Imports Sem_Manager
Public Class clsModule
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private WithEvents objfrm_Partner As frmPartnerManager

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


    Private Sub applied_Partner_DataGrid(ByVal objDGVSRC_Files As DataGridViewSelectedRowCollection, ByVal RowName_GUID As String) Handles objfrm_Partner.applied_Partner_FromList
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim i As Integer = 0

        objSemItems_Result = Nothing

        For Each objDGVR_Selected In objDGVSRC_Files
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            ReDim Preserve objSemItems_Result(i)
            objSemItems_Result(i) = New clsSemItem
            objSemItems_Result(i).GUID = objDRV_Selected.Item("GUID_Token")
            objSemItems_Result(i).Name = objDRV_Selected.Item("Name_Token")
            objSemItems_Result(i).GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
            objSemItems_Result(i).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            i = i + 1
        Next
    End Sub

    Private Sub applied_Address_SemItems(ByVal objSemItem_Address As clsSemItem) Handles objfrm_Partner.applied_Address

        ReDim Preserve objSemItems_Result(0)
        objSemItems_Result(0) = objSemItem_Address
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
        Dim objDRC_Module As DataRowCollection

        objDRC_Module = funcA_TokenToken.GetData_TokenToken_RightLeft(objLocalConfig.GUID_Development, objLocalConfig.SemItem_RelationType_offered_by.GUID, objLocalConfig.SemItem_Type_Module.GUID).Rows
        If objDRC_Module.Count > 0 Then
            objSemItem_Module = New clsSemItem
            objSemItem_Module.GUID = objDRC_Module(0).Item("GUID_Token_Left")
            objSemItem_Module.Name = objDRC_Module(0).Item("Name_Token_Left")
            objSemItem_Module.GUID_Parent = objDRC_Module(0).Item("GUID_Type_Left")
            objSemItem_Module.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        Else
            objSemItem_Module = Nothing
        End If
    End Sub

    Public Sub execute_Module()
        objfrm_Partner = New frmPartnerManager()
        objfrm_Partner.Show()
    End Sub
    Public Function start_Module_With_Result(ByVal Applyable As Boolean) As Boolean
        Dim boolResult As Boolean = False
        objfrm_Partner = New frmPartnerManager
        objfrm_Partner.Applyable = Applyable
        objfrm_Partner.ShowDialog()
        If objfrm_Partner.DialogResult = DialogResult.OK Then
            objfrm_Partner.Close()
            boolResult = True
        End If

        Return boolResult
    End Function
    Public Function filter_SemItem(ByVal SemItem_Selected As clsSemItem) As clsSemItem

    End Function



    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

    End Sub
End Class
