<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_EditPDF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_EditPDF))
        Me.AxFoxitReaderOCX_Viewer = New AxFOXITREADEROCXLib.AxFoxitReaderOCX()
        CType(Me.AxFoxitReaderOCX_Viewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxFoxitReaderOCX_Viewer
        '
        Me.AxFoxitReaderOCX_Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxFoxitReaderOCX_Viewer.Enabled = True
        Me.AxFoxitReaderOCX_Viewer.Location = New System.Drawing.Point(0, 0)
        Me.AxFoxitReaderOCX_Viewer.Name = "AxFoxitReaderOCX_Viewer"
        Me.AxFoxitReaderOCX_Viewer.OcxState = CType(resources.GetObject("AxFoxitReaderOCX_Viewer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxFoxitReaderOCX_Viewer.Size = New System.Drawing.Size(448, 432)
        Me.AxFoxitReaderOCX_Viewer.TabIndex = 1
        '
        'UserControl_EditPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AxFoxitReaderOCX_Viewer)
        Me.Name = "UserControl_EditPDF"
        Me.Size = New System.Drawing.Size(448, 432)
        CType(Me.AxFoxitReaderOCX_Viewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxFoxitReaderOCX_Viewer As AxFOXITREADEROCXLib.AxFoxitReaderOCX

End Class
