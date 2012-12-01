<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Localized
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Localized))
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.TreeView_Description = New System.Windows.Forms.TreeView
        Me.ImageList_LanguageTree = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox_Description = New System.Windows.Forms.TextBox
        Me.Timer_Description = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Name = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip_localizedNames = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddLocalizedNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ContextMenuStrip_localizedNames.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TreeView_Description)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TextBox_Description)
        Me.SplitContainer2.Size = New System.Drawing.Size(412, 340)
        Me.SplitContainer2.SplitterDistance = 137
        Me.SplitContainer2.TabIndex = 1
        '
        'TreeView_Description
        '
        Me.TreeView_Description.ContextMenuStrip = Me.ContextMenuStrip_localizedNames
        Me.TreeView_Description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Description.ImageIndex = 0
        Me.TreeView_Description.ImageList = Me.ImageList_LanguageTree
        Me.TreeView_Description.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_Description.Name = "TreeView_Description"
        Me.TreeView_Description.SelectedImageIndex = 0
        Me.TreeView_Description.Size = New System.Drawing.Size(133, 336)
        Me.TreeView_Description.TabIndex = 0
        '
        'ImageList_LanguageTree
        '
        Me.ImageList_LanguageTree.ImageStream = CType(resources.GetObject("ImageList_LanguageTree.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_LanguageTree.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_LanguageTree.Images.SetKeyName(0, "Language Standard.png")
        Me.ImageList_LanguageTree.Images.SetKeyName(1, "Language.png")
        Me.ImageList_LanguageTree.Images.SetKeyName(2, "Language Standard ToDo.png")
        Me.ImageList_LanguageTree.Images.SetKeyName(3, "Language Standard Done.png")
        Me.ImageList_LanguageTree.Images.SetKeyName(4, "Language ToDo.png")
        Me.ImageList_LanguageTree.Images.SetKeyName(5, "Language Done.png")
        Me.ImageList_LanguageTree.Images.SetKeyName(6, "Localized Names.png")
        Me.ImageList_LanguageTree.Images.SetKeyName(7, "Localized Names ToDo.png")
        Me.ImageList_LanguageTree.Images.SetKeyName(8, "Localized Names Done.png")
        Me.ImageList_LanguageTree.Images.SetKeyName(9, "Localized Names.png")
        '
        'TextBox_Description
        '
        Me.TextBox_Description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Description.Location = New System.Drawing.Point(0, 0)
        Me.TextBox_Description.Multiline = True
        Me.TextBox_Description.Name = "TextBox_Description"
        Me.TextBox_Description.ReadOnly = True
        Me.TextBox_Description.Size = New System.Drawing.Size(267, 336)
        Me.TextBox_Description.TabIndex = 0
        '
        'Timer_Description
        '
        Me.Timer_Description.Interval = 300
        '
        'Timer_Name
        '
        '
        'ContextMenuStrip_localizedNames
        '
        Me.ContextMenuStrip_localizedNames.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddLocalizedNameToolStripMenuItem})
        Me.ContextMenuStrip_localizedNames.Name = "ContextMenuStrip_localizedNames"
        Me.ContextMenuStrip_localizedNames.Size = New System.Drawing.Size(189, 48)
        '
        'AddLocalizedNameToolStripMenuItem
        '
        Me.AddLocalizedNameToolStripMenuItem.Name = "AddLocalizedNameToolStripMenuItem"
        Me.AddLocalizedNameToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AddLocalizedNameToolStripMenuItem.Text = "x_add localized Name"
        '
        'UserControl_Localized
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "UserControl_Localized"
        Me.Size = New System.Drawing.Size(412, 340)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ContextMenuStrip_localizedNames.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView_Description As System.Windows.Forms.TreeView
    Friend WithEvents TextBox_Description As System.Windows.Forms.TextBox
    Friend WithEvents ImageList_LanguageTree As System.Windows.Forms.ImageList
    Friend WithEvents Timer_Description As System.Windows.Forms.Timer
    Friend WithEvents Timer_Name As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip_localizedNames As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddLocalizedNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
