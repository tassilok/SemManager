<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevelopmentStructure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevelopmentStructure))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Apply = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label_Type_And_Validity = New System.Windows.Forms.Label()
        Me.ComboBox_Type = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Validity = New System.Windows.Forms.ComboBox()
        Me.Label_Parameter = New System.Windows.Forms.Label()
        Me.Panel_Name = New System.Windows.Forms.Panel()
        Me.Panel_TypeValidity = New System.Windows.Forms.Panel()
        Me.DataGridView_Parameters = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_Parameters = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewParameterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Handles = New System.Windows.Forms.TextBox()
        Me.Button_SetHandling = New System.Windows.Forms.Button()
        Me.Timer_TestName = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource_Parameters = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer_TestTypeValidity = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Test = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView_Parameters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_Parameters.SuspendLayout()
        CType(Me.BindingSource_Parameters, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(768, 338)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(768, 363)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Apply, Me.ToolStripButton_Close})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(114, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Apply
        '
        Me.ToolStripButton_Apply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Apply.Enabled = False
        Me.ToolStripButton_Apply.Image = CType(resources.GetObject("ToolStripButton_Apply.Image"), System.Drawing.Image)
        Me.ToolStripButton_Apply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Apply.Name = "ToolStripButton_Apply"
        Me.ToolStripButton_Apply.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton_Apply.Text = "x_Apply"
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Name, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Name, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Type_And_Validity, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_Type, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_Validity, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Parameter, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_Name, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_TypeValidity, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView_Parameters, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Handles, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button_SetHandling, 3, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(768, 338)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Location = New System.Drawing.Point(3, 5)
        Me.Label_Name.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(83, 13)
        Me.Label_Name.TabIndex = 0
        Me.Label_Name.Text = "x_Beziechnung:"
        '
        'TextBox_Name
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox_Name, 2)
        Me.TextBox_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Name.Location = New System.Drawing.Point(150, 3)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(582, 20)
        Me.TextBox_Name.TabIndex = 1
        '
        'Label_Type_And_Validity
        '
        Me.Label_Type_And_Validity.AutoSize = True
        Me.Label_Type_And_Validity.Location = New System.Drawing.Point(3, 30)
        Me.Label_Type_And_Validity.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label_Type_And_Validity.Name = "Label_Type_And_Validity"
        Me.Label_Type_And_Validity.Size = New System.Drawing.Size(88, 13)
        Me.Label_Type_And_Validity.TabIndex = 3
        Me.Label_Type_And_Validity.Text = "x_Typ/Gültigkeit:"
        '
        'ComboBox_Type
        '
        Me.ComboBox_Type.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox_Type.FormattingEnabled = True
        Me.ComboBox_Type.Location = New System.Drawing.Point(150, 28)
        Me.ComboBox_Type.Name = "ComboBox_Type"
        Me.ComboBox_Type.Size = New System.Drawing.Size(288, 21)
        Me.ComboBox_Type.TabIndex = 4
        '
        'ComboBox_Validity
        '
        Me.ComboBox_Validity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox_Validity.FormattingEnabled = True
        Me.ComboBox_Validity.Location = New System.Drawing.Point(444, 28)
        Me.ComboBox_Validity.Name = "ComboBox_Validity"
        Me.ComboBox_Validity.Size = New System.Drawing.Size(288, 21)
        Me.ComboBox_Validity.TabIndex = 5
        '
        'Label_Parameter
        '
        Me.Label_Parameter.AutoSize = True
        Me.Label_Parameter.Location = New System.Drawing.Point(3, 55)
        Me.Label_Parameter.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label_Parameter.Name = "Label_Parameter"
        Me.Label_Parameter.Size = New System.Drawing.Size(74, 13)
        Me.Label_Parameter.TabIndex = 7
        Me.Label_Parameter.Text = "x_Parameters:"
        '
        'Panel_Name
        '
        Me.Panel_Name.Location = New System.Drawing.Point(738, 3)
        Me.Panel_Name.Name = "Panel_Name"
        Me.Panel_Name.Size = New System.Drawing.Size(22, 19)
        Me.Panel_Name.TabIndex = 10
        '
        'Panel_TypeValidity
        '
        Me.Panel_TypeValidity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_TypeValidity.Location = New System.Drawing.Point(738, 28)
        Me.Panel_TypeValidity.Name = "Panel_TypeValidity"
        Me.Panel_TypeValidity.Size = New System.Drawing.Size(27, 19)
        Me.Panel_TypeValidity.TabIndex = 11
        '
        'DataGridView_Parameters
        '
        Me.DataGridView_Parameters.AllowUserToAddRows = False
        Me.DataGridView_Parameters.AllowUserToDeleteRows = False
        Me.DataGridView_Parameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.DataGridView_Parameters, 2)
        Me.DataGridView_Parameters.ContextMenuStrip = Me.ContextMenuStrip_Parameters
        Me.DataGridView_Parameters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Parameters.Location = New System.Drawing.Point(150, 53)
        Me.DataGridView_Parameters.Name = "DataGridView_Parameters"
        Me.DataGridView_Parameters.ReadOnly = True
        Me.DataGridView_Parameters.Size = New System.Drawing.Size(582, 257)
        Me.DataGridView_Parameters.TabIndex = 12
        '
        'ContextMenuStrip_Parameters
        '
        Me.ContextMenuStrip_Parameters.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewParameterToolStripMenuItem, Me.ChangeToolStripMenuItem})
        Me.ContextMenuStrip_Parameters.Name = "ContextMenuStrip_Parameters"
        Me.ContextMenuStrip_Parameters.Size = New System.Drawing.Size(164, 48)
        '
        'NewParameterToolStripMenuItem
        '
        Me.NewParameterToolStripMenuItem.Name = "NewParameterToolStripMenuItem"
        Me.NewParameterToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.NewParameterToolStripMenuItem.Text = "x_new Parameter"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ChangeToolStripMenuItem.Text = "x_Change"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 318)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "x_Handles:"
        '
        'TextBox_Handles
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox_Handles, 2)
        Me.TextBox_Handles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Handles.Location = New System.Drawing.Point(150, 316)
        Me.TextBox_Handles.Name = "TextBox_Handles"
        Me.TextBox_Handles.ReadOnly = True
        Me.TextBox_Handles.Size = New System.Drawing.Size(582, 20)
        Me.TextBox_Handles.TabIndex = 14
        '
        'Button_SetHandling
        '
        Me.Button_SetHandling.Location = New System.Drawing.Point(738, 316)
        Me.Button_SetHandling.Name = "Button_SetHandling"
        Me.Button_SetHandling.Size = New System.Drawing.Size(25, 19)
        Me.Button_SetHandling.TabIndex = 15
        Me.Button_SetHandling.Text = "..."
        Me.Button_SetHandling.UseVisualStyleBackColor = True
        '
        'Timer_TestName
        '
        Me.Timer_TestName.Interval = 500
        '
        'Timer_TestTypeValidity
        '
        Me.Timer_TestTypeValidity.Interval = 500
        '
        'Timer_Test
        '
        Me.Timer_Test.Interval = 200
        '
        'frmDevelopmentStructure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 363)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDevelopmentStructure"
        Me.Text = "frmDevelopmentStructure"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView_Parameters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_Parameters.ResumeLayout(False)
        CType(Me.BindingSource_Parameters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Apply As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_Name As System.Windows.Forms.Label
    Friend WithEvents TextBox_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label_Type_And_Validity As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Type As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Validity As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Parameter As System.Windows.Forms.Label
    Friend WithEvents Panel_Name As System.Windows.Forms.Panel
    Friend WithEvents Timer_TestName As System.Windows.Forms.Timer
    Friend WithEvents BindingSource_Parameters As System.Windows.Forms.BindingSource
    Friend WithEvents Panel_TypeValidity As System.Windows.Forms.Panel
    Friend WithEvents Timer_TestTypeValidity As System.Windows.Forms.Timer
    Friend WithEvents Timer_Test As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip_Parameters As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewParameterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView_Parameters As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Handles As System.Windows.Forms.TextBox
    Friend WithEvents Button_SetHandling As System.Windows.Forms.Button
End Class
