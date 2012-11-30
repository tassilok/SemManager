
Imports Sem_Manager
Imports Filesystem_Management
Imports System.Web
Imports System.Web.UI

Public Class clsWIKI
    Private objLocalConfig As clsLocalConfig
    Private objTransaction_WIKIDocument As clsTransaction_WIKIDocument
    Private objTransaction_Heading As clsTransaction_Heading
    Private objTransaction_Table As clsTransaction_Table
    Private objTransaction_Pre As clsTransaction_Pre
    Private objTransaction_WikiMarkuped As clsTransaction_WIKITextMarkuped
    Private objTransaction_WikiLinkIntern As clsTransaction_WIKILink_intern
    Private objTransaction_WIKICategory As clsTransaction_Category
    Private objTagWork As clsTagWork

    Private objFileWork As clsFileWork
    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private funcA_TokenAttribute_Named_By_GUID As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private funcA_WIKIDocument_Data_Of_WIKIImplementation As New ds_WikiManagementTableAdapters.func_WIKIDocument_Data_Of_WIKIImplementationTableAdapter
    Private procA_WIKIDocPart_With_WIKIText_By_GUIDWIKIDocument As New ds_WikiManagementTableAdapters.proc_WIKIDocPart_With_WIKIText_By_GUIDWIKIDocumentTableAdapter
    Private procA_TokenAttribute_VarcharMAX As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter
    Private procA_TokenAttribute_DateTime As New ds_TokenAttributeTableAdapters.TokenAttribute_DatetimeTableAdapter

    Private strWikiDoc As String
    Private intCountComponent As Integer

    Private Function set_SemItem_Document(ByVal objSemItem_Document As clsSemItem) As Boolean

        Dim objDRC_Document As DataRowCollection
        Dim boolResult As Boolean = False

        objDRC_Document = funcA_Token_Token.GetData_LeftRight_Ordered_By_GUIDs(objSemItem_Document.GUID, objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, True).Rows
        If objDRC_Document.Count > 0 Then
            intCountComponent = objDRC_Document(objDRC_Document.Count - 1).Item("OrderID")
            intCountComponent = intCountComponent + 1
            boolResult = True
        Else
            boolResult = False
        End If
        Return boolResult
    End Function

    Public Function get_String_Markuped(ByVal objSemItem_Token_Type As clsSemItem, ByVal strText As String) As String
        strText = objTagWork.get_Tag(objSemItem_Token_Type.GUID, True) & strText & objTagWork.get_Tag(objSemItem_Token_Type.GUID, False)

        Return strText
    End Function

    Public Function add_Link(ByVal objSemItem_WikiDocument_To_Doc As clsSemItem, ByVal objSemItem_WikiDocument_To_Insert As clsSemItem) As clsSemItem
        Dim objSemItem_DocPart As clsSemItem = Nothing
        objSemItem_WikiDocument_To_Insert.Level = intCountComponent
        objTransaction_WikiLinkIntern = New clsTransaction_WIKILink_intern(objLocalConfig, objSemItem_WikiDocument_To_Insert, objSemItem_WikiDocument_To_Doc)

        If objTransaction_WikiLinkIntern.save_001_WIKILink = True Then
            If objTransaction_WikiLinkIntern.save_002_WIKILink_WIKIText = True Then
                If objTransaction_WikiLinkIntern.save_003_WIKILink_To_WIKIDoc = True Then
                    objSemItem_DocPart = objTransaction_WikiLinkIntern.save_004_WikiDocPart
                    If Not objSemItem_DocPart Is Nothing Then
                        If objTransaction_WikiLinkIntern.save_005_WikiLink_To_WikiDocPart = True Then
                            If objTransaction_WikiLinkIntern.save_006_WikiDoc_To_WikiDocPart = True Then
                                If objTransaction_WikiLinkIntern.save_007_WIKIDocPart_WIKIText = True Then
                                    intCountComponent = intCountComponent + 1
                                Else
                                    If objTransaction_WikiLinkIntern.del_006_WikiDoc_To_WikiDocPart = True Then
                                        objTransaction_WikiLinkIntern.del_004_WikiDocPart()
                                        If objTransaction_WikiLinkIntern.del_003_WIKILink_to_WIKIDoc = True Then
                                            If objTransaction_WikiLinkIntern.del_002_WIKILink_WIKIText() = True Then
                                                objTransaction_WikiLinkIntern.del_001_WIKILink()
                                            End If
                                        End If
                                    End If
                                    objSemItem_DocPart = Nothing
                                End If

                            Else
                                If objTransaction_WikiLinkIntern.del_005_WikiLink_To_WikiDocPart = True Then
                                    objTransaction_WikiLinkIntern.del_004_WikiDocPart()
                                    If objTransaction_WikiLinkIntern.del_003_WIKILink_to_WIKIDoc = True Then
                                        If objTransaction_WikiLinkIntern.del_002_WIKILink_WIKIText() = True Then
                                            objTransaction_WikiLinkIntern.del_001_WIKILink()
                                        End If
                                    End If
                                End If
                                objSemItem_DocPart = Nothing

                            End If
                        Else
                            objTransaction_WikiLinkIntern.del_004_WikiDocPart()
                            If objTransaction_WikiLinkIntern.del_003_WIKILink_to_WIKIDoc = True Then
                                If objTransaction_WikiLinkIntern.del_002_WIKILink_WIKIText() = True Then
                                    objTransaction_WikiLinkIntern.del_001_WIKILink()
                                End If
                            End If
                            objSemItem_DocPart = Nothing
                        End If
                    Else
                        If objTransaction_WikiLinkIntern.del_003_WIKILink_to_WIKIDoc = True Then
                            If objTransaction_WikiLinkIntern.del_002_WIKILink_WIKIText() = True Then
                                objTransaction_WikiLinkIntern.del_001_WIKILink()
                            End If
                        End If
                        objSemItem_DocPart = Nothing

                    End If
                Else
                    If objTransaction_WikiLinkIntern.del_002_WIKILink_WIKIText() = True Then
                        objTransaction_WikiLinkIntern.del_001_WIKILink()
                    End If
                    objSemItem_DocPart = Nothing
                End If
            Else
                objTransaction_WikiLinkIntern.del_001_WIKILink()
                objSemItem_DocPart = Nothing
            End If
        Else
            objSemItem_DocPart = Nothing
        End If
        Return objSemItem_DocPart
    End Function
    Public Function add_Pre(ByVal objSemItem_WikiDocument As clsSemItem, ByVal strPreText As String) As clsSemItem
        Dim objSemItem_Wiki_DocumentPart As clsSemItem = Nothing
        Dim objSemItem_WIKI_Pre As clsSemItem = Nothing

        If Not objSemItem_WikiDocument Is Nothing Then
            objTransaction_Pre = New clsTransaction_Pre(objLocalConfig, objSemItem_WikiDocument)

            objSemItem_WIKI_Pre = New clsSemItem
            objSemItem_WIKI_Pre.GUID = Guid.NewGuid
            objSemItem_WIKI_Pre.Name = strPreText
            If objSemItem_WIKI_Pre.Name.Length > 255 Then
                objSemItem_WIKI_Pre.Name = objSemItem_WIKI_Pre.Name.Substring(0, 254)
            End If
            objSemItem_WIKI_Pre.GUID_Parent = objLocalConfig.SemItem_Type_WIKI_Pre.GUID
            objSemItem_WIKI_Pre.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            If objTransaction_Pre.save_001_Pre(objSemItem_WIKI_Pre) = True Then
                If objTransaction_Pre.save_002_WIKIText(strPreText) = True Then
                    If objTransaction_Pre.save_003_WIKIDocPart = True Then
                        If objTransaction_Pre.save_004_WIKIDocPart_WIKIText = True Then
                            If objTransaction_Pre.save_005_WIKIDocPart_To_WIKIPre = True Then
                                If objTransaction_Pre.save_006_WIKIDoc_To_WIKIDocPart(intCountComponent) = True Then
                                    intCountComponent = intCountComponent + 1
                                Else
                                    If objTransaction_Pre.del_005_WIKIDocPart_To_WIKIPre = True Then
                                        If objTransaction_Pre.del_004_WIKIDocPart_WIKIText = True Then
                                            objTransaction_Pre.del_003_WIKIDocPart()
                                            objTransaction_Pre.del_002_WIKIText()
                                        End If

                                    End If



                                    objTransaction_Pre.del_001_Pre()
                                    objSemItem_WIKI_Pre = Nothing
                                End If
                            Else

                                If objTransaction_Pre.del_004_WIKIDocPart_WIKIText = True Then
                                    objTransaction_Pre.del_003_WIKIDocPart()
                                    objTransaction_Pre.del_002_WIKIText()
                                End If





                                objTransaction_Pre.del_001_Pre()
                                objSemItem_WIKI_Pre = Nothing
                            End If
                        Else

                            objTransaction_Pre.del_003_WIKIDocPart()
                            objTransaction_Pre.del_002_WIKIText()




                            objTransaction_Pre.del_001_Pre()
                            objSemItem_WIKI_Pre = Nothing
                        End If

                    Else
                        objTransaction_Pre.del_002_WIKIText()

                        objTransaction_Pre.del_001_Pre()
                        objSemItem_WIKI_Pre = Nothing
                    End If
                Else
                    objTransaction_Pre.del_001_Pre()
                    objSemItem_WIKI_Pre = Nothing

                End If
            Else
                objSemItem_WIKI_Pre = Nothing
            End If

        End If
        Return objSemItem_WIKI_Pre
    End Function

    Public Function add_Category(ByVal objSemItem_WikiDocument As clsSemItem, ByVal objSemItem_WikiImplementation As clsSemItem, ByVal strCategory As String) As clsSemItem
        Dim objSemItem_Wiki_DocumentPart As clsSemItem = Nothing

        objTransaction_WIKICategory = New clsTransaction_Category(objLocalConfig, objSemItem_WikiDocument, objSemItem_WikiImplementation, intCountComponent)

        If objTransaction_WIKICategory.save_001_WIKICategory(strCategory) = True Then
            If objTransaction_WIKICategory.save_002_WIKIText = True Then
                If objTransaction_WIKICategory.save_003_WIKIDocPart = True Then
                    If objTransaction_WIKICategory.save_004_WIKICategory_To_WIKIDocPart = True Then
                        If objTransaction_WIKICategory.save_005_WIKIDocPart_WIKIText = True Then
                            If objTransaction_WIKICategory.save_006_WIKIDocument_To_WIKIDocPart = True Then
                                intCountComponent = intCountComponent + 1
                            Else
                                If objTransaction_WIKICategory.del_005_WIKIDocPart_WIKIText = True Then
                                    If objTransaction_WIKICategory.del_004_WIKICategory_To_WIKIDocPart = True Then
                                        objTransaction_WIKICategory.del_003_WIKIDocPart()
                                        If objTransaction_WIKICategory.del_002_WIKIText = True Then
                                            objTransaction_WIKICategory.del_001_WIKICategory()

                                        End If
                                    End If

                                End If


                                objSemItem_Wiki_DocumentPart = Nothing
                            End If
                        Else
                            If objTransaction_WIKICategory.del_005_WIKIDocPart_WIKIText = True Then
                                If objTransaction_WIKICategory.del_004_WIKICategory_To_WIKIDocPart = True Then
                                    objTransaction_WIKICategory.del_003_WIKIDocPart()
                                    If objTransaction_WIKICategory.del_002_WIKIText = True Then
                                        objTransaction_WIKICategory.del_001_WIKICategory()

                                    End If
                                End If

                            End If

                            
                            objSemItem_Wiki_DocumentPart = Nothing
                        End If
                    Else
                        objTransaction_WIKICategory.del_003_WIKIDocPart()
                        If objTransaction_WIKICategory.del_002_WIKIText = True Then
                            objTransaction_WIKICategory.del_001_WIKICategory()

                        End If
                        objSemItem_Wiki_DocumentPart = Nothing
                    End If
                Else
                    If objTransaction_WIKICategory.del_002_WIKIText = True Then
                        objTransaction_WIKICategory.del_001_WIKICategory()
                    End If

                    objSemItem_Wiki_DocumentPart = Nothing
                End If
            Else
                objTransaction_WIKICategory.del_001_WIKICategory()
                objSemItem_Wiki_DocumentPart = Nothing
            End If
        Else
            objSemItem_Wiki_DocumentPart = Nothing
        End If

        Return objSemItem_Wiki_DocumentPart
    End Function

    Public Function add_heading(ByVal objSemItem_WikiDocument As clsSemItem, ByVal strHeading As String, ByVal intLevel As Integer) As clsSemItem
        Dim objSemItem_Wiki_DocumentPart As clsSemItem = Nothing
        Dim objSemItem_WIKI_Heading As New clsSemItem


        If Not objSemItem_WikiDocument Is Nothing Then
            objTransaction_Heading = New clsTransaction_Heading(objLocalConfig, objSemItem_WikiDocument)

            objSemItem_WIKI_Heading = New clsSemItem
            objSemItem_WIKI_Heading.GUID = Guid.NewGuid
            objSemItem_WIKI_Heading.Name = strHeading
            If objSemItem_WIKI_Heading.Name.Length > 255 Then
                objSemItem_WIKI_Heading.Name = objSemItem_WIKI_Heading.Name.Substring(0, 255)
            End If
            objSemItem_WIKI_Heading.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Heading.GUID
            objSemItem_WIKI_Heading.Level = intLevel
            If objTransaction_Heading.save_001_WIKI_Heading(objSemItem_WIKI_Heading) = True Then

                If objTransaction_Heading.save_003_WikiText(strHeading) = True Then
                    If objTransaction_Heading.save_004_WIKIDocPart = True Then
                        If objTransaction_Heading.save_005_WIKIDocPart_WIKIText = True Then
                            If objTransaction_Heading.save_006_Rel_WikiDoc_WikiDocPart(intCountComponent) = True Then
                                If objTransaction_Heading.save_007_Rel_WikiHeading_WikiDocPart = True Then
                                    intCountComponent = intCountComponent + 1
                                Else
                                    If objTransaction_Heading.del_006_Rel_WikiDoc_WikiDocPart = True Then
                                        If objTransaction_Heading.del_005_WIKIDocPart_WIKIText = True Then
                                            If objTransaction_Heading.del_004_WikiDocPart = True Then
                                                If objTransaction_Heading.del_003_WikiText = True Then

                                                    objTransaction_Heading.del_001_WIKI_Heading()


                                                End If
                                            End If
                                        End If

                                    End If

                                    objSemItem_Wiki_DocumentPart = Nothing
                                End If

                            Else
                                If objTransaction_Heading.del_005_WIKIDocPart_WIKIText = True Then
                                    If objTransaction_Heading.del_004_WikiDocPart = True Then
                                        If objTransaction_Heading.del_003_WikiText = True Then

                                            objTransaction_Heading.del_001_WIKI_Heading()


                                        End If
                                    End If
                                End If

                                objSemItem_Wiki_DocumentPart = Nothing
                            End If
                        Else
                            If objTransaction_Heading.del_004_WikiDocPart = True Then
                                If objTransaction_Heading.del_003_WikiText = True Then

                                    objTransaction_Heading.del_001_WIKI_Heading()


                                End If
                            End If

                            objSemItem_Wiki_DocumentPart = Nothing
                        End If


                    Else

                        If objTransaction_Heading.del_003_WikiText = True Then

                            objTransaction_Heading.del_001_WIKI_Heading()


                        End If
                        objSemItem_Wiki_DocumentPart = Nothing
                    End If
                Else


                    objTransaction_Heading.del_001_WIKI_Heading()

                    objSemItem_Wiki_DocumentPart = Nothing
                End If

            Else
                objSemItem_Wiki_DocumentPart = Nothing
            End If

        End If

        Return objSemItem_Wiki_DocumentPart
    End Function

    Public Function add_Markuped_Text(ByVal objSemItem_WikiDoc As clsSemItem, ByVal strText As String) As clsSemItem
        Dim objSemItem_WikiMarkuped As clsSemItem
        Dim objSemItem_WikiDocPart As clsSemItem = Nothing
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Wiki_DocPart As clsSemItem

        If Not objSemItem_WikiDoc Is Nothing Then
            objTransaction_WikiMarkuped = New clsTransaction_WIKITextMarkuped(objLocalConfig, objSemItem_WikiDoc)
            objSemItem_WikiMarkuped = New clsSemItem
            objSemItem_WikiMarkuped.GUID = Guid.NewGuid
            objSemItem_WikiMarkuped.Name = strText
            If objSemItem_WikiMarkuped.Name.Length > 255 Then
                objSemItem_WikiMarkuped.Name = objSemItem_WikiMarkuped.Name.Substring(0, 254)
            End If
            objSemItem_WikiMarkuped.GUID_Parent = objLocalConfig.SemItem_Type_WIKI_Text__Markuped_.GUID
            objSemItem_WikiMarkuped.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_WikiMarkuped.Additional1 = strText
            objSemItem_WikiMarkuped.Level = intCountComponent

            If objTransaction_WikiMarkuped.save_001_WikiMarkuped(objSemItem_WikiMarkuped) = True Then

                If objTransaction_WikiMarkuped.save_002_WikiMarkuped_WIKIText() = True Then
                    objSemItem_Wiki_DocPart = objTransaction_WikiMarkuped.save_003_WikiDocPart
                    If Not objSemItem_Wiki_DocPart Is Nothing Then
                        If objTransaction_WikiMarkuped.save_004_WikiMarkuped_To_WikiDocPart() = True Then
                            If objTransaction_WikiMarkuped.save_005_WikiDoc_To_WikiDocPart() = True Then
                                If objTransaction_WikiMarkuped.save_006_WIKIDocPart_WIKIText = True Then
                                    intCountComponent = intCountComponent + 1
                                Else
                                    If objTransaction_WikiMarkuped.del_005_WikiDoc_To_WikiDocPart = True Then
                                        If objTransaction_WikiMarkuped.del_004_WikiMarkuped_To_WikiDocPart() = True Then
                                            objTransaction_WikiMarkuped.del_003_WikiDocPart()
                                        End If
                                    End If
                                    
                                    If objTransaction_WikiMarkuped.del_002_WikiMarkuped_WIKIText() = True Then
                                        objTransaction_WikiMarkuped.del_001_WikiMarkuped()
                                    End If

                                    objSemItem_Wiki_DocPart = Nothing
                                End If

                            Else

                                If objTransaction_WikiMarkuped.del_004_WikiMarkuped_To_WikiDocPart() = True Then
                                    objTransaction_WikiMarkuped.del_003_WikiDocPart()
                                End If
                                If objTransaction_WikiMarkuped.del_002_WikiMarkuped_WIKIText() = True Then
                                    objTransaction_WikiMarkuped.del_001_WikiMarkuped()
                                End If

                                objSemItem_Wiki_DocPart = Nothing
                            End If
                        Else

                            objTransaction_WikiMarkuped.del_003_WikiDocPart()
                            If objTransaction_WikiMarkuped.del_002_WikiMarkuped_WIKIText() = True Then
                                objTransaction_WikiMarkuped.del_001_WikiMarkuped()
                            End If

                            objSemItem_Wiki_DocPart = Nothing
                        End If
                    Else
                        If objTransaction_WikiMarkuped.del_002_WikiMarkuped_WIKIText() = True Then
                            objTransaction_WikiMarkuped.del_001_WikiMarkuped()
                        End If

                        objSemItem_Wiki_DocPart = Nothing
                    End If
                Else
                    objTransaction_WikiMarkuped.del_001_WikiMarkuped()
                    objSemItem_Wiki_DocPart = Nothing
                End If
            Else

                objSemItem_Wiki_DocPart = Nothing
            End If
        End If

        Return objSemItem_Wiki_DocPart
    End Function
    Public Function create_WIKIText_Of_WIKIDoc(ByVal objSemItem_WikiImplementation As clsSemItem) As Integer
        Dim objDRC_WIKIDocs As DataRowCollection
        Dim objDR_WIKIDocs As DataRow
        Dim objDRC_WIKIText As DataRowCollection
        Dim objDR_WIKIText As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_WIKIText_Document As DataRowCollection
        Dim strWIKIText As String
        Dim intCount_Docs_Texted As Integer
        Dim intNr_Docs_Texted As Integer

        objDRC_WIKIDocs = funcA_WIKIDocument_Data_Of_WIKIImplementation.GetData(objLocalConfig.SemItem_Attribute_Revision.GUID, _
                                                                                objLocalConfig.SemItem_Attribute_ID.GUID, _
                                                                                objLocalConfig.SemItem_Type_WIKI_Implementation.GUID, _
                                                                                objLocalConfig.SemItem_Type_Wiki_Document.GUID, _
                                                                                objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                objSemItem_WikiImplementation.GUID).Rows
        intCount_Docs_Texted = objDRC_WIKIDocs.Count
        intNr_Docs_Texted = 0
        For Each objDR_WIKIDocs In objDRC_WIKIDocs
            objDRC_WIKIText = procA_WIKIDocPart_With_WIKIText_By_GUIDWIKIDocument.GetData(objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, _
                                                                                          objLocalConfig.SemItem_Type_Wiki_Document.GUID, _
                                                                                          objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                          objDR_WIKIDocs.Item("GUID_WIKIDocument")).Rows


            strWIKIText = ""
            For Each objDR_WIKIText In objDRC_WIKIText
                strWIKIText = strWIKIText & objDR_WIKIText.Item("WIKIText") & vbCrLf
            Next
            If Not strWIKIText = "" Then
                objDRC_WIKIText_Document = funcA_TokenAttribute_Named_By_GUID.GetData_By_GUIDToken_And_GUIDAttribute(objDR_WIKIDocs.Item("GUID_WIKIDocument"), objLocalConfig.SemItem_Attribute_Wiki_Text.GUID).Rows
                If objDRC_WIKIText_Document.Count > 0 Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objDR_WIKIDocs.Item("GUID_WIKIDocument"), objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, objDRC_WIKIText_Document(0).Item("GUID_TokenAttribute"), strWIKIText, 0).Rows
                Else
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objDR_WIKIDocs.Item("GUID_WIKIDocument"), objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, strWIKIText, 0).Rows

                End If
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    intNr_Docs_Texted = intNr_Docs_Texted + 1

                End If
            End If
        Next
        Return intCount_Docs_Texted - intNr_Docs_Texted
    End Function
    Public Function add_Table(ByVal objSemItem_WikiDoc As clsSemItem, ByVal objDRC_Table As DataRowCollection, ByVal intCount_Cols As Integer, ByVal boolFirstRowBold As Boolean) As clsSemItem
        Dim objSemItem_WIKI_DocumentPart As clsSemItem = Nothing
        Dim objSemItem_WIKITable As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim i As Integer
        Dim objDR_Row As DataRow
        objTransaction_Table = New clsTransaction_Table(objLocalConfig, objSemItem_WikiDoc, intCountComponent, True, 1)
        objSemItem_WIKITable = objTransaction_Table.save_001_Table(objDRC_Table, intCount_Cols)
        If Not objSemItem_WIKITable Is Nothing Then
            intCountComponent = intCountComponent + 1
        End If
        
        Return objSemItem_WIKITable
    End Function

    Public Function add_Language_Table(ByVal objSemItem_WIKIDoc As clsSemItem, ByVal strLanguage_Lbl As String, ByVal objDRC_LocalizedPages As DataRowCollection) As clsSemItem
        Dim objSemItem_WIKIDocPart As clsSemItem
        Dim strHtml_Table As String
        Dim strLocalizedPage As String
        Dim strCaptionPage As String
        Dim strLanguage As String
        Dim strLanguages As String = ""
        Dim objDR_LocalizedPage As DataRow

        strHtml_Table = get_Text_From_XML(objLocalConfig.SemItem_Token_XML_Table_for_Language_in_WIKI.GUID)
        strHtml_Table = strHtml_Table.Replace("@" & objLocalConfig.SemItem_Token_Variable_name_language.Name & "@", strLanguage_Lbl)
        For Each objDR_LocalizedPage In objDRC_LocalizedPages
            strLocalizedPage = objDR_LocalizedPage.Item(0)
            strCaptionPage = objDR_LocalizedPage.Item(1)
            strLanguage = get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, strLocalizedPage & "|" & strCaptionPage)
            If strLanguages = "" Then
                strLanguages = strLanguages & strLanguage
            Else
                strLanguages = strLanguages & ", " & strLanguage
            End If

        Next
        strHtml_Table = strHtml_Table.Replace("@" & objLocalConfig.SemItem_Token_Variable_text_col.Name & "@", strLanguages)

        objSemItem_WIKIDocPart = add_Markuped_Text(objSemItem_WIKIDoc, strHtml_Table)
        Return objSemItem_WIKIDocPart
    End Function

    Private Function get_Text_From_XML(ByVal GUID_XML As Guid) As String
        Dim objDRC_XML As DataRowCollection
        Dim objXMLDocument As Xml.XmlDocument
        Dim objXMLNodeList As Xml.XmlNodeList
        Dim objXMLElement As Xml.XmlElement
        Dim strText_Of_XML As String = ""


        objDRC_XML = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(GUID_XML, objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
        If objDRC_XML.Count > 0 Then
            strText_Of_XML = objDRC_XML(0).Item("Val")
            objXMLDocument = New Xml.XmlDocument
            objXMLDocument.LoadXml(strText_Of_XML)
            objXMLNodeList = objXMLDocument.GetElementsByTagName("data")
            objXMLElement = objXMLNodeList(0)
            strText_Of_XML = objXMLElement.InnerText
        End If

        Return strText_Of_XML
    End Function

    Public Function delete_DocumentParts_Of_WIKIDoc(ByVal objSemItem_WIKIDoc As clsSemItem) As Integer
        Dim objDRC_DocumentParts As DataRowCollection
        Dim objDR_DocumentParts As DataRow

        objDRC_DocumentParts = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_WIKIDoc.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID).Rows
        For Each objDR_DocumentParts In objDRC_DocumentParts

        Next
    End Function

    Private Sub set_DBConnection()
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB
        funcA_WIKIDocument_Data_Of_WIKIImplementation.Connection = objLocalConfig.Connection_Plugin
        procA_WIKIDocPart_With_WIKIText_By_GUIDWIKIDocument.Connection = objLocalConfig.Connection_Plugin
        semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUID.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_VarcharMAX.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_DateTime.Connection = objLocalConfig.Connection_DB

        objTagWork = New clsTagWork(objLocalConfig)
        objFileWork = New clsFileWork(objLocalConfig.Globals)
    End Sub

    Public Sub New()

        objLocalConfig = New clsLocalConfig(New clsGlobals)
        set_DBConnection()
    End Sub
    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Public Function get_WIKIDocument(ByVal strName_Document As String, ByVal objSemItem_WikiImplementation As clsSemItem, ByVal boolDocumentParts As Boolean) As clsSemItem
        Dim objSemItem_WikiDocument As New clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_WikiDocument.GUID = Guid.NewGuid
        objSemItem_WikiDocument.Name = strName_Document
        objSemItem_WikiDocument.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Document.GUID
        objSemItem_WikiDocument.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        objTransaction_WIKIDocument = New clsTransaction_WIKIDocument(objLocalConfig)

        If objTransaction_WIKIDocument.get_001_Data(objSemItem_WikiImplementation, strName_Document) = True Then
            If objTransaction_WIKIDocument.save_002_WIKIDocument(objSemItem_WikiDocument) = True Then
                If objTransaction_WIKIDocument.save_003_ID = True Then
                    If objTransaction_WIKIDocument.save_004_Revision = True Then
                        If objTransaction_WIKIDocument.save_005_DateTimeStamp = True Then
                            If objTransaction_WIKIDocument.save_006_old_Text = True Then
                                If objTransaction_WIKIDocument.save_007_WIKIDocumentParts(boolDocumentParts) = True Then
                                    If objTransaction_WIKIDocument.save_008_History_of = True Then
                                        If objTransaction_WIKIDocument.del_009_Relation_WIKIImplementation_WIKIDocOld = True Then

                                            If objTransaction_WIKIDocument.save_010_Relation_WIKIImplementation_WIKIDoc = True Then
                                                set_SemItem_Document(objSemItem_WikiDocument)
                                            Else

                                                objTransaction_WIKIDocument.del_009_Relation_WIKIImplementation_WIKIDocOld()
                                                objTransaction_WIKIDocument.del_007_WIKI_DocumentParts()
                                                If objTransaction_WIKIDocument.del_005_DateTimeStamp = True Then
                                                    If objTransaction_WIKIDocument.del_004_Revision = True Then
                                                        If objTransaction_WIKIDocument.del_003_ID = True Then
                                                            objTransaction_WIKIDocument.del_002_WIKIDocument()
                                                        End If
                                                    End If
                                                End If



                                                objSemItem_WikiDocument = Nothing

                                            End If

                                        Else
                                            objTransaction_WIKIDocument.save_009_Relation_WIKIImplementation_WIKIDocOld()
                                            objTransaction_WIKIDocument.del_008_History_of()
                                            objTransaction_WIKIDocument.del_007_WIKI_DocumentParts()
                                            If objTransaction_WIKIDocument.del_005_DateTimeStamp = True Then
                                                If objTransaction_WIKIDocument.del_004_Revision = True Then
                                                    If objTransaction_WIKIDocument.del_003_ID = True Then
                                                        objTransaction_WIKIDocument.del_002_WIKIDocument()
                                                    End If
                                                End If
                                            End If



                                            objSemItem_WikiDocument = Nothing
                                        End If
                                    Else
                                        objTransaction_WIKIDocument.del_007_WIKI_DocumentParts()
                                        If objTransaction_WIKIDocument.del_005_DateTimeStamp = True Then
                                            If objTransaction_WIKIDocument.del_004_Revision = True Then
                                                If objTransaction_WIKIDocument.del_003_ID = True Then
                                                    objTransaction_WIKIDocument.del_002_WIKIDocument()
                                                End If
                                            End If
                                        End If



                                        objSemItem_WikiDocument = Nothing
                                    End If
                                Else
                                    objTransaction_WIKIDocument.del_007_WIKI_DocumentParts()
                                    If objTransaction_WIKIDocument.del_005_DateTimeStamp = True Then
                                        If objTransaction_WIKIDocument.del_004_Revision = True Then
                                            If objTransaction_WIKIDocument.del_003_ID = True Then
                                                objTransaction_WIKIDocument.del_002_WIKIDocument()
                                            End If
                                        End If
                                    End If



                                    objSemItem_WikiDocument = Nothing
                                End If
                            Else
                                If objTransaction_WIKIDocument.del_005_DateTimeStamp = True Then
                                    If objTransaction_WIKIDocument.del_004_Revision = True Then
                                        If objTransaction_WIKIDocument.del_003_ID = True Then
                                            objTransaction_WIKIDocument.del_002_WIKIDocument()
                                        End If
                                    End If
                                End If



                                objSemItem_WikiDocument = Nothing
                            End If
                        Else
                            If objTransaction_WIKIDocument.del_004_Revision = True Then
                                If objTransaction_WIKIDocument.del_003_ID = True Then
                                    objTransaction_WIKIDocument.del_002_WIKIDocument()
                                End If
                            End If


                            objSemItem_WikiDocument = Nothing
                        End If
                    Else
                        If objTransaction_WIKIDocument.del_003_ID = True Then
                            objTransaction_WIKIDocument.del_002_WIKIDocument()
                        End If

                        objSemItem_WikiDocument = Nothing
                    End If
                Else
                    objTransaction_WIKIDocument.del_002_WIKIDocument()
                    objSemItem_WikiDocument = Nothing
                End If
            Else
                objSemItem_WikiDocument = Nothing
            End If
        Else
            objSemItem_WikiDocument = Nothing
        End If
        intCountComponent = 0
        Return objSemItem_WikiDocument
    End Function

    Public Function export_XML_For_Import(ByVal objSemItem_WIKIImplementation As clsSemItem, ByVal strUrl_WIKI As String) As String
        Dim objFileStream As IO.TextWriter
        Dim objDRC_Documents As DataRowCollection
        Dim objDRC_File As DataRowCollection
        Dim objDR_Documents As DataRow
        Dim objDRC_WIKIText As DataRowCollection
        Dim objDRC_DateTimeStamp As DataRowCollection
        Dim objSemItem_File As clsSemItem
        Dim objDateTimeStamp As Date
        Dim strXML_Import As String
        Dim strXML_PageList As String
        Dim strPath_File As String
        Dim boolSave As Boolean = True
        Dim strGenerator As String
        Dim strWIKIName As String
        Dim strText_Export As String
        Dim strPage_Text As String
        Dim strYear As String
        Dim strMonth As String
        Dim strDay As String
        Dim strHour As String
        Dim strMinute As String
        Dim strSecond As String
        Dim strIPImporter As String
        Dim strTitle As String

        strXML_Import = get_Text_From_XML(objLocalConfig.SemItem_Token_XML_WIKI_Import.GUID)
        strXML_PageList = get_Text_From_XML(objLocalConfig.SemItem_Token_XML_WIKI_pagelist.GUID)

        objDRC_File = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_WIKIImplementation.GUID, objLocalConfig.SemItem_RelationType_export_to.GUID, objLocalConfig.SemItem_Type_File.GUID).Rows
        If objDRC_File.Count > 0 Then
            objSemItem_File = New clsSemItem
            objSemItem_File.GUID = objDRC_File(0).Item("GUID_Token_Right")
            objSemItem_File.Name = objDRC_File(0).Item("Name_Token_Right")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            strPath_File = objFileWork.get_Path_FileSystemObject(objSemItem_File)
            Try
                If IO.File.Exists(strPath_File) Then
                    IO.File.Delete(strPath_File)
                End If
                objFileStream = New IO.StreamWriter(strPath_File, IO.FileMode.Create)
            Catch ex As Exception
                boolSave = False
                strPath_File = ""
            End Try

        Else
            boolSave = False
            strPath_File = ""
        End If

        If boolSave = True Then
            strGenerator = My.Application.Info.Title
            strWIKIName = HttpUtility.HtmlEncode(objSemItem_WIKIImplementation.Name)
            strText_Export = strXML_Import.Replace("@" & objLocalConfig.SemItem_Token_Variable_generator_name.Name & "@", strGenerator)
            strText_Export = strText_Export.Replace("@" & objLocalConfig.SemItem_Token_Variable_wiki_url.Name & "@", strUrl_WIKI)
            strText_Export = strText_Export.Replace("@" & objLocalConfig.SemItem_Token_Variable_wiki_name.Name & "@", strWIKIName)
            strText_Export = strXML_Import.Substring(0, strXML_Import.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_page_list.Name & "@") - 1)
            objFileStream.Write(strText_Export)
            objDRC_Documents = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_WIKIImplementation.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, objLocalConfig.SemItem_Type_Wiki_Document.GUID).Rows

            For Each objDR_Documents In objDRC_Documents
                objDRC_DateTimeStamp = procA_TokenAttribute_DateTime.GetData_By_GUIDAttribute_And_GUIDToken(objDR_Documents.Item("GUID_Token_Right"), objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID).Rows
                If objDRC_DateTimeStamp.Count > 0 Then
                    objDateTimeStamp = objDRC_DateTimeStamp(0).Item("Val")
                    strYear = objDateTimeStamp.Year
                    strMonth = objDateTimeStamp.Month
                    If strMonth.Length = 1 Then
                        strMonth = "0" & strMonth
                    End If
                    strDay = objDateTimeStamp.Day
                    If strDay.Length = 1 Then
                        strDay = "0" & strDay
                    End If
                    strHour = objDateTimeStamp.Hour
                    If strHour.Length = 1 Then
                        strHour = "0" & strHour
                    End If
                    strMinute = objDateTimeStamp.Minute
                    If strMinute.Length = 1 Then
                        strMinute = "0" & strMinute
                    End If
                    strSecond = objDateTimeStamp.Second
                    If strSecond.Length = 1 Then
                        strSecond = "0" & strSecond
                    End If

                    objDRC_WIKIText = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(objDR_Documents.Item("GUID_Token_Right"), objLocalConfig.SemItem_Attribute_Wiki_Text.GUID).Rows
                    If objDRC_WIKIText.Count > 0 Then
                        strPage_Text = objDRC_WIKIText(0).Item("Val")
                        strText_Export = strXML_PageList.Replace("@" & objLocalConfig.SemItem_Token_Variable_comment.Name & "@", HttpUtility.HtmlEncode(objDR_Documents.Item("Name_Token_Right")))
                        strText_Export = strText_Export.Replace("@" & objLocalConfig.SemItem_Token_Variable_day.Name & "@", strDay)
                        strText_Export = strText_Export.Replace("@" & objLocalConfig.SemItem_Token_Variable_hour.Name & "@", strHour)
                        strText_Export = strText_Export.Replace("@" & objLocalConfig.SemItem_Token_Variable_ip_importer.Name & "@", "")
                        strText_Export = strText_Export.Replace("@" & objLocalConfig.SemItem_Token_Variable_minute.Name & "@", strMinute)
                        strText_Export = strText_Export.Replace("@" & objLocalConfig.SemItem_Token_Variable_month.Name & "@", strMonth)
                        strText_Export = strText_Export.Replace("@" & objLocalConfig.SemItem_Token_Variable_second.Name & "@", strSecond)
                        strText_Export = strText_Export.Replace("@" & objLocalConfig.SemItem_Token_Variable_title.Name & "@", objDR_Documents.Item("Name_Token_Right"))
                        strText_Export = strText_Export.Replace("@" & objLocalConfig.SemItem_Token_Variable_wiki_text.Name & "@", HttpUtility.HtmlEncode(strPage_Text))
                        strText_Export = strText_Export.Replace("@" & objLocalConfig.SemItem_Token_Variable_year.Name & "@", strYear)
                        objFileStream.WriteLine(strText_Export)
                    End If
                End If

            Next
            objFileStream.WriteLine(strXML_Import.Substring(strXML_Import.IndexOf("@" & objLocalConfig.SemItem_Token_Variable_page_list.Name & "@") + ("@" & objLocalConfig.SemItem_Token_Variable_page_list.Name & "@").Length))

            objFileStream.Close()
        End If


        Return strPath_File
    End Function
End Class
