Imports System.Text.RegularExpressions
Public Class clsGlobals

    Private cstrField_ID_Item As String = "ID_Item"
    Private cstrField_ID_Object As String = "ID_Object"
    Private cstrField_ID_Parent_Other As String = "ID_Parent_Other"
    Private cstrField_Ontology As String = "Ontology"
    Private cstrField_OrderID As String = "OrderID"
    Private cstrField_ID_Other As String = "ID_Other"
    Private cstrField_ID_Parent_Object As String = "ID_Parent_Object"
    Private cstrField_ID_RelationType As String = "ID_RelationType"
    Private cstrField_Name_RelationType As String = "Name_RelationType"
    Private cstrField_Name_Object As String = "Name_Object"
    Private cstrField_Name_AttributeType As String = "AttributeType"
    Private cstrField_Name_Item As String = "Name_Item"
    Private cstrField_ID_DataType As String = "ID_DataType"
    Private cstrField_ID_Parent As String = "ID_Parent"
    Private cstrField_ID_Class As String = "ID_Class"
    Private cstrField_Val_Int As String = "Val_Int"
    Private cstrField_Val_Bool As String = "Val_Bool"
    Private cstrField_Val_Real As String = "Val_Real"
    Private cstrField_ID_AttributeType As String = "ID_AttributeType"
    Private cstrField_Val_String As String = "Val_String"
    Private cstrField_Val_Datetime As String = "Val_Datetime"
    Private cstrField_Val_Name As String = "Val_Name"
    Private cstrField_ID_Class_Left As String = "ID_Class_Left"
    Private cstrField_ID_Class_Right As String = "ID_Class_Right"
    Private cstrField_Min_Forw As String = "Min_forw"
    Private cstrField_Max_Forw As String = "Max_forw"
    Private cstrField_Max_Backw As String = "Max_backw"
    Private cstrField_Min As String = "Min"
    Private cstrField_Max As String = "Max"
    Private cstrField_ID_Attribute As String = "ID_Attribute"



    private cstrType_ObjectRel = "ObjectRel"
    Private cstrType_Class = "Class"
    Private cstrType_ClassRel = "ClassRel"
    Private cstrType_ClassAtt = "ClassAtt"
    Private cstrType_DataType = "DataType"
    Private cstrType_Object = "Object"
    Private cstrType_ObjectAtt = "ObjectAttribute"
    Private cstrType_RelationType = "RelationType"
    Private cstrType_AttributeType = "AttributeType"
    Private cstrType_Attribute = "Attribute"
    Private cstrType_Other = "Other"
    Private cstrType_Other_AttType = "Other_AttType"
    Private cstrType_Other_RelType = "Other_RelType"
    Private cstrType_Other_Classes = "Other_Classes"

    
    Private strEL_Server As String
    Private strEL_Port As String
    Private strEL_Index As String

    Private strRep_Server As String
    Private strRep_Instance As String
    Private strRep_Database As String

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

    Private objDirection_LeftRight As clsOntologyItem
    Private objDirection_RightLeft As clsOntologyItem

    Private objRelationType_Contains As clsOntologyItem

    Private objELSearchResult As ElasticSearch.Client.Domain.SearchResult
    Private objELQuery As ElasticSearch.Client.QueryDSL.BoolQuery

    Private dtblT_Config As New DataSet_Config.dtbl_BaseConfigDataTable

    Private GUID_Session As String

    Private Sub set_RelationTypes()
        objRelationType_Contains = New clsOntologyItem
        objRelationType_Contains.GUID = "e971160347db44d8a476fe88290639a4"
        objRelationType_Contains.Name = "contains"
        objRelationType_Contains.Type = cstrType_RelationType
    End Sub

    Public Function get_ConnectionStr(ByVal strServer As String, ByVal strInstance As String, ByVal strDatabase As String) As String
        Dim strConn As String
        strConn = "Data Source=" & strServer
        If strInstance <> "" Then
            strConn = strConn & "\" & strInstance
        End If
        strConn = strConn & ";Initial Catalog=" & strDatabase & ";Integrated Security=True"

        Return strConn
    End Function

    Public ReadOnly Property RelationType_contains As clsOntologyItem
        Get
            Return objRelationType_Contains
        End Get
    End Property

    Public ReadOnly Property Rep_Server As String
        Get
            Return strRep_Server
        End Get
    End Property
    Public ReadOnly Property Rep_Instance As String
        Get
            Return strRep_Instance
        End Get
    End Property
    Public ReadOnly Property Rep_Database As String
        Get
            Return strRep_Database
        End Get
    End Property
    Public ReadOnly Property Session As String
        Get
            Return GUID_Session
        End Get
    End Property
    Public ReadOnly Property Port As String
        Get
            Return strEL_Port
        End Get
    End Property

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

    Public ReadOnly Property Type_AttributeType As String
        Get
            Return cstrType_AttributeType
        End Get
    End Property

    Public ReadOnly Property Type_Attribute As String
        Get
            Return cstrType_Attribute
        End Get
    End Property

    Public ReadOnly Property Type_Class As String
        Get
            Return cstrType_Class
        End Get
    End Property

    Public ReadOnly Property Type_DataType As String
        Get
            Return cstrType_DataType
        End Get
    End Property

    Public ReadOnly Property Type_Object As String
        Get
            Return cstrType_Object
        End Get
    End Property

    Public ReadOnly Property Type_ObjectAtt As String
        Get
            Return cstrType_ObjectAtt
        End Get
    End Property

    Public ReadOnly Property Type_ObjectRel As String
        Get
            Return cstrType_ObjectRel
        End Get
    End Property

    Public ReadOnly Property Type_Other As String
        Get
            Return cstrType_Other
        End Get
    End Property

    Public ReadOnly Property Type_Other_AttType As String
        Get
            Return cstrType_Other_AttType
        End Get
    End Property

    Public ReadOnly Property Type_Other_Classes As String
        Get
            Return cstrType_Other_Classes
        End Get
    End Property

    Public ReadOnly Property Type_Other_RelType As String
        Get
            Return cstrType_Other_RelType
        End Get
    End Property

    Public ReadOnly Property Type_RelationType As String
        Get
            Return cstrType_RelationType
        End Get
    End Property


    Public ReadOnly Property Type_ClassRel As String
        Get
            Return cstrType_ClassRel
        End Get
    End Property

    Public ReadOnly Property Type_ClassAtt As String
        Get
            Return cstrType_ClassAtt
        End Get
    End Property


    'Fields
    Public ReadOnly Property Field_ID_Object As String
        Get
            Return cstrField_ID_Object
        End Get
    End Property

    Public ReadOnly Property Field_ID_Item As String
        Get
            Return cstrField_ID_Item
        End Get
    End Property

    Public ReadOnly Property Field_ID_Class_Left As String
        Get
            Return cstrField_ID_Class_Left
        End Get
    End Property

    Public ReadOnly Property Field_ID_Class_Right As String
        Get
            Return cstrField_ID_Class_Right
        End Get
    End Property

    Public ReadOnly Property Field_Max_forw As String
        Get
            Return cstrField_Max_Forw
        End Get
    End Property

    Public ReadOnly Property Field_Min_forw As String
        Get
            Return cstrField_Min_Forw
        End Get
    End Property

    Public ReadOnly Property Field_Min As String
        Get
            Return cstrField_Min
        End Get
    End Property

    Public ReadOnly Property Field_Max As String
        Get
            Return cstrField_Max
        End Get
    End Property

    Public ReadOnly Property Field_Max_backw As String
        Get
            Return cstrField_Max_Backw
        End Get
    End Property

    Public ReadOnly Property Field_ID_AttributeType As String
        Get
            Return cstrField_ID_AttributeType
        End Get
    End Property

    Public ReadOnly Property Field_ID_Class As String
        Get
            Return cstrField_ID_Class
        End Get
    End Property

    Public ReadOnly Property Field_ID_DataType As String
        Get
            Return cstrField_ID_DataType
        End Get
    End Property

    Public ReadOnly Property Field_Ontology As String
        Get
            Return cstrField_Ontology
        End Get
    End Property

    Public ReadOnly Property Field_ID_Parent As String
        Get
            Return cstrField_ID_Parent
        End Get
    End Property

    Public ReadOnly Property Field_ID_Parent_Object As String
        Get
            Return cstrField_ID_Parent_Object
        End Get
    End Property

    Public ReadOnly Property Field_ID_Parent_Other As String
        Get
            Return cstrField_ID_Parent_Other
        End Get
    End Property

    Public ReadOnly Property Field_ID_RelationType As String
        Get
            Return cstrField_ID_RelationType
        End Get
    End Property

    Public ReadOnly Property Field_ID_Other As String
        Get
            Return cstrField_ID_Other
        End Get
    End Property

    Public ReadOnly Property Field_Name_AttributeType As String
        Get
            Return cstrField_Name_AttributeType
        End Get
    End Property

    Public ReadOnly Property Field_Name_Object As String
        Get
            Return cstrField_Name_Object
        End Get
    End Property

    Public ReadOnly Property Field_Name_Item As String
        Get
            Return cstrField_Name_Item
        End Get
    End Property

    Public ReadOnly Property Field_Name_RelationType As String
        Get
            Return cstrField_Name_RelationType
        End Get
    End Property

    Public ReadOnly Property Field_OrderID As String
        Get
            Return cstrField_OrderID
        End Get
    End Property

    Public ReadOnly Property Field_Val_Bool As String
        Get
            Return cstrField_Val_Bool
        End Get
    End Property

    Public ReadOnly Property Field_Val_Datetime As String
        Get
            Return cstrField_Val_Datetime
        End Get
    End Property

    Public ReadOnly Property Field_Val_Int As String
        Get
            Return cstrField_Val_Int
        End Get
    End Property

    Public ReadOnly Property Field_Val_Real As String
        Get
            Return cstrField_Val_Real
        End Get
    End Property

    Public ReadOnly Property Field_Val_String As String
        Get
            Return cstrField_Val_String
        End Get
    End Property

    Public ReadOnly Property Field_Val_Name As String
        Get
            Return cstrField_Val_Name
        End Get
    End Property

    Public ReadOnly Property Field_ID_Attribute As String
        Get
            Return cstrField_ID_Attribute
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

    Public ReadOnly Property Direction_LeftRight As clsOntologyItem
        Get
            Return objDirection_LeftRight
        End Get
    End Property

    Public ReadOnly Property Direction_RightLeft As clsOntologyItem
        Get
            Return objDirection_RightLeft
        End Get
    End Property

    Private Sub set_TypeFields()
        
    End Sub



    Private Sub set_LogStates()
        objOItem_Class_Logstate = New clsOntologyItem("1d9568afb6da49908f4d907dfdd30749", "Logstate", cstrType_Class)

        objLogState_Delete = New clsOntologyItem("BB6A95553AF640FC9FB0489D2678DFF2", "Delete", objOItem_Class_Logstate.GUID)
        objLogState_Error = New clsOntologyItem("cc71434176314b78b8f4385db073635f", "Error", objOItem_Class_Logstate.GUID)
        objLogState_Exists = New clsOntologyItem("0b285306f64d4444bffe627a21687eff", "Exist", objOItem_Class_Logstate.GUID)
        objLogState_Insert = New clsOntologyItem("a6df6ab2359045b1b32535334a2f574a", "Insert", objOItem_Class_Logstate.GUID)
        objLogState_Nothing = New clsOntologyItem("95666887fb2a416e-9624a48d48dc5446", "Nothing", objOItem_Class_Logstate.GUID)
        objLogState_Relation = New clsOntologyItem("a46b74723c8e44a8b7853913b760db22", "Relation", objOItem_Class_Logstate.GUID)
        objLogState_Success = New clsOntologyItem("84251164265e4e0294b2ed7c40a02e56", "Success", objOItem_Class_Logstate.GUID)
        objLogState_Update = New clsOntologyItem("2bf7e9d6fb9c40929b16ecc4fef7c072", "Update", objOItem_Class_Logstate.GUID)

    End Sub

    Private Sub set_DataTypes()
        objOItem_DType_Bool = New clsOntologyItem("dd858f27d5e14363-a5c33e561e432333", "Bool", cstrType_DataType)
        objOItem_DType_DateTime = New clsOntologyItem("905fda81788f4e3d83293e55ae984b9e", "Datetime", cstrType_DataType)
        objOItem_DType_Int = New clsOntologyItem("3a4f5b7bda754980933efbc33cc51439", "Int", cstrType_DataType)
        objOItem_DType_Real = New clsOntologyItem("a1244d0e187f46ee85742fc334077b7d", "Real", cstrType_DataType)
        objOItem_DType_String = New clsOntologyItem("64530b52d96c4df186fe183f44513450", "String", cstrType_DataType)

    End Sub

    Public Function is_GUID(ByVal strText As String) As Boolean
        Dim objRegExp As New Regex(strRegEx_GUID)
        If objRegExp.IsMatch(strText) And Not strText = "00000000000000000000000000000000" Then
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
                strEL_Server = objDRs_ConfigItem(0).Item("ConfigItem_Value")
            Else
                Err.Raise(1, "Config")
            End If

            objDRs_ConfigItem = dtblT_Config.Select("ConfigItem_Name='Port'")
            If objDRs_ConfigItem.Count > 0 Then
                strEL_Port = objDRs_ConfigItem(0).Item("ConfigItem_Value")
            Else
                Err.Raise(1, "Config")
            End If

            objDRs_ConfigItem = dtblT_Config.Select("ConfigItem_Name='server_report'")
            If objDRs_ConfigItem.Count > 0 Then
                strRep_Server = objDRs_ConfigItem(0).Item("ConfigItem_Value")
            Else
                Err.Raise(1, "Config")
            End If

            objDRs_ConfigItem = dtblT_Config.Select("ConfigItem_Name='server_instance'")
            If objDRs_ConfigItem.Count > 0 Then
                strRep_Instance = objDRs_ConfigItem(0).Item("ConfigItem_Value")
            Else
                Err.Raise(1, "Config")
            End If

            objDRs_ConfigItem = dtblT_Config.Select("ConfigItem_Name='database'")
            If objDRs_ConfigItem.Count > 0 Then
                strRep_Database = objDRs_ConfigItem(0).Item("ConfigItem_Value")
            Else
                Err.Raise(1, "Config")
            End If
        Else
            Err.Raise(1, "Config")
        End If
    End Sub

    Private Sub set_Directions()
        objDirection_LeftRight = New clsOntologyItem("cc99d5365d564fd29d4f45b48af33029", "Left-Right", cstrType_Object)
        objDirection_RightLeft = New clsOntologyItem("061243fc4c134bd5800c2c33b70e99b2", "Right-Left", cstrType_Object)
    End Sub
    Public Sub New()
        objOItem_Class_Root = New clsOntologyItem("49fdcd27e1054770941d7485dcad08c1", "Root", "dbbfc1a00c2e483684340a7b7a8b4b52")
        strRegEx_GUID = "[A-Za-z0-9]{8}[A-Za-z0-9]{4}[A-Za-z0-9]{4}[A-Za-z0-9]{4}[A-Za-z0-9]{12}"
        set_Session()
        get_ConfigData()
        set_DataTypes()
        set_LogStates()
        set_TypeFields()
        set_Directions()
        set_RelationTypes()
    End Sub

    Private Sub set_Session()
        GUID_Session = Guid.NewGuid.ToString.Replace("-", "")
    End Sub
End Class


