Public Class clsSemClipboard

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter

    Private procA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private procA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private procA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter

    Private semprocA_DBWork_Save_TokenOr As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_DBWork_Del_TokenOr As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter

    Private objLocalConfig_Semmanager As clsLocalConfig_SemManager

    Private objSemItem_OR As New clsSemItem

    Public Function addToClipboard(ByVal SemItem_Item As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Clipboard As DataRowCollection
        Dim objDR_Clipboard As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_RelationType As New clsSemItem

        Select Case SemItem_Item.GUID_Type
            Case objLocalConfig_Semmanager.Globals.ObjectReferenceType_Attribute.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Attribute.GetData(SemItem_Item.GUID).Rows
                objSemItem_RelationType = objLocalConfig_Semmanager.SemItem_RelationType_belonging_Attribute

            Case objLocalConfig_Semmanager.Globals.ObjectReferenceType_RelationType.GUID
                objDRC_LogState = procA_DBWork_Save_OR_RelationType.GetData(SemItem_Item.GUID).Rows
                objSemItem_RelationType = objLocalConfig_Semmanager.SemItem_RelationType_RelationType

            Case objLocalConfig_Semmanager.Globals.ObjectReferenceType_Token.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Token.GetData(SemItem_Item.GUID).Rows
                objSemItem_RelationType = objLocalConfig_Semmanager.SemItem_RelationType_belonging_Token


            Case objLocalConfig_Semmanager.Globals.ObjectReferenceType_Type.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Type.GetData(SemItem_Item.GUID).Rows
                objSemItem_RelationType = objLocalConfig_Semmanager.SemItem_RelationType_belonging_Type

        End Select

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig_Semmanager.Globals.LogState_Error.GUID Then
            objSemItem_OR = New clsSemItem
            objSemItem_OR.GUID = objDRC_LogState(0).Item("GUID_ObjectReference")

            objDRC_Clipboard = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objLocalConfig_Semmanager.SemItem_BaseConfig.GUID, _
                                                                                            objSemItem_RelationType.GUID).Rows
            For Each objDR_Clipboard In objDRC_Clipboard
                objDRC_LogState = semprocA_DBWork_Del_TokenOr.GetData(objLocalConfig_Semmanager.SemItem_BaseConfig.GUID, _
                                                                      objDR_Clipboard.Item("GUID_ObjectReference"), _
                                                                      objSemItem_RelationType.GUID).Rows
            Next
            

            objSemItem_Result = objLocalConfig_Semmanager.Globals.LogState_Success

            objDRC_LogState = semprocA_DBWork_Save_TokenOr.GetData(objLocalConfig_Semmanager.SemItem_BaseConfig.GUID, _
                                                                   objSemItem_OR.GUID, _
                                                                   objSemItem_RelationType.GUID, 1).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig_Semmanager.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig_Semmanager.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig_Semmanager.Globals.LogState_Error
            End If
        Else
            objSemItem_OR = Nothing

            objSemItem_Result = objLocalConfig_Semmanager.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function getFromClipboard(ByVal SemItem_Type As clsSemItem, Optional ByVal boolRemoveFromClipboard As Boolean = False) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_RelationType As clsSemItem
        Dim objDRC_ClipBoard As DataRowCollection
        Dim objDR_ClipBoard As DataRow
        Dim objDRC_Token As DataRowCollection

        Select Case SemItem_Type.GUID
            Case objLocalConfig_Semmanager.Globals.ObjectReferenceType_Attribute.GUID
                objSemItem_RelationType = objLocalConfig_Semmanager.SemItem_RelationType_belonging_Attribute

            Case objLocalConfig_Semmanager.Globals.ObjectReferenceType_RelationType.GUID
                objSemItem_RelationType = objLocalConfig_Semmanager.SemItem_RelationType_RelationType

            Case objLocalConfig_Semmanager.Globals.ObjectReferenceType_Token.GUID
                objSemItem_RelationType = objLocalConfig_Semmanager.SemItem_RelationType_belonging_Token

            Case objLocalConfig_Semmanager.Globals.ObjectReferenceType_Type.GUID
                objSemItem_RelationType = objLocalConfig_Semmanager.SemItem_RelationType_belonging_Type

        End Select

        objDRC_ClipBoard = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objLocalConfig_Semmanager.SemItem_BaseConfig.GUID, _
                                                                                        objSemItem_RelationType.GUID).Rows

        If objDRC_ClipBoard.Count > 0 Then
            objSemItem_Result = New clsSemItem
            objSemItem_Result.GUID = objDRC_ClipBoard(0).Item("GUID_Ref")
            objSemItem_Result.Name = objDRC_ClipBoard(0).Item("Name_Ref")
            If objDRC_ClipBoard(0).Item("GUID_ItemType") = objLocalConfig_Semmanager.Globals.ObjectReferenceType_Token.GUID Then
                objDRC_Token = semtblA_Token.GetData_Token_By_GUID(objSemItem_Result.GUID).Rows
                If objDRC_Token.Count > 0 Then
                    objSemItem_Result.GUID_Parent = objDRC_Token(0).Item("GUID_Type")
                End If
            End If
            objSemItem_Result.GUID_Type = objDRC_ClipBoard(0).Item("GUID_ItemType")

            If boolRemoveFromClipboard = True Then
                semprocA_DBWork_Del_TokenOr.GetData(objLocalConfig_Semmanager.SemItem_BaseConfig.GUID, _
                                                    objDRC_ClipBoard(0).Item("GUID_ObjectReference"), _
                                                    objSemItem_RelationType.GUID)
            End If
        Else
            objSemItem_Result = Nothing
        End If

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig_SemManager)
        objLocalConfig_Semmanager = LocalConfig
        set_DBConnection()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig_Semmanager = New clsLocalConfig_SemManager(Globals)
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig_Semmanager.Connection_User
        funcA_Token_OR.Connection = objLocalConfig_Semmanager.Connection_User

        procA_DBWork_Save_OR_Attribute.Connection = objLocalConfig_Semmanager.Connection_User
        procA_DBWork_Save_OR_RelationType.Connection = objLocalConfig_Semmanager.Connection_User
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig_Semmanager.Connection_User
        procA_DBWork_Save_OR_Type.Connection = objLocalConfig_Semmanager.Connection_User

        semprocA_DBWork_Del_TokenOr.Connection = objLocalConfig_Semmanager.Connection_User
        semprocA_DBWork_Save_TokenOr.Connection = objLocalConfig_Semmanager.Connection_User
    End Sub
End Class
