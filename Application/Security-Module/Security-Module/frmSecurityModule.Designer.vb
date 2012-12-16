<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecurityModule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                Clipboard.Clear()
                components.Dispose()

            End If
        Finally
            Clipboard.Clear()
            MyBase.Dispose(disposing)

        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSecurityModule))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Apply = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView_RelatedItems = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_Passwords = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_Passwords = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.DataGridView_Passwords = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripComboBox_Search = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripTextBox_Search = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_GetSemItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Filter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton_Test = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem_Authentication = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_NoRelate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_User = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Group = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_UserAndGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_UserToGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_GroupToUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_Search = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource_Passwords = New System.Windows.Forms.BindingSource(Me.components)
        Me.CopyPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_Remove = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip_Passwords.SuspendLayout()
        Me.ToolStripContainer2.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        CType(Me.DataGridView_Passwords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        CType(Me.BindingSource_Passwords, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(662, 277)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(662, 327)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip4)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Apply, Me.ToolStripButton_Close})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(59, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Apply
        '
        Me.ToolStripButton_Apply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Apply.Enabled = False
        Me.ToolStripButton_Apply.Image = CType(resources.GetObject("ToolStripButton_Apply.Image"), System.Drawing.Image)
        Me.ToolStripButton_Apply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Apply.Name = "ToolStripButton_Apply"
        Me.ToolStripButton_Apply.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton_Apply.Text = "x_Apply"
        Me.ToolStripButton_Apply.Visible = False
        '
        'ToolStripButton_Close
        '
        Me.ToolStripButton_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Close.Image = CType(resources.GetObject("ToolStripButton_Close.Image"), System.Drawing.Image)
        Me.ToolStripButton_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
        Me.ToolStripButton_Close.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton_Close.Text = "x_Close"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView_RelatedItems)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(662, 277)
        Me.SplitContainer1.SplitterDistance = 219
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView_RelatedItems
        '
        Me.TreeView_RelatedItems.ContextMenuStrip = Me.ContextMenuStrip_Passwords
        Me.TreeView_RelatedItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_RelatedItems.ImageIndex = 0
        Me.TreeView_RelatedItems.ImageList = Me.ImageList_Passwords
        Me.TreeView_RelatedItems.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_RelatedItems.Name = "TreeView_RelatedItems"
        Me.TreeView_RelatedItems.SelectedImageIndex = 0
        Me.TreeView_RelatedItems.Size = New System.Drawing.Size(215, 273)
        Me.TreeView_RelatedItems.TabIndex = 0
        '
        'ContextMenuStrip_Passwords
        '
        Me.ContextMenuStrip_Passwords.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ChangeToolStripMenuItem, Me.CopyPasswordToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_Passwords.Name = "ContextMenuStrip_Passwords"
        Me.ContextMenuStrip_Passwords.Size = New System.Drawing.Size(161, 92)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Enabled = False
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Enabled = False
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ChangeToolStripMenuItem.Text = "x_Change"
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Enabled = False
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ApplyToolStripMenuItem.Text = "Apply"
        Me.ApplyToolStripMenuItem.Visible = False
        '
        'ImageList_Passwords
        '
        Me.ImageList_Passwords.ImageStream = CType(resources.GetObject("ImageList_Passwords.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Passwords.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Passwords.Images.SetKeyName(0, "bb_home_.png")
        Me.ImageList_Passwords.Images.SetKeyName(1, "Types_Closed.png")
        Me.ImageList_Passwords.Images.SetKeyName(2, "Types_Opened.png")
        Me.ImageList_Passwords.Images.SetKeyName(3, "Attributes bamboo_danny_allen_r.png")
        Me.ImageList_Passwords.Images.SetKeyName(4, "Types_Closed.png")
        Me.ImageList_Passwords.Images.SetKeyName(5, "Types_Opened.png")
        Me.ImageList_Passwords.Images.SetKeyName(6, "Vogelschwarm klein.png")
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.BottomToolStripPanel
        '
        Me.ToolStripContainer2.BottomToolStripPanel.Controls.Add(Me.ToolStrip3)
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.DataGridView_Passwords)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(435, 223)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(435, 273)
        Me.ToolStripContainer2.TabIndex = 1
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(109, 25)
        Me.ToolStrip3.TabIndex = 0
        '
        'DataGridView_Passwords
        '
        Me.DataGridView_Passwords.AllowUserToAddRows = False
        Me.DataGridView_Passwords.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Passwords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_Passwords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Passwords.ContextMenuStrip = Me.ContextMenuStrip_Passwords
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Passwords.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView_Passwords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Passwords.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Passwords.Name = "DataGridView_Passwords"
        Me.DataGridView_Passwords.ReadOnly = True
        Me.DataGridView_Passwords.Size = New System.Drawing.Size(435, 223)
        Me.DataGridView_Passwords.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_Search, Me.ToolStripTextBox_Search, Me.ToolStripButton_GetSemItem, Me.ToolStripButton_Filter})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(405, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripComboBox_Search
        '
        Me.ToolStripComboBox_Search.Name = "ToolStripComboBox_Search"
        Me.ToolStripComboBox_Search.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripTextBox_Search
        '
        Me.ToolStripTextBox_Search.Name = "ToolStripTextBox_Search"
        Me.ToolStripTextBox_Search.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripButton_GetSemItem
        '
        Me.ToolStripButton_GetSemItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_GetSemItem.Enabled = False
        Me.ToolStripButton_GetSemItem.Image = CType(resources.GetObject("ToolStripButton_GetSemItem.Image"), System.Drawing.Image)
        Me.ToolStripButton_GetSemItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_GetSemItem.Name = "ToolStripButton_GetSemItem"
        Me.ToolStripButton_GetSemItem.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_GetSemItem.Text = "..."
        '
        'ToolStripButton_Filter
        '
        Me.ToolStripButton_Filter.Checked = True
        Me.ToolStripButton_Filter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton_Filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Filter.Image = CType(resources.GetObject("ToolStripButton_Filter.Image"), System.Drawing.Image)
        Me.ToolStripButton_Filter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Filter.Name = "ToolStripButton_Filter"
        Me.ToolStripButton_Filter.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripButton_Filter.Text = "x_Filter"
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton_Test})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(63, 25)
        Me.ToolStrip4.TabIndex = 0
        '
        'ToolStripDropDownButton_Test
        '
        Me.ToolStripDropDownButton_Test.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton_Test.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Authentication})
        Me.ToolStripDropDownButton_Test.Image = CType(resources.GetObject("ToolStripDropDownButton_Test.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton_Test.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton_Test.Name = "ToolStripDropDownButton_Test"
        Me.ToolStripDropDownButton_Test.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripDropDownButton_Test.Text = "x_Test"
        '
        'ToolStripMenuItem_Authentication
        '
        Me.ToolStripMenuItem_Authentication.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_NoRelate, Me.ToolStripMenuItem_UserToGroup, Me.ToolStripMenuItem_GroupToUser})
        Me.ToolStripMenuItem_Authentication.Name = "ToolStripMenuItem_Authentication"
        Me.ToolStripMenuItem_Authentication.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuItem_Authentication.Text = "x_Authentication"
        '
        'ToolStripMenuItem_NoRelate
        '
        Me.ToolStripMenuItem_NoRelate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_User, Me.ToolStripMenuItem_Group, Me.ToolStripMenuItem_UserAndGroup})
        Me.ToolStripMenuItem_NoRelate.Name = "ToolStripMenuItem_NoRelate"
        Me.ToolStripMenuItem_NoRelate.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem_NoRelate.Text = "x_NoRelate"
        '
        'ToolStripMenuItem_User
        '
        Me.ToolStripMenuItem_User.Name = "ToolStripMenuItem_User"
        Me.ToolStripMenuItem_User.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuItem_User.Text = "x_User"
        '
        'ToolStripMenuItem_Group
        '
        Me.ToolStripMenuItem_Group.Name = "ToolStripMenuItem_Group"
        Me.ToolStripMenuItem_Group.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuItem_Group.Text = "x_Group"
        '
        'ToolStripMenuItem_UserAndGroup
        '
        Me.ToolStripMenuItem_UserAndGroup.Name = "ToolStripMenuItem_UserAndGroup"
        Me.ToolStripMenuItem_UserAndGroup.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuItem_UserAndGroup.Text = "x_UserAndGroup"
        '
        'ToolStripMenuItem_UserToGroup
        '
        Me.ToolStripMenuItem_UserToGroup.Name = "ToolStripMenuItem_UserToGroup"
        Me.ToolStripMenuItem_UserToGroup.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem_UserToGroup.Text = "x_User_To_Group"
        '
        'ToolStripMenuItem_GroupToUser
        '
        Me.ToolStripMenuItem_GroupToUser.Name = "ToolStripMenuItem_GroupToUser"
        Me.ToolStripMenuItem_GroupToUser.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem_GroupToUser.Text = "x_Group_To_User"
        '
        'Timer_Search
        '
        Me.Timer_Search.Interval = 300
        '
        'CopyPasswordToolStripMenuItem
        '
        Me.CopyPasswordToolStripMenuItem.Enabled = False
        Me.CopyPasswordToolStripMenuItem.Name = "CopyPasswordToolStripMenuItem"
        Me.CopyPasswordToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CopyPasswordToolStripMenuItem.Text = "x_Copy Password"
        '
        'Timer_Remove
        '
        Me.Timer_Remove.Interval = 30000
        '
        'frmSecurityModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 327)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSecurityModule"
        Me.Text = "x_Security-Module"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip_Passwords.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        CType(Me.DataGridView_Passwords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        CType(Me.BindingSource_Passwords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Apply As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView_RelatedItems As System.Windows.Forms.TreeView
    Friend WithEvents ImageList_Passwords As System.Windows.Forms.ImageList
    Friend WithEvents BindingSource_Passwords As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip_Passwords As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents DataGridView_Passwords As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripComboBox_Search As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripTextBox_Search As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton_GetSemItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Filter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ChangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_Search As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton_Test As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem_Authentication As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_NoRelate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_UserToGroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_GroupToUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_User As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Group As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_UserAndGroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_Remove As System.Windows.Forms.Timer

End Class
