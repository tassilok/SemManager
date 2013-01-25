Imports Sem_Manager
Imports RestSharp
Imports ElasticSearch
Public Class clsElasticSearch
    Dim objLocalConfig As clsLocalConfig

    Private procA_XMLNodes_ColConfig As New DataSet_ElasticSearchConnectorTableAdapters.proc_XMLNodes_ColConfigTableAdapter
    Private procT_XMLNodes_ColConfig As New DataSet_ElasticSearchConnector.proc_XMLNodes_ColConfigDataTable

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

    Private objBulkObjects() As ElasticSearch.Client.Domain.BulkObject

    Private lngRowID As Long

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_XMLImport.Connection = objLocalConfig.Connection_Plugin
        procA_XMLNodes_ColConfig.Connection = objLocalConfig.Connection_Plugin
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
        Dim objWebRequest As Net.HttpWebRequest
        Dim objStream As IO.Stream
        Dim objWebResponse As Net.WebResponse
        Dim objStreamReader As IO.StreamReader
        Dim objElasticSearch As ElasticSearch.Client.ElasticSearchClient
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult
        Dim objBulkObject As ElasticSearch.Client.Domain.BulkObject
        Dim strResponse As String
        Dim objDRC_XMLNode_Row As DataRowCollection
        Dim objXMLNodeList As Xml.XmlNodeList
        Dim objXMLNode As Xml.XmlElement
        Dim objDRC_XMLNodes_Col As DataRowCollection
        Dim objDR_XMLNodes_Col As DataRow
        Dim objXMLNodeLis_col As Xml.XmlNodeList
        Dim objXMLNode_col As Xml.XmlElement
        Dim objDict As Dictionary(Of String, Object)
        Dim bytes() As Byte
        Dim intCount As Integer
        Dim intItem As Integer
        Dim strFields As String

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If

        If Not objSemItem_XMLImport Is Nothing Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success

            'strJson = objJson.convert_XML_To_Json_ForElasticSearch(objXMLImport, objSemItem_Index, objSemItem_TypeElasticSearch, objXML)
            objDRC_XMLNode_Row = funcA_TokenToken.GetData_TokenToken_LeftRight(objXMLImport.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_RowConfig.GUID, _
                                                                           objLocalConfig.SemItem_Type_XMLNode.GUID).Rows

            If objDRC_XMLNode_Row.Count > 0 Then
                objXMLNodeList = objXML.GetElementsByTagName(objDRC_XMLNode_Row(0).Item("Name_Token_Right"))
                objDRC_XMLNodes_Col = procA_XMLNodes_ColConfig.GetData(objLocalConfig.SemItem_Type_XMLNode.GUID, _
                                                               objLocalConfig.SemItem_Type_FieldType.GUID, _
                                                               objLocalConfig.SemItem_RelationType_ColConfig.GUID, _
                                                               objLocalConfig.SemItem_RelationType_isOfType.GUID, _
                                                               objXMLImport.GUID).Rows
                lngRowID = 0
                'objElasticSearch = New ElasticSearch.Client.ElasticSearchClient(objSemItem_Server.Name, Integer.Parse(objSemItem_Port.Name), Client.Config.TransportType.Http, False)
                Try

                    objElasticSearch = New ElasticSearch.Client.ElasticSearchClient("Explido")

                    Try
                        objElasticSearch.DeleteIndex(objSemItem_Index.Name)

                    Catch ex As Exception
                        MsgBox(objSemItem_Index.Name)
                    End Try
                    Try
                        objElasticSearch.CreateIndex(objSemItem_Index.Name)
                    Catch ex As Exception
                        MsgBox(objSemItem_Index.Name)
                    End Try
                    While lngRowID < objXMLNodeList.Count
                        If lngRowID + 500 < objXMLNodeList.Count Then
                            intCount = 500
                        Else
                            intCount = objXMLNodeList.Count - lngRowID
                        End If
                        intItem = 0
                        While intCount >= 0
                            objXMLNode = objXMLNodeList(lngRowID)
                            objDict = New Dictionary(Of String, Object)
                            For Each objDR_XMLNode_Col In objDRC_XMLNodes_Col
                                objXMLNodeLis_col = objXMLNode.GetElementsByTagName(objDR_XMLNode_Col.Item("Name_XMLNode"))
                                If objXMLNodeLis_col.Count > 0 Then
                                    objXMLNode_col = objXMLNodeLis_col(0)


                                    objDict.Add(objDR_XMLNode_Col.Item("Name_XMLNode"), objXMLNode_col.InnerText)
                                    'strFields = strFields & "" & objDR_XMLNode_Col.Item("Name_XMLNode") & """ : """ & objXMLNode_col.InnerText & """"
                                End If

                            Next

                            If objDict.Count > 0 Then
                                ReDim Preserve objBulkObjects(intItem)
                                objBulkObjects(intItem) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, objSemItem_TypeElasticSearch.Name, lngRowID, objDict)
                            End If
                            lngRowID = lngRowID + 1
                            intCount = intCount - 1
                            intItem = intItem + 1
                        End While
                        Try
                            objOPResult = objElasticSearch.Bulk(objBulkObjects)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                        'MsgBox(objOPResult.JsonString)

                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                
            End If
            'objElasticSearch = New ElasticSearch.Client.ElasticSearchClient(objSemItem_Server.Name, objSemItem_Port.Name, Client.Config.TransportType.Http, False)


            'get_BulkObjects(objXMLImport, objSemItem_Index, objSemItem_TypeElasticSearch, objXML)
            

            'objTextWriter = New IO.StreamWriter("C:\Temp\json.txt")
            'objTextWriter.Write(strJson)
            'objTextWriter.Close()

            'objRestRequest = New RestRequest("_bulk", Method.POST)
            'objRestRequest.AddFile("request", "C:\Temp\json.txt")
            'initialize_RestClient()
            'objWebRequest = Net.HttpWebRequest.Create("http://" & objSemItem_Server.Name & ":" & objSemItem_Port.Name)
            'objWebRequest.Method = "POST"
            'objStream = objWebRequest.GetRequestStream()

            'bytes = System.Text.Encoding.UTF8.GetBytes(strJson)
            'objStream.Write(bytes, 0, bytes.Count - 1)
            'objStream.Close()
            'objWebResponse = objWebRequest.GetResponse
            'objStreamReader = New IO.StreamReader(objWebResponse.GetResponseStream(), True)
            'strResponse = objStreamReader.ReadToEnd()

            'objWebclient.UploadFile("http://" & objSemItem_Server.Name & ":" & objSemItem_Port.Name, "C:\Temp\json.txt")
            'objRestResponse = objRestClient.Execute(objRestRequest)

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        

        Return objSemItem_Result
    End Function

    Public Sub get_BulkObjects(ByVal objXMLImport As clsSemItem, ByVal objSemItem_Index As clsSemItem, ByVal objSemItem_TypeElasticSearch As clsSemItem, ByVal objXML As Xml.XmlDocument)
        Dim strJson As String = ""
        Dim strFields As String = ""
        Dim objDRC_XMLNodes_Col As DataRowCollection
        Dim objDR_XMLNode_Col As DataRow
        Dim objXMLNodeList As Xml.XmlNodeList
        Dim objXMLNode As Xml.XmlElement
        Dim objXMLNodeLis_col As Xml.XmlNodeList
        Dim objXMLNode_col As Xml.XmlElement

        Dim lngID As Long = 1

        


        
        If objDRC_XMLNodes_Col.Count > 0 Then

            For Each objXMLNode In objXMLNodeList
                strFields = ""
                For Each objDR_XMLNode_Col In objDRC_XMLNodes_Col
                    objXMLNodeLis_col = objXMLNode.GetElementsByTagName(objDR_XMLNode_Col.Item("Name_XMLNode"))
                    If objXMLNodeLis_col.Count > 0 Then
                        objXMLNode_col = objXMLNodeLis_col(0)

                        If strFields <> "" Then
                            strFields = strFields & " , "
                        End If
                        strFields = strFields & objDR_XMLNode_Col.Item("Name_XMLNode") & """ : """ & objXMLNode_col.InnerText & """"
                    End If

                Next

                If strFields <> "" Then
                    ReDim Preserve objBulkObjects(lngID - 1)
                    objBulkObjects(lngID - 1) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, objSemItem_TypeElasticSearch.Name, lngID, strFields)
                End If

                'strJson = strJson & strFields
                'strJson = strJson & " } "
                lngID = lngID + 1

            Next
        Else
            strJson = ""
        End If


    End Sub

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
