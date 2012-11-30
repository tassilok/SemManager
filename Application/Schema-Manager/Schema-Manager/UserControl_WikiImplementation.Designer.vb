<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_WikiImplementation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_WikiImplementation))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.BindingSource_Wikidocs = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSplitButton_Export = New System.Windows.Forms.ToolStripSplitButton
        Me.ExportXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DirectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer
        Me.Label_Docs = New System.Windows.Forms.Label
        Me.DataGridView_Documents = New System.Windows.Forms.DataGridView
        Me.Button_getUrl = New System.Windows.Forms.Button
        Me.TextBox_Url = New System.Windows.Forms.TextBox
        Me.Label_Url = New System.Windows.Forms.Label
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.BindingSource_Wikidocs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        CType(Me.DataGridView_Documents, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(635, 356)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(635, 406)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton_Export})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(109, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripSplitButton_Export
        '
        Me.ToolStripSplitButton_Export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton_Export.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportXMLToolStripMenuItem, Me.DirectToolStripMenuItem})
        Me.ToolStripSplitButton_Export.Image = CType(resources.GetObject("ToolStripSplitButton_Export.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton_Export.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton_Export.Name = "ToolStripSplitButton_Export"
        Me.ToolStripSplitButton_Export.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripSplitButton_Export.Text = "x_Export"
        '
        'ExportXMLToolStripMenuItem
        '
        Me.ExportXMLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllToolStripMenuItem})
        Me.ExportXMLToolStripMenuItem.Name = "ExportXMLToolStripMenuItem"
        Me.ExportXMLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportXMLToolStripMenuItem.Text = "x_export XML"
        '
        'DirectToolStripMenuItem
        '
        Me.DirectToolStripMenuItem.Name = "DirectToolStripMenuItem"
        Me.DirectToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DirectToolStripMenuItem.Text = "x_direct..."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(635, 356)
        Me.SplitContainer1.SplitterDistance = 121
        Me.SplitContainer1.TabIndex = 1
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Label_Docs)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.DataGridView_Documents)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Button_getUrl)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.TextBox_Url)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Label_Url)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(631, 202)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.LeftToolStripPanelVisible = False
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.RightToolStripPanelVisible = False
        Me.ToolStripContainer2.Size = New System.Drawing.Size(631, 227)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'Label_Docs
        '
        Me.Label_Docs.AutoSize = True
        Me.Label_Docs.Location = New System.Drawing.Point(6, 33)
        Me.Label_Docs.Name = "Label_Docs"
        Me.Label_Docs.Size = New System.Drawing.Size(46, 13)
        Me.Label_Docs.TabIndex = 4
        Me.Label_Docs.Text = "x_Docs:"
        '
        'DataGridView_Documents
        '
        Me.DataGridView_Documents.AllowUserToAddRows = False
        Me.DataGridView_Documents.AllowUserToDeleteRows = False
        Me.DataGridView_Documents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Documents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Documents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Documents.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_Documents.Location = New System.Drawing.Point(58, 33)
        Me.DataGridView_Documents.Name = "DataGridView_Documents"
        Me.DataGridView_Documents.ReadOnly = True
        Me.DataGridView_Documents.Size = New System.Drawing.Size(569, 166)
        Me.DataGridView_Documents.TabIndex = 3
        '
        'Button_getUrl
        '
        Me.Button_getUrl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_getUrl.Location = New System.Drawing.Point(600, 2)
        Me.Button_getUrl.Name = "Button_getUrl"
        Me.Button_getUrl.Size = New System.Drawing.Size(27, 23)
        Me.Button_getUrl.TabIndex = 2
        Me.Button_getUrl.Text = "..."
        Me.Button_getUrl.UseVisualStyleBackColor = True
        '
        'TextBox_Url
        '
        Me.TextBox_Url.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Url.Location = New System.Drawing.Point(58, 4)
        Me.TextBox_Url.Name = "TextBox_Url"
        Me.TextBox_Url.ReadOnly = True
        Me.TextBox_Url.Size = New System.Drawing.Size(536, 20)
        Me.TextBox_Url.TabIndex = 1
        '
        'Label_Url
        '
        Me.Label_Url.AutoSize = True
        Me.Label_Url.Location = New System.Drawing.Point(3, 7)
        Me.Label_Url.Name = "Label_Url"
        Me.Label_Url.Size = New System.Drawing.Size(34, 13)
        Me.Label_Url.TabIndex = 0
        Me.Label_Url.Text = "x_Url:"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.CheckOnClick = True
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AllToolStripMenuItem.Text = "x_All"
        '
        'UserControl_WikiImplementation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_WikiImplementation"
        Me.Size = New System.Drawing.Size(635, 406)
        CType(Me.BindingSource_Wikidocs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        CType(Me.DataGridView_Documents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource_Wikidocs As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSplitButton_Export As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ExportXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents Label_Docs As System.Windows.Forms.Label
    Friend WithEvents DataGridView_Documents As System.Windows.Forms.DataGridView
    Friend WithEvents Button_getUrl As System.Windows.Forms.Button
    Friend WithEvents TextBox_Url As System.Windows.Forms.TextBox
    Friend WithEvents Label_Url As System.Windows.Forms.Label
    Friend WithEvents AllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
