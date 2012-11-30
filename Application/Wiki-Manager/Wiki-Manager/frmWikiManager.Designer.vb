<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWikiManager
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
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.WebBrowser_WIKI = New System.Windows.Forms.WebBrowser
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel_WIKIImplementation = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripComboBox_WIKIImplementation = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.WebBrowser_WIKI)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(627, 338)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(627, 388)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'WebBrowser_WIKI
        '
        Me.WebBrowser_WIKI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser_WIKI.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser_WIKI.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser_WIKI.Name = "WebBrowser_WIKI"
        Me.WebBrowser_WIKI.Size = New System.Drawing.Size(627, 338)
        Me.WebBrowser_WIKI.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_WIKIImplementation, Me.ToolStripComboBox_WIKIImplementation})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(308, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_WIKIImplementation
        '
        Me.ToolStripLabel_WIKIImplementation.Name = "ToolStripLabel_WIKIImplementation"
        Me.ToolStripLabel_WIKIImplementation.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel_WIKIImplementation.Text = "x_WIKI:"
        '
        'ToolStripComboBox_WIKIImplementation
        '
        Me.ToolStripComboBox_WIKIImplementation.Name = "ToolStripComboBox_WIKIImplementation"
        Me.ToolStripComboBox_WIKIImplementation.Size = New System.Drawing.Size(250, 25)
        '
        'frmWikiManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 388)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmWikiManager"
        Me.Text = "x_Wiki-Manager"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents WebBrowser_WIKI As System.Windows.Forms.WebBrowser
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_WIKIImplementation As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripComboBox_WIKIImplementation As System.Windows.Forms.ToolStripComboBox

End Class
