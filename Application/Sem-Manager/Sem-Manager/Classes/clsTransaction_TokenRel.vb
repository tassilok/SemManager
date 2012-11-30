Public Class clsTransaction_TokenRel
    Private objGlobals As clsGlobals
    Private objConnection As SqlClient.SqlConnection

    Private semtblA_TypeType As New ds_SemDBTableAdapters.semtbl_Type_TypeTableAdapter
    Private semtblA_Type_OR As New ds_SemDBTableAdapters.semtbl_Type_ORTableAdapter
    Private semprocA_Save_TypeRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TypeRelTableAdapter
    Private semprocA_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_Del_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter
    Private semprocA_Save_Type_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Type_ORTableAdapter
    Private semprocA_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private semprocA_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private semprocA_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter

    Private objSemItem_Token_Left As clsSemItem
    Private objSemItem_Relationtype As clsSemItem
    Private objSemItem_Right As clsSemItem
    Private GUID_OR As Guid


    Public Function save_001_TokenRel(ByVal SemItem_Token_Left As clsSemItem, ByVal SemItem_RelationType As clsSemItem, ByVal SemItem_Right As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Token_Left = SemItem_Token_Left
        objSemItem_Relationtype = SemItem_RelationType
        objSemItem_Right = SemItem_Right

        objSemItem_Result = save_001a_TypeRel()
        If objSemItem_Result.GUID = objGlobals.LogState_Success.GUID Then
            Select objSemItem_Right.GUID_Type
                Case objGlobals.ObjectReferenceType_Token.GUID
                    objDRC_LogState = semprocA_Save_TokenRel.GetData(objSemItem_Token_Left.GUID, _
                                                                     objSemItem_Right.GUID, _
                                                                     objSemItem_Relationtype.GUID, objSemItem_Right.Level).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                        objSemItem_Result = objGlobals.LogState_Success
                    Else
                        objSemItem_Result = objGlobals.LogState_Error
                    End If
                Case objGlobals.ObjectReferenceType_Attribute.GUID
                    If objSemItem_Right.Mark = False Then
                        objDRC_LogState = semprocA_Save_OR_Attribute.GetData(objSemItem_Right.GUID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            GUID_OR = objDRC_LogState(0).Item("GUID_ObjectReference")
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Else
                        GUID_OR = objSemItem_Right.GUID
                        objSemItem_Result = objGlobals.LogState_Success
                    End If
                    If objSemItem_Result.GUID = objGlobals.LogState_Success.GUID Then
                        objDRC_LogState = semprocA_Save_Token_OR.GetData(objSemItem_Token_Left.GUID, _
                                                                             GUID_OR, _
                                                                             objSemItem_Relationtype.GUID, objSemItem_Right.Level).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    End If
                    
                    
                Case objGlobals.ObjectReferenceType_RelationType.GUID
                    If objSemItem_Right.Mark = False Then
                        objDRC_LogState = semprocA_Save_OR_RelationType.GetData(objSemItem_Right.GUID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            GUID_OR = objDRC_LogState(0).Item("GUID_ObjectReference")
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Else
                        GUID_OR = objSemItem_Right.GUID
                        objSemItem_Result = objGlobals.LogState_Success
                    End If

                    If objSemItem_Result.GUID = objGlobals.LogState_Success.GUID Then
                        objDRC_LogState = semprocA_Save_Token_OR.GetData(objSemItem_Token_Left.GUID, _
                                                                             GUID_OR, _
                                                                             objSemItem_Relationtype.GUID, objSemItem_Right.Level).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    End If
                    

                Case objGlobals.ObjectReferenceType_Type.GUID
                    If objSemItem_Right.Mark = False Then
                        objDRC_LogState = semprocA_Save_OR_Type.GetData(objSemItem_Right.GUID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            GUID_OR = objDRC_LogState(0).Item("GUID_ObjectReference")
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Else
                        GUID_OR = objSemItem_Right.GUID
                        objSemItem_Result = objGlobals.LogState_Success
                    End If

                    If objSemItem_Result.GUID = objGlobals.LogState_Success.GUID Then
                        objDRC_LogState = semprocA_Save_Token_OR.GetData(objSemItem_Token_Left.GUID, _
                                                                             GUID_OR, _
                                                                             objSemItem_Relationtype.GUID, objSemItem_Right.Level).Rows

                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    End If
                    
                    
            End Select
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_TokenRel(Optional ByVal SemItem_Token_Left As clsSemItem = Nothing, Optional ByVal SemItem_RelationType As clsSemItem = Nothing, Optional ByVal SemItem_Right As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Token_Left Is Nothing Then
            objSemItem_Token_Left = SemItem_Token_Left
        End If

        If Not SemItem_RelationType Is Nothing Then
            objSemItem_Relationtype = SemItem_RelationType
        End If

        If Not SemItem_Right Is Nothing Then
            objSemItem_Right = SemItem_Right
        End If


        objSemItem_Result = objGlobals.LogState_Success

        Select Case objSemItem_Right.GUID_Type
            Case objGlobals.ObjectReferenceType_Token.GUID
                objDRC_LogState = semprocA_Del_TokenRel.GetData(objSemItem_Token_Left.GUID, _
                                                                objSemItem_Right.GUID, _
                                                                objSemItem_Relationtype.GUID).Rows

                If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                    objSemItem_Result = objGlobals.LogState_Success
                Else
                    objSemItem_Result = objGlobals.LogState_Error
                End If
            Case objGlobals.ObjectReferenceType_Attribute.GUID
                objDRC_LogState = semprocA_Save_OR_Attribute.GetData(objSemItem_Right.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                    GUID_OR = objDRC_LogState(0).Item("GUID_ObjectReference")
                    objDRC_LogState = semprocA_Del_Token_OR.GetData(objSemItem_Token_Left.GUID, _
                                                                    GUID_OR, _
                                                                    objSemItem_Relationtype.GUID).Rows

                    If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                        objSemItem_Result = objGlobals.LogState_Success
                    Else
                        objSemItem_Result = objGlobals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objGlobals.LogState_Error
                End If
            Case objGlobals.ObjectReferenceType_RelationType.GUID
                objDRC_LogState = semprocA_Save_OR_RelationType.GetData(objSemItem_Right.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                    GUID_OR = objDRC_LogState(0).Item("GUID_ObjectReference")
                    objDRC_LogState = semprocA_Del_Token_OR.GetData(objSemItem_Token_Left.GUID, _
                                                                     GUID_OR, _
                                                                     objSemItem_Relationtype.GUID).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                        objSemItem_Result = objGlobals.LogState_Success
                    Else
                        objSemItem_Result = objGlobals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objGlobals.LogState_Error
                End If
            Case objGlobals.ObjectReferenceType_Type.GUID
                objDRC_LogState = semprocA_Save_OR_Type.GetData(objSemItem_Right.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                    GUID_OR = objDRC_LogState(0).Item("GUID_ObjectReference")
                    objDRC_LogState = semprocA_Del_Token_OR.GetData(objSemItem_Token_Left.GUID, _
                                                                     GUID_OR, _
                                                                     objSemItem_Relationtype.GUID).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                        objSemItem_Result = objGlobals.LogState_Success
                    Else
                        objSemItem_Result = objGlobals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objGlobals.LogState_Error
                End If
        End Select


        Return objSemItem_Result
    End Function

    Private Function save_001a_TypeRel() As clsSemItem
        Dim objDRC_OR As DataRowCollection

        Dim objDRC_Relation As DataRowCollection
        Dim objDR_Relation As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objGlobals.LogState_Success
        Select Case objSemItem_Right.GUID_Type
            Case objGlobals.ObjectReferenceType_Token.GUID
                objDRC_Relation = semtblA_TypeType.GetData_ByGUIDs(objSemItem_Token_Left.GUID_Parent, _
                                                                   objSemItem_Right.GUID_Parent, _
                                                                   objSemItem_Relationtype.GUID).Rows
                If objDRC_Relation.Count = 0 Then
                    objDRC_LogState = semprocA_Save_TypeRel.GetData(objSemItem_Token_Left.GUID_Parent, _
                                                                    objSemItem_Right.GUID_Parent, _
                                                                    objSemItem_Relationtype.GUID, _
                                                                    0, -1, -1).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                        objSemItem_Result = objGlobals.LogState_Success
                    Else
                        objSemItem_Result = objGlobals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objGlobals.LogState_Success
                End If
            Case objGlobals.ObjectReferenceType_Attribute.GUID, objGlobals.ObjectReferenceType_Type.GUID
                objDRC_Relation = semtblA_Type_OR.GetData_By_GUIDType(objSemItem_Token_Left.GUID_Parent).Rows
                objSemItem_Result = objGlobals.LogState_Nothing
                For Each objDR_Relation In objDRC_Relation
                    If objDR_Relation.Item("GUID_RelationType") = objSemItem_Relationtype.GUID Then
                        objSemItem_Result = objGlobals.LogState_Success
                        Exit For
                    End If
                Next

                If objSemItem_Result.GUID = objGlobals.LogState_Nothing.GUID Then
                    objDRC_LogState = semprocA_Save_Type_OR.GetData(objSemItem_Token_Left.GUID_Parent, _
                                                                    objSemItem_Relationtype.GUID, 0, -1).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                        objSemItem_Result = objGlobals.LogState_Error
                    Else
                        objSemItem_Result = objGlobals.LogState_Success
                    End If
                End If

        End Select

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objConnection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        semtblA_TypeType.Connection = objConnection
        semtblA_TypeType.Connection = objConnection
        semtblA_Type_OR.Connection = objConnection
        semprocA_Save_Type_OR.Connection = objConnection
        semprocA_Save_TokenRel.Connection = objConnection
        semprocA_Save_TypeRel.Connection = objConnection
        semprocA_Del_Token_OR.Connection = objConnection
        semprocA_Del_TokenRel.Connection = objConnection

        semprocA_Save_OR_Attribute.Connection = objConnection
        semprocA_Save_OR_RelationType.Connection = objConnection
        semprocA_Save_OR_Type.Connection = objConnection
        semprocA_Save_Token_OR.Connection = objConnection
    End Sub

End Class
