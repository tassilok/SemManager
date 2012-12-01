Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "04816070-c3d0-4570-8e27-9732f48d1c6d"

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

    Private objSemItem_Attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_DateTimeStamp As New clsSemItem
    Private objSemItem_Attribute_Message As New clsSemItem
    Private objSemItem_Attribute_Major As New clsSemItem
    Private objSemItem_Attribute_Minor As New clsSemItem
    Private objSemItem_Attribute_Build As New clsSemItem
    Private objSemItem_Attribute_Revision As New clsSemItem
    Private objSemItem_Attribute_XML_Text As New clsSemItem
    Private objSemItem_Attribute_caption As New clsSemItem
    Private objSemItem_Attribute_ImageID As New clsSemItem
    Private objSemItem_Attribute_Grant As New clsSemItem

    'Types
    Private objSemItem_Type_SoftwareDevelopment As New clsSemItem
    Private objSemItem_Type_DevelopmentVersion As New clsSemItem
    Private objSemItem_Type_LogState As New clsSemItem
    Private objSemItem_Type_User As New clsSemItem
    Private objSemItem_Type_ProgramingLanguage As New clsSemItem
    Private objSemItem_Type_Folder As New clsSemItem
    Private objSemItem_Type_Language As New clsSemItem
    Private objSemItem_Type_LogEntry As New clsSemItem
    Private objSemItem_Type_LocalizedDescription As New clsSemItem
    Private objSemItem_Type_DevelopmentConfig As New clsSemItem
    Private objSemItem_Type_DevelopmentConfigItem As New clsSemItem
    Private objSemItem_Type_Development_Structure As New clsSemItem
    Private objSemItem_Type_Process As New clsSemItem
    Private objSemItem_Type_Parameter_Dev_Structure As New clsSemItem
    Private objSemItem_Type_Directions As New clsSemItem
    Private objSemItem_Type_Localized_Names As New clsSemItem
    Private objSemItem_Type_DBSchema_Of_Application As New clsSemItem
    Private objSemItem_Type_DB_Schema_Type As New clsSemItem
    Private objSemItem_Type_File As New clsSemItem
    Private objSemItem_Type_Database_on_Server As New clsSemItem
    Private objSemItem_Type_Database As New clsSemItem
    Private objSemItem_Type_Server As New clsSemItem
    Private objSemItem_Type_GUI_Entires As New clsSemItem
    Private objSemItem_Type_GUI_Caption As New clsSemItem
    Private objSemItem_Type_ToolTip_Messages As New clsSemItem
    Private objSemItem_Type_Messages As New clsSemItem
    Private objSemItem_Type_Localized_Message As New clsSemItem
    Private objSemItem_Type_Dev_Structure_Invoke As New clsSemItem
    Private objSemItem_Type_Structure_Type_with_Aspects As New clsSemItem
    Private objSemItem_Type_Structure_Type As New clsSemItem
    Private objSemItem_Type_Structure_Validity As New clsSemItem
    Private objSemItem_Type_Objects As New clsSemItem
    Private objSemItem_Type_Dev_Structure__Process_Type_to_Process_ As New clsSemItem
    Private objSemItem_Type_Dev_Structure As New clsSemItem
    Private objSemItem_Type_Scene As New clsSemItem
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_Development_Libraries As New clsSemItem
    Private objSemItem_Type_Image_Video_Management As New clsSemItem
    Private objSemItem_Type_Sem_Items_to_expot_with_Children As New clsSemItem
    Private objSemItem_Type_Export_Mode As New clsSemItem
    Private objSemItem_Type_Database_Schema As New clsSemItem

    'Token
    Private objSemItem_Token_User As clsSemItem
    Private objSemItem_Token_LogState_Active As New clsSemItem
    Private objSemItem_Token_LogState_Inactive As New clsSemItem
    Private objSemItem_Token_LogState_Open As New clsSemItem
    Private objSemItem_Token_LogState_Changed As New clsSemItem
    Private objSemItem_Token_LogState_Obsolete As New clsSemItem
    Private objSemItem_Token_LogState_Information As New clsSemItem
    Private objSemItem_Token_LogState_Request As New clsSemItem
    Private objSemItem_Token_LogState_VersionChanged As New clsSemItem
    Private objSemItem_Token_LogState_Create As New clsSemItem
    Private objSemItem_Token_LogState_ConfigItemAdded As New clsSemItem
    Private objSemItem_Token_clsLocalConfig_xml_XML As New clsSemItem
    Private objSemItem_Token_Declaration_Configitems_XML As New clsSemItem
    Private objSemItem_Token_Initialize_RelationType__ConfigItem__XML As New clsSemItem
    Private objSemItem_Token_Initialize_Token__ConfigItem__XML As New clsSemItem
    Private objSemItem_Token_Initilize_Attribute__ConfigItem__XML As New clsSemItem
    Private objSemItem_Token_Initilize_Type__ConfigItem__XML As New clsSemItem
    Private objSemItem_Token_Property_ConfigItem_XML As New clsSemItem
    Private objSemItem_Token_Directions_IN As New clsSemItem
    Private objSemItem_Token_Directions_OUT As New clsSemItem
    Private objSemItem_Token_PossibleStates_DevelopmentStandard As New clsSemItem
    Private objSemItem_Token_Variable_List_Properties As New clsSemItem
    Private objSemItem_Token_Variable_List_Initialize_ConfigItems_Types As New clsSemItem
    Private objSemItem_Token_Variable_List_Initialize_ConfigItems_Token As New clsSemItem
    Private objSemItem_Token_Variable_List_Initialize_ConfigItems_RelationTypes As New clsSemItem
    Private objSemItem_Token_Variable_List_Initialize_ConfigItems_Attributes As New clsSemItem
    Private objSemItem_Token_Variable_List_Declaration_ConfigItems As New clsSemItem
    Private objSemItem_Token_Dev_Structure_Schleife As New clsSemItem
    Private objSemItem_Token_Dev_Structure_Return As New clsSemItem
    Private objSemItem_Token_Dev_Structure_Database As New clsSemItem
    Private objSemItem_Token_Module_Development_Management As New clsSemItem
    Private objSemItem_Token_Export_Mode_Grant_Children_of_Item__Token_of_Type_ As New clsSemItem
    Private objSemItem_Token_Export_Mode_Deny_Only_Children__Token_of_Type_ As New clsSemItem
    Private objSemItem_Token_Export_Mode_Deny_Item_with_Children__Type___Token_ As New clsSemItem
    Private objSemItem_Token_Export_Mode_Normal As New clsSemItem

    Private objSemItem_Token_DB_Schema_Type_User As New clsSemItem
    Private objSemItem_Token_DB_Schema_Type_Module As New clsSemItem
    Private objSemItem_Token_DB_Schema_Type_Config As New clsSemItem

    'RelationType
    Private objSemItem_RelationType_isInState As New clsSemItem
    Private objSemItem_RelationType_isSubordinated As New clsSemItem
    Private objSemItem_RelationType_wasDevelopedBy As New clsSemItem
    Private objSemItem_RelationType_wasCreatedBy As New clsSemItem
    Private objSemItem_RelationType_isWrittenIn As New clsSemItem
    Private objSemItem_RelationType_Standard As New clsSemItem
    Private objSemItem_RelationType_SourcesLocatedIn As New clsSemItem
    Private objSemItem_RelationType_Possible As New clsSemItem
    Private objSemItem_RelationType_Request As New clsSemItem
    Private objSemItem_RelationType_provides As New clsSemItem
    Private objSemItem_RelationType_Happened As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_offers As New clsSemItem
    Private objSemItem_RelationType_additional As New clsSemItem
    Private objSemItem_RelationType_isDescribedBy As New clsSemItem
    Private objSemItem_RelationType_needs As New clsSemItem
    Private objSemItem_RelationType_contains As New clsSemItem
    Private objSemItem_RelationType_works_off As New clsSemItem
    Private objSemItem_RelationType_directed_by As New clsSemItem
    Private objSemItem_RelationType_describes As New clsSemItem
    Private objSemItem_RelationType_alternative_for As New clsSemItem
    Private objSemItem_RelationType_export_to As New clsSemItem
    Private objSemItem_RelationType_is_of_Type As New clsSemItem
    Private objSemItem_RelationType_located_in As New clsSemItem
    Private objSemItem_RelationType_is_defined_by As New clsSemItem
    Private objSemItem_RelationType_User_Message As New clsSemItem
    Private objSemItem_RelationType_Input_Message As New clsSemItem
    Private objSemItem_RelationType_Error_Message As New clsSemItem
    Private objSemItem_RelationType_superordinate As New clsSemItem
    Private objSemItem_RelationType_invoking_Actor As New clsSemItem
    Private objSemItem_RelationType_invoked_Actor As New clsSemItem
    Private objSemItem_RelationType_access_by As New clsSemItem
    Private objSemItem_RelationType_belonging_Paramter As New clsSemItem
    Private objSemItem_RelationType_is_instance_of As New clsSemItem
    Private objSemItem_RelationType_ignore As New clsSemItem
    Private objSemItem_RelationType_handles As New clsSemItem
    Private objSemItem_RelationType_initializing As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem

    Private objLanguage As clsLanguage

    Private objSemItem_Development As clsSemItem
    Private objSemItem_Folder_ImageVideoManagement As clsSemItem

    Private strPath_ImageVideos As String

    Public Property SemItem_Folder_ImageVideoManagement() As clsSemItem
        Get
            Return objSemItem_Folder_ImageVideoManagement
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_Folder_ImageVideoManagement = value
        End Set
    End Property

    Public Property Path_ImageVideos() As String
        Get
            Return strPath_ImageVideos
        End Get
        Set(ByVal value As String)
            strPath_ImageVideos = value
        End Set
    End Property

    Public ReadOnly Property GUID_Development() As Guid
        Get
            Return New Guid(cstr_GUIDToken_Development)
        End Get
    End Property
    Public ReadOnly Property SemItem_Development() As clsSemItem
        Get
            Return objSemItem_Development
        End Get
    End Property
    Public Property LanguageConfig() As clsLanguage
        Get
            Return objLanguage
        End Get
        Set(ByVal value As clsLanguage)
            objLanguage = value
        End Set
    End Property

    'Types
    Public ReadOnly Property SemItem_Type_DevelopmentVersion() As clsSemItem
        Get
            Return objSemItem_Type_DevelopmentVersion
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_SoftwareDevelopment() As clsSemItem
        Get
            Return objSemItem_Type_SoftwareDevelopment
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_LogState() As clsSemItem
        Get
            Return objSemItem_Type_LogState
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_LogEntry() As clsSemItem
        Get
            Return objSemItem_Type_LogEntry
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_User() As clsSemItem
        Get
            Return objSemItem_Type_User
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_ProgramingLanguage() As clsSemItem
        Get
            Return objSemItem_Type_ProgramingLanguage
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Folder() As clsSemItem
        Get
            Return objSemItem_Type_Folder
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Language() As clsSemItem
        Get
            Return objSemItem_Type_Language
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_LocalizedDescription() As clsSemItem
        Get
            Return objSemItem_Type_LocalizedDescription
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DevelopmentConfig() As clsSemItem
        Get
            Return objSemItem_Type_DevelopmentConfig
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DevelopmentConfigItem() As clsSemItem
        Get
            Return objSemItem_Type_DevelopmentConfigItem
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Development_Structure() As clsSemItem
        Get
            Return objSemItem_Type_Development_Structure
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Process() As clsSemItem
        Get
            Return objSemItem_Type_Process
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Parameter_Dev_Structure() As clsSemItem
        Get
            Return objSemItem_Type_Parameter_Dev_Structure
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Directions() As clsSemItem
        Get
            Return objSemItem_Type_Directions
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Localized_Names() As clsSemItem
        Get
            Return objSemItem_Type_Localized_Names
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DBSchema_Of_Application() As clsSemItem
        Get
            Return objSemItem_Type_DBSchema_Of_Application
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_DB_Schema_Type() As clsSemItem
        Get
            Return objSemItem_Type_DB_Schema_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_File() As clsSemItem
        Get
            Return objSemItem_Type_File
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Database_on_Server() As clsSemItem
        Get
            Return objSemItem_Type_Database_on_Server
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

    Public ReadOnly Property SemItem_Type_GUI_Entires() As clsSemItem
        Get
            Return objSemItem_Type_GUI_Entires
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_GUI_Caption() As clsSemItem
        Get
            Return objSemItem_Type_GUI_Caption
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_ToolTip_Messages() As clsSemItem
        Get
            Return objSemItem_Type_ToolTip_Messages
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Messages() As clsSemItem
        Get
            Return objSemItem_Type_Messages
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Localized_Message() As clsSemItem
        Get
            Return objSemItem_Type_Localized_Message
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Structure_Type_with_Aspects() As clsSemItem
        Get
            Return objSemItem_Type_Structure_Type_with_Aspects
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Structure_Type() As clsSemItem
        Get
            Return objSemItem_Type_Structure_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Structure_Validity() As clsSemItem
        Get
            Return objSemItem_Type_Structure_Validity
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Objects() As clsSemItem
        Get
            Return objSemItem_Type_Objects
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Dev_Structure__Process_Type_to_Process_() As clsSemItem
        Get
            Return objSemItem_Type_Dev_Structure__Process_Type_to_Process_
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Dev_Structure() As clsSemItem
        Get
            Return objSemItem_Type_Dev_Structure
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Scene() As clsSemItem
        Get
            Return objSemItem_Type_Scene
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Development_Libraries() As clsSemItem
        Get
            Return objSemItem_Type_Development_Libraries
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Image_Video_Management() As clsSemItem
        Get
            Return objSemItem_Type_Image_Video_Management
        End Get
    End Property


    Public ReadOnly Property SemItem_Type_Sem_Items_to_expot_with_Children() As clsSemItem
        Get
            Return objSemItem_Type_Sem_Items_to_expot_with_Children
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Export_Mode() As clsSemItem
        Get
            Return objSemItem_Type_Export_Mode
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Database_Schema() As clsSemItem
        Get
            Return objSemItem_Type_Database_Schema
        End Get
    End Property

    'Attributes
    Public ReadOnly Property SemItem_Attribute_dbPostfix() As clsSemItem
        Get
            Return objSemItem_Attribute_dbPostfix
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_DateTimeStamp() As clsSemItem
        Get
            Return objSemItem_Attribute_DateTimeStamp
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Message() As clsSemItem
        Get
            Return objSemItem_Attribute_Message
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Major() As clsSemItem
        Get
            Return objSemItem_Attribute_Major
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Minor() As clsSemItem
        Get
            Return objSemItem_Attribute_Minor
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Build() As clsSemItem
        Get
            Return objSemItem_Attribute_Build
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Revision() As clsSemItem
        Get
            Return objSemItem_Attribute_Revision
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_XML_Text() As clsSemItem
        Get
            Return objSemItem_Attribute_XML_Text
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_caption() As clsSemItem
        Get
            Return objSemItem_Attribute_caption
        End Get
    End Property


    Public ReadOnly Property SemItem_Attribute_ImageID() As clsSemItem
        Get
            Return objSemItem_Attribute_ImageID
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Grant() As clsSemItem
        Get
            Return objSemItem_Attribute_Grant
        End Get
    End Property

    'Token
    Public Property SemItem_Token_User() As clsSemItem
        Get
            Return objSemItem_Token_User
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_Token_User = value
        End Set
    End Property

    Public ReadOnly Property SemItem_Token_LogState_Active() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Active
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_LogState_Inactive() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Inactive
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_LogState_Open() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Open
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_LogState_Changed() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Changed
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_LogState_Obsolete() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Obsolete
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_LogState_Information() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Information
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_LogState_Request() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Request
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_LogState_VersionChanged() As clsSemItem
        Get
            Return objSemItem_Token_LogState_VersionChanged
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_LogState_Create() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Create
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_LogState_ConfigItemAdded() As clsSemItem
        Get
            Return objSemItem_Token_LogState_ConfigItemAdded
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_PossibleStates_DevelopmentStandard() As clsSemItem
        Get
            Return objSemItem_Token_PossibleStates_DevelopmentStandard
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_clsLocalConfig_xml_XML() As clsSemItem
        Get
            Return objSemItem_Token_clsLocalConfig_xml_XML
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Declaration_Configitems_XML() As clsSemItem
        Get
            Return objSemItem_Token_Declaration_Configitems_XML
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Initialize_RelationType__ConfigItem__XML() As clsSemItem
        Get
            Return objSemItem_Token_Initialize_RelationType__ConfigItem__XML
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Initialize_Token__ConfigItem__XML() As clsSemItem
        Get
            Return objSemItem_Token_Initialize_Token__ConfigItem__XML

        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Initilize_Attribute__ConfigItem__XML() As clsSemItem
        Get
            Return objSemItem_Token_Initilize_Attribute__ConfigItem__XML

        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Initilize_Type__ConfigItem__XML() As clsSemItem
        Get
            Return objSemItem_Token_Initilize_Type__ConfigItem__XML

        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Property_ConfigItem_XML() As clsSemItem
        Get
            Return objSemItem_Token_Property_ConfigItem_XML

        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Directions_IN() As clsSemItem
        Get
            Return objSemItem_Token_Directions_IN
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Directions_OUT() As clsSemItem
        Get
            Return objSemItem_Token_Directions_OUT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_DB_Schema_Type_User() As clsSemItem
        Get
            Return objSemItem_Token_DB_Schema_Type_User
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

    Public ReadOnly Property SemItem_Type_Dev_Structure_Invoke() As clsSemItem
        Get
            Return objSemItem_Type_Dev_Structure_Invoke
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_List_Properties() As clsSemItem
        Get
            Return objSemItem_Token_Variable_List_Properties
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_List_Initialize_ConfigItems_Types() As clsSemItem
        Get
            Return objSemItem_Token_Variable_List_Initialize_ConfigItems_Types
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_List_Initialize_ConfigItems_Token() As clsSemItem
        Get
            Return objSemItem_Token_Variable_List_Initialize_ConfigItems_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_List_Initialize_ConfigItems_RelationTypes() As clsSemItem
        Get
            Return objSemItem_Token_Variable_List_Initialize_ConfigItems_RelationTypes
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_List_Initialize_ConfigItems_Attributes() As clsSemItem
        Get
            Return objSemItem_Token_Variable_List_Initialize_ConfigItems_Attributes
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_List_Declaration_ConfigItems() As clsSemItem
        Get
            Return objSemItem_Token_Variable_List_Declaration_ConfigItems
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Dev_Structure_Schleife() As clsSemItem
        Get
            Return objSemItem_Token_Dev_Structure_Schleife
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Dev_Structure_Return() As clsSemItem
        Get
            Return objSemItem_Token_Dev_Structure_Return
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Dev_Structure_Database() As clsSemItem
        Get
            Return objSemItem_Token_Dev_Structure_Database
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Module_Development_Management() As clsSemItem
        Get
            Return objSemItem_Token_Module_Development_Management
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Export_Mode_Grant_Children_of_Item__Token_of_Type_() As clsSemItem
        Get
            Return objSemItem_Token_Export_Mode_Grant_Children_of_Item__Token_of_Type_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Export_Mode_Deny_Only_Children__Token_of_Type_() As clsSemItem
        Get
            Return objSemItem_Token_Export_Mode_Deny_Only_Children__Token_of_Type_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Export_Mode_Deny_Item_with_Children__Type___Token_() As clsSemItem
        Get
            Return objSemItem_Token_Export_Mode_Deny_Item_with_Children__Type___Token_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Export_Mode_Normal() As clsSemItem
        Get
            Return objSemItem_Token_Export_Mode_Normal
        End Get
    End Property

    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_isInState() As clsSemItem
        Get
            Return objSemItem_RelationType_isInState
        End Get
    End Property


    Public ReadOnly Property SemItem_RelationType_isSubordinated() As clsSemItem
        Get
            Return objSemItem_RelationType_isSubordinated
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_wasDevelopedBy() As clsSemItem
        Get
            Return objSemItem_RelationType_wasDevelopedBy
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_wasCreatedBy() As clsSemItem
        Get
            Return objSemItem_RelationType_wasCreatedBy
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_isWrittenIn() As clsSemItem
        Get
            Return objSemItem_RelationType_isWrittenIn
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Standard() As clsSemItem
        Get
            Return objSemItem_RelationType_Standard
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_SourcesLocatedIn() As clsSemItem
        Get
            Return objSemItem_RelationType_SourcesLocatedIn
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_Possible() As clsSemItem
        Get
            Return objSemItem_RelationType_Possible
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_Request() As clsSemItem
        Get
            Return objSemItem_RelationType_Request
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_provides() As clsSemItem
        Get
            Return objSemItem_RelationType_provides
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Happened() As clsSemItem
        Get
            Return objSemItem_RelationType_Happened
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offers() As clsSemItem
        Get
            Return objSemItem_RelationType_offers
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_additional() As clsSemItem
        Get
            Return objSemItem_RelationType_additional
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_isDescribedBy() As clsSemItem
        Get
            Return objSemItem_RelationType_isDescribedBy
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_needs() As clsSemItem
        Get
            Return objSemItem_RelationType_needs
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_contains() As clsSemItem
        Get
            Return objSemItem_RelationType_contains
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_works_off() As clsSemItem
        Get
            Return objSemItem_RelationType_works_off
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_directed_by() As clsSemItem
        Get
            Return objSemItem_RelationType_directed_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_describes() As clsSemItem
        Get
            Return objSemItem_RelationType_describes
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_alternative_for() As clsSemItem
        Get
            Return objSemItem_RelationType_alternative_for
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_export_to() As clsSemItem
        Get
            Return objSemItem_RelationType_export_to
        End Get
    End Property

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

    Public ReadOnly Property SemItem_RelationType_is_defined_by() As clsSemItem
        Get
            Return objSemItem_RelationType_is_defined_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_User_Message() As clsSemItem
        Get
            Return objSemItem_RelationType_User_Message
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Input_Message() As clsSemItem
        Get
            Return objSemItem_RelationType_Input_Message
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Error_Message() As clsSemItem
        Get
            Return objSemItem_RelationType_Error_Message
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_superordinate() As clsSemItem
        Get
            Return objSemItem_RelationType_superordinate
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_access_by() As clsSemItem
        Get
            Return objSemItem_RelationType_access_by
        End Get
    End Property

    Public ReadOnly Property Connection_DB() As SqlClient.SqlConnection
        Get
            Return objConnection_DB
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_invoking_Actor() As clsSemItem
        Get
            Return objSemItem_RelationType_invoking_Actor
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_invoked_Actor() As clsSemItem
        Get
            Return objSemItem_RelationType_invoked_Actor
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Paramter() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Paramter
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is_instance_of() As clsSemItem
        Get
            Return objSemItem_RelationType_is_instance_of
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_ignore() As clsSemItem
        Get
            Return objSemItem_RelationType_ignore
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_handles() As clsSemItem
        Get
            Return objSemItem_RelationType_handles
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_initializing() As clsSemItem
        Get
            Return objSemItem_RelationType_initializing
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property

    Public ReadOnly Property Connection_Plugin() As SqlClient.SqlConnection
        Get
            Return objConnection_Plugin
        End Get
    End Property

    Public ReadOnly Property Connection_Config() As SqlClient.SqlConnection
        Get
            Return objConnection_Config
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
        objSemItem_Development = New clsSemItem
        objSemItem_Development.GUID = New Guid(cstr_GUIDToken_Development)

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
       
        funcA_SoftwareDevelopment_Config.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_Config, objSemItem_Development.GUID)

        get_Config_Attributes()
        get_Config_RelationTypes()
        get_Config_Token()
        get_Config_Types()
        

    End Sub

    Private Sub get_Config_Attributes()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_dbPostfix'")

        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_dbPostfix.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_dbPostfix.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_dbPostfix.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_dbPostfix.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID

                objDRC_RelData = procA_TokenAttribute_Varchar255.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_Development.GUID, objSemItem_Attribute_dbPostfix.GUID).Rows

                objConnection_Plugin = New SqlClient.SqlConnection(objGlobals.get_DB_ConnectionString(objDRC_RelData(0).Item("Val")))
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_caption'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_caption.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_caption.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_caption.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_caption.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_ImageID'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_ImageID.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_ImageID.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_ImageID.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_ImageID.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Grant'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Grant.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Grant.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Grant.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Grant.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_isSubordinated'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_isSubordinated.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_isSubordinated.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_isSubordinated.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_wasDevelopedBy'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_wasDevelopedBy.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_wasDevelopedBy.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_wasDevelopedBy.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Standard'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Standard.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Standard.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Standard.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_SourcesLocatedIn'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_SourcesLocatedIn.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_SourcesLocatedIn.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_SourcesLocatedIn.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Possible'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Possible.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Possible.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Possible.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Request'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Request.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Request.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Request.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Happened'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Happened.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Happened.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Happened.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_offers'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_offers.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_offers.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_offers.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_additional'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_additional.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_additional.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_additional.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_works_off'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_works_off.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_works_off.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_works_off.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_directed_by'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_directed_by.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_directed_by.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_directed_by.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_alternative_for'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_alternative_for.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_alternative_for.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_alternative_for.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_is_defined_by'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_is_defined_by.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_is_defined_by.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_is_defined_by.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_User_Message'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_User_Message.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_User_Message.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_User_Message.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Input_Message'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Input_Message.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Input_Message.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Input_Message.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Error_Message'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Error_Message.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Error_Message.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Error_Message.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_superordinate'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_superordinate.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_superordinate.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_superordinate.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_invoking_Actor'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_invoking_Actor.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_invoking_Actor.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_invoking_Actor.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_invoked_Actor'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_invoked_Actor.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_invoked_Actor.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_invoked_Actor.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_access_by'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_access_by.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_access_by.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_access_by.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Paramter'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Paramter.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Paramter.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Paramter.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_is_instance_of'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_is_instance_of.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_is_instance_of.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_is_instance_of.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_ignore'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_ignore.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_ignore.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_ignore.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_handles'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_handles.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_handles.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_handles.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_initializing'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_initializing.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_initializing.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_initializing.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_Inactive'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_Inactive.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_Inactive.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_Inactive.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_Inactive.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_Open'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_Open.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_Open.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_Open.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_Open.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_Obsolete'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_Obsolete.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_Obsolete.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_Obsolete.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_Obsolete.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_Information'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_Information.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_Information.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_Information.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_Information.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_Request'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_Request.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_Request.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_Request.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_Request.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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


        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_PossibleStates_DevelopmentStandard'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_PossibleStates_DevelopmentStandard.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_PossibleStates_DevelopmentStandard.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_PossibleStates_DevelopmentStandard.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_PossibleStates_DevelopmentStandard.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_ConfigItemAdded'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_ConfigItemAdded.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_ConfigItemAdded.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_ConfigItemAdded.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_ConfigItemAdded.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_clsLocalConfig_xml_XML'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_clsLocalConfig_xml_XML.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_clsLocalConfig_xml_XML.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_clsLocalConfig_xml_XML.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_clsLocalConfig_xml_XML.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Declaration_Configitems_XML'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Declaration_Configitems_XML.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Declaration_Configitems_XML.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Declaration_Configitems_XML.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Declaration_Configitems_XML.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Initialize_RelationType__ConfigItem__XML'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Initialize_RelationType__ConfigItem__XML.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Initialize_RelationType__ConfigItem__XML.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Initialize_RelationType__ConfigItem__XML.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Initialize_RelationType__ConfigItem__XML.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Initialize_Token__ConfigItem__XML'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Initialize_Token__ConfigItem__XML.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Initialize_Token__ConfigItem__XML.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Initialize_Token__ConfigItem__XML.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Initialize_Token__ConfigItem__XML.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Initilize_Attribute__ConfigItem__XML'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Initilize_Attribute__ConfigItem__XML.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Initilize_Attribute__ConfigItem__XML.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Initilize_Attribute__ConfigItem__XML.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Initilize_Attribute__ConfigItem__XML.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Initilize_Type__ConfigItem__XML'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Initilize_Type__ConfigItem__XML.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Initilize_Type__ConfigItem__XML.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Initilize_Type__ConfigItem__XML.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Initilize_Type__ConfigItem__XML.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Property_ConfigItem_XML'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Property_ConfigItem_XML.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Property_ConfigItem_XML.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Property_ConfigItem_XML.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Property_ConfigItem_XML.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Directions_IN'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Directions_IN.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Directions_IN.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Directions_IN.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Directions_IN.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Directions_OUT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Directions_OUT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Directions_OUT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Directions_OUT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Directions_OUT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_List_Properties'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_List_Properties.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_List_Properties.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_List_Properties.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_List_Properties.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_List_Initialize_ConfigItems_Types'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_List_Initialize_ConfigItems_Types.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_List_Initialize_ConfigItems_Types.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_List_Initialize_ConfigItems_Types.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_List_Initialize_ConfigItems_Types.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_List_Initialize_ConfigItems_Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_List_Initialize_ConfigItems_Token.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_List_Initialize_ConfigItems_Token.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_List_Initialize_ConfigItems_Token.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_List_Initialize_ConfigItems_Token.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_List_Initialize_ConfigItems_RelationTypes'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_List_Initialize_ConfigItems_RelationTypes.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_List_Initialize_ConfigItems_RelationTypes.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_List_Initialize_ConfigItems_RelationTypes.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_List_Initialize_ConfigItems_RelationTypes.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_List_Initialize_ConfigItems_Attributes'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_List_Initialize_ConfigItems_Attributes.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_List_Initialize_ConfigItems_Attributes.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_List_Initialize_ConfigItems_Attributes.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_List_Initialize_ConfigItems_Attributes.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_List_Declaration_ConfigItems'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_List_Declaration_ConfigItems.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_List_Declaration_ConfigItems.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_List_Declaration_ConfigItems.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_List_Declaration_ConfigItems.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Dev_Structure_Schleife'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Dev_Structure_Schleife.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Dev_Structure_Schleife.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Dev_Structure_Schleife.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Dev_Structure_Schleife.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Dev_Structure_Return'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Dev_Structure_Return.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Dev_Structure_Return.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Dev_Structure_Return.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Dev_Structure_Return.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Dev_Structure_Database'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Dev_Structure_Database.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Dev_Structure_Database.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Dev_Structure_Database.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Dev_Structure_Database.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Module_Development_Management'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Module_Development_Management.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Module_Development_Management.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Module_Development_Management.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Module_Development_Management.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Export_Mode_Grant_Children_of_Item__Token_of_Type_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Export_Mode_Grant_Children_of_Item__Token_of_Type_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Export_Mode_Grant_Children_of_Item__Token_of_Type_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Export_Mode_Grant_Children_of_Item__Token_of_Type_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Export_Mode_Grant_Children_of_Item__Token_of_Type_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Export_Mode_Deny_Only_Children__Token_of_Type_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Export_Mode_Deny_Only_Children__Token_of_Type_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Export_Mode_Deny_Only_Children__Token_of_Type_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Export_Mode_Deny_Only_Children__Token_of_Type_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Export_Mode_Deny_Only_Children__Token_of_Type_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Export_Mode_Deny_Item_with_Children__Type___Token_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Export_Mode_Deny_Item_with_Children__Type___Token_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Export_Mode_Deny_Item_with_Children__Type___Token_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Export_Mode_Deny_Item_with_Children__Type___Token_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Export_Mode_Deny_Item_with_Children__Type___Token_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Export_Mode_Normal'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Export_Mode_Normal.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Export_Mode_Normal.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Export_Mode_Normal.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Export_Mode_Normal.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_SoftwareDevelopment'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_SoftwareDevelopment.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_SoftwareDevelopment.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_SoftwareDevelopment.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_SoftwareDevelopment.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DevelopmentVersion'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DevelopmentVersion.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DevelopmentVersion.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DevelopmentVersion.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DevelopmentVersion.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Logstate'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_LogState.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_LogState.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_LogState.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_LogState.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_User'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_User.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_User.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_User.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_User.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_ProgramingLanguage'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_ProgramingLanguage.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_ProgramingLanguage.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_ProgramingLanguage.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_ProgramingLanguage.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Folder'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Folder.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Folder.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Folder.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Folder.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Logentry'")
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_LocalizedDescription'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_LocalizedDescription.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_LocalizedDescription.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_LocalizedDescription.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_LocalizedDescription.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DevelopmentConfig'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DevelopmentConfig.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DevelopmentConfig.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DevelopmentConfig.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DevelopmentConfig.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DevelopmentConfigItem'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DevelopmentConfigItem.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DevelopmentConfigItem.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DevelopmentConfigItem.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DevelopmentConfigItem.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Development_Structure'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Development_Structure.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Development_Structure.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Development_Structure.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Development_Structure.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Parameter_Dev_Structure'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Parameter_Dev_Structure.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Parameter_Dev_Structure.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Parameter_Dev_Structure.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Parameter_Dev_Structure.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Process'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Process.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Process.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Process.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Process.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Directions'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Directions.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Directions.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Directions.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Directions.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DBSchema_Of_Application'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DBSchema_Of_Application.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DBSchema_Of_Application.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DBSchema_Of_Application.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DBSchema_Of_Application.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_GUI_Caption'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_GUI_Caption.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_GUI_Caption.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_GUI_Caption.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_GUI_Caption.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_GUI_Entires'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_GUI_Entires.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_GUI_Entires.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_GUI_Entires.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_GUI_Entires.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_ToolTip_Messages'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_ToolTip_Messages.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_ToolTip_Messages.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_ToolTip_Messages.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_ToolTip_Messages.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Localized_Message'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Localized_Message.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Localized_Message.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Localized_Message.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Localized_Message.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Structure_Type_with_Aspects'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Structure_Type_with_Aspects.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Structure_Type_with_Aspects.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Structure_Type_with_Aspects.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Structure_Type_with_Aspects.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        'Token
        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_Active'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_Active.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_Active.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_Active.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_Active.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Messages'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Messages.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Messages.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Messages.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Messages.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Dev_Structure_Invoke'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Dev_Structure_Invoke.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Dev_Structure_Invoke.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Dev_Structure_Invoke.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Dev_Structure_Invoke.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Structure_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Structure_Type.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Structure_Type.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Structure_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Structure_Type.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Structure_Validity'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Structure_Validity.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Structure_Validity.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Structure_Validity.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Structure_Validity.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Objects'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Objects.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Objects.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Objects.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Objects.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Dev_Structure__Process_Type_to_Process_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Dev_Structure__Process_Type_to_Process_.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Dev_Structure__Process_Type_to_Process_.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Dev_Structure__Process_Type_to_Process_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Dev_Structure__Process_Type_to_Process_.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Dev_Structure'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Dev_Structure.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Dev_Structure.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Dev_Structure.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Dev_Structure.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Scene'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Scene.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Scene.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Scene.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Scene.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Development_Libraries'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Development_Libraries.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Development_Libraries.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Development_Libraries.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Development_Libraries.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Image_Video_Management'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Image_Video_Management.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Image_Video_Management.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Image_Video_Management.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Image_Video_Management.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Sem_Items_to_expot_with_Children'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Sem_Items_to_expot_with_Children.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Sem_Items_to_expot_with_Children.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Sem_Items_to_expot_with_Children.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Sem_Items_to_expot_with_Children.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Export_Mode'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Export_Mode.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Export_Mode.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Export_Mode.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Export_Mode.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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


    End Sub

End Class
