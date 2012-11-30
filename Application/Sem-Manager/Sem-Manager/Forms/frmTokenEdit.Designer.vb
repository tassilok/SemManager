<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTokenEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTokenEdit))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FilefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuleViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox_ModuleEdit = New System.Windows.Forms.ToolStripComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_DB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_VersionLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Version = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Nav_First = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Nav_Previous = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Nav_Next = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Nav_Last = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_PosCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Token = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_GUID = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_GUID = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_Name = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_Name = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Timer_Name = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilefToolStripMenuItem, Me.EditfToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilefToolStripMenuItem
        '
        Me.FilefToolStripMenuItem.Name = "FilefToolStripMenuItem"
        Me.FilefToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FilefToolStripMenuItem.Text = "x_File"
        '
        'EditfToolStripMenuItem
        '
        Me.EditfToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.EditfToolStripMenuItem.Name = "EditfToolStripMenuItem"
        Me.EditfToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditfToolStripMenuItem.Text = "x_Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.DeleteToolStripMenuItem.Text = "x_delete"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModuleViewToolStripMenuItem, Me.ToolStripComboBox_ModuleEdit})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ToolsToolStripMenuItem.Text = "x_Tools"
        '
        'ModuleViewToolStripMenuItem
        '
        Me.ModuleViewToolStripMenuItem.Checked = True
        Me.ModuleViewToolStripMenuItem.CheckOnClick = True
        Me.ModuleViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ModuleViewToolStripMenuItem.Name = "ModuleViewToolStripMenuItem"
        Me.ModuleViewToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ModuleViewToolStripMenuItem.Text = "Module-View"
        '
        'ToolStripComboBox_ModuleEdit
        '
        Me.ToolStripComboBox_ModuleEdit.Name = "ToolStripComboBox_ModuleEdit"
        Me.ToolStripComboBox_ModuleEdit.Size = New System.Drawing.Size(121, 23)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_DB, Me.ToolStripStatusLabel_VersionLbl, Me.ToolStripStatusLabel_Version})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 417)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(864, 25)
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
        Me.ToolStripStatusLabel_DB.Size = New System.Drawing.Size(51, 20)
        Me.ToolStripStatusLabel_DB.Text = "DB_f"
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
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(864, 393)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Nav_First, Me.ToolStripButton_Nav_Previous, Me.ToolStripButton_Nav_Next, Me.ToolStripButton_Nav_Last, Me.ToolStripSeparator1, Me.ToolStripLabel_PosCount, Me.ToolStripLabel_Token})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 368)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(864, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton_Nav_First
        '
        Me.ToolStripButton_Nav_First.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Nav_First.Image = Global.Sem_Manager.My.Resources.Resources.pulsante_01_architetto_f_01_First
        Me.ToolStripButton_Nav_First.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Nav_First.Name = "ToolStripButton_Nav_First"
        Me.ToolStripButton_Nav_First.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Nav_First.Text = "ToolStripButton1"
        '
        'ToolStripButton_Nav_Previous
        '
        Me.ToolStripButton_Nav_Previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Nav_Previous.Image = Global.Sem_Manager.My.Resources.Resources.pulsante_01_architetto_f_01
        Me.ToolStripButton_Nav_Previous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Nav_Previous.Name = "ToolStripButton_Nav_Previous"
        Me.ToolStripButton_Nav_Previous.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Nav_Previous.Text = "ToolStripButton2"
        '
        'ToolStripButton_Nav_Next
        '
        Me.ToolStripButton_Nav_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Nav_Next.Image = Global.Sem_Manager.My.Resources.Resources.pulsante_02_architetto_f_01
        Me.ToolStripButton_Nav_Next.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Nav_Next.Name = "ToolStripButton_Nav_Next"
        Me.ToolStripButton_Nav_Next.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Nav_Next.Text = "ToolStripButton3"
        '
        'ToolStripButton_Nav_Last
        '
        Me.ToolStripButton_Nav_Last.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Nav_Last.Image = Global.Sem_Manager.My.Resources.Resources.pulsante_02_architetto_f_01_Last
        Me.ToolStripButton_Nav_Last.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Nav_Last.Name = "ToolStripButton_Nav_Last"
        Me.ToolStripButton_Nav_Last.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Nav_Last.Text = "ToolStripButton4"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_PosCount
        '
        Me.ToolStripLabel_PosCount.Name = "ToolStripLabel_PosCount"
        Me.ToolStripLabel_PosCount.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripLabel_PosCount.Text = "0/0"
        '
        'ToolStripLabel_Token
        '
        Me.ToolStripLabel_Token.Name = "ToolStripLabel_Token"
        Me.ToolStripLabel_Token.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel_Token.Text = "x_Token"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(858, 337)
        Me.SplitContainer1.SplitterDistance = 285
        Me.SplitContainer1.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_GUID, Me.ToolStripTextBox_GUID, Me.ToolStripSeparator2, Me.ToolStripLabel_Name, Me.ToolStripTextBox_Name, Me.ToolStripSeparator3})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(864, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel_GUID
        '
        Me.ToolStripLabel_GUID.Name = "ToolStripLabel_GUID"
        Me.ToolStripLabel_GUID.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel_GUID.Text = "x_GUID:"
        '
        'ToolStripTextBox_GUID
        '
        Me.ToolStripTextBox_GUID.MaxLength = 36
        Me.ToolStripTextBox_GUID.Name = "ToolStripTextBox_GUID"
        Me.ToolStripTextBox_GUID.ReadOnly = True
        Me.ToolStripTextBox_GUID.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_Name
        '
        Me.ToolStripLabel_Name.Name = "ToolStripLabel_Name"
        Me.ToolStripLabel_Name.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel_Name.Text = "x_Name:"
        '
        'ToolStripTextBox_Name
        '
        Me.ToolStripTextBox_Name.MaxLength = 255
        Me.ToolStripTextBox_Name.Name = "ToolStripTextBox_Name"
        Me.ToolStripTextBox_Name.ReadOnly = True
        Me.ToolStripTextBox_Name.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Timer_Name
        '
        Me.Timer_Name.Interval = 300
        '
        'frmTokenEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 442)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTokenEdit"
        Me.Text = "frmTokenEdit"
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
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FilefToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel_DB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_VersionLbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Version As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Nav_First As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Nav_Previous As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Nav_Next As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Nav_Last As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_PosCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Token As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_GUID As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_GUID As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_Name As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Name As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Timer_Name As System.Windows.Forms.Timer
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModuleViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripComboBox_ModuleEdit As System.Windows.Forms.ToolStripComboBox
End Class
