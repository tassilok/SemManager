Imports Sem_Manager
Public Class clsTransaction_DeleteDocParts
    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VarcharMax As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private procA_TokenAttribute_VARCHARMAX As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter

    Private objLocalConfig As clsLocalConfig

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Public Function delete_DocPart(ByVal objSemItem_Document As clsSemItem) As Integer
        Dim objDRC_DocParts As DataRowCollection
        Dim objSemItem_DocPart As New clsSemItem

        Dim objDR_DocPart As DataRow

        objDRC_DocParts = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Document.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID).Rows

        For Each objDR_DocPart In objDRC_DocParts
            objSemItem_DocPart.GUID = objDR_DocPart.Item("GUID_Token_Right")
            objSemItem_DocPart.Name = objDR_DocPart.Item("Name_Token_Right")
            objSemItem_DocPart.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID
            objSemItem_DocPart.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_DocPart.Level = objDR_DocPart.Item("OrderID")

            If del_001_WIKIDocument_To_WIKIDocPart(objSemItem_Document, objSemItem_DocPart) = True Then

            Else
                save_001_WIKIDocument_To_WIKIDocPart(objSemItem_Document, objSemItem_DocPart)
            End If
        Next
    End Function

    Private Function del_001_WIKIDocument_To_WIKIDocPart(ByVal objSemItem_WIKIDocument As clsSemItem, ByVal objSemItem_WIKIDocPart As clsSemItem) As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_WIKIDocument.GUID, objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function save_001_WIKIDocument_To_WIKIDocPart(ByVal objSemItem_WIKIDocument As clsSemItem, ByVal objSemItem_WIKIDocPart As clsSemItem) As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_WIKIDocument.GUID, objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, objSemItem_WIKIDocPart.Level).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function del_002_WIKIComponent_Of_WIKIDocPart(ByVal objSemItem_WIKIDocPart As clsSemItem) As clsSemItem()
        Dim objDRC_Component_Of_DocPart As DataRowCollection
        Dim objDR_Component_Of_DocPart As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItems_Components() As clsSemItem = Nothing
        Dim objSemItem_Component As New clsSemItem
        Dim intID As Integer

        objDRC_Component_Of_DocPart = funcA_Token_Token.GetData_By_GUDTokenRight_And_GUIDRelationType(objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID).Rows
        For Each objDR_Component_Of_DocPart In objDRC_Component_Of_DocPart
            objSemItem_Component.GUID = objDR_Component_Of_DocPart.Item("GUID_Token_Left")
            objSemItem_Component.Name = objDR_Component_Of_DocPart.Item("Name_Token_Left")
            objSemItem_Component.GUID_Parent = objDR_Component_Of_DocPart.Item("GUID_Type_Left")
            objSemItem_Component.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Component.GUID_Related = objSemItem_WIKIDocPart.GUID
            If delete_003_Component_Rels_And_Attribus(objSemItem_Component) = True Then
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDR_Component_Of_DocPart.Item("GUID_Token_Left"), objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    If objSemItems_Components Is Nothing Then
                        intID = 0
                        ReDim Preserve objSemItems_Components(intID)
                    Else
                        intID = objSemItems_Components.Length
                        ReDim Preserve objSemItems_Components(intID)
                    End If
                    objSemItems_Components(intID) = New clsSemItem
                    objSemItems_Components(intID).GUID = objDR_Component_Of_DocPart.Item("GUID_Token_Left")
                    objSemItems_Components(intID).Name = objDR_Component_Of_DocPart.Item("Name_Token_Left")
                    objSemItems_Components(intID).GUID_Parent = objDR_Component_Of_DocPart.Item("GUID_Type_Left")
                    objSemItems_Components(intID).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objSemItems_Components(intID).GUID_Related = objSemItem_WIKIDocPart.GUID
                    objSemItems_Components(intID).deleted = True
                Else
                    objSemItems_Components = save_002_WIKIComponents_Of_WIKIDocPart(objSemItems_Components)
                    Exit For
                End If
            Else
                objSemItems_Components = save_002_WIKIComponents_Of_WIKIDocPart(objSemItems_Components)
                Exit For
            End If

            
        Next

        Return objSemItems_Components
    End Function

    Private Function save_002_WIKIComponents_Of_WIKIDocPart(ByVal objSemItems_Deleted_Component() As clsSemItem) As clsSemItem()
        Dim objSemItem_Deleted_Component As clsSemItem
        Dim objSemItems_Added_Components() As clsSemItem = Nothing
        Dim objDRC_LogState As DataRowCollection
        Dim intID As Integer

        If Not objSemItems_Deleted_Component Is Nothing Then
            For Each objSemItem_Deleted_Component In objSemItems_Deleted_Component
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Deleted_Component.GUID, objSemItem_Deleted_Component.GUID_Related, objLocalConfig.SemItem_RelationType_is.GUID, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    If objSemItems_Added_Components Is Nothing Then
                        intID = 0
                    Else
                        intID = objSemItems_Added_Components.Length
                    End If
                    ReDim Preserve objSemItems_Added_Components(intID)
                    objSemItems_Added_Components(intID) = New clsSemItem
                    objSemItems_Added_Components(intID).GUID = objSemItem_Deleted_Component.GUID
                    objSemItems_Added_Components(intID).Name = objSemItem_Deleted_Component.Name
                    objSemItems_Added_Components(intID).GUID_Parent = objSemItem_Deleted_Component.GUID_Parent
                    objSemItems_Added_Components(intID).GUID_Type = objSemItem_Deleted_Component.GUID_Type
                    objSemItems_Added_Components(intID).GUID_Related = objSemItem_Deleted_Component.GUID_Related
                    objSemItems_Added_Components(intID).deleted = False
                End If
            Next
        End If

        Return objSemItems_Added_Components
    End Function

    Private Function delete_003_Component_Rels_And_Attribus(ByVal objSemItem_Component As clsSemItem) As Boolean
        Dim boolResult As Boolean

        Select Case objSemItem_Component.GUID_Parent
            Case objLocalConfig.SemItem_Type_Wiki_Category.GUID
                If del_004_Category(objSemItem_Component) = False Then
                    boolResult = False
                    If save_004_Category(objSemItem_Component) = False Then
                        boolResult = False
                    End If
                End If
            Case objLocalConfig.SemItem_Type_Wiki_Heading.GUID
                If del_005_ComponentSimple(objSemItem_Component) = False Then
                    boolResult = False
                    If save_005_ComponentSimple(objSemItem_Component) = False Then
                        boolResult = False
                    End If
                End If

            Case objLocalConfig.SemItem_Type_Wiki_Table.GUID

            Case objLocalConfig.SemItem_Type_WIKI_Pre.GUID
                If del_005_ComponentSimple(objSemItem_Component) = False Then
                    boolResult = False
                    If save_005_ComponentSimple(objSemItem_Component) = False Then
                        boolResult = False
                    End If
                End If
            Case objLocalConfig.SemItem_Type_Wiki_Link__intern_.GUID

            Case objLocalConfig.SemItem_Type_WIKI_Text__Markuped_.GUID
                If del_005_ComponentSimple(objSemItem_Component) = False Then
                    boolResult = False
                    If save_005_ComponentSimple(objSemItem_Component) = False Then
                        boolResult = False
                    End If
                End If
        End Select
    End Function

    Private Function del_004_Category(ByVal objSemItem_Component As clsSemItem) As Boolean
        Dim objDRC_DocumentParts As DataRowCollection
        Dim objDRC_WIKIText As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_DocumentPart As DataRow
        Dim boolResult As Boolean = True


        objDRC_WIKIText = procA_TokenAttribute_VARCHARMAX.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_Component.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID).Rows
        If objDRC_WIKIText.Count > 0 Then
            objSemItem_Component.GUID_Relation = objDRC_WIKIText(0).Item("GUID_TokenAttribute")
            objSemItem_Component.Additional1 = objDRC_WIKIText(0).Item("Val")
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_Component.GUID_Relation).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        End If
        If boolResult = True Then
            objDRC_DocumentParts = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Component.GUID, objLocalConfig.SemItem_RelationType_is.GUID, objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID).Rows
            For Each objDR_DocumentPart In objDRC_DocumentParts
                If Not objDR_DocumentPart.Item("GUID_Token_Right") = objSemItem_Component.GUID_Related Then
                    boolResult = False
                    Exit For
                End If
            Next
            If boolResult = True Then
                objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Component.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    boolResult = False
                Else
                    boolResult = False
                End If
            End If
        End If

        Return boolResult
    End Function

    Private Function save_004_Category(ByVal objSemItem_Component As clsSemItem) As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Component.GUID, objSemItem_Component.Name, objSemItem_Component.GUID_Type, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Or _
            objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then

            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_Component.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, objSemItem_Component.GUID_Relation, objSemItem_Component.Additional1, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Or _
                objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then

                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If
    End Function

    Private Function del_005_ComponentSimple(ByVal objSemItem_Component As clsSemItem) As Boolean
        Dim objDRC_DocumentParts As DataRowCollection
        Dim objDRC_WIKIText As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_DocumentPart As DataRow
        Dim boolResult As Boolean = True


        objDRC_WIKIText = procA_TokenAttribute_VARCHARMAX.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_Component.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID).Rows
        If objDRC_WIKIText.Count > 0 Then
            objSemItem_Component.GUID_Relation = objDRC_WIKIText(0).Item("GUID_TokenAttribute")
            objSemItem_Component.Additional1 = objDRC_WIKIText(0).Item("Val")
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_Component.GUID_Relation).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Component.GUID, objSemItem_Component.GUID_Related, objLocalConfig.SemItem_RelationType_is.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    boolResult = True
                Else
                    boolResult = False
                End If

            Else
                boolResult = False
            End If
        End If

        Return boolResult
    End Function

    Private Function save_005_ComponentSimple(ByVal objSemItem_Component As clsSemItem) As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_Component.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, objSemItem_Component.GUID_Relation, objSemItem_Component.Additional1, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Or _
            objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Component.GUID, objSemItem_Component.GUID_Related, objLocalConfig.SemItem_RelationType_is.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Or _
                objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then

                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If

    End Function
    Private Sub set_DBConnection()
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VarcharMax.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        procA_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB

        funcA_Token_Token.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
