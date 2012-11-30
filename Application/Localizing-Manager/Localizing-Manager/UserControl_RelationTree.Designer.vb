<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_RelationTree
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_RelationTree))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_LocalizedItems = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Count_RelatedItems = New System.Windows.Forms.ToolStripLabel()
        Me.TreeView_RelatedItems = New System.Windows.Forms.TreeView()
        Me.ImageList_RelatedItems = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip_Related = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip_Related.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TreeView_RelatedItems)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(343, 331)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(343, 381)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_LocalizedItems, Me.ToolStripLabel_Count_RelatedItems})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(207, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_LocalizedItems
        '
        Me.ToolStripLabel_LocalizedItems.Name = "ToolStripLabel_LocalizedItems"
        Me.ToolStripLabel_LocalizedItems.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripLabel_LocalizedItems.Text = "x_Localized-Items::"
        '
        'ToolStripLabel_Count_RelatedItems
        '
        Me.ToolStripLabel_Count_RelatedItems.Name = "ToolStripLabel_Count_RelatedItems"
        Me.ToolStripLabel_Count_RelatedItems.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripLabel_Count_RelatedItems.Text = "ToolStripLabel1"
        '
        'TreeView_RelatedItems
        '
        Me.TreeView_RelatedItems.ContextMenuStrip = Me.ContextMenuStrip_Related
        Me.TreeView_RelatedItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_RelatedItems.ImageIndex = 0
        Me.TreeView_RelatedItems.ImageList = Me.ImageList_RelatedItems
        Me.TreeView_RelatedItems.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_RelatedItems.Name = "TreeView_RelatedItems"
        Me.TreeView_RelatedItems.SelectedImageIndex = 0
        Me.TreeView_RelatedItems.Size = New System.Drawing.Size(343, 331)
        Me.TreeView_RelatedItems.TabIndex = 0
        '
        'ImageList_RelatedItems
        '
        Me.ImageList_RelatedItems.ImageStream = CType(resources.GetObject("ImageList_RelatedItems.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_RelatedItems.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_RelatedItems.Images.SetKeyName(0, "bb_home_.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(1, "Types_Closed.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(2, "Types_Closed SubItems.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(3, "Types_Closed Images.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(4, "Types_Closed SubItems Image.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(5, "Types_Opened.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(6, "Types_Opened SubItems.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(7, "Types_Opened Image.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(8, "Types_Opened SubItems Image.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(9, "Attributes bamboo_danny_allen_r.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(10, "RelationTypes gpride_jean_victor_balin_.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(11, "Vogelschwarm klein.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(12, "Attributes bamboo_danny_allen_r.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(13, "RelationTypes gpride_jean_victor_balin_.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(14, "Vogelschwarm%20klein.ico")
        Me.ImageList_RelatedItems.Images.SetKeyName(15, "Types_Closed.png")
        Me.ImageList_RelatedItems.Images.SetKeyName(16, "Types_Opened.png")
        '
        'ContextMenuStrip_Related
        '
        Me.ContextMenuStrip_Related.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.ContextMenuStrip_Related.Name = "ContextMenuStrip_Related"
        Me.ContextMenuStrip_Related.Size = New System.Drawing.Size(153, 48)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "x_New"
        '
        'UserControl_RelationTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_RelationTree"
        Me.Size = New System.Drawing.Size(343, 381)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip_Related.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_LocalizedItems As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TreeView_RelatedItems As System.Windows.Forms.TreeView
    Friend WithEvents ImageList_RelatedItems As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripLabel_Count_RelatedItems As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ContextMenuStrip_Related As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
