<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImageSingle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImageSingle))
        Me.PictureBox_Images = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_Images, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_Images
        '
        Me.PictureBox_Images.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_Images.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox_Images.Name = "PictureBox_Images"
        Me.PictureBox_Images.Size = New System.Drawing.Size(434, 353)
        Me.PictureBox_Images.TabIndex = 2
        Me.PictureBox_Images.TabStop = False
        '
        'frmImageSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 353)
        Me.Controls.Add(Me.PictureBox_Images)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImageSingle"
        Me.Text = "x_Single Image"
        CType(Me.PictureBox_Images, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox_Images As System.Windows.Forms.PictureBox
End Class
