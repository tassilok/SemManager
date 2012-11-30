Imports Sem_Manager
Imports ClassLibrary_ShellWork
Public Class clsFileWork

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level As New ds_TokenTableAdapters.func_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_LevelTableAdapter
    Private funcT_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level As New ds_Token.func_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_LevelDataTable
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private procA_PathToWatch_Of_BaseConfig As New ds_FilesystemManagementTableAdapters.proc_PathToWatch_Of_BaseConfigTableAdapter

    Private procA_File_OutChecked As New ds_FilesystemManagementTableAdapters.proc_File_OutCheckedTableAdapter

    Private objSemItem_Server As clsSemItem
    Private strPathToWatch As String

    Private objTransaction_FileSystemObject As clsTransaction_Insert_FileSystemObject
    Private objBlobConnection As clsBlobConnection
    Private objShellWork As clsShellWork
    Private objFrmBlobWatcher As frmBlobWatcher

    Private strSeperator As String
    Private boolBlob As Boolean

    Public ReadOnly Property PathToWatch As String
        Get
            Return strPathToWatch
        End Get
    End Property
    
    Public ReadOnly Property SemItem_Server() As clsSemItem
        Get
            Return objSemItem_Server
        End Get
    End Property
    Public Function get_Path_FileSystemObject(ByVal objSemItem_FileSystemObject As clsSemItem, Optional ByVal boolBlobPath As Boolean = True) As String
        Dim strPath As String = ""
        Dim objDRC_Rel As DataRowCollection
        Dim objDRC_Blob As DataRowCollection
        Dim objDR_Folder As DataRow
        Dim GUID_Folder_L1 As Guid

        boolBlob = False
        strSeperator = "\"
        Select Case objSemItem_FileSystemObject.GUID_Parent
            Case objLocalConfig.SemItem_Type_Server.GUID
                strPath = strSeperator & strSeperator & objSemItem_FileSystemObject.Name
                objSemItem_Server = objSemItem_FileSystemObject
            Case objLocalConfig.SemItem_Type_Drive.GUID
                objDRC_Rel = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FileSystemObject.GUID, objLocalConfig.SemItem_RelationType_isSubordinated.GUID, objLocalConfig.SemItem_Type_Server.GUID).Rows
                If objDRC_Rel.Count > 0 Then

                    strPath = objSemItem_FileSystemObject.Name & ":"

                    objSemItem_Server = New clsSemItem
                    objSemItem_Server.GUID = objDRC_Rel(0).Item("GUID_Token_Right")
                    objSemItem_Server.Name = objDRC_Rel(0).Item("Name_Token_Right")
                    objSemItem_Server.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                    objSemItem_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                Else
                    strPath = objSemItem_FileSystemObject.Name & ":"
                    objSemItem_Server = Nothing
                End If
            Case objLocalConfig.SemItem_type_Folder.GUID

                funcA_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level.Fill(funcT_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level, _
                                                                                          objSemItem_FileSystemObject.GUID, _
                                                                                          objLocalConfig.SemItem_type_Folder.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                                          objLocalConfig.Globals.GUID_Direction_LeftRight, 0, 1)

                For Each objDR_Folder In funcT_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level.Rows
                    strPath = objDR_Folder.Item("Name_Token_Rel") & "\" & strPath
                Next

                If Not strPath.EndsWith("\") And Not objSemItem_FileSystemObject.Name.StartsWith("\") Then
                    strPath = strPath & "\"
                End If
                strPath = strPath & objSemItem_FileSystemObject.Name

                If Not funcT_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level.Rows.Count = 0 Then
                    objDR_Folder = funcT_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level.Rows(funcT_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level.Rows.Count - 1)
                    GUID_Folder_L1 = objDR_Folder.Item("GIUD_Token_Rel")
                Else
                    GUID_Folder_L1 = objSemItem_FileSystemObject.GUID
                End If

                objDRC_Rel = funcA_TokenToken.GetData_TokenToken_LeftRight(GUID_Folder_L1, objLocalConfig.SemItem_RelationType_isSubordinated.GUID, objLocalConfig.SemItem_Type_Drive.GUID).Rows
                If objDRC_Rel.Count > 0 Then
                    If objDRC_Rel(0).Item("Name_Token_Right").ToString.EndsWith(":") Then
                        strPath = objDRC_Rel(0).Item("Name_Token_Right") & "\" & strPath
                    Else
                        strPath = objDRC_Rel(0).Item("Name_Token_Right") & ":" & strPath
                    End If

                    objDRC_Rel = funcA_TokenToken.GetData_TokenToken_LeftRight(objDRC_Rel(0).Item("GUID_Token_Right"), objLocalConfig.SemItem_RelationType_isSubordinated.GUID, objLocalConfig.SemItem_Type_Server.GUID).Rows
                    If objDRC_Rel.Count > 0 Then
                        objSemItem_Server = New clsSemItem
                        objSemItem_Server.GUID = objDRC_Rel(0).Item("GUID_Token_Right")
                        objSemItem_Server.Name = objDRC_Rel(0).Item("Name_Token_Right")
                        objSemItem_Server.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                        objSemItem_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    Else
                        objSemItem_Server = Nothing
                    End If
                Else
                    objDRC_Rel = funcA_TokenToken.GetData_TokenToken_RightLeft(GUID_Folder_L1, objLocalConfig.SemItem_RelationType_Fileshare.GUID, objLocalConfig.SemItem_Type_Server.GUID).Rows
                    If objDRC_Rel.Count > 0 Then

                        objSemItem_Server = New clsSemItem
                        objSemItem_Server.GUID = objDRC_Rel(0).Item("GUID_Token_Left")
                        objSemItem_Server.Name = objDRC_Rel(0).Item("Name_Token_Left")
                        objSemItem_Server.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                        objSemItem_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        If Not strPath.StartsWith("\") And Not objSemItem_Server.Name.EndsWith("\") Then
                            strPath = "\" & strPath
                        End If
                        strPath = strSeperator & strSeperator & objSemItem_Server.Name & strPath
                    Else
                        objSemItem_Server = Nothing
                    End If
                End If
            Case objLocalConfig.SemItem_Type_File.GUID
                objDRC_Blob = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_FileSystemObject.GUID, _
                                                                                                             objLocalConfig.SemItem_Attribute_Blob.GUID).Rows
                If objDRC_Blob.Count > 0 And boolBlobPath = True Then
                    objSemItem_Server = Nothing
                    strPath = objLocalConfig.Globals.DB_Name_User & "@" & objLocalConfig.Globals.Server_Name & ":" & objSemItem_FileSystemObject.GUID.ToString & ":" & objSemItem_FileSystemObject.Name
                    boolBlob = True
                Else
                    objDRC_Rel = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FileSystemObject.GUID, objLocalConfig.SemItem_RelationType_isSubordinated.GUID, objLocalConfig.SemItem_type_Folder.GUID).Rows
                    If objDRC_Rel.Count > 0 Then
                        strPath = objDRC_Rel(0).Item("Name_Token_Right")
                        funcA_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level.Fill(funcT_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level, _
                                                                                              objDRC_Rel(0).Item("GUID_Token_Right"), _
                                                                                              objLocalConfig.SemItem_type_Folder.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                                              objLocalConfig.Globals.GUID_Direction_LeftRight, 0, 1)

                        For Each objDR_Folder In funcT_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level.Rows
                            If Not strPath.StartsWith("\") And Not objDR_Folder.Item("Name_Token_Rel").ToString.EndsWith("\") Then
                                strPath = "\" & strPath
                            End If
                            strPath = objDR_Folder.Item("Name_Token_Rel") & strPath
                        Next

                        If Not strPath.EndsWith("\") And Not objSemItem_FileSystemObject.Name.StartsWith("\") Then
                            strPath = strPath & "\"
                        End If
                        strPath = strPath & objSemItem_FileSystemObject.Name
                        If Not funcT_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level.Rows.Count = 0 Then
                            objDR_Folder = funcT_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level.Rows(funcT_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level.Rows.Count - 1)
                            GUID_Folder_L1 = objDR_Folder.Item("GIUD_Token_Rel")
                        Else
                            GUID_Folder_L1 = objSemItem_FileSystemObject.GUID
                        End If

                        objDRC_Rel = funcA_TokenToken.GetData_TokenToken_LeftRight(GUID_Folder_L1, objLocalConfig.SemItem_RelationType_isSubordinated.GUID, objLocalConfig.SemItem_Type_Drive.GUID).Rows
                        If objDRC_Rel.Count > 0 Then
                            If objDRC_Rel(0).Item("Name_Token_Right").ToString.EndsWith(":") Then
                                strPath = objDRC_Rel(0).Item("Name_Token_Right") & "\" & strPath
                            Else
                                strPath = objDRC_Rel(0).Item("Name_Token_Right") & ":" & strPath
                            End If

                            objDRC_Rel = funcA_TokenToken.GetData_TokenToken_LeftRight(objDRC_Rel(0).Item("GUID_Token_Right"), objLocalConfig.SemItem_RelationType_isSubordinated.GUID, objLocalConfig.SemItem_Type_Server.GUID).Rows
                            If objDRC_Rel.Count > 0 Then
                                objSemItem_Server = New clsSemItem
                                objSemItem_Server.GUID = objDRC_Rel(0).Item("GUID_Token_Right")
                                objSemItem_Server.Name = objDRC_Rel(0).Item("Name_Token_Right")
                                objSemItem_Server.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                                objSemItem_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            Else
                                objSemItem_Server = Nothing
                            End If
                        Else
                            objDRC_Rel = funcA_TokenToken.GetData_TokenToken_RightLeft(GUID_Folder_L1, objLocalConfig.SemItem_RelationType_Fileshare.GUID, objLocalConfig.SemItem_Type_Server.GUID).Rows
                            If objDRC_Rel.Count > 0 Then

                                objSemItem_Server = New clsSemItem
                                objSemItem_Server.GUID = objDRC_Rel(0).Item("GUID_Token_Left")
                                objSemItem_Server.Name = objDRC_Rel(0).Item("Name_Token_Left")
                                objSemItem_Server.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                                objSemItem_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                strPath = strSeperator & strSeperator & objSemItem_Server.Name & strSeperator & strPath
                            Else
                                objSemItem_Server = Nothing
                            End If
                        End If
                    Else
                        strPath = objSemItem_FileSystemObject.Name
                        objSemItem_Server = Nothing

                    End If
                End If

        End Select
        Return strPath
    End Function

    Public Function save_Path_Of_FileSystemObject(ByVal objSemItem_FileSystemObject As clsSemItem) As clsSemItem
        Dim objDRC_Server As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Extension As clsSemItem = Nothing
        Dim objSemItem_Child As New clsSemItem
        Dim strPath As String
        Dim strA_Path() As String
        Dim intOffset As Integer
        Dim i As Integer
        Dim boolUNC As Boolean

        strPath = objSemItem_FileSystemObject.Additional1

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If strPath.StartsWith("\\") Then
            strPath = strPath.Substring(2)

            boolUNC = True
        ElseIf strPath.Substring(1, 1) = ":" Then


            boolUNC = False
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            strA_Path = strPath.Split("\")
            If objSemItem_FileSystemObject.Name.Contains(".") Then
                objSemItem_Extension = New clsSemItem
                objSemItem_Extension.Name = objSemItem_FileSystemObject.Name.Substring(objSemItem_FileSystemObject.Name.LastIndexOf(".") + 1)

            End If
            If boolUNC = True Then
                objSemItem_Server = New clsSemItem
                objSemItem_Server.Name = strA_Path(0)

            Else
                objSemItem_Server = New clsSemItem
                objSemItem_Server.Name = Environment.MachineName

            End If
            objSemItem_Result = objTransaction_FileSystemObject.save_001_Server(objSemItem_Server)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                
                If boolUNC = True Then
                    objSemItem_Child.Name = strA_Path(1)
                    objSemItem_Result = objTransaction_FileSystemObject.save_002_Folder(objSemItem_Child)
                    intOffset = 2
                Else
                    objSemItem_Child.Name = strA_Path(0)
                    objSemItem_Result = objTransaction_FileSystemObject.save_002_Drive(objSemItem_Child)
                    intOffset = 1
                End If

                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_FileSystemObject.save_003_Parent_To_Child
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Child.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
                        For i = intOffset To strA_Path.Length - 2
                            objSemItem_Child.Name = strA_Path(i)
                            objSemItem_Result = objTransaction_FileSystemObject.save_002_Folder(objSemItem_Child)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_FileSystemObject.save_003_Parent_To_Child
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                    'Fehler: Rollback
                                    Exit For
                                End If
                            Else

                                'Fehler: Rollback
                                Exit For
                            End If
                        Next
                        If objSemItem_FileSystemObject.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID Then
                            objSemItem_Child.Name = strA_Path(strA_Path.Length - 1)
                            objSemItem_Result = objTransaction_FileSystemObject.save_004_File(objSemItem_Child)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_FileSystemObject.save_005_File_To_Folder
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    If Not objSemItem_Extension Is Nothing Then
                                        objSemItem_Result = objTransaction_FileSystemObject.save_006_FileExtension(objSemItem_Extension)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_FileSystemObject.save_007_File_To_Extension
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                                'Fehler:Rollback
                                            End If
                                        Else
                                            'Fehler:Rollback
                                        End If
                                    End If
                                Else
                                    'Fehler:Rollback
                                End If

                            Else
                                'Fehler:Rollback
                            End If
                        Else
                            objSemItem_Child.Name = strA_Path(strA_Path.Length - 1)
                            objSemItem_Result = objTransaction_FileSystemObject.save_002_Folder(objSemItem_Child)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_FileSystemObject.save_003_Parent_To_Child
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                    'Fehler: Rollback
                                End If
                            Else
                                'Fehler:Rollback

                            End If
                        End If
                    Else
                        'Fehler:Rollback
                    End If
                    
                Else
                    'Fehler
                End If

                
            End If

        End If

        Return objSemItem_Result
    End Function

    Public Function open_FileSystemObject(ByVal objSemItem_FileSystemObject As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem


        Select Case objSemItem_FileSystemObject.GUID_Parent
            Case objLocalConfig.SemItem_Type_Drive.GUID
                objSemItem_FileSystemObject.Additional1 = get_Path_FileSystemObject(objSemItem_FileSystemObject)
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                objShellWork.start_Process(objSemItem_FileSystemObject.Additional1, Nothing, Nothing, False, False)
            Case objLocalConfig.SemItem_type_Folder.GUID
                objSemItem_FileSystemObject.Additional1 = get_Path_FileSystemObject(objSemItem_FileSystemObject)
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                objShellWork.start_Process(objSemItem_FileSystemObject.Additional1, Nothing, Nothing, False, False)
            Case objLocalConfig.SemItem_Type_File.GUID
                objSemItem_FileSystemObject.Additional1 = get_Path_FileSystemObject(objSemItem_FileSystemObject)
                If boolBlob = True Then
                    objSemItem_Result = open_BlobFile(objSemItem_FileSystemObject)
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    objShellWork.start_Process(objSemItem_FileSystemObject.Additional1, Nothing, Nothing, False, False)
                End If
            Case Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                objSemItem_Result.Additional1 = "Beim Öffnen ist ein Fehler aufgetreten!"
        End Select

        Return objSemItem_Result
    End Function

    Public Function get_Path_to_Watch() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Path As DataRowCollection

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_Path = procA_PathToWatch_Of_BaseConfig.GetData(objLocalConfig.SemItem_Type_BlobDirWatcher.GUID, _
                                                              objLocalConfig.SemItem_Type_Path.GUID, _
                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                              objLocalConfig.SemItem_RelationType_watch.GUID, _
                                                              objLocalConfig.SemItem_BaseConfig.GUID).Rows
        If objDRC_Path.Count > 0 Then
            strPathToWatch = objDRC_Path(0).Item("Name_Path")
            If strPathToWatch.EndsWith("\") Then
                strPathToWatch = strPathToWatch & objDRC_Path(0).Item("GUID_Path").ToString
            Else
                strPathToWatch = strPathToWatch & "\" & objDRC_Path(0).Item("GUID_Path").ToString
            End If
            strPathToWatch = Environment.ExpandEnvironmentVariables(strPathToWatch)
            objSemItem_Result.Additional1 = strPathToWatch
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        Return objSemItem_Result
    End Function

    Public Sub New(ByVal Globals As clsGlobals)
        If objLocalConfig Is Nothing Then
            objLocalConfig = New clsLocalConfig_FileManager(Globals)
        End If

        set_DBConnection()
        get_Path_to_Watch()
    End Sub

    Public Function merge_paths(ByVal strPath1 As String, ByVal strPath2 As String, ByVal strSeperator As String) As String
        Dim strPath As String

        If strPath1.EndsWith(strSeperator) Then
            If strPath2.StartsWith(strSeperator) Then
                strPath = strPath1 & strPath2.Substring(1)
            Else
                strPath = strPath1 & strPath2
            End If
        Else
            If strPath2.StartsWith(strSeperator) Then
                strPath = strPath1 & strPath2
            Else
                strPath = strPath1 & strSeperator & strPath2
            End If
        End If

        Return strPath
    End Function

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        objTransaction_FileSystemObject = New clsTransaction_Insert_FileSystemObject(objLocalConfig)
        objBlobConnection = New clsBlobConnection(objLocalConfig)
        objShellWork = New clsShellWork

        procA_PathToWatch_Of_BaseConfig.Connection = objLocalConfig.Connection_Plugin

        procA_File_OutChecked.Connection = objLocalConfig.Connection_Plugin
    End Sub
    Public Function open_BlobWatcher() As clsSemItem
        Dim boolGoOn As Boolean
        Dim objSemItem_Result As clsSemItem

        objFrmBlobWatcher = New frmBlobWatcher(objLocalConfig)

        Do
            boolGoOn = False
            objSemItem_Result = objFrmBlobWatcher.SemItem_Result
            If Not objSemItem_Result Is Nothing Then
                Select Case objFrmBlobWatcher.SemItem_Result.GUID
                    Case objLocalConfig.Globals.LogState_Relation.GUID
                        boolGoOn = True
                    Case objLocalConfig.Globals.LogState_Success.GUID
                        boolGoOn = True
                    Case objLocalConfig.Globals.LogState_Error.GUID
                        boolGoOn = True
                End Select
            End If

        Loop Until boolGoOn = True


        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or _
            objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Relation.GUID Then
            objFrmBlobWatcher.Show()
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result

    End Function
    Private Function open_BlobFile(ByVal objSemItem_File As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_FileCheckOut As DataRowCollection

        Dim strPath As String
        Dim strExtension As String
        Dim boolGoOn As Boolean

        objDRC_FileCheckOut = procA_File_OutChecked.GetData(objLocalConfig.SemItem_Type_Server.GUID, _
                                                            objLocalConfig.SemItem_RelationType_is_checkout_by.GUID, _
                                                            objSemItem_File.GUID).Rows
        If objDRC_FileCheckOut.Count = 0 Then

            objFrmBlobWatcher = New frmBlobWatcher(objLocalConfig)

            Do
                boolGoOn = False
                objSemItem_Result = objFrmBlobWatcher.SemItem_Result
                If Not objSemItem_Result Is Nothing Then
                    Select Case objFrmBlobWatcher.SemItem_Result.GUID
                        Case objLocalConfig.Globals.LogState_Relation.GUID
                            boolGoOn = True
                        Case objLocalConfig.Globals.LogState_Success.GUID
                            boolGoOn = True
                        Case objLocalConfig.Globals.LogState_Error.GUID
                            boolGoOn = True
                    End Select
                End If

            Loop Until boolGoOn = True


            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or _
                objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Relation.GUID Then
                objFrmBlobWatcher.Show()
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    Do
                        objSemItem_Result = objFrmBlobWatcher.SemItem_Result
                    Loop Until objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Or objSemItem_Result.GUID = objLocalConfig.SemItem_token_LogState_Active.GUID
                End If


                strExtension = ""
                If objSemItem_File.Name.Contains(".") Then
                    strExtension = objSemItem_File.Name.Substring(objSemItem_File.Name.LastIndexOf("."))
                End If
                objSemItem_File.Additional1 = merge_paths(objFrmBlobWatcher.PathToWatch, objSemItem_File.GUID.ToString & strExtension, "\")
                objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, objSemItem_File.Additional1)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result.Additional1 = "Die Datei kann nicht geöffnet werden!"
                Else
                    objShellWork.start_Process(objSemItem_File.Additional1, Nothing, Nothing, False, False)
                End If
               
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                objSemItem_Result.Additional1 = "Die Datei kann nicht geöffnet werden, weil der Blob-Watcher nicht startet!"

            End If


        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
            objSemItem_Result.Additional1 = "Die Datei ist bereits am Server " & objDRC_FileCheckOut(0).Item("Name_Server") & " geöffnet!"
        End If
        Return objSemItem_Result
    End Function

    Public Function is_File_Blob(ByVal objSemItem_File As clsSemItem) As Boolean
        Dim boolResult As Boolean
        Dim objDRC_Blob As DataRowCollection

        objDRC_Blob = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_File.GUID, objLocalConfig.SemItem_Attribute_Blob.GUID).Rows
        If objDRC_Blob.Count > 0 Then
            boolResult = objDRC_Blob(0).Item("Val_Bool") = True
        
        Else
            boolResult = False
        End If


        Return boolResult
    End Function
End Class
