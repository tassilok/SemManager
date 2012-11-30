<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_TypeTree
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_TypeTree))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TreeView_Types = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_Tree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuplicateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_Classtree = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_mark = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox_Filter = New System.Windows.Forms.ToolStripTextBox()
        Me.Timer_Mark = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_GUIDLbl = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_GUID = New System.Windows.Forms.ToolStripTextBox()
        Me.ToClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip_Clipboard = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ContextMenuStrip_Tree.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TreeView_Types, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(476, 443)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TreeView_Types
        '
        Me.TreeView_Types.AllowDrop = True
        Me.TreeView_Types.ContextMenuStrip = Me.ContextMenuStrip_Tree
        Me.TreeView_Types.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Types.ImageIndex = 1
        Me.TreeView_Types.ImageList = Me.ImageList_Classtree
        Me.TreeView_Types.Location = New System.Drawing.Point(3, 28)
        Me.TreeView_Types.Name = "TreeView_Types"
        Me.TreeView_Types.SelectedImageIndex = 2
        Me.TreeView_Types.Size = New System.Drawing.Size(470, 387)
        Me.TreeView_Types.TabIndex = 0
        '
        'ContextMenuStrip_Tree
        '
        Me.ContextMenuStrip_Tree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToClipboardToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_Tree.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip_Tree.Size = New System.Drawing.Size(153, 92)
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NeuToolStripMenuItem.Text = "Neu_f"
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ApplyToolStripMenuItem.Text = "Apply_f"
        Me.ApplyToolStripMenuItem.Visible = False
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyNameToolStripMenuItem, Me.DuplicateToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit_f"
        '
        'CopyNameToolStripMenuItem
        '
        Me.CopyNameToolStripMenuItem.Name = "CopyNameToolStripMenuItem"
        Me.CopyNameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyNameToolStripMenuItem.Text = "Copy Name_f"
        '
        'DuplicateToolStripMenuItem
        '
        Me.DuplicateToolStripMenuItem.Name = "DuplicateToolStripMenuItem"
        Me.DuplicateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DuplicateToolStripMenuItem.Text = "x_Duplicate"
        '
        'ImageList_Classtree
        '
        Me.ImageList_Classtree.ImageStream = CType(resources.GetObject("ImageList_Classtree.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Classtree.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Classtree.Images.SetKeyName(0, "bb_home_.png")
        Me.ImageList_Classtree.Images.SetKeyName(1, "gnome-fs-home-Closed_with_Bats.png")
        Me.ImageList_Classtree.Images.SetKeyName(2, "gnome-fs-home_with_bats.png")
        Me.ImageList_Classtree.Images.SetKeyName(3, "puzzle_architetto_france_01.png")
        Me.ImageList_Classtree.Images.SetKeyName(4, "honey.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_mark, Me.ToolStripTextBox_Filter})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(476, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton_mark
        '
        Me.ToolStripButton_mark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_mark.Image = CType(resources.GetObject("ToolStripButton_mark.Image"), System.Drawing.Image)
        Me.ToolStripButton_mark.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_mark.Name = "ToolStripButton_mark"
        Me.ToolStripButton_mark.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripButton_mark.Text = "x_markieren:"
        '
        'ToolStripTextBox_Filter
        '
        Me.ToolStripTextBox_Filter.Name = "ToolStripTextBox_Filter"
        Me.ToolStripTextBox_Filter.Size = New System.Drawing.Size(250, 25)
        '
        'Timer_Mark
        '
        Me.Timer_Mark.Interval = 300
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_GUIDLbl, Me.ToolStripTextBox_GUID})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 418)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(476, 25)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
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
        Me.ToolStripTextBox_GUID.Size = New System.Drawing.Size(250, 25)
        '
        'ToClipboardToolStripMenuItem
        '
        Me.ToClipboardToolStripMenuItem.Name = "ToClipboardToolStripMenuItem"
        Me.ToClipboardToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ToClipboardToolStripMenuItem.Text = "x_to_Clipboard"
        '
        'UserControl_TypeTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UserControl_TypeTree"
        Me.Size = New System.Drawing.Size(476, 443)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ContextMenuStrip_Tree.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TreeView_Types As System.Windows.Forms.TreeView
    Friend WithEvents ImageList_Classtree As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip_Tree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NeuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton_mark As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTextBox_Filter As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Timer_Mark As System.Windows.Forms.Timer
    Friend WithEvents DuplicateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_GUIDLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_GUID As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip_Clipboard As System.Windows.Forms.ToolTip

End Class
