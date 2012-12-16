Imports Sem_Manager
Public Class clsModule
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private WithEvents objfrm_OfficeManager As frmOfficeManager
    Private WithEvents objFrm_Menue As frmMenu

    Private objLocalConfig As clsLocalConfig
    Private objSemItems_Result() As clsSemItem
    Private objSemItem_Module As clsSemItem

    Public ReadOnly Property TokenEdit As Boolean
        Get
            Return False
        End Get
    End Property

    Public ReadOnly Property SemItmes_Result() As clsSemItem()
        Get
            Return objSemItems_Result
        End Get
    End Property


    Private Sub applied_Document_DataGrid(ByVal objDGVSRC_Documents As DataGridViewSelectedRowCollection, ByVal RowName_GUID As String, ByVal RowName_Name As String, ByVal GUID_Parent As Guid) Handles objfrm_OfficeManager.applied_Document_DataGrid
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim i As Integer = 0

        objSemItems_Result = Nothing

        For Each objDGVR_Selected In objDGVSRC_Documents
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            ReDim Preserve objSemItems_Result(i)
            objSemItems_Result(i) = New clsSemItem
            objSemItems_Result(i).GUID = objDRV_Selected.Item(RowName_GUID)
            objSemItems_Result(i).Name = objDRV_Selected.Item(RowName_Name)
            objSemItems_Result(i).GUID_Parent = GUID_Parent
            objSemItems_Result(i).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            i = i + 1
        Next

    End Sub

    Private Sub applied_Document_Tree(ByVal objSemItem_Document As clsSemItem) Handles objfrm_OfficeManager.applied_Document_Tree
        ReDim Preserve objSemItems_Result(0)
        objSemItems_Result(0) = objSemItem_Document
    End Sub

    Public ReadOnly Property SemItem_Module() As clsSemItem
        Get
            Return objSemItem_Module
        End Get
    End Property

    Public Sub New()

    End Sub

    Public Sub initialize(ByVal Globals)
        objLocalConfig = New clsLocalConfig(Globals)
        set_DBConnection()
        get_Module()
    End Sub

    Private Sub get_Module()
        objSemItem_Module = objLocalConfig.SemItem_Token_Module_Office_Manager
    End Sub

    Public Sub execute_Module()
        objfrm_OfficeManager = New frmOfficeManager(objLocalConfig)
        objfrm_OfficeManager.Show()
    End Sub
    Public Function start_Module_With_Result(ByVal Applyable As Boolean) As Boolean
        Dim boolResult As Boolean = False
        objfrm_OfficeManager = New frmOfficeManager(objLocalConfig)
        objfrm_OfficeManager.applyable = Applyable
        objfrm_OfficeManager.ShowDialog()
        If objfrm_OfficeManager.DialogResult = DialogResult.OK Then
            objfrm_OfficeManager.Hide()
            boolResult = True
        End If

        Return boolResult
    End Function
    Public Function filter_SemItem(ByVal SemItem_Selected As clsSemItem) As clsSemItem

    End Function
    Public Function activate_Menue_SemItems(ByVal SemItems_Selected() As clsSemItem) As Boolean
        Dim boolResult As Boolean = False

        objFrm_Menue = New frmMenu(SemItems_Selected)
        objFrm_Menue.ShowDialog()
        If objFrm_Menue.DialogResult = DialogResult.OK Then
            boolResult = True
            objSemItems_Result = SemItems_Selected
            objFrm_Menue.Close()
        End If
        Return boolResult
    End Function

    Public Function activate_Menue_DataGrid(ByRef DGVSRC_Selected As DataGridViewSelectedRowCollection, ByVal strRowName_GUID As String, ByVal strRowName_Name As String, ByVal strRowName_Parent As String, ByVal GUID_Type As Guid) As Boolean
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim boolResult As Boolean = False
        Dim i As Integer = 0

        objFrm_Menue = New frmMenu(DGVSRC_Selected, strRowName_GUID, strRowName_Name, strRowName_Parent, GUID_Type)
        objFrm_Menue.ShowDialog()
        If objFrm_Menue.DialogResult = DialogResult.OK Then
            boolResult = True
            objSemItems_Result = Nothing
            For Each objDGVR_Selected In DGVSRC_Selected
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                ReDim Preserve objSemItems_Result(i)
                objSemItems_Result(i) = New clsSemItem
                objSemItems_Result(i).GUID = objDRV_Selected.Item(strRowName_GUID)
                objSemItems_Result(i).Name = objDRV_Selected.Item(strRowName_Name)
                objSemItems_Result(i).GUID_Parent = objDRV_Selected.Item(strRowName_Parent)
                objSemItems_Result(i).GUID_Type = GUID_Type
                i = i + 1
            Next

            objFrm_Menue.Hide()
        End If
        Return boolResult
    End Function
    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

    End Sub
End Class
