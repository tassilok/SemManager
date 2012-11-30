Imports Sem_Manager
Public Class UserControl_RelationTree
    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Close As Integer = 1
    Private Const cint_ImageID_Close_SubItems As Integer = 2
    Private Const cint_ImageID_Close_Images As Integer = 3
    Private Const cint_ImageID_Close_Images_SubItems As Integer = 4
    Private Const cint_ImageID_Open As Integer = 5
    Private Const cint_ImageID_Open_SubItems As Integer = 6
    Private Const cint_ImageID_Open_Images As Integer = 7
    Private Const cint_ImageID_Open_Images_SubItems As Integer = 8
    Private Const cint_ImageID_Attributes As Integer = 9
    Private Const cint_ImageID_RelationTypes As Integer = 10
    Private Const cint_ImageID_Token As Integer = 11
    Private Const cint_ImageID_Attribute As Integer = 12
    Private Const cint_ImageID_RelationType As Integer = 13
    Private Const cint_ImageID_Token_Named As Integer = 14
    Private Const cint_ImageID_Close_RelateChoose As Integer = 15
    Private Const cint_ImageID_Open_RelateChoose As Integer = 16

    Private objLocalConfig As clsLocalConfig

    Private objFrmSemManager As frmSemManager

    Private procA_relatedItems_Localized As New ds_LocalizeTableAdapters.proc_relatedItems_LocalizedTableAdapter
    Private procT_relatedItems_Localized As New ds_Localize.proc_relatedItems_LocalizedDataTable

    Private objTreeNode_Root As TreeNode
    Private objTreeNode_Attributes As TreeNode
    Private objTreeNode_RelationTypes As TreeNode
    Private objTreeNode_Token As TreeNode
    Private objTreeNode_Types As TreeNode

    Private semtblT_Type As New ds_SemDB.semtbl_TypeDataTable

    Private objSemWork As clsSemWork

    Private intitemCount As Integer

    Public Event selected_Item(ByVal objSemItem As clsSemItem)


    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
        fill_Tree()
    End Sub

    Private Sub fill_Tree()
        Dim objDRs_Item() As DataRow
        Dim objDR_Item As DataRow
        Dim objTreeNodes() As TreeNode

        TreeView_RelatedItems.Nodes.Clear()

        procA_relatedItems_Localized.Fill(procT_relatedItems_Localized, _
                                          objLocalConfig.SemItem_type_LocalizedDescription.GUID, _
                                          objLocalConfig.SemItem_Type_Localized_Names.GUID, _
                                          objLocalConfig.SemItem_RelationType_describes.GUID, _
                                          objLocalConfig.SemItem_RelationType_alternative_for.GUID)

        objTreeNode_Root = TreeView_RelatedItems.Nodes.Add(objLocalConfig.SemItem_type_LocalizedDescription.GUID.ToString, _
                                                           objLocalConfig.SemItem_type_LocalizedDescription.Name, _
                                                           cint_ImageID_Root, _
                                                           cint_ImageID_Root)

        objDRs_Item = procT_relatedItems_Localized.Select("GUID_Type='" & objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString & "'")
        intitemCount = intitemCount + objDRs_Item.Count
        If objDRs_Item.Count > 0 Then
            objTreeNode_Attributes = objTreeNode_Root.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString, _
                                                                     objLocalConfig.Globals.ObjectReferenceType_Attribute.Name, _
                                                                     cint_ImageID_Attributes, _
                                                                     cint_ImageID_Attributes)
            For Each objDR_Item In objDRs_Item
                objTreeNode_Attributes.Nodes.Add(objDR_Item.Item("GUID_Item").ToString, _
                                                 objDR_Item.Item("Name_Item"), _
                                                 cint_ImageID_Attribute, _
                                                 cint_ImageID_Attribute)

            Next
        End If

        objDRs_Item = procT_relatedItems_Localized.Select("GUID_Type='" & objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString & "'")
        intitemCount = intitemCount + objDRs_Item.Count
        If objDRs_Item.Count > 0 Then
            objTreeNode_RelationTypes = objTreeNode_Root.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString, _
                                                                     objLocalConfig.Globals.ObjectReferenceType_RelationType.Name, _
                                                                     cint_ImageID_RelationTypes, _
                                                                     cint_ImageID_RelationTypes)
            For Each objDR_Item In objDRs_Item
                objTreeNode_RelationTypes.Nodes.Add(objDR_Item.Item("GUID_Item").ToString, _
                                                 objDR_Item.Item("Name_Item"), _
                                                 cint_ImageID_RelationType, _
                                                 cint_ImageID_RelationType)

            Next
        End If


        fill_Tree_Types()

        objDRs_Item = procT_relatedItems_Localized.Select("GUID_Type='" & objLocalConfig.Globals.ObjectReferenceType_Token.GUID.ToString & "'")
        intitemCount = intitemCount + objDRs_Item.Count
        For Each objDR_Item In objDRs_Item
            objTreeNodes = TreeView_RelatedItems.Nodes.Find(objDR_Item.Item("GUID_Parent").ToString, True)
            If objTreeNodes.Count > 0 Then
                objTreeNodes(0).Nodes.Add(objDR_Item.Item("GUID_Item").ToString, _
                                          objDR_Item.Item("Name_Item"), _
                                          cint_ImageID_Token, _
                                          cint_ImageID_Token)
            End If
        Next

        ToolStripLabel_Count_RelatedItems.Text = intitemCount.ToString
    End Sub

    Private Sub fill_Tree_Types(Optional ByVal objTreeNode_Parent As TreeNode = Nothing)
        Dim objDRs_Type() As DataRow
        Dim objDR_Type As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode As TreeNode
        Dim intImageID1 As Integer
        Dim intImageID2 As Integer

        If objTreeNode_Parent Is Nothing Then
            objDRs_Type = procT_relatedItems_Localized.Select("GUID_Type='" & objLocalConfig.Globals.ObjectReferenceType_Type.GUID.ToString & "' AND " & _
                                                              "GUID_Parent IS NULL")
        Else
            objDRs_Type = procT_relatedItems_Localized.Select("GUID_Type='" & objLocalConfig.Globals.ObjectReferenceType_Type.GUID.ToString & "' AND " & _
                                                              "GUID_Parent='" & objTreeNode_Parent.Name & "'")
        End If

        For Each objDR_Type In objDRs_Type

            If objDR_Type.Item("isRelated") = True Then
                intitemCount = intitemCount + 1
                intImageID1 = cint_ImageID_Close_Images
                intImageID2 = cint_ImageID_Open_Images
            Else
                intImageID1 = cint_ImageID_Close
                intImageID2 = cint_ImageID_Open
            End If

            If IsDBNull(objDR_Type.Item("GUID_Parent")) Then
                objTreeNode = objTreeNode_Root.Nodes.Add(objDR_Type.Item("GUID_Item").ToString, objDR_Type.Item("Name_Item"), intImageID1, intImageID2)
            Else
                objTreeNodes = objTreeNode_Parent.Nodes.Find(objDR_Type.Item("GUID_Parent").ToString, True)
                If objTreeNodes.Count = 0 Then
                    objTreeNode = objTreeNode_Parent.Nodes.Add(objDR_Type.Item("GUID_Item").ToString, objDR_Type.Item("Name_Item"), intImageID1, intImageID2)
                Else
                    objTreeNode = objTreeNodes(0)
                End If
            End If

            fill_Tree_Types(objTreeNode)
        Next
    End Sub



    Private Sub set_DBConnection()
        procA_relatedItems_Localized.Connection = objLocalConfig.Connection_Plugin


    End Sub

    Private Sub TreeView_RelatedItems_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_RelatedItems.AfterSelect
        Dim objTreeNode As TreeNode
        Dim objSemItem_Selected As New clsSemItem

        objTreeNode = e.Node
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Attribute
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                    RaiseEvent selected_Item(objSemItem_Selected)
                Case cint_ImageID_Close, cint_ImageID_Close_Images
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                    RaiseEvent selected_Item(objSemItem_Selected)
                Case cint_ImageID_RelationType
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                    RaiseEvent selected_Item(objSemItem_Selected)
                Case cint_ImageID_Token
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    RaiseEvent selected_Item(objSemItem_Selected)
                Case Else
                    RaiseEvent selected_Item(Nothing)
            End Select
        End If
    End Sub

    Private Sub ContextMenuStrip_Related_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Related.Opening
        Dim objTreeNode As TreeNode

        NewToolStripMenuItem.Enabled = False
        objTreeNode = TreeView_RelatedItems.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Attributes, cint_ImageID_Close, cint_ImageID_Close_Images, cint_ImageID_RelationTypes, cint_ImageID_Root
                    NewToolStripMenuItem.Enabled = True
            End Select

        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Selected As New clsSemItem

        objTreeNode = TreeView_RelatedItems.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Attributes
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                    objFrmSemManager = New frmSemManager(objSemItem_Selected, objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)
                    If objFrmSemManager.DialogResult = DialogResult.OK Then
                        If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID Then
                            add_RelItem_Rows(objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID)
                        End If
                    End If
                Case cint_ImageID_Close, cint_ImageID_Close_Images
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objFrmSemManager = New frmSemManager(objSemItem_Selected, objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)
                    If objFrmSemManager.DialogResult = DialogResult.OK Then
                        If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                            add_RelItem_Rows(objLocalConfig.Globals.ObjectReferenceType_Token.GUID)
                        End If
                    End If

                Case cint_ImageID_RelationTypes
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

                    objFrmSemManager = New frmSemManager(objSemItem_Selected, objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)
                    If objFrmSemManager.DialogResult = DialogResult.OK Then
                        If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID Then
                            add_RelItem_Rows(objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID)
                        End If
                    End If
                Case cint_ImageID_Root
                    objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)
                    If objFrmSemManager.DialogResult = DialogResult.OK Then
                        Select Case objFrmSemManager.SelectedItems_TypeGUID
                            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                add_RelItem_Rows(objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID)
                            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                                add_RelItem_Rows(objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID)
                            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                add_RelItem_Rows(objLocalConfig.Globals.ObjectReferenceType_Token.GUID)

                            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                                add_RelItem_Type()

                        End Select
                    End If
            End Select
        End If
    End Sub

    Private Sub add_RelItem_Type()
        Dim objSemItem_Result As clsSemItem

        objSemWork = New clsSemWork(objLocalConfig.Globals)
        For Each objSemItem_Result In objFrmSemManager.SemItems_Selected
            objSemWork.add_Type(objSemItem_Result.GUID, True)

        Next

        semtblT_Type = objSemWork.semtblT_Type

        add_Tree_Types()
    End Sub

    Private Sub add_RelItem_Rows(ByVal GUID_Type As Guid)
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode As TreeNode

        Dim objDR_Type As DataRow
        Dim objDR_Token As DataRow

        Select Case GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                If objFrmSemManager.SelectedRows_Items.Count > 0 Then
                    objTreeNodes = TreeView_RelatedItems.Nodes.Find(objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString, False)
                    If objTreeNodes.Count = 0 Then
                        objTreeNode = TreeView_RelatedItems.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString, _
                                                                      objLocalConfig.Globals.ObjectReferenceType_Attribute.Name, _
                                                                      cint_ImageID_Attributes, _
                                                                      cint_ImageID_Attributes)

                    Else
                        objTreeNode = objTreeNodes(0)
                    End If
                End If
                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    objTreeNodes = objTreeNode_Attributes.Nodes.Find(objDRV_Selected.Item("GUID_Attribute").ToString, False)
                    If objTreeNodes.Count = 0 Then
                        objTreeNode_Attributes.Nodes.Add(objDRV_Selected.Item("GUID_Attribute"), _
                                                         objDRV_Selected.Item("Name_Attribute"), _
                                                         cint_ImageID_Attribute, _
                                                         cint_ImageID_Attribute)
                    End If

                Next

            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                If objFrmSemManager.SelectedRows_Items.Count > 0 Then
                    objTreeNodes = TreeView_RelatedItems.Nodes.Find(objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString, False)
                    If objTreeNodes.Count = 0 Then
                        objTreeNode = TreeView_RelatedItems.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString, _
                                                                      objLocalConfig.Globals.ObjectReferenceType_RelationType.Name, _
                                                                      cint_ImageID_RelationTypes, _
                                                                      cint_ImageID_RelationTypes)

                    Else
                        objTreeNode = objTreeNodes(0)
                    End If

                    
                End If
                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    objTreeNodes = objTreeNode_RelationTypes.Nodes.Find(objDRV_Selected.Item("GUID_RelationType").ToString, False)
                    If objTreeNodes.Count = 0 Then
                        objTreeNode_RelationTypes.Nodes.Add(objDRV_Selected.Item("GUID_RelationType"), _
                                                         objDRV_Selected.Item("Name_RelationType"), _
                                                         cint_ImageID_RelationType, _
                                                         cint_ImageID_RelationType)
                    End If
                Next
            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemWork = New clsSemWork(objLocalConfig.Globals)

                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    objSemWork.add_Token(objDRV_Selected.Item("GUID_Token"))
                    objSemWork.add_Type(objDRV_Selected.Item("GUID_Type"), True)

                Next

                semtblT_Type = objSemWork.semtblT_Type

                add_Tree_Types()
                For Each objDR_Token In objSemWork.semtblT_Token.Rows
                    objTreeNodes = TreeView_RelatedItems.Nodes.Find(objDR_Token.Item("GUID_Type").ToString, True)
                    objTreeNodes(0).Nodes.Add(objDR_Token.Item("GUID_Token").ToString, _
                                              objDR_Token.Item("Name_Token"), _
                                              cint_ImageID_Token, _
                                              cint_ImageID_Token)
                Next
        End Select
    End Sub

    Private Sub add_Tree_Types(Optional ByVal objTreeNode_Parent As TreeNode = Nothing)
        Dim objDRs_Type() As DataRow
        Dim objDR_Type As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Sub As TreeNode

        If objTreeNode_Parent Is Nothing Then
            objDRs_Type = semtblT_Type.Select("GUID_Type_Parent IS NULL")
            For Each objDR_Type In objDRs_Type
                objTreeNodes = TreeView_RelatedItems.Nodes.Find(objDR_Type.Item("GUID_Type").ToString, True)
                If objTreeNodes.Count = 0 Then
                    objTreeNode_Sub = TreeView_RelatedItems.Nodes.Add(objDR_Type.Item("GUID_Type").ToString, _
                                                                      objDR_Type.Item("Name_Type"), _
                                                                      cint_ImageID_Close, _
                                                                      cint_ImageID_Open)
                Else
                    objTreeNode_Sub = objTreeNodes(0)
                End If
                add_Tree_Types(objTreeNode_Sub)
            Next
        Else
            objDRs_Type = semtblT_Type.Select("GUID_Type_Parent='" & objTreeNode_Parent.Name & "'")
            For Each objDR_Type In objDRs_Type
                objTreeNodes = objTreeNode_Parent.Nodes.Find(objDR_Type.Item("GUID_Type").ToString, _
                                                             False)
                If objTreeNodes.Count = 0 Then
                    objTreeNode_Sub = objTreeNode_Parent.Nodes.Add(objDR_Type.Item("GUID_Type").ToString, _
                                                                      objDR_Type.Item("Name_Type"), _
                                                                      cint_ImageID_Close, _
                                                                      cint_ImageID_Open)
                Else
                    objTreeNode_Sub = objTreeNodes(0)
                End If
                add_Tree_Types(objTreeNode_Sub)
            Next
        End If
    End Sub
End Class
