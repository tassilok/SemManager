Imports System.Text.RegularExpressions
Public Class clsGlobals
    Private strEL_Server As String
    Private strEL_Index As String

    Private cintSearchRange As Integer = 20000

    Private objOItem_Class_Root As clsOntologyItem
    Private objOItem_DType_Bool As clsOntologyItem
    Private objOItem_DType_DateTime As clsOntologyItem
    Private objOItem_DType_Int As clsOntologyItem
    Private objOItem_DType_Real As clsOntologyItem
    Private objOItem_DType_String As clsOntologyItem

    Private objOItem_Class_Logstate As clsOntologyItem

    Private strRegEx_GUID As String

    Private objLogState_Success As clsOntologyItem
    Private objLogState_Error As clsOntologyItem
    Private objLogState_Nothing As clsOntologyItem
    Private objLogState_Insert As clsOntologyItem
    Private objLogState_Update As clsOntologyItem
    Private objLogState_Delete As clsOntologyItem
    Private objLogState_Relation As clsOntologyItem
    Private objLogState_Exists As clsOntologyItem

    Private objELSearchResult As ElasticSearch.Client.Domain.SearchResult
    Private objELQuery As ElasticSearch.Client.QueryDSL.BoolQuery

    Private dtblT_Config As New DataSet_Config.dtbl_BaseConfigDataTable

    Private objType_ObjectRel As New clsDocType
    Private objType_DataType As New clsDocType
    Private objType_ItemType As New clsDocType
    Private objType_ObjectAtt As New clsDocType
    Private objType_Class As New clsDocType
    Private objType_AttributeType As New clsDocType
    Private objType_Object As New clsDocType

    

    Public ReadOnly Property SearchRange As Integer
        Get
            Return cintSearchRange
        End Get
    End Property

    Public ReadOnly Property Server
        Get
            Return strEL_Server
        End Get
    End Property

    Public ReadOnly Property Index
        Get
            Return strEL_Index
        End Get
    End Property

    

    Public ReadOnly Property Root As clsOntologyItem
        Get
            Return objOItem_Class_Root
        End Get
    End Property

    Public ReadOnly Property DType_Bool As clsOntologyItem
        Get
            Return objOItem_DType_Bool
        End Get
    End Property

    Public ReadOnly Property DType_DateTime As clsOntologyItem
        Get
            Return objOItem_DType_DateTime
        End Get
    End Property

    Public ReadOnly Property DType_Int As clsOntologyItem
        Get
            Return objOItem_DType_Int
        End Get
    End Property

    Public ReadOnly Property DType_Real As clsOntologyItem
        Get
            Return objOItem_DType_Real
        End Get
    End Property

    Public ReadOnly Property DType_String As clsOntologyItem
        Get
            Return objOItem_DType_String
        End Get
    End Property

    Public ReadOnly Property LState_Delete As clsOntologyItem
        Get
            Return objLogState_Delete
        End Get
    End Property

    Public ReadOnly Property LState_Error As clsOntologyItem
        Get
            Return objLogState_Error
        End Get
    End Property

    Public ReadOnly Property LState_Exists As clsOntologyItem
        Get
            Return objLogState_Exists
        End Get
    End Property

    Public ReadOnly Property LState_Insert As clsOntologyItem
        Get
            Return objLogState_Insert
        End Get
    End Property

    Public ReadOnly Property LState_Nothing As clsOntologyItem
        Get
            Return objLogState_Nothing
        End Get
    End Property

    Public ReadOnly Property LState_Relation As clsOntologyItem
        Get
            Return objLogState_Relation
        End Get
    End Property

    Public ReadOnly Property LState_Success As clsOntologyItem
        Get
            Return objLogState_Success
        End Get
    End Property

    Public ReadOnly Property LState_Update As clsOntologyItem
        Get
            Return objLogState_Update
        End Get
    End Property

    Private Sub set_TypeFields()
        objType_AttributeType.Doc = 

    End Sub

    Private Sub set_LogStates()
        objOItem_Class_Logstate = New clsOntologyItem("1d9568af-b6da-4990-8f4d-907dfdd30749", "Logstate", objOItem_Type_Class.GUID)

        objLogState_Delete = New clsOntologyItem("BB6A9555-3AF6-40FC-9FB0-489D2678DFF2", "Delete", objOItem_Class_Logstate.GUID)
        objLogState_Error = New clsOntologyItem("cc714341-7631-4b78-b8f4-385db073635f", "Error", objOItem_Class_Logstate.GUID)
        objLogState_Exists = New clsOntologyItem("0b285306-f64d-4444-bffe-627a21687eff", "Exist", objOItem_Class_Logstate.GUID)
        objLogState_Insert = New clsOntologyItem("a6df6ab2-3590-45b1-b325-35334a2f574a", "Insert", objOItem_Class_Logstate.GUID)
        objLogState_Nothing = New clsOntologyItem("95666887-fb2a-416e-9624-a48d48dc5446", "Nothing", objOItem_Class_Logstate.GUID)
        objLogState_Relation = New clsOntologyItem("a46b7472-3c8e-44a8-b785-3913b760db22", "Relation", objOItem_Class_Logstate.GUID)
        objLogState_Success = New clsOntologyItem("84251164-265e-4e02-94b2-ed7c40a02e56", "Success", objOItem_Class_Logstate.GUID)
        objLogState_Update = New clsOntologyItem("2bf7e9d6-fb9c-4092-9b16-ecc4fef7c072", "Update", objOItem_Class_Logstate.GUID)

    End Sub

    Private Sub set_DataTypes()
        objOItem_DType_Bool = New clsOntologyItem("dd858f27-d5e1-4363-a5c3-3e561e432333", "Bool", objOItem_Type_DataType.GUID)
        objOItem_DType_DateTime = New clsOntologyItem("905fda81-788f-4e3d-8329-3e55ae984b9e", "Datetime", objOItem_Type_DataType.GUID)
        objOItem_DType_Int = New clsOntologyItem("3a4f5b7b-da75-4980-933e-fbc33cc51439", "Int", objOItem_Type_DataType.GUID)
        objOItem_DType_Real = New clsOntologyItem("a1244d0e-187f-46ee-8574-2fc334077b7d", "Real", objOItem_Type_DataType.GUID)
        objOItem_DType_String = New clsOntologyItem("64530b52-d96c-4df1-86fe-183f44513450", "String", objOItem_Type_DataType.GUID)

    End Sub

    Public Function is_GUID(ByVal strText As String) As Boolean
        Dim objRegExp As New Regex(strRegEx_GUID)
        If objRegExp.IsMatch(strText) And Not strText = "00000000-0000-0000-0000-000000000000" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub get_ConfigData()
        Dim objDRs_ConfigItem() As DataRow
        dtblT_Config.ReadXml("Config\Config_ont.xml")
        If dtblT_Config.Rows.Count > 0 Then
            objDRs_ConfigItem = dtblT_Config.Select("ConfigItem_Name='Index'")
            If objDRs_ConfigItem.Count > 0 Then
                strEL_Index = objDRs_ConfigItem(0).Item("ConfigItem_Value")
            Else
                Err.Raise(1, "Config")
            End If

            objDRs_ConfigItem = dtblT_Config.Select("ConfigItem_Name='Server'")
            If objDRs_ConfigItem.Count > 0 Then
                strEL_Type = objDRs_ConfigItem(0).Item("ConfigItem_Value")
            Else
                Err.Raise(1, "Config")
            End If
        Else
            Err.Raise(1, "Config")
        End If
    End Sub
    Public Sub New()
        objOItem_Class_Root = New clsOntologyItem("49fdcd27-e105-4770-941d-7485dcad08c1", "Root", "dbbfc1a0-0c2e-4836-8434-0a7b7a8b4b52")
        strRegEx_GUID = "[A-Za-z0-9]{8}-[A-Za-z0-9]{4}-[A-Za-z0-9]{4}-[A-Za-z0-9]{4}-[A-Za-z0-9]{12}"
        get_ConfigData()
        set_OTypes()
        set_DataTypes()
        set_LogStates()
        set_TypeFields()
    End Sub
End Class
