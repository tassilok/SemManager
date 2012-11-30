<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemplateView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemplateView))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_ItemCountLbl = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_ItemCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Apply = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Cancel = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView_DBItems = New System.Windows.Forms.DataGridView()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_DBItems, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_DBItems)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1005, 407)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1005, 432)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_ItemCountLbl, Me.ToolStripLabel_ItemCount, Me.ToolStripSeparator1, Me.ToolStripButton_Apply, Me.ToolStripButton_Cancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(222, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_ItemCountLbl
        '
        Me.ToolStripLabel_ItemCountLbl.Name = "ToolStripLabel_ItemCountLbl"
        Me.ToolStripLabel_ItemCountLbl.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripLabel_ItemCountLbl.Text = "x_Item-Count:"
        '
        'ToolStripLabel_ItemCount
        '
        Me.ToolStripLabel_ItemCount.Name = "ToolStripLabel_ItemCount"
        Me.ToolStripLabel_ItemCount.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_ItemCount.Text = "0"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Apply
        '
        Me.ToolStripButton_Apply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Apply.Image = CType(resources.GetObject("ToolStripButton_Apply.Image"), System.Drawing.Image)
        Me.ToolStripButton_Apply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Apply.Name = "ToolStripButton_Apply"
        Me.ToolStripButton_Apply.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton_Apply.Text = "x_Apply"
        '
        'ToolStripButton_Cancel
        '
        Me.ToolStripButton_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Cancel.Image = CType(resources.GetObject("ToolStripButton_Cancel.Image"), System.Drawing.Image)
        Me.ToolStripButton_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Cancel.Name = "ToolStripButton_Cancel"
        Me.ToolStripButton_Cancel.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton_Cancel.Text = "x_Cancel"
        '
        'DataGridView_DBItems
        '
        Me.DataGridView_DBItems.AllowUserToAddRows = False
        Me.DataGridView_DBItems.AllowUserToDeleteRows = False
        Me.DataGridView_DBItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_DBItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_DBItems.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_DBItems.Name = "DataGridView_DBItems"
        Me.DataGridView_DBItems.Size = New System.Drawing.Size(1005, 407)
        Me.DataGridView_DBItems.TabIndex = 0
        '
        'frmTemplateView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 432)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTemplateView"
        Me.Text = "frmTemplateView"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_DBItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Apply As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView_DBItems As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripLabel_ItemCountLbl As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_ItemCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
