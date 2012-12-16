<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_EditImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_EditImage))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_SizeLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_size = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_NameLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Name = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_CreationLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Creation = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Image = New System.Windows.Forms.TabPage()
        Me.PictureBox_Image = New System.Windows.Forms.PictureBox()
        Me.TabPage_Persons = New System.Windows.Forms.TabPage()
        Me.TabPage_ImportantEvent = New System.Windows.Forms.TabPage()
        Me.TabPage_Locations = New System.Windows.Forms.TabPage()
        Me.TabPage_Buildings = New System.Windows.Forms.TabPage()
        Me.TabPage_Pets = New System.Windows.Forms.TabPage()
        Me.TabPage_Species = New System.Windows.Forms.TabPage()
        Me.TabPage_Plants = New System.Windows.Forms.TabPage()
        Me.TabPage_Landscapes = New System.Windows.Forms.TabPage()
        Me.TabPage_WeatherConditions = New System.Windows.Forms.TabPage()
        Me.TabPage_Others = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_LoadImage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Copy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Paste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton_Scale = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItem_Stretch = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Original = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Zoom = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_OwnWindow = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_getMeta = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog_Image = New System.Windows.Forms.OpenFileDialog()
        Me.Timer_Create = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage_ArtWork = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Image.SuspendLayout()
        CType(Me.PictureBox_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(710, 408)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(710, 458)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Delete, Me.ToolStripSeparator3, Me.ToolStripLabel_SizeLBL, Me.ToolStripLabel_size, Me.ToolStripSeparator6, Me.ToolStripLabel_NameLBL, Me.ToolStripLabel_Name, Me.ToolStripSeparator5, Me.ToolStripLabel_CreationLBL, Me.ToolStripLabel_Creation})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(335, 25)
        Me.ToolStrip2.TabIndex = 1
        '
        'ToolStripButton_Delete
        '
        Me.ToolStripButton_Delete.Enabled = False
        Me.ToolStripButton_Delete.Image = Global.MediaViewer_Module.My.Resources.Resources.tasto_8_architetto_franc_01
        Me.ToolStripButton_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
        Me.ToolStripButton_Delete.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripButton_Delete.Text = "x_Delete Image"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_SizeLBL
        '
        Me.ToolStripLabel_SizeLBL.Name = "ToolStripLabel_SizeLBL"
        Me.ToolStripLabel_SizeLBL.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripLabel_SizeLBL.Text = "x_Size:"
        '
        'ToolStripLabel_size
        '
        Me.ToolStripLabel_size.Name = "ToolStripLabel_size"
        Me.ToolStripLabel_size.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripLabel_size.Text = "0/0"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_NameLBL
        '
        Me.ToolStripLabel_NameLBL.Name = "ToolStripLabel_NameLBL"
        Me.ToolStripLabel_NameLBL.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel_NameLBL.Text = "x_Name:"
        '
        'ToolStripLabel_Name
        '
        Me.ToolStripLabel_Name.Name = "ToolStripLabel_Name"
        Me.ToolStripLabel_Name.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel_Name.Text = "-"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_CreationLBL
        '
        Me.ToolStripLabel_CreationLBL.Name = "ToolStripLabel_CreationLBL"
        Me.ToolStripLabel_CreationLBL.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripLabel_CreationLBL.Text = "x_Erzeugt:"
        '
        'ToolStripLabel_Creation
        '
        Me.ToolStripLabel_Creation.Name = "ToolStripLabel_Creation"
        Me.ToolStripLabel_Creation.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel_Creation.Text = "-"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Image)
        Me.TabControl1.Controls.Add(Me.TabPage_Persons)
        Me.TabControl1.Controls.Add(Me.TabPage_ImportantEvent)
        Me.TabControl1.Controls.Add(Me.TabPage_Locations)
        Me.TabControl1.Controls.Add(Me.TabPage_Buildings)
        Me.TabControl1.Controls.Add(Me.TabPage_Pets)
        Me.TabControl1.Controls.Add(Me.TabPage_Species)
        Me.TabControl1.Controls.Add(Me.TabPage_Plants)
        Me.TabControl1.Controls.Add(Me.TabPage_Landscapes)
        Me.TabControl1.Controls.Add(Me.TabPage_WeatherConditions)
        Me.TabControl1.Controls.Add(Me.TabPage_ArtWork)
        Me.TabControl1.Controls.Add(Me.TabPage_Others)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(710, 408)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Image
        '
        Me.TabPage_Image.Controls.Add(Me.PictureBox_Image)
        Me.TabPage_Image.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Image.Name = "TabPage_Image"
        Me.TabPage_Image.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Image.Size = New System.Drawing.Size(702, 364)
        Me.TabPage_Image.TabIndex = 0
        Me.TabPage_Image.Text = "x_Image"
        Me.TabPage_Image.UseVisualStyleBackColor = True
        '
        'PictureBox_Image
        '
        Me.PictureBox_Image.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_Image.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox_Image.Name = "PictureBox_Image"
        Me.PictureBox_Image.Size = New System.Drawing.Size(696, 358)
        Me.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_Image.TabIndex = 4
        Me.PictureBox_Image.TabStop = False
        '
        'TabPage_Persons
        '
        Me.TabPage_Persons.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Persons.Name = "TabPage_Persons"
        Me.TabPage_Persons.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Persons.Size = New System.Drawing.Size(702, 364)
        Me.TabPage_Persons.TabIndex = 1
        Me.TabPage_Persons.Text = "x_Persons"
        Me.TabPage_Persons.UseVisualStyleBackColor = True
        '
        'TabPage_ImportantEvent
        '
        Me.TabPage_ImportantEvent.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_ImportantEvent.Name = "TabPage_ImportantEvent"
        Me.TabPage_ImportantEvent.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ImportantEvent.Size = New System.Drawing.Size(702, 364)
        Me.TabPage_ImportantEvent.TabIndex = 7
        Me.TabPage_ImportantEvent.Text = "x_Wichtige Ereignisse"
        Me.TabPage_ImportantEvent.UseVisualStyleBackColor = True
        '
        'TabPage_Locations
        '
        Me.TabPage_Locations.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Locations.Name = "TabPage_Locations"
        Me.TabPage_Locations.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Locations.Size = New System.Drawing.Size(702, 364)
        Me.TabPage_Locations.TabIndex = 2
        Me.TabPage_Locations.Text = "x_Orte"
        Me.TabPage_Locations.UseVisualStyleBackColor = True
        '
        'TabPage_Buildings
        '
        Me.TabPage_Buildings.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Buildings.Name = "TabPage_Buildings"
        Me.TabPage_Buildings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Buildings.Size = New System.Drawing.Size(702, 364)
        Me.TabPage_Buildings.TabIndex = 4
        Me.TabPage_Buildings.Text = "x_Bauwerke"
        Me.TabPage_Buildings.UseVisualStyleBackColor = True
        '
        'TabPage_Pets
        '
        Me.TabPage_Pets.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Pets.Name = "TabPage_Pets"
        Me.TabPage_Pets.Size = New System.Drawing.Size(702, 364)
        Me.TabPage_Pets.TabIndex = 5
        Me.TabPage_Pets.Text = "x_Haustiere"
        Me.TabPage_Pets.UseVisualStyleBackColor = True
        '
        'TabPage_Species
        '
        Me.TabPage_Species.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Species.Name = "TabPage_Species"
        Me.TabPage_Species.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Species.Size = New System.Drawing.Size(702, 364)
        Me.TabPage_Species.TabIndex = 6
        Me.TabPage_Species.Text = "x_Tierarten"
        Me.TabPage_Species.UseVisualStyleBackColor = True
        '
        'TabPage_Plants
        '
        Me.TabPage_Plants.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Plants.Name = "TabPage_Plants"
        Me.TabPage_Plants.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Plants.Size = New System.Drawing.Size(702, 364)
        Me.TabPage_Plants.TabIndex = 10
        Me.TabPage_Plants.Text = "x_Pflanzenarten"
        Me.TabPage_Plants.UseVisualStyleBackColor = True
        '
        'TabPage_Landscapes
        '
        Me.TabPage_Landscapes.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Landscapes.Name = "TabPage_Landscapes"
        Me.TabPage_Landscapes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Landscapes.Size = New System.Drawing.Size(702, 364)
        Me.TabPage_Landscapes.TabIndex = 8
        Me.TabPage_Landscapes.Text = "x_Landschaften"
        Me.TabPage_Landscapes.UseVisualStyleBackColor = True
        '
        'TabPage_WeatherConditions
        '
        Me.TabPage_WeatherConditions.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_WeatherConditions.Name = "TabPage_WeatherConditions"
        Me.TabPage_WeatherConditions.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_WeatherConditions.Size = New System.Drawing.Size(702, 364)
        Me.TabPage_WeatherConditions.TabIndex = 9
        Me.TabPage_WeatherConditions.Text = "x_Wetterlagen"
        Me.TabPage_WeatherConditions.UseVisualStyleBackColor = True
        '
        'TabPage_Others
        '
        Me.TabPage_Others.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_Others.Name = "TabPage_Others"
        Me.TabPage_Others.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Others.Size = New System.Drawing.Size(702, 364)
        Me.TabPage_Others.TabIndex = 3
        Me.TabPage_Others.Text = "x_Sonstiges"
        Me.TabPage_Others.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_LoadImage, Me.ToolStripButton_Copy, Me.ToolStripButton_Paste, Me.ToolStripSeparator2, Me.ToolStripSplitButton_Scale, Me.ToolStripSeparator1, Me.ToolStripButton_OwnWindow, Me.ToolStripSeparator4, Me.ToolStripButton_getMeta})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(352, 25)
        Me.ToolStrip1.TabIndex = 1
        '
        'ToolStripButton_LoadImage
        '
        Me.ToolStripButton_LoadImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_LoadImage.Enabled = False
        Me.ToolStripButton_LoadImage.Image = Global.MediaViewer_Module.My.Resources.Resources.b_plus_with_Folder
        Me.ToolStripButton_LoadImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_LoadImage.Name = "ToolStripButton_LoadImage"
        Me.ToolStripButton_LoadImage.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_LoadImage.Text = "ToolStripButton1"
        '
        'ToolStripButton_Copy
        '
        Me.ToolStripButton_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Copy.Enabled = False
        Me.ToolStripButton_Copy.Image = Global.MediaViewer_Module.My.Resources.Resources._1435_ClipBoard
        Me.ToolStripButton_Copy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Copy.Name = "ToolStripButton_Copy"
        Me.ToolStripButton_Copy.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Copy.Text = "ToolStripButton1"
        '
        'ToolStripButton_Paste
        '
        Me.ToolStripButton_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Paste.Enabled = False
        Me.ToolStripButton_Paste.Image = Global.MediaViewer_Module.My.Resources.Resources.Paste
        Me.ToolStripButton_Paste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Paste.Name = "ToolStripButton_Paste"
        Me.ToolStripButton_Paste.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Paste.Text = "ToolStripButton2"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSplitButton_Scale
        '
        Me.ToolStripSplitButton_Scale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton_Scale.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Stretch, Me.ToolStripMenuItem_Original, Me.ToolStripMenuItem_Zoom})
        Me.ToolStripSplitButton_Scale.Enabled = False
        Me.ToolStripSplitButton_Scale.Image = CType(resources.GetObject("ToolStripSplitButton_Scale.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton_Scale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton_Scale.Name = "ToolStripSplitButton_Scale"
        Me.ToolStripSplitButton_Scale.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripSplitButton_Scale.Text = "x_Scale"
        '
        'ToolStripMenuItem_Stretch
        '
        Me.ToolStripMenuItem_Stretch.Name = "ToolStripMenuItem_Stretch"
        Me.ToolStripMenuItem_Stretch.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripMenuItem_Stretch.Text = "x_Stretch"
        '
        'ToolStripMenuItem_Original
        '
        Me.ToolStripMenuItem_Original.Name = "ToolStripMenuItem_Original"
        Me.ToolStripMenuItem_Original.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripMenuItem_Original.Text = "x_Original"
        '
        'ToolStripMenuItem_Zoom
        '
        Me.ToolStripMenuItem_Zoom.Checked = True
        Me.ToolStripMenuItem_Zoom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem_Zoom.Name = "ToolStripMenuItem_Zoom"
        Me.ToolStripMenuItem_Zoom.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripMenuItem_Zoom.Text = "x_Zoom"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_OwnWindow
        '
        Me.ToolStripButton_OwnWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_OwnWindow.Enabled = False
        Me.ToolStripButton_OwnWindow.Image = CType(resources.GetObject("ToolStripButton_OwnWindow.Image"), System.Drawing.Image)
        Me.ToolStripButton_OwnWindow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_OwnWindow.Name = "ToolStripButton_OwnWindow"
        Me.ToolStripButton_OwnWindow.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripButton_OwnWindow.Text = "x_Eigenes Fenster"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_getMeta
        '
        Me.ToolStripButton_getMeta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_getMeta.Enabled = False
        Me.ToolStripButton_getMeta.Image = CType(resources.GetObject("ToolStripButton_getMeta.Image"), System.Drawing.Image)
        Me.ToolStripButton_getMeta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_getMeta.Name = "ToolStripButton_getMeta"
        Me.ToolStripButton_getMeta.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripButton_getMeta.Text = "x_get Metadata"
        '
        'OpenFileDialog_Image
        '
        Me.OpenFileDialog_Image.FileName = "OpenFileDialog1"
        '
        'Timer_Create
        '
        Me.Timer_Create.Interval = 300
        '
        'TabPage_ArtWork
        '
        Me.TabPage_ArtWork.Location = New System.Drawing.Point(4, 40)
        Me.TabPage_ArtWork.Name = "TabPage_ArtWork"
        Me.TabPage_ArtWork.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ArtWork.Size = New System.Drawing.Size(702, 364)
        Me.TabPage_ArtWork.TabIndex = 11
        Me.TabPage_ArtWork.Text = "x_Kunstwerke"
        Me.TabPage_ArtWork.UseVisualStyleBackColor = True
        '
        'UserControl_EditImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_EditImage"
        Me.Size = New System.Drawing.Size(710, 458)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Image.ResumeLayout(False)
        Me.TabPage_Image.PerformLayout()
        CType(Me.PictureBox_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Copy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Paste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_SizeLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_size As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_NameLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Name As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton_LoadImage As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog_Image As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Image As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Persons As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Locations As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Others As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_OwnWindow As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage_Buildings As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Pets As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Species As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_ImportantEvent As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_getMeta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton_Scale As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem_Stretch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Original As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Zoom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage_Landscapes As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_WeatherConditions As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_CreationLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Creation As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Timer_Create As System.Windows.Forms.Timer
    Friend WithEvents PictureBox_Image As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage_Plants As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_ArtWork As System.Windows.Forms.TabPage

End Class
