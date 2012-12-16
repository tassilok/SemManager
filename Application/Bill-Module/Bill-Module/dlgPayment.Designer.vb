<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPayment
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgPayment))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_OK = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Cancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Clear = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_Amount = New System.Windows.Forms.Panel()
        Me.Label_Percent = New System.Windows.Forms.Label()
        Me.TextBox_PercPart = New System.Windows.Forms.TextBox()
        Me.Label_PercPart = New System.Windows.Forms.Label()
        Me.Label_Currency = New System.Windows.Forms.Label()
        Me.TextBox_Amount = New System.Windows.Forms.TextBox()
        Me.Label_Amount = New System.Windows.Forms.Label()
        Me.Panel_Datetime = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_GetBankTransaction = New System.Windows.Forms.Button()
        Me.TextBox_BankTransaction = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip_ClearBankTransaction = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_BankTransaction = New System.Windows.Forms.Label()
        Me.Button_Calc = New System.Windows.Forms.Button()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel_Amount.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip_ClearBankTransaction.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(527, 290)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(527, 315)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_OK, Me.ToolStripButton_Cancel, Me.ToolStripSeparator1, Me.ToolStripButton_Clear})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(160, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_OK
        '
        Me.ToolStripButton_OK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_OK.Image = CType(resources.GetObject("ToolStripButton_OK.Image"), System.Drawing.Image)
        Me.ToolStripButton_OK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_OK.Name = "ToolStripButton_OK"
        Me.ToolStripButton_OK.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripButton_OK.Text = "x_OK"
        '
        'ToolStripButton_Cancel
        '
        Me.ToolStripButton_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Cancel.Image = CType(resources.GetObject("ToolStripButton_Cancel.Image"), System.Drawing.Image)
        Me.ToolStripButton_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Cancel.Name = "ToolStripButton_Cancel"
        Me.ToolStripButton_Cancel.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton_Cancel.Text = "x_Cancel"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Clear
        '
        Me.ToolStripButton_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Clear.Image = CType(resources.GetObject("ToolStripButton_Clear.Image"), System.Drawing.Image)
        Me.ToolStripButton_Clear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Clear.Name = "ToolStripButton_Clear"
        Me.ToolStripButton_Clear.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripButton_Clear.Text = "x_Clear"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_Amount, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_Datetime, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(527, 290)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel_Amount
        '
        Me.Panel_Amount.Controls.Add(Me.Button_Calc)
        Me.Panel_Amount.Controls.Add(Me.Label_Percent)
        Me.Panel_Amount.Controls.Add(Me.TextBox_PercPart)
        Me.Panel_Amount.Controls.Add(Me.Label_PercPart)
        Me.Panel_Amount.Controls.Add(Me.Label_Currency)
        Me.Panel_Amount.Controls.Add(Me.TextBox_Amount)
        Me.Panel_Amount.Controls.Add(Me.Label_Amount)
        Me.Panel_Amount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Amount.Location = New System.Drawing.Point(3, 3)
        Me.Panel_Amount.Name = "Panel_Amount"
        Me.Panel_Amount.Size = New System.Drawing.Size(521, 29)
        Me.Panel_Amount.TabIndex = 1
        '
        'Label_Percent
        '
        Me.Label_Percent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Percent.AutoSize = True
        Me.Label_Percent.Location = New System.Drawing.Point(470, 7)
        Me.Label_Percent.Name = "Label_Percent"
        Me.Label_Percent.Size = New System.Drawing.Size(15, 13)
        Me.Label_Percent.TabIndex = 5
        Me.Label_Percent.Text = "%"
        '
        'TextBox_PercPart
        '
        Me.TextBox_PercPart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_PercPart.Location = New System.Drawing.Point(422, 4)
        Me.TextBox_PercPart.Name = "TextBox_PercPart"
        Me.TextBox_PercPart.Size = New System.Drawing.Size(45, 20)
        Me.TextBox_PercPart.TabIndex = 4
        '
        'Label_PercPart
        '
        Me.Label_PercPart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_PercPart.AutoSize = True
        Me.Label_PercPart.Location = New System.Drawing.Point(369, 7)
        Me.Label_PercPart.Name = "Label_PercPart"
        Me.Label_PercPart.Size = New System.Drawing.Size(47, 13)
        Me.Label_PercPart.TabIndex = 3
        Me.Label_PercPart.Text = "x_Anteil:"
        '
        'Label_Currency
        '
        Me.Label_Currency.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Currency.AutoSize = True
        Me.Label_Currency.Location = New System.Drawing.Point(353, 7)
        Me.Label_Currency.Name = "Label_Currency"
        Me.Label_Currency.Size = New System.Drawing.Size(10, 13)
        Me.Label_Currency.TabIndex = 2
        Me.Label_Currency.Text = "-"
        '
        'TextBox_Amount
        '
        Me.TextBox_Amount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Amount.Location = New System.Drawing.Point(61, 4)
        Me.TextBox_Amount.Name = "TextBox_Amount"
        Me.TextBox_Amount.Size = New System.Drawing.Size(286, 20)
        Me.TextBox_Amount.TabIndex = 1
        Me.TextBox_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_Amount
        '
        Me.Label_Amount.AutoSize = True
        Me.Label_Amount.Location = New System.Drawing.Point(3, 7)
        Me.Label_Amount.Name = "Label_Amount"
        Me.Label_Amount.Size = New System.Drawing.Size(52, 13)
        Me.Label_Amount.TabIndex = 0
        Me.Label_Amount.Text = "x_Betrag:"
        '
        'Panel_Datetime
        '
        Me.Panel_Datetime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Datetime.Location = New System.Drawing.Point(3, 38)
        Me.Panel_Datetime.Name = "Panel_Datetime"
        Me.Panel_Datetime.Size = New System.Drawing.Size(521, 216)
        Me.Panel_Datetime.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_GetBankTransaction)
        Me.Panel1.Controls.Add(Me.TextBox_BankTransaction)
        Me.Panel1.Controls.Add(Me.Label_BankTransaction)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 260)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 27)
        Me.Panel1.TabIndex = 3
        '
        'Button_GetBankTransaction
        '
        Me.Button_GetBankTransaction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_GetBankTransaction.Location = New System.Drawing.Point(496, -1)
        Me.Button_GetBankTransaction.Name = "Button_GetBankTransaction"
        Me.Button_GetBankTransaction.Size = New System.Drawing.Size(25, 23)
        Me.Button_GetBankTransaction.TabIndex = 2
        Me.Button_GetBankTransaction.Text = "..."
        Me.Button_GetBankTransaction.UseVisualStyleBackColor = True
        '
        'TextBox_BankTransaction
        '
        Me.TextBox_BankTransaction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_BankTransaction.ContextMenuStrip = Me.ContextMenuStrip_ClearBankTransaction
        Me.TextBox_BankTransaction.Location = New System.Drawing.Point(112, 1)
        Me.TextBox_BankTransaction.Name = "TextBox_BankTransaction"
        Me.TextBox_BankTransaction.ReadOnly = True
        Me.TextBox_BankTransaction.Size = New System.Drawing.Size(378, 20)
        Me.TextBox_BankTransaction.TabIndex = 1
        '
        'ContextMenuStrip_ClearBankTransaction
        '
        Me.ContextMenuStrip_ClearBankTransaction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.ContextMenuStrip_ClearBankTransaction.Name = "ContextMenuStrip_ClearBankTransaction"
        Me.ContextMenuStrip_ClearBankTransaction.Size = New System.Drawing.Size(102, 26)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'Label_BankTransaction
        '
        Me.Label_BankTransaction.AutoSize = True
        Me.Label_BankTransaction.Location = New System.Drawing.Point(1, 4)
        Me.Label_BankTransaction.Name = "Label_BankTransaction"
        Me.Label_BankTransaction.Size = New System.Drawing.Size(105, 13)
        Me.Label_BankTransaction.TabIndex = 0
        Me.Label_BankTransaction.Text = "x_Bank-Transaction:"
        '
        'Button_Calc
        '
        Me.Button_Calc.Location = New System.Drawing.Point(484, 2)
        Me.Button_Calc.Name = "Button_Calc"
        Me.Button_Calc.Size = New System.Drawing.Size(34, 23)
        Me.Button_Calc.TabIndex = 6
        Me.Button_Calc.Text = "x_C"
        Me.Button_Calc.UseVisualStyleBackColor = True
        '
        'dlgPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 315)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPayment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dlgPayment"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel_Amount.ResumeLayout(False)
        Me.Panel_Amount.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip_ClearBankTransaction.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_OK As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Clear As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel_Amount As System.Windows.Forms.Panel
    Friend WithEvents Panel_Datetime As System.Windows.Forms.Panel
    Friend WithEvents Label_Currency As System.Windows.Forms.Label
    Friend WithEvents TextBox_Amount As System.Windows.Forms.TextBox
    Friend WithEvents Label_Amount As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button_GetBankTransaction As System.Windows.Forms.Button
    Friend WithEvents TextBox_BankTransaction As System.Windows.Forms.TextBox
    Friend WithEvents Label_BankTransaction As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip_ClearBankTransaction As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_Percent As System.Windows.Forms.Label
    Friend WithEvents TextBox_PercPart As System.Windows.Forms.TextBox
    Friend WithEvents Label_PercPart As System.Windows.Forms.Label
    Friend WithEvents Button_Calc As System.Windows.Forms.Button

End Class
