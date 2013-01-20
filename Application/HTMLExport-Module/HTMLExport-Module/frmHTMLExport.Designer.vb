<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHTMLExport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHTMLExport))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Count = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView_HTMLDoc = New System.Windows.Forms.DataGridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton_Tests = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItem_HTMLDoc = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource_HTMLDOC = New System.Windows.Forms.BindingSource(Me.components)
        Me.WebBrowser_Test = New System.Windows.Forms.WebBrowser()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer2.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.DataGridView_HTMLDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.BindingSource_HTMLDOC, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1004, 547)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1004, 597)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStripContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser_Test)
        Me.SplitContainer1.Size = New System.Drawing.Size(1004, 547)
        Me.SplitContainer1.SplitterDistance = 334
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.BottomToolStripPanel
        '
        Me.ToolStripContainer2.BottomToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.DataGridView_HTMLDoc)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(330, 493)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(330, 543)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip3)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountLBL, Me.ToolStripLabel_Count})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(75, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_CountLBL
        '
        Me.ToolStripLabel_CountLBL.Name = "ToolStripLabel_CountLBL"
        Me.ToolStripLabel_CountLBL.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel_CountLBL.Text = "x_Count:"
        '
        'ToolStripLabel_Count
        '
        Me.ToolStripLabel_Count.Name = "ToolStripLabel_Count"
        Me.ToolStripLabel_Count.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Count.Text = "0"
        '
        'DataGridView_HTMLDoc
        '
        Me.DataGridView_HTMLDoc.AllowUserToAddRows = False
        Me.DataGridView_HTMLDoc.AllowUserToDeleteRows = False
        Me.DataGridView_HTMLDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_HTMLDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_HTMLDoc.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_HTMLDoc.Name = "DataGridView_HTMLDoc"
        Me.DataGridView_HTMLDoc.ReadOnly = True
        Me.DataGridView_HTMLDoc.Size = New System.Drawing.Size(330, 493)
        Me.DataGridView_HTMLDoc.TabIndex = 0
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton_Tests})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(71, 25)
        Me.ToolStrip3.TabIndex = 0
        '
        'ToolStripSplitButton_Tests
        '
        Me.ToolStripSplitButton_Tests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton_Tests.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_HTMLDoc})
        Me.ToolStripSplitButton_Tests.Image = CType(resources.GetObject("ToolStripSplitButton_Tests.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton_Tests.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton_Tests.Name = "ToolStripSplitButton_Tests"
        Me.ToolStripSplitButton_Tests.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripSplitButton_Tests.Text = "x_Tests"
        '
        'ToolStripMenuItem_HTMLDoc
        '
        Me.ToolStripMenuItem_HTMLDoc.Name = "ToolStripMenuItem_HTMLDoc"
        Me.ToolStripMenuItem_HTMLDoc.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem_HTMLDoc.Text = "x_HTML-Documents"
        '
        'WebBrowser_Test
        '
        Me.WebBrowser_Test.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser_Test.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser_Test.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser_Test.Name = "WebBrowser_Test"
        Me.WebBrowser_Test.Size = New System.Drawing.Size(662, 543)
        Me.WebBrowser_Test.TabIndex = 0
        '
        'frmHTMLExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 597)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmHTMLExport"
        Me.Text = "x_HTML-Export"
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
        Me.ToolStripContainer2.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.DataGridView_HTMLDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.BindingSource_HTMLDOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Count As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_HTMLDoc As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_HTMLDOC As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSplitButton_Tests As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem_HTMLDoc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser_Test As System.Windows.Forms.WebBrowser

End Class
