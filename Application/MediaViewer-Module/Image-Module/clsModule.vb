Imports Sem_Manager
Public Class clsModule
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private WithEvents objFrmImageModule As frmImageModule
    Private WithEvents objFrmModuleTokenEdit As frmModuleTokenEdit

    Private objLocalConfig As clsLocalConfig

    Private objSemItems_Result() As clsSemItem
    Private objSemItem_Module As clsSemItem

    Public ReadOnly Property TokenEdit As Boolean
        Get
            Return True
        End Get
    End Property


    Public ReadOnly Property SemItmes_Result() As clsSemItem()
        Get
            Return objSemItems_Result
        End Get
    End Property


    
    Private Sub applied_Item(ByVal objSemItem_Item As clsSemItem) Handles objFrmImageModule.applied_Item
        ReDim Preserve objSemItems_Result(0)
        objSemItems_Result(0) = objSemItem_Item
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
        objFrmImageModule = New frmImageModule
        objFrmImageModule.Show()
    End Sub
    Public Function start_Module_With_Result(ByVal Applyable As Boolean) As Boolean
        Dim boolResult As Boolean = False
        objFrmImageModule = New frmImageModule
        objFrmImageModule.applyable = True
        objFrmImageModule.ShowDialog()
        If objFrmImageModule.DialogResult = DialogResult.OK Then
            objFrmImageModule.Hide()
            boolResult = True
        End If

        Return boolResult
    End Function
    Public Function filter_SemItem(ByVal SemItem_Selected As clsSemItem) As clsSemItem

    End Function
    Public Function activate_Menue_SemItems(ByVal SemItems_Selected() As clsSemItem) As Boolean
        Dim boolResult As Boolean = False

        Return boolResult
    End Function

    Public Function edit_SemItem(ByVal SemItem_Token As clsSemItem, ByVal objFrm As Windows.Forms.IWin32Window) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objFrmModuleTokenEdit = New frmModuleTokenEdit(SemItem_Token, objLocalConfig)
        objFrmModuleTokenEdit.ShowDialog(objFrm)
        If objFrmModuleTokenEdit.DialogResult = DialogResult.OK Then
            objSemItem_Result = objFrmModuleTokenEdit.SemItem_Result
        Else
            objSemItem_Result = Nothing
        End If

        Return objSemItem_Result
    End Function

    Public Function activate_Menue_DataGrid(ByRef DGVSRC_Selected As DataGridViewSelectedRowCollection, ByVal strRowName_GUID As String, ByVal strRowName_Name As String, ByVal strRowName_Parent As String, ByVal GUID_Type As Guid) As Boolean
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim boolResult As Boolean = False
        Dim i As Integer = 0

        
        Return boolResult
    End Function
    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

    End Sub
End Class
