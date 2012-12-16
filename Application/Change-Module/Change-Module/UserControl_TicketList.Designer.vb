<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_TicketList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_TicketList))
        Me.DataGridView_Tickets = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_Tickets = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EqualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox_Equal = New System.Windows.Forms.ToolStripTextBox()
        Me.NotEqualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox_NotEqual = New System.Windows.Forms.ToolStripTextBox()
        Me.approximateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox_approximate = New System.Windows.Forms.ToolStripTextBox()
        Me.ContainsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox_Contains = New System.Windows.Forms.ToolStripTextBox()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource_Tickets = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator_Tickets = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_TicketRel = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView_Tickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_Tickets.SuspendLayout()
        CType(Me.BindingSource_Tickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator_Tickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator_Tickets.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView_Tickets
        '
        Me.DataGridView_Tickets.AllowUserToAddRows = False
        Me.DataGridView_Tickets.AllowUserToDeleteRows = False
        Me.DataGridView_Tickets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Tickets.ContextMenuStrip = Me.ContextMenuStrip_Tickets
        Me.DataGridView_Tickets.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Tickets.Name = "DataGridView_Tickets"
        Me.DataGridView_Tickets.ReadOnly = True
        Me.DataGridView_Tickets.Size = New System.Drawing.Size(619, 404)
        Me.DataGridView_Tickets.TabIndex = 0
        '
        'ContextMenuStrip_Tickets
        '
        Me.ContextMenuStrip_Tickets.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.FilterToolStripMenuItem, Me.RelateToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_Tickets.Name = "ContextMenuStrip_Tickets"
        Me.ContextMenuStrip_Tickets.Size = New System.Drawing.Size(153, 136)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.NewToolStripMenuItem.Text = "x_New"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EqualToolStripMenuItem, Me.NotEqualToolStripMenuItem, Me.approximateToolStripMenuItem, Me.ContainsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FilterToolStripMenuItem.Text = "x_Filter"
        '
        'EqualToolStripMenuItem
        '
        Me.EqualToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox_Equal})
        Me.EqualToolStripMenuItem.Name = "EqualToolStripMenuItem"
        Me.EqualToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.EqualToolStripMenuItem.Text = "x_equal"
        '
        'ToolStripTextBox_Equal
        '
        Me.ToolStripTextBox_Equal.Name = "ToolStripTextBox_Equal"
        Me.ToolStripTextBox_Equal.Size = New System.Drawing.Size(100, 21)
        '
        'NotEqualToolStripMenuItem
        '
        Me.NotEqualToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox_NotEqual})
        Me.NotEqualToolStripMenuItem.Name = "NotEqualToolStripMenuItem"
        Me.NotEqualToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NotEqualToolStripMenuItem.Text = "x_not equal"
        '
        'ToolStripTextBox_NotEqual
        '
        Me.ToolStripTextBox_NotEqual.Name = "ToolStripTextBox_NotEqual"
        Me.ToolStripTextBox_NotEqual.Size = New System.Drawing.Size(100, 21)
        '
        'approximateToolStripMenuItem
        '
        Me.approximateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox_approximate})
        Me.approximateToolStripMenuItem.Name = "approximateToolStripMenuItem"
        Me.approximateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.approximateToolStripMenuItem.Text = "x_approximate"
        '
        'ToolStripTextBox_approximate
        '
        Me.ToolStripTextBox_approximate.Name = "ToolStripTextBox_approximate"
        Me.ToolStripTextBox_approximate.Size = New System.Drawing.Size(100, 21)
        '
        'ContainsToolStripMenuItem
        '
        Me.ContainsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox_Contains})
        Me.ContainsToolStripMenuItem.Name = "ContainsToolStripMenuItem"
        Me.ContainsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ContainsToolStripMenuItem.Text = "x_Contains"
        '
        'ToolStripTextBox_Contains
        '
        Me.ToolStripTextBox_Contains.Name = "ToolStripTextBox_Contains"
        Me.ToolStripTextBox_Contains.Size = New System.Drawing.Size(100, 21)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'RelateToolStripMenuItem
        '
        Me.RelateToolStripMenuItem.Enabled = False
        Me.RelateToolStripMenuItem.Name = "RelateToolStripMenuItem"
        Me.RelateToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.RelateToolStripMenuItem.Text = "x_relate"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Enabled = False
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.OpenToolStripMenuItem.Text = "x_Open"
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Enabled = False
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        Me.ApplyToolStripMenuItem.Visible = False
        '
        'BindingNavigator_Tickets
        '
        Me.BindingNavigator_Tickets.AddNewItem = Nothing
        Me.BindingNavigator_Tickets.BindingSource = Me.BindingSource_Tickets
        Me.BindingNavigator_Tickets.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator_Tickets.DeleteItem = Nothing
        Me.BindingNavigator_Tickets.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator_Tickets.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton_TicketRel})
        Me.BindingNavigator_Tickets.Location = New System.Drawing.Point(0, 407)
        Me.BindingNavigator_Tickets.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator_Tickets.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator_Tickets.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator_Tickets.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator_Tickets.Name = "BindingNavigator_Tickets"
        Me.BindingNavigator_Tickets.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator_Tickets.Size = New System.Drawing.Size(619, 25)
        Me.BindingNavigator_Tickets.TabIndex = 1
        Me.BindingNavigator_Tickets.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuelle Position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_TicketRel
        '
        Me.ToolStripButton_TicketRel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_TicketRel.Enabled = False
        Me.ToolStripButton_TicketRel.Image = CType(resources.GetObject("ToolStripButton_TicketRel.Image"), System.Drawing.Image)
        Me.ToolStripButton_TicketRel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_TicketRel.Name = "ToolStripButton_TicketRel"
        Me.ToolStripButton_TicketRel.Size = New System.Drawing.Size(104, 22)
        Me.ToolStripButton_TicketRel.Text = "x_Refresh-Relation"
        '
        'UserControl_TicketList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BindingNavigator_Tickets)
        Me.Controls.Add(Me.DataGridView_Tickets)
        Me.Name = "UserControl_TicketList"
        Me.Size = New System.Drawing.Size(619, 432)
        CType(Me.DataGridView_Tickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_Tickets.ResumeLayout(False)
        CType(Me.BindingSource_Tickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator_Tickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator_Tickets.ResumeLayout(False)
        Me.BindingNavigator_Tickets.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView_Tickets As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_Tickets As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip_Tickets As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EqualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox_Equal As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents NotEqualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox_NotEqual As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents approximateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox_approximate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ContainsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox_Contains As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingNavigator_Tickets As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RelateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton_TicketRel As System.Windows.Forms.ToolStripButton

End Class
