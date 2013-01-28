Imports Newtonsoft.Json
Imports Sem_Manager
Public Class clsJson
    Private objLocalConfig As clsLocalConfig

    Private objXMLDoc As Xml.XmlDocument

    Private strJson_Document As String
    Private strJson_Attribute As String

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private procA_XMLNodes_ColConfig As New DataSet_ElasticSearchConnectorTableAdapters.proc_XMLNodes_ColConfigTableAdapter

    Public ReadOnly Property Json_Document As String
        Get
            Return strJson_Document
        End Get
    End Property

    Public ReadOnly Property Json_Attribute As String
        Get
            Return strJson_Attribute
        End Get
    End Property

    Private Function get_Data_JsonTemplates() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_XML As DataRowCollection
        Dim objXMLNodeList As Xml.XmlNodeList
        Dim objXMLElement As Xml.XmlElement

        objDRC_XML = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objLocalConfig.SemItem_Token_XML_ES_Bulk_Document.GUID, _
                                                                                                    objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
        If objDRC_XML.Count > 0 Then
            Try
                objXMLDoc = New Xml.XmlDocument()
                objXMLDoc.LoadXml(objDRC_XML(0).Item("VAL_VARCHARMAX"))
                objXMLNodeList = objXMLDoc.GetElementsByTagName("data")
                objXMLElement = objXMLNodeList(0)

                strJson_Document = objXMLElement.InnerText

                objDRC_XML = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objLocalConfig.SemItem_Token_XML_ES_Bulk_Attribute.GUID, _
                                                                                                    objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows

                If objDRC_XML.Count > 0 Then
                    objXMLDoc = New Xml.XmlDocument()
                    objXMLDoc.LoadXml(objDRC_XML(0).Item("VAL_VARCHARMAX"))
                    objXMLNodeList = objXMLDoc.GetElementsByTagName("data")
                    objXMLElement = objXMLNodeList(0)

                    strJson_Attribute = objXMLElement.InnerText

                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Catch ex As Exception
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End Try
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function convert_XML_To_Json_ForElasticSearch(ByVal objXMLImport As clsSemItem, ByVal objSemItem_Index As clsSemItem, ByVal objSemItem_TypeElasticSearch As clsSemItem, ByVal objXML As Xml.XmlDocument) As String
        Dim strJson As String = ""
        Dim strFields As String = ""
        Dim objDRC_XMLNode_Row As DataRowCollection
        Dim objDRC_XMLNodes_Col As DataRowCollection
        Dim objDR_XMLNode_Col As DataRow
        Dim objXMLNodeList As Xml.XmlNodeList
        Dim objXMLNode As Xml.XmlElement
        Dim objXMLNodeLis_col As Xml.XmlNodeList
        Dim objXMLNode_col As Xml.XmlElement
        Dim lngID As Long = 1

        objDRC_XMLNode_Row = funcA_TokenToken.GetData_TokenToken_LeftRight(objXMLImport.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_Row_Config.GUID, _
                                                                           objLocalConfig.SemItem_Type_XML_Nodes.GUID).Rows

        If objDRC_XMLNode_Row.Count > 0 Then
            objDRC_XMLNodes_Col = procA_XMLNodes_ColConfig.GetData(objLocalConfig.SemItem_Type_XML_Nodes.GUID, _
                                                                   objLocalConfig.SemItem_Type_Field_Type.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_Col_Config.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                   objXMLImport.GUID).Rows
            If objDRC_XMLNodes_Col.Count > 0 Then
                objXMLNodeList = objXML.GetElementsByTagName(objDRC_XMLNode_Row(0).Item("Name_Token_Right"))
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
                    strJson = strJson & strFields
                    strJson = strJson & " } "
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

        initialize()
    End Sub

    Private Sub initialize()
        get_Data_JsonTemplates()
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        procA_XMLNodes_ColConfig.Connection = objLocalConfig.Connection_Plugin
    End Sub
End Class
