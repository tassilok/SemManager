Imports Sem_Manager
Public Class clsTransaction_Heading
    Private objLocalConfig As clsLocalConfig
    Private objTagWork As clsTagWork
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Int As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_IntTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VarcharMax As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private procA_WIKI_DocumentParts_By_GUIDWikiDoc_And_WIKIHeading As New ds_WikiManagementTableAdapters.proc_WIKI_DocumentParts_By_GUIDWikiDoc_And_WIKIHeadingTableAdapter
    Private objSemItem_Wiki_Document As clsSemItem
    Private objSemItem_Wiki_Heading As clsSemItem
    Private objSemItem_Wiki_DocPart As clsSemItem

    Private GUID_TokenAttribute_Level As Guid
    Private GUID_TokenAttribute_WIKIText As Guid
    Private GUID_TokenAttribute_WIKITextDocPart As Guid
    Private strText As String
    Private intLevel As Integer

    Public Function save_001_WIKI_Heading(ByVal SemItem_Wiki_Heading As clsSemItem) As Boolean
        Dim boolResult As Boolean
        Dim objDRC_Sem As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Wiki_Heading = SemItem_Wiki_Heading
        intLevel = objSemItem_Wiki_Heading.Level
        objDRC_Sem = semtblA_Token.GetData_Token_By_GUID(objSemItem_Wiki_Heading.GUID).Rows
        If objDRC_Sem.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Wiki_Heading.GUID, objSemItem_Wiki_Heading.Name, objSemItem_Wiki_Heading.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        Else
            If objDRC_Sem(0).Item("Name_Token") <> objSemItem_Wiki_Heading.Name Then
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Wiki_Heading.GUID, objSemItem_Wiki_Heading.Name, objSemItem_Wiki_Heading.GUID_Parent, True).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    boolResult = True
                Else
                    boolResult = False
                End If
            Else
                boolResult = True
            End If
        End If
        

        Return boolResult
    End Function

    Public Function del_001_WIKI_Heading() As Boolean
        Dim objDRC_LogState As DataRowCollection
        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Wiki_Heading.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_003_WikiText(ByVal Text As String) As Boolean
        Dim objDRC_WikiText As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        Dim GUID_Token As Guid

        Dim strTag_Open As String
        Dim strTag_Close As String

        Dim boolResult As Boolean

        GUID_TokenAttribute_WIKIText = Nothing

        Select Case intLevel
            Case 1
                GUID_Token = objLocalConfig.SemItem_Token_Wiki_Components__berschrift_1.GUID
            Case 2
                GUID_Token = objLocalConfig.SemItem_Token_Wiki_Components__berschrift_2.GUID
            Case 3
                GUID_Token = objLocalConfig.SemItem_Token_Wiki_Components__berschrift_3.GUID

        End Select
        strText = Text
        strTag_Open = objTagWork.get_Tag(GUID_Token, True)
        strTag_Close = objTagWork.get_Tag(GUID_Token, False)
        strText = strTag_Open & " " & strText & " " & strTag_Close

        objDRC_WikiText = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Wiki_Heading.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID).Rows
        If objDRC_WikiText.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_Wiki_Heading.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, strText, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                GUID_TokenAttribute_WIKIText = objDRC_LogState(0).Item("GUID_TokenAttribute")
                boolResult = True
            Else
                boolResult = False
            End If
        Else
            If objDRC_WikiText(0).Item("VAL_VARCHARMAX") <> strText Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_Wiki_Heading.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, objDRC_WikiText(0).Item("GUID_TokenAttribute"), strText, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                    GUID_TokenAttribute_WIKIText = objDRC_LogState(0).Item("GUID_TokenAttribute")
                    boolResult = True
                Else
                    boolResult = False
                End If
            Else
                GUID_TokenAttribute_WIKIText = objDRC_WikiText(0).Item("GUID_TokenAttribute")
                boolResult = True
            End If
        End If
        Return boolResult
    End Function

    Public Function del_003_WikiText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_WIKIText).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_004_WIKIDocPart() As Boolean
        Dim objDRC_DocPart As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_DocPart = procA_WIKI_DocumentParts_By_GUIDWikiDoc_And_WIKIHeading.GetData(objLocalConfig.SemItem_Type_Wiki_Heading.GUID, _
                                                                                         objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID, _
                                                                                         objLocalConfig.SemItem_Type_Wiki_Document.GUID, _
                                                                                         objLocalConfig.SemItem_RelationType_is.GUID, _
                                                                                         objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                         objSemItem_Wiki_Heading.GUID, _
                                                                                         objSemItem_Wiki_Document.GUID).Rows
        objSemItem_Wiki_DocPart = Nothing
        If objDRC_DocPart.Count = 0 Then
            objSemItem_Wiki_DocPart = New clsSemItem
            objSemItem_Wiki_DocPart.GUID = Guid.NewGuid
            objSemItem_Wiki_DocPart.Name = objSemItem_Wiki_Document.Name & "\" & objSemItem_Wiki_Heading.Name
            If objSemItem_Wiki_DocPart.Name.Length > 255 Then
                objSemItem_Wiki_DocPart.Name = objSemItem_Wiki_DocPart.Name.Substring(0, 255)
            End If
            objSemItem_Wiki_DocPart.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID
            objSemItem_Wiki_DocPart.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Wiki_DocPart.GUID, objSemItem_Wiki_DocPart.Name, objSemItem_Wiki_DocPart.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        Else
            objSemItem_Wiki_DocPart = New clsSemItem
            objSemItem_Wiki_DocPart.GUID = objDRC_DocPart(0).Item("GUID_WikiDocPart")
            objSemItem_Wiki_DocPart.Name = objDRC_DocPart(0).Item("Name_WikiDocPart")
            objSemItem_Wiki_DocPart.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID
            objSemItem_Wiki_DocPart.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            boolResult = True
        End If
        Return boolResult
    End Function
    Public Function del_004_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Wiki_DocPart.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_005_WIKIDocPart_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, strText, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            GUID_TokenAttribute_WIKITextDocPart = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            GUID_TokenAttribute_WIKITextDocPart = Nothing
            Return False
        End If
    End Function

    Public Function del_005_WIKIDocPart_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_WIKITextDocPart).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_006_Rel_WikiDoc_WikiDocPart(Optional ByVal intOrderID As Integer = 0) As Boolean
        Dim objDRC_Rel As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_Rel = semtblA_Token_Token.GetData_By_GUIDs(objSemItem_Wiki_Document.GUID, objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_Rel.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Wiki_Document.GUID, objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, intOrderID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        Else
            If objDRC_Rel(0).Item("OrderID") <> intOrderID Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Wiki_Document.GUID, objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, intOrderID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                    boolResult = True
                Else
                    boolResult = False
                End If
            Else
                boolResult = True
            End If
        End If

        Return boolResult
    End Function

    Public Function del_006_Rel_WikiDoc_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Wiki_Document.GUID, objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Or _
            objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_007_Rel_WikiHeading_WikiDocPart() As Boolean
        Dim objDRC_Rel As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_Rel = semtblA_Token_Token.GetData_By_GUIDs(objSemItem_Wiki_Heading.GUID, objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID).Rows
        If objDRC_Rel.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Wiki_Heading.GUID, objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        Else

            boolResult = True

        End If

        Return boolResult
    End Function

    Public Function del_007_WikiHeading_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Wiki_Heading.GUID, objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Or _
            objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_WikiDocument As clsSemItem)
        objLocalConfig = LocalConfig
        objSemItem_Wiki_Document = SemItem_WikiDocument
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Token_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Int.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VarcharMax.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        procA_WIKI_DocumentParts_By_GUIDWikiDoc_And_WIKIHeading.Connection = objLocalConfig.Connection_Plugin


        objTagWork = New clsTagWork(objLocalConfig)
    End Sub
End Class
