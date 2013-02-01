Public Class frmMain
    Private objLocalConfig As clsLocalConfig

    Private WithEvents objUserControl_TypeTree As UserControl_TypeTree
    Private WithEvents objUserControl_OObjectList As UserControl_OItemList
    Private WithEvents objUserControl_ORelationTypeList As UserControl_OItemList
    Private WithEvents objUserControl_OAttributeList As UserControl_OItemList

    Private objOItem As clsOntologyItem

    Private objDBLevel_ObjectRel As clsDBLevel

    Private objOList_Classes_Right As New List(Of clsOntologyItem)
    Private objOList_RelationTypes_Right As New List(Of clsOntologyItem)
    Private objOList_Classes_Left As New List(Of clsOntologyItem)
    Private objOList_RelationTypes_Left As New List(Of clsOntologyItem)

    Private Sub selectedClass(ByVal OItem_Class As clsOntologyItem) Handles objUserControl_TypeTree.selected_Class
        objUserControl_OObjectList.initialize_Simple(New clsOntologyItem(Nothing, Nothing, OItem_Class.GUID, objLocalConfig.Globals.Type_Object))
        get_ClassRel(OItem_Class)
    End Sub

    Private Sub ObjectList_Selection_Changed() Handles objUserControl_OObjectList.Selection_Changed
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        objOItem = Nothing

        If objUserControl_OObjectList.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_OObjectList.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            If SplitContainer_Token.Panel2Collapsed = False Then
                'objUserControl_TokenTree.find_Node(objDRV_Selected.Item("GUID_Token"))
            End If

            objOItem = New clsOntologyItem(objDRV_Selected.Item("ID_Object"), _
                                           objDRV_Selected.Item("Name"), _
                                           objDRV_Selected.Item("ID_Class"), _
                                           objLocalConfig.Globals.Type_Object)
            
            'get_ObjectRel(objOItem)
            'get_TokenAttribute(objSemItem_Token)



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

        objDBLevel_RightLeft.get_Data_ClassRel(objOList_Classes, objLocalConfig.Globals.Direction_RightLeft)
        objOList_Classes_Left = objDBLevel_RightLeft.OList_Classes
        objOList_RelationTypes_Left = objDBLevel_RightLeft.OList_RelationTypes

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

    End Sub

    Private Sub set_DBConnection()
        objDBLevel_ObjectRel = New clsDBLevel(objLocalConfig)
    End Sub
End Class
