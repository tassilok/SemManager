<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Adress
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Adress))
        Me.Label_Strasse = New System.Windows.Forms.Label
        Me.TextBox_Strasse = New System.Windows.Forms.TextBox
        Me.Label_Zusatz = New System.Windows.Forms.Label
        Me.TextBox_Zusatz = New System.Windows.Forms.TextBox
        Me.TextBox_PLZOrtLand = New System.Windows.Forms.TextBox
        Me.Button_addPLZOrtLand = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton_Apply = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel_CountAddresses_lbl = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel_AxiomAddresses = New System.Windows.Forms.ToolStripLabel
        Me.Label_Postfach = New System.Windows.Forms.Label
        Me.Timer_Zusatz = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Strasse = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Postfach = New System.Windows.Forms.Timer(Me.components)
        Me.Label_PlzOrtLand = New System.Windows.Forms.Label
        Me.MaskedTextBox_Postfach = New System.Windows.Forms.MaskedTextBox
        Me.Button_DelPLZOrtLand = New System.Windows.Forms.Button
        Me.ImageList_UserControl = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Strasse
        '
        Me.Label_Strasse.AutoSize = True
        Me.Label_Strasse.Location = New System.Drawing.Point(3, 64)
        Me.Label_Strasse.Name = "Label_Strasse"
        Me.Label_Strasse.Size = New System.Drawing.Size(50, 13)
        Me.Label_Strasse.TabIndex = 0
        Me.Label_Strasse.Text = "Straße_f:"
        '
        'TextBox_Strasse
        '
        Me.TextBox_Strasse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Strasse.Location = New System.Drawing.Point(127, 61)
        Me.TextBox_Strasse.Name = "TextBox_Strasse"
        Me.TextBox_Strasse.Size = New System.Drawing.Size(400, 20)
        Me.TextBox_Strasse.TabIndex = 1
        '
        'Label_Zusatz
        '
        Me.Label_Zusatz.AutoSize = True
        Me.Label_Zusatz.Location = New System.Drawing.Point(3, 38)
        Me.Label_Zusatz.Name = "Label_Zusatz"
        Me.Label_Zusatz.Size = New System.Drawing.Size(81, 13)
        Me.Label_Zusatz.TabIndex = 2
        Me.Label_Zusatz.Text = "Adresszusatz_f:"
        '
        'TextBox_Zusatz
        '
        Me.TextBox_Zusatz.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Zusatz.Location = New System.Drawing.Point(127, 35)
        Me.TextBox_Zusatz.Name = "TextBox_Zusatz"
        Me.TextBox_Zusatz.Size = New System.Drawing.Size(400, 20)
        Me.TextBox_Zusatz.TabIndex = 3
        '
        'TextBox_PLZOrtLand
        '
        Me.TextBox_PLZOrtLand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_PLZOrtLand.Location = New System.Drawing.Point(125, 113)
        Me.TextBox_PLZOrtLand.Multiline = True
        Me.TextBox_PLZOrtLand.Name = "TextBox_PLZOrtLand"
        Me.TextBox_PLZOrtLand.ReadOnly = True
        Me.TextBox_PLZOrtLand.Size = New System.Drawing.Size(402, 63)
        Me.TextBox_PLZOrtLand.TabIndex = 5
        '
        'Button_addPLZOrtLand
        '
        Me.Button_addPLZOrtLand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_addPLZOrtLand.Location = New System.Drawing.Point(531, 113)
        Me.Button_addPLZOrtLand.Name = "Button_addPLZOrtLand"
        Me.Button_addPLZOrtLand.Size = New System.Drawing.Size(27, 23)
        Me.Button_addPLZOrtLand.TabIndex = 6
        Me.Button_addPLZOrtLand.Text = "..."
        Me.Button_addPLZOrtLand.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Apply, Me.ToolStripSeparator1, Me.ToolStripLabel_CountAddresses_lbl, Me.ToolStripLabel_AxiomAddresses})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(561, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton_Apply
        '
        Me.ToolStripButton_Apply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Apply.Image = CType(resources.GetObject("ToolStripButton_Apply.Image"), System.Drawing.Image)
        Me.ToolStripButton_Apply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Apply.Name = "ToolStripButton_Apply"
        Me.ToolStripButton_Apply.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton_Apply.Text = "Apply_f"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_CountAddresses_lbl
        '
        Me.ToolStripLabel_CountAddresses_lbl.Name = "ToolStripLabel_CountAddresses_lbl"
        Me.ToolStripLabel_CountAddresses_lbl.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel_CountAddresses_lbl.Text = "Adresses_f:"
        '
        'ToolStripLabel_AxiomAddresses
        '
        Me.ToolStripLabel_AxiomAddresses.Name = "ToolStripLabel_AxiomAddresses"
        Me.ToolStripLabel_AxiomAddresses.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel_AxiomAddresses.Text = "0/0/0"
        '
        'Label_Postfach
        '
        Me.Label_Postfach.AutoSize = True
        Me.Label_Postfach.Location = New System.Drawing.Point(3, 90)
        Me.Label_Postfach.Name = "Label_Postfach"
        Me.Label_Postfach.Size = New System.Drawing.Size(61, 13)
        Me.Label_Postfach.TabIndex = 8
        Me.Label_Postfach.Text = "Postfach_f:"
        '
        'Timer_Zusatz
        '
        '
        'Timer_Strasse
        '
        '
        'Timer_Postfach
        '
        Me.Timer_Postfach.Interval = 500
        '
        'Label_PlzOrtLand
        '
        Me.Label_PlzOrtLand.AutoSize = True
        Me.Label_PlzOrtLand.Location = New System.Drawing.Point(3, 118)
        Me.Label_PlzOrtLand.Name = "Label_PlzOrtLand"
        Me.Label_PlzOrtLand.Size = New System.Drawing.Size(87, 13)
        Me.Label_PlzOrtLand.TabIndex = 13
        Me.Label_PlzOrtLand.Text = "PLZ/Ort/Land_f:"
        '
        'MaskedTextBox_Postfach
        '
        Me.MaskedTextBox_Postfach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox_Postfach.Location = New System.Drawing.Point(127, 87)
        Me.MaskedTextBox_Postfach.Mask = "00 00 00 00 00"
        Me.MaskedTextBox_Postfach.Name = "MaskedTextBox_Postfach"
        Me.MaskedTextBox_Postfach.Size = New System.Drawing.Size(400, 20)
        Me.MaskedTextBox_Postfach.TabIndex = 14
        '
        'Button_DelPLZOrtLand
        '
        Me.Button_DelPLZOrtLand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_DelPLZOrtLand.Enabled = False
        Me.Button_DelPLZOrtLand.ImageIndex = 0
        Me.Button_DelPLZOrtLand.ImageList = Me.ImageList_UserControl
        Me.Button_DelPLZOrtLand.Location = New System.Drawing.Point(531, 142)
        Me.Button_DelPLZOrtLand.Name = "Button_DelPLZOrtLand"
        Me.Button_DelPLZOrtLand.Size = New System.Drawing.Size(27, 23)
        Me.Button_DelPLZOrtLand.TabIndex = 15
        Me.Button_DelPLZOrtLand.UseVisualStyleBackColor = True
        '
        'ImageList_UserControl
        '
        Me.ImageList_UserControl.ImageStream = CType(resources.GetObject("ImageList_UserControl.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_UserControl.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_UserControl.Images.SetKeyName(0, "tasto_8_architetto_franc_01.png")
        '
        'UserControl_Adress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button_DelPLZOrtLand)
        Me.Controls.Add(Me.MaskedTextBox_Postfach)
        Me.Controls.Add(Me.Label_PlzOrtLand)
        Me.Controls.Add(Me.Label_Postfach)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button_addPLZOrtLand)
        Me.Controls.Add(Me.TextBox_PLZOrtLand)
        Me.Controls.Add(Me.TextBox_Zusatz)
        Me.Controls.Add(Me.Label_Zusatz)
        Me.Controls.Add(Me.TextBox_Strasse)
        Me.Controls.Add(Me.Label_Strasse)
        Me.Name = "UserControl_Adress"
        Me.Size = New System.Drawing.Size(561, 185)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Strasse As System.Windows.Forms.Label
    Friend WithEvents TextBox_Strasse As System.Windows.Forms.TextBox
    Friend WithEvents Label_Zusatz As System.Windows.Forms.Label
    Friend WithEvents TextBox_Zusatz As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_PLZOrtLand As System.Windows.Forms.TextBox
    Friend WithEvents Button_addPLZOrtLand As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Apply As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label_Postfach As System.Windows.Forms.Label
    Friend WithEvents Timer_Zusatz As System.Windows.Forms.Timer
    Friend WithEvents Timer_Strasse As System.Windows.Forms.Timer
    Friend WithEvents Timer_Postfach As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_CountAddresses_lbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_AxiomAddresses As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label_PlzOrtLand As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_Postfach As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button_DelPLZOrtLand As System.Windows.Forms.Button
    Friend WithEvents ImageList_UserControl As System.Windows.Forms.ImageList

End Class
