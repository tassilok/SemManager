<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_PersonalData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_PersonalData))
        Me.Label_Vorname = New System.Windows.Forms.Label()
        Me.TextBox_Vorname = New System.Windows.Forms.TextBox()
        Me.ComboBox_Geschlecht = New System.Windows.Forms.ComboBox()
        Me.Label_Geschlecht = New System.Windows.Forms.Label()
        Me.Label_Nachname = New System.Windows.Forms.Label()
        Me.TextBox_Nachname = New System.Windows.Forms.TextBox()
        Me.Label_Familienstand = New System.Windows.Forms.Label()
        Me.ComboBox_Familienstand = New System.Windows.Forms.ComboBox()
        Me.Label_Geburtsdatum = New System.Windows.Forms.Label()
        Me.Button_Geburtsdatum = New System.Windows.Forms.Button()
        Me.MaskedTextBox_Geburtsdatum = New System.Windows.Forms.MaskedTextBox()
        Me.Label_Sozialversicherungsnummer = New System.Windows.Forms.Label()
        Me.TextBox_Sozialversicherungsnummer = New System.Windows.Forms.TextBox()
        Me.Label_eTin = New System.Windows.Forms.Label()
        Me.TextBox_eTin = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripProgressBar_Data = New System.Windows.Forms.ToolStripProgressBar()
        Me.Timer_Data = New System.Windows.Forms.Timer(Me.components)
        Me.Label_Identifikationsnummer = New System.Windows.Forms.Label()
        Me.TextBox_Identifikationsnummer = New System.Windows.Forms.TextBox()
        Me.Label_Steuernummer = New System.Windows.Forms.Label()
        Me.TextBox_Steuernummer = New System.Windows.Forms.TextBox()
        Me.Timer_Vorname = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Nachname = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Geburtsdatum = New System.Windows.Forms.Timer(Me.components)
        Me.Button_Sozialversicherungsnummer = New System.Windows.Forms.Button()
        Me.Button_eTin = New System.Windows.Forms.Button()
        Me.Button_INr = New System.Windows.Forms.Button()
        Me.Button_Steuernummer = New System.Windows.Forms.Button()
        Me.Button_Del_Steuernummer = New System.Windows.Forms.Button()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.Button_Del_INr = New System.Windows.Forms.Button()
        Me.Button_Del_eTin = New System.Windows.Forms.Button()
        Me.Button_Del_Sozialversicherungsnummer = New System.Windows.Forms.Button()
        Me.Button_Del_Geburtsdatum = New System.Windows.Forms.Button()
        Me.Button_Del_Todesdatum = New System.Windows.Forms.Button()
        Me.MaskedTextBox_Todesdatum = New System.Windows.Forms.MaskedTextBox()
        Me.Button_Todesdatum = New System.Windows.Forms.Button()
        Me.Label_Todesdatum = New System.Windows.Forms.Label()
        Me.Panel_Foto = New System.Windows.Forms.Panel()
        Me.Button_DelPhoto = New System.Windows.Forms.Button()
        Me.Button_AddImageExisting = New System.Windows.Forms.Button()
        Me.Button_AddImageNew = New System.Windows.Forms.Button()
        Me.Label_Photo = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Vorname
        '
        Me.Label_Vorname.AutoSize = True
        Me.Label_Vorname.Location = New System.Drawing.Point(12, 11)
        Me.Label_Vorname.Name = "Label_Vorname"
        Me.Label_Vorname.Size = New System.Drawing.Size(63, 13)
        Me.Label_Vorname.TabIndex = 0
        Me.Label_Vorname.Text = "x_Vorname:"
        '
        'TextBox_Vorname
        '
        Me.TextBox_Vorname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Vorname.Location = New System.Drawing.Point(165, 8)
        Me.TextBox_Vorname.Name = "TextBox_Vorname"
        Me.TextBox_Vorname.Size = New System.Drawing.Size(290, 20)
        Me.TextBox_Vorname.TabIndex = 1
        '
        'ComboBox_Geschlecht
        '
        Me.ComboBox_Geschlecht.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Geschlecht.FormattingEnabled = True
        Me.ComboBox_Geschlecht.Location = New System.Drawing.Point(165, 62)
        Me.ComboBox_Geschlecht.Name = "ComboBox_Geschlecht"
        Me.ComboBox_Geschlecht.Size = New System.Drawing.Size(290, 21)
        Me.ComboBox_Geschlecht.TabIndex = 2
        '
        'Label_Geschlecht
        '
        Me.Label_Geschlecht.AutoSize = True
        Me.Label_Geschlecht.Location = New System.Drawing.Point(12, 65)
        Me.Label_Geschlecht.Name = "Label_Geschlecht"
        Me.Label_Geschlecht.Size = New System.Drawing.Size(75, 13)
        Me.Label_Geschlecht.TabIndex = 3
        Me.Label_Geschlecht.Text = "x_Geschlecht:"
        '
        'Label_Nachname
        '
        Me.Label_Nachname.AutoSize = True
        Me.Label_Nachname.Location = New System.Drawing.Point(12, 38)
        Me.Label_Nachname.Name = "Label_Nachname"
        Me.Label_Nachname.Size = New System.Drawing.Size(73, 13)
        Me.Label_Nachname.TabIndex = 4
        Me.Label_Nachname.Text = "x_Nachname:"
        '
        'TextBox_Nachname
        '
        Me.TextBox_Nachname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Nachname.Location = New System.Drawing.Point(165, 35)
        Me.TextBox_Nachname.Name = "TextBox_Nachname"
        Me.TextBox_Nachname.Size = New System.Drawing.Size(290, 20)
        Me.TextBox_Nachname.TabIndex = 5
        '
        'Label_Familienstand
        '
        Me.Label_Familienstand.AutoSize = True
        Me.Label_Familienstand.Location = New System.Drawing.Point(12, 92)
        Me.Label_Familienstand.Name = "Label_Familienstand"
        Me.Label_Familienstand.Size = New System.Drawing.Size(85, 13)
        Me.Label_Familienstand.TabIndex = 6
        Me.Label_Familienstand.Text = "x_Familienstand:"
        '
        'ComboBox_Familienstand
        '
        Me.ComboBox_Familienstand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Familienstand.FormattingEnabled = True
        Me.ComboBox_Familienstand.Location = New System.Drawing.Point(165, 89)
        Me.ComboBox_Familienstand.Name = "ComboBox_Familienstand"
        Me.ComboBox_Familienstand.Size = New System.Drawing.Size(290, 21)
        Me.ComboBox_Familienstand.TabIndex = 7
        '
        'Label_Geburtsdatum
        '
        Me.Label_Geburtsdatum.AutoSize = True
        Me.Label_Geburtsdatum.Location = New System.Drawing.Point(12, 122)
        Me.Label_Geburtsdatum.Name = "Label_Geburtsdatum"
        Me.Label_Geburtsdatum.Size = New System.Drawing.Size(87, 13)
        Me.Label_Geburtsdatum.TabIndex = 8
        Me.Label_Geburtsdatum.Text = "x_Geburtsdatum:"
        '
        'Button_Geburtsdatum
        '
        Me.Button_Geburtsdatum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Geburtsdatum.Location = New System.Drawing.Point(396, 117)
        Me.Button_Geburtsdatum.Name = "Button_Geburtsdatum"
        Me.Button_Geburtsdatum.Size = New System.Drawing.Size(29, 23)
        Me.Button_Geburtsdatum.TabIndex = 10
        Me.Button_Geburtsdatum.Text = "..."
        Me.Button_Geburtsdatum.UseVisualStyleBackColor = True
        '
        'MaskedTextBox_Geburtsdatum
        '
        Me.MaskedTextBox_Geburtsdatum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox_Geburtsdatum.Location = New System.Drawing.Point(165, 119)
        Me.MaskedTextBox_Geburtsdatum.Mask = "00/00/0000"
        Me.MaskedTextBox_Geburtsdatum.Name = "MaskedTextBox_Geburtsdatum"
        Me.MaskedTextBox_Geburtsdatum.ReadOnly = True
        Me.MaskedTextBox_Geburtsdatum.Size = New System.Drawing.Size(225, 20)
        Me.MaskedTextBox_Geburtsdatum.TabIndex = 11
        Me.MaskedTextBox_Geburtsdatum.ValidatingType = GetType(Date)
        '
        'Label_Sozialversicherungsnummer
        '
        Me.Label_Sozialversicherungsnummer.AutoSize = True
        Me.Label_Sozialversicherungsnummer.Location = New System.Drawing.Point(12, 174)
        Me.Label_Sozialversicherungsnummer.Name = "Label_Sozialversicherungsnummer"
        Me.Label_Sozialversicherungsnummer.Size = New System.Drawing.Size(152, 13)
        Me.Label_Sozialversicherungsnummer.TabIndex = 12
        Me.Label_Sozialversicherungsnummer.Text = "x_Sozialversicherungsnummer:"
        '
        'TextBox_Sozialversicherungsnummer
        '
        Me.TextBox_Sozialversicherungsnummer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Sozialversicherungsnummer.Location = New System.Drawing.Point(165, 170)
        Me.TextBox_Sozialversicherungsnummer.Name = "TextBox_Sozialversicherungsnummer"
        Me.TextBox_Sozialversicherungsnummer.ReadOnly = True
        Me.TextBox_Sozialversicherungsnummer.Size = New System.Drawing.Size(225, 20)
        Me.TextBox_Sozialversicherungsnummer.TabIndex = 13
        '
        'Label_eTin
        '
        Me.Label_eTin.AutoSize = True
        Me.Label_eTin.Location = New System.Drawing.Point(12, 200)
        Me.Label_eTin.Name = "Label_eTin"
        Me.Label_eTin.Size = New System.Drawing.Size(31, 13)
        Me.Label_eTin.TabIndex = 14
        Me.Label_eTin.Text = "eTin:"
        '
        'TextBox_eTin
        '
        Me.TextBox_eTin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_eTin.Location = New System.Drawing.Point(165, 197)
        Me.TextBox_eTin.Name = "TextBox_eTin"
        Me.TextBox_eTin.ReadOnly = True
        Me.TextBox_eTin.Size = New System.Drawing.Size(225, 20)
        Me.TextBox_eTin.TabIndex = 15
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar_Data})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 458)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(458, 25)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripProgressBar_Data
        '
        Me.ToolStripProgressBar_Data.Maximum = 10
        Me.ToolStripProgressBar_Data.Name = "ToolStripProgressBar_Data"
        Me.ToolStripProgressBar_Data.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripProgressBar_Data.Step = 1
        '
        'Timer_Data
        '
        Me.Timer_Data.Interval = 300
        '
        'Label_Identifikationsnummer
        '
        Me.Label_Identifikationsnummer.AutoSize = True
        Me.Label_Identifikationsnummer.Location = New System.Drawing.Point(12, 225)
        Me.Label_Identifikationsnummer.Name = "Label_Identifikationsnummer"
        Me.Label_Identifikationsnummer.Size = New System.Drawing.Size(143, 13)
        Me.Label_Identifikationsnummer.TabIndex = 17
        Me.Label_Identifikationsnummer.Text = "x_Identifikationsnummer(INr):"
        '
        'TextBox_Identifikationsnummer
        '
        Me.TextBox_Identifikationsnummer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Identifikationsnummer.Location = New System.Drawing.Point(165, 222)
        Me.TextBox_Identifikationsnummer.Name = "TextBox_Identifikationsnummer"
        Me.TextBox_Identifikationsnummer.ReadOnly = True
        Me.TextBox_Identifikationsnummer.Size = New System.Drawing.Size(225, 20)
        Me.TextBox_Identifikationsnummer.TabIndex = 18
        '
        'Label_Steuernummer
        '
        Me.Label_Steuernummer.AutoSize = True
        Me.Label_Steuernummer.Location = New System.Drawing.Point(12, 251)
        Me.Label_Steuernummer.Name = "Label_Steuernummer"
        Me.Label_Steuernummer.Size = New System.Drawing.Size(89, 13)
        Me.Label_Steuernummer.TabIndex = 19
        Me.Label_Steuernummer.Text = "x_Steuernummer:"
        '
        'TextBox_Steuernummer
        '
        Me.TextBox_Steuernummer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Steuernummer.Location = New System.Drawing.Point(165, 248)
        Me.TextBox_Steuernummer.Name = "TextBox_Steuernummer"
        Me.TextBox_Steuernummer.ReadOnly = True
        Me.TextBox_Steuernummer.Size = New System.Drawing.Size(225, 20)
        Me.TextBox_Steuernummer.TabIndex = 20
        '
        'Timer_Vorname
        '
        Me.Timer_Vorname.Interval = 300
        '
        'Timer_Nachname
        '
        Me.Timer_Nachname.Interval = 300
        '
        'Timer_Geburtsdatum
        '
        Me.Timer_Geburtsdatum.Interval = 300
        '
        'Button_Sozialversicherungsnummer
        '
        Me.Button_Sozialversicherungsnummer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Sozialversicherungsnummer.Location = New System.Drawing.Point(396, 168)
        Me.Button_Sozialversicherungsnummer.Name = "Button_Sozialversicherungsnummer"
        Me.Button_Sozialversicherungsnummer.Size = New System.Drawing.Size(29, 23)
        Me.Button_Sozialversicherungsnummer.TabIndex = 21
        Me.Button_Sozialversicherungsnummer.Text = "..."
        Me.Button_Sozialversicherungsnummer.UseVisualStyleBackColor = True
        '
        'Button_eTin
        '
        Me.Button_eTin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_eTin.Location = New System.Drawing.Point(396, 195)
        Me.Button_eTin.Name = "Button_eTin"
        Me.Button_eTin.Size = New System.Drawing.Size(29, 23)
        Me.Button_eTin.TabIndex = 22
        Me.Button_eTin.Text = "..."
        Me.Button_eTin.UseVisualStyleBackColor = True
        '
        'Button_INr
        '
        Me.Button_INr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_INr.Location = New System.Drawing.Point(396, 220)
        Me.Button_INr.Name = "Button_INr"
        Me.Button_INr.Size = New System.Drawing.Size(29, 23)
        Me.Button_INr.TabIndex = 23
        Me.Button_INr.Text = "..."
        Me.Button_INr.UseVisualStyleBackColor = True
        '
        'Button_Steuernummer
        '
        Me.Button_Steuernummer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Steuernummer.Location = New System.Drawing.Point(396, 246)
        Me.Button_Steuernummer.Name = "Button_Steuernummer"
        Me.Button_Steuernummer.Size = New System.Drawing.Size(29, 23)
        Me.Button_Steuernummer.TabIndex = 24
        Me.Button_Steuernummer.Text = "..."
        Me.Button_Steuernummer.UseVisualStyleBackColor = True
        '
        'Button_Del_Steuernummer
        '
        Me.Button_Del_Steuernummer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Del_Steuernummer.ImageIndex = 0
        Me.Button_Del_Steuernummer.ImageList = Me.ImageList_Main
        Me.Button_Del_Steuernummer.Location = New System.Drawing.Point(426, 246)
        Me.Button_Del_Steuernummer.Name = "Button_Del_Steuernummer"
        Me.Button_Del_Steuernummer.Size = New System.Drawing.Size(29, 23)
        Me.Button_Del_Steuernummer.TabIndex = 29
        Me.Button_Del_Steuernummer.UseVisualStyleBackColor = True
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ImageStream = CType(resources.GetObject("ImageList_Main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Main.Images.SetKeyName(0, "delete.png")
        Me.ImageList_Main.Images.SetKeyName(1, "b_plus.png")
        '
        'Button_Del_INr
        '
        Me.Button_Del_INr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Del_INr.ImageIndex = 0
        Me.Button_Del_INr.ImageList = Me.ImageList_Main
        Me.Button_Del_INr.Location = New System.Drawing.Point(426, 220)
        Me.Button_Del_INr.Name = "Button_Del_INr"
        Me.Button_Del_INr.Size = New System.Drawing.Size(29, 23)
        Me.Button_Del_INr.TabIndex = 28
        Me.Button_Del_INr.UseVisualStyleBackColor = True
        '
        'Button_Del_eTin
        '
        Me.Button_Del_eTin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Del_eTin.ImageIndex = 0
        Me.Button_Del_eTin.ImageList = Me.ImageList_Main
        Me.Button_Del_eTin.Location = New System.Drawing.Point(426, 195)
        Me.Button_Del_eTin.Name = "Button_Del_eTin"
        Me.Button_Del_eTin.Size = New System.Drawing.Size(29, 23)
        Me.Button_Del_eTin.TabIndex = 27
        Me.Button_Del_eTin.UseVisualStyleBackColor = True
        '
        'Button_Del_Sozialversicherungsnummer
        '
        Me.Button_Del_Sozialversicherungsnummer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Del_Sozialversicherungsnummer.ImageIndex = 0
        Me.Button_Del_Sozialversicherungsnummer.ImageList = Me.ImageList_Main
        Me.Button_Del_Sozialversicherungsnummer.Location = New System.Drawing.Point(426, 168)
        Me.Button_Del_Sozialversicherungsnummer.Name = "Button_Del_Sozialversicherungsnummer"
        Me.Button_Del_Sozialversicherungsnummer.Size = New System.Drawing.Size(29, 23)
        Me.Button_Del_Sozialversicherungsnummer.TabIndex = 26
        Me.Button_Del_Sozialversicherungsnummer.UseVisualStyleBackColor = True
        '
        'Button_Del_Geburtsdatum
        '
        Me.Button_Del_Geburtsdatum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Del_Geburtsdatum.ImageIndex = 0
        Me.Button_Del_Geburtsdatum.ImageList = Me.ImageList_Main
        Me.Button_Del_Geburtsdatum.Location = New System.Drawing.Point(426, 117)
        Me.Button_Del_Geburtsdatum.Name = "Button_Del_Geburtsdatum"
        Me.Button_Del_Geburtsdatum.Size = New System.Drawing.Size(29, 23)
        Me.Button_Del_Geburtsdatum.TabIndex = 25
        Me.Button_Del_Geburtsdatum.UseVisualStyleBackColor = True
        '
        'Button_Del_Todesdatum
        '
        Me.Button_Del_Todesdatum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Del_Todesdatum.ImageIndex = 0
        Me.Button_Del_Todesdatum.ImageList = Me.ImageList_Main
        Me.Button_Del_Todesdatum.Location = New System.Drawing.Point(426, 143)
        Me.Button_Del_Todesdatum.Name = "Button_Del_Todesdatum"
        Me.Button_Del_Todesdatum.Size = New System.Drawing.Size(29, 23)
        Me.Button_Del_Todesdatum.TabIndex = 33
        Me.Button_Del_Todesdatum.UseVisualStyleBackColor = True
        '
        'MaskedTextBox_Todesdatum
        '
        Me.MaskedTextBox_Todesdatum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox_Todesdatum.Location = New System.Drawing.Point(165, 145)
        Me.MaskedTextBox_Todesdatum.Mask = "00/00/0000"
        Me.MaskedTextBox_Todesdatum.Name = "MaskedTextBox_Todesdatum"
        Me.MaskedTextBox_Todesdatum.ReadOnly = True
        Me.MaskedTextBox_Todesdatum.Size = New System.Drawing.Size(225, 20)
        Me.MaskedTextBox_Todesdatum.TabIndex = 32
        Me.MaskedTextBox_Todesdatum.ValidatingType = GetType(Date)
        '
        'Button_Todesdatum
        '
        Me.Button_Todesdatum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Todesdatum.Location = New System.Drawing.Point(396, 143)
        Me.Button_Todesdatum.Name = "Button_Todesdatum"
        Me.Button_Todesdatum.Size = New System.Drawing.Size(29, 23)
        Me.Button_Todesdatum.TabIndex = 31
        Me.Button_Todesdatum.Text = "..."
        Me.Button_Todesdatum.UseVisualStyleBackColor = True
        '
        'Label_Todesdatum
        '
        Me.Label_Todesdatum.AutoSize = True
        Me.Label_Todesdatum.Location = New System.Drawing.Point(12, 148)
        Me.Label_Todesdatum.Name = "Label_Todesdatum"
        Me.Label_Todesdatum.Size = New System.Drawing.Size(80, 13)
        Me.Label_Todesdatum.TabIndex = 30
        Me.Label_Todesdatum.Text = "x_Todesdatum:"
        '
        'Panel_Foto
        '
        Me.Panel_Foto.Location = New System.Drawing.Point(165, 274)
        Me.Panel_Foto.Name = "Panel_Foto"
        Me.Panel_Foto.Size = New System.Drawing.Size(117, 167)
        Me.Panel_Foto.TabIndex = 34
        '
        'Button_DelPhoto
        '
        Me.Button_DelPhoto.ImageIndex = 0
        Me.Button_DelPhoto.ImageList = Me.ImageList_Main
        Me.Button_DelPhoto.Location = New System.Drawing.Point(323, 274)
        Me.Button_DelPhoto.Name = "Button_DelPhoto"
        Me.Button_DelPhoto.Size = New System.Drawing.Size(29, 23)
        Me.Button_DelPhoto.TabIndex = 36
        Me.Button_DelPhoto.UseVisualStyleBackColor = True
        '
        'Button_AddImageExisting
        '
        Me.Button_AddImageExisting.Location = New System.Drawing.Point(288, 303)
        Me.Button_AddImageExisting.Name = "Button_AddImageExisting"
        Me.Button_AddImageExisting.Size = New System.Drawing.Size(29, 23)
        Me.Button_AddImageExisting.TabIndex = 35
        Me.Button_AddImageExisting.Text = "..."
        Me.Button_AddImageExisting.UseVisualStyleBackColor = True
        '
        'Button_AddImageNew
        '
        Me.Button_AddImageNew.ImageIndex = 1
        Me.Button_AddImageNew.ImageList = Me.ImageList_Main
        Me.Button_AddImageNew.Location = New System.Drawing.Point(288, 274)
        Me.Button_AddImageNew.Name = "Button_AddImageNew"
        Me.Button_AddImageNew.Size = New System.Drawing.Size(29, 23)
        Me.Button_AddImageNew.TabIndex = 37
        Me.Button_AddImageNew.UseVisualStyleBackColor = True
        '
        'Label_Photo
        '
        Me.Label_Photo.AutoSize = True
        Me.Label_Photo.Location = New System.Drawing.Point(15, 274)
        Me.Label_Photo.Name = "Label_Photo"
        Me.Label_Photo.Size = New System.Drawing.Size(42, 13)
        Me.Label_Photo.TabIndex = 38
        Me.Label_Photo.Text = "x_Foto:"
        '
        'UserControl_PersonalData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label_Photo)
        Me.Controls.Add(Me.Button_AddImageNew)
        Me.Controls.Add(Me.Button_DelPhoto)
        Me.Controls.Add(Me.Button_AddImageExisting)
        Me.Controls.Add(Me.Panel_Foto)
        Me.Controls.Add(Me.Button_Del_Todesdatum)
        Me.Controls.Add(Me.MaskedTextBox_Todesdatum)
        Me.Controls.Add(Me.Button_Todesdatum)
        Me.Controls.Add(Me.Label_Todesdatum)
        Me.Controls.Add(Me.Button_Del_Steuernummer)
        Me.Controls.Add(Me.Button_Del_INr)
        Me.Controls.Add(Me.Button_Del_eTin)
        Me.Controls.Add(Me.Button_Del_Sozialversicherungsnummer)
        Me.Controls.Add(Me.Button_Del_Geburtsdatum)
        Me.Controls.Add(Me.Button_Steuernummer)
        Me.Controls.Add(Me.Button_INr)
        Me.Controls.Add(Me.Button_eTin)
        Me.Controls.Add(Me.Button_Sozialversicherungsnummer)
        Me.Controls.Add(Me.TextBox_Steuernummer)
        Me.Controls.Add(Me.Label_Steuernummer)
        Me.Controls.Add(Me.TextBox_Identifikationsnummer)
        Me.Controls.Add(Me.Label_Identifikationsnummer)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TextBox_eTin)
        Me.Controls.Add(Me.Label_eTin)
        Me.Controls.Add(Me.TextBox_Sozialversicherungsnummer)
        Me.Controls.Add(Me.Label_Sozialversicherungsnummer)
        Me.Controls.Add(Me.MaskedTextBox_Geburtsdatum)
        Me.Controls.Add(Me.Button_Geburtsdatum)
        Me.Controls.Add(Me.Label_Geburtsdatum)
        Me.Controls.Add(Me.ComboBox_Familienstand)
        Me.Controls.Add(Me.Label_Familienstand)
        Me.Controls.Add(Me.TextBox_Nachname)
        Me.Controls.Add(Me.Label_Nachname)
        Me.Controls.Add(Me.Label_Geschlecht)
        Me.Controls.Add(Me.ComboBox_Geschlecht)
        Me.Controls.Add(Me.TextBox_Vorname)
        Me.Controls.Add(Me.Label_Vorname)
        Me.Name = "UserControl_PersonalData"
        Me.Size = New System.Drawing.Size(458, 483)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Vorname As System.Windows.Forms.Label
    Friend WithEvents TextBox_Vorname As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_Geschlecht As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Geschlecht As System.Windows.Forms.Label
    Friend WithEvents Label_Nachname As System.Windows.Forms.Label
    Friend WithEvents TextBox_Nachname As System.Windows.Forms.TextBox
    Friend WithEvents Label_Familienstand As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Familienstand As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Geburtsdatum As System.Windows.Forms.Label
    Friend WithEvents Button_Geburtsdatum As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox_Geburtsdatum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label_Sozialversicherungsnummer As System.Windows.Forms.Label
    Friend WithEvents TextBox_Sozialversicherungsnummer As System.Windows.Forms.TextBox
    Friend WithEvents Label_eTin As System.Windows.Forms.Label
    Friend WithEvents TextBox_eTin As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripProgressBar_Data As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Timer_Data As System.Windows.Forms.Timer
    Friend WithEvents Label_Identifikationsnummer As System.Windows.Forms.Label
    Friend WithEvents TextBox_Identifikationsnummer As System.Windows.Forms.TextBox
    Friend WithEvents Label_Steuernummer As System.Windows.Forms.Label
    Friend WithEvents TextBox_Steuernummer As System.Windows.Forms.TextBox
    Friend WithEvents Timer_Vorname As System.Windows.Forms.Timer
    Friend WithEvents Timer_Nachname As System.Windows.Forms.Timer
    Friend WithEvents Timer_Geburtsdatum As System.Windows.Forms.Timer
    Friend WithEvents Button_Sozialversicherungsnummer As System.Windows.Forms.Button
    Friend WithEvents Button_eTin As System.Windows.Forms.Button
    Friend WithEvents Button_INr As System.Windows.Forms.Button
    Friend WithEvents Button_Steuernummer As System.Windows.Forms.Button
    Friend WithEvents Button_Del_Steuernummer As System.Windows.Forms.Button
    Friend WithEvents Button_Del_INr As System.Windows.Forms.Button
    Friend WithEvents Button_Del_eTin As System.Windows.Forms.Button
    Friend WithEvents Button_Del_Sozialversicherungsnummer As System.Windows.Forms.Button
    Friend WithEvents Button_Del_Geburtsdatum As System.Windows.Forms.Button
    Friend WithEvents ImageList_Main As System.Windows.Forms.ImageList
    Friend WithEvents Button_Del_Todesdatum As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox_Todesdatum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button_Todesdatum As System.Windows.Forms.Button
    Friend WithEvents Label_Todesdatum As System.Windows.Forms.Label
    Friend WithEvents Panel_Foto As System.Windows.Forms.Panel
    Friend WithEvents Button_DelPhoto As System.Windows.Forms.Button
    Friend WithEvents Button_AddImageExisting As System.Windows.Forms.Button
    Friend WithEvents Button_AddImageNew As System.Windows.Forms.Button
    Friend WithEvents Label_Photo As System.Windows.Forms.Label

End Class
