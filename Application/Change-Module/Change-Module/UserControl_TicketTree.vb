Imports Sem_Manager
Public Class UserControl_TicketTree
    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Tickets As Integer = 1
    Private Const cint_ImageID_Type_Closed As Integer = 2
    Private Const cint_ImageID_Type_Opened As Integer = 3
    Private Const cint_ImageID_Attribute As Integer = 4
    Private Const cint_ImageID_RelationType As Integer = 5
    Private Const cint_ImageID_Token As Integer = 6
    Private Const cint_ImageID_Type_Subitems_Closed As Integer = 7
    Private Const cint_ImageID_Type_Subitems_Opened As Integer = 8
    Private Const cint_ImageID_TicketList_Root As Integer = 9
    Private Const cint_ImageID_TicketList As Integer = 10

    Private objLocalConfig As clsLocalConfig

    Private chngviewA_TicketList As New ds_ChangeModuleTableAdapters.chngview_TicketListTableAdapter
    Private orgviewA_Item_Attribute As New ds_ChangeModuleTableAdapters.orgview_Item_AttributeTableAdapter
    Private orgviewT_Item_Attribute As New ds_ChangeModule.orgview_Item_AttributeDataTable
    Private orgviewA_Item_RelationType As New ds_ChangeModuleTableAdapters.orgview_Item_RelationTypeTableAdapter
    Private orgviewT_Item_RelationType As New ds_ChangeModule.orgview_Item_RelationTypeDataTable
    Private orgviewA_Item_Type As New ds_ChangeModuleTableAdapters.orgview_Item_TypeTableAdapter
    Private orgviewT_Item_Type As New ds_ChangeModule.orgview_Item_TypeDataTable
    Private orgviewA_Item_Token As New ds_ChangeModuleTableAdapters.orgview_Item_TokenTableAdapter
    Private orgviewT_Item_Token As New ds_ChangeModule.orgview_Item_TokenDataTable

    Private procA_TicketList_Of_Tickets As New ds_ChangeModuleTableAdapters.proc_TicketList_Of_TicketsTableAdapter
    Private procT_TicketList_Of_Tickets As New ds_ChangeModule.proc_TicketList_Of_TicketsDataTable

    Private semtblT_Token As New ds_SemDB.semtbl_TokenDataTable

    Private objDLG_Attribute_VARCHAR255 As dlgAttribute_Varchar255

    Private objTransaction_TicketTree As clsTransaction_TicketTree

    Private objTreeNode_Root As TreeNode
    Private objTreeNode_TicketList_TicketList As TreeNode
    Private objTreeNode_TicketList_Range As TreeNode
    Private objTreeNode_TicketList_ThisYear As TreeNode
    Private objTreeNode_TicketList_ThisMonth As TreeNode
    Private objTreeNode_TicketList_ThisWeek As TreeNode
    Private objTreeNode_TicketList_ThisDay As TreeNode
    Private objTreeNode_TicketList As TreeNode

    Private objTreeNode_Attribute_Root As TreeNode
    Private objTreeNode_RelationType_Root As TreeNode

    Private objThread_Related As Threading.Thread
    Private boolRelated As Boolean

    Private objSemItem_Selected As New clsSemItem

    Private boolAll As Boolean

    Public Event sel_TicketList(ByVal SemItem_TicketList As clsSemItem)
    Public Event clear_List()
    Public Event applied_TicketList(ByVal TreeNode_Selected As TreeNode)
    Public Event related()


    Public Property All As Boolean
        Get
            Return boolAll
        End Get
        Set(ByVal value As Boolean)
            boolAll = value
            get_RelatedItems()
        End Set
    End Property

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal boolAll As Boolean)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        Me.boolAll = boolAll

        set_DBConnection()
        initialize()
    End Sub

    Private Sub set_DBConnection()
        chngviewA_TicketList.Connection = objLocalConfig.Connection_Plugin
        objTransaction_TicketTree = New clsTransaction_TicketTree(objLocalConfig)
    End Sub

    Private Sub initialize()
        objTreeNode_Root = TreeView_TicketLists.Nodes.Add(objLocalConfig.SemItem_Type_Process_Ticket.GUID.ToString, objLocalConfig.SemItem_Type_Process_Ticket.Name, cint_ImageID_Root, cint_ImageID_Root)

        objTreeNode_TicketList_TicketList = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Token_Process_Ticket_Lists_ProcessTicketList.GUID.ToString, objLocalConfig.SemItem_Token_Process_Ticket_Lists_ProcessTicketList.Name, cint_ImageID_Tickets, cint_ImageID_Tickets)
        objTreeNode_TicketList_Range = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Token_Process_Ticket_Lists_Selected_Date_Range.GUID.ToString, objLocalConfig.SemItem_Token_Process_Ticket_Lists_Selected_Date_Range.Name, cint_ImageID_Tickets, cint_ImageID_Tickets)
        objTreeNode_TicketList_ThisDay = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Day.GUID.ToString, objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Day.Name, cint_ImageID_Tickets, cint_ImageID_Tickets)
        objTreeNode_TicketList_ThisWeek = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Week.GUID.ToString, objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Week.Name, cint_ImageID_Tickets, cint_ImageID_Tickets)
        objTreeNode_TicketList_ThisMonth = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Month.GUID.ToString, objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Month.Name, cint_ImageID_Tickets, cint_ImageID_Tickets)
        objTreeNode_TicketList_ThisYear = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Year.GUID.ToString, objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Year.Name, cint_ImageID_Tickets, cint_ImageID_Tickets)

        TreeView_TicketLists.SelectedNode = objTreeNode_TicketList_TicketList
        TreeView_TicketLists.Sort()
    End Sub

    Public Sub get_RelatedItems()
        Try
            objThread_Related.Abort()
        Catch ex As Exception

        End Try
        boolRelated = False
        ToolStripProgressBar_Related.Value = 0
        chngviewA_TicketList.create_Tables_Items()
        chngviewA_TicketList.create_TicketLists(objLocalConfig.SemItem_Attribute_Standard.GUID, _
                                                objLocalConfig.SemItem_Attribute_Startdate.GUID, _
                                                objLocalConfig.SemItem_Attribute_Enddate.GUID, _
                                                objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID, _
                                                objLocalConfig.SemItem_Type_Process_Ticket.GUID, _
                                                objLocalConfig.SemItem_Type_Group.GUID, _
                                                objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID)

        objThread_Related = New Threading.Thread(AddressOf get_RelatedItems_Thread)
        objThread_Related.Start()
        Timer_Related.Start()
    End Sub

    Private Sub get_RelatedItems_Thread()
        orgviewA_Item_Attribute.Connection.Close()
        orgviewA_Item_Attribute.Connection = New SqlClient.SqlConnection(objLocalConfig.ConnectionString_Plugin)
        orgviewA_Item_Attribute.Fill(orgviewT_Item_Attribute)

        orgviewA_Item_RelationType.Connection.Close()
        orgviewA_Item_RelationType.Connection = New SqlClient.SqlConnection(objLocalConfig.ConnectionString_Plugin)
        orgviewA_Item_RelationType.Fill(orgviewT_Item_RelationType)

        orgviewA_Item_Token.Connection.Close()
        orgviewA_Item_Token.Connection = New SqlClient.SqlConnection(objLocalConfig.ConnectionString_Plugin)
        orgviewA_Item_Token.Fill(orgviewT_Item_Token)

        orgviewA_Item_Type.Connection.Close()
        orgviewA_Item_Type.Connection = New SqlClient.SqlConnection(objLocalConfig.ConnectionString_Plugin)
        orgviewA_Item_Type.Fill(orgviewT_Item_Type)

        procA_TicketList_Of_Tickets.Connection.Close()
        procA_TicketList_Of_Tickets.Connection = New SqlClient.SqlConnection(objLocalConfig.ConnectionString_Plugin)
        procA_TicketList_Of_Tickets.Fill(procT_TicketList_Of_Tickets, _
                                         objLocalConfig.SemItem_Group.GUID)


        boolRelated = True
    End Sub

    Private Sub TreeView_TicketLists_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_TicketLists.AfterSelect
        Dim objTreeNode_Sel As TreeNode
        Dim objDRs_TicketList() As DataRow

        objTreeNode_Sel = e.Node
        If Not objTreeNode_Sel Is Nothing Then
            If objTreeNode_Sel.ImageIndex = cint_ImageID_Tickets Then

                Select Case New Guid(objTreeNode_Sel.Name)
                    Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_All.GUID
                        objSemItem_Selected = objLocalConfig.SemItem_Token_Process_Ticket_Lists_All
                        RaiseEvent sel_TicketList(objSemItem_Selected)
                    Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_Open.GUID
                        objSemItem_Selected = objLocalConfig.SemItem_Token_Process_Ticket_Lists_Open
                        RaiseEvent sel_TicketList(objSemItem_Selected)
                    Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_Selected_Date_Range.GUID
                        objSemItem_Selected = objLocalConfig.SemItem_Token_Process_Ticket_Lists_Selected_Date_Range
                        RaiseEvent sel_TicketList(objSemItem_Selected)
                    Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Day.GUID
                        objSemItem_Selected = objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Day
                        RaiseEvent sel_TicketList(objSemItem_Selected)
                    Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Month.GUID
                        objSemItem_Selected = objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Month
                        RaiseEvent sel_TicketList(objSemItem_Selected)
                    Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Week.GUID
                        objSemItem_Selected = objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Week
                        RaiseEvent sel_TicketList(objSemItem_Selected)
                    Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Year.GUID
                        objSemItem_Selected = objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Year
                        RaiseEvent sel_TicketList(objSemItem_Selected)
                    Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_ProcessTicketList.GUID
                        objSemItem_Selected = objLocalConfig.SemItem_Token_Process_Ticket_Lists_ProcessTicketList
                        RaiseEvent sel_TicketList(objSemItem_Selected)
                        




                End Select


            ElseIf objTreeNode_Sel.ImageIndex = cint_ImageID_TicketList Then

                objDRs_TicketList = procT_TicketList_Of_Tickets.Select("GUID_TicketList='" & objTreeNode_Sel.Name & "'")
                If objDRs_TicketList.Count > 0 Then
                    objSemItem_Selected = New clsSemItem
                    objSemItem_Selected.GUID = New Guid(objTreeNode_Sel.Name)
                    objSemItem_Selected.Name = objTreeNode_Sel.Text
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    If Not IsDBNull(objDRs_TicketList(0).Item("StartStamp")) Then
                        objSemItem_Selected.Additional1 = objDRs_TicketList(0).Item("StartStamp")
                    End If

                    If Not IsDBNull(objDRs_TicketList(0).Item("EndStamp")) Then
                        objSemItem_Selected.Additional1 = objDRs_TicketList(0).Item("EndStamp")
                    End If

                    RaiseEvent sel_TicketList(objSemItem_Selected)



                End If
            Else
                RaiseEvent clear_List()
            End If
        End If
    End Sub

    Private Sub Timer_Related_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Related.Tick

        If boolRelated = True Then
            create_TicketLists()
            create_Types()
            create_Attributes()
            create_RelationTypes()
            create_Token()
            Timer_Related.Stop()
            RaiseEvent related()
            ToolStripProgressBar_Related.Value = 0
        Else
            ToolStripProgressBar_Related.Value = 50
        End If
    End Sub

    Private Sub create_TicketLists()
        Dim objTreeNodes() As TreeNode

        objTreeNodes = TreeView_TicketLists.Nodes.Find(objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID.ToString, False)
        If objTreeNodes.Count = 0 Then
            objTreeNode_TicketList = TreeView_TicketLists.Nodes.Add(objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID.ToString, _
                                                                objLocalConfig.SemItem_Type_Process_Ticket_Lists.Name, _
                                                                cint_ImageID_TicketList_Root, _
                                                                cint_ImageID_TicketList_Root)
        Else
            objTreeNode_TicketList = objTreeNodes(0)
        End If

        objTreeNode_TicketList.Nodes.Clear()
        
        create_TicketTree(objTreeNode_TicketList)

    End Sub

    Private Sub create_TicketTree(ByVal objTreeNode As TreeNode)
        Dim objDRs_TicketList() As DataRow
        Dim objDR_TicketList As DataRow
        Dim objTreeNode_Sub As TreeNode

        If objTreeNode.Name = objTreeNode_TicketList.Name Then
            objDRs_TicketList = procT_TicketList_Of_Tickets.Select("GUID_TicketList_Parent IS NULL")
        Else
            objDRs_TicketList = procT_TicketList_Of_Tickets.Select("GUID_TicketList_Parent='" & objTreeNode.Name & "'")
        End If

        For Each objDR_TicketList In objDRs_TicketList
            objTreeNode_Sub = objTreeNode.Nodes.Add(objDR_TicketList.Item("GUID_TicketList").ToString, objDR_TicketList.Item("Name_TicketList"), cint_ImageID_TicketList, cint_ImageID_TicketList)
            create_TicketTree(objTreeNode_Sub)
        Next
    End Sub

    Private Sub create_Token()
        Dim objDRs_Token() As DataRow
        Dim objDR_Token As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Type As TreeNode

        If boolAll = False Then
            objDRs_Token = orgviewT_Item_Token.Select("GUID_LogState IS NULL")
        Else
            objDRs_Token = orgviewT_Item_Token.Select
        End If

        For Each objDR_Token In objDRs_Token
            objTreeNodes = TreeView_TicketLists.Nodes.Find(objDR_Token.Item("GUID_Type").ToString, True)
            If objTreeNodes.Count > 0 Then
                objTreeNode_Type = objTreeNodes(0)
                objTreeNodes = objTreeNode_Type.Nodes.Find(objDR_Token.Item("GUID_Token").ToString, True)
                If objTreeNodes.Count = 0 Then
                    objTreeNode_Type.Nodes.Add(objDR_Token.Item("GUID_Token").ToString, objDR_Token.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)
                End If
            End If
        Next
    End Sub

    Private Sub create_RelationTypes()
        Dim objDRs_RelationTypes() As DataRow
        Dim objDR_RelationTypes As DataRow
        Dim objTreeNodes() As TreeNode

        If boolAll = False Then
            objDRs_RelationTypes = orgviewT_Item_RelationType.Select("GUID_LogState IS NULL")
        Else
            objDRs_RelationTypes = orgviewT_Item_RelationType.Select
        End If

        If orgviewT_Item_RelationType.Count > 0 Then


            objTreeNodes = TreeView_TicketLists.Nodes.Find(objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString, False)

            If objTreeNodes.Count = 0 Then
                objTreeNode_RelationType_Root = TreeView_TicketLists.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString, objLocalConfig.Globals.ObjectReferenceType_RelationType.Name, cint_ImageID_RelationType, cint_ImageID_RelationType)
            Else
                objTreeNode_RelationType_Root = objTreeNodes(0)
            End If


            For Each objDR_RelationTypes In orgviewT_Item_RelationType.Rows
                objTreeNodes = objTreeNode_RelationType_Root.Nodes.Find(objDR_RelationTypes.Item("GUID_RelationType").ToString, False)
                If objTreeNodes.Count = 0 Then
                    objTreeNode_RelationType_Root.Nodes.Add(objDR_RelationTypes.Item("GUID_RelationType").ToString, objDR_RelationTypes.Item("Name_RelationType"), cint_ImageID_RelationType, cint_ImageID_RelationType)
                End If
            Next
        End If
    End Sub

    Private Sub create_Attributes()
        Dim objDRs_Attributes() As DataRow
        Dim objDR_Attributes As DataRow
        Dim objTreeNodes() As TreeNode

        If boolAll = False Then
            objDRs_Attributes = orgviewT_Item_Attribute.Select("GUID_LogState IS NULL")
        Else
            objDRs_Attributes = orgviewT_Item_Attribute.Select
        End If

        If orgviewT_Item_Attribute.Count > 0 Then

            objTreeNodes = TreeView_TicketLists.Nodes.Find(objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString, False)

            If objTreeNodes.Count = 0 Then
                objTreeNode_Attribute_Root = TreeView_TicketLists.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString, objLocalConfig.Globals.ObjectReferenceType_Attribute.Name, cint_ImageID_Attribute, cint_ImageID_Attribute)
            Else
                objTreeNode_Attribute_Root = objTreeNodes(0)
            End If


            For Each objDR_Attributes In orgviewT_Item_Attribute.Rows
                objTreeNodes = objTreeNode_Attribute_Root.Nodes.Find(objDR_Attributes.Item("GUID_Attribute").ToString, False)
                If objTreeNodes.Count = 0 Then
                    objTreeNode_Attribute_Root.Nodes.Add(objDR_Attributes.Item("GUID_Attribute").ToString, objDR_Attributes.Item("Name_Attribute"), cint_ImageID_Attribute, cint_ImageID_Attribute)
                End If
            Next
        End If
    End Sub

    Private Sub create_Types(Optional ByVal objTreeNode_Parent As TreeNode = Nothing)
        Dim objDRs_Type() As DataRow
        Dim objDR_Type As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode As TreeNode
        Dim intImageID_Closed As Integer
        Dim intImageID_Opened As Integer
        Dim strWHEREAll As String

        If boolAll = True Then
            strWHEREAll = ""
        Else
            strWHEREAll = " AND (GUID_LogState IS NULL OR isParent=1)"
        End If

        If objTreeNode_Parent Is Nothing Then
            objDRs_Type = orgviewT_Item_Type.Select("GUID_Type_Parent IS NULL" & strWHEREAll)
        Else
            objDRs_Type = orgviewT_Item_Type.Select("GUID_Type_Parent='" & objTreeNode_Parent.Name & "'" & strWHEREAll)
        End If

        For Each objDR_Type In objDRs_Type
            If IsDBNull(objDR_Type.Item("GUID_Ticket_Exist")) Then
                intImageID_Closed = cint_ImageID_Type_Closed
                intImageID_Opened = cint_ImageID_Type_Opened
            Else
                intImageID_Closed = cint_ImageID_Type_Subitems_Closed
                intImageID_Opened = cint_ImageID_Type_Subitems_Opened
            End If
            If objTreeNode_Parent Is Nothing Then
                objTreeNodes = TreeView_TicketLists.Nodes.Find(objDR_Type.Item("GUID_Type").ToString, False)
                If objTreeNodes.Count = 0 Then
                    objTreeNode = TreeView_TicketLists.Nodes.Add(objDR_Type.Item("GUID_Type").ToString, objDR_Type.Item("Name_Type"), intImageID_Closed, intImageID_Opened)
                Else
                    objTreeNode = objTreeNodes(0)
                End If

            Else
                objTreeNodes = objTreeNode_Parent.Nodes.Find(objDR_Type.Item("GUID_Type").ToString, False)
                If objTreeNodes.Count = 0 Then
                    objTreeNode = objTreeNode_Parent.Nodes.Add(objDR_Type.Item("GUID_Type").ToString, objDR_Type.Item("Name_Type"), intImageID_Closed, intImageID_Opened)
                Else
                    objTreeNode = objTreeNodes(0)
                End If
            End If

            create_Types(objTreeNode)
        Next
    End Sub

    Private Sub ContextMenuStrip_TicketTree_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_TicketTree.Opening
        Dim objTreeNode As TreeNode

        CreateToolStripMenuItem.Enabled = False
        RemoveToolStripMenuItem.Enabled = False
        ApplyToolStripMenuItem.Enabled = False

        objTreeNode = TreeView_TicketLists.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_TicketList Then
                CreateToolStripMenuItem.Enabled = True
                RemoveToolStripMenuItem.Enabled = True
                ApplyToolStripMenuItem.Enabled = True
            ElseIf objTreeNode.ImageIndex = cint_ImageID_TicketList_Root Then
                CreateToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub CreateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Sub As TreeNode
        Dim objSemItem_TicketList As clsSemItem
        Dim objSemItem_TicketList_Parent As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objTreeNode = TreeView_TicketLists.SelectedNode

        objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255("New " & objLocalConfig.SemItem_Type_Process_Ticket_Lists.Name, objLocalConfig.Globals)
        objDLG_Attribute_VARCHAR255.ShowDialog(Me)
        If objDLG_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
            If Not objDLG_Attribute_VARCHAR255.Value1 = "" Then
                objTreeNodes = objTreeNode.Nodes.Find(objDLG_Attribute_VARCHAR255.Value1, False)
                If objTreeNodes.Count = 0 Then
                    objSemItem_TicketList = New clsSemItem
                    objSemItem_TicketList.GUID = Guid.NewGuid
                    objSemItem_TicketList.Name = objDLG_Attribute_VARCHAR255.Value1
                    objSemItem_TicketList.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID
                    objSemItem_TicketList.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Result = objTransaction_TicketTree.save_001_TicketList(objSemItem_TicketList)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        If objTreeNode.ImageIndex = cint_ImageID_TicketList Then
                            objSemItem_TicketList_Parent = New clsSemItem
                            objSemItem_TicketList_Parent.GUID = New Guid(objTreeNode.Name)
                            objSemItem_TicketList_Parent.Name = objTreeNode.Text
                            objSemItem_TicketList_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID
                            objSemItem_TicketList_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Result = objTransaction_TicketTree.save_002_TicketList_To_TicketList(objSemItem_TicketList_Parent, _
                                                                                                            objSemItem_TicketList)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_TicketTree.del_004_TicketList_To_Standard()
                                If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_TicketTree.del_002_TicketList_To_TicketList()

                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_TicketTree.del_001_TicketList()
                                    End If

                                    MsgBox("Die Ticket-Liste konnte leider nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                                End If

                            Else
                                objTransaction_TicketTree.del_001_TicketList()
                                MsgBox("Die Ticket-Liste konnte leider nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            objSemItem_Result = objTransaction_TicketTree.save_004_TicketList_To_Standard(objSemItem_TicketList)
                            If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_TicketTree.del_001_TicketList()
                                MsgBox("Die Ticket-Liste konnte leider nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                            End If
                        End If

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_TicketTree.save_003_TicketList_To_Group(objLocalConfig.SemItem_Group, _
                                                                                                       objSemItem_TicketList)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTreeNode_Sub = objTreeNode.Nodes.Add(objSemItem_TicketList.GUID.ToString, _
                                                                            objSemItem_TicketList.Name, _
                                                                            cint_ImageID_TicketList, _
                                                                            cint_ImageID_TicketList)
                            Else
                                MsgBox("Die TicketList konnte leider nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    Else
                        MsgBox("Die Ticket-Liste konnte leider nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Es gibt bereits einen Knoten mit dem eingegebenen Namen.", MsgBoxStyle.Information)
                End If
            End If
            
        End If
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim objDR_TicketList As DataRow
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Sub As TreeNode
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_TicketList As clsSemItem
        Dim boolDel As Boolean

        objTreeNode = TreeView_TicketLists.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_TicketList Then
                boolDel = False
                If objTreeNode.Nodes.Count > 0 Then
                    If MsgBox("Die Liste enthält untergoerdnete Listen. Wollen Sie die Liste und alle untergeordnete wirklich löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        boolDel = True
                    End If
                Else
                    If MsgBox("Soll die Liste wirklich gelöscht werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        boolDel = True
                    End If

                End If
                If boolDel = True Then
                    semtblT_Token.Clear()

                    get_TicketLists(objTreeNode)

                    objSemItem_TicketList = New clsSemItem

                    For Each objDR_TicketList In semtblT_Token.Rows
                        objSemItem_TicketList.GUID = objDR_TicketList.Item("GUID_Token")
                        objSemItem_TicketList.Name = objDR_TicketList.Item("Name_Token")
                        objSemItem_TicketList.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID
                        objSemItem_TicketList.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_TicketTree.del_002_TicketList_To_TicketList(Nothing, objSemItem_TicketList)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_TicketTree.del_003_TicketList_To_Group(objLocalConfig.SemItem_Group, objSemItem_TicketList)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_TicketTree.del_004_TicketList_To_Standard(objSemItem_TicketList)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_TicketTree.del_005_TicketList_To_Ticket(Nothing, objSemItem_TicketList)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_TicketTree.del_001_TicketList(objSemItem_TicketList)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            MsgBox("Die Ticket-Listen können nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                                            Exit For
                                        Else
                                            objTreeNode.Remove()
                                        End If
                                    Else
                                        MsgBox("Die Ticket-Listen können nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                                        Exit For
                                    End If
                                Else
                                    MsgBox("Die Ticket-Listen können nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                                    Exit For
                                End If
                            Else

                                MsgBox("Die Ticket-Listen können nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Else
                            MsgBox("Die Ticket-Listen können nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                            Exit For
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub get_TicketLists(ByVal objTreeNode As TreeNode)
        Dim objTreeNode_Sub As TreeNode

        semtblT_Token.Rows.Add(New Guid(objTreeNode.Name), objTreeNode.Text, objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID)

        For Each objTreeNode_Sub In objTreeNode.Nodes
            get_TicketLists(objTreeNode)
        Next
    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        Dim objTreeNode_TicketList As TreeNode

        objTreeNode_TicketList = TreeView_TicketLists.SelectedNode

        RaiseEvent applied_TicketList(objTreeNode_TicketList)
    End Sub
End Class
