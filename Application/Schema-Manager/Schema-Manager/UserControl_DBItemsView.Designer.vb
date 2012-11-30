<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_DBItemsView
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.ToolStripContainer3 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel_CountParametersLbl = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel_CountParameters = New System.Windows.Forms.ToolStripLabel
        Me.DataGridView_Parameters = New System.Windows.Forms.DataGridView
        Me.Label_Parameters = New System.Windows.Forms.Label
        Me.ToolStripContainer4 = New System.Windows.Forms.ToolStripContainer
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage_Data = New System.Windows.Forms.TabPage
        Me.Label_Script = New System.Windows.Forms.Label
        Me.TextBox_Script = New System.Windows.Forms.TextBox
        Me.TextBox_CreationDate = New System.Windows.Forms.TextBox
        Me.Label_Created = New System.Windows.Forms.Label
        Me.TabPage_history = New System.Windows.Forms.TabPage
        Me.DataGridView_ScriptHistory = New System.Windows.Forms.DataGridView
        Me.TabPage_Process = New System.Windows.Forms.TabPage
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton_newDefinition = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton_EditScript = New System.Windows.Forms.ToolStripButton
        Me.BindingSource_Parameters = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_ScriptHistory = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage_Requests = New System.Windows.Forms.TabPage
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.ToolStripContainer3.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer3.ContentPanel.SuspendLayout()
        Me.ToolStripContainer3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.DataGridView_Parameters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer4.ContentPanel.SuspendLayout()
        Me.ToolStripContainer4.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Data.SuspendLayout()
        Me.TabPage_history.SuspendLayout()
        CType(Me.DataGridView_ScriptHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.BindingSource_Parameters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_ScriptHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.ToolStripContainer3)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.ToolStripContainer4)
        Me.SplitContainer4.Size = New System.Drawing.Size(580, 448)
        Me.SplitContainer4.SplitterDistance = 300
        Me.SplitContainer4.TabIndex = 1
        '
        'ToolStripContainer3
        '
        '
        'ToolStripContainer3.BottomToolStripPanel
        '
        Me.ToolStripContainer3.BottomToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStripContainer3.ContentPanel
        '
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.DataGridView_Parameters)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.Label_Parameters)
        Me.ToolStripContainer3.ContentPanel.Size = New System.Drawing.Size(296, 419)
        Me.ToolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer3.LeftToolStripPanelVisible = False
        Me.ToolStripContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer3.Name = "ToolStripContainer3"
        Me.ToolStripContainer3.RightToolStripPanelVisible = False
        Me.ToolStripContainer3.Size = New System.Drawing.Size(296, 444)
        Me.ToolStripContainer3.TabIndex = 17
        Me.ToolStripContainer3.Text = "ToolStripContainer3"
        Me.ToolStripContainer3.TopToolStripPanelVisible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountParametersLbl, Me.ToolStripLabel_CountParameters})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(104, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_CountParametersLbl
        '
        Me.ToolStripLabel_CountParametersLbl.Name = "ToolStripLabel_CountParametersLbl"
        Me.ToolStripLabel_CountParametersLbl.Size = New System.Drawing.Size(79, 22)
        Me.ToolStripLabel_CountParametersLbl.Text = "x_Parameters:"
        '
        'ToolStripLabel_CountParameters
        '
        Me.ToolStripLabel_CountParameters.Name = "ToolStripLabel_CountParameters"
        Me.ToolStripLabel_CountParameters.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_CountParameters.Text = "0"
        '
        'DataGridView_Parameters
        '
        Me.DataGridView_Parameters.AllowUserToAddRows = False
        Me.DataGridView_Parameters.AllowUserToDeleteRows = False
        Me.DataGridView_Parameters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Parameters.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Parameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Parameters.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_Parameters.Location = New System.Drawing.Point(3, 30)
        Me.DataGridView_Parameters.Name = "DataGridView_Parameters"
        Me.DataGridView_Parameters.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Parameters.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_Parameters.Size = New System.Drawing.Size(290, 386)
        Me.DataGridView_Parameters.TabIndex = 15
        '
        'Label_Parameters
        '
        Me.Label_Parameters.AutoSize = True
        Me.Label_Parameters.Location = New System.Drawing.Point(3, 9)
        Me.Label_Parameters.Name = "Label_Parameters"
        Me.Label_Parameters.Size = New System.Drawing.Size(74, 13)
        Me.Label_Parameters.TabIndex = 14
        Me.Label_Parameters.Text = "x_Parameters:"
        '
        'ToolStripContainer4
        '
        '
        'ToolStripContainer4.ContentPanel
        '
        Me.ToolStripContainer4.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer4.ContentPanel.Size = New System.Drawing.Size(272, 419)
        Me.ToolStripContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer4.LeftToolStripPanelVisible = False
        Me.ToolStripContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer4.Name = "ToolStripContainer4"
        Me.ToolStripContainer4.RightToolStripPanelVisible = False
        Me.ToolStripContainer4.Size = New System.Drawing.Size(272, 444)
        Me.ToolStripContainer4.TabIndex = 1
        Me.ToolStripContainer4.Text = "ToolStripContainer4"
        '
        'ToolStripContainer4.TopToolStripPanel
        '
        Me.ToolStripContainer4.TopToolStripPanel.Controls.Add(Me.ToolStrip3)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Data)
        Me.TabControl1.Controls.Add(Me.TabPage_Requests)
        Me.TabControl1.Controls.Add(Me.TabPage_history)
        Me.TabControl1.Controls.Add(Me.TabPage_Process)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(272, 419)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Data
        '
        Me.TabPage_Data.Controls.Add(Me.Label_Script)
        Me.TabPage_Data.Controls.Add(Me.TextBox_Script)
        Me.TabPage_Data.Controls.Add(Me.TextBox_CreationDate)
        Me.TabPage_Data.Controls.Add(Me.Label_Created)
        Me.TabPage_Data.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Data.Name = "TabPage_Data"
        Me.TabPage_Data.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Data.Size = New System.Drawing.Size(264, 393)
        Me.TabPage_Data.TabIndex = 0
        Me.TabPage_Data.Text = "x_Data"
        Me.TabPage_Data.UseVisualStyleBackColor = True
        '
        'Label_Script
        '
        Me.Label_Script.AutoSize = True
        Me.Label_Script.Location = New System.Drawing.Point(3, 42)
        Me.Label_Script.Name = "Label_Script"
        Me.Label_Script.Size = New System.Drawing.Size(93, 13)
        Me.Label_Script.TabIndex = 24
        Me.Label_Script.Text = "x_Script (Creation)"
        '
        'TextBox_Script
        '
        Me.TextBox_Script.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Script.Location = New System.Drawing.Point(2, 58)
        Me.TextBox_Script.Multiline = True
        Me.TextBox_Script.Name = "TextBox_Script"
        Me.TextBox_Script.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Script.Size = New System.Drawing.Size(259, 329)
        Me.TextBox_Script.TabIndex = 23
        '
        'TextBox_CreationDate
        '
        Me.TextBox_CreationDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_CreationDate.Location = New System.Drawing.Point(2, 19)
        Me.TextBox_CreationDate.Name = "TextBox_CreationDate"
        Me.TextBox_CreationDate.ReadOnly = True
        Me.TextBox_CreationDate.Size = New System.Drawing.Size(260, 20)
        Me.TextBox_CreationDate.TabIndex = 22
        '
        'Label_Created
        '
        Me.Label_Created.AutoSize = True
        Me.Label_Created.Location = New System.Drawing.Point(3, 3)
        Me.Label_Created.Name = "Label_Created"
        Me.Label_Created.Size = New System.Drawing.Size(84, 13)
        Me.Label_Created.TabIndex = 21
        Me.Label_Created.Text = "x_Create (Date):"
        '
        'TabPage_history
        '
        Me.TabPage_history.Controls.Add(Me.DataGridView_ScriptHistory)
        Me.TabPage_history.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_history.Name = "TabPage_history"
        Me.TabPage_history.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_history.Size = New System.Drawing.Size(264, 393)
        Me.TabPage_history.TabIndex = 1
        Me.TabPage_history.Text = "x_History"
        Me.TabPage_history.UseVisualStyleBackColor = True
        '
        'DataGridView_ScriptHistory
        '
        Me.DataGridView_ScriptHistory.AllowUserToAddRows = False
        Me.DataGridView_ScriptHistory.AllowUserToDeleteRows = False
        Me.DataGridView_ScriptHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ScriptHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_ScriptHistory.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView_ScriptHistory.Name = "DataGridView_ScriptHistory"
        Me.DataGridView_ScriptHistory.ReadOnly = True
        Me.DataGridView_ScriptHistory.Size = New System.Drawing.Size(258, 387)
        Me.DataGridView_ScriptHistory.TabIndex = 0
        '
        'TabPage_Process
        '
        Me.TabPage_Process.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Process.Name = "TabPage_Process"
        Me.TabPage_Process.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Process.Size = New System.Drawing.Size(264, 393)
        Me.TabPage_Process.TabIndex = 2
        Me.TabPage_Process.Text = "x_Process"
        Me.TabPage_Process.UseVisualStyleBackColor = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_newDefinition, Me.ToolStripButton_EditScript})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(58, 25)
        Me.ToolStrip3.TabIndex = 0
        '
        'ToolStripButton_newDefinition
        '
        Me.ToolStripButton_newDefinition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_newDefinition.Image = Global.Schema_Manager.My.Resources.Resources.b_plus
        Me.ToolStripButton_newDefinition.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_newDefinition.Name = "ToolStripButton_newDefinition"
        Me.ToolStripButton_newDefinition.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_newDefinition.Text = "ToolStripButton1"
        '
        'ToolStripButton_EditScript
        '
        Me.ToolStripButton_EditScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_EditScript.Image = Global.Schema_Manager.My.Resources.Resources.bb_txt_
        Me.ToolStripButton_EditScript.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_EditScript.Name = "ToolStripButton_EditScript"
        Me.ToolStripButton_EditScript.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_EditScript.Text = "ToolStripButton2"
        '
        'TabPage_Requests
        '
        Me.TabPage_Requests.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Requests.Name = "TabPage_Requests"
        Me.TabPage_Requests.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Requests.Size = New System.Drawing.Size(264, 393)
        Me.TabPage_Requests.TabIndex = 3
        Me.TabPage_Requests.Text = "x_Requests"
        Me.TabPage_Requests.UseVisualStyleBackColor = True
        '
        'UserControl_DBItemsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer4)
        Me.Name = "UserControl_DBItemsView"
        Me.Size = New System.Drawing.Size(580, 448)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.ToolStripContainer3.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer3.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer3.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer3.ContentPanel.PerformLayout()
        Me.ToolStripContainer3.ResumeLayout(False)
        Me.ToolStripContainer3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.DataGridView_Parameters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer4.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer4.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer4.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer4.ResumeLayout(False)
        Me.ToolStripContainer4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Data.ResumeLayout(False)
        Me.TabPage_Data.PerformLayout()
        Me.TabPage_history.ResumeLayout(False)
        CType(Me.DataGridView_ScriptHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.BindingSource_Parameters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_ScriptHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer3 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountParametersLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_CountParameters As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_Parameters As System.Windows.Forms.DataGridView
    Friend WithEvents Label_Parameters As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer4 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_newDefinition As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingSource_Parameters As System.Windows.Forms.BindingSource
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Data As System.Windows.Forms.TabPage
    Friend WithEvents Label_Script As System.Windows.Forms.Label
    Friend WithEvents TextBox_Script As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_CreationDate As System.Windows.Forms.TextBox
    Friend WithEvents Label_Created As System.Windows.Forms.Label
    Friend WithEvents TabPage_history As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView_ScriptHistory As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_ScriptHistory As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripButton_EditScript As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage_Process As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Requests As System.Windows.Forms.TabPage

End Class
