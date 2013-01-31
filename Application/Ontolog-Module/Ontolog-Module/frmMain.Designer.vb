<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_DatabaseLBL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Database = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_TokenAttLBL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_TokenAtt_Attribute = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_TokenAttSeperator = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_TokenAtt_Token = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_RelationLBL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_TokenRelLeft = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Seperator1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_TokenRelRelation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Seperator2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_TokenRelRight = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_RelationDoneLBL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_RelationDone = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer_Filter_Body = New System.Windows.Forms.SplitContainer()
        Me.Panel_Filter = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBox_NameRelationType = New System.Windows.Forms.TextBox()
        Me.TextBox_GUIDRelationType = New System.Windows.Forms.TextBox()
        Me.TextBox_NameType = New System.Windows.Forms.TextBox()
        Me.TextBox_GUIDType = New System.Windows.Forms.TextBox()
        Me.TextBox_NameToken = New System.Windows.Forms.TextBox()
        Me.TextBox_GUIDToken = New System.Windows.Forms.TextBox()
        Me.Label_NameRelationTypeLBL = New System.Windows.Forms.Label()
        Me.Label_GUIDRelationLBL = New System.Windows.Forms.Label()
        Me.Label_NameTypeLBL = New System.Windows.Forms.Label()
        Me.Label_GUIDTypeLBL = New System.Windows.Forms.Label()
        Me.Label_NameTokenLBL = New System.Windows.Forms.Label()
        Me.Label_GUIDTokenLBL = New System.Windows.Forms.Label()
        Me.TextBox_NameTypeOther = New System.Windows.Forms.TextBox()
        Me.TextBox_GUIDTypeOther = New System.Windows.Forms.TextBox()
        Me.TextBox_NameTokenOther = New System.Windows.Forms.TextBox()
        Me.TextBox_GUIDTokenOther = New System.Windows.Forms.TextBox()
        Me.Label_NameTypeOtherLBL = New System.Windows.Forms.Label()
        Me.Label_GUIDTypeOtherLBL = New System.Windows.Forms.Label()
        Me.Label_NameTokenOtherLBL = New System.Windows.Forms.Label()
        Me.Label_GUIDTokenOtherLBL = New System.Windows.Forms.Label()
        Me.CheckBox_Filter = New System.Windows.Forms.CheckBox()
        Me.Button_SaveFilter = New System.Windows.Forms.Button()
        Me.ComboBox_Filter = New System.Windows.Forms.ComboBox()
        Me.Label_FilterStd = New System.Windows.Forms.Label()
        Me.Button_Filter = New System.Windows.Forms.Button()
        Me.Button_GetData = New System.Windows.Forms.Button()
        Me.GroupBox_FilterDr = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton_RightLeft = New System.Windows.Forms.RadioButton()
        Me.RadioButton_LeftRight = New System.Windows.Forms.RadioButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer_TypeToken = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.SplitContainer_Token = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer_AttribRelTokenRel = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer_AttribRel = New System.Windows.Forms.SplitContainer()
        Me.Panel_Attributes = New System.Windows.Forms.Panel()
        Me.Label_AttributesLBL = New System.Windows.Forms.Label()
        Me.ToolStripContainer3 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip6 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_TokAttCountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_TokAttCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripProgressBar_TokenAttribiute = New System.Windows.Forms.ToolStripProgressBar()
        Me.DataGridView_TokenAtt = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_TokAtt = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyValToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_TokAttFilterLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_TokAttFilter = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton_DelTokenAtt = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer_TokAttTokRel = New System.Windows.Forms.SplitContainer()
        Me.Panel_RelationTypes = New System.Windows.Forms.Panel()
        Me.Label_RelationTypes = New System.Windows.Forms.Label()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_RelCountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_RelCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripProgressBar_TokenRelation = New System.Windows.Forms.ToolStripProgressBar()
        Me.DataGridView_Relations = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_TokRel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetOrderIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetRelationTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuleEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox_ModuleEdit = New System.Windows.Forms.ToolStripComboBox()
        Me.ModuleMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox_ModuleMenu = New System.Windows.Forms.ToolStripComboBox()
        Me.CopyValToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EqualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifferentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContainsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox_TokRelContains = New System.Windows.Forms.ToolStripTextBox()
        Me.GreaterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LessThanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_FilterLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Filter = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton_DelTokenRel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Types = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Token = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Tokentree = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_AttribRel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_TokenRel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Filter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_ModuleView = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_TokenRelation = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_TokenAttribute = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource_TokenRel = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_TokenAtt = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.LeftToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer_Filter_Body, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Filter_Body.Panel1.SuspendLayout()
        Me.SplitContainer_Filter_Body.Panel2.SuspendLayout()
        Me.SplitContainer_Filter_Body.SuspendLayout()
        Me.Panel_Filter.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox_FilterDr.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer_TypeToken, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_TypeToken.Panel1.SuspendLayout()
        Me.SplitContainer_TypeToken.Panel2.SuspendLayout()
        Me.SplitContainer_TypeToken.SuspendLayout()
        CType(Me.SplitContainer_Token, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Token.SuspendLayout()
        CType(Me.SplitContainer_AttribRelTokenRel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_AttribRelTokenRel.Panel1.SuspendLayout()
        Me.SplitContainer_AttribRelTokenRel.Panel2.SuspendLayout()
        Me.SplitContainer_AttribRelTokenRel.SuspendLayout()
        CType(Me.SplitContainer_AttribRel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_AttribRel.Panel1.SuspendLayout()
        Me.SplitContainer_AttribRel.Panel2.SuspendLayout()
        Me.SplitContainer_AttribRel.SuspendLayout()
        Me.ToolStripContainer3.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer3.ContentPanel.SuspendLayout()
        Me.ToolStripContainer3.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer3.SuspendLayout()
        Me.ToolStrip6.SuspendLayout()
        CType(Me.DataGridView_TokenAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_TokAtt.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.SplitContainer_TokAttTokRel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_TokAttTokRel.Panel1.SuspendLayout()
        Me.SplitContainer_TokAttTokRel.Panel2.SuspendLayout()
        Me.SplitContainer_TokAttTokRel.SuspendLayout()
        Me.ToolStripContainer2.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        CType(Me.DataGridView_Relations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_TokRel.SuspendLayout()
        Me.ToolStrip5.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BindingSource_TokenRel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_TokenAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer_Filter_Body)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1377, 554)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.LeftToolStripPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1401, 602)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_DatabaseLBL, Me.ToolStripStatusLabel_Database, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel_TokenAttLBL, Me.ToolStripStatusLabel_TokenAtt_Attribute, Me.ToolStripStatusLabel_TokenAttSeperator, Me.ToolStripStatusLabel_TokenAtt_Token, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel_RelationLBL, Me.ToolStripStatusLabel_TokenRelLeft, Me.ToolStripStatusLabel_Seperator1, Me.ToolStripStatusLabel_TokenRelRelation, Me.ToolStripStatusLabel_Seperator2, Me.ToolStripStatusLabel_TokenRelRight, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel_RelationDoneLBL, Me.ToolStripStatusLabel_RelationDone})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1401, 24)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel_DatabaseLBL
        '
        Me.ToolStripStatusLabel_DatabaseLBL.Name = "ToolStripStatusLabel_DatabaseLBL"
        Me.ToolStripStatusLabel_DatabaseLBL.Size = New System.Drawing.Size(58, 19)
        Me.ToolStripStatusLabel_DatabaseLBL.Text = "Database:"
        '
        'ToolStripStatusLabel_Database
        '
        Me.ToolStripStatusLabel_Database.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel_Database.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel_Database.Name = "ToolStripStatusLabel_Database"
        Me.ToolStripStatusLabel_Database.Size = New System.Drawing.Size(16, 19)
        Me.ToolStripStatusLabel_Database.Text = "-"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 19)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusLabel_TokenAttLBL
        '
        Me.ToolStripStatusLabel_TokenAttLBL.Name = "ToolStripStatusLabel_TokenAttLBL"
        Me.ToolStripStatusLabel_TokenAttLBL.Size = New System.Drawing.Size(95, 19)
        Me.ToolStripStatusLabel_TokenAttLBL.Text = "Token-Attribute:"
        '
        'ToolStripStatusLabel_TokenAtt_Attribute
        '
        Me.ToolStripStatusLabel_TokenAtt_Attribute.Name = "ToolStripStatusLabel_TokenAtt_Attribute"
        Me.ToolStripStatusLabel_TokenAtt_Attribute.Size = New System.Drawing.Size(12, 19)
        Me.ToolStripStatusLabel_TokenAtt_Attribute.Text = "-"
        '
        'ToolStripStatusLabel_TokenAttSeperator
        '
        Me.ToolStripStatusLabel_TokenAttSeperator.Name = "ToolStripStatusLabel_TokenAttSeperator"
        Me.ToolStripStatusLabel_TokenAttSeperator.Size = New System.Drawing.Size(12, 19)
        Me.ToolStripStatusLabel_TokenAttSeperator.Text = "/"
        '
        'ToolStripStatusLabel_TokenAtt_Token
        '
        Me.ToolStripStatusLabel_TokenAtt_Token.Name = "ToolStripStatusLabel_TokenAtt_Token"
        Me.ToolStripStatusLabel_TokenAtt_Token.Size = New System.Drawing.Size(12, 19)
        Me.ToolStripStatusLabel_TokenAtt_Token.Text = "-"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(10, 19)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'ToolStripStatusLabel_RelationLBL
        '
        Me.ToolStripStatusLabel_RelationLBL.Name = "ToolStripStatusLabel_RelationLBL"
        Me.ToolStripStatusLabel_RelationLBL.Size = New System.Drawing.Size(53, 19)
        Me.ToolStripStatusLabel_RelationLBL.Text = "Relation:"
        '
        'ToolStripStatusLabel_TokenRelLeft
        '
        Me.ToolStripStatusLabel_TokenRelLeft.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel_TokenRelLeft.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.ToolStripStatusLabel_TokenRelLeft.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel_TokenRelLeft.Name = "ToolStripStatusLabel_TokenRelLeft"
        Me.ToolStripStatusLabel_TokenRelLeft.Size = New System.Drawing.Size(16, 19)
        Me.ToolStripStatusLabel_TokenRelLeft.Text = "-"
        '
        'ToolStripStatusLabel_Seperator1
        '
        Me.ToolStripStatusLabel_Seperator1.Name = "ToolStripStatusLabel_Seperator1"
        Me.ToolStripStatusLabel_Seperator1.Size = New System.Drawing.Size(12, 19)
        Me.ToolStripStatusLabel_Seperator1.Text = "/"
        '
        'ToolStripStatusLabel_TokenRelRelation
        '
        Me.ToolStripStatusLabel_TokenRelRelation.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel_TokenRelRelation.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.ToolStripStatusLabel_TokenRelRelation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel_TokenRelRelation.Name = "ToolStripStatusLabel_TokenRelRelation"
        Me.ToolStripStatusLabel_TokenRelRelation.Size = New System.Drawing.Size(16, 19)
        Me.ToolStripStatusLabel_TokenRelRelation.Text = "-"
        '
        'ToolStripStatusLabel_Seperator2
        '
        Me.ToolStripStatusLabel_Seperator2.Name = "ToolStripStatusLabel_Seperator2"
        Me.ToolStripStatusLabel_Seperator2.Size = New System.Drawing.Size(12, 19)
        Me.ToolStripStatusLabel_Seperator2.Text = "/"
        '
        'ToolStripStatusLabel_TokenRelRight
        '
        Me.ToolStripStatusLabel_TokenRelRight.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel_TokenRelRight.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.ToolStripStatusLabel_TokenRelRight.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel_TokenRelRight.Name = "ToolStripStatusLabel_TokenRelRight"
        Me.ToolStripStatusLabel_TokenRelRight.Size = New System.Drawing.Size(16, 19)
        Me.ToolStripStatusLabel_TokenRelRight.Text = "-"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 19)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'ToolStripStatusLabel_RelationDoneLBL
        '
        Me.ToolStripStatusLabel_RelationDoneLBL.Name = "ToolStripStatusLabel_RelationDoneLBL"
        Me.ToolStripStatusLabel_RelationDoneLBL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel_RelationDoneLBL.Size = New System.Drawing.Size(92, 19)
        Me.ToolStripStatusLabel_RelationDoneLBL.Text = "Relation (Done):"
        '
        'ToolStripStatusLabel_RelationDone
        '
        Me.ToolStripStatusLabel_RelationDone.Name = "ToolStripStatusLabel_RelationDone"
        Me.ToolStripStatusLabel_RelationDone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel_RelationDone.Size = New System.Drawing.Size(12, 19)
        Me.ToolStripStatusLabel_RelationDone.Text = "-"
        '
        'SplitContainer_Filter_Body
        '
        Me.SplitContainer_Filter_Body.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer_Filter_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Filter_Body.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Filter_Body.Name = "SplitContainer_Filter_Body"
        Me.SplitContainer_Filter_Body.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer_Filter_Body.Panel1
        '
        Me.SplitContainer_Filter_Body.Panel1.Controls.Add(Me.Panel_Filter)
        Me.SplitContainer_Filter_Body.Panel1.Controls.Add(Me.CheckBox_Filter)
        Me.SplitContainer_Filter_Body.Panel1.Controls.Add(Me.Button_SaveFilter)
        Me.SplitContainer_Filter_Body.Panel1.Controls.Add(Me.ComboBox_Filter)
        Me.SplitContainer_Filter_Body.Panel1.Controls.Add(Me.Label_FilterStd)
        Me.SplitContainer_Filter_Body.Panel1.Controls.Add(Me.Button_Filter)
        Me.SplitContainer_Filter_Body.Panel1.Controls.Add(Me.Button_GetData)
        Me.SplitContainer_Filter_Body.Panel1.Controls.Add(Me.GroupBox_FilterDr)
        '
        'SplitContainer_Filter_Body.Panel2
        '
        Me.SplitContainer_Filter_Body.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer_Filter_Body.Size = New System.Drawing.Size(1377, 554)
        Me.SplitContainer_Filter_Body.SplitterDistance = 105
        Me.SplitContainer_Filter_Body.TabIndex = 0
        '
        'Panel_Filter
        '
        Me.Panel_Filter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Filter.Controls.Add(Me.SplitContainer1)
        Me.Panel_Filter.Location = New System.Drawing.Point(119, 3)
        Me.Panel_Filter.Name = "Panel_Filter"
        Me.Panel_Filter.Size = New System.Drawing.Size(1052, 95)
        Me.Panel_Filter.TabIndex = 1
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_NameRelationType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_GUIDRelationType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_NameType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_GUIDType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_NameToken)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_GUIDToken)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_NameRelationTypeLBL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_GUIDRelationLBL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_NameTypeLBL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_GUIDTypeLBL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_NameTokenLBL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_GUIDTokenLBL)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_NameTypeOther)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_GUIDTypeOther)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_NameTokenOther)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_GUIDTokenOther)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label_NameTypeOtherLBL)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label_GUIDTypeOtherLBL)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label_NameTokenOtherLBL)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label_GUIDTokenOtherLBL)
        Me.SplitContainer1.Size = New System.Drawing.Size(1052, 95)
        Me.SplitContainer1.SplitterDistance = 499
        Me.SplitContainer1.TabIndex = 0
        '
        'TextBox_NameRelationType
        '
        Me.TextBox_NameRelationType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NameRelationType.Location = New System.Drawing.Point(119, 122)
        Me.TextBox_NameRelationType.Name = "TextBox_NameRelationType"
        Me.TextBox_NameRelationType.Size = New System.Drawing.Size(373, 20)
        Me.TextBox_NameRelationType.TabIndex = 16
        '
        'TextBox_GUIDRelationType
        '
        Me.TextBox_GUIDRelationType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_GUIDRelationType.Location = New System.Drawing.Point(118, 98)
        Me.TextBox_GUIDRelationType.Name = "TextBox_GUIDRelationType"
        Me.TextBox_GUIDRelationType.Size = New System.Drawing.Size(374, 20)
        Me.TextBox_GUIDRelationType.TabIndex = 15
        '
        'TextBox_NameType
        '
        Me.TextBox_NameType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NameType.Location = New System.Drawing.Point(87, 74)
        Me.TextBox_NameType.Name = "TextBox_NameType"
        Me.TextBox_NameType.Size = New System.Drawing.Size(405, 20)
        Me.TextBox_NameType.TabIndex = 14
        '
        'TextBox_GUIDType
        '
        Me.TextBox_GUIDType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_GUIDType.Location = New System.Drawing.Point(87, 50)
        Me.TextBox_GUIDType.Name = "TextBox_GUIDType"
        Me.TextBox_GUIDType.Size = New System.Drawing.Size(405, 20)
        Me.TextBox_GUIDType.TabIndex = 13
        '
        'TextBox_NameToken
        '
        Me.TextBox_NameToken.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NameToken.Location = New System.Drawing.Point(87, 27)
        Me.TextBox_NameToken.Name = "TextBox_NameToken"
        Me.TextBox_NameToken.Size = New System.Drawing.Size(405, 20)
        Me.TextBox_NameToken.TabIndex = 12
        '
        'TextBox_GUIDToken
        '
        Me.TextBox_GUIDToken.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_GUIDToken.Location = New System.Drawing.Point(87, 4)
        Me.TextBox_GUIDToken.Name = "TextBox_GUIDToken"
        Me.TextBox_GUIDToken.Size = New System.Drawing.Size(405, 20)
        Me.TextBox_GUIDToken.TabIndex = 11
        '
        'Label_NameRelationTypeLBL
        '
        Me.Label_NameRelationTypeLBL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_NameRelationTypeLBL.AutoSize = True
        Me.Label_NameRelationTypeLBL.Location = New System.Drawing.Point(6, 124)
        Me.Label_NameRelationTypeLBL.Name = "Label_NameRelationTypeLBL"
        Me.Label_NameRelationTypeLBL.Size = New System.Drawing.Size(107, 13)
        Me.Label_NameRelationTypeLBL.TabIndex = 10
        Me.Label_NameRelationTypeLBL.Text = "Name_RelationType:"
        '
        'Label_GUIDRelationLBL
        '
        Me.Label_GUIDRelationLBL.AutoSize = True
        Me.Label_GUIDRelationLBL.Location = New System.Drawing.Point(6, 100)
        Me.Label_GUIDRelationLBL.Name = "Label_GUIDRelationLBL"
        Me.Label_GUIDRelationLBL.Size = New System.Drawing.Size(106, 13)
        Me.Label_GUIDRelationLBL.TabIndex = 9
        Me.Label_GUIDRelationLBL.Text = "GUID_RelationType:"
        '
        'Label_NameTypeLBL
        '
        Me.Label_NameTypeLBL.AutoSize = True
        Me.Label_NameTypeLBL.Location = New System.Drawing.Point(5, 77)
        Me.Label_NameTypeLBL.Name = "Label_NameTypeLBL"
        Me.Label_NameTypeLBL.Size = New System.Drawing.Size(68, 13)
        Me.Label_NameTypeLBL.TabIndex = 8
        Me.Label_NameTypeLBL.Text = "Name_Type:"
        '
        'Label_GUIDTypeLBL
        '
        Me.Label_GUIDTypeLBL.AutoSize = True
        Me.Label_GUIDTypeLBL.Location = New System.Drawing.Point(6, 53)
        Me.Label_GUIDTypeLBL.Name = "Label_GUIDTypeLBL"
        Me.Label_GUIDTypeLBL.Size = New System.Drawing.Size(67, 13)
        Me.Label_GUIDTypeLBL.TabIndex = 7
        Me.Label_GUIDTypeLBL.Text = "GUID_Type:"
        '
        'Label_NameTokenLBL
        '
        Me.Label_NameTokenLBL.AutoSize = True
        Me.Label_NameTokenLBL.Location = New System.Drawing.Point(6, 30)
        Me.Label_NameTokenLBL.Name = "Label_NameTokenLBL"
        Me.Label_NameTokenLBL.Size = New System.Drawing.Size(75, 13)
        Me.Label_NameTokenLBL.TabIndex = 6
        Me.Label_NameTokenLBL.Text = "Name_Token:"
        '
        'Label_GUIDTokenLBL
        '
        Me.Label_GUIDTokenLBL.AutoSize = True
        Me.Label_GUIDTokenLBL.Location = New System.Drawing.Point(6, 6)
        Me.Label_GUIDTokenLBL.Name = "Label_GUIDTokenLBL"
        Me.Label_GUIDTokenLBL.Size = New System.Drawing.Size(74, 13)
        Me.Label_GUIDTokenLBL.TabIndex = 5
        Me.Label_GUIDTokenLBL.Text = "GUID_Token:"
        '
        'TextBox_NameTypeOther
        '
        Me.TextBox_NameTypeOther.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NameTypeOther.Location = New System.Drawing.Point(86, 74)
        Me.TextBox_NameTypeOther.Name = "TextBox_NameTypeOther"
        Me.TextBox_NameTypeOther.Size = New System.Drawing.Size(456, 20)
        Me.TextBox_NameTypeOther.TabIndex = 16
        '
        'TextBox_GUIDTypeOther
        '
        Me.TextBox_GUIDTypeOther.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_GUIDTypeOther.Location = New System.Drawing.Point(86, 50)
        Me.TextBox_GUIDTypeOther.Name = "TextBox_GUIDTypeOther"
        Me.TextBox_GUIDTypeOther.Size = New System.Drawing.Size(456, 20)
        Me.TextBox_GUIDTypeOther.TabIndex = 15
        '
        'TextBox_NameTokenOther
        '
        Me.TextBox_NameTokenOther.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NameTokenOther.Location = New System.Drawing.Point(86, 27)
        Me.TextBox_NameTokenOther.Name = "TextBox_NameTokenOther"
        Me.TextBox_NameTokenOther.Size = New System.Drawing.Size(456, 20)
        Me.TextBox_NameTokenOther.TabIndex = 14
        '
        'TextBox_GUIDTokenOther
        '
        Me.TextBox_GUIDTokenOther.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_GUIDTokenOther.Location = New System.Drawing.Point(86, 4)
        Me.TextBox_GUIDTokenOther.Name = "TextBox_GUIDTokenOther"
        Me.TextBox_GUIDTokenOther.Size = New System.Drawing.Size(456, 20)
        Me.TextBox_GUIDTokenOther.TabIndex = 13
        '
        'Label_NameTypeOtherLBL
        '
        Me.Label_NameTypeOtherLBL.AutoSize = True
        Me.Label_NameTypeOtherLBL.Location = New System.Drawing.Point(6, 77)
        Me.Label_NameTypeOtherLBL.Name = "Label_NameTypeOtherLBL"
        Me.Label_NameTypeOtherLBL.Size = New System.Drawing.Size(68, 13)
        Me.Label_NameTypeOtherLBL.TabIndex = 12
        Me.Label_NameTypeOtherLBL.Text = "Name_Type:"
        '
        'Label_GUIDTypeOtherLBL
        '
        Me.Label_GUIDTypeOtherLBL.AutoSize = True
        Me.Label_GUIDTypeOtherLBL.Location = New System.Drawing.Point(6, 53)
        Me.Label_GUIDTypeOtherLBL.Name = "Label_GUIDTypeOtherLBL"
        Me.Label_GUIDTypeOtherLBL.Size = New System.Drawing.Size(67, 13)
        Me.Label_GUIDTypeOtherLBL.TabIndex = 11
        Me.Label_GUIDTypeOtherLBL.Text = "GUID_Type:"
        '
        'Label_NameTokenOtherLBL
        '
        Me.Label_NameTokenOtherLBL.AutoSize = True
        Me.Label_NameTokenOtherLBL.Location = New System.Drawing.Point(5, 30)
        Me.Label_NameTokenOtherLBL.Name = "Label_NameTokenOtherLBL"
        Me.Label_NameTokenOtherLBL.Size = New System.Drawing.Size(75, 13)
        Me.Label_NameTokenOtherLBL.TabIndex = 10
        Me.Label_NameTokenOtherLBL.Text = "Name_Token:"
        '
        'Label_GUIDTokenOtherLBL
        '
        Me.Label_GUIDTokenOtherLBL.AutoSize = True
        Me.Label_GUIDTokenOtherLBL.Location = New System.Drawing.Point(6, 6)
        Me.Label_GUIDTokenOtherLBL.Name = "Label_GUIDTokenOtherLBL"
        Me.Label_GUIDTokenOtherLBL.Size = New System.Drawing.Size(74, 13)
        Me.Label_GUIDTokenOtherLBL.TabIndex = 9
        Me.Label_GUIDTokenOtherLBL.Text = "GUID_Token:"
        '
        'CheckBox_Filter
        '
        Me.CheckBox_Filter.AutoSize = True
        Me.CheckBox_Filter.Location = New System.Drawing.Point(953, 51)
        Me.CheckBox_Filter.Name = "CheckBox_Filter"
        Me.CheckBox_Filter.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox_Filter.TabIndex = 7
        Me.CheckBox_Filter.Text = "Filter"
        Me.CheckBox_Filter.UseVisualStyleBackColor = True
        '
        'Button_SaveFilter
        '
        Me.Button_SaveFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_SaveFilter.Location = New System.Drawing.Point(1275, 51)
        Me.Button_SaveFilter.Name = "Button_SaveFilter"
        Me.Button_SaveFilter.Size = New System.Drawing.Size(95, 23)
        Me.Button_SaveFilter.TabIndex = 6
        Me.Button_SaveFilter.Text = "Filter speichern"
        Me.Button_SaveFilter.UseVisualStyleBackColor = True
        '
        'ComboBox_Filter
        '
        Me.ComboBox_Filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Filter.FormattingEnabled = True
        Me.ComboBox_Filter.Location = New System.Drawing.Point(1177, 28)
        Me.ComboBox_Filter.Name = "ComboBox_Filter"
        Me.ComboBox_Filter.Size = New System.Drawing.Size(193, 21)
        Me.ComboBox_Filter.TabIndex = 5
        '
        'Label_FilterStd
        '
        Me.Label_FilterStd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_FilterStd.AutoSize = True
        Me.Label_FilterStd.Location = New System.Drawing.Point(1174, 11)
        Me.Label_FilterStd.Name = "Label_FilterStd"
        Me.Label_FilterStd.Size = New System.Drawing.Size(96, 13)
        Me.Label_FilterStd.TabIndex = 4
        Me.Label_FilterStd.Text = "Filter (gespeichert):"
        '
        'Button_Filter
        '
        Me.Button_Filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Filter.Location = New System.Drawing.Point(1275, 75)
        Me.Button_Filter.Name = "Button_Filter"
        Me.Button_Filter.Size = New System.Drawing.Size(95, 23)
        Me.Button_Filter.TabIndex = 3
        Me.Button_Filter.Text = "Filter"
        Me.Button_Filter.UseVisualStyleBackColor = True
        '
        'Button_GetData
        '
        Me.Button_GetData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_GetData.Location = New System.Drawing.Point(1275, 47)
        Me.Button_GetData.Name = "Button_GetData"
        Me.Button_GetData.Size = New System.Drawing.Size(95, 23)
        Me.Button_GetData.TabIndex = 2
        Me.Button_GetData.Text = "Eintrag holen"
        Me.Button_GetData.UseVisualStyleBackColor = True
        '
        'GroupBox_FilterDr
        '
        Me.GroupBox_FilterDr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_FilterDr.Controls.Add(Me.CheckBox1)
        Me.GroupBox_FilterDr.Controls.Add(Me.RadioButton_RightLeft)
        Me.GroupBox_FilterDr.Controls.Add(Me.RadioButton_LeftRight)
        Me.GroupBox_FilterDr.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox_FilterDr.Name = "GroupBox_FilterDr"
        Me.GroupBox_FilterDr.Size = New System.Drawing.Size(92, 95)
        Me.GroupBox_FilterDr.TabIndex = 0
        Me.GroupBox_FilterDr.TabStop = False
        Me.GroupBox_FilterDr.Text = "Filter-Config"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 67)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(44, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Null"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton_RightLeft
        '
        Me.RadioButton_RightLeft.AutoSize = True
        Me.RadioButton_RightLeft.Location = New System.Drawing.Point(7, 44)
        Me.RadioButton_RightLeft.Name = "RadioButton_RightLeft"
        Me.RadioButton_RightLeft.Size = New System.Drawing.Size(77, 17)
        Me.RadioButton_RightLeft.TabIndex = 1
        Me.RadioButton_RightLeft.Text = "Right->Left"
        Me.RadioButton_RightLeft.UseVisualStyleBackColor = True
        '
        'RadioButton_LeftRight
        '
        Me.RadioButton_LeftRight.AutoSize = True
        Me.RadioButton_LeftRight.Checked = True
        Me.RadioButton_LeftRight.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton_LeftRight.Name = "RadioButton_LeftRight"
        Me.RadioButton_LeftRight.Size = New System.Drawing.Size(77, 17)
        Me.RadioButton_LeftRight.TabIndex = 0
        Me.RadioButton_LeftRight.TabStop = True
        Me.RadioButton_LeftRight.Text = "Left->Right"
        Me.RadioButton_LeftRight.UseVisualStyleBackColor = True
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer_TypeToken)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer_AttribRelTokenRel)
        Me.SplitContainer2.Size = New System.Drawing.Size(1377, 445)
        Me.SplitContainer2.SplitterDistance = 665
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer_TypeToken
        '
        Me.SplitContainer_TypeToken.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer_TypeToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_TypeToken.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_TypeToken.Name = "SplitContainer_TypeToken"
        '
        'SplitContainer_TypeToken.Panel1
        '
        Me.SplitContainer_TypeToken.Panel1.Controls.Add(Me.ToolStrip2)
        '
        'SplitContainer_TypeToken.Panel2
        '
        Me.SplitContainer_TypeToken.Panel2.Controls.Add(Me.SplitContainer_Token)
        Me.SplitContainer_TypeToken.Size = New System.Drawing.Size(665, 445)
        Me.SplitContainer_TypeToken.SplitterDistance = 305
        Me.SplitContainer_TypeToken.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 416)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(301, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'SplitContainer_Token
        '
        Me.SplitContainer_Token.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer_Token.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Token.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Token.Name = "SplitContainer_Token"
        Me.SplitContainer_Token.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer_Token.Size = New System.Drawing.Size(356, 445)
        Me.SplitContainer_Token.SplitterDistance = 310
        Me.SplitContainer_Token.TabIndex = 0
        '
        'SplitContainer_AttribRelTokenRel
        '
        Me.SplitContainer_AttribRelTokenRel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer_AttribRelTokenRel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_AttribRelTokenRel.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_AttribRelTokenRel.Name = "SplitContainer_AttribRelTokenRel"
        '
        'SplitContainer_AttribRelTokenRel.Panel1
        '
        Me.SplitContainer_AttribRelTokenRel.Panel1.Controls.Add(Me.SplitContainer_AttribRel)
        '
        'SplitContainer_AttribRelTokenRel.Panel2
        '
        Me.SplitContainer_AttribRelTokenRel.Panel2.Controls.Add(Me.SplitContainer_TokAttTokRel)
        Me.SplitContainer_AttribRelTokenRel.Size = New System.Drawing.Size(708, 445)
        Me.SplitContainer_AttribRelTokenRel.SplitterDistance = 335
        Me.SplitContainer_AttribRelTokenRel.TabIndex = 0
        '
        'SplitContainer_AttribRel
        '
        Me.SplitContainer_AttribRel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer_AttribRel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_AttribRel.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_AttribRel.Name = "SplitContainer_AttribRel"
        Me.SplitContainer_AttribRel.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer_AttribRel.Panel1
        '
        Me.SplitContainer_AttribRel.Panel1.Controls.Add(Me.Panel_Attributes)
        Me.SplitContainer_AttribRel.Panel1.Controls.Add(Me.Label_AttributesLBL)
        '
        'SplitContainer_AttribRel.Panel2
        '
        Me.SplitContainer_AttribRel.Panel2.Controls.Add(Me.ToolStripContainer3)
        Me.SplitContainer_AttribRel.Size = New System.Drawing.Size(335, 445)
        Me.SplitContainer_AttribRel.SplitterDistance = 227
        Me.SplitContainer_AttribRel.TabIndex = 0
        '
        'Panel_Attributes
        '
        Me.Panel_Attributes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Attributes.Location = New System.Drawing.Point(4, 21)
        Me.Panel_Attributes.Name = "Panel_Attributes"
        Me.Panel_Attributes.Size = New System.Drawing.Size(324, 199)
        Me.Panel_Attributes.TabIndex = 1
        '
        'Label_AttributesLBL
        '
        Me.Label_AttributesLBL.AutoSize = True
        Me.Label_AttributesLBL.Location = New System.Drawing.Point(4, 4)
        Me.Label_AttributesLBL.Name = "Label_AttributesLBL"
        Me.Label_AttributesLBL.Size = New System.Drawing.Size(54, 13)
        Me.Label_AttributesLBL.TabIndex = 0
        Me.Label_AttributesLBL.Text = "Attributes:"
        '
        'ToolStripContainer3
        '
        '
        'ToolStripContainer3.BottomToolStripPanel
        '
        Me.ToolStripContainer3.BottomToolStripPanel.Controls.Add(Me.ToolStrip6)
        '
        'ToolStripContainer3.ContentPanel
        '
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.DataGridView_TokenAtt)
        Me.ToolStripContainer3.ContentPanel.Size = New System.Drawing.Size(331, 160)
        Me.ToolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer3.LeftToolStripPanelVisible = False
        Me.ToolStripContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer3.Name = "ToolStripContainer3"
        Me.ToolStripContainer3.RightToolStripPanelVisible = False
        Me.ToolStripContainer3.Size = New System.Drawing.Size(331, 210)
        Me.ToolStripContainer3.TabIndex = 0
        Me.ToolStripContainer3.Text = "ToolStripContainer3"
        '
        'ToolStripContainer3.TopToolStripPanel
        '
        Me.ToolStripContainer3.TopToolStripPanel.Controls.Add(Me.ToolStrip3)
        '
        'ToolStrip6
        '
        Me.ToolStrip6.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_TokAttCountLBL, Me.ToolStripLabel_TokAttCount, Me.ToolStripProgressBar_TokenAttribiute})
        Me.ToolStrip6.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip6.Name = "ToolStrip6"
        Me.ToolStrip6.Size = New System.Drawing.Size(170, 25)
        Me.ToolStrip6.TabIndex = 0
        '
        'ToolStripLabel_TokAttCountLBL
        '
        Me.ToolStripLabel_TokAttCountLBL.Name = "ToolStripLabel_TokAttCountLBL"
        Me.ToolStripLabel_TokAttCountLBL.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripLabel_TokAttCountLBL.Text = "Count:"
        '
        'ToolStripLabel_TokAttCount
        '
        Me.ToolStripLabel_TokAttCount.Name = "ToolStripLabel_TokAttCount"
        Me.ToolStripLabel_TokAttCount.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_TokAttCount.Text = "0"
        '
        'ToolStripProgressBar_TokenAttribiute
        '
        Me.ToolStripProgressBar_TokenAttribiute.Name = "ToolStripProgressBar_TokenAttribiute"
        Me.ToolStripProgressBar_TokenAttribiute.Size = New System.Drawing.Size(100, 22)
        '
        'DataGridView_TokenAtt
        '
        Me.DataGridView_TokenAtt.AllowUserToAddRows = False
        Me.DataGridView_TokenAtt.AllowUserToDeleteRows = False
        Me.DataGridView_TokenAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_TokenAtt.ContextMenuStrip = Me.ContextMenuStrip_TokAtt
        Me.DataGridView_TokenAtt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_TokenAtt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView_TokenAtt.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_TokenAtt.Name = "DataGridView_TokenAtt"
        Me.DataGridView_TokenAtt.ReadOnly = True
        Me.DataGridView_TokenAtt.Size = New System.Drawing.Size(331, 160)
        Me.DataGridView_TokenAtt.TabIndex = 0
        '
        'ContextMenuStrip_TokAtt
        '
        Me.ContextMenuStrip_TokAtt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem1, Me.RelateToolStripMenuItem1, Me.DeleteToolStripMenuItem1})
        Me.ContextMenuStrip_TokAtt.Name = "ContextMenuStrip_TokAtt"
        Me.ContextMenuStrip_TokAtt.Size = New System.Drawing.Size(107, 70)
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyValToolStripMenuItem})
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(106, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'CopyValToolStripMenuItem
        '
        Me.CopyValToolStripMenuItem.Name = "CopyValToolStripMenuItem"
        Me.CopyValToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.CopyValToolStripMenuItem.Text = "Copy Val"
        '
        'RelateToolStripMenuItem1
        '
        Me.RelateToolStripMenuItem1.Name = "RelateToolStripMenuItem1"
        Me.RelateToolStripMenuItem1.Size = New System.Drawing.Size(106, 22)
        Me.RelateToolStripMenuItem1.Text = "relate"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(106, 22)
        Me.DeleteToolStripMenuItem1.Text = "delete"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_TokAttFilterLBL, Me.ToolStripLabel_TokAttFilter, Me.ToolStripButton_DelTokenAtt})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(83, 25)
        Me.ToolStrip3.TabIndex = 0
        '
        'ToolStripLabel_TokAttFilterLBL
        '
        Me.ToolStripLabel_TokAttFilterLBL.Name = "ToolStripLabel_TokAttFilterLBL"
        Me.ToolStripLabel_TokAttFilterLBL.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel_TokAttFilterLBL.Text = "Filter:"
        '
        'ToolStripLabel_TokAttFilter
        '
        Me.ToolStripLabel_TokAttFilter.Name = "ToolStripLabel_TokAttFilter"
        Me.ToolStripLabel_TokAttFilter.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel_TokAttFilter.Text = "-"
        '
        'ToolStripButton_DelTokenAtt
        '
        Me.ToolStripButton_DelTokenAtt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_DelTokenAtt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DelTokenAtt.Name = "ToolStripButton_DelTokenAtt"
        Me.ToolStripButton_DelTokenAtt.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_DelTokenAtt.Text = "ToolStripButton2"
        '
        'SplitContainer_TokAttTokRel
        '
        Me.SplitContainer_TokAttTokRel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer_TokAttTokRel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_TokAttTokRel.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_TokAttTokRel.Name = "SplitContainer_TokAttTokRel"
        Me.SplitContainer_TokAttTokRel.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer_TokAttTokRel.Panel1
        '
        Me.SplitContainer_TokAttTokRel.Panel1.Controls.Add(Me.Panel_RelationTypes)
        Me.SplitContainer_TokAttTokRel.Panel1.Controls.Add(Me.Label_RelationTypes)
        '
        'SplitContainer_TokAttTokRel.Panel2
        '
        Me.SplitContainer_TokAttTokRel.Panel2.Controls.Add(Me.ToolStripContainer2)
        Me.SplitContainer_TokAttTokRel.Size = New System.Drawing.Size(369, 445)
        Me.SplitContainer_TokAttTokRel.SplitterDistance = 228
        Me.SplitContainer_TokAttTokRel.TabIndex = 0
        '
        'Panel_RelationTypes
        '
        Me.Panel_RelationTypes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_RelationTypes.Location = New System.Drawing.Point(3, 21)
        Me.Panel_RelationTypes.Name = "Panel_RelationTypes"
        Me.Panel_RelationTypes.Size = New System.Drawing.Size(359, 199)
        Me.Panel_RelationTypes.TabIndex = 3
        '
        'Label_RelationTypes
        '
        Me.Label_RelationTypes.AutoSize = True
        Me.Label_RelationTypes.Location = New System.Drawing.Point(3, 4)
        Me.Label_RelationTypes.Name = "Label_RelationTypes"
        Me.Label_RelationTypes.Size = New System.Drawing.Size(78, 13)
        Me.Label_RelationTypes.TabIndex = 2
        Me.Label_RelationTypes.Text = "RelationTypes:"
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.BottomToolStripPanel
        '
        Me.ToolStripContainer2.BottomToolStripPanel.Controls.Add(Me.ToolStrip4)
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.DataGridView_Relations)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(365, 159)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.LeftToolStripPanelVisible = False
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.RightToolStripPanelVisible = False
        Me.ToolStripContainer2.Size = New System.Drawing.Size(365, 209)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip5)
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_RelCountLBL, Me.ToolStripLabel_RelCount, Me.ToolStripProgressBar_TokenRelation})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(170, 25)
        Me.ToolStrip4.TabIndex = 0
        '
        'ToolStripLabel_RelCountLBL
        '
        Me.ToolStripLabel_RelCountLBL.Name = "ToolStripLabel_RelCountLBL"
        Me.ToolStripLabel_RelCountLBL.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripLabel_RelCountLBL.Text = "Count:"
        '
        'ToolStripLabel_RelCount
        '
        Me.ToolStripLabel_RelCount.Name = "ToolStripLabel_RelCount"
        Me.ToolStripLabel_RelCount.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_RelCount.Text = "0"
        '
        'ToolStripProgressBar_TokenRelation
        '
        Me.ToolStripProgressBar_TokenRelation.Name = "ToolStripProgressBar_TokenRelation"
        Me.ToolStripProgressBar_TokenRelation.Size = New System.Drawing.Size(100, 22)
        '
        'DataGridView_Relations
        '
        Me.DataGridView_Relations.AllowUserToAddRows = False
        Me.DataGridView_Relations.AllowUserToDeleteRows = False
        Me.DataGridView_Relations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Relations.ContextMenuStrip = Me.ContextMenuStrip_TokRel
        Me.DataGridView_Relations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Relations.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Relations.Name = "DataGridView_Relations"
        Me.DataGridView_Relations.ReadOnly = True
        Me.DataGridView_Relations.Size = New System.Drawing.Size(365, 159)
        Me.DataGridView_Relations.TabIndex = 0
        '
        'ContextMenuStrip_TokRel
        '
        Me.ContextMenuStrip_TokRel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.FilterToolStripMenuItem, Me.RelateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip_TokRel.Name = "ContextMenuStrip_TokRel"
        Me.ContextMenuStrip_TokRel.Size = New System.Drawing.Size(107, 92)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetOrderIDToolStripMenuItem, Me.SetRelationTypeToolStripMenuItem, Me.ModuleEditToolStripMenuItem, Me.ModuleMenuToolStripMenuItem, Me.CopyValToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SetOrderIDToolStripMenuItem
        '
        Me.SetOrderIDToolStripMenuItem.Name = "SetOrderIDToolStripMenuItem"
        Me.SetOrderIDToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SetOrderIDToolStripMenuItem.Text = "Set OrderID"
        '
        'SetRelationTypeToolStripMenuItem
        '
        Me.SetRelationTypeToolStripMenuItem.Name = "SetRelationTypeToolStripMenuItem"
        Me.SetRelationTypeToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SetRelationTypeToolStripMenuItem.Text = "Set RelationType"
        '
        'ModuleEditToolStripMenuItem
        '
        Me.ModuleEditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_ModuleEdit})
        Me.ModuleEditToolStripMenuItem.Name = "ModuleEditToolStripMenuItem"
        Me.ModuleEditToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ModuleEditToolStripMenuItem.Text = "x_Module-Edit"
        '
        'ToolStripComboBox_ModuleEdit
        '
        Me.ToolStripComboBox_ModuleEdit.Name = "ToolStripComboBox_ModuleEdit"
        Me.ToolStripComboBox_ModuleEdit.Size = New System.Drawing.Size(121, 23)
        '
        'ModuleMenuToolStripMenuItem
        '
        Me.ModuleMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_ModuleMenu})
        Me.ModuleMenuToolStripMenuItem.Name = "ModuleMenuToolStripMenuItem"
        Me.ModuleMenuToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ModuleMenuToolStripMenuItem.Text = "x_Module-Menu"
        '
        'ToolStripComboBox_ModuleMenu
        '
        Me.ToolStripComboBox_ModuleMenu.Name = "ToolStripComboBox_ModuleMenu"
        Me.ToolStripComboBox_ModuleMenu.Size = New System.Drawing.Size(250, 23)
        '
        'CopyValToolStripMenuItem1
        '
        Me.CopyValToolStripMenuItem1.Name = "CopyValToolStripMenuItem1"
        Me.CopyValToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.CopyValToolStripMenuItem1.Text = "x_Copy Val"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EqualToolStripMenuItem, Me.DifferentToolStripMenuItem, Me.ContainsToolStripMenuItem, Me.GreaterToolStripMenuItem, Me.LessThanToolStripMenuItem, Me.ClearFilterToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.FilterToolStripMenuItem.Text = "Filter"
        '
        'EqualToolStripMenuItem
        '
        Me.EqualToolStripMenuItem.Name = "EqualToolStripMenuItem"
        Me.EqualToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.EqualToolStripMenuItem.Text = "Equal"
        '
        'DifferentToolStripMenuItem
        '
        Me.DifferentToolStripMenuItem.Name = "DifferentToolStripMenuItem"
        Me.DifferentToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DifferentToolStripMenuItem.Text = "Different"
        '
        'ContainsToolStripMenuItem
        '
        Me.ContainsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox_TokRelContains})
        Me.ContainsToolStripMenuItem.Name = "ContainsToolStripMenuItem"
        Me.ContainsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ContainsToolStripMenuItem.Text = "Contains"
        '
        'ToolStripTextBox_TokRelContains
        '
        Me.ToolStripTextBox_TokRelContains.Name = "ToolStripTextBox_TokRelContains"
        Me.ToolStripTextBox_TokRelContains.Size = New System.Drawing.Size(100, 23)
        '
        'GreaterToolStripMenuItem
        '
        Me.GreaterToolStripMenuItem.Name = "GreaterToolStripMenuItem"
        Me.GreaterToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.GreaterToolStripMenuItem.Text = "Greater >"
        '
        'LessThanToolStripMenuItem
        '
        Me.LessThanToolStripMenuItem.Name = "LessThanToolStripMenuItem"
        Me.LessThanToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LessThanToolStripMenuItem.Text = "Less than <"
        '
        'ClearFilterToolStripMenuItem
        '
        Me.ClearFilterToolStripMenuItem.Name = "ClearFilterToolStripMenuItem"
        Me.ClearFilterToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ClearFilterToolStripMenuItem.Text = "Clear Filter"
        '
        'RelateToolStripMenuItem
        '
        Me.RelateToolStripMenuItem.Name = "RelateToolStripMenuItem"
        Me.RelateToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.RelateToolStripMenuItem.Text = "Relate"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.DeleteToolStripMenuItem.Text = "delete"
        '
        'ToolStrip5
        '
        Me.ToolStrip5.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_FilterLBL, Me.ToolStripLabel_Filter, Me.ToolStripButton_DelTokenRel})
        Me.ToolStrip5.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Size = New System.Drawing.Size(83, 25)
        Me.ToolStrip5.TabIndex = 1
        '
        'ToolStripLabel_FilterLBL
        '
        Me.ToolStripLabel_FilterLBL.Name = "ToolStripLabel_FilterLBL"
        Me.ToolStripLabel_FilterLBL.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel_FilterLBL.Text = "Filter:"
        '
        'ToolStripLabel_Filter
        '
        Me.ToolStripLabel_Filter.Name = "ToolStripLabel_Filter"
        Me.ToolStripLabel_Filter.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel_Filter.Text = "-"
        '
        'ToolStripButton_DelTokenRel
        '
        Me.ToolStripButton_DelTokenRel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_DelTokenRel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DelTokenRel.Name = "ToolStripButton_DelTokenRel"
        Me.ToolStripButton_DelTokenRel.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_DelTokenRel.Text = "ToolStripButton1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Types, Me.ToolStripButton_Token, Me.ToolStripButton_Tokentree, Me.ToolStripButton_AttribRel, Me.ToolStripButton_TokenRel, Me.ToolStripButton_Filter, Me.ToolStripSeparator1, Me.ToolStripButton_ModuleView})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(24, 177)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Types
        '
        Me.ToolStripButton_Types.Checked = True
        Me.ToolStripButton_Types.CheckOnClick = True
        Me.ToolStripButton_Types.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton_Types.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Types.Image = Global.Ontolog_Module.My.Resources.Resources.Types_Closed
        Me.ToolStripButton_Types.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Types.Name = "ToolStripButton_Types"
        Me.ToolStripButton_Types.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripButton_Types.Text = "ToolStripButton1"
        Me.ToolStripButton_Types.ToolTipText = "Toggle Typetree"
        '
        'ToolStripButton_Token
        '
        Me.ToolStripButton_Token.Checked = True
        Me.ToolStripButton_Token.CheckOnClick = True
        Me.ToolStripButton_Token.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton_Token.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Token.Image = Global.Ontolog_Module.My.Resources.Resources.Vogelschwarm
        Me.ToolStripButton_Token.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Token.Name = "ToolStripButton_Token"
        Me.ToolStripButton_Token.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripButton_Token.Text = "ToolStripButton2"
        Me.ToolStripButton_Token.ToolTipText = "Toggle Tokenlist"
        '
        'ToolStripButton_Tokentree
        '
        Me.ToolStripButton_Tokentree.CheckOnClick = True
        Me.ToolStripButton_Tokentree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Tokentree.Image = Global.Ontolog_Module.My.Resources.Resources.XSDSchema_SequenceIcon
        Me.ToolStripButton_Tokentree.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Tokentree.Name = "ToolStripButton_Tokentree"
        Me.ToolStripButton_Tokentree.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripButton_Tokentree.Text = "x_Tokentree"
        '
        'ToolStripButton_AttribRel
        '
        Me.ToolStripButton_AttribRel.Checked = True
        Me.ToolStripButton_AttribRel.CheckOnClick = True
        Me.ToolStripButton_AttribRel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton_AttribRel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_AttribRel.Image = Global.Ontolog_Module.My.Resources.Resources.Attributes_bamboo_danny_allen_r
        Me.ToolStripButton_AttribRel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_AttribRel.Name = "ToolStripButton_AttribRel"
        Me.ToolStripButton_AttribRel.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripButton_AttribRel.Text = "ToolStripButton3"
        Me.ToolStripButton_AttribRel.ToolTipText = "Toggle Attributes and Relations"
        '
        'ToolStripButton_TokenRel
        '
        Me.ToolStripButton_TokenRel.Checked = True
        Me.ToolStripButton_TokenRel.CheckOnClick = True
        Me.ToolStripButton_TokenRel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton_TokenRel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_TokenRel.Image = Global.Ontolog_Module.My.Resources.Resources.RelationTypes_gpride_jean_victor_balin_
        Me.ToolStripButton_TokenRel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_TokenRel.Name = "ToolStripButton_TokenRel"
        Me.ToolStripButton_TokenRel.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripButton_TokenRel.Text = "ToolStripButton4"
        Me.ToolStripButton_TokenRel.ToolTipText = "Toggle Token-Relations"
        '
        'ToolStripButton_Filter
        '
        Me.ToolStripButton_Filter.Checked = True
        Me.ToolStripButton_Filter.CheckOnClick = True
        Me.ToolStripButton_Filter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton_Filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Filter.Image = Global.Ontolog_Module.My.Resources.Resources.Procedures
        Me.ToolStripButton_Filter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Filter.Name = "ToolStripButton_Filter"
        Me.ToolStripButton_Filter.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripButton_Filter.Text = "ToolStripButton1"
        Me.ToolStripButton_Filter.ToolTipText = "Toggle Filter"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(22, 6)
        '
        'ToolStripButton_ModuleView
        '
        Me.ToolStripButton_ModuleView.CheckOnClick = True
        Me.ToolStripButton_ModuleView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_ModuleView.Image = CType(resources.GetObject("ToolStripButton_ModuleView.Image"), System.Drawing.Image)
        Me.ToolStripButton_ModuleView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ModuleView.Name = "ToolStripButton_ModuleView"
        Me.ToolStripButton_ModuleView.Size = New System.Drawing.Size(22, 19)
        Me.ToolStripButton_ModuleView.Text = "M"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1401, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ToolsToolStripMenuItem.Text = "&Extras"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'Timer_TokenRelation
        '
        Me.Timer_TokenRelation.Interval = 300
        '
        'Timer_TokenAttribute
        '
        Me.Timer_TokenAttribute.Interval = 300
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1401, 602)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmMain"
        Me.Text = "x_Ontology_Module"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.LeftToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.LeftToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer_Filter_Body.Panel1.ResumeLayout(False)
        Me.SplitContainer_Filter_Body.Panel1.PerformLayout()
        Me.SplitContainer_Filter_Body.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Filter_Body, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Filter_Body.ResumeLayout(False)
        Me.Panel_Filter.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox_FilterDr.ResumeLayout(False)
        Me.GroupBox_FilterDr.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer_TypeToken.Panel1.ResumeLayout(False)
        Me.SplitContainer_TypeToken.Panel1.PerformLayout()
        Me.SplitContainer_TypeToken.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_TypeToken, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_TypeToken.ResumeLayout(False)
        CType(Me.SplitContainer_Token, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Token.ResumeLayout(False)
        Me.SplitContainer_AttribRelTokenRel.Panel1.ResumeLayout(False)
        Me.SplitContainer_AttribRelTokenRel.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_AttribRelTokenRel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_AttribRelTokenRel.ResumeLayout(False)
        Me.SplitContainer_AttribRel.Panel1.ResumeLayout(False)
        Me.SplitContainer_AttribRel.Panel1.PerformLayout()
        Me.SplitContainer_AttribRel.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_AttribRel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_AttribRel.ResumeLayout(False)
        Me.ToolStripContainer3.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer3.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer3.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer3.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer3.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer3.ResumeLayout(False)
        Me.ToolStripContainer3.PerformLayout()
        Me.ToolStrip6.ResumeLayout(False)
        Me.ToolStrip6.PerformLayout()
        CType(Me.DataGridView_TokenAtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_TokAtt.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.SplitContainer_TokAttTokRel.Panel1.ResumeLayout(False)
        Me.SplitContainer_TokAttTokRel.Panel1.PerformLayout()
        Me.SplitContainer_TokAttTokRel.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_TokAttTokRel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_TokAttTokRel.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        CType(Me.DataGridView_Relations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_TokRel.ResumeLayout(False)
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BindingSource_TokenRel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_TokenAtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel_DatabaseLBL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Database As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_TokenAttLBL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_TokenAtt_Attribute As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_TokenAttSeperator As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_TokenAtt_Token As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_RelationLBL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_TokenRelLeft As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Seperator1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_TokenRelRelation As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Seperator2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_TokenRelRight As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_RelationDoneLBL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_RelationDone As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer_Filter_Body As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel_Filter As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBox_NameRelationType As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_GUIDRelationType As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_NameType As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_GUIDType As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_NameToken As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_GUIDToken As System.Windows.Forms.TextBox
    Friend WithEvents Label_NameRelationTypeLBL As System.Windows.Forms.Label
    Friend WithEvents Label_GUIDRelationLBL As System.Windows.Forms.Label
    Friend WithEvents Label_NameTypeLBL As System.Windows.Forms.Label
    Friend WithEvents Label_GUIDTypeLBL As System.Windows.Forms.Label
    Friend WithEvents Label_NameTokenLBL As System.Windows.Forms.Label
    Friend WithEvents Label_GUIDTokenLBL As System.Windows.Forms.Label
    Friend WithEvents TextBox_NameTypeOther As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_GUIDTypeOther As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_NameTokenOther As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_GUIDTokenOther As System.Windows.Forms.TextBox
    Friend WithEvents Label_NameTypeOtherLBL As System.Windows.Forms.Label
    Friend WithEvents Label_GUIDTypeOtherLBL As System.Windows.Forms.Label
    Friend WithEvents Label_NameTokenOtherLBL As System.Windows.Forms.Label
    Friend WithEvents Label_GUIDTokenOtherLBL As System.Windows.Forms.Label
    Friend WithEvents CheckBox_Filter As System.Windows.Forms.CheckBox
    Friend WithEvents Button_SaveFilter As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Filter As System.Windows.Forms.ComboBox
    Friend WithEvents Label_FilterStd As System.Windows.Forms.Label
    Friend WithEvents Button_Filter As System.Windows.Forms.Button
    Friend WithEvents Button_GetData As System.Windows.Forms.Button
    Friend WithEvents GroupBox_FilterDr As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton_RightLeft As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_LeftRight As System.Windows.Forms.RadioButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer_TypeToken As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer_Token As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer_AttribRelTokenRel As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer_AttribRel As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel_Attributes As System.Windows.Forms.Panel
    Friend WithEvents Label_AttributesLBL As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer3 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip6 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_TokAttCountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_TokAttCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripProgressBar_TokenAttribiute As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents DataGridView_TokenAtt As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip_TokAtt As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyValToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_TokAttFilterLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_TokAttFilter As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton_DelTokenAtt As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer_TokAttTokRel As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel_RelationTypes As System.Windows.Forms.Panel
    Friend WithEvents Label_RelationTypes As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_RelCountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_RelCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripProgressBar_TokenRelation As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents DataGridView_Relations As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip_TokRel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetOrderIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetRelationTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModuleEditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox_ModuleEdit As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ModuleMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox_ModuleMenu As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents CopyValToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EqualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DifferentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContainsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox_TokRelContains As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GreaterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LessThanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip5 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_FilterLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Filter As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton_DelTokenRel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Types As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Token As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Tokentree As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_AttribRel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_TokenRel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Filter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_ModuleView As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingSource_TokenRel As System.Windows.Forms.BindingSource
    Friend WithEvents Timer_TokenRelation As System.Windows.Forms.Timer
    Friend WithEvents Timer_TokenAttribute As System.Windows.Forms.Timer
    Friend WithEvents BindingSource_TokenAtt As System.Windows.Forms.BindingSource

End Class
