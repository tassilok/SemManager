Imports System.Net.NetworkInformation
Imports System.Management
Imports System.IO
Imports System.Reflection
Imports System.Text.RegularExpressions
Public Class clsGlobals

    Private objLocalConfig_SemManager As clsLocalConfig_SemManager
    'Private objLocalConfig_ModuleManagement As clsLocalConfig_ModuleManagement
    Private semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private procA_TokenAttribute_By_GUIDType_And_GUIDAttribute As New ds_TokenAttributeTableAdapters.proc_TokenAttribute_By_GUIDType_And_GUIDAttributeTableAdapter
    Private funcA_related_ModuleActivator_With_RelatedObjectReferences As New ds_ModuleManagementTableAdapters.func_ModuleActivator_With_RelatedObjectReferencesTableAdapter
    Private funcT_related_ModuleActivator_With_RelatedObjectReferences As New ds_ModuleManagement.func_ModuleActivator_With_RelatedObjectReferencesDataTable
    Private funcA_related_ModuleActivators_With_RelatedObjectReferenceType As New ds_ModuleManagementTableAdapters.func_ModuleActivator_With_RelatedObjectReferenceTypesTableAdapter
    Private funcT_related_ModuleActivators_With_RelatedObjectReferenceType As New ds_ModuleManagement.func_ModuleActivator_With_RelatedObjectReferenceTypesDataTable
    Private funcA_Modules_With_Rels As New ds_ModuleManagementTableAdapters.func_Modules_With_RelsTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHAR255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter

    Private chngtbl_SemDBs As New ds_Change.chngtbl_DBDataTable
    Private chngtbl_SemDB_System As New ds_Change.chngtbl_DBDataTable
    Private chngqry_SemDB As New ds_ChangeTableAdapters.chngtbl_DBTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semfuncA_Logstates As New ds_logTableAdapters.semfunc_LogStatesTableAdapter
    Private semtblA_AttributeType As New ds_SemDBTableAdapters.semtbl_AttributeTypeTableAdapter
    Private semtblA_ORType As New ds_SemDBTableAdapters.semtbl_ORTypeTableAdapter
    Private semtblT_ORType As New ds_SemDB.semtbl_ORTypeDataTable
    Private funcA_Direction_LeftRight As New ds_TokenTableAdapters.func_Direction_LeftRightTableAdapter
    Private funcA_Direction_RightLeft As New ds_TokenTableAdapters.func_Direction_RightLeftTableAdapter

    Private objDtbl_BatItem As New ds_Config.dtbl_BaseConfigDataTable

    Private objDataRows_BaseConfig() As DataRow

    Private objObjectReferenceType_Attribute As New clsSemItem
    Private objObjectReferenceType_AttributeType As New clsSemItem
    Private objObjectReferenceType_OR_Attribute As New clsSemItem
    Private objObjectReferenceType_OR_AttributeType As New clsSemItem
    Private objObjectReferenceType_OR_RelationType As New clsSemItem
    Private objObjectReferenceType_OR_Token As New clsSemItem
    Private objObjectReferenceType_OR_Token_OR As New clsSemItem
    Private objObjectReferenceType_OR_Token_Attribute_Bit As New clsSemItem
    Private objObjectReferenceType_OR_Token_Attribute_Date As New clsSemItem
    Private objObjectReferenceType_OR_Token_Attribute_Datetime As New clsSemItem
    Private objObjectReferenceType_OR_Token_Attribute_Int As New clsSemItem
    Private objObjectReferenceType_OR_Token_Attribute_Real As New clsSemItem
    Private objObjectReferenceType_OR_Token_Attribute_Time As New clsSemItem
    Private objObjectReferenceType_OR_Token_Attribute_Varchar255 As New clsSemItem
    Private objObjectReferenceType_OR_Token_Attribute_VARCHARMAX As New clsSemItem
    Private objObjectReferenceType_OR_Token_Token As New clsSemItem
    Private objObjectReferenceType_OR_Type As New clsSemItem
    Private objObjectReferenceType_OR_Type_Attribute As New clsSemItem
    Private objObjectReferenceType_OR_Type_Type As New clsSemItem
    Private objObjectReferenceType_Token As New clsSemItem
    Private objObjectReferenceType_Token_OR As New clsSemItem
    Private objObjectReferenceType_Type As New clsSemItem
    Private objObjectReferenceType_Type_OR As New clsSemItem
    Private objObjectReferenceType_RelationType As New clsSemItem
    Private objObjectReferenceType_TypeType As New clsSemItem
    Private objObjectReferenceType_TokenToken As New clsSemItem
    Private objObjectReferenceType_TokenAttributeBit As New clsSemItem
    Private objObjectReferenceType_TokenAttributeDate As New clsSemItem
    Private objObjectReferenceType_TokenAttributeTime As New clsSemItem
    Private objObjectReferenceType_TokenAttributeDateTime As New clsSemItem
    Private objObjectReferenceType_TokenAttributeInt As New clsSemItem
    Private objObjectReferenceType_TokenAttributeReal As New clsSemItem
    Private objObjectReferenceType_TokenAttributeVarchar255 As New clsSemItem
    Private objObjectReferenceType_TokenAttributeVarcharMAX As New clsSemItem
    Private objObjectReferenceType_TypeAttribute As New clsSemItem

    Private objAttributeType_Bool As New clsSemItem
    Private objAttributeType_Date As New clsSemItem
    Private objAttributeType_Datetime As New clsSemItem
    Private objAttributeType_Int As New clsSemItem
    Private objAttributeType_Real As New clsSemItem
    Private objAttributeType_Time As New clsSemItem
    Private objAttributeType_Varchar255 As New clsSemItem
    Private objAttributeType_String As New clsSemItem

    Private objLogState_Success As New clsSemItem
    Private objLogState_Error As New clsSemItem
    Private objLogState_Nothing As New clsSemItem
    Private objLogState_Insert As New clsSemItem
    Private objLogState_Update As New clsSemItem
    Private objLogState_Delete As New clsSemItem
    Private objLogState_Relation As New clsSemItem
    Private objLogState_Exists As New clsSemItem

    Private objSemItem_Computer As clsSemItem

    Private strServer_Name As String
    Private strServer_Instance As String
    Private strName_DB_User As String
    Private strName_DB_System As String
    Private strName_DB_Change As String
    Private strName_User As String
    Private strName_Password As String
    Private strPath_Modules As String
    Private strProcessorID As String
    Private strBaseBoardSerial As String
    Private GUID_Attribute_ProcessorID As Guid
    Private GUID_Attribute_BaseBoardSerial As Guid

    Private objGUID_Direction_LeftRight As Guid
    Private objGUID_Direction_RightLeft As Guid

    Private strConnectionString_User As String
    Private strConnectionString_System As String
    Private strConnectionString_Change As String

    Private boolWindowsAuth As Boolean

    Private strRegEx_GUID As String

    Private objDR_Module As DataRow
    Private boolModules_Exist As Boolean
    Private objModules() As clsModule

    Private intModule_LastIndex As Integer

    Public ReadOnly Property LocalConfig As clsLocalConfig_SemManager
        Get
            Return objLocalConfig_SemManager
        End Get
    End Property
    Public ReadOnly Property SemItem_Computer As clsSemItem
        Get
            Return objSemItem_Computer
        End Get
    End Property
    Public ReadOnly Property GUID_Empty_str() As String
        Get
            Dim objGUID As New Guid

            Return objGUID.ToString
        End Get
    End Property
    Public ReadOnly Property RegEx_GUID() As String
        Get
            Return strRegEx_GUID
        End Get
    End Property

    Public ReadOnly Property loaded_Modules() As clsModule()
        Get
            Return objModules
        End Get
    End Property

    Public ReadOnly Property GUID_Direction_LeftRight() As Guid
        Get
            Return objGUID_Direction_LeftRight
        End Get
    End Property
    Public ReadOnly Property GUID_Direction_RightLeft() As Guid
        Get
            Return objGUID_Direction_RightLeft
        End Get
    End Property

    Public ReadOnly Property LogState_Success() As clsSemItem
        Get
            Return objLogState_Success
        End Get
    End Property
    Public ReadOnly Property LogState_Error() As clsSemItem
        Get
            Return objLogState_Error
        End Get
    End Property
    Public ReadOnly Property LogState_Nothing() As clsSemItem
        Get
            Return objLogState_Nothing
        End Get
    End Property
    Public ReadOnly Property LogState_Insert() As clsSemItem
        Get
            Return objLogState_Insert
        End Get
    End Property
    Public ReadOnly Property LogState_Update() As clsSemItem
        Get
            Return objLogState_Update
        End Get
    End Property
    Public ReadOnly Property LogState_Delete() As clsSemItem
        Get
            Return objLogState_Delete
        End Get
    End Property
    Public ReadOnly Property LogState_Relation() As clsSemItem
        Get
            Return objLogState_Relation
        End Get
    End Property
    Public ReadOnly Property LogState_Exists() As clsSemItem
        Get
            Return objLogState_Exists
        End Get
    End Property
    Public ReadOnly Property DB_Path_User() As String
        Get
            Return DB_Name_User & "@" & Server_Name
        End Get
    End Property
    Public ReadOnly Property SemDB_System() As DataRowCollection
        Get
            Return chngtbl_SemDB_System.Rows
        End Get
    End Property

    Public ReadOnly Property SemDBs_User() As DataRowCollection
        Get
            Return chngtbl_SemDBs.Rows
        End Get
    End Property
    Public ReadOnly Property ObjectReferenceType_Attribute() As clsSemItem
        Get
            Return objObjectReferenceType_Attribute
        End Get
    End Property
    Public ReadOnly Property ObjectReferenceType_AttributeType() As clsSemItem
        Get
            Return objObjectReferenceType_AttributeType
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Attribute() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Attribute
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_AttributeType() As clsSemItem
        Get
            Return objObjectReferenceType_OR_AttributeType
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_RelationType() As clsSemItem
        Get
            Return objObjectReferenceType_OR_RelationType
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Token() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Token
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Token_OR() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Token
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Token_Attribute_Bit() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Token_Attribute_Bit
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Token_Attribute_Date() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Token_Attribute_Date
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Token_Attribute_Datetime() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Token_Attribute_Datetime
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Token_Attribute_Int() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Token_Attribute_Int
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Token_Attribute_Real() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Token_Attribute_Real
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Token_Attribute_Time() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Token_Attribute_Time
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Token_Attribute_Varchar255() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Token_Attribute_Varchar255
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Token_Attribute_VARCHARMAX() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Token_Attribute_VARCHARMAX
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Token_Token() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Token_Token
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Type() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Type
        End Get
    End Property
    Public ReadOnly Property ObjectReferenceType_Type_OR() As clsSemItem
        Get
            Return objObjectReferenceType_Type_OR
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Type_Attribute() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Type_Attribute
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_OR_Type_Type() As clsSemItem
        Get
            Return objObjectReferenceType_OR_Type_Type
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_RelationType() As clsSemItem
        Get
            Return objObjectReferenceType_RelationType
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_Token() As clsSemItem
        Get
            Return objObjectReferenceType_Token
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_Token_OR() As clsSemItem
        Get
            Return objObjectReferenceType_Token_OR
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_TokenAttributeBit() As clsSemItem
        Get
            Return objObjectReferenceType_TokenAttributeBit
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_TokenAttributeDate() As clsSemItem
        Get
            Return objObjectReferenceType_TokenAttributeDate
        End Get
    End Property
    Public ReadOnly Property ObjectReferenceType_TokenAttributeDatetime() As clsSemItem
        Get
            Return objObjectReferenceType_TokenAttributeDateTime
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_TokenAttributeInt() As clsSemItem
        Get
            Return objObjectReferenceType_TokenAttributeInt
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_TokenAttributeReal() As clsSemItem
        Get
            Return objObjectReferenceType_TokenAttributeReal
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_TokenAttributeTime() As clsSemItem
        Get
            Return objObjectReferenceType_TokenAttributeTime
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_TokenAttributeVarchar255() As clsSemItem
        Get
            Return objObjectReferenceType_TokenAttributeVarchar255
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_TokenAttributeVarcharMAX() As clsSemItem
        Get
            Return objObjectReferenceType_TokenAttributeVarcharMAX
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_TokenToken() As clsSemItem
        Get
            Return objObjectReferenceType_TokenToken
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_Type() As clsSemItem
        Get
            Return objObjectReferenceType_Type
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_TypeAttribute() As clsSemItem
        Get
            Return objObjectReferenceType_TypeAttribute
        End Get
    End Property

    Public ReadOnly Property ObjectReferenceType_TypeType() As clsSemItem
        Get
            Return objObjectReferenceType_TypeType
        End Get
    End Property

    Public ReadOnly Property AttributeType_Bool() As clsSemItem
        Get
            Return objAttributeType_Bool
        End Get

    End Property

    Public ReadOnly Property AttributeType_Date() As clsSemItem
        Get
            Return objAttributeType_Date
        End Get

    End Property
    Public ReadOnly Property AttributeType_Datetime() As clsSemItem
        Get
            Return objAttributeType_Datetime
        End Get

    End Property
    Public ReadOnly Property AttributeType_Int() As clsSemItem
        Get
            Return objAttributeType_Int
        End Get

    End Property
    Public ReadOnly Property AttributeType_Real() As clsSemItem
        Get
            Return objAttributeType_Real
        End Get

    End Property
    Public ReadOnly Property AttributeType_Time() As clsSemItem
        Get
            Return objAttributeType_Time
        End Get

    End Property
    Public ReadOnly Property AttributeType_Varchar255() As clsSemItem
        Get
            Return objAttributeType_Varchar255
        End Get

    End Property
    Public ReadOnly Property AttributeType_String() As clsSemItem
        Get
            Return objAttributeType_String
        End Get

    End Property

    Public ReadOnly Property ConnectionString_User() As String
        Get
            Return strConnectionString_User
        End Get
    End Property

    Public Sub set_UserDB(ByVal ConnectionString_User As String)
        strConnectionString_User = ConnectionString_User
        strName_DB_User = strConnectionString_User.Substring(strConnectionString_User.IndexOf("Initial Catalog=") + "Initial Catalog=".Length)
        strName_DB_User = strName_DB_User.Substring(0, strName_DB_User.IndexOf(";"))

    End Sub

    Public ReadOnly Property ConnectionString_System() As String
        Get
            Return strConnectionString_System
        End Get
    End Property
    Public ReadOnly Property ConnectionString_Change() As String
        Get
            Return strConnectionString_Change
        End Get
    End Property

    Public ReadOnly Property Server_Name() As String
        Get
            Return strServer_Name
        End Get
    End Property

    Public ReadOnly Property DB_Name_User() As String
        Get
            Return strName_DB_User
        End Get
    End Property

    Public ReadOnly Property DB_Name_System() As String
        Get
            Return strName_DB_System
        End Get
    End Property
    Public ReadOnly Property Path_Modules() As String
        Get
            Return strPath_Modules
        End Get
    End Property

    Public Function get_DB_ConnectionString(ByVal strDB_Postfix As String) As String
        Dim strConnectionString_DB As String

        strConnectionString_DB = "Data Source=" & _
                   strServer_Name

        If strServer_Instance <> "" Then
            strConnectionString_DB = strConnectionString_DB & "\" & strServer_Instance
        End If

        strConnectionString_DB = strConnectionString_DB & ";Initial Catalog=" & _
                   strName_DB_User & "_" & strDB_Postfix

        If boolWindowsAuth = True Then
            strConnectionString_DB = strConnectionString_DB & ";Integrated Security=True"
        Else
            strConnectionString_DB = strConnectionString_DB & ";Persist Security Info=True;User ID=" & strName_User & ";Password=" & strName_Password
        End If



        Return strConnectionString_DB
    End Function

    Public Function get_DB_ConnectionString(ByVal strServerName As String, ByVal strDatabase As String) As String
        Dim strConnectionString_DB As String


        strConnectionString_DB = "Data Source=" & _
                   strServer_Name

        If strServer_Instance <> "" Then
            strConnectionString_DB = strConnectionString_DB & "\" & strServer_Instance
        End If

        strConnectionString_DB = strConnectionString_DB & ";Initial Catalog=" & _
                   strDatabase

        If boolWindowsAuth = True Then
            strConnectionString_DB = strConnectionString_DB & ";Integrated Security=True"
        Else
            strConnectionString_DB = strConnectionString_DB & ";Persist Security Info=True;User ID=" & strName_User & ";Password=" & strName_Password
        End If

        Return strConnectionString_DB
    End Function
    Public Function is_GUID(ByVal strText As String) As Boolean
        Dim objRegExp As New Regex(strRegEx_GUID)
        If objRegExp.IsMatch(strText) And Not strText = "00000000-0000-0000-0000-000000000000" Then
            Return True
        Else
            Return False
        End If

    End Function
    Private Sub get_LogStates()
        Dim objDRC_LogState As DataRowCollection

        semfuncA_Logstates.Connection = New SqlClient.SqlConnection(ConnectionString_System)

        objDRC_LogState = semfuncA_Logstates.GetData_LogState_Error().Rows
        objLogState_Error.GUID = objDRC_LogState(0).Item("GUID_Token")
        objLogState_Error.Name = objDRC_LogState(0).Item("Name_Token")
        objLogState_Error.GUID_Parent = objDRC_LogState(0).Item("GUID_Type")
        objLogState_Error.GUID_Type = ObjectReferenceType_Token.GUID

        objDRC_LogState = semfuncA_Logstates.GetData_LogState_Nothing().Rows
        objLogState_Nothing.GUID = objDRC_LogState(0).Item("GUID_Token")
        objLogState_Nothing.Name = objDRC_LogState(0).Item("Name_Token")
        objLogState_Nothing.GUID_Parent = objDRC_LogState(0).Item("GUID_Type")
        objLogState_Nothing.GUID_Type = ObjectReferenceType_Token.GUID

        objDRC_LogState = semfuncA_Logstates.GetData_LogState_Success().Rows
        objLogState_Success.GUID = objDRC_LogState(0).Item("GUID_Token")
        objLogState_Success.Name = objDRC_LogState(0).Item("Name_Token")
        objLogState_Success.GUID_Parent = objDRC_LogState(0).Item("GUID_Type")
        objLogState_Success.GUID_Type = ObjectReferenceType_Token.GUID

        objDRC_LogState = semfuncA_Logstates.GetData_LogState_Insert().Rows
        objLogState_Insert.GUID = objDRC_LogState(0).Item("GUID_Token")
        objLogState_Insert.Name = objDRC_LogState(0).Item("Name_Token")
        objLogState_Insert.GUID_Parent = objDRC_LogState(0).Item("GUID_Type")
        objLogState_Insert.GUID_Type = ObjectReferenceType_Token.GUID

        objDRC_LogState = semfuncA_Logstates.GetData_LogState_Update().Rows
        objLogState_Update.GUID = objDRC_LogState(0).Item("GUID_Token")
        objLogState_Update.Name = objDRC_LogState(0).Item("Name_Token")
        objLogState_Update.GUID_Parent = objDRC_LogState(0).Item("GUID_Type")
        objLogState_Update.GUID_Type = ObjectReferenceType_Token.GUID

        objDRC_LogState = semfuncA_Logstates.GetData_LogState_Delete().Rows
        objLogState_Delete.GUID = objDRC_LogState(0).Item("GUID_Token")
        objLogState_Delete.Name = objDRC_LogState(0).Item("Name_Token")
        objLogState_Delete.GUID_Parent = objDRC_LogState(0).Item("GUID_Type")
        objLogState_Delete.GUID_Type = ObjectReferenceType_Token.GUID

        objDRC_LogState = semfuncA_Logstates.GetData_LogState_Relation().Rows
        objLogState_Relation.GUID = objDRC_LogState(0).Item("GUID_Token")
        objLogState_Relation.Name = objDRC_LogState(0).Item("Name_Token")
        objLogState_Relation.GUID_Parent = objDRC_LogState(0).Item("GUID_Type")
        objLogState_Relation.GUID_Type = ObjectReferenceType_Token.GUID

        objDRC_LogState = semfuncA_Logstates.GetData_LogState_Exists().Rows
        objLogState_Exists.GUID = objDRC_LogState(0).Item("GUID_Token")
        objLogState_Exists.Name = objDRC_LogState(0).Item("Name_Token")
        objLogState_Exists.GUID_Parent = objDRC_LogState(0).Item("GUID_Type")
        objLogState_Exists.GUID_Type = ObjectReferenceType_Token.GUID
    End Sub
    Private Sub get_AttributeTypes()
        Dim objDR_AttributeType As DataRow
        objDR_AttributeType = semtblA_AttributeType.GetData_Bool.Rows(0)
        objAttributeType_Bool.GUID = objDR_AttributeType.Item("GUID_AttributeType")
        objAttributeType_Bool.Name = objDR_AttributeType.Item("Name_AttributeType")

        objDR_AttributeType = semtblA_AttributeType.GetData_Date.Rows(0)
        objAttributeType_Date.GUID = objDR_AttributeType.Item("GUID_AttributeType")
        objAttributeType_Date.Name = objDR_AttributeType.Item("Name_AttributeType")

        objDR_AttributeType = semtblA_AttributeType.GetData_Datetime.Rows(0)
        objAttributeType_Datetime.GUID = objDR_AttributeType.Item("GUID_AttributeType")
        objAttributeType_Datetime.Name = objDR_AttributeType.Item("Name_AttributeType")

        objDR_AttributeType = semtblA_AttributeType.GetData_Int.Rows(0)
        objAttributeType_Int.GUID = objDR_AttributeType.Item("GUID_AttributeType")
        objAttributeType_Int.Name = objDR_AttributeType.Item("Name_AttributeType")

        objDR_AttributeType = semtblA_AttributeType.GetData_Real.Rows(0)
        objAttributeType_Real.GUID = objDR_AttributeType.Item("GUID_AttributeType")
        objAttributeType_Real.Name = objDR_AttributeType.Item("Name_AttributeType")

        objDR_AttributeType = semtblA_AttributeType.GetData_String.Rows(0)
        objAttributeType_String.GUID = objDR_AttributeType.Item("GUID_AttributeType")
        objAttributeType_String.Name = objDR_AttributeType.Item("Name_AttributeType")

        objDR_AttributeType = semtblA_AttributeType.GetData_Time.Rows(0)
        objAttributeType_Time.GUID = objDR_AttributeType.Item("GUID_AttributeType")
        objAttributeType_Time.Name = objDR_AttributeType.Item("Name_AttributeType")

        objDR_AttributeType = semtblA_AttributeType.GetData_Varchar255.Rows(0)
        objAttributeType_Varchar255.GUID = objDR_AttributeType.Item("GUID_AttributeType")
        objAttributeType_Varchar255.Name = objDR_AttributeType.Item("Name_AttributeType")

    End Sub
    Private Sub get_ObjectReferenceTypes()
        Dim objDRs_ObjectReferenceType() As DataRow
        Dim objDR_ObjectReferenceType As DataRow
        semtblA_ORType.Connection = New SqlClient.SqlConnection(ConnectionString_System)
        semtblA_ORType.Fill(semtblT_ORType)

        objObjectReferenceType_Attribute.GUID = semtblA_ORType.GUID_ORType_Attribute
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_Attribute.GUID.ToString & "'")
        objObjectReferenceType_Attribute.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_AttributeType.GUID = semtblA_ORType.GUID_ORType_AttributeType
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_AttributeType.GUID.ToString & "'")
        objObjectReferenceType_AttributeType.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Attribute.GUID = semtblA_ORType.GUID_ORType_OR_Attribute
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Attribute.GUID.ToString & "'")
        objObjectReferenceType_OR_Attribute.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_AttributeType.GUID = semtblA_ORType.GUID_ORType_OR_AttributeType
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_AttributeType.GUID.ToString & "'")
        objObjectReferenceType_OR_AttributeType.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_RelationType.GUID = semtblA_ORType.GUID_ORType_OR_RelationType
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_RelationType.GUID.ToString & "'")
        objObjectReferenceType_OR_RelationType.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Token.GUID = semtblA_ORType.GUID_ORType_OR_Token
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Token.GUID.ToString & "'")
        objObjectReferenceType_OR_Token.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_Token_OR.GUID = semtblA_ORType.GUID_ORType_Token_OR
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_Token_OR.GUID.ToString & "'")
        objObjectReferenceType_Token_OR.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Token_Attribute_Bit.GUID = semtblA_ORType.GUID_ORType_OR_Token_Attribute_Bit
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Token_Attribute_Bit.GUID.ToString & "'")
        objObjectReferenceType_OR_Token_Attribute_Bit.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Token_Attribute_Date.GUID = semtblA_ORType.GUID_ORType_OR_Token_Attribute_Date
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Token_Attribute_Date.GUID.ToString & "'")
        objObjectReferenceType_OR_Token_Attribute_Date.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Token_Attribute_Datetime.GUID = semtblA_ORType.GUID_ORType_OR_Token_Attribute_Datetime
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Token_Attribute_Datetime.GUID.ToString & "'")
        objObjectReferenceType_OR_Token_Attribute_Datetime.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Token_Attribute_Int.GUID = semtblA_ORType.GUID_ORType_OR_Token_Attribute_Int
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Token_Attribute_Int.GUID.ToString & "'")
        objObjectReferenceType_OR_Token_Attribute_Int.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Token_Attribute_Real.GUID = semtblA_ORType.GUID_ORType_OR_Token_Attribute_Real
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Token_Attribute_Real.GUID.ToString & "'")
        objObjectReferenceType_OR_Token_Attribute_Real.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Token_Attribute_Time.GUID = semtblA_ORType.GUID_ORType_OR_Token_Attribute_Time
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Token_Attribute_Time.GUID.ToString & "'")
        objObjectReferenceType_OR_Token_Attribute_Time.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Token_Attribute_Varchar255.GUID = semtblA_ORType.GUID_ORType_OR_Token_Attribute_Varchar255
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Token_Attribute_Varchar255.GUID.ToString & "'")
        objObjectReferenceType_OR_Token_Attribute_Varchar255.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Token_Attribute_VARCHARMAX.GUID = semtblA_ORType.GUID_ORType_OR_Token_Attribute_VARCHARMAX
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Token_Attribute_VARCHARMAX.GUID.ToString & "'")
        objObjectReferenceType_OR_Token_Attribute_VARCHARMAX.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Token_Token.GUID = semtblA_ORType.GUID_ORType_OR_Token_Token
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Token_Token.GUID.ToString & "'")
        objObjectReferenceType_OR_Token_Token.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Type.GUID = semtblA_ORType.GUID_ORType_OR_Type
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Type.GUID.ToString & "'")
        objObjectReferenceType_OR_Type.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Type_Attribute.GUID = semtblA_ORType.GUID_ORType_OR_Type_Attribute
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Type_Attribute.GUID.ToString & "'")
        objObjectReferenceType_OR_Type_Attribute.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Type_Type.GUID = semtblA_ORType.GUID_ORType_OR_Type_Type
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Type_Type.GUID.ToString & "'")
        objObjectReferenceType_OR_Type_Type.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_RelationType.GUID = semtblA_ORType.GUID_ORType_RelationType
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_RelationType.GUID.ToString & "'")
        objObjectReferenceType_RelationType.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_Token.GUID = semtblA_ORType.GUID_ORType_Token
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_Token.GUID.ToString & "'")
        objObjectReferenceType_Token.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_TokenAttributeBit.GUID = semtblA_ORType.GUID_ORType_TokenAttributeBit
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_TokenAttributeBit.GUID.ToString & "'")
        objObjectReferenceType_TokenAttributeBit.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_TokenAttributeDate.GUID = semtblA_ORType.GUID_ORType_TokenAttributeDate
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_TokenAttributeDate.GUID.ToString & "'")
        objObjectReferenceType_TokenAttributeDate.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_TokenAttributeDateTime.GUID = semtblA_ORType.GUID_ORType_TokenAttributeDatetime
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_TokenAttributeDateTime.GUID.ToString & "'")
        objObjectReferenceType_TokenAttributeDateTime.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_TokenAttributeInt.GUID = semtblA_ORType.GUID_ORType_TokenAttributeInt
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_TokenAttributeInt.GUID.ToString & "'")
        objObjectReferenceType_TokenAttributeInt.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_TokenAttributeReal.GUID = semtblA_ORType.GUID_ORType_TokenAttributeReal
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_TokenAttributeReal.GUID.ToString & "'")
        objObjectReferenceType_TokenAttributeReal.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_TokenAttributeTime.GUID = semtblA_ORType.GUID_ORType_TokenAttributeTime
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_TokenAttributeTime.GUID.ToString & "'")
        objObjectReferenceType_TokenAttributeTime.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_TokenAttributeVarchar255.GUID = semtblA_ORType.GUID_ORType_TokenAttributeVarchar255
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_TokenAttributeVarchar255.GUID.ToString & "'")
        objObjectReferenceType_TokenAttributeVarchar255.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_TokenAttributeVarcharMAX.GUID = semtblA_ORType.GUID_ORType_TokenAttributeVarcharMAX
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_TokenAttributeVarcharMAX.GUID.ToString & "'")
        objObjectReferenceType_TokenAttributeVarcharMAX.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Token_Token.GUID = semtblA_ORType.GUID_ORType_TokenToken
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Token_Token.GUID.ToString & "'")
        objObjectReferenceType_OR_Token_Token.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Token_OR.GUID = semtblA_ORType.GUID_ORType_Token_OR
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Token_OR.GUID.ToString & "'")
        objObjectReferenceType_OR_Token_OR.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_OR_Type.GUID = semtblA_ORType.GUID_ORType_Type
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_OR_Type.GUID.ToString & "'")
        objObjectReferenceType_OR_Type.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_Type.GUID = semtblA_ORType.GUID_ORType_Type
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_Type.GUID.ToString & "'")
        objObjectReferenceType_Type.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_Type_OR.GUID = semtblA_ORType.GUID_ORType_Type_OR
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_Type_OR.GUID.ToString & "'")
        objObjectReferenceType_Type_OR.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")


        objObjectReferenceType_TypeAttribute.GUID = semtblA_ORType.GUID_ORType_TypeAttribute
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_TypeAttribute.GUID.ToString & "'")
        objObjectReferenceType_TypeAttribute.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")

        objObjectReferenceType_TypeType.GUID = semtblA_ORType.GUID_ORType_TypeType
        objDRs_ObjectReferenceType = semtblT_ORType.Select("GUID_ObjectReferenceType='" & objObjectReferenceType_TypeType.GUID.ToString & "'")
        objObjectReferenceType_TypeType.Name = objDRs_ObjectReferenceType(0).Item("Name_ObjectReferenceType")
    End Sub

    Private Sub get_SemDBs()
        chngqry_SemDB.Connection = New SqlClient.SqlConnection(strConnectionString_Change)
        chngqry_SemDB.Fill_DB_System(chngtbl_SemDB_System)
        chngqry_SemDB.Fill(chngtbl_SemDBs)
    End Sub

    Private Sub get_Directions()
        Dim objDRC_Direction As DataRowCollection

        funcA_Direction_LeftRight.Connection = New SqlClient.SqlConnection(ConnectionString_System)
        funcA_Direction_RightLeft.Connection = New SqlClient.SqlConnection(ConnectionString_System)

        objDRC_Direction = funcA_Direction_LeftRight.GetData().Rows
        objGUID_Direction_LeftRight = objDRC_Direction(0).Item("Direction_LeftRight")

        objDRC_Direction = funcA_Direction_RightLeft.GetData().Rows
        objGUID_Direction_RightLeft = objDRC_Direction(0).Item("Direction_RightLeft")
    End Sub

    Public Sub New(Optional ByVal boolOnlyConnections As Boolean = False, Optional ByVal strPath_Config As String = "")
        Dim objPing As New Ping()
        Dim objPingReplay As PingReply
        Dim objWMI As ManagementObjectSearcher
        Dim objWMIManagementObject As ManagementObject

        strRegEx_GUID = "[A-Za-z0-9]{8}-[A-Za-z0-9]{4}-[A-Za-z0-9]{4}-[A-Za-z0-9]{4}-[A-Za-z0-9]{12}"
        If objDtbl_BatItem.Rows.Count = 0 Then

            If IO.File.Exists(strPath_Config & cstrFileName_Config) = True Then
                objDtbl_BatItem.ReadXml(strPath_Config & cstrFileName_Config)

                objDataRows_BaseConfig = objDtbl_BatItem.Select("ConfigItem_Name='WindowsAuth'")
                If objDataRows_BaseConfig.Length > 0 Then
                    If objDataRows_BaseConfig(0).Item("ConfigItem_Value").ToString.ToLower = "yes" Then
                        boolWindowsAuth = True
                    Else
                        boolWindowsAuth = False
                    End If
                Else
                    Err.Raise(1, "Baseconfig", "Baseconfig not correct")
                End If

                objDataRows_BaseConfig = objDtbl_BatItem.Select("ConfigItem_Name='Server_Instance'")
                If objDataRows_BaseConfig.Length > 0 Then
                    strServer_Instance = objDataRows_BaseConfig(0).Item("ConfigItem_Value")
                Else
                    Err.Raise(1, "Baseconfig", "Baseconfig not correct")
                End If

                objDataRows_BaseConfig = objDtbl_BatItem.Select("ConfigItem_Name='Server_Name'")
                If objDataRows_BaseConfig.Length > 0 Then
                    strServer_Name = objDataRows_BaseConfig(0).Item("ConfigItem_Value")
                    objPingReplay = objPing.Send(strServer_Name)
                    If Not objPingReplay.Status = IPStatus.Success Then
                        Err.Raise(2, "Ping: " & strServer_Name)
                    End If
                Else
                    Err.Raise(1, "Baseconfig", "Baseconfig not correct")
                End If

                objDataRows_BaseConfig = objDtbl_BatItem.Select("ConfigItem_Name='DB_Name_User'")
                If objDataRows_BaseConfig.Length > 0 Then
                    strName_DB_User = objDataRows_BaseConfig(0).Item("ConfigItem_Value")
                Else
                    Err.Raise(1, "Baseconfig", "Baseconfig not correct")
                End If

                objDataRows_BaseConfig = objDtbl_BatItem.Select("ConfigItem_Name='DB_Name_System'")
                If objDataRows_BaseConfig.Length > 0 Then
                    strName_DB_System = objDataRows_BaseConfig(0).Item("ConfigItem_Value")
                Else
                    Err.Raise(1, "Baseconfig", "Baseconfig not correct")
                End If

                objDataRows_BaseConfig = objDtbl_BatItem.Select("ConfigItem_Name='DB_Name_Change'")
                If objDataRows_BaseConfig.Length > 0 Then
                    strName_DB_Change = objDataRows_BaseConfig(0).Item("ConfigItem_Value")
                Else
                    Err.Raise(1, "Baseconfig", "Baseconfig not correct")
                End If

                objDataRows_BaseConfig = objDtbl_BatItem.Select("ConfigItem_Name='Name_User'")
                If objDataRows_BaseConfig.Length > 0 Then
                    strName_User = objDataRows_BaseConfig(0).Item("ConfigItem_Value")
                Else
                    Err.Raise(1, "Baseconfig", "Baseconfig not correct")
                End If

                objDataRows_BaseConfig = objDtbl_BatItem.Select("ConfigItem_Name='Name_Password'")
                If objDataRows_BaseConfig.Length > 0 Then
                    strName_Password = objDataRows_BaseConfig(0).Item("ConfigItem_Value")
                Else
                    Err.Raise(1, "Baseconfig", "Baseconfig not correct")
                End If

                objDataRows_BaseConfig = objDtbl_BatItem.Select("ConfigItem_Name='Module-Path'")
                If objDataRows_BaseConfig.Length > 0 Then
                    strPath_Modules = objDataRows_BaseConfig(0).Item("ConfigItem_Value")
                Else
                    Err.Raise(1, "Baseconfig", "Baseconfig not correct")
                End If

                strConnectionString_User = get_DB_ConnectionString(strServer_Name, strName_DB_User)

                strConnectionString_System = get_DB_ConnectionString(strServer_Name, strName_DB_System)

                strConnectionString_Change = get_DB_ConnectionString(strServer_Name, strName_DB_Change)

                strProcessorID = ""
                strBaseBoardSerial = ""
                objWMI = New ManagementObjectSearcher("Select ProcessorID FROM Win32_Processor")
                For Each objWMIManagementObject In objWMI.Get
                    strProcessorID = objWMIManagementObject("ProcessorID").ToString
                    Exit For
                Next

                objWMI = New ManagementObjectSearcher("SELECT SerialNumber FROM Win32_Baseboard")
                For Each objWMIManagementObject In objWMI.Get
                    strBaseBoardSerial = objWMIManagementObject("SerialNumber").ToString
                    Exit For
                Next

                If boolOnlyConnections = False Then
                    set_DBConnection()
                    get_AttributeTypes()
                    get_ObjectReferenceTypes()
                    get_LogStates()
                    get_Directions()


                End If


                create_Computer()
            End If
        End If
    End Sub

    Private Sub test_Existance_Modules()
        boolModules_Exist = Directory.Exists(strPath_Modules)
    End Sub
    Public Sub get_Modules(ByVal Globals As clsGlobals)
        Dim strFolders() As String
        Dim strFolder As String
        Dim strFile As String
        Dim strPath_Module As String
        Dim objAssembly As Assembly
        Dim objTypes() As Type
        Dim objType As Type
        intModule_LastIndex = 0
        objLocalConfig_SemManager = New clsLocalConfig_SemManager(Globals)
        'objLocalConfig_ModuleManagement = New clsLocalConfig_ModuleManagement(strConnectionString_User, _
        '                                                                      strConnectionString_System, _
        '                                                                      objObjectReferenceType_Attribute.GUID, _
        '                                                                      objObjectReferenceType_RelationType.GUID, _
        '                                                                      objObjectReferenceType_Token.GUID, _
        '                                                                      objObjectReferenceType_Type.GUID, _
        '                                                                      strServer_Name, _
        '                                                                      strName_DB_User)
        test_Existance_Modules()
        If boolModules_Exist = True Then
            strFolders = Directory.GetDirectories(strPath_Modules)
            For Each strFolder In strFolders
                For Each strFile In IO.Directory.GetFiles(strFolder)
                    If strFile.ToLower.EndsWith(".exe") = True Then
                        Try
                            objAssembly = Assembly.LoadFile(strFile)
                            objTypes = objAssembly.GetTypes()
                            For Each objType In objTypes
                                If objType.Name = cstrClass_Module Then
                                    add_Module(objAssembly, objType, Globals)
                                    Exit For
                                End If

                            Next
                        Catch ex As Exception

                        End Try

                    End If
                Next
            Next
        End If

    End Sub
    Private Sub add_Module(ByRef objAssembly As Assembly, ByVal objType As Type, ByVal Globals As clsGlobals)
        Dim objDRC_Module As DataRowCollection
        Dim objModule As clsModule
        Dim objInstance As Object

        Dim objSemItem_IntegrationLevel As New clsSemItem
        Dim boolAdd_Module As Boolean

        boolAdd_Module = True
        Try
            objInstance = objAssembly.CreateInstance(objType.FullName, False)
            objInstance.initialize(Globals)
        Catch ex As Exception
            boolAdd_Module = False
        End Try

        If Not objModules Is Nothing Then
            For Each objModule In objModules
                Try

                    If objInstance.SemItem_Module.GUID = objModule.loaded_Module.SemItem_Module.GUID Then
                        boolAdd_Module = False
                        Exit For
                    End If
                Catch ex As Exception

                End Try
            Next
        End If


        If boolAdd_Module = True Then
            ReDim Preserve objModules(intModule_LastIndex)
            objModules(intModule_LastIndex) = New clsModule(objLocalConfig_SemManager)

            objModules(intModule_LastIndex).Valid = False
            objModules(intModule_LastIndex).Active = False
            Try
                objModules(intModule_LastIndex).loaded_Module = objInstance
                objModules(intModule_LastIndex).Location = objAssembly.Location.Substring(0, objAssembly.Location.LastIndexOf("\"))
                objModules(intModule_LastIndex).SemItem_Module = objModules(intModule_LastIndex).loaded_Module.SemItem_Module
                objModules(intModule_LastIndex).Valid = True


                objDRC_Module = funcA_Modules_With_Rels.GetData_By_GUID_Module(objLocalConfig_SemManager.SemItem_Type_Module.GUID, _
                                                                              objLocalConfig_SemManager.SemItem_Type_Integration_Level.GUID, _
                                                                              objLocalConfig_SemManager.SemItem_type_Folder.GUID, _
                                                                              objLocalConfig_SemManager.SemItem_type_SoftwareDevelopment.GUID, _
                                                                              objLocalConfig_SemManager.SemItem_RelationType_is_on.GUID, _
                                                                              objLocalConfig_SemManager.SemItem_RelationType_SourcesLocatedIn.GUID, _
                                                                              objLocalConfig_SemManager.SemItem_RelationType_offered_by.GUID, _
                                                                              objModules(intModule_LastIndex).GUID_LoadedModule).Rows
                If objDRC_Module.Count = 1 Then
                    objSemItem_IntegrationLevel.GUID = objDRC_Module(0).Item("GUID_IntegrationLevel")
                    objSemItem_IntegrationLevel.Name = objDRC_Module(0).Item("Name_IntegrationLevel")
                    objSemItem_IntegrationLevel.GUID_Parent = objDRC_Module(0).Item("GUID_Type_IntegrationLevel")
                    objSemItem_IntegrationLevel.GUID_Type = ObjectReferenceType_Token.GUID

                    objModules(intModule_LastIndex).IntegrationLevel = objSemItem_IntegrationLevel
                    funcA_related_ModuleActivator_With_RelatedObjectReferences.Fill_By_GUIDModule(funcT_related_ModuleActivator_With_RelatedObjectReferences, _
                                                                                                  objLocalConfig_SemManager.SemItem_Type_Module_Activator.GUID, _
                                                                                                  objLocalConfig_SemManager.SemItem_RelationType_offers_for.GUID, _
                                                                                                  objModules(intModule_LastIndex).GUID_LoadedModule)
                    objModules(intModule_LastIndex).funcT_RelatedObjectReferences = funcT_related_ModuleActivator_With_RelatedObjectReferences
                    funcA_related_ModuleActivators_With_RelatedObjectReferenceType.Fill_By_GUIDModule(funcT_related_ModuleActivators_With_RelatedObjectReferenceType, _
                                                                                                      objLocalConfig_SemManager.SemItem_Type_Module_Activator.GUID, _
                                                                                                      objLocalConfig_SemManager.SemItem_RelationType_offers_for.GUID, _
                                                                                                      objLocalConfig_SemManager.SemItem_Attribute_Type.GUID, _
                                                                                                      objLocalConfig_SemManager.SemItem_Attribute_Token.GUID, _
                                                                                                      objLocalConfig_SemManager.SemItem_Attribute_RelationType.GUID, _
                                                                                                      objLocalConfig_SemManager.SemItem_Attribute_Attribute.GUID, _
                                                                                                      objModules(intModule_LastIndex).GUID_LoadedModule)
                    objModules(intModule_LastIndex).funcT_RelatedObjectReferenceTypes = funcT_related_ModuleActivators_With_RelatedObjectReferenceType
                    objModules(intModule_LastIndex).Active = True
                Else
                    objModules(intModule_LastIndex).Valid = False
                End If
                intModule_LastIndex = objModules.Count

            Catch ex As Exception

            End Try
        End If


    End Sub

    Public Function toogle_Module_Active(ByVal GUID_Module As Guid, ByVal boolActive As Boolean) As Boolean
        Dim objModule As clsModule
        Dim boolResult As Boolean = Nothing
        If Not objModules Is Nothing Then
            For Each objModule In objModules
                If objModule.GUID_LoadedModule = GUID_Module Then
                    objModule.Active = boolActive
                    boolResult = objModule.Active
                End If
            Next
        End If
        Return boolResult
    End Function
    Private Sub set_DBConnection()
        Dim objConnection As SqlClient.SqlConnection

        objConnection = New SqlClient.SqlConnection(ConnectionString_System)
        semtblA_AttributeType.Connection = objConnection
        funcA_Modules_With_Rels.Connection = objConnection
        funcA_related_ModuleActivator_With_RelatedObjectReferences.Connection = objConnection
        funcA_related_ModuleActivators_With_RelatedObjectReferenceType.Connection = objConnection
        semtblA_Attribute.Connection = objConnection
        procA_TokenAttribute_By_GUIDType_And_GUIDAttribute.Connection = objConnection
        semtblA_Type.Connection = objConnection

        semprocA_DBWork_Save_Token.Connection = objConnection
        semprocA_DBWork_Save_TokenAttribute_VARCHAR255.Connection = objConnection
    End Sub

    Private Sub create_Computer()
        Dim objDRC_Computer As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim boolInsert As Boolean

        objSemItem_Computer = New clsSemItem
        objSemItem_Computer.GUID = Guid.NewGuid
        objSemItem_Computer.Name = Environment.MachineName
        objSemItem_Computer.GUID_Parent = semtblA_Type.GUID_Type_Server
        objSemItem_Computer.GUID_Type = ObjectReferenceType_Type.GUID

        GUID_Attribute_ProcessorID = semtblA_Attribute.WMI_ProcessorID
        GUID_Attribute_BaseBoardSerial = semtblA_Attribute.WMI_BaseBoardSerial

        boolInsert = False
        objDRC_Computer = procA_TokenAttribute_By_GUIDType_And_GUIDAttribute.GetData(GUID_Attribute_BaseBoardSerial, objSemItem_Computer.GUID_Parent).Rows
        If objDRC_Computer.Count = 0 Then
            boolInsert = True


        Else
            objSemItem_Computer.GUID = objDRC_Computer(0).Item("GUID_Token")
            objDRC_Computer = procA_TokenAttribute_By_GUIDType_And_GUIDAttribute.GetData(GUID_Attribute_ProcessorID, objSemItem_Computer.GUID_Parent).Rows
            If objDRC_Computer.Count = 0 Then
                boolInsert = True
            Else
                If Not objDRC_Computer(0).Item("GUID_Token") = objSemItem_Computer.GUID Then

                    objSemItem_Computer = Nothing

                End If
            End If

        End If

        If boolInsert = True Then
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Computer.GUID, objSemItem_Computer.Name, objSemItem_Computer.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLogState_Insert.GUID Then
                If Not strBaseBoardSerial = "" Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_Computer.GUID, GUID_Attribute_BaseBoardSerial, Nothing, strBaseBoardSerial, 0).Rows

                End If

                If Not strProcessorID = "" Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_Computer.GUID, GUID_Attribute_ProcessorID, Nothing, strProcessorID, 0).Rows

                End If

            End If

        End If
    End Sub
End Class
