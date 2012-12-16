Imports Sem_Manager
Public Class clsTransaction_LiteraturQuelle
    Private objLocalConfig As clsLocalConfig
    Private objConnection As SqlClient.SqlConnection

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private objSemItem_LiteraturQuelle As clsSemItem

    Public Function save_001_LiteraturQuelle(ByVal SemItem_LiteraturQuelle As clsSemItem) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objSemItem_LiteraturQuelle = SemItem_LiteraturQuelle

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_LiteraturQuelle.GUID, _
                                                             objSemItem_LiteraturQuelle.Name, _
                                                             objSemItem_LiteraturQuelle.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_LiteraturQuelle(Optional ByVal SemItem_LiteraturQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        If Not SemItem_LiteraturQuelle Is Nothing Then
            objSemItem_LiteraturQuelle = SemItem_LiteraturQuelle
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_LiteraturQuelle.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

  

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objConnection = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)

        semprocA_DBWork_Save_Token.Connection = objConnection
        semprocA_DBWork_Del_Token.Connection = objConnection

        semprocA_DBWork_Save_TokenRel.Connection = objConnection
        semprocA_DBWork_Del_TokenRel.Connection = objConnection
    End Sub
End Class
