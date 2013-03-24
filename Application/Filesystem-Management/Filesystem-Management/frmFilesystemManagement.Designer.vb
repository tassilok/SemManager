<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilesystemManagement
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFilesystemManagement))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1_DB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_DBName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusToolStripLable_Ctrl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolstripToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckExistanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObjectListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartBlobWatcherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetaBlobsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetHashOfFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView_Folder = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_Tree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem_Tree = New System.Windows.Forms.ToolStripMenuItem()
        Me.Open_Tree_ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuleActionsToolStripMenuItem_Tree = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox_ModuleActions_Tree = New System.Windows.Forms.ToolStripComboBox()
        Me.ContextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeNodeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Count = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView_Files = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_DataGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem_DataGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuleActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox_ModuleActions = New System.Windows.Forms.ToolStripComboBox()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlobsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateBlobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XputBackToFSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetMetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_Search = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_Search = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_ClearSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FoldersToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_ObjectList_Label = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_ObjectList = New System.Windows.Forms.ToolStripLabel()
        Me.FolderBrowserDialog_Download = New System.Windows.Forms.FolderBrowserDialog()
        Me.BindingSource_Files = New System.Windows.Forms.BindingSource(Me.components)
        Me.GUIDAsNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip_Tree.SuspendLayout()
        Me.ToolStripContainer2.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_Files, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_DataGrid.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.BindingSource_Files, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1_DB, Me.ToolStripStatusLabel_DBName, Me.StatusToolStripLable_Ctrl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 381)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(536, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1_DB
        '
        Me.ToolStripStatusLabel1_DB.Name = "ToolStripStatusLabel1_DB"
        Me.ToolStripStatusLabel1_DB.Size = New System.Drawing.Size(36, 17)
        Me.ToolStripStatusLabel1_DB.Text = "x_DB:"
        '
        'ToolStripStatusLabel_DBName
        '
        Me.ToolStripStatusLabel_DBName.BackColor = System.Drawing.Color.LemonChiffon
        Me.ToolStripStatusLabel_DBName.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel_DBName.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripStatusLabel_DBName.Name = "ToolStripStatusLabel_DBName"
        Me.ToolStripStatusLabel_DBName.Size = New System.Drawing.Size(31, 17)
        Me.ToolStripStatusLabel_DBName.Text = "n.a."
        '
        'StatusToolStripLable_Ctrl
        '
        Me.StatusToolStripLable_Ctrl.Name = "StatusToolStripLable_Ctrl"
        Me.StatusToolStripLable_Ctrl.Size = New System.Drawing.Size(24, 17)
        Me.StatusToolStripLable_Ctrl.Text = "Ctrl"
        Me.StatusToolStripLable_Ctrl.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(536, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FileToolStripMenuItem.Text = "x_File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.ExitToolStripMenuItem.Text = "x_Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolstripToolStripMenuItem, Me.TaskbarToolStripMenuItem, Me.FolderToolStripMenuItem, Me.CheckExistanceToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ViewToolStripMenuItem.Text = "x_View"
        '
        'ToolstripToolStripMenuItem
        '
        Me.ToolstripToolStripMenuItem.Checked = True
        Me.ToolstripToolStripMenuItem.CheckOnClick = True
        Me.ToolstripToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolstripToolStripMenuItem.Name = "ToolstripToolStripMenuItem"
        Me.ToolstripToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ToolstripToolStripMenuItem.Text = "x_Toolstrip"
        '
        'TaskbarToolStripMenuItem
        '
        Me.TaskbarToolStripMenuItem.Checked = True
        Me.TaskbarToolStripMenuItem.CheckOnClick = True
        Me.TaskbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TaskbarToolStripMenuItem.Name = "TaskbarToolStripMenuItem"
        Me.TaskbarToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TaskbarToolStripMenuItem.Text = "x_Taskbar"
        '
        'FolderToolStripMenuItem
        '
        Me.FolderToolStripMenuItem.Checked = True
        Me.FolderToolStripMenuItem.CheckOnClick = True
        Me.FolderToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem"
        Me.FolderToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FolderToolStripMenuItem.Text = "x_Folder"
        '
        'CheckExistanceToolStripMenuItem
        '
        Me.CheckExistanceToolStripMenuItem.Checked = True
        Me.CheckExistanceToolStripMenuItem.CheckOnClick = True
        Me.CheckExistanceToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckExistanceToolStripMenuItem.Name = "CheckExistanceToolStripMenuItem"
        Me.CheckExistanceToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CheckExistanceToolStripMenuItem.Text = "x_Check Existance"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.BrowseToolStripMenuItem, Me.ObjectListToolStripMenuItem, Me.StartBlobWatcherToolStripMenuItem, Me.MenuToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.GetHashOfFilesToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ToolsToolStripMenuItem.Text = "x_Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.OptionsToolStripMenuItem.Text = "x_Options"
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Checked = True
        Me.BrowseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.BrowseToolStripMenuItem.Text = "x_Browse"
        '
        'ObjectListToolStripMenuItem
        '
        Me.ObjectListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ExistentToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ObjectListToolStripMenuItem.Name = "ObjectListToolStripMenuItem"
        Me.ObjectListToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ObjectListToolStripMenuItem.Text = "x_Object-List"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NewToolStripMenuItem.Text = "x_New"
        '
        'ExistentToolStripMenuItem
        '
        Me.ExistentToolStripMenuItem.Name = "ExistentToolStripMenuItem"
        Me.ExistentToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ExistentToolStripMenuItem.Text = "x_Existent"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ClearToolStripMenuItem.Text = "x_Clear"
        '
        'StartBlobWatcherToolStripMenuItem
        '
        Me.StartBlobWatcherToolStripMenuItem.Name = "StartBlobWatcherToolStripMenuItem"
        Me.StartBlobWatcherToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.StartBlobWatcherToolStripMenuItem.Text = "x_Start Blob-Watcher"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MenuToolStripMenuItem.Text = "x_Menu"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MetaBlobsToolStripMenuItem})
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.RefreshToolStripMenuItem.Text = "x_Refresh"
        '
        'MetaBlobsToolStripMenuItem
        '
        Me.MetaBlobsToolStripMenuItem.Name = "MetaBlobsToolStripMenuItem"
        Me.MetaBlobsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.MetaBlobsToolStripMenuItem.Text = "x_Meta (Blobs)"
        '
        'GetHashOfFilesToolStripMenuItem
        '
        Me.GetHashOfFilesToolStripMenuItem.Name = "GetHashOfFilesToolStripMenuItem"
        Me.GetHashOfFilesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.GetHashOfFilesToolStripMenuItem.Text = "x_get Hash of Files"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(536, 332)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(536, 357)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView_Folder)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(536, 332)
        Me.SplitContainer1.SplitterDistance = 178
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView_Folder
        '
        Me.TreeView_Folder.ContextMenuStrip = Me.ContextMenuStrip_Tree
        Me.TreeView_Folder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Folder.ImageIndex = 3
        Me.TreeView_Folder.ImageList = Me.TreeNodeImageList
        Me.TreeView_Folder.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_Folder.Name = "TreeView_Folder"
        Me.TreeView_Folder.SelectedImageIndex = 3
        Me.TreeView_Folder.Size = New System.Drawing.Size(174, 328)
        Me.TreeView_Folder.TabIndex = 0
        '
        'ContextMenuStrip_Tree
        '
        Me.ContextMenuStrip_Tree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem_Tree, Me.Open_Tree_ToolStripMenuItem1, Me.ApplyToolStripMenuItem, Me.ModuleActionsToolStripMenuItem_Tree})
        Me.ContextMenuStrip_Tree.Name = "ContextMenuStrip_Tree"
        Me.ContextMenuStrip_Tree.Size = New System.Drawing.Size(162, 92)
        '
        'NewToolStripMenuItem_Tree
        '
        Me.NewToolStripMenuItem_Tree.Name = "NewToolStripMenuItem_Tree"
        Me.NewToolStripMenuItem_Tree.Size = New System.Drawing.Size(161, 22)
        Me.NewToolStripMenuItem_Tree.Text = "x_New"
        '
        'Open_Tree_ToolStripMenuItem1
        '
        Me.Open_Tree_ToolStripMenuItem1.Enabled = False
        Me.Open_Tree_ToolStripMenuItem1.Name = "Open_Tree_ToolStripMenuItem1"
        Me.Open_Tree_ToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.Open_Tree_ToolStripMenuItem1.Text = "x_Open"
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        '
        'ModuleActionsToolStripMenuItem_Tree
        '
        Me.ModuleActionsToolStripMenuItem_Tree.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_ModuleActions_Tree, Me.ContextToolStripMenuItem})
        Me.ModuleActionsToolStripMenuItem_Tree.Name = "ModuleActionsToolStripMenuItem_Tree"
        Me.ModuleActionsToolStripMenuItem_Tree.Size = New System.Drawing.Size(161, 22)
        Me.ModuleActionsToolStripMenuItem_Tree.Text = "x_Module_Actions"
        '
        'ToolStripComboBox_ModuleActions_Tree
        '
        Me.ToolStripComboBox_ModuleActions_Tree.Name = "ToolStripComboBox_ModuleActions_Tree"
        Me.ToolStripComboBox_ModuleActions_Tree.Size = New System.Drawing.Size(200, 21)
        '
        'ContextToolStripMenuItem
        '
        Me.ContextToolStripMenuItem.Name = "ContextToolStripMenuItem"
        Me.ContextToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.ContextToolStripMenuItem.Text = "x_Context"
        '
        'TreeNodeImageList
        '
        Me.TreeNodeImageList.ImageStream = CType(resources.GetObject("TreeNodeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TreeNodeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TreeNodeImageList.Images.SetKeyName(0, "ClosedFolder")
        Me.TreeNodeImageList.Images.SetKeyName(1, "OpenFolder")
        Me.TreeNodeImageList.Images.SetKeyName(2, "jigsaw_green_02.png")
        Me.TreeNodeImageList.Images.SetKeyName(3, "server_olivier_boyer_01.png")
        Me.TreeNodeImageList.Images.SetKeyName(4, "gnome-dev-harddisk.png")
        Me.TreeNodeImageList.Images.SetKeyName(5, "gnome-fs-directory.png")
        Me.TreeNodeImageList.Images.SetKeyName(6, "gnome-fs-directory-accept.png")
        Me.TreeNodeImageList.Images.SetKeyName(7, "bb_home_.png")
        Me.TreeNodeImageList.Images.SetKeyName(8, "Parentless Files.png")
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.BottomToolStripPanel
        '
        Me.ToolStripContainer2.BottomToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.DataGridView_Files)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(350, 278)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(350, 328)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountLBL, Me.ToolStripLabel_Count})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(75, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_CountLBL
        '
        Me.ToolStripLabel_CountLBL.Name = "ToolStripLabel_CountLBL"
        Me.ToolStripLabel_CountLBL.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel_CountLBL.Text = "x_Count:"
        '
        'ToolStripLabel_Count
        '
        Me.ToolStripLabel_Count.Name = "ToolStripLabel_Count"
        Me.ToolStripLabel_Count.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Count.Text = "0"
        '
        'DataGridView_Files
        '
        Me.DataGridView_Files.AllowDrop = True
        Me.DataGridView_Files.AllowUserToAddRows = False
        Me.DataGridView_Files.AllowUserToDeleteRows = False
        Me.DataGridView_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Files.ContextMenuStrip = Me.ContextMenuStrip_DataGrid
        Me.DataGridView_Files.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Files.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Files.Name = "DataGridView_Files"
        Me.DataGridView_Files.ReadOnly = True
        Me.DataGridView_Files.Size = New System.Drawing.Size(350, 278)
        Me.DataGridView_Files.TabIndex = 1
        '
        'ContextMenuStrip_DataGrid
        '
        Me.ContextMenuStrip_DataGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem_DataGrid, Me.OpenToolStripMenuItem, Me.ApplyFilesToolStripMenuItem, Me.ModuleActionsToolStripMenuItem, Me.EditToolStripMenuItem, Me.BlobsToolStripMenuItem})
        Me.ContextMenuStrip_DataGrid.Name = "ContextMenuStrip_DataGrid"
        Me.ContextMenuStrip_DataGrid.Size = New System.Drawing.Size(160, 158)
        '
        'NewToolStripMenuItem_DataGrid
        '
        Me.NewToolStripMenuItem_DataGrid.Name = "NewToolStripMenuItem_DataGrid"
        Me.NewToolStripMenuItem_DataGrid.Size = New System.Drawing.Size(159, 22)
        Me.NewToolStripMenuItem_DataGrid.Text = "x_New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Enabled = False
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.OpenToolStripMenuItem.Text = "x_Open"
        '
        'ApplyFilesToolStripMenuItem
        '
        Me.ApplyFilesToolStripMenuItem.Name = "ApplyFilesToolStripMenuItem"
        Me.ApplyFilesToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ApplyFilesToolStripMenuItem.Text = "x_Apply"
        '
        'ModuleActionsToolStripMenuItem
        '
        Me.ModuleActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_ModuleActions})
        Me.ModuleActionsToolStripMenuItem.Name = "ModuleActionsToolStripMenuItem"
        Me.ModuleActionsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ModuleActionsToolStripMenuItem.Text = "x_Module-Actions"
        '
        'ToolStripComboBox_ModuleActions
        '
        Me.ToolStripComboBox_ModuleActions.Name = "ToolStripComboBox_ModuleActions"
        Me.ToolStripComboBox_ModuleActions.Size = New System.Drawing.Size(200, 21)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyPathToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.EditToolStripMenuItem.Text = "x_Edit"
        '
        'CopyPathToolStripMenuItem
        '
        Me.CopyPathToolStripMenuItem.Name = "CopyPathToolStripMenuItem"
        Me.CopyPathToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyPathToolStripMenuItem.Text = "x_Copy Path"
        '
        'BlobsToolStripMenuItem
        '
        Me.BlobsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateBlobToolStripMenuItem, Me.XputBackToFSToolStripMenuItem, Me.DownloadToolStripMenuItem, Me.GetMetaToolStripMenuItem})
        Me.BlobsToolStripMenuItem.Name = "BlobsToolStripMenuItem"
        Me.BlobsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BlobsToolStripMenuItem.Text = "x_Blobs"
        '
        'CreateBlobToolStripMenuItem
        '
        Me.CreateBlobToolStripMenuItem.Name = "CreateBlobToolStripMenuItem"
        Me.CreateBlobToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CreateBlobToolStripMenuItem.Text = "x_create Blob"
        '
        'XputBackToFSToolStripMenuItem
        '
        Me.XputBackToFSToolStripMenuItem.Name = "XputBackToFSToolStripMenuItem"
        Me.XputBackToFSToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.XputBackToFSToolStripMenuItem.Text = "x_put back to FS"
        '
        'DownloadToolStripMenuItem
        '
        Me.DownloadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GUIDAsNameToolStripMenuItem})
        Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
        Me.DownloadToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DownloadToolStripMenuItem.Text = "x_Download"
        '
        'GetMetaToolStripMenuItem
        '
        Me.GetMetaToolStripMenuItem.Name = "GetMetaToolStripMenuItem"
        Me.GetMetaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.GetMetaToolStripMenuItem.Text = "x_get meta"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox_Search, Me.ToolStripButton_Search, Me.ToolStripButton_ClearSearch})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(314, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel1.Text = "x_Search:"
        '
        'ToolStripTextBox_Search
        '
        Me.ToolStripTextBox_Search.Name = "ToolStripTextBox_Search"
        Me.ToolStripTextBox_Search.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripButton_Search
        '
        Me.ToolStripButton_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Search.Enabled = False
        Me.ToolStripButton_Search.Image = Global.Filesystem_Management.My.Resources.Resources.tasto_7_architetto_franc_01
        Me.ToolStripButton_Search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Search.Name = "ToolStripButton_Search"
        Me.ToolStripButton_Search.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Search.Text = "ToolStripButton1"
        '
        'ToolStripButton_ClearSearch
        '
        Me.ToolStripButton_ClearSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_ClearSearch.Enabled = False
        Me.ToolStripButton_ClearSearch.Image = Global.Filesystem_Management.My.Resources.Resources.tasto_11_architetto_fran_01
        Me.ToolStripButton_ClearSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ClearSearch.Name = "ToolStripButton_ClearSearch"
        Me.ToolStripButton_ClearSearch.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_ClearSearch.Text = "ToolStripButton1"
        '
        'ToolStrip
        '
        Me.ToolStrip.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FoldersToolStripButton, Me.ToolStripSeparator8, Me.ToolStripLabel_ObjectList_Label, Me.ToolStripLabel_ObjectList})
        Me.ToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(175, 25)
        Me.ToolStrip.TabIndex = 1
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'FoldersToolStripButton
        '
        Me.FoldersToolStripButton.Checked = True
        Me.FoldersToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FoldersToolStripButton.Image = CType(resources.GetObject("FoldersToolStripButton.Image"), System.Drawing.Image)
        Me.FoldersToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.FoldersToolStripButton.Name = "FoldersToolStripButton"
        Me.FoldersToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.FoldersToolStripButton.Text = "x_Ordner"
        Me.FoldersToolStripButton.ToolTipText = "Ordneransicht umschalten"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_ObjectList_Label
        '
        Me.ToolStripLabel_ObjectList_Label.Name = "ToolStripLabel_ObjectList_Label"
        Me.ToolStripLabel_ObjectList_Label.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripLabel_ObjectList_Label.Text = "x_Object-List:"
        '
        'ToolStripLabel_ObjectList
        '
        Me.ToolStripLabel_ObjectList.Name = "ToolStripLabel_ObjectList"
        Me.ToolStripLabel_ObjectList.Size = New System.Drawing.Size(11, 22)
        Me.ToolStripLabel_ObjectList.Text = "-"
        '
        'GUIDAsNameToolStripMenuItem
        '
        Me.GUIDAsNameToolStripMenuItem.CheckOnClick = True
        Me.GUIDAsNameToolStripMenuItem.Name = "GUIDAsNameToolStripMenuItem"
        Me.GUIDAsNameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GUIDAsNameToolStripMenuItem.Text = "GUID as Name"
        '
        'frmFilesystemManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 403)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFilesystemManagement"
        Me.Text = "x_FilesystemManagement"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip_Tree.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_Files, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_DataGrid.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.BindingSource_Files, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel_DBName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1_DB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolstripToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckExistanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObjectListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExistentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FoldersToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_ObjectList_Label As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_ObjectList As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TreeView_Folder As System.Windows.Forms.TreeView
    Friend WithEvents TreeNodeImageList As System.Windows.Forms.ImageList
    Friend WithEvents StatusToolStripLable_Ctrl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BindingSource_Files As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip_Tree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem_Tree As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_DataGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem_DataGrid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModuleActionsToolStripMenuItem_Tree As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox_ModuleActions_Tree As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ModuleActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox_ModuleActions As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ContextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlobsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateBlobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XputBackToFSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Open_Tree_ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartBlobWatcherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog_Download As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetaBlobsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents DataGridView_Files As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Count As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Search As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton_Search As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_ClearSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents GetMetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetHashOfFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GUIDAsNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
