Imports Sem_Manager
Imports RestSharp

Public Class clsElasticSearch
    Dim objLocalConfig As clsLocalConfig

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcT_Indexes As New ds_Token.func_TokenTokenDataTable

    Private procA_XMLImport As New DataSet_ElasticSearchConnectorTableAdapters.proc_XMLImportTableAdapter
    Private procT_XMLImport As New DataSet_ElasticSearchConnector.proc_XMLImportDataTable

    Private objJson As clsJson

    Private objRestClient As RestClient
    Private objRestRequest As RestRequest
    Private objRestResponse As RestResponse
    Private objFileWebRequest As Net.FileWebRequest

    Private objSemItem_ServerPort As clsSemItem
    Private objSemItem_Port As clsSemItem
    Private objSemItem_Server As clsSemItem
    Private objSemItem_Index As clsSemItem
    Private objSemItem_XMLImport As clsSemItem
    Private objSemItem_TypeElasticSearch As clsSemItem

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_XMLImport.Connection = objLocalConfig.Connection_Plugin
        objJson = New clsJson(objLocalConfig)
    End Sub

    Public Sub get_Data_XMLImport()
        Dim objDRC_XMLImport As DataRowCollection
        objDRC_XMLImport = procA_XMLImport.GetData(objLocalConfig.SemItem_User.GUID, _
                             objLocalConfig.SemItem_Type_XMLImport.GUID, _
                             objLocalConfig.SemItem_Type_Url.GUID, _
                             objLocalConfig.SemItem_Type_Types_Elastic_Search.GUID, _
                             objLocalConfig.SemItem_RelationType_belongs_to.GUID, _
                             objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                             objLocalConfig.SemItem_RelationType_isOfType.GUID).Rows

        objSemItem_XMLImport = Nothing
        If objDRC_XMLImport.Count > 0 Then
            objSemItem_XMLImport = New clsSemItem
            objSemItem_XMLImport.GUID = objDRC_XMLImport(0).Item("GUID_XMLImport")
            objSemItem_XMLImport.Name = objDRC_XMLImport(0).Item("Name_XMLImport")
            objSemItem_XMLImport.GUID_Parent = objLocalConfig.SemItem_Type_XMLImport.GUID
            objSemItem_XMLImport.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_TypeElasticSearch = New clsSemItem
            objSemItem_TypeElasticSearch.GUID = objDRC_XMLImport(0).Item("GUID_TypeElasticSearch")
            objSemItem_TypeElasticSearch.Name = objDRC_XMLImport(0).Item("Name_TypeElasticSearch")
            objSemItem_TypeElasticSearch.GUID_Parent = objLocalConfig.SemItem_Type_Types_Elastic_Search.GUID
            objSemItem_TypeElasticSearch.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        End If

    End Sub

    Public Function insert_XML(ByVal objXML As Xml.XmlDocument, ByVal objXMLImport As clsSemItem) As clsSemItem
        Dim strJson As String
        Dim objSemItem_Result As clsSemItem
        Dim objTextWriter As IO.TextWriter

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If

        If Not objSemItem_XMLImport Is Nothing Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success

            strJson = objJson.convert_XML_To_Json_ForElasticSearch(objXMLImport, objSemItem_Index, objSemItem_TypeElasticSearch, objXML)

            objTextWriter = New IO.StreamWriter("C:\Temp\json.txt")
            objTextWriter.Write(strJson)
            objTextWriter.Close()

            objRestRequest = New RestRequest("_bulk", Method.POST)
            objRestRequest.AddFile("request", "C:\Temp\json.txt")
            initialize_RestClient()
            objRestResponse = objRestClient.Execute(objRestRequest)

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        

        Return objSemItem_Result
    End Function

    Private Sub initialize_RestClient()
        objRestClient = New RestClient("http://" & objSemItem_Server.Name & ":" & objSemItem_Port.Name)
    End Sub

    Private Sub get_Data_Indexes()
        funcA_TokenToken.Fill_TokenToken_RightLeft(funcT_Indexes, _
                                                   objSemItem_ServerPort.GUID, _
                                                   objLocalConfig.SemItem_RelationType_belongs_to.GUID, _
                                                   objLocalConfig.SemItem_Type_IndexesElasticSearch.GUID)

    End Sub

    Private Sub get_Data_ServerPort()
        Dim objDRC_ServerPort As DataRowCollection
        Dim objDRC_Index As DataRowCollection

        objDRC_ServerPort = funcA_TokenToken.GetData_LeftRight_Ordered_By_GUIDs(objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                          objLocalConfig.SemItem_Type_ServerPort.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging_resource.GUID, True).Rows

        If objDRC_ServerPort.Count > 0 Then
            objSemItem_ServerPort = New clsSemItem
            objSemItem_ServerPort.GUID = objDRC_ServerPort(0).Item("GUID_Token_Right")
            objSemItem_ServerPort.Name = objDRC_ServerPort(0).Item("Name_Token_Right")
            objSemItem_ServerPort.GUID_Parent = objLocalConfig.SemItem_Type_ServerPort.GUID
            objSemItem_ServerPort.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_ServerPort = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ServerPort.GUID, _
                                                                              objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                              objLocalConfig.SemItem_Type_Port.GUID).Rows
            If objDRC_ServerPort.Count > 0 Then
                objSemItem_Port = New clsSemItem
                objSemItem_Port.GUID = objDRC_ServerPort(0).Item("GUID_Token_Right")
                objSemItem_Port.Name = objDRC_ServerPort(0).Item("Name_Token_Right")
                objSemItem_Port.GUID_Parent = objLocalConfig.SemItem_Type_Port.GUID
                objSemItem_Port.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objDRC_ServerPort = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ServerPort.GUID, _
                                                                              objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                              objLocalConfig.SemItem_Type_Server.GUID).Rows
                If objDRC_ServerPort.Count > 0 Then
                    objSemItem_Server = New clsSemItem
                    objSemItem_Server.GUID = objDRC_ServerPort(0).Item("GUID_Token_Right")
                    objSemItem_Server.Name = objDRC_ServerPort(0).Item("Name_Token_Right")
                    objSemItem_Server.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                    objSemItem_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objDRC_Index = funcA_TokenToken.GetData_RightLeft_Ordered_By_GUIDs(objSemItem_ServerPort.GUID, _
                                                                                       objLocalConfig.SemItem_Type_IndexesElasticSearch.GUID, _
                                                                                       objLocalConfig.SemItem_RelationType_belongs_to.GUID, True).Rows
                    If objDRC_Index.Count > 0 Then
                        objSemItem_Index = New clsSemItem
                        objSemItem_Index.GUID = objDRC_Index(0).Item("GUID_Token_Left")
                        objSemItem_Index.Name = objDRC_Index(0).Item("Name_Token_Left")
                        objSemItem_Index.GUID_Parent = objLocalConfig.SemItem_Type_IndexesElasticSearch.GUID
                        objSemItem_Index.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    Else

                        Err.Raise(1, Nothing, "Config not set")
                    End If
                Else
                    Err.Raise(1, Nothing, "Config not set")
                End If

            Else
                Err.Raise(1, Nothing, "Config not set")
            End If

        Else
            Err.Raise(1, Nothing, "Config not set")
        End If
    End Sub

    Public Sub New()
        objLocalConfig = New clsLocalConfig(New clsGlobals)

        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        get_Data_ServerPort()
        get_Data_Indexes()
    End Sub
End Class
