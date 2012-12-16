Imports Sem_Manager
Public Class clsUserData

    Private objLocalConfig As clsLocalConfig

    Private objSemItem_URL As New clsSemItem

    Public ReadOnly Property SemItem_URL
        Get
            Return objSemItem_URL
        End Get
    End Property

    Private Sub set_DBConnection()


    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub
End Class
