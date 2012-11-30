Imports Sem_Manager
Public Class clsTransaction_WIKILink_intern
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VarcharMax As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objTagWork As clsTagWork
    Private objLocalConfig As clsLocalConfig
    Private objSemItem_Wiki_Document_To_Insert As clsSemItem
    Private objSemItem_Wiki_Document_To_Link As clsSemItem
    Private objSemItem_Wiki_Link As clsSemItem
    Private objSemItem_DocPart As clsSemItem
    Private GUID_TokenAttribute_WIKITextDocPart As Guid

    Private strText As String

    Public Function save_001_WIKILink() As Boolean
        Dim objDRC_LogState As DataRowCollection
        objSemItem_Wiki_Link = New clsSemItem
        objSemItem_Wiki_Link.GUID = Guid.NewGuid
        objSemItem_Wiki_Link.Name = objSemItem_Wiki_Document_To_Link.Name
        objSemItem_Wiki_Link.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Link__intern_.GUID
        objSemItem_Wiki_Link.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Wiki_Link.GUID, objSemItem_Wiki_Link.Name, objSemItem_Wiki_Link.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function del_001_WIKILink() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Wiki_Link.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_002_WIKILink_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        strText = objTagWork.get_Tag(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_.GUID, True) & objSemItem_Wiki_Document_To_Link.Name & _
            objTagWork.get_Tag(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_.GUID, False)

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_Wiki_Link.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, strText, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            objSemItem_Wiki_Link.GUID_Related = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            Return False
        End If

    End Function
    Public Function del_002_WIKILink_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_Wiki_Link.GUID_Related).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_003_WIKILink_To_WIKIDoc() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Wiki_Link.GUID, objSemItem_Wiki_Document_To_Link.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function del_003_WIKILink_to_WIKIDoc() As Boolean
        Dim objDRC_LogStae As DataRowCollection

        objDRC_LogStae = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Wiki_Link.GUID, objSemItem_Wiki_Document_To_Link.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        If objDRC_LogStae(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_004_WikiDocPart() As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_DocPart = New clsSemItem
        objSemItem_DocPart.GUID = Guid.NewGuid
        objSemItem_DocPart.Name = objSemItem_Wiki_Document_To_Insert.Name & "\" & objSemItem_Wiki_Link.Name
        If objSemItem_DocPart.Name.Length > 255 Then
            objSemItem_DocPart.Name = objSemItem_DocPart.Name.Substring(0, 254)

        End If
        objSemItem_DocPart.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID
        objSemItem_DocPart.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DocPart.GUID, objSemItem_DocPart.Name, objSemItem_DocPart.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return objSemItem_DocPart
        Else
            Return Nothing
        End If


    End Function

    Public Function del_004_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_DocPart.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_005_WikiLink_To_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Wiki_Link.GUID, objSemItem_DocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function del_005_WikiLink_To_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Wiki_Link.GUID, objSemItem_DocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_006_WikiDoc_To_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Wiki_Document_To_Insert.GUID, objSemItem_DocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, objSemItem_Wiki_Document_To_Insert.Level).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Function del_006_WikiDoc_To_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Wiki_Document_To_Insert.GUID, objSemItem_DocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function save_007_WIKIDocPart_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection
        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_DocPart.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, strText, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            GUID_TokenAttribute_WIKITextDocPart = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            GUID_TokenAttribute_WIKITextDocPart = Nothing
            Return False
        End If
    End Function

    Public Function del_007_WIKIDocPart_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_WIKITextDocPart).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_WikiDocument_To_Insert As clsSemItem, ByVal SemItem_WikiDocument_To_Link As clsSemItem)
        objLocalConfig = LocalConfig
        objSemItem_Wiki_Document_To_Insert = SemItem_WikiDocument_To_Insert
        objSemItem_Wiki_Document_To_Link = SemItem_WikiDocument_To_Link
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
