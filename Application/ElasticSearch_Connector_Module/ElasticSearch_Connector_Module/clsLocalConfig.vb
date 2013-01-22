Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "f40e5133-f876-42c7-ab40-c8c602f8884c"

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection

    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter

    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter


    Private objSemItem_User As New clsSemItem

    Private objGUID_Development As Guid
    Private objSemItem_Development As clsSemItem

    'Attributes


    'RelationTypes
    Private objSemItem_RelationType_belonging_Source As clsSemItem
    Private objSemItem_RelationType_belonging_resource As clsSemItem
    Private objSemItem_RelationType_belongs_to As clsSemItem
    Private objSemItem_RelationType_RowConfig As clsSemItem
    Private objSemItem_RelationType_ColConfig As clsSemItem
    Private objSemItem_RelationType_isOfType As clsSemItem
    
    'Types
    Private objSemItem_Type_ServerPort As clsSemItem
    Private objSemItem_Type_Server As clsSemItem
    Private objSemItem_Type_Port As clsSemItem
    Private objSemItem_Type_ElasticSearchConnectorModule As clsSemItem
    Private objSemItem_Type_ElasticSearch As clsSemItem
    Private objSemItem_Type_Indexes_ElasticSearch As clsSemItem
    Private objSemItem_Type_XMLImport As clsSemItem
    Private objSemItem_Type_Url As clsSemItem
    Private objSemItem_Type_XMLNode As clsSemItem
    Private objSemItem_Type_FieldType As clsSemItem
    Private objSemItem_Type_Types_Elastic_Search As clsSemItem

    'Token


    Private objSemItem_BaseConfig As clsSemItem

    'Attributes

    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_belonging_Source As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Source
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_resource As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_resource
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongs_to As clsSemItem
        Get
            Return objSemItem_RelationType_belongs_to
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_RowConfig As clsSemItem
        Get
            Return objSemItem_RelationType_RowConfig
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_ColConfig As clsSemItem
        Get
            Return objSemItem_RelationType_ColConfig
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_isOfType As clsSemItem
        Get
            Return objSemItem_RelationType_isOfType
        End Get
    End Property


    'Types
    Public ReadOnly Property SemItem_Type_ServerPort As clsSemItem
        Get
            Return objSemItem_Type_ServerPort
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Server As clsSemItem
        Get
            Return objSemItem_Type_Server
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Port As clsSemItem
        Get
            Return objSemItem_Type_Port
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_ElasticSearchConnectorModule As clsSemItem
        Get
            Return objSemItem_Type_ElasticSearchConnectorModule
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_ElasticSearch As clsSemItem
        Get
            Return objSemItem_Type_ElasticSearch
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_XMLImport As clsSemItem
        Get
            Return objSemItem_Type_XMLImport
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_IndexesElasticSearch As clsSemItem
        Get
            Return objSemItem_Type_Indexes_ElasticSearch
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Url As clsSemItem
        Get
            Return objSemItem_Type_Url
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_XMLNode As clsSemItem
        Get
            Return objSemItem_Type_XMLNode
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_FieldType As clsSemItem
        Get
            Return objSemItem_Type_FieldType
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Types_Elastic_Search As clsSemItem
        Get
            Return objSemItem_Type_Types_Elastic_Search
        End Get
    End Property




    'Token


    Public ReadOnly Property SemItem_BaseConfig As clsSemItem
        Get
            Return objSemItem_BaseConfig
        End Get
    End Property

    Public Property SemItem_User As clsSemItem
        Get
            Return objSemItem_User
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_User = value
        End Set
    End Property

    Public ReadOnly Property Connection_DB() As SqlClient.SqlConnection
        Get
            Return objConnection_DB
        End Get
    End Property

    Public ReadOnly Property Connection_Plugin() As SqlClient.SqlConnection
        Get
            Return objConnection_Plugin
        End Get
    End Property

    Public ReadOnly Property Globals() As clsGlobals
        Get
            Return objGlobals
        End Get
    End Property

    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals
        objConnection_DB = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        objConnection_Config = New SqlClient.SqlConnection(objGlobals.ConnectionString_System)

        objGUID_Development = New Guid(cstr_GUIDToken_Development)
        objSemItem_Development = New clsSemItem
        objSemItem_Development.GUID = objGUID_Development

        set_DBConnection()
        get_Config()
    End Sub

    Private Sub set_DBConnection()
        funcA_SoftwareDevelopment_Config.Connection = objConnection_Config

        procA_TokenAttribute_Varchar255.Connection = objConnection_Config

        procA_OR_Attribute_By_GUIDObjectReference.Connection = objConnection_Config
        procA_OR_RelationType_By_GUIDObjectReference.Connection = objConnection_Config
        procA_OR_Token_By_GUID.Connection = objConnection_Config
        procA_OR_Type_By_GUID.Connection = objConnection_Config
    End Sub

    Private Sub get_Config()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection
        funcA_SoftwareDevelopment_Config.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_Config, objGUID_Development)

        get_Config_Attributes()
        get_Config_RelationTypes()
        get_Config_Types()
        get_Config_Token()

    End Sub

    Private Sub get_Config_Attributes()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection


    End Sub

    Private Sub get_Config_RelationTypes()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objSemItem_RelationType_belonging_Source = New clsSemItem
        objSemItem_RelationType_belonging_Source.GUID = New Guid("d34d545e-9ddf-46ce-bb6f-22db1b7bb025")
        objSemItem_RelationType_belonging_Source.Name = "belonging Source"
        objSemItem_RelationType_belonging_Source.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

        objSemItem_RelationType_belonging_resource = New clsSemItem
        objSemItem_RelationType_belonging_resource.GUID = New Guid("a80b1064-649b-4510-980e-c28be335956c")
        objSemItem_RelationType_belonging_resource.Name = "belonging Resources"
        objSemItem_RelationType_belonging_resource.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

        objSemItem_RelationType_belongs_to = New clsSemItem
        objSemItem_RelationType_belongs_to.GUID = New Guid("e07469d9-766c-443e-8526-6d9c684f944f")
        objSemItem_RelationType_belongs_to.Name = "belongs to"
        objSemItem_RelationType_belongs_to.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

        objSemItem_RelationType_ColConfig = New clsSemItem
        objSemItem_RelationType_ColConfig.GUID = New Guid("e6fa577e-ad2f-4c34-b314-061f5fa6c894")
        objSemItem_RelationType_ColConfig.Name = "Col-Config"
        objSemItem_RelationType_ColConfig.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID


        objSemItem_RelationType_RowConfig = New clsSemItem
        objSemItem_RelationType_RowConfig.GUID = New Guid("66857dba-efd6-48c9-ad54-04103f56ab8a")
        objSemItem_RelationType_RowConfig.Name = "Row-Config"
        objSemItem_RelationType_RowConfig.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

        objSemItem_RelationType_isOfType = New clsSemItem
        objSemItem_RelationType_isOfType.GUID = New Guid("9996494a-ef6a-4357-a6ef-71a92b5ff596")
        objSemItem_RelationType_isOfType.Name = "is of Type"
        objSemItem_RelationType_isOfType.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

    End Sub

    Private Sub get_Config_Token()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objConnection_Plugin = New SqlClient.SqlConnection(objGlobals.get_DB_ConnectionString("ElasticSearch_Connector_Module"))

        objSemItem_BaseConfig = New clsSemItem
        objSemItem_BaseConfig.GUID = New Guid("236b0653-6d4a-4d6f-bf2e-580f7ea780ca")
        objSemItem_BaseConfig.Name = "BaseConfig"
        objSemItem_BaseConfig.GUID_Parent = objSemItem_Type_ElasticSearchConnectorModule.GUID
        objSemItem_BaseConfig.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

    End Sub

    Private Sub get_Config_Types()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objSemItem_Type_ServerPort = New clsSemItem
        objSemItem_Type_ServerPort.GUID = New Guid("9ba24283-a0ad-4717-be30-6f0f3818c36c")
        objSemItem_Type_ServerPort.Name = "Server:Port"
        objSemItem_Type_ServerPort.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_Server = New clsSemItem
        objSemItem_Type_Server.GUID = New Guid("d7a03a35-8751-42b4-8e05-19fc7a77ee91")
        objSemItem_Type_Server.Name = "Server"
        objSemItem_Type_Server.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_Port = New clsSemItem
        objSemItem_Type_Port.GUID = New Guid("ca4eff30-a40b-476d-9906-9f56a67c8cf9")
        objSemItem_Type_Port.Name = "Port"
        objSemItem_Type_Port.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_ElasticSearchConnectorModule = New clsSemItem
        objSemItem_Type_ElasticSearchConnectorModule.GUID = New Guid("74303821-1abf-4e60-b119-0e6c7fffbe2d")
        objSemItem_Type_ElasticSearchConnectorModule.Name = "ElasticSearch-Connector-Module"
        objSemItem_Type_ElasticSearchConnectorModule.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_ElasticSearch = New clsSemItem
        objSemItem_Type_ElasticSearch.GUID = New Guid("d79c764d-e946-454c-8e91-054ca1471cf2")
        objSemItem_Type_ElasticSearch.Name = "ElasticSearch"
        objSemItem_Type_ElasticSearch.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_Indexes_ElasticSearch = New clsSemItem
        objSemItem_Type_Indexes_ElasticSearch.GUID = New Guid("1233afbe-60bf-40e7-9228-64ca4013b75c")
        objSemItem_Type_Indexes_ElasticSearch.Name = "Indexes (Elastic-Search)"
        objSemItem_Type_Indexes_ElasticSearch.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_XMLImport = New clsSemItem
        objSemItem_Type_XMLImport.GUID = New Guid("52b61535-d619-4db8-a3ea-fb77b864dc55")
        objSemItem_Type_XMLImport.Name = "XML-Import"
        objSemItem_Type_XMLImport.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_Url = New clsSemItem
        objSemItem_Type_Url.GUID = New Guid("094d728d-6efc-463c-85c7-2dcfed903c78")
        objSemItem_Type_Url.Name = "Url"
        objSemItem_Type_Url.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_XMLNode = New clsSemItem
        objSemItem_Type_XMLNode.GUID = New Guid("48d76692-2ee7-4b34-b3bf-4a8116a50d0d")
        objSemItem_Type_XMLNode.Name = "XML-Nodes"
        objSemItem_Type_XMLNode.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_FieldType = New clsSemItem
        objSemItem_Type_FieldType.GUID = New Guid("a534dc0a-e3c8-4e05-9f86-faaec798f9cc")
        objSemItem_Type_FieldType.Name = "Field-Type"
        objSemItem_Type_FieldType.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_Types_Elastic_Search = New clsSemItem
        objSemItem_Type_Types_Elastic_Search.GUID = New Guid("d9775bda-1526-475b-8e16-723881828876")
        objSemItem_Type_Types_Elastic_Search.Name = "Types (Elastic Search)"
        objSemItem_Type_Types_Elastic_Search.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

    End Sub
End Class


