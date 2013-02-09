<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassEdit
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_Database = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_DatabaseLBL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_ClassLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_Name = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel_GUIDLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox_GUID = New System.Windows.Forms.ToolStripTextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Forward = New System.Windows.Forms.TabPage()
        Me.TabPage_Backward = New System.Windows.Forms.TabPage()
        Me.TabPage_ObjectReferences = New System.Windows.Forms.TabPage()
        Me.ToolStripButton_DelClass = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_Database, Me.ToolStripStatusLabel_DatabaseLBL})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 392)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(771, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel_Database
        '
        Me.ToolStripStatusLabel_Database.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel_Database.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel_Database.Name = "ToolStripStatusLabel_Database"
        Me.ToolStripStatusLabel_Database.Size = New System.Drawing.Size(15, 17)
        Me.ToolStripStatusLabel_Database.Text = "-"
        '
        'ToolStripStatusLabel_DatabaseLBL
        '
        Me.ToolStripStatusLabel_DatabaseLBL.Name = "ToolStripStatusLabel_DatabaseLBL"
        Me.ToolStripStatusLabel_DatabaseLBL.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel_DatabaseLBL.Text = "Database:"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(771, 367)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(771, 392)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_ClassLBL, Me.ToolStripTextBox_Name, Me.ToolStripSeparator1, Me.ToolStripLabel_GUIDLBL, Me.ToolStripTextBox_GUID, Me.ToolStripButton_DelClass})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(670, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_ClassLBL
        '
        Me.ToolStripLabel_ClassLBL.Name = "ToolStripLabel_ClassLBL"
        Me.ToolStripLabel_ClassLBL.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel_ClassLBL.Text = "x_Class:"
        '
        'ToolStripTextBox_Name
        '
        Me.ToolStripTextBox_Name.Name = "ToolStripTextBox_Name"
        Me.ToolStripTextBox_Name.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripLabel_GUIDLBL
        '
        Me.ToolStripLabel_GUIDLBL.Name = "ToolStripLabel_GUIDLBL"
        Me.ToolStripLabel_GUIDLBL.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel_GUIDLBL.Text = "x_GUID:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox_GUID
        '
        Me.ToolStripTextBox_GUID.Name = "ToolStripTextBox_GUID"
        Me.ToolStripTextBox_GUID.ReadOnly = True
        Me.ToolStripTextBox_GUID.Size = New System.Drawing.Size(250, 25)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(771, 367)
        Me.SplitContainer1.SplitterDistance = 384
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Forward)
        Me.TabControl1.Controls.Add(Me.TabPage_Backward)
        Me.TabControl1.Controls.Add(Me.TabPage_ObjectReferences)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(379, 363)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Forward
        '
        Me.TabPage_Forward.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Forward.Name = "TabPage_Forward"
        Me.TabPage_Forward.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Forward.Size = New System.Drawing.Size(371, 337)
        Me.TabPage_Forward.TabIndex = 0
        Me.TabPage_Forward.Text = "x_Forward-Relations"
        Me.TabPage_Forward.UseVisualStyleBackColor = True
        '
        'TabPage_Backward
        '
        Me.TabPage_Backward.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Backward.Name = "TabPage_Backward"
        Me.TabPage_Backward.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Backward.Size = New System.Drawing.Size(371, 337)
        Me.TabPage_Backward.TabIndex = 1
        Me.TabPage_Backward.Text = "x_Backward-Relations"
        Me.TabPage_Backward.UseVisualStyleBackColor = True
        '
        'TabPage_ObjectReferences
        '
        Me.TabPage_ObjectReferences.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ObjectReferences.Name = "TabPage_ObjectReferences"
        Me.TabPage_ObjectReferences.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ObjectReferences.Size = New System.Drawing.Size(371, 337)
        Me.TabPage_ObjectReferences.TabIndex = 2
        Me.TabPage_ObjectReferences.Text = "x_Object-References"
        Me.TabPage_ObjectReferences.UseVisualStyleBackColor = True
        '
        'ToolStripButton_DelClass
        '
        Me.ToolStripButton_DelClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_DelClass.Image = Global.Ontolog_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_DelClass.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DelClass.Name = "ToolStripButton_DelClass"
        Me.ToolStripButton_DelClass.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_DelClass.Text = "ToolStripButton1"
        '
        'frmClassEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 414)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmClassEdit"
        Me.Text = "frmClassEdit"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel_Database As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_DatabaseLBL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_ClassLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Name As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_GUIDLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_GUID As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Forward As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Backward As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_ObjectReferences As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripButton_DelClass As System.Windows.Forms.ToolStripButton
End Class
