Public Class UserControl_TokenTree

    Private objLocalConfig As clsLocalConfig_TokenTree
    Private objTreeNode_RelForward As TreeNode
    Private objTreeNode_RelBackward As TreeNode
    Private objTreeNode_ObjectReference As TreeNode
    Private objTreeNode_ObjectReference_Backward As TreeNode
    Private objTreeNode_Atttributes As TreeNode
    Private objTreeNode_Selected As TreeNode

    Private objTokenEdit_Navigation As clsTokenEdit_Navigation
    Private objSemItem_Selected As clsSemItem

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter
    Private typefunc_Types_With_Attributes_And_Types As New ds_TypeTableAdapters.typefunc_Types_With_Attributes_And_TypesTableAdapter
    Private semfunc_Token_Attribute As New ds_TokenAttributeTableAdapters.semfunc_Token_AttributeTableAdapter
    Private typefunc_Types_Rel As New ds_TypeTableAdapters.typefunc_Types_RelTableAdapter
    Private func_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_Type_OR_By_GUIDType As New ds_ObjectReferenceTableAdapters.proc_Type_OR_By_GUIDTypeTableAdapter
    Private funcA_Token_OR_Count_By_Types As New ds_ObjectReferenceTableAdapters.func_Token_OR_Count_By_TypesTableAdapter
    Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter

    Private objFrmTokenEdit As frmTokenEdit

    Public Event selected_Node(ByVal objSemItem As clsSemItem)

    Private Sub initialize()
        objTreeNode_Atttributes = TreeView_Token.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString, objLocalConfig.Globals.ObjectReferenceType_Attribute.Name)
        objTreeNode_RelForward = TreeView_Token.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_TokenToken.GUID.ToString & " - Forward", objLocalConfig.Globals.ObjectReferenceType_TokenToken.Name & " - Forward")
        objTreeNode_RelBackward = TreeView_Token.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_TokenToken.GUID.ToString & " - Backward", objLocalConfig.Globals.ObjectReferenceType_TokenToken.Name & " - Backward")

        set_DBConnection()
        get_Attributes()
        get_TokenRel_Forward()
        get_TokenRel_Backward()
        get_ObjectReferences()

        objTreeNode_Atttributes.ExpandAll()
        objTreeNode_RelForward.ExpandAll()
        objTreeNode_RelBackward.ExpandAll()
    End Sub

    Private Sub set_DBConnection()
        typefunc_Types_With_Attributes_And_Types.Connection = objLocalConfig.Connection_DB
        semfunc_Token_Attribute.Connection = objLocalConfig.Connection_DB
        typefunc_Types_Rel.Connection = objLocalConfig.Connection_DB
        func_TokenToken.Connection = objLocalConfig.Connection_DB
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_RelationType.Connection = objLocalConfig.Connection_DB
        procA_Type_OR_By_GUIDType.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR_Count_By_Types.Connection = objLocalConfig.Connection_DB
        semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
    End Sub

   

    Public Sub get_Attributes()
        Dim objDRC_Attribute As DataRowCollection
        Dim objDR_Attribute As DataRow
        Dim objTreeNode_Attribute As TreeNode
        Dim objTreeNodes_Selected() As TreeNode
        Dim objTreeNode_Selected As TreeNode
        Dim GUID_TreeNode As Guid = Nothing
        Dim intCount_Token As Integer
        Dim boolCount As Boolean

        If Not objTreeNode_Attribute Is Nothing Then
            GUID_TreeNode = New Guid(objTreeNode_Attribute.Name)

        End If

        objTreeNode_Atttributes.Nodes.Clear()

        If Not objTokenEdit_Navigation Is Nothing Then
            objDRC_Attribute = typefunc_Types_With_Attributes_And_Types.GetData_Attributes_By_GUIDType(objTokenEdit_Navigation.SemItem_Active.GUID_Parent).Rows
            boolCount = True
        Else
            boolCount = False
            If objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                objDRC_Attribute = typefunc_Types_With_Attributes_And_Types.GetData_Attributes_By_GUIDType(objSemItem_Selected.GUID).Rows
            Else
                objDRC_Attribute = typefunc_Types_With_Attributes_And_Types.GetData_Attributes_By_GUIDType(objSemItem_Selected.GUID_Parent).Rows
            End If

        End If

        For Each objDR_Attribute In objDRC_Attribute

            If boolCount = True Then
                intCount_Token = semfunc_Token_Attribute.TokenAttribute_Count_Token_Of_Attribute_And_Token(objDR_Attribute.Item("GUID_Attribute"), objTokenEdit_Navigation.SemItem_Active.GUID)

                objTreeNode_Attribute = objTreeNode_Atttributes.Nodes.Add(objDR_Attribute.Item("GUID_Attribute").ToString & "_" & objDR_Attribute.Item("GUID_AttributeType").ToString, objDR_Attribute.Item("Name_Attribute") & _
                                                          " (" & objDR_Attribute.Item("Min") & " <= " & intCount_Token & " <= " & objDR_Attribute.Item("Max") & ")")

                If intCount_Token > 0 Then
                    objTreeNode_Attribute.ImageIndex = 1
                End If

                If test_Count(objDR_Attribute.Item("Min"), objDR_Attribute.Item("Max"), intCount_Token) = True Then
                    objTreeNode_Attribute.ForeColor = Color.Green
                Else
                    objTreeNode_Attribute.ForeColor = Color.SandyBrown
                End If
            Else
                objTreeNode_Attribute = objTreeNode_Atttributes.Nodes.Add(objDR_Attribute.Item("GUID_Attribute").ToString & "_" & objDR_Attribute.Item("GUID_AttributeType").ToString, objDR_Attribute.Item("Name_Attribute"))
            End If

        Next
        If Not GUID_TreeNode = Nothing Then
            objTreeNodes_Selected = objTreeNode_Atttributes.Nodes.Find(GUID_TreeNode.ToString, False)
            If Not objTreeNodes_Selected Is Nothing Then
                For Each objTreeNode_Selected In objTreeNodes_Selected
                    TreeView_Token.SelectedNode = objTreeNode_Selected

                Next
            End If
            
        End If
    End Sub

    Private Sub get_TokenRel_Forward()
        Dim objDRC_TokenRel As DataRowCollection
        Dim objDR_TokenRel As DataRow
        Dim objDRC_TokenCount As DataRowCollection
        Dim objTreeNode_TokenRel As TreeNode
        Dim intCount_Token As Integer
        Dim boolCount As Boolean

        If Not objTokenEdit_Navigation Is Nothing Then
            boolCount = True
            objDRC_TokenRel = typefunc_Types_Rel.GetData_By_GUID_Type_Left(objTokenEdit_Navigation.SemItem_Active.GUID_Parent).Rows
        Else
            boolCount = False
            If objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                objDRC_TokenRel = typefunc_Types_Rel.GetData_By_GUID_Type_Left(objSemItem_Selected.GUID).Rows
            Else
                objDRC_TokenRel = typefunc_Types_Rel.GetData_By_GUID_Type_Left(objSemItem_Selected.GUID_Parent).Rows
            End If

        End If

        For Each objDR_TokenRel In objDRC_TokenRel
            If boolCount = True Then
                objTreeNode_TokenRel = objTreeNode_RelForward.Nodes.Add(objDR_TokenRel.Item("GUID_Type_Right").ToString & "_" & objDR_TokenRel.Item("GUID_RelationType").ToString, objDR_TokenRel.Item("Name_Type_Right") & " / " & objDR_TokenRel.Item("Name_RelationType"))
                objDRC_TokenCount = func_TokenToken.GetData_TokenToken_LeftRight(objTokenEdit_Navigation.SemItem_Active.GUID, objDR_TokenRel.Item("GUID_RelationType"), objDR_TokenRel.Item("GUID_Type_Right")).Rows
                intCount_Token = objDRC_TokenCount.Count
                objTreeNode_TokenRel.Text = objTreeNode_TokenRel.Text & " (" & objDR_TokenRel.Item("Min_forw") & "/" & intCount_Token & "/" & objDR_TokenRel.Item("Max_forw") & ")"

                If intCount_Token > 0 Then
                    objTreeNode_TokenRel.ImageIndex = 1
                End If
                If test_Count(objDR_TokenRel.Item("Min_forw"), objDR_TokenRel.Item("Max_forw"), intCount_Token) = True Then
                    objTreeNode_TokenRel.ForeColor = Color.Green
                Else
                    objTreeNode_TokenRel.ForeColor = Color.SandyBrown
                End If
            Else
                objTreeNode_TokenRel = objTreeNode_RelForward.Nodes.Add(objDR_TokenRel.Item("GUID_Type_Right").ToString & "_" & objDR_TokenRel.Item("GUID_RelationType").ToString, objDR_TokenRel.Item("Name_Type_Right") & " / " & objDR_TokenRel.Item("Name_RelationType"))

            End If
            
        Next
    End Sub
    Private Sub get_TokenRel_Backward()
        Dim objDRC_TokenRel As DataRowCollection
        Dim objDR_TokenRel As DataRow
        Dim objDRC_TokenCount As DataRowCollection
        Dim objTreeNode_TokenRel As TreeNode
        Dim intCount_Token As Integer

        Dim boolCount As Boolean

        If Not objTokenEdit_Navigation Is Nothing Then
            boolCount = True
            objDRC_TokenRel = typefunc_Types_Rel.GetData_By_GUID_Type_Right(objTokenEdit_Navigation.SemItem_Active.GUID_Parent).Rows
        Else
            boolCount = False
            If objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                objDRC_TokenRel = typefunc_Types_Rel.GetData_By_GUID_Type_Right(objSemItem_Selected.GUID).Rows
            Else
                objDRC_TokenRel = typefunc_Types_Rel.GetData_By_GUID_Type_Right(objSemItem_Selected.GUID_Parent).Rows
            End If


        End If

        For Each objDR_TokenRel In objDRC_TokenRel

            If boolCount = True Then
                objDRC_TokenCount = func_TokenToken.GetData_TokenToken_RightLeft(objTokenEdit_Navigation.SemItem_Active.GUID, objDR_TokenRel.Item("GUID_RelationType"), objDR_TokenRel.Item("GUID_Type_Left")).Rows
                intCount_Token = objDRC_TokenCount.Count
                objTreeNode_TokenRel = objTreeNode_RelBackward.Nodes.Add(objDR_TokenRel.Item("GUID_Type_Left").ToString & "_" & objDR_TokenRel.Item("GUID_RelationType").ToString, objDR_TokenRel.Item("Name_Type_Left") & " / " & objDR_TokenRel.Item("Name_RelationType") & " (" & intCount_Token & " / " & _
                                                                         objDR_TokenRel.Item("Max_backw") & ")")

                If intCount_Token > 0 Then
                    objTreeNode_TokenRel.ImageIndex = 1
                End If

                If objDRC_TokenCount.Count > 0 Then
                    If intCount_Token < objDR_TokenRel.Item("Max_Backw") Or objDR_TokenRel.Item("Max_Backw") = -1 Then
                        objTreeNode_TokenRel.ForeColor = Color.Green
                    Else
                        objTreeNode_TokenRel.ForeColor = Color.SandyBrown
                    End If

                End If
            Else
                objTreeNode_TokenRel = objTreeNode_RelBackward.Nodes.Add(objDR_TokenRel.Item("GUID_Type_Left").ToString & "_" & objDR_TokenRel.Item("GUID_RelationType").ToString, objDR_TokenRel.Item("Name_Type_Left") & " / " & objDR_TokenRel.Item("Name_RelationType") )
            End If
            


        Next
    End Sub

    Private Sub get_ObjectReferences()
        Dim objTreeNode_ObjectReference As TreeNode
        Dim objTreeNode_ObjectReference_Sub As TreeNode
        Dim objTreeNode_Referenced As TreeNode
        Dim strName_Node As String
        Dim strText_Node As String
        Dim intMin As Integer
        Dim intMax As Integer
        Dim intCount As Integer
        Dim objDRC_ObjectReference As DataRowCollection
        Dim objDR_ObjectReference As DataRow
        Dim objDRC_Token_OR As DataRowCollection
        Dim objDR_Token_OR As DataRow

        Dim boolCount As Boolean

        If Not objTokenEdit_Navigation Is Nothing Then
            boolCount = True
            objDRC_ObjectReference = procA_Type_OR_By_GUIDType.GetData(objTokenEdit_Navigation.SemItem_Active.GUID_Parent).Rows
        Else
            boolCount = False
            If objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                objDRC_ObjectReference = procA_Type_OR_By_GUIDType.GetData(objSemItem_Selected.GUID).Rows
            Else
                objDRC_ObjectReference = procA_Type_OR_By_GUIDType.GetData(objSemItem_Selected.GUID_Parent).Rows
            End If
        End If

        If objDRC_ObjectReference.Count > 0 Then
            objTreeNode_ObjectReference = TreeView_Token.Nodes.Add("Object-Reference", "Object-Reference", 0, 0)
            If boolCount = True Then

                For Each objDR_ObjectReference In objDRC_ObjectReference
                    objTreeNode_ObjectReference_Sub = objTreeNode_ObjectReference.Nodes.Add(objDR_ObjectReference.Item("GUID_RelationType").ToString, objDR_ObjectReference.Item("Name_RelationType"), 0, 0)
                    intMin = objDR_ObjectReference.Item("Min_forw")
                    intMax = objDR_ObjectReference.Item("Max_forw")
                    intCount = funcA_Token_OR_Count_By_Types.Count_By_GUIDToken_And_GUIDRelationType(objTokenEdit_Navigation.SemItem_Active.GUID, objDR_ObjectReference.Item("GUID_RelationType"))
                    objTreeNode_ObjectReference_Sub.Text = objTreeNode_ObjectReference_Sub.Text & " (" & intMin & "/" & intCount & "/" & intMax & ")"
                    If test_Count(intMin, intMax, intCount) = True Then
                        objTreeNode_ObjectReference_Sub.ForeColor = Color.Green
                    Else
                        objTreeNode_ObjectReference_Sub.ForeColor = Color.SandyBrown
                    End If
                Next
            Else

                For Each objDR_ObjectReference In objDRC_ObjectReference
                    objTreeNode_ObjectReference_Sub = objTreeNode_ObjectReference.Nodes.Add(objDR_ObjectReference.Item("GUID_RelationType").ToString, objDR_ObjectReference.Item("Name_RelationType"), 0, 0)
                Next
            End If
            

            objTreeNode_ObjectReference.Expand()
        End If
        If Not objTokenEdit_Navigation Is Nothing Then
            boolCount = True
            objDRC_ObjectReference = semfuncA_ObjectReference.GetData_By_GUID_Ref(objTokenEdit_Navigation.SemItem_Active.GUID).Rows
        Else
            boolCount = False
            If objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                objDRC_ObjectReference = semfuncA_ObjectReference.GetData_By_GUID_Ref(objSemItem_Selected.GUID).Rows
            Else
                objDRC_ObjectReference = semfuncA_ObjectReference.GetData_By_GUID_Ref(objSemItem_Selected.GUID_Parent).Rows
            End If
        End If

        If objDRC_ObjectReference.Count > 0 Then
            objTreeNode_ObjectReference = TreeView_Token.Nodes.Add("References to this Object", "References to this Object", 0, 0)
            objDRC_ObjectReference = funcA_Token_OR.GetData_By_GUIDObjectReference(objDRC_ObjectReference(0).Item("GUID_ObjectReference")).Rows
            For Each objDR_ObjectReference In objDRC_ObjectReference
                objTreeNode_ObjectReference.Nodes.Add(objDR_ObjectReference.Item("GUID_Token_Left").ToString & "_" & objDR_ObjectReference.Item("GUID_Type_Left").ToString, objDR_ObjectReference.Item("Name_Token_Left") & " (" & objDR_ObjectReference.Item("Name_Type_Left") & "\" & objDR_ObjectReference.Item("Name_RelationType") & ")", 0, 0)
            Next
        Else
            objTreeNode_ObjectReference = Nothing
        End If
    End Sub
    
    Private Function test_Count(ByVal intMin As Integer, ByVal intMax As Integer, ByVal intCount As Integer) As Boolean
        Dim boolResult As Boolean = False

        If intCount >= intMin Then
            If intCount <= intMax Or intMax = -1 Then
                boolResult = True
            End If
        End If

        Return boolResult
    End Function
    Public Sub New(ByVal TokenItem_Navigation As clsTokenEdit_Navigation, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_TokenTree(Globals)
        objTokenEdit_Navigation = TokenItem_Navigation
        objSemItem_Selected = Nothing
        initialize()
    End Sub

    Public Sub New(ByVal SemItem_Selected As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_TokenTree(Globals)
        objTokenEdit_Navigation = Nothing
        objSemItem_Selected = SemItem_Selected
        initialize()
    End Sub

    
    Private Sub TreeView_Token_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Token.AfterSelect

        Dim objTreeNode_Parent As TreeNode
        Dim objSemItem_Complex As clsSemItem
        Dim objGUID_Attribute As Guid
        Dim objGUID_AttributeType As Guid
        Dim objGUID_Type As Guid
        Dim objGUID_RelationType As Guid


        objTreeNode_Selected = e.Node
        If Not objTreeNode_Selected Is Nothing Then
            objTreeNode_Parent = objTreeNode_Selected.Parent
            If Not objTreeNode_Parent Is Nothing Then
                If Not objTokenEdit_Navigation Is Nothing Then
                    Select Case objTreeNode_Parent.Name
                        Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString
                            objGUID_Attribute = New Guid(objTreeNode_Selected.Name.Substring(0, objTreeNode_Selected.Name.IndexOf("_")))
                            objGUID_AttributeType = New Guid(objTreeNode_Selected.Name.Substring(objTreeNode_Selected.Name.IndexOf("_") + 1))

                            objSemItem_Complex = New clsSemItem
                            objSemItem_Complex.GUID = objTokenEdit_Navigation.SemItem_Active.GUID
                            objSemItem_Complex.GUID_Parent = objTokenEdit_Navigation.SemItem_Active.GUID_Parent
                            Select Case objGUID_AttributeType
                                Case objLocalConfig.Globals.AttributeType_Bool.GUID
                                    objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.GUID
                                Case objLocalConfig.Globals.AttributeType_Date.GUID
                                    objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.GUID
                                Case objLocalConfig.Globals.AttributeType_Datetime.GUID
                                    objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.GUID
                                Case objLocalConfig.Globals.AttributeType_Int.GUID
                                    objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.GUID
                                Case objLocalConfig.Globals.AttributeType_Real.GUID
                                    objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.GUID
                                Case objLocalConfig.Globals.AttributeType_String.GUID
                                    objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.GUID
                                Case objLocalConfig.Globals.AttributeType_Time.GUID
                                    objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.GUID
                                Case objLocalConfig.Globals.AttributeType_Varchar255.GUID
                                    objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.GUID
                            End Select


                            objSemItem_Complex.GUID_Related = objGUID_Attribute
                            objSemItem_Complex.GUID_Relation = objGUID_AttributeType
                            RaiseEvent selected_Node(objSemItem_Complex)

                        Case objLocalConfig.Globals.ObjectReferenceType_TokenToken.GUID.ToString & " - Forward"
                            objGUID_Type = New Guid(objTreeNode_Selected.Name.Substring(0, objTreeNode_Selected.Name.IndexOf("_")))
                            objGUID_RelationType = New Guid(objTreeNode_Selected.Name.Substring(objTreeNode_Selected.Name.IndexOf("_") + 1))
                            objSemItem_Complex = New clsSemItem
                            objSemItem_Complex.GUID = objTokenEdit_Navigation.SemItem_Active.GUID
                            objSemItem_Complex.GUID_Parent = objTokenEdit_Navigation.SemItem_Active.GUID_Parent
                            objSemItem_Complex.GUID_Related = objGUID_Type
                            objSemItem_Complex.GUID_Relation = objGUID_RelationType
                            objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objSemItem_Complex.Direction = objSemItem_Complex.Direction_LeftRight
                            RaiseEvent selected_Node(objSemItem_Complex)

                        Case objLocalConfig.Globals.ObjectReferenceType_TokenToken.GUID.ToString & " - Backward"
                            objGUID_Type = New Guid(objTreeNode_Selected.Name.Substring(0, objTreeNode_Selected.Name.IndexOf("_")))
                            objGUID_RelationType = New Guid(objTreeNode_Selected.Name.Substring(objTreeNode_Selected.Name.IndexOf("_") + 1))
                            objSemItem_Complex = New clsSemItem
                            objSemItem_Complex.GUID = objTokenEdit_Navigation.SemItem_Active.GUID
                            objSemItem_Complex.GUID_Parent = objTokenEdit_Navigation.SemItem_Active.GUID_Parent
                            objSemItem_Complex.GUID_Related = objGUID_Type
                            objSemItem_Complex.GUID_Relation = objGUID_RelationType
                            objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objSemItem_Complex.Direction = objSemItem_Complex.Direction_RightLeft
                            RaiseEvent selected_Node(objSemItem_Complex)
                        Case "Object-Reference"

                            objGUID_RelationType = New Guid(objTreeNode_Selected.Name)
                            objSemItem_Complex = New clsSemItem
                            objSemItem_Complex.GUID = objTokenEdit_Navigation.SemItem_Active.GUID
                            objSemItem_Complex.GUID_Parent = objTokenEdit_Navigation.SemItem_Active.GUID_Parent
                            objSemItem_Complex.GUID_Relation = objGUID_RelationType
                            objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objSemItem_Complex.Direction = objSemItem_Complex.Direction_LeftRight
                            objSemItem_Complex.Rel_ObjectReference = True
                            RaiseEvent selected_Node(objSemItem_Complex)

                    End Select
                Else
                    Select Case objTreeNode_Parent.Name
                        Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString
                            objGUID_Attribute = New Guid(objTreeNode_Selected.Name.Substring(0, objTreeNode_Selected.Name.IndexOf("_")))
                            objGUID_AttributeType = New Guid(objTreeNode_Selected.Name.Substring(objTreeNode_Selected.Name.IndexOf("_") + 1))

                            objSemItem_Complex = New clsSemItem
                            objSemItem_Complex.GUID = objGUID_Attribute
                            objSemItem_Complex.GUID_Parent = objGUID_AttributeType
                            objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID


                            RaiseEvent selected_Node(objSemItem_Complex)

                        Case objLocalConfig.Globals.ObjectReferenceType_TokenToken.GUID.ToString & " - Forward"
                            objGUID_Type = New Guid(objTreeNode_Selected.Name.Substring(0, objTreeNode_Selected.Name.IndexOf("_")))
                            objGUID_RelationType = New Guid(objTreeNode_Selected.Name.Substring(objTreeNode_Selected.Name.IndexOf("_") + 1))

                            objSemItem_Complex = New clsSemItem
                            objSemItem_Complex.Direction = objSemItem_Complex.Direction_LeftRight
                            objSemItem_Complex.GUID = objGUID_Type
                            objSemItem_Complex.GUID_Relation = objGUID_RelationType
                            objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                            RaiseEvent selected_Node(objSemItem_Complex)

                        Case objLocalConfig.Globals.ObjectReferenceType_TokenToken.GUID.ToString & " - Backward"
                            objGUID_Type = New Guid(objTreeNode_Selected.Name.Substring(0, objTreeNode_Selected.Name.IndexOf("_")))
                            objGUID_RelationType = New Guid(objTreeNode_Selected.Name.Substring(objTreeNode_Selected.Name.IndexOf("_") + 1))
                            objSemItem_Complex = New clsSemItem
                            objSemItem_Complex.Direction = objSemItem_Complex.Direction_RightLeft
                            objSemItem_Complex.GUID = objGUID_Type
                            objSemItem_Complex.GUID_Relation = objGUID_RelationType
                            objSemItem_Complex.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            RaiseEvent selected_Node(objSemItem_Complex)


                    End Select
                End If

            End If
        End If
    End Sub

    Private Sub TreeView_Token_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_Token.DoubleClick
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Parent As TreeNode
        Dim objSemItem_Token As New clsSemItem
        Dim strGUIDs() As String
        Dim GUID_Token As Guid
        Dim GUID_Type As Guid

        objTreeNode = TreeView_Token.SelectedNode

        If Not objTreeNode Is Nothing Then
            objTreeNode_Parent = objTreeNode.Parent
            If Not objTreeNode_Parent Is Nothing Then
                If objTreeNode_Parent.Name = "References to this Object" Then
                    strGUIDs = objTreeNode.Name.Split("_")
                    GUID_Token = New Guid(strGUIDs(0))
                    GUID_Type = New Guid(strGUIDs(1))

                    objSemItem_Token.GUID = GUID_Token
                    objSemItem_Token.Name = objTreeNode.Text
                    objSemItem_Token.GUID_Parent = GUID_Type
                    objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objFrmTokenEdit = New frmTokenEdit(objSemItem_Token, objLocalConfig.Globals)
                    objFrmTokenEdit.ShowDialog(Me)
                End If
            End If
        End If

    End Sub
End Class
