Imports ElasticSearch
Imports Lucene.Net.Search
Imports Lucene.Net.Index

Public Class clsDBLevel
    Private objElConn As ElasticSearch.Client.ElasticSearchClient
    Private objOntologyList_Objects As New List(Of clsOntologyItem)
    Private objOntologyList_ObjectRel As New List(Of clsObjectRel)
    Private objOntologyList_ObjectTree As New List(Of clsObjectTree)
    Private objOntologyList_Classes As New List(Of clsOntologyItem)
    Private objOntologyList_RelationTypes As New List(Of clsOntologyItem)
    Private objOntologyList_AttributTypes As New List(Of clsOntologyItem)
    Private objOntologyList_ClassRel_ID As New List(Of clsClassRel)
    Private objOntologyList_ClassRel_Named As New List(Of clsClassRel)
    Private objOntologyList_ClassAtt As New List(Of clsClassAtt)
    Private objOntologyList_ObjRel_ID As New List(Of clsObjectRel)
    Private objOntologyList_ObjRel_Named As New List(Of clsObjectRel)
    Private objOntologyList_ObjAtt_ID As New List(Of clsObjectAtt)
    Private objOntologyList_DataTypes As New List(Of clsOntologyItem)

    Private otblT_Objects As New DataSet_Config.otbl_ObjectsDataTable
    Private otblT_Classes As New DataSet_Config.otbl_ClassesDataTable
    Private otblT_RelationTypes As New DataSet_Config.otbl_RelationTypesDataTable
    Private otblT_AttributeTypes As New DataSet_Config.otbl_AttributeTypesDataTable
    Private otblT_ObjectRel As New DataSet_Config.otbl_ObjectRelDataTable
    Private otblT_DataTypes As New DataSet_Config.otbl_DataTypesDataTable
    Private otblT_ObjectTree As New DataSet_Config.otbl_ObjetTreeDataTable
    Private otblT_ObjectAtt As New DataSet_Config.otbl_ObjectAttDataTable

    Private oList_DBLevel As List(Of clsDBLevel)

    Private objConnection As SqlClient.SqlConnection
    Private createA_Table_orgT As New DataSet_ConfigTableAdapters.create_Table_orgTTableAdapter

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

    Public ReadOnly Property OList_ClassAtt As List(Of clsClassAtt)
        Get
            Return objOntologyList_ClassAtt
        End Get
    End Property

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

    Public ReadOnly Property OList_ObjectRel As List(Of clsObjectRel)
        Get
            Return objOntologyList_ObjRel_Named
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

    Public ReadOnly Property tbl_ObjecRelation As DataSet_Config.otbl_ObjectRelDataTable
        Get
            Return otblT_ObjectRel
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
        If OList_RelType Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
        Else
            If OList_RelType.Count = 0 Then
                objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
            Else
                If OList_RelType.Count = 1 And OList_RelType(0).GUID = "" And OList_RelType(0).Name = "" And OList_RelType(0).GUID_Parent = "" Then
                    objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
                Else
                    Dim strLQuery_ID = From rel As clsOntologyItem In OList_RelType Group By rel.GUID Into Group Select GUID
                    Dim strLQuery_Name = From rel As clsOntologyItem In OList_RelType Group By rel.Name Into Group Select Name

                    strQuery = ""

                    For Each strQuery_ID In strLQuery_ID
                        If strQuery <> "" Then
                            strQuery = strQuery & "\ OR\ "
                        End If
                        strQuery = strQuery & strQuery_ID
                    Next

                    If strQuery <> "" Then
                        objBoolQuery.Add(New TermQuery(New Term("ID_Item", strQuery)), BooleanClause.Occur.MUST)
                    End If


                    strQuery = ""
                    For Each strQuery_Name In strLQuery_Name
                        If strQuery <> "" Then
                            strQuery = strQuery & "\ OR\ "
                        End If
                        If strQuery_Name <> "" Then
                            strQuery = strQuery & """*" & strQuery_Name & "*"""
                        End If

                    Next
                    If strQuery <> "" Then

                        objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_Name_Item, strQuery)), BooleanClause.Occur.MUST)
                    End If
                End If
                
            End If


            End If

    
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

    Public Function get_Data_AttributeType(Optional ByVal OList_AttType As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objOItem_Result As clsOntologyItem
        Dim strQuery_ID As String
        Dim strQuery_Name As String
        Dim strQuery_IDParent As String
        Dim strQuery As String
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim intCount As Integer
        Dim intPos As Integer

        otblT_AttributeTypes.Clear()
        objOntologyList_AttributTypes.Clear()


        objOItem_Result = objLocalConfig.Globals.LState_Success

        intCount = 0
        If OList_AttType Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
        Else
            If OList_AttType(0).GUID = "" And OList_AttType(0).Name = "" And OList_AttType(0).GUID_Parent = "" Then
                objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
            Else
                Dim strLQuery_ID = From at As clsOntologyItem In OList_AttType Group By at.GUID Into Group Select GUID
                Dim strLQuery_Name = From at As clsOntologyItem In OList_AttType Group By at.Name Into Group Select Name
                Dim strLQuery_AttributeType = From at As clsOntologyItem In OList_AttType Group By at.GUID_Parent Into Group Select GUID_Parent

                strQuery = ""
                For Each strQuery_ID In strLQuery_ID
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & strQuery_ID
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term("ID_Item", strQuery)), BooleanClause.Occur.MUST)
                End If

                strQuery = ""
                For Each strQuery_Name In strLQuery_Name
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    If strQuery_Name <> "" Then
                        strQuery = strQuery & """*" & strQuery_Name & "*"""
                    End If

                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_Name_Item, strQuery)), BooleanClause.Occur.MUST)
                End If

                strQuery = ""
                For Each strQuery_IDParent In strLQuery_AttributeType
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    If strQuery_IDParent <> "" Then
                        strQuery = strQuery & strQuery_IDParent
                    End If

                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_Name_Item, strQuery)), BooleanClause.Occur.MUST)
                End If
            End If


        End If

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

    Public Function get_Data_ClassAtt(ByVal oList_Class As List(Of clsOntologyItem), Optional ByVal boolTable As Boolean = False) As clsOntologyItem
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

        objOntologyList_ClassAtt.Clear()

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ClassAtt, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList

                objOntologyList_ClassAtt.Add(New clsClassAtt(objHit.Source(objLocalConfig.Globals.Field_ID_AttributeType).ToString, _
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

        Dim strLGUID_Attributetype = From obj In objOntologyList_ClassAtt
                               Group By obj.ID_AttributeType Into Group
                               Select ID_AttributeType

        For Each strGUID_AttributeType In strLGUID_Attributetype
            oList_AttributeTypes.Add(New clsOntologyItem(strGUID_AttributeType, objLocalConfig.Globals.Type_AttributeType))

        Next

        If oList_AttributeTypes.Count > 0 Then
            get_Data_AttributeType(oList_AttributeTypes, boolTable)
        End If


        Return objOItem_Result
    End Function

    Public Function get_Data_ClassRel(ByVal oList_Class As List(Of clsOntologyItem), ByVal Direction As clsOntologyItem, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objOItem_Result As clsOntologyItem
        Dim oList_Classes As New List(Of clsOntologyItem)
        Dim oList_Rels As New List(Of clsOntologyItem)
        Dim strLGUID_Class As Object
        Dim strLGUID_Rel As Object
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer

        oList_Classes.Clear()
        oList_Rels.Clear()

        objOItem_Result = objLocalConfig.Globals.LState_Success

        Dim strLQuery_LID = From obj As clsOntologyItem In oList_Class Group By obj.GUID Into Group Select GUID = GUID

        strQuery = ""
        For Each strQuery_ID In strLQuery_LID
            If strQuery <> "" Then
                strQuery = strQuery & "\ OR\ "
            End If
            strQuery = strQuery & strQuery_ID
        Next
        If strQuery <> "" Then
            If Direction.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
                objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Class_Left, strQuery)), BooleanClause.Occur.MUST)
            Else
                objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Class_Right, strQuery)), BooleanClause.Occur.MUST)
            End If

        End If

        objOntologyList_ClassRel_ID.Clear()

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0


            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ClassRel, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits
            'Dim a = From obja In objList
            'Where (Not obja.Source("@fields")("ex_cid") Is Nothing)
            '       Group obja By key = obja.Source("@fields")("ex_cid").First.ToString Into Count() Select key, count = Count

            'For Each b In a
            '    CidA_Count.Insert(Integer.Parse(b.key), b.count)
            'Next

            For Each objHit In objList

                objOntologyList_ClassRel_ID.Add(New clsClassRel(objHit.Source(objLocalConfig.Globals.Field_ID_Class_Left).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_ID_Class_Right).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString, _
                                                             objHit.Source(objLocalConfig.Globals.Field_Min_forw), _
                                                             objHit.Source(objLocalConfig.Globals.Field_Max_forw), _
                                                             objHit.Source(objLocalConfig.Globals.Field_Max_backw)))


            Next


            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

        If Direction.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
            strLGUID_Class = From objClRel In objOntologyList_ClassRel_ID Group By objClRel.ID_Class_Right Into Group Select ID_Class_Right
            For Each strGUID In strLGUID_Class
                oList_Classes.Add(New clsOntologyItem(strGUID, Nothing, objLocalConfig.Globals.Type_Class))
            Next
        Else
            strLGUID_Class = From objClRel In objOntologyList_ClassRel_ID Group By objClRel.ID_Class_Left Into Group Select ID_Class_Left
            For Each strGUID In strLGUID_Class
                oList_Classes.Add(New clsOntologyItem(strGUID, Nothing, objLocalConfig.Globals.Type_Class))
            Next
        End If
        If oList_Classes.Count > 0 Then
            get_Data_Classes(oList_Classes, boolTable)
        End If


        strLGUID_Rel = From objClRel In objOntologyList_ClassRel_ID Group By objClRel.ID_RelationType Into Group Select ID_RelationType
        For Each strGUID In strLGUID_Rel
            oList_Rels.Add(New clsOntologyItem(strGUID, Nothing, objLocalConfig.Globals.Type_RelationType))
        Next

        get_Data_RelationTypes(oList_Rels, boolTable)

        Return objOItem_Result
    End Function

    Public Function get_Data_ObjectAtt(Optional ByRef oItem_Object As clsOntologyItem = Nothing, Optional ByVal oItem_AttributeType As clsOntologyItem = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
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
                If boolTable = False Then
                    objOntologyList_ObjAtt_ID.Add(New clsObjectAtt(objHit.Source(objLocalConfig.Globals.Field_ID_ObjectAttribute).ToString, _
                                                                   objHit.Source(objLocalConfig.Globals.Field_ID_Object).ToString, _
                                                                   objHit.Source(objLocalConfig.Globals.Field_ID_Class).ToString, _
                                                                   objHit.Source(objLocalConfig.Globals.Field_ID_AttributeType).ToString, _
                                                                   objHit.Source(objLocalConfig.Globals.Field_OrderID).ToString))
                Else
                    otblT_ObjectAtt.Rows.Add(objHit.Source(objLocalConfig.Globals.Field_ID_ObjectAttribute).ToString, _
                                                                   objHit.Source(objLocalConfig.Globals.Field_ID_Object).ToString, _
                                                                   Nothing, _
                                                                   objHit.Source(objLocalConfig.Globals.Field_ID_AttributeType).ToString, _
                                                                   Nothing, _
                                                                   objHit.Source(objLocalConfig.Globals.Field_ID_Class).ToString, _
                                                                   Nothing, _
                                                                   objHit.Source(objLocalConfig.Globals.Field_OrderID), _
                                                                   Nothing, _
                                                                   Nothing, _
                                                                   Nothing, _
                                                                   Nothing, _
                                                                   Nothing, _
                                                                   Nothing, _
                                                                   Nothing, _
                                                                   Nothing)
                End If
            Next
        End While


        Return objOItem_Result
    End Function

    Public Function get_Data_ObjectRel(Optional ByVal oItem_ObjectLeft As clsOntologyItem = Nothing, Optional ByVal oItem_ObjectRight As clsOntologyItem = Nothing, Optional ByVal oItem_RelationType As clsOntologyItem = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim objOItem_Result As clsOntologyItem = objLocalConfig.Globals.LState_Success
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer

        objOntologyList_ClassRel_ID.Clear()

        If Not oItem_ObjectLeft Is Nothing Then
            strQuery = ""
            If oItem_ObjectLeft.GUID <> "" Then
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If


                strQuery = strQuery & oItem_ObjectLeft.GUID

            End If

            If strQuery <> "" Then
                objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_ID_Object, strQuery)), BooleanClause.Occur.MUST)
            End If

            strQuery = ""
            If oItem_ObjectLeft.GUID_Parent <> "" Then
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If


                strQuery = strQuery & oItem_ObjectLeft.GUID_Parent

            End If

            If strQuery <> "" Then
                objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_ID_Parent_Object, strQuery)), BooleanClause.Occur.MUST)
            End If
        End If
        
        If Not oItem_ObjectRight Is Nothing Then
            strQuery = ""
            If oItem_ObjectRight.GUID <> "" Then
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If


                strQuery = strQuery & oItem_ObjectRight.GUID

            End If

            If strQuery <> "" Then
                objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_ID_Other, strQuery)), BooleanClause.Occur.MUST)
            End If

            strQuery = ""
            If oItem_ObjectRight.Type <> "" Then
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If


                strQuery = strQuery & oItem_ObjectRight.Type

            End If

            If strQuery <> "" Then
                objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_Ontology, strQuery)), BooleanClause.Occur.MUST)
            End If
        End If

        If Not oItem_RelationType Is Nothing Then
            strQuery = ""
            If oItem_RelationType.GUID <> "" Then
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If


                strQuery = strQuery & oItem_RelationType.GUID

            End If

            If strQuery <> "" Then
                objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_ID_RelationType, strQuery)), BooleanClause.Occur.MUST)
            End If
        End If
        

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ObjectRel, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList

                If boolTable = False Then
                    If Not objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Other) = Nothing Then
                        objOntologyList_ObjectRel.Add(New clsObjectRel(objHit.Source(objLocalConfig.Globals.Field_ID_Object).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Object).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Other).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Other).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Ontology).ToString, _
                                                                    objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_OrderID).ToString))
                    Else

                        objOntologyList_ObjectRel.Add(New clsObjectRel(objHit.Source(objLocalConfig.Globals.Field_ID_Object).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Object).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Other).ToString, _
                                                                    Nothing, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Ontology).ToString, _
                                                                    objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_OrderID).ToString))
                    End If
                Else
                    If Not objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Other) = Nothing Then
                        otblT_ObjectRel.Rows.Add(objHit.Source(objLocalConfig.Globals.Field_ID_Object).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Object).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Other).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Other).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Ontology).ToString, _
                                                                    objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_OrderID).ToString)
                    Else
                        otblT_ObjectRel.Rows.Add(objHit.Source(objLocalConfig.Globals.Field_ID_Object).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Object).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_Other).ToString, _
                                                                    Nothing, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_Ontology).ToString, _
                                                                    objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                                    objHit.Source(objLocalConfig.Globals.Field_OrderID).ToString)
                    End If
                    
                End If

            Next
        End While

        Return objOItem_Result
    End Function



    Public Function get_Data_ObjectRel_Joined(ByVal oList_Objects As List(Of clsOntologyItem), Optional ByVal boolTable As Boolean = False) As clsOntologyItem


        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim objOItem_Result As clsOntologyItem
        Dim objOList_AttributeType As New List(Of clsOntologyItem)
        Dim objOList_Object As New List(Of clsOntologyItem)
        Dim objOList_Class As New List(Of clsOntologyItem)
        Dim objOList_RelationType As New List(Of clsOntologyItem)
        Dim objOList_DataTypes As New List(Of clsOntologyItem)
        Dim objOList_ClassesRel As New List(Of clsOntologyItem)
        Dim objDBLevel_RelationType As New clsDBLevel(objLocalConfig)
        Dim objDBLevel_DataTypes As New clsDBLevel(objLocalConfig)
        Dim objDBLevel_Classes As New clsDBLevel(objLocalConfig)
        Dim objDBLevel_Objects As New clsDBLevel(objLocalConfig)
        Dim objDBLevel_AttributeTypes As New clsDBLevel(objLocalConfig)
        Dim strQuery_ObjID As String
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer

        otblT_ObjectRel.Clear()
        objOntologyList_ObjectRel.Clear()

        objOItem_Result = objLocalConfig.Globals.LState_Success

        Dim strLQuery_ObjID = From obj As clsOntologyItem In oList_Objects Group By obj.GUID Into Group Select GUID = GUID

        strQuery = ""
        For Each strQuery_ObjID In strLQuery_ObjID
            If strQuery <> "" Then
                strQuery = strQuery & "\ OR\ "
            End If

            If strQuery_ObjID <> "" Then
                strQuery = strQuery & strQuery_ObjID
            End If
        Next

        If strQuery <> "" Then
            objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_ID_Object, strQuery)), BooleanClause.Occur.MUST)
        End If


        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ObjectRel, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList
                If Not objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Other) = Nothing Then
                    objOntologyList_ObjectRel.Add(New clsObjectRel(objHit.Source(objLocalConfig.Globals.Field_ID_Object).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Object).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Other).ToString, _
                                                                Nothing, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Ontology).ToString, _
                                                                objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                                objHit.Source(objLocalConfig.Globals.Field_OrderID).ToString))
                Else
                    objOntologyList_ObjectRel.Add(New clsObjectRel(objHit.Source(objLocalConfig.Globals.Field_ID_Object).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Object).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Other).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Other).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Ontology).ToString, _
                                                                objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                                objHit.Source(objLocalConfig.Globals.Field_OrderID).ToString))
                End If
                

            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While

        Dim objLRelType = From obj In objOntologyList_ObjectRel _
                                  Group By obj.ID_RelationType Into Group
                                  Select ID_RelationType, objLocalConfig.Globals.Type_RelationType
        For Each objRelType In objLRelType
            objOList_RelationType.Add(New clsOntologyItem(objRelType.ID_RelationType, objRelType.Type_RelationType))
        Next


        objDBLevel_RelationType.get_Data_RelationTypes(objOList_RelationType)



        Dim objLQuery_IDOther = From obj As clsObjectRel In objOntologyList_ObjectRel _
                                Group By obj.ID_Object, _
                                            obj.ID_Other, _
                                            obj.ID_Parent_Other, _
                                            obj.ID_Direction, _
                                            obj.Ontology _
                                Into Group _
                                Select ID_Object, _
                                        ID_Other, _
                                        Ontology, _
                                        ID_Parent_Other, _
                                        ID_Direction

        For Each objORelItem In objLQuery_IDOther
            Select Case objORelItem.Ontology
                Case objLocalConfig.Globals.Type_Object
                    objOList_Object.Add(New clsOntologyItem(objORelItem.ID_Other, Nothing, objORelItem.Ontology))
                Case objLocalConfig.Globals.Type_AttributeType
                    objOList_AttributeType.Add(New clsOntologyItem(objORelItem.ID_Other, Nothing, objORelItem.Ontology))
                Case objLocalConfig.Globals.Type_Class
                    objOList_Class.Add(New clsOntologyItem(objORelItem.ID_Other, Nothing, objORelItem.Ontology))
                Case objLocalConfig.Globals.Type_RelationType
                    objOList_RelationType.Add(New clsOntologyItem(objORelItem.ID_Other, Nothing, objORelItem.Ontology))

            End Select
        Next



        If objOList_AttributeType.Count > 0 Then
            objDBLevel_DataTypes.get_Data_DataTyps()
            objDBLevel_AttributeTypes.get_Data_AttributeType(objOList_AttributeType, False)
            Dim objLArel = From obj As clsOntologyItem In objDBLevel_AttributeTypes.objOntologyList_AttributTypes
                           Join objObjRel As clsObjectRel In objOntologyList_ObjectRel On obj.GUID Equals objObjRel.ID_Other _
                           Join objRelType As clsOntologyItem In objDBLevel_RelationType.objOntologyList_RelationTypes On objRelType.GUID Equals objObjRel.ID_RelationType
                           Join objAttTypes In objDBLevel_DataTypes.objOntologyList_DataTypes On obj.GUID_Parent Equals objAttTypes.GUID
                                               Select ID_Object = objObjRel.ID_Object, _
                                                      Name_Object = objObjRel.Name_Object, _
                                                      ID_Other = obj.GUID, _
                                                      Name_Other = obj.Name, _
                                                      ID_Parent_Other = obj.GUID_Parent, _
                                                      Name_Parent_Other = objAttTypes.Name, _
                                                      Ontology = objLocalConfig.Globals.Type_Object, _
                                                      ID_relationType = objRelType.GUID, _
                                                      Name_RelationType = objRelType.Name, _
                                                      OrderID = objObjRel.OrderID

            For Each objArel In objLArel
                If boolTable = True Then
                    objOntologyList_ObjectRel.Add(New clsObjectRel(objArel.ID_Object, _
                                                               objArel.Name_Object, _
                                                               Nothing, _
                                                               Nothing, _
                                                               objArel.ID_Other, _
                                                               objArel.Name_Other, _
                                                               objArel.ID_Parent_Other, _
                                                               objArel.Name_Parent_Other, _
                                                               objArel.ID_relationType, _
                                                               objArel.Name_RelationType, _
                                                               objArel.Ontology, _
                                                               objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                               objLocalConfig.Globals.Direction_LeftRight.Name, _
                                                               objArel.OrderID))
                Else
                    otblT_ObjectRel.Rows.Add(objArel.ID_Object, _
                                             objArel.Name_Object, _
                                             Nothing, _
                                             Nothing, _
                                             objArel.ID_relationType, _
                                             objArel.Name_RelationType, _
                                             objArel.OrderID, _
                                             objArel.ID_Other, _
                                             objArel.Name_Other, _
                                             objArel.ID_Parent_Other, _
                                             objArel.Name_Parent_Other, _
                                             objArel.Ontology, _
                                             objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                             objLocalConfig.Globals.Direction_LeftRight.Name)


                End If




            Next
        End If

        If objOList_Class.Count > 0 Then
            objDBLevel_Classes.get_Data_Classes(objOList_Class, False)
            Dim objLCRel = From obj As clsOntologyItem In objDBLevel_Classes.objOntologyList_Classes
                           Join objObjRel As clsObjectRel In objOntologyList_ObjectRel On obj.GUID Equals objObjRel.ID_Other _
                           Join objRelType As clsOntologyItem In objDBLevel_RelationType.objOntologyList_RelationTypes On objRelType.GUID Equals objObjRel.ID_RelationType
                           Join objClassPar In objDBLevel_Classes.objOntologyList_Classes On obj.GUID_Parent Equals objClassPar.GUID
                                               Select ID_Object = objObjRel.ID_Object, _
                                                      Name_Object = objObjRel.Name_Object, _
                                                      ID_Other = obj.GUID, _
                                                      Name_Other = obj.Name, _
                                                      ID_Parent_Other = obj.GUID_Parent, _
                                                      Name_Parent_Other = objClassPar.Name, _
                                                      Ontology = objLocalConfig.Globals.Type_Object, _
                                                      ID_relationType = objRelType.GUID, _
                                                      Name_RelationType = objRelType.Name, _
                                                      OrderID = objObjRel.OrderID

            For Each objCRel In objLCRel
                If boolTable = True Then
                    objOntologyList_ObjectRel.Add(New clsObjectRel(objCRel.ID_Object, _
                                                               objCRel.Name_Object, _
                                                               Nothing, _
                                                               Nothing, _
                                                               objCRel.ID_Other, _
                                                               objCRel.Name_Other, _
                                                               objCRel.ID_Parent_Other, _
                                                               objCRel.Name_Parent_Other, _
                                                               objCRel.ID_relationType, _
                                                               objCRel.Name_RelationType, _
                                                               objCRel.Ontology, _
                                                               objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                               objLocalConfig.Globals.Direction_LeftRight.Name, _
                                                               objCRel.OrderID))
                Else
                    otblT_ObjectRel.Rows.Add(objCRel.ID_Object, _
                                             objCRel.Name_Object, _
                                             Nothing, _
                                             Nothing, _
                                             objCRel.ID_relationType, _
                                             objCRel.Name_RelationType, _
                                             objCRel.OrderID, _
                                             objCRel.ID_Other, _
                                             objCRel.Name_Other, _
                                             objCRel.ID_Parent_Other, _
                                             objCRel.Name_Parent_Other, _
                                             objCRel.Ontology, _
                                             objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                             objLocalConfig.Globals.Direction_LeftRight.Name)


                End If
            Next
        End If

        If objOList_Object.Count > 0 Then
            objDBLevel_Objects.get_Data_Objects(objOList_Object)
            Dim objOL_ClassesRel = From obj In objDBLevel_Objects.objOntologyList_Objects Group By obj.GUID_Parent Into Group Select GUID_Parent

            For Each objClassRel In objOL_ClassesRel
                objOList_ClassesRel.Add(New clsOntologyItem(objClassRel, objLocalConfig.Globals.Type_Class))

            Next

            objDBLevel_Classes.get_Data_Classes(objOList_ClassesRel)

            Dim objLOrel = From obj As clsOntologyItem In objDBLevel_Objects.objOntologyList_Objects _
                           Join objObjRel As clsObjectRel In objOntologyList_ObjectRel On obj.GUID Equals objObjRel.ID_Other _
                           Join objRelType As clsOntologyItem In objDBLevel_RelationType.objOntologyList_RelationTypes On objRelType.GUID Equals objObjRel.ID_RelationType
                           Join objClass In objDBLevel_Classes.objOntologyList_Classes On obj.GUID_Parent Equals objClass.GUID
                                               Select ID_Object = objObjRel.ID_Object, _
                                                      Name_Object = objObjRel.Name_Object, _
                                                      ID_Other = obj.GUID, _
                                                      Name_Other = obj.Name, _
                                                      ID_Parent_Other = obj.GUID_Parent, _
                                                      Name_Parent_Other = objClass.Name, _
                                                      Ontology = objLocalConfig.Globals.Type_Object, _
                                                      ID_relationType = objRelType.GUID, _
                                                      Name_RelationType = objRelType.Name, _
                                                      OrderID = objObjRel.OrderID

            For Each objOrel In objLOrel
                If boolTable = True Then
                    objOntologyList_ObjectRel.Add(New clsObjectRel(objOrel.ID_Object, _
                                                               objOrel.Name_Object, _
                                                               Nothing, _
                                                               Nothing, _
                                                               objOrel.ID_Other, _
                                                               objOrel.Name_Other, _
                                                               objOrel.ID_Parent_Other, _
                                                               objOrel.Name_Parent_Other, _
                                                               objOrel.ID_relationType, _
                                                               objOrel.Name_RelationType, _
                                                               objOrel.Ontology, _
                                                               objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                               objLocalConfig.Globals.Direction_LeftRight.Name, _
                                                               objOrel.OrderID))
                Else
                    otblT_ObjectRel.Rows.Add(objOrel.ID_Object, _
                                             objOrel.Name_Object, _
                                             Nothing, _
                                             Nothing, _
                                             objOrel.ID_relationType, _
                                             objOrel.Name_RelationType, _
                                             objOrel.OrderID, _
                                             objOrel.ID_Other, _
                                             objOrel.Name_Other, _
                                             objOrel.ID_Parent_Other, _
                                             objOrel.Name_Parent_Other, _
                                             objOrel.Ontology, _
                                             objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                             objLocalConfig.Globals.Direction_LeftRight.Name)


                End If




            Next


        End If

        If objOList_RelationType.Count > 0 Then
            objDBLevel_RelationType.get_Data_RelationTypes(objOList_RelationType, False)

            Dim objLRRel = From obj As clsOntologyItem In objDBLevel_RelationType.objOntologyList_RelationTypes
                           Join objObjRel As clsObjectRel In objOntologyList_ObjectRel On obj.GUID Equals objObjRel.ID_Other _
                           Join objRelType As clsOntologyItem In objDBLevel_RelationType.objOntologyList_RelationTypes On objRelType.GUID Equals objObjRel.ID_RelationType
                                               Select ID_Object = objObjRel.ID_Object, _
                                                      Name_Object = objObjRel.Name_Object, _
                                                      ID_Other = obj.GUID, _
                                                      Name_Other = obj.Name, _
                                                      Ontology = objLocalConfig.Globals.Type_Object, _
                                                      ID_relationType = objRelType.GUID, _
                                                      Name_RelationType = objRelType.Name, _
                                                      OrderID = objObjRel.OrderID

            For Each objRRel In objLRRel
                If boolTable = True Then
                    objOntologyList_ObjectRel.Add(New clsObjectRel(objRRel.ID_Object, _
                                                               objRRel.Name_Object, _
                                                               Nothing, _
                                                               Nothing, _
                                                               objRRel.ID_Other, _
                                                               objRRel.Name_Other, _
                                                               Nothing, _
                                                               Nothing, _
                                                               objRRel.ID_relationType, _
                                                               objRRel.Name_RelationType, _
                                                               objRRel.Ontology, _
                                                               objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                               objLocalConfig.Globals.Direction_LeftRight.Name, _
                                                               objRRel.OrderID))
                Else
                    otblT_ObjectRel.Rows.Add(objRRel.ID_Object, _
                                             objRRel.Name_Object, _
                                             Nothing, _
                                             Nothing, _
                                             objRRel.ID_relationType, _
                                             objRRel.Name_RelationType, _
                                             objRRel.OrderID, _
                                             objRRel.ID_Other, _
                                             objRRel.Name_Other, _
                                             Nothing, _
                                             Nothing, _
                                             objRRel.Ontology, _
                                             objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                             objLocalConfig.Globals.Direction_LeftRight.Name)


                End If
            Next
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
        If OList_Objects Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
        Else

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
        Dim strQuery_ID As String
        Dim strQuery_Name As String
        Dim strQuery_IDParent As String

        otblT_Objects.Clear()
        objOntologyList_Objects.Clear()


        objOItem_Result = objLocalConfig.Globals.LState_Success
        intCount = 0
        If oList_Objects Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
        Else
            Dim strLQuery_LID = From obj As clsOntologyItem In oList_Objects Where obj.Type = objLocalConfig.Globals.Type_Object Group By obj.GUID Into Group Select GUID = GUID
            Dim strLQuery_LName = From obj As clsOntologyItem In oList_Objects Where obj.Type = objLocalConfig.Globals.Type_Object Group By obj.Name Into Group Select Name = Name
            Dim strLQuery_LIDParent = From obj As clsOntologyItem In oList_Objects Where obj.Type = objLocalConfig.Globals.Type_Object Group By obj.GUID_Parent Into Group Select GUID_Parent = GUID_Parent
            Dim strLQuery_LIDCParent = From obj As clsOntologyItem In oList_Objects Where obj.Type = objLocalConfig.Globals.Type_Class Group By obj.GUID Into Group Select GUID_Parent = GUID

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

            strQuery = ""
            For Each strQuery_IDParent In strLQuery_LIDParent
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If
                strQuery = strQuery & strQuery_IDParent
            Next
            If strQuery <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Class, strQuery)), BooleanClause.Occur.MUST)
            End If

            strQuery = ""
            For Each strQuery_IDParent In strLQuery_LIDCParent
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If
                strQuery = strQuery & strQuery_IDParent
            Next
            If strQuery <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Class, strQuery)), BooleanClause.Occur.MUST)
            End If

            strLQuery_LID = Nothing
            strLQuery_LIDParent = Nothing
            strLQuery_LName = Nothing
        End If



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
        Dim objOItem_Result As clsOntologyItem
        Dim strQuery_ID As String
        Dim strQuery_Name As String
        Dim strQuery_IDParent As String
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer

        objOntologyList_Classes.Clear()
        tbl_Classes.Clear()

        objOItem_Result = objLocalConfig.Globals.LState_Success
        intCount = 0
        If OList_Classes Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
        Else

            Dim strLQuery_ID = From cl As clsOntologyItem In OList_Classes Group By cl.GUID Into Group Select GUID
            Dim strLQuery_Name = From cl As clsOntologyItem In OList_Classes Group By cl.Name Into Group Select Name
            Dim strLQuery_IDParent = From cl As clsOntologyItem In OList_Classes Group By cl.GUID_Parent Into Group Select GUID_Parent

            strQuery = ""
            For Each strQuery_ID In strLQuery_ID
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If
                If strQuery_ID <> "" Then
                    strQuery = strQuery & strQuery_ID
                End If

            Next
            If strQuery <> "" Then

                objBoolQuery.Add(New TermQuery(New Term("ID_Item", strQuery)), BooleanClause.Occur.MUST)
            End If

            strQuery = ""
            For Each strQuery_Name In strLQuery_Name
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If
                If strQuery_Name <> "" Then
                    strQuery = strQuery & """*" & strQuery_Name & "*"""
                End If

            Next
            If strQuery <> "" Then
                objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_Name_Item, strQuery)), BooleanClause.Occur.MUST)
            End If

            strQuery = ""
            For Each strQuery_IDParent In strLQuery_IDParent
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If
                If strQuery_IDParent <> "" Then
                    strQuery = strQuery & strQuery_IDParent
                End If

            Next
            If strQuery <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Parent, strQuery)), BooleanClause.Occur.MUST)
            End If
        End If


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
