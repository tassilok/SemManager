<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlobWatcher
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            objFlagStream.Close()
        Catch ex As Exception

        End Try

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlobWatcher))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView_BlobWatcher = New System.Windows.Forms.DataGridView()
        Me.BindingSource_BlobWatcher = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotifyIcon_Blob = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip_Notify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileSystemWatcher_BlobDir = New System.IO.FileSystemWatcher()
        Me.Timer_BlobSave = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_BlobWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_BlobWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_Notify.SuspendLayout()
        CType(Me.FileSystemWatcher_BlobDir, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_BlobWatcher)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(452, 300)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(452, 325)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
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
        'DataGridView_BlobWatcher
        '
        Me.DataGridView_BlobWatcher.AllowUserToAddRows = False
        Me.DataGridView_BlobWatcher.AllowUserToDeleteRows = False
        Me.DataGridView_BlobWatcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_BlobWatcher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_BlobWatcher.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_BlobWatcher.Name = "DataGridView_BlobWatcher"
        Me.DataGridView_BlobWatcher.ReadOnly = True
        Me.DataGridView_BlobWatcher.Size = New System.Drawing.Size(452, 300)
        Me.DataGridView_BlobWatcher.TabIndex = 0
        '
        'NotifyIcon_Blob
        '
        Me.NotifyIcon_Blob.ContextMenuStrip = Me.ContextMenuStrip_Notify
        Me.NotifyIcon_Blob.Icon = CType(resources.GetObject("NotifyIcon_Blob.Icon"), System.Drawing.Icon)
        Me.NotifyIcon_Blob.Text = "x_Blob-Management"
        Me.NotifyIcon_Blob.Visible = True
        '
        'ContextMenuStrip_Notify
        '
        Me.ContextMenuStrip_Notify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip_Notify.Name = "ContextMenuStrip_Notify"
        Me.ContextMenuStrip_Notify.Size = New System.Drawing.Size(114, 26)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.CloseToolStripMenuItem.Text = "x_Close"
        '
        'FileSystemWatcher_BlobDir
        '
        Me.FileSystemWatcher_BlobDir.EnableRaisingEvents = True
        Me.FileSystemWatcher_BlobDir.SynchronizingObject = Me
        '
        'Timer_BlobSave
        '
        Me.Timer_BlobSave.Interval = 500
        '
        'frmBlobWatcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 325)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBlobWatcher"
        Me.ShowInTaskbar = False
        Me.Text = "frmBlobWatcher"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_BlobWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_BlobWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_Notify.ResumeLayout(False)
        CType(Me.FileSystemWatcher_BlobDir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView_BlobWatcher As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_BlobWatcher As System.Windows.Forms.BindingSource
    Friend WithEvents NotifyIcon_Blob As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip_Notify As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileSystemWatcher_BlobDir As System.IO.FileSystemWatcher
    Friend WithEvents Timer_BlobSave As System.Windows.Forms.Timer
End Class
