Imports Sem_Manager
Public Class frmWikiManager
    Private objLocalConfig As Wiki_Manager.clsLocalConfig
    
    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()
        objLocalConfig = New clsLocalConfig(New clsGlobals)

    End Sub
End Class
