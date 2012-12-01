<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevelopmentManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevelopmentManager))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl_ModuleManagement = New System.Windows.Forms.TabControl()
        Me.TabPage_Basedata = New System.Windows.Forms.TabPage()
        Me.TabPage_Requests = New System.Windows.Forms.TabPage()
        Me.TabPage_Logentries = New System.Windows.Forms.TabPage()
        Me.TabPage_DBSchema = New System.Windows.Forms.TabPage()
        Me.TabPage_SemConfig = New System.Windows.Forms.TabPage()
        Me.TabPage_GUIEntries = New System.Windows.Forms.TabPage()
        Me.TabPage_Messages = New System.Windows.Forms.TabPage()
        Me.TabPage_devStructures = New System.Windows.Forms.TabPage()
        Me.TabPage_Scenarios = New System.Windows.Forms.TabPage()
        Me.TabPage_Libraries = New System.Windows.Forms.TabPage()
        Me.TabPage_Features = New System.Windows.Forms.TabPage()
        Me.TabPage_ModuleManagement = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl_ModuleManagement.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1028, 370)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1028, 420)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Close})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(61, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Close
        '
        Me.ToolStripButton_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Close.Image = CType(resources.GetObject("ToolStripButton_Close.Image"), System.Drawing.Image)
        Me.ToolStripButton_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
        Me.ToolStripButton_Close.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton_Close.Text = "Close_f"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl_ModuleManagement)
        Me.SplitContainer1.Size = New System.Drawing.Size(1028, 370)
        Me.SplitContainer1.SplitterDistance = 341
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl_ModuleManagement
        '
        Me.TabControl_ModuleManagement.Controls.Add(Me.TabPage_Basedata)
        Me.TabControl_ModuleManagement.Controls.Add(Me.TabPage_Requests)
        Me.TabControl_ModuleManagement.Controls.Add(Me.TabPage_Logentries)
        Me.TabControl_ModuleManagement.Controls.Add(Me.TabPage_DBSchema)
        Me.TabControl_ModuleManagement.Controls.Add(Me.TabPage_SemConfig)
        Me.TabControl_ModuleManagement.Controls.Add(Me.TabPage_GUIEntries)
        Me.TabControl_ModuleManagement.Controls.Add(Me.TabPage_Messages)
        Me.TabControl_ModuleManagement.Controls.Add(Me.TabPage_devStructures)
        Me.TabControl_ModuleManagement.Controls.Add(Me.TabPage_Scenarios)
        Me.TabControl_ModuleManagement.Controls.Add(Me.TabPage_Libraries)
        Me.TabControl_ModuleManagement.Controls.Add(Me.TabPage_Features)
        Me.TabControl_ModuleManagement.Controls.Add(Me.TabPage_ModuleManagement)
        Me.TabControl_ModuleManagement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_ModuleManagement.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_ModuleManagement.Multiline = True
        Me.TabControl_ModuleManagement.Name = "TabControl_ModuleManagement"
        Me.TabControl_ModuleManagement.SelectedIndex = 0
        Me.TabControl_ModuleManagement.Size = New System.Drawing.Size(679, 366)
        Me.TabControl_ModuleManagement.TabIndex = 0
        '
        'TabPage_Basedata
        '
        Me.TabPage_Basedata.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Basedata.Name = "TabPage_Basedata"
        Me.TabPage_Basedata.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Basedata.Size = New System.Drawing.Size(671, 322)
        Me.TabPage_Basedata.TabIndex = 0
        Me.TabPage_Basedata.Text = "Basedata_f"
        Me.TabPage_Basedata.UseVisualStyleBackColor = True
        '
        'TabPage_Requests
        '
        Me.TabPage_Requests.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Requests.Name = "TabPage_Requests"
        Me.TabPage_Requests.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Requests.Size = New System.Drawing.Size(671, 322)
        Me.TabPage_Requests.TabIndex = 1
        Me.TabPage_Requests.Text = "Requests_f"
        Me.TabPage_Requests.UseVisualStyleBackColor = True
        '
        'TabPage_Logentries
        '
        Me.TabPage_Logentries.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Logentries.Name = "TabPage_Logentries"
        Me.TabPage_Logentries.Size = New System.Drawing.Size(671, 322)
        Me.TabPage_Logentries.TabIndex = 2
        Me.TabPage_Logentries.Text = "Logentries_f"
        Me.TabPage_Logentries.UseVisualStyleBackColor = True
        '
        'TabPage_DBSchema
        '
        Me.TabPage_DBSchema.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_DBSchema.Name = "TabPage_DBSchema"
        Me.TabPage_DBSchema.Size = New System.Drawing.Size(671, 322)
        Me.TabPage_DBSchema.TabIndex = 3
        Me.TabPage_DBSchema.Text = "DB-Schema_f"
        Me.TabPage_DBSchema.UseVisualStyleBackColor = True
        '
        'TabPage_SemConfig
        '
        Me.TabPage_SemConfig.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_SemConfig.Name = "TabPage_SemConfig"
        Me.TabPage_SemConfig.Size = New System.Drawing.Size(671, 322)
        Me.TabPage_SemConfig.TabIndex = 4
        Me.TabPage_SemConfig.Text = "Semantic-Config_f"
        Me.TabPage_SemConfig.UseVisualStyleBackColor = True
        '
        'TabPage_GUIEntries
        '
        Me.TabPage_GUIEntries.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_GUIEntries.Name = "TabPage_GUIEntries"
        Me.TabPage_GUIEntries.Size = New System.Drawing.Size(671, 322)
        Me.TabPage_GUIEntries.TabIndex = 5
        Me.TabPage_GUIEntries.Text = "GUI-Entries_f"
        Me.TabPage_GUIEntries.UseVisualStyleBackColor = True
        '
        'TabPage_Messages
        '
        Me.TabPage_Messages.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Messages.Name = "TabPage_Messages"
        Me.TabPage_Messages.Size = New System.Drawing.Size(671, 322)
        Me.TabPage_Messages.TabIndex = 6
        Me.TabPage_Messages.Text = "Messages_f"
        Me.TabPage_Messages.UseVisualStyleBackColor = True
        '
        'TabPage_devStructures
        '
        Me.TabPage_devStructures.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_devStructures.Name = "TabPage_devStructures"
        Me.TabPage_devStructures.Size = New System.Drawing.Size(671, 322)
        Me.TabPage_devStructures.TabIndex = 7
        Me.TabPage_devStructures.Text = "Development-Structures_f"
        Me.TabPage_devStructures.UseVisualStyleBackColor = True
        '
        'TabPage_Scenarios
        '
        Me.TabPage_Scenarios.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Scenarios.Name = "TabPage_Scenarios"
        Me.TabPage_Scenarios.Size = New System.Drawing.Size(671, 322)
        Me.TabPage_Scenarios.TabIndex = 8
        Me.TabPage_Scenarios.Text = "Scenarios_f"
        Me.TabPage_Scenarios.UseVisualStyleBackColor = True
        '
        'TabPage_Libraries
        '
        Me.TabPage_Libraries.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Libraries.Name = "TabPage_Libraries"
        Me.TabPage_Libraries.Size = New System.Drawing.Size(671, 322)
        Me.TabPage_Libraries.TabIndex = 9
        Me.TabPage_Libraries.Text = "Libraries_f"
        Me.TabPage_Libraries.UseVisualStyleBackColor = True
        '
        'TabPage_Features
        '
        Me.TabPage_Features.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Features.Name = "TabPage_Features"
        Me.TabPage_Features.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Features.Size = New System.Drawing.Size(671, 322)
        Me.TabPage_Features.TabIndex = 10
        Me.TabPage_Features.Text = "x_Features"
        Me.TabPage_Features.UseVisualStyleBackColor = True
        '
        'TabPage_ModuleManagement
        '
        Me.TabPage_ModuleManagement.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_ModuleManagement.Name = "TabPage_ModuleManagement"
        Me.TabPage_ModuleManagement.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ModuleManagement.Size = New System.Drawing.Size(671, 322)
        Me.TabPage_ModuleManagement.TabIndex = 11
        Me.TabPage_ModuleManagement.Text = "x_ModuleManagement"
        Me.TabPage_ModuleManagement.UseVisualStyleBackColor = True
        '
        'frmDevelopmentManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 420)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDevelopmentManager"
        Me.Text = "x_Features"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl_ModuleManagement.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl_ModuleManagement As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Basedata As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Requests As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Logentries As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_DBSchema As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_SemConfig As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_GUIEntries As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Messages As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_devStructures As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Scenarios As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Libraries As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Features As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_ModuleManagement As System.Windows.Forms.TabPage

End Class
