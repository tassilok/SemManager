Imports Sem_Manager
Public Class clsUserData
    Private objLocalConfig As clsLocalConfig
    Private strConnection_DB As String
    Private strConnection_Module As String

    Private procA_ReportTree As New DataSet_ReportsTableAdapters.proc_ReportTreeTableAdapter
    Private procT_ReportTree As New DataSet_Reports.proc_ReportTreeDataTable

    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private funcT_Token_OR As New ds_ObjectReference.func_Token_ORDataTable

    Private procA_Report As New DataSet_ReportsTableAdapters.proc_ReportTableAdapter
    Private procT_Report As New DataSet_Reports.proc_ReportDataTable

    Private procA_ReportFields As New DataSet_ReportsTableAdapters.proc_ReportFieldsTableAdapter
    Private procT_ReportFields As New DataSet_Reports.proc_ReportFieldsDataTable

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter

    Private dtblA_Columns As New DataSet_ReportsTableAdapters.dtbl_ColumnsTableAdapter
    Private dtblT_Columns As New DataSet_Reports.dtbl_ColumnsDataTable

    Private procA_XMLConfig As New DataSet_ReportsTableAdapters.proc_XMLConfigTableAdapter
    Private procT_XMLConfig As New DataSet_Reports.proc_XMLConfigDataTable

    Private procA_XML_Variable As New DataSet_ReportsTableAdapters.proc_XML_VariableTableAdapter
    Private procT_XML_Variable As New DataSet_Reports.proc_XML_VariableDataTable

    Private procA_ReportFieldTypes As New DataSet_ReportsTableAdapters.proc_ReportFieldTypesTableAdapter
    Private procT_ReportFieldTypes As New DataSet_Reports.proc_ReportFieldTypesDataTable

    Private objTransaction_Reports As clsTransaction_Reports

    Private objSemItem_Report As clsSemItem
    Private objSemItem_User As clsSemItem

    Private objThread_Data_ReportTree As Threading.Thread
    Private objThread_Data_Reports As Threading.Thread
    Private objThread_Data_Report As Threading.Thread
    Private objThread_Data_ReportFields As Threading.Thread

    Private boolData_ReportTree As Boolean
    Private boolData_Reports As Boolean
    Private boolData_Report As Boolean
    Private boolData_ReportFields As Boolean

    Public ReadOnly Property FieldTypes_procT As DataSet_Reports.proc_ReportFieldTypesDataTable
        Get
            Return procT_ReportFieldTypes
        End Get
    End Property
    Public ReadOnly Property ReportFields_procT As DataSet_Reports.proc_ReportFieldsDataTable
        Get
            Return procT_ReportFields
        End Get
    End Property
    Public ReadOnly Property ReportTree_procT As DataSet_Reports.proc_ReportTreeDataTable
        Get
            Return procT_ReportTree
        End Get
    End Property

    Public ReadOnly Property Report_procT As DataSet_Reports.proc_ReportDataTable
        Get
            Return procT_Report
        End Get
    End Property

    Public ReadOnly Property XMLConfig_procT As DataSet_Reports.proc_XMLConfigDataTable
        Get
            Return procT_XMLConfig
        End Get
    End Property

    Public ReadOnly Property XML_Variable_ProcT As DataSet_Reports.proc_XML_VariableDataTable
        Get
            Return procT_XML_Variable
        End Get
    End Property

    Public ReadOnly Property finished_Data_ReportTree As Boolean
        Get
            Return boolData_ReportTree
        End Get
    End Property

    Public ReadOnly Property finished_Data_Reports As Boolean
        Get
            Return boolData_Reports
        End Get
    End Property

    Public ReadOnly Property finished_Data_Report As Boolean
        Get
            Return boolData_Report
        End Get
    End Property

    Public ReadOnly Property finished_Data_ReportFields As Boolean
        Get
            Return boolData_ReportFields
        End Get
    End Property

    Public ReadOnly Property TextConfig_Table As clsSemItem
        Get
            Dim objXMLDom As New Xml.XmlDocument
            Dim objXMLElement As Xml.XmlElement
            Dim objSemItem_Text As New clsSemItem

            If procT_XMLConfig.Rows.Count = 1 Then
                Try
                    objXMLDom.LoadXml(procT_XMLConfig.Rows(0).Item("XMLTable"))
                    objXMLElement = objXMLDom.GetElementsByTagName("data").Item(0)

                    objSemItem_Text.GUID = procT_XMLConfig.Rows(0).Item("GUID_XML_Table")
                    objSemItem_Text.Name = procT_XMLConfig.Rows(0).Item("Name_XML_Table")
                    objSemItem_Text.Additional1 = objXMLElement.InnerText
                    objSemItem_Text.GUID_Parent = objLocalConfig.SemItem_Type_XML.GUID
                    objSemItem_Text.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                Catch ex As Exception
                    objSemItem_Text = Nothing
                End Try


            Else
                objSemItem_Text = Nothing
            End If

            Return objSemItem_Text
        End Get
    End Property

    Public ReadOnly Property TextConfig_Row As clsSemItem
        Get
            Dim objXMLDom As New Xml.XmlDocument
            Dim objXMLElement As Xml.XmlElement
            Dim objSemItem_Text As New clsSemItem

            If procT_XMLConfig.Rows.Count = 1 Then
                Try
                    objXMLDom.LoadXml(procT_XMLConfig.Rows(0).Item("XMLRow"))
                    objXMLElement = objXMLDom.GetElementsByTagName("data").Item(0)

                    objSemItem_Text.GUID = procT_XMLConfig.Rows(0).Item("GUID_XML_Row")
                    objSemItem_Text.Name = procT_XMLConfig.Rows(0).Item("Name_XML_Row")
                    objSemItem_Text.Additional1 = objXMLElement.InnerText
                    objSemItem_Text.GUID_Parent = objLocalConfig.SemItem_Type_XML.GUID
                    objSemItem_Text.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                Catch ex As Exception
                    objSemItem_Text = Nothing
                End Try


            Else
                objSemItem_Text = Nothing
            End If

            Return objSemItem_Text
        End Get
    End Property

    Public ReadOnly Property TextConfig_Cell As clsSemItem
        Get
            Dim objXMLDom As New Xml.XmlDocument
            Dim objXMLElement As Xml.XmlElement
            Dim objSemItem_Text As New clsSemItem

            If procT_XMLConfig.Rows.Count = 1 Then
                Try
                    objXMLDom.LoadXml(procT_XMLConfig.Rows(0).Item("XMLCell"))
                    objXMLElement = objXMLDom.GetElementsByTagName("data").Item(0)

                    objSemItem_Text.GUID = procT_XMLConfig.Rows(0).Item("GUID_XML_Cell")
                    objSemItem_Text.Name = procT_XMLConfig.Rows(0).Item("Name_XML_Cell")
                    objSemItem_Text.Additional1 = objXMLElement.InnerText
                    objSemItem_Text.GUID_Parent = objLocalConfig.SemItem_Type_XML.GUID
                    objSemItem_Text.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                Catch ex As Exception
                    objSemItem_Text = Nothing
                End Try


            Else
                objSemItem_Text = Nothing
            End If

            Return objSemItem_Text
        End Get
    End Property

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)
        set_DBConnection()
    End Sub

    Public Function get_Data_XMLConfig(ByVal SemItem_User As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem


        objSemItem_User = SemItem_User

        procA_XMLConfig.Fill(procT_XMLConfig, _
                             objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                             objLocalConfig.SemItem_Attribute_Row_Header.GUID, _
                             objLocalConfig.SemItem_Type_XML_Config.GUID, _
                             objLocalConfig.SemItem_Type_XML.GUID, _
                             objLocalConfig.SemItem_type_User.GUID, _
                             objLocalConfig.SemItem_Type_Variable.GUID, _
                             objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                             objLocalConfig.SemItem_RelationType_Table_Config.GUID, _
                             objLocalConfig.SemItem_RelationType_Row_Config.GUID, _
                             objLocalConfig.SemItem_RelationType_Cell_Config.GUID, _
                             objLocalConfig.SemItem_RelationType_contains.GUID, _
                             objSemItem_User.GUID)

        procA_XML_Variable.Fill(procT_XML_Variable, _
                                objSemItem_User.GUID)


        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        Return objSemItem_Result
    End Function

    Public Function get_Columns(ByVal objSemItem_Report As clsSemItem) As clsSemItem
        Dim objConnection As SqlClient.SqlConnection
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_View As New clsSemItem
        Dim objDRs_FieldType() As DataRow
        Dim objDRs_View() As DataRow
        Dim objDRs_Exists() As DataRow
        Dim objDR_Column As DataRow
        Dim objDRC_Column As DataRowCollection
        Dim objSemItem_DBColumn As New clsSemItem
        Dim objSemItem_ReportField As New clsSemItem
        Dim objSemItem_Type As New clsSemItem
        Dim intToDo As Integer
        Dim intDone As Integer
        Dim boolVisible As Boolean

        get_Data_Report(objSemItem_Report)
        objDRs_View = procT_Report.Select("GUID_Report='" & objSemItem_Report.GUID.ToString & "'")

        If objDRs_View.Count > 0 Then

            objSemItem_View.GUID = objDRs_View(0).Item("GUID_DBItem")
            objSemItem_View.Name = objDRs_View(0).Item("Name_DBItem")
            objSemItem_View.GUID_Parent = objLocalConfig.SemItem_Type_DB_Views.GUID
            objSemItem_View.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


            If Not IsDBNull(objDRs_View(0).Item("Name_Server")) And Not IsDBNull(objDRs_View(0).Item("Name_Database")) Then
                objConnection = New SqlClient.SqlConnection(objLocalConfig.Globals.get_DB_ConnectionString(objDRs_View(0).Item("Name_Server"), objDRs_View(0).Item("Name_Database")))

                dtblA_Columns.Connection = objConnection
                dtblA_Columns.Fill(dtblT_Columns, _
                                   objSemItem_View.Name)


                If dtblT_Columns.Rows.Count > 0 Then
                    get_Data_ReportFieldTypes()

                    procA_ReportFields.Fill(procT_ReportFields, _
                                            objLocalConfig.SemItem_Attribute_invisible.GUID, _
                                            objLocalConfig.SemItem_Type_Report_Field.GUID, _
                                            objLocalConfig.SemItem_Type_Reports.GUID, _
                                            objLocalConfig.SemItem_Type_DB_Columns.GUID, _
                                            objLocalConfig.SemItem_Type_Field_Type.GUID, _
                                            objLocalConfig.SemItem_Type_Field_Format.GUID, _
                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                            objLocalConfig.SemItem_RelationType_is.GUID, _
                                            objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                            objLocalConfig.SemItem_RelationType_leads.GUID, _
                                            objLocalConfig.SemItem_RelationType_Formatted_by.GUID, _
                                            objLocalConfig.SemItem_RelationType_Type_Field.GUID, _
                                            objSemItem_Report.GUID)

                    intToDo = dtblT_Columns.Rows.Count
                    intDone = 0
                    For Each objDR_Column In dtblT_Columns.Rows
                        objDRs_FieldType = procT_ReportFieldTypes.Select("Name_DataTypes__Ms_SQL_='" & objDR_Column.Item("name_type") & "'")
                        If objDRs_FieldType.Count > 0 Then
                            boolVisible = objDRs_FieldType(0).Item("Visible")
                            objSemItem_Type.GUID = objDRs_FieldType(0).Item("GUID_Field_Type")
                            objSemItem_Type.Name = objDRs_FieldType(0).Item("Name_Field_Type")
                            objSemItem_Type.GUID_Parent = objLocalConfig.SemItem_Type_Field_Type.GUID
                            objSemItem_Type.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        Else
                            boolVisible = True
                            objSemItem_Type = Nothing
                        End If



                        objDRs_Exists = procT_ReportFields.Select("Name_DBColumn='" & objDR_Column.Item("name") & "'")
                        If objDRs_Exists.Count = 0 Then
                            objDRC_Column = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Columns.GUID, _
                                                                                             objDR_Column.Item("Name")).Rows
                            If objDRC_Column.Count = 0 Then
                                objSemItem_DBColumn.GUID = Guid.NewGuid
                                objSemItem_DBColumn.Name = objDR_Column.Item("name")
                                objSemItem_DBColumn.GUID_Parent = objLocalConfig.SemItem_Type_DB_Columns.GUID
                                objSemItem_DBColumn.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objSemItem_Result = objTransaction_Reports.save_001_DBColumn(objSemItem_DBColumn)

                            Else
                                objSemItem_DBColumn.GUID = objDRC_Column(0).Item("GUID_Token")
                                objSemItem_DBColumn.Name = objDRC_Column(0).Item("Name_Token")
                                objSemItem_DBColumn.GUID_Parent = objLocalConfig.SemItem_Type_DB_Columns.GUID
                                objSemItem_DBColumn.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                            End If

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_Reports.save_002_DBColumn_To_View(objSemItem_View, _
                                                                                                     objSemItem_DBColumn)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                    objSemItem_ReportField.GUID = Guid.NewGuid
                                    objSemItem_ReportField.Name = objSemItem_DBColumn.Name
                                    objSemItem_ReportField.GUID_Parent = objLocalConfig.SemItem_Type_Report_Field.GUID
                                    objSemItem_ReportField.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    objSemItem_Result = objTransaction_Reports.save_003_ReportField(objSemItem_ReportField)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_Reports.save_004_ReportField_To_Report(objSemItem_Report, _
                                                                                                                  objSemItem_ReportField)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_Reports.save_005_ReportField_To_DBColumn(objSemItem_DBColumn, _
                                                                                                                        objSemItem_ReportField)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_Reports.save_008_ReportField__Visibility(boolVisible, objSemItem_ReportField)
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_Reports.save_009_ReportField_to_FieldType(objSemItem_Type, _
                                                                                                                                 objSemItem_ReportField)
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        intDone = intDone + 1
                                                    Else
                                                        objSemItem_Result = objTransaction_Reports.del_008_ReportField__Visibility
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_Reports.del_005_ReportField_To_Report
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_Reports.del_004_ReportField_To_Report
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objTransaction_Reports.del_003_ReportField()
                                                                End If
                                                            End If
                                                        End If
                                                        
                                                    End If


                                                Else
                                                    objSemItem_Result = objTransaction_Reports.del_005_ReportField_To_Report
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_Reports.del_004_ReportField_To_Report
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objTransaction_Reports.del_003_ReportField()
                                                        End If
                                                    End If

                                                End If

                                            Else
                                                objSemItem_Result = objTransaction_Reports.del_004_ReportField_To_Report
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objTransaction_Reports.del_003_ReportField()
                                                End If
                                            End If
                                        Else
                                            objTransaction_Reports.del_003_ReportField(objSemItem_ReportField)
                                        End If
                                    End If
                                Else
                                    objTransaction_Reports.del_001_DBColumn(objSemItem_DBColumn)

                                End If
                            End If
                        Else
                            intDone = intDone + 1
                        End If

                    Next

                    If intDone < intToDo Then
                        MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Report-Fields erzeugt werden!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Sub initailze_ReportTree()
        boolData_ReportTree = False
        objThread_Data_ReportTree = New Threading.Thread(AddressOf get_Data_ReportTree)
        objThread_Data_ReportTree.Start()
    End Sub

    Public Sub initialize_Reports()
        boolData_Reports = False
        objThread_Data_Reports = New Threading.Thread(AddressOf get_Data_Reports)
        objThread_Data_Reports.Start()
    End Sub

    Public Sub initialize_Report(ByVal SemItem_Report As clsSemItem)
        boolData_Report = False
        objSemItem_Report = SemItem_Report
        objThread_Data_Report = New Threading.Thread(AddressOf get_Data_Report)
        objThread_Data_Report.Start()
    End Sub

    Public Sub initiaize_ReportFields(ByVal SemItem_Report As clsSemItem)
        boolData_ReportFields = False
        objSemItem_Report = SemItem_Report
        objThread_Data_ReportFields = New Threading.Thread(AddressOf get_Data_ReportFields)
        objThread_Data_ReportFields.Start()
    End Sub

    Private Sub get_Data_ReportFieldTypes()
        procA_ReportFieldTypes.Fill(procT_ReportFieldTypes, _
                                    objLocalConfig.SemItem_Attribute_visible.GUID, _
                                    objLocalConfig.SemItem_Type_Field_Type.GUID, _
                                    objLocalConfig.SemItem_Type_DataTypes__Ms_SQL_.GUID, _
                                    objLocalConfig.SemItem_RelationType_is_of_Type.GUID)

    End Sub

    Private Sub get_Data_ReportFields()
        procA_ReportFields.Connection = New SqlClient.SqlConnection(strConnection_Module)
        procA_ReportFields.Fill(procT_ReportFields, _
                                objLocalConfig.SemItem_Attribute_invisible.GUID, _
                                objLocalConfig.SemItem_Type_Report_Field.GUID, _
                                objLocalConfig.SemItem_Type_Reports.GUID, _
                                objLocalConfig.SemItem_Type_DB_Columns.GUID, _
                                objLocalConfig.SemItem_Type_Field_Type.GUID, _
                                objLocalConfig.SemItem_Type_Field_Format.GUID, _
                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                objLocalConfig.SemItem_RelationType_is.GUID, _
                                objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                objLocalConfig.SemItem_RelationType_leads.GUID, _
                                objLocalConfig.SemItem_RelationType_Formatted_by.GUID, _
                                objLocalConfig.SemItem_RelationType_Type_Field.GUID, _
                                objSemItem_Report.GUID)


        boolData_ReportFields = True
    End Sub
    Private Sub get_Data_Report(Optional ByVal SemItem_Report As clsSemItem = Nothing)
        If Not SemItem_Report Is Nothing Then
            objSemItem_Report = SemItem_Report
        End If
        procA_Report.Connection = New SqlClient.SqlConnection(strConnection_Module)
        procA_Report.Fill(procT_Report, _
                          objLocalConfig.SemItem_Type_Reports.GUID, _
                          objLocalConfig.SemItem_Type_Report_Type.GUID, _
                          objLocalConfig.SemItem_Type_Database_on_Server.GUID, _
                          objLocalConfig.SemItem_Type_DB_Views.GUID, _
                          objLocalConfig.SemItem_Type_Database.GUID, _
                          objLocalConfig.SemItem_Type_Server.GUID, _
                          objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                          objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                          objLocalConfig.SemItem_RelationType_is.GUID, _
                          objLocalConfig.SemItem_RelationType_contains.GUID, _
                          objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                          objSemItem_Report.GUID, _
                          objLocalConfig.SemItem_Token_Report_Type_View.GUID, _
                          objLocalConfig.SemItem_Token_Report_Type_Token_Report.GUID)

        boolData_Report = True
    End Sub

    Private Sub get_Data_ReportTree()
        procA_ReportTree.Connection = New SqlClient.SqlConnection(strConnection_Module)
        procA_ReportTree.Fill(procT_ReportTree, _
                              objLocalConfig.SemItem_Type_Reports.GUID, _
                              objLocalConfig.SemItem_Type_Report_Type.GUID, _
                              objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                              objLocalConfig.SemItem_RelationType_contains.GUID)


        boolData_ReportTree = True
    End Sub

    Private Sub get_Data_Reports()

        boolData_Reports = True
    End Sub

    Private Sub set_DBConnection()
        strConnection_DB = objLocalConfig.Connection_DB.ConnectionString
        strConnection_Module = objLocalConfig.Connection_Plugin.ConnectionString
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        objTransaction_Reports = New clsTransaction_Reports(objLocalConfig)
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        procA_XMLConfig.Connection = objLocalConfig.Connection_Plugin
        procA_XML_Variable.Connection = objLocalConfig.Connection_Plugin
        procA_ReportFields.Connection = objLocalConfig.Connection_Plugin
        procA_ReportFieldTypes.Connection = objLocalConfig.Connection_Plugin

    End Sub
End Class
