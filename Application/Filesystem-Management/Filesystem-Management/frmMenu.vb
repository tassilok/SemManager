Imports Sem_Manager
Imports ClassLibrary_ShellWork
Public Class frmMenu

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter

    Private objShellWork As New clsShellWork
    Private objSemItems_Work() As clsSemItem
    Private objDGVSRC_Selected As DataGridViewSelectedRowCollection
    Private objFileWork As clsFileWork
    Private objBlobConnection As clsBlobConnection
    Private strRowName_GUID As String
    Private strRowName_Name As String
    Private strRowName_Parent As String
    Private objGUID_Type As Guid
    Private boolSemItems As Boolean

    Public Sub New(ByVal SemItems_Work() As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItems_Work = SemItems_Work
        boolSemItems = True
        initialize()
    End Sub

    Public Sub New(ByVal DGVSRC_Selected As DataGridViewSelectedRowCollection, ByVal RowName_GUID As String, ByVal RowName_Name As String, ByVal RowName_Parent As String, ByVal GUID_Type As Guid)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objDGVSRC_Selected = DGVSRC_Selected
        strRowName_GUID = RowName_GUID
        strRowName_Name = RowName_Name
        strRowName_Parent = RowName_Parent
        objGUID_Type = GUID_Type
        boolSemItems = False
        initialize()
    End Sub

    Private Sub initialize()
        Dim objDGVR_Work As DataGridViewRow
        Dim objDRV_Work As DataRowView
        Dim objSemItem_Work As clsSemItem
        Dim objListViewItem As ListViewItem
        Dim strPath As String

        set_DBConnection()

        objFileWork = New clsFileWork(objLocalConfig.Globals)
        objBlobConnection = New clsBlobConnection(objLocalConfig)

        If boolSemItems = True Then
            For Each objSemItem_Work In objSemItems_Work
                If objSemItem_Work.GUID_Parent = objLocalConfig.SemItem_Type_Drive.GUID Or _
                    objSemItem_Work.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID Or _
                    objSemItem_Work.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID Then

                    strPath = objFileWork.get_Path_FileSystemObject(objSemItem_Work)
                    objListViewItem = ListView_Items.Items.Add(objSemItem_Work.GUID.ToString, strPath, 0)
                    objListViewItem.Checked = True

                End If
            Next
        Else
            If Not strRowName_GUID = "" And Not strRowName_Name = "" And Not strRowName_Parent = "" And Not objGUID_Type = Nothing Then
                For Each objDGVR_Work In objDGVSRC_Selected
                    objDRV_Work = objDGVR_Work.DataBoundItem
                    If objDRV_Work.Item(strRowName_Parent) = objLocalConfig.SemItem_Type_Drive.GUID Or _
                        objDRV_Work.Item(strRowName_Parent) = objLocalConfig.SemItem_type_Folder.GUID Or _
                        objDRV_Work.Item(strRowName_Parent) = objLocalConfig.SemItem_Type_File.GUID Then

                        objSemItem_Work = New clsSemItem
                        objSemItem_Work.GUID = objDRV_Work.Item(strRowName_GUID)
                        objSemItem_Work.Name = objDRV_Work.Item(strRowName_Name)
                        objSemItem_Work.GUID_Parent = objDRV_Work.Item(strRowName_Parent)
                        objSemItem_Work.GUID_Type = objGUID_Type

                        strPath = objFileWork.get_Path_FileSystemObject(objSemItem_Work)
                        objListViewItem = ListView_Items.Items.Add(objSemItem_Work.GUID.ToString, strPath, 0)
                        objListViewItem.Checked = True
                    End If
                Next
            End If
            
        End If
    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
    End Sub
    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Close()
    End Sub

    Private Sub Button_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Open.Click
        Dim objListViewItem As ListViewItem

        For Each objListViewItem In ListView_Items.Items
            If objListViewItem.Checked = True Then
                If objShellWork.start_Process(objListViewItem.Text, Nothing, Nothing, False, False) = False Then
                    MsgBox("Datei kann nicht gestartet werden!")
                End If
            End If
        Next
    End Sub

    Private Sub Button_CopyLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CopyLink.Click
        Dim objListViewItem As ListViewItem
        Dim strCopy As String

        strCopy = ""
        For Each objListViewItem In ListView_Items.Items
            If objListViewItem.Checked = True Then

                If Not strCopy = "" Then
                    strCopy = strCopy & vbCrLf
                End If
                strCopy = strCopy & objListViewItem.Text
            End If
        Next
        Clipboard.SetDataObject(strCopy)
    End Sub

    Private Sub Button_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Delete.Click
        Dim objListViewItem As ListViewItem
        Dim objDRC_Token As DataRowCollection
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        For Each objListViewItem In ListView_Items.Items
            If objListViewItem.Checked = True Then
                objDRC_Token = semtblA_Token.GetData_Token_By_GUID(New Guid(objListViewItem.Name)).Rows
                If objDRC_Token.Count > 0 Then

                    objSemItem_File.GUID = objDRC_Token(0).Item("GUID_Token")
                    objSemItem_File.Name = objDRC_Token(0).Item("Name_Token")
                    objSemItem_File.GUID_Parent = objDRC_Token(0).Item("GUID_Type")
                    objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    If objFileWork.is_File_Blob(objSemItem_File) Then
                        objSemItem_File = objBlobConnection.del_Blob(objSemItem_File)
                        If objSemItem_File.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Die Datei konnte nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        If MsgBox("Die Datei liegt nicht als Blob vor. Soll sie trotzdem gelöscht werden!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Try
                                objSemItem_File.Additional1 = objFileWork.get_Path_FileSystemObject(objSemItem_File, True)
                                Select Case objSemItem_File.GUID_Parent
                                    Case objLocalConfig.SemItem_Type_File.GUID
                                        If IO.File.Exists(objSemItem_File.Additional1) Then
                                            IO.File.Delete(objSemItem_File.Additional1)

                                        Else
                                            MsgBox("Die Datei existiert nicht!", MsgBoxStyle.Exclamation)
                                        End If
                                    Case objLocalConfig.SemItem_type_Folder.GUID
                                        If IO.Directory.Exists(objSemItem_File.Additional1) Then
                                            IO.Directory.Delete(objSemItem_File.Additional1, True)

                                        Else
                                            MsgBox("Die Datei existiert nicht!", MsgBoxStyle.Exclamation)
                                        End If
                                    Case Else
                                        MsgBox("Item kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                                End Select
                            Catch ex As Exception
                                MsgBox("Item kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                            End Try

                        End If

                    End If
                Else
                    MsgBox("Die Datei existiert nicht mehr!", MsgBoxStyle.Critical)
                End If
            End If
        Next
    End Sub
End Class