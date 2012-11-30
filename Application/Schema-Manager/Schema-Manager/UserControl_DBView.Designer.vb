<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_DBView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_DBView))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView_DBServer = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_LiveView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyLiveViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_Tree = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_SemView = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountSemDBs_Lbl = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_CountSemDBs = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView_DBsSem = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_SemDBs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewSchemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTSQLScriptsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem_SemDB = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage_LiveView = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountDBsLbl = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_CountDBs = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView_DBsLive = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_DBView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachAsSemDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource_DBsLive = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_DBsSem = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip_Databases = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FolderBrowserDialog_Files = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip_LiveView.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_SemView.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStripContainer2.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.DataGridView_DBsSem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_SemDBs.SuspendLayout()
        Me.TabPage_LiveView.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_DBsLive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_DBView.SuspendLayout()
        CType(Me.BindingSource_DBsLive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_DBsSem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView_DBServer)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(745, 349)
        Me.SplitContainer1.SplitterDistance = 248
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView_DBServer
        '
        Me.TreeView_DBServer.ContextMenuStrip = Me.ContextMenuStrip_LiveView
        Me.TreeView_DBServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_DBServer.ImageIndex = 0
        Me.TreeView_DBServer.ImageList = Me.ImageList_Tree
        Me.TreeView_DBServer.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_DBServer.Name = "TreeView_DBServer"
        Me.TreeView_DBServer.SelectedImageIndex = 0
        Me.TreeView_DBServer.Size = New System.Drawing.Size(244, 345)
        Me.TreeView_DBServer.TabIndex = 0
        '
        'ContextMenuStrip_LiveView
        '
        Me.ContextMenuStrip_LiveView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddServerToolStripMenuItem, Me.AddDatabaseToolStripMenuItem, Me.ApplyLiveViewToolStripMenuItem})
        Me.ContextMenuStrip_LiveView.Name = "ContextMenuStrip_LiveView"
        Me.ContextMenuStrip_LiveView.Size = New System.Drawing.Size(167, 70)
        '
        'AddServerToolStripMenuItem
        '
        Me.AddServerToolStripMenuItem.Name = "AddServerToolStripMenuItem"
        Me.AddServerToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AddServerToolStripMenuItem.Text = "x_Add Server"
        '
        'AddDatabaseToolStripMenuItem
        '
        Me.AddDatabaseToolStripMenuItem.Name = "AddDatabaseToolStripMenuItem"
        Me.AddDatabaseToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AddDatabaseToolStripMenuItem.Text = "x_Add Database..."
        '
        'ApplyLiveViewToolStripMenuItem
        '
        Me.ApplyLiveViewToolStripMenuItem.Name = "ApplyLiveViewToolStripMenuItem"
        Me.ApplyLiveViewToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ApplyLiveViewToolStripMenuItem.Text = "x_Apply"
        '
        'ImageList_Tree
        '
        Me.ImageList_Tree.ImageStream = CType(resources.GetObject("ImageList_Tree.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Tree.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Tree.Images.SetKeyName(0, "bb_home_.png")
        Me.ImageList_Tree.Images.SetKeyName(1, "server_olivier_boyer_04.png")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_SemView)
        Me.TabControl1.Controls.Add(Me.TabPage_LiveView)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(489, 345)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_SemView
        '
        Me.TabPage_SemView.Controls.Add(Me.SplitContainer2)
        Me.TabPage_SemView.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_SemView.Name = "TabPage_SemView"
        Me.TabPage_SemView.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_SemView.Size = New System.Drawing.Size(481, 319)
        Me.TabPage_SemView.TabIndex = 0
        Me.TabPage_SemView.Text = "x_Sem-View"
        Me.TabPage_SemView.UseVisualStyleBackColor = True
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
        Me.SplitContainer2.Size = New System.Drawing.Size(475, 313)
        Me.SplitContainer2.SplitterDistance = 301
        Me.SplitContainer2.TabIndex = 0
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.BottomToolStripPanel
        '
        Me.ToolStripContainer2.BottomToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.DataGridView_DBsSem)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(297, 284)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.LeftToolStripPanelVisible = False
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.RightToolStripPanelVisible = False
        Me.ToolStripContainer2.Size = New System.Drawing.Size(297, 309)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        Me.ToolStripContainer2.TopToolStripPanelVisible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountSemDBs_Lbl, Me.ToolStripLabel_CountSemDBs})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(109, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_CountSemDBs_Lbl
        '
        Me.ToolStripLabel_CountSemDBs_Lbl.Name = "ToolStripLabel_CountSemDBs_Lbl"
        Me.ToolStripLabel_CountSemDBs_Lbl.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripLabel_CountSemDBs_Lbl.Text = "x_DBs (Count):"
        '
        'ToolStripLabel_CountSemDBs
        '
        Me.ToolStripLabel_CountSemDBs.Name = "ToolStripLabel_CountSemDBs"
        Me.ToolStripLabel_CountSemDBs.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_CountSemDBs.Text = "0"
        '
        'DataGridView_DBsSem
        '
        Me.DataGridView_DBsSem.AllowUserToAddRows = False
        Me.DataGridView_DBsSem.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_DBsSem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_DBsSem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_DBsSem.ContextMenuStrip = Me.ContextMenuStrip_SemDBs
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_DBsSem.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_DBsSem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_DBsSem.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_DBsSem.Name = "DataGridView_DBsSem"
        Me.DataGridView_DBsSem.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_DBsSem.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_DBsSem.Size = New System.Drawing.Size(297, 284)
        Me.DataGridView_DBsSem.TabIndex = 0
        '
        'ContextMenuStrip_SemDBs
        '
        Me.ContextMenuStrip_SemDBs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSchemaToolStripMenuItem, Me.SaveTSQLScriptsToolStripMenuItem, Me.ApplyToolStripMenuItem_SemDB})
        Me.ContextMenuStrip_SemDBs.Name = "ContextMenuStrip_SemDBs"
        Me.ContextMenuStrip_SemDBs.Size = New System.Drawing.Size(179, 70)
        '
        'NewSchemaToolStripMenuItem
        '
        Me.NewSchemaToolStripMenuItem.Name = "NewSchemaToolStripMenuItem"
        Me.NewSchemaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.NewSchemaToolStripMenuItem.Text = "x_New Schema"
        '
        'SaveTSQLScriptsToolStripMenuItem
        '
        Me.SaveTSQLScriptsToolStripMenuItem.Name = "SaveTSQLScriptsToolStripMenuItem"
        Me.SaveTSQLScriptsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SaveTSQLScriptsToolStripMenuItem.Text = "x_save TSQL-Scripts"
        '
        'ApplyToolStripMenuItem_SemDB
        '
        Me.ApplyToolStripMenuItem_SemDB.Name = "ApplyToolStripMenuItem_SemDB"
        Me.ApplyToolStripMenuItem_SemDB.Size = New System.Drawing.Size(178, 22)
        Me.ApplyToolStripMenuItem_SemDB.Text = "x_Apply"
        Me.ApplyToolStripMenuItem_SemDB.Visible = False
        '
        'TabPage_LiveView
        '
        Me.TabPage_LiveView.Controls.Add(Me.ToolStripContainer1)
        Me.TabPage_LiveView.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_LiveView.Name = "TabPage_LiveView"
        Me.TabPage_LiveView.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_LiveView.Size = New System.Drawing.Size(481, 319)
        Me.TabPage_LiveView.TabIndex = 1
        Me.TabPage_LiveView.Text = "x_LiveView"
        Me.TabPage_LiveView.UseVisualStyleBackColor = True
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_DBsLive)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(475, 288)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(475, 313)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountDBsLbl, Me.ToolStripLabel_CountDBs})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(109, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_CountDBsLbl
        '
        Me.ToolStripLabel_CountDBsLbl.Name = "ToolStripLabel_CountDBsLbl"
        Me.ToolStripLabel_CountDBsLbl.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripLabel_CountDBsLbl.Text = "x_DBs (Count):"
        '
        'ToolStripLabel_CountDBs
        '
        Me.ToolStripLabel_CountDBs.Name = "ToolStripLabel_CountDBs"
        Me.ToolStripLabel_CountDBs.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_CountDBs.Text = "0"
        '
        'DataGridView_DBsLive
        '
        Me.DataGridView_DBsLive.AllowUserToAddRows = False
        Me.DataGridView_DBsLive.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_DBsLive.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView_DBsLive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_DBsLive.ContextMenuStrip = Me.ContextMenuStrip_DBView
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_DBsLive.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView_DBsLive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_DBsLive.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_DBsLive.Name = "DataGridView_DBsLive"
        Me.DataGridView_DBsLive.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_DBsLive.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView_DBsLive.Size = New System.Drawing.Size(475, 288)
        Me.DataGridView_DBsLive.TabIndex = 0
        '
        'ContextMenuStrip_DBView
        '
        Me.ContextMenuStrip_DBView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplyToolStripMenuItem, Me.NewToolStripMenuItem, Me.AttachAsSemDBToolStripMenuItem})
        Me.ContextMenuStrip_DBView.Name = "ContextMenuStrip_DBView"
        Me.ContextMenuStrip_DBView.Size = New System.Drawing.Size(180, 70)
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ApplyToolStripMenuItem.Text = "Apply"
        Me.ApplyToolStripMenuItem.Visible = False
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.NewToolStripMenuItem.Text = "x_New"
        '
        'AttachAsSemDBToolStripMenuItem
        '
        Me.AttachAsSemDBToolStripMenuItem.Name = "AttachAsSemDBToolStripMenuItem"
        Me.AttachAsSemDBToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AttachAsSemDBToolStripMenuItem.Text = "x_Attach as Sem-DB"
        '
        'ContextMenuStrip_Databases
        '
        Me.ContextMenuStrip_Databases.Name = "ContextMenuStrip_Databases"
        Me.ContextMenuStrip_Databases.Size = New System.Drawing.Size(61, 4)
        '
        'UserControl_DBView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_DBView"
        Me.Size = New System.Drawing.Size(745, 349)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip_LiveView.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_SemView.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.DataGridView_DBsSem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_SemDBs.ResumeLayout(False)
        Me.TabPage_LiveView.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_DBsLive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_DBView.ResumeLayout(False)
        CType(Me.BindingSource_DBsLive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_DBsSem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView_DBServer As System.Windows.Forms.TreeView
    Friend WithEvents ImageList_Tree As System.Windows.Forms.ImageList
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_SemView As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_LiveView As System.Windows.Forms.TabPage
    Friend WithEvents BindingSource_DBsLive As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountDBsLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_CountDBs As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_DBsLive As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountSemDBs_Lbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_CountSemDBs As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_DBsSem As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_DBsSem As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip_DBView As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_LiveView As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_SemDBs As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ApplyToolStripMenuItem_SemDB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_Databases As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttachAsSemDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSchemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyLiveViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveTSQLScriptsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog_Files As System.Windows.Forms.FolderBrowserDialog

End Class
