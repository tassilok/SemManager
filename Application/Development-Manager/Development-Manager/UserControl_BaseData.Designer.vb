<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_BaseData
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label_Development = New System.Windows.Forms.Label
        Me.Panel_Languages = New System.Windows.Forms.Panel
        Me.Label_Languages = New System.Windows.Forms.Label
        Me.Button_LanguageStandard = New System.Windows.Forms.Button
        Me.Label_StandarLanguage = New System.Windows.Forms.Label
        Me.TextBox_LanguageStandard = New System.Windows.Forms.TextBox
        Me.Button_FolderSourceCode = New System.Windows.Forms.Button
        Me.Label_FolderSourceCode = New System.Windows.Forms.Label
        Me.TextBox_FolderSourceCode = New System.Windows.Forms.TextBox
        Me.Button_PLanguage = New System.Windows.Forms.Button
        Me.Label_PLanguage = New System.Windows.Forms.Label
        Me.TextBox_PLanguage = New System.Windows.Forms.TextBox
        Me.Button_Creator = New System.Windows.Forms.Button
        Me.Label_Creator = New System.Windows.Forms.Label
        Me.TextBox_Creator = New System.Windows.Forms.TextBox
        Me.Button_Version = New System.Windows.Forms.Button
        Me.Label_Version = New System.Windows.Forms.Label
        Me.TextBox_Version = New System.Windows.Forms.TextBox
        Me.ComboBox_State = New System.Windows.Forms.ComboBox
        Me.Label_State = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_Development)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel_Languages)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_Languages)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_LanguageStandard)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_StandarLanguage)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_LanguageStandard)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_FolderSourceCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_FolderSourceCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_FolderSourceCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_PLanguage)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_PLanguage)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_PLanguage)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_Creator)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_Creator)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_Creator)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_Version)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_Version)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_Version)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBox_State)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_State)
        Me.SplitContainer1.Size = New System.Drawing.Size(544, 508)
        Me.SplitContainer1.SplitterDistance = 332
        Me.SplitContainer1.TabIndex = 0
        '
        'Label_Development
        '
        Me.Label_Development.AutoSize = True
        Me.Label_Development.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Development.Location = New System.Drawing.Point(12, 9)
        Me.Label_Development.Name = "Label_Development"
        Me.Label_Development.Size = New System.Drawing.Size(13, 16)
        Me.Label_Development.TabIndex = 38
        Me.Label_Development.Text = "-"
        '
        'Panel_Languages
        '
        Me.Panel_Languages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Languages.Location = New System.Drawing.Point(107, 195)
        Me.Panel_Languages.Name = "Panel_Languages"
        Me.Panel_Languages.Size = New System.Drawing.Size(430, 130)
        Me.Panel_Languages.TabIndex = 37
        '
        'Label_Languages
        '
        Me.Label_Languages.AutoSize = True
        Me.Label_Languages.Location = New System.Drawing.Point(12, 195)
        Me.Label_Languages.Name = "Label_Languages"
        Me.Label_Languages.Size = New System.Drawing.Size(72, 26)
        Me.Label_Languages.TabIndex = 36
        Me.Label_Languages.Text = "Additional " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Languages_f:"
        '
        'Button_LanguageStandard
        '
        Me.Button_LanguageStandard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_LanguageStandard.Location = New System.Drawing.Point(510, 165)
        Me.Button_LanguageStandard.Name = "Button_LanguageStandard"
        Me.Button_LanguageStandard.Size = New System.Drawing.Size(27, 23)
        Me.Button_LanguageStandard.TabIndex = 35
        Me.Button_LanguageStandard.Text = "..."
        Me.Button_LanguageStandard.UseVisualStyleBackColor = True
        '
        'Label_StandarLanguage
        '
        Me.Label_StandarLanguage.AutoSize = True
        Me.Label_StandarLanguage.Location = New System.Drawing.Point(12, 170)
        Me.Label_StandarLanguage.Name = "Label_StandarLanguage"
        Me.Label_StandarLanguage.Size = New System.Drawing.Size(89, 13)
        Me.Label_StandarLanguage.TabIndex = 34
        Me.Label_StandarLanguage.Text = "Std.-Language_f:"
        '
        'TextBox_LanguageStandard
        '
        Me.TextBox_LanguageStandard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_LanguageStandard.Location = New System.Drawing.Point(107, 167)
        Me.TextBox_LanguageStandard.Name = "TextBox_LanguageStandard"
        Me.TextBox_LanguageStandard.ReadOnly = True
        Me.TextBox_LanguageStandard.Size = New System.Drawing.Size(397, 20)
        Me.TextBox_LanguageStandard.TabIndex = 33
        '
        'Button_FolderSourceCode
        '
        Me.Button_FolderSourceCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_FolderSourceCode.Location = New System.Drawing.Point(510, 139)
        Me.Button_FolderSourceCode.Name = "Button_FolderSourceCode"
        Me.Button_FolderSourceCode.Size = New System.Drawing.Size(27, 23)
        Me.Button_FolderSourceCode.TabIndex = 32
        Me.Button_FolderSourceCode.Text = "..."
        Me.Button_FolderSourceCode.UseVisualStyleBackColor = True
        '
        'Label_FolderSourceCode
        '
        Me.Label_FolderSourceCode.AutoSize = True
        Me.Label_FolderSourceCode.Location = New System.Drawing.Point(12, 144)
        Me.Label_FolderSourceCode.Name = "Label_FolderSourceCode"
        Me.Label_FolderSourceCode.Size = New System.Drawing.Size(48, 13)
        Me.Label_FolderSourceCode.TabIndex = 31
        Me.Label_FolderSourceCode.Text = "Folder_f:"
        '
        'TextBox_FolderSourceCode
        '
        Me.TextBox_FolderSourceCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_FolderSourceCode.Location = New System.Drawing.Point(107, 141)
        Me.TextBox_FolderSourceCode.Name = "TextBox_FolderSourceCode"
        Me.TextBox_FolderSourceCode.ReadOnly = True
        Me.TextBox_FolderSourceCode.Size = New System.Drawing.Size(397, 20)
        Me.TextBox_FolderSourceCode.TabIndex = 30
        '
        'Button_PLanguage
        '
        Me.Button_PLanguage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_PLanguage.Location = New System.Drawing.Point(510, 113)
        Me.Button_PLanguage.Name = "Button_PLanguage"
        Me.Button_PLanguage.Size = New System.Drawing.Size(27, 23)
        Me.Button_PLanguage.TabIndex = 29
        Me.Button_PLanguage.Text = "..."
        Me.Button_PLanguage.UseVisualStyleBackColor = True
        '
        'Label_PLanguage
        '
        Me.Label_PLanguage.AutoSize = True
        Me.Label_PLanguage.Location = New System.Drawing.Point(12, 118)
        Me.Label_PLanguage.Name = "Label_PLanguage"
        Me.Label_PLanguage.Size = New System.Drawing.Size(80, 13)
        Me.Label_PLanguage.TabIndex = 28
        Me.Label_PLanguage.Text = "P.-Language_f:"
        '
        'TextBox_PLanguage
        '
        Me.TextBox_PLanguage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_PLanguage.Location = New System.Drawing.Point(107, 115)
        Me.TextBox_PLanguage.Name = "TextBox_PLanguage"
        Me.TextBox_PLanguage.ReadOnly = True
        Me.TextBox_PLanguage.Size = New System.Drawing.Size(397, 20)
        Me.TextBox_PLanguage.TabIndex = 27
        '
        'Button_Creator
        '
        Me.Button_Creator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Creator.Location = New System.Drawing.Point(510, 86)
        Me.Button_Creator.Name = "Button_Creator"
        Me.Button_Creator.Size = New System.Drawing.Size(27, 23)
        Me.Button_Creator.TabIndex = 26
        Me.Button_Creator.Text = "..."
        Me.Button_Creator.UseVisualStyleBackColor = True
        '
        'Label_Creator
        '
        Me.Label_Creator.AutoSize = True
        Me.Label_Creator.Location = New System.Drawing.Point(12, 91)
        Me.Label_Creator.Name = "Label_Creator"
        Me.Label_Creator.Size = New System.Drawing.Size(53, 13)
        Me.Label_Creator.TabIndex = 25
        Me.Label_Creator.Text = "Creator_f:"
        '
        'TextBox_Creator
        '
        Me.TextBox_Creator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Creator.Location = New System.Drawing.Point(107, 88)
        Me.TextBox_Creator.Name = "TextBox_Creator"
        Me.TextBox_Creator.ReadOnly = True
        Me.TextBox_Creator.Size = New System.Drawing.Size(397, 20)
        Me.TextBox_Creator.TabIndex = 24
        '
        'Button_Version
        '
        Me.Button_Version.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Version.Location = New System.Drawing.Point(510, 59)
        Me.Button_Version.Name = "Button_Version"
        Me.Button_Version.Size = New System.Drawing.Size(27, 23)
        Me.Button_Version.TabIndex = 23
        Me.Button_Version.Text = "..."
        Me.Button_Version.UseVisualStyleBackColor = True
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Location = New System.Drawing.Point(12, 64)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(54, 13)
        Me.Label_Version.TabIndex = 22
        Me.Label_Version.Text = "Version_f:"
        '
        'TextBox_Version
        '
        Me.TextBox_Version.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Version.Location = New System.Drawing.Point(107, 61)
        Me.TextBox_Version.Name = "TextBox_Version"
        Me.TextBox_Version.ReadOnly = True
        Me.TextBox_Version.Size = New System.Drawing.Size(397, 20)
        Me.TextBox_Version.TabIndex = 21
        '
        'ComboBox_State
        '
        Me.ComboBox_State.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_State.FormattingEnabled = True
        Me.ComboBox_State.Location = New System.Drawing.Point(107, 33)
        Me.ComboBox_State.Name = "ComboBox_State"
        Me.ComboBox_State.Size = New System.Drawing.Size(397, 21)
        Me.ComboBox_State.TabIndex = 20
        '
        'Label_State
        '
        Me.Label_State.AutoSize = True
        Me.Label_State.Location = New System.Drawing.Point(12, 36)
        Me.Label_State.Name = "Label_State"
        Me.Label_State.Size = New System.Drawing.Size(44, 13)
        Me.Label_State.TabIndex = 19
        Me.Label_State.Text = "State_f:"
        '
        'UserControl_BaseData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_BaseData"
        Me.Size = New System.Drawing.Size(544, 508)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel_Languages As System.Windows.Forms.Panel
    Friend WithEvents Label_Languages As System.Windows.Forms.Label
    Friend WithEvents Button_LanguageStandard As System.Windows.Forms.Button
    Friend WithEvents Label_StandarLanguage As System.Windows.Forms.Label
    Friend WithEvents TextBox_LanguageStandard As System.Windows.Forms.TextBox
    Friend WithEvents Button_FolderSourceCode As System.Windows.Forms.Button
    Friend WithEvents Label_FolderSourceCode As System.Windows.Forms.Label
    Friend WithEvents TextBox_FolderSourceCode As System.Windows.Forms.TextBox
    Friend WithEvents Button_PLanguage As System.Windows.Forms.Button
    Friend WithEvents Label_PLanguage As System.Windows.Forms.Label
    Friend WithEvents TextBox_PLanguage As System.Windows.Forms.TextBox
    Friend WithEvents Button_Creator As System.Windows.Forms.Button
    Friend WithEvents Label_Creator As System.Windows.Forms.Label
    Friend WithEvents TextBox_Creator As System.Windows.Forms.TextBox
    Friend WithEvents Button_Version As System.Windows.Forms.Button
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents TextBox_Version As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_State As System.Windows.Forms.ComboBox
    Friend WithEvents Label_State As System.Windows.Forms.Label
    Friend WithEvents Label_Development As System.Windows.Forms.Label

End Class
