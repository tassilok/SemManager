Imports Sem_Manager
Public Class clsSecurityModuleWork
    Private objLocalConfig As clsLocalConfig
    Private objDlgAttribute_VARCHAR255 As dlgAttribute_Varchar255
    Private objSecurity As New clsSecurity
    Private strMasterPassword_decoded As String
    Private objFrm As Windows.Forms.IWin32Window
    Private boolUser_Initialized As Boolean

    Private procA_User_By_GUID As New ds_SecurityModuleTableAdapters.proc_User_By_GUIDTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHAR255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter


    Public Function initialize_User(ByVal objSemItem_User As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_User As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim strMasterPassword_Encoded As String
        Dim strPassword As String

        objDRC_User = procA_User_By_GUID.GetData(objLocalConfig.SemItem_Attribute_Master_Password.GUID, _
                                                 objLocalConfig.SemItem_type_User.GUID, _
                                                 objSemItem_User.GUID).Rows
        If objDRC_User.Count > 0 Then
            strMasterPassword_Encoded = objDRC_User(0).Item("MasterPassword")
            objDlgAttribute_VARCHAR255 = New dlgAttribute_Varchar255("New Password", objLocalConfig.Globals)
            objDlgAttribute_VARCHAR255.secure_Val1 = True
            objDlgAttribute_VARCHAR255.ShowDialog(objFrm)
            If objDlgAttribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then
                strPassword = objDlgAttribute_VARCHAR255.Value1
                strMasterPassword_Decoded = objSecurity.decode_String(strMasterPassword_Encoded, strPassword)
                If strPassword = strMasterPassword_Decoded Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    boolUser_Initialized = True
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            End If
        Else

            objDlgAttribute_VARCHAR255 = New dlgAttribute_Varchar255("New Password", objLocalConfig.Globals)
            objDlgAttribute_VARCHAR255.secure_Val1 = True
            objDlgAttribute_VARCHAR255.secure_Val2 = True
            objDlgAttribute_VARCHAR255.ShowDialog(objFrm)
            If objDlgAttribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then
                strMasterPassword_decoded = objDlgAttribute_VARCHAR255.Value1
                strMasterPassword_Encoded = objSecurity.encode_String(objDlgAttribute_VARCHAR255.Value1, strMasterPassword_decoded)
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_User.GUID, _
                                                                                         objLocalConfig.SemItem_Attribute_Master_Password.GUID, _
                                                                                         Nothing, _
                                                                                         strMasterPassword_Encoded, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    boolUser_Initialized = True
                Else

                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If


            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function encode_Password(ByVal strPassword As String) As String
        Dim strPassword_Encoded As String = Nothing
        If boolUser_Initialized = True Then
            strPassword_Encoded = objSecurity.encode_String(strPassword, strMasterPassword_decoded)
        End If


        Return strPassword_Encoded
    End Function

    Public Function decode_Password(ByVal strPassword_Encoded As String) As String
        Dim strPassword_Decoded As String = Nothing
        If boolUser_Initialized = True Then
            strPassword_Decoded = objSecurity.decode_String(strPassword_Encoded, strMasterPassword_decoded)
        End If


        Return strPassword_Decoded
    End Function

    Public Sub New(ByVal objGlobals As clsGlobals, ByVal Frm As Windows.Forms.IWin32Window)
        objLocalConfig = New clsLocalConfig(objGlobals)
        boolUser_Initialized = False
        set_DBConnection()
        objFrm = Frm
    End Sub

    Private Sub set_DBConnection()
        procA_User_By_GUID.Connection = objLocalConfig.Connection_Plugin
        semprocA_DBWork_Save_TokenAttribute_VARCHAR255.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
