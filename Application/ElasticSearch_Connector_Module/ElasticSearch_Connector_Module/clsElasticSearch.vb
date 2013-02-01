Imports Sem_Manager
Imports ElasticSearch
Public Class clsElasticSearch
    Dim objLocalConfig As clsLocalConfig

    Private semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter
    Private semtblA_Token_OR As New ds_SemDBTableAdapters.semtbl_Token_ORTableAdapter
    Private typefuncA_Types_Rel As New ds_TypeTableAdapters.typefunc_Types_RelTableAdapter
    Private typefuncA_Types_With_Attributes_And_Types As New ds_TypeTableAdapters.typefunc_Types_With_Attributes_And_TypesTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter

    Private TokenAAttribute_Bit As New ds_TokenAttributeTableAdapters.TokenAttribute_BitTableAdapter
    Private TokenAAttribute_Date As New ds_TokenAttributeTableAdapters.TokenAttribute_DateTableAdapter
    Private TokenAAttribute_Datetime As New ds_TokenAttributeTableAdapters.TokenAttribute_DatetimeTableAdapter
    Private TokenAAttribute_Int As New ds_TokenAttributeTableAdapters.TokenAttribute_IntTableAdapter
    Private TokenAAttribute_Real As New ds_TokenAttributeTableAdapters.TokenAttribute_RealTableAdapter
    Private TokenAAttribute_Time As New ds_TokenAttributeTableAdapters.TokenAttribute_TimeTableAdapter
    Private TokenAAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter
    Private TokenAAttribute_VarcharMax As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter

    Private procA_XMLNodes_ColConfig As New DataSet_ElasticSearchConnectorTableAdapters.proc_XMLNodes_ColConfigTableAdapter
    Private procT_XMLNodes_ColConfig As New DataSet_ElasticSearchConnector.proc_XMLNodes_ColConfigDataTable

    Private funcT_Indexes As New ds_Token.func_TokenTokenDataTable

    Private procA_XMLImport As New DataSet_ElasticSearchConnectorTableAdapters.proc_XMLImportTableAdapter
    Private procT_XMLImport As New DataSet_ElasticSearchConnector.proc_XMLImportDataTable

    Private objJson As clsJson

    'Private objFileWebRequest As System.Net.FileWebRequest

    Private objElConn As ElasticSearch.Client.ElasticSearchClient

    Private objSemItem_ServerPort As clsSemItem
    Private objSemItem_Port As clsSemItem
    Private objSemItem_Server As clsSemItem
    Private objSemItem_Index As clsSemItem
    Private objSemItem_XMLImport As clsSemItem
    Private objSemItem_TypeElasticSearch As clsSemItem


    Private lngRowID As Long

    Private Sub set_DBConnection()
        typefuncA_Types_Rel.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_XMLImport.Connection = objLocalConfig.Connection_Plugin
        procA_XMLNodes_ColConfig.Connection = objLocalConfig.Connection_Plugin
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB
        semtblA_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_RelationType.Connection = objLocalConfig.Connection_DB
        typefuncA_Types_With_Attributes_And_Types.Connection = objLocalConfig.Connection_DB

        TokenAAttribute_Bit.Connection = objLocalConfig.Connection_DB
        TokenAAttribute_Date.Connection = objLocalConfig.Connection_DB
        TokenAAttribute_Datetime.Connection = objLocalConfig.Connection_DB
        TokenAAttribute_Int.Connection = objLocalConfig.Connection_DB
        TokenAAttribute_Real.Connection = objLocalConfig.Connection_DB
        TokenAAttribute_Time.Connection = objLocalConfig.Connection_DB
        TokenAAttribute_Varchar255.Connection = objLocalConfig.Connection_DB
        TokenAAttribute_VarcharMax.Connection = objLocalConfig.Connection_DB

        semtblA_Token_OR.Connection = objLocalConfig.Connection_DB

        semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB

        objJson = New clsJson(objLocalConfig)
    End Sub

    Private Function initialize_ElConn() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Try
            objElConn = New ElasticSearch.Client.ElasticSearchClient("localhost")

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

    'Public Function insert_XML(ByVal objXML As Xml.XmlDocument, ByVal objXMLImport As clsSemItem) As clsSemItem
    '    Dim strJson As String
    '    Dim objSemItem_Result As clsSemItem
    '    Dim objWebRequest As Net.HttpWebRequest
    '    Dim objStream As IO.Stream
    '    Dim objWebResponse As Net.webresponse
    '    Dim objStreamReader As IO.StreamReader
    '    Dim objElasticSearch As ElasticSearch.Client.ElasticSearchClient
    '    Dim objOPResult As ElasticSearch.Client.Domain.OperateResult
    '    Dim objBulkObject As ElasticSearch.Client.Domain.BulkObject
    '    Dim strResponse As String
    '    Dim objDRC_XMLNode_Row As DataRowCollection
    '    Dim objXMLNodeList As Xml.XmlNodeList
    '    Dim objXMLNode As Xml.XmlElement
    '    Dim objDRC_XMLNodes_Col As DataRowCollection
    '    Dim objDR_XMLNodes_Col As DataRow
    '    Dim objXMLNodeLis_col As Xml.XmlNodeList
    '    Dim objXMLNode_col As Xml.XmlElement
    '    Dim objDict As Dictionary(Of String, Object)
    '    Dim bytes() As Byte
    '    Dim intCount As Integer
    '    Dim intItem As Integer
    '    Dim strFields As String

    '    If objSemItem_XMLImport Is Nothing Then
    '        get_Data_XMLImport()
    '    End If

    '    If Not objSemItem_XMLImport Is Nothing Then
    '        objSemItem_Result = objLocalConfig.Globals.LogState_Success

    '        'strJson = objJson.convert_XML_To_Json_ForElasticSearch(objXMLImport, objSemItem_Index, objSemItem_TypeElasticSearch, objXML)
    '        objDRC_XMLNode_Row = funcA_TokenToken.GetData_TokenToken_LeftRight(objXMLImport.GUID, _
    '                                                                       objLocalConfig.SemItem_RelationType_Row_Config.GUID, _
    '                                                                       objLocalConfig.SemItem_Type_XML_Nodes.GUID).Rows

    '        If objDRC_XMLNode_Row.Count > 0 Then
    '            objXMLNodeList = objXML.GetElementsByTagName(objDRC_XMLNode_Row(0).Item("Name_Token_Right"))
    '            objDRC_XMLNodes_Col = procA_XMLNodes_ColConfig.GetData(objLocalConfig.SemItem_Type_XML_Nodes.GUID, _
    '                                                           objLocalConfig.SemItem_Type_Field_Type.GUID, _
    '                                                           objLocalConfig.SemItem_RelationType_Col_Config.GUID, _
    '                                                           objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
    '                                                           objXMLImport.GUID).Rows
    '            lngRowID = 0
    '            'objElasticSearch = New ElasticSearch.Client.ElasticSearchClient(objSemItem_Server.Name, Integer.Parse(objSemItem_Port.Name), Client.Config.TransportType.Http, False)
    '            Try

    '                objElasticSearch = New ElasticSearch.Client.ElasticSearchClient("Explido")

    '                Try
    '                    objElasticSearch.DeleteIndex(objSemItem_Index.Name)

    '                Catch ex As Exception
    '                    MsgBox(objSemItem_Index.Name)
    '                End Try
    '                Try
    '                    objElasticSearch.CreateIndex(objSemItem_Index.Name)
    '                Catch ex As Exception
    '                    MsgBox(objSemItem_Index.Name)
    '                End Try
    '                While lngRowID < objXMLNodeList.Count
    '                    If lngRowID + 500 < objXMLNodeList.Count Then
    '                        intCount = 500
    '                    Else
    '                        intCount = objXMLNodeList.Count - lngRowID
    '                    End If
    '                    intItem = 0
    '                    While intCount >= 0
    '                        objXMLNode = objXMLNodeList(lngRowID)
    '                        objDict = New Dictionary(Of String, Object)
    '                        For Each objDR_XMLNode_Col In objDRC_XMLNodes_Col
    '                            objXMLNodeLis_col = objXMLNode.GetElementsByTagName(objDR_XMLNode_Col.Item("Name_XMLNode"))
    '                            If objXMLNodeLis_col.Count > 0 Then
    '                                objXMLNode_col = objXMLNodeLis_col(0)


    '                                objDict.Add(objDR_XMLNode_Col.Item("Name_XMLNode"), objXMLNode_col.InnerText)
    '                                'strFields = strFields & "" & objDR_XMLNode_Col.Item("Name_XMLNode") & """ : """ & objXMLNode_col.InnerText & """"
    '                            End If

    '                        Next

    '                        If objDict.Count > 0 Then
    '                            ReDim Preserve objBulkObjects(intItem)
    '                            objBulkObjects(intItem) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, objSemItem_TypeElasticSearch.Name, lngRowID, objDict)
    '                        End If
    '                        lngRowID = lngRowID + 1
    '                        intCount = intCount - 1
    '                        intItem = intItem + 1
    '                    End While
    '                    Try
    '                        objOPResult = objElasticSearch.Bulk(objBulkObjects)
    '                    Catch ex As Exception
    '                        MsgBox(ex.Message)
    '                    End Try

    '                    'MsgBox(objOPResult.JsonString)

    '                End While
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try


    '        End If
    '        'objElasticSearch = New ElasticSearch.Client.ElasticSearchClient(objSemItem_Server.Name, objSemItem_Port.Name, Client.Config.TransportType.Http, False)


    '        'get_BulkObjects(objXMLImport, objSemItem_Index, objSemItem_TypeElasticSearch, objXML)


    '        'objTextWriter = New IO.StreamWriter("C:\Temp\json.txt")
    '        'objTextWriter.Write(strJson)
    '        'objTextWriter.Close()

    '        'objRestRequest = New RestRequest("_bulk", Method.POST)
    '        'objRestRequest.AddFile("request", "C:\Temp\json.txt")
    '        'initialize_RestClient()
    '        'objWebRequest = Net.HttpWebRequest.Create("http://" & objSemItem_Server.Name & ":" & objSemItem_Port.Name)
    '        'objWebRequest.Method = "POST"
    '        'objStream = objWebRequest.GetRequestStream()

    '        'bytes = System.Text.Encoding.UTF8.GetBytes(strJson)
    '        'objStream.Write(bytes, 0, bytes.Count - 1)
    '        'objStream.Close()
    '        'objWebResponse = objWebRequest.GetResponse
    '        'objStreamReader = New IO.StreamReader(objWebResponse.GetResponseStream(), True)
    '        'strResponse = objStreamReader.ReadToEnd()

    '        'objWebclient.UploadFile("http://" & objSemItem_Server.Name & ":" & objSemItem_Port.Name, "C:\Temp\json.txt")
    '        'objRestResponse = objRestClient.Execute(objRestRequest)

    '    Else
    '        objSemItem_Result = objLocalConfig.Globals.LogState_Error
    '    End If


    '    Return objSemItem_Result
    'End Function

    Public Sub get_BulkObjects(ByVal objXMLImport As clsSemItem, ByVal objSemItem_Index As clsSemItem, ByVal objSemItem_TypeElasticSearch As clsSemItem, ByVal objXML As Xml.XmlDocument)
        Dim strJson As String = ""
        Dim strFields As String = ""
        Dim objDRC_XMLNodes_Col As DataRowCollection
        Dim objDR_XMLNode_Col As DataRow
        Dim objXMLNodeList As Xml.XmlNodeList
        Dim objXMLNode As Xml.XmlElement
        Dim objXMLNodeLis_col As Xml.XmlNodeList
        Dim objXMLNode_col As Xml.XmlElement
        Dim objBulkObjects() As ElasticSearch.Client.Domain.BulkObject

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

    'Private Sub initialize_RestClient()
    '    'objRestClient = New RestClient("http://" & objSemItem_Server.Name & ":" & objSemItem_Port.Name)
    '    objRestClient = New RestClient("http://localhost:" & objSemItem_Port.Name)
    'End Sub

    Private Sub get_Data_Indexes()
        funcA_TokenToken.Fill_TokenToken_RightLeft(funcT_Indexes, _
                                                   objSemItem_ServerPort.GUID, _
                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                   objLocalConfig.SemItem_Type_Indexes__Elastic_Search_.GUID)

    End Sub

    Public Function export_Attributes() As clsSemItem
        Dim objDRC_Attribute As DataRowCollection
        Dim i As Integer
        Dim objSemItem_Result As clsSemItem
        Dim strJson As String = ""
        Dim lngPack As Long
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects() As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult
        Dim strGUID_AttributeType As String

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If
        initialize_ElConn()
        Try
            objElConn.CreateIndex(objSemItem_Index.Name)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            lngPack = 0
            objDRC_Attribute = semtblA_Attribute.GetData().Rows

            For i = 0 To objDRC_Attribute.Count - 1
                objDict = New Dictionary(Of String, Object)
                objDict.Add("ID_Item", objDRC_Attribute(i).Item("GUID_Attribute").ToString)
                objDict.Add("Name_Item", objDRC_Attribute(i).Item("Name_Attribute").ToString)
                Select Case objDRC_Attribute(i).Item("GUID_AttributeType")
                    Case objLocalConfig.Globals.AttributeType_Bool.GUID
                        strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Bool.GUID.ToString
                    Case objLocalConfig.Globals.AttributeType_Date.GUID
                        strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Datetime.GUID.ToString
                    Case objLocalConfig.Globals.AttributeType_Datetime.GUID
                        strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Datetime.GUID.ToString
                    Case objLocalConfig.Globals.AttributeType_Time.GUID
                        strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Time.GUID.ToString
                    Case objLocalConfig.Globals.AttributeType_Int.GUID
                        strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Int.GUID.ToString
                    Case objLocalConfig.Globals.AttributeType_Real.GUID
                        strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Real.GUID.ToString
                    Case objLocalConfig.Globals.AttributeType_String.GUID
                        strGUID_AttributeType = objLocalConfig.Globals.AttributeType_String.GUID.ToString
                    Case objLocalConfig.Globals.AttributeType_Time.GUID
                        strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Datetime.GUID.ToString
                    Case objLocalConfig.Globals.AttributeType_Varchar255.GUID
                        strGUID_AttributeType = objLocalConfig.Globals.AttributeType_String.GUID.ToString
                End Select
                objDict.Add("ID_DataType", strGUID_AttributeType)

                ReDim Preserve objBulkObjects(lngPack)
                objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "AttributeType", objDRC_Attribute(i).Item("GUID_Attribute").ToString, objDict)
                objDict = Nothing


                If lngPack = 10000 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End Try

                    lngPack = 0
                End If

                lngPack = lngPack + 1
            Next

            If Not objBulkObjects Is Nothing Then
                If objBulkObjects.Count > 0 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End Try
                End If

            End If
        End If


        Return objSemItem_Result
    End Function
    Public Function export_Token() As clsSemItem
        Dim objDRC_Token As DataRowCollection
        Dim i As Integer
        Dim objSemItem_Result As clsSemItem
        Dim strJson As String = ""
        Dim lngPack As Long
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects() As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If
        initialize_ElConn()
        Try
            objElConn.CreateIndex(objSemItem_Index.Name)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            lngPack = 0
            objDRC_Token = semtblA_Token.GetData().Rows

            For i = 0 To objDRC_Token.Count - 1
                objDict = New Dictionary(Of String, Object)
                objDict.Add("ID_Item", objDRC_Token(i).Item("GUID_Token").ToString)
                objDict.Add("Name_Item", objDRC_Token(i).Item("Name_Token").ToString)
                objDict.Add("ID_Class", objDRC_Token(i).Item("GUID_Type").ToString)

                ReDim Preserve objBulkObjects(lngPack)
                objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "Object", objDRC_Token(i).Item("GUID_Token").ToString, objDict)
                objDict = Nothing


                If lngPack = 10000 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                        lngPack = 0
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End Try

                    lngPack = 0
                Else
                    lngPack = lngPack + 1
                End If


            Next

            If Not objBulkObjects Is Nothing Then
                If objBulkObjects.Count > 0 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End Try
                End If

            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function export_TokenRel() As clsSemItem
        Dim objDRC_TokenRel As DataRowCollection
        Dim i As Integer
        Dim objSemItem_Result As clsSemItem
        Dim strJson As String = ""
        Dim lngPack As Long
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects() As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If
        initialize_ElConn()
        Try
            objElConn.CreateIndex(objSemItem_Index.Name)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            lngPack = 0
            objDRC_TokenRel = funcA_TokenToken.GetData().Rows

            For i = 0 To objDRC_TokenRel.Count - 1
                objDict = New Dictionary(Of String, Object)
                objDict.Add("ID_Object", objDRC_TokenRel(i).Item("GUID_Token_Left").ToString)
                objDict.Add("ID_Parent_Left", objDRC_TokenRel(i).Item("GUID_Type_Left").ToString)
                objDict.Add("ID_Right", objDRC_TokenRel(i).Item("GUID_Token_Right").ToString)
                objDict.Add("ID_Parent_Right", objDRC_TokenRel(i).Item("GUID_Type_Right").ToString)
                objDict.Add("ID_Ontology", objLocalConfig.SemItem_Token_KindOfOntology_Object.GUID.ToString)
                objDict.Add("ID_RelationType", objDRC_TokenRel(i).Item("GUID_RelationType").ToString)
                objDict.Add("OrderID", objDRC_TokenRel(i).Item("OrderID").ToString)

                ReDim Preserve objBulkObjects(lngPack)
                objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ObjectRel", objDRC_TokenRel(i).Item("GUID_Token_Left").ToString & "_" & objDRC_TokenRel(i).Item("GUID_Token_Right").ToString & "_" & objDRC_TokenRel(i).Item("GUID_RelationType").ToString, objDict)
                objDict = Nothing


                If lngPack = 10000 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                        lngPack = 0
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End Try

                    lngPack = 0
                Else
                    lngPack = lngPack + 1
                End If


            Next

            If Not objBulkObjects Is Nothing Then
                If objBulkObjects.Count > 0 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End Try
                End If

            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function export_Token_OR() As clsSemItem
        Dim semfuncT_ObjectReference As New ds_ObjectReference.semfunc_ObjectReferenceDataTable
        Dim semtblT_Token As New ds_SemDB.semtbl_TokenDataTable
        Dim objDRC_TokenOR As DataRowCollection
        Dim objDRC_Item As DataRowCollection
        Dim i As Integer
        Dim objSemItem_Result As clsSemItem
        Dim strJson As String = ""
        Dim lngPack As Long
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects() As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult
        Dim objDRs_OR() As DataRow
        Dim objDRs_Token() As DataRow

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If
        initialize_ElConn()
        Try
            objElConn.CreateIndex(objSemItem_Index.Name)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

            lngPack = 0
            semfuncA_ObjectReference.Fill(semfuncT_ObjectReference)
            semtblA_Token.Fill(semtblT_Token)

            objDRC_TokenOR = semtblA_Token_OR.GetData().Rows

            For i = 0 To objDRC_TokenOR.Count - 1

                objDRs_OR = semfuncT_ObjectReference.Select("GUID_ObjectReference='" & objDRC_TokenOR(i).Item("GUID_ObjectReference").ToString & "'")
                objDRs_Token = semtblT_Token.Select("GUID_Token='" & objDRC_TokenOR(i).Item("GUID_Token_Left").ToString & "'")
                If objDRs_OR.Count > 0 And objDRs_Token.Count > 0 Then

                    objDict = New Dictionary(Of String, Object)
                    objDict.Add("ID_Object", objDRs_Token(0).Item("GUID_Token").ToString)
                    objDict.Add("ID_Parent_Left", objDRs_Token(0).Item("GUID_Type").ToString)



                    objDict.Add("ID_Right", objDRs_OR(0).Item("GUID_Ref").ToString)
                    objDict.Add("ID_RelationType", objDRC_TokenOR(i).Item("GUID_RelationType").ToString)
                    objDict.Add("OrderID", objDRC_TokenOR(i).Item("OrderID").ToString)
                    Select Case objDRs_OR(0).Item("GUID_ItemType")
                        Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                            objDict.Add("ID_Ontology", objLocalConfig.SemItem_Token_KindOfOntology_Attribute.GUID.ToString)
                        Case objLocalConfig.Globals.ObjectReferenceType_AttributeType.GUID
                            objDict.Add("ID_Ontology", objLocalConfig.SemItem_Token_KindOfOntology_DataType.GUID.ToString)
                        Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                            objDict.Add("ID_Ontology", objLocalConfig.SemItem_Token_KindOfOntology_RelationType.GUID.ToString)
                        Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objDict.Add("ID_Ontology", objLocalConfig.SemItem_Token_KindOfOntology_Object.GUID.ToString)
                            objDRs_Token = semtblT_Token.Select("GUID_Token='" & objDRs_OR(0).Item("GUID_Ref").ToString & "'")
                            If objDRs_Token.Count > 0 Then
                                objDict.Add("ID_Parent_Right", objDRs_Token(0).Item("GUID_Type").ToString)
                            End If

                        
                        Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                            objDict.Add("ID_Ontology", objLocalConfig.SemItem_Token_KindOfOntology_Class.GUID.ToString)

                    End Select


                    ReDim Preserve objBulkObjects(lngPack)
                    objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ObjectRel", objDRC_TokenOR(i).Item("GUID_Token_Left").ToString & "_" & objDRs_OR(0).Item("GUID_Ref").ToString & "_" & objDRC_TokenOR(i).Item("GUID_RelationType").ToString, objDict)
                    objDict = Nothing


                    If lngPack = 10000 Then
                        Try
                            objOPResult = objElConn.Bulk(objBulkObjects)
                            objBulkObjects = Nothing
                        Catch ex As Exception
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End Try

                        lngPack = 0
                    End If

                    lngPack = lngPack + 1
                End If
                
            Next

            If Not objBulkObjects Is Nothing Then
                If objBulkObjects.Count > 0 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End Try
                End If

            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function export_RelationTypes() As clsSemItem
        Dim objDRC_RelationTypes As DataRowCollection
        Dim i As Integer
        Dim objSemItem_Result As clsSemItem
        Dim strJson As String = ""
        Dim lngPack As Long
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects() As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If
        initialize_ElConn()
        Try
            objElConn.CreateIndex(objSemItem_Index.Name)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            lngPack = 0
            objDRC_RelationTypes = semtblA_RelationType.GetData().Rows

            For i = 0 To objDRC_RelationTypes.Count - 1
                objDict = New Dictionary(Of String, Object)
                objDict.Add("ID_Item", objDRC_RelationTypes(i).Item("GUID_RelationType").ToString)
                objDict.Add("Name_Item", objDRC_RelationTypes(i).Item("Name_RelationType").ToString)

                ReDim Preserve objBulkObjects(lngPack)
                objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "RelationType", objDRC_RelationTypes(i).Item("GUID_RelationType").ToString, objDict)
                objDict = Nothing


                If lngPack = 10000 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End Try

                    lngPack = 0
                End If

                lngPack = lngPack + 1
            Next

            If Not objBulkObjects Is Nothing Then
                If objBulkObjects.Count > 0 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End Try
                End If

            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function export_TokenAttribute(ByVal GUID_AttributeType) As clsSemItem
        Dim objDRC_TokenAttribute As DataRowCollection
        Dim i As Integer
        Dim objSemItem_Result As clsSemItem
        Dim strJson As String = ""
        Dim lngPack As Long
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects_AttItems() As ElasticSearch.Client.Domain.BulkObject
        Dim objBulkObjects_ObjAtt() As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult
        Dim strGUID_AttributeType As String
        Dim strVal_RowName As String
        Dim strVal_Name As String

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If
        initialize_ElConn()
        Try
            objElConn.CreateIndex(objSemItem_Index.Name)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            lngPack = 0
            Select Case GUID_AttributeType
                Case objLocalConfig.Globals.AttributeType_Bool.GUID
                    objDRC_TokenAttribute = TokenAAttribute_Bit.GetData().Rows
                    strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Bool.GUID.ToString
                    strVal_RowName = "Val_Bool"
                Case objLocalConfig.Globals.AttributeType_Date.GUID
                    objDRC_TokenAttribute = TokenAAttribute_Date.GetData().Rows
                    strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Datetime.GUID.ToString
                    strVal_RowName = "Val_Datetime"
                Case objLocalConfig.Globals.AttributeType_Datetime.GUID
                    objDRC_TokenAttribute = TokenAAttribute_Datetime.GetData().Rows
                    strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Datetime.GUID.ToString
                    strVal_RowName = "Val_Datetime"
                Case objLocalConfig.Globals.AttributeType_Time.GUID
                    objDRC_TokenAttribute = TokenAAttribute_Time.GetData().Rows
                    strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Datetime.GUID.ToString
                    strVal_RowName = "Val_Datetime"
                Case objLocalConfig.Globals.AttributeType_Int.GUID
                    objDRC_TokenAttribute = TokenAAttribute_Int.GetData().Rows
                    strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Int.GUID.ToString
                    strVal_RowName = "Val_Int"
                Case objLocalConfig.Globals.AttributeType_Real.GUID
                    objDRC_TokenAttribute = TokenAAttribute_Real.GetData().Rows
                    strGUID_AttributeType = objLocalConfig.Globals.AttributeType_Real.GUID.ToString
                    strVal_RowName = "Val_Real"
                Case objLocalConfig.Globals.AttributeType_String.GUID
                    objDRC_TokenAttribute = TokenAAttribute_VarcharMax.GetData().Rows
                    strGUID_AttributeType = objLocalConfig.Globals.AttributeType_String.GUID.ToString
                    strVal_RowName = "Val_String"
                Case objLocalConfig.Globals.AttributeType_Varchar255.GUID
                    objDRC_TokenAttribute = TokenAAttribute_Varchar255.GetData().Rows
                    strGUID_AttributeType = objLocalConfig.Globals.AttributeType_String.GUID.ToString
                    strVal_RowName = "Val_String"
            End Select


            For i = 0 To objDRC_TokenAttribute.Count - 1
                objDict = New Dictionary(Of String, Object)

                objDict.Add(strVal_RowName, objDRC_TokenAttribute(i).Item("Val"))
                Select Case strVal_RowName
                    Case "Val_Bool"
                        If objDRC_TokenAttribute(i).Item("Val") = True Then
                            objDict.Add("Val_Name", "True")

                        Else
                            objDict.Add("Val_Name", "False")

                        End If
                    Case "Val_Datetime"
                        objDict.Add("Val_Name", objDRC_TokenAttribute(i).Item("Val").ToString)
                    Case "Val_Int"
                        objDict.Add("Val_Name", objDRC_TokenAttribute(i).Item("Val").ToString)
                    Case "Val_Real"
                        objDict.Add("Val_Name", objDRC_TokenAttribute(i).Item("Val").ToString)
                    Case "Val_String"
                        objDict.Add("Val_Name", objDRC_TokenAttribute(i).Item("Val").ToString)

                End Select
                objDict.Add("ID_Item", objDRC_TokenAttribute(i).Item("GUID_TokenAttribute").ToString)
                objDict.Add("ID_AttributeType", objDRC_TokenAttribute(i).Item("GUID_Attribute").ToString)
                
                objDict.Add("ID_DataType", strGUID_AttributeType)


                ReDim Preserve objBulkObjects_AttItems(lngPack)
                objBulkObjects_AttItems(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "Attribute", objDRC_TokenAttribute(i).Item("GUID_TokenAttribute").ToString, objDict)
                objDict = Nothing
                objDict = New Dictionary(Of String, Object)
                objDict.Add("ID_Object", objDRC_TokenAttribute(i).Item("GUID_Token").ToString)
                objDict.Add("ID_Class", objDRC_TokenAttribute(i).Item("GUID_Type").ToString)
                objDict.Add("ID_ObjectAttribute", objDRC_TokenAttribute(i).Item("GUID_TokenAttribute").ToString)
                objDict.Add("OrderID", objDRC_TokenAttribute(i).Item("OrderID"))

                ReDim Preserve objBulkObjects_ObjAtt(lngPack)
                objBulkObjects_ObjAtt(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ObjectAttribute", objDRC_TokenAttribute(i).Item("GUID_Token").ToString & "_" & objDRC_TokenAttribute(i).Item("GUID_TokenAttribute").ToString, objDict)
                objDict = Nothing

                If lngPack = 10000 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects_AttItems)
                        objOPResult = objElConn.Bulk(objBulkObjects_ObjAtt)
                        objBulkObjects_AttItems = Nothing
                        objBulkObjects_ObjAtt = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End Try

                    lngPack = 0
                End If

                lngPack = lngPack + 1
            Next

            If Not objBulkObjects_AttItems Is Nothing Then
                If objBulkObjects_AttItems.Count > 0 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects_AttItems)
                        objBulkObjects_AttItems = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End Try
                End If

            End If

            If Not objBulkObjects_ObjAtt Is Nothing Then
                If objBulkObjects_ObjAtt.Count > 0 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects_ObjAtt)
                        objBulkObjects_AttItems = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End Try
                End If

            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function export_Types() As clsSemItem
        Dim objDRC_Types As DataRowCollection
        Dim i As Integer
        Dim objSemItem_Result As clsSemItem
        Dim strJson As String = ""
        Dim lngPack As Long
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects() As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If
        initialize_ElConn()
        Try
            objElConn.CreateIndex(objSemItem_Index.Name)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            lngPack = 0
            objDRC_Types = semtblA_Type.GetData().Rows

            For i = 0 To objDRC_Types.Count - 1
                objDict = New Dictionary(Of String, Object)
                objDict.Add("ID_Item", objDRC_Types(i).Item("GUID_Type").ToString)
                objDict.Add("Name_Item", objDRC_Types(i).Item("Name_Type").ToString)
                objDict.Add("ID_Parent", objDRC_Types(i).Item("GUID_Type_Parent").ToString)


                ReDim Preserve objBulkObjects(lngPack)
                objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "Class", objDRC_Types(i).Item("GUID_Type").ToString, objDict)
                objDict = Nothing


                If lngPack = 10000 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End Try

                    lngPack = 0
                End If

                lngPack = lngPack + 1
            Next

            If Not objBulkObjects Is Nothing Then
                If objBulkObjects.Count > 0 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End Try
                End If

            End If
        End If
        

        Return objSemItem_Result
    End Function

    Public Function export_TypeRel() As clsSemItem
        Dim objDRC_TypeRel As DataRowCollection
        Dim i As Integer
        Dim objSemItem_Result As clsSemItem
        Dim strJson As String = ""
        Dim lngPack As Long
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects() As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If
        initialize_ElConn()
        Try
            objElConn.CreateIndex(objSemItem_Index.Name)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            lngPack = 0
            objDRC_TypeRel = typefuncA_Types_Rel.GetData().Rows

            For i = 0 To objDRC_TypeRel.Count - 1
                objDict = New Dictionary(Of String, Object)
                objDict.Add("ID_Class_Left", objDRC_TypeRel(i).Item("GUID_Type_Left").ToString)
                objDict.Add("ID_Class_Right", objDRC_TypeRel(i).Item("GUID_Type_Right").ToString)
                objDict.Add("ID_RelationType", objDRC_TypeRel(i).Item("GUID_RelationType").ToString)
                objDict.Add("Min_forw", objDRC_TypeRel(i).Item("Min_forw"))
                objDict.Add("Max_forw", objDRC_TypeRel(i).Item("Max_forw"))
                objDict.Add("Max_backw", objDRC_TypeRel(i).Item("Max_backw"))


                ReDim Preserve objBulkObjects(lngPack)
                objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ClassRel", objDRC_TypeRel(i).Item("GUID_Type_Left").ToString & "_" & objDRC_TypeRel(i).Item("GUID_Type_Right").ToString & "_" & objDRC_TypeRel(i).Item("GUID_RelationType").ToString, objDict)
                objDict = Nothing


                If lngPack = 10000 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End Try

                    lngPack = 0
                End If

                lngPack = lngPack + 1
            Next

            If Not objBulkObjects Is Nothing Then
                If objBulkObjects.Count > 0 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End Try
                End If

            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function export_TypeAtt() As clsSemItem
        Dim objDRC_TypeAtt As DataRowCollection
        Dim i As Integer
        Dim objSemItem_Result As clsSemItem
        Dim strJson As String = ""
        Dim lngPack As Long
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects() As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If
        initialize_ElConn()
        Try
            objElConn.CreateIndex(objSemItem_Index.Name)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            lngPack = 0
            objDRC_TypeAtt = typefuncA_Types_With_Attributes_And_Types.GetData().Rows

            For i = 0 To objDRC_TypeAtt.Count - 1
                objDict = New Dictionary(Of String, Object)
                objDict.Add("ID_Class", objDRC_TypeAtt(i).Item("GUID_Type").ToString)
                objDict.Add("ID_Attribute", objDRC_TypeAtt(i).Item("GUID_Attribute").ToString)
                objDict.Add("ID_AttributeType", objDRC_TypeAtt(i).Item("GUID_AttributeType").ToString)
                objDict.Add("Min", objDRC_TypeAtt(i).Item("Min").ToString)
                objDict.Add("Max", objDRC_TypeAtt(i).Item("Max").ToString)

                ReDim Preserve objBulkObjects(lngPack)
                objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ClassAtt", objDRC_TypeAtt(i).Item("GUID_Type").ToString, objDict)
                objDict = Nothing


                If lngPack = 10000 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End Try

                    lngPack = 0
                End If

                lngPack = lngPack + 1
            Next

            If Not objBulkObjects Is Nothing Then
                If objBulkObjects.Count > 0 Then
                    Try
                        objOPResult = objElConn.Bulk(objBulkObjects)
                        objBulkObjects = Nothing
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End Try
                End If

            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function export_DataTypes() As clsSemItem
        Dim i As Integer
        Dim objSemItem_Result As clsSemItem
        Dim strJson As String = ""
        Dim lngPack As Long
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects() As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If
        initialize_ElConn()
        Try
            objElConn.CreateIndex(objSemItem_Index.Name)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            lngPack = 0



            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.Globals.AttributeType_Bool.GUID)
            objDict.Add("Name_Item", objLocalConfig.Globals.AttributeType_Bool.Name)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "DataType", objLocalConfig.Globals.AttributeType_Bool.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.Globals.AttributeType_Datetime.GUID)
            objDict.Add("Name_Item", objLocalConfig.Globals.AttributeType_Datetime.Name)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "DataType", objLocalConfig.Globals.AttributeType_Datetime.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.Globals.AttributeType_Int.GUID)
            objDict.Add("Name_Item", objLocalConfig.Globals.AttributeType_Int.Name)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "DataType", objLocalConfig.Globals.AttributeType_Int.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.Globals.AttributeType_Real.GUID)
            objDict.Add("Name_Item", objLocalConfig.Globals.AttributeType_Real.Name)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "DataType", objLocalConfig.Globals.AttributeType_Real.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.Globals.AttributeType_String.GUID)
            objDict.Add("Name_Item", objLocalConfig.Globals.AttributeType_String.Name)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "DataType", objLocalConfig.Globals.AttributeType_String.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            Try
                objOPResult = objElConn.Bulk(objBulkObjects)
                objBulkObjects = Nothing
            Catch ex As Exception
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End Try








        End If


        Return objSemItem_Result
    End Function

    Public Function export_ItemTypes() As clsSemItem
        Dim i As Integer
        Dim objSemItem_Result As clsSemItem
        Dim strJson As String = ""
        Dim lngPack As Long
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects() As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objSemItem_XMLImport Is Nothing Then
            get_Data_XMLImport()
        End If
        initialize_ElConn()
        Try
            objElConn.CreateIndex(objSemItem_Index.Name)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            lngPack = 0


            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.SemItem_Token_KindOfOntology_Attribute.GUID)
            objDict.Add("Name_Item", objLocalConfig.SemItem_Token_KindOfOntology_Attribute.Name)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ItemType", objLocalConfig.SemItem_Token_KindOfOntology_Attribute.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.SemItem_Token_KindOfOntology_AttributeInstance.GUID)
            objDict.Add("Name", objLocalConfig.SemItem_Token_KindOfOntology_AttributeInstance.Name)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ItemType", objLocalConfig.SemItem_Token_KindOfOntology_AttributeInstance.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.SemItem_Token_KindOfOntology_Class.GUID)
            objDict.Add("Name", objLocalConfig.SemItem_Token_KindOfOntology_Class.Name)
            objDict.Add("ID_ItemType", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ItemType", objLocalConfig.SemItem_Token_KindOfOntology_Class.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.SemItem_Token_KindOfOntology_Class_Attribute.GUID)
            objDict.Add("Name", objLocalConfig.SemItem_Token_KindOfOntology_Class_Attribute.Name)
            objDict.Add("ID_ItemType", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ItemType", objLocalConfig.SemItem_Token_KindOfOntology_Class_Attribute.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.SemItem_Token_KindOfOntology_Class_Ontology.GUID)
            objDict.Add("Name", objLocalConfig.SemItem_Token_KindOfOntology_Class_Ontology.Name)
            objDict.Add("ID_ItemType", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ItemType", objLocalConfig.SemItem_Token_KindOfOntology_Class_Ontology.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.SemItem_Token_KindOfOntology_Class_Relation.GUID)
            objDict.Add("Name", objLocalConfig.SemItem_Token_KindOfOntology_Class_Relation.Name)
            objDict.Add("ID_ItemType", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ItemType", objLocalConfig.SemItem_Token_KindOfOntology_Class_Relation.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.SemItem_Token_KindOfOntology_DataType.GUID)
            objDict.Add("Name", objLocalConfig.SemItem_Token_KindOfOntology_DataType.Name)
            objDict.Add("ID_ItemType", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ItemType", objLocalConfig.SemItem_Token_KindOfOntology_DataType.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID)
            objDict.Add("Name", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.Name)
            objDict.Add("ID_ItemType", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ItemType", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.SemItem_Token_KindOfOntology_Object.GUID)
            objDict.Add("Name", objLocalConfig.SemItem_Token_KindOfOntology_Object.Name)
            objDict.Add("ID_ItemType", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ItemType", objLocalConfig.SemItem_Token_KindOfOntology_Object.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.SemItem_Token_KindOfOntology_Object_Ontology.GUID)
            objDict.Add("Name", objLocalConfig.SemItem_Token_KindOfOntology_Object_Ontology.Name)
            objDict.Add("ID_ItemType", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ItemType", objLocalConfig.SemItem_Token_KindOfOntology_Object_Ontology.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1

            objDict = New Dictionary(Of String, Object)
            objDict.Add("ID_Item", objLocalConfig.SemItem_Token_KindOfOntology_RelationType.GUID)
            objDict.Add("Name", objLocalConfig.SemItem_Token_KindOfOntology_RelationType.Name)
            objDict.Add("ID_ItemType", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)

            ReDim Preserve objBulkObjects(lngPack)
            objBulkObjects(lngPack) = New ElasticSearch.Client.Domain.BulkObject(objSemItem_Index.Name, "ItemType", objLocalConfig.SemItem_Token_KindOfOntology_RelationType.GUID.ToString, objDict)
            objDict = Nothing

            lngPack = lngPack + 1
            Try
                objOPResult = objElConn.Bulk(objBulkObjects)
                objBulkObjects = Nothing
            Catch ex As Exception
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End Try








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
