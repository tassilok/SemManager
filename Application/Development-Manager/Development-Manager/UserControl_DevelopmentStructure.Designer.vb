<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_DevelopmentStructure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_DevelopmentStructure))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel_Count = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel_CountLbl = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel_StructureType = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.TreeView_DevStructures = New System.Windows.Forms.TreeView
        Me.ContextMenuStrip_Structures = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SimpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InvokeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList_DevStructures = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton_AddStructure = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton_DelStructure = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ContextMenuStrip_Structures.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(449, 377)
        Me.SplitContainer1.SplitterDistance = 243
        Me.SplitContainer1.TabIndex = 0
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TreeView_DevStructures)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(445, 189)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(445, 239)
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
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Count, Me.ToolStripLabel_CountLbl, Me.ToolStripSeparator1, Me.ToolStripLabel_StructureType, Me.ToolStripTextBox1})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(428, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_Count
        '
        Me.ToolStripLabel_Count.Name = "ToolStripLabel_Count"
        Me.ToolStripLabel_Count.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Count.Text = "0"
        '
        'ToolStripLabel_CountLbl
        '
        Me.ToolStripLabel_CountLbl.Name = "ToolStripLabel_CountLbl"
        Me.ToolStripLabel_CountLbl.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel_CountLbl.Text = "x_Items"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_StructureType
        '
        Me.ToolStripLabel_StructureType.Name = "ToolStripLabel_StructureType"
        Me.ToolStripLabel_StructureType.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripLabel_StructureType.Text = "x_Structure-Type:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.ReadOnly = True
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(250, 25)
        '
        'TreeView_DevStructures
        '
        Me.TreeView_DevStructures.ContextMenuStrip = Me.ContextMenuStrip_Structures
        Me.TreeView_DevStructures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_DevStructures.ImageIndex = 0
        Me.TreeView_DevStructures.ImageList = Me.ImageList_DevStructures
        Me.TreeView_DevStructures.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_DevStructures.Name = "TreeView_DevStructures"
        Me.TreeView_DevStructures.SelectedImageIndex = 0
        Me.TreeView_DevStructures.Size = New System.Drawing.Size(445, 189)
        Me.TreeView_DevStructures.TabIndex = 0
        '
        'ContextMenuStrip_Structures
        '
        Me.ContextMenuStrip_Structures.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProcessToolStripMenuItem, Me.LogToolStripMenuItem, Me.ChangeTypeToolStripMenuItem, Me.CopyNameToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_Structures.Name = "ContextMenuStrip_Structures"
        Me.ContextMenuStrip_Structures.Size = New System.Drawing.Size(155, 114)
        '
        'NewProcessToolStripMenuItem
        '
        Me.NewProcessToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimpleToolStripMenuItem, Me.InvokeToolStripMenuItem})
        Me.NewProcessToolStripMenuItem.Name = "NewProcessToolStripMenuItem"
        Me.NewProcessToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NewProcessToolStripMenuItem.Text = "x_New Process"
        '
        'SimpleToolStripMenuItem
        '
        Me.SimpleToolStripMenuItem.Name = "SimpleToolStripMenuItem"
        Me.SimpleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SimpleToolStripMenuItem.Text = "x_Simple"
        '
        'InvokeToolStripMenuItem
        '
        Me.InvokeToolStripMenuItem.Name = "InvokeToolStripMenuItem"
        Me.InvokeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InvokeToolStripMenuItem.Text = "x_Invoke"
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        Me.LogToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.LogToolStripMenuItem.Text = "x_Log"
        '
        'ChangeTypeToolStripMenuItem
        '
        Me.ChangeTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem, Me.LoopToolStripMenuItem, Me.ReturnToolStripMenuItem, Me.ProcessToolStripMenuItem})
        Me.ChangeTypeToolStripMenuItem.Name = "ChangeTypeToolStripMenuItem"
        Me.ChangeTypeToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ChangeTypeToolStripMenuItem.Text = "x_Change Type"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Image = Global.Development_Manager.My.Resources.Resources.bb_pckg_
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.DatabaseToolStripMenuItem.Text = "x_Database"
        '
        'LoopToolStripMenuItem
        '
        Me.LoopToolStripMenuItem.Image = Global.Development_Manager.My.Resources.Resources.bb_reload_
        Me.LoopToolStripMenuItem.Name = "LoopToolStripMenuItem"
        Me.LoopToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.LoopToolStripMenuItem.Text = "x_Loop"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Image = Global.Development_Manager.My.Resources.Resources.bb_bback_
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ReturnToolStripMenuItem.Text = "x_Return"
        '
        'ProcessToolStripMenuItem
        '
        Me.ProcessToolStripMenuItem.Image = Global.Development_Manager.My.Resources.Resources.mycomp
        Me.ProcessToolStripMenuItem.Name = "ProcessToolStripMenuItem"
        Me.ProcessToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ProcessToolStripMenuItem.Text = "x_Process"
        '
        'CopyNameToolStripMenuItem
        '
        Me.CopyNameToolStripMenuItem.Name = "CopyNameToolStripMenuItem"
        Me.CopyNameToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CopyNameToolStripMenuItem.Text = "x_Copy Name"
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        Me.ApplyToolStripMenuItem.Visible = False
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
        Me.ImageList_DevStructures.Images.SetKeyName(9, "blender.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_AddStructure, Me.ToolStripButton_DelStructure})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(58, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_AddStructure
        '
        Me.ToolStripButton_AddStructure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_AddStructure.Image = Global.Development_Manager.My.Resources.Resources.b_plus
        Me.ToolStripButton_AddStructure.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_AddStructure.Name = "ToolStripButton_AddStructure"
        Me.ToolStripButton_AddStructure.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_AddStructure.Text = "ToolStripButton1"
        '
        'ToolStripButton_DelStructure
        '
        Me.ToolStripButton_DelStructure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_DelStructure.Image = Global.Development_Manager.My.Resources.Resources.b_minus
        Me.ToolStripButton_DelStructure.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DelStructure.Name = "ToolStripButton_DelStructure"
        Me.ToolStripButton_DelStructure.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_DelStructure.Text = "ToolStripButton2"
        '
        'UserControl_DevelopmentStructure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_DevelopmentStructure"
        Me.Size = New System.Drawing.Size(449, 377)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ContextMenuStrip_Structures.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents TreeView_DevStructures As System.Windows.Forms.TreeView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_AddStructure As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_DelStructure As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel_Count As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_CountLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_StructureType As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ImageList_DevStructures As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip_Structures As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvokeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
