<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Menge
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
        Me.components = New System.ComponentModel.Container()
        Me.Label_Menge = New System.Windows.Forms.Label()
        Me.TextBox_Menge = New System.Windows.Forms.TextBox()
        Me.ComboBox_Einheit = New System.Windows.Forms.ComboBox()
        Me.Timer_Menge = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label_Menge
        '
        Me.Label_Menge.AutoSize = True
        Me.Label_Menge.Location = New System.Drawing.Point(3, 5)
        Me.Label_Menge.Name = "Label_Menge"
        Me.Label_Menge.Size = New System.Drawing.Size(54, 13)
        Me.Label_Menge.TabIndex = 0
        Me.Label_Menge.Text = "x_Menge:"
        '
        'TextBox_Menge
        '
        Me.TextBox_Menge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Menge.Location = New System.Drawing.Point(63, 2)
        Me.TextBox_Menge.Name = "TextBox_Menge"
        Me.TextBox_Menge.Size = New System.Drawing.Size(126, 20)
        Me.TextBox_Menge.TabIndex = 1
        '
        'ComboBox_Einheit
        '
        Me.ComboBox_Einheit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Einheit.FormattingEnabled = True
        Me.ComboBox_Einheit.Location = New System.Drawing.Point(195, 2)
        Me.ComboBox_Einheit.Name = "ComboBox_Einheit"
        Me.ComboBox_Einheit.Size = New System.Drawing.Size(81, 21)
        Me.ComboBox_Einheit.TabIndex = 2
        '
        'Timer_Menge
        '
        Me.Timer_Menge.Interval = 300
        '
        'UserControl_Menge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ComboBox_Einheit)
        Me.Controls.Add(Me.TextBox_Menge)
        Me.Controls.Add(Me.Label_Menge)
        Me.Name = "UserControl_Menge"
        Me.Size = New System.Drawing.Size(279, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Menge As System.Windows.Forms.Label
    Friend WithEvents TextBox_Menge As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_Einheit As System.Windows.Forms.ComboBox
    Friend WithEvents Timer_Menge As System.Windows.Forms.Timer

End Class
