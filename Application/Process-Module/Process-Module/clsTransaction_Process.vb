Imports Sem_Manager
Public Class clsTransaction_Process
    Private objLocalConfig As clsLocalConfig

    Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private objSemItem_Process As clsSemItem
    Private objSemItem_Process_Parent As clsSemItem
    Private GUID_TokenAttribute_Public As Guid
    Private objSemItem_TokenAttribute_Description As clsSemItem

    Public ReadOnly Property SemItem_Process As clsSemItem
        Get
            Return objSemItem_Process
        End Get
    End Property

    Public Function save_001_Process(ByVal SemItem_Process As clsSemItem) As clsSemItem

        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Process = SemItem_Process

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Process.GUID, _
                                                             objSemItem_Process.Name, _
                                                             objSemItem_Process.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_Process(Optional ByVal SemItem_Process As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Process Is Nothing Then
            objSemItem_Process = SemItem_Process
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Process.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Process_Public(ByVal boolPublic As Boolean, Optional ByVal SemItem_Process As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Process As DataRowCollection

        Dim objDRC_LogState As DataRowCollection
        Dim i As Integer
        Dim boolAdd As Boolean

        If Not SemItem_Process Is Nothing Then
            objSemItem_Process = SemItem_Process

        End If

        objDRC_Process = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Process.GUID, _
                                                                                                        objLocalConfig.SemItem_Attribute_Public.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        boolAdd = True
        If objDRC_Process.Count > 0 Then
            boolAdd = False
            For i = 1 To objDRC_Process.Count - 1
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_Process(i).Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If

            Next
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                GUID_TokenAttribute_Public = objDRC_Process(0).Item("GUID_TokenAttribute")
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Process.GUID, _
                                                                                  objLocalConfig.SemItem_Attribute_Public.GUID, _
                                                                                  objDRC_Process(0).Item("GUID_TokenAttribute"), _
                                                                                  boolPublic, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        End If

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Process.GUID, _
                                                                          objLocalConfig.SemItem_Attribute_Public.GUID, _
                                                                          Nothing, _
                                                                          boolPublic, 0).Rows

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                GUID_TokenAttribute_Public = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        

        Return objSemItem_Result

    End Function

    Public Function del_002_Process_Public(Optional ByVal SemItem_Process As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_Process As DataRowCollection
        Dim objDR_Process As DataRow
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        If Not SemItem_Process Is Nothing Then
            objSemItem_Process = SemItem_Process
        End If
        objDRC_Process = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Process.GUID, _
                                                                                                        objLocalConfig.SemItem_Attribute_Public.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Process In objDRC_Process
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Process.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_003_Process_To_Parent(ByVal SemItem_Process_Parent As clsSemItem, ByVal intOrderID As Integer, Optional ByVal SemItem_Process As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_Process As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objSemItem_Process_Parent = SemItem_Process_Parent
        If Not SemItem_Process Is Nothing Then
            objSemItem_Process = SemItem_Process

        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objLocalConfig.Globals.is_GUID(objSemItem_Process.GUID.ToString) Then
            objDRC_Process = semtblA_Token_Token.GetData_By_GUIDs(objSemItem_Process_Parent.GUID, _
                                                              objSemItem_Process.GUID, _
                                                              objLocalConfig.SemItem_RelationType_superordinate.GUID).Rows
        Else
            objDRC_Process = funcA_TokenToken.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(objSemItem_Process_Parent.GUID, _
                                                                                                               objSemItem_Process.Name, _
                                                                                                               objLocalConfig.SemItem_Type_Process.GUID, _
                                                                                                               objLocalConfig.SemItem_RelationType_superordinate.GUID).Rows
            If objDRC_Process.Count = 0 Then
                objSemItem_Process.GUID = Guid.NewGuid
                objSemItem_Result = save_001_Process(objSemItem_Process)
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Exists
            End If
        End If
        

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            If intOrderID = -1 Then
                intOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_Process_Parent.GUID, _
                                                                             objLocalConfig.SemItem_Type_Process.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_superordinate.GUID) + 1

            End If
            If objDRC_Process.Count = 0 Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Process_Parent.GUID, _
                                                                        objSemItem_Process.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                                        intOrderID).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                If Not objDRC_Process(0).Item("OrderID") = intOrderID Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Process_Parent.GUID, _
                                                                        objSemItem_Process.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                                        intOrderID).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                End If
            End If
        End If
        

        Return objSemItem_Result
    End Function

    Public Function del_003_Process_To_Parent(Optional ByVal SemItem_Process_Parent As clsSemItem = Nothing, Optional ByVal SemItem_Process As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Process As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Process Is Nothing Then
            objSemItem_Process = SemItem_Process
        End If
        If Not SemItem_Process_Parent Is Nothing Then
            objSemItem_Process_Parent = SemItem_Process_Parent
        End If

        objDRC_Process = semtblA_Token_Token.GetData_By_GUIDs(objSemItem_Process_Parent.GUID, _
                                                              objSemItem_Process.GUID, _
                                                              objLocalConfig.SemItem_RelationType_superordinate.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objDRC_Process.Count > 0 Then
            objSemItem_Result.Level = objDRC_Process(0).Item("OrderID")
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Process_Parent.GUID, _
                                                                   objSemItem_Process.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_superordinate.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_Process__Description(ByVal Description As String, Optional ByVal SemItem_Process As clsSemItem = Nothing, Optional ByVal SemItem_TokenAttribute_Description As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Process__Description As DataRowCollection

        If Not SemItem_Process Is Nothing Then
            objSemItem_Process = SemItem_Process
        End If

        objSemItem_TokenAttribute_Description = SemItem_TokenAttribute_Description

        If objSemItem_TokenAttribute_Description Is Nothing Then
            objDRC_Process__Description = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Process.GUID, _
                                                                                                                         objLocalConfig.SemItem_Attribute_Description.GUID).Rows
            If objDRC_Process__Description.Count = 0 Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_Process.GUID, _
                                                                                         objLocalConfig.SemItem_Attribute_Description.GUID, _
                                                                                         Nothing, _
                                                                                         Description, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_TokenAttribute_Description = New clsSemItem
                    objSemItem_TokenAttribute_Description.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_Process.GUID, _
                                                                                         objLocalConfig.SemItem_Attribute_Description.GUID, _
                                                                                         objDRC_Process__Description(0).Item("GUID_TokenAttribute"), _
                                                                                         Description, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_TokenAttribute_Description = New clsSemItem
                    objSemItem_TokenAttribute_Description.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Else
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_Process.GUID, _
                                                                                     objLocalConfig.SemItem_Attribute_Description.GUID, _
                                                                                     objSemItem_TokenAttribute_Description.GUID, _
                                                                                     Description, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_token") = objLocalConfig.Globals.LogState_Error.GUID Then

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function del_004_Process__Description(Optional ByVal SemItem_TokenAttribute_Description As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Process__Description As DataRowCollection
        Dim objDR_Process_Description As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_TokenAttribute_Description Is Nothing Then
            objSemItem_TokenAttribute_Description = SemItem_TokenAttribute_Description
        End If

        objDRC_Process__Description = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Process.GUID, _
                                                                                                                     objLocalConfig.SemItem_Attribute_Description.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Process_Description In objDRC_Process__Description
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Process_Description.Item("GUID_TokenAttribute")).Rows
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
    Public Sub New(ByVal objGlobals As clsGlobals)
        objLocalConfig = New clsLocalConfig(objGlobals)
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Token_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

    End Sub
End Class
