Imports Sem_Manager
Public Class clsTransaction_WIKITextMarkuped
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VarcharMax As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objTagWork As clsTagWork

    Private objLocalConfig As clsLocalConfig
    Private objSemItem_Wiki_Document As clsSemItem
    Private objSemItem_Wiki_DocPart As clsSemItem
    Private objSemItem_WikiMarkuped As clsSemItem
    Private GUID_TokenAttribute_WIKIDocPart_WIKIText As Guid


    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_WikiDocument As clsSemItem)
        objLocalConfig = LocalConfig
        objSemItem_Wiki_Document = SemItem_WikiDocument
        set_DBConnection()


    End Sub

    Public Function save_001_WikiMarkuped(ByVal SemItem_WikiMarkuped As clsSemItem) As Boolean
        Dim objDRC_LogState As DataRowCollection

        objSemItem_WikiMarkuped = SemItem_WikiMarkuped
        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_WikiMarkuped.GUID, objSemItem_WikiMarkuped.Name, objSemItem_WikiMarkuped.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Function del_001_WikiMarkuped() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_WikiMarkuped.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_002_WikiMarkuped_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_WikiMarkuped.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, objSemItem_WikiMarkuped.Additional1, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function del_002_WikiMarkuped_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_WikiMarkuped.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function save_003_WikiDocPart() As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Wiki_DocPart = New clsSemItem
        objSemItem_Wiki_DocPart.GUID = Guid.NewGuid
        objSemItem_Wiki_DocPart.Name = objSemItem_Wiki_Document.Name & "\" & objSemItem_WikiMarkuped.Name
        If objSemItem_Wiki_DocPart.Name.Length > 255 Then
            objSemItem_Wiki_DocPart.Name = objSemItem_Wiki_DocPart.Name.Substring(0, 254)
        End If
        objSemItem_Wiki_DocPart.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID
        objSemItem_Wiki_DocPart.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Wiki_DocPart.GUID, objSemItem_Wiki_DocPart.Name, objSemItem_Wiki_DocPart.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return objSemItem_Wiki_DocPart
        Else
            Return Nothing
        End If
    End Function
    Public Function del_003_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Wiki_DocPart.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_004_WikiMarkuped_To_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_WikiMarkuped.GUID, objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_004_WikiMarkuped_To_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_WikiMarkuped.GUID, objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_005_WikiDoc_To_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Wiki_Document.GUID, objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, objSemItem_WikiMarkuped.Level).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function del_005_WikiDoc_To_WikiDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Wiki_Document.GUID, objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_006_WIKIDocPart_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_Wiki_DocPart.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, objSemItem_WikiMarkuped.Additional1, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            GUID_TokenAttribute_WIKIDocPart_WIKIText = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_006_WIKIDocPart_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_WIKIDocPart_WIKIText).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
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

        objTagWork = New clsTagWork(objLocalConfig)
    End Sub
End Class
