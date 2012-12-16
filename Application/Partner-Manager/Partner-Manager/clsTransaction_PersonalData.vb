Imports Sem_Manager
Public Class clsTransaction_PersonalData
    Private objLocalConfig As clsLocalConfig

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Varchar255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_DateTime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objSemItem_PersonalData As clsSemItem
    Private objSemItem_Geschlecht As clsSemItem
    Private objSemItem_Familienstand As clsSemItem
    Private objSemItem_Sozialversicherungsnummer As clsSemItem
    Private objSemItem_eTin As clsSemItem
    Private objSemItem_Identifkationsnummer__IdNr_ As clsSemItem
    Private objSemItem_Steuernummer As clsSemItem
    Private objSemItem_Partner As clsSemItem
    Private objSemItem_ImageGraphic As clsSemItem

    Private objSemItem_GUID_TokenAttribute_Vorname As clsSemItem
    Private objSemItem_GUID_TokenAttribute_Nachname As clsSemItem
    Private objSemItem_GUID_TokenAttribute_Geburtsdatum As clsSemItem
    Private objSemItem_GUID_TokenAttribute_Todesdatum As clsSemItem

    Public Function save_001_personalData(ByVal SemItem_PersonalData As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_PersonalData = SemItem_PersonalData

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_PersonalData.GUID, _
                                                             objSemItem_PersonalData.Name, _
                                                             objSemItem_PersonalData.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Private Function del_001_personalData(Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If
        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_PersonalData.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Vorname(ByVal strVorname As String, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing, Optional ByVal SemItem_GUID_TokenAttribute_Vorname As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Vorname As DataRowCollection
        Dim objDR_Vorname As DataRow

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If



        objSemItem_GUID_TokenAttribute_Vorname = SemItem_GUID_TokenAttribute_Vorname



        If objSemItem_GUID_TokenAttribute_Vorname Is Nothing Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

            objDRC_Vorname = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_PersonalData.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Vorname.GUID).Rows
            For Each objDR_Vorname In objDRC_Vorname
                If objDR_Vorname.Item("Val_VARCHAR255") = strVorname Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    objSemItem_GUID_TokenAttribute_Vorname = New clsSemItem
                    objSemItem_GUID_TokenAttribute_Vorname.GUID = objDR_Vorname.Item("GUID_TokenAttribute")
                Else
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Vorname.Item("GUID_TokenAttribute")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                End If
            Next
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Varchar255.GetData(objSemItem_PersonalData.GUID, _
                                                                                 objLocalConfig.SemItem_Attribute_Vorname.GUID, _
                                                                                 Nothing, _
                                                                                 strVorname, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_GUID_TokenAttribute_Vorname = New clsSemItem
                    objSemItem_GUID_TokenAttribute_Vorname.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Varchar255.GetData(objSemItem_PersonalData.GUID, _
                                                                                     objLocalConfig.SemItem_Attribute_Vorname.GUID, _
                                                                                     objSemItem_GUID_TokenAttribute_Vorname.GUID, _
                                                                                     strVorname, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function del_002_Vorname(Optional ByVal SemItem_GUID_TokenAttribute_Vorname As clsSemItem = Nothing, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Vorname As DataRowCollection
        Dim objDR_Vorname As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_GUID_TokenAttribute_Vorname Is Nothing Then
            objSemItem_GUID_TokenAttribute_Vorname = objSemItem_GUID_TokenAttribute_Vorname
        End If

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        If objSemItem_GUID_TokenAttribute_Vorname Is Nothing Then
            objDRC_Vorname = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_PersonalData.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Vorname.GUID).Rows
            For Each objDR_Vorname In objDRC_Vorname
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Vorname.Item("GUID_TokenAttribte")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        Else
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_GUID_TokenAttribute_Vorname.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error

            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Nachname(ByVal strNachname As String, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing, Optional ByVal SemItem_GUID_TokenAttribute_Nachname As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Nachname As DataRowCollection
        Dim objDR_Nachname As DataRow

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If



        objSemItem_GUID_TokenAttribute_Nachname = SemItem_GUID_TokenAttribute_Nachname



        If objSemItem_GUID_TokenAttribute_Nachname Is Nothing Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

            objDRC_Nachname = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_PersonalData.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Nachname.GUID).Rows
            For Each objDR_Nachname In objDRC_Nachname
                If objDR_Nachname.Item("Val_VARCHAR255") = strNachname Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    objSemItem_GUID_TokenAttribute_Nachname = New clsSemItem
                    objSemItem_GUID_TokenAttribute_Nachname.GUID = objDR_Nachname.Item("GUID_TokenAttribute")
                Else
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Nachname.Item("GUID_TokenAttribute")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                End If
            Next
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Varchar255.GetData(objSemItem_PersonalData.GUID, _
                                                                                 objLocalConfig.SemItem_Attribute_Nachname.GUID, _
                                                                                 Nothing, _
                                                                                 strNachname, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_GUID_TokenAttribute_Nachname = New clsSemItem
                    objSemItem_GUID_TokenAttribute_Nachname.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Varchar255.GetData(objSemItem_PersonalData.GUID, _
                                                                                     objLocalConfig.SemItem_Attribute_Nachname.GUID, _
                                                                                     objSemItem_GUID_TokenAttribute_Nachname.GUID, _
                                                                                     strNachname, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function del_002_Nachname(Optional ByVal SemItem_GUID_TokenAttribute_Nachname As clsSemItem = Nothing, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Nachname As DataRowCollection
        Dim objDR_Nachname As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_GUID_TokenAttribute_Nachname Is Nothing Then
            objSemItem_GUID_TokenAttribute_Nachname = objSemItem_GUID_TokenAttribute_Nachname
        End If

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        If objSemItem_GUID_TokenAttribute_Vorname Is Nothing Then
            objDRC_Nachname = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_PersonalData.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Nachname.GUID).Rows
            For Each objDR_Nachname In objDRC_Nachname
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Nachname.Item("GUID_TokenAttribte")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        Else
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_GUID_TokenAttribute_Nachname.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error

            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_003_PersonalData_To_Geschlecht(ByVal SemItem_Geschlecht As clsSemItem, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Geschlecht As DataRowCollection
        Dim objDR_Geschlecht As DataRow

        objSemItem_Geschlecht = SemItem_Geschlecht
        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_Geschlecht = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                          objLocalConfig.SemItem_Type_Geschlecht.GUID).Rows
        For Each objDR_Geschlecht In objDRC_Geschlecht
            If objDR_Geschlecht.Item("GUID_Token_Right") = objSemItem_Geschlecht.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                       objDR_Geschlecht.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belonging.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                objSemItem_Geschlecht.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function del_003_PersonalData_To_Geschlecht(Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Geschlecht As DataRowCollection
        Dim objDR_Geschlecht As DataRow

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objDRC_Geschlecht = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                          objLocalConfig.SemItem_Type_Geschlecht.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Geschlecht In objDRC_Geschlecht

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                   objDR_Geschlecht.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belonging.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_004_PersonalData_To_Familienstand(ByVal SemItem_Familienstand As clsSemItem, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Familienstand As DataRowCollection
        Dim objDR_Familienstand As DataRow

        objSemItem_Familienstand = SemItem_Familienstand
        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_Familienstand = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                          objLocalConfig.SemItem_Type_Familienstand.GUID).Rows
        For Each objDR_Familienstand In objDRC_Familienstand
            If objDR_Familienstand.Item("GUID_Token_Right") = objSemItem_Familienstand.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                       objDR_Familienstand.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_isInState.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                objSemItem_Familienstand.GUID, _
                                                                objLocalConfig.SemItem_RelationType_isInState.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function del_004_PersonalData_To_Familienstand(Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Familienstand As DataRowCollection
        Dim objDR_Familienstand As DataRow

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objDRC_Familienstand = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                          objLocalConfig.SemItem_Type_Familienstand.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Familienstand In objDRC_Familienstand

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                   objDR_Familienstand.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_isInState.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_005_Geburtsdatum(ByVal dateGeburtsdatum As Date, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing, Optional ByVal SemItem_GUID_TokenAttribute_Geburtsdatum As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Geburtsdatum As DataRowCollection
        Dim objDR_Geburtsdatum As DataRow

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If



        objSemItem_GUID_TokenAttribute_Geburtsdatum = SemItem_GUID_TokenAttribute_Geburtsdatum



        If objSemItem_GUID_TokenAttribute_Geburtsdatum Is Nothing Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

            objDRC_Geburtsdatum = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_PersonalData.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Geburtsdatum.GUID).Rows
            For Each objDR_Geburtsdatum In objDRC_Geburtsdatum
                If objDR_Geburtsdatum.Item("Val_DateTime") = dateGeburtsdatum Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    objSemItem_GUID_TokenAttribute_Geburtsdatum = New clsSemItem
                    objSemItem_GUID_TokenAttribute_Geburtsdatum.GUID = objDR_Geburtsdatum.Item("GUID_TokenAttribute")
                Else
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Geburtsdatum.Item("GUID_TokenAttribute")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                End If
            Next
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DateTime.GetData(objSemItem_PersonalData.GUID, _
                                                                                 objLocalConfig.SemItem_Attribute_Geburtsdatum.GUID, _
                                                                                 Nothing, _
                                                                                 dateGeburtsdatum, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_GUID_TokenAttribute_Geburtsdatum = New clsSemItem
                    objSemItem_GUID_TokenAttribute_Geburtsdatum.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DateTime.GetData(objSemItem_PersonalData.GUID, _
                                                                                     objLocalConfig.SemItem_Attribute_Geburtsdatum.GUID, _
                                                                                     objSemItem_GUID_TokenAttribute_Geburtsdatum.GUID, _
                                                                                     dateGeburtsdatum, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function del_005_Geburtsdatum(Optional ByVal SemItem_GUID_TokenAttribute_Geburtsdatum As clsSemItem = Nothing, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Geburtsdatum As DataRowCollection
        Dim objDR_Geburtsdatum As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_GUID_TokenAttribute_Geburtsdatum Is Nothing Then
            objSemItem_GUID_TokenAttribute_Geburtsdatum = SemItem_GUID_TokenAttribute_Geburtsdatum
        End If

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If objSemItem_GUID_TokenAttribute_Vorname Is Nothing Then
            objDRC_Geburtsdatum = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_PersonalData.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Geburtsdatum.GUID).Rows
            For Each objDR_Geburtsdatum In objDRC_Geburtsdatum
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Geburtsdatum.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        Else
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_GUID_TokenAttribute_Geburtsdatum.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error

            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_006_PersonalData_To_Sozialversicherungsnummer(ByVal SemItem_Sozialversicherungsnummer As clsSemItem, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Sozialversicherungsnummer As DataRowCollection
        Dim objDR_Sozialversicherungsnummer As DataRow

        objSemItem_Sozialversicherungsnummer = SemItem_Sozialversicherungsnummer
        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_Sozialversicherungsnummer = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                          objLocalConfig.SemItem_Type_Sozialversicherungsnummer.GUID).Rows
        For Each objDR_Sozialversicherungsnummer In objDRC_Sozialversicherungsnummer
            If objDR_Sozialversicherungsnummer.Item("GUID_Token_Right") = objSemItem_Sozialversicherungsnummer.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                       objDR_Sozialversicherungsnummer.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_has.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                objSemItem_Sozialversicherungsnummer.GUID, _
                                                                objLocalConfig.SemItem_RelationType_has.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function del_006_PersonalData_To_Sozialversicherungsnummer(Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Sozialversicherungsnummer As DataRowCollection
        Dim objDR_Sozialversicherungsnummer As DataRow

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objDRC_Sozialversicherungsnummer = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                          objLocalConfig.SemItem_Type_Sozialversicherungsnummer.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Sozialversicherungsnummer In objDRC_Sozialversicherungsnummer

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                   objDR_Sozialversicherungsnummer.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_has.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_007_PersonalData_To_eTin(ByVal SemItem_eTin As clsSemItem, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_eTin As DataRowCollection
        Dim objDR_eTin As DataRow

        objSemItem_eTin = SemItem_eTin
        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_eTin = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                          objLocalConfig.SemItem_Type_eTin.GUID).Rows
        For Each objDR_eTin In objDRC_eTin
            If objDR_eTin.Item("GUID_Token_Right") = objSemItem_eTin.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                       objDR_eTin.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_has.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                objSemItem_eTin.GUID, _
                                                                objLocalConfig.SemItem_RelationType_has.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function del_007_PersonalData_To_eTin(Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_eTin As DataRowCollection
        Dim objDR_eTin As DataRow

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objDRC_eTin = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                          objLocalConfig.SemItem_Type_eTin.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_eTin In objDRC_eTin

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                   objDR_eTin.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_has.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_008_PersonalData_To_Identifkationsnummer__IdNr_(ByVal SemItem_Identifkationsnummer__IdNr_ As clsSemItem, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Identifkationsnummer__IdNr_ As DataRowCollection
        Dim objDR_Identifkationsnummer__IdNr_ As DataRow

        objSemItem_Identifkationsnummer__IdNr_ = SemItem_Identifkationsnummer__IdNr_
        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_Identifkationsnummer__IdNr_ = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                          objLocalConfig.SemItem_Type_Identifkationsnummer__IdNr_.GUID).Rows
        For Each objDR_Identifkationsnummer__IdNr_ In objDRC_Identifkationsnummer__IdNr_
            If objDR_Identifkationsnummer__IdNr_.Item("GUID_Token_Right") = objSemItem_Identifkationsnummer__IdNr_.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                       objDR_Identifkationsnummer__IdNr_.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_has.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                objSemItem_Identifkationsnummer__IdNr_.GUID, _
                                                                objLocalConfig.SemItem_RelationType_has.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function del_008_PersonalData_To_Identifkationsnummer__IdNr_(Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Identifkationsnummer__IdNr_ As DataRowCollection
        Dim objDR_Identifkationsnummer__IdNr_ As DataRow

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objDRC_Identifkationsnummer__IdNr_ = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                          objLocalConfig.SemItem_Type_Identifkationsnummer__IdNr_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Identifkationsnummer__IdNr_ In objDRC_Identifkationsnummer__IdNr_

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                   objDR_Identifkationsnummer__IdNr_.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_has.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_009_PersonalData_To_Steuernummer(ByVal SemItem_Steuernummer As clsSemItem, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Steuernummer As DataRowCollection
        Dim objDR_Steuernummer As DataRow

        objSemItem_Steuernummer = SemItem_Steuernummer
        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_Steuernummer = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                          objLocalConfig.SemItem_Type_Steuernummer.GUID).Rows
        For Each objDR_Steuernummer In objDRC_Steuernummer
            If objDR_Steuernummer.Item("GUID_Token_Right") = objSemItem_Steuernummer.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                       objDR_Steuernummer.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_has.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                objSemItem_Steuernummer.GUID, _
                                                                objLocalConfig.SemItem_RelationType_has.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function del_009_PersonalData_To_Steuernummer(Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Steuernummer As DataRowCollection
        Dim objDR_Steuernummer As DataRow

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objDRC_Steuernummer = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                          objLocalConfig.SemItem_Type_Steuernummer.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Steuernummer In objDRC_Steuernummer

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                   objDR_Steuernummer.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_has.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_010_PersonalData_To_Partner(ByVal SemItem_Partner As clsSemItem, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objSemItem_Partner = SemItem_Partner

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                              objSemItem_Partner.GUID, _
                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_010_PersonalData_To_Partner(Optional ByVal SemItem_Partner As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_PersonalData As DataRowCollection
        Dim objDR_PersonalData As DataRow

        If Not SemItem_Partner Is Nothing Then
            objSemItem_Partner = SemItem_Partner
        End If

        objDRC_PersonalData = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Partner.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                            objLocalConfig.SemItem_Type_nat_rliche_Person.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_PersonalData In objDRC_PersonalData
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDR_PersonalData.Item("GUID_Token_Left"), _
                                                                   objSemItem_Partner.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next


        Return objSemItem_Result
    End Function

    Public Function save_011_Todesdatum(ByVal dateTodesdatum As Date, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing, Optional ByVal SemItem_GUID_TokenAttribute_Todesdatum As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Todesdatum As DataRowCollection
        Dim objDR_Todesdatum As DataRow

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If



        objSemItem_GUID_TokenAttribute_Todesdatum = SemItem_GUID_TokenAttribute_Todesdatum



        If objSemItem_GUID_TokenAttribute_Todesdatum Is Nothing Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

            objDRC_Todesdatum = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_PersonalData.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Todesdatum.GUID).Rows
            For Each objDR_Todesdatum In objDRC_Todesdatum
                If objDR_Todesdatum.Item("Val_DateTime") = dateTodesdatum Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    objSemItem_GUID_TokenAttribute_Todesdatum = New clsSemItem
                    objSemItem_GUID_TokenAttribute_Todesdatum.GUID = objDR_Todesdatum.Item("GUID_TokenAttribute")
                Else
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Todesdatum.Item("GUID_TokenAttribute")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                End If
            Next
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DateTime.GetData(objSemItem_PersonalData.GUID, _
                                                                                 objLocalConfig.SemItem_Attribute_Todesdatum.GUID, _
                                                                                 Nothing, _
                                                                                 dateTodesdatum, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_GUID_TokenAttribute_Todesdatum = New clsSemItem
                    objSemItem_GUID_TokenAttribute_Todesdatum.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If

        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DateTime.GetData(objSemItem_PersonalData.GUID, _
                                                                                     objLocalConfig.SemItem_Attribute_Todesdatum.GUID, _
                                                                                     objSemItem_GUID_TokenAttribute_Todesdatum.GUID, _
                                                                                     dateTodesdatum, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function del_011_Todesdatum(Optional ByVal SemItem_GUID_TokenAttribute_Todesdatum As clsSemItem = Nothing, Optional ByVal SemItem_PersonalData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Todesdatum As DataRowCollection
        Dim objDR_Todesdatum As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_GUID_TokenAttribute_Todesdatum Is Nothing Then
            objSemItem_GUID_TokenAttribute_Todesdatum = SemItem_GUID_TokenAttribute_Todesdatum
        End If

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If objSemItem_GUID_TokenAttribute_Vorname Is Nothing Then
            objDRC_Todesdatum = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_PersonalData.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Todesdatum.GUID).Rows
            For Each objDR_Todesdatum In objDRC_Todesdatum
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Todesdatum.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        Else
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_GUID_TokenAttribute_Todesdatum.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error

            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_012_Image(ByVal SemItem_ImageGraphic As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_ImageGraphic = SemItem_ImageGraphic

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_ImageGraphic.GUID, _
                                                             objSemItem_ImageGraphic.Name, _
                                                             objSemItem_ImageGraphic.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_012_Image(Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_ImageGraphic.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID _
            And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_013_PersonalData_To_Image(Optional ByVal SemItem_PersonalData As clsSemItem = Nothing, Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        Dim objDRC_Photo As DataRowCollection
        Dim objDR_Photo As DataRow

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        objDRC_Photo = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belonging_photo.GUID, _
                                                                     objLocalConfig.SemItem_Type_Images__Graphic_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_Photo In objDRC_Photo
            If objDR_Photo.Item("GUID_Token_Right") = objSemItem_ImageGraphic.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                       objDR_Photo.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belonging_photo.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                    objSemItem_ImageGraphic.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_photo.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function del_013_PersonalData_To_Image(Optional ByVal SemItem_PersonalData As clsSemItem = Nothing, Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing) As clsSemItem

        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        Dim objDRC_Photo As DataRowCollection
        Dim objDR_Photo As DataRow

        If Not SemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = SemItem_PersonalData
        End If

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        objDRC_Photo = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belonging_photo.GUID, _
                                                                     objLocalConfig.SemItem_Type_Images__Graphic_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Photo In objDRC_Photo
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_PersonalData.GUID, _
                                                                   objDR_Photo.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belonging_photo.GUID).Rows
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
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Varchar255.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_DateTime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
