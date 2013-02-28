<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_ObjectRel
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
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_RelCountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_RelCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripProgressBar_TokenRelation = New System.Windows.Forms.ToolStripProgressBar()
        Me.ContextMenuStrip_TokRel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetOrderIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetRelationTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuleEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox_ModuleEdit = New System.Windows.Forms.ToolStripComboBox()
        Me.ModuleMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox_ModuleMenu = New System.Windows.Forms.ToolStripComboBox()
        Me.CopyValToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EqualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifferentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContainsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox_TokRelContains = New System.Windows.Forms.ToolStripTextBox()
        Me.GreaterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LessThanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_FilterLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Filter = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton_DelTokenRel = New System.Windows.Forms.ToolStripButton()
        Me.Timer_TokenRelation = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource_ObjectRel = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView_Relations = New System.Windows.Forms.DataGridView()
        Me.ToolStripContainer2.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.ContextMenuStrip_TokRel.SuspendLayout()
        Me.ToolStrip5.SuspendLayout()
        CType(Me.BindingSource_ObjectRel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Relations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.BottomToolStripPanel
        '
        Me.ToolStripContainer2.BottomToolStripPanel.Controls.Add(Me.ToolStrip4)
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.DataGridView_Relations)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(505, 436)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.LeftToolStripPanelVisible = False
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.RightToolStripPanelVisible = False
        Me.ToolStripContainer2.Size = New System.Drawing.Size(505, 486)
        Me.ToolStripContainer2.TabIndex = 1
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip5)
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_RelCountLBL, Me.ToolStripLabel_RelCount, Me.ToolStripProgressBar_TokenRelation})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(170, 25)
        Me.ToolStrip4.TabIndex = 0
        '
        'ToolStripLabel_RelCountLBL
        '
        Me.ToolStripLabel_RelCountLBL.Name = "ToolStripLabel_RelCountLBL"
        Me.ToolStripLabel_RelCountLBL.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripLabel_RelCountLBL.Text = "Count:"
        '
        'ToolStripLabel_RelCount
        '
        Me.ToolStripLabel_RelCount.Name = "ToolStripLabel_RelCount"
        Me.ToolStripLabel_RelCount.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_RelCount.Text = "0"
        '
        'ToolStripProgressBar_TokenRelation
        '
        Me.ToolStripProgressBar_TokenRelation.Name = "ToolStripProgressBar_TokenRelation"
        Me.ToolStripProgressBar_TokenRelation.Size = New System.Drawing.Size(100, 22)
        '
        'ContextMenuStrip_TokRel
        '
        Me.ContextMenuStrip_TokRel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.FilterToolStripMenuItem, Me.RelateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip_TokRel.Name = "ContextMenuStrip_TokRel"
        Me.ContextMenuStrip_TokRel.Size = New System.Drawing.Size(107, 92)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetOrderIDToolStripMenuItem, Me.SetRelationTypeToolStripMenuItem, Me.ModuleEditToolStripMenuItem, Me.ModuleMenuToolStripMenuItem, Me.CopyValToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SetOrderIDToolStripMenuItem
        '
        Me.SetOrderIDToolStripMenuItem.Name = "SetOrderIDToolStripMenuItem"
        Me.SetOrderIDToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SetOrderIDToolStripMenuItem.Text = "Set OrderID"
        '
        'SetRelationTypeToolStripMenuItem
        '
        Me.SetRelationTypeToolStripMenuItem.Name = "SetRelationTypeToolStripMenuItem"
        Me.SetRelationTypeToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SetRelationTypeToolStripMenuItem.Text = "Set RelationType"
        '
        'ModuleEditToolStripMenuItem
        '
        Me.ModuleEditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_ModuleEdit})
        Me.ModuleEditToolStripMenuItem.Name = "ModuleEditToolStripMenuItem"
        Me.ModuleEditToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ModuleEditToolStripMenuItem.Text = "x_Module-Edit"
        '
        'ToolStripComboBox_ModuleEdit
        '
        Me.ToolStripComboBox_ModuleEdit.Name = "ToolStripComboBox_ModuleEdit"
        Me.ToolStripComboBox_ModuleEdit.Size = New System.Drawing.Size(121, 23)
        '
        'ModuleMenuToolStripMenuItem
        '
        Me.ModuleMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_ModuleMenu})
        Me.ModuleMenuToolStripMenuItem.Name = "ModuleMenuToolStripMenuItem"
        Me.ModuleMenuToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ModuleMenuToolStripMenuItem.Text = "x_Module-Menu"
        '
        'ToolStripComboBox_ModuleMenu
        '
        Me.ToolStripComboBox_ModuleMenu.Name = "ToolStripComboBox_ModuleMenu"
        Me.ToolStripComboBox_ModuleMenu.Size = New System.Drawing.Size(250, 23)
        '
        'CopyValToolStripMenuItem1
        '
        Me.CopyValToolStripMenuItem1.Name = "CopyValToolStripMenuItem1"
        Me.CopyValToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.CopyValToolStripMenuItem1.Text = "x_Copy Val"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EqualToolStripMenuItem, Me.DifferentToolStripMenuItem, Me.ContainsToolStripMenuItem, Me.GreaterToolStripMenuItem, Me.LessThanToolStripMenuItem, Me.ClearFilterToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.FilterToolStripMenuItem.Text = "Filter"
        '
        'EqualToolStripMenuItem
        '
        Me.EqualToolStripMenuItem.Name = "EqualToolStripMenuItem"
        Me.EqualToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.EqualToolStripMenuItem.Text = "Equal"
        '
        'DifferentToolStripMenuItem
        '
        Me.DifferentToolStripMenuItem.Name = "DifferentToolStripMenuItem"
        Me.DifferentToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DifferentToolStripMenuItem.Text = "Different"
        '
        'ContainsToolStripMenuItem
        '
        Me.ContainsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox_TokRelContains})
        Me.ContainsToolStripMenuItem.Name = "ContainsToolStripMenuItem"
        Me.ContainsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ContainsToolStripMenuItem.Text = "Contains"
        '
        'ToolStripTextBox_TokRelContains
        '
        Me.ToolStripTextBox_TokRelContains.Name = "ToolStripTextBox_TokRelContains"
        Me.ToolStripTextBox_TokRelContains.Size = New System.Drawing.Size(100, 23)
        '
        'GreaterToolStripMenuItem
        '
        Me.GreaterToolStripMenuItem.Name = "GreaterToolStripMenuItem"
        Me.GreaterToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.GreaterToolStripMenuItem.Text = "Greater >"
        '
        'LessThanToolStripMenuItem
        '
        Me.LessThanToolStripMenuItem.Name = "LessThanToolStripMenuItem"
        Me.LessThanToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LessThanToolStripMenuItem.Text = "Less than <"
        '
        'ClearFilterToolStripMenuItem
        '
        Me.ClearFilterToolStripMenuItem.Name = "ClearFilterToolStripMenuItem"
        Me.ClearFilterToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ClearFilterToolStripMenuItem.Text = "Clear Filter"
        '
        'RelateToolStripMenuItem
        '
        Me.RelateToolStripMenuItem.Name = "RelateToolStripMenuItem"
        Me.RelateToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.RelateToolStripMenuItem.Text = "Relate"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.DeleteToolStripMenuItem.Text = "delete"
        '
        'ToolStrip5
        '
        Me.ToolStrip5.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_FilterLBL, Me.ToolStripLabel_Filter, Me.ToolStripButton_DelTokenRel})
        Me.ToolStrip5.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Size = New System.Drawing.Size(83, 25)
        Me.ToolStrip5.TabIndex = 1
        '
        'ToolStripLabel_FilterLBL
        '
        Me.ToolStripLabel_FilterLBL.Name = "ToolStripLabel_FilterLBL"
        Me.ToolStripLabel_FilterLBL.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel_FilterLBL.Text = "Filter:"
        '
        'ToolStripLabel_Filter
        '
        Me.ToolStripLabel_Filter.Name = "ToolStripLabel_Filter"
        Me.ToolStripLabel_Filter.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel_Filter.Text = "-"
        '
        'ToolStripButton_DelTokenRel
        '
        Me.ToolStripButton_DelTokenRel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_DelTokenRel.Image = Global.Ontolog_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_DelTokenRel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DelTokenRel.Name = "ToolStripButton_DelTokenRel"
        Me.ToolStripButton_DelTokenRel.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_DelTokenRel.Text = "ToolStripButton1"
        '
        'Timer_TokenRelation
        '
        Me.Timer_TokenRelation.Interval = 300
        '
        'DataGridView_Relations
        '
        Me.DataGridView_Relations.AllowUserToAddRows = False
        Me.DataGridView_Relations.AllowUserToDeleteRows = False
        Me.DataGridView_Relations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Relations.ContextMenuStrip = Me.ContextMenuStrip_TokRel
        Me.DataGridView_Relations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Relations.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Relations.Name = "DataGridView_Relations"
        Me.DataGridView_Relations.ReadOnly = True
        Me.DataGridView_Relations.Size = New System.Drawing.Size(505, 436)
        Me.DataGridView_Relations.TabIndex = 0
        '
        'UserControl_ObjectRel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.Name = "UserControl_ObjectRel"
        Me.Size = New System.Drawing.Size(505, 486)
        Me.ToolStripContainer2.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ContextMenuStrip_TokRel.ResumeLayout(False)
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        CType(Me.BindingSource_ObjectRel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Relations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_RelCountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_RelCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripProgressBar_TokenRelation As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStrip5 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_FilterLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Filter As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton_DelTokenRel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer_TokenRelation As System.Windows.Forms.Timer
    Friend WithEvents BindingSource_ObjectRel As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip_TokRel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetOrderIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetRelationTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModuleEditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox_ModuleEdit As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ModuleMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox_ModuleMenu As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents CopyValToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EqualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DifferentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContainsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox_TokRelContains As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GreaterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LessThanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView_Relations As System.Windows.Forms.DataGridView

End Class
