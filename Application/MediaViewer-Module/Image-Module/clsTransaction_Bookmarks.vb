Imports Sem_Manager
Imports Log_Manager
Public Class clsTransaction_Bookmarks

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHAR255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private objLocalConfig As clsLocalConfig
    Private objLogManagement As clsLogManagement

    Private objSemItem_User As clsSemItem

    Private objSemItem_Bookmark As clsSemItem
    Private objSemItem_LogEntry As clsSemItem
    Private objSemItem_LogState As clsSemItem
    Private objSemItem_MediaItem As clsSemItem
    Private strPosition As String
    Private objSemItem_TokenAttribute_MediPosition As clsSemItem
    Private dateLogEntry As Date

    Public ReadOnly Property SemItem_LogEntry As clsSemItem
        Get
            Return objSemItem_LogEntry
        End Get
    End Property

    Public ReadOnly Property date_Logentry As Date
        Get
            Return dateLogentry
        End Get
    End Property

    Public Function save_001_Bookmark(ByVal SemItem_Bookmark As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Bookmark = SemItem_Bookmark
        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Bookmark.GUID, _
                                                             objSemItem_Bookmark.Name, _
                                                             objSemItem_Bookmark.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_Bookmark(Optional ByVal SemItem_Bookmark As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Bookmark Is Nothing Then
            objSemItem_Bookmark = SemItem_Bookmark
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Bookmark.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function save_002_BookMark__Position(ByVal strPosition As String, Optional ByVal SemItem_Bookmark As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Position As DataRowCollection
        Dim objDR_Position As DataRow

        If Not SemItem_Bookmark Is Nothing Then
            objSemItem_Bookmark = SemItem_Bookmark
        End If

        Me.strPosition = strPosition

        objDRC_Position = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Bookmark.GUID, _
                                                                                                         objLocalConfig.SemItem_Attribute_Media_Position.GUID).Rows

        objSemItem_TokenAttribute_MediPosition = Nothing
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_Position In objDRC_Position
            If objDR_Position.Item("Val_VARCHAR255") = strPosition Then
                objSemItem_TokenAttribute_MediPosition = New clsSemItem
                objSemItem_TokenAttribute_MediPosition.GUID = objDR_Position.Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Position.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_Bookmark.GUID, _
                                                                                     objLocalConfig.SemItem_Attribute_Media_Position.GUID, _
                                                                                     Nothing, _
                                                                                     strPosition, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_MediPosition = New clsSemItem
                objSemItem_TokenAttribute_MediPosition.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_BookMark__Position(Optional ByVal SemItem_Bookmark As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Position As DataRowCollection
        Dim objDR_Position As DataRow

        If Not SemItem_Bookmark Is Nothing Then
            objSemItem_Bookmark = SemItem_Bookmark
        End If


        objDRC_Position = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Bookmark.GUID, _
                                                                                                         objLocalConfig.SemItem_Attribute_Media_Position.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Position In objDRC_Position
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Position.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next


        Return objSemItem_Result
    End Function

    Public Function save_003_LogEntry(ByVal SemItem_LogState As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        dateLogEntry = Now

        objSemItem_LogState = SemItem_LogState

        If Not objSemItem_User Is Nothing Then
            objSemItem_LogEntry = objLogManagement.log_Entry(dateLogEntry, _
                                   objSemItem_LogState.GUID, _
                                   objSemItem_User.GUID)
        Else
            objSemItem_LogEntry = objLogManagement.log_Entry(dateLogEntry, _
                                   objSemItem_LogState.GUID, _
                                   Nothing)
        End If
        

        If Not objSemItem_LogEntry Is Nothing Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_LogEntry(Optional ByVal SemItem_LogEntry As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not objSemItem_LogEntry Is Nothing Then
            objSemItem_LogEntry = SemItem_LogEntry
        End If

        objSemItem_Result = objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)

        Return objSemItem_Result
    End Function

    Public Function save_004_BookMark_To_LogEntry(Optional ByVal SemItem_Logentry As clsSemItem = Nothing, Optional ByVal SemItem_Bookmark As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_LogEntry As DataRowCollection
        Dim objDR_LogEntry As DataRow

        If Not SemItem_Bookmark Is Nothing Then
            objSemItem_Bookmark = SemItem_Bookmark
        End If

        If Not SemItem_Logentry Is Nothing Then
            objSemItem_LogEntry = SemItem_Logentry
        End If

        objDRC_LogEntry = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Bookmark.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belonging_Done.GUID, _
                                                                        objLocalConfig.SemItem_Type_LogEntry.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_LogEntry In objDRC_LogEntry
            If objDR_LogEntry.Item("GUID_Token") = objSemItem_LogEntry.GUID Then

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Exit For
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Bookmark.GUID, _
                                                                       objDR_LogEntry.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Done.GUID).Rows
                If objDRC_LogEntry(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next


        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Bookmark.GUID, _
                                                                    objSemItem_LogEntry.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Done.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function del_004_BookMark_To_LogEntry(Optional ByVal SemItem_Bookmark As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_LogEntry As DataRowCollection
        Dim objDR_LogEntry As DataRow

        If Not SemItem_Bookmark Is Nothing Then
            objSemItem_Bookmark = SemItem_Bookmark
        End If


        objDRC_LogEntry = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Bookmark.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belonging_Done.GUID, _
                                                                        objLocalConfig.SemItem_Type_LogEntry.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_LogEntry In objDRC_LogEntry
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Bookmark.GUID, _
                                                                   objDR_LogEntry.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belonging_Done.GUID).Rows
            If objDRC_LogEntry(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_005_BookMark_To_MediaItem(ByVal SemItem_MediaItem As clsSemItem, Optional ByVal SemItem_Bookmark As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_MediaItem As DataRowCollection
        Dim objDR_MediaItem As DataRow

        objSemItem_MediaItem = SemItem_MediaItem
        If Not SemItem_Bookmark Is Nothing Then
            objSemItem_Bookmark = SemItem_Bookmark
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        objDRC_MediaItem = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Bookmark.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                         objSemItem_MediaItem.GUID).Rows
        For Each objDR_MediaItem In objDRC_MediaItem
            If objDR_MediaItem.Item("GUID_Toke_Right") = objSemItem_MediaItem.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Bookmark.GUID, _
                                                                       objDR_MediaItem.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next


        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Bookmark.GUID, _
                                                                    objSemItem_MediaItem.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_BookMark_To_MediaItem(Optional ByVal SemItem_Bookmark As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_MediaItem As DataRowCollection
        Dim objDR_MediaItem As DataRow

        If Not SemItem_Bookmark Is Nothing Then
            objSemItem_Bookmark = SemItem_Bookmark
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_MediaItem = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Bookmark.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                         objSemItem_MediaItem.GUID).Rows
        For Each objDR_MediaItem In objDRC_MediaItem
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Bookmark.GUID, _
                                                                       objDR_MediaItem.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig, Optional ByVal SemItem_User As clsSemItem = Nothing)
        objSemItem_User = SemItem_User
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHAR255.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        objLogManagement = New clsLogManagement(objLocalConfig.Globals)
    End Sub
End Class
