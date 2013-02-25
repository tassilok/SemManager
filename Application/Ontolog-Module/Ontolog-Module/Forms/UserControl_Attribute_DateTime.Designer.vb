<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Attribute_DateTime
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
        Me.DateTimePicker_Value = New System.Windows.Forms.DateTimePicker()
        Me.NumericUpDown_Hour = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Minute = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown_Second = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown_Millisecond = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown_Hour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Minute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Second, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Millisecond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker_Value
        '
        Me.DateTimePicker_Value.CustomFormat = "dd.MM.yyyy"
        Me.DateTimePicker_Value.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Value.Location = New System.Drawing.Point(4, 4)
        Me.DateTimePicker_Value.Name = "DateTimePicker_Value"
        Me.DateTimePicker_Value.Size = New System.Drawing.Size(114, 20)
        Me.DateTimePicker_Value.TabIndex = 0
        '
        'NumericUpDown_Hour
        '
        Me.NumericUpDown_Hour.Location = New System.Drawing.Point(124, 3)
        Me.NumericUpDown_Hour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDown_Hour.Name = "NumericUpDown_Hour"
        Me.NumericUpDown_Hour.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDown_Hour.TabIndex = 1
        '
        'NumericUpDown_Minute
        '
        Me.NumericUpDown_Minute.Location = New System.Drawing.Point(182, 3)
        Me.NumericUpDown_Minute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDown_Minute.Name = "NumericUpDown_Minute"
        Me.NumericUpDown_Minute.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDown_Minute.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = ":"
        '
        'NumericUpDown_Second
        '
        Me.NumericUpDown_Second.Location = New System.Drawing.Point(238, 3)
        Me.NumericUpDown_Second.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDown_Second.Name = "NumericUpDown_Second"
        Me.NumericUpDown_Second.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDown_Second.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "."
        '
        'NumericUpDown_Millisecond
        '
        Me.NumericUpDown_Millisecond.Location = New System.Drawing.Point(293, 3)
        Me.NumericUpDown_Millisecond.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown_Millisecond.Name = "NumericUpDown_Millisecond"
        Me.NumericUpDown_Millisecond.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDown_Millisecond.TabIndex = 6
        '
        'UserControl_Attribute_DateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDown_Millisecond)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown_Second)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown_Minute)
        Me.Controls.Add(Me.NumericUpDown_Hour)
        Me.Controls.Add(Me.DateTimePicker_Value)
        Me.Name = "UserControl_Attribute_DateTime"
        Me.Size = New System.Drawing.Size(347, 35)
        CType(Me.NumericUpDown_Hour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Minute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Second, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Millisecond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker_Value As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumericUpDown_Hour As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_Minute As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_Second As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_Millisecond As System.Windows.Forms.NumericUpDown

End Class
