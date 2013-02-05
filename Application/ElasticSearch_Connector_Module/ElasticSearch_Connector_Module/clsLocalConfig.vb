Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "5afa8b15-09ae-487c-a02d-4ff3e9ac88c4"

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection

    Private dtblT_Config As New DataSet_ElasticSearchConnector.dtbl_BaseConfigDataTable

    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter

    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter


    Private objSemItem_User As New clsSemItem

    Private objGUID_Development As Guid
    Private objSemItem_Development As clsSemItem

    'Attributes
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_XML_Text As New clsSemItem
    Private objSemItem_Attribute_Header As New clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_Row_Config As New clsSemItem
    Private objSemItem_RelationType_is_of_Type As New clsSemItem
    Private objSemItem_RelationType_Col_Config As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_belonging_Source As New clsSemItem
    Private objSemItem_RelationType_belonging_Resources As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem
    Private objSemItem_RelationType_Textqualifier As New clsSemItem
    Private objSemItem_RelationType_Seperator As New clsSemItem
    Private objSemItem_RelationType_Contains As New clsSemItem
    Private objSemItem_RelationType_exportTo As New clsSemItem
    
    'Types
    Private objSemItem_Type_XML_Nodes As New clsSemItem
    Private objSemItem_Type_XML_Import As New clsSemItem
    Private objSemItem_Type_Url As New clsSemItem
    Private objSemItem_Type_Types__Elastic_Search_ As New clsSemItem
    Private objSemItem_Type_Server_Port As New clsSemItem
    Private objSemItem_Type_Server As New clsSemItem
    Private objSemItem_Type_Port As New clsSemItem
    Private objSemItem_Type_Indexes__Elastic_Search_ As New clsSemItem
    Private objSemItem_Type_Field As New clsSemItem
    Private objSemItem_Type_Field_Type As New clsSemItem
    Private objSemItem_Type_ElasticSearch_Connector_Module As New clsSemItem
    Private objSemItem_Type_ElasticSearch As New clsSemItem
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_CSVImport As New clsSemItem
    Private objSemItem_Type_Zeichen As New clsSemItem
    Private objSemItem_Type_File As New clsSemItem

    'Token
    Private objSemItem_Token_KindOfOntology_RelationType As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Object_Ontology As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Object As New clsSemItem
    Private objSemItem_Token_KindOfOntology_KindOfOntology As New clsSemItem
    Private objSemItem_Token_KindOfOntology_DataType As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Class_Relation As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Class_Ontology As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Class_Attribute As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Class As New clsSemItem
    Private objSemItem_Token_KindOfOntology_AttributeInstance As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Attribute As New clsSemItem
    Private objSemItem_Token_Types__Elastic_Search__ontologydb As New clsSemItem
    Private objSemItem_Token_XML_ES_Bulk_Document As New clsSemItem
    Private objSemItem_Token_Variable_TYPE As New clsSemItem
    Private objSemItem_Token_Variable_INDEX As New clsSemItem
    Private objSemItem_Token_Variable_ID As New clsSemItem
    Private objSemItem_Token_XML_ES_Bulk_Attribute As New clsSemItem
    Private objSemItem_Token_Variable_VALUE As New clsSemItem
    Private objSemItem_Token_Variable_FIELD As New clsSemItem


    Private objSemItem_BaseConfig As clsSemItem

    'Attributes
    Public ReadOnly Property SemItem_attribute_dbPostfix() As clsSemItem
        Get
            Return objSemItem_attribute_dbPostfix
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_XML_Text() As clsSemItem
        Get
            Return objSemItem_Attribute_XML_Text
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Header() As clsSemItem
        Get
            Return objSemItem_Attribute_Header
        End Get
    End Property
    


    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_Row_Config() As clsSemItem
        Get
            Return objSemItem_RelationType_Row_Config
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is_of_Type() As clsSemItem
        Get
            Return objSemItem_RelationType_is_of_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Col_Config() As clsSemItem
        Get
            Return objSemItem_RelationType_Col_Config
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Source() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Source
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Resources() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Resources
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Textqualifier() As clsSemItem
        Get
            Return objSemItem_RelationType_Textqualifier
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Seperator() As clsSemItem
        Get
            Return objSemItem_RelationType_Seperator
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_contains() As clsSemItem
        Get
            Return objSemItem_RelationType_Contains
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_exportTo() As clsSemItem
        Get
            Return objSemItem_RelationType_exportTo
        End Get
    End Property



    'Types
    Public ReadOnly Property SemItem_Type_XML_Nodes() As clsSemItem
        Get
            Return objSemItem_Type_XML_Nodes
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_XML_Import() As clsSemItem
        Get
            Return objSemItem_Type_XML_Import
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Url() As clsSemItem
        Get
            Return objSemItem_Type_Url
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Types__Elastic_Search_() As clsSemItem
        Get
            Return objSemItem_Type_Types__Elastic_Search_
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Server_Port() As clsSemItem
        Get
            Return objSemItem_Type_Server_Port
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Server() As clsSemItem
        Get
            Return objSemItem_Type_Server
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Port() As clsSemItem
        Get
            Return objSemItem_Type_Port
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Indexes__Elastic_Search_() As clsSemItem
        Get
            Return objSemItem_Type_Indexes__Elastic_Search_
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Field_Type() As clsSemItem
        Get
            Return objSemItem_Type_Field_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_ElasticSearch_Connector_Module() As clsSemItem
        Get
            Return objSemItem_Type_ElasticSearch_Connector_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_ElasticSearch() As clsSemItem
        Get
            Return objSemItem_Type_ElasticSearch
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_CSVImport() As clsSemItem
        Get
            Return objSemItem_Type_CSVImport
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Zeichen() As clsSemItem
        Get
            Return objSemItem_Type_Zeichen
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_File() As clsSemItem
        Get
            Return objSemItem_Type_File
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Field() As clsSemItem
        Get
            Return objSemItem_Type_Field
        End Get
    End Property



    'Token
    Public ReadOnly Property SemItem_Token_KindOfOntology_RelationType() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_RelationType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Object_Ontology() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Object_Ontology
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Object() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Object
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_KindOfOntology() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_KindOfOntology
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_DataType() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_DataType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Class_Relation() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Class_Relation
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Class_Ontology() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Class_Ontology
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Class_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Class_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Class() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Class
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_AttributeInstance() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_AttributeInstance
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Types__Elastic_Search__ontologydb() As clsSemItem
        Get
            Return objSemItem_Token_Types__Elastic_Search__ontologydb
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_ES_Bulk_Document() As clsSemItem
        Get
            Return objSemItem_Token_XML_ES_Bulk_Document
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_TYPE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_TYPE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_INDEX() As clsSemItem
        Get
            Return objSemItem_Token_Variable_INDEX
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ID() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ID
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_ES_Bulk_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_XML_ES_Bulk_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VALUE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VALUE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_FIELD() As clsSemItem
        Get
            Return objSemItem_Token_Variable_FIELD
        End Get
    End Property


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
        funcA_TokenToken.Connection = objConnection_Config

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

        objSemItem_Attribute_Header.GUID = New Guid("5e0c66db-0992-4c92-9dbb-0568e58250f9")
        objSemItem_Attribute_Header.Name = "Header"
        objSemItem_Attribute_Header.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID


        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='attribute_dbPostfix'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_attribute_dbPostfix.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_attribute_dbPostfix.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_attribute_dbPostfix.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_attribute_dbPostfix.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID

                objDRC_RelData = procA_TokenAttribute_Varchar255.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_Development.GUID, objSemItem_attribute_dbPostfix.GUID).Rows

                objConnection_Plugin = New SqlClient.SqlConnection(objGlobals.get_DB_ConnectionString(objDRC_RelData(0).Item("Val")))
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_XML_Text'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_XML_Text.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_XML_Text.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_XML_Text.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_XML_Text.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub

    Private Sub get_Config_RelationTypes()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objSemItem_RelationType_Textqualifier.GUID = New Guid("82047cba-f63a-429f-a61b-33b622a9826e")
        objSemItem_RelationType_Textqualifier.Name = "Textqualifier"
        objSemItem_RelationType_Textqualifier.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

        objSemItem_RelationType_Seperator.GUID = New Guid("6b106ab9-7e68-44f1-8a75-4612e021d7ab")
        objSemItem_RelationType_Seperator.Name = "Seperator"
        objSemItem_RelationType_Seperator.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

        objSemItem_RelationType_Contains.GUID = New Guid("e9711603-47db-44d8-a476-fe88290639a4")
        objSemItem_RelationType_Contains.Name = "contains"
        objSemItem_RelationType_Contains.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

        objSemItem_RelationType_exportTo.GUID = New Guid("aaf3e012-a822-4ba6-9d9d-d5bb35821757")
        objSemItem_RelationType_exportTo.Name = "export to"
        objSemItem_RelationType_exportTo.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Row_Config'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Row_Config.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Row_Config.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Row_Config.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_is_of_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_is_of_Type.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_is_of_Type.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_is_of_Type.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Col_Config'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Col_Config.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Col_Config.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Col_Config.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belongsTo'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belongsTo.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belongsTo.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belongsTo.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Source'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Source.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Source.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Source.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Resources'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Resources.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Resources.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Resources.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_offered_by'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_offered_by.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_offered_by.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_offered_by.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub

    Private Sub get_Config_Token()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection



        objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objGUID_Development, _
                                                                   objSemItem_RelationType_offered_by.GUID, _
                                                                   objSemItem_Type_Module.GUID).Rows
        If objDRC_Ref.Count > 0 Then
            objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objDRC_Ref(0).Item("GUID_Token_Left"), _
                                                                       objSemItem_RelationType_belongsTo.GUID, _
                                                                       objSemItem_Type_ElasticSearch_Connector_Module.GUID).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_BaseConfig = New clsSemItem
                objSemItem_BaseConfig.GUID = objDRC_Ref(0).Item("GUID_Token_Left")
                objSemItem_BaseConfig.Name = objDRC_Ref(0).Item("Name_Token_Left")
                objSemItem_BaseConfig.GUID_Parent = objSemItem_Type_ElasticSearch_Connector_Module.GUID
                objSemItem_BaseConfig.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If
        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_KindOfOntology_RelationType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_KindOfOntology_RelationType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_KindOfOntology_RelationType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_KindOfOntology_RelationType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_KindOfOntology_RelationType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_KindOfOntology_Object_Ontology'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_KindOfOntology_Object_Ontology.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_KindOfOntology_Object_Ontology.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_KindOfOntology_Object_Ontology.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_KindOfOntology_Object_Ontology.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_KindOfOntology_Object'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_KindOfOntology_Object.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_KindOfOntology_Object.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_KindOfOntology_Object.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_KindOfOntology_Object.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_KindOfOntology_KindOfOntology'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_KindOfOntology_KindOfOntology.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_KindOfOntology_KindOfOntology.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_KindOfOntology_KindOfOntology.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_KindOfOntology_KindOfOntology.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_KindOfOntology_DataType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_KindOfOntology_DataType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_KindOfOntology_DataType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_KindOfOntology_DataType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_KindOfOntology_DataType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_KindOfOntology_Class_Relation'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_KindOfOntology_Class_Relation.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_KindOfOntology_Class_Relation.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_KindOfOntology_Class_Relation.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_KindOfOntology_Class_Relation.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_KindOfOntology_Class_Ontology'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_KindOfOntology_Class_Ontology.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_KindOfOntology_Class_Ontology.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_KindOfOntology_Class_Ontology.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_KindOfOntology_Class_Ontology.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_KindOfOntology_Class_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_KindOfOntology_Class_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_KindOfOntology_Class_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_KindOfOntology_Class_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_KindOfOntology_Class_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_KindOfOntology_Class'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_KindOfOntology_Class.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_KindOfOntology_Class.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_KindOfOntology_Class.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_KindOfOntology_Class.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_KindOfOntology_AttributeInstance'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_KindOfOntology_AttributeInstance.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_KindOfOntology_AttributeInstance.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_KindOfOntology_AttributeInstance.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_KindOfOntology_AttributeInstance.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_KindOfOntology_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_KindOfOntology_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_KindOfOntology_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_KindOfOntology_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_KindOfOntology_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Types__Elastic_Search__ontologydb'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Types__Elastic_Search__ontologydb.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Types__Elastic_Search__ontologydb.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Types__Elastic_Search__ontologydb.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Types__Elastic_Search__ontologydb.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_ES_Bulk_Document'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_ES_Bulk_Document.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_ES_Bulk_Document.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_ES_Bulk_Document.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_ES_Bulk_Document.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_TYPE'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_TYPE.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_TYPE.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_TYPE.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_TYPE.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_INDEX'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_INDEX.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_INDEX.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_INDEX.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_INDEX.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ID'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ID.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ID.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ID.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ID.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_ES_Bulk_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_ES_Bulk_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_ES_Bulk_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_ES_Bulk_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_ES_Bulk_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VALUE'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VALUE.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VALUE.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VALUE.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VALUE.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_FIELD'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_FIELD.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_FIELD.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_FIELD.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_FIELD.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub

    Private Sub get_Config_Types()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objSemItem_Type_CSVImport.GUID = New Guid("2bf81077-b8c9-4e0e-99bf-b8329ed8bf25")
        objSemItem_Type_CSVImport.Name = "CSV-Import"
        objSemItem_Type_CSVImport.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_Zeichen.GUID = New Guid("c8e580ed-be06-49a2-8ee8-17e8e0160393")
        objSemItem_Type_Zeichen.Name = "Zeichen"
        objSemItem_Type_Zeichen.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_File.GUID = New Guid("6eb4fdd3-2e25-4886-b288-e1bfc2857efb")
        objSemItem_Type_File.Name = "File"
        objSemItem_Type_File.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objSemItem_Type_Field.GUID = New Guid("e1be73cd-0deb-41a0-a222-b779e7862412")
        objSemItem_Type_Field.Name = "Fields"
        objSemItem_Type_Field.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_XML_Nodes'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_XML_Nodes.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_XML_Nodes.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_XML_Nodes.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_XML_Nodes.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_XML_Import'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_XML_Import.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_XML_Import.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_XML_Import.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_XML_Import.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Url'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Url.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Url.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Url.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Url.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Types__Elastic_Search_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Types__Elastic_Search_.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Types__Elastic_Search_.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Types__Elastic_Search_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Types__Elastic_Search_.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Server_Port'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Server_Port.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Server_Port.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Server_Port.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Server_Port.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Server'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Server.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Server.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Server.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Server.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Port'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Port.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Port.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Port.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Port.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Indexes__Elastic_Search_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Indexes__Elastic_Search_.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Indexes__Elastic_Search_.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Indexes__Elastic_Search_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Indexes__Elastic_Search_.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Field_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Field_Type.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Field_Type.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Field_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Field_Type.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_ElasticSearch_Connector_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_ElasticSearch_Connector_Module.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_ElasticSearch_Connector_Module.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_ElasticSearch_Connector_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_ElasticSearch_Connector_Module.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_ElasticSearch'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_ElasticSearch.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_ElasticSearch.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_ElasticSearch.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_ElasticSearch.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Module.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Module.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Module.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub

    
End Class


