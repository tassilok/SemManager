﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_ImageLandscape
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
        Me.DataGridView_ImageLandscapes = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_NoLandscape = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_ToList = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_FromList = New System.Windows.Forms.ToolStripButton()
        Me.BindingSource_ImageObjects = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.RightToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.DataGridView_ImageLandscapes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.BindingSource_ImageObjects, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(485, 451)
        Me.SplitContainer1.SplitterDistance = 237
        Me.SplitContainer1.TabIndex = 3
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_ImageLandscapes)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(201, 447)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.RightToolStripPanel.Controls.Add(Me.ToolStrip2)
        Me.ToolStripContainer1.Size = New System.Drawing.Size(233, 447)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'DataGridView_ImageLandscapes
        '
        Me.DataGridView_ImageLandscapes.AllowUserToAddRows = False
        Me.DataGridView_ImageLandscapes.AllowUserToDeleteRows = False
        Me.DataGridView_ImageLandscapes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ImageLandscapes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_ImageLandscapes.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_ImageLandscapes.Name = "DataGridView_ImageLandscapes"
        Me.DataGridView_ImageLandscapes.ReadOnly = True
        Me.DataGridView_ImageLandscapes.Size = New System.Drawing.Size(201, 447)
        Me.DataGridView_ImageLandscapes.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_NoLandscape, Me.ToolStripSeparator1, Me.ToolStripButton_ToList, Me.ToolStripButton_FromList})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 5)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(32, 105)
        Me.ToolStrip2.TabIndex = 1
        '
        'ToolStripButton_NoLandscape
        '
        Me.ToolStripButton_NoLandscape.CheckOnClick = True
        Me.ToolStripButton_NoLandscape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_NoLandscape.Image = Global.MediaViewer_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_NoLandscape.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_NoLandscape.Name = "ToolStripButton_NoLandscape"
        Me.ToolStripButton_NoLandscape.Size = New System.Drawing.Size(30, 20)
        Me.ToolStripButton_NoLandscape.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(30, 6)
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
        'UserControl_ImageLandscape
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_ImageLandscape"
        Me.Size = New System.Drawing.Size(485, 451)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.RightToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.RightToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.DataGridView_ImageLandscapes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.BindingSource_ImageObjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents DataGridView_ImageLandscapes As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_ImageObjects As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_NoLandscape As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_ToList As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_FromList As System.Windows.Forms.ToolStripButton

End Class
