Imports Sem_Manager
Public Class clsTransaction_BankTransaction
    Private objLocalConfig As clsLocalConfig

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHAR255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_DATETIME As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_BIT As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Real As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_RealTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private objSemItem_BankTransaction As clsSemItem
    Private objSemItem_Auftragskonto As clsSemItem
    Private objSemItem_Gegenkonto As clsSemItem
    Private objSemItem_Currency As clsSemItem
    Private objSemItem_Payment As clsSemItem
    Private objSemItem_BLZ_Gegenkonto As clsSemItem

    Private objSemItem_TokenAttribute_Info As clsSemItem
    Private objSemItem_TokenAttribute_Valutadatum As clsSemItem
    Private objSemItem_TokenAttribute_Zahlungsausgang As clsSemItem
    Private objSemItem_TokenAttribute_BegZahl As clsSemItem
    Private objSemItem_TokenAttribute_Betrag As clsSemItem
    Private objSemItem_TokenAttribute_Buchungstext As clsSemItem
    Private objSemItem_TokenAttribute_Verwendungszweck As clsSemItem

    Public Function save_001_BankTransaction(ByVal SemItem_BankTransaction As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_BankTransaction = SemItem_BankTransaction

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_BankTransaction.GUID, _
                                                             objSemItem_BankTransaction.Name, _
                                                             objSemItem_BankTransaction.GUID_Parent, _
                                                             True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function del_001_BankTransaction(Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_BankTransaction.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_BankTransaction_To_Auftragskonto(ByVal SemItem_Auftragskonto As clsSemItem, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Auftragskonto = SemItem_Auftragskonto
        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_BankTransaction.GUID, _
                                                                objSemItem_Auftragskonto.GUID, _
                                                                objLocalConfig.SemItem_RelationType_Auftragskonto.GUID, 0).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function del_002_BankTransaction_To_Auftragskonto(Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing, Optional ByVal SemItem_Auftragskonto As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Auftragskonto As DataRowCollection
        Dim objDR_Auftragskonto As DataRow

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        If Not SemItem_Auftragskonto Is Nothing Then
            objSemItem_Auftragskonto = SemItem_Auftragskonto
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        If Not objSemItem_Auftragskonto Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_BankTransaction.GUID, _
                                                               objSemItem_Auftragskonto.GUID, _
                                                               objLocalConfig.SemItem_RelationType_Auftragskonto.GUID).Rows
            objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
        Else
            objDRC_Auftragskonto = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_BankTransaction.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_Auftragskonto.GUID, _
                                                                                 objLocalConfig.SemItem_Type_Kontonummer.GUID).Rows
            For Each objDR_Auftragskonto In objDRC_Auftragskonto
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_BankTransaction.GUID, _
                                                               objDR_Auftragskonto.Item("GUID_Token_Right"), _
                                                               objLocalConfig.SemItem_RelationType_Auftragskonto.GUID).Rows
                objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                End If
            Next
        End If
        
        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function save_003_Info_Of_BankTransaction(ByVal strInfo As String, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_BankTransaction.GUID, _
                                                                                 objLocalConfig.SemItem_Attribute_Info.GUID, _
                                                                                 Nothing, _
                                                                                 strInfo, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_TokenAttribute_Info = New clsSemItem
            objSemItem_TokenAttribute_Info.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_Info_Of_BankTransaction(Optional ByVal SemItem_TokenAttribute_Info As clsSemItem = Nothing, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Info As DataRowCollection
        Dim objDR_Info As DataRow

        If Not SemItem_TokenAttribute_Info Is Nothing Then
            objSemItem_TokenAttribute_Info = SemItem_TokenAttribute_Info
        End If

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        If Not objSemItem_TokenAttribute_Info Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_TokenAttribute_Info.GUID).Rows
            objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
        Else
            objDRC_Info = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_BankTransaction.GUID, _
                                                                                                         objLocalConfig.SemItem_Attribute_Info.GUID).Rows
            For Each objDR_Info In objDRC_Info
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Info.Item("GUID_TokenAttribute")).Rows
                objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                End If
            Next
        End If


        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_Valutadatum_Of_BankTransaction(ByVal dateValutadatum As Date, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DATETIME.GetData(objSemItem_BankTransaction.GUID, _
                                                                                 objLocalConfig.SemItem_Attribute_Valutatag.GUID, _
                                                                                 Nothing, _
                                                                                 dateValutadatum, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_TokenAttribute_Valutadatum = New clsSemItem
            objSemItem_TokenAttribute_Valutadatum.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_Valutadatum_Of_BankTransaction(Optional ByVal SemItem_TokenAttribute_ValutaDatum As clsSemItem = Nothing, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Valutadatum As DataRowCollection
        Dim objDR_Valutadatum As DataRow

        If Not SemItem_TokenAttribute_ValutaDatum Is Nothing Then
            objSemItem_TokenAttribute_Valutadatum = SemItem_TokenAttribute_ValutaDatum
        End If

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        If Not objSemItem_TokenAttribute_Valutadatum Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_TokenAttribute_Valutadatum.GUID).Rows
            objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
        Else
            objDRC_Valutadatum = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_BankTransaction.GUID, _
                                                                                                                objLocalConfig.SemItem_Attribute_Valutatag.GUID).Rows
            For Each objDR_Valutadatum In objDRC_Valutadatum
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Valutadatum.Item("GUID_TokenAttribute")).Rows
                objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                End If
            Next
        End If


        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_005_Zahlungsausgang_Of_BankTransaction(ByVal boolZahlungsausgang As Boolean, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_BIT.GetData(objSemItem_BankTransaction.GUID, _
                                                                                 objLocalConfig.SemItem_Attribute_Zahlungsausgang.GUID, _
                                                                                 Nothing, _
                                                                                 boolZahlungsausgang, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_TokenAttribute_Zahlungsausgang = New clsSemItem
            objSemItem_TokenAttribute_Zahlungsausgang.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_Zahlungsausgang_Of_BankTransaction(Optional ByVal SemItem_TokenAttribute_Zahlungsausgang As clsSemItem = Nothing, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Zahlungseingang As DataRowCollection
        Dim objDR_Zahlungseingang As DataRow

        If Not SemItem_TokenAttribute_Zahlungsausgang Is Nothing Then
            objSemItem_TokenAttribute_Zahlungsausgang = SemItem_TokenAttribute_Zahlungsausgang
        End If

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        If Not objSemItem_TokenAttribute_Zahlungsausgang Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_TokenAttribute_Zahlungsausgang.GUID).Rows
            objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")

        Else
            objDRC_Zahlungseingang = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_BankTransaction.GUID, _
                                                                                                                    objLocalConfig.SemItem_Attribute_Zahlungsausgang.GUID).Rows
            For Each objDR_Zahlungseingang In objDRC_Zahlungseingang
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Zahlungseingang.Item("GUID_TokenAttribute")).Rows
                objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                End If
            Next
        End If

        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_006_BegZahl_Of_BankTransaction(ByVal strBegZahl As String, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_BankTransaction.GUID, _
                                                                                 objLocalConfig.SemItem_Attribute_Beg_nstigter_Zahlungspflichtiger.GUID, _
                                                                                 Nothing, _
                                                                                 strBegZahl, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_TokenAttribute_BegZahl = New clsSemItem
            objSemItem_TokenAttribute_BegZahl.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_006_BegZahl_Of_BankTransaction(Optional ByVal SemItem_TokenAttribute_BegZahl As clsSemItem = Nothing, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_BegZahl As DataRowCollection
        Dim objDR_BegZahl As DataRow

        If Not SemItem_TokenAttribute_BegZahl Is Nothing Then
            objSemItem_TokenAttribute_BegZahl = SemItem_TokenAttribute_BegZahl
        End If

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        If Not objSemItem_TokenAttribute_BegZahl Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_TokenAttribute_BegZahl.GUID).Rows
            objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")

        Else
            objDRC_BegZahl = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_BankTransaction.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Beg_nstigter_Zahlungspflichtiger.GUID).Rows
            For Each objDR_BegZahl In objDRC_BegZahl
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_BegZahl.Item("GUID_TokenAttribute")).Rows
                objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                End If
            Next
        End If


        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function


    Public Function save_007_Betrag_Of_BankTransaction(ByVal dblBetrag As Double, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Real.GetData(objSemItem_BankTransaction.GUID, _
                                                                                 objLocalConfig.SemItem_Attribute_Betrag.GUID, _
                                                                                 Nothing, _
                                                                                 dblBetrag, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_TokenAttribute_Betrag = New clsSemItem
            objSemItem_TokenAttribute_Betrag.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_007_Betrag_Of_BankTransaction(Optional ByVal SemItem_TokenAttribute_Betrag As clsSemItem = Nothing, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Betrag As DataRowCollection
        Dim objDR_Betrag As DataRow

        If Not SemItem_TokenAttribute_Betrag Is Nothing Then
            objSemItem_TokenAttribute_Betrag = SemItem_TokenAttribute_Betrag
        End If

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        If Not objSemItem_TokenAttribute_Betrag Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_TokenAttribute_Betrag.GUID).Rows
            objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")

        Else
            objDRC_Betrag = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_BankTransaction.GUID, _
                                                                                                           objLocalConfig.SemItem_Attribute_Betrag.GUID).Rows
            For Each objDR_Betrag In objDRC_Betrag
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Betrag.Item("GUID_TokenAttribute")).Rows
                objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                End If
            Next
        End If


        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_008_Buchungstext_Of_BankTransaction(ByVal strBuchungstext As String, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_BankTransaction.GUID, _
                                                                                 objLocalConfig.SemItem_Attribute_Buchungstext.GUID, _
                                                                                 Nothing, _
                                                                                 strBuchungstext, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_TokenAttribute_Buchungstext = New clsSemItem
            objSemItem_TokenAttribute_Buchungstext.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_008_Buchungstext_Of_BankTransaction(Optional ByVal SemItem_TokenAttribute_Buchungstext As clsSemItem = Nothing, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Buchungstext As DataRowCollection
        Dim objDR_Buchungstext As DataRow

        If Not SemItem_TokenAttribute_Buchungstext Is Nothing Then
            objSemItem_TokenAttribute_Buchungstext = SemItem_TokenAttribute_Buchungstext
        End If

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        If Not objSemItem_TokenAttribute_Buchungstext Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_TokenAttribute_Buchungstext.GUID).Rows
            objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
        Else
            objDRC_Buchungstext = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_BankTransaction.GUID, _
                                                                                                                 objLocalConfig.SemItem_Attribute_Buchungstext.GUID).Rows
            For Each objDR_Buchungstext In objDRC_Buchungstext
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Buchungstext.Item("GUID_TokenAttribute")).Rows
                objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                End If
            Next
        End If


        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_009_Verwendungszweck_Of_BankTransaction(ByVal strVerwendungszweck As String, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_BankTransaction.GUID, _
                                                                                 objLocalConfig.SemItem_Attribute_Verwendungszweck.GUID, _
                                                                                 Nothing, _
                                                                                 strVerwendungszweck, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_TokenAttribute_Verwendungszweck = New clsSemItem
            objSemItem_TokenAttribute_Verwendungszweck.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_009_Verwendungszweck_Of_BankTransaction(Optional ByVal SemItem_TokenAttribute_Verwendungszweck As clsSemItem = Nothing, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Verwendungszweck As DataRowCollection
        Dim objDR_Verwendungszweck As DataRow

        If Not SemItem_TokenAttribute_Verwendungszweck Is Nothing Then
            objSemItem_TokenAttribute_Verwendungszweck = SemItem_TokenAttribute_Verwendungszweck
        End If

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If


        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        If Not objSemItem_TokenAttribute_Verwendungszweck Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_TokenAttribute_Verwendungszweck.GUID).Rows
            objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
        Else
            objDRC_Verwendungszweck = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_BankTransaction.GUID, _
                                                                                                                     objLocalConfig.SemItem_Attribute_Verwendungszweck.GUID).Rows
            For Each objDR_Verwendungszweck In objDRC_Verwendungszweck
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Verwendungszweck.Item("GUID_TokenAttribute")).Rows
                objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                End If
            Next
        End If


        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_010_BankTransaction_To_Currency(ByVal SemItem_Currency As clsSemItem, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Currency = SemItem_Currency
        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_BankTransaction.GUID, _
                                                                objSemItem_Currency.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_010_BankTransaction_To_Currency(Optional ByVal SemItem_Curecny As clsSemItem = Nothing, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Currency As DataRowCollection
        Dim objDR_Currency As DataRow

        If Not SemItem_Curecny Is Nothing Then
            objSemItem_Currency = SemItem_Curecny
        End If

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        If Not objSemItem_Currency Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_BankTransaction.GUID, _
                                                               objSemItem_Currency.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belonging.GUID).Rows
            objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
        Else
            objDRC_Currency = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_BankTransaction.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                            objLocalConfig.SemItem_Type_Currencies.GUID).Rows
            For Each objDR_Currency In objDRC_Currency
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_BankTransaction.GUID, _
                                                               objDR_Currency.Item("GUID_TokeN_Right"), _
                                                               objLocalConfig.SemItem_RelationType_belonging.GUID).Rows
                objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                End If
            Next
        End If
        
        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function
    Public Function save_011_Gegenkonto(ByVal SemItem_Gegenkonto As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Gegenkonto = SemItem_Gegenkonto

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Gegenkonto.GUID, _
                                                             objSemItem_Gegenkonto.Name, _
                                                             objSemItem_Gegenkonto.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function del_011_Gegenkonto(Optional ByVal SemItem_Gegenkonto As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Gegenkonto Is Nothing Then
            objSemItem_Gegenkonto = SemItem_Gegenkonto
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Gegenkonto.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_012_BLZ_Gegenkonto(ByVal SemItem_BLZ_Gegenkonto As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_BLZ_Gegenkonto = SemItem_BLZ_Gegenkonto

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_BLZ_Gegenkonto.GUID, _
                                                             objSemItem_BLZ_Gegenkonto.Name, _
                                                             objSemItem_BLZ_Gegenkonto.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function del_012_BLZ_Gegenkonto(Optional ByVal SemItem_BLZ_Gegenkonto As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_BLZ_Gegenkonto Is Nothing Then
            objSemItem_BLZ_Gegenkonto = SemItem_BLZ_Gegenkonto
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_BLZ_Gegenkonto.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_013_KTO_To_BLZ(Optional ByVal SemItem_Gegenkonto As clsSemItem = Nothing, Optional ByVal SemItem_BLZ_Gegenkonto As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Gegenkonto Is Nothing Then
            objSemItem_Gegenkonto = SemItem_Gegenkonto
        End If

        If Not SemItem_BLZ_Gegenkonto Is Nothing Then
            objSemItem_BLZ_Gegenkonto = SemItem_BLZ_Gegenkonto
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Gegenkonto.GUID, _
                                                                objSemItem_BLZ_Gegenkonto.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function save_014_BankTransaction_To_Gegenkonto(Optional ByVal SemItem_Gegenkonto As clsSemItem = Nothing, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Gegenkonto Is Nothing Then
            objSemItem_Gegenkonto = SemItem_Gegenkonto
        End If


        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_BankTransaction.GUID, _
                                                                objSemItem_Gegenkonto.GUID, _
                                                                objLocalConfig.SemItem_RelationType_Gegenkonto.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function



    Public Function del_014_BankTransaction_To_Gegenkonto(Optional ByVal SemItem_Gegenkonto As clsSemItem = Nothing, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Gegenkonto As DataRowCollection
        Dim objDR_Gegenkonto As DataRow

        If Not SemItem_Gegenkonto Is Nothing Then
            objSemItem_Gegenkonto = SemItem_Gegenkonto
        End If

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        If Not objSemItem_Gegenkonto Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_BankTransaction.GUID, _
                                                               objSemItem_Gegenkonto.GUID, _
                                                               objLocalConfig.SemItem_RelationType_Gegenkonto.GUID).Rows
            objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
        Else
            objDRC_Gegenkonto = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_BankTransaction.GUID, _
                                                                              objLocalConfig.SemItem_RelationType_Gegenkonto.GUID, _
                                                                              objLocalConfig.SemItem_Type_Kontonummer.GUID).Rows
            For Each objDR_Gegenkonto In objDRC_Gegenkonto
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_BankTransaction.GUID, _
                                                               objDR_Gegenkonto.Item("GUID_Token_Right"), _
                                                               objLocalConfig.SemItem_RelationType_Gegenkonto.GUID).Rows
                objSemItem_Result.GUID = objDRC_LogState(0).Item("GUID_Token")
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                End If
            Next
        End If
        
        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function save_015_BankTransaction_To_Payment(ByVal SemItem_Payment As clsSemItem, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Payment = objSemItem_Payment
        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_BankTransaction.GUID, _
                                                                objSemItem_Payment.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_BankTransaction
    End Function

    Public Function del_015_BankTransaction_To_Payment(Optional ByVal SemItem_Payment As clsSemItem = Nothing, Optional ByVal SemItem_BankTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Payment Is Nothing Then
            objSemItem_Payment = SemItem_Payment
        End If

        If Not SemItem_BankTransaction Is Nothing Then
            objSemItem_BankTransaction = SemItem_BankTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_BankTransaction.GUID, _
                                                               objSemItem_Payment.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig



        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenAttribute_VARCHAR255.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_DATETIME.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_BIT.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Real.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
