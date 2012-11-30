<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFolderBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFolderBrowser))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_Reading = New System.Windows.Forms.ToolStripLabel()
        Me.TreeView_Folder = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_Tree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenExternToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_FileSystem = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer_Browse = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip_Tree.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TreeView_Folder)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(589, 328)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(589, 353)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Close, Me.ToolStripSeparator1, Me.ToolStripLabel_Reading})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(68, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Close
        '
        Me.ToolStripButton_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Close.Image = CType(resources.GetObject("ToolStripButton_Close.Image"), System.Drawing.Image)
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
        'ToolStripLabel_Reading
        '
        Me.ToolStripLabel_Reading.Name = "ToolStripLabel_Reading"
        Me.ToolStripLabel_Reading.Size = New System.Drawing.Size(0, 22)
        '
        'TreeView_Folder
        '
        Me.TreeView_Folder.ContextMenuStrip = Me.ContextMenuStrip_Tree
        Me.TreeView_Folder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Folder.ImageIndex = 0
        Me.TreeView_Folder.ImageList = Me.ImageList_FileSystem
        Me.TreeView_Folder.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_Folder.Name = "TreeView_Folder"
        Me.TreeView_Folder.SelectedImageIndex = 0
        Me.TreeView_Folder.Size = New System.Drawing.Size(589, 328)
        Me.TreeView_Folder.TabIndex = 0
        '
        'ContextMenuStrip_Tree
        '
        Me.ContextMenuStrip_Tree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenExternToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_Tree.Name = "ContextMenuStrip_Tree"
        Me.ContextMenuStrip_Tree.Size = New System.Drawing.Size(158, 48)
        '
        'OpenExternToolStripMenuItem
        '
        Me.OpenExternToolStripMenuItem.Name = "OpenExternToolStripMenuItem"
        Me.OpenExternToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.OpenExternToolStripMenuItem.Text = "x_Open Extern..."
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        '
        'ImageList_FileSystem
        '
        Me.ImageList_FileSystem.ImageStream = CType(resources.GetObject("ImageList_FileSystem.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_FileSystem.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_FileSystem.Images.SetKeyName(0, "bb_home_.png")
        Me.ImageList_FileSystem.Images.SetKeyName(1, "gnome-fs-home-Closed_with_Bats.png")
        Me.ImageList_FileSystem.Images.SetKeyName(2, "gnome-fs-home_with_bats.png")
        Me.ImageList_FileSystem.Images.SetKeyName(3, "gnome-dev-harddisk.png")
        Me.ImageList_FileSystem.Images.SetKeyName(4, "racked.png")
        '
        'Timer_Browse
        '
        Me.Timer_Browse.Interval = 1000
        '
        'frmFolderBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 353)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFolderBrowser"
        Me.Text = "x_frmFolderBrowser"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip_Tree.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents TreeView_Folder As System.Windows.Forms.TreeView
    Friend WithEvents ImageList_FileSystem As System.Windows.Forms.ImageList
    Friend WithEvents Timer_Browse As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_Reading As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ContextMenuStrip_Tree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenExternToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
