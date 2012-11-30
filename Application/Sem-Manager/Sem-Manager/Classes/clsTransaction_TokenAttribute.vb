Public Class clsTransaction_TokenAttribute
    Private objGlobals As clsGlobals


    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Date As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DateTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Datetime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Int As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_IntTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Real As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_RealTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Time As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_TimeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Varchar255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VarcharMax As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objSemItem_Token As clsSemItem
    Private objSemItem_Attribute As clsSemItem
    Private objSemItem_TokenAttribute As clsSemItem

    Private objFrm_Parent As Windows.Forms.IWin32Window
    Private objDLG_Attribute_Bit As dlgAttribute_Bool
    Private objDLG_Attribute_Datetime As dlgAttribute_Datetime
    Private objDLG_Attribute_Int As dlgAttribute_Int
    Private objDLG_Attribute_Real As dlgAttribute_Real
    Private objDLG_Attribute_Varchar255 As dlgAttribute_Varchar255
    Private objDLG_Attribute_VarcharMAX As dlgAttribute_VarcharMax

    Private boolValSet As Boolean

    Private boolVal As Boolean
    Private dateVal As Date
    Private intVal As Integer
    Private dblVal As Double
    Private strVal As String

    Public Property Value_Bit As Boolean
        Get
            Return boolVal
        End Get
        Set(ByVal value As Boolean)
            boolVal = value
            boolValSet = True
        End Set
    End Property

    Public Property Value_Date As Date
        Get
            Return dateVal
        End Get
        Set(ByVal value As Date)
            dateVal = value
            boolValSet = True
        End Set
    End Property

    Public Property Value_Int As Integer
        Get
            Return intVal
        End Get
        Set(ByVal value As Integer)
            intVal = value
            boolValSet = True
        End Set
    End Property

    Public Property Value_Real As Integer
        Get
            Return dblVal
        End Get
        Set(ByVal value As Integer)
            dblVal = value
            boolValSet = True
        End Set
    End Property

    Public Property Value_str As String
        Get
            Return strVal
        End Get
        Set(ByVal value As String)
            strVal = value
            boolValSet = True
        End Set
    End Property

    Public Function save_001_TokenAttribute(ByVal SemItem_Token As clsSemItem, ByVal SemItem_Attribute As clsSemItem, Optional ByVal SemItem_TokenAttribute As clsSemItem = Nothing, Optional ByVal intOrderID As Integer = 1) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection


        objSemItem_Token = SemItem_Token
        objSemItem_Attribute = SemItem_Attribute
        objSemItem_TokenAttribute = SemItem_TokenAttribute

        objSemItem_Result = Nothing


        objSemItem_Result = get_Value()

        If objSemItem_Result.GUID = objGlobals.LogState_Success.GUID Then

            If Not objSemItem_TokenAttribute Is Nothing Then
                Select Case objSemItem_Attribute.GUID_Type
                    Case objGlobals.AttributeType_Bool.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          objSemItem_TokenAttribute.GUID, _
                                                                                          boolVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_Date.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Date.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          objSemItem_TokenAttribute.GUID, _
                                                                                          dateVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_Datetime.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          objSemItem_TokenAttribute.GUID, _
                                                                                          dateVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_Int.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Int.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          objSemItem_TokenAttribute.GUID, _
                                                                                          intVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_Real.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Real.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          objSemItem_TokenAttribute.GUID, _
                                                                                          dblVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_Time.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Time.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          objSemItem_TokenAttribute.GUID, _
                                                                                          dateVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_Varchar255.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Varchar255.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          objSemItem_TokenAttribute.GUID, _
                                                                                          strVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_String.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          objSemItem_TokenAttribute.GUID, _
                                                                                          strVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                End Select
            Else
                Select Case objSemItem_Attribute.GUID_Type
                    Case objGlobals.AttributeType_Bool.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          Nothing, _
                                                                                          boolVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_TokenAttribute = New clsSemItem
                            objSemItem_TokenAttribute.GUID = objDRC_LogState(0).Item("GUID_Token")
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_Date.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Date.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          Nothing, _
                                                                                          dateVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_TokenAttribute = New clsSemItem
                            objSemItem_TokenAttribute.GUID = objDRC_LogState(0).Item("GUID_Token")
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_Datetime.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          Nothing, _
                                                                                          dateVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_TokenAttribute = New clsSemItem
                            objSemItem_TokenAttribute.GUID = objDRC_LogState(0).Item("GUID_Token")
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_Int.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Int.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          Nothing, _
                                                                                          intVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_TokenAttribute = New clsSemItem
                            objSemItem_TokenAttribute.GUID = objDRC_LogState(0).Item("GUID_Token")
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_Real.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Real.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          Nothing, _
                                                                                          dblVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_TokenAttribute = New clsSemItem
                            objSemItem_TokenAttribute.GUID = objDRC_LogState(0).Item("GUID_Token")
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_Time.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Time.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          Nothing, _
                                                                                          dateVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_TokenAttribute = New clsSemItem
                            objSemItem_TokenAttribute.GUID = objDRC_LogState(0).Item("GUID_Token")
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_Varchar255.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Varchar255.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          Nothing, _
                                                                                          strVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_TokenAttribute = New clsSemItem
                            objSemItem_TokenAttribute.GUID = objDRC_LogState(0).Item("GUID_Token")
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                    Case objGlobals.AttributeType_String.GUID
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_Token.GUID, _
                                                                                          objSemItem_Attribute.GUID, _
                                                                                          Nothing, _
                                                                                          strVal, intOrderID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                            objSemItem_TokenAttribute = New clsSemItem
                            objSemItem_TokenAttribute.GUID = objDRC_LogState(0).Item("GUID_Token")
                            objSemItem_Result = objGlobals.LogState_Success
                        Else
                            objSemItem_Result = objGlobals.LogState_Error
                        End If
                End Select
            End If
        End If


        Return objSemItem_Result
    End Function

    Public Function del_001_TokenAttribute(Optional ByVal SemItem_TokenAttribute As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_TokenAttribute Is Nothing Then
            objSemItem_TokenAttribute = SemItem_TokenAttribute
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_TokenAttribute.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
            objSemItem_Result = objGlobals.LogState_Success
        Else
            objSemItem_Result = objGlobals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Private Function get_Value() As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objGlobals.LogState_Success

        Select Case objSemItem_Attribute.GUID_Type
            Case objGlobals.AttributeType_Bool.GUID
                If boolValSet = False Then
                    boolVal = False
                End If
                objDLG_Attribute_Bit = New dlgAttribute_Bool(objSemItem_Attribute.Name, objGlobals, boolVal)
                objDLG_Attribute_Bit.ShowDialog(objFrm_Parent)
                If objDLG_Attribute_Bit.DialogResult = DialogResult.OK Then
                    boolVal = objDLG_Attribute_Bit.Value
                    boolValSet = True
                Else
                    objSemItem_Result = objGlobals.LogState_Nothing
                End If

            Case objGlobals.AttributeType_Date.GUID
                If boolValSet = False Then
                    dateVal = Now
                End If
                objDLG_Attribute_Datetime = New dlgAttribute_Datetime(objSemItem_Attribute.Name, objGlobals, dateVal, True)
                objDLG_Attribute_Datetime.ShowDialog(objFrm_Parent)
                If objDLG_Attribute_Datetime.DialogResult = DialogResult.OK Then
                    dateVal = objDLG_Attribute_Datetime.Value
                    boolValSet = True
                Else
                    objSemItem_Result = objGlobals.LogState_Nothing
                End If
            Case objGlobals.AttributeType_Datetime.GUID
                If boolValSet = False Then
                    dateVal = Now
                End If
                objDLG_Attribute_Datetime = New dlgAttribute_Datetime(objSemItem_Attribute.Name, objGlobals, dateVal, True)
                objDLG_Attribute_Datetime.ShowDialog(objFrm_Parent)
                If objDLG_Attribute_Datetime.DialogResult = DialogResult.OK Then
                    dateVal = objDLG_Attribute_Datetime.Value
                    boolValSet = True
                Else
                    objSemItem_Result = objGlobals.LogState_Nothing
                End If
            Case objGlobals.AttributeType_Int.GUID
                If boolValSet = False Then
                    intVal = 0
                End If
                objDLG_Attribute_Int = New dlgAttribute_Int(objSemItem_Attribute.Name, objGlobals, intVal)
                objDLG_Attribute_Int.ShowDialog(objFrm_Parent)
                If objDLG_Attribute_Int.DialogResult = DialogResult.OK Then
                    intVal = objDLG_Attribute_Int.Value
                    boolValSet = True
                Else
                    objSemItem_Result = objGlobals.LogState_Nothing
                End If
            Case objGlobals.AttributeType_Real.GUID
                If boolValSet = False Then
                    dblVal = 0
                End If
                objDLG_Attribute_Real = New dlgAttribute_Real(objSemItem_Attribute.Name, objGlobals, dblVal)
                objDLG_Attribute_Real.ShowDialog(objFrm_Parent)
                If objDLG_Attribute_Real.DialogResult = DialogResult.OK Then
                    dblVal = objDLG_Attribute_Real.Value
                    boolValSet = True
                Else
                    objSemItem_Result = objGlobals.LogState_Nothing
                End If
            Case objGlobals.AttributeType_Time.GUID
                If boolValSet = False Then
                    dateVal = Now
                End If
                objDLG_Attribute_Datetime = New dlgAttribute_Datetime(objSemItem_Attribute.Name, objGlobals, dateVal, False)
                objDLG_Attribute_Datetime.ShowDialog(objFrm_Parent)
                If objDLG_Attribute_Datetime.DialogResult = DialogResult.OK Then
                    dateVal = objDLG_Attribute_Datetime.Value
                    boolValSet = True
                Else
                    objSemItem_Result = objGlobals.LogState_Nothing
                End If
            Case objGlobals.AttributeType_Varchar255.GUID
                If boolValSet = False Then
                    strVal = ""
                End If
                objDLG_Attribute_Varchar255 = New dlgAttribute_Varchar255(objSemItem_Attribute.Name, objGlobals, strVal)
                objDLG_Attribute_Varchar255.ShowDialog(objFrm_Parent)
                If objDLG_Attribute_Varchar255.DialogResult = DialogResult.OK Then
                    strVal = objDLG_Attribute_Varchar255.Value1
                    boolValSet = True
                Else
                    objSemItem_Result = objGlobals.LogState_Nothing
                End If
            Case objGlobals.AttributeType_String.GUID
                If boolValSet = False Then
                    strVal = ""
                End If
                objDLG_Attribute_VarcharMAX = New dlgAttribute_VarcharMax(objSemItem_Attribute.Name, objGlobals, strVal)
                objDLG_Attribute_VarcharMAX.ShowDialog(objFrm_Parent)
                If objDLG_Attribute_VarcharMAX.DialogResult = DialogResult.OK Then
                    strVal = objDLG_Attribute_VarcharMAX.Value
                    boolValSet = True
                Else
                    objSemItem_Result = objGlobals.LogState_Nothing
                End If
        End Select

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal Globals As clsGlobals, ByVal FrmParent As Windows.Forms.IWin32Window)
        objGlobals = Globals

        objFrm_Parent = FrmParent

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        Dim objConnection As Data.SqlClient.SqlConnection

        objConnection = New Data.SqlClient.SqlConnection(objGlobals.ConnectionString_User)

        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objConnection
        semprocA_DBWork_Del_TokenAttribute.Connection = objConnection
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objConnection
        semprocA_DBWork_Save_TokenAttribute_Date.Connection = objConnection
        semprocA_DBWork_Save_TokenAttribute_Datetime.Connection = objConnection
        semprocA_DBWork_Save_TokenAttribute_Int.Connection = objConnection
        semprocA_DBWork_Save_TokenAttribute_Real.Connection = objConnection
        semprocA_DBWork_Save_TokenAttribute_Time.Connection = objConnection
        semprocA_DBWork_Save_TokenAttribute_Varchar255.Connection = objConnection
        semprocA_DBWork_Save_TokenAttribute_VarcharMax.Connection = objConnection
    End Sub

End Class
