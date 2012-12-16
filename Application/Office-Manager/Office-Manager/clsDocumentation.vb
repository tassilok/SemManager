Imports Sem_Manager
Imports Filesystem_Management
Public Class clsDocumentation
    Private procA_StandardTemplate_Of_Module_Office As New ds_OfficeModuleTableAdapters.proc_StandardTemplate_Of_Module_OfficeTableAdapter
    Private procA_Template_Of_ObjectReference As New ds_OfficeModuleTableAdapters.proc_Template_Of_ObjectReferenceTableAdapter

    'Private strPath_Docs As String
    'Private strPath_Templates As String
    'Private strPath_StandardTemplate As String

    Private objLocalConfig As clsLocalConfig

    Private objTransactionDocument As clsTransaction_Document
    Private objTransaction_ContentObject As clsTransaction_ContentObject

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtblA_TokenToken As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private semprocA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private semprocA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private semprocA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private semprocA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter

    Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter

    Private objFileWork As clsFileWork
    Private objWordWork As clsWordWork
    Private objBlobConnection As clsBlobConnection

    Private objSemItem_Std_Template As clsSemItem
    Private objSemItem_Extension_WordDoc As clsSemItem
    Private objSemItem_Extension_WordTempl As clsSemItem
    Private objSemItem_Ref_For_Template As clsSemItem
    Private objSemItem_Folder_Docs As New clsSemItem

    Private boolDocUsable As Boolean
    Private boolVisible As Boolean

    Public Property Visible() As Boolean
        Get
            Return boolVisible
        End Get
        Set(ByVal value As Boolean)
            boolVisible = value

            objWordWork.Visible = value
            
        End Set
    End Property

    Public ReadOnly Property DocUsable() As Boolean
        Get
            Return boolDocUsable
        End Get
    End Property

    Public Sub New(ByVal objGlobals As clsGlobals)

        objLocalConfig = New clsLocalConfig(objGlobals)
        initialize()


    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()

        'get_DocumentFolders()
        get_Extensions()
        get_StandardTemplate()
    End Sub

    Private Sub set_DBConnection()

        procA_StandardTemplate_Of_Module_Office.Connection = objLocalConfig.Connection_Plugin
        procA_Template_Of_ObjectReference.Connection = objLocalConfig.Connection_Plugin

        semprocA_DBWork_Save_OR_Attribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_OR_RelationType.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_OR_Type.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB

        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB
        semtblA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB

        semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB

        objFileWork = New clsFileWork(objLocalConfig.Globals)
        objTransactionDocument = New clsTransaction_Document(objLocalConfig)
        objWordWork = New clsWordWork
        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
        objTransaction_ContentObject = New clsTransaction_ContentObject(objLocalConfig)
    End Sub

    Public Function open_BlobDirWatcher() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        objSemItem_Result = objFileWork.open_BlobWatcher

        Return objSemItem_Result
    End Function
    Private Sub get_Extensions()
        Dim objDRC_Extension As DataRowCollection

        objDRC_Extension = funcA_TokenToken.GetData_TokenToken_LeftRight(objLocalConfig.SemItem_Token_Document_Type__managed__Winword_2007_Document.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_isDescribedBy.GUID, _
                                                                         objLocalConfig.SemItem_Type_Extensions.GUID).Rows
        If objDRC_Extension.Count > 0 Then
            objSemItem_Extension_WordDoc = New clsSemItem
            objSemItem_Extension_WordDoc.GUID = objDRC_Extension(0).Item("GUID_Token_Right")
            objSemItem_Extension_WordDoc.Name = objDRC_Extension(0).Item("Name_Token_Right")
            objSemItem_Extension_WordDoc.GUID_Parent = objLocalConfig.SemItem_Type_Extensions.GUID
            objSemItem_Extension_WordDoc.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_Extension = funcA_TokenToken.GetData_TokenToken_LeftRight(objLocalConfig.SemItem_Token_Document_Type__managed__Winword_2007_Template.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_isDescribedBy.GUID, _
                                                                             objLocalConfig.SemItem_Type_Extensions.GUID).Rows
            If objDRC_Extension.Count > 0 Then
                objSemItem_Extension_WordTempl = New clsSemItem
                objSemItem_Extension_WordTempl.GUID = objDRC_Extension(0).Item("GUID_Token_Right")
                objSemItem_Extension_WordTempl.Name = objDRC_Extension(0).Item("Name_Token_Right")
                objSemItem_Extension_WordTempl.GUID_Parent = objLocalConfig.SemItem_Type_Extensions.GUID
                objSemItem_Extension_WordTempl.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                boolDocUsable = True
            Else
                boolDocUsable = False
            End If
        Else
            boolDocUsable = False
        End If
    End Sub

    Private Sub get_StandardTemplate()
        Dim objDRC_StandardTempl As DataRowCollection



        objDRC_StandardTempl = procA_StandardTemplate_Of_Module_Office.GetData(objLocalConfig.SemItem_Type_Word_Templates.GUID, _
                                                                               objLocalConfig.SemItem_Type_File.GUID, _
                                                                               objLocalConfig.SemItem_RelationType_Standard.GUID, _
                                                                               objLocalConfig.SemItem_RelationType_is.GUID, _
                                                                               objLocalConfig.SemIteM_BaseConfig.GUID).Rows

        If objDRC_StandardTempl.Count > 0 Then
            objSemItem_Std_Template = New clsSemItem
            objSemItem_Std_Template.GUID = objDRC_StandardTempl(0).Item("GUID_File")
            objSemItem_Std_Template.Name = objDRC_StandardTempl(0).Item("Name_File")
            objSemItem_Std_Template.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_Std_Template.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            If objFileWork.is_File_Blob(objSemItem_Std_Template) = True Then
                objSemItem_Std_Template.Mark = True
            Else

                objSemItem_Std_Template.Additional1 = objFileWork.get_Path_FileSystemObject(objSemItem_Std_Template)
            End If
            'strPath_StandardTemplate = objFileWork.get_Path_FileSystemObject(objSemItem_File)
            boolDocUsable = True

        Else
            objSemItem_Std_Template = Nothing
            boolDocUsable = False
        End If
    End Sub

    Private Function fill_ConentObjects(ByVal objContentObject As clsContentObject, ByVal intDocID As Integer, ByVal objSemItem_ContentObject As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        Return objSemItem_Result
    End Function

    Public Function refresh_DBContent(ByVal intDocID As Integer) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objContentObjects() As clsContentObject
        Dim objContentObject As clsContentObject
        Dim objDRC_Content As DataRowCollection
        Dim objDRC_Document As DataRowCollection
        Dim strGUID As String
        Dim objSemItem_Document As clsSemItem
        Dim objSemItem_ContentObject As clsSemItem

        objContentObjects = objWordWork.get_ContentObjects(intDocID)
        If Not objContentObjects Is Nothing Then

            For Each objContentObject In objContentObjects
                If objLocalConfig.Globals.is_GUID(objContentObject.ContentControl.Title) Then
                    strGUID = objContentObject.Name_Doc
                    If strGUID.Contains(".") Then
                        strGUID = strGUID.Substring(0, strGUID.IndexOf(".") - 1)
                    End If
                    If objLocalConfig.Globals.is_GUID(strGUID) Then
                        objSemItem_Document = New clsSemItem
                        objSemItem_Document.GUID = New Guid(strGUID)
                        objDRC_Document = semtblA_Token.GetData_Token_By_GUID(objSemItem_Document.GUID).Rows
                        If objDRC_Document.Count > 0 Then
                            If objDRC_Document(0).Item("GUID_Type") = objLocalConfig.SemItem_Type_Managed_Document.GUID Then
                                objSemItem_Document.Name = objDRC_Document(0).Item("Name_Token")
                                objSemItem_Document.GUID_Parent = objDRC_Document(0).Item("GUID_Type")
                                objSemItem_Document.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objDRC_Content = semtblA_Token.GetData_Token_By_GUID(New Guid(objContentObject.ContentControl.Title)).Rows
                                If objDRC_Content.Count > 0 Then

                                    Select Case objDRC_Content(0).Item("GUID_Type")
                                        Case objLocalConfig.SemItem_Type_ContentObject.GUID
                                            objSemItem_ContentObject = New clsSemItem
                                            objSemItem_ContentObject.GUID = objDRC_Content(0).Item("GUID_Token")
                                            objSemItem_ContentObject.Name = objDRC_Content(0).Item("Name_Token")
                                            objSemItem_ContentObject.GUID_Parent = objLocalConfig.SemItem_Type_ContentObject.GUID
                                            objSemItem_ContentObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                            objSemItem_Result = objTransaction_ContentObject.save_003_ContentObject_To_ManagedDoc(objSemItem_Document, objSemItem_ContentObject)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = fill_ConentObjects(objContentObject, intDocID, objSemItem_ContentObject)
                                            Else
                                                'Fehlerbehandlung
                                            End If

                                    End Select


                                End If
                            End If

                        End If

                    End If

                End If




            Next
        End If
        Return objSemItem_Result
    End Function

    

    Public Function open_Document(ByVal objSemItem_Ref As clsSemItem) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Document As DataRowCollection
        Dim objDRC_Category As DataRowCollection
        Dim objSemItem_Document As clsSemItem = Nothing
        Dim objSemItem_Template As clsSemItem
        Dim objSemItem_WordDoc As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim strCategory As String
        Dim strPath_Document As String
        Dim GUID_ObjectReference As Guid
        Dim date_LastAccess As Date
        Dim strPath_Template As String

        strCategory = ""
        objSemItem_Ref_For_Template = New clsSemItem
        'Typ der Referenz auswählen und anhand dessen die Vorlagen.
        Select Case objSemItem_Ref.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_Attribute.GetData(objSemItem_Ref.GUID).Rows
                objSemItem_Ref_For_Template = objLocalConfig.Globals.ObjectReferenceType_Attribute
                strCategory = objLocalConfig.Globals.ObjectReferenceType_Attribute.Name
            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_RelationType.GetData(objSemItem_Ref.GUID).Rows
                objSemItem_Ref_For_Template = objLocalConfig.Globals.ObjectReferenceType_RelationType
                strCategory = objLocalConfig.Globals.ObjectReferenceType_RelationType.Name
            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_Token.GetData(objSemItem_Ref.GUID).Rows
                objDRC_Category = semtblA_Type.GetData_By_GUID(objSemItem_Ref.GUID_Parent).Rows
                If objDRC_Category.Count > 0 Then
                    objSemItem_Ref_For_Template = New clsSemItem
                    objSemItem_Ref_For_Template.GUID = objDRC_Category(0).Item("GUID_Type")
                    objSemItem_Ref_For_Template.Name = objDRC_Category(0).Item("Name_Type")
                    objSemItem_Ref_For_Template.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                    strCategory = objDRC_Category(0).Item("Name_Type")
                End If
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objSemItem_Ref_For_Template = objLocalConfig.Globals.ObjectReferenceType_Type
                objDRC_LogState = semprocA_DBWork_Save_OR_Type.GetData(objSemItem_Ref.GUID).Rows
                strCategory = objLocalConfig.Globals.ObjectReferenceType_Type.Name
        End Select

        'Die Ref für die Vorlage wurde ermittelt
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Or _
            objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Exists.GUID Then

            'Die Vorlage des Items ermitteln.
            objSemItem_Template = get_Template(objSemItem_Ref)


            If Not objSemItem_Template Is Nothing Then
                'Vorlage nicht ermittelt: Die Allgemeine Vorlage benutzen
                objSemItem_Template.Additional1 = objFileWork.merge_paths("%temp%", objSemItem_Template.Name, "\")
            End If

            'Objekt-Referenz des Items ermitteln
            GUID_ObjectReference = objDRC_LogState(0).Item("GUID_ObjectReference")

            'Gibt es ein Dokument, dass dem Item bereits zugeordnet ist?
            objDRC_Document = funcA_Token_OR.GetData_By_GUIDOR_And_GUIDRelType_And_GUIDType(objLocalConfig.SemItem_Type_Managed_Document.GUID, _
                                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                            GUID_ObjectReference).Rows
            If objDRC_Document.Count = 0 Then
                'Es existiert kein Dokument, dass dem Item zugeordnet ist.
                objSemItem_Document = New clsSemItem
                objSemItem_Document.GUID = Guid.NewGuid
                objSemItem_Document.Name = objSemItem_Ref.Name
                objSemItem_Document.GUID_Parent = objLocalConfig.SemItem_Type_Managed_Document.GUID
                objSemItem_Document.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                'Dokument speichern
                objSemItem_Result = objTransactionDocument.save_001_Document(objSemItem_Document)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    'Den Dokument-Typ dem Dokument zuordnen
                    objSemItem_Result = objTransactionDocument.save_002_Document_To_DocumentType(objLocalConfig.SemItem_Token_Document_Type__managed__Winword_2007_Document)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                        'Die zum Dokument zugehörige Datei.
                        objSemItem_WordDoc.GUID = Guid.NewGuid
                        objSemItem_WordDoc.Name = objSemItem_WordDoc.GUID.ToString & "." & objSemItem_Extension_WordDoc.Name
                        objSemItem_WordDoc.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                        objSemItem_WordDoc.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        objSemItem_WordDoc.Additional1 = objFileWork.merge_paths(objFileWork.PathToWatch, objSemItem_WordDoc.Name, "\")

                        'Das File-Item speichern
                        objSemItem_Result = objTransactionDocument.save_003_File(objSemItem_WordDoc)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                            'Das FileItem dem Dokument zuordnen
                            objSemItem_Result = objTransactionDocument.save_005_Doc_To_File()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Ref.GUID_Related = GUID_ObjectReference
                                objSemItem_Result = objTransactionDocument.save_007_Doc_To_Rel(objSemItem_Ref)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                    objSemItem_Document = Nothing

                                    objSemItem_Result = objTransactionDocument.del_005_Doc_To_File
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransactionDocument.del_003_File
                                    End If

                                    objSemItem_Result = objTransactionDocument.del_002_Document_To_DocumentType
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransactionDocument.del_001_Document()
                                        MsgBox("Das Dokument konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                    End If
                                End If
                            Else

                                objSemItem_Document = Nothing


                                objSemItem_Result = objTransactionDocument.del_003_File
                                objSemItem_Result = objTransactionDocument.del_002_Document_To_DocumentType
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objTransactionDocument.del_001_Document()
                                    MsgBox("Das Dokument konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                End If
                            End If

                        Else
                            objSemItem_Document = Nothing
                            objSemItem_Result = objTransactionDocument.del_002_Document_To_DocumentType
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransactionDocument.del_001_Document()
                                MsgBox("Das Dokument konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If
                        End If

                    Else
                        objSemItem_Document = Nothing
                        objTransactionDocument.del_001_Document()
                        MsgBox("Das Dokument konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    objSemItem_Document = Nothing
                    MsgBox("Das Dokument konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If
            Else
                objSemItem_Document = New clsSemItem
                objSemItem_Document.GUID = objDRC_Document(0).Item("GUID_Token_Left")
                objSemItem_Document.Name = objDRC_Document(0).Item("Name_Token_Left")
                objSemItem_Document.GUID_Parent = objLocalConfig.SemItem_Type_Managed_Document.GUID
                objSemItem_Document.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                objDRC_Document = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Document.GUID, _
                                                                                objLocalConfig.SemItem_RelationType_belonging_Document.GUID, _
                                                                                objLocalConfig.SemItem_Type_File.GUID).Rows
                If objDRC_Document.Count > 0 Then
                    objSemItem_WordDoc = New clsSemItem
                    objSemItem_WordDoc.GUID = objDRC_Document(0).Item("GUID_Token_Right")
                    objSemItem_WordDoc.Name = objDRC_Document(0).Item("Name_Token_Right")
                    objSemItem_WordDoc.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                    objSemItem_WordDoc.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objSemItem_WordDoc.Level = -1
                    objSemItem_WordDoc.Additional1 = objFileWork.merge_paths(objFileWork.PathToWatch, objSemItem_WordDoc.Name, "\")

                    objTransactionDocument.SemItem_Document = objSemItem_Document
                    objTransactionDocument.SemItem_File = objSemItem_WordDoc
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    objSemItem_Document.Additional1 = objSemItem_WordDoc.Name
                Else

                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

            'Das Dokument und das Datei-Item wurde gespeichert.
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                'Template entweder im Temp-Verzeichnis abspeichern oder aus dem Verzeichnis ziehen, in dem sie liegt, wenn sie kein Blob ist.
                If Not objSemItem_Template Is Nothing Then
                    'Vorlage für das Item ist definiert.
                    If objSemItem_Template.Mark = True Then
                        'Template ist Blob
                        objSemItem_Template.Additional1 = objFileWork.merge_paths(Environment.ExpandEnvironmentVariables("%Temp%"), Guid.NewGuid.ToString & "." & objLocalConfig.SemItem_Token_Extensions_dotx.Name, "\")
                        objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_Template, objSemItem_Template.Additional1)
                    Else
                        'Template ist kein Blob
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End If
                    strPath_Template = objSemItem_Template.Additional1
                Else
                    'Vorlage nicht vorhanden: Allgemeine Vorlage verwenden
                    If objSemItem_Std_Template.Mark = True Then
                        'Template ist Blob
                        objSemItem_Std_Template.Additional1 = objFileWork.merge_paths(Environment.ExpandEnvironmentVariables("%Temp%"), Guid.NewGuid.ToString & "." & objLocalConfig.SemItem_Token_Extensions_dotx.Name, "\")
                        objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_Std_Template, objSemItem_Std_Template.Additional1)
                    Else
                        'Template ist kein Blob
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    End If
                    strPath_Template = objSemItem_Std_Template.Additional1
                End If


                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    'Es konnte ein Template ermittelt werden
                    objSemItem_Result = objFileWork.open_BlobWatcher
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objBlobConnection.is_Blob_Present(objSemItem_WordDoc)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objBlobConnection.save_Blob_To_File(objSemItem_WordDoc, objSemItem_WordDoc.Additional1)
                        End If
                        objSemItem_Document.Level = objWordWork.open_Document(objSemItem_WordDoc.Additional1, strCategory, objSemItem_Ref.Name, strPath_Template)
                        If Not objSemItem_Document.Level = -1 Then
                            objWordWork.Visible = True

                            If objWordWork.save_WordDoc(objSemItem_Document.Level) = True Then

                                If objSemItem_Document.Level = -1 Then
                                    objSemItem_Document.Level = 0
                                End If

                                date_LastAccess = objWordWork.get_ChangeDate(objSemItem_Document.Level)

                                objSemItem_Result = objTransactionDocument.save_006_LastAccess(date_LastAccess)

                            Else
                                objSemItem_Document = Nothing
                                MsgBox("Das Dokument konnte nicht geöffnet werden!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            objSemItem_Document = Nothing
                            MsgBox("Das Dokument konnte nicht geöffnet werden!", MsgBoxStyle.Exclamation)
                        End If
                    End If

                Else
                    objSemItem_Document = Nothing
                    MsgBox("Das Dokument konnte nicht geöffnet werden!", MsgBoxStyle.Exclamation)
                End If

            End If
        Else
            objSemItem_Document = Nothing
        End If
        Return objSemItem_Document
    End Function

    Public Function is_Doc_Open(ByVal objSemItem_Document As clsSemItem, Optional ByVal boolActivate As Boolean = False) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_File As DataRowCollection

        objDRC_File = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Document.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Document.GUID, _
                                                                    objLocalConfig.SemItem_Type_File.GUID).Rows
        If objDRC_File.Count > 0 Then
            If objWordWork.is_Doc_Open(objDRC_File(0).Item("GUID_Token_Right").ToString, boolActivate) Then

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                objSemItem_Result.Additional1 = objDRC_File(0).Item("GUID_Token_Right").ToString & "." & objLocalConfig.SemItem_Token_Extensions_docx.Name
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        

        Return objSemItem_Result
    End Function

    Public Function activate_Bookmark(ByVal objSemItem_BookMark As clsSemItem, ByVal objSemItem_Document As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim strBookMarkTitle As String

        strBookMarkTitle = "m_" & objSemItem_BookMark.GUID.ToString
        strBookMarkTitle = strBookMarkTitle.Replace("-", "_")

        If objWordWork.activate_Bookmark(strBookMarkTitle, objSemItem_Document.Additional1) = True Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function insert_BookMark(ByVal objSemItem_Ref As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_File As clsSemItem
        Dim objSemItem_ManagedDocument As clsSemItem
        Dim objSemItem_ContentObject As clsSemItem

        Dim objDRC_File As DataRowCollection

        Dim strFileName As String

        strFileName = objWordWork.FileName_Active_Doc
        If strFileName.Contains("." & objSemItem_Extension_WordDoc.Name) Then


            objSemItem_File = New clsSemItem
            objSemItem_File.Name = strFileName
            strFileName = strFileName.Substring(0, strFileName.IndexOf("." & objSemItem_Extension_WordDoc.Name))
            If objLocalConfig.Globals.is_GUID(strFileName) Then
                objSemItem_File.GUID = New Guid(strFileName)
                objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objDRC_File = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_File.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_belonging_Document.GUID, _
                                                                            objLocalConfig.SemItem_Type_Managed_Document.GUID).Rows
                If objDRC_File.Count > 0 Then
                    objSemItem_ManagedDocument = New clsSemItem
                    objSemItem_ManagedDocument.GUID = objDRC_File(0).Item("GUID_Token_Left")
                    objSemItem_ManagedDocument.Name = objDRC_File(0).Item("Name_Token_Left")
                    objSemItem_ManagedDocument.GUID_Parent = objLocalConfig.SemItem_Type_Managed_Document.GUID
                    objSemItem_ManagedDocument.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Result = objTransaction_ContentObject.test_Existance(objSemItem_ManagedDocument, _
                                                                                    objLocalConfig.SemItem_Token_ContentType_Bookmark, _
                                                                                    objSemItem_Ref)
                    If objSemItem_Ref.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Exists
                    Else
                        objSemItem_ContentObject = New clsSemItem
                        objSemItem_ContentObject.GUID = Guid.NewGuid
                        objSemItem_ContentObject.Name = objSemItem_Ref.Name
                        objSemItem_ContentObject.GUID_Parent = objLocalConfig.SemItem_Type_ContentObject.GUID
                        objSemItem_ContentObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_ContentObject.save_001_ContentObject(objSemItem_ContentObject)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_ContentObject.save_002_ContentObject_To_ContentType()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_ContentObject.save_003_ContentObject_To_ManagedDoc()
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Ref = objTransaction_ContentObject.save_004_ContentObect_To_Related()
                                    If objSemItem_Ref.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                        If Not objWordWork.insert_BookMark(objSemItem_ContentObject.GUID) = Nothing Then
                                            If objWordWork.save_WordDoc() = True Then

                                                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                            Else
                                                objSemItem_Result = objTransaction_ContentObject.del_004_ContentObject_To_Related
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_ContentObject.del_003_ContentObject_To_ManagedDoc()
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_ContentObject.del_002_ContentObject_To_ContentType()
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objTransaction_ContentObject.del_001_ContentObject()
                                                        End If

                                                    End If
                                                End If
                                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                            End If

                                        Else
                                            objSemItem_Result = objTransaction_ContentObject.del_004_ContentObject_To_Related
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_ContentObject.del_003_ContentObject_To_ManagedDoc()
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_ContentObject.del_002_ContentObject_To_ContentType()
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objTransaction_ContentObject.del_001_ContentObject()
                                                    End If

                                                End If
                                            End If


                                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                        End If

                                    Else
                                        objSemItem_Result = objTransaction_ContentObject.del_003_ContentObject_To_ManagedDoc()
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_ContentObject.del_002_ContentObject_To_ContentType()
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objTransaction_ContentObject.del_001_ContentObject()
                                            End If

                                        End If

                                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                    End If
                                Else
                                    objSemItem_Result = objTransaction_ContentObject.del_002_ContentObject_To_ContentType()
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_ContentObject.del_001_ContentObject()
                                    End If
                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                End If
                            Else
                                objTransaction_ContentObject.del_001_ContentObject()
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                            End If
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error

                        End If
                    End If


                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If



        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Private Function get_Template(ByVal objSemItem_Ref As clsSemItem) As clsSemItem
        Dim objDRC_Template As DataRowCollection
        Dim objSemItem_File As clsSemItem = Nothing

        Select Case objSemItem_Ref.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_Template = procA_Template_Of_ObjectReference.GetData(objLocalConfig.SemItem_Type_Word_Templates.GUID, _
                                                                    objLocalConfig.SemItem_Type_File.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_used_for.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_is.GUID, _
                                                                    objSemItem_Ref.GUID_Parent).Rows
            Case Else
                objDRC_Template = procA_Template_Of_ObjectReference.GetData(objLocalConfig.SemItem_Type_Word_Templates.GUID, _
                                                                    objLocalConfig.SemItem_Type_File.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_used_for.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_is.GUID, _
                                                                    objSemItem_Ref.GUID).Rows
        End Select

        If objDRC_Template.Count > 0 Then
            objSemItem_File = New clsSemItem
            objSemItem_File.GUID = objDRC_Template(0).Item("GUID_File")
            objSemItem_File.Name = objDRC_Template(0).Item("Name_File")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            If objFileWork.is_File_Blob(objSemItem_File) Then
                objSemItem_File.Mark = True
            Else
                objSemItem_File.Additional1 = objFileWork.get_Path_FileSystemObject(objSemItem_File)
            End If

        End If

        Return objSemItem_File
    End Function

End Class
