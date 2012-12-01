Imports Sem_Manager
Public Class clsTransaction_DBSchemForApplications

    Private objLocalConfig As clsLocalConfig

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter


    Private objSemItem_DBSchemaOfApplication As clsSemItem
    Private objSemItem_DBOnServer As clsSemItem
    Private objSemItem_DBSchema As clsSemItem
    Private objSemItem_DBSchemaType As clsSemItem
    Private objSemItem_File As clsSemItem
    Private objSemItem_Development As clsSemItem

    Public Function save_001_DBSchemaOfApplication(ByVal SemItem_DBSchemaOfApplication As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_DBSchemaOfApplication = SemItem_DBSchemaOfApplication

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DBSchemaOfApplication.GUID, _
                                                             objSemItem_DBSchemaOfApplication.Name, _
                                                             objSemItem_DBSchemaOfApplication.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_DBSchemaOfApplication(Optional ByVal SemItem_DBSchemaOfApplication As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_DBSchemaOfApplication Is Nothing Then
            objSemItem_DBSchemaOfApplication = SemItem_DBSchemaOfApplication
        End If


        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_DBSchemaOfApplication.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_DBSchemaOfApplication_To_DBOnServer(ByVal SemItem_DBOnServer As clsSemItem, Optional ByVal SemItem_DBSchemaOfApplication As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_DBOnServer = SemItem_DBOnServer

        If Not SemItem_DBSchemaOfApplication Is Nothing Then
            objSemItem_DBSchemaOfApplication = SemItem_DBSchemaOfApplication
        End If


        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBSchemaOfApplication.GUID, _
                                                                objSemItem_DBOnServer.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_DBSchemaOfApplication_To_DBOnServer(Optional ByVal SemItem_DBOnServer As clsSemItem = Nothing, Optional ByVal SemItem_DBSchemaOfApplication As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_DBOnServer Is Nothing Then
            objSemItem_DBOnServer = SemItem_DBOnServer
        End If

        If Not SemItem_DBSchemaOfApplication Is Nothing Then
            objSemItem_DBSchemaOfApplication = SemItem_DBSchemaOfApplication
        End If


        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBSchemaOfApplication.GUID, _
                                                               objSemItem_DBOnServer.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function

    Public Function save_003_DBSchemaOfApplication_To_DBSchema(ByVal SemItem_DBSchema As clsSemItem, Optional ByVal SemItem_DBSchemaOfApplication As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_DBSchema = SemItem_DBSchema

        If Not SemItem_DBSchemaOfApplication Is Nothing Then
            objSemItem_DBSchemaOfApplication = SemItem_DBSchemaOfApplication
        End If


        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBSchemaOfApplication.GUID, _
                                                                objSemItem_DBSchema.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_DBSchemaOfApplication_To_DBSchema(Optional ByVal SemItem_DBSchema As clsSemItem = Nothing, Optional ByVal SemItem_DBSchemaOfApplication As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_DBSchema Is Nothing Then
            objSemItem_DBSchema = SemItem_DBSchema
        End If

        If Not SemItem_DBSchemaOfApplication Is Nothing Then
            objSemItem_DBSchemaOfApplication = SemItem_DBSchemaOfApplication
        End If


        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBSchemaOfApplication.GUID, _
                                                               objSemItem_DBSchema.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_DBSchemaOfApplication_To_DBSchemaType(ByVal SemItem_DBSchemaType As clsSemItem, Optional ByVal SemItem_DBSchemaOfApplication As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_DBSchemaType = SemItem_DBSchemaType

        If Not SemItem_DBSchemaOfApplication Is Nothing Then
            objSemItem_DBSchemaOfApplication = SemItem_DBSchemaOfApplication
        End If


        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBSchemaOfApplication.GUID, _
                                                                objSemItem_DBSchemaType.GUID, _
                                                                objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 0).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_DBSchemaOfApplication_To_DBSchemaType(Optional ByVal SemItem_DBSchemaType As clsSemItem = Nothing, Optional ByVal SemItem_DBSchemaOfApplication As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_DBSchemaType Is Nothing Then
            objSemItem_DBSchemaType = SemItem_DBSchemaType
        End If

        If Not SemItem_DBSchemaOfApplication Is Nothing Then
            objSemItem_DBSchemaOfApplication = SemItem_DBSchemaOfApplication
        End If


        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBSchemaOfApplication.GUID, _
                                                               objSemItem_DBSchemaType.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function

    Public Function save_005_DBSchemaOfApplication_To_File(ByVal SemItem_File As clsSemItem, Optional ByVal SemItem_DBSchemaOfApplication As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_File = SemItem_File

        If Not SemItem_DBSchemaOfApplication Is Nothing Then
            objSemItem_DBSchemaOfApplication = SemItem_DBSchemaOfApplication
        End If


        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBSchemaOfApplication.GUID, _
                                                                objSemItem_File.GUID, _
                                                                objLocalConfig.SemItem_RelationType_export_to.GUID, 0).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_DBSchemaOfApplication_To_File(Optional ByVal SemItem_File As clsSemItem = Nothing, Optional ByVal SemItem_DBSchemaOfApplication As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        If Not SemItem_DBSchemaOfApplication Is Nothing Then
            objSemItem_DBSchemaOfApplication = SemItem_DBSchemaOfApplication
        End If


        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBSchemaOfApplication.GUID, _
                                                               objSemItem_File.GUID, _
                                                               objLocalConfig.SemItem_RelationType_export_to.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function

    Public Function save_006_DBSchemaOfApplication_To_Development(ByVal SemItem_Development As clsSemItem, Optional ByVal SemItem_DBSchemaOfApplication As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Development = SemItem_Development

        If Not SemItem_DBSchemaOfApplication Is Nothing Then
            objSemItem_DBSchemaOfApplication = SemItem_DBSchemaOfApplication
        End If


        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBSchemaOfApplication.GUID, _
                                                                objSemItem_Development.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_006_DBSchemaOfApplication_To_DBSchemaType(Optional ByVal SemItem_Development As clsSemItem = Nothing, Optional ByVal SemItem_DBSchemaOfApplication As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Development Is Nothing Then
            objSemItem_Development = SemItem_Development
        End If

        If Not SemItem_DBSchemaOfApplication Is Nothing Then
            objSemItem_DBSchemaOfApplication = SemItem_DBSchemaOfApplication
        End If


        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBSchemaOfApplication.GUID, _
                                                               objSemItem_Development.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function



    Private Sub set_DBConnection()
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
    End Sub
End Class
