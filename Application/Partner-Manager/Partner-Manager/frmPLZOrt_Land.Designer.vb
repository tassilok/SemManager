<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPLZOrt_Land
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPLZOrt_Land))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton_Apply = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel_PLZ = New System.Windows.Forms.Panel
        Me.Label_PLZ = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Panel_Ort = New System.Windows.Forms.Panel
        Me.Label_Ort = New System.Windows.Forms.Label
        Me.Panel_Land = New System.Windows.Forms.Panel
        Me.Label_Land = New System.Windows.Forms.Label
        Me.ToolStripButton_Clear = New System.Windows.Forms.ToolStripButton
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(725, 333)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(725, 383)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Apply, Me.ToolStripButton_Clear})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(112, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Apply
        '
        Me.ToolStripButton_Apply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Apply.Enabled = False
        Me.ToolStripButton_Apply.Image = CType(resources.GetObject("ToolStripButton_Apply.Image"), System.Drawing.Image)
        Me.ToolStripButton_Apply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Apply.Name = "ToolStripButton_Apply"
        Me.ToolStripButton_Apply.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton_Apply.Text = "x_Apply"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel_PLZ)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_PLZ)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(725, 333)
        Me.SplitContainer1.SplitterDistance = 105
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel_PLZ
        '
        Me.Panel_PLZ.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_PLZ.Location = New System.Drawing.Point(2, 21)
        Me.Panel_PLZ.Name = "Panel_PLZ"
        Me.Panel_PLZ.Size = New System.Drawing.Size(718, 79)
        Me.Panel_PLZ.TabIndex = 1
        '
        'Label_PLZ
        '
        Me.Label_PLZ.AutoSize = True
        Me.Label_PLZ.Location = New System.Drawing.Point(4, 4)
        Me.Label_PLZ.Name = "Label_PLZ"
        Me.Label_PLZ.Size = New System.Drawing.Size(41, 13)
        Me.Label_PLZ.TabIndex = 0
        Me.Label_PLZ.Text = "x_PLZ:"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel_Ort)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label_Ort)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel_Land)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label_Land)
        Me.SplitContainer2.Size = New System.Drawing.Size(725, 224)
        Me.SplitContainer2.SplitterDistance = 116
        Me.SplitContainer2.TabIndex = 0
        '
        'Panel_Ort
        '
        Me.Panel_Ort.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Ort.Location = New System.Drawing.Point(4, 20)
        Me.Panel_Ort.Name = "Panel_Ort"
        Me.Panel_Ort.Size = New System.Drawing.Size(716, 89)
        Me.Panel_Ort.TabIndex = 1
        '
        'Label_Ort
        '
        Me.Label_Ort.AutoSize = True
        Me.Label_Ort.Location = New System.Drawing.Point(4, 3)
        Me.Label_Ort.Name = "Label_Ort"
        Me.Label_Ort.Size = New System.Drawing.Size(35, 13)
        Me.Label_Ort.TabIndex = 0
        Me.Label_Ort.Text = "x_Ort:"
        '
        'Panel_Land
        '
        Me.Panel_Land.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Land.Location = New System.Drawing.Point(4, 21)
        Me.Panel_Land.Name = "Panel_Land"
        Me.Panel_Land.Size = New System.Drawing.Size(716, 78)
        Me.Panel_Land.TabIndex = 1
        '
        'Label_Land
        '
        Me.Label_Land.AutoSize = True
        Me.Label_Land.Location = New System.Drawing.Point(4, 4)
        Me.Label_Land.Name = "Label_Land"
        Me.Label_Land.Size = New System.Drawing.Size(45, 13)
        Me.Label_Land.TabIndex = 0
        Me.Label_Land.Text = "x_Land:"
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
        'frmPLZOrt_Land
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 383)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmPLZOrt_Land"
        Me.Text = "x_frmPLZOrt_Land"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Apply As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label_PLZ As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label_Ort As System.Windows.Forms.Label
    Friend WithEvents Label_Land As System.Windows.Forms.Label
    Friend WithEvents Panel_PLZ As System.Windows.Forms.Panel
    Friend WithEvents Panel_Ort As System.Windows.Forms.Panel
    Friend WithEvents Panel_Land As System.Windows.Forms.Panel
    Friend WithEvents ToolStripButton_Clear As System.Windows.Forms.ToolStripButton
End Class
