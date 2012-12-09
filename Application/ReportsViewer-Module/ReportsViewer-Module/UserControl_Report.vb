Imports Sem_Manager
Public Class UserControl_Report

    Private objLocalConfig As clsLocalConfig

    Private objUserData As clsUserData

    Private objDataTable As DataTable
    Private objDataAdp As SqlClient.SqlDataAdapter
    Private objDataSet As DataSet
    Private objSemItem_Report As clsSemItem

    Private strView As String
    Private strProcedure As String
    Private strDatabase As String
    Private strServer As String

    Private strConn As String

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        objLocalConfig = LocalConfig
        
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objUserData = New clsUserData(objLocalConfig)
    End Sub

    Public Sub initialize(ByVal SemItem_Report As clsSemItem)
        objDataTable = New DataTable
        objDataSet = New DataSet
        objSemItem_Report = SemItem_Report
        If objSemItem_Report Is Nothing Then
            objDataTable.Clear()
        Else
            get_Data()
        End If
    End Sub

    Private Sub get_Data()
        Dim objDRC_Data As DataRowCollection
        Dim objDRC_Data2 As DataRowCollection

        objDataTable.Clear()

        objUserData.initialize_Report(objSemItem_Report)
        Timer_Data.Start()
        
    End Sub

    Private Sub Timer_Data_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Data.Tick
        If objUserData.finished_Data_Report = True Then
            If objUserData.Report_procT.Rows.Count > 0 Then
                strView = objUserData.Report_procT.Rows(0).Item("Name_DBItem")

                strDatabase = objUserData.Report_procT.Rows(0).Item("Name_Database")
                strServer = objUserData.Report_procT.Rows(0).Item("Name_Server")
                strConn = "Data Source=" & strServer & "\SQLEXPRESS;Initial Catalog=" & strDatabase & ";Integrated Security=True"
                objDataAdp = New SqlClient.SqlDataAdapter("SELECT * FROM [" & strDatabase & "]..[" & strView & "]", strConn)
                Debug.Print(objLocalConfig.Connection_DB.ConnectionString)
                objDataAdp.Fill(objDataSet)
                objDataTable = objDataSet.Tables(0)

                BindingSource_Reports.DataSource = objDataTable
                DataGridView_Reports.DataSource = BindingSource_Reports
                BindingNavigator_Reports.BindingSource = BindingSource_Reports


                Timer_Data.Stop()
            End If
        End If
        
    End Sub
End Class
