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

    Private objConnection As SqlClient.SqlConnection
    Private createA_Table_orgT As New DataSet_ConfigTableAdapters.create_Table_orgTTableAdapter

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

        objElConn = New ElasticSearch.Client.ElasticSearchClient(objLocalConfig.Globals.Server, objLocalConfig.Globals.Port, Client.Config.TransportType.Thrift, False)
        'objElConn = New ElasticSearch.Client.ElasticSearchClient("ontology_db")
    End Sub

    Public Function get_Data_RelationTypes(Optional ByVal OList_RelType As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim objFieldQuery_ID As New clsFieldQuery
        Dim objFieldQuery_Name As New clsFieldQuery
        Dim oItem As clsOntologyItem
        Dim intCount As Integer
        Dim intPos As Integer

        intCount = 0
        If OList_RelType Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
        Else
            For Each oItem In OList_RelType
                If oItem.GUID <> "" Then
                    objFieldQuery_ID.Field = "ID_Item"

                    If objFieldQuery_ID.Query <> "" Then
                        objFieldQuery_ID.Query = objFieldQuery_ID.Query & " OR "
                    End If

                    objFieldQuery_ID.Query = objFieldQuery_ID.Query & oItem.GUID


                End If

                If oItem.Name <> "" Then
                    objFieldQuery_Name.Field = objLocalConfig.Globals.Field_Name_Item

                    If objFieldQuery_Name.Query <> "" Then
                        objFieldQuery_Name.Query = objFieldQuery_Name.Query & " OR "
                    End If

                    objFieldQuery_Name.Query = objFieldQuery_Name.Query & oItem.Name
                End If
            Next
            If objFieldQuery_ID.Field <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_ID.Field, objFieldQuery_ID.Query)), BooleanClause.Occur.MUST)
            End If

            If objFieldQuery_Name.Field <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_Name.Field, objFieldQuery_Name.Query)), BooleanClause.Occur.MUST)
            End If

        End If

        otblT_RelationTypes.Clear()
        objOntologyList_RelationTypes.Clear()

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_RelationType, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
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
                                                                objLocalConfig.Globals.Type_RelationType))
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

    Public Function get_Data_AttributeType(Optional ByVal OList_AttType As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objOItem_AttType As clsOntologyItem
        Dim objFieldQuery_ID As New clsFieldQuery
        Dim objFieldQuery_Name As New clsFieldQuery
        Dim objFieldQuery_ID_DataType As New clsFieldQuery

        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim intCount As Integer
        Dim intPos As Integer

        intCount = 0
        If OList_AttType Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
        Else
            For Each objOItem_AttType In OList_AttType
                If objOItem_AttType.GUID <> "" Then
                    objFieldQuery_ID.Field = "id"
                    If objFieldQuery_ID.Query <> "" Then
                        objFieldQuery_ID.Query = objFieldQuery_ID.Query & " OR "
                    End If
                    objFieldQuery_ID.Query = objFieldQuery_ID.Query & objOItem_AttType.GUID

                End If

                If objOItem_AttType.Name <> "" Then
                    objFieldQuery_Name.Field = objLocalConfig.Globals.Field_Name_Item
                    If objFieldQuery_Name.Query <> "" Then
                        objFieldQuery_Name.Query = objFieldQuery_Name.Query & " OR "
                    End If
                    objFieldQuery_Name.Query = objFieldQuery_Name.Query & objOItem_AttType.Name

                End If

                If objOItem_AttType.GUID_Parent <> "" Then
                    objFieldQuery_ID_DataType.Field = objLocalConfig.Globals.Field_ID_DataType
                    If objFieldQuery_ID_DataType.Query <> "" Then
                        objFieldQuery_ID_DataType.Query = objFieldQuery_ID_DataType.Query & " OR "
                    End If
                    objFieldQuery_ID_DataType.Query = objFieldQuery_ID_DataType.Query & objOItem_AttType.GUID_Parent

                End If
            Next
            If objFieldQuery_ID.Field <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_ID.Field, objFieldQuery_ID.Query)), BooleanClause.Occur.MUST)
            End If

            If objFieldQuery_Name.Field <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_Name.Field, objFieldQuery_ID.Query)), BooleanClause.Occur.MUST)
            End If

            If objFieldQuery_ID_DataType.Field <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_ID_DataType.Field, objFieldQuery_ID_DataType.Query)), BooleanClause.Occur.MUST)
            End If

        End If

        otblT_RelationTypes.Clear()
        objOntologyList_RelationTypes.Clear()

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
                    objOntologyList_Attributes.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_DataType).ToString, _
                                                                objLocalConfig.Globals.Type_AttributeType))
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

    Public Function get_Data_Objects(Optional ByVal oList_Objects As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objOItem_Object As clsOntologyItem
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim strQuery As String = ""
        Dim intCount As Integer
        Dim intPos As Integer
        Dim objFieldQuery_ID As New clsFieldQuery
        Dim objFieldQuery_Name As New clsFieldQuery
        Dim objFieldQuery_Class As New clsFieldQuery
        Dim objOItem As clsOntologyItem

        

        intCount = 0
        If oList_Objects Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
        Else

            For Each objOItem In oList_Objects
                If Not objOItem.GUID = "" Then
                    If objFieldQuery_ID.Field = "" Then
                        objFieldQuery_ID.Field = "ID_Item"
                    End If

                    If objFieldQuery_ID.Query <> "" Then
                        objFieldQuery_ID.Query = objFieldQuery_ID.Query & " OR "
                    End If

                    objFieldQuery_ID.Query = objFieldQuery_ID.Query & objOItem.GUID
                End If

                If Not objOItem.Name = "" Then
                    If objFieldQuery_Name.Field = "" Then
                        objFieldQuery_Name.Field = objLocalConfig.Globals.Field_Name_Item
                    End If

                    If objFieldQuery_Name.Query <> "" Then
                        objFieldQuery_Name.Query = objFieldQuery_Name.Query & " OR "
                    End If

                    objFieldQuery_Name.Query = objFieldQuery_Name.Query & "*" & objOItem.Name & "*"
                End If

                If Not objOItem.GUID_Parent = "" Then
                    If objFieldQuery_Class.Field = "" Then
                        objFieldQuery_Class.Field = objLocalConfig.Globals.Field_ID_Class
                    End If

                    If objFieldQuery_Class.Query <> "" Then
                        objFieldQuery_Class.Query = objFieldQuery_Class.Query & " OR "
                    End If

                    objFieldQuery_Class.Query = objFieldQuery_Class.Query & objOItem.GUID_Parent
                End If

            Next
            If objFieldQuery_ID.Field <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_ID.Field, objFieldQuery_ID.Query)), BooleanClause.Occur.MUST)
            End If

            If objFieldQuery_Name.Field <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_Name.Field, objFieldQuery_Name.Query)), BooleanClause.Occur.MUST)
            End If

            If objFieldQuery_Class.Field <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_Class.Field, objFieldQuery_Class.Query)), BooleanClause.Occur.MUST)
            End If


        End If

        otblT_Objects.Clear()
        objOntologyList_Objects.Clear()

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Object, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
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
                                                                objLocalConfig.Globals.Type_Object))
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

    Public Function create_Report(Optional ByVal OList_Classes As List(Of clsOntologyItem) = Nothing) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim objOItem As clsOntologyItem
        Dim objFieldQuery_ID As New clsFieldQuery
        Dim objFieldQuery_Name As New clsFieldQuery
        Dim objFieldQuery_ID_Parent As New clsFieldQuery
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


        objOntologyList_Classes.Clear()

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

    Public Function get_Data_Classes(Optional ByVal OList_Classes As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim objOItem As clsOntologyItem
        Dim objFieldQuery_ID As New clsFieldQuery
        Dim objFieldQuery_Name As New clsFieldQuery
        Dim objFieldQuery_ID_Parent As New clsFieldQuery
        Dim intCount As Integer
        Dim intPos As Integer

        intCount = 0
        If OList_Classes Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
        Else
            For Each objOItem In OList_Classes
                If objOItem.GUID <> "" Then
                    objFieldQuery_ID.Field = "ID_Item"
                    If objFieldQuery_ID.Query <> "" Then
                        objFieldQuery_ID.Query = objFieldQuery_ID.Query & " OR "
                    End If
                    objFieldQuery_ID.Query = objFieldQuery_ID.Query & objOItem.GUID
                End If

                If objOItem.Name <> "" Then
                    objFieldQuery_Name.Field = objLocalConfig.Globals.Field_Name_Item
                    If objFieldQuery_Name.Query <> "" Then
                        objFieldQuery_Name.Query = objFieldQuery_Name.Query & " OR "
                    End If
                    objFieldQuery_Name.Query = objFieldQuery_Name.Query & objOItem.Name
                End If

                If objOItem.GUID_Parent <> "" Then
                    objFieldQuery_ID_Parent.Field = objLocalConfig.Globals.Field_ID_Parent
                    If objFieldQuery_ID_Parent.Query <> "" Then
                        objFieldQuery_ID_Parent.Query = objFieldQuery_ID_Parent.Query & " OR "
                    End If
                    objFieldQuery_ID_Parent.Query = objFieldQuery_ID_Parent.Query & objOItem.GUID_Parent
                End If
            Next

            If objFieldQuery_ID.Field <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_ID.Field, objFieldQuery_ID.Query)), BooleanClause.Occur.MUST)
            End If

            If objFieldQuery_Name.Field <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_Name.Field, objFieldQuery_Name.Query)), BooleanClause.Occur.MUST)
            End If

            If objFieldQuery_ID_Parent.Field <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_ID_Parent.Field, objFieldQuery_ID_Parent.Query)), BooleanClause.Occur.MUST)
            End If
        End If


        objOntologyList_Classes.Clear()

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
                        objOntologyList_Classes.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent).ToString, _
                                                                    objLocalConfig.Globals.Type_Class))
                    Else
                        objOntologyList_Classes.Add(New clsOntologyItem(objHit.Id.ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Name_Item).ToString, _
                                                                    objLocalConfig.Globals.Type_Class))
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
        set_DBConnection()
        initialize_Client()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
        initialize_Client()
    End Sub

    Private Sub set_DBConnection()
        Dim strConnection As String

        
        objConnection = New SqlClient.SqlConnection(objLocalConfig.Globals.get_ConnectionStr(objLocalConfig.Globals.Rep_Server, objLocalConfig.Globals.Rep_Instance, objLocalConfig.Globals.Rep_Database))

        createA_Table_orgT.Connection = objConnection

    End Sub

End Class
