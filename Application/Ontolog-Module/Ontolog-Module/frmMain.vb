Public Class frmMain
    Private objLocalConfig As clsLocalConfig

    Private WithEvents objUserControl_TypeTree As UserControl_TypeTree
    Private WithEvents objUserControl_OObjectList As UserControl_OItemList
    Private WithEvents objUserControl_ObjectTree As UserControl_ObjectTree
    Private WithEvents objUserControl_ORelationTypeList As UserControl_OItemList
    Private WithEvents objUserControl_OAttributeList As UserControl_OItemList
    Private WithEvents objUserControl_ObjRel As UserControl_ObjectRel

    Private objFrm_ObjectEdit As frm_ObjectEdit

    Private objOItem As clsOntologyItem

    Private objOItem_Class As clsOntologyItem

    Private objDBLevel_ObjectRel As clsDBLevel

    Private objOList_ClassRel_LeftRight As New List(Of clsClassRel)
    Private objOList_ClassRel_RightLeft As New List(Of clsClassRel)

    Private objOList_Classes_Right As New List(Of clsOntologyItem)
    Private objOList_RelationTypes_Right As New List(Of clsOntologyItem)
    Private objOList_Classes_Left As New List(Of clsOntologyItem)
    Private objOList_RelationTypes_Left As New List(Of clsOntologyItem)

    Private Sub editObject() Handles objUserControl_OObjectList.edit_Object
        objFrm_ObjectEdit = New frm_ObjectEdit(objLocalConfig, _
                                               objUserControl_OObjectList.DataGridviewRows, _
                                               objUserControl_OObjectList.RowID)
        objFrm_ObjectEdit.ShowDialog(Me)
        If objFrm_ObjectEdit.DialogResult = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub selectedClass(ByVal OItem_Class As clsOntologyItem) Handles objUserControl_TypeTree.selected_Class
        objOItem_Class = OItem_Class
        objUserControl_OObjectList.initialize_Simple(New clsOntologyItem(Nothing, Nothing, OItem_Class.GUID, objLocalConfig.Globals.Type_Object))
        get_ClassRel(objOItem_Class)
       
    End Sub

    Private Sub initialize_OTree()
        Dim objTreeNode As TreeNode
        Dim objOItem_Class As New clsOntologyItem
        objTreeNode = objUserControl_TypeTree.selected_Node
        If Not objTreeNode Is Nothing Then

            objOItem_Class.GUID = objTreeNode.Name
            objOItem_Class.Name = objTreeNode.Text
            objOItem_Class.Type = objLocalConfig.Globals.Type_Class

            If SplitContainer_Token.Panel2Collapsed = False Then
                objUserControl_ObjectTree.initialize(objOItem_Class)
            End If
        Else
            objUserControl_ObjectTree.clear()
        End If
        
    End Sub

    Private Sub ObjectList_Selection_Changed() Handles objUserControl_OObjectList.Selection_Changed
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objOList_Item As New List(Of clsOntologyItem)


        If objUserControl_OObjectList.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_OObjectList.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            If SplitContainer_Token.Panel2Collapsed = False Then
                'objUserControl_TokenTree.find_Node(objDRV_Selected.Item("GUID_Token"))
            End If

            objOItem = New clsOntologyItem(objDRV_Selected.Item("ID_Item"), _
                                           objDRV_Selected.Item("Name"), _
                                           objDRV_Selected.Item("ID_Parent"), _
                                           objLocalConfig.Globals.Type_Object)

            objOList_Item.Add(objOItem)
            'get_ObjectRel(objOItem)
            'get_TokenAttribute(objSemItem_Token)
            objUserControl_ObjRel.initialize_RelList(objOList_Item, _
                                                     objOList_Classes_Left, _
                                                     objOList_RelationTypes_Left, _
                                                     objOList_ClassRel_LeftRight, _
                                                     objOList_Classes_Right, _
                                                     objOList_RelationTypes_Right, _
                                                     objOList_ClassRel_RightLeft)



        Else
            'procT_TokenRel_With_Or.Clear()
            'funcT_TokenAttribute_Named_By_GUIDToken.Clear()
        End If
    End Sub

    Private Sub get_ClassRel(ByVal objOItem_Class As clsOntologyItem)

        Dim objOList_Classes As New List(Of clsOntologyItem)
        Dim objDBLevel_LeftRight As New clsDBLevel(objLocalConfig)
        Dim objDBLevel_RightLeft As New clsDBLevel(objLocalConfig)

        
        objOList_Classes.Add(objOItem_Class)

        objOList_Classes_Left.Clear()
        objOList_Classes_Right.Clear()
        objOList_RelationTypes_Left.Clear()
        objOList_RelationTypes_Right.Clear()

        objDBLevel_LeftRight.get_Data_ClassRel(objOList_Classes, objLocalConfig.Globals.Direction_LeftRight)
        objOList_Classes_Right = objDBLevel_LeftRight.OList_Classes
        objOList_RelationTypes_Right = objDBLevel_LeftRight.OList_RelationTypes
        objOList_ClassRel_LeftRight = objDBLevel_LeftRight.OList_ClassRel

        objDBLevel_RightLeft.get_Data_ClassRel(objOList_Classes, objLocalConfig.Globals.Direction_RightLeft, objLocalConfig.Globals.Type_Class)
        objOList_Classes_Left = objDBLevel_RightLeft.OList_Classes
        objOList_RelationTypes_Left = objDBLevel_RightLeft.OList_RelationTypes
        objOList_ClassRel_RightLeft = objDBLevel_RightLeft.OList_ClassRel
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        Dim objOItem_RelType As New clsOntologyItem(Nothing, Nothing, objLocalConfig.Globals.Type_RelationType)
        Dim objOItem_AttType As New clsOntologyItem(Nothing, Nothing, objLocalConfig.Globals.Type_AttributeType)

        objUserControl_TypeTree = New UserControl_TypeTree(objLocalConfig)
        objUserControl_TypeTree.Dock = DockStyle.Fill
        SplitContainer_TypeToken.Panel1.Controls.Clear()
        SplitContainer_TypeToken.Panel1.Controls.Add(objUserControl_TypeTree)


        objUserControl_TypeTree.initialize_Tree()

        objUserControl_OObjectList = New UserControl_OItemList(objLocalConfig)
        objUserControl_OObjectList.Dock = DockStyle.Fill
        SplitContainer_Token.Panel1.Controls.Clear()
        SplitContainer_Token.Panel1.Controls.Add(objUserControl_OObjectList)


        objUserControl_ORelationTypeList = New UserControl_OItemList(objLocalConfig)
        objUserControl_ORelationTypeList.Dock = DockStyle.Fill
        Panel_RelationTypes.Controls.Clear()
        objUserControl_ORelationTypeList.initialize_Simple(objOItem_RelType)
        Panel_RelationTypes.Controls.Add(objUserControl_ORelationTypeList)

        objUserControl_OAttributeList = New UserControl_OItemList(objLocalConfig)
        objUserControl_OAttributeList.Dock = DockStyle.Fill
        Panel_Attributes.Controls.Clear()
        objUserControl_OAttributeList.initialize_Simple(objOItem_AttType)
        Panel_Attributes.Controls.Add(objUserControl_OAttributeList)

        objUserControl_ObjRel = New UserControl_ObjectRel(objLocalConfig)
        objUserControl_ObjRel.Dock = DockStyle.Fill
        SplitContainer_TokAttTokRel.Panel2.Controls.Clear()
        SplitContainer_TokAttTokRel.Panel2.Controls.Add(objUserControl_ObjRel)

        objUserControl_ObjectTree = New UserControl_ObjectTree(objLocalConfig)
        objUserControl_ObjectTree.Dock = DockStyle.Fill
        SplitContainer_Token.Panel2.Controls.Clear()
        SplitContainer_Token.Panel2.Controls.Add(objUserControl_ObjectTree)

        configure_Areas()
    End Sub

    Private Sub configure_Areas()
        SplitContainer_TypeToken.Panel1Collapsed = Not ToolStripButton_Types.Checked

        SplitContainer_TypeToken.Panel2Collapsed = Not ToolStripButton_Token.Checked

        SplitContainer_Filter_Body.Panel1Collapsed = Not ToolStripButton_Filter.Checked

        SplitContainer2.Panel2Collapsed = Not ToolStripButton_AttributesAndRelations.Checked

        SplitContainer_AttribRelTokenRel.Panel1Collapsed = Not ToolStripButton_AttribRel.Checked

        SplitContainer_AttribRelTokenRel.Panel2Collapsed = Not ToolStripButton_TokenRel.Checked

        SplitContainer_Token.Panel1Collapsed = Not ToolStripButton_Token.Checked

        SplitContainer_Token.Panel2Collapsed = Not ToolStripButton_Tokentree.Checked


        ToolStripButton_Types.Checked = Not SplitContainer_TypeToken.Panel1Collapsed

        ToolStripButton_Token.Checked = Not SplitContainer_TypeToken.Panel2Collapsed


        ToolStripButton_Filter.Checked = Not SplitContainer_Filter_Body.Panel1Collapsed

        ToolStripButton_AttributesAndRelations.Checked = Not SplitContainer2.Panel2Collapsed

        ToolStripButton_AttribRel.Checked = Not SplitContainer_AttribRelTokenRel.Panel1Collapsed

        ToolStripButton_TokenRel.Checked = Not SplitContainer_AttribRelTokenRel.Panel2Collapsed

        ToolStripButton_Token.Checked = Not SplitContainer_Token.Panel1Collapsed

        ToolStripButton_Tokentree.Checked = Not SplitContainer_Token.Panel2Collapsed

        initialize_OTree()
    End Sub

    Private Sub set_DBConnection()
        objDBLevel_ObjectRel = New clsDBLevel(objLocalConfig)
    End Sub


    Private Sub ToolStripButton_Types_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton_Types.Click
        configure_Areas()
    End Sub

    Private Sub ToolStripButton_Token_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton_Token.Click
        configure_Areas()
    End Sub

    
    Private Sub ToolStripButton_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Filter.Click
        configure_Areas()
    End Sub

    Private Sub ToolStripButton_AttributesAndRelations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AttributesAndRelations.Click
        configure_Areas()
    End Sub

    Private Sub ToolStripButton_AttribRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AttribRel.Click
        configure_Areas()
    End Sub

    Private Sub ToolStripButton_TokenRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_TokenRel.Click
        configure_Areas()
    End Sub

    Private Sub ToolStripButton_Tokentree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Tokentree.Click
        configure_Areas()
    End Sub
End Class
