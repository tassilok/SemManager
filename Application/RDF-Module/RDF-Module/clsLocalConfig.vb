Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "6655e65d-f4f8-4ef1-9618-3524e0ee94ea"

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

    Private objSemItem_Development As New clsSemItem
    Private objGUID_Development As Guid

    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_XML_Text As New clsSemItem
    Private objSemItem_Attribute_last_Websync As New clsSemItem
    Private objSemItem_Attribute_Sync_necessary As New clsSemItem

    Private objSemItem_RelationType_belonging_Source As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem
    Private objSemItem_RelationType_Ontologies_located_at As New clsSemItem

    Private objSemItem_Token_RDF_Module_Base_Config As New clsSemItem
    Private objSemItem_Token_XML_RDF__Container_Doc As New clsSemItem
    Private objSemItem_Token_Variable_URL_Ontology As New clsSemItem
    Private objSemItem_Token_Variable_Name_Ontology As New clsSemItem
    Private objSemItem_Token_Variable_LIST_ObjectProperties As New clsSemItem
    Private objSemItem_Token_Variable_LIST_Individuals As New clsSemItem
    Private objSemItem_Token_Variable_LIST_Classes As New clsSemItem
    Private objSemItem_Token_Variable_LIST_AnnotationProperties As New clsSemItem
    Private objSemItem_Token_XML_RDF__RelationType As New clsSemItem
    Private objSemItem_Token_Variable_GUID_RelationType As New clsSemItem
    Private objSemItem_Token_Variable_Name_RelationType As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Type As New clsSemItem
    Private objSemItem_Token_Variable_Name_Type As New clsSemItem
    Private objSemItem_Token_XML_RDF__Class As New clsSemItem
    Private objSemItem_Token_Variable_Max As New clsSemItem
    Private objSemItem_Token_Variable_Min As New clsSemItem
    Private objSemItem_Token_XML_RDF__Type_Type As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Type_Right As New clsSemItem
    Private objSemItem_Token_Variable_LIST_Type_Relations As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Attribute As New clsSemItem
    Private objSemItem_Token_Variable_Name_Attribute As New clsSemItem
    Private objSemItem_Token_Variable_NAME_DATATYPE As New clsSemItem
    Private objSemItem_Token_XML_RDF__Attribute As New clsSemItem
    Private objSemItem_Token_Variable_GUID_Token As New clsSemItem
    Private objSemItem_Token_Variable_Val_Attribute As New clsSemItem
    Private objSemItem_Token_XML_RDF__Token_Attribute As New clsSemItem
    Private objSemItem_Token_XML_RDF__Token_Token As New clsSemItem
    Private objSemItem_Token_Variable_LIST_Token_Token As New clsSemItem
    Private objSemItem_Token_Variable_LIST_Token_Attribute As New clsSemItem
    Private objSemItem_Token_XML_RDF__Token As New clsSemItem
    Private objSemItem_Token_Variable_Name_Token As New clsSemItem

    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_Url As New clsSemItem
    Private objSemItem_Type_XML As New clsSemItem
    Private objSemItem_Type_RDF_Module As New clsSemItem
    Private objSemItem_Type_File As New clsSemItem
    Private objSemItem_Type_Ontology As New clsSemItem

    Public ReadOnly Property Semitem_Development As clsSemItem
        Get
            Return objSemItem_Development
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

    Public ReadOnly Property SemItem_Attribute_last_Websync() As clsSemItem
        Get
            Return objSemItem_Attribute_last_Websync
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Sync_necessary() As clsSemItem
        Get
            Return objSemItem_Attribute_Sync_necessary
        End Get
    End Property

    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_belonging_Source() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Source
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Ontologies_located_at() As clsSemItem
        Get
            Return objSemItem_RelationType_Ontologies_located_at
        End Get
    End Property

    'Token
    Public ReadOnly Property SemItem_Token_RDF_Module_Base_Config() As clsSemItem
        Get
            Return objSemItem_Token_RDF_Module_Base_Config
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_RDF__Container_Doc() As clsSemItem
        Get
            Return objSemItem_Token_XML_RDF__Container_Doc
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_URL_Ontology() As clsSemItem
        Get
            Return objSemItem_Token_Variable_URL_Ontology
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Name_Ontology() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Name_Ontology
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_LIST_ObjectProperties() As clsSemItem
        Get
            Return objSemItem_Token_Variable_LIST_ObjectProperties
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_LIST_Individuals() As clsSemItem
        Get
            Return objSemItem_Token_Variable_LIST_Individuals
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_LIST_Classes() As clsSemItem
        Get
            Return objSemItem_Token_Variable_LIST_Classes
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_LIST_AnnotationProperties() As clsSemItem
        Get
            Return objSemItem_Token_Variable_LIST_AnnotationProperties
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_RDF__RelationType() As clsSemItem
        Get
            Return objSemItem_Token_XML_RDF__RelationType
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

    Public ReadOnly Property SemItem_Token_Variable_GUID_Type() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Name_Type() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Name_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_RDF__Class() As clsSemItem
        Get
            Return objSemItem_Token_XML_RDF__Class
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Max() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Max
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Min() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Min
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_RDF__Type_Type() As clsSemItem
        Get
            Return objSemItem_Token_XML_RDF__Type_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Type_Right() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Type_Right
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_LIST_Type_Relations() As clsSemItem
        Get
            Return objSemItem_Token_Variable_LIST_Type_Relations
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Name_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Name_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_NAME_DATATYPE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_NAME_DATATYPE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_RDF__Attribute() As clsSemItem
        Get
            Return objSemItem_Token_XML_RDF__Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_GUID_Token() As clsSemItem
        Get
            Return objSemItem_Token_Variable_GUID_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Val_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Val_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_RDF__Token_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_XML_RDF__Token_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_RDF__Token_Token() As clsSemItem
        Get
            Return objSemItem_Token_XML_RDF__Token_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_LIST_Token_Token() As clsSemItem
        Get
            Return objSemItem_Token_Variable_LIST_Token_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_LIST_Token_Attribute() As clsSemItem
        Get
            Return objSemItem_Token_Variable_LIST_Token_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_RDF__Token() As clsSemItem
        Get
            Return objSemItem_Token_XML_RDF__Token
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_Name_Token() As clsSemItem
        Get
            Return objSemItem_Token_Variable_Name_Token
        End Get
    End Property

    'Types
    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Url() As clsSemItem
        Get
            Return objSemItem_Type_Url
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_XML() As clsSemItem
        Get
            Return objSemItem_Type_XML
        End Get
    End Property


    Public ReadOnly Property SemItem_Type_RDF_Module() As clsSemItem
        Get
            Return objSemItem_Type_RDF_Module
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_File() As clsSemItem
        Get
            Return objSemItem_Type_File
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Ontology() As clsSemItem
        Get
            Return objSemItem_Type_Ontology
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
    End Sub

    Private Sub get_Config()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection
        funcA_SoftwareDevelopment_Config.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_Config, objGUID_Development)

        get_Config_Attributes()
        get_Config_RelationTypes()
        get_Config_Token()
        get_Config_Types()


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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_last_Websync'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_last_Websync.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_last_Websync.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_last_Websync.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_last_Websync.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Sync_necessary'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Sync_necessary.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Sync_necessary.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Sync_necessary.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Sync_necessary.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Ontologies_located_at'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Ontologies_located_at.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Ontologies_located_at.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Ontologies_located_at.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_RDF_Module_Base_Config'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_RDF_Module_Base_Config.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_RDF_Module_Base_Config.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_RDF_Module_Base_Config.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_RDF_Module_Base_Config.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_RDF__Container_Doc'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_RDF__Container_Doc.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_RDF__Container_Doc.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_RDF__Container_Doc.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_RDF__Container_Doc.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_URL_Ontology'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_URL_Ontology.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_URL_Ontology.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_URL_Ontology.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_URL_Ontology.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Name_Ontology'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Name_Ontology.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Name_Ontology.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Name_Ontology.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Name_Ontology.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_LIST_ObjectProperties'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_LIST_ObjectProperties.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_LIST_ObjectProperties.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_LIST_ObjectProperties.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_LIST_ObjectProperties.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_LIST_Individuals'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_LIST_Individuals.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_LIST_Individuals.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_LIST_Individuals.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_LIST_Individuals.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_LIST_Classes'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_LIST_Classes.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_LIST_Classes.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_LIST_Classes.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_LIST_Classes.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_LIST_AnnotationProperties'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_LIST_AnnotationProperties.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_LIST_AnnotationProperties.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_LIST_AnnotationProperties.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_LIST_AnnotationProperties.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_RDF__RelationType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_RDF__RelationType.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_RDF__RelationType.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_RDF__RelationType.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_RDF__RelationType.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_RDF__Class'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_RDF__Class.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_RDF__Class.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_RDF__Class.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_RDF__Class.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_RDF__Type_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_RDF__Type_Type.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_RDF__Type_Type.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_RDF__Type_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_RDF__Type_Type.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_LIST_Type_Relations'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_LIST_Type_Relations.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_LIST_Type_Relations.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_LIST_Type_Relations.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_LIST_Type_Relations.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_RDF__Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_RDF__Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_RDF__Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_RDF__Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_RDF__Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_Val_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_Val_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_Val_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_Val_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_Val_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_RDF__Token_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_RDF__Token_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_RDF__Token_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_RDF__Token_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_RDF__Token_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_RDF__Token_Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_RDF__Token_Token.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_RDF__Token_Token.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_RDF__Token_Token.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_RDF__Token_Token.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_LIST_Token_Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_LIST_Token_Token.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_LIST_Token_Token.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_LIST_Token_Token.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_LIST_Token_Token.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_LIST_Token_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_LIST_Token_Attribute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_LIST_Token_Attribute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_LIST_Token_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_LIST_Token_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_RDF__Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_RDF__Token.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_RDF__Token.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_RDF__Token.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_RDF__Token.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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
    End Sub

    Private Sub get_Config_Types()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_RDF_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_RDF_Module.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_RDF_Module.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_RDF_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_RDF_Module.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Ontology'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Ontology.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Ontology.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Ontology.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Ontology.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub
End Class

