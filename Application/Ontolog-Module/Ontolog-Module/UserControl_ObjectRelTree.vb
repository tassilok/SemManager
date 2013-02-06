Public Class UserControl_ObjectRelTree
    Private objTreeNode_RelForward As TreeNode
    Private objTreeNode_RelBackward As TreeNode
    Private objTreeNode_Atttributes As TreeNode
    Private objTreeNode_Selected As TreeNode

    Private objLocalConfig As clsLocalConfig

    Private objDBLevel As clsDBLevel

    Private objOItem_Object As clsOntologyItem

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal OItem_Object As clsOntologyItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        objOItem_Object = OItem_Object

        set_DBConnection()
    End Sub

    Private Sub initialize()
        Dim objOList_Classes As New List(Of clsOntologyItem)

        objOList_Classes.Add(New clsOntologyItem(objOItem_Object.GUID_Parent, objLocalConfig.Globals.Type_Class))

        objDBLevel.get_Data_ClassRel(objOList_Classes, objLocalConfig.Globals.Direction_LeftRight, False)



    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)
    End Sub

End Class
