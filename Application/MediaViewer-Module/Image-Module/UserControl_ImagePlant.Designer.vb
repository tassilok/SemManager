<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_ImagePlant
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
        Me.ToolStripButton_ToList = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.DataGridView_PlantsOfImage = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_NoPlants = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_FromList = New System.Windows.Forms.ToolStripButton()
        Me.BindingSource_ImageObjects = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.RightToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.DataGridView_PlantsOfImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.BindingSource_ImageObjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripButton_ToList
        '
        Me.ToolStripButton_ToList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_ToList.Enabled = False
        Me.ToolStripButton_ToList.Image = Global.MediaViewer_Module.My.Resources.Resources.pulsante_01_architetto_f_01
        Me.ToolStripButton_ToList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ToList.Name = "ToolStripButton_ToList"
        Me.ToolStripButton_ToList.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_ToList.Text = "ToolStripButton1"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(473, 487)
        Me.SplitContainer1.SplitterDistance = 233
        Me.SplitContainer1.TabIndex = 1
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_PlantsOfImage)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(197, 483)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.RightToolStripPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.Size = New System.Drawing.Size(229, 483)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'DataGridView_PlantsOfImage
        '
        Me.DataGridView_PlantsOfImage.AllowUserToAddRows = False
        Me.DataGridView_PlantsOfImage.AllowUserToDeleteRows = False
        Me.DataGridView_PlantsOfImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_PlantsOfImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_PlantsOfImage.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_PlantsOfImage.Name = "DataGridView_PlantsOfImage"
        Me.DataGridView_PlantsOfImage.ReadOnly = True
        Me.DataGridView_PlantsOfImage.Size = New System.Drawing.Size(197, 483)
        Me.DataGridView_PlantsOfImage.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_NoPlants, Me.ToolStripSeparator1, Me.ToolStripButton_ToList, Me.ToolStripButton_FromList})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(32, 105)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_NoPlants
        '
        Me.ToolStripButton_NoPlants.CheckOnClick = True
        Me.ToolStripButton_NoPlants.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_NoPlants.Image = Global.MediaViewer_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_NoPlants.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_NoPlants.Name = "ToolStripButton_NoPlants"
        Me.ToolStripButton_NoPlants.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_NoPlants.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(30, 6)
        '
        'ToolStripButton_FromList
        '
        Me.ToolStripButton_FromList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_FromList.Enabled = False
        Me.ToolStripButton_FromList.Image = Global.MediaViewer_Module.My.Resources.Resources.pulsante_02_architetto_f_01
        Me.ToolStripButton_FromList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_FromList.Name = "ToolStripButton_FromList"
        Me.ToolStripButton_FromList.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_FromList.Text = "ToolStripButton2"
        '
        'UserControl_ImagePlant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_ImagePlant"
        Me.Size = New System.Drawing.Size(473, 487)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.RightToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.RightToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.DataGridView_PlantsOfImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.BindingSource_ImageObjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripButton_ToList As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents DataGridView_PlantsOfImage As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_NoPlants As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_FromList As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingSource_ImageObjects As System.Windows.Forms.BindingSource

End Class
