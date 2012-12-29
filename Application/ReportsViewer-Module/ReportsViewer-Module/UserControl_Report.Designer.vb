<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Report))
        Me.ContextMenuStrip_Reports = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyGUIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XEditSemItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecodePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EqualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifferentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContainsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox_contains = New System.Windows.Forms.ToolStripTextBox()
        Me.ClearFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_Data = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Password = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.BindingNavigator_Reports = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_FilterLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Filter = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView_Reports = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_DrillDown = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_OpenLink = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_OpenFile = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_DownloadFile = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_CopyPath = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_OpenImage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_OpenMedia = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_OpenPDF = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_DecodePassword = New System.Windows.Forms.ToolStripButton()
        Me.FolderBrowserDialog_Save = New System.Windows.Forms.FolderBrowserDialog()
        Me.BindingSource_Reports = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip_Reports.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.RightToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.BindingNavigator_Reports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator_Reports.SuspendLayout()
        CType(Me.DataGridView_Reports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.BindingSource_Reports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip_Reports
        '
        Me.ContextMenuStrip_Reports.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesToolStripMenuItem, Me.EditToolStripMenuItem, Me.FilterToolStripMenuItem})
        Me.ContextMenuStrip_Reports.Name = "ContextMenuStrip_Reports"
        Me.ContextMenuStrip_Reports.Size = New System.Drawing.Size(111, 70)
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.CopyPathToolStripMenuItem})
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.FilesToolStripMenuItem.Text = "x_Files"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.OpenToolStripMenuItem.Text = "x_Open"
        '
        'CopyPathToolStripMenuItem
        '
        Me.CopyPathToolStripMenuItem.Name = "CopyPathToolStripMenuItem"
        Me.CopyPathToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.CopyPathToolStripMenuItem.Text = "x_Copy Path"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyNameToolStripMenuItem, Me.CopyGUIDToolStripMenuItem, Me.XEditSemItemToolStripMenuItem, Me.DecodePasswordToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.EditToolStripMenuItem.Text = "x_Edit"
        '
        'CopyNameToolStripMenuItem
        '
        Me.CopyNameToolStripMenuItem.Name = "CopyNameToolStripMenuItem"
        Me.CopyNameToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CopyNameToolStripMenuItem.Text = "x_Copy Name"
        '
        'CopyGUIDToolStripMenuItem
        '
        Me.CopyGUIDToolStripMenuItem.Name = "CopyGUIDToolStripMenuItem"
        Me.CopyGUIDToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CopyGUIDToolStripMenuItem.Text = "x_Copy GUID"
        '
        'XEditSemItemToolStripMenuItem
        '
        Me.XEditSemItemToolStripMenuItem.Name = "XEditSemItemToolStripMenuItem"
        Me.XEditSemItemToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.XEditSemItemToolStripMenuItem.Text = "x_Edit_SemItem"
        '
        'DecodePasswordToolStripMenuItem
        '
        Me.DecodePasswordToolStripMenuItem.Name = "DecodePasswordToolStripMenuItem"
        Me.DecodePasswordToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.DecodePasswordToolStripMenuItem.Text = "x_Decode Password (Copy)"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EqualToolStripMenuItem, Me.DifferentToolStripMenuItem, Me.ContainsToolStripMenuItem, Me.ClearFilterToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.FilterToolStripMenuItem.Text = "x_Filter"
        '
        'EqualToolStripMenuItem
        '
        Me.EqualToolStripMenuItem.Name = "EqualToolStripMenuItem"
        Me.EqualToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.EqualToolStripMenuItem.Text = "equal"
        '
        'DifferentToolStripMenuItem
        '
        Me.DifferentToolStripMenuItem.Name = "DifferentToolStripMenuItem"
        Me.DifferentToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.DifferentToolStripMenuItem.Text = "different"
        '
        'ContainsToolStripMenuItem
        '
        Me.ContainsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox_contains})
        Me.ContainsToolStripMenuItem.Name = "ContainsToolStripMenuItem"
        Me.ContainsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ContainsToolStripMenuItem.Text = "contains"
        '
        'ToolStripTextBox_contains
        '
        Me.ToolStripTextBox_contains.Name = "ToolStripTextBox_contains"
        Me.ToolStripTextBox_contains.Size = New System.Drawing.Size(100, 21)
        '
        'ClearFilterToolStripMenuItem
        '
        Me.ClearFilterToolStripMenuItem.Name = "ClearFilterToolStripMenuItem"
        Me.ClearFilterToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ClearFilterToolStripMenuItem.Text = "x_clear Filter"
        '
        'Timer_Data
        '
        Me.Timer_Data.Interval = 300
        '
        'Timer_Password
        '
        Me.Timer_Password.Interval = 30000
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.BindingNavigator_Reports)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_Reports)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(843, 493)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.RightToolStripPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.Size = New System.Drawing.Size(875, 518)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'BindingNavigator_Reports
        '
        Me.BindingNavigator_Reports.AddNewItem = Nothing
        Me.BindingNavigator_Reports.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator_Reports.DeleteItem = Nothing
        Me.BindingNavigator_Reports.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator_Reports.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel_FilterLBL, Me.ToolStripLabel_Filter})
        Me.BindingNavigator_Reports.Location = New System.Drawing.Point(0, 468)
        Me.BindingNavigator_Reports.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator_Reports.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator_Reports.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator_Reports.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator_Reports.Name = "BindingNavigator_Reports"
        Me.BindingNavigator_Reports.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator_Reports.Size = New System.Drawing.Size(843, 25)
        Me.BindingNavigator_Reports.TabIndex = 2
        Me.BindingNavigator_Reports.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_FilterLBL
        '
        Me.ToolStripLabel_FilterLBL.Name = "ToolStripLabel_FilterLBL"
        Me.ToolStripLabel_FilterLBL.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel_FilterLBL.Text = "x_Filter:"
        '
        'ToolStripLabel_Filter
        '
        Me.ToolStripLabel_Filter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel_Filter.ForeColor = System.Drawing.Color.DarkBlue
        Me.ToolStripLabel_Filter.Name = "ToolStripLabel_Filter"
        Me.ToolStripLabel_Filter.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel_Filter.Text = "-"
        '
        'DataGridView_Reports
        '
        Me.DataGridView_Reports.AllowUserToAddRows = False
        Me.DataGridView_Reports.AllowUserToDeleteRows = False
        Me.DataGridView_Reports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Reports.ContextMenuStrip = Me.ContextMenuStrip_Reports
        Me.DataGridView_Reports.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView_Reports.Name = "DataGridView_Reports"
        Me.DataGridView_Reports.ReadOnly = True
        Me.DataGridView_Reports.Size = New System.Drawing.Size(837, 462)
        Me.DataGridView_Reports.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_DrillDown, Me.ToolStripSeparator4, Me.ToolStripButton_OpenLink, Me.ToolStripSeparator2, Me.ToolStripButton_OpenFile, Me.ToolStripButton_DownloadFile, Me.ToolStripButton_CopyPath, Me.ToolStripSeparator1, Me.ToolStripButton_OpenImage, Me.ToolStripButton_OpenMedia, Me.ToolStripButton_OpenPDF, Me.ToolStripSeparator3, Me.ToolStripButton_DecodePassword})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(32, 259)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_DrillDown
        '
        Me.ToolStripButton_DrillDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_DrillDown.Enabled = False
        Me.ToolStripButton_DrillDown.Image = Global.ReportsTest.My.Resources.Resources._112_ArrowCurve_Blue_Right_32x32_72
        Me.ToolStripButton_DrillDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DrillDown.Name = "ToolStripButton_DrillDown"
        Me.ToolStripButton_DrillDown.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_DrillDown.Text = "ToolStripButton1"
        Me.ToolStripButton_DrillDown.ToolTipText = "Drill Down"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(30, 6)
        '
        'ToolStripButton_OpenLink
        '
        Me.ToolStripButton_OpenLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_OpenLink.Enabled = False
        Me.ToolStripButton_OpenLink.Image = Global.ReportsTest.My.Resources.Resources.bb_wrld_
        Me.ToolStripButton_OpenLink.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_OpenLink.Name = "ToolStripButton_OpenLink"
        Me.ToolStripButton_OpenLink.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_OpenLink.Text = "ToolStripButton1"
        Me.ToolStripButton_OpenLink.ToolTipText = "x_OpenLink"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(30, 6)
        '
        'ToolStripButton_OpenFile
        '
        Me.ToolStripButton_OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_OpenFile.Enabled = False
        Me.ToolStripButton_OpenFile.Image = Global.ReportsTest.My.Resources.Resources._1683_Lightbulb_32x32
        Me.ToolStripButton_OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_OpenFile.Name = "ToolStripButton_OpenFile"
        Me.ToolStripButton_OpenFile.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_OpenFile.Text = "ToolStripButton1"
        Me.ToolStripButton_OpenFile.ToolTipText = "Open File"
        '
        'ToolStripButton_DownloadFile
        '
        Me.ToolStripButton_DownloadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_DownloadFile.Enabled = False
        Me.ToolStripButton_DownloadFile.Image = Global.ReportsTest.My.Resources.Resources._010_LowPriority_32x32_72
        Me.ToolStripButton_DownloadFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DownloadFile.Name = "ToolStripButton_DownloadFile"
        Me.ToolStripButton_DownloadFile.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_DownloadFile.Text = "ToolStripButton3"
        Me.ToolStripButton_DownloadFile.ToolTipText = "Download File"
        '
        'ToolStripButton_CopyPath
        '
        Me.ToolStripButton_CopyPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_CopyPath.Enabled = False
        Me.ToolStripButton_CopyPath.Image = Global.ReportsTest.My.Resources.Resources.CopyHS
        Me.ToolStripButton_CopyPath.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_CopyPath.Name = "ToolStripButton_CopyPath"
        Me.ToolStripButton_CopyPath.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_CopyPath.Text = "ToolStripButton2"
        Me.ToolStripButton_CopyPath.ToolTipText = "Copy Path"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(30, 6)
        '
        'ToolStripButton_OpenImage
        '
        Me.ToolStripButton_OpenImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_OpenImage.Enabled = False
        Me.ToolStripButton_OpenImage.Image = Global.ReportsTest.My.Resources.Resources.generic_picture
        Me.ToolStripButton_OpenImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_OpenImage.Name = "ToolStripButton_OpenImage"
        Me.ToolStripButton_OpenImage.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_OpenImage.Text = "ToolStripButton1"
        '
        'ToolStripButton_OpenMedia
        '
        Me.ToolStripButton_OpenMedia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_OpenMedia.Enabled = False
        Me.ToolStripButton_OpenMedia.Image = Global.ReportsTest.My.Resources.Resources.AudioCD
        Me.ToolStripButton_OpenMedia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_OpenMedia.Name = "ToolStripButton_OpenMedia"
        Me.ToolStripButton_OpenMedia.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_OpenMedia.Text = "ToolStripButton2"
        '
        'ToolStripButton_OpenPDF
        '
        Me.ToolStripButton_OpenPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_OpenPDF.Enabled = False
        Me.ToolStripButton_OpenPDF.Image = Global.ReportsTest.My.Resources.Resources.pdf_preview
        Me.ToolStripButton_OpenPDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_OpenPDF.Name = "ToolStripButton_OpenPDF"
        Me.ToolStripButton_OpenPDF.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_OpenPDF.Text = "ToolStripButton3"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(30, 6)
        '
        'ToolStripButton_DecodePassword
        '
        Me.ToolStripButton_DecodePassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_DecodePassword.Enabled = False
        Me.ToolStripButton_DecodePassword.Image = Global.ReportsTest.My.Resources.Resources.Key
        Me.ToolStripButton_DecodePassword.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DecodePassword.Name = "ToolStripButton_DecodePassword"
        Me.ToolStripButton_DecodePassword.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_DecodePassword.Text = "ToolStripButton1"
        '
        'UserControl_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_Report"
        Me.Size = New System.Drawing.Size(875, 518)
        Me.ContextMenuStrip_Reports.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.RightToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.RightToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.BindingNavigator_Reports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator_Reports.ResumeLayout(False)
        Me.BindingNavigator_Reports.PerformLayout()
        CType(Me.DataGridView_Reports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.BindingSource_Reports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource_Reports As System.Windows.Forms.BindingSource
    Friend WithEvents Timer_Data As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip_Reports As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyGUIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XEditSemItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecodePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_Password As System.Windows.Forms.Timer
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EqualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DifferentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContainsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox_contains As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ClearFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents BindingNavigator_Reports As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_FilterLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Filter As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_Reports As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_OpenFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_DownloadFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_CopyPath As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_DrillDown As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_OpenMedia As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_OpenImage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_OpenPDF As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_DecodePassword As System.Windows.Forms.ToolStripButton
    Friend WithEvents FolderBrowserDialog_Save As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_OpenLink As System.Windows.Forms.ToolStripButton

End Class
