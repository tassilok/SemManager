Imports ElasticSearch
Imports Lucene.Net.Search
Imports Lucene.Net.Index

Public Class clsDBLevel
    Private objElConn As ElasticSearch.Client.ElasticSearchClient
    Private objOntologyList_Objects As New List(Of clsOntologyItem)
    Private objOntologyList_ObjectRel_ID As New List(Of clsObjectRel)
    Private objOntologyList_ObjectRel As New List(Of clsObjectRel)
    Private objOntologyList_ObjectTree As New List(Of clsObjectTree)
    Private objOntologyList_Classes1 As New List(Of clsOntologyItem)
    Private objOntologyList_Classes2 As New List(Of clsOntologyItem)
    Private objOntologyList_RelationTypes As New List(Of clsOntologyItem)
    Private objOntologyList_AttributTypes As New List(Of clsOntologyItem)
    Private objOntologyList_ClassRel_ID As New List(Of clsClassRel)
    Private objOntologyList_ClassRel As New List(Of clsClassRel)
    Private objOntologyList_ClassAtt_ID As New List(Of clsClassAtt)
    Private objOntologyList_ObjAtt_ID As New List(Of clsObjectAtt)
    Private objOntologyList_ObjAtt As New List(Of clsObjectAtt)
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

    Private objBoolQuery As New Lucene.Net.Search.BooleanQuery

    Private objLocalConfig As clsLocalConfig

    Private intPackageLength As Integer

    Public Property PackageLength As Integer
        Get
            Return intPackageLength
        End Get
        Set(ByVal value As Integer)
            intPackageLength = value
        End Set
    End Property

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

    Public ReadOnly Property OList_ClassRel As List(Of clsClassRel)
        Get
            Return objOntologyList_ClassRel
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

    Public ReadOnly Property OList_ObjectRel As List(Of clsObjectRel)
        Get
            Return objOntologyList_ObjectRel
        End Get
    End Property

    Public ReadOnly Property OList_ObjectAtt_ID As List(Of clsObjectAtt)
        Get
            Return objOntologyList_ObjAtt_ID
        End Get
    End Property

    Public ReadOnly Property OList_ObjectAtt As List(Of clsObjectAtt)
        Get
            Return objOntologyList_ObjAtt
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

    Public Function save_AttributeType(ByVal oItem_AttributeType As clsOntologyItem) As clsOntologyItem
        Dim objOItem_Result As clsOntologyItem
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects(0) As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult
        Dim oList_AttTypes As New List(Of clsOntologyItem)
        Dim oList_AttTypeTests As New List(Of clsOntologyItem)

        oList_AttTypes.Add(oItem_AttributeType)


        oList_AttTypeTests.Add(New clsOntologyItem(Nothing, oItem_AttributeType.Name, objLocalConfig.Globals.Type_AttributeType))

        get_Data_AttributeType(oList_AttTypeTests, False)

        Dim objL = From obj1 In objOntologyList_AttributTypes
                   Join obj2 In oList_AttTypes On obj1.Name.ToLower Equals obj2.Name.ToLower

        If objL.Count = 0 Then
            objOItem_Result = objLocalConfig.Globals.LState_Success
        Else
            If oItem_AttributeType.GUID = objOntologyList_AttributTypes(0).GUID Then
                objOItem_Result = objLocalConfig.Globals.LState_Success
            Else
                objOItem_Result = objLocalConfig.Globals.LState_Exists
            End If

        End If

        If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
            oList_AttTypeTests.Clear()

            oList_AttTypeTests.Add(New clsOntologyItem(oItem_AttributeType.GUID, objLocalConfig.Globals.Type_AttributeType))

            get_Data_AttributeType(oList_AttTypeTests)

            If objOntologyList_AttributTypes.Count > 0 Then
                If objOntologyList_AttributTypes(0).GUID_Parent <> oItem_AttributeType.GUID_Parent Then
                    get_Data_Attributes(Nothing, _
                                        oList_AttTypeTests, _
                                        Nothing)

                    If objOntologyList_Attributes.Count > 0 Then
                        objOItem_Result = objLocalConfig.Globals.LState_Relation
                    Else
                        objOItem_Result = objLocalConfig.Globals.LState_Success
                    End If
                Else
                    If objOntologyList_AttributTypes(0).Name <> oItem_AttributeType.Name Then
                        objOItem_Result = objLocalConfig.Globals.LState_Success
                    End If
                End If

            End If

            If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                objDict = New Dictionary(Of String, Object)
                objDict.Add(objLocalConfig.Globals.Field_ID_Item, oItem_AttributeType.GUID)
                objDict.Add(objLocalConfig.Globals.Field_Name_Item, oItem_AttributeType.Name)
                If oItem_AttributeType.GUID_Parent <> "" Then
                    objDict.Add(objLocalConfig.Globals.Field_ID_DataType, oItem_AttributeType.GUID_Parent)
                Else
                    oItem_AttributeType.GUID_Parent = objLocalConfig.Globals.DType_String.GUID
                    objDict.Add(objLocalConfig.Globals.Field_ID_DataType, oItem_AttributeType.GUID_Parent)
                End If


                objBulkObjects(0) = New ElasticSearch.Client.Domain.BulkObject(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_AttributeType, oItem_AttributeType.GUID, objDict)

                Try
                    objOPResult = objElConn.Bulk(objBulkObjects)
                    objBulkObjects = Nothing
                    objOItem_Result = objLocalConfig.Globals.LState_Success
                Catch ex As Exception
                    objOItem_Result = objLocalConfig.Globals.LState_Error
                End Try
            End If

        End If


        Return objOItem_Result
    End Function

    Public Function del_Objects(ByVal List_Objects As List(Of clsOntologyItem)) As String()
        Dim objDBLevel_LeftRight As clsDBLevel
        Dim objDBLeveL_RightLeft As clsDBLevel
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult
        Dim objOItem_Result As clsOntologyItem
        Dim i As Integer
        Dim strAIDs() As String = Nothing

        objElConn.Flush()
        objDBLevel_LeftRight = New clsDBLevel(objLocalConfig)
        objDBLeveL_RightLeft = New clsDBLevel(objLocalConfig)

        objDBLevel_LeftRight.get_Data_ObjectRel(List_Objects, Nothing, Nothing)

        Dim objLeftRight = From objDel In List_Objects
                           Group Join objRel In objDBLevel_LeftRight.OList_ObjectRel_ID On objDel.GUID Equals objRel.ID_Object Into RightTableResult = Group
                           From objRel In RightTableResult.DefaultIfEmpty
                           Where objRel Is Nothing




        objDBLeveL_RightLeft.get_Data_ObjectRel(Nothing, List_Objects, Nothing)

        Dim objRightLeft = From objDel In List_Objects
                          Group Join objRel In objDBLeveL_RightLeft.OList_ObjectRel_ID On objDel.GUID Equals objRel.ID_Other Into RightTableResult = Group
                          From objRel In RightTableResult.DefaultIfEmpty
                          Where objRel Is Nothing



        Dim objLDelable = From objDel In List_Objects
                         Join objRelLeftRight In objLeftRight On objDel.GUID Equals objRelLeftRight.objDel.GUID
                         Join objRelRightLeft In objRightLeft On objDel.GUID Equals objRelRightLeft.objDel.GUID


        For i = 0 To objLDelable.Count - 1
            ReDim Preserve strAIDs(i)
            strAIDs(i) = objLDelable(i).objDel.GUID

        Next

        objOItem_Result = objLocalConfig.Globals.LState_Success
        If Not strAIDs Is Nothing Then
            If strAIDs.Count > 0 Then
                Try
                    objOPResult = objElConn.Delete(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Object, strAIDs)
                    objOItem_Result = objLocalConfig.Globals.LState_Success
                Catch ex As Exception
                    objOItem_Result = objLocalConfig.Globals.LState_Error
                End Try
            End If
        End If


        If Not objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
            strAIDs = Nothing
        End If

        Return strAIDs
    End Function

    
    Public Function del_ObjectRel(ByVal oList_Items As List(Of clsOntologyItem)) As clsOntologyItem
        Dim objItem As clsOntologyItem
        Dim objOItem_Result As clsOntologyItem
        Dim strAObjectKeys() As String = Nothing

        Dim l As Long = 0
        Dim lngDone As Long = 0
        Dim lngToDo As Long
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult
        objElConn.Flush()
        objOItem_Result = objLocalConfig.Globals.LState_Nothing

        lngToDo = oList_Items.Count

        For Each objItem In oList_Items
            ReDim Preserve strAObjectKeys(l)
            strAObjectKeys(l) = objItem.GUID & objItem.GUID_Related & objItem.GUID_Relation
            l = l + 1
        Next

        If Not strAObjectKeys Is Nothing Then
            If strAObjectKeys.Count > 0 Then
                Try
                    objOPResult = objElConn.Delete(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ObjectRel, strAObjectKeys)
                    objOItem_Result = objLocalConfig.Globals.LState_Success
                Catch ex As Exception
                    objOItem_Result = objLocalConfig.Globals.LState_Error
                End Try
            End If
        End If
        
        Return (objOItem_Result)
    End Function
    Public Function save_RelationType(ByVal oItem_RelationType As clsOntologyItem) As clsOntologyItem
        Dim objOItem_Result As clsOntologyItem
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects(0) As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult
        Dim oList_RelTypes As New List(Of clsOntologyItem)
        Dim oList_RelTypeTests As New List(Of clsOntologyItem)

        oList_RelTypes.Add(oItem_RelationType)
        oList_RelTypeTests.Add(New clsOntologyItem(Nothing, oItem_RelationType.Name, objLocalConfig.Globals.Type_RelationType))

        get_Data_RelationTypes(oList_RelTypeTests, False)

        Dim objL = From obj1 In objOntologyList_RelationTypes
                   Join obj2 In oList_RelTypes On obj1.Name.ToLower Equals obj2.Name.ToLower

        If objL.Count = 0 Then
            objDict = New Dictionary(Of String, Object)
            objDict.Add(objLocalConfig.Globals.Field_ID_Item, oItem_RelationType.GUID)
            objDict.Add(objLocalConfig.Globals.Field_Name_Item, oItem_RelationType.Name)

            objBulkObjects(0) = New ElasticSearch.Client.Domain.BulkObject(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_RelationType, oItem_RelationType.GUID, objDict)

            Try
                objOPResult = objElConn.Bulk(objBulkObjects)
                objBulkObjects = Nothing
                objOItem_Result = objLocalConfig.Globals.LState_Success
            Catch ex As Exception
                objOItem_Result = objLocalConfig.Globals.LState_Error
            End Try
        Else
            If objOntologyList_RelationTypes(0).GUID = oItem_RelationType.GUID Then
                objOItem_Result = objLocalConfig.Globals.LState_Nothing
            Else
                objOItem_Result = objLocalConfig.Globals.LState_Exists
            End If

        End If

        Return objOItem_Result
    End Function
    Public Function save_Class(ByVal objOItem_Class As clsOntologyItem) As clsOntologyItem
        Dim objOItem_Result As clsOntologyItem
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects(0) As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult
        Dim oList_Classes As New List(Of clsOntologyItem)
        Dim oList_ClassesTest As New List(Of clsOntologyItem)

        oList_Classes.Add(objOItem_Class)
        oList_ClassesTest.Add(New clsOntologyItem(Nothing, objOItem_Class.Name, objLocalConfig.Globals.Type_Class))

        get_Data_Classes(oList_ClassesTest, False, False)

        Dim objL = From obj1 In objOntologyList_Classes1
                   Join obj2 In oList_Classes On obj1.Name.ToLower Equals obj2.Name.ToLower

        If objL.Count = 0 Then
            objDict = New Dictionary(Of String, Object)
            objDict.Add(objLocalConfig.Globals.Field_ID_Item, objOItem_Class.GUID)
            objDict.Add(objLocalConfig.Globals.Field_Name_Item, objOItem_Class.Name)
            objDict.Add(objLocalConfig.Globals.Field_ID_Parent, objOItem_Class.GUID_Parent)

            objBulkObjects(0) = New ElasticSearch.Client.Domain.BulkObject(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Class, objOItem_Class.GUID, objDict)

            Try
                objOPResult = objElConn.Bulk(objBulkObjects)
                objBulkObjects = Nothing
                objOItem_Result = objLocalConfig.Globals.LState_Success
            Catch ex As Exception
                objOItem_Result = objLocalConfig.Globals.LState_Error
            End Try
        Else
            objOItem_Result = objLocalConfig.Globals.LState_Exists
        End If

        Return objOItem_Result
    End Function

    Public Function save_ObjRel(ByVal objOItem_Object As clsOntologyItem, ByVal objOItem_Other As clsOntologyItem, ByVal objOItem_RelationType As clsOntologyItem, ByVal OrderID As Integer) As clsOntologyItem
        Dim objOItem_Result As clsOntologyItem
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects(0) As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult

        objDict = New Dictionary(Of String, Object)
        objDict.Add(objLocalConfig.Globals.Field_ID_Object, objOItem_Object.GUID)
        objDict.Add(objLocalConfig.Globals.Field_ID_Parent_Object, objOItem_Object.GUID_Parent)
        objDict.Add(objLocalConfig.Globals.Field_ID_Other, objOItem_Other.GUID)
        Select Case objOItem_Other.Type
            Case objLocalConfig.Globals.Type_AttributeType
                objDict.Add(objLocalConfig.Globals.Field_ID_Parent_Other, objOItem_Other.GUID_Parent)
            Case objLocalConfig.Globals.Type_Class
                objDict.Add(objLocalConfig.Globals.Field_ID_Parent_Other, objOItem_Other.GUID_Parent)
            Case objLocalConfig.Globals.Type_Object
                objDict.Add(objLocalConfig.Globals.Field_ID_Parent_Other, objOItem_Other.GUID_Parent)
        End Select
        objDict.Add(objLocalConfig.Globals.Field_ID_RelationType, objOItem_RelationType.GUID)
        objDict.Add(objLocalConfig.Globals.Field_OrderID, OrderID)
        objDict.Add(objLocalConfig.Globals.Field_Ontology, objOItem_Other.Type)

        objBulkObjects(0) = New ElasticSearch.Client.Domain.BulkObject(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ObjectRel, objOItem_Object.GUID & objOItem_Other.GUID & objOItem_RelationType.GUID, objDict)

        Try
            objOPResult = objElConn.Bulk(objBulkObjects)
            objBulkObjects = Nothing
            objOItem_Result = objLocalConfig.Globals.LState_Success
        Catch ex As Exception
            objOItem_Result = objLocalConfig.Globals.LState_Error
        End Try

        Return objOItem_Result
    End Function

    Public Function save_Objects(ByVal oList_Objects As List(Of clsOntologyItem)) As clsOntologyItem
        Dim objOItem_Result As clsOntologyItem
        Dim objOItem_Object As clsOntologyItem
        Dim objDict As Dictionary(Of String, Object)
        Dim objBulkObjects() As ElasticSearch.Client.Domain.BulkObject
        Dim objOPResult As ElasticSearch.Client.Domain.OperateResult
        Dim l As Long

        ReDim Preserve objBulkObjects(oList_Objects.Count - 1)

        objDict = New Dictionary(Of String, Object)
        l = 0
        For Each objOItem_Object In oList_Objects
            objDict.Add(objLocalConfig.Globals.Field_ID_Item, objOItem_Object.GUID)
            objDict.Add(objLocalConfig.Globals.Field_Name_Item, objOItem_Object.Name)
            objDict.Add(objLocalConfig.Globals.Field_ID_Class, objOItem_Object.GUID_Parent)

            objBulkObjects(l) = New ElasticSearch.Client.Domain.BulkObject(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Object, objOItem_Object.GUID, objDict)

            l = l + 1
        Next


        Try
            objOPResult = objElConn.Bulk(objBulkObjects)
            objBulkObjects = Nothing
            objOItem_Result = objLocalConfig.Globals.LState_Success
        Catch ex As Exception
            objOItem_Result = objLocalConfig.Globals.LState_Error
        End Try

        Return objOItem_Result
    End Function

    Private Sub initialize_Client()
        intPackageLength = objLocalConfig.Globals.SearchRange

        objElConn = New ElasticSearch.Client.ElasticSearchClient(objLocalConfig.Globals.Server, objLocalConfig.Globals.Port, Client.Config.TransportType.Thrift, False)
        Try
            objElConn.CreateIndex(objLocalConfig.Globals.Index_Rep)
        Catch ex As Exception
            Err.Raise(1, Nothing, "Report index!")
        End Try
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
        objElConn.Flush()
        objOntologyList_Attributes.Clear()
        otblT_RelationTypes.Clear()
        objOntologyList_RelationTypes.Clear()


        intCount = 0
        objOItem_Result = objLocalConfig.Globals.LState_Success

        create_BoolQuery_Attributes(OList_Attributes, OList_DataTypes, OList_AttributeTypes, True)

        intCount = intPackageLength
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Attribute, objBoolQuery.ToString, intPos, intPackageLength)
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
                                               objHit.Source(objLocalConfig.Globals.Field_Val_Real).ToString, _
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

        objElConn.Flush()
        otblT_RelationTypes.Clear()
        objOntologyList_RelationTypes.Clear()


        intCount = 0
        objOItem_Result = objLocalConfig.Globals.LState_Success

        create_BoolQuery_Simple(OList_RelType, objLocalConfig.Globals.Type_RelationType)

        intCount = intPackageLength
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_RelationType, objBoolQuery.ToString, intPos, intPackageLength)
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
        Dim strField_IDParent As String = ""
        Dim boolID As Boolean = False

        Select Case strOntology
            Case objLocalConfig.Globals.Type_AttributeType
                strField_IDParent = objLocalConfig.Globals.Field_ID_DataType
            Case objLocalConfig.Globals.Type_Object
                strField_IDParent = objLocalConfig.Globals.Field_ID_Class
            Case Else
                strField_IDParent = objLocalConfig.Globals.Field_ID_Parent
        End Select

        objBoolQuery = New Lucene.Net.Search.BooleanQuery



        If Not OList_Items Is Nothing Then
            If OList_Items.Count > 0 Then
                If strOntology = objLocalConfig.Globals.Type_AttributeType Or _
                strOntology = objLocalConfig.Globals.Type_RelationType Or _
                strOntology = objLocalConfig.Globals.Type_Class Or _
                strOntology = objLocalConfig.Globals.Type_Object Or _
                strOntology = objLocalConfig.Globals.Type_Class Then

                    Dim objLQuery_ID = From at As clsOntologyItem In OList_Items Group By at.GUID Into Group

                    strQuery = ""

                    For Each objQuery_ID In objLQuery_ID
                        If objQuery_ID.GUID <> "" Then
                            If strQuery <> "" Then
                                strQuery = strQuery & "\ OR\ "
                            End If
                            strQuery = strQuery & objQuery_ID.GUID
                        End If
                        
                    Next

                    If strQuery <> "" Then
                        boolID = True
                        objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Item, strQuery)), BooleanClause.Occur.MUST)

                    End If
                End If

                If boolID = False Then
                    If strOntology = objLocalConfig.Globals.Type_AttributeType Or _
                    strOntology = objLocalConfig.Globals.Type_RelationType Or _
                    strOntology = objLocalConfig.Globals.Type_Class Or _
                    strOntology = objLocalConfig.Globals.Type_Object Or _
                    strOntology = objLocalConfig.Globals.Type_DataType Then

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

                            objBoolQuery.Add(New TermQuery(New Term(strField_IDParent, strQuery)), BooleanClause.Occur.MUST)
                        End If
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

        If boolClear = True Then
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

        If boolClear = True Then
            objBoolQuery = New Lucene.Net.Search.BooleanQuery
        End If


        If Not OList_Object Is Nothing Then
            If OList_Object.Count > 0 Then
                If Not OList_Object(0) Is Nothing Then
                    Dim objLQuery_ID = From at As clsOntologyItem In OList_Object Group By at.GUID Into Group

                    strQuery = ""

                    For Each objQuery_ID In objLQuery_ID
                        If objQuery_ID.GUID <> "" Then
                            If strQuery <> "" Then
                                strQuery = strQuery & "\ OR\ "
                            End If
                            strQuery = strQuery & objQuery_ID.GUID
                        End If
                        
                    Next

                    If strQuery <> "" Then
                        objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Object, strQuery)), BooleanClause.Occur.MUST)

                    End If

                    Dim objLQuery_ID_Parent = From at As clsOntologyItem In OList_Object Group By at.GUID_Parent Into Group

                    If strQuery = "" Then
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


            End If
        End If

        If Not OList_Other Is Nothing Then
            If OList_Other.Count > 0 Then
                If Not OList_Other(0) Is Nothing Then
                    Dim objLQuery_ID = From at As clsOntologyItem In OList_Other
                                   Group By at.GUID Into Group

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

                    If strQuery = "" Then
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


                        Dim objLQuery_Ontology = From at As clsOntologyItem In OList_Other Group By at.Type, at.Mark Into Group

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

            End If
        End If

        If Not oList_RelationType Is Nothing Then
            If oList_RelationType.Count > 0 Then
                If Not oList_RelationType(0) Is Nothing Then
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

        objElConn.Flush()
        otblT_AttributeTypes.Clear()
        objOntologyList_AttributTypes.Clear()


        objOItem_Result = objLocalConfig.Globals.LState_Success

        intCount = 0

        create_BoolQuery_Simple(OList_AttType, objLocalConfig.Globals.Type_AttributeType)

        intCount = intPackageLength
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_AttributeType, objBoolQuery.ToString, intPos, intPackageLength)
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

    Public Function get_Data_ClassAtt(Optional ByVal oList_Class As List(Of clsOntologyItem) = Nothing, Optional ByVal oList_AttributeTyp As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False, Optional ByVal boolIDs As Boolean = True) As clsOntologyItem
        Dim objOItem_Result As clsOntologyItem
        Dim oList_Classes As New List(Of clsOntologyItem)
        Dim oList_AttributeTypes As New List(Of clsOntologyItem)
        Dim objBoolQuery As New Lucene.Net.Search.BooleanQuery
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer

        objElConn.Flush()
        objOItem_Result = objLocalConfig.Globals.LState_Success

        oList_AttributeTypes.Clear()
        If Not oList_Class Is Nothing Then
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

            Dim strLQuery_AttID = From obj As clsOntologyItem In oList_AttributeTypes Group By obj.GUID Into Group Select GUID = GUID

            strQuery = ""
            For Each strQuery_ID In strLQuery_AttID
                If strQuery <> "" Then
                    strQuery = strQuery & "\ OR\ "
                End If
                strQuery = strQuery & strQuery_ID
            Next
            If strQuery <> "" Then
                objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Attribute, strQuery)), BooleanClause.Occur.MUST)

            End If
        End If
        If Not oList_AttributeTypes Is Nothing Then
            If Not oList_AttributeTypes.Count = 0 Then
                Dim strLQuery_ID = From obj As clsOntologyItem In oList_AttributeTyp Group By obj.GUID Into Group Select GUID = GUID

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

                Dim strLQuery_AttID = From obj As clsOntologyItem In oList_AttributeTypes Group By obj.GUID Into Group Select GUID = GUID

                strQuery = ""
                For Each strQuery_ID In strLQuery_AttID
                    If strQuery <> "" Then
                        strQuery = strQuery & "\ OR\ "
                    End If
                    strQuery = strQuery & strQuery_ID
                Next
                If strQuery <> "" Then
                    objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Attribute, strQuery)), BooleanClause.Occur.MUST)

                End If
            End If

        End If

        objOntologyList_ClassAtt_ID.Clear()
        objOntologyList_Classes1.Clear()
        otblT_ClassAtt.Clear()

        intCount = intPackageLength
        intPos = 0
        While intCount > 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ClassAtt, objBoolQuery.ToString, intPos, intPackageLength)
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

    Public Function get_Data_ClassRel(ByVal oList_Class As List(Of clsOntologyItem), ByVal Direction As clsOntologyItem, ByVal boolIDs As Boolean, Optional ByVal boolTable As Boolean = False, Optional ByVal boolOR As Boolean = False) As clsOntologyItem
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

        objElConn.Flush()
        objOntologyList_Classes1.Clear()
        objOntologyList_Classes2.Clear()
        objOntologyList_RelationTypes.Clear()
        objOntologyList_ClassRel_ID.Clear()
        objOntologyList_ClassRel.Clear()

        objOItem_Result = objLocalConfig.Globals.LState_Success

        If Not Direction Is Nothing Then
            If Direction.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
                create_BoolQuery_ClassRel(oList_Class, Nothing, Nothing, True)

            Else
                create_BoolQuery_ClassRel(Nothing, oList_Class, Nothing, True)
            End If
        Else
            create_BoolQuery_ClassRel(Nothing, Nothing, Nothing, True)
        End If


        strQuery = ""


        intCount = intPackageLength
        intPos = 0
        While intCount > 0


            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ClassRel, objBoolQuery.ToString, intPos, intPackageLength)
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

            If boolOR = False Then
                Dim objLRels = From objRel In objOntologyList_ClassRel_ID
                          Join objClass_Left In objOntologyList_Classes1 On objClass_Left.GUID Equals objRel.ID_Class_Left
                          Join objClass_Right In objOntologyList_Classes2 On objClass_Right.GUID Equals objRel.ID_Class_Right
                          Join objRelType In objOntologyList_RelationTypes On objRelType.GUID Equals objRel.ID_RelationType

                For Each objRel In objLRels
                    If boolTable = False Then
                        objOntologyList_ClassRel.Add(New clsClassRel(objRel.objClass_Left.GUID, objRel.objClass_Left.Name, _
                                                                     objRel.objClass_Right.GUID, objRel.objClass_Right.Name, _
                                                                     objRel.objRelType.GUID, objRel.objRelType.Name, _
                                                                     objRel.objRel.Ontology, _
                                                                     objRel.objRel.Min_Forw, _
                                                                     objRel.objRel.Max_Forw, _
                                                                     objRel.objRel.Max_Backw))
                    Else
                        otblT_ClassRel.Rows.Add(objRel.objRel.ID_Class_Left, _
                                                             objRel.objClass_Left.Name, _
                                                             objRel.objRel.ID_Class_Right, _
                                                             objRel.objClass_Right.Name, _
                                                             objRel.objRel.ID_RelationType, _
                                                             objRel.objRelType.Name, _
                                                             objRel.objRel.Ontology, _
                                                             objRel.objRel.Min_Forw, _
                                                             objRel.objRel.Max_Forw, _
                                                             objRel.objRel.Max_Backw)
                    End If


                Next
            Else
                Dim objLRels = From objRel In objOntologyList_ClassRel_ID
                          Join objClass_Left In objOntologyList_Classes1 On objClass_Left.GUID Equals objRel.ID_Class_Left
                          Join objRelType In objOntologyList_RelationTypes On objRelType.GUID Equals objRel.ID_RelationType
                          Where objRel.Ontology = objLocalConfig.Globals.Type_Other

                For Each objRel In objLRels
                    If boolTable = False Then
                        objOntologyList_ClassRel.Add(New clsClassRel(objRel.objClass_Left.GUID, objRel.objClass_Left.Name, _
                                                                     Nothing, Nothing, _
                                                                     objRel.objRelType.GUID, objRel.objRelType.Name, _
                                                                     objRel.objRel.Ontology, _
                                                                     objRel.objRel.Min_Forw, _
                                                                     objRel.objRel.Max_Forw, _
                                                                     objRel.objRel.Max_Backw))
                    Else
                        otblT_ClassRel.Rows.Add(objRel.objRel.ID_Class_Left, _
                                                             objRel.objClass_Left.Name, _
                                                             Nothing, _
                                                             Nothing, _
                                                             objRel.objRel.ID_RelationType, _
                                                             objRel.objRelType.Name, _
                                                             objRel.objRel.Ontology, _
                                                             objRel.objRel.Min_Forw, _
                                                             objRel.objRel.Max_Forw, _
                                                             objRel.objRel.Max_Backw)
                    End If


                Next
            End If


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

        objElConn.Flush()
        objOntologyList_ObjAtt_ID.Clear()
        objOntologyList_ObjAtt.Clear()
        objOList_AttributeTypes.Clear()
        objOList_Attributes.Clear()
        objOList_Classes.Clear()
        objOList_Objects.Clear()

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
                objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_AttributeType, strQuery)), BooleanClause.Occur.MUST)
            End If
        End If
        intCount = intPackageLength
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ObjectAtt, objBoolQuery.ToString, intPos, intPackageLength)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList

                objOntologyList_ObjAtt_ID.Add(New clsObjectAtt(objHit.Source(objLocalConfig.Globals.Field_ID_Attribute).ToString, _
                                                               objHit.Source(objLocalConfig.Globals.Field_ID_Object).ToString, _
                                                               objHit.Source(objLocalConfig.Globals.Field_ID_Class).ToString, _
                                                               objHit.Source(objLocalConfig.Globals.Field_ID_AttributeType).ToString, _
                                                               objHit.Source(objLocalConfig.Globals.Field_OrderID).ToString))

            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
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
                                Group By objObj.ID_Class Into Group

            For Each oItem_Objects In oList_Objects
                objOList_Objects.Add(New clsOntologyItem(Nothing, Nothing, oItem_Objects.ID_Class, objLocalConfig.Globals.Type_Object))
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


            Dim oList_DataType = From objDataType In objOntologyList_AttributTypes
                                 Group By objDataType.GUID_Parent Into Group

            For Each oItem_DataType In oList_DataType
                objOList_DataTypes.Add(New clsOntologyItem(oItem_DataType.GUID_Parent, objLocalConfig.Globals.Type_DataType))

            Next

            If objOList_DataTypes.Count > 0 Then
                get_Data_DataTyps(objOList_DataTypes)
            End If


            Dim oListRel = From objRel In objOntologyList_ObjAtt_ID
                           Join objAttType In objOntologyList_AttributTypes On objRel.ID_AttributeType Equals objAttType.GUID
                           Join objClass In objOntologyList_Classes1 On objRel.ID_Class Equals objClass.GUID
                           Join objAtt In objOntologyList_Attributes On objRel.ID_Attribute Equals objAtt.ID_Attribute
                           Join objObj In objOntologyList_Objects On objRel.ID_Object Equals objObj.GUID
                           Join objDataType In objOntologyList_DataTypes On objAttType.GUID_Parent Equals objDataType.GUID
                           Group By objRel.ID_Attribute _
                            , ID_AttributeType = objAttType.GUID _
                            , Name_AttributeType = objAttType.Name _
                            , ID_Class = objClass.GUID _
                            , Name_Class = objClass.Name _
                            , ID_Object = objObj.GUID _
                            , Name_Object = objObj.Name _
                            , ID_DataType = objDataType.GUID _
                            , Name_DataType = objDataType.Name _
                            , objRel.OrderID _
                            , Val_Bool = objAtt.Val_Bool _
                            , Val_Date = objAtt.Val_Date _
                            , Val_Double = objAtt.Val_Double _
                            , Val_Int = objAtt.Val_Long _
                            , Val_String = objAtt.Val_String _
                            , Val_Named = objAtt.Val_Name Into Group

            oList_AttType = Nothing

            For Each objORels In oListRel
                If boolTable = False Then
                    Select Case objORels.ID_DataType
                        Case objLocalConfig.Globals.DType_Bool.GUID
                            objOntologyList_ObjAtt.Add(New clsObjectAtt(objORels.ID_Attribute, _
                                             objORels.ID_Object, _
                                             objORels.Name_Object, _
                                             objORels.ID_Class, _
                                             objORels.Name_Class, _
                                             objORels.ID_AttributeType, _
                                             objORels.Name_AttributeType, _
                                             objORels.OrderID, _
                                             objORels.Val_Named, _
                                             objORels.Val_Bool, _
                                             Nothing, _
                                             Nothing, _
                                             Nothing, _
                                             Nothing))
                        Case objLocalConfig.Globals.DType_DateTime.GUID
                            objOntologyList_ObjAtt.Add(New clsObjectAtt(objORels.ID_Attribute, _
                                             objORels.ID_Object, _
                                             objORels.Name_Object, _
                                             objORels.ID_Class, _
                                             objORels.Name_Class, _
                                             objORels.ID_AttributeType, _
                                             objORels.Name_AttributeType, _
                                             objORels.OrderID, _
                                             objORels.Val_Named, _
                                             Nothing, _
                                             objORels.Val_Date, _
                                             Nothing, _
                                             Nothing, _
                                             Nothing))
                        Case objLocalConfig.Globals.DType_Int.GUID
                            objOntologyList_ObjAtt.Add(New clsObjectAtt(objORels.ID_Attribute, _
                                             objORels.ID_Object, _
                                             objORels.Name_Object, _
                                             objORels.ID_Class, _
                                             objORels.Name_Class, _
                                             objORels.ID_AttributeType, _
                                             objORels.Name_AttributeType, _
                                             objORels.OrderID, _
                                             objORels.Val_Named, _
                                             Nothing, _
                                             Nothing, _
                                             objORels.Val_Int, _
                                             Nothing, _
                                             Nothing))
                        Case objLocalConfig.Globals.DType_Real.GUID
                            objOntologyList_ObjAtt.Add(New clsObjectAtt(objORels.ID_Attribute, _
                                             objORels.ID_Object, _
                                             objORels.Name_Object, _
                                             objORels.ID_Class, _
                                             objORels.Name_Class, _
                                             objORels.ID_AttributeType, _
                                             objORels.Name_AttributeType, _
                                             objORels.OrderID, _
                                             objORels.Val_Named, _
                                             Nothing, _
                                             Nothing, _
                                             Nothing, _
                                             objORels.Val_Double, _
                                             Nothing))
                        Case objLocalConfig.Globals.DType_String.GUID
                            objOntologyList_ObjAtt.Add(New clsObjectAtt(objORels.ID_Attribute, _
                                             objORels.ID_Object, _
                                             objORels.Name_Object, _
                                             objORels.ID_Class, _
                                             objORels.Name_Class, _
                                             objORels.ID_AttributeType, _
                                             objORels.Name_AttributeType, _
                                             objORels.OrderID, _
                                             objORels.Val_Named, _
                                             Nothing, _
                                             Nothing, _
                                             Nothing, _
                                             Nothing, _
                                             objORels.Val_String))
                    End Select
                Else
                    Select Case objORels.ID_DataType
                        Case objLocalConfig.Globals.DType_Bool.GUID
                            otblT_ObjectAtt.Rows.Add(objORels.ID_Attribute, _
                                                 objORels.ID_Object, _
                                                 objORels.Name_Object, _
                                                 objORels.ID_AttributeType, _
                                                 objORels.Name_AttributeType, _
                                                 objORels.ID_Class, _
                                                 objORels.Name_Class, _
                                                 objORels.OrderID, _
                                                 objORels.Val_Named, _
                                                 objORels.Val_Bool, _
                                                 Nothing, _
                                                 Nothing, _
                                                 Nothing, _
                                                 Nothing, _
                                                 objORels.ID_DataType, _
                                                 objORels.Name_DataType)
                        Case objLocalConfig.Globals.DType_DateTime.GUID
                            otblT_ObjectAtt.Rows.Add(objORels.ID_Attribute, _
                                                     objORels.ID_Object, _
                                                 objORels.Name_Object, _
                                                 objORels.ID_AttributeType, _
                                                 objORels.Name_AttributeType, _
                                                 objORels.ID_Class, _
                                                 objORels.Name_Class, _
                                                 objORels.OrderID, _
                                                 objORels.Val_Named, _
                                                 Nothing, _
                                                 Nothing, _
                                                 Nothing, _
                                                 objORels.Val_Date, _
                                                 Nothing, _
                                                 objORels.ID_DataType, _
                                                 objORels.Name_DataType)
                        Case objLocalConfig.Globals.DType_Int.GUID
                            otblT_ObjectAtt.Rows.Add(objORels.ID_Object, _
                                                 objORels.Name_Object, _
                                                 objORels.ID_AttributeType, _
                                                 objORels.Name_AttributeType, _
                                                 objORels.ID_Class, _
                                                 objORels.Name_Class, _
                                                 objORels.OrderID, _
                                                 objORels.Val_Named, _
                                                 Nothing, _
                                                 objORels.Val_Int, _
                                                 Nothing, _
                                                 Nothing, _
                                                 Nothing, _
                                                 objORels.ID_DataType, _
                                                 objORels.Name_DataType)
                        Case objLocalConfig.Globals.DType_Real.GUID
                            otblT_ObjectAtt.Rows.Add(objORels.ID_Object, _
                                                 objORels.Name_Object, _
                                                 objORels.ID_AttributeType, _
                                                 objORels.Name_AttributeType, _
                                                 objORels.ID_Class, _
                                                 objORels.Name_Class, _
                                                 objORels.OrderID, _
                                                 objORels.Val_Named, _
                                                 Nothing, _
                                                 Nothing, _
                                                 objORels.Val_Double, _
                                                 Nothing, _
                                                 Nothing, _
                                                 objORels.ID_DataType, _
                                                 objORels.Name_DataType)
                        Case objLocalConfig.Globals.DType_String.GUID
                            otblT_ObjectAtt.Rows.Add(objORels.ID_Object, _
                                                 objORels.Name_Object, _
                                                 objORels.ID_AttributeType, _
                                                 objORels.Name_AttributeType, _
                                                 objORels.ID_Class, _
                                                 objORels.Name_Class, _
                                                 objORels.OrderID, _
                                                 objORels.Val_Named, _
                                                 Nothing, _
                                                 Nothing, _
                                                 Nothing, _
                                                 Nothing, _
                                                 objORels.Val_String, _
                                                 objORels.ID_DataType, _
                                                 objORels.Name_DataType)
                    End Select
                End If


            Next


        End If


        Return objOItem_Result
    End Function

    Public Function get_Data_ObjectRel(ByVal oList_Object As List(Of clsOntologyItem), ByVal oList_Other As List(Of clsOntologyItem), ByVal oList_RelType As List(Of clsOntologyItem), Optional ByVal boolTable As Boolean = False, Optional ByVal boolIDs As Boolean = True) As clsOntologyItem
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim objOItem_Result As clsOntologyItem = objLocalConfig.Globals.LState_Success

        Dim oList_Class As New List(Of clsOntologyItem)

        Dim oList_Rel_Object As New List(Of clsOntologyItem)
        Dim oList_Rel_ObjectCls As New List(Of clsOntologyItem)
        Dim oList_Rel_AttType As New List(Of clsOntologyItem)
        Dim oList_Rel_Class As New List(Of clsOntologyItem)
        Dim oList_Rel_RelType As New List(Of clsOntologyItem)
        Dim objDBLevel As New clsDBLevel(objLocalConfig)
        Dim strQuery As String
        Dim intCount As Integer
        Dim intPos As Integer

        objElConn.Flush()
        objOntologyList_ObjectRel_ID.Clear()
        objOntologyList_ObjectRel.Clear()
        objOntologyList_Objects.Clear()
        objOntologyList_RelationTypes.Clear()
        otblT_ObjectRel.Clear()

        create_BoolQuery_ObjectRel(oList_Object, oList_Other, oList_RelType)

        intCount = intPackageLength
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ObjectRel, objBoolQuery.ToString, intPos, intPackageLength)
            objList = objSearchResult.GetHits.Hits

            For Each objHit In objList


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


            Next

            intCount = objList.Count

            objList.Clear()
            objSearchResult = Nothing
            objList = Nothing
            intPos = intPos + intCount
        End While


        If objOntologyList_ObjectRel_ID.Count > 0 Then
            If boolIDs = False Then

                oList_RelType = New List(Of clsOntologyItem)
                Dim objLCls = From objObj In objOntologyList_ObjectRel_ID
                                 Group By objObj.ID_Parent_Object Into Group


                For Each objCls In objLCls
                    oList_Object.Add(New clsOntologyItem(Nothing, Nothing, objCls.ID_Parent_Object, objLocalConfig.Globals.Type_Object))

                Next


                If oList_Object.Count > 0 Then
                    get_Data_Objects(oList_Object)
                End If

                Dim objLClasses = From objClass In objOntologyList_ObjectRel_ID
                                  Group By objClass.ID_Parent_Object Into Group

                For Each objClass In objLClasses
                    oList_Class.Add(New clsOntologyItem(objClass.ID_Parent_Object, objLocalConfig.Globals.Type_Class))


                Next

                If oList_Class.Count > 0 Then
                    get_Data_Classes(oList_Class)
                End If

                Dim objLRelType = From objRelType In objOntologyList_ObjectRel_ID
                                  Group By objRelType.ID_RelationType Into Group

