Imports Sem_Manager
Imports System.Net.Sockets
Public Class clsSplunk
    Private objTCPClient As TcpClient
    Private objNetworkStream As Net.Sockets.NetworkStream
    Private objUserData As clsUserData

    Private objLocalConfig As clsLocalConfig

    Private objDataTable As DataTable
    Private objDataAdp As SqlClient.SqlDataAdapter
    Private objDataSet As DataSet


    Private objSemItem_Report As clsSemItem

    Public ReadOnly Property SemItem_Text_Report
        Get
            Return objUserData.TextConfig_Report
        End Get
    End Property


    Public ReadOnly Property SemItem_Text_Row
        Get
            Return objUserData.TextConfig_Row
        End Get
    End Property

    Public ReadOnly Property SemItem_Text_Field
        Get
            Return objUserData.TextConfig_Field
        End Get
    End Property

    Public Function exists_Variable(ByVal SemItem_XML As clsSemItem, ByVal SemItem_Variable As clsSemItem) As DataRow()
        Dim objDRs_Variables() As DataRow

        objDRs_Variables = objUserData.XML_Variable_T.Select("GUID_XML='" & SemItem_XML.GUID.ToString & "' AND GUID_Variable='" & SemItem_Variable.GUID.ToString & "'")

        Return objDRs_Variables
    End Function

    Public Function write_Line(ByVal strLine As String) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Try
            objNetworkStream.Write(System.Text.Encoding.UTF8.GetBytes(strLine), 0, System.Text.Encoding.UTF8.GetBytes(strLine).Length - 1)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try


        Return objSemItem_Result
    End Function

    Public Function Initialize_Client() As clsSemItem
        Dim objSemItem_Result As clsSemItem


        objTCPClient = New TcpClient()
        Try
            objTCPClient.Connect(objUserData.SemItem_Server.Name, objUserData.SemItem_Port.Name)
            objNetworkStream = objTCPClient.GetStream()
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        Return objSemItem_Result
    End Function


    Public Sub finalize_Client()
        Try
            objNetworkStream.Close()
        Catch ex As Exception

        End Try
        Try

            objTCPClient.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objUserData = New clsUserData(objLocalConfig)
    End Sub
End Class
