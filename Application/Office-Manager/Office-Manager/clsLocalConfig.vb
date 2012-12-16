Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "9ad11085-f76c-4d1f-bbb3-136276a89852"

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection

    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter


    Private objGUID_Development As Guid
    Private objSemItem_BaseConfig As clsSemItem

    'Attributes
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_SubDirectory_Templates As New clsSemItem
    Private objSemItem_Attribute_Path As New clsSemItem
    Private objSemItem_Attribute_DateTimeStamp__Change_ As New clsSemItem
    Private objSemItem_Attribute_Seperator As New clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_SourcesLocatedIn As New clsSemItem
    Private objSemItem_RelationType_used_for As New clsSemItem
    Private objSemItem_RelationType_belonging_Document As New clsSemItem
    Private objSemItem_RelationType_is_of_Type As New clsSemItem
    Private objSemItem_RelationType_isDescribedBy As New clsSemItem
    Private objSemItem_RelationType_is As New clsSemItem
    Private objSemItem_RelationType_isSubordinated As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem
    Private objSemItem_RelationType_filtered_by As New clsSemItem
    Private objSemItem_RelationType_belonging_Sem_Item As New clsSemItem
    Private objSemItem_RelationType_RelationType As New clsSemItem
    Private objSemItem_RelationType_belonging_Type As New clsSemItem
    Private objSemItem_RelationType_contains As New clsSemItem
    Private objSemItem_RelationType_belonging_Attribute As New clsSemItem
    Private objSemItem_RelationType_Standard As New clsSemItem

    'Token
    Private objSemItem_Token_Module_Office_Manager As New clsSemItem
    Private objSemItem_Token_Document_Type__managed__Winword_2007_Document As New clsSemItem
    Private objSemItem_Token_Document_Type__managed__Winword_2007_Template As New clsSemItem
    Private objSemItem_Token_ContentType_Name As New clsSemItem
    Private objSemItem_Token_ContentType_Link As New clsSemItem
    Private objSemItem_Token_ContentType_GUID As New clsSemItem
    Private objSemItem_Token_ContentType_DocumentLink As New clsSemItem
    Private objSemItem_Token_ContentType_Content As New clsSemItem
    Private objSemItem_Token_ContentType_Bookmark As New clsSemItem
    Private objSemItem_Token_ContentType_BatItemList As New clsSemItem
    Private objSemItem_Token_Contentformat_MM_yyyy As New clsSemItem
    Private objSemItem_Token_Contentformat_dd_MM_yyyy As New clsSemItem
    Private objSemItem_Token_Extensions_dotx As New clsSemItem
    Private objSemItem_Token_ContentType_Templatefield As New clsSemItem
    Private objSemItem_Token_Extensions_docx As New clsSemItem

    'Types
    Private objSemItem_type_Folder As New clsSemItem
    Private objSemItem_Type_Word_Management As New clsSemItem
    Private objSemItem_Type_Word_Templates As New clsSemItem
    Private objSemItem_Type_File As New clsSemItem
    Private objSemItem_Type_Document_Type__managed_ As New clsSemItem
    Private objSemItem_Type_Extensions As New clsSemItem
    Private objSemItem_Type_Managed_Document As New clsSemItem
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_ContentType As New clsSemItem
    Private objSemItem_Type_ContentObject As New clsSemItem
    Private objSemItem_Type_Contentformat As New clsSemItem
    Private objSemItem_Type_Templatefield As New clsSemItem
    Private objSemItem_Type_Office_Module As New clsSemItem

    Private objSemItem_Development As clsSemItem

    'Attributes
    Public ReadOnly Property SemItem_attribute_dbPostfix() As clsSemItem
        Get
            Return objSemItem_attribute_dbPostfix
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_SubDirectory_Templates() As clsSemItem
        Get
            Return objSemItem_Attribute_SubDirectory_Templates
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Path() As clsSemItem
        Get
            Return objSemItem_Attribute_Path
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_DateTimeStamp__Change_() As clsSemItem
        Get
            Return objSemItem_Attribute_DateTimeStamp__Change_
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Seperator() As clsSemItem
        Get
            Return objSemItem_Attribute_Seperator
        End Get
    End Property

    'RelationTypes
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

    Public ReadOnly Property SemItem_RelationType_used_for() As clsSemItem
        Get
            Return objSemItem_RelationType_used_for
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Document() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Document
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is_of_Type() As clsSemItem
        Get
            Return objSemItem_RelationType_is_of_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_isDescribedBy() As clsSemItem
        Get
            Return objSemItem_RelationType_isDescribedBy
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_is() As clsSemItem
        Get
            Return objSemItem_RelationType_is
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_isSubordinated() As clsSemItem
        Get
            Return objSemItem_RelationType_isSubordinated
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_filtered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_filtered_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_RelationType() As clsSemItem
        Get
            Return objSemItem_RelationType_RelationType
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Type() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_contains() As clsSemItem
        Get
            Return objSemItem_RelationType_contains
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Attribute() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Sem_Item() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Sem_Item
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Standard() As clsSemItem
        Get
            Return objSemItem_RelationType_Standard
        End Get
    End Property

    'Token
    Public ReadOnly Property SemItem_Token_Module_Office_Manager() As clsSemItem
        Get
            Return objSemItem_Token_Module_Office_Manager
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_ContentType_Name() As clsSemItem
        Get
            Return objSemItem_Token_ContentType_Name
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_ContentType_Link() As clsSemItem
        Get
            Return objSemItem_Token_ContentType_Link
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_ContentType_GUID() As clsSemItem
        Get
            Return objSemItem_Token_ContentType_GUID
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_ContentType_DocumentLink() As clsSemItem
        Get
            Return objSemItem_Token_ContentType_DocumentLink
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_ContentType_Content() As clsSemItem
        Get
            Return objSemItem_Token_ContentType_Content
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_ContentType_Bookmark() As clsSemItem
        Get
            Return objSemItem_Token_ContentType_Bookmark
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_ContentType_BatItemList() As clsSemItem
        Get
            Return objSemItem_Token_ContentType_BatItemList
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Contentformat_MM_yyyy() As clsSemItem
        Get
            Return objSemItem_Token_Contentformat_MM_yyyy
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Contentformat_dd_MM_yyyy() As clsSemItem
        Get
            Return objSemItem_Token_Contentformat_dd_MM_yyyy
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Extensions_dotx() As clsSemItem
        Get
            Return objSemItem_Token_Extensions_dotx
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Extensions_docx() As clsSemItem
        Get
            Return objSemItem_Token_Extensions_docx
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_ContentType_Templatefield() As clsSemItem
        Get
            Return objSemItem_Token_ContentType_Templatefield
        End Get
    End Property

    'Types
    Public ReadOnly Property SemItem_Token_Document_Type__managed__Winword_2007_Document() As clsSemItem
        Get
            Return objSemItem_Token_Document_Type__managed__Winword_2007_Document
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Document_Type__managed__Winword_2007_Template() As clsSemItem
        Get
            Return objSemItem_Token_Document_Type__managed__Winword_2007_Template
        End Get
    End Property

    Public ReadOnly Property SemItem_type_Folder() As clsSemItem
        Get
            Return objSemItem_type_Folder
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Word_Management() As clsSemItem
        Get
            Return objSemItem_Type_Word_Management
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Word_Templates() As clsSemItem
        Get
            Return objSemItem_Type_Word_Templates
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_File() As clsSemItem
        Get
            Return objSemItem_Type_File
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Document_Type__managed_() As clsSemItem
        Get
            Return objSemItem_Type_Document_Type__managed_
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Extensions() As clsSemItem
        Get
            Return objSemItem_Type_Extensions
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Managed_Document() As clsSemItem
        Get
            Return objSemItem_Type_Managed_Document
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_ContentType() As clsSemItem
        Get
            Return objSemItem_Type_ContentType
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_ContentObject() As clsSemItem
        Get
            Return objSemItem_Type_ContentObject
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Contentformat() As clsSemItem
        Get
            Return objSemItem_Type_Contentformat
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Templatefield() As clsSemItem
        Get
            Return objSemItem_Type_Templatefield
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Office_Module() As clsSemItem
        Get
            Return objSemItem_Type_Office_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_BaseConfig As clsSemItem
        Get
            Return objSemItem_BaseConfig
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

    Public ReadOnly Property GUID_Development As Guid
        Get
            Return objGUID_Development
        End Get
    End Property

    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals
        objConnection_DB = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        objConnection_Config = New SqlClient.SqlConnection(objGlobals.ConnectionString_System)

        objGUID_Development = New Guid(cstr_GUIDToken_Development)
        objSemItem_Development = New clsSemItem
        objSemItem_Development.GUID = New Guid(cstr_GUIDToken_Development)

        set_DBConnection()
        get_Config()
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objConnection_Config
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_SubDirectory_Templates'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_SubDirectory_Templates.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_SubDirectory_Templates.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_SubDirectory_Templates.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_SubDirectory_Templates.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Path'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Path.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Path.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Path.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Path.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_DateTimeStamp__Change_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_DateTimeStamp__Change_.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_DateTimeStamp__Change_.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_DateTimeStamp__Change_.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_DateTimeStamp__Change_.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_used_for'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_used_for.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_used_for.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_used_for.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Document'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Document.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Document.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Document.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_is'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_is.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_is.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_is.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_filtered_by'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_filtered_by.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_filtered_by.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_filtered_by.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Sem_Item'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Sem_Item.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Sem_Item.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Sem_Item.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

    End Sub

    Private Sub get_Config_Token()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Module_Office_Manager'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Module_Office_Manager.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Module_Office_Manager.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Module_Office_Manager.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Module_Office_Manager.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Document_Type__managed__Winword_2007_Document'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Document_Type__managed__Winword_2007_Document.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Document_Type__managed__Winword_2007_Document.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Document_Type__managed__Winword_2007_Document.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Document_Type__managed__Winword_2007_Document.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Document_Type__managed__Winword_2007_Template'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Document_Type__managed__Winword_2007_Template.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Document_Type__managed__Winword_2007_Template.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Document_Type__managed__Winword_2007_Template.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Document_Type__managed__Winword_2007_Template.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_ContentType_Name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_ContentType_Name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_ContentType_Name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_ContentType_Name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_ContentType_Name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_ContentType_Link'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_ContentType_Link.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_ContentType_Link.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_ContentType_Link.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_ContentType_Link.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_ContentType_GUID'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_ContentType_GUID.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_ContentType_GUID.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_ContentType_GUID.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_ContentType_GUID.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_ContentType_DocumentLink'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_ContentType_DocumentLink.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_ContentType_DocumentLink.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_ContentType_DocumentLink.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_ContentType_DocumentLink.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_ContentType_Content'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_ContentType_Content.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_ContentType_Content.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_ContentType_Content.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_ContentType_Content.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_ContentType_Bookmark'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_ContentType_Bookmark.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_ContentType_Bookmark.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_ContentType_Bookmark.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_ContentType_Bookmark.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_ContentType_BatItemList'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_ContentType_BatItemList.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_ContentType_BatItemList.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_ContentType_BatItemList.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_ContentType_BatItemList.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Contentformat_MM_yyyy'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Contentformat_MM_yyyy.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Contentformat_MM_yyyy.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Contentformat_MM_yyyy.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Contentformat_MM_yyyy.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Contentformat_dd_MM_yyyy'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Contentformat_dd_MM_yyyy.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Contentformat_dd_MM_yyyy.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Contentformat_dd_MM_yyyy.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Contentformat_dd_MM_yyyy.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Extensions_dotx'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Extensions_dotx.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Extensions_dotx.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Extensions_dotx.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Extensions_dotx.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_ContentType_Templatefield'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_ContentType_Templatefield.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_ContentType_Templatefield.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_ContentType_Templatefield.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_ContentType_Templatefield.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Extensions_docx'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Extensions_docx.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Extensions_docx.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Extensions_docx.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Extensions_docx.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If


        objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Token_Module_Office_Manager.GUID, _
                                                                   objSemItem_RelationType_belongsTo.GUID, _
                                                                   objSemItem_Type_Office_Module.GUID).Rows
        If objDRC_Ref.Count > 0 Then
            objSemItem_BaseConfig = New clsSemItem
            objSemItem_BaseConfig.GUID = objDRC_Ref(0).Item("GUID_Token_Left")
            objSemItem_BaseConfig.Name = objDRC_Ref(0).Item("Name_Token_Left")
            objSemItem_BaseConfig.GUID_Parent = objSemItem_Type_Office_Module.GUID
            objSemItem_BaseConfig.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
        Else
            Err.Raise(1, "Config not set")
        End If

    End Sub

    Private Sub get_Config_Types()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_Folder'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_Folder.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_Folder.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_Folder.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_Folder.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Word_Management'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Word_Management.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Word_Management.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Word_Management.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Word_Management.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Word_Templates'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Word_Templates.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Word_Templates.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Word_Templates.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Word_Templates.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Document_Type__managed_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Document_Type__managed_.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Document_Type__managed_.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Document_Type__managed_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Document_Type__managed_.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Extensions'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Extensions.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Extensions.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Extensions.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Extensions.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Managed_Document'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Managed_Document.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Managed_Document.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Managed_Document.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Managed_Document.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_ContentType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_ContentType.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_ContentType.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_ContentType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_ContentType.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_ContentObject'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_ContentObject.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_ContentObject.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_ContentObject.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_ContentObject.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Contentformat'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Contentformat.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Contentformat.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Contentformat.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Contentformat.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Office_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Office_Module.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Office_Module.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Office_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Office_Module.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

    End Sub
End Class
