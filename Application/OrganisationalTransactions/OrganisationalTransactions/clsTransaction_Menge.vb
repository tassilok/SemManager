Imports Sem_Manager
Public Class clsTransaction_Menge
    Private objLocalConfig As clsLocalConfig

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Real As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_RealTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private procA_Menge_By_Val_Einheit As New ds_MengeTableAdapters.proc_Menge_By_Val_EinheitTableAdapter

    Private objSemItem_Menge As clsSemItem
    Private objSemItem_Einheit As clsSemItem

    Private objSemItem_TokenAttribute_Menge As clsSemItem

    Private dblMenge As Double

    Public ReadOnly Property SemItem_Menge As clsSemItem
        Get
            Return objSemItem_Menge
        End Get
    End Property
    Public Function save_001_Menge(ByVal dblMenge As Double, ByVal SemItem_Einheit As clsSemItem, Optional ByVal SemItem_Menge As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Menge As DataRowCollection
        Dim objDR_Menge As DataRow
        Dim objDRC_Einheit As DataRowCollection
        Dim objDR_Einheit As DataRow

        Me.dblMenge = dblMenge

        objSemItem_Einheit = SemItem_Einheit
        If Not SemItem_Menge Is Nothing Then
            objSemItem_Menge = SemItem_Menge
        End If
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If Not objLocalConfig.Globals.is_GUID(objSemItem_Einheit.GUID.ToString) Then
            objDRC_Einheit = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_Einheit.GUID, _
                                                                              objSemItem_Einheit.Name).Rows
            If objDRC_Einheit.Count > 0 Then
                objSemItem_Einheit.GUID = objDRC_Einheit(0).Item("GUID_Token")
                objSemItem_Einheit.Name = objDRC_Einheit(0).Item("Name_Token")
                objSemItem_Einheit.GUID_Parent = objLocalConfig.SemItem_Type_Einheit.GUID
                objSemItem_Einheit.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Else
                objSemItem_Einheit.GUID = Guid.NewGuid
                objSemItem_Einheit.GUID_Parent = objLocalConfig.SemItem_Type_Einheit.GUID
                objSemItem_Einheit.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID



            End If
        End If


        objDRC_Menge = procA_Menge_By_Val_Einheit.GetData(objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                            objLocalConfig.SemItem_Type_Menge.GUID, _
                                                            objLocalConfig.SemItem_Type_Einheit.GUID, _
                                                            objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                            objSemItem_Einheit.Name, _
                                                            dblMenge).Rows
        If objDRC_Menge.Count > 0 Then
            objSemItem_Menge = New clsSemItem
            objSemItem_Menge.GUID = objDRC_Menge(0).Item("GUID_Menge")
            objSemItem_Menge.Name = dblMenge & " " & objSemItem_Einheit.Name
            objSemItem_Menge.GUID_Parent = objLocalConfig.SemItem_Type_Menge.GUID
            objSemItem_Menge.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            If Not objDRC_Menge(0).Item("Name_Menge") = objSemItem_Menge.Name Then
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Menge.GUID, _
                                                                        objSemItem_Menge.Name, _
                                                                        objSemItem_Menge.GUID_Parent, False).Rows

            End If
            objSemItem_Result = objLocalConfig.Globals.LogState_Exists
        Else
            objSemItem_Menge = New clsSemItem
            objSemItem_Menge.GUID = Guid.NewGuid
            objSemItem_Menge.Name = dblMenge.ToString & " " & objSemItem_Einheit.Name
            objSemItem_Menge.GUID_Parent = objLocalConfig.SemItem_Type_Menge.GUID
            objSemItem_Menge.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Menge.GUID, _
                                                                    objSemItem_Menge.Name, _
                                                                    objSemItem_Menge.GUID_Parent, True).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else

                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function

    Public Function del_001_Menge(Optional ByVal SemItem_Menge As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Menge Is Nothing Then
            objSemItem_Menge = SemItem_Menge
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Menge.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Menge__Menge(Optional ByVal dblMenge As Double = Nothing, Optional ByVal SemItem_Menge As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Menge As DataRowCollection
        Dim objDR_Menge As DataRow

        If Not dblMenge = Nothing Then
            Me.dblMenge = dblMenge
        End If

        If Not SemItem_Menge Is Nothing Then
            objSemItem_Menge = SemItem_Menge
        End If

        objDRC_Menge = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Menge.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_Menge.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Menge In objDRC_Menge
            If objDR_Menge.Item("VAL_Real") = dblMenge Then
                objSemItem_TokenAttribute_Menge = New clsSemItem
                objSemItem_TokenAttribute_Menge.GUID = objDR_Menge.Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Menge.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Real.GetData(objSemItem_Menge.GUID, _
                                                                               objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                                               Nothing, _
                                                                               Me.dblMenge, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_TokenAttribute_Menge = New clsSemItem
                objSemItem_TokenAttribute_Menge.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        Return objSemItem_Result
    End Function

    Public Function del_002_Menge__Menge(Optional ByVal SemItem_Menge As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Menge As DataRowCollection
        Dim objDR_Menge As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Menge Is Nothing Then
            objSemItem_Menge = SemItem_Menge
        End If
        objDRC_Menge = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Menge.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_Menge.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Menge In objDRC_Menge
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Menge.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_003_Einheit(ByVal objSemItem_Einheit As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Einheit.GUID, _
                                                             objSemItem_Einheit.Name, _
                                                             objSemItem_Einheit.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_Einheit(Optional ByVal SemItem_Einheit As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Einheit Is Nothing Then
            objSemItem_Einheit = SemItem_Einheit
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Einheit.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_Menge_To_Einheit(Optional ByVal SemItem_Einheit As clsSemItem = Nothing, Optional ByVal SemItem_Menge As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Menge As DataRowCollection
        Dim objDR_Menge As DataRow

        If Not SemItem_Einheit Is Nothing Then
            objSemItem_Einheit = SemItem_Einheit
        End If

        If Not SemItem_Menge Is Nothing Then
            objSemItem_Menge = SemItem_Menge
        End If

        objDRC_Menge = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Menge.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                     objLocalConfig.SemItem_Type_Einheit.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Menge In objDRC_Menge
            If objDR_Menge.Item("GUID_Token_Right") = objSemItem_Einheit.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Menge.GUID, _
                                                                       objDR_Menge.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If

        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Menge.GUID, _
                                                                    objSemItem_Einheit.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_Menge_To_Einheit(Optional ByVal SemItem_Menge As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Menge As DataRowCollection
        Dim objDR_Menge As DataRow

        objDRC_Menge = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Menge.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                     objLocalConfig.SemItem_Type_Einheit.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Menge In objDRC_Menge
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Menge.GUID, _
                                                                   objDR_Menge.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next


        Return objSemItem_Result
    End Function

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Real.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB


        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        procA_Menge_By_Val_Einheit.Connection = objLocalConfig.Connection_Plugin
    End Sub
End Class
