Imports Sem_Manager
Public Class clsTransaction_WIKIDocument

    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private funcA_WIKIDocument_Data_Of_WIKIImplementation As New ds_WikiManagementTableAdapters.func_WIKIDocument_Data_Of_WIKIImplementationTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VarcharMax As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Int As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_IntTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_DateTime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objLocalConfig As clsLocalConfig
    Private objSemItem_WikiDocument As clsSemItem
    Private objSemItem_WikiDocument_old As clsSemItem
    Private objSemItem_WikiImplementation As clsSemItem

    Private GUID_TokenAttribute_ID As Guid
    Private GUID_TokenAttribute_Revision As Guid
    Private GUID_TokenAttribute_DateTimeStamp As Guid
    Private GUID_TokenAttribute_WIKIText As Guid

    Private GUIDs_DocumentParts() As Guid = Nothing

    Private dateDateTimeStamp As Date
    Private intID As Integer
    Private intRevision As Integer

    Public Function get_001_Data(ByVal SemItem_WikiImplementation As clsSemItem, ByVal strName_Document As String) As Boolean
        Dim objDRC_Document As DataRowCollection
        Dim boolResult As Boolean

        dateDateTimeStamp = Now
        objSemItem_WikiImplementation = SemItem_WikiImplementation
        objSemItem_WikiDocument = New clsSemItem
        objSemItem_WikiDocument.GUID = Guid.NewGuid
        objSemItem_WikiDocument.Name = strName_Document
        objSemItem_WikiDocument.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Document.GUID
        objSemItem_WikiDocument.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


        objDRC_Document = funcA_WIKIDocument_Data_Of_WIKIImplementation.GetData_By_GUIDImplementation_And_NameDocument(objLocalConfig.SemItem_Attribute_Revision.GUID, _
                                                                                                                       objLocalConfig.SemItem_Attribute_ID.GUID, _
                                                                                                                       objLocalConfig.SemItem_Type_WIKI_Implementation.GUID, _
                                                                                                                       objLocalConfig.SemItem_Type_Wiki_Document.GUID, _
                                                                                                                       objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                                                        objSemItem_WikiImplementation.GUID, _
                                                                                                                        objSemItem_WikiDocument.Name).Rows


        If objDRC_Document.Count > 0 Then


            objSemItem_WikiDocument_old = New clsSemItem
            objSemItem_WikiDocument_old.GUID = objDRC_Document(0).Item("GUID_WIKIDocument")
            objSemItem_WikiDocument_old.Name = objDRC_Document(0).Item("Name_WIKIDocument")
            objSemItem_WikiDocument_old.GUID_Parent = objDRC_Document(0).Item("GUID_Type_WIKIDocument")
            objSemItem_WikiDocument_old.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            intID = objDRC_Document(0).Item("ID")

            intRevision = objDRC_Document(0).Item("Revision") + 1

            boolResult = True
        Else
            objSemItem_WikiDocument_old = Nothing
            intID = 0
            intRevision = 0
            boolResult = True
        End If

        Return boolResult
    End Function

    Public Function save_002_WIKIDocument(ByVal SemItem_WikiDocument As clsSemItem) As Boolean
        Dim objDRC_LogState As DataRowCollection

        objSemItem_WikiDocument = SemItem_WikiDocument
        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_WikiDocument.GUID, objSemItem_WikiDocument.Name, objSemItem_WikiDocument.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_002_WIKIDocument() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_WikiDocument.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_003_ID() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Int.GetData(objSemItem_WikiDocument.GUID, objLocalConfig.SemItem_Attribute_ID.GUID, Nothing, intID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            GUID_TokenAttribute_ID = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            GUID_TokenAttribute_ID = Nothing
            Return False
        End If
    End Function

    Public Function del_003_ID() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_ID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_004_Revision() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Int.GetData(objSemItem_WikiDocument.GUID, objLocalConfig.SemItem_Attribute_Revision.GUID, Nothing, intRevision, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            GUID_TokenAttribute_Revision = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            GUID_TokenAttribute_Revision = Nothing
            Return False
        End If
    End Function

    Public Function del_004_Revision() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_Revision).Rows
    End Function

    Public Function save_005_DateTimeStamp() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DateTime.GetData(objSemItem_WikiDocument.GUID, objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, Nothing, dateDateTimeStamp, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            GUID_TokenAttribute_DateTimeStamp = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            GUID_TokenAttribute_DateTimeStamp = Nothing
            Return False
        End If
    End Function

    Public Function del_005_DateTimeStamp() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_DateTimeStamp).rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_006_old_Text() As Boolean
        Dim objSemItem_WikiDocument_old As clsSemItem
        Dim objDRC_WIKIText As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim intGUIDCount As Integer = 0
        Dim boolResult As Boolean
        GUID_TokenAttribute_WIKIText = Nothing
        If objSemItem_WikiDocument_old Is Nothing Then
            boolResult = True
        Else

            objDRC_WIKIText = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_WikiDocument_old.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID).Rows
            If objDRC_WIKIText.Count > 0 Then
                If Not IsDBNull(objDRC_WIKIText(0).Item("VAL_VARCHARMAX")) Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_WikiDocument.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, objDRC_WIKIText(0).Item("VAL_VARCHARMAX"), 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then

                        GUID_TokenAttribute_WIKIText = objDRC_LogState(0).Item("GUID_TokenAttribute")
                        boolResult = True
                    Else

                        GUID_TokenAttribute_WIKIText = Nothing
                        boolResult = False
                    End If
                Else

                    GUID_TokenAttribute_WIKIText = Nothing
                    boolResult = False
                End If
            Else

                GUID_TokenAttribute_WIKIText = Nothing
                boolResult = True
            End If

        End If
        Return boolResult
    End Function

    Public Function del_006_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        If Not GUID_TokenAttribute_WIKIText = Nothing Then

            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_WIKIText).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If


        Else
            boolResult = True
        End If
        Return boolResult
    End Function

    Public Function save_007_WIKIDocumentParts(ByVal boolDocumentParts As Boolean) As Boolean
        Dim objDRC_DocParts As DataRowCollection
        Dim objDR_DocParts As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean = True
        Dim intDocPartsCount As Integer

        If boolDocumentParts = True Then
            If Not objSemItem_WikiDocument_old Is Nothing Then

                objDRC_DocParts = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_WikiDocument_old.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID).Rows
                For Each objDR_DocParts In objDRC_DocParts
                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_WikiDocument.GUID, objDR_DocParts.Item("GUID_Token_Right"), objLocalConfig.SemItem_RelationType_contains.GUID, objDR_DocParts.Item("OrderID")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        If GUIDs_DocumentParts Is Nothing Then
                            intDocPartsCount = 0
                        Else
                            intDocPartsCount = GUIDs_DocumentParts.Length
                        End If
                        ReDim Preserve GUIDs_DocumentParts(intDocPartsCount)
                        GUIDs_DocumentParts(intDocPartsCount) = objDR_DocParts.Item("GUID_Token_Right")
                    Else
                        boolResult = False
                        Exit For
                    End If
                Next


            Else
                boolResult = True
            End If
        Else
            boolResult = True
        End If
        

        Return boolResult
    End Function

    Public Function del_007_WIKI_DocumentParts() As Boolean
        Dim GUID_DocPart As Guid
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean = True

        If Not GUIDs_DocumentParts Is Nothing Then
            For Each GUID_DocPart In GUIDs_DocumentParts
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_WikiDocument.GUID, GUID_DocPart, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    boolResult = False
                End If
            Next
        Else
            boolResult = True
        End If
        Return boolResult
    End Function

    Public Function save_008_History_of() As Boolean
        Dim objDRC_LogState As DataRowCollection
        If Not objSemItem_WikiDocument_old Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_WikiDocument.GUID, objSemItem_WikiDocument_old.GUID, objLocalConfig.SemItem_RelationType_belonging_history.GUID, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
        
    End Function

    Public Function del_008_History_of() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_WikiDocument.GUID, objSemItem_WikiDocument_old.GUID, objLocalConfig.SemItem_RelationType_belonging_history.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_009_Relation_WIKIImplementation_WIKIDocOld() As Boolean
        Dim objDRC_LogState As DataRowCollection

        If Not objSemItem_WikiDocument_old Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_WikiImplementation.GUID, objSemItem_WikiDocument_old.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
        
    End Function

    Public Function save_009_Relation_WIKIImplementation_WIKIDocOld() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_WikiImplementation.GUID, objSemItem_WikiDocument_old.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_010_Relation_WIKIImplementation_WIKIDoc() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_WikiImplementation.GUID, objSemItem_WikiDocument.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_010_Relation_WIKIImplementation_WIKIDoc() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_WikiImplementation.GUID, objSemItem_WikiDocument.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VarcharMax.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Int.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_DateTime.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        funcA_Token_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        funcA_WIKIDocument_Data_Of_WIKIImplementation.Connection = objLocalConfig.Connection_Plugin
    End Sub
End Class
