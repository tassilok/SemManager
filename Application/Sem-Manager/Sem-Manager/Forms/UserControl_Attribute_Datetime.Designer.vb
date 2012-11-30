<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Attribute_Datetime
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
        Me.Panel_Date = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.NumericUpDown_Day = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown_Year = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown_Month = New System.Windows.Forms.NumericUpDown
        Me.Panel_Time = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.NumericUpDown_Second = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown_Minute = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown_Hour = New System.Windows.Forms.NumericUpDown
        Me.Panel_Date.SuspendLayout()
        CType(Me.NumericUpDown_Day, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Year, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Month, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Time.SuspendLayout()
        CType(Me.NumericUpDown_Second, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Minute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Hour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Date
        '
        Me.Panel_Date.Controls.Add(Me.Label2)
        Me.Panel_Date.Controls.Add(Me.Label1)
        Me.Panel_Date.Controls.Add(Me.NumericUpDown_Day)
        Me.Panel_Date.Controls.Add(Me.NumericUpDown_Year)
        Me.Panel_Date.Controls.Add(Me.NumericUpDown_Month)
        Me.Panel_Date.Location = New System.Drawing.Point(0, 3)
        Me.Panel_Date.Name = "Panel_Date"
        Me.Panel_Date.Size = New System.Drawing.Size(270, 26)
        Me.Panel_Date.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "."
        '
        'NumericUpDown_Day
        '
        Me.NumericUpDown_Day.Location = New System.Drawing.Point(3, 3)
        Me.NumericUpDown_Day.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.NumericUpDown_Day.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Day.Name = "NumericUpDown_Day"
        Me.NumericUpDown_Day.Size = New System.Drawing.Size(53, 20)
        Me.NumericUpDown_Day.TabIndex = 6
        Me.NumericUpDown_Day.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown_Year
        '
        Me.NumericUpDown_Year.Location = New System.Drawing.Point(147, 3)
        Me.NumericUpDown_Year.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown_Year.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Year.Name = "NumericUpDown_Year"
        Me.NumericUpDown_Year.Size = New System.Drawing.Size(119, 20)
        Me.NumericUpDown_Year.TabIndex = 8
        Me.NumericUpDown_Year.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown_Month
        '
        Me.NumericUpDown_Month.Location = New System.Drawing.Point(78, 3)
        Me.NumericUpDown_Month.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumericUpDown_Month.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Month.Name = "NumericUpDown_Month"
        Me.NumericUpDown_Month.Size = New System.Drawing.Size(47, 20)
        Me.NumericUpDown_Month.TabIndex = 7
        Me.NumericUpDown_Month.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel_Time
        '
        Me.Panel_Time.Controls.Add(Me.Label3)
        Me.Panel_Time.Controls.Add(Me.Label4)
        Me.Panel_Time.Controls.Add(Me.NumericUpDown_Second)
        Me.Panel_Time.Controls.Add(Me.NumericUpDown_Minute)
        Me.Panel_Time.Controls.Add(Me.NumericUpDown_Hour)
        Me.Panel_Time.Location = New System.Drawing.Point(0, 35)
        Me.Panel_Time.Name = "Panel_Time"
        Me.Panel_Time.Size = New System.Drawing.Size(270, 27)
        Me.Panel_Time.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = ":"
        '
        'NumericUpDown_Second
        '
        Me.NumericUpDown_Second.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown_Second.Location = New System.Drawing.Point(230, 3)
        Me.NumericUpDown_Second.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDown_Second.Name = "NumericUpDown_Second"
        Me.NumericUpDown_Second.Size = New System.Drawing.Size(37, 20)
        Me.NumericUpDown_Second.TabIndex = 13
        '
        'NumericUpDown_Minute
        '
        Me.NumericUpDown_Minute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown_Minute.Location = New System.Drawing.Point(179, 3)
        Me.NumericUpDown_Minute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDown_Minute.Name = "NumericUpDown_Minute"
        Me.NumericUpDown_Minute.Size = New System.Drawing.Size(37, 20)
        Me.NumericUpDown_Minute.TabIndex = 12
        '
        'NumericUpDown_Hour
        '
        Me.NumericUpDown_Hour.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown_Hour.Location = New System.Drawing.Point(129, 3)
        Me.NumericUpDown_Hour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDown_Hour.Name = "NumericUpDown_Hour"
        Me.NumericUpDown_Hour.Size = New System.Drawing.Size(37, 20)
        Me.NumericUpDown_Hour.TabIndex = 11
        '
        'UserControl_Attribute_Datetime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel_Time)
        Me.Controls.Add(Me.Panel_Date)
        Me.Name = "UserControl_Attribute_Datetime"
        Me.Size = New System.Drawing.Size(270, 66)
        Me.Panel_Date.ResumeLayout(False)
        Me.Panel_Date.PerformLayout()
        CType(Me.NumericUpDown_Day, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Year, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Month, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Time.ResumeLayout(False)
        Me.Panel_Time.PerformLayout()
        CType(Me.NumericUpDown_Second, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Minute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Hour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Date As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_Day As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_Year As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_Month As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel_Time As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_Second As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_Minute As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_Hour As System.Windows.Forms.NumericUpDown

End Class
