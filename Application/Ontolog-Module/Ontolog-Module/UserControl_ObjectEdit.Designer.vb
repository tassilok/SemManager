<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_ObjectEdit
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_Database = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Nav_First = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Nav_Previous = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Nav_Next = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Nav_Last = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_ObjectCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_ObjectLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_GUIDLbl = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_GUID = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_Name = New System.Windows.Forms.ToolStripTextBox()
        Me.Timer_Name_Change = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(558, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FileToolStripMenuItem.Text = "x_File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditToolStripMenuItem.Text = "x_Edit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_Database})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 405)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(558, 24)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel_Database
        '
        Me.ToolStripStatusLabel_Database.BackColor = System.Drawing.SystemColors.Info
        Me.ToolStripStatusLabel_Database.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel_Database.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ToolStripStatusLabel_Database.Name = "ToolStripStatusLabel_Database"
        Me.ToolStripStatusLabel_Database.Size = New System.Drawing.Size(16, 19)
        Me.ToolStripStatusLabel_Database.Text = "-"
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(558, 331)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(558, 381)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Nav_First, Me.ToolStripButton_Nav_Previous, Me.ToolStripButton_Nav_Next, Me.ToolStripButton_Nav_Last, Me.ToolStripSeparator1, Me.ToolStripLabel_ObjectCount, Me.ToolStripLabel_ObjectLabel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(191, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Nav_First
        '
        Me.ToolStripButton_Nav_First.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Nav_First.Image = Global.Ontolog_Module.My.Resources.Resources.pulsante_01_architetto_f_01_First
        Me.ToolStripButton_Nav_First.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Nav_First.Name = "ToolStripButton_Nav_First"
        Me.ToolStripButton_Nav_First.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Nav_First.Text = "ToolStripButton1"
        '
        'ToolStripButton_Nav_Previous
        '
        Me.ToolStripButton_Nav_Previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Nav_Previous.Image = Global.Ontolog_Module.My.Resources.Resources.pulsante_01_architetto_f_01
        Me.ToolStripButton_Nav_Previous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Nav_Previous.Name = "ToolStripButton_Nav_Previous"
        Me.ToolStripButton_Nav_Previous.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Nav_Previous.Text = "ToolStripButton2"
        '
        'ToolStripButton_Nav_Next
        '
        Me.ToolStripButton_Nav_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Nav_Next.Image = Global.Ontolog_Module.My.Resources.Resources.pulsante_02_architetto_f_01
        Me.ToolStripButton_Nav_Next.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Nav_Next.Name = "ToolStripButton_Nav_Next"
        Me.ToolStripButton_Nav_Next.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Nav_Next.Text = "ToolStripButton3"
        '
        'ToolStripButton_Nav_Last
        '
        Me.ToolStripButton_Nav_Last.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Nav_Last.Image = Global.Ontolog_Module.My.Resources.Resources.pulsante_02_architetto_f_01_Last
        Me.ToolStripButton_Nav_Last.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Nav_Last.Name = "ToolStripButton_Nav_Last"
        Me.ToolStripButton_Nav_Last.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Nav_Last.Text = "ToolStripButton4"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_ObjectCount
        '
        Me.ToolStripLabel_ObjectCount.Name = "ToolStripLabel_ObjectCount"
        Me.ToolStripLabel_ObjectCount.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripLabel_ObjectCount.Text = "0/0"
        '
        'ToolStripLabel_ObjectLabel
        '
        Me.ToolStripLabel_ObjectLabel.Name = "ToolStripLabel_ObjectLabel"
        Me.ToolStripLabel_ObjectLabel.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripLabel_ObjectLabel.Text = "x_Objects"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(558, 331)
        Me.SplitContainer1.SplitterDistance = 186
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_GUIDLbl, Me.ToolStripTextBox_GUID, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.ToolStripTextBox_Name})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(518, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_GUIDLbl
        '
        Me.ToolStripLabel_GUIDLbl.Name = "ToolStripLabel_GUIDLbl"
        Me.ToolStripLabel_GUIDLbl.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel_GUIDLbl.Text = "x_GUID:"
        '
        'ToolStripTextBox_GUID
        '
        Me.ToolStripTextBox_GUID.Name = "ToolStripTextBox_GUID"
        Me.ToolStripTextBox_GUID.ReadOnly = True
        Me.ToolStripTextBox_GUID.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel1.Text = "x_Name"
        '
        'ToolStripTextBox_Name
        '
        Me.ToolStripTextBox_Name.Name = "ToolStripTextBox_Name"
        Me.ToolStripTextBox_Name.Size = New System.Drawing.Size(200, 25)
        '
        'Timer_Name_Change
        '
        Me.Timer_Name_Change.Interval = 300
        '
        'UserControl_ObjectEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "UserControl_ObjectEdit"
        Me.Size = New System.Drawing.Size(558, 429)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel_Database As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Nav_First As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Nav_Previous As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Nav_Next As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Nav_Last As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_ObjectCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_ObjectLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_GUIDLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_GUID As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Name As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Timer_Name_Change As System.Windows.Forms.Timer

End Class
