Imports Sem_Manager


Public Class clsLogManagement
    Private objLocalConfig As clsLocalConfig
    Private objSemItem_LogEntry As New clsSemItem

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_TokenAttribute_Datetime As New ds_TokenAttributeTableAdapters.TokenAttribute_DatetimeTableAdapter
    Private procA_TokenAttribute_VARCHARMAX As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Datetime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Del_TokenATtribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter


    Public Function log_Entry(ByVal dateTimestamp As Date, ByVal GUID_Token_LogState As Guid, ByVal GUID_Token_User As Guid, Optional ByVal strMessage As String = Nothing) As clsSemItem

        Dim objGUID As Guid
        Dim objDRC_LogState As DataRowCollection

        objSemItem_LogEntry = New clsSemItem
        objSemItem_LogEntry.GUID = Guid.NewGuid
        If strMessage = "" Or strMessage Is Nothing Then
            objSemItem_LogEntry.Name = dateTimestamp.ToString
        Else
            If strMessage.Length > 200 Then
                objSemItem_LogEntry.Name = dateTimestamp.ToString & ": " & strMessage.Substring(0, 200) & "..."
            Else
                objSemItem_LogEntry.Name = dateTimestamp.ToString & ": " & strMessage
            End If
        End If

        objSemItem_LogEntry.GUID_Parent = objLocalConfig.SemItem_Type_LogEntry.GUID

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_LogEntry.GUID, objSemItem_LogEntry.Name, objSemItem_LogEntry.GUID_Parent, True).Rows

        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_LogEntry.GUID, GUID_Token_LogState, objLocalConfig.SemItem_RelationType_provides.GUID, 0).Rows


            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then

                objSemItem_LogEntry = Nothing
            Else

                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_LogEntry.GUID, objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, Nothing, dateTimestamp, 0).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    If Not strMessage = "" Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_LogEntry.GUID, objLocalConfig.SemItem_Attribute_Message.GUID, Nothing, strMessage, 0).Rows

                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_LogEntry = Nothing
                        End If

                    End If
                    If Not GUID_Token_User = Nothing And Not objSemItem_LogEntry Is Nothing Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_LogEntry.GUID, GUID_Token_User, objLocalConfig.SemItem_RelationType_wasCreatedBy.GUID, 0).Rows


                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            objSemItem_LogEntry = Nothing
                        End If

                    End If
                Else
                    objSemItem_LogEntry = Nothing
                End If

            End If



        Else
            objSemItem_LogEntry = Nothing
        End If


        Return objSemItem_LogEntry
    End Function

    Public Function del_LogEntry(ByVal GUID_LogEntry As Guid) As clsSemItem
        Dim objDRC_Related As DataRowCollection
        Dim objDR_Related As DataRow
        Dim objSemItem_Result As clsSemItem = Nothing
        Dim objDRC_LogState As DataRowCollection
        Dim boolDel As Boolean = True

        objDRC_Related = funcA_TokenToken.GetData_RightLeft_Tokens_By_GUIDTokenRight_Only(GUID_LogEntry).Rows
        If objDRC_Related.Count > 0 Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Relation
        Else
            objDRC_Related = funcA_TokenToken.GetData_LeftRight_Tokens_By_GUIDTokenLeft_Only(GUID_LogEntry).Rows
            For Each objDR_Related In objDRC_Related
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(GUID_LogEntry, objDR_Related.Item("GUID_Token_Right"), objDR_Related.Item("GUID_RelationType")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    boolDel = False
                    Exit For
                End If
            Next
            If boolDel = True Then
                objDRC_Related = procA_TokenAttribute_Datetime.GetData_By_GUIDAttribute_And_GUIDToken(GUID_LogEntry, objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID).Rows
                For Each objDR_Related In objDRC_Related
                    objDRC_LogState = semprocA_DBWork_Del_TokenATtribute.GetData(objDR_Related.Item("GUID_TokenAttribute")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        boolDel = False
                        Exit For
                    End If
                Next

                If boolDel = True Then
                    objDRC_Related = procA_TokenAttribute_VARCHARMAX.GetData_By_GUIDAttribute_And_GUIDToken(GUID_LogEntry, objLocalConfig.SemItem_Attribute_Message.GUID).Rows
                    For Each objDR_Related In objDRC_Related
                        objDRC_LogState = semprocA_DBWork_Del_TokenATtribute.GetData(objDR_Related.Item("GUID_TokenAttribute")).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                            Exit For
                        End If
                    Next
                End If
            End If
        End If
        Return objSemItem_Result
    End Function

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Datetime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenATtribute.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_Datetime.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
