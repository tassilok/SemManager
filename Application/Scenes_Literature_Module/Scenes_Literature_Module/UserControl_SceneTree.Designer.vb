<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_SceneTree
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_SceneTree))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_SceneCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_CountScenes = New System.Windows.Forms.ToolStripLabel()
        Me.TreeView_Scenes = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_SceneTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinwordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenBelongingDocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertBookmarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivateBookmarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_SceneTree = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripComboBox_SearchTemplates = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripTextBox_Search = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_ClearSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_GetRel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Search = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel_FoundLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Found = New System.Windows.Forms.ToolStripLabel()
        Me.ContextMenuStrip_ScenesList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem_Add_List = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Remove_List = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Apply_List = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip_SceneTree.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ContextMenuStrip_ScenesList.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TreeView_Scenes)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(593, 394)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(593, 444)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_SceneCount, Me.ToolStripLabel_CountScenes})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(125, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_SceneCount
        '
        Me.ToolStripLabel_SceneCount.Name = "ToolStripLabel_SceneCount"
        Me.ToolStripLabel_SceneCount.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripLabel_SceneCount.Text = "x_Scenes (Count):"
        '
        'ToolStripLabel_CountScenes
        '
        Me.ToolStripLabel_CountScenes.Name = "ToolStripLabel_CountScenes"
        Me.ToolStripLabel_CountScenes.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_CountScenes.Text = "0"
        '
        'TreeView_Scenes
        '
        Me.TreeView_Scenes.ContextMenuStrip = Me.ContextMenuStrip_SceneTree
        Me.TreeView_Scenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Scenes.ImageIndex = 0
        Me.TreeView_Scenes.ImageList = Me.ImageList_SceneTree
        Me.TreeView_Scenes.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_Scenes.Name = "TreeView_Scenes"
        Me.TreeView_Scenes.SelectedImageIndex = 0
        Me.TreeView_Scenes.Size = New System.Drawing.Size(593, 394)
        Me.TreeView_Scenes.TabIndex = 2
        '
        'ContextMenuStrip_SceneTree
        '
        Me.ContextMenuStrip_SceneTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ExistentToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.WinwordToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_SceneTree.Name = "ContextMenuStrip_SceneTree"
        Me.ContextMenuStrip_SceneTree.Size = New System.Drawing.Size(133, 114)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewToolStripMenuItem.Text = "x_New"
        '
        'ExistentToolStripMenuItem
        '
        Me.ExistentToolStripMenuItem.Name = "ExistentToolStripMenuItem"
        Me.ExistentToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExistentToolStripMenuItem.Text = "x_Existent"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.RemoveToolStripMenuItem.Text = "x_Remove"
        '
        'WinwordToolStripMenuItem
        '
        Me.WinwordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenBelongingDocToolStripMenuItem, Me.InsertBookmarkToolStripMenuItem, Me.ActivateBookmarkToolStripMenuItem})
        Me.WinwordToolStripMenuItem.Name = "WinwordToolStripMenuItem"
        Me.WinwordToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.WinwordToolStripMenuItem.Text = "x_Winword"
        '
        'OpenBelongingDocToolStripMenuItem
        '
        Me.OpenBelongingDocToolStripMenuItem.Name = "OpenBelongingDocToolStripMenuItem"
        Me.OpenBelongingDocToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.OpenBelongingDocToolStripMenuItem.Text = "x_open belonging Doc"
        '
        'InsertBookmarkToolStripMenuItem
        '
        Me.InsertBookmarkToolStripMenuItem.Name = "InsertBookmarkToolStripMenuItem"
        Me.InsertBookmarkToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.InsertBookmarkToolStripMenuItem.Text = "x_insert Bookmark"
        '
        'ActivateBookmarkToolStripMenuItem
        '
        Me.ActivateBookmarkToolStripMenuItem.Name = "ActivateBookmarkToolStripMenuItem"
        Me.ActivateBookmarkToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ActivateBookmarkToolStripMenuItem.Text = "x_activate Bookmark"
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Enabled = False
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        Me.ApplyToolStripMenuItem.Visible = False
        '
        'ImageList_SceneTree
        '
        Me.ImageList_SceneTree.ImageStream = CType(resources.GetObject("ImageList_SceneTree.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_SceneTree.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_SceneTree.Images.SetKeyName(0, "bb_home_.png")
        Me.ImageList_SceneTree.Images.SetKeyName(1, "Types_Closed.png")
        Me.ImageList_SceneTree.Images.SetKeyName(2, "Types_Opened.png")
        Me.ImageList_SceneTree.Images.SetKeyName(3, "Types_Closed.png")
        Me.ImageList_SceneTree.Images.SetKeyName(4, "Types_Opened.png")
        Me.ImageList_SceneTree.Images.SetKeyName(5, "gthumb.ico")
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_SearchTemplates, Me.ToolStripTextBox_Search, Me.ToolStripButton_ClearSearch, Me.ToolStripButton_GetRel, Me.ToolStripButton_Search, Me.ToolStripLabel_FoundLBL, Me.ToolStripLabel_Found})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(506, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripComboBox_SearchTemplates
        '
        Me.ToolStripComboBox_SearchTemplates.Name = "ToolStripComboBox_SearchTemplates"
        Me.ToolStripComboBox_SearchTemplates.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripTextBox_Search
        '
        Me.ToolStripTextBox_Search.Name = "ToolStripTextBox_Search"
        Me.ToolStripTextBox_Search.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripButton_ClearSearch
        '
        Me.ToolStripButton_ClearSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_ClearSearch.Enabled = False
        Me.ToolStripButton_ClearSearch.Image = Global.Scenes_Literature_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_ClearSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ClearSearch.Name = "ToolStripButton_ClearSearch"
        Me.ToolStripButton_ClearSearch.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_ClearSearch.Text = "ToolStripButton1"
        '
        'ToolStripButton_GetRel
        '
        Me.ToolStripButton_GetRel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_GetRel.Image = CType(resources.GetObject("ToolStripButton_GetRel.Image"), System.Drawing.Image)
        Me.ToolStripButton_GetRel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_GetRel.Name = "ToolStripButton_GetRel"
        Me.ToolStripButton_GetRel.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_GetRel.Text = "..."
        '
        'ToolStripButton_Search
        '
        Me.ToolStripButton_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Search.Enabled = False
        Me.ToolStripButton_Search.Image = CType(resources.GetObject("ToolStripButton_Search.Image"), System.Drawing.Image)
        Me.ToolStripButton_Search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Search.Name = "ToolStripButton_Search"
        Me.ToolStripButton_Search.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton_Search.Text = "x_Search"
        '
        'ToolStripLabel_FoundLBL
        '
        Me.ToolStripLabel_FoundLBL.Name = "ToolStripLabel_FoundLBL"
        Me.ToolStripLabel_FoundLBL.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel_FoundLBL.Text = "x_Found:"
        '
        'ToolStripLabel_Found
        '
        Me.ToolStripLabel_Found.Name = "ToolStripLabel_Found"
        Me.ToolStripLabel_Found.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Found.Text = "0"
        '
        'ContextMenuStrip_ScenesList
        '
        Me.ContextMenuStrip_ScenesList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Add_List, Me.ToolStripMenuItem_Remove_List, Me.ToolStripMenuItem_Apply_List})
        Me.ContextMenuStrip_ScenesList.Name = "ContextMenuStrip_SceneTree"
        Me.ContextMenuStrip_ScenesList.Size = New System.Drawing.Size(128, 70)
        '
        'ToolStripMenuItem_Add_List
        '
        Me.ToolStripMenuItem_Add_List.Name = "ToolStripMenuItem_Add_List"
        Me.ToolStripMenuItem_Add_List.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem_Add_List.Text = "x_New"
        '
        'ToolStripMenuItem_Remove_List
        '
        Me.ToolStripMenuItem_Remove_List.Name = "ToolStripMenuItem_Remove_List"
        Me.ToolStripMenuItem_Remove_List.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem_Remove_List.Text = "x_Remove"
        '
        'ToolStripMenuItem_Apply_List
        '
        Me.ToolStripMenuItem_Apply_List.Enabled = False
        Me.ToolStripMenuItem_Apply_List.Name = "ToolStripMenuItem_Apply_List"
        Me.ToolStripMenuItem_Apply_List.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem_Apply_List.Text = "x_Apply"
        Me.ToolStripMenuItem_Apply_List.Visible = False
        '
        'UserControl_SceneTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_SceneTree"
        Me.Size = New System.Drawing.Size(593, 444)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip_SceneTree.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ContextMenuStrip_ScenesList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_SceneCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_CountScenes As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ContextMenuStrip_SceneTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList_SceneTree As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip_ScenesList As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem_Add_List As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Remove_List As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Apply_List As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeView_Scenes As System.Windows.Forms.TreeView
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripTextBox_Search As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents WinwordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertBookmarkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivateBookmarkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenBelongingDocToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox_SearchTemplates As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton_GetRel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Search As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_ClearSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel_FoundLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Found As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ExistentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
