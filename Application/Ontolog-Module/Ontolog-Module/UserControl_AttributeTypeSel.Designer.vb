<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_AttributeTypeSel
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
        Me.GroupBox_AttriuteTypes = New System.Windows.Forms.GroupBox()
        Me.RadioButton_String = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Real = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Long = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Datetime = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Bit = New System.Windows.Forms.RadioButton()
        Me.GroupBox_AttriuteTypes.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_AttriuteTypes
        '
        Me.GroupBox_AttriuteTypes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_String)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_Real)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_Long)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_Datetime)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_Bit)
        Me.GroupBox_AttriuteTypes.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox_AttriuteTypes.Name = "GroupBox_AttriuteTypes"
        Me.GroupBox_AttriuteTypes.Size = New System.Drawing.Size(297, 386)
        Me.GroupBox_AttriuteTypes.TabIndex = 1
        Me.GroupBox_AttriuteTypes.TabStop = False
        Me.GroupBox_AttriuteTypes.Text = "x_Type"
        '
        'RadioButton_String
        '
        Me.RadioButton_String.AutoSize = True
        Me.RadioButton_String.Checked = True
        Me.RadioButton_String.Location = New System.Drawing.Point(18, 122)
        Me.RadioButton_String.Name = "RadioButton_String"
        Me.RadioButton_String.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton_String.TabIndex = 6
        Me.RadioButton_String.TabStop = True
        Me.RadioButton_String.Text = "x_String"
        Me.RadioButton_String.UseVisualStyleBackColor = True
        '
        'RadioButton_Real
        '
        Me.RadioButton_Real.AutoSize = True
        Me.RadioButton_Real.Location = New System.Drawing.Point(18, 99)
        Me.RadioButton_Real.Name = "RadioButton_Real"
        Me.RadioButton_Real.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton_Real.TabIndex = 4
        Me.RadioButton_Real.Text = "x_Real"
        Me.RadioButton_Real.UseVisualStyleBackColor = True
        '
        'RadioButton_Long
        '
        Me.RadioButton_Long.AutoSize = True
        Me.RadioButton_Long.Location = New System.Drawing.Point(18, 76)
        Me.RadioButton_Long.Name = "RadioButton_Long"
        Me.RadioButton_Long.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton_Long.TabIndex = 3
        Me.RadioButton_Long.Text = "x_Long"
        Me.RadioButton_Long.UseVisualStyleBackColor = True
        '
        'RadioButton_Datetime
        '
        Me.RadioButton_Datetime.AutoSize = True
        Me.RadioButton_Datetime.Location = New System.Drawing.Point(18, 53)
        Me.RadioButton_Datetime.Name = "RadioButton_Datetime"
        Me.RadioButton_Datetime.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton_Datetime.TabIndex = 2
        Me.RadioButton_Datetime.Text = "x_Datetime"
        Me.RadioButton_Datetime.UseVisualStyleBackColor = True
        '
        'RadioButton_Bit
        '
        Me.RadioButton_Bit.AutoSize = True
        Me.RadioButton_Bit.Location = New System.Drawing.Point(18, 30)
        Me.RadioButton_Bit.Name = "RadioButton_Bit"
        Me.RadioButton_Bit.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton_Bit.TabIndex = 0
        Me.RadioButton_Bit.Text = "x_Boolean"
        Me.RadioButton_Bit.UseVisualStyleBackColor = True
        '
        'UserControl_AttributeTypeSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox_AttriuteTypes)
        Me.Name = "UserControl_AttributeTypeSel"
        Me.Size = New System.Drawing.Size(305, 391)
        Me.GroupBox_AttriuteTypes.ResumeLayout(False)
        Me.GroupBox_AttriuteTypes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox_AttriuteTypes As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_String As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Real As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Long As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Datetime As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Bit As System.Windows.Forms.RadioButton

End Class
