Imports ElasticSearch.Client.ElasticSearchClient
Public Class clsGlobals
    Private cstrEL_Index As String = "ontology_db"
    Private cstrEL_Type As String = "ontologydb"

    Private objOItem_Root As clsOntologyItem

    Private objOItem_Type_Attribute As clsOntologyItem
    Private objOItem_Type_AttributeInstance As clsOntologyItem
    Private objOItem_Type_Class As clsOntologyItem
    Private objOItem_Type_ClassAttribute As clsOntologyItem
    Private objOItem_Type_ClassRelation As clsOntologyItem
    Private objOItem_Type_DataType As clsOntologyItem
    Private objOItem_Type_KindOfOntology As clsOntologyItem
    Private objOItem_Type_Object As clsOntologyItem
    Private objOItem_Type_ObjectOntology As clsOntologyItem
    Private objOItem_Type_RelationType As clsOntologyItem

    Private objOItem_DType_Bool As clsOntologyItem
    Private objOItem_DType_DateTime As clsOntologyItem
    Private objOItem_DType_Int As clsOntologyItem
    Private objOItem_DType_Real As clsOntologyItem
    Private objOItem_DType_String As clsOntologyItem

    Private objELConn As ElasticSearch.Client.ElasticSearchClient

    Private objELSearchResult As ElasticSearch.Client.Domain.SearchResult
    Private objELQuery As ElasticSearch.Client.QueryDSL.BoolQuery

    Public ReadOnly Property OItem_Type_Root As clsOntologyItem
        Get
            Return objOItem_Root
        End Get
    End Property

    Public ReadOnly Property OItem_Type_Attribute As clsOntologyItem
        Get
            Return objOItem_Type_Attribute
        End Get
    End Property

    Public ReadOnly Property OItem_Type_AttributeInstance As clsOntologyItem
        Get
            Return objOItem_Type_AttributeInstance
        End Get
    End Property

    Public ReadOnly Property OItem_Type_Class As clsOntologyItem
        Get
            Return objOItem_Type_Class
        End Get
    End Property

    Public ReadOnly Property OItem_Type_ClassAttribute As clsOntologyItem
        Get
            Return objOItem_Type_ClassAttribute
        End Get
    End Property

    Public ReadOnly Property OItem_Type_ClassRelation As clsOntologyItem
        Get
            Return objOItem_Type_ClassRelation
        End Get
    End Property

    Public ReadOnly Property OItem_Type_DataType As clsOntologyItem
        Get
            Return objOItem_Type_DataType
        End Get
    End Property

    Public ReadOnly Property OItem_Type_KindOfOntology As clsOntologyItem
        Get
            Return objOItem_Type_KindOfOntology
        End Get
    End Property

    Public ReadOnly Property OItem_Type_Object As clsOntologyItem
        Get
            Return objOItem_Type_Object
        End Get
    End Property

    Public ReadOnly Property OItem_Type_ObjectOntology As clsOntologyItem
        Get
            Return objOItem_Type_ObjectOntology
        End Get
    End Property

    Public ReadOnly Property OItem_Type_RelationType As clsOntologyItem
        Get
            Return objOItem_Type_RelationType
        End Get
    End Property

    Private Sub initialize_Client()
        Try
            objELConn = New ElasticSearch.Client.ElasticSearchClient("ontology_db")
        Catch ex As Exception
            Err.Raise(1, "Config")
        End Try
    End Sub

    Private Sub get_OTypes()
        objOItem_Type_Attribute = New clsOntologyItem(New Guid("eff5d646-9ef6-447b-8575-921462f3b9b8"), "Attribute", New Guid("69d36f9c-c59a-4766-9d10-8a46bed99b54"))
        objOItem_Type_AttributeInstance = New clsOntologyItem(New Guid("e36a4286-f34d-485f-b435-bd1344033c74"), "AttributeInstance", New Guid("69d36f9c-c59a-4766-9d10-8a46bed99b54"))
        objOItem_Type_Class = New clsOntologyItem(New Guid("dbbfc1a0-0c2e-4836-8434-0a7b7a8b4b52"), "Class", New Guid("69d36f9c-c59a-4766-9d10-8a46bed99b54"))
        objOItem_Type_ClassAttribute = New clsOntologyItem(New Guid("2ad76ad0-14c2-47cc-abec-81397298c6c8"), "Class-Attribute", New Guid("69d36f9c-c59a-4766-9d10-8a46bed99b54"))
        objOItem_Type_ClassRelation = New clsOntologyItem(New Guid("30039a60-0e36-4ec8-92ac-a2892e35e247"), "Class-Relation", New Guid("69d36f9c-c59a-4766-9d10-8a46bed99b54"))
        objOItem_Type_DataType = New clsOntologyItem(New Guid("9285e6f5-4dd3-41a7-a20d-b8dd5b0c3eeb"), "Class-Relation", New Guid("69d36f9c-c59a-4766-9d10-8a46bed99b54"))
        objOItem_Type_KindOfOntology = New clsOntologyItem(New Guid("69d36f9c-c59a-4766-9d10-8a46bed99b54"), "KindOfOntology", New Guid("69d36f9c-c59a-4766-9d10-8a46bed99b54"))
        objOItem_Type_Object = New clsOntologyItem(New Guid("e9ae24bf-f89b-407c-b36d-51f8219df6c8"), "Object", New Guid("69d36f9c-c59a-4766-9d10-8a46bed99b54"))
        objOItem_Type_ObjectOntology = New clsOntologyItem(New Guid("407e2719-982a-4ef5-a893-d3dfc2c42764"), "Object-Ontology", New Guid("69d36f9c-c59a-4766-9d10-8a46bed99b54"))
        objOItem_Type_RelationType = New clsOntologyItem(New Guid("0d1d690b-d406-4fb6-bdf0-475c29a7a9fe"), "RelationType", New Guid("69d36f9c-c59a-4766-9d10-8a46bed99b54"))
    End Sub

    Private Sub get_DataTypes()
        objOItem_DType_Bool = New clsOntologyItem(New Guid("dd858f27-d5e1-4363-a5c3-3e561e432333"), "Bool", New Guid("9285e6f5-4dd3-41a7-a20d-b8dd5b0c3eeb"))
        objOItem_DType_DateTime = New clsOntologyItem(New Guid("905fda81-788f-4e3d-8329-3e55ae984b9e"), "Bool", New Guid("9285e6f5-4dd3-41a7-a20d-b8dd5b0c3eeb"))
        objOItem_DType_Int = New clsOntologyItem(New Guid("3a4f5b7b-da75-4980-933e-fbc33cc51439"), "Bool", New Guid("9285e6f5-4dd3-41a7-a20d-b8dd5b0c3eeb"))
        objOItem_DType_Real = New clsOntologyItem(New Guid("a1244d0e-187f-46ee-8574-2fc334077b7d"), "Bool", New Guid("9285e6f5-4dd3-41a7-a20d-b8dd5b0c3eeb"))
        objOItem_DType_String = New clsOntologyItem(New Guid("64530b52-d96c-4df1-86fe-183f44513450"), "Bool", New Guid("9285e6f5-4dd3-41a7-a20d-b8dd5b0c3eeb"))

    End Sub

    Public Sub New()
        initialize_Client()
        objOItem_Root = New clsOntologyItem(New Guid("49fdcd27-e105-4770-941d-7485dcad08c1"), "Root", New Guid("dbbfc1a0-0c2e-4836-8434-0a7b7a8b4b52"))
        get_OTypes()
        get_DataTypes()
    End Sub
End Class
