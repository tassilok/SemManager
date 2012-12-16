Imports Sem_Manager
Public Class clsTransaction_Resources
    Private objLocalConfig As clsLocalConfig

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_DBWork_Del_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter

    Private semprocA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private semprocA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private semprocA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private semprocA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter

    Private objSemItem_Appointment As clsSemItem
    Private objSemItem_Resource As clsSemItem
    Private objSemItem_OR As clsSemItem

    Public Function save_001_Appointment_To_SimpleResource(ByVal SemItem_Appointment As clsSemItem, ByVal SemItem_Resource As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Appointment = SemItem_Appointment
        objSemItem_Resource = SemItem_Resource

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Appointment.GUID, _
                                                                objSemItem_Resource.GUID, _
                                                                objLocalConfig.SemItem_RelationType_located_at.GUID, _
                                                                0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_Appointment_To_SimpleResource(Optional ByVal SemItem_Appointment As clsSemItem = Nothing, Optional ByVal SemItem_Resource As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Appointment Is Nothing Then
            objSemItem_Appointment = SemItem_Appointment
        End If

        If Not SemItem_Resource Is Nothing Then
            objSemItem_Resource = SemItem_Resource
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Appointment.GUID, _
                                                               objSemItem_Resource.GUID, _
                                                               objLocalConfig.SemItem_RelationType_located_at.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Appointment_To_ORResource(Optional ByVal SemItem_Appointment As clsSemItem = Nothing, Optional ByVal SemItem_Resource As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Appointment Is Nothing Then
            objSemItem_Appointment = SemItem_Appointment
        End If

        If Not SemItem_Resource Is Nothing Then
            objSemItem_Resource = SemItem_Resource
        End If

        Select Case objSemItem_Resource.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_Attribute.GetData(objSemItem_Resource.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_RelationType.GetData(objSemItem_Resource.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_Token.GetData(objSemItem_Resource.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_Type.GetData(objSemItem_Resource.GUID).Rows

        End Select

        objSemItem_OR = Nothing

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            objSemItem_OR = New clsSemItem
            objSemItem_OR.GUID = objDRC_LogState(0).Item("GUID_ObjectReference")
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_Token_OR.GetData(objSemItem_Appointment.GUID, _
                                                                    objSemItem_OR.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Resources.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function del_002_Appointment_To_ORResource(Optional ByVal SemItem_Appointment As clsSemItem = Nothing, Optional ByVal SemItem_Resource As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Appointment Is Nothing Then
            objSemItem_Appointment = SemItem_Appointment
        End If

        If Not SemItem_Resource Is Nothing Then
            objSemItem_Resource = SemItem_Resource
        End If

        Select Case objSemItem_Resource.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_Attribute.GetData(objSemItem_Resource.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_RelationType.GetData(objSemItem_Resource.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_Token.GetData(objSemItem_Resource.GUID).Rows

            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objDRC_LogState = semprocA_DBWork_Save_OR_Type.GetData(objSemItem_Resource.GUID).Rows

        End Select

        objSemItem_OR = Nothing

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            objSemItem_OR = New clsSemItem
            objSemItem_OR.GUID = objDRC_LogState(0).Item("GUID_ObjectReference")
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objDRC_LogState = semprocA_DBWork_Del_Token_OR.GetData(objSemItem_Appointment.GUID, _
                                                                    objSemItem_OR.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Resources.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token_OR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_OR_Attribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_OR_RelationType.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_OR_Type.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
