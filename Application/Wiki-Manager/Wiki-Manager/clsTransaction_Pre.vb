Imports Sem_Manager
Public Class clsTransaction_Pre
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VarcharMax As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objTagWork As clsTagWork

    Private objLocalConfig As clsLocalConfig
    Private objSemItem_Wiki_Document As clsSemItem
    Private objSemItem_WIKI_DocPart As clsSemItem
    Private objSemItem_Pre As clsSemItem

    Private GUID_TokenAttribute_WIKITextDocPart As Guid
    Private strText As String
    Private intComponentID As Integer
    Public Function save_001_Pre(ByVal SemItem_Pre As clsSemItem) As Boolean
        Dim objDRC_LogState As DataRowCollection
        objSemItem_Pre = SemItem_Pre

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Pre.GUID, objSemItem_Pre.Name, objSemItem_Pre.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_001_Pre() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Pre.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_002_WIKIText(ByVal Text As String) As Boolean
        Dim objDRC_LogState As DataRowCollection

        strText = Text
        strText = objTagWork.get_Tag(objLocalConfig.SemItem_Token_Wiki_Components_Skript.GUID, True) & strText
        strText = strText & objTagWork.get_Tag(objLocalConfig.SemItem_Token_Wiki_Components_Skript.GUID, False)

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_Pre.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, strText, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            objSemItem_Pre.GUID_Related = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            Return False
        End If
    End Function
    Public Function del_002_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_Pre.GUID_Related).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function save_003_WIKIDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objSemItem_WIKI_DocPart = New clsSemItem
        objSemItem_WIKI_DocPart.GUID = Guid.NewGuid
        objSemItem_WIKI_DocPart.Name = objSemItem_Wiki_Document.Name & "/" & objSemItem_Pre.Name
        If objSemItem_WIKI_DocPart.Name.Length > 255 Then
            objSemItem_WIKI_DocPart.Name = objSemItem_WIKI_DocPart.Name.Substring(0, 254)
        End If
        objSemItem_WIKI_DocPart.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID
        objSemItem_WIKI_DocPart.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_WIKI_DocPart.GUID, objSemItem_WIKI_DocPart.Name, objSemItem_WIKI_DocPart.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function del_003_WIKIDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_WIKI_DocPart.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_004_WIKIDocPart_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_WIKI_DocPart.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, strText, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            GUID_TokenAttribute_WIKITextDocPart = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            GUID_TokenAttribute_WIKITextDocPart = Nothing
            Return False
        End If
    End Function
    Public Function del_004_WIKIDocPart_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_WIKITextDocPart).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function save_005_WIKIDocPart_To_WIKIPre() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Pre.GUID, objSemItem_WIKI_DocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function del_005_WIKIDocPart_To_WIKIPre() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_WIKI_DocPart.GUID, objSemItem_Pre.GUID, objLocalConfig.SemItem_RelationType_is.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function save_006_WIKIDoc_To_WIKIDocPart(ByVal intComponentID As Integer) As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Wiki_Document.GUID, objSemItem_WIKI_DocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, intComponentID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function del_006_WIKIDoc_To_WIKIDocPart() As Integer
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Wiki_Document.GUID, objSemItem_WIKI_DocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
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
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VarcharMax.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        objTagWork = New clsTagWork(objLocalConfig)
    End Sub
End Class
