<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_SchemaView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_SchemaView))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountSchemasLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_SchemaCount = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView_Schemas = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_DataGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewSchemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportOtDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToSQLFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_SchemaItems = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.TreeView_SchemaItems = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_SchemaTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GetFromTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetDependenciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchemaItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDependenciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhoNeedsThisItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SynonymsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetSubItemToolStripMenuItem_Synonyms = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_SchemaItems = New System.Windows.Forms.ImageList(Me.components)
        Me.CheckBox_ObjectReferenceTypes = New System.Windows.Forms.CheckBox()
        Me.Button_ChangeVersion = New System.Windows.Forms.Button()
        Me.TextBox_Version = New System.Windows.Forms.TextBox()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.CheckBox_AttributeTypes = New System.Windows.Forms.CheckBox()
        Me.TextBox_SchemaName = New System.Windows.Forms.TextBox()
        Me.Label_SchemaName = New System.Windows.Forms.Label()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_SelectDBItem = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.TabPage_Databases = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer3 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_DatabaseLbl = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Database = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_ItemToolTipLbl = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_ToolTip = New System.Windows.Forms.ToolStripLabel()
        Me.TreeView_DatabasesOfSchema = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_DBView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TestSchemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportexportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyDefinitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_DatabasesOfSchema = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.Timer_DatabaseTree = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip_TreeView = New System.Windows.Forms.ToolTip(Me.components)
        Me.BindingSource_Schemas = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimerNodes = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_Schemas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_DataGrid.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_SchemaItems.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.ContextMenuStrip_SchemaTree.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.SuspendLayout()
        Me.TabPage_Databases.SuspendLayout()
        Me.ToolStripContainer3.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer3.ContentPanel.SuspendLayout()
        Me.ToolStripContainer3.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer3.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ContextMenuStrip_DBView.SuspendLayout()
        CType(Me.BindingSource_Schemas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1021, 667)
        Me.SplitContainer1.SplitterDistance = 237
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_Schemas)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(233, 638)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(233, 663)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountSchemasLBL, Me.ToolStripLabel_SchemaCount})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(75, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_CountSchemasLBL
        '
        Me.ToolStripLabel_CountSchemasLBL.Name = "ToolStripLabel_CountSchemasLBL"
        Me.ToolStripLabel_CountSchemasLBL.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel_CountSchemasLBL.Text = "x_Count:"
        '
        'ToolStripLabel_SchemaCount
        '
        Me.ToolStripLabel_SchemaCount.Name = "ToolStripLabel_SchemaCount"
        Me.ToolStripLabel_SchemaCount.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_SchemaCount.Text = "0"
        '
        'DataGridView_Schemas
        '
        Me.DataGridView_Schemas.AllowUserToAddRows = False
        Me.DataGridView_Schemas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Schemas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Schemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Schemas.ContextMenuStrip = Me.ContextMenuStrip_DataGrid
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Schemas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_Schemas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Schemas.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Schemas.Name = "DataGridView_Schemas"
        Me.DataGridView_Schemas.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Schemas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_Schemas.Size = New System.Drawing.Size(233, 638)
        Me.DataGridView_Schemas.TabIndex = 1
        '
        'ContextMenuStrip_DataGrid
        '
        Me.ContextMenuStrip_DataGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSchemaToolStripMenuItem, Me.DocumentationToolStripMenuItem, Me.ExportOtDBToolStripMenuItem, Me.ApplyToolStripMenuItem1})
        Me.ContextMenuStrip_DataGrid.Name = "ContextMenuStrip_DataGrid"
        Me.ContextMenuStrip_DataGrid.Size = New System.Drawing.Size(177, 114)
        '
        'NewSchemaToolStripMenuItem
        '
        Me.NewSchemaToolStripMenuItem.Name = "NewSchemaToolStripMenuItem"
        Me.NewSchemaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.NewSchemaToolStripMenuItem.Text = "x_New Schema"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DocumentationToolStripMenuItem.Text = "x_Documentation..."
        '
        'ExportOtDBToolStripMenuItem
        '
        Me.ExportOtDBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToSQLFileToolStripMenuItem})
        Me.ExportOtDBToolStripMenuItem.Name = "ExportOtDBToolStripMenuItem"
        Me.ExportOtDBToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ExportOtDBToolStripMenuItem.Text = "x_Export ot DB..."
        '
        'ToSQLFileToolStripMenuItem
        '
        Me.ToSQLFileToolStripMenuItem.Checked = True
        Me.ToSQLFileToolStripMenuItem.CheckOnClick = True
        Me.ToSQLFileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToSQLFileToolStripMenuItem.Name = "ToSQLFileToolStripMenuItem"
        Me.ToSQLFileToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ToSQLFileToolStripMenuItem.Text = "x_to XML"
        '
        'ApplyToolStripMenuItem1
        '
        Me.ApplyToolStripMenuItem1.Name = "ApplyToolStripMenuItem1"
        Me.ApplyToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.ApplyToolStripMenuItem1.Text = "x_Apply"
        Me.ApplyToolStripMenuItem1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_SchemaItems)
        Me.TabControl1.Controls.Add(Me.TabPage_Databases)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 663)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_SchemaItems
        '
        Me.TabPage_SchemaItems.Controls.Add(Me.SplitContainer2)
        Me.TabPage_SchemaItems.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_SchemaItems.Name = "TabPage_SchemaItems"
        Me.TabPage_SchemaItems.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_SchemaItems.Size = New System.Drawing.Size(768, 637)
        Me.TabPage_SchemaItems.TabIndex = 0
        Me.TabPage_SchemaItems.Text = "x_Schema-Items"
        Me.TabPage_SchemaItems.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStripContainer2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(762, 631)
        Me.SplitContainer2.SplitterDistance = 326
        Me.SplitContainer2.TabIndex = 0
        '
        'ToolStripContainer2
        '
        Me.ToolStripContainer2.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.SplitContainer4)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(322, 602)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.LeftToolStripPanelVisible = False
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.RightToolStripPanelVisible = False
        Me.ToolStripContainer2.Size = New System.Drawing.Size(322, 627)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip4)
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.TreeView_SchemaItems)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.CheckBox_ObjectReferenceTypes)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Button_ChangeVersion)
        Me.SplitContainer4.Panel2.Controls.Add(Me.TextBox_Version)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label_Version)
        Me.SplitContainer4.Panel2.Controls.Add(Me.CheckBox_AttributeTypes)
        Me.SplitContainer4.Panel2.Controls.Add(Me.TextBox_SchemaName)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label_SchemaName)
        Me.SplitContainer4.Size = New System.Drawing.Size(322, 602)
        Me.SplitContainer4.SplitterDistance = 399
        Me.SplitContainer4.TabIndex = 0
        '
        'TreeView_SchemaItems
        '
        Me.TreeView_SchemaItems.ContextMenuStrip = Me.ContextMenuStrip_SchemaTree
        Me.TreeView_SchemaItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_SchemaItems.ImageIndex = 0
        Me.TreeView_SchemaItems.ImageList = Me.ImageList_SchemaItems
        Me.TreeView_SchemaItems.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_SchemaItems.Name = "TreeView_SchemaItems"
        Me.TreeView_SchemaItems.SelectedImageIndex = 0
        Me.TreeView_SchemaItems.Size = New System.Drawing.Size(318, 395)
        Me.TreeView_SchemaItems.TabIndex = 2
        '
        'ContextMenuStrip_SchemaTree
        '
        Me.ContextMenuStrip_SchemaTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetFromTemplateToolStripMenuItem, Me.SetDependenciesToolStripMenuItem, Me.ShowDependenciesToolStripMenuItem, Me.SynonymsToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_SchemaTree.Name = "ContextMenuStrip_SchemaTree"
        Me.ContextMenuStrip_SchemaTree.Size = New System.Drawing.Size(183, 136)
        '
        'GetFromTemplateToolStripMenuItem
        '
        Me.GetFromTemplateToolStripMenuItem.Name = "GetFromTemplateToolStripMenuItem"
        Me.GetFromTemplateToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.GetFromTemplateToolStripMenuItem.Text = "x_get from Template"
        '
        'SetDependenciesToolStripMenuItem
        '
        Me.SetDependenciesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SchemaItemsToolStripMenuItem, Me.SemItemsToolStripMenuItem})
        Me.SetDependenciesToolStripMenuItem.Name = "SetDependenciesToolStripMenuItem"
        Me.SetDependenciesToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SetDependenciesToolStripMenuItem.Text = "x_set Dependencies"
        '
        'SchemaItemsToolStripMenuItem
        '
        Me.SchemaItemsToolStripMenuItem.Name = "SchemaItemsToolStripMenuItem"
        Me.SchemaItemsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SchemaItemsToolStripMenuItem.Text = "x_Schema-Items"
        '
        'SemItemsToolStripMenuItem
        '
        Me.SemItemsToolStripMenuItem.Name = "SemItemsToolStripMenuItem"
        Me.SemItemsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SemItemsToolStripMenuItem.Text = "x_Sem-Items"
        '
        'ShowDependenciesToolStripMenuItem
        '
        Me.ShowDependenciesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhoNeedsThisItemToolStripMenuItem})
        Me.ShowDependenciesToolStripMenuItem.Name = "ShowDependenciesToolStripMenuItem"
        Me.ShowDependenciesToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ShowDependenciesToolStripMenuItem.Text = "x_Show Dependencies"
        '
        'WhoNeedsThisItemToolStripMenuItem
        '
        Me.WhoNeedsThisItemToolStripMenuItem.Name = "WhoNeedsThisItemToolStripMenuItem"
        Me.WhoNeedsThisItemToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.WhoNeedsThisItemToolStripMenuItem.Text = "x_who needs this Item?"
        '
        'SynonymsToolStripMenuItem
        '
        Me.SynonymsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetSubItemToolStripMenuItem_Synonyms})
        Me.SynonymsToolStripMenuItem.Name = "SynonymsToolStripMenuItem"
        Me.SynonymsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SynonymsToolStripMenuItem.Text = "x_&Synonyms"
        '
        'GetSubItemToolStripMenuItem_Synonyms
        '
        Me.GetSubItemToolStripMenuItem_Synonyms.Name = "GetSubItemToolStripMenuItem_Synonyms"
        Me.GetSubItemToolStripMenuItem_Synonyms.Size = New System.Drawing.Size(149, 22)
        Me.GetSubItemToolStripMenuItem_Synonyms.Text = "x_get Sub-&Item"
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        Me.ApplyToolStripMenuItem.Visible = False
        '
        'ImageList_SchemaItems
        '
        Me.ImageList_SchemaItems.ImageStream = CType(resources.GetObject("ImageList_SchemaItems.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_SchemaItems.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_SchemaItems.Images.SetKeyName(0, "folder_binary.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(1, "Tables.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(2, "Tables.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(3, "Tables.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(4, "folder_documents.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(5, "Views.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(6, "Views.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(7, "Views.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(8, "folder_apollon.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(9, "Procedures.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(10, "Procedures.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(11, "Procedures.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(12, "folder_grey.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(13, "Functions.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(14, "Functions.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(15, "Functions.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(16, "folder_bomb.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(17, "Synonyms.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(18, "Synonyms.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(19, "Synonyms.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(20, "folder_download.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(21, "Triggers.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(22, "Triggers.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(23, "Triggers.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(24, "tasto_5_architetto_franc_01.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(25, "tasto_6_architetto_franc_01.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(26, "socket.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(27, "socket.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(28, "server_olivier_boyer_04.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(29, "server_olivier_boyer_01.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(30, "folder_binary.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(31, "Tables.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(32, "people_juliane_krug_04a.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(33, "people_juliane_krug_04a.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(34, "racked.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(35, "racked.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(36, "puzzle_architetto_france_01.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(37, "honey.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(38, "Vogelschwarm klein.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(39, "gpride_jean_victor_balin_.png")
        Me.ImageList_SchemaItems.Images.SetKeyName(40, "stormo_di_uccelli_archit_01.png")
        '
        'CheckBox_ObjectReferenceTypes
        '
        Me.CheckBox_ObjectReferenceTypes.AutoSize = True
        Me.CheckBox_ObjectReferenceTypes.Location = New System.Drawing.Point(65, 77)
        Me.CheckBox_ObjectReferenceTypes.Name = "CheckBox_ObjectReferenceTypes"
        Me.CheckBox_ObjectReferenceTypes.Size = New System.Drawing.Size(153, 17)
        Me.CheckBox_ObjectReferenceTypes.TabIndex = 6
        Me.CheckBox_ObjectReferenceTypes.Text = "x_Object-Reference-Types"
        Me.CheckBox_ObjectReferenceTypes.UseVisualStyleBackColor = True
        '
        'Button_ChangeVersion
        '
        Me.Button_ChangeVersion.Location = New System.Drawing.Point(280, 26)
        Me.Button_ChangeVersion.Name = "Button_ChangeVersion"
        Me.Button_ChangeVersion.Size = New System.Drawing.Size(36, 23)
        Me.Button_ChangeVersion.TabIndex = 5
        Me.Button_ChangeVersion.Text = "..."
        Me.Button_ChangeVersion.UseVisualStyleBackColor = True
        '
        'TextBox_Version
        '
        Me.TextBox_Version.Location = New System.Drawing.Point(65, 28)
        Me.TextBox_Version.Name = "TextBox_Version"
        Me.TextBox_Version.ReadOnly = True
        Me.TextBox_Version.Size = New System.Drawing.Size(211, 20)
        Me.TextBox_Version.TabIndex = 4
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Location = New System.Drawing.Point(3, 31)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(56, 13)
        Me.Label_Version.TabIndex = 3
        Me.Label_Version.Text = "x_Version:"
        '
        'CheckBox_AttributeTypes
        '
        Me.CheckBox_AttributeTypes.AutoSize = True
        Me.CheckBox_AttributeTypes.Enabled = False
        Me.CheckBox_AttributeTypes.Location = New System.Drawing.Point(65, 54)
        Me.CheckBox_AttributeTypes.Name = "CheckBox_AttributeTypes"
        Me.CheckBox_AttributeTypes.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox_AttributeTypes.TabIndex = 2
        Me.CheckBox_AttributeTypes.Text = "x_Attribute-Datatypes"
        Me.CheckBox_AttributeTypes.UseVisualStyleBackColor = True
        '
        'TextBox_SchemaName
        '
        Me.TextBox_SchemaName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_SchemaName.Location = New System.Drawing.Point(65, 2)
        Me.TextBox_SchemaName.Name = "TextBox_SchemaName"
        Me.TextBox_SchemaName.ReadOnly = True
        Me.TextBox_SchemaName.Size = New System.Drawing.Size(252, 20)
        Me.TextBox_SchemaName.TabIndex = 1
        '
        'Label_SchemaName
        '
        Me.Label_SchemaName.AutoSize = True
        Me.Label_SchemaName.Location = New System.Drawing.Point(3, 4)
        Me.Label_SchemaName.Name = "Label_SchemaName"
        Me.Label_SchemaName.Size = New System.Drawing.Size(60, 13)
        Me.Label_SchemaName.TabIndex = 0
        Me.Label_SchemaName.Text = "x_Schema:"
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_SelectDBItem})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(96, 25)
        Me.ToolStrip4.TabIndex = 0
        '
        'ToolStripLabel_SelectDBItem
        '
        Me.ToolStripLabel_SelectDBItem.Enabled = False
        Me.ToolStripLabel_SelectDBItem.Name = "ToolStripLabel_SelectDBItem"
        Me.ToolStripLabel_SelectDBItem.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripLabel_SelectDBItem.Text = "x_Select DBItem"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer3.Size = New System.Drawing.Size(432, 631)
        Me.SplitContainer3.SplitterDistance = 425
        Me.SplitContainer3.TabIndex = 0
        '
        'TabPage_Databases
        '
        Me.TabPage_Databases.Controls.Add(Me.ToolStripContainer3)
        Me.TabPage_Databases.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Databases.Name = "TabPage_Databases"
        Me.TabPage_Databases.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Databases.Size = New System.Drawing.Size(768, 637)
        Me.TabPage_Databases.TabIndex = 1
        Me.TabPage_Databases.Text = "x_Databases"
        Me.TabPage_Databases.UseVisualStyleBackColor = True
        '
        'ToolStripContainer3
        '
        '
        'ToolStripContainer3.BottomToolStripPanel
        '
        Me.ToolStripContainer3.BottomToolStripPanel.Controls.Add(Me.ToolStrip3)
        '
        'ToolStripContainer3.ContentPanel
        '
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.TreeView_DatabasesOfSchema)
        Me.ToolStripContainer3.ContentPanel.Size = New System.Drawing.Size(762, 581)
        Me.ToolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer3.LeftToolStripPanelVisible = False
        Me.ToolStripContainer3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer3.Name = "ToolStripContainer3"
        Me.ToolStripContainer3.RightToolStripPanelVisible = False
        Me.ToolStripContainer3.Size = New System.Drawing.Size(762, 631)
        Me.ToolStripContainer3.TabIndex = 0
        Me.ToolStripContainer3.Text = "ToolStripContainer3"
        '
        'ToolStripContainer3.TopToolStripPanel
        '
        Me.ToolStripContainer3.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_DatabaseLbl, Me.ToolStripLabel_Database, Me.ToolStripSeparator1, Me.ToolStripLabel_ItemToolTipLbl, Me.ToolStripLabel_ToolTip})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(179, 25)
        Me.ToolStrip3.TabIndex = 0
        '
        'ToolStripLabel_DatabaseLbl
        '
        Me.ToolStripLabel_DatabaseLbl.Name = "ToolStripLabel_DatabaseLbl"
        Me.ToolStripLabel_DatabaseLbl.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel_DatabaseLbl.Text = "x_Database:"
        '
        'ToolStripLabel_Database
        '
        Me.ToolStripLabel_Database.Name = "ToolStripLabel_Database"
        Me.ToolStripLabel_Database.Size = New System.Drawing.Size(11, 22)
        Me.ToolStripLabel_Database.Text = "-"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_ItemToolTipLbl
        '
        Me.ToolStripLabel_ItemToolTipLbl.Name = "ToolStripLabel_ItemToolTipLbl"
        Me.ToolStripLabel_ItemToolTipLbl.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripLabel_ItemToolTipLbl.Text = "x_Itemcount:"
        '
        'ToolStripLabel_ToolTip
        '
        Me.ToolStripLabel_ToolTip.Name = "ToolStripLabel_ToolTip"
        Me.ToolStripLabel_ToolTip.Size = New System.Drawing.Size(11, 22)
        Me.ToolStripLabel_ToolTip.Text = "-"
        '
        'TreeView_DatabasesOfSchema
        '
        Me.TreeView_DatabasesOfSchema.ContextMenuStrip = Me.ContextMenuStrip_DBView
        Me.TreeView_DatabasesOfSchema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_DatabasesOfSchema.ImageIndex = 0
        Me.TreeView_DatabasesOfSchema.ImageList = Me.ImageList_DatabasesOfSchema
        Me.TreeView_DatabasesOfSchema.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_DatabasesOfSchema.Name = "TreeView_DatabasesOfSchema"
        Me.TreeView_DatabasesOfSchema.SelectedImageIndex = 0
        Me.TreeView_DatabasesOfSchema.Size = New System.Drawing.Size(762, 581)
        Me.TreeView_DatabasesOfSchema.TabIndex = 0
        '
        'ContextMenuStrip_DBView
        '
        Me.ContextMenuStrip_DBView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestSchemaToolStripMenuItem, Me.ImportexportToolStripMenuItem, Me.CopyDefinitionToolStripMenuItem})
        Me.ContextMenuStrip_DBView.Name = "ContextMenuStrip_DBView"
        Me.ContextMenuStrip_DBView.Size = New System.Drawing.Size(168, 70)
        '
        'TestSchemaToolStripMenuItem
        '
        Me.TestSchemaToolStripMenuItem.Name = "TestSchemaToolStripMenuItem"
        Me.TestSchemaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.TestSchemaToolStripMenuItem.Text = "x_Test Schema"
        '
        'ImportexportToolStripMenuItem
        '
        Me.ImportexportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.ImportexportToolStripMenuItem.Name = "ImportexportToolStripMenuItem"
        Me.ImportexportToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ImportexportToolStripMenuItem.Text = "x_import/export"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ImportToolStripMenuItem.Text = "x_import"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ExportToolStripMenuItem.Text = "x_export"
        '
        'CopyDefinitionToolStripMenuItem
        '
        Me.CopyDefinitionToolStripMenuItem.Name = "CopyDefinitionToolStripMenuItem"
        Me.CopyDefinitionToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CopyDefinitionToolStripMenuItem.Text = "x_Copy Definition"
        '
        'ImageList_DatabasesOfSchema
        '
        Me.ImageList_DatabasesOfSchema.ImageStream = CType(resources.GetObject("ImageList_DatabasesOfSchema.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_DatabasesOfSchema.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(0, "bb_home_.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(1, "unita_disco_rigido_archi_01.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(2, "folder_grey.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(3, "Functions.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(4, "Functions_in.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(5, "Functions_out.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(6, "Functions Definition.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(7, "folder_apollon.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(8, "Procedures.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(9, "Procedures_in.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(10, "Procedures_out.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(11, "Procedures Definition.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(12, "folder_bomb.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(13, "Synonyms.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(14, "Synonyms_int.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(15, "Synonyms_out.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(16, "Synonyms Definition.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(17, "folder_binary.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(18, "Tables.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(19, "Tables in.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(20, "Tables out.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(21, "Tables Definition.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(22, "folder_download.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(23, "Triggers.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(24, "Triggers in.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(25, "Triggers out.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(26, "Triggers Definition.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(27, "folder_documents.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(28, "Views.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(29, "Views in.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(30, "Views out.png")
        Me.ImageList_DatabasesOfSchema.Images.SetKeyName(31, "Views Definition.png")
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(109, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(220, 396)
        '
        'Timer_DatabaseTree
        '
        Me.Timer_DatabaseTree.Interval = 500
        '
        'TimerNodes
        '
        Me.TimerNodes.Interval = 300
        '
        'UserControl_SchemaView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_SchemaView"
        Me.Size = New System.Drawing.Size(1021, 667)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_Schemas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_DataGrid.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_SchemaItems.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ContextMenuStrip_SchemaTree.ResumeLayout(False)
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.TabPage_Databases.ResumeLayout(False)
        Me.ToolStripContainer3.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer3.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer3.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer3.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer3.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer3.ResumeLayout(False)
        Me.ToolStripContainer3.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ContextMenuStrip_DBView.ResumeLayout(False)
        CType(Me.BindingSource_Schemas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BindingSource_Schemas As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountSchemasLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_SchemaCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_Schemas As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_SchemaItems As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabPage_Databases As System.Windows.Forms.TabPage
    Friend WithEvents ImageList_SchemaItems As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ContextMenuStrip_SchemaTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GetFromTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SetDependenciesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SynonymsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetSubItemToolStripMenuItem_Synonyms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchemaItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SemItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList_DatabasesOfSchema As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripContainer3 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_DatabaseLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Database As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_ItemToolTipLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_ToolTip As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents Timer_DatabaseTree As System.Windows.Forms.Timer
    Friend WithEvents TreeView_DatabasesOfSchema As System.Windows.Forms.TreeView
    Friend WithEvents ContextMenuStrip_DBView As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TestSchemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip_TreeView As System.Windows.Forms.ToolTip
    Friend WithEvents ImportexportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyDefinitionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_DataGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportOtDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_SelectDBItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView_SchemaItems As System.Windows.Forms.TreeView
    Friend WithEvents CheckBox_AttributeTypes As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox_SchemaName As System.Windows.Forms.TextBox
    Friend WithEvents Label_SchemaName As System.Windows.Forms.Label
    Friend WithEvents Button_ChangeVersion As System.Windows.Forms.Button
    Friend WithEvents TextBox_Version As System.Windows.Forms.TextBox
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents DocumentationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowDependenciesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhoNeedsThisItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToSQLFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox_ObjectReferenceTypes As System.Windows.Forms.CheckBox
    Friend WithEvents NewSchemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerNodes As System.Windows.Forms.Timer

End Class
