Imports Sem_Manager
Public Class clsTransaction_MP3

    Private objLocalConfig As clsLocalConfig

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Real As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_RealTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHAR255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_TokenToken As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private objSemItem_MediaItem As clsSemItem
    Private objSemItem_MP3 As clsSemItem
    Private objSemItem_Album As clsSemItem
    Private objSemItem_Artist As clsSemItem
    Private objSemItem_Genre As clsSemItem
    Private objSemItem_Media As clsSemItem
    Private objSemItem_Partner As clsSemItem
    Private objSemItem_Year As clsSemItem
    Private strTitle As String
    Private strComment As String
    Private dblLength As Double

    Private objSemItem_TokenAttribute_Title As clsSemItem
    Private objSemItem_TokenAttribute_Comment As clsSemItem
    Private objSemItem_TokenAttribute_Length As clsSemItem

    Public ReadOnly Property SemItem_MP3 As clsSemItem
        Get
            Return objSemItem_MP3
        End Get
    End Property

    Public Function save_001_MP3(ByVal SemItem_MediaItem As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_MP3 As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objSemItem_MediaItem = SemItem_MediaItem

        objDRC_MP3 = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_MediaItem.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                   objLocalConfig.SemItem_Type_mp3_File.GUID).Rows
        If objDRC_MP3.Count = 0 Then
            objSemItem_MP3 = New clsSemItem
            objSemItem_MP3.GUID = Guid.NewGuid
            objSemItem_MP3.Name = objSemItem_MediaItem.Name
            objSemItem_MP3.GUID_Parent = objLocalConfig.SemItem_Type_mp3_File.GUID
            objSemItem_MP3.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_MP3.GUID, _
                                                                 objSemItem_MP3.Name, _
                                                                 objSemItem_MP3.GUID_Parent, True).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_MP3 = New clsSemItem
            objSemItem_MP3.GUID = objDRC_MP3(0).Item("GUID_Token_Left")
            objSemItem_MP3.Name = objDRC_MP3(0).Item("Name_Token_Left")
            objSemItem_MP3.GUID_Parent = objLocalConfig.SemItem_Type_mp3_File.GUID
            objSemItem_MP3.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_MP3(Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If


        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_MP3.GUID).Rows
        If Not objDRC_LogState(0).Item("GUId_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_MediaItem_To_MP3(Optional ByVal SemItem_MediaItem As clsSemItem = Nothing, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_MP3 As DataRowCollection
        Dim objDR_MP3 As DataRow

        If Not SemItem_MediaItem Is Nothing Then
            objSemItem_MediaItem = SemItem_MediaItem
        End If


        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        objDRC_MP3 = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_MediaItem.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                   objLocalConfig.SemItem_Type_mp3_File.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_MP3 In objDRC_MP3
            If objDR_MP3.Item("GUID_Token_Left") = objSemItem_MP3.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDR_MP3.Item("GUID_Token_Left"), _
                                                                       objSemItem_MediaItem.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objSemItem_MediaItem.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_MediaItem_To_MP3(Optional ByVal SemItem_MediaItem As clsSemItem = Nothing, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_MP3 As DataRowCollection
        Dim objDR_MP3 As DataRow

        If Not SemItem_MediaItem Is Nothing Then
            objSemItem_MediaItem = SemItem_MediaItem
        End If

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        objDRC_MP3 = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_MediaItem.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                   objLocalConfig.SemItem_Type_mp3_File.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_MP3 In objDRC_MP3
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDR_MP3.Item("GUID_Token_Left"), _
                                                                   objSemItem_MediaItem.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next


        Return objSemItem_Result
    End Function

    Public Function save_003_MP3__Title(ByVal strTitle As String, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Title As DataRowCollection
        Dim objDR_Title As DataRow

        Me.strTitle = strTitle

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        objDRC_Title = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_MP3.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_Titel.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Title In objDRC_Title
            If objDR_Title.Item("Val_VARCHAR255") = strTitle Then
                objSemItem_TokenAttribute_Title = New clsSemItem
                objSemItem_TokenAttribute_Title.GUID = objDR_Title.Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Title.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_MP3.GUID, _
                                                                                     objLocalConfig.SemItem_Attribute_Titel.GUID, _
                                                                                     Nothing, strTitle, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_MP3__Title(Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Title As DataRowCollection
        Dim objDR_Title As DataRow

        Me.strTitle = strTitle

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        objDRC_Title = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_MP3.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_Titel.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Title In objDRC_Title
            
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Title.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next


        Return objSemItem_Result
    End Function

    Public Function save_004_MP3__Comment(ByVal strComment As String, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Comment As DataRowCollection
        Dim objDR_Comment As DataRow

        Me.strComment = strComment

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        objDRC_Comment = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_MP3.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_comment.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Comment In objDRC_Comment
            If objDR_Comment.Item("Val_VARCHAR255") = strComment Then
                objSemItem_TokenAttribute_Comment = New clsSemItem
                objSemItem_TokenAttribute_Comment.GUID = objDR_Comment.Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Comment.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_MP3.GUID, _
                                                                                     objLocalConfig.SemItem_Attribute_comment.GUID, _
                                                                                     Nothing, strComment, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_MP3__Comment(Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Comment As DataRowCollection
        Dim objDR_Comment As DataRow


        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        objDRC_Comment = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_MP3.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_comment.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Comment In objDRC_Comment

            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Comment.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next


        Return objSemItem_Result
    End Function

    Public Function save_005_MP3__Length(ByVal dblLength As Double, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Length As DataRowCollection
        Dim objDR_Length As DataRow

        Me.dblLength = dblLength

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        objDRC_Length = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_MP3.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_L_nge__Minuten_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Length In objDRC_Length
            If objDR_Length.Item("Val_Real") = dblLength Then
                objSemItem_TokenAttribute_Length = New clsSemItem
                objSemItem_TokenAttribute_Length.GUID = objDR_Length.Item("GUID_TokenAttribte")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Length.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Real.GetData(objSemItem_MP3.GUID, _
                                                                                     objLocalConfig.SemItem_Attribute_L_nge__Minuten_.GUID, _
                                                                                     Nothing, dblLength, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_MP3__Length(Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Length As DataRowCollection
        Dim objDR_Length As DataRow



        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        objDRC_Length = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_MP3.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_L_nge__Minuten_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Length In objDRC_Length

            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Length.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next


        Return objSemItem_Result
    End Function

    Public Function save_006_MP3_To_Album(ByVal SemItem_Album As clsSemItem, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Album As DataRowCollection
        Dim objDR_Album As DataRow

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        objSemItem_Album = SemItem_Album

        objDRC_Album = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Album.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_from.GUID, _
                                                                     objLocalConfig.SemItem_Type_Album.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Album In objDRC_Album
            If objDR_Album.Item("GUID_Token_Right") = objSemItem_Album.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                       objDR_Album.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_from.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objSemItem_Album.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_from.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_006_MP3_To_Album(Optional ByVal SemItem_Album As clsSemItem = Nothing, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Album As DataRowCollection
        Dim objDR_Album As DataRow

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If
        If Not SemItem_Album Is Nothing Then
            objSemItem_Album = SemItem_Album
        End If


        objDRC_Album = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Album.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_from.GUID, _
                                                                     objLocalConfig.SemItem_Type_Album.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Album In objDRC_Album
            
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objDR_Album.Item("GUID_Token_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_from.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        
        Return objSemItem_Result
    End Function

    Public Function save_007_MP3_To_Artist(ByVal SemItem_Artist As clsSemItem, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Artist As DataRowCollection
        Dim objDR_Artist As DataRow

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        objSemItem_Artist = SemItem_Artist

        objDRC_Artist = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Artist.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_Artist.GUID, _
                                                                     objLocalConfig.SemItem_Type_Band.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Artist In objDRC_Artist
            If objDR_Artist.Item("GUID_Token_Right") = objSemItem_Artist.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                       objDR_Artist.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_Artist.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objSemItem_Artist.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_Artist.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_007_MP3_To_Artist(Optional ByVal SemItem_Artist As clsSemItem = Nothing, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Artist As DataRowCollection
        Dim objDR_Artist As DataRow

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If
        If Not SemItem_Artist Is Nothing Then
            objSemItem_Artist = SemItem_Artist
        End If


        objDRC_Artist = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Artist.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_Artist.GUID, _
                                                                     objLocalConfig.SemItem_Type_Band.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Artist In objDRC_Artist

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objDR_Artist.Item("GUID_Token_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_Artist.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next


        Return objSemItem_Result
    End Function

    Public Function save_008_Genre(ByVal SemItem_Genre As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Genre As DataRowCollection

        objSemItem_Genre = SemItem_Genre

        objDRC_Genre = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_Genre.GUID, _
                                                                        objSemItem_Genre.Name).Rows
        If objDRC_Genre.Count = 0 Then
            objSemItem_Genre.GUID = Guid.NewGuid
        Else
            objSemItem_Genre.GUID = objDRC_Genre(0).Item("GUID_Token")
        End If

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Genre.GUID, _
                                                             objSemItem_Genre.Name, _
                                                             objSemItem_Genre.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_008_Genre(Optional ByVal SemItem_Genre As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Genre Is Nothing Then
            objSemItem_Genre = SemItem_Genre
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Genre.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID _
            And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_009_MP3_To_Genre(Optional ByVal SemItem_Genre As clsSemItem = Nothing, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Genre As DataRowCollection
        Dim objDR_Genre As DataRow

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        If Not SemItem_Genre Is Nothing Then
            objSemItem_Genre = SemItem_Genre
        End If


        objDRC_Genre = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Genre.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                     objLocalConfig.SemItem_Type_Genre.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Genre In objDRC_Genre
            If objDR_Genre.Item("GUID_Token_Right") = objSemItem_Genre.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                       objDR_Genre.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objSemItem_Genre.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_009_MP3_To_Genre(Optional ByVal SemItem_Genre As clsSemItem = Nothing, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Genre As DataRowCollection
        Dim objDR_Genre As DataRow

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If
        If Not SemItem_Genre Is Nothing Then
            objSemItem_Genre = SemItem_Genre
        End If


        objDRC_Genre = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Genre.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                     objLocalConfig.SemItem_Type_Genre.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Genre In objDRC_Genre

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objDR_Genre.Item("GUID_Token_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next


        Return objSemItem_Result
    End Function


    Public Function save_010_MP3_To_Media(ByVal SemItem_Media As clsSemItem, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Media As DataRowCollection
        Dim objDR_Media As DataRow

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        objSemItem_Media = SemItem_Media

        objDRC_Media = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Media.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_Disc.GUID, _
                                                                     objLocalConfig.SemItem_Type_Media.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Media In objDRC_Media
            If objDR_Media.Item("GUID_Token_Right") = objSemItem_Media.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                       objDR_Media.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_Disc.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objSemItem_Media.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_Disc.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_010_MP3_To_Media(Optional ByVal SemItem_Media As clsSemItem = Nothing, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Media As DataRowCollection
        Dim objDR_Media As DataRow

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If
        If Not SemItem_Media Is Nothing Then
            objSemItem_Media = SemItem_Media
        End If


        objDRC_Media = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Media.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_Disc.GUID, _
                                                                     objLocalConfig.SemItem_Type_Media.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Media In objDRC_Media

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objDR_Media.Item("GUID_Token_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_Disc.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next


        Return objSemItem_Result
    End Function

    Public Function save_011_Partner(ByVal SemItem_Partner As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Partner = SemItem_Partner

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Partner.GUID, _
                                                             objSemItem_Partner.Name, _
                                                             objSemItem_Partner.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_011_Partner(Optional ByVal SemItem_Partner As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Partner Is Nothing Then
            objSemItem_Partner = SemItem_Partner
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Partner.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID _
            And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_012_MP3_To_Partner(Optional ByVal SemItem_Partner As clsSemItem = Nothing, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Partner As DataRowCollection
        Dim objDR_Partner As DataRow

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If


        If Not SemItem_Partner Is Nothing Then
            objSemItem_Partner = SemItem_Partner
        End If


        objDRC_Partner = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_MP3.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_Composer.GUID, _
                                                                     objLocalConfig.SemItem_Type_Partner.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Partner In objDRC_Partner
            If objDR_Partner.Item("GUID_Token_Right") = objSemItem_Partner.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                       objDR_Partner.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_Composer.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objSemItem_Partner.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_Composer.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objDRC_Partner = semtblA_TokenToken.GetData_By_GUIDs(objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                     objSemItem_Partner.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_Composer.GUID).Rows
                If objDRC_Partner.Count = 0 Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                            objSemItem_Partner.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_Composer.GUID, 1).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                End If

            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_012_MP3_To_Partner(Optional ByVal SemItem_Partner As clsSemItem = Nothing, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Partner As DataRowCollection
        Dim objDR_Partner As DataRow

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If
        If Not SemItem_Partner Is Nothing Then
            objSemItem_Partner = SemItem_Partner
        End If


        objDRC_Partner = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Partner.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_Composer.GUID, _
                                                                     objLocalConfig.SemItem_Type_Partner.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Partner In objDRC_Partner

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objDR_Partner.Item("GUID_Token_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_Composer.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next


        Return objSemItem_Result
    End Function

    Public Function save_013_Year(ByVal SemItem_Year As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Year As DataRowCollection

        objSemItem_Year = SemItem_Year

        objDRC_Year = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_Year.GUID, _
                                                                       objSemItem_Year.Name).Rows
        If objDRC_Year.Count = 0 Then
            objSemItem_Year.GUID = Guid.NewGuid
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Year.GUID, _
                                                                 objSemItem_Year.Name, _
                                                                 objSemItem_Year.GUID_Parent, True).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Year.GUID = objDRC_Year(0).Item("GUID_Token")
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If



        Return objSemItem_Result
    End Function

    Public Function del_013_Year(Optional ByVal SemItem_Year As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Year Is Nothing Then
            objSemItem_Year = SemItem_Year
        End If


        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Year.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID _
            And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_014_MP3_To_Year(Optional ByVal SemItem_Year As clsSemItem = Nothing, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Year As DataRowCollection
        Dim objDR_Year As DataRow

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If

        If Not SemItem_Year Is Nothing Then
            objSemItem_Year = SemItem_Year
        End If


        objDRC_Year = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Year.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_from.GUID, _
                                                                     objLocalConfig.SemItem_Type_Year.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Year In objDRC_Year
            If objDR_Year.Item("GUID_Token_Right") = objSemItem_Year.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                       objDR_Year.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_from.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objSemItem_Year.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_from.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_014_MP3_To_Year(Optional ByVal SemItem_Year As clsSemItem = Nothing, Optional ByVal SemItem_MP3 As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Year As DataRowCollection
        Dim objDR_Year As DataRow

        If Not SemItem_MP3 Is Nothing Then
            objSemItem_MP3 = SemItem_MP3
        End If
        If Not SemItem_Year Is Nothing Then
            objSemItem_Year = SemItem_Year
        End If


        objDRC_Year = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Year.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_from.GUID, _
                                                                     objLocalConfig.SemItem_Type_Year.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Year In objDRC_Year

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MP3.GUID, _
                                                                    objDR_Year.Item("GUID_Token_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_from.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next


        Return objSemItem_Result
    End Function

    



    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Real.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHAR255.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB

        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
