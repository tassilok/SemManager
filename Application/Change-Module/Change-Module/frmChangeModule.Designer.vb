<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeModule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeModule))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_ClockLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Clock = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton_StartClock = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_PauseClock = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_StopClock = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_ResetClock = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_MoveFirst = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MovePrevious = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MoveNext = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_MoveLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel_TicketCount = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView_Ticket = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip_ProcessTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LoggingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorSolvedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObsoleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubIncidentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer_Description_RefHist = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer_Description = New System.Windows.Forms.SplitContainer()
        Me.Label_Description_Ticket = New System.Windows.Forms.Label()
        Me.TextBox_Description_Ticket = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_Description_Process = New System.Windows.Forms.Panel()
        Me.Label_Description_Process = New System.Windows.Forms.Label()
        Me.TextBox_Description_Process = New System.Windows.Forms.TextBox()
        Me.Panel_Description_ProcessLog = New System.Windows.Forms.Panel()
        Me.Label_Description_ProcessLog = New System.Windows.Forms.Label()
        Me.TextBox_Description_ProcessLog = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_References_And_Log = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel_References_History = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_References = New System.Windows.Forms.Panel()
        Me.Panel_History = New System.Windows.Forms.Panel()
        Me.TabPage_Images = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage_Process_Images = New System.Windows.Forms.TabPage()
        Me.TabPage_ProcessLog_Images = New System.Windows.Forms.TabPage()
        Me.TabPage_MediaItems = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage_ProcessMediaItem = New System.Windows.Forms.TabPage()
        Me.TabPage_ProcessLog_MediaItem = New System.Windows.Forms.TabPage()
        Me.TabPage_PDF = New System.Windows.Forms.TabPage()
        Me.TabControl_PDF = New System.Windows.Forms.TabControl()
        Me.TabPage_Process_PDF = New System.Windows.Forms.TabPage()
        Me.TabPage_PDF_ProcessLog = New System.Windows.Forms.TabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Tickets = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_TicketDoc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel_Doc = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_TicketIDLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_ID = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel_TicketNameLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_Name = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel_Reference = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox_Reference = New System.Windows.Forms.ToolStripTextBox()
        Me.Timer_Description_Ticket = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Description_ProcessLog = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Description_Process = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip_ProcessTree.SuspendLayout()
        CType(Me.SplitContainer_Description_RefHist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Description_RefHist.Panel1.SuspendLayout()
        Me.SplitContainer_Description_RefHist.Panel2.SuspendLayout()
        Me.SplitContainer_Description_RefHist.SuspendLayout()
        CType(Me.SplitContainer_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Description.Panel1.SuspendLayout()
        Me.SplitContainer_Description.Panel2.SuspendLayout()
        Me.SplitContainer_Description.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel_Description_Process.SuspendLayout()
        Me.Panel_Description_ProcessLog.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_References_And_Log.SuspendLayout()
        Me.TableLayoutPanel_References_History.SuspendLayout()
        Me.TabPage_Images.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage_MediaItems.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage_PDF.SuspendLayout()
        Me.TabControl_PDF.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(934, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ToolsToolStripMenuItem.Text = "x_Extras"
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(934, 555)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(934, 605)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Close, Me.ToolStripSeparator1, Me.ToolStripLabel_ClockLBL, Me.ToolStripLabel_Clock, Me.ToolStripButton_StartClock, Me.ToolStripButton_PauseClock, Me.ToolStripButton_StopClock, Me.ToolStripButton_ResetClock, Me.ToolStripSeparator2, Me.ToolStripButton_MoveFirst, Me.ToolStripButton_MovePrevious, Me.ToolStripButton_MoveNext, Me.ToolStripButton_MoveLast, Me.ToolStripLabel_TicketCount})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(396, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Close
        '
        Me.ToolStripButton_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton_Close.Image = CType(resources.GetObject("ToolStripButton_Close.Image"), System.Drawing.Image)
        Me.ToolStripButton_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
        Me.ToolStripButton_Close.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton_Close.Text = "x_Close"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_ClockLBL
        '
        Me.ToolStripLabel_ClockLBL.Name = "ToolStripLabel_ClockLBL"
        Me.ToolStripLabel_ClockLBL.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripLabel_ClockLBL.Text = "x_Stoppuhr:"
        '
        'ToolStripLabel_Clock
        '
        Me.ToolStripLabel_Clock.Name = "ToolStripLabel_Clock"
        Me.ToolStripLabel_Clock.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel_Clock.Text = "00:00:00"
        '
        'ToolStripButton_StartClock
        '
        Me.ToolStripButton_StartClock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_StartClock.Enabled = False
        Me.ToolStripButton_StartClock.Image = Global.Change_Module.My.Resources.Resources._next
        Me.ToolStripButton_StartClock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_StartClock.Name = "ToolStripButton_StartClock"
        Me.ToolStripButton_StartClock.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_StartClock.Text = "ToolStripButton1"
        '
        'ToolStripButton_PauseClock
        '
        Me.ToolStripButton_PauseClock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_PauseClock.Enabled = False
        Me.ToolStripButton_PauseClock.Image = Global.Change_Module.My.Resources.Resources.b_down_Infinite
        Me.ToolStripButton_PauseClock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_PauseClock.Name = "ToolStripButton_PauseClock"
        Me.ToolStripButton_PauseClock.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_PauseClock.Text = "ToolStripButton1"
        '
        'ToolStripButton_StopClock
        '
        Me.ToolStripButton_StopClock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_StopClock.Enabled = False
        Me.ToolStripButton_StopClock.Image = Global.Change_Module.My.Resources.Resources.b_stop
        Me.ToolStripButton_StopClock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_StopClock.Name = "ToolStripButton_StopClock"
        Me.ToolStripButton_StopClock.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_StopClock.Text = "ToolStripButton2"
        '
        'ToolStripButton_ResetClock
        '
        Me.ToolStripButton_ResetClock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_ResetClock.Enabled = False
        Me.ToolStripButton_ResetClock.Image = Global.Change_Module.My.Resources.Resources.back
        Me.ToolStripButton_ResetClock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ResetClock.Name = "ToolStripButton_ResetClock"
        Me.ToolStripButton_ResetClock.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_ResetClock.Text = "ToolStripButton3"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_MoveFirst
        '
        Me.ToolStripButton_MoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MoveFirst.Enabled = False
        Me.ToolStripButton_MoveFirst.Image = Global.Change_Module.My.Resources.Resources.pulsante_01_architetto_f_01_First
        Me.ToolStripButton_MoveFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MoveFirst.Name = "ToolStripButton_MoveFirst"
        Me.ToolStripButton_MoveFirst.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MoveFirst.Text = "ToolStripButton1"
        '
        'ToolStripButton_MovePrevious
        '
        Me.ToolStripButton_MovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MovePrevious.Enabled = False
        Me.ToolStripButton_MovePrevious.Image = Global.Change_Module.My.Resources.Resources.pulsante_01_architetto_f_01
        Me.ToolStripButton_MovePrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MovePrevious.Name = "ToolStripButton_MovePrevious"
        Me.ToolStripButton_MovePrevious.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MovePrevious.Text = "ToolStripButton2"
        '
        'ToolStripButton_MoveNext
        '
        Me.ToolStripButton_MoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MoveNext.Enabled = False
        Me.ToolStripButton_MoveNext.Image = Global.Change_Module.My.Resources.Resources.pulsante_02_architetto_f_01
        Me.ToolStripButton_MoveNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MoveNext.Name = "ToolStripButton_MoveNext"
        Me.ToolStripButton_MoveNext.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MoveNext.Text = "ToolStripButton3"
        '
        'ToolStripButton_MoveLast
        '
        Me.ToolStripButton_MoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_MoveLast.Enabled = False
        Me.ToolStripButton_MoveLast.Image = Global.Change_Module.My.Resources.Resources.pulsante_02_architetto_f_01_Last
        Me.ToolStripButton_MoveLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_MoveLast.Name = "ToolStripButton_MoveLast"
        Me.ToolStripButton_MoveLast.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_MoveLast.Text = "ToolStripButton4"
        '
        'ToolStripLabel_TicketCount
        '
        Me.ToolStripLabel_TicketCount.Name = "ToolStripLabel_TicketCount"
        Me.ToolStripLabel_TicketCount.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripLabel_TicketCount.Text = "0/0"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView_Ticket)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer_Description_RefHist)
        Me.SplitContainer1.Size = New System.Drawing.Size(934, 555)
        Me.SplitContainer1.SplitterDistance = 311
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView_Ticket
        '
        Me.TreeView_Ticket.CheckBoxes = True
        Me.TreeView_Ticket.ContextMenuStrip = Me.ContextMenuStrip_ProcessTree
        Me.TreeView_Ticket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_Ticket.ImageIndex = 0
        Me.TreeView_Ticket.ImageList = Me.ImageList_Main
        Me.TreeView_Ticket.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_Ticket.Name = "TreeView_Ticket"
        Me.TreeView_Ticket.SelectedImageIndex = 0
        Me.TreeView_Ticket.Size = New System.Drawing.Size(307, 551)
        Me.TreeView_Ticket.TabIndex = 0
        '
        'ContextMenuStrip_ProcessTree
        '
        Me.ContextMenuStrip_ProcessTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoggingToolStripMenuItem, Me.NewToolStripMenuItem})
        Me.ContextMenuStrip_ProcessTree.Name = "ContextMenuStrip_ProcessTree"
        Me.ContextMenuStrip_ProcessTree.Size = New System.Drawing.Size(124, 48)
        '
        'LoggingToolStripMenuItem
        '
        Me.LoggingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ErrorToolStripMenuItem, Me.ErrorSolvedToolStripMenuItem, Me.InformationToolStripMenuItem, Me.ObsoleteToolStripMenuItem})
        Me.LoggingToolStripMenuItem.Name = "LoggingToolStripMenuItem"
        Me.LoggingToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LoggingToolStripMenuItem.Text = "x_Logging"
        '
        'ErrorToolStripMenuItem
        '
        Me.ErrorToolStripMenuItem.Name = "ErrorToolStripMenuItem"
        Me.ErrorToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ErrorToolStripMenuItem.Text = "x_Error"
        '
        'ErrorSolvedToolStripMenuItem
        '
        Me.ErrorSolvedToolStripMenuItem.Name = "ErrorSolvedToolStripMenuItem"
        Me.ErrorSolvedToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ErrorSolvedToolStripMenuItem.Text = "x_Error solved"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.InformationToolStripMenuItem.Text = "x_Information"
        '
        'ObsoleteToolStripMenuItem
        '
        Me.ObsoleteToolStripMenuItem.Name = "ObsoleteToolStripMenuItem"
        Me.ObsoleteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ObsoleteToolStripMenuItem.Text = "x_Obsolete"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubProcessToolStripMenuItem, Me.SubIncidentToolStripMenuItem, Me.SubTicketToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.NewToolStripMenuItem.Text = "x_New"
        '
        'SubProcessToolStripMenuItem
        '
        Me.SubProcessToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.ExistingToolStripMenuItem})
        Me.SubProcessToolStripMenuItem.Name = "SubProcessToolStripMenuItem"
        Me.SubProcessToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SubProcessToolStripMenuItem.Text = "x_Sub-Process"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.NewToolStripMenuItem1.Text = "x_New"
        '
        'ExistingToolStripMenuItem
        '
        Me.ExistingToolStripMenuItem.Name = "ExistingToolStripMenuItem"
        Me.ExistingToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ExistingToolStripMenuItem.Text = "x_Existing"
        '
        'SubIncidentToolStripMenuItem
        '
        Me.SubIncidentToolStripMenuItem.Name = "SubIncidentToolStripMenuItem"
        Me.SubIncidentToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SubIncidentToolStripMenuItem.Text = "x_Sub-Incident"
        '
        'SubTicketToolStripMenuItem
        '
        Me.SubTicketToolStripMenuItem.Name = "SubTicketToolStripMenuItem"
        Me.SubTicketToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SubTicketToolStripMenuItem.Text = "x_Sub-Ticket"
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ImageStream = CType(resources.GetObject("ImageList_Main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Main.Images.SetKeyName(0, "gnome-mime-application-vnd.ms-powerpoint.png")
        Me.ImageList_Main.Images.SetKeyName(1, "cog_01.png")
        Me.ImageList_Main.Images.SetKeyName(2, "construction_hammer_jon__01.png")
        Me.ImageList_Main.Images.SetKeyName(3, "cog_01_w_doc.png")
        Me.ImageList_Main.Images.SetKeyName(4, "construction_hammer_jon__01_w_doc.png")
        Me.ImageList_Main.Images.SetKeyName(5, "bb_home_.png")
        '
        'SplitContainer_Description_RefHist
        '
        Me.SplitContainer_Description_RefHist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer_Description_RefHist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Description_RefHist.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Description_RefHist.Name = "SplitContainer_Description_RefHist"
        Me.SplitContainer_Description_RefHist.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer_Description_RefHist.Panel1
        '
        Me.SplitContainer_Description_RefHist.Panel1.Controls.Add(Me.SplitContainer_Description)
        '
        'SplitContainer_Description_RefHist.Panel2
        '
        Me.SplitContainer_Description_RefHist.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer_Description_RefHist.Size = New System.Drawing.Size(619, 555)
        Me.SplitContainer_Description_RefHist.SplitterDistance = 206
        Me.SplitContainer_Description_RefHist.TabIndex = 0
        '
        'SplitContainer_Description
        '
        Me.SplitContainer_Description.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer_Description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Description.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Description.Name = "SplitContainer_Description"
        Me.SplitContainer_Description.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer_Description.Panel1
        '
        Me.SplitContainer_Description.Panel1.Controls.Add(Me.Label_Description_Ticket)
        Me.SplitContainer_Description.Panel1.Controls.Add(Me.TextBox_Description_Ticket)
        '
        'SplitContainer_Description.Panel2
        '
        Me.SplitContainer_Description.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer_Description.Size = New System.Drawing.Size(619, 206)
        Me.SplitContainer_Description.SplitterDistance = 103
        Me.SplitContainer_Description.TabIndex = 0
        '
        'Label_Description_Ticket
        '
        Me.Label_Description_Ticket.AutoSize = True
        Me.Label_Description_Ticket.Location = New System.Drawing.Point(3, 2)
        Me.Label_Description_Ticket.Name = "Label_Description_Ticket"
        Me.Label_Description_Ticket.Size = New System.Drawing.Size(113, 13)
        Me.Label_Description_Ticket.TabIndex = 2
        Me.Label_Description_Ticket.Text = "x_Description (Ticket):"
        '
        'TextBox_Description_Ticket
        '
        Me.TextBox_Description_Ticket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Description_Ticket.Location = New System.Drawing.Point(3, 18)
        Me.TextBox_Description_Ticket.Multiline = True
        Me.TextBox_Description_Ticket.Name = "TextBox_Description_Ticket"
        Me.TextBox_Description_Ticket.ReadOnly = True
        Me.TextBox_Description_Ticket.Size = New System.Drawing.Size(612, 78)
        Me.TextBox_Description_Ticket.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_Description_Process, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_Description_ProcessLog, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(615, 95)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel_Description_Process
        '
        Me.Panel_Description_Process.Controls.Add(Me.Label_Description_Process)
        Me.Panel_Description_Process.Controls.Add(Me.TextBox_Description_Process)
        Me.Panel_Description_Process.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Description_Process.Location = New System.Drawing.Point(3, 3)
        Me.Panel_Description_Process.Name = "Panel_Description_Process"
        Me.Panel_Description_Process.Size = New System.Drawing.Size(301, 89)
        Me.Panel_Description_Process.TabIndex = 0
        '
        'Label_Description_Process
        '
        Me.Label_Description_Process.AutoSize = True
        Me.Label_Description_Process.Location = New System.Drawing.Point(0, 1)
        Me.Label_Description_Process.Name = "Label_Description_Process"
        Me.Label_Description_Process.Size = New System.Drawing.Size(121, 13)
        Me.Label_Description_Process.TabIndex = 1
        Me.Label_Description_Process.Text = "x_Description (Process):"
        '
        'TextBox_Description_Process
        '
        Me.TextBox_Description_Process.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Description_Process.Location = New System.Drawing.Point(0, 17)
        Me.TextBox_Description_Process.Multiline = True
        Me.TextBox_Description_Process.Name = "TextBox_Description_Process"
        Me.TextBox_Description_Process.ReadOnly = True
        Me.TextBox_Description_Process.Size = New System.Drawing.Size(301, 72)
        Me.TextBox_Description_Process.TabIndex = 3
        '
        'Panel_Description_ProcessLog
        '
        Me.Panel_Description_ProcessLog.Controls.Add(Me.Label_Description_ProcessLog)
        Me.Panel_Description_ProcessLog.Controls.Add(Me.TextBox_Description_ProcessLog)
        Me.Panel_Description_ProcessLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Description_ProcessLog.Location = New System.Drawing.Point(310, 3)
        Me.Panel_Description_ProcessLog.Name = "Panel_Description_ProcessLog"
        Me.Panel_Description_ProcessLog.Size = New System.Drawing.Size(302, 89)
        Me.Panel_Description_ProcessLog.TabIndex = 1
        '
        'Label_Description_ProcessLog
        '
        Me.Label_Description_ProcessLog.AutoSize = True
        Me.Label_Description_ProcessLog.Location = New System.Drawing.Point(3, 1)
        Me.Label_Description_ProcessLog.Name = "Label_Description_ProcessLog"
        Me.Label_Description_ProcessLog.Size = New System.Drawing.Size(142, 13)
        Me.Label_Description_ProcessLog.TabIndex = 4
        Me.Label_Description_ProcessLog.Text = "x_Description (Process-Log):"
        '
        'TextBox_Description_ProcessLog
        '
        Me.TextBox_Description_ProcessLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Description_ProcessLog.Location = New System.Drawing.Point(3, 17)
        Me.TextBox_Description_ProcessLog.Multiline = True
        Me.TextBox_Description_ProcessLog.Name = "TextBox_Description_ProcessLog"
        Me.TextBox_Description_ProcessLog.ReadOnly = True
        Me.TextBox_Description_ProcessLog.Size = New System.Drawing.Size(297, 70)
        Me.TextBox_Description_ProcessLog.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_References_And_Log)
        Me.TabControl1.Controls.Add(Me.TabPage_Images)
        Me.TabControl1.Controls.Add(Me.TabPage_MediaItems)
        Me.TabControl1.Controls.Add(Me.TabPage_PDF)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(615, 341)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage_References_And_Log
        '
        Me.TabPage_References_And_Log.Controls.Add(Me.TableLayoutPanel_References_History)
        Me.TabPage_References_And_Log.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_References_And_Log.Name = "TabPage_References_And_Log"
        Me.TabPage_References_And_Log.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_References_And_Log.Size = New System.Drawing.Size(607, 315)
        Me.TabPage_References_And_Log.TabIndex = 0
        Me.TabPage_References_And_Log.Text = "x_References And Logs"
        Me.TabPage_References_And_Log.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_References_History
        '
        Me.TableLayoutPanel_References_History.ColumnCount = 1
        Me.TableLayoutPanel_References_History.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_References_History.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_References_History.Controls.Add(Me.Panel_References, 0, 0)
        Me.TableLayoutPanel_References_History.Controls.Add(Me.Panel_History, 0, 1)
        Me.TableLayoutPanel_References_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_References_History.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel_References_History.Name = "TableLayoutPanel_References_History"
        Me.TableLayoutPanel_References_History.RowCount = 2
        Me.TableLayoutPanel_References_History.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5!))
        Me.TableLayoutPanel_References_History.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TableLayoutPanel_References_History.Size = New System.Drawing.Size(601, 309)
        Me.TableLayoutPanel_References_History.TabIndex = 0
        '
        'Panel_References
        '
        Me.Panel_References.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_References.Location = New System.Drawing.Point(3, 3)
        Me.Panel_References.Name = "Panel_References"
        Me.Panel_References.Size = New System.Drawing.Size(595, 187)
        Me.Panel_References.TabIndex = 0
        '
        'Panel_History
        '
        Me.Panel_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_History.Location = New System.Drawing.Point(3, 196)
        Me.Panel_History.Name = "Panel_History"
        Me.Panel_History.Size = New System.Drawing.Size(595, 110)
        Me.Panel_History.TabIndex = 1
        '
        'TabPage_Images
        '
        Me.TabPage_Images.Controls.Add(Me.TabControl2)
        Me.TabPage_Images.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Images.Name = "TabPage_Images"
        Me.TabPage_Images.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Images.Size = New System.Drawing.Size(607, 315)
        Me.TabPage_Images.TabIndex = 1
        Me.TabPage_Images.Text = "x_Images"
        Me.TabPage_Images.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage_Process_Images)
        Me.TabControl2.Controls.Add(Me.TabPage_ProcessLog_Images)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(601, 309)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage_Process_Images
        '
        Me.TabPage_Process_Images.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Process_Images.Name = "TabPage_Process_Images"
        Me.TabPage_Process_Images.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Process_Images.Size = New System.Drawing.Size(593, 283)
        Me.TabPage_Process_Images.TabIndex = 0
        Me.TabPage_Process_Images.Text = "x_Process"
        Me.TabPage_Process_Images.UseVisualStyleBackColor = True
        '
        'TabPage_ProcessLog_Images
        '
        Me.TabPage_ProcessLog_Images.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ProcessLog_Images.Name = "TabPage_ProcessLog_Images"
        Me.TabPage_ProcessLog_Images.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ProcessLog_Images.Size = New System.Drawing.Size(593, 283)
        Me.TabPage_ProcessLog_Images.TabIndex = 1
        Me.TabPage_ProcessLog_Images.Text = "x_Process-Log"
        Me.TabPage_ProcessLog_Images.UseVisualStyleBackColor = True
        '
        'TabPage_MediaItems
        '
        Me.TabPage_MediaItems.Controls.Add(Me.TabControl3)
        Me.TabPage_MediaItems.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_MediaItems.Name = "TabPage_MediaItems"
        Me.TabPage_MediaItems.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_MediaItems.Size = New System.Drawing.Size(607, 315)
        Me.TabPage_MediaItems.TabIndex = 2
        Me.TabPage_MediaItems.Text = "x_Media-Items"
        Me.TabPage_MediaItems.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage_ProcessMediaItem)
        Me.TabControl3.Controls.Add(Me.TabPage_ProcessLog_MediaItem)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(3, 3)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(601, 309)
        Me.TabControl3.TabIndex = 0
        '
        'TabPage_ProcessMediaItem
        '
        Me.TabPage_ProcessMediaItem.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ProcessMediaItem.Name = "TabPage_ProcessMediaItem"
        Me.TabPage_ProcessMediaItem.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ProcessMediaItem.Size = New System.Drawing.Size(593, 283)
        Me.TabPage_ProcessMediaItem.TabIndex = 0
        Me.TabPage_ProcessMediaItem.Text = "x_Procss"
        Me.TabPage_ProcessMediaItem.UseVisualStyleBackColor = True
        '
        'TabPage_ProcessLog_MediaItem
        '
        Me.TabPage_ProcessLog_MediaItem.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ProcessLog_MediaItem.Name = "TabPage_ProcessLog_MediaItem"
        Me.TabPage_ProcessLog_MediaItem.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ProcessLog_MediaItem.Size = New System.Drawing.Size(593, 283)
        Me.TabPage_ProcessLog_MediaItem.TabIndex = 1
        Me.TabPage_ProcessLog_MediaItem.Text = "x_Process_Log"
        Me.TabPage_ProcessLog_MediaItem.UseVisualStyleBackColor = True
        '
        'TabPage_PDF
        '
        Me.TabPage_PDF.Controls.Add(Me.TabControl_PDF)
        Me.TabPage_PDF.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_PDF.Name = "TabPage_PDF"
        Me.TabPage_PDF.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_PDF.Size = New System.Drawing.Size(607, 315)
        Me.TabPage_PDF.TabIndex = 3
        Me.TabPage_PDF.Text = "x_PDF"
        Me.TabPage_PDF.UseVisualStyleBackColor = True
        '
        'TabControl_PDF
        '
        Me.TabControl_PDF.Controls.Add(Me.TabPage_Process_PDF)
        Me.TabControl_PDF.Controls.Add(Me.TabPage_PDF_ProcessLog)
        Me.TabControl_PDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_PDF.Location = New System.Drawing.Point(3, 3)
        Me.TabControl_PDF.Name = "TabControl_PDF"
        Me.TabControl_PDF.SelectedIndex = 0
        Me.TabControl_PDF.Size = New System.Drawing.Size(601, 309)
        Me.TabControl_PDF.TabIndex = 0
        '
        'TabPage_Process_PDF
        '
        Me.TabPage_Process_PDF.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Process_PDF.Name = "TabPage_Process_PDF"
        Me.TabPage_Process_PDF.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Process_PDF.Size = New System.Drawing.Size(593, 283)
        Me.TabPage_Process_PDF.TabIndex = 0
        Me.TabPage_Process_PDF.Text = "x_Process"
        Me.TabPage_Process_PDF.UseVisualStyleBackColor = True
        '
        'TabPage_PDF_ProcessLog
        '
        Me.TabPage_PDF_ProcessLog.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_PDF_ProcessLog.Name = "TabPage_PDF_ProcessLog"
        Me.TabPage_PDF_ProcessLog.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_PDF_ProcessLog.Size = New System.Drawing.Size(593, 283)
        Me.TabPage_PDF_ProcessLog.TabIndex = 1
        Me.TabPage_PDF_ProcessLog.Text = "x_Process-Log"
        Me.TabPage_PDF_ProcessLog.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Tickets, Me.ToolStripSeparator3, Me.ToolStripButton_TicketDoc, Me.ToolStripLabel_Doc, Me.ToolStripSeparator4, Me.ToolStripLabel_TicketIDLBL, Me.ToolStripTextBox_ID, Me.ToolStripLabel_TicketNameLBL, Me.ToolStripTextBox_Name, Me.ToolStripSeparator5, Me.ToolStripLabel_Reference, Me.ToolStripTextBox_Reference})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(801, 25)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripButton_Tickets
        '
        Me.ToolStripButton_Tickets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Tickets.Image = Global.Change_Module.My.Resources.Resources.gnome_mime_application_vnd_ms_powerpoint
        Me.ToolStripButton_Tickets.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Tickets.Name = "ToolStripButton_Tickets"
        Me.ToolStripButton_Tickets.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_Tickets.Text = "ToolStripButton5"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton_TicketDoc
        '
        Me.ToolStripButton_TicketDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_TicketDoc.Enabled = False
        Me.ToolStripButton_TicketDoc.Image = Global.Change_Module.My.Resources.Resources.bb_txt_
        Me.ToolStripButton_TicketDoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_TicketDoc.Name = "ToolStripButton_TicketDoc"
        Me.ToolStripButton_TicketDoc.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton_TicketDoc.Text = "ToolStripButton5"
        '
        'ToolStripLabel_Doc
        '
        Me.ToolStripLabel_Doc.Name = "ToolStripLabel_Doc"
        Me.ToolStripLabel_Doc.Size = New System.Drawing.Size(11, 22)
        Me.ToolStripLabel_Doc.Text = "-"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_TicketIDLBL
        '
        Me.ToolStripLabel_TicketIDLBL.Name = "ToolStripLabel_TicketIDLBL"
        Me.ToolStripLabel_TicketIDLBL.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripLabel_TicketIDLBL.Text = "x_Ticket-Nr.:"
        '
        'ToolStripTextBox_ID
        '
        Me.ToolStripTextBox_ID.Name = "ToolStripTextBox_ID"
        Me.ToolStripTextBox_ID.ReadOnly = True
        Me.ToolStripTextBox_ID.Size = New System.Drawing.Size(40, 25)
        '
        'ToolStripLabel_TicketNameLBL
        '
        Me.ToolStripLabel_TicketNameLBL.Name = "ToolStripLabel_TicketNameLBL"
        Me.ToolStripLabel_TicketNameLBL.Size = New System.Drawing.Size(83, 22)
        Me.ToolStripLabel_TicketNameLBL.Text = "x_Bezeichnung:"
        '
        'ToolStripTextBox_Name
        '
        Me.ToolStripTextBox_Name.Name = "ToolStripTextBox_Name"
        Me.ToolStripTextBox_Name.ReadOnly = True
        Me.ToolStripTextBox_Name.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel_Reference
        '
        Me.ToolStripLabel_Reference.Name = "ToolStripLabel_Reference"
        Me.ToolStripLabel_Reference.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripLabel_Reference.Text = "x_Referenz:"
        '
        'ToolStripTextBox_Reference
        '
        Me.ToolStripTextBox_Reference.Name = "ToolStripTextBox_Reference"
        Me.ToolStripTextBox_Reference.ReadOnly = True
        Me.ToolStripTextBox_Reference.Size = New System.Drawing.Size(200, 25)
        '
        'Timer_Description_Ticket
        '
        Me.Timer_Description_Ticket.Interval = 300
        '
        'Timer_Description_ProcessLog
        '
        Me.Timer_Description_ProcessLog.Interval = 300
        '
        'Timer_Description_Process
        '
        Me.Timer_Description_Process.Interval = 300
        '
        'frmChangeModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 629)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmChangeModule"
        Me.Text = "x_Change-Module"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip_ProcessTree.ResumeLayout(False)
        Me.SplitContainer_Description_RefHist.Panel1.ResumeLayout(False)
        Me.SplitContainer_Description_RefHist.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Description_RefHist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Description_RefHist.ResumeLayout(False)
        Me.SplitContainer_Description.Panel1.ResumeLayout(False)
        Me.SplitContainer_Description.Panel1.PerformLayout()
        Me.SplitContainer_Description.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Description, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Description.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel_Description_Process.ResumeLayout(False)
        Me.Panel_Description_Process.PerformLayout()
        Me.Panel_Description_ProcessLog.ResumeLayout(False)
        Me.Panel_Description_ProcessLog.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_References_And_Log.ResumeLayout(False)
        Me.TableLayoutPanel_References_History.ResumeLayout(False)
        Me.TabPage_Images.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage_MediaItems.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage_PDF.ResumeLayout(False)
        Me.TabControl_PDF.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ImageList_Main As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_ClockLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Clock As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton_StartClock As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_StopClock As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_ResetClock As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_PauseClock As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton_MoveFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MovePrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MoveNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_MoveLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_TicketDoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton_Tickets As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_Doc As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_TicketCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TreeView_Ticket As System.Windows.Forms.TreeView
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_TicketIDLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_ID As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel_TicketNameLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Name As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel_Reference As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox_Reference As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Timer_Description_Ticket As System.Windows.Forms.Timer
    Friend WithEvents Timer_Description_ProcessLog As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer_Description_RefHist As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel_References_History As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel_References As System.Windows.Forms.Panel
    Friend WithEvents Panel_History As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer_Description As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel_Description_Process As System.Windows.Forms.Panel
    Friend WithEvents Panel_Description_ProcessLog As System.Windows.Forms.Panel
    Friend WithEvents Label_Description_Ticket As System.Windows.Forms.Label
    Friend WithEvents TextBox_Description_Ticket As System.Windows.Forms.TextBox
    Friend WithEvents Label_Description_Process As System.Windows.Forms.Label
    Friend WithEvents TextBox_Description_Process As System.Windows.Forms.TextBox
    Friend WithEvents Label_Description_ProcessLog As System.Windows.Forms.Label
    Friend WithEvents TextBox_Description_ProcessLog As System.Windows.Forms.TextBox
    Friend WithEvents Timer_Description_Process As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip_ProcessTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LoggingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorSolvedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObsoleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubIncidentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubTicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExistingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_References_And_Log As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Images As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Process_Images As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_ProcessLog_Images As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_MediaItems As System.Windows.Forms.TabPage
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_ProcessMediaItem As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_ProcessLog_MediaItem As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_PDF As System.Windows.Forms.TabPage
    Friend WithEvents TabControl_PDF As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Process_PDF As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_PDF_ProcessLog As System.Windows.Forms.TabPage

End Class
