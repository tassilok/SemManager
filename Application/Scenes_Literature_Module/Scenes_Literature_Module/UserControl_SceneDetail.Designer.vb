<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_SceneDetail
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Panel_LiterarischesDatum = New System.Windows.Forms.Panel()
        Me.Label_DateTime = New System.Windows.Forms.Label()
        Me.Label_LiterarischerCharakter = New System.Windows.Forms.Label()
        Me.Panel_LiterarischerCharakter = New System.Windows.Forms.Panel()
        Me.Label_LiterarischerOrt = New System.Windows.Forms.Label()
        Me.Panel_LiterarischerOr = New System.Windows.Forms.Panel()
        Me.Button_Medias = New System.Windows.Forms.Button()
        Me.Label_SceneName = New System.Windows.Forms.Label()
        Me.Label_Scene = New System.Windows.Forms.Label()
        Me.TabControl_Medias = New System.Windows.Forms.TabControl()
        Me.TabPage_Images = New System.Windows.Forms.TabPage()
        Me.TabPage_MediaItems = New System.Windows.Forms.TabPage()
        Me.TabPage_PDF = New System.Windows.Forms.TabPage()
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
        Me.TabControl_Medias.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_Medias)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_SceneName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_Scene)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl_Medias)
        Me.SplitContainer1.Size = New System.Drawing.Size(941, 635)
        Me.SplitContainer1.SplitterDistance = 446
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 33)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label_LiterarischerOrt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel_LiterarischerOr)
        Me.SplitContainer2.Size = New System.Drawing.Size(436, 594)
        Me.SplitContainer2.SplitterDistance = 398
        Me.SplitContainer2.TabIndex = 3
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Panel_LiterarischesDatum)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label_DateTime)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label_LiterarischerCharakter)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Panel_LiterarischerCharakter)
        Me.SplitContainer3.Size = New System.Drawing.Size(436, 398)
        Me.SplitContainer3.SplitterDistance = 184
        Me.SplitContainer3.TabIndex = 0
        '
        'Panel_LiterarischesDatum
        '
        Me.Panel_LiterarischesDatum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_LiterarischesDatum.Location = New System.Drawing.Point(4, 19)
        Me.Panel_LiterarischesDatum.Name = "Panel_LiterarischesDatum"
        Me.Panel_LiterarischesDatum.Size = New System.Drawing.Size(425, 158)
        Me.Panel_LiterarischesDatum.TabIndex = 1
        '
        'Label_DateTime
        '
        Me.Label_DateTime.AutoSize = True
        Me.Label_DateTime.Location = New System.Drawing.Point(4, 2)
        Me.Label_DateTime.Name = "Label_DateTime"
        Me.Label_DateTime.Size = New System.Drawing.Size(114, 13)
        Me.Label_DateTime.TabIndex = 0
        Me.Label_DateTime.Text = "x_Literarisches Datum:"
        '
        'Label_LiterarischerCharakter
        '
        Me.Label_LiterarischerCharakter.AutoSize = True
        Me.Label_LiterarischerCharakter.Location = New System.Drawing.Point(4, 3)
        Me.Label_LiterarischerCharakter.Name = "Label_LiterarischerCharakter"
        Me.Label_LiterarischerCharakter.Size = New System.Drawing.Size(127, 13)
        Me.Label_LiterarischerCharakter.TabIndex = 3
        Me.Label_LiterarischerCharakter.Text = "x_Literarischer Charakter:"
        '
        'Panel_LiterarischerCharakter
        '
        Me.Panel_LiterarischerCharakter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_LiterarischerCharakter.Location = New System.Drawing.Point(3, 19)
        Me.Panel_LiterarischerCharakter.Name = "Panel_LiterarischerCharakter"
        Me.Panel_LiterarischerCharakter.Size = New System.Drawing.Size(425, 184)
        Me.Panel_LiterarischerCharakter.TabIndex = 2
        '
        'Label_LiterarischerOrt
        '
        Me.Label_LiterarischerOrt.AutoSize = True
        Me.Label_LiterarischerOrt.Location = New System.Drawing.Point(4, 1)
        Me.Label_LiterarischerOrt.Name = "Label_LiterarischerOrt"
        Me.Label_LiterarischerOrt.Size = New System.Drawing.Size(95, 13)
        Me.Label_LiterarischerOrt.TabIndex = 3
        Me.Label_LiterarischerOrt.Text = "x_Literarischer Ort:"
        '
        'Panel_LiterarischerOr
        '
        Me.Panel_LiterarischerOr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_LiterarischerOr.Location = New System.Drawing.Point(3, 17)
        Me.Panel_LiterarischerOr.Name = "Panel_LiterarischerOr"
        Me.Panel_LiterarischerOr.Size = New System.Drawing.Size(425, 168)
        Me.Panel_LiterarischerOr.TabIndex = 2
        '
        'Button_Medias
        '
        Me.Button_Medias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Medias.Location = New System.Drawing.Point(364, 8)
        Me.Button_Medias.Name = "Button_Medias"
        Me.Button_Medias.Size = New System.Drawing.Size(75, 23)
        Me.Button_Medias.TabIndex = 2
        Me.Button_Medias.Text = "x_Medias"
        Me.Button_Medias.UseVisualStyleBackColor = True
        '
        'Label_SceneName
        '
        Me.Label_SceneName.AutoSize = True
        Me.Label_SceneName.Location = New System.Drawing.Point(67, 13)
        Me.Label_SceneName.Name = "Label_SceneName"
        Me.Label_SceneName.Size = New System.Drawing.Size(10, 13)
        Me.Label_SceneName.TabIndex = 1
        Me.Label_SceneName.Text = "-"
        '
        'Label_Scene
        '
        Me.Label_Scene.AutoSize = True
        Me.Label_Scene.Location = New System.Drawing.Point(12, 13)
        Me.Label_Scene.Name = "Label_Scene"
        Me.Label_Scene.Size = New System.Drawing.Size(52, 13)
        Me.Label_Scene.TabIndex = 0
        Me.Label_Scene.Text = "x_Scene:"
        '
        'TabControl_Medias
        '
        Me.TabControl_Medias.Controls.Add(Me.TabPage_Images)
        Me.TabControl_Medias.Controls.Add(Me.TabPage_MediaItems)
        Me.TabControl_Medias.Controls.Add(Me.TabPage_PDF)
        Me.TabControl_Medias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_Medias.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_Medias.Name = "TabControl_Medias"
        Me.TabControl_Medias.SelectedIndex = 0
        Me.TabControl_Medias.Size = New System.Drawing.Size(487, 631)
        Me.TabControl_Medias.TabIndex = 0
        '
        'TabPage_Images
        '
        Me.TabPage_Images.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Images.Name = "TabPage_Images"
        Me.TabPage_Images.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Images.Size = New System.Drawing.Size(479, 605)
        Me.TabPage_Images.TabIndex = 0
        Me.TabPage_Images.Text = "x_Images"
        Me.TabPage_Images.UseVisualStyleBackColor = True
        '
        'TabPage_MediaItems
        '
        Me.TabPage_MediaItems.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_MediaItems.Name = "TabPage_MediaItems"
        Me.TabPage_MediaItems.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_MediaItems.Size = New System.Drawing.Size(479, 605)
        Me.TabPage_MediaItems.TabIndex = 1
        Me.TabPage_MediaItems.Text = "x_Audio/Video"
        Me.TabPage_MediaItems.UseVisualStyleBackColor = True
        '
        'TabPage_PDF
        '
        Me.TabPage_PDF.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_PDF.Name = "TabPage_PDF"
        Me.TabPage_PDF.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_PDF.Size = New System.Drawing.Size(479, 605)
        Me.TabPage_PDF.TabIndex = 2
        Me.TabPage_PDF.Text = "x_PDF-Documents"
        Me.TabPage_PDF.UseVisualStyleBackColor = True
        '
        'UserControl_SceneDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_SceneDetail"
        Me.Size = New System.Drawing.Size(941, 635)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.TabControl_Medias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel_LiterarischesDatum As System.Windows.Forms.Panel
    Friend WithEvents Label_DateTime As System.Windows.Forms.Label
    Friend WithEvents Label_LiterarischerCharakter As System.Windows.Forms.Label
    Friend WithEvents Panel_LiterarischerCharakter As System.Windows.Forms.Panel
    Friend WithEvents Label_LiterarischerOrt As System.Windows.Forms.Label
    Friend WithEvents Panel_LiterarischerOr As System.Windows.Forms.Panel
    Friend WithEvents Button_Medias As System.Windows.Forms.Button
    Friend WithEvents Label_SceneName As System.Windows.Forms.Label
    Friend WithEvents Label_Scene As System.Windows.Forms.Label
    Friend WithEvents TabControl_Medias As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Images As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_MediaItems As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_PDF As System.Windows.Forms.TabPage

End Class
