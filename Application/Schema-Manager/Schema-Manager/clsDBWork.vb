Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Management.Common
Imports Filesystem_Management
Imports Sem_Manager
Public Class clsDBWork

    Private Const cstrTSQLVar_Function As String = "@name_function@"
    Private Const cstrTSQLVar_Procedure As String = "@name_procedure@"
    Private Const cstrTSQLVar_Synonym As String = "@synonym_name@"
    Private Const cstrTSQLVar_Table As String = "@name_table@"
    Private Const cstrTSQLVar_Trigger As String = "@trigger_name@"
    Private Const cstrTSQLVar_View As String = "@name_view@"
    Private Const cstrTSQLVar_Schema As String = "@schema_name@"

    Private semtblA_AttributeType_Templ As New ds_SemDBTableAdapters.semtbl_AttributeTypeTableAdapter
    Private semtblA_AttributeTYpe_New As New ds_SemDBTableAdapters.semtbl_AttributeTypeTableAdapter
    Private semtblA_ORType_Templ As New ds_SemDBTableAdapters.semtbl_ORTypeTableAdapter
    Private semtblA_ORType_New As New ds_SemDBTableAdapters.semtbl_ORTypeTableAdapter

    Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private dtblA_Columns As New ds_SchemaManagerTableAdapters.dtbl_ColumnsTableAdapter
    Private dtblT_Columns As New ds_SchemaManager.dtbl_ColumnsDataTable

    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_CreationScript_And_DBItems_Of_DBSchema_BY_GUIDDBSchema As New ds_SchemaManagerTableAdapters.proc_CreationScript_And_DBItems_Of_DBSchema_BY_GUIDDBSchemaTableAdapter
    Private procT_CreationScript_And_DBItems_Of_DBSchema_BY_GUIDDBSchema As New ds_SchemaManager.proc_CreationScript_And_DBItems_Of_DBSchema_BY_GUIDDBSchemaDataTable
    Private funcA_DatabaseSchema_with_Version_and_Logentry As New ds_SchemaManagerTableAdapters.func_DatabaseSchema_with_Version_and_LogentryTableAdapter
    Private procA_Item_in_Schema As New ds_SchemaManagerTableAdapters.proc_Item_in_SchemaTableAdapter
    Private procA_TokenAttribute_VarcharMAX As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter
    Private procA_CreationScript_And_XML_Of_DBItem_By_GUIDDBItem As New ds_SchemaManagerTableAdapters.proc_CreationScript_Of_DBItem_By_GUIDDBItemTableAdapter
    Private procA_TokenAttribute_Int As New ds_TokenAttributeTableAdapters.TokenAttribute_IntTableAdapter
    Private procA_CreationScripts_And_DBItemInSchema_Of_DBSchema_By_GUIDDbSchema As New ds_SchemaManagerTableAdapters.proc_CreationScripts_And_DBItemInSchema_Of_DBSchema_By_GUIDDbSchemaTableAdapter
    Private procT_CreationScripts_And_DBItemInSchema_Of_DBSchema_By_GUIDDbSchema As New ds_SchemaManager.proc_CreationScripts_And_DBItemInSchema_Of_DBSchema_By_GUIDDbSchemaDataTable
    Private procA_CreationScript_Of_DBSchema_GUID_DBSchema_Ordered As New ds_SchemaManagerTableAdapters.proc_CreationScript_Of_DBSchema_GUID_DBSchema_OrderedTableAdapter
    Private funcA_CreationScript_belongsTo_DBSchema As New ds_SchemaManagerTableAdapters.func_CreationScript_belongsTo_DBSchemaTableAdapter
    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter
    Private procA_TokenAttribute_Bit As New ds_TokenAttributeTableAdapters.TokenAttribute_BitTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private procA_Type_OR_By_GUIDType As New ds_ObjectReferenceTableAdapters.proc_Type_OR_By_GUIDTypeTableAdapter
    Private funcA_listExtendedProperties As New ds_SchemaManagerTableAdapters.func_listExtendedPropertiesTableAdapter
    Private chngtblA_DB As New ds_ChangeTableAdapters.chngtbl_DBTableAdapter
    Private procA_SemItems_Of_DatabaseSchema As New ds_SchemaManagerTableAdapters.proc_SemItems_Of_DatabaseSchemaTableAdapter
    Private funcA_SemDatabasesOnServers As New ds_SchemaManagerTableAdapters.func_SemDatabasesOnServersTableAdapter
    Private funcT_SemDatabasesOnServers As New ds_SchemaManager.func_SemDatabasesOnServersDataTable
    Private procA_Creationscript_Of_DBSchema_Work As New ds_SchemaManagerTableAdapters.proc_Creationscript_Of_DBSchema_WorkTableAdapter

    Private typefuncA_Types_With_Attributes_And_Types As New ds_TypeTableAdapters.typefunc_Types_With_Attributes_And_TypesTableAdapter
    Private typefuncA_Types_Rel As New ds_TypeTableAdapters.typefunc_Types_RelTableAdapter

    Private semprocA_DBWork_Save_TokenAttribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_INT As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_IntTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter

    Private objXML As Xml.XmlDocument
    Private objXMLNodeList As Xml.XmlNodeList
    Private objXMLElement As Xml.XmlElement
    Private objXMLCData As Xml.XmlCDataSection

    Private objFileWork As clsFileWork
    Private objTextWriter As IO.TextWriter
    Private objSemWork As clsSemWork
    Private objBlobConnection As clsBlobConnection
    Private objTransaction_DBFiles As clsTransaction_DBFiles
    Private objTransaction_DBViewSchema As clsTransaction_DBViewSchema

    Private objConnection As SqlClient.SqlConnection

    Private objSemItem_Schema As clsSemItem


    Private semtblT_Type As New ds_SemDB.semtbl_TypeDataTable

    Private strSQL_Drop_Function As String
    Private strSQL_Drop_Procedure As String
    Private strSQL_Drop_Synonym As String
    Private strSQL_Drop_Table As String
    Private strSQL_Drop_Trigger As String
    Private strSQL_Drop_View As String

    Private strSQL_IFNotExists_Table As String
    Private strSQL_IFNotExists_View As String
    Private strSQL_IFNotExists_Function As String
    Private strSQL_IFNotExists_Procedure As String
    Private strSQL_IFNotExists_Synonym As String
    Private strSQL_IFNotExists_Trigger As String

    Private strSQL_Drop_All_Views As String
    Private strSQL_Drop_All_Procedures As String
    Private strSQL_Drop_All_Functions As String
    Private strSQL_Drop_All_Synonyms As String
    Private strSQL_Drop_All_Tables As String
    Private strSQL_Drop_All_Triggers As String

    Private strSQL_Insert_Attribute As String
    Private strSQL_Insert_RelationType As String
    Private strSQL_Insert_Type As String
    Private strSQL_Insert_Type_NoParent As String
    Private strSQL_Insert_Token As String
    Private strSQL_Insert_TokenAttribute As String
    Private strSQL_Insert_OR As String
    Private strSQL_Insert_TypeAttribute As String
    Private strSQL_Insert_TypeType As String
    Private strSQL_Insert_TokenAttribute_Bit As String
    Private strSQL_Insert_TokenAttribute_Date As String
    Private strSQL_Insert_TokenAttribute_Datetime As String
    Private strSQL_Insert_TokenAttribute_Int As String
    Private strSQL_Insert_TokenAttribute_Real As String
    Private strSQL_Insert_TokenAttribute_Time As String
    Private strSQL_Insert_TokenAttribute_Varchar255 As String
    Private strSQL_Insert_TokenAttribute_VarcharMax As String
    Private strSQL_Insert_Token_Token As String
    Private strSQL_Insert_OR_Type As String
    Private strSQL_Insert_OR_Attribute As String
    Private strSQL_Insert_OR_RelationType As String
    Private strSQL_Insert_OR_Token As String
    Private strSQL_Insert_OR_Token_Attribute_Bit As String
    Private strSQL_Insert_OR_Token_Attribute_Date As String
    Private strSQL_Insert_OR_Token_Attribute_Datetime As String
    Private strSQL_Insert_OR_Token_Attribute_Int As String
    Private strSQL_Insert_OR_Token_Attribute_Real As String
    Private strSQL_Insert_OR_Token_Attribute_Time As String
    Private strSQL_Insert_OR_Token_Attribute_Varchar255 As String
    Private strSQL_Insert_OR_Token_Attribute_VarcharMax As String
    Private strSQL_Insert_Token_OR As String
    Private strSQL_Insert_Type_OR As String

    Private strSQL_dbg_Attribute As String

    Private strSQL_Create_Database As String
    Private strSQL_Create_Database_FS As String

    Private strVersion_Schema As String

    Private strSchemaItem As String

    Private boolInitialized As Boolean
    Private boolSaveSQL As Boolean

    Public ReadOnly Property dtbl_Columns() As ds_SchemaManager.dtbl_ColumnsDataTable
        Get
            Return dtblT_Columns
        End Get
    End Property

    Public Function get_ColumnsOfView(ByVal SemItem_View As clsSemItem, ByVal strDatabase As String, ByVal strServer As String) As clsSemItem
        Dim objConnection As New SqlClient.SqlConnection
        Dim objSemItem_Result As clsSemItem

        objConnection.ConnectionString = objLocalConfig.Globals.get_DB_ConnectionString(strServer, strDatabase)

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        dtblA_Columns.Connection = objConnection
        Try
            dtblA_Columns.Fill(dtblT_Columns, SemItem_View.Name)
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try


        Return objSemItem_Result
    End Function

    Public Function get_SQL_Insert_Attribute(ByVal GUID_Attribute As Guid, ByVal Name_attribute As String, ByVal GUID_Attribute_Type As Guid) As String
        Dim strSQL As String
        strSQL = strSQL_Insert_Attribute.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Attribute.Name & "@", GUID_Attribute.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Attribute.Name & "@", Name_attribute)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_AttributeType.Name & "@", GUID_Attribute_Type.ToString)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_RelationType(ByVal GUID_RelationType As Guid, ByVal Name_RelationType As String) As String
        Dim strSQL As String
        strSQL = strSQL_Insert_RelationType.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_RelationType.Name & "@", GUID_RelationType.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_RelationType.Name & "@", Name_RelationType)
        Return strSQL
    End Function

    Public Function get_SQL_Insert_Type(ByVal GUID_Type As Guid, ByVal Name_Type As String, ByVal GUID_Type_Parent As Guid) As String
        Dim strSQL As String
        If GUID_Type_Parent = Nothing Then
            strSQL = strSQL_Insert_Type_NoParent.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", GUID_Type.ToString)
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Type.Name & "@", Name_Type)
        Else
            strSQL = strSQL_Insert_Type.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", GUID_Type.ToString)
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Type.Name & "@", Name_Type)
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type_Parent.Name & "@", GUID_Type_Parent.ToString)
        End If

        Return strSQL
    End Function

    Public Function get_SQL_Insert_Token(ByVal GUID_Token As Guid, ByVal Name_Token As String, ByVal GUID_Type As Guid) As String
        Dim strSQL
        strSQL = strSQL_Insert_Token.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Token.Name & "@", GUID_Token.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Token.Name & "@", Name_Token)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", GUID_Type.ToString)
        Return strSQL
    End Function

    Public Function get_SQL_Insert_Token_Token(ByVal GUID_Token_Left As Guid, ByVal GUID_Token_Right As Guid, ByVal GUID_RelationType As Guid, ByVal intOrderID As Integer) As String
        Dim strSQL As String
        strSQL = strSQL_Insert_Token_Token.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Token_Left.Name & "@", GUID_Token_Left.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Token_Right.Name & "@", GUID_Token_Right.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_RelationType.Name & "@", GUID_RelationType.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_OrderID.Name & "@", intOrderID)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_Type_Attribute(ByVal GUID_Type As Guid, ByVal GUID_Attribute As Guid, ByVal intMin As Integer, ByVal intMax As Integer) As String
        Dim strSQL As String
        strSQL = strSQL_Insert_TypeAttribute.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", GUID_Type.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Attribute.Name & "@", GUID_Attribute.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Min.Name & "@", intMin.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Max.Name & "@", intMax.ToString)
        Return strSQL
    End Function

    

    Public Function get_SQL_Insert_Type_Type(ByVal GUID_Type_Left As Guid, ByVal GUID_Type_Right As Guid, ByVal GUID_RelationType As Guid, ByVal intMin_forw As Integer, ByVal intMax_forw As Integer, ByVal intMax_backw As String) As String
        Dim strSQL As String
        strSQL = strSQL_Insert_TypeType.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type_Left.Name & "@", GUID_Type_Left.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type_Right.Name & "@", GUID_Type_Right.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_RelationType.Name & "@", GUID_RelationType.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Min_forw.Name & "@", intMin_forw)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Max_forw.Name & "@", intMax_forw)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Max_backw.Name & "@", intMax_backw)
        Return strSQL
    End Function

    Public Function get_SQL_Insert_Token_Attribute(ByVal GUID_TokenAttribute As Guid, ByVal GUID_Token As Guid, ByVal GUID_Attribute As Guid) As String
        Dim strSQL As String
        strSQL = strSQL_Insert_TokenAttribute.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Token.Name & "@", GUID_Token.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Attribute.Name & "@", GUID_Attribute.ToString)
        Return strSQL
    End Function

    Public Function get_SQL_Insert_Token_Attribute_Bit(ByVal GUID_TokenAttribute As Guid, ByVal boolVal As Boolean, ByVal intOrderID As Integer) As String
        Dim strSQL As String
        strSQL = strSQL_Insert_TokenAttribute_Bit.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_OrderID.Name & "@", intOrderID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_val.Name & "@", CInt(boolVal))
        Return strSQL
    End Function

    Public Function get_SQL_Insert_Token_Attribute_Date(ByVal GUID_TokenAttribute As Guid, ByVal dateVal As Date, ByVal intOrderID As Integer) As String
        Dim strSQL As String
        strSQL = strSQL_Insert_TokenAttribute_Date.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_OrderID.Name & "@", intOrderID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_val.Name & "@", dateVal)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_Token_Attribute_Datetime(ByVal GUID_TokenAttribute As Guid, ByVal dateVal As Date, ByVal intOrderID As Integer) As String
        Dim strSQL As String
        strSQL = strSQL_Insert_TokenAttribute_Datetime.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_OrderID.Name & "@", intOrderID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_val.Name & "@", dateVal)
        Return strSQL
    End Function

    Public Function get_SQL_Insert_Token_Attribute_Int(ByVal GUID_TokenAttribute As Guid, ByVal intVal As Integer, ByVal intOrderID As Integer) As String
        Dim strSQL As String
        strSQL = strSQL_Insert_TokenAttribute_Int.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_OrderID.Name & "@", intOrderID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_val.Name & "@", intVal)
        Return strSQL
    End Function

    Public Function get_SQL_Insert_Token_Attribute_Real(ByVal GUID_TokenAttribute As Guid, ByVal dblVal As Double, ByVal intOrderID As Integer) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_TokenAttribute_Real.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_OrderID.Name & "@", intOrderID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_val.Name & "@", dblVal)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_Token_Attribute_Time(ByVal GUID_TokenAttribute As Guid, ByVal dateVal As Date, ByVal intOrderID As Integer) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_TokenAttribute_Time.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_OrderID.Name & "@", intOrderID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_val.Name & "@", dateVal)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_Token_Attribute_VARCHAR255(ByVal GUID_TokenAttribute As Guid, ByVal strVal As String, ByVal intOrderID As Integer) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_TokenAttribute_Varchar255.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_OrderID.Name & "@", intOrderID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_val.Name & "@", strVal)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_Token_Attribute_VARCHARMAX(ByVal GUID_TokenAttribute As Guid, ByVal strVal As String, ByVal intOrderID As Integer) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_TokenAttribute_VarcharMax.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_OrderID.Name & "@", intOrderID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_val.Name & "@", strVal)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_OR(ByVal GUID_ObjectReference As Guid, ByVal GUID_OrType As Guid) As String
        Dim strSQL As String
        strSQL = strSQL_Insert_OR.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ORType.Name & "@", GUID_OrType.ToString)
        Return strSQL
    End Function

    Public Function get_SQL_Insert_OR_Type(ByVal GUID_ObjectReference As Guid, ByVal GUID_Type As Guid) As String
        Dim strSQL

        strSQL = strSQL_Insert_OR_Type.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", GUID_Type.ToString)

        Return strSQL

    End Function

    Public Function get_SQL_Insert_OR_Attribute(ByVal GUID_ObjectReference As Guid, ByVal GUID_Attribute As Guid) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_OR_Attribute.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Attribute.Name & "@", GUID_Attribute.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_OR_RelationType(ByVal GUID_ObjectReference As Guid, ByVal GUID_RelationType As Guid) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_OR_RelationType.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_RelationType.Name & "@", GUID_RelationType.ToString)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_OR_Token(ByVal GUID_ObjectReference As Guid, ByVal GUID_Token As Guid) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_OR_Token.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Token.Name & "@", GUID_Token.ToString)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_OR_Token_Attribute_Bit(ByVal GUID_ObjectReference As Guid, ByVal GUID_TokenAttribute As Guid) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_OR_Token_Attribute_Bit.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_OR_Token_Attribute_Date(ByVal GUID_ObjectReference As Guid, ByVal GUID_TokenAttribute As Guid) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_OR_Token_Attribute_Date.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_OR_Token_Attribute_DateTime(ByVal GUID_ObjectReference As Guid, ByVal GUID_TokenAttribute As Guid) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_OR_Token_Attribute_Datetime.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_OR_Token_Attribute_Int(ByVal GUID_ObjectReference As Guid, ByVal GUID_TokenAttribute As Guid) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_OR_Token_Attribute_Int.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_OR_Token_Attribute_Real(ByVal GUID_ObjectReference As Guid, ByVal GUID_TokenAttribute As Guid) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_OR_Token_Attribute_Real.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_OR_Token_Attribute_Time(ByVal GUID_ObjectReference As Guid, ByVal GUID_TokenAttribute As Guid) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_OR_Token_Attribute_Time.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_OR_Token_Attribute_VARCHAR255(ByVal GUID_ObjectReference As Guid, ByVal GUID_TokenAttribute As Guid) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_OR_Token_Attribute_Varchar255.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_OR_Token_Attribute_VARCHARMAX(ByVal GUID_ObjectReference As Guid, ByVal GUID_TokenAttribute As Guid) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_OR_Token_Attribute_VarcharMax.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_TokenAttribute.Name & "@", GUID_TokenAttribute.ToString)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_Token_OR(ByVal GUID_ObjectReference As Guid, ByVal GUID_RelationType As Guid, ByVal GUID_Token_Left As Guid, ByVal intOrderID As Integer) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_Token_OR.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReference.Name & "@", GUID_ObjectReference.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_RelationType.Name & "@", GUID_RelationType.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Token_Left.Name & "@", GUID_Token_Left.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_OrderID.Name & "@", intOrderID)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_Type_OR(ByVal GUID_Type As Guid, ByVal GUID_RelationType As Guid, ByVal intMin_forw As Integer, ByVal intMax_forw As Integer) As String
        Dim strSQL As String

        strSQL = strSQL_Insert_Type_OR.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", GUID_Type.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_RelationType.Name & "@", GUID_RelationType.ToString)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Min_forw.Name & "@", intMin_forw)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Max_forw.Name & "@", intMax_forw)

        Return strSQL
    End Function

    Public Function get_SQL_User_Database(ByVal strDatabase As String)
        Dim strSQL As String
        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_Use_Database.GUID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_db_name.Name & "@", strDatabase)

        Return strSQL
    End Function

    Public Function get_SQL_IFNOTExists_Function(ByVal strFunction As String, Optional ByVal strSchema As String = Nothing)
        Dim strSQL As String

        strFunction = parse_Name(strFunction)
        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__IF_EXISTS___Function_.GUID)
        If Not strSchema Is Nothing Then
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", strSchema)
        Else
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", "dbo")
        End If

        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_function_name.Name & "@", strFunction)

        Return strSQL
    End Function

    Public Function get_SQL_IFNOTExists_Procedure(ByVal strProcedure As String, Optional ByVal strSchema As String = Nothing)
        Dim strSQL As String

        strProcedure = parse_Name(strProcedure)
        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__IF_EXISTS___Procedure_.GUID)
        If Not strSchema Is Nothing Then
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", strSchema)
        Else
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", "dbo")
        End If
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_procedure_name.Name & "@", strProcedure)

        Return strSQL
    End Function
    Public Function get_SQL_Func_related_Token_Of_Token(ByVal RowName_GUID_Right As String, _
                                                        ByVal RowName_GUIDType_Right As String, _
                                                        ByVal RowName_Name_Right As String, _
                                                        ByVal Par_GUID_Type_Right As String, _
                                                        ByVal Type_Name_Left As String, _
                                                        ByVal Type_Name_Right As String, _
                                                        ByVal Name_RelationType As String) As String
        Dim strSQL As String

        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL___Func___Token_Of_related_Token.GUID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Row_Left.Name & "@", "GUID_" & Type_Name_Left)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Row_Right.Name & "@", RowName_GUID_Right)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type_Row_Right.Name & "@", RowName_GUIDType_Right)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_RelationType.Name & "@", Name_RelationType)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Row_Right.Name & "@", RowName_Name_Right)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Par_GUID_Type_Right.Name & "@", Par_GUID_Type_Right)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Type_Name_Left.Name & "@", Type_Name_Left)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Type_Name_Right.Name & "@", Type_Name_Right)

        Return strSQL
    End Function
    Public Function get_SQL_IFNOTExists_Synonym(ByVal strSynonym As String, Optional ByVal strSchema As String = Nothing)
        Dim strSQL As String

        strSynonym = parse_Name(strSynonym)
        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__IF_EXISTS___Synonym_.GUID)
        If Not strSchema Is Nothing Then
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", strSchema)
        Else
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", "dbo")
        End If
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_synonym_name.Name & "@", strSynonym)

        Return strSQL
    End Function

    Public Function get_SQL_IFNOTExists_Table(ByVal strTable As String, Optional ByVal strSchema As String = Nothing)
        Dim strSQL As String

        strTable = parse_Name(strTable)
        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__IF_EXISTS___Table_.GUID)
        If Not strSchema Is Nothing Then
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", strSchema)
        Else
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", "dbo")
        End If
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_table_name.Name & "@", strTable)

        Return strSQL
    End Function

    Public Function get_SQL_IFNOTExists_Trigger(ByVal strTrigger As String, Optional ByVal strSchema As String = Nothing)
        Dim strSQL As String

        strTrigger = parse_Name(strTrigger)
        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__IF_EXISTS___Trigger_.GUID)
        If Not strSchema Is Nothing Then
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", strSchema)
        Else
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", "dbo")
        End If
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_trigger_name.Name & "@", strTrigger)

        Return strSQL
    End Function

    Public Function get_SQL_IFNOTExists_View(ByVal strView As String, Optional ByVal strSchema As String = Nothing)
        Dim strSQL As String

        strView = parse_Name(strView)
        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__IF_EXISTS___View_.GUID)
        If Not strSchema Is Nothing Then
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", strSchema)
        Else
            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", "dbo")
        End If
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_view_name.Name & "@", strView)

        Return strSQL
    End Function
    Public Function parse_Name(ByVal strName As String) As String
        Dim strParsedName As String

        strParsedName = ""
        For i = 0 To strName.Length - 1
            Select Case strName.Substring(i, 1)
                Case "0" To "9"
                    strParsedName = strParsedName & strName.Substring(i, 1)
                Case "a" To "z"
                    strParsedName = strParsedName & strName.Substring(i, 1)
                Case "A" To "Z"
                    strParsedName = strParsedName & strName.Substring(i, 1)
                Case "_"
                    strParsedName = strParsedName & strName.Substring(i, 1)
                Case Else
                    strParsedName = strParsedName & "_"

            End Select
        Next
        Return strParsedName
    End Function

    Public Function get_SQL_Insert_dbg_Attribute(ByVal strName_Attribute As String) As String

        Dim strSQL As String
        Dim i As Integer


        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_dbg_Attribute.GUID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Attribute.Name & "@", strName_Attribute)
        strName_Attribute = parse_Name(strName_Attribute)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_ParsedName_Attribute.Name & "@", strName_Attribute)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_dbg_RelationType(ByVal strName_RelationType As String) As String
        Dim strSQL As String



        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_dbg_RelationType.GUID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_RelationType.Name & "@", strName_RelationType)
        strName_RelationType = parse_Name(strName_RelationType)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_ParsedName_RelationType.Name & "@", strName_RelationType)

        Return strSQL
    End Function

    Public Function get_SQL_Insert_dbg_Type(ByVal strName_Type As String) As String
        Dim strSQL As String


        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_dbg_Type.GUID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Type.Name & "@", strName_Type)
        strName_Type = parse_Name(strName_Type)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_ParsedName_Type.Name & "@", strName_Type)

        Return strSQL
    End Function

    Public Function get_SQL_Creation_Token_Of_Type(ByVal strName_Type As String) As String
        Dim strSQL As String

        strName_Type = parse_Name(strName_Type)
        

        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_CREATE_Function_Token_Of_Type.GUID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_ParsedName_Type.Name & "@", strName_Type)

        Return strSQL
    End Function

    Public Function get_SQL_Use_Database(ByVal strDatabase) As String
        Dim strSQL As String

        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_Use_Database.GUID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_db_name.Name & "@", strDatabase)

        Return strSQL
    End Function

    Public Function get_SQL_GO() As String
        Dim strSQL As String

        strSQL = "GO"

        Return strSQL
    End Function

    Public Function get_SQL_BEGIN() As String
        Dim strSQL As String

        strSQL = "BEGIN"

        Return strSQL
    End Function

    Public Function get_SQL_END() As String
        Dim strSQL As String

        strSQL = "END"

        Return strSQL
    End Function

    Public Function get_SQL_Create_Database(ByVal strName_DB As String) As String
        Dim strSQL As String

        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__Create_Database_.GUID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_db_name.Name & "@", strName_DB)

        Return strSQL
    End Function

    Public Function get_SQL_Create_Database(ByVal strName_DB As String, ByVal strPath_DBs As String) As String
        Dim strSQL As String

        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_Create_Database__Filestreams_.GUID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_db_name.Name & "@", strName_DB)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_db_folder_path.Name & "@", strPath_DBs)

        Return strSQL
    End Function

    Public Function get_SQL_execute_SQL(ByVal strSQL_Insert As String) As String
        Dim strSQL As String

        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_executesql.GUID)
        strSQL_Insert = strSQL_Insert.Replace("'", "''")
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_tsql_code.Name & "@", strSQL_Insert)

        Return strSQL
    End Function

    Public Function get_SQL(ByVal GUID_XML As Guid) As String
        Dim objDRC_XML As DataRowCollection
        Dim strXML As String
        Dim strSQL As String

        objDRC_XML = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(GUID_XML, objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
        If objDRC_XML.Count > 0 Then
            strXML = objDRC_XML(0).Item("Val")
            objXML = New Xml.XmlDocument
            objXML.LoadXml(strXML)
            objXMLNodeList = objXML.GetElementsByTagName("data")
            If objXMLNodeList.Count > 0 Then
                objXMLElement = objXMLNodeList(0)
                strSQL = objXML.InnerText

            Else
                strSQL = Nothing
            End If
        Else
            strSQL = Nothing
        End If
        Return strSQL
    End Function

    Private Function get_SQL_All() As Boolean
        Dim boolResult As Boolean = True

        strSQL_Drop_Function = get_SQL(objLocalConfig.SemItem_Token_XML_Drop_Function.GUID)
        strSQL_Drop_Procedure = get_SQL(objLocalConfig.SemItem_Token_XML_Drop_Procedure.GUID)
        strSQL_Drop_Synonym = get_SQL(objLocalConfig.SemItem_Token_XML_Drop_Synonym.GUID)
        strSQL_Drop_Table = get_SQL(objLocalConfig.SemItem_Token_XML_Drop_Table.GUID)
        strSQL_Drop_Trigger = get_SQL(objLocalConfig.SemItem_Token_XML_Drop_Trigger.GUID)
        strSQL_Drop_View = get_SQL(objLocalConfig.SemItem_Token_XML_Drop_View.GUID)

        strSQL_IFNotExists_Table = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__IF_EXISTS___Table_.GUID)
        strSQL_IFNotExists_View = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__IF_EXISTS___View_.GUID)
        strSQL_IFNotExists_Function = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__IF_EXISTS___Function_.GUID)
        strSQL_IFNotExists_Procedure = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__IF_EXISTS___Procedure_.GUID)
        strSQL_IFNotExists_Synonym = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__IF_EXISTS___Synonym_.GUID)
        strSQL_IFNotExists_Trigger = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__IF_EXISTS___Trigger_.GUID)

        strSQL_Drop_All_Views = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__Drop_All_Views_.GUID)
        strSQL_Drop_All_Procedures = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__Drop_All_Views_.GUID)
        strSQL_Drop_All_Functions = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__Drop_all_Functions_.GUID)
        strSQL_Drop_All_Synonyms = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__Drop_all_Synonyms_.GUID)
        strSQL_Drop_All_Tables = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__Drop_all_Tables_.GUID)
        strSQL_Drop_All_Triggers = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__Drop_all_Triggers_.GUID)

        strSQL_Create_Database = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL__Create_Database_.GUID)
        strSQL_Create_Database_FS = get_SQL(objLocalConfig.SemItem_Token_XML_Create_Database__Filestreams_.GUID)

        strSQL_Insert_Attribute = get_SQL(objLocalConfig.SemItem_Token_XML_SemItem_Insert_Attribute.GUID)
        strSQL_Insert_RelationType = get_SQL(objLocalConfig.SemItem_Token_XML_SemItem_Insert_RelationType.GUID)
        strSQL_Insert_Type = get_SQL(objLocalConfig.SemItem_Token_XML_SemItem_Insert_Type.GUID)
        strSQL_Insert_Token = get_SQL(objLocalConfig.SemItem_Token_XML_SemItem_Insert_Token.GUID)
        strSQL_Insert_Type_NoParent = get_SQL(objLocalConfig.SemItem_Token_XML_SemItem_Insert_Type_NoParent.GUID)
        strSQL_Insert_TokenAttribute = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_Insert_TokenAttribute.GUID)
        strSQL_Insert_OR = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR.GUID)
        strSQL_Insert_TypeAttribute = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_Type_Attribute.GUID)
        strSQL_Insert_TypeType = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_Type_Type.GUID)
        strSQL_Insert_TokenAttribute_Bit = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_TokenAttribute_Bit.GUID)
        strSQL_Insert_TokenAttribute_Date = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_TokenAttribute_Date.GUID)
        strSQL_Insert_TokenAttribute_Datetime = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_TokenAttribute_Datetime.GUID)
        strSQL_Insert_TokenAttribute_Int = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_TokenAttribute_Int.GUID)
        strSQL_Insert_TokenAttribute_Real = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_TokenAttribute_Real.GUID)
        strSQL_Insert_TokenAttribute_Time = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_TokenAttribute_time.GUID)
        strSQL_Insert_TokenAttribute_Varchar255 = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_TokenAttribute_Varchar255.GUID)
        strSQL_Insert_TokenAttribute_VarcharMax = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_TokenAttribute_VarcharMax.GUID)
        strSQL_Insert_Token_Token = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_Token_Token.GUID)
        strSQL_Insert_OR_Attribute = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR_Attribute.GUID)
        strSQL_Insert_OR_RelationType = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR_RelationType.GUID)
        strSQL_Insert_OR_Token = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR_Token.GUID)
        strSQL_Insert_OR_Type = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR_Type.GUID)
        strSQL_Insert_OR_Token_Attribute_Bit = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Bit.GUID)
        strSQL_Insert_OR_Token_Attribute_Date = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Date.GUID)
        strSQL_Insert_OR_Token_Attribute_Datetime = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Datetime.GUID)
        strSQL_Insert_OR_Token_Attribute_Int = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Int.GUID)
        strSQL_Insert_OR_Token_Attribute_Real = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Real.GUID)
        strSQL_Insert_OR_Token_Attribute_Time = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_Time.GUID)
        strSQL_Insert_OR_Token_Attribute_Varchar255 = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHAR255.GUID)
        strSQL_Insert_OR_Token_Attribute_VarcharMax = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_OR_Token_Attribute_VARCHARMAX.GUID)
        strSQL_Insert_Token_OR = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_Token_OR.GUID)
        strSQL_Insert_Type_OR = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_semtbl_Type_OR.GUID)

        strSQL_dbg_Attribute = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_dbg_Attribute.GUID)

        If strSQL_Drop_Function Is Nothing Or _
            strSQL_Drop_Procedure Is Nothing Or _
            strSQL_Drop_Synonym Is Nothing Or _
            strSQL_Drop_Table Is Nothing Or _
            strSQL_Drop_Trigger Is Nothing Or _
            strSQL_Drop_View Is Nothing Or _
            strSQL_Drop_All_Functions Is Nothing Or _
            strSQL_Drop_All_Procedures Is Nothing Or _
            strSQL_Drop_All_Synonyms Is Nothing Or _
            strSQL_Drop_All_Tables Is Nothing Or _
            strSQL_Drop_All_Triggers Is Nothing Or _
            strSQL_Drop_All_Views Is Nothing Or _
            strSQL_IFNotExists_Function Is Nothing Or _
            strSQL_IFNotExists_Procedure Is Nothing Or _
            strSQL_IFNotExists_Synonym Is Nothing Or _
            strSQL_IFNotExists_Table Is Nothing Or _
            strSQL_IFNotExists_Trigger Is Nothing Or _
            strSQL_IFNotExists_View Is Nothing Or _
            strSQL_Create_Database Is Nothing Or _
            strSQL_Insert_Attribute Is Nothing Or _
            strSQL_Insert_RelationType Is Nothing Or _
            strSQL_Insert_Type Is Nothing Or _
            strSQL_Insert_Token Is Nothing Or _
            strSQL_Insert_Type_NoParent Is Nothing Or _
            strSQL_Create_Database_FS Is Nothing Then

            boolResult = False

        End If

        Return boolResult
    End Function
    Public Sub New()
        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal objGlobals As clsGlobals)
        objLocalConfig = New clsLocalConfig(objGlobals)
        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        boolInitialized = get_SQL_All()

    End Sub

    Public Sub get_CreationScripts()
        procA_CreationScripts_And_DBItemInSchema_Of_DBSchema_By_GUIDDbSchema.Fill(procT_CreationScripts_And_DBItemInSchema_Of_DBSchema_By_GUIDDbSchema, _
                                                               objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                               objLocalConfig.SemItem_Attribute_Creation_Level.GUID, _
                                                               objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                               objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                               objLocalConfig.SemItem_Type_XML.GUID, _
                                                               objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                               objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                               objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                                               objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                                               objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                               objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                               objLocalConfig.SemItem_Type_Functions_in_Schema.GUID, _
                                                               objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID, _
                                                               objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID, _
                                                               objLocalConfig.SemItem_Type_Tables_in_Schema.GUID, _
                                                               objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID, _
                                                               objLocalConfig.SemItem_Type_Views_in_Schema.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                               objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                               objSemItem_Schema.GUID)
    End Sub
    Public Function recreate_DBItem(ByVal objSemItem_DBItem As clsSemItem) As clsRecreation_SQL
        Dim objXML_DBItem As Xml.XmlDocument
        Dim objXMLNodeList_Data As Xml.XmlNodeList
        Dim objXMLElement_Data As Xml.XmlElement
        Dim objDRC_CreationTemplate As DataRowCollection
        Dim objRecreation_SQL As New clsRecreation_SQL

        objDRC_CreationTemplate = procA_CreationScript_And_XML_Of_DBItem_By_GUIDDBItem.GetData(objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                               objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                                                               objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                                                               objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                                                                               objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                                                                               objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                                                               objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                                                               objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                               objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                               objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                               objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                               objSemItem_DBItem.GUID).Rows

        If objDRC_CreationTemplate.Count > 0 Then
            objRecreation_SQL.GUID_CreationScript = objDRC_CreationTemplate(0).Item("GUID_CreationScript")
            Select Case objSemItem_DBItem.GUID_Parent
                Case objLocalConfig.SemItem_Type_DB_Function.GUID
                    objRecreation_SQL.SQL_Drop = strSQL_Drop_Function.Replace(cstrTSQLVar_Function, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                    objRecreation_SQL.SQL_Exists = strSQL_IFNotExists_Function.Replace(cstrTSQLVar_Function, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                    objRecreation_SQL.SQL_Exists = strSQL_IFNotExists_Function.Replace(cstrTSQLVar_Schema, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                Case objLocalConfig.SemItem_Type_DB_Procedure.GUID
                    objRecreation_SQL.SQL_Drop = strSQL_Drop_Procedure.Replace(cstrTSQLVar_Procedure, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                    objRecreation_SQL.SQL_Exists = strSQL_IFNotExists_Procedure.Replace(cstrTSQLVar_Procedure, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                    objRecreation_SQL.SQL_Exists = strSQL_IFNotExists_Procedure.Replace(cstrTSQLVar_Schema, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                Case objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                    objRecreation_SQL.SQL_Drop = strSQL_Drop_Synonym.Replace(cstrTSQLVar_Synonym, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                    objRecreation_SQL.SQL_Exists = strSQL_IFNotExists_Synonym.Replace(cstrTSQLVar_Synonym, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                    objRecreation_SQL.SQL_Exists = strSQL_IFNotExists_Synonym.Replace(cstrTSQLVar_Schema, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                Case objLocalConfig.SemItem_Type_DB_Tables.GUID
                    objRecreation_SQL.SQL_Drop = strSQL_Drop_Table.Replace(cstrTSQLVar_Table, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                    objRecreation_SQL.SQL_Exists = strSQL_IFNotExists_Table.Replace(cstrTSQLVar_Table, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                    objRecreation_SQL.SQL_Exists = strSQL_IFNotExists_Table.Replace(cstrTSQLVar_Schema, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                Case objLocalConfig.SemItem_Type_DB_Triggers.GUID
                    objRecreation_SQL.SQL_Drop = strSQL_Drop_Trigger.Replace(cstrTSQLVar_Trigger, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                    objRecreation_SQL.SQL_Exists = strSQL_IFNotExists_Trigger.Replace(cstrTSQLVar_Trigger, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                    objRecreation_SQL.SQL_Exists = strSQL_IFNotExists_Trigger.Replace(cstrTSQLVar_Schema, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                Case objLocalConfig.SemItem_Type_DB_Views.GUID
                    objRecreation_SQL.SQL_Drop = strSQL_Drop_View.Replace(cstrTSQLVar_View, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                    objRecreation_SQL.SQL_Exists = strSQL_IFNotExists_View.Replace(cstrTSQLVar_View, objDRC_CreationTemplate(0).Item("Name_DBItem"))
                    objRecreation_SQL.SQL_Exists = strSQL_IFNotExists_View.Replace(cstrTSQLVar_Schema, objDRC_CreationTemplate(0).Item("Name_DBItem"))
            End Select


            objXML_DBItem = New Xml.XmlDocument
            objXML_DBItem.LoadXml(objDRC_CreationTemplate(0).Item("XML"))
            objXMLNodeList_Data = objXML_DBItem.GetElementsByTagName("data")
            If objXMLNodeList_Data.Count > 0 Then
                objXMLElement_Data = objXMLNodeList_Data(0)
                objRecreation_SQL.SQL_Create = objXMLElement_Data.InnerText
            End If


        End If
        Return objRecreation_SQL
    End Function

    Public Function create_Schema(ByVal SemItem_Schema As clsSemItem, ByVal objSemItem_Database As clsSemItem, ByVal objSemItem_Server As clsSemItem, Optional ByVal saveSQL As Boolean = False) As Boolean
        Dim objDRC_Version As DataRowCollection
        Dim objDRC_SQLFile As DataRowCollection
        Dim objDRC_AddtionalData As DataRowCollection
        Dim objDRC_DatabaseForSynonyms As DataRowCollection
        Dim objDRC_Database As DataRowCollection
        Dim objDR_CreationScript As DataRow
        Dim objDRs_DatabaseOnServer() As DataRow
        Dim objCMD As New SqlClient.SqlCommand
        Dim objXML_DBItem As Xml.XmlDocument
        Dim objXMLNodeList_Data As Xml.XmlNodeList
        Dim objXMLElement_Data As Xml.XmlElement
        Dim objSemItem_SQLFile As New clsSemItem
        Dim objSemItem_DBOnServer As New clsSemItem
        Dim objSemItem_DBOnServer_Syn As New clsSemItem
        Dim objServerCon As ServerConnection
        Dim objServer As Server
        Dim objDatabase As Database
        Dim GUID_DBType As Guid
        Dim strPathSQL As String
        Dim strUserSchema_Syn As String
        Dim strTableName_Syn As String
        Dim strServerName_Syn As String
        Dim strDatabaseName_Syn As String
        Dim boolResult As Boolean = False
        Dim strSQL As String
        Dim strSQL_IFExist As String
        Dim strPath_DBs As String
        Dim boolExists As Boolean
        Dim boolScript As Boolean
        Dim boolAttributes As Boolean
        Dim boolObjectReferenceTypes As Boolean
        Dim boolFilestreams As Boolean
        Dim objSemItem_File As clsSemItem
        Dim objSemItem_Version As clsSemItem
        Dim objSemItem_SchemaType As clsSemItem
        Dim objSemItem_Result As clsSemItem

        'Typ der Datenbank (System, User, Module, Change)
        objDRC_Database = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Database.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                         objLocalConfig.SemItem_Type_DB_Schema_Type.GUID).Rows
        objSemItem_SchemaType = New clsSemItem
        objSemItem_SchemaType.GUID = objLocalConfig.SemItem_RelationType_Schema.GUID
        objSemItem_SchemaType.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
        

        funcA_SemDatabasesOnServers.Fill_By_GUIDServer(funcT_SemDatabasesOnServers, _
                                                                         objLocalConfig.SemItem_Type_Server.GUID, _
                                                                         objLocalConfig.SemItem_Type_Database_on_Server.GUID, _
                                                                         objLocalConfig.SemItem_Type_Database.GUID, _
                                                                         objLocalConfig.SemItem_type_DevelopmentVersion.GUID, _
                                                                         objLocalConfig.SemItem_Type_DB_Schema_Type.GUID, _
                                                                         objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                         objSemItem_Server.GUID)

        objDRs_DatabaseOnServer = funcT_SemDatabasesOnServers.Select("GUID_Database='" & objSemItem_Database.GUID.ToString & "'")

        objSemItem_DBOnServer = New clsSemItem
        objSemItem_DBOnServer.GUID = objDRs_DatabaseOnServer(0).Item("GUID_DatabaseOnServer")
        objSemItem_DBOnServer.Name = objDRs_DatabaseOnServer(0).Item("Name_DatabaseOnServer")
        objSemItem_DBOnServer.GUID_Parent = objLocalConfig.SemItem_Type_Database_on_Server.GUID
        objSemItem_DBOnServer.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


        objDRC_AddtionalData = funcA_Token_Token.GetData_TokenToken_RightLeft(objSemItem_Server.GUID, _
                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                              objLocalConfig.SemItem_Type_DBServerConfig.GUID).Rows
        If objDRC_AddtionalData.Count > 0 Then
            objDRC_AddtionalData = funcA_Token_Token.GetData_TokenToken_LeftRight(objDRC_AddtionalData(0).Item("GUID_TokeN_Left"), _
                                                                                  objLocalConfig.SemItem_RelationType_DataPath.GUID, _
                                                                                  objLocalConfig.SemItem_Type_Path.GUID).Rows
            If objDRC_AddtionalData.Count > 0 Then
                strPath_DBs = objDRC_AddtionalData(0).Item("Name_Token_Right")
            Else
                boolResult = False
            End If
        Else
            boolResult = False
        End If
        strDatabaseName_Syn = ""
        'Wurde ein Typ festgelegt?
        If objDRC_Database.Count > 0 Then
            'Typ ermitteln
            GUID_DBType = objDRC_Database(0).Item("GUID_Token_Right")

            objDRC_DatabaseForSynonyms = funcA_Token_Token.GetData_TokenToken_RightLeft(objSemItem_DBOnServer.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_Database_for_Synonyms.GUID).Rows
            If objDRC_DatabaseForSynonyms.Count > 0 Then
                
                objSemItem_DBOnServer_Syn.GUID = objDRC_DatabaseForSynonyms(0).Item("GUID_Token_Left")
                objDRC_DatabaseForSynonyms = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DBOnServer_Syn.GUID, _
                                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                            objLocalConfig.SemItem_Type_Database.GUID).Rows
                If objDRC_DatabaseForSynonyms.Count > 0 Then
                    strDatabaseName_Syn = objDRC_DatabaseForSynonyms(0).Item("Name_Token_Right")
                End If

                objDRC_DatabaseForSynonyms = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DBOnServer_Syn.GUID, _
                                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                            objLocalConfig.SemItem_Type_Server.GUID).Rows

                If objDRC_DatabaseForSynonyms.Count > 0 Then
                    strServerName_Syn = objDRC_DatabaseForSynonyms(0).Item("Name_Token_Right")
                End If



                End If

                objDRC_AddtionalData = procA_TokenAttribute_Bit.GetData_By_GUIDAttribute_And_GUIDToken(SemItem_Schema.GUID, _
                                                                                                       objLocalConfig.SemItem_Attribute_Filestreams.GUID).Rows
                If objDRC_AddtionalData.Count > 0 Then
                    boolFilestreams = objDRC_AddtionalData(0).Item("Val")
                Else
                    boolFilestreams = False
                End If

                boolSaveSQL = saveSQL
                objSemItem_Schema = SemItem_Schema

                'SQL speichern oder direkt ändern?
                If boolSaveSQL = True Then

                    'SQL-File ermitteln
                    objDRC_SQLFile = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Schema.GUID, objLocalConfig.SemItem_RelationType_export_to.GUID, objLocalConfig.SemItem_Type_File.GUID).Rows

                    If objDRC_SQLFile.Count > 0 Then
                        objSemItem_SQLFile.GUID = objDRC_SQLFile(0).Item("GUID_Token_Right")
                        objSemItem_SQLFile.Name = objDRC_SQLFile(0).Item("Name_Token_Right")
                        objSemItem_SQLFile.GUID_Parent = objDRC_SQLFile(0).Item("GUID_Type_Right")
                        objSemItem_SQLFile.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    'strPathSQL = objFileWork.get_Path_FileSystemObject(objSemItem_SQLFile)
                    strPathSQL = "%temp%\" & Guid.NewGuid.ToString & ".sql"
                    strPathSQL = Environment.ExpandEnvironmentVariables(strPathSQL)
                        Try
                            objTextWriter = New IO.StreamWriter(strPathSQL, False)

                        Catch ex As Exception
                            MsgBox("Die Datei, in die der SQL-Code exportiert werden soll, kann nicht geschrieben werden!", MsgBoxStyle.Exclamation)
                        End Try
                    Else
                        MsgBox("Die Datei, in die der SQL-Code exportiert werden soll, kann nicht ermittelt werden (Sem-DB)!", MsgBoxStyle.Exclamation)
                        Exit Function
                    End If

                End If


                'Version des Datenbankschemas ermitteln
                objDRC_Version = funcA_DatabaseSchema_with_Version_and_Logentry.GetData_By_GUIDSchema(objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_Create_Datatypes.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_Create_Object_Reference_Typs.GUID, _
                                                                                                  objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                                                                  objLocalConfig.SemItem_type_DevelopmentVersion.GUID, _
                                                                                                  objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                                  objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                                                  objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                                  objSemItem_Schema.GUID).Rows

                If objDRC_Version.Count > 0 Then
                    objSemItem_Version = New clsSemItem
                    objSemItem_Version.GUID = objDRC_Version(0).Item("GUID_DevelopmentVersion")
                    objSemItem_Version.Name = objDRC_Version(0).Item("Name_DevelopmentVersion")
                    objSemItem_Version.GUID_Parent = objLocalConfig.SemItem_type_DevelopmentVersion.GUID
                    objSemItem_Version.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    strVersion_Schema = objDRC_Version(0).Item("Name_DevelopmentVersion")
                    boolAttributes = objDRC_Version(0).Item("CreateDataTypes")
                    boolObjectReferenceTypes = objDRC_Version(0).Item("Create_ObjectReferenceType")
                Else
                    objSemItem_Version = Nothing
                    strVersion_Schema = ""
                End If

                'Die Creation-Scripts des Schemas speichern
            If save_CreationScript_Of_DBSchema() = True Then
                boolResult = True
                'Die dem Schema zugeordneten Creation-Scripts ermitteln
                get_CreationScripts_Of_Schema()

                If boolSaveSQL = False Then
                    objServerCon = New ServerConnection
                    objServerCon.ServerInstance = objSemItem_Server.Name & "\SQLEXPRESS"
                    objServerCon.LoginSecure = True
                    objServer = New Server(objServerCon)
                End If


                Try
                    If boolSaveSQL = False Then
                        objServer.ConnectionContext.Connect()
                        boolExists = False
                        For Each objDatabase In objServer.Databases
                            If objDatabase.Name = objSemItem_Database.Name Then
                                boolExists = True
                                Exit For

                            End If
                        Next
                    Else
                        boolExists = False
                    End If

                    'get_CreationScripts()

                    If boolSaveSQL = False Then
                        objConnection = New SqlClient.SqlConnection("Data Source=" & _
                            objSemItem_Server.Name & _
                            "\SQLEXPRESS" & _
                            ";Integrated Security=True")

                        objConnection.Open()
                        objCMD.Connection = objConnection
                    End If
                    If boolExists = True And boolSaveSQL = False Then

                    Else

                        If boolFilestreams = True Then
                            strSQL = strSQL_Create_Database_FS.Replace("@db_name@", objSemItem_Database.Name)
                            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_db_folder_path.Name & "@", strPath_DBs)
                        Else
                            strSQL = strSQL_Create_Database.Replace("@db_name@", objSemItem_Database.Name)
                        End If

                        If boolSaveSQL = False Then
                            objCMD.CommandText = strSQL
                            objCMD.ExecuteNonQuery()
                        Else
                            objTextWriter.WriteLine(strSQL)
                            objTextWriter.WriteLine("GO")
                        End If

                        If boolSaveSQL = True Then
                            strSQL = get_SQL_User_Database(objLocalConfig.Connection_Change.Database)

                            objTextWriter.WriteLine(strSQL)
                        End If

                    End If

                    If chngtblA_DB.GetData_DB_ByName(SemItem_Schema.Name).Rows.Count = 0 And boolSaveSQL = False Then

                        chngtblA_DB.proc_Insert_New_SemDB(objSemItem_Database.GUID, objSemItem_Database.Name, False)
                    ElseIf boolSaveSQL = True Then
                        If GUID_DBType = objLocalConfig.SemItem_Token_DB_Schema_Type_System.GUID Or GUID_DBType = objLocalConfig.SemItem_Token_DB_Schema_Type_User.GUID Then
                            strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB.GUID)
                            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_DB.Name & "@", objSemItem_Database.GUID.ToString)
                            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME_DB.Name & "@", objSemItem_Database.Name)
                            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_isSystemDB.Name & "@", CInt(False))
                            objTextWriter.WriteLine(strSQL)
                            objTextWriter.WriteLine("GO")
                        End If

                        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_Use_Database.GUID)
                        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_db_name.Name & "@", objSemItem_Database.Name)
                        objTextWriter.WriteLine(strSQL)
                        objTextWriter.WriteLine("GO")
                    End If



                    If boolSaveSQL = False Then
                        objConnection = New SqlClient.SqlConnection("Data Source=" & _
                        objSemItem_Server.Name & _
                        "\SQLEXPRESS;Initial Catalog=" & _
                        objSemItem_Database.Name & _
                        ";Integrated Security=True")
                        objConnection.Open()
                        funcA_listExtendedProperties.Connection = objConnection
                        objCMD.Connection = objConnection
                    End If





                    objXML_DBItem = New Xml.XmlDocument

                    For Each objDR_CreationScript In procT_CreationScript_And_DBItems_Of_DBSchema_BY_GUIDDBSchema.Rows
                        strSchemaItem = objDR_CreationScript("Name_CreationScript")
                        boolScript = False
                        objXML_DBItem.LoadXml(objDR_CreationScript.Item("XMLText"))
                        objXMLNodeList_Data = objXML_DBItem.GetElementsByTagName("data")
                        If objXMLNodeList_Data.Count > 0 Then
                            objXMLElement_Data = objXMLNodeList_Data(0)
                            strSQL = objXMLElement_Data.InnerText

                            boolScript = True

                        End If
                        Select Case objDR_CreationScript.Item("GUID_Type_DBItemInSchema")
                            Case objLocalConfig.SemItem_Type_Functions_in_Schema.GUID
                                strSQL_IFExist = get_SQL_IFNOTExists_Function(objDR_CreationScript("Name_DBItem"))
                            Case objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID
                                strSQL_IFExist = get_SQL_IFNOTExists_Procedure(objDR_CreationScript("Name_DBItem"))
                            Case objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID
                                strSQL_IFExist = get_SQL_IFNOTExists_Synonym(objDR_CreationScript("Name_DBItem"))
                                objDRC_AddtionalData = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_CreationScript.Item("GUID_DBItemInSchema"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Userschema.GUID).Rows
                                If objDRC_AddtionalData.Count > 0 Then
                                    strUserSchema_Syn = objDRC_AddtionalData(0).Item("Name_Token_Right")
                                Else
                                    strUserSchema_Syn = ""
                                End If
                                strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_schema_name.Name & "@", strUserSchema_Syn)
                                objDRC_AddtionalData = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_CreationScript.Item("GUID_DbItemInSchema"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Tables.GUID).Rows
                                If objDRC_AddtionalData.Count > 0 Then
                                    strTableName_Syn = objDRC_AddtionalData(0).Item("Name_Token_Right")
                                Else
                                    strTableName_Syn = ""
                                End If
                                strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_table_name.Name & "@", strTableName_Syn)

                                strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_db_name.Name & "@", strDatabaseName_Syn)





                                strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_server_name.Name & "@", strServerName_Syn)
                                strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_synonym_name.Name & "@" & objLocalConfig.SemItem_Token_Variable_synonym_name.Name & "@", objDR_CreationScript.Item("Name_DBItem"))
                            Case objLocalConfig.SemItem_Type_Tables_in_Schema.GUID
                                strSQL_IFExist = get_SQL_IFNOTExists_Table(objDR_CreationScript("Name_DBItem"))
                            Case objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID
                                strSQL_IFExist = get_SQL_IFNOTExists_Trigger(objDR_CreationScript("Name_DBItem"))
                            Case objLocalConfig.SemItem_Type_Views_in_Schema.GUID
                                strSQL_IFExist = get_SQL_IFNOTExists_View(objDR_CreationScript("Name_DBItem"))
                        End Select
                        If boolScript = True Then
                            strSQL = get_SQL_execute_SQL(strSQL)
                            If boolSaveSQL = False Then
                                objCMD.CommandText = strSQL
                                Try
                                    objCMD.ExecuteNonQuery()
                                Catch ex As Exception
                                    MsgBox(ex.Message & ": " & objDR_CreationScript("Name_CreationScript"), MsgBoxStyle.Exclamation)


                                End Try
                            Else
                                objTextWriter.WriteLine(strSQL_IFExist)
                                objTextWriter.WriteLine(get_SQL_BEGIN)
                                objTextWriter.WriteLine(strSQL)
                                objTextWriter.WriteLine(get_SQL_END)
                                objTextWriter.WriteLine("GO")
                            End If

                            'Debug.Print(strSQL)
                        End If
                    Next

                    If boolSaveSQL = True Then
                        If GUID_DBType = objLocalConfig.SemItem_Token_DB_Schema_Type_System.GUID Or GUID_DBType = objLocalConfig.SemItem_Token_DB_Schema_Type_User.GUID Then
                            strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL_insert_SemDB_Into_Change_DB__Local_.GUID)
                            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_DB.Name & "@", objSemItem_Database.GUID.ToString)
                            strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME_DB.Name & "@", objSemItem_Database.Name)
                            objTextWriter.WriteLine(strSQL)
                            objTextWriter.WriteLine("GO")
                        End If
                    End If

                    If GUID_DBType = objLocalConfig.SemItem_Token_DB_Schema_Type_System.GUID Or GUID_DBType = objLocalConfig.SemItem_Token_DB_Schema_Type_User.GUID Then
                        boolResult = Create_AttributeTypes(objConnection)
                        boolResult = Create_ObjectReferenceType(objConnection)
                        boolResult = Create_SemItems(objConnection, GUID_DBType)
                    End If



                    If boolSaveSQL = False Then
                        funcA_listExtendedProperties.Add_ExtendedProperty(objLocalConfig.SemItem_Token_Variable_SchemaVersion.Name, strVersion_Schema)
                        funcA_listExtendedProperties.Add_ExtendedProperty(objLocalConfig.SemItem_Token_Variable_SemDB.Name, "Yes")
                    Else
                        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL___addProperty.GUID)
                        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Property.Name & "@", objLocalConfig.SemItem_Token_Variable_SchemaVersion.Name)
                        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Value_Property.Name & "@", "'" & strVersion_Schema & "'")
                        objTextWriter.WriteLine(strSQL)
                        objTextWriter.WriteLine("GO")

                        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL___addProperty.GUID)
                        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Property.Name & "@", objLocalConfig.SemItem_Token_Variable_SemDB.Name)
                        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Value_Property.Name & "@", "'Yes'")
                        objTextWriter.WriteLine(strSQL)
                        objTextWriter.WriteLine("GO")
                    End If


                Catch ex As Exception
                    MsgBox(ex.Message & ": " & strSchemaItem, MsgBoxStyle.Exclamation)
                End Try

            Else
                boolResult = False
                MsgBox("Die Erzeugungs-Skripte der Datenbank-Objekte konnte nicht ermittelt werden!", MsgBoxStyle.Exclamation)
            End If




            Try
                objTextWriter.Close()
            Catch ex As Exception

            End Try
        Else
            MsgBox("Der Typ der Datenbank wurde nicht festgelegt!", MsgBoxStyle.Exclamation)
            boolResult = False
        End If

            If boolResult = True Then

                save_File(objSemItem_DBOnServer, objSemItem_Version, objSemItem_SchemaType, strPathSQL)
            End If

            Return boolResult
    End Function

    Private Function Create_AttributeTypes(ByVal objConnection As SqlClient.SqlConnection) As Boolean
        Dim objDRC_AttributeTypes As DataRowCollection
        Dim objDR_AttributeType As DataRow
        Dim semtblT_AttributeType As New ds_SemDB.semtbl_AttributeTypeDataTable
        Dim boolResult As Boolean = True
        Dim strSQL As String

        If boolSaveSQL = False Then
            semtblA_AttributeTYpe_New.Connection = objConnection
            semtblA_AttributeTYpe_New.Fill(semtblT_AttributeType)
        End If

        objDRC_AttributeTypes = semtblA_AttributeType_Templ.GetData().Rows
        For Each objDR_AttributeType In objDRC_AttributeTypes
            If boolSaveSQL = True Then
                strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL___insert_Datatypes.GUID)
                strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_DATATYPE.Name & "@", objDR_AttributeType.Item("GUID_AttributeType").ToString)
                strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME_DATATYPE.Name & "@", objDR_AttributeType.Item("Name_AttributeType"))
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            Else
                If semtblT_AttributeType.Select("GUID_AttributeType='" & objDR_AttributeType.Item("GUID_AttributeType").ToString & "'").Count = 0 Then
                    semtblA_AttributeTYpe_New.Insert(objDR_AttributeType.Item("GUID_AttributeType"), objDR_AttributeType.Item("Name_AttributeType"))
                End If
            End If


        Next

        Return boolResult
    End Function

    Private Function Create_ObjectReferenceType(ByVal objConnection As SqlClient.SqlConnection) As Boolean
        Dim objDRC_ObjectReferenceTypes As DataRowCollection
        Dim objDR_ObjectReferenceType As DataRow
        Dim semtblT_ObjectReferenceType As New ds_SemDB.semtbl_ORTypeDataTable
        Dim boolResult As Boolean = True
        Dim strSQL As String

        If boolSaveSQL = False Then
            semtblA_ORType_New.Connection = objConnection
            semtblA_ORType_New.Fill(semtblT_ObjectReferenceType)
        End If

        objDRC_ObjectReferenceTypes = semtblA_ORType_Templ.GetData().Rows
        For Each objDR_ObjectReferenceType In objDRC_ObjectReferenceTypes
            If boolSaveSQL = True Then
                strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL___insert_Object_Reference_Type.GUID)
                strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_ObjectReferenceType.Name & "@", objDR_ObjectReferenceType.Item("GUID_ObjectReferenceType").ToString)
                strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_ObjectReferenceType.Name & "@", objDR_ObjectReferenceType.Item("Name_ObjectReferenceType"))
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            Else
                If semtblT_ObjectReferenceType.Select("GUID_ObjectReferenceType='" & objDR_ObjectReferenceType.Item("GUID_ObjectReferenceType").ToString & "'").Count = 0 Then
                    semtblA_ORType_New.Insert(objDR_ObjectReferenceType.Item("GUID_ObjectReferenceType"), objDR_ObjectReferenceType.Item("Name_ObjectReferenceType"))
                End If
            End If


        Next

        Return boolResult
    End Function


    Private Function Create_SemItems(ByVal objConnection As SqlClient.SqlConnection, ByVal GUID_DBType As Guid) As Boolean
        Dim objDRC_SemItems As DataRowCollection
        Dim objDR_SemItem As DataRow
        Dim objDRC_SemItem_DB As DataRowCollection
        Dim funcT_Token_Token As New ds_Token.func_TokenTokenDataTable

        Dim objDRs_SemItem() As DataRow
        Dim objDRC_Attributes As DataRowCollection
        Dim objDR_Attribute As DataRow
        Dim objDRC_TypeRels As DataRowCollection
        Dim objDR_TypeRel As DataRow
        Dim objDRC_TokenRel As DataRowCollection
        Dim objDR_TokenRel As DataRow



        Dim strSQL As String

        objDRC_SemItems = procA_SemItems_Of_DatabaseSchema.GetData(objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                                   objLocalConfig.SemItem_Type_Semantic_Objects_of_DB_Schema.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID, _
                                                                   objSemItem_Schema.GUID).Rows
        For Each objDR_SemItem In objDRC_SemItems
            funcA_Token_Token.Fill_TokenToken_LeftRight(funcT_Token_Token, _
                                                        objDR_SemItem.Item("GUID_Semantic_Objects_of_DB_Schema"), _
                                                        objLocalConfig.SemItem_RelationType_belonging_Type.GUID, _
                                                        objLocalConfig.SemItem_Type_DB_Schema_Type.GUID)
            If funcT_Token_Token.Select("GUID_Token_Right='" & GUID_DBType.ToString & "'").Count > 0 Then

                Select Case objDR_SemItem.Item("GUID_ItemType")
                    Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                        objDRC_SemItem_DB = semtblA_Attribute.GetData_By_GUID(objDR_SemItem.Item("GUID_Ref")).Rows
                        If objDRC_SemItem_DB.Count > 0 Then
                            objSemWork.add_Attribute(objDRC_SemItem_DB(0).Item("GUID_Attribute"))
                        End If

                    Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                        objDRC_SemItem_DB = semtblA_RelationType.GetData_By_GUID(objDR_SemItem.Item("GUID_Ref")).Rows
                        If objDRC_SemItem_DB.Count > 0 Then
                            objSemWork.add_RelationType(objDRC_SemItem_DB(0).Item("GUID_RelationType"))
                        End If

                    Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        objDRC_SemItem_DB = semtblA_Token.GetData_Token_By_GUID(objDR_SemItem.Item("GUID_Ref")).Rows
                        If objDRC_SemItem_DB.Count > 0 Then
                            objSemWork.add_Token(objDRC_SemItem_DB(0).Item("GUID_Token"))
                        End If
                    Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                        objDRC_SemItem_DB = semtblA_Type.GetData_By_GUID(objDR_SemItem.Item("GUID_Ref")).Rows
                        If objDRC_SemItem_DB.Count > 0 Then
                            objSemWork.add_Type(objDRC_SemItem_DB(0).Item("GUID_Type"), True)
                        End If
                End Select

            End If

        Next

        write_TSQL_SemItems(objSemWork, objTextWriter, objConnection, boolSaveSQL)
        Return True
    End Function

    Public Sub write_TSQL_SemItems(ByRef objSemWork As clsSemWork, ByVal objTextWriter As IO.TextWriter, ByVal objConnection As SqlClient.SqlConnection, ByVal boolSaveSQL As Boolean)
        Dim objDRs_Types() As DataRow
        Dim objCMD As SqlClient.SqlCommand
        Dim strSQL As String

        objCMD = New SqlClient.SqlCommand
        objCMD.Connection = objConnection


        For Each objDR_SemItem In objSemWork.semtblT_Attribute.Rows


            strSQL = get_SQL_Insert_Attribute(objDR_SemItem.Item("GUID_Attribute"), objDR_SemItem.Item("Name_Attribute"), objDR_SemItem.Item("GUID_AttributeType"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If

        Next

        For Each objDR_SemItem In objSemWork.semtblT_RelationType.Rows
            strSQL = get_SQL_Insert_RelationType(objDR_SemItem.Item("GUID_RelationType"), objDR_SemItem.Item("Name_RelationType"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If


        Next
        objDRs_Types = objSemWork.semtblT_Type.Select("GUID_Type_Parent Is Null")
        For Each objDR_SemItem In objDRs_Types
            strSQL = get_SQL_Insert_Type(objDR_SemItem.Item("GUID_Type"), objDR_SemItem.Item("Name_Type"), Nothing)
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
            get_SubTypes(objTextWriter, objConnection, objDR_SemItem.Item("GUID_Type"), objSemWork, boolSaveSQL)


        Next

        For Each objDR_SemItem In objSemWork.semtblT_Token.Rows
            strSQL = get_SQL_Insert_Token(objDR_SemItem.Item("GUID_Token"), objDR_SemItem.Item("Name_Token"), objDR_SemItem.Item("GUID_Type"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Token_Token.Rows
            strSQL = get_SQL_Insert_Token_Token(objDR_SemItem.Item("GUID_Token_Left"), objDR_SemItem.Item("GUID_Token_Right"), objDR_SemItem.Item("GUID_RelationType"), objDR_SemItem.Item("OrderID"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Type_Attribute.Rows
            strSQL = get_SQL_Insert_Type_Attribute(objDR_SemItem.Item("GUID_Type"), objDR_SemItem.Item("GUID_Attribute"), objDR_SemItem.Item("Min"), objDR_SemItem.Item("Max"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Type_Type.Rows
            strSQL = get_SQL_Insert_Type_Type(objDR_SemItem.Item("GUID_Type_Left"), objDR_SemItem.Item("GUID_Type_Right"), objDR_SemItem.Item("GUID_RelationType"), objDR_SemItem.Item("Min_forw"), objDR_SemItem.Item("Max_forw"), objDR_SemItem.Item("Max_backw"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Token_Attribute.Rows
            strSQL = get_SQL_Insert_Token_Attribute(objDR_SemItem.Item("GUID_TokenAttribute"), objDR_SemItem.Item("GUID_Token"), objDR_SemItem.Item("GUID_Attribute"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Token_Attribute_Bit.Rows
            strSQL = get_SQL_Insert_Token_Attribute_Bit(objDR_SemItem.Item("GUID_TokenAttribute"), objDR_SemItem.Item("val"), objDR_SemItem.Item("OrderID"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Token_Attribute_Date.Rows
            strSQL = get_SQL_Insert_Token_Attribute_Date(objDR_SemItem.Item("GUID_TokenAttribute"), objDR_SemItem.Item("val"), objDR_SemItem.Item("OrderID"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Token_Attribute_datetime.Rows
            strSQL = get_SQL_Insert_Token_Attribute_Datetime(objDR_SemItem.Item("GUID_TokenAttribute"), objDR_SemItem.Item("val"), objDR_SemItem.Item("OrderID"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Token_Attribute_Int.Rows
            strSQL = get_SQL_Insert_Token_Attribute_Int(objDR_SemItem.Item("GUID_TokenAttribute"), objDR_SemItem.Item("val"), objDR_SemItem.Item("OrderID"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Token_Attribute_Real.Rows
            strSQL = get_SQL_Insert_Token_Attribute_Real(objDR_SemItem.Item("GUID_TokenAttribute"), objDR_SemItem.Item("val"), objDR_SemItem.Item("OrderID"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Token_Attribute_Time.Rows
            strSQL = get_SQL_Insert_Token_Attribute_Time(objDR_SemItem.Item("GUID_TokenAttribute"), objDR_SemItem.Item("val"), objDR_SemItem.Item("OrderID"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Token_Attribute_varchar255.Rows
            strSQL = get_SQL_Insert_Token_Attribute_VARCHAR255(objDR_SemItem.Item("GUID_TokenAttribute"), objDR_SemItem.Item("val"), objDR_SemItem.Item("OrderID"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Token_Attribute_varcharMAX.Rows

            strSQL = get_SQL_Insert_Token_Attribute_VARCHARMAX(objDR_SemItem.Item("GUID_TokenAttribute"), objDR_SemItem.Item("val"), objDR_SemItem.Item("OrderID"))
            strSQL = get_SQL_execute_SQL(strSQL)


            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR.Rows
            strSQL = get_SQL_Insert_OR(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_ORType"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR_Type.Rows
            strSQL = get_SQL_Insert_OR_Type(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_Type"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR_Attribute.Rows
            strSQL = get_SQL_Insert_OR_Attribute(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_Attribute"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR_RelationType.Rows
            strSQL = get_SQL_Insert_OR_RelationType(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_RelationType"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR_Token.Rows
            strSQL = get_SQL_Insert_OR_Token(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_Token"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR_Token_Attribute_Bit.Rows
            strSQL = get_SQL_Insert_OR_Token_Attribute_Bit(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_TokenAttribute"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR_Token_Attribute_Date.Rows
            strSQL = get_SQL_Insert_OR_Token_Attribute_Date(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_TokenAttribute"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR_Token_Attribute_Datetime.Rows
            strSQL = get_SQL_Insert_OR_Token_Attribute_DateTime(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_TokenAttribute"))
            strSQL = get_SQL_execute_SQL(strSQL)


            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR_Token_Attribute_Int.Rows
            strSQL = get_SQL_Insert_OR_Token_Attribute_Int(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_TokenAttribute"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR_Token_Attribute_Real.Rows
            strSQL = get_SQL_Insert_OR_Token_Attribute_Real(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_TokenAttribute"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR_Token_Attribute_Time.Rows
            strSQL = get_SQL_Insert_OR_Token_Attribute_Time(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_TokenAttribute"))
            strSQL = get_SQL_execute_SQL(strSQL)


            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR_Token_Attribute_Varchar255.Rows
            strSQL = get_SQL_Insert_OR_Token_Attribute_VARCHAR255(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_TokenAttribute"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_OR_Token_Attribute_VarcharMax.Rows
            strSQL = get_SQL_Insert_OR_Token_Attribute_VARCHARMAX(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_TokenAttribute"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Token_OR.Rows
            strSQL = get_SQL_Insert_Token_OR(objDR_SemItem.Item("GUID_ObjectReference"), objDR_SemItem.Item("GUID_RelationType"), objDR_SemItem.Item("GUID_Token_Left"), objDR_SemItem.Item("OrderID"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

        For Each objDR_SemItem In objSemWork.semtblT_Type_OR.Rows
            strSQL = get_SQL_Insert_Type_OR(objDR_SemItem.Item("GUID_Type"), objDR_SemItem.Item("GUID_RelationType"), objDR_SemItem.Item("Min_forw"), objDR_SemItem.Item("Max_forw"))
            strSQL = get_SQL_execute_SQL(strSQL)

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
        Next

    End Sub

    Private Sub get_SubTypes(ByVal objTextWriter As IO.TextWriter, ByVal objConnection As SqlClient.SqlConnection, ByVal GUID_Type_Parent As Guid, ByVal objSemWork As clsSemWork, ByVal boolSaveSQL As Boolean)
        Dim objCMD As New SqlClient.SqlCommand
        Dim objDRs_Types() As DataRow
        Dim objDR_Type As DataRow
        Dim strSQL As String

        objCMD.Connection = objConnection

        objDRs_Types = objSemWork.semtblT_Type.Select("GUID_Type_Parent='" & GUID_Type_Parent.ToString & "'")
        For Each objDR_Type In objDRs_Types
            strSQL = get_SQL_Insert_Type(objDR_Type.Item("GUID_Type"), objDR_Type.Item("Name_Type"), objDR_Type.Item("GUID_Type_Parent"))

            If boolSaveSQL = False Then
                objCMD.CommandText = strSQL
                objCMD.ExecuteNonQuery()
            Else
                objTextWriter.WriteLine(strSQL)
                objTextWriter.WriteLine("GO")
            End If
            get_SubTypes(objTextWriter, objConnection, objDR_Type.Item("GUID_Type"), objSemWork, boolSaveSQL)
        Next
    End Sub

    Public Function save_CreationScript_Of_DBSchema() As Boolean
        Dim boolResult As Boolean = True
        procA_Creationscript_Of_DBSchema_Work.CommandTimeout = 3600
        procA_Creationscript_Of_DBSchema_Work.GetData(objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                      objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                      objLocalConfig.SemItem_Type_Functions_in_Schema.GUID, _
                                                      objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                      objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID, _
                                                      objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                                      objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID, _
                                                      objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                                      objLocalConfig.SemItem_Type_Tables_in_Schema.GUID, _
                                                      objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                      objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID, _
                                                      objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                      objLocalConfig.SemItem_Type_Views_in_Schema.GUID, _
                                                      objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                      objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                      objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                      objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                      objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                      objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                      objLocalConfig.SemItem_RelationType_needs.GUID, _
                                                      objSemItem_Schema.GUID)
        Return boolResult
    End Function

    Private Sub get_CreationScripts_Of_Schema()
        procA_CreationScript_And_DBItems_Of_DBSchema_BY_GUIDDBSchema.Fill(procT_CreationScript_And_DBItems_Of_DBSchema_BY_GUIDDBSchema, _
                                                                          objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                          objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                                          objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                          objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                                          objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                                          objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                                                          objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                                                          objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                                          objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                                          objLocalConfig.SemItem_Type_Functions_in_Schema.GUID, _
                                                                          objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID, _
                                                                          objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID, _
                                                                          objLocalConfig.SemItem_Type_Tables_in_Schema.GUID, _
                                                                          objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID, _
                                                                          objLocalConfig.SemItem_Type_Views_in_Schema.GUID, _
                                                                          objLocalConfig.SemItem_Type_XML.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                          objSemItem_Schema.GUID)

    End Sub

    Private Function insert_CreationLvel_0()
        Dim objDR_CreationScript As DataRow
        Dim objDRC_Requirements As DataRowCollection


        Dim boolResult As Boolean = True
        get_CreationScripts_Of_Schema()

        For Each objDR_CreationScript In procT_CreationScript_And_DBItems_Of_DBSchema_BY_GUIDDBSchema.Rows
            objDRC_Requirements = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_CreationScript.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Function.GUID).Rows
            If objDRC_Requirements.Count = 0 Then
                objDRC_Requirements = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_CreationScript.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Views.GUID).Rows
                If objDRC_Requirements.Count = 0 Then
                    objDRC_Requirements = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_CreationScript.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Tables.GUID).Rows
                    If objDRC_Requirements.Count = 0 Then
                        objDRC_Requirements = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_CreationScript.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Synonyms.GUID).Rows
                        If objDRC_Requirements.Count = 0 Then
                            If save_CreationLevel(objDR_CreationScript, 0) = True Then
                                boolResult = True
                            Else
                                boolResult = False
                            End If
                        Else
                            If save_CreationLevel(objDR_CreationScript, 9999) = True Then
                                boolResult = True
                            Else
                                boolResult = False
                            End If
                        End If
                    Else
                        If save_CreationLevel(objDR_CreationScript, 9999) = True Then
                            boolResult = True
                        Else
                            boolResult = False
                        End If
                    End If
                Else
                    If save_CreationLevel(objDR_CreationScript, 9999) = True Then
                        boolResult = True
                    Else
                        boolResult = False
                    End If
                End If
            Else
                If save_CreationLevel(objDR_CreationScript, 9999) = True Then
                    boolResult = True
                Else
                    boolResult = False
                End If
            End If
        Next
        Return boolResult
    End Function
    Private Function save_CreationLevel(ByVal objDR_CreationScript As DataRow, ByVal intLevel As Integer) As Boolean
        Dim objDRC_Requirements As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim boolOK As Boolean = True
        Dim boolResult As Boolean = True

        objDRC_Requirements = semtblA_Token_Token.GetData_By_GUIDs(objSemItem_Schema.GUID, objDR_CreationScript.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_Requirements.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Schema.GUID, objDR_CreationScript.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_contains.GUID, intLevel).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                boolOK = False
            End If
        Else
            If objDR_CreationScript.Item("OrderID") <> intLevel Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Schema.GUID, objDR_CreationScript.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_contains.GUID, intLevel).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID And Not _
                    objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID And Not _
                    objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then
                    boolOK = False
                End If
            End If
        End If
        'objDRC_Requirements = procA_TokenAttribute_Int.GetData_By_GUIDAttribute_And_GUIDToken(objDR_CreationScript.Item("GUID_DBItemInSchema"), objLocalConfig.SemItem_Attribute_Creation_Level.GUID).Rows
        'If objDRC_Requirements.Count = 0 Then
        '    boolOK = True
        '    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_INT.GetData(objDR_CreationScript.Item("GUID_DBItemInSchema"), objLocalConfig.SemItem_Attribute_Creation_Level.GUID, Nothing, intLevel, 0).Rows
        '    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
        '        boolOK = False
        '    End If


        'Else
        '    If objDRC_Requirements(0).Item("Val") <> intLevel Then
        '        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_INT.GetData(objDR_CreationScript.Item("GUID_DBItemInSchema"), objLocalConfig.SemItem_Attribute_Creation_Level.GUID, objDRC_Requirements(0).Item("GUID_TokenAttribute"), intLevel, 0).Rows
        '        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
        '            boolOK = False
        '        End If
        '    End If

        'End If
        If boolOK = False Then
            boolResult = boolOK

        End If
        Return boolResult
    End Function

    'Private Function insert_CreationLevel_0(ByVal GUID_Type_DBItem As Guid, ByVal GUID_Type_DBItemInSchema As Guid) As Boolean
    '    Dim objDRC_DBItems_In_Schema As DataRowCollection
    '    Dim objDR_DBItems_In_Schema As DataRow
    '    Dim objRecreation_SQL As clsRecreation_SQL
    '    Dim objDRC_LogState As DataRowCollection

    '    Dim objDRC_Requirements As DataRowCollection
    '    Dim objSemItem_DBItem As New clsSemItem
    '    Dim objSemItem_DBItem_In_Schema As New clsSemItem

    '    Dim boolResult As Boolean = True
    '    Dim boolOK As Boolean


    '    objDRC_DBItems_In_Schema = procA_Item_in_Schema.GetData(GUID_Type_DBItem, GUID_Type_DBItemInSchema, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objSemItem_Schema.GUID).Rows
    '    For Each objDR_DBItems_In_Schema In objDRC_DBItems_In_Schema
    '        objSemItem_DBItem.GUID = objDR_DBItems_In_Schema.Item("GUID_DBItem")
    '        objSemItem_DBItem.Name = objDR_DBItems_In_Schema.Item("Name_DBItem")
    '        objSemItem_DBItem.GUID_Parent = GUID_Type_DBItem
    '        objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

    '        objRecreation_SQL = recreate_DBItem(objSemItem_DBItem)

    '        objSemItem_DBItem_In_Schema.GUID = objDR_DBItems_In_Schema.Item("GUID_ItemInSchema")
    '        objSemItem_DBItem_In_Schema.Name = objDR_DBItems_In_Schema.Item("Name_ItemInSchema")
    '        objSemItem_DBItem_In_Schema.GUID_Parent = GUID_Type_DBItemInSchema
    '        objSemItem_DBItem_In_Schema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

    '        objDRC_Requirements = funcA_Token_Token.GetData_TokenToken_LeftRight(objRecreation_SQL.GUID_CreationScript, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Function.GUID).Rows
    '        If objDRC_Requirements.Count = 0 Then
    '            objDRC_Requirements = funcA_Token_Token.GetData_TokenToken_LeftRight(objRecreation_SQL.GUID_CreationScript, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Views.GUID).Rows
    '            If objDRC_Requirements.Count = 0 Then
    '                objDRC_Requirements = funcA_Token_Token.GetData_TokenToken_LeftRight(objRecreation_SQL.GUID_CreationScript, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Tables.GUID).Rows
    '                If objDRC_Requirements.Count = 0 Then
    '                    objDRC_Requirements = funcA_Token_Token.GetData_TokenToken_LeftRight(objRecreation_SQL.GUID_CreationScript, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Synonyms.GUID).Rows
    '                    If objDRC_Requirements.Count = 0 Then
    '                        objDRC_Requirements = procA_TokenAttribute_Int.GetData_By_GUIDAttribute_And_GUIDToken(objRecreation_SQL.GUID_CreationScript, objLocalConfig.SemItem_Attribute_Creation_Level.GUID).Rows
    '                        If objDRC_Requirements.Count = 0 Then
    '                            boolOK = True
    '                            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_INT.GetData(objRecreation_SQL.GUID_CreationScript, objLocalConfig.SemItem_Attribute_Creation_Level.GUID, Nothing, 0, 0).Rows
    '                            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
    '                                boolOK = False
    '                            End If


    '                        Else
    '                            If objDRC_Requirements(0).Item("Val") <> 0 Then
    '                                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_INT.GetData(objRecreation_SQL.GUID_CreationScript, objLocalConfig.SemItem_Attribute_Creation_Level.GUID, objDRC_Requirements(0).Item("GUID_TokenAttribute"), 0, 0).Rows
    '                                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
    '                                    boolOK = False
    '                                End If
    '                            End If

    '                        End If
    '                        If boolOK = True Then
    '                            objDRC_Requirements = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(objRecreation_SQL.GUID_CreationScript, objLocalConfig.SemItem_Attribute_Creation_Script.GUID).Rows
    '                            If objDRC_Requirements.Count = 0 Then
    '                                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objRecreation_SQL.GUID_CreationScript, objLocalConfig.SemItem_Attribute_Creation_Script.GUID, Nothing, objRecreation_SQL.SQL_Create, 0).Rows
    '                            Else
    '                                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objRecreation_SQL.GUID_CreationScript, objLocalConfig.SemItem_Attribute_Creation_Script.GUID, objDRC_Requirements(0).Item("GUID_TokenAttribute"), objRecreation_SQL.SQL_Create, 0).Rows
    '                            End If

    '                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
    '                                boolResult = False
    '                            Else
    '                                boolResult = True
    '                            End If
    '                        Else
    '                            boolResult = False
    '                        End If

    '                    End If
    '                End If
    '            End If
    '        End If
    '    Next
    '    Return boolResult
    'End Function
    
    Private Function set_CreationLevel(ByVal intLevel As Integer) As Boolean
        Dim objDRs_DBItems() As DataRow
        Dim objDRs_DBItem_Level_Plus_1() As DataRow
        Dim objDRC_Requirements As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_Requirements As DataRow
        Dim objDR_DBItems As DataRow
        Dim boolResult As Boolean = True
        Dim boolCreationLevel_Next As Boolean
        get_CreationScripts_Of_Schema()

        boolCreationLevel_Next = False
        objDRs_DBItems = procT_CreationScript_And_DBItems_Of_DBSchema_BY_GUIDDBSchema.Select("OrderID=" & intLevel)
        For Each objDR_DBItems In objDRs_DBItems


            objDRC_Requirements = funcA_Token_Token.GetData_TokenToken_RightLeft(objDR_DBItems.Item("GUID_DBItem"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Creation_Scripts.GUID).Rows
            For Each objDR_Requirements In objDRC_Requirements
                objDRs_DBItem_Level_Plus_1 = procT_CreationScript_And_DBItems_Of_DBSchema_BY_GUIDDBSchema.Select("GUID_CreationScript='" & objDR_Requirements.Item("GUID_Token_Left").ToString & "'")
                If objDRs_DBItem_Level_Plus_1.Count = 1 Then
                    If objDRs_DBItem_Level_Plus_1(0).Item("OrderID") <> intLevel + 1 Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objDRs_DBItem_Level_Plus_1(0).Item("GUID_DBSchema"), objDRs_DBItem_Level_Plus_1(0).Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_contains.GUID, intLevel + 1).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID And Not _
                            objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID And Not _
                            objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then
                            boolResult = False
                            Exit For
                        End If
                    End If

                    boolCreationLevel_Next = True
                End If
            Next


        Next

        If boolCreationLevel_Next = True Then
            set_CreationLevel(intLevel + 1)
        End If


        Return boolResult
    End Function
    Private Sub set_DBConnection()

        semtblA_Token_Token.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_VarcharMAX.Connection = objLocalConfig.Connection_DB
        procA_CreationScript_And_XML_Of_DBItem_By_GUIDDBItem.Connection = objLocalConfig.Connection_Plugin
        funcA_DatabaseSchema_with_Version_and_Logentry.Connection = objLocalConfig.Connection_Plugin
        procA_Item_in_Schema.Connection = objLocalConfig.Connection_Plugin
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_INT.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_Int.Connection = objLocalConfig.Connection_DB
        procA_CreationScripts_And_DBItemInSchema_Of_DBSchema_By_GUIDDbSchema.Connection = objLocalConfig.Connection_Plugin
        procA_TokenAttribute_Varchar255.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        procA_CreationScript_Of_DBSchema_GUID_DBSchema_Ordered.Connection = objLocalConfig.Connection_Plugin
        funcA_CreationScript_belongsTo_DBSchema.Connection = objLocalConfig.Connection_Plugin
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
        funcA_listExtendedProperties.Connection = objLocalConfig.Connection_Plugin
        semtblA_AttributeType_Templ.Connection = objLocalConfig.Connection_DB
        procA_Type_OR_By_GUIDType.Connection = objLocalConfig.Connection_DB
        procA_SemItems_Of_DatabaseSchema.Connection = objLocalConfig.Connection_Plugin
        funcA_SemDatabasesOnServers.Connection = objLocalConfig.Connection_Plugin
        procA_Creationscript_Of_DBSchema_Work.Connection = objLocalConfig.Connection_Plugin
        procA_CreationScript_And_DBItems_Of_DBSchema_BY_GUIDDBSchema.Connection = objLocalConfig.Connection_Plugin

        typefuncA_Types_With_Attributes_And_Types.Connection = objLocalConfig.Connection_DB
        typefuncA_Types_Rel.Connection = objLocalConfig.Connection_DB

        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_RelationType.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB

        chngtblA_DB.Connection = objLocalConfig.Connection_DB
        objFileWork = New clsFileWork(objLocalConfig.Globals)
        objSemWork = New clsSemWork(objLocalConfig.Globals)

        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
        objTransaction_DBFiles = New clsTransaction_DBFiles(objLocalConfig)
        objTransaction_DBViewSchema = New clsTransaction_DBViewSchema()
    End Sub

    Public Function create_Database(ByVal strName_DB As String, ByVal strServer As String) As Boolean
        Dim objConnection As SqlClient.SqlConnection
        Dim objSQLCMD As SqlClient.SqlCommand
        Dim strSQL_CreateDB As String
        Dim strSQL As String

        objConnection = New SqlClient.SqlConnection("Data Source=" & strServer & ";Initial Catalog=;Integrated Security=True")
        objConnection.Open()

        strSQL_CreateDB = get_SQL_Create_Database(strName_DB)
        objSQLCMD = New SqlClient.SqlCommand(strSQL_CreateDB, objConnection)
        objSQLCMD.ExecuteNonQuery()
        objConnection.Close()

        objConnection = New SqlClient.SqlConnection("Data Source=" & strServer & ";Initial Catalog=" & strName_DB & ";Integrated Security=True")
        objConnection.Open()

        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL___addProperty.GUID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Property.Name & "@", objLocalConfig.SemItem_Token_Variable_SchemaVersion.Name)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Value_Property.Name & "@", "'0.0.0.1'")
        objSQLCMD = New SqlClient.SqlCommand(strSQL, objConnection)
        objSQLCMD.ExecuteNonQuery()

        strSQL = get_SQL(objLocalConfig.SemItem_Token_XML_TSQL___addProperty.GUID)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Property.Name & "@", objLocalConfig.SemItem_Token_Variable_SemDB.Name)
        strSQL = strSQL.Replace("@" & objLocalConfig.SemItem_Token_Variable_Value_Property.Name & "@", "'Yes'")
        objSQLCMD = New SqlClient.SqlCommand(strSQL, objConnection)
        objSQLCMD.ExecuteNonQuery()

        objConnection.Close()
        If DB_exists(strServer, strName_DB) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function DB_exists(ByVal strName_Server As String, ByVal strDB_Name As String) As Boolean
        Dim objServerCon As ServerConnection
        Dim objServer As Server
        Dim objDatabase As Database
        Dim boolResult As Boolean = False



        objServerCon = New ServerConnection
        objServerCon.ServerInstance = strName_Server
        objServerCon.LoginSecure = True
        objServer = New Server(objServerCon)

        For Each objDatabase In objServer.Databases
            If objDatabase.Name.ToLower = strDB_Name.ToLower Then
                boolResult = True
                Exit For
            End If
        Next

        Return boolResult
    End Function

    Public Function get_Database(ByVal objSemItem_DatabaseOnServer As clsSemItem) As clsDatabase
        Dim objDatabase As New clsDatabase
        Dim objDRC_DatabaseOnServer As DataRowCollection

        objDRC_DatabaseOnServer = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DatabaseOnServer.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                 objLocalConfig.SemItem_Type_Database.GUID).Rows
        If objDRC_DatabaseOnServer.Count > 0 Then
            objDatabase.Name_Database = objDRC_DatabaseOnServer(0).Item("Name_Token_Right")
        End If

        objDRC_DatabaseOnServer = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DatabaseOnServer.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                                                                 objLocalConfig.SemItem_Type_Server.GUID).Rows
        If objDRC_DatabaseOnServer.Count > 0 Then
            objDatabase.Name_Server = objDRC_DatabaseOnServer(0).Item("Name_Token_Right")
        End If
        Return objDatabase
    End Function

    Public Function save_File(ByVal objSemItem_Rel As clsSemItem, ByVal objSemItem_Version As clsSemItem, ByVal objSemItem_Type As clsSemItem, ByVal strPath_File As String) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_File As clsSemItem

        objSemItem_File = New clsSemItem
        objSemItem_File.GUID = Guid.NewGuid
        objSemItem_File.Name = objSemItem_Rel.Name
        objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
        objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        objSemItem_File.Additional1 = strPath_File

        objSemItem_Result = objTransaction_DBFiles.save_002_File(objSemItem_File)

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_DBFiles.save_003_Ref_To_File(objSemItem_Rel, objSemItem_Type)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_DBFiles.save_004_File_To_Version(objSemItem_Version)
                objSemItem_Result = objTransaction_DBViewSchema.save_011_Version(objSemItem_Rel, objSemItem_Version)
            Else
                objTransaction_DBFiles.del_002_File()
            End If

        End If

        Return objSemItem_Result
    End Function
End Class
