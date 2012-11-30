Imports Sem_Manager
Public Class clsTransaction_Insert_FileSystemObject
    Private objLocalConfig As clsLocalConfig_FileManager
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_Token_Folder As New ds_FilesystemManagement.semtbl_Token_FolderDataTable
    Private semtblT_Token_Token_Folder As New ds_FilesystemManagement.semtbl_Token_Token_FolderDataTable

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private objSemItem_Extension As clsSemItem
    Private objSemItem_File As clsSemItem

    Private intOrderID_Folder As Integer
    Private intOrderID_FolderRel As Integer


    Public Function save_001_Server(ByVal SemItem_Server As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Server As DataRowCollection


        objDRC_Server = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_Server.GUID, _
                                                                         SemItem_Server.Name).Rows
        intOrderID_Folder = 0
        semtblT_Token_Folder.Clear()
        semtblT_Token_Token_Folder.Clear()
        If objDRC_Server.Count > 0 Then
            SemItem_Server.GUID = objDRC_Server(0).Item("GUID_Token")
            SemItem_Server.Name = objDRC_Server(0).Item("Name_Token")
            SemItem_Server.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
            SemItem_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            semtblT_Token_Folder.Rows.Add(SemItem_Server.GUID, _
                                          SemItem_Server.Name, _
                                          SemItem_Server.GUID_Parent, _
                                          intOrderID_Folder)
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            SemItem_Server.GUID = Guid.NewGuid
            SemItem_Server.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
            SemItem_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(SemItem_Server.GUID, _
                                                                 SemItem_Server.Name, _
                                                                 SemItem_Server.GUID_Parent, True).Rows

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                semtblT_Token_Folder.Rows.Add(SemItem_Server.GUID, _
                                          SemItem_Server.Name, _
                                          SemItem_Server.GUID_Parent, _
                                          intOrderID_Folder)
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Private Function del_001_Server() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRs_Folder() As DataRow

        objDRs_Folder = semtblT_Token_Folder.Select("GUID_Type='" & objLocalConfig.SemItem_Type_Server.GUID.ToString & "'")
        If objDRs_Folder.Count > 0 Then
            objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objDRs_Folder(0).Item("GUID_Token")).Rows
            Select Case objDRC_LogState(0).Item("GUID_Token")
                Case objLocalConfig.Globals.LogState_Delete.GUID
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Case objLocalConfig.Globals.LogState_Nothing.GUID
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Case Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End Select
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        

        Return objSemItem_Result
    End Function
    Public Function save_002_Drive(ByVal SemItem_Drive As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Drive As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Drive As clsSemItem

        objSemItem_Drive = SemItem_Drive

        objSemItem_Drive.Name = objSemItem_Drive.Name.Substring(0, 1)

        objDRC_Drive = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_Drive.GUID, _
                                                                        objSemItem_Drive.Name).Rows

        objSemItem_Drive.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID
        objSemItem_Drive.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        If objDRC_Drive.Count = 0 Then
            objSemItem_Drive.GUID = Guid.NewGuid
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Drive.GUID, _
                                                                 objSemItem_Drive.Name, _
                                                                 objSemItem_Drive.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                intOrderID_Folder = intOrderID_Folder + 1
                semtblT_Token_Folder.Rows.Add(objSemItem_Drive.GUID, _
                                              objSemItem_Drive.Name, _
                                              objSemItem_Drive.GUID_Parent, intOrderID_Folder)

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else

            objSemItem_Drive.GUID = objDRC_Drive(0).Item("GUID_Token")
            intOrderID_Folder = intOrderID_Folder + 1
            semtblT_Token_Folder.Rows.Add(objSemItem_Drive.GUID, _
                                          objSemItem_Drive.Name, _
                                          objSemItem_Drive.GUID_Parent, intOrderID_Folder)
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_Drive(ByVal SemItem_Drive As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRs_Drive() As DataRow
        Dim objSemItem_Drive As New clsSemItem

        If Not SemItem_Drive Is Nothing Then
            objSemItem_Drive = SemItem_Drive

        End If

        objDRs_Drive = semtblT_Token_Folder.Select("GUID_Type='" & objLocalConfig.SemItem_Type_Drive.GUID.ToString & "'")
        If objDRs_Drive.Count > 0 Then
            objSemItem_Drive.GUID = objDRs_Drive(0).Item("GUID_Token")
        End If
        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Drive.GUID).Rows
        Select Case objDRC_LogState(0).Item("GUID_Token")
            Case objLocalConfig.Globals.LogState_Delete.GUID
                If objDRs_Drive.Count > 0 Then
                    objDRs_Drive(0).Delete()
                End If

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Case objLocalConfig.Globals.LogState_Relation.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Relation
            Case objLocalConfig.Globals.LogState_Nothing.GUID
                If objDRs_Drive.Count > 0 Then
                    objDRs_Drive(0).Delete()
                End If
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Case objLocalConfig.Globals.LogState_Error.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            Case Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Select

        Return objSemItem_Result
    End Function

    Public Function save_002_Folder(ByVal SemItem_Child As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRs_Folder() As DataRow
        Dim objDRC_Folder As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objDRs_Folder = semtblT_Token_Folder.Select("OrderID=" & intOrderID_Folder)
        If objDRs_Folder.Count > 0 Then
            If objDRs_Folder(0).Item("GUID_Type") = objLocalConfig.SemItem_Type_Server.GUID Then
                If SemItem_Child.GUID_Type = objLocalConfig.SemItem_Type_Drive.GUID Then
                    objDRC_Folder = funcA_TokenToken.GetData_By_GUIDToken_Right_GUIDType_Left_TokenName_Left_GUIDRel(objDRs_Folder(0).Item("GUID_Token"), _
                                                                                                              SemItem_Child.Name, _
                                                                                                              objLocalConfig.SemItem_Type_Drive.GUID, _
                                                                                                              objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows
                    SemItem_Child.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID
                Else
                    objDRC_Folder = funcA_TokenToken.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(objDRs_Folder(0).Item("GUID_Token"), _
                                                                                                              SemItem_Child.Name, _
                                                                                                              objLocalConfig.SemItem_type_Folder.GUID, _
                                                                                                              objLocalConfig.SemItem_RelationType_Fileshare.GUID).Rows
                    SemItem_Child.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
                End If

                SemItem_Child.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                If objDRC_Folder.Count = 0 Then
                    SemItem_Child.GUID = Guid.NewGuid
                    objDRC_LogState = semprocA_DBWork_Save_Token.GetData(SemItem_Child.GUID, _
                                                                         SemItem_Child.Name, _
                                                                         SemItem_Child.GUID_Parent, True).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        intOrderID_Folder = intOrderID_Folder + 1
                        semtblT_Token_Folder.Rows.Add(SemItem_Child.GUID, _
                                                      SemItem_Child.Name, _
                                                      SemItem_Child.GUID_Parent, _
                                                      intOrderID_Folder)
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If

                Else
                    SemItem_Child.GUID = objDRC_Folder(0).Item("GUID_Token_Right")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    intOrderID_Folder = intOrderID_Folder + 1
                    semtblT_Token_Folder.Rows.Add(SemItem_Child.GUID, _
                                                  SemItem_Child.Name, _
                                                  SemItem_Child.GUID_Parent, _
                                                  intOrderID_Folder)
                End If




            ElseIf objDRs_Folder(0).Item("GUID_Type") = objLocalConfig.SemItem_type_Folder.GUID Or _
                    objDRs_Folder(0).Item("GUID_Type") = objLocalConfig.SemItem_Type_Drive.GUID Then
                objDRC_Folder = funcA_TokenToken.GetData_By_GUIDToken_Right_GUIDType_Left_TokenName_Left_GUIDRel(objDRs_Folder(0).Item("GUID_Token"), _
                                                                                                                 SemItem_Child.Name, _
                                                                                                                 objLocalConfig.SemItem_type_Folder.GUID, _
                                                                                                                 objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows
                If objDRC_Folder.Count = 0 Then
                    SemItem_Child.GUID = Guid.NewGuid
                    objDRC_LogState = semprocA_DBWork_Save_Token.GetData(SemItem_Child.GUID, _
                                                                         SemItem_Child.Name, _
                                                                         SemItem_Child.GUID_Parent, True).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        intOrderID_Folder = intOrderID_Folder + 1
                        semtblT_Token_Folder.Rows.Add(SemItem_Child.GUID, _
                                                      SemItem_Child.Name, _
                                                      SemItem_Child.GUID_Parent, _
                                                      intOrderID_Folder)
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else

                    SemItem_Child.GUID = objDRC_Folder(0).Item("GUID_Token_Left")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    intOrderID_Folder = intOrderID_Folder + 1
                    semtblT_Token_Folder.Rows.Add(SemItem_Child.GUID, _
                                                  SemItem_Child.Name, _
                                                  SemItem_Child.GUID_Parent, _
                                                  intOrderID_Folder)
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function del_002_Folder() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRs_Folder() As DataRow

        If intOrderID_Folder >= 0 Then
            objDRs_Folder = semtblT_Token_Folder.Select("OrderID=" & intOrderID_Folder)

            If objDRs_Folder.Count > 0 Then
                objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objDRs_Folder(0).Item("GUID_Token")).Rows
                Select Case objDRC_LogState(0).Item("GUID_Token")
                    Case objLocalConfig.Globals.LogState_Delete.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Case objLocalConfig.Globals.LogState_Nothing.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Case Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End Select
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objDRs_Folder(0).Delete()
                    intOrderID_Folder = intOrderID_Folder - 1
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = Nothing
        End If
        


        Return objSemItem_Result

    End Function

    Public Function save_003_Parent_To_Child() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Parent As New clsSemItem
        Dim objSemItem_Child As New clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRs_Folder() As DataRow

        objDRs_Folder = semtblT_Token_Folder.Select("OrderID=" & intOrderID_Folder)
        If objDRs_Folder.Count > 0 Then
            objSemItem_Child.GUID = objDRs_Folder(0).Item("GUID_Token")
            objSemItem_Child.Name = objDRs_Folder(0).Item("Name_Token")
            objSemItem_Child.GUID_Parent = objDRs_Folder(0).Item("GUID_Type")
            objSemItem_Child.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRs_Folder = semtblT_Token_Folder.Select("OrderID=" & intOrderID_Folder - 1)
            If objDRs_Folder.Count > 0 Then
                objSemItem_Parent.GUID = objDRs_Folder(0).Item("GUID_Token")
                objSemItem_Parent.Name = objDRs_Folder(0).Item("Name_Token")
                objSemItem_Parent.GUID_Parent = objDRs_Folder(0).Item("GUID_Type")
                objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                If objSemItem_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID Then
                    intOrderID_FolderRel = 0
                    If objSemItem_Child.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Parent.GUID, _
                                                                            objSemItem_Child.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_isSubordinated.GUID, intOrderID_FolderRel).Rows
                    Else
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Parent.GUID, _
                                                                            objSemItem_Child.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_Fileshare.GUID, intOrderID_FolderRel).Rows
                    End If

                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        If objSemItem_Child.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID Then
                            semtblT_Token_Token_Folder.Rows.Add(objSemItem_Parent.GUID, _
                                                            objSemItem_Child.GUID, _
                                                            objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                            intOrderID_FolderRel)
                        Else
                            semtblT_Token_Token_Folder.Rows.Add(objSemItem_Parent.GUID, _
                                                            objSemItem_Child.GUID, _
                                                            objLocalConfig.SemItem_RelationType_Fileshare.GUID, _
                                                            intOrderID_FolderRel)
                        End If


                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else

                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Child.GUID, _
                                                                            objSemItem_Parent.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_isSubordinated.GUID, intOrderID_FolderRel).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        intOrderID_FolderRel = intOrderID_FolderRel + 1
                        semtblT_Token_Token_Folder.Rows.Add(objSemItem_Child.GUID, _
                                                            objSemItem_Parent.GUID, _
                                                            objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                            intOrderID_FolderRel)
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If

                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If



        Return objSemItem_Result
    End Function

    Public Function del_003_Parent_To_Child() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRs_Folder() As DataRow

        If intOrderID_FolderRel >= 0 Then
            objDRs_Folder = semtblT_Token_Token_Folder.Select("OrderID=" & intOrderID_FolderRel)
            If objDRs_Folder.Count > 0 Then
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDRs_Folder(0).Item("GUID_Token_Left"), _
                                                                       objDRs_Folder(0).Item("GUID_Token_Right"), _
                                                                       objDRs_Folder(0).Item("GUID_RelationType")).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    objDRs_Folder(0).Delete()
                    intOrderID_FolderRel = intOrderID_FolderRel - 1
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        End If
        

        Return objSemItem_Result
    End Function
    Public Function save_004_File(ByVal SemItem_File As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRs_Folder() As DataRow
        Dim objDRC_Folder As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objSemItem_File = SemItem_File

        objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
        objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        If semtblT_Token_Folder.Rows.Count > 0 Then
            objDRs_Folder = semtblT_Token_Folder.Select("OrderID=" & intOrderID_Folder)
            If objDRs_Folder.Count > 0 Then
                objDRC_Folder = funcA_TokenToken.GetData_By_GUIDToken_Right_GUIDType_Left_TokenName_Left_GUIDRel(objDRs_Folder(0).Item("GUID_Token"), _
                                                                                                                 objSemItem_File.Name, _
                                                                                                                 objLocalConfig.SemItem_Type_File.GUID, _
                                                                                                                 objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows
                If objDRC_Folder.Count = 0 Then
                    objSemItem_File.GUID = Guid.NewGuid

                    objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_File.GUID, _
                                                                         objSemItem_File.Name, _
                                                                         objSemItem_File.GUID_Parent, True).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    objSemItem_File.GUID = objDRC_Folder(0).Item("GUID_Token_Left")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_File.GUID = Guid.NewGuid

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_File.GUID, _
                                                                 objSemItem_File.Name, _
                                                                 objSemItem_File.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        


        Return objSemItem_Result
    End Function

    Public Function del_004_File(Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_File.GUID).Rows
        Select Case objDRC_LogState(0).Item("GUID_Token")
            Case objLocalConfig.Globals.LogState_Delete.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Case objLocalConfig.Globals.LogState_Nothing.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Case objLocalConfig.Globals.LogState_Relation.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Relation
            Case objLocalConfig.Globals.LogState_Error.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            Case Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Select

        Return objSemItem_Result
    End Function

    Public Function save_005_File_To_Folder(Optional ByVal SemItem_Folder As clsSemItem = Nothing, Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRs_Folder() As DataRow

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If
        If semtblT_Token_Folder.Rows.Count > 0 Then
            objDRs_Folder = semtblT_Token_Folder.Select("OrderID=" & intOrderID_Folder)
            If objDRs_Folder.Count > 0 Then
                SemItem_Folder = New clsSemItem
                SemItem_Folder.GUID = objDRs_Folder(0).Item("GUID_Token")
                SemItem_Folder.Name = objDRs_Folder(0).Item("Name_Token")
                SemItem_Folder.GUID_Parent = objDRs_Folder(0).Item("GUID_Type")
                SemItem_Folder.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_File.GUID, _
                                                                        SemItem_Folder.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_isSubordinated.GUID, 0).Rows
                Select Case objDRC_LogState(0).Item("GUID_Token")
                    Case objLocalConfig.Globals.LogState_Insert.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Case objLocalConfig.Globals.LogState_Nothing.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Case objLocalConfig.Globals.LogState_Error.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Case Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error

                End Select
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            If Not SemItem_Folder Is Nothing Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_File.GUID, _
                                                                        SemItem_Folder.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_isSubordinated.GUID, 0).Rows
                Select Case objDRC_LogState(0).Item("GUID_Token")
                    Case objLocalConfig.Globals.LogState_Insert.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Case objLocalConfig.Globals.LogState_Relation.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Relation
                    Case objLocalConfig.Globals.LogState_Error.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Case Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error

                End Select
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_File_To_Folder(Optional ByVal SemItem_Folder As clsSemItem = Nothing, Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRs_Folder() As DataRow

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If
        If semtblT_Token_Folder.Rows.Count > 0 Then
            objDRs_Folder = semtblT_Token_Folder.Select("OrderID=" & intOrderID_Folder)
            If objDRs_Folder.Count > 0 Then
                SemItem_Folder = New clsSemItem
                SemItem_Folder.GUID = objDRs_Folder(0).Item("GUID_Token")
                SemItem_Folder.Name = objDRs_Folder(0).Item("Name_Token")
                SemItem_Folder.GUID_Parent = objDRs_Folder(0).Item("GUID_Type")
                SemItem_Folder.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_File.GUID, _
                                                                        SemItem_Folder.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows
                Select Case objDRC_LogState(0).Item("GUID_Token")
                    Case objLocalConfig.Globals.LogState_Delete.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Case objLocalConfig.Globals.LogState_Relation.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Relation
                    Case objLocalConfig.Globals.LogState_Error.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Case Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error

                End Select
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            If Not SemItem_Folder Is Nothing Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_File.GUID, _
                                                                        SemItem_Folder.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows
                Select Case objDRC_LogState(0).Item("GUID_Token")
                    Case objLocalConfig.Globals.LogState_Delete.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Case objLocalConfig.Globals.LogState_Relation.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Relation
                    Case objLocalConfig.Globals.LogState_Error.GUID
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Case Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error

                End Select
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_006_FileExtension(ByVal SemItem_Extension As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_FileExtension As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Extension = SemItem_Extension

        objDRC_FileExtension = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_Extensions.GUID, _
                                                                                SemItem_Extension.Name).Rows
        objSemItem_Extension.GUID_Parent = objLocalConfig.SemItem_Type_Extensions.GUID
        objSemItem_Extension.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        If objDRC_FileExtension.Count = 0 Then
            objSemItem_Extension.GUID = Guid.NewGuid
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Extension.GUID, _
                                                                 objSemItem_Extension.Name, _
                                                                 objSemItem_Extension.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Extension.GUID = objDRC_FileExtension(0).Item("GUID_Token")
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function del_006_FileExtensions(Optional ByVal SemItem_Extension As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Extension Is Nothing Then
            objSemItem_Extension = SemItem_Extension
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Extension.GUID).Rows
        Select Case objDRC_LogState(0).Item("GUID_Token")
            Case objLocalConfig.Globals.LogState_Delete.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Case objLocalConfig.Globals.LogState_Nothing.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Case objLocalConfig.Globals.LogState_Relation.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Relation
            Case objLocalConfig.Globals.LogState_Error.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            Case Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Select

        Return objSemItem_Result
    End Function

    Public Function save_007_File_To_Extension(Optional ByVal SemItem_Extensionas As clsSemItem = Nothing, Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Extensionas Is Nothing Then
            objSemItem_Extension = SemItem_Extensionas
        End If

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_File.GUID, _
                                                               objSemItem_Extension.GUID, _
                                                               objLocalConfig.SemItem_RelationType_ends_with.GUID, 0).Rows
        Select Case objDRC_LogState(0).Item("GUID_Token")
            Case objLocalConfig.Globals.LogState_Insert.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Case objLocalConfig.Globals.LogState_Nothing.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Case objLocalConfig.Globals.LogState_Error.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            Case Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Select

        Return objSemItem_Result
    End Function

    Public Function del_007_File_To_Extension(Optional ByVal SemItem_File As clsSemItem = Nothing, Optional ByVal SemItem_Extension As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        If Not SemItem_Extension Is Nothing Then
            objSemItem_Extension = SemItem_Extension
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_File.GUID, _
                                                               objSemItem_Extension.GUID, _
                                                               objLocalConfig.SemItem_RelationType_ends_with.GUID).Rows
        Select Case objDRC_LogState(0).Item("GUID_Token")
            Case objLocalConfig.Globals.LogState_Delete.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Case objLocalConfig.Globals.LogState_Relation.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Relation
            Case objLocalConfig.Globals.LogState_Nothing.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Case objLocalConfig.Globals.LogState_Error.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            Case Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Select

        Return objSemItem_Result
    End Function

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig_FileManager)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub
End Class
