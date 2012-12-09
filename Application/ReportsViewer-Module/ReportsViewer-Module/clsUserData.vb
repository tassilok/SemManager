Imports Sem_Manager
Public Class clsUserData
    Private objLocalConfig As clsLocalConfig
    Private strConnection_DB As String
    Private strConnection_Module As String

    Private procA_ReportTree As New DataSet_ReportsTableAdapters.proc_ReportTreeTableAdapter
    Private procT_ReportTree As New DataSet_Reports.proc_ReportTreeDataTable

    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private funcT_Token_OR As New ds_ObjectReference.func_Token_ORDataTable

    Private procA_Report As New DataSet_ReportsTableAdapters.proc_ReportTableAdapter
    Private procT_Report As New DataSet_Reports.proc_ReportDataTable

    Private objSemItem_Report As clsSemItem

    Private objThread_Data_ReportTree As Threading.Thread
    Private objThread_Data_Reports As Threading.Thread
    Private objThread_Data_Report As Threading.Thread

    Private boolData_ReportTree As Boolean
    Private boolData_Reports As Boolean
    Private boolData_Report As Boolean

    Public ReadOnly Property ReportTree_procT As DataSet_Reports.proc_ReportTreeDataTable
        Get
            Return procT_ReportTree
        End Get
    End Property

    Public ReadOnly Property Report_procT As DataSet_Reports.proc_ReportDataTable
        Get
            Return procT_Report
        End Get
    End Property


    Public ReadOnly Property finished_Data_ReportTree As Boolean
        Get
            Return boolData_ReportTree
        End Get
    End Property

    Public ReadOnly Property finished_Data_Reports As Boolean
        Get
            Return boolData_Reports
        End Get
    End Property

    Public ReadOnly Property finished_Data_Report As Boolean
        Get
            Return boolData_Report
        End Get
    End Property

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Public Sub initailze_ReportTree()
        boolData_ReportTree = False
        objThread_Data_ReportTree = New Threading.Thread(AddressOf get_Data_ReportTree)
        objThread_Data_ReportTree.Start()
    End Sub

    Public Sub initialize_Reports()
        boolData_Reports = False
        objThread_Data_Reports = New Threading.Thread(AddressOf get_Data_Reports)
        objThread_Data_Reports.Start()
    End Sub

    Public Sub initialize_Report(ByVal SemItem_Report As clsSemItem)
        boolData_Report = False
        objSemItem_Report = SemItem_Report
        objThread_Data_Report = New Threading.Thread(AddressOf get_Data_Report)
        objThread_Data_Report.Start()
    End Sub

    Private Sub get_Data_Report()
        procA_Report.Connection = New SqlClient.SqlConnection(strConnection_Module)
        procA_Report.Fill(procT_Report, _
                          objLocalConfig.SemItem_Type_Reports.GUID, _
                          objLocalConfig.SemItem_Type_Report_Type.GUID, _
                          objLocalConfig.SemItem_Type_Database_on_Server.GUID, _
                          objLocalConfig.SemItem_Type_DB_Views.GUID, _
                          objLocalConfig.SemItem_Type_Database.GUID, _
                          objLocalConfig.SemItem_Type_Server.GUID, _
                          objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                          objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                          objLocalConfig.SemItem_RelationType_is.GUID, _
                          objLocalConfig.SemItem_RelationType_contains.GUID, _
                          objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                          objSemItem_Report.GUID, _
                          objLocalConfig.SemItem_Token_Report_Type_View.GUID, _
                          objLocalConfig.SemItem_Token_Report_Type_Token_Report.GUID)

        boolData_Report = True
    End Sub

    Private Sub get_Data_ReportTree()
        procA_ReportTree.Connection = New SqlClient.SqlConnection(strConnection_Module)
        procA_ReportTree.Fill(procT_ReportTree, _
                              objLocalConfig.SemItem_Type_Reports.GUID, _
                              objLocalConfig.SemItem_Type_Report_Type.GUID, _
                              objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                              objLocalConfig.SemItem_RelationType_contains.GUID)


        boolData_ReportTree = True
    End Sub

    Private Sub get_Data_Reports()

        boolData_Reports = True
    End Sub

    Private Sub set_DBConnection()
        strConnection_DB = objLocalConfig.Connection_DB.ConnectionString
        strConnection_Module = objLocalConfig.Connection_Plugin.ConnectionString
    End Sub
End Class
