<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView_Report = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_Reports = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip_Reports.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(771, 442)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(771, 492)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Close})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(59, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Close
        '
        Me.ToolStripButton_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Close.Image = CType(resources.GetObject("ToolStripButton_Close.Image"), System.Drawing.Image)
        Me.ToolStripButton_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
        Me.ToolStripButton_Close.Size = New System.Drawing.Size(49, 22)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView_Report)
        Me.SplitContainer1.Size = New System.Drawing.Size(771, 442)
        Me.SplitContainer1.SplitterDistance = 257
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView_Report
        '
        Me.TreeView_Report.ContextMenuStrip = Me.ContextMenuStrip_Reports
        Me.TreeView_Report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Report.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_Report.Name = "TreeView_Report"
        Me.TreeView_Report.Size = New System.Drawing.Size(253, 438)
        Me.TreeView_Report.TabIndex = 0
        '
        'ContextMenuStrip_Reports
        '
        Me.ContextMenuStrip_Reports.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddReportToolStripMenuItem, Me.GetColumnsToolStripMenuItem, Me.ExportXMLToolStripMenuItem})
        Me.ContextMenuStrip_Reports.Name = "ContextMenuStrip_Reports"
        Me.ContextMenuStrip_Reports.Size = New System.Drawing.Size(153, 92)
        '
        'AddReportToolStripMenuItem
        '
        Me.AddReportToolStripMenuItem.Name = "AddReportToolStripMenuItem"
        Me.AddReportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddReportToolStripMenuItem.Text = "x_Add Report"
        '
        'GetColumnsToolStripMenuItem
        '
        Me.GetColumnsToolStripMenuItem.Name = "GetColumnsToolStripMenuItem"
        Me.GetColumnsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GetColumnsToolStripMenuItem.Text = "x_Get Columns"
        '
        'ExportXMLToolStripMenuItem
        '
        Me.ExportXMLToolStripMenuItem.Enabled = False
        Me.ExportXMLToolStripMenuItem.Name = "ExportXMLToolStripMenuItem"
        Me.ExportXMLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportXMLToolStripMenuItem.Text = "x_export XML"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 492)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmMain"
        Me.Text = "x_Reports"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip_Reports.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView_Report As System.Windows.Forms.TreeView
    Friend WithEvents ContextMenuStrip_Reports As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GetColumnsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
