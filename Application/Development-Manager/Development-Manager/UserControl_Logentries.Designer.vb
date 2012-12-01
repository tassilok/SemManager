<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Logentries
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
        Me.components = New System.ComponentModel.Container
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TextBox_Message = New System.Windows.Forms.TextBox
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel_ItemCounts = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel_ItemCountLbl = New System.Windows.Forms.ToolStripLabel
        Me.DataGridView_Logentries = New System.Windows.Forms.DataGridView
        Me.BindingSource_LogEntries = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip_Logentries = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_Logentries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_LogEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_Logentries.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_Message)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripContainer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(383, 384)
        Me.SplitContainer1.SplitterDistance = 73
        Me.SplitContainer1.TabIndex = 0
        '
        'TextBox_Message
        '
        Me.TextBox_Message.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Message.Location = New System.Drawing.Point(0, 0)
        Me.TextBox_Message.Multiline = True
        Me.TextBox_Message.Name = "TextBox_Message"
        Me.TextBox_Message.ReadOnly = True
        Me.TextBox_Message.Size = New System.Drawing.Size(379, 69)
        Me.TextBox_Message.TabIndex = 0
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_Logentries)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(379, 278)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(379, 303)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_ItemCounts, Me.ToolStripLabel_ItemCountLbl})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(67, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_ItemCounts
        '
        Me.ToolStripLabel_ItemCounts.Name = "ToolStripLabel_ItemCounts"
        Me.ToolStripLabel_ItemCounts.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_ItemCounts.Text = "0"
        '
        'ToolStripLabel_ItemCountLbl
        '
        Me.ToolStripLabel_ItemCountLbl.Name = "ToolStripLabel_ItemCountLbl"
        Me.ToolStripLabel_ItemCountLbl.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel_ItemCountLbl.Text = "Items_f"
        '
        'DataGridView_Logentries
        '
        Me.DataGridView_Logentries.AllowUserToAddRows = False
        Me.DataGridView_Logentries.AllowUserToDeleteRows = False
        Me.DataGridView_Logentries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Logentries.ContextMenuStrip = Me.ContextMenuStrip_Logentries
        Me.DataGridView_Logentries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Logentries.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Logentries.Name = "DataGridView_Logentries"
        Me.DataGridView_Logentries.ReadOnly = True
        Me.DataGridView_Logentries.Size = New System.Drawing.Size(379, 278)
        Me.DataGridView_Logentries.TabIndex = 0
        '
        'ContextMenuStrip_Logentries
        '
        Me.ContextMenuStrip_Logentries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.ContextMenuStrip_Logentries.Name = "ContextMenuStrip_Logentries"
        Me.ContextMenuStrip_Logentries.Size = New System.Drawing.Size(153, 48)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "Neu_f"
        '
        'UserControl_Logentries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_Logentries"
        Me.Size = New System.Drawing.Size(383, 384)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_Logentries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_LogEntries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_Logentries.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBox_Message As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_ItemCounts As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_ItemCountLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_Logentries As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_LogEntries As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip_Logentries As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
