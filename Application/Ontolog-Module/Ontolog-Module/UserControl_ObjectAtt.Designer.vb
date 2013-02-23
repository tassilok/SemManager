<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_ObjectAtt
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
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Count = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_FilterLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Filter = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton_ClearFilter = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView_ObjectAtt = New System.Windows.Forms.DataGridView()
        Me.BindingSource_ObjectAtt = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer_ObjectAtt = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.DataGridView_ObjectAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_ObjectAtt, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_ObjectAtt)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(521, 429)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(521, 479)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountLBL, Me.ToolStripLabel_Count})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(75, 25)
        Me.ToolStrip1.TabIndex = 0
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
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_FilterLBL, Me.ToolStripLabel_Filter, Me.ToolStripButton_ClearFilter})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(91, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_FilterLBL
        '
        Me.ToolStripLabel_FilterLBL.Name = "ToolStripLabel_FilterLBL"
        Me.ToolStripLabel_FilterLBL.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel_FilterLBL.Text = "x_Filter:"
        '
        'ToolStripLabel_Filter
        '
        Me.ToolStripLabel_Filter.Name = "ToolStripLabel_Filter"
        Me.ToolStripLabel_Filter.Size = New System.Drawing.Size(11, 22)
        Me.ToolStripLabel_Filter.Text = "-"
        '
        'ToolStripButton_ClearFilter
        '
        Me.ToolStripButton_ClearFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_ClearFilter.Image = Global.Ontolog_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_ClearFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ClearFilter.Name = "ToolStripButton_ClearFilter"
        Me.ToolStripButton_ClearFilter.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_ClearFilter.Text = "ToolStripButton1"
        '
        'DataGridView_ObjectAtt
        '
        Me.DataGridView_ObjectAtt.AllowUserToAddRows = False
        Me.DataGridView_ObjectAtt.AllowUserToDeleteRows = False
        Me.DataGridView_ObjectAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ObjectAtt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_ObjectAtt.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_ObjectAtt.Name = "DataGridView_ObjectAtt"
        Me.DataGridView_ObjectAtt.ReadOnly = True
        Me.DataGridView_ObjectAtt.Size = New System.Drawing.Size(521, 429)
        Me.DataGridView_ObjectAtt.TabIndex = 0
        '
        'Timer_ObjectAtt
        '
        Me.Timer_ObjectAtt.Interval = 300
        '
        'UserControl_ObjectAtt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_ObjectAtt"
        Me.Size = New System.Drawing.Size(521, 479)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.DataGridView_ObjectAtt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_ObjectAtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Count As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_FilterLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_ObjectAtt As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripLabel_Filter As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton_ClearFilter As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingSource_ObjectAtt As System.Windows.Forms.BindingSource
    Friend WithEvents Timer_ObjectAtt As System.Windows.Forms.Timer

End Class
