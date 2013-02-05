Imports Filesystem_Management
Imports Sem_Manager
Public Class clsCSVImport

    Private procA_CSVImport As New DataSet_ElasticSearchConnectorTableAdapters.proc_CSVImportTableAdapter
    Private procT_CSVImport As New DataSet_ElasticSearchConnector.proc_CSVImportDataTable
    Private procA_CSVImport_Fields As New DataSet_ElasticSearchConnectorTableAdapters.proc_CSVImport_FieldsTableAdapter
    Private procT_CSVImport_Fields As New DataSet_ElasticSearchConnector.proc_CSVImport_FieldsDataTable

    Private objLocalConfig As clsLocalConfig

    Public ReadOnly Property tbl_CSVImport As DataSet_ElasticSearchConnector.proc_CSVImportDataTable
        Get
            Return procT_CSVImport
        End Get
    End Property

    Private Sub get_CSVImports()
        procA_CSVImport.Fill(procT_CSVImport, _
                             objLocalConfig.SemItem_Attribute_Header.GUID, _
                             objLocalConfig.SemItem_Type_CSVImport.GUID, _
                             objLocalConfig.SemItem_Type_Types__Elastic_Search_.GUID, _
                             objLocalConfig.SemItem_Type_Zeichen.GUID, _
                             objLocalConfig.SemItem_Type_File.GUID, _
                             objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                             objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                             objLocalConfig.SemItem_RelationType_Textqualifier.GUID, _
                             objLocalConfig.SemItem_RelationType_Seperator.GUID, _
                             objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                             objLocalConfig.SemItem_User.GUID)

    End Sub

    Public Function get_CSVImport_Fields(ByVal SemItem_CSVImport As clsSemItem) As DataSet_ElasticSearchConnector.proc_CSVImport_FieldsDataTable
        procA_CSVImport_Fields.Fill(procT_CSVImport_Fields, _
                                    objLocalConfig.SemItem_Type_Field.GUID, _
                                    objLocalConfig.SemItem_Type_Field_Type.GUID, _
                                    objLocalConfig.SemItem_RelationType_contains.GUID, _
                                    objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                    SemItem_CSVImport.GUID)
        Return procT_CSVImport_Fields
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        get_CSVImports()
    End Sub

    Private Sub set_DBConnection()
        procA_CSVImport.Connection = objLocalConfig.Connection_Plugin
        procA_CSVImport_Fields.Connection = objLocalConfig.Connection_Plugin
    End Sub
End Class
