﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog_DateFilter
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.MonthCalendar_CreationDate = New System.Windows.Forms.MonthCalendar()
        Me.RadioButton_Start = New System.Windows.Forms.RadioButton()
        Me.RadioButton_End = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_Start = New System.Windows.Forms.TextBox()
        Me.TextBox_End = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(220, 184)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Abbrechen"
        '
        'MonthCalendar_CreationDate
        '
        Me.MonthCalendar_CreationDate.Location = New System.Drawing.Point(188, 18)
        Me.MonthCalendar_CreationDate.MaxSelectionCount = 1
        Me.MonthCalendar_CreationDate.Name = "MonthCalendar_CreationDate"
        Me.MonthCalendar_CreationDate.TabIndex = 3
        '
        'RadioButton_Start
        '
        Me.RadioButton_Start.AutoSize = True
        Me.RadioButton_Start.Checked = True
        Me.RadioButton_Start.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton_Start.Name = "RadioButton_Start"
        Me.RadioButton_Start.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton_Start.TabIndex = 4
        Me.RadioButton_Start.TabStop = True
        Me.RadioButton_Start.Text = "Start:"
        Me.RadioButton_Start.UseVisualStyleBackColor = True
        '
        'RadioButton_End
        '
        Me.RadioButton_End.AutoSize = True
        Me.RadioButton_End.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_End.Name = "RadioButton_End"
        Me.RadioButton_End.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton_End.TabIndex = 5
        Me.RadioButton_End.Text = "End:"
        Me.RadioButton_End.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_End)
        Me.GroupBox1.Controls.Add(Me.TextBox_Start)
        Me.GroupBox1.Controls.Add(Me.RadioButton_Start)
        Me.GroupBox1.Controls.Add(Me.RadioButton_End)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Range:"
        '
        'TextBox_Start
        '
        Me.TextBox_Start.Location = New System.Drawing.Point(58, 18)
        Me.TextBox_Start.Name = "TextBox_Start"
        Me.TextBox_Start.ReadOnly = True
        Me.TextBox_Start.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Start.TabIndex = 6
        '
        'TextBox_End
        '
        Me.TextBox_End.Location = New System.Drawing.Point(58, 41)
        Me.TextBox_End.Name = "TextBox_End"
        Me.TextBox_End.ReadOnly = True
        Me.TextBox_End.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_End.TabIndex = 7
        '
        'Dialog_DateFilter
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(378, 225)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MonthCalendar_CreationDate)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog_DateFilter"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Date-Filter"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar_CreationDate As System.Windows.Forms.MonthCalendar
    Friend WithEvents RadioButton_Start As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_End As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_End As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Start As System.Windows.Forms.TextBox

End Class
