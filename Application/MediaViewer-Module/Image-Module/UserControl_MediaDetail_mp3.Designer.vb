<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_MediaDetail_MP3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_MediaDetail_MP3))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripProgressBar_Readed = New System.Windows.Forms.ToolStripProgressBar()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.Button_Year = New System.Windows.Forms.Button()
        Me.Label_min = New System.Windows.Forms.Label()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.TextBox_Title = New System.Windows.Forms.TextBox()
        Me.Label_Year = New System.Windows.Forms.Label()
        Me.TextBox_Year = New System.Windows.Forms.TextBox()
        Me.Button_Composer = New System.Windows.Forms.Button()
        Me.TextBox_Composer = New System.Windows.Forms.TextBox()
        Me.Label_Composer = New System.Windows.Forms.Label()
        Me.Button_Disk = New System.Windows.Forms.Button()
        Me.TextBox_Disk = New System.Windows.Forms.TextBox()
        Me.Label_Disk = New System.Windows.Forms.Label()
        Me.Button_Genre = New System.Windows.Forms.Button()
        Me.TextBox_Genre = New System.Windows.Forms.TextBox()
        Me.Label_Genre = New System.Windows.Forms.Label()
        Me.Button_Artist = New System.Windows.Forms.Button()
        Me.TextBox_Artist = New System.Windows.Forms.TextBox()
        Me.Label_Artist = New System.Windows.Forms.Label()
        Me.Button_Album = New System.Windows.Forms.Button()
        Me.Label_Album = New System.Windows.Forms.Label()
        Me.TextBox_Album = New System.Windows.Forms.TextBox()
        Me.Label_Length = New System.Windows.Forms.Label()
        Me.TextBox_Length = New System.Windows.Forms.TextBox()
        Me.TextBox_Comment = New System.Windows.Forms.TextBox()
        Me.Label_Comment = New System.Windows.Forms.Label()
        Me.Timer_MP3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Title = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Comment = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Length = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.Button_Del_Year = New System.Windows.Forms.Button()
        Me.Button_Del_Composer = New System.Windows.Forms.Button()
        Me.Button_Del_Disk = New System.Windows.Forms.Button()
        Me.Button_Del_Genre = New System.Windows.Forms.Button()
        Me.Button_Del_Artist = New System.Windows.Forms.Button()
        Me.Button_Del_Album = New System.Windows.Forms.Button()
        Me.ToolStripButton_FromFile = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_ToFile = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Del_Year)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Year)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_min)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Title)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Title)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Year)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Year)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Del_Composer)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Composer)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Composer)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Composer)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Del_Disk)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Disk)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Disk)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Disk)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Del_Genre)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Genre)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Genre)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Genre)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Del_Artist)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Artist)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Artist)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Artist)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Del_Album)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Button_Album)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Album)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Album)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Length)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Length)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TextBox_Comment)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label_Comment)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(409, 360)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(409, 410)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar_Readed})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(264, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripProgressBar_Readed
        '
        Me.ToolStripProgressBar_Readed.Maximum = 8
        Me.ToolStripProgressBar_Readed.Name = "ToolStripProgressBar_Readed"
        Me.ToolStripProgressBar_Readed.Size = New System.Drawing.Size(250, 22)
        Me.ToolStripProgressBar_Readed.Step = 1
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ImageStream = CType(resources.GetObject("ImageList_Main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Main.Images.SetKeyName(0, "tasto_8_architetto_franc_01.png")
        '
        'Button_Year
        '
        Me.Button_Year.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Year.Enabled = False
        Me.Button_Year.Location = New System.Drawing.Point(356, 269)
        Me.Button_Year.Name = "Button_Year"
        Me.Button_Year.Size = New System.Drawing.Size(24, 23)
        Me.Button_Year.TabIndex = 29
        Me.Button_Year.Text = "..."
        Me.Button_Year.UseVisualStyleBackColor = True
        '
        'Label_min
        '
        Me.Label_min.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_min.AutoSize = True
        Me.Label_min.Location = New System.Drawing.Point(386, 111)
        Me.Label_min.Name = "Label_min"
        Me.Label_min.Size = New System.Drawing.Size(23, 13)
        Me.Label_min.TabIndex = 28
        Me.Label_min.Text = "min"
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Location = New System.Drawing.Point(4, 6)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(41, 13)
        Me.Label_Title.TabIndex = 27
        Me.Label_Title.Text = "x_Titel:"
        '
        'TextBox_Title
        '
        Me.TextBox_Title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Title.Location = New System.Drawing.Point(76, 3)
        Me.TextBox_Title.Name = "TextBox_Title"
        Me.TextBox_Title.Size = New System.Drawing.Size(330, 20)
        Me.TextBox_Title.TabIndex = 26
        '
        'Label_Year
        '
        Me.Label_Year.AutoSize = True
        Me.Label_Year.Location = New System.Drawing.Point(4, 274)
        Me.Label_Year.Name = "Label_Year"
        Me.Label_Year.Size = New System.Drawing.Size(41, 13)
        Me.Label_Year.TabIndex = 25
        Me.Label_Year.Text = "x_Jahr:"
        '
        'TextBox_Year
        '
        Me.TextBox_Year.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Year.Location = New System.Drawing.Point(76, 271)
        Me.TextBox_Year.Name = "TextBox_Year"
        Me.TextBox_Year.ReadOnly = True
        Me.TextBox_Year.Size = New System.Drawing.Size(274, 20)
        Me.TextBox_Year.TabIndex = 24
        '
        'Button_Composer
        '
        Me.Button_Composer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Composer.Enabled = False
        Me.Button_Composer.Location = New System.Drawing.Point(356, 242)
        Me.Button_Composer.Name = "Button_Composer"
        Me.Button_Composer.Size = New System.Drawing.Size(24, 23)
        Me.Button_Composer.TabIndex = 22
        Me.Button_Composer.Text = "..."
        Me.Button_Composer.UseVisualStyleBackColor = True
        '
        'TextBox_Composer
        '
        Me.TextBox_Composer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Composer.Location = New System.Drawing.Point(76, 244)
        Me.TextBox_Composer.Name = "TextBox_Composer"
        Me.TextBox_Composer.ReadOnly = True
        Me.TextBox_Composer.Size = New System.Drawing.Size(274, 20)
        Me.TextBox_Composer.TabIndex = 21
        '
        'Label_Composer
        '
        Me.Label_Composer.AutoSize = True
        Me.Label_Composer.Location = New System.Drawing.Point(4, 247)
        Me.Label_Composer.Name = "Label_Composer"
        Me.Label_Composer.Size = New System.Drawing.Size(68, 13)
        Me.Label_Composer.TabIndex = 20
        Me.Label_Composer.Text = "x_Composer:"
        '
        'Button_Disk
        '
        Me.Button_Disk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Disk.Enabled = False
        Me.Button_Disk.Location = New System.Drawing.Point(356, 215)
        Me.Button_Disk.Name = "Button_Disk"
        Me.Button_Disk.Size = New System.Drawing.Size(24, 23)
        Me.Button_Disk.TabIndex = 18
        Me.Button_Disk.Text = "..."
        Me.Button_Disk.UseVisualStyleBackColor = True
        '
        'TextBox_Disk
        '
        Me.TextBox_Disk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Disk.Location = New System.Drawing.Point(76, 217)
        Me.TextBox_Disk.Name = "TextBox_Disk"
        Me.TextBox_Disk.ReadOnly = True
        Me.TextBox_Disk.Size = New System.Drawing.Size(274, 20)
        Me.TextBox_Disk.TabIndex = 17
        '
        'Label_Disk
        '
        Me.Label_Disk.AutoSize = True
        Me.Label_Disk.Location = New System.Drawing.Point(4, 220)
        Me.Label_Disk.Name = "Label_Disk"
        Me.Label_Disk.Size = New System.Drawing.Size(42, 13)
        Me.Label_Disk.TabIndex = 16
        Me.Label_Disk.Text = "x_Disk:"
        '
        'Button_Genre
        '
        Me.Button_Genre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Genre.Enabled = False
        Me.Button_Genre.Location = New System.Drawing.Point(356, 188)
        Me.Button_Genre.Name = "Button_Genre"
        Me.Button_Genre.Size = New System.Drawing.Size(24, 23)
        Me.Button_Genre.TabIndex = 14
        Me.Button_Genre.Text = "..."
        Me.Button_Genre.UseVisualStyleBackColor = True
        '
        'TextBox_Genre
        '
        Me.TextBox_Genre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Genre.Location = New System.Drawing.Point(76, 190)
        Me.TextBox_Genre.Name = "TextBox_Genre"
        Me.TextBox_Genre.ReadOnly = True
        Me.TextBox_Genre.Size = New System.Drawing.Size(274, 20)
        Me.TextBox_Genre.TabIndex = 13
        '
        'Label_Genre
        '
        Me.Label_Genre.AutoSize = True
        Me.Label_Genre.Location = New System.Drawing.Point(4, 193)
        Me.Label_Genre.Name = "Label_Genre"
        Me.Label_Genre.Size = New System.Drawing.Size(50, 13)
        Me.Label_Genre.TabIndex = 12
        Me.Label_Genre.Text = "x_Genre:"
        '
        'Button_Artist
        '
        Me.Button_Artist.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Artist.Enabled = False
        Me.Button_Artist.Location = New System.Drawing.Point(356, 161)
        Me.Button_Artist.Name = "Button_Artist"
        Me.Button_Artist.Size = New System.Drawing.Size(24, 23)
        Me.Button_Artist.TabIndex = 10
        Me.Button_Artist.Text = "..."
        Me.Button_Artist.UseVisualStyleBackColor = True
        '
        'TextBox_Artist
        '
        Me.TextBox_Artist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Artist.Location = New System.Drawing.Point(76, 163)
        Me.TextBox_Artist.Name = "TextBox_Artist"
        Me.TextBox_Artist.ReadOnly = True
        Me.TextBox_Artist.Size = New System.Drawing.Size(274, 20)
        Me.TextBox_Artist.TabIndex = 9
        '
        'Label_Artist
        '
        Me.Label_Artist.AutoSize = True
        Me.Label_Artist.Location = New System.Drawing.Point(4, 166)
        Me.Label_Artist.Name = "Label_Artist"
        Me.Label_Artist.Size = New System.Drawing.Size(44, 13)
        Me.Label_Artist.TabIndex = 8
        Me.Label_Artist.Text = "x_Artist:"
        '
        'Button_Album
        '
        Me.Button_Album.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Album.Enabled = False
        Me.Button_Album.Location = New System.Drawing.Point(356, 132)
        Me.Button_Album.Name = "Button_Album"
        Me.Button_Album.Size = New System.Drawing.Size(24, 23)
        Me.Button_Album.TabIndex = 6
        Me.Button_Album.Text = "..."
        Me.Button_Album.UseVisualStyleBackColor = True
        '
        'Label_Album
        '
        Me.Label_Album.AutoSize = True
        Me.Label_Album.Location = New System.Drawing.Point(4, 137)
        Me.Label_Album.Name = "Label_Album"
        Me.Label_Album.Size = New System.Drawing.Size(50, 13)
        Me.Label_Album.TabIndex = 5
        Me.Label_Album.Text = "x_Album:"
        '
        'TextBox_Album
        '
        Me.TextBox_Album.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Album.Location = New System.Drawing.Point(76, 135)
        Me.TextBox_Album.Name = "TextBox_Album"
        Me.TextBox_Album.ReadOnly = True
        Me.TextBox_Album.Size = New System.Drawing.Size(274, 20)
        Me.TextBox_Album.TabIndex = 4
        '
        'Label_Length
        '
        Me.Label_Length.AutoSize = True
        Me.Label_Length.Location = New System.Drawing.Point(4, 111)
        Me.Label_Length.Name = "Label_Length"
        Me.Label_Length.Size = New System.Drawing.Size(57, 13)
        Me.Label_Length.TabIndex = 3
        Me.Label_Length.Text = "x_Laenge:"
        '
        'TextBox_Length
        '
        Me.TextBox_Length.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Length.Location = New System.Drawing.Point(76, 108)
        Me.TextBox_Length.Name = "TextBox_Length"
        Me.TextBox_Length.Size = New System.Drawing.Size(304, 20)
        Me.TextBox_Length.TabIndex = 2
        '
        'TextBox_Comment
        '
        Me.TextBox_Comment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Comment.Location = New System.Drawing.Point(76, 27)
        Me.TextBox_Comment.Multiline = True
        Me.TextBox_Comment.Name = "TextBox_Comment"
        Me.TextBox_Comment.Size = New System.Drawing.Size(330, 74)
        Me.TextBox_Comment.TabIndex = 1
        '
        'Label_Comment
        '
        Me.Label_Comment.AutoSize = True
        Me.Label_Comment.Location = New System.Drawing.Point(4, 30)
        Me.Label_Comment.Name = "Label_Comment"
        Me.Label_Comment.Size = New System.Drawing.Size(65, 13)
        Me.Label_Comment.TabIndex = 0
        Me.Label_Comment.Text = "x_Comment:"
        '
        'Timer_MP3
        '
        Me.Timer_MP3.Interval = 300
        '
        'Timer_Title
        '
        Me.Timer_Title.Interval = 300
        '
        'Timer_Comment
        '
        Me.Timer_Comment.Interval = 300
        '
        'Timer_Length
        '
        Me.Timer_Length.Interval = 300
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_FromFile, Me.ToolStripButton_ToFile})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(201, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'Button_Del_Year
        '
        Me.Button_Del_Year.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Del_Year.Enabled = False
        Me.Button_Del_Year.ImageIndex = 0
        Me.Button_Del_Year.ImageList = Me.ImageList_Main
        Me.Button_Del_Year.Location = New System.Drawing.Point(382, 269)
        Me.Button_Del_Year.Name = "Button_Del_Year"
        Me.Button_Del_Year.Size = New System.Drawing.Size(24, 23)
        Me.Button_Del_Year.TabIndex = 30
        Me.Button_Del_Year.UseVisualStyleBackColor = True
        '
        'Button_Del_Composer
        '
        Me.Button_Del_Composer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Del_Composer.Enabled = False
        Me.Button_Del_Composer.ImageIndex = 0
        Me.Button_Del_Composer.ImageList = Me.ImageList_Main
        Me.Button_Del_Composer.Location = New System.Drawing.Point(382, 242)
        Me.Button_Del_Composer.Name = "Button_Del_Composer"
        Me.Button_Del_Composer.Size = New System.Drawing.Size(24, 23)
        Me.Button_Del_Composer.TabIndex = 23
        Me.Button_Del_Composer.UseVisualStyleBackColor = True
        '
        'Button_Del_Disk
        '
        Me.Button_Del_Disk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Del_Disk.Enabled = False
        Me.Button_Del_Disk.ImageIndex = 0
        Me.Button_Del_Disk.ImageList = Me.ImageList_Main
        Me.Button_Del_Disk.Location = New System.Drawing.Point(382, 215)
        Me.Button_Del_Disk.Name = "Button_Del_Disk"
        Me.Button_Del_Disk.Size = New System.Drawing.Size(24, 23)
        Me.Button_Del_Disk.TabIndex = 19
        Me.Button_Del_Disk.UseVisualStyleBackColor = True
        '
        'Button_Del_Genre
        '
        Me.Button_Del_Genre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Del_Genre.Enabled = False
        Me.Button_Del_Genre.ImageIndex = 0
        Me.Button_Del_Genre.ImageList = Me.ImageList_Main
        Me.Button_Del_Genre.Location = New System.Drawing.Point(382, 188)
        Me.Button_Del_Genre.Name = "Button_Del_Genre"
        Me.Button_Del_Genre.Size = New System.Drawing.Size(24, 23)
        Me.Button_Del_Genre.TabIndex = 15
        Me.Button_Del_Genre.UseVisualStyleBackColor = True
        '
        'Button_Del_Artist
        '
        Me.Button_Del_Artist.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Del_Artist.Enabled = False
        Me.Button_Del_Artist.ImageIndex = 0
        Me.Button_Del_Artist.ImageList = Me.ImageList_Main
        Me.Button_Del_Artist.Location = New System.Drawing.Point(382, 161)
        Me.Button_Del_Artist.Name = "Button_Del_Artist"
        Me.Button_Del_Artist.Size = New System.Drawing.Size(24, 23)
        Me.Button_Del_Artist.TabIndex = 11
        Me.Button_Del_Artist.UseVisualStyleBackColor = True
        '
        'Button_Del_Album
        '
        Me.Button_Del_Album.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Del_Album.Enabled = False
        Me.Button_Del_Album.ImageIndex = 0
        Me.Button_Del_Album.ImageList = Me.ImageList_Main
        Me.Button_Del_Album.Location = New System.Drawing.Point(382, 132)
        Me.Button_Del_Album.Name = "Button_Del_Album"
        Me.Button_Del_Album.Size = New System.Drawing.Size(24, 23)
        Me.Button_Del_Album.TabIndex = 7
        Me.Button_Del_Album.UseVisualStyleBackColor = True
        '
        'ToolStripButton_FromFile
        '
        Me.ToolStripButton_FromFile.Enabled = False
        Me.ToolStripButton_FromFile.Image = Global.MediaViewer_Module.My.Resources.Resources.IssueTracking_32x32
        Me.ToolStripButton_FromFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_FromFile.Name = "ToolStripButton_FromFile"
        Me.ToolStripButton_FromFile.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripButton_FromFile.Text = "x_From File"
        '
        'ToolStripButton_ToFile
        '
        Me.ToolStripButton_ToFile.Enabled = False
        Me.ToolStripButton_ToFile.Image = Global.MediaViewer_Module.My.Resources.Resources.base_floppydisk_32
        Me.ToolStripButton_ToFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ToFile.Name = "ToolStripButton_ToFile"
        Me.ToolStripButton_ToFile.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripButton_ToFile.Text = "x_To File"
        '
        'UserControl_MediaDetail_MP3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_MediaDetail_MP3"
        Me.Size = New System.Drawing.Size(409, 410)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripProgressBar_Readed As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Label_Title As System.Windows.Forms.Label
    Friend WithEvents TextBox_Title As System.Windows.Forms.TextBox
    Friend WithEvents Label_Year As System.Windows.Forms.Label
    Friend WithEvents TextBox_Year As System.Windows.Forms.TextBox
    Friend WithEvents Button_Del_Composer As System.Windows.Forms.Button
    Friend WithEvents ImageList_Main As System.Windows.Forms.ImageList
    Friend WithEvents Button_Composer As System.Windows.Forms.Button
    Friend WithEvents TextBox_Composer As System.Windows.Forms.TextBox
    Friend WithEvents Label_Composer As System.Windows.Forms.Label
    Friend WithEvents Button_Del_Disk As System.Windows.Forms.Button
    Friend WithEvents Button_Disk As System.Windows.Forms.Button
    Friend WithEvents TextBox_Disk As System.Windows.Forms.TextBox
    Friend WithEvents Label_Disk As System.Windows.Forms.Label
    Friend WithEvents Button_Del_Genre As System.Windows.Forms.Button
    Friend WithEvents Button_Genre As System.Windows.Forms.Button
    Friend WithEvents TextBox_Genre As System.Windows.Forms.TextBox
    Friend WithEvents Label_Genre As System.Windows.Forms.Label
    Friend WithEvents Button_Del_Artist As System.Windows.Forms.Button
    Friend WithEvents Button_Artist As System.Windows.Forms.Button
    Friend WithEvents TextBox_Artist As System.Windows.Forms.TextBox
    Friend WithEvents Label_Artist As System.Windows.Forms.Label
    Friend WithEvents Button_Del_Album As System.Windows.Forms.Button
    Friend WithEvents Button_Album As System.Windows.Forms.Button
    Friend WithEvents Label_Album As System.Windows.Forms.Label
    Friend WithEvents TextBox_Album As System.Windows.Forms.TextBox
    Friend WithEvents Label_Length As System.Windows.Forms.Label
    Friend WithEvents TextBox_Length As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Comment As System.Windows.Forms.TextBox
    Friend WithEvents Label_Comment As System.Windows.Forms.Label
    Friend WithEvents Timer_MP3 As System.Windows.Forms.Timer
    Friend WithEvents Label_min As System.Windows.Forms.Label
    Friend WithEvents Button_Del_Year As System.Windows.Forms.Button
    Friend WithEvents Button_Year As System.Windows.Forms.Button
    Friend WithEvents Timer_Title As System.Windows.Forms.Timer
    Friend WithEvents Timer_Comment As System.Windows.Forms.Timer
    Friend WithEvents Timer_Length As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_FromFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_ToFile As System.Windows.Forms.ToolStripButton

End Class
