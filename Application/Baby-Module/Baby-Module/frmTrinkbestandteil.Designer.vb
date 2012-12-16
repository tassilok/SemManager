<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrinkbestandteil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrinkbestandteil))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Cancel = New System.Windows.Forms.ToolStripButton()
        Me.Label_Menge = New System.Windows.Forms.Label()
        Me.Panel_Menge = New System.Windows.Forms.Panel()
        Me.ComboBox_Nahrungsmittel = New System.Windows.Forms.ComboBox()
        Me.Label_Nahrungsmittel = New System.Windows.Forms.Label()
        Me.ComboBox_Medikament = New System.Windows.Forms.ComboBox()
        Me.Label_Medikament = New System.Windows.Forms.Label()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Menge)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Panel_Menge)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ComboBox_Nahrungsmittel)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Nahrungsmittel)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ComboBox_Medikament)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Medikament)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(432, 162)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(432, 187)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Save, Me.ToolStripButton_Cancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(145, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Save
        '
        Me.ToolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Save.Image = CType(resources.GetObject("ToolStripButton_Save.Image"), System.Drawing.Image)
        Me.ToolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
        Me.ToolStripButton_Save.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripButton_Save.Text = "x_Save"
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
        'Label_Menge
        '
        Me.Label_Menge.AutoSize = True
        Me.Label_Menge.Location = New System.Drawing.Point(12, 63)
        Me.Label_Menge.Name = "Label_Menge"
        Me.Label_Menge.Size = New System.Drawing.Size(54, 13)
        Me.Label_Menge.TabIndex = 5
        Me.Label_Menge.Text = "x_Menge:"
        '
        'Panel_Menge
        '
        Me.Panel_Menge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Menge.Location = New System.Drawing.Point(109, 60)
        Me.Panel_Menge.Name = "Panel_Menge"
        Me.Panel_Menge.Size = New System.Drawing.Size(317, 94)
        Me.Panel_Menge.TabIndex = 4
        '
        'ComboBox_Nahrungsmittel
        '
        Me.ComboBox_Nahrungsmittel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Nahrungsmittel.FormattingEnabled = True
        Me.ComboBox_Nahrungsmittel.Location = New System.Drawing.Point(109, 33)
        Me.ComboBox_Nahrungsmittel.Name = "ComboBox_Nahrungsmittel"
        Me.ComboBox_Nahrungsmittel.Size = New System.Drawing.Size(317, 21)
        Me.ComboBox_Nahrungsmittel.TabIndex = 3
        '
        'Label_Nahrungsmittel
        '
        Me.Label_Nahrungsmittel.AutoSize = True
        Me.Label_Nahrungsmittel.Location = New System.Drawing.Point(12, 36)
        Me.Label_Nahrungsmittel.Name = "Label_Nahrungsmittel"
        Me.Label_Nahrungsmittel.Size = New System.Drawing.Size(91, 13)
        Me.Label_Nahrungsmittel.TabIndex = 2
        Me.Label_Nahrungsmittel.Text = "x_Nahrungsmittel:"
        '
        'ComboBox_Medikament
        '
        Me.ComboBox_Medikament.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Medikament.FormattingEnabled = True
        Me.ComboBox_Medikament.Location = New System.Drawing.Point(109, 6)
        Me.ComboBox_Medikament.Name = "ComboBox_Medikament"
        Me.ComboBox_Medikament.Size = New System.Drawing.Size(317, 21)
        Me.ComboBox_Medikament.TabIndex = 1
        '
        'Label_Medikament
        '
        Me.Label_Medikament.AutoSize = True
        Me.Label_Medikament.Location = New System.Drawing.Point(12, 9)
        Me.Label_Medikament.Name = "Label_Medikament"
        Me.Label_Medikament.Size = New System.Drawing.Size(79, 13)
        Me.Label_Medikament.TabIndex = 0
        Me.Label_Medikament.Text = "x_Medikament:"
        '
        'frmTrinkbestandteil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 187)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmTrinkbestandteil"
        Me.Text = "frmTrinkbestandteil"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label_Menge As System.Windows.Forms.Label
    Friend WithEvents Panel_Menge As System.Windows.Forms.Panel
    Friend WithEvents ComboBox_Nahrungsmittel As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Nahrungsmittel As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Medikament As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Medikament As System.Windows.Forms.Label
End Class
