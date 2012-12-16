Imports Sem_Manager
Public Class clsTransaction_Trinkmessungen

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBwork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_DateTime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private objSemItem_Trinkmessungen As clsSemItem
    Private objSemItem_TokenAttribute_Trinkprobleme As clsSemItem
    Private objSemItem_TokenAttribute_Eigeninitiative As clsSemItem
    Private objSemItem_TokenAttribute_Zeitpunkt As clsSemItem
    Private objSemItem_Menge As clsSemItem
    Private objSemItem_Partner As clsSemItem
    Private objSemItem_Trinkbestandteil As clsSemItem
    Private objSemItem_Medikament As clsSemItem
    Private objSemItem_Nahrungsmittel As clsSemItem

    Private objLocalConfig As clsLocalConfig

    Public Function save_001_Trinkmessungen(ByVal SemItem_Trinkmessungen As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Trinkmessungen = SemItem_Trinkmessungen

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Trinkmessungen.GUID, _
                                                             objSemItem_Trinkmessungen.Name, _
                                                             objSemItem_Trinkmessungen.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_Trinkmessungen(Optional ByVal SemItem_Trinkmessungen As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Trinkmessungen Is Nothing Then
            objSemItem_Trinkmessungen = SemItem_Trinkmessungen
        End If

        objDRC_LogState = semprocA_DBwork_Del_Token.GetData(objSemItem_Trinkmessungen.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Trinkmessungen__Trinkprobleme(ByVal boolTrinkprobleme As Boolean, Optional ByVal GUID_Trinkprobleme As Guid = Nothing, Optional ByVal SemItem_Trinkmessungen As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Trinkprobleme As DataRowCollection
        Dim objDR_Trinkprobleme As DataRow

        If objLocalConfig.Globals.is_GUID(GUID_Trinkprobleme.ToString) Then
            objSemItem_TokenAttribute_Trinkprobleme = New clsSemItem
            objSemItem_TokenAttribute_Trinkprobleme.GUID = GUID_Trinkprobleme
        Else
            objSemItem_TokenAttribute_Trinkprobleme = Nothing
        End If
        If Not SemItem_Trinkmessungen Is Nothing Then
            objSemItem_Trinkmessungen = SemItem_Trinkmessungen
        End If

        objDRC_Trinkprobleme = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Trinkmessungen.GUID, _
                                                                                                          objLocalConfig.SemItem_Attribute_Trinkprobleme__Spucken_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        If Not objSemItem_TokenAttribute_Trinkprobleme Is Nothing Then
            For Each objDR_Trinkprobleme In objDRC_Trinkprobleme
                If Not objDR_Trinkprobleme.Item("VAL_Bool") = boolTrinkprobleme Then
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Trinkprobleme.Item("GUID_TokenAttribute")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                Else
                    objSemItem_TokenAttribute_Trinkprobleme = New clsSemItem
                    objSemItem_TokenAttribute_Trinkprobleme.GUID = objDR_Trinkprobleme.Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Exists
                End If
            Next

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Trinkmessungen.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Trinkprobleme__Spucken_.GUID, _
                                                                                       Nothing, _
                                                                                       boolTrinkprobleme, 1).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_TokenAttribute_Trinkprobleme = New clsSemItem
                    objSemItem_TokenAttribute_Trinkprobleme.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Trinkmessungen.GUID, _
                                                                                   objLocalConfig.SemItem_Attribute_Trinkprobleme__Spucken_.GUID, _
                                                                                   Nothing, _
                                                                                   boolTrinkprobleme, _
                                                                                   1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function del_002_Trinkmessungen__Trinkprobleme(Optional ByVal SemItem_Trinkmessungen As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Trinkprobleme As DataRowCollection
        Dim objDR_Trinkprobleme As DataRow

        objDRC_Trinkprobleme = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Trinkmessungen.GUID, _
                                                                                                          objLocalConfig.SemItem_Attribute_Trinkprobleme__Spucken_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Trinkprobleme In objDRC_Trinkprobleme
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Trinkprobleme.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_003_Trinkmessungen__Eigeninitiative(ByVal boolEigeninitiative As Boolean, Optional ByVal GUID_TokenAttribute_Eigeninitiative As Guid = Nothing, Optional ByVal SemItem_Trinkmessungen As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Eigeninitiative As DataRowCollection
        Dim objDR_Eigeninitiative As DataRow

        If objLocalConfig.Globals.is_GUID(GUID_TokenAttribute_Eigeninitiative.ToString) Then
            objSemItem_TokenAttribute_Eigeninitiative = New clsSemItem
            objSemItem_TokenAttribute_Eigeninitiative.GUID = GUID_TokenAttribute_Eigeninitiative
        Else
            objSemItem_TokenAttribute_Eigeninitiative = Nothing
        End If
        If Not SemItem_Trinkmessungen Is Nothing Then
            objSemItem_Trinkmessungen = SemItem_Trinkmessungen
        End If

        objDRC_Eigeninitiative = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Trinkmessungen.GUID, _
                                                                                                          objLocalConfig.SemItem_Attribute_Eigeninitiative.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        If Not objSemItem_TokenAttribute_Eigeninitiative Is Nothing Then
            For Each objDR_Eigeninitiative In objDRC_Eigeninitiative
                If Not objDR_Eigeninitiative.Item("VAL_Bool") = boolEigeninitiative Then
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Eigeninitiative.Item("GUID_TokenAttribute")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                Else
                    objSemItem_TokenAttribute_Eigeninitiative = New clsSemItem
                    objSemItem_TokenAttribute_Eigeninitiative.GUID = objDR_Eigeninitiative.Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Exists
                End If
            Next

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Trinkmessungen.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Eigeninitiative.GUID, _
                                                                                       Nothing, _
                                                                                       boolEigeninitiative, 1).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_TokenAttribute_Eigeninitiative = New clsSemItem
                    objSemItem_TokenAttribute_Eigeninitiative.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Trinkmessungen.GUID, _
                                                                                   objLocalConfig.SemItem_Attribute_Eigeninitiative.GUID, _
                                                                                   Nothing, _
                                                                                   boolEigeninitiative, _
                                                                                   1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function del_003_Eigeninitiative__Trinkprobleme(Optional ByVal SemItem_Trinkmessung As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Trinkprobleme As DataRowCollection
        Dim objDR_Trinkprobleme As DataRow

        If Not SemItem_Trinkmessung Is Nothing Then
            objSemItem_Trinkmessungen = SemItem_Trinkmessung
        End If

        objDRC_Trinkprobleme = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Trinkmessungen.GUID, _
                                                                                                          objLocalConfig.SemItem_Attribute_Eigeninitiative.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Trinkprobleme In objDRC_Trinkprobleme
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Trinkprobleme.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_004_Trinkmessungen__Zeitpunkt(ByVal dateZeitpunkt As Date, Optional ByVal GUID_TokenAttribute_Zeitpunkt As Guid = Nothing, Optional ByVal SemItem_Trinkmessungen As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Zeitpunkt As DataRowCollection
        Dim objDR_Zeitpunkt As DataRow

        If objLocalConfig.Globals.is_GUID(GUID_TokenAttribute_Zeitpunkt.ToString) Then
            objSemItem_TokenAttribute_Zeitpunkt = New clsSemItem
            objSemItem_TokenAttribute_Zeitpunkt.GUID = GUID_TokenAttribute_Zeitpunkt
        Else
            objSemItem_TokenAttribute_Zeitpunkt = Nothing
        End If
        If Not SemItem_Trinkmessungen Is Nothing Then
            objSemItem_Trinkmessungen = SemItem_Trinkmessungen
        End If

        objDRC_Zeitpunkt = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Trinkmessungen.GUID, _
                                                                                                          objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        If Not objSemItem_TokenAttribute_Zeitpunkt Is Nothing Then
            For Each objDR_Zeitpunkt In objDRC_Zeitpunkt
                If Not objDR_Zeitpunkt.Item("VAL_DateTime") = dateZeitpunkt Then
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Zeitpunkt.Item("GUID_TokenAttribute")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                Else
                    objSemItem_TokenAttribute_Zeitpunkt = New clsSemItem
                    objSemItem_TokenAttribute_Zeitpunkt.GUID = objDR_Zeitpunkt.Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Exists
                End If
            Next

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DateTime.GetData(objSemItem_Trinkmessungen.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID, _
                                                                                       Nothing, _
                                                                                       dateZeitpunkt, 1).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_TokenAttribute_Zeitpunkt = New clsSemItem
                    objSemItem_TokenAttribute_Zeitpunkt.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DateTime.GetData(objSemItem_Trinkmessungen.GUID, _
                                                                                   objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID, _
                                                                                   Nothing, _
                                                                                   dateZeitpunkt, _
                                                                                   1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function del_004_Trinkmessung__Zeitpunkt(Optional ByVal SemItem_Trinkmessung As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Zeitpunkt As DataRowCollection
        Dim objDR_Zeitpunkt As DataRow

        If Not SemItem_Trinkmessung Is Nothing Then
            objSemItem_Trinkmessungen = SemItem_Trinkmessung
        End If

        objDRC_Zeitpunkt = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Trinkmessungen.GUID, _
                                                                                                          objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Zeitpunkt In objDRC_Zeitpunkt
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Zeitpunkt.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_005_Trinkmessungen_To_Partner(ByVal SemItem_Partner As clsSemItem, Optional ByVal SemItem_Trinkmessungen As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Partner As DataRowCollection
        Dim objDR_Partner As DataRow
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Partner = SemItem_Partner
        If Not SemItem_Trinkmessungen Is Nothing Then
            objSemItem_Trinkmessungen = SemItem_Trinkmessungen
        End If

        objDRC_Partner = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Trinkmessungen.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                     objLocalConfig.SemItem_Type_Partner.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Partner In objDRC_Partner
            If objDRC_Partner(0).Item("GUID_Token_Right") = objSemItem_Partner.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Trinkmessungen.GUID, _
                                                                       objSemItem_Partner.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Trinkmessungen.GUID, _
                                                                    objSemItem_Partner.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error

            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_Trinkmessungen_To_Partner(Optional ByVal SemItem_Trinkmessungen As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Partner As DataRowCollection
        Dim objDR_Partner As DataRow

        If Not SemItem_Trinkmessungen Is Nothing Then
            objSemItem_Trinkmessungen = SemItem_Trinkmessungen
        End If

        objDRC_Partner = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Trinkmessungen.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                     objLocalConfig.SemItem_Type_Partner.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Partner In objDRC_Partner
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Trinkmessungen.GUID, _
                                                                   objDR_Partner.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_006_Trinkbestandteil(ByVal SemItem_Trinkbestandteil As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Trinkbestandteil = SemItem_Trinkbestandteil

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Trinkbestandteil.GUID, _
                                                             objSemItem_Trinkbestandteil.Name, _
                                                             objSemItem_Trinkbestandteil.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_006_Trinkbestandteil(Optional ByVal SemItem_Trinkbestandteil As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Trinkbestandteil Is Nothing Then
            objSemItem_Trinkbestandteil = SemItem_Trinkbestandteil
        End If

        objDRC_LogState = semprocA_DBwork_Del_Token.GetData(objSemItem_Trinkbestandteil.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_007_Trinkmessung_To_Trinkbestandteil(Optional ByVal SemItem_TrinkMessung As clsSemItem = Nothing, Optional ByVal SemItem_TrinkBestandteil As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_TrinkBestandteil Is Nothing Then
            objSemItem_Trinkbestandteil = SemItem_TrinkBestandteil
        End If

        If Not SemItem_TrinkMessung Is Nothing Then
            objSemItem_Trinkmessungen = SemItem_TrinkMessung
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Trinkmessungen.GUID, _
                                                                objSemItem_Trinkbestandteil.GUID, _
                                                                objLocalConfig.SemItem_RelationType_contains.GUID, 1).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result

    End Function

    Public Function del_007_Trinkmessung_To_Trinkbestandteil(ByVal boolAll As Boolean, Optional ByVal SemItem_TrinkMessung As clsSemItem = Nothing, Optional ByVal SemItem_TrinkBestandteil As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Trinkbestandteil As DataRowCollection
        Dim objDR_Trinkbestandteil As DataRow

        If Not SemItem_TrinkBestandteil Is Nothing Then
            objSemItem_Trinkbestandteil = SemItem_TrinkBestandteil
        End If

        If Not SemItem_TrinkMessung Is Nothing Then
            objSemItem_Trinkmessungen = SemItem_TrinkMessung
        End If

        If boolAll = True Then
            objDRC_Trinkbestandteil = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Trinkmessungen.GUID, _
                                                                                    objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                    objLocalConfig.SemItem_Type_Trinkbestandteil.GUID).Rows
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            For Each objDR_Trinkbestandteil In objDRC_Trinkbestandteil
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Trinkmessungen.GUID, _
                                                                       objDR_Trinkbestandteil.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_contains.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Next
        Else
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Trinkmessungen.GUID, _
                                                                   objSemItem_Trinkbestandteil.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_contains.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_008_Trinkbestandteil_To_Medikament(ByVal SemItem_Medikament As clsSemItem, Optional ByVal SemItem_Trinkbestandteil As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Medikamente As DataRowCollection
        Dim objDR_Medikament As DataRow

        If Not SemItem_Trinkbestandteil Is Nothing Then
            objSemItem_Trinkbestandteil = SemItem_Trinkbestandteil
        End If

        objSemItem_Medikament = SemItem_Medikament
        objDRC_Medikamente = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Trinkbestandteil.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                           objLocalConfig.SemItem_Type_Medikamente.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Medikament In objDRC_Medikamente
            If objDR_Medikament.Item("GUID_Token_Right") = objSemItem_Medikament.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Trinkbestandteil.GUID, _
                                                                       objDR_Medikament.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_contains.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Trinkbestandteil.GUID, _
                                                                    objSemItem_Medikament.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_contains.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            del_009_Trinkbestandteil_To_Nahrungsmittel()
        End If
        Return objSemItem_Result
    End Function
    
    Public Function del_008_Trinkbestandteil_To_Medikament(Optional ByVal SemItem_Trinkbestandteil As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Medikament As DataRowCollection
        Dim objDR_Medikament As DataRow

        If Not SemItem_Trinkbestandteil Is Nothing Then
            objSemItem_Trinkbestandteil = SemItem_Trinkbestandteil
        End If

        objDRC_Medikament = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Trinkbestandteil.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                          objLocalConfig.SemItem_Type_Medikamente.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Medikament In objDRC_Medikament
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Trinkbestandteil.GUID, _
                                                                   objDR_Medikament.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_contains.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_009_Trinkbestandteil_To_Nahrungsmittel(ByVal SemItem_Nahrungsmittel As clsSemItem, Optional ByVal SemItem_Trinkbestandteil As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Nahrungsmittele As DataRowCollection
        Dim objDR_Nahrungsmittel As DataRow

        If Not SemItem_Trinkbestandteil Is Nothing Then
            objSemItem_Trinkbestandteil = SemItem_Trinkbestandteil
        End If

        objSemItem_Nahrungsmittel = SemItem_Nahrungsmittel
        objDRC_Nahrungsmittele = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Trinkbestandteil.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                           objLocalConfig.SemItem_Type_Nahrung.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Nahrungsmittel In objDRC_Nahrungsmittele
            If objDR_Nahrungsmittel.Item("GUID_Token_Right") = objSemItem_Nahrungsmittel.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Trinkbestandteil.GUID, _
                                                                       objDR_Nahrungsmittel.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_contains.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Trinkbestandteil.GUID, _
                                                                    objSemItem_Nahrungsmittel.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_contains.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            del_008_Trinkbestandteil_To_Medikament()
        End If
        Return objSemItem_Result
    End Function

    Public Function del_009_Trinkbestandteil_To_Nahrungsmittel(Optional ByVal SemItem_Trinkbestandteil As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Nahrungsmittel As DataRowCollection
        Dim objDR_Nahrungsmittel As DataRow

        If Not SemItem_Trinkbestandteil Is Nothing Then
            objSemItem_Trinkbestandteil = SemItem_Trinkbestandteil
        End If

        objDRC_Nahrungsmittel = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Trinkbestandteil.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                          objLocalConfig.SemItem_Type_Nahrung.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Nahrungsmittel In objDRC_Nahrungsmittel
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Trinkbestandteil.GUID, _
                                                                   objDR_Nahrungsmittel.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_contains.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_010_Trinkbestandteil_To_Menge(ByVal SemItem_Menge As clsSemItem, Optional ByVal SemItem_Trinkbestandteil As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Mengee As DataRowCollection
        Dim objDR_Menge As DataRow

        If Not SemItem_Trinkbestandteil Is Nothing Then
            objSemItem_Trinkbestandteil = SemItem_Trinkbestandteil
        End If

        objSemItem_Menge = SemItem_Menge
        objDRC_Mengee = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Trinkbestandteil.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                           objLocalConfig.SemItem_Type_Menge.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Menge In objDRC_Mengee
            If objDR_Menge.Item("GUID_Token_Right") = objSemItem_Menge.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Trinkbestandteil.GUID, _
                                                                       objDR_Menge.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belonging.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Trinkbestandteil.GUID, _
                                                                    objSemItem_Menge.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_010_Trinkbestandteil_To_Menge(Optional ByVal SemItem_Trinkbestandteil As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Menge As DataRowCollection
        Dim objDR_Menge As DataRow

        If Not SemItem_Trinkbestandteil Is Nothing Then
            objSemItem_Trinkbestandteil = SemItem_Trinkbestandteil
        End If

        objDRC_Menge = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Trinkbestandteil.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                          objLocalConfig.SemItem_Type_Menge.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Menge In objDRC_Menge
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Trinkbestandteil.GUID, _
                                                                   objDR_Menge.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belonging.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Next

        Return objSemItem_Result
    End Function
    
    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBwork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_DateTime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

    End Sub
End Class
