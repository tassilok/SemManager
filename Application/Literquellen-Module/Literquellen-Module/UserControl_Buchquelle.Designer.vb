<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Buchquelle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Buchquelle))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripProgressBar_Data = New System.Windows.Forms.ToolStripProgressBar()
        Me.Button_ParentQuelle = New System.Windows.Forms.Button()
        Me.TextBox_ParentQuelle = New System.Windows.Forms.TextBox()
        Me.Label_ParentQuelle = New System.Windows.Forms.Label()
        Me.Button_Literatur = New System.Windows.Forms.Button()
        Me.TextBox_Literatur = New System.Windows.Forms.TextBox()
        Me.Label_Literatur = New System.Windows.Forms.Label()
        Me.Panel_Begriffe = New System.Windows.Forms.Panel()
        Me.Label_Begriffe = New System.Windows.Forms.Label()
        Me.TextBox_Seite = New System.Windows.Forms.TextBox()
        Me.Label_Seite = New System.Windows.Forms.Label()
        Me.Timer_getData = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Seite = New System.Windows.Forms.Timer(Me.components)
        Me.Button_DelParent = New System.Windows.Forms.Button()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_DelParent)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_ParentQuelle)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_ParentQuelle)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_ParentQuelle)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Literatur)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Literatur)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Literatur)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Panel_Begriffe)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Begriffe)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Seite)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Seite)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(410, 372)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(410, 422)
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
        Me.ToolStripProgressBar_Data.Maximum = 2
        Me.ToolStripProgressBar_Data.Name = "ToolStripProgressBar_Data"
        Me.ToolStripProgressBar_Data.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripProgressBar_Data.Step = 1
        Me.ToolStripProgressBar_Data.Visible = False
        '
        'Button_ParentQuelle
        '
        Me.Button_ParentQuelle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ParentQuelle.Enabled = False
        Me.Button_ParentQuelle.Location = New System.Drawing.Point(362, 345)
        Me.Button_ParentQuelle.Name = "Button_ParentQuelle"
        Me.Button_ParentQuelle.Size = New System.Drawing.Size(24, 23)
        Me.Button_ParentQuelle.TabIndex = 11
        Me.Button_ParentQuelle.Text = "..."
        Me.Button_ParentQuelle.UseVisualStyleBackColor = True
        '
        'TextBox_ParentQuelle
        '
        Me.TextBox_ParentQuelle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ParentQuelle.Enabled = False
        Me.TextBox_ParentQuelle.Location = New System.Drawing.Point(115, 347)
        Me.TextBox_ParentQuelle.Name = "TextBox_ParentQuelle"
        Me.TextBox_ParentQuelle.Size = New System.Drawing.Size(241, 20)
        Me.TextBox_ParentQuelle.TabIndex = 10
        '
        'Label_ParentQuelle
        '
        Me.Label_ParentQuelle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_ParentQuelle.AutoSize = True
        Me.Label_ParentQuelle.Location = New System.Drawing.Point(7, 350)
        Me.Label_ParentQuelle.Name = "Label_ParentQuelle"
        Me.Label_ParentQuelle.Size = New System.Drawing.Size(103, 13)
        Me.Label_ParentQuelle.TabIndex = 9
        Me.Label_ParentQuelle.Text = "Buchquelle (Parent):"
        '
        'Button_Literatur
        '
        Me.Button_Literatur.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Literatur.Enabled = False
        Me.Button_Literatur.Location = New System.Drawing.Point(383, 26)
        Me.Button_Literatur.Name = "Button_Literatur"
        Me.Button_Literatur.Size = New System.Drawing.Size(24, 23)
        Me.Button_Literatur.TabIndex = 8
        Me.Button_Literatur.Text = "..."
        Me.Button_Literatur.UseVisualStyleBackColor = True
        '
        'TextBox_Literatur
        '
        Me.TextBox_Literatur.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Literatur.Enabled = False
        Me.TextBox_Literatur.Location = New System.Drawing.Point(115, 28)
        Me.TextBox_Literatur.Name = "TextBox_Literatur"
        Me.TextBox_Literatur.Size = New System.Drawing.Size(268, 20)
        Me.TextBox_Literatur.TabIndex = 7
        '
        'Label_Literatur
        '
        Me.Label_Literatur.AutoSize = True
        Me.Label_Literatur.Location = New System.Drawing.Point(4, 31)
        Me.Label_Literatur.Name = "Label_Literatur"
        Me.Label_Literatur.Size = New System.Drawing.Size(56, 13)
        Me.Label_Literatur.TabIndex = 6
        Me.Label_Literatur.Text = "x_Literatur"
        '
        'Panel_Begriffe
        '
        Me.Panel_Begriffe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Begriffe.Location = New System.Drawing.Point(115, 54)
        Me.Panel_Begriffe.Name = "Panel_Begriffe"
        Me.Panel_Begriffe.Size = New System.Drawing.Size(292, 287)
        Me.Panel_Begriffe.TabIndex = 5
        '
        'Label_Begriffe
        '
        Me.Label_Begriffe.AutoSize = True
        Me.Label_Begriffe.Location = New System.Drawing.Point(4, 54)
        Me.Label_Begriffe.Name = "Label_Begriffe"
        Me.Label_Begriffe.Size = New System.Drawing.Size(57, 13)
        Me.Label_Begriffe.TabIndex = 4
        Me.Label_Begriffe.Text = "x_Begriffe:"
        '
        'TextBox_Seite
        '
        Me.TextBox_Seite.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Seite.Enabled = False
        Me.TextBox_Seite.Location = New System.Drawing.Point(115, 3)
        Me.TextBox_Seite.Name = "TextBox_Seite"
        Me.TextBox_Seite.Size = New System.Drawing.Size(292, 20)
        Me.TextBox_Seite.TabIndex = 3
        '
        'Label_Seite
        '
        Me.Label_Seite.AutoSize = True
        Me.Label_Seite.Location = New System.Drawing.Point(4, 6)
        Me.Label_Seite.Name = "Label_Seite"
        Me.Label_Seite.Size = New System.Drawing.Size(45, 13)
        Me.Label_Seite.TabIndex = 2
        Me.Label_Seite.Text = "x_Seite:"
        '
        'Timer_getData
        '
        Me.Timer_getData.Interval = 300
        '
        'Timer_Seite
        '
        Me.Timer_Seite.Interval = 300
        '
        'Button_DelParent
        '
        Me.Button_DelParent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_DelParent.Enabled = False
        Me.Button_DelParent.ImageIndex = 0
        Me.Button_DelParent.ImageList = Me.ImageList_Main
        Me.Button_DelParent.Location = New System.Drawing.Point(386, 345)
        Me.Button_DelParent.Name = "Button_DelParent"
        Me.Button_DelParent.Size = New System.Drawing.Size(24, 23)
        Me.Button_DelParent.TabIndex = 12
        Me.Button_DelParent.UseVisualStyleBackColor = True
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ImageStream = CType(resources.GetObject("ImageList_Main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Main.Images.SetKeyName(0, "tasto_8_architetto_franc_01.png")
        '
        'UserControl_Buchquelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_Buchquelle"
        Me.Size = New System.Drawing.Size(410, 422)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Button_ParentQuelle As System.Windows.Forms.Button
    Friend WithEvents TextBox_ParentQuelle As System.Windows.Forms.TextBox
    Friend WithEvents Label_ParentQuelle As System.Windows.Forms.Label
    Friend WithEvents Button_Literatur As System.Windows.Forms.Button
    Friend WithEvents TextBox_Literatur As System.Windows.Forms.TextBox
    Friend WithEvents Label_Literatur As System.Windows.Forms.Label
    Friend WithEvents Panel_Begriffe As System.Windows.Forms.Panel
    Friend WithEvents Label_Begriffe As System.Windows.Forms.Label
    Friend WithEvents TextBox_Seite As System.Windows.Forms.TextBox
    Friend WithEvents Label_Seite As System.Windows.Forms.Label
    Friend WithEvents ToolStripProgressBar_Data As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Timer_getData As System.Windows.Forms.Timer
    Friend WithEvents Timer_Seite As System.Windows.Forms.Timer
    Friend WithEvents Button_DelParent As System.Windows.Forms.Button
    Friend WithEvents ImageList_Main As System.Windows.Forms.ImageList

End Class