<<<<<<< HEAD
                    Case objLocalConfig.Globals.Type_Object
                        oList_Rel_Object.Add(New clsOntologyItem(Nothing, Nothing, objOther.ID_Parent_Other, objLocalConfig.Globals.Type_Object))
=======
                For Each objRelType In objLRelType
                    oList_RelType.Add(New clsOntologyItem(objRelType.ID_RelationType, objLocalConfig.Globals.Type_RelationType))
>>>>>>> Go On

                Next

                If oList_RelType.Count > 0 Then
                    get_Data_RelationTypes(oList_RelType)
                End If

                Dim objLOther = From objOther In objOntologyList_ObjectRel_ID
                                Group By objOther.Ontology, objOther.ID_Other, objOther.ID_Parent_Other Into Group

                For Each objOther In objLOther
                    Select Case objOther.Ontology
                        Case objLocalConfig.Globals.Type_AttributeType
                            OList_AttributeTypes.Add(New clsOntologyItem(objOther.ID_Other, objLocalConfig.Globals.Type_AttributeType))

                        Case objLocalConfig.Globals.Type_Class
                            OList_Classes.Add(New clsOntologyItem(objOther.ID_Other, objLocalConfig.Globals.Type_Class))

                        Case objLocalConfig.Globals.Type_Object
                            oList_Rel_Object.Add(New clsOntologyItem(Nothing, Nothing, objOther.ID_Parent_Other, objLocalConfig.Globals.Type_Object))

                            Dim oLClasses = From objCls1 In objOntologyList_ObjectRel_ID
                                            Group By objCls1.ID_Parent_Other Into Group

                            For Each oClass In oLClasses
                                oList_Rel_ObjectCls.Add(New clsOntologyItem(oClass.ID_Parent_Other, objLocalConfig.Globals.Type_Class))
                            Next

