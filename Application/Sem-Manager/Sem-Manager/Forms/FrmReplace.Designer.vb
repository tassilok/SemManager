<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReplace
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReplace))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Label_Search = New System.Windows.Forms.Label()
        Me.TextBox_Search = New System.Windows.Forms.TextBox()
        Me.Label_Replace = New System.Windows.Forms.Label()
        Me.TextBox_Replace = New System.Windows.Forms.TextBox()
        Me.Button_Test = New System.Windows.Forms.Button()
        Me.DataGridView_Replace = New System.Windows.Forms.DataGridView()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DtblReplaceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Replace = New Sem_Manager.ds_Replace()
        Me.GUIDItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameReplacedItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GUIDParentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout
        Me.ToolStripContainer1.SuspendLayout
        CType(Me.DataGridView_Replace,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.BindingNavigator1.SuspendLayout
        CType(Me.DtblReplaceBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Ds_Replace,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.BindingNavigator1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Cancel)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_OK)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_Replace)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Test)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Replace)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Replace)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Search)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Search)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(889, 514)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(889, 539)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'Label_Search
        '
        Me.Label_Search.AutoSize = true
        Me.Label_Search.Location = New System.Drawing.Point(5, 7)
        Me.Label_Search.Name = "Label_Search"
        Me.Label_Search.Size = New System.Drawing.Size(55, 13)
        Me.Label_Search.TabIndex = 0
        Me.Label_Search.Text = "x_Search:"
        '
        'TextBox_Search
        '
        Me.TextBox_Search.Location = New System.Drawing.Point(66, 4)
        Me.TextBox_Search.Name = "TextBox_Search"
        Me.TextBox_Search.Size = New System.Drawing.Size(274, 20)
        Me.TextBox_Search.TabIndex = 1
        '
        'Label_Replace
        '
        Me.Label_Replace.AutoSize = true
        Me.Label_Replace.Location = New System.Drawing.Point(347, 7)
        Me.Label_Replace.Name = "Label_Replace"
        Me.Label_Replace.Size = New System.Drawing.Size(61, 13)
        Me.Label_Replace.TabIndex = 2
        Me.Label_Replace.Text = "x_Replace:"
        '
        'TextBox_Replace
        '
        Me.TextBox_Replace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TextBox_Replace.Location = New System.Drawing.Point(414, 4)
        Me.TextBox_Replace.Name = "TextBox_Replace"
        Me.TextBox_Replace.Size = New System.Drawing.Size(393, 20)
        Me.TextBox_Replace.TabIndex = 3
        '
        'Button_Test
        '
        Me.Button_Test.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button_Test.Enabled = false
        Me.Button_Test.Location = New System.Drawing.Point(811, 2)
        Me.Button_Test.Name = "Button_Test"
        Me.Button_Test.Size = New System.Drawing.Size(75, 23)
        Me.Button_Test.TabIndex = 4
        Me.Button_Test.Text = "x_Test"
        Me.Button_Test.UseVisualStyleBackColor = true
        '
        'DataGridView_Replace
        '
        Me.DataGridView_Replace.AllowUserToAddRows = false
        Me.DataGridView_Replace.AllowUserToDeleteRows = false
        Me.DataGridView_Replace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Replace.AutoGenerateColumns = false
        Me.DataGridView_Replace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Replace.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GUIDItemDataGridViewTextBoxColumn, Me.NameItemDataGridViewTextBoxColumn, Me.NameReplacedItemDataGridViewTextBoxColumn, Me.GUIDParentDataGridViewTextBoxColumn})
        Me.DataGridView_Replace.DataSource = Me.DtblReplaceBindingSource
        Me.DataGridView_Replace.Location = New System.Drawing.Point(4, 31)
        Me.DataGridView_Replace.Name = "DataGridView_Replace"
        Me.DataGridView_Replace.ReadOnly = true
        Me.DataGridView_Replace.Size = New System.Drawing.Size(882, 445)
        Me.DataGridView_Replace.TabIndex = 5
        '
        'Button_OK
        '
        Me.Button_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button_OK.Location = New System.Drawing.Point(723, 482)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(75, 23)
        Me.Button_OK.TabIndex = 6
        Me.Button_OK.Text = "OK"
        Me.Button_OK.UseVisualStyleBackColor = true
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.Location = New System.Drawing.Point(805, 482)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancel.TabIndex = 7
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = true
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.BindingNavigator1.BindingSource = Me.DtblReplaceBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(4, 480)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(209, 25)
        Me.BindingNavigator1.TabIndex = 8
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = false
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DtblReplaceBindingSource
        '
        Me.DtblReplaceBindingSource.DataMember = "dtbl_Replace"
        Me.DtblReplaceBindingSource.DataSource = Me.Ds_Replace
        '
        'Ds_Replace
        '
        Me.Ds_Replace.DataSetName = "ds_Replace"
        Me.Ds_Replace.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GUIDItemDataGridViewTextBoxColumn
        '
        Me.GUIDItemDataGridViewTextBoxColumn.DataPropertyName = "GUID_Item"
        Me.GUIDItemDataGridViewTextBoxColumn.HeaderText = "GUID_Item"
        Me.GUIDItemDataGridViewTextBoxColumn.Name = "GUIDItemDataGridViewTextBoxColumn"
        Me.GUIDItemDataGridViewTextBoxColumn.ReadOnly = true
        '
        'NameItemDataGridViewTextBoxColumn
        '
        Me.NameItemDataGridViewTextBoxColumn.DataPropertyName = "Name_Item"
        Me.NameItemDataGridViewTextBoxColumn.HeaderText = "Name_Item"
        Me.NameItemDataGridViewTextBoxColumn.Name = "NameItemDataGridViewTextBoxColumn"
        Me.NameItemDataGridViewTextBoxColumn.ReadOnly = true
        Me.NameItemDataGridViewTextBoxColumn.Width = 300
        '
        'NameReplacedItemDataGridViewTextBoxColumn
        '
        Me.NameReplacedItemDataGridViewTextBoxColumn.DataPropertyName = "Name_ReplacedItem"
        Me.NameReplacedItemDataGridViewTextBoxColumn.HeaderText = "Name_ReplacedItem"
        Me.NameReplacedItemDataGridViewTextBoxColumn.Name = "NameReplacedItemDataGridViewTextBoxColumn"
        Me.NameReplacedItemDataGridViewTextBoxColumn.ReadOnly = true
        Me.NameReplacedItemDataGridViewTextBoxColumn.Width = 300
        '
        'GUIDParentDataGridViewTextBoxColumn
        '
        Me.GUIDParentDataGridViewTextBoxColumn.DataPropertyName = "GUID_Parent"
        Me.GUIDParentDataGridViewTextBoxColumn.HeaderText = "GUID_Parent"
        Me.GUIDParentDataGridViewTextBoxColumn.Name = "GUIDParentDataGridViewTextBoxColumn"
        Me.GUIDParentDataGridViewTextBoxColumn.ReadOnly = true
        '
        'FrmReplace
        '
        Me.AcceptButton = Me.Button_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button_Cancel
        Me.ClientSize = New System.Drawing.Size(889, 539)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "FrmReplace"
        Me.Text = "x_Replace"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(false)
        Me.ToolStripContainer1.ContentPanel.PerformLayout
        Me.ToolStripContainer1.ResumeLayout(false)
        Me.ToolStripContainer1.PerformLayout
        CType(Me.DataGridView_Replace,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).EndInit
        Me.BindingNavigator1.ResumeLayout(false)
        Me.BindingNavigator1.PerformLayout
        CType(Me.DtblReplaceBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Ds_Replace,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Replace As System.Windows.Forms.DataGridView
    Friend WithEvents Button_Test As System.Windows.Forms.Button
    Friend WithEvents TextBox_Replace As System.Windows.Forms.TextBox
    Friend WithEvents Label_Replace As System.Windows.Forms.Label
    Friend WithEvents TextBox_Search As System.Windows.Forms.TextBox
    Friend WithEvents Label_Search As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DtblReplaceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Replace As Sem_Manager.ds_Replace
    Friend WithEvents GUIDItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameReplacedItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GUIDParentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
