<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_SemanticConfig
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
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_Count = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_CountLbl = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView_ConfigItems = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip_SemItems = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.setExportModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_AddConfigItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_RemoveConfigItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_ShowCode = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_ExportRDF = New System.Windows.Forms.ToolStripButton()
        Me.BindingSource_ConfigItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_ConfigItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_SemItems.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.BindingSource_ConfigItems, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_ConfigItems)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(451, 427)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(451, 477)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Count, Me.ToolStripLabel_CountLbl})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(69, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_Count
        '
        Me.ToolStripLabel_Count.Name = "ToolStripLabel_Count"
        Me.ToolStripLabel_Count.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Count.Text = "0"
        '
        'ToolStripLabel_CountLbl
        '
        Me.ToolStripLabel_CountLbl.Name = "ToolStripLabel_CountLbl"
        Me.ToolStripLabel_CountLbl.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel_CountLbl.Text = "Item(s)"
        '
        'DataGridView_ConfigItems
        '
        Me.DataGridView_ConfigItems.AllowUserToAddRows = False
        Me.DataGridView_ConfigItems.AllowUserToDeleteRows = False
        Me.DataGridView_ConfigItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ConfigItems.ContextMenuStrip = Me.ContextMenuStrip_SemItems
        Me.DataGridView_ConfigItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_ConfigItems.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_ConfigItems.Name = "DataGridView_ConfigItems"
        Me.DataGridView_ConfigItems.ReadOnly = True
        Me.DataGridView_ConfigItems.Size = New System.Drawing.Size(451, 427)
        Me.DataGridView_ConfigItems.TabIndex = 0
        '
        'ContextMenuStrip_SemItems
        '
        Me.ContextMenuStrip_SemItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.setExportModeToolStripMenuItem})
        Me.ContextMenuStrip_SemItems.Name = "ContextMenuStrip_SemItems"
        Me.ContextMenuStrip_SemItems.Size = New System.Drawing.Size(172, 26)
        '
        'setExportModeToolStripMenuItem
        '
        Me.setExportModeToolStripMenuItem.Enabled = False
        Me.setExportModeToolStripMenuItem.Name = "setExportModeToolStripMenuItem"
        Me.setExportModeToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.setExportModeToolStripMenuItem.Text = "x_set Export-Mode"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_AddConfigItem, Me.ToolStripButton_RemoveConfigItem, Me.ToolStripSeparator1, Me.ToolStripButton_ShowCode, Me.ToolStripButton_ExportRDF})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(150, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_AddConfigItem
        '
        Me.ToolStripButton_AddConfigItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_AddConfigItem.Enabled = False
        Me.ToolStripButton_AddConfigItem.Image = Global.Development_Manager.My.Resources.Resources.b_plus
        Me.ToolStripButton_AddConfigItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_AddConfigItem.Name = "ToolStripButton_AddConfigItem"
        Me.ToolStripButton_AddConfigItem.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_AddConfigItem.Text = "ToolStripButton1"
        '
        'ToolStripButton_RemoveConfigItem
        '
        Me.ToolStripButton_RemoveConfigItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_RemoveConfigItem.Enabled = False
        Me.ToolStripButton_RemoveConfigItem.Image = Global.Development_Manager.My.Resources.Resources.b_minus
        Me.ToolStripButton_RemoveConfigItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_RemoveConfigItem.Name = "ToolStripButton_RemoveConfigItem"
        Me.ToolStripButton_RemoveConfigItem.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_RemoveConfigItem.Text = "ToolStripButton2"
        '
        'ToolStripButton_ShowCode
        '
        Me.ToolStripButton_ShowCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_ShowCode.Enabled = False
        Me.ToolStripButton_ShowCode.Image = Global.Development_Manager.My.Resources.Resources.appunti_architetto_franc_01
        Me.ToolStripButton_ShowCode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ShowCode.Name = "ToolStripButton_ShowCode"
        Me.ToolStripButton_ShowCode.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_ShowCode.Text = "ToolStripButton3"
        '
        'ToolStripButton_ExportRDF
        '
        Me.ToolStripButton_ExportRDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_ExportRDF.Enabled = False
        Me.ToolStripButton_ExportRDF.Image = Global.Development_Manager.My.Resources.Resources.XSDSchema_AllIcon
        Me.ToolStripButton_ExportRDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ExportRDF.Name = "ToolStripButton_ExportRDF"
        Me.ToolStripButton_ExportRDF.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripButton_ExportRDF.Text = "RDF"
        '
        'UserControl_SemanticConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_SemanticConfig"
        Me.Size = New System.Drawing.Size(451, 477)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_ConfigItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_SemItems.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.BindingSource_ConfigItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_ShowCode As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Count As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_CountLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_ConfigItems As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton_AddConfigItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_RemoveConfigItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingSource_ConfigItems As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip_SemItems As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents setExportModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton_ExportRDF As System.Windows.Forms.ToolStripButton

End Class
