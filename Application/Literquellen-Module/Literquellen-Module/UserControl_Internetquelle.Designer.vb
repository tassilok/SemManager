<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Internetquelle
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
        Me.ToolStripProgressBar_Data = New System.Windows.Forms.ToolStripProgressBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Data = New System.Windows.Forms.TabPage()
        Me.Panel_Begriffe = New System.Windows.Forms.Panel()
        Me.TextBox_URL = New System.Windows.Forms.TextBox()
        Me.Label_Partner = New System.Windows.Forms.Label()
        Me.Button_AddPartner = New System.Windows.Forms.Button()
        Me.TextBox_Partner = New System.Windows.Forms.TextBox()
        Me.Label_DownloadTimstamp = New System.Windows.Forms.Label()
        Me.DateTimePicker_Download = New System.Windows.Forms.DateTimePicker()
        Me.Button_AddURL = New System.Windows.Forms.Button()
        Me.Label_URL = New System.Windows.Forms.Label()
        Me.TabPage_PDF = New System.Windows.Forms.TabPage()
        Me.Timer_getData = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Data.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(385, 355)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(385, 405)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar_Data})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(111, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripProgressBar_Data
        '
        Me.ToolStripProgressBar_Data.Maximum = 3
        Me.ToolStripProgressBar_Data.Name = "ToolStripProgressBar_Data"
        Me.ToolStripProgressBar_Data.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripProgressBar_Data.Step = 1
        Me.ToolStripProgressBar_Data.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Data)
        Me.TabControl1.Controls.Add(Me.TabPage_PDF)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(385, 355)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Data
        '
        Me.TabPage_Data.Controls.Add(Me.Panel_Begriffe)
        Me.TabPage_Data.Controls.Add(Me.TextBox_URL)
        Me.TabPage_Data.Controls.Add(Me.Label_Partner)
        Me.TabPage_Data.Controls.Add(Me.Button_AddPartner)
        Me.TabPage_Data.Controls.Add(Me.TextBox_Partner)
        Me.TabPage_Data.Controls.Add(Me.Label_DownloadTimstamp)
        Me.TabPage_Data.Controls.Add(Me.DateTimePicker_Download)
        Me.TabPage_Data.Controls.Add(Me.Button_AddURL)
        Me.TabPage_Data.Controls.Add(Me.Label_URL)
        Me.TabPage_Data.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Data.Name = "TabPage_Data"
        Me.TabPage_Data.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Data.Size = New System.Drawing.Size(377, 329)
        Me.TabPage_Data.TabIndex = 0
        Me.TabPage_Data.Text = "x_Quelldaten"
        Me.TabPage_Data.UseVisualStyleBackColor = True
        '
        'Panel_Begriffe
        '
        Me.Panel_Begriffe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Begriffe.Location = New System.Drawing.Point(82, 87)
        Me.Panel_Begriffe.Name = "Panel_Begriffe"
        Me.Panel_Begriffe.Size = New System.Drawing.Size(252, 236)
        Me.Panel_Begriffe.TabIndex = 10
        '
        'TextBox_URL
        '
        Me.TextBox_URL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_URL.Location = New System.Drawing.Point(82, 5)
        Me.TextBox_URL.Name = "TextBox_URL"
        Me.TextBox_URL.ReadOnly = True
        Me.TextBox_URL.Size = New System.Drawing.Size(252, 20)
        Me.TextBox_URL.TabIndex = 9
        '
        'Label_Partner
        '
        Me.Label_Partner.AutoSize = True
        Me.Label_Partner.Location = New System.Drawing.Point(7, 62)
        Me.Label_Partner.Name = "Label_Partner"
        Me.Label_Partner.Size = New System.Drawing.Size(58, 13)
        Me.Label_Partner.TabIndex = 8
        Me.Label_Partner.Text = "x_Ersteller:"
        '
        'Button_AddPartner
        '
        Me.Button_AddPartner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_AddPartner.Location = New System.Drawing.Point(340, 58)
        Me.Button_AddPartner.Name = "Button_AddPartner"
        Me.Button_AddPartner.Size = New System.Drawing.Size(31, 23)
        Me.Button_AddPartner.TabIndex = 7
        Me.Button_AddPartner.Text = "..."
        Me.Button_AddPartner.UseVisualStyleBackColor = True
        '
        'TextBox_Partner
        '
        Me.TextBox_Partner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Partner.Location = New System.Drawing.Point(82, 60)
        Me.TextBox_Partner.Name = "TextBox_Partner"
        Me.TextBox_Partner.ReadOnly = True
        Me.TextBox_Partner.Size = New System.Drawing.Size(252, 20)
        Me.TextBox_Partner.TabIndex = 6
        '
        'Label_DownloadTimstamp
        '
        Me.Label_DownloadTimstamp.AutoSize = True
        Me.Label_DownloadTimstamp.Location = New System.Drawing.Point(7, 36)
        Me.Label_DownloadTimstamp.Name = "Label_DownloadTimstamp"
        Me.Label_DownloadTimstamp.Size = New System.Drawing.Size(69, 13)
        Me.Label_DownloadTimstamp.TabIndex = 5
        Me.Label_DownloadTimstamp.Text = "x_Download:"
        '
        'DateTimePicker_Download
        '
        Me.DateTimePicker_Download.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_Download.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        Me.DateTimePicker_Download.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Download.Location = New System.Drawing.Point(82, 33)
        Me.DateTimePicker_Download.Name = "DateTimePicker_Download"
        Me.DateTimePicker_Download.Size = New System.Drawing.Size(252, 20)
        Me.DateTimePicker_Download.TabIndex = 4
        '
        'Button_AddURL
        '
        Me.Button_AddURL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_AddURL.Location = New System.Drawing.Point(340, 4)
        Me.Button_AddURL.Name = "Button_AddURL"
        Me.Button_AddURL.Size = New System.Drawing.Size(31, 23)
        Me.Button_AddURL.TabIndex = 2
        Me.Button_AddURL.Text = "..."
        Me.Button_AddURL.UseVisualStyleBackColor = True
        '
        'Label_URL
        '
        Me.Label_URL.AutoSize = True
        Me.Label_URL.Location = New System.Drawing.Point(7, 8)
        Me.Label_URL.Name = "Label_URL"
        Me.Label_URL.Size = New System.Drawing.Size(43, 13)
        Me.Label_URL.TabIndex = 0
        Me.Label_URL.Text = "x_URL:"
        '
        'TabPage_PDF
        '
        Me.TabPage_PDF.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_PDF.Name = "TabPage_PDF"
        Me.TabPage_PDF.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_PDF.Size = New System.Drawing.Size(377, 329)
        Me.TabPage_PDF.TabIndex = 1
        Me.TabPage_PDF.Text = "x_PDF"
        Me.TabPage_PDF.UseVisualStyleBackColor = True
        '
        'Timer_getData
        '
        Me.Timer_getData.Interval = 300
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList_Main.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent
        '
        'UserControl_Internetquelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_Internetquelle"
        Me.Size = New System.Drawing.Size(385, 405)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Data.ResumeLayout(False)
        Me.TabPage_Data.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripProgressBar_Data As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Data As System.Windows.Forms.TabPage
    Friend WithEvents Button_AddURL As System.Windows.Forms.Button
    Friend WithEvents Label_URL As System.Windows.Forms.Label
    Friend WithEvents TabPage_PDF As System.Windows.Forms.TabPage
    Friend WithEvents Timer_getData As System.Windows.Forms.Timer
    Friend WithEvents ImageList_Main As System.Windows.Forms.ImageList
    Friend WithEvents Panel_Begriffe As System.Windows.Forms.Panel
    Friend WithEvents TextBox_URL As System.Windows.Forms.TextBox
    Friend WithEvents Label_Partner As System.Windows.Forms.Label
    Friend WithEvents Button_AddPartner As System.Windows.Forms.Button
    Friend WithEvents TextBox_Partner As System.Windows.Forms.TextBox
    Friend WithEvents Label_DownloadTimstamp As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_Download As System.Windows.Forms.DateTimePicker

End Class
