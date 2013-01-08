Imports Sem_Manager
Imports System.Net.Sockets
Imports ReportsTest
Public Class clsSplunk
    Private objTCPClient As TcpClient
    Private objUserData As clsUserData
    Private objReportUserData As ReportsTest.clsUserData

    Private objLocalConfig As clsLocalConfig

    Private objDataTable As DataTable
    Private objDataAdp As SqlClient.SqlDataAdapter
    Private objDataSet As DataSet


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

    Public Sub get_data()
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDataTable.Clear()
        objReportUserData.initiaize_ReportFields(objSemItem_Report)
        While objReportUserData.finished_Data_ReportFields = False

        End While
        objReportUserData.initialize_Report(objSemItem_Report)


    End Sub

    Public Function write_Report(ByVal SemItem_Report As clsSemItem) As clsSemItem
        Dim strReport As String
        Dim dateDateTime As Date
        Dim objDR_Cols As DataRow
        Dim objDRs_Variables() As DataRow

        objSemItem_Report = SemItem_Report


        dateDateTime = Now
        
        Dim strView As String
        Dim strDatabase As String
        Dim strServer As String
        Dim strConn As String

        Dim objSemItem_Text_Report As clsSemItem
        Dim objSemItem_Text_Row As clsSemItem
        Dim objSemItem_Text_Field As clsSemItem
        Dim strRow As String
        Dim strField As String
        Dim strWrite As String

        Dim objSemItem_Result As clsSemItem
        Dim objDR_Row As DataRow


        Dim objNetworkStream As Net.Sockets.NetworkStream

        



        objSemItem_Result = Initialize_Client()

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objDataTable = New DataTable
            objDataSet = New DataSet
            objSemItem_Report = SemItem_Report
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
            If objSemItem_Report Is Nothing Then
                objDataTable.Clear()

            Else

                get_data()
                objSemItem_Text_Report = objUserData.TextConfig_Report
                objSemItem_Text_Row = objUserData.TextConfig_Row
                objSemItem_Text_Field = objUserData.TextConfig_Field
                While objReportUserData.finished_Data_Report = False

                End While
                If objReportUserData.finished_Data_Report = True Then
                    If objReportUserData.Report_procT.Rows.Count > 0 Then
                        If Not IsDBNull(objReportUserData.Report_procT.Rows(0).Item("Name_DBItem")) Then



                            strView = objReportUserData.Report_procT.Rows(0).Item("Name_DBItem")

                            strDatabase = objReportUserData.Report_procT.Rows(0).Item("Name_Database")
                            strServer = objReportUserData.Report_procT.Rows(0).Item("Name_Server")
                            strConn = "Data Source=" & strServer & "\SQLEXPRESS;Initial Catalog=" & strDatabase & ";Integrated Security=True"
                            objDataAdp = New SqlClient.SqlDataAdapter("SELECT * FROM [" & strDatabase & "]..[" & strView & "]", strConn)

                            objDataAdp.Fill(objDataSet)
                            objDataTable = objDataSet.Tables(0)
                            objNetworkStream = objTCPClient.GetStream()

                            objDRs_Variables = objUserData.XML_Variable_T.Select("GUID_XML='" & objSemItem_Text_Report.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.GUID.ToString & "'")
                            If objDRs_Variables.Count > 0 Then
                                strReport = objSemItem_Text_Report.Additional1
                                
                                objDRs_Variables = objUserData.XML_Variable_T.Select("GUID_XML='" & objSemItem_Text_Report.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.GUID.ToString & "'")
                                If objDRs_Variables.Count > 0 Then
                                    strWrite = strReport.Substring(0, strReport.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.Name & "@"))
                                    If strWrite <> "" Then
                                        objNetworkStream.Write(System.Text.Encoding.UTF8.GetBytes(strWrite), 0, System.Text.Encoding.UTF8.GetBytes(strWrite).Length - 1)
                                    End If


                                End If
                                For Each objDR_Row In objDataTable.Rows
                                    strRow = objSemItem_Text_Row.Additional1
                                    objDRs_Variables = objUserData.XML_Variable_T.Select("GUID_XML='" & objSemItem_Text_Row.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_DATETIME_TZ.GUID.ToString & "'")
                                    If objDRs_Variables.Count > 0 Then
                                        strRow = strRow.Replace("@" & objLocalConfig.SemItem_Token_Variable_DATETIME_TZ.Name & "@", dateDateTime.ToString("s"))

                                    End If
                                    objDRs_Variables = objUserData.XML_Variable_T.Select("GUID_XML='" & objSemItem_Text_Row.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_REPORT.GUID.ToString & "'")
                                    If objDRs_Variables.Count > 0 Then
                                        strRow = strRow.Replace("@" & objLocalConfig.SemItem_Token_Variable_REPORT.Name & "@", objSemItem_Report.Name)

                                    End If
                                    objDRs_Variables = objUserData.XML_Variable_T.Select("GUID_XML='" & objSemItem_Text_Row.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.GUID.ToString & "'")
                                    If objDRs_Variables.Count > 0 Then
                                        strWrite = strRow.Substring(0, strRow.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.Name & "@"))
                                        objNetworkStream.Write(System.Text.Encoding.UTF8.GetBytes(strWrite), 0, System.Text.Encoding.UTF8.GetBytes(strWrite).Length - 1)

                                        For Each objDR_Cols In objReportUserData.ReportFields_procT.Rows
                                            strField = objSemItem_Text_Field.Additional1
                                            objDRs_Variables = objUserData.XML_Variable_T.Select("GUID_XML='" & objSemItem_Text_Field.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_CELL_NAME.GUID.ToString & "'")
                                            If objDRs_Variables.Count > 0 Then
                                                strField = strField.Replace("@" & objLocalConfig.SemItem_Token_Variable_CELL_NAME.Name & "@", objDR_Cols.Item("Name_ReportField"))

                                            End If

                                            objDRs_Variables = objUserData.XML_Variable_T.Select("GUID_XML='" & objSemItem_Text_Field.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_CELL_VALUE.GUID.ToString & "'")
                                            If objDRs_Variables.Count > 0 Then
                                                strField = strField.Replace("@" & objLocalConfig.SemItem_Token_Variable_CELL_VALUE.Name & "@", objDR_Row.Item(objDR_Cols.Item("Name_DBColumn")).ToString)

                                            End If
                                            objNetworkStream.Write(System.Text.Encoding.UTF8.GetBytes(strField), 0, System.Text.Encoding.UTF8.GetBytes(strField).Length - 1)
                                        Next

                                        strWrite = strRow.Substring(strRow.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.Name & "@") + Len("@" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.Name & "@"))
                                        objNetworkStream.Write(System.Text.Encoding.UTF8.GetBytes(strWrite), 0, System.Text.Encoding.UTF8.GetBytes(strWrite).Length - 1)
                                    End If
                                    


                                Next
                                objDRs_Variables = objUserData.XML_Variable_T.Select("GUID_XML='" & objSemItem_Text_Row.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.GUID.ToString & "'")
                                If objDRs_Variables.Count > 0 Then
                                    strWrite = strReport.Substring(strReport.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.Name & "@") + Len("@" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.Name & "@"))
                                    If strWrite <> "" Then
                                        objNetworkStream.Write(System.Text.Encoding.UTF8.GetBytes(strWrite), 0, System.Text.Encoding.UTF8.GetBytes(strWrite).Length - 1)
                                    End If


                                End If
                            End If

                            objNetworkStream.Close()

                        End If

                    End If
                End If
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            End If

            finalize_Client()
        End If
        




        Return objSemItem_Result
    End Function
    Private Sub finalize_Client()
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
        objReportUserData = New ReportsTest.clsUserData(objLocalConfig.Globals)
    End Sub
End Class
