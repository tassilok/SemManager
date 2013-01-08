Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "16cd3ca4-f19e-418b-9006-4b626d2f3049"

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter

    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter


    Private objGUID_Development As Guid
    Private objSemItem_BaseConfig As New clsSemItem

    'Attributes
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_XML_Text As New clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_belonging_Field_Template As New clsSemItem
    Private objSemItem_RelationType_belonging_Report_Template As New clsSemItem
    Private objSemItem_RelationType_belonging_Row_Template As New clsSemItem
    Private objSemItem_RelationType_belonging_Source As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_contains As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem

    'Token
    Private objSemItem_Token_Variable_CELL_LIST As New clsSemItem
    Private objSemItem_Token_Variable_CELL_NAME As New clsSemItem
    Private objSemItem_Token_Variable_CELL_VALUE As New clsSemItem
    Private objSemItem_Token_Variable_DATETIME_TZ As New clsSemItem
    Private objSemItem_Token_Variable_REPORT As New clsSemItem
    Private objSemItem_Token_Variable_ROW_LIST As New clsSemItem

    'Types
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_Port As New clsSemItem
    Private objSemItem_Type_Server As New clsSemItem
    Private objSemItem_Type_Server_Port As New clsSemItem
    Private objSemItem_Type_Splunk_Connector_Module As New clsSemItem
    Private objSemItem_Type_Variable As New clsSemItem
    Private objSemItem_Type_XML As New clsSemItem


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

    'RelationType
    Public ReadOnly Property SemItem_RelationType_belonging_Field_Template() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Field_Template
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Report_Template() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Report_Template
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Row_Template() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Row_Template
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Source() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Source
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_contains() As clsSemItem
        Get
            Return objSemItem_RelationType_contains
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property


    'Token
    Public ReadOnly Property SemItem_Token_Variable_CELL_LIST() As clsSemItem
        Get
            Return objSemItem_Token_Variable_CELL_LIST
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_CELL_NAME() As clsSemItem
        Get
            Return objSemItem_Token_Variable_CELL_NAME
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_CELL_VALUE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_CELL_VALUE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_DATETIME_TZ() As clsSemItem
        Get
            Return objSemItem_Token_Variable_DATETIME_TZ
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_REPORT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_REPORT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ROW_LIST() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ROW_LIST
        End Get
    End Property

    'Types
    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Port() As clsSemItem
        Get
            Return objSemItem_Type_Port
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Server() As clsSemItem
        Get
            Return objSemItem_Type_Server
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Server_Port() As clsSemItem
        Get
            Return objSemItem_Type_Server_Port
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Splunk_Connector_Module() As clsSemItem
        Get
            Return objSemItem_Type_Splunk_Connector_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Variable() As clsSemItem
        Get
            Return objSemItem_Type_Variable
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_XML() As clsSemItem
        Get
            Return objSemItem_Type_XML
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

    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals
        objConnection_DB = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        objConnection_Config = New SqlClient.SqlConnection(objGlobals.ConnectionString_System)

        objGUID_Development = New Guid(cstr_GUIDToken_Development)

        set_DBConnection()
        get_Config()
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objConnection_DB
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Field_Template'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Field_Template.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Field_Template.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Field_Template.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Report_Template'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Report_Template.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Report_Template.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Report_Template.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Row_Template'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Row_Template.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Row_Template.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Row_Template.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_CELL_LIST'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_CELL_LIST.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_CELL_LIST.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_CELL_LIST.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_CELL_LIST.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_CELL_NAME'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_CELL_NAME.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_CELL_NAME.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_CELL_NAME.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_CELL_NAME.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_CELL_VALUE'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_CELL_VALUE.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_CELL_VALUE.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_CELL_VALUE.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_CELL_VALUE.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_DATETIME_TZ'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_DATETIME_TZ.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_DATETIME_TZ.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_DATETIME_TZ.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_DATETIME_TZ.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_REPORT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_REPORT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_REPORT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_REPORT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_REPORT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ROW_LIST'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ROW_LIST.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ROW_LIST.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ROW_LIST.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ROW_LIST.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        funcA_TokenToken.Connection = objConnection_Config
        objDRC_RelData = funcA_TokenToken.GetData_TokenToken_RightLeft(objGUID_Development, _
                                                                       objSemItem_RelationType_offered_by.GUID, _
                                                                       objSemItem_Type_Module.GUID).Rows
        If objDRC_RelData.Count > 0 Then
            objDRC_RelData = funcA_TokenToken.GetData_TokenToken_RightLeft(objDRC_RelData(0).Item("GUID_Token_Left"), _
                                                                           objSemItem_RelationType_belongsTo.GUID, _
                                                                           objSemItem_Type_Splunk_Connector_Module.GUID).Rows
            If objDRC_RelData.Count > 0 Then
                objSemItem_BaseConfig = New clsSemItem
                objSemItem_BaseConfig.GUID = objDRC_RelData(0).Item("GUID_Token_Left")
                objSemItem_BaseConfig.Name = objDRC_RelData(0).Item("Name_Token_Left")
                objSemItem_BaseConfig.GUID_Parent = objSemItem_Type_Splunk_Connector_Module.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Splunk_Connector_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Splunk_Connector_Module.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Splunk_Connector_Module.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Splunk_Connector_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Splunk_Connector_Module.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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


    End Sub
End Class
