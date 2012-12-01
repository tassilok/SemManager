<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Scenarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Scenarios))
        Me.ImageList_DevStructures = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip_Scenario = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.TreeView_Scenario = New System.Windows.Forms.TreeView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel_Mark = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox_Mark = New System.Windows.Forms.ToolStripTextBox
        Me.IgnoreProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DoNotIgnoreProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip_Scenario.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList_DevStructures
        '
        Me.ImageList_DevStructures.ImageStream = CType(resources.GetObject("ImageList_DevStructures.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_DevStructures.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_DevStructures.Images.SetKeyName(0, "microchip_v.2_havok_redh_01.png")
        Me.ImageList_DevStructures.Images.SetKeyName(1, "mycomp.png")
        Me.ImageList_DevStructures.Images.SetKeyName(2, "microchip_v.2_havok_redh_01 with green arrow.png")
        Me.ImageList_DevStructures.Images.SetKeyName(3, "bb_reload_.png")
        Me.ImageList_DevStructures.Images.SetKeyName(4, "bb_bback_.png")
        Me.ImageList_DevStructures.Images.SetKeyName(5, "bb_pckg_.png")
        Me.ImageList_DevStructures.Images.SetKeyName(6, "bb_home_.png")
        Me.ImageList_DevStructures.Images.SetKeyName(7, "Parameter In.png")
        Me.ImageList_DevStructures.Images.SetKeyName(8, "Parameter Out.png")
        Me.ImageList_DevStructures.Images.SetKeyName(9, "foglio_e_mondo_architett_01.png")
        Me.ImageList_DevStructures.Images.SetKeyName(10, "finestre_sovrapposte_arc_01.png")
        '
        'ContextMenuStrip_Scenario
        '
        Me.ContextMenuStrip_Scenario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplyToolStripMenuItem, Me.IgnoreProcessToolStripMenuItem, Me.DoNotIgnoreProcessToolStripMenuItem})
        Me.ContextMenuStrip_Scenario.Name = "ContextMenuStrip_Scenario"
        Me.ContextMenuStrip_Scenario.Size = New System.Drawing.Size(201, 70)
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Enabled = False
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStripContainer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(448, 451)
        Me.SplitContainer1.SplitterDistance = 316
        Me.SplitContainer1.TabIndex = 2
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TreeView_Scenario)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(444, 262)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(444, 312)
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
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(111, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'TreeView_Scenario
        '
        Me.TreeView_Scenario.ContextMenuStrip = Me.ContextMenuStrip_Scenario
        Me.TreeView_Scenario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Scenario.ImageIndex = 0
        Me.TreeView_Scenario.ImageList = Me.ImageList_DevStructures
        Me.TreeView_Scenario.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_Scenario.Name = "TreeView_Scenario"
        Me.TreeView_Scenario.SelectedImageIndex = 0
        Me.TreeView_Scenario.Size = New System.Drawing.Size(444, 262)
        Me.TreeView_Scenario.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Mark, Me.ToolStripTextBox_Mark})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(311, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_Mark
        '
        Me.ToolStripLabel_Mark.Name = "ToolStripLabel_Mark"
        Me.ToolStripLabel_Mark.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel_Mark.Text = "x_Mark:"
        '
        'ToolStripTextBox_Mark
        '
        Me.ToolStripTextBox_Mark.Name = "ToolStripTextBox_Mark"
        Me.ToolStripTextBox_Mark.Size = New System.Drawing.Size(250, 25)
        '
        'IgnoreProcessToolStripMenuItem
        '
        Me.IgnoreProcessToolStripMenuItem.Name = "IgnoreProcessToolStripMenuItem"
        Me.IgnoreProcessToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.IgnoreProcessToolStripMenuItem.Text = "x_Ignore Process"
        '
        'DoNotIgnoreProcessToolStripMenuItem
        '
        Me.DoNotIgnoreProcessToolStripMenuItem.Name = "DoNotIgnoreProcessToolStripMenuItem"
        Me.DoNotIgnoreProcessToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.DoNotIgnoreProcessToolStripMenuItem.Text = "x_Do not ignore Process"
        '
        'UserControl_Scenarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_Scenarios"
        Me.Size = New System.Drawing.Size(448, 451)
        Me.ContextMenuStrip_Scenario.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList_DevStructures As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip_Scenario As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents TreeView_Scenario As System.Windows.Forms.TreeView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Mark As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Mark As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents IgnoreProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoNotIgnoreProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
