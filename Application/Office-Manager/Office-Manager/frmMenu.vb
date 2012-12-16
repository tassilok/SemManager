Imports Sem_Manager
Public Class frmMenu

    Private procA_ManagedDocumentData As New ds_OfficeModuleTableAdapters.proc_ManagedDocumentDataTableAdapter
    Private procT_ManagedDocumentData As New ds_OfficeModule.proc_ManagedDocumentDataDataTable
    

    Private objUserControl_Documents As UserControl_Documents
    Private objUserControl_Bookmarks As UserControl_Bookmarks

    Private objFRM_TokenEdit As frmTokenEdit

    Private objSemItem_Ref As clsSemItem
    Private objDGVSRC_Selected As DataGridViewSelectedRowCollection
    Private objLocalConfig As clsLocalConfig
    Private objSemItems_Work() As clsSemItem

    Private strRowName_GUID As String
    Private strRowName_Name As String
    Private strRowName_Parent As String
    Private objGUID_Type As Guid
    Private boolSemItems As Boolean

    Public Sub New(ByVal DGVSRC_Selected As DataGridViewSelectedRowCollection, ByVal RowName_GUID As String, ByVal RowName_Name As String, ByVal RowName_Parent As String, ByVal GUID_Type As Guid)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Dim objDRV_Selected As DataRowView
        objSemItem_Ref = Nothing
        objDGVSRC_Selected = DGVSRC_Selected
        strRowName_GUID = RowName_GUID
        strRowName_Name = RowName_Name
        strRowName_Parent = RowName_Parent
        objGUID_Type = GUID_Type
        If objDGVSRC_Selected.Count = 1 Then
            objDRV_Selected = objDGVSRC_Selected(0).DataBoundItem
            objSemItem_Ref = New clsSemItem
            objSemItem_Ref.GUID = objDRV_Selected.Item(strRowName_GUID)
            objSemItem_Ref.Name = objDRV_Selected.Item(strRowName_Name)
            objSemItem_Ref.GUID_Parent = objDRV_Selected.Item(strRowName_Parent)
            objSemItem_Ref.GUID_Type = objGUID_Type
        End If

        initialize()
    End Sub

    Public Sub New(ByVal SemItems_Work() As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = Nothing
        objSemItems_Work = SemItems_Work
        If objSemItems_Work.Count = 1 Then
            objSemItem_Ref = New clsSemItem
            objSemItem_Ref.GUID = objSemItems_Work(0).GUID
            objSemItem_Ref.Name = objSemItems_Work(0).Name
            objSemItem_Ref.GUID_Parent = objSemItems_Work(0).GUID_Parent
            objSemItem_Ref.GUID_Type = objSemItems_Work(0).GUID_Type
        End If

        initialize()
    End Sub

    Private Sub initialize()
        
        objUserControl_Documents = New UserControl_Documents(objLocalConfig)
        objUserControl_Documents.Dock = DockStyle.Fill
        TabPage_Document.Controls.Add(objUserControl_Documents)
        objUserControl_Bookmarks = New UserControl_Bookmarks(objLocalConfig)
        objUserControl_Bookmarks.Dock = DockStyle.Fill
        TabPage_Bookmarks.Controls.Add(objUserControl_Bookmarks)
        Configure_TabPages()
    End Sub

    Private Sub Configure_TabPages()
        Select Case TabControl1.SelectedTab.Name
            Case TabPage_Bookmarks.Name
                objUserControl_Bookmarks.initialize(objSemItem_Ref)
            Case TabPage_Document.Name
                objUserControl_Documents.initialize(objSemItem_Ref)
        End Select
    End Sub

    
    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Dispose()
    End Sub


    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Configure_TabPages()
    End Sub
End Class