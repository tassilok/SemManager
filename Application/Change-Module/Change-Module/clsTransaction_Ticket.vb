Imports Sem_Manager
Imports Log_Manager
Public Class clsTransaction_Ticket
    Private objLocalConfig As clsLocalConfig

    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private procA_TokenAttribute_Int As New ds_TokenAttributeTableAdapters.TokenAttribute_IntTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
   
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Int As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_IntTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_DateTime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private semprocA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private semprocA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private semprocA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter
    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_DBWork_Del_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter


    Private procA_ProcessItem_LastDone As New ds_ChangeModuleTableAdapters.proc_ProcessItem_LastDoneTableAdapter

    Private objLogManagement As clsLogManagement

    Private objSemItem_Ticket As clsSemItem
    Private objSemItem_Group As clsSemItem
    Private objSemItem_User As clsSemItem
    Private objSemItem_Logentry As clsSemItem
    Private objSemItem_LogState As clsSemItem
    Private objSemItem_Process As clsSemItem
    Private objSemItem_ProcessItem As clsSemItem
    Private objSemItem_ProcessLastDone As clsSemItem
    Private objSemItem_Ref As clsSemItem
    Private objSemItem_RefOR As clsSemItem
    Private objSemItem_ProcessLogIncident As clsSemItem
    Private objSemItem_TicketList As clsSemItem

    Private objSemItem_TokenAttribute_ID As clsSemItem
    Private objSemItem_TokenAttribute_StartDate As clsSemItem
    Private objSemItem_TokenAttribute_Description As clsSemItem
    Private date_StartDate As Date
    Private boolCreate As Boolean
    Private boolFinish As Boolean

    Public ReadOnly Property SemItem_LogEntry As clsSemItem
        Get
            Return objSemItem_Logentry
        End Get
    End Property

    Public Function save_001_Ticket(ByVal SemItem_Ticket As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Ticket = SemItem_Ticket

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Ticket.GUID, _
                                                             objSemItem_Ticket.Name, _
                                                             objSemItem_Ticket.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_Ticket(Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Ticket.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Ticket__ID(Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Ticket__ID As DataRowCollection
        Dim intID As Integer

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objDRC_Ticket__ID = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Ticket.GUID, _
                                                                                                           objLocalConfig.SemItem_Attribute_ID.GUID).Rows

        If objDRC_Ticket__ID.Count > 0 Then
            intID = objDRC_Ticket__ID(0).Item("Val_Int")
            objSemItem_TokenAttribute_ID = New clsSemItem
            objSemItem_TokenAttribute_ID.GUID = objDRC_Ticket__ID(0).Item("GUID_TokenAttribute")
            objSemItem_TokenAttribute_ID.Level = intID

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            intID = procA_TokenAttribute_Int.Val_Max(objLocalConfig.SemItem_Type_Process_Ticket.GUID, _
                                                     objLocalConfig.SemItem_Attribute_ID.GUID) + 1
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Int.GetData(objSemItem_Ticket.GUID, _
                                                                              objLocalConfig.SemItem_Attribute_ID.GUID, _
                                                                              Nothing, _
                                                                              intID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_ID = New clsSemItem
                objSemItem_TokenAttribute_ID.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_TokenAttribute_ID.Level = intID
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        End If


        Return objSemItem_Result
    End Function

    Public Function del_002_Ticket__ID(Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Ticket__ID As DataRowCollection
        Dim objDR_Ticket__ID As DataRow

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objDRC_Ticket__ID = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Ticket.GUID, _
                                                                                                           objLocalConfig.SemItem_Attribute_ID.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Ticket__ID In objDRC_Ticket__ID
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Ticket__ID.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result

    End Function

    Public Function save_003_Ticket_To_Group(Optional ByVal SemItem_Group As clsSemItem = Nothing, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Group = SemItem_Group

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        If objSemItem_Group Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                    objLocalConfig.SemItem_Group.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                    1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                    objSemItem_Group.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                    objSemItem_Group.Level).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        Return objSemItem_Result
    End Function

    Public Function del_003_Ticket_To_Group(Optional ByVal SemItem_Group As clsSemItem = Nothing, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objSemItem_Group = SemItem_Group

        If objSemItem_Group Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                   objLocalConfig.SemItem_Group.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                   objSemItem_Group.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_Logentry(ByVal SemItem_LogState As clsSemItem, ByVal Message As String, ByVal dateTimeStamp As Date) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_LogState = SemItem_LogState
        objSemItem_Logentry = objLogManagement.log_Entry(dateTimeStamp, _
                                                         SemItem_LogState.GUID, _
                                                         objLocalConfig.SemItem_User.GUID, _
                                                         Message)
        If Not objSemItem_Logentry Is Nothing Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_Logentry(Optional ByVal SemItem_LogEntry As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem


        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_Logentry = SemItem_LogEntry
        End If


        objSemItem_Result = objLogManagement.del_LogEntry(objSemItem_Logentry.GUID)

        Return objSemItem_Result
    End Function

    Public Function save_005_Ticket_To_Logentry(Optional ByVal SemItem_LogEntry As clsSemItem = Nothing, Optional ByVal SemItem_Ticket As clsSemItem = Nothing, Optional ByVal isStart As Boolean = False, Optional ByVal isFinish As Boolean = False) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_Logentry = SemItem_LogEntry
        End If

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        boolCreate = isStart
        boolFinish = isFinish

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                objSemItem_Logentry.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging_Done.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            If boolCreate = True Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                        objSemItem_Logentry.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_started_with.GUID, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                         objSemItem_Logentry.GUID, _
                                                         objLocalConfig.SemItem_RelationType_belonging_Done.GUID)
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If

            ElseIf boolFinish = True Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                        objSemItem_Logentry.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_finished_with.GUID, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                         objSemItem_Logentry.GUID, _
                                                         objLocalConfig.SemItem_RelationType_belonging_Done.GUID)
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = save_006_Ticket_To_LastLogEntry()
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                          objSemItem_Logentry.GUID, _
                                                          objLocalConfig.SemItem_RelationType_belonging_Done.GUID)

                semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                     objSemItem_Logentry.GUID, _
                                                     objLocalConfig.SemItem_RelationType_started_with.GUID)

                semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                     objSemItem_Logentry.GUID, _
                                                     objLocalConfig.SemItem_RelationType_finished_with.GUID)
                objSemItem_Result = objLocalConfig.Globals.LogState_Error

            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_Ticket_To_Logentry(Optional ByVal SemItem_LogEntry As clsSemItem = Nothing, Optional ByVal SemItem_Ticket As clsSemItem = Nothing, Optional ByVal isStart As Boolean = Nothing, Optional ByVal isFinish As Boolean = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_Logentry = SemItem_LogEntry
        End If

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        If Not isStart = Nothing Then
            boolCreate = isStart
        End If

        If Not isFinish = Nothing Then
            boolFinish = isFinish
        End If
        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                               objSemItem_Logentry.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belonging_Done.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            If boolCreate = True Then
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                       objSemItem_Logentry.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_started_with.GUID).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Else
                    objSemItem_Result = del_006_Ticket_To_LastLogEntry()
                End If
            ElseIf boolFinish = True Then
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                       objSemItem_Logentry.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_finished_with.GUID).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Else
                    objSemItem_Result = del_006_Ticket_To_LastLogEntry()
                End If
            End If

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function

    Private Function save_006_Ticket_To_LastLogEntry() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Ticket_To_LastLogEntry As DataRowCollection
        Dim objDR_Ticket_To_LastLogEntry As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim boolAdd As Boolean = True

        objDRC_Ticket_To_LastLogEntry = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Ticket.GUID, _
                                                                                      objLocalConfig.SemItem_RelationType_Last_Done.GUID, _
                                                                                      objLocalConfig.SemItem_Type_LogEntry.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Ticket_To_LastLogEntry In objDRC_Ticket_To_LastLogEntry
            If objDR_Ticket_To_LastLogEntry.Item("GUID_Token_Right") = objSemItem_Logentry.GUID Then
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                       objDR_Ticket_To_LastLogEntry.Item("GUID_TokeN_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_Last_Done.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If

            End If
        Next

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                    objSemItem_Logentry.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_Last_Done.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result

    End Function

    Private Function del_006_Ticket_To_LastLogEntry() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Ticket_To_LastLogEntry As DataRowCollection
        Dim objDR_Ticket_To_LastLogEntry As DataRow
        Dim objDRC_LogState As DataRowCollection

        objDRC_Ticket_To_LastLogEntry = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Ticket.GUID, _
                                                                                      objLocalConfig.SemItem_RelationType_Last_Done.GUID, _
                                                                                      objLocalConfig.SemItem_Type_LogEntry.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Ticket_To_LastLogEntry In objDRC_Ticket_To_LastLogEntry
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                       objDR_Ticket_To_LastLogEntry.Item("GUID_TokeN_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_Last_Done.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next
        Return objSemItem_Result
    End Function
    Public Function save_007_Ticket_To_Process(ByVal SemItem_Process As clsSemItem, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Process = SemItem_Process
        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                objSemItem_Process.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_007_Ticket_To_Process(Optional ByVal SemItem_Process As clsSemItem = Nothing, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Ticket_To_Process As DataRowCollection
        Dim objDR_Ticket_To_Process As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Process Is Nothing Then
            objSemItem_Process = SemItem_Process
        End If

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objDRC_Ticket_To_Process = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Ticket.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                 objLocalConfig.SemItem_Type_Process.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Ticket_To_Process In objDRC_Ticket_To_Process
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                   objDR_Ticket_To_Process.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result

    End Function
    Public Function save_008_ProcessLastDone(Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_ProcessLastDone As DataRowCollection
        Dim objDRC_LogState As DataRowCollection



        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objDRC_ProcessLastDone = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Ticket.GUID, _
                                                                               objLocalConfig.SemItem_RelationType_Last_Done.GUID, _
                                                                               objLocalConfig.SemItem_Type_Process_Last_Done.GUID).Rows

        If objDRC_ProcessLastDone.Count = 0 Then
            objSemItem_ProcessLastDone = New clsSemItem
            objSemItem_ProcessLastDone.GUID = Guid.NewGuid
            objSemItem_ProcessLastDone.Name = objSemItem_Process.Name
            objSemItem_ProcessLastDone.GUID_Parent = objLocalConfig.SemItem_Type_Process_Last_Done.GUID
            objSemItem_ProcessLastDone.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_ProcessLastDone.GUID, _
                                                                 objSemItem_ProcessLastDone.Name, _
                                                                 objSemItem_ProcessLastDone.GUID_Parent, True).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_ProcessLastDone = New clsSemItem
            objSemItem_ProcessLastDone.GUID = objDRC_ProcessLastDone(0).Item("GUID_Process_Last_Done")
            objSemItem_ProcessLastDone.Name = objDRC_ProcessLastDone(0).Item("Name_Process_Last_Done")
            objSemItem_ProcessLastDone.GUID_Parent = objLocalConfig.SemItem_Type_Process_Last_Done.GUID
            objSemItem_ProcessLastDone.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If


        Return objSemItem_Result
    End Function

    Public Function del_008_ProcessLastDone(Optional ByVal SemItem_ProcessLastDone As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ProcessLastDone Is Nothing Then
            objSemItem_ProcessLastDone = SemItem_ProcessLastDone
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_ProcessLastDone.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function

    Public Function save_009_ProcessLastDone_To_ProcessItem(ByVal SemItem_ProcessItem As clsSemItem, Optional ByVal SemItem_ProcessLastDone As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ProcessLastDone_To_ProcessItem As DataRowCollection
        Dim objDR_ProcessLastDone_To_ProcessItem As DataRow
        Dim boolAdd As Boolean = True

        If Not SemItem_ProcessLastDone Is Nothing Then
            objSemItem_ProcessLastDone = SemItem_ProcessLastDone
        End If


        objSemItem_ProcessItem = SemItem_ProcessItem


        objDRC_ProcessLastDone_To_ProcessItem = funcA_TokenToken.GetData_By_GUDTokenLeft_And_GUIDRelationType(objSemItem_ProcessLastDone.GUID, _
                                                                                                              objLocalConfig.SemItem_RelationType_Last_Done.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_ProcessLastDone_To_ProcessItem In objDRC_ProcessLastDone_To_ProcessItem
            If objDR_ProcessLastDone_To_ProcessItem.Item("GUID_Token_Right") = objSemItem_ProcessItem.GUID Then
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ProcessLastDone.GUID, _
                                                                       objDR_ProcessLastDone_To_ProcessItem.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_Last_Done.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ProcessLastDone.GUID, _
                                                                    objSemItem_ProcessItem.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_Last_Done.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_009_ProcessLastDone_To_ProcessItem(Optional ByVal SemItem_ProcessLastDone As clsSemItem = Nothing, Optional ByVal SemItem_ProcessItem As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ProcessLastDone_To_ProcessItem As DataRowCollection
        Dim objDR_ProcessLastDone_To_ProcessItem As DataRow

        If Not SemItem_ProcessLastDone Is Nothing Then
            objSemItem_ProcessLastDone = SemItem_ProcessLastDone
        End If

        If Not SemItem_ProcessItem Is Nothing Then
            objSemItem_ProcessItem = SemItem_ProcessItem
        End If

        objDRC_ProcessLastDone_To_ProcessItem = funcA_TokenToken.GetData_By_GUDTokenLeft_And_GUIDRelationType(objSemItem_ProcessLastDone.GUID, _
                                                                                                              objLocalConfig.SemItem_RelationType_Last_Done.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_ProcessLastDone_To_ProcessItem In objDRC_ProcessLastDone_To_ProcessItem
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ProcessLastDone.GUID, _
                                                                   objSemItem_ProcessItem.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_Last_Done.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_010_Ticket_To_ProcessLastDone(Optional ByVal SemItem_ProcessLastDone As clsSemItem = Nothing, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Ticket_To_ProcessLastdone As DataRowCollection
        Dim objDR_Ticket_To_ProcessLastDone As DataRow
        Dim boolAdd As Boolean = True

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        If Not SemItem_ProcessLastDone Is Nothing Then
            objSemItem_ProcessLastDone = SemItem_ProcessLastDone
        End If

        objDRC_Ticket_To_ProcessLastdone = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Ticket.GUID, _
                                                                                         objLocalConfig.SemItem_RelationType_Last_Done.GUID, _
                                                                                         objSemItem_ProcessLastDone.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Ticket_To_ProcessLastDone In objDRC_Ticket_To_ProcessLastdone
            If objDR_Ticket_To_ProcessLastDone.Item("GUID_Token") = objSemItem_ProcessLastDone.GUID Then
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                       objDR_Ticket_To_ProcessLastDone.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_Last_Done.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                    objSemItem_ProcessLastDone.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_Last_Done.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        Return objSemItem_Result
    End Function

    Public Function del_010_Ticket_To_ProcessLastDone(Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Ticket_To_ProcessLastdone As DataRowCollection
        Dim objDR_Ticket_To_ProcessLastDone As DataRow

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If


        objDRC_Ticket_To_ProcessLastdone = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Ticket.GUID, _
                                                                                         objLocalConfig.SemItem_RelationType_Last_Done.GUID, _
                                                                                         objSemItem_ProcessLastDone.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Ticket_To_ProcessLastDone In objDRC_Ticket_To_ProcessLastdone
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                   objDR_Ticket_To_ProcessLastDone.Item("GUID_TokeN_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_Last_Done.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next
        Return objSemItem_Result
    End Function

    Public Function save_011_Ticket_To_User(Optional ByVal SemItem_User As clsSemItem = Nothing, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_User = SemItem_User

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        If objSemItem_User Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                    objLocalConfig.SemItem_User.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                    1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                    objSemItem_User.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                    objSemItem_User.Level).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        Return objSemItem_Result
    End Function

    Public Function del_011_Ticket_To_User(Optional ByVal SemItem_User As clsSemItem = Nothing, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objSemItem_User = SemItem_User

        If objSemItem_User Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                   objLocalConfig.SemItem_User.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                   objSemItem_User.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_012_Ticket_To_SemItem(ByVal SemItem_Ref As clsSemItem, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_SemItem As DataRowCollection
        Dim objDR_SemItem As DataRow
        Dim boolAdd As Boolean = True

        objSemItem_Ref = SemItem_Ref

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Error
        Select Case objSemItem_Ref.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_Attribute.GetData(objSemItem_Ref.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_RefOR = New clsSemItem
                    objSemItem_RefOR.GUID = objDRC_LogState(0).Item("GUID_ObjectReference")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                End If
            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_RelationType.GetData(objSemItem_Ref.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_RefOR = New clsSemItem
                    objSemItem_RefOR.GUID = objDRC_LogState(0).Item("GUID_ObjectReference")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                End If
            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_Token.GetData(objSemItem_Ref.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_RefOR = New clsSemItem
                    objSemItem_RefOR.GUID = objDRC_LogState(0).Item("GUID_ObjectReference")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                End If
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_Type.GetData(objSemItem_Ref.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_RefOR = New clsSemItem
                    objSemItem_RefOR.GUID = objDRC_LogState(0).Item("GUID_ObjectReference")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                End If
        End Select

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objDRC_SemItem = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objSemItem_Ticket.GUID, _
                                                                                           objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            For Each objDR_SemItem In objDRC_SemItem
                If objDR_SemItem.Item("GUID_ObjectReference") = objSemItem_RefOR.GUID Then
                    boolAdd = False
                Else
                    objDRC_LogState = semprocA_DBWork_Del_Token_OR.GetData(objSemItem_Ticket.GUID, _
                                                                           objDR_SemItem.Item("GUID_ObjectReference"), _
                                                                           objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        boolAdd = False
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                End If
            Next
            If boolAdd = True Then
                objDRC_LogState = semprocA_DBWork_Save_Token_OR.GetData(objSemItem_Ticket.GUID, _
                                                                        objSemItem_RefOR.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_012_Ticket_To_Semitem(Optional ByVal SemItem_RefOR As clsSemItem = Nothing, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_SemItem As DataRowCollection
        Dim objDR_SemItem As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket

        End If

        If Not SemItem_RefOR Is Nothing Then
            objSemItem_RefOR = SemItem_RefOR
        End If
        objDRC_SemItem = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objSemItem_Ticket.GUID, _
                                                                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_SemItem In objDRC_SemItem
            objDRC_LogState = semprocA_DBWork_Del_Token_OR.GetData(objSemItem_Ticket.GUID, _
                                                                   objSemItem_RefOR.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next


        Return objSemItem_Result
    End Function

    Public Function save_013_Ticket_To_ProcessLogIncident(ByVal SemItem_ProcessLogIncident As clsSemItem, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Ticket_To_ProcessLogIncident As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim intOrderID As Integer

        objSemItem_ProcessLogIncident = SemItem_ProcessLogIncident
        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objDRC_Ticket_To_ProcessLogIncident = semtblA_Token_Token.GetData_By_GUIDs(objSemItem_Ticket.GUID, _
                                                                                   objSemItem_ProcessLogIncident.GUID, _
                                                                                   objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_Ticket_To_ProcessLogIncident.Count = 0 Then
            If objSemItem_ProcessLogIncident.GUID_Parent = objLocalConfig.SemItem_Type_Process_Log.GUID Then
                intOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_Ticket.GUID, _
                                                                             objLocalConfig.SemItem_Type_Process_Log.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_contains.GUID) + 1
            Else
                intOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_Ticket.GUID, _
                                                                             objLocalConfig.SemItem_Type_Incident.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_contains.GUID) + 1
            End If
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                                    objSemItem_ProcessLogIncident.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                    intOrderID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If


        Return objSemItem_Result
    End Function

    Public Function del_013_Ticket_To_ProcessLogIncident(Optional ByVal SemItem_ProcessLogIncident As clsSemItem = Nothing, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ProcessLogIncident Is Nothing Then
            objSemItem_ProcessLogIncident = SemItem_ProcessLogIncident
        End If

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ticket.GUID, _
                                                               objSemItem_ProcessLogIncident.GUID, _
                                                               objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_014_Ticket__Description(ByVal Description As String, Optional ByVal SemItem_Ticket As clsSemItem = Nothing, Optional ByVal SemItem_TokenAttribute_Description As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Ticket__Description As DataRowCollection


        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objSemItem_TokenAttribute_Description = SemItem_TokenAttribute_Description

        If objSemItem_TokenAttribute_Description Is Nothing Then
            objDRC_Ticket__Description = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Ticket.GUID, _
                                                                                                                        objLocalConfig.SemItem_Attribute_Description.GUID).Rows
            If objDRC_Ticket__Description.Count = 0 Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_Ticket.GUID, _
                                                                                         objLocalConfig.SemItem_Attribute_Description.GUID, _
                                                                                         Nothing, _
                                                                                         Description, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_Ticket.GUID, _
                                                                                         objLocalConfig.SemItem_Attribute_Description.GUID, _
                                                                                         objDRC_Ticket__Description(0).Item("GUID_TokenAttribute"), _
                                                                                         Description, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_Ticket.GUID, _
                                                                                 objLocalConfig.SemItem_Attribute_Description.GUID, _
                                                                                 objSemItem_TokenAttribute_Description.GUID, _
                                                                                 Description, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        End If
        
        Return objSemItem_Result
    End Function

    Public Function del_014_Ticket__Description(Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Ticket__Description As DataRowCollection
        Dim objDR_Ticket__Description As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objDRC_Ticket__Description = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Ticket.GUID, _
                                                                                                                    objLocalConfig.SemItem_Attribute_Description.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Ticket__Description In objDRC_Ticket__Description
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Ticket__Description.Item("GUID_TokenAttribute")).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error

            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_015_Ticket_To_TicketList(ByVal SemItem_TicketList As clsSemItem, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_TicketList = SemItem_TicketList
        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_TicketList.GUID, _
                                                                objSemItem_Ticket.GUID, _
                                                                objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                objSemItem_TicketList.Level).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_015_Ticket_To_TicketList(Optional ByVal SemItem_TicketList As clsSemItem = Nothing, Optional ByVal SemItem_Ticket As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_TicketList Is Nothing Then
            objSemItem_TicketList = SemItem_TicketList
        End If

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_TicketList.GUID, _
                                                               objSemItem_Ticket.GUID, _
                                                               objLocalConfig.SemItem_RelationType_contains.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        procA_TokenAttribute_Int.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
        semtblA_Token_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenAttribute_Int.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_DateTime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_OR_Attribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_OR_RelationType.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_OR_Type.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token_OR.Connection = objLocalConfig.Connection_DB

        procA_ProcessItem_LastDone.Connection = objLocalConfig.Connection_Plugin

        objLogManagement = New clsLogManagement(objLocalConfig.Globals)
    End Sub
End Class
