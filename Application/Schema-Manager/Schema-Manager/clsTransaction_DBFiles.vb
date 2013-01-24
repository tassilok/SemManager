Imports Sem_Manager
Imports Filesystem_Management
Public Class clsTransaction_DBFiles
    Dim objLocalConfig As clsLocalConfig

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private objSemItem_File As clsSemItem
    Private objSemItem_Ref As clsSemItem
    Private objSemItem_Type As clsSemItem
    Private objSemItem_Version As clsSemItem
    Private objSemItem_DBSchemaOfApplication As clsSemItem

    Private objBlobConnection As clsBlobConnection

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

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID _
            And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result

    End Function
    Public Function save_002_File(ByVal SemItem_File As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_File = SemItem_File

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_File.GUID, _
                                                             objSemItem_File.Name, _
                                                             objSemItem_File.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objBlobConnection.save_File_To_Blob(objSemItem_File, objSemItem_File.Additional1)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                semprocA_DBWork_Del_Token.GetData(objSemItem_File.GUID)
            ElseIf objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Relation.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                objSemItem_File.GUID = objSemItem_Result.GUID_Related
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_File(Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If


        objBlobConnection.del_Blob(objSemItem_File)

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_File.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID _
            And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_003_Ref_To_File(ByVal SemItem_Ref As clsSemItem, ByVal SemItem_Type As clsSemItem, Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim intOrderID As Integer
        Dim GUID_RelationType As Guid


        'objSemItem_DBOnServer = SemItem_DBOnServer Then
        objSemItem_Ref = SemItem_Ref

        objSemItem_Type = SemItem_Type

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        If objSemItem_Type.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID Then
            GUID_RelationType = objSemItem_Type.GUID
        Else
            Select Case objSemItem_Type.GUID
                Case objLocalConfig.SemItem_Token_DB_Schema_Type_Change.GUID
                    GUID_RelationType = objLocalConfig.SemItem_RelationType_Change.GUID
                Case objLocalConfig.SemItem_Token_DB_Schema_Type_Config.GUID
                    GUID_RelationType = objLocalConfig.SemItem_RelationType_Config.GUID
                Case objLocalConfig.SemItem_Token_DB_Schema_Type_User.GUID
                    GUID_RelationType = objLocalConfig.SemItem_RelationType_User.GUID
                Case objLocalConfig.SemItem_Token_DB_Schema_Type_Module.GUID
                    GUID_RelationType = objLocalConfig.SemItem_RelationType_Module.GUID
            End Select
        End If


        intOrderID = funcA_Token_Token.LeftRight_Max_OrderID_By_GUIDs(objSemItem_Ref.GUID, _
                                                                      objLocalConfig.SemItem_Type_File.GUID, _
                                                                      GUID_RelationType)
        intOrderID = intOrderID + 1

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ref.GUID, _
                                                                objSemItem_File.GUID, _
                                                                GUID_RelationType, intOrderID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_Ref_To_File(Optional ByVal SemItem_Ref As clsSemItem = Nothing, Optional ByVal SemItem_Type As clsSemItem = Nothing, Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim GUID_RelationType As Guid
        Dim objDRC_LogState As DataRowCollection

        If Not objSemItem_Ref Is Nothing Then
            objSemItem_Ref = objSemItem_Ref
        End If

        If Not SemItem_Type Is Nothing Then
            objSemItem_Type = SemItem_Type
        End If


        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        If objSemItem_Type.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID Then
            GUID_RelationType = objSemItem_Type.GUID
        Else
            Select Case objSemItem_Type.GUID
                Case objLocalConfig.SemItem_Token_DB_Schema_Type_Change.GUID
                    GUID_RelationType = objLocalConfig.SemItem_RelationType_Change.GUID
                Case objLocalConfig.SemItem_Token_DB_Schema_Type_Config.GUID
                    GUID_RelationType = objLocalConfig.SemItem_RelationType_Config.GUID
                Case objLocalConfig.SemItem_Token_DB_Schema_Type_User.GUID
                    GUID_RelationType = objLocalConfig.SemItem_RelationType_User.GUID
                Case objLocalConfig.SemItem_Token_DB_Schema_Type_Module.GUID
                    GUID_RelationType = objLocalConfig.SemItem_RelationType_Module.GUID
            End Select
        End If


        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ref.GUID, _
                                                               objSemItem_File.GUID, _
                                                               GUID_RelationType).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_File_To_Version(ByVal SemItem_Version As clsSemItem, Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Version = SemItem_Version

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_File.GUID, _
                                                                objSemItem_Version.GUID, _
                                                                objLocalConfig.SemItem_RelationType_isInState.GUID, 1).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_File_To_Version(Optional ByVal SemItem_Version As clsSemItem = Nothing, Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Version Is Nothing Then
            objSemItem_Version = SemItem_Version
        End If


        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_File.GUID, _
                                                                objSemItem_Version.GUID, _
                                                                objLocalConfig.SemItem_RelationType_isInState.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Private Sub set_DBConnection()
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB

        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub
End Class
