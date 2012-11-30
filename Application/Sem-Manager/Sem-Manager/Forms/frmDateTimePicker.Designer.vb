<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateTimePicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDateTimePicker))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_OK = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Cancel = New System.Windows.Forms.ToolStripButton()
        Me.MonthCalendar_Date = New System.Windows.Forms.MonthCalendar()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.MonthCalendar_Date)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(206, 184)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(206, 209)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_OK, Me.ToolStripButton_Cancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(106, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_OK
        '
        Me.ToolStripButton_OK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_OK.Image = CType(resources.GetObject("ToolStripButton_OK.Image"), System.Drawing.Image)
        Me.ToolStripButton_OK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_OK.Name = "ToolStripButton_OK"
        Me.ToolStripButton_OK.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripButton_OK.Text = "x_OK"
        '
        'ToolStripButton_Cancel
        '
        Me.ToolStripButton_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Cancel.Image = CType(resources.GetObject("ToolStripButton_Cancel.Image"), System.Drawing.Image)
        Me.ToolStripButton_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Cancel.Name = "ToolStripButton_Cancel"
        Me.ToolStripButton_Cancel.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton_Cancel.Text = "x_Cancel"
        '
        'MonthCalendar_Date
        '
        Me.MonthCalendar_Date.Location = New System.Drawing.Point(15, 9)
        Me.MonthCalendar_Date.Name = "MonthCalendar_Date"
        Me.MonthCalendar_Date.TabIndex = 1
        '
        'frmDateTimePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDateTimePicker"
        Me.Text = "x_Date"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_OK As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents MonthCalendar_Date As System.Windows.Forms.MonthCalendar
End Class
