Imports Sem_Manager
Public Class clsSplunk
    Private Const cintPort_SplunkStorm As Integer = 20173
    Private Const cstrURL_SplunkStorm As String = "logs4.splunkstorm.com"

    Private objUserData As clsUserData

    Private objDataTable As DataTable
    Private objDataAdp As SqlClient.SqlDataAdapter
    Private objDataSet As DataSet


    Private objTcpClient As New Net.Sockets.TcpClient
    Private objSemItem_Report As clsSemItem

    Private objLocalConfig As clsLocalConfig

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objUserData = New clsUserData(objLocalConfig)
    End Sub

    Private Sub get_Data()

        objDataTable.Clear()

        objUserData.initiaize_ReportFields(objSemItem_Report)
        While objUserData.finished_Data_ReportFields = False
        End While
        objUserData.initialize_Report(objSemItem_Report)

    End Sub

    Public Function write_Report(ByVal SemItem_Report As clsSemItem) As clsSemItem
        Dim strReport As String
        Dim dateDateTime As Date
        Dim objDR_Cols As DataRow

        objSemItem_Report = SemItem_Report


        dateDateTime = Now
        objTcpClient = New Net.Sockets.TcpClient
        objTcpClient.Connect(cstrURL_SplunkStorm, cintPort_SplunkStorm)

        Dim strView As String
        Dim strDatabase As String
        Dim strServer As String
        Dim strConn As String

        Dim objSemItem_Result As clsSemItem
        Dim objDR_Row As DataRow

        Dim objNetworkStream As Net.Sockets.NetworkStream

        objDataTable = New DataTable
        objDataSet = New DataSet
        objSemItem_Report = SemItem_Report
        objSemItem_Result = objLocalConfig.Globals.LogState_Error
        If objSemItem_Report Is Nothing Then
            objDataTable.Clear()

        Else

            get_Data()
            While objUserData.finished_Data_Report = False

            End While
            If objUserData.finished_Data_Report = True Then
                If objUserData.Report_procT.Rows.Count > 0 Then
                    If Not IsDBNull(objUserData.Report_procT.Rows(0).Item("Name_DBItem")) Then
                        strView = objUserData.Report_procT.Rows(0).Item("Name_DBItem")

                        strDatabase = objUserData.Report_procT.Rows(0).Item("Name_Database")
                        strServer = objUserData.Report_procT.Rows(0).Item("Name_Server")
                        strConn = "Data Source=" & strServer & "\SQLEXPRESS;Initial Catalog=" & strDatabase & ";Integrated Security=True"
                        objDataAdp = New SqlClient.SqlDataAdapter("SELECT * FROM [" & strDatabase & "]..[" & strView & "]", strConn)

                        objDataAdp.Fill(objDataSet)
                        objDataTable = objDataSet.Tables(0)
                        objNetworkStream = objTcpClient.GetStream()

                        For Each objDR_Row In objDataTable.Rows
                            strReport = dateDateTime.ToString("s") & ";<Report>" & objSemItem_Report.Name & "</report>;"
                            For Each objDR_Cols In objUserData.ReportFields_procT.Rows
                                strReport = strReport & "<" & objDR_Cols.Item("Name_ReportField") & ">" & _
                                        objDR_Row.Item(objDR_Cols.Item("Name_DBColumn")).ToString & "</" & objDR_Cols.Item("Name_ReportField") & ">;"

                            Next
                            strReport = strReport & "EOL" & vbCrLf
                            objNetworkStream.Write(System.Text.Encoding.UTF8.GetBytes(strReport), 0, System.Text.Encoding.UTF8.GetBytes(strReport).Length - 1)
                        Next

                        objNetworkStream.Close()

                    End If

                End If
            End If
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If



        objTcpClient.Close()
        Return objSemItem_Result
    End Function

    Private Sub initialize()

    End Sub


End Class
