<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankTransactionModule
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBankTransactionModule))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.BindingNavigator_BankTransaction = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingSource_BankTransactions = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView_BankTransactions = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_BankTransactions = New System.Windows.Forms.ContextMenuStrip(Me.components)
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
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Import = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel_LastImportLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_LastImport = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_NoPayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton_Folder = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItem_Transactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Archive = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_Equal = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_NotEqual = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_approximate = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Contains = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Filter = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_ClearFilter = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.BindingNavigator_BankTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator_BankTransaction.SuspendLayout()
        CType(Me.BindingSource_BankTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_BankTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_BankTransactions.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.BindingNavigator_BankTransaction)
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_BankTransactions)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(556, 396)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(556, 446)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'BindingNavigator_BankTransaction
        '
        Me.BindingNavigator_BankTransaction.AddNewItem = Nothing
        Me.BindingNavigator_BankTransaction.BindingSource = Me.BindingSource_BankTransactions
        Me.BindingNavigator_BankTransaction.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator_BankTransaction.DeleteItem = Nothing
        Me.BindingNavigator_BankTransaction.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator_BankTransaction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator_BankTransaction.Location = New System.Drawing.Point(3, 0)
        Me.BindingNavigator_BankTransaction.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator_BankTransaction.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator_BankTransaction.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator_BankTransaction.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator_BankTransaction.Name = "BindingNavigator_BankTransaction"
        Me.BindingNavigator_BankTransaction.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator_BankTransaction.Size = New System.Drawing.Size(218, 25)
        Me.BindingNavigator_BankTransaction.TabIndex = 1
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Close})
        Me.ToolStrip1.Location = New System.Drawing.Point(222, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(62, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Close
        '
        Me.ToolStripButton_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Close.Image = CType(resources.GetObject("ToolStripButton_Close.Image"), System.Drawing.Image)
        Me.ToolStripButton_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
        Me.ToolStripButton_Close.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton_Close.Text = "x_Close"
        '
        'DataGridView_BankTransactions
        '
        Me.DataGridView_BankTransactions.AllowUserToAddRows = False
        Me.DataGridView_BankTransactions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_BankTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_BankTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_BankTransactions.ContextMenuStrip = Me.ContextMenuStrip_BankTransactions
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_BankTransactions.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_BankTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_BankTransactions.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_BankTransactions.Name = "DataGridView_BankTransactions"
        Me.DataGridView_BankTransactions.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_BankTransactions.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_BankTransactions.Size = New System.Drawing.Size(556, 396)
        Me.DataGridView_BankTransactions.TabIndex = 0
        '
        'ContextMenuStrip_BankTransactions
        '
        Me.ContextMenuStrip_BankTransactions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterToolStripMenuItem, Me.EditToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_BankTransactions.Name = "ContextMenuStrip_BankTransactions"
        Me.ContextMenuStrip_BankTransactions.Size = New System.Drawing.Size(116, 70)
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EqualToolStripMenuItem, Me.NotEqualToolStripMenuItem, Me.approximateToolStripMenuItem, Me.ContainsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.FilterToolStripMenuItem.Text = "x_Filter"
        '
        'EqualToolStripMenuItem
        '
        Me.EqualToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox_Equal})
        Me.EqualToolStripMenuItem.Name = "EqualToolStripMenuItem"
        Me.EqualToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EqualToolStripMenuItem.Text = "x_equal"
        '
        'ToolStripTextBox_Equal
        '
        Me.ToolStripTextBox_Equal.Name = "ToolStripTextBox_Equal"
        Me.ToolStripTextBox_Equal.Size = New System.Drawing.Size(100, 23)
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
        Me.ToolStripTextBox_NotEqual.Size = New System.Drawing.Size(100, 23)
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
        Me.ToolStripTextBox_approximate.Size = New System.Drawing.Size(100, 23)
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
        Me.ToolStripTextBox_Contains.Size = New System.Drawing.Size(100, 23)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Image = Global.Bank_Transaction_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ArchiveToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.EditToolStripMenuItem.Text = "x_Edit"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyToolStripMenuItem.Text = "x_Copy"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "x_Delete"
        '
        'ArchiveToolStripMenuItem
        '
        Me.ArchiveToolStripMenuItem.Name = "ArchiveToolStripMenuItem"
        Me.ArchiveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ArchiveToolStripMenuItem.Text = "x_Archive"
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        Me.ApplyToolStripMenuItem.Visible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Import, Me.ToolStripLabel_LastImportLBL, Me.ToolStripLabel_LastImport, Me.ToolStripSeparator1, Me.ToolStripButton_NoPayment, Me.ToolStripSeparator2, Me.ToolStripSplitButton_Folder})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(326, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripButton_Import
        '
        Me.ToolStripButton_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Import.Image = CType(resources.GetObject("ToolStripButton_Import.Image"), System.Drawing.Image)
        Me.ToolStripButton_Import.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Import.Name = "ToolStripButton_Import"
        Me.ToolStripButton_Import.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton_Import.Text = "x_Import"
        '
        'ToolStripLabel_LastImportLBL
        '
        Me.ToolStripLabel_LastImportLBL.Name = "ToolStripLabel_LastImportLBL"
        Me.ToolStripLabel_LastImportLBL.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripLabel_LastImportLBL.Text = "x_Last Import:"
        '
        'ToolStripLabel_LastImport
        '
        Me.ToolStripLabel_LastImport.Name = "ToolStripLabel_LastImport"
        Me.ToolStripLabel_LastImport.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel_LastImport.Text = "-"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_NoPayment
        '
        Me.ToolStripButton_NoPayment.Checked = True
        Me.ToolStripButton_NoPayment.CheckOnClick = True
        Me.ToolStripButton_NoPayment.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton_NoPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_NoPayment.Image = CType(resources.GetObject("ToolStripButton_NoPayment.Image"), System.Drawing.Image)
        Me.ToolStripButton_NoPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_NoPayment.Name = "ToolStripButton_NoPayment"
        Me.ToolStripButton_NoPayment.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripButton_NoPayment.Text = "x_No Payment"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSplitButton_Folder
        '
        Me.ToolStripSplitButton_Folder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton_Folder.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Transactions, Me.ToolStripMenuItem_Archive})
        Me.ToolStripSplitButton_Folder.Image = CType(resources.GetObject("ToolStripSplitButton_Folder.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton_Folder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton_Folder.Name = "ToolStripSplitButton_Folder"
        Me.ToolStripSplitButton_Folder.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripSplitButton_Folder.Text = "x_Folder"
        '
        'ToolStripMenuItem_Transactions
        '
        Me.ToolStripMenuItem_Transactions.Checked = True
        Me.ToolStripMenuItem_Transactions.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem_Transactions.Name = "ToolStripMenuItem_Transactions"
        Me.ToolStripMenuItem_Transactions.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem_Transactions.Text = "x_Transactions"
        '
        'ToolStripMenuItem_Archive
        '
        Me.ToolStripMenuItem_Archive.Name = "ToolStripMenuItem_Archive"
        Me.ToolStripMenuItem_Archive.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem_Archive.Text = "x_Archive"
        '
        'Timer_Equal
        '
        Me.Timer_Equal.Interval = 500
        '
        'Timer_NotEqual
        '
        Me.Timer_NotEqual.Interval = 500
        '
        'Timer_approximate
        '
        Me.Timer_approximate.Interval = 500
        '
        'Timer_Contains
        '
        Me.Timer_Contains.Interval = 500
        '
        'Timer_Filter
        '
        Me.Timer_Filter.Interval = 300
        '
        'Timer_ClearFilter
        '
        Me.Timer_ClearFilter.Interval = 1000
        '
        'frmBankTransactionModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 446)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmBankTransactionModule"
        Me.Text = "x_Bank-Transaction-Module"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.BindingNavigator_BankTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator_BankTransaction.ResumeLayout(False)
        Me.BindingNavigator_BankTransaction.PerformLayout()
        CType(Me.BindingSource_BankTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_BankTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_BankTransactions.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView_BankTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_BankTransactions As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigator_BankTransaction As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip_BankTransactions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EqualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotEqualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents approximateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContainsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox_Equal As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox_NotEqual As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox_approximate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox_Contains As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Timer_Equal As System.Windows.Forms.Timer
    Friend WithEvents Timer_NotEqual As System.Windows.Forms.Timer
    Friend WithEvents Timer_approximate As System.Windows.Forms.Timer
    Friend WithEvents Timer_Contains As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Import As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_NoPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchiveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel_LastImportLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_LastImport As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton_Folder As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem_Transactions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Archive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_Filter As System.Windows.Forms.Timer
    Friend WithEvents Timer_ClearFilter As System.Windows.Forms.Timer

End Class
