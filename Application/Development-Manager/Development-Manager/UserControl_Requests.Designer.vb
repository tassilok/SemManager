<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Requests
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Requests))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TextBox_RequestMessage = New System.Windows.Forms.TextBox
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.TreeView_Requests = New System.Windows.Forms.TreeView
        Me.ContextMenuStrip_Requests = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ObsoleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReopenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList_Requests = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel_Mark = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox_Mark = New System.Windows.Forms.ToolStripTextBox
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ContextMenuStrip_Requests.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_RequestMessage)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripContainer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(763, 475)
        Me.SplitContainer1.SplitterDistance = 147
        Me.SplitContainer1.TabIndex = 0
        '
        'TextBox_RequestMessage
        '
        Me.TextBox_RequestMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_RequestMessage.Location = New System.Drawing.Point(0, 0)
        Me.TextBox_RequestMessage.Multiline = True
        Me.TextBox_RequestMessage.Name = "TextBox_RequestMessage"
        Me.TextBox_RequestMessage.Size = New System.Drawing.Size(759, 143)
        Me.TextBox_RequestMessage.TabIndex = 0
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TreeView_Requests)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(759, 295)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(759, 320)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'TreeView_Requests
        '
        Me.TreeView_Requests.ContextMenuStrip = Me.ContextMenuStrip_Requests
        Me.TreeView_Requests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Requests.ImageIndex = 0
        Me.TreeView_Requests.ImageList = Me.ImageList_Requests
        Me.TreeView_Requests.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_Requests.Name = "TreeView_Requests"
        Me.TreeView_Requests.SelectedImageIndex = 0
        Me.TreeView_Requests.Size = New System.Drawing.Size(759, 295)
        Me.TreeView_Requests.TabIndex = 0
        '
        'ContextMenuStrip_Requests
        '
        Me.ContextMenuStrip_Requests.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRequestToolStripMenuItem, Me.LogToolStripMenuItem})
        Me.ContextMenuStrip_Requests.Name = "ContextMenuStrip_Requests"
        Me.ContextMenuStrip_Requests.Size = New System.Drawing.Size(153, 48)
        '
        'NewRequestToolStripMenuItem
        '
        Me.NewRequestToolStripMenuItem.Name = "NewRequestToolStripMenuItem"
        Me.NewRequestToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewRequestToolStripMenuItem.Text = "New Request_f"
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeToolStripMenuItem, Me.InfoToolStripMenuItem, Me.ObsoleteToolStripMenuItem, Me.ReopenToolStripMenuItem})
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        Me.LogToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogToolStripMenuItem.Text = "Log"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ChangeToolStripMenuItem.Text = "Change"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'ObsoleteToolStripMenuItem
        '
        Me.ObsoleteToolStripMenuItem.Name = "ObsoleteToolStripMenuItem"
        Me.ObsoleteToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ObsoleteToolStripMenuItem.Text = "Obsolete"
        '
        'ReopenToolStripMenuItem
        '
        Me.ReopenToolStripMenuItem.Name = "ReopenToolStripMenuItem"
        Me.ReopenToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ReopenToolStripMenuItem.Text = "Reopen"
        '
        'ImageList_Requests
        '
        Me.ImageList_Requests.ImageStream = CType(resources.GetObject("ImageList_Requests.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Requests.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Requests.Images.SetKeyName(0, "bb_txt_.png")
        Me.ImageList_Requests.Images.SetKeyName(1, "bb_txt_erl.png")
        Me.ImageList_Requests.Images.SetKeyName(2, "bb_txt_obsolete.png")
        Me.ImageList_Requests.Images.SetKeyName(3, "tasto_7_architetto_franc_01.png")
        Me.ImageList_Requests.Images.SetKeyName(4, "button-yellow_benji_park_01_Ausrufezeichen.png")
        Me.ImageList_Requests.Images.SetKeyName(5, "button-yellow_benji_park_01 Obsolete.png")
        Me.ImageList_Requests.Images.SetKeyName(6, "government_icon_-_symbo_01.png")
        Me.ImageList_Requests.Images.SetKeyName(7, "bb_home_.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Mark, Me.ToolStripTextBox_Mark})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(341, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_Mark
        '
        Me.ToolStripLabel_Mark.Name = "ToolStripLabel_Mark"
        Me.ToolStripLabel_Mark.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel_Mark.Text = "Mark_f:"
        '
        'ToolStripTextBox_Mark
        '
        Me.ToolStripTextBox_Mark.Name = "ToolStripTextBox_Mark"
        Me.ToolStripTextBox_Mark.Size = New System.Drawing.Size(250, 25)
        '
        'UserControl_Requests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_Requests"
        Me.Size = New System.Drawing.Size(763, 475)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ContextMenuStrip_Requests.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBox_RequestMessage As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TreeView_Requests As System.Windows.Forms.TreeView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Mark As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Mark As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ImageList_Requests As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip_Requests As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObsoleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReopenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
