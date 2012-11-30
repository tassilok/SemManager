Imports Sem_Manager
Imports System.IO
Public Class frmFolderBrowser
    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Folder_Closed As Integer = 1
    Private Const cint_ImageID_Folder_Opened As Integer = 2
    Private Const cint_ImageID_Drive As Integer = 3
    Private Const cint_ImageID_DriveRoot As Integer = 4

    Private dtbl_Tree As New ds_FilesystemManagement.dtblTreeDataTable

    Private objSemItem_Root As clsSemItem

    Private objTreeNode_Root As TreeNode
    Private objTreeNode_Root_Drives As TreeNode

    Private objSemItem_Selected As clsSemItem

    Private objThread_Folders As Threading.Thread

    Private strName_Server As String

    Private boolReading As Boolean
    Public ReadOnly Property SemItem_Selected() As clsSemItem
        Get
            Return objSemItem_Selected
        End Get
    End Property
    Public Sub New(ByVal SemItem_Root As clsSemItem, ByVal Name_Server As String)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Root = SemItem_Root
        strName_Server = Name_Server

        initialize_Tree()
        TreeView_Folder.Sort()
    End Sub

    Private Sub initialize_Tree()
        Dim objDriveInfos() As IO.DriveInfo
        Dim objDriveInfo As IO.DriveInfo
        Dim objGUID_Root As Guid



        dtbl_Tree.Rows.Add(Nothing, objLocalConfig.SemItem_type_Folder.GUID, objLocalConfig.SemItem_type_Folder.Name, cint_ImageID_Root, cint_ImageID_Root, False, Nothing, False, 0)
        If objSemItem_Root.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID Then
            If Environment.MachineName.ToLower = strName_Server.ToLower Then

                dtbl_Tree.Rows.Add(Nothing, objLocalConfig.SemItem_Type_Drive.GUID, objLocalConfig.SemItem_Type_Drive.Name, cint_ImageID_DriveRoot, cint_ImageID_DriveRoot, False, Nothing, False, 0)

                objDriveInfos = IO.DriveInfo.GetDrives()
                For Each objDriveInfo In objDriveInfos
                    If Not objDriveInfo.DriveType = DriveType.Network Then
                        objGUID_Root = Guid.NewGuid
                        dtbl_Tree.Rows.Add(objLocalConfig.SemItem_Type_Drive.GUID, objGUID_Root, objDriveInfo.RootDirectory.FullName, cint_ImageID_Drive, cint_ImageID_Drive, True, objDriveInfo.RootDirectory.FullName, False, 1)
                    End If

                Next
            End If
        End If
        
        If IO.Directory.Exists(objSemItem_Root.Additional1) Then
            dtbl_Tree.Rows.Add(objLocalConfig.SemItem_type_Folder.GUID, objSemItem_Root.GUID, objSemItem_Root.Additional1, cint_ImageID_Folder_Closed, cint_ImageID_Folder_Opened, True, objSemItem_Root.Additional1, False, 1)
        End If

        boolReading = True
        objThread_Folders = New Threading.Thread(AddressOf get_L1)
        objThread_Folders.Start()
        Timer_Browse.Start()
    End Sub
    Private Sub get_L1()
        Dim objDRs_ToScan() As DataRow
        Dim objDR_ToScan As DataRow
        Dim objDRs_Found() As DataRow
        Dim objGUID As Guid
        Dim strPath As String
        Dim strFolders() As String
        Dim strFolder As String
        Dim strFolderShort As String

        Do

            objDRs_ToScan = dtbl_Tree.Select("ToScan=1", "Level ASC")

            For Each objDR_ToScan In objDRs_ToScan
                strPath = objDR_ToScan.Item("Path")
                If Directory.Exists(strPath) = True Then
                    Try
                        strFolders = Directory.GetDirectories(strPath)
                        If strFolders.Length = 0 Then
                            objDR_ToScan.Item("ToScan") = False
                        End If

                        For Each strFolder In strFolders
                            strFolderShort = strFolder.Substring(strFolder.LastIndexOf("\") + 1)

                            objDRs_Found = dtbl_Tree.Select("GUID_Node_Parent='" & objDR_ToScan.Item("GUID_Node").ToString & "' AND Text='" & strFolderShort & "'")
                            If objDRs_Found.Count > 0 Then
                                If objDRs_Found(0).Item("ToScan") = 1 Then
                                    get_L2(objDRs_Found(0).Item("GUID_Node"), strFolder, objDRs_Found(0).Item("Level") + 1)
                                    objDRs_Found(0).Item("ToScan") = 0
                                Else
                                    objDR_ToScan.Item("ToScan") = 0
                                End If
                            Else
                                objGUID = Guid.NewGuid
                                get_L2(objGUID, strFolder, objDR_ToScan.Item("Level") + 2)
                                dtbl_Tree.Rows.Add(objDR_ToScan.Item("GUID_Node"), objGUID, strFolderShort, cint_ImageID_Folder_Closed, cint_ImageID_Folder_Opened, 0, strFolder, False, objDR_ToScan.Item("Level") + 1)
                            End If


                        Next
                    Catch ex As Exception
                        objDR_ToScan.Item("ToScan") = False
                    End Try
                    
                End If
            Next
            objDRs_ToScan = dtbl_Tree.Select("ToScan=1", "Level ASC")

        Loop Until objDRs_ToScan.Length = 0
        boolReading = False
    End Sub

    Private Sub get_L2(ByVal objGUID_Parent As Guid, ByVal strPath As String, ByVal intLevel As Integer)
        Dim objDRs_Found() As DataRow
        Dim objDR_Found As DataRow
        Dim objGUID As Guid
        Dim strFolders() As String
        Dim strFolder As String
        Dim strFolderShort As String

        If Directory.Exists(strPath) = True Then
            Try
                strFolders = Directory.GetDirectories(strPath)

                For Each strFolder In strFolders
                    strFolderShort = strFolder.Substring(strFolder.LastIndexOf("\") + 1)
                    objDRs_Found = dtbl_Tree.Select("GUID_Node_Parent='" & objGUID_Parent.ToString & "' AND Text='" & strFolderShort & "'")
                    If objDRs_Found.Count = 0 Then
                        objGUID = Guid.NewGuid
                        dtbl_Tree.Rows.Add(objGUID_Parent, objGUID, strFolderShort, cint_ImageID_Folder_Closed, cint_ImageID_Folder_Opened, True, strFolder, False, intLevel)
                    End If


                Next
            Catch ex As Exception

            End Try

        End If

    End Sub
    'Private Sub get_L1()
    '    Dim objTreeNodes() As TreeNode
    '    Dim objTreeNode_Sub As TreeNode
    '    Dim strFolders() As String
    '    Dim strFolder As String
    '    Dim strFolderShort As String
    '    Dim i

    '    ReDim Preserve dtbls_Tree(intScanID)
    '    dtbls_Tree(intScanID) = New ds_FilesystemManagement.dtblTreeDataTable
    '    dtbls_Tree(intScanID).Clear()

    '    For i = 0 To objTreeNodes_Start.Count - 1
    '        Try
    '            strFolders = IO.Directory.GetDirectories(objTreeNodes_Start(i).ToolTipText)

    '            For Each strFolder In strFolders
    '                strFolderShort = strFolder.Substring(strFolder.LastIndexOf("\") + 1)

    '                objTreeNodes = objTreeNodes_Start(i).Nodes.Find(strFolderShort, False)
    '                If objTreeNodes.Count = 0 Then
    '                    dtbl_Tree.Rows(
    '                Else


    '                End If



    '            Next
    '        Catch ex As Exception

    '        End Try
    '    Next


    'End Sub
    'Private Sub get_L2(ByVal objTreeNode As TreeNode)
    '    Dim objTreeNodes() As TreeNode
    '    Dim objTreeNode_Sub As TreeNode
    '    Dim strFolders() As String
    '    Dim strFolder As String
    '    Dim strFolderShort As String
    '    Dim i

    '    For i = 0 To objScanObject_L2.Count - 1
    '        Try
    '            strFolders = IO.Directory.GetDirectories(objScanObject_L2(i).Path)

    '            For Each strFolder In strFolders
    '                strFolderShort = strFolder.Substring(strFolder.LastIndexOf("\") + 1)
    '                objTreeNodes = objScanObject_L2(i).TreeNode.Nodes.Find(strFolderShort, False)
    '                If objTreeNodes.Count = 0 Then
    '                    objTreeNode_Sub = objScanObject_L2(i).TreeNode.Nodes.Add(strFolderShort, strFolderShort, cint_ImageID_Folder_Closed, cint_ImageID_Folder_Opened)
    '                Else
    '                    objTreeNode_Sub = objTreeNodes(0)
    '                End If



    '            Next
    '        Catch ex As Exception

    '        End Try
    '    Next

    'End Sub






    Private Sub TreeView_Folder_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Folder.AfterSelect

    End Sub

    Private Sub TreeView_Folder_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView_Folder.BeforeExpand
        Dim objTreeNode As TreeNode


        objTreeNode = e.Node



    End Sub


    Private Sub Timer_Browse_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Browse.Tick
        Dim objDRs_notShown() As DataRow
        Dim objDR_notShown As DataRow
        Dim objDRs_Parent() As DataRow
        Dim objGUID_Parent As Guid
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Parent As TreeNode
        Dim objTreeNode As TreeNode
        Dim dateNow As Date
        Dim intCount As Integer
        Dim i As Integer
        Dim j As Integer
        dateNow = Now

        objGUID_Parent = Guid.NewGuid


        Try
            objThread_Folders.Suspend()
        Catch ex As Exception

        End Try

        objDRs_notShown = dtbl_Tree.Select("Shown=" & 0, "Level ASC")
        If objDRs_notShown.Length > 0 Or boolReading = True Then
            ToolStripLabel_Reading.Text = "Reading..."
            ToolStripLabel_Reading.ForeColor = Color.Red
            Try
                objThread_Folders.Resume()
            Catch ex As Exception

            End Try


            For Each objDR_notShown In objDRs_notShown

                If IsDBNull(objDR_notShown.Item("GUID_Node_Parent")) Then
                    objGUID_Parent = objDR_notShown.Item("GUID_Node")
                    objTreeNode_Parent = TreeView_Folder.Nodes.Add(objDR_notShown.Item("GUID_Node").ToString, objDR_notShown.Item("Text"), objDR_notShown.Item("ImageID"), objDR_notShown.Item("ImageID_Selected"))


                    Try
                        objThread_Folders.Suspend()
                    Catch ex As Exception

                    End Try

                    objDR_notShown.Item("Shown") = 1

                    Try
                        objThread_Folders.Resume()
                    Catch ex As Exception

                    End Try



                Else
                    If objGUID_Parent <> objDR_notShown.Item("GUID_Node_Parent") Then
                        objTreeNodes = TreeView_Folder.Nodes.Find(objDR_notShown.Item("GUID_Node_Parent").ToString, True)
                        If objTreeNodes.Count > 0 Then
                            objTreeNode_Parent = objTreeNodes(0)
                            objGUID_Parent = objDR_notShown.Item("GUID_Node")
                            objTreeNode_Parent.Nodes.Add(objDR_notShown.Item("GUID_Node").ToString, objDR_notShown.Item("Text"), objDR_notShown.Item("ImageID"), objDR_notShown.Item("ImageID_Selected"))

                            Try
                                objThread_Folders.Suspend()
                            Catch ex As Exception

                            End Try

                            objDR_notShown.Item("Shown") = 1

                            Try
                                objThread_Folders.Resume()
                            Catch ex As Exception

                            End Try

                        End If
                    Else
                        objTreeNode_Parent.Nodes.Add(objDR_notShown.Item("GUID_Node").ToString, objDR_notShown.Item("Text"), objDR_notShown.Item("ImageID"), objDR_notShown.Item("ImageID_Selected"))

                        Try
                            objThread_Folders.Suspend()
                        Catch ex As Exception

                        End Try

                        objDR_notShown.Item("Shown") = 1

                        Try
                            objThread_Folders.Resume()
                        Catch ex As Exception

                        End Try

                    End If

                End If

                If (Now - dateNow).Milliseconds > 500 Then
                    Exit For
                End If
            Next
        Else
            ToolStripLabel_Reading.Text = ""
            ToolStripLabel_Reading.ForeColor = Nothing
        End If
        


    End Sub

    
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub frmFolderBrowser_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub frmFolderBrowser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            objThread_Folders.Abort()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ContextMenuStrip_Tree_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Tree.Opening
        Dim objTreeNode As TreeNode

        ApplyToolStripMenuItem.Enabled = False
        OpenExternToolStripMenuItem.Enabled = False
        objTreeNode = TreeView_Folder.SelectedNode
        If Not objTreeNode Is Nothing Then
            If Not objTreeNode.ImageIndex = cint_ImageID_DriveRoot And Not objTreeNode.ImageIndex = cint_ImageID_Root Then
                ApplyToolStripMenuItem.Enabled = True
                OpenExternToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        Dim objTreeNode As TreeNode


        objTreeNode = TreeView_Folder.SelectedNode
        If Not objTreeNode Is Nothing Then
            objSemItem_Selected = New clsSemItem
            objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
            objSemItem_Selected.Name = objTreeNode.Text
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Drive
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID
                Case cint_ImageID_Folder_Closed
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
            End Select
            objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Selected.Additional1 = get_Path(objTreeNode)
            DialogResult = Windows.Forms.DialogResult.OK
            Try
                objThread_Folders.Abort()
            Catch ex As Exception

            End Try
            Me.Hide()
        End If
    End Sub
    Private Function get_Path(ByVal objTreeNode As TreeNode) As String
        Dim strPath As String = ""
        Dim objTreeNode_Parent As TreeNode


        If Not objTreeNode.ImageIndex = cint_ImageID_Root And Not objTreeNode.ImageIndex = cint_ImageID_DriveRoot Then
            strPath = objTreeNode.Text
        End If

        objTreeNode_Parent = objTreeNode

        Do
            If Not objTreeNode_Parent.Parent Is Nothing Then
                objTreeNode_Parent = objTreeNode_Parent.Parent
                If Not objTreeNode_Parent.ImageIndex = cint_ImageID_Root And Not objTreeNode_Parent.ImageIndex = cint_ImageID_DriveRoot Then
                    If Not objTreeNode_Parent.Text.EndsWith("\") Or strPath.StartsWith("\") Then
                        strPath = "\" & strPath
                    End If
                    strPath = objTreeNode_Parent.Text & strPath
                End If
            End If
        Loop Until objTreeNode_Parent.Parent Is Nothing
        Return strPath
    End Function
End Class