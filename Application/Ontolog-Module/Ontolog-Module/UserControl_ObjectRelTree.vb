Public Class UserControl_ObjectRelTree
    Private objTreeNode_RelForward As TreeNode
    Private objTreeNode_RelBackward As TreeNode
    Private objTreeNode_RelForward_Attributes As TreeNode
    Private objTreeNode_RelForward_RelationTypes As TreeNode
    Private objTreeNode_RelForward_Classes As TreeNode
    Private objTreeNode_Atttributes As TreeNode
    Private objTreeNode_Selected As TreeNode

    Private objLocalConfig As clsLocalConfig

    Private objDBLevel_Class_LeftRight As clsDBLevel
    Private objDBLevel_Class_RightLeft As clsDBLevel
    Private objDBLevel_ClassAtt As clsDBLevel
    Private objDBLevel_AttributeType As clsDBLevel
    Private objDBLevel_RelationType As clsDBLevel
    Private objDBLevel_RelType As clsDBLevel
    Private objDBLevel_DataType As clsDBLevel
    Private objDBLevel_ObjectRel As clsDBLevel
    Private objDBLevel_Classes As clsDBLevel
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
        





        TreeView_ObjectRels.Nodes.Clear()

        objTreeNode_Atttributes = TreeView_ObjectRels.Nodes.Add(objLocalConfig.Globals.Type_AttributeType, objLocalConfig.Globals.Type_AttributeType, 0)
        objTreeNode_RelForward = TreeView_ObjectRels.Nodes.Add(objLocalConfig.Globals.Direction_LeftRight.GUID, objLocalConfig.Globals.Direction_LeftRight.Name, 0)
        objTreeNode_RelBackward = TreeView_ObjectRels.Nodes.Add(objLocalConfig.Globals.Direction_RightLeft.GUID, objLocalConfig.Globals.Direction_RightLeft.Name, 0)

        
        'objTreeNode_RelForward_RelationTypes = TreeView_ObjectRels.Nodes.Add(objLocalConfig.Globals.Type_Other_RelType, objLocalConfig.Globals.Type_Other_RelType, 0)
        'objTreeNode_RelForward_Classes = TreeView_ObjectRels.Nodes.Add(objLocalConfig.Globals.Type_Other_Classes, objLocalConfig.Globals.Type_Other_Classes, 0)

        fill_Attributes()
        fill_Forward()
        fill_Backward()
        fill_ForwardOther_AttributeTypes()
        fill_ForwardOther_RelationTypes()
        TreeView_ObjectRels.ExpandAll()
    End Sub

    Private Sub fill_Attributes()
        Dim objTreeNode As TreeNode
        Dim intCount As Integer
        Dim objOList_Classes As New List(Of clsOntologyItem)

        objOList_Classes.Add(New clsOntologyItem(objOItem_Object.GUID_Parent, objLocalConfig.Globals.Type_Class))

        objDBLevel_ClassAtt.get_Data_ClassAtt(objOList_Classes)

        objDBLevel_Count.get_Data_ObjectAtt(objOItem_Object)

        Dim objOL_AttributeTree = From objAttType In objDBLevel_ClassAtt.OList_ClassAtt
                                  Join objAtt In objDBLevel_ClassAtt.OList_AttributeTypes On objAttType.ID_AttributeType Equals objAtt.GUID
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

    Private Sub fill_Forward()
        Dim objTreeNode As TreeNode
        Dim objOList_ClassesRight As New List(Of clsOntologyItem)
        Dim objOList_RelationTypes As New List(Of clsOntologyItem)
        Dim intCount As Integer

        Dim objOList_Classes As New List(Of clsOntologyItem)

        objOList_Classes.Add(New clsOntologyItem(objOItem_Object.GUID_Parent, objLocalConfig.Globals.Type_Class))

        objDBLevel_Class_LeftRight.get_Data_ClassRel(objOList_Classes, objLocalConfig.Globals.Direction_LeftRight, objLocalConfig.Globals.Type_Class)

        Dim strLLeftRight = From obj In objDBLevel_Class_LeftRight.OList_ClassRel_ID
                            Group By obj.ID_Class_Right Into Group
                            Select ID_Class_Right



        For Each strLeftRight In strLLeftRight
            objOList_ClassesRight.Add(New clsOntologyItem(strLeftRight, objLocalConfig.Globals.Type_Class))

        Next

        objDBLevel_Classes.get_Data_Classes(objOList_ClassesRight)

        Dim strLRelationTypes = From obj In objDBLevel_Class_LeftRight.OList_ClassRel_ID
                                Group By obj.ID_RelationType Into Group Select ID_RelationType

        For Each strRelationType In strLRelationTypes
            objOList_RelationTypes.Add(New clsOntologyItem(strRelationType, objLocalConfig.Globals.Type_RelationType))
        Next

        objDBLevel_RelationType.get_Data_RelationTypes(objOList_RelationTypes)

        Dim objOList = From objRel In objDBLevel_Class_LeftRight.OList_ClassRel_ID
                       Join objClass In objDBLevel_Classes.OList_Classes On objRel.ID_Class_Right Equals objClass.GUID
                       Join objRelType In objDBLevel_RelationType.OList_RelationTypes On objRel.ID_RelationType Equals objRelType.GUID
                       Group By ID_Class_Right = objClass.GUID, ID_RelationType = objRelType.GUID, Name_Class_Right = objClass.Name, Name_RelationType = objRelType.Name, objRel.Min_Forw, objRel.Max_Forw Into Group
                       Select ID_RelationType, Name_RelationType, ID_Class_Right, Name_Class_Right, Min_Forw, Max_Forw
                       Order By Name_Class_Right, Name_RelationType

        For Each objItem In objOList
            objDBLevel_Count.get_Data_ObjectRel(objOItem_Object, _
                                                New clsOntologyItem(Nothing, Nothing, objItem.ID_Class_Right, objLocalConfig.Globals.Type_Object), _
                                                New clsOntologyItem(objItem.ID_RelationType, objLocalConfig.Globals.Type_RelationType))

            Dim objCount = From obj In objDBLevel_Count.OList_ObjectRel_ID
                           Group By obj.ID_Parent_Other Into Count()
                           Select ID_Parent_Other, Count

            If objCount.Count = 0 Then
                intCount = 0
            Else
                intCount = objCount(0).Count
            End If

            objTreeNode = objTreeNode_RelForward.Nodes.Add(objItem.ID_Class_Right & "_" & objItem.ID_RelationType, objItem.Name_Class_Right & " / " & objItem.Name_RelationType)

            objTreeNode.Text = objTreeNode.Text & " (" & objItem.Min_Forw & " / " & intCount & " / " & objItem.Max_Forw & ")"
            objTreeNode.ForeColor = Color.Green
            If intCount < objItem.Min_Forw Then
                objTreeNode.ForeColor = Color.SandyBrown
            Else
                If intCount > objItem.Max_Forw And objItem.Max_Forw > -1 Then
                    objTreeNode.ForeColor = Color.SandyBrown
                End If
            End If

            If intCount > 0 Then
                objTreeNode.ImageIndex = 1
                objTreeNode.SelectedImageIndex = 1
            End If

        Next
    End Sub

    Private Sub fill_Backward()
        Dim objTreeNode As TreeNode
        Dim objOList_ClassesLeft As New List(Of clsOntologyItem)
        Dim objOList_RelationTypes As New List(Of clsOntologyItem)
        Dim intCount As Integer
        Dim objOList_Classes As New List(Of clsOntologyItem)

        objOList_Classes.Add(New clsOntologyItem(objOItem_Object.GUID_Parent, objLocalConfig.Globals.Type_Class))

        objDBLevel_Class_RightLeft.get_Data_ClassRel(objOList_Classes, objLocalConfig.Globals.Direction_RightLeft, objLocalConfig.Globals.Type_Class)

        Dim strLRightLeft = From obj In objDBLevel_Class_RightLeft.OList_ClassRel_ID
                            Group By obj.ID_Class_Left Into Group
                            Select ID_Class_Left


        For Each strRigtLeft In strLRightLeft
            objOList_ClassesLeft.Add(New clsOntologyItem(strRigtLeft, objLocalConfig.Globals.Type_Class))

        Next
        If objOList_ClassesLeft.Count > 0 Then
            objDBLevel_Classes.get_Data_Classes(objOList_ClassesLeft)
        End If


        Dim strLRelationTypes = From obj In objDBLevel_Class_RightLeft.OList_ClassRel_ID
                                Group By obj.ID_RelationType Into Group Select ID_RelationType

        For Each strRelationType In strLRelationTypes
            objOList_RelationTypes.Add(New clsOntologyItem(strRelationType, objLocalConfig.Globals.Type_RelationType))
        Next

        objDBLevel_RelationType.get_Data_RelationTypes(objOList_RelationTypes)

        Dim objOList = From objRel In objDBLevel_Class_LeftRight.OList_ClassRel_ID
                       Join objClass In objDBLevel_Classes.OList_Classes On objRel.ID_Class_Left Equals objClass.GUID
                       Join objRelType In objDBLevel_RelationType.OList_RelationTypes On objRel.ID_RelationType Equals objRelType.GUID
                       Group By ID_Class_Left = objClass.GUID, ID_RelationType = objRelType.GUID, Name_Class_Left = objClass.Name, Name_RelationType = objRelType.Name, objRel.Min_Forw, objRel.Max_Forw Into Group
                       Select ID_RelationType, Name_RelationType, ID_Class_Left, Name_Class_Left, Min_Forw, Max_Forw
                       Order By Name_Class_Left, Name_RelationType


        For Each objItem In objOList
            objDBLevel_Count.get_Data_ObjectRel(objOItem_Object, _
                                                New clsOntologyItem(Nothing, Nothing, objItem.ID_Class_Left, objLocalConfig.Globals.Type_Object), _
                                                New clsOntologyItem(objItem.ID_RelationType, objLocalConfig.Globals.Type_RelationType))

            Dim objCount = From obj In objDBLevel_Count.OList_ObjectRel_ID
                           Group By obj.ID_Parent_Other Into Count()
                           Select ID_Parent_Other, Count

            If objCount.Count = 0 Then
                intCount = 0
            Else
                intCount = objCount(0).Count
            End If

            objTreeNode = objTreeNode_RelBackward.Nodes.Add(objItem.ID_Class_Left & "_" & objItem.ID_RelationType, objItem.Name_Class_Left & " / " & objItem.Name_RelationType)

            objTreeNode.Text = objTreeNode.Text & " (" & objItem.Min_Forw & " / " & intCount & " / " & objItem.Max_Forw & ")"
            objTreeNode.ForeColor = Color.Green
            If intCount < objItem.Min_Forw Then
                objTreeNode.ForeColor = Color.SandyBrown
            Else
                If intCount > objItem.Max_Forw And objItem.Max_Forw > -1 Then
                    objTreeNode.ForeColor = Color.SandyBrown
                End If
            End If

            If intCount > 0 Then
                objTreeNode.ImageIndex = 1
                objTreeNode.SelectedImageIndex = 1
            End If
        Next
    End Sub

    Private Sub fill_ForwardOther_AttributeTypes()
        Dim objTreeNode As TreeNode
        Dim objOList_AttributeTypes As New List(Of clsOntologyItem)
        Dim objOList_DataTypes As New List(Of clsOntologyItem)
        Dim objOList_RelationTypes As New List(Of clsOntologyItem)
        Dim intCount As Integer
        Dim objOList_Classes As New List(Of clsOntologyItem)

        objOList_Classes.Add(New clsOntologyItem(objOItem_Object.GUID_Parent, objLocalConfig.Globals.Type_Class))

        objDBLevel_Class_LeftRight.get_Data_ClassRel(objOList_Classes, objLocalConfig.Globals.Direction_LeftRight, objLocalConfig.Globals.Type_Other)

        objDBLevel_ObjectRel.get_Data_ObjectRel(objOItem_Object, New clsOntologyItem(Nothing, objLocalConfig.Globals.Type_AttributeType))

        Dim strLRelationTypes = From obj In objDBLevel_ObjectRel.OList_ObjectRel_ID
                                Group By obj.ID_RelationType Into Group
                                Select ID_RelationType

        For Each strRelationType In strLRelationTypes
            objOList_RelationTypes.Add(New clsOntologyItem(strRelationType, objLocalConfig.Globals.Type_RelationType))

        Next

        objDBLevel_RelationType.get_Data_RelationTypes(objOList_RelationTypes)

        ' Attributes
        Dim strLDataTypes = From obj In objDBLevel_ObjectRel.OList_ObjectRel_ID
                            Group By obj.ID_Parent_Other Into Group
                            Select ID_Parent_Other

        For Each strDataType In strLDataTypes
            objOList_DataTypes.Add(New clsOntologyItem(strDataType, objLocalConfig.Globals.Type_DataType))

        Next

        objDBLevel_DataType.get_Data_DataTyps(objOList_DataTypes)

        Dim strLAttributeTypes = From obj In objDBLevel_ObjectRel.OList_ObjectRel_ID
                                 Group By obj.ID_Other Into Group
                                 Select ID_Other

        For Each strAttributeType In strLAttributeTypes
            objOList_AttributeTypes.Add(New clsOntologyItem(strAttributeType, objLocalConfig.Globals.Type_AttributeType))
        Next

        objDBLevel_AttributeType.get_Data_AttributeType(objOList_AttributeTypes)


        Dim objLAttributeNode = From obj In objDBLevel_ObjectRel.OList_ObjectRel_ID
                                Join objClassRel In objDBLevel_Class_LeftRight.OList_ClassRel_ID On obj.ID_RelationType Equals objClassRel.ID_RelationType
                                Join objRelType In objDBLevel_RelationType.OList_RelationTypes On obj.ID_RelationType Equals objRelType.GUID
                                Join objAttType In objDBLevel_AttributeType.OList_AttributeTypes On obj.ID_Other Equals objAttType.GUID
                                Join objDataType In objDBLevel_DataType.OList_DataTypes On obj.ID_Parent_Other Equals objDataType.GUID
                                Group By ID_RelationType = objRelType.GUID, Name_RelationType = objRelType.Name, ID_AttributeType = objAttType.GUID, Name_AttributeType = objAttType.Name, ID_DataType = objDataType.GUID, Name_DataType = objDataType.Name, objClassRel.Min_Forw, objClassRel.Max_Forw Into Group, Count()
                                Select ID_DataType, ID_RelationType, Name_DataType, Name_RelationType, Min_Forw, Max_Forw, Count
                                Order By Name_DataType, Name_RelationType
        For Each objAttributeNode In objLAttributeNode

            If objTreeNode_RelForward_Attributes Is Nothing Then
                objTreeNode_RelForward_Attributes = TreeView_ObjectRels.Nodes.Add(objLocalConfig.Globals.Type_Other_AttType, objLocalConfig.Globals.Type_Other_AttType, 0)
            End If
            objTreeNode = objTreeNode_RelForward_Attributes.Nodes.Add(objAttributeNode.ID_DataType & "_" & objAttributeNode.ID_RelationType, objAttributeNode.Name_DataType & " / " & objAttributeNode.Name_RelationType & " (" & objAttributeNode.Min_Forw & " / " & objAttributeNode.Count & " / " & objAttributeNode.Max_Forw & ")", 0)
            objTreeNode.ForeColor = Color.Green
            If objAttributeNode.Count < objAttributeNode.Min_Forw Then
                objTreeNode.ForeColor = Color.SandyBrown
            Else

                If objAttributeNode.Count > objAttributeNode.Max_Forw And objAttributeNode.Max_Forw > -1 Then
                    objTreeNode.ForeColor = Color.SandyBrown
                End If
            End If

            If objAttributeNode.Count > 0 Then
                objTreeNode.ImageIndex = 1
                objTreeNode.SelectedImageIndex = 1
            End If

        Next

    End Sub

    Private Sub fill_ForwardOther_RelationTypes()
        Dim objTreeNode As TreeNode
        Dim objOList_AttributeTypes As New List(Of clsOntologyItem)
        Dim objOList_DataTypes As New List(Of clsOntologyItem)
        Dim objOList_RelationTypes As New List(Of clsOntologyItem)
        Dim objOList_RelTypes As New List(Of clsOntologyItem)
        Dim intCount As Integer
        Dim objOList_Classes As New List(Of clsOntologyItem)

        objOList_Classes.Add(New clsOntologyItem(objOItem_Object.GUID_Parent, objLocalConfig.Globals.Type_Class))

        objDBLevel_Class_LeftRight.get_Data_ClassRel(objOList_Classes, objLocalConfig.Globals.Direction_LeftRight, objLocalConfig.Globals.Type_Other)

        objDBLevel_ObjectRel.get_Data_ObjectRel(objOItem_Object, New clsOntologyItem(Nothing, objLocalConfig.Globals.Type_RelationType))

        Dim strLRelationTypes = From obj In objDBLevel_ObjectRel.OList_ObjectRel_ID
                                Group By obj.ID_RelationType Into Group
                                Select ID_RelationType

        For Each strRelationType In strLRelationTypes
            objOList_RelationTypes.Add(New clsOntologyItem(strRelationType, objLocalConfig.Globals.Type_RelationType))

        Next

        objDBLevel_RelationType.get_Data_RelationTypes(objOList_RelationTypes)

        Dim strLRelTypes = From obj In objDBLevel_ObjectRel.OList_ObjectRel_ID
                                 Group By obj.ID_Other Into Group
                                 Select ID_Other

        For Each strRelType In strLRelTypes
            objOList_RelTypes.Add(New clsOntologyItem(strRelType, objLocalConfig.Globals.Type_RelationType))
        Next

        objDBLevel_RelType.get_Data_RelationTypes(objOList_RelTypes)


        Dim objLReType = From obj In objDBLevel_ObjectRel.OList_ObjectRel_ID
                                Join objClassRel In objDBLevel_Class_LeftRight.OList_ClassRel_ID On obj.ID_RelationType Equals objClassRel.ID_RelationType
                                Join objRelType In objDBLevel_RelationType.OList_RelationTypes On obj.ID_RelationType Equals objRelType.GUID
                                Join objRelRelType In objDBLevel_RelType.OList_RelationTypes On obj.ID_Other Equals objRelRelType.GUID
                                Group By ID_RelationType = objRelType.GUID, Name_RelationType = objRelType.Name, ID_Rel_RelType = objRelRelType.GUID, Name_Rel_RelType = objRelRelType.Name, objClassRel.Min_Forw, objClassRel.Max_Forw Into Group, Count()
                                Select ID_Rel_RelType, Name_Rel_RelType, ID_RelationType, Name_RelationType, Min_Forw, Max_Forw, Count
                                Order By Name_Rel_RelType, Name_RelationType
        For Each objRelType In objLReType
            

            If objTreeNode_RelForward_RelationTypes Is Nothing Then
                objTreeNode_RelForward_RelationTypes = TreeView_ObjectRels.Nodes.Add(objLocalConfig.Globals.Type_Other_RelType, objLocalConfig.Globals.Type_Other_RelType, 0)
            End If
            objTreeNode = objTreeNode_RelForward_RelationTypes.Nodes.Add(objRelType.ID_Rel_RelType & "_" & objRelType.ID_RelationType, objRelType.Name_Rel_RelType & " / " & objRelType.Name_RelationType & " (" & objRelType.Min_Forw & " / " & objRelType.Count & " / " & objRelType.Max_Forw & ")", 0)
            objTreeNode.ForeColor = Color.Green
            If objRelType.Count < objRelType.Min_Forw Then
                objTreeNode.ForeColor = Color.SandyBrown
            Else

                If objRelType.Count > objRelType.Max_Forw And objRelType.Max_Forw > -1 Then
                    objTreeNode.ForeColor = Color.SandyBrown
                End If
            End If

            If objRelType.Count > 0 Then
                objTreeNode.ImageIndex = 1
                objTreeNode.SelectedImageIndex = 1
            End If

        Next

    End Sub

    Private Sub set_DBConnection()
        objDBLevel_ClassAtt = New clsDBLevel(objLocalConfig)
        objDBLevel_Class_LeftRight = New clsDBLevel(objLocalConfig)
        objDBLevel_Class_RightLeft = New clsDBLevel(objLocalConfig)
        objDBLevel_AttributeType = New clsDBLevel(objLocalConfig)
        objDBLevel_RelationType = New clsDBLevel(objLocalConfig)
        objDBLevel_RelType = New clsDBLevel(objLocalConfig)
        objDBLevel_Classes = New clsDBLevel(objLocalConfig)
        objDBLevel_Count = New clsDBLevel(objLocalConfig)
        objDBLevel_ObjectRel = New clsDBLevel(objLocalConfig)
        objDBLevel_DataType = New clsDBLevel(objLocalConfig)
    End Sub

End Class
