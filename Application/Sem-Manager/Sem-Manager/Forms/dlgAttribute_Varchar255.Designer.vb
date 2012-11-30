<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAttribute_Varchar255
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_DB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimestampfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputernamefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsernamefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox_more = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_ItemCount = New System.Windows.Forms.NumericUpDown()
        Me.Panel_Data = New System.Windows.Forms.Panel()
        Me.CheckBox_SemItem = New System.Windows.Forms.CheckBox()
        Me.ToolStripStatusLabel_LengthLBL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Length = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NumericUpDown_ItemCount, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 166)
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_DB, Me.ToolStripStatusLabel_LengthLBL, Me.ToolStripStatusLabel_Length})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 207)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(435, 25)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel_DB
        '
        Me.ToolStripStatusLabel_DB.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ToolStripStatusLabel_DB.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel_DB.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripStatusLabel_DB.Image = Global.Sem_Manager.My.Resources.Resources.bb_home_
        Me.ToolStripStatusLabel_DB.Name = "ToolStripStatusLabel_DB"
        Me.ToolStripStatusLabel_DB.Size = New System.Drawing.Size(51, 20)
        Me.ToolStripStatusLabel_DB.Text = "DB_f"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditfToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(435, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditfToolStripMenuItem
        '
        Me.EditfToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertToolStripMenuItem, Me.ListToolStripMenuItem})
        Me.EditfToolStripMenuItem.Name = "EditfToolStripMenuItem"
        Me.EditfToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.EditfToolStripMenuItem.Text = "Edit_f"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimestampfToolStripMenuItem, Me.ComputernamefToolStripMenuItem, Me.UsernamefToolStripMenuItem, Me.SemItemToolStripMenuItem})
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InsertToolStripMenuItem.Text = "x_Insert"
        '
        'TimestampfToolStripMenuItem
        '
        Me.TimestampfToolStripMenuItem.Name = "TimestampfToolStripMenuItem"
        Me.TimestampfToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.TimestampfToolStripMenuItem.Text = "x_Timestamp"
        '
        'ComputernamefToolStripMenuItem
        '
        Me.ComputernamefToolStripMenuItem.Name = "ComputernamefToolStripMenuItem"
        Me.ComputernamefToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ComputernamefToolStripMenuItem.Text = "x_Computername"
        '
        'UsernamefToolStripMenuItem
        '
        Me.UsernamefToolStripMenuItem.Name = "UsernamefToolStripMenuItem"
        Me.UsernamefToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UsernamefToolStripMenuItem.Text = "x_Username"
        '
        'SemItemToolStripMenuItem
        '
        Me.SemItemToolStripMenuItem.Name = "SemItemToolStripMenuItem"
        Me.SemItemToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SemItemToolStripMenuItem.Text = "x_Sem-Item"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.CheckOnClick = True
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListToolStripMenuItem.Text = "x_List"
        '
        'CheckBox_more
        '
        Me.CheckBox_more.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_more.AutoSize = True
        Me.CheckBox_more.Location = New System.Drawing.Point(351, 212)
        Me.CheckBox_more.Name = "CheckBox_more"
        Me.CheckBox_more.Size = New System.Drawing.Size(69, 17)
        Me.CheckBox_more.TabIndex = 12
        Me.CheckBox_more.Text = "weitere_f"
        Me.CheckBox_more.UseVisualStyleBackColor = True
        Me.CheckBox_more.Visible = False
        '
        'NumericUpDown_ItemCount
        '
        Me.NumericUpDown_ItemCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown_ItemCount.Location = New System.Drawing.Point(306, 210)
        Me.NumericUpDown_ItemCount.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown_ItemCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_ItemCount.Name = "NumericUpDown_ItemCount"
        Me.NumericUpDown_ItemCount.Size = New System.Drawing.Size(41, 20)
        Me.NumericUpDown_ItemCount.TabIndex = 11
        Me.NumericUpDown_ItemCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_ItemCount.Visible = False
        '
        'Panel_Data
        '
        Me.Panel_Data.Location = New System.Drawing.Point(13, 27)
        Me.Panel_Data.Name = "Panel_Data"
        Me.Panel_Data.Size = New System.Drawing.Size(407, 132)
        Me.Panel_Data.TabIndex = 13
        '
        'CheckBox_SemItem
        '
        Me.CheckBox_SemItem.AutoSize = True
        Me.CheckBox_SemItem.Enabled = False
        Me.CheckBox_SemItem.Location = New System.Drawing.Point(13, 173)
        Me.CheckBox_SemItem.Name = "CheckBox_SemItem"
        Me.CheckBox_SemItem.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox_SemItem.TabIndex = 14
        Me.CheckBox_SemItem.Text = "x_SemItem"
        Me.CheckBox_SemItem.UseVisualStyleBackColor = True
        '
        'ToolStripStatusLabel_LengthLBL
        '
        Me.ToolStripStatusLabel_LengthLBL.Name = "ToolStripStatusLabel_LengthLBL"
        Me.ToolStripStatusLabel_LengthLBL.Size = New System.Drawing.Size(52, 20)
        Me.ToolStripStatusLabel_LengthLBL.Text = "x_Länge:"
        '
        'ToolStripStatusLabel_Length
        '
        Me.ToolStripStatusLabel_Length.Name = "ToolStripStatusLabel_Length"
        Me.ToolStripStatusLabel_Length.Size = New System.Drawing.Size(13, 20)
        Me.ToolStripStatusLabel_Length.Text = "0"
        '
        'dlgAttribute_Varchar255
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 232)
        Me.Controls.Add(Me.CheckBox_SemItem)
        Me.Controls.Add(Me.Panel_Data)
        Me.Controls.Add(Me.NumericUpDown_ItemCount)
        Me.Controls.Add(Me.CheckBox_more)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAttribute_Varchar255"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dlgAttribute_Varchar255"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NumericUpDown_ItemCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel_DB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimestampfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputernamefToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsernamefToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox_more As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown_ItemCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel_Data As System.Windows.Forms.Panel
    Friend WithEvents SemItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox_SemItem As System.Windows.Forms.CheckBox
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel_LengthLBL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Length As System.Windows.Forms.ToolStripStatusLabel

End Class
