Public Class UserControl_SearchResult
    Private strSearch As String
    Private objGlobals As clsGlobals

    Private objThread_Attribute As Threading.Thread
    Private objThread_RelationType As Threading.Thread
    Private objThread_Token As Threading.Thread
    Private objThread_Type As Threading.Thread

    Private objDRC_Attribute As DataRowCollection
    Private objDRC_RelationType As DataRowCollection

    Private DataTable_Token As New ds_SemItems.DataTable_SemItemDataTable
    Private DataTable_SemItems_Show As New ds_SemItems.DataTable_SemItemDataTable
    Private objDRC_Type As DataRowCollection

    Private intAttribs_Done As Integer
    Private intRelationTypes_Done As Integer
    Private intToken_Done As Integer
    Private intTypes_Done As Integer

    Private boolFinished_Attributes As Boolean
    Private boolFinished_RelationTypes As Boolean
    Private boolFinished_Token As Boolean
    Private boolFinished_Types As Boolean

    Public Event selected_Item(ByVal SemItem_Selected As clsSemItem)

    Public Sub New(ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objGlobals = Globals
    End Sub

    Public Sub find_Item(ByVal Search As String)
        Dim i As Integer
        strSearch = Search

        Timer_Threads.Stop()
        BindingSource_SearchResult.DataSource = DataTable_SemItems_Show
        DataGridView_Items.DataSource = BindingSource_SearchResult
        For i = 0 To 21
            If Not i = 1 And Not i = 3 And Not i = 5 Then
                DataGridView_Items.Columns(i).Visible = False
            End If

        Next
        start_Threads()
        Timer_Threads.Start()

    End Sub

    Public Sub start_Threads()

        abort_Threads()

        DataTable_SemItems_Show.Clear()

        intAttribs_Done = 0
        intRelationTypes_Done = 0
        intToken_Done = 0
        intTypes_Done = 0

        boolFinished_Attributes = False
        boolFinished_RelationTypes = False
        boolFinished_Token = False
        boolFinished_Types = False

        objThread_Attribute = New Threading.Thread(AddressOf find_Attribute)
        objThread_RelationType = New Threading.Thread(AddressOf find_RelationType)
        objThread_Token = New Threading.Thread(AddressOf find_Token)
        objThread_Type = New Threading.Thread(AddressOf find_Type)

        objThread_Attribute.Start()
        objThread_RelationType.Start()
        objThread_Token.Start()
        objThread_Type.Start()
    End Sub

    Public Sub suspend_Threads()
        Try
            objThread_Attribute.Suspend()
        Catch ex As Exception

        End Try
        Try
            objThread_RelationType.Suspend()
        Catch ex As Exception

        End Try
        Try
            objThread_Token.Suspend()
        Catch ex As Exception

        End Try
        Try
            objThread_Type.Suspend()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub resume_Threads()
        Try
            objThread_Attribute.Resume()
        Catch ex As Exception

        End Try
        Try
            objThread_RelationType.Resume()
        Catch ex As Exception

        End Try
        Try
            objThread_Token.Resume()
        Catch ex As Exception

        End Try
        Try
            objThread_Type.Resume()
        Catch ex As Exception

        End Try
    End Sub


    Public Sub abort_Threads()
        Try
            objThread_Attribute.Abort()
        Catch ex As Exception

        End Try
        Try
            objThread_RelationType.Abort()
        Catch ex As Exception

        End Try
        Try
            objThread_Token.Abort()
        Catch ex As Exception

        End Try
        Try
            objThread_Type.Abort()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub find_Attribute()
        Dim semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter

        semtblA_Attribute.Connection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        objDRC_Attribute = semtblA_Attribute.GetData_Like_Name(strSearch).Rows
        boolFinished_Attributes = True

    End Sub

    Private Sub find_RelationType()
        Dim semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter

        semtblA_RelationType.Connection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        objDRC_RelationType = semtblA_RelationType.GetData_Like_Name(strSearch).Rows
        boolFinished_RelationTypes = True

    End Sub

    Private Sub find_Token()
        Dim semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
        Dim semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
        Dim objDRC_Token As DataRowCollection
        Dim objDR_Token As DataRow
        Dim objDRC_Type As DataRowCollection

        DataTable_Token.Clear()
        semtblA_Token.Connection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        semtblA_Type.Connection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        objDRC_Token = semtblA_Token.GetData_Like_Name(strSearch).Rows
        For Each objDR_Token In objDRC_Token
            objDRC_Type = semtblA_Type.GetData_By_GUID(objDR_Token.Item("GUID_Type")).Rows
            DataTable_Token.Rows.Add(objDR_Token.Item("GUID_Token"), _
                                       objDR_Token.Item("Name_Token"), _
                                       objDR_Token.Item("GUID_Type"), _
                                       objDRC_Type(0).Item("Name_Type"))

        Next
        boolFinished_Token = True

    End Sub

    Private Sub find_Type()
        Dim  semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
        semtblA_Type.Connection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        objDRC_Type = semtblA_Type.GetData_Like_Name(strSearch).Rows
        boolFinished_Types = True

    End Sub

    Private Sub Timer_Threads_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Threads.Tick
        Dim dateNow As Date
        Dim boolStop As Boolean = True
        Dim objDR_Item As DataRow
        Dim intCount As Integer = 0
        dateNow = Now
        If (Now - dateNow).Milliseconds < 250 Then
            If boolFinished_Attributes = True Then
                If intAttribs_Done < objDRC_Attribute.Count Then
                    objDR_Item = objDRC_Attribute(intAttribs_Done)
                    DataTable_SemItems_Show.Rows.Add(objDR_Item.Item("GUID_Attribute"), _
                                                     objDR_Item.Item("Name_Attribute"), _
                                                     objDR_Item.Item("GUID_AttributeType"),
                                                     Nothing,
                                                     objGlobals.ObjectReferenceType_Attribute.GUID, _
                                                     objGlobals.ObjectReferenceType_OR_Attribute.Name)
                    intAttribs_Done = intAttribs_Done + 1
                    boolStop = False
                    intCount = intCount + 1
                End If
            End If
            If boolFinished_RelationTypes = True Then
                If intRelationTypes_Done < objDRC_RelationType.Count Then
                    objDR_Item = objDRC_RelationType(intRelationTypes_Done)
                    DataTable_SemItems_Show.Rows.Add(objDR_Item.Item("GUID_RelationType"), _
                                                     objDR_Item.Item("Name_RelationType"), _
                                                     Nothing, _
                                                     Nothing, _
                                                     objGlobals.ObjectReferenceType_RelationType.GUID, _
                                                     objGlobals.ObjectReferenceType_RelationType.Name)
                    intRelationTypes_Done = intRelationTypes_Done + 1
                    boolStop = False
                    intCount = intCount + 1
                End If
            End If
            If boolFinished_Token = True Then
                If intToken_Done < DataTable_Token.Rows.Count Then
                    objDR_Item = DataTable_Token.Rows(intToken_Done)
                    DataTable_SemItems_Show.Rows.Add(objDR_Item.Item("GUID"), _
                                                     objDR_Item.Item("Name"), _
                                                     objDR_Item.Item("GUID_Parent"), _
                                                     objDR_Item.Item("Name_Parent"), _
                                                     objGlobals.ObjectReferenceType_Token.GUID, _
                                                     objGlobals.ObjectReferenceType_Token.Name)
                    intToken_Done = intToken_Done + 1
                    boolStop = False
                    intCount = intCount + 1
                End If
            End If
            If boolFinished_Types = True Then
                If intTypes_Done < objDRC_Type.Count Then
                    objDR_Item = objDRC_Type(intTypes_Done)
                    DataTable_SemItems_Show.Rows.Add(objDR_Item.Item("GUID_Type"), _
                                                     objDR_Item.Item("Name_Type"), _
                                                     objDR_Item.Item("GUID_Type_Parent"),
                                                     Nothing, _
                                                     objGlobals.ObjectReferenceType_Type.GUID, _
                                                     objGlobals.ObjectReferenceType_Type.Name)

                    intTypes_Done = intTypes_Done + 1
                    boolStop = False
                    intCount = intCount + 1
                End If

            End If

            If boolStop = True Then
                ToolStripProgressBar_Read.Visible = False
                ToolStripProgressBar_Read.Value = 0
                Timer_Threads.Stop()
            Else
                ToolStripProgressBar_Read.Visible = True
                ToolStripProgressBar_Read.Value = intCount

            End If
        End If
        
    End Sub

    Private Sub DataGridView_Items_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Items.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Selected As New clsSemItem

        objDGVR_Selected = DataGridView_Items.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem
        objSemItem_Selected.GUID = objDRV_Selected.Item("GUID")
        objSemItem_Selected.Name = objDRV_Selected.Item("Name")
        objSemItem_Selected.GUID_Parent = objDRV_Selected.Item("GUID_Parent")
        objSemItem_Selected.GUID_Type = objDRV_Selected.Item("GUID_Type")

        RaiseEvent selected_Item(objSemItem_Selected)
    End Sub

   
    Private Sub ContextMenuStrip_SearchResults_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_SearchResults.Opening
        CopyGUIDToolStripMenuItem.Enabled = False
        CopyNameToolStripMenuItem.Enabled = False

        If DataGridView_Items.SelectedRows.Count = 1 Then
            CopyGUIDToolStripMenuItem.Enabled = True
            CopyNameToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub CopyGUIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyGUIDToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        objDGVR_Selected = DataGridView_Items.SelectedRows(0)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        Clipboard.SetDataObject(objDRV_Selected.Item("GUID").ToString)

    End Sub

    Private Sub CopyNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyNameToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        objDGVR_Selected = DataGridView_Items.SelectedRows(0)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        Clipboard.SetDataObject(objDRV_Selected.Item("Name").ToString)
    End Sub
End Class
