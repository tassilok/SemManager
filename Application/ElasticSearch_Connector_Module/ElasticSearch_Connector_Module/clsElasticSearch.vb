Imports Sem_Manager
Imports RestSharp
<<<<<<< HEAD
Imports ElasticSearch
Public Class clsElasticSearch
    Dim objLocalConfig As clsLocalConfig

    Private procA_XMLNodes_ColConfig As New DataSet_ElasticSearchConnectorTableAdapters.proc_XMLNodes_ColConfigTableAdapter
    Private procT_XMLNodes_ColConfig As New DataSet_ElasticSearchConnector.proc_XMLNodes_ColConfigDataTable

=======
Imports PlainElastic

Public Class clsElasticSearch
    Dim objLocalConfig As clsLocalConfig

    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
>>>>>>> Some Changes
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcT_Indexes As New ds_Token.func_TokenTokenDataTable

    Private procA_XMLImport As New DataSet_ElasticSearchConnectorTableAdapters.proc_XMLImportTableAdapter
    Private procT_XMLImport As New DataSet_ElasticSearchConnector.proc_XMLImportDataTable

    Private objJson As clsJson

    Private objRestClient As RestClient
    Private objRestRequest As RestRequest
    Private objRestResponse As RestResponse
    Private objFileWebRequest As System.Net.FileWebRequest
    Private objElConn As PlainElastic.Net.ElasticConnection
    Private objBulkBuilder As PlainElastic.Net.BulkBuilder

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
<<<<<<< HEAD
        procA_XMLNodes_ColConfig.Connection = objLocalConfig.Connection_Plugin
=======
        semtblA_Type.Connection = objLocalConfig.Connection_DB
