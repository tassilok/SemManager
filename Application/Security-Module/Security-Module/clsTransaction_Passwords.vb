Imports Sem_Manager
Public Class clsTransaction_Passwords
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private semtblA_TokenToken As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter

    Private objLocalConfig As clsLocalConfig

    Private objSemItem_Password As clsSemItem
    Private objSemItem_User As clsSemItem
    Private objSemItem_Secured As clsSemItem

    Public Function save_001_Password(ByVal SemItem_Password As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Password = SemItem_Password

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Password.GUID, _
                                                             objSemItem_Password.Name, _
                                                             objSemItem_Password.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_Password(Optional ByVal SemItem_Password As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If Not SemItem_Password Is Nothing Then
            objSemItem_Password = SemItem_Password
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Password.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Password_To_User(ByVal SemItem_User As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_User = SemItem_User

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Password.GUID, _
                                                                objSemItem_User.GUID, _
                                                                objLocalConfig.SemItem_RelationType_encoded_by.GUID, _
                                                                0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_Password_To_User(Optional ByVal SemItem_User As clsSemItem = Nothing, Optional ByVal SemItem_Password As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Passwords As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_Password As DataRow

        If Not SemItem_User Is Nothing Then
            objSemItem_User = SemItem_User
        End If

        If Not SemItem_Password Is Nothing Then
            objSemItem_Password = SemItem_Password
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_Passwords = semtblA_TokenToken.GetData_By_GUIDs(objSemItem_Password.GUID, objSemItem_User.GUID, objLocalConfig.SemItem_RelationType_encoded_by.GUID).Rows

        For Each objDR_Password In objDRC_Passwords
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDR_Password.Item("GUID_Token_Left"), objDR_Password.Item("GUID_Token_Right"), objLocalConfig.SemItem_RelationType_encoded_by.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_003_Password_To_Secured(ByVal SemItem_Secured As clsSemItem, Optional ByVal SemItem_Password As clsSemItem = Nothing)
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Secured = SemItem_Secured

        If Not SemItem_Password Is Nothing Then
            objSemItem_Password = SemItem_Password

        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Secured.GUID, objSemItem_Password.GUID, objLocalConfig.SemItem_RelationType_secured_by.GUID, 1).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_Password_To_Secured(Optional ByVal SemItem_Secured As clsSemItem = Nothing, Optional ByVal SemItem_Password As clsSemItem = Nothing)
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Secured Is Nothing Then
            objSemItem_Secured = SemItem_Secured
        End If


        If Not SemItem_Password Is Nothing Then
            objSemItem_Password = SemItem_Password

        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Secured.GUID, objSemItem_Password.GUID, objLocalConfig.SemItem_RelationType_secured_by.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function



    Private Sub set_DBConnection()
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        semtblA_TokenToken.Connection = objLocalConfig.Connection_DB
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub
End Class
