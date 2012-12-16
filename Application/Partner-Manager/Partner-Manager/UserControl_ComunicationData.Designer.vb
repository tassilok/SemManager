<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_ComunicationData
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
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Tel = New System.Windows.Forms.TabPage()
        Me.TabPage_Web = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label_Telephone = New System.Windows.Forms.Label()
        Me.Panel_Telephone = New System.Windows.Forms.Panel()
        Me.Label_Fax = New System.Windows.Forms.Label()
        Me.Panel_Fax = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Label_Email = New System.Windows.Forms.Label()
        Me.Label_Url = New System.Windows.Forms.Label()
        Me.Label_Webservice = New System.Windows.Forms.Label()
        Me.Panel_Email = New System.Windows.Forms.Panel()
        Me.Panel_Url = New System.Windows.Forms.Panel()
        Me.Panel_Webservice = New System.Windows.Forms.Panel()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Tel.SuspendLayout()
        Me.TabPage_Web.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(533, 443)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(533, 443)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Tel)
        Me.TabControl1.Controls.Add(Me.TabPage_Web)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(533, 443)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Tel
        '
        Me.TabPage_Tel.Controls.Add(Me.SplitContainer1)
        Me.TabPage_Tel.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Tel.Name = "TabPage_Tel"
        Me.TabPage_Tel.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Tel.Size = New System.Drawing.Size(525, 392)
        Me.TabPage_Tel.TabIndex = 0
        Me.TabPage_Tel.Text = "x_Tel/Fax"
        Me.TabPage_Tel.UseVisualStyleBackColor = True
        '
        'TabPage_Web
        '
        Me.TabPage_Web.Controls.Add(Me.SplitContainer2)
        Me.TabPage_Web.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Web.Name = "TabPage_Web"
        Me.TabPage_Web.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Web.Size = New System.Drawing.Size(525, 417)
        Me.TabPage_Web.TabIndex = 1
        Me.TabPage_Web.Text = "x_Web"
        Me.TabPage_Web.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel_Telephone)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_Telephone)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel_Fax)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label_Fax)
        Me.SplitContainer1.Size = New System.Drawing.Size(519, 386)
        Me.SplitContainer1.SplitterDistance = 191
        Me.SplitContainer1.TabIndex = 0
        '
        'Label_Telephone
        '
        Me.Label_Telephone.AutoSize = True
        Me.Label_Telephone.Location = New System.Drawing.Point(3, 3)
        Me.Label_Telephone.Name = "Label_Telephone"
        Me.Label_Telephone.Size = New System.Drawing.Size(72, 13)
        Me.Label_Telephone.TabIndex = 0
        Me.Label_Telephone.Text = "x_Telephone:"
        '
        'Panel_Telephone
        '
        Me.Panel_Telephone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Telephone.Location = New System.Drawing.Point(2, 23)
        Me.Panel_Telephone.Name = "Panel_Telephone"
        Me.Panel_Telephone.Size = New System.Drawing.Size(510, 162)
        Me.Panel_Telephone.TabIndex = 1
        '
        'Label_Fax
        '
        Me.Label_Fax.AutoSize = True
        Me.Label_Fax.Location = New System.Drawing.Point(3, 3)
        Me.Label_Fax.Name = "Label_Fax"
        Me.Label_Fax.Size = New System.Drawing.Size(38, 13)
        Me.Label_Fax.TabIndex = 0
        Me.Label_Fax.Text = "x_Fax:"
        '
        'Panel_Fax
        '
        Me.Panel_Fax.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Fax.Location = New System.Drawing.Point(3, 19)
        Me.Panel_Fax.Name = "Panel_Fax"
        Me.Panel_Fax.Size = New System.Drawing.Size(509, 165)
        Me.Panel_Fax.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel_Email)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label_Email)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(519, 411)
        Me.SplitContainer2.SplitterDistance = 139
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Panel_Url)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label_Url)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Panel_Webservice)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label_Webservice)
        Me.SplitContainer3.Size = New System.Drawing.Size(519, 268)
        Me.SplitContainer3.SplitterDistance = 137
        Me.SplitContainer3.TabIndex = 0
        '
        'Label_Email
        '
        Me.Label_Email.AutoSize = True
        Me.Label_Email.Location = New System.Drawing.Point(5, 3)
        Me.Label_Email.Name = "Label_Email"
        Me.Label_Email.Size = New System.Drawing.Size(46, 13)
        Me.Label_Email.TabIndex = 0
        Me.Label_Email.Text = "x_Email:"
        '
        'Label_Url
        '
        Me.Label_Url.AutoSize = True
        Me.Label_Url.Location = New System.Drawing.Point(5, 4)
        Me.Label_Url.Name = "Label_Url"
        Me.Label_Url.Size = New System.Drawing.Size(34, 13)
        Me.Label_Url.TabIndex = 0
        Me.Label_Url.Text = "x_Url:"
        '
        'Label_Webservice
        '
        Me.Label_Webservice.AutoSize = True
        Me.Label_Webservice.Location = New System.Drawing.Point(5, 4)
        Me.Label_Webservice.Name = "Label_Webservice"
        Me.Label_Webservice.Size = New System.Drawing.Size(78, 13)
        Me.Label_Webservice.TabIndex = 0
        Me.Label_Webservice.Text = "x_Webservice:"
        '
        'Panel_Email
        '
        Me.Panel_Email.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Email.Location = New System.Drawing.Point(3, 19)
        Me.Panel_Email.Name = "Panel_Email"
        Me.Panel_Email.Size = New System.Drawing.Size(509, 113)
        Me.Panel_Email.TabIndex = 1
        '
        'Panel_Url
        '
        Me.Panel_Url.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Url.Location = New System.Drawing.Point(3, 21)
        Me.Panel_Url.Name = "Panel_Url"
        Me.Panel_Url.Size = New System.Drawing.Size(509, 109)
        Me.Panel_Url.TabIndex = 1
        '
        'Panel_Webservice
        '
        Me.Panel_Webservice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Webservice.Location = New System.Drawing.Point(3, 21)
        Me.Panel_Webservice.Name = "Panel_Webservice"
        Me.Panel_Webservice.Size = New System.Drawing.Size(509, 99)
        Me.Panel_Webservice.TabIndex = 1
        '
        'UserControl_ComunicationData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_ComunicationData"
        Me.Size = New System.Drawing.Size(533, 443)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Tel.ResumeLayout(False)
        Me.TabPage_Web.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Tel As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel_Telephone As System.Windows.Forms.Panel
    Friend WithEvents Label_Telephone As System.Windows.Forms.Label
    Friend WithEvents Panel_Fax As System.Windows.Forms.Panel
    Friend WithEvents Label_Fax As System.Windows.Forms.Label
    Friend WithEvents TabPage_Web As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel_Email As System.Windows.Forms.Panel
    Friend WithEvents Label_Email As System.Windows.Forms.Label
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel_Url As System.Windows.Forms.Panel
    Friend WithEvents Label_Url As System.Windows.Forms.Label
    Friend WithEvents Panel_Webservice As System.Windows.Forms.Panel
    Friend WithEvents Label_Webservice As System.Windows.Forms.Label

End Class
