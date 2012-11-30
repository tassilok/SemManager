<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelationTypeEdit
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelationTypeEdit))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label_Token = New System.Windows.Forms.Label
        Me.DataGridView_Token = New System.Windows.Forms.DataGridView
        Me.Label_Types = New System.Windows.Forms.Label
        Me.DataGridView_Type = New System.Windows.Forms.DataGridView
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel_Name = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox_Name = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel_GUID = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox_GUID = New System.Windows.Forms.ToolStripTextBox
        Me.BindingSource_Token = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_Type = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer_RelationType = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView_Token, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Type, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.BindingSource_Token, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Type, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(654, 340)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(654, 390)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Close})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(48, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Close
        '
        Me.ToolStripButton_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Close.Image = CType(resources.GetObject("ToolStripButton_Close.Image"), System.Drawing.Image)
        Me.ToolStripButton_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
        Me.ToolStripButton_Close.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripButton_Close.Text = "OK_f"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_Token)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView_Token)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label_Types)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView_Type)
        Me.SplitContainer1.Size = New System.Drawing.Size(654, 340)
        Me.SplitContainer1.SplitterDistance = 153
        Me.SplitContainer1.TabIndex = 0
        '
        'Label_Token
        '
        Me.Label_Token.AutoSize = True
        Me.Label_Token.Location = New System.Drawing.Point(3, 2)
        Me.Label_Token.Name = "Label_Token"
        Me.Label_Token.Size = New System.Drawing.Size(50, 13)
        Me.Label_Token.TabIndex = 1
        Me.Label_Token.Text = "Token_f:"
        '
        'DataGridView_Token
        '
        Me.DataGridView_Token.AllowUserToAddRows = False
        Me.DataGridView_Token.AllowUserToDeleteRows = False
        Me.DataGridView_Token.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Token.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Token.Location = New System.Drawing.Point(3, 26)
        Me.DataGridView_Token.Name = "DataGridView_Token"
        Me.DataGridView_Token.ReadOnly = True
        Me.DataGridView_Token.Size = New System.Drawing.Size(644, 120)
        Me.DataGridView_Token.TabIndex = 0
        '
        'Label_Types
        '
        Me.Label_Types.AutoSize = True
        Me.Label_Types.Location = New System.Drawing.Point(5, 1)
        Me.Label_Types.Name = "Label_Types"
        Me.Label_Types.Size = New System.Drawing.Size(48, 13)
        Me.Label_Types.TabIndex = 2
        Me.Label_Types.Text = "Types_f:"
        '
        'DataGridView_Type
        '
        Me.DataGridView_Type.AllowUserToAddRows = False
        Me.DataGridView_Type.AllowUserToDeleteRows = False
        Me.DataGridView_Type.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Type.Location = New System.Drawing.Point(3, 24)
        Me.DataGridView_Type.Name = "DataGridView_Type"
        Me.DataGridView_Type.ReadOnly = True
        Me.DataGridView_Type.Size = New System.Drawing.Size(644, 152)
        Me.DataGridView_Type.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Name, Me.ToolStripTextBox_Name, Me.ToolStripSeparator1, Me.ToolStripLabel_GUID, Me.ToolStripTextBox_GUID})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(619, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_Name
        '
        Me.ToolStripLabel_Name.Name = "ToolStripLabel_Name"
        Me.ToolStripLabel_Name.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel_Name.Text = "Name_f:"
        '
        'ToolStripTextBox_Name
        '
        Me.ToolStripTextBox_Name.MaxLength = 255
        Me.ToolStripTextBox_Name.Name = "ToolStripTextBox_Name"
        Me.ToolStripTextBox_Name.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_GUID
        '
        Me.ToolStripLabel_GUID.Name = "ToolStripLabel_GUID"
        Me.ToolStripLabel_GUID.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel_GUID.Text = "GUID_f:"
        '
        'ToolStripTextBox_GUID
        '
        Me.ToolStripTextBox_GUID.Name = "ToolStripTextBox_GUID"
        Me.ToolStripTextBox_GUID.ReadOnly = True
        Me.ToolStripTextBox_GUID.Size = New System.Drawing.Size(250, 25)
        '
        'Timer_RelationType
        '
        Me.Timer_RelationType.Interval = 500
        '
        'frmRelationTypeEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 390)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmRelationTypeEdit"
        Me.Text = "frmRelationTypeEdit"
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
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView_Token, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Type, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.BindingSource_Token, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Type, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView_Token As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Name As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Name As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DataGridView_Type As System.Windows.Forms.DataGridView
    Friend WithEvents Label_Token As System.Windows.Forms.Label
    Friend WithEvents Label_Types As System.Windows.Forms.Label
    Friend WithEvents BindingSource_Token As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource_Type As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_GUID As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_GUID As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Timer_RelationType As System.Windows.Forms.Timer
End Class
