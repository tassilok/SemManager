<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Bookmarks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Bookmarks))
        Me.ImageList_Bookmarks = New System.Windows.Forms.ImageList(Me.components)
        Me.BindingSource_Bookmarks = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Tree = New System.Windows.Forms.TabPage()
        Me.TabPage_Grid = New System.Windows.Forms.TabPage()
        Me.TreeView_Bookmarks = New System.Windows.Forms.TreeView()
        Me.DataGridView_Bookmarks = New System.Windows.Forms.DataGridView()
        CType(Me.BindingSource_Bookmarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Tree.SuspendLayout()
        Me.TabPage_Grid.SuspendLayout()
        CType(Me.DataGridView_Bookmarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList_Bookmarks
        '
        Me.ImageList_Bookmarks.ImageStream = CType(resources.GetObject("ImageList_Bookmarks.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Bookmarks.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Bookmarks.Images.SetKeyName(0, "bb_home_.png")
        Me.ImageList_Bookmarks.Images.SetKeyName(1, "pulsante_02_architetto_f_01_gray.png")
        Me.ImageList_Bookmarks.Images.SetKeyName(2, "Multimedia.ico")
        Me.ImageList_Bookmarks.Images.SetKeyName(3, "Image 32.png")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Tree)
        Me.TabControl1.Controls.Add(Me.TabPage_Grid)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(550, 407)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Tree
        '
        Me.TabPage_Tree.Controls.Add(Me.TreeView_Bookmarks)
        Me.TabPage_Tree.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Tree.Name = "TabPage_Tree"
        Me.TabPage_Tree.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Tree.Size = New System.Drawing.Size(542, 381)
        Me.TabPage_Tree.TabIndex = 1
        Me.TabPage_Tree.Text = "x_Bookmark-Baum"
        Me.TabPage_Tree.UseVisualStyleBackColor = True
        '
        'TabPage_Grid
        '
        Me.TabPage_Grid.Controls.Add(Me.DataGridView_Bookmarks)
        Me.TabPage_Grid.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Grid.Name = "TabPage_Grid"
        Me.TabPage_Grid.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Grid.Size = New System.Drawing.Size(542, 381)
        Me.TabPage_Grid.TabIndex = 2
        Me.TabPage_Grid.Text = "x_Bookmark_Tabelle"
        Me.TabPage_Grid.UseVisualStyleBackColor = True
        '
        'TreeView_Bookmarks
        '
        Me.TreeView_Bookmarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Bookmarks.ImageIndex = 0
        Me.TreeView_Bookmarks.ImageList = Me.ImageList_Bookmarks
        Me.TreeView_Bookmarks.Location = New System.Drawing.Point(3, 3)
        Me.TreeView_Bookmarks.Name = "TreeView_Bookmarks"
        Me.TreeView_Bookmarks.SelectedImageIndex = 0
        Me.TreeView_Bookmarks.Size = New System.Drawing.Size(536, 375)
        Me.TreeView_Bookmarks.TabIndex = 2
        '
        'DataGridView_Bookmarks
        '
        Me.DataGridView_Bookmarks.AllowUserToAddRows = False
        Me.DataGridView_Bookmarks.AllowUserToDeleteRows = False
        Me.DataGridView_Bookmarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Bookmarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Bookmarks.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView_Bookmarks.Name = "DataGridView_Bookmarks"
        Me.DataGridView_Bookmarks.ReadOnly = True
        Me.DataGridView_Bookmarks.Size = New System.Drawing.Size(536, 375)
        Me.DataGridView_Bookmarks.TabIndex = 0
        '
        'UserControl_Bookmarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "UserControl_Bookmarks"
        Me.Size = New System.Drawing.Size(550, 407)
        CType(Me.BindingSource_Bookmarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Tree.ResumeLayout(False)
        Me.TabPage_Grid.ResumeLayout(False)
        CType(Me.DataGridView_Bookmarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList_Bookmarks As System.Windows.Forms.ImageList
    Friend WithEvents BindingSource_Bookmarks As System.Windows.Forms.BindingSource
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Tree As System.Windows.Forms.TabPage
    Friend WithEvents TreeView_Bookmarks As System.Windows.Forms.TreeView
    Friend WithEvents TabPage_Grid As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView_Bookmarks As System.Windows.Forms.DataGridView

End Class
