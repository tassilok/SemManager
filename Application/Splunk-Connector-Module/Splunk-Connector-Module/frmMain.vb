Imports Sem_Manager

Public Class frmMain
    Private objLocalConfig As clsLocalConfig

    Private objSplunk As clsSplunk

    Private objSemItem_TestReport As New clsSemItem

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)

        set_DBConnection()

        initialize()
    End Sub

    Private Sub initialize()
        Test_Report()
    End Sub

    Private Sub Test_Report()
        objSemItem_TestReport.GUID = New Guid("320749bd-88dd-4b3c-a528-2dd7e48d7dec")
        objSemItem_TestReport.Name = "Kontostände"
        objSemItem_TestReport.GUID_Parent = New Guid("30cbc6e8-9c0f-47d6-920c-97fdc40ea1de")
        objSemItem_TestReport.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objSplunk.write_Report(objSemItem_TestReport)
    End Sub


    Private Sub set_DBConnection()
        objSplunk = New clsSplunk(objLocalConfig)
    End Sub
End Class
