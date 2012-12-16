Imports System.Web
Imports Sem_Manager
Imports Filesystem_Management
Public Class clsRDFWork
    Private Const cstrPath_Attributes As String = "%TEMP%\rdfoutput.txt"

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_XMLText As New ds_RDFModuleTableAdapters.proc_XMLTextTableAdapter
    Private procA_Url_Of_Baseconfig As New ds_RDFModuleTableAdapters.proc_Url_Of_BaseconfigTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private semtblA_AttributeType As New ds_SemDBTableAdapters.semtbl_AttributeTypeTableAdapter
    Private semtblT_AttributeType As New ds_SemDB.semtbl_AttributeTypeDataTable
    Private objLocalConfig As clsLocalConfig

    Private objSemWork As clsSemWork
    Private objSemItem_Ontology As clsSemItem
    Private strUrl As String
    Private objTextStream As IO.TextWriter

    Private objSemItem_File As clsSemItem

    Private objBlobConnection As clsBlobConnection

    Private GUID_TokenAttribute_SyncNeccesary As Guid

    Private strXML_Attribute As String
    Private strXML_Type As String
    Private strXML_Token As String
    Private strXML_RelationType As String
    Private strXML_TypeType As String
    Private strXML_TokenToken As String
    Private strXML_TokenAttribute As String
    Private strXML_ContainerDoc As String

    Public ReadOnly Property XML_Attribute As String
        Get
            Return strXML_Attribute
        End Get
    End Property

    Public ReadOnly Property XML_Type As String
        Get
            Return strXML_Type
        End Get
    End Property

    Public ReadOnly Property XML_Token As String
        Get
            Return strXML_Token
        End Get
    End Property

    Public ReadOnly Property XML_RelationType As String
        Get
            Return strXML_RelationType
        End Get
    End Property

    Public ReadOnly Property XML_TypeType As String
        Get
            Return strXML_TypeType
        End Get
    End Property

    Public ReadOnly Property XML_TokenToken As String
        Get
            Return strXML_TokenToken
        End Get
    End Property

    Public ReadOnly Property XML_TokenAttribute As String
        Get
            Return strXML_TokenAttribute
        End Get
    End Property

    Public ReadOnly Property XML_ContainerDoc As String
        Get
            Return strXML_ContainerDoc
        End Get
    End Property
    Public Sub New()
        objLocalConfig = New clsLocalConfig(New clsGlobals)

        set_DBConnection()

        get_XMLTexts()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)

        set_DBConnection()

        get_XMLTexts()
    End Sub

    Private Function get_URL_Ontologies() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_URL As DataRowCollection

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_URL = procA_Url_Of_Baseconfig.GetData(objLocalConfig.SemItem_Type_Url.GUID, _
                                                     objLocalConfig.SemItem_RelationType_Ontologies_located_at.GUID, _
                                                     objLocalConfig.SemItem_Token_RDF_Module_Base_Config.GUID).Rows
        If objDRC_URL.Count > 0 Then
            strUrl = objDRC_URL(0).Item("Name_Url")
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function add_Attribute(ByVal objSemItem_Attribute As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        If objSemWork.add_Attribute(objSemItem_Attribute.GUID) = True Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function add_RelationType(ByVal objSemItem_RelationType As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        If objSemWork.add_RelationType(objSemItem_RelationType.GUID) = True Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function add_Type(ByVal objSemItem_Type As clsSemItem, ByVal boolGetParent As Boolean, ByVal boolChilds As Boolean, ByVal boolRels As Boolean) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemWork.Relations = boolRels

        If objSemWork.add_Type(objSemItem_Type.GUID, boolGetParent, boolChilds) = True Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function add_Token(ByVal objSemItem_Token As clsSemItem, ByVal boolRels As Boolean) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemWork.Relations = boolRels

        If objSemWork.add_Token(objSemItem_Token.GUID) = True Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Private Sub set_DBConnection()

        semtblA_Token.Connection = objLocalConfig.Connection_DB

        procA_XMLText.Connection = objLocalConfig.Connection_Plugin
        procA_Url_Of_Baseconfig.Connection = objLocalConfig.Connection_Plugin
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        semtblA_AttributeType.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        semtblA_AttributeType.Fill(semtblT_AttributeType)

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)

        objSemWork = New clsSemWork(objLocalConfig.Globals)

    End Sub

    Public Function create_RDF(ByVal SemItem_Ontology As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_File As clsSemItem
        Dim objDRC_File As DataRowCollection
        Dim strPath As String

        objSemItem_Ontology = SemItem_Ontology
        objSemItem_Result = get_URL_Ontologies()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            strPath = Environment.ExpandEnvironmentVariables(cstrPath_Attributes)
            objTextStream = New IO.StreamWriter(strPath, False)
            objSemItem_Result = create_RDF_Container_Header()
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = create_RDF_Attributes()
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = create_RDF_RelationTypes()
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = create_RDF_Type()
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = create_RDF_Token()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = create_RDF_Container_Footer()
                                objSemItem_Result.Additional1 = cstrPath_Attributes

                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objTextStream.Close()
                                    objSemItem_Result = save_001_Ontology()
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objDRC_File = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Ontology.GUID, _
                                                                                                objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                                                objLocalConfig.SemItem_Type_File.GUID).Rows
                                        If objDRC_File.Count = 0 Then
                                            objSemItem_File = New clsSemItem
                                            objSemItem_File.GUID = Guid.NewGuid
                                            objSemItem_File.Name = objSemItem_Ontology.Name
                                            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                                            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                        Else
                                            objSemItem_File = New clsSemItem
                                            objSemItem_File.GUID = objDRC_File(0).Item("GUID_Token_Right")
                                            objSemItem_File.Name = objDRC_File(0).Item("Name_Token_Right")
                                            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                                            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                        End If
                                        objSemItem_Result = save_002_File(objSemItem_File)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objBlobConnection.save_File_To_Blob(objSemItem_File, cstrPath_Attributes)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = save_003_Ontology_Fo_File()
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = save_004_SyncNecessary()
                                                    If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = del_003_Ontology_To_File()
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objBlobConnection.del_Blob(objSemItem_File)
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = del_002_File()
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    del_001_Ontology()
                                                                End If

                                                            End If
                                                        End If

                                                    End If
                                                Else

                                                    objSemItem_Result = objBlobConnection.del_Blob(objSemItem_File)
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = del_002_File()
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            del_001_Ontology()
                                                        End If

                                                    End If

                                                End If
                                            Else
                                                objSemItem_Result = objBlobConnection.del_Blob(objSemItem_File)
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = del_002_File()
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        del_001_Ontology()
                                                    End If

                                                End If


                                            End If

                                        Else
                                            del_001_Ontology()

                                        End If
                                    End If

                                End If
                            End If
                        End If
                    End If
                End If
            End If


        End If
        Try
            objTextStream.Close()
        Catch ex As Exception

        End Try
        Return objSemItem_Result
    End Function

    Public Function save_001_Ontology() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Ontology As DataRowCollection
        Dim boolAdd_Ontology As Boolean

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_Ontology = semtblA_Token.GetData_Token_By_GUID(objSemItem_Ontology.GUID).Rows

        boolAdd_Ontology = True
        If objDRC_Ontology.Count > 0 Then
            boolAdd_Ontology = False
            If Not objDRC_Ontology(0).Item("Name_Token") = objSemItem_Ontology.Name Then
                boolAdd_Ontology = True
            End If
        End If

        If boolAdd_Ontology = True Then
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Ontology.GUID, objSemItem_Ontology.Name, objSemItem_Ontology.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        
        Return objSemItem_Result
    End Function

    Public Function save_002_File(ByVal SemItem_File As clsSemItem) As clsSemItem
        Dim objDRC_File As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objSemItem_File = SemItem_File
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_File = semtblA_Token.GetData_Token_By_GUID(objSemItem_File.GUID).Rows
        If objDRC_File.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_File.GUID, _
                                                                  objSemItem_File.Name, _
                                                                  objSemItem_File.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_File() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_File As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_File As DataRow

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_File = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Ontology.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                    objLocalConfig.SemItem_Type_File.GUID).Rows

        For Each objDR_File In objDRC_File
            objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objDR_File.Item("GUID_Token_Right")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Next

        Return objSemItem_Result
    End Function

    Private Function save_003_Ontology_Fo_File() As clsSemItem

        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Ontology_To_File As DataRowCollection
        Dim objDR_Ontology_To_File As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim boolAdd As Boolean


        objSemItem_Result = objLocalConfig.Globals.LogState_Success



        objDRC_Ontology_To_File = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Ontology.GUID, _
                                                                                objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                                objLocalConfig.SemItem_Type_File.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        boolAdd = True
        For Each objDR_Ontology_To_File In objDRC_Ontology_To_File
            If objDR_Ontology_To_File.Item("GUID_Token_Right") = objSemItem_File.GUID Then
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ontology.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                       objDR_Ontology_To_File.Item("GUID_Token_Right")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ontology.GUID, _
                                                                    objSemItem_File.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Source.GUID, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_Ontology_To_File() As clsSemItem

        Dim objDRC_Ontology_To_File As DataRowCollection
        Dim objDR_Ontology_To_File As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_Ontology_To_File = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Ontology.GUID, _
                                                                                objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                                objSemItem_File.GUID).Rows

        For Each objDR_Ontology_To_File In objDRC_Ontology_To_File
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ontology.GUID, _
                                                                   objSemItem_File.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belonging_Source.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_004_SyncNecessary() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_SyncNecessary As DataRowCollection
        Dim i As Integer

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_SyncNecessary = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Ontology.GUID, _
                                                                                                              objLocalConfig.SemItem_Attribute_Sync_necessary.GUID).Rows
        If objDRC_SyncNecessary.Count > 0 Then

            For i = 0 To objDRC_SyncNecessary.Count - 1
                If i = 0 Then
                    GUID_TokenAttribute_SyncNeccesary = objDRC_SyncNecessary(i).Item("GUID_TokenAttribute")
                    If objDRC_SyncNecessary(i).Item("Val") = False Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Ontology.GUID, _
                                                                                          objLocalConfig.SemItem_Attribute_Sync_necessary.GUID, _
                                                                                          GUID_TokenAttribute_SyncNeccesary, _
                                                                                          True, 0).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If
                    End If
                Else
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_SyncNecessary(i).Item("GUID_TokenAttribute")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                End If
            Next
        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Ontology.GUID, _
                                                                              objLocalConfig.SemItem_Attribute_Sync_necessary.GUID, _
                                                                              Nothing, _
                                                                              True, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                GUID_TokenAttribute_SyncNeccesary = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_SyncNecessary() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_SyncNecessary As DataRowCollection
        Dim objDR_SyncNecessary As DataRow


        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_SyncNecessary = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Ontology.GUID, _
                                                                                                              objLocalConfig.SemItem_Attribute_Sync_necessary.GUID).Rows
        For Each objDR_SyncNecessary In objDRC_SyncNecessary
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_SyncNecessary.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next
        Return objSemItem_Result
    End Function

    Public Function del_001_Ontology() As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objLocalConfig.Globals.LogState_Success



        Return objSemItem_Result
    End Function
    Private Function create_RDF_Container_Header() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim strHeader As String

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If strXML_ContainerDoc.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_LIST_AnnotationProperties.Name & "@") > -1 Then
            strHeader = strXML_ContainerDoc.Substring(0, strXML_ContainerDoc.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_LIST_AnnotationProperties.Name & "@"))
            strHeader = strHeader.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Ontology.Name & "@", objLocalConfig.SemItem_Type_Ontology.Name & "_" & objSemItem_Ontology.GUID.ToString)
            strHeader = strHeader.Replace("@" & objLocalConfig.SemItem_Token_Variable_URL_Ontology.Name & "@", strUrl)

            objTextStream.WriteLine(strHeader)
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Private Function create_RDF_Container_Footer() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim strFooter As String

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If strXML_ContainerDoc.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_LIST_Individuals.Name & "@") > -1 Then
            strFooter = strXML_ContainerDoc.Substring(strXML_ContainerDoc.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_LIST_Individuals.Name & "@") + ("@" & objLocalConfig.SemItem_Token_Variable_LIST_Individuals.Name & "@").Length)

            objTextStream.WriteLine(strFooter)
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function
    Private Function create_RDF_Attributes() As clsSemItem

        Dim objDR_Attributes As DataRow
        Dim objDRs_DataType() As DataRow

        Dim objSemItem_Result As clsSemItem
        Dim strRDFAttribute As String
        Dim strPath As String




        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Attributes In objSemWork.semtblT_Attribute.Rows
            strRDFAttribute = strXML_Attribute.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Attribute.Name & "@", objDR_Attributes.Item("GUID_Attribute").ToString)
            strRDFAttribute = strRDFAttribute.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Attribute.Name & "@", HTMLEncode(objDR_Attributes.Item("Name_Attribute").ToString))
            objDRs_DataType = semtblT_AttributeType.Select("GUID_AttributeType='" & objDR_Attributes.Item("GUID_AttributeType").ToString & "'")
            If objDRs_DataType.Count > 0 Then
                strRDFAttribute = strRDFAttribute.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME_DATATYPE.Name & "@", objDRs_DataType(0).Item("Name_AttributeType"))
            End If


            objTextStream.WriteLine(strRDFAttribute)

        Next


        Return objSemItem_Result
    End Function

    Private Function create_RDF_RelationTypes() As clsSemItem

        Dim objDR_RelationTypes As DataRow
        Dim objDRs_DataType() As DataRow

        Dim objSemItem_Result As clsSemItem
        Dim strRDFRelationType As String
        Dim strPath As String




        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_RelationTypes In objSemWork.semtblT_RelationType.Rows
            strRDFRelationType = strXML_RelationType.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_RelationType.Name & "@", objDR_RelationTypes.Item("GUID_RelationType").ToString)
            strRDFRelationType = strRDFRelationType.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_RelationType.Name & "@", HTMLEncode(objDR_RelationTypes.Item("Name_RelationType").ToString))
            objDRs_DataType = objSemWork.semtblT_RelationType.Select("GUID_RelationType='" & objDR_RelationTypes.Item("GUID_RelationType").ToString & "'")
            If objDRs_DataType.Count > 0 Then
                strRDFRelationType = strRDFRelationType.Replace("@" & objLocalConfig.SemItem_Token_Variable_NAME_DATATYPE.Name & "@", objDRs_DataType(0).Item("Name_RelationType"))
            End If


            objTextStream.WriteLine(strRDFRelationType)

        Next


        Return objSemItem_Result
    End Function

    Private Function create_RDF_Type() As clsSemItem
        Dim objSemItem_Result As clsSemItem

        Dim objDR_Type As DataRow
        Dim objDRs_TypeType() As DataRow
        Dim objDR_TypeType As DataRow
        Dim strRDF_Type As String = ""
        Dim strRDF_Type_Type As String = ""
        Dim strRDF_Type_Type_tmp As String

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Type In objSemWork.semtblT_Type.Rows
            strRDF_Type = strXML_Type.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", objDR_Type.Item("GUID_Type").ToString)
            strRDF_Type = strRDF_Type.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Type.Name & "@", HTMLEncode(objDR_Type.Item("Name_Type").ToString))

            objDRs_TypeType = objSemWork.semtblT_Type_Type.Select("GUID_Type_Left='" & objDR_Type.Item("GUID_Type").ToString & "'")
            strRDF_Type_Type = ""
            If objDRs_TypeType.Count > 0 Then
                For Each objDR_TypeType In objDRs_TypeType
                    strRDF_Type_Type_tmp = strXML_TypeType.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_RelationType.Name & "@", objDR_TypeType.Item("GUID_RelationType").ToString)
                    strRDF_Type_Type_tmp = strRDF_Type_Type_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type_Right.Name & "@", objDR_TypeType.Item("GUID_Type_Right").ToString)
                    strRDF_Type_Type_tmp = strRDF_Type_Type_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_Min.Name & "@", objDR_TypeType.Item("Min_forw"))
                    strRDF_Type_Type_tmp = strRDF_Type_Type_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_Max.Name & "@", objDR_TypeType.Item("Max_forw"))
                    strRDF_Type_Type = strRDF_Type_Type & strRDF_Type_Type_tmp & vbCrLf
                Next

            End If
            strRDF_Type = strRDF_Type.Replace("@" & objLocalConfig.SemItem_Token_Variable_LIST_Type_Relations.Name & "@", strRDF_Type_Type)
            objTextStream.WriteLine(strRDF_Type)
        Next



        Return objSemItem_Result
    End Function

    Private Function create_RDF_Token() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDR_Token As DataRow
        Dim objDRs_TokenAttribute() As DataRow
        Dim objDR_TokenAttribute As DataRow
        Dim objDRC_Attribute As DataRowCollection
        Dim objDRs_TokenToken() As DataRow
        Dim objDR_TokenToken As DataRow
        Dim strRDF_Token As String = ""
        Dim strRDF_TokenAttribute_tmp As String
        Dim strRDF_TokenAttribute As String
        Dim strRDF_TokenToken_tmp As String
        Dim strRDF_TokenToken As String

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Token In objSemWork.semtblT_Token.Rows
            strRDF_Token = strXML_Token.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Token.Name & "@", objDR_Token.Item("GUID_Token").ToString)
            strRDF_Token = strRDF_Token.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Type.Name & "@", objDR_Token.Item("GUID_Type").ToString)
            strRDF_Token = strRDF_Token.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Token.Name & "@", objDR_Token.Item("Name_Token"))
            objDRs_TokenAttribute = objSemWork.semtblT_Token_Attribute.Select("GUID_Token='" & objDR_Token.Item("GUID_Token").ToString & "'")
            strRDF_TokenAttribute = ""
            strRDF_TokenToken = ""
            If objDRs_TokenAttribute.Count > 0 Then
                For Each objDR_TokenAttribute In objDRs_TokenAttribute
                    strRDF_TokenAttribute_tmp = strXML_TokenAttribute.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Ontology.Name & "@", objSemItem_Ontology.Name.ToString)
                    strRDF_TokenAttribute_tmp = strRDF_TokenAttribute_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Attribute.Name & "@", objDR_TokenAttribute.Item("GUID_Attribute").ToString)
                    objDRC_Attribute = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objDR_TokenAttribute.Item("GUID_TokenAttribute"), _
                                                                                                                      objDR_TokenAttribute.Item("GUID_Attribute")).Rows
                    If objDRC_Attribute.Count > 0 Then
                        Select Case objDRC_Attribute(0).Item("GUID_AttributeType")
                            Case objLocalConfig.Globals.AttributeType_Bool.GUID
                                strRDF_TokenAttribute_tmp = strRDF_TokenAttribute_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_Val_Attribute.Name & "@", objDRC_Attribute(0).Item("VAL_BOOL"))
                            Case objLocalConfig.Globals.AttributeType_Date.GUID
                                strRDF_TokenAttribute_tmp = strRDF_TokenAttribute_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_Val_Attribute.Name & "@", objDRC_Attribute(0).Item("VAL_DATE"))
                            Case objLocalConfig.Globals.AttributeType_Datetime.GUID
                                strRDF_TokenAttribute_tmp = strRDF_TokenAttribute_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_Val_Attribute.Name & "@", objDRC_Attribute(0).Item("VAL_Named"))
                            Case objLocalConfig.Globals.AttributeType_Int.GUID
                                strRDF_TokenAttribute_tmp = strRDF_TokenAttribute_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_Val_Attribute.Name & "@", objDRC_Attribute(0).Item("VAL_INT"))
                            Case objLocalConfig.Globals.AttributeType_Real.GUID
                                strRDF_TokenAttribute_tmp = strRDF_TokenAttribute_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_Val_Attribute.Name & "@", objDRC_Attribute(0).Item("VAL_REAL"))
                            Case objLocalConfig.Globals.AttributeType_Time.GUID
                                strRDF_TokenAttribute_tmp = strRDF_TokenAttribute_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_Val_Attribute.Name & "@", objDRC_Attribute(0).Item("VAL_TIME"))
                            Case objLocalConfig.Globals.AttributeType_String.GUID
                                strRDF_TokenAttribute_tmp = strRDF_TokenAttribute_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_Val_Attribute.Name & "@", objDRC_Attribute(0).Item("VAL_VARCHARMAX"))
                            Case objLocalConfig.Globals.AttributeType_Varchar255.GUID
                                strRDF_TokenAttribute_tmp = strRDF_TokenAttribute_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_Val_Attribute.Name & "@", objDRC_Attribute(0).Item("VAL_VARCHAR255"))
                        End Select

                        strRDF_TokenAttribute = strRDF_TokenAttribute & strRDF_TokenAttribute_tmp & vbCrLf

                    End If



                Next

                objDRs_TokenToken = objSemWork.semtblT_Token_Token.Select("GUID_Token_Left='" & objDR_Token.Item("GUID_Token") & "'")

                For Each objDR_TokenToken In objDRs_TokenToken
                    strRDF_TokenToken_tmp = strXML_TokenToken.Replace("@" & objLocalConfig.SemItem_Token_Variable_Name_Ontology.Name & "@", objSemItem_Ontology.Name.ToString)
                    strRDF_TokenToken_tmp = strRDF_TokenToken_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_RelationType.Name & "@", objDR_TokenToken.Item("GUID_RelationType").ToString)
                    strRDF_TokenToken_tmp = strRDF_TokenToken_tmp.Replace("@" & objLocalConfig.SemItem_Token_Variable_GUID_Token.Name & "@", objDR_TokenToken.Item("GUID_Token_Right").ToString)
                    strRDF_TokenToken = strRDF_TokenToken & strRDF_TokenToken_tmp & vbCrLf
                Next


            End If
            strRDF_Token = strRDF_Token.Replace("@" & objLocalConfig.SemItem_Token_Variable_LIST_Token_Token.Name & "@", strRDF_TokenToken)
            strRDF_Token = strRDF_Token.Replace("@" & objLocalConfig.SemItem_Token_Variable_LIST_Token_Attribute.Name & "@", strRDF_TokenAttribute)
            objTextStream.WriteLine(strRDF_Token)
        Next

        Return objSemItem_Result
    End Function

    Private Function HTMLEncode(ByVal Text As String) As String
        Dim i As Integer
        Dim acode As Integer
        Dim repl As String

        HTMLEncode = Text

        For i = Len(HTMLEncode) To 1 Step -1
            acode = Asc(Mid$(HTMLEncode, i, 1))
            Select Case acode
                Case 32
                    repl = "&nbsp;"
                Case 34
                    repl = "&quot;"
                Case 38
                    repl = "&amp;"
                Case 60
                    repl = "&lt;"
                Case 62
                    repl = "&gt;"
                Case 32 To 127
                    ' don't touch alphanumeric chars
                Case Else
                    repl = "&#" & CStr(acode) & ";"
            End Select
            If Len(repl) Then
                HTMLEncode = Left$(HTMLEncode, i - 1) & repl & Mid$(HTMLEncode, _
                    i + 1)
                repl = ""
            End If
        Next
    End Function


    Private Sub get_XMLTexts()
        strXML_ContainerDoc = get_Content(objLocalConfig.SemItem_Token_XML_RDF__Container_Doc.GUID)
        strXML_Attribute = get_Content(objLocalConfig.SemItem_Token_XML_RDF__Attribute.GUID)
        strXML_RelationType = get_Content(objLocalConfig.SemItem_Token_XML_RDF__RelationType.GUID)
        strXML_Type = get_Content(objLocalConfig.SemItem_Token_XML_RDF__Class.GUID)
        strXML_TypeType = get_Content(objLocalConfig.SemItem_Token_XML_RDF__Type_Type.GUID)
        strXML_Token = get_Content(objLocalConfig.SemItem_Token_XML_RDF__Token.GUID)
        strXML_TokenAttribute = get_Content(objLocalConfig.SemItem_Token_XML_RDF__Token_Attribute.GUID)
        strXML_TokenToken = get_Content(objLocalConfig.SemItem_Token_XML_RDF__Token_Token.GUID)

    End Sub

    Private Function get_Content(ByVal GUID_Template As Guid) As String
        Dim objXML As New Xml.XmlDocument
        Dim objXMLNodeList As Xml.XmlNodeList
        Dim objXMLElement As Xml.XmlElement
        Dim objDRC_XMLText As DataRowCollection
        Dim strXML As String = Nothing

        objDRC_XMLText = procA_XMLText.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                               objLocalConfig.SemItem_Type_XML.GUID, _
                                               GUID_Template).Rows
        If objDRC_XMLText.Count > 0 Then
            strXML = objDRC_XMLText(0).Item("XMLText")
            Try
                objXML.LoadXml(strXML)
                objXMLNodeList = objXML.GetElementsByTagName("data")
                If objXMLNodeList.Count > 0 Then
                    objXMLElement = objXMLNodeList(0)
                    strXML = objXMLElement.InnerText
                End If
            Catch ex As Exception

            End Try

        End If

        Return strXML
    End Function
End Class
