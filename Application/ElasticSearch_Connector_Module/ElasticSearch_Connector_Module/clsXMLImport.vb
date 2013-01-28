Imports Sem_Manager
Public Class clsXMLImport
    Private objLocalConfig As clsLocalConfig

    Private objSemItem_User As clsSemItem

    Private procA_XMLImport As New DataSet_ElasticSearchConnectorTableAdapters.proc_XMLImportTableAdapter
    Private procT_XMLImport As New DataSet_ElasticSearchConnector.proc_XMLImportDataTable

    Public ReadOnly Property tbl_XMLImport As DataSet_ElasticSearchConnector.proc_XMLImportDataTable
        Get
            Return procT_XMLImport
        End Get
    End Property

    Private Sub get_Data_XMLImport()
        procA_XMLImport.Fill(procT_XMLImport, _
                             objLocalConfig.SemItem_User.GUID, _
                             objLocalConfig.SemItem_Type_XML_Import.GUID, _
                             objLocalConfig.SemItem_Type_Url.GUID, _
                             objLocalConfig.SemItem_Type_Types__Elastic_Search_.GUID, _
                             objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                             objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                             objLocalConfig.SemItem_RelationType_is_of_Type.GUID)

    End Sub

    Public Function get_XML_Of_WebResource(ByVal SemItem_XMLImport As clsSemItem) As Xml.XmlDocument
        Dim objDRs_XMLImport() As DataRow
        Dim objXML As Xml.XmlDocument
        get_Data_XMLImport()

        objDRs_XMLImport = procT_XMLImport.Select("GUID_XMLImport='" & SemItem_XMLImport.GUID.ToString & "'")
        If objDRs_XMLImport.Count > 0 Then
            objXML = New Xml.XmlDocument()
            Try
                objXML.Load(objDRs_XMLImport(0).Item("Name_Url"))
            Catch ex As Exception
                objXML = Nothing
            End Try


        Else
            objXML = Nothing
        End If

        Return objXML
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_User As clsSemItem)
        objLocalConfig = LocalConfig

        objSemItem_User = SemItem_User
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        procA_XMLImport.Connection = objLocalConfig.Connection_Plugin

    End Sub
End Class
