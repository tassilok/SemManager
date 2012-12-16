<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillModule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillModule))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.TreeView_Transactions = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_FinancialTransaction = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFromBankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFromParentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_main = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripComboBox_SearchTemplates = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripTextBox_Search = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_SemItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Filter = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_TransactionDetails = New System.Windows.Forms.TabPage()
        Me.TabPage_Documents = New System.Windows.Forms.TabPage()
        Me.Timer_Filter = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource_Contractee = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_Contractor = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemoveFromTreeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToBillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ContextMenuStrip_FinancialTransaction.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.BindingSource_Contractee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Contractor, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1148, 498)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1148, 548)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Close})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
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
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStripContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1148, 498)
        Me.SplitContainer1.SplitterDistance = 550
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.TreeView_Transactions)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(546, 469)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(546, 494)
        Me.ToolStripContainer2.TabIndex = 1
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'TreeView_Transactions
        '
        Me.TreeView_Transactions.ContextMenuStrip = Me.ContextMenuStrip_FinancialTransaction
        Me.TreeView_Transactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Transactions.ImageIndex = 0
        Me.TreeView_Transactions.ImageList = Me.ImageList_main
        Me.TreeView_Transactions.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_Transactions.Name = "TreeView_Transactions"
        Me.TreeView_Transactions.SelectedImageIndex = 8
        Me.TreeView_Transactions.Size = New System.Drawing.Size(546, 469)
        Me.TreeView_Transactions.TabIndex = 0
        '
        'ContextMenuStrip_FinancialTransaction
        '
        Me.ContextMenuStrip_FinancialTransaction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTransactionToolStripMenuItem, Me.NewFromBankToolStripMenuItem, Me.NewFromParentToolStripMenuItem, Me.RemoveTransactionToolStripMenuItem, Me.RemoveFromTreeToolStripMenuItem, Me.DetailsToBillsToolStripMenuItem, Me.ApplyToolStripMenuItem})
        Me.ContextMenuStrip_FinancialTransaction.Name = "ContextMenuStrip_FinancialTransaction"
        Me.ContextMenuStrip_FinancialTransaction.Size = New System.Drawing.Size(185, 180)
        '
        'NewTransactionToolStripMenuItem
        '
        Me.NewTransactionToolStripMenuItem.Enabled = False
        Me.NewTransactionToolStripMenuItem.Name = "NewTransactionToolStripMenuItem"
        Me.NewTransactionToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.NewTransactionToolStripMenuItem.Text = "x_New"
        '
        'NewFromBankToolStripMenuItem
        '
        Me.NewFromBankToolStripMenuItem.Enabled = False
        Me.NewFromBankToolStripMenuItem.Name = "NewFromBankToolStripMenuItem"
        Me.NewFromBankToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.NewFromBankToolStripMenuItem.Text = "x_New (From Bank)"
        '
        'NewFromParentToolStripMenuItem
        '
        Me.NewFromParentToolStripMenuItem.Enabled = False
        Me.NewFromParentToolStripMenuItem.Name = "NewFromParentToolStripMenuItem"
        Me.NewFromParentToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.NewFromParentToolStripMenuItem.Text = "x_New (From Parent)"
        '
        'RemoveTransactionToolStripMenuItem
        '
        Me.RemoveTransactionToolStripMenuItem.Enabled = False
        Me.RemoveTransactionToolStripMenuItem.Name = "RemoveTransactionToolStripMenuItem"
        Me.RemoveTransactionToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RemoveTransactionToolStripMenuItem.Text = "x_Remove"
        '
        'ApplyToolStripMenuItem
        '
        Me.ApplyToolStripMenuItem.Enabled = False
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
        Me.ApplyToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ApplyToolStripMenuItem.Text = "x_Apply"
        Me.ApplyToolStripMenuItem.Visible = False
        '
        'ImageList_main
        '
        Me.ImageList_main.ImageStream = CType(resources.GetObject("ImageList_main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_main.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_main.Images.SetKeyName(0, "calcolatrice_architetto__01.png")
        Me.ImageList_main.Images.SetKeyName(1, "simple_calculator_01.png")
        Me.ImageList_main.Images.SetKeyName(2, "cross_hand_drawn_linda_k_02.png")
        Me.ImageList_main.Images.SetKeyName(3, "smiley114.png")
        Me.ImageList_main.Images.SetKeyName(4, "people_juliane_krug_04c.png")
        Me.ImageList_main.Images.SetKeyName(5, "arrow-left-red_benji_par_01.png")
        Me.ImageList_main.Images.SetKeyName(6, "arrow-right-green_benji__01.png")
        Me.ImageList_main.Images.SetKeyName(7, "bb_home_.png")
        Me.ImageList_main.Images.SetKeyName(8, "calcolatrice_architetto__01 Selected.png")
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_SearchTemplates, Me.ToolStripTextBox_Search, Me.ToolStripButton_SemItem, Me.ToolStripButton_Filter})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(407, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripComboBox_SearchTemplates
        '
        Me.ToolStripComboBox_SearchTemplates.Name = "ToolStripComboBox_SearchTemplates"
        Me.ToolStripComboBox_SearchTemplates.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripTextBox_Search
        '
        Me.ToolStripTextBox_Search.Name = "ToolStripTextBox_Search"
        Me.ToolStripTextBox_Search.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripButton_SemItem
        '
        Me.ToolStripButton_SemItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_SemItem.Enabled = False
        Me.ToolStripButton_SemItem.Image = CType(resources.GetObject("ToolStripButton_SemItem.Image"), System.Drawing.Image)
        Me.ToolStripButton_SemItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_SemItem.Name = "ToolStripButton_SemItem"
        Me.ToolStripButton_SemItem.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_SemItem.Text = "..."
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_TransactionDetails)
        Me.TabControl1.Controls.Add(Me.TabPage_Documents)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(590, 494)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_TransactionDetails
        '
        Me.TabPage_TransactionDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_TransactionDetails.Name = "TabPage_TransactionDetails"
        Me.TabPage_TransactionDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_TransactionDetails.Size = New System.Drawing.Size(582, 468)
        Me.TabPage_TransactionDetails.TabIndex = 0
        Me.TabPage_TransactionDetails.Text = "x_Transaction-Details"
        Me.TabPage_TransactionDetails.UseVisualStyleBackColor = True
        '
        'TabPage_Documents
        '
        Me.TabPage_Documents.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Documents.Name = "TabPage_Documents"
        Me.TabPage_Documents.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Documents.Size = New System.Drawing.Size(582, 468)
        Me.TabPage_Documents.TabIndex = 1
        Me.TabPage_Documents.Text = "x_Documents"
        Me.TabPage_Documents.UseVisualStyleBackColor = True
        '
        'Timer_Filter
        '
        Me.Timer_Filter.Interval = 1000
        '
        'RemoveFromTreeToolStripMenuItem
        '
        Me.RemoveFromTreeToolStripMenuItem.Enabled = False
        Me.RemoveFromTreeToolStripMenuItem.Name = "RemoveFromTreeToolStripMenuItem"
        Me.RemoveFromTreeToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RemoveFromTreeToolStripMenuItem.Text = "x_Remove from Tree"
        '
        'DetailsToBillsToolStripMenuItem
        '
        Me.DetailsToBillsToolStripMenuItem.Enabled = False
        Me.DetailsToBillsToolStripMenuItem.Name = "DetailsToBillsToolStripMenuItem"
        Me.DetailsToBillsToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DetailsToBillsToolStripMenuItem.Text = "x_Details to Bills"
        '
        'frmBillModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 548)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBillModule"
        Me.Text = "x_Bill-Module"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ContextMenuStrip_FinancialTransaction.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.BindingSource_Contractee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Contractor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_TransactionDetails As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Documents As System.Windows.Forms.TabPage
    Friend WithEvents ImageList_main As System.Windows.Forms.ImageList
    Friend WithEvents TreeView_Transactions As System.Windows.Forms.TreeView
    Friend WithEvents ContextMenuStrip_FinancialTransaction As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripComboBox_SearchTemplates As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripTextBox_Search As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Timer_Filter As System.Windows.Forms.Timer
    Friend WithEvents BindingSource_Contractee As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource_Contractor As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripButton_Filter As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewFromBankToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton_SemItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewFromParentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveFromTreeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToBillsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
