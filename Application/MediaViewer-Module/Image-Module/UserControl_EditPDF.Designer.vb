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
        Me.AxFoxitCtl_Main = New AxFOXITREADERLib.AxFoxitCtl()
        CType(Me.AxFoxitCtl_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxFoxitCtl_Main
        '
        Me.AxFoxitCtl_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxFoxitCtl_Main.Enabled = True
        Me.AxFoxitCtl_Main.Location = New System.Drawing.Point(0, 0)
        Me.AxFoxitCtl_Main.Name = "AxFoxitCtl_Main"
        Me.AxFoxitCtl_Main.OcxState = CType(resources.GetObject("AxFoxitCtl_Main.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxFoxitCtl_Main.Size = New System.Drawing.Size(448, 432)
        Me.AxFoxitCtl_Main.TabIndex = 0
        '
        'UserControl_EditPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AxFoxitCtl_Main)
        Me.Name = "UserControl_EditPDF"
        Me.Size = New System.Drawing.Size(448, 432)
        CType(Me.AxFoxitCtl_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxFoxitCtl_Main As AxFOXITREADERLib.AxFoxitCtl

End Class
