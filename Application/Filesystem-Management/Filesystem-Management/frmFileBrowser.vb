Imports ClassLibrary_ShellWork
Public Class frmFileBrowser

    Private objDGVSRC_Selected As DataGridViewSelectedRowCollection
    Private dtbl_Files As New ds_FilesystemManagement.dtbl_FilesDataTable
    Private objShellWork As New clsShellWork
    Private strPath As String

    Public ReadOnly Property DGVSRC_Selected() As DataGridViewSelectedRowCollection
        Get
            Return objDGVSRC_Selected
        End Get
    End Property

    Public Sub New(ByVal Path As String)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        strPath = Path
        Me.Text = strPath
        fill_DataGrid()
    End Sub

    Private Sub fill_DataGrid()
        Dim strFile As String

        If strPath.EndsWith(":") Then
            strPath = strPath & "\"
        End If
        Try
            For Each strFile In IO.Directory.GetFiles(strPath)
                If strFile.Contains("\") Then
                    strFile = strFile.Substring(strFile.LastIndexOf("\") + 1)
                Else
                    If strFile.Contains(":") Then
                        strFile = strFile.Substring(strFile.LastIndexOf(":") + 1)
                    End If
                End If

                dtbl_Files.Rows.Add(strFile)
            Next

            BindingSource_Files.DataSource = dtbl_Files
            DataGridView_Files.DataSource = BindingSource_Files
            DataGridView_Files.Columns(0).Width = 500
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        objDGVSRC_Selected = DataGridView_Files.SelectedRows
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ContextMenuStrip_Files_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Files.Opening

        ApplyToolStripMenuItem.Enabled = False
        If DataGridView_Files.SelectedRows.Count > 0 Then
            ApplyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub OpenFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFolderToolStripMenuItem.Click
        If objShellWork.start_Process(strPath, Nothing, strPath, False, False) = False Then
            MsgBox("Der Ordner kann nicht geöffnet werden!", MsgBoxStyle.Exclamation)
        End If

    End Sub
End Class