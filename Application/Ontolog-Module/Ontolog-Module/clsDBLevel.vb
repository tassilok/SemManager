Imports ElasticSearch
Imports Lucene.Net.Search
Imports Lucene.Net.Index

Public Class clsDBLevel
    Private objElConn As ElasticSearch.Client.ElasticSearchClient
    Private objOntologyList_Objects As New List(Of clsOntologyItem)
    Private objOntologyList_Classes As New List(Of clsOntologyItem)
    Private objOntologyList_RelationTypes As New List(Of clsOntologyItem)
    Private objOntologyList_Attributes As New List(Of clsOntologyItem)

    Private otblT_Objects As New DataSet_Config.otbl_ObjectsDataTable
    Private otblT_Classes As New DataSet_Config.otbl_ClassesDataTable
    Private otblT_RelationTypes As New DataSet_Config.otbl_RelationTypesDataTable
    Private otblT_Attributes As New DataSet_Config.otbl_AttributesDataTable

    Private oList_DBLevel As List(Of clsDBLevel)

    Private objLocalConfig As clsLocalConfig

    Public ReadOnly Property OList_Classes As List(Of clsOntologyItem)
        Get
            Return objOntologyList_Classes
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

    Public ReadOnly Property OList_Attributes As List(Of clsOntologyItem)
        Get
            Return objOntologyList_Attributes
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

    Public ReadOnly Property tbl_RelationTypes As DataSet_Config.otbl_RelationTypesDataTable
        Get
            Return otblT_RelationTypes
        End Get
    End Property

    Public ReadOnly Property tbl_Attributes As DataSet_Config.otbl_AttributesDataTable
        Get
            Return otblT_Attributes
        End Get
    End Property

    Private Sub initialize_Client()

        objElConn = New ElasticSearch.Client.ElasticSearchClient(objLocalConfig.Globals.Cluster)
    End Sub

    Public Function get_Data_RelationTypes(Optional ByVal OItem_RelType As clsOntologyItem = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim intCount As Integer
        Dim intPos As Integer

        intCount = 0
        If OItem_RelType Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_ItemType", objLocalConfig.Globals.OType_RelationType.GUID.ToString)), BooleanClause.Occur.MUST)
        Else
            
        End If

        otblT_RelationTypes.Clear()
        objOntologyList_RelationTypes.Clear()

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits
            'Dim a = From obja In objList
            'Where (Not obja.Source("@fields")("ex_cid") Is Nothing)
            '       Group obja By key = obja.Source("@fields")("ex_cid").First.ToString Into Count() Select key, count = Count

            'For Each b In a
            '    CidA_Count.Insert(Integer.Parse(b.key), b.count)
            'Next
            For Each objHit In objList
                If boolTable = False Then
                    objOntologyList_RelationTypes.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                objHit.Source("Name_Item").ToString, _
                                                                objLocalConfig.Globals.OType_RelationType.GUID))
                Else
                    otblT_RelationTypes.Rows.Add(New Guid(objHit.Id.ToString), _
                                                                objHit.Source("Name_Item").ToString)
                End If


            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

    End Function

    Public Function get_Data_Attributes(Optional ByVal OItem_RelType As clsOntologyItem = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim intCount As Integer
        Dim intPos As Integer

        intCount = 0
        If OItem_RelType Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_ItemType, objLocalConfig.Globals.OType_Attribute.GUID.ToString)), BooleanClause.Occur.MUST)
        Else

        End If

        otblT_RelationTypes.Clear()
        objOntologyList_RelationTypes.Clear()

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits
            'Dim a = From obja In objList
            'Where (Not obja.Source("@fields")("ex_cid") Is Nothing)
            '       Group obja By key = obja.Source("@fields")("ex_cid").First.ToString Into Count() Select key, count = Count

            'For Each b In a
            '    CidA_Count.Insert(Integer.Parse(b.key), b.count)
            'Next
            For Each objHit In objList
                If boolTable = False Then
                    objOntologyList_Attributes.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_DataType).ToString, _
                                                                objLocalConfig.Globals.OType_Attribute.GUID))
                Else
                    otblT_Attributes.Rows.Add(New Guid(objHit.Id.ToString), _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                New Guid(objHit.Source(objLocalConfig.Globals.Field_ID_DataType).ToString))
                End If


            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

    End Function

    Public Function get_Data_Objects(Optional ByVal oList_Objects As List(of clsOntologyItem), Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objOItem_Object As clsOntologyItem
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim strQuery As String = ""
        Dim intCount As Integer
        Dim intPos As Integer

        intCount = 0
        If oList_Objects Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_ItemType, objLocalConfig.Globals.OType_Object.GUID.ToString)), BooleanClause.Occur.MUST)
        Else
            objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_ItemType, objLocalConfig.Globals.OType_Object.GUID.ToString)), BooleanClause.Occur.MUST)

            For Each objOItem_Object In oList_Objects
                If objLocalConfig.Globals.is_GUID(objOItem_Object.GUID_Parent.ToString) Then
                    If strQuery <> "" Then
                        strQuery = strQuery & " OR "
                    End If
                    strQuery = strQuery & objOItem_Object.GUID_Parent
                End If
            Next
            objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Class, strQuery)), BooleanClause.Occur.MUST)
            
        End If

        otblT_Objects.Clear()
        objOntologyList_Objects.Clear()

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits
            'Dim a = From obja In objList
            'Where (Not obja.Source("@fields")("ex_cid") Is Nothing)
            '       Group obja By key = obja.Source("@fields")("ex_cid").First.ToString Into Count() Select key, count = Count

            'For Each b In a
            '    CidA_Count.Insert(Integer.Parse(b.key), b.count)
            'Next
            For Each objHit In objList
                If boolTable = False Then
                    objOntologyList_Objects.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Class).ToString, _
                                                                objLocalConfig.Globals.OType_Object.GUID))
                Else
                    otblT_Objects.Rows.Add(New Guid(objHit.Id.ToString), _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                New Guid(objHit.Source(objLocalConfig.Globals.Field_ID_Class).ToString))
                End If


            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

    End Function

    Public Function get_Data_Classes(Optional ByVal OItem_Classes As clsOntologyItem = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim intCount As Integer
        Dim intPos As Integer

        intCount = 0
        If OItem_Classes Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_ItemType, objLocalConfig.Globals.OType_Class.GUID.ToString)), BooleanClause.Occur.MUST)
        End If


        objOntologyList_Classes.Clear()

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
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
                        objOntologyList_Classes.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Right).ToString, _
                                                                    objLocalConfig.Globals.OType_Class.GUID))
                    Else
                        objOntologyList_Classes.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                    objLocalConfig.Globals.OType_Class.GUID))
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

    End Function

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)
        initialize_Client()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        initialize_Client()
    End Sub
End Class
