<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMediaModule_Grid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMediaModule_Grid))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton_Mark = New System.Windows.Forms.ToolStripSplitButton()
        Me.MarkPersonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkNoPersonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkBuildingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkNoBuildingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_FilterItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_ToNext_Colored = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_ToNext_NoColor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_ExportMarked = New System.Windows.Forms.ToolStripButton()
        Me.ClearMarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(465, 331)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(465, 381)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Close})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(62, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Close
        '
        Me.ToolStripButton_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Close.Image = CType(resources.GetObject("ToolStripButton_Close.Image"), System.Drawing.Image)
        Me.ToolStripButton_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
        Me.ToolStripButton_Close.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton_Close.Text = "x_Close"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(465, 331)
        Me.SplitContainer1.SplitterDistance = 155
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton_Mark, Me.ToolStripSeparator1, Me.ToolStripButton_FilterItem, Me.ToolStripButton_ToNext_Colored, Me.ToolStripButton_ToNext_NoColor, Me.ToolStripSeparator2, Me.ToolStripButton_ExportMarked})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(332, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripSplitButton_Mark
        '
        Me.ToolStripSplitButton_Mark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton_Mark.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkPersonsToolStripMenuItem, Me.MarkNoPersonsToolStripMenuItem, Me.MarkBuildingsToolStripMenuItem, Me.MarkNoBuildingsToolStripMenuItem, Me.ClearMarkToolStripMenuItem})
        Me.ToolStripSplitButton_Mark.Image = CType(resources.GetObject("ToolStripSplitButton_Mark.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton_Mark.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton_Mark.Name = "ToolStripSplitButton_Mark"
        Me.ToolStripSplitButton_Mark.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripSplitButton_Mark.Text = "x_Mark"
        '
        'MarkPersonsToolStripMenuItem
        '
        Me.MarkPersonsToolStripMenuItem.Name = "MarkPersonsToolStripMenuItem"
        Me.MarkPersonsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MarkPersonsToolStripMenuItem.Text = "x_mark Persons"
        '
        'MarkNoPersonsToolStripMenuItem
        '
        Me.MarkNoPersonsToolStripMenuItem.Name = "MarkNoPersonsToolStripMenuItem"
        Me.MarkNoPersonsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MarkNoPersonsToolStripMenuItem.Text = "x_mark no Persons"
        '
        'MarkBuildingsToolStripMenuItem
        '
        Me.MarkBuildingsToolStripMenuItem.Name = "MarkBuildingsToolStripMenuItem"
        Me.MarkBuildingsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MarkBuildingsToolStripMenuItem.Text = "x_mark Buildings"
        '
        'MarkNoBuildingsToolStripMenuItem
        '
        Me.MarkNoBuildingsToolStripMenuItem.Name = "MarkNoBuildingsToolStripMenuItem"
        Me.MarkNoBuildingsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MarkNoBuildingsToolStripMenuItem.Text = "x_mark no Buildings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_FilterItem
        '
        Me.ToolStripButton_FilterItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_FilterItem.Image = CType(resources.GetObject("ToolStripButton_FilterItem.Image"), System.Drawing.Image)
        Me.ToolStripButton_FilterItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_FilterItem.Name = "ToolStripButton_FilterItem"
        Me.ToolStripButton_FilterItem.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripButton_FilterItem.Text = "x_Filter Item"
        '
        'ToolStripButton_ToNext_Colored
        '
        Me.ToolStripButton_ToNext_Colored.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_ToNext_Colored.Image = Global.MediaViewer_Module.My.Resources.Resources.pulsante_02_architetto_f_01
        Me.ToolStripButton_ToNext_Colored.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ToNext_Colored.Name = "ToolStripButton_ToNext_Colored"
        Me.ToolStripButton_ToNext_Colored.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_ToNext_Colored.Text = "ToolStripButton1"
        '
        'ToolStripButton_ToNext_NoColor
        '
        Me.ToolStripButton_ToNext_NoColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_ToNext_NoColor.Image = Global.MediaViewer_Module.My.Resources.Resources.pulsante_02_architetto_f_01_gray
        Me.ToolStripButton_ToNext_NoColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ToNext_NoColor.Name = "ToolStripButton_ToNext_NoColor"
        Me.ToolStripButton_ToNext_NoColor.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_ToNext_NoColor.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_ExportMarked
        '
        Me.ToolStripButton_ExportMarked.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_ExportMarked.Image = CType(resources.GetObject("ToolStripButton_ExportMarked.Image"), System.Drawing.Image)
        Me.ToolStripButton_ExportMarked.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ExportMarked.Name = "ToolStripButton_ExportMarked"
        Me.ToolStripButton_ExportMarked.Size = New System.Drawing.Size(97, 22)
        Me.ToolStripButton_ExportMarked.Text = "x_Export Marked"
        '
        'ClearMarkToolStripMenuItem
        '
        Me.ClearMarkToolStripMenuItem.Name = "ClearMarkToolStripMenuItem"
        Me.ClearMarkToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearMarkToolStripMenuItem.Text = "Clear Mark"
        '
        'frmMediaModule_Grid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 381)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmMediaModule_Grid"
        Me.Text = "frmMediaModule_Grid"
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

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_FilterItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_ToNext_Colored As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_ToNext_NoColor As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_ExportMarked As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton_Mark As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents MarkPersonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkNoPersonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkBuildingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkNoBuildingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearMarkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
