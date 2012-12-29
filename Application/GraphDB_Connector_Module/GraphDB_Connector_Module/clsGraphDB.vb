Imports Sem_Manager
Imports System.Web
Public Class clsGraphDB
    Private objWebRequest As Net.HttpWebRequest

    Private semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private procA_GraphDBs As New DataSet_CouchDBTableAdapters.proc_GraphDBsTableAdapter
    Private procT_GraphDBs As New DataSet_CouchDB.proc_GraphDBsDataTable

    Private objSemItem_Url As clsSemItem
    Private objSemItem_GraphDB As clsSemItem
    Private objSemItem_ProgramingLanguage As clsSemItem
    Private boolSingleInstance As Boolean

    Private objLocalConfig As clsLocalConfig

    Public ReadOnly Property SingleInstance As Boolean
        Get
            Return boolSingleInstance
        End Get
    End Property

    Public Property SemItem_Url As clsSemItem
        Get
            Return objSemItem_Url
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_Url = value
        End Set
    End Property

    Public ReadOnly Property GraphDB_Exists As Boolean
        Get
            Dim objWebResp As Net.WebResponse
            Dim objStream As IO.Stream
            Dim objTextRead As IO.TextReader
            Dim strResponse As String

            objWebRequest = Net.HttpWebRequest.Create(objSemItem_Url.Name & "_all_dbs")

            objWebResp = objWebRequest.GetResponse
            objStream = objWebResp.GetResponseStream
            objTextRead = New IO.StreamReader(objStream)
            strResponse = objTextRead.ReadToEnd

            objTextRead.Close()
            objStream.Close()
            If strResponse.ToLower.Contains(objLocalConfig.Connection_DB.Database.ToLower) Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public Function initialize_GraphDB() As clsSemItem
        Return get_Data_CouchDB()

    End Function

    Private Function get_Data_CouchDB() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_GraphDB As DataRowCollection
        Dim objDRs_GraphDB() As DataRow

        procA_GraphDBs.Fill(procT_GraphDBs, _
                            objLocalConfig.SemItem_Attribute_SingleDB_Instance.GUID, _
                            objLocalConfig.SemItem_type_ProgramingLanguage.GUID, _
                            objLocalConfig.SemItem_Type_Url.GUID, _
                            objLocalConfig.SemItem_Type_Web_Methods.GUID, _
                            objLocalConfig.SemItem_Type_GraphDB.GUID, _
                            objLocalConfig.SemItem_RelationType_Create_Node_Relationship.GUID, _
                            objLocalConfig.SemItem_RelationType_belonging_Resources.GUID, _
                            1)
        If procT_GraphDBs.Rows.Count > 0 Then
            objSemItem_Result = get_Data_URL()

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objDRC_GraphDB = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Url.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Resources.GUID, _
                                                                       objLocalConfig.SemItem_Type_GraphDB.GUID).Rows
                If objDRC_GraphDB.Count > 0 Then
                    objSemItem_GraphDB = New clsSemItem
                    objSemItem_GraphDB.GUID = objDRC_GraphDB(0).Item("GUID_Token_Left")
                    objSemItem_GraphDB.Name = objDRC_GraphDB(0).Item("Name_Token_Left")
                    objSemItem_GraphDB.GUID_Parent = objLocalConfig.SemItem_Type_GraphDB.GUID
                    objSemItem_GraphDB.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objDRs_GraphDB = procT_GraphDBs.Select("GUID_GraphDB='" & objSemItem_GraphDB.GUID.ToString & "'")
                    If objDRs_GraphDB.Count > 0 Then
                        boolSingleInstance = objDRs_GraphDB(0).Item("SingleDBInstance")
                        objSemItem_ProgramingLanguage = New clsSemItem
                        objSemItem_ProgramingLanguage.GUID = objDRs_GraphDB(0).Item("GUID_Programing_Language")
                        objSemItem_ProgramingLanguage.Name = objDRs_GraphDB(0).Item("Name_Programing_Language")
                        objSemItem_ProgramingLanguage.GUID_Parent = objLocalConfig.SemItem_type_ProgramingLanguage.GUID
                        objSemItem_ProgramingLanguage.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID



                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If


                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
                
            End If
            
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    

    Private Function get_Data_URL() As clsSemItem
        Dim objDRC_URL As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_URL = funcA_TokenToken.GetData_LeftRight_Ordered_By_GUIDs(objLocalConfig.BaseConfig.GUID, _
                                                                         objLocalConfig.SemItem_Type_Url.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belonging_Resources.GUID, _
                                                           True).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Error
        If objDRC_URL.Count > 0 Then
            objSemItem_Url = New clsSemItem
            objSemItem_Url.GUID = objDRC_URL(0).Item("GUID_Token_Right")
            objSemItem_Url.Name = objDRC_URL(0).Item("Name_Token_Right")
            objSemItem_Url.GUID_Parent = objLocalConfig.SemItem_Type_Url.GUID
            objSemItem_Url.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function create_Database() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objWebResp As Net.WebResponse
        Dim objStream As IO.Stream
        Dim objTextRead As IO.TextReader
        Dim strResponse As String

        objSemItem_Result = objLocalConfig.Globals.LogState_Error

        objWebRequest = Net.HttpWebRequest.Create(objSemItem_Url.Name & objLocalConfig.Connection_DB.Database)
        objWebRequest.Method = "PUT"

        objWebResp = objWebRequest.GetResponse
        objStream = objWebResp.GetResponseStream
        objTextRead = New IO.StreamReader(objStream)
        strResponse = objTextRead.ReadToEnd

        objTextRead.Close()
        objStream.Close()

        Return objSemItem_Result
    End Function

    Public Function create_DataTypes() As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Error
        Dim strJSON As String
        Dim strJSONQry As String
        Dim strUpload As String
        Dim objDR_DataType As DataRow
        Dim objDRs_Qry() As DataRow
        Dim objDRs_Code() As DataRow

        objDRs_Code = objLocalConfig.tbl_ItemsWithRest.Select("GUID_Item='" & objLocalConfig.SemItem_Token_KindOfOntology_DataType.GUID.ToString & "' " & _
                                            "AND GUID_ProgramingLanguage='" & objSemItem_ProgramingLanguage.GUID.ToString & "'")
        If objDRs_Code.Count > 0 Then
            strJSON = objDRs_Code(0).Item("Code")

            objDRs_Qry = objLocalConfig.tbl_ItemsWithRest.Select("GUID_Item='" & objLocalConfig.SemItem_Token_Ontology_Item_qry_NodeByGUID.GUID.ToString & "' " & _
                                                              "AND GUID_ProgramingLanguage='" & objSemItem_ProgramingLanguage.GUID.ToString & "'")
            If objDRs_Qry.Count > 0 Then
                strJSONQry = objDRs_Qry(0).Item("Code")
            End If
            objSemItem_Result = objLocalConfig.Globals.LogState_Success

            For Each objDR_DataType In objLocalConfig.tbl_DataTypes.Rows
                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

                If objDRs_Qry.Count > 0 Then
                    strUpload = strJSONQry
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objDR_DataType.Item("GUID_Token_Left").ToString)

                    objSemItem_Result = upload_String(strUpload, True)
                End If


                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    strUpload = strJSON
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objDR_DataType.Item("GUID_Token_Left").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objDR_DataType.Item("GUID_Token_Left").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", objDR_DataType.Item("Name_Token_Left"))
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_DataType.GUID.ToString)

                    objSemItem_Result = upload_String(strUpload)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        Exit For
                    End If
                End If


            Next
        End If

        

        Return objSemItem_Result
    End Function


    Public Function create_KindOfOntologies() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRs_Code() As DataRow
        Dim objDRs_Qry() As DataRow
        Dim strJSON As String
        Dim strUpload As String

        

        objDRs_Code = objLocalConfig.tbl_ItemsWithRest.Select("GUID_Item='" & objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString & "' " & _
                                            "AND GUID_ProgramingLanguage='" & objSemItem_ProgramingLanguage.GUID.ToString & "'")

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        objDRs_Qry = objLocalConfig.tbl_ItemsWithRest.Select("GUID_Item='" & objLocalConfig.SemItem_Token_Ontology_Item_qry_NodeByGUID.GUID.ToString & "' " & _
                                                          "AND GUID_ProgramingLanguage='" & objSemItem_ProgramingLanguage.GUID.ToString & "'")
        If objDRs_Qry.Count > 0 Then
            strJSON = objDRs_Qry(0).Item("Code")
            strUpload = strJSON

            strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Attribute.GUID.ToString)

            objSemItem_Result = upload_String(strUpload, True)
        End If
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            If objDRs_Code.Count > 0 Then
                strJSON = objDRs_Code(0).Item("Code")
                strUpload = strJSON
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Attribute.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Attribute.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Attribute.Name)

                objSemItem_Result = upload_String(strUpload)
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        




        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or _
            objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then

            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            If objDRs_Qry.Count > 0 Then
                strJSON = objDRs_Qry(0).Item("Code")
                strUpload = strJSON

                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_AttributeInstance.GUID.ToString)

                objSemItem_Result = upload_String(strUpload, True)
            End If
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                strJSON = objDRs_Code(0).Item("Code")
                strUpload = strJSON
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_AttributeInstance.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_AttributeInstance.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_AttributeInstance.Name)

                objSemItem_Result = upload_String(strUpload)
            End If

        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or _
            objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then

            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            If objDRs_Qry.Count > 0 Then
                strJSON = objDRs_Qry(0).Item("Code")
                strUpload = strJSON

                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class.GUID.ToString)

                objSemItem_Result = upload_String(strUpload, True)
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                strJSON = objDRs_Code(0).Item("Code")
                strUpload = strJSON
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class.Name)

                objSemItem_Result = upload_String(strUpload)
            End If

        End If


        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or _
            objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then

            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            If objDRs_Qry.Count > 0 Then
                strJSON = objDRs_Qry(0).Item("Code")
                strUpload = strJSON

                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class_Attribute.GUID.ToString)

                objSemItem_Result = upload_String(strUpload, True)
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                strJSON = objDRs_Code(0).Item("Code")
                strUpload = strJSON
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class_Attribute.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class_Attribute.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class_Attribute.Name)

                objSemItem_Result = upload_String(strUpload)
            End If


        End If


        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or _
            objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then

            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            If objDRs_Qry.Count > 0 Then
                strJSON = objDRs_Qry(0).Item("Code")
                strUpload = strJSON

                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class_Relation.GUID.ToString)

                objSemItem_Result = upload_String(strUpload, True)
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                strJSON = objDRs_Code(0).Item("Code")
                strUpload = strJSON
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class_Relation.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class_Relation.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class_Relation.Name)

                objSemItem_Result = upload_String(strUpload)
            End If

        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or _
            objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            If objDRs_Qry.Count > 0 Then
                strJSON = objDRs_Qry(0).Item("Code")
                strUpload = strJSON

                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class_Ontology.GUID.ToString)

                objSemItem_Result = upload_String(strUpload, True)
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                strJSON = objDRs_Code(0).Item("Code")
                strUpload = strJSON
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class_Ontology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class_Ontology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class_Ontology.Name)

                objSemItem_Result = upload_String(strUpload)
            End If

        End If


        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or _
            objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then

            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            If objDRs_Qry.Count > 0 Then
                strJSON = objDRs_Qry(0).Item("Code")
                strUpload = strJSON

                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_DataType.GUID.ToString)

                objSemItem_Result = upload_String(strUpload, True)
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                strJSON = objDRs_Code(0).Item("Code")
                strUpload = strJSON
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_DataType.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_DataType.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_DataType.Name)

                objSemItem_Result = upload_String(strUpload)
            End If

        End If


        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or _
            objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then

            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            If objDRs_Qry.Count > 0 Then
                strJSON = objDRs_Qry(0).Item("Code")
                strUpload = strJSON

                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Object.GUID.ToString)

                objSemItem_Result = upload_String(strUpload, True)
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                strJSON = objDRs_Code(0).Item("Code")
                strUpload = strJSON
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Object.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Object.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Object.Name)

                objSemItem_Result = upload_String(strUpload)
            End If

        End If


        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or _
            objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then

            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            If objDRs_Qry.Count > 0 Then
                strJSON = objDRs_Qry(0).Item("Code")
                strUpload = strJSON

                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Object_Ontology.GUID.ToString)

                objSemItem_Result = upload_String(strUpload, True)
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                strJSON = objDRs_Code(0).Item("Code")
                strUpload = strJSON
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Object_Ontology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Object_Ontology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Object_Ontology.Name)

                objSemItem_Result = upload_String(strUpload)
            End If
            
        End If


        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or _
            objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            If objDRs_Qry.Count > 0 Then
                strJSON = objDRs_Qry(0).Item("Code")
                strUpload = strJSON

                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_RelationType.GUID.ToString)

                objSemItem_Result = upload_String(strUpload, True)
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                strJSON = objDRs_Code(0).Item("Code")
                strUpload = strJSON
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_RelationType.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_RelationType.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_KindOfOntology.GUID.ToString)
                strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_RelationType.Name)

                objSemItem_Result = upload_String(strUpload)
            End If
            

        End If

        Return objSemItem_Result
    End Function

    Public Function upload_String(ByVal strUpload As String, Optional ByVal boolQry As Boolean = False) As clsSemItem
        Dim objWebClient As New Net.WebClient
        Dim objWebResp As Net.WebResponse
        Dim objStream As IO.Stream
        Dim objTextRead As IO.TextReader
        Dim objTextWriter As IO.TextWriter
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Nothing
        Dim strResponse As String

        objWebClient.Headers.Add("Content-Type", "application/json")
        If SingleInstance = False Then
            objWebClient.Headers.Add("Method", "PUT")
        Else
            objWebClient.Headers.Add("Method", "POST")
            objWebClient.Headers.Add("Accept", "application/json")
        End If

        Try
            If SingleInstance = False Then
                strResponse = objWebClient.UploadString(objSemItem_Url.Name & objLocalConfig.Connection_DB.Database, strUpload)
            Else
                If boolQry = True Then
                    strResponse = objWebClient.UploadString(objSemItem_Url.Name & "/cypher", strUpload)
                Else
                    strResponse = objWebClient.UploadString(objSemItem_Url.Name & "/node", strUpload)
                End If

            End If



            If strResponse.ToLower.Contains("{""ok"":true,") Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                If Not objWebClient.ResponseHeaders.Get("Location") Is Nothing Then
                    If objWebClient.ResponseHeaders.Get("Location").Contains(objSemItem_Url.Name) Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End If
                End If

                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                    If Not strResponse = Nothing Then
                        If strResponse.Contains(objSemItem_Url.Name) Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        End If
                    End If
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If

                End If

            End If
        Catch ex As Exception
            If ex.Message.ToLower.Contains("(409)") Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Exists
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error

            End If
        End Try

        Return objSemItem_Result
    End Function

    Public Function create_Object_Rel() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_TokenToken As DataRowCollection
        Dim objDR_TokenToken As DataRow
        Dim strJSON As String
        Dim strUpload As String


        strJSON = objLocalConfig.SemItem_Token_KindOfOntology_Object_Ontology.Additional1

        objDRC_TokenToken = semtblA_Token_Token.GetData().Rows

        For Each objDR_TokenToken In objDRC_TokenToken
            strUpload = strJSON
            strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", Guid.NewGuid.ToString)
            strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_OBJECT.Name & "@", objDR_TokenToken.Item("GUID_Token_Left").ToString)
            strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_ONTOLOGY.Name & "@", objDR_TokenToken.Item("GUID_Token_Right").ToString)
            strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE_RIGHT.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Object.GUID.ToString)
            strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_RELATIONTYPE.Name & "@", objDR_TokenToken.Item("GUID_RelationType").ToString)
            strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_WEIGHT.Name & "@", objDR_TokenToken.Item("OrderID").ToString)
            strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Object_Ontology.GUID.ToString)

            objSemItem_Result = upload_String(strUpload)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function create_Attributes() As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Error
        Dim objDRC_Attributes As DataRowCollection
        Dim objDR_Attribute As DataRow
        Dim objDRs_DataType() As DataRow
        Dim objDRs_Code() As DataRow
        Dim objDRs_Qry() As DataRow
        Dim strJSON As String
        Dim strJSONQry As String
        Dim strUpload As String

        objDRs_Code = objLocalConfig.tbl_ItemsWithRest.Select("GUID_Item='" & objLocalConfig.SemItem_Token_KindOfOntology_Attribute.GUID.ToString & "' " & _
                                            "AND GUID_ProgramingLanguage='" & objSemItem_ProgramingLanguage.GUID.ToString & "'")

        If objDRs_Code.Count > 0 Then
            strJSON = objDRs_Code(0).Item("Code")

            objDRs_Qry = objLocalConfig.tbl_ItemsWithRest.Select("GUID_Item='" & objLocalConfig.SemItem_Token_Ontology_Item_qry_NodeByGUID.GUID.ToString & "' " & _
                                                              "AND GUID_ProgramingLanguage='" & objSemItem_ProgramingLanguage.GUID.ToString & "'")
            If objDRs_Qry.Count > 0 Then
                strJSONQry = objDRs_Qry(0).Item("Code")
            End If

            objDRC_Attributes = semtblA_Attribute.GetData().Rows
            For Each objDR_Attribute In objDRC_Attributes
                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

                If objDRs_Qry.Count > 0 Then
                    strUpload = strJSONQry
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objDR_Attribute.Item("GUID_Attribute").ToString)

                    objSemItem_Result = upload_String(strUpload, True)
                End If


                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    Select Case objDR_Attribute.Item("GUID_AttributeType")
                        Case objLocalConfig.Globals.AttributeType_Bool.GUID
                            objDRs_DataType = objLocalConfig.tbl_DataTypes.Select("Name_Token_Left='bit'")
                        Case objLocalConfig.Globals.AttributeType_Date.GUID
                            objDRs_DataType = objLocalConfig.tbl_DataTypes.Select("Name_Token_Left='datetime'")
                        Case objLocalConfig.Globals.AttributeType_Datetime.GUID
                            objDRs_DataType = objLocalConfig.tbl_DataTypes.Select("Name_Token_Left='datetime'")
                        Case objLocalConfig.Globals.AttributeType_Int.GUID
                            objDRs_DataType = objLocalConfig.tbl_DataTypes.Select("Name_Token_Left='int'")
                        Case objLocalConfig.Globals.AttributeType_Real.GUID
                            objDRs_DataType = objLocalConfig.tbl_DataTypes.Select("Name_Token_Left='real'")
                        Case objLocalConfig.Globals.AttributeType_String.GUID
                            objDRs_DataType = objLocalConfig.tbl_DataTypes.Select("Name_Token_Left='string'")
                        Case objLocalConfig.Globals.AttributeType_Time.GUID
                            objDRs_DataType = objLocalConfig.tbl_DataTypes.Select("Name_Token_Left='datetime'")
                        Case objLocalConfig.Globals.AttributeType_Varchar255.GUID
                            objDRs_DataType = objLocalConfig.tbl_DataTypes.Select("Name_Token_Left='string'")
                    End Select

                    strUpload = strJSON
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objDR_Attribute.Item("GUID_Attribute").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objDR_Attribute.Item("GUID_Attribute").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", HttpUtility.UrlEncode(objDR_Attribute.Item("Name_Attribute")))
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_DATATYPE.Name & "@", objDRs_DataType(0).Item("GUID_Token_Left").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Attribute.GUID.ToString)

                    objSemItem_Result = upload_String(strUpload)

                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        Exit For
                    End If
                End If
                
            Next
        End If

        



        Return objSemItem_Result
    End Function

    Public Function create_RelationTypes() As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Error
        Dim objDRC_RelationTypes As DataRowCollection
        Dim objDR_RelationType As DataRow
        Dim objDRs_DataType() As DataRow
        Dim objDRs_Code() As DataRow
        Dim objDRs_Qry() As DataRow
        Dim strJSON As String
        Dim strJSONQry As String
        Dim strUpload As String

        objDRs_Code = objLocalConfig.tbl_ItemsWithRest.Select("GUID_Item='" & objLocalConfig.SemItem_Token_KindOfOntology_RelationType.GUID.ToString & "' " & _
                                            "AND GUID_ProgramingLanguage='" & objSemItem_ProgramingLanguage.GUID.ToString & "'")

        If objDRs_Code.Count > 0 Then
            strJSON = objDRs_Code(0).Item("Code")

            objDRs_Qry = objLocalConfig.tbl_ItemsWithRest.Select("GUID_Item='" & objLocalConfig.SemItem_Token_Ontology_Item_qry_NodeByGUID.GUID.ToString & "' " & _
                                                              "AND GUID_ProgramingLanguage='" & objSemItem_ProgramingLanguage.GUID.ToString & "'")
            If objDRs_Qry.Count > 0 Then
                strJSONQry = objDRs_Qry(0).Item("Code")
            End If

            objDRC_RelationTypes = semtblA_RelationType.GetData().Rows
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
            For Each objDR_RelationType In objDRC_RelationTypes
                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

                If objDRs_Qry.Count > 0 Then
                    strUpload = strJSONQry
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objDR_RelationType.Item("GUID_RelationType").ToString)

                    objSemItem_Result = upload_String(strUpload, True)
                End If


                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    strUpload = strJSON
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objDR_RelationType.Item("GUID_RelationType").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objDR_RelationType.Item("GUID_RelationType").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", HttpUtility.UrlEncode(objDR_RelationType.Item("Name_RelationType")))
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_RelationType.GUID.ToString)

                    objSemItem_Result = upload_String(strUpload)

                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        Exit For
                    End If
                End If
                
            Next
        End If

        



        Return objSemItem_Result
    End Function


    Public Function create_Class() As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Error
        Dim objDRC_Types As DataRowCollection
        Dim objDR_Type As DataRow
        Dim objDRs_DataType() As DataRow
        Dim objDRs_Code() As DataRow
        Dim objDRs_QRY() As DataRow
        Dim strJSON As String
        Dim strJSONQry As String
        Dim strUpload As String

        objDRs_Code = objLocalConfig.tbl_ItemsWithRest.Select("GUID_Item='" & objLocalConfig.SemItem_Token_KindOfOntology_Class.GUID.ToString & "' " & _
                                            "AND GUID_ProgramingLanguage='" & objSemItem_ProgramingLanguage.GUID.ToString & "'")

        If objDRs_Code.Count > 0 Then
            strJSON = objDRs_Code(0).Item("Code")

            objDRs_QRY = objLocalConfig.tbl_ItemsWithRest.Select("GUID_Item='" & objLocalConfig.SemItem_Token_Ontology_Item_qry_NodeByGUID.GUID.ToString & "' " & _
                                                              "AND GUID_ProgramingLanguage='" & objSemItem_ProgramingLanguage.GUID.ToString & "'")
            If objDRs_QRY.Count > 0 Then
                strJSONQry = objDRs_QRY(0).Item("Code")
            End If

            objDRC_Types = semtblA_Type.GetData().Rows
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
            For Each objDR_Type In objDRC_Types
                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

                If objDRs_QRY.Count > 0 Then
                    strUpload = strJSONQry
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objDR_Type.Item("GUID_Type").ToString)

                    objSemItem_Result = upload_String(strUpload, True)
                End If


                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    strUpload = strJSON
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objDR_Type.Item("GUID_Type").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objDR_Type.Item("GUID_Type").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", HttpUtility.UrlEncode(objDR_Type.Item("Name_Type")))
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_PARENT.Name & "@", objDR_Type.Item("GUID_Type_Parent").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Class.GUID.ToString)

                    objSemItem_Result = upload_String(strUpload)

                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        Exit For
                    End If
                End If
                
            Next




        End If

        Return objSemItem_Result
    End Function
    Public Function create_Object_To_Class() As clsSemItem

    End Function
    Public Function create_Object() As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Nothing
        Dim objDRC_Tokens As DataRowCollection
        Dim objDR_Token As DataRow
        Dim objDRs_DataToken() As DataRow
        Dim objDRs_Code() As DataRow
        Dim objDRs_Qry() As DataRow
        Dim strJSON As String
        Dim strJSONQry As String
        Dim strUpload As String


        objDRs_Code = objLocalConfig.tbl_ItemsWithRest.Select("GUID_Item='" & objLocalConfig.SemItem_Token_KindOfOntology_Class.GUID.ToString & "' " & _
                                            "AND GUID_ProgramingLanguage='" & objSemItem_ProgramingLanguage.GUID.ToString & "'")

        If objDRs_Code.Count > 0 Then
            strJSON = objDRs_Code(0).Item("Code")
            objDRC_Tokens = semtblA_Token.GetData().Rows

            objDRs_Qry = objLocalConfig.tbl_ItemsWithRest.Select("GUID_Item='" & objLocalConfig.SemItem_Token_Ontology_Item_qry_NodeByGUID.GUID.ToString & "' " & _
                                                              "AND GUID_ProgramingLanguage='" & objSemItem_ProgramingLanguage.GUID.ToString & "'")
            If objDRs_Qry.Count > 0 Then
                strJSONQry = objDRs_Qry(0).Item("Code")
            End If

            objSemItem_Result = objLocalConfig.Globals.LogState_Error
            For Each objDR_Token In objDRC_Tokens
                

                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

                If objDRs_Qry.Count > 0 Then
                    strUpload = strJSONQry
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objDR_Token.Item("GUID_Token").ToString)

                    objSemItem_Result = upload_String(strUpload, True)
                End If


                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    strUpload = strJSON
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID.Name & "@", objDR_Token.Item("GUID_Token").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_id.Name & "@", objDR_Token.Item("GUID_Token").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME.Name & "@", HttpUtility.UrlEncode(objDR_Token.Item("Name_Token")))
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_CLASS.Name & "@", objDR_Token.Item("GUID_Type").ToString)
                    strUpload = strUpload.Replace("@" & objLocalConfig.SemItem_Token_Variable_ID_TYPE.Name & "@", objLocalConfig.SemItem_Token_KindOfOntology_Object.GUID.ToString)

                    objSemItem_Result = upload_String(strUpload)

                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        Exit For
                    End If
                End If
                
            Next
        End If
        



        Return objSemItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_RelationType.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB
        semtblA_Token.Connection = objLocalConfig.Connection_DB

        semtblA_Token_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

        procA_GraphDBs.Connection = objLocalConfig.Connection_Plugin
    End Sub
End Class

