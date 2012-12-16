<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Trinken
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Trinken))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_Edit = New System.Windows.Forms.Panel()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.Button_Del = New System.Windows.Forms.Button()
        Me.Button_New = New System.Windows.Forms.Button()
        Me.CheckBox_Eigeninitiative = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Spucken = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker_Zeitpunkt = New System.Windows.Forms.DateTimePicker()
        Me.Label_Zeitpunkt = New System.Windows.Forms.Label()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_Count_TrinkenLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Count_Trinken = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_Filter = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton_ClearFilter = New System.Windows.Forms.ToolStripButton()
        Me.Label_Trinkmessungen = New System.Windows.Forms.Label()
        Me.DataGridView_Trinken = New System.Windows.Forms.DataGridView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label_Bestandteile = New System.Windows.Forms.Label()
        Me.DataGridView_Bestandteil = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_Bestandteile = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddBestandteilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveBestandteilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBestandteilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_ToDay = New System.Windows.Forms.TabPage()
        Me.ProgressBar_Mengen = New System.Windows.Forms.ProgressBar()
        Me.DataGridView_Tagesmengen = New System.Windows.Forms.DataGridView()
        Me.Label_Bestandteile_Tag = New System.Windows.Forms.Label()
        Me.TabPage_Days = New System.Windows.Forms.TabPage()
        Me.DataGridView_Dayly = New System.Windows.Forms.DataGridView()
        Me.TabPage_Weeks = New System.Windows.Forms.TabPage()
        Me.DataGridView_Weeks = New System.Windows.Forms.DataGridView()
        Me.ToolTip_State = New System.Windows.Forms.ToolTip(Me.components)
        Me.BindingSource_Trinken = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_Bestandteil = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_Tagesmengen = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer_Tagesmengen = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_Days = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_Weeks = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel_Edit.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_Trinken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView_Bestandteil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_Bestandteile.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_ToDay.SuspendLayout()
        CType(Me.DataGridView_Tagesmengen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Days.SuspendLayout()
        CType(Me.DataGridView_Dayly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Weeks.SuspendLayout()
        CType(Me.DataGridView_Weeks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Trinken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Bestandteil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Tagesmengen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Days, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Weeks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_Edit, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStripContainer1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(702, 493)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel_Edit
        '
        Me.Panel_Edit.Controls.Add(Me.Button_Save)
        Me.Panel_Edit.Controls.Add(Me.Button_Del)
        Me.Panel_Edit.Controls.Add(Me.Button_New)
        Me.Panel_Edit.Controls.Add(Me.CheckBox_Eigeninitiative)
        Me.Panel_Edit.Controls.Add(Me.CheckBox_Spucken)
        Me.Panel_Edit.Controls.Add(Me.DateTimePicker_Zeitpunkt)
        Me.Panel_Edit.Controls.Add(Me.Label_Zeitpunkt)
        Me.Panel_Edit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Edit.Location = New System.Drawing.Point(3, 3)
        Me.Panel_Edit.Name = "Panel_Edit"
        Me.Panel_Edit.Size = New System.Drawing.Size(696, 29)
        Me.Panel_Edit.TabIndex = 0
        '
        'Button_Save
        '
        Me.Button_Save.ImageIndex = 0
        Me.Button_Save.ImageList = Me.ImageList_Main
        Me.Button_Save.Location = New System.Drawing.Point(410, 1)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(30, 24)
        Me.Button_Save.TabIndex = 14
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ImageStream = CType(resources.GetObject("ImageList_Main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Main.Images.SetKeyName(0, "base_floppydisk_32.png")
        Me.ImageList_Main.Images.SetKeyName(1, "NewDocument_32x32.png")
        Me.ImageList_Main.Images.SetKeyName(2, "tasto_8_architetto_franc_01.png")
        '
        'Button_Del
        '
        Me.Button_Del.Enabled = False
        Me.Button_Del.ImageIndex = 2
        Me.Button_Del.ImageList = Me.ImageList_Main
        Me.Button_Del.Location = New System.Drawing.Point(486, 2)
        Me.Button_Del.Name = "Button_Del"
        Me.Button_Del.Size = New System.Drawing.Size(30, 24)
        Me.Button_Del.TabIndex = 13
        Me.Button_Del.UseVisualStyleBackColor = True
        '
        'Button_New
        '
        Me.Button_New.ImageIndex = 1
        Me.Button_New.ImageList = Me.ImageList_Main
        Me.Button_New.Location = New System.Drawing.Point(456, 1)
        Me.Button_New.Name = "Button_New"
        Me.Button_New.Size = New System.Drawing.Size(31, 24)
        Me.Button_New.TabIndex = 12
        Me.Button_New.UseVisualStyleBackColor = True
        '
        'CheckBox_Eigeninitiative
        '
        Me.CheckBox_Eigeninitiative.AutoSize = True
        Me.CheckBox_Eigeninitiative.Checked = True
        Me.CheckBox_Eigeninitiative.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Eigeninitiative.Location = New System.Drawing.Point(302, 3)
        Me.CheckBox_Eigeninitiative.Name = "CheckBox_Eigeninitiative"
        Me.CheckBox_Eigeninitiative.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox_Eigeninitiative.TabIndex = 5
        Me.CheckBox_Eigeninitiative.Text = "x_Eigeninitiative"
        Me.CheckBox_Eigeninitiative.UseVisualStyleBackColor = True
        '
        'CheckBox_Spucken
        '
        Me.CheckBox_Spucken.AutoSize = True
        Me.CheckBox_Spucken.Location = New System.Drawing.Point(215, 3)
        Me.CheckBox_Spucken.Name = "CheckBox_Spucken"
        Me.CheckBox_Spucken.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_Spucken.TabIndex = 4
        Me.CheckBox_Spucken.Text = "x_gespuckt"
        Me.CheckBox_Spucken.UseVisualStyleBackColor = True
        '
        'DateTimePicker_Zeitpunkt
        '
        Me.DateTimePicker_Zeitpunkt.CustomFormat = "dd.MM.yyy HH.mm.ss"
        Me.DateTimePicker_Zeitpunkt.Enabled = False
        Me.DateTimePicker_Zeitpunkt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Zeitpunkt.Location = New System.Drawing.Point(69, 0)
        Me.DateTimePicker_Zeitpunkt.Name = "DateTimePicker_Zeitpunkt"
        Me.DateTimePicker_Zeitpunkt.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker_Zeitpunkt.TabIndex = 3
        '
        'Label_Zeitpunkt
        '
        Me.Label_Zeitpunkt.AutoSize = True
        Me.Label_Zeitpunkt.Location = New System.Drawing.Point(3, 0)
        Me.Label_Zeitpunkt.Name = "Label_Zeitpunkt"
        Me.Label_Zeitpunkt.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.Label_Zeitpunkt.Size = New System.Drawing.Size(66, 17)
        Me.Label_Zeitpunkt.TabIndex = 2
        Me.Label_Zeitpunkt.Text = "x_Zeitpunkt:"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(696, 452)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(3, 38)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(696, 452)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_Trinkmessungen)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView_Trinken)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(696, 452)
        Me.SplitContainer1.SplitterDistance = 315
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Count_TrinkenLBL, Me.ToolStripLabel_Count_Trinken, Me.ToolStripSeparator1, Me.ToolStripLabel_Filter, Me.ToolStripButton_ClearFilter})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 286)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(692, 25)
        Me.ToolStrip1.TabIndex = 3
        '
        'ToolStripLabel_Count_TrinkenLBL
        '
        Me.ToolStripLabel_Count_TrinkenLBL.Name = "ToolStripLabel_Count_TrinkenLBL"
        Me.ToolStripLabel_Count_TrinkenLBL.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel_Count_TrinkenLBL.Text = "x_Count:"
        '
        'ToolStripLabel_Count_Trinken
        '
        Me.ToolStripLabel_Count_Trinken.Name = "ToolStripLabel_Count_Trinken"
        Me.ToolStripLabel_Count_Trinken.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Count_Trinken.Text = "0"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_Filter
        '
        Me.ToolStripLabel_Filter.Enabled = False
        Me.ToolStripLabel_Filter.Name = "ToolStripLabel_Filter"
        Me.ToolStripLabel_Filter.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripLabel_Filter.Text = "x_Filter"
        '
        'ToolStripButton_ClearFilter
        '
        Me.ToolStripButton_ClearFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_ClearFilter.Enabled = False
        Me.ToolStripButton_ClearFilter.Image = CType(resources.GetObject("ToolStripButton_ClearFilter.Image"), System.Drawing.Image)
        Me.ToolStripButton_ClearFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ClearFilter.Name = "ToolStripButton_ClearFilter"
        Me.ToolStripButton_ClearFilter.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripButton_ClearFilter.Text = "x_Clear Filter"
        '
        'Label_Trinkmessungen
        '
        Me.Label_Trinkmessungen.AutoSize = True
        Me.Label_Trinkmessungen.Location = New System.Drawing.Point(1, 3)
        Me.Label_Trinkmessungen.Name = "Label_Trinkmessungen"
        Me.Label_Trinkmessungen.Size = New System.Drawing.Size(99, 13)
        Me.Label_Trinkmessungen.TabIndex = 2
        Me.Label_Trinkmessungen.Text = "x_Trinkmessungen:"
        '
        'DataGridView_Trinken
        '
        Me.DataGridView_Trinken.AllowUserToAddRows = False
        Me.DataGridView_Trinken.AllowUserToDeleteRows = False
        Me.DataGridView_Trinken.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Trinken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Trinken.Location = New System.Drawing.Point(1, 24)
        Me.DataGridView_Trinken.Name = "DataGridView_Trinken"
        Me.DataGridView_Trinken.ReadOnly = True
        Me.DataGridView_Trinken.Size = New System.Drawing.Size(690, 259)
        Me.DataGridView_Trinken.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label_Bestandteile)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DataGridView_Bestandteil)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(696, 133)
        Me.SplitContainer2.SplitterDistance = 343
        Me.SplitContainer2.TabIndex = 0
        '
        'Label_Bestandteile
        '
        Me.Label_Bestandteile.AutoSize = True
        Me.Label_Bestandteile.Location = New System.Drawing.Point(2, 4)
        Me.Label_Bestandteile.Name = "Label_Bestandteile"
        Me.Label_Bestandteile.Size = New System.Drawing.Size(79, 13)
        Me.Label_Bestandteile.TabIndex = 6
        Me.Label_Bestandteile.Text = "x_Bestandteile:"
        '
        'DataGridView_Bestandteil
        '
        Me.DataGridView_Bestandteil.AllowUserToAddRows = False
        Me.DataGridView_Bestandteil.AllowUserToDeleteRows = False
        Me.DataGridView_Bestandteil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Bestandteil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Bestandteil.ContextMenuStrip = Me.ContextMenuStrip_Bestandteile
        Me.DataGridView_Bestandteil.Location = New System.Drawing.Point(-1, 20)
        Me.DataGridView_Bestandteil.Name = "DataGridView_Bestandteil"
        Me.DataGridView_Bestandteil.ReadOnly = True
        Me.DataGridView_Bestandteil.Size = New System.Drawing.Size(337, 106)
        Me.DataGridView_Bestandteil.TabIndex = 5
        '
        'ContextMenuStrip_Bestandteile
        '
        Me.ContextMenuStrip_Bestandteile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBestandteilToolStripMenuItem, Me.RemoveBestandteilToolStripMenuItem, Me.ChangeBestandteilToolStripMenuItem})
        Me.ContextMenuStrip_Bestandteile.Name = "ContextMenuStrip_Bestandteile"
        Me.ContextMenuStrip_Bestandteile.Size = New System.Drawing.Size(128, 70)
        '
        'AddBestandteilToolStripMenuItem
        '
        Me.AddBestandteilToolStripMenuItem.Name = "AddBestandteilToolStripMenuItem"
        Me.AddBestandteilToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AddBestandteilToolStripMenuItem.Text = "x_Add"
        '
        'RemoveBestandteilToolStripMenuItem
        '
        Me.RemoveBestandteilToolStripMenuItem.Name = "RemoveBestandteilToolStripMenuItem"
        Me.RemoveBestandteilToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.RemoveBestandteilToolStripMenuItem.Text = "x_Remove"
        '
        'ChangeBestandteilToolStripMenuItem
        '
        Me.ChangeBestandteilToolStripMenuItem.Name = "ChangeBestandteilToolStripMenuItem"
        Me.ChangeBestandteilToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ChangeBestandteilToolStripMenuItem.Text = "x_Change"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_ToDay)
        Me.TabControl1.Controls.Add(Me.TabPage_Days)
        Me.TabControl1.Controls.Add(Me.TabPage_Weeks)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(345, 129)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_ToDay
        '
        Me.TabPage_ToDay.Controls.Add(Me.ProgressBar_Mengen)
        Me.TabPage_ToDay.Controls.Add(Me.DataGridView_Tagesmengen)
        Me.TabPage_ToDay.Controls.Add(Me.Label_Bestandteile_Tag)
        Me.TabPage_ToDay.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ToDay.Name = "TabPage_ToDay"
        Me.TabPage_ToDay.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ToDay.Size = New System.Drawing.Size(337, 103)
        Me.TabPage_ToDay.TabIndex = 0
        Me.TabPage_ToDay.Text = "x_Heute"
        Me.TabPage_ToDay.UseVisualStyleBackColor = True
        '
        'ProgressBar_Mengen
        '
        Me.ProgressBar_Mengen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar_Mengen.Location = New System.Drawing.Point(90, 5)
        Me.ProgressBar_Mengen.Name = "ProgressBar_Mengen"
        Me.ProgressBar_Mengen.Size = New System.Drawing.Size(244, 15)
        Me.ProgressBar_Mengen.TabIndex = 12
        '
        'DataGridView_Tagesmengen
        '
        Me.DataGridView_Tagesmengen.AllowUserToAddRows = False
        Me.DataGridView_Tagesmengen.AllowUserToDeleteRows = False
        Me.DataGridView_Tagesmengen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Tagesmengen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Tagesmengen.Location = New System.Drawing.Point(3, 23)
        Me.DataGridView_Tagesmengen.Name = "DataGridView_Tagesmengen"
        Me.DataGridView_Tagesmengen.ReadOnly = True
        Me.DataGridView_Tagesmengen.Size = New System.Drawing.Size(331, 77)
        Me.DataGridView_Tagesmengen.TabIndex = 11
        '
        'Label_Bestandteile_Tag
        '
        Me.Label_Bestandteile_Tag.AutoSize = True
        Me.Label_Bestandteile_Tag.Location = New System.Drawing.Point(0, 7)
        Me.Label_Bestandteile_Tag.Name = "Label_Bestandteile_Tag"
        Me.Label_Bestandteile_Tag.Size = New System.Drawing.Size(84, 13)
        Me.Label_Bestandteile_Tag.TabIndex = 10
        Me.Label_Bestandteile_Tag.Text = "x_Mengen/Tag:"
        '
        'TabPage_Days
        '
        Me.TabPage_Days.Controls.Add(Me.DataGridView_Dayly)
        Me.TabPage_Days.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Days.Name = "TabPage_Days"
        Me.TabPage_Days.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Days.Size = New System.Drawing.Size(337, 103)
        Me.TabPage_Days.TabIndex = 1
        Me.TabPage_Days.Text = "x_Tagesverlauf"
        Me.TabPage_Days.UseVisualStyleBackColor = True
        '
        'DataGridView_Dayly
        '
        Me.DataGridView_Dayly.AllowUserToAddRows = False
        Me.DataGridView_Dayly.AllowUserToDeleteRows = False
        Me.DataGridView_Dayly.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Dayly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Dayly.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView_Dayly.Name = "DataGridView_Dayly"
        Me.DataGridView_Dayly.ReadOnly = True
        Me.DataGridView_Dayly.Size = New System.Drawing.Size(331, 97)
        Me.DataGridView_Dayly.TabIndex = 2
        '
        'TabPage_Weeks
        '
        Me.TabPage_Weeks.Controls.Add(Me.DataGridView_Weeks)
        Me.TabPage_Weeks.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Weeks.Name = "TabPage_Weeks"
        Me.TabPage_Weeks.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Weeks.Size = New System.Drawing.Size(337, 103)
        Me.TabPage_Weeks.TabIndex = 2
        Me.TabPage_Weeks.Text = "x_Wochenverlauf"
        Me.TabPage_Weeks.UseVisualStyleBackColor = True
        '
        'DataGridView_Weeks
        '
        Me.DataGridView_Weeks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Weeks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Weeks.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView_Weeks.Name = "DataGridView_Weeks"
        Me.DataGridView_Weeks.Size = New System.Drawing.Size(331, 95)
        Me.DataGridView_Weeks.TabIndex = 0
        '
        'Timer_Tagesmengen
        '
        Me.Timer_Tagesmengen.Interval = 300
        '
        'UserControl_Trinken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UserControl_Trinken"
        Me.Size = New System.Drawing.Size(702, 493)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel_Edit.ResumeLayout(False)
        Me.Panel_Edit.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_Trinken, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView_Bestandteil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_Bestandteile.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_ToDay.ResumeLayout(False)
        Me.TabPage_ToDay.PerformLayout()
        CType(Me.DataGridView_Tagesmengen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Days.ResumeLayout(False)
        CType(Me.DataGridView_Dayly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Weeks.ResumeLayout(False)
        CType(Me.DataGridView_Weeks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Trinken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Bestandteil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Tagesmengen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Days, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Weeks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel_Edit As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker_Zeitpunkt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_Zeitpunkt As System.Windows.Forms.Label
    Friend WithEvents CheckBox_Eigeninitiative As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Spucken As System.Windows.Forms.CheckBox
    Friend WithEvents ImageList_Main As System.Windows.Forms.ImageList
    Friend WithEvents Button_Del As System.Windows.Forms.Button
    Friend WithEvents Button_New As System.Windows.Forms.Button
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents BindingSource_Trinken As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip_State As System.Windows.Forms.ToolTip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label_Trinkmessungen As System.Windows.Forms.Label
    Friend WithEvents DataGridView_Trinken As System.Windows.Forms.DataGridView
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents BindingSource_Bestandteil As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip_Bestandteile As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddBestandteilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveBestandteilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeBestandteilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Count_TrinkenLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Count_Trinken As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label_Bestandteile As System.Windows.Forms.Label
    Friend WithEvents DataGridView_Bestandteil As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_Tagesmengen As System.Windows.Forms.BindingSource
    Friend WithEvents Timer_Tagesmengen As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_Filter As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton_ClearFilter As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_ToDay As System.Windows.Forms.TabPage
    Friend WithEvents ProgressBar_Mengen As System.Windows.Forms.ProgressBar
    Friend WithEvents DataGridView_Tagesmengen As System.Windows.Forms.DataGridView
    Friend WithEvents Label_Bestandteile_Tag As System.Windows.Forms.Label
    Friend WithEvents TabPage_Days As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView_Dayly As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage_Weeks As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView_Weeks As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource_Days As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource_Weeks As System.Windows.Forms.BindingSource

End Class
