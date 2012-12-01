<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_GUIEntries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_GUIEntries))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel_CountGUIEntries_lbl = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel_GUIEntriesCount = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel_GUICaptionsToDef_Lbl = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox_GUICaption_Count = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripButton_Jump_to_next_ToDo_GUICaption = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel_ToolTips_Lbl = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox_ToolTip_Count = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripButton_Jump_to_next_ToDo_ToolStrip = New System.Windows.Forms.ToolStripButton
        Me.TreeView_GUIEntries = New System.Windows.Forms.TreeView
        Me.ContextMenuStrip_GUIEntries = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewGUIEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList_GUIEntries = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel_Mark = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox_Mark = New System.Windows.Forms.ToolStripTextBox
        Me.TextBox_LocalizedDescription = New System.Windows.Forms.TextBox
        Me.Timer_Description = New System.Windows.Forms.Timer(Me.components)
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ContextMenuStrip_GUIEntries.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStripContainer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_LocalizedDescription)
        Me.SplitContainer1.Size = New System.Drawing.Size(728, 374)
        Me.SplitContainer1.SplitterDistance = 480
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TreeView_GUIEntries)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(476, 320)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(476, 370)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountGUIEntries_lbl, Me.ToolStripLabel_GUIEntriesCount, Me.ToolStripSeparator2, Me.ToolStripLabel_GUICaptionsToDef_Lbl, Me.ToolStripTextBox_GUICaption_Count, Me.ToolStripButton_Jump_to_next_ToDo_GUICaption, Me.ToolStripSeparator3, Me.ToolStripLabel_ToolTips_Lbl, Me.ToolStripTextBox_ToolTip_Count, Me.ToolStripButton_Jump_to_next_ToDo_ToolStrip})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(427, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_CountGUIEntries_lbl
        '
        Me.ToolStripLabel_CountGUIEntries_lbl.Name = "ToolStripLabel_CountGUIEntries_lbl"
        Me.ToolStripLabel_CountGUIEntries_lbl.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripLabel_CountGUIEntries_lbl.Text = "x_GUI-Entries (Count):"
        '
        'ToolStripLabel_GUIEntriesCount
        '
        Me.ToolStripLabel_GUIEntriesCount.Name = "ToolStripLabel_GUIEntriesCount"
        Me.ToolStripLabel_GUIEntriesCount.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_GUIEntriesCount.Text = "0"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_GUICaptionsToDef_Lbl
        '
        Me.ToolStripLabel_GUICaptionsToDef_Lbl.Name = "ToolStripLabel_GUICaptionsToDef_Lbl"
        Me.ToolStripLabel_GUICaptionsToDef_Lbl.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripLabel_GUICaptionsToDef_Lbl.Text = "x_GUI-Captions:"
        '
        'ToolStripTextBox_GUICaption_Count
        '
        Me.ToolStripTextBox_GUICaption_Count.Name = "ToolStripTextBox_GUICaption_Count"
        Me.ToolStripTextBox_GUICaption_Count.ReadOnly = True
        Me.ToolStripTextBox_GUICaption_Count.Size = New System.Drawing.Size(30, 25)
        '
        'ToolStripButton_Jump_to_next_ToDo_GUICaption
        '
        Me.ToolStripButton_Jump_to_next_ToDo_GUICaption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Jump_to_next_ToDo_GUICaption.Image = Global.Development_Manager.My.Resources.Resources.tasto_3_architetto_franc_01
        Me.ToolStripButton_Jump_to_next_ToDo_GUICaption.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Jump_to_next_ToDo_GUICaption.Name = "ToolStripButton_Jump_to_next_ToDo_GUICaption"
        Me.ToolStripButton_Jump_to_next_ToDo_GUICaption.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Jump_to_next_ToDo_GUICaption.Text = "ToolStripButton1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_ToolTips_Lbl
        '
        Me.ToolStripLabel_ToolTips_Lbl.Name = "ToolStripLabel_ToolTips_Lbl"
        Me.ToolStripLabel_ToolTips_Lbl.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel_ToolTips_Lbl.Text = "x_ToolTips:"
        '
        'ToolStripTextBox_ToolTip_Count
        '
        Me.ToolStripTextBox_ToolTip_Count.Name = "ToolStripTextBox_ToolTip_Count"
        Me.ToolStripTextBox_ToolTip_Count.ReadOnly = True
        Me.ToolStripTextBox_ToolTip_Count.Size = New System.Drawing.Size(30, 25)
        '
        'ToolStripButton_Jump_to_next_ToDo_ToolStrip
        '
        Me.ToolStripButton_Jump_to_next_ToDo_ToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Jump_to_next_ToDo_ToolStrip.Image = Global.Development_Manager.My.Resources.Resources.tasto_3_architetto_franc_01
        Me.ToolStripButton_Jump_to_next_ToDo_ToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Jump_to_next_ToDo_ToolStrip.Name = "ToolStripButton_Jump_to_next_ToDo_ToolStrip"
        Me.ToolStripButton_Jump_to_next_ToDo_ToolStrip.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Jump_to_next_ToDo_ToolStrip.Text = "ToolStripButton1"
        '
        'TreeView_GUIEntries
        '
        Me.TreeView_GUIEntries.ContextMenuStrip = Me.ContextMenuStrip_GUIEntries
        Me.TreeView_GUIEntries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_GUIEntries.ImageIndex = 0
        Me.TreeView_GUIEntries.ImageList = Me.ImageList_GUIEntries
        Me.TreeView_GUIEntries.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_GUIEntries.Name = "TreeView_GUIEntries"
        Me.TreeView_GUIEntries.SelectedImageIndex = 0
        Me.TreeView_GUIEntries.Size = New System.Drawing.Size(476, 320)
        Me.TreeView_GUIEntries.TabIndex = 0
        '
        'ContextMenuStrip_GUIEntries
        '
        Me.ContextMenuStrip_GUIEntries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGUIEntryToolStripMenuItem, Me.CopyNameToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_GUIEntries.Name = "ContextMenuStrip_GUIEntries"
        Me.ContextMenuStrip_GUIEntries.Size = New System.Drawing.Size(163, 92)
        '
        'NewGUIEntryToolStripMenuItem
        '
        Me.NewGUIEntryToolStripMenuItem.Name = "NewGUIEntryToolStripMenuItem"
        Me.NewGUIEntryToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.NewGUIEntryToolStripMenuItem.Text = "x_New GUI-Entry"
        '
        'CopyNameToolStripMenuItem
        '
        Me.CopyNameToolStripMenuItem.Name = "CopyNameToolStripMenuItem"
        Me.CopyNameToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CopyNameToolStripMenuItem.Text = "x_Copy Name"
        '
        'ImageList_GUIEntries
        '
        Me.ImageList_GUIEntries.ImageStream = CType(resources.GetObject("ImageList_GUIEntries.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_GUIEntries.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_GUIEntries.Images.SetKeyName(0, "finestra_architetto_fran_01.png")
        Me.ImageList_GUIEntries.Images.SetKeyName(1, "finestre_sovrapposte_arc_01.png")
        Me.ImageList_GUIEntries.Images.SetKeyName(2, "Localized Names Done.png")
        Me.ImageList_GUIEntries.Images.SetKeyName(3, "Localized Names ToDo.png")
        Me.ImageList_GUIEntries.Images.SetKeyName(4, "finestre_sovrapposte_arc_01.png")
        Me.ImageList_GUIEntries.Images.SetKeyName(5, "bb_home_.png")
        Me.ImageList_GUIEntries.Images.SetKeyName(6, "information_icon_stuart__01.png")
        Me.ImageList_GUIEntries.Images.SetKeyName(7, "finestre_vt_architetto_f_01.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Mark, Me.ToolStripTextBox_Mark})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(261, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_Mark
        '
        Me.ToolStripLabel_Mark.Name = "ToolStripLabel_Mark"
        Me.ToolStripLabel_Mark.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel_Mark.Text = "x_Mark:"
        '
        'ToolStripTextBox_Mark
        '
        Me.ToolStripTextBox_Mark.Name = "ToolStripTextBox_Mark"
        Me.ToolStripTextBox_Mark.Size = New System.Drawing.Size(200, 25)
        '
        'TextBox_LocalizedDescription
        '
        Me.TextBox_LocalizedDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_LocalizedDescription.Location = New System.Drawing.Point(0, 0)
        Me.TextBox_LocalizedDescription.Multiline = True
        Me.TextBox_LocalizedDescription.Name = "TextBox_LocalizedDescription"
        Me.TextBox_LocalizedDescription.ReadOnly = True
        Me.TextBox_LocalizedDescription.Size = New System.Drawing.Size(240, 370)
        Me.TextBox_LocalizedDescription.TabIndex = 0
        '
        'Timer_Description
        '
        Me.Timer_Description.Interval = 300
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        Me.ApplyToolStripMenuItem.Visible = False
        '
        'UserControl_GUIEntries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_GUIEntries"
        Me.Size = New System.Drawing.Size(728, 374)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ContextMenuStrip_GUIEntries.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountGUIEntries_lbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_GUIEntriesCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Mark As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Mark As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TextBox_LocalizedDescription As System.Windows.Forms.TextBox
    Friend WithEvents TreeView_GUIEntries As System.Windows.Forms.TreeView
    Friend WithEvents ImageList_GUIEntries As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip_GUIEntries As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewGUIEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_Description As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_GUICaptionsToDef_Lbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_GUICaption_Count As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel_ToolTips_Lbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_ToolTip_Count As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton_Jump_to_next_ToDo_GUICaption As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Jump_to_next_ToDo_ToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
