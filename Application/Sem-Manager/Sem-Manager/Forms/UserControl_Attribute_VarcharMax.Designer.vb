<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Attribute_VarcharMax
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
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Text = New System.Windows.Forms.TabPage()
        Me.TextBox_Value = New System.Windows.Forms.TextBox()
        Me.TabPage_RTF = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.RichTextBox_Value = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Text.SuspendLayout()
        Me.TabPage_RTF.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(367, 343)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(367, 368)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Text)
        Me.TabControl1.Controls.Add(Me.TabPage_RTF)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(367, 343)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage_Text
        '
        Me.TabPage_Text.Controls.Add(Me.TextBox_Value)
        Me.TabPage_Text.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Text.Name = "TabPage_Text"
        Me.TabPage_Text.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Text.Size = New System.Drawing.Size(359, 317)
        Me.TabPage_Text.TabIndex = 0
        Me.TabPage_Text.Text = "x_Raw-Text"
        Me.TabPage_Text.UseVisualStyleBackColor = True
        '
        'TextBox_Value
        '
        Me.TextBox_Value.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Value.Location = New System.Drawing.Point(3, 3)
        Me.TextBox_Value.MaxLength = 0
        Me.TextBox_Value.Multiline = True
        Me.TextBox_Value.Name = "TextBox_Value"
        Me.TextBox_Value.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Value.Size = New System.Drawing.Size(353, 311)
        Me.TextBox_Value.TabIndex = 3
        '
        'TabPage_RTF
        '
        Me.TabPage_RTF.Controls.Add(Me.ToolStripContainer2)
        Me.TabPage_RTF.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_RTF.Name = "TabPage_RTF"
        Me.TabPage_RTF.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_RTF.Size = New System.Drawing.Size(359, 317)
        Me.TabPage_RTF.TabIndex = 1
        Me.TabPage_RTF.Text = "x_RTF-Text"
        Me.TabPage_RTF.UseVisualStyleBackColor = True
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.RichTextBox_Value)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(353, 286)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(353, 311)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'RichTextBox_Value
        '
        Me.RichTextBox_Value.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox_Value.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox_Value.Name = "RichTextBox_Value"
        Me.RichTextBox_Value.Size = New System.Drawing.Size(353, 286)
        Me.RichTextBox_Value.TabIndex = 0
        Me.RichTextBox_Value.Text = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(111, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'UserControl_Attribute_VarcharMax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_Attribute_VarcharMax"
        Me.Size = New System.Drawing.Size(367, 368)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Text.ResumeLayout(False)
        Me.TabPage_Text.PerformLayout()
        Me.TabPage_RTF.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Text As System.Windows.Forms.TabPage
    Friend WithEvents TextBox_Value As System.Windows.Forms.TextBox
    Friend WithEvents TabPage_RTF As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents RichTextBox_Value As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip

End Class
