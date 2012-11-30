<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Attribute_Bool
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton_False = New System.Windows.Forms.RadioButton
        Me.RadioButton_True = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_False)
        Me.GroupBox1.Controls.Add(Me.RadioButton_True)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 80)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'RadioButton_False
        '
        Me.RadioButton_False.AutoSize = True
        Me.RadioButton_False.Location = New System.Drawing.Point(7, 35)
        Me.RadioButton_False.Name = "RadioButton_False"
        Me.RadioButton_False.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton_False.TabIndex = 1
        Me.RadioButton_False.TabStop = True
        Me.RadioButton_False.Text = "Falsch_f"
        Me.RadioButton_False.UseVisualStyleBackColor = True
        '
        'RadioButton_True
        '
        Me.RadioButton_True.AutoSize = True
        Me.RadioButton_True.Checked = True
        Me.RadioButton_True.Location = New System.Drawing.Point(7, 11)
        Me.RadioButton_True.Name = "RadioButton_True"
        Me.RadioButton_True.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton_True.TabIndex = 0
        Me.RadioButton_True.TabStop = True
        Me.RadioButton_True.Text = "Wahr_f"
        Me.RadioButton_True.UseVisualStyleBackColor = True
        '
        'UserControl_Attribute_Bool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControl_Attribute_Bool"
        Me.Size = New System.Drawing.Size(299, 76)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_False As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_True As System.Windows.Forms.RadioButton

End Class
