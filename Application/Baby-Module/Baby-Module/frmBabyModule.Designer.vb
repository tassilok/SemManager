<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBabyModule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBabyModule))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Gewicht = New System.Windows.Forms.TabPage()
        Me.TabPage_Trinken = New System.Windows.Forms.TabPage()
        Me.TabPage_Kopfumfang = New System.Windows.Forms.TabPage()
        Me.TabPage_Koerpergroesse = New System.Windows.Forms.TabPage()
        Me.TabPage_Graph = New System.Windows.Forms.TabPage()
        Me.BindingSource_Partner = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.BindingSource_Partner, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(736, 370)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(736, 420)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(736, 370)
        Me.SplitContainer1.SplitterDistance = 163
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(159, 341)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(159, 366)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Gewicht)
        Me.TabControl1.Controls.Add(Me.TabPage_Trinken)
        Me.TabControl1.Controls.Add(Me.TabPage_Kopfumfang)
        Me.TabControl1.Controls.Add(Me.TabPage_Koerpergroesse)
        Me.TabControl1.Controls.Add(Me.TabPage_Graph)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(565, 366)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Gewicht
        '
        Me.TabPage_Gewicht.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Gewicht.Name = "TabPage_Gewicht"
        Me.TabPage_Gewicht.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Gewicht.Size = New System.Drawing.Size(557, 340)
        Me.TabPage_Gewicht.TabIndex = 0
        Me.TabPage_Gewicht.Text = "x_Gewicht"
        Me.TabPage_Gewicht.UseVisualStyleBackColor = True
        '
        'TabPage_Trinken
        '
        Me.TabPage_Trinken.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Trinken.Name = "TabPage_Trinken"
        Me.TabPage_Trinken.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Trinken.Size = New System.Drawing.Size(475, 340)
        Me.TabPage_Trinken.TabIndex = 1
        Me.TabPage_Trinken.Text = "x_Trinken"
        Me.TabPage_Trinken.UseVisualStyleBackColor = True
        '
        'TabPage_Kopfumfang
        '
        Me.TabPage_Kopfumfang.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Kopfumfang.Name = "TabPage_Kopfumfang"
        Me.TabPage_Kopfumfang.Size = New System.Drawing.Size(475, 340)
        Me.TabPage_Kopfumfang.TabIndex = 2
        Me.TabPage_Kopfumfang.Text = "x_Kopfumfang"
        Me.TabPage_Kopfumfang.UseVisualStyleBackColor = True
        '
        'TabPage_Koerpergroesse
        '
        Me.TabPage_Koerpergroesse.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Koerpergroesse.Name = "TabPage_Koerpergroesse"
        Me.TabPage_Koerpergroesse.Size = New System.Drawing.Size(475, 340)
        Me.TabPage_Koerpergroesse.TabIndex = 3
        Me.TabPage_Koerpergroesse.Text = "x_Körpergröße"
        Me.TabPage_Koerpergroesse.UseVisualStyleBackColor = True
        '
        'TabPage_Graph
        '
        Me.TabPage_Graph.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Graph.Name = "TabPage_Graph"
        Me.TabPage_Graph.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Graph.Size = New System.Drawing.Size(475, 340)
        Me.TabPage_Graph.TabIndex = 4
        Me.TabPage_Graph.Text = "x_Graph"
        Me.TabPage_Graph.UseVisualStyleBackColor = True
        '
        'frmBabyModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 420)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBabyModule"
        Me.Text = "x_Baby-Module"
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
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.BindingSource_Partner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Gewicht As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Trinken As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Kopfumfang As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Koerpergroesse As System.Windows.Forms.TabPage
    Friend WithEvents BindingSource_Partner As System.Windows.Forms.BindingSource
    Friend WithEvents TabPage_Graph As System.Windows.Forms.TabPage

End Class
