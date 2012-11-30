Public Class UserControl_TreeOfToken
    Private objLocalConfig As clsLocalConfig_SemManager
    Private objGlobals As clsGlobals
    Private objSemItem_Parent As clsSemItem
    Private GUID_Type As Guid
    Private objSemItem_RelationType As clsSemItem

    Private objFRMSemManager As frmSemManager

    Private typefuncA_Types_Rel As New ds_TypeTableAdapters.typefunc_Types_RelTableAdapter
    Private typefuncT_Types_Rel As New ds_Type.typefunc_Types_RelDataTable
    Private procA_TokenTree_TopDown As New ds_TokenTableAdapters.proc_TokenTree_TopDownTableAdapter
    Private procT_TokenTree_TopDown As New ds_Token.proc_TokenTree_TopDownDataTable
    Private objTransaction_TreeOfToken As clsTransaction_TreeOfToken
    Private objFrmTokenEdit As frmTokenEdit
    Private objDLG_Attribut_VARCHAR255 As dlgAttribute_Varchar255
    Private objDRC_FirstLevel As DataRowCollection
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcT_TokenToken As New ds_Token.func_TokenTokenDataTable
    Private objTreeNode_Parent As TreeNode
    Private objThread_Tree As Threading.Thread
    Private boolTopDown As Boolean
    Private intRowID As Integer
    Private boolDataGet As Boolean
    Private boolFindNode As Boolean
    Private GUID_Node As Guid

    Public Event selected_Node(ByVal SemItem_Node As clsSemItem)

    Public Sub New(ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objGlobals = Globals
        objLocalConfig = Globals.LocalConfig
        If objLocalConfig Is Nothing Then
            objLocalConfig = New clsLocalConfig_SemManager(objGlobals)
        End If

        set_DBConnection()

        objSemItem_RelationType = objLocalConfig.SemItem_RelationType_superordinate
        ToolStripTextBox_RelationType.Text = objSemItem_RelationType.Name
    End Sub

    Private Sub set_DBConnection()
        typefuncA_Types_Rel.Connection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        procA_TokenTree_TopDown.Connection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        funcA_TokenToken.Connection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        funcA_TokenToken.ClearBeforeFill = False

        objTransaction_TreeOfToken = New clsTransaction_TreeOfToken(objLocalConfig)
    End Sub

    Public Sub initialize(ByVal SemItem_Parent As clsSemItem)
        boolFindNode = False
        Timer_Tree.Stop()
        ToolStripProgressBar_Tree.Visible = False
        Try
            objThread_Tree.Abort()
        Catch ex As Exception

        End Try
        objSemItem_Parent = SemItem_Parent
        get_RelationType()

        fill_Tree()

    End Sub

    Private Sub fill_Tree()
        TreeView_TokenTree.Nodes.Clear()
        If Not objSemItem_Parent Is Nothing Then
            boolTopDown = ToolStripButton_TopDown.Checked

            objThread_Tree = New Threading.Thread(AddressOf get_Tree)
            intRowID = 0
            boolDataGet = False
            objThread_Tree.Start()
            Timer_Tree.Start()
        End If
    End Sub

    Public Sub find_Node(ByVal _GUID_Node As Guid)


        GUID_Node = _GUID_Node
        boolFindNode = True
        If boolDataGet = True Then
            select_Node()
        End If
        
    End Sub

    Private Sub select_Node()
        Dim objTreeNodes() As TreeNode
        objTreeNodes = TreeView_TokenTree.Nodes.Find(GUID_Node.ToString, True)
        If objTreeNodes.Count > 0 Then
            TreeView_TokenTree.SelectedNode = objTreeNodes(0)
        End If
    End Sub

    Private Sub get_RelationType()
        Dim objDRs_Types() As DataRow
        If boolTopDown = True Then
            typefuncA_Types_Rel.Fill_By_GUID_Type_Left(typefuncT_Types_Rel, objSemItem_Parent.GUID)

            objDRs_Types = typefuncT_Types_Rel.Select("GUID_Type_Right='" & objSemItem_Parent.GUID.ToString & "'")
            If objDRs_Types.Count > 0 Then
                objSemItem_RelationType.GUID = objDRs_Types(0).Item("GUID_RelationType")
                objSemItem_RelationType.Name = objDRs_Types(0).Item("Name_RelationType")
                objSemItem_RelationType.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                ToolStripTextBox_RelationType.Text = objSemItem_RelationType.Name
            End If
        End If

    End Sub

    Private Sub get_Tree()
        Dim objConnection As SqlClient.SqlConnection

        objConnection = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)
        procA_TokenTree_TopDown.Connection = objConnection

        If boolTopDown = True Then
            If objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                procA_TokenTree_TopDown.Fill(procT_TokenTree_TopDown, _
                                         objSemItem_Parent.GUID_Parent, _
                                         objSemItem_RelationType.GUID, _
                                         objSemItem_Parent.GUID)
            Else
                procA_TokenTree_TopDown.Fill(procT_TokenTree_TopDown, _
                                         objSemItem_Parent.GUID, _
                                         objSemItem_RelationType.GUID, _
                                         Nothing)
            End If




        Else

        End If
        boolDataGet = True
    End Sub

    Private Sub TreeView_TokenTree_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_TokenTree.AfterExpand

    End Sub

    Private Sub TreeView_TokenTree_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_TokenTree.AfterSelect
        Dim objSemItem_Node As New clsSemItem
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_TokenTree.SelectedNode
        If Not objTreeNode Is Nothing Then
            objSemItem_Node.GUID = New Guid(objTreeNode.Name)
            objSemItem_Node.Name = objTreeNode.Text
            objSemItem_Node.GUID_Parent = objSemItem_Parent.GUID
            objSemItem_Node.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            RaiseEvent selected_Node(objSemItem_Node)
        End If
    End Sub

    Private Sub TreeView_TokenTree_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_TokenTree.DoubleClick
        Dim objTreeNode As TreeNode
        Dim objSemItem_Selected As New clsSemItem

        objTreeNode = TreeView_TokenTree.SelectedNode
        If Not objTreeNode Is Nothing Then
            objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
            objSemItem_Selected.Name = objTreeNode.Text
            objSemItem_Selected.GUID_Parent = objSemItem_Parent.GUID
            objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objFrmTokenEdit = New frmTokenEdit(objSemItem_Selected, objLocalConfig.Globals)
            objFrmTokenEdit.ShowDialog(Me)

        End If
    End Sub

    Private Sub ContextMenuStrip_Tree_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Tree.Opening
        Dim objTreeNode As TreeNode

        NewToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False
        FilterToolStripMenuItem.Enabled = False
        objTreeNode = TreeView_TokenTree.SelectedNode
        If Not objTreeNode Is Nothing Then
            FilterToolStripMenuItem.Enabled = True
            NewToolStripMenuItem.Enabled = True
            If objTreeNode.Nodes.Count = 0 Then
                DeleteToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Children As TreeNode
        Dim objSemItem_Parent_Tree As New clsSemItem
        Dim objSemItem_Children As New clsSemItem
        Dim objDRC_Children As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objTreeNode = TreeView_TokenTree.SelectedNode
        If Not objTreeNode Is Nothing Then
            objSemItem_Parent_Tree.GUID = New Guid(objTreeNode.Name)
            objSemItem_Parent_Tree.Name = objTreeNode.Text
            objSemItem_Parent_Tree.GUID_Parent = objSemItem_Parent.GUID
            objSemItem_Parent_Tree.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDLG_Attribut_VARCHAR255 = New dlgAttribute_Varchar255("New Token", objLocalConfig.Globals)
            objDLG_Attribut_VARCHAR255.ShowDialog(Me)
            If objDLG_Attribut_VARCHAR255.DialogResult = DialogResult.OK Then
                objSemItem_Children.Name = objDLG_Attribut_VARCHAR255.Value1

                objDRC_Children = funcA_TokenToken.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(objSemItem_Parent.GUID, _
                                                                                                                    objSemItem_Children.Name, _
                                                                                                                    objSemItem_Parent.GUID, _
                                                                                                                    objSemItem_RelationType.GUID).Rows
                If objDRC_Children.Count = 0 Then
                    objSemItem_Children.GUID = Guid.NewGuid
                    objSemItem_Children.GUID_Parent = objSemItem_Parent_Tree.GUID_Parent
                    objSemItem_Children.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Result = objTransaction_TreeOfToken.save_001_Token(objSemItem_Children)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Parent_Tree.Direction = objSemItem_Parent.Direction_LeftRight
                        objSemItem_Parent_Tree.GUID_Related = objSemItem_RelationType.GUID
                        objSemItem_Parent_Tree.Mark = ToolStripButton_SortedByOrder.Checked
                        objSemItem_Result = objTransaction_TreeOfToken.save_002_TokenRel(objSemItem_Parent_Tree, _
                                                                                         objSemItem_Children)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode_Children = objTreeNode.Nodes.Add(objSemItem_Children.GUID.ToString, _
                                                  objSemItem_Children.Name)
                            objTreeNode.Expand()

                            TreeView_TokenTree.SelectedNode = objTreeNode_Children
                        Else
                            MsgBox("Der Knoten konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            objTransaction_TreeOfToken.del_001_Token(objSemItem_Children)
                        End If
                    Else
                        MsgBox("Der Knoten konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Es existiert bereits ein Knoten mit dem Namen!", MsgBoxStyle.Exclamation)
                End If
            End If

        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Parent As TreeNode
        Dim objSemItem_Children As New clsSemItem
        Dim objSemItem_Parent As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objTreeNode = TreeView_TokenTree.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.Nodes.Count = 0 Then
                objSemItem_Children.GUID = New Guid(objTreeNode.Name)
                objSemItem_Children.Name = objTreeNode.Text
                objSemItem_Children.GUID_Parent = objSemItem_Parent.GUID
                objSemItem_Children.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objTreeNode_Parent = objTreeNode.Parent

                If objTreeNode_Parent Is Nothing Then

                    objSemItem_Parent = Nothing
                Else
                    objSemItem_Parent.GUID = New Guid(objTreeNode_Parent.Name)
                    objSemItem_Parent.Name = objTreeNode_Parent.Text
                    objSemItem_Parent.GUID_Parent = objSemItem_Parent.GUID
                    objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                End If

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                If Not objSemItem_Parent Is Nothing Then
                    objSemItem_Parent.Direction = objSemItem_Parent.Direction_LeftRight
                    objSemItem_Parent.GUID_Related = objSemItem_RelationType.GUID

                    objSemItem_Result = objTransaction_TreeOfToken.del_002_TokenRel(objSemItem_Parent, objSemItem_Children)
                End If

                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_TreeOfToken.del_001_Token(objSemItem_Children)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objTreeNode.Remove()
                    Else
                        MsgBox("Der Knoten konnte nicht entfernt werden!", MsgBoxStyle.Exclamation)
                        objTransaction_TreeOfToken.save_002_TokenRel(objSemItem_Parent, objSemItem_Children)
                    End If
                Else
                    MsgBox("Der Knoten konnte nicht entfernt werden!", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub Timer_Tree_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Tree.Tick
        Dim dateNow As Date
        Dim objDR_Nodes As DataRow
        Dim objTreeNodes() As TreeNode
        Dim boolSearch As Boolean

        dateNow = Now

        ToolStripProgressBar_Tree.Visible = True

        While (Now - dateNow).Milliseconds <= 200
            If boolDataGet = True Then

                If intRowID < procT_TokenTree_TopDown.Count Then
                    objDR_Nodes = procT_TokenTree_TopDown.Rows(intRowID)
                    If IsDBNull(objDR_Nodes.Item("GUID_Token_Parent")) Then
                        TreeView_TokenTree.Nodes.Add(objDR_Nodes.Item("GUID_Token").ToString, _
                                                     objDR_Nodes.Item("Name_Token"), 0)
                    Else
                        boolSearch = True
                        If Not objTreeNode_Parent Is Nothing Then
                            If objTreeNode_Parent.Name = objDR_Nodes.Item("GUID_Token").ToString Then
                                boolSearch = False
                            End If
                        End If
                        If boolSearch = True Then
                            objTreeNodes = TreeView_TokenTree.Nodes.Find(objDR_Nodes.Item("GUID_Token_Parent").ToString, True)
                            If objTreeNodes.Count > 0 Then
                                objTreeNode_Parent = objTreeNodes(0)
                            Else
                                objTreeNode_Parent = Nothing
                            End If
                        End If

                        If Not objTreeNode_Parent Is Nothing Then
                            objTreeNode_Parent.Nodes.Add(objDR_Nodes.Item("GUID_Token").ToString, _
                                                         objDR_Nodes.Item("Name_Token"), _
                                                         0)

                        End If
                    End If

                    intRowID = intRowID + 1
                Else
                    ToolStripProgressBar_Tree.Maximum = procT_TokenTree_TopDown.Rows.Count
                    ToolStripProgressBar_Tree.Value = intRowID
                    ToolStripLabel_LBL.Text = procT_TokenTree_TopDown.Rows.Count.ToString

                    If boolDataGet = True Then
                        select_Node()
                    End If
                    ToolStripProgressBar_Tree.Visible = False
                    Timer_Tree.Stop()
                End If


            End If


        End While
        
    End Sub

    Private Sub FilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Token As New clsSemItem

        objTreeNode = TreeView_TokenTree.SelectedNode

        If Not objTreeNode Is Nothing Then
            objSemItem_Token.GUID = New Guid(objTreeNode.Name)
            objSemItem_Token.Name = objTreeNode.Text
            If objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                objSemItem_Token.GUID_Parent = objSemItem_Parent.GUID_Parent
            Else
                objSemItem_Token.GUID_Parent = objSemItem_Parent.GUID
            End If
            objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            initialize(objSemItem_Token)
        End If
    End Sub

    Private Sub ToolStripButton_Change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Change.Click
        Dim objSemItem_RelationType As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        objSemItem_RelationType.GUID = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
        objSemItem_RelationType.Name = objLocalConfig.Globals.ObjectReferenceType_RelationType.Name
        objSemItem_RelationType.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
        objFRMSemManager = New frmSemManager(objSemItem_RelationType, objLocalConfig.Globals)
        objFRMSemManager.Applyabale = True
        objFRMSemManager.ShowDialog(Me)

        If objFRMSemManager.DialogResult = DialogResult.OK Then
            If objFRMSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID Then
                If objFRMSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFRMSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    objSemItem_RelationType.GUID = objDRV_Selected.Item("GUID_RelationType")
                    objSemItem_RelationType.Name = objDRV_Selected.Item("Name_RelationType")
                    objSemItem_RelationType.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

                    Me.objSemItem_RelationType.GUID = objSemItem_RelationType.GUID
                    Me.objSemItem_RelationType.Name = objSemItem_RelationType.Name

                    ToolStripTextBox_RelationType.Text = objSemItem_RelationType.Name

                    fill_Tree()

                Else
                    MsgBox("Wählen Sie bitte einen Beziehungstyp auswählen!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Wählen Sie bitte einen Beziehungstyp auswählen!", MsgBoxStyle.Exclamation)

            End If

        End If
    End Sub
End Class
