<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Attribute_Int
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
        Me.TextBox_Value = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TextBox_Value
        '
        Me.TextBox_Value.Location = New System.Drawing.Point(3, 3)
        Me.TextBox_Value.MaxLength = 14
        Me.TextBox_Value.Name = "TextBox_Value"
        Me.TextBox_Value.Size = New System.Drawing.Size(306, 20)
        Me.TextBox_Value.TabIndex = 1
        '
        'UserControl_Attribute_Int
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBox_Value)
        Me.Name = "UserControl_Attribute_Int"
        Me.Size = New System.Drawing.Size(312, 28)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_Value As System.Windows.Forms.TextBox

End Class
