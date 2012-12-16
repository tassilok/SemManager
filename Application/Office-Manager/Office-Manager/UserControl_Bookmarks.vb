Imports Sem_Manager
Imports Filesystem_Management
Public Class UserControl_Bookmarks

    Private pA_BookMarkList_Of_Item As New ds_OfficeModuleTableAdapters.p_BookMarkList_Of_ItemTableAdapter
    Private pT_BookMarkList_Of_Item As New ds_OfficeModule.p_BookMarkList_Of_ItemDataTable

    Private semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter

    Private objSemItem_Ref As clsSemItem

    Private objLocalConfig As clsLocalConfig

    Private objDocumentation As clsDocumentation

    Private objFRM_TokenEdit As frmTokenEdit

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
    End Sub

    Public Sub initialize(ByVal SemItem_Ref As clsSemItem)

        Button_CreateBookmark.Enabled = False
        Button_OpenBookmark.Enabled = False
        Button_DeleteBookmark.Enabled = False
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        set_DBConnection()

        pT_BookMarkList_Of_Item.Clear()

        objSemItem_Ref = SemItem_Ref

        If Not objSemItem_Ref Is Nothing Then

            pA_BookMarkList_Of_Item.Fill(pT_BookMarkList_Of_Item, _
                                         objLocalConfig.SemItem_Type_ContentObject.GUID, _
                                         objLocalConfig.SemItem_Type_ContentType.GUID, _
                                         objLocalConfig.SemItem_Type_Managed_Document.GUID, _
                                         objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                         objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID, _
                                         objLocalConfig.SemItem_RelationType_belonging_Document.GUID, _
                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                         objLocalConfig.SemItem_Token_ContentType_Bookmark.GUID, _
                                         objSemItem_Ref.GUID, _
                                         objLocalConfig.Globals.ObjectReferenceType_Token.GUID)
            Button_CreateBookmark.Enabled = True
        Else
            pT_BookMarkList_Of_Item.Clear()
        End If

        BindingSource_Bookmarks.DataSource = pT_BookMarkList_Of_Item
        DataGridView_Bookmark.DataSource = BindingSource_Bookmarks
        DataGridView_Bookmark.Columns(0).Visible = False
        DataGridView_Bookmark.Columns(1).Visible = False
        DataGridView_Bookmark.Columns(2).Visible = False
        DataGridView_Bookmark.Columns(3).Visible = False
        DataGridView_Bookmark.Columns(5).Visible = False
        DataGridView_Bookmark.Columns(6).Visible = False
        DataGridView_Bookmark.Columns(7).Visible = False
        DataGridView_Bookmark.Columns(9).Visible = False

    End Sub

    Private Sub set_DBConnection()
        objDocumentation = New clsDocumentation(objLocalConfig)
        objDocumentation.Visible = True

        semtblA_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_RelationType.Connection = objLocalConfig.Connection_DB
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB
 
        pA_BookMarkList_Of_Item.Connection = objLocalConfig.Connection_Plugin
    End Sub

    Private Sub DataGridView_Bookmark_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Bookmark.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_ContentObject As New clsSemItem
        objDGVR_Selected = DataGridView_Bookmark.Rows(e.RowIndex)

        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_ContentObject.GUID = objDRV_Selected.Item("GUID_ContentObject")
        objSemItem_ContentObject.Name = objDRV_Selected.Item("Name_ContentObject")
        objSemItem_ContentObject.GUID_Parent = objLocalConfig.SemItem_Type_ContentObject.GUID
        objSemItem_ContentObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFRM_TokenEdit = New frmTokenEdit(objSemItem_ContentObject, _
                                           objLocalConfig.Globals)
        objFRM_TokenEdit.ShowDialog(Me)
    End Sub

    Private Sub Button_CreateBookmark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CreateBookmark.Click
        Dim objSemItem_Result As clsSemItem
        If Not objSemItem_Ref Is Nothing Then
            objSemItem_Result = objDocumentation.insert_BookMark(objSemItem_Ref)

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                MsgBox("Bookmark wurde eingefügt!", MsgBoxStyle.Information)
            Else
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then
                    MsgBox("Im Dokument existiert bereits ein Bookmark zu diesem Sem-Item!", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Der Bookmark konnte nicht eingefügt werden.", MsgBoxStyle.Exclamation)
                End If

            End If
        End If
    End Sub

    Private Sub Button_OpenBookmark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_OpenBookmark.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Ref As New clsSemItem
        Dim objSemItem_Bookmark As New clsSemItem
        Dim objSemItem_Document As clsSemItem
        Dim objDRC_Item As DataRowCollection

        If DataGridView_Bookmark.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Bookmark.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Bookmark.GUID = objDRV_Selected.Item("GUID_ContentObject")
            objSemItem_Bookmark.Name = objDRV_Selected.Item("Name_ContentObject")
            objSemItem_Bookmark.GUID_Parent = objLocalConfig.SemItem_Type_ContentObject.GUID
            objSemItem_Bookmark.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Ref.GUID = objDRV_Selected.Item("GUID_Ref")
            Select Case objDRV_Selected.Item("GUID_ItemType")
                Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                    objDRC_Item = semtblA_Attribute.GetData_By_GUID(objSemItem_Ref.GUID).Rows
                    If objDRC_Item.Count > 0 Then
                        objSemItem_Ref.Name = objDRC_Item(0).Item("Name_Attribute")
                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                    Else
                        objSemItem_Ref = Nothing
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                    objDRC_Item = semtblA_RelationType.GetData_By_GUID(objSemItem_Ref.GUID).Rows
                    If objDRC_Item.Count > 0 Then
                        objSemItem_Ref.Name = objDRC_Item(0).Item("Name_RelationType")
                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                    Else
                        objSemItem_Ref = Nothing
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objDRC_Item = semtblA_Token.GetData_Token_By_GUID(objSemItem_Ref.GUID).Rows
                    If objDRC_Item.Count > 0 Then
                        objSemItem_Ref.Name = objDRC_Item(0).Item("Name_Token")
                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        objSemItem_Ref.GUID_Parent = objDRC_Item(0).Item("GUID_Type")
                    Else
                        objSemItem_Ref = Nothing
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                    objDRC_Item = semtblA_Type.GetData_By_GUID(objSemItem_Ref.GUID).Rows
                    If objDRC_Item.Count > 0 Then
                        objSemItem_Ref.Name = objDRC_Item(0).Item("Name_Type")
                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                    Else
                        objSemItem_Ref = Nothing
                    End If
                Case Else
                    objSemItem_Ref = Nothing
            End Select

            If Not objSemItem_Ref Is Nothing Then
                objSemItem_Document = objDocumentation.open_Document(objSemItem_Ref)
                If Not objSemItem_Document Is Nothing Then
                    objDocumentation.activate_Bookmark(objSemItem_Bookmark, objSemItem_Document)
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView_Bookmark_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Bookmark.SelectionChanged
        Button_OpenBookmark.Enabled = False
        Button_DeleteBookmark.Enabled = False
        If DataGridView_Bookmark.SelectedRows.Count = 1 Then
            Button_OpenBookmark.Enabled = True
            Button_DeleteBookmark.Enabled = True
        End If
    End Sub
End Class
