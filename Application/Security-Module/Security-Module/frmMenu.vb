Imports Sem_Manager
Public Class frmMenu

    Private objLocalConfig As clsLocalConfig

    Public Sub New(ByVal objGlobals As clsGlobals, ByVal objSemItems_Selected() As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(objGlobals)
    End Sub

    Public Sub New(ByVal objGlobals As clsGlobals, ByRef DGVSRC_Selected As DataGridViewSelectedRowCollection, ByVal strRowName_GUID As String, ByVal strRowName_Name As String, ByVal strRowName_Parent As String, ByVal GUID_Type As Guid)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(objGlobals)
    End Sub
End Class