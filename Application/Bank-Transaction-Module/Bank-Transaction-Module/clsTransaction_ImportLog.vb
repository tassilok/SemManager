Imports Sem_Manager
Public Class clsTransaction_ImportLog
    Private objLocalConfig As clsLocalConfig

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private semprocA_DBWork_Save_TokenAttribute_DateTime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objSemItem_ImportLog As clsSemItem
    Private objSemItem_ImportSetting As clsSemItem
    Private objSemItem_LogEntry As clsSemItem

    Private objSemItem_TokenAttribute_Start As clsSemItem

    Public Function save_001_ImportLog(ByVal SemItem_ImportLog As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_ImportLog = SemItem_ImportLog

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_ImportLog.GUID, _
                                                             objSemItem_ImportLog.Name, _
                                                             objSemItem_ImportLog.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_ImportLog(Optional ByVal SemItem_ImportLog As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_ImportLog = SemItem_ImportLog

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_ImportLog.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Start(ByVal dateStart As Date, Optional ByVal SemItem_ImportLog As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ImportLog Is Nothing Then
            objSemItem_ImportLog = SemItem_ImportLog
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DateTime.GetData(objSemItem_ImportLog.GUID, _
                                                                               objLocalConfig.SemItem_Attribute_Start.GUID, _
                                                                               Nothing, _
                                                                               dateStart, 0).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_TokenAttribute_Start = New clsSemItem
            objSemItem_TokenAttribute_Start.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_Start(Optional ByVal SemItem_TokenAttribute_Start As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_TokenAttribute_Start Is Nothing Then
            objSemItem_TokenAttribute_Start = SemItem_TokenAttribute_Start
        End If
        

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_TokenAttribute_Start.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_003_ImportLog_To_ImportSetting(ByVal SemItem_ImportSetting As clsSemItem, Optional ByVal SemItem_ImportLog As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_ImportSetting = SemItem_ImportSetting
        If Not SemItem_ImportLog Is Nothing Then
            objSemItem_ImportLog = SemItem_ImportLog
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ImportLog.GUID, _
                                                                objSemItem_ImportSetting.GUID, _
                                                                objLocalConfig.SemItem_RelationType_Log_of.GUID, 0).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function del_003_ImportLog_To_ImportSetting(Optional ByVal SemItem_ImportSetting As clsSemItem = Nothing, Optional ByVal SemItem_ImportLog As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ImportSetting Is Nothing Then
            objSemItem_ImportSetting = SemItem_ImportSetting
        End If

        If Not SemItem_ImportLog Is Nothing Then
            objSemItem_ImportLog = SemItem_ImportLog
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ImportLog.GUID, _
                                                                objSemItem_ImportSetting.GUID, _
                                                                objLocalConfig.SemItem_RelationType_Log_of.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function save_004_ImportLog_To_LogEntry(ByVal SemItem_LogEntry As clsSemItem, Optional ByVal SemItem_ImportLog As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        objSemItem_LogEntry = SemItem_LogEntry
        If Not SemItem_ImportLog Is Nothing Then
            objSemItem_ImportLog = SemItem_ImportLog
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ImportLog.GUID, _
                                                                objSemItem_LogEntry.GUID, _
                                                                objLocalConfig.SemItem_RelationType_was_finished_with.GUID, 0).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function del_004_ImportLog_To_LogEntry(Optional ByVal SemItem_LogEntry As clsSemItem = Nothing, Optional ByVal SemItem_ImportLog As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        objSemItem_LogEntry = objSemItem_LogEntry
        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_LogEntry = SemItem_LogEntry
        End If
        If Not SemItem_ImportLog Is Nothing Then
            objSemItem_ImportLog = SemItem_ImportLog
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ImportLog.GUID, _
                                                                objSemItem_LogEntry.GUID, _
                                                                objLocalConfig.SemItem_RelationType_was_finished_with.GUID).Rows

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
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenAttribute_DateTime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
