Public Class UserControl_DBSelection

    Private objLocalConfig As clsLocalConfig_SemManager
    Private chngtblA_DB As ds_ChangeTableAdapters.chngtbl_DBTableAdapter
    Private chngtblT_DB As ds_Change.chngtbl_DBDataTable
    Private objSemItems_Selected() As clsSemItem
    Public Event Cancel()
    Public Event Apply(ByVal SemItems_Applied() As clsSemItem)

    Private Sub ToolStripButton_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Cancel.Click
        RaiseEvent Cancel()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()


        objLocalConfig = New clsLocalConfig_SemManager(Globals)
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        set_DBConnection()
        get_DBs()
        fill_DG()
    End Sub

    Private Sub get_DBs()
        chngtblA_DB.Fill(chngtblT_DB)
    End Sub

    Private Sub fill_DG()
        BindingSource_Databases.DataSource = chngtblT_DB
        DataGridView_Databases.DataSource = BindingSource_Databases
        DataGridView_Databases.Columns(0).Visible = False
    End Sub

    Private Sub set_DBConnection()
        chngtblA_DB.Connection = objLocalConfig.Connection_Config
    End Sub

    Private Sub DataGridView_Databases_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Databases.SelectionChanged
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim i As Integer

        ToolStripButton_Apply.Enabled = False

        If DataGridView_Databases.SelectedRows.Count > 0 Then
            ReDim objSemItems_Selected(DataGridView_Databases.SelectedRows.Count)
            For i = 0 To DataGridView_Databases.SelectedRows.Count - 1
                objDGVR_Selected = DataGridView_Databases.SelectedRows(i)
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                objSemItems_Selected(i) = New clsSemItem
                objSemItems_Selected(i).GUID = objDRV_Selected.Item("GUID_DB")
                objSemItems_Selected(i).Name = objDRV_Selected.Item("Name_DB")
                objSemItems_Selected(i).Mark = objDRV_Selected.Item("is_SystemDB")
                ToolStripButton_Apply.Enabled = True
            Next
        End If
    End Sub

    Private Sub ToolStripButton_Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Apply.Click
        RaiseEvent Apply(objSemItems_Selected)
    End Sub
End Class
