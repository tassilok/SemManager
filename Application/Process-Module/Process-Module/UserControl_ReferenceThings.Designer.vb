<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_ReferenceThings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_ReferenceThings))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Button_Add_Reference = New System.Windows.Forms.Button()
        Me.TextBox_Reference = New System.Windows.Forms.TextBox()
        Me.Label_Reference = New System.Windows.Forms.Label()
        Me.TextBox_Count = New System.Windows.Forms.TextBox()
        Me.Label_Count = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Clear = New System.Windows.Forms.ToolStripButton()
        Me.Timer_Count = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Add_Reference)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Reference)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Reference)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Count)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Count)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(452, 283)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(452, 308)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'Button_Add_Reference
        '
        Me.Button_Add_Reference.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Add_Reference.Location = New System.Drawing.Point(419, 25)
        Me.Button_Add_Reference.Name = "Button_Add_Reference"
        Me.Button_Add_Reference.Size = New System.Drawing.Size(30, 23)
        Me.Button_Add_Reference.TabIndex = 6
        Me.Button_Add_Reference.Text = "..."
        Me.Button_Add_Reference.UseVisualStyleBackColor = True
        '
        'TextBox_Reference
        '
        Me.TextBox_Reference.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Reference.Location = New System.Drawing.Point(80, 27)
        Me.TextBox_Reference.Name = "TextBox_Reference"
        Me.TextBox_Reference.Size = New System.Drawing.Size(337, 20)
        Me.TextBox_Reference.TabIndex = 5
        '
        'Label_Reference
        '
        Me.Label_Reference.AutoSize = True
        Me.Label_Reference.Location = New System.Drawing.Point(3, 30)
        Me.Label_Reference.Name = "Label_Reference"
        Me.Label_Reference.Size = New System.Drawing.Size(71, 13)
        Me.Label_Reference.TabIndex = 4
        Me.Label_Reference.Text = "x_Reference:"
        '
        'TextBox_Count
        '
        Me.TextBox_Count.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Count.Enabled = False
        Me.TextBox_Count.Location = New System.Drawing.Point(80, 4)
        Me.TextBox_Count.Name = "TextBox_Count"
        Me.TextBox_Count.Size = New System.Drawing.Size(369, 20)
        Me.TextBox_Count.TabIndex = 3
        '
        'Label_Count
        '
        Me.Label_Count.AutoSize = True
        Me.Label_Count.Location = New System.Drawing.Point(3, 7)
        Me.Label_Count.Name = "Label_Count"
        Me.Label_Count.Size = New System.Drawing.Size(49, 13)
        Me.Label_Count.TabIndex = 2
        Me.Label_Count.Text = "x_Count:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Clear})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(60, 25)
        Me.ToolStrip1.TabIndex = 0
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
        'Timer_Count
        '
        '
        'UserControl_ReferenceThings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_ReferenceThings"
        Me.Size = New System.Drawing.Size(452, 308)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TextBox_Count As System.Windows.Forms.TextBox
    Friend WithEvents Label_Count As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Clear As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button_Add_Reference As System.Windows.Forms.Button
    Friend WithEvents TextBox_Reference As System.Windows.Forms.TextBox
    Friend WithEvents Label_Reference As System.Windows.Forms.Label
    Friend WithEvents Timer_Count As System.Windows.Forms.Timer

End Class
