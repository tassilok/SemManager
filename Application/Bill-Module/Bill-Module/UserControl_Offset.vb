Imports Sem_Manager
Public Class UserControl_Offset

    Private objLocalConfig As clsLocalConfig

    Private objSemItem_FinancialTransaction As clsSemItem
    Private procA_Offset_Of_FinancialTransaction As New ds_FinancialTransactionTableAdapters.proc_Offset_Of_FinancialTransactionTableAdapter
    Private procT_Offset_Of_FinancialTransaction As New ds_FinancialTransaction.proc_Offset_Of_FinancialTransactionDataTable

    Private dblAmount1 As Double
    Private dblAmount2 As Double

    Public WriteOnly Property Amount_Offset1 As Double
        Set(ByVal value As Double)
            dblAmount2 = value
            calc_Offset()
        End Set
    End Property
    Private Sub calc_Offset()

        If dblAmount1 > dblAmount2 Then
            ToolStripLabel_Calc.Text = dblAmount1 - dblAmount2
        Else
            ToolStripLabel_Calc.Text = dblAmount2 - dblAmount1
        End If
    End Sub
    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Public Sub initialize_Offset(ByVal SemItem_FinancialTransaction)
        objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        get_Data_Offset()
        fill_DataGrid()
    End Sub

    Private Sub initialize()

        set_DBConnection()
        get_Data_Offset()
        fill_DataGrid()
    End Sub

    Private Sub get_Data_Offset()
        If objSemItem_FinancialTransaction Is Nothing Then
            procT_Offset_Of_FinancialTransaction.Clear()
        Else
            procA_Offset_Of_FinancialTransaction.Fill(procT_Offset_Of_FinancialTransaction, _
                                                  objLocalConfig.SemItem_Attribute_Betrag.GUID, _
                                                  objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                  objLocalConfig.SemItem_Type_Offset.GUID, _
                                                  objLocalConfig.SemItem_RelationType_accountings.GUID, _
                                                  objSemItem_FinancialTransaction.GUID)
        End If
        

    End Sub

    Private Sub fill_DataGrid()
        BindingSource_Offset.DataSource = procT_Offset_Of_FinancialTransaction
        DataGridView_Offset.DataSource = BindingSource_Offset

        DataGridView_Offset.Columns(0).Visible = False
        DataGridView_Offset.Columns(1).Visible = False
        DataGridView_Offset.Columns(2).Visible = False
        DataGridView_Offset.Columns(3).Visible = False
        DataGridView_Offset.Columns(4).Visible = False
        DataGridView_Offset.Columns(5).Visible = False
        DataGridView_Offset.Columns(6).Visible = False

        DataGridView_Offset.Columns(8).Visible = False
        DataGridView_Offset.Columns(9).Visible = False

        If IsDBNull(procT_Offset_Of_FinancialTransaction.Compute("SUM(Betrag)", "")) Then
            dblAmount1 = 0
        Else
            dblAmount1 = procT_Offset_Of_FinancialTransaction.Compute("SUM(Betrag)", "")
        End If

        ToolStripLabel_Sum.Text = dblAmount1.ToString


        ToolStripLabel_ItemCount.Text = DataGridView_Offset.RowCount
        ToolStripLabel_Calc.Text = "0"
        calc_Offset()
    End Sub

    Private Sub set_DBConnection()
        procA_Offset_Of_FinancialTransaction.Connection = objLocalConfig.Connection_Plugin

    End Sub
End Class
