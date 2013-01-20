<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Process
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Process))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView_Process = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_Process = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectExistingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_Process = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_References = New System.Windows.Forms.TabPage()
        Me.TabPage_Images = New System.Windows.Forms.TabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountLbl = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_ProcessCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Correlation = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_Mark = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_Mark = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_NextProcess = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Clear = New System.Windows.Forms.ToolStripButton()
        Me.Timer_Process = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Mark = New System.Windows.Forms.Timer(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportHTMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip_Process.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(765, 339)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(765, 389)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView_Process)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(765, 339)
        Me.SplitContainer1.SplitterDistance = 255
        Me.SplitContainer1.TabIndex = 1
        '
        'TreeView_Process
        '
        Me.TreeView_Process.AllowDrop = True
        Me.TreeView_Process.ContextMenuStrip = Me.ContextMenuStrip_Process
        Me.TreeView_Process.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Process.ImageIndex = 0
        Me.TreeView_Process.ImageList = Me.ImageList_Process
        Me.TreeView_Process.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_Process.Name = "TreeView_Process"
        Me.TreeView_Process.SelectedImageIndex = 0
        Me.TreeView_Process.Size = New System.Drawing.Size(255, 339)
        Me.TreeView_Process.TabIndex = 0
        '
        'ContextMenuStrip_Process
        '
        Me.ContextMenuStrip_Process.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_Process.Name = "ContextMenuStrip_Proces"
        Me.ContextMenuStrip_Process.Size = New System.Drawing.Size(153, 114)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewToolStripMenuItem, Me.SelectExistingToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "x_New"
        '
        'CreateNewToolStripMenuItem
        '
        Me.CreateNewToolStripMenuItem.Name = "CreateNewToolStripMenuItem"
        Me.CreateNewToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CreateNewToolStripMenuItem.Text = "x_Create new"
        '
        'SelectExistingToolStripMenuItem
        '
        Me.SelectExistingToolStripMenuItem.Name = "SelectExistingToolStripMenuItem"
        Me.SelectExistingToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SelectExistingToolStripMenuItem.Text = "x_Select Existing"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RemoveToolStripMenuItem.Text = "x_Remove"
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        Me.ApplyToolStripMenuItem.Visible = False
        '
        'ImageList_Process
        '
        Me.ImageList_Process.ImageStream = CType(resources.GetObject("ImageList_Process.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Process.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Process.Images.SetKeyName(0, "bb_home_.png")
        Me.ImageList_Process.Images.SetKeyName(1, "mycomp.png")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_References)
        Me.TabControl1.Controls.Add(Me.TabPage_Images)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(506, 339)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_References
        '
        Me.TabPage_References.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_References.Name = "TabPage_References"
        Me.TabPage_References.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_References.Size = New System.Drawing.Size(498, 313)
        Me.TabPage_References.TabIndex = 0
        Me.TabPage_References.Text = "x_References"
        Me.TabPage_References.UseVisualStyleBackColor = True
        '
        'TabPage_Images
        '
        Me.TabPage_Images.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Images.Name = "TabPage_Images"
        Me.TabPage_Images.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Images.Size = New System.Drawing.Size(498, 313)
        Me.TabPage_Images.TabIndex = 1
        Me.TabPage_Images.Text = "x_Images"
        Me.TabPage_Images.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountLbl, Me.ToolStripLabel_ProcessCount})
        Me.ToolStrip2.Location = New System.Drawing.Point(18, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(126, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_CountLbl
        '
        Me.ToolStripLabel_CountLbl.Name = "ToolStripLabel_CountLbl"
        Me.ToolStripLabel_CountLbl.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripLabel_CountLbl.Text = "x_Count Processes:"
        '
        'ToolStripLabel_ProcessCount
        '
        Me.ToolStripLabel_ProcessCount.Name = "ToolStripLabel_ProcessCount"
        Me.ToolStripLabel_ProcessCount.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_ProcessCount.Text = "0"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Correlation, Me.ToolStripSeparator1, Me.ToolStripLabel_Mark, Me.ToolStripTextBox_Mark, Me.ToolStripButton_NextProcess, Me.ToolStripButton_Clear})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(493, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Correlation
        '
        Me.ToolStripButton_Correlation.Image = Global.Process_Module.My.Resources.Resources.gpride_jean_victor_balin_
        Me.ToolStripButton_Correlation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Correlation.Name = "ToolStripButton_Correlation"
        Me.ToolStripButton_Correlation.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripButton_Correlation.Text = "x_Correlation"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_Mark
        '
        Me.ToolStripLabel_Mark.Name = "ToolStripLabel_Mark"
        Me.ToolStripLabel_Mark.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel_Mark.Text = "x_Mark:"
        '
        'ToolStripTextBox_Mark
        '
        Me.ToolStripTextBox_Mark.Name = "ToolStripTextBox_Mark"
        Me.ToolStripTextBox_Mark.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripButton_NextProcess
        '
        Me.ToolStripButton_NextProcess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_NextProcess.Enabled = False
        Me.ToolStripButton_NextProcess.Image = Global.Process_Module.My.Resources.Resources._112_DownArrowLong_Green_24x24_72
        Me.ToolStripButton_NextProcess.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_NextProcess.Name = "ToolStripButton_NextProcess"
        Me.ToolStripButton_NextProcess.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_NextProcess.Text = "ToolStripButton1"
        '
        'ToolStripButton_Clear
        '
        Me.ToolStripButton_Clear.Image = Global.Process_Module.My.Resources.Resources.delete
        Me.ToolStripButton_Clear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Clear.Name = "ToolStripButton_Clear"
        Me.ToolStripButton_Clear.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripButton_Clear.Text = "x_Clear"
        '
        'Timer_Process
        '
        Me.Timer_Process.Interval = 300
        '
        'Timer_Mark
        '
        Me.Timer_Mark.Interval = 500
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportHTMLToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "x_Edit"
        '
        'ExportHTMLToolStripMenuItem
        '
        Me.ExportHTMLToolStripMenuItem.Name = "ExportHTMLToolStripMenuItem"
        Me.ExportHTMLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportHTMLToolStripMenuItem.Text = "x_Export HTML"
        '
        'UserControl_Process
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_Process"
        Me.Size = New System.Drawing.Size(765, 389)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip_Process.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Correlation As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_Mark As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Mark As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton_NextProcess As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Clear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel_CountLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_ProcessCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TreeView_Process As System.Windows.Forms.TreeView
    Friend WithEvents ImageList_Process As System.Windows.Forms.ImageList
    Friend WithEvents Timer_Process As System.Windows.Forms.Timer
    Friend WithEvents Timer_Mark As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip_Process As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectExistingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_References As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Images As System.Windows.Forms.TabPage
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportHTMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
