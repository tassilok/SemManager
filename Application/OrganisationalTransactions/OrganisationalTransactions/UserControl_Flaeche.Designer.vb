<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Flaeche
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
        Me.Label_X = New System.Windows.Forms.Label()
        Me.Panel_X = New System.Windows.Forms.Panel()
        Me.Label_Y = New System.Windows.Forms.Label()
        Me.Panel_Y = New System.Windows.Forms.Panel()
        Me.Label_ResultLBL = New System.Windows.Forms.Label()
        Me.Label_Result = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_X
        '
        Me.Label_X.AutoSize = True
        Me.Label_X.Location = New System.Drawing.Point(3, 9)
        Me.Label_X.Name = "Label_X"
        Me.Label_X.Size = New System.Drawing.Size(25, 13)
        Me.Label_X.TabIndex = 0
        Me.Label_X.Text = "x_X"
        '
        'Panel_X
        '
        Me.Panel_X.Location = New System.Drawing.Point(37, 5)
        Me.Panel_X.Name = "Panel_X"
        Me.Panel_X.Size = New System.Drawing.Size(340, 33)
        Me.Panel_X.TabIndex = 1
        '
        'Label_Y
        '
        Me.Label_Y.AutoSize = True
        Me.Label_Y.Location = New System.Drawing.Point(3, 44)
        Me.Label_Y.Name = "Label_Y"
        Me.Label_Y.Size = New System.Drawing.Size(25, 13)
        Me.Label_Y.TabIndex = 2
        Me.Label_Y.Text = "x_Y"
        '
        'Panel_Y
        '
        Me.Panel_Y.Location = New System.Drawing.Point(37, 44)
        Me.Panel_Y.Name = "Panel_Y"
        Me.Panel_Y.Size = New System.Drawing.Size(340, 33)
        Me.Panel_Y.TabIndex = 3
        '
        'Label_ResultLBL
        '
        Me.Label_ResultLBL.AutoSize = True
        Me.Label_ResultLBL.Location = New System.Drawing.Point(3, 86)
        Me.Label_ResultLBL.Name = "Label_ResultLBL"
        Me.Label_ResultLBL.Size = New System.Drawing.Size(24, 13)
        Me.Label_ResultLBL.TabIndex = 4
        Me.Label_ResultLBL.Text = "x_="
        '
        'Label_Result
        '
        Me.Label_Result.AutoSize = True
        Me.Label_Result.Location = New System.Drawing.Point(44, 86)
        Me.Label_Result.Name = "Label_Result"
        Me.Label_Result.Size = New System.Drawing.Size(10, 13)
        Me.Label_Result.TabIndex = 5
        Me.Label_Result.Text = "-"
        '
        'UserControl_Flaeche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label_Result)
        Me.Controls.Add(Me.Label_ResultLBL)
        Me.Controls.Add(Me.Panel_Y)
        Me.Controls.Add(Me.Label_Y)
        Me.Controls.Add(Me.Panel_X)
        Me.Controls.Add(Me.Label_X)
        Me.Name = "UserControl_Flaeche"
        Me.Size = New System.Drawing.Size(388, 123)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_X As System.Windows.Forms.Label
    Friend WithEvents Panel_X As System.Windows.Forms.Panel
    Friend WithEvents Label_Y As System.Windows.Forms.Label
    Friend WithEvents Panel_Y As System.Windows.Forms.Panel
    Friend WithEvents Label_ResultLBL As System.Windows.Forms.Label
    Friend WithEvents Label_Result As System.Windows.Forms.Label

End Class
