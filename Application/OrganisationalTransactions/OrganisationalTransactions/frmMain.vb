Imports Sem_Manager
Public Class frmMain
    Private objLocalConfig As clsLocalConfig
    Private objFrmSemManager As frmSemManager
    Private WithEvents objUserControl_Menge As UserControl_Menge
    Private WithEvents objUserControl_Flaeche As UserControl_Flaeche

    Private procA_Menge As New ds_MengeTableAdapters.proc_MengeTableAdapter
    Private procT_Menge As New ds_Menge.proc_MengeDataTable

    Private procA_Flaechen As New ds_MengeTableAdapters.proc_FlaechenTableAdapter
    Private procT_Flaechen As New ds_Menge.proc_FlaechenDataTable

    Private Sub saved_Flaeche(ByVal objSemItem_Flaeche As clsSemItem) Handles objUserControl_Flaeche.saved_Flaeche
        If Not objSemItem_Flaeche Is Nothing Then
            get_Flaeche()
            BindingSource_Flaeche.Filter = "GUID_Flaeche='" & objSemItem_Flaeche.GUID.ToString & "'"
        End If
    End Sub

    Private Sub saved_Menge(ByVal objSemItem_Menge As clsSemItem) Handles objUserControl_Menge.saved_Menge
        If Not objSemItem_Menge Is Nothing Then
            get_Menge()
            BindingSource_Menge.Filter = "GUID_Menge='" & objSemItem_Menge.GUID.ToString & "'"
        End If
        
    End Sub
    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Close()
    End Sub

    Private Sub configure_TabPages()
        Select Case TabControl1.SelectedTab.Name
            Case TabPage_Menge.Name
                objUserControl_Menge.clear_Menge()
                BindingSource_Menge.Filter = ""
                get_Menge()
            Case TabPage_Flaeche.Name
                objUserControl_Flaeche.clear_Flaeche()
                BindingSource_Flaeche.Filter = ""
                get_Flaeche()
        End Select
    End Sub

    Private Sub get_Flaeche()
        procA_Flaechen.Fill(procT_Flaechen, _
                            objLocalConfig.SemItem_Attribute_Menge.GUID, _
                               objLocalConfig.SemItem_Type_Menge.GUID, _
                               objLocalConfig.SemItem_Type_Einheit.GUID, _
                               objLocalConfig.SemItem_Type_Fl_che.GUID, _
                               objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                               objLocalConfig.SemItem_RelationType_x.GUID, _
                               objLocalConfig.SemItem_RelationType_y.GUID)
        BindingSource_Flaeche.DataSource = procT_Flaechen

        DataGridView_Flaeche.DataSource = BindingSource_Flaeche
        DataGridView_Flaeche.Columns(0).Visible = False
        DataGridView_Flaeche.Columns(1).Visible = False
        DataGridView_Flaeche.Columns(2).Visible = False
        DataGridView_Flaeche.Columns(3).Visible = False

        DataGridView_Flaeche.Columns(5).Visible = False
        DataGridView_Flaeche.Columns(6).Visible = False
        DataGridView_Flaeche.Columns(7).Visible = False
        DataGridView_Flaeche.Columns(8).Visible = False
        DataGridView_Flaeche.Columns(9).Visible = False
        DataGridView_Flaeche.Columns(10).Visible = False
        DataGridView_Flaeche.Columns(11).Visible = False

        DataGridView_Flaeche.Columns(13).Visible = False
        DataGridView_Flaeche.Columns(14).Visible = False
        DataGridView_Flaeche.Columns(15).Visible = False
        DataGridView_Flaeche.Columns(16).Visible = False
        DataGridView_Flaeche.Columns(17).Visible = False
        DataGridView_Flaeche.Columns(18).Visible = False

        ToolStripLabel_Count_Flaeche.Text = DataGridView_Flaeche.RowCount.ToString
    End Sub

    Private Sub get_Menge()

        procA_Menge.Fill(procT_Menge, _
                         objLocalConfig.SemItem_Attribute_Menge.GUID, _
                         objLocalConfig.SemItem_Type_Menge.GUID, _
                         objLocalConfig.SemItem_Type_Einheit.GUID, _
                         objLocalConfig.SemItem_RelationType_is_of_Type.GUID)

        BindingSource_Menge.DataSource = procT_Menge
        BindingSource_Menge.Filter = ""
        DataGridView_Menge.DataSource = BindingSource_Menge

        DataGridView_Menge.Columns(0).Visible = False
        DataGridView_Menge.Columns(2).Visible = False
        DataGridView_Menge.Columns(3).Visible = False
        DataGridView_Menge.Columns(4).Visible = False
        DataGridView_Menge.Columns(5).Visible = False
        DataGridView_Menge.Columns(6).Visible = False
        DataGridView_Menge.Columns(7).Visible = False

        ToolStripLabel_Count_Menge.Text = DataGridView_Menge.RowCount.ToString
    End Sub

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        set_DBConnection()
        objUserControl_Menge = New UserControl_Menge(objLocalConfig, Me)
        objUserControl_Menge.Dock = DockStyle.Fill
        objUserControl_Flaeche = New UserControl_Flaeche(objLocalConfig, Me)
        objUserControl_Flaeche.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(objUserControl_Menge)
        SplitContainer2.Panel2.Controls.Clear()
        SplitContainer2.Panel2.Controls.Add(objUserControl_Flaeche)
        configure_TabPages()
    End Sub

    Private Sub set_DBConnection()
        procA_Menge.Connection = objLocalConfig.Connection_Plugin
        procA_Flaechen.Connection = objLocalConfig.Connection_Plugin
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        configure_TabPages()
    End Sub

    Private Sub DataGridView_Menge_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Menge.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Menge As New clsSemItem

        Dim objFrm_TokenEdit As frmTokenEdit

        objDGVR_Selected = DataGridView_Menge.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Menge.GUID = objDRV_Selected.Item("GUID_Menge")
        objSemItem_Menge.Name = objDRV_Selected.Item("Name_Menge")
        objSemItem_Menge.GUID_Parent = objLocalConfig.SemItem_Type_Menge.GUID
        objSemItem_Menge.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrm_TokenEdit = New frmTokenEdit(objSemItem_Menge, objLocalConfig.Globals)
        objFrm_TokenEdit.ShowDialog(Me)
        get_Menge()

    End Sub

    Private Sub DataGridView_Menge_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Menge.SelectionChanged
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Einheit As New clsSemItem

        objUserControl_Menge.clear_Menge()
        If DataGridView_Menge.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Menge.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_Einheit.GUID = objDRV_Selected.Item("GUID_Einheit")
            objSemItem_Einheit.Name = objDRV_Selected.Item("Name_Einheit")
            objSemItem_Einheit.GUID_Parent = objLocalConfig.SemItem_Type_Einheit.GUID
            objSemItem_Einheit.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objUserControl_Menge.initialize_Menge(objSemItem_Einheit, objDRV_Selected.Item("Menge"))
        End If
    End Sub

    Private Sub ToolStripButton_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_New.Click
        objUserControl_Menge.clear_Menge()
        BindingSource_Menge.Position = -1
    End Sub

    Private Sub DataGridView_Flaeche_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Flaeche.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Flaeche As New clsSemItem

        Dim objFrm_TokenEdit As frmTokenEdit

        objDGVR_Selected = DataGridView_Flaeche.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Flaeche.GUID = objDRV_Selected.Item("GUID_Flaeche")
        objSemItem_Flaeche.Name = objDRV_Selected.Item("Name_Flaeche")
        objSemItem_Flaeche.GUID_Parent = objLocalConfig.SemItem_Type_Fl_che.GUID
        objSemItem_Flaeche.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrm_TokenEdit = New frmTokenEdit(objSemItem_Flaeche, objLocalConfig.Globals)
        objFrm_TokenEdit.ShowDialog(Me)
        get_Flaeche()
    End Sub

    Private Sub DataGridView_Flaeche_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Flaeche.SelectionChanged
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Einheit_X As New clsSemItem
        Dim objSemItem_Einheit_Y As New clsSemItem

        objUserControl_Flaeche.clear_Flaeche()
        If DataGridView_Flaeche.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Flaeche.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_Einheit_X.GUID = objDRV_Selected.Item("GUID_Einheit_X")
            objSemItem_Einheit_X.Name = objDRV_Selected.Item("Name_Einheit_X")
            objSemItem_Einheit_X.GUID_Parent = objDRV_Selected.Item("GUID_Type_Einhiet_X")
            objSemItem_Einheit_X.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Einheit_Y.GUID = objDRV_Selected.Item("GUID_Einheit_Y")
            objSemItem_Einheit_Y.Name = objDRV_Selected.Item("Name_Einheit_Y")
            objSemItem_Einheit_Y.GUID_Parent = objDRV_Selected.Item("GUID_Type_Einheit_Y")
            objSemItem_Einheit_Y.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objUserControl_Flaeche.initialize_Flaeche(objDRV_Selected.Item("Flaeche"), objDRV_Selected.Item("Menge_X"), objSemItem_Einheit_X, objDRV_Selected.Item("Menge_Y"), objSemItem_Einheit_Y)
        End If
    End Sub

    Private Sub ToolStripButton_NewFlaeche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_NewFlaeche.Click
        objUserControl_Flaeche.clear_Flaeche()
        BindingSource_Flaeche.Position = -1

    End Sub
End Class
