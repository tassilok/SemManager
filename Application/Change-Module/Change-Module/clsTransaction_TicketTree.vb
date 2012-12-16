Imports Sem_Manager
Public Class clsTransaction_TicketTree
    Private objLocalConfig As clsLocalConfig

    Private funcA_TokenAttribute_Named As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objSemItem_TicketList As clsSemItem
    Private objSemItem_TicketList_Parent As clsSemItem
    Private objSemItem_Group As clsSemItem
    Private objSemItem_TokenAttribute As clsSemItem
    Private objSemItem_Ticket As clsSemItem

    Public Function save_001_TicketList(ByVal SemItem_TicketList As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_TicketList = SemItem_TicketList

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_TicketList.GUID, _
                                                             objSemItem_TicketList.Name, _
                                                             objSemItem_TicketList.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_TicketList(Optional ByVal SemItem_TicketList As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_TicketList Is Nothing Then
            objSemItem_TicketList = SemItem_TicketList
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_TicketList.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_TicketList_To_TicketList(ByVal SemItem_TicketList_Parent As clsSemItem, Optional ByVal SemItem_TicketList As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_TicketList_Parent = SemItem_TicketList_Parent

        If Not SemItem_TicketList Is Nothing Then
            objSemItem_TicketList = SemItem_TicketList
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_TicketList_Parent.GUID, _
                                                                objSemItem_TicketList.GUID, _
                                                                objLocalConfig.SemItem_RelationType_contains.GUID, 1).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_TicketList_To_TicketList(Optional ByVal SemItem_TicketList_Parent As clsSemItem = Nothing, Optional ByVal SemItem_TicketList As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_TicketLists As DataRowCollection
        Dim objDR_TicketList As DataRow

        If Not SemItem_TicketList_Parent Is Nothing Then
            objSemItem_TicketList_Parent = SemItem_TicketList_Parent
        End If

        If Not SemItem_TicketList Is Nothing Then
            objSemItem_TicketList = SemItem_TicketList
        End If

        If Not objSemItem_TicketList_Parent Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_TicketList_Parent.GUID, _
                                                               objSemItem_TicketList.GUID, _
                                                               objLocalConfig.SemItem_RelationType_contains.GUID).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objDRC_TicketLists = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_TicketList.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                            objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID).Rows
            objSemItem_Result = objLocalConfig.Globals.LogState_Success

            For Each objDR_TicketList In objDRC_TicketLists
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_TicketList.GUID, _
                                                                       objDR_TicketList.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_contains.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objDRC_TicketLists = funcA_Token_Token.GetData_TokenToken_RightLeft(objSemItem_TicketList.GUID, _
                                                                                    objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                    objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID).Rows
                For Each objDR_TicketList In objDRC_TicketLists
                    objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDR_TicketList.Item("GUID_Token_Left"), _
                                                                           objSemItem_TicketList.GUID, _
                                                                           objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                Next
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function save_003_TicketList_To_Group(ByVal SemItem_Group As clsSemItem, Optional ByVal SemItem_TicketList As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Group = SemItem_Group

        If Not SemItem_TicketList Is Nothing Then
            objSemItem_TicketList = SemItem_TicketList
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_TicketList.GUID, _
                                                                objSemItem_Group.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_TicketList_To_Group(Optional ByVal SemItem_Group As clsSemItem = Nothing, Optional ByVal SemItem_TicketList As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Group Is Nothing Then
            objSemItem_Group = SemItem_Group
        End If

        If Not SemItem_TicketList Is Nothing Then
            objSemItem_TicketList = SemItem_TicketList
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_TicketList.GUID, _
                                                                objSemItem_Group.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_TicketList_To_Standard(Optional ByVal SemItem_TicketList As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If SemItem_TicketList Is Nothing Then
            objSemItem_TicketList = SemItem_TicketList
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_TicketList.GUID, _
                                                                          objLocalConfig.SemItem_Attribute_Standard.GUID, _
                                                                          Nothing, _
                                                                          False, 1).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_TokenAttribute = New clsSemItem
            objSemItem_TokenAttribute.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_TicketList_To_Standard(Optional ByVal SemItem_TicketList As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Standard As DataRowCollection
        Dim objDR_Standard As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_TicketList Is Nothing Then
            objSemItem_TicketList = SemItem_TicketList
        End If

        objDRC_Standard = funcA_TokenAttribute_Named.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_TicketList.GUID, _
                                                                                            objLocalConfig.SemItem_Attribute_Standard.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Standard In objDRC_Standard
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Standard.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_005_TicketList_To_Ticket(ByVal SemItem_Ticket As clsSemItem, Optional ByVal SemItem_TicketList As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Ticket = SemItem_Ticket

        If Not SemItem_TicketList Is Nothing Then
            objSemItem_TicketList = SemItem_TicketList
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_TicketList.GUID, _
                                                                objSemItem_Ticket.GUID, _
                                                                objLocalConfig.SemItem_RelationType_contains.GUID, 1).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_TicketList_To_Ticket(Optional ByVal SemItem_Ticket As clsSemItem = Nothing, Optional ByVal SemItem_TicketList As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Ticket As DataRowCollection
        Dim objDR_Ticket As DataRow

        If Not SemItem_Ticket Is Nothing Then
            objSemItem_Ticket = SemItem_Ticket
        End If

        If Not SemItem_TicketList Is Nothing Then
            objSemItem_TicketList = SemItem_TicketList
        End If

        If Not objSemItem_Ticket Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_TicketList.GUID, _
                                                                objSemItem_Ticket.GUID, _
                                                                objLocalConfig.SemItem_RelationType_contains.GUID).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
                Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objDRC_Ticket = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_TicketList.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                           objLocalConfig.SemItem_Type_Process_Ticket.GUID).Rows
            objSemItem_Result = objLocalConfig.Globals.LogState_Success

            For Each objDR_Ticket In objDRC_Ticket
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_TicketList.GUID, _
                                                                       objDR_Ticket.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_contains.GUID).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        End If
        
        Return objSemItem_Result
    End Function



    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenAttribute_Named.Connection = objLocalConfig.Connection_DB
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
