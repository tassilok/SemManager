Imports ElasticSearch
Imports Lucene.Net.Search
Imports Lucene.Net.Index

Public Class clsDBLevel
    Private objElConn As ElasticSearch.Client.ElasticSearchClient
    Private objOntologyList_Objects As New List(Of clsOntologyItem)
    Private objOntologyList_ObjectRel_ID As New List(Of clsObjectRel)
    Private objOntologyList_ObjectTree As New List(Of clsObjectTree)
    Private objOntologyList_Classes1 As New List(Of clsOntologyItem)
    Private objOntologyList_Classes2 As New List(Of clsOntologyItem)
    Private objOntologyList_RelationTypes As New List(Of clsOntologyItem)
    Private objOntologyList_AttributTypes As New List(Of clsOntologyItem)
    Private objOntologyList_ClassRel_ID As New List(Of clsClassRel)
    Private objOntologyList_ClassAtt_ID As New List(Of clsClassAtt)
    Private objOntologyList_ObjAtt_ID As New List(Of clsObjectAtt)
    Private objOntologyList_DataTypes As New List(Of clsOntologyItem)
    Private objOntologyList_Attributes As New List(Of clsAttribute)

    Private otblT_Objects As New DataSet_Config.otbl_ObjectsDataTable
    Private otblT_Classes As New DataSet_Config.otbl_ClassesDataTable
    Private otblT_RelationTypes As New DataSet_Config.otbl_RelationTypesDataTable
    Private otblT_AttributeTypes As New DataSet_Config.otbl_AttributeTypesDataTable
    Private otblT_ObjectRel As New DataSet_Config.otbl_ObjectRelDataTable
    Private otblT_DataTypes As New DataSet_Config.otbl_DataTypesDataTable
    Private otblT_ObjectTree As New DataSet_Config.otbl_ObjetTreeDataTable
    Private otblT_ObjectAtt As New DataSet_Config.otbl_ObjectAttDataTable
    Private otblT_ClassAtt As New DataSet_Config.otbl_ClassAttDataTable
    Private otblT_ClassRel As New DataSet_Config.otbl_ClassRelDataTable

    Private oList_DBLevel As List(Of clsDBLevel)

    Private objConnection As SqlClient.SqlConnection
    Private createA_Table_orgT As New DataSet_ConfigTableAdapters.create_Table_orgTTableAdapter

    Private objBoolQuery As New Lucene.Net.Search.BooleanQuery

    Private objLocalConfig As clsLocalConfig

    Public ReadOnly Property OList_ObjectTree As List(Of clsObjectTree)
        Get
            Return objOntologyList_ObjectTree
        End Get
    End Property

    Public ReadOnly Property OList_ClassRel_ID As List(Of clsClassRel)
        Get
            Return objOntologyList_ClassRel_ID
        End Get
    End Property

    Public ReadOnly Property OList_ClassRel_Named As List(Of clsClassRel)
        Get
            Return objOntologyList_ClassRel_Named
        End Get
    End Property

    Public ReadOnly Property OList_ClassAtt_ID As List(Of clsClassAtt)
        Get
            Return objOntologyList_ClassAtt_ID
        End Get
    End Property

    Public ReadOnly Property OList_Classes As List(Of clsOntologyItem)
        Get
            Return objOntologyList_Classes1
        End Get
    End Property

    Public ReadOnly Property OList_Classes_Left As List(Of clsOntologyItem)
        Get
            Return objOntologyList_Classes1
        End Get
    End Property

    Public ReadOnly Property OList_Classes_Right As List(Of clsOntologyItem)
        Get
            Return objOntologyList_Classes2
        End Get
    End Property

    Public ReadOnly Property OList_Objects As List(Of clsOntologyItem)
        Get
            Return objOntologyList_Objects
        End Get
    End Property

    Public ReadOnly Property OList_RelationTypes As List(Of clsOntologyItem)
        Get
            Return objOntologyList_RelationTypes
        End Get
    End Property

    Public ReadOnly Property OList_AttributeTypes As List(Of clsOntologyItem)
        Get
            Return objOntologyList_AttributTypes
        End Get
    End Property

    Public ReadOnly Property OList_DataTypes As List(Of clsOntologyItem)
        Get
            Return objOntologyList_DataTypes
        End Get
    End Property

    Public ReadOnly Property OList_ObjectRel_ID As List(Of clsObjectRel)
        Get
            Return objOntologyList_ObjectRel_ID
        End Get
    End Property

    
    Public ReadOnly Property OList_ObjectAtt_ID As List(Of clsObjectAtt)
        Get
            Return objOntologyList_ObjAtt_ID
        End Get
    End Property

    
    Public ReadOnly Property tbl_Objects As DataSet_Config.otbl_ObjectsDataTable
        Get
            Return otblT_Objects
        End Get
    End Property

    Public ReadOnly Property tbl_Classes As DataSet_Config.otbl_ClassesDataTable
        Get
            Return otblT_Classes
        End Get
    End Property

    Public ReadOnly Property tbl_ClassAtt As DataSet_Config.otbl_ClassAttDataTable
        Get
            Return otblT_ClassAtt
        End Get
    End Property

    Public ReadOnly Property tbl_RelationTypes As DataSet_Config.otbl_RelationTypesDataTable
        Get
            Return otblT_RelationTypes
        End Get
    End Property

    Public ReadOnly Property tbl_AttributeTypes As DataSet_Config.otbl_AttributeTypesDataTable
        Get
            Return otblT_AttributeTypes
        End Get
    End Property

    Public ReadOnly Property tbl_ObjectRelation As DataSet_Config.otbl_ObjectRelDataTable
        Get
            Return otblT_ObjectRel
        End Get
    End Property

    Public ReadOnly Property tbl_ObjectAttribute As DataSet_Config.otbl_ObjectAttDataTable
        Get
            Return otblT_ObjectAtt
        End Get
    End Property

    Public ReadOnly Property tbl_ClassRelation As DataSet_Config.otbl_ClassRelDataTable
        Get
            Return otblT_ClassRel
        End Get
    End Property

    Private Sub initialize_Client()

        objElConn = New ElasticSearch.Client.ElasticSearchClient(objLocalConfig.Globals.Server, objLocalConfig.Globals.Port, Client.Config.TransportType.Thrift, False)
        'objElConn = New ElasticSearch.Client.ElasticSearchClient("ontology_db")
    End Sub
    Public Function get_Data_Attributes(Optional ByVal OList_Attributes As List(Of clsOntologyItem) = Nothing, _
                                        Optional ByVal OList_AttributeTypes As List(Of clsOntologyItem) = Nothing, _
                                        Optional ByVal OList_DataTypes As List(Of clsOntologyItem) = Nothing) As clsOntologyItem

        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim strQuery_ID As String
        Dim strQuery_Name As String
        Dim strQuery As String
        Dim objHit As ElasticSearch.Client.Domain.Hits

        Dim objOItem_Result As clsOntologyItem
        Dim intCount As Integer
        Dim intPos As Integer

        otblT_RelationTypes.Clear()
        objOntologyList_RelationTypes.Clear()


        intCount = 0
        objOItem_Result = objLocalConfig.Globals.LState_Success

        create_BoolQuery_Attributes(OList_Attributes, OList_DataTypes, OList_AttributeTypes)

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Attribute, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList

                If objHit.Source.ContainsKey(objLocalConfig.Globals.Field_Val_Bool) Then
                    objOntologyList_Attributes.Add(New clsAttribute(objHit.Source(objLocalConfig.Globals.Field_ID_Attribute).ToString, _
                                               objHit.Source(objLocalConfig.Globals.Field_ID_AttributeType).ToString, _
                                               objHit.Source(objLocalConfig.Globals.Field_ID_DataType).ToString, _
                                               objHit.Source(objLocalConfig.Globals.Field_Val_Bool).ToString, _
                                               Nothing, _
                                               Nothing, _
                                               Nothing, _
                                               Nothing, _
                                               objHit.Source(objLocalConfig.Globals.Field_Val_Name).ToString))
                ElseIf objHit.Source.ContainsKey(objLocalConfig.Globals.Field_Val_Datetime) Then
                    objOntologyList_Attributes.Add(New clsAttribute(objHit.Source(objLocalConfig.Globals.Field_ID_Attribute).ToString, _
                                               objHit.Source(objLocalConfig.Globals.Field_ID_AttributeType).ToString, _
                                               objHit.Source(objLocalConfig.Globals.Field_ID_DataType).ToString, _
                                               Nothing, _
                                               Nothing, _
                                               Nothing, _
                                               objHit.Source(objLocalConfig.Globals.Field_Val_Datetime).ToString, _
                                               Nothing, _
                                               objHit.Source(objLocalConfig.Globals.Field_Val_Name).ToString))
                ElseIf objHit.Source.ContainsKey(objLocalConfig.Globals.Field_Val_Int) Then
                    objOntologyList_Attributes.Add(New clsAttribute(objHit.Source(objLocalConfig.Globals.Field_ID_Attribute).ToString, _
                                               objHit.Source(objLocalConfig.Globals.Field_ID_AttributeType).ToString, _
                                               objHit.Source(objLocalConfig.Globals.Field_ID_DataType).ToString, _
                                               Nothing, _
                                               objHit.Source(objLocalConfig.Globals.Field_Val_Int).ToString, _
                                               Nothing, _
                                               Nothing, _
                                               Nothing, _
                                               objHit.Source(objLocalConfig.Globals.Field_Val_Name).ToString))
                ElseIf objHit.Source.ContainsKey(objLocalConfig.Globals.Field_Val_Real) Then
                    objOntologyList_Attributes.Add(New clsAttribute(objHit.Source(objLocalConfig.Globals.Field_ID_Attribute).ToString, _
                                               objHit.Source(objLocalConfig.Globals.Field_ID_AttributeType).ToString, _
                                               objHit.Source(objLocalConfig.Globals.Field_ID_DataType).ToString, _
                                               Nothing, _
                                               Nothing, _
                                               objHit.Source(objLocalConfig.Globals.Field_Val_Datetime).ToString, _
                                               Nothing, _
                                               Nothing, _
                                               objHit.Source(objLocalConfig.Globals.Field_Val_Name).ToString))
                ElseIf objHit.Source.ContainsKey(objLocalConfig.Globals.Field_Val_String) Then
                    objOntologyList_Attributes.Add(New clsAttribute(objHit.Source(objLocalConfig.Globals.Field_ID_Attribute).ToString, _
                                               objHit.Source(objLocalConfig.Globals.Field_ID_AttributeType).ToString, _
                                               objHit.Source(objLocalConfig.Globals.Field_ID_DataType).ToString, _
                                               Nothing, _
                                               Nothing, _
                                               Nothing, _
                                               Nothing, _
                                               objHit.Source(objLocalConfig.Globals.Field_Val_String).ToString, _
                                               objHit.Source(objLocalConfig.Globals.Field_Val_Name).ToString))

                End If
            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

        Return objOItem_Result
    End Function
    Public Function get_Data_RelationTypes(Optional ByVal OList_RelType As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim strQuery_ID As String
        Dim strQuery_Name As String
        Dim strQuery As String
        Dim objHit As ElasticSearch.Client.Domain.Hits

        Dim objOItem_Result As clsOntologyItem
        Dim intCount As Integer
        Dim intPos As Integer

        otblT_RelationTypes.Clear()
        objOntologyList_RelationTypes.Clear()


        intCount = 0
        objOItem_Result = objLocalConfig.Globals.LState_Success

        create_BoolQuery_Simple(OList_RelType, objLocalConfig.Globals.Type_RelationType)
    
        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_RelationType, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits
    
            For Each objHit In objList
                If boolTable = False Then
                    objOntologyList_RelationTypes.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                objHit.Source("Name_Item").ToString, _
                                                                objLocalConfig.Globals.Type_RelationType))
                Else
                    otblT_RelationTypes.Rows.Add(objHit.Id.ToString, _
                                                                objHit.Source("Name_Item").ToString)
                End If


            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

        Return objOItem_Result
    End Function

    Private Sub create_BoolQuery_Simple(ByVal OList_Items As List(Of clsOntologyItem), _
                                 ByVal strOntology As String)

        Dim strQuery As String

        objBoolQuery = New Lucene.Net.Search.BooleanQuery

        If Not OList_Items Is Nothing Then
            If OList_Items.Count > 0 Then
                If strOntology = objLocalConfig.Globals.Type_AttributeType Or _
                strOntology = objLocalConfig.Globals.Type_RelationType Or _
                strOntology = objLocalConfig.Globals.Type_Class Or _
                strOntology = objLocalConfig.Globals.Type_Object Then

                    Dim objLQuery_ID = From at As clsOntologyItem In OList_Items Group By at.GUID Into Group

                    strQuery = ""

                    For Each objQuery_ID In objLQuery_ID
                        If strQuery <> "" Then
                            strQuery = strQuery & "\ OR\ "
                        End If
                        strQuery = strQuery & objQuery_ID.GUID
                    Next

                    If strQuery <> "" Then
                        objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Item, strQuery)), BooleanClause.Occur.MUST)

                    End If
                End If

                If strOntology = objLocalConfig.Globals.Type_AttributeType Or _
                    strOntology = objLocalConfig.Globals.Type_RelationType Or _
                    strOntology = objLocalConfig.Globals.Type_Class Or _
                    strOntology = objLocalConfig.Globals.Type_Object Then

                    Dim objLQuery_Name = From at As clsOntologyItem In OList_Items Group By at.Name Into Group

                    strQuery = ""

                    For Each objQuery_Name In objLQuery_Name
                        If strQuery <> "" Then
                            strQuery = strQuery & "\ OR\ "
                        End If
                        If objQuery_Name.Name <> "" Then
                            strQuery = strQuery & """*" & objQuery_Name.Name & "*"""
                        End If

                    Next

                    If strQuery <> "" Then
                        objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_Name_Item, strQuery)), BooleanClause.Occur.MUST)
                    End If
                End If

                If strOntology = objLocalConfig.Globals.Type_AttributeType Or _
                    strOntology = objLocalConfig.Globals.Type_RelationType Or _
                    strOntology = objLocalConfig.Globals.Type_Class Or _
                    strOntology = objLocalConfig.Globals.Type_Object Then

                    Dim objLQuery_AttributeType = From at As clsOntologyItem In OList_Items Group By at.GUID_Parent Into Group

                    strQuery = ""
                    For Each objQuery_IDParent In objLQuery_AttributeType
                        If strQuery <> "" Then
                            strQuery = strQuery & "\ OR\ "
                        End If
                        If objQuery_IDParent.GUID_Parent <> "" Then
                            strQuery = strQuery & objQuery_IDParent.GUID_Parent
                        End If

                    Next

                    If strQuery <> "" Then
                        objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_Name_Item, strQuery)), BooleanClause.Occur.MUST)
                    End If
                End If
            End If
        End If

        If objBoolQuery.ToString = "" Then
            strQuery = "*"
            objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_ID_Item, strQuery)), BooleanClause.Occur.MUST)
        End If
    End Sub

    Private Sub create_BoolQuery_ClassRel(ByVal OList_Class_Left As List(Of clsOntologyItem), ByVal OList_Class_Right As List(Of clsOntologyItem), ByVal oList_RelationType As List(Of clsOntologyItem), Optional ByVal boolClear As Boolean = True)
        Dim strQuery As String

        If boolClear = False Then
            objBoolQuery = New Lucene.Net.Search.BooleanQuery
        End If


        If Not OList_Class_Left Is Nothing Then
            If OList_Class_Left.Count > 0 Then
                Dim objLQuery_ID = From at As clsOntologyItem In OList_Class_Left Group By at.GUID Into Group

                strQuery = ""

                For Each objQuery_ID In objLQuery_ID
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & objQuery_ID.GUID
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Class_Left, strQuery)), BooleanClause.Occur.MUST)

                End If


            End If
        End If

        If Not OList_Class_Right Is Nothing Then
            If OList_Class_Right.Count > 0 Then
                Dim objLQuery_ID = From at As clsOntologyItem In OList_Class_Right Group By at.GUID Into Group

                strQuery = ""

                For Each objQuery_ID In objLQuery_ID
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & objQuery_ID.GUID
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Class_Right, strQuery)), BooleanClause.Occur.MUST)

                End If


            End If
        End If

        If Not oList_RelationType Is Nothing Then
            If oList_RelationType.Count > 0 Then
                Dim objLQuery_ID = From at As clsOntologyItem In oList_RelationType Group By at.GUID Into Group

                strQuery = ""

                For Each objQuery_ID In objLQuery_ID
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & objQuery_ID.GUID
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_RelationType, strQuery)), BooleanClause.Occur.MUST)

                End If


            End If
        End If

        If objBoolQuery.ToString = "" Then
            strQuery = "*"
            objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_ID_Class_Left, strQuery)), BooleanClause.Occur.MUST)

        End If
    End Sub

    Private Sub create_BoolQuery_Attributes(ByVal OList_Attributes As List(Of clsOntologyItem), ByVal OList_DataTypes As List(Of clsOntologyItem), ByVal OList_AttributeTypes As List(Of clsOntologyItem), Optional ByVal boolClear As Boolean = True)
        Dim strQuery As String

        If boolClear = False Then
            objBoolQuery = New Lucene.Net.Search.BooleanQuery
        End If


        If Not OList_Attributes Is Nothing Then
            If OList_Attributes.Count > 0 Then
                Dim objLQuery_ID = From at As clsOntologyItem In OList_Attributes Group By at.GUID Into Group

                strQuery = ""

                For Each objQuery_ID In objLQuery_ID
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & objQuery_ID.GUID
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Attribute, strQuery)), BooleanClause.Occur.MUST)

                End If


            End If
        End If

        If Not OList_AttributeTypes Is Nothing Then
            If OList_AttributeTypes.Count > 0 Then
                Dim objLQuery_ID = From at As clsOntologyItem In OList_AttributeTypes Group By at.GUID Into Group

                strQuery = ""

                For Each objQuery_ID In objLQuery_ID
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & objQuery_ID.GUID
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_AttributeType, strQuery)), BooleanClause.Occur.MUST)

                End If


            End If
        End If

        If Not OList_DataTypes Is Nothing Then
            If OList_DataTypes.Count > 0 Then
                Dim objLQuery_ID = From at As clsOntologyItem In OList_DataTypes Group By at.GUID Into Group

                strQuery = ""

                For Each objQuery_ID In objLQuery_ID
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & objQuery_ID.GUID
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_DataType, strQuery)), BooleanClause.Occur.MUST)

                End If


            End If
        End If

        If objBoolQuery.ToString = "" Then
            strQuery = "*"
            objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_ID_Attribute, strQuery)), BooleanClause.Occur.MUST)

        End If
    End Sub

    Private Sub create_BoolQuery_ObjectRel(ByVal OList_Object As List(Of clsOntologyItem), ByVal OList_Other As List(Of clsOntologyItem), ByVal oList_RelationType As List(Of clsOntologyItem), Optional ByVal boolClear As Boolean = True)
        Dim strQuery As String

        If boolClear = False Then
            objBoolQuery = New Lucene.Net.Search.BooleanQuery
        End If


        If Not OList_Object Is Nothing Then
            If OList_Object.Count > 0 Then
                Dim objLQuery_ID = From at As clsOntologyItem In OList_Object Group By at.GUID Into Group

                strQuery = ""

                For Each objQuery_ID In objLQuery_ID
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & objQuery_ID.GUID
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Object, strQuery)), BooleanClause.Occur.MUST)

                End If

                Dim objLQuery_ID_Parent = From at As clsOntologyItem In OList_Object Group By at.GUID_Parent Into Group

                strQuery = ""

                For Each objQuery_ID_Parent In objLQuery_ID_Parent
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & objQuery_ID_Parent.GUID_Parent
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Parent_Object, strQuery)), BooleanClause.Occur.MUST)

                End If

            End If
        End If

        If Not OList_Other Is Nothing Then
            If OList_Other.Count > 0 Then
                Dim objLQuery_ID = From at As clsOntologyItem In OList_Other Group By at.GUID Into Group

                strQuery = ""

                For Each objQuery_ID In objLQuery_ID
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & objQuery_ID.GUID
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Other, strQuery)), BooleanClause.Occur.MUST)

                End If

                Dim objLQuery_ID_Parent = From at As clsOntologyItem In OList_Other Group By at.GUID_Parent Into Group

                strQuery = ""

                For Each objQuery_ID_Parent In objLQuery_ID_Parent
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & objQuery_ID_Parent.GUID_Parent
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Parent_Other, strQuery)), BooleanClause.Occur.MUST)

                End If


                Dim objLQuery_Ontology = From at As clsOntologyItem In OList_Other Group By at.Type Into Group

                strQuery = ""

                For Each objQuery_Ontology In objLQuery_Ontology
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & objQuery_Ontology.Type
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_Ontology, strQuery)), BooleanClause.Occur.MUST)

                End If

            End If
        End If

        If Not oList_RelationType Is Nothing Then
            If oList_RelationType.Count > 0 Then
                Dim objLQuery_ID = From at As clsOntologyItem In oList_RelationType Group By at.GUID Into Group

                strQuery = ""

                For Each objQuery_ID In objLQuery_ID
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & objQuery_ID.GUID
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_RelationType, strQuery)), BooleanClause.Occur.MUST)

                End If


            End If
        End If

        If objBoolQuery.ToString = "" Then
            strQuery = "*"
            objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_ID_Object, strQuery)), BooleanClause.Occur.MUST)

        End If
    End Sub

    Public Function get_Data_AttributeType(Optional ByVal OList_AttType As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objOItem_Result As clsOntologyItem
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim intCount As Integer
        Dim intPos As Integer

        otblT_AttributeTypes.Clear()
        objOntologyList_AttributTypes.Clear()


        objOItem_Result = objLocalConfig.Globals.LState_Success

        intCount = 0

        create_BoolQuery_Simple(OList_AttributeTypes, objLocalConfig.Globals.Type_AttributeType)

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_AttributeType, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits
            'Dim a = From obja In objList
            'Where (Not obja.Source("@fields")("ex_cid") Is Nothing)
            '       Group obja By key = obja.Source("@fields")("ex_cid").First.ToString Into Count() Select key, count = Count

            'For Each b In a
            '    CidA_Count.Insert(Integer.Parse(b.key), b.count)
            'Next
            For Each objHit In objList
                If boolTable = False Then
                    objOntologyList_AttributTypes.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_DataType).ToString, _
                                                                objLocalConfig.Globals.Type_AttributeType))
                Else
                    otblT_AttributeTypes.Rows.Add(objHit.Id.ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_DataType).ToString)
                End If


            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

        Return objOItem_Result
    End Function

    Public Function get_Data_ClassAtt(ByVal oList_Class As List(Of clsOntologyItem), Optional ByVal boolTable As Boolean = False, Optional ByVal boolIDs As Boolean = True) As clsOntologyItem
        Dim objOItem_Result As clsOntologyItem
        Dim oList_Classes As New List(Of clsOntologyItem)
        Dim oList_AttributeTypes As New List(Of clsOntologyItem)
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer

        objOItem_Result = objLocalConfig.Globals.LState_Success

        oList_AttributeTypes.Clear()

        Dim strLQuery_ID = From obj As clsOntologyItem In oList_Class Group By obj.GUID Into Group Select GUID = GUID

        strQuery = ""
        For Each strQuery_ID In strLQuery_ID
            If strQuery <> "" Then
                strQuery = strQuery & "\ OR\ "
            End If
            strQuery = strQuery & strQuery_ID
        Next
        If strQuery <> "" Then
            objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Class, strQuery)), BooleanClause.Occur.MUST)

        End If

        objOntologyList_ClassAtt_ID.Clear()
        objOntologyList_Classes1.Clear()
        otblT_ClassAtt.Clear()

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ClassAtt, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList

                objOntologyList_ClassAtt_ID.Add(New clsClassAtt(objHit.Source(objLocalConfig.Globals.Field_ID_AttributeType).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_ID_DataType).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_ID_Class).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_Min).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_Max).ToString))


            Next


            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

        If boolIDs = False Then
            Dim strLGUID_Attributetype = From obj In objOntologyList_ClassAtt_ID
                               Group By obj.ID_AttributeType Into Group
                               Select ID_AttributeType

            For Each strGUID_AttributeType In strLGUID_Attributetype
                oList_AttributeTypes.Add(New clsOntologyItem(strGUID_AttributeType, objLocalConfig.Globals.Type_AttributeType))

            Next

            If oList_AttributeTypes.Count > 0 Then
                get_Data_AttributeType(oList_AttributeTypes, False)
            End If

            Dim strLGUID_Class = From obj In objOntologyList_ClassAtt_ID
                                 Group By obj.ID_Class Into Group
                                 Select ID_Class

            For Each strGUID_Class In strLGUID_Class
                oList_Classes.Add(New clsOntologyItem(strGUID_Class, objLocalConfig.Globals.Type_Class))

            Next

            If oList_Classes.Count > 0 Then
                get_Data_Classes(oList_Classes, False)
            End If

            If boolTable = True Then
                Dim objLClassAtt = From obj In objOntologyList_ClassAtt_ID
                                   Join objAttType In objOntologyList_AttributTypes On obj.ID_AttributeType Equals objAttType.GUID
                                   Join objClass In objOntologyList_Classes1 On obj.ID_Class Equals objClass.GUID

                For Each objClassAtt In objLClassAtt
                    otblT_ClassAtt.Rows.Add(objClassAtt.obj.ID_Class, _
                                            objClassAtt.objClass.Name, _
                                            objClassAtt.objAttType.GUID, _
                                            objClassAtt.objAttType.Name, _
                                            objClassAtt.obj.Min, _
                                            objClassAtt.obj.Max)
                Next
            End If
        End If
        
        Return objOItem_Result
    End Function

    Public Function get_Data_ClassRel(ByVal oList_Class As List(Of clsOntologyItem), ByVal Direction As clsOntologyItem, ByVal boolIDs As Boolean, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objOItem_Result As clsOntologyItem
        Dim oList_Classes_Left As New List(Of clsOntologyItem)
        Dim oList_Classes_Right As New List(Of clsOntologyItem)
        Dim oList_Rels As New List(Of clsOntologyItem)
        Dim strLGUID_Class As Object
        Dim strLGUID_Rel As Object
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer

        objOntologyList_Classes1.Clear()
        objOntologyList_RelationTypes.Clear()
        objOntologyList_ClassRel_ID.Clear()

        objOItem_Result = objLocalConfig.Globals.LState_Success

        If Direction.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
            create_BoolQuery_ClassRel(oList_Class, Nothing, Nothing)

        Else
            create_BoolQuery_ClassRel(Nothing, oList_Class, Nothing)
        End If

        strQuery = ""
        

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0


            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ClassRel, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList

                If objHit.Source(objLocalConfig.Globals.Field_Ontology).ToString = objLocalConfig.Globals.Type_Other Then
                    objOntologyList_ClassRel_ID.Add(New clsClassRel(objHit.Source(objLocalConfig.Globals.Field_ID_Class_Left).ToString, _
                                                             Nothing, _
                                                             objHit.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_Ontology).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_Min_forw), _
                                                             objHit.Source(objLocalConfig.Globals.Field_Max_forw), _
                                                             Nothing))
                Else
                    objOntologyList_ClassRel_ID.Add(New clsClassRel(objHit.Source(objLocalConfig.Globals.Field_ID_Class_Left).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_ID_Class_Right).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_Ontology).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_Min_forw), _
                                                             objHit.Source(objLocalConfig.Globals.Field_Max_forw), _
                                                             objHit.Source(objLocalConfig.Globals.Field_Max_backw)))
                End If



            Next


            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

        If boolIDs = False Then
            Dim objLClasses_Left = From obj In objOntologyList_ClassRel_ID
                                   Group By obj.ID_Class_Left Into Group

            For Each objClasses_Left In objLClasses_Left
                oList_Classes_Left.Add(New clsOntologyItem(objClasses_Left.ID_Class_Left, objLocalConfig.Globals.Type_Class))

            Next

            If oList_Classes_Left.Count > 0 Then
                get_Data_Classes(oList_Classes_Left, False, False)
            End If


            Dim objLClasses_Right = From obj In objOntologyList_ClassRel_ID
                                    Group By obj.ID_Class_Right Into Group

            For Each objClasses_Right In objLClasses_Right
                oList_Classes_Right.Add(New clsOntologyItem(objClasses_Right.ID_Class_Right, objLocalConfig.Globals.Type_Class))

            Next

            If oList_Classes_Right.Count > 0 Then
                get_Data_Classes(oList_Classes_Right, False, True)
            End If


            Dim objLRelTypes = From obj In objOntologyList_ClassRel_ID
                               Group By obj.ID_RelationType Into Group

            For Each objRelType In objLRelTypes
                oList_Rels.Add(New clsOntologyItem(objRelType.ID_RelationType, objLocalConfig.Globals.Type_RelationType))
            Next

            If oList_Rels.Count > 0 Then
                get_Data_RelationTypes(oList_Rels, False)
            End If

            Dim objLRels = From objRel In objOntologyList_ClassRel_ID
                          Join objClass_Left In objOntologyList_Classes1 On objClass_Left.GUID Equals objRel.ID_Class_Left
                          Join objClass_Right In objOntologyList_Classes2 On objClass_Right.GUID Equals objRel.ID_Class_Right
                          Join objRelType In objOntologyList_RelationTypes On objRelType.GUID Equals objRel.ID_RelationType

            For Each objRel In objLRels

                otblT_ClassRel.Rows.Add(objRel.objRel.ID_Class_Left, _
                                                         objRel.objClass_Left.Name, _
                                                         objRel.objRel.ID_Class_Right, _
                                                         objRel.objClass_Right.Name, _
                                                         objRel.objRel.ID_RelationType, _
                                                         objRel.objRelType.Name, _
                                                         objLocalConfig.Globals.Type_ClassRel, _
                                                         objRel.objRel.Min_Forw, _
                                                         objRel.objRel.Max_Forw, _
                                                         objRel.objRel.Max_Backw)

            Next

        End If


    
        Return objOItem_Result
    End Function

    

    Public Function get_Data_ObjectAtt(Optional ByRef oItem_Object As clsOntologyItem = Nothing, Optional ByVal oItem_AttributeType As clsOntologyItem = Nothing, Optional ByVal boolTable As Boolean = False, Optional ByVal boolIDs As Boolean = True) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim objOList_AttributeTypes As New List(Of clsOntologyItem)
        Dim objOList_Classes As New List(Of clsOntologyItem)
        Dim objOList_Objects As New List(Of clsOntologyItem)
        Dim objOList_Attributes As New List(Of clsOntologyItem)
        Dim objOList_DataTypes As New List(Of clsOntologyItem)
        Dim objOItem_Result As clsOntologyItem
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer

        objOntologyList_ObjAtt_ID.Clear()
        otblT_ObjectAtt.Clear()

        objOItem_Result = objLocalConfig.Globals.LState_Success

        strQuery = ""
        If Not oItem_Object Is Nothing Then
            If oItem_Object.GUID <> "" Then
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If


                strQuery = strQuery & oItem_Object.GUID

            End If

            If strQuery <> "" Then
                objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_ID_Object, strQuery)), BooleanClause.Occur.MUST)
            End If
        End If


        If Not oItem_AttributeType Is Nothing Then
            strQuery = ""
            If oItem_AttributeType.GUID <> "" Then
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If


                strQuery = strQuery & oItem_AttributeType.GUID

            End If

            If strQuery <> "" Then
                objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_ID_AttributeType, strQuery)), BooleanClause.Occur.MUST)
            End If
        End If
        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ObjectAtt, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList

                objOntologyList_ObjAtt_ID.Add(New clsObjectAtt(objHit.Source(objLocalConfig.Globals.Field_ID_Attribute).ToString, _
                                                               objHit.Source(objLocalConfig.Globals.Field_ID_Object).ToString, _
                                                               objHit.Source(objLocalConfig.Globals.Field_ID_Class).ToString, _
                                                               objHit.Source(objLocalConfig.Globals.Field_ID_AttributeType).ToString, _
                                                               objHit.Source(objLocalConfig.Globals.Field_OrderID).ToString))
                
            Next
        End While

        If boolIDs = False Then
            Dim oList_AttType = From objAtt In objOntologyList_ObjAtt_ID
                            Group By objAtt.ID_AttributeType Into Group

            For Each oItem_AttType In oList_AttType
                objOList_AttributeTypes.Add(New clsOntologyItem(oItem_AttType.ID_AttributeType, objLocalConfig.Globals.Type_AttributeType))
            Next

            If objOList_AttributeTypes.Count > 0 Then
                get_Data_AttributeType(objOList_AttributeTypes)
            End If


            Dim oList_Classes = From objClass In objOntologyList_ObjAtt_ID
                                Group By objClass.ID_Class Into Group

            For Each oItem_Class In oList_Classes
                objOList_Classes.Add(New clsOntologyItem(oItem_Class.ID_Class, objLocalConfig.Globals.Type_Class))

            Next

            If objOList_Classes.Count > 0 Then
                get_Data_Classes(objOList_Classes, False, False)
            End If


            Dim oList_Objects = From objObj In objOntologyList_ObjAtt_ID
                                Group By objObj.ID_Object Into Group

            For Each oItem_Objects In oList_Objects
                objOList_Objects.Add(New clsOntologyItem(oItem_Objects.ID_Object, objLocalConfig.Globals.Type_Object))
            Next

            If objOList_Objects.Count > 0 Then
                get_Data_Objects(objOList_Objects)
            End If


            Dim oList_ObjAtt = From objObjAtt In objOntologyList_ObjAtt_ID
                               Group By objObjAtt.ID_Attribute Into Group

            For Each oItem_ObjAtt In oList_ObjAtt
                objOList_Attributes.Add(New clsOntologyItem(oItem_ObjAtt.ID_Attribute, objLocalConfig.Globals.Type_Attribute))
            Next

            If objOList_Attributes.Count > 0 Then
                get_Data_Attributes(objOList_Attributes)
            End If


            Dim oList_DataType = From objDataType In objOntologyList_DataTypes
                                 Group By objDataType.GUID Into Group

            For Each oItem_DataType In oList_DataType
                objOList_DataTypes.Add(New clsOntologyItem(oItem_DataType.GUID, objLocalConfig.Globals.Type_DataType))

            Next

            If objOList_DataTypes.Count > 0 Then
                get_Data_DataTyps(objOList_DataTypes)
            End If


            Dim oListRel = From objRel In objOntologyList_ObjAtt_ID
                           Join objAttType In objOntologyList_AttributTypes On objRel.ID_AttributeType Equals objAttType.GUID
                           Join objClass In objOntologyList_Classes1 On objRel.ID_Class Equals objClass.GUID
                           Join objAtt In objOntologyList_Attributes On objRel.ID_Attribute Equals objAtt.ID_Attribute
                           Join objObj In objOntologyList_Objects On objRel.ID_Object Equals objObj.GUID
                           Join objDataType In objOntologyList_DataTypes On objAtt.ID_DataType Equals objDataType.GUID

            For Each objORels In oListRel

                If objORels.objDataType.GUID = objLocalConfig.Globals.DType_Bool.GUID Then
                    otblT_ObjectAtt.Rows.Add(objORels.objRel.ID_Attribute, _
                                         objORels.objRel.ID_Object, _
                                         objORels.objObj.Name, _
                                         objORels.objAttType.GUID, _
                                         objORels.objAttType.Name, _
                                         objORels.objClass.GUID, _
                                         objORels.objClass.Name, _
                                         objORels.objRel.OrderID, _
                                         objORels.objAtt.Val_Name, _
                                         objORels.objAtt.Val_Bool, _
                                         Nothing, _
                                         Nothing, _
                                         Nothing, _
                                         Nothing, _
                                         objORels.objDataType.GUID, _
                                         objORels.objDataType.Name)
                ElseIf objORels.objDataType.GUID = objLocalConfig.Globals.DType_DateTime.GUID Then
                    otblT_ObjectAtt.Rows.Add(objORels.objRel.ID_Attribute, _
                                         objORels.objRel.ID_Object, _
                                         objORels.objObj.Name, _
                                         objORels.objAttType.GUID, _
                                         objORels.objAttType.Name, _
                                         objORels.objClass.GUID, _
                                         objORels.objClass.Name, _
                                         objORels.objRel.OrderID, _
                                         objORels.objAtt.Val_Name, _
                                         Nothing, _
                                         Nothing, _
                                         Nothing, _
                                         objORels.objAtt.Val_Date, _
                                         Nothing, _
                                         objORels.objDataType.GUID, _
                                         objORels.objDataType.Name)
                ElseIf objORels.objDataType.GUID = objLocalConfig.Globals.DType_Int.GUID Then
                    otblT_ObjectAtt.Rows.Add(objORels.objRel.ID_Attribute, _
                                         objORels.objRel.ID_Object, _
                                         objORels.objObj.Name, _
                                         objORels.objAttType.GUID, _
                                         objORels.objAttType.Name, _
                                         objORels.objClass.GUID, _
                                         objORels.objClass.Name, _
                                         objORels.objRel.OrderID, _
                                         objORels.objAtt.Val_Name, _
                                         Nothing, _
                                         objORels.objAtt.Val_Long, _
                                         Nothing, _
                                         Nothing, _
                                         Nothing, _
                                         objORels.objDataType.GUID, _
                                         objORels.objDataType.Name)
                ElseIf objORels.objDataType.GUID = objLocalConfig.Globals.DType_Real.GUID Then
                    otblT_ObjectAtt.Rows.Add(objORels.objRel.ID_Attribute, _
                                         objORels.objRel.ID_Object, _
                                         objORels.objObj.Name, _
                                         objORels.objAttType.GUID, _
                                         objORels.objAttType.Name, _
                                         objORels.objClass.GUID, _
                                         objORels.objClass.Name, _
                                         objORels.objRel.OrderID, _
                                         objORels.objAtt.Val_Name, _
                                         Nothing, _
                                         Nothing, _
                                         objORels.objAtt.Val_Double, _
                                         Nothing, _
                                         Nothing, _
                                         objORels.objDataType.GUID, _
                                         objORels.objDataType.Name)
                ElseIf objORels.objDataType.GUID = objLocalConfig.Globals.DType_String.GUID Then
                    otblT_ObjectAtt.Rows.Add(objORels.objRel.ID_Attribute, _
                                         objORels.objRel.ID_Object, _
                                         objORels.objObj.Name, _
                                         objORels.objAttType.GUID, _
                                         objORels.objAttType.Name, _
                                         objORels.objClass.GUID, _
                                         objORels.objClass.Name, _
                                         objORels.objRel.OrderID, _
                                         objORels.objAtt.Val_Name, _
                                         Nothing, _
                                         Nothing, _
                                         Nothing, _
                                         Nothing, _
                                         objORels.objAtt.Val_String, _
                                         objORels.objDataType.GUID, _
                                         objORels.objDataType.Name)
                End If
                

            Next
        End If

        Return objOItem_Result
    End Function

    Public Function get_Data_ObjectRel(Optional ByVal oItem_ObjectLeft As clsOntologyItem = Nothing, Optional ByVal oItem_ObjectRight As clsOntologyItem = Nothing, Optional ByVal oItem_RelationType As clsOntologyItem = Nothing, Optional ByVal boolTable As Boolean = False, Optional ByVal boolIDs As Boolean = True) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim objOItem_Result As clsOntologyItem = objLocalConfig.Globals.LState_Success
        Dim oList_Object As New List(Of clsOntologyItem)
        Dim oList_Other As New List(Of clsOntologyItem)
        Dim oList_RelType As New List(Of clsOntologyItem)
        Dim oList_Rel_Object As New List(Of clsOntologyItem)
        Dim oList_Rel_AttType As New List(Of clsOntologyItem)
        Dim oList_Rel_Class As New List(Of clsOntologyItem)
        Dim oList_Rel_RelType As New List(Of clsOntologyItem)
        Dim objDBLevel As New clsDBLevel(objLocalConfig)
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer

        objOntologyList_ObjectRel_ID.Clear()
        otblT_ObjectRel.Clear()

        oList_Object.Add(oItem_ObjectLeft)
        oList_Other.Add(oItem_ObjectRight)
        oList_RelType.Add(oItem_RelationType)

        create_BoolQuery_ObjectRel(oList_Object, oList_Other, oList_RelType)
        
        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ObjectRel, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList

                If boolTable = False Then
                    If Not objHit.Source.ContainsKey(objLocalConfig.Globals.Field_ID_Parent_Other) Then

                        objOntologyList_ObjectRel_ID.Add(New clsObjectRel(objHit.Source(objLocalConfig.Globals.Field_ID_Object).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Object).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Other).ToString, _
                                                                Nothing, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Ontology).ToString, _
                                                                objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                                objHit.Source(objLocalConfig.Globals.Field_OrderID).ToString))


                    Else

                        objOntologyList_ObjectRel_ID.Add(New clsObjectRel(objHit.Source(objLocalConfig.Globals.Field_ID_Object).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Object).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Other).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Other).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Ontology).ToString, _
                                                                    objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_OrderID).ToString))
                    End If
                End If

            Next
        End While

        If boolIDs = False Then
            Dim objLObject = From objObj In objOntologyList_ObjectRel_ID
                             Group By objObj.ID_Object Into Group


            For Each objObject In objLObject
                oList_Object.Add(New clsOntologyItem(objObject.ID_Object, objLocalConfig.Globals.Type_Object))

            Next

            If oList_Object.Count > 0 Then
                get_Data_Objects(oList_Object)
            End If

            Dim objLOther = From objOther In objOntologyList_ObjectRel_ID
                            Group By objOther.ID_Other, objOther.Ontology Into Group

            For Each objOther In objLOther
                Select Case objOther.Ontology
                    Case objLocalConfig.Globals.Type_AttributeType
                        OList_AttributeTypes.Add(New clsOntologyItem(objOther.ID_Other, objLocalConfig.Globals.Type_AttributeType))

                    Case objLocalConfig.Globals.Type_Class
                        OList_Classes.Add(New clsOntologyItem(objOther.ID_Other, objLocalConfig.Globals.Type_Class))

                    Case objLocalConfig.Globals.Type_Object
                        oList_Object.Add(New clsOntologyItem(objOther.ID_Other, objLocalConfig.Globals.Type_Object))

                    Case objLocalConfig.Globals.Type_RelationType
                        oList_RelType.Add(New clsOntologyItem(objOther.ID_Other, objLocalConfig.Globals.Type_RelationType))

                End Select
            Next

            If OList_AttributeTypes.Count > 0 Then
                objDBLevel.get_Data_AttributeType(OList_AttributeTypes)

            End If

            If OList_Classes.Count > 0 Then
                objDBLevel.get_Data_Classes(OList_Classes)

            End If

            If oList_Object.Count > 0 Then
                objDBLevel.get_Data_Objects(oList_Object)

            End If

            If OList_RelationTypes.Count > 0 Then
                objDBLevel.get_Data_RelationTypes(oList_RelType)

            End If
        End If

        Return objOItem_Result
    End Function



    Public Function get_Data_DataTyps(Optional ByVal oList_DataTypes As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objOItem_Result As clsOntologyItem
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim strQuery As String = ""
        Dim intCount As Integer
        Dim intPos As Integer
        Dim strQuery_ID As String
        Dim strQuery_Name As String

        otblT_Objects.Clear()
        objOntologyList_Objects.Clear()

        objOItem_Result = objLocalConfig.Globals.LState_Success
        intCount = 0


        Dim strLQuery_LID = From obj As clsOntologyItem In OList_Objects Group By obj.GUID Into Group Select GUID = GUID
        Dim strLQuery_LName = From obj As clsOntologyItem In OList_Objects Group By obj.Name Into Group Select Name = Name

        strQuery = ""
        For Each strQuery_ID In strLQuery_LID
            If strQuery <> "" Then
                strQuery = strQuery & "\ OR\ "
            End If
            strQuery = strQuery & strQuery_ID
        Next
        If strQuery <> "" Then

            objBoolQuery.Add(New TermQuery(New Term("ID_Item", strQuery)), BooleanClause.Occur.MUST)
        End If

        strQuery = ""
        For Each strQuery_Name In strLQuery_LName
            If strQuery <> "" Then
                strQuery = strQuery & "\ OR\ "
            End If
            If strQuery_Name <> "" Then
                strQuery = strQuery & """*" & strQuery_Name & "*"""""
            End If

        Next
        If strQuery <> "" Then
            objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_Name_Item, strQuery)), BooleanClause.Occur.MUST)
        End If


        strQuery = objBoolQuery.ToString
        If strQuery = "" Then
            objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_ID_Item, "*")), BooleanClause.Occur.MUST)
        End If

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_DataType, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList
                If boolTable = False Then
                    objOntologyList_DataTypes.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                objLocalConfig.Globals.Type_DataType))
                Else
                    otblT_DataTypes.Rows.Add(objHit.Id.ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString)
                End If


            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

        Return objOItem_Result
    End Function

    Public Function get_Data_Objects_Tree(ByVal objOItem_Class_Par As clsOntologyItem, ByVal objOitem_Class_Child As clsOntologyItem, ByVal objOItem_RelationType As clsOntologyItem, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objOItem_Result As clsOntologyItem
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim objOList_Objects As New List(Of clsOntologyItem)
        Dim objOList_RelationTypes As New List(Of clsOntologyItem)
        Dim strQuery As String
        Dim intPos As Integer
        Dim intCount As Integer

        objOItem_Result = objLocalConfig.Globals.LState_Success

        objOntologyList_ObjectTree.Clear()
        otblT_ObjectTree.Clear()

        objOList_Objects.Add(objOItem_Class_Par)
        objOList_Objects.Add(objOitem_Class_Child)
        objOList_RelationTypes.Add(objOItem_RelationType)

        get_Data_Objects(objOList_Objects)

        objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Parent_Object, objOItem_Class_Par.GUID)), BooleanClause.Occur.MUST)
        objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Parent_Other, objOitem_Class_Child.GUID)), BooleanClause.Occur.MUST)
        objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_RelationType, objOItem_RelationType.GUID)), BooleanClause.Occur.MUST)

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0
            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ObjectRel, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits


            Dim objList_Items = From obj In objList
                                Join objLeft In objOntologyList_Objects On obj.Source(objLocalConfig.Globals.Field_ID_Object).ToString Equals objLeft.GUID
                                Join objRight In objOntologyList_Objects On obj.Source(objLocalConfig.Globals.Field_ID_Other).ToString Equals objRight.GUID
                                Join objRel In objOList_RelationTypes On obj.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString Equals objRel.GUID
                                Select ID_Object = objRight.GUID, Name_Object = objRight.Name, ID_Parent = objRight.GUID_Parent, ID_Object_Parent = objLeft.GUID

            For Each objList_Item In objList_Items
                If boolTable = False Then
                    objOntologyList_ObjectTree.Add(New clsObjectTree(objList_Item.ID_Object, _
                                                                     objList_Item.Name_Object, _
                                                                     objList_Item.ID_Parent, _
                                                                     objList_Item.ID_Object_Parent))
                Else
                    otblT_ObjectTree.Rows.Add(objList_Item.ID_Object, _
                                              objList_Item.Name_Object, _
                                              objList_Item.ID_Object_Parent, _
                                              objList_Item.ID_Parent)


                End If
            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

        Return objOItem_Result
    End Function
    Public Function get_Data_Objects(Optional ByVal oList_Objects As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objOItem_Result As clsOntologyItem
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim strQuery As String = ""
        Dim intCount As Integer
        Dim intPos As Integer
        
        otblT_Objects.Clear()
        objOntologyList_Objects.Clear()

        create_BoolQuery_Simple(oList_Objects, objLocalConfig.Globals.Type_Object)

        objOItem_Result = objLocalConfig.Globals.LState_Success
        intCount = 0
        
        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Object, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList
                If boolTable = False Then
                    objOntologyList_Objects.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Class).ToString, _
                                                                objLocalConfig.Globals.Type_Object))
                Else
                    otblT_Objects.Rows.Add(objHit.Id.ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Class).ToString)
                End If


            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

        Return objOItem_Result
    End Function



    Public Function create_Report(Optional ByVal OList_Classes As List(Of clsOntologyItem) = Nothing) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim objOItem As clsOntologyItem
        Dim strTable As String
        Dim intCount As Integer
        Dim intPos As Integer

        intCount = 0
        If OList_Classes Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
        Else
            For Each objOItem In OList_Classes
                strTable = objLocalConfig.Globals.Session & objOItem.GUID
                objBoolQuery.Add(New TermQuery(New Term("ID_Item", objOItem.GUID)), BooleanClause.Occur.MUST)
            Next
        End If


        objOntologyList_Classes1.Clear()

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Class, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits
            'Dim a = From obja In objList
            'Where (Not obja.Source("@fields")("ex_cid") Is Nothing)
            '       Group obja By key = obja.Source("@fields")("ex_cid").First.ToString Into Count() Select key, count = Count

            'For Each b In a
            '    CidA_Count.Insert(Integer.Parse(b.key), b.count)
            'Next
            For Each objHit In objList

                If Not objHit.Source("ID_Parent") = "" Then
                    otblT_Classes.Rows.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Parent).ToString))
                Else
                    otblT_Classes.Rows.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                Nothing))
                End If






            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While
    End Function

    Public Function get_Data_Classes(Optional ByVal OList_Classes As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False, Optional ByVal boolClasses_Right As Boolean = False) As clsOntologyItem

        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim objOItem_Result As clsOntologyItem
        Dim strQuery_ID As String
        Dim strQuery_Name As String
        Dim strQuery_IDParent As String
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer

        If boolClasses_Right = False Then
            objOntologyList_Classes1.Clear()
        Else
            objOntologyList_Classes2.Clear()
        End If


        tbl_Classes.Clear()

        objOItem_Result = objLocalConfig.Globals.LState_Success
        intCount = 0

        create_BoolQuery_Simple(OList_Classes, objLocalConfig.Globals.Type_Class)


        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0

            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Class, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits
            'Dim a = From obja In objList
            'Where (Not obja.Source("@fields")("ex_cid") Is Nothing)
            '       Group obja By key = obja.Source("@fields")("ex_cid").First.ToString Into Count() Select key, count = Count

            'For Each b In a
            '    CidA_Count.Insert(Integer.Parse(b.key), b.count)
            'Next
            For Each objHit In objList
                If boolTable = False Then
                    If Not objHit.Source("ID_Parent") = "" Then
                        If boolClasses_Right = False Then
                            objOntologyList_Classes1.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent).ToString, _
                                                                    objLocalConfig.Globals.Type_Class))
                        Else
                            objOntologyList_Classes2.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent).ToString, _
                                                                    objLocalConfig.Globals.Type_Class))
                        End If

                    Else
                        If boolClasses_Right = False Then
                            objOntologyList_Classes1.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                    objLocalConfig.Globals.Type_Class))
                        Else
                            objOntologyList_Classes2.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                    objLocalConfig.Globals.Type_Class))
                        End If

                    End If
                Else
                    If Not objHit.Source("ID_Parent") = "" Then
                        otblT_Classes.Rows.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent).ToString))
                    Else
                        otblT_Classes.Rows.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                    Nothing))
                    End If
                End If





            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

        Return objOItem_Result
    End Function

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)
        set_DBConnection()
        initialize_Client()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
        initialize_Client()
    End Sub

    Private Sub set_DBConnection()

        objConnection = New SqlClient.SqlConnection(objLocalConfig.Globals.get_ConnectionStr(objLocalConfig.Globals.Rep_Server, objLocalConfig.Globals.Rep_Instance, objLocalConfig.Globals.Rep_Database))

        createA_Table_orgT.Connection = objConnection

    End Sub

End Class
