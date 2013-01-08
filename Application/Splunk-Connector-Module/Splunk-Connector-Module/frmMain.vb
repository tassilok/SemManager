Imports Sem_Manager
Public Class frmMain
    Private objLocalConfig As clsLocalConfig

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

    End Sub

    Private Sub Test_Report()
        objSemItem_TestReport.GUID = 
    End Sub


    Private Sub set_DBConnection()

    End Sub
End Class
