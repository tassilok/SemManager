<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_PDFViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_PDFViewer))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_MoveFirst = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MovePrevious = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MoveNext = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MoveLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Replace = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Edit = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog_PDF = New System.Windows.Forms.OpenFileDialog()
        Me.AxFoxitCtl_Main = New AxFOXITREADERLib.AxFoxitCtl()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.AxFoxitCtl_Main, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(514, 418)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(514, 468)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_MoveFirst, Me.ToolStripButton_MovePrevious, Me.ToolStripButton_MoveNext, Me.ToolStripButton_MoveLast, Me.ToolStripSeparator1, Me.ToolStripButton_Delete})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(203, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_MoveFirst
        '
        Me.ToolStripButton_MoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MoveFirst.Enabled = False
        Me.ToolStripButton_MoveFirst.Image = Global.MediaViewer_Module.My.Resources.Resources.pulsante_01_architetto_f_01_First
        Me.ToolStripButton_MoveFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MoveFirst.Name = "ToolStripButton_MoveFirst"
        Me.ToolStripButton_MoveFirst.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MoveFirst.Text = "ToolStripButton1"
        '
        'ToolStripButton_MovePrevious
        '
        Me.ToolStripButton_MovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MovePrevious.Enabled = False
        Me.ToolStripButton_MovePrevious.Image = Global.MediaViewer_Module.My.Resources.Resources.pulsante_01_architetto_f_01
        Me.ToolStripButton_MovePrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MovePrevious.Name = "ToolStripButton_MovePrevious"
        Me.ToolStripButton_MovePrevious.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MovePrevious.Text = "ToolStripButton2"
        '
        'ToolStripButton_MoveNext
        '
        Me.ToolStripButton_MoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MoveNext.Enabled = False
        Me.ToolStripButton_MoveNext.Image = Global.MediaViewer_Module.My.Resources.Resources.pulsante_02_architetto_f_01
        Me.ToolStripButton_MoveNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MoveNext.Name = "ToolStripButton_MoveNext"
        Me.ToolStripButton_MoveNext.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MoveNext.Text = "ToolStripButton3"
        '
        'ToolStripButton_MoveLast
        '
        Me.ToolStripButton_MoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MoveLast.Enabled = False
        Me.ToolStripButton_MoveLast.Image = Global.MediaViewer_Module.My.Resources.Resources.pulsante_02_architetto_f_01_Last
        Me.ToolStripButton_MoveLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MoveLast.Name = "ToolStripButton_MoveLast"
        Me.ToolStripButton_MoveLast.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MoveLast.Text = "ToolStripButton4"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Delete
        '
        Me.ToolStripButton_Delete.Enabled = False
        Me.ToolStripButton_Delete.Image = Global.MediaViewer_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
        Me.ToolStripButton_Delete.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripButton_Delete.Text = "x_delete PDF"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.AxFoxitCtl_Main)
        Me.SplitContainer1.Size = New System.Drawing.Size(514, 418)
        Me.SplitContainer1.SplitterDistance = 290
        Me.SplitContainer1.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Add, Me.ToolStripSeparator2, Me.ToolStripButton_Replace, Me.ToolStripSeparator3, Me.ToolStripButton_Edit})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(150, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripButton_Add
        '
        Me.ToolStripButton_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Add.Image = Global.MediaViewer_Module.My.Resources.Resources.b_plus_with_Folder
        Me.ToolStripButton_Add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Add.Name = "ToolStripButton_Add"
        Me.ToolStripButton_Add.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Add.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Replace
        '
        Me.ToolStripButton_Replace.CheckOnClick = True
        Me.ToolStripButton_Replace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Replace.Image = CType(resources.GetObject("ToolStripButton_Replace.Image"), System.Drawing.Image)
        Me.ToolStripButton_Replace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Replace.Name = "ToolStripButton_Replace"
        Me.ToolStripButton_Replace.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton_Replace.Text = "x_Replace"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_Edit
        '
        Me.ToolStripButton_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Edit.Image = CType(resources.GetObject("ToolStripButton_Edit.Image"), System.Drawing.Image)
        Me.ToolStripButton_Edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Edit.Name = "ToolStripButton_Edit"
        Me.ToolStripButton_Edit.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripButton_Edit.Text = "x_Edit"
        '
        'OpenFileDialog_PDF
        '
        Me.OpenFileDialog_PDF.Filter = "PDF-Dateien|*.pdf"
        Me.OpenFileDialog_PDF.Multiselect = True
        '
        'AxFoxitCtl_Main
        '
        Me.AxFoxitCtl_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxFoxitCtl_Main.Enabled = True
        Me.AxFoxitCtl_Main.Location = New System.Drawing.Point(0, 0)
        Me.AxFoxitCtl_Main.Name = "AxFoxitCtl_Main"
        Me.AxFoxitCtl_Main.OcxState = CType(resources.GetObject("AxFoxitCtl_Main.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxFoxitCtl_Main.Size = New System.Drawing.Size(286, 414)
        Me.AxFoxitCtl_Main.TabIndex = 0
        '
        'UserControl_PDFViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_PDFViewer"
        Me.Size = New System.Drawing.Size(514, 468)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.AxFoxitCtl_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_MoveFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MovePrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MoveNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MoveLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Add As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer

    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Replace As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog_PDF As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_Edit As System.Windows.Forms.ToolStripButton
    Friend WithEvents AxFoxitCtl_Main As AxFOXITREADERLib.AxFoxitCtl

End Class
