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
    Private objOntologyList_ClassRel_ID As New List(Of clsClassRel)
    Private objOntologyList_ClassRel_Named As New List(Of clsClassRel)
    Private objOntologyList_ObjRel_ID As New List(Of clsObjectRel)
    Private objOntologyList_ObjRel_Named As New List(Of clsObjectRel)
    Private objOntologyList_DataTypes As New List(Of clsOntologyItem)

    Private otblT_Objects As New DataSet_Config.otbl_ObjectsDataTable
    Private otblT_Classes As New DataSet_Config.otbl_ClassesDataTable
    Private otblT_RelationTypes As New DataSet_Config.otbl_RelationTypesDataTable
    Private otblT_AttributeTypes As New DataSet_Config.otbl_AttributesDataTable
    Private otblT_ObjectRel As New DataSet_Config.otbl_ObjectRelDataTable
    Private otblT_DataTypes As New DataSet_Config.otbl_DataTypesDataTable

    Private oList_DBLevel As List(Of clsDBLevel)

    Private objConnection As SqlClient.SqlConnection
    Private createA_Table_orgT As New DataSet_ConfigTableAdapters.create_Table_orgTTableAdapter

    Private objLocalConfig As clsLocalConfig

    Public ReadOnly Property OList_ClassRel_ID As List(Of clsClassRel)
        Get
            Return objOntologyList_ClassRel_ID
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
                        strQuery = strQuery & """*" & strQuery_Name & "*"""
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

        oList_Classes.Clear()
        oList_Rels.Clear()

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

        get_Data_Classes(oList_Classes, boolTable)

        strLGUID_Rel = From objClRel In objOntologyList_ClassRel_ID Group By objClRel.ID_RelationType Into Group Select ID_RelationType
        For Each strGUID In strLGUID_Rel
            oList_Rels.Add(New clsOntologyItem(strGUID, Nothing, objLocalConfig.Globals.Type_RelationType))
        Next

        get_Data_RelationTypes(oList_Rels, boolTable)

        Return objOItem_Result
    End Function

    Public Function get_Data_ObjectRel(ByVal oList_Objects As List(Of clsOntologyItem), Optional ByVal boolTable As Boolean = False)

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
        Dim strQuery_ObjID As String
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer

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

        otblT_ObjectRel.Clear()
        objOntologyList_ObjectRel.Clear()

        intCount = objLocalConfig.Globals.SearchRange
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ObjectRel, objBoolQuery.ToString, intPos, objLocalConfig.Globals.SearchRange)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList

                objOntologyList_ObjectRel.Add(New clsObjectRel(objHit.Id.ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Other).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Other).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_Parent_Other).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_ID_RelationType).ToString, _
                                                                objHit.Source(objLocalConfig.Globals.Field_Ontology).ToString, _
                                                                objLocalConfig.Globals.Direction_LeftRight.GUID, _
                                                                objHit.Source(objLocalConfig.Globals.Field_OrderID).ToString))

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
            get_Data_AttributeType(objOList_AttributeType, False)
            objOList_DataTypes.Add(From obj In objOList_AttributeType Group By obj.GUID_Parent Into Group Select Guid = GUID_Parent)
            objDBLevel_DataTypes.get_Data_DataTyps()
            objOntologyList_ObjectRel.Add(From obj As clsOntologyItem In objOntologyList_AttributTypes _
                                          Join objObjRel As clsObjectRel In objOntologyList_ObjectRel On obj.GUID Equals objObjRel.ID_Other _
                                          Join objRelTyp As clsOntologyItem In objDBLevel_RelationType.objOntologyList_RelationTypes On objObjRel.ID_RelationType Equals objRelTyp.GUID _
                                          Join objDataType As clsOntologyItem In objDBLevel_DataTypes.objOntologyList_DataTypes On obj.GUID_Parent Equals objDataType.GUID _
                                               Select ID_Other = obj.GUID, _
                                                      Name_Other = obj.Name, _
                                                      ID_RelationType = objRelTyp.GUID, _
                                                      Name_RelationType = objRelTyp.Name, _
                                                      ID_Parent_Other = obj.GUID_Parent, _
                                                      Name_Parent_Other = objDataType.Name, _
                                                      Ontology = objLocalConfig.Globals.Type_AttributeType)
        End If

        If objOList_Class.Count > 0 Then
            get_Data_Classes(objOList_Class, False)

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
            get_Data_RelationTypes(objOList_RelationType, False)
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

        otblT_Objects.Clear()
        objOntologyList_Objects.Clear()

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
