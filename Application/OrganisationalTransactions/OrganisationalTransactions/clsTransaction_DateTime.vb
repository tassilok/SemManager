Imports Sem_Manager
Public Class clsTransaction_DateTime

    Private objLocalConfig As clsLocalConfig

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Int As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_IntTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private objSemItem_Period As clsSemItem
    Private objSemItem_TokenAttribute_ID As clsSemItem
    Private intPeriod As Integer

    Public ReadOnly Property SemItem_Period As clsSemItem
        Get
            Return objSemItem_Period
        End Get
    End Property

    Public Function save_001_Period(ByVal intPeriod As Integer, ByVal GUID_Parent As Guid) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Period As DataRowCollection

        Me.intPeriod = intPeriod
        objSemItem_Period = Nothing
        objDRC_Period = semtblA_Token.GetData_Token_By_Name_And_GUIDType(GUID_Parent, intPeriod.ToString).Rows
        If objDRC_Period.Count = 0 Then
            objSemItem_Period = New clsSemItem
            objSemItem_Period.GUID = Guid.NewGuid
            objSemItem_Period.Name = intPeriod.ToString
            objSemItem_Period.GUID_Parent = GUID_Parent

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Period.GUID, _
                                                                 objSemItem_Period.Name, _
                                                                 objSemItem_Period.GUID_Parent, _
                                                                 True).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Period = New clsSemItem
            objSemItem_Period.GUID = objDRC_Period(0).Item("GUID_Token")
            objSemItem_Period.Name = objDRC_Period(0).Item("Name_Token")
            objSemItem_Period.GUID_Parent = GUID_Parent
            objSemItem_Period.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If
        
        Return objSemItem_Result
    End Function

    Public Function del_001_Period(Optional ByVal SemItem_Period As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Period Is Nothing Then
            objSemItem_Period = SemItem_Period
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Period.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function save_002_Period__Value() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Value As DataRowCollection
        Dim objDR_Value As DataRow



        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        
        objDRC_Value = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Period.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_ID.GUID).Rows
        For Each objDR_Value In objDRC_Value
            If objDR_Value.Item("VAL_Int") = intPeriod Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Value.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Int.GetData(objSemItem_Period.GUID, _
                                                                          objLocalConfig.SemItem_Attribute_ID.GUID, _
                                                                          Nothing, _
                                                                          intPeriod, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then

                objSemItem_TokenAttribute_ID = New clsSemItem
                objSemItem_TokenAttribute_ID.GUID = objDRC_LogState(0).Item("GUID_Token")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        

        Return objSemItem_Result
    End Function

    Public Function del_002_Period__Value() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Period As DataRowCollection
        Dim objDR_Period As DataRow

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_Period = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Period.GUID, _
                                                                                                       objLocalConfig.SemItem_Attribute_ID.GUID).Rows

        For Each objDR_Period In objDRC_Period
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Period.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Next

        Return objSemItem_Result
    End Function
    Private Sub set_DBConnection()

        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        semtblA_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Int.Connection = objLocalConfig.Connection_DB


    End Sub
    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)
        set_DBConnection()
    End Sub
    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub
End Class
