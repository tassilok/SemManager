Imports Sem_Manager
Public Class clsReportXMLExport
    Private objLocalConfig As clsLocalConfig
    Private objXMLDoc As Xml.XmlDocument

    Private objUserData As clsUserData

    Private objDataTable As DataTable
    Private objDataAdp As SqlClient.SqlDataAdapter
    Private objDataSet As DataSet

    Private objSemItem_Report As clsSemItem

    Private boolRowHeader As Boolean

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)
        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
    End Sub

    Public Function initialize(ByVal SemItem_Report As clsSemItem) As clsSemItem
        Dim strView As String
        Dim strDatabase As String
        Dim strServer As String
        Dim strConn As String

        Dim objSemItem_Result As clsSemItem

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

                        objSemItem_Result = objUserData.get_Data_XMLConfig(objLocalConfig.SemItem_User)

                    End If

                End If
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function create_XML() As clsSemItem
        Dim objTextWriter As IO.TextWriter
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Text_Table As clsSemItem
        Dim objSemItem_Text_Row As clsSemItem
        Dim strTable As String
        Dim strRow As String
        Dim objSemItem_Text_Cell As clsSemItem
        Dim strCell As String
        Dim objDRs_Var_Table() As DataRow
        Dim objDRs_Var_Row() As DataRow
        Dim objDRs_Var_Cell() As DataRow
        Dim lngRowCount As Long
        Dim lngColCount As Long

        Dim objDR As DataRow
        Dim objDR_Col As DataRow
        Dim l As Long
        Dim boolHeader As Boolean = False

        l = 1

        objSemItem_Text_Table = objUserData.TextConfig_Table

        objSemItem_Text_Row = objUserData.TextConfig_Row
        objDRs_Var_Row = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Row.GUID.ToString & "'")

        objSemItem_Text_Cell = objUserData.TextConfig_Cell
        objDRs_Var_Cell = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Cell.GUID.ToString & "'")

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If IO.File.Exists("test.xml") Then
            IO.File.Delete("test.xml")
        End If
        objTextWriter = New IO.StreamWriter("test.xml", False)
        If objSemItem_Text_Table.Additional1 <> "" Then
            strTable = objSemItem_Text_Table.Additional1
            objDRs_Var_Table = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Table.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.GUID.ToString & "'")
            If objDRs_Var_Table.Count > 0 Then
                objDRs_Var_Table = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Table.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_AUTHOR.GUID.ToString & "'")
                If objDRs_Var_Table.Count > 0 Then
                    strTable = strTable.Replace("@" + objLocalConfig.SemItem_Token_Variable_AUTHOR.Name & "@", objLocalConfig.SemItem_User.Name)

                End If
                objDRs_Var_Table = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Table.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_DATETIME_TZ.GUID.ToString & "'")
                If objDRs_Var_Table.Count > 0 Then
                    strTable = strTable.Replace("@" + objLocalConfig.SemItem_Token_Variable_DATETIME_TZ.Name & "@", Now.ToString("s"))

                End If
                objDRs_Var_Table = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Table.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_REPORT_20.GUID.ToString & "'")
                If objDRs_Var_Table.Count > 0 Then
                    If objSemItem_Report.Name.Length > 20 Then
                        strTable = strTable.Replace("@" + objLocalConfig.SemItem_Token_Variable_REPORT_20.Name & "@", objSemItem_Report.Name.Substring(0, 19))
                    Else
                        strTable = strTable.Replace("@" + objLocalConfig.SemItem_Token_Variable_REPORT_20.Name & "@", objSemItem_Report.Name)
                    End If



                End If


                objDRs_Var_Table = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Table.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_ROWCOUNT.GUID.ToString & "'")
                If objDRs_Var_Table.Count > 0 Then
                    lngRowCount = objDataTable.Rows.Count + 1
                    strTable = strTable.Replace("@" + objLocalConfig.SemItem_Token_Variable_ROWCOUNT.Name & "@", lngRowCount)

                End If

                objDRs_Var_Table = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Table.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_COLCOUNT.GUID.ToString & "'")
                If objDRs_Var_Table.Count > 0 Then
                    lngColCount = 0
                    For Each objDR_Col In objUserData.ReportFields_procT.Rows
                        If objDR_Col.Item("invisible") = False Then
                            lngColCount = lngColCount + 1
                        End If
                    Next
                    strTable = strTable.Replace("@" + objLocalConfig.SemItem_Token_Variable_COLCOUNT.Name & "@", lngColCount)

                End If
                objTextWriter.WriteLine(strTable.Substring(0, strTable.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.Name & "@")))

                For Each objDR In objDataTable.Rows
                    strRow = objSemItem_Text_Row.Additional1
                    objDRs_Var_Row = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Row.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_id.GUID.ToString & "'")
                    If objDRs_Var_Row.Count > 0 Then
                        strRow = strRow.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", l)
                    End If

                    objDRs_Var_Row = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Row.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.GUID.ToString & "'")
                    If objDRs_Var_Row.Count > 0 Then

                        If objUserData.XMLConfig_procT.Rows(0).Item("RowHeader") = True Then
                            If boolHeader = False Then
                                objTextWriter.WriteLine(strRow.Substring(0, strRow.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.Name & "@")))
                                For Each objDR_Col In objUserData.ReportFields_procT.Rows
                                    strCell = objSemItem_Text_Cell.Additional1
                                    If objDR_Col.Item("invisible") = False Then
                                        objDRs_Var_Cell = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Cell.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_CELL_VALUE.GUID.ToString & "'")
                                        If objDRs_Var_Cell.Count > 0 Then
                                            strCell = strCell.Replace("@" & objLocalConfig.SemItem_Token_Variable_CELL_VALUE.Name & "@", Web.HttpUtility.HtmlEncode(objDR_Col.Item("Name_ReportField").ToString))
                                            objTextWriter.WriteLine(strCell)
                                        End If
                                    End If
                                Next
                                boolHeader = True
                                objTextWriter.WriteLine(strRow.Substring(strRow.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.Name & "@") + Len("@" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.Name & "@")))
                                l = l + 1
                                strRow = objSemItem_Text_Row.Additional1
                                objDRs_Var_Row = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Row.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_id.GUID.ToString & "'")
                                If objDRs_Var_Row.Count > 0 Then
                                    strRow = strRow.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", l)
                                End If
                            End If
                        End If
                        

                        objTextWriter.WriteLine(strRow.Substring(0, strRow.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.Name & "@")))
                        For Each objDR_Col In objUserData.ReportFields_procT.Rows
                            strCell = objSemItem_Text_Cell.Additional1
                            If objDR_Col.Item("invisible") = False Then
                                objDRs_Var_Cell = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Cell.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_CELL_NAME.GUID.ToString & "'")
                                If objDRs_Var_Cell.Count > 0 Then
                                    strCell = strCell.Replace("@" & objLocalConfig.SemItem_Token_Variable_CELL_NAME.Name & "@", Web.HttpUtility.HtmlEncode(objDR_Col.Item("Name_ReportField").ToString))

                                End If

                                objDRs_Var_Cell = objUserData.XML_Variable_ProcT.Select("GUID_XML='" & objSemItem_Text_Cell.GUID.ToString & "' AND GUID_Variable='" & objLocalConfig.SemItem_Token_Variable_CELL_VALUE.GUID.ToString & "'")
                                If objDRs_Var_Cell.Count > 0 Then
                                    strCell = strCell.Replace("@" & objLocalConfig.SemItem_Token_Variable_CELL_VALUE.Name & "@", Web.HttpUtility.HtmlEncode(objDR.Item(objDR_Col.Item("Name_DBColumn")).ToString))

                                End If
                                objTextWriter.WriteLine(strCell)

                            End If
                        Next
                        objTextWriter.WriteLine(strRow.Substring(strRow.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.Name & "@") + Len("@" & objLocalConfig.SemItem_Token_Variable_CELL_LIST.Name & "@")))

                    End If


                    l = l + 1
                Next
                objTextWriter.WriteLine(strTable.Substring(strTable.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.Name & "@") + Len("@" & objLocalConfig.SemItem_Token_Variable_ROW_LIST.Name & "@")))
            End If
        End If


        objTextWriter.Close()

        Return objSemItem_Result
    End Function

    Private Sub get_Data()

        objDataTable.Clear()

        objUserData.initiaize_ReportFields(objSemItem_Report)
        While objUserData.finished_Data_ReportFields = False
        End While
        objUserData.initialize_Report(objSemItem_Report)

    End Sub

    Private Sub set_DBConnection()
        objUserData = New clsUserData(objLocalConfig)

    End Sub
End Class
