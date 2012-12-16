<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Documents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Documents))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_Belege = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Count = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_New = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MoveFirst = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MovePrevious = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MoveNext = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MoveLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Down = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Up = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Del = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_Title = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_Title = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_Location = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_Location = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton_Location = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_DelLocation = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_Type = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox_Type = New System.Windows.Forms.ToolStripComboBox()
        Me.Timer_Title = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip3)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(816, 366)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(816, 441)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Belege, Me.ToolStripLabel_Count})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(91, 25)
        Me.ToolStrip3.TabIndex = 0
        '
        'ToolStripLabel_Belege
        '
        Me.ToolStripLabel_Belege.Name = "ToolStripLabel_Belege"
        Me.ToolStripLabel_Belege.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel_Belege.Text = "x_Belege:"
        '
        'ToolStripLabel_Count
        '
        Me.ToolStripLabel_Count.Name = "ToolStripLabel_Count"
        Me.ToolStripLabel_Count.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripLabel_Count.Text = "0/0"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_New, Me.ToolStripButton_MoveFirst, Me.ToolStripButton_MovePrevious, Me.ToolStripButton_MoveNext, Me.ToolStripButton_MoveLast, Me.ToolStripButton_Down, Me.ToolStripButton_Up, Me.ToolStripButton_Del, Me.ToolStripSeparator1, Me.ToolStripLabel_Title, Me.ToolStripTextBox_Title})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(528, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_New
        '
        Me.ToolStripButton_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_New.Enabled = False
        Me.ToolStripButton_New.Image = Global.Bill_Module.My.Resources.Resources.NewDocumentHS
        Me.ToolStripButton_New.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_New.Name = "ToolStripButton_New"
        Me.ToolStripButton_New.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_New.Text = "ToolStripButton2"
        '
        'ToolStripButton_MoveFirst
        '
        Me.ToolStripButton_MoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MoveFirst.Enabled = False
        Me.ToolStripButton_MoveFirst.Image = Global.Bill_Module.My.Resources.Resources.pulsante_01_architetto_f_01_First
        Me.ToolStripButton_MoveFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MoveFirst.Name = "ToolStripButton_MoveFirst"
        Me.ToolStripButton_MoveFirst.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MoveFirst.Text = "ToolStripButton1"
        '
        'ToolStripButton_MovePrevious
        '
        Me.ToolStripButton_MovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MovePrevious.Enabled = False
        Me.ToolStripButton_MovePrevious.Image = Global.Bill_Module.My.Resources.Resources.pulsante_01_architetto_f_01
        Me.ToolStripButton_MovePrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MovePrevious.Name = "ToolStripButton_MovePrevious"
        Me.ToolStripButton_MovePrevious.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MovePrevious.Text = "ToolStripButton2"
        '
        'ToolStripButton_MoveNext
        '
        Me.ToolStripButton_MoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MoveNext.Enabled = False
        Me.ToolStripButton_MoveNext.Image = Global.Bill_Module.My.Resources.Resources.pulsante_02_architetto_f_01
        Me.ToolStripButton_MoveNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MoveNext.Name = "ToolStripButton_MoveNext"
        Me.ToolStripButton_MoveNext.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MoveNext.Text = "ToolStripButton3"
        '
        'ToolStripButton_MoveLast
        '
        Me.ToolStripButton_MoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MoveLast.Enabled = False
        Me.ToolStripButton_MoveLast.Image = Global.Bill_Module.My.Resources.Resources.pulsante_02_architetto_f_01_Last
        Me.ToolStripButton_MoveLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MoveLast.Name = "ToolStripButton_MoveLast"
        Me.ToolStripButton_MoveLast.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MoveLast.Text = "ToolStripButton4"
        '
        'ToolStripButton_Down
        '
        Me.ToolStripButton_Down.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Down.Enabled = False
        Me.ToolStripButton_Down.Image = Global.Bill_Module.My.Resources.Resources.arrow_down_purple_benji__01
        Me.ToolStripButton_Down.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Down.Name = "ToolStripButton_Down"
        Me.ToolStripButton_Down.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Down.Text = "ToolStripButton1"
        '
        'ToolStripButton_Up
        '
        Me.ToolStripButton_Up.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Up.Enabled = False
        Me.ToolStripButton_Up.Image = Global.Bill_Module.My.Resources.Resources.arrow_up_blue_benji_park_01
        Me.ToolStripButton_Up.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Up.Name = "ToolStripButton_Up"
        Me.ToolStripButton_Up.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Up.Text = "ToolStripButton2"
        '
        'ToolStripButton_Del
        '
        Me.ToolStripButton_Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Del.Enabled = False
        Me.ToolStripButton_Del.Image = Global.Bill_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_Del.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Del.Name = "ToolStripButton_Del"
        Me.ToolStripButton_Del.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Del.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_Title
        '
        Me.ToolStripLabel_Title.Name = "ToolStripLabel_Title"
        Me.ToolStripLabel_Title.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripLabel_Title.Text = "x_Title:"
        '
        'ToolStripTextBox_Title
        '
        Me.ToolStripTextBox_Title.Name = "ToolStripTextBox_Title"
        Me.ToolStripTextBox_Title.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Location, Me.ToolStripTextBox_Location, Me.ToolStripButton_Location, Me.ToolStripButton_DelLocation, Me.ToolStripSeparator2, Me.ToolStripLabel_Type, Me.ToolStripComboBox_Type})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 25)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(626, 25)
        Me.ToolStrip2.TabIndex = 1
        '
        'ToolStripLabel_Location
        '
        Me.ToolStripLabel_Location.Name = "ToolStripLabel_Location"
        Me.ToolStripLabel_Location.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel_Location.Text = "x_Location:"
        '
        'ToolStripTextBox_Location
        '
        Me.ToolStripTextBox_Location.Enabled = False
        Me.ToolStripTextBox_Location.Name = "ToolStripTextBox_Location"
        Me.ToolStripTextBox_Location.Size = New System.Drawing.Size(300, 25)
        '
        'ToolStripButton_Location
        '
        Me.ToolStripButton_Location.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Location.Enabled = False
        Me.ToolStripButton_Location.Image = CType(resources.GetObject("ToolStripButton_Location.Image"), System.Drawing.Image)
        Me.ToolStripButton_Location.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Location.Name = "ToolStripButton_Location"
        Me.ToolStripButton_Location.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Location.Text = "..."
        '
        'ToolStripButton_DelLocation
        '
        Me.ToolStripButton_DelLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_DelLocation.Enabled = False
        Me.ToolStripButton_DelLocation.Image = Global.Bill_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_DelLocation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_DelLocation.Name = "ToolStripButton_DelLocation"
        Me.ToolStripButton_DelLocation.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_DelLocation.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_Type
        '
        Me.ToolStripLabel_Type.Name = "ToolStripLabel_Type"
        Me.ToolStripLabel_Type.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripLabel_Type.Text = "x_Belegstyp:"
        '
        'ToolStripComboBox_Type
        '
        Me.ToolStripComboBox_Type.Enabled = False
        Me.ToolStripComboBox_Type.Name = "ToolStripComboBox_Type"
        Me.ToolStripComboBox_Type.Size = New System.Drawing.Size(121, 25)
        '
        'Timer_Title
        '
        Me.Timer_Title.Interval = 300
        '
        'UserControl_Documents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_Documents"
        Me.Size = New System.Drawing.Size(816, 441)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_MoveFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MovePrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MoveNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MoveLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Del As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_New As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel_Title As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Title As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Location As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Location As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton_Location As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Belege As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Count As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_Type As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripComboBox_Type As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton_Down As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Up As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_DelLocation As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer_Title As System.Windows.Forms.Timer

End Class
