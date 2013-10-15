<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeManagementEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimeManagementEdit))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Cancel = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Krankheit = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Urlaub = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Private = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Work = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker_Ende = New System.Windows.Forms.DateTimePicker()
        Me.Label_Ende = New System.Windows.Forms.Label()
        Me.Label_Start = New System.Windows.Forms.Label()
        Me.DateTimePicker_Start = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label_Caption = New System.Windows.Forms.Label()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout
        Me.ToolStripContainer1.ContentPanel.SuspendLayout
        Me.ToolStripContainer1.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.GroupBox1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DateTimePicker_Ende)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Ende)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Start)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DateTimePicker_Start)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Name)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Caption)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(400, 140)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(400, 190)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Save, Me.ToolStripButton_Cancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(114, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Save
        '
        Me.ToolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Save.Image = CType(resources.GetObject("ToolStripButton_Save.Image"),System.Drawing.Image)
        Me.ToolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
        Me.ToolStripButton_Save.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripButton_Save.Text = "x_Save"
        '
        'ToolStripButton_Cancel
        '
        Me.ToolStripButton_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Cancel.Image = CType(resources.GetObject("ToolStripButton_Cancel.Image"),System.Drawing.Image)
        Me.ToolStripButton_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Cancel.Name = "ToolStripButton_Cancel"
        Me.ToolStripButton_Cancel.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton_Cancel.Text = "x_Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(3, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "x_LogState:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadioButton_Krankheit)
        Me.GroupBox1.Controls.Add(Me.RadioButton_Urlaub)
        Me.GroupBox1.Controls.Add(Me.RadioButton_Private)
        Me.GroupBox1.Controls.Add(Me.RadioButton_Work)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 87)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = false
        '
        'RadioButton_Krankheit
        '
        Me.RadioButton_Krankheit.AutoSize = true
        Me.RadioButton_Krankheit.Location = New System.Drawing.Point(7, 85)
        Me.RadioButton_Krankheit.Name = "RadioButton_Krankheit"
        Me.RadioButton_Krankheit.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton_Krankheit.TabIndex = 3
        Me.RadioButton_Krankheit.TabStop = true
        Me.RadioButton_Krankheit.Text = "x_Krankheit"
        Me.RadioButton_Krankheit.UseVisualStyleBackColor = true
        '
        'RadioButton_Urlaub
        '
        Me.RadioButton_Urlaub.AutoSize = true
        Me.RadioButton_Urlaub.Location = New System.Drawing.Point(7, 61)
        Me.RadioButton_Urlaub.Name = "RadioButton_Urlaub"
        Me.RadioButton_Urlaub.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton_Urlaub.TabIndex = 2
        Me.RadioButton_Urlaub.TabStop = true
        Me.RadioButton_Urlaub.Text = "x_Urlaub"
        Me.RadioButton_Urlaub.UseVisualStyleBackColor = true
        '
        'RadioButton_Private
        '
        Me.RadioButton_Private.AutoSize = true
        Me.RadioButton_Private.Location = New System.Drawing.Point(7, 37)
        Me.RadioButton_Private.Name = "RadioButton_Private"
        Me.RadioButton_Private.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton_Private.TabIndex = 1
        Me.RadioButton_Private.TabStop = true
        Me.RadioButton_Private.Text = "x_Private"
        Me.RadioButton_Private.UseVisualStyleBackColor = true
        '
        'RadioButton_Work
        '
        Me.RadioButton_Work.AutoSize = true
        Me.RadioButton_Work.Checked = true
        Me.RadioButton_Work.Location = New System.Drawing.Point(7, 13)
        Me.RadioButton_Work.Name = "RadioButton_Work"
        Me.RadioButton_Work.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton_Work.TabIndex = 0
        Me.RadioButton_Work.TabStop = true
        Me.RadioButton_Work.Text = "x_Work"
        Me.RadioButton_Work.UseVisualStyleBackColor = true
        '
        'DateTimePicker_Ende
        '
        Me.DateTimePicker_Ende.CustomFormat = "dd.MM.yyy HH:mm:ss"
        Me.DateTimePicker_Ende.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Ende.Location = New System.Drawing.Point(261, 31)
        Me.DateTimePicker_Ende.Name = "DateTimePicker_Ende"
        Me.DateTimePicker_Ende.Size = New System.Drawing.Size(136, 20)
        Me.DateTimePicker_Ende.TabIndex = 5
        '
        'Label_Ende
        '
        Me.Label_Ende.AutoSize = true
        Me.Label_Ende.Location = New System.Drawing.Point(215, 34)
        Me.Label_Ende.Name = "Label_Ende"
        Me.Label_Ende.Size = New System.Drawing.Size(46, 13)
        Me.Label_Ende.TabIndex = 4
        Me.Label_Ende.Text = "x_Ende:"
        '
        'Label_Start
        '
        Me.Label_Start.AutoSize = true
        Me.Label_Start.Location = New System.Drawing.Point(3, 34)
        Me.Label_Start.Name = "Label_Start"
        Me.Label_Start.Size = New System.Drawing.Size(43, 13)
        Me.Label_Start.TabIndex = 3
        Me.Label_Start.Text = "x_Start:"
        '
        'DateTimePicker_Start
        '
        Me.DateTimePicker_Start.CustomFormat = "dd.MM.yyy HH:mm:ss"
        Me.DateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Start.Location = New System.Drawing.Point(73, 31)
        Me.DateTimePicker_Start.Name = "DateTimePicker_Start"
        Me.DateTimePicker_Start.Size = New System.Drawing.Size(136, 20)
        Me.DateTimePicker_Start.TabIndex = 2
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TextBox_Name.Location = New System.Drawing.Point(73, 4)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(324, 20)
        Me.TextBox_Name.TabIndex = 1
        '
        'Label_Caption
        '
        Me.Label_Caption.AutoSize = true
        Me.Label_Caption.Location = New System.Drawing.Point(3, 7)
        Me.Label_Caption.Name = "Label_Caption"
        Me.Label_Caption.Size = New System.Drawing.Size(49, 13)
        Me.Label_Caption.TabIndex = 0
        Me.Label_Caption.Text = "x_Name:"
        '
        'frmTimeManagementEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 190)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "frmTimeManagementEdit"
        Me.Text = "frmTimeManagementEdit"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(false)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(false)
        Me.ToolStripContainer1.ContentPanel.PerformLayout
        Me.ToolStripContainer1.ResumeLayout(false)
        Me.ToolStripContainer1.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_Krankheit As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Urlaub As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Private As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Work As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker_Ende As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_Ende As System.Windows.Forms.Label
    Friend WithEvents Label_Start As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_Start As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label_Caption As System.Windows.Forms.Label
End Class
