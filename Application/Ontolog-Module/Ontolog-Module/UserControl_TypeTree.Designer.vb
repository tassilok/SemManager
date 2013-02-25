<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_TypeTree
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_TypeTree))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Count = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_ID = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_ID = New System.Windows.Forms.ToolStripTextBox()
        Me.TreeView_Types = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_Classes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_Classtree = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_Mark = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_MarkTypes = New System.Windows.Forms.ToolStripTextBox()
        Me.Timer_Mark = New System.Windows.Forms.Timer(Me.components)
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ContextMenuStrip_Classes.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TreeView_Types)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(582, 440)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(582, 490)
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
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountLBL, Me.ToolStripLabel_Count, Me.ToolStripSeparator1, Me.ToolStripLabel_ID, Me.ToolStripTextBox_ID})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(417, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_CountLBL
        '
        Me.ToolStripLabel_CountLBL.Name = "ToolStripLabel_CountLBL"
        Me.ToolStripLabel_CountLBL.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel_CountLBL.Text = "x_Count:"
        '
        'ToolStripLabel_Count
        '
        Me.ToolStripLabel_Count.Name = "ToolStripLabel_Count"
        Me.ToolStripLabel_Count.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Count.Text = "0"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_ID
        '
        Me.ToolStripLabel_ID.Name = "ToolStripLabel_ID"
        Me.ToolStripLabel_ID.Size = New System.Drawing.Size(34, 22)
        Me.ToolStripLabel_ID.Text = "x_ID:"
        '
        'ToolStripTextBox_ID
        '
        Me.ToolStripTextBox_ID.Name = "ToolStripTextBox_ID"
        Me.ToolStripTextBox_ID.ReadOnly = True
        Me.ToolStripTextBox_ID.Size = New System.Drawing.Size(300, 25)
        '
        'TreeView_Types
        '
        Me.TreeView_Types.ContextMenuStrip = Me.ContextMenuStrip_Classes
        Me.TreeView_Types.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Types.HideSelection = False
        Me.TreeView_Types.ImageIndex = 0
        Me.TreeView_Types.ImageList = Me.ImageList_Classtree
        Me.TreeView_Types.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_Types.Name = "TreeView_Types"
        Me.TreeView_Types.SelectedImageIndex = 0
        Me.TreeView_Types.Size = New System.Drawing.Size(582, 440)
        Me.TreeView_Types.TabIndex = 0
        '
        'ContextMenuStrip_Classes
        '
        Me.ContextMenuStrip_Classes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_Classes.Name = "ContextMenuStrip_Classes"
        Me.ContextMenuStrip_Classes.Size = New System.Drawing.Size(153, 70)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "x_New"
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
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Mark, Me.ToolStripTextBox_MarkTypes})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(358, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_Mark
        '
        Me.ToolStripLabel_Mark.Name = "ToolStripLabel_Mark"
        Me.ToolStripLabel_Mark.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel_Mark.Text = "x_Mark:"
        '
        'ToolStripTextBox_MarkTypes
        '
        Me.ToolStripTextBox_MarkTypes.Name = "ToolStripTextBox_MarkTypes"
        Me.ToolStripTextBox_MarkTypes.Size = New System.Drawing.Size(300, 25)
        '
        'Timer_Mark
        '
        Me.Timer_Mark.Interval = 300
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        '
        'UserControl_TypeTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_TypeTree"
        Me.Size = New System.Drawing.Size(582, 490)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ContextMenuStrip_Classes.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Count As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TreeView_Types As System.Windows.Forms.TreeView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Mark As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_MarkTypes As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ImageList_Classtree As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripLabel_ID As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox_ID As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Timer_Mark As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip_Classes As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
