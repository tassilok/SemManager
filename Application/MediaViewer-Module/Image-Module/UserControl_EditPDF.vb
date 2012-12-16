Imports Sem_Manager
Imports Filesystem_Management
Public Class UserControl_EditPDF
    Private objLocalConfig As clsLocalConfig
    Private objSemItem_Token As clsSemItem
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private objBlobConnection As clsBlobConnection
    Private objFileWork As clsFileWork

    Public Sub New(ByVal SemItem_Token As clsSemItem, ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Token = SemItem_Token
        objLocalConfig = LocalConfig
        set_DBConnection()
        load_PDF()
    End Sub


    Private Sub load_PDF()
        Dim objDRC_File As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_File As New clsSemItem
        Dim strPath As String

        objDRC_File = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Token.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                    objLocalConfig.SemItem_Type_File.GUID).Rows

        If objDRC_File.Count > 0 Then
            objSemItem_File.GUID = objDRC_File(0).Item("GUID_Token_Right")
            objSemItem_File.Name = objDRC_File(0).Item("Name_Token_Right")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            strPath = Environment.ExpandEnvironmentVariables("%temp%") & "\" & Guid.NewGuid.ToString & objSemItem_File.Name.Substring(objSemItem_File.Name.LastIndexOf("."))


            objSemItem_Result = objBlobConnection.is_Blob_Present(objSemItem_File)
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath)
            Else


                strPath = objFileWork.get_Path_FileSystemObject(objSemItem_File)
                If Not IO.File.Exists(strPath) Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    MsgBox("Die Datei existiert nicht", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
            MsgBox("Es konnte keine Datei ermittelt werden!", MsgBoxStyle.Exclamation)
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            AxFoxitReaderOCX_Viewer.OpenFile(strPath)
        End If
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
        objFileWork = New clsFileWork(objLocalConfig.Globals)
    End Sub
End Class
