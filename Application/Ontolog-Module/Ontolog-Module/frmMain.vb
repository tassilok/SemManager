Public Class frmMain
    Private objLocalConfig As clsLocalConfig

    Private WithEvents objUserControl_TypeTree As UserControl_TypeTree
    Private WithEvents objUserControl_OObjectList As UserControl_OItemList
    Private WithEvents objUserControl_ORelationTypeList As UserControl_OItemList
    Private WithEvents objUserControl_OAttributeList As UserControl_OItemList

    Private Sub selectedClass(ByVal OItem_Class As clsOntologyItem) Handles objUserControl_TypeTree.selected_Class
        objUserControl_OObjectList.initialize_Simple(New clsOntologyItem(Nothing, Nothing, OItem_Class.GUID, objLocalConfig.Globals.Type_Object))
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objLocalConfig = New clsLocalConfig(New clsGlobals)

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

    
End Class
