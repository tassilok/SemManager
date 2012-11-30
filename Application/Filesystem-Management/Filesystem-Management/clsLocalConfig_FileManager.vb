Imports Sem_Manager
Public Class clsLocalConfig_FileManager
    Private Const cstr_GUIDToken_Development As String = "488fe6a8-ac90-4871-8e3a-598667ba8828"

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection
    Private objConnection_Blob As SqlClient.SqlConnection

    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable

    'Attributes
    Private objSemItem_Attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_Blob As New clsSemItem
    Private objSemItem_Attribute_Datetimestamp__Create_ As New clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_Fileshare As New clsSemItem
    Private objSemItem_RelationType_is_of_Type As New clsSemItem
    Private objSemItem_RelationType_isInState As New clsSemItem
    Private objSemItem_RelationType_isSubordinated As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem
    Private objSemItem_RelationType_ends_with As New clsSemItem
    Private objSemItem_RelationType_watch As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_located_in As New clsSemItem
    Private objSemItem_RelationType_is_checkout_by As New clsSemItem

    'Token
    Private objSemItem_Token_Active_Server_State As New clsSemItem
    Private objSemItem_Token_Fileserver_Server_Type As New clsSemItem
    Private objSemItem_token_LogState_Active As New clsSemItem

    'Types
    Private objSemItem_Type_Filesystem_Management As New clsSemItem
    Private objSemItem_Type_Drive As New clsSemItem
    Private objSemItem_type_Folder As New clsSemItem
    Private objSemItem_Type_File As New clsSemItem
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_Server As New clsSemItem
    Private objSemItem_Type_Server_State As New clsSemItem
    Private objSemItem_Type_Server_Type As New clsSemItem
    Private objSemItem_Type_Extensions As New clsSemItem
    Private objSemItem_Type_BlobDirWatcher As New clsSemItem
    Private objSemItem_Type_Database_on_Server As New clsSemItem
    Private objSemItem_Type_Database As New clsSemItem
    Private objSemItem_Type_Path As New clsSemItem

    Private objGUID_Development As Guid
    Private objSemItem_Development As clsSemItem
    Private objSemItem_BaseConfig As clsSemItem

    Public ReadOnly Property SemItem_Development As clsSemItem
        Get
            Return objSemItem_Development
        End Get
    End Property
    Public ReadOnly Property GUID_Development() As Guid
        Get
            Return New Guid(cstr_GUIDToken_Development)
        End Get
    End Property

    'Attributes
    Public ReadOnly Property SemItem_Attribute_Blob() As clsSemItem
        Get
            Return objSemItem_Attribute_Blob
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Datetimestamp__Create_() As clsSemItem
        Get
            Return objSemItem_Attribute_Datetimestamp__Create_
        End Get
    End Property

    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_Fileshare() As clsSemItem
        Get
            Return objSemItem_RelationType_Fileshare
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is_of_Type() As clsSemItem
        Get
            Return objSemItem_RelationType_is_of_Type
        End Get
    End Property

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
    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_ends_with() As clsSemItem
        Get
            Return objSemItem_RelationType_ends_with
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_watch() As clsSemItem
        Get
            Return objSemItem_RelationType_watch
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_located_in() As clsSemItem
        Get
            Return objSemItem_RelationType_located_in
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is_checkout_by() As clsSemItem
        Get
            Return objSemItem_RelationType_is_checkout_by
        End Get
    End Property

    'Token
    Public ReadOnly Property SemItem_Token_Active_Server_State() As clsSemItem
        Get
            Return objSemItem_Token_Active_Server_State
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Fileserver_Server_Type() As clsSemItem
        Get
            Return objSemItem_Token_Fileserver_Server_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_token_LogState_Active() As clsSemItem
        Get
            Return objSemItem_token_LogState_Active
        End Get
    End Property

    'Types
    Public ReadOnly Property SemItem_Type_Filesystem_Management() As clsSemItem
        Get
            Return objSemItem_Type_Filesystem_Management
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Drive() As clsSemItem
        Get
            Return objSemItem_Type_Drive
        End Get
    End Property

    Public ReadOnly Property SemItem_type_Folder() As clsSemItem
        Get
            Return objSemItem_type_Folder
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_File() As clsSemItem
        Get
            Return objSemItem_Type_File
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Server() As clsSemItem
        Get
            Return objSemItem_Type_Server
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Server_State() As clsSemItem
        Get
            Return objSemItem_Type_Server_State
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Server_Type() As clsSemItem
        Get
            Return objSemItem_Type_Server_Type
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Extensions() As clsSemItem
        Get
            Return objSemItem_Type_Extensions
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_BlobDirWatcher() As clsSemItem
        Get
            Return objSemItem_Type_BlobDirWatcher
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

    Public ReadOnly Property SemItem_Type_Path() As clsSemItem
        Get
            Return objSemItem_Type_Path
        End Get
    End Property


    Public ReadOnly Property SemItem_BaseConfig As clsSemItem
        Get
            Return objSemItem_BaseConfig
        End Get
    End Property


    Public Property Connection_DB() As SqlClient.SqlConnection
        Get
            Return objConnection_DB
        End Get
        Set(ByVal value As SqlClient.SqlConnection)
            Dim objDRC_RelData As DataRowCollection
            objConnection_DB = value
            objDRC_RelData = procA_TokenAttribute_Varchar255.GetData_By_GUIDAttribute_And_GUIDToken(objGUID_Development, objSemItem_Attribute_dbPostfix.GUID).Rows
            objConnection_Plugin = New SqlClient.SqlConnection(objGlobals.get_DB_ConnectionString(objDRC_RelData(0).Item("Val")))
        End Set
    End Property


    Public ReadOnly Property Connection_Plugin() As SqlClient.SqlConnection
        Get
            Return objConnection_Plugin
        End Get
    End Property

    Public ReadOnly Property Connection_Blob() As SqlClient.SqlConnection
        Get
            Return objConnection_Blob
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

        funcA_TokenToken.Connection = objConnection_Config
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

                objDRC_RelData = procA_TokenAttribute_Varchar255.GetData_By_GUIDAttribute_And_GUIDToken(objGUID_Development, objSemItem_Attribute_dbPostfix.GUID).Rows

                objConnection_Plugin = New SqlClient.SqlConnection(objGlobals.get_DB_ConnectionString(objDRC_RelData(0).Item("Val")))
            Else
                Err.Raise(1, "Config not set")
            End If
        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Blob'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Blob.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Blob.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Blob.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Blob.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Datetimestamp__Create_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Datetimestamp__Create_.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Datetimestamp__Create_.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Datetimestamp__Create_.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Datetimestamp__Create_.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Fileshare'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Fileshare.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Fileshare.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Fileshare.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_ends_with'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_ends_with.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_ends_with.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_ends_with.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_watch'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_watch.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_watch.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_watch.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_is_checkout_by'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_is_checkout_by.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_is_checkout_by.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_is_checkout_by.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Active_Server_State'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Active_Server_State.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Active_Server_State.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Active_Server_State.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Active_Server_State.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Fileserver_Server_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Fileserver_Server_Type.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Fileserver_Server_Type.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Fileserver_Server_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Fileserver_Server_Type.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='token_LogState_Active'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_token_LogState_Active.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_token_LogState_Active.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_token_LogState_Active.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_token_LogState_Active.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Development.GUID, _
                                                                   objSemItem_RelationType_offered_by.GUID, _
                                                                   objSemItem_Type_Module.GUID).Rows
        If objDRC_Ref.Count > 0 Then
            objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objDRC_Ref(0).Item("GUID_Token_Left"), _
                                                                       objSemItem_RelationType_belongsTo.GUID, _
                                                                       objSemItem_Type_BlobDirWatcher.GUID).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_BaseConfig = New clsSemItem
                objSemItem_BaseConfig.GUID = objDRC_Ref(0).Item("GUID_Token_Left")
                objSemItem_BaseConfig.Name = objDRC_Ref(0).Item("Name_Token_Left")
                objSemItem_BaseConfig.GUID_Parent = objSemItem_Type_BlobDirWatcher.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Drive'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Drive.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Drive.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Drive.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Drive.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Filesystem_Management'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Filesystem_Management.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Filesystem_Management.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Filesystem_Management.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Filesystem_Management.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Server_State'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Server_State.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Server_State.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Server_State.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Server_State.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Server_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Server_Type.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Server_Type.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Server_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Server_Type.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_BlobDirWatcher'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_BlobDirWatcher.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_BlobDirWatcher.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_BlobDirWatcher.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_BlobDirWatcher.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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
    Private Sub get_Config()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection
        funcA_SoftwareDevelopment_Config.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_Config, objGUID_Development)

        get_Config_Attributes()
        get_Config_RelationTypes()
        get_Config_Types()
        get_Config_Token()

        objConnection_Blob = New SqlClient.SqlConnection(objGlobals.get_DB_ConnectionString(objGlobals.Server_Name, objGlobals.DB_Name_User & "_blob"))

        
    End Sub
End Class
