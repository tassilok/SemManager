<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_OItemList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_OItemList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip_Filter = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Filter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox_Filter = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_FilterAdvanced = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_Count = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_CountLbl = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_GUID = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_GUID = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripProgressBar_List = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip_Edit = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_AddItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_DelItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Relate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Sort = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Down = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Up = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Report = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_List = New System.Windows.Forms.TabPage()
        Me.DataGridView_Items = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_SemList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuleMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox_ModuleMenu = New System.Windows.Forms.ToolStripComboBox()
        Me.ModuleEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox_ModuleEdit = New System.Windows.Forms.ToolStripComboBox()
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage_Tree = New System.Windows.Forms.TabPage()
        Me.BindingSource_Token = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_RelationType = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_Type = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_TokenToken = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_Attribute = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer_Filter = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip_Item = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer_List = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip_Filter.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip_Edit.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_List.SuspendLayout()
        CType(Me.DataGridView_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_SemList.SuspendLayout()
        CType(Me.BindingSource_Token, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_RelationType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_TokenToken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Attribute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CopyNameToolStripMenuItem
        '
        Me.CopyNameToolStripMenuItem.Name = "CopyNameToolStripMenuItem"
        Me.CopyNameToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CopyNameToolStripMenuItem.Text = "x_Copy Name"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip_Filter, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip_Edit, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(704, 517)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ToolStrip_Filter
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ToolStrip_Filter, 2)
        Me.ToolStrip_Filter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Filter, Me.ToolStripTextBox_Filter, Me.ToolStripSeparator3, Me.ToolStripButton_FilterAdvanced})
        Me.ToolStrip_Filter.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_Filter.Name = "ToolStrip_Filter"
        Me.ToolStrip_Filter.Size = New System.Drawing.Size(704, 25)
        Me.ToolStrip_Filter.TabIndex = 0
        Me.ToolStrip_Filter.Text = "ToolStrip1"
        '
        'ToolStripButton_Filter
        '
        Me.ToolStripButton_Filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Filter.Image = CType(resources.GetObject("ToolStripButton_Filter.Image"), System.Drawing.Image)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_FilterAdvanced
        '
        Me.ToolStripButton_FilterAdvanced.CheckOnClick = True
        Me.ToolStripButton_FilterAdvanced.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_FilterAdvanced.Image = CType(resources.GetObject("ToolStripButton_FilterAdvanced.Image"), System.Drawing.Image)
        Me.ToolStripButton_FilterAdvanced.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_FilterAdvanced.Name = "ToolStripButton_FilterAdvanced"
        Me.ToolStripButton_FilterAdvanced.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripButton_FilterAdvanced.Text = "x_Advanced Filter..."
        '
        'ToolStrip2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ToolStrip2, 2)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Count, Me.ToolStripLabel_CountLbl, Me.ToolStripSeparator4, Me.ToolStripLabel_GUID, Me.ToolStripTextBox_GUID, Me.ToolStripProgressBar_List})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 492)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(704, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
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
        Me.ToolStripLabel_CountLbl.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel_CountLbl.Text = "x_Item(s)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_GUID
        '
        Me.ToolStripLabel_GUID.Name = "ToolStripLabel_GUID"
        Me.ToolStripLabel_GUID.Size = New System.Drawing.Size(101, 22)
        Me.ToolStripLabel_GUID.Text = "x_GUID (selected):"
        '
        'ToolStripTextBox_GUID
        '
        Me.ToolStripTextBox_GUID.Name = "ToolStripTextBox_GUID"
        Me.ToolStripTextBox_GUID.ReadOnly = True
        Me.ToolStripTextBox_GUID.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripProgressBar_List
        '
        Me.ToolStripProgressBar_List.Name = "ToolStripProgressBar_List"
        Me.ToolStripProgressBar_List.Size = New System.Drawing.Size(100, 22)
        '
        'ToolStrip_Edit
        '
        Me.ToolStrip_Edit.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip_Edit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_AddItem, Me.ToolStripButton_DelItem, Me.ToolStripSeparator1, Me.ToolStripButton_Relate, Me.ToolStripSeparator5, Me.ToolStripButton_Sort, Me.ToolStripButton_Down, Me.ToolStripButton_Up, Me.ToolStripSeparator2, Me.ToolStripButton_Report})
        Me.ToolStrip_Edit.Location = New System.Drawing.Point(674, 25)
        Me.ToolStrip_Edit.Name = "ToolStrip_Edit"
        Me.ToolStrip_Edit.Size = New System.Drawing.Size(30, 467)
        Me.ToolStrip_Edit.TabIndex = 2
        Me.ToolStrip_Edit.Text = "ToolStrip3"
        '
        'ToolStripButton_AddItem
        '
        Me.ToolStripButton_AddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_AddItem.Image = Global.Ontolog_Module.My.Resources.Resources.b_plus
        Me.ToolStripButton_AddItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_AddItem.Name = "ToolStripButton_AddItem"
        Me.ToolStripButton_AddItem.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripButton_AddItem.Text = "ToolStripButton1"
        '
        'ToolStripButton_DelItem
        '
        Me.ToolStripButton_DelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_DelItem.Image = Global.Ontolog_Module.My.Resources.Resources.b_minus
        Me.ToolStripButton_DelItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DelItem.Name = "ToolStripButton_DelItem"
        Me.ToolStripButton_DelItem.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripButton_DelItem.Text = "ToolStripButton2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(29, 6)
        '
        'ToolStripButton_Relate
        '
        Me.ToolStripButton_Relate.CheckOnClick = True
        Me.ToolStripButton_Relate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Relate.Enabled = False
        Me.ToolStripButton_Relate.Image = Global.Ontolog_Module.My.Resources.Resources.RelationTypes_gpride_jean_victor_balin_
        Me.ToolStripButton_Relate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Relate.Name = "ToolStripButton_Relate"
        Me.ToolStripButton_Relate.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripButton_Relate.Text = "ToolStripButton1"
        Me.ToolStripButton_Relate.ToolTipText = "Relate Items"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(29, 6)
        '
        'ToolStripButton_Sort
        '
        Me.ToolStripButton_Sort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Sort.Image = Global.Ontolog_Module.My.Resources.Resources.bb_sort2
        Me.ToolStripButton_Sort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Sort.Name = "ToolStripButton_Sort"
        Me.ToolStripButton_Sort.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripButton_Sort.Text = "ToolStripButton1"
        '
        'ToolStripButton_Down
        '
        Me.ToolStripButton_Down.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Down.Image = Global.Ontolog_Module.My.Resources.Resources.tasto_3_architetto_franc_01
        Me.ToolStripButton_Down.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Down.Name = "ToolStripButton_Down"
        Me.ToolStripButton_Down.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripButton_Down.Text = "ToolStripButton1"
        '
        'ToolStripButton_Up
        '
        Me.ToolStripButton_Up.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Up.Image = Global.Ontolog_Module.My.Resources.Resources.tasto_4_architetto_franc_01
        Me.ToolStripButton_Up.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Up.Name = "ToolStripButton_Up"
        Me.ToolStripButton_Up.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripButton_Up.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(29, 6)
        '
        'ToolStripButton_Report
        '
        Me.ToolStripButton_Report.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Report.Image = Global.Ontolog_Module.My.Resources.Resources.appunti_architetto_franc_01
        Me.ToolStripButton_Report.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Report.Name = "ToolStripButton_Report"
        Me.ToolStripButton_Report.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripButton_Report.Text = "ToolStripButton1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_List)
        Me.TabControl1.Controls.Add(Me.TabPage_Tree)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(668, 461)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage_List
        '
        Me.TabPage_List.Controls.Add(Me.DataGridView_Items)
        Me.TabPage_List.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_List.Name = "TabPage_List"
        Me.TabPage_List.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_List.Size = New System.Drawing.Size(660, 435)
        Me.TabPage_List.TabIndex = 0
        Me.TabPage_List.Text = "x_List"
        Me.TabPage_List.UseVisualStyleBackColor = True
        '
        'DataGridView_Items
        '
        Me.DataGridView_Items.AllowUserToAddRows = False
        Me.DataGridView_Items.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Items.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Items.ContextMenuStrip = Me.ContextMenuStrip_SemList
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Items.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Items.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView_Items.Name = "DataGridView_Items"
        Me.DataGridView_Items.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Items.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_Items.Size = New System.Drawing.Size(654, 429)
        Me.DataGridView_Items.TabIndex = 4
        '
        'ContextMenuStrip_SemList
        '
        Me.ContextMenuStrip_SemList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ApplyToolStripMenuItem, Me.ToClipboardToolStripMenuItem})
        Me.ContextMenuStrip_SemList.Name = "ContextMenuStrip_SemList"
        Me.ContextMenuStrip_SemList.Size = New System.Drawing.Size(151, 70)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyNameToolStripMenuItem, Me.ModuleMenuToolStripMenuItem, Me.ModuleEditToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.EditToolStripMenuItem.Text = "x_Edit"
        '
        'ModuleMenuToolStripMenuItem
        '
        Me.ModuleMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_ModuleMenu})
        Me.ModuleMenuToolStripMenuItem.Name = "ModuleMenuToolStripMenuItem"
        Me.ModuleMenuToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ModuleMenuToolStripMenuItem.Text = "x_Module-Menu"
        '
        'ToolStripComboBox_ModuleMenu
        '
        Me.ToolStripComboBox_ModuleMenu.Name = "ToolStripComboBox_ModuleMenu"
        Me.ToolStripComboBox_ModuleMenu.Size = New System.Drawing.Size(250, 23)
        '
        'ModuleEditToolStripMenuItem
        '
        Me.ModuleEditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_ModuleEdit})
        Me.ModuleEditToolStripMenuItem.Name = "ModuleEditToolStripMenuItem"
        Me.ModuleEditToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ModuleEditToolStripMenuItem.Text = "x_Module-Edit"
        '
        'ToolStripComboBox_ModuleEdit
        '
        Me.ToolStripComboBox_ModuleEdit.Name = "ToolStripComboBox_ModuleEdit"
        Me.ToolStripComboBox_ModuleEdit.Size = New System.Drawing.Size(121, 23)
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        Me.ApplyToolStripMenuItem.Visible = False
        '
        'ToClipboardToolStripMenuItem
        '
        Me.ToClipboardToolStripMenuItem.Name = "ToClipboardToolStripMenuItem"
        Me.ToClipboardToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ToClipboardToolStripMenuItem.Text = "x_to Clipboard"
        '
        'TabPage_Tree
        '
        Me.TabPage_Tree.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Tree.Name = "TabPage_Tree"
        Me.TabPage_Tree.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Tree.Size = New System.Drawing.Size(660, 435)
        Me.TabPage_Tree.TabIndex = 1
        Me.TabPage_Tree.Text = "x_Tree"
        Me.TabPage_Tree.UseVisualStyleBackColor = True
        '
        'Timer_Filter
        '
        Me.Timer_Filter.Interval = 500
        '
        'Timer_List
        '
        Me.Timer_List.Interval = 300
        '
        'UserControl_OItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UserControl_OItemList"
        Me.Size = New System.Drawing.Size(704, 517)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip_Filter.ResumeLayout(False)
        Me.ToolStrip_Filter.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip_Edit.ResumeLayout(False)
        Me.ToolStrip_Edit.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_List.ResumeLayout(False)
        CType(Me.DataGridView_Items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_SemList.ResumeLayout(False)
        CType(Me.BindingSource_Token, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_RelationType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_TokenToken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Attribute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CopyNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip_Filter As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Filter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTextBox_Filter As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_FilterAdvanced As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Count As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_CountLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_GUID As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_GUID As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStrip_Edit As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_AddItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_DelItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Relate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Sort As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Down As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Up As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Report As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_List As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView_Items As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip_SemList As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModuleMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox_ModuleMenu As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ModuleEditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox_ModuleEdit As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage_Tree As System.Windows.Forms.TabPage
    Friend WithEvents BindingSource_Token As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource_RelationType As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource_Type As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource_TokenToken As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource_Attribute As System.Windows.Forms.BindingSource
    Friend WithEvents Timer_Filter As System.Windows.Forms.Timer
    Friend WithEvents ToolTip_Item As System.Windows.Forms.ToolTip
    Friend WithEvents Timer_List As System.Windows.Forms.Timer
    Friend WithEvents ToolStripProgressBar_List As System.Windows.Forms.ToolStripProgressBar

End Class
