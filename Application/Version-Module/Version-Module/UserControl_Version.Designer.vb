<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Version
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Version))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton_Apply = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton_Clear = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton_Cancel = New System.Windows.Forms.ToolStripButton
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.NumericUpDown_Marjor = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown_Minor = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown_Build = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown_Revision = New System.Windows.Forms.NumericUpDown
        Me.Label_Major = New System.Windows.Forms.Label
        Me.Label_Minor = New System.Windows.Forms.Label
        Me.Label_Build = New System.Windows.Forms.Label
        Me.Label_Revision = New System.Windows.Forms.Label
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDown_Marjor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Minor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Build, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Revision, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(300, 51)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(300, 76)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Apply, Me.ToolStripButton_Clear, Me.ToolStripButton_Cancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(166, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Apply
        '
        Me.ToolStripButton_Apply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Apply.Enabled = False
        Me.ToolStripButton_Apply.Image = CType(resources.GetObject("ToolStripButton_Apply.Image"), System.Drawing.Image)
        Me.ToolStripButton_Apply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Apply.Name = "ToolStripButton_Apply"
        Me.ToolStripButton_Apply.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton_Apply.Text = "Apply_f"
        '
        'ToolStripButton_Clear
        '
        Me.ToolStripButton_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Clear.Enabled = False
        Me.ToolStripButton_Clear.Image = CType(resources.GetObject("ToolStripButton_Clear.Image"), System.Drawing.Image)
        Me.ToolStripButton_Clear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Clear.Name = "ToolStripButton_Clear"
        Me.ToolStripButton_Clear.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripButton_Clear.Text = "Clear_f"
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
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown_Marjor, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown_Minor, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown_Build, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown_Revision, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Major, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Minor, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Build, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Revision, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.69231!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.30769!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(300, 51)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'NumericUpDown_Marjor
        '
        Me.NumericUpDown_Marjor.Location = New System.Drawing.Point(3, 19)
        Me.NumericUpDown_Marjor.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown_Marjor.Name = "NumericUpDown_Marjor"
        Me.NumericUpDown_Marjor.Size = New System.Drawing.Size(57, 20)
        Me.NumericUpDown_Marjor.TabIndex = 0
        '
        'NumericUpDown_Minor
        '
        Me.NumericUpDown_Minor.Location = New System.Drawing.Point(78, 19)
        Me.NumericUpDown_Minor.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown_Minor.Name = "NumericUpDown_Minor"
        Me.NumericUpDown_Minor.Size = New System.Drawing.Size(57, 20)
        Me.NumericUpDown_Minor.TabIndex = 1
        '
        'NumericUpDown_Build
        '
        Me.NumericUpDown_Build.Location = New System.Drawing.Point(153, 19)
        Me.NumericUpDown_Build.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown_Build.Name = "NumericUpDown_Build"
        Me.NumericUpDown_Build.Size = New System.Drawing.Size(57, 20)
        Me.NumericUpDown_Build.TabIndex = 2
        '
        'NumericUpDown_Revision
        '
        Me.NumericUpDown_Revision.Location = New System.Drawing.Point(228, 19)
        Me.NumericUpDown_Revision.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown_Revision.Name = "NumericUpDown_Revision"
        Me.NumericUpDown_Revision.Size = New System.Drawing.Size(59, 20)
        Me.NumericUpDown_Revision.TabIndex = 3
        '
        'Label_Major
        '
        Me.Label_Major.AutoSize = True
        Me.Label_Major.Location = New System.Drawing.Point(3, 0)
        Me.Label_Major.Name = "Label_Major"
        Me.Label_Major.Size = New System.Drawing.Size(45, 13)
        Me.Label_Major.TabIndex = 4
        Me.Label_Major.Text = "Marjor_f"
        '
        'Label_Minor
        '
        Me.Label_Minor.AutoSize = True
        Me.Label_Minor.Location = New System.Drawing.Point(78, 0)
        Me.Label_Minor.Name = "Label_Minor"
        Me.Label_Minor.Size = New System.Drawing.Size(42, 13)
        Me.Label_Minor.TabIndex = 5
        Me.Label_Minor.Text = "Minor_f"
        '
        'Label_Build
        '
        Me.Label_Build.AutoSize = True
        Me.Label_Build.Location = New System.Drawing.Point(153, 0)
        Me.Label_Build.Name = "Label_Build"
        Me.Label_Build.Size = New System.Drawing.Size(39, 13)
        Me.Label_Build.TabIndex = 6
        Me.Label_Build.Text = "Build_f"
        '
        'Label_Revision
        '
        Me.Label_Revision.AutoSize = True
        Me.Label_Revision.Location = New System.Drawing.Point(228, 0)
        Me.Label_Revision.Name = "Label_Revision"
        Me.Label_Revision.Size = New System.Drawing.Size(57, 13)
        Me.Label_Revision.TabIndex = 7
        Me.Label_Revision.Text = "Revision_f"
        '
        'UserControl_Version
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_Version"
        Me.Size = New System.Drawing.Size(300, 76)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.NumericUpDown_Marjor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Minor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Build, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Revision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Apply As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Clear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NumericUpDown_Marjor As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_Minor As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_Build As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_Revision As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_Major As System.Windows.Forms.Label
    Friend WithEvents Label_Minor As System.Windows.Forms.Label
    Friend WithEvents Label_Build As System.Windows.Forms.Label
    Friend WithEvents Label_Revision As System.Windows.Forms.Label

End Class
