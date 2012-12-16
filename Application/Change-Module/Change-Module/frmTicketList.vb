Imports Sem_Manager
Public Class frmTicketList

    Private objLocalConfig As clsLocalConfig

    Private WithEvents objUserControl_TicketList As UserControl_TicketList
    Private WithEvents objUserControl_TicketTree As UserControl_TicketTree
    Private objFrmGet_User_And_Group As frmGet_User_And_Group

    Private objTransaction_Ticket As clsTransaction_Ticket

    Private boolStart As Boolean
    Private intRowID_Selected As Integer
    Private objSemItems_Ticket() As clsSemItem
    Private boolRelate As Boolean

    Private Sub related_Tree() Handles objUserControl_TicketTree.related
        objUserControl_TicketList.relatedTree()

    End Sub
    Private Sub applied_TicketLists(ByVal TreeNode_Applied As TreeNode) Handles objUserControl_TicketTree.applied_TicketList
        Dim objSemItem_Related As clsSemItem
        Dim objSemItem_TicketList As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intToDo As Integer
        Dim intDone As Integer

        If boolRelate = True Then
            objSemItem_TicketList.GUID = New Guid(TreeNode_Applied.Name)
            objSemItem_TicketList.Name = TreeNode_Applied.Text
            objSemItem_TicketList.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID
            objSemItem_TicketList.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_TicketList.Level = 1
            intToDo = objSemItems_Ticket.Count
            intDone = 0
            objSemItems_Ticket = objUserControl_TicketList.SemItems_Tickets
            If MsgBox("Wollen Sie die markierten Tickets der Ticketliste zuordnen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For Each objSemItem_Related In objSemItems_Ticket
                    objSemItem_Result = objTransaction_Ticket.save_015_Ticket_To_TicketList(objSemItem_TicketList, _
                                                                                            objSemItem_Related)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        intDone = intDone + 1
                    End If
                Next
            End If

            If intDone < intToDo Then
                MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Tickets der Ticketliste zugeordnet worden.", MsgBoxStyle.Information)
            End If
            objUserControl_TicketList.get_Tickets()
        Else
            MsgBox("Es sind keine Tickets markiert!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub related_Tickets() Handles objUserControl_TicketList.related_Ticket
        Dim objSemItem_Related As clsSemItem
        boolRelate = True
        ToolStripLabel_IDs.Text = ""

        objSemItems_Ticket = objUserControl_TicketList.SemItems_Tickets

        For Each objSemItem_Related In objSemItems_Ticket

            If Not ToolStripLabel_IDs.Text = "" Then
                ToolStripLabel_IDs.Text = ToolStripLabel_IDs.Text + ", "
            End If
            ToolStripLabel_IDs.Text = ToolStripLabel_IDs.Text & objSemItem_Related.Level
        Next
    End Sub

    Private Sub sel_TicketList(ByVal SemItem_TicketList) Handles objUserControl_TicketTree.sel_TicketList
        objUserControl_TicketList.refresh_TicketList(SemItem_TicketList)
    End Sub

    Private Sub refreshed_Tickets() Handles objUserControl_TicketList.refreshed_Tickets
        objUserControl_TicketTree.get_RelatedItems()
    End Sub

    Public ReadOnly Property SemItems_Ticket As clsSemItem()
        Get
            Return objSemItems_Ticket
        End Get
    End Property
    Public Property Applyable As Boolean
        Get
            Return objUserControl_TicketList.applyable
        End Get
        Set(ByVal value As Boolean)
            objUserControl_TicketList.applyable = value
        End Set
    End Property
    Private Sub choosen_Ticket(ByVal objDGVSRC As DataGridViewSelectedRowCollection) Handles objUserControl_TicketList.selected_Ticket

    End Sub

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        ToolStripButton_OpenAll.Text = objLocalConfig.SemItem_Token_Process_Ticket_Lists_Open.Name
        objFrmGet_User_And_Group = New frmGet_User_And_Group(objLocalConfig)
        get_User()
        objUserControl_TicketList = New UserControl_TicketList(objLocalConfig)
        objUserControl_TicketList.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(objUserControl_TicketList)

        objUserControl_TicketTree = New UserControl_TicketTree(objLocalConfig, ToolStripButton_OpenAll.Checked)
        objUserControl_TicketTree.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Add(objUserControl_TicketTree)

    End Sub

    Private Sub set_DBConnection()
        objTransaction_Ticket = New clsTransaction_Ticket(objLocalConfig)
    End Sub

    Private Sub get_User()
        objFrmGet_User_And_Group.ShowDialog(Me)
        If objFrmGet_User_And_Group.DialogResult = Windows.Forms.DialogResult.OK Then
            objLocalConfig.SemItem_User = objFrmGet_User_And_Group.SemItem_User
            objLocalConfig.SemItem_Group = objFrmGet_User_And_Group.SemItem_Group
            boolStart = True
        Else
            boolStart = False
        End If
    End Sub

    Private Sub frmTicketList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If boolStart = False Then
            Me.Dispose()
        End If
    End Sub

    Private Sub ToolStripButton_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Cancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Hide()
    End Sub

    Private Sub ToolStripButton_OpenAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_OpenAll.Click
        If ToolStripButton_OpenAll.Checked = True Then
            ToolStripButton_OpenAll.Checked = False
            ToolStripButton_OpenAll.Text = objLocalConfig.SemItem_Token_Process_Ticket_Lists_Open.Name
        Else
            ToolStripButton_OpenAll.Text = objLocalConfig.SemItem_Token_Process_Ticket_Lists_All.Name
            ToolStripButton_OpenAll.Checked = True
        End If

        objUserControl_TicketList.All = ToolStripButton_OpenAll.Checked
        objUserControl_TicketTree.get_RelatedItems()
    End Sub

    Private Sub ToolStripButton_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Clear.Click
        ToolStripLabel_IDs.Text = "-"
        boolRelate = False
    End Sub
End Class