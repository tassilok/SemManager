Imports Sem_Manager
Public Class clsTransaction_BuchQuelle
    Private objLocalConfig As clsLocalConfig
    Private objConnection As SqlClient.SqlConnection

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcT_TokenToken As New ds_Token.func_TokenTokenDataTable
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHAR255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objSemItem_LiteraturQuelle As clsSemItem
    Private objSemItem_BuchQuelle As clsSemItem
    Private objSemItem_TokenAttribute_Seite As clsSemItem
    Private objSemItem_Literatur As clsSemItem
    Private objSemItem_BuchQuelle_Parent As clsSemItem

    Public Property SemItem_BuchQeulle As clsSemItem
        Get
            Return objSemItem_BuchQuelle
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_BuchQuelle = value
        End Set
    End Property

    Public Function save_001_BuchQuelle(ByVal SemItem_LiteraturQuelle As clsSemItem) As clsSemItem
        Dim objDRC_BuchQuelle As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim i As Integer

        objSemItem_LiteraturQuelle = SemItem_LiteraturQuelle

        objDRC_BuchQuelle = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_LiteraturQuelle.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                          objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        If objDRC_BuchQuelle.Count > 0 Then
            objSemItem_BuchQuelle = New clsSemItem
            objSemItem_BuchQuelle.GUID = objDRC_BuchQuelle(0).Item("GUID_Token_Left")
            objSemItem_BuchQuelle.Name = objDRC_BuchQuelle(0).Item("Name_Token_Left")
            objSemItem_BuchQuelle.GUID_Parent = objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID
            objSemItem_BuchQuelle.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objLocalConfig.Globals.LogState_Success

            For i = 1 To objDRC_BuchQuelle.Count - 1
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDRC_BuchQuelle(i).Item("GUID_Token_Left"), _
                                                                       objDRC_BuchQuelle(i).Item("GUID_Token_Right"), _
                                                                       objDRC_BuchQuelle(i).Item("GUID_RelationType")).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
                    Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then

                    semprocA_DBWork_Del_Token.GetData(objDRC_BuchQuelle(i).Item("GUID_Token_Left"))
                End If
            Next
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objSemItem_BuchQuelle = New clsSemItem
            objSemItem_BuchQuelle.GUID = Guid.NewGuid
            objSemItem_BuchQuelle.Name = objSemItem_LiteraturQuelle.Name
            objSemItem_BuchQuelle.GUID_Parent = objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID
            objSemItem_BuchQuelle.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_BuchQuelle.GUID, _
                                                                 objSemItem_BuchQuelle.Name, _
                                                                 objSemItem_BuchQuelle.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_BuchQuelle.GUID, _
                                                                        objSemItem_LiteraturQuelle.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_isSubordinated.GUID, 1).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success

                Else
                    semprocA_DBWork_Del_Token.GetData(objSemItem_BuchQuelle.GUID)
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_BuchQuelle(Optional ByVal SemItem_LiteraturQuelle As clsSemItem = Nothing, Optional ByVal SemItem_BuchQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objDR_BuchQuelle As DataRow
        Dim objDRC_BuchQuelle As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        If Not SemItem_LiteraturQuelle Is Nothing Then
            objSemItem_LiteraturQuelle = SemItem_LiteraturQuelle
        End If

        If Not SemItem_BuchQuelle Is Nothing Then
            objSemItem_BuchQuelle = SemItem_BuchQuelle
        End If

        If objSemItem_LiteraturQuelle Is Nothing And Not objSemItem_BuchQuelle Is Nothing Then
            objDRC_BuchQuelle = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_BuchQuelle.GUID, _
                                                                              objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                              objLocalConfig.SemItem_Type_literarische_Quelle.GUID).Rows
            If objDRC_BuchQuelle.Count > 0 Then
                objSemItem_LiteraturQuelle = New clsSemItem
                objSemItem_LiteraturQuelle.GUID = objDRC_BuchQuelle(0).Item("GUID_Token_Right")
                objSemItem_LiteraturQuelle.Name = objDRC_BuchQuelle(0).Item("Name_Token_Right")
                objSemItem_LiteraturQuelle.GUID_Parent = objLocalConfig.SemItem_Type_literarische_Quelle.GUID
                objSemItem_LiteraturQuelle.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            If Not objSemItem_LiteraturQuelle Is Nothing And objSemItem_BuchQuelle Is Nothing Then
                objDRC_BuchQuelle = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_LiteraturQuelle.GUID, _
                                                                                  objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                                  objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID).Rows
                If objDRC_BuchQuelle.Count > 0 Then
                    objSemItem_BuchQuelle = New clsSemItem
                    objSemItem_BuchQuelle.GUID = objDRC_BuchQuelle(0).Item("GUID_Token_Left")
                    objSemItem_BuchQuelle.Name = objDRC_BuchQuelle(0).Item("Name_Token_Left")
                    objSemItem_BuchQuelle.GUID_Parent = objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID
                    objSemItem_BuchQuelle.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                End If
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            ElseIf Not objSemItem_LiteraturQuelle Is Nothing And Not objSemItem_BuchQuelle Is Nothing Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else

                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            If objSemItem_BuchQuelle Is Nothing Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                funcA_TokenToken.Fill_RightLeft_Tokens_By_GUIDTokenRight_Only(funcT_TokenToken, _
                                                                              objSemItem_BuchQuelle.GUID)
                If funcT_TokenToken.Select("not GUID_Type_Left='" & objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID.ToString & "'").Length > 0 Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Relation

                End If

                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objDRC_BuchQuelle = funcA_TokenToken.GetData_LeftRight_Tokens_By_GUIDTokenLeft_Only(objSemItem_BuchQuelle.GUID).Rows
                    For Each objDR_BuchQuelle In objDRC_BuchQuelle
                        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_BuchQuelle.GUID, _
                                                                               objDR_BuchQuelle.Item("GUID_Token_Right"), _
                                                                               objDR_BuchQuelle.Item("GUID_RelationType")).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                            Exit For
                        End If
                    Next

                    objDRC_BuchQuelle = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_BuchQuelle.GUID, _
                                                                                                                       objLocalConfig.SemItem_Attribute_Seite.GUID).Rows
                    For Each objDR_BuchQuelle In objDRC_BuchQuelle
                        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_BuchQuelle.Item("GUID_TokenAttribute")).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                            Exit For
                        End If
                    Next

                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_BuchQuelle.GUID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And _
                            Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If
                    End If
                End If
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Seite(ByVal strSeite As String, Optional ByVal SemItem_BuchQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Seite As DataRowCollection
        Dim objDR_Seite As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_BuchQuelle Is Nothing Then
            objSemItem_BuchQuelle = SemItem_BuchQuelle
        End If

        objSemItem_TokenAttribute_Seite = New clsSemItem
        objSemItem_TokenAttribute_Seite.Additional1 = strSeite

        objDRC_Seite = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_BuchQuelle.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_Seite.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_Seite In objDRC_Seite
            If objDR_Seite.Item("Val_VARCHAR255") = strSeite Then
                objSemItem_TokenAttribute_Seite.GUID = objDR_Seite.Item("GUID_TokenATtribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Seite.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_BuchQuelle.GUID, _
                                                                                     objLocalConfig.SemItem_Attribute_Seite.GUID, _
                                                                                     Nothing, _
                                                                                     objSemItem_TokenAttribute_Seite.Additional1, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_Seite.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_Seite(Optional ByVal SemItem_BuchQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Seite As DataRowCollection
        Dim objDR_Seite As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_BuchQeulle Is Nothing Then
            objSemItem_BuchQuelle = SemItem_BuchQeulle
        End If


        objDRC_Seite = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_BuchQuelle.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_Seite.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Seite In objDRC_Seite
            
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Seite.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_003_Quelle_To_Literatur(ByVal SemItem_Literatur As clsSemItem, Optional ByVal SemItem_BuchQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Literatur As DataRowCollection
        Dim objDR_Literatur As DataRow

        objSemItem_Literatur = SemItem_Literatur

        If Not SemItem_BuchQuelle Is Nothing Then
            objSemItem_BuchQuelle = SemItem_BuchQuelle
        End If

        objDRC_Literatur = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_BuchQuelle.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                         objLocalConfig.SemItem_Type_Literatur.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_Literatur In objDRC_Literatur
            If objDR_Literatur.Item("GUID_Token_Right") = objSemItem_Literatur.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_BuchQuelle.GUID, _
                                                                       objDR_Literatur.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belonging_Source.GUID).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_BuchQuelle.GUID, _
                                                                    objSemItem_Literatur.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Source.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function


    Public Function del_003_Quelle_To_Literatur(Optional ByVal SemItem_Literatur As clsSemItem = Nothing, Optional ByVal SemItem_BuchQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Literatur As DataRowCollection
        Dim objDR_Literatur As DataRow

        If Not SemItem_Literatur Is Nothing Then
            objSemItem_Literatur = SemItem_Literatur
        End If

        If Not SemItem_BuchQeulle Is Nothing Then
            objSemItem_BuchQuelle = SemItem_BuchQeulle
        End If

        objDRC_Literatur = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_BuchQuelle.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                         objLocalConfig.SemItem_Type_Literatur.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Literatur In objDRC_Literatur
            
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_BuchQuelle.GUID, _
                                                                    objDR_Literatur.Item("GUID_Token_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Source.GUID).Rows

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_004_Quelle_To_Parent(ByVal SemItem_Parent As clsSemItem, Optional ByVal SemItem_BuchQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_BuchQuelle_Parent As DataRowCollection
        Dim objDR_BuchQuelle_Parent As DataRow

        objSemItem_BuchQuelle_Parent = SemItem_Parent

        If Not SemItem_BuchQuelle Is Nothing Then
            objSemItem_BuchQuelle = SemItem_BuchQuelle
        End If

        objDRC_BuchQuelle_Parent = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_BuchQuelle.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                         objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_BuchQuelle_Parent In objDRC_BuchQuelle_Parent
            If objDR_BuchQuelle_Parent.Item("GUID_Token_Right") = objSemItem_BuchQuelle_Parent.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_BuchQuelle.GUID, _
                                                                       objDR_BuchQuelle_Parent.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_BuchQuelle.GUID, _
                                                                    objSemItem_BuchQuelle_Parent.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_isSubordinated.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function


    Public Function del_004_Quelle_To_Parent(Optional ByVal SemItem_Parent As clsSemItem = Nothing, Optional ByVal SemItem_BuchQuelle As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_BuchQuelle_Parent As DataRowCollection
        Dim objDR_BuchQuelle_Parent As DataRow

        If Not SemItem_Parent Is Nothing Then
            objSemItem_BuchQuelle_Parent = SemItem_Parent
        End If

        If Not SemItem_BuchQuelle Is Nothing Then
            objSemItem_BuchQuelle = SemItem_BuchQuelle
        End If

        objDRC_BuchQuelle_Parent = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_BuchQuelle.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                         objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_BuchQuelle_Parent In objDRC_BuchQuelle_Parent

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_BuchQuelle.GUID, _
                                                                    objDR_BuchQuelle_Parent.Item("GUID_Token_Right"), _
                                                                    objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows

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
        objConnection = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)

        funcA_TokenToken.Connection = objConnection
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objConnection

        semprocA_DBWork_Save_Token.Connection = objConnection
        semprocA_DBWork_Del_Token.Connection = objConnection

        semprocA_DBWork_Save_TokenRel.Connection = objConnection
        semprocA_DBWork_Del_TokenRel.Connection = objConnection

        semprocA_DBWork_Save_TokenAttribute_VARCHAR255.Connection = objConnection
        semprocA_DBWork_Del_TokenAttribute.Connection = objConnection
    End Sub
End Class
