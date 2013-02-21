Public Class UserControl_TypeTree
    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Class_Closed As Integer = 1
    Private Const cint_ImageID_Class_Opened As Integer = 2
    Private Const cint_ImageID_Attribute As Integer = 3
    Private Const cint_ImageID_RelationType As Integer = 4

    Private objFrm_Name As frm_Name

    Private objList_Classes As List(Of clsOntologyItem)

    Private objTreeNode_Root As TreeNode

    Private objLocalConfig As clsLocalConfig

    Private objOItem_Class_Selected As clsOntologyItem

    Private objDBLevel As clsDBLevel

    Private objFrm_Class As frmClassEdit

    Public Event selected_Class(ByVal OItem_Class As clsOntologyItem)

    Public ReadOnly Property selected_Node
        Get
            Return TreeView_Types.SelectedNode
        End Get
    End Property

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

    Private Sub TreeView_Types_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView_Types.NodeMouseDoubleClick
        Dim objOItem_Class As New clsOntologyItem

        If Not e.Node.Name = objLocalConfig.Globals.Root.GUID Then
            objOItem_Class.GUID = e.Node.Name
            objOItem_Class.Name = e.Node.Text
            objOItem_Class.GUID_Parent = e.Node.Parent.Name
            objOItem_Class.Type = objLocalConfig.Globals.Type_Class

            objFrm_Class = New frmClassEdit(objLocalConfig, objOItem_Class)
            objFrm_Class.ShowDialog(Me)
            If objFrm_Class.DialogResult = DialogResult.OK Then

            End If
        End If
        
    End Sub

    Private Sub ContextMenuStrip_Classes_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Classes.Opening
        Dim objTreeNode As TreeNode

        NewToolStripMenuItem.Enabled = False

        objTreeNode = TreeView_Types.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Class_Opened Or _
                objTreeNode.ImageIndex = cint_ImageID_Root Then
                NewToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objOItem_Class As New clsOntologyItem
        Dim objOItem_Result As clsOntologyItem

        objTreeNode = TreeView_Types.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Class_Opened Or _
                objTreeNode.ImageIndex = cint_ImageID_Root Then
                objFrm_Name = New frm_Name("New Class", _
                                           objLocalConfig, _
                                           Nothing, _
                                           Nothing, _
                                           Nothing, _
                                           True)
                objFrm_Name.ShowDialog(Me)
                If objFrm_Name.DialogResult = DialogResult.OK Then
                    objOItem_Class.GUID = objFrm_Name.TextBox_GUID.Text
                    If objOItem_Class.GUID = "" Then
                        objOItem_Class.GUID = Guid.NewGuid.ToString.Replace("-", "")
                    End If
                    objOItem_Class.Name = objFrm_Name.Value1
                    objOItem_Class.GUID_Parent = objTreeNode.Name

                    objOItem_Result = objDBLevel.save_Class(objOItem_Class)

                    If objOItem_Result.GUID = objLocalConfig.Globals.LState_Exists.GUID Then
                        MsgBox("Die Klasse konnte nicht erstellt werden. Es gibt bereits eine mit diesem Namen!", MsgBoxStyle.Exclamation)
                    ElseIf objOItem_Result.GUID = objLocalConfig.Globals.LState_Error.GUID Then
                        MsgBox("Die Klasse konnte nicht erstellt werden. Es ist ein Fehler aufgetreten!", MsgBoxStyle.Critical)
                    Else
                        objTreeNode.Nodes.Add(objOItem_Class.GUID, objOItem_Class.Name, cint_ImageID_Class_Closed, cint_ImageID_Class_Opened)
                    End If


                End If
            End If
        End If
    End Sub
End Class
