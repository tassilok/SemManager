<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeManagementModule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimeManagementModule))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip_Clear = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Filter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox_Filter = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_ClearFilter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Sort = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox_Sort = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_ClearSort = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_CalcCapt = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_Calculation = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripDropDownButton_Calc = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem_AVG = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Calc_Mult = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_CalcAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView_LogManagement = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_TimeManagement = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton_Range = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TodayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YesterdayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XThisWeekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XThisMonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource_LogManagement = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LastTwoWeeksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout
        Me.ToolStripContainer1.ContentPanel.SuspendLayout
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout
        Me.ToolStripContainer1.SuspendLayout
        Me.ToolStrip_Clear.SuspendLayout
        CType(Me.DataGridView_LogManagement,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ContextMenuStrip_TimeManagement.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        CType(Me.BindingSource_LogManagement,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip_Clear)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_LogManagement)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1310, 385)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1310, 435)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStrip_Clear
        '
        Me.ToolStrip_Clear.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip_Clear.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Close, Me.ToolStripSeparator1, Me.ToolStripButton_Filter, Me.ToolStripTextBox_Filter, Me.ToolStripButton_ClearFilter, Me.ToolStripSeparator2, Me.ToolStripButton_Sort, Me.ToolStripTextBox_Sort, Me.ToolStripButton_ClearSort, Me.ToolStripSeparator3, Me.ToolStripLabel_CalcCapt, Me.ToolStripTextBox_Calculation, Me.ToolStripDropDownButton_Calc})
        Me.ToolStrip_Clear.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip_Clear.Name = "ToolStrip_Clear"
        Me.ToolStrip_Clear.Size = New System.Drawing.Size(925, 25)
        Me.ToolStrip_Clear.TabIndex = 0
        '
        'ToolStripButton_Close
        '
        Me.ToolStripButton_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Close.Image = CType(resources.GetObject("ToolStripButton_Close.Image"),System.Drawing.Image)
        Me.ToolStripButton_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
        Me.ToolStripButton_Close.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton_Close.Text = "x_Close"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Filter
        '
        Me.ToolStripButton_Filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Filter.Image = CType(resources.GetObject("ToolStripButton_Filter.Image"),System.Drawing.Image)
        Me.ToolStripButton_Filter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Filter.Name = "ToolStripButton_Filter"
        Me.ToolStripButton_Filter.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton_Filter.Text = "x_Filter:"
        '
        'ToolStripTextBox_Filter
        '
        Me.ToolStripTextBox_Filter.Name = "ToolStripTextBox_Filter"
        Me.ToolStripTextBox_Filter.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripButton_ClearFilter
        '
        Me.ToolStripButton_ClearFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_ClearFilter.Image = Global.TimeManagement_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_ClearFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ClearFilter.Name = "ToolStripButton_ClearFilter"
        Me.ToolStripButton_ClearFilter.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_ClearFilter.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Sort
        '
        Me.ToolStripButton_Sort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Sort.Image = CType(resources.GetObject("ToolStripButton_Sort.Image"),System.Drawing.Image)
        Me.ToolStripButton_Sort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Sort.Name = "ToolStripButton_Sort"
        Me.ToolStripButton_Sort.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripButton_Sort.Text = "x_Sort:"
        '
        'ToolStripTextBox_Sort
        '
        Me.ToolStripTextBox_Sort.Name = "ToolStripTextBox_Sort"
        Me.ToolStripTextBox_Sort.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripButton_ClearSort
        '
        Me.ToolStripButton_ClearSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_ClearSort.Image = Global.TimeManagement_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_ClearSort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ClearSort.Name = "ToolStripButton_ClearSort"
        Me.ToolStripButton_ClearSort.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_ClearSort.Text = "ToolStripButton1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_CalcCapt
        '
        Me.ToolStripLabel_CalcCapt.Name = "ToolStripLabel_CalcCapt"
        Me.ToolStripLabel_CalcCapt.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripLabel_CalcCapt.Text = "Calculation:"
        '
        'ToolStripTextBox_Calculation
        '
        Me.ToolStripTextBox_Calculation.Name = "ToolStripTextBox_Calculation"
        Me.ToolStripTextBox_Calculation.ReadOnly = true
        Me.ToolStripTextBox_Calculation.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripDropDownButton_Calc
        '
        Me.ToolStripDropDownButton_Calc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton_Calc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_AVG, Me.ToolStripMenuItem_Calc_Mult, Me.ToolStripMenuItem_CalcAdd})
        Me.ToolStripDropDownButton_Calc.Image = CType(resources.GetObject("ToolStripDropDownButton_Calc.Image"),System.Drawing.Image)
        Me.ToolStripDropDownButton_Calc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton_Calc.Name = "ToolStripDropDownButton_Calc"
        Me.ToolStripDropDownButton_Calc.Size = New System.Drawing.Size(28, 22)
        Me.ToolStripDropDownButton_Calc.Text = "+"
        '
        'ToolStripMenuItem_AVG
        '
        Me.ToolStripMenuItem_AVG.Name = "ToolStripMenuItem_AVG"
        Me.ToolStripMenuItem_AVG.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem_AVG.Text = "AVG"
        '
        'ToolStripMenuItem_Calc_Mult
        '
        Me.ToolStripMenuItem_Calc_Mult.Name = "ToolStripMenuItem_Calc_Mult"
        Me.ToolStripMenuItem_Calc_Mult.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem_Calc_Mult.Text = "*"
        '
        'ToolStripMenuItem_CalcAdd
        '
        Me.ToolStripMenuItem_CalcAdd.Name = "ToolStripMenuItem_CalcAdd"
        Me.ToolStripMenuItem_CalcAdd.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem_CalcAdd.Text = "+"
        '
        'DataGridView_LogManagement
        '
        Me.DataGridView_LogManagement.AllowUserToAddRows = false
        Me.DataGridView_LogManagement.AllowUserToDeleteRows = false
        Me.DataGridView_LogManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_LogManagement.ContextMenuStrip = Me.ContextMenuStrip_TimeManagement
        Me.DataGridView_LogManagement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_LogManagement.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_LogManagement.Name = "DataGridView_LogManagement"
        Me.DataGridView_LogManagement.ReadOnly = true
        Me.DataGridView_LogManagement.Size = New System.Drawing.Size(1310, 385)
        Me.DataGridView_LogManagement.TabIndex = 0
        '
        'ContextMenuStrip_TimeManagement
        '
        Me.ContextMenuStrip_TimeManagement.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ContextMenuStrip_TimeManagement.Name = "ContextMenuStrip_TimeManagement"
        Me.ContextMenuStrip_TimeManagement.Size = New System.Drawing.Size(109, 48)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.NewToolStripMenuItem.Text = "x_New"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton_Range})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(121, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripDropDownButton_Range
        '
        Me.ToolStripDropDownButton_Range.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton_Range.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodayToolStripMenuItem, Me.YesterdayToolStripMenuItem, Me.XThisWeekToolStripMenuItem, Me.LastTwoWeeksToolStripMenuItem, Me.XThisMonthToolStripMenuItem, Me.AllToolStripMenuItem})
        Me.ToolStripDropDownButton_Range.Image = CType(resources.GetObject("ToolStripDropDownButton_Range.Image"),System.Drawing.Image)
        Me.ToolStripDropDownButton_Range.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton_Range.Name = "ToolStripDropDownButton_Range"
        Me.ToolStripDropDownButton_Range.Size = New System.Drawing.Size(109, 22)
        Me.ToolStripDropDownButton_Range.Text = "x_Last two weeks"
        '
        'TodayToolStripMenuItem
        '
        Me.TodayToolStripMenuItem.Name = "TodayToolStripMenuItem"
        Me.TodayToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.TodayToolStripMenuItem.Text = "x_Today"
        '
        'YesterdayToolStripMenuItem
        '
        Me.YesterdayToolStripMenuItem.Name = "YesterdayToolStripMenuItem"
        Me.YesterdayToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.YesterdayToolStripMenuItem.Text = "x_Yesterday"
        '
        'XThisWeekToolStripMenuItem
        '
        Me.XThisWeekToolStripMenuItem.Name = "XThisWeekToolStripMenuItem"
        Me.XThisWeekToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.XThisWeekToolStripMenuItem.Text = "x_This Week"
        '
        'XThisMonthToolStripMenuItem
        '
        Me.XThisMonthToolStripMenuItem.Name = "XThisMonthToolStripMenuItem"
        Me.XThisMonthToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.XThisMonthToolStripMenuItem.Text = "x_This Month"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AllToolStripMenuItem.Text = "x_All"
        '
        'LastTwoWeeksToolStripMenuItem
        '
        Me.LastTwoWeeksToolStripMenuItem.Name = "LastTwoWeeksToolStripMenuItem"
        Me.LastTwoWeeksToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LastTwoWeeksToolStripMenuItem.Text = "x_Last two weeks"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.EditToolStripMenuItem.Text = "x_Edit"
        '
        'frmTimeManagementModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 435)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmTimeManagementModule"
        Me.Text = "x-TimeManagement"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(false)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(false)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(false)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout
        Me.ToolStripContainer1.ResumeLayout(false)
        Me.ToolStripContainer1.PerformLayout
        Me.ToolStrip_Clear.ResumeLayout(false)
        Me.ToolStrip_Clear.PerformLayout
        CType(Me.DataGridView_LogManagement,System.ComponentModel.ISupportInitialize).EndInit
        Me.ContextMenuStrip_TimeManagement.ResumeLayout(false)
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.BindingSource_LogManagement,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip_Clear As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView_LogManagement As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_LogManagement As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox_Filter As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox_Sort As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton_ClearFilter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Filter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Sort As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_ClearSort As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_CalcCapt As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Calculation As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripDropDownButton_Calc As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem_AVG As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Calc_Mult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_CalcAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton_Range As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TodayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YesterdayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XThisWeekToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XThisMonthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_TimeManagement As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LastTwoWeeksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
