Imports Sem_Manager
Public Class clsTransaction_ContentObject
    Private objLocalConfig As clsLocalConfig

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Datetime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHAR255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Save_TokenOR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_DBWork_Del_TokenOR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter

    Private procA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private procA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private procA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter

    Private procA_ConentObject_In_Doc As New ds_OfficeModuleTableAdapters.proc_ConentObject_In_DocTableAdapter

    Private objSemItem_ContentObject As clsSemItem
    Private objSemItem_ContentType As clsSemItem
    Private objSemItem_ManagedDoc As clsSemItem
    Private objSemItem_Ref As clsSemItem
    Private objSemItem_OR As clsSemItem

    Public Function test_Existance(ByVal SemItem_ManagedDoc As clsSemItem, ByVal SemItem_ContentType As clsSemItem, ByVal SemItem_Ref As clsSemItem) As clsSemItem
        Dim objDRC_CO_Exists As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objSemItem_ManagedDoc = SemItem_ManagedDoc
        objSemItem_ContentType = SemItem_ContentType
        objSemItem_Ref = SemItem_Ref

        objDRC_CO_Exists = procA_ConentObject_In_Doc.GetData(objLocalConfig.SemItem_Type_ContentType.GUID, _
                                                             objLocalConfig.SemItem_Type_ContentObject.GUID, _
                                                             objLocalConfig.SemItem_Type_Managed_Document.GUID, _
                                                             objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                             objLocalConfig.SemItem_RelationType_belonging_Document.GUID, _
                                                             objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID, _
                                                             objSemItem_ManagedDoc.GUID, _
                                                             objSemItem_ContentType.GUID, _
                                                             objSemItem_Ref.GUID, _
                                                             objSemItem_Ref.GUID_Type).Rows
        If objDRC_CO_Exists.Count > 0 Then
            objSemItem_OR = New clsSemItem
            objSemItem_OR.GUID = objDRC_CO_Exists(0).Item("GUID_ObjectReference")

            objSemItem_ContentObject = New clsSemItem
            objSemItem_ContentObject.GUID = objDRC_CO_Exists(0).Item("GUID_ContentObject")
            objSemItem_ContentObject.Name = objDRC_CO_Exists(0).Item("Name_ContentObject")
            objSemItem_ContentObject.GUID_Parent = objLocalConfig.SemItem_Type_ContentObject.GUID
            objSemItem_ContentObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objLocalConfig.Globals.LogState_Exists
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        End If

        Return objSemItem_Result
    End Function

    Public Function save_001_ContentObject(Optional ByVal SemItem_ContentObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ContentObject Is Nothing Then
            objSemItem_ContentObject = SemItem_ContentObject
        End If

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_ContentObject.GUID, _
                                                             objSemItem_ContentObject.Name, _
                                                             objSemItem_ContentObject.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_ContentObject(Optional ByVal SemItem_ContentObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If Not SemItem_ContentObject Is Nothing Then
            objSemItem_ContentObject = SemItem_ContentObject
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_ContentObject.GUID).Rows

        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Relation
        ElseIf objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_ContentObject_To_ContentType(Optional ByVal SemItem_ContentType As clsSemItem = Nothing, Optional ByVal SemItem_ContentObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_ContentType As DataRowCollection
        Dim objDR_ContentType As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ContentType Is Nothing Then
            objSemItem_ContentType = SemItem_ContentType
        End If

        If Not SemItem_ContentObject Is Nothing Then
            objSemItem_ContentObject = SemItem_ContentObject
        End If



        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_ContentType = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ContentObject.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                           objLocalConfig.SemItem_Type_Managed_Document.GUID).Rows
        For Each objDR_ContentType In objDRC_ContentType
            If objDR_ContentType.Item("GUID_Token_Right") = objSemItem_ContentType.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ContentObject.GUID, _
                                                                       objSemItem_ContentType.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ContentObject.GUID, _
                                                                    objSemItem_ContentType.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function


    Public Function del_002_ContentObject_To_ContentType(Optional ByVal SemItem_ContentObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_ContentType As DataRowCollection
        Dim objDR_ContentType As DataRow
        Dim objDRC_LogState As DataRowCollection


        If Not SemItem_ContentObject Is Nothing Then
            objSemItem_ContentObject = SemItem_ContentObject
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_ContentType = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ContentObject.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                           objLocalConfig.SemItem_Type_Managed_Document.GUID).Rows
        For Each objDR_ContentType In objDRC_ContentType

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ContentObject.GUID, _
                                                                    objSemItem_ContentType.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_003_ContentObject_To_ManagedDoc(Optional ByVal SemItem_ManagedDoc As clsSemItem = Nothing, Optional ByVal SemItem_ContentObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ManagedDoc As DataRowCollection
        Dim objDR_ManagedDoc As DataRow

        If Not SemItem_ManagedDoc Is Nothing Then
            objSemItem_ManagedDoc = SemItem_ManagedDoc
        End If

        If Not SemItem_ContentObject Is Nothing Then
            objSemItem_ContentObject = SemItem_ContentObject
        End If



        objDRC_ManagedDoc = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ContentObject.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging_Document.GUID, _
                                                                          objLocalConfig.SemItem_Type_Managed_Document.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_ManagedDoc In objDRC_ManagedDoc
            If objDR_ManagedDoc.Item("GUID_Token_Right") = objSemItem_ManagedDoc.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ContentObject.GUID, _
                                                                       objSemItem_ManagedDoc.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Document.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ContentObject.GUID, _
                                                                    objSemItem_ManagedDoc.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Document.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_ContentObject_To_ManagedDoc(Optional ByVal SemItem_ContentObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_ManagedDoc As DataRowCollection
        Dim objDR_ManagedDoc As DataRow
        Dim objDRC_LogState As DataRowCollection


        If Not objSemItem_ManagedDoc Is Nothing Then
            objSemItem_ManagedDoc = objSemItem_ManagedDoc
        End If

        If Not SemItem_ContentObject Is Nothing Then
            objSemItem_ContentObject = SemItem_ContentObject
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_ManagedDoc = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ContentObject.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_belonging_Document.GUID, _
                                                                           objLocalConfig.SemItem_Type_Managed_Document.GUID).Rows
        For Each objDR_ManagedDoc In objDRC_ManagedDoc

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ContentObject.GUID, _
                                                                    objSemItem_ManagedDoc.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Document.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_004_ContentObect_To_Related(Optional ByVal SemItem_Ref As clsSemItem = Nothing, Optional ByVal SemItem_ContentObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_OR As DataRowCollection
        Dim objDR_Or As DataRow

        If Not SemItem_Ref Is Nothing Then
            objSemItem_Ref = SemItem_Ref
        End If


        If Not SemItem_Ref Is Nothing Then
            objSemItem_Ref = SemItem_Ref
        End If

        If Not SemItem_ContentObject Is Nothing Then
            objSemItem_ContentObject = SemItem_ContentObject
        End If

        Select Case objSemItem_Ref.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objDRC_OR = procA_DBWork_Save_OR_Attribute.GetData(objSemItem_Ref.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objDRC_OR = procA_DBWork_Save_OR_RelationType.GetData(objSemItem_Ref.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_OR = procA_DBWork_Save_OR_Token.GetData(objSemItem_Ref.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objDRC_OR = procA_DBWork_Save_OR_Type.GetData(objSemItem_Ref.GUID).Rows

        End Select

        If objDRC_OR.Count > 0 Then
            objSemItem_OR = New clsSemItem
            objSemItem_OR.GUID = objDRC_OR(0).Item("GUID_ObjectReference")

            objDRC_OR = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objSemItem_ContentObject.GUID, _
                                                                                     objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID).Rows
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            For Each objDR_Or In objDRC_OR
                If objDR_Or.Item("GUID_ObjectReference") = objSemItem_OR.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objDRC_LogState = semprocA_DBWork_Del_TokenOR.GetData(objSemItem_ContentObject.GUID, _
                                                                          objDR_Or.Item("GUID_ObjectReference"), _
                                                                          objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                End If
            Next

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objDRC_LogState = semprocA_DBWork_Save_TokenOR.GetData(objSemItem_ContentObject.GUID, _
                                                                       objSemItem_OR.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID, 1).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_ContentObject_To_Related(Optional ByVal SemItem_ContentObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_OR As DataRowCollection
        Dim objDR_OR As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ContentObject Is Nothing Then
            objSemItem_ContentObject = SemItem_ContentObject
        End If


        objDRC_OR = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objSemItem_ContentObject.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_OR In objDRC_OR
            objDRC_LogState = semprocA_DBWork_Del_TokenOR.GetData(objSemItem_ContentObject.GUID, _
                                                                  objDR_OR.Item("GUID_ObjectReference"), _
                                                                  objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID).Rows
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
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenAttribute_Datetime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHAR255.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenOR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenOR.Connection = objLocalConfig.Connection_DB

        procA_DBWork_Save_OR_Attribute.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_RelationType.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Type.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB

        procA_ConentObject_In_Doc.Connection = objLocalConfig.Connection_Plugin
    End Sub
End Class
