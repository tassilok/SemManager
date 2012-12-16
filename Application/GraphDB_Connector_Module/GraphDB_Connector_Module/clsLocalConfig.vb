Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "86b3478c-2676-44ee-914e-64f9edd794a2"

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcT_CodeSnipplets As New ds_Token.func_TokenTokenDataTable
    Private funcT_DataTypes As New ds_Token.func_TokenTokenDataTable
    Private func_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter


    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter

    Private dtblT_Views As New DataSet_CouchDB.dtbl_ViewsDataTable
    Private dtblT_ItemsWithRestCode As New DataSet_CouchDB.dtbl_ItemWithRestCodeDataTable

    Private objGUID_Development As Guid
    Private objSemItem_Development As New clsSemItem
    Private objSemItem_BaseConfig As clsSemItem

    'Attributes
    Private objSemItem_Attribute_Code As New clsSemItem
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_SingleDB_Instance As New clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_contains As New clsSemItem
    Private objSemItem_RelationType_JSON As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_is_of_Type As New clsSemItem
    Private objSemItem_RelationType_belonging_Source As New clsSemItem
    Private objSemItem_RelationType_belonging_DB As New clsSemItem
    Private objSemItem_RelationType_Create_Node_Relationship As New clsSemItem
    Private objSemItem_RelationType_belonging_Resources As New clsSemItem

    'Token
    Private objSemItem_Token_KindOfOntology_Attribute As New clsSemItem
    Private objSemItem_Token_KindOfOntology_AttributeInstance As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Class As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Class_Attribute As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Class_Relation As New clsSemItem
    Private objSemItem_Token_KindOfOntology_DataType As New clsSemItem
    Private objSemItem_Token_KindOfOntology_KindOfOntology As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Object As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Object_Ontology As New clsSemItem
    Private objSemItem_Token_KindOfOntology_RelationType As New clsSemItem
    Private objSemItem_Token_KindOfOntology_Class_Ontology As New clsSemItem
    Private objSemItem_Token_KindOfOntology_designDocs As New clsSemItem
    Private objSemItem_Token_Code_Snipplet_No_DB As New clsSemItem

    Private objSemItem_Token_Variable_WEIGHT As New clsSemItem
    Private objSemItem_Token_Variable_VAL_YEAR As New clsSemItem
    Private objSemItem_Token_Variable_VAL_STRING As New clsSemItem
    Private objSemItem_Token_Variable_VAL_SECOND As New clsSemItem
    Private objSemItem_Token_Variable_VAL_NUMBER As New clsSemItem
    Private objSemItem_Token_Variable_VAL_NANOSECOND As New clsSemItem
    Private objSemItem_Token_Variable_VAL_MONTH As New clsSemItem
    Private objSemItem_Token_Variable_VAL_MINUTE As New clsSemItem
    Private objSemItem_Token_Variable_VAL_MILLISECOND As New clsSemItem
    Private objSemItem_Token_Variable_VAL_MICROSECOND As New clsSemItem
    Private objSemItem_Token_Variable_VAL_HOUR As New clsSemItem
    Private objSemItem_Token_Variable_VAL_DAY As New clsSemItem
    Private objSemItem_Token_Variable_VAL_BIT As New clsSemItem
    Private objSemItem_Token_Variable_NAME As New clsSemItem
    Private objSemItem_Token_Variable_MIN_LEFTRIGHT As New clsSemItem
    Private objSemItem_Token_Variable_MAX_RIGHTLEFT As New clsSemItem
    Private objSemItem_Token_Variable_MAX_LEFTRIGHT As New clsSemItem
    Private objSemItem_Token_Variable_ID_TYPE As New clsSemItem
    Private objSemItem_Token_Variable_ID_RELATIONTYPE As New clsSemItem
    Private objSemItem_Token_Variable_ID_PARENT As New clsSemItem
    Private objSemItem_Token_Variable_ID_ONTOLOGY As New clsSemItem
    Private objSemItem_Token_Variable_ID_OBJECT As New clsSemItem
    Private objSemItem_Token_Variable_ID_DATATYPE As New clsSemItem
    Private objSemItem_Token_Variable_ID_CLASS_RIGHT As New clsSemItem
    Private objSemItem_Token_Variable_ID_CLASS_LEFT As New clsSemItem
    Private objSemItem_Token_Variable_ID_CLASS As New clsSemItem
    Private objSemItem_Token_Variable_ID_ATTRIBUTE As New clsSemItem
    Private objSemItem_Token_Variable_id As New clsSemItem
    Private objSemItem_Token_Variable_NAMESPACE As New clsSemItem
    Private objSemItem_Token_Variable_VIEWS As New clsSemItem
    Private objSemItem_Token_Variable_CODE As New clsSemItem
    Private objSemItem_Token_Variable_ID_TYPE_RIGHT As New clsSemItem

    'Types
    Private objSemItem_Type_Code_Snipplet As New clsSemItem
    Private objSemItem_Type_KindOfOntology As New clsSemItem
    Private objSemItem_Type_Variable As New clsSemItem
    Private objSemItem_Type_Url As New clsSemItem
    Private objSemItem_Type_CouchDB_Connector_Module As New clsSemItem
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_Ontology_Item As New clsSemItem
    Private objSemItem_Type_GraphDB As New clsSemItem
    Private objSemItem_type_ProgramingLanguage As New clsSemItem
    Private objSemItem_Type_Web_Methods As New clsSemItem


    Private strErrNoDB As String

    Private objSemItems_Views() As clsSemItem

    'Attributes
    Public ReadOnly Property SemItem_Attribute_Code() As clsSemItem
        Get
            Return objSemItem_Attribute_Code
        End Get
    End Property

    Public ReadOnly Property SemItem_attribute_dbPostfix() As clsSemItem
        Get
            Return objSemItem_attribute_dbPostfix
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_SingleDB_Instance() As clsSemItem
        Get
            Return objSemItem_Attribute_SingleDB_Instance
        End Get
    End Property



    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_contains() As clsSemItem
        Get
            Return objSemItem_RelationType_contains
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_JSON() As clsSemItem
        Get
            Return objSemItem_RelationType_JSON
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_DB() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_DB
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Create_Node_Relationship() As clsSemItem
        Get
            Return objSemItem_RelationType_Create_Node_Relationship
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Resources() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Resources
        End Get
    End Property


    'Token
    Public ReadOnly Property SemItem_Token_KindOfOntology_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_AttributeInstance() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_AttributeInstance
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Class() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Class
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Class_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Class_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Class_Relation() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Class_Relation
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_DataType() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_DataType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_KindOfOntology() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_KindOfOntology
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Object() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Object
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Object_Ontology() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Object_Ontology
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_RelationType() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_RelationType
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Source() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Source
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Code_Snipplet_No_DB() As clsSemItem
        Get
            Return objSemItem_Token_Code_Snipplet_No_DB
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is_of_Type() As clsSemItem
        Get
            Return objSemItem_RelationType_is_of_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_WEIGHT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_WEIGHT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VAL_YEAR() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VAL_YEAR
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VAL_STRING() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VAL_STRING
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VAL_SECOND() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VAL_SECOND
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VAL_NUMBER() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VAL_NUMBER
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VAL_NANOSECOND() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VAL_NANOSECOND
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VAL_MONTH() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VAL_MONTH
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VAL_MINUTE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VAL_MINUTE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VAL_MILLISECOND() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VAL_MILLISECOND
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VAL_MICROSECOND() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VAL_MICROSECOND
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VAL_HOUR() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VAL_HOUR
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VAL_DAY() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VAL_DAY
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VAL_BIT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VAL_BIT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_NAME() As clsSemItem
        Get
            Return objSemItem_Token_Variable_NAME
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_MIN_LEFTRIGHT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_MIN_LEFTRIGHT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_MAX_RIGHTLEFT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_MAX_RIGHTLEFT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_MAX_LEFTRIGHT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_MAX_LEFTRIGHT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ID_TYPE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ID_TYPE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ID_RELATIONTYPE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ID_RELATIONTYPE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ID_PARENT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ID_PARENT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ID_ONTOLOGY() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ID_ONTOLOGY
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ID_OBJECT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ID_OBJECT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ID_DATATYPE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ID_DATATYPE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ID_CLASS_RIGHT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ID_CLASS_RIGHT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ID_CLASS_LEFT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ID_CLASS_LEFT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ID_CLASS() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ID_CLASS
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ID_ATTRIBUTE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ID_ATTRIBUTE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_id() As clsSemItem
        Get
            Return objSemItem_Token_Variable_id
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_Class_Ontology() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_Class_Ontology
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_CODE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_CODE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_KindOfOntology_map_view() As clsSemItem
        Get
            Return objSemItem_Token_KindOfOntology_designDocs
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_NAMESPACE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_NAMESPACE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_VIEWS() As clsSemItem
        Get
            Return objSemItem_Token_Variable_VIEWS
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ID_TYPE_RIGHT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ID_TYPE_RIGHT
        End Get
    End Property


    'Types
    Public ReadOnly Property SemItem_Type_Code_Snipplet() As clsSemItem
        Get
            Return objSemItem_Type_Code_Snipplet
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_KindOfOntology() As clsSemItem
        Get
            Return objSemItem_Type_KindOfOntology
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Variable() As clsSemItem
        Get
            Return objSemItem_Type_Variable
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Url() As clsSemItem
        Get
            Return objSemItem_Type_Url
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_CouchDB_Connector_Module() As clsSemItem
        Get
            Return objSemItem_Type_CouchDB_Connector_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Ontology_Item() As clsSemItem
        Get
            Return objSemItem_Type_Ontology_Item
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_GraphDB() As clsSemItem
        Get
            Return objSemItem_Type_GraphDB
        End Get
    End Property

    Public ReadOnly Property SemItem_type_ProgramingLanguage() As clsSemItem
        Get
            Return objSemItem_type_ProgramingLanguage
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Web_Methods() As clsSemItem
        Get
            Return objSemItem_Type_Web_Methods
        End Get
    End Property


    Public ReadOnly Property BaseConfig As clsSemItem
        Get
            Return objSemItem_BaseConfig
        End Get
    End Property

    Public ReadOnly Property Err_NoDB As String
        Get
            Return strErrNoDB
        End Get
    End Property

    Public ReadOnly Property tbl_DataTypes As ds_Token.func_TokenTokenDataTable
        Get
            Return funcT_DataTypes
        End Get
    End Property

    Public ReadOnly Property tbl_DesignDocs As DataSet_CouchDB.dtbl_ViewsDataTable
        Get
            Return dtblT_Views
        End Get
    End Property

    Public ReadOnly Property tbl_ItemsWithRest As DataSet_CouchDB.dtbl_ItemWithRestCodeDataTable
        Get
            Return dtblT_ItemsWithRestCode
        End Get
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

        funcA_TokenToken.Connection = objConnection_Config
        func_TokenAttribute_Named_By_GUIDToken.Connection = objConnection_Config
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Code'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Code.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Code.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Code.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Code.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID

                
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_SingleDB_Instance'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_SingleDB_Instance.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_SingleDB_Instance.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_SingleDB_Instance.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_SingleDB_Instance.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_contains'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_contains.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_contains.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_contains.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_JSON'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_JSON.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_JSON.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_JSON.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Create_Node_Relationship'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Create_Node_Relationship.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Create_Node_Relationship.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Create_Node_Relationship.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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
    End Sub

    Private Sub get_Config_Token()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

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

        objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Development.GUID, _
                                                                   SemItem_RelationType_offered_by.GUID, _
                                                                   objSemItem_Type_Module.GUID).Rows
        If objDRC_Ref.Count > 0 Then
            objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objDRC_Ref(0).Item("GUID_Token_Left"), _
                                                                       objSemItem_RelationType_belongsTo.GUID, _
                                                                       objSemItem_Type_CouchDB_Connector_Module.GUID).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_BaseConfig = New clsSemItem
                objSemItem_BaseConfig.GUID = objDRC_Ref(0).Item("GUID_Token_Left")
                objSemItem_BaseConfig.Name = objDRC_Ref(0).Item("Name_Token_left")
                objSemItem_BaseConfig.GUID_Parent = objSemItem_Type_CouchDB_Connector_Module.GUID
                objSemItem_BaseConfig.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If
        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Code_Snipplet_No_DB'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Code_Snipplet_No_DB.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Code_Snipplet_No_DB.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Code_Snipplet_No_DB.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Code_Snipplet_No_DB.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRC_Ref = func_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Token_Code_Snipplet_No_DB.GUID, _
                                                                                                   objSemItem_Attribute_Code.GUID).Rows
        If objDRC_Ref.Count > 0 Then
            strErrNoDB = objDRC_Ref(0).Item("Val_VARCHARMAX")
        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_WEIGHT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_WEIGHT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_WEIGHT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_WEIGHT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_WEIGHT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VAL_YEAR'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VAL_YEAR.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VAL_YEAR.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VAL_YEAR.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VAL_YEAR.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VAL_STRING'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VAL_STRING.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VAL_STRING.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VAL_STRING.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VAL_STRING.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VAL_SECOND'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VAL_SECOND.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VAL_SECOND.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VAL_SECOND.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VAL_SECOND.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VAL_NUMBER'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VAL_NUMBER.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VAL_NUMBER.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VAL_NUMBER.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VAL_NUMBER.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VAL_NANOSECOND'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VAL_NANOSECOND.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VAL_NANOSECOND.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VAL_NANOSECOND.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VAL_NANOSECOND.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VAL_MONTH'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VAL_MONTH.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VAL_MONTH.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VAL_MONTH.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VAL_MONTH.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VAL_MINUTE'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VAL_MINUTE.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VAL_MINUTE.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VAL_MINUTE.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VAL_MINUTE.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VAL_MILLISECOND'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VAL_MILLISECOND.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VAL_MILLISECOND.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VAL_MILLISECOND.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VAL_MILLISECOND.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VAL_MICROSECOND'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VAL_MICROSECOND.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VAL_MICROSECOND.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VAL_MICROSECOND.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VAL_MICROSECOND.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VAL_HOUR'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VAL_HOUR.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VAL_HOUR.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VAL_HOUR.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VAL_HOUR.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VAL_DAY'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VAL_DAY.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VAL_DAY.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VAL_DAY.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VAL_DAY.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VAL_BIT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VAL_BIT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VAL_BIT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VAL_BIT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VAL_BIT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_NAME'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_NAME.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_NAME.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_NAME.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_NAME.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_MIN_LEFTRIGHT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_MIN_LEFTRIGHT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_MIN_LEFTRIGHT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_MIN_LEFTRIGHT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_MIN_LEFTRIGHT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_MAX_RIGHTLEFT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_MAX_RIGHTLEFT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_MAX_RIGHTLEFT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_MAX_RIGHTLEFT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_MAX_RIGHTLEFT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_MAX_LEFTRIGHT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_MAX_LEFTRIGHT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_MAX_LEFTRIGHT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_MAX_LEFTRIGHT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_MAX_LEFTRIGHT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ID_TYPE'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ID_TYPE.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ID_TYPE.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ID_TYPE.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ID_TYPE.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ID_RELATIONTYPE'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ID_RELATIONTYPE.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ID_RELATIONTYPE.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ID_RELATIONTYPE.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ID_RELATIONTYPE.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ID_PARENT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ID_PARENT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ID_PARENT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ID_PARENT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ID_PARENT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ID_ONTOLOGY'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ID_ONTOLOGY.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ID_ONTOLOGY.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ID_ONTOLOGY.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ID_ONTOLOGY.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ID_OBJECT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ID_OBJECT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ID_OBJECT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ID_OBJECT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ID_OBJECT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ID_DATATYPE'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ID_DATATYPE.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ID_DATATYPE.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ID_DATATYPE.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ID_DATATYPE.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ID_CLASS_RIGHT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ID_CLASS_RIGHT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ID_CLASS_RIGHT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ID_CLASS_RIGHT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ID_CLASS_RIGHT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ID_CLASS_LEFT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ID_CLASS_LEFT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ID_CLASS_LEFT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ID_CLASS_LEFT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ID_CLASS_LEFT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ID_CLASS'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ID_CLASS.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ID_CLASS.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ID_CLASS.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ID_CLASS.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ID_ATTRIBUTE'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ID_ATTRIBUTE.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ID_ATTRIBUTE.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ID_ATTRIBUTE.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ID_ATTRIBUTE.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_id'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_id.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_id.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_id.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_id.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_CODE'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_CODE.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_CODE.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_CODE.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_CODE.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_KindOfOntology_designDocs'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_KindOfOntology_designDocs.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_KindOfOntology_designDocs.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_KindOfOntology_designDocs.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_KindOfOntology_designDocs.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_NAMESPACE'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_NAMESPACE.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_NAMESPACE.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_NAMESPACE.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_NAMESPACE.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_VIEWS'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_VIEWS.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_VIEWS.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_VIEWS.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_VIEWS.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ID_TYPE_RIGHT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ID_TYPE_RIGHT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ID_TYPE_RIGHT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ID_TYPE_RIGHT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ID_TYPE_RIGHT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        get_Codes()
        get_DataTypes()
        get_DesignDocs()
    End Sub

    Private Sub get_DataTypes()
        funcA_TokenToken.Fill_TokenToken_RightLeft(funcT_DataTypes, _
                                                   objSemItem_Token_KindOfOntology_DataType.GUID, _
                                                   objSemItem_RelationType_is_of_Type.GUID, _
                                                   objSemItem_Type_Ontology_Item.GUID)

    End Sub

    Private Sub get_Codes()
        Dim objDR_Codes As DataRow
        Dim objDRC_Codes As DataRowCollection
        Dim GUID_Item As Guid
        Dim strCode As String

        funcA_TokenToken.ClearBeforeFill = False
        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_CodeSnipplets, _
                                                   objSemItem_Token_KindOfOntology_Attribute.GUID, _
                                                   objSemItem_RelationType_JSON.GUID, _
                                                   objSemItem_Type_Code_Snipplet.GUID)
        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_CodeSnipplets, _
                                                   objSemItem_Token_KindOfOntology_AttributeInstance.GUID, _
                                                   objSemItem_RelationType_JSON.GUID, _
                                                   objSemItem_Type_Code_Snipplet.GUID)
        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_CodeSnipplets, _
                                                   objSemItem_Token_KindOfOntology_Class.GUID, _
                                                   objSemItem_RelationType_JSON.GUID, _
                                                   objSemItem_Type_Code_Snipplet.GUID)
        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_CodeSnipplets, _
                                                   objSemItem_Token_KindOfOntology_Class_Attribute.GUID, _
                                                   objSemItem_RelationType_JSON.GUID, _
                                                   objSemItem_Type_Code_Snipplet.GUID)
        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_CodeSnipplets, _
                                                   objSemItem_Token_KindOfOntology_Class_Relation.GUID, _
                                                   objSemItem_RelationType_JSON.GUID, _
                                                   objSemItem_Type_Code_Snipplet.GUID)
        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_CodeSnipplets, _
                                                   objSemItem_Token_KindOfOntology_DataType.GUID, _
                                                   objSemItem_RelationType_JSON.GUID, _
                                                   objSemItem_Type_Code_Snipplet.GUID)
        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_CodeSnipplets, _
                                                   objSemItem_Token_KindOfOntology_KindOfOntology.GUID, _
                                                   objSemItem_RelationType_JSON.GUID, _
                                                   objSemItem_Type_Code_Snipplet.GUID)
        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_CodeSnipplets, _
                                                   objSemItem_Token_KindOfOntology_Object.GUID, _
                                                   objSemItem_RelationType_JSON.GUID, _
                                                   objSemItem_Type_Code_Snipplet.GUID)
        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_CodeSnipplets, _
                                                   objSemItem_Token_KindOfOntology_designDocs.GUID, _
                                                   objSemItem_RelationType_JSON.GUID, _
                                                   objSemItem_Type_Code_Snipplet.GUID)

        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_CodeSnipplets, _
                                                   objSemItem_Token_KindOfOntology_Object_Ontology.GUID, _
                                                   objSemItem_RelationType_JSON.GUID, _
                                                   objSemItem_Type_Code_Snipplet.GUID)

        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_CodeSnipplets, _
                                                   objSemItem_Token_KindOfOntology_RelationType.GUID, _
                                                   objSemItem_RelationType_JSON.GUID, _
                                                   objSemItem_Type_Code_Snipplet.GUID)

        For Each objDR_Codes In funcT_CodeSnipplets.Rows
            objDRC_Codes = func_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objDR_Codes.Item("GUID_Token_Right"), _
                                                                                                         objSemItem_Attribute_Code.GUID).Rows
            If objDRC_Codes.Count > 0 Then
                GUID_Item = objDR_Codes.Item("GUID_Token_Left")
                strCode = objDRC_Codes(0).Item("VAL_VARCHARMAX")

                objDRC_Codes = funcA_TokenToken.GetData_TokenToken_LeftRight(objDR_Codes.Item("GUID_Token_Right"), _
                                                                             objSemItem_RelationType_is_of_Type.GUID, _
                                                                             objSemItem_type_ProgramingLanguage.GUID).Rows
                If objDRC_Codes.Count > 0 Then
                    dtblT_ItemsWithRestCode.Rows.Add(GUID_Item, _
                                                     objDRC_Codes(0).Item("GUID_Token_Left"), _
                                                     strCode, _
                                                     objDRC_Codes(0).Item("GUID_Token_Right"))

                End If
            End If

        Next


    End Sub

    Private Sub get_DesignDocs()
        Dim objDRC_DesignDocs As DataRowCollection
        Dim strCode_DesignDoc As String
        Dim objDRC_Code As DataRowCollection
        Dim objDRC_View As DataRowCollection
        Dim objDR_View As DataRow
        Dim objDR_DesignDoc As DataRow

        objDRC_DesignDocs = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Token_KindOfOntology_designDocs.GUID, _
                                                                          objSemItem_RelationType_is_of_Type.GUID, _
                                                                          objSemItem_Type_Ontology_Item.GUID).Rows

        For Each objDR_DesignDoc In objDRC_DesignDocs
            objDRC_Code = funcA_TokenToken.GetData_TokenToken_LeftRight(objDR_DesignDoc.Item("GUID_Token_Left"), _
                                                                        objSemItem_RelationType_JSON.GUID, _
                                                                        objSemItem_Type_Code_Snipplet.GUID).Rows
            strCode_DesignDoc = ""
            If objDRC_Code.Count > 0 Then
                objDRC_Code = func_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objDRC_Code(0).Item("GUID_Token_Right"), _
                                                                                                            objSemItem_Attribute_Code.GUID).Rows
                If objDRC_Code.Count > 0 Then
                    strCode_DesignDoc = objDRC_Code(0).Item("VAL_VARCHARMAX")
                End If
            End If

            objDRC_View = funcA_TokenToken.GetData_TokenToken_LeftRight(objDR_DesignDoc.Item("GUID_Token_Left"), _
                                                                        objSemItem_RelationType_contains.GUID, _
                                                                        objSemItem_Type_Ontology_Item.GUID).Rows
            For Each objDR_View In objDRC_View
                objDRC_Code = funcA_TokenToken.GetData_TokenToken_LeftRight(objDR_DesignDoc.Item("GUID_Token_Right"), _
                                                                        objSemItem_RelationType_JSON.GUID, _
                                                                        objSemItem_Type_Code_Snipplet.GUID).Rows
                If objDRC_Code.Count > 0 Then
                    objDRC_Code = func_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objDRC_Code(0).Item("GUID_Token_Right"), _
                                                                                                                objSemItem_Attribute_Code.GUID).Rows
                    If objDRC_Code.Count > 0 Then
                        dtblT_Views.Rows.Add(objDR_DesignDoc.Item("GUID_Token_Left"), _
                                             objDR_DesignDoc.Item("Name_Token_left"), _
                                             strCode_DesignDoc, _
                                             objDR_View.Item("GUID_Token_Right"), _
                                             objDR_View.Item("Name_Token_Right"), _
                                             objDRC_Code(0).Item("VAL_VARCHARMAX"))
                    End If
                End If
            Next
        Next
    End Sub
    Private Sub get_Config_Types()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Code_Snipplet'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Code_Snipplet.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Code_Snipplet.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Code_Snipplet.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Code_Snipplet.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_KindOfOntology'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_KindOfOntology.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_KindOfOntology.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_KindOfOntology.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_KindOfOntology.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Variable'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Variable.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Variable.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Variable.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Variable.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_CouchDB_Connector_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_CouchDB_Connector_Module.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_CouchDB_Connector_Module.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_CouchDB_Connector_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_CouchDB_Connector_Module.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Ontology_Item'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Ontology_Item.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Ontology_Item.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Ontology_Item.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Ontology_Item.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_ProgramingLanguage'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_ProgramingLanguage.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_ProgramingLanguage.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_ProgramingLanguage.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_ProgramingLanguage.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Web_Methods'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Web_Methods.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Web_Methods.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Web_Methods.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Web_Methods.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_GraphDB'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_GraphDB.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_GraphDB.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_GraphDB.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_GraphDB.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub
End Class
