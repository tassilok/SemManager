Imports Sem_Manager
Public Class clsLinkManagement

    Private semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter


    Private objLocalConfig As clsLocalConfig
    Private objSemItem_Linked As clsSemItem
    Private boolDocument As Boolean

    Public Function parseLink(ByVal Arguments() As String) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Item As DataRowCollection
        Dim strArgument As String

        boolDocument = False
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        objSemItem_Linked = New clsSemItem
        For Each strArgument In Arguments
            If objLocalConfig.Globals.is_GUID(strArgument) Then
                Select Case strArgument
                    Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString
                        objSemItem_Linked.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID.ToString
                        objSemItem_Linked.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID.ToString
                        objSemItem_Linked.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString
                        objSemItem_Linked.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                    Case Else
                        objSemItem_Linked.GUID = New Guid(strArgument)
                End Select
            Else
                If strArgument.ToLower = "/d" Then
                    boolDocument = True
                End If
            End If
        Next

        If objLocalConfig.Globals.is_GUID(objSemItem_Linked.GUID.ToString) And objLocalConfig.Globals.is_GUID(objSemItem_Linked.GUID_Type.ToString) Then
            Select Case objSemItem_Linked.GUID_Type
                Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                    objDRC_Item = semtblA_Attribute.GetData_By_GUID(objSemItem_Linked.GUID).Rows
                    If objDRC_Item.Count > 0 Then
                        objSemItem_Linked.Name = objDRC_Item(0).Item("Name_Attribute")
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objDRC_Item = semtblA_Token.GetData_Token_By_GUID(objSemItem_Linked.GUID).Rows
                    If objDRC_Item.Count > 0 Then
                        objSemItem_Linked.Name = objDRC_Item(0).Item("Name_Token")
                        objSemItem_Linked.GUID_Parent = objDRC_Item(0).Item("GUID_Type")
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                    objDRC_Item = semtblA_Type.GetData_By_GUID(objSemItem_Linked.GUID).Rows
                    If objDRC_Item.Count > 0 Then
                        objSemItem_Linked.Name = objDRC_Item(0).Item("Name_Type")
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                    objDRC_Item = semtblA_RelationType.GetData_By_GUID(objSemItem_Linked.GUID).Rows
                    If objDRC_Item.Count > 0 Then
                        objSemItem_Linked.Name = objDRC_Item(0).Item("Name_RelationType")
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Case Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End Select
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

        End If


        Return objSemItem_Result
    End Function

    Private Function open_Document(ByVal objSemItem_Ref As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        Return objSemItem_Result
    End Function

    Private Function open_SemItem(ByVal objSemItem_Ref As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_RelationType.Connection = objLocalConfig.Connection_DB
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB
    End Sub

End Class
