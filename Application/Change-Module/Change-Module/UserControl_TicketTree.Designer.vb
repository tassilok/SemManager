<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_TicketTree
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_TicketTree))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripProgressBar_Related = New System.Windows.Forms.ToolStripProgressBar()
        Me.TreeView_TicketLists = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_TicketTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_SelectedRange = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_DateRange = New System.Windows.Forms.ToolStripTextBox()
        Me.Timer_Related = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ContextMenuStrip_TicketTree.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TreeView_TicketLists)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(372, 397)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(372, 447)
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
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar_Related})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(114, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripProgressBar_Related
        '
        Me.ToolStripProgressBar_Related.Name = "ToolStripProgressBar_Related"
        Me.ToolStripProgressBar_Related.Size = New System.Drawing.Size(100, 22)
        '
        'TreeView_TicketLists
        '
        Me.TreeView_TicketLists.ContextMenuStrip = Me.ContextMenuStrip_TicketTree
        Me.TreeView_TicketLists.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_TicketLists.HideSelection = False
        Me.TreeView_TicketLists.ImageIndex = 0
        Me.TreeView_TicketLists.ImageList = Me.ImageList_Main
        Me.TreeView_TicketLists.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_TicketLists.Name = "TreeView_TicketLists"
        Me.TreeView_TicketLists.SelectedImageIndex = 0
        Me.TreeView_TicketLists.Size = New System.Drawing.Size(372, 397)
        Me.TreeView_TicketLists.TabIndex = 0
        '
        'ContextMenuStrip_TicketTree
        '
        Me.ContextMenuStrip_TicketTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_TicketTree.Name = "ContextMenuStrip_TicketTree"
        Me.ContextMenuStrip_TicketTree.Size = New System.Drawing.Size(128, 70)
        '
        'CreateToolStripMenuItem
        '
        Me.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem"
        Me.CreateToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CreateToolStripMenuItem.Text = "x_Create"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.RemoveToolStripMenuItem.Text = "x_Remove"
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Enabled = False
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ImageStream = CType(resources.GetObject("ImageList_Main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Main.Images.SetKeyName(0, "bb_home_.png")
        Me.ImageList_Main.Images.SetKeyName(1, "gnome-mime-application-vnd.ms-powerpoint.png")
        Me.ImageList_Main.Images.SetKeyName(2, "Types_Closed.png")
        Me.ImageList_Main.Images.SetKeyName(3, "Types_Opened.png")
        Me.ImageList_Main.Images.SetKeyName(4, "Attributes bamboo_danny_allen_r.png")
        Me.ImageList_Main.Images.SetKeyName(5, "RelationTypes gpride_jean_victor_balin_.png")
        Me.ImageList_Main.Images.SetKeyName(6, "Vogelschwarm klein.png")
        Me.ImageList_Main.Images.SetKeyName(7, "Types_Closed SubItems.png")
        Me.ImageList_Main.Images.SetKeyName(8, "Types_Opened SubItems.png")
        Me.ImageList_Main.Images.SetKeyName(9, "clipboard_01.ico")
        Me.ImageList_Main.Images.SetKeyName(10, "bb_pckg_.ico")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_SelectedRange, Me.ToolStripTextBox_DateRange})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(314, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_SelectedRange
        '
        Me.ToolStripLabel_SelectedRange.Name = "ToolStripLabel_SelectedRange"
        Me.ToolStripLabel_SelectedRange.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripLabel_SelectedRange.Text = "x_Selected Range:"
        '
        'ToolStripTextBox_DateRange
        '
        Me.ToolStripTextBox_DateRange.Name = "ToolStripTextBox_DateRange"
        Me.ToolStripTextBox_DateRange.Size = New System.Drawing.Size(200, 25)
        '
        'Timer_Related
        '
        Me.Timer_Related.Interval = 300
        '
        'UserControl_TicketTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_TicketTree"
        Me.Size = New System.Drawing.Size(372, 447)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ContextMenuStrip_TicketTree.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TreeView_TicketLists As System.Windows.Forms.TreeView
    Friend WithEvents ImageList_Main As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_SelectedRange As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_DateRange As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripProgressBar_Related As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Timer_Related As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip_TicketTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CreateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
