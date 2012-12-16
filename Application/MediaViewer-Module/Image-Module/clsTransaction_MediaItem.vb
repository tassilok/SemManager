Imports Sem_Manager
Imports Filesystem_Management
Public Class clsTransaction_MediaItem
    Private objLocalConfig As clsLocalConfig

    Private procA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private procA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private procA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_INT As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_IntTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_DBWork_Del_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter

    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private objBlobConnection As clsBlobConnection

    Private objSemItem_Ref As clsSemItem
    Private objSemItem_OR As clsSemItem
    Private objSemItem_MediaItem As clsSemItem
    Private objSemItem_File As clsSemItem
    Private intID As Integer

    Public Function save_001_OR_of_Ref(ByVal SemItem_Ref As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Ref = SemItem_Ref

        Select Case objSemItem_Ref.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Attribute.GetData(objSemItem_Ref.GUID).Rows
            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objDRC_LogState = procA_DBWork_Save_OR_RelationType.GetData(objSemItem_Ref.GUID).Rows
            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Token.GetData(objSemItem_Ref.GUID).Rows
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Type.GetData(objSemItem_Ref.GUID).Rows
        End Select

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_OR = New clsSemItem
            objSemItem_OR.GUID = objDRC_LogState(0).Item("GUID_ObjectReference")

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            objSemItem_Result.GUID_Related = objDRC_LogState(0).Item("GUID_objectReference")
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_MediaItem(ByVal SemItem_MediaItem As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_MediaItem = SemItem_MediaItem

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_MediaItem.GUID, _
                                                             objSemItem_MediaItem.Name, _
                                                             objSemItem_MediaItem.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_MediaItem(Optional ByVal SemItem_MediaItem As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_MediaItem Is Nothing Then
            objSemItem_MediaItem = SemItem_MediaItem
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_MediaItem.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function save_004_File(ByVal SemItem_File As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_File = SemItem_File

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_File.GUID, _
                                                             objSemItem_File.Name, _
                                                             objSemItem_File.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_File(Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_File.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_005_Blob(ByVal strPath_File As String) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_File.Additional1 = strPath_File

        objSemItem_Result = objBlobConnection.save_File_To_Blob(objSemItem_File, objSemItem_File.Additional1)

        Return objSemItem_Result
    End Function

    Public Function del_005_Blob(Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objBlobConnection.del_Blob(objSemItem_File)

        Return objSemItem_Result
    End Function

    Public Function save_006_MediaItem_To_File(Optional ByVal SemItem_MediaItem As clsSemItem = Nothing, Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_MediaItem Is Nothing Then
            objSemItem_MediaItem = SemItem_MediaItem

        End If

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_MediaItem.GUID, _
                                                                objSemItem_File.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging_Source.GUID, 0).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function del_006_MediaItem_To_File(Optional ByVal SemItem_MediaItem As clsSemItem = Nothing, Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        If Not SemItem_MediaItem Is Nothing Then
            objSemItem_MediaItem = SemItem_MediaItem

        End If

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MediaItem.GUID, _
                                                               objSemItem_File.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belonging_Source.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result

    End Function

    Public Function save_007_MediaItem_To_OR(ByVal ID As Integer, Optional ByVal SemItem_MediaItem As clsSemItem = Nothing, Optional ByVal SemItem_OR As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_MediaItem Is Nothing Then
            objSemItem_MediaItem = SemItem_MediaItem
        End If

        If Not SemItem_OR Is Nothing Then
            objSemItem_OR = SemItem_OR
        End If

        intID = ID

        objDRC_LogState = semprocA_DBWork_Save_Token_OR.GetData(objSemItem_MediaItem.GUID, _
                                                                objSemItem_OR.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                intID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        Return objSemItem_Result
    End Function

    Public Function del_007_MediaItem_To_OR(Optional ByVal SemItem_MediaItem As clsSemItem = Nothing, Optional ByVal SemItem_OR As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_MediaItem Is Nothing Then
            objSemItem_MediaItem = SemItem_MediaItem
        End If

        If Not SemItem_OR Is Nothing Then
            objSemItem_OR = SemItem_OR
        End If



        objDRC_LogState = semprocA_DBWork_Del_Token_OR.GetData(objSemItem_MediaItem.GUID, _
                                                               objSemItem_OR.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
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
        procA_DBWork_Save_OR_Attribute.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_RelationType.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Type.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_INT.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token_OR.Connection = objLocalConfig.Connection_DB

        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
    End Sub
End Class
