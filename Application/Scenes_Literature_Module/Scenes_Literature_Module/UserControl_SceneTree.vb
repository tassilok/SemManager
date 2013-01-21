Imports Sem_Manager
Imports Office_Manager
Public Class UserControl_SceneTree
    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Level1Rel_Close As Integer = 1
    Private Const cint_ImageID_Level1Rel_Open As Integer = 2
    Private Const cint_ImageiD_Level2Rel_Close As Integer = 3
    Private Const cint_ImageiD_Level2Rel_Open As Integer = 4
    Private Const cint_ImageID_Scene As Integer = 5

    Private procA_Scenes_Related As New DataSet_ScenesTableAdapters.proc_Scenes_RelatedTableAdapter
    Private procT_Scenes_Related As New DataSet_Scenes.proc_Scenes_RelatedDataTable

    Private procA_Bookmarks_Of_Scene As New DataSet_ScenesTableAdapters.proc_BookMark_Of_SceneTableAdapter
    Private procA_Scenes_By_Charakter As New DataSet_ScenesTableAdapters.proc_Scenes_By_CharakterTableAdapter
    Private procT_Scenes_By_Charakter As New DataSet_Scenes.proc_Scenes_By_CharakterDataTable
    Private procA_Scenes_By_Datum As New DataSet_ScenesTableAdapters.proc_Scenes_By_DatumTableAdapter
    Private procT_Scenes_By_Datum As New DataSet_Scenes.proc_Scenes_By_DatumDataTable
    Private procA_Scenes_By_Orte As New DataSet_ScenesTableAdapters.proc_Scenes_By_OrteTableAdapter
    Private procT_Scenes_By_Orte As New DataSet_Scenes.proc_Scenes_By_OrteDataTable
    Private procA_Scenes_By_dramaturgyPhase As New DataSet_ScenesTableAdapters.proc_Scenes_By_dramaturgyPhaseTableAdapter
    Private procT_Scenes_By_dramaturgyPhase As New DataSet_Scenes.proc_Scenes_By_dramaturgyPhaseDataTable

    Private procA_Scenes As New DataSet_ScenesTableAdapters.proc_Scenes_RelatedTableAdapter
    Private procT_Scenes As New DataSet_Scenes.proc_Scenes_RelatedDataTable

    Private objFrmSemManager As frmSemManager
    Private objFrmTokenEdit As frmTokenEdit

    Private semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtblA_TokenToken As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter

    Private objTransaction_Scene As clsTransaction_Scene

    Private objDocumentation As clsDocumentation

    Private objDlgAttribute_VARCHAR255 As dlgAttribute_Varchar255

    Private objLocalConfig As clsLocalConfig
    Private objSemItems_Relations() As clsSemItem
    Private objSemItem_Bookmark As clsSemItem

    Private objSemItem_Character As clsSemItem
    Private objSemItem_Ort As clsSemItem
    Private objSemItem_Datum As clsSemItem
    Private objSemItem_dramaturgyPhase As clsSemItem

    Private objTreeNode_Root As TreeNode

    Private intFound As Integer

    Public Event selected_Node(ByVal objSemItem_Item As clsSemItem)

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        objSemItems_Relations = Nothing
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        objSemItems_Relations = Nothing
        initialize()
    End Sub

    Public Sub New(ByVal SemItems_Relations() As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        objSemItems_Relations = SemItems_Relations
        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
        get_BaseData_Form()
        configure_Tree()

    End Sub

    Private Sub get_BaseData_Form()
        ToolStripComboBox_SearchTemplates.Items.Clear()
        ToolStripComboBox_SearchTemplates.Items.Add(objLocalConfig.SemItem_Token_Search_Template_Character_)
        ToolStripComboBox_SearchTemplates.Items.Add(objLocalConfig.SemItem_Token_Search_Template_Date_)
        ToolStripComboBox_SearchTemplates.Items.Add(objLocalConfig.SemItem_Token_Search_Template_Location_)
        ToolStripComboBox_SearchTemplates.Items.Add(objLocalConfig.SemItem_Token_Search_Template_Name_)
        ToolStripComboBox_SearchTemplates.Items.Add(objLocalConfig.SemItem_Token_Search_Template_dramaturgy_phase_)

        ToolStripComboBox_SearchTemplates.ComboBox.DisplayMember = "Name"
        ToolStripComboBox_SearchTemplates.ComboBox.ValueMember = "GUID"

        Select Case objLocalConfig.SemItem_SearchTemplate_Standard.GUID
            Case objLocalConfig.SemItem_Token_Search_Template_Name_.GUID
                ToolStripComboBox_SearchTemplates.SelectedItem = objLocalConfig.SemItem_Token_Search_Template_Name_
            Case objLocalConfig.SemItem_Token_Search_Template_Character_.GUID
                ToolStripComboBox_SearchTemplates.SelectedItem = objLocalConfig.SemItem_Token_Search_Template_Character_
            Case objLocalConfig.SemItem_Token_Search_Template_Date_.GUID
                ToolStripComboBox_SearchTemplates.SelectedItem = objLocalConfig.SemItem_Token_Search_Template_Date_
            Case objLocalConfig.SemItem_Token_Search_Template_Location_.GUID
                ToolStripComboBox_SearchTemplates.SelectedItem = objLocalConfig.SemItem_Token_Search_Template_Location_
            Case objLocalConfig.SemItem_Token_Search_Template_dramaturgy_phase_.GUID
                ToolStripComboBox_SearchTemplates.SelectedItem = objLocalConfig.SemItem_Token_Search_Template_dramaturgy_phase_
        End Select


    End Sub

    Private Sub configure_Tree()

        TreeView_Scenes.Nodes.Clear()

        objTreeNode_Root = TreeView_Scenes.Nodes.Add(objLocalConfig.SemItem_Type_Szene.GUID.ToString, objLocalConfig.SemItem_Type_Szene.Name, cint_ImageID_Root, cint_ImageID_Root)

        If objSemItems_Relations Is Nothing Then
            configure_Tree_NoRelations()

        Else
            configure_Tree_Relations()
        End If

    End Sub

    Private Sub configure_Tree_NoRelations()
        
        procA_Scenes.Fill(procT_Scenes, _
                              objLocalConfig.SemItem_Type_Szene.GUID, _
                              objLocalConfig.SemItem_RelationType_contains.GUID)

        configure_Scenes(objTreeNode_Root)
    End Sub

    Private Sub configure_Scenes(ByVal objTreeNode_Parent As TreeNode)
        Dim objDRs_Scene() As DataRow
        Dim objDR_Scene As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode As TreeNode
        objDRs_Scene = procT_Scenes.Select("GUID_Scene_Parent IS NULL")
        For Each objDR_Scene In objDRs_Scene
            objTreeNodes = objTreeNode_Root.Nodes.Find(objDR_Scene.Item("GUID_Scene").ToString, False)
            If objTreeNodes.Count = 0 Then
                objTreeNode = objTreeNode_Root.Nodes.Add(objDR_Scene.Item("GUID_Scene").ToString, _
                                                         objDR_Scene.Item("Name_Scene"), cint_ImageID_Scene, cint_ImageID_Scene)

            Else
                objTreeNode = objTreeNodes(0)
            End If

            configure_SubScenes(objTreeNode)
        Next
    End Sub


    Private Sub configure_SubScenes(ByVal objTreeNode_Scene_Parent As TreeNode)
        Dim objDRs_Scene() As DataRow
        Dim objDR_Scene As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode As TreeNode

        objDRs_Scene = procT_Scenes.Select("GUID_Scene_Parent='" & objTreeNode_Scene_Parent.Name & "'")

        For Each objDR_Scene In objDRs_Scene
            objTreeNodes = objTreeNode_Scene_Parent.Nodes.Find(objDR_Scene.Item("GUID_Scene").ToString, False)
            If objTreeNodes.Count = 0 Then
                objTreeNode = objTreeNode_Scene_Parent.Nodes.Add(objDR_Scene.Item("GUID_Scene").ToString, objDR_Scene.Item("Name_Scene"), cint_ImageID_Scene, cint_ImageID_Scene)
            Else
                objTreeNode = objTreeNodes(0)
            End If

            configure_SubScenes(objTreeNode)

        Next
    End Sub

    Private Sub configure_Tree_Relations()
        Dim objDRC_Related_L1 As DataRowCollection
        Dim objDR_Related_L1 As DataRow
        Dim objTreeNode_Related As TreeNode
        procA_Scenes_Related.Fill(procT_Scenes_Related, _
                                  objLocalConfig.SemItem_Type_Szene.GUID, _
                                  objLocalConfig.SemItem_RelationType_contains.GUID)

        objDRC_Related_L1 = semtblA_Token.GetData_Token_TypeChilds(objSemItems_Relations(0).GUID).Rows
        For Each objDR_Related_L1 In objDRC_Related_L1
            objTreeNode_Related = objTreeNode_Root.Nodes.Add(objDR_Related_L1.Item("GUID_Token").ToString, objDR_Related_L1.Item("Name_Token"), cint_ImageID_Level1Rel_Close, cint_ImageID_Level1Rel_Open)
            If objSemItems_Relations.Count = 2 Then
                get_Relation_L2(objTreeNode_Related)
            Else
                configure_Scenes_Related(objTreeNode_Related, 0)
            End If

        Next
    End Sub

    Private Sub get_Relation_L2(ByVal objTreeNode_Parent As TreeNode)
        Dim objDRC_Related_L2 As DataRowCollection
        Dim objDR_Related_L2 As DataRow
        Dim objTreeNode As TreeNode

        If objSemItems_Relations(0).Mark = False Then
            objDRC_Related_L2 = funcA_TokenToken.GetData_TokenToken_LeftRight(New Guid(objTreeNode_Parent.Name), _
                                                                          objSemItems_Relations(0).GUID_Relation, _
                                                                          objSemItems_Relations(1).GUID).Rows
        Else
            objDRC_Related_L2 = funcA_TokenToken.GetData_LeftRight_Ordered_By_GUIDs(New Guid(objTreeNode_Parent.Name), _
                                                                          objSemItems_Relations(1).GUID, _
                                                                          objSemItems_Relations(0).GUID_Relation, True).Rows
        End If
        
        For Each objDR_Related_L2 In objDRC_Related_L2
            objTreeNode = objTreeNode_Parent.Nodes.Add(objDR_Related_L2.Item("GUID_Token_Right").ToString, _
                                         objDR_Related_L2.Item("Name_Token_Right"), cint_ImageiD_Level2Rel_Close, cint_ImageiD_Level2Rel_Close)
            configure_Scenes_Related(objTreeNode, 1)
        Next

    End Sub

    Private Sub configure_Scenes_Related(ByVal objTreeNode_Parent As TreeNode, ByVal ixRelated As Integer)
        Dim objDRs_Scenes() As DataRow
        Dim objDR_Scene As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode As TreeNode

        objDRs_Scenes = procT_Scenes_Related.Select("GUID_Related='" & objTreeNode_Parent.Name & "' AND " & _
                                                    "GUID_RelationType='" & objSemItems_Relations(ixRelated).GUID_Relation.ToString & "'")
        For Each objDR_Scene In objDRs_Scenes

            objTreeNodes = objTreeNode_Parent.Nodes.Find(objDR_Scene.Item("GUID_Scene").ToString, False)
            If objTreeNodes.Count = 0 Then
                objTreeNode = objTreeNode_Parent.Nodes.Add(objDR_Scene.Item("GUID_Scene").ToString, objDR_Scene.Item("Name_Scene"), cint_ImageID_Scene, cint_ImageID_Scene)
            Else
                objTreeNode = objTreeNodes(0)
            End If

            configure_SubScenes(objTreeNode)

        Next
    End Sub

    Private Sub ContextMenuStrip_SceneTree_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_SceneTree.Opening
        Dim objTreeNode_Selected As TreeNode
        Dim objDRC_Bookmark As DataRowCollection

        NewToolStripMenuItem.Enabled = False
        RemoveToolStripMenuItem.Enabled = False
        ApplyToolStripMenuItem.Enabled = False
        WinwordToolStripMenuItem.Enabled = False
        ActivateBookmarkToolStripMenuItem.Enabled = False
        OpenBelongingDocToolStripMenuItem.Enabled = False
        objSemItem_Bookmark = Nothing

        objTreeNode_Selected = TreeView_Scenes.SelectedNode
        Select Case objTreeNode_Selected.ImageIndex
            Case cint_ImageiD_Level2Rel_Close
                NewToolStripMenuItem.Enabled = True
            Case cint_ImageID_Scene
                RemoveToolStripMenuItem.Enabled = True
                ApplyToolStripMenuItem.Enabled = True
                WinwordToolStripMenuItem.Enabled = True
                objDRC_Bookmark = procA_Bookmarks_Of_Scene.GetData(objLocalConfig.SemItem_Type_Szene.GUID, _
                                                                   objLocalConfig.SemItem_Type_ContentObject.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                   New Guid(objTreeNode_Selected.Name), _
                                                                   objLocalConfig.SemItem_Token_ContentType_Bookmark.GUID).Rows
                If objDRC_Bookmark.Count > 0 Then
                    objSemItem_Bookmark = New clsSemItem
                    objSemItem_Bookmark.GUID = objDRC_Bookmark(0).Item("GUID_Bookmark")
                    objSemItem_Bookmark.Name = objDRC_Bookmark(0).Item("Name_Bookmark")
                    objSemItem_Bookmark.GUID_Parent = objLocalConfig.SemItem_Type_ContentObject.GUID
                    objSemItem_Bookmark.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    ActivateBookmarkToolStripMenuItem.Enabled = True
                    OpenBelongingDocToolStripMenuItem.Enabled = True
                End If
        End Select
    End Sub

    Private Sub set_DBConnection()
        semtblA_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_RelationType.Connection = objLocalConfig.Connection_DB
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB
        semtblA_TokenToken.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB

        procA_Scenes_Related.Connection = objLocalConfig.Connection_Plugin
        procA_Scenes.Connection = objLocalConfig.Connection_Plugin
        procA_Scenes_By_Datum.Connection = objLocalConfig.Connection_Plugin
        procA_Scenes_By_Charakter.Connection = objLocalConfig.Connection_Plugin
        procA_Scenes_By_Orte.Connection = objLocalConfig.Connection_Plugin
        procA_Scenes_By_dramaturgyPhase.Connection = objLocalConfig.Connection_Plugin

        procA_Bookmarks_Of_Scene.Connection = objLocalConfig.Connection_Plugin

        objTransaction_Scene = New clsTransaction_Scene(objLocalConfig)
        objDocumentation = New clsDocumentation(objLocalConfig.Globals)
        objDocumentation.Visible = True
    End Sub

    Private Sub TreeView_Scenes_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Scenes.AfterSelect
        Dim objTreeNode As TreeNode
        Dim objSemItem_Item As New clsSemItem

        objTreeNode = TreeView_Scenes.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Scene
                    objSemItem_Item.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Item.Name = objTreeNode.Text
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_Szene.GUID
                    objSemItem_Item.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    RaiseEvent selected_Node(objSemItem_Item)
                Case cint_ImageID_Level1Rel_Close
                    objSemItem_Item.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Item.Name = objTreeNode.Text
                    objSemItem_Item.GUID_Parent = objSemItems_Relations(0).GUID
                    objSemItem_Item.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    RaiseEvent selected_Node(objSemItem_Item)
                Case cint_ImageiD_Level2Rel_Close
                    objSemItem_Item.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Item.Name = objTreeNode.Text
                    objSemItem_Item.GUID_Parent = objSemItems_Relations(1).GUID
                    objSemItem_Item.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    RaiseEvent selected_Node(objSemItem_Item)
            End Select

        End If
    End Sub

    Private Sub ToolStripMenuItem_Add_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_Add_List.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Scenes.SelectedNode

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim strName_Scene As String
        Dim objDRC_Scene As DataRowCollection
        Dim objSemItem_Chapter As clsSemItem
        Dim objSemItem_Scene As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objTreeNode_Scene As TreeNode
        Dim intOrderID As Integer

        objTreeNode = TreeView_Scenes.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageiD_Level2Rel_Close Then
                objDlgAttribute_VARCHAR255 = New dlgAttribute_Varchar255("New " & objLocalConfig.SemItem_Type_Szene.Name, objLocalConfig.Globals)
                objDlgAttribute_VARCHAR255.ShowDialog(Me)
                If objDlgAttribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then

                    objSemItem_Chapter = New clsSemItem
                    objSemItem_Chapter.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Chapter.Name = objTreeNode.Text
                    objSemItem_Chapter.GUID_Parent = objLocalConfig.SemItem_Type_Kapitel.GUID
                    objSemItem_Chapter.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    strName_Scene = objDlgAttribute_VARCHAR255.Value1
                    objDRC_Scene = funcA_TokenToken.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(objSemItem_Chapter.GUID, _
                                                                                                                     strName_Scene, _
                                                                                                                     objLocalConfig.SemItem_Type_Szene.GUID, _
                                                                                                                     objLocalConfig.SemItem_RelationType_contains.GUID).Rows
                    If objDRC_Scene.Count = 0 Then
                        intOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_Chapter.GUID, _
                                                                                     objLocalConfig.SemItem_Type_Szene.GUID, _
                                                                                     objLocalConfig.SemItem_RelationType_contains.GUID)
                        intOrderID = intOrderID + 1

                        objSemItem_Scene = New clsSemItem
                        objSemItem_Scene.GUID = Guid.NewGuid
                        objSemItem_Scene.Name = strName_Scene
                        objSemItem_Scene.GUID_Parent = objLocalConfig.SemItem_Type_Szene.GUID
                        objSemItem_Scene.Level = intOrderID
                        objSemItem_Scene.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_Scene.save_001_Scene(objSemItem_Scene)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Scene.save_002_Chapter_To_Scene(objSemItem_Chapter)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTreeNode_Scene = objTreeNode.Nodes.Add(objSemItem_Scene.GUID.ToString, objSemItem_Scene.Name, cint_ImageID_Scene, cint_ImageID_Scene)
                                TreeView_Scenes.SelectedNode = objTreeNode_Scene
                            Else
                                MsgBox("Die Szene konnte nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                                objTransaction_Scene.del_001_Scene()
                            End If
                        Else
                            MsgBox("Die Szene konnte nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Es gibt bereits eine Szene mit der Bezeichnung!", MsgBoxStyle.Information)
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub ActivateBookmarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivateBookmarkToolStripMenuItem.Click
        Dim objTreeNode_Selected As TreeNode
        Dim objSemItem_Document As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Document As DataRowCollection
        Dim objDRC_Ref As DataRowCollection
        Dim objSemItem_Ref As clsSemItem

        objTreeNode_Selected = TreeView_Scenes.SelectedNode
        If Not objTreeNode_Selected Is Nothing Then
            If objTreeNode_Selected.ImageIndex = cint_ImageID_Scene Then
                If Not objSemItem_Bookmark Is Nothing Then
                    objDRC_Document = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Bookmark.GUID, _
                                                                                    objLocalConfig.SemItem_RelationType_belonging_Document.GUID, _
                                                                                    objLocalConfig.SemItem_Type_Managed_Document.GUID).Rows
                    If objDRC_Document.Count > 0 Then
                        objSemItem_Document.GUID = objDRC_Document(0).Item("GUID_Token_Right")
                        objSemItem_Document.Name = objDRC_Document(0).Item("Name_Token_Right")
                        objSemItem_Document.GUID_Parent = objLocalConfig.SemItem_Type_Managed_Document.GUID
                        objSemItem_Document.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objDRC_Ref = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objSemItem_Document.GUID, _
                                                                                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                        If objDRC_Ref.Count > 0 Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error

                            Select Case objDRC_Ref(0).Item("GUID_ItemType")
                                Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                    objDRC_Ref = semtblA_Attribute.GetData_By_GUID(objDRC_Ref(0).Item("GUID_Ref")).Rows
                                    If objDRC_Ref.Count > 0 Then
                                        objSemItem_Ref = New clsSemItem
                                        objSemItem_Ref.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                                        objSemItem_Ref.Name = objDRC_Ref(0).Item("Name_Attribute")
                                        objSemItem_Ref.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                    End If
                                Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                                    objDRC_Ref = semtblA_RelationType.GetData_By_GUID(objDRC_Ref(0).Item("GUID_Ref")).Rows
                                    If objDRC_Ref.Count > 0 Then
                                        objSemItem_Ref = New clsSemItem
                                        objSemItem_Ref.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                                        objSemItem_Ref.Name = objDRC_Ref(0).Item("Name_RelationType")
                                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

                                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                    End If
                                Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                    objDRC_Ref = semtblA_Token.GetData_Token_By_GUID(objDRC_Ref(0).Item("GUID_Ref")).Rows
                                    If objDRC_Ref.Count > 0 Then
                                        objSemItem_Ref = New clsSemItem
                                        objSemItem_Ref.GUID = objDRC_Ref(0).Item("GUID_Token")
                                        objSemItem_Ref.Name = objDRC_Ref(0).Item("Name_Token")
                                        objSemItem_Ref.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                    End If
                                Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                                    objDRC_Ref = semtblA_Type.GetData_By_GUID(objDRC_Ref(0).Item("GUID_Ref")).Rows
                                    If objDRC_Ref.Count > 0 Then
                                        objSemItem_Ref = New clsSemItem
                                        objSemItem_Ref.GUID = objDRC_Ref(0).Item("GUID_Type")
                                        objSemItem_Ref.Name = objDRC_Ref(0).Item("Name_Type")
                                        objSemItem_Ref.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_parent")
                                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                    End If
                            End Select

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objDocumentation.open_BlobDirWatcher()
                                objSemItem_Result = objDocumentation.is_Doc_Open(objSemItem_Document, True)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                    objSemItem_Document = objDocumentation.open_Document(objSemItem_Ref)
                                Else
                                    objSemItem_Document.Additional1 = objSemItem_Result.Additional1
                                End If

                                If Not objSemItem_Document Is Nothing Then
                                    objSemItem_Result = objDocumentation.activate_Bookmark(objSemItem_Bookmark, _
                                                                   objSemItem_Document)
                                    If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        MsgBox("Der Bookmark konnte nicht geöffnet werden!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    MsgBox("Das Dokument konnte nicht geöffnet werden!", MsgBoxStyle.Exclamation)
                                End If

                            Else
                                MsgBox("Die Referenz zum Dokument konnte nicht ermittelt werden!", MsgBoxStyle.Exclamation)
                            End If
                        End If

                        
                    End If

                End If

            End If
        End If
    End Sub

    Private Sub ContextMenuStrip_ScenesList_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_ScenesList.Opening
        
    End Sub

    Private Sub OpenBelongingDocToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenBelongingDocToolStripMenuItem.Click
        Dim objTreeNode_Selected As TreeNode
        Dim objSemItem_Document As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Document As DataRowCollection
        Dim objDRC_Ref As DataRowCollection
        Dim objSemItem_Ref As clsSemItem

        objTreeNode_Selected = TreeView_Scenes.SelectedNode
        If Not objTreeNode_Selected Is Nothing Then
            If objTreeNode_Selected.ImageIndex = cint_ImageID_Scene Then
                If Not objSemItem_Bookmark Is Nothing Then
                    objDRC_Document = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Bookmark.GUID, _
                                                                                    objLocalConfig.SemItem_RelationType_belonging_Document.GUID, _
                                                                                    objLocalConfig.SemItem_Type_Managed_Document.GUID).Rows
                    If objDRC_Document.Count > 0 Then
                        objSemItem_Document.GUID = objDRC_Document(0).Item("GUID_Token_Right")
                        objSemItem_Document.Name = objDRC_Document(0).Item("Name_Token_Right")
                        objSemItem_Document.GUID_Parent = objLocalConfig.SemItem_Type_Managed_Document.GUID
                        objSemItem_Document.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objDRC_Ref = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objSemItem_Document.GUID, _
                                                                                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                        If objDRC_Ref.Count > 0 Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error

                            Select Case objDRC_Ref(0).Item("GUID_ItemType")
                                Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                    objDRC_Ref = semtblA_Attribute.GetData_By_GUID(objDRC_Ref(0).Item("GUID_Ref")).Rows
                                    If objDRC_Ref.Count > 0 Then
                                        objSemItem_Ref = New clsSemItem
                                        objSemItem_Ref.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                                        objSemItem_Ref.Name = objDRC_Ref(0).Item("Name_Attribute")
                                        objSemItem_Ref.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                    End If
                                Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                                    objDRC_Ref = semtblA_RelationType.GetData_By_GUID(objDRC_Ref(0).Item("GUID_Ref")).Rows
                                    If objDRC_Ref.Count > 0 Then
                                        objSemItem_Ref = New clsSemItem
                                        objSemItem_Ref.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                                        objSemItem_Ref.Name = objDRC_Ref(0).Item("Name_RelationType")
                                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

                                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                    End If
                                Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                    objDRC_Ref = semtblA_Token.GetData_Token_By_GUID(objDRC_Ref(0).Item("GUID_Ref")).Rows
                                    If objDRC_Ref.Count > 0 Then
                                        objSemItem_Ref = New clsSemItem
                                        objSemItem_Ref.GUID = objDRC_Ref(0).Item("GUID_Token")
                                        objSemItem_Ref.Name = objDRC_Ref(0).Item("Name_Token")
                                        objSemItem_Ref.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                    End If
                                Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                                    objDRC_Ref = semtblA_Type.GetData_By_GUID(objDRC_Ref(0).Item("GUID_Ref")).Rows
                                    If objDRC_Ref.Count > 0 Then
                                        objSemItem_Ref = New clsSemItem
                                        objSemItem_Ref.GUID = objDRC_Ref(0).Item("GUID_Type")
                                        objSemItem_Ref.Name = objDRC_Ref(0).Item("Name_Type")
                                        objSemItem_Ref.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_parent")
                                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                    End If
                            End Select

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objDocumentation.open_BlobDirWatcher()
                                objSemItem_Result = objDocumentation.is_Doc_Open(objSemItem_Document, True)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                    objSemItem_Document = objDocumentation.open_Document(objSemItem_Ref)
                                Else
                                    objSemItem_Document.Additional1 = objSemItem_Result.Additional1
                                End If

                                If objSemItem_Document Is Nothing Then
                                    MsgBox("Das Dokument konnte nicht geöffnet werden!", MsgBoxStyle.Exclamation)
                                End If

                            Else
                                MsgBox("Die Referenz zum Dokument konnte nicht ermittelt werden!", MsgBoxStyle.Exclamation)
                            End If
                        End If


                    End If

                End If

            End If
        End If
    End Sub

    Private Sub InsertBookmarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertBookmarkToolStripMenuItem.Click
        Dim objTreeNode_Selected As TreeNode
        Dim objSemItem_Document As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Document As DataRowCollection
        Dim objDRC_Ref As DataRowCollection
        Dim objSemItem_Ref As clsSemItem

        objTreeNode_Selected = TreeView_Scenes.SelectedNode
        If Not objTreeNode_Selected Is Nothing Then
            If objTreeNode_Selected.ImageIndex = cint_ImageID_Scene Then
                objSemItem_Ref = New clsSemItem
                objSemItem_Ref.GUID = New Guid(objTreeNode_Selected.Name)
                objSemItem_Ref.Name = objTreeNode_Selected.Text
                objSemItem_Ref.GUID_Parent = objLocalConfig.SemItem_Type_Szene.GUID
                objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                If MsgBox("Wollen Sie den Bookmark wirklich einfügen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    objSemItem_Result = objDocumentation.insert_BookMark(objSemItem_Ref)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Der Bookmark konnte nicht eingefügt werden!", MsgBoxStyle.Exclamation)
                    End If
                End If



            Else

                MsgBox("Das Dokument konnte nicht geöffnet werden!", MsgBoxStyle.Exclamation)
            End If

        Else
            MsgBox("Die Referenz zum Dokument konnte nicht ermittelt werden!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub ToolStripComboBox_SearchTemplates_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_SearchTemplates.SelectedIndexChanged
        Dim objSemItem_SearchTemplate As clsSemItem

        objSemItem_Character = Nothing
        objSemItem_Datum = Nothing
        objSemItem_Ort = Nothing
        objSemItem_dramaturgyPhase = Nothing
        If Not ToolStripComboBox_SearchTemplates.SelectedItem Is Nothing Then
            objSemItem_SearchTemplate = ToolStripComboBox_SearchTemplates.SelectedItem
            Select Case objSemItem_SearchTemplate.GUID
                Case objLocalConfig.SemItem_Token_Search_Template_Character_.GUID
                    ToolStripButton_GetRel.Enabled = True
                Case objLocalConfig.SemItem_Token_Search_Template_Date_.GUID
                    ToolStripButton_GetRel.Enabled = True
                Case objLocalConfig.SemItem_Token_Search_Template_Location_.GUID
                    ToolStripButton_GetRel.Enabled = True
                Case objLocalConfig.SemItem_Token_Search_Template_Name_.GUID
                    ToolStripButton_GetRel.Enabled = False
                Case objLocalConfig.SemItem_Token_Search_Template_dramaturgy_phase_.GUID
                    ToolStripButton_GetRel.Enabled = True
            End Select

        End If

    End Sub

    
    Private Sub ToolStripComboBox_SearchTemplates_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_SearchTemplates.TextChanged
        objSemItem_Character = Nothing
        objSemItem_Datum = Nothing
        objSemItem_Ort = Nothing
        ToolStripTextBox_Search.Text = ""
        ToolStripLabel_Found.Text = "0"
        Select Case ToolStripComboBox_SearchTemplates.Text.ToLower
            Case objLocalConfig.SemItem_Token_Search_Template_Character_.Name.ToLower
                If Not ToolStripComboBox_SearchTemplates.ComboBox.SelectedValue = objLocalConfig.SemItem_Token_Search_Template_Character_.GUID Then
                    ToolStripComboBox_SearchTemplates.SelectedItem = objLocalConfig.SemItem_Token_Search_Template_Character_
                End If
            Case objLocalConfig.SemItem_Token_Search_Template_Date_.Name.ToLower
                If Not ToolStripComboBox_SearchTemplates.ComboBox.SelectedValue = objLocalConfig.SemItem_Token_Search_Template_Date_.GUID Then
                    ToolStripComboBox_SearchTemplates.SelectedItem = objLocalConfig.SemItem_Token_Search_Template_Date_
                End If
            Case objLocalConfig.SemItem_Token_Search_Template_Location_.Name.ToLower
                If Not ToolStripComboBox_SearchTemplates.ComboBox.SelectedValue = objLocalConfig.SemItem_Token_Search_Template_Location_.GUID Then
                    ToolStripComboBox_SearchTemplates.SelectedItem = objLocalConfig.SemItem_Token_Search_Template_Location_
                End If
            Case objLocalConfig.SemItem_Token_Search_Template_Name_.Name.ToLower
                If Not ToolStripComboBox_SearchTemplates.ComboBox.SelectedValue = objLocalConfig.SemItem_Token_Search_Template_Name_.GUID Then
                    ToolStripComboBox_SearchTemplates.SelectedItem = objLocalConfig.SemItem_Token_Search_Template_Name_
                End If

        End Select
    End Sub

    Private Sub ToolStripButton_GetRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_GetRel.Click
        Dim objSemItem_SearchTemplate As clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        objSemItem_Character = Nothing
        objSemItem_Datum = Nothing
        objSemItem_Ort = Nothing
        objSemItem_dramaturgyPhase = Nothing

        If Not ToolStripComboBox_SearchTemplates.SelectedItem Is Nothing Then
            objSemItem_SearchTemplate = ToolStripComboBox_SearchTemplates.SelectedItem
            Select Case objSemItem_SearchTemplate.GUID
                Case objLocalConfig.SemItem_Token_Search_Template_Character_.GUID
                    objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_literarischer_Charakter, objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)
                    If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                        If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                            
                            If Not objFrmSemManager.SelectedRows_Items Is Nothing Then
                                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                                    objSemItem_Character = New clsSemItem
                                    objSemItem_Character.GUID = objDRV_Selected.Item("GUID_Token")
                                    objSemItem_Character.Name = objDRV_Selected.Item("Name_Token")
                                    objSemItem_Character.GUID_Parent = objLocalConfig.SemItem_Type_literarischer_Charakter.GUID
                                    objSemItem_Character.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    ToolStripTextBox_Search.ReadOnly = True
                                    ToolStripTextBox_Search.Text = objSemItem_Character.Name
                                    ToolStripTextBox_Search.ReadOnly = False
                                    ToolStripButton_Search.Enabled = True
                                Else
                                    MsgBox("Bitte nur einen Charakter auswählen!", MsgBoxStyle.Information, vbOK)
                                End If
                            End If

                        Else
                            MsgBox("Bitte wählen Sie einen Charakter.", MsgBoxStyle.Information, vbOK)
                        End If
                    End If
                Case objLocalConfig.SemItem_Token_Search_Template_Date_.GUID
                    objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_literarisches_Datum, objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)
                    If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                        If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then

                            If Not objFrmSemManager.SelectedRows_Items Is Nothing Then
                                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                                    objSemItem_Datum = New clsSemItem
                                    objSemItem_Datum.GUID = objDRV_Selected.Item("GUID_Token")
                                    objSemItem_Datum.Name = objDRV_Selected.Item("Name_Token")
                                    objSemItem_Datum.GUID_Parent = objLocalConfig.SemItem_Type_literarisches_Datum.GUID
                                    objSemItem_Datum.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    ToolStripTextBox_Search.ReadOnly = True
                                    ToolStripTextBox_Search.Text = objSemItem_Datum.Name
                                    ToolStripTextBox_Search.ReadOnly = False
                                    ToolStripButton_Search.Enabled = True
                                Else
                                    MsgBox("Bitte nur ein Datum auswählen!", MsgBoxStyle.Information, vbOK)
                                End If
                            End If

                        Else
                            MsgBox("Bitte wählen Sie ein Datum.", MsgBoxStyle.Information, vbOK)
                        End If
                    End If
                Case objLocalConfig.SemItem_Token_Search_Template_Location_.GUID
                    objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Literarischer_Ort, objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)
                    If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                        If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                            
                            If Not objFrmSemManager.SelectedRows_Items Is Nothing Then
                                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                                    objSemItem_Ort = New clsSemItem
                                    objSemItem_Ort.GUID = objDRV_Selected.Item("GUID_Token")
                                    objSemItem_Ort.Name = objDRV_Selected.Item("Name_Token")
                                    objSemItem_Ort.GUID_Parent = objLocalConfig.SemItem_Type_Literarischer_Ort.GUID
                                    objSemItem_Ort.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    ToolStripTextBox_Search.ReadOnly = True
                                    ToolStripTextBox_Search.Text = objSemItem_Ort.Name
                                    ToolStripTextBox_Search.ReadOnly = False
                                    ToolStripButton_Search.Enabled = True
                                Else
                                    MsgBox("Bitte nur einen Ort auswählen!", MsgBoxStyle.Information, vbOK)
                                End If
                            End If

                        Else
                            MsgBox("Bitte wählen Sie einen Ort.", MsgBoxStyle.Information, vbOK)
                        End If
                    End If
                Case objLocalConfig.SemItem_Token_Search_Template_Name_.GUID

                Case objLocalConfig.SemItem_Token_Search_Template_dramaturgy_phase_.GUID
                    objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Dramaturgische_Ebenen, objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)
                    If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                        If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then

                            If Not objFrmSemManager.SelectedRows_Items Is Nothing Then
                                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                                    objSemItem_dramaturgyPhase = New clsSemItem
                                    objSemItem_dramaturgyPhase.GUID = objDRV_Selected.Item("GUID_Token")
                                    objSemItem_dramaturgyPhase.Name = objDRV_Selected.Item("Name_Token")
                                    objSemItem_dramaturgyPhase.GUID_Parent = objLocalConfig.SemItem_Type_literarischer_Charakter.GUID
                                    objSemItem_dramaturgyPhase.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    ToolStripTextBox_Search.ReadOnly = True
                                    ToolStripTextBox_Search.Text = objSemItem_dramaturgyPhase.Name
                                    ToolStripTextBox_Search.ReadOnly = False
                                    ToolStripButton_Search.Enabled = True
                                Else
                                    MsgBox("Bitte nur eine dramaturgische Ebene auswählen!", MsgBoxStyle.Information, vbOK)
                                End If
                            End If

                        Else
                            MsgBox("Bitte wählen Sie eine dramaturgische Ebene aus.", MsgBoxStyle.Information, vbOK)
                        End If
                    End If
            End Select

        End If

    End Sub

    Private Sub ToolStripTextBox_Search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Search.TextChanged
        If ToolStripTextBox_Search.ReadOnly = False Then
            objSemItem_Character = Nothing
            objSemItem_Datum = Nothing
            objSemItem_Ort = Nothing
            objSemItem_dramaturgyPhase = Nothing
            ToolStripLabel_Found.Text = "0"
            If ToolStripTextBox_Search.Text <> "" Then
                ToolStripButton_Search.Enabled = True
                ToolStripButton_ClearSearch.Enabled = True
            Else
                clear_Mark_Tree()
                ToolStripButton_Search.Enabled = False
                ToolStripButton_ClearSearch.Enabled = False
            End If
        End If
        
    End Sub
    Private Sub search_Ort()
        clear_Mark_Tree()

        If objSemItem_Ort Is Nothing Then
            procA_Scenes_By_Orte.Fill(procT_Scenes_By_Orte, _
                                       objLocalConfig.SemItem_Type_Szene.GUID, _
                                       objLocalConfig.SemItem_Type_Literarischer_Ort.GUID, _
                                       objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                       Nothing,
                                       ToolStripTextBox_Search.Text)

        Else
            procA_Scenes_By_Orte.Fill(procT_Scenes_By_Orte, _
                                       objLocalConfig.SemItem_Type_Szene.GUID, _
                                       objLocalConfig.SemItem_Type_Literarischer_Ort.GUID, _
                                       objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                       objSemItem_Ort.GUID, _
                                       Nothing)
        End If

        search_Ort_InTree()
        ToolStripLabel_Found.Text = procT_Scenes_By_Orte.Rows.Count.ToString
    End Sub

    Private Sub search_Ort_InTree(Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode
        Dim objDRs_Search() As DataRow

        If objTreeNode Is Nothing Then
            For Each objTreeNode_Sub In TreeView_Scenes.Nodes
                If objTreeNode_Sub.ImageIndex = cint_ImageID_Scene Then
                    objDRs_Search = procT_Scenes_By_Orte.Select("GUID_Szene='" & objTreeNode_Sub.Name & "'")
                    If objDRs_Search.Count > 0 Then
                        objTreeNode_Sub.BackColor = Color.Yellow
                        expand_Parents(objTreeNode_Sub)
                    End If
                End If
                search_Ort_InTree(objTreeNode_Sub)
            Next
        Else
            For Each objTreeNode_Sub In objTreeNode.Nodes
                If objTreeNode_Sub.ImageIndex = cint_ImageID_Scene Then
                    objDRs_Search = procT_Scenes_By_Orte.Select("GUID_Szene='" & objTreeNode_Sub.Name & "'")
                    If objDRs_Search.Count > 0 Then
                        objTreeNode_Sub.BackColor = Color.Yellow
                        expand_Parents(objTreeNode_Sub)
                    End If
                End If
                search_Ort_InTree(objTreeNode_Sub)
            Next
        End If
    End Sub
    
    Private Sub search_Character()
        clear_Mark_Tree()

        If objSemItem_Character Is Nothing Then
            procA_Scenes_By_Charakter.Fill(procT_Scenes_By_Charakter, _
                                       objLocalConfig.SemItem_Type_Szene.GUID, _
                                       objLocalConfig.SemItem_Type_literarischer_Charakter.GUID, _
                                       objLocalConfig.SemItem_RelationType_contains.GUID, _
                                       Nothing,
                                       ToolStripTextBox_Search.Text)

        Else
            procA_Scenes_By_Charakter.Fill(procT_Scenes_By_Charakter, _
                                       objLocalConfig.SemItem_Type_Szene.GUID, _
                                       objLocalConfig.SemItem_Type_literarischer_Charakter.GUID, _
                                       objLocalConfig.SemItem_RelationType_contains.GUID, _
                                       objSemItem_Character.GUID, _
                                       Nothing)
        End If
        
        search_Character_InTree()
        ToolStripLabel_Found.Text = procT_Scenes_By_Charakter.Rows.Count.ToString
    End Sub

    Private Sub search_Character_InTree(Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode
        Dim objDRs_Search() As DataRow

        If objTreeNode Is Nothing Then
            For Each objTreeNode_Sub In TreeView_Scenes.Nodes
                If objTreeNode_Sub.ImageIndex = cint_ImageID_Scene Then
                    objDRs_Search = procT_Scenes_By_Charakter.Select("GUID_Szene='" & objTreeNode_Sub.Name & "'")
                    If objDRs_Search.Count > 0 Then
                        objTreeNode_Sub.BackColor = Color.Yellow
                        intFound = intFound + 1
                        expand_Parents(objTreeNode_Sub)
                    End If
                End If
                search_Character_InTree(objTreeNode_Sub)
            Next
        Else
            For Each objTreeNode_Sub In objTreeNode.Nodes
                If objTreeNode_Sub.ImageIndex = cint_ImageID_Scene Then
                    objDRs_Search = procT_Scenes_By_Charakter.Select("GUID_Szene='" & objTreeNode_Sub.Name & "'")
                    If objDRs_Search.Count > 0 Then
                        objTreeNode_Sub.BackColor = Color.Yellow
                        intFound = intFound + 1
                        expand_Parents(objTreeNode_Sub)
                    End If
                End If
                search_Character_InTree(objTreeNode_Sub)
            Next
        End If
    End Sub

    Private Sub search_Datum()
        clear_Mark_Tree()

        If objSemItem_Datum Is Nothing Then
            procA_Scenes_By_Datum.Fill(procT_Scenes_By_Datum, _
                                       objLocalConfig.SemItem_Type_Szene.GUID, _
                                       objLocalConfig.SemItem_Type_literarisches_Datum.GUID, _
                                       objLocalConfig.SemItem_RelationType_findet_statt_am.GUID, _
                                       Nothing,
                                       ToolStripTextBox_Search.Text)

        Else
            procA_Scenes_By_Datum.Fill(procT_Scenes_By_Datum, _
                                       objLocalConfig.SemItem_Type_Szene.GUID, _
                                       objLocalConfig.SemItem_Type_literarisches_Datum.GUID, _
                                       objLocalConfig.SemItem_RelationType_findet_statt_am.GUID, _
                                       objSemItem_Datum.GUID, _
                                       Nothing)
        End If

        search_Datum_InTree()
        ToolStripLabel_Found.Text = procT_Scenes_By_Datum.Rows.Count.ToString
    End Sub

    Private Sub search_Datum_InTree(Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode
        Dim objDRs_Search() As DataRow

        If objTreeNode Is Nothing Then
            For Each objTreeNode_Sub In TreeView_Scenes.Nodes
                If objTreeNode_Sub.ImageIndex = cint_ImageID_Scene Then
                    objDRs_Search = procT_Scenes_By_Datum.Select("GUID_Szene='" & objTreeNode_Sub.Name & "'")
                    If objDRs_Search.Count > 0 Then
                        objTreeNode_Sub.BackColor = Color.Yellow
                        intFound = intFound + 1
                        expand_Parents(objTreeNode_Sub)
                    End If
                End If
                search_Datum_InTree(objTreeNode_Sub)
            Next
        Else
            For Each objTreeNode_Sub In objTreeNode.Nodes
                If objTreeNode_Sub.ImageIndex = cint_ImageID_Scene Then
                    objDRs_Search = procT_Scenes_By_Datum.Select("GUID_Szene='" & objTreeNode_Sub.Name & "'")
                    If objDRs_Search.Count > 0 Then
                        objTreeNode_Sub.BackColor = Color.Yellow
                        intFound = intFound + 1
                        expand_Parents(objTreeNode_Sub)
                    End If
                End If
                search_Datum_InTree(objTreeNode_Sub)
            Next
        End If
    End Sub

    Private Sub expand_Parents(ByVal objTreeNode As TreeNode)
        Dim objTreeNode_Parent As TreeNode

        objTreeNode_Parent = objTreeNode.Parent
        While Not objTreeNode_Parent Is Nothing
            objTreeNode_Parent.Expand()
            objTreeNode_Parent = objTreeNode_Parent.Parent
        End While
    End Sub

    Private Sub clear_Mark_Tree(Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode
        If objTreeNode Is Nothing Then
            For Each objTreeNode_Sub In TreeView_Scenes.Nodes
                objTreeNode_Sub.BackColor = Nothing
                clear_Mark_Tree(objTreeNode_Sub)
            Next
        Else
            For Each objTreeNode_Sub In objTreeNode.Nodes
                objTreeNode_Sub.BackColor = Nothing
                clear_Mark_Tree(objTreeNode_Sub)
            Next
        End If
    End Sub

    Private Sub ToolStripButton_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Search.Click
        Dim objSemItem_SearchTemplate As clsSemItem

        objSemItem_SearchTemplate = ToolStripComboBox_SearchTemplates.SelectedItem
        clear_Mark_Tree()
        If Not objSemItem_SearchTemplate Is Nothing Then
            Select Case objSemItem_SearchTemplate.GUID
                Case objLocalConfig.SemItem_Token_Search_Template_Character_.GUID
                    intFound = 0
                    search_Character()
                    ToolStripLabel_Found.Text = intFound
                Case objLocalConfig.SemItem_Token_Search_Template_Date_.GUID
                    intFound = 0
                    search_Datum()
                    ToolStripLabel_Found.Text = intFound
                Case objLocalConfig.SemItem_Token_Search_Template_Location_.GUID
                    intFound = 0
                    search_Ort()
                    ToolStripLabel_Found.Text = intFound
                Case objLocalConfig.SemItem_Token_Search_Template_Name_.GUID
                    intFound = 0
                    search_NameGUID()
                    ToolStripLabel_Found.Text = intFound

                Case objLocalConfig.SemItem_Token_Search_Template_dramaturgy_phase_.GUID
                    intFound = 0
                    search_dramaturgyPhase()
                    ToolStripLabel_Found.Text = intFound

            End Select
        End If
    End Sub

    Private Sub search_NameGUID(Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode
        Dim strSearch As String
        Dim boolGUID As Boolean

        strSearch = ToolStripTextBox_Search.Text

        If objLocalConfig.Globals.is_GUID(strSearch) Then
            boolGUID = True
        Else
            boolGUID = False
        End If

        If objTreeNode Is Nothing Then
            For Each objTreeNode_Sub In TreeView_Scenes.Nodes
                If boolGUID = True Then
                    If objTreeNode_Sub.Name = strSearch Then
                        objTreeNode_Sub.BackColor = Color.Yellow
                        intFound = intFound + 1
                        expand_Parents(objTreeNode_Sub)
                    End If
                Else
                    If objTreeNode_Sub.Text.ToLower.Contains(strSearch.ToLower) Then
                        objTreeNode_Sub.BackColor = Color.Yellow
                        intFound = intFound + 1
                        expand_Parents(objTreeNode_Sub)
                    End If
                End If
                search_NameGUID(objTreeNode_Sub)
            Next
        Else
            For Each objTreeNode_Sub In objTreeNode.Nodes
                If boolGUID = True Then
                    If objTreeNode_Sub.Name = strSearch Then
                        objTreeNode_Sub.BackColor = Color.Yellow
                        intFound = intFound + 1
                        expand_Parents(objTreeNode_Sub)
                    End If
                Else
                    If objTreeNode_Sub.Text.ToLower.Contains(strSearch.ToLower) Then
                        objTreeNode_Sub.BackColor = Color.Yellow
                        intFound = intFound + 1
                        expand_Parents(objTreeNode_Sub)
                    End If
                End If
                search_NameGUID(objTreeNode_Sub)
            Next
        End If

    End Sub

    Private Sub search_dramaturgyPhase()
        clear_Mark_Tree()

        If objSemItem_dramaturgyPhase Is Nothing Then
            procA_Scenes_By_dramaturgyPhase.Fill(procT_Scenes_By_dramaturgyPhase, _
                                                 Nothing, _
                                                 objLocalConfig.SemItem_Type_Szene.GUID, _
                                                 objLocalConfig.SemItem_Type_Dramaturgische_Ebenen.GUID, _
                                                 objLocalConfig.SemItem_Type_Szenen_auf_Ebenen.GUID, _
                                                 objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                 objLocalConfig.SemItem_RelationType_repr_sentiert.GUID, _
                                                 ToolStripTextBox_Search.Text)

        Else
            procA_Scenes_By_dramaturgyPhase.Fill(procT_Scenes_By_dramaturgyPhase, _
                                                 objSemItem_dramaturgyPhase.GUID, _
                                                 objLocalConfig.SemItem_Type_Szene.GUID, _
                                                 objLocalConfig.SemItem_Type_Dramaturgische_Ebenen.GUID, _
                                                 objLocalConfig.SemItem_Type_Szenen_auf_Ebenen.GUID, _
                                                 objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                 objLocalConfig.SemItem_RelationType_repr_sentiert.GUID, _
                                                 Nothing)
        End If

        search_dramaturgyPhase_InTree()
        ToolStripLabel_Found.Text = procT_Scenes_By_Charakter.Rows.Count.ToString
    End Sub

    Private Sub search_dramaturgyPhase_InTree(Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode
        Dim objDRs_Search() As DataRow

        If objTreeNode Is Nothing Then
            For Each objTreeNode_Sub In TreeView_Scenes.Nodes
                If objTreeNode_Sub.ImageIndex = cint_ImageID_Scene Then
                    objDRs_Search = procT_Scenes_By_dramaturgyPhase.Select("GUID_Szene='" & objTreeNode_Sub.Name & "'")
                    If objDRs_Search.Count > 0 Then
                        objTreeNode_Sub.BackColor = Color.Yellow
                        intFound = intFound + 1
                        expand_Parents(objTreeNode_Sub)
                    End If
                End If
                search_dramaturgyPhase_InTree(objTreeNode_Sub)
            Next
        Else
            For Each objTreeNode_Sub In objTreeNode.Nodes
                If objTreeNode_Sub.ImageIndex = cint_ImageID_Scene Then
                    objDRs_Search = procT_Scenes_By_dramaturgyPhase.Select("GUID_Szene='" & objTreeNode_Sub.Name & "'")
                    If objDRs_Search.Count > 0 Then
                        objTreeNode_Sub.BackColor = Color.Yellow
                        intFound = intFound + 1
                        expand_Parents(objTreeNode_Sub)
                    End If
                End If
                search_dramaturgyPhase_InTree(objTreeNode_Sub)
            Next
        End If
    End Sub

    Private Sub TreeView_Scenes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView_Scenes.KeyDown
        Dim objTreeNode_Parent As TreeNode = Nothing
        Dim objTreeNode_Selected As TreeNode = Nothing
        Dim objTreeNodes() As TreeNode
        Select Case e.KeyCode
            Case Keys.F5
                objTreeNode_Selected = TreeView_Scenes.SelectedNode
                If Not objTreeNode_Selected Is Nothing Then
                    objTreeNode_Parent = objTreeNode_Selected.Parent
                End If
                configure_Tree()
                If Not objTreeNode_Parent Is Nothing Then
                    objTreeNodes = TreeView_Scenes.Nodes.Find(objTreeNode_Parent.Name, True)
                    If objTreeNodes.Count > 0 Then
                        objTreeNodes = objTreeNodes(0).Nodes.Find(objTreeNode_Selected.Name, False)
                        If objTreeNodes.Count > 0 Then
                            objTreeNode_Selected = objTreeNodes(0)
                        Else
                            objTreeNode_Selected = Nothing
                        End If
                    Else
                        objTreeNode_Selected = Nothing
                    End If
                Else

                    If Not objTreeNode_Selected Is Nothing Then
                        objTreeNodes = objTreeNode_Root.Nodes.Find(objTreeNode_Selected.Name, False)
                        If objTreeNodes.Count > 0 Then
                            objTreeNode_Selected = objTreeNodes(0)
                        Else
                            objTreeNode_Selected = Nothing
                        End If
                    End If
                End If

                If Not objTreeNode_Selected Is Nothing Then
                    expand_Parents(objTreeNode_Selected)
                    TreeView_Scenes.SelectedNode = objTreeNode_Selected
                End If

            Case Keys.Up
                objTreeNode_Selected = TreeView_Scenes.SelectedNode
                If Not objTreeNode_Selected Is Nothing Then
                    If e.Control Then
                        move_Scene(True, objTreeNode_Selected)
                    End If
                End If
                

            Case Keys.Down
                objTreeNode_Selected = TreeView_Scenes.SelectedNode
                If Not objTreeNode_Selected Is Nothing Then
                    If e.Control Then
                        move_Scene(False, objTreeNode_Selected)

                    End If
                End If
                
        End Select
    End Sub

    Private Sub TreeView_Scenes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TreeView_Scenes.KeyPress

    End Sub

    Private Sub ToolStripButton_ClearSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ClearSearch.Click
        objSemItem_Character = Nothing
        objSemItem_Datum = Nothing
        objSemItem_Ort = Nothing
        ToolStripTextBox_Search.Text = ""
    End Sub

    Private Sub ExistentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistentToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_Scene As DataRowCollection
        Dim objSemItem_Scene As New clsSemItem
        Dim objSemItem_Chapter As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objTreeNode As TreeNode
        Dim intOrderID As Integer
        Dim intToDo As Integer
        Dim intDone As Integer

        objTreeNode = TreeView_Scenes.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageiD_Level2Rel_Close Then
                objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Szene, objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then

                        objSemItem_Chapter = New clsSemItem
                        objSemItem_Chapter.GUID = New Guid(objTreeNode.Name)
                        objSemItem_Chapter.Name = objTreeNode.Text
                        objSemItem_Chapter.GUID_Parent = objLocalConfig.SemItem_Type_Kapitel.GUID
                        objSemItem_Chapter.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                        intToDo = objFrmSemManager.SelectedRows_Items.Count
                        intToDo = 0
                        For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                            objDRV_Selected = objDGVR_Selected.DataBoundItem
                            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Szene.GUID Then
                                objSemItem_Scene.GUID = objDRV_Selected.Item("GUID_Token")
                                objSemItem_Scene.Name = objDRV_Selected.Item("Name_Token")
                                objSemItem_Scene.GUID_Parent = objLocalConfig.SemItem_Type_Szene.GUID
                                objSemItem_Scene.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objDRC_Scene = semtblA_TokenToken.GetData_By_GUIDs(objSemItem_Chapter.GUID, objSemItem_Scene.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
                                If objDRC_Scene.Count = 0 Then
                                    objDRC_Scene = funcA_TokenToken.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(objSemItem_Chapter.GUID, _
                                                                                                                             objSemItem_Scene.Name, _
                                                                                                                             objLocalConfig.SemItem_Type_Szene.GUID, _
                                                                                                                             objLocalConfig.SemItem_RelationType_contains.GUID).Rows
                                    If objDRC_Scene.Count = 0 Then
                                        intOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_Chapter.GUID, _
                                                                                                     objLocalConfig.SemItem_Type_Szene.GUID, _
                                                                                                     objLocalConfig.SemItem_RelationType_contains.GUID)
                                        intOrderID = intOrderID + 1
                                        objSemItem_Scene.Level = intOrderID
                                        objSemItem_Result = objTransaction_Scene.save_002_Chapter_To_Scene(objSemItem_Chapter, objSemItem_Scene)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objTreeNode.Nodes.Add(objSemItem_Scene.GUID.ToString, objSemItem_Scene.Name, cint_ImageID_Scene, cint_ImageID_Scene)
                                            intDone = intDone + 1
                                        End If
                                    End If
                                End If

                            End If
                        Next
                    Else
                        MsgBox("Bitte nur Token auswählen!", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If
        End If

        If intDone < intToDo Then
            MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Szenen zugeordnet werden!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TreeView_Scenes_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView_Scenes.MouseDoubleClick
        Dim objTreeNode As TreeNode
        Dim objSemItem_Selected As New clsSemItem


        objTreeNode = TreeView_Scenes.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Level1Rel_Close
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Parent = objSemItems_Relations(0).GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objFrmTokenEdit = New frmTokenEdit(objSemItem_Selected, objLocalConfig.Globals)
                    objFrmTokenEdit.ShowDialog(Me)
                Case cint_ImageiD_Level2Rel_Close
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Parent = objSemItems_Relations(1).GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objFrmTokenEdit = New frmTokenEdit(objSemItem_Selected, objLocalConfig.Globals)
                    objFrmTokenEdit.ShowDialog(Me)
                Case cint_ImageID_Scene
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Szene.GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objFrmTokenEdit = New frmTokenEdit(objSemItem_Selected, objLocalConfig.Globals)
                    objFrmTokenEdit.ShowDialog(Me)
            End Select
        End If
    End Sub

    Private Sub move_Scene(ByVal boolUP As Boolean, ByVal objTreeNode_Scene As TreeNode)
        Dim objTreeNode_Parent As TreeNode
        Dim objTreeNode_Scene_New As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim funcT_TokenToken As New ds_Token.func_TokenTokenDataTable
        Dim objDRs_Scenes1() As DataRow
        Dim objDRs_Scenes2() As DataRow
        Dim objDR_Scene As DataRow
        Dim objSemItem_Kapitel As New clsSemItem
        Dim objSemItem_Scene_Old As New clsSemItem
        Dim objSemItem_Scene_New As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intOrderID_old As Integer
        Dim intOrderID_new As Integer

        objTreeNode_Parent = objTreeNode_Scene.Parent

        If objTreeNode_Parent.ImageIndex = cint_ImageiD_Level2Rel_Close Then
            objSemItem_Kapitel.GUID = New Guid(objTreeNode_Parent.Name)
            objSemItem_Kapitel.Name = objTreeNode_Parent.Text
            objSemItem_Kapitel.GUID_Parent = objLocalConfig.SemItem_Type_Kapitel.GUID
            objSemItem_Kapitel.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


            funcA_TokenToken.Fill_LeftRight_Ordered_By_GUIDs(funcT_TokenToken, _
                                                     New Guid(objTreeNode_Parent.Name), _
                                                     objLocalConfig.SemItem_Type_Szene.GUID, _
                                                     objLocalConfig.SemItem_RelationType_contains.GUID, True)
            


            objDRs_Scenes1 = funcT_TokenToken.Select("GUID_Token_Right='" & objTreeNode_Scene.Name & "'")
            If objDRs_Scenes1.Count > 0 Then
                objSemItem_Scene_Old.GUID = New Guid(objTreeNode_Scene.Name)
                objSemItem_Scene_Old.Name = objTreeNode_Scene.Text
                objSemItem_Scene_Old.GUID_Parent = objLocalConfig.SemItem_Type_Szene.GUID
                objSemItem_Scene_Old.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                intOrderID_old = objDRs_Scenes1(0).Item("OrderID")


                If boolUP = True Then
                    objDRs_Scenes2 = funcT_TokenToken.Select("OrderID<" & intOrderID_old)
                Else
                    objDRs_Scenes2 = funcT_TokenToken.Select("OrderID>" & intOrderID_old)
                End If

                If objDRs_Scenes2.Count > 0 Then
                    If boolUP = True Then
                        objSemItem_Scene_New.GUID = objDRs_Scenes2(objDRs_Scenes2.Count - 1).Item("GUID_Token_Right")
                        objSemItem_Scene_New.Name = objDRs_Scenes2(objDRs_Scenes2.Count - 1).Item("Name_Token_Right")
                    Else
                        objSemItem_Scene_New.GUID = objDRs_Scenes2(0).Item("GUID_Token_Right")
                        objSemItem_Scene_New.Name = objDRs_Scenes2(0).Item("Name_Token_Right")
                    End If
                    
                    objSemItem_Scene_New.GUID_Parent = objLocalConfig.SemItem_Type_Szene.GUID
                    objSemItem_Scene_New.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objTreeNodes = objTreeNode_Parent.Nodes.Find(objSemItem_Scene_New.GUID.ToString, False)
                    If objTreeNodes.Count > 0 Then
                        If boolUP = True Then
                            intOrderID_new = objDRs_Scenes2(objDRs_Scenes2.Count - 1).Item("OrderID")

                        Else
                            intOrderID_new = objDRs_Scenes2(0).Item("OrderID")
                        End If

                        objSemItem_Scene_Old.Level = intOrderID_new
                        objSemItem_Scene_New.Level = intOrderID_old

                        objSemItem_Result = objTransaction_Scene.save_002_Chapter_To_Scene(objSemItem_Kapitel, objSemItem_Scene_Old)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Scene.save_002_Chapter_To_Scene(objSemItem_Kapitel, objSemItem_Scene_New)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                funcA_TokenToken.Fill_LeftRight_Ordered_By_GUIDs(funcT_TokenToken, _
                                                         New Guid(objTreeNode_Parent.Name), _
                                                         objLocalConfig.SemItem_Type_Szene.GUID, _
                                                         objLocalConfig.SemItem_RelationType_contains.GUID, True)

                                objTreeNode_Parent.Nodes.Clear()
                                For Each objDR_Scene In funcT_TokenToken.Rows
                                    objTreeNode_Parent.Nodes.Add(objDR_Scene.Item("GUID_Token_Right").ToString, _
                                                                 objDR_Scene.Item("Name_Token_Right"), _
                                                                 cint_ImageID_Scene, cint_ImageID_Scene)
                                Next
                                objTreeNodes = objTreeNode_Parent.Nodes.Find(objSemItem_Scene_Old.GUID.ToString, False)
                                If objTreeNodes.Count > 0 Then
                                    TreeView_Scenes.SelectedNode = objTreeNodes(0)
                                End If
                            Else
                                MsgBox("Leider konnte die Szene nicht verschoben werden!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Leider konnte die Szene nicht verschoben werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Die Ansicht ist nicht mehr aktuell. Aktualisieren Sie bitte die Ansicht!", MsgBoxStyle.Exclamation)
                    End If



                End If
            End If
        End If


    End Sub
End Class