Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "f40e5133-f876-42c7-ab40-c8c602f8884c"

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
    Private objSemItem_Development As clsSemItem
    Private objSemItem_User As clsSemItem
    Private strFilter As String
    Private intFilter As Integer
    Private strSort As String

    'Attributes
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_Standard As New clsSemItem
    Private objSemItem_Attribute_ASC As New clsSemItem
    Private objSemItem_Attribute_invisible As New clsSemItem
    Private objSemItem_Attribute_Value As New clsSemItem
    Private objSemItem_Attribute_is_Null As New clsSemItem
    Private objSemItem_Attribute_XML_Text As New clsSemItem


    'RelationTypes
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_contains As New clsSemItem
    Private objSemItem_RelationType_is As New clsSemItem
    Private objSemItem_RelationType_located_in As New clsSemItem
    Private objSemItem_RelationType_is_of_Type As New clsSemItem
    Private objSemItem_RelationType_leads As New clsSemItem
    Private objSemItem_RelationType_Formatted_by As New clsSemItem
    Private objSemItem_RelationType_Type_Field As New clsSemItem
    Private objSemItem_RelationType_connected_by As New clsSemItem
    Private objSemItem_RelationType_Table_Config As New clsSemItem
    Private objSemItem_RelationType_Row_Config As New clsSemItem
    Private objSemItem_RelationType_Cell_Config As New clsSemItem


    'Types
    Private objSemItem_Type_Database As New clsSemItem
    Private objSemItem_Type_Database_on_Server As New clsSemItem
    Private objSemItem_Type_DB_Procedure As New clsSemItem
    Private objSemItem_Type_DB_Views As New clsSemItem
    Private objSemItem_Type_Reports As New clsSemItem
    Private objSemItem_Type_Server As New clsSemItem
    Private objSemItem_Type_Report_Type As New clsSemItem
    Private objSemItem_Type_Report_Field As New clsSemItem
    Private objSemItem_Type_Field_Type As New clsSemItem
    Private objSemItem_Type_DB_Columns As New clsSemItem
    Private objSemItem_Type_File As New clsSemItem
    Private objSemItem_Type_Field_Format As New clsSemItem
    Private objSemItem_Type_Report_Sort As New clsSemItem
    Private objSemItem_Type_Comparison_Operators As New clsSemItem
    Private objSemItem_Type_Logical_Operators As New clsSemItem
    Private objSemItem_Type_Report_Filter As New clsSemItem
    Private objSemItem_Type_Password As New clsSemItem
    Private objSemItem_Type_Url As New clsSemItem
    Private objSemItem_Type_Path As New clsSemItem
    Private objSemItem_Type_XML_Config As New clsSemItem
    Private objSemItem_Type_Variable As New clsSemItem
    Private objSemItem_Type_XML As New clsSemItem
    Private objSemItem_type_User As New clsSemItem

    
    'Token
    Private objSemItem_Token_Report_Type_View As New clsSemItem
    Private objSemItem_Token_Report_Type_Token_Report As New clsSemItem
    Private objSemItem_Token_Field_Type_Text As New clsSemItem
    Private objSemItem_Token_Field_Type_GUID As New clsSemItem
    Private objSemItem_Token_Field_Type_Zahl As New clsSemItem
    Private objSemItem_Token_Variable_ROW_NAME As New clsSemItem
    Private objSemItem_Token_Variable_ROW_LIST As New clsSemItem
    Private objSemItem_Token_Variable_CELL_VALUE As New clsSemItem
    Private objSemItem_Token_Variable_CELL_NAME As New clsSemItem
    Private objSemItem_Token_Variable_CELL_LIST As New clsSemItem
    Private objSemItem_Token_Variable_id As New clsSemItem
    Private objSemItem_Token_Variable_REPORT_20 As New clsSemItem
    Private objSemItem_Token_Variable_ROWCOUNT As New clsSemItem
    Private objSemItem_Token_Variable_AUTHOR As New clsSemItem
    Private objSemItem_Token_Variable_COLCOUNT As New clsSemItem
    Private objSemItem_Token_Variable_DATETIME_TZ As New clsSemItem

    'Attributes
    Public ReadOnly Property SemItem_attribute_dbPostfix() As clsSemItem
        Get
            Return objSemItem_attribute_dbPostfix
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_invisible() As clsSemItem
        Get
            Return objSemItem_Attribute_invisible
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Standard() As clsSemItem
        Get
            Return objSemItem_Attribute_Standard
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_ASC() As clsSemItem
        Get
            Return objSemItem_Attribute_ASC
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Value() As clsSemItem
        Get
            Return objSemItem_Attribute_Value
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_is_Null() As clsSemItem
        Get
            Return objSemItem_Attribute_is_Null
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_XML_Text() As clsSemItem
        Get
            Return objSemItem_Attribute_XML_Text
        End Get
    End Property


    'RelationTypes
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

    Public ReadOnly Property SemItem_RelationType_is() As clsSemItem
        Get
            Return objSemItem_RelationType_is
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_located_in() As clsSemItem
        Get
            Return objSemItem_RelationType_located_in
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is_of_Type() As clsSemItem
        Get
            Return objSemItem_RelationType_is_of_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_leads() As clsSemItem
        Get
            Return objSemItem_RelationType_leads
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Formatted_by() As clsSemItem
        Get
            Return objSemItem_RelationType_Formatted_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Type_Field() As clsSemItem
        Get
            Return objSemItem_RelationType_Type_Field
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_connected_by() As clsSemItem
        Get
            Return objSemItem_RelationType_connected_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Table_Config() As clsSemItem
        Get
            Return objSemItem_RelationType_Table_Config
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Row_Config() As clsSemItem
        Get
            Return objSemItem_RelationType_Row_Config
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Cell_Config() As clsSemItem
        Get
            Return objSemItem_RelationType_Cell_Config
        End Get
    End Property



    'Types
    Public ReadOnly Property SemItem_Type_Database() As clsSemItem
        Get
            Return objSemItem_Type_Database
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Database_on_Server() As clsSemItem
        Get
            Return objSemItem_Type_Database_on_Server
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DB_Procedure() As clsSemItem
        Get
            Return objSemItem_Type_DB_Procedure
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DB_Views() As clsSemItem
        Get
            Return objSemItem_Type_DB_Views
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Reports() As clsSemItem
        Get
            Return objSemItem_Type_Reports
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Server() As clsSemItem
        Get
            Return objSemItem_Type_Server
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Report_Type() As clsSemItem
        Get
            Return objSemItem_Type_Report_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Report_Field() As clsSemItem
        Get
            Return objSemItem_Type_Report_Field
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Field_Type() As clsSemItem
        Get
            Return objSemItem_Type_Field_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DB_Columns() As clsSemItem
        Get
            Return objSemItem_Type_DB_Columns
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_File() As clsSemItem
        Get
            Return objSemItem_Type_File
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Field_Format() As clsSemItem
        Get
            Return objSemItem_Type_Field_Format
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Report_Sort() As clsSemItem
        Get
            Return objSemItem_Type_Report_Sort
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Comparison_Operators() As clsSemItem
        Get
            Return objSemItem_Type_Comparison_Operators
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Logical_Operators() As clsSemItem
        Get
            Return objSemItem_Type_Logical_Operators
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Report_Filter() As clsSemItem
        Get
            Return objSemItem_Type_Report_Filter
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Password() As clsSemItem
        Get
            Return objSemItem_Type_Password
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Url() As clsSemItem
        Get
            Return objSemItem_Type_Url
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Path() As clsSemItem
        Get
            Return objSemItem_Type_Path
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_XML_Config() As clsSemItem
        Get
            Return objSemItem_Type_XML_Config
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

    Public ReadOnly Property SemItem_type_User() As clsSemItem
        Get
            Return objSemItem_type_User
        End Get
    End Property


    'Token
    Public ReadOnly Property SemItem_Token_Report_Type_View() As clsSemItem
        Get
            Return objSemItem_Token_Report_Type_View
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Report_Type_Token_Report() As clsSemItem
        Get
            Return objSemItem_Token_Report_Type_Token_Report
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Field_Type_Text() As clsSemItem
        Get
            Return objSemItem_Token_Field_Type_Text
        End Get
    End Property
   
    Public ReadOnly Property SemItem_Token_Field_Type_GUID() As clsSemItem
        Get
            Return objSemItem_Token_Field_Type_GUID
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Field_Type_Zahl() As clsSemItem
        Get
            Return objSemItem_Token_Field_Type_Zahl
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ROW_NAME() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ROW_NAME
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ROW_LIST() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ROW_LIST
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_CELL_VALUE() As clsSemItem
        Get
            Return objSemItem_Token_Variable_CELL_VALUE
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_CELL_NAME() As clsSemItem
        Get
            Return objSemItem_Token_Variable_CELL_NAME
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_CELL_LIST() As clsSemItem
        Get
            Return objSemItem_Token_Variable_CELL_LIST
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_id() As clsSemItem
        Get
            Return objSemItem_Token_Variable_id
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_REPORT_20() As clsSemItem
        Get
            Return objSemItem_Token_Variable_REPORT_20
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ROWCOUNT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ROWCOUNT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_AUTHOR() As clsSemItem
        Get
            Return objSemItem_Token_Variable_AUTHOR
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_COLCOUNT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_COLCOUNT
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_DATETIME_TZ() As clsSemItem
        Get
            Return objSemItem_Token_Variable_DATETIME_TZ
        End Get
    End Property


    Public Property SemItem_User As clsSemItem
        Get
            Return objSemItem_User
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_User = value
        End Set
    End Property

    Public Property Filter As String
        Get
            Return strFilter
        End Get
        Set(ByVal value As String)
            strFilter = value
        End Set
    End Property

    Public Property Filter_Type As Integer
        Get
            Return intFilter
        End Get
        Set(ByVal value As Integer)
            intFilter = value
        End Set
    End Property

    Public Property Sort As String
        Get
            Return strSort
        End Get
        Set(ByVal value As String)
            strSort = value
        End Set
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_is_Null'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_is_Null.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_is_Null.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_is_Null.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_is_Null.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Standard'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Standard.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Standard.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Standard.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Standard.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_ASC'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_ASC.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_ASC.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_ASC.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_ASC.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_invisible'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_invisible.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_invisible.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_invisible.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_invisible.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Table_Config'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Table_Config.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Table_Config.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Table_Config.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Row_Config'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Row_Config.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Row_Config.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Row_Config.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Cell_Config'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Cell_Config.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Cell_Config.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Cell_Config.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_connected_by'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_connected_by.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_connected_by.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_connected_by.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If


        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Type_Field'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Type_Field.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Type_Field.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Type_Field.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Formatted_by'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Formatted_by.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Formatted_by.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Formatted_by.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_leads'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_leads.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_leads.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_leads.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_REPORT_20'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_REPORT_20.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_REPORT_20.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_REPORT_20.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_REPORT_20.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ROWCOUNT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ROWCOUNT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ROWCOUNT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ROWCOUNT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ROWCOUNT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_AUTHOR'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_AUTHOR.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_AUTHOR.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_AUTHOR.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_AUTHOR.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_COLCOUNT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_COLCOUNT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_COLCOUNT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_COLCOUNT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_COLCOUNT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ROW_NAME'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ROW_NAME.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ROW_NAME.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ROW_NAME.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ROW_NAME.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Report_Type_View'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Report_Type_View.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Report_Type_View.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Report_Type_View.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Report_Type_View.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Report_Type_Token_Report'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Report_Type_Token_Report.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Report_Type_Token_Report.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Report_Type_Token_Report.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Report_Type_Token_Report.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If


        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Field_Type_Text'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Field_Type_Text.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Field_Type_Text.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Field_Type_Text.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Field_Type_Text.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        

        

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Field_Type_GUID'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Field_Type_GUID.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Field_Type_GUID.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Field_Type_GUID.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Field_Type_GUID.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_XML_Config'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_XML_Config.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_XML_Config.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_XML_Config.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_XML_Config.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Password'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Password.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Password.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Password.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Password.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Report_Filter'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Report_Filter.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Report_Filter.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Report_Filter.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Report_Filter.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Comparison_Operators'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Comparison_Operators.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Comparison_Operators.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Comparison_Operators.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Comparison_Operators.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Logical_Operators'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Logical_Operators.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Logical_Operators.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Logical_Operators.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Logical_Operators.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Report_Sort'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Report_Sort.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Report_Sort.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Report_Sort.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Report_Sort.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Field_Format'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Field_Format.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Field_Format.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Field_Format.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Field_Format.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Reports'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Reports.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Reports.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Reports.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Reports.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Report_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Report_Type.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Report_Type.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Report_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Report_Type.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Report_Field'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Report_Field.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Report_Field.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Report_Field.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Report_Field.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Field_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Field_Type.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Field_Type.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Field_Type.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Field_Type.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_DB_Columns'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_DB_Columns.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_DB_Columns.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_DB_Columns.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_DB_Columns.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Field_Type_Zahl'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Field_Type_Zahl.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Field_Type_Zahl.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Field_Type_Zahl.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Field_Type_Zahl.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub
End Class
