Imports Sem_Manager
Public Class frmBlobWatcher
    Private cstrFlag_Start As String = "started.flg"
    Private cstrXML_Files As String = "config.xml"
    Private objLocalConfig As clsLocalConfig_FileManager

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private dtblA_CheckedOut As New db_BlobManagementDataSetTableAdapters.dtbl_CheckedOutTableAdapter
    Private dtblT_CheckedOut As New db_BlobManagementDataSet.dtbl_CheckedOutDataTable

    Private objBlobConnection As clsBlobConnection
    Private objFileWork As clsFileWork
    Private objFlagStream As IO.FileStream
    Private objTextWriter As IO.TextWriter
    Private objTextReader As IO.TextReader
    Private objSemItem_Result As clsSemItem = Nothing

    Private strPathToWatch As String
    Private boolStart As Boolean
    Private boolRegister As Boolean
    Private boolUpdate As Boolean
    Private boolInitialize As Boolean

    Public ReadOnly Property SemItem_Result As clsSemItem
        Get
            Return objSemItem_Result
        End Get
    End Property

    Public ReadOnly Property PathToWatch As String
        Get
            Return strPathToWatch
        End Get
    End Property

    Public Sub New(ByVal LocalConfig As clsLocalConfig_FileManager)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Private Sub initialize()
        Dim strFile As String


        boolStart = True
        boolInitialize = True
        set_DBConnection()
        objSemItem_Result = objFileWork.get_Path_to_Watch
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            boolStart = False
        Else
            strPathToWatch = objSemItem_Result.Additional1
        End If
        If boolStart = True Then
            strFile = objFileWork.merge_paths(Environment.ExpandEnvironmentVariables("%temp%"), cstrFlag_Start, "\")
            If is_File_Locked(strFile) = True Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Relation
                boolStart = False
            Else
                objFlagStream = New IO.FileStream(strFile, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
                objTextWriter = New IO.StreamWriter(objFlagStream)
                objTextWriter.WriteLine("started")
            End If


        End If



        If boolStart = True Then
            Try
                If IO.Directory.Exists(strPathToWatch) = False Then
                    IO.Directory.CreateDirectory(strPathToWatch)
                End If


                dtblA_CheckedOut.Fill(dtblT_CheckedOut)
                clear_Config()

                'For Each strFile In IO.Directory.GetFiles(strPathToWatch)
                '    Try
                '        IO.File.Delete(strFile)
                '    Catch ex As Exception

                '    End Try

                'Next
                FileSystemWatcher_BlobDir.Path = strPathToWatch
                FileSystemWatcher_BlobDir.EnableRaisingEvents = True



                boolInitialize = False
            Catch ex As Exception
                boolStart = False
            End Try
        Else
            FileSystemWatcher_BlobDir.EnableRaisingEvents = False
        End If



    End Sub

    Private Sub clear_Config()
        Dim objFileInfo As IO.FileInfo
        Dim objDR_File As DataRow
        Dim objDRC_File_DB As DataRowCollection
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        For Each objDR_File In dtblT_CheckedOut.Rows
            If IO.File.Exists(objDR_File.Item("Path_File")) = True Then

                If is_File_Locked(objDR_File.Item("Path_File")) = False Then
                    objFileInfo = New IO.FileInfo(objDR_File.Item("Path_File"))
                    If objFileInfo.LastWriteTime > objDR_File.Item("dateChanged") Then
                        objDRC_File_DB = semtblA_Token.GetData_Token_By_GUID(objDR_File.Item("GUID_File")).Rows
                        If objDRC_File_DB.Count > 0 Then
                            dtblA_CheckedOut.local_upd_Save(objDR_File.Item("GUID_File"))
                            objSemItem_File.GUID = objDR_File.Item("GUID_File")
                            objSemItem_File.Name = objDR_File.Item("Name_File")
                            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objSemItem_File.Additional1 = objDR_File.Item("Path_File")
                            If is_File_Locked(objSemItem_File.Additional1) = False Then
                                objSemItem_Result = objBlobConnection.save_File_To_Blob(objSemItem_File, objSemItem_File.Additional1)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    IO.File.Delete(objDR_File.Item("Path_File"))
                                    dtblA_CheckedOut.local_del_File(objDR_File.Item("GUID_File"))
                                End If
                            End If


                        Else
                            IO.File.Delete(objDR_File.Item("Path_File"))
                            dtblA_CheckedOut.local_del_File(objDR_File.Item("GUID_File"))
                        End If

                    Else
                        IO.File.Delete(objDR_File.Item("Path_File"))
                        dtblA_CheckedOut.local_del_File(objDR_File.Item("GUID_File"))

                    End If

                End If
            Else
                dtblA_CheckedOut.local_del_File(objDR_File.Item("GUID_File"))
            End If

        Next

    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        objFileWork = New clsFileWork(objLocalConfig.Globals)
        objBlobConnection = New clsBlobConnection(objLocalConfig)

        dtblA_CheckedOut.Connection = objLocalConfig.Connection_Plugin

    End Sub
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub FileSystemWatcher_BlobDir_Changed(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher_BlobDir.Changed
        boolUpdate = True
        If e.ChangeType = IO.WatcherChangeTypes.Changed Then
            test_Change(e.FullPath, e.Name)
        End If

        boolUpdate = False
    End Sub

    Private Function test_Change(ByVal strPath As String, ByVal strName As String) As clsSemItem

        Dim objFileInfo As IO.FileInfo
        Dim objDRC_File As DataRowCollection

        If strName.Contains(".") Then
            strName = strName.Substring(0, strName.IndexOf("."))

        End If
        If objLocalConfig.Globals.is_GUID(strName) = True Then
            If IO.File.Exists(strPath) Then
                objDRC_File = dtblA_CheckedOut.GetData_local_File_By_GUID(New Guid(strName)).Rows

                If objDRC_File.Count > 0 Then
                    objFileInfo = New IO.FileInfo(strPath)
                    If DateDiff(Microsoft.VisualBasic.DateInterval.Second, objDRC_File(0).Item("dateChanged"), objFileInfo.LastWriteTime) > 1 Then
                        dtblA_CheckedOut.local_upd_Save(objDRC_File(0).Item("GUID_File"))
                    End If


                End If
            End If

        End If

    End Function

    Private Sub frmBlobWatcher_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            objTextWriter.Close()
        Catch ex As Exception

        End Try


        Try

            objFlagStream.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmBlobWatcher_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If boolStart = False Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            Me.Dispose()
        Else
            objSemItem_Result = objLocalConfig.SemItem_token_LogState_Active
            Timer_BlobSave.Enabled = True
            Timer_BlobSave.Start()
            boolInitialize = False
        End If

    End Sub

    Private Sub register_File(ByVal strPath As String, ByVal strName As String, Optional ByVal boolSetSave As Boolean = False)
        Dim objSemItem_Computer As clsSemItem
        Dim objFileInfo As IO.FileInfo
        Dim objDRC_File As DataRowCollection
        Dim GUID_File As Guid
        objSemItem_Computer = objLocalConfig.Globals.SemItem_Computer

        If strName.Contains(".") Then
            strName = strName.Substring(0, strName.IndexOf("."))

        End If

        If objLocalConfig.Globals.is_GUID(strName) = True Then
            If IO.File.Exists(strPath) Then
                objFileInfo = New IO.FileInfo(strPath)
                GUID_File = New Guid(strName)
                objDRC_File = semtblA_Token.GetData_Token_By_GUID(GUID_File).Rows
                If objDRC_File.Count > 0 Then
                    If dtblA_CheckedOut.GetData_local_File_By_GUID(GUID_File).Rows.Count = 0 Then
                        dtblA_CheckedOut.Insert(GUID_File, _
                                            objDRC_File(0).Item("Name_Token"), _
                                            strPath, _
                                            objFileInfo.LastWriteTime, _
                                            boolSetSave)
                    Else
                        dtblA_CheckedOut.local_upd_Save(GUID_File)
                    End If
                    


                End If
            End If

        End If

    End Sub

    Private Function is_File_Locked(ByVal strFile As String) As Boolean
        Dim boolResult As Boolean
        Dim objFileStream As IO.FileStream

        Try
            If IO.File.Exists(strFile) = True Then
                objFileStream = New IO.FileStream(strFile, IO.FileMode.Open)
                objFileStream.Close()
                boolResult = False
            Else
                boolResult = False
            End If
            
        Catch ex As Exception
            boolResult = True
        End Try

        Return boolResult
    End Function

    Private Sub FileSystemWatcher_BlobDir_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher_BlobDir.Created
        boolRegister = True
        register_File(e.FullPath, e.Name)
        boolRegister = False
    End Sub


    Private Sub Timer_BlobSave_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_BlobSave.Tick
        Dim objDRC_Files As DataRowCollection
        Dim objDR_Files As DataRow
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_File As New clsSemItem


        If boolUpdate = False And boolRegister = False And boolInitialize = False Then
            objDRC_Files = dtblA_CheckedOut.GetData_ToSave.Rows
            For Each objDR_Files In objDRC_Files
                If is_File_Locked(objDR_Files.Item("Path_File")) = False Then
                    System.Threading.Thread.Sleep(500)
                    objSemItem_File.GUID = objDR_Files.Item("GUID_File")
                    objSemItem_File.Name = objDR_Files.Item("Name_File")
                    objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                    objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objSemItem_Result = objBlobConnection.save_File_To_Blob(objSemItem_File, objDR_Files.Item("Path_File"))
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        IO.File.Delete(objDR_Files.Item("Path_File"))
                        dtblA_CheckedOut.local_del_File(objDR_Files.Item("GUID_File"))
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub FileSystemWatcher_BlobDir_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles FileSystemWatcher_BlobDir.Renamed
        boolRegister = True
        register_File(e.FullPath, e.Name, True)
        boolRegister = False
    End Sub
End Class