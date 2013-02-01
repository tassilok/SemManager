Imports ElasticSearch
Imports Lucene.Net.Search
Imports Lucene.Net.Index

Public Class clsDBLevel
    Private objElConn As ElasticSearch.Client.ElasticSearchClient
    Private objOntologyList_Objects As New List(Of clsOntologyItem)
    Private objOntologyList_ObjectRel As New List(Of clsObjectRel)
    Private objOntologyList_Classes As New List(Of clsOntologyItem)
    Private objOntologyList_RelationTypes As New List(Of clsOntologyItem)
    Private objOntologyList_AttributTypes As New List(Of clsOntologyItem)
    Private objOntologyList_ClassRel As New List(Of clsClassRel)

    Private otblT_Objects As New DataSet_Config.otbl_ObjectsDataTable
    Private otblT_Classes As New DataSet_Config.otbl_ClassesDataTable
    Private otblT_RelationTypes As New DataSet_Config.otbl_RelationTypesDataTable
    Private otblT_AttributeTypes As New DataSet_Config.otbl_AttributesDataTable
    Private otblT_ObjectRel As New DataSet_Config.otbl_ObjectRelDataTable

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

    Public ReadOnly Property OList_AttributeTypes As List(Of clsOntologyItem)
        Get
            Return objOntologyList_AttributTypes
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

    Public ReadOnly Property tbl_AttributeTypes As DataSet_Config.otbl_AttributesDataTable
        Get
            Return otblT_AttributeTypes
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

        intCount = 0
        objOItem_Result = objLocalConfig.Globals.LState_Success
        If OList_RelType Is Nothing Then
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
                        strQuery = strQuery & "*" & strQuery_Name & "*"
                    End If

                Next
                If strQuery <> "" Then

                    objBoolQuery.Add(New WildcardQuery(New Term(objLocalConfig.Globals.Field_Name_Item, strQuery)), BooleanClause.Occur.MUST)
                End If
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
                        strQuery = strQuery & "*" & strQuery_Name & "*"
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
                    strQuery = strQuery & strQuery_IDParent
                Next

                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_Name_Item, strQuery)), BooleanClause.Occur.MUST)
                End If
            End If
            
            
        End If

        otblT_AttributeTypes.Clear()
        objOntologyList_AttributTypes.Clear()

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
                    otblT_AttributeTypes.Rows.Add(New Guid(objHit.Id.ToString), _
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

        objOntologyList_ClassRel.Clear()

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

                objOntologyList_ClassRel.Add(New clsClassRel(objHit.Source(objLocalConfig.Globals.Field_ID_Class_Left).ToString, _
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

        oList_Classes.Clear()
        oList_Rels.Clear()

        If Direction.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
            strLGUID_Class = From objClRel In objOntologyList_ClassRel Group By objClRel.ID_Class_Right Into Group Select ID_Class_Right
            For Each strGUID In strLGUID_Class
                oList_Classes.Add(New clsOntologyItem(strGUID, Nothing, objLocalConfig.Globals.Type_Class))
            Next
        Else
            strLGUID_Class = From objClRel In objOntologyList_ClassRel Group By objClRel.ID_Class_Left Into Group Select ID_Class_Left
            For Each strGUID In strLGUID_Class
                oList_Classes.Add(New clsOntologyItem(strGUID, Nothing, objLocalConfig.Globals.Type_Class))
            Next
        End If

        get_Data_Classes(oList_Classes, boolTable)

        strLGUID_Rel = From objClRel In objOntologyList_ClassRel Group By objClRel.ID_RelationType Into Group Select ID_RelationType
        For Each strGUID In strLGUID_Rel
            oList_Rels.Add(New clsOntologyItem(strGUID, Nothing, objLocalConfig.Globals.Type_RelationType))
        Next

        get_Data_RelationTypes(oList_Rels, boolTable)

        Return objOItem_Result
    End Function

    'Public Function get_Data_ObjectRel(Optional ByVal oList_Left As List(Of clsOntologyItem) = Nothing, Optional ByVal oList_Right As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
    '    Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
    '    Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
    '    Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
    '    Dim objOItem_Object As clsOntologyItem
    '    Dim objHit As ElasticSearch.Client.Domain.Hits
    '    Dim strQuery As String = ""
    '    Dim intCount As Integer
    '    Dim intPos As Integer
    '    Dim objFieldQuery_ID As New clsFieldQuery
    '    Dim objFieldQuery_Class As New clsFieldQuery
    '    Dim objOItem_Result As clsOntologyItem
    '    Dim objOItem_ObjectRel As clsObjectRel

    '    Dim oList_Items_Left As New List(Of clsOntologyItem)
    '    Dim oList_Items_Right As New List(Of clsOntologyItem)
    '    Dim oList_Class_Left As New List(Of clsOntologyItem)
    '    Dim oList_Class_Right As New List(Of clsOntologyItem)
    '    Dim oList_RelationType As New List(Of clsOntologyItem)

    '    Dim oList_ObjectRel As New List(Of clsObjectRel)

    '    Dim objDBLevel_Left As New clsDBLevel(objLocalConfig)
    '    Dim objDBLevel_Right As New clsDBLevel(objLocalConfig)
    '    Dim objDBLevel_Class_Left As New clsDBLevel(objLocalConfig)
    '    Dim objDBLevel_Class_Right As New clsDBLevel(objLocalConfig)
    '    Dim objDBLevel_RelationType As New clsDBLevel(objLocalConfig)



    '    intCount = 0
    '    objOItem_Result = objDBLevel_Left.get_Data_Objects(oList_Left)
    '    If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then

    '        objOItem_Result = objDBLevel_Right.get_Data_Objects(oList_Right)
    '        If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
    '            oList_Items_Left = objDBLevel_Left.OList_Objects

    '            Dim strLQuery_LID = From obj As clsOntologyItem In OList_Objects Group By obj.GUID Into Group Select GUID = GUID

    '            From at As clsOntologyItem In OList_AttType Group By at.GUID Select (strQuery_ID = strQuery_ID + GUID & "\ OR\ ")

    '            For Each objOItem In oList_Items_Left
    '                If Not objOItem.GUID = "" Then
    '                    If objFieldQuery_ID.Field = "" Then
    '                        objFieldQuery_ID.Field = "ID_Left"
    '                    End If

    '                    If objFieldQuery_ID.Query <> "" Then
    '                        objFieldQuery_ID.Query = objFieldQuery_ID.Query & "\ OR\ "
    '                    End If

    '                    objFieldQuery_ID.Query = objFieldQuery_ID.Query & objOItem.GUID
    '                End If

    '                If Not objOItem.GUID_Parent = "" Then
    '                    If objFieldQuery_Class.Field = "" Then
    '                        objFieldQuery_Class.Field = objLocalConfig.Globals.Field_ID_Parent_Left
    '                    End If

    '                    If objFieldQuery_Class.Query <> "" Then
    '                        objFieldQuery_Class.Query = objFieldQuery_Class.Query & "\ OR\ "
    '                    End If
    '                    oList_Class_Left.Add(New clsOntologyItem(objOItem.GUID_Parent, Nothing, Nothing))
    '                    objFieldQuery_Class.Query = objFieldQuery_Class.Query & objOItem.GUID_Parent
    '                End If
    '                If Not objOItem.GUID_Relation = "" Then
    '                    oList_RelationType.Add(New clsOntologyItem(objOItem.GUID_Relation, Nothing, Nothing))
    '                End If

    '            Next
    '            If Not oList_RelationType.Count = 0 Then
    '                objDBLevel_RelationType.get_Data_RelationTypes(oList_RelationType)
    '            Else
    '                objDBLevel_RelationType.get_Data_RelationTypes()
    '            End If

    '            objDBLevel_Class_Left.get_Data_Classes(oList_Class_Left)
    '            oList_Class_Left = objDBLevel_Class_Left.OList_Classes
    '            oList_RelationType = objDBLevel_RelationType.OList_RelationTypes

    '            If objFieldQuery_ID.Field <> "" Then
    '                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_ID.Field, objFieldQuery_ID.Query)), BooleanClause.Occur.MUST)
    '            End If

    '            If objFieldQuery_Class.Field <> "" Then
    '                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_Class.Field, objFieldQuery_Class.Query)), BooleanClause.Occur.MUST)
    '            End If

    '            For Each objOItem In oList_Items_Right
    '                If Not objOItem.GUID = "" Then
    '                    If objFieldQuery_ID.Field = "" Then
    '                        objFieldQuery_ID.Field = "ID_Right"
    '                    End If

    '                    If objFieldQuery_ID.Query <> "" Then
    '                        objFieldQuery_ID.Query = objFieldQuery_ID.Query & "\ OR\ "
    '                    End If

    '                    objFieldQuery_ID.Query = objFieldQuery_ID.Query & objOItem.GUID
    '                End If

    '                If Not objOItem.GUID_Parent = "" Then
    '                    If objFieldQuery_Class.Field = "" Then
    '                        objFieldQuery_Class.Field = objLocalConfig.Globals.Field_ID_Parent_Right
    '                    End If

    '                    If objFieldQuery_Class.Query <> "" Then
    '                        objFieldQuery_Class.Query = objFieldQuery_Class.Query & "\ OR\ "
    '                    End If
    '                    oList_Class_Right.Add(New clsOntologyItem(objOItem.GUID_Parent, Nothing, Nothing))
    '                    objFieldQuery_Class.Query = objFieldQuery_Class.Query & objOItem.GUID_Parent
    '                End If

    '            Next

    '            objDBLevel_Class_Right.get_Data_Classes(oList_Class_Right)
    '            oList_Class_Right = objDBLevel_Class_Right.OList_Classes

    '            If objFieldQuery_ID.Field <> "" Then
    '                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_ID.Field, objFieldQuery_ID.Query)), BooleanClause.Occur.MUST)
    '            End If

    '            If objFieldQuery_Class.Field <> "" Then
    '                objBoolQuery.Add(New TermQuery(New Term(objFieldQuery_Class.Field, objFieldQuery_Class.Query)), BooleanClause.Occur.MUST)
    '            End If
    '        End If
    '    End If

    '    otblT_Objects.Clear()
    '    objOntologyList_Objects.Clear()

    '    intCount = objLocalConfig.Globals.SearchRange
    '    intPos = 0
    '    While intCount > 0

    '        intCount = 0
    '        objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Object, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
    '        objList = objSearchResult.GetHits.Hits

    '        'Dim a = From obja In objList
    '        'Where (Not obja.Source("@fields")("ex_cid") Is Nothing)
    '        '       Group obja By key = obja.Source("@fields")("ex_cid").First.ToString Into Count() Select key, count = Count

    '        'For Each b In a
    '        '    CidA_Count.Insert(Integer.Parse(b.key), b.count)
    '        'Next
    '        For Each objHit In objList

    '            oList_ObjectRel.Add(New clsObjectRel(objHit.Source(objLocalConfig.Globals.Field_ID_Object), _
    '                                                           objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Left), _
    '                                                           objHit.Source(objLocalConfig.Globals.Field_ID_Right), _
    '                                                           objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Right), _
    '                                                           objHit.Source(objLocalConfig.Globals.Field_ID_RelationType), _
    '                                                           objHit.Source(objLocalConfig.Globals.Field_ID_Ontology), _
    '                                                           objHit.Source(objLocalConfig.Globals.Field_OrderID)))




    '        Next

    '        objOntologyList_ObjectRel.Add(From l In oList_Items_Left _
    '                       Join l_r In oList_ObjectRel On l.GUID Equals l_r.ID_Object
    '                       Join r In oList_Items_Right On l_r.ID_Other Equals r.GUID _
    '                       Join cl_l In oList_Class_Left On l.GUID_Parent Equals cl_l.GUID _
    '                       Join cl_r In oList_Class_Right On r.GUID_Parent Equals cl_r.GUID _
    '                       Join rel In oList_RelationType On l_r.ID_RelationType Equals rel.GUID _
    '                       Select New clsObjectRel(l.GUID, l.Name, _
    '                              cl_l.GUID, cl_l.Name, _
    '                              r.GUID, r.Name, _
    '                              cl_r.GUID, cl_r.Name, _
    '                              l_r.ID_RelationType, rel.Name, _
    '                              l_r.ID_Ontology, l_r.OrderID))


    '        intCount = objList.Count

    '        objList.Clear()
    '        objSearchResult = Nothing
    '        objList = Nothing
    '        intPos = intPos + intCount
    '    End While

    '    If boolTable = True Then
    '        For Each objOItem_ObjectRel In objOntologyList_ObjectRel
    '            otblT_ObjectRel.Rows.Add(objOItem_ObjectRel.ID_Object, objOItem_ObjectRel.Name_Object, _
    '                                     objOItem_ObjectRel.ID_Parent_Object, objOItem_ObjectRel.Name_Parent_Object, _
    '                                     objOItem_ObjectRel.ID_RelationType, objOItem_ObjectRel.Name_RelationType, _
    '                                     objOItem_ObjectRel.OrderID, objOItem_ObjectRel.ID_Ontology, _
    '                                     objOItem_ObjectRel.ID_Other, objOItem_ObjectRel.Name_Other, _
    '                                     objOItem_ObjectRel.ID_Parent_Right, objOItem_ObjectRel.Name_Parent_Right)



    '        Next


    '    End If

    'End Function

    Private Sub set_RelItem(ByVal ID_Object As String, _
                            ByVal Name_Object As String, _
                            ByVal ID_Parent_Left As String, _
                            ByVal Name_Parent_Left As String, _
                            ByVal ID_Other As String, _
                            ByVal Name_Other As String, _
                            ByVal ID_Parent_Right As String, _
                            ByVal Name_Parent_Right As String, _
                            ByVal ID_RelationType As String, _
                            ByVal Name_RelationType As String, _
                            ByVal ID_Ontology As String, _
                            ByVal boolTable As Boolean)

    End Sub

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


        objOItem_Result = objLocalConfig.Globals.LState_Success
        intCount = 0
        If oList_Objects Is Nothing Then
            objBoolQuery.Add(New TermQuery(New Term("ID_Item", "*")), BooleanClause.Occur.MUST)
        Else

            Dim strLQuery_LID = From obj As clsOntologyItem In oList_Objects Group By obj.GUID Into Group Select GUID = GUID
            Dim strLQuery_LName = From obj As clsOntologyItem In oList_Objects Group By obj.Name Into Group Select Name = Name
            Dim strLQuery_LIDParent = From obj As clsOntologyItem In oList_Objects Group By obj.GUID_Parent Into Group Select GUID_Parent = GUID_Parent

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
                    strQuery = strQuery & "*" & strQuery_Name & "*"
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

        Return objOItem_Result
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
        Dim objOItem_Result As clsOntologyItem
        Dim objFieldQuery_ID As New clsFieldQuery
        Dim objFieldQuery_Name As New clsFieldQuery
        Dim objFieldQuery_ID_Parent As New clsFieldQuery
        Dim strQuery_ID As String
        Dim strQuery_Name As String
        Dim strQuery_IDParent As String
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer


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
                    strQuery = strQuery & "*" & strQuery_Name & "*"
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
                strQuery = strQuery & strQuery_IDParent
            Next
            If strQuery <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Parent, strQuery)), BooleanClause.Occur.MUST)
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
