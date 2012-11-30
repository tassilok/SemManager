Imports Sem_Manager
Public Class clsTransaction_Category
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VarcharMax As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_WIKICategory_of_WIKIImplementation_By_GUIDWikiImpl_AND_NameCategory As New ds_WikiManagementTableAdapters.proc_WIKICategory_of_WIKIImplementation_By_GUIDWikiImpl_AND_NameCategoryTableAdapter

    Private objTagWork As clsTagWork
    Private objLocalConfig As clsLocalConfig
    Private objSemItem_WIKIDoc As clsSemItem
    Private objSemItem_WIKIDocPart As clsSemItem
    Private objSemItem_Category As clsSemItem
    Private objSemItem_WIKIImplementation As clsSemItem

    Private GUID_TokenAttribute_WIKIText_Category As Guid
    Private GUID_TokenAttribute_WIKIText_WIKIDocPart As Guid

    Private strText As String
    Private boolUsed As Boolean
    Private intComponentID As Integer

    Public Function save_001_WIKICategory(ByVal strCategory As String) As Boolean
        Dim objDRC_Category As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        Dim boolResult As Boolean

        objSemItem_Category = New clsSemItem
        objSemItem_Category.Name = strCategory
        objSemItem_Category.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Category.GUID
        objSemItem_Category.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objDRC_Category = procA_WIKICategory_of_WIKIImplementation_By_GUIDWikiImpl_AND_NameCategory.GetData(objLocalConfig.SemItem_Type_WIKI_Implementation.GUID, _
                                                                                                            objLocalConfig.SemItem_Type_Wiki_Document.GUID, _
                                                                                                            objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID, _
                                                                                                            objLocalConfig.SemItem_Type_Wiki_Category.GUID, _
                                                                                                            objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                                            objLocalConfig.SemItem_RelationType_is.GUID, _
                                                                                                            objSemItem_WIKIImplementation.GUID, _
                                                                                                            objSemItem_Category.Name).Rows
        If objDRC_Category.Count = 0 Then
            objSemItem_Category.GUID = Guid.NewGuid
            boolUsed = False
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Category.GUID, objSemItem_Category.Name, objSemItem_Category.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        Else
            objSemItem_Category.GUID = objDRC_Category(0).Item("GUID_WIKICategory")
            boolUsed = True
            boolResult = True
        End If

        Return boolResult
    End Function

   
    Public Function del_001_WIKICategory() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        If boolUsed = False Then
            objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Category.GUID).Rows
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

    Public Function save_002_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        strText = objTagWork.get_Tag(objLocalConfig.SemItem_Token_Wiki_Components_Kategorie.GUID, True)
        strText = strText & objSemItem_Category.Name
        strText = strText & objTagWork.get_Tag(objLocalConfig.SemItem_Token_Wiki_Components_Kategorie.GUID, False)
        If boolUsed = False Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_Category.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, strText, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                GUID_TokenAttribute_WIKIText_Category = objDRC_LogState(0).Item("GUID_TokenAttribute")
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
        
    End Function

    Public Function del_002_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        If boolUsed = False Then
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_WIKIText_Category).Rows
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

    Public Function save_003_WIKIDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objSemItem_WIKIDocPart = New clsSemItem
        objSemItem_WIKIDocPart.GUID = Guid.NewGuid
        objSemItem_WIKIDocPart.Name = objSemItem_WIKIDoc.Name
        objSemItem_WIKIDocPart.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID
        objSemItem_WIKIDocPart.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_WIKIDocPart.GUID, objSemItem_WIKIDocPart.Name, objSemItem_WIKIDocPart.GUID_Parent, True).Rows

        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_003_WIKIDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_WIKIDocPart.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_004_WIKICategory_To_WIKIDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Category.GUID, objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function del_004_WIKICategory_To_WIKIDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Category.GUID, objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_005_WIKIDocPart_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, strText, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            GUID_TokenAttribute_WIKIText_WIKIDocPart = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_005_WIKIDocPart_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_WIKIText_WIKIDocPart).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_006_WIKIDocument_To_WIKIDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_WIKIDoc.GUID, objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, intComponentID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_006_WIKIDocument_To_WIKIDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_WIKIDoc.GUID, objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_WikiDoc As clsSemItem, ByVal SemItem_WikiImplementation As clsSemItem, ByVal ComponentID As Integer)
        objLocalConfig = LocalConfig

        objTagWork = New clsTagWork(objLocalConfig)
        objSemItem_WIKIDoc = SemItem_WikiDoc
        objSemItem_WIKIImplementation = SemItem_WikiImplementation
        intComponentID = ComponentID
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VarcharMax.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        funcA_Token_Token.Connection = objLocalConfig.Connection_DB
        procA_WIKICategory_of_WIKIImplementation_By_GUIDWikiImpl_AND_NameCategory.Connection = objLocalConfig.Connection_Plugin

        objTagWork = New clsTagWork(objLocalConfig)
    End Sub
End Class
