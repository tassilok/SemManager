Imports Sem_Manager
Public Class clsTransaction_Availability
    Private objLocalConfig As clsLocalConfig

    Private procA_related_Availabilities_ByGUID_AvailabilityData As New ds_AddressTableAdapters.proc_related_Availabilities_ByGUID_AvailabilityDataTableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Datetime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objSemItem_Partner As clsSemItem
    Private objSemItem_AvailabilityData As clsSemItem
    Private objSemItem_Availability As clsSemItem
    Private objSemItem_WeekDay As clsSemItem
    Private date_To As Date
    Private date_From As Date
    Private boolByArrangement As Boolean
    Private objSemItem_TokenAttribute_From As clsSemItem
    Private objSemItem_TokenAttribute_To As clsSemItem
    Private objSemItem_TokenAttribute_ByArrangement As clsSemItem

    Public ReadOnly Property SemItem_AvailabilityData As clsSemItem
        Get
            Return objSemItem_AvailabilityData
        End Get
    End Property

    Public Function exists_001_Availability(ByVal SemItem_WeekDay As clsSemItem, ByVal date_From As Date, ByVal date_To As Date, Optional ByVal SemItem_AvailabilityData As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_Availability As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objSemItem_WeekDay = SemItem_WeekDay
        Me.date_From = date_From
        Me.date_To = date_To

        If Not SemItem_AvailabilityData Is Nothing Then
            objSemItem_AvailabilityData = SemItem_AvailabilityData
        End If

        objDRC_Availability = procA_related_Availabilities_ByGUID_AvailabilityData.GetData(objLocalConfig.SemItem_Attribute_Timestamp__To_.GUID, _
                                                                                           objLocalConfig.SemItem_Attribute_Timestamp__from_.GUID, _
                                                                                           objLocalConfig.SemItem_Type_Availabilities.GUID, _
                                                                                           objLocalConfig.SemItem_Type_Weekdays.GUID, _
                                                                                           objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                                           objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                           objLocalConfig.SemItem_RelationType_needs.GUID, _
                                                                                           objLocalConfig.SemItem_Type_Availability_Data.GUID, _
                                                                                           objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                                           objSemItem_WeekDay.GUID, _
                                                                                           date_From, _
                                                                                           date_To).Rows
        If objDRC_Availability.Count = 0 Then
            objSemItem_TokenAttribute_From = Nothing
            objSemItem_TokenAttribute_To = Nothing
            objSemItem_Availability = Nothing
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        Else
            objSemItem_TokenAttribute_To = New clsSemItem
            objSemItem_TokenAttribute_To.GUID = objDRC_Availability(0).Item("GUID_TokenAttribute_To")
            objSemItem_TokenAttribute_From = New clsSemItem
            objSemItem_TokenAttribute_From.GUID = objDRC_Availability(0).Item("GUID_TokenAttribute_From")

            objSemItem_Availability = New clsSemItem
            objSemItem_Availability.GUID = objDRC_Availability(0).Item("GUID_Availabilities")
            objSemItem_Availability.Name = objDRC_Availability(0).Item("Name_Availabilities")
            objSemItem_Availability.GUID_Parent = objLocalConfig.SemItem_Type_Availabilities.GUID
            objSemItem_Availability.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objLocalConfig.Globals.LogState_Exists
        End If

        Return objSemItem_Result
    End Function



    Public Function save_001_AvailabilityData(ByVal SemItem_AvailabilityData As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_AvailabilityData As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objSemItem_AvailabilityData = SemItem_AvailabilityData

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_AvailabilityData.GUID, _
                                                             objSemItem_AvailabilityData.Name, _
                                                             objSemItem_AvailabilityData.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_AvailabilityData(Optional ByVal SemItem_AvailabilityData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Partner As DataRowCollection
        Dim objDR_Partner As DataRow

        
        If Not SemItem_AvailabilityData Is Nothing Then
            objSemItem_AvailabilityData = SemItem_AvailabilityData
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_AvailabilityData.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function save_001a_AvailabilityData_To_Partner(ByVal SemItem_Partner As clsSemItem, Optional ByVal SemItem_AvailabilityData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Partner = SemItem_Partner

        If Not SemItem_AvailabilityData Is Nothing Then
            objSemItem_AvailabilityData = SemItem_AvailabilityData
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_AvailabilityData.GUID, _
                                                                objSemItem_Partner.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001a_AvailabilityData_To_Partner(Optional ByVal SemItem_Partner As clsSemItem = Nothing, Optional ByVal SemItem_AvailabilityData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Partner Is Nothing Then
            objSemItem_Partner = SemItem_Partner
        End If

        If Not SemItem_AvailabilityData Is Nothing Then
            objSemItem_AvailabilityData = SemItem_AvailabilityData
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_AvailabilityData.GUID, _
                                                               objSemItem_Partner.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function


    Public Function save_002_Availability__ByArrangement(ByVal boolByArrangement As Boolean, Optional ByVal SemItem_AvailabilityData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ByArrangement As DataRowCollection

        If Not SemItem_AvailabilityData Is Nothing Then
            objSemItem_AvailabilityData = SemItem_AvailabilityData
        End If

        Me.boolByArrangement = boolByArrangement

        objDRC_ByArrangement = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_AvailabilityData.GUID, _
                                                                                                              objLocalConfig.SemItem_Attribute_Nach_Vereinbarung.GUID).Rows
        If objDRC_ByArrangement.Count > 0 Then
            objSemItem_TokenAttribute_ByArrangement = New clsSemItem
            objSemItem_TokenAttribute_ByArrangement.GUID = objDRC_ByArrangement(0).Item("GUID_TokenAttribute")
            If objDRC_ByArrangement(0).Item("Val_Bool") = boolByArrangement Then

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else

                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_AvailabilityData.GUID, _
                                                                                  objLocalConfig.SemItem_Attribute_Nach_Vereinbarung.GUID, _
                                                                                  objSemItem_TokenAttribute_ByArrangement.GUID, _
                                                                                  boolByArrangement, _
                                                                                  1).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_AvailabilityData.GUID, _
                                                                              objLocalConfig.SemItem_Attribute_Nach_Vereinbarung.GUID, _
                                                                              Nothing, _
                                                                              boolByArrangement, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_ByArrangement = New clsSemItem
                objSemItem_TokenAttribute_ByArrangement.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        End If


        Return objSemItem_Result
    End Function

    Public Function del_002_AvailabilityData__ByArrangement(Optional ByVal SemItem_AvailabilityData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ByArrangement As DataRowCollection
        Dim objDR_ByArrangement As DataRow

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If Not SemItem_AvailabilityData Is Nothing Then
            objSemItem_AvailabilityData = SemItem_AvailabilityData
        End If

        objDRC_ByArrangement = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_AvailabilityData.GUID, _
                                                                                                              objLocalConfig.SemItem_Attribute_Nach_Vereinbarung.GUID).Rows
        For Each objDR_ByArrangement In objDRC_ByArrangement
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_ByArrangement.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_003_Availability(Optional ByVal SemItem_Availability As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Availability Is Nothing Then
            objSemItem_Availability = SemItem_Availability
        End If

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Availability.GUID, _
                                                             objSemItem_Availability.Name, _
                                                             objSemItem_Availability.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_Availability(Optional ByVal SemItem_Availability As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Availability Is Nothing Then
            objSemItem_Availability = SemItem_Availability
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Availability.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        Return objSemItem_Result
    End Function

    Public Function save_004_AvailabiltyData_To_Availability(Optional ByVal SemItem_Availability As clsSemItem = Nothing, Optional ByVal SemItem_AvailabilityData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Availability Is Nothing Then
            objSemItem_Availability = SemItem_Availability
        End If

        If Not SemItem_AvailabilityData Is Nothing Then
            objSemItem_AvailabilityData = SemItem_AvailabilityData
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_AvailabilityData.GUID, _
                                                               objSemItem_Availability.GUID, _
                                                               objLocalConfig.SemItem_RelationType_contains.GUID, 1).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_AvailabilityData_To_Availability(Optional ByVal SemItem_Availability As clsSemItem = Nothing, Optional ByVal SemItem_AvailabilityData As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Availability Is Nothing Then
            objSemItem_Availability = SemItem_Availability
        End If

        If Not SemItem_AvailabilityData Is Nothing Then
            objSemItem_AvailabilityData = SemItem_AvailabilityData
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_AvailabilityData.GUID, _
                                                               objSemItem_Availability.GUID, _
                                                               objLocalConfig.SemItem_RelationType_contains.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_005_Availability__From(ByVal date_From As Date, Optional ByVal SemItem_Availability As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_From As DataRowCollection
        Dim objDR_From As DataRow

        If Not SemItem_Availability Is Nothing Then
            objSemItem_Availability = SemItem_Availability
        End If

        objDRC_From = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Availability.GUID, _
                                                                                                     objLocalConfig.SemItem_Attribute_Timestamp__from_.GUID).Rows

        If objDRC_From.Count > 0 Then
            objSemItem_TokenAttribute_From = New clsSemItem
            objSemItem_TokenAttribute_From.GUID = objDRC_From(0).Item("GUID_TokenAttribute_From")
            If Not objDRC_From(0).Item("From") = date_From Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Availability.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Timestamp__from_.GUID, _
                                                                                       objSemItem_TokenAttribute_From.GUID, _
                                                                                       date_From, 1).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            End If
        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Availability.GUID, _
                                                                                   objLocalConfig.SemItem_Attribute_Timestamp__from_.GUID, _
                                                                                   Nothing, _
                                                                                   date_From, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_From = New clsSemItem
                objSemItem_TokenAttribute_From.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_Availability__From(Optional ByVal SemItem_Availability As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_From As DataRowCollection
        Dim objDR_From As DataRow

        If Not SemItem_Availability Is Nothing Then
            objSemItem_Availability = SemItem_Availability
        End If

        objDRC_From = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Availability.GUID, _
                                                                                                     objLocalConfig.SemItem_Attribute_Timestamp__from_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_From In objDRC_From
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_From.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function


    Public Function save_006_Availability__To(ByVal date_To As Date, Optional ByVal SemItem_Availability As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_To As DataRowCollection
        Dim objDR_To As DataRow

        If Not SemItem_Availability Is Nothing Then
            objSemItem_Availability = SemItem_Availability
        End If

        objDRC_To = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Availability.GUID, _
                                                                                                     objLocalConfig.SemItem_Attribute_Timestamp__To_.GUID).Rows

        If objDRC_To.Count > 0 Then
            objSemItem_TokenAttribute_To = New clsSemItem
            objSemItem_TokenAttribute_To.GUID = objDRC_To(0).Item("GUID_TokenAttribute_To")
            If Not objDRC_To(0).Item("To") = date_To Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Availability.GUID, _
                                                                                       objLocalConfig.SemItem_Attribute_Timestamp__To_.GUID, _
                                                                                       objSemItem_TokenAttribute_To.GUID, _
                                                                                       date_To, 1).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            End If
        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Availability.GUID, _
                                                                                   objLocalConfig.SemItem_Attribute_Timestamp__To_.GUID, _
                                                                                   Nothing, _
                                                                                   date_To, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_To = New clsSemItem
                objSemItem_TokenAttribute_To.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_006_Availability__To(Optional ByVal SemItem_Availability As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_To As DataRowCollection
        Dim objDR_To As DataRow

        If Not SemItem_Availability Is Nothing Then
            objSemItem_Availability = SemItem_Availability
        End If

        objDRC_To = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Availability.GUID, _
                                                                                                     objLocalConfig.SemItem_Attribute_Timestamp__To_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_To In objDRC_To
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_To.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_007_Availability_To_Weekday(Optional ByVal SemItem_Weekday As clsSemItem = Nothing, Optional ByVal SemItem_Availability As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        Dim objDRC_WeekDays As DataRowCollection
        Dim objDR_WeekDay As DataRow

        If Not SemItem_Availability Is Nothing Then
            objSemItem_Availability = SemItem_Availability
        End If

        If Not SemItem_Weekday Is Nothing Then
            objSemItem_WeekDay = SemItem_Weekday
        End If

        objDRC_WeekDays = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Availability.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                        objLocalConfig.SemItem_Type_Weekdays.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_WeekDay In objDRC_WeekDays
            If objDR_WeekDay.Item("GUID_Token_Right") = objSemItem_WeekDay.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Availability.GUID, _
                                                                       objSemItem_WeekDay.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_belonging.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Availability.GUID, _
                                                                    objSemItem_WeekDay.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_007_Availability_To_WeekDay(Optional ByVal SemItem_Availability As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        Dim objDRC_WeekDays As DataRowCollection
        Dim objDR_WeekDay As DataRow

        If Not SemItem_Availability Is Nothing Then
            objSemItem_Availability = SemItem_Availability
        End If

        objDRC_WeekDays = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Availability.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                        objLocalConfig.SemItem_Type_Weekdays.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_WeekDay In objDRC_WeekDays
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Availability.GUID, _
                                                                   objDR_WeekDay.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belonging.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        procA_related_Availabilities_ByGUID_AvailabilityData.Connection = objLocalConfig.Connection_Plugin
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Datetime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
