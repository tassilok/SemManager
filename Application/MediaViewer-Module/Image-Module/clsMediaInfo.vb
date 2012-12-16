Imports Sem_Manager
Imports Filesystem_Management
Public Class clsMediaInfo
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_OR_Token As New ds_SemDBTableAdapters.semtbl_OR_TokenTableAdapter
    Private semtblA_OR_Type As New ds_SemDBTableAdapters.semtbl_OR_TypeTableAdapter
    Private semtblA_OR_Attribute As New ds_SemDBTableAdapters.semtbl_OR_AttributeTableAdapter
    Private semtblA_OR_RelationType As New ds_SemDBTableAdapters.semtbl_OR_RelationTypeTableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private procA_MediaItems_And_Files As New ds_ImageModuleTableAdapters.proc_MediaItems_And_FilesTableAdapter

    Private procA_Composer As New ds_ImageModuleTableAdapters.proc_ComposerTableAdapter

    Private objLocalConfig As clsLocalConfig

    Private objTransaction_MP3 As clsTransaction_MP3

    Private objBlobConnection As clsBlobConnection
    Private objMP3Info As clsMP3Info

    Public ReadOnly Property SemItem_Image As clsSemItem
        Get
            Return objLocalConfig.SemItem_Type_Images__Graphic_
        End Get
    End Property

    Public ReadOnly Property SemItem_MediaItem As clsSemItem
        Get
            Return objLocalConfig.SemItem_Type_Media_Item
        End Get
    End Property

    Public ReadOnly Property SemItem_PDF As clsSemItem
        Get
            Return objLocalConfig.SemItem_Type_PDF_Documents
        End Get
    End Property

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)

        set_DBConnection()
    End Sub

    Public Function count_Media_Of_Ref(ByVal objSemItem_Ref As clsSemItem, ByVal objSemItem_MediaType As clsSemItem) As Integer
        Dim objDRC_Count As DataRowCollection
        Dim objDRC_OR As DataRowCollection
        Dim intResult As Integer = 0

        Select Case objSemItem_Ref.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objDRC_OR = semtblA_OR_Attribute.GetData_By_GUIDAttribute(objSemItem_Ref.GUID).Rows
                intResult = objDRC_OR.Count
            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objDRC_OR = semtblA_OR_RelationType.GetData_By_GUIDRelationType(objSemItem_Ref.GUID).Rows()
                intResult = objDRC_OR.Count
            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_OR = semtblA_OR_Token.GetData_By_GUIDToken(objSemItem_Ref.GUID).Rows
                intResult = objDRC_OR.Count
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objDRC_OR = semtblA_OR_Type.GetData_By_GUIDType(objSemItem_Ref.GUID).Rows
                intResult = objDRC_OR.Count
        End Select
        If intResult > 0 Then
            objDRC_Count = funcA_Token_OR.GetData_By_GUIDOR_And_GUIDRelType_And_GUIDType(objSemItem_MediaType.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objDRC_OR(0).Item("GUID_ObjectReference")).Rows
            intResult = objDRC_Count.Count
        End If

        Return intResult
    End Function

    Public Sub start_Getting_Meta()
        Dim objDRC_MediaItems As DataRowCollection
        Dim objDR_MediaItem As DataRow
        Dim objSemItem_MediaItem As New clsSemItem
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim strPath_Blob As String
        Dim intToDo As Integer
        Dim intDone As Integer

        objDRC_MediaItems = procA_MediaItems_And_Files.GetData(objLocalConfig.SemItem_Type_Media_Item.GUID, _
                                                       objLocalConfig.SemItem_Type_File.GUID, _
                                                       objLocalConfig.SemItem_RelationType_belonging_Source.GUID).Rows

        intToDo = objDRC_MediaItems.Count
        intDone = 0
        For Each objDR_MediaItem In objDRC_MediaItems
            objSemItem_MediaItem.GUID = objDR_MediaItem.Item("GUID_Media_Item")
            objSemItem_MediaItem.Name = objDR_MediaItem.Item("Name_Media_Item")
            objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
            objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_File.GUID = objDR_MediaItem.Item("GUID_File")
            objSemItem_File.Name = objDR_MediaItem.Item("Name_File")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            strPath_Blob = Environment.ExpandEnvironmentVariables("%Temp%") & "\" & objSemItem_File.Name

            objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath_Blob)

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = get_Meta(objSemItem_MediaItem, objSemItem_File, strPath_Blob)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If
            End If
            Try
                IO.File.Delete(strPath_Blob)
            Catch ex As Exception

            End Try

        Next
    End Sub

    Public Function get_Meta(ByVal objSemItem_MediaItem As clsSemItem, ByVal objSemItem_File As clsSemItem, Optional ByVal strPath_Blob As String = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objFile As IO.FileInfo
        Dim objDRC_File As DataRowCollection
        Dim objMP3File As Mp3Lib.Mp3File
        Dim objDRC_Ref As DataRowCollection
        Dim objSemItem_Partner As New clsSemItem
        Dim objSemItem_Genre As New clsSemItem
        Dim objSemItem_Year As New clsSemItem
        Dim strTag As String
        Dim strATag() As String
        Dim objID3V1 As ID3V1

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If strPath_Blob = Nothing Then
            objDRC_File = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_MediaItem.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                        objLocalConfig.SemItem_Type_File.GUID).Rows
            If objDRC_File.Count > 0 Then
                strPath_Blob = Environment.ExpandEnvironmentVariables("%Temp%") & "\" & Guid.NewGuid.ToString & "." & objLocalConfig.SemItem_Token_Extensions_Image.Name
                objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath_Blob)
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

            objFile = New IO.FileInfo(strPath_Blob)
            Select Case objFile.Extension.ToLower
                Case ".mp3"
                    Try
                        objID3V1 = objMP3Info.GetID3v1Tag(strPath_Blob)

                        'objMP3File = New Mp3Lib.Mp3File(strPath_Blob)
                        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_MP3.save_002_MediaItem_To_MP3()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                strTag = objID3V1.Title
                                'strTag = objMP3File.TagHandler.Title
                                If strTag <> "" Then
                                    objSemItem_Result = objTransaction_MP3.save_003_MP3__Title(strTag)
                                End If

                                strTag = objID3V1.Comment
                                'strTag = objMP3File.TagHandler.Comment
                                If strTag <> "" Then
                                    objSemItem_Result = objTransaction_MP3.save_004_MP3__Comment(strTag)
                                End If

                                'strTag = objMP3File.TagHandler.Length.ToString
                                'If strTag <> "" Then
                                '    objSemItem_Result = objTransaction_MP3.save_005_MP3__Length(strTag)
                                'End If

                                strTag = objID3V1.Artist
                                'strTag = objMP3File.TagHandler.Composer
                                If strTag <> "" Then
                                    strATag = strTag.Split(";")

                                    For Each strTag In strATag
                                        objDRC_Ref = procA_Composer.GetData(objLocalConfig.SemItem_Type_Partner.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_Composer.GUID, _
                                                                        objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                        strTag).Rows
                                        If objDRC_Ref.Count = 0 Then
                                            objSemItem_Partner.GUID = Guid.NewGuid
                                            objSemItem_Partner.Name = strTag
                                            objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                                            objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                            objSemItem_Result = objTransaction_MP3.save_011_Partner(objSemItem_Partner)

                                        Else
                                            objSemItem_Partner.GUID = objDRC_Ref(0).Item("GUID_Partner")
                                            objSemItem_Partner.Name = objDRC_Ref(0).Item("Name_Partner")
                                            objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                                            objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                        End If

                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_MP3.save_012_MP3_To_Partner(objSemItem_Partner)
                                        End If
                                    Next


                                End If


                            End If


                            strTag = objID3V1.GenreName
                            'strTag = objMP3File.TagHandler.Genre.ToString
                            If strTag <> "0" Then
                                strATag = strTag.Split(";")
                                For Each strTag In strATag
                                    objSemItem_Genre.Name = strTag
                                    objSemItem_Result = objTransaction_MP3.save_008_Genre(objSemItem_Genre)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_MP3.save_009_MP3_To_Genre(objSemItem_Genre)
                                    End If

                                Next
                            End If

                            strTag = objID3V1.Year
                            'strTag = objMP3File.TagHandler.Year.ToString
                            If strTag <> "" Then
                                objSemItem_Year.Name = strTag
                                objSemItem_Year.GUID_Parent = objLocalConfig.SemItem_Type_Year.GUID
                                objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objSemItem_Result = objTransaction_MP3.save_013_Year(objSemItem_Year)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_MP3.save_014_MP3_To_Year

                                End If
                            End If
                        Else

                        End If
                    Catch ex As Exception
                        'Stop
                    End Try
                Case ".mod"
                Case ".wav"
                Case ".avi"

            End Select
            

        End If


        Return objSemItem_Result
    End Function

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_OR_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_OR_RelationType.Connection = objLocalConfig.Connection_DB
        semtblA_OR_Token.Connection = objLocalConfig.Connection_DB
        semtblA_OR_Type.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
        procA_Composer.Connection = objLocalConfig.Connection_Plugin
        procA_MediaItems_And_Files.Connection = objLocalConfig.Connection_Plugin

        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
        objTransaction_MP3 = New clsTransaction_MP3(objLocalConfig)
        objMP3Info = New clsMP3Info(objLocalConfig)
    End Sub

End Class
