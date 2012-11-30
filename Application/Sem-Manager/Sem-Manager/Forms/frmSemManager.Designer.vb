<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSemManager))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox_Modules = New System.Windows.Forms.ToolStripComboBox()
        Me.ConfigureActivationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuleViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox_Databases = New System.Windows.Forms.ToolStripComboBox()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_DB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_Search = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_Search = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_Search = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(704, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FileToolStripMenuItem.Text = "x_File"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_Modules, Me.ConfigureActivationToolStripMenuItem, Me.ModuleViewToolStripMenuItem, Me.SelectDatabaseToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ToolsToolStripMenuItem.Text = "x_Tools"
        '
        'ToolStripComboBox_Modules
        '
        Me.ToolStripComboBox_Modules.Name = "ToolStripComboBox_Modules"
        Me.ToolStripComboBox_Modules.Size = New System.Drawing.Size(250, 23)
        '
        'ConfigureActivationToolStripMenuItem
        '
        Me.ConfigureActivationToolStripMenuItem.Name = "ConfigureActivationToolStripMenuItem"
        Me.ConfigureActivationToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.ConfigureActivationToolStripMenuItem.Text = "x_Configure Activation"
        '
        'ModuleViewToolStripMenuItem
        '
        Me.ModuleViewToolStripMenuItem.Checked = True
        Me.ModuleViewToolStripMenuItem.CheckOnClick = True
        Me.ModuleViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ModuleViewToolStripMenuItem.Name = "ModuleViewToolStripMenuItem"
        Me.ModuleViewToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.ModuleViewToolStripMenuItem.Text = "x_ModuleView"
        '
        'SelectDatabaseToolStripMenuItem
        '
        Me.SelectDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_Databases})
        Me.SelectDatabaseToolStripMenuItem.Name = "SelectDatabaseToolStripMenuItem"
        Me.SelectDatabaseToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.SelectDatabaseToolStripMenuItem.Text = "x_select Database"
        '
        'ToolStripComboBox_Databases
        '
        Me.ToolStripComboBox_Databases.Name = "ToolStripComboBox_Databases"
        Me.ToolStripComboBox_Databases.Size = New System.Drawing.Size(121, 23)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.HelpToolStripMenuItem.Text = "x_Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AboutToolStripMenuItem.Text = "x_About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_DB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 429)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(704, 25)
        Me.StatusStrip1.TabIndex = 1
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(704, 405)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Search, Me.ToolStripTextBox_Search, Me.ToolStripButton_Search})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(704, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel_Search
        '
        Me.ToolStripLabel_Search.Name = "ToolStripLabel_Search"
        Me.ToolStripLabel_Search.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel_Search.Text = "x_Search:"
        '
        'ToolStripTextBox_Search
        '
        Me.ToolStripTextBox_Search.Name = "ToolStripTextBox_Search"
        Me.ToolStripTextBox_Search.Size = New System.Drawing.Size(300, 25)
        '
        'ToolStripButton_Search
        '
        Me.ToolStripButton_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Search.Image = CType(resources.GetObject("ToolStripButton_Search.Image"), System.Drawing.Image)
        Me.ToolStripButton_Search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Search.Name = "ToolStripButton_Search"
        Me.ToolStripButton_Search.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton_Search.Text = "x_Search"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(698, 374)
        Me.SplitContainer1.SplitterDistance = 232
        Me.SplitContainer1.TabIndex = 1
        '
        'frmSemManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 454)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSemManager"
        Me.Text = "x_Sem-Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripStatusLabel_DB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox_Modules As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ConfigureActivationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModuleViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox_Databases As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel_Search As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Search As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton_Search As System.Windows.Forms.ToolStripButton

End Class
