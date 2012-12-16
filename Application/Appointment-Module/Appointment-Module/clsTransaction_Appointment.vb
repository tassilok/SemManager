Imports Sem_Manager
Public Class clsTransaction_Appointment
    Private objLocalConfig As clsLocalConfig

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Datetime As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Datetime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objSemItem_Appointment As clsSemItem
    Private objSemItem_User As clsSemItem
    Private objSemItem_Partner As clsSemItem

    Private objSemItem_TokenAttribute_Start As clsSemItem
    Private objSemItem_TokenAttribute_End As clsSemItem

    Public Function save_001_Appointment(ByVal SemItem_Appointment As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Appointment = SemItem_Appointment

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Appointment.GUID, _
                                                             objSemItem_Appointment.Name, _
                                                             objSemItem_Appointment.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function del_001_Appointment(Optional ByVal SemItem_Appointment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Appointment Is Nothing Then
            objSemItem_Appointment = SemItem_Appointment
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Appointment.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result

    End Function

    Public Function save_002_Appointment_To_User(ByVal SemItem_User As clsSemItem, Optional ByVal replaceUser As Boolean = False, Optional ByVal SemItem_Appointment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_User As DataRowCollection
        Dim objDR_User As DataRow

        objSemItem_User = SemItem_User

        If Not SemItem_Appointment Is Nothing Then
            objSemItem_Appointment = SemItem_Appointment
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        If replaceUser = True Then
            objDRC_User = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Appointment.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                        objLocalConfig.SemItem_type_User.GUID).Rows
            For Each objDR_User In objDRC_User
                If objDR_User.Item("GUID_Token_Right") = objSemItem_User.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Appointment.GUID, _
                                                                           objDR_User.Item("GUID_Token_Right"), _
                                                                           objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                End If
            Next
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Appointment.GUID, _
                                                                objSemItem_User.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        

        Return objSemItem_Result
    End Function

    Public Function del_002_Appointment_To_User(Optional ByVal allUsers As Boolean = False, Optional ByVal SemItem_User As clsSemItem = Nothing, Optional ByVal SemItem_Appointment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Users As DataRowCollection
        Dim objDR_User As DataRow

        If Not SemItem_User Is Nothing Then
            objSemItem_User = SemItem_User
        End If

        If Not SemItem_Appointment Is Nothing Then
            objSemItem_Appointment = SemItem_Appointment
        End If

        If allUsers = True Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            objDRC_Users = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Appointment.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                         objLocalConfig.SemItem_type_User.GUID).Rows
            For Each objDR_User In objDRC_Users
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Appointment.GUID, _
                                                                       objDR_User.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        Else
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Appointment.GUID, _
                                                                   objSemItem_User.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_003_Appointment__Start(ByVal dateStart As Date, Optional ByVal SemItem_Appointment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Start As DataRowCollection
        Dim objDR_Start As DataRow


        If Not SemItem_Appointment Is Nothing Then
            objSemItem_Appointment = SemItem_Appointment
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_Start = funcA_TokenAttribute_Datetime.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Appointment.GUID, _
                                                                                            objLocalConfig.SemItem_Attribute_Start.GUID).Rows
        For Each objDR_Start In objDRC_Start
            If objDR_Start.Item("Val_Datetime") = dateStart Then
                objSemItem_TokenAttribute_Start = New clsSemItem
                objSemItem_TokenAttribute_Start.GUID = objDR_Start.Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Start.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Appointment.GUID, _
                                                                                   objLocalConfig.SemItem_Attribute_Start.GUID, _
                                                                                   Nothing, _
                                                                                   dateStart, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_Start = New clsSemItem
                objSemItem_TokenAttribute_Start.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_Appointment__Start(Optional ByVal SemItem_Appointment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Start As DataRowCollection
        Dim objDR_Start As DataRow


        If Not SemItem_Appointment Is Nothing Then
            objSemItem_Appointment = SemItem_Appointment
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_Start = funcA_TokenAttribute_Datetime.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Appointment.GUID, _
                                                                                            objLocalConfig.SemItem_Attribute_Start.GUID).Rows
        For Each objDR_Start In objDRC_Start
            
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Start.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_004_Appointment__End(ByVal dateEnd As Date, Optional ByVal SemItem_Appointment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_End As DataRowCollection
        Dim objDR_End As DataRow


        If Not SemItem_Appointment Is Nothing Then
            objSemItem_Appointment = SemItem_Appointment
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_End = funcA_TokenAttribute_Datetime.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Appointment.GUID, _
                                                                                            objLocalConfig.SemItem_Attribute_Ende.GUID).Rows
        For Each objDR_End In objDRC_End
            If objDR_End.Item("Val_Datetime") = dateEnd Then
                objSemItem_TokenAttribute_Start = New clsSemItem
                objSemItem_TokenAttribute_Start.GUID = objDR_End.Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_End.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Appointment.GUID, _
                                                                                   objLocalConfig.SemItem_Attribute_Ende.GUID, _
                                                                                   Nothing, _
                                                                                   dateEnd, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_Start = New clsSemItem
                objSemItem_TokenAttribute_Start.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_Appointment__Start(Optional ByVal SemItem_Appointment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_End As DataRowCollection
        Dim objDR_End As DataRow


        If Not SemItem_Appointment Is Nothing Then
            objSemItem_Appointment = SemItem_Appointment
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_End = funcA_TokenAttribute_Datetime.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Appointment.GUID, _
                                                                                            objLocalConfig.SemItem_Attribute_Ende.GUID).Rows
        For Each objDR_End In objDRC_End

            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_End.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_005_Appointment_To_Partner(ByVal SemItem_Partner As clsSemItem, Optional ByVal SemItem_Appointment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Partner = SemItem_Partner
        If Not SemItem_Appointment Is Nothing Then
            objSemItem_Appointment = SemItem_Appointment
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Appointment.GUID, _
                                                                objSemItem_Partner.GUID, _
                                                                objSemItem_Partner.GUID_Relation, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_Appointment_To_Partner(Optional ByVal SemItem_Partner As clsSemItem = Nothing, Optional ByVal SemItem_Appointment As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Appointment Is Nothing Then
            objSemItem_Appointment = SemItem_Appointment
        End If

        If Not SemItem_Partner Is Nothing Then
            objSemItem_Partner = SemItem_Partner
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Appointment.GUID, _
                                                               objSemItem_Partner.GUID, _
                                                               objSemItem_Partner.GUID_Relation).Rows

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
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Datetime.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Datetime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
