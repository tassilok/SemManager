<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_SearchResult
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
        Me.BindingSource_SearchResult = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer_Threads = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Count = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripProgressBar_Read = New System.Windows.Forms.ToolStripProgressBar()
        Me.DataGridView_Items = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_SearchResults = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyGUIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.BindingSource_SearchResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_SearchResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_Threads
        '
        Me.Timer_Threads.Interval = 300
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_Items)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(693, 410)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(693, 435)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountLBL, Me.ToolStripLabel_Count, Me.ToolStripProgressBar_Read})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(280, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_CountLBL
        '
        Me.ToolStripLabel_CountLBL.Name = "ToolStripLabel_CountLBL"
        Me.ToolStripLabel_CountLBL.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel_CountLBL.Text = "x_Count:"
        '
        'ToolStripLabel_Count
        '
        Me.ToolStripLabel_Count.Name = "ToolStripLabel_Count"
        Me.ToolStripLabel_Count.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Count.Text = "0"
        '
        'ToolStripProgressBar_Read
        '
        Me.ToolStripProgressBar_Read.Maximum = 4
        Me.ToolStripProgressBar_Read.Name = "ToolStripProgressBar_Read"
        Me.ToolStripProgressBar_Read.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripProgressBar_Read.Step = 1
        '
        'DataGridView_Items
        '
        Me.DataGridView_Items.AllowUserToAddRows = False
        Me.DataGridView_Items.AllowUserToDeleteRows = False
        Me.DataGridView_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Items.ContextMenuStrip = Me.ContextMenuStrip_SearchResults
        Me.DataGridView_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Items.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Items.Name = "DataGridView_Items"
        Me.DataGridView_Items.ReadOnly = True
        Me.DataGridView_Items.Size = New System.Drawing.Size(693, 410)
        Me.DataGridView_Items.TabIndex = 0
        '
        'ContextMenuStrip_SearchResults
        '
        Me.ContextMenuStrip_SearchResults.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.ContextMenuStrip_SearchResults.Name = "ContextMenuStrip_SearchResults"
        Me.ContextMenuStrip_SearchResults.Size = New System.Drawing.Size(105, 26)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyGUIDToolStripMenuItem, Me.CopyNameToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "x_Edit"
        '
        'CopyGUIDToolStripMenuItem
        '
        Me.CopyGUIDToolStripMenuItem.Name = "CopyGUIDToolStripMenuItem"
        Me.CopyGUIDToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyGUIDToolStripMenuItem.Text = "x_Copy GUID"
        '
        'CopyNameToolStripMenuItem
        '
        Me.CopyNameToolStripMenuItem.Name = "CopyNameToolStripMenuItem"
        Me.CopyNameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyNameToolStripMenuItem.Text = "x_Copy Name"
        '
        'UserControl_SearchResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_SearchResult"
        Me.Size = New System.Drawing.Size(693, 435)
        CType(Me.BindingSource_SearchResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_Items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_SearchResults.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource_SearchResult As System.Windows.Forms.BindingSource
    Friend WithEvents Timer_Threads As System.Windows.Forms.Timer
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Count As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripProgressBar_Read As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents DataGridView_Items As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip_SearchResults As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyGUIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
