Imports Sem_Manager
Public Class clsModule
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private WithEvents objfrm_FileSystemManagement As frmFilesystemManagement
    Private WithEvents objFrm_Menue As frmMenu

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


    Private Sub applied_FileSystemItem_DataGrid(ByVal objDGVSRC_Files As DataGridViewSelectedRowCollection, ByVal RowName_GUID As String) Handles objfrm_FileSystemManagement.applied_FileSystemItem_DataGrid
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim i As Integer = 0

        objSemItems_Result = Nothing

        For Each objDGVR_Selected In objDGVSRC_Files
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            ReDim Preserve objSemItems_Result(i)
            objSemItems_Result(i) = New clsSemItem
            objSemItems_Result(i).GUID = objDRV_Selected.Item("GUID_File")
            objSemItems_Result(i).Name = objDRV_Selected.Item("Name_File")
            objSemItems_Result(i).GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItems_Result(i).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            i = i + 1
        Next

    End Sub

    Private Sub applied_FileSystemItem_Tree(ByVal objSemItem_FileSystemObject As clsSemItem) Handles objfrm_FileSystemManagement.applied_FileSystemItem_Tree
        ReDim Preserve objSemItems_Result(0)
        objSemItems_Result(0) = objSemItem_FileSystemObject
    End Sub

    Public ReadOnly Property SemItem_Module() As clsSemItem
        Get
            Return objSemItem_Module
        End Get
    End Property

    Public Sub New()

    End Sub

    Public Sub initialize(ByVal Globals)
        objLocalConfig = New clsLocalConfig_FileManager(Globals)
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
        objfrm_FileSystemManagement = New frmFilesystemManagement
        objfrm_FileSystemManagement.Show()
    End Sub
    Public Function start_Module_With_Result(ByVal Applyable As Boolean) As Boolean
        Dim boolResult As Boolean = False
        objfrm_FileSystemManagement = New frmFilesystemManagement
        objfrm_FileSystemManagement.Applyable = Applyable
        objfrm_FileSystemManagement.ShowDialog()
        If objfrm_FileSystemManagement.DialogResult = DialogResult.OK Then
            objfrm_FileSystemManagement.Hide()
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
