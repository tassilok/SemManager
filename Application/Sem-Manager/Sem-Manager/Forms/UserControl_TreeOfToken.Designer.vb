<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_TreeOfToken
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_TreeOfToken))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_LBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripProgressBar_Tree = New System.Windows.Forms.ToolStripProgressBar()
        Me.TreeView_TokenTree = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_Tree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_RelationType = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_RelationType = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_Change = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_SortedByOrder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_TopDown = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton()
        Me.Timer_Tree = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ContextMenuStrip_Tree.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TreeView_TokenTree)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(485, 363)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(485, 413)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountLBL, Me.ToolStripLabel_LBL, Me.ToolStripSeparator1, Me.ToolStripProgressBar_Tree})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(84, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_CountLBL
        '
        Me.ToolStripLabel_CountLBL.Name = "ToolStripLabel_CountLBL"
        Me.ToolStripLabel_CountLBL.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel_CountLBL.Text = "x_Count:"
        '
        'ToolStripLabel_LBL
        '
        Me.ToolStripLabel_LBL.Name = "ToolStripLabel_LBL"
        Me.ToolStripLabel_LBL.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_LBL.Text = "0"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripProgressBar_Tree
        '
        Me.ToolStripProgressBar_Tree.Name = "ToolStripProgressBar_Tree"
        Me.ToolStripProgressBar_Tree.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripProgressBar_Tree.Visible = False
        '
        'TreeView_TokenTree
        '
        Me.TreeView_TokenTree.ContextMenuStrip = Me.ContextMenuStrip_Tree
        Me.TreeView_TokenTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_TokenTree.HideSelection = False
        Me.TreeView_TokenTree.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_TokenTree.Name = "TreeView_TokenTree"
        Me.TreeView_TokenTree.Size = New System.Drawing.Size(485, 363)
        Me.TreeView_TokenTree.TabIndex = 0
        '
        'ContextMenuStrip_Tree
        '
        Me.ContextMenuStrip_Tree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.FilterToolStripMenuItem})
        Me.ContextMenuStrip_Tree.Name = "ContextMenuStrip_Tree"
        Me.ContextMenuStrip_Tree.Size = New System.Drawing.Size(153, 92)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "x_New"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "x_Delete"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FilterToolStripMenuItem.Text = "x_Filter"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_RelationType, Me.ToolStripTextBox_RelationType, Me.ToolStripButton_Change, Me.ToolStripButton_SortedByOrder, Me.ToolStripButton_TopDown, Me.ToolStripButton_Refresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(476, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_RelationType
        '
        Me.ToolStripLabel_RelationType.Name = "ToolStripLabel_RelationType"
        Me.ToolStripLabel_RelationType.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripLabel_RelationType.Text = "x_RelationType:"
        '
        'ToolStripTextBox_RelationType
        '
        Me.ToolStripTextBox_RelationType.Name = "ToolStripTextBox_RelationType"
        Me.ToolStripTextBox_RelationType.ReadOnly = True
        Me.ToolStripTextBox_RelationType.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripButton_Change
        '
        Me.ToolStripButton_Change.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Change.Image = CType(resources.GetObject("ToolStripButton_Change.Image"), System.Drawing.Image)
        Me.ToolStripButton_Change.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Change.Name = "ToolStripButton_Change"
        Me.ToolStripButton_Change.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Change.Text = "..."
        '
        'ToolStripButton_SortedByOrder
        '
        Me.ToolStripButton_SortedByOrder.CheckOnClick = True
        Me.ToolStripButton_SortedByOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_SortedByOrder.Image = Global.Sem_Manager.My.Resources.Resources.bb_sort2
        Me.ToolStripButton_SortedByOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_SortedByOrder.Name = "ToolStripButton_SortedByOrder"
        Me.ToolStripButton_SortedByOrder.Size = New System.Drawing.Size(23, 22)
        '
        'ToolStripButton_TopDown
        '
        Me.ToolStripButton_TopDown.Checked = True
        Me.ToolStripButton_TopDown.CheckOnClick = True
        Me.ToolStripButton_TopDown.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton_TopDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_TopDown.Image = Global.Sem_Manager.My.Resources.Resources.tasto_3_architetto_franc_01
        Me.ToolStripButton_TopDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_TopDown.Name = "ToolStripButton_TopDown"
        Me.ToolStripButton_TopDown.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_TopDown.Text = "ToolStripButton1"
        '
        'ToolStripButton_Refresh
        '
        Me.ToolStripButton_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Refresh.Image = Global.Sem_Manager.My.Resources.Resources.bb_reload_
        Me.ToolStripButton_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
        Me.ToolStripButton_Refresh.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Refresh.Text = "ToolStripButton1"
        '
        'Timer_Tree
        '
        Me.Timer_Tree.Interval = 300
        '
        'UserControl_TreeOfToken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_TreeOfToken"
        Me.Size = New System.Drawing.Size(485, 413)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ContextMenuStrip_Tree.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_LBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TreeView_TokenTree As System.Windows.Forms.TreeView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_RelationType As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_RelationType As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton_Change As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_SortedByOrder As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_TopDown As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip_Tree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_Tree As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripProgressBar_Tree As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
