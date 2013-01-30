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
            objOItem_Class_Selected = New clsOntologyItem(objTreeNode.Name, objTreeNode.Text, objLocalConfig.Globals.OType_Class.GUID)
            RaiseEvent selected_Class(objOItem_Class_Selected)
            ToolStripTextBox_ID.Text = objTreeNode.Name
        End If
    End Sub
End Class
