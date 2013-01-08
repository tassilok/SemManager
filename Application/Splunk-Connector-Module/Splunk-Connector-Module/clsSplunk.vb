Imports Sem_Manager
Imports System.Net.Sockets
Public Class clsSplunk
    Private objTCPClient As TcpClient
    Private objUserData As clsUserData
    Private objReportUserData

    Private objLocalConfig As clsLocalConfig

    Private objSemItem_Report As clsSemItem

    Private Function Initialize_Client() As clsSemItem
        Dim objSemItem_Result As clsSemItem


        objTCPClient = New TcpClient()
        Try
            objTCPClient.Connect(objUserData.SemItem_Server.Name, objUserData.SemItem_Port.Name)
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        Return objSemItem_Result
    End Function

    Public Function export_Report(ByVal SemItem_Report As clsSemItem) As clsSemItem
        objSemItem_Report = SemItem_Report



    End Function

    Private Sub finalize_Client()
        Try
            objTCPClient.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
    End Sub

    Private Sub set_DBConnection()
        objUserData = New clsUserData(objLocalConfig)
    End Sub
End Class
