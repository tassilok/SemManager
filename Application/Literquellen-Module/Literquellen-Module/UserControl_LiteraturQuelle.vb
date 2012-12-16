Imports Sem_Manager
Public Class UserControl_LiteraturQuelle

    Private procA_LiteraturQuelle As New DataSet_LiteraturQuelleTableAdapters.proc_LiteraturQuelleTableAdapter
    Private procT_LiteraturQuelle As New DataSet_LiteraturQuelle.proc_LiteraturQuelleDataTable

    Private objFRM_TokenEdit As frmTokenEdit
    Private objFRMSemManager As frmSemManager
    Private objDLG_Attribute_VARCHAR255 As dlgAttribute_Varchar255

    Private objTransaction_LiteraturQuelle As clsTransaction_LiteraturQuelle
    

    Private objLocalConfig As clsLocalConfig

    Private boolPChange As Boolean

    Public Event select_Quelle()
    Public Event add_LiteraturQuelle()
    Public Event del_LiteraturQuelle(ByVal SemItem_LiteraturQuelle As clsSemItem)

    Public Sub refresh_Quellen(Optional ByVal SemItem_Quelle As clsSemItem = Nothing)
        fill_LiteraturQuelle()
        If Not SemItem_Quelle Is Nothing Then
            BindingSource_LiteraturQuelle.Find("GUID_literarische_Quelle", SemItem_Quelle.GUID)
        End If

    End Sub

    Public Function addLiteraturQuelle() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_LiteraturQuelle As New clsSemItem

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Type_literarische_Quelle.Name, objLocalConfig.Globals)
        objDLG_Attribute_VARCHAR255.ShowDialog(Me)
        If objDLG_Attribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then
            objSemItem_LiteraturQuelle.GUID = Guid.NewGuid
            objSemItem_LiteraturQuelle.Name = objDLG_Attribute_VARCHAR255.Value1
            objSemItem_LiteraturQuelle.GUID_Parent = objLocalConfig.SemItem_Type_literarische_Quelle.GUID
            objSemItem_LiteraturQuelle.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objTransaction_LiteraturQuelle.save_001_LiteraturQuelle(objSemItem_LiteraturQuelle)

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objSemItem_LiteraturQuelle
            Else
                MsgBox("Die Literaturquelle kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function delLiteraturQuelle(ByVal SemItem_LiteraturQuelle) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objTransaction_LiteraturQuelle.del_001_LiteraturQuelle(SemItem_LiteraturQuelle)

        Return objSemItem_Result
    End Function
    Public ReadOnly Property DGVR_SelectedRow As DataGridViewSelectedRowCollection
        Get
            Return DataGridView_LiteraturQuelle.SelectedRows
        End Get
    End Property

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()

        fill_LiteraturQuelle()
    End Sub

    Public Sub fill_LiteraturQuelle()
        procA_LiteraturQuelle.Fill(procT_LiteraturQuelle, _
                                   objLocalConfig.SemItem_Type_literarische_Quelle.GUID, _
                                   objLocalConfig.SemItem_RelationType_isSubordinated.GUID)

        BindingSource_LiteraturQuelle.DataSource = procT_LiteraturQuelle
        DataGridView_LiteraturQuelle.DataSource = BindingSource_LiteraturQuelle

        DataGridView_LiteraturQuelle.Columns(0).Visible = False
        DataGridView_LiteraturQuelle.Columns(1).Width = 200
        DataGridView_LiteraturQuelle.Columns(2).Visible = False
        DataGridView_LiteraturQuelle.Columns(3).Visible = False
        DataGridView_LiteraturQuelle.Columns(4).Visible = False
        DataGridView_LiteraturQuelle.Columns(5).Visible = False
        DataGridView_LiteraturQuelle.Columns(6).Width = 200

        ToolStripLabel_Count.Text = DataGridView_LiteraturQuelle.Rows.Count
    End Sub

    Private Sub set_DBConnection()
        procA_LiteraturQuelle.Connection = objLocalConfig.Connection_Plugin

        objTransaction_LiteraturQuelle = New clsTransaction_LiteraturQuelle(objLocalConfig)

    End Sub

    Private Sub DataGridView_LiteraturQuelle_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_LiteraturQuelle.RowHeaderMouseClick

    End Sub

    Private Sub DataGridView_LiteraturQuelle_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_LiteraturQuelle.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Quelle As New clsSemItem

        objDGVR_Selected = DataGridView_LiteraturQuelle.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Quelle.GUID = objDRV_Selected.Item("GUID_literarische_Quelle")
        objSemItem_Quelle.Name = objDRV_Selected.Item("Name_literarische_Quelle")
        objSemItem_Quelle.GUID_Parent = objLocalConfig.SemItem_Type_literarische_Quelle.GUID
        objSemItem_Quelle.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFRM_TokenEdit = New frmTokenEdit(objSemItem_Quelle, objLocalConfig.Globals)
        objFRM_TokenEdit.ShowDialog(Me)
    End Sub

    Private Sub DataGridView_LiteraturQuelle_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_LiteraturQuelle.SelectionChanged
        RaiseEvent select_Quelle()
    End Sub

    Private Sub ContextMenuStrip_LiteraturQuelle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_LiteraturQuelle.Opening
        EditToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False
        If DataGridView_LiteraturQuelle.SelectedRows.Count = 1 Then
            EditToolStripMenuItem.Enabled = True
            DeleteToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub CopyNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyNameToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        If DataGridView_LiteraturQuelle.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_LiteraturQuelle.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            Clipboard.SetDataObject(objDRV_Selected.Item("Name_literarische_Quelle"))

        End If
    End Sub

    Private Sub CopyGUIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyGUIDToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        If DataGridView_LiteraturQuelle.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_LiteraturQuelle.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            Clipboard.SetDataObject(objDRV_Selected.Item("GUID_literarische_Quelle").ToString)
            MsgBox(objDRV_Selected.Item("GUID_literarische_Quelle").ToString & " copied", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        RaiseEvent add_LiteraturQuelle()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_LiteraturQuelle As New clsSemItem

        Dim objSemItem_Result As clsSemItem
        If DataGridView_LiteraturQuelle.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_LiteraturQuelle.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_LiteraturQuelle.GUID = objDRV_Selected.Item("GUID_literarische_Quelle")
            objSemItem_LiteraturQuelle.Name = objDRV_Selected.Item("Name_literarische_Quelle")
            objSemItem_LiteraturQuelle.GUID_Parent = objLocalConfig.SemItem_Type_literarische_Quelle.GUID
            objSemItem_LiteraturQuelle.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_LiteraturQuelle.GUID_Related = objDRV_Selected.Item("GUID_Type_Quelle")

            If MsgBox("Wollen Sie die Literaturquelle '" & objSemItem_LiteraturQuelle.Name & "' wirklich löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                RaiseEvent del_LiteraturQuelle(objSemItem_LiteraturQuelle)
            End If

        End If
    End Sub
End Class
