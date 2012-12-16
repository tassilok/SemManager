Imports Sem_Manager
Public Class clsTransactionOutlookConnector
    Private objLocalConfig As clsLocalConfig

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter


    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Datetime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objSemItem_MailItem As clsSemItem
    Private objSemItem_EmailAddress As clsSemItem
    Private objSemItem_TokenAttribute_Sended As clsSemItem
    Private objSemItem_EmailAdr_Von As clsSemItem
    Private objSemItem_EmailAdr_An As clsSemItem
    Private objSemItem_OutlookItem As clsSemItem

    Public ReadOnly Property SemItem_EmailAdr_Von As clsSemItem
        Get
            Return objSemItem_EmailAdr_Von
        End Get
    End Property

    Public ReadOnly Property SemItem_EmailAdr_An As clsSemItem
        Get
            Return objSemItem_EmailAdr_An
        End Get
    End Property

    Public Function save_001_MailItem(ByVal SemItem_MailItem As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_MailItem = SemItem_MailItem

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_MailItem.GUID, _
                                                             objSemItem_MailItem.Name, _
                                                             objSemItem_MailItem.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_MailItem(Optional ByVal SemItem_MailItem As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_MailItem Is Nothing Then
            objSemItem_MailItem = SemItem_MailItem
        End If


        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_MailItem.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID _
            And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_MailItem_To_Sended(ByVal dateCreation As Date, Optional ByVal SemItem_MailItem As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_CreationDate As DataRowCollection
        Dim objDR_CreationDate As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_MailItem Is Nothing Then
            objSemItem_MailItem = SemItem_MailItem
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_CreationDate = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_MailItem.GUID, _
                                                                                                             objLocalConfig.SemItem_Attribute_sended.GUID).Rows
        For Each objDR_CreationDate In objDRC_CreationDate
            If objDR_CreationDate.Item("Val_Datetime") = dateCreation Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                objSemItem_TokenAttribute_Sended = New clsSemItem
                objSemItem_TokenAttribute_Sended.GUID = objDR_CreationDate.Item("GUID_TokenAttribute")
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_CreationDate.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If

            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_MailItem.GUID, _
                                                                                   objLocalConfig.SemItem_Attribute_sended.GUID, _
                                                                                   Nothing, _
                                                                                   dateCreation, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_Sended = New clsSemItem
                objSemItem_TokenAttribute_Sended.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_MailItem_To_Sended(Optional ByVal SemItem_MailItem As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_CreationDate As DataRowCollection
        Dim objDR_CreationDate As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_MailItem Is Nothing Then
            objSemItem_MailItem = SemItem_MailItem
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_CreationDate = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_MailItem.GUID, _
                                                                                                             objLocalConfig.SemItem_Attribute_sended.GUID).Rows
        For Each objDR_CreationDate In objDRC_CreationDate
            
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_CreationDate.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If


        Next

        Return objSemItem_Result
    End Function

    Public Function save_003_EmailAddress(ByVal SemItem_EmailAddress As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_EmailAddress As DataRowCollection

        objSemItem_EmailAddress = SemItem_EmailAddress

        If objSemItem_EmailAddress.Mark = True Then
            objSemItem_EmailAdr_Von = objSemItem_EmailAddress
        Else
            objSemItem_EmailAdr_An = objSemItem_EmailAddress
        End If

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_EmailAddress.GUID, _
                                                             objSemItem_EmailAddress.Name, _
                                                             objSemItem_EmailAddress.GUID_Parent, False).Rows

        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Exists.GUID Then
            objDRC_EmailAddress = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_eMail_Address.GUID, _
                                                                                   objSemItem_EmailAddress.Name).Rows
            If objDRC_EmailAddress.Count > 0 Then
                objSemItem_EmailAddress.GUID = objDRC_EmailAddress(0).Item("GUID_Token")
                If objSemItem_EmailAddress.Mark = True Then
                    objSemItem_EmailAdr_Von.GUID = objDRC_EmailAddress(0).Item("GUID_Token")
                Else
                    objSemItem_EmailAdr_An.GUID = objDRC_EmailAddress(0).Item("GUID_Token")
                End If
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        ElseIf Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_EmailAddress(Optional ByVal SemItem_EmailAddress As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_EmailAddress Is Nothing Then
            objSemItem_EmailAddress = SemItem_EmailAddress
        End If


        If objSemItem_EmailAddress.Mark = True Then
            objSemItem_EmailAdr_Von = objSemItem_EmailAddress
        Else
            objSemItem_EmailAdr_An = objSemItem_EmailAddress
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_EmailAddress.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID _
            And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
            
        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_MailItem_VonAn(Optional ByVal SemItem_EmailAddress As clsSemItem = Nothing, Optional ByVal SemItem_MailItem As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim GUID_RelationType As Guid

        If Not SemItem_EmailAddress Is Nothing Then
            objSemItem_EmailAddress = SemItem_EmailAddress
        End If

        If Not SemItem_MailItem Is Nothing Then
            objSemItem_MailItem = SemItem_MailItem
        End If

        If objSemItem_EmailAddress.Mark = True Then
            objSemItem_EmailAdr_Von = SemItem_EmailAddress
            GUID_RelationType = objLocalConfig.SemItem_RelationType_Von.GUID
        Else
            objSemItem_EmailAdr_An = SemItem_EmailAddress
            GUID_RelationType = objLocalConfig.SemItem_RelationType_An.GUID
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_MailItem.GUID, _
                                                                SemItem_EmailAddress.GUID, _
                                                                GUID_RelationType, 1).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_MailItem_VonAn(Optional ByVal SemItem_EmailAddress As clsSemItem = Nothing, Optional ByVal SemItem_MailItem As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim GUID_RelationType As Guid

        If Not SemItem_MailItem Is Nothing Then
            objSemItem_MailItem = SemItem_MailItem
        End If

        If objSemItem_MailItem.Mark Then
            If Not SemItem_EmailAddress Is Nothing Then
                objSemItem_EmailAdr_Von = SemItem_EmailAddress
            End If

            GUID_RelationType = objLocalConfig.SemItem_RelationType_Von.GUID
        Else
            If Not SemItem_EmailAddress Is Nothing Then
                objSemItem_EmailAdr_An = SemItem_EmailAddress
            End If

            GUID_RelationType = objLocalConfig.SemItem_RelationType_An.GUID
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_MailItem.GUID, _
                                                               SemItem_EmailAddress.GUID, _
                                                               GUID_RelationType).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_005_OutlookItem(ByVal SemItem_OutlookItem As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_OutlookItem As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objSemItem_OutlookItem = SemItem_OutlookItem

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_OutlookItem.GUID, _
                                                             objSemItem_OutlookItem.Name, _
                                                             objSemItem_OutlookItem.GUID_Parent, False).Rows

        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Exists.GUID Then
            objDRC_OutlookItem = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objSemItem_OutlookItem.GUID, _
                                                                                  objSemItem_OutlookItem.Name).Rows
            If objDRC_OutlookItem.Count > 0 Then
                objSemItem_OutlookItem.GUID = objDRC_OutlookItem(0).Item("GUID_Token")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        ElseIf objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success

        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_OutlookItem(Optional ByVal SemItem_OutlookItem As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_OutlookItem Is Nothing Then
            objSemItem_OutlookItem = SemItem_OutlookItem
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_OutlookItem.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID _
            And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error

        End If

        Return objSemItem_Result
    End Function

    Public Function save_006_OutlookItem_To_MailItem(Optional ByVal SemItem_OutlookItem As clsSemItem = Nothing, Optional ByVal SemItem_MailItem As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_OutlookItem As DataRowCollection
        Dim objDR_OutlookItem As DataRow

        If Not SemItem_OutlookItem Is Nothing Then
            objSemItem_OutlookItem = SemItem_OutlookItem
        End If

        If Not SemItem_MailItem Is Nothing Then
            objSemItem_MailItem = SemItem_MailItem
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_OutlookItem = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_OutlookItem.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_is.GUID, _
                                                                           objLocalConfig.SemItem_Type_e_Mail.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_OutlookItem In objDRC_OutlookItem
            If objDR_OutlookItem.Item("GUID_Token_Right") = objSemItem_MailItem.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_OutlookItem.GUID, _
                                                                       objDR_OutlookItem.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_is.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_OutlookItem.GUID, _
                                                                objSemItem_MailItem.GUID, _
                                                                objLocalConfig.SemItem_RelationType_is.GUID, 1).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        

        Return objSemItem_Result

    End Function

    Public Function del_006_OutlookItem_To_MailItem(Optional ByVal SemItem_OutlookItem As clsSemItem = Nothing, Optional ByVal SemItem_MailItem As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_OutlookItem As DataRowCollection
        Dim objDR_OutlookItem As DataRow

        If Not SemItem_OutlookItem Is Nothing Then
            objSemItem_OutlookItem = SemItem_OutlookItem
        End If

        If Not SemItem_MailItem Is Nothing Then
            objSemItem_MailItem = SemItem_MailItem
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_OutlookItem = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_OutlookItem.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_is.GUID, _
                                                                           objLocalConfig.SemItem_Type_e_Mail.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_OutlookItem In objDRC_OutlookItem
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_OutlookItem.GUID, _
                                                                       objDR_OutlookItem.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_is.GUID).Rows
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
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Datetime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
