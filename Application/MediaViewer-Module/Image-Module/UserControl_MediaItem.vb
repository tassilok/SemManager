Imports Sem_Manager
Imports Filesystem_Management
Imports ClassLibrary_ShellWork
Imports Localizing_Manager
Public Class UserControl_MediaItem

    Private objSemItem_Ref As clsSemItem
    Private objSemItems_Languages() As clsSemItem
    Private objLocalConfig As clsLocalConfig
    Private objTransaction_MediaItem As clsTransaction_MediaItem
    Private objMediaInfo As clsMediaInfo

    Private funcA_Token_OR As New ds_TokenTableAdapters.func_Token_ORTableAdapter
    Private funcT_Token_OR As New ds_Token.func_Token_ORDataTable
    Private procA_MediaItem_Of_Or As New ds_ImageModuleTableAdapters.proc_MediaItem_Of_OrTableAdapter
    Private procT_MediaItem_Of_Or As New ds_ImageModule.proc_MediaItem_Of_OrDataTable
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter

    Private objDLG_Attribute_Integer As dlgAttribute_Int

    Private WithEvents objFrmBookMarks As frmBookMarks
    Private objUserControl_Localized As UserControl_Localized
    Private objUserControl_MediaDetail_mp3 As UserControl_MediaDetail_MP3

    Private objBlobConnection As clsBlobConnection
    Private objShellWork As clsShellWork
    Private objFrmTokenEdit As frmTokenEdit
    Private objTransaction_Bookmarks As clsTransaction_Bookmarks

    Private objSemItems_Extensions() As clsSemItem
    Private objSemItem_Or As clsSemItem
    Private objSemItem_MediaItem As clsSemItem
    Private objSemItem_File As clsSemItem
    Private objSemItem_LogState_Player As clsSemItem
    Private objMediaPlayer As clsMediaPlayer
    Private objDRC_Or As DataRowCollection
    Private intID As Integer
    Private boolAllowEdit As Boolean
    Private boolAllowRelate As Boolean
    Private boolSetPosition As Boolean
    Private objSemItem_Bookmark As clsSemItem
    Private intPositionSec As Integer
    Private strPosition As String
    Private strAPosition() As String

    Public Event related_Items()
    Public Event relate_All_Images()

    Private Sub set_Bookmark(ByVal SemItem_Bookmark As clsSemItem) Handles objFrmBookMarks.set_Position
        Dim ixMediaItem As Integer

        boolSetPosition = False
        objSemItem_Bookmark = SemItem_Bookmark
        strPosition = objSemItem_Bookmark.Additional1
        If strPosition.Contains(":") Then
            strAPosition = strPosition.Split(":")
            If strAPosition.Count = 3 Then
                intPositionSec = Integer.Parse(strAPosition(0)) * 3600
                intPositionSec = intPositionSec + Integer.Parse(strAPosition(1)) * 60
                intPositionSec = intPositionSec + Integer.Parse(strAPosition(2))
                boolSetPosition = True
            ElseIf strAPosition.Count = 2 Then
                intPositionSec = Integer.Parse(strAPosition(0)) * 60
                intPositionSec = intPositionSec + Integer.Parse(strAPosition(1))
                boolSetPosition = True
            End If
        End If

        If boolSetPosition = True Then
            ixMediaItem = BindingSource_MediaItems.Find("GUID_Media_Item", objSemItem_Bookmark.GUID_Related.ToString)

            If ixMediaItem > -1 Then
                AxWindowsMediaPlayer_Main.close()
                AxWindowsMediaPlayer_Main.URL = ""

                DataGridView_MediaItems.ClearSelection()
                DataGridView_MediaItems.Rows(ixMediaItem).Selected = True
                open_MediaItem()
            Else
                boolSetPosition = False
            End If
        End If
    End Sub

    Public WriteOnly Property Enable_Relation As Boolean
        Set(ByVal value As Boolean)
            boolAllowRelate = value
        End Set
    End Property

    Public ReadOnly Property DataGridViewRow_SelectedRows As DataGridViewSelectedRowCollection
        Get
            Return DataGridView_MediaItems.SelectedRows
        End Get
    End Property


    Public Property Allow_Edit As Boolean
        Get
            Return boolAllowEdit
        End Get
        Set(ByVal value As Boolean)
            boolAllowEdit = value

        End Set
    End Property

    Public Sub stop_Media()
        AxWindowsMediaPlayer_Main.close()
    End Sub

    Public Sub New(ByVal SemItem_Ref As clsSemItem, ByVal SemItems_Languages() As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = SemItem_Ref
        objSemItems_Languages = SemItems_Languages

        objLocalConfig = New clsLocalConfig(New clsGlobals)
        initialize()
    End Sub

    Public Sub New(ByVal SemItem_Ref As clsSemItem, ByVal SemItems_Languages() As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = SemItem_Ref
        objSemItems_Languages = SemItems_Languages

        objLocalConfig = New clsLocalConfig(Globals)
        initialize()
    End Sub

    Public Sub New(ByVal SemItem_Ref As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = SemItem_Ref


        objLocalConfig = New clsLocalConfig(Globals)
        get_Languages()
        initialize()
    End Sub

    Public Sub New(ByVal SemItem_Ref As clsSemItem, ByVal SemItems_Languages() As clsSemItem, ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = SemItem_Ref
        objSemItems_Languages = SemItems_Languages

        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Private Sub get_Languages()
        Dim objDRC_Languages As DataRowCollection
        Dim i As Integer


        objDRC_Languages = funcA_TokenToken.GetData_TokenToken_LeftRight(objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_isDescribedBy.GUID, _
                                                                            objLocalConfig.SemItem_Type_Language.GUID).Rows
        If objDRC_Languages.Count > 0 Then


            ReDim Preserve objSemItems_Languages(objDRC_Languages.Count - 1)
            For i = 0 To objDRC_Languages.Count - 1
                objSemItems_Languages(i) = New clsSemItem
                objSemItems_Languages(i).GUID = objDRC_Languages(i).Item("GUID_Token_Right")
                objSemItems_Languages(i).Name = objDRC_Languages(i).Item("Name_Token_Right")
                objSemItems_Languages(i).GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
                objSemItems_Languages(i).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Next
        End If

    End Sub

    Private Sub initialize()
        set_DBConnection()
        objDRC_Or = semfuncA_ObjectReference.GetData_By_GUID_Ref(objSemItem_Ref.GUID).Rows
        If objDRC_Or.Count > 0 Then
            objSemItem_Or = New clsSemItem
            objSemItem_Or.GUID = objDRC_Or(0).Item("GUID_ObjectReference")
            objSemItem_Or.Name = objDRC_Or(0).Item("Name_Token")
            objSemItem_Or.GUID_Parent = objDRC_Or(0).Item("GUID_ItemType")
        Else
            objSemItem_Or = Nothing
        End If
        get_Data()
        fill_DataGrid()

    End Sub

    Private Sub select_TabPage()
        Select Case TabControl1.SelectedTab.Name
            'Case TabPage_MediaPlayer.Name
            '    get_Data()
            '    fill_DataGrid()
            Case TabPage_MediaData.Name
                get_Meta()

            Case TabPage_Description.Name
                objUserControl_Localized.Dock = Windows.Forms.DockStyle.Fill

                TabPage_Description.Controls.Add(objUserControl_Localized)
                objUserControl_Localized.initialize(objSemItem_Ref, objSemItems_Languages, True)
        End Select
    End Sub

    Private Sub get_Meta()
        Dim strExtension As String
        TabPage_MediaData.Controls.Clear()
        If Not objSemItem_File Is Nothing Then
            If Not objSemItem_MediaItem Is Nothing Then
                If objSemItem_File.Name.Contains(".") Then
                    strExtension = objSemItem_File.Name.Substring(objSemItem_File.Name.IndexOf(".") + 1)
                    Select Case strExtension.ToLower
                        Case "mp3"
                            objUserControl_MediaDetail_mp3 = New UserControl_MediaDetail_MP3(objLocalConfig, objSemItem_File, objSemItem_MediaItem)
                            objUserControl_MediaDetail_mp3.Dock = DockStyle.Fill

                            TabPage_MediaData.Controls.Add(objUserControl_MediaDetail_mp3)

                    End Select
                End If
            End If
            
        End If
        



    End Sub
    Private Sub fill_DataGrid()
        BindingSource_MediaItems.DataSource = procT_MediaItem_Of_Or
        DataGridView_MediaItems.DataSource = BindingSource_MediaItems
        DataGridView_MediaItems.Columns(1).Visible = False
        DataGridView_MediaItems.Columns(0).Width = 30
        DataGridView_MediaItems.Columns(2).Width = 300
        DataGridView_MediaItems.Columns(3).Visible = False
        DataGridView_MediaItems.Columns(4).Visible = False
        DataGridView_MediaItems.Columns(5).Visible = False
        DataGridView_MediaItems.Columns(6).Visible = False
        DataGridView_MediaItems.Columns(7).Visible = False
        DataGridView_MediaItems.Columns(8).Visible = False
        ToolStripLabel_ItemCount.Text = BindingSource_MediaItems.Position.ToString & "/" & DataGridView_MediaItems.RowCount.ToString
        If DataGridView_MediaItems.RowCount > 0 Then
            ToolStripButton_PlayList.Enabled = True
        Else
            ToolStripButton_PlayList.Enabled = False
        End If
    End Sub

    Private Sub set_DBConnection()
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_MediaItem_Of_Or.Connection = objLocalConfig.Connection_Plugin
        semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB

        objUserControl_Localized = New UserControl_Localized(objLocalConfig.Globals)
        objTransaction_MediaItem = New clsTransaction_MediaItem(objLocalConfig)
        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
        objTransaction_Bookmarks = New clsTransaction_Bookmarks(objLocalConfig)
        objShellWork = New clsShellWork()
        objMediaInfo = New clsMediaInfo(objLocalConfig.Globals)
    End Sub

    Private Sub get_Data()
        If Not objSemItem_Or Is Nothing Then
            procA_MediaItem_Of_Or.Fill(procT_MediaItem_Of_Or, _
                                   objLocalConfig.SemItem_Type_Media_Item.GUID, _
                                   objLocalConfig.SemItem_Type_File.GUID, _
                                   objLocalConfig.SemItem_Type_Media_Item_Bookmark.GUID, _
                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                   objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                   objSemItem_Or.GUID)
        Else
            procT_MediaItem_Of_Or.Clear()
        End If
        get_FileTypes()
    End Sub

    Private Sub get_FileTypes()

        Dim objDRC_FileType As DataRowCollection

        objDRC_FileType = funcA_TokenToken.GetData_TokenToken_LeftRight(objLocalConfig.SemItem_Type_Filetypes.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                         objLocalConfig.SemItem_Token_Extensions_mod.GUID).Rows

        If objDRC_FileType.Count > 0 Then
            ReDim Preserve objSemItems_Extensions(0)
            objSemItems_Extensions(0) = New clsSemItem
            objSemItems_Extensions(0).GUID = objLocalConfig.SemItem_Token_Extensions_mod.GUID
            objSemItems_Extensions(0).Name = objDRC_FileType(0).Item("Name_Token_Right") & " (*." & objLocalConfig.SemItem_Token_Extensions_mod.Name & ")"
            objSemItems_Extensions(0).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        End If


    End Sub

    Private Sub ToolStripButton_LoadImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_LoadImage.Click
        Dim strPath As String
        Dim objSemItem_Result As clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_MediaItem As DataRowCollection

        If ToolStripButton_Replace.Checked = True Then
            If DataGridView_MediaItems.SelectedRows.Count = 1 Then

                OpenFileDialog_MediaItem.Multiselect = False
                If OpenFileDialog_MediaItem.ShowDialog(Me) = DialogResult.OK Then
                    strPath = OpenFileDialog_MediaItem.FileName

                    objSemItem_Result = objBlobConnection.compare_File(strPath)
                    If objSemItem_Result.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID Then
                        intID = get_NextID()
                        If objSemItem_Or Is Nothing Then
                            objSemItem_Or = New clsSemItem
                            objSemItem_Or.GUID = objSemItem_Result.GUID_Related

                        End If
                        objDRC_MediaItem = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Result.GUID, _
                                                                                         objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                                         objLocalConfig.SemItem_Type_Media_Item.GUID).Rows

                        If objDRC_MediaItem.Count > 0 Then
                            objSemItem_MediaItem = New clsSemItem
                            objSemItem_MediaItem.GUID = objDRC_MediaItem(0).Item("GUID_TokeN_Left")
                            objSemItem_MediaItem.Name = objDRC_MediaItem(0).Item("Name_TokeN_Left")
                            objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
                            objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Result = objTransaction_MediaItem.save_007_MediaItem_To_OR(1, objSemItem_MediaItem, objSemItem_Or)
                            If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                MsgBox("Die Mediendatei konnte nicht gespeichert werden!", MsgBoxStyle.Information)
                            End If
                        Else
                            MsgBox("Die Mediendatei konnte nicht gespeichert werden!", MsgBoxStyle.Information)
                        End If
                    Else
                        objDGVR_Selected = DataGridView_MediaItems.SelectedRows(0)
                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                        objSemItem_MediaItem = New clsSemItem
                        objSemItem_MediaItem.GUID = objDRV_Selected.Item("GUID_Media_Item")
                        objSemItem_MediaItem.Name = objDRV_Selected.Item("Name_Media_Item")
                        objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
                        objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_File = New clsSemItem
                        objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
                        objSemItem_File.Name = objDRV_Selected.Item("Name_File")
                        objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                        objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        Try
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                            If objSemItem_Or Is Nothing Then
                                objSemItem_Or = New clsSemItem
                                objSemItem_Or.GUID = objSemItem_Result.GUID_Related

                            End If

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_MediaItem.save_004_File(objSemItem_File)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_MediaItem.save_005_Blob(strPath)
                                    If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        MsgBox("Die Mediendatei konnte nicht gespeichert werden!", MsgBoxStyle.Information)
                                    End If
                                Else
                                    MsgBox("Die Mediendatei konnte nicht gespeichert werden!", MsgBoxStyle.Information)
                                End If


                            End If

                        Catch ex As Exception
                            Stop
                        End Try
                    End If


                End If
            Else
                MsgBox("Sie können nur jeweils ein Media-Item ersetzen!", MsgBoxStyle.Information)
            End If
        Else
            OpenFileDialog_MediaItem.Multiselect = True
            If OpenFileDialog_MediaItem.ShowDialog(Me) = DialogResult.OK Then

                For Each strPath In OpenFileDialog_MediaItem.FileNames
                    Try
                        'Prüfung, ob Datei eine zugelassene Media-Datei ist.
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        If objSemItem_Or Is Nothing Then

                            objSemItem_Result = objTransaction_MediaItem.save_001_OR_of_Ref(objSemItem_Ref)

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Or = New clsSemItem
                                objSemItem_Or.GUID = objSemItem_Result.GUID_Related
                                get_Data()
                            Else

                                MsgBox("Das Image konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objBlobConnection.compare_File(strPath)
                            If objSemItem_Result.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID Then
                                intID = get_NextID()
                                objDRC_MediaItem = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Result.GUID, _
                                                                                                 objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                                                 objLocalConfig.SemItem_Type_Media_Item.GUID).Rows

                                If objDRC_MediaItem.Count > 0 Then
                                    objSemItem_MediaItem = New clsSemItem
                                    objSemItem_MediaItem.GUID = objDRC_MediaItem(0).Item("GUID_TokeN_Left")
                                    objSemItem_MediaItem.Name = objDRC_MediaItem(0).Item("Name_TokeN_Left")
                                    objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
                                    objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    objSemItem_Result = objTransaction_MediaItem.save_007_MediaItem_To_OR(1, objSemItem_MediaItem, objSemItem_Or)
                                    If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        MsgBox("Die Mediendatei konnte nicht gespeichert werden!", MsgBoxStyle.Information)
                                    End If
                                Else
                                    MsgBox("Die Mediendatei konnte nicht gespeichert werden!", MsgBoxStyle.Information)
                                End If
                            Else
                                intID = get_NextID()

                                objSemItem_MediaItem = New clsSemItem
                                objSemItem_MediaItem.GUID = Guid.NewGuid
                                objSemItem_MediaItem.Name = strPath.Substring(strPath.LastIndexOf("\") + 1)
                                objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
                                objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objSemItem_Result = objTransaction_MediaItem.save_002_MediaItem(objSemItem_MediaItem)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_File = New clsSemItem
                                    objSemItem_File.GUID = Guid.NewGuid
                                    objSemItem_File.Name = strPath.Substring(strPath.LastIndexOf("\") + 1)
                                    objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID

                                    objSemItem_Result = objTransaction_MediaItem.save_004_File(objSemItem_File)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_MediaItem.save_005_Blob(strPath)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_MediaItem.save_006_MediaItem_To_File
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_MediaItem.save_007_MediaItem_To_OR(intID, objSemItem_MediaItem, objSemItem_Or)
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objMediaInfo.get_Meta(objSemItem_MediaItem, objSemItem_File, strPath)
                                                    get_Data()
                                                    fill_DataGrid()
                                                Else
                                                    MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                                                    objSemItem_Result = objTransaction_MediaItem.del_006_MediaItem_To_File
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                        objSemItem_Result = objTransaction_MediaItem.del_005_Blob
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objTransaction_MediaItem.del_004_File()
                                                        End If


                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objTransaction_MediaItem.del_002_MediaItem()
                                                        End If
                                                    End If



                                                End If
                                            Else
                                                MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                                                objSemItem_Result = objTransaction_MediaItem.del_005_Blob
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objTransaction_MediaItem.del_004_File()
                                                End If


                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objTransaction_MediaItem.del_002_MediaItem()
                                                End If
                                            End If
                                        Else
                                            MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                                            objSemItem_Result = objTransaction_MediaItem.del_004_File()

                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objTransaction_MediaItem.del_002_MediaItem()
                                            End If
                                        End If
                                    Else
                                        MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)

                                        objTransaction_MediaItem.del_002_MediaItem()


                                    End If

                                Else
                                    MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                                End If
                            End If

                            
                        End If
                    Catch ex As Exception
                        MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                    End Try
                Next


            End If
        End If

    End Sub


    Public Function get_NextID() As Integer
        Dim objDRC_Images As DataRowCollection
        objDRC_Images = procA_MediaItem_Of_Or.GetData(objLocalConfig.SemItem_Type_Media_Item.GUID, _
                                                      objLocalConfig.SemItem_Type_File.GUID, _
                                                      objLocalConfig.SemItem_Type_Media_Item_Bookmark.GUID, _
                                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                  objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                  objSemItem_Or.GUID).Rows
        If objDRC_Images.Count > 0 Then
            Return objDRC_Images(objDRC_Images.Count - 1).Item("OrderID") + 1
        Else
            Return 1
        End If
    End Function

    Private Sub ContextMenuStrip_MediaPlayer_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_MediaPlayer.Opening
        PlayToolStripMenuItem.Enabled = False
        RelateToolStripMenuItem.Enabled = False
        ToolStripMenuItem_RelateAll.Enabled = False
        RemoveFromListToolStripMenuItem.Enabled = False
        GetMetaToolStripMenuItem.Enabled = False
        SavePlaylistToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False
        SavePlaylistToolStripMenuItem.Enabled = False
        If DataGridView_MediaItems.SelectedRows.Count = 1 Then
            PlayToolStripMenuItem.Enabled = True
            If boolAllowRelate = True Then
                RelateToolStripMenuItem.Enabled = True
            End If

        ElseIf DataGridView_MediaItems.SelectedRows.Count > 1 Then

            If boolAllowRelate = True Then
                RelateToolStripMenuItem.Enabled = True
            End If


        ElseIf DataGridView_MediaItems.RowCount > 0 Then
            SavePlaylistToolStripMenuItem.Enabled = True
        End If

        If DataGridView_MediaItems.RowCount > 0 Then
            If boolAllowRelate = True Then
                ToolStripMenuItem_RelateAll.Enabled = True
            End If
            RemoveFromListToolStripMenuItem.Enabled = True
            DeleteToolStripMenuItem.Enabled = True
            GetMetaToolStripMenuItem.Enabled = True
            SaveMediaItemsToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub PlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        Dim objDGRV_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        If DataGridView_MediaItems.SelectedRows.Count = 1 Then
            objDGRV_Selected = DataGridView_MediaItems.SelectedRows(0)
            objDRV_Selected = objDGRV_Selected.DataBoundItem

            objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
            objSemItem_File.Name = objDRV_Selected.Item("Name_File")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_File.Additional1 = "%Temp%\" & objSemItem_File.Name
            objSemItem_File.Additional1 = Environment.ExpandEnvironmentVariables(objSemItem_File.Additional1)

            objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, objSemItem_File.Additional1)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objShellWork.start_Process(objSemItem_File.Additional1, Nothing, Nothing, False, False)

            End If

        End If
        


    End Sub

    Private Sub DataGridView_MediaItems_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_MediaItems.CellMouseDoubleClick
        Dim intRowIndex As Integer
        Dim intColIndex As Integer
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_MediaItem As New clsSemItem
        Dim objSemItem_OR As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intOrderID As Integer

        intRowIndex = e.RowIndex
        intColIndex = e.ColumnIndex

        If intColIndex = 0 Then
            objDGVR_Selected = DataGridView_MediaItems.Rows(intRowIndex)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            intOrderID = objDRV_Selected.Item("OrderID")

            objDLG_Attribute_Integer = New dlgAttribute_Int("OrderID", objLocalConfig.Globals, intOrderID)
            objDLG_Attribute_Integer.ShowDialog(Me)
            If objDLG_Attribute_Integer.DialogResult = Windows.Forms.DialogResult.OK Then
                intOrderID = objDLG_Attribute_Integer.Value
                objSemItem_MediaItem.GUID = objDRV_Selected.Item("GUID_Media_Item")
                objSemItem_MediaItem.Name = objDRV_Selected.Item("Name_Media_Item")
                objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
                objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_OR.GUID = objDRV_Selected.Item("GUID_ObjectReference")

                objSemItem_Result = objTransaction_MediaItem.save_007_MediaItem_To_OR(intOrderID, _
                                                                  objSemItem_MediaItem, _
                                                                  objSemItem_OR)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objDRV_Selected.Item("OrderID") = intOrderID
                Else
                    MsgBox("Die Ordnungsnummer konnte nicht geändert werden!", MsgBoxStyle.Exclamation)
                End If
            End If

        End If


    End Sub

    Private Sub DataGridView_MediaItems_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_MediaItems.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_MediaItem As New clsSemItem

        objDGVR_Selected = DataGridView_MediaItems.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_MediaItem.GUID = objDRV_Selected.Item("GUID_Media_Item")
        objSemItem_MediaItem.Name = objDRV_Selected.Item("Name_Media_Item")
        objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
        objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrmTokenEdit = New frmTokenEdit(objSemItem_MediaItem, objLocalConfig.Globals)
        objFrmTokenEdit.ShowDialog(Me)

        
    End Sub

    Private Sub DataGridView_MediaItems_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_MediaItems.SelectionChanged
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Ref As New clsSemItem
        TabPage_Description.Controls.Clear()
        TabPage_MediaData.Controls.Clear()

        AxWindowsMediaPlayer_Main.close()
        AxWindowsMediaPlayer_Main.URL = ""
        ToolStripButton_Open.Enabled = False
        objSemItem_File = Nothing
        objSemItem_MediaItem = Nothing
        If DataGridView_MediaItems.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_MediaItems.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Ref.GUID = objDRV_Selected.Item("GUID_Media_Item")
            objSemItem_Ref.Name = objDRV_Selected.Item("Name_Media_Item")
            objSemItem_Ref.GUID_Parent = objDRV_Selected.Item("GUID_Type_Media_Item")
            objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_File = New clsSemItem
            objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
            objSemItem_File.Name = objDRV_Selected.Item("Name_File")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_MediaItem = New clsSemItem
            objSemItem_MediaItem.GUID = objDRV_Selected.Item("GUID_Media_Item")
            objSemItem_MediaItem.Name = objDRV_Selected.Item("Name_Media_Item")
            objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
            objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            ToolStripButton_Open.Enabled = True
            
            select_TabPage()
        End If
    End Sub

    Private Sub ToolStripButton_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Open.Click
        open_MediaItem()
    End Sub

    Private Sub open_MediaItem()
        Dim objSemItem_Result As clsSemItem
        If Not objSemItem_File Is Nothing Then
            objSemItem_File.Additional1 = "%Temp%\" & objSemItem_File.Name
            objSemItem_File.Additional1 = Environment.ExpandEnvironmentVariables(objSemItem_File.Additional1)

            If objLocalConfig.SemItem_Url Is Nothing Then
                objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, objSemItem_File.Additional1)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    AxWindowsMediaPlayer_Main.URL = objSemItem_File.Additional1
                Else
                    MsgBox("Die Media-Datei konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If
            Else
                AxWindowsMediaPlayer_Main.URL = objLocalConfig.SemItem_Url.Name & "?GUID_Token=" & objSemItem_File.GUID.ToString
            End If
        End If
    End Sub

    Private Sub ToolStripButton_Paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Paste.Click

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        select_TabPage()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub RelateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelateToolStripMenuItem.Click
        If DataGridView_MediaItems.SelectedRows.Count > 0 Then
            RaiseEvent related_Items()
        End If
    End Sub

    Private Sub ToolStripMenuItem_RelateAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_RelateAll.Click
        If DataGridView_MediaItems.RowCount > 0 Then

        End If
    End Sub

    Private Sub ToolStripButton_PlayList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_PlayList.Click

    End Sub

    Private Sub AxWindowsMediaPlayer_Main_MouseDownEvent(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_MouseDownEvent) Handles AxWindowsMediaPlayer_Main.MouseDownEvent

    End Sub

    Private Sub AxWindowsMediaPlayer_Main_PlayStateChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer_Main.PlayStateChange
        Select Case AxWindowsMediaPlayer_Main.playState
            Case WMPLib.WMPPlayState.wmppsStopped
                Timer_Position.Stop()
                objSemItem_LogState_Player = objLocalConfig.SemItem_Token_Logstate_Stop
                set_StateChange()

                If ToolStripButton_PlayList.Checked = True Then
                    Timer_Play.Start()

                End If
            Case WMPLib.WMPPlayState.wmppsPaused
                Timer_Position.Stop()
                objSemItem_LogState_Player = objLocalConfig.SemItem_Token_Logstate_Pause
                set_StateChange()
            Case WMPLib.WMPPlayState.wmppsPlaying
                Timer_Position.Start()
                objSemItem_LogState_Player = objLocalConfig.SemItem_Token_Logstate_Start
                set_StateChange()
                If boolSetPosition = True Then
                    boolSetPosition = False
                    AxWindowsMediaPlayer_Main.Ctlcontrols.currentPosition = intPositionSec
                End If
        End Select

    End Sub

    Private Sub set_StateChange()
        Dim objSemItem_BookMark As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim dateNow As DateTime

        dateNow = Now
        If objSemItem_LogState_Player.GUID = objLocalConfig.SemItem_Token_Logstate_Start.GUID Then
            strPosition = ""
            While (Now - dateNow).Milliseconds < 1000 And strPosition = ""
                strPosition = AxWindowsMediaPlayer_Main.Ctlcontrols.currentPositionString

            End While

        End If

        objSemItem_BookMark = New clsSemItem
        objSemItem_BookMark.GUID = Guid.NewGuid
        objSemItem_BookMark.Name = Now.ToString
        objSemItem_BookMark.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item_Bookmark.GUID
        objSemItem_BookMark.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        If strPosition <> "" Then
            objSemItem_Result = objTransaction_Bookmarks.save_001_Bookmark(objSemItem_BookMark)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                objSemItem_Result = objTransaction_Bookmarks.save_002_BookMark__Position(strPosition)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_Bookmarks.save_003_LogEntry(objSemItem_LogState_Player)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_Bookmarks.save_004_BookMark_To_LogEntry
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Bookmarks.save_005_BookMark_To_MediaItem(objSemItem_MediaItem)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                objTransaction_Bookmarks.del_004_BookMark_To_LogEntry()
                                objTransaction_Bookmarks.del_003_LogEntry()
                                objTransaction_Bookmarks.del_002_BookMark__Position()
                                objTransaction_Bookmarks.del_001_Bookmark()
                            End If
                        Else
                            objTransaction_Bookmarks.del_003_LogEntry()
                            objTransaction_Bookmarks.del_002_BookMark__Position()
                            objTransaction_Bookmarks.del_001_Bookmark()
                        End If
                    Else
                        objTransaction_Bookmarks.del_002_BookMark__Position()
                        objTransaction_Bookmarks.del_001_Bookmark()
                    End If
                Else
                    objTransaction_Bookmarks.del_001_Bookmark()

                End If
            End If
        End If
        

    End Sub

    Private Sub Timer_Play_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Play.Tick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem
        Timer_Play.Stop()
        If BindingSource_MediaItems.Position < BindingSource_MediaItems.Count Then
            BindingSource_MediaItems.Position = BindingSource_MediaItems.Position + 1


            objDGVR_Selected = DataGridView_MediaItems.Rows(BindingSource_MediaItems.Position)
            objDGVR_Selected.Selected = True
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Ref.GUID = objDRV_Selected.Item("GUID_Media_Item")
            objSemItem_Ref.Name = objDRV_Selected.Item("Name_Media_Item")
            objSemItem_Ref.GUID_Parent = objDRV_Selected.Item("GUID_Type_Media_Item")
            objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_File = New clsSemItem
            objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
            objSemItem_File.Name = objDRV_Selected.Item("Name_File")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_MediaItem = New clsSemItem
            objSemItem_MediaItem.GUID = objDRV_Selected.Item("GUID_Media_Item")
            objSemItem_MediaItem.Name = objDRV_Selected.Item("Name_Media_Item")
            objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
            objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            ToolStripButton_Open.Enabled = True

            AxWindowsMediaPlayer_Main.settings.autoStart = True
            If objLocalConfig.SemItem_Url Is Nothing Then
                objSemItem_File.Additional1 = "%Temp%\" & objSemItem_File.Name
                objSemItem_File.Additional1 = Environment.ExpandEnvironmentVariables(objSemItem_File.Additional1)

                objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, objSemItem_File.Additional1)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    AxWindowsMediaPlayer_Main.URL = objSemItem_File.Additional1
                Else
                    MsgBox("Die Media-Datei konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If
            Else
                AxWindowsMediaPlayer_Main.URL = objLocalConfig.SemItem_Url.Name & "?GUID_Token=" & objSemItem_File.GUID.ToString
            End If

            'End If
        Else
            Timer_Play.Stop()
            ToolStripButton_PlayList.Checked = False
        End If
    End Sub

    Private Sub BindingSource_MediaItems_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BindingSource_MediaItems.PositionChanged
        ToolStripLabel_ItemCount.Text = BindingSource_MediaItems.Position.ToString & "/" & DataGridView_MediaItems.RowCount.ToString
    End Sub

    Private Sub RemoveFromListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFromListToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_Related() As DataRow
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_MediaItem As New clsSemItem
        Dim objSemItem_OR As New clsSemItem
        Dim intItems_NoRef As Integer
        Dim intItems_Error As Integer

        intItems_Error = 0
        intItems_NoRef = 0
        For Each objDGVR_Selected In DataGridView_MediaItems.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            funcA_Token_OR.Fill_By_GUIDTokenLeft_GUIDRelationType(funcT_Token_OR, _
                                                                  objDRV_Selected.Item("GUID_Media_Item"), _
                                                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID)
            objDRs_Related = funcT_Token_OR.Select("NOT GUID_ObjectReference='" & objDRV_Selected.Item("GUID_ObjectReference").ToString & "'")
            If objDRs_Related.Count > 0 Then
                objSemItem_MediaItem.GUID = objDRV_Selected.Item("GUID_Media_Item")
                objSemItem_MediaItem.Name = objDRV_Selected.Item("Name_Media_Item")
                objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
                objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_OR.GUID = objDRV_Selected.Item("GUID_ObjectReference")
                objSemItem_Result = objTransaction_MediaItem.del_007_MediaItem_To_OR(objSemItem_MediaItem, objSemItem_OR)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    intItems_Error = intItems_Error + 1
                Else
                    objDRV_Selected.Delete()
                End If
            Else
                intItems_NoRef = intItems_NoRef + 1
            End If

        Next
        If intItems_NoRef > 0 Then
            MsgBox(intItems_NoRef & " Elemente konnte nicht gelöscht werden, weil sie sonst nicht mehr referenziert wären!", MsgBoxStyle.Exclamation)
        End If

        If intItems_Error > 0 Then
            MsgBox(intItems_Error & " Elemente konnte nicht gelöscht werden, weil ein Fehler aufgetreten ist!", MsgBoxStyle.Exclamation)
        End If
    End Sub


    Private Sub AxWindowsMediaPlayer_Main_StatusChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer_Main.StatusChange
        
    End Sub

    Private Sub Timer_Position_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Position.Tick
        If AxWindowsMediaPlayer_Main.Ctlcontrols.currentPositionString <> "" Then
            strPosition = AxWindowsMediaPlayer_Main.Ctlcontrols.currentPositionString
        End If

    End Sub

    Private Sub ToolStripButton_BookmarksRelItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_BookmarksRelItem.Click
        objFrmBookMarks = New frmBookMarks(objLocalConfig)
        objFrmBookMarks.initialize_Ref(objSemItem_Ref)
        objFrmBookMarks.Show()


    End Sub

    Private Sub GetMetaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetMetaToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_MediaItem As New clsSemItem
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        For Each objDGVR_Selected In DataGridView_MediaItems.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_MediaItem.GUID = objDRV_Selected.Item("GUID_Media_Item")
            objSemItem_MediaItem.Name = objDRV_Selected.Item("Name_Media_Item")
            objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
            objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
            objSemItem_File.Name = objDRV_Selected.Item("Name_File")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, Environment.ExpandEnvironmentVariables("%Temp%\" & objSemItem_File.Name))

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objMediaInfo.get_Meta(objSemItem_MediaItem, objSemItem_File, Environment.ExpandEnvironmentVariables("%Temp%\" & objSemItem_File.Name))
            End If

            Try
                IO.File.Delete("%Temp%\" & Environment.ExpandEnvironmentVariables(objSemItem_File.Name))
            Catch ex As Exception

            End Try

        Next
    End Sub

    Private Sub SavePlaylistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavePlaylistToolStripMenuItem.Click
        Dim strPath As String
        Dim strFileName As String
        Dim strURL As String
        Dim strXMLWPL As String
        Dim strXMLSRCUrl As String
        Dim cInvalid As Char
        Dim i As Integer
        Dim objXMLTextWriter As Xml.XmlTextWriter
        Dim objDGVR_Select As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        If FolderBrowserDialog_Playlist.ShowDialog(Me) = DialogResult.OK Then
            strPath = FolderBrowserDialog_Playlist.SelectedPath
            If IO.Directory.Exists(strPath) Then
                strFileName = objSemItem_Ref.Name


                For Each cInvalid In IO.Path.GetInvalidFileNameChars
                    strFileName = strFileName.Replace(cInvalid, "_")
                Next
                i = 1
                While IO.File.Exists(strPath & "\" & strFileName & ".wpl")
                    strFileName = strFileName & i
                    i = i + 1
                End While

                strPath = strPath & "\" & strFileName & ".wpl"

                strXMLSRCUrl = ""
                For Each objDGVR_Select In DataGridView_MediaItems.Rows
                    objDRV_Selected = objDGVR_Select.DataBoundItem
                    strURL = objLocalConfig.SemItem_Url.Name & "?GUID_Token=" & objDRV_Selected.Item("GUID_File").ToString
                    strXMLSRCUrl = strXMLSRCUrl & objLocalConfig.XML_SRCURL.Replace("@" & objLocalConfig.SemItem_Token_Variable_URL_MEDIASRC.Name & "@", strURL) & vbCrLf

                Next

                strXMLWPL = objLocalConfig.XML_WPL1.Replace("@" & objLocalConfig.SemItem_Token_Variable_MEDIASRC.Name & "@", strXMLSRCUrl)
                strXMLWPL = strXMLWPL.Replace("@" & objLocalConfig.SemItem_Token_Variable_ITEMCOUNT.Name & "@", DataGridView_MediaItems.RowCount)
                strXMLWPL = strXMLWPL.Replace("@" & objLocalConfig.SemItem_Token_Variable_title.Name & "@", objSemItem_Ref.Name)

                Try
                    objXMLTextWriter = New Xml.XmlTextWriter(strPath, New System.Text.UTF8Encoding)
                    objXMLTextWriter.WriteRaw(strXMLWPL)
                    objXMLTextWriter.Close()

                    MsgBox("Die Playlist wurde gespeichert.", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Die Playlist kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End Try
                
            Else
                MsgBox("Das Verzeichnis existiert nicht!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim funcT_TokenToken As New ds_Token.func_TokenTokenDataTable
        Dim funcT_Token_OR As New ds_Token.func_Token_ORDataTable
        Dim objDRC_OR As DataRowCollection
        Dim objDRs_Ref() As DataRow
        Dim objDR_MediaItem As DataRow
        Dim procT_MediaItem_Of_Or As New ds_ImageModule.proc_MediaItem_Of_OrDataTable
        Dim objSemItem_MediaItem As New clsSemItem
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intToDo As Integer
        Dim intToDo_Possible As Integer
        Dim intDone As Integer
        Dim boolDel As Boolean

        Dim objSemItem_OR As New clsSemItem

        objDRC_OR = semfuncA_ObjectReference.GetData_By_GUID_Ref(objSemItem_Ref.GUID).Rows
        If objDRC_OR.Count > 0 Then
            objSemItem_OR.GUID = objDRC_OR(0).Item("GUID_ObjectReference")

            intToDo = DataGridView_MediaItems.SelectedRows.Count
            intDone = 0

            For Each objDGVR_Selected In DataGridView_MediaItems.SelectedRows
                objDRV_Selected = objDGVR_Selected.DataBoundItem

                funcA_TokenToken.Fill_RightLeft_Tokens_By_GUIDTokenRight_Only(funcT_TokenToken, objDRV_Selected.Item("GUID_Media_Item"))
                If funcT_TokenToken.Count = 0 Then
                    funcA_Token_OR.Fill_By_GUIDTokenLeft_GUIDRelationType(funcT_Token_OR, _
                                                                          objDRV_Selected.Item("GUID_Media_Item"), _
                                                                          objLocalConfig.SemItem_RelationType_belongsTo.GUID)

                    objDRs_Ref = funcT_Token_OR.Select("NOT GUID_Ref='" & objSemItem_Ref.GUID.ToString & "'")
                    If objDRs_Ref.Count = 0 Then

                        procT_MediaItem_Of_Or.Rows.Add(objDRV_Selected.Item(0), _
                                                       objDRV_Selected.Item(1), _
                                                       objDRV_Selected.Item(2), _
                                                       objDRV_Selected.Item(3), _
                                                       objDRV_Selected.Item(4), _
                                                       objDRV_Selected.Item(5), _
                                                       objDRV_Selected.Item(6), _
                                                       objDRV_Selected.Item(7), _
                                                       objDRV_Selected.Item(8))

                    End If
                End If



            Next

            intToDo_Possible = procT_MediaItem_Of_Or.Rows.Count

            boolDel = False

            If intToDo_Possible < intToDo Then
                If intToDo_Possible > 0 Then
                    If MsgBox("Es können nur " & intToDo_Possible & " von " & intToDo & " MediaItems gelöscht werden. Soll gelöscht werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        boolDel = True
                    End If
                Else
                    MsgBox("Keine der MediaItems kann aufgrund von Beziehungen gelöscht werden!", MsgBoxStyle.Exclamation)
                End If
                
            Else
                If MsgBox("Sollen die MediaItems wirklich gelöscht werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    boolDel = True
                End If
            End If

            If boolDel = True Then
                For Each objDR_MediaItem In procT_MediaItem_Of_Or.Rows

                    objSemItem_MediaItem.GUID = objDR_MediaItem.Item("GUID_Media_Item")
                    objSemItem_MediaItem.Name = objDR_MediaItem.Item("Name_Media_Item")
                    objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
                    objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objSemItem_MediaItem.Level = objDR_MediaItem.Item("OrderID")

                    objSemItem_File.GUID = objDR_MediaItem.Item("GUID_File")
                    objSemItem_File.Name = objDR_MediaItem.Item("Name_File")
                    objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                    objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                    objSemItem_Result = objTransaction_MediaItem.del_006_MediaItem_To_File(objSemItem_MediaItem, objSemItem_File)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_MediaItem.del_007_MediaItem_To_OR(objSemItem_MediaItem, objSemItem_OR)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_MediaItem.del_005_Blob(objSemItem_File)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_MediaItem.del_004_File(objSemItem_File)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_MediaItem.del_002_MediaItem(objSemItem_MediaItem)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        intDone = intDone + 1
                                    End If
                                End If
                            Else
                                objTransaction_MediaItem.save_007_MediaItem_To_OR(objSemItem_MediaItem.Level, _
                                                                                  objSemItem_MediaItem, _
                                                                                  objSemItem_OR)
                            End If

                        Else
                            objTransaction_MediaItem.save_006_MediaItem_To_File(objSemItem_MediaItem, objSemItem_File)
                        End If

                    End If


                Next
                If intDone < intToDo_Possible Then
                    MsgBox("Es konnten nur " & intDone & " von " & intToDo_Possible & " MediaItems gelöscht werden!", MsgBoxStyle.Exclamation)
                End If
                get_Data()
                fill_DataGrid()
            End If
           
            
        End if
        
    End Sub

    Private Sub SaveMediaItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveMediaItemsToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim strFileName As String
        Dim strPath As String
        Dim strPath_File As String
        Dim cReplace As Char
        Dim strExtension As String
        Dim i As Integer
        Dim intToDo As Integer
        Dim intDone As Integer

        If FolderBrowserDialog_Playlist.ShowDialog(Me) = DialogResult.OK Then
            strPath = FolderBrowserDialog_Playlist.SelectedPath
            strFileName = objSemItem_Ref.Name
            For Each cReplace In IO.Path.GetInvalidFileNameChars()
                strFileName = strFileName.Replace(cReplace, "_")

            Next
            strPath = strPath & IO.Path.DirectorySeparatorChar & strFileName
            i = 1
            While IO.Directory.Exists(strPath)
                strPath = strPath & "_" & i
                i = i + 1
            End While

            IO.Directory.CreateDirectory(strPath)

            intToDo = DataGridView_MediaItems.SelectedRows.Count
            intDone = 0
            For Each objDGVR_Selected In DataGridView_MediaItems.SelectedRows
                objDRV_Selected = objDGVR_Selected.DataBoundItem

                objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
                objSemItem_File.Name = objDRV_Selected.Item("Name_File")
                objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                strFileName = objSemItem_File.Name
                For Each cReplace In IO.Path.GetInvalidFileNameChars()
                    strFileName = strFileName.Replace(cReplace, "_")

                Next
                strPath_File = strPath & IO.Path.DirectorySeparatorChar & strFileName
                i = 1
                While IO.File.Exists(strPath_File)
                    strExtension = IO.Path.GetExtension(strPath_File)
                    strPath_File = strPath_File.Replace(strExtension, "_" & i & strExtension)

                    i = i + 1

                End While

                objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath_File)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If


            Next

            If intDone < intToDo Then
                MsgBox("Es konnten nur " & intDone & " von " & intToDo & " MediaItems gespeichert werden!", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub
End Class
