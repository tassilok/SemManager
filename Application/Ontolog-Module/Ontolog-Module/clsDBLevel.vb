Imports ElasticSearch
Imports Lucene.Net.Search
Imports Lucene.Net.Index

Public Class clsDBLevel
    Private objElConn As ElasticSearch.Client.ElasticSearchClient
    Private objOntologyList_Objects As New List(Of clsOntologyItem)
    Private objOntologyList_Classes As New List(Of clsOntologyItem)
    Private objOntologyList_RelationTypes As New List(Of clsOntologyItem)

    Private otblT_Objects As New DataSet_Config.otbl_ObjectsDataTable
    Private otblT_Classes As New DataSet_Config.otbl_ClassesDataTable
    Private otblT_RelationTypes As New DataSet_Config.otbl_RelationTypesDataTable

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
                    objOntologyList_RelationTypes.Add(New clsOntologyItem(New Guid(objHit.Id.ToString), _
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

    Public Function get_Data_Objects(Optional ByVal OItem_Object As clsOntologyItem = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim intCount As Integer
        Dim intPos As Integer

        intCount = 0
        If OItem_Object Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_ItemType", objLocalConfig.Globals.OType_Object.GUID.ToString)), BooleanClause.Occur.MUST)
        Else
            If objLocalConfig.Globals.is_GUID(OItem_Object.GUID.ToString) Then
                objBoolQuery.Add(New TermQuery(New Term("ID_Class", OItem_Object.GUID.ToString)), BooleanClause.Occur.MUST)
                objBoolQuery.Add(New TermQuery(New Term("ID_ItemType", objLocalConfig.Globals.OType_Object.GUID.ToString)), BooleanClause.Occur.MUST)
            End If
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
                    objOntologyList_Objects.Add(New clsOntologyItem(New Guid(objHit.Id.ToString), _
                                                                objHit.Source("Name_Item").ToString, _
                                                                New Guid(objHit.Source("ID_Class").ToString), _
                                                                objLocalConfig.Globals.OType_Object.GUID))
                Else
                    otblT_Objects.Rows.Add(New Guid(objHit.Id.ToString), _
                                                                objHit.Source("Name_Item").ToString, _
                                                                New Guid(objHit.Source("ID_Class").ToString))
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
            objBoolQuery.Add(New TermQuery(New Term("ID_ItemType", objLocalConfig.Globals.OType_Class.GUID.ToString)), BooleanClause.Occur.MUST)
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
                        objOntologyList_Classes.Add(New clsOntologyItem(New Guid(objHit.Id.ToString), _
                                                                    objHit.Source("Name_Item").ToString, _
                                                                    New Guid(objHit.Source("ID_Parent").ToString), _
                                                                    objLocalConfig.Globals.OType_Class.GUID))
                    Else
                        objOntologyList_Classes.Add(New clsOntologyItem(New Guid(objHit.Id.ToString), _
                                                                    objHit.Source("Name_Item").ToString, _
                                                                    objLocalConfig.Globals.OType_Class.GUID))
                    End If
                Else
                    If Not objHit.Source("ID_Parent") = "" Then
                        otblT_Classes.Rows.Add(New clsOntologyItem(New Guid(objHit.Id.ToString), _
                                                                    objHit.Source("Name_Item").ToString, _
                                                                    New Guid(objHit.Source("ID_Parent").ToString)))
                    Else
                        otblT_Classes.Rows.Add(New clsOntologyItem(New Guid(objHit.Id.ToString), _
                                                                    objHit.Source("Name_Item").ToString, _
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
