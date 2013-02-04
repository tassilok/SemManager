Public Class UserControl_TypeTree
    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Class_Closed As Integer = 1
    Private Const cint_ImageID_Class_Opened As Integer = 2
    Private Const cint_ImageID_Attribute As Integer = 3
    Private Const cint_ImageID_RelationType As Integer = 4

    Private objList_Classes As List(Of clsOntologyItem)

    Private objTreeNode_Root As TreeNode

    Private objLocalConfig As clsLocalConfig

    Private objOItem_Class_Selected As clsOntologyItem

    Private objDBLevel As clsDBLevel

    Public Event selected_Class(ByVal OItem_Class As clsOntologyItem)

    Public Function get_SelectedNode() As TreeNode
        Return TreeView_Types.SelectedNode
    End Function

    Public Sub New(ByVal Globals As clsGlobals)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objLocalConfig = New clsLocalConfig(Globals)
        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objLocalConfig = LocalConfig
        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        get_Data_Classes()
        
    End Sub

    Public Sub initialize_Tree()
        TreeView_Types.Nodes.Clear()
        objTreeNode_Root = TreeView_Types.Nodes.Add(objLocalConfig.Globals.Root.GUID.ToString, _
                                                    objLocalConfig.Globals.Root.Name, _
                                                    cint_ImageID_Root, _
                                                    cint_ImageID_Root)
        fill_Tree(objTreeNode_Root)
        TreeView_Types.Sort()
        ToolStripLabel_Count.Text = objList_Classes.Count.ToString
    End Sub

    Private Sub fill_Tree(ByVal objTreeNode As TreeNode)
        Dim objTreeNode_Sub As TreeNode

       
        Dim a = From obja In objList_Classes
        Where (obja.GUID_Parent = objTreeNode.Name)

        For Each b In a
            objTreeNode_Sub = objTreeNode.Nodes.Add(b.GUID.ToString, _
                                        b.Name, _
                                        cint_ImageID_Class_Closed, _
                                        cint_ImageID_Class_Opened)
            fill_Tree(objTreeNode_Sub)
        Next

    End Sub

    Private Sub get_Data_Classes()
        objDBLevel.get_Data_Classes()
        objList_Classes = objDBLevel.OList_Classes

    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)
    End Sub

    Private Sub TreeView_Types_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Types.AfterSelect
        Dim objTreeNode As TreeNode

        objTreeNode = e.Node
        objOItem_Class_Selected = Nothing
        ToolStripTextBox_ID.Text = ""
        If objTreeNode.ImageIndex = cint_ImageID_Class_Closed Then
            objOItem_Class_Selected = New clsOntologyItem(objTreeNode.Name, objTreeNode.Text, objLocalConfig.Globals.Type_Class)
            RaiseEvent selected_Class(objOItem_Class_Selected)
            ToolStripTextBox_ID.Text = objTreeNode.Name
        End If
    End Sub

    Private Sub ToolStripTextBox_MarkTypes_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_MarkTypes.TextChanged
        Timer_Mark.Stop()
        Timer_Mark.Start()
    End Sub

    Private Sub Timer_Mark_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Mark.Tick
        Timer_Mark.Stop()
        filter_Classes()
    End Sub

    Private Sub filter_Classes()

        clear_Mark(objTreeNode_Root)
        If ToolStripTextBox_MarkTypes.Text <> "" Then
            mark_Nodes(ToolStripTextBox_MarkTypes.Text.ToLower)
        End If
    End Sub

    Private Sub clear_Mark(ByVal objTreeNode As TreeNode)
        Dim objTreeNode_Sub As TreeNode
        objTreeNode.BackColor = Nothing

        For Each objTreeNode_Sub In objTreeNode.Nodes
            clear_Mark(objTreeNode_Sub)
        Next

    End Sub
    Private Sub mark_Nodes(ByVal strFind As String)
        Dim objTreeNode As TreeNode
        For Each objTreeNode In TreeView_Types.Nodes
            mark_Node(objTreeNode, strFind)

        Next
    End Sub
    Private Sub expandCollapse_Parents(ByVal objTreeNode As TreeNode, ByVal boolExpand As Boolean)
        Dim objTreeNode_Parent As TreeNode

        objTreeNode_Parent = objTreeNode
        Do Until objTreeNode_Parent Is Nothing
            objTreeNode_Parent = objTreeNode_Parent.Parent
            If Not objTreeNode_Parent Is Nothing Then
                If boolExpand = True Then
                    objTreeNode_Parent.Expand()
                Else
                    objTreeNode_Parent.Collapse()
                End If
            End If
        Loop
    End Sub
    Private Sub mark_Node(ByVal objTreeNode As TreeNode, ByVal strFind As String)
        Dim objTreeNode_Sub As TreeNode
        If objTreeNode.Text.ToLower.Contains(strFind) Then
            expandCollapse_Parents(objTreeNode, True)
            objTreeNode.BackColor = Color.Yellow
        End If

        For Each objTreeNode_Sub In objTreeNode.Nodes
            mark_Node(objTreeNode_Sub, strFind)
        Next
    End Sub
End Class
