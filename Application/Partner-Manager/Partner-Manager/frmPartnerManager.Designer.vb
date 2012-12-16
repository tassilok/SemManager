<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartnerManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartnerManager))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Address = New System.Windows.Forms.TabPage()
        Me.TabPage_PersonalData = New System.Windows.Forms.TabPage()
        Me.TabPage_ComData = New System.Windows.Forms.TabPage()
        Me.TabPage_Availability = New System.Windows.Forms.TabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_ShowAddress = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(534, 428)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(534, 478)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Close})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(61, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Close
        '
        Me.ToolStripButton_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Close.Image = CType(resources.GetObject("ToolStripButton_Close.Image"), System.Drawing.Image)
        Me.ToolStripButton_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
        Me.ToolStripButton_Close.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton_Close.Text = "Close_f"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(534, 428)
        Me.SplitContainer1.SplitterDistance = 178
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Address)
        Me.TabControl1.Controls.Add(Me.TabPage_PersonalData)
        Me.TabControl1.Controls.Add(Me.TabPage_ComData)
        Me.TabControl1.Controls.Add(Me.TabPage_Availability)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(348, 424)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Address
        '
        Me.TabPage_Address.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Address.Name = "TabPage_Address"
        Me.TabPage_Address.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Address.Size = New System.Drawing.Size(340, 398)
        Me.TabPage_Address.TabIndex = 0
        Me.TabPage_Address.Text = "Addresse_f"
        Me.TabPage_Address.UseVisualStyleBackColor = True
        '
        'TabPage_PersonalData
        '
        Me.TabPage_PersonalData.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_PersonalData.Name = "TabPage_PersonalData"
        Me.TabPage_PersonalData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_PersonalData.Size = New System.Drawing.Size(340, 398)
        Me.TabPage_PersonalData.TabIndex = 1
        Me.TabPage_PersonalData.Text = "x_Peronal Data"
        Me.TabPage_PersonalData.UseVisualStyleBackColor = True
        '
        'TabPage_ComData
        '
        Me.TabPage_ComData.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ComData.Name = "TabPage_ComData"
        Me.TabPage_ComData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ComData.Size = New System.Drawing.Size(340, 398)
        Me.TabPage_ComData.TabIndex = 2
        Me.TabPage_ComData.Text = "x_Comunication-Data"
        Me.TabPage_ComData.UseVisualStyleBackColor = True
        '
        'TabPage_Availability
        '
        Me.TabPage_Availability.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Availability.Name = "TabPage_Availability"
        Me.TabPage_Availability.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Availability.Size = New System.Drawing.Size(340, 398)
        Me.TabPage_Availability.TabIndex = 3
        Me.TabPage_Availability.Text = "x_Availability-Data"
        Me.TabPage_Availability.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_ShowAddress})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(106, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripButton_ShowAddress
        '
        Me.ToolStripButton_ShowAddress.CheckOnClick = True
        Me.ToolStripButton_ShowAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_ShowAddress.Image = CType(resources.GetObject("ToolStripButton_ShowAddress.Image"), System.Drawing.Image)
        Me.ToolStripButton_ShowAddress.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ShowAddress.Name = "ToolStripButton_ShowAddress"
        Me.ToolStripButton_ShowAddress.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripButton_ShowAddress.Text = "Show Address_f"
        '
        'frmPartnerManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 478)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPartnerManager"
        Me.Text = "x-Partner-Module"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_ShowAddress As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Address As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_PersonalData As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_ComData As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Availability As System.Windows.Forms.TabPage

End Class
