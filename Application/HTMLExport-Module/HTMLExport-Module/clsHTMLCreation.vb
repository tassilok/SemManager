Imports Sem_Manager
Imports Version_Module
Imports Filesystem_Management
Public Class clsHTMLCreation

    Private objFrm_Parent As IWin32Window

    Private objXML As clsXML

    Private procA_TagSigns As New DataSet_HTMLTableAdapters.proc_TagSignsTableAdapter
    Private procT_TagSigns As New DataSet_HTML.proc_TagSignsDataTable

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private objTransaction_HTML As clsTransactionHTML

    Private objLocalConfig As clsLocalConfig
    Private objSemItem_HTMLDoc As clsSemItem
    Private objSemItem_User As clsSemItem
    Private objVersionWork As clsVersionWork

    Private objSemItem_XMLIntro As clsSemItem
    Private objSemItem_Folder As clsSemItem

    Private objFileWork As clsFileWork
    Private objBlobConnection As clsBlobConnection
    Private objTextWriter As IO.TextWriter

    Private dtblTAttributes As New DataSet_HTML.dtblAttributesDataTable

    Public Function add_Attribute(ByVal strAttrib As String, ByVal strValue As String) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        dtblTAttributes.Rows.Add(strAttrib, strValue)
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        Return objSemItem_Result
    End Function

    Public ReadOnly Property Path_Docs As String
        Get
            Dim strPath As String

            If Not objSemItem_Folder Is Nothing Then
                strPath = objSemItem_Folder.Additional1
            Else
                strPath = Nothing
            End If

            Return strPath
        End Get

    End Property

    Public ReadOnly Property Path__Resources As String
        Get
            Dim strPath As String
            If Not objSemItem_Folder Is Nothing Then
                strPath = objSemItem_Folder.Additional2
            Else
                strPath = Nothing
            End If

            Return strPath
        End Get
    End Property

    Public Function open_TextWriter(ByVal strFile As String) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        If objSemItem_Folder Is Nothing Then
            objSemItem_Result = initilialize_ExportFolder()
        End If

        If Not objSemItem_Folder Is Nothing Then
            Try
                objTextWriter = New IO.StreamWriter(objFileWork.merge_paths(objSemItem_Folder.Additional1, strFile & ".html", "\"), False, System.Text.Encoding.UTF8)
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Catch ex As Exception
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End Try


        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function encode_HTML(ByVal strInput As String) As String
        strInput = Web.HttpUtility.HtmlEncode(strInput)

        Return strInput
    End Function

    Public Function export_File(ByVal SemItem_File As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success
        Dim strExtension As String

        If objBlobConnection.is_Blob_Present(SemItem_File).GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            If objSemItem_Folder Is Nothing Then
                objSemItem_Result = initilialize_ExportFolder()
                
            End If

            If Not objSemItem_Folder Is Nothing Then
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    If SemItem_File.Name.LastIndexOf(".") > 0 Then
                        strExtension = SemItem_File.Name.Substring(SemItem_File.Name.LastIndexOf("."))
                        SemItem_File.Additional1 = "./Resources/" & SemItem_File.GUID.ToString & strExtension
                        SemItem_File.Additional2 = objFileWork.merge_paths(objSemItem_Folder.Additional2, SemItem_File.GUID.ToString & strExtension, "\")
                        If IO.File.Exists(SemItem_File.Additional2) Then
                            Try
                                IO.File.Delete(SemItem_File.Additional2)
                            Catch ex As Exception
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                            End Try


                        End If
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objBlobConnection.save_Blob_To_File(SemItem_File, SemItem_File.Additional2)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result.Additional1 = SemItem_File.Additional1
                            End If
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

    Public Function write_Line(ByVal strLine As String) As clsSemItem
        Dim objSemItem_Result As clsSemItem


        Try
            objTextWriter.WriteLine(strLine)
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        Return objSemItem_Result
    End Function

    Public Function close_TextWriter() As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success
        Try
            objTextWriter.Close()
        Catch ex As Exception

        End Try
        Return objSemItem_Result
    End Function

    Public ReadOnly Property SemItem_Attribute_Border As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Tag_Attributes_border
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_SRC As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Tag_Attributes_src
        End Get
    End Property

    Public ReadOnly Property SemItem_DocType_Bold As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Document_Tag_Type_Bold
        End Get
    End Property

    Public ReadOnly Property SemItem_DocType_Head As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_HTML_Tag_Type_HTML_Head_Init_Final
        End Get
    End Property

    Public ReadOnly Property SemItem_DocType_DocumentInit As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_HTML_Tag_Type_Document_Init_Final
        End Get
    End Property

    Public ReadOnly Property SemItem_DocType_Body As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Document_Tag_Type_Content
        End Get
    End Property

    Public ReadOnly Property SemItem_DocType_Title As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Document_Tag_Type_Title
        End Get
    End Property

    Public ReadOnly Property SemItem_DocType_Content As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Document_Tag_Type_Content
        End Get
    End Property

    Public ReadOnly Property SemItem_DocType_Paragraph As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Document_Tag_Type_Paragraph
        End Get
    End Property

    Public ReadOnly Property SemItem_DocType_Images As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Document_Tag_Type_Images
        End Get
    End Property

    Public ReadOnly Property SemItem_DocType_Table As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Document_Tag_Type_Table
        End Get
    End Property

    Public ReadOnly Property SemItem_DocType_TableRow As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Document_Tag_Type_Table_Row
        End Get
    End Property

    Public ReadOnly Property SemItem_DocType_TableCol As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Document_Tag_Type_Table_Col
        End Get
    End Property


    Public ReadOnly Property SemItem_HTMLDoc As clsSemItem
        Get
            Return objSemItem_HTMLDoc
        End Get
    End Property

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal objSemItem_User As clsSemItem, ByVal frmParent As IWin32Window)
        objLocalConfig = LocalConfig
        Me.objSemItem_User = objSemItem_User
        objFrm_Parent = frmParent
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals, ByVal objSemItem_User As clsSemItem, ByVal frmParent As IWin32Window)
        objLocalConfig = New clsLocalConfig(Globals)
        Me.objSemItem_User = objSemItem_User
        objFrm_Parent = frmParent
        initialize()
    End Sub



    Public Function initialize_Document(ByVal SemItem_HTMLDoc As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_HTMLDoc = SemItem_HTMLDoc

        If objSemItem_HTMLDoc.new_Item = True Then
            objSemItem_HTMLDoc.GUID = Guid.NewGuid
            objSemItem_HTMLDoc.GUID_Parent = objLocalConfig.SemItem_Type_HTML_Document.GUID
            objSemItem_HTMLDoc.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


        End If

        objSemItem_Result = objTransaction_HTML.save_001_HTMLDoc(objSemItem_HTMLDoc)

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            If objSemItem_HTMLDoc.new_Item = True Then
                objVersionWork = New clsVersionWork(objLocalConfig.Globals, objSemItem_HTMLDoc, objSemItem_User, objFrm_Parent)
                objSemItem_Result = objVersionWork.save_FirstVersion()
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_HTML.save_004_Document_To_Intro(objSemItem_XMLIntro)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        objTransaction_HTML.del_001_HTMLDoc()
                    End If
                Else

                    objTransaction_HTML.del_001_HTMLDoc()
                End If
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function insert_DocumentPart_HTML() As clsSemItem
        Dim objSemItem_DocumentPart_HTML As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_DocumentPart_HTML.GUID = Guid.NewGuid
        objSemItem_DocumentPart_HTML.Name = "HTML"
        objSemItem_DocumentPart_HTML.GUID_Parent = objLocalConfig.SemItem_Type_Document_Parts.GUID
        objSemItem_DocumentPart_HTML.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objSemItem_Result = objTransaction_HTML.save_002_DocumentPart(objSemItem_DocumentPart_HTML)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_HTML.save_003_Document_To_DocumentPart
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                objTransaction_HTML.del_002_DocumentPart()
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function Open_Head() As clsSemItem
        Dim objSemItem_Result As clsSemItem



        Return objSemItem_Result
    End Function

    Public Function close_Head() As clsSemItem
        Dim objSemItem_Result As clsSemItem



        Return objSemItem_Result
    End Function

    Public Function get_HTML_Tag(ByVal SemItem_DocumentType As clsSemItem, ByVal boolFinalize As Boolean) As String
        Dim strHTMLHead As String = ""
        Dim objDRs_TagSigns() As DataRow
        Dim objDRC_Tag As DataRowCollection
        Dim objDR_Attributes As DataRow

        objDRs_TagSigns = procT_TagSigns.Select("GUID_RelationType='" & objLocalConfig.SemItem_RelationType_Tag_Start.GUID.ToString & "'")
        If objDRs_TagSigns.Count > 0 Then
            strHTMLHead = strHTMLHead & objDRs_TagSigns(0).Item("Name_Zeichen")
        End If

        If boolFinalize = True Then
            objDRs_TagSigns = procT_TagSigns.Select("GUID_RelationType='" & objLocalConfig.SemItem_RelationType_Tag_End_Init.GUID.ToString & "'")
            If objDRs_TagSigns.Count > 0 Then
                strHTMLHead = strHTMLHead & objDRs_TagSigns(0).Item("Name_Zeichen")
            End If

        End If

        objDRC_Tag = funcA_TokenToken.GetData_TokenToken_RightLeft(SemItem_DocumentType.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                   objLocalConfig.SemItem_Type_HTML_Tags.GUID).Rows

        If objDRC_Tag.Count > 0 Then
            strHTMLHead = strHTMLHead & objDRC_Tag(0).Item("Name_Token_Left")
        End If

        If boolFinalize = False Then
            For Each objDR_Attributes In dtblTAttributes.Rows
                strHTMLHead = strHTMLHead & " " & objDR_Attributes.Item("Attribute") & "="
                strHTMLHead = strHTMLHead & """" & objDR_Attributes.Item("Value") & """"
            Next
        End If

        objDRs_TagSigns = procT_TagSigns.Select("GUID_RelationType='" & objLocalConfig.SemItem_RelationType_Tag_End.GUID.ToString & "'")
        If objDRs_TagSigns.Count > 0 Then
            strHTMLHead = strHTMLHead & objDRs_TagSigns(0).Item("Name_Zeichen")
        End If


        dtblTAttributes.Clear()


        Return strHTMLHead
    End Function

    Public Function get_HTML_Heading(ByVal intLevel As Integer, ByVal boolFinalize As Boolean) As String
        Dim funcT_TokenToken As New ds_Token.func_TokenTokenDataTable
        Dim objDRs_Heading() As DataRow
        Dim objDRs_TagSigns() As DataRow
        Dim strHTML As String = ""


        objDRs_TagSigns = procT_TagSigns.Select("GUID_RelationType='" & objLocalConfig.SemItem_RelationType_Tag_Start.GUID.ToString & "'")
        If objDRs_TagSigns.Count > 0 Then
            strHTML = strHTML & objDRs_TagSigns(0).Item("Name_Zeichen")
        End If

        If boolFinalize = True Then
            objDRs_TagSigns = procT_TagSigns.Select("GUID_RelationType='" & objLocalConfig.SemItem_RelationType_Tag_End_Init.GUID.ToString & "'")
            If objDRs_TagSigns.Count > 0 Then
                strHTML = strHTML & objDRs_TagSigns(0).Item("Name_Zeichen")
            End If
        End If

        funcA_TokenToken.Fill_TokenToken_RightLeft(funcT_TokenToken, objLocalConfig.SemItem_Token_HTML_Tag_Type_Heading.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                             objLocalConfig.SemItem_Type_HTML_Tags.GUID)
        objDRs_Heading = funcT_TokenToken.Select("OrderID=" & intLevel)

        If objDRs_Heading.Count = 0 Then
            While intLevel > 0 And objDRs_Heading.Count = 0
                intLevel = intLevel - 1
                objDRs_Heading = funcT_TokenToken.Select("OrderID=" & intLevel)
            End While

            If objDRs_Heading.Count > 0 Then
                strHTML = strHTML & objDRs_Heading(0).Item("Name_Token_Left")
            End If
        Else
            strHTML = strHTML & objDRs_Heading(0).Item("Name_Token_Left")
        End If

        objDRs_TagSigns = procT_TagSigns.Select("GUID_RelationType='" & objLocalConfig.SemItem_RelationType_Tag_End.GUID.ToString & "'")
        If objDRs_TagSigns.Count > 0 Then
            strHTML = strHTML & objDRs_TagSigns(0).Item("Name_Zeichen")
        End If

        Return strHTML
    End Function

    Public Function get_HTML_Intro() As String
        Dim strHTMLIntro As String

        strHTMLIntro = objXML.get_XML(objLocalConfig.SemItem_Token_XML_HTML_Intro).Additional1

        Return strHTMLIntro
    End Function

    Public Function initilialize_ExportFolder() As clsSemItem
        Dim objDRC_Folder As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        If objSemItem_Folder Is Nothing Then
            objSemItem_Folder = New clsSemItem

            objDRC_Folder = funcA_TokenToken.GetData_LeftRight_Ordered_By_GUIDs(objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                                objLocalConfig.SemItem_type_Folder.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_export_to.GUID, _
                                                                          True).Rows
            If objDRC_Folder.Count > 0 Then
                objSemItem_Folder.GUID = objDRC_Folder(0).Item("GUID_Token_Right")
                objSemItem_Folder.Name = objDRC_Folder(0).Item("Name_Token_Right")
                objSemItem_Folder.GUID_Parent = objLocalConfig.SemItem_type_Folder.GUID
                objSemItem_Folder.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objSemItem_Folder.Additional1 = objFileWork.get_Path_FileSystemObject(objSemItem_Folder, False)

            If Not IO.Directory.Exists(objSemItem_Folder.Additional1) Then
                Try
                    IO.Directory.CreateDirectory(objSemItem_Folder.Additional1)

                Catch ex As Exception
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End Try


            End If
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objSemItem_Folder.Additional2 = objSemItem_Folder.Additional1 & "\Resources"
                If Not IO.Directory.Exists(objSemItem_Folder.Additional2) Then
                    Try
                        IO.Directory.CreateDirectory(objSemItem_Folder.Additional2)
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Catch ex As Exception
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End Try
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                End If
            End If
        End If

        Return objSemItem_Result
    End Function
    Private Sub initialize()
        set_DBConnection()

        procA_TagSigns.Fill(procT_TagSigns, _
                            objLocalConfig.SemItem_Type_Zeichen.GUID, _
                            objLocalConfig.SemItem_RelationType_Tag_Start.GUID, _
                            objLocalConfig.SemItem_RelationType_Tag_End.GUID, _
                            objLocalConfig.SemItem_RelationType_Tag_End_Init.GUID, _
                            objLocalConfig.SemItem_BaseConfig.GUID)

        objSemItem_XMLIntro = objXML.get_XML(objLocalConfig.SemItem_Token_XML_HTML_Intro)


    End Sub


    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

        objTransaction_HTML = New clsTransactionHTML(objLocalConfig)
        procA_TagSigns.Connection = objLocalConfig.Connection_Plugin

        objXML = New clsXML(objLocalConfig)

        objFileWork = New clsFileWork(objLocalConfig.Globals)
        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
    End Sub
End Class
