<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTypeEdit
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_DB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_VersionLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Version = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_ClassName = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_ClassName = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_GUID = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_GUID = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_DelClass = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_AddAttribute = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_DelAttribute = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView_Attributes = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_ForwardRelations = New System.Windows.Forms.TabPage()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_AddType_Forw = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Remove_TypeRight = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView_RelationsForward = New System.Windows.Forms.DataGridView()
        Me.TabPage_ObjectReferences = New System.Windows.Forms.TabPage()
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_AddRelationType = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_DelRelationType = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView_ObjectReferences = New System.Windows.Forms.DataGridView()
        Me.TabPage_Backward = New System.Windows.Forms.TabPage()
        Me.ToolStrip6 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_AddType_Back = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_DelType_Back = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView_BackwardRelations = New System.Windows.Forms.DataGridView()
        Me.BindingSource_Attributes = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_RelForw = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_RelBackw = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingSource_ObjectReferences = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer_ClassName = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.DataGridView_Attributes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_ForwardRelations.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.DataGridView_RelationsForward, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_ObjectReferences.SuspendLayout()
        Me.ToolStrip5.SuspendLayout()
        CType(Me.DataGridView_ObjectReferences, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Backward.SuspendLayout()
        Me.ToolStrip6.SuspendLayout()
        CType(Me.DataGridView_BackwardRelations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Attributes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_RelForw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_RelBackw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_ObjectReferences, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_DB, Me.ToolStripStatusLabel_VersionLbl, Me.ToolStripStatusLabel_Version})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 361)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(961, 25)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel_DB
        '
        Me.ToolStripStatusLabel_DB.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ToolStripStatusLabel_DB.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel_DB.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripStatusLabel_DB.Image = Global.Sem_Manager.My.Resources.Resources.bb_home_
        Me.ToolStripStatusLabel_DB.Name = "ToolStripStatusLabel_DB"
        Me.ToolStripStatusLabel_DB.Size = New System.Drawing.Size(42, 20)
        Me.ToolStripStatusLabel_DB.Text = "DB"
        '
        'ToolStripStatusLabel_VersionLbl
        '
        Me.ToolStripStatusLabel_VersionLbl.Name = "ToolStripStatusLabel_VersionLbl"
        Me.ToolStripStatusLabel_VersionLbl.Size = New System.Drawing.Size(59, 20)
        Me.ToolStripStatusLabel_VersionLbl.Text = "x_Version:"
        '
        'ToolStripStatusLabel_Version
        '
        Me.ToolStripStatusLabel_Version.Name = "ToolStripStatusLabel_Version"
        Me.ToolStripStatusLabel_Version.Size = New System.Drawing.Size(13, 20)
        Me.ToolStripStatusLabel_Version.Text = "0"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(961, 361)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_ClassName, Me.ToolStripTextBox_ClassName, Me.ToolStripSeparator3, Me.ToolStripLabel_GUID, Me.ToolStripTextBox_GUID, Me.ToolStripSeparator4, Me.ToolStripButton_DelClass})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(961, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel_ClassName
        '
        Me.ToolStripLabel_ClassName.Name = "ToolStripLabel_ClassName"
        Me.ToolStripLabel_ClassName.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripLabel_ClassName.Text = "x_Typenbezeichnung:"
        '
        'ToolStripTextBox_ClassName
        '
        Me.ToolStripTextBox_ClassName.Name = "ToolStripTextBox_ClassName"
        Me.ToolStripTextBox_ClassName.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_GUID
        '
        Me.ToolStripLabel_GUID.Name = "ToolStripLabel_GUID"
        Me.ToolStripLabel_GUID.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel_GUID.Text = "x_GUID:"
        '
        'ToolStripTextBox_GUID
        '
        Me.ToolStripTextBox_GUID.Name = "ToolStripTextBox_GUID"
        Me.ToolStripTextBox_GUID.ReadOnly = True
        Me.ToolStripTextBox_GUID.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_DelClass
        '
        Me.ToolStripButton_DelClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_DelClass.Image = Global.Sem_Manager.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_DelClass.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DelClass.Name = "ToolStripButton_DelClass"
        Me.ToolStripButton_DelClass.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_DelClass.Text = "ToolStripButton1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(955, 330)
        Me.SplitContainer1.SplitterDistance = 477
        Me.SplitContainer1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ToolStrip2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridView_Attributes, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(473, 326)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_AddAttribute, Me.ToolStripButton_DelAttribute})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(473, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton_AddAttribute
        '
        Me.ToolStripButton_AddAttribute.Image = Global.Sem_Manager.My.Resources.Resources.b_plus
        Me.ToolStripButton_AddAttribute.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_AddAttribute.Name = "ToolStripButton_AddAttribute"
        Me.ToolStripButton_AddAttribute.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripButton_AddAttribute.Text = "x_Attribute"
        '
        'ToolStripButton_DelAttribute
        '
        Me.ToolStripButton_DelAttribute.Image = Global.Sem_Manager.My.Resources.Resources.b_minus
        Me.ToolStripButton_DelAttribute.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DelAttribute.Name = "ToolStripButton_DelAttribute"
        Me.ToolStripButton_DelAttribute.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripButton_DelAttribute.Text = "x_Attribute"
        '
        'DataGridView_Attributes
        '
        Me.DataGridView_Attributes.AllowUserToAddRows = False
        Me.DataGridView_Attributes.AllowUserToDeleteRows = False
        Me.DataGridView_Attributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Attributes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Attributes.Location = New System.Drawing.Point(3, 28)
        Me.DataGridView_Attributes.Name = "DataGridView_Attributes"
        Me.DataGridView_Attributes.ReadOnly = True
        Me.DataGridView_Attributes.Size = New System.Drawing.Size(467, 295)
        Me.DataGridView_Attributes.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(470, 326)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_ForwardRelations)
        Me.TabControl1.Controls.Add(Me.TabPage_ObjectReferences)
        Me.TabControl1.Controls.Add(Me.TabPage_Backward)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(464, 320)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage_ForwardRelations
        '
        Me.TabPage_ForwardRelations.Controls.Add(Me.ToolStrip3)
        Me.TabPage_ForwardRelations.Controls.Add(Me.DataGridView_RelationsForward)
        Me.TabPage_ForwardRelations.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ForwardRelations.Name = "TabPage_ForwardRelations"
        Me.TabPage_ForwardRelations.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ForwardRelations.Size = New System.Drawing.Size(456, 294)
        Me.TabPage_ForwardRelations.TabIndex = 0
        Me.TabPage_ForwardRelations.Text = "x_Forward-Relations"
        Me.TabPage_ForwardRelations.UseVisualStyleBackColor = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_AddType_Forw, Me.ToolStripButton_Remove_TypeRight})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(450, 25)
        Me.ToolStrip3.TabIndex = 1
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripButton_AddType_Forw
        '
        Me.ToolStripButton_AddType_Forw.Image = Global.Sem_Manager.My.Resources.Resources.b_plus
        Me.ToolStripButton_AddType_Forw.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_AddType_Forw.Name = "ToolStripButton_AddType_Forw"
        Me.ToolStripButton_AddType_Forw.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton_AddType_Forw.Text = "x_Type"
        '
        'ToolStripButton_Remove_TypeRight
        '
        Me.ToolStripButton_Remove_TypeRight.Image = Global.Sem_Manager.My.Resources.Resources.b_minus
        Me.ToolStripButton_Remove_TypeRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Remove_TypeRight.Name = "ToolStripButton_Remove_TypeRight"
        Me.ToolStripButton_Remove_TypeRight.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton_Remove_TypeRight.Text = "x_Type"
        '
        'DataGridView_RelationsForward
        '
        Me.DataGridView_RelationsForward.AllowUserToAddRows = False
        Me.DataGridView_RelationsForward.AllowUserToDeleteRows = False
        Me.DataGridView_RelationsForward.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_RelationsForward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_RelationsForward.Location = New System.Drawing.Point(3, 31)
        Me.DataGridView_RelationsForward.Name = "DataGridView_RelationsForward"
        Me.DataGridView_RelationsForward.ReadOnly = True
        Me.DataGridView_RelationsForward.Size = New System.Drawing.Size(450, 260)
        Me.DataGridView_RelationsForward.TabIndex = 0
        '
        'TabPage_ObjectReferences
        '
        Me.TabPage_ObjectReferences.Controls.Add(Me.ToolStrip5)
        Me.TabPage_ObjectReferences.Controls.Add(Me.DataGridView_ObjectReferences)
        Me.TabPage_ObjectReferences.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ObjectReferences.Name = "TabPage_ObjectReferences"
        Me.TabPage_ObjectReferences.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ObjectReferences.Size = New System.Drawing.Size(456, 294)
        Me.TabPage_ObjectReferences.TabIndex = 2
        Me.TabPage_ObjectReferences.Text = "x_ObjectReferences"
        Me.TabPage_ObjectReferences.UseVisualStyleBackColor = True
        '
        'ToolStrip5
        '
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_AddRelationType, Me.ToolStripButton_DelRelationType})
        Me.ToolStrip5.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Size = New System.Drawing.Size(450, 25)
        Me.ToolStrip5.TabIndex = 3
        Me.ToolStrip5.Text = "ToolStrip5"
        '
        'ToolStripButton_AddRelationType
        '
        Me.ToolStripButton_AddRelationType.Image = Global.Sem_Manager.My.Resources.Resources.b_plus
        Me.ToolStripButton_AddRelationType.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_AddRelationType.Name = "ToolStripButton_AddRelationType"
        Me.ToolStripButton_AddRelationType.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripButton_AddRelationType.Text = "x_RelationType"
        '
        'ToolStripButton_DelRelationType
        '
        Me.ToolStripButton_DelRelationType.Image = Global.Sem_Manager.My.Resources.Resources.b_minus
        Me.ToolStripButton_DelRelationType.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DelRelationType.Name = "ToolStripButton_DelRelationType"
        Me.ToolStripButton_DelRelationType.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripButton_DelRelationType.Text = "x_RelationType"
        '
        'DataGridView_ObjectReferences
        '
        Me.DataGridView_ObjectReferences.AllowUserToAddRows = False
        Me.DataGridView_ObjectReferences.AllowUserToDeleteRows = False
        Me.DataGridView_ObjectReferences.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_ObjectReferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ObjectReferences.Location = New System.Drawing.Point(3, 31)
        Me.DataGridView_ObjectReferences.Name = "DataGridView_ObjectReferences"
        Me.DataGridView_ObjectReferences.ReadOnly = True
        Me.DataGridView_ObjectReferences.Size = New System.Drawing.Size(450, 260)
        Me.DataGridView_ObjectReferences.TabIndex = 2
        '
        'TabPage_Backward
        '
        Me.TabPage_Backward.Controls.Add(Me.ToolStrip6)
        Me.TabPage_Backward.Controls.Add(Me.DataGridView_BackwardRelations)
        Me.TabPage_Backward.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Backward.Name = "TabPage_Backward"
        Me.TabPage_Backward.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Backward.Size = New System.Drawing.Size(456, 294)
        Me.TabPage_Backward.TabIndex = 1
        Me.TabPage_Backward.Text = "x_Backward-Relations"
        Me.TabPage_Backward.UseVisualStyleBackColor = True
        '
        'ToolStrip6
        '
        Me.ToolStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_AddType_Back, Me.ToolStripButton_DelType_Back})
        Me.ToolStrip6.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip6.Name = "ToolStrip6"
        Me.ToolStrip6.Size = New System.Drawing.Size(450, 25)
        Me.ToolStrip6.TabIndex = 2
        Me.ToolStrip6.Text = "ToolStrip6"
        '
        'ToolStripButton_AddType_Back
        '
        Me.ToolStripButton_AddType_Back.Image = Global.Sem_Manager.My.Resources.Resources.b_plus
        Me.ToolStripButton_AddType_Back.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_AddType_Back.Name = "ToolStripButton_AddType_Back"
        Me.ToolStripButton_AddType_Back.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton_AddType_Back.Text = "x_Type"
        '
        'ToolStripButton_DelType_Back
        '
        Me.ToolStripButton_DelType_Back.Image = Global.Sem_Manager.My.Resources.Resources.b_minus
        Me.ToolStripButton_DelType_Back.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DelType_Back.Name = "ToolStripButton_DelType_Back"
        Me.ToolStripButton_DelType_Back.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton_DelType_Back.Text = "x_Type"
        '
        'DataGridView_BackwardRelations
        '
        Me.DataGridView_BackwardRelations.AllowUserToAddRows = False
        Me.DataGridView_BackwardRelations.AllowUserToDeleteRows = False
        Me.DataGridView_BackwardRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_BackwardRelations.Location = New System.Drawing.Point(3, 31)
        Me.DataGridView_BackwardRelations.Name = "DataGridView_BackwardRelations"
        Me.DataGridView_BackwardRelations.ReadOnly = True
        Me.DataGridView_BackwardRelations.Size = New System.Drawing.Size(450, 235)
        Me.DataGridView_BackwardRelations.TabIndex = 0
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.Sem_Manager.My.Resources.Resources.b_plus
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton3.Text = "x_Type"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.Sem_Manager.My.Resources.Resources.b_minus
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton4.Text = "x_Type"
        '
        'Timer_ClassName
        '
        Me.Timer_ClassName.Interval = 300
        '
        'frmTypeEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 386)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmTypeEdit"
        Me.Text = "frmTypeEdit"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.DataGridView_Attributes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_ForwardRelations.ResumeLayout(False)
        Me.TabPage_ForwardRelations.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.DataGridView_RelationsForward, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_ObjectReferences.ResumeLayout(False)
        Me.TabPage_ObjectReferences.PerformLayout()
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        CType(Me.DataGridView_ObjectReferences, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Backward.ResumeLayout(False)
        Me.TabPage_Backward.PerformLayout()
        Me.ToolStrip6.ResumeLayout(False)
        Me.ToolStrip6.PerformLayout()
        CType(Me.DataGridView_BackwardRelations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Attributes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_RelForw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_RelBackw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_ObjectReferences, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel_DB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_ClassName As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_ClassName As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripButton_DelClass As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel_GUID As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_GUID As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_AddAttribute As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_DelAttribute As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridView_Attributes As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_ForwardRelations As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Backward As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView_BackwardRelations As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripStatusLabel_VersionLbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Version As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BindingSource_Attributes As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource_RelForw As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource_RelBackw As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView_RelationsForward As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage_ObjectReferences As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_AddType_Forw As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Remove_TypeRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip5 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_AddRelationType As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_DelRelationType As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView_ObjectReferences As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip6 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_AddType_Back As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_DelType_Back As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingSource_ObjectReferences As System.Windows.Forms.BindingSource
    Friend WithEvents Timer_ClassName As System.Windows.Forms.Timer
End Class
