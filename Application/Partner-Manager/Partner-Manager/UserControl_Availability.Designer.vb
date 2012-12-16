<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Availability
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Availability))
        Me.Timer_Data = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_Count_AvailabilityDataLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_CountAvailabilityData = New System.Windows.Forms.ToolStripLabel()
        Me.TreeView_AvailabilityData = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_Tree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem_Tree = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem_Tree = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_AvailabilityData = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ComboBox_Weekday = New System.Windows.Forms.ComboBox()
        Me.Label_WeekDay = New System.Windows.Forms.Label()
        Me.CheckBox_byArrangement = New System.Windows.Forms.CheckBox()
        Me.MaskedTextBox_To = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_From = New System.Windows.Forms.MaskedTextBox()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.ImageList_Button = New System.Windows.Forms.ImageList(Me.components)
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Label_To = New System.Windows.Forms.Label()
        Me.Label_From = New System.Windows.Forms.Label()
        Me.ToolStripContainer3 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_AvailabilitiesCount = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView_Availabilities = New System.Windows.Forms.DataGridView()
        Me.BindingSource_Availabilities = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStripContainer2.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ContextMenuStrip_Tree.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStripContainer3.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer3.ContentPanel.SuspendLayout()
        Me.ToolStripContainer3.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.DataGridView_Availabilities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Availabilities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer_Data
        '
        Me.Timer_Data.Interval = 300
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(620, 417)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(620, 417)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStripContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(620, 417)
        Me.SplitContainer1.SplitterDistance = 206
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.BottomToolStripPanel
        '
        Me.ToolStripContainer2.BottomToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.TreeView_AvailabilityData)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(202, 388)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.LeftToolStripPanelVisible = False
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.RightToolStripPanelVisible = False
        Me.ToolStripContainer2.Size = New System.Drawing.Size(202, 413)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        Me.ToolStripContainer2.TopToolStripPanelVisible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_Count_AvailabilityDataLBL, Me.ToolStripLabel_CountAvailabilityData})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(78, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel_Count_AvailabilityDataLBL
        '
        Me.ToolStripLabel_Count_AvailabilityDataLBL.Name = "ToolStripLabel_Count_AvailabilityDataLBL"
        Me.ToolStripLabel_Count_AvailabilityDataLBL.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel_Count_AvailabilityDataLBL.Text = "x_Count:"
        '
        'ToolStripLabel_CountAvailabilityData
        '
        Me.ToolStripLabel_CountAvailabilityData.Name = "ToolStripLabel_CountAvailabilityData"
        Me.ToolStripLabel_CountAvailabilityData.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_CountAvailabilityData.Text = "0"
        '
        'TreeView_AvailabilityData
        '
        Me.TreeView_AvailabilityData.ContextMenuStrip = Me.ContextMenuStrip_Tree
        Me.TreeView_AvailabilityData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_AvailabilityData.ImageIndex = 0
        Me.TreeView_AvailabilityData.ImageList = Me.ImageList_AvailabilityData
        Me.TreeView_AvailabilityData.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_AvailabilityData.Name = "TreeView_AvailabilityData"
        Me.TreeView_AvailabilityData.SelectedImageIndex = 1
        Me.TreeView_AvailabilityData.Size = New System.Drawing.Size(202, 388)
        Me.TreeView_AvailabilityData.TabIndex = 0
        '
        'ContextMenuStrip_Tree
        '
        Me.ContextMenuStrip_Tree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem_Tree, Me.RemoveToolStripMenuItem_Tree})
        Me.ContextMenuStrip_Tree.Name = "ContextMenuStrip_Tree"
        Me.ContextMenuStrip_Tree.Size = New System.Drawing.Size(153, 70)
        '
        'NewToolStripMenuItem_Tree
        '
        Me.NewToolStripMenuItem_Tree.Name = "NewToolStripMenuItem_Tree"
        Me.NewToolStripMenuItem_Tree.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem_Tree.Text = "x_New"
        '
        'RemoveToolStripMenuItem_Tree
        '
        Me.RemoveToolStripMenuItem_Tree.Name = "RemoveToolStripMenuItem_Tree"
        Me.RemoveToolStripMenuItem_Tree.Size = New System.Drawing.Size(127, 22)
        Me.RemoveToolStripMenuItem_Tree.Text = "x_Remove"
        '
        'ImageList_AvailabilityData
        '
        Me.ImageList_AvailabilityData.ImageStream = CType(resources.GetObject("ImageList_AvailabilityData.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_AvailabilityData.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_AvailabilityData.Images.SetKeyName(0, "bb_home_.png")
        Me.ImageList_AvailabilityData.Images.SetKeyName(1, "Folder_Closed.png")
        Me.ImageList_AvailabilityData.Images.SetKeyName(2, "Folder_Open.png")
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComboBox_Weekday)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label_WeekDay)
        Me.SplitContainer2.Panel1.Controls.Add(Me.CheckBox_byArrangement)
        Me.SplitContainer2.Panel1.Controls.Add(Me.MaskedTextBox_To)
        Me.SplitContainer2.Panel1.Controls.Add(Me.MaskedTextBox_From)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button_Delete)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button_Save)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label_To)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label_From)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStripContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(410, 417)
        Me.SplitContainer2.SplitterDistance = 55
        Me.SplitContainer2.TabIndex = 0
        '
        'ComboBox_Weekday
        '
        Me.ComboBox_Weekday.FormattingEnabled = True
        Me.ComboBox_Weekday.Location = New System.Drawing.Point(52, 1)
        Me.ComboBox_Weekday.Name = "ComboBox_Weekday"
        Me.ComboBox_Weekday.Size = New System.Drawing.Size(61, 21)
        Me.ComboBox_Weekday.TabIndex = 11
        '
        'Label_WeekDay
        '
        Me.Label_WeekDay.AutoSize = True
        Me.Label_WeekDay.Location = New System.Drawing.Point(3, 4)
        Me.Label_WeekDay.Name = "Label_WeekDay"
        Me.Label_WeekDay.Size = New System.Drawing.Size(40, 13)
        Me.Label_WeekDay.TabIndex = 10
        Me.Label_WeekDay.Text = "x_Day:"
        '
        'CheckBox_byArrangement
        '
        Me.CheckBox_byArrangement.AutoSize = True
        Me.CheckBox_byArrangement.Location = New System.Drawing.Point(119, 3)
        Me.CheckBox_byArrangement.Name = "CheckBox_byArrangement"
        Me.CheckBox_byArrangement.Size = New System.Drawing.Size(129, 17)
        Me.CheckBox_byArrangement.TabIndex = 9
        Me.CheckBox_byArrangement.Text = "x_Nach Vereinbarung"
        Me.CheckBox_byArrangement.UseVisualStyleBackColor = True
        '
        'MaskedTextBox_To
        '
        Me.MaskedTextBox_To.Enabled = False
        Me.MaskedTextBox_To.Location = New System.Drawing.Point(156, 29)
        Me.MaskedTextBox_To.Mask = "90:00"
        Me.MaskedTextBox_To.Name = "MaskedTextBox_To"
        Me.MaskedTextBox_To.Size = New System.Drawing.Size(60, 20)
        Me.MaskedTextBox_To.TabIndex = 8
        Me.MaskedTextBox_To.ValidatingType = GetType(Date)
        '
        'MaskedTextBox_From
        '
        Me.MaskedTextBox_From.Enabled = False
        Me.MaskedTextBox_From.Location = New System.Drawing.Point(52, 29)
        Me.MaskedTextBox_From.Mask = "90:00"
        Me.MaskedTextBox_From.Name = "MaskedTextBox_From"
        Me.MaskedTextBox_From.Size = New System.Drawing.Size(61, 20)
        Me.MaskedTextBox_From.TabIndex = 7
        Me.MaskedTextBox_From.ValidatingType = GetType(Date)
        '
        'Button_Delete
        '
        Me.Button_Delete.Enabled = False
        Me.Button_Delete.ImageIndex = 1
        Me.Button_Delete.ImageList = Me.ImageList_Button
        Me.Button_Delete.Location = New System.Drawing.Point(254, 29)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(27, 23)
        Me.Button_Delete.TabIndex = 6
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'ImageList_Button
        '
        Me.ImageList_Button.ImageStream = CType(resources.GetObject("ImageList_Button.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Button.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Button.Images.SetKeyName(0, "base_floppydisk_32.png")
        Me.ImageList_Button.Images.SetKeyName(1, "tasto_8_architetto_franc_01.png")
        '
        'Button_Save
        '
        Me.Button_Save.Enabled = False
        Me.Button_Save.ImageIndex = 0
        Me.Button_Save.ImageList = Me.ImageList_Button
        Me.Button_Save.Location = New System.Drawing.Point(254, 1)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(27, 23)
        Me.Button_Save.TabIndex = 5
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Label_To
        '
        Me.Label_To.AutoSize = True
        Me.Label_To.Location = New System.Drawing.Point(116, 32)
        Me.Label_To.Name = "Label_To"
        Me.Label_To.Size = New System.Drawing.Size(34, 13)
        Me.Label_To.TabIndex = 4
        Me.Label_To.Text = "x_To:"
        '
        'Label_From
        '
        Me.Label_From.AutoSize = True
        Me.Label_From.Location = New System.Drawing.Point(2, 32)
        Me.Label_From.Name = "Label_From"
        Me.Label_From.Size = New System.Drawing.Size(44, 13)
        Me.Label_From.TabIndex = 3
        Me.Label_From.Text = "x_From:"
        '
        'ToolStripContainer3
        '
        '
        'ToolStripContainer3.BottomToolStripPanel
        '
        Me.ToolStripContainer3.BottomToolStripPanel.Controls.Add(Me.ToolStrip3)
        '
        'ToolStripContainer3.ContentPanel
        '
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.DataGridView_Availabilities)
        Me.ToolStripContainer3.ContentPanel.Size = New System.Drawing.Size(406, 329)
        Me.ToolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer3.LeftToolStripPanelVisible = False
        Me.ToolStripContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer3.Name = "ToolStripContainer3"
        Me.ToolStripContainer3.RightToolStripPanelVisible = False
        Me.ToolStripContainer3.Size = New System.Drawing.Size(406, 354)
        Me.ToolStripContainer3.TabIndex = 0
        Me.ToolStripContainer3.Text = "ToolStripContainer3"
        Me.ToolStripContainer3.TopToolStripPanelVisible = False
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel_AvailabilitiesCount})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(78, 25)
        Me.ToolStrip3.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel1.Text = "x_Count:"
        '
        'ToolStripLabel_AvailabilitiesCount
        '
        Me.ToolStripLabel_AvailabilitiesCount.Name = "ToolStripLabel_AvailabilitiesCount"
        Me.ToolStripLabel_AvailabilitiesCount.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_AvailabilitiesCount.Text = "0"
        '
        'DataGridView_Availabilities
        '
        Me.DataGridView_Availabilities.AllowUserToAddRows = False
        Me.DataGridView_Availabilities.AllowUserToDeleteRows = False
        Me.DataGridView_Availabilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Availabilities.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Availabilities.Enabled = False
        Me.DataGridView_Availabilities.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Availabilities.Name = "DataGridView_Availabilities"
        Me.DataGridView_Availabilities.ReadOnly = True
        Me.DataGridView_Availabilities.Size = New System.Drawing.Size(406, 329)
        Me.DataGridView_Availabilities.TabIndex = 0
        '
        'UserControl_Availability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "UserControl_Availability"
        Me.Size = New System.Drawing.Size(620, 417)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ContextMenuStrip_Tree.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStripContainer3.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer3.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer3.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer3.ResumeLayout(False)
        Me.ToolStripContainer3.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.DataGridView_Availabilities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Availabilities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer_Data As System.Windows.Forms.Timer
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_Count_AvailabilityDataLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_CountAvailabilityData As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TreeView_AvailabilityData As System.Windows.Forms.TreeView
    Friend WithEvents ImageList_AvailabilityData As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer3 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_AvailabilitiesCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_Availabilities As System.Windows.Forms.DataGridView
    Friend WithEvents Label_To As System.Windows.Forms.Label
    Friend WithEvents Label_From As System.Windows.Forms.Label
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents ImageList_Button As System.Windows.Forms.ImageList
    Friend WithEvents BindingSource_Availabilities As System.Windows.Forms.BindingSource
    Friend WithEvents Button_Delete As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox_To As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_From As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CheckBox_byArrangement As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip_Tree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem_Tree As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem_Tree As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboBox_Weekday As System.Windows.Forms.ComboBox
    Friend WithEvents Label_WeekDay As System.Windows.Forms.Label

End Class
