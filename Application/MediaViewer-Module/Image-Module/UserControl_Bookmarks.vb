Imports Sem_Manager
Public Class UserControl_Bookmarks
    Private cintImageID_Root As Integer = 0
    Private cintImageID_Related As Integer = 1
    Private cintImageID_MediaItem As Integer = 2
    Private cintImageID_Bookmark As Integer = 3

    Private procA_Bookmarks_Of_MediaItem_Of_Ref As New ds_ImageModuleTableAdapters.proc_Bookmarks_Of_MediaItem_Of_RefTableAdapter
    Private procT_Bookmarks_Of_MediaItem_Of_Ref As New ds_ImageModule.proc_Bookmarks_Of_MediaItem_Of_RefDataTable
    Private procA_Bookmarks_Of_MediaItem As New ds_ImageModuleTableAdapters.proc_Bookmarks_Of_MediaItemTableAdapter
    Private procT_Bookmarks_Of_MediaItem As New ds_ImageModule.proc_Bookmarks_Of_MediaItemDataTable

    Private objLocalConfig As clsLocalConfig

    Private objTreeNode_Root As TreeNode

    Private objSemItem_MediaItem As clsSemItem
    Private objSemItem_Ref As clsSemItem
    Private objSemItem_User As clsSemItem

    Public Event activate_Bookmark(ByVal SemItem_Bookmark As clsSemItem)

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        initialize_main()
    End Sub

    Private Sub initialize_main()
        set_DBConnection()

        clear_BookmarkTree()

    End Sub

    Public Sub initialize_MediaItem(ByVal SemItem_MediaItem As clsSemItem, Optional ByVal SemItem_User As clsSemItem = Nothing)
        objSemItem_MediaItem = SemItem_MediaItem
        objSemItem_Ref = Nothing
        objSemItem_User = SemItem_User

        clear_BookmarkTree()

        get_Data_Bookmarks()
        fill_Tree()

    End Sub

    Public Sub initialize_Ref(ByVal SemItem_Ref As clsSemItem, Optional ByVal SemItem_User As clsSemItem = Nothing)
        objSemItem_Ref = SemItem_Ref
        objSemItem_MediaItem = Nothing
        objSemItem_User = SemItem_User

        clear_BookmarkTree()

        get_Data_Bookmarks()
        fill_Tree()
    End Sub

    Public Sub clear_BookmarkTree()
        TreeView_Bookmarks.Nodes.Clear()
        objTreeNode_Root = TreeView_Bookmarks.Nodes.Add(objLocalConfig.SemItem_Type_Media_Item_Bookmark.GUID.ToString, objLocalConfig.SemItem_Type_Media_Item_Bookmark.Name, cintImageID_Root, cintImageID_Root)

    End Sub

    Private Sub get_Data_Bookmarks()
        If objSemItem_MediaItem Is Nothing Then
            procA_Bookmarks_Of_MediaItem_Of_Ref.Fill(procT_Bookmarks_Of_MediaItem_Of_Ref, _
                                                     objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                     objLocalConfig.SemItem_Type_Media_Item_Bookmark.GUID, _
                                                     objLocalConfig.SemItem_Type_Media_Item.GUID, _
                                                     objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                     objLocalConfig.SemItem_type_User.GUID, _
                                                     objLocalConfig.SemItem_RelationType_wasCreatedBy.GUID, _
                                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                     objLocalConfig.SemItem_RelationType_belonging_Done.GUID, _
                                                     objSemItem_Ref.GUID)
            BindingSource_Bookmarks.DataSource = procT_Bookmarks_Of_MediaItem_Of_Ref
            DataGridView_Bookmarks.DataSource = BindingSource_Bookmarks
            DataGridView_Bookmarks.Columns(0).Visible = False
            DataGridView_Bookmarks.Columns(2).Visible = False
            DataGridView_Bookmarks.Columns(3).Visible = False
            DataGridView_Bookmarks.Columns(5).Visible = False
            DataGridView_Bookmarks.Columns(6).Visible = False
            DataGridView_Bookmarks.Columns(8).Visible = False
            DataGridView_Bookmarks.Columns(10).Visible = False
            DataGridView_Bookmarks.Columns(12).Visible = False
            DataGridView_Bookmarks.Columns(13).Visible = False
            DataGridView_Bookmarks.Columns(15).Visible = False
            DataGridView_Bookmarks.Columns(16).Visible = False
            DataGridView_Bookmarks.Columns(17).Visible = False
            DataGridView_Bookmarks.Columns(19).Visible = False
        Else
            procA_Bookmarks_Of_MediaItem.Fill(procT_Bookmarks_Of_MediaItem, _
                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                              objLocalConfig.SemItem_Type_Media_Item_Bookmark.GUID, _
                                              objLocalConfig.SemItem_Type_Media_Item.GUID, _
                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                              objLocalConfig.SemItem_type_User.GUID, _
                                              objLocalConfig.SemItem_RelationType_wasCreatedBy.GUID, _
                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                              objLocalConfig.SemItem_RelationType_belonging_Done.GUID, _
                                              objSemItem_MediaItem.GUID)
            BindingSource_Bookmarks.DataSource = procT_Bookmarks_Of_MediaItem
            DataGridView_Bookmarks.DataSource = BindingSource_Bookmarks

            DataGridView_Bookmarks.Columns(0).Visible = False
            DataGridView_Bookmarks.Columns(2).Visible = False
            DataGridView_Bookmarks.Columns(3).Visible = False
            DataGridView_Bookmarks.Columns(5).Visible = False
            DataGridView_Bookmarks.Columns(6).Visible = False
            DataGridView_Bookmarks.Columns(8).Visible = False
            DataGridView_Bookmarks.Columns(10).Visible = False
            DataGridView_Bookmarks.Columns(12).Visible = False
            DataGridView_Bookmarks.Columns(13).Visible = False
            DataGridView_Bookmarks.Columns(15).Visible = False
        End If
        
        
        If Not objSemItem_User Is Nothing Then
            BindingSource_Bookmarks.Filter = "GUID_User='" & objSemItem_User.GUID.ToString & "'"
        End If

        DataGridView_Bookmarks.DataSource = BindingSource_Bookmarks
        
    End Sub

    Private Sub fill_Tree()
        Dim objTreeNode_Ref As TreeNode
        Dim objTreeNode_MediaItem As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim objDR_Bookmark As DataRowView
        Dim i As Integer

        If objSemItem_MediaItem Is Nothing Then
            objTreeNode_Ref = objTreeNode_Root.Nodes.Add(objSemItem_Ref.GUID.ToString, objSemItem_Ref.Name, cintImageID_Related, cintImageID_Related)
            For i = 0 To BindingSource_Bookmarks.Count - 1
                BindingSource_Bookmarks.Position = i
                objDR_Bookmark = BindingSource_Bookmarks.Current
                objTreeNodes = objTreeNode_Ref.Nodes.Find(objDR_Bookmark.Item("GUID_Media_Item").ToString, False)
                If objTreeNodes.Count = 0 Then
                    objTreeNode_MediaItem = objTreeNode_Ref.Nodes.Add(objDR_Bookmark.Item("GUID_Media_Item").ToString, objDR_Bookmark.Item("Name_Media_Item"), cintImageID_MediaItem, cintImageID_MediaItem)
                Else
                    objTreeNode_MediaItem = objTreeNodes(0)
                End If

                objTreeNode_MediaItem.Nodes.Add(objDR_Bookmark.Item("GUID_Media_Item_Bookmark").ToString, objDR_Bookmark.Item("DateTimeStamp") & " - " & objDR_Bookmark.Item("MediaPosition"), cintImageID_Bookmark, cintImageID_Bookmark)
            Next
            
        Else
            objDR_Bookmark = BindingSource_Bookmarks.Current
            objTreeNode_MediaItem = objTreeNode_Root.Nodes.Add(objSemItem_MediaItem.GUID.ToString, objSemItem_MediaItem.Name, cintImageID_MediaItem, cintImageID_MediaItem)
            For i = 0 To BindingSource_Bookmarks.Count - 1
                objTreeNode_MediaItem.Nodes.Add(objDR_Bookmark.Item("GUID_Media_Item_Bookmark").ToString, objDR_Bookmark.Item("DateTimeStamp") & " - " & objDR_Bookmark.Item("MediaPosition"), cintImageID_Bookmark, cintImageID_Bookmark)
            Next
        End If
    End Sub

    Private Sub set_DBConnection()
        procA_Bookmarks_Of_MediaItem_Of_Ref.Connection = objLocalConfig.Connection_Plugin
        procA_Bookmarks_Of_MediaItem.Connection = objLocalConfig.Connection_Plugin
    End Sub

    Private Sub TreeView_Bookmarks_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_Bookmarks.DoubleClick
        Dim objTreeNode As TreeNode
        Dim objSemItem_Bookmark As New clsSemItem
        Dim objDRs_Bookmark() As DataRow

        objTreeNode = TreeView_Bookmarks.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cintImageID_Bookmark Then
                objSemItem_Bookmark.GUID = New Guid(objTreeNode.Name)
                objSemItem_Bookmark.Name = objTreeNode.Text
                objSemItem_Bookmark.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item_Bookmark.GUID
                objSemItem_Bookmark.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                If objSemItem_MediaItem Is Nothing Then
                    objDRs_Bookmark = procT_Bookmarks_Of_MediaItem_Of_Ref.Select("GUID_Media_Item_Bookmark='" & objSemItem_Bookmark.GUID.ToString & "'")
                    If objDRs_Bookmark.Count > 0 Then
                        objSemItem_Bookmark.Additional1 = objDRs_Bookmark(0).Item("MediaPosition")
                        objSemItem_Bookmark.GUID_Related = objDRs_Bookmark(0).Item("GUID_Media_Item")
                        RaiseEvent activate_Bookmark(objSemItem_Bookmark)
                    Else
                        MsgBox("Der Bookmark konnte nicht gefunden werden!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    objDRs_Bookmark = procT_Bookmarks_Of_MediaItem.Select("GUID_Media_Item_Bookmark='" & objSemItem_Bookmark.GUID.ToString & "'")
                    If objDRs_Bookmark.Count > 0 Then
                        objSemItem_Bookmark.Additional1 = objDRs_Bookmark(0).Item("MediaPosition")
                        objSemItem_Bookmark.GUID_Related = objDRs_Bookmark(0).Item("GUID_Media_Item")
                        RaiseEvent activate_Bookmark(objSemItem_Bookmark)
                    Else
                        MsgBox("Der Bookmark konnte nicht gefunden werden!", MsgBoxStyle.Exclamation)
                    End If
                End If


            End If
        End If
    End Sub

    Private Sub TreeView_Bookmarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView_Bookmarks.KeyDown
        Dim objTreeNode As TreeNode
        Dim objTreenode_Parent As TreeNode
        If e.KeyCode = Keys.F5 Then
            objTreeNode = TreeView_Bookmarks.SelectedNode
            If Not objTreeNode Is Nothing Then
                objTreenode_Parent = objTreeNode.Parent
            Else
                objTreenode_Parent = Nothing
            End If
            clear_BookmarkTree()
            get_Data_Bookmarks()
            fill_Tree()
        End If
    End Sub

    Private Sub DataGridView_Bookmarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView_Bookmarks.KeyDown
        If e.KeyCode = Keys.F5 Then
            clear_BookmarkTree()
            get_Data_Bookmarks()
            fill_Tree()
        End If
        
    End Sub

    Private Sub DataGridView_Bookmarks_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Bookmarks.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Bookmark As New clsSemItem

        objDGVR_Selected = DataGridView_Bookmarks.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Bookmark.GUID = objDRV_Selected.Item("GUID_Media_Item_Bookmark")
        objSemItem_Bookmark.Name = objDRV_Selected.Item("Name_Media_Item_Bookmark")
        objSemItem_Bookmark.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item_Bookmark.GUID
        objSemItem_Bookmark.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        

        If objSemItem_MediaItem Is Nothing Then


            objSemItem_Bookmark.Additional1 = objDRV_Selected.Item("MediaPosition")
            objSemItem_Bookmark.GUID_Related = objDRV_Selected.Item("GUID_Media_Item")
            RaiseEvent activate_Bookmark(objSemItem_Bookmark)
        
        Else
        
            objSemItem_Bookmark.Additional1 = objDRV_Selected.Item("MediaPosition")
            objSemItem_Bookmark.GUID_Related = objDRV_Selected.Item("GUID_Media_Item")
            RaiseEvent activate_Bookmark(objSemItem_Bookmark)
        

        End If
    End Sub
End Class
