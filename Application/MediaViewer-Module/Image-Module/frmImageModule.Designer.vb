<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImageModule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImageModule))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_Items = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_ItemCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_LastRelationLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_LastRelation = New System.Windows.Forms.ToolStripLabel()
        Me.TreeView_RelatedItems = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_Item = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeParentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveFromTreeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_RelatedItems = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripComboBox_SearchTemplate = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripTextBox_Filter = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_Filter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_MediaType = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox_MediaType = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSplitButton_OrderType = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItem_Semantic = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Chrono = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_ChronoSemantic = New System.Windows.Forms.ToolStripMenuItem()
        Me.NamedSemanticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton_OpenGrid = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Meta = New System.Windows.Forms.ToolStripButton()
        Me.FolderBrowserDialog_Export = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Filter = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer2.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ContextMenuStrip_Item.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(821, 371)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(821, 421)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip3)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Close})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(62, 25)
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
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStripContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(821, 371)
        Me.SplitContainer1.SplitterDistance = 528
        Me.SplitContainer1.TabIndex = 0
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
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.TreeView_RelatedItems)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(524, 317)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(524, 367)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip4)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Items, Me.ToolStripLabel_ItemCount, Me.ToolStripSeparator2, Me.ToolStripLabel_LastRelationLBL, Me.ToolStripLabel_LastRelation})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(181, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_Items
        '
        Me.ToolStripLabel_Items.Name = "ToolStripLabel_Items"
        Me.ToolStripLabel_Items.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel_Items.Text = "x_Items:"
        '
        'ToolStripLabel_ItemCount
        '
        Me.ToolStripLabel_ItemCount.Name = "ToolStripLabel_ItemCount"
        Me.ToolStripLabel_ItemCount.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_ItemCount.Text = "0"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_LastRelationLBL
        '
        Me.ToolStripLabel_LastRelationLBL.Name = "ToolStripLabel_LastRelationLBL"
        Me.ToolStripLabel_LastRelationLBL.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripLabel_LastRelationLBL.Text = "x_Last-Relation:"
        '
        'ToolStripLabel_LastRelation
        '
        Me.ToolStripLabel_LastRelation.Name = "ToolStripLabel_LastRelation"
        Me.ToolStripLabel_LastRelation.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel_LastRelation.Text = "/"
        '
        'TreeView_RelatedItems
        '
        Me.TreeView_RelatedItems.ContextMenuStrip = Me.ContextMenuStrip_Item
        Me.TreeView_RelatedItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_RelatedItems.ImageIndex = 0
        Me.TreeView_RelatedItems.ImageList = Me.ImageList_RelatedItems
        Me.TreeView_RelatedItems.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_RelatedItems.Name = "TreeView_RelatedItems"
        Me.TreeView_RelatedItems.SelectedImageIndex = 0
        Me.TreeView_RelatedItems.Size = New System.Drawing.Size(524, 317)
        Me.TreeView_RelatedItems.TabIndex = 0
        '
        'ContextMenuStrip_Item
        '
        Me.ContextMenuStrip_Item.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.RelateToolStripMenuItem, Me.ChangeParentToolStripMenuItem, Me.RemoveFromTreeToolStripMenuItem})
        Me.ContextMenuStrip_Item.Name = "ContextMenuStrip_Item"
        Me.ContextMenuStrip_Item.Size = New System.Drawing.Size(183, 114)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NewToolStripMenuItem.Text = "x_New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SaveToolStripMenuItem.Text = "x_Save"
        '
        'RelateToolStripMenuItem
        '
        Me.RelateToolStripMenuItem.Enabled = False
        Me.RelateToolStripMenuItem.Name = "RelateToolStripMenuItem"
        Me.RelateToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RelateToolStripMenuItem.Text = "x_Relate"
        '
        'ChangeParentToolStripMenuItem
        '
        Me.ChangeParentToolStripMenuItem.Name = "ChangeParentToolStripMenuItem"
        Me.ChangeParentToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ChangeParentToolStripMenuItem.Text = "x_Change Parent"
        '
        'RemoveFromTreeToolStripMenuItem
        '
        Me.RemoveFromTreeToolStripMenuItem.Name = "RemoveFromTreeToolStripMenuItem"
        Me.RemoveFromTreeToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RemoveFromTreeToolStripMenuItem.Text = "x_Remove from Tree"
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
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_SearchTemplate, Me.ToolStripTextBox_Filter, Me.ToolStripButton_Filter})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(432, 25)
        Me.ToolStrip4.TabIndex = 0
        '
        'ToolStripComboBox_SearchTemplate
        '
        Me.ToolStripComboBox_SearchTemplate.Name = "ToolStripComboBox_SearchTemplate"
        Me.ToolStripComboBox_SearchTemplate.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripTextBox_Filter
        '
        Me.ToolStripTextBox_Filter.Name = "ToolStripTextBox_Filter"
        Me.ToolStripTextBox_Filter.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripButton_Filter
        '
        Me.ToolStripButton_Filter.Checked = True
        Me.ToolStripButton_Filter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton_Filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Filter.Image = CType(resources.GetObject("ToolStripButton_Filter.Image"), System.Drawing.Image)
        Me.ToolStripButton_Filter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Filter.Name = "ToolStripButton_Filter"
        Me.ToolStripButton_Filter.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripButton_Filter.Text = "x_filter"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_MediaType, Me.ToolStripComboBox_MediaType, Me.ToolStripSplitButton_OrderType, Me.ToolStripButton_OpenGrid, Me.ToolStripSeparator1, Me.ToolStripButton_Meta})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(604, 25)
        Me.ToolStrip3.TabIndex = 0
        '
        'ToolStripLabel_MediaType
        '
        Me.ToolStripLabel_MediaType.Name = "ToolStripLabel_MediaType"
        Me.ToolStripLabel_MediaType.Size = New System.Drawing.Size(79, 22)
        Me.ToolStripLabel_MediaType.Text = "x_MediaType:"
        '
        'ToolStripComboBox_MediaType
        '
        Me.ToolStripComboBox_MediaType.Name = "ToolStripComboBox_MediaType"
        Me.ToolStripComboBox_MediaType.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripSplitButton_OrderType
        '
        Me.ToolStripSplitButton_OrderType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton_OrderType.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Semantic, Me.ToolStripMenuItem_Chrono, Me.ToolStripMenuItem_ChronoSemantic, Me.NamedSemanticsToolStripMenuItem})
        Me.ToolStripSplitButton_OrderType.Image = CType(resources.GetObject("ToolStripSplitButton_OrderType.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton_OrderType.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton_OrderType.Name = "ToolStripSplitButton_OrderType"
        Me.ToolStripSplitButton_OrderType.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripSplitButton_OrderType.Text = "x_Order-Type"
        '
        'ToolStripMenuItem_Semantic
        '
        Me.ToolStripMenuItem_Semantic.Checked = True
        Me.ToolStripMenuItem_Semantic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem_Semantic.Name = "ToolStripMenuItem_Semantic"
        Me.ToolStripMenuItem_Semantic.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem_Semantic.Text = "x_semantic"
        '
        'ToolStripMenuItem_Chrono
        '
        Me.ToolStripMenuItem_Chrono.Name = "ToolStripMenuItem_Chrono"
        Me.ToolStripMenuItem_Chrono.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem_Chrono.Text = "x_Chrono"
        '
        'ToolStripMenuItem_ChronoSemantic
        '
        Me.ToolStripMenuItem_ChronoSemantic.Name = "ToolStripMenuItem_ChronoSemantic"
        Me.ToolStripMenuItem_ChronoSemantic.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem_ChronoSemantic.Text = "x_Chrono-Semantic"
        '
        'NamedSemanticsToolStripMenuItem
        '
        Me.NamedSemanticsToolStripMenuItem.CheckOnClick = True
        Me.NamedSemanticsToolStripMenuItem.Name = "NamedSemanticsToolStripMenuItem"
        Me.NamedSemanticsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NamedSemanticsToolStripMenuItem.Text = "x_Named-Semantics"
        '
        'ToolStripButton_OpenGrid
        '
        Me.ToolStripButton_OpenGrid.CheckOnClick = True
        Me.ToolStripButton_OpenGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_OpenGrid.Image = CType(resources.GetObject("ToolStripButton_OpenGrid.Image"), System.Drawing.Image)
        Me.ToolStripButton_OpenGrid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_OpenGrid.Name = "ToolStripButton_OpenGrid"
        Me.ToolStripButton_OpenGrid.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButton_OpenGrid.Text = "x_Open Grid"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Meta
        '
        Me.ToolStripButton_Meta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Meta.Enabled = False
        Me.ToolStripButton_Meta.Image = CType(resources.GetObject("ToolStripButton_Meta.Image"), System.Drawing.Image)
        Me.ToolStripButton_Meta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Meta.Name = "ToolStripButton_Meta"
        Me.ToolStripButton_Meta.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripButton_Meta.Text = "x_Get Metadat"
        '
        'Timer_Filter
        '
        Me.Timer_Filter.Interval = 300
        '
        'frmImageModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 421)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImageModule"
        Me.Text = "x_Media-Viewer Module"
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
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ContextMenuStrip_Item.ResumeLayout(False)
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Items As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_ItemCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TreeView_RelatedItems As System.Windows.Forms.TreeView
    Friend WithEvents ImageList_RelatedItems As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip_Item As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog_Export As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_MediaType As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripComboBox_MediaType As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripComboBox_SearchTemplate As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripTextBox_Filter As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer_Filter As System.Windows.Forms.Timer
    Friend WithEvents ToolStripButton_Filter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_OpenGrid As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Meta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton_OrderType As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem_Semantic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Chrono As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_ChronoSemantic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_LastRelationLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_LastRelation As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NamedSemanticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeParentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveFromTreeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
