<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Messages
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Messages))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel_MessageCount_LBL = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel_MessageCount = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel_ToDo_Lbl = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel_ToDoCount = New System.Windows.Forms.ToolStripLabel
        Me.TreeView_Messages = New System.Windows.Forms.TreeView
        Me.ContextMenuStrip_Messages = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList_Messages = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel_Mark = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox_ToMark = New System.Windows.Forms.ToolStripTextBox
        Me.TextBox_Description = New System.Windows.Forms.TextBox
        Me.Timer_Description = New System.Windows.Forms.Timer(Me.components)
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip_Messages.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStripContainer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_Description)
        Me.SplitContainer1.Size = New System.Drawing.Size(750, 436)
        Me.SplitContainer1.SplitterDistance = 402
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TreeView_Messages)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(398, 382)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(398, 432)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_MessageCount_LBL, Me.ToolStripLabel_MessageCount, Me.ToolStripSeparator1, Me.ToolStripLabel_ToDo_Lbl, Me.ToolStripLabel_ToDoCount})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(164, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_MessageCount_LBL
        '
        Me.ToolStripLabel_MessageCount_LBL.Name = "ToolStripLabel_MessageCount_LBL"
        Me.ToolStripLabel_MessageCount_LBL.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripLabel_MessageCount_LBL.Text = "x_Messages:"
        '
        'ToolStripLabel_MessageCount
        '
        Me.ToolStripLabel_MessageCount.Name = "ToolStripLabel_MessageCount"
        Me.ToolStripLabel_MessageCount.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_MessageCount.Text = "0"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_ToDo_Lbl
        '
        Me.ToolStripLabel_ToDo_Lbl.Name = "ToolStripLabel_ToDo_Lbl"
        Me.ToolStripLabel_ToDo_Lbl.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel_ToDo_Lbl.Text = "x_ToDo:"
        '
        'ToolStripLabel_ToDoCount
        '
        Me.ToolStripLabel_ToDoCount.Name = "ToolStripLabel_ToDoCount"
        Me.ToolStripLabel_ToDoCount.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_ToDoCount.Text = "0"
        '
        'TreeView_Messages
        '
        Me.TreeView_Messages.ContextMenuStrip = Me.ContextMenuStrip_Messages
        Me.TreeView_Messages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Messages.ImageIndex = 0
        Me.TreeView_Messages.ImageList = Me.ImageList_Messages
        Me.TreeView_Messages.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_Messages.Name = "TreeView_Messages"
        Me.TreeView_Messages.SelectedImageIndex = 0
        Me.TreeView_Messages.Size = New System.Drawing.Size(398, 382)
        Me.TreeView_Messages.TabIndex = 0
        '
        'ContextMenuStrip_Messages
        '
        Me.ContextMenuStrip_Messages.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMessageToolStripMenuItem, Me.CopyNameToolStripMenuItem})
        Me.ContextMenuStrip_Messages.Name = "ContextMenuStrip_Messages"
        Me.ContextMenuStrip_Messages.Size = New System.Drawing.Size(158, 70)
        '
        'NewMessageToolStripMenuItem
        '
        Me.NewMessageToolStripMenuItem.Name = "NewMessageToolStripMenuItem"
        Me.NewMessageToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NewMessageToolStripMenuItem.Text = "x_New Message"
        '
        'ImageList_Messages
        '
        Me.ImageList_Messages.ImageStream = CType(resources.GetObject("ImageList_Messages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Messages.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Messages.Images.SetKeyName(0, "bb_home_.png")
        Me.ImageList_Messages.Images.SetKeyName(1, "tasto_10_architetto_fran_01.png")
        Me.ImageList_Messages.Images.SetKeyName(2, "tasto_10_architetto_fran_01.png")
        Me.ImageList_Messages.Images.SetKeyName(3, "people_juliane_krug_05c.png")
        Me.ImageList_Messages.Images.SetKeyName(4, "people_juliane_krug_05c.png")
        Me.ImageList_Messages.Images.SetKeyName(5, "Filter2HS.png")
        Me.ImageList_Messages.Images.SetKeyName(6, "Filter2HS.png")
        Me.ImageList_Messages.Images.SetKeyName(7, "Localized Names Done.png")
        Me.ImageList_Messages.Images.SetKeyName(8, "Localized Names ToDo.png")
        Me.ImageList_Messages.Images.SetKeyName(9, "FontDialogHS.png")
        Me.ImageList_Messages.Images.SetKeyName(10, "NewCardHS.png")
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Mark, Me.ToolStripTextBox_ToMark})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(261, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_Mark
        '
        Me.ToolStripLabel_Mark.Name = "ToolStripLabel_Mark"
        Me.ToolStripLabel_Mark.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel_Mark.Text = "x_Mark:"
        '
        'ToolStripTextBox_ToMark
        '
        Me.ToolStripTextBox_ToMark.Name = "ToolStripTextBox_ToMark"
        Me.ToolStripTextBox_ToMark.Size = New System.Drawing.Size(200, 25)
        '
        'TextBox_Description
        '
        Me.TextBox_Description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Description.Location = New System.Drawing.Point(0, 0)
        Me.TextBox_Description.Multiline = True
        Me.TextBox_Description.Name = "TextBox_Description"
        Me.TextBox_Description.ReadOnly = True
        Me.TextBox_Description.Size = New System.Drawing.Size(340, 432)
        Me.TextBox_Description.TabIndex = 0
        '
        'Timer_Description
        '
        Me.Timer_Description.Interval = 300
        '
        'CopyNameToolStripMenuItem
        '
        Me.CopyNameToolStripMenuItem.Name = "CopyNameToolStripMenuItem"
        Me.CopyNameToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CopyNameToolStripMenuItem.Text = "x_Copy Name"
        '
        'UserControl_Messages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_Messages"
        Me.Size = New System.Drawing.Size(750, 436)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip_Messages.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBox_Description As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TreeView_Messages As System.Windows.Forms.TreeView
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Mark As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_ToMark As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel_MessageCount_LBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_MessageCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_ToDo_Lbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_ToDoCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ImageList_Messages As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip_Messages As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_Description As System.Windows.Forms.Timer
    Friend WithEvents CopyNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
