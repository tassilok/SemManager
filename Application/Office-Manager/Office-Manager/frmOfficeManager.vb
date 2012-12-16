Imports Sem_Manager
Public Class frmOfficeManager
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

    Private objLocalConfig As clsLocalConfig
    Private objGlobals As New clsGlobals
    Private objDocumentation As clsDocumentation
    Private boolApplyable As Boolean

    Private WithEvents objUserControl_Documents As UserControl_Documents
    Private WithEvents objUserControl_Bookmarks As UserControl_Bookmarks

    Private objFrmSemManager As frmSemManager

    Private objSemWork_Documents As clsSemWork
    Private objSemWork_ContentItems As clsSemWork

    Private objTreeNode_Root As TreeNode
    Private objTreeNode_Documents As TreeNode
    Private objTreeNode_ContentItems As TreeNode
    Private objTreeNode_RelationTypes As TreeNode
    Private objTreeNode_Attributes As TreeNode

    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtblT_Type As New ds_SemDB.semtbl_TypeDataTable
    Private procA_ContentItems As New ds_OfficeModuleTableAdapters.proc_ContentItemsTableAdapter
    Private procT_ContentItems As New ds_OfficeModule.proc_ContentItemsDataTable
    Private procA_ManagedDocuments As New ds_OfficeModuleTableAdapters.proc_ManagedDocumentDataTableAdapter
    Private procT_ManagedDocuments As New ds_OfficeModule.proc_ManagedDocumentDataDataTable

    Public Event applied_Document_DataGrid(ByVal objDGVSRC_Documents As DataGridViewSelectedRowCollection, ByVal RowName_GUID As String, ByVal RowName_Name As String, ByVal GUID_Parent As Guid)
    Public Event applied_Document_Tree(ByVal objSemItem_Document As clsSemItem)
    Public Event applied_Bookmark(ByVal objSemItem_Bookmark)

    Private intCountDS As Integer

    Private boolPChange_Tree As Boolean

    Public Property applyable As Boolean
        Get
            Return boolApplyable
        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
        End Set
    End Property

    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(objGlobals)


        initialize()
        'test_menue()
    End Sub

    Private Sub initialize()
        Dim strArguments() As String
        objDocumentation = New clsDocumentation(objLocalConfig)

        strArguments = Environment.GetCommandLineArgs
        If strArguments.Count > 0 Then

        End If
        set_DBConnection()
        objUserControl_Bookmarks = New UserControl_Bookmarks(objLocalConfig)
        objUserControl_Bookmarks.Dock = DockStyle.Fill
        SplitContainer2.Panel2.Controls.Add(objUserControl_Bookmarks)
        objUserControl_Documents = New UserControl_Documents(objLocalConfig)
        objUserControl_Documents.Dock = DockStyle.Fill
        SplitContainer2.Panel1.Controls.Add(objUserControl_Documents)

        fill_Tree()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Type.Connection = objLocalConfig.Connection_DB
        procA_ManagedDocuments.Connection = objLocalConfig.Connection_Plugin
        procA_ContentItems.Connection = objLocalConfig.Connection_Plugin
    End Sub

    Private Sub fill_Tree()
        Dim objDRs_Item() As DataRow
        Dim objDR_Item As DataRow
        Dim objDRs_Childs() As DataRow
        Dim objDR_Child As DataRow
        Dim objDRs_Docs() As DataRow
        Dim objTreeNode_Sub As TreeNode
        Dim objTreeNode_SubSub As TreeNode


        boolPChange_Tree = True
        TreeView_Items.Nodes.Clear()

        objTreeNode_Root = TreeView_Items.Nodes.Add(objLocalConfig.SemItem_Token_Module_Office_Manager.GUID.ToString, objLocalConfig.SemItem_Token_Module_Office_Manager.Name, cint_ImageID_Root, cint_ImageID_Root)
        objTreeNode_Documents = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_Managed_Document.GUID.ToString, objLocalConfig.SemItem_Type_Managed_Document.Name, cint_ImageID_Root, cint_ImageID_Root)
        objTreeNode_ContentItems = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_ContentObject.GUID.ToString, objLocalConfig.SemItem_Type_ContentObject.Name, cint_ImageID_Root, cint_ImageID_Root)

        objTreeNode_Attributes = objTreeNode_Documents.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString, objLocalConfig.Globals.ObjectReferenceType_Attribute.Name, cint_ImageID_Attributes, cint_ImageID_Attributes)
        objTreeNode_RelationTypes = objTreeNode_Documents.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString, objLocalConfig.Globals.ObjectReferenceType_RelationType.Name, cint_ImageID_RelationTypes, cint_ImageID_RelationTypes)

        objSemWork_Documents = New clsSemWork(objLocalConfig.Globals)
        objSemWork_Documents.Relations = False
        objSemWork_ContentItems = New clsSemWork(objLocalConfig.Globals)
        objSemWork_ContentItems.Relations = False

        procA_ManagedDocuments.Fill(procT_ManagedDocuments, _
                                    objLocalConfig.SemItem_Attribute_DateTimeStamp__Change_.GUID, _
                                    objLocalConfig.SemItem_Type_Managed_Document.GUID, _
                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                    Nothing)


        objDRs_Item = procT_ManagedDocuments.Select("GUID_ItemType='" & objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString & "'")
        For Each objDR_Item In objDRs_Item
            objSemWork_Documents.add_Attribute(objDR_Item.Item("GUID_Ref"))
        Next

        objDRs_Item = procT_ManagedDocuments.Select("GUID_ItemType='" & objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString & "'")
        For Each objDR_Item In objDRs_Item
            objSemWork_Documents.add_RelationType(objDR_Item.Item("GUID_Ref"))
        Next

        objDRs_Item = procT_ManagedDocuments.Select("GUID_ItemType='" & objLocalConfig.Globals.ObjectReferenceType_Type.GUID.ToString & "'")
        For Each objDR_Item In objDRs_Item
            objSemWork_Documents.add_Type(objDR_Item.Item("GUID_Ref"), True)
        Next

        objDRs_Item = procT_ManagedDocuments.Select("GUID_ItemType='" & objLocalConfig.Globals.ObjectReferenceType_Token.GUID.ToString & "'")
        For Each objDR_Item In objDRs_Item
            objSemWork_Documents.add_Token(objDR_Item.Item("GUID_Ref"))
        Next

        For Each objDR_Item In objSemWork_Documents.semtblT_Token.Rows
            objSemWork_Documents.add_Type(objDR_Item.Item("GUID_Type"), True)
        Next
        intCountDS = 0
        objDRs_Item = objSemWork_Documents.semtblT_Type.Select("GUID_Type_Parent IS NULL")
        For Each objDR_Item In objDRs_Item
            objDRs_Docs = procT_ManagedDocuments.Select("GUID_Ref='" & objDR_Item.Item("GUID_Type").ToString & "'")
            objTreeNode_Sub = objTreeNode_Documents.Nodes.Add(objDR_Item.Item("GUID_Type").ToString, objDR_Item.Item("Name_Type"), cint_ImageID_Close, cint_ImageID_Open)

            If objDRs_Docs.Count > 0 Then
                objTreeNode_Sub.ImageIndex = cint_ImageID_Close_Images
                objTreeNode_Sub.SelectedImageIndex = cint_ImageID_Open_Images
                intCountDS = intCountDS + 1
            End If

            'objDRs_Childs = objSemWork_Documents.semtblT_Token.Select("GUID_Type='" & objDR_Item.Item("GUID_Type").ToString & "'")
            'For Each objDR_Child In objDRs_Childs
            'objTreeNode_SubSub = objTreeNode_Sub.Nodes.Add(objDR_Child.Item("GUID_Token").ToString, objDR_Child.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)
            'intCountDS = intCountDS + 1
            'Next

            get_SubTypes_Docs(objTreeNode_Sub)

        Next



        For Each objDR_Item In objSemWork_Documents.semtblT_Attribute.Rows
            objTreeNode_Attributes.Nodes.Add(objDR_Item.Item("GUID_Attribute").ToString, objDR_Item.Item("Name_Attribute"), cint_ImageID_Attribute, cint_ImageID_Attribute)
        Next

        For Each objDR_Item In objSemWork_Documents.semtblT_RelationType.Rows
            objTreeNode_RelationTypes.Nodes.Add(objDR_Item.Item("GUID_RelationType").ToString, objDR_Item.Item("Name_RelationType"), cint_ImageID_RelationType, cint_ImageID_RelationType)
        Next


        procA_ContentItems.Fill(procT_ContentItems, _
                                objLocalConfig.SemItem_Type_ContentObject.GUID, _
                                objLocalConfig.SemItem_Type_ContentType.GUID, _
                                objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID)

        objDRs_Item = procT_ContentItems.Select("GUID_ItemType='" & objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString & "'")
        For Each objDR_Item In objDRs_Item
            objSemWork_ContentItems.add_Attribute(objDR_Item.Item("GUID_Ref"))
        Next

        objDRs_Item = procT_ContentItems.Select("GUID_ItemType='" & objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString & "'")
        For Each objDR_Item In objDRs_Item
            objSemWork_ContentItems.add_RelationType(objDR_Item.Item("GUID_Ref"))
        Next

        objDRs_Item = procT_ContentItems.Select("GUID_ItemType='" & objLocalConfig.Globals.ObjectReferenceType_Type.GUID.ToString & "'")
        For Each objDR_Item In objDRs_Item
            objSemWork_ContentItems.add_Type(objDR_Item.Item("GUID_Ref"), True)
        Next

        objDRs_Item = procT_ContentItems.Select("GUID_ItemType='" & objLocalConfig.Globals.ObjectReferenceType_Token.GUID.ToString & "'")
        For Each objDR_Item In objDRs_Item
            objSemWork_ContentItems.add_Token(objDR_Item.Item("GUID_Ref"))
        Next

        For Each objDR_Item In objSemWork_ContentItems.semtblT_Token.Rows
            objSemWork_ContentItems.add_Type(objDR_Item.Item("GUID_Type"), True)
        Next

        objDRs_Item = objSemWork_ContentItems.semtblT_Type.Select("GUID_Type_Parent IS NULL")
        For Each objDR_Item In objDRs_Item
            objDRs_Docs = procT_ContentItems.Select("GUID_Ref='" & objDR_Item.Item("GUID_Type").ToString & "'")
            objTreeNode_Sub = objTreeNode_ContentItems.Nodes.Add(objDR_Item.Item("GUID_Type").ToString, objDR_Item.Item("Name_Type"), cint_ImageID_Close, cint_ImageID_Open)

            If objDRs_Docs.Count > 0 Then
                objTreeNode_Sub.ImageIndex = cint_ImageID_Close_Images
                objTreeNode_Sub.SelectedImageIndex = cint_ImageID_Open_Images
                intCountDS = intCountDS + 1
            End If

            'objDRs_Childs = objSemWork_Documents.semtblT_Token.Select("GUID_Type='" & objDR_Item.Item("GUID_Type").ToString & "'")
            'For Each objDR_Child In objDRs_Childs
            'objTreeNode_SubSub = objTreeNode_Sub.Nodes.Add(objDR_Child.Item("GUID_Token").ToString, objDR_Child.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)
            'intCountDS = intCountDS + 1
            'Next

            get_SubTypes_ContentItems(objTreeNode_Sub)

        Next

        get_Token_Documents()
        ToolStripLabel_ItemCount.Text = intCountDS

        boolPChange_Tree = False
    End Sub

    Private Sub get_Token_Documents(Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objDRs_Childs() As DataRow
        Dim objDR_Child As DataRow
        Dim objTreeNode_Sub As TreeNode

        If objTreeNode Is Nothing Then
            For Each objTreeNode_Sub In objTreeNode_Documents.Nodes
                If objTreeNode_Sub.ImageIndex = cint_ImageID_Close Or _
                    objTreeNode_Sub.ImageIndex = cint_ImageID_Close_Images Or _
                    objTreeNode_Sub.ImageIndex = cint_ImageID_Close_Images_SubItems Or _
                    objTreeNode_Sub.ImageIndex = cint_ImageID_Close_SubItems Then

                    objDRs_Childs = objSemWork_Documents.semtblT_Token.Select("GUID_Type='" & objTreeNode_Sub.Name & "'", "Name_Token")
                    For Each objDR_Child In objDRs_Childs
                        objTreeNode_Sub.Nodes.Add(objDR_Child.Item("GUID_Token").ToString, objDR_Child.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)
                        intCountDS = intCountDS + 1
                    Next
                    get_Token_Documents(objTreeNode_Sub)
                End If
            Next
        Else
            For Each objTreeNode_Sub In objTreeNode.Nodes
                If objTreeNode_Sub.ImageIndex = cint_ImageID_Close Or _
                    objTreeNode_Sub.ImageIndex = cint_ImageID_Close_Images Or _
                    objTreeNode_Sub.ImageIndex = cint_ImageID_Close_Images_SubItems Or _
                    objTreeNode_Sub.ImageIndex = cint_ImageID_Close_SubItems Then

                    objDRs_Childs = objSemWork_Documents.semtblT_Token.Select("GUID_Type='" & objTreeNode_Sub.Name & "'")
                    For Each objDR_Child In objDRs_Childs
                        objTreeNode_Sub.Nodes.Add(objDR_Child.Item("GUID_Token").ToString, objDR_Child.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)
                        intCountDS = intCountDS + 1
                    Next
                    get_Token_Documents(objTreeNode_Sub)
                End If

            Next
        End If
    End Sub

    Private Sub get_SubTypes_ContentItems(ByVal objTreeNode_Parent As TreeNode)
        Dim objDRs_Type() As DataRow
        Dim objDR_Type As DataRow
        Dim objDRs_Docs() As DataRow
        Dim objDRs_Childs() As DataRow
        Dim objDR_Child As DataRow
        Dim objTreeNode_Sub As TreeNode
        Dim objTreeNode_SubSub As TreeNode

        objDRs_Type = objSemWork_ContentItems.semtblT_Type.Select("GUID_Type_Parent='" & objTreeNode_Parent.Name & "'")
        For Each objDR_Type In objDRs_Type
            objDRs_Docs = procT_ContentItems.Select("GUID_Ref='" & objDR_Type.Item("GUID_Type").ToString & "'")
            objTreeNode_Sub = objTreeNode_Parent.Nodes.Add(objDR_Type.Item("GUID_Type").ToString, objDR_Type.Item("Name_Type"), cint_ImageID_Close, cint_ImageID_Open)

            'objDRs_Childs = objSemWork_ContentItems.semtblT_Token.Select("GUID_Type='" & objDR_Type.Item("GUID_Type").ToString & "'")
            'For Each objDR_Child In objDRs_Childs
            'objTreeNode_SubSub = objTreeNode_Sub.Nodes.Add(objDR_Child.Item("GUID_Token").ToString, objDR_Child.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)
            'intCountDS = intCountDS + 1
            'Next
            get_SubTypes_ContentItems(objTreeNode_Sub)
        Next
    End Sub

    Private Sub get_SubTypes_Docs(ByVal objTreeNode_Parent As TreeNode)
        Dim objDRs_Type() As DataRow
        Dim objDR_Type As DataRow
        Dim objDRs_Docs() As DataRow
        Dim objDRs_Childs() As DataRow
        Dim objDR_Child As DataRow
        Dim objTreeNode_Sub As TreeNode
        Dim objTreeNode_SubSub As TreeNode

        objDRs_Type = objSemWork_Documents.semtblT_Type.Select("GUID_Type_Parent='" & objTreeNode_Parent.Name & "'")
        For Each objDR_Type In objDRs_Type
            objDRs_Docs = procT_ManagedDocuments.Select("GUID_Ref='" & objDR_Type.Item("GUID_Type").ToString & "'")
            objTreeNode_Sub = objTreeNode_Parent.Nodes.Add(objDR_Type.Item("GUID_Type").ToString, objDR_Type.Item("Name_Type"), cint_ImageID_Close, cint_ImageID_Open)

            'objDRs_Childs = objSemWork_Documents.semtblT_Token.Select("GUID_Type='" & objDR_Type.Item("GUID_Type").ToString & "'")
            'For Each objDR_Child In objDRs_Childs
            'objTreeNode_SubSub = objTreeNode_Sub.Nodes.Add(objDR_Child.Item("GUID_Token").ToString, objDR_Child.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)
            'intCountDS = intCountDS + 1
            'Next
            get_SubTypes_Docs(objTreeNode_Sub)
        Next
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        initialize()
        'objDocumentation = New clsDocumentation(objLocalConfig)
        test_menue()
    End Sub

    Private Sub test_Documentation()
        Dim objSemItem_SoftDev As New clsSemItem
        Dim objSemItem_Document As clsSemItem

        objSemItem_SoftDev.GUID = New Guid("be7f91ef-9786-4b36-b8a9-c952586c3138")
        objSemItem_SoftDev.Name = "clsDataPos"
        objSemItem_SoftDev.GUID_Parent = New Guid("71415eeb-ce46-4b2c-b0a2-f72116b55438")
        objSemItem_SoftDev.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objSemItem_Document = objDocumentation.open_Document(objSemItem_SoftDev)

    End Sub

    Private Sub test_menue()
        Dim objSemItems_SoftDev(0) As clsSemItem
        Dim objFrmMenu As frmMenu

        objSemItems_SoftDev(0) = New clsSemItem
        objSemItems_SoftDev(0).GUID = New Guid("d599cac4-dce6-47de-98f4-ac5315d6ada9")
        objSemItems_SoftDev(0).Name = "Test"
        objSemItems_SoftDev(0).GUID_Parent = New Guid("5a52329c-bf4e-4995-a17d-810c03d917ac")
        objSemItems_SoftDev(0).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrmMenu = New frmMenu(objSemItems_SoftDev)
        objFrmMenu.ShowDialog(Me)

    End Sub

    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Close()
    End Sub

    Private Sub TreeView_Items_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Items.AfterSelect
        Dim objTreeNode As TreeNode
        Dim objSemItem_Selected As clsSemItem = Nothing
        If boolPChange_Tree = False Then
            objTreeNode = TreeView_Items.SelectedNode
            If Not objTreeNode Is Nothing Then
                If Not objTreeNode.ImageIndex = cint_ImageID_Root And _
                    Not objTreeNode.ImageIndex = cint_ImageID_Attributes And _
                    Not objTreeNode.ImageIndex = cint_ImageID_RelationTypes Then

                    objSemItem_Selected = New clsSemItem
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text

                    Select Case objTreeNode.ImageIndex
                        Case cint_ImageID_Attribute
                            objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                        Case cint_ImageID_Close
                            objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                        Case cint_ImageID_RelationType
                            objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                        Case cint_ImageID_Token
                            objSemItem_Selected.GUID_Parent = New Guid(objTreeNode.Parent.Name)
                            objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    End Select

                End If
            End If

        End If

        objUserControl_Bookmarks.initialize(objSemItem_Selected)
        objUserControl_Documents.initialize(objSemItem_Selected)
    End Sub

    Private Sub ContextMenuStrip_Tree_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Tree.Opening
        Dim objTreeNode As TreeNode

        NewToolStripMenuItem.Enabled = False
        objTreeNode = TreeView_Items.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Attributes
                    NewToolStripMenuItem.Enabled = True
                Case cint_ImageID_Close, cint_ImageID_Close_Images, cint_ImageID_Close_Images_SubItems, cint_ImageID_Close_SubItems
                    NewToolStripMenuItem.Enabled = True
                Case cint_ImageID_RelationType
                    NewToolStripMenuItem.Enabled = True
                Case cint_ImageID_Root
                    NewToolStripMenuItem.Enabled = True
            End Select

        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        Dim objSemItem_Selected As New clsSemItem
        Dim objDRC_Type As DataRowCollection
        Dim objDRs_Type() As DataRow
        Dim objDR_Type As DataRow
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objTreeNodes() As TreeNode
        Dim objSemWork As New clsSemWork(objLocalConfig.Globals)
        Dim intRowCount As Integer

        objTreeNode = TreeView_Items.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Root
                    If objTreeNode.Name = objTreeNode_Documents.Name Then
                        objFrmSemManager = New frmSemManager(objSemItem_Selected, objLocalConfig.Globals)
                        objFrmSemManager.Applyabale = True
                        objFrmSemManager.ShowDialog(Me)
                        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                                    objSemItem_Selected = New clsSemItem
                                    objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_Token")
                                    objSemItem_Selected.Name = objDRV_Selected.Item("Name_Token")
                                    objSemItem_Selected.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    objSemWork.add_Type(objSemItem_Selected.GUID_Parent, True)


                                    objDRs_Type = objSemWork.semtblT_Type.Select("GUID_Type_Parent IS NULL")

                                    objTreeNodes = TreeView_Items.Nodes.Find(objDRs_Type(0).Item("GUID_Type").ToString, True)

                                    If objTreeNodes.Count > 0 Then
                                        objTreeNode = objTreeNodes(0)
                                    Else
                                        objTreeNode = objTreeNode_Documents.Nodes.Add(objDRs_Type(0).Item("GUID_Type").ToString, _
                                                                                    objDRs_Type(0).Item("Name_Type"), _
                                                                                    cint_ImageID_Close, cint_ImageID_Open)
                                    End If

                                    objDRs_Type = objSemWork.semtblT_Type.Select("GUID_Type_Parent='" & objTreeNode.Name & "'")
                                    Do


                                        If objDRs_Type.Count > 0 Then
                                            objTreeNodes = objTreeNode.Nodes.Find(objDRs_Type(0).Item("GUID_Type").ToString, False)
                                            If objTreeNodes.Count > 0 Then
                                                objTreeNode = objTreeNodes(0)
                                            Else
                                                objTreeNode = objTreeNode.Nodes.Add(objDRs_Type(0).Item("GUID_Type").ToString, _
                                                                                    objDRs_Type(0).Item("Name_Type"), _
                                                                                    cint_ImageID_Close, cint_ImageID_Open)
                                            End If

                                            objDRs_Type = objSemWork.semtblT_Type.Select("GUID_Type_Parent='" & objTreeNode.Name & "'")
                                        End If

                                    Loop Until objDRs_Type.Count = 0

                                    If objTreeNode.Name = objSemItem_Selected.GUID_Parent.ToString Then
                                        objTreeNodes = objTreeNode.Nodes.Find(objSemItem_Selected.GUID.ToString, False)
                                        If objTreeNodes.Count = 0 Then
                                            objTreeNode = objTreeNode.Nodes.Add(objSemItem_Selected.GUID.ToString, _
                                                              objSemItem_Selected.Name, _
                                                              cint_ImageID_Token, cint_ImageID_Token)
                                        Else
                                            objTreeNode = objTreeNodes(0)
                                        End If

                                        TreeView_Items.SelectedNode = objTreeNode
                                    Else
                                        MsgBox("Leider konnte das Element nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                                    End If

                                Else
                                    MsgBox("Bitte nur ein Token auswählen!", MsgBoxStyle.Information)
                                End If
                            Else
                                MsgBox("Bitte nur Token auswählen!", MsgBoxStyle.Information)
                            End If
                        End If
                    End If
                    

                Case cint_ImageID_Attribute
                Case cint_ImageID_Close, cint_ImageID_Close_Images, cint_ImageID_Close_Images_SubItems, cint_ImageID_Close_SubItems
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                    objFrmSemManager = New frmSemManager(objSemItem_Selected, objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)

                    If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                        If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                            If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                                objDRV_Selected = objDGVR_Selected.DataBoundItem
                                If objDRV_Selected.Item("GUID_Type") = objSemItem_Selected.GUID Then
                                    objTreeNodes = objTreeNode.Nodes.Find(objDRV_Selected.Item("GUID_Token").ToString, False)
                                    If objTreeNodes.Count = 0 Then
                                        objTreeNode.Nodes.Add(objDRV_Selected.Item("GUID_Token").ToString, objDRV_Selected.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)
                                    End If


                                Else
                                    MsgBox("Bitte nur ein Token vom Typ " & objSemItem_Selected.Name & " auswählen!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Bitte nur ein Item auswählen!", MsgBoxStyle.Exclamation)
                            End If

                        Else
                            MsgBox("Bitte ein Token vom Type " & objSemItem_Selected.Name & " auswählen!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Case cint_ImageID_RelationType

            End Select
        End If
    End Sub
End Class
