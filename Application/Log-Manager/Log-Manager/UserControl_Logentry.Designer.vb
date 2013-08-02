<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Logentry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Logentry))
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.TextBox_Caption = New System.Windows.Forms.TextBox()
        Me.Label_DateTimeStamp = New System.Windows.Forms.Label()
        Me.DateTimePicker_DateTimeStamp = New System.Windows.Forms.DateTimePicker()
        Me.Label_Message = New System.Windows.Forms.Label()
        Me.TextBox_Message = New System.Windows.Forms.TextBox()
        Me.Label_Logstate = New System.Windows.Forms.Label()
        Me.ComboBox_Logstate = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip_LogState = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LogStateStandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogStateOpenTokenEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_User = New System.Windows.Forms.Label()
        Me.ComboBox_User = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip_User = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UserStandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserOpenTokenEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripProgressBar_Data = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_UserLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton_User = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_LogStateLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton_LogState = New System.Windows.Forms.ToolStripButton()
        Me.Timer_Data = New System.Windows.Forms.Timer(Me.components)
        Me.Button_FromTimestamp = New System.Windows.Forms.Button()
        Me.Panel_Relations = New System.Windows.Forms.Panel()
        Me.Label_Relations = New System.Windows.Forms.Label()
        Me.Timer_Caption = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Message = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip_LogState.SuspendLayout()
        Me.ContextMenuStrip_User.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Location = New System.Drawing.Point(4, 4)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(57, 13)
        Me.Label_Name.TabIndex = 0
        Me.Label_Name.Text = "x_Caption:"
        '
        'TextBox_Caption
        '
        Me.TextBox_Caption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Caption.Location = New System.Drawing.Point(80, 3)
        Me.TextBox_Caption.Name = "TextBox_Caption"
        Me.TextBox_Caption.ReadOnly = True
        Me.TextBox_Caption.Size = New System.Drawing.Size(373, 20)
        Me.TextBox_Caption.TabIndex = 1
        '
        'Label_DateTimeStamp
        '
        Me.Label_DateTimeStamp.AutoSize = True
        Me.Label_DateTimeStamp.Location = New System.Drawing.Point(4, 31)
        Me.Label_DateTimeStamp.Name = "Label_DateTimeStamp"
        Me.Label_DateTimeStamp.Size = New System.Drawing.Size(72, 13)
        Me.Label_DateTimeStamp.TabIndex = 3
        Me.Label_DateTimeStamp.Text = "x_Timestamp:"
        '
        'DateTimePicker_DateTimeStamp
        '
        Me.DateTimePicker_DateTimeStamp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_DateTimeStamp.CustomFormat = "dd.MM.yyy HH:mm:ss"
        Me.DateTimePicker_DateTimeStamp.Enabled = False
        Me.DateTimePicker_DateTimeStamp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_DateTimeStamp.Location = New System.Drawing.Point(80, 28)
        Me.DateTimePicker_DateTimeStamp.Name = "DateTimePicker_DateTimeStamp"
        Me.DateTimePicker_DateTimeStamp.Size = New System.Drawing.Size(438, 20)
        Me.DateTimePicker_DateTimeStamp.TabIndex = 4
        '
        'Label_Message
        '
        Me.Label_Message.AutoSize = True
        Me.Label_Message.Location = New System.Drawing.Point(4, 57)
        Me.Label_Message.Name = "Label_Message"
        Me.Label_Message.Size = New System.Drawing.Size(64, 13)
        Me.Label_Message.TabIndex = 6
        Me.Label_Message.Text = "x_Message:"
        '
        'TextBox_Message
        '
        Me.TextBox_Message.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Message.Location = New System.Drawing.Point(80, 53)
        Me.TextBox_Message.Multiline = True
        Me.TextBox_Message.Name = "TextBox_Message"
        Me.TextBox_Message.ReadOnly = True
        Me.TextBox_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Message.Size = New System.Drawing.Size(438, 199)
        Me.TextBox_Message.TabIndex = 7
        '
        'Label_Logstate
        '
        Me.Label_Logstate.AutoSize = True
        Me.Label_Logstate.Location = New System.Drawing.Point(4, 261)
        Me.Label_Logstate.Name = "Label_Logstate"
        Me.Label_Logstate.Size = New System.Drawing.Size(62, 13)
        Me.Label_Logstate.TabIndex = 8
        Me.Label_Logstate.Text = "x_Logstate:"
        '
        'ComboBox_Logstate
        '
        Me.ComboBox_Logstate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Logstate.ContextMenuStrip = Me.ContextMenuStrip_LogState
        Me.ComboBox_Logstate.Enabled = False
        Me.ComboBox_Logstate.FormattingEnabled = True
        Me.ComboBox_Logstate.Location = New System.Drawing.Point(80, 258)
        Me.ComboBox_Logstate.Name = "ComboBox_Logstate"
        Me.ComboBox_Logstate.Size = New System.Drawing.Size(438, 21)
        Me.ComboBox_Logstate.TabIndex = 9
        '
        'ContextMenuStrip_LogState
        '
        Me.ContextMenuStrip_LogState.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogStateStandardToolStripMenuItem, Me.LogStateOpenTokenEditToolStripMenuItem})
        Me.ContextMenuStrip_LogState.Name = "ContextMenuStrip_LogState"
        Me.ContextMenuStrip_LogState.Size = New System.Drawing.Size(175, 70)
        '
        'LogStateStandardToolStripMenuItem
        '
        Me.LogStateStandardToolStripMenuItem.Name = "LogStateStandardToolStripMenuItem"
        Me.LogStateStandardToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.LogStateStandardToolStripMenuItem.Text = "x_Standard"
        '
        'LogStateOpenTokenEditToolStripMenuItem
        '
        Me.LogStateOpenTokenEditToolStripMenuItem.Name = "LogStateOpenTokenEditToolStripMenuItem"
        Me.LogStateOpenTokenEditToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.LogStateOpenTokenEditToolStripMenuItem.Text = "x_Open Token-Edit"
        '
        'Label_User
        '
        Me.Label_User.AutoSize = True
        Me.Label_User.Location = New System.Drawing.Point(4, 287)
        Me.Label_User.Name = "Label_User"
        Me.Label_User.Size = New System.Drawing.Size(43, 13)
        Me.Label_User.TabIndex = 10
        Me.Label_User.Text = "x_User:"
        '
        'ComboBox_User
        '
        Me.ComboBox_User.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_User.ContextMenuStrip = Me.ContextMenuStrip_User
        Me.ComboBox_User.Enabled = False
        Me.ComboBox_User.FormattingEnabled = True
        Me.ComboBox_User.Location = New System.Drawing.Point(80, 284)
        Me.ComboBox_User.Name = "ComboBox_User"
        Me.ComboBox_User.Size = New System.Drawing.Size(438, 21)
        Me.ComboBox_User.TabIndex = 11
        '
        'ContextMenuStrip_User
        '
        Me.ContextMenuStrip_User.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserStandardToolStripMenuItem, Me.UserOpenTokenEditToolStripMenuItem})
        Me.ContextMenuStrip_User.Name = "ContextMenuStrip_User"
        Me.ContextMenuStrip_User.Size = New System.Drawing.Size(175, 48)
        '
        'UserStandardToolStripMenuItem
        '
        Me.UserStandardToolStripMenuItem.Name = "UserStandardToolStripMenuItem"
        Me.UserStandardToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.UserStandardToolStripMenuItem.Text = "x_Standard"
        '
        'UserOpenTokenEditToolStripMenuItem
        '
        Me.UserOpenTokenEditToolStripMenuItem.Name = "UserOpenTokenEditToolStripMenuItem"
        Me.UserOpenTokenEditToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.UserOpenTokenEditToolStripMenuItem.Text = "x_Open Token-Edit"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar_Data, Me.ToolStripSeparator1, Me.ToolStripLabel_UserLBL, Me.ToolStripButton_User, Me.ToolStripSeparator2, Me.ToolStripLabel_LogStateLBL, Me.ToolStripButton_LogState})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 418)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(530, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripProgressBar_Data
        '
        Me.ToolStripProgressBar_Data.Maximum = 5
        Me.ToolStripProgressBar_Data.Name = "ToolStripProgressBar_Data"
        Me.ToolStripProgressBar_Data.Size = New System.Drawing.Size(200, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_UserLBL
        '
        Me.ToolStripLabel_UserLBL.Name = "ToolStripLabel_UserLBL"
        Me.ToolStripLabel_UserLBL.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripLabel_UserLBL.Text = "x_User:"
        '
        'ToolStripButton_User
        '
        Me.ToolStripButton_User.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_User.Image = CType(resources.GetObject("ToolStripButton_User.Image"), System.Drawing.Image)
        Me.ToolStripButton_User.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_User.Name = "ToolStripButton_User"
        Me.ToolStripButton_User.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_User.Text = "-"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_LogStateLBL
        '
        Me.ToolStripLabel_LogStateLBL.Name = "ToolStripLabel_LogStateLBL"
        Me.ToolStripLabel_LogStateLBL.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel_LogStateLBL.Text = "x_Logstate:"
        '
        'ToolStripButton_LogState
        '
        Me.ToolStripButton_LogState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_LogState.Image = CType(resources.GetObject("ToolStripButton_LogState.Image"), System.Drawing.Image)
        Me.ToolStripButton_LogState.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_LogState.Name = "ToolStripButton_LogState"
        Me.ToolStripButton_LogState.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_LogState.Text = "-"
        '
        'Timer_Data
        '
        Me.Timer_Data.Interval = 300
        '
        'Button_FromTimestamp
        '
        Me.Button_FromTimestamp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_FromTimestamp.Location = New System.Drawing.Point(459, 2)
        Me.Button_FromTimestamp.Name = "Button_FromTimestamp"
        Me.Button_FromTimestamp.Size = New System.Drawing.Size(59, 22)
        Me.Button_FromTimestamp.TabIndex = 13
        Me.Button_FromTimestamp.Text = "x_Stamp"
        Me.Button_FromTimestamp.UseVisualStyleBackColor = True
        '
        'Panel_Relations
        '
        Me.Panel_Relations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Relations.Location = New System.Drawing.Point(80, 312)
        Me.Panel_Relations.Name = "Panel_Relations"
        Me.Panel_Relations.Size = New System.Drawing.Size(438, 100)
        Me.Panel_Relations.TabIndex = 14
        '
        'Label_Relations
        '
        Me.Label_Relations.AutoSize = True
        Me.Label_Relations.Location = New System.Drawing.Point(4, 312)
        Me.Label_Relations.Name = "Label_Relations"
        Me.Label_Relations.Size = New System.Drawing.Size(65, 13)
        Me.Label_Relations.TabIndex = 15
        Me.Label_Relations.Text = "x_Relations:"
        '
        'Timer_Caption
        '
        Me.Timer_Caption.Interval = 300
        '
        'Timer_Message
        '
        Me.Timer_Message.Interval = 300
        '
        'UserControl_Logentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label_Relations)
        Me.Controls.Add(Me.Panel_Relations)
        Me.Controls.Add(Me.Button_FromTimestamp)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ComboBox_User)
        Me.Controls.Add(Me.Label_User)
        Me.Controls.Add(Me.ComboBox_Logstate)
        Me.Controls.Add(Me.Label_Logstate)
        Me.Controls.Add(Me.TextBox_Message)
        Me.Controls.Add(Me.Label_Message)
        Me.Controls.Add(Me.DateTimePicker_DateTimeStamp)
        Me.Controls.Add(Me.Label_DateTimeStamp)
        Me.Controls.Add(Me.TextBox_Caption)
        Me.Controls.Add(Me.Label_Name)
        Me.Name = "UserControl_Logentry"
        Me.Size = New System.Drawing.Size(530, 443)
        Me.ContextMenuStrip_LogState.ResumeLayout(False)
        Me.ContextMenuStrip_User.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Name As System.Windows.Forms.Label
    Friend WithEvents TextBox_Caption As System.Windows.Forms.TextBox
    Friend WithEvents Label_DateTimeStamp As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_DateTimeStamp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_Message As System.Windows.Forms.Label
    Friend WithEvents TextBox_Message As System.Windows.Forms.TextBox
    Friend WithEvents Label_Logstate As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Logstate As System.Windows.Forms.ComboBox
    Friend WithEvents Label_User As System.Windows.Forms.Label
    Friend WithEvents ComboBox_User As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripProgressBar_Data As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Timer_Data As System.Windows.Forms.Timer
    Friend WithEvents Button_FromTimestamp As System.Windows.Forms.Button
    Friend WithEvents Panel_Relations As System.Windows.Forms.Panel
    Friend WithEvents Label_Relations As System.Windows.Forms.Label
    Friend WithEvents Timer_Caption As System.Windows.Forms.Timer
    Friend WithEvents Timer_Message As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip_LogState As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LogStateStandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_User As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UserStandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_UserLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton_User As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_LogStateLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton_LogState As System.Windows.Forms.ToolStripButton
    Friend WithEvents LogStateOpenTokenEditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserOpenTokenEditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
