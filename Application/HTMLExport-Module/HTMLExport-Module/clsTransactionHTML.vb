Imports Sem_Manager
Public Class clsTransactionHTML

    Private objLocalConfig As clsLocalConfig

    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objSemItem_HTMLDocument As clsSemItem
    Private objSemItem_Intro As clsSemItem
    Private objSemItem_TokenAttribute_Intro As clsSemItem
    Private intOrderID_Last As Integer

    Private semtblT_DocumentParts As New ds_SemDB.semtbl_TokenDataTable

    Public Sub clear_DocumentParts()
        semtblT_DocumentParts.Clear()
    End Sub

    Public Function save_001_HTMLDoc(ByVal SemItem_HTMLDocument As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_HTMLDocument = SemItem_HTMLDocument

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_HTMLDocument.GUID, _
                                                             objSemItem_HTMLDocument.Name, _
                                                             objSemItem_HTMLDocument.GUID_Parent, _
                                                             True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function del_001_HTMLDoc(Optional ByVal SemItem_HTMLDocument As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_HTMLDocument Is Nothing Then
            objSemItem_HTMLDocument = SemItem_HTMLDocument
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_HTMLDocument.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID _
            And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_DocumentPart(ByVal SemItem_DocumentPart As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        
        Dim i As Integer

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For i = 0 To semtblT_DocumentParts.Rows.Count - 1
            If semtblT_DocumentParts.Rows(i).Item("GUID_Token") = SemItem_DocumentPart.GUID Then
                If Not semtblT_DocumentParts.Rows(i).Item("OrderID") = SemItem_DocumentPart.Level Then
                    semtblT_DocumentParts.Rows(i).Item("OrderID") = SemItem_DocumentPart.Level

                End If
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Exit For
            End If

        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            intOrderID_Last = get_LastOrderID() + 1

            semtblT_DocumentParts.Rows.Add(SemItem_DocumentPart.GUID, _
                                           SemItem_DocumentPart.Name, _
                                           SemItem_DocumentPart.GUID_Parent, _
                                           intOrderID_Last)

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(SemItem_DocumentPart.GUID, _
                                                                 SemItem_DocumentPart.Name, _
                                                                 SemItem_DocumentPart.GUID_Parent, True).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        End If

        Return objSemItem_Result

    End Function

    Public Function del_002_DocumentPart(Optional ByVal OrderID As Integer = -1) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRs_Parts() As DataRow
        Dim intOrderID As Integer

        If Not OrderID = -1 Then
            intOrderID = OrderID
        Else
            intOrderID = intOrderID_Last
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRs_Parts = semtblT_DocumentParts.Select("OrderID=" & intOrderID)

        If objDRs_Parts.Count > 0 Then
            objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objDRs_Parts(0).Item("GUID_Token")).Rows
            If Not objDRC_LogState(0).Item("GUID_token") = objLocalConfig.Globals.LogState_Error.GUID _
                And Not objDRC_LogState(0).Item("GUID_token") = objLocalConfig.Globals.LogState_Relation.GUID Then

                objDRs_Parts(0).Delete()
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Return objSemItem_Result
    End Function

    Public Function save_003_Document_To_DocumentPart(Optional ByVal SemItem_Document As clsSemItem = Nothing, Optional ByVal OrderID As Integer = -1) As clsSemItem
        Dim intOrderID As Integer
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRs_Parts() As DataRow

        If Not OrderID = -1 Then
            intOrderID = OrderID
        Else
            intOrderID = intOrderID_Last
        End If

        If Not SemItem_Document Is Nothing Then
            objSemItem_HTMLDocument = SemItem_Document
        End If

        objDRs_Parts = semtblT_DocumentParts.Select("OrderID=" & intOrderID)
        If objDRs_Parts.Count > 0 Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_HTMLDocument.GUID, _
                                                                    objDRs_Parts(0).Item("GUID_Token"), _
                                                                    objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                    objDRs_Parts(0).Item("OrderID")).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_Document_To_DocumentPart(Optional ByVal SemItem_Document As clsSemItem = Nothing, Optional ByVal OrderID As Integer = -1) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRs_Parts() As DataRow
        Dim intOrderID As Integer

        If Not OrderID = -1 Then
            intOrderID = OrderID
        Else
            intOrderID = intOrderID_Last
        End If

        If Not SemItem_Document Is Nothing Then
            objSemItem_HTMLDocument = SemItem_Document
        End If

        objDRs_Parts = semtblT_DocumentParts.Select("OrderID=" & intOrderID)
        If objDRs_Parts.Count > 0 Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_HTMLDocument.GUID, _
                                                 objDRs_Parts(0).Item("GUID_Token"), _
                                                 objLocalConfig.SemItem_RelationType_contains.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_Document_To_Intro(ByVal SemItem_Intro As clsSemItem, Optional ByVal SemItem_HTMLDocument As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Intro As DataRowCollection
        Dim objDR_Intro As DataRow
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Intro = SemItem_Intro

        If Not SemItem_HTMLDocument Is Nothing Then
            objSemItem_HTMLDocument = objSemItem_HTMLDocument
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_Intro = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_HTMLDocument.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_Intro.GUID).Rows

        For Each objDR_Intro In objDRC_Intro
            If objDR_Intro.Item("VAL_VARCHARMAX") = objSemItem_Intro.Additional1 Then
                objSemItem_TokenAttribute_Intro = New clsSemItem
                objSemItem_TokenAttribute_Intro.GUID = objDR_Intro.Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Intro.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_HTMLDocument.GUID, _
                                                                                     objLocalConfig.SemItem_Attribute_Intro.GUID, _
                                                                                     Nothing, _
                                                                                     objSemItem_Intro.Additional1, 1).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_Document_To_Intro(Optional ByVal SemItem_HTMLDocument As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Intro As DataRowCollection
        Dim objDR_Intro As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_HTMLDocument Is Nothing Then
            objSemItem_HTMLDocument = objSemItem_HTMLDocument
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_Intro = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_HTMLDocument.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_Intro.GUID).Rows

        For Each objDR_Intro In objDRC_Intro
            
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Intro.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        Return objSemItem_Result
    End Function

    Private Function get_LastOrderID() As Integer
        Dim objDataView_Parts As DataView
        Dim objDataRowView As DataRowView
        Dim objDR_LastPart As DataRow
        Dim intOrderID_Last As Integer
        If semtblT_DocumentParts.Rows.Count > 0 Then
            objDataView_Parts = semtblT_DocumentParts.AsDataView
            objDataView_Parts.Sort = "OrderID"
            objDataRowView = objDataView_Parts.Item(objDataView_Parts.Count - 1)
            objDR_LastPart = objDataRowView.Row.Item("OrderID")

            intOrderID_Last = objDR_LastPart.Item("OrderID")
        Else
            intOrderID_Last = 0
        End If

        Return intOrderID_Last
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()

        intOrderID_Last = 0
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB


        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
    End Sub
End Class