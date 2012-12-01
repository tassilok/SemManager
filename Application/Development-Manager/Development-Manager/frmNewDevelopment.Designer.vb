<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewDevelopment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewDevelopment))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_OK = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Cancel = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_PLanguage_OK = New System.Windows.Forms.Label()
        Me.Label_StdLanguage_OK = New System.Windows.Forms.Label()
        Me.Label_Version_OK = New System.Windows.Forms.Label()
        Me.Panel_PLanguage = New System.Windows.Forms.Panel()
        Me.Label_PLanguage = New System.Windows.Forms.Label()
        Me.Panel_StdLanguage = New System.Windows.Forms.Panel()
        Me.Label_StdLanguage = New System.Windows.Forms.Label()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Panel_Version = New System.Windows.Forms.Panel()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Label_Name_OK = New System.Windows.Forms.Label()
        Me.Timer_Name = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip_Name = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip_StdLanguage = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip_Version = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip_PLanguage = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(789, 402)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(789, 427)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_OK, Me.ToolStripButton_Cancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(104, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_OK
        '
        Me.ToolStripButton_OK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_OK.Enabled = False
        Me.ToolStripButton_OK.Image = CType(resources.GetObject("ToolStripButton_OK.Image"), System.Drawing.Image)
        Me.ToolStripButton_OK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_OK.Name = "ToolStripButton_OK"
        Me.ToolStripButton_OK.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripButton_OK.Text = "OK_f"
        '
        'ToolStripButton_Cancel
        '
        Me.ToolStripButton_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Cancel.Image = CType(resources.GetObject("ToolStripButton_Cancel.Image"), System.Drawing.Image)
        Me.ToolStripButton_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Cancel.Name = "ToolStripButton_Cancel"
        Me.ToolStripButton_Cancel.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton_Cancel.Text = "Cancel_f"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label_PLanguage_OK, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_StdLanguage_OK, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Version_OK, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_PLanguage, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_PLanguage, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_StdLanguage, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_StdLanguage, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Version, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_Version, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Name, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Name, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Name_OK, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(789, 402)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'Label_PLanguage_OK
        '
        Me.Label_PLanguage_OK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_PLanguage_OK.AutoSize = True
        Me.Label_PLanguage_OK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_PLanguage_OK.Location = New System.Drawing.Point(756, 256)
        Me.Label_PLanguage_OK.Name = "Label_PLanguage_OK"
        Me.Label_PLanguage_OK.Padding = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.Label_PLanguage_OK.Size = New System.Drawing.Size(30, 146)
        Me.Label_PLanguage_OK.TabIndex = 15
        '
        'Label_StdLanguage_OK
        '
        Me.Label_StdLanguage_OK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_StdLanguage_OK.AutoSize = True
        Me.Label_StdLanguage_OK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_StdLanguage_OK.Location = New System.Drawing.Point(756, 110)
        Me.Label_StdLanguage_OK.Name = "Label_StdLanguage_OK"
        Me.Label_StdLanguage_OK.Padding = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.Label_StdLanguage_OK.Size = New System.Drawing.Size(30, 146)
        Me.Label_StdLanguage_OK.TabIndex = 14
        '
        'Label_Version_OK
        '
        Me.Label_Version_OK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Version_OK.AutoSize = True
        Me.Label_Version_OK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_Version_OK.Location = New System.Drawing.Point(756, 25)
        Me.Label_Version_OK.Name = "Label_Version_OK"
        Me.Label_Version_OK.Padding = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.Label_Version_OK.Size = New System.Drawing.Size(30, 85)
        Me.Label_Version_OK.TabIndex = 13
        '
        'Panel_PLanguage
        '
        Me.Panel_PLanguage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_PLanguage.Location = New System.Drawing.Point(97, 259)
        Me.Panel_PLanguage.Name = "Panel_PLanguage"
        Me.Panel_PLanguage.Size = New System.Drawing.Size(653, 140)
        Me.Panel_PLanguage.TabIndex = 9
        '
        'Label_PLanguage
        '
        Me.Label_PLanguage.AutoSize = True
        Me.Label_PLanguage.Location = New System.Drawing.Point(3, 256)
        Me.Label_PLanguage.Name = "Label_PLanguage"
        Me.Label_PLanguage.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label_PLanguage.Size = New System.Drawing.Size(67, 31)
        Me.Label_PLanguage.TabIndex = 8
        Me.Label_PLanguage.Text = "Programing-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Language_f:"
        '
        'Panel_StdLanguage
        '
        Me.Panel_StdLanguage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_StdLanguage.Location = New System.Drawing.Point(97, 113)
        Me.Panel_StdLanguage.Name = "Panel_StdLanguage"
        Me.Panel_StdLanguage.Size = New System.Drawing.Size(653, 140)
        Me.Panel_StdLanguage.TabIndex = 7
        '
        'Label_StdLanguage
        '
        Me.Label_StdLanguage.AutoSize = True
        Me.Label_StdLanguage.Location = New System.Drawing.Point(3, 110)
        Me.Label_StdLanguage.Name = "Label_StdLanguage"
        Me.Label_StdLanguage.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label_StdLanguage.Size = New System.Drawing.Size(67, 31)
        Me.Label_StdLanguage.TabIndex = 6
        Me.Label_StdLanguage.Text = "Standard-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Language_f:"
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Location = New System.Drawing.Point(3, 25)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label_Version.Size = New System.Drawing.Size(54, 18)
        Me.Label_Version.TabIndex = 5
        Me.Label_Version.Text = "Version_f:"
        '
        'Panel_Version
        '
        Me.Panel_Version.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Version.Location = New System.Drawing.Point(97, 28)
        Me.Panel_Version.Name = "Panel_Version"
        Me.Panel_Version.Size = New System.Drawing.Size(300, 79)
        Me.Panel_Version.TabIndex = 2
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Name.Location = New System.Drawing.Point(97, 3)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(653, 20)
        Me.TextBox_Name.TabIndex = 10
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Location = New System.Drawing.Point(3, 0)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label_Name.Size = New System.Drawing.Size(81, 18)
        Me.Label_Name.TabIndex = 11
        Me.Label_Name.Text = "Bezeichnung_f:"
        '
        'Label_Name_OK
        '
        Me.Label_Name_OK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Name_OK.AutoSize = True
        Me.Label_Name_OK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_Name_OK.Location = New System.Drawing.Point(756, 0)
        Me.Label_Name_OK.Name = "Label_Name_OK"
        Me.Label_Name_OK.Padding = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.Label_Name_OK.Size = New System.Drawing.Size(30, 25)
        Me.Label_Name_OK.TabIndex = 12
        '
        'Timer_Name
        '
        Me.Timer_Name.Interval = 500
        '
        'frmNewDevelopment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 427)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNewDevelopment"
        Me.Text = "frmNewDevelopment"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_OK As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel_PLanguage As System.Windows.Forms.Panel
    Friend WithEvents Label_PLanguage As System.Windows.Forms.Label
    Friend WithEvents Panel_StdLanguage As System.Windows.Forms.Panel
    Friend WithEvents Label_StdLanguage As System.Windows.Forms.Label
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents Panel_Version As System.Windows.Forms.Panel
    Friend WithEvents TextBox_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label_Name As System.Windows.Forms.Label
    Friend WithEvents Timer_Name As System.Windows.Forms.Timer
    Friend WithEvents Label_PLanguage_OK As System.Windows.Forms.Label
    Friend WithEvents Label_StdLanguage_OK As System.Windows.Forms.Label
    Friend WithEvents Label_Version_OK As System.Windows.Forms.Label
    Friend WithEvents Label_Name_OK As System.Windows.Forms.Label
    Friend WithEvents ToolTip_Name As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip_StdLanguage As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip_Version As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip_PLanguage As System.Windows.Forms.ToolTip
End Class
