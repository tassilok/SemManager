Imports Sem_Manager
Imports Splunk_Connector_Module
Public Class clsSplunkPrepare
    Private Const cintPort_SplunkStorm As Integer = 20173
    Private Const cstrURL_SplunkStorm As String = "logs4.splunkstorm.com"

    Private objUserData As clsUserData

    Private objDataTable As DataTable
    Private objDataAdp As SqlClient.SqlDataAdapter
    Private objDataSet As DataSet

    Private objSplunk As Splunk_Connector_Module.clsSplunk
    Private objSemItem_Report As clsSemItem

    Private objLocalConfig As clsLocalConfig

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objUserData = New clsUserData(objLocalConfig)
        objSplunk = New Splunk_Connector_Module.clsSplunk(objLocalConfig.Globals)
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





        objSemItem_Result = objSplunk.Initialize_Client()

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objDataTable = New DataTable
            objDataSet = New DataSet
            objSemItem_Report = SemItem_Report
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
            If objSemItem_Report Is Nothing Then
                objDataTable.Clear()

            Else

                get_Data()
                objSemItem_Text_Report = objSplunk.SemItem_Text_Report
                objSemItem_Text_Row = objSplunk.SemItem_Text_Row
                objSemItem_Text_Field = objSplunk.SemItem_Text_Field
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



                            strReport = objSemItem_Text_Report.Additional1

                            objDRs_Variables = objSplunk.exists_Variable(objSemItem_Text_Report, objLocalConfig.SemItem_Token_Variable_ROW_LIST)
                            If objDRs_Variables.Count > 0 Then
                                strWrite = strReport.Substring(0, strReport.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.Name & "@"))
                                If strWrite <> "" Then
                                    objSplunk.write_Line(strWrite)

                                End If


                            End If
                            For Each objDR_Row In objDataTable.Rows
                                strRow = objSemItem_Text_Row.Additional1
                                objDRs_Variables = objSplunk.exists_Variable(objSemItem_Text_Row, objLocalConfig.SemItem_Token_Variable_DATETIME_TZ)
                                If objDRs_Variables.Count > 0 Then
                                    strRow = strRow.Replace("@" & objLocalConfig.SemItem_Token_Variable_DATETIME_TZ.Name & "@", dateDateTime.ToString("s"))

                                End If
                                objDRs_Variables = objSplunk.exists_Variable(objSemItem_Text_Row, objLocalConfig.SemItem_Token_Variable_REPORT)
                                If objDRs_Variables.Count > 0 Then
                                    strRow = strRow.Replace("@" & objLocalConfig.SemItem_Token_Variable_REPORT.Name & "@", objSemItem_Report.Name)

                                End If
                                objDRs_Variables = objSplunk.exists_Variable(objSemItem_Text_Row, objLocalConfig.SemItem_Token_Variable_CELL_LIST)
                                If objDRs_Variables.Count > 0 Then
                                    strWrite = strRow.Substring(0, strRow.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.Name & "@"))
                                    objSplunk.write_Line(strWrite)

                                    For Each objDR_Cols In objUserData.ReportFields_procT.Rows
                                        strField = objSemItem_Text_Field.Additional1

                                        objDRs_Variables = objSplunk.exists_Variable(objSemItem_Text_Field, objLocalConfig.SemItem_Token_Variable_CELL_NAME)
                                        If objDRs_Variables.Count > 0 Then
                                            strField = strField.Replace("@" & objLocalConfig.SemItem_Token_Variable_CELL_NAME.Name & "@", objDR_Cols.Item("Name_ReportField"))

                                        End If

                                        objDRs_Variables = objSplunk.exists_Variable(objSemItem_Text_Field, objLocalConfig.SemItem_Token_Variable_CELL_VALUE)
                                        If objDRs_Variables.Count > 0 Then
                                            strField = strField.Replace("@" & objLocalConfig.SemItem_Token_Variable_CELL_VALUE.Name & "@", objDR_Row.Item(objDR_Cols.Item("Name_DBColumn")).ToString)

                                        End If
                                        objSplunk.write_Line(strField)
                                    Next

                                    strWrite = strRow.Substring(strRow.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.Name & "@") + Len("@" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.Name & "@"))
                                    If strWrite <> "" Then
                                        objSplunk.write_Line(strWrite)
                                    End If

                                End If



                            Next

                            objDRs_Variables = objSplunk.exists_Variable(objSemItem_Text_Row, objLocalConfig.SemItem_Token_Variable_ROW_LIST)
                            If objDRs_Variables.Count > 0 Then
                                strWrite = strReport.Substring(strReport.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.Name & "@") + Len("@" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.Name & "@"))
                                If strWrite <> "" Then
                                    objSplunk.write_Line(strWrite)
                                End If


                            End If




                        End If

                    End If
                End If
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            End If

            objSplunk.finalize_Client()
        End If





        Return objSemItem_Result
    End Function

    Private Sub initialize()

    End Sub


End Class
