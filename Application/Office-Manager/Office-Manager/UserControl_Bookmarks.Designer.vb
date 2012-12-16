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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Button_CreateBookmark = New System.Windows.Forms.Button()
        Me.Button_DeleteBookmark = New System.Windows.Forms.Button()
        Me.Button_OpenBookmark = New System.Windows.Forms.Button()
        Me.DataGridView_Bookmark = New System.Windows.Forms.DataGridView()
        Me.BindingSource_Bookmarks = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView_Bookmark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Bookmarks, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button_CreateBookmark)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button_DeleteBookmark)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button_OpenBookmark)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView_Bookmark)
        Me.SplitContainer2.Size = New System.Drawing.Size(513, 428)
        Me.SplitContainer2.SplitterDistance = 113
        Me.SplitContainer2.TabIndex = 1
        '
        'Button_CreateBookmark
        '
        Me.Button_CreateBookmark.Location = New System.Drawing.Point(4, 62)
        Me.Button_CreateBookmark.Name = "Button_CreateBookmark"
        Me.Button_CreateBookmark.Size = New System.Drawing.Size(97, 23)
        Me.Button_CreateBookmark.TabIndex = 6
        Me.Button_CreateBookmark.Text = "x_Create"
        Me.Button_CreateBookmark.UseVisualStyleBackColor = True
        '
        'Button_DeleteBookmark
        '
        Me.Button_DeleteBookmark.Enabled = False
        Me.Button_DeleteBookmark.Location = New System.Drawing.Point(3, 91)
        Me.Button_DeleteBookmark.Name = "Button_DeleteBookmark"
        Me.Button_DeleteBookmark.Size = New System.Drawing.Size(97, 23)
        Me.Button_DeleteBookmark.TabIndex = 5
        Me.Button_DeleteBookmark.Text = "x_Delete"
        Me.Button_DeleteBookmark.UseVisualStyleBackColor = True
        '
        'Button_OpenBookmark
        '
        Me.Button_OpenBookmark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_OpenBookmark.Enabled = False
        Me.Button_OpenBookmark.Location = New System.Drawing.Point(3, 3)
        Me.Button_OpenBookmark.Name = "Button_OpenBookmark"
        Me.Button_OpenBookmark.Size = New System.Drawing.Size(89, 23)
        Me.Button_OpenBookmark.TabIndex = 4
        Me.Button_OpenBookmark.Text = "x_Open"
        Me.Button_OpenBookmark.UseVisualStyleBackColor = True
        '
        'DataGridView_Bookmark
        '
        Me.DataGridView_Bookmark.AllowUserToAddRows = False
        Me.DataGridView_Bookmark.AllowUserToDeleteRows = False
        Me.DataGridView_Bookmark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Bookmark.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Bookmark.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Bookmark.Name = "DataGridView_Bookmark"
        Me.DataGridView_Bookmark.ReadOnly = True
        Me.DataGridView_Bookmark.Size = New System.Drawing.Size(392, 424)
        Me.DataGridView_Bookmark.TabIndex = 0
        '
        'UserControl_Bookmarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "UserControl_Bookmarks"
        Me.Size = New System.Drawing.Size(513, 428)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView_Bookmark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Bookmarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button_CreateBookmark As System.Windows.Forms.Button
    Friend WithEvents Button_DeleteBookmark As System.Windows.Forms.Button
    Friend WithEvents Button_OpenBookmark As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Bookmark As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_Bookmarks As System.Windows.Forms.BindingSource

End Class
