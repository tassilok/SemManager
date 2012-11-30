Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "76913008-42d7-416f-bdc7-39c416df61f4"

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection
    Private objConnection_Plugin_Config As SqlClient.SqlConnection
    Private objConnection_Change As SqlClient.SqlConnection
    Private objConnection_System As SqlClient.SqlConnection

    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter

    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter

    Private procA_LocalizedNames_By_GUIDName As New ds_LocalizeTableAdapters.proc_LocalizedNames_By_GUIDNameTableAdapter
    Private procT_LocalizedNames_By_GUIDName As New ds_Localize.proc_LocalizedNames_By_GUIDNameDataTable

    Private objGUID_Development As Guid

    Private objSemItem_User As clsSemItem

    'Attributes
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_DateTimeStamp As New clsSemItem
    Private objSemItem_Attribute_XML_Text As New clsSemItem
    Private objSemItem_Attribute_Message As New clsSemItem
    Private objSemItem_Attribute_Creation_Level As New clsSemItem
    Private objSemItem_Attribute_Creation_Script As New clsSemItem
    Private objSemItem_Attribute_Revision As New clsSemItem
    Private objSemItem_Attribute_Minor As New clsSemItem
    Private objSemItem_Attribute_Major As New clsSemItem
    Private objSemItem_Attribute_Build As New clsSemItem
    Private objSemItem_Attribute_Value As New clsSemItem
    Private objSemItem_Attribute_Create_Datatypes As New clsSemItem
    Private objSemItem_Attribute_Short As New clsSemItem
    Private objSemItem_Attribute_is_exported As New clsSemItem
    Private objSemItem_Attribute_Create_Object_Reference_Typs As New clsSemItem
    Private objSemItem_Attribute_is_Sem_DB As New clsSemItem
    Private objSemItem_Attribute_Filestreams As New clsSemItem

    'Token
    Private objSemItem_Token_Server_Type_SemDB_Server As New clsSemItem
    Private objSemItem_Token_LogState_Create As New clsSemItem
    Private objSemItem_Token_LogState_Changed As New clsSemItem
    Private objSemItem_Token_LogState_VersionChanged As New clsSemItem
    Private objSemItem_Token_XML_Drop_View As New clsSemItem
    Private objSemItem_Token_XML_Drop_Trigger As New clsSemItem
    Private objSemItem_Token_XML_Drop_Table As New clsSemItem
    Private objSemItem_Token_XML_Drop_Synonym As New clsSemItem
    Private objSemItem_Token_XML_Drop_Procedure As New clsSemItem
    Private objSemItem_Token_XML_Drop_Function As New clsSemItem
    Private objSemItem_Token_XML_TSQL__IF_EXISTS___Table_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL__IF_EXISTS___View_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL__IF_EXISTS___Function_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL__IF_EXISTS___Procedure_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL__IF_EXISTS___Synonym_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL__IF_EXISTS___Trigger_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL__Drop_All_Views_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL__Drop_all_Procedures_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL__Drop_all_Functions_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL__Drop_all_Synonyms_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL__Drop_all_Tables_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL__Drop_all_Triggers_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL__Create_Database_ As New clsSemItem
    Private objSemItem_Token_XML_TSQL_dbg_Attribute As New clsSemItem
    Private objSemItem_Token_Variable_schema_dbo As New clsSemItem
    Private objSemItem_Token_Variable_schema_name As New clsSemItem
    Private objSemItem_Token_Variable_table_name As New clsSemItem
    Private objSemItem_Token_Variable_server_name As New clsSemItem
    Private objSemItem_Token_Variable_db_name_change As New clsSemItem
    Private objSemItem_Token_Variable_synonym_name As New clsSemItem
    Private objSemItem_Token_Variable_db_name As New clsSemItem
    Private objSemItem_Token_Variable_Name_Attribute As New clsSemItem
    Private objSemItem_Token_Variable_GUID_AttributeType As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Attribute As New clsSemItem
    Private objSemItem_Token_XML_SemItem_Insert_Attribute As New clsSemItem
    Private objSemItem_Token_XML_SemItem_Insert_RelationType As New clsSemItem
    Private objSemItem_Token_Variable_GUID_RelationType As New clsSemItem
    Private objSemItem_Token_Variable_Name_RelationType As New clsSemItem
    Private objSemItem_Token_XML_SemItem_Insert_Type As New clsSemItem
    Private objSemItem_Token_Variable_Name_Type As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Type As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Type_Parent As New clsSemItem
    Private objSemItem_Token_XML_SemItem_Insert_Token As New clsSemItem
    Private objSemItem_Token_Variable_Name_Token As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Token As New clsSemItem
    Private objSemItem_Token_XML_SemItem_Insert_Type_NoParent As New clsSemItem
    Private objSemItem_Token_Variable_SemDB As New clsSemItem
    Private objSemItem_Token_Variable_SchemaVersion As New clsSemItem
    Private objSemItem_Token_Wiki_Components_Wiki_Link__intern_ As New clsSemItem
    Private objSemItem_Token_Names_Language_Lbl As New clsSemItem
    Private objSemItem_Token_XML_TSQL_Use_Database As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB__Local_ As New clsSemItem
    Private objSemItem_Token_Variable_isSystemDB As New clsSemItem
    Private objSemItem_Token_Variable_GUID_DB As New clsSemItem
    Private objSemItem_Token_Variable_NAME_DB As New clsSemItem
    Private objSemItem_Token_Variable_NAME_DATATYPE As New clsSemItem
    Private objSemItem_Token_Variable_GUID_DATATYPE As New clsSemItem
    Private objSemItem_Token_XML_TSQL___insert_Datatypes As New clsSemItem
    Private objSemItem_Token_Variable_Value_Property As New clsSemItem
    Private objSemItem_Token_Variable_Name_Property As New clsSemItem
    Private objSemItem_Token_XML_TSQL___addProperty As New clsSemItem
    Private objSemItem_Token_XML_TSQL___insert_Object_Reference_Type As New clsSemItem
    Private objSemItem_Token_Variable_Name_ObjectReferenceType As New clsSemItem
    Private objSemItem_Token_Variable_GUID_ObjectReferenceType As New clsSemItem
    Private objSemItem_Token_XML_TSQL_Insert_TokenAttribute As New clsSemItem
    Private objSemItem_Token_Variable_GUID_TokenAttribute As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR As New clsSemItem
    Private objSemItem_Token_Variable_GUID_ORType As New clsSemItem
    Private objSemItem_Token_Variable_GUID_ObjectReference As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_Type_Attribute As New clsSemItem
    Private objSemItem_Token_Variable_Min As New clsSemItem
    Private objSemItem_Token_Variable_Max As New clsSemItem
    Private objSemItem_Token_Variable_Min_forw As New clsSemItem
    Private objSemItem_Token_Variable_Max_forw As New clsSemItem
    Private objSemItem_Token_Variable_Max_backw As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Type_Right As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Type_Left As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_Type_Type As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_TokenAttribute_Bit As New clsSemItem
    Private objSemItem_Token_Variable_OrderID As New clsSemItem
    Private objSemItem_Token_Variable_val As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_TokenAttribute_Date As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_TokenAttribute_Datetime As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_TokenAttribute_Int As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_TokenAttribute_Real As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_TokenAttribute_time As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_TokenAttribute_Varchar255 As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_TokenAttribute_VarcharMax As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Token_Right As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Token_Left As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_Token_Token As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR_Attribute As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR_RelationType As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Bit As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Date As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Datetime As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Int As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Real As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Time As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHAR255 As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHARMAX As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_Token_OR As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_Type_OR As New clsSemItem
    Private objSemItem_Token_XML_TSQL_insert_semtbl_OR_Type As New clsSemItem
    Private objSemItem_Token_XML_TSQL_dbg_RelationType As New clsSemItem
    Private objSemItem_Token_XML_XML_Template As New clsSemItem
    Private objSemItem_Token_Variable_ParsedName_RelationType As New clsSemItem
    Private objSemItem_Token_Variable_ParsedName_Attribute As New clsSemItem
    Private objSemItem_Token_XML_TSQL_dbg_Type As New clsSemItem
    Private objSemItem_Token_Variable_ParsedName_Type As New clsSemItem
    Private objSemItem_Token_XML_TSQL_CREATE_Function_Token_Of_Type As New clsSemItem
    Private objSemItem_Token_Variable_function_name As New clsSemItem
    Private objSemItem_Token_Variable_view_name As New clsSemItem
    Private objSemItem_Token_Variable_procedure_name As New clsSemItem
    Private objSemItem_Token_Variable_trigger_name As New clsSemItem
    Private objSemItem_Token_XML_TSQL_executesql As New clsSemItem
    Private objSemItem_Token_Variable_tsql_code As New clsSemItem
    Private objSemItem_Token_DB_Schema_Type_User As New clsSemItem
    Private objSemItem_Token_DB_Schema_Type_System As New clsSemItem
    Private objSemItem_Token_DB_Schema_Type_Module As New clsSemItem
    Private objSemItem_Token_DB_Schema_Type_Config As New clsSemItem
    Private objSemItem_Token_DB_Schema_Type_Change As New clsSemItem
    Private objSemItem_Token_XML_TSQL___Func___Token_Of_related_Token As New clsSemItem
    Private objSemItem_Token_Variable_Type_Name_Right As New clsSemItem
    Private objSemItem_Token_Variable_Type_Name_Left As New clsSemItem
    Private objSemItem_Token_Variable_Par_GUID_Type_Right As New clsSemItem
    Private objSemItem_Token_Variable_Name_Row_Right As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Type_Row_Right As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Row_Right As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Row_Left As New clsSemItem
    Private objSemItem_Token_Variable_db_folder_path As New clsSemItem
    Private objSemItem_Token_XML_Create_Database__Filestreams_ As New clsSemItem

    Private objSemItem_Token_Names_Trigger As New clsSemItem
    Private objSemItem_Token_Names_Tabellen As New clsSemItem
    Private objSemItem_Token_Names_Synonyme As New clsSemItem
    Private objSemItem_Token_Names_Skript As New clsSemItem
    Private objSemItem_Token_Names_Semantic_Items As New clsSemItem
    Private objSemItem_Token_Names_Prozeduren As New clsSemItem
    Private objSemItem_Token_Names_Notwendig_f_r As New clsSemItem
    Private objSemItem_Token_Names_Funktionen As New clsSemItem
    Private objSemItem_Token_Names_F_r_das_Datenbankobjekt_notwendig As New clsSemItem
    Private objSemItem_Token_Names_Beschreibung As New clsSemItem
    Private objSemItem_Token_Names_Basisdaten As New clsSemItem
    Private objSemItem_Token_Names_Abh_ngigkeiten As New clsSemItem
    Private objSemItem_Token_Names_Abfragen As New clsSemItem
    Private objSemItem_Token_Names_DBItem_Name As New clsSemItem
    Private objSemItem_Token_Names_DBItem_ChangeDate As New clsSemItem
    Private objSemItem_Token_Names_DBItem_Type As New clsSemItem

    'Types
    Private objSemItem_Type_LogEntry As New clsSemItem
    Private objSemItem_Type_DB_Views As New clsSemItem
    Private objSemItem_Type_DB_Triggers As New clsSemItem
    Private objSemItem_Type_DB_Trigger_Event As New clsSemItem
    Private objSemItem_Type_DB_Tables As New clsSemItem
    Private objSemItem_Type_DB_Synonyms As New clsSemItem
    Private objSemItem_Type_DB_Synonym_Point As New clsSemItem
    Private objSemItem_Type_DB_Synonym___Server As New clsSemItem
    Private objSemItem_Type_DB_Procedure As New clsSemItem
    Private objSemItem_Type_DB_Parameters As New clsSemItem
    Private objSemItem_Type_DB_Function As New clsSemItem
    Private objSemItem_Type_Database_Schema As New clsSemItem
    Private objSemItem_Type_Database As New clsSemItem
    Private objSemItem_Type_Server As New clsSemItem
    Private objSemItem_Type_Database_on_Server As New clsSemItem
    Private objSemItem_type_DevelopmentVersion As New clsSemItem
    Private objSemItem_Type_Functions_in_Schema As New clsSemItem
    Private objSemItem_Type_Views_in_Schema As New clsSemItem
    Private objSemItem_Type_Triggers_in_Schema As New clsSemItem
    Private objSemItem_Type_Tables_in_Schema As New clsSemItem
    Private objSemItem_Type_Synonyms_in_Schemas As New clsSemItem
    Private objSemItem_Type_Procedures_in_Schemas As New clsSemItem
    Private objSemItem_Type_XML As New clsSemItem
    Private objSemItem_Type_Language As New clsSemItem
    Private objSemItem_Type_Creation_Scripts As New clsSemItem
    Private objSemItem_type_User As New clsSemItem
    Private objSemItem_type_Logstate As New clsSemItem
    Private objSemItem_Type_Userschema As New clsSemItem
    Private objSemItem_Type_Database_Schema_on_Server___Creation_Script_Imported As New clsSemItem
    Private objSemItem_Type_Wiki_Documentation__Database_Schema_ As New clsSemItem
    Private objSemItem_Type_WIKI_Implementation As New clsSemItem
    Private objSemItem_Type_Url As New clsSemItem
    Private objSemItem_Type_Wiki_Document As New clsSemItem
    Private objSemItem_Type_Names As New clsSemItem
    Private objSemItem_Type_Localized_Names As New clsSemItem
    Private objSemItem_type_LocalizedDescription As New clsSemItem
    Private objSemItem_Type_File As New clsSemItem
    Private objSemItem_Type_Semantic_Objects_of_DB_Schema As New clsSemItem
    Private objSemItem_Type_DB_Schema_Type As New clsSemItem
    Private objSemItem_Type_Commands As New clsSemItem
    Private objSemItem_Type_Database_for_Synonyms As New clsSemItem
    Private objSemItem_Type_DBServerConfig As New clsSemItem
    Private objSemItem_Type_Path As New clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_is_of_Type As New clsSemItem
    Private objSemItem_RelationType_located_in As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_isInState As New clsSemItem
    Private objSemItem_RelationType_was_created_at As New clsSemItem
    Private objSemItem_RelationType_creation_template As New clsSemItem
    Private objSemItem_RelationType_needs As New clsSemItem
    Private objSemItem_RelationType_isDescribedBy As New clsSemItem
    Private objSemItem_RelationType_belonging_history As New clsSemItem
    Private objSemItem_RelationType_provides As New clsSemItem
    Private objSemItem_RelationType_wasCreatedBy As New clsSemItem
    Private objSemItem_RelationType_needed_semantic_Object As New clsSemItem
    Private objSemItem_RelationType_imported As New clsSemItem
    Private objSemItem_RelationType_contains As New clsSemItem
    Private objSemItem_RelationType_implemented_on As New clsSemItem
    Private objSemItem_RelationType_isWrittenIn As New clsSemItem
    Private objSemItem_RelationType_describes As New clsSemItem
    Private objSemItem_RelationType_was_exported_at As New clsSemItem
    Private objSemItem_RelationType_export_to As New clsSemItem
    Private objSemItem_RelationType_belonging_Type As New clsSemItem
    Private objSemItem_RelationType_DataPath As New clsSemItem
    Private objSemItem_RelationType_User As New clsSemItem
    Private objSemItem_RelationType_Module As New clsSemItem
    Private objSemItem_RelationType_Schema As New clsSemItem
    Private objSemItem_RelationType_Config As New clsSemItem
    Private objSemItem_RelationType_Change As New clsSemItem

    Private objSemItem_Development As clsSemItem
    Public ReadOnly Property SemItem_Development() As clsSemItem
        Get
            Return objSemItem_Development
        End Get
    End Property

    Public Property User() As clsSemItem
        Get
            Return objSemItem_User
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_User = New clsSemItem
            objSemItem_User.GUID = value.GUID
            objSemItem_User.Name = value.Name
            objSemItem_User.GUID_Parent = value.GUID_Parent
            objSemItem_User.GUID_Type = value.GUID_Type
        End Set
    End Property

    'Attributes
    Public ReadOnly Property SemItem_Attribute_Short() As clsSemItem
        Get
            Return objSemItem_Attribute_Short
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_DateTimeStamp() As clsSemItem
        Get
            Return objSemItem_Attribute_DateTimeStamp
        End Get
    End Property

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
    Public ReadOnly Property SemItem_Attribute_Message() As clsSemItem
        Get
            Return objSemItem_Attribute_Message
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_Creation_Level() As clsSemItem
        Get
            Return objSemItem_Attribute_Creation_Level
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_Creation_Script() As clsSemItem
        Get
            Return objSemItem_Attribute_Creation_Script
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_Revision() As clsSemItem
        Get
            Return objSemItem_Attribute_Revision
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Minor() As clsSemItem
        Get
            Return objSemItem_Attribute_Minor
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Major() As clsSemItem
        Get
            Return objSemItem_Attribute_Major
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Build() As clsSemItem
        Get
            Return objSemItem_Attribute_Build
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Value() As clsSemItem
        Get
            Return objSemItem_Attribute_Value
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Create_Datatypes() As clsSemItem
        Get
            Return objSemItem_Attribute_Create_Datatypes
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_is_exported() As clsSemItem
        Get
            Return objSemItem_Attribute_is_exported
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_is_Sem_DB() As clsSemItem
        Get
            Return objSemItem_Attribute_is_Sem_DB
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Filestreams() As clsSemItem
        Get
            Return objSemItem_Attribute_Filestreams
        End Get
    End Property


    'Token
    Public ReadOnly Property SemItem_Token_Server_Type_SemDB_Server() As clsSemItem
        Get
            Return objSemItem_Token_Server_Type_SemDB_Server
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_LogState_Create() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Create
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_LogState_Changed() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Changed
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_LogState_VersionChanged() As clsSemItem
        Get
            Return objSemItem_Token_LogState_VersionChanged
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_Drop_View() As clsSemItem
        Get
            Return objSemItem_Token_XML_Drop_View
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_Drop_Trigger() As clsSemItem
        Get
            Return objSemItem_Token_XML_Drop_Trigger
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_Drop_Table() As clsSemItem
        Get
            Return objSemItem_Token_XML_Drop_Table
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_Drop_Synonym() As clsSemItem
        Get
            Return objSemItem_Token_XML_Drop_Synonym
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_Drop_Procedure() As clsSemItem
        Get
            Return objSemItem_Token_XML_Drop_Procedure
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_Drop_Function() As clsSemItem
        Get
            Return objSemItem_Token_XML_Drop_Function
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL__IF_EXISTS___Table_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__IF_EXISTS___Table_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL__IF_EXISTS___View_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__IF_EXISTS___View_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL__IF_EXISTS___Function_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__IF_EXISTS___Function_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL__IF_EXISTS___Synonym_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__IF_EXISTS___Synonym_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL__IF_EXISTS___Trigger_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__IF_EXISTS___Trigger_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL__IF_EXISTS___Procedure_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__IF_EXISTS___Procedure_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL__Drop_All_Views_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__Drop_All_Views_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL__Drop_all_Procedures_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__Drop_all_Procedures_
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_TSQL__Drop_all_Functions_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__Drop_all_Functions_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL__Drop_all_Synonyms_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__Drop_all_Synonyms_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL__Drop_all_Tables_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__Drop_all_Tables_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL__Drop_all_Triggers_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__Drop_all_Triggers_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL__Create_Database_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL__Create_Database_
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Variable_schema_dbo() As clsSemItem
        Get
            Return objSemItem_Token_Variable_schema_dbo
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_schema_name() As clsSemItem
        Get
            Return objSemItem_Token_Variable_schema_name
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_table_name() As clsSemItem
        Get
            Return objSemItem_Token_Variable_table_name
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_server_name() As clsSemItem
        Get
            Return objSemItem_Token_Variable_server_name
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_db_name_change() As clsSemItem
        Get
            Return objSemItem_Token_Variable_db_name_change
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Variable_synonym_name() As clsSemItem
        Get
            Return objSemItem_Token_Variable_synonym_name
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Variable_db_name() As clsSemItem
        Get
            Return objSemItem_Token_Variable_db_name
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Name_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Name_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_AttributeType() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_AttributeType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_SemItem_Insert_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_XML_SemItem_Insert_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_SemItem_Insert_RelationType() As clsSemItem
        Get
            Return objSemItem_Token_XML_SemItem_Insert_RelationType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_RelationType() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_RelationType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Name_RelationType() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Name_RelationType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_SemItem_Insert_Type() As clsSemItem
        Get
            Return objSemItem_Token_XML_SemItem_Insert_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Name_Type() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Name_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Type() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Type_Parent() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Type_Parent
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_SemItem_Insert_Token() As clsSemItem
        Get
            Return objSemItem_Token_XML_SemItem_Insert_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Name_Token() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Name_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Token() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_SemItem_Insert_Type_NoParent() As clsSemItem
        Get
            Return objSemItem_Token_XML_SemItem_Insert_Type_NoParent
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_SemDB() As clsSemItem
        Get
            Return objSemItem_Token_Variable_SemDB
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_SchemaVersion() As clsSemItem
        Get
            Return objSemItem_Token_Variable_SchemaVersion
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_Trigger() As clsSemItem
        Get
            Return objSemItem_Token_Names_Trigger
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_Tabellen() As clsSemItem
        Get
            Return objSemItem_Token_Names_Tabellen
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_Synonyme() As clsSemItem
        Get
            Return objSemItem_Token_Names_Synonyme
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_Skript() As clsSemItem
        Get
            Return objSemItem_Token_Names_Skript
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_Semantic_Items() As clsSemItem
        Get
            Return objSemItem_Token_Names_Semantic_Items
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_Prozeduren() As clsSemItem
        Get
            Return objSemItem_Token_Names_Prozeduren
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_Notwendig_f_r() As clsSemItem
        Get
            Return objSemItem_Token_Names_Notwendig_f_r
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_Funktionen() As clsSemItem
        Get
            Return objSemItem_Token_Names_Funktionen
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_F_r_das_Datenbankobjekt_notwendig() As clsSemItem
        Get
            Return objSemItem_Token_Names_F_r_das_Datenbankobjekt_notwendig
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_Beschreibung() As clsSemItem
        Get
            Return objSemItem_Token_Names_Beschreibung
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_Basisdaten() As clsSemItem
        Get
            Return objSemItem_Token_Names_Basisdaten
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_Abh_ngigkeiten() As clsSemItem
        Get
            Return objSemItem_Token_Names_Abh_ngigkeiten
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_Abfragen() As clsSemItem
        Get
            Return objSemItem_Token_Names_Abfragen
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_DBItem_Name() As clsSemItem
        Get
            Return objSemItem_Token_Names_DBItem_Name
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_DBItem_ChangeDate() As clsSemItem
        Get
            Return objSemItem_Token_Names_DBItem_ChangeDate
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Names_DBItem_Type() As clsSemItem
        Get
            Return objSemItem_Token_Names_DBItem_Type
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Wiki_Components_Wiki_Link__intern_() As clsSemItem
        Get
            Return objSemItem_Token_Wiki_Components_Wiki_Link__intern_
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Names_Language_Lbl() As clsSemItem
        Get
            Return objSemItem_Token_Names_Language_Lbl
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_TSQL_Use_Database() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_Use_Database
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB__Local_() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB__Local_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_isSystemDB() As clsSemItem
        Get
            Return objSemItem_Token_Variable_isSystemDB
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_DB() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_DB
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_NAME_DB() As clsSemItem
        Get
            Return objSemItem_Token_Variable_NAME_DB
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Variable_NAME_DATATYPE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_NAME_DATATYPE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_DATATYPE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_DATATYPE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL___insert_Datatypes() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL___insert_Datatypes
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Variable_Value_Property() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Value_Property
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Name_Property() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Name_Property
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL___addProperty() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL___addProperty
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_Create_Object_Reference_Typs() As clsSemItem
        Get
            Return objSemItem_Attribute_Create_Object_Reference_Typs
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_TSQL___insert_Object_Reference_Type() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL___insert_Object_Reference_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Name_ObjectReferenceType() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Name_ObjectReferenceType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_ObjectReferenceType() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_ObjectReferenceType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_Insert_TokenAttribute() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_Insert_TokenAttribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_TokenAttribute() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_TokenAttribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_ORType() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_ORType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_ObjectReference() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_ObjectReference
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_Type_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_Type_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Min() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Min
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Max() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Max
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Min_forw() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Min_forw
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Max_forw() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Max_forw
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Max_backw() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Max_backw
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Type_Right() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Type_Right
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Type_Left() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Type_Left
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_Type_Type() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_Type_Type
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_TokenAttribute_Bit() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_TokenAttribute_Bit
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_OrderID() As clsSemItem
        Get
            Return objSemItem_Token_Variable_OrderID
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_val() As clsSemItem
        Get
            Return objSemItem_Token_Variable_val
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_TokenAttribute_Date() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_TokenAttribute_Date
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_TokenAttribute_Datetime() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_TokenAttribute_Datetime
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_TokenAttribute_Int() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_TokenAttribute_Int
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_TokenAttribute_Real() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_TokenAttribute_Real
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_TokenAttribute_time() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_TokenAttribute_time
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_TokenAttribute_Varchar255() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_TokenAttribute_Varchar255
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_TokenAttribute_VarcharMax() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_TokenAttribute_VarcharMax
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Token_Right() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Token_Right
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Token_Left() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Token_Left
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_Token_Token() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_Token_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR_RelationType() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR_RelationType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR_Token() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Bit() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Bit
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Date() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Date
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Datetime() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Datetime
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Int() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Int
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Real() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Real
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Time() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Time
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHAR255() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHAR255
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHARMAX() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHARMAX
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_Token_OR() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_Token_OR
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_Type_OR() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_Type_OR
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_insert_semtbl_OR_Type() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_insert_semtbl_OR_Type
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_TSQL_dbg_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_dbg_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_dbg_RelationType() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_dbg_RelationType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ParsedName_RelationType() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ParsedName_RelationType
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ParsedName_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ParsedName_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_dbg_Type() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_dbg_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ParsedName_Type() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ParsedName_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_TSQL_CREATE_Function_Token_Of_Type() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_CREATE_Function_Token_Of_Type
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Variable_function_name() As clsSemItem
        Get
            Return objSemItem_Token_Variable_function_name
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Variable_view_name() As clsSemItem
        Get
            Return objSemItem_Token_Variable_view_name
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_procedure_name() As clsSemItem
        Get
            Return objSemItem_Token_Variable_procedure_name
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Variable_trigger_name() As clsSemItem
        Get
            Return objSemItem_Token_Variable_trigger_name
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_TSQL_executesql() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL_executesql
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Variable_tsql_code() As clsSemItem
        Get
            Return objSemItem_Token_Variable_tsql_code
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_DB_Schema_Type_User() As clsSemItem
        Get
            Return objSemItem_Token_DB_Schema_Type_User
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_DB_Schema_Type_System() As clsSemItem
        Get
            Return objSemItem_Token_DB_Schema_Type_System
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_DB_Schema_Type_Module() As clsSemItem
        Get
            Return objSemItem_Token_DB_Schema_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_DB_Schema_Type_Config() As clsSemItem
        Get
            Return objSemItem_Token_DB_Schema_Type_Config
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_DB_Schema_Type_Change() As clsSemItem
        Get
            Return objSemItem_Token_DB_Schema_Type_Change
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_TSQL___Func___Token_Of_related_Token() As clsSemItem
        Get
            Return objSemItem_Token_XML_TSQL___Func___Token_Of_related_Token
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Variable_Type_Name_Right() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Type_Name_Right
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Type_Name_Left() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Type_Name_Left
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Par_GUID_Type_Right() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Par_GUID_Type_Right
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Name_Row_Right() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Name_Row_Right
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Type_Row_Right() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Type_Row_Right
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Row_Right() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Row_Right
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Variable_GUID_Row_Left() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Row_Left
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_Create_Database__Filestreams_() As clsSemItem
        Get
            Return objSemItem_Token_XML_Create_Database__Filestreams_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_db_folder_path() As clsSemItem
        Get
            Return objSemItem_Token_Variable_db_folder_path
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_XML_Template() As clsSemItem
        Get
            Return objSemItem_Token_XML_XML_Template
        End Get
    End Property

    'Types
    Public ReadOnly Property SemItem_Type_DB_Views() As clsSemItem
        Get
            Return objSemItem_Type_DB_Views
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DB_Triggers() As clsSemItem
        Get
            Return objSemItem_Type_DB_Triggers
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DB_Trigger_Event() As clsSemItem
        Get
            Return objSemItem_Type_DB_Trigger_Event
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DB_Tables() As clsSemItem
        Get
            Return objSemItem_Type_DB_Tables
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DB_Synonyms() As clsSemItem
        Get
            Return objSemItem_Type_DB_Synonyms
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DB_Synonym_Point() As clsSemItem
        Get
            Return objSemItem_Type_DB_Synonym_Point
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DB_Synonym___Server() As clsSemItem
        Get
            Return objSemItem_Type_DB_Synonym___Server
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DB_Procedure() As clsSemItem
        Get
            Return objSemItem_Type_DB_Procedure
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DB_Parameters() As clsSemItem
        Get
            Return objSemItem_Type_DB_Parameters
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DB_Function() As clsSemItem
        Get
            Return objSemItem_Type_DB_Function
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Database_Schema() As clsSemItem
        Get
            Return objSemItem_Type_Database_Schema
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Database() As clsSemItem
        Get
            Return objSemItem_Type_Database
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Server() As clsSemItem
        Get
            Return objSemItem_Type_Server
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Database_on_Server() As clsSemItem
        Get
            Return objSemItem_Type_Database_on_Server
        End Get
    End Property
    Public ReadOnly Property SemItem_type_DevelopmentVersion() As clsSemItem
        Get
            Return objSemItem_type_DevelopmentVersion
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_LogEntry() As clsSemItem
        Get
            Return objSemItem_Type_LogEntry
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Functions_in_Schema() As clsSemItem
        Get
            Return objSemItem_Type_Functions_in_Schema
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Views_in_Schema() As clsSemItem
        Get
            Return objSemItem_Type_Views_in_Schema
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Triggers_in_Schema() As clsSemItem
        Get
            Return objSemItem_Type_Triggers_in_Schema
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Tables_in_Schema() As clsSemItem
        Get
            Return objSemItem_Type_Tables_in_Schema
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Synonyms_in_Schemas() As clsSemItem
        Get
            Return objSemItem_Type_Synonyms_in_Schemas
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Procedures_in_Schemas() As clsSemItem
        Get
            Return objSemItem_Type_Procedures_in_Schemas
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_XML() As clsSemItem
        Get
            Return objSemItem_Type_XML
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Language() As clsSemItem
        Get
            Return objSemItem_Type_Language
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Creation_Scripts() As clsSemItem
        Get
            Return objSemItem_Type_Creation_Scripts
        End Get
    End Property
    Public ReadOnly Property SemItem_type_User() As clsSemItem
        Get
            Return objSemItem_type_User
        End Get
    End Property
    Public ReadOnly Property SemItem_type_Logstate() As clsSemItem
        Get
            Return objSemItem_type_Logstate
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Userschema() As clsSemItem
        Get
            Return objSemItem_Type_Userschema
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Database_Schema_on_Server___Creation_Script_Imported() As clsSemItem
        Get
            Return objSemItem_Type_Database_Schema_on_Server___Creation_Script_Imported
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_WIKI_Implementation() As clsSemItem
        Get
            Return objSemItem_Type_WIKI_Implementation
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Wiki_Documentation__Database_Schema_() As clsSemItem
        Get
            Return objSemItem_Type_Wiki_Documentation__Database_Schema_
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Url() As clsSemItem
        Get
            Return objSemItem_Type_Url
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Wiki_Document() As clsSemItem
        Get
            Return objSemItem_Type_Wiki_Document
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Names() As clsSemItem
        Get
            Return objSemItem_Type_Names
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Localized_Names() As clsSemItem
        Get
            Return objSemItem_Type_Localized_Names
        End Get
    End Property
    Public ReadOnly Property SemItem_type_LocalizedDescription() As clsSemItem
        Get
            Return objSemItem_type_LocalizedDescription
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_File() As clsSemItem
        Get
            Return objSemItem_Type_File
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Semantic_Objects_of_DB_Schema() As clsSemItem
        Get
            Return objSemItem_Type_Semantic_Objects_of_DB_Schema
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_DB_Schema_Type() As clsSemItem
        Get
            Return objSemItem_Type_DB_Schema_Type
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Commands() As clsSemItem
        Get
            Return objSemItem_Type_Commands
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Database_for_Synonyms() As clsSemItem
        Get
            Return objSemItem_Type_Database_for_Synonyms
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DBServerConfig() As clsSemItem
        Get
            Return objSemItem_Type_DBServerConfig
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Path() As clsSemItem
        Get
            Return objSemItem_Type_Path
        End Get
    End Property
    
    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_is_of_Type() As clsSemItem
        Get
            Return objSemItem_RelationType_is_of_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_located_in() As clsSemItem
        Get
            Return objSemItem_RelationType_located_in
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_isInState() As clsSemItem
        Get
            Return objSemItem_RelationType_isInState
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_was_created_at() As clsSemItem
        Get
            Return objSemItem_RelationType_was_created_at
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_creation_template() As clsSemItem
        Get
            Return objSemItem_RelationType_creation_template
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_needs() As clsSemItem
        Get
            Return objSemItem_RelationType_needs
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_isDescribedBy() As clsSemItem
        Get
            Return objSemItem_RelationType_isDescribedBy
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_belonging_history() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_history
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_provides() As clsSemItem
        Get
            Return objSemItem_RelationType_provides
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_wasCreatedBy() As clsSemItem
        Get
            Return objSemItem_RelationType_wasCreatedBy
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_needed_semantic_Object() As clsSemItem
        Get
            Return objSemItem_RelationType_needed_semantic_Object
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_imported() As clsSemItem
        Get
            Return objSemItem_RelationType_imported
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_contains() As clsSemItem
        Get
            Return objSemItem_RelationType_contains
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_implemented_on() As clsSemItem
        Get
            Return objSemItem_RelationType_implemented_on
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_isWrittenIn() As clsSemItem
        Get
            Return objSemItem_RelationType_isWrittenIn
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_describes() As clsSemItem
        Get
            Return objSemItem_RelationType_describes
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_was_exported_at() As clsSemItem
        Get
            Return objSemItem_RelationType_was_exported_at
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_export_to() As clsSemItem
        Get
            Return objSemItem_RelationType_export_to
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_belonging_Type() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_DataPath() As clsSemItem
        Get
            Return objSemItem_RelationType_DataPath
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_User() As clsSemItem
        Get
            Return objSemItem_RelationType_User
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Module() As clsSemItem
        Get
            Return objSemItem_RelationType_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Schema() As clsSemItem
        Get
            Return objSemItem_RelationType_Schema
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Config() As clsSemItem
        Get
            Return objSemItem_RelationType_Config
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Change() As clsSemItem
        Get
            Return objSemItem_RelationType_Change
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

    Public ReadOnly Property Connection_System() As SqlClient.SqlConnection
        Get
            Return objConnection_System
        End Get
    End Property

    Public ReadOnly Property Connection_Change() As SqlClient.SqlConnection
        Get
            Return objConnection_Change
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

        set_DBConnection()
        get_Config()
    End Sub

    Private Sub set_DBConnection()
        objConnection_Change = New SqlClient.SqlConnection(objGlobals.ConnectionString_Change)

        funcA_SoftwareDevelopment_Config.Connection = objConnection_Config

        procA_TokenAttribute_Varchar255.Connection = objConnection_Config

        procA_OR_Attribute_By_GUIDObjectReference.Connection = objConnection_Config
        procA_OR_RelationType_By_GUIDObjectReference.Connection = objConnection_Config
        procA_OR_Token_By_GUID.Connection = objConnection_Config
        procA_OR_Type_By_GUID.Connection = objConnection_Config
    End Sub

    Private Sub get_Config()
        
        funcA_SoftwareDevelopment_Config.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_Config, objGUID_Development)

        get_Config_Attributes()
        get_Config_RelationTypes()
        get_Config_Token()
        get_Config_Types()


        objConnection_System = New SqlClient.SqlConnection(objGlobals.ConnectionString_System)
        get_LocalizedNames()

    End Sub

    Private Sub get_Config_Attributes()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objSemItem_Development = New clsSemItem
        objSemItem_Development.GUID = New Guid(cstr_GUIDToken_Development)
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Build'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Build.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Build.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Build.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Build.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Create_Datatypes'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Create_Datatypes.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Create_Datatypes.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Create_Datatypes.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Create_Datatypes.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Create_Object_Reference_Typs'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Create_Object_Reference_Typs.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Create_Object_Reference_Typs.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Create_Object_Reference_Typs.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Create_Object_Reference_Typs.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Creation_Level'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Creation_Level.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Creation_Level.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Creation_Level.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Creation_Level.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Creation_Script'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Creation_Script.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Creation_Script.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Creation_Script.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Creation_Script.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_DateTimeStamp'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_DateTimeStamp.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_DateTimeStamp.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_DateTimeStamp.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_DateTimeStamp.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_is_exported'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_is_exported.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_is_exported.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_is_exported.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_is_exported.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Major'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Major.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Major.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Major.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Major.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Message'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Message.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Message.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Message.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Message.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Minor'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Minor.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Minor.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Minor.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Minor.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Revision'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Revision.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Revision.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Revision.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Revision.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Short'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Short.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Short.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Short.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Short.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Value'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Value.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Value.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Value.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Value.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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
        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_is_Sem_DB'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_is_Sem_DB.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_is_Sem_DB.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_is_Sem_DB.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_is_Sem_DB.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Filestreams'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Filestreams.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Filestreams.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Filestreams.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Filestreams.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_history'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_history.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_history.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_history.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_creation_template'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_creation_template.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_creation_template.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_creation_template.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_describes'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_describes.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_describes.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_describes.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_export_to'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_export_to.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_export_to.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_export_to.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_implemented_on'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_implemented_on.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_implemented_on.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_implemented_on.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_imported'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_imported.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_imported.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_imported.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_isDescribedBy'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_isDescribedBy.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_isDescribedBy.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_isDescribedBy.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_isInState'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_isInState.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_isInState.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_isInState.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_isWrittenIn'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_isWrittenIn.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_isWrittenIn.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_isWrittenIn.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_located_in'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_located_in.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_located_in.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_located_in.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_needed_semantic_Object'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_needed_semantic_Object.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_needed_semantic_Object.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_needed_semantic_Object.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_needs'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_needs.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_needs.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_needs.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_provides'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_provides.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_provides.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_provides.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_was_created_at'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_was_created_at.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_was_created_at.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_was_created_at.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_was_exported_at'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_was_exported_at.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_was_exported_at.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_was_exported_at.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_wasCreatedBy'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_wasCreatedBy.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_wasCreatedBy.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_wasCreatedBy.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DB_Schema_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DB_Schema_Type.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DB_Schema_Type.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DB_Schema_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DB_Schema_Type.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Type.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Type.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Type.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_DataPath'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_DataPath.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_DataPath.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_DataPath.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_User'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_User.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_User.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_User.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Module.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Module.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Module.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Schema'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Schema.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Schema.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Schema.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Config'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Config.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Config.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Config.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Change'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Change.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Change.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Change.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_Changed'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_Changed.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_Changed.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_Changed.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_Changed.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_Create'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_Create.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_Create.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_Create.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_Create.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_VersionChanged'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_VersionChanged.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_VersionChanged.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_VersionChanged.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_VersionChanged.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Abfragen'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Abfragen.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Abfragen.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Abfragen.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Abfragen.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Abh_ngigkeiten'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Abh_ngigkeiten.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Abh_ngigkeiten.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Abh_ngigkeiten.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Abh_ngigkeiten.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Basisdaten'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Basisdaten.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Basisdaten.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Basisdaten.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Basisdaten.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Beschreibung'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Beschreibung.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Beschreibung.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Beschreibung.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Beschreibung.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_DBItem_ChangeDate'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_DBItem_ChangeDate.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_DBItem_ChangeDate.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_DBItem_ChangeDate.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_DBItem_ChangeDate.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_DBItem_Name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_DBItem_Name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_DBItem_Name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_DBItem_Name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_DBItem_Name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_DBItem_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_DBItem_Type.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_DBItem_Type.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_DBItem_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_DBItem_Type.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_F_r_das_Datenbankobjekt_notwendig'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_F_r_das_Datenbankobjekt_notwendig.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_F_r_das_Datenbankobjekt_notwendig.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_F_r_das_Datenbankobjekt_notwendig.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_F_r_das_Datenbankobjekt_notwendig.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Funktionen'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Funktionen.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Funktionen.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Funktionen.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Funktionen.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Language_Lbl'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Language_Lbl.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Language_Lbl.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Language_Lbl.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Language_Lbl.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Notwendig_f_r'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Notwendig_f_r.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Notwendig_f_r.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Notwendig_f_r.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Notwendig_f_r.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Prozeduren'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Prozeduren.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Prozeduren.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Prozeduren.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Prozeduren.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Semantic_Items'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Semantic_Items.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Semantic_Items.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Semantic_Items.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Semantic_Items.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Skript'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Skript.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Skript.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Skript.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Skript.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Synonyme'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Synonyme.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Synonyme.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Synonyme.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Synonyme.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Tabellen'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Tabellen.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Tabellen.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Tabellen.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Tabellen.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Names_Trigger'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Names_Trigger.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Names_Trigger.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Names_Trigger.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Names_Trigger.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Server_Type_SemDB_Server'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Server_Type_SemDB_Server.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Server_Type_SemDB_Server.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Server_Type_SemDB_Server.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Server_Type_SemDB_Server.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_db_name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_db_name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_db_name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_db_name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_db_name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_db_name_change'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_db_name_change.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_db_name_change.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_db_name_change.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_db_name_change.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_function_name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_function_name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_function_name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_function_name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_function_name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_AttributeType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_AttributeType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_AttributeType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_AttributeType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_AttributeType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_DATATYPE'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_DATATYPE.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_DATATYPE.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_DATATYPE.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_DATATYPE.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_DB'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_DB.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_DB.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_DB.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_DB.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_ObjectReference'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_ObjectReference.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_ObjectReference.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_ObjectReference.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_ObjectReference.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_ObjectReferenceType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_ObjectReferenceType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_ObjectReferenceType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_ObjectReferenceType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_ObjectReferenceType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_ORType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_ORType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_ORType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_ORType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_ORType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_RelationType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_RelationType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_RelationType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_RelationType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_RelationType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_Token.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_Token.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_Token.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_Token.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_Token_Left'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_Token_Left.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_Token_Left.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_Token_Left.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_Token_Left.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_Token_Right'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_Token_Right.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_Token_Right.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_Token_Right.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_Token_Right.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_TokenAttribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_TokenAttribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_TokenAttribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_TokenAttribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_TokenAttribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_Type.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_Type.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_Type.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_Type_Left'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_Type_Left.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_Type_Left.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_Type_Left.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_Type_Left.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_Type_Parent'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_Type_Parent.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_Type_Parent.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_Type_Parent.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_Type_Parent.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_Type_Right'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_Type_Right.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_Type_Right.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_Type_Right.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_Type_Right.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_isSystemDB'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_isSystemDB.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_isSystemDB.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_isSystemDB.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_isSystemDB.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Max'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Max.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Max.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Max.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Max.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Max_backw'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Max_backw.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Max_backw.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Max_backw.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Max_backw.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Max_forw'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Max_forw.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Max_forw.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Max_forw.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Max_forw.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Min'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Min.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Min.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Min.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Min.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Min_forw'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Min_forw.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Min_forw.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Min_forw.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Min_forw.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Name_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Name_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Name_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Name_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Name_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_NAME_DATATYPE'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_NAME_DATATYPE.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_NAME_DATATYPE.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_NAME_DATATYPE.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_NAME_DATATYPE.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_NAME_DB'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_NAME_DB.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_NAME_DB.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_NAME_DB.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_NAME_DB.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Name_ObjectReferenceType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Name_ObjectReferenceType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Name_ObjectReferenceType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Name_ObjectReferenceType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Name_ObjectReferenceType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Name_Property'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Name_Property.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Name_Property.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Name_Property.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Name_Property.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Name_RelationType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Name_RelationType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Name_RelationType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Name_RelationType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Name_RelationType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Name_Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Name_Token.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Name_Token.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Name_Token.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Name_Token.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Name_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Name_Type.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Name_Type.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Name_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Name_Type.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_OrderID'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_OrderID.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_OrderID.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_OrderID.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_OrderID.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ParsedName_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ParsedName_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ParsedName_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ParsedName_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ParsedName_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ParsedName_RelationType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ParsedName_RelationType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ParsedName_RelationType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ParsedName_RelationType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ParsedName_RelationType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ParsedName_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ParsedName_Type.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ParsedName_Type.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ParsedName_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ParsedName_Type.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_schema_dbo'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_schema_dbo.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_schema_dbo.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_schema_dbo.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_schema_dbo.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_schema_name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_schema_name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_schema_name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_schema_name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_schema_name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_SchemaVersion'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_SchemaVersion.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_SchemaVersion.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_SchemaVersion.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_SchemaVersion.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_SemDB'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_SemDB.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_SemDB.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_SemDB.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_SemDB.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_server_name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_server_name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_server_name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_server_name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_server_name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_synonym_name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_synonym_name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_synonym_name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_synonym_name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_synonym_name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_table_name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_table_name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_table_name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_table_name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_table_name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_val'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_val.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_val.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_val.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_val.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Value_Property'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Value_Property.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Value_Property.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Value_Property.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Value_Property.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Wiki_Components_Wiki_Link__intern_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Wiki_Components_Wiki_Link__intern_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Wiki_Components_Wiki_Link__intern_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Wiki_Components_Wiki_Link__intern_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Wiki_Components_Wiki_Link__intern_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_Drop_Function'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_Drop_Function.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_Drop_Function.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_Drop_Function.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_Drop_Function.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_Drop_Procedure'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_Drop_Procedure.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_Drop_Procedure.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_Drop_Procedure.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_Drop_Procedure.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_Drop_Synonym'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_Drop_Synonym.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_Drop_Synonym.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_Drop_Synonym.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_Drop_Synonym.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_Drop_Table'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_Drop_Table.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_Drop_Table.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_Drop_Table.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_Drop_Table.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_Drop_Trigger'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_Drop_Trigger.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_Drop_Trigger.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_Drop_Trigger.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_Drop_Trigger.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_Drop_View'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_Drop_View.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_Drop_View.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_Drop_View.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_Drop_View.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_SemItem_Insert_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_SemItem_Insert_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_SemItem_Insert_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_SemItem_Insert_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_SemItem_Insert_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_SemItem_Insert_RelationType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_SemItem_Insert_RelationType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_SemItem_Insert_RelationType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_SemItem_Insert_RelationType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_SemItem_Insert_RelationType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_SemItem_Insert_Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_SemItem_Insert_Token.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_SemItem_Insert_Token.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_SemItem_Insert_Token.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_SemItem_Insert_Token.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_SemItem_Insert_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_SemItem_Insert_Type.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_SemItem_Insert_Type.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_SemItem_Insert_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_SemItem_Insert_Type.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_SemItem_Insert_Type_NoParent'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_SemItem_Insert_Type_NoParent.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_SemItem_Insert_Type_NoParent.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_SemItem_Insert_Type_NoParent.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_SemItem_Insert_Type_NoParent.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL___addProperty'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL___addProperty.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL___addProperty.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL___addProperty.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL___addProperty.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL___insert_Datatypes'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL___insert_Datatypes.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL___insert_Datatypes.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL___insert_Datatypes.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL___insert_Datatypes.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL___insert_Object_Reference_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL___insert_Object_Reference_Type.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL___insert_Object_Reference_Type.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL___insert_Object_Reference_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL___insert_Object_Reference_Type.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__Create_Database_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__Create_Database_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__Create_Database_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__Create_Database_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__Create_Database_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__Drop_all_Functions_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__Drop_all_Functions_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__Drop_all_Functions_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__Drop_all_Functions_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__Drop_all_Functions_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__Drop_all_Procedures_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__Drop_all_Procedures_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__Drop_all_Procedures_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__Drop_all_Procedures_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__Drop_all_Procedures_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__Drop_all_Synonyms_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__Drop_all_Synonyms_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__Drop_all_Synonyms_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__Drop_all_Synonyms_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__Drop_all_Synonyms_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__Drop_all_Tables_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__Drop_all_Tables_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__Drop_all_Tables_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__Drop_all_Tables_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__Drop_all_Tables_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__Drop_all_Triggers_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__Drop_all_Triggers_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__Drop_all_Triggers_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__Drop_all_Triggers_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__Drop_all_Triggers_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__Drop_All_Views_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__Drop_All_Views_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__Drop_All_Views_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__Drop_All_Views_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__Drop_All_Views_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__IF_EXISTS___Function_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__IF_EXISTS___Function_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Function_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Function_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Function_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__IF_EXISTS___Procedure_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__IF_EXISTS___Procedure_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Procedure_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Procedure_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Procedure_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__IF_EXISTS___Synonym_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__IF_EXISTS___Synonym_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Synonym_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Synonym_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Synonym_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__IF_EXISTS___Table_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__IF_EXISTS___Table_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Table_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Table_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Table_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__IF_EXISTS___Trigger_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__IF_EXISTS___Trigger_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Trigger_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Trigger_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__IF_EXISTS___Trigger_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL__IF_EXISTS___View_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL__IF_EXISTS___View_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL__IF_EXISTS___View_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL__IF_EXISTS___View_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL__IF_EXISTS___View_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_CREATE_Function_Token_Of_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_CREATE_Function_Token_Of_Type.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_CREATE_Function_Token_Of_Type.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_CREATE_Function_Token_Of_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_CREATE_Function_Token_Of_Type.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_dbg_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_dbg_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_dbg_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_dbg_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_dbg_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_dbg_RelationType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_dbg_RelationType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_dbg_RelationType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_dbg_RelationType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_dbg_RelationType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_dbg_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_dbg_Type.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_dbg_Type.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_dbg_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_dbg_Type.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_SemDB_Into_Change_DB'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR_RelationType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_RelationType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_RelationType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_RelationType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_RelationType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR_Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Bit'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Bit.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Bit.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Bit.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Bit.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Date'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Date.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Date.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Date.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Date.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Datetime'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Datetime.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Datetime.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Datetime.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Datetime.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Int'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Int.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Int.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Int.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Int.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Real'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Real.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Real.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Real.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Real.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Time'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Time.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Time.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Time.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Time.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHAR255'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHAR255.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHAR255.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHAR255.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHAR255.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHARMAX'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHARMAX.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHARMAX.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHARMAX.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHARMAX.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_OR_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Type.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Type.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_OR_Type.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_Token_OR'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_Token_OR.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_Token_OR.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_Token_OR.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_Token_OR.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_Type_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_Type_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_Type_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_Type_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_Type_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_Type_OR'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_Type_OR.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_Type_OR.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_Type_OR.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_Type_OR.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_semtbl_Type_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_semtbl_Type_Type.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_Type_Type.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_semtbl_Type_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_semtbl_Type_Type.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_Token_Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_Token_Token.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_Token_Token.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_Token_Token.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_Token_Token.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_Insert_TokenAttribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_Insert_TokenAttribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_Insert_TokenAttribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_Insert_TokenAttribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_Insert_TokenAttribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_TokenAttribute_Bit'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Bit.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Bit.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Bit.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Bit.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_TokenAttribute_Date'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Date.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Date.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Date.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Date.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_TokenAttribute_Datetime'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Datetime.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Datetime.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Datetime.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Datetime.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_TokenAttribute_Int'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Int.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Int.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Int.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Int.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_TokenAttribute_Real'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Real.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Real.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Real.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Real.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_TokenAttribute_time'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_time.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_time.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_time.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_time.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_TokenAttribute_Varchar255'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Varchar255.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Varchar255.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Varchar255.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_Varchar255.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_TokenAttribute_VarcharMax'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_VarcharMax.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_VarcharMax.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_VarcharMax.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_TokenAttribute_VarcharMax.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_Use_Database'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_Use_Database.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_Use_Database.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_Use_Database.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_Use_Database.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_view_name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_view_name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_view_name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_view_name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_view_name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_procedure_name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_procedure_name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_procedure_name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_procedure_name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_procedure_name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_trigger_name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_trigger_name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_trigger_name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_trigger_name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_trigger_name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_executesql'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_executesql.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_executesql.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_executesql.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_executesql.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_tsql_code'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_tsql_code.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_tsql_code.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_tsql_code.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_tsql_code.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_DB_Schema_Type_User'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_DB_Schema_Type_User.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_DB_Schema_Type_User.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_DB_Schema_Type_User.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_DB_Schema_Type_User.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_DB_Schema_Type_System'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_DB_Schema_Type_System.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_DB_Schema_Type_System.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_DB_Schema_Type_System.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_DB_Schema_Type_System.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_DB_Schema_Type_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_DB_Schema_Type_Module.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_DB_Schema_Type_Module.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_DB_Schema_Type_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_DB_Schema_Type_Module.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_DB_Schema_Type_Config'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_DB_Schema_Type_Config.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_DB_Schema_Type_Config.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_DB_Schema_Type_Config.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_DB_Schema_Type_Config.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_DB_Schema_Type_Change'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_DB_Schema_Type_Change.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_DB_Schema_Type_Change.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_DB_Schema_Type_Change.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_DB_Schema_Type_Change.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL___Func___Token_Of_related_Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL___Func___Token_Of_related_Token.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL___Func___Token_Of_related_Token.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL___Func___Token_Of_related_Token.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL___Func___Token_Of_related_Token.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Type_Name_Right'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Type_Name_Right.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Type_Name_Right.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Type_Name_Right.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Type_Name_Right.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Type_Name_Left'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Type_Name_Left.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Type_Name_Left.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Type_Name_Left.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Type_Name_Left.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Par_GUID_Type_Right'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Par_GUID_Type_Right.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Par_GUID_Type_Right.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Par_GUID_Type_Right.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Par_GUID_Type_Right.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Name_Row_Right'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Name_Row_Right.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Name_Row_Right.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Name_Row_Right.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Name_Row_Right.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If


        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_Type_Row_Right'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_Type_Row_Right.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_Type_Row_Right.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_Type_Row_Right.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_Type_Row_Right.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_Row_Right'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_Row_Right.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_Row_Right.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_Row_Right.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_Row_Right.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_GUID_Row_Left'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_GUID_Row_Left.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_GUID_Row_Left.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_GUID_Row_Left.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_GUID_Row_Left.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_Create_Database__Filestreams_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_Create_Database__Filestreams_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_Create_Database__Filestreams_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_Create_Database__Filestreams_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_Create_Database__Filestreams_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_db_folder_path'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_db_folder_path.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_db_folder_path.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_db_folder_path.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_db_folder_path.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_XML_Template'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_XML_Template.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_XML_Template.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_XML_Template.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_XML_Template.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_TSQL_insert_SemDB_Into_Change_DB__Local_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB__Local_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB__Local_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB__Local_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB__Local_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Creation_Scripts'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Creation_Scripts.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Creation_Scripts.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Creation_Scripts.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Creation_Scripts.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Database'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Database.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Database.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Database.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Database.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Database_on_Server'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Database_on_Server.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Database_on_Server.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Database_on_Server.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Database_on_Server.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Database_Schema'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Database_Schema.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Database_Schema.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Database_Schema.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Database_Schema.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Database_Schema_on_Server___Creation_Script_Imported'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Database_Schema_on_Server___Creation_Script_Imported.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Database_Schema_on_Server___Creation_Script_Imported.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Database_Schema_on_Server___Creation_Script_Imported.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Database_Schema_on_Server___Creation_Script_Imported.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DB_Function'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DB_Function.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DB_Function.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DB_Function.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DB_Function.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DB_Parameters'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DB_Parameters.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DB_Parameters.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DB_Parameters.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DB_Parameters.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DB_Procedure'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DB_Procedure.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DB_Procedure.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DB_Procedure.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DB_Procedure.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DB_Synonym___Server'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DB_Synonym___Server.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DB_Synonym___Server.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DB_Synonym___Server.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DB_Synonym___Server.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DB_Synonym_Point'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DB_Synonym_Point.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DB_Synonym_Point.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DB_Synonym_Point.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DB_Synonym_Point.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DB_Synonyms'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DB_Synonyms.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DB_Synonyms.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DB_Synonyms.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DB_Synonyms.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DB_Tables'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DB_Tables.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DB_Tables.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DB_Tables.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DB_Tables.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DB_Trigger_Event'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DB_Trigger_Event.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DB_Trigger_Event.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DB_Trigger_Event.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DB_Trigger_Event.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DB_Triggers'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DB_Triggers.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DB_Triggers.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DB_Triggers.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DB_Triggers.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DB_Views'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DB_Views.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DB_Views.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DB_Views.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DB_Views.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_DevelopmentVersion'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_DevelopmentVersion.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_DevelopmentVersion.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_DevelopmentVersion.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_DevelopmentVersion.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_File'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_File.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_File.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_File.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_File.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Functions_in_Schema'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Functions_in_Schema.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Functions_in_Schema.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Functions_in_Schema.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Functions_in_Schema.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Language'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Language.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Language.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Language.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Language.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Localized_Names'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Localized_Names.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Localized_Names.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Localized_Names.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Localized_Names.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_LocalizedDescription'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_LocalizedDescription.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_LocalizedDescription.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_LocalizedDescription.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_LocalizedDescription.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_LogEntry'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_LogEntry.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_LogEntry.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_LogEntry.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_LogEntry.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_Logstate'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_Logstate.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_Logstate.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_Logstate.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_Logstate.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Names'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Names.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Names.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Names.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Names.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Procedures_in_Schemas'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Procedures_in_Schemas.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Procedures_in_Schemas.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Procedures_in_Schemas.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Procedures_in_Schemas.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Synonyms_in_Schemas'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Synonyms_in_Schemas.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Synonyms_in_Schemas.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Synonyms_in_Schemas.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Synonyms_in_Schemas.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Tables_in_Schema'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Tables_in_Schema.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Tables_in_Schema.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Tables_in_Schema.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Tables_in_Schema.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Triggers_in_Schema'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Triggers_in_Schema.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Triggers_in_Schema.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Triggers_in_Schema.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Triggers_in_Schema.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_User'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_User.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_User.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_User.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_User.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Userschema'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Userschema.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Userschema.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Userschema.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Userschema.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Views_in_Schema'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Views_in_Schema.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Views_in_Schema.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Views_in_Schema.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Views_in_Schema.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Wiki_Document'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Wiki_Document.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Wiki_Document.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Wiki_Document.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Wiki_Document.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Wiki_Documentation__Database_Schema_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Wiki_Documentation__Database_Schema_.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Wiki_Documentation__Database_Schema_.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Wiki_Documentation__Database_Schema_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Wiki_Documentation__Database_Schema_.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_WIKI_Implementation'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_WIKI_Implementation.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_WIKI_Implementation.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_WIKI_Implementation.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_WIKI_Implementation.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_XML'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_XML.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_XML.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_XML.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_XML.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Semantic_Objects_of_DB_Schema'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Semantic_Objects_of_DB_Schema.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Semantic_Objects_of_DB_Schema.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Semantic_Objects_of_DB_Schema.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Semantic_Objects_of_DB_Schema.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Commands'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Commands.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Commands.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Commands.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Commands.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Database_for_Synonyms'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Database_for_Synonyms.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Database_for_Synonyms.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Database_for_Synonyms.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Database_for_Synonyms.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DBServerConfig'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DBServerConfig.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DBServerConfig.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DBServerConfig.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DBServerConfig.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Path'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Path.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Path.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Path.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Path.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub


    Private Sub get_LocalizedNames()
        procA_LocalizedNames_By_GUIDName.Connection = objConnection_Plugin
        procT_LocalizedNames_By_GUIDName.Clear()
        procA_LocalizedNames_By_GUIDName.ClearBeforeFill = False

        get_concrete_LocalizedName(objSemItem_Token_Names_Abfragen.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_Abh_ngigkeiten.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_Basisdaten.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_Beschreibung.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_F_r_das_Datenbankobjekt_notwendig.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_Funktionen.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_Notwendig_f_r.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_Prozeduren.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_Semantic_Items.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_Skript.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_Synonyme.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_Tabellen.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_Trigger.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_DBItem_ChangeDate.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_DBItem_Name.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_DBItem_Type.GUID)
        get_concrete_LocalizedName(objSemItem_Token_Names_Language_Lbl.GUID)

    End Sub

    Public Function get_LocalizedName(ByVal GUID_Name As Guid, ByVal GUID_Language As Guid) As String
        Dim objDRs_Language() As DataRow

        objDRs_Language = procT_LocalizedNames_By_GUIDName.Select("GUID_Name='" & GUID_Name.ToString & "' AND GUID_Language='" & GUID_Language.ToString & "'")
        If objDRs_Language.Count > 0 Then
            Return objDRs_Language(0).Item("Name_LocalizedName")
        Else
            Return ""
        End If
    End Function

    Private Sub get_concrete_LocalizedName(ByVal GUID_Name As Guid)
        procA_LocalizedNames_By_GUIDName.Fill(procT_LocalizedNames_By_GUIDName, _
                                              objSemItem_Attribute_Short.GUID, _
                                              objSemItem_Type_Names.GUID, _
                                              objSemItem_Type_Localized_Names.GUID, _
                                              objSemItem_Type_Language.GUID, _
                                              objSemItem_RelationType_contains.GUID, _
                                              objSemItem_RelationType_isWrittenIn.GUID, _
                                              GUID_Name)

    End Sub
End Class

