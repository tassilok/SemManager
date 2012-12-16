Imports Sem_Manager
Public Class clsTransaction_Scene

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private objLocalConfig As clsLocalConfig

    Private objSemItem_Scene As clsSemItem
    Private objSemItem_Chapter As clsSemItem

    Public Function save_001_Scene(ByVal SemItem_Scene As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Scene = SemItem_Scene

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Scene.GUID, _
                                                             objSemItem_Scene.Name, _
                                                             objSemItem_Scene.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_Scene(Optional ByVal SemItem_Scene As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Scene Is Nothing Then
            objSemItem_Scene = SemItem_Scene
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Scene.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID _
            And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Chapter_To_Scene(ByVal SemItem_Chapter As clsSemItem, Optional ByVal SemItem_Scene As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Chapter = SemItem_Chapter

        If Not SemItem_Scene Is Nothing Then
            objSemItem_Scene = SemItem_Scene
        End If
        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Chapter.GUID, _
                                                                objSemItem_Scene.GUID, _
                                                                objLocalConfig.SemItem_RelationType_contains.GUID, objSemItem_Scene.Level).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_Chapter_To_Scene(Optional ByVal SemItem_Chapter As clsSemItem = Nothing, Optional ByVal SemItem_Scene As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Chapter Is Nothing Then
            objSemItem_Chapter = SemItem_Chapter
        End If

        If Not SemItem_Scene Is Nothing Then
            objSemItem_Scene = SemItem_Scene
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Chapter.GUID, _
                                                               objSemItem_Scene.GUID, _
                                                               objLocalConfig.SemItem_RelationType_contains.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID _
            And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then

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
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
