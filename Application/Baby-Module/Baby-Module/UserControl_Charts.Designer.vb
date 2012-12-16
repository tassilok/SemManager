<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Charts
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ReportViewer_Baby = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsBabyModule = New Baby_Module.dsBabyModule()
        Me.proc_Mengen_Of_Day_By_EinheitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.proc_Mengen_Of_Day_By_EinheitTableAdapter = New Baby_Module.dsBabyModuleTableAdapters.proc_Mengen_Of_Day_By_EinheitTableAdapter()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.dsBabyModule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.proc_Mengen_Of_Day_By_EinheitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ReportViewer_Baby)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(548, 423)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(548, 448)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ReportViewer_Baby
        '
        Me.ReportViewer_Baby.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet_Nahrung"
        ReportDataSource1.Value = Me.proc_Mengen_Of_Day_By_EinheitBindingSource
        Me.ReportViewer_Baby.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer_Baby.LocalReport.ReportEmbeddedResource = "Baby_Module.Report_Nahrung.rdlc"
        Me.ReportViewer_Baby.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer_Baby.Name = "ReportViewer_Baby"
        Me.ReportViewer_Baby.Size = New System.Drawing.Size(548, 423)
        Me.ReportViewer_Baby.TabIndex = 0
        Me.ReportViewer_Baby.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        '
        'dsBabyModule
        '
        Me.dsBabyModule.DataSetName = "dsBabyModule"
        Me.dsBabyModule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'proc_Mengen_Of_Day_By_EinheitBindingSource
        '
        Me.proc_Mengen_Of_Day_By_EinheitBindingSource.DataMember = "proc_Mengen_Of_Day_By_Einheit"
        Me.proc_Mengen_Of_Day_By_EinheitBindingSource.DataSource = Me.dsBabyModule
        '
        'proc_Mengen_Of_Day_By_EinheitTableAdapter
        '
        Me.proc_Mengen_Of_Day_By_EinheitTableAdapter.ClearBeforeFill = True
        '
        'UserControl_Charts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_Charts"
        Me.Size = New System.Drawing.Size(548, 448)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.dsBabyModule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.proc_Mengen_Of_Day_By_EinheitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ReportViewer_Baby As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents proc_Mengen_Of_Day_By_EinheitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsBabyModule As Baby_Module.dsBabyModule
    Friend WithEvents proc_Mengen_Of_Day_By_EinheitTableAdapter As Baby_Module.dsBabyModuleTableAdapters.proc_Mengen_Of_Day_By_EinheitTableAdapter

End Class
