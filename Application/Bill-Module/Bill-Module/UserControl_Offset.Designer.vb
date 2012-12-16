<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Offset
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
        Me.ToolStripLabel_ItemCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_SumLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Sum = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView_Offset = New System.Windows.Forms.DataGridView()
        Me.BindingSource_Offset = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel_Calc = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_Offset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Offset, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_Offset)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(429, 329)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(429, 379)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountLBL, Me.ToolStripLabel_ItemCount, Me.ToolStripSeparator1, Me.ToolStripLabel_SumLBL, Me.ToolStripLabel_Sum, Me.ToolStripLabel_Calc})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(167, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_CountLBL
        '
        Me.ToolStripLabel_CountLBL.Name = "ToolStripLabel_CountLBL"
        Me.ToolStripLabel_CountLBL.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel_CountLBL.Text = "x_Items:"
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
        'ToolStripLabel_SumLBL
        '
        Me.ToolStripLabel_SumLBL.Name = "ToolStripLabel_SumLBL"
        Me.ToolStripLabel_SumLBL.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLabel_SumLBL.Text = "x_Summe:"
        '
        'ToolStripLabel_Sum
        '
        Me.ToolStripLabel_Sum.Name = "ToolStripLabel_Sum"
        Me.ToolStripLabel_Sum.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Sum.Text = "0"
        '
        'DataGridView_Offset
        '
        Me.DataGridView_Offset.AllowUserToAddRows = False
        Me.DataGridView_Offset.AllowUserToDeleteRows = False
        Me.DataGridView_Offset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Offset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Offset.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Offset.Name = "DataGridView_Offset"
        Me.DataGridView_Offset.ReadOnly = True
        Me.DataGridView_Offset.Size = New System.Drawing.Size(429, 329)
        Me.DataGridView_Offset.TabIndex = 0
        '
        'ToolStripLabel_Calc
        '
        Me.ToolStripLabel_Calc.Name = "ToolStripLabel_Calc"
        Me.ToolStripLabel_Calc.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Calc.Text = "0"
        '
        'UserControl_Offset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_Offset"
        Me.Size = New System.Drawing.Size(429, 379)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_Offset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Offset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_ItemCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_Offset As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_Offset As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_SumLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Sum As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Calc As System.Windows.Forms.ToolStripLabel

End Class
