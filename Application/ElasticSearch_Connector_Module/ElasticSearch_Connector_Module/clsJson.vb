Imports Newtonsoft.Json
Imports Sem_Manager
Public Class clsJson
    Private objLocalConfig As clsLocalConfig

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_XMLNodes_ColConfig As New DataSet_ElasticSearchConnectorTableAdapters.proc_XMLNodes_ColConfigTableAdapter

    Public Function convert_XML_To_Json_ForElasticSearch(ByVal objXMLImport As clsSemItem, ByVal objSemItem_Index As clsSemItem, ByVal objSemItem_TypeElasticSearch As clsSemItem, ByVal objXML As Xml.XmlDocument) As String
        Dim strJson As String = ""
        Dim objDRC_XMLNode_Row As DataRowCollection
        Dim objDRC_XMLNodes_Col As DataRowCollection
        Dim objDR_XMLNode_Col As DataRow
        Dim objXMLNodeList As Xml.XmlNodeList
        Dim objXMLNode As Xml.XmlElement
        Dim objXMLNodeLis_col As Xml.XmlNodeList
        Dim objXMLNode_col As Xml.XmlElement
        Dim lngID As Long = 1

        objDRC_XMLNode_Row = funcA_TokenToken.GetData_TokenToken_LeftRight(objXMLImport.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_RowConfig.GUID, _
                                                                           objLocalConfig.SemItem_Type_XMLNode.GUID).Rows

        If objDRC_XMLNode_Row.Count > 0 Then
            objDRC_XMLNodes_Col = procA_XMLNodes_ColConfig.GetData(objLocalConfig.SemItem_Type_XMLNode.GUID, _
                                                                   objLocalConfig.SemItem_Type_FieldType.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_ColConfig.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_isOfType.GUID, _
                                                                   objXMLImport.GUID).Rows
            If objDRC_XMLNodes_Col.Count > 0 Then
                objXMLNodeList = objXML.GetElementsByTagName(objDRC_XMLNode_Row(0).Item("Name_Token_Right"))
                For Each objXMLNode In objXMLNodeList
                    strJson = strJson & "{ ""index"" : { ""_index"" : """ & objSemItem_Index.Name & """, ""_type"" : """ & objSemItem_TypeElasticSearch.Name & """, ""_id"" : """ & lngID & """} }" & vbCrLf
                    For Each objDR_XMLNode_Col In objDRC_XMLNodes_Col
                        objXMLNodeLis_col = objXMLNode.GetElementsByTagName(objDR_XMLNode_Col.Item("Name_XMLNode"))
                        If objXMLNodeLis_col.Count > 0 Then
                            objXMLNode_col = objXMLNodeLis_col(0)
                            strJson = strJson & "{ """ & objDR_XMLNode_Col.Item("Name_XMLNode") & """ : """ & objXMLNode_col.InnerText & """ }" & vbCrLf
                        End If

                    Next
                    lngID = lngID + 1

                Next
            Else
                strJson = ""
            End If

        Else
            strJson = ""
        End If
        Return strJson
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_XMLNodes_ColConfig.Connection = objLocalConfig.Connection_Plugin
    End Sub
End Class
