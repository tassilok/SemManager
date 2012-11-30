<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Attribute_VARCHAR255
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
        Me.Label_GUID = New System.Windows.Forms.Label()
        Me.TextBox_GUID = New System.Windows.Forms.TextBox()
        Me.Button_New = New System.Windows.Forms.Button()
        Me.Label_Caption = New System.Windows.Forms.Label()
        Me.TextBox_Value1 = New System.Windows.Forms.TextBox()
        Me.TextBox_Value2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label_GUID
        '
        Me.Label_GUID.AutoSize = True
        Me.Label_GUID.Location = New System.Drawing.Point(4, 3)
        Me.Label_GUID.Name = "Label_GUID"
        Me.Label_GUID.Size = New System.Drawing.Size(46, 13)
        Me.Label_GUID.TabIndex = 1
        Me.Label_GUID.Text = "GUID_f:"
        '
        'TextBox_GUID
        '
        Me.TextBox_GUID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_GUID.Location = New System.Drawing.Point(7, 19)
        Me.TextBox_GUID.MaxLength = 36
        Me.TextBox_GUID.Name = "TextBox_GUID"
        Me.TextBox_GUID.ReadOnly = True
        Me.TextBox_GUID.Size = New System.Drawing.Size(233, 20)
        Me.TextBox_GUID.TabIndex = 2
        '
        'Button_New
        '
        Me.Button_New.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_New.Location = New System.Drawing.Point(246, 17)
        Me.Button_New.Name = "Button_New"
        Me.Button_New.Size = New System.Drawing.Size(75, 23)
        Me.Button_New.TabIndex = 3
        Me.Button_New.Text = "New"
        Me.Button_New.UseVisualStyleBackColor = True
        '
        'Label_Caption
        '
        Me.Label_Caption.AutoSize = True
        Me.Label_Caption.Location = New System.Drawing.Point(4, 49)
        Me.Label_Caption.Name = "Label_Caption"
        Me.Label_Caption.Size = New System.Drawing.Size(55, 13)
        Me.Label_Caption.TabIndex = 4
        Me.Label_Caption.Text = "Caption_f:"
        '
        'TextBox_Value1
        '
        Me.TextBox_Value1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Value1.Location = New System.Drawing.Point(7, 65)
        Me.TextBox_Value1.Name = "TextBox_Value1"
        Me.TextBox_Value1.Size = New System.Drawing.Size(314, 20)
        Me.TextBox_Value1.TabIndex = 5
        '
        'TextBox_Value2
        '
        Me.TextBox_Value2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Value2.Enabled = False
        Me.TextBox_Value2.Location = New System.Drawing.Point(7, 91)
        Me.TextBox_Value2.Name = "TextBox_Value2"
        Me.TextBox_Value2.Size = New System.Drawing.Size(314, 20)
        Me.TextBox_Value2.TabIndex = 6
        '
        'UserControl_Attribute_VARCHAR255
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBox_Value2)
        Me.Controls.Add(Me.TextBox_Value1)
        Me.Controls.Add(Me.Label_Caption)
        Me.Controls.Add(Me.Button_New)
        Me.Controls.Add(Me.TextBox_GUID)
        Me.Controls.Add(Me.Label_GUID)
        Me.Name = "UserControl_Attribute_VARCHAR255"
        Me.Size = New System.Drawing.Size(324, 118)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_GUID As System.Windows.Forms.Label
    Friend WithEvents TextBox_GUID As System.Windows.Forms.TextBox
    Friend WithEvents Button_New As System.Windows.Forms.Button
    Friend WithEvents Label_Caption As System.Windows.Forms.Label
    Friend WithEvents TextBox_Value1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Value2 As System.Windows.Forms.TextBox

End Class
