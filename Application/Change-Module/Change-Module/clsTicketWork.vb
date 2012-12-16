Imports Sem_Manager
Imports Process_Module
Imports Log_Manager
Public Class clsTicketWork

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_ProcessLog_Of_Process_And_Ticket As New ds_ChangeModuleTableAdapters.proc_ProcessLog_Of_Process_And_TicketTableAdapter
    Private procA_State_Of_ProcessLog_By_GUIDState As New ds_ChangeModuleTableAdapters.proc_State_Of_ProcessLog_By_GUIDStateTableAdapter

    Private objFrmSemManager As frmSemManager
    Private objFrmProcessModule As frmProcessModule
    Private objLocalConfig As clsLocalConfig
    Private objLogManagement As clsLogManagement

    Private objTransaction_Ticket As clsTransaction_Ticket
    Private objTransaction_ProcessLog As clsTransaction_ProcessLog
    Private objDlg_Attribute_VARCHAR255 As dlgAttribute_Varchar255
    Private objFrmParent As IWin32Window

    Public Function new_Ticket() As clsSemItem



        
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Process As clsSemItem = Nothing

        objFrmProcessModule.applyable = True
        objFrmProcessModule.ShowDialog(objFrmParent)
        If objFrmProcessModule.DialogResult = DialogResult.OK Then
            objSemItem_Process = objFrmProcessModule.SemItem_Result
            If Not objSemItem_Process Is Nothing Then
                If objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    MsgBox("Sie müssen einen Prozess auswählen!", MsgBoxStyle.Exclamation)
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                MsgBox("Sie müssen einen Prozess auswählen!", MsgBoxStyle.Exclamation)
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
            objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
            objFrmSemManager.Applyabale = True
            objFrmSemManager.ShowDialog(objFrmParent)
            If objFrmSemManager.DialogResult = DialogResult.OK Then
                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                    objSemItem_Result = create_Tickets(objFrmSemManager.SemItems_Selected, _
                                                    objSemItem_Process)
                Else
                    objSemItem_Result = create_Tickets(objFrmSemManager.SelectedItems_TypeGUID, _
                                                objFrmSemManager.SelectedRows_Items, _
                                                objSemItem_Process)

                End If
            End If
        End If
        Return objSemItem_Result
    End Function
    Public Function create_Tickets(ByVal GUID_Type_SemItems As Guid, ByVal objDGSR_SemItem As DataGridViewSelectedRowCollection, ByVal objSemItem_Process As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Ref As New clsSemItem

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        Select Case GUID_Type_SemItems
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                    objDRV_Selected = objFrmSemManager.SelectedRows_Items(0).DataBoundItem
                    objSemItem_Ref.GUID = objDRV_Selected.Item("GUID_Attribute")
                    objSemItem_Ref.Name = objDRV_Selected.Item("Name_Attribute")
                    objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                    objSemItem_Result = create_Ticket(objSemItem_Ref, objSemItem_Process)

                Next

            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                    objDRV_Selected = objFrmSemManager.SelectedRows_Items(0).DataBoundItem
                    objSemItem_Ref.GUID = objDRV_Selected.Item("GUID_RelationType")
                    objSemItem_Ref.Name = objDRV_Selected.Item("Name_RelationType")
                    objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                    objSemItem_Result = create_Ticket(objSemItem_Ref, objSemItem_Process)
                Next


            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                    objDRV_Selected = objFrmSemManager.SelectedRows_Items(0).DataBoundItem
                    objSemItem_Ref.GUID = objDRV_Selected.Item("GUID_Token")
                    objSemItem_Ref.Name = objDRV_Selected.Item("Name_Token")
                    objSemItem_Ref.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                    objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objSemItem_Result = create_Ticket(objSemItem_Ref, objSemItem_Process)
                Next

            Case Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Select

        Return objSemItem_Result
    End Function

    Public Function create_Sub_processItem(ByVal objSemItem_ProcessItem_Parent As clsSemItem, ByVal boolExisting As Boolean) As clsSemItem
        Dim objSemItem_ProcessItem As clsSemItem


    End Function
    Public Function create_Tickets(ByVal objSemItems_SemItem() As clsSemItem, ByVal objSemItem_Process As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Ref As clsSemItem
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objSemItem_Ref In objSemItems_SemItem
            objSemItem_Result = create_Ticket(objSemItem_Ref, objSemItem_Process)
        Next
        Return objSemItem_Result
    End Function

    Public Function create_Ticket(ByVal objSemItem_Ref As clsSemItem, ByVal objSemItem_Process As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_ProcessLogIncident As clsSemItem = Nothing
        Dim objSemItem_Ticket As New clsSemItem
        Dim objSemItem_LogEntry As clsSemItem
        Dim dateStartDate As Date

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If objSemItem_Process.GUID = objLocalConfig.SemItem_Token_Process_Incident.GUID Then
            objDlg_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Token_Process_Incident.Name, _
                                                                      objLocalConfig.Globals)
            objDlg_Attribute_VARCHAR255.ShowDialog(objFrmParent)
            If objDlg_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
                objSemItem_ProcessLogIncident = New clsSemItem
                objSemItem_ProcessLogIncident.GUID = Guid.NewGuid
                objSemItem_ProcessLogIncident.Name = objDlg_Attribute_VARCHAR255.Value1
                objSemItem_ProcessLogIncident.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID
                objSemItem_ProcessLogIncident.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If


        Else

            objSemItem_ProcessLogIncident = New clsSemItem
            objSemItem_ProcessLogIncident.GUID = Guid.NewGuid
            objSemItem_ProcessLogIncident.Name = objSemItem_Process.Name
            objSemItem_ProcessLogIncident.GUID_Parent = objLocalConfig.SemItem_Type_Process_Log.GUID
            objSemItem_ProcessLogIncident.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Ticket.GUID = Guid.NewGuid
            If objSemItem_Process.GUID = objLocalConfig.SemItem_Token_Process_Incident.GUID Then
                objSemItem_Ticket.Name = objSemItem_ProcessLogIncident.Name & " (" & objSemItem_Process.Name & "/" & objSemItem_Ref.Name & ")"

            Else
                objSemItem_Ticket.Name = objSemItem_Process.Name & " (" & objSemItem_Ref.Name & ")"
            End If
            If objSemItem_Ticket.Name.Length > 255 Then
                objSemItem_Ticket.Name = objSemItem_Ticket.Name.Substring(0, 125) & "..." & objSemItem_Ticket.Name.Substring(objSemItem_Ticket.Name.Length - 126)
            End If
            objSemItem_Ticket.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket.GUID
            objSemItem_Ticket.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objTransaction_Ticket.save_001_Ticket(objSemItem_Ticket)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_Ticket.save_002_Ticket__ID
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    dateStartDate = Now
                   
                    objSemItem_Result = objTransaction_Ticket.save_003_Ticket_To_Group()
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_LogEntry = objLogManagement.log_Entry(dateStartDate, _
                                                                            objLocalConfig.SemItem_Token_LogState_Create.GUID, _
                                                                            objLocalConfig.SemItem_User.GUID, _
                                                                            objLocalConfig.SemItem_Token_LogState_Create.Name)
                        If Not objSemItem_LogEntry Is Nothing Then
                            objSemItem_Result = objTransaction_Ticket.save_005_Ticket_To_Logentry(objSemItem_LogEntry, Nothing, True)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_Ticket.save_007_Ticket_To_Process(objSemItem_Process)

                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                    objSemItem_Result = objTransaction_ProcessLog.save_001_ProcessLogIncident(objSemItem_ProcessLogIncident)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_ProcessLog.save_002_ProcessLog_To_Process(objSemItem_Process)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_ProcessLog.save_003_ProcessLog_To_LogEntry(objSemItem_LogEntry, Nothing, True)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_Ticket.save_008_ProcessLastDone
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    If objSemItem_Process.GUID = objLocalConfig.SemItem_Token_Process_Incident.GUID Then
                                                        objSemItem_Result = objTransaction_Ticket.save_009_ProcessLastDone_To_ProcessItem(objSemItem_ProcessLogIncident)
                                                    Else
                                                        objSemItem_Result = objTransaction_Ticket.save_009_ProcessLastDone_To_ProcessItem(objSemItem_Process)
                                                    End If

                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_Ticket.save_010_Ticket_To_ProcessLastDone
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_Ticket.save_011_Ticket_To_User
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_Ticket.save_012_Ticket_To_SemItem(objSemItem_Ref)
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objSemItem_Result = objTransaction_Ticket.save_013_Ticket_To_ProcessLogIncident(objSemItem_ProcessLogIncident)
                                                                    If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                                        objSemItem_Result = objTransaction_Ticket.del_012_Ticket_To_Semitem
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objSemItem_Result = objTransaction_Ticket.del_011_Ticket_To_User
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objSemItem_Result = objTransaction_Ticket.del_010_Ticket_To_ProcessLastDone
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objSemItem_Result = objTransaction_Ticket.del_009_ProcessLastDone_To_ProcessItem
                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                        objSemItem_Result = objTransaction_Ticket.del_008_ProcessLastDone

                                                                                        objSemItem_Result = objTransaction_ProcessLog.del_003_ProcessLog_To_LogEntry
                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                            objSemItem_Result = objTransaction_ProcessLog.del_002_ProcessLog_To_Process
                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                objSemItem_Result = objTransaction_ProcessLog.del_001_ProcessLogIncident
                                                                                            End If

                                                                                            objSemItem_Result = objTransaction_Ticket.del_007_Ticket_To_Process
                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                objSemItem_Result = objTransaction_Ticket.del_005_Ticket_To_Logentry
                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                    objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                                                                                    objSemItem_Result = objTransaction_Ticket.del_003_Ticket_To_Group
                                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                        
                                                                                                        objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                            objTransaction_Ticket.del_001_Ticket()
                                                                                                        End If

                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If





                                                                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                                    End If

                                                                Else
                                                                    objSemItem_Result = objTransaction_Ticket.del_011_Ticket_To_User
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objSemItem_Result = objTransaction_Ticket.del_010_Ticket_To_ProcessLastDone
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objSemItem_Result = objTransaction_Ticket.del_009_ProcessLastDone_To_ProcessItem
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objSemItem_Result = objTransaction_Ticket.del_008_ProcessLastDone

                                                                                objSemItem_Result = objTransaction_ProcessLog.del_003_ProcessLog_To_LogEntry
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objSemItem_Result = objTransaction_ProcessLog.del_002_ProcessLog_To_Process
                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                        objSemItem_Result = objTransaction_ProcessLog.del_001_ProcessLogIncident
                                                                                    End If

                                                                                    objSemItem_Result = objTransaction_Ticket.del_007_Ticket_To_Process
                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                        objSemItem_Result = objTransaction_Ticket.del_005_Ticket_To_Logentry
                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                            objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                                                                            objSemItem_Result = objTransaction_Ticket.del_003_Ticket_To_Group
                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                                                                objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                    objTransaction_Ticket.del_001_Ticket()
                                                                                                End If

                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If




                                                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                                End If
                                                            Else
                                                                objSemItem_Result = objTransaction_Ticket.del_010_Ticket_To_ProcessLastDone
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objSemItem_Result = objTransaction_Ticket.del_009_ProcessLastDone_To_ProcessItem
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objSemItem_Result = objTransaction_Ticket.del_008_ProcessLastDone

                                                                        objSemItem_Result = objTransaction_ProcessLog.del_003_ProcessLog_To_LogEntry
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objSemItem_Result = objTransaction_ProcessLog.del_002_ProcessLog_To_Process
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objSemItem_Result = objTransaction_ProcessLog.del_001_ProcessLogIncident
                                                                            End If

                                                                            objSemItem_Result = objTransaction_Ticket.del_007_Ticket_To_Process
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objSemItem_Result = objTransaction_Ticket.del_005_Ticket_To_Logentry
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                                                                    objSemItem_Result = objTransaction_Ticket.del_003_Ticket_To_Group
                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                                                        objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                            objTransaction_Ticket.del_001_Ticket()
                                                                                        End If

                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If



                                                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                            End If
                                                        Else
                                                            objSemItem_Result = objTransaction_Ticket.del_009_ProcessLastDone_To_ProcessItem
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_Ticket.del_008_ProcessLastDone

                                                                objSemItem_Result = objTransaction_ProcessLog.del_003_ProcessLog_To_LogEntry
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objSemItem_Result = objTransaction_ProcessLog.del_002_ProcessLog_To_Process
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objSemItem_Result = objTransaction_ProcessLog.del_001_ProcessLogIncident
                                                                    End If

                                                                    objSemItem_Result = objTransaction_Ticket.del_007_Ticket_To_Process
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objSemItem_Result = objTransaction_Ticket.del_005_Ticket_To_Logentry
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                                                            objSemItem_Result = objTransaction_Ticket.del_003_Ticket_To_Group
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                                                objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objTransaction_Ticket.del_001_Ticket()
                                                                                End If

                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If


                                                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                        End If
                                                    Else
                                                        objSemItem_Result = objTransaction_Ticket.del_008_ProcessLastDone

                                                        objSemItem_Result = objTransaction_ProcessLog.del_003_ProcessLog_To_LogEntry
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_ProcessLog.del_002_ProcessLog_To_Process
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_ProcessLog.del_001_ProcessLogIncident
                                                            End If

                                                            objSemItem_Result = objTransaction_Ticket.del_007_Ticket_To_Process
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_Ticket.del_005_Ticket_To_Logentry
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                                                    objSemItem_Result = objTransaction_Ticket.del_003_Ticket_To_Group
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                                        objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objTransaction_Ticket.del_001_Ticket()
                                                                        End If

                                                                    End If
                                                                End If
                                                            End If
                                                        End If

                                                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                    End If

                                                Else
                                                    objSemItem_Result = objTransaction_ProcessLog.del_003_ProcessLog_To_LogEntry
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_ProcessLog.del_002_ProcessLog_To_Process
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_ProcessLog.del_001_ProcessLogIncident
                                                        End If

                                                        objSemItem_Result = objTransaction_Ticket.del_007_Ticket_To_Process
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_Ticket.del_005_Ticket_To_Logentry
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                                                objSemItem_Result = objTransaction_Ticket.del_003_Ticket_To_Group
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                                    objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objTransaction_Ticket.del_001_Ticket()
                                                                    End If

                                                                End If
                                                            End If
                                                        End If
                                                    End If

                                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                End If
                                            Else
                                                objSemItem_Result = objTransaction_ProcessLog.del_002_ProcessLog_To_Process
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_ProcessLog.del_001_ProcessLogIncident
                                                End If

                                                objSemItem_Result = objTransaction_Ticket.del_007_Ticket_To_Process
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_Ticket.del_005_Ticket_To_Logentry
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                                        objSemItem_Result = objTransaction_Ticket.del_003_Ticket_To_Group
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                            objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objTransaction_Ticket.del_001_Ticket()
                                                            End If

                                                        End If
                                                    End If
                                                End If
                                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                            End If
                                        Else
                                            objSemItem_Result = objTransaction_ProcessLog.del_001_ProcessLogIncident
                                            objSemItem_Result = objTransaction_Ticket.del_007_Ticket_To_Process
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_Ticket.del_005_Ticket_To_Logentry
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                                    objSemItem_Result = objTransaction_Ticket.del_003_Ticket_To_Group
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                        objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objTransaction_Ticket.del_001_Ticket()
                                                        End If

                                                    End If
                                                End If
                                            End If
                                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                        End If
                                    Else
                                        objSemItem_Result = objTransaction_Ticket.del_007_Ticket_To_Process
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_Ticket.del_005_Ticket_To_Logentry
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                                objSemItem_Result = objTransaction_Ticket.del_003_Ticket_To_Group
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                    objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objTransaction_Ticket.del_001_Ticket()
                                                    End If

                                                End If
                                            End If
                                        End If
                                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                    End If
                                Else
                                    objSemItem_Result = objTransaction_Ticket.del_005_Ticket_To_Logentry
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                        objSemItem_Result = objTransaction_Ticket.del_003_Ticket_To_Group

                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objTransaction_Ticket.del_001_Ticket()
                                            End If
                                        End If

                                    End If
                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                End If
                            Else
                                objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                objSemItem_Result = objTransaction_Ticket.del_003_Ticket_To_Group

                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_Ticket.del_001_Ticket()
                                    End If
                                End If

                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                            End If
                        Else
                            objSemItem_Result = objTransaction_Ticket.del_003_Ticket_To_Group
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objTransaction_Ticket.del_001_Ticket()
                                End If

                            End If


                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If

                    Else

                        objSemItem_Result = objTransaction_Ticket.del_002_Ticket__ID
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTransaction_Ticket.del_001_Ticket()
                        End If


                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If

                Else
                    objTransaction_Ticket.del_001_Ticket()
                End If
            End If
        End If




        Return objSemItem_Result
    End Function

    Public Function log_Entry_Information(ByVal objSemItem_ProcessItem As clsSemItem, ByVal objSemItem_Ticket As clsSemItem, ByVal strInformation As String) As clsSemItem
        Dim objSemItem_ProcessLog As clsSemItem
        Dim objSemItem_LogEntry As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Error

        objSemItem_ProcessLog = get_ProcessLog(objSemItem_ProcessItem, objSemItem_Ticket)

        objSemItem_LogEntry = objLogManagement.log_Entry(Now, objLocalConfig.SemItem_Token_LogState_Information.GUID, objLocalConfig.SemItem_User.GUID, strInformation)

        If Not objSemItem_LogEntry Is Nothing Then
            objSemItem_Result = objTransaction_ProcessLog.save_003_ProcessLog_To_LogEntry(objSemItem_LogEntry, objSemItem_ProcessLog)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_Ticket.save_005_Ticket_To_Logentry(objSemItem_LogEntry, objSemItem_Ticket, False, False)
            Else
                objTransaction_ProcessLog.del_003_ProcessLog_To_LogEntry()
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function log_Entry_Obsolete(ByVal objSemItem_ProcessItem As clsSemItem, ByVal objSemItem_Ticket As clsSemItem, ByVal strInformation As String) As clsSemItem
        Dim objSemItem_ProcessLog As clsSemItem
        Dim objSemItem_LogEntry As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Error

        objSemItem_ProcessLog = get_ProcessLog(objSemItem_ProcessItem, objSemItem_Ticket)

        objSemItem_LogEntry = objLogManagement.log_Entry(Now, objLocalConfig.SemItem_Token_LogState_Obsolete.GUID, objLocalConfig.SemItem_User.GUID, strInformation)

        If Not objSemItem_LogEntry Is Nothing Then
            objSemItem_Result = objTransaction_ProcessLog.save_003_ProcessLog_To_LogEntry(objSemItem_LogEntry, objSemItem_ProcessLog, False, True)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_Ticket.save_005_Ticket_To_Logentry(objSemItem_LogEntry, objSemItem_Ticket, False, False)
            Else
                objTransaction_ProcessLog.del_003_ProcessLog_To_LogEntry()
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function log_Entry_Error(ByVal objSemItem_ProcessItem As clsSemItem, ByVal objSemItem_Ticket As clsSemItem, ByVal strInformation As String) As clsSemItem
        Dim objSemItem_ProcessLog As clsSemItem
        Dim objSemItem_LogEntry As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Error

        objSemItem_ProcessLog = get_ProcessLog(objSemItem_ProcessItem, objSemItem_Ticket)

        objSemItem_LogEntry = objLogManagement.log_Entry(Now, objLocalConfig.SemItem_Token_Logstate_Error.GUID, objLocalConfig.SemItem_User.GUID, strInformation)

        If Not objSemItem_LogEntry Is Nothing Then
            objSemItem_Result = objTransaction_ProcessLog.save_003_ProcessLog_To_LogEntry(objSemItem_LogEntry, objSemItem_ProcessLog)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_Ticket.save_005_Ticket_To_Logentry(objSemItem_LogEntry, objSemItem_Ticket, False, False)
            Else
                objTransaction_ProcessLog.del_003_ProcessLog_To_LogEntry()
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function get_ProcessLog(ByVal objSemItem_ProcessItem As clsSemItem, ByVal objSemItem_Ticket As clsSemItem) As clsSemItem
        Dim objSemItem_ProcessLog As clsSemItem
        Dim objDRC_ProcessLog As DataRowCollection

        If objSemItem_ProcessItem.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID Then
            objSemItem_ProcessLog = objSemItem_ProcessItem
        Else
            objDRC_ProcessLog = procA_ProcessLog_Of_Process_And_Ticket.GetData(objLocalConfig.SemItem_Type_Process_Log.GUID, _
                                                                               objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                               objSemItem_ProcessItem.GUID, _
                                                                               objSemItem_Ticket.GUID).Rows
            If objDRC_ProcessLog.Count > 0 Then
                objSemItem_ProcessLog = New clsSemItem
                objSemItem_ProcessLog.GUID = objDRC_ProcessLog(0).Item("GUID_Process_Log")
                objSemItem_ProcessLog.Name = objDRC_ProcessLog(0).Item("Name_Process_Log")
                objSemItem_ProcessLog.GUID_Parent = objLocalConfig.SemItem_Type_Process_Log.GUID
                objSemItem_ProcessLog.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Else

                objSemItem_ProcessLog = create_ProcessLog(objSemItem_ProcessItem, objSemItem_Ticket)
            End If
        End If

        Return objSemItem_ProcessLog
    End Function

    Private Function create_ProcessLog(ByVal objSemItem_ProcessItem As clsSemItem, ByVal objSemItem_Ticket As clsSemItem) As clsSemItem
        Dim objSemItem_ProcessLog As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_LogEntry As clsSemItem

        objSemItem_ProcessLog = New clsSemItem
        objSemItem_ProcessLog.GUID = Guid.NewGuid
        objSemItem_ProcessLog.Name = objSemItem_ProcessItem.Name
        objSemItem_ProcessLog.GUID_Parent = objLocalConfig.SemItem_Type_Process_Log.GUID
        objSemItem_ProcessLog.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objSemItem_Result = objTransaction_ProcessLog.save_001_ProcessLogIncident(objSemItem_ProcessLog)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_ProcessLog.save_002_ProcessLog_To_Process(objSemItem_ProcessItem)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_Ticket.save_013_Ticket_To_ProcessLogIncident(objSemItem_ProcessLog, objSemItem_Ticket)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_LogEntry = objLogManagement.log_Entry(Now, _
                                                                     objLocalConfig.SemItem_Token_LogState_Create.GUID, _
                                                                     objLocalConfig.SemItem_User.GUID, _
                                                                     objLocalConfig.SemItem_Token_LogState_Create.Name)
                    If Not objSemItem_LogEntry Is Nothing Then
                        objSemItem_Result = objTransaction_ProcessLog.save_003_ProcessLog_To_LogEntry(objSemItem_LogEntry, _
                                                                                                      objSemItem_ProcessLog, _
                                                                                                      True)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Ticket.save_005_Ticket_To_Logentry(objSemItem_LogEntry, _
                                                                                                  objSemItem_Ticket)
                            If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_ProcessLog.del_003_ProcessLog_To_LogEntry
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_ProcessLog.del_002_ProcessLog_To_Process
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objTransaction_ProcessLog.del_001_ProcessLogIncident()
                                        End If
                                    End If
                                End If
                                objSemItem_ProcessLog = Nothing
                            End If
                        Else
                            objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                            objSemItem_Result = objTransaction_ProcessLog.del_002_ProcessLog_To_Process
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_ProcessLog.del_001_ProcessLogIncident()
                            End If
                            objSemItem_ProcessLog = Nothing
                        End If

                    Else
                        objSemItem_Result = objTransaction_ProcessLog.del_002_ProcessLog_To_Process
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTransaction_ProcessLog.del_001_ProcessLogIncident()
                        End If
                        objSemItem_ProcessLog = Nothing
                    End If
                Else
                    objSemItem_Result = objTransaction_ProcessLog.del_002_ProcessLog_To_Process
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objTransaction_ProcessLog.del_001_ProcessLogIncident()
                    End If
                    objSemItem_ProcessLog = Nothing
                End If
            Else
                objTransaction_ProcessLog.del_001_ProcessLogIncident()
                objSemItem_ProcessLog = Nothing
            End If
        Else
            objSemItem_ProcessLog = Nothing
        End If

        Return objSemItem_ProcessLog
    End Function


    Public Function state_Err(ByVal objSemItem_ProcessLog As clsSemItem) As Boolean
        Dim boolResult As Boolean
        Dim objDRC_Error As DataRowCollection

        objDRC_Error = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLog.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_Error_Queue.GUID, _
                                                                     objLocalConfig.SemItem_Type_LogEntry.GUID).Rows
        If objDRC_Error.Count > 0 Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Public Function state_Finished(ByVal objSemItem_ProcessLog As clsSemItem) As Boolean
        Dim boolResult As Boolean
        Dim objDRC_Finished As DataRowCollection

        objDRC_Finished = procA_State_Of_ProcessLog_By_GUIDState.GetData(objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                         objLocalConfig.SemItem_type_Logstate.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_provides.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_finished_with.GUID, _
                                                                         objLocalConfig.SemItem_Token_Logstate_finished.GUID, _
                                                                         objSemItem_ProcessLog.GUID).Rows
        If objDRC_Finished.Count > 0 Then
            boolResult = True
        Else
            boolResult = False
        End If
        Return boolResult
    End Function

    Public Function state_Obsolete(ByVal objSemItem_ProcessLog As clsSemItem) As Boolean
        Dim boolResult As Boolean
        Dim objDRC_Finished As DataRowCollection

        objDRC_Finished = procA_State_Of_ProcessLog_By_GUIDState.GetData(objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                         objLocalConfig.SemItem_type_Logstate.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_provides.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_finished_with.GUID, _
                                                                         objLocalConfig.SemItem_Token_LogState_Obsolete.GUID, _
                                                                         objSemItem_ProcessLog.GUID).Rows
        If objDRC_Finished.Count > 0 Then
            boolResult = True
        Else
            boolResult = False
        End If
        Return boolResult
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal Frm As IWin32Window)
        objFrmParent = Frm
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_ProcessLog_Of_Process_And_Ticket.Connection = objLocalConfig.Connection_Plugin
        procA_State_Of_ProcessLog_By_GUIDState.Connection = objLocalConfig.Connection_Plugin

        objFrmProcessModule = New frmProcessModule(objLocalConfig.Globals)
        objTransaction_Ticket = New clsTransaction_Ticket(objLocalConfig)
        objTransaction_ProcessLog = New clsTransaction_ProcessLog(objLocalConfig)
        objLogManagement = New clsLogManagement(objLocalConfig.Globals)
    End Sub

End Class
