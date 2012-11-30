Public Class frmRelationChoose
    Private WithEvents objUserControl_TokenTree As UserControl_TokenTree

    Private objGlobals As clsGlobals
    Private objSemItem_Selected As clsSemItem
    Private objSemItem_Result As clsSemItem

    Public ReadOnly Property SemItem_Result As clsSemItem
        Get
            Return objSemItem_Result
        End Get
        
    End Property

    Private Sub selected_Node(ByVal objSemItem As clsSemItem) Handles objUserControl_TokenTree.selected_Node
        objSemItem_Result = objSemItem
    End Sub

    Public Sub New(ByVal Globals As clsGlobals, ByVal SemItem_Selected As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objGlobals = Globals
        objSemItem_Selected = SemItem_Selected
        initialize()
    End Sub

    Private Sub initialize()
        objUserControl_TokenTree = New UserControl_TokenTree(objSemItem_Selected, objGlobals)
        objUserControl_TokenTree.Dock = DockStyle.Fill
        objUserControl_TokenTree.ContextMenuStrip = ContextMenuStrip_selected

        Me.Controls.Add(objUserControl_TokenTree)
    End Sub

    Private Sub ContextMenuStrip_selected_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_selected.Opening
        ApplyToolStripMenuItem.Enabled = False

        If Not objSemItem_Result Is Nothing Then
            ApplyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub
End Class