Imports Sem_Manager
Public Class clsModule
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private WithEvents objFrmDevelopmentManager As frmDevelopmentManager


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
        objFrmDevelopmentManager = New frmDevelopmentManager
        objFrmDevelopmentManager.Show()
    End Sub
    Public Function start_Module_With_Result(ByVal Applyable As Boolean) As Boolean
        Dim boolResult As Boolean = False
        objFrmDevelopmentManager = New frmDevelopmentManager(objLocalConfig, True)
        objFrmDevelopmentManager.ShowDialog()
        If objFrmDevelopmentManager.DialogResult = DialogResult.OK Then
            objFrmDevelopmentManager.Hide()
            objSemItems_Result = objFrmDevelopmentManager.SemItems_Result
            boolResult = True
        End If

        Return boolResult
    End Function

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

    End Sub
End Class

