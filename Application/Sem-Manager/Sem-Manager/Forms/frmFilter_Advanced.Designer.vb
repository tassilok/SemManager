<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilter_Advanced
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFilter_Advanced))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Apply = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Cancel = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_NoRelation = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_AddRelation = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer3 = New System.Windows.Forms.ToolStripContainer()
        Me.Button_RemoveRelationType = New System.Windows.Forms.Button()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox_RelationType = New System.Windows.Forms.TextBox()
        Me.Button_RemoveType = New System.Windows.Forms.Button()
        Me.Button_RemoveToken = New System.Windows.Forms.Button()
        Me.TextBox_Type = New System.Windows.Forms.TextBox()
        Me.TextBox_Token = New System.Windows.Forms.TextBox()
        Me.Label_RelationType = New System.Windows.Forms.Label()
        Me.Label_Type = New System.Windows.Forms.Label()
        Me.Label_Token = New System.Windows.Forms.Label()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStripContainer3.ContentPanel.SuspendLayout()
        Me.ToolStripContainer3.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(682, 370)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(682, 420)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Apply, Me.ToolStripButton_Cancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(121, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Apply
        '
        Me.ToolStripButton_Apply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Apply.Image = CType(resources.GetObject("ToolStripButton_Apply.Image"), System.Drawing.Image)
        Me.ToolStripButton_Apply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Apply.Name = "ToolStripButton_Apply"
        Me.ToolStripButton_Apply.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton_Apply.Text = "x_Apply"
        '
        'ToolStripButton_Cancel
        '
        Me.ToolStripButton_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Cancel.Image = CType(resources.GetObject("ToolStripButton_Cancel.Image"), System.Drawing.Image)
        Me.ToolStripButton_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Cancel.Name = "ToolStripButton_Cancel"
        Me.ToolStripButton_Cancel.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton_Cancel.Text = "x_Cancel"
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(682, 370)
        Me.SplitContainer1.SplitterDistance = 201
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStripContainer2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStripContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(477, 370)
        Me.SplitContainer2.SplitterDistance = 140
        Me.SplitContainer2.TabIndex = 0
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(473, 111)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(473, 136)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_NoRelation, Me.ToolStripButton_AddRelation})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(118, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripButton_NoRelation
        '
        Me.ToolStripButton_NoRelation.CheckOnClick = True
        Me.ToolStripButton_NoRelation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_NoRelation.Image = CType(resources.GetObject("ToolStripButton_NoRelation.Image"), System.Drawing.Image)
        Me.ToolStripButton_NoRelation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_NoRelation.Name = "ToolStripButton_NoRelation"
        Me.ToolStripButton_NoRelation.Size = New System.Drawing.Size(83, 22)
        Me.ToolStripButton_NoRelation.Text = "x_No Relation"
        '
        'ToolStripButton_AddRelation
        '
        Me.ToolStripButton_AddRelation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_AddRelation.Image = Global.Sem_Manager.My.Resources.Resources.b_plus
        Me.ToolStripButton_AddRelation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_AddRelation.Name = "ToolStripButton_AddRelation"
        Me.ToolStripButton_AddRelation.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_AddRelation.Text = "ToolStripButton2"
        '
        'ToolStripContainer3
        '
        '
        'ToolStripContainer3.ContentPanel
        '
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.Button_RemoveRelationType)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.TextBox_RelationType)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.Button_RemoveType)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.Button_RemoveToken)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.TextBox_Type)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.TextBox_Token)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.Label_RelationType)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.Label_Type)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.Label_Token)
        Me.ToolStripContainer3.ContentPanel.Size = New System.Drawing.Size(473, 197)
        Me.ToolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer3.Name = "ToolStripContainer3"
        Me.ToolStripContainer3.Size = New System.Drawing.Size(473, 222)
        Me.ToolStripContainer3.TabIndex = 0
        Me.ToolStripContainer3.Text = "ToolStripContainer3"
        '
        'Button_RemoveRelationType
        '
        Me.Button_RemoveRelationType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_RemoveRelationType.ImageIndex = 0
        Me.Button_RemoveRelationType.ImageList = Me.ImageList_Main
        Me.Button_RemoveRelationType.Location = New System.Drawing.Point(443, 48)
        Me.Button_RemoveRelationType.Name = "Button_RemoveRelationType"
        Me.Button_RemoveRelationType.Size = New System.Drawing.Size(29, 23)
        Me.Button_RemoveRelationType.TabIndex = 10
        Me.Button_RemoveRelationType.UseVisualStyleBackColor = True
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ImageStream = CType(resources.GetObject("ImageList_Main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Main.Images.SetKeyName(0, "b_minus.png")
        Me.ImageList_Main.Images.SetKeyName(1, "b_plus.png")
        '
        'TextBox_RelationType
        '
        Me.TextBox_RelationType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_RelationType.Location = New System.Drawing.Point(97, 50)
        Me.TextBox_RelationType.Name = "TextBox_RelationType"
        Me.TextBox_RelationType.ReadOnly = True
        Me.TextBox_RelationType.Size = New System.Drawing.Size(340, 20)
        Me.TextBox_RelationType.TabIndex = 9
        '
        'Button_RemoveType
        '
        Me.Button_RemoveType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_RemoveType.ImageIndex = 0
        Me.Button_RemoveType.ImageList = Me.ImageList_Main
        Me.Button_RemoveType.Location = New System.Drawing.Point(443, 25)
        Me.Button_RemoveType.Name = "Button_RemoveType"
        Me.Button_RemoveType.Size = New System.Drawing.Size(29, 23)
        Me.Button_RemoveType.TabIndex = 8
        Me.Button_RemoveType.UseVisualStyleBackColor = True
        '
        'Button_RemoveToken
        '
        Me.Button_RemoveToken.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_RemoveToken.ImageIndex = 0
        Me.Button_RemoveToken.ImageList = Me.ImageList_Main
        Me.Button_RemoveToken.Location = New System.Drawing.Point(443, 1)
        Me.Button_RemoveToken.Name = "Button_RemoveToken"
        Me.Button_RemoveToken.Size = New System.Drawing.Size(29, 23)
        Me.Button_RemoveToken.TabIndex = 6
        Me.Button_RemoveToken.UseVisualStyleBackColor = True
        '
        'TextBox_Type
        '
        Me.TextBox_Type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Type.Location = New System.Drawing.Point(97, 27)
        Me.TextBox_Type.Name = "TextBox_Type"
        Me.TextBox_Type.ReadOnly = True
        Me.TextBox_Type.Size = New System.Drawing.Size(340, 20)
        Me.TextBox_Type.TabIndex = 4
        '
        'TextBox_Token
        '
        Me.TextBox_Token.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Token.Location = New System.Drawing.Point(97, 3)
        Me.TextBox_Token.Name = "TextBox_Token"
        Me.TextBox_Token.ReadOnly = True
        Me.TextBox_Token.Size = New System.Drawing.Size(340, 20)
        Me.TextBox_Token.TabIndex = 3
        '
        'Label_RelationType
        '
        Me.Label_RelationType.AutoSize = True
        Me.Label_RelationType.Location = New System.Drawing.Point(3, 53)
        Me.Label_RelationType.Name = "Label_RelationType"
        Me.Label_RelationType.Size = New System.Drawing.Size(84, 13)
        Me.Label_RelationType.TabIndex = 2
        Me.Label_RelationType.Text = "x_RelationType:"
        '
        'Label_Type
        '
        Me.Label_Type.AutoSize = True
        Me.Label_Type.Location = New System.Drawing.Point(3, 27)
        Me.Label_Type.Name = "Label_Type"
        Me.Label_Type.Size = New System.Drawing.Size(45, 13)
        Me.Label_Type.TabIndex = 1
        Me.Label_Type.Text = "x_Type:"
        '
        'Label_Token
        '
        Me.Label_Token.AutoSize = True
        Me.Label_Token.Location = New System.Drawing.Point(3, 6)
        Me.Label_Token.Name = "Label_Token"
        Me.Label_Token.Size = New System.Drawing.Size(52, 13)
        Me.Label_Token.TabIndex = 0
        Me.Label_Token.Text = "x_Token:"
        '
        'frmFilter_Advanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 420)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmFilter_Advanced"
        Me.Text = "x_Filter (Advanced)"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStripContainer3.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer3.ContentPanel.PerformLayout()
        Me.ToolStripContainer3.ResumeLayout(False)
        Me.ToolStripContainer3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Apply As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_NoRelation As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_AddRelation As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripContainer3 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents Button_RemoveRelationType As System.Windows.Forms.Button
    Friend WithEvents ImageList_Main As System.Windows.Forms.ImageList
    Friend WithEvents TextBox_RelationType As System.Windows.Forms.TextBox
    Friend WithEvents Button_RemoveType As System.Windows.Forms.Button
    Friend WithEvents Button_RemoveToken As System.Windows.Forms.Button
    Friend WithEvents TextBox_Type As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Token As System.Windows.Forms.TextBox
    Friend WithEvents Label_RelationType As System.Windows.Forms.Label
    Friend WithEvents Label_Type As System.Windows.Forms.Label
    Friend WithEvents Label_Token As System.Windows.Forms.Label
End Class
