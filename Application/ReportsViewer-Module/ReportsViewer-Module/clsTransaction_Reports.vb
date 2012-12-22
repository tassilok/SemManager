Imports Sem_Manager
Public Class clsTransaction_Reports

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private objLocalConfig As clsLocalConfig

    Private objSemItem_DBColumn As clsSemItem
    Private objSemItem_View As clsSemItem
    Private objSemItem_ReportField As clsSemItem
    Private objSemItem_Report As clsSemItem
    Private objSemItem_Report_Parent As clsSemItem

    Public Function save_001_DBColumn(ByVal SemItem_DBColumn As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_DBColumn = SemItem_DBColumn

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DBColumn.GUID, _
                                                             objSemItem_DBColumn.Name, _
                                                             objSemItem_DBColumn.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_DBColumn(Optional ByVal SemItem_DBColumn As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_DBColumn Is Nothing Then
            objSemItem_DBColumn = SemItem_DBColumn
        End If


        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_DBColumn.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function


    Public Function save_002_DBColumn_To_View(ByVal SemItem_View As clsSemItem, Optional ByVal SemItem_DBColumn As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_View = SemItem_View

        If Not SemItem_DBColumn Is Nothing Then
            objSemItem_DBColumn = SemItem_DBColumn
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBColumn.GUID, _
                                                                objSemItem_View.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_DBColumn_To_View(Optional ByVal SemItem_View As clsSemItem = Nothing, Optional ByVal SemItem_DBColumn As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_View = SemItem_View

        If Not SemItem_DBColumn Is Nothing Then
            objSemItem_DBColumn = SemItem_DBColumn
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBColumn.GUID, _
                                                                objSemItem_View.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_003_ReportField(ByVal SemItem_ReportField As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_ReportField = SemItem_ReportField

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_ReportField.GUID, _
                                                             objSemItem_ReportField.Name, _
                                                             objSemItem_ReportField.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_ReportField(Optional ByVal SemItem_ReportField As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_ReportField = SemItem_ReportField

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_ReportField.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_ReportField_To_Report(ByVal SemItem_Report As clsSemItem, Optional ByVal SemItem_ReportField As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Report = SemItem_Report

        If Not SemItem_ReportField Is Nothing Then
            objSemItem_ReportField = SemItem_ReportField
        End If


        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ReportField.GUID, _
                                                                objSemItem_Report.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_ReportField_To_Report(Optional ByVal SemItem_Report As clsSemItem = Nothing, Optional ByVal SemItem_ReportField As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If SemItem_Report Is Nothing Then
            objSemItem_Report = SemItem_Report
        End If

        If Not SemItem_ReportField Is Nothing Then
            objSemItem_ReportField = SemItem_ReportField
        End If


        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ReportField.GUID, _
                                                               objSemItem_Report.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_005_ReportField_To_DBColumn(Optional ByVal SemItem_DBColumn As clsSemItem = Nothing, Optional ByVal SemItem_ReportField As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_DBColumn Is Nothing Then
            objSemItem_DBColumn = SemItem_DBColumn
        End If

        If Not SemItem_ReportField Is Nothing Then
            objSemItem_ReportField = SemItem_ReportField
        End If


        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ReportField.GUID, _
                                                                objSemItem_DBColumn.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_ReportField_To_Report(Optional ByVal SemItem_DBColumn As clsSemItem = Nothing, Optional ByVal SemItem_ReportField As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If SemItem_DBColumn Is Nothing Then
            objSemItem_DBColumn = SemItem_DBColumn
        End If

        If Not SemItem_ReportField Is Nothing Then
            objSemItem_ReportField = SemItem_ReportField
        End If


        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ReportField.GUID, _
                                                               objSemItem_DBColumn.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_006_Report(ByVal SemItem_Report As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Report = SemItem_Report

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Report.GUID, _
                                                             objSemItem_Report.Name, _
                                                             objSemItem_Report.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_006_Report(Optional ByVal SemItem_Report As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Report Is Nothing Then
            objSemItem_Report = SemItem_Report
        End If


        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Report.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_007_Report_to_Report(ByVal SemItem_Report_Parent As clsSemItem, Optional ByVal SemItem_Report As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Report_Parent = SemItem_Report_Parent

        If Not SemItem_Report Is Nothing Then
            objSemItem_Report = SemItem_Report
        End If


        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Report_Parent.GUID, _
                                                             objSemItem_Report.GUID, _
                                                             objLocalConfig.SemItem_RelationType_contains.GUID, 1).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_007_Report_to_Report(Optional ByVal SemItem_Report_Parent As clsSemItem = Nothing, Optional ByVal SemItem_Report As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Report_Parent Is Nothing Then
            objSemItem_Report_Parent = SemItem_Report_Parent
        End If


        If Not SemItem_Report Is Nothing Then
            objSemItem_Report = SemItem_Report
        End If


        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Report_Parent.GUID, _
                                                             objSemItem_Report.GUID, _
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
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
