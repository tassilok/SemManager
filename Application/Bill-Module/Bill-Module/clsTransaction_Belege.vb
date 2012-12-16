Imports Sem_Manager
Public Class clsTransaction_Belege
    Private objLocalConfig As clsLocalConfig

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private objSemItem_Beleg As clsSemItem
    Private objSemItem_Transaction As clsSemItem
    Private objSemItem_Belegsart As clsSemItem
    Private objSemItem_Container As clsSemItem

    Public Function save_001_Beleg(ByVal SemItem_Beleg As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Beleg As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Beleg = SemItem_Beleg

        objDRC_Beleg = semtblA_Token.GetData_Token_By_GUID(objSemItem_Beleg.GUID).Rows
        If objDRC_Beleg.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Beleg.GUID, _
                                                                 objSemItem_Beleg.Name, _
                                                                 objSemItem_Beleg.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            If Not objDRC_Beleg(0).Item("Name_Token") = objSemItem_Beleg.Name Then
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Beleg.GUID, _
                                                                 objSemItem_Beleg.Name, _
                                                                 objSemItem_Beleg.GUID_Parent, True).Rows
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

    Public Function del_001_Beleg(Optional ByVal SemItem_Beleg As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Beleg Is Nothing Then
            objSemItem_Beleg = SemItem_Beleg
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Beleg.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Transaction_To_Beleg(ByVal SemItem_Transaction As clsSemItem, Optional ByVal SemItem_Beleg As clsSemItem = Nothing, Optional ByVal objSemItem_Direction As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRs_Transaction_To_Beleg() As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim funcT_Transaction_To_Beleg As New ds_Token.func_TokenTokenDataTable
        Dim intOrderID As Integer
        Dim intOrderID_Other As Integer

        If Not SemItem_Beleg Is Nothing Then
            objSemItem_Beleg = SemItem_Beleg
        End If

        objSemItem_Transaction = SemItem_Transaction
        funcA_TokenToken.Fill_LeftRight_Ordered_By_GUIDs(funcT_Transaction_To_Beleg, _
                                                         objSemItem_Transaction.GUID, _
                                                         objLocalConfig.SemItem_Type_Beleg.GUID, _
                                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                         True)
        objDRs_Transaction_To_Beleg = funcT_Transaction_To_Beleg.Select("GUID_TokeN_Right='" & objSemItem_Beleg.GUID.ToString & "'")
        If objDRs_Transaction_To_Beleg.Count = 0 Then
            intOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_Transaction.GUID, _
                                                                         objLocalConfig.SemItem_Type_Beleg.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID) + 1

            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Transaction.GUID, _
                                                                    objSemItem_Beleg.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                    intOrderID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            If Not objSemItem_Direction Is Nothing Then
                If objSemItem_Direction.GUID = objLocalConfig.SemItem_Token_Direction_Up.GUID Then
                    intOrderID = objDRs_Transaction_To_Beleg(0).Item("OrderID")
                    objDRs_Transaction_To_Beleg = funcT_Transaction_To_Beleg.Select("OrderID>" & intOrderID)
                    If objDRs_Transaction_To_Beleg.Count > 0 Then
                        intOrderID_Other = objDRs_Transaction_To_Beleg(0).Item("OrderID")
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Transaction.GUID, _
                                                                                objDRs_Transaction_To_Beleg(0).Item("GUID_Token_Right"), _
                                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Transaction.GUID, _
                                                                                    objSemItem_Beleg.GUID, _
                                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                    intOrderID_Other).Rows
                            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                            Else
                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Transaction.GUID, _
                                                                                    objDRs_Transaction_To_Beleg(0).Item("GUID_Token_Right"), _
                                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                    intOrderID_Other).Rows
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                            End If
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    intOrderID = objDRs_Transaction_To_Beleg(0).Item("OrderID")
                    objDRs_Transaction_To_Beleg = funcT_Transaction_To_Beleg.Select("OrderID<" & intOrderID)
                    If objDRs_Transaction_To_Beleg.Count > 0 Then
                        intOrderID_Other = objDRs_Transaction_To_Beleg(0).Item("OrderID")
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Transaction.GUID, _
                                                                                objDRs_Transaction_To_Beleg(0).Item("GUID_Token_Right"), _
                                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Transaction.GUID, _
                                                                                    objSemItem_Beleg.GUID, _
                                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                    intOrderID_Other).Rows
                            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                            Else
                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Transaction.GUID, _
                                                                                    objDRs_Transaction_To_Beleg(0).Item("GUID_Token_Right"), _
                                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                    intOrderID_Other).Rows
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                            End If
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            End If
        End If

        


        Return objSemItem_Result
    End Function

    Public Function del_002_Transaction_To_Beleg(Optional ByVal SemItem_Transaction As clsSemItem = Nothing, Optional ByVal SemItem_Beleg As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Transaction Is Nothing Then
            objSemItem_Transaction = SemItem_Transaction
        End If

        If Not SemItem_Beleg Is Nothing Then
            objSemItem_Beleg = SemItem_Beleg
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Transaction.GUID, _
                                                               objSemItem_Beleg.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_003_Beleg_To_Belegsart(ByVal SemItem_Belegsart As clsSemItem, Optional ByVal SemItem_Beleg As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Beleg_To_Belegsart As DataRowCollection
        Dim objDR_Beleg_To_Belegsart As DataRow
        Dim boolAdd As Boolean

        Dim objSemItem_Result As clsSemItem

        objSemItem_Belegsart = SemItem_Belegsart

        If Not SemItem_Beleg Is Nothing Then
            objSemItem_Beleg = SemItem_Beleg
        End If

        objDRC_Beleg_To_Belegsart = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Beleg.GUID, _
                                                                                  objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                                  objLocalConfig.SemItem_Type_Belegsart.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        boolAdd = True

        For Each objDR_Beleg_To_Belegsart In objDRC_Beleg_To_Belegsart
            If objDR_Beleg_To_Belegsart.Item("GUID_Token_Right") = objSemItem_Belegsart.GUID Then
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Beleg.GUID, _
                                                                       objSemItem_Belegsart.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            If boolAdd = True Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Beleg.GUID, _
                                                                objSemItem_Belegsart.GUID, _
                                                                objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 1).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error

                End If

            End If
        End If
        
        Return objSemItem_Result
    End Function

    Public Function del_003_Beleg_To_Belegsart(Optional ByVal SemItem_Belegsart As clsSemItem = Nothing, Optional ByVal SemItem_Beleg As clsSemItem = Nothing) As clsSemItem

        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        If Not SemItem_Beleg Is Nothing Then
            objSemItem_Beleg = SemItem_Beleg
        End If

        If Not SemItem_Belegsart Is Nothing Then
            objSemItem_Belegsart = SemItem_Belegsart
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Beleg.GUID, _
                                                               objSemItem_Belegsart.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_Beleg_To_Container(ByVal SemItem_Container As clsSemItem, Optional ByVal SemItem_Beleg As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Beleg_To_Container As DataRowCollection
        Dim objDR_Beleg_To_Container As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim boolAdd As Boolean

        objSemItem_Container = SemItem_Container
        If Not SemItem_Beleg Is Nothing Then
            objSemItem_Beleg = SemItem_Beleg
        End If

        objDRC_Beleg_To_Container = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Beleg.GUID, _
                                                                                  objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                                                                  objLocalConfig.SemItem_Type_Container__physical_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        boolAdd = True
        For Each objDR_Beleg_To_Container In objDRC_Beleg_To_Container
            If objDR_Beleg_To_Container.Item("GUID_Token_Right") = objSemItem_Container.GUID Then
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Beleg.GUID, _
                                                                       objDR_Beleg_To_Container.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_located_in.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If

        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            If boolAdd = True Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Beleg.GUID, _
                                                                        objSemItem_Container.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                                                        1).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_Beleg_To_Container(Optional ByVal SemItem_Beleg As clsSemItem = Nothing, Optional ByVal SemItem_Container As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Beleg Is Nothing Then
            objSemItem_Beleg = SemItem_Beleg
        End If

        If Not SemItem_Container Is Nothing Then
            objSemItem_Container = SemItem_Container
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Beleg.GUID, _
                                                               objSemItem_Container.GUID, _
                                                               objLocalConfig.SemItem_RelationType_located_in.GUID).Rows

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
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
