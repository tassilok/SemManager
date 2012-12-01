<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_DBSchema_For_Applications
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.DataGridView_DBSchemas = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton_Add_Schemas = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItem_DBschema_User = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuleSchemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigSchemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton_RemoveSchema = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_setExportFile = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.DataGridView_DBOnServer = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Add_DBOnServer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Remove_DB_On_Server = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_ExportDirect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_SaveToFile = New System.Windows.Forms.ToolStripButton()
        Me.BindingSource_DBSchemas = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_DBOnServer = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.DataGridView_DBSchemas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        CType(Me.DataGridView_DBOnServer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.BindingSource_DBSchemas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_DBOnServer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStripContainer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(641, 392)
        Me.SplitContainer1.SplitterDistance = 356
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_DBSchemas)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(352, 363)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(352, 388)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'DataGridView_DBSchemas
        '
        Me.DataGridView_DBSchemas.AllowUserToAddRows = False
        Me.DataGridView_DBSchemas.AllowUserToDeleteRows = False
        Me.DataGridView_DBSchemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_DBSchemas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_DBSchemas.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_DBSchemas.Name = "DataGridView_DBSchemas"
        Me.DataGridView_DBSchemas.ReadOnly = True
        Me.DataGridView_DBSchemas.Size = New System.Drawing.Size(352, 363)
        Me.DataGridView_DBSchemas.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton_Add_Schemas, Me.ToolStripButton_RemoveSchema, Me.ToolStripSeparator1, Me.ToolStripButton_setExportFile})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(180, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripSplitButton_Add_Schemas
        '
        Me.ToolStripSplitButton_Add_Schemas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton_Add_Schemas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_DBschema_User, Me.ModuleSchemaToolStripMenuItem, Me.ConfigSchemaToolStripMenuItem})
        Me.ToolStripSplitButton_Add_Schemas.Image = Global.Development_Manager.My.Resources.Resources.b_plus
        Me.ToolStripSplitButton_Add_Schemas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton_Add_Schemas.Name = "ToolStripSplitButton_Add_Schemas"
        Me.ToolStripSplitButton_Add_Schemas.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripSplitButton_Add_Schemas.Text = "ToolStripSplitButton1"
        '
        'ToolStripMenuItem_DBschema_User
        '
        Me.ToolStripMenuItem_DBschema_User.Name = "ToolStripMenuItem_DBschema_User"
        Me.ToolStripMenuItem_DBschema_User.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem_DBschema_User.Text = "x_User-Schema"
        '
        'ModuleSchemaToolStripMenuItem
        '
        Me.ModuleSchemaToolStripMenuItem.Name = "ModuleSchemaToolStripMenuItem"
        Me.ModuleSchemaToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ModuleSchemaToolStripMenuItem.Text = "x_Module-Schema"
        '
        'ConfigSchemaToolStripMenuItem
        '
        Me.ConfigSchemaToolStripMenuItem.Name = "ConfigSchemaToolStripMenuItem"
        Me.ConfigSchemaToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ConfigSchemaToolStripMenuItem.Text = "x_Config-Schema"
        '
        'ToolStripButton_RemoveSchema
        '
        Me.ToolStripButton_RemoveSchema.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_RemoveSchema.Enabled = False
        Me.ToolStripButton_RemoveSchema.Image = Global.Development_Manager.My.Resources.Resources.b_minus
        Me.ToolStripButton_RemoveSchema.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_RemoveSchema.Name = "ToolStripButton_RemoveSchema"
        Me.ToolStripButton_RemoveSchema.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_RemoveSchema.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_setExportFile
        '
        Me.ToolStripButton_setExportFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_setExportFile.Enabled = False
        Me.ToolStripButton_setExportFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_setExportFile.Name = "ToolStripButton_setExportFile"
        Me.ToolStripButton_setExportFile.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripButton_setExportFile.Text = "Export-File..."
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.DataGridView_DBOnServer)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(277, 363)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(277, 388)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'DataGridView_DBOnServer
        '
        Me.DataGridView_DBOnServer.AllowUserToAddRows = False
        Me.DataGridView_DBOnServer.AllowUserToDeleteRows = False
        Me.DataGridView_DBOnServer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_DBOnServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_DBOnServer.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_DBOnServer.Name = "DataGridView_DBOnServer"
        Me.DataGridView_DBOnServer.ReadOnly = True
        Me.DataGridView_DBOnServer.Size = New System.Drawing.Size(277, 363)
        Me.DataGridView_DBOnServer.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Add_DBOnServer, Me.ToolStripButton_Remove_DB_On_Server, Me.ToolStripButton_ExportDirect, Me.ToolStripButton_SaveToFile})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(117, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripButton_Add_DBOnServer
        '
        Me.ToolStripButton_Add_DBOnServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Add_DBOnServer.Enabled = False
        Me.ToolStripButton_Add_DBOnServer.Image = Global.Development_Manager.My.Resources.Resources.b_plus
        Me.ToolStripButton_Add_DBOnServer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Add_DBOnServer.Name = "ToolStripButton_Add_DBOnServer"
        Me.ToolStripButton_Add_DBOnServer.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Add_DBOnServer.Text = "ToolStripButton1"
        '
        'ToolStripButton_Remove_DB_On_Server
        '
        Me.ToolStripButton_Remove_DB_On_Server.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Remove_DB_On_Server.Enabled = False
        Me.ToolStripButton_Remove_DB_On_Server.Image = Global.Development_Manager.My.Resources.Resources.b_minus
        Me.ToolStripButton_Remove_DB_On_Server.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Remove_DB_On_Server.Name = "ToolStripButton_Remove_DB_On_Server"
        Me.ToolStripButton_Remove_DB_On_Server.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Remove_DB_On_Server.Text = "ToolStripButton1"
        '
        'ToolStripButton_ExportDirect
        '
        Me.ToolStripButton_ExportDirect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_ExportDirect.Enabled = False
        Me.ToolStripButton_ExportDirect.Image = Global.Development_Manager.My.Resources.Resources.Export_to_DB
        Me.ToolStripButton_ExportDirect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ExportDirect.Name = "ToolStripButton_ExportDirect"
        Me.ToolStripButton_ExportDirect.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_ExportDirect.Text = "ToolStripButton1"
        '
        'ToolStripButton_SaveToFile
        '
        Me.ToolStripButton_SaveToFile.Enabled = False
        Me.ToolStripButton_SaveToFile.Image = Global.Development_Manager.My.Resources.Resources.saveHS
        Me.ToolStripButton_SaveToFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_SaveToFile.Name = "ToolStripButton_SaveToFile"
        Me.ToolStripButton_SaveToFile.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripButton_SaveToFile.Text = "..."
        '
        'UserControl_DBSchema_For_Applications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_DBSchema_For_Applications"
        Me.Size = New System.Drawing.Size(641, 392)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.DataGridView_DBSchemas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        CType(Me.DataGridView_DBOnServer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.BindingSource_DBSchemas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_DBOnServer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource_DBSchemas As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents DataGridView_DBSchemas As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSplitButton_Add_Schemas As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem_DBschema_User As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModuleSchemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigSchemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton_RemoveSchema As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_setExportFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Add_DBOnServer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Remove_DB_On_Server As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_ExportDirect As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView_DBOnServer As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_DBOnServer As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripButton_SaveToFile As System.Windows.Forms.ToolStripButton

End Class