>>>>>>> Some Changes
        objJson = New clsJson(objLocalConfig)
    End Sub

    Private Function initialize_ElConn() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Try
            objElConn = New PlainElastic.Net.ElasticConnection(objSemItem_Server.Name, objSemItem_Port.Name)
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        Return objSemItem_Result
    End Function

    Private Function finalize_ElConn() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Try
            objElConn = Nothing
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        Return objSemItem_Result
    End Function

    Public Sub get_Data_XMLImport()
        Dim objDRC_XMLImport As DataRowCollection
        objDRC_XMLImport = procA_XMLImport.GetData(objLocalConfig.SemItem_User.GUID, _
                             objLocalConfig.SemItem_Type_XML_Import.GUID, _
                             objLocalConfig.SemItem_Type_Url.GUID, _
                             objLocalConfig.SemItem_Type_Types__Elastic_Search_.GUID, _
                             objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                             objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                             objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows

        objSemItem_XMLImport = Nothing
        If objDRC_XMLImport.Count > 0 Then
            objSemItem_XMLImport = New clsSemItem
            objSemItem_XMLImport.GUID = objDRC_XMLImport(0).Item("GUID_XMLImport")
            objSemItem_XMLImport.Name = objDRC_XMLImport(0).Item("Name_XMLImport")
            objSemItem_XMLImport.GUID_Parent = objLocalConfig.SemItem_Type_XML_Import.GUID
            objSemItem_XMLImport.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_TypeElasticSearch = New clsSemItem
            objSemItem_TypeElasticSearch.GUID = objDRC_XMLImport(0).Item("GUID_TypeElasticSearch")
            objSemItem_TypeElasticSearch.Name = objDRC_XMLImport(0).Item("Name_TypeElasticSearch")
            objSemItem_TypeElasticSearch.GUID_Parent = objLocalConfig.SemItem_Type_Types__Elastic_Search_.GUID
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
        'objRestClient = New RestClient("http://" & objSemItem_Server.Name & ":" & objSemItem_Port.Name)
        objRestClient = New RestClient("http://localhost:" & objSemItem_Port.Name)
    End Sub

    Private Sub get_Data_Indexes()
        funcA_TokenToken.Fill_TokenToken_RightLeft(funcT_Indexes, _
                                                   objSemItem_ServerPort.GUID, _
                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                   objLocalConfig.SemItem_Type_Indexes__Elastic_Search_.GUID)

    End Sub

    Public Function export_Types() As clsSemItem
        Dim objDRC_Types As DataRowCollection
        Dim i As Integer
        Dim objSemItem_Result As clsSemItem
        Dim strBulkCommand As String
        Dim objSemItems_Type() As clsSemItem
        Dim strJson As String = ""
        Dim strJsonTmp As String
        Dim lngPack As Long
        Dim objTextWriter As IO.TextWriter


        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If

        lngPack = 0
        objDRC_Types = semtblA_Type.GetData().Rows
        For i = 0 To objDRC_Types.Count - 1
            strJsonTmp = objJson.Json_Document
            strJsonTmp = strJsonTmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_INDEX.Name & "@", objSemItem_Index.Name)
            strJsonTmp = strJsonTmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_TYPE.Name & "@", objLocalConfig.SemItem_Token_Types__Elastic_Search__ontologydb.Name)
            strJsonTmp = strJsonTmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID.Name & "@", objDRC_Types(i).Item("GUID_Type").ToString)
            strJson = strJson & strJsonTmp & vbCrLf

            strJsonTmp = objJson.Json_Attribute
            strJsonTmp = strJsonTmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_FIELD.Name & "@", "Name")
            strJsonTmp = strJsonTmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_VALUE.Name & "@", """" & Web.HttpUtility.HtmlEncode(objDRC_Types(i).Item("Name_Type").ToString) & """")
            strJson = strJson & strJsonTmp & vbCrLf
            strJsonTmp = objJson.Json_Attribute
            strJsonTmp = strJsonTmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_FIELD.Name & "@", "ÍD_Type_Parent")
            strJsonTmp = strJsonTmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_VALUE.Name & "@", """" & objDRC_Types(i).Item("GUID_Type_Parent").ToString & """")
            strJson = strJson & strJsonTmp & vbCrLf

            If lngPack = 10000 Then
                initialize_RestClient()
                objTextWriter = New IO.StreamWriter("C:\Temp\json.txt", False)
                objTextWriter.Write(strJson)
                objTextWriter.Close()
                objRestRequest = New RestRequest("_bulk", Method.POST)
                objRestRequest.AddFile("request", "C:\Temp\json.txt")
                objRestResponse = objRestClient.Execute(objRestRequest)

                strJson = ""
                lngPack = 0
            End If

            lngPack = lngPack + 1
        Next

        If strJson <> "" Then
            initialize_RestClient()
            objTextWriter = New IO.StreamWriter("C:\Temp\json.txt", False)
            objTextWriter.Write(strJson)
            objTextWriter.Close()
            objRestRequest = New RestRequest("_bulk", Method.POST)
            objRestRequest.AddFile("request", "C:\Temp\json.txt")
            objRestResponse = objRestClient.Execute(objRestRequest)
        End If

        Return objSemItem_Result
    End Function

    Private Sub get_Data_ServerPort()
        Dim objDRC_ServerPort As DataRowCollection
        Dim objDRC_Index As DataRowCollection

        objDRC_ServerPort = funcA_TokenToken.GetData_LeftRight_Ordered_By_GUIDs(objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                          objLocalConfig.SemItem_Type_Server_Port.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging_Resources.GUID, True).Rows

        If objDRC_ServerPort.Count > 0 Then
            objSemItem_ServerPort = New clsSemItem
            objSemItem_ServerPort.GUID = objDRC_ServerPort(0).Item("GUID_Token_Right")
            objSemItem_ServerPort.Name = objDRC_ServerPort(0).Item("Name_Token_Right")
            objSemItem_ServerPort.GUID_Parent = objLocalConfig.SemItem_Type_Server_Port.GUID
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
                                                                                       objLocalConfig.SemItem_Type_Indexes__Elastic_Search_.GUID, _
                                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID, True).Rows
                    If objDRC_Index.Count > 0 Then
                        objSemItem_Index = New clsSemItem
                        objSemItem_Index.GUID = objDRC_Index(0).Item("GUID_Token_Left")
                        objSemItem_Index.Name = objDRC_Index(0).Item("Name_Token_Left")
                        objSemItem_Index.GUID_Parent = objLocalConfig.SemItem_Type_Indexes__Elastic_Search_.GUID
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

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
