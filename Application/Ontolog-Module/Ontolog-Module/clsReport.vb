Public Class clsReport

    Private objLocalConfig As clsLocalConfig
    Private objConnection As SqlClient.SqlConnection

    Private initializeA_Tables As New DataSet_ReportTableAdapters.initialize_TablesTableAdapter
    Private finalizeA_Tables As New DataSet_ReportTableAdapters.finalize_TablesTableAdapter

    Private createA_Table_orgT As New DataSet_ReportTableAdapters.create_Table_orgTTableAdapter
    Private createA_Table_attT As New DataSet_ReportTableAdapters.create_Table_attTTableAdapter
    Private createA_Table_relT As New DataSet_ReportTableAdapters.create_Table_relTTableAdapter

    Private objDBLevel_Classes As clsDBLevel
    Private objDBLevel_Objects As clsDBLevel

    Private objDBLevel_OntologyRules As clsDBLevel
    Private objDBLevel_Ontology As clsDBLevel

    Public Sub sync_SQLDB()
        Dim objOItem_Class As clsOntologyItem
        Dim objOItem_Object As clsOntologyItem
        Dim oList_Objects As New List(Of clsOntologyItem)
        Dim objTextWriter As IO.TextWriter
        Dim strPath As String
        Dim strLine As String
        


        objDBLevel_Classes.get_Data_Classes(Nothing, False, False)
        For Each objOItem_Class In objDBLevel_Classes.OList_Classes

            oList_Objects.Clear()
            oList_Objects.Add(New clsOntologyItem(Nothing, Nothing, objOItem_Class.GUID, objLocalConfig.Globals.Type_Object))
            objDBLevel_Objects.get_Data_Objects(oList_Objects, False)
            strPath = "%Temp%\" & Guid.NewGuid().ToString & ".txt"
            strPath = Environment.ExpandEnvironmentVariables(strPath)
            objTextWriter = New IO.StreamWriter(strPath, False)
            strLine = ""
            For Each objOItem_Object In objDBLevel_Objects.OList_Objects
                strLine = strLine & objOItem_Object.GUID & "@@" & objOItem_Object.Name & "@@" & objOItem_Object.GUID_Parent & "@@1"
                objTextWriter.WriteLine(strLine)
            Next
            objTextWriter.Close()
            If objDBLevel_Objects.OList_Objects.Count > 0 Then
                createA_Table_orgT.GetData(objLocalConfig.Globals.Type_Class, objOItem_Class.Name, strPath, True)
            Else
                createA_Table_orgT.GetData(objLocalConfig.Globals.Type_Class, objOItem_Class.Name, strPath, False)
            End If

        Next
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)

        set_DBConnection()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        Dim strConnection As String

        strConnection = objLocalConfig.Globals.get_ConnectionStr(objLocalConfig.Globals.Rep_Server, _
                                                                 objLocalConfig.Globals.Rep_Instance, _
                                                                 objLocalConfig.Globals.Rep_Database)

        createA_Table_attT.Connection = New SqlClient.SqlConnection(strConnection)
        createA_Table_orgT.Connection = New SqlClient.SqlConnection(strConnection)
        createA_Table_relT.Connection = New SqlClient.SqlConnection(strConnection)

        initializeA_Tables.Connection = New SqlClient.SqlConnection(strConnection)
        finalizeA_Tables.Connection = New SqlClient.SqlConnection(strConnection)

        objDBLevel_Objects = New clsDBLevel(objLocalConfig)
        objDBLevel_Classes = New clsDBLevel(objLocalConfig)
        objDBLevel_Ontology = New clsDBLevel(objLocalConfig)
        objDBLevel_OntologyRules = New clsDBLevel(objLocalConfig)
    End Sub
End Class
