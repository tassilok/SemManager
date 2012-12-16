<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutlookConnector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOutlookConnector))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView_MailItems = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_Filter = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquivalentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotEquivalentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContainsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox_Contains = New System.Windows.Forms.ToolStripTextBox()
        Me.DateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MltblMailItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_OutlookConnector = New Outlook_Connector.DataSet_OutlookConnector()
        Me.BindingNavigator_MailItems = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Label_Filter = New System.Windows.Forms.Label()
        Me.Label_FilterLBL = New System.Windows.Forms.Label()
        Me.Button_Refresh = New System.Windows.Forms.Button()
        Me.Label_CurrentFolder = New System.Windows.Forms.Label()
        Me.Label_Folder = New System.Windows.Forms.Label()
        Me.Label_State = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_GetMailItems = New System.Windows.Forms.Button()
        Me.Proc_MailItemsTableAdapter = New Outlook_Connector.DataSet_OutlookConnectorTableAdapters.proc_MailItemsTableAdapter()
        Me.SemItemPresentDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SenderEmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SenderNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView_MailItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_Filter.SuspendLayout()
        CType(Me.MltblMailItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_OutlookConnector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator_MailItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator_MailItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Filter)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_FilterLBL)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Refresh)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_CurrentFolder)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Folder)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_State)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_GetMailItems)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(561, 448)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(561, 473)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Location = New System.Drawing.Point(15, 77)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView_MailItems)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BindingNavigator_MailItems)
        Me.SplitContainer1.Size = New System.Drawing.Size(534, 343)
        Me.SplitContainer1.SplitterDistance = 326
        Me.SplitContainer1.TabIndex = 10
        '
        'DataGridView_MailItems
        '
        Me.DataGridView_MailItems.AllowUserToAddRows = False
        Me.DataGridView_MailItems.AllowUserToDeleteRows = False
        Me.DataGridView_MailItems.AutoGenerateColumns = False
        Me.DataGridView_MailItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_MailItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SemItemPresentDataGridViewCheckBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.EntryIDDataGridViewTextBoxColumn, Me.Folder, Me.SenderEmailAddressDataGridViewTextBoxColumn, Me.SenderNameDataGridViewTextBoxColumn, Me.CreationDateDataGridViewTextBoxColumn, Me.ToDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn})
        Me.DataGridView_MailItems.ContextMenuStrip = Me.ContextMenuStrip_Filter
        Me.DataGridView_MailItems.DataSource = Me.MltblMailItemsBindingSource
        Me.DataGridView_MailItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_MailItems.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_MailItems.Name = "DataGridView_MailItems"
        Me.DataGridView_MailItems.ReadOnly = True
        Me.DataGridView_MailItems.Size = New System.Drawing.Size(322, 314)
        Me.DataGridView_MailItems.TabIndex = 11
        '
        'ContextMenuStrip_Filter
        '
        Me.ContextMenuStrip_Filter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterToolStripMenuItem, Me.EditToolStripMenuItem, Me.SemDBToolStripMenuItem, Me.OpenToolStripMenuItem})
        Me.ContextMenuStrip_Filter.Name = "ContextMenuStrip_Filter"
        Me.ContextMenuStrip_Filter.Size = New System.Drawing.Size(118, 92)
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EquivalentToolStripMenuItem, Me.NotEquivalentToolStripMenuItem, Me.ContainsToolStripMenuItem, Me.DateToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.FilterToolStripMenuItem.Text = "Filter"
        '
        'EquivalentToolStripMenuItem
        '
        Me.EquivalentToolStripMenuItem.Name = "EquivalentToolStripMenuItem"
        Me.EquivalentToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.EquivalentToolStripMenuItem.Text = "equivalent"
        '
        'NotEquivalentToolStripMenuItem
        '
        Me.NotEquivalentToolStripMenuItem.Name = "NotEquivalentToolStripMenuItem"
        Me.NotEquivalentToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NotEquivalentToolStripMenuItem.Text = "not equivalent"
        '
        'ContainsToolStripMenuItem
        '
        Me.ContainsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox_Contains})
        Me.ContainsToolStripMenuItem.Name = "ContainsToolStripMenuItem"
        Me.ContainsToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ContainsToolStripMenuItem.Text = "Contains"
        '
        'ToolStripTextBox_Contains
        '
        Me.ToolStripTextBox_Contains.Name = "ToolStripTextBox_Contains"
        Me.ToolStripTextBox_Contains.Size = New System.Drawing.Size(100, 23)
        '
        'DateToolStripMenuItem
        '
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        Me.DateToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DateToolStripMenuItem.Text = "Date"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SemDBToolStripMenuItem
        '
        Me.SemDBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateItemsToolStripMenuItem})
        Me.SemDBToolStripMenuItem.Name = "SemDBToolStripMenuItem"
        Me.SemDBToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SemDBToolStripMenuItem.Text = "Sem-DB"
        '
        'CreateItemsToolStripMenuItem
        '
        Me.CreateItemsToolStripMenuItem.Name = "CreateItemsToolStripMenuItem"
        Me.CreateItemsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CreateItemsToolStripMenuItem.Text = "Create-Items"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'MltblMailItemsBindingSource
        '
        Me.MltblMailItemsBindingSource.DataMember = "proc_MailItems"
        Me.MltblMailItemsBindingSource.DataSource = Me.DataSet_OutlookConnector
        Me.MltblMailItemsBindingSource.Sort = "CreationDate DESC"
        '
        'DataSet_OutlookConnector
        '
        Me.DataSet_OutlookConnector.DataSetName = "DataSet_OutlookConnector"
        Me.DataSet_OutlookConnector.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigator_MailItems
        '
        Me.BindingNavigator_MailItems.AddNewItem = Nothing
        Me.BindingNavigator_MailItems.BindingSource = Me.MltblMailItemsBindingSource
        Me.BindingNavigator_MailItems.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator_MailItems.DeleteItem = Nothing
        Me.BindingNavigator_MailItems.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator_MailItems.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator_MailItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.BindingNavigator_MailItems.Location = New System.Drawing.Point(0, 314)
        Me.BindingNavigator_MailItems.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator_MailItems.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator_MailItems.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator_MailItems.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator_MailItems.Name = "BindingNavigator_MailItems"
        Me.BindingNavigator_MailItems.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator_MailItems.Size = New System.Drawing.Size(322, 25)
        Me.BindingNavigator_MailItems.TabIndex = 10
        Me.BindingNavigator_MailItems.Text = "BindingNavigator1"
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
        'Label_Filter
        '
        Me.Label_Filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_Filter.AutoSize = True
        Me.Label_Filter.Location = New System.Drawing.Point(51, 423)
        Me.Label_Filter.Name = "Label_Filter"
        Me.Label_Filter.Size = New System.Drawing.Size(10, 13)
        Me.Label_Filter.TabIndex = 8
        Me.Label_Filter.Text = "-"
        '
        'Label_FilterLBL
        '
        Me.Label_FilterLBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_FilterLBL.AutoSize = True
        Me.Label_FilterLBL.Location = New System.Drawing.Point(12, 423)
        Me.Label_FilterLBL.Name = "Label_FilterLBL"
        Me.Label_FilterLBL.Size = New System.Drawing.Size(32, 13)
        Me.Label_FilterLBL.TabIndex = 7
        Me.Label_FilterLBL.Text = "Filter:"
        '
        'Button_Refresh
        '
        Me.Button_Refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Refresh.Location = New System.Drawing.Point(474, 7)
        Me.Button_Refresh.Name = "Button_Refresh"
        Me.Button_Refresh.Size = New System.Drawing.Size(75, 23)
        Me.Button_Refresh.TabIndex = 5
        Me.Button_Refresh.Text = "Refresh"
        Me.Button_Refresh.UseVisualStyleBackColor = True
        '
        'Label_CurrentFolder
        '
        Me.Label_CurrentFolder.AutoSize = True
        Me.Label_CurrentFolder.Location = New System.Drawing.Point(54, 24)
        Me.Label_CurrentFolder.Name = "Label_CurrentFolder"
        Me.Label_CurrentFolder.Size = New System.Drawing.Size(10, 13)
        Me.Label_CurrentFolder.TabIndex = 4
        Me.Label_CurrentFolder.Text = "-"
        '
        'Label_Folder
        '
        Me.Label_Folder.AutoSize = True
        Me.Label_Folder.Location = New System.Drawing.Point(10, 24)
        Me.Label_Folder.Name = "Label_Folder"
        Me.Label_Folder.Size = New System.Drawing.Size(39, 13)
        Me.Label_Folder.TabIndex = 3
        Me.Label_Folder.Text = "Folder:"
        '
        'Label_State
        '
        Me.Label_State.AutoSize = True
        Me.Label_State.Location = New System.Drawing.Point(51, 7)
        Me.Label_State.Name = "Label_State"
        Me.Label_State.Size = New System.Drawing.Size(67, 13)
        Me.Label_State.TabIndex = 2
        Me.Label_State.Text = "Not Running"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "State:"
        '
        'Button_GetMailItems
        '
        Me.Button_GetMailItems.Location = New System.Drawing.Point(12, 48)
        Me.Button_GetMailItems.Name = "Button_GetMailItems"
        Me.Button_GetMailItems.Size = New System.Drawing.Size(115, 23)
        Me.Button_GetMailItems.TabIndex = 0
        Me.Button_GetMailItems.Text = "Get Mailitems (Current Folder)"
        Me.Button_GetMailItems.UseVisualStyleBackColor = True
        '
        'Proc_MailItemsTableAdapter
        '
        Me.Proc_MailItemsTableAdapter.ClearBeforeFill = True
        '
        'SemItemPresentDataGridViewCheckBoxColumn
        '
        Me.SemItemPresentDataGridViewCheckBoxColumn.DataPropertyName = "SemItem_Present"
        Me.SemItemPresentDataGridViewCheckBoxColumn.HeaderText = "SemItem_Present"
        Me.SemItemPresentDataGridViewCheckBoxColumn.Name = "SemItemPresentDataGridViewCheckBoxColumn"
        Me.SemItemPresentDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EntryIDDataGridViewTextBoxColumn
        '
        Me.EntryIDDataGridViewTextBoxColumn.DataPropertyName = "EntryID"
        Me.EntryIDDataGridViewTextBoxColumn.HeaderText = "EntryID"
        Me.EntryIDDataGridViewTextBoxColumn.Name = "EntryIDDataGridViewTextBoxColumn"
        Me.EntryIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Folder
        '
        Me.Folder.DataPropertyName = "Folder"
        Me.Folder.HeaderText = "Folder"
        Me.Folder.Name = "Folder"
        Me.Folder.ReadOnly = True
        '
        'SenderEmailAddressDataGridViewTextBoxColumn
        '
        Me.SenderEmailAddressDataGridViewTextBoxColumn.DataPropertyName = "SenderEmailAddress"
        Me.SenderEmailAddressDataGridViewTextBoxColumn.HeaderText = "SenderEmailAddress"
        Me.SenderEmailAddressDataGridViewTextBoxColumn.Name = "SenderEmailAddressDataGridViewTextBoxColumn"
        Me.SenderEmailAddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SenderNameDataGridViewTextBoxColumn
        '
        Me.SenderNameDataGridViewTextBoxColumn.DataPropertyName = "SenderName"
        Me.SenderNameDataGridViewTextBoxColumn.HeaderText = "SenderName"
        Me.SenderNameDataGridViewTextBoxColumn.Name = "SenderNameDataGridViewTextBoxColumn"
        Me.SenderNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreationDateDataGridViewTextBoxColumn
        '
        Me.CreationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate"
        Me.CreationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate"
        Me.CreationDateDataGridViewTextBoxColumn.Name = "CreationDateDataGridViewTextBoxColumn"
        Me.CreationDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ToDataGridViewTextBoxColumn
        '
        Me.ToDataGridViewTextBoxColumn.DataPropertyName = "To"
        Me.ToDataGridViewTextBoxColumn.HeaderText = "To"
        Me.ToDataGridViewTextBoxColumn.Name = "ToDataGridViewTextBoxColumn"
        Me.ToDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        Me.SubjectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmOutlookConnector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 473)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOutlookConnector"
        Me.Text = "Outlook-Connector"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView_MailItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_Filter.ResumeLayout(False)
        CType(Me.MltblMailItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_OutlookConnector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator_MailItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator_MailItems.ResumeLayout(False)
        Me.BindingNavigator_MailItems.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents Label_State As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_GetMailItems As System.Windows.Forms.Button
    Friend WithEvents Label_CurrentFolder As System.Windows.Forms.Label
    Friend WithEvents Label_Folder As System.Windows.Forms.Label
    Friend WithEvents Button_Refresh As System.Windows.Forms.Button
    Friend WithEvents DataSet_OutlookConnector As Outlook_Connector.DataSet_OutlookConnector
    Friend WithEvents MltblMailItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip_Filter As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Label_Filter As System.Windows.Forms.Label
    Friend WithEvents Label_FilterLBL As System.Windows.Forms.Label
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContainsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox_Contains As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquivalentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotEquivalentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SemDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BindingNavigator_MailItems As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Proc_MailItemsTableAdapter As Outlook_Connector.DataSet_OutlookConnectorTableAdapters.proc_MailItemsTableAdapter
    Friend WithEvents DataGridView_MailItems As System.Windows.Forms.DataGridView
    Friend WithEvents SemItemPresentDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntryIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Folder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SenderEmailAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SenderNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
