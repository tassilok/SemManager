Imports Sem_Manager
Public Class clsTransaction_Gewichtsmessung
    Private objLocalConfig As clsLocalConfig

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBwork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_DateTime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_DBWork_Del_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter
    Private semprocA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private objSemItem_Gewichtsmessung As clsSemItem
    Private objSemItem_Menge As clsSemItem
    Private objSemItem_Partner As clsSemItem

    Private objSemItem_TokenAttribute_Zeitpunkt As clsSemItem

    Public Function save_001_Gewichtsmessung(ByVal SemItem_Gewichtsmessung As clsSemItem) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objSemItem_Gewichtsmessung = SemItem_Gewichtsmessung

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Gewichtsmessung.GUID, _
                                                             objSemItem_Gewichtsmessung.Name, _
                                                             objSemItem_Gewichtsmessung.GUID_Parent, _
                                                             True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else

            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_Gewichtsmessung(Optional ByVal SemItem_Gewichtsmessung As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Gewichtsmessung Is Nothing Then
            objSemItem_Gewichtsmessung = SemItem_Gewichtsmessung
        End If


        objDRC_LogState = semprocA_DBwork_Del_Token.GetData(objSemItem_Gewichtsmessung.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        Return objSemItem_Result
    End Function

    Public Function save_002_Gewichtsmessung__Zeitpunkt(ByVal dateZeitpunkt As Date, Optional ByVal SemItem_TokenAttribute_Zeitpunkt As clsSemItem = Nothing, Optional ByVal SemItem_Gewichtsmessung As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Zeitpunkt As DataRowCollection
        Dim objDR_Zeitpunkt As DataRow

        objSemItem_TokenAttribute_Zeitpunkt = SemItem_TokenAttribute_Zeitpunkt
        If Not SemItem_Gewichtsmessung Is Nothing Then
            objSemItem_Gewichtsmessung = SemItem_Gewichtsmessung
        End If

        objDRC_Zeitpunkt = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Gewichtsmessung.GUID, _
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
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DateTime.GetData(objSemItem_Gewichtsmessung.GUID, _
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
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DateTime.GetData(objSemItem_Gewichtsmessung.GUID, _
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

    Public Function del_002_Gewichtsmessung__Zeitpunkt(Optional ByVal SemItem_Gewichtsmessung As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Zeitpunkt As DataRowCollection
        Dim objDR_Zeitpunkt As DataRow

        If Not SemItem_Gewichtsmessung Is Nothing Then
            objSemItem_Gewichtsmessung = SemItem_Gewichtsmessung
        End If
        objDRC_Zeitpunkt = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Gewichtsmessung.GUID, _
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

    Public Function save_003_Gewichtsmessung_To_Menge(ByVal SemItem_Menge As clsSemItem, Optional ByVal SemItem_Gewichtsmessung As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Menge As DataRowCollection
        Dim objDR_Menge As DataRow
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Menge = SemItem_Menge
        If Not SemItem_Gewichtsmessung Is Nothing Then
            objSemItem_Gewichtsmessung = SemItem_Gewichtsmessung
        End If

        objDRC_Menge = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Gewichtsmessung.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_Gewicht.GUID, _
                                                                     objLocalConfig.SemItem_Type_Menge.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Menge In objDRC_Menge
            If objDRC_Menge(0).Item("GUID_Token_Right") = objSemItem_Menge.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Gewichtsmessung.GUID, _
                                                                       objSemItem_Menge.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_Gewicht.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Gewichtsmessung.GUID, _
                                                                    objSemItem_Menge.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_Gewicht.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error

            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_Gewichtsmessung_To_Menge(Optional ByVal SemItem_Gewichtsmessung As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Menge As DataRowCollection
        Dim objDR_Menge As DataRow

        If Not SemItem_Gewichtsmessung Is Nothing Then
            objSemItem_Gewichtsmessung = SemItem_Gewichtsmessung
        End If
        objDRC_Menge = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Gewichtsmessung.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_Gewicht.GUID, _
                                                                     objLocalConfig.SemItem_Type_Menge.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Menge In objDRC_Menge
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Gewichtsmessung.GUID, _
                                                                   objDR_Menge.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_Gewicht.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_004_Gewichtsmessung_To_Partner(ByVal SemItem_Partner As clsSemItem, Optional ByVal SemItem_Gewichtsmessung As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Partner As DataRowCollection
        Dim objDR_Partner As DataRow

        objSemItem_Partner = SemItem_Partner

        If Not SemItem_Gewichtsmessung Is Nothing Then
            objSemItem_Gewichtsmessung = SemItem_Gewichtsmessung
        End If

        objDRC_Partner = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objSemItem_Gewichtsmessung.GUID, _
                                                                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Partner In objDRC_Partner
            If objDR_Partner.Item("GUID_Ref") = objSemItem_Partner.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_Token_OR.GetData(objSemItem_Gewichtsmessung.GUID, _
                                                                       objDR_Partner.Item("GUID_ObjectReference"), _
                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If


            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_OR_Token.GetData(objSemItem_Partner.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Partner.GUID_Related = objDRC_LogState(0).Item("GUID_ObjectReference")
                objDRC_LogState = semprocA_DBWork_Save_Token_OR.GetData(objSemItem_Gewichtsmessung.GUID, _
                                                                        objSemItem_Partner.GUID_Related, _
                                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_Gewichtsmessung_To_Partner(Optional ByVal SemItem_Gewichtsmessung As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Partner As DataRowCollection
        Dim objDR_Partner As DataRow

        If Not SemItem_Gewichtsmessung Is Nothing Then
            objSemItem_Gewichtsmessung = SemItem_Gewichtsmessung
        End If

        objDRC_Partner = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objSemItem_Gewichtsmessung.GUID, _
                                                                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Partner In objDRC_Partner
            objDRC_LogState = semprocA_DBWork_Del_Token_OR.GetData(objSemItem_Gewichtsmessung.GUID, _
                                                                   objDR_Partner.Item("GUID_ObjectReference"), _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
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
        semprocA_DBwork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token_OR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_DateTime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