<<<<<<< HEAD
            If oList_Object.Count > 0 Then
                objDBLevel.get_Data_Objects(oList_Rel_Object)
                objDBLevel.get_Data_Classes(oList_Rel_ObjectCls, False, True)
            End If
=======
                        Case objLocalConfig.Globals.Type_RelationType
                            oList_Rel_RelType.Add(New clsOntologyItem(objOther.ID_Other, objLocalConfig.Globals.Type_RelationType))
>>>>>>> Go On

                    End Select
                Next

                If OList_AttributeTypes.Count > 0 Then
                    objDBLevel.get_Data_AttributeType(OList_AttributeTypes)

                End If

                If OList_Classes.Count > 0 Then
                    objDBLevel.get_Data_Classes(OList_Classes)

                End If

                If oList_Object.Count > 0 Then
                    objDBLevel.get_Data_Objects(oList_Rel_Object)
                    objDBLevel.get_Data_Classes(oList_Rel_ObjectCls, False, True)
                End If

                If oList_Rel_RelType.Count > 0 Then
                    objDBLevel.get_Data_RelationTypes(oList_Rel_RelType)

                End If

                Dim objLItems = From objRel In objOntologyList_ObjectRel_ID
                            Join objObjs In objOntologyList_Objects On objRel.ID_Object Equals objObjs.GUID
                            Join objCls In objOntologyList_Classes1 On objRel.ID_Parent_Object Equals objCls.GUID
                            Join objRelTypes In objOntologyList_RelationTypes On objRelTypes.GUID Equals objRel.ID_RelationType
                            Group Join objRelAtts In objDBLevel.objOntologyList_AttributTypes On objRelAtts.GUID Equals objRel.ID_Other Into Right_Attributes = Group
                            Group Join objRelClasses In objDBLevel.objOntologyList_Classes1 On objRelClasses.GUID Equals objRel.ID_Other Into Right_Classes = Group
                            Group Join objRelObjs In objDBLevel.objOntologyList_Objects On objRelObjs.GUID Equals objRel.ID_Other Into Right_Objects = Group
                            Group Join objRelObjsCls In objDBLevel.objOntologyList_Classes2 On objRelObjsCls.GUID Equals objRel.ID_Parent_Other Into Right_ObjectClasses = Group
                            Group Join objRelRels In objDBLevel.objOntologyList_RelationTypes On objRelRels.GUID Equals objRel.ID_Other Into Right_Rels = Group
                            From oRightAtts In Right_Attributes.DefaultIfEmpty, _
                                 oRightClasses In Right_Classes.DefaultIfEmpty, _
                                 objRightObjs In Right_Objects.DefaultIfEmpty, _
                                 objRightObjCls In Right_ObjectClasses.DefaultIfEmpty, _
                                 objRightRels In Right_Rels.DefaultIfEmpty()

                For Each oItem In objLItems
                    If boolTable = False Then
                        Select Case oItem.objRel.Ontology
                            Case objLocalConfig.Globals.Type_Attribute
                                objOntologyList_ObjectRel.Add(New clsObjectRel(oItem.objRel.ID_Object, _
                                                                               oItem.objObjs.Name, _
                                                                               oItem.objRel.ID_Parent_Object, _
                                                                               oItem.objCls.Name, _
                                                                               oItem.oRightAtts.GUID, _
                                                                               oItem.oRightAtts.Name, _
                                                                               oItem.oRightAtts.GUID_Parent, _
                                                                               Nothing, _
                                                                               oItem.objRelTypes.GUID, _
                                                                               oItem.objRelTypes.Name, _
                                                                               oItem.objRel.Ontology, _
                                                                               Nothing, _
                                                                               Nothing, _
                                                                               oItem.objRel.OrderID))



                            Case objLocalConfig.Globals.Type_Class
                                objOntologyList_ObjectRel.Add(New clsObjectRel(oItem.objRel.ID_Object, _
                                                                               oItem.objObjs.Name, _
                                                                               oItem.objRel.ID_Parent_Object, _
                                                                               oItem.objCls.Name, _
                                                                               oItem.oRightClasses.GUID, _
                                                                               oItem.oRightClasses.Name, _
                                                                               oItem.oRightClasses.GUID_Parent, _
                                                                               Nothing, _
                                                                               oItem.objRelTypes.GUID, _
                                                                               oItem.objRelTypes.Name, _
                                                                               oItem.objRel.Ontology, _
                                                                               Nothing, _
                                                                               Nothing, _
                                                                               oItem.objRel.OrderID))

                            Case objLocalConfig.Globals.Type_Object
                                objOntologyList_ObjectRel.Add(New clsObjectRel(oItem.objRel.ID_Object, _
                                                                               oItem.objObjs.Name, _
                                                                               oItem.objRel.ID_Parent_Object, _
                                                                               oItem.objCls.Name, _
                                                                               oItem.objRightObjs.GUID, _
                                                                               oItem.objRightObjs.Name, _
                                                                               oItem.objRightObjCls.GUID, _
                                                                               oItem.objRightObjCls.Name, _
                                                                               oItem.objRelTypes.GUID, _
                                                                               oItem.objRelTypes.Name, _
                                                                               oItem.objRel.Ontology, _
                                                                               Nothing, _
                                                                               Nothing, _
                                                                               oItem.objRel.OrderID))
                            Case objLocalConfig.Globals.Type_RelationType
                                objOntologyList_ObjectRel.Add(New clsObjectRel(oItem.objRel.ID_Object, _
                                                                               oItem.objObjs.Name, _
                                                                               oItem.objRel.ID_Parent_Object, _
                                                                               oItem.objCls.Name, _
                                                                               oItem.objRightRels.GUID, _
                                                                               oItem.objRightRels.Name, _
                                                                               Nothing, _
                                                                               Nothing, _
                                                                               oItem.objRelTypes.GUID, _
                                                                               oItem.objRelTypes.Name, _
                                                                               oItem.objRel.Ontology, _
                                                                               Nothing, _
                                                                               Nothing, _
                                                                               oItem.objRel.OrderID))
                        End Select
                    Else
                        Select Case oItem.objRel.Ontology
                            Case objLocalConfig.Globals.Type_Attribute
                                otblT_ObjectRel.Rows.Add(oItem.objObjs.GUID, _
                                                 oItem.objObjs.Name, _
                                                 oItem.objCls.GUID, _
                                                 oItem.objCls.Name, _
                                                 oItem.objRelTypes.GUID, _
                                                 oItem.objRelTypes.Name, _
                                                 oItem.objRel.OrderID, _
                                                 oItem.oRightAtts.GUID, _
                                                 oItem.oRightAtts.Name, _
                                                 Nothing, _
                                                 Nothing, _
                                                 oItem.objRel.Ontology)



                            Case objLocalConfig.Globals.Type_Class
                                otblT_ObjectRel.Rows.Add(oItem.objObjs.GUID, _
                                                 oItem.objObjs.Name, _
                                                 oItem.objCls.GUID, _
                                                 oItem.objCls.Name, _
                                                 oItem.objRelTypes.GUID, _
                                                 oItem.objRelTypes.Name, _
                                                 oItem.objRel.OrderID, _
                                                 oItem.oRightClasses.GUID, _
                                                 oItem.oRightClasses.Name, _
                                                 Nothing, _
                                                 Nothing, _
                                                 oItem.objRel.Ontology)

                            Case objLocalConfig.Globals.Type_Object
                                otblT_ObjectRel.Rows.Add(oItem.objObjs.GUID, _
                                                 oItem.objObjs.Name, _
                                                 oItem.objCls.GUID, _
                                                 oItem.objCls.Name, _
                                                 oItem.objRelTypes.GUID, _
                                                 oItem.objRelTypes.Name, _
                                                 oItem.objRel.OrderID, _
                                                 oItem.objRightObjs.GUID, _
                                                 oItem.objRightObjs.Name, _
                                                 oItem.objRightObjCls.GUID, _
                                                 oItem.objRightObjCls.Name, _
                                                 oItem.objRel.Ontology)

                            Case objLocalConfig.Globals.Type_RelationType
                                otblT_ObjectRel.Rows.Add(oItem.objObjs.GUID, _
                                                 oItem.objObjs.Name, _
                                                 oItem.objCls.GUID, _
                                                 oItem.objCls.Name, _
                                                 oItem.objRelTypes.GUID, _
                                                 oItem.objRelTypes.Name, _
                                                 oItem.objRel.OrderID, _
                                                 oItem.objRightRels.GUID, _
                                                 oItem.objRightRels.Name, _
                                                 Nothing, _
                                                 Nothing, _
                                                 oItem.objRel.Ontology)
                        End Select
                    End If





                Next
            End If
        End If

        






        Return objOItem_Result
    End Function



    Public Function get_Data_DataTyps(Optional ByVal oList_DataTypes As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False) As clsOntologyItem
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objOItem_Result As clsOntologyItem
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim strQuery As String = ""
        Dim intCount As Integer
        Dim intPos As Integer
        Dim strQuery_ID As String
        Dim strQuery_Name As String

        objElConn.Flush()
        otblT_DataTypes.Clear()
        objOntologyList_DataTypes.Clear()

        objOItem_Result = objLocalConfig.Globals.LState_Success
        intCount = 0


        Dim strLQuery_LID = From obj As clsOntologyItem In OList_Objects Group By obj.GUID Into Group Select GUID = GUID
        Dim strLQuery_LName = From obj As clsOntologyItem In OList_Objects Group By obj.Name Into Group Select Name = Name

        create_BoolQuery_Simple(oList_DataTypes, objLocalConfig.Globals.Type_DataType)

        intCount = intPackageLength
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_DataType, objBoolQuery.ToString, intPos, intPackageLength)
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

        objElConn.Flush()
        objOItem_Result = objLocalConfig.Globals.LState_Success

        objOntologyList_ObjectTree.Clear()
        otblT_ObjectTree.Clear()
        objOntologyList_Objects.Clear()
        otblT_Objects.Clear()

        objOList_Objects.Add(New clsOntologyItem(Nothing, Nothing, objOItem_Class_Par.GUID, objLocalConfig.Globals.Type_Class))
        objOList_Objects.Add(New clsOntologyItem(Nothing, Nothing, objOitem_Class_Child.GUID, objLocalConfig.Globals.Type_Class))
        objOList_RelationTypes.Add(objOItem_RelationType)

        get_Data_Objects(objOList_Objects)

        objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Parent_Object, objOItem_Class_Par.GUID)), BooleanClause.Occur.MUST)
        objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_Parent_Other, objOitem_Class_Child.GUID)), BooleanClause.Occur.MUST)
        objBoolQuery.Add(New TermQuery(New Term(objLocalConfig.Globals.Field_ID_RelationType, objOItem_RelationType.GUID)), BooleanClause.Occur.MUST)

        intCount = intPackageLength
        intPos = 0
        While intCount > 0
            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_ObjectRel, objBoolQuery.ToString, intPos, intPackageLength)
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
        Dim objSearchResult As ElasticSearch.Client.Domain.SearchResult
        Dim objList As New List(Of ElasticSearch.Client.Domain.Hits)
        Dim objOItem_Result As clsOntologyItem
        Dim objHit As ElasticSearch.Client.Domain.Hits
        Dim strQuery As String = ""
        Dim intCount As Integer
        Dim intPos As Integer

        objElConn.Flush()
        otblT_Objects.Clear()
        objOntologyList_Objects.Clear()

        create_BoolQuery_Simple(oList_Objects, objLocalConfig.Globals.Type_Object)

        objOItem_Result = objLocalConfig.Globals.LState_Success
        intCount = 0

        intCount = intPackageLength
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Object, objBoolQuery.ToString, intPos, intPackageLength)
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



    Public Function create_Report_ES(ByVal objOItem_Report As clsOntologyItem) As clsOntologyItem
        Dim objOItem_Result As clsOntologyItem

        Return objOItem_Result
    End Function

    Public Function create_Report_SQL(Optional ByVal OList_Classes As List(Of clsOntologyItem) = Nothing) As clsOntologyItem
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

        intCount = intPackageLength
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Class, objBoolQuery.ToString, intPos, intPackageLength)
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

    Public Function get_Data_Classes(Optional ByVal OList_Classes As List(Of clsOntologyItem) = Nothing, Optional ByVal boolTable As Boolean = False, Optional ByVal boolClasses_Right As Boolean = False, Optional ByVal strSort As String = Nothing) As clsOntologyItem

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

        objElConn.Flush()
        If boolClasses_Right = False Then
            objOntologyList_Classes1.Clear()
        Else
            objOntologyList_Classes2.Clear()
        End If


        tbl_Classes.Clear()

        objOItem_Result = objLocalConfig.Globals.LState_Success
        intCount = 0

        create_BoolQuery_Simple(OList_Classes, objLocalConfig.Globals.Type_Class)


        intCount = intPackageLength
        intPos = 0
        While intCount > 0

            intCount = 0
            objSearchResult = objElConn.Search(objLocalConfig.Globals.Index, objLocalConfig.Globals.Type_Class, objBoolQuery.ToString, intPos, intPackageLength)
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



    End Sub

End Class
