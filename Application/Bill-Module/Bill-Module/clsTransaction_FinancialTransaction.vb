Imports Sem_Manager
Public Class clsTransaction_FinancialTransaction
    Private objLocalConfig As clsLocalConfig

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private procA_Menge As New ds_FinancialTransactionTableAdapters.proc_MengeTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Datetime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHAR255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_REAL As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_RealTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objSemItem_FinancialTransaction As clsSemItem
    Private objSemItem_FinancialTransaction_Sub As clsSemItem
    Private objSemItem_TokenAttribute_TransactionDate As clsSemItem
    Private objSemItem_TokenAttribute_TransactionID As clsSemItem
    Private objSemItem_TokenAttribute_ToPay As clsSemItem
    Private objSemItem_TokenAttribute_Gross As clsSemItem
    Private objSemItem_TokenAttribute_PercentPart As clsSemItem
    Private objSemItem_Menge As clsSemItem
    Private objSemItem_Currency As clsSemItem
    Private objSemItem_Einheit As clsSemItem
    Private objSemItem_Contractor As clsSemItem
    Private objSemItem_Contractee As clsSemItem
    Private objSemItem_TaxRate As clsSemItem
    Private objSemItem_Payment As clsSemItem
    Private objSemItem_Sparkasse As clsSemItem
    Private objSemItem_TokenAttribute_Payment__Amount As clsSemItem
    Private objSemItem_TokenAttribute_Payment_TransactionDate As clsSemItem

    Private GUID_TokenAttribute_Menge As Guid

    Public Property SemItem_TokenAttribute_TransactionDate As clsSemItem
        Get
            Return objSemItem_TokenAttribute_TransactionDate
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_TokenAttribute_TransactionDate = value
        End Set
    End Property

    Public ReadOnly Property SemItem_FinancialTransaction As clsSemItem
        Get
            Return objSemItem_FinancialTransaction
        End Get
    End Property

    Public Function save_001_FinancialTransaction(ByVal SemItem_FinancialTransaction As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_FinancialTransaction = SemItem_FinancialTransaction

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_FinancialTransaction.GUID, _
                                                             objSemItem_FinancialTransaction.Name, _
                                                             objSemItem_FinancialTransaction.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else

            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        Return objSemItem_Result
    End Function

    Public Function del_001_FinancialTransaction(Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_FinancialTransaction.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_TransactionDate(ByVal dateTransactionDate As Date, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_TransactionDate As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim boolAdd As Boolean = True
        Dim i As Integer

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        objDRC_TransactionDate = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_FinancialTransaction.GUID, _
                                                                                                                objLocalConfig.SemItem_Attribute_Transaction_Date.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For i = 0 To objDRC_TransactionDate.Count - 1
            If i = 0 Then
                boolAdd = False
                If Not objDRC_TransactionDate(i).Item("Val_Datetime") = dateTransactionDate Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                                                       objDRC_TransactionDate(i).Item("GUID_TokenAttribute"), _
                                                                                       dateTransactionDate, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_TokenAttribute_TransactionDate = New clsSemItem
                        objSemItem_TokenAttribute_TransactionDate.GUID = objDRC_TransactionDate(i).Item("GUID_TokenAttribute")
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        boolAdd = False
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If

                End If
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_TransactionDate(i).Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If

        Next

        If boolAdd = True Then
            If objSemItem_TokenAttribute_TransactionDate Is Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                                                       Nothing, _
                                                                                       dateTransactionDate, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    objSemItem_TokenAttribute_TransactionDate = New clsSemItem
                    objSemItem_TokenAttribute_TransactionDate.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")

                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                                                       objSemItem_TokenAttribute_TransactionDate.GUID, _
                                                                                       dateTransactionDate, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then

                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

        End If
        Return objSemItem_Result
    End Function

    Public Function del_002_TransactionDate(Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_TransactionDate As DataRowCollection
        Dim objDR_TransactionDate As DataRow

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_TransactionDate = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_FinancialTransaction.GUID, _
                                                                                                                objLocalConfig.SemItem_Attribute_Transaction_Date.GUID).Rows
        For Each objDR_TransactionDate In objDRC_TransactionDate
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_TransactionDate.Item("GUID_TokenAttribute")).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_003_TransactionID(ByVal strTransactionID As String, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_TransactionID As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim boolAdd As Boolean = True
        Dim i As Integer

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If


        objDRC_TransactionID = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_FinancialTransaction.GUID, _
                                                                                                                objLocalConfig.SemItem_Attribute_Transaction_ID.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For i = 0 To objDRC_TransactionID.Count - 1

            If i = 0 Then
                boolAdd = False
                If Not objDRC_TransactionID(i).Item("Val_VARCHAR255") = strTransactionID Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Transaction_ID.GUID, _
                                                                                       objDRC_TransactionID(i).Item("GUID_TokenAttribute"), _
                                                                                       strTransactionID, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_TokenAttribute_TransactionID = New clsSemItem
                        objSemItem_TokenAttribute_TransactionID.GUID = objDRC_TransactionID(i).Item("GUID_TokenAttribute")
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        boolAdd = False
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If

                End If
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_TransactionID(i).Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If boolAdd = True Then
            If objSemItem_TokenAttribute_TransactionID Is Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Transaction_ID.GUID, _
                                                                                       Nothing, _
                                                                                       strTransactionID, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    objSemItem_TokenAttribute_TransactionID = New clsSemItem
                    objSemItem_TokenAttribute_TransactionID.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")

                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Transaction_ID.GUID, _
                                                                                       objSemItem_TokenAttribute_TransactionID.GUID, _
                                                                                       strTransactionID, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then

                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

        End If
        Return objSemItem_Result
    End Function

    Public Function del_003_TransactionID(Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_TransactionDate As DataRowCollection
        Dim objDR_TransactionDate As DataRow

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_TransactionDate = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_FinancialTransaction.GUID, _
                                                                                                                objLocalConfig.SemItem_Attribute_Transaction_ID.GUID).Rows
        For Each objDR_TransactionDate In objDRC_TransactionDate
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_TransactionDate.Item("GUID_TokenAttribute")).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_004_ToPay(ByVal dblToPay As Double, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_TransactionID As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim boolAdd As Boolean = True
        Dim i As Integer

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        objDRC_TransactionID = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_FinancialTransaction.GUID, _
                                                                                                                objLocalConfig.SemItem_Attribute_to_Pay.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For i = 0 To objDRC_TransactionID.Count - 1

            If i = 0 Then
                boolAdd = False
                If Not objDRC_TransactionID(i).Item("Val_Real") = dblToPay Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_REAL.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                                                       objDRC_TransactionID(i).Item("GUID_TokenAttribute"), _
                                                                                       dblToPay, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_TokenAttribute_Payment__Amount = New clsSemItem
                        objSemItem_TokenAttribute_Payment__Amount.GUID = objDRC_TransactionID(i).Item("GUID_TokenAttribute")
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        boolAdd = False
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If

                End If
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_TransactionID(i).Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If boolAdd = True Then
            If objSemItem_TokenAttribute_ToPay Is Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_REAL.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                                                       Nothing, _
                                                                                       dblToPay, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    objSemItem_TokenAttribute_ToPay = New clsSemItem
                    objSemItem_TokenAttribute_ToPay.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")

                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_REAL.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                                                       objSemItem_TokenAttribute_ToPay.GUID, _
                                                                                       dblToPay, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then

                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

        End If
        Return objSemItem_Result
    End Function

    Public Function del_004_ToPay(Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_TransactionDate As DataRowCollection
        Dim objDR_TransactionDate As DataRow

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_TransactionDate = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_FinancialTransaction.GUID, _
                                                                                                                objLocalConfig.SemItem_Attribute_to_Pay.GUID).Rows
        For Each objDR_TransactionDate In objDRC_TransactionDate
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_TransactionDate.Item("GUID_TokenAttribute")).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_005_Gross(ByVal boolGross As Boolean, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_TransactionID As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim boolAdd As Boolean = True
        Dim i As Integer

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If


        objDRC_TransactionID = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_FinancialTransaction.GUID, _
                                                                                                                objLocalConfig.SemItem_Attribute_gross.GUID).Rows
        objSemItem_TokenAttribute_Gross = Nothing
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For i = 0 To objDRC_TransactionID.Count - 1

            If i = 0 Then
                boolAdd = False
                If Not objDRC_TransactionID(i).Item("Val_Bool") = boolGross Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_gross.GUID, _
                                                                                       objDRC_TransactionID(i).Item("GUID_TokenAttribute"), _
                                                                                       boolGross, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_TokenAttribute_Gross = New clsSemItem
                        objSemItem_TokenAttribute_Gross.GUID = objDRC_TransactionID(i).Item("GUID_TokenAttribute")
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        boolAdd = False
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If

                End If
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_TransactionID(i).Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If boolAdd = True Then
            If objSemItem_TokenAttribute_Gross Is Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_gross.GUID, _
                                                                                       Nothing, _
                                                                                       boolGross, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    objSemItem_TokenAttribute_Gross = New clsSemItem
                    objSemItem_TokenAttribute_Gross.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")

                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_gross.GUID, _
                                                                                       objSemItem_TokenAttribute_Gross.GUID, _
                                                                                       boolGross, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then

                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

        End If
        Return objSemItem_Result
    End Function

    Public Function del_005_Gross(Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_TransactionDate As DataRowCollection
        Dim objDR_TransactionDate As DataRow

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_TransactionDate = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_FinancialTransaction.GUID, _
                                                                                                                objLocalConfig.SemItem_Attribute_gross.GUID).Rows
        For Each objDR_TransactionDate In objDRC_TransactionDate
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_TransactionDate.Item("GUID_TokenAttribute")).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_006_Currency(ByVal SemItem_Currency As clsSemItem, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Currency As DataRowCollection
        Dim objDR_Currency As DataRow
        Dim boolAdd As Boolean = True

        objSemItem_Currency = SemItem_Currency
        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If
        objDRC_Currency = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FinancialTransaction.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belonging_Currency.GUID, _
                                                                        objLocalConfig.SemItem_Type_Currencies.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Currency In objDRC_Currency
            If objDR_Currency.Item("GUID_Token_Right") = objSemItem_Currency.GUID Then
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Currency.GUID, _
                                                                       objDR_Currency.Item("GUID_Token_Right")).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                    objSemItem_Currency.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Currency.GUID, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_006_Currency(Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Currency As DataRowCollection
        Dim objDR_Currency As DataRow

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_Currency = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FinancialTransaction.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belonging_Currency.GUID, _
                                                                        objLocalConfig.SemItem_Type_Currencies.GUID).Rows

        For Each objDR_Currency In objDRC_Currency
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                   objDR_Currency.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belonging_Currency.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_007_FinancialTransaction_To_FinancialTransaction_Sub(ByVal SemItem_FinancialTransaction_Sub As clsSemItem, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_FinancialTransaction_Sub As DataRowCollection
        Dim objDRC_Order As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        Dim intMaxOrderID As Integer

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        objSemItem_FinancialTransaction_Sub = SemItem_FinancialTransaction_Sub

        objDRC_FinancialTransaction_Sub = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FinancialTransaction.GUID, _
                                                                                        objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                        objLocalConfig.SemItem_Type_Financial_Transaction.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If objDRC_FinancialTransaction_Sub.Count = 0 Then
            intMaxOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_FinancialTransaction.GUID, _
                                                        objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                        objLocalConfig.SemItem_RelationType_contains.GUID) + 1
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                    objSemItem_FinancialTransaction_Sub.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_contains.GUID, intMaxOrderID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            If Not objSemItem_FinancialTransaction_Sub.Level = 0 Then
                If objSemItem_FinancialTransaction_Sub.Level = -1 Then
                    objSemItem_FinancialTransaction_Sub.Level = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_FinancialTransaction.GUID, _
                        objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                        objLocalConfig.SemItem_RelationType_contains.GUID)
                    objSemItem_FinancialTransaction_Sub.Level = objSemItem_FinancialTransaction_Sub.Level + 1

                End If
                If Not objDRC_FinancialTransaction_Sub(0).Item("OrderID") = objSemItem_FinancialTransaction_Sub.Level Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                            objSemItem_FinancialTransaction_Sub.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                            objSemItem_FinancialTransaction_Sub.Level).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                End If
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function del_007_FinancialTransaction_To_FinancialTransaction_Sub(Optional ByVal SemItem_FinancialTransaction_Sub As clsSemItem = Nothing, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If
        If Not SemItem_FinancialTransaction_Sub Is Nothing Then
            objSemItem_FinancialTransaction_Sub = SemItem_FinancialTransaction_Sub
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success


        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                               objSemItem_FinancialTransaction_Sub.GUID, _
                                                               objLocalConfig.SemItem_RelationType_contains.GUID).Rows

        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_008_Menge(ByVal dblMenge As Double, ByVal strEinheit As String) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Menge As DataRowCollection


        objDRC_Menge = procA_Menge.GetData(dblMenge, _
                                           strEinheit, _
                                           objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                           objLocalConfig.SemItem_Type_Menge.GUID, _
                                           objLocalConfig.SemItem_Type_Einheit.GUID, _
                                           objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
        If objDRC_Menge.Count = 0 Then
            objSemItem_Menge = New clsSemItem
            objSemItem_Menge.GUID = Guid.NewGuid
            objSemItem_Menge.Name = dblMenge & " " & strEinheit
            objSemItem_Menge.GUID_Parent = objLocalConfig.SemItem_Type_Menge.GUID
            objSemItem_Menge.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Menge.GUID, _
                                                                 objSemItem_Menge.Name, _
                                                                 objSemItem_Menge.GUID_Parent, True).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = save_008_1_Menge__Menge(dblMenge)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = save_008_2_Menge_To_Einheit(strEinheit)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = del_008_1_Menge__Menge()
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            del_008_Menge()
                        End If
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    del_008_Menge()
                End If
            End If

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            objSemItem_Menge = New clsSemItem
            objSemItem_Menge.GUID = objDRC_Menge(0).Item("GUID_Menge")
            objSemItem_Menge.Name = objDRC_Menge(0).Item("Name_Menge")
            objSemItem_Menge.GUID_Parent = objLocalConfig.SemItem_Type_Menge.GUID
            objSemItem_Menge.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        End If

        
        


        Return objSemItem_Result
    End Function

    Public Function del_008_Menge(Optional ByVal SemItem_Menge As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Menge Is Nothing Then
            objSemItem_Menge = SemItem_Menge

        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Menge.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Or _
            objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Private Function save_008_1_Menge__Menge(ByVal valReal As Double) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_REAL.GetData(objSemItem_Menge.GUID, _
                                                                           objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                                           Nothing, _
                                                                           valReal, 0).Rows

        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            GUID_TokenAttribute_Menge = objDRC_LogState(0).Item("GUID_TokenAttribute")
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Private Function del_008_1_Menge__Menge() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_Menge).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Private Function save_008_2_Menge_To_Einheit(ByVal strEinheit As String) As clsSemItem
        Dim objDRC_Einheit As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_Einheit = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_Einheit.GUID, _
                                                                          strEinheit).Rows

        If objDRC_Einheit.Count > 0 Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Menge.GUID, _
                                                                    objDRC_Einheit(0).Item("GUID_Token"), _
                                                                    objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 0).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Einheit = New clsSemItem
                objSemItem_Einheit.GUID = objDRC_Einheit(0).Item("GUID_Token")
                objSemItem_Einheit.Name = objDRC_Einheit(0).Item("Name_Token")
                objSemItem_Einheit.GUID_Parent = objLocalConfig.SemItem_Type_Einheit.GUID
                objSemItem_Einheit.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        End If

        Return objSemItem_Result
    End Function

    Private Function del_008_2_Menge_To_Einheit() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Einheit As DataRowCollection
        Dim objDR_Einheit As DataRow

        objDRC_Einheit = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Menge.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                       objLocalConfig.SemItem_Type_Einheit.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Einheit In objDRC_Einheit
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Menge.GUID, _
                                                                   objDR_Einheit.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next


        Return objSemItem_Result
    End Function

    Public Function save_009_FinancialTransaction_To_Menge(Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing, Optional ByVal SemItem_Menge As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ToMenge As DataRowCollection
        Dim objDR_ToMenge As DataRow
        Dim boolAdd As Boolean = True

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        If Not SemItem_Menge Is Nothing Then
            objSemItem_Menge = SemItem_Menge
        End If


        objDRC_ToMenge = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FinancialTransaction.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                                       objLocalConfig.SemItem_Type_Menge.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_ToMenge In objDRC_ToMenge
            If objDR_ToMenge.Item("GUID_Token_Right") = objSemItem_Menge.GUID Then
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                       objDR_ToMenge.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Amount.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next
        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                objSemItem_Menge.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, 0).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        

        Return objSemItem_Result
    End Function

    Public Function del_009_FinancialTransaction_To_Menge(Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing, Optional ByVal SemItem_Menge As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ToMenge As DataRowCollection
        Dim objDR_ToMenge As DataRow

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        If Not SemItem_Menge Is Nothing Then
            objSemItem_Menge = SemItem_Menge
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        objDRC_ToMenge = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FinancialTransaction.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                                       objLocalConfig.SemItem_Type_Menge.GUID).Rows

        For Each objDR_ToMenge In objDRC_ToMenge
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                   objDR_ToMenge.Item("GUID_TokeN_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belonging_Amount.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_010_FinancialTransaction_To_Contractor(ByVal objSemItem_Partner As clsSemItem, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Contractor As DataRowCollection
        Dim objDR_Contractor As DataRow
        Dim boolAdd As Boolean = True

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        objDRC_Contractor = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FinancialTransaction.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                                          objLocalConfig.SemItem_Type_Partner.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Contractor In objDRC_Contractor
            If objDR_Contractor.Item("GUID_Token_Right") = objSemItem_Partner.GUID Then
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                       objDR_Contractor.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next
        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                objSemItem_Partner.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, 0).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        

        Return objSemItem_Result
    End Function

    Public Function del_010_FinancialTransaction_To_Contractor(Optional ByVal SemItem_Partner As clsSemItem = Nothing, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_To_Contractor As DataRowCollection
        Dim objDR_To_Contractor As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        If Not SemItem_Partner Is Nothing Then
            objSemItem_Contractor = SemItem_Partner
        End If
        objDRC_To_Contractor = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FinancialTransaction.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                                             objLocalConfig.SemItem_Type_Partner.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_To_Contractor In objDRC_To_Contractor
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                   objSemItem_Contractor.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_011_FinancialTransaction_To_Contractee(ByVal objSemItem_Partner As clsSemItem, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Contractee As DataRowCollection
        Dim objDR_Contractee As DataRow
        Dim boolAdd As Boolean = True

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If
        objDRC_Contractee = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FinancialTransaction.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                                          objLocalConfig.SemItem_Type_Partner.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Contractee In objDRC_Contractee
            If objDR_Contractee.Item("GUID_Token_Right") = objSemItem_Partner.GUID Then
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                       objDR_Contractee.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next
        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                objSemItem_Partner.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, 0).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        

        Return objSemItem_Result
    End Function

    Public Function del_011_FinancialTransaction_To_Contractee(Optional ByVal SemItem_Partner As clsSemItem = Nothing, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_To_Contractee As DataRowCollection
        Dim objDR_To_Contractee As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        If Not SemItem_Partner Is Nothing Then
            objSemItem_Contractee = SemItem_Partner
        End If
        objDRC_To_Contractee = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FinancialTransaction.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                                             objLocalConfig.SemItem_Type_Partner.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_To_Contractee In objDRC_To_Contractee
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                   objSemItem_Contractee.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_012_FinancialTransaction_To_TaxRate(ByVal SemItem_TaxRate As clsSemItem, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_TaxRates As DataRowCollection
        Dim objDR_TaxRate As DataRow
        Dim boolAdd As Boolean = True

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        objSemItem_TaxRate = SemItem_TaxRate

        objDRC_TaxRates = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FinancialTransaction.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belonging_Tax_Rate.GUID, _
                                                                        objLocalConfig.SemItem_Type_Tax_Rates.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_TaxRate In objDRC_TaxRates
            If objDR_TaxRate.Item("GUID_Token_Right") = objSemItem_TaxRate.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                       objDR_TaxRate.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Tax_Rate.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next
        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                objSemItem_TaxRate.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging_Tax_Rate.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        


        Return objSemItem_Result
    End Function

    
    Public Function del_012_FinancialTransaction_To_TaxRate(Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_To_Taxrates As DataRowCollection
        Dim objDR_To_TaxRate As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        objDRC_To_Taxrates = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FinancialTransaction.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_belonging_Tax_Rate.GUID, _
                                                                           objLocalConfig.SemItem_Type_Tax_Rates.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_To_TaxRate In objDRC_To_Taxrates
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                   objDR_To_TaxRate.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belonging_Tax_Rate.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_013_Payment(ByVal SemItem_Payment As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intOrderID As Integer
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Payment = SemItem_Payment

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Payment.GUID, _
                                                                objSemItem_Payment.Name, _
                                                                objSemItem_Payment.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_013_Payment(Optional ByVal SemItem_PayMent As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_PayMent Is Nothing Then
            objSemItem_Payment = SemItem_PayMent
        End If

        
        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Payment.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_014_Payment__Amount(ByVal dblAmount As Double, Optional ByVal SemItem_Payment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Amount As DataRowCollection
        Dim i As Integer
        Dim boolAdd As Boolean = True

        If Not SemItem_Payment Is Nothing Then
            objSemItem_Payment = SemItem_Payment
        End If

        objDRC_Amount = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Payment.GUID, _
                                                                                                       objLocalConfig.SemItem_Attribute_Amount.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For i = 0 To objDRC_Amount.Count - 1
            If i = 0 Then
                boolAdd = False
                If Not objDRC_Amount(i).Item("Val_Real") = dblAmount Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_REAL.GetData(objSemItem_Payment.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Amount.GUID, _
                                                                                       objDRC_Amount(i).Item("GUID_TokenAttribute"), _
                                                                                       dblAmount, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_TokenAttribute_Payment__Amount = New clsSemItem
                        objSemItem_TokenAttribute_Payment__Amount.GUID = objDRC_Amount(i).Item("GUID_TokenAttribute")
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        boolAdd = False
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If

                End If
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_Amount(i).Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_REAL.GetData(objSemItem_Payment.GUID, _
                                                                               objLocalConfig.SemItem_Attribute_Amount.GUID, _
                                                                               Nothing, _
                                                                               dblAmount, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_Payment__Amount = New clsSemItem
                objSemItem_TokenAttribute_Payment__Amount.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else

                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function del_014_Payment__Amount(Optional ByVal SemItem_Payment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Amount As DataRowCollection
        Dim objDR_Amount As DataRow


        If Not SemItem_Payment Is Nothing Then
            objSemItem_Payment = SemItem_Payment
        End If

        objDRC_Amount = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Payment.GUID, _
                                                                                                       objLocalConfig.SemItem_Attribute_Amount.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Amount In objDRC_Amount

            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Amount.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_015_Payment__TransactionDate(ByVal dateTransactionDate As Date, Optional ByVal SemItem_Payment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Amount As DataRowCollection
        Dim i As Integer
        Dim boolAdd As Boolean = True

        If Not SemItem_Payment Is Nothing Then
            objSemItem_Payment = SemItem_Payment
        End If

        objDRC_Amount = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Payment.GUID, _
                                                                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For i = 0 To objDRC_Amount.Count - 1
            If i = 0 Then
                boolAdd = False
                If Not objDRC_Amount(i).Item("Val_Datetime") = dateTransactionDate Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Payment.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                                                       objDRC_Amount(i).Item("GUID_TokenAttribute"), _
                                                                                       dateTransactionDate, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_TokenAttribute_Payment_TransactionDate = New clsSemItem
                        objSemItem_TokenAttribute_Payment_TransactionDate.GUID = objDRC_Amount(i).Item("GUID_TokenAttribute")
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        boolAdd = False
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If

                End If
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_Amount(i).Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Payment.GUID, _
                                                                               objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                                               Nothing, _
                                                                               dateTransactionDate, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_Payment_TransactionDate = New clsSemItem
                objSemItem_TokenAttribute_Payment_TransactionDate.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else

                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function del_015_Payment__TransactionDate(Optional ByVal SemItem_Payment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Amount As DataRowCollection
        Dim objDR_Amount As DataRow


        If Not SemItem_Payment Is Nothing Then
            objSemItem_Payment = SemItem_Payment
        End If

        objDRC_Amount = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Payment.GUID, _
                                                                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Amount In objDRC_Amount

            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Amount.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_016_FinancialTransaction_To_Payment(Optional ByVal SemItem_Payment As clsSemItem = Nothing, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_belongingPayment As DataRowCollection
        Dim intOrderID As Integer

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        If Not SemItem_Payment Is Nothing Then
            objSemItem_Payment = SemItem_Payment
        End If

        objDRC_belongingPayment = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_FinancialTransaction.GUID, _
                                                                                objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                                                objSemItem_Payment.GUID).Rows
        If objDRC_belongingPayment.Count = 0 Then
            intOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_FinancialTransaction.GUID, _
                                                                         objLocalConfig.SemItem_Type_Payment.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_belonging_Payment.GUID) + 1
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                objSemItem_Payment.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                                intOrderID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            If Not objSemItem_Payment.Level = 0 Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                                objSemItem_Payment.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                                objSemItem_Payment.Level).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            End If
        End If

        

        Return objSemItem_Result
    End Function
    Public Function del_016_FinancialTransaction_To_Payment(Optional ByVal SemItem_Payment As clsSemItem = Nothing, Optional ByVal SemItem_FinancialTransaction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_FinancialTransaction Is Nothing Then
            objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        End If

        If Not SemItem_Payment Is Nothing Then
            objSemItem_Payment = SemItem_Payment
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_FinancialTransaction.GUID, _
                                                               objSemItem_Payment.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belonging_Payment.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    
    Public Function save_017_Sparkasse_To_Payment(ByVal SemItem_Sparkasse As clsSemItem, Optional ByVal SemItem_Payment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Sparkasse = SemItem_Sparkasse
        If Not SemItem_Payment Is Nothing Then
            objSemItem_Payment = SemItem_Payment
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Sparkasse.GUID, _
                                                                objSemItem_Payment.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_017_Sparkasse_To_Payment(Optional ByVal SemItem_Sparkasse As clsSemItem = Nothing, Optional ByVal SemItem_Payment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Sparkasse Is Nothing Then
            objSemItem_Sparkasse = SemItem_Sparkasse
        End If

        If Not SemItem_Payment Is Nothing Then
            objSemItem_Payment = SemItem_Payment
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Sparkasse.GUID, _
                                                                objSemItem_Payment.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_018_Payment_PercentPart(ByVal dblPercent As Double, Optional ByVal SemItem_Payment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_PercentPart As DataRowCollection
        Dim objDR_PercentPart As DataRow
        Dim boolAdd As Boolean

        If Not SemItem_Payment Is Nothing Then
            objSemItem_Payment = SemItem_Payment
        End If

        objDRC_PercentPart = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Payment.GUID, objLocalConfig.SemItem_Attribute_part____.GUID).Rows
        boolAdd = True
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_PercentPart In objDRC_PercentPart
            If objDR_PercentPart.Item("Val_Real") = dblPercent Then
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_PercentPart.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                End If
            End If
        Next

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_REAL.GetData(objSemItem_Payment.GUID, _
                                                                               objLocalConfig.SemItem_Attribute_part____.GUID, _
                                                                               Nothing, _
                                                                               dblPercent, 1).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_PercentPart = New clsSemItem
                objSemItem_TokenAttribute_PercentPart.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                objSemItem_TokenAttribute_PercentPart = Nothing
            End If
        End If

        Return objSemItem_Result

    End Function

    Public Function del_018_Payment_PercentPart(Optional ByVal SemItem_Payment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_PercentPart As DataRowCollection
        Dim objDR_PercentPart As DataRow

        If Not SemItem_Payment Is Nothing Then
            objSemItem_Payment = SemItem_Payment
        End If


        objDRC_PercentPart = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Payment.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_part____.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_PercentPart In objDRC_PercentPart
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_PercentPart.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result

    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        funcA_TokenToken.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        semprocA_DBWork_Save_Token.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        semprocA_DBWork_Del_Token.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        semprocA_DBWork_Save_TokenRel.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        semprocA_DBWork_Del_TokenRel.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        semprocA_DBWork_Save_TokenAttribute_Datetime.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        semprocA_DBWork_Save_TokenAttribute_REAL.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        semprocA_DBWork_Save_TokenAttribute_VARCHAR255.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        semprocA_DBWork_Del_TokenAttribute.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        procA_Menge.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_Plugin.ConnectionString)
    End Sub
End Class
