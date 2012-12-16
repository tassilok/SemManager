<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_History
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
        Me.ToolStripLabel_EntryCountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_EntryCount = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView_History = New System.Windows.Forms.DataGridView()
        Me.BindingSource_History = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer_History = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripProgressBar_History = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_History, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_History, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_History)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(421, 366)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(421, 391)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_EntryCountLBL, Me.ToolStripLabel_EntryCount, Me.ToolStripProgressBar_History})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(277, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_EntryCountLBL
        '
        Me.ToolStripLabel_EntryCountLBL.Name = "ToolStripLabel_EntryCountLBL"
        Me.ToolStripLabel_EntryCountLBL.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripLabel_EntryCountLBL.Text = "x_Logentries (Count):"
        '
        'ToolStripLabel_EntryCount
        '
        Me.ToolStripLabel_EntryCount.Name = "ToolStripLabel_EntryCount"
        Me.ToolStripLabel_EntryCount.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_EntryCount.Text = "0"
        '
        'DataGridView_History
        '
        Me.DataGridView_History.AllowUserToAddRows = False
        Me.DataGridView_History.AllowUserToDeleteRows = False
        Me.DataGridView_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_History.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_History.Name = "DataGridView_History"
        Me.DataGridView_History.ReadOnly = True
        Me.DataGridView_History.Size = New System.Drawing.Size(421, 366)
        Me.DataGridView_History.TabIndex = 0
        '
        'Timer_History
        '
        Me.Timer_History.Interval = 300
        '
        'ToolStripProgressBar_History
        '
        Me.ToolStripProgressBar_History.Maximum = 10
        Me.ToolStripProgressBar_History.Name = "ToolStripProgressBar_History"
        Me.ToolStripProgressBar_History.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripProgressBar_History.Step = 1
        '
        'UserControl_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_History"
        Me.Size = New System.Drawing.Size(421, 391)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_History, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_History, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_EntryCountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_EntryCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_History As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_History As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripProgressBar_History As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Timer_History As System.Windows.Forms.Timer

End Class
