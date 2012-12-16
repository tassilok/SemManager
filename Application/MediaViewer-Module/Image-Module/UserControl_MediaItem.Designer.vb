<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_MediaItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_MediaItem))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_MoveFirst = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MovePrevious = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MoveNext = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MoveLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_ItemCountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_ItemCount = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView_MediaItems = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_MediaPlayer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_RelateAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveFromListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetMetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavePlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_MediaPlayer = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.AxWindowsMediaPlayer_Main = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Open = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Bookmarks = New System.Windows.Forms.ToolStripButton()
        Me.TabPage_MediaData = New System.Windows.Forms.TabPage()
        Me.TabPage_Description = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_LoadImage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Copy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Paste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_PlayList = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Replace = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_BookmarksRelItem = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog_MediaItem = New System.Windows.Forms.OpenFileDialog()
        Me.Timer_Play = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Position = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource_MediaItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.FolderBrowserDialog_Playlist = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveMediaItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView_MediaItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_MediaPlayer.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_MediaPlayer.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.BindingSource_MediaItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(510, 360)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(510, 410)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_MoveFirst, Me.ToolStripButton_MovePrevious, Me.ToolStripButton_MoveNext, Me.ToolStripButton_MoveLast, Me.ToolStripSeparator3, Me.ToolStripButton_Delete, Me.ToolStripSeparator1, Me.ToolStripLabel_ItemCountLBL, Me.ToolStripLabel_ItemCount})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(295, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_MoveFirst
        '
        Me.ToolStripButton_MoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MoveFirst.Enabled = False
        Me.ToolStripButton_MoveFirst.Image = Global.MediaViewer_Module.My.Resources.Resources.pulsante_01_architetto_f_01_First
        Me.ToolStripButton_MoveFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MoveFirst.Name = "ToolStripButton_MoveFirst"
        Me.ToolStripButton_MoveFirst.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MoveFirst.Text = "ToolStripButton1"
        '
        'ToolStripButton_MovePrevious
        '
        Me.ToolStripButton_MovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MovePrevious.Enabled = False
        Me.ToolStripButton_MovePrevious.Image = Global.MediaViewer_Module.My.Resources.Resources.pulsante_01_architetto_f_01
        Me.ToolStripButton_MovePrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MovePrevious.Name = "ToolStripButton_MovePrevious"
        Me.ToolStripButton_MovePrevious.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MovePrevious.Text = "ToolStripButton2"
        '
        'ToolStripButton_MoveNext
        '
        Me.ToolStripButton_MoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MoveNext.Enabled = False
        Me.ToolStripButton_MoveNext.Image = Global.MediaViewer_Module.My.Resources.Resources.pulsante_02_architetto_f_01
        Me.ToolStripButton_MoveNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MoveNext.Name = "ToolStripButton_MoveNext"
        Me.ToolStripButton_MoveNext.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MoveNext.Text = "ToolStripButton3"
        '
        'ToolStripButton_MoveLast
        '
        Me.ToolStripButton_MoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MoveLast.Enabled = False
        Me.ToolStripButton_MoveLast.Image = Global.MediaViewer_Module.My.Resources.Resources.pulsante_02_architetto_f_01_Last
        Me.ToolStripButton_MoveLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MoveLast.Name = "ToolStripButton_MoveLast"
        Me.ToolStripButton_MoveLast.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MoveLast.Text = "ToolStripButton4"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Delete
        '
        Me.ToolStripButton_Delete.Enabled = False
        Me.ToolStripButton_Delete.Image = Global.MediaViewer_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
        Me.ToolStripButton_Delete.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripButton_Delete.Text = "x_Delete Image"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_ItemCountLBL
        '
        Me.ToolStripLabel_ItemCountLBL.Name = "ToolStripLabel_ItemCountLBL"
        Me.ToolStripLabel_ItemCountLBL.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel_ItemCountLBL.Text = "x_Items:"
        '
        'ToolStripLabel_ItemCount
        '
        Me.ToolStripLabel_ItemCount.Name = "ToolStripLabel_ItemCount"
        Me.ToolStripLabel_ItemCount.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripLabel_ItemCount.Text = "0/0"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView_MediaItems)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(510, 360)
        Me.SplitContainer1.SplitterDistance = 170
        Me.SplitContainer1.TabIndex = 0
        '
        'DataGridView_MediaItems
        '
        Me.DataGridView_MediaItems.AllowUserToAddRows = False
        Me.DataGridView_MediaItems.AllowUserToDeleteRows = False
        Me.DataGridView_MediaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_MediaItems.ContextMenuStrip = Me.ContextMenuStrip_MediaPlayer
        Me.DataGridView_MediaItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_MediaItems.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_MediaItems.Name = "DataGridView_MediaItems"
        Me.DataGridView_MediaItems.ReadOnly = True
        Me.DataGridView_MediaItems.Size = New System.Drawing.Size(166, 356)
        Me.DataGridView_MediaItems.TabIndex = 0
        '
        'ContextMenuStrip_MediaPlayer
        '
        Me.ContextMenuStrip_MediaPlayer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem, Me.RelateToolStripMenuItem, Me.ToolStripMenuItem_RelateAll, Me.RemoveFromListToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.GetMetaToolStripMenuItem, Me.SavePlaylistToolStripMenuItem, Me.SaveMediaItemsToolStripMenuItem})
        Me.ContextMenuStrip_MediaPlayer.Name = "ContextMenuStrip_MediaPlayer"
        Me.ContextMenuStrip_MediaPlayer.Size = New System.Drawing.Size(180, 202)
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.PlayToolStripMenuItem.Text = "x_Play"
        '
        'RelateToolStripMenuItem
        '
        Me.RelateToolStripMenuItem.Enabled = False
        Me.RelateToolStripMenuItem.Name = "RelateToolStripMenuItem"
        Me.RelateToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.RelateToolStripMenuItem.Text = "x_Relate"
        '
        'ToolStripMenuItem_RelateAll
        '
        Me.ToolStripMenuItem_RelateAll.Enabled = False
        Me.ToolStripMenuItem_RelateAll.Name = "ToolStripMenuItem_RelateAll"
        Me.ToolStripMenuItem_RelateAll.Size = New System.Drawing.Size(179, 22)
        Me.ToolStripMenuItem_RelateAll.Text = "x_Relate all"
        '
        'RemoveFromListToolStripMenuItem
        '
        Me.RemoveFromListToolStripMenuItem.Enabled = False
        Me.RemoveFromListToolStripMenuItem.Name = "RemoveFromListToolStripMenuItem"
        Me.RemoveFromListToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.RemoveFromListToolStripMenuItem.Text = "x_Remove From List"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Enabled = False
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DeleteToolStripMenuItem.Text = "x_Delete"
        '
        'GetMetaToolStripMenuItem
        '
        Me.GetMetaToolStripMenuItem.Name = "GetMetaToolStripMenuItem"
        Me.GetMetaToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.GetMetaToolStripMenuItem.Text = "x_get Meta"
        '
        'SavePlaylistToolStripMenuItem
        '
        Me.SavePlaylistToolStripMenuItem.Name = "SavePlaylistToolStripMenuItem"
        Me.SavePlaylistToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SavePlaylistToolStripMenuItem.Text = "x_Save Playlist"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_MediaPlayer)
        Me.TabControl1.Controls.Add(Me.TabPage_MediaData)
        Me.TabControl1.Controls.Add(Me.TabPage_Description)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(332, 356)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_MediaPlayer
        '
        Me.TabPage_MediaPlayer.Controls.Add(Me.ToolStripContainer2)
        Me.TabPage_MediaPlayer.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_MediaPlayer.Name = "TabPage_MediaPlayer"
        Me.TabPage_MediaPlayer.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_MediaPlayer.Size = New System.Drawing.Size(324, 330)
        Me.TabPage_MediaPlayer.TabIndex = 2
        Me.TabPage_MediaPlayer.Text = "x_MediaPlayer"
        Me.TabPage_MediaPlayer.UseVisualStyleBackColor = True
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.AxWindowsMediaPlayer_Main)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(318, 299)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(318, 324)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip3)
        '
        'AxWindowsMediaPlayer_Main
        '
        Me.AxWindowsMediaPlayer_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer_Main.Enabled = True
        Me.AxWindowsMediaPlayer_Main.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer_Main.Name = "AxWindowsMediaPlayer_Main"
        Me.AxWindowsMediaPlayer_Main.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer_Main.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer_Main.Size = New System.Drawing.Size(318, 299)
        Me.AxWindowsMediaPlayer_Main.TabIndex = 0
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Open, Me.ToolStripSeparator5, Me.ToolStripButton_Bookmarks})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(191, 25)
        Me.ToolStrip3.TabIndex = 0
        '
        'ToolStripButton_Open
        '
        Me.ToolStripButton_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Open.Image = CType(resources.GetObject("ToolStripButton_Open.Image"), System.Drawing.Image)
        Me.ToolStripButton_Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Open.Name = "ToolStripButton_Open"
        Me.ToolStripButton_Open.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton_Open.Text = "x_Open"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Bookmarks
        '
        Me.ToolStripButton_Bookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Bookmarks.Image = CType(resources.GetObject("ToolStripButton_Bookmarks.Image"), System.Drawing.Image)
        Me.ToolStripButton_Bookmarks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Bookmarks.Name = "ToolStripButton_Bookmarks"
        Me.ToolStripButton_Bookmarks.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripButton_Bookmarks.Text = "x_Bookmarks/Ranges"
        '
        'TabPage_MediaData
        '
        Me.TabPage_MediaData.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_MediaData.Name = "TabPage_MediaData"
        Me.TabPage_MediaData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_MediaData.Size = New System.Drawing.Size(324, 330)
        Me.TabPage_MediaData.TabIndex = 0
        Me.TabPage_MediaData.Text = "x_Detail"
        Me.TabPage_MediaData.UseVisualStyleBackColor = True
        '
        'TabPage_Description
        '
        Me.TabPage_Description.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Description.Name = "TabPage_Description"
        Me.TabPage_Description.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Description.Size = New System.Drawing.Size(324, 330)
        Me.TabPage_Description.TabIndex = 1
        Me.TabPage_Description.Text = "x_Description"
        Me.TabPage_Description.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(324, 330)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_LoadImage, Me.ToolStripButton_Copy, Me.ToolStripButton_Paste, Me.ToolStripSeparator2, Me.ToolStripButton_PlayList, Me.ToolStripSeparator4, Me.ToolStripButton_Replace, Me.ToolStripSeparator6, Me.ToolStripButton_BookmarksRelItem})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(311, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripButton_LoadImage
        '
        Me.ToolStripButton_LoadImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_LoadImage.Image = Global.MediaViewer_Module.My.Resources.Resources.b_plus_with_Folder
        Me.ToolStripButton_LoadImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_LoadImage.Name = "ToolStripButton_LoadImage"
        Me.ToolStripButton_LoadImage.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_LoadImage.Text = "ToolStripButton1"
        '
        'ToolStripButton_Copy
        '
        Me.ToolStripButton_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Copy.Enabled = False
        Me.ToolStripButton_Copy.Image = Global.MediaViewer_Module.My.Resources.Resources._1435_ClipBoard
        Me.ToolStripButton_Copy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Copy.Name = "ToolStripButton_Copy"
        Me.ToolStripButton_Copy.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Copy.Text = "ToolStripButton1"
        '
        'ToolStripButton_Paste
        '
        Me.ToolStripButton_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Paste.Image = Global.MediaViewer_Module.My.Resources.Resources.Paste
        Me.ToolStripButton_Paste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Paste.Name = "ToolStripButton_Paste"
        Me.ToolStripButton_Paste.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Paste.Text = "ToolStripButton2"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_PlayList
        '
        Me.ToolStripButton_PlayList.CheckOnClick = True
        Me.ToolStripButton_PlayList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_PlayList.Image = Global.MediaViewer_Module.My.Resources.Resources._next
        Me.ToolStripButton_PlayList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_PlayList.Name = "ToolStripButton_PlayList"
        Me.ToolStripButton_PlayList.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_PlayList.Text = "ToolStripButton1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Replace
        '
        Me.ToolStripButton_Replace.CheckOnClick = True
        Me.ToolStripButton_Replace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Replace.Image = CType(resources.GetObject("ToolStripButton_Replace.Image"), System.Drawing.Image)
        Me.ToolStripButton_Replace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Replace.Name = "ToolStripButton_Replace"
        Me.ToolStripButton_Replace.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton_Replace.Text = "x_Replace"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_BookmarksRelItem
        '
        Me.ToolStripButton_BookmarksRelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_BookmarksRelItem.Image = CType(resources.GetObject("ToolStripButton_BookmarksRelItem.Image"), System.Drawing.Image)
        Me.ToolStripButton_BookmarksRelItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_BookmarksRelItem.Name = "ToolStripButton_BookmarksRelItem"
        Me.ToolStripButton_BookmarksRelItem.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripButton_BookmarksRelItem.Text = "x_Bookmarks/Regions"
        '
        'OpenFileDialog_MediaItem
        '
        Me.OpenFileDialog_MediaItem.FileName = "OpenFileDialog1"
        '
        'Timer_Play
        '
        Me.Timer_Play.Interval = 200
        '
        'Timer_Position
        '
        '
        'BindingSource_MediaItems
        '
        '
        'SaveMediaItemsToolStripMenuItem
        '
        Me.SaveMediaItemsToolStripMenuItem.Enabled = False
        Me.SaveMediaItemsToolStripMenuItem.Name = "SaveMediaItemsToolStripMenuItem"
        Me.SaveMediaItemsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SaveMediaItemsToolStripMenuItem.Text = "x_Save MediaItems"
        '
        'UserControl_MediaItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_MediaItem"
        Me.Size = New System.Drawing.Size(510, 410)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView_MediaItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_MediaPlayer.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_MediaPlayer.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        CType(Me.AxWindowsMediaPlayer_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.BindingSource_MediaItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_MoveFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MovePrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MoveNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MoveLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_ItemCountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_ItemCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_LoadImage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Copy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Paste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Replace As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView_MediaItems As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_MediaData As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Description As System.Windows.Forms.TabPage
    Friend WithEvents BindingSource_MediaItems As System.Windows.Forms.BindingSource
    Friend WithEvents OpenFileDialog_MediaItem As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStrip_MediaPlayer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage_MediaPlayer As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents AxWindowsMediaPlayer_Main As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Open As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents RelateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_RelateAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton_PlayList As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer_Play As System.Windows.Forms.Timer
    Friend WithEvents RemoveFromListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Bookmarks As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_BookmarksRelItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer_Position As System.Windows.Forms.Timer
    Friend WithEvents GetMetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavePlaylistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog_Playlist As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveMediaItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
