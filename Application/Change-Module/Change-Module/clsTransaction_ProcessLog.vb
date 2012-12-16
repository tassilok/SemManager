Imports Sem_Manager
Public Class clsTransaction_ProcessLog
    Private objLocalConfig As clsLocalConfig

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private objSemItem_TokenAttribute_Description As clsSemItem
    Private objSemItem_ProcessLogIncident As clsSemItem
    Private objSemItem_Process As clsSemItem
    Private objSemItem_LogEntry As clsSemItem
    Private objSemItem_Parent As clsSemItem
    Private boolCreate As Boolean
    Private boolFinish As Boolean

    Public ReadOnly Property SemItem_LogEntry As clsSemItem
        Get
            Return objSemItem_LogEntry
        End Get
    End Property
    Public Function save_001_ProcessLogIncident(ByVal SemItem_ProcessLogIncident As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_ProcessLogIncident = SemItem_ProcessLogIncident

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                             objSemItem_ProcessLogIncident.Name, _
                                                             objSemItem_ProcessLogIncident.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_ProcessLogIncident(Optional ByVal SemItem_ProcessLogIncident As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ProcessLogIncident Is Nothing Then
            objSemItem_ProcessLogIncident = SemItem_ProcessLogIncident
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_ProcessLogIncident.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_ProcessLog_To_Process(ByVal SemItem_Process As clsSemItem, Optional ByVal SemItem_ProcessLogIncident As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ProcessLog_To_Process As DataRowCollection
        Dim objDR_ProcessLog_To_Process As DataRow
        Dim boolAdd As Boolean = True

        objSemItem_Process = SemItem_Process
        If Not SemItem_ProcessLogIncident Is Nothing Then
            objSemItem_ProcessLogIncident = SemItem_ProcessLogIncident
        End If
        If objSemItem_ProcessLogIncident.GUID_Parent = objLocalConfig.SemItem_Type_Process_Log.GUID Then
            objDRC_ProcessLog_To_Process = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLogIncident.GUID, _
                                                                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                         objLocalConfig.SemItem_Type_Process.GUID).Rows
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            For Each objDR_ProcessLog_To_Process In objDRC_ProcessLog_To_Process
                If objDR_ProcessLog_To_Process.Item("GUID_Token_Right") = objSemItem_Process.GUID Then
                    boolAdd = False
                Else
                    objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                                           objDR_ProcessLog_To_Process.Item("GUID_Token_Right"), _
                                                                           objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        boolAdd = False
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If

                End If
            Next
            If boolAdd = True Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                                        objSemItem_Process.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
                If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If


        Return objSemItem_Result
    End Function

    Public Function del_002_ProcessLog_To_Process(Optional ByVal SemItem_ProcessLogIncident As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ProcessLog_To_Process As DataRowCollection
        Dim objDR_ProcessLog_To_Process As DataRow

        If Not SemItem_ProcessLogIncident Is Nothing Then
            objSemItem_ProcessLogIncident = SemItem_ProcessLogIncident
        End If

        If objSemItem_ProcessLogIncident.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID Then
            objDRC_ProcessLog_To_Process = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLogIncident.GUID, _
                                                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                        objLocalConfig.SemItem_Type_Process.GUID).Rows
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            For Each objDR_ProcessLog_To_Process In objDRC_ProcessLog_To_Process
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                                           objDR_ProcessLog_To_Process.Item("GUID_Token_Right"), _
                                                                           objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If
        


        Return objSemItem_Result
    End Function

    Public Function save_003_ProcessLog_To_LogEntry(ByVal SemItem_LogEntry As clsSemItem, Optional ByVal SemItem_ProcessLogIncident As clsSemItem = Nothing, Optional ByVal forCreate As Boolean = False, Optional ByVal forFinish As Boolean = False) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_LogEntry = SemItem_LogEntry
        If Not SemItem_ProcessLogIncident Is Nothing Then
            objSemItem_ProcessLogIncident = SemItem_ProcessLogIncident
        End If
        boolCreate = forCreate
        boolFinish = forFinish
        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                                objSemItem_LogEntry.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging_Done.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            If boolCreate = True Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                                        objSemItem_LogEntry.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_started_with.GUID, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                         objSemItem_LogEntry.GUID, _
                                                         objLocalConfig.SemItem_RelationType_belonging_Done.GUID)
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            ElseIf boolFinish = True Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                                        objSemItem_LogEntry.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_finished_with.GUID, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                         objSemItem_LogEntry.GUID, _
                                                         objLocalConfig.SemItem_RelationType_belonging_Done.GUID)
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function del_003_ProcessLog_To_LogEntry(Optional ByVal SemItem_LogEntry As clsSemItem = Nothing, Optional ByVal SemItem_ProcessLogIncident As clsSemItem = Nothing, Optional ByVal forCreate As Boolean = Nothing, Optional ByVal forFinish As Boolean = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_LogEntry = SemItem_LogEntry
        End If
        If Not SemItem_ProcessLogIncident Is Nothing Then
            objSemItem_ProcessLogIncident = SemItem_ProcessLogIncident
        End If

        If Not forCreate = Nothing Then
            boolCreate = forCreate
        End If

        If Not forFinish = Nothing Then
            boolFinish = forFinish
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                               objSemItem_LogEntry.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belonging_Done.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            If boolCreate = True Then
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                                       objSemItem_LogEntry.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_started_with.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                          objSemItem_LogEntry.GUID, _
                                                          objLocalConfig.SemItem_RelationType_belonging_Done.GUID, 0)

                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            ElseIf boolFinish = True Then
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                                       objSemItem_LogEntry.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_finished_with.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                          objSemItem_LogEntry.GUID, _
                                                          objLocalConfig.SemItem_RelationType_belonging_Done.GUID, 0)

                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            End If
        Else

            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_ProcessLog__Description(ByVal Description As String, Optional ByVal SemItem_ProcessLog As clsSemItem = Nothing, Optional ByVal SemItem_TokenAttribute_Description As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Ticket__Description As DataRowCollection


        If Not SemItem_ProcessLog Is Nothing Then
            objSemItem_ProcessLogIncident = SemItem_ProcessLog
        End If

        objSemItem_TokenAttribute_Description = SemItem_TokenAttribute_Description

        If objSemItem_TokenAttribute_Description Is Nothing Then
            objDRC_Ticket__Description = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_ProcessLogIncident.GUID, _
                                                                                                                        objLocalConfig.SemItem_Attribute_Description.GUID).Rows
            If objDRC_Ticket__Description.Count = 0 Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_ProcessLogIncident.GUID, _
                                                                                         objLocalConfig.SemItem_Attribute_Description.GUID, _
                                                                                         Nothing, _
                                                                                         Description, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_ProcessLogIncident.GUID, _
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
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_ProcessLogIncident.GUID, _
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

    Public Function del_004_Ticket__Description(Optional ByVal SemItem_ProcessLog As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Ticket__Description As DataRowCollection
        Dim objDR_Ticket__Description As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ProcessLog Is Nothing Then
            objSemItem_ProcessLogIncident = SemItem_ProcessLog
        End If

        objDRC_Ticket__Description = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_ProcessLogIncident.GUID, _
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

    Public Function save_005_Incident_To_Parent(ByVal SemItem_Parent As clsSemItem, Optional ByVal SemItem_Incident As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Relation As DataRowCollection
        Dim GUID_RelationType As Guid
        Dim intOrderID As Integer


        If Not SemItem_Incident Is Nothing Then
            objSemItem_ProcessLogIncident = SemItem_Incident
        End If

        objSemItem_Parent = SemItem_Parent

        If objSemItem_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID Then
            GUID_RelationType = objLocalConfig.SemItem_RelationType_superordinate.GUID
        Else
            GUID_RelationType = objLocalConfig.SemItem_RelationType_contains.GUID
        End If

        objDRC_Relation = semtblA_Token_Token.GetData_By_GUIDs(objSemItem_Parent.GUID, objSemItem_ProcessLogIncident.GUID, GUID_RelationType).Rows
        If objDRC_Relation.Count = 0 Then
            intOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_Parent.GUID, _
                                                                         objLocalConfig.SemItem_Type_Incident.GUID, _
                                                                         GUID_RelationType)
            intOrderID = intOrderID + 1
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Parent.GUID, _
                                                                    objSemItem_ProcessLogIncident.GUID, _
                                                                    GUID_RelationType, intOrderID).Rows
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

    Public Function del_005_Incident_To_Parent(Optional ByVal SemItem_Parent As clsSemItem = Nothing, Optional ByVal SemItem_Incident As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim GUID_Relation As Guid

        If Not SemItem_Parent Is Nothing Then
            objSemItem_Parent = SemItem_Parent
        End If

        If Not objSemItem_ProcessLogIncident Is Nothing Then
            objSemItem_ProcessLogIncident = objSemItem_ProcessLogIncident
        End If

        If Not objSemItem_Parent Is Nothing Then
            If objSemItem_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID Then
                GUID_Relation = objLocalConfig.SemItem_RelationType_superordinate.GUID
            Else
                GUID_Relation = objLocalConfig.SemItem_RelationType_contains.GUID
            End If

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Parent.GUID, _
                                                                   objSemItem_ProcessLogIncident.GUID, _
                                                                   GUID_Relation).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
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
        semtblA_Token_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
