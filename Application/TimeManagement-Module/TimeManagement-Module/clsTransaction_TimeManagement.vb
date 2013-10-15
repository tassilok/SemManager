Imports Sem_Manager
Imports Log_Manager
Public Class clsTransaction_TimeManagement
    Private objLocalConfig As clsLocalConfig


    Private objLogManagement As clsLogManagement
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Datetime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter

    Private orgprocA_LogEntry_Of_TimeManagement As new DataSet_TimeManagementTableAdapters.orgproc_LogEntry_Of_TimeManagementTableAdapter

    Private objSemItem_TimeManagement As clsSemItem
    Private objSemItem_LogEntry_Start As clsSemItem
    Private objSemItem_TokenAttribute_Start As clsSemItem
    Private objSemItem_LogEntry_End As clsSemItem
    Private objSemItem_LogState As clsSemItem


    Public Function save_001_TimeManagement(SemItem_TimeManagement As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        
        objSemItem_TimeManagement = SemItem_TimeManagement

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_TimeManagement.GUID, _
                                                             objSemItem_TimeManagement.Name, _
                                                             objSemItem_TimeManagement.GUID_Parent, _
                                                             True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else 
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_TimeManagement(Optional  SemItem_TimeManagement As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        
        If Not SemItem_TimeManagement Is Nothing Then
            objSemItem_TimeManagement = SemItem_TimeManagement    
        End If
        

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_TimeManagement.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else 
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_LogEntry_Start(dateStart As DateTime, Optional  SemItem_TimeManagement As clsSemItem = Nothing) As clsSemItem
        Return save_002a_LogEntry_DateTimeStamp(dateStart,True, SemItem_TimeManagement)
    End Function

    Public Function save_003_LogEntry_End(dateEnd As DateTime, Optional  SemItem_TimeManagement As clsSemItem = Nothing) As clsSemItem
        Return save_002a_LogEntry_DateTimeStamp(dateEnd,false, SemItem_TimeManagement)
    End Function

    Public Function del_002_LogEntry_Start(optional SemItem_LogEntry_Start = Nothing) As clsSemItem
        
        If Not SemItem_LogEntry_Start Is Nothing Then
            objSemItem_LogEntry_Start = SemItem_LogEntry_Start    
        End If
        

        Return objLogManagement.del_LogEntry(objSemItem_LogEntry_Start.GUID)

    End Function

    Public Function del_003_LogEntry_End(optional SemItem_LogEntry_End = Nothing) As clsSemItem
        
        If Not SemItem_LogEntry_End Is Nothing Then
            objSemItem_LogEntry_End = SemItem_LogEntry_End    
        End If
        

        Return objLogManagement.del_LogEntry(objSemItem_LogEntry_End.GUID)

    End Function

 
    Private Function save_002a_LogEntry_DateTimeStamp(dateLogEntry As DateTime, boolStart As Boolean, Optional  SemItem_TimeManagement As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogEntries As DataRowCollection
        
        If Not SemItem_TimeManagement Is Nothing Then
            objSemItem_TimeManagement = SemItem_TimeManagement    
        End If

        objDRC_LogEntries = orgprocA_LogEntry_Of_TimeManagement.GetData(objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                        objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                        objSemItem_TimeManagement.GUID, _
                                                                        boolStart).Rows

        If objDRC_LogEntries.Count>0 Then
            objSemItem_LogEntry_Start = new clsSemItem With {.GUID = objDRC_LogEntries(0).Item("GUID_LogEntry"), _
                                                                 .Name = objDRC_LogEntries(0).Item("Name_LogEntry"), _
                                                                 .GUID_Parent = objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                 .GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID}
            objSemItem_TokenAttribute_Start = new clsSemItem With {.GUID = objDRC_LogEntries(0).Item("GUID_TokenAttribute_DateTimeStamp")}

            If objDRC_LogEntries(0).Item("DateTimeStamp") <> dateLogEntry Then


                objDRC_LogEntries = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_LogEntry_Start.GUID, _
                                                                                         objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                         objSemItem_TokenAttribute_Start.GUID, _
                                                                                         dateLogEntry,
                                                                                         If(boolStart,1,2)).Rows

                If Not objDRC_LogEntries(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else 
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else 
                

                objSemItem_Result = objLocalConfig.Globals.LogState_Success

            End If
        Else 
            If boolStart Then
                objSemItem_LogEntry_Start = objLogManagement.log_Entry(dateLogEntry,objLocalConfig.SemItem_Token_Logstate_Work.GUID,objLocalConfig.User.GUID)
            Else 
                objSemItem_LogEntry_End = objLogManagement.log_Entry(dateLogEntry,objLocalConfig.SemItem_Token_Logstate_Work.GUID,objLocalConfig.User.GUID)
            End If
            
            If Not objSemItem_LogEntry_Start Is Nothing Or Not objSemItem_LogEntry_End Is Nothing then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else 
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function


    Public Function save_004_TimeManagement_To_LogEntry_Start(optional SemItem_LogEntry_Start As clsSemItem = Nothing, Optional SemItem_TimeManagement As clsSemItem = Nothing) As clsSemItem
        Return save_004a_TimeManagement_To_LogEntry(True,SemItem_LogEntry_Start,SemItem_TimeManagement)
    End Function

    Public Function del_004_TimeManagement_To_LogEntry_Start(Optional  SemItem_TimeManagement As clsSemItem = Nothing) As clsSemItem
        Return del_004a_TimeManagement_To_LogEntries(True,SemItem_TimeManagement)
    End Function

    Public Function save_005_TimeManagement_To_LogEntry_End(optional SemItem_LogEntry_End As clsSemItem = Nothing, Optional SemItem_TimeManagement As clsSemItem = Nothing) As clsSemItem
        Return save_004a_TimeManagement_To_LogEntry(False,SemItem_LogEntry_End,SemItem_TimeManagement)
    End Function

    Public Function del_005_TimeManagement_To_LogEntry_End(Optional  SemItem_TimeManagement As clsSemItem = Nothing) As clsSemItem
        Return del_004a_TimeManagement_To_LogEntries(false,SemItem_TimeManagement)
    End Function

    Private Function del_004a_TimeManagement_To_LogEntries(boolStart As boolean, optional SemItem_TimeManagement As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_LogEntries As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If Not SemItem_TimeManagement Is Nothing Then
            objSemItem_TimeManagement = SemItem_TimeManagement
        End If

        objDRC_LogEntries = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_TimeManagement.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                          objLocalConfig.SemItem_Type_LogEntry.GUID).Rows

        For Each objDR_LogEntry As DataRow In objDRC_LogEntries
            If objDR_LogEntry.Item("OrderID") = if(boolStart,1,2) Then
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_TimeManagement.GUID, _
                                                                       objDR_LogEntry.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belonging.GUID).Rows
                If objDRC_LogEntries(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next
        Return objSemItem_Result
    End Function


    Private Function save_004a_TimeManagement_To_LogEntry(boolStart As Boolean, optional SemItem_LogEntry As clsSemItem = Nothing, Optional SemItem_TimeManagement As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogEntries As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_LogEntry Is Nothing Then
            If boolStart Then
                objSemItem_LogEntry_Start = SemItem_LogEntry
            Else 
                objSemItem_LogEntry_End = SemItem_LogEntry
            End If    
        End If

        If Not SemItem_TimeManagement Is Nothing Then
            objSemItem_TimeManagement = SemItem_TimeManagement
        End If
        
        objDRC_LogEntries = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_TimeManagement.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                          objLocalConfig.SemItem_Type_LogEntry.GUID).Rows
        
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_LogEntry As DataRow In objDRC_LogEntries
            If objDR_LogEntry.Item("OrderID") = if(boolStart,1,2) Then 
                Dim boolDel = True
                If objDR_LogEntry.Item("GUID_Token_Right") = if(boolStart,objSemItem_LogEntry_Start.GUID, objSemItem_LogEntry_End.GUID) Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    boolDel = False
                End If

                If boolDel Then
                    objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_TimeManagement.GUID, _
                                                                           If(boolStart,objSemItem_LogEntry_Start.GUID, objSemItem_LogEntry_End.GUID), _
                                                                           objLocalConfig.SemItem_RelationType_belonging.GUID).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_TimeManagement.GUID, _
                                                                    If (boolStart,objSemItem_LogEntry_Start.GUID, objSemItem_LogEntry_End.GUID), _
                                                                    objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                    If (boolStart,1,2)).Rows
            If not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else 
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_006_TimeManagement_To_LogState(SemItem_LogState As clsSemItem, Optional SemItem_TimeManagement As clsSemItem = Nothing) As clsSemItem
        dim objSemItem_Result As clsSemItem
        Dim objDRC_LogStates As DataRowCollection
        Dim objDRC_LogState  As DataRowCollection

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objSemItem_LogState = SemItem_LogState

        If Not SemItem_TimeManagement Is Nothing Then
            objSemItem_TimeManagement = SemItem_TimeManagement
        End If

        objDRC_LogStates = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_TimeManagement.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                         objLocalConfig.SemItem_type_Logstate.GUID).Rows

        For Each objDR_LogState As DataRow In objDRC_LogStates
            If objDRC_LogStates(0).Item("GUID_Token_Right") = objSemItem_LogState.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_TimeManagement.GUID, _
                                                                       objDR_LogState.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_isInState.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_TimeManagement.GUID, _
                                                                    objSemItem_LogState.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                    1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_006_TimeManagement_To_LogState(Optional SemItem_TimeManagement As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogStates As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_TimeManagement Is Nothing Then
            objSemItem_TimeManagement = SemItem_TimeManagement
        End If

        objDRC_LogStates = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_TimeManagement.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                         objLocalConfig.SemItem_type_Logstate.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_LogState As DataRow In objDRC_LogStates
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_TimeManagement.GUID, _
                                                                    objDR_LogState.Item("GUID_Token_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_isInState.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Sub New(LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private sub set_DBConnection()
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Datetime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        orgprocA_LogEntry_Of_TimeManagement.Connection = objLocalConfig.Connection_Plugin
        semtblA_Token_Token.Connection = objLocalConfig.Connection_DB

        objLogManagement = new clsLogManagement(objLocalConfig.Globals)
    End Sub
End Class
