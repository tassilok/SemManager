Imports Sem_Manager
Public Class clsXML
    Private objLocalConfig As clsLocalConfig

    Private func_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private Sub get_Data()

    End Sub

    Public Function get_XML(ByVal SemItem_XML As clsSemItem) As clsSemItem
        Dim objXML As New Xml.XmlDocument
        Dim objXMLNodeList As Xml.XmlNodeList
        Dim objXMLElement As Xml.XmlElement

        Dim objDRC_XML As DataRowCollection

        objDRC_XML = func_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(SemItem_XML.GUID, _
                                                                                                   objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows

        If objDRC_XML.Count > 0 Then
            Try
                objXML.LoadXml(objDRC_XML(0).Item("Val_varcharmax"))
                objXMLNodeList = objXML.GetElementsByTagName("data")
                If objXMLNodeList.Count > 0 Then
                    objXMLElement = objXMLNodeList(0)
                    SemItem_XML.Additional1 = objXMLElement.InnerText

                Else
                    SemItem_XML = Nothing
                End If
            Catch ex As Exception
                SemItem_XML = Nothing
            End Try

        Else
            SemItem_XML = Nothing
        End If

        Return SemItem_XML
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        func_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
    End Sub

End Class
