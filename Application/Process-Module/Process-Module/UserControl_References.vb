Imports Sem_Manager
Imports Filesystem_Management
Public Class UserControl_References
    Private cint_ImageID_Ref As Integer = 0
    Private cint_ImageID_Class As Integer = 1
    Private cint_ImageID_Bat As Integer = 2
    Private cint_ImageID_Attribute As Integer = 3
    Private cint_ImageID_RelationType As Integer = 4
    Private cint_ImageID_Manual As Integer = 5
    Private cint_ImageID_Needs As Integer = 6
    Private cint_ImageID_NeedsChild As Integer = 7
    Private cint_ImageID_Variable As Integer = 8
    Private cint_ImageID_Responsibility As Integer = 9
    Private cint_ImageID_Group As Integer = 10
    Private cint_ImageID_User As Integer = 11
    Private cint_ImageID_Document As Integer = 12
    Private cint_ImageID_File As Integer = 13
    Private cint_ImageID_Folder As Integer = 14
    Private cint_ImageID_Role As Integer = 15
    Private cint_ImageID_Application As Integer = 16
    Private cint_ImageID_Media As Integer = 17
    Private cint_ImageID_Belonging As Integer = 18
    Private cint_ImageID_Util As Integer = 58
    Private cint_ImageID_Material As Integer = 59

    Private cint_ImageID_Refs As Integer = 19
    Private cint_ImageID_Classes As Integer = 20
    Private cint_ImageID_Bats As Integer = 21
    Private cint_ImageID_Attributes As Integer = 22
    Private cint_ImageID_RelationTypes As Integer = 23
    Private cint_ImageID_Manuals As Integer = 24
    Private cint_ImageID_NeedsPar As Integer = 25
    Private cint_ImageID_NeedsChildPar As Integer = 26
    Private cint_ImageID_Variables As Integer = 27
    Private cint_ImageID_Responsibilities As Integer = 28
    Private cint_ImageID_Groups As Integer = 29
    Private cint_ImageID_Users As Integer = 30
    Private cint_ImageID_Documents As Integer = 31
    Private cint_ImageID_Files As Integer = 32
    Private cint_ImageID_Folders As Integer = 33
    Private cint_ImageID_Roles As Integer = 34
    Private cint_ImageID_Applications As Integer = 35
    Private cint_ImageID_Medias As Integer = 36
    Private cint_ImageID_Belongings As Integer = 37
    Private cint_ImageID_Utils As Integer = 60
    Private cint_ImageID_Materials As Integer = 61

    Private cint_ImageID_VarVal As Integer = 38

    Private cint_ImageID_Log_Ref As Integer = 39
    Private cint_ImageID_Log_Class As Integer = 40
    Private cint_ImageID_Log_Bat As Integer = 41
    Private cint_ImageID_Log_Attribute As Integer = 42
    Private cint_ImageID_Log_RelationType As Integer = 43
    Private cint_ImageID_Log_Manual As Integer = 44
    Private cint_ImageID_Log_Needs As Integer = 45
    Private cint_ImageID_Log_NeedsChild As Integer = 46
    Private cint_ImageID_Log_Variable As Integer = 47
    Private cint_ImageID_Log_Responsibility As Integer = 48
    Private cint_ImageID_Log_Group As Integer = 49
    Private cint_ImageID_Log_User As Integer = 50
    Private cint_ImageID_Log_Document As Integer = 51
    Private cint_ImageID_Log_File As Integer = 52
    Private cint_ImageID_Log_Folder As Integer = 53
    Private cint_ImageID_Log_Role As Integer = 53
    Private cint_ImageID_Log_Application As Integer = 55
    Private cint_ImageID_Log_Media As Integer = 56
    Private cint_ImageID_Log_Belonging As Integer = 57
    Private cint_ImageID_Log_Util As Integer = 62
    Private cint_ImageID_Log_Material As Integer = 63

    Private semtblT_Belonging As New ds_ObjectReference.func_Token_ORDataTable
    Private intRowCount_belonging As Integer
    Private intRowDone_belonging As Integer
    Private intRowLog_belonging As Integer
    Private boolDone_belonging As Boolean
    Private semtblT_Needs As New ds_ObjectReference.func_Token_ORDataTable
    Private intRowCount_Needs As Integer
    Private intRowDone_Needs As Integer
    Private intRowLog_Needs As Integer
    Private boolDone_Needs As Boolean
    Private semtblT_NeedsChild As New ds_ObjectReference.func_Token_ORDataTable
    Private intRowCount_NeedsChild As Integer
    Private intRowDone_NeedsChild As Integer
    Private intRowLog_NeedsChild As Integer
    Private boolDone_NeedsChild As Boolean
    Private dtbl_Variable As New ds_Process.dtbl_VariableDataTable
    Private intRowCount_Variable As Integer
    Private boolDone_Variable As Boolean
    Private intRowDone_Variable As Integer
    Private intRowLog_Variable As Integer
    Private semtblT_Responsiblity As New ds_Token.func_TokenTokenDataTable
    Private intRowCount_Responsibility As Integer
    Private intRowDone_Responsibility As Integer
    Private intRowLog_Responsibility As Integer
    Private boolDone_Responsibility As Boolean
    Private semtblT_Group As New ds_Token.func_TokenTokenDataTable
    Private intRowCount_Group As Integer
    Private intRowDone_Group As Integer
    Private intRowLog_Group As Integer
    Private boolDone_Group As Boolean
    Private semtblT_User As New ds_Token.func_TokenTokenDataTable
    Private intRowCount_User As Integer
    Private intRowDone_User As Integer
    Private intRowLog_User As Integer
    Private boolDone_User As Boolean
    Private semtblT_File As New ds_Token.func_TokenTokenDataTable
    Private intRowCount_File As Integer
    Private intRowDone_File As Integer
    Private intRowLog_File As Integer
    Private boolDone_File As Boolean
    Private semtblT_Folder As New ds_Token.func_TokenTokenDataTable
    Private intRowCount_Folder As Integer
    Private intRowDone_Folder As Integer
    Private intRowLog_Folder As Integer
    Private boolDone_Folder As Boolean
    Private semtblT_Role As New ds_Token.func_TokenTokenDataTable
    Private intRowCount_Role As Integer
    Private intRowDone_Role As Integer
    Private intRowLog_Role As Integer
    Private boolDone_Role As Boolean
    Private semtblT_Application As New ds_Token.func_TokenTokenDataTable
    Private intRowCount_Application As Integer
    Private intRowDone_Application As Integer
    Private intRowLog_Application As Integer
    Private boolDone_Application As Boolean
    Private semtblT_Media As New ds_Token.func_TokenTokenDataTable
    Private intRowCount_Media As Integer
    Private intRowDone_Media As Integer
    Private intRowLog_Media As Integer
    Private boolDone_Media As Boolean
    Private semtblT_Manual As New ds_Token.func_TokenTokenDataTable
    Private intRowCount_Manual As Integer
    Private intRowDone_Manual As Integer
    Private intRowLog_Manual As Integer
    Private boolDone_Manual As Boolean
    Private semtblT_Document As New ds_ObjectReference.func_Token_ORDataTable
    Private intRowCount_Document As Integer
    Private intRowDone_Document As Integer
    Private intRowLog_Document As Integer
    Private boolDone_Document As Boolean
    Private procT_Util As New ds_Process.proc_ProcessThins_Of_ProcessLocDataTable
    Private intRowCount_Util As Integer
    Private intRowDone_Util As Integer
    Private intRowLog_Util As Integer
    Private boolDone_Util As Boolean
    Private procT_Material As New ds_Process.proc_ProcessThins_Of_ProcessLocDataTable
    Private intRowCount_Material As Integer
    Private intRowDone_Material As Integer
    Private intRowLog_Material As Integer
    Private boolDone_Material As Boolean


    Private objSemItem_Process As clsSemItem
    Private objSemItem_ProcessLog As clsSemItem

    Private WithEvents objFrm_FileSystemManagement As frmFilesystemManagement
    Private objFrm_TokenEdit As frmTokenEdit
    Private objFileWork As clsFileWork
    Private objTransaction_References As clsTransaction_References
    Private objThread_References As Threading.Thread

    Private objTreeNode_Refs As TreeNode
    Private objTreeNode_Classes As TreeNode
    Private objTreeNode_Bats As TreeNode
    Private objTreeNode_Attributes As TreeNode
    Private objTreeNode_RelationTypes As TreeNode
    Private objTreeNode_Manuals As TreeNode
    Private objTreeNode_NeedsPar As TreeNode
    Private objTreeNode_NeedsChildPar As TreeNode
    Private objTreeNode_Variables As TreeNode
    Private objTreeNode_Responsibilities As TreeNode
    Private objTreeNode_Groups As TreeNode
    Private objTreeNode_Users As TreeNode
    Private objTreeNode_Documents As TreeNode
    Private objTreeNode_Files As TreeNode
    Private objTreeNode_Folders As TreeNode
    Private objTreeNode_Roles As TreeNode
    Private objTreeNode_Applications As TreeNode
    Private objTreeNode_Medias As TreeNode
    Private objTreeNode_Belongings As TreeNode
    Private objTreeNode_Utils As TreeNode
    Private objTreeNode_Materials As TreeNode

    Private objLocalConfig As clsLocalConfig

    Private objFrmSemManager As frmSemManager

    Private strConnectionString_DB As String
    Private strConnectionString_Module As String

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private procA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private procA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private procA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private procA_ProcessThins_Of_ProcessLocDataTable As New ds_ProcessTableAdapters.proc_ProcessThins_Of_ProcessLocTableAdapter

    Private Sub applied_File(ByVal objDGVSRC_Files As DataGridViewSelectedRowCollection, ByVal strRowName_GUID As String) Handles objFrm_FileSystemManagement.applied_FileSystemItem_DataGrid
        Dim objDGVR_File As DataGridViewRow
        Dim objDRV_File As DataRowView
        Dim objTreeNodes() As TreeNode
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_ProcessRef As clsSemItem
        Dim objDR_File As DataRow
        Dim strPath As String
        Dim semtblT_File As New ds_SemDB.semtbl_TokenDataTable


        For Each objDGVR_File In objDGVSRC_Files
            objDRV_File = objDGVR_File.DataBoundItem
            semtblT_File.Rows.Add(objDRV_File.Item("GUID_File"), _
                                  objDRV_File.Item("Name_File"), _
                                  objDRV_File.Item("GUID_Type_File"))
            


        Next
        objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_Process)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_ProcessRef = objTransaction_References.SemItem_ProcessRef
            objSemItem_Result = objTransaction_References.save_002_SimpleItems(semtblT_File, objLocalConfig.SemItem_RelationType_needs, objSemItem_ProcessRef)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                For Each objDR_File In semtblT_File.Rows
                    objSemItem_File.GUID = objDR_File.Item("GUID_Token")
                    objSemItem_File.Name = objDR_File.Item("Name_Token")
                    objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                    objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    strPath = objFileWork.get_Path_FileSystemObject(objSemItem_File)
                    objTreeNodes = objTreeNode_Files.Nodes.Find(objSemItem_File.GUID.ToString, False)
                    If objTreeNodes.Count = 0 Then
                        objTreeNode_Files.Nodes.Add(objSemItem_File.GUID.ToString, _
                                                    strPath, _
                                                    cint_ImageID_File, _
                                                    cint_ImageID_File)
                    End If
                Next
            End If
        Else
            MsgBox("Die Datei kann nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
        End If
        
    End Sub

    Private Sub applied_Folder(ByVal objSemItem_FileSystemObject As clsSemItem) Handles objFrm_FileSystemManagement.applied_FileSystemItem_Tree
        Dim semtblT_Folder As New ds_SemDB.semtbl_TokenDataTable
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_ProcessRef As clsSemItem
        Dim objTreeNodes() As TreeNode
        Dim strPath As String



        semtblT_Folder.Rows.Add(objSemItem_FileSystemObject.GUID, _
                              objSemItem_FileSystemObject.Name, _
                              objSemItem_FileSystemObject.GUID_Parent)
        objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_Process)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_ProcessRef = objTransaction_References.SemItem_ProcessRef
            objSemItem_Result = objTransaction_References.save_002_SimpleItems(semtblT_Folder, objLocalConfig.SemItem_RelationType_needs, objSemItem_ProcessRef)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                strPath = objFileWork.get_Path_FileSystemObject(objSemItem_FileSystemObject)
                objTreeNodes = objTreeNode_Files.Nodes.Find(objSemItem_FileSystemObject.GUID.ToString, False)
                If objTreeNodes.Count = 0 Then
                    objTreeNode_Folders.Nodes.Add(objSemItem_FileSystemObject.GUID.ToString, _
                                                strPath, _
                                                cint_ImageID_Folder, _
                                                cint_ImageID_Folder)
                End If
            End If
        Else
            MsgBox("Der Ordner kann nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
        End If
        

    End Sub

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        initialize()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
        funcA_Token_OR.ClearBeforeFill = False
        funcA_TokenToken.ClearBeforeFill = False
        'save_ImagesOfImageList()
    End Sub

    'Private Sub save_ImagesOfImageList()
    '    Dim i As Integer
    '    For i = 0 To ImageList_Reference.Images.Count - 1
    '        ImageList_Reference.Images(i).Save("Image " & i & ".png")


    '    Next

    'End Sub
    Public Sub abort_Thread()
        Try
            ToolStripProgressBar_References.Value = 0
            objThread_References.Abort()
            clear_Tables()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub clear_Nodes()
        abort_Thread()
        TreeView_Refs.Nodes.Clear()
    End Sub

    Public Sub fill_Tree_Ref_Process(ByVal SemItem_Process As clsSemItem, Optional ByVal SemItem_ProcessLog As clsSemItem = Nothing)
        abort_Thread()
        objSemItem_Process = SemItem_Process
        objSemItem_ProcessLog = SemItem_ProcessLog
        If objSemItem_ProcessLog Is Nothing Then
            LogItemToolStripMenuItem.Visible = False
        Else
            LogItemToolStripMenuItem.Visible = True
        End If
        objTreeNode_Refs = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID.ToString, objLocalConfig.SemItem_RelationType_belonging_Sem_Item.Name, cint_ImageID_Refs, cint_ImageID_Refs)
        objTreeNode_NeedsPar = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_RelationType_needs.GUID.ToString, objLocalConfig.SemItem_RelationType_needs.Name, cint_ImageID_NeedsPar, cint_ImageID_NeedsPar)
        objTreeNode_NeedsChildPar = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_RelationType_needs_Child.ToString, objLocalConfig.SemItem_RelationType_needs_Child.Name, cint_ImageID_NeedsChildPar, cint_ImageID_NeedsChildPar)
        objTreeNode_Files = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_Type_File.GUID.ToString, objLocalConfig.SemItem_Type_File.Name, cint_ImageID_Files, cint_ImageID_Files)
        objTreeNode_Folders = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_type_Folder.GUID.ToString, objLocalConfig.SemItem_type_Folder.Name, cint_ImageID_Folders, cint_ImageID_Folders)
        objTreeNode_Applications = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_Type_Application.GUID.ToString, objLocalConfig.SemItem_Type_Application.Name, cint_ImageID_Applications, cint_ImageID_Applications)
        objTreeNode_Medias = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_Type_Media.GUID.ToString, objLocalConfig.SemItem_Type_Media.Name, cint_ImageID_Medias, cint_ImageID_Medias)
        objTreeNode_Responsibilities = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_Type_responsibility.GUID.ToString, objLocalConfig.SemItem_Type_responsibility.Name, cint_ImageID_Responsibilities, cint_ImageID_Responsibilities)
        objTreeNode_Roles = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_Type_Role.GUID.ToString, objLocalConfig.SemItem_Type_Role.Name, cint_ImageID_Roles, cint_ImageID_Roles)
        objTreeNode_Users = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_type_User.GUID.ToString, objLocalConfig.SemItem_type_User.Name, cint_ImageID_Users, cint_ImageID_Users)
        objTreeNode_Groups = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_Type_Group.GUID.ToString, objLocalConfig.SemItem_Type_Group.Name, cint_ImageID_Groups, cint_ImageID_Groups)
        objTreeNode_Variables = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_Type_Variable.GUID.ToString, objLocalConfig.SemItem_Type_Variable.Name, cint_ImageID_Variables, cint_ImageID_Variables)
        objTreeNode_Documents = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_RelationType_needed_Documentation.GUID.ToString, objLocalConfig.SemItem_RelationType_needed_Documentation.Name, cint_ImageID_Documents, cint_ImageID_Documents)
        objTreeNode_Manuals = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_Type_Manual.GUID.ToString, objLocalConfig.SemItem_Type_Manual.Name, cint_ImageID_Manuals, cint_ImageID_Manuals)
        objTreeNode_Utils = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_RelationType_belonging_Util.GUID.ToString, objLocalConfig.SemItem_RelationType_belonging_Util.Name, cint_ImageID_Utils, cint_ImageID_Utils)
        objTreeNode_Materials = TreeView_Refs.Nodes.Add(objLocalConfig.SemItem_RelationType_belonging_Material.GUID.ToString, objLocalConfig.SemItem_RelationType_belonging_Material.Name, cint_ImageID_Materials, cint_ImageID_Materials)


        intRowCount_Application = 0
        intRowCount_belonging = 0
        intRowCount_Document = 0
        intRowCount_File = 0
        intRowCount_Folder = 0
        intRowCount_Group = 0
        intRowCount_Manual = 0
        intRowCount_Media = 0
        intRowCount_Needs = 0
        intRowCount_NeedsChild = 0
        intRowCount_Responsibility = 0
        intRowCount_Role = 0
        intRowCount_User = 0
        intRowCount_Variable = 0
        intRowCount_Material = 0
        intRowCount_Util = 0

        intRowDone_Application = 0
        intRowDone_belonging = 0
        intRowDone_Document = 0
        intRowDone_File = 0
        intRowDone_Folder = 0
        intRowDone_Group = 0
        intRowDone_Manual = 0
        intRowDone_Media = 0
        intRowDone_Needs = 0
        intRowDone_NeedsChild = 0
        intRowDone_Responsibility = 0
        intRowDone_Role = 0
        intRowDone_User = 0
        intRowDone_Variable = 0
        intRowDone_Material = 0
        intRowDone_Util = 0

        clear_Tables()
        abort_Thread()
        objThread_References = New Threading.Thread(AddressOf get_ProcessRefs)
        objThread_References.Start()

        ToolStripProgressBar_References.Maximum = 18
        Timer_References.Start()
    End Sub

    Private Sub clear_Tables()
        semtblT_Belonging.Clear()
        semtblT_Needs.Clear()
        semtblT_NeedsChild.Clear()
        semtblT_Document.Clear()
        semtblT_Responsiblity.Clear()
        semtblT_Application.Clear()
        semtblT_File.Clear()
        semtblT_Folder.Clear()
        semtblT_Group.Clear()
        semtblT_Manual.Clear()
        semtblT_Media.Clear()
        semtblT_Role.Clear()
        semtblT_User.Clear()
        dtbl_Variable.Clear()
    End Sub

    Private Sub get_ProcessRefs()
        Dim funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
        Dim funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter

        Dim objConnection As SqlClient.SqlConnection

        Dim objDRC_Process As DataRowCollection
        Dim objDRC_ProcessLog As DataRowCollection = Nothing
        Dim objDRC_Token As DataRowCollection
        Dim objDR_Token As DataRow
        Dim objDRC_VarVal As DataRowCollection
        Dim objSemItem_ProcessRef As New clsSemItem
        Dim objSemItem_ProcessLogRef As clsSemItem = Nothing

        Dim GUID_Var As Guid
        Dim Name_Var As String
        Dim GUID_Type_Var As Guid
        Dim strVal As String

        objConnection = New SqlClient.SqlConnection(strConnectionString_DB)

        funcA_TokenToken.Connection = objConnection
        funcA_Token_OR.Connection = objConnection

        boolDone_belonging = False
        boolDone_Needs = False
        boolDone_NeedsChild = False
        boolDone_Responsibility = False
        boolDone_Application = False
        boolDone_Document = False
        boolDone_File = False
        boolDone_Folder = False
        boolDone_Group = False
        boolDone_Manual = False
        boolDone_Media = False
        boolDone_Role = False
        boolDone_User = False
        boolDone_Variable = False
        boolDone_Material = False
        boolDone_Util = False



        objDRC_Process = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Process.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                   objLocalConfig.SemItem_Type_Process_References.GUID).Rows
        If Not objSemItem_ProcessLog Is Nothing Then
            objDRC_ProcessLog = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLog.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                       objLocalConfig.SemItem_Type_Process_References.GUID).Rows
        End If




        If objDRC_Process.Count > 0 Then
            objSemItem_ProcessRef.GUID = objDRC_Process(0).Item("GUID_Token_right")
            objSemItem_ProcessRef.Name = objDRC_Process(0).Item("Name_Token_right")
            objSemItem_ProcessRef.GUID_Parent = objLocalConfig.SemItem_Type_Process_References.GUID
            objSemItem_ProcessRef.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        Else
            objSemItem_ProcessRef = Nothing
        End If

        If Not objDRC_ProcessLog Is Nothing Then
            If objDRC_ProcessLog.Count > 0 Then
                objSemItem_ProcessLogRef = New clsSemItem
                objSemItem_ProcessLogRef.GUID = objDRC_ProcessLog(0).Item("GUID_Token_right")
                objSemItem_ProcessLogRef.Name = objDRC_ProcessLog(0).Item("Name_Token_right")
                objSemItem_ProcessLogRef.GUID_Parent = objLocalConfig.SemItem_Type_Process_References.GUID
                objSemItem_ProcessLogRef.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            End If
        End If
        If Not objSemItem_ProcessRef Is Nothing Then
            funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(semtblT_Belonging, objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID)
        End If

        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_belonging = semtblT_Belonging.Rows.Count
            funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(semtblT_Belonging, objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID)
        Else
            intRowLog_belonging = -1
        End If
        intRowCount_belonging = semtblT_Belonging.Rows.Count
        boolDone_belonging = True

        If Not objSemItem_ProcessRef Is Nothing Then
            funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(semtblT_Needs, objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID)
        End If
        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_Needs = semtblT_Needs.Rows.Count
            funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(semtblT_Needs, objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID)
        Else
            intRowLog_Needs = -1
        End If
        intRowCount_Needs = semtblT_Needs.Rows.Count
        boolDone_Needs = True

        If Not objSemItem_ProcessRef Is Nothing Then

            funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(semtblT_NeedsChild, objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needs_Child.GUID)
        End If
        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_belonging = semtblT_NeedsChild.Rows.Count
            funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(semtblT_NeedsChild, objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needs_Child.GUID)
        Else
            intRowLog_belonging = -1
        End If
        intRowCount_belonging = semtblT_NeedsChild.Rows.Count
        boolDone_NeedsChild = True

        If Not objSemItem_ProcessRef Is Nothing Then

            funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(semtblT_Document, objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needed_Documentation.GUID)
        End If
        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_Document = semtblT_Document.Rows.Count
            funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(semtblT_Document, objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needed_Documentation.GUID)
        Else
            intRowLog_Document = -1
        End If
        intRowCount_Document = semtblT_Document.Rows.Count
        boolDone_Document = True

        If Not objSemItem_ProcessRef Is Nothing Then

            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needs_authority.GUID, objLocalConfig.SemItem_Type_responsibility.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Responsiblity.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        End If

        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_Responsibility = semtblT_Responsiblity.Rows.Count
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needs_authority.GUID, objLocalConfig.SemItem_Type_responsibility.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Responsiblity.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        Else
            intRowLog_Responsibility = -1
        End If


        intRowCount_Responsibility = semtblT_Responsiblity.Rows.Count
        boolDone_Responsibility = True

        If Not objSemItem_ProcessRef Is Nothing Then
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Application.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Application.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        End If
        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_Application = semtblT_Application.Rows.Count
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Application.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Application.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        Else
            intRowLog_Application = -1
        End If
        intRowCount_Application = semtblT_Application.Rows.Count
        boolDone_Application = True

        If Not objSemItem_ProcessRef Is Nothing Then
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_File.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_File.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        End If
        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_File = semtblT_File.Rows.Count
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_File.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_File.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        Else
            intRowLog_File = -1
        End If
        intRowCount_File = semtblT_File.Rows.Count
        boolDone_File = True

        If Not objSemItem_ProcessRef Is Nothing Then
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_type_Folder.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Folder.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        End If
        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_Folder = semtblT_Folder.Rows.Count
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_type_Folder.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Folder.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        Else
            intRowLog_Folder = -1
        End If
        intRowCount_Folder = semtblT_Folder.Rows.Count
        boolDone_Folder = True

        If Not objSemItem_ProcessRef Is Nothing Then
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needs_authority.GUID, objLocalConfig.SemItem_Type_Group.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Group.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        End If
        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_Group = semtblT_Group.Rows.Count
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needs_authority.GUID, objLocalConfig.SemItem_Type_Group.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Group.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        Else
            intRowLog_Group = -1
        End If
        intRowCount_Group = semtblT_Group.Rows.Count
        boolDone_Group = True

        If Not objSemItem_ProcessRef Is Nothing Then
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Manual.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Manual.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        End If
        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_Manual = semtblT_Manual.Rows.Count
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Manual.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Manual.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        Else
            intRowLog_Manual = -1
        End If
        intRowCount_Manual = semtblT_Manual.Rows.Count
        boolDone_Manual = True

        If Not objSemItem_ProcessRef Is Nothing Then
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Media.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Media.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        End If
        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_Media = semtblT_Media.Rows.Count
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Media.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Media.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        Else
            intRowLog_Media = -1
        End If
        intRowCount_Media = semtblT_Media.Rows.Count
        boolDone_Media = True

        If Not objSemItem_ProcessRef Is Nothing Then
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needs_authority.GUID, objLocalConfig.SemItem_Type_Role.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Role.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        End If
        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_Role = semtblT_Role.Rows.Count
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Role.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_Role.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        Else
            intRowLog_Role = -1
        End If
        intRowCount_Role = semtblT_Role.Rows.Count
        boolDone_Role = True

        If Not objSemItem_ProcessRef Is Nothing Then
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needs_authority.GUID, objLocalConfig.SemItem_type_User.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_User.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        End If
        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_User = semtblT_User.Rows.Count
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needs_authority.GUID, objLocalConfig.SemItem_type_User.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token


                    semtblT_User.Rows.Add(objDR_Token.Item(0), _
                                                   objDR_Token.Item(1), _
                                                   objDR_Token.Item(2), _
                                                   objDR_Token.Item(3), _
                                                   objDR_Token.Item(4), _
                                                   objDR_Token.Item(5), _
                                                   objDR_Token.Item(6), _
                                                   objDR_Token.Item(7), _
                                                   objDR_Token.Item(8), _
                                                   objDR_Token.Item(9), _
                                                   objDR_Token.Item(10))

                Next

            End If
        Else
            intRowLog_User = -1
        End If
        intRowCount_User = semtblT_User.Rows.Count
        boolDone_User = True

        If Not objSemItem_ProcessRef Is Nothing Then
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Variable.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token

                    GUID_Var = objDR_Token.Item("GUID_Token_Right")
                    Name_Var = objDR_Token.Item("Name_Token_Right")
                    GUID_Type_Var = objLocalConfig.SemItem_Type_Variable.GUID

                    objDRC_VarVal = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objDR_Token.Item("GUID_Token_Right"), _
                                                                                                                   objLocalConfig.SemItem_Attribute_Value.GUID).Rows
                    If objDRC_VarVal.Count > 0 Then
                        strVal = objDRC_VarVal(0).Item("VAL_VARCHAR255")
                    Else
                        strVal = ""
                    End If

                    dtbl_Variable.Rows.Add(objDR_Token.Item("GUID_Token_Right"), _
                                              objDR_Token.Item("Name_Token_Right"), _
                                              objDR_Token.Item("GUID_Type_Right"), _
                                              strVal)


                Next

            End If
        End If
        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_Variable = dtbl_Variable.Rows.Count
            objDRC_Token = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ProcessLogRef.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Variable.GUID).Rows

            If objDRC_Token.Count > 0 Then

                For Each objDR_Token In objDRC_Token

                    GUID_Var = objDR_Token.Item("GUID_Token_Right")
                    Name_Var = objDR_Token.Item("Name_Token_Right")
                    GUID_Type_Var = objLocalConfig.SemItem_Type_Variable.GUID

                    objDRC_VarVal = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objDR_Token.Item("GUID_Token_Right"), _
                                                                                                                   objLocalConfig.SemItem_Attribute_Value.GUID).Rows
                    If objDRC_VarVal.Count > 0 Then
                        strVal = objDRC_VarVal(0).Item("VAL_VARCHAR255")
                    Else
                        strVal = ""
                    End If

                    dtbl_Variable.Rows.Add(objDR_Token.Item("GUID_Token_Right"), _
                                              objDR_Token.Item("Name_Token_Right"), _
                                              objDR_Token.Item("GUID_Type_Right"), _
                                              strVal)


                Next

            End If
        Else
            intRowLog_Variable = -1
        End If

        intRowCount_Variable = dtbl_Variable.Rows.Count
        boolDone_Variable = True

        If Not objSemItem_ProcessRef Is Nothing Then
            intRowCount_Material = procT_Material.Rows.Count
            procA_ProcessThins_Of_ProcessLocDataTable.Fill(procT_Material, _
                                                              objLocalConfig.SemItem_Attribute_Count.GUID, _
                                                                             objLocalConfig.SemItem_Type_Process_References.GUID, _
                                                                             objLocalConfig.SemItem_Type_Things_References.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_belonging_Material.GUID, _
                                                                             objSemItem_ProcessRef.GUID)

        Else
            intRowCount_Material = -1
        End If


        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_Material = procT_Material.Rows.Count
            procA_ProcessThins_Of_ProcessLocDataTable.Fill(procT_Material, _
                                                              objLocalConfig.SemItem_Attribute_Count.GUID, _
                                                                             objLocalConfig.SemItem_Type_Process_References.GUID, _
                                                                             objLocalConfig.SemItem_Type_Things_References.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_belonging_Material.GUID, _
                                                                             objSemItem_ProcessLogRef.GUID)
            
        Else
            intRowLog_Material = -1
        End If

        intRowCount_Material = procT_Material.Rows.Count
        boolDone_Material = True

        If Not objSemItem_ProcessRef Is Nothing Then
            intRowCount_Util = procT_Util.Rows.Count
            procA_ProcessThins_Of_ProcessLocDataTable.Fill(procT_Util, _
                                                              objLocalConfig.SemItem_Attribute_Count.GUID, _
                                                                             objLocalConfig.SemItem_Type_Process_References.GUID, _
                                                                             objLocalConfig.SemItem_Type_Things_References.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_belonging_Util.GUID, _
                                                                             objSemItem_ProcessRef.GUID)

        Else
            intRowCount_Util = -1
        End If

        If Not objSemItem_ProcessLogRef Is Nothing Then
            intRowLog_Util = procT_Util.Rows.Count
            procA_ProcessThins_Of_ProcessLocDataTable.Fill(procT_Util, _
                                                              objLocalConfig.SemItem_Attribute_Count.GUID, _
                                                                             objLocalConfig.SemItem_Type_Process_References.GUID, _
                                                                             objLocalConfig.SemItem_Type_Things_References.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_belonging_Util.GUID, _
                                                                             objSemItem_ProcessLogRef.GUID)

        Else
            intRowLog_Util = -1
        End If

        intRowCount_Util = procT_Util.Rows.Count
        boolDone_Util = True


    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Attribute.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_RelationType.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Type.Connection = objLocalConfig.Connection_DB
        procA_ProcessThins_Of_ProcessLocDataTable.Connection = objLocalConfig.Connection_Plugin

        objTransaction_References = New clsTransaction_References(objLocalConfig)
        objFrm_FileSystemManagement = New frmFilesystemManagement(objLocalConfig.Globals)
        objFileWork = New clsFileWork(objLocalConfig.Globals)
        strConnectionString_DB = objLocalConfig.Connection_DB.ConnectionString
        strConnectionString_Module = objLocalConfig.Connection_Plugin.ConnectionString
    End Sub

    Private Sub Timer_References_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_References.Tick
        Dim objTreeNode_Var As TreeNode
        Dim objSemItem_FileSystemObject As New clsSemItem
        Dim strPath As String
        Dim strMatUtil As String
        Dim dateNow As Date
        Dim boolStopTimer As Boolean
        Dim intImageiD As Integer
        Dim intVal_Progressbar As Integer

        dateNow = Now
        boolStopTimer = True
        Do
            intVal_Progressbar = 0
            If boolDone_Application = True And intRowDone_Application < intRowCount_Application Then
                If intRowDone_Application < intRowLog_Application And intRowLog_Application > 0 Then
                    intImageiD = cint_ImageID_Application
                Else
                    intImageiD = cint_ImageID_Log_Application
                End If
                objTreeNode_Applications.Nodes.Add(semtblT_Application.Rows(intRowDone_Application).Item("GUID_Token_Right").ToString, semtblT_Application.Rows(intRowDone_Application).Item("Name_Token_Right"), intImageiD, intImageiD)
                intRowDone_Application = intRowDone_Application + 1
                boolStopTimer = False
            ElseIf boolDone_Application = False Then
                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If



            If boolDone_belonging = True And intRowDone_belonging < intRowCount_belonging Then

                Select Case semtblT_Belonging.Rows(intRowDone_belonging).Item("GUID_ItemType")
                    Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                        If intRowDone_belonging < intRowLog_belonging And intRowLog_belonging > 0 Then
                            intImageiD = cint_ImageID_Attribute
                        Else
                            intImageiD = cint_ImageID_Log_Attribute
                        End If

                    Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        If intRowDone_belonging < intRowLog_belonging And intRowLog_belonging > 0 Then
                            intImageiD = cint_ImageID_Bat
                        Else
                            intImageiD = cint_ImageID_Log_Bat
                        End If

                    Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                        If intRowDone_belonging < intRowLog_belonging And intRowLog_belonging > 0 Then
                            intImageiD = cint_ImageID_Class
                        Else
                            intImageiD = cint_ImageID_Log_Class
                        End If

                    Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                        If intRowDone_belonging < intRowLog_belonging And intRowLog_belonging > 0 Then
                            intImageiD = cint_ImageID_RelationType
                        Else
                            intImageiD = cint_ImageID_Log_RelationType
                        End If

                End Select
                objTreeNode_Belongings.Nodes.Add(semtblT_Belonging.Rows(intRowDone_belonging).Item("GUID_Ref").ToString, semtblT_Belonging.Rows(intRowDone_belonging).Item("Name_Ref"), intImageiD, intImageiD)
                intRowDone_belonging = intRowDone_belonging + 1
                boolStopTimer = False
            ElseIf boolDone_belonging = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If



            If boolDone_Document = True And intRowDone_Document < intRowCount_Document Then
                If intRowDone_Document < intRowLog_Document And intRowLog_Document > 0 Then
                    intImageiD = cint_ImageID_Document
                Else
                    intImageiD = cint_ImageID_Log_Document
                End If

                objTreeNode_Documents.Nodes.Add(semtblT_Document.Rows(intRowDone_Document).Item("GUID_Token_Right"), semtblT_Document.Rows(intRowDone_Document).Item("Name_Token_Right"), intImageiD, intImageiD)
                intRowDone_Document = intRowDone_Document + 1
                boolStopTimer = False
            ElseIf boolDone_Document = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If


            If boolDone_File = True And intRowDone_File < intRowCount_File Then
                If intRowDone_File < intRowLog_File And intRowLog_File > 0 Then
                    intImageiD = cint_ImageID_File
                Else
                    intImageiD = cint_ImageID_Log_File
                End If
                objSemItem_FileSystemObject.GUID = semtblT_File.Rows(intRowDone_File).Item("GUID_Token_Right")
                objSemItem_FileSystemObject.Name = semtblT_File.Rows(intRowDone_File).Item("Name_Token_Right")
                objSemItem_FileSystemObject.GUID_Parent = semtblT_File.Rows(intRowDone_File).Item("GUID_Type_Right")
                objSemItem_FileSystemObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                strPath = objFileWork.get_Path_FileSystemObject(objSemItem_FileSystemObject)

                objTreeNode_Files.Nodes.Add(semtblT_File.Rows(intRowDone_File).Item("GUID_Token_Right").ToString, strPath, intImageiD, intImageiD)
                intRowDone_File = intRowDone_File + 1
                boolStopTimer = False
            ElseIf boolDone_File = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolDone_Folder = True And intRowDone_Folder < intRowCount_Folder Then
                If intRowDone_Folder < intRowLog_Folder And intRowLog_Folder > 0 Then
                    intImageiD = cint_ImageID_Folder
                Else
                    intImageiD = cint_ImageID_Log_Folder
                End If
                objSemItem_FileSystemObject.GUID = semtblT_Folder.Rows(intRowDone_Folder).Item("GUID_Token_Right")
                objSemItem_FileSystemObject.Name = semtblT_Folder.Rows(intRowDone_Folder).Item("Name_Token_Right")
                objSemItem_FileSystemObject.GUID_Parent = semtblT_Folder.Rows(intRowDone_Folder).Item("GUID_Type_Right")
                objSemItem_FileSystemObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                strPath = objFileWork.get_Path_FileSystemObject(objSemItem_FileSystemObject)

                objTreeNode_Folders.Nodes.Add(semtblT_Folder.Rows(intRowDone_Folder).Item("GUID_Token_Right").ToString, strPath, intImageiD, intImageiD)
                intRowDone_Folder = intRowDone_Folder + 1
                boolStopTimer = False
            ElseIf boolDone_Folder = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolDone_Group = True And intRowDone_Group < intRowCount_Group Then
                If intRowDone_Group < intRowLog_Group And intRowLog_Group > 0 Then
                    intImageiD = cint_ImageID_Group
                Else
                    intImageiD = cint_ImageID_Log_Group
                End If

                objTreeNode_Groups.Nodes.Add(semtblT_Group.Rows(intRowDone_Group).Item("GUID_Token_Right").ToString, semtblT_Group.Rows(intRowDone_Group).Item("Name_Token_Right"), intImageiD, intImageiD)
                intRowDone_Group = intRowDone_Group + 1
                boolStopTimer = False
            ElseIf boolDone_Group = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolDone_Manual = True And intRowDone_Manual < intRowCount_Manual Then
                If intRowDone_Manual < intRowLog_Manual And intRowLog_Manual > 0 Then
                    intImageiD = cint_ImageID_Manual
                Else
                    intImageiD = cint_ImageID_Log_Manual
                End If

                objTreeNode_Manuals.Nodes.Add(semtblT_Manual.Rows(intRowDone_Manual).Item("GUID_Token_Right").ToString, semtblT_Manual.Rows(intRowDone_Manual).Item("Name_Token_Right"), intImageiD, intImageiD)
                intRowDone_Manual = intRowDone_Manual + 1
                boolStopTimer = False
            ElseIf boolDone_Manual = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolDone_Media = True And intRowDone_Media < intRowCount_Media Then
                If intRowDone_Media < intRowLog_Media And intRowLog_Media > 0 Then
                    intImageiD = cint_ImageID_Media
                Else
                    intImageiD = cint_ImageID_Log_Media
                End If

                objTreeNode_Medias.Nodes.Add(semtblT_Media.Rows(intRowDone_Media).Item("GUID_Token_Right").ToString, semtblT_Media.Rows(intRowDone_Media).Item("Name_Token_Right"), intImageiD, intImageiD)
                intRowDone_Media = intRowDone_Media + 1
                boolStopTimer = False
            ElseIf boolDone_Media = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolDone_Needs = True And intRowDone_Needs < intRowCount_Needs Then
                
                Select Case semtblT_Needs.Rows(intRowDone_belonging).Item("GUID_ItemType")
                    Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                        If intRowDone_Needs < intRowLog_Needs And intRowLog_Needs > 0 Then
                            intImageiD = cint_ImageID_Attribute
                        Else
                            intImageiD = cint_ImageID_Log_Attribute
                        End If

                    Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        If intRowDone_Needs < intRowLog_Needs And intRowLog_Needs > 0 Then
                            intImageiD = cint_ImageID_Bat
                        Else
                            intImageiD = cint_ImageID_Log_Bat
                        End If

                    Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                        If intRowDone_Needs < intRowLog_Needs And intRowLog_Needs > 0 Then
                            intImageiD = cint_ImageID_Class
                        Else
                            intImageiD = cint_ImageID_Log_Class
                        End If

                    Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                        If intRowDone_Needs < intRowLog_Needs And intRowLog_Needs > 0 Then
                            intImageiD = cint_ImageID_RelationType
                        Else
                            intImageiD = cint_ImageID_Log_RelationType
                        End If


                End Select
                objTreeNode_NeedsPar.Nodes.Add(semtblT_Needs.Rows(intRowDone_Needs).Item("GUID_Ref").ToString, semtblT_Needs.Rows(intRowDone_Needs).Item("Name_Ref"), intImageiD, intImageiD)
                intRowDone_Needs = intRowDone_Needs + 1
                boolStopTimer = False
            ElseIf boolDone_Needs = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolDone_NeedsChild = True And intRowDone_NeedsChild < intRowCount_NeedsChild Then

                Select Case semtblT_NeedsChild.Rows(intRowDone_belonging).Item("GUID_ItemType")
                    Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                        If intRowDone_NeedsChild < intRowLog_NeedsChild And intRowLog_NeedsChild > 0 Then
                            intImageiD = cint_ImageID_Attribute
                        Else
                            intImageiD = cint_ImageID_Log_Attribute
                        End If
                    Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        If intRowDone_NeedsChild < intRowLog_NeedsChild And intRowLog_NeedsChild > 0 Then
                            intImageiD = cint_ImageID_Bat
                        Else
                            intImageiD = cint_ImageID_Log_Bat
                        End If

                    Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                        If intRowDone_NeedsChild < intRowLog_NeedsChild And intRowLog_NeedsChild > 0 Then
                            intImageiD = cint_ImageID_Class
                        Else
                            intImageiD = cint_ImageID_Log_Class
                        End If

                    Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                        If intRowDone_NeedsChild < intRowLog_NeedsChild And intRowLog_NeedsChild > 0 Then
                            intImageiD = cint_ImageID_RelationType
                        Else
                            intImageiD = cint_ImageID_Log_RelationType
                        End If

                End Select
                objTreeNode_NeedsChildPar.Nodes.Add(semtblT_NeedsChild.Rows(intRowDone_NeedsChild).Item("GUID_Ref").ToString, semtblT_NeedsChild.Rows(intRowDone_NeedsChild).Item("Name_Ref"), intImageiD, intImageiD)
                intRowDone_NeedsChild = intRowDone_NeedsChild + 1
                boolStopTimer = False
            ElseIf boolDone_NeedsChild = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolDone_Responsibility = True And intRowDone_Responsibility < intRowCount_Responsibility Then
                If intRowDone_Responsibility < intRowLog_Responsibility And intRowLog_Responsibility > 0 Then
                    intImageiD = cint_ImageID_Responsibility
                Else
                    intImageiD = cint_ImageID_Log_Responsibility
                End If

                objTreeNode_Responsibilities.Nodes.Add(semtblT_Responsiblity.Rows(intRowDone_Responsibility).Item("GUID_Token_Right").ToString, semtblT_Responsiblity.Rows(intRowDone_Responsibility).Item("Name_Token_Right"), intImageiD, intImageiD)
                intRowDone_Responsibility = intRowDone_Responsibility + 1
                boolStopTimer = False
            ElseIf boolDone_Responsibility = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolDone_Role = True And intRowDone_Role < intRowCount_Role Then
                If intRowDone_Role < intRowLog_Role And intRowLog_Role > 0 Then
                    intImageiD = cint_ImageID_Role
                Else
                    intImageiD = cint_ImageID_Log_Role
                End If

                objTreeNode_Roles.Nodes.Add(semtblT_Role.Rows(intRowDone_Role).Item("GUID_Token_Right").ToString, semtblT_Role.Rows(intRowDone_Role).Item("Name_Token_Right"), intImageiD, intImageiD)
                intRowDone_Role = intRowDone_Role + 1
                boolStopTimer = False

            ElseIf boolDone_Role = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolDone_User = True And intRowDone_User < intRowCount_User Then
                If intRowDone_User < intRowLog_User And intRowLog_User > 0 Then
                    intImageiD = cint_ImageID_User
                Else
                    intImageiD = cint_ImageID_Log_User
                End If

                objTreeNode_Users.Nodes.Add(semtblT_User.Rows(intRowDone_User).Item("GUID_Token_Right").ToString, semtblT_User.Rows(intRowDone_User).Item("Name_Token_Right").ToString, intImageiD, intImageiD)
                intRowDone_User = intRowDone_User + 1
                boolStopTimer = False
            ElseIf boolDone_User = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolDone_Variable = True And intRowDone_Variable < intRowCount_Variable Then
                If intRowDone_Variable < intRowLog_Variable And intRowLog_Variable > 0 Then
                    intImageiD = cint_ImageID_Variable
                Else
                    intImageiD = cint_ImageID_Log_Variable
                End If

                objTreeNode_Var = objTreeNode_Variables.Nodes.Add(dtbl_Variable.Rows(intRowDone_Variable).Item("GUID_Var").ToString, dtbl_Variable.Rows(intRowDone_Variable).Item("Name_Var"), cint_ImageID_Variable, cint_ImageID_Variable)
                If Not IsDBNull(dtbl_Variable.Rows(intRowDone_Variable).Item("Var_val")) Then
                    objTreeNode_Var.Nodes.Add(dtbl_Variable.Rows(intRowDone_Variable).Item("GUID_Var").ToString & "_Val", dtbl_Variable.Rows(intRowDone_Variable).Item("Var_Val"), cint_ImageID_VarVal, cint_ImageID_VarVal)
                End If

                intRowDone_Variable = intRowDone_Variable + 1
                boolStopTimer = False
            ElseIf boolDone_Variable = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolDone_Util = True And intRowDone_Util < intRowCount_Util Then
                If intRowDone_Util < intRowLog_Util And intRowLog_Util > 0 Then
                    intImageiD = cint_ImageID_Util
                Else
                    intImageiD = cint_ImageID_Log_Util
                End If
                strMatUtil = procT_Util.Rows(intRowDone_Util).Item("Name_Token")
                If strMatUtil.Contains(":") = True Then
                    strMatUtil = strMatUtil.Substring(strMatUtil.IndexOf(":") + 2)
                End If
                strMatUtil = procT_Util.Rows(intRowDone_Util).Item("Count") & ": " & strMatUtil

                objTreeNode_Utils.Nodes.Add(procT_Util.Rows(intRowDone_Util).Item("GUID_Things_References").ToString, strMatUtil, intImageiD, intImageiD)
                intRowDone_Util = intRowDone_Util + 1
                boolStopTimer = False
            ElseIf boolDone_Util = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolDone_Material = True And intRowDone_Material < intRowCount_Material Then
                If intRowDone_Material < intRowLog_Material And intRowLog_Material > 0 Then
                    intImageiD = cint_ImageID_Material
                Else
                    intImageiD = cint_ImageID_Log_Material
                End If

                strMatUtil = procT_Material.Rows(intRowDone_Material).Item("Name_Token")
                If strMatUtil.Contains(":") = True Then
                    strMatUtil = strMatUtil.Substring(strMatUtil.IndexOf(":") + 2)
                End If
                strMatUtil = procT_Material.Rows(intRowDone_Material).Item("Count") & ": " & strMatUtil

                objTreeNode_Materials.Nodes.Add(procT_Material.Rows(intRowDone_Material).Item("GUID_Things_References").ToString, strMatUtil, intImageiD, intImageiD)
                intRowDone_Material = intRowDone_Material + 1
                boolStopTimer = False
            ElseIf boolDone_Material = False Then

                boolStopTimer = False
            Else
                intVal_Progressbar = intVal_Progressbar + 1
            End If

            If boolStopTimer = True Then
                TreeView_Refs.ExpandAll()
                intVal_Progressbar = 0
                Timer_References.Stop()

            End If
        Loop Until (Now - dateNow).Milliseconds > 200
        ToolStripProgressBar_References.Value = intVal_Progressbar
    End Sub

    Private Sub ContextMenuStrip_References_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_References.Opening
        Dim objTreeNode As TreeNode
        NewToolStripMenuItem.Enabled = False
        RemoveToolStripMenuItem.Enabled = False
        ProcessItemToolStripMenuItem.Enabled = False
        LogItemToolStripMenuItem.Enabled = False
        CopyNameToolStripMenuItem.Enabled = False
        CopyGUIDToolStripMenuItem.Enabled = False

        objTreeNode = TreeView_Refs.SelectedNode
        If objTreeNode.ImageIndex >= cint_ImageID_Refs And objTreeNode.ImageIndex <= cint_ImageID_Belongings Then
            NewToolStripMenuItem.Enabled = True
            ProcessItemToolStripMenuItem.Enabled = True
            LogItemToolStripMenuItem.Enabled = True
        ElseIf (objTreeNode.ImageIndex >= cint_ImageID_Ref And objTreeNode.ImageIndex <= cint_ImageID_Belonging) Or (objTreeNode.ImageIndex >= cint_ImageID_Log_Ref And objTreeNode.ImageIndex <= cint_ImageID_Log_Belonging) Then
            RemoveToolStripMenuItem.Enabled = True
            CopyNameToolStripMenuItem.Enabled = True
            CopyGUIDToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub ProcessItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessItemToolStripMenuItem.Click
        Dim objTreeNode As TreeNode


        objTreeNode = TreeView_Refs.SelectedNode
        If Not objTreeNode Is Nothing Then
            add_Item_To_ProcessOrLog(objTreeNode, True)
        End If
    End Sub


    Private Sub add_Item_To_ProcessOrLog(ByVal objTreeNode As TreeNode, ByVal boolProcess As Boolean)
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDR_SimpleItem As DataRow
        Dim semtblT_simpleItems As New ds_SemDB.semtbl_TokenDataTable
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_ProcessRef As clsSemItem
        Dim objTreeNodes() As TreeNode
        Dim objSemItems_Selected() As clsSemItem
        Dim intImage As Integer
        Dim intToDo As Integer
        Dim intDone As Integer

        Select Case objTreeNode.ImageIndex
            Case cint_ImageID_Applications
                If boolProcess = True Then
                    intImage = cint_ImageID_Application
                Else
                    intImage = cint_ImageID_Log_Application
                End If
                objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Application, objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                            objDRV_Selected = objDGVR_Selected.DataBoundItem
                            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Application.GUID Then
                                semtblT_simpleItems.Rows.Add(objDRV_Selected.Item("GUID_Token"), _
                                                             objDRV_Selected.Item("Name_Token"), _
                                                             objDRV_Selected.Item("GUID_Type"))
                            Else
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_Application.Name & " aus!", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Next
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            If boolProcess = True Then
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_Process)
                            Else
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_ProcessLog)
                            End If

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_ProcessRef = objTransaction_References.SemItem_ProcessRef
                                objSemItem_Result = objTransaction_References.save_002_SimpleItems(semtblT_simpleItems, _
                                                                                               objLocalConfig.SemItem_RelationType_needs, objSemItem_ProcessRef)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    For Each objDR_SimpleItem In semtblT_simpleItems.Rows
                                        objTreeNodes = objTreeNode_Applications.Nodes.Find(objDR_SimpleItem.Item("GUID_Token").ToString, False)
                                        If objTreeNodes.Count = 0 Then
                                            objTreeNode_Applications.Nodes.Add(objDR_SimpleItem.Item("GUID_Token").ToString, _
                                                                               objDR_SimpleItem.Item("Name_Token"), _
                                                                               intImage, intImage)
                                        End If
                                    Next
                                Else
                                    MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If
                    Else
                        MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_Application.Name & " aus!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case cint_ImageID_Belongings
               
                objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    Select Case objFrmSemManager.SelectedItems_TypeGUID
                        Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                            If boolProcess = True Then
                                intImage = cint_ImageID_Attribute
                            Else
                                intImage = cint_ImageID_Log_Attribute
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                            If boolProcess = True Then
                                intImage = cint_ImageID_RelationType
                            Else
                                intImage = cint_ImageID_Log_RelationType
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            If boolProcess = True Then
                                intImage = cint_ImageID_Bat
                            Else
                                intImage = cint_ImageID_Log_Bat
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                            If boolProcess = True Then
                                intImage = cint_ImageID_Class
                            Else
                                intImage = cint_ImageID_Log_Class
                            End If

                    End Select
                End If
            Case cint_ImageID_Documents

            Case cint_ImageID_Files
                objFrm_FileSystemManagement.Applyable = True
                objFrm_FileSystemManagement.ShowDialog(Me)

            Case cint_ImageID_Folders
                objFrm_FileSystemManagement.Applyable = True
                objFrm_FileSystemManagement.ShowDialog(Me)
            Case cint_ImageID_Groups
                If boolProcess = True Then
                    intImage = cint_ImageID_Group
                Else
                    intImage = cint_ImageID_Log_Group
                End If
                objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Group, objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                            objDRV_Selected = objDGVR_Selected.DataBoundItem
                            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Group.GUID Then
                                semtblT_simpleItems.Rows.Add(objDRV_Selected.Item("GUID_Token"), _
                                                             objDRV_Selected.Item("Name_Token"), _
                                                             objDRV_Selected.Item("GUID_Type"))
                            Else
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_Group.Name & " aus!", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Next
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            If boolProcess = True Then
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_Process)
                            Else
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_ProcessLog)
                            End If

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_ProcessRef = objTransaction_References.SemItem_ProcessRef
                                objSemItem_Result = objTransaction_References.save_002_SimpleItems(semtblT_simpleItems, _
                                                                                               objLocalConfig.SemItem_RelationType_needs_authority, objSemItem_ProcessRef)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    For Each objDR_SimpleItem In semtblT_simpleItems.Rows
                                        objTreeNodes = objTreeNode_Groups.Nodes.Find(objDR_SimpleItem.Item("GUID_Token").ToString, False)
                                        If objTreeNodes.Count = 0 Then
                                            objTreeNode_Groups.Nodes.Add(objDR_SimpleItem.Item("GUID_Token").ToString, _
                                                                               objDR_SimpleItem.Item("Name_Token"), _
                                                                               intImage, intImage)
                                        End If
                                    Next
                                Else
                                    MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If
                    Else
                        MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_Group.Name & " aus!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case cint_ImageID_Manuals
                If boolProcess = True Then
                    intImage = cint_ImageID_Manual
                Else
                    intImage = cint_ImageID_Log_Manual
                End If
                objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Manual, objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                            objDRV_Selected = objDGVR_Selected.DataBoundItem
                            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Manual.GUID Then
                                semtblT_simpleItems.Rows.Add(objDRV_Selected.Item("GUID_Token"), _
                                                             objDRV_Selected.Item("Name_Token"), _
                                                             objDRV_Selected.Item("GUID_Type"))
                            Else
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_Manual.Name & " aus!", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Next
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            If boolProcess = True Then
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_Process)
                            Else
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_ProcessLog)
                            End If

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_ProcessRef = objTransaction_References.SemItem_ProcessRef
                                objSemItem_Result = objTransaction_References.save_002_SimpleItems(semtblT_simpleItems, _
                                                                                               objLocalConfig.SemItem_RelationType_needs, objSemItem_ProcessRef)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    For Each objDR_SimpleItem In semtblT_simpleItems.Rows
                                        objTreeNodes = objTreeNode_Manuals.Nodes.Find(objDR_SimpleItem.Item("GUID_Token").ToString, False)
                                        If objTreeNodes.Count = 0 Then
                                            objTreeNode_Manuals.Nodes.Add(objDR_SimpleItem.Item("GUID_Token").ToString, _
                                                                               objDR_SimpleItem.Item("Name_Token"), _
                                                                               intImage, intImage)
                                        End If
                                    Next
                                Else
                                    MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If
                    Else
                        MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_Manual.Name & " aus!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case cint_ImageID_Medias
                If boolProcess = True Then
                    intImage = cint_ImageID_Media
                Else
                    intImage = cint_ImageID_Log_Media
                End If
                objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Media, objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                            objDRV_Selected = objDGVR_Selected.DataBoundItem
                            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Media.GUID Then
                                semtblT_simpleItems.Rows.Add(objDRV_Selected.Item("GUID_Token"), _
                                                             objDRV_Selected.Item("Name_Token"), _
                                                             objDRV_Selected.Item("GUID_Type"))
                            Else
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_Media.Name & " aus!", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Next
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            If boolProcess = True Then
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_Process)
                            Else
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_ProcessLog)
                            End If

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_ProcessRef = objTransaction_References.SemItem_ProcessRef
                                objSemItem_Result = objTransaction_References.save_002_SimpleItems(semtblT_simpleItems, _
                                                                                               objLocalConfig.SemItem_RelationType_needs, objSemItem_ProcessRef)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    For Each objDR_SimpleItem In semtblT_simpleItems.Rows
                                        objTreeNodes = objTreeNode_Medias.Nodes.Find(objDR_SimpleItem.Item("GUID_Token").ToString, False)
                                        If objTreeNodes.Count = 0 Then
                                            objTreeNode_Medias.Nodes.Add(objDR_SimpleItem.Item("GUID_Token").ToString, _
                                                                               objDR_SimpleItem.Item("Name_Token"), _
                                                                               intImage, intImage)
                                        End If
                                    Next
                                Else
                                    MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If
                    Else
                        MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_Media.Name & " aus!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case cint_ImageID_NeedsChildPar

            Case cint_ImageID_NeedsPar
                If boolProcess = True Then
                    intImage = cint_ImageID_Needs
                Else
                    intImage = cint_ImageID_Log_Needs
                End If
                objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    If boolProcess = True Then
                        objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_Process)
                    Else
                        objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_ProcessLog)
                    End If
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        Select Case objFrmSemManager.SelectedItems_TypeGUID
                            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                intToDo = objFrmSemManager.SelectedRows_Items.Count
                                intDone = 0
                                objSemItems_Selected = Nothing
                                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                                    If objSemItems_Selected Is Nothing Then
                                        intDone = 0
                                    Else
                                        intDone = objSemItems_Selected.Count
                                    End If
                                    ReDim Preserve objSemItems_Selected(intDone)
                                    objSemItems_Selected(intDone) = New clsSemItem



                                    Select Case objFrmSemManager.SelectedItems_TypeGUID
                                        Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                            objSemItems_Selected(intDone).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                                            objSemItems_Selected(intDone).GUID = objDRV_Selected.Item("GUID_Attribute")
                                            objSemItems_Selected(intDone).Name = objDRV_Selected.Item("Name_Attribute")
                                            objSemItems_Selected(intDone).GUID_Parent = objDRV_Selected.Item("GUID_AttributeType")
                                        Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                                            objSemItems_Selected(intDone).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

                                            objSemItems_Selected(intDone).GUID = objDRV_Selected.Item("GUID_RelationType")
                                            objSemItems_Selected(intDone).Name = objDRV_Selected.Item("Name_RelationType")

                                        Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                            objSemItems_Selected(intDone).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                            objSemItems_Selected(intDone).GUID = objDRV_Selected.Item("GUID_Token")
                                            objSemItems_Selected(intDone).Name = objDRV_Selected.Item("Name_Token")
                                            objSemItems_Selected(intDone).GUID_Parent = objDRV_Selected.Item("GUID_Type")
                                        Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                                            objSemItems_Selected(intDone).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                                            objSemItems_Selected(intDone).GUID = objDRV_Selected.Item("GUID_Type")
                                            objSemItems_Selected(intDone).Name = objDRV_Selected.Item("Name_Type")
                                            objSemItems_Selected(intDone).GUID_Parent = objDRV_Selected.Item("GUID_TypeParent")
                                    End Select
                                Next
                                If Not objSemItems_Selected Is Nothing Then

                                    objSemItem_Result = objTransaction_References.save_003_ORRef(objSemItems_Selected, _
                                                                                                 objLocalConfig.SemItem_RelationType_needs)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        For intDone = 0 To objTransaction_References.SemItems_Selected.Count - 1
                                            objTreeNodes = objTreeNode_NeedsPar.Nodes.Find(objTransaction_References.SemItems_Selected(intDone).GUID.ToString, False)
                                            If objTreeNodes.Count = 0 Then
                                                objTreeNode_NeedsPar.Nodes.Add(objTransaction_References.SemItems_Selected(intDone).GUID.ToString, _
                                                                                   objTransaction_References.SemItems_Selected(intDone).Name, _
                                                                                   intImage, intImage)
                                            End If
                                        Next
                                        
                                    Else
                                        objTransaction_References.del_003_ORRef()
                                    End If
                                End If
                                

                            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                        End Select
                    Else
                        MsgBox("Die Process-Ref kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    End If
                    
                End If
            Case cint_ImageID_Refs

            Case cint_ImageID_Responsibilities
                If boolProcess = True Then
                    intImage = cint_ImageID_Responsibility
                Else
                    intImage = cint_ImageID_Log_Responsibility
                End If
                objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_responsibility, objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                            objDRV_Selected = objDGVR_Selected.DataBoundItem
                            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_responsibility.GUID Then
                                semtblT_simpleItems.Rows.Add(objDRV_Selected.Item("GUID_Token"), _
                                                             objDRV_Selected.Item("Name_Token"), _
                                                             objDRV_Selected.Item("GUID_Type"))
                            Else
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_responsibility.Name & " aus!", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Next
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            If boolProcess = True Then
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_Process)
                            Else
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_ProcessLog)
                            End If

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_ProcessRef = objTransaction_References.SemItem_ProcessRef
                                objSemItem_Result = objTransaction_References.save_002_SimpleItems(semtblT_simpleItems, _
                                                                                               objLocalConfig.SemItem_RelationType_needs_authority, objSemItem_ProcessRef)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    For Each objDR_SimpleItem In semtblT_simpleItems.Rows
                                        objTreeNodes = objTreeNode_Responsibilities.Nodes.Find(objDR_SimpleItem.Item("GUID_Token").ToString, False)
                                        If objTreeNodes.Count = 0 Then
                                            objTreeNode_Responsibilities.Nodes.Add(objDR_SimpleItem.Item("GUID_Token").ToString, _
                                                                               objDR_SimpleItem.Item("Name_Token"), _
                                                                               intImage, intImage)
                                        End If
                                    Next
                                Else
                                    MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If
                    Else
                        MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_responsibility.Name & " aus!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case cint_ImageID_Roles
                If boolProcess = True Then
                    intImage = cint_ImageID_Role
                Else
                    intImage = cint_ImageID_Log_Role
                End If
                objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Role, objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                            objDRV_Selected = objDGVR_Selected.DataBoundItem
                            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Role.GUID Then
                                semtblT_simpleItems.Rows.Add(objDRV_Selected.Item("GUID_Token"), _
                                                             objDRV_Selected.Item("Name_Token"), _
                                                             objDRV_Selected.Item("GUID_Type"))
                            Else
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_Role.Name & " aus!", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Next
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            If boolProcess = True Then
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_Process)
                            Else
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_ProcessLog)
                            End If

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_ProcessRef = objTransaction_References.SemItem_ProcessRef
                                objSemItem_Result = objTransaction_References.save_002_SimpleItems(semtblT_simpleItems, _
                                                                                               objLocalConfig.SemItem_RelationType_needs_authority, objSemItem_ProcessRef)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    For Each objDR_SimpleItem In semtblT_simpleItems.Rows
                                        objTreeNodes = objTreeNode_Roles.Nodes.Find(objDR_SimpleItem.Item("GUID_Token").ToString, False)
                                        If objTreeNodes.Count = 0 Then
                                            objTreeNode_Roles.Nodes.Add(objDR_SimpleItem.Item("GUID_Token").ToString, _
                                                                               objDR_SimpleItem.Item("Name_Token"), _
                                                                               intImage, intImage)
                                        End If
                                    Next
                                Else
                                    MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If
                    Else
                        MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_Role.Name & " aus!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case cint_ImageID_Users
                If boolProcess = True Then
                    intImage = cint_ImageID_User
                Else
                    intImage = cint_ImageID_Log_User
                End If
                objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_type_User, objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                            objDRV_Selected = objDGVR_Selected.DataBoundItem
                            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_type_User.GUID Then
                                semtblT_simpleItems.Rows.Add(objDRV_Selected.Item("GUID_Token"), _
                                                             objDRV_Selected.Item("Name_Token"), _
                                                             objDRV_Selected.Item("GUID_Type"))
                            Else
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_type_User.Name & " aus!", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Next
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            If boolProcess = True Then
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_Process)
                            Else
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_ProcessLog)
                            End If

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_ProcessRef = objTransaction_References.SemItem_ProcessRef
                                objSemItem_Result = objTransaction_References.save_002_SimpleItems(semtblT_simpleItems, _
                                                                                               objLocalConfig.SemItem_RelationType_needs_authority, objSemItem_ProcessRef)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    For Each objDR_SimpleItem In semtblT_simpleItems.Rows
                                        objTreeNodes = objTreeNode_Users.Nodes.Find(objDR_SimpleItem.Item("GUID_Token").ToString, False)
                                        If objTreeNodes.Count = 0 Then
                                            objTreeNode_Users.Nodes.Add(objDR_SimpleItem.Item("GUID_Token").ToString, _
                                                                               objDR_SimpleItem.Item("Name_Token"), _
                                                                               intImage, intImage)
                                        End If
                                    Next
                                Else
                                    MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If
                    Else
                        MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_type_User.Name & " aus!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case cint_ImageID_Variables
                If boolProcess = True Then
                    intImage = cint_ImageID_Variable
                Else
                    intImage = cint_ImageID_Log_Variable
                End If
                objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Variable, objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                            objDRV_Selected = objDGVR_Selected.DataBoundItem
                            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Variable.GUID Then
                                semtblT_simpleItems.Rows.Add(objDRV_Selected.Item("GUID_Token"), _
                                                             objDRV_Selected.Item("Name_Token"), _
                                                             objDRV_Selected.Item("GUID_Type"))
                            Else
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_Variable.Name & " aus!", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Next
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            If boolProcess = True Then
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_Process)
                            Else
                                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_ProcessLog)
                            End If

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_ProcessRef = objTransaction_References.SemItem_ProcessRef
                                objSemItem_Result = objTransaction_References.save_002_SimpleItems(semtblT_simpleItems, _
                                                                                               objLocalConfig.SemItem_RelationType_needs, objSemItem_ProcessRef)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    For Each objDR_SimpleItem In semtblT_simpleItems.Rows
                                        objTreeNodes = objTreeNode_Variables.Nodes.Find(objDR_SimpleItem.Item("GUID_Token").ToString, False)
                                        If objTreeNodes.Count = 0 Then
                                            objTreeNode_Variables.Nodes.Add(objDR_SimpleItem.Item("GUID_Token").ToString, _
                                                                               objDR_SimpleItem.Item("Name_Token"), _
                                                                               intImage, intImage)
                                        End If
                                    Next
                                Else
                                    MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Die Applikationen konnten nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If
                    Else
                        MsgBox("Bitte wählen Sie Token des Types " & objLocalConfig.SemItem_Type_Variable.Name & " aus!", MsgBoxStyle.Exclamation)
                    End If
                End If
        End Select
    End Sub
    

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Result As clsSemItem
        Dim semtblT_SimpleItem As New ds_SemDB.semtbl_TokenDataTable

        objTreeNode = TreeView_Refs.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex <= cint_ImageID_Belonging Then
                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_Process)
            Else
                objSemItem_Result = objTransaction_References.save_001_ProcessRef(objSemItem_ProcessLog)

            End If
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                Select Case objTreeNode.ImageIndex
                    Case cint_ImageID_Application, cint_ImageID_Log_Application
                        semtblT_SimpleItem.Rows.Add(New Guid(objTreeNode.Name), objTreeNode.Text, objLocalConfig.SemItem_Type_Application.GUID)

                        objSemItem_Result = objTransaction_References.del_002_SimpleItems(semtblT_SimpleItem, objLocalConfig.SemItem_RelationType_needs)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode.Remove()
                        Else
                            MsgBox("Die Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                        End If
                    Case cint_ImageID_Belonging, cint_ImageID_Log_Belonging

                    Case cint_ImageID_Document, cint_ImageID_Log_Document

                    Case cint_ImageID_File, cint_ImageID_Log_File
                        semtblT_SimpleItem.Rows.Add(New Guid(objTreeNode.Name), objTreeNode.Text, objLocalConfig.SemItem_Type_File.GUID)

                        objSemItem_Result = objTransaction_References.del_002_SimpleItems(semtblT_SimpleItem, objLocalConfig.SemItem_RelationType_needs)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode.Remove()
                        Else
                            MsgBox("Die Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                        End If
                    Case cint_ImageID_Folder, cint_ImageID_Log_Folder
                        semtblT_SimpleItem.Rows.Add(New Guid(objTreeNode.Name), objTreeNode.Text, objLocalConfig.SemItem_type_Folder.GUID)

                        objSemItem_Result = objTransaction_References.del_002_SimpleItems(semtblT_SimpleItem, objLocalConfig.SemItem_RelationType_needs)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode.Remove()
                        Else
                            MsgBox("Die Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                        End If
                    Case cint_ImageID_Group, cint_ImageID_Log_Group
                        semtblT_SimpleItem.Rows.Add(New Guid(objTreeNode.Name), objTreeNode.Text, objLocalConfig.SemItem_Type_Group.GUID)

                        objSemItem_Result = objTransaction_References.del_002_SimpleItems(semtblT_SimpleItem, objLocalConfig.SemItem_RelationType_needs_authority)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode.Remove()
                        Else
                            MsgBox("Die Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                        End If
                    Case cint_ImageID_Manual, cint_ImageID_Log_Manual
                        semtblT_SimpleItem.Rows.Add(New Guid(objTreeNode.Name), objTreeNode.Text, objLocalConfig.SemItem_Type_Manual.GUID)

                        objSemItem_Result = objTransaction_References.del_002_SimpleItems(semtblT_SimpleItem, objLocalConfig.SemItem_RelationType_needs)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode.Remove()
                        Else
                            MsgBox("Die Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                        End If
                    Case cint_ImageID_Media, cint_ImageID_Log_Media
                        semtblT_SimpleItem.Rows.Add(New Guid(objTreeNode.Name), objTreeNode.Text, objLocalConfig.SemItem_Type_Media.GUID)

                        objSemItem_Result = objTransaction_References.del_002_SimpleItems(semtblT_SimpleItem, objLocalConfig.SemItem_RelationType_needs)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode.Remove()
                        Else
                            MsgBox("Die Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                        End If
                    Case cint_ImageID_NeedsChild, cint_ImageID_Log_NeedsChild

                    Case cint_ImageID_Needs, cint_ImageID_Log_Needs

                    Case cint_ImageID_Ref, cint_ImageID_Log_Ref

                    Case cint_ImageID_Responsibility, cint_ImageID_Log_Responsibility
                        semtblT_SimpleItem.Rows.Add(New Guid(objTreeNode.Name), objTreeNode.Text, objLocalConfig.SemItem_Type_responsibility.GUID)

                        objSemItem_Result = objTransaction_References.del_002_SimpleItems(semtblT_SimpleItem, objLocalConfig.SemItem_RelationType_needs_authority)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode.Remove()
                        Else
                            MsgBox("Die Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                        End If
                    Case cint_ImageID_Role, cint_ImageID_Log_Role
                        semtblT_SimpleItem.Rows.Add(New Guid(objTreeNode.Name), objTreeNode.Text, objLocalConfig.SemItem_Type_Role.GUID)

                        objSemItem_Result = objTransaction_References.del_002_SimpleItems(semtblT_SimpleItem, objLocalConfig.SemItem_RelationType_needs_authority)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode.Remove()
                        Else
                            MsgBox("Die Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                        End If
                    Case cint_ImageID_User, cint_ImageID_Log_User
                        semtblT_SimpleItem.Rows.Add(New Guid(objTreeNode.Name), objTreeNode.Text, objLocalConfig.SemItem_type_User.GUID)

                        objSemItem_Result = objTransaction_References.del_002_SimpleItems(semtblT_SimpleItem, objLocalConfig.SemItem_RelationType_needs_authority)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode.Remove()
                        Else
                            MsgBox("Die Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                        End If
                    Case cint_ImageID_Variable, cint_ImageID_Log_Variable
                        semtblT_SimpleItem.Rows.Add(New Guid(objTreeNode.Name), objTreeNode.Text, objLocalConfig.SemItem_Type_Variable.GUID)

                        objSemItem_Result = objTransaction_References.del_002_SimpleItems(semtblT_SimpleItem, objLocalConfig.SemItem_RelationType_needs)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode.Remove()
                        Else
                            MsgBox("Die Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                        End If
                End Select
            Else
                MsgBox("Die Referenz konnte nicht ermittelt werden!", MsgBoxStyle.Exclamation)
            End If
            
        End If
    End Sub


    Private Sub LogItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogItemToolStripMenuItem.Click
        Dim objTreeNode As TreeNode


        objTreeNode = TreeView_Refs.SelectedNode
        If Not objTreeNode Is Nothing Then
            add_Item_To_ProcessOrLog(objTreeNode, False)
        End If
    End Sub


    Private Sub CopyNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyNameToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Refs.SelectedNode
        If Not objTreeNode Is Nothing Then
            Clipboard.SetDataObject(objTreeNode.Text)
        End If
    End Sub

    Private Sub CopyGUIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyGUIDToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        objTreeNode = TreeView_Refs.SelectedNode
        If Not objTreeNode Is Nothing Then
            Clipboard.SetDataObject(objTreeNode.Name)
        End If
    End Sub

    Private Sub TreeView_Refs_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_Refs.DoubleClick
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Parent As TreeNode
        Dim objSemItem_Token As New clsSemItem
        Dim objDRC_Rels As DataRowCollection
        Dim boolOpenEdit As Boolean
        objTreeNode = TreeView_Refs.SelectedNode
        If Not objTreeNode Is Nothing Then
            objTreeNode_Parent = objTreeNode.Parent
            If Not objTreeNode_Parent Is Nothing Then
                boolOpenEdit = False
                objSemItem_Token.GUID = New Guid(objTreeNode.Name)
                objSemItem_Token.Name = objTreeNode.Text
                Select Case objTreeNode_Parent.ImageIndex
                    Case cint_ImageID_Applications, _
                        cint_ImageID_Belongings, _
                        cint_ImageID_Documents, _
                        cint_ImageID_Files, _
                        cint_ImageID_Folders, _
                        cint_ImageID_Groups, _
                        cint_ImageID_Manuals, _
                        cint_ImageID_Refs, _
                        cint_ImageID_Responsibilities, _
                        cint_ImageID_Roles, _
                        cint_ImageID_Users, _
                        cint_ImageID_Variables

                        objSemItem_Token.GUID_Parent = New Guid(objTreeNode_Parent.Name)
                        boolOpenEdit = True
                    Case cint_ImageID_NeedsChildPar, cint_ImageID_NeedsPar
                        If objTreeNode.ImageIndex = cint_ImageID_Bat Or _
                            objTreeNode.ImageIndex = cint_ImageID_Log_Bat Then
                            objDRC_Rels = semtblA_Token.GetData_Token_By_GUID(New Guid(objTreeNode.Name)).Rows
                            If objDRC_Rels.Count > 0 Then
                                objSemItem_Token.GUID_Parent = objDRC_Rels(0).Item("GUID_Type")
                                boolOpenEdit = True
                            End If


                        End If



                End Select

                If boolOpenEdit = True Then
                    objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objFrm_TokenEdit = New frmTokenEdit(objSemItem_Token, objLocalConfig.Globals)
                    objFrm_TokenEdit.ShowDialog(Me)
                    fill_Tree_Ref_Process(objSemItem_Process, objSemItem_ProcessLog)
                End If


            End If
            
        End If
    End Sub
End Class
