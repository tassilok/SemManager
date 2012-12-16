<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Menge = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountLBL_Menge = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Count_Menge = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView_Menge = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_New = New System.Windows.Forms.ToolStripButton()
        Me.TabPage_Flaeche = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer3 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountLBL_Flaeche = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Count_Flaeche = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView_Flaeche = New System.Windows.Forms.DataGridView()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_NewFlaeche = New System.Windows.Forms.ToolStripButton()
        Me.TabPage_Volumen = New System.Windows.Forms.TabPage()
        Me.BindingSource_Menge = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_Flaeche = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Menge.SuspendLayout()
        Me.ToolStripContainer2.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView_Menge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabPage_Flaeche.SuspendLayout()
        Me.ToolStripContainer3.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer3.ContentPanel.SuspendLayout()
        Me.ToolStripContainer3.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer3.SuspendLayout()
        Me.ToolStrip5.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView_Flaeche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip4.SuspendLayout()
        CType(Me.BindingSource_Menge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Flaeche, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(516, 333)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(516, 383)
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Menge)
        Me.TabControl1.Controls.Add(Me.TabPage_Flaeche)
        Me.TabControl1.Controls.Add(Me.TabPage_Volumen)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(516, 333)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Menge
        '
        Me.TabPage_Menge.Controls.Add(Me.ToolStripContainer2)
        Me.TabPage_Menge.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Menge.Name = "TabPage_Menge"
        Me.TabPage_Menge.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Menge.Size = New System.Drawing.Size(508, 307)
        Me.TabPage_Menge.TabIndex = 0
        Me.TabPage_Menge.Text = "x_Menge"
        Me.TabPage_Menge.UseVisualStyleBackColor = True
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.BottomToolStripPanel
        '
        Me.ToolStripContainer2.BottomToolStripPanel.Controls.Add(Me.ToolStrip3)
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(502, 251)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(502, 301)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountLBL_Menge, Me.ToolStripLabel_Count_Menge})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(78, 25)
        Me.ToolStrip3.TabIndex = 0
        '
        'ToolStripLabel_CountLBL_Menge
        '
        Me.ToolStripLabel_CountLBL_Menge.Name = "ToolStripLabel_CountLBL_Menge"
        Me.ToolStripLabel_CountLBL_Menge.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel_CountLBL_Menge.Text = "x_Count:"
        '
        'ToolStripLabel_Count_Menge
        '
        Me.ToolStripLabel_Count_Menge.Name = "ToolStripLabel_Count_Menge"
        Me.ToolStripLabel_Count_Menge.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Count_Menge.Text = "0"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView_Menge)
        Me.SplitContainer1.Size = New System.Drawing.Size(502, 251)
        Me.SplitContainer1.SplitterDistance = 167
        Me.SplitContainer1.TabIndex = 0
        '
        'DataGridView_Menge
        '
        Me.DataGridView_Menge.AllowUserToAddRows = False
        Me.DataGridView_Menge.AllowUserToDeleteRows = False
        Me.DataGridView_Menge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Menge.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Menge.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Menge.Name = "DataGridView_Menge"
        Me.DataGridView_Menge.ReadOnly = True
        Me.DataGridView_Menge.Size = New System.Drawing.Size(163, 247)
        Me.DataGridView_Menge.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_New})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(57, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripButton_New
        '
        Me.ToolStripButton_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_New.Image = CType(resources.GetObject("ToolStripButton_New.Image"), System.Drawing.Image)
        Me.ToolStripButton_New.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_New.Name = "ToolStripButton_New"
        Me.ToolStripButton_New.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripButton_New.Text = "x_New"
        '
        'TabPage_Flaeche
        '
        Me.TabPage_Flaeche.Controls.Add(Me.ToolStripContainer3)
        Me.TabPage_Flaeche.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Flaeche.Name = "TabPage_Flaeche"
        Me.TabPage_Flaeche.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Flaeche.Size = New System.Drawing.Size(508, 307)
        Me.TabPage_Flaeche.TabIndex = 1
        Me.TabPage_Flaeche.Text = "x_Flaeche"
        Me.TabPage_Flaeche.UseVisualStyleBackColor = True
        '
        'ToolStripContainer3
        '
        '
        'ToolStripContainer3.BottomToolStripPanel
        '
        Me.ToolStripContainer3.BottomToolStripPanel.Controls.Add(Me.ToolStrip5)
        '
        'ToolStripContainer3.ContentPanel
        '
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.SplitContainer2)
        Me.ToolStripContainer3.ContentPanel.Size = New System.Drawing.Size(502, 251)
        Me.ToolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer3.Name = "ToolStripContainer3"
        Me.ToolStripContainer3.Size = New System.Drawing.Size(502, 301)
        Me.ToolStripContainer3.TabIndex = 0
        Me.ToolStripContainer3.Text = "ToolStripContainer3"
        '
        'ToolStripContainer3.TopToolStripPanel
        '
        Me.ToolStripContainer3.TopToolStripPanel.Controls.Add(Me.ToolStrip4)
        '
        'ToolStrip5
        '
        Me.ToolStrip5.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountLBL_Flaeche, Me.ToolStripLabel_Count_Flaeche})
        Me.ToolStrip5.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Size = New System.Drawing.Size(78, 25)
        Me.ToolStrip5.TabIndex = 0
        '
        'ToolStripLabel_CountLBL_Flaeche
        '
        Me.ToolStripLabel_CountLBL_Flaeche.Name = "ToolStripLabel_CountLBL_Flaeche"
        Me.ToolStripLabel_CountLBL_Flaeche.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel_CountLBL_Flaeche.Text = "x_Count:"
        '
        'ToolStripLabel_Count_Flaeche
        '
        Me.ToolStripLabel_Count_Flaeche.Name = "ToolStripLabel_Count_Flaeche"
        Me.ToolStripLabel_Count_Flaeche.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Count_Flaeche.Text = "0"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DataGridView_Flaeche)
        Me.SplitContainer2.Size = New System.Drawing.Size(502, 251)
        Me.SplitContainer2.SplitterDistance = 167
        Me.SplitContainer2.TabIndex = 0
        '
        'DataGridView_Flaeche
        '
        Me.DataGridView_Flaeche.AllowUserToAddRows = False
        Me.DataGridView_Flaeche.AllowUserToDeleteRows = False
        Me.DataGridView_Flaeche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Flaeche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Flaeche.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Flaeche.Name = "DataGridView_Flaeche"
        Me.DataGridView_Flaeche.ReadOnly = True
        Me.DataGridView_Flaeche.Size = New System.Drawing.Size(163, 247)
        Me.DataGridView_Flaeche.TabIndex = 0
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_NewFlaeche})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(55, 25)
        Me.ToolStrip4.TabIndex = 0
        '
        'ToolStripButton_NewFlaeche
        '
        Me.ToolStripButton_NewFlaeche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_NewFlaeche.Image = CType(resources.GetObject("ToolStripButton_NewFlaeche.Image"), System.Drawing.Image)
        Me.ToolStripButton_NewFlaeche.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_NewFlaeche.Name = "ToolStripButton_NewFlaeche"
        Me.ToolStripButton_NewFlaeche.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripButton_NewFlaeche.Text = "x_Neu"
        '
        'TabPage_Volumen
        '
        Me.TabPage_Volumen.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Volumen.Name = "TabPage_Volumen"
        Me.TabPage_Volumen.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Volumen.Size = New System.Drawing.Size(508, 307)
        Me.TabPage_Volumen.TabIndex = 2
        Me.TabPage_Volumen.Text = "x_Volumen"
        Me.TabPage_Volumen.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 383)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Menge.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView_Menge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabPage_Flaeche.ResumeLayout(False)
        Me.ToolStripContainer3.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer3.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer3.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer3.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer3.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer3.ResumeLayout(False)
        Me.ToolStripContainer3.PerformLayout()
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView_Flaeche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        CType(Me.BindingSource_Menge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Flaeche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Menge As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_New As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView_Menge As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_Menge As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountLBL_Menge As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Count_Menge As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TabPage_Flaeche As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripContainer3 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip5 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountLBL_Flaeche As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Count_Flaeche As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView_Flaeche As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_NewFlaeche As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage_Volumen As System.Windows.Forms.TabPage
    Friend WithEvents BindingSource_Flaeche As System.Windows.Forms.BindingSource

End Class
