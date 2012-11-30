Imports Sem_Manager
Public Class clsTransaction_Logentries
    Private objLocalConfig As clsLocalConfig

    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_DATETIME As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter

    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Del_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter

    Private procA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private procA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private procA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter

    Private objSemItem_LogEntry As clsSemItem
    Private dateTimeStamp As Date
    Private objSemItem_TokenAttribute_DateTimeStamp As clsSemItem
    Private strMessage As String
    Private objSemItem_TokenAttribute_Message As clsSemItem
    Private objSemItem_User As clsSemItem
    Private objSemItem_Ref As clsSemItem
    Private objSemItem_LogState As clsSemItem

    Public Function save_000_LogEntry(ByVal SemItem_LogEntry As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_LogEntry = SemItem_LogEntry

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_LogEntry.GUID, _
                                                              objSemItem_LogEntry.Name, _
                                                              objSemItem_LogEntry.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function save_001_LogEntry_Datetime(ByVal SemItem_LogEntry As clsSemItem, ByVal dateTimeStamp As Date) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_DateTimeStamp As DataRowCollection
        Dim objDR_DateTimeStamp As DataRow
        Dim objDRC_LogState As DataRowCollection

        objSemItem_LogEntry = SemItem_LogEntry
        Me.dateTimeStamp = dateTimeStamp

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_DateTimeStamp = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_LogEntry.GUID, _
                                                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID).Rows
        For Each objDR_DateTimeStamp In objDRC_DateTimeStamp
            If objDR_DateTimeStamp.Item("VAL_DateTime") = dateTimeStamp Then
                objSemItem_TokenAttribute_DateTimeStamp = New clsSemItem
                objSemItem_TokenAttribute_DateTimeStamp.GUID = objDR_DateTimeStamp.Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_DateTimeStamp.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If


            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DATETIME.GetData(objSemItem_LogEntry.GUID, _
                                                                                   objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                   Nothing, _
                                                                                   dateTimeStamp, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_DateTimeStamp = New clsSemItem
                objSemItem_TokenAttribute_DateTimeStamp.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        End If


        Return objSemItem_Result
    End Function

    Public Function del_001_DateTimeStamp(Optional ByVal SemItem_Logentry As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_DateTimeStamp As DataRowCollection
        Dim objDR_DateTimeStamp As DataRow

        If Not SemItem_Logentry Is Nothing Then
            objSemItem_LogEntry = SemItem_Logentry
        End If

        objDRC_DateTimeStamp = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_LogEntry.GUID, _
                                                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_DateTimeStamp In objDRC_DateTimeStamp
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_DateTimeStamp.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_002_Message(ByVal strMessage As String, Optional ByVal SemItem_LogEntry As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Message As DataRowCollection
        Dim objDR_Message As DataRow

        Me.strMessage = strMessage

        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_LogEntry = SemItem_LogEntry
        End If

        objDRC_Message = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_LogEntry.GUID, _
                                                                                                        objLocalConfig.SemItem_Attribute_Message.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_Message In objDRC_Message
            If objDR_Message.Item("Val_VARCHARMAX") = strMessage Then
                objSemItem_TokenAttribute_Message = New clsSemItem
                objSemItem_TokenAttribute_Message.GUID = objDR_Message.Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Message.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_LogEntry.GUID, _
                                                                                     objLocalConfig.SemItem_Attribute_Message.GUID, _
                                                                                     Nothing, _
                                                                                     strMessage, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_Message = New clsSemItem
                objSemItem_TokenAttribute_Message.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result

    End Function

    Public Function del_002_Message(Optional ByVal SemItem_LogEntry As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Message As DataRowCollection
        Dim objDR_Message As DataRow

        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_LogEntry = SemItem_LogEntry
        End If

        objDRC_Message = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_LogEntry.GUID, _
                                                                                                        objLocalConfig.SemItem_Attribute_Message.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Message In objDRC_Message
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Message.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_003_User(ByVal SemItem_User As clsSemItem, Optional ByVal SemItem_LogEntry As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_User As DataRowCollection
        Dim objDR_User As DataRow

        objSemItem_User = SemItem_User

        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_LogEntry = SemItem_LogEntry
        End If

        objDRC_User = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_LogEntry.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_wasCreatedBy.GUID, _
                                                                    objLocalConfig.SemItem_type_User.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_User In objDRC_User
            If objDR_User.Item("GUID_Token_Right") = objSemItem_User.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success

            Else
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_LogEntry.GUID, _
                                                                        objDR_User.Item("GUID_TokeN_Right"), _
                                                                        objLocalConfig.SemItem_RelationType_wasCreatedBy.GUID, 1).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_LogEntry.GUID, _
                                                                    objSemItem_User.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_wasCreatedBy.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_User(Optional ByVal SemItem_LogEntry As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_User As DataRowCollection
        Dim objDR_User As DataRow

        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_LogEntry = SemItem_LogEntry
        End If

        objDRC_User = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_LogEntry.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_wasCreatedBy.GUID, _
                                                                    objLocalConfig.SemItem_type_User.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_User In objDRC_User
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_LogEntry.GUID, _
                                                                   objDR_User.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_wasCreatedBy.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_004_Relation(ByVal SemItem_Ref As clsSemItem, Optional ByVal SemItem_LogEntry As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Relation As DataRowCollection
        Dim objDR_Relation As DataRow

        objSemItem_Ref = SemItem_Ref

        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_LogEntry = SemItem_LogEntry
        End If

        Select Case SemItem_Ref.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Attribute.GetData(objSemItem_Ref.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objDRC_LogState = procA_DBWork_Save_OR_RelationType.GetData(objSemItem_Ref.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Token.GetData(objSemItem_Ref.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Type.GetData(objSemItem_Ref.GUID).Rows

        End Select

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Ref.GUID_Related = objDRC_LogState(0).Item("GUID_ObjectReference")
            objDRC_LogState = semprocA_DBWork_Save_Token_OR.GetData(objSemItem_LogEntry.GUID, _
                                                                    objSemItem_Ref.GUID_Related, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows
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

    Public Function del_004_Reference(Optional ByVal SemItem_Ref As clsSemItem = Nothing, Optional ByVal SemItem_LogEntry As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Ref Is Nothing Then
            objSemItem_Ref = SemItem_Ref
        End If


        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_LogEntry = SemItem_LogEntry
        End If

        Select Case SemItem_Ref.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Attribute.GetData(objSemItem_Ref.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objDRC_LogState = procA_DBWork_Save_OR_RelationType.GetData(objSemItem_Ref.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Token.GetData(objSemItem_Ref.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Type.GetData(objSemItem_Ref.GUID).Rows

        End Select

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Ref.GUID_Related = objDRC_LogState(0).Item("GUID_ObjectReference")
            objDRC_LogState = semprocA_DBWork_Del_Token_OR.GetData(objSemItem_LogEntry.GUID, _
                                                                   objSemItem_Ref.GUID_Related, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
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

    Public Function save_005_LogState(ByVal SemItem_LogState As clsSemItem, Optional ByVal SemItem_LogEntry As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Result As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_LogState As DataRow

        If Not SemItem_LogState Is Nothing Then
            objSemItem_LogState = SemItem_LogState
        End If

        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_LogEntry = SemItem_LogEntry
        End If

        objDRC_LogState = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_LogEntry.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_provides.GUID, _
                                                                        objLocalConfig.SemItem_type_Logstate.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_LogState In objDRC_LogState
            If objDR_LogState.Item("GUID_Token_Right") = objSemItem_LogState.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_Result = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_LogEntry.GUID, _
                                                                     objDR_LogState.Item("GUID_TokeN_Right"), _
                                                                     objLocalConfig.SemItem_RelationType_provides.GUID).Rows
                If objDRC_Result(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next


        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_Result = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_LogEntry.GUID, _
                                                                  objSemItem_LogState.GUID, _
                                                                  objLocalConfig.SemItem_RelationType_provides.GUID, 1).Rows
            If Not objDRC_Result(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function del_005_LogState(Optional ByVal SemItem_LogEntry As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Result As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_LogState As DataRow

        If Not SemItem_LogEntry Is Nothing Then
            objSemItem_LogEntry = SemItem_LogEntry
        End If

        objDRC_LogState = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_LogEntry.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_provides.GUID, _
                                                                        objLocalConfig.SemItem_type_Logstate.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_LogState In objDRC_LogState
            objDRC_Result = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_LogEntry.GUID, _
                                                                    objDR_LogState.Item("GUID_TokeN_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_provides.GUID).Rows
            If objDRC_Result(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
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
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_DATETIME.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token_OR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB

        procA_DBWork_Save_OR_Attribute.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_RelationType.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Type.Connection = objLocalConfig.Connection_DB
    End Sub

End Class
