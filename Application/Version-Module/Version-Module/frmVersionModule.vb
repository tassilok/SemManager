Public Class frmVersionModule
    Private objLocalConfig As clsLocalConfig
    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        'test_Major()
    End Sub

    Private Sub test_Major()
        Dim GUID_Version As Guid
        Dim GUID_TypeVersion As Guid
        Dim GUID_Attribute_Major As Guid
        Dim objDRC_LogState As DataRowCollection
        Dim intMajor As Integer

        Dim procA_ModDBWork_Save_Version_MajorMinorBuildRevision As New ds_ModDBWorkTableAdapters.proc_ModDBWork_Save_Version_MajorMinorBuildRevisionTableAdapter

        intMajor = 2
        GUID_TypeVersion = New Guid("f30436d6-2ffc-4071-af5e-3ce708b8c2d9")
        GUID_Version = New Guid("1d3e6ce8-854e-4c81-8167-6b5ba293ad12")
        GUID_Attribute_Major = New Guid("e57ea6f4-77d5-4cc7-9070-d0ea3308092f")

        objDRC_LogState = procA_ModDBWork_Save_Version_MajorMinorBuildRevision.GetData(GUID_Version, GUID_TypeVersion, GUID_Attribute_Major, intMajor).Rows
        MsgBox(objDRC_LogState(0).Item("Name_Token"))

    End Sub
End Class
