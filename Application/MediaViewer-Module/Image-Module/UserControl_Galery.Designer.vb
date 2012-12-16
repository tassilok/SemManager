<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Galery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Galery))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ContextMenuStrip_Navigation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox_Goto = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_MoveFirst = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MovePrevious = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MoveNext = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MoveLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_ItemCountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_ItemCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_SizeLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_size = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_NameLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Name = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.HScrollBar_Picture = New System.Windows.Forms.HScrollBar()
        Me.VScrollBar_Picture = New System.Windows.Forms.VScrollBar()
        Me.PictureBox_Image = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip_Relate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RelateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelateAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_LoadImage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Copy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Paste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Replace = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton_Scale = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItem_Stretch = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Original = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Zoom = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Relate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_OpenEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Meta = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog_Image = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip_ImageInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveImagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog_Save = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ContextMenuStrip_Navigation.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_Relate.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(559, 427)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(559, 477)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ContextMenuStrip = Me.ContextMenuStrip_Navigation
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_MoveFirst, Me.ToolStripButton_MovePrevious, Me.ToolStripButton_MoveNext, Me.ToolStripButton_MoveLast, Me.ToolStripSeparator1, Me.ToolStripButton_Delete, Me.ToolStripSeparator3, Me.ToolStripLabel_ItemCountLBL, Me.ToolStripLabel_ItemCount, Me.ToolStripSeparator5, Me.ToolStripLabel_SizeLBL, Me.ToolStripLabel_size, Me.ToolStripSeparator6, Me.ToolStripLabel_NameLBL, Me.ToolStripLabel_Name})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(428, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ContextMenuStrip_Navigation
        '
        Me.ContextMenuStrip_Navigation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GotoToolStripMenuItem})
        Me.ContextMenuStrip_Navigation.Name = "ContextMenuStrip_Navigation"
        Me.ContextMenuStrip_Navigation.Size = New System.Drawing.Size(110, 26)
        '
        'GotoToolStripMenuItem
        '
        Me.GotoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox_Goto})
        Me.GotoToolStripMenuItem.Name = "GotoToolStripMenuItem"
        Me.GotoToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.GotoToolStripMenuItem.Text = "x_Goto"
        '
        'ToolStripTextBox_Goto
        '
        Me.ToolStripTextBox_Goto.Name = "ToolStripTextBox_Goto"
        Me.ToolStripTextBox_Goto.Size = New System.Drawing.Size(100, 21)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Delete
        '
        Me.ToolStripButton_Delete.Enabled = False
        Me.ToolStripButton_Delete.Image = Global.MediaViewer_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
        Me.ToolStripButton_Delete.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripButton_Delete.Text = "x_Delete Image"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_ItemCountLBL
        '
        Me.ToolStripLabel_ItemCountLBL.Name = "ToolStripLabel_ItemCountLBL"
        Me.ToolStripLabel_ItemCountLBL.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel_ItemCountLBL.Text = "x_Items:"
        '
        'ToolStripLabel_ItemCount
        '
        Me.ToolStripLabel_ItemCount.Name = "ToolStripLabel_ItemCount"
        Me.ToolStripLabel_ItemCount.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripLabel_ItemCount.Text = "0/0"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_SizeLBL
        '
        Me.ToolStripLabel_SizeLBL.Name = "ToolStripLabel_SizeLBL"
        Me.ToolStripLabel_SizeLBL.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel_SizeLBL.Text = "x_Size:"
        '
        'ToolStripLabel_size
        '
        Me.ToolStripLabel_size.Name = "ToolStripLabel_size"
        Me.ToolStripLabel_size.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripLabel_size.Text = "0/0"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_NameLBL
        '
        Me.ToolStripLabel_NameLBL.Name = "ToolStripLabel_NameLBL"
        Me.ToolStripLabel_NameLBL.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel_NameLBL.Text = "x_Name:"
        '
        'ToolStripLabel_Name
        '
        Me.ToolStripLabel_Name.Name = "ToolStripLabel_Name"
        Me.ToolStripLabel_Name.Size = New System.Drawing.Size(11, 22)
        Me.ToolStripLabel_Name.Text = "-"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(559, 427)
        Me.SplitContainer1.SplitterDistance = 357
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.HScrollBar_Picture, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.VScrollBar_Picture, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox_Image, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(353, 423)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'HScrollBar_Picture
        '
        Me.HScrollBar_Picture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HScrollBar_Picture.Location = New System.Drawing.Point(0, 403)
        Me.HScrollBar_Picture.Name = "HScrollBar_Picture"
        Me.HScrollBar_Picture.Size = New System.Drawing.Size(333, 20)
        Me.HScrollBar_Picture.TabIndex = 0
        '
        'VScrollBar_Picture
        '
        Me.VScrollBar_Picture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VScrollBar_Picture.Location = New System.Drawing.Point(333, 0)
        Me.VScrollBar_Picture.Name = "VScrollBar_Picture"
        Me.VScrollBar_Picture.Size = New System.Drawing.Size(20, 403)
        Me.VScrollBar_Picture.TabIndex = 1
        '
        'PictureBox_Image
        '
        Me.PictureBox_Image.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Image.ContextMenuStrip = Me.ContextMenuStrip_Relate
        Me.PictureBox_Image.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox_Image.Name = "PictureBox_Image"
        Me.PictureBox_Image.Size = New System.Drawing.Size(327, 397)
        Me.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_Image.TabIndex = 2
        Me.PictureBox_Image.TabStop = False
        '
        'ContextMenuStrip_Relate
        '
        Me.ContextMenuStrip_Relate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelateToolStripMenuItem, Me.RelateAllToolStripMenuItem, Me.SaveImagesToolStripMenuItem})
        Me.ContextMenuStrip_Relate.Name = "ContextMenuStrip_Relate"
        Me.ContextMenuStrip_Relate.Size = New System.Drawing.Size(149, 70)
        '
        'RelateToolStripMenuItem
        '
        Me.RelateToolStripMenuItem.Enabled = False
        Me.RelateToolStripMenuItem.Name = "RelateToolStripMenuItem"
        Me.RelateToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.RelateToolStripMenuItem.Text = "x_Relate"
        '
        'RelateAllToolStripMenuItem
        '
        Me.RelateAllToolStripMenuItem.Enabled = False
        Me.RelateAllToolStripMenuItem.Name = "RelateAllToolStripMenuItem"
        Me.RelateAllToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.RelateAllToolStripMenuItem.Text = "x_Relate all"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_LoadImage, Me.ToolStripButton_Copy, Me.ToolStripButton_Paste, Me.ToolStripSeparator2, Me.ToolStripButton_Replace, Me.ToolStripSeparator4, Me.ToolStripSplitButton_Scale, Me.ToolStripSeparator7, Me.ToolStripButton_Relate, Me.ToolStripButton_OpenEdit, Me.ToolStripButton_Meta})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(401, 25)
        Me.ToolStrip1.TabIndex = 0
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
        'ToolStripButton_Replace
        '
        Me.ToolStripButton_Replace.CheckOnClick = True
        Me.ToolStripButton_Replace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Replace.Image = CType(resources.GetObject("ToolStripButton_Replace.Image"), System.Drawing.Image)
        Me.ToolStripButton_Replace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Replace.Name = "ToolStripButton_Replace"
        Me.ToolStripButton_Replace.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripButton_Replace.Text = "x_Replace"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSplitButton_Scale
        '
        Me.ToolStripSplitButton_Scale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton_Scale.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Stretch, Me.ToolStripMenuItem_Original, Me.ToolStripMenuItem_Zoom})
        Me.ToolStripSplitButton_Scale.Image = CType(resources.GetObject("ToolStripSplitButton_Scale.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton_Scale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton_Scale.Name = "ToolStripSplitButton_Scale"
        Me.ToolStripSplitButton_Scale.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripSplitButton_Scale.Text = "x_Scale"
        '
        'ToolStripMenuItem_Stretch
        '
        Me.ToolStripMenuItem_Stretch.Name = "ToolStripMenuItem_Stretch"
        Me.ToolStripMenuItem_Stretch.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripMenuItem_Stretch.Text = "x_Stretch"
        '
        'ToolStripMenuItem_Original
        '
        Me.ToolStripMenuItem_Original.Name = "ToolStripMenuItem_Original"
        Me.ToolStripMenuItem_Original.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripMenuItem_Original.Text = "x_Original"
        '
        'ToolStripMenuItem_Zoom
        '
        Me.ToolStripMenuItem_Zoom.Checked = True
        Me.ToolStripMenuItem_Zoom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem_Zoom.Name = "ToolStripMenuItem_Zoom"
        Me.ToolStripMenuItem_Zoom.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripMenuItem_Zoom.Text = "x_Zoom"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Relate
        '
        Me.ToolStripButton_Relate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Relate.Image = CType(resources.GetObject("ToolStripButton_Relate.Image"), System.Drawing.Image)
        Me.ToolStripButton_Relate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Relate.Name = "ToolStripButton_Relate"
        Me.ToolStripButton_Relate.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripButton_Relate.Text = "x_Relate"
        '
        'ToolStripButton_OpenEdit
        '
        Me.ToolStripButton_OpenEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_OpenEdit.Image = CType(resources.GetObject("ToolStripButton_OpenEdit.Image"), System.Drawing.Image)
        Me.ToolStripButton_OpenEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_OpenEdit.Name = "ToolStripButton_OpenEdit"
        Me.ToolStripButton_OpenEdit.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripButton_OpenEdit.Text = "x_Edit"
        '
        'ToolStripButton_Meta
        '
        Me.ToolStripButton_Meta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Meta.Image = CType(resources.GetObject("ToolStripButton_Meta.Image"), System.Drawing.Image)
        Me.ToolStripButton_Meta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Meta.Name = "ToolStripButton_Meta"
        Me.ToolStripButton_Meta.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripButton_Meta.Text = "x_get Metadata"
        '
        'OpenFileDialog_Image
        '
        Me.OpenFileDialog_Image.FileName = "Image-Browser"
        Me.OpenFileDialog_Image.Filter = "Alle Dateien|*.*"
        Me.OpenFileDialog_Image.Multiselect = True
        '
        'SaveImagesToolStripMenuItem
        '
        Me.SaveImagesToolStripMenuItem.Enabled = False
        Me.SaveImagesToolStripMenuItem.Name = "SaveImagesToolStripMenuItem"
        Me.SaveImagesToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SaveImagesToolStripMenuItem.Text = "x_Save Images"
        '
        'UserControl_Galery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_Galery"
        Me.Size = New System.Drawing.Size(559, 477)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ContextMenuStrip_Navigation.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_Relate.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_MoveFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MovePrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MoveNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MoveLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_LoadImage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Copy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Paste As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents HScrollBar_Picture As System.Windows.Forms.HScrollBar
    Friend WithEvents VScrollBar_Picture As System.Windows.Forms.VScrollBar
    Friend WithEvents PictureBox_Image As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Replace As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog_Image As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_SizeLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_size As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_ItemCountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_ItemCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_NameLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Name As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton_Relate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_OpenEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip_ImageInfo As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripButton_Meta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip_Relate As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RelateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelateAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_Navigation As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox_Goto As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSplitButton_Scale As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem_Stretch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Original As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Zoom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveImagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog_Save As System.Windows.Forms.FolderBrowserDialog

End Class
