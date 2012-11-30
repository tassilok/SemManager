Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "76bee339-e97c-4d61-9f1b-337d47af96ac"

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection

    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter

    Private funcA_TokenToken1 As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenToken2 As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter


    Private objGUID_Development As Guid
    Private objSemItem_Module As clsSemItem
    Private objSemItem_BaseConfig As clsSemItem
    Private objSemItems_Language() As clsSemItem

    'Attributes
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_Message As New clsSemItem
    Private objSemItem_Attribute_Codepage As New clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_additional As New clsSemItem
    Private objSemItem_RelationType_alternative_for As New clsSemItem
    Private objSemItem_RelationType_describes As New clsSemItem
    Private objSemItem_RelationType_isWrittenIn As New clsSemItem
    Private objSemItem_RelationType_Standard As New clsSemItem
    Private objSemItem_RelationType_isDescribedBy As New clsSemItem
    Private objSemItem_RelationType_contains As New clsSemItem
    Private objSemItem_RelationType_is_defined_by As New clsSemItem
    Private objSemItem_RelationType_offers As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem

    'Types
    Private objSemItem_Type_Language As New clsSemItem
    Private objSemItem_Type_Localized_Names As New clsSemItem
    Private objSemItem_type_LocalizedDescription As New clsSemItem
    Private objSemItem_type_SoftwareDevelopment As New clsSemItem
    Private objSemItem_Type_GUI_Caption As New clsSemItem
    Private objSemItem_Type_ToolTip_Messages As New clsSemItem
    Private objSemItem_Type_GUI_Entires As New clsSemItem
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_Localizing_Module As New clsSemItem


    'Attributes
    Public ReadOnly Property SemItem_Attribute_Message() As clsSemItem
        Get
            Return objSemItem_Attribute_Message
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Codepage() As clsSemItem
        Get
            Return objSemItem_Attribute_Codepage
        End Get
    End Property

    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_additional() As clsSemItem
        Get
            Return objSemItem_RelationType_additional
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_alternative_for() As clsSemItem
        Get
            Return objSemItem_RelationType_alternative_for
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_describes() As clsSemItem
        Get
            Return objSemItem_RelationType_describes
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
    Public ReadOnly Property SemItem_RelationType_isDescribedBy() As clsSemItem
        Get
            Return objSemItem_RelationType_isDescribedBy
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_contains() As clsSemItem
        Get
            Return objSemItem_RelationType_contains
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is_defined_by() As clsSemItem
        Get
            Return objSemItem_RelationType_is_defined_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offers() As clsSemItem
        Get
            Return objSemItem_RelationType_offers
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

    'Types
    Public ReadOnly Property SemItem_Type_Language() As clsSemItem
        Get
            Return objSemItem_Type_Language
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
    Public ReadOnly Property SemItem_type_SoftwareDevelopment() As clsSemItem
        Get
            Return objSemItem_type_SoftwareDevelopment
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

    Public ReadOnly Property SemItem_Type_GUI_Entires() As clsSemItem
        Get
            Return objSemItem_Type_GUI_Entires
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Localizing_Module() As clsSemItem
        Get
            Return objSemItem_Type_Localizing_Module
        End Get
    End Property

    Public ReadOnly Property SemItems_Language As clsSemItem()
        Get
            Return objSemItems_Language
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

        set_DBConnection()
        get_Config()
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken1.Connection = objConnection_Config
        funcA_TokenToken2.Connection = objConnection_DB
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

                objDRC_RelData = procA_TokenAttribute_Varchar255.GetData_By_GUIDAttribute_And_GUIDToken(objGUID_Development, objSemItem_attribute_dbPostfix.GUID).Rows

                objConnection_Plugin = New SqlClient.SqlConnection(objGlobals.get_DB_ConnectionString(objDRC_RelData(0).Item("Val")))
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Codepage'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Codepage.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Codepage.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Codepage.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Codepage.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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
    End Sub

    Private Sub get_Config_Token()
        Dim objDRC_RelData As DataRowCollection
        Dim i As Integer
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objSemItem_Module = Nothing
        objSemItem_BaseConfig = Nothing

        objDRC_RelData = funcA_TokenToken1.GetData_TokenToken_RightLeft(objGUID_Development, _
                                                                       objSemItem_RelationType_offered_by.GUID, _
                                                                       objSemItem_Type_Module.GUID).Rows
        If objDRC_RelData.Count > 0 Then
            objSemItem_Module = New clsSemItem
            objSemItem_Module.GUID = objDRC_RelData(0).Item("GUID_Token_Left")
            objSemItem_Module.Name = objDRC_RelData(0).Item("Name_Token_Left")
            objSemItem_Module.GUID_Parent = objSemItem_Type_Module.GUID
            objSemItem_Module.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

            objDRC_RelData = funcA_TokenToken1.GetData_TokenToken_RightLeft(objSemItem_Module.GUID, _
                                                                           objSemItem_RelationType_belongsTo.GUID, _
                                                                           objSemItem_Type_Localizing_Module.GUID).Rows
            If objDRC_RelData.Count > 0 Then
                objSemItem_BaseConfig = New clsSemItem
                objSemItem_BaseConfig.GUID = objDRC_RelData(0).Item("GUID_Token_Left")
                objSemItem_BaseConfig.Name = objDRC_RelData(0).Item("Name_Token_Left")
                objSemItem_BaseConfig.GUID_Parent = objSemItem_Type_Localizing_Module.GUID
                objSemItem_BaseConfig.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

                objDRC_RelData = funcA_TokenToken2.GetData_TokenToken_LeftRight(objSemItem_BaseConfig.GUID, _
                                                                               objSemItem_RelationType_offers.GUID, _
                                                                               objSemItem_Type_Language.GUID).Rows
                ReDim Preserve objSemItems_Language(objDRC_RelData.Count - 1)

                For i = 0 To objDRC_RelData.Count - 1
                    objSemItems_Language(i) = New clsSemItem
                    objSemItems_Language(i).GUID = objDRC_RelData(i).Item("GUID_Token_Right")
                    objSemItems_Language(i).Name = objDRC_RelData(i).Item("Name_Token_Right")
                    objSemItems_Language(i).GUID_Parent = objSemItem_Type_Language.GUID
                    objSemItems_Language(i).GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
                Next
            End If

        End If
    End Sub

    Private Sub get_Config_Types()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Localizing_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Localizing_Module.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Localizing_Module.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Localizing_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Localizing_Module.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If


    End Sub
End Class

