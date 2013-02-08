Public Class UserControl_ObjectRelTree
    Private objTreeNode_RelForward As TreeNode
    Private objTreeNode_RelBackward As TreeNode
    Private objTreeNode_Atttributes As TreeNode
    Private objTreeNode_Selected As TreeNode

    Private objLocalConfig As clsLocalConfig

    Private objDBLevel As clsDBLevel
    Private objDBLevel_Count As clsDBLevel

    Private objOItem_Object As clsOntologyItem

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal OItem_Object As clsOntologyItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        objOItem_Object = OItem_Object

        set_DBConnection()

        initialize()
    End Sub

    Private Sub initialize()
        Dim objOList_Classes As New List(Of clsOntologyItem)

        objOList_Classes.Add(New clsOntologyItem(objOItem_Object.GUID_Parent, objLocalConfig.Globals.Type_Class))

        objDBLevel.get_Data_ClassRel(objOList_Classes, objLocalConfig.Globals.Direction_LeftRight, False)
        objDBLevel.get_Data_ClassAtt(objOList_Classes, False)
        objDBLevel_Count.get_Data_ObjectAtt(objOItem_Object)


        TreeView_ObjectRels.Nodes.Clear()

        objTreeNode_Atttributes = TreeView_ObjectRels.Nodes.Add(objLocalConfig.Globals.Type_AttributeType, objLocalConfig.Globals.Type_AttributeType, 0)
        objTreeNode_RelForward = TreeView_ObjectRels.Nodes.Add(objLocalConfig.Globals.Direction_LeftRight.GUID, objLocalConfig.Globals.Direction_LeftRight.Name, 0)
        objTreeNode_RelBackward = TreeView_ObjectRels.Nodes.Add(objLocalConfig.Globals.Direction_RightLeft.GUID, objLocalConfig.Globals.Direction_RightLeft.Name, 0)

        fill_Attributes()
        TreeView_ObjectRels.ExpandAll()
    End Sub

    Private Sub fill_Attributes()
        Dim objOItem_AttributeType As clsOntologyItem
        Dim objTreeNode As TreeNode
        Dim intCount As Integer

        Dim objOL_AttributeTree = From objAttType In objDBLevel.OList_ClassAtt
                                  Join objAtt In objDBLevel.OList_AttributeTypes On objAttType.ID_AttributeType Equals objAtt.GUID
                                  Select objAttType.ID_AttributeType, objAttType.Min, objAttType.Max, objAtt.Name
                                  Order By Name

        For Each objO_AttributeType In objOL_AttributeTree
            Dim objCnt_AttributeType = From obj In objDBLevel_Count.OList_ObjectAtt_ID
                                       Where obj.ID_AttributeType = objO_AttributeType.ID_AttributeType
                                       Group By obj.ID_AttributeType Into Count() Select ID_AttributeType, Count
            If objCnt_AttributeType.Count = 0 Then
                intCount = 0
            Else
                intCount = objCnt_AttributeType(0).Count
            End If
            objTreeNode = objTreeNode_Atttributes.Nodes.Add(objO_AttributeType.ID_AttributeType, objO_AttributeType.Name & " (" & objO_AttributeType.Min & "/" & intCount & "/" & objO_AttributeType.Max & ")")

            objTreeNode.ForeColor = Color.Green

            If intCount < objO_AttributeType.Min Then
                objTreeNode.ForeColor = Color.SandyBrown
            Else
                If intCount > objO_AttributeType.Max And objO_AttributeType.Max > -1 Then
                    objTreeNode.ForeColor = Color.SandyBrown
                End If
            End If

            If intCount > 0 Then
                objTreeNode.ImageIndex = 1
                objTreeNode.SelectedImageIndex = 1
            End If
        Next
    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)
        objDBLevel_Count = New clsDBLevel(objLocalConfig)
    End Sub

End Class
