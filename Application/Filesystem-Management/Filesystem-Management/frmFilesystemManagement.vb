Imports Sem_Manager
Imports ClassLibrary_ShellWork
Imports System.Net.NetworkInformation
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Public Class frmFilesystemManagement

    Private Const cint_ImageID_Root As Integer = 7
    Private Const cint_ImageID_Server As Integer = 3
    Private Const cint_ImageID_Drive As Integer = 4
    Private Const cint_ImageID_Folder_Closed As Integer = 0
    Private Const cint_ImageID_Folder_Opened As Integer = 1
    Private Const cint_ImageID_ParentLessFiles As Integer = 8

    Private objFrmFileSystemManagement As frmFilesystemManagement
    Private WithEvents objFrmBlobWatcher As frmBlobWatcher
    Private objFrmTokenEdit As frmTokenEdit
    Private objDlg_Attribute_VARCHAR255 As dlgAttribute_Varchar255
    Private objFrmFolderBrowser As frmFolderBrowser
    Private objFrmMenu As frmMenu
    Private objFrm_FileBrowser As frmFileBrowser
    Private objBlobConnection As clsBlobConnection
    Private objShellWork As New clsShellWork

    Private semtbl_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_TokenToken_LeftRight_NoRight As New ds_TokenTableAdapters.proc_TokenToken_LeftRight_NoRightTableAdapter

    Private procA_Server_Active_And_Fileserver As New ds_FilesystemManagementTableAdapters.proc_Server_Active_And_FileserverTableAdapter
    Private procA_related_Folder_L1_L2 As New ds_FilesystemManagementTableAdapters.proc_related_Folder_L1_L2TableAdapter
    Private procA_related_File_By_GUID_Folder As New ds_FilesystemManagementTableAdapters.proc_related_File_By_GUID_FolderTableAdapter
    Private procT_related_File_By_GUID_Folder As New ds_FilesystemManagement.proc_related_File_By_GUID_FolderDataTable
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter


    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter

    Declare Function WNetGetConnection Lib "mpr.dll" Alias "WNetGetConnectionA" (ByVal localName As String, ByVal remoteName As System.Text.StringBuilder, _
                                  ByRef length As Integer) As Integer


    Private objDGVSRC_Files As DataGridViewSelectedRowCollection
    Private objSemItem_FileSystemObjekt As clsSemItem

    Private objGUID_SelectedParent As Guid

    Private objFileWork As clsFileWork

    Private strComputerName As String

    Private objTreeNode_FileSystemObject As TreeNode
    Private objTreeNode_ParentLessFiles As TreeNode
    Private boolApplyable As Boolean

    Public Event applied_FileSystemItem_DataGrid(ByVal objDGVSRC_Files As DataGridViewSelectedRowCollection, ByVal strRowName_GUID As String)
    Public Event applied_FileSystemItem_Tree(ByVal objSemItem_FileSystemObject As clsSemItem)

    Public ReadOnly Property GUID_SelectedParent() As Guid
        Get
            Return objGUID_SelectedParent
        End Get
    End Property
    Public ReadOnly Property DGVSRC_Files() As DataGridViewSelectedRowCollection
        Get
            Return objDGVSRC_Files
        End Get
    End Property
    Public ReadOnly Property SemItem_FileSystemObject() As clsSemItem
        Get
            Return objSemItem_FileSystemObjekt
        End Get
    End Property
    Public Property Applyable() As Boolean
        Get
            Return boolApplyable
        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
            set_ControlAttribus()
        End Set
    End Property

    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        If objLocalConfig Is Nothing Then
            objLocalConfig = New clsLocalConfig_FileManager(New clsGlobals)
        End If

        objFileWork = New clsFileWork(objLocalConfig.Globals)
        set_DBConnection()
        initialize()

    End Sub

    Public Sub New(ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        objLocalConfig = New clsLocalConfig_FileManager(Globals)


        objFileWork = New clsFileWork(objLocalConfig.Globals)
        set_DBConnection()
        initialize()
    End Sub

    Private Sub open_Menu()
        Dim objFrmMenu As frmMenu
        Dim objFrmSemManager As frmSemManager
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItems_Item() As clsSemItem = Nothing
        Dim intCountItems As Integer

        objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)

        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    If objSemItems_Item Is Nothing Then
                        intCountItems = 0

                    Else
                        intCountItems = objSemItems_Item.Count

                    End If
                    ReDim Preserve objSemItems_Item(intCountItems)
                    objSemItems_Item(intCountItems) = New clsSemItem
                    objSemItems_Item(intCountItems).GUID = objDRV_Selected.Item("GUID_Token")
                    objSemItems_Item(intCountItems).Name = objDRV_Selected.Item("Name_Token")
                    objSemItems_Item(intCountItems).GUID_Parent = objDRV_Selected.Item("GUID_Type")
                    objSemItems_Item(intCountItems).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Next
                objFrmMenu = New frmMenu(objSemItems_Item)
                objFrmMenu.ShowDialog(Me)
            Else
                MsgBox("Bitte nur Token auswählen!", MsgBoxStyle.Exclamation)
            End If


        End If


    End Sub

    Private Sub set_DBConnection()
        semtbl_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_Server_Active_And_Fileserver.Connection = objLocalConfig.Connection_Plugin
        procA_related_Folder_L1_L2.Connection = objLocalConfig.Connection_Plugin
        procA_related_File_By_GUID_Folder.Connection = objLocalConfig.Connection_Plugin

        procA_TokenToken_LeftRight_NoRight.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB

        objBlobConnection = New clsBlobConnection(objLocalConfig)
    End Sub

    Private Sub initialize()
        set_ControlAttribus()
        load_Tree()
    End Sub

    Private Sub set_ControlAttribus()
        ApplyToolStripMenuItem.Visible = boolApplyable
        ApplyFilesToolStripMenuItem.Visible = boolApplyable
    End Sub

    Private Sub load_Tree()
        Dim objTreeNode_Root As TreeNode
        TreeView_Folder.Nodes.Clear()
        objTreeNode_Root = TreeView_Folder.Nodes.Add(objLocalConfig.SemItem_Type_Filesystem_Management.GUID.ToString, objLocalConfig.SemItem_Type_Filesystem_Management.Name, cint_ImageID_Root, cint_ImageID_Root)
        objTreeNode_ParentLessFiles = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_File.GUID.ToString, " " & objLocalConfig.SemItem_Type_File.Name & " (not in a folder)", cint_ImageID_ParentLessFiles, cint_ImageID_ParentLessFiles)
        load_Server_With_Drives_And_Shares(objTreeNode_Root)
        objTreeNode_Root.Expand()
        TreeView_Folder.Sort()
    End Sub

    
    Private Sub load_Server_With_Drives_And_Shares(ByVal objTreeNode_Root As TreeNode)
        Dim objDRC_ServerDriveShare As DataRowCollection
        Dim objDR_ServerDriveShare As DataRow

        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Server As TreeNode
        Dim objTreeNode_Drive As TreeNode
        Dim objTreeNode_Folder As TreeNode

        objDRC_ServerDriveShare = procA_Server_Active_And_Fileserver.GetData( _
                                    objLocalConfig.SemItem_Type_Server.GUID, _
                                    objLocalConfig.SemItem_Type_Server_State.GUID, _
                                    objLocalConfig.SemItem_type_Folder.GUID, _
                                    objLocalConfig.SemItem_Type_Drive.GUID, _
                                    objLocalConfig.SemItem_Type_Server_Type.GUID, _
                                    objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                    objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                    objLocalConfig.SemItem_RelationType_Fileshare.GUID, _
                                    objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                    objLocalConfig.SemItem_Token_Active_Server_State.GUID, _
                                    objLocalConfig.SemItem_Token_Fileserver_Server_Type.GUID).Rows

        For Each objDR_ServerDriveShare In objDRC_ServerDriveShare
            objTreeNodes = objTreeNode_Root.Nodes.Find(objDR_ServerDriveShare.Item("GUID_Server").ToString, False)
            If objTreeNodes.Length = 0 Then
                objTreeNode_Server = objTreeNode_Root.Nodes.Add(objDR_ServerDriveShare.Item("GUID_Server").ToString, objDR_ServerDriveShare.Item("Name_Server"), cint_ImageID_Server, cint_ImageID_Server)
            Else
                objTreeNode_Server = objTreeNodes(0)
            End If
            If Not IsDBNull(objDR_ServerDriveShare.Item("GUID_Drive")) Then
                objTreeNodes = objTreeNode_Server.Nodes.Find(objDR_ServerDriveShare.Item("GUID_Drive").ToString, False)
                If objTreeNodes.Length = 0 Then
                    objTreeNode_Drive = objTreeNode_Server.Nodes.Add(objDR_ServerDriveShare.Item("GUID_Drive").ToString, objDR_ServerDriveShare.Item("Name_Drive"), cint_ImageID_Drive, cint_ImageID_Drive)
                Else
                    objTreeNode_Drive = objTreeNodes(0)
                End If
                If (StatusToolStripLable_Ctrl.Visible = False And CheckExistanceToolStripMenuItem.Checked = True) Then
                    check_Existance(objTreeNode_Drive)
                End If
            End If
            If Not IsDBNull(objDR_ServerDriveShare.Item("GUID_Folder")) Then
                objTreeNodes = objTreeNode_Server.Nodes.Find(objDR_ServerDriveShare.Item("GUID_Folder").ToString, False)
                If objTreeNodes.Length = 0 Then
                    objTreeNode_Folder = objTreeNode_Server.Nodes.Add(objDR_ServerDriveShare.Item("GUID_Folder").ToString, objDR_ServerDriveShare.Item("Name_Folder"), cint_ImageID_Folder_Closed, cint_ImageID_Folder_Opened)
                Else
                    objTreeNode_Folder = objTreeNodes(0)
                End If
                If (StatusToolStripLable_Ctrl.Visible = False And CheckExistanceToolStripMenuItem.Checked = True) Then
                    check_Existance(objTreeNode_Folder)
                End If
            End If
        Next
    End Sub

    Private Sub check_Existance(ByVal objTreeNode As TreeNode)

    End Sub

    Private Sub TreeView_Folder_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Folder.AfterSelect
        objTreeNode_FileSystemObject = e.Node
        get_Files()
    End Sub
    Private Sub get_Files()
        Dim objDR_Row As DataRow
        Dim boolShowFiles As Boolean

        procT_related_File_By_GUID_Folder.Clear()
        
        If ToolStripTextBox_Search.Text <> "" Then
            If objLocalConfig.Globals.is_GUID(ToolStripTextBox_Search.Text) Then
                procA_related_File_By_GUID_Folder.Fill(procT_related_File_By_GUID_Folder, _
                                                           objLocalConfig.SemItem_Attribute_Blob.GUID, _
                                                       objLocalConfig.SemItem_Type_File.GUID, _
                                                       objLocalConfig.SemItem_type_Folder.GUID, _
                                                       objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                       Nothing, _
                                                       New Guid(ToolStripTextBox_Search.Text), _
                                                       Nothing)
                BindingSource_Files.DataSource = procT_related_File_By_GUID_Folder
                DataGridView_Files.DataSource = BindingSource_Files
                DataGridView_Files.Columns(0).Visible = False
                DataGridView_Files.Columns(1).Width = 300
                DataGridView_Files.Columns(2).Visible = False
                DataGridView_Files.Columns(3).Visible = False
                DataGridView_Files.Columns(4).Visible = False
            Else
                procA_related_File_By_GUID_Folder.Fill(procT_related_File_By_GUID_Folder, _
                                                           objLocalConfig.SemItem_Attribute_Blob.GUID, _
                                                       objLocalConfig.SemItem_Type_File.GUID, _
                                                       objLocalConfig.SemItem_type_Folder.GUID, _
                                                       objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                       Nothing, _
                                                       Nothing, _
                                                       ToolStripTextBox_Search.Text)
                BindingSource_Files.DataSource = procT_related_File_By_GUID_Folder
                DataGridView_Files.DataSource = BindingSource_Files
                DataGridView_Files.Columns(0).Visible = False
                DataGridView_Files.Columns(1).Width = 300
                DataGridView_Files.Columns(2).Visible = False
                DataGridView_Files.Columns(3).Visible = False
                DataGridView_Files.Columns(4).Visible = False
            End If

        Else
            If Not objTreeNode_FileSystemObject Is Nothing Then
                If objTreeNode_FileSystemObject.ImageIndex = cint_ImageID_Folder_Closed Or _
                    objTreeNode_FileSystemObject.ImageIndex = cint_ImageID_Drive Then

                    procA_related_File_By_GUID_Folder.Fill(procT_related_File_By_GUID_Folder, _
                                                           objLocalConfig.SemItem_Attribute_Blob.GUID, _
                                                       objLocalConfig.SemItem_Type_File.GUID, _
                                                       objLocalConfig.SemItem_type_Folder.GUID, _
                                                       objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                       New Guid(objTreeNode_FileSystemObject.Name), _
                                                       Nothing, _
                                                       Nothing)
                    BindingSource_Files.DataSource = procT_related_File_By_GUID_Folder
                    DataGridView_Files.DataSource = BindingSource_Files
                    DataGridView_Files.Columns(0).Visible = False
                    DataGridView_Files.Columns(1).Width = 300
                    DataGridView_Files.Columns(2).Visible = False
                    DataGridView_Files.Columns(3).Visible = False
                    DataGridView_Files.Columns(4).Visible = False
                ElseIf objTreeNode_FileSystemObject.ImageIndex = cint_ImageID_ParentLessFiles Then
                    procA_related_File_By_GUID_Folder.Fill(procT_related_File_By_GUID_Folder, _
                                                           objLocalConfig.SemItem_Attribute_Blob.GUID, _
                                                       objLocalConfig.SemItem_Type_File.GUID, _
                                                       objLocalConfig.SemItem_type_Folder.GUID, _
                                                       objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                       Nothing, _
                                                       Nothing, _
                                                       Nothing)
                    BindingSource_Files.DataSource = procT_related_File_By_GUID_Folder
                    DataGridView_Files.DataSource = BindingSource_Files
                    DataGridView_Files.Columns(0).Visible = False
                    DataGridView_Files.Columns(1).Width = 300
                    DataGridView_Files.Columns(2).Visible = False
                    DataGridView_Files.Columns(3).Visible = False
                    DataGridView_Files.Columns(4).Visible = False
                Else

                    DataGridView_Files.DataSource = Nothing
                    BindingSource_Files.DataSource = Nothing
                End If


            End If
        End If
        

        ToolStripLabel_Count.Text = DataGridView_Files.Rows.Count
    End Sub
    Private Sub TreeView_Folder_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView_Folder.BeforeExpand
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Root As TreeNode
        
        objTreeNode = e.Node
        If Not objTreeNode Is Nothing Then
            For Each objTreeNode_Root In objTreeNode.Nodes
                get_SubFolders(objTreeNode_Root)
            Next
            
        End If
    End Sub

    Private Sub get_SubFolders(ByVal objTreeNode As TreeNode)
        Dim objTreeNode_Sub As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim objDRC_Folder As DataRowCollection
        Dim objDR_Folder As DataRow

        objDRC_Folder = procA_related_Folder_L1_L2.GetData(objLocalConfig.SemItem_type_Folder.GUID, objLocalConfig.SemItem_RelationType_isSubordinated.GUID, New Guid(objTreeNode.Name)).Rows
        For Each objDR_Folder In objDRC_Folder
            objTreeNodes = objTreeNode.Nodes.Find(objDR_Folder.Item("GUID_Folder_L1").ToString, False)
            If objTreeNodes.Count > 0 Then
                objTreeNode_Sub = objTreeNodes(0)
            Else
                objTreeNode_Sub = objTreeNode.Nodes.Add(objDR_Folder.Item("GUID_Folder_L1").ToString, objDR_Folder.Item("Name_Folder_L1"), cint_ImageID_Folder_Closed, cint_ImageID_Folder_Opened)
            End If
            If Not IsDBNull(objDR_Folder.Item("GUID_Folder_L2")) Then
                objTreeNodes = objTreeNode_Sub.Nodes.Find(objDR_Folder.Item("GUID_Folder_L2").ToString, False)
                If objTreeNodes.Count = 0 Then
                    objTreeNode_Sub.Nodes.Add(objDR_Folder.Item("GUID_Folder_L2").ToString, objDR_Folder.Item("Name_Folder_L2"), cint_ImageID_Folder_Closed, cint_ImageID_Folder_Opened)
                End If
            End If
        Next
    End Sub

    Private Sub DataGridView_Files_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DataGridView_Files.DragDrop
        Dim objDTO As DataObject = TryCast(e.Data, DataObject)
        Dim objObject As Object
        Dim objSemItem_Result As clsSemItem
        Dim objTreeNodes() As TreeNode
        Dim strPath As String
        Dim intCount_ToDo As Integer
        Dim intCount_Done As Integer

        Try
            intCount_ToDo = objDTO.GetFileDropList.Count
            intCount_Done = 0
            For Each objObject In objDTO.GetFileDropList
                strPath = objObject.ToString
                objSemItem_Result = save_File(strPath)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intCount_Done = intCount_Done + 1
                End If
            Next

            load_Tree()
            objTreeNodes = TreeView_Folder.Nodes.Find(objTreeNode_FileSystemObject.Name, True)
            If objTreeNodes.Count > 0 Then
                TreeView_Folder.SelectedNode = objTreeNodes(0)
            End If
        Catch ex As Exception
            MsgBox("Die Datei konnte nicht in die Liste eingefügt werden!", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Function save_File(ByVal strFilePath As String) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_File As clsSemItem
        Dim objDriveInfo As IO.DriveInfo
        Dim boolSemItems As Boolean
        Dim strFileName As String
        Dim intLength As Integer = 255
        Dim objUNC As New System.Text.StringBuilder(intLength)


        If IO.File.Exists(strFilePath) Then
            If strFilePath.Contains(":") Then
                For Each objDriveInfo In IO.DriveInfo.GetDrives
                    If strFilePath.ToLower.StartsWith(objDriveInfo.Name.ToLower) Then
                        If objDriveInfo.DriveType = IO.DriveType.Network Then
                            WNetGetConnection(objDriveInfo.Name.Substring(0, 2), objUNC, intLength)
                            strFilePath = strFilePath.Replace(objDriveInfo.Name.Substring(0, 2), objUNC.ToString)
                        End If
                        Exit For
                    End If
                Next

            End If
            strFileName = strFilePath.Substring(strFilePath.LastIndexOf("\") + 1)

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            


            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_File = New clsSemItem
                objSemItem_File.GUID = Guid.NewGuid
                objSemItem_File.Name = strFileName
                objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_File.Additional1 = strFilePath
                objSemItem_Result = objFileWork.save_Path_Of_FileSystemObject(objSemItem_File)


                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    

                End If
            End If

        ElseIf IO.Directory.Exists(strFilePath) Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        Else

            objSemItem_Result = objLocalConfig.Globals.LogState_Delete
        End If



        Return objSemItem_Result
    End Function

    Private Sub DataGridView_Files_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DataGridView_Files.DragOver
        Dim objDTO As DataObject = TryCast(e.Data, DataObject)
        If objDTO IsNot Nothing AndAlso objDTO.ContainsFileDropList Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub DataGridView_Files_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.F5
                get_Files()
        End Select
    End Sub

    Private Sub DataGridView_Files_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objSemItem_Selected As New clsSemItem

        objDGVR_Selected = DataGridView_Files.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_File")
        objSemItem_Selected.Name = objDRV_Selected.Item("Name_File")
        objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
        objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrmTokenEdit = New frmTokenEdit(DataGridView_Files, objDGVR_Selected.Index, objSemItem_Selected, objLocalConfig.Globals)
        objFrmTokenEdit.ShowDialog(Me)
        load_Tree()
    End Sub

    Private Sub TreeView_Folder_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_Folder.DoubleClick
        Dim objSemItem_Selected As clsSemItem
        Dim objTreeNode As TreeNode
        Dim objTreeNodes() As TreeNode

        objTreeNode = TreeView_Folder.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Drive Or _
                objTreeNode.ImageIndex = cint_ImageID_Folder_Closed Or _
                objTreeNode.ImageIndex = cint_ImageID_Server Then
                objSemItem_Selected = New clsSemItem
                objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                objSemItem_Selected.Name = objTreeNode.Text
                Select Case objTreeNode.ImageIndex
                    Case cint_ImageID_Server
                        objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                    Case cint_ImageID_Drive
                        objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID
                    Case cint_ImageID_Folder_Closed
                        objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID

                End Select

                objFrmTokenEdit = New frmTokenEdit(objSemItem_Selected, objLocalConfig.Globals)
                objFrmTokenEdit.Applyable = boolApplyable
                objFrmTokenEdit.ShowDialog(Me)
                load_Tree()

                objTreeNodes = TreeView_Folder.Nodes.Find(objTreeNode.Name, True)
                If objTreeNodes.Length > 0 Then
                    TreeView_Folder.SelectedNode = objTreeNodes(0)
                End If

            End If
            
        End If
    End Sub

    Private Sub TreeView_Folder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView_Folder.KeyDown
        Dim objTreeNode As TreeNode
        Select Case e.KeyCode
            Case Keys.F5
                objTreeNode = TreeView_Folder.SelectedNode
                Select Case objTreeNode.ImageIndex
                    Case cint_ImageID_Folder_Closed
                        objTreeNode.Nodes.Clear()
                        get_SubFolders(objTreeNode)
                        objTreeNode.Collapse()
                    Case Else
                        load_Tree()
                End Select
        End Select
    End Sub

    Private Sub NewToolStripMenuItem_Tree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem_Tree.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Parent As New clsSemItem
        Dim objSemItem_New As New clsSemItem
        Dim objDRC_TokenToken As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Server As clsSemItem
        Dim strPath As String
        Dim boolCreate As Boolean
        Dim boolBrowse As Boolean

        objTreeNode = TreeView_Folder.SelectedNode

        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Root
                    objDlg_Attribute_VARCHAR255 = New dlgAttribute_Varchar255("new " & objLocalConfig.SemItem_Type_Server.Name, objLocalConfig.Globals)
                    If objDlg_Attribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then
                        objSemItem_New.GUID = Guid.NewGuid
                        objSemItem_New.Name = objDlg_Attribute_VARCHAR255.Value1
                        objSemItem_New.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                        objSemItem_New.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        objDRC_TokenToken = semtbl_Token.GetData_Token_By_Name_And_GUIDType(objSemItem_New.GUID_Parent, objSemItem_New.Name).Rows
                        If objDRC_TokenToken.Count = 0 Then
                            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_New.GUID, objSemItem_New.Name, objSemItem_New.GUID_Parent, True).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                objTreeNode.Nodes.Add(objSemItem_New.GUID.ToString, objSemItem_New.Name, cint_ImageID_Server, cint_ImageID_Server)
                            Else
                                MsgBox("Der Server konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Der Server existiert bereits. Sie müssen einen anderen Namen wählen!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Case cint_ImageID_Server
                    

                    If BrowseToolStripMenuItem.Checked = True Then
                        objSemItem_Parent.GUID = New Guid(objTreeNode.Name)
                        objSemItem_Parent.Name = objTreeNode.Text
                        objSemItem_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                        objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        strPath = objFileWork.get_Path_FileSystemObject(objSemItem_Parent)
                        objSemItem_Server = objFileWork.SemItem_Server
                        objSemItem_Parent.Additional1 = strPath
                        objFrmFolderBrowser = New frmFolderBrowser(objSemItem_Parent, objSemItem_Server.Name)
                        objFrmFolderBrowser.ShowDialog()
                        If objFrmFolderBrowser.DialogResult = Windows.Forms.DialogResult.OK Then
                            add_Folder(objTreeNode, objFrmFolderBrowser.SemItem_Selected, objSemItem_Server)
                        End If
                    Else
                        If MsgBox("Soll ein neues " & objLocalConfig.SemItem_Type_Drive.Name & " erzeugt werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            objSemItem_New.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID
                        Else
                            objSemItem_New.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
                        End If
                        objDlg_Attribute_VARCHAR255 = New dlgAttribute_Varchar255("new " & objLocalConfig.SemItem_Type_Server.Name, objLocalConfig.Globals)
                        If objDlg_Attribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then
                            objSemItem_New.GUID = Guid.NewGuid
                            objSemItem_New.Name = objDlg_Attribute_VARCHAR255.Value1
                            objSemItem_New.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            If objSemItem_New.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID Then
                                objDRC_TokenToken = funcA_TokenToken.GetData_By_GUIDToken_Right_GUIDType_Left_TokenName_Left_GUIDRel(New Guid(objTreeNode.Name), objSemItem_New.Name, objSemItem_New.GUID_Parent, objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows
                            Else
                                objDRC_TokenToken = funcA_TokenToken.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(New Guid(objTreeNode.Name), objSemItem_New.Name, objSemItem_New.GUID_Parent, objLocalConfig.SemItem_RelationType_Fileshare.GUID).Rows
                            End If
                            If objDRC_TokenToken.Count = 0 Then
                                If objSemItem_New.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_New.GUID, New Guid(objTreeNode.Name), objLocalConfig.SemItem_RelationType_isSubordinated.GUID, 0).Rows
                                Else
                                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(New Guid(objTreeNode.Name), objSemItem_New.GUID, objLocalConfig.SemItem_RelationType_Fileshare.GUID, 0).Rows
                                End If

                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                    If objSemItem_New.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID Then
                                        objTreeNode.Nodes.Add(objSemItem_New.GUID.ToString, objSemItem_New.Name, cint_ImageID_Drive, cint_ImageID_Drive)
                                    Else
                                        objTreeNode.Nodes.Add(objSemItem_New.GUID.ToString, objSemItem_New.Name, cint_ImageID_Folder_Closed, cint_ImageID_Folder_Opened)
                                    End If

                                Else
                                    MsgBox("Das Objekt konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Es kann nur ein Objekt des Typs erzeugt werden!", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    End If
                Case cint_ImageID_Drive
                    If BrowseToolStripMenuItem.Checked = True Then
                        objSemItem_Parent = New clsSemItem
                        objSemItem_Parent.GUID = New Guid(objTreeNode.Name)
                        objSemItem_Parent.Name = objTreeNode.Text
                        objSemItem_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID
                        objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        strPath = objFileWork.get_Path_FileSystemObject(objSemItem_Parent)
                        objSemItem_Server = objFileWork.SemItem_Server
                        objSemItem_Parent.Additional1 = strPath & "\"
                        objFrmFolderBrowser = New frmFolderBrowser(objSemItem_Parent, objSemItem_Server.Name)
                        objFrmFolderBrowser.ShowDialog()
                        If objFrmFolderBrowser.DialogResult = Windows.Forms.DialogResult.OK Then
                            add_Folder(objTreeNode, objFrmFolderBrowser.SemItem_Selected, objSemItem_Server)
                        End If
                    End If


                Case cint_ImageID_Folder_Closed
                    boolBrowse = BrowseToolStripMenuItem.Checked
                    If boolBrowse = True Then
                        objSemItem_Parent.GUID = New Guid(objTreeNode.Name)
                        objSemItem_Parent.Name = objTreeNode.Text
                        objSemItem_Parent.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
                        objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        strPath = objFileWork.get_Path_FileSystemObject(objSemItem_Parent)
                        objSemItem_Parent.Additional1 = strPath & "\"
                        objSemItem_Server = objFileWork.SemItem_Server
                        objFrmFolderBrowser = New frmFolderBrowser(objSemItem_Parent, objSemItem_Server.Name)
                        objFrmFolderBrowser.ShowDialog()
                        If objFrmFolderBrowser.DialogResult = Windows.Forms.DialogResult.OK Then
                            add_Folder(objTreeNode, objFrmFolderBrowser.SemItem_Selected, objSemItem_Server)
                        End If
                    Else
                        objDlg_Attribute_VARCHAR255 = New dlgAttribute_Varchar255("new " & objLocalConfig.SemItem_Type_Server.Name, objLocalConfig.Globals)
                        objDlg_Attribute_VARCHAR255.ShowDialog(Me)
                        If objDlg_Attribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then
                            objSemItem_New.GUID = Guid.NewGuid
                            objSemItem_New.Name = objDlg_Attribute_VARCHAR255.Value1
                            objSemItem_New.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
                            objSemItem_New.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objDRC_TokenToken = funcA_TokenToken.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(New Guid(objTreeNode.Name), objSemItem_New.Name, objSemItem_New.GUID_Parent, objLocalConfig.SemItem_RelationType_Fileshare.GUID).Rows

                            If objDRC_TokenToken.Count = 0 Then

                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(New Guid(objTreeNode.Name), objSemItem_New.GUID, objLocalConfig.SemItem_RelationType_Fileshare.GUID, 0).Rows


                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then

                                    objTreeNode.Nodes.Add(objSemItem_New.GUID.ToString, objSemItem_New.Name, cint_ImageID_Folder_Closed, cint_ImageID_Folder_Opened)


                                Else
                                    MsgBox("Der " & objLocalConfig.SemItem_type_Folder.Name & " kann nicht erstellt werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Es kann nur ein " & objLocalConfig.SemItem_type_Folder.Name & " des Typs erzeugt werden!", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    End If


            End Select
        End If
    End Sub

    Private Sub add_Folder(ByVal objTreeNode_Selected As TreeNode, ByVal objSemItem_ToAdd As clsSemItem, ByVal objSemItem_Server As clsSemItem)
        Dim objDRC_Path As DataRowCollection
        Dim objSemItem_Selected As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_FSObject As clsSemItem
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Added As TreeNode
        Dim strPath_Selected As String
        Dim strPaths() As String
        Dim strPath As String
        Dim boolNextPath As Boolean
        Dim boolAdd As Boolean
        Dim boolFirst As Boolean

        objSemItem_Selected = New clsSemItem
        objSemItem_Selected.GUID = New Guid(objTreeNode_Selected.Name)
        objSemItem_Selected.Name = objTreeNode_Selected.Text
        Select Case objTreeNode_Selected.ImageIndex
            Case cint_ImageID_Server
                objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
            Case cint_ImageID_Drive
                objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID
            Case cint_ImageID_Folder_Closed
                objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
        End Select
        objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        objTreeNode_Added = objTreeNode_Selected
        strPath_Selected = objFileWork.get_Path_FileSystemObject(objSemItem_Selected)
        boolAdd = True
        If objSemItem_ToAdd.Additional1.ToLower.StartsWith(strPath_Selected.ToLower) Or objSemItem_Server.Name = objSemItem_Selected.Name Then
            If Not objSemItem_Selected.Name = objSemItem_Server.Name Then
                strPath = objSemItem_ToAdd.Additional1.Substring(strPath_Selected.Length + 1)                
            Else
                strPath = objSemItem_ToAdd.Additional1
            End If

            strPaths = Nothing
            If strPath.Length > 0 Then
                strPaths = strPath.Split("\")
            Else
                boolAdd = False
            End If

            If boolAdd = True And Not strPaths Is Nothing Then
                boolFirst = True
                For Each strPath In strPaths
                    boolNextPath = True

                    If Not strPath = "" Then
                        If strPath.EndsWith(":") Then
                            boolFirst = False
                            strPath = strPath.Replace(":", "")
                            objDRC_Path = funcA_TokenToken.GetData_By_GUIDToken_Right_GUIDType_Left_TokenName_Left_GUIDRel(objSemItem_Server.GUID, strPath, objLocalConfig.SemItem_Type_Drive.GUID, objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows
                            If objDRC_Path.Count = 0 Then
                                objSemItem_FSObject = New clsSemItem
                                objSemItem_FSObject.GUID = Guid.NewGuid
                                objSemItem_FSObject.Name = strPath
                                objSemItem_FSObject.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID
                                objSemItem_FSObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_FSObject.GUID, objSemItem_FSObject.Name, objSemItem_FSObject.GUID_Parent, True).Rows
                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Server.GUID, objSemItem_FSObject.GUID, objLocalConfig.SemItem_RelationType_isSubordinated.GUID, 0).Rows
                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                        objTreeNode_Added = objTreeNode_Added.Nodes.Add(objSemItem_FSObject.GUID.ToString, objSemItem_FSObject.Name, cint_ImageID_Drive, cint_ImageID_Drive)
                                        objSemItem_Selected = objSemItem_FSObject
                                    Else
                                        semprocA_DBWork_Del_Token.GetData(objSemItem_FSObject.GUID)
                                        MsgBox("Der Pfad kann nicht vollständig eingefügt werden!", MsgBoxStyle.Exclamation)
                                        boolNextPath = False
                                    End If
                                Else
                                    MsgBox("Der Pfad kann nicht vollständig eingefügt werden!", MsgBoxStyle.Exclamation)
                                    boolNextPath = False
                                End If
                            Else
                                objSemItem_Selected = New clsSemItem
                                objSemItem_Selected.GUID = objDRC_Path(0).Item("GUID_token_Left")
                                objSemItem_Selected.Name = objDRC_Path(0).Item("Name_Token_Left")
                                objSemItem_Selected.GUID_Parent = objDRC_Path(0).Item("GUID_Type_Left")
                                objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                objTreeNodes = objTreeNode_Selected.Nodes.Find(objSemItem_Selected.GUID.ToString, False)
                                If objTreeNodes.Count > 0 Then
                                    objTreeNode_Added = objTreeNodes(0)
                                Else
                                    MsgBox("Der Pfad kann eingefügt werden, weil das übergeordnete Element nicht erkannt wurde!", MsgBoxStyle.Exclamation)
                                    boolNextPath = 0
                                End If

                            End If
                        Else
                            objSemItem_FSObject = New clsSemItem
                            objSemItem_FSObject.GUID = Guid.NewGuid
                            objSemItem_FSObject.Name = strPath
                            objSemItem_FSObject.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
                            objSemItem_FSObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            If boolFirst = True Then
                                boolFirst = False
                                Select Case objSemItem_Selected.GUID_Parent
                                    Case objLocalConfig.SemItem_Type_Server.GUID
                                        objDRC_Path = funcA_TokenToken.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(objSemItem_Selected.GUID, strPath, objLocalConfig.SemItem_type_Folder.GUID, objLocalConfig.SemItem_RelationType_Fileshare.GUID).Rows
                                        If objDRC_Path.Count = 0 Then
                                            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_FSObject.GUID, objSemItem_FSObject.Name, objSemItem_FSObject.GUID_Parent, True).Rows
                                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Server.GUID, objSemItem_FSObject.GUID, objLocalConfig.SemItem_RelationType_Fileshare.GUID, 0).Rows
                                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                    objTreeNode_Added = objTreeNode_Added.Nodes.Add(objSemItem_FSObject.GUID.ToString, objSemItem_FSObject.Name, cint_ImageID_Folder_Closed, cint_ImageID_Folder_Opened)
                                                    objSemItem_Selected = objSemItem_FSObject
                                                Else

                                                    semprocA_DBWork_Del_Token.GetData(objSemItem_FSObject.GUID)
                                                    MsgBox("Der Pfad kann nicht vollständig eingefügt werden!", MsgBoxStyle.Exclamation)
                                                    boolNextPath = False
                                                End If

                                            Else
                                                MsgBox("Der Pfad kann nicht vollständig eingefügt werden!", MsgBoxStyle.Exclamation)
                                                boolNextPath = False
                                            End If
                                        Else
                                            objSemItem_Selected = New clsSemItem
                                            objSemItem_Selected.GUID = objDRC_Path(0).Item("GUID_token_Left")
                                            objSemItem_Selected.Name = objDRC_Path(0).Item("Name_Token_Left")
                                            objSemItem_Selected.GUID_Parent = objDRC_Path(0).Item("GUID_Type_Left")
                                            objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                            objTreeNodes = objTreeNode_Selected.Nodes.Find(objSemItem_Selected.GUID.ToString, False)
                                            If objTreeNodes.Count > 0 Then
                                                objTreeNode_Added = objTreeNodes(0)
                                            Else
                                                MsgBox("Der Pfad kann eingefügt werden, weil das übergeordnete Element nicht erkannt wurde!", MsgBoxStyle.Exclamation)
                                                boolNextPath = 0
                                            End If
                                        End If
                                    Case objLocalConfig.SemItem_Type_Drive.GUID, objLocalConfig.SemItem_type_Folder.GUID
                                        objDRC_Path = funcA_TokenToken.GetData_By_GUIDToken_Right_GUIDType_Left_TokenName_Left_GUIDRel(objSemItem_Selected.GUID, strPath, objLocalConfig.SemItem_type_Folder.GUID, objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows
                                        If objDRC_Path.Count = 0 Then
                                            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_FSObject.GUID, objSemItem_FSObject.Name, objSemItem_FSObject.GUID_Parent, True).Rows
                                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_FSObject.GUID, objSemItem_Selected.GUID, objLocalConfig.SemItem_RelationType_isSubordinated.GUID, 0).Rows
                                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                    objTreeNode_Added = objTreeNode_Added.Nodes.Add(objSemItem_FSObject.GUID.ToString, objSemItem_FSObject.Name, cint_ImageID_Folder_Closed, cint_ImageID_Folder_Opened)
                                                    objSemItem_Selected = objSemItem_FSObject
                                                Else

                                                    semprocA_DBWork_Del_Token.GetData(objSemItem_FSObject.GUID)
                                                    MsgBox("Der Pfad kann nicht vollständig eingefügt werden!", MsgBoxStyle.Exclamation)
                                                    boolNextPath = False
                                                End If
                                            Else
                                                MsgBox("Der Pfad kann nicht vollständig eingefügt werden!", MsgBoxStyle.Exclamation)
                                                boolNextPath = False
                                            End If
                                        Else
                                            objSemItem_Selected = New clsSemItem
                                            objSemItem_Selected.GUID = objDRC_Path(0).Item("GUID_token_Left")
                                            objSemItem_Selected.Name = objDRC_Path(0).Item("Name_Token_Left")
                                            objSemItem_Selected.GUID_Parent = objDRC_Path(0).Item("GUID_Type_Left")
                                            objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                            objTreeNodes = objTreeNode_Selected.Nodes.Find(objSemItem_Selected.GUID.ToString, False)
                                            If objTreeNodes.Count > 0 Then
                                                objTreeNode_Added = objTreeNodes(0)
                                            Else
                                                MsgBox("Der Pfad kann eingefügt werden, weil das übergeordnete Element nicht erkannt wurde!", MsgBoxStyle.Exclamation)
                                                boolNextPath = 0
                                            End If
                                        End If
                                    Case Else
                                        MsgBox("Der Pfad kann eingefügt werden, weil das übergeordnete Element nicht erkannt wurde!", MsgBoxStyle.Exclamation)
                                        boolNextPath = False
                                End Select
                            Else
                                
                                objDRC_Path = funcA_TokenToken.GetData_By_GUIDToken_Right_GUIDType_Left_TokenName_Left_GUIDRel(objSemItem_Selected.GUID, strPath, objLocalConfig.SemItem_type_Folder.GUID, objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows
                                If objDRC_Path.Count = 0 Then
                                    objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_FSObject.GUID, objSemItem_FSObject.Name, objSemItem_FSObject.GUID_Parent, True).Rows
                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_FSObject.GUID, objSemItem_Selected.GUID, objLocalConfig.SemItem_RelationType_isSubordinated.GUID, 0).Rows
                                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                            objTreeNode_Added = objTreeNode_Added.Nodes.Add(objSemItem_FSObject.GUID.ToString, objSemItem_FSObject.Name, cint_ImageID_Folder_Closed, cint_ImageID_Folder_Opened)
                                            objSemItem_Selected = objSemItem_FSObject
                                        Else

                                            semprocA_DBWork_Del_Token.GetData(objSemItem_FSObject.GUID)
                                            MsgBox("Der Pfad kann nicht vollständig eingefügt werden!", MsgBoxStyle.Exclamation)
                                            boolNextPath = False
                                        End If
                                    Else
                                        MsgBox("Der Pfad kann nicht vollständig eingefügt werden!", MsgBoxStyle.Exclamation)
                                        boolNextPath = False
                                    End If
                                Else
                                    objSemItem_Selected = New clsSemItem
                                    objSemItem_Selected.GUID = objDRC_Path(0).Item("GUID_token_Left")
                                    objSemItem_Selected.Name = objDRC_Path(0).Item("Name_Token_Left")
                                    objSemItem_Selected.GUID_Parent = objDRC_Path(0).Item("GUID_Type_Left")
                                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                    objTreeNodes = objTreeNode_Added.Nodes.Find(objSemItem_Selected.GUID.ToString, False)
                                    If objTreeNodes.Count > 0 Then
                                        objTreeNode_Added = objTreeNodes(0)
                                    Else
                                        MsgBox("Der Pfad kann eingefügt werden, weil das übergeordnete Element nicht erkannt wurde!", MsgBoxStyle.Exclamation)
                                        boolNextPath = 0
                                    End If
                                End If
                            End If


                        End If
                    Else
                        boolNextPath = False
                    End If
                    If boolNextPath = False Then
                        Exit For
                    End If
                Next
            End If
        Else

            MsgBox("Es wurde kein gültiger Pfad übergeben!", MsgBoxStyle.Exclamation)


        End If


    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Folder.SelectedNode
        If Not objTreeNode Is Nothing Then
            If Not objTreeNode.ImageIndex = cint_ImageID_Root Then
                DialogResult = Windows.Forms.DialogResult.OK
                objSemItem_FileSystemObjekt = New clsSemItem
                objSemItem_FileSystemObjekt.GUID = New Guid(objTreeNode.Name)
                objSemItem_FileSystemObjekt.Name = objTreeNode.Text
                objSemItem_FileSystemObjekt.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                Select Case objTreeNode.ImageIndex
                    Case cint_ImageID_Server
                        objSemItem_FileSystemObjekt.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                    Case cint_ImageID_Drive
                        objSemItem_FileSystemObjekt.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID
                    Case cint_ImageID_Folder_Closed
                        objSemItem_FileSystemObjekt.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
                End Select
                objGUID_SelectedParent = objSemItem_FileSystemObjekt.GUID_Parent
                RaiseEvent applied_FileSystemItem_Tree(objSemItem_FileSystemObjekt)

                Me.Hide()
            End If
            
        End If
    End Sub

    Private Sub ApplyFilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyFilesToolStripMenuItem.Click


        If DataGridView_Files.SelectedRows.Count > 0 Then
            objDGVSRC_Files = DataGridView_Files.SelectedRows
            DialogResult = Windows.Forms.DialogResult.OK
            objGUID_SelectedParent = objLocalConfig.SemItem_Type_File.GUID
            RaiseEvent applied_FileSystemItem_DataGrid(objDGVSRC_Files, "GUID_Token")
            Me.Hide()

        Else

            objDGVSRC_Files = Nothing
        End If

    End Sub

    Private Sub ContextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Nodes(0) As clsSemItem


        objTreeNode = TreeView_Folder.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Folder_Closed Then
                objSemItem_Nodes(0) = New clsSemItem
                objSemItem_Nodes(0).GUID = New Guid(objTreeNode.Name)
                objSemItem_Nodes(0).Name = objTreeNode.Text
                objSemItem_Nodes(0).GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
                objSemItem_Nodes(0).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objFrmMenu = New frmMenu(objSemItem_Nodes)
                objFrmMenu.ShowDialog(Me)

            End If
        End If
    End Sub

    Private Sub NewToolStripMenuItem_DataGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem_DataGrid.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_FileSystemObject As New clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_Folders As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_File As New clsSemItem
        Dim strPath As String
        Dim strFile As String
        Dim intCount_Files As Integer
        Dim intDone_Files As Integer

        objTreeNode = TreeView_Folder.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Folder_Closed Or _
                objTreeNode.ImageIndex = cint_ImageID_Drive Then
                objSemItem_FileSystemObject.GUID = New Guid(objTreeNode.Name)
                objSemItem_FileSystemObject.Name = objTreeNode.Text
                If objTreeNode.ImageIndex = cint_ImageID_Folder_Closed Then
                    objSemItem_FileSystemObject.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
                Else
                    objSemItem_FileSystemObject.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID
                End If

                objSemItem_FileSystemObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                strPath = objFileWork.get_Path_FileSystemObject(objSemItem_FileSystemObject)
                objFrm_FileBrowser = New frmFileBrowser(strPath)
                objFrm_FileBrowser.ShowDialog(Me)
                If objFrm_FileBrowser.DialogResult = Windows.Forms.DialogResult.OK Then
                    intCount_Files = objFrm_FileBrowser.DGVSRC_Selected.Count
                    intDone_Files = 0
                    For Each objDGVR_Selected In objFrm_FileBrowser.DGVSRC_Selected
                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                        strFile = objDRV_Selected.Item("File")
                        objDRC_Folders = funcA_TokenToken.GetData_By_GUIDToken_Right_GUIDType_Left_TokenName_Left_GUIDRel(objSemItem_FileSystemObject.GUID, _
                                                                                                                          strFile, _
                                                                                                                          objLocalConfig.SemItem_Type_File.GUID, _
                                                                                                                          objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows
                        If objDRC_Folders.Count = 0 Then
                            objSemItem_File.GUID = Guid.NewGuid
                            objSemItem_File.Name = strFile
                            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_File.GUID, objSemItem_File.Name, objSemItem_File.GUID_Parent, True).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_File.GUID, objSemItem_FileSystemObject.GUID, objLocalConfig.SemItem_RelationType_isSubordinated.GUID, 0).Rows
                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                    intDone_Files = intDone_Files + 1
                                Else
                                    semprocA_DBWork_Del_Token.GetData(objSemItem_File.GUID)
                                End If
                            End If
                        Else
                            intDone_Files = intDone_Files + 1
                        End If
                    Next
                End If
            End If
        End If
        get_Files()
    End Sub

    Private Sub ContextMenuStrip_DataGrid_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_DataGrid.Opening
        Dim objTreeNode As TreeNode
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim boolCreateBlob As Boolean
        Dim boolDownloadBlob As Boolean

        NewToolStripMenuItem_DataGrid.Enabled = False
        CreateBlobToolStripMenuItem.Enabled = False
        OpenToolStripMenuItem.Enabled = False
        DownloadToolStripMenuItem.Enabled = False
        XputBackToFSToolStripMenuItem.Enabled = False
        GetMetaToolStripMenuItem.Enabled = False
        objTreeNode = TreeView_Folder.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Folder_Closed Or _
                objTreeNode.ImageIndex = cint_ImageID_Drive Then
                NewToolStripMenuItem_DataGrid.Enabled = True

            End If
        End If
        If DataGridView_Files.SelectedRows.Count > 0 Then
            boolCreateBlob = False
            boolDownloadBlob = False

            For Each objDGVR_Selected In DataGridView_Files.SelectedRows
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                Try
                    If Not IsDBNull(objDRV_Selected.Item("is Blob")) Then
                        If objDRV_Selected.Item("is Blob") = False Then
                            boolCreateBlob = True
                        Else
                            boolDownloadBlob = True
                        End If
                    Else
                        boolCreateBlob = True
                    End If
                Catch ex As Exception
                    Exit For
                End Try
                

                
            Next
            If boolCreateBlob = True Then
                CreateBlobToolStripMenuItem.Enabled = True
            End If

            If boolDownloadBlob = True Then
                XputBackToFSToolStripMenuItem.Enabled = True
                DownloadToolStripMenuItem.Enabled = True
                GetMetaToolStripMenuItem.Enabled = True
            End If

            If DataGridView_Files.SelectedRows.Count = 1 Then
                OpenToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Function is_File_Locked(ByVal strFile As String) As Boolean
        Dim boolResult As Boolean
        Dim objFileStream As IO.FileStream

        Try
            objFileStream = New IO.FileStream(strFile, IO.FileMode.Open)
            objFileStream.Close()
            boolResult = False
        Catch ex As Exception
            boolResult = True
        End Try

        Return boolResult
    End Function

    Private Sub CopyPathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyPathToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_File As New clsSemItem
        Dim strPath As String = ""

        For Each objDGVR_Selected In DataGridView_Files.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
            objSemItem_File.Name = objDRV_Selected.Item("Name_File")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            If strPath = "" Then
                strPath = strPath & objFileWork.get_Path_FileSystemObject(objSemItem_File)
            Else
                strPath = strPath & vbCrLf & objFileWork.get_Path_FileSystemObject(objSemItem_File)
            End If
        Next
        Clipboard.SetDataObject(strPath)
    End Sub


    Private Sub CreateBlobToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateBlobToolStripMenuItem.Click
        Dim objSemItem_File As New clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_Blob As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim intCount_ToDo As Integer
        Dim intCount_Done As Integer
        Dim boolCreateBlob As Boolean

        intCount_ToDo = DataGridView_Files.SelectedRows.Count
        intCount_Done = 0
        For Each objDGVR_Selected In DataGridView_Files.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
            objSemItem_File.Name = objDRV_Selected.Item("Name_File")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_File.Additional1 = objFileWork.get_Path_FileSystemObject(objSemItem_File)
            objDRC_Blob = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_File.GUID, _
                                                                                                         objLocalConfig.SemItem_Attribute_Blob.GUID).Rows
            boolCreateBlob = True
            If objDRC_Blob.Count > 0 Then
                If objDRC_Blob(0).Item("Val_Bit") = True Then
                    boolCreateBlob = False
                End If


            End If
            If boolCreateBlob = True Then
                If IO.File.Exists(objSemItem_File.Additional1) Then
                    If is_File_Locked(objSemItem_File.Additional1) = False Then
                        objSemItem_Result = objBlobConnection.save_File_To_Blob(objSemItem_File, objSemItem_File.Additional1)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                            Try
                                IO.File.Delete(objSemItem_File.Additional1)
                                intCount_Done = intCount_Done + 1
                            Catch ex As Exception

                                MsgBox("die Datei kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                            End Try




                        Else
                            MsgBox("Die Datei kann nicht in der Datenbank gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Die Datei ist gelockt!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Die Datei existiert nicht!", MsgBoxStyle.Exclamation)
                End If
            End If
        Next

        If intCount_Done < intCount_ToDo Then
            MsgBox("Es konnten nur " & intCount_Done & " von " & intCount_ToDo & " Dateien gespeichert werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub XputBackToFSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XputBackToFSToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intCount_ToDo As Integer
        Dim intCount_Done As Integer

        intCount_ToDo = DataGridView_Files.SelectedRows.Count
        intCount_Done = 0

        For Each objDGVR_Selected In DataGridView_Files.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
            objSemItem_File.Name = objDRV_Selected.Item("Name_File")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_File.Additional1 = objFileWork.get_Path_FileSystemObject(objSemItem_File, False)
            If IO.File.Exists(objSemItem_File.Additional1) = False Then
                objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, objSemItem_File.Additional1)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objBlobConnection.del_Blob(objSemItem_File)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        intCount_Done = intCount_Done + 1
                    End If
                End If
            End If
        Next

        If intCount_Done < intCount_ToDo Then
            MsgBox("Es konnten nur " & intCount_Done & " von " & intCount_ToDo & " Dateien wiederhergestellt werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ContextMenuStrip_Tree_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Tree.Opening
        Dim objTreeNode As TreeNode

        Open_Tree_ToolStripMenuItem1.Enabled = False
        objTreeNode = TreeView_Folder.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Drive Or _
                objTreeNode.ImageIndex = cint_ImageID_Folder_Closed Then
                Open_Tree_ToolStripMenuItem1.Enabled = True
            End If
        End If
    End Sub

    
    Private Sub Open_Tree_ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Open_Tree_ToolStripMenuItem1.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_FileSystemObject As New clsSemItem

        objTreeNode = TreeView_Folder.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Drive Or _
                objTreeNode.ImageIndex = cint_ImageID_Folder_Closed Then

                objSemItem_FileSystemObject.GUID = New Guid(objTreeNode.Name)
                objSemItem_FileSystemObject.Name = objTreeNode.Text

                Select Case objTreeNode.ImageIndex
                    Case cint_ImageID_Drive
                        objSemItem_FileSystemObject.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID
                    Case cint_ImageID_Folder_Closed
                        objSemItem_FileSystemObject.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
                End Select
                objSemItem_FileSystemObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_FileSystemObject.Additional1 = objFileWork.get_Path_FileSystemObject(objSemItem_FileSystemObject)

                objShellWork.start_Process(objSemItem_FileSystemObject.Additional1, Nothing, objSemItem_FileSystemObject.Additional1, False, False)
            End If

        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        
        Dim boolBlob As Boolean


        If DataGridView_Files.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Files.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
            objSemItem_File.Name = objDRV_Selected.Item("Name_File")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objFileWork.open_FileSystemObject(objSemItem_File)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox(objSemItem_Result.Additional1, MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub StartBlobWatcherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartBlobWatcherToolStripMenuItem.Click
        objFrmBlobWatcher = New frmBlobWatcher(objLocalConfig)
        Me.Hide()
        objFrmBlobWatcher.ShowDialog(Me)
        If objFrmBlobWatcher.SemItem_Result.GUID = objLocalConfig.Globals.LogState_Relation.GUID Then
            MsgBox("Der Blob-Watcher arbeitet bereits!", MsgBoxStyle.Exclamation)
        ElseIf objFrmBlobWatcher.SemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Beim Starten des Blob-Watchers ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
        End If
        Me.Show()

    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click
        open_Menu()
    End Sub

    Private Sub DownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_File As New clsSemItem
        Dim intToDo As Integer
        Dim intDone As Integer
        Dim strPath As String

        intToDo = DataGridView_Files.SelectedRows.Count
        intDone = 0

        If FolderBrowserDialog_Download.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            strPath = FolderBrowserDialog_Download.SelectedPath

            For Each objDGVR_Selected In DataGridView_Files.SelectedRows
                objDRV_Selected = objDGVR_Selected.DataBoundItem

                If objDRV_Selected.Item("is Blob") = True Then
                    Try
                        objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
                        objSemItem_File.Name = objDRV_Selected.Item("Name_File")
                        objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_Filesystem_Management.GUID
                        objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath & "\" & objSemItem_File.Name)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intDone = intDone + 1
                        End If
                    Catch ex As Exception

                    End Try
                End If
            Next
            If intDone < intToDo Then
                MsgBox("Es konnten leider nur " & intDone & " von " & intToDo & " Dateien gespeichert werden.", MsgBoxStyle.Information)
            Else
                MsgBox("Alle Dateien wurden gespeichert.", MsgBoxStyle.Information)
            End If
        End If


        
    End Sub

    Private Sub FileSizesBlobsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetaBlobsToolStripMenuItem.Click
        Dim objSemItem_Result As clsSemItem
        objSemItem_Result = objBlobConnection.upd_Meta_All_Blos()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Es konnten nur " & objSemItem_Result.Additional1 & " Blobs upgedatete werden!", MsgBoxStyle.Exclamation)
        Else
            MsgBox("Alle Blobs wurden upgedated", MsgBoxStyle.Information)
        End If

    End Sub

    
    Private Sub ToolStripTextBox_Search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Search.TextChanged
        If ToolStripTextBox_Search.Text <> "" Then

            ToolStripButton_Search.Enabled = True
            ToolStripButton_ClearSearch.Enabled = False

        Else
            clear_Search()
        End If
    End Sub

    Private Sub clear_Search()
        ToolStripButton_Search.Enabled = False
        ToolStripButton_ClearSearch.Enabled = False
        TreeView_Folder.Enabled = True

        get_Files()
    End Sub

    Private Sub ToolStripButton_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Search.Click
        If ToolStripTextBox_Search.Text <> "" Then
            TreeView_Folder.Enabled = False
            get_Files()
        Else
            clear_Search()
        End If
    End Sub

    Private Sub TreeView_Folder_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView_Folder.MouseClick
        If TreeView_Folder.Enabled = False Then
            MsgBox("Bitte setzen Sie die Dateisuche zurück!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub GetMetaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetMetaToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intToDo As Integer
        Dim intDone As Integer

        intToDo = DataGridView_Files.Rows.Count
        intDone = 0

        For Each objDGVR_Selected In DataGridView_Files.Rows
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            If objDRV_Selected.Item("is Blob") Then
                objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
                objSemItem_File.Name = objDRV_Selected.Item("Name_File")
                objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objBlobConnection.upd_BlobHash(objSemItem_File)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If
            End If
        Next

    End Sub
End Class
