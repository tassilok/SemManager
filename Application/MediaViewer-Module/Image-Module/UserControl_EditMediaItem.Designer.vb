<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_EditMediaItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_EditMediaItem))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.AxWindowsMediaPlayer_Main = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_DeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.AxWindowsMediaPlayer_Main)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(362, 336)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(362, 386)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'AxWindowsMediaPlayer_Main
        '
        Me.AxWindowsMediaPlayer_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer_Main.Enabled = True
        Me.AxWindowsMediaPlayer_Main.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer_Main.Name = "AxWindowsMediaPlayer_Main"
        Me.AxWindowsMediaPlayer_Main.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer_Main.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer_Main.Size = New System.Drawing.Size(362, 336)
        Me.AxWindowsMediaPlayer_Main.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_DeleteItem})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(82, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_DeleteItem
        '
        Me.ToolStripButton_DeleteItem.Image = Global.MediaViewer_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_DeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DeleteItem.Name = "ToolStripButton_DeleteItem"
        Me.ToolStripButton_DeleteItem.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton_DeleteItem.Text = "x_Delete"
        '
        'UserControl_EditMediaItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_EditMediaItem"
        Me.Size = New System.Drawing.Size(362, 386)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_DeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AxWindowsMediaPlayer_Main As AxWMPLib.AxWindowsMediaPlayer

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
