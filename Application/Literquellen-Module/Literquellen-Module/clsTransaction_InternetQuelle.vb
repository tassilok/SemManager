Imports Sem_Manager
Imports Log_Manager
Imports MediaViewer_Module
Public Class clsTransaction_InternetQuelle

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcT_TokenToken As New ds_Token.func_TokenTokenDataTable
    Private procT_Logentry_Of_Quelle As New DataSet_LiteraturQuelle.proc_Logentry_Of_QuelleDataTable
    Private procA_Logentry_Of_Quelle As New DataSet_LiteraturQuelleTableAdapters.proc_Logentry_Of_QuelleTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_DATETIME As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objLocalConfig As clsLocalConfig
    Private objConnection As SqlClient.SqlConnection
    Private objConnection_Module As SqlClient.SqlConnection

    Private objLogManagement As clsLogManagement

    Private objSemItem_LiteraturQuelle As clsSemItem
    Private objSemItem_InternetQuelle As clsSemItem
    Private objSemItem_URL As clsSemItem
    Private objSemItem_LogEntry As clsSemItem
    Private objSemItem_Partner As clsSemItem

    Private dateDownload As Date

    Public Property SemItem_InternetQuelle As clsSemItem
        Get
            Return objSemItem_InternetQuelle
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_InternetQuelle = value
        End Set
    End Property

    Public Function save_001_InternetQuelle(ByVal SemItem_LiteraturQuelle As clsSemItem) As clsSemItem
        Dim objDRC_InternetQuelle As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim i As Integer

        objSemItem_LiteraturQuelle = SemItem_LiteraturQuelle

        objDRC_InternetQuelle = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_LiteraturQuelle.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                          objLocalConfig.SemItem_Type_Internet_Quellenangabe.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        If objDRC_InternetQuelle.Count > 0 Then
            objSemItem_InternetQuelle = New clsSemItem
            objSemItem_InternetQuelle.GUID = objDRC_InternetQuelle(0).Item("GUID_Token_Left")
            objSemItem_InternetQuelle.Name = objDRC_InternetQuelle(0).Item("Name_Token_Left")
            objSemItem_InternetQuelle.GUID_Parent = objLocalConfig.SemItem_Type_Internet_Quellenangabe.GUID
            objSemItem_InternetQuelle.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objLocalConfig.Globals.LogState_Success

            For i = 1 To objDRC_InternetQuelle.Count - 1
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDRC_InternetQuelle(i).Item("GUID_Token_Left"), _
                                                                       objDRC_InternetQuelle(i).Item("GUID_Token_Right"), _
                                                                       objDRC_InternetQuelle(i).Item("GUID_RelationType")).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
                    Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then

                    semprocA_DBWork_Del_Token.GetData(objDRC_InternetQuelle(i).Item("GUID_Token_Left"))
                End If
            Next
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objSemItem_InternetQuelle = New clsSemItem
            objSemItem_InternetQuelle.GUID = Guid.NewGuid
            objSemItem_InternetQuelle.Name = objSemItem_LiteraturQuelle.Name
            objSemItem_InternetQuelle.GUID_Parent = objLocalConfig.SemItem_Type_Internet_Quellenangabe.GUID
            objSemItem_InternetQuelle.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_InternetQuelle.GUID, _
                                                                 objSemItem_InternetQuelle.Name, _
                                                                 objSemItem_InternetQuelle.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_InternetQuelle(Optional ByVal SemItem_InternetQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        If Not SemItem_InternetQuelle Is Nothing Then
            objSemItem_InternetQuelle = SemItem_InternetQuelle
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_InternetQuelle.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_InternetQuelle_To_LiteraturQuelle(Optional ByVal SemItem_InternetQuelle As clsSemItem = Nothing, Optional ByVal SemItem_LiteraturQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_InternetQuelle As DataRowCollection
        Dim objDR_IneternetQuelle As DataRow

        If Not SemItem_InternetQuelle Is Nothing Then
            objSemItem_InternetQuelle = SemItem_InternetQuelle
        End If

        If Not SemItem_LiteraturQuelle Is Nothing Then
            objSemItem_LiteraturQuelle = SemItem_LiteraturQuelle
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_InternetQuelle.GUID, _
                                                                        objSemItem_LiteraturQuelle.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_isSubordinated.GUID, 1).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success

        Else
            semprocA_DBWork_Del_Token.GetData(objSemItem_InternetQuelle.GUID)
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_InternetQuelle_To_LiteraturQuelle(Optional ByVal SemItem_InternetQuelle As clsSemItem = Nothing, Optional ByVal SemItem_LiteraturQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_InternetQuelle Is Nothing Then
            objSemItem_InternetQuelle = SemItem_InternetQuelle
        End If

        If Not SemItem_LiteraturQuelle Is Nothing Then
            objSemItem_LiteraturQuelle = SemItem_LiteraturQuelle
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_InternetQuelle.GUID, _
                                                               objSemItem_LiteraturQuelle.GUID, _
                                                               objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_003_InternetQuelle_To_Url(ByVal SemItem_Url As clsSemItem, Optional ByVal SemItem_InternetQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_URL As DataRowCollection
        Dim objDR_Url As DataRow

        objSemItem_URL = SemItem_Url

        If Not SemItem_InternetQuelle Is Nothing Then
            objSemItem_InternetQuelle = SemItem_InternetQuelle
        End If

        objDRC_URL = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_InternetQuelle.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                   objLocalConfig.SemItem_Type_Url.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_Url In objDRC_URL
            If objSemItem_URL.GUID = objDR_Url.Item("GUID_Token_Right") Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_InternetQuelle.GUID, _
                                                                       objDR_Url.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Source.GUID).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_InternetQuelle.GUID, _
                                                                    objSemItem_URL.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Source.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function


    Public Function del_003_InternetQuelle_To_Url(Optional ByVal SemItem_InternetQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_URL As DataRowCollection
        Dim objDR_Url As DataRow


        If Not SemItem_InternetQuelle Is Nothing Then
            objSemItem_InternetQuelle = SemItem_InternetQuelle
        End If

        objDRC_URL = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_InternetQuelle.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                   objLocalConfig.SemItem_Type_Url.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Url In objDRC_URL

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_InternetQuelle.GUID, _
                                                                    objDR_Url.Item("GUID_Token_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Source.GUID).Rows

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next


        Return objSemItem_Result
    End Function

    Public Function save_004_InternetQuelle_To_Logentry(ByVal dateDownload As Date, Optional ByVal SemItem_InternetQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDR_LogEntry As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_InternetQuelle Is Nothing Then
            objSemItem_InternetQuelle = SemItem_InternetQuelle
        End If

        procA_Logentry_Of_Quelle.Fill(procT_Logentry_Of_Quelle, _
                                      objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                      objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                      objLocalConfig.SemItem_type_Logstate.GUID, _
                                      objLocalConfig.SemItem_RelationType_provides.GUID, _
                                      objLocalConfig.SemItem_RelationType_download.GUID, _
                                      objSemItem_InternetQuelle.GUID)

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_LogEntry In procT_Logentry_Of_Quelle.Rows
            If dateDownload = objDR_LogEntry.Item("Datetimestamp") Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                objSemItem_LogEntry = New clsSemItem
                objSemItem_LogEntry.GUID = objDR_LogEntry.Item("GUID_LogEntry")
                objSemItem_LogEntry.Name = objDR_LogEntry.Item("Name_LogEntry")
                objSemItem_LogEntry.GUID_Parent = objLocalConfig.SemItem_Type_LogEntry.GUID
                objSemItem_LogEntry.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_InternetQuelle.GUID, _
                                                                       objDR_LogEntry.Item("GUID_LogEntry"), _
                                                                       objLocalConfig.SemItem_RelationType_download.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                Else
                    objSemItem_Result = objLogManagement.del_LogEntry(objDR_LogEntry.Item("GUID_LogEntry"))
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        Exit For
                    End If
                End If
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objLogManagement.del_LogEntry(objDR_LogEntry.Item("GUID_Logentry"))
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Or _
                        objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Relation.GUID Then
                        Exit For
                    End If
                End If
            End If

        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objSemItem_Result = objLogManagement.log_Entry(dateDownload, _
                                                           objLocalConfig.SemItem_Token_Logstate_Download.GUID, _
                                                           objLocalConfig.SemItem_User.GUID)
            If Not objSemItem_Result Is Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_InternetQuelle.GUID, _
                                                                        objSemItem_Result.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_download.GUID, 1).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_InternetQuelle_To_Logentry(Optional ByVal SemItem_InternetQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDR_LogEntry As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_InternetQuelle Is Nothing Then
            objSemItem_InternetQuelle = SemItem_InternetQuelle
        End If

        procA_Logentry_Of_Quelle.Fill(procT_Logentry_Of_Quelle, _
                                      objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                      objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                      objLocalConfig.SemItem_type_Logstate.GUID, _
                                      objLocalConfig.SemItem_RelationType_provides.GUID, _
                                      objLocalConfig.SemItem_RelationType_download.GUID, _
                                      objSemItem_InternetQuelle.GUID)

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_LogEntry In procT_Logentry_Of_Quelle.Rows

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_InternetQuelle.GUID, _
                                                                    objDR_LogEntry.Item("GUID_LogEntry"), _
                                                                    objLocalConfig.SemItem_RelationType_download.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            Else
                objSemItem_Result = objLogManagement.del_LogEntry(objDR_LogEntry.Item("GUID_LogEntry"))
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                End If
            End If


        Next

        Return objSemItem_Result
    End Function

    Public Function save_005_InternetQuelle_To_Partner(ByVal SemItem_Partner As clsSemItem, Optional ByVal SemItem_InternetQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Partner As DataRowCollection
        Dim objDR_Partner As DataRow

        objSemItem_Partner = SemItem_Partner

        If Not SemItem_InternetQuelle Is Nothing Then
            objSemItem_InternetQuelle = SemItem_InternetQuelle
        End If

        objDRC_Partner = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_InternetQuelle.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_Ersteller.GUID, _
                                                                   objLocalConfig.SemItem_Type_Partner.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_Partner In objDRC_Partner
            If objSemItem_Partner.GUID = objDR_Partner.Item("GUID_Token_Right") Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_InternetQuelle.GUID, _
                                                                       objDR_Partner.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_Ersteller.GUID).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_InternetQuelle.GUID, _
                                                                    objSemItem_Partner.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_Ersteller.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function


    Public Function del_005_InternetQuelle_To_Partner(Optional ByVal SemItem_InternetQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Partner As DataRowCollection
        Dim objDR_Partner As DataRow


        If Not SemItem_InternetQuelle Is Nothing Then
            objSemItem_InternetQuelle = SemItem_InternetQuelle
        End If

        objDRC_Partner = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_InternetQuelle.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_Ersteller.GUID, _
                                                                   objLocalConfig.SemItem_Type_Partner.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Partner In objDRC_Partner

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_InternetQuelle.GUID, _
                                                                    objDR_Partner.Item("GUID_Token_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_Ersteller.GUID).Rows

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next


        Return objSemItem_Result
    End Function

    Public Function del_006_InternetQuelle_To_Begriff(Optional ByVal SemItem_InternetQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Begriff As DataRowCollection
        Dim objDR_Begriff As DataRow


        If Not SemItem_InternetQuelle Is Nothing Then
            objSemItem_InternetQuelle = SemItem_InternetQuelle
        End If

        objDRC_Begriff = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_InternetQuelle.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                   objLocalConfig.SemItem_Type_Begriff.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Begriff In objDRC_Begriff

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_InternetQuelle.GUID, _
                                                                    objDR_Begriff.Item("GUID_Token_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_contains.GUID).Rows

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next


        Return objSemItem_Result
    End Function

    Public Function del_007_PDFFiles(Optional ByVal SemItem_InternetQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem


    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objConnection = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)
        objConnection_Module = New SqlClient.SqlConnection(objLocalConfig.Connection_Plugin.ConnectionString)

        funcA_TokenToken.Connection = objConnection
        procA_Logentry_Of_Quelle.Connection = objConnection_Module

        semprocA_DBWork_Save_Token.Connection = objConnection
        semprocA_DBWork_Del_Token.Connection = objConnection

        semprocA_DBWork_Save_TokenRel.Connection = objConnection
        semprocA_DBWork_Del_TokenRel.Connection = objConnection

        semprocA_DBWork_Save_TokenAttribute_DATETIME.Connection = objConnection
        semprocA_DBWork_Del_TokenAttribute.Connection = objConnection

        objLogManagement = New clsLogManagement(objLocalConfig.Globals)
    End Sub
End Class
