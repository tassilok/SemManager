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
        Me.GroupBox_AttriuteTypes = New System.Windows.Forms.GroupBox
        Me.RadioButton_Time = New System.Windows.Forms.RadioButton
        Me.RadioButton_VarcharMAX = New System.Windows.Forms.RadioButton
        Me.RadioButton_Varchar255 = New System.Windows.Forms.RadioButton
        Me.RadioButton_Real = New System.Windows.Forms.RadioButton
        Me.RadioButton_Int = New System.Windows.Forms.RadioButton
        Me.RadioButton_Datetime = New System.Windows.Forms.RadioButton
        Me.RadioButton_Date = New System.Windows.Forms.RadioButton
        Me.RadioButton_Bit = New System.Windows.Forms.RadioButton
        Me.GroupBox_AttriuteTypes.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_AttriuteTypes
        '
        Me.GroupBox_AttriuteTypes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_Time)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_VarcharMAX)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_Varchar255)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_Real)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_Int)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_Datetime)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_Date)
        Me.GroupBox_AttriuteTypes.Controls.Add(Me.RadioButton_Bit)
        Me.GroupBox_AttriuteTypes.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox_AttriuteTypes.Name = "GroupBox_AttriuteTypes"
        Me.GroupBox_AttriuteTypes.Size = New System.Drawing.Size(360, 413)
        Me.GroupBox_AttriuteTypes.TabIndex = 0
        Me.GroupBox_AttriuteTypes.TabStop = False
        Me.GroupBox_AttriuteTypes.Text = "x_Type"
        '
        'RadioButton_Time
        '
        Me.RadioButton_Time.AutoSize = True
        Me.RadioButton_Time.Location = New System.Drawing.Point(18, 149)
        Me.RadioButton_Time.Name = "RadioButton_Time"
        Me.RadioButton_Time.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton_Time.TabIndex = 7
        Me.RadioButton_Time.TabStop = True
        Me.RadioButton_Time.Text = "x_Time"
        Me.RadioButton_Time.UseVisualStyleBackColor = True
        '
        'RadioButton_VarcharMAX
        '
        Me.RadioButton_VarcharMAX.AutoSize = True
        Me.RadioButton_VarcharMAX.Location = New System.Drawing.Point(18, 195)
        Me.RadioButton_VarcharMAX.Name = "RadioButton_VarcharMAX"
        Me.RadioButton_VarcharMAX.Size = New System.Drawing.Size(106, 17)
        Me.RadioButton_VarcharMAX.TabIndex = 6
        Me.RadioButton_VarcharMAX.Text = "x_Varchar 32767"
        Me.RadioButton_VarcharMAX.UseVisualStyleBackColor = True
        '
        'RadioButton_Varchar255
        '
        Me.RadioButton_Varchar255.AutoSize = True
        Me.RadioButton_Varchar255.Checked = True
        Me.RadioButton_Varchar255.Location = New System.Drawing.Point(18, 172)
        Me.RadioButton_Varchar255.Name = "RadioButton_Varchar255"
        Me.RadioButton_Varchar255.Size = New System.Drawing.Size(94, 17)
        Me.RadioButton_Varchar255.TabIndex = 5
        Me.RadioButton_Varchar255.TabStop = True
        Me.RadioButton_Varchar255.Text = "x_Varchar 255"
        Me.RadioButton_Varchar255.UseVisualStyleBackColor = True
        '
        'RadioButton_Real
        '
        Me.RadioButton_Real.AutoSize = True
        Me.RadioButton_Real.Location = New System.Drawing.Point(18, 126)
        Me.RadioButton_Real.Name = "RadioButton_Real"
        Me.RadioButton_Real.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton_Real.TabIndex = 4
        Me.RadioButton_Real.Text = "x_Real"
        Me.RadioButton_Real.UseVisualStyleBackColor = True
        '
        'RadioButton_Int
        '
        Me.RadioButton_Int.AutoSize = True
        Me.RadioButton_Int.Location = New System.Drawing.Point(18, 102)
        Me.RadioButton_Int.Name = "RadioButton_Int"
        Me.RadioButton_Int.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton_Int.TabIndex = 3
        Me.RadioButton_Int.Text = "x_Int"
        Me.RadioButton_Int.UseVisualStyleBackColor = True
        '
        'RadioButton_Datetime
        '
        Me.RadioButton_Datetime.AutoSize = True
        Me.RadioButton_Datetime.Location = New System.Drawing.Point(18, 78)
        Me.RadioButton_Datetime.Name = "RadioButton_Datetime"
        Me.RadioButton_Datetime.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton_Datetime.TabIndex = 2
        Me.RadioButton_Datetime.Text = "x_Datetime"
        Me.RadioButton_Datetime.UseVisualStyleBackColor = True
        '
        'RadioButton_Date
        '
        Me.RadioButton_Date.AutoSize = True
        Me.RadioButton_Date.Location = New System.Drawing.Point(18, 54)
        Me.RadioButton_Date.Name = "RadioButton_Date"
        Me.RadioButton_Date.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton_Date.TabIndex = 1
        Me.RadioButton_Date.Text = "x_Date"
        Me.RadioButton_Date.UseVisualStyleBackColor = True
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
        Me.Size = New System.Drawing.Size(363, 419)
        Me.GroupBox_AttriuteTypes.ResumeLayout(False)
        Me.GroupBox_AttriuteTypes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox_AttriuteTypes As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_VarcharMAX As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Varchar255 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Real As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Int As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Datetime As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Date As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Bit As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Time As System.Windows.Forms.RadioButton

End Class
