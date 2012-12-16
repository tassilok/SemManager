Imports Sem_Manager
Imports Filesystem_Management
Public Class UserControl_Documents

    Private procA_ManagedDocumentData As New ds_OfficeModuleTableAdapters.proc_ManagedDocumentDataTableAdapter
    Private procT_ManagedDocumentData As New ds_OfficeModule.proc_ManagedDocumentDataDataTable

    Private semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter

    Private objSemItem_Ref As clsSemItem

    Private objLocalConfig As clsLocalConfig
    Private objDocumentation As clsDocumentation

    Public Sub initialize(ByVal SemItem_Ref As clsSemItem)
        Dim intCountDS As Integer


        objLocalConfig = New clsLocalConfig(New clsGlobals)
        set_DBConnection()
        procT_ManagedDocumentData.Clear()


        objSemItem_Ref = SemItem_Ref

        If Not objSemItem_Ref Is Nothing Then
            Button_Open.Enabled = True

            procA_ManagedDocumentData.Fill(procT_ManagedDocumentData, _
                                           objLocalConfig.SemItem_Attribute_DateTimeStamp__Change_.GUID, _
                                           objLocalConfig.SemItem_Type_Managed_Document.GUID, _
                                           objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                           objSemItem_Ref.GUID)


        End If
        intCountDS = procT_ManagedDocumentData.Rows.Count
        BindingSource_Items.DataSource = procT_ManagedDocumentData
        DataGridView_Items.DataSource = BindingSource_Items
        DataGridView_Items.Columns(0).Visible = False
        DataGridView_Items.Columns(3).Visible = False

    End Sub

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

    Private Sub set_DBConnection()
        objDocumentation = New clsDocumentation(objLocalConfig)
        objDocumentation.Visible = True

        semtblA_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_RelationType.Connection = objLocalConfig.Connection_DB
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB

        procA_ManagedDocumentData.Connection = objLocalConfig.Connection_Plugin
        procA_ManagedDocumentData.ClearBeforeFill = False

    End Sub

    Private Sub DataGridView_Items_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Items.SelectionChanged
        Button_Open.Enabled = False
        If DataGridView_Items.SelectedRows.Count = 1 Then
            Button_Open.Enabled = True
        ElseIf Not objSemItem_Ref Is Nothing Then
            Button_Open.Enabled = True
        End If
    End Sub

    Private Sub Button_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Open.Click
        Dim objSemItem_Ref As New clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_Item As DataRowCollection = Nothing

        If DataGridView_Items.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Items.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
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
                    objSemItem_Ref = Me.objSemItem_Ref
            End Select

        Else
            objSemItem_Ref = Me.objSemItem_Ref
        End If

        If Not objSemItem_Ref Is Nothing Then
            objDocumentation.open_Document(objSemItem_Ref)
        End If
    End Sub

    Private Sub Button_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Delete.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        For Each objDGVR_Selected In DataGridView_Items.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem


        Next
    End Sub
End Class
