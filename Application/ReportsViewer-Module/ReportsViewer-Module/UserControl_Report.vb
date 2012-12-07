Imports Sem_Manager
Public Class UserControl_Report

    Private objLocalConfig As clsLocalConfig

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

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
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
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

        objDRC_Data = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Report.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_is.GUID, _
                                                                    objLocalConfig.SemItem_Type_DBView.GUID).Rows

        If objDRC_Data.Count > 0 Then
            strView = objDRC_Data(0).Item("Name_Token_Right")
            objDRC_Data = funcA_TokenToken.GetData_TokenToken_LeftRight(objDRC_Data(0).Item("GUID_Token_Right"), _
                                                                        objLocalConfig.SemItem_RelationType_isPartOf.GUID, _
                                                                        objLocalConfig.SemItem_Type_DatabaseOnServer.GUID).Rows
            If objDRC_Data.Count > 0 Then
                objDRC_Data2 = funcA_TokenToken.GetData_TokenToken_LeftRight(objDRC_Data(0).Item("GUID_Token_Right"), _
                                                                             objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                             objLocalConfig.SemItem_Type_Database.GUID).Rows
                objDRC_Data = funcA_TokenToken.GetData_TokenToken_LeftRight(objDRC_Data(0).Item("GUID_Token_Right"), _
                                                                            objLocalConfig.SemItem_RelationType_locatedIn.GUID, _
                                                                            objLocalConfig.SemItem_Type_Server.GUID).Rows
                If objDRC_Data.Count > 0 And objDRC_Data2.Count > 0 Then
                    strDatabase = objDRC_Data2(0).Item("Name_Token_Right")
                    strServer = objDRC_Data(0).Item("Name_Token_Right")
                    strConn = "Data Source=" & strServer & "\SQLEXPRESS;Initial Catalog=" & strDatabase & ";Integrated Security=True"
                    objDataAdp = New SqlClient.SqlDataAdapter("SELECT * FROM [" & strDatabase & "]..[" & strView & "]", strConn)
                    Debug.Print(objLocalConfig.Connection_DB.ConnectionString)
                    objDataAdp.Fill(objDataSet)
                    objDataTable = objDataSet.Tables(0)

                    BindingSource_Reports.DataSource = objDataTable
                    DataGridView_Reports.DataSource = BindingSource_Reports
                End If
            End If
        End If
    End Sub
End Class
