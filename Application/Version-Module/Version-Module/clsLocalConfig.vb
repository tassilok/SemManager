Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "099b3fc1-26f2-4ac9-91d9-5a10e513982e"

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


    Private objGUID_Development As Guid

    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_Build As New clsSemItem
    Private objSemItem_Attribute_Major As New clsSemItem
    Private objSemItem_Attribute_Minor As New clsSemItem
    Private objSemItem_Attribute_Revision As New clsSemItem

    Private objSemItem_type_DevelopmentVersion As New clsSemItem
    Private objSemItem_type_Logstate As New clsSemItem

    Private objSemItem_Token_LogState_VersionChanged As New clsSemItem
    Private objSemItem_Token_LogState_Request As New clsSemItem
    Private objSemItem_Token_LogState_Obsolete As New clsSemItem
    Private objSemItem_Token_LogState_Information As New clsSemItem
    Private objSemItem_Token_LogState_Create As New clsSemItem

    Private objSemItem_RelationType_isInState As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_Happened As New clsSemItem

    Private objSemItem_Development As clsSemItem
    Private objSemItem_User As clsSemItem

    Public ReadOnly Property SemItem_attribute_dbPostfix() As clsSemItem
        Get
            Return objSemItem_attribute_dbPostfix
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_Build() As clsSemItem
        Get
            Return objSemItem_Attribute_Build
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

    Public ReadOnly Property SemItem_Attribute_Revision() As clsSemItem
        Get
            Return objSemItem_Attribute_Revision
        End Get
    End Property

    'Types
    Public ReadOnly Property SemItem_type_DevelopmentVersion() As clsSemItem
        Get
            Return objSemItem_type_DevelopmentVersion
        End Get
    End Property

    Public ReadOnly Property SemItem_type_Logstate() As clsSemItem
        Get
            Return objSemItem_type_Logstate
        End Get
    End Property

    'Token
    Public ReadOnly Property SemItem_Token_LogState_VersionChanged() As clsSemItem
        Get
            Return objSemItem_Token_LogState_VersionChanged
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_LogState_Request() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Request
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
    Public ReadOnly Property SemItem_Token_LogState_Create() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Create
        End Get
    End Property

    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_isInState() As clsSemItem
        Get
            Return objSemItem_RelationType_isInState
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Happened() As clsSemItem
        Get
            Return objSemItem_RelationType_Happened
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

    Public Property SemItem_User() As clsSemItem
        Get
            Return objSemItem_User
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_User = value
        End Set
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
            Else
                Err.Raise(1, "Config not set")
            End If

            objDRC_RelData = procA_TokenAttribute_Varchar255.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_Development.GUID, objSemItem_attribute_dbPostfix.GUID).Rows

            objConnection_Plugin = New SqlClient.SqlConnection(objGlobals.get_DB_ConnectionString(objDRC_RelData(0).Item("Val")))

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
    End Sub

    Private Sub get_Config_Token()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

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
    End Sub
End Class

