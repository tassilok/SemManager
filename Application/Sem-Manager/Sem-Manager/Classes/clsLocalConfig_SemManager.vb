Public Class clsLocalConfig_SemManager
    Private Const cstr_GUIDToken_Development As String = "bb96e526-e6d7-419f-adf8-fe4fbc12038d"

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

    'Attributes
    Private objSemItem_Attribute_Attribute As New clsSemItem
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_RelationType As New clsSemItem
    Private objSemItem_Attribute_Token As New clsSemItem
    Private objSemItem_Attribute_Type As New clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_is_on As New clsSemItem
    Private objSemItem_RelationType_isInState As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem
    Private objSemItem_RelationType_offers_for As New clsSemItem
    Private objSemItem_RelationType_SourcesLocatedIn As New clsSemItem
    Private objSemItem_RelationType_superordinate As New clsSemItem
    Private objSemItem_RelationType_belonging_Attribute As New clsSemItem
    Private objSemItem_RelationType_belonging_Type As New clsSemItem
    Private objSemItem_RelationType_belonging_Token As New clsSemItem
    Private objSemItem_RelationType_RelationType As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem

    'Token
    Private objSemItem_Token_Filter_Integration_Level As New clsSemItem
    Private objSemItem_Token_Full_Integration_Level As New clsSemItem
    Private objSemItem_Token_Information_Integration_Level As New clsSemItem
    Private objSemItem_Token_Type_Integration_Level As New clsSemItem
    Private objSemItem_Token_Integration_Level_Menu As New clsSemItem

    'Types
    Private objSemItem_type_DevelopmentVersion As New clsSemItem
    Private objSemItem_type_Folder As New clsSemItem
    Private objSemItem_Type_Integration_Level As New clsSemItem
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_Module_Activator As New clsSemItem
    Private objSemItem_Type_Module_Management As New clsSemItem
    Private objSemItem_type_SoftwareDevelopment As New clsSemItem
    Private objSemItem_Type_Sem_Manager As New clsSemItem

    Private objGUID_Development As Guid
    Private objSemItem_BaseConfig As New clsSemItem

    'Attributes
    Public ReadOnly Property SemItem_Attribute_Attribute() As clsSemItem
        Get
            Return objSemItem_Attribute_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_attribute_dbPostfix() As clsSemItem
        Get
            Return objSemItem_attribute_dbPostfix
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_RelationType() As clsSemItem
        Get
            Return objSemItem_Attribute_RelationType
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Token() As clsSemItem
        Get
            Return objSemItem_Attribute_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Type() As clsSemItem
        Get
            Return objSemItem_Attribute_Type
        End Get
    End Property

    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_is_on() As clsSemItem
        Get
            Return objSemItem_RelationType_is_on
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_isInState() As clsSemItem
        Get
            Return objSemItem_RelationType_isInState
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offers_for() As clsSemItem
        Get
            Return objSemItem_RelationType_offers_for
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_SourcesLocatedIn() As clsSemItem
        Get
            Return objSemItem_RelationType_SourcesLocatedIn
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_superordinate() As clsSemItem
        Get
            Return objSemItem_RelationType_superordinate
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_RelationType() As clsSemItem
        Get
            Return objSemItem_RelationType_RelationType
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Attribute() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Type() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Token() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property

    'Token
    Public ReadOnly Property SemItem_Token_Filter_Integration_Level() As clsSemItem
        Get
            Return objSemItem_Token_Filter_Integration_Level
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Full_Integration_Level() As clsSemItem
        Get
            Return objSemItem_Token_Full_Integration_Level
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Information_Integration_Level() As clsSemItem
        Get
            Return objSemItem_Token_Information_Integration_Level
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Integration_Level_Menu() As clsSemItem
        Get
            Return objSemItem_Token_Integration_Level_Menu
        End Get
    End Property

    'Types
    Public ReadOnly Property SemItem_Token_Type_Integration_Level() As clsSemItem
        Get
            Return objSemItem_Token_Type_Integration_Level
        End Get
    End Property

    Public ReadOnly Property SemItem_type_DevelopmentVersion() As clsSemItem
        Get
            Return objSemItem_type_DevelopmentVersion
        End Get
    End Property

    Public ReadOnly Property SemItem_type_Folder() As clsSemItem
        Get
            Return objSemItem_type_Folder
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Integration_Level() As clsSemItem
        Get
            Return objSemItem_Type_Integration_Level
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module_Activator() As clsSemItem
        Get
            Return objSemItem_Type_Module_Activator
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module_Management() As clsSemItem
        Get
            Return objSemItem_Type_Module_Management
        End Get
    End Property

    Public ReadOnly Property SemItem_type_SoftwareDevelopment() As clsSemItem
        Get
            Return objSemItem_type_SoftwareDevelopment
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Sem_Manager() As clsSemItem
        Get
            Return objSemItem_Type_Sem_Manager
        End Get
    End Property

    Public Property Connection_User As SqlClient.SqlConnection
        Get
            Return objConnection_DB
        End Get
        Set(ByVal value As SqlClient.SqlConnection)
            objConnection_DB = value
        End Set
    End Property
    Public ReadOnly Property Connection_Config As SqlClient.SqlConnection
        Get
            Return objConnection_Config
        End Get
    End Property
    Public Property Globals() As clsGlobals
        Get
            Return objGlobals
        End Get
        Set(ByVal value As clsGlobals)
            objGlobals = value
        End Set
    End Property

    Public ReadOnly Property SemItem_BaseConfig As clsSemItem
        Get
            Return objSemItem_BaseConfig
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
        funcA_SoftwareDevelopment_Config.Connection = objConnection_Config

        procA_TokenAttribute_Varchar255.Connection = objConnection_Config

        procA_OR_Attribute_By_GUIDObjectReference.Connection = objConnection_Config
        procA_OR_RelationType_By_GUIDObjectReference.Connection = objConnection_Config
        procA_OR_Token_By_GUID.Connection = objConnection_Config
        procA_OR_Type_By_GUID.Connection = objConnection_Config

        funcA_TokenToken.Connection = objConnection_Config
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Attribute.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Attribute.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Attribute.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Attribute.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_RelationType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_RelationType.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_RelationType.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_RelationType.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_RelationType.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Token.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Token.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Token.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Token.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Type.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Type.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Type.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_is_on'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_is_on.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_is_on.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_is_on.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_offers_for'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_offers_for.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_offers_for.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_offers_for.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_RelationType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_RelationType.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_RelationType.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_RelationType.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Attribute.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Attribute.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Attribute.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Token.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Token.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Token.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Filter_Integration_Level'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Filter_Integration_Level.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Filter_Integration_Level.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Filter_Integration_Level.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Filter_Integration_Level.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Full_Integration_Level'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Full_Integration_Level.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Full_Integration_Level.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Full_Integration_Level.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Full_Integration_Level.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Information_Integration_Level'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Information_Integration_Level.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Information_Integration_Level.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Information_Integration_Level.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Information_Integration_Level.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Type_Integration_Level'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Type_Integration_Level.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Type_Integration_Level.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Type_Integration_Level.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Type_Integration_Level.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Integration_Level_Menu'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Integration_Level_Menu.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Integration_Level_Menu.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Integration_Level_Menu.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Integration_Level_Menu.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objGUID_Development, _
                                                                   objSemItem_RelationType_offered_by.GUID, _
                                                                   objSemItem_Type_Module.GUID).Rows
        If objDRC_Ref.Count > 0 Then
            objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objDRC_Ref(0).Item("GUID_Token_Left"), _
                                                                       objSemItem_RelationType_belongsTo.GUID, _
                                                                       objSemItem_Type_Sem_Manager.GUID).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_BaseConfig.GUID = objDRC_Ref(0).Item("GUID_Token_Left")
                objSemItem_BaseConfig.Name = objDRC_Ref(0).Item("Name_Token_Left")
                objSemItem_BaseConfig.GUID_Parent = objSemItem_Type_Sem_Manager.GUID
                objSemItem_BaseConfig.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Integration_Level'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Integration_Level.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Integration_Level.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Integration_Level.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Integration_Level.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Module_Activator'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Module_Activator.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Module_Activator.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Module_Activator.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Module_Activator.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Module_Management'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Module_Management.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Module_Management.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Module_Management.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Module_Management.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_SoftwareDevelopment'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_SoftwareDevelopment.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_SoftwareDevelopment.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_SoftwareDevelopment.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_SoftwareDevelopment.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If


        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Sem_Manager'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Sem_Manager.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Sem_Manager.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Sem_Manager.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Sem_Manager.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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
    End Sub
End Class
