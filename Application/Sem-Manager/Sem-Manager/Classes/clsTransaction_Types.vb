Public Class clsTransaction_Types
    Private objGlobals As clsGlobals

    Private objConnection As SqlClient.SqlConnection

    Private semprocA_DBWork_Save_Type As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TypeTableAdapter
    Private semprocA_DBWork_Save_TypeRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TypeRelTableAdapter
    Private semprocA_DBWork_Save_TypeAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TypeAttributeTableAdapter
    Private semprocA_DBWork_Del_Type As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TypeTableAdapter
    Private semprocA_DBWork_Del_TypeRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Type_RelTableAdapter
    Private semprocA_DBWork_Del_TypeAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TypeAttributeTableAdapter

    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter

    Private objSemItem_Type As clsSemItem
    Private objSemItem_Type_Right As clsSemItem
    Private objSemItem_Attribute As clsSemItem
    Private intMin As Integer
    Private intMax As Integer
    Private intMax_Forw As Integer
    Private intMax_Backw As Integer

    Public Function save_001_Type(ByVal SemItem_Type As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Type As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Type = SemItem_Type

        objSemItem_Result = objGlobals.LogState_Success
        objDRC_Type = semtblA_Type.GetData_By_GUID(objSemItem_Type.GUID).Rows
        If objDRC_Type.Count = 0 Then
            objDRC_Type = semtblA_Type.GetData_By_Name(objSemItem_Type.Name).Rows
            If objDRC_Type.Count = 0 Then
                objDRC_LogState = semprocA_DBWork_Save_Type.GetData(objSemItem_Type.GUID, _
                                                                objSemItem_Type.Name, _
                                                                objSemItem_Type.GUID_Parent).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                    objSemItem_Result = objGlobals.LogState_Error
                End If
            Else
                objSemItem_Result = objGlobals.LogState_Exists
            End If
            
        Else

            objDRC_LogState = semprocA_DBWork_Save_Type.GetData(objSemItem_Type.GUID, _
                                                                objSemItem_Type.Name, _
                                                                objSemItem_Type.GUID_Parent).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
                objSemItem_Result = objGlobals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_Type(Optional ByVal SemItem_Type As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Type Is Nothing Then
            objSemItem_Type = SemItem_Type
        End If

        objDRC_LogState = semprocA_DBWork_Del_Type.GetData(objSemItem_Type.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Relation.GUID Then
            objSemItem_Result = objGlobals.LogState_Relation
        Else
            objSemItem_Result = objGlobals.LogState_Success
        End If


        Return objSemItem_Result
    End Function


    Public Function save_002_TypeRel(ByVal SemItem_Type_Right As clsSemItem, ByVal intMin As Integer, ByVal intMax_Forw As Integer, ByVal intMax_Backw As Integer, Optional ByVal SemItem_Type As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Type_Right = SemItem_Type_Right

        Me.intMin = intMin
        Me.intMax_Forw = intMax_Forw
        Me.intMax_Backw = intMax_Backw

        If Not SemItem_Type Is Nothing Then
            objSemItem_Type = SemItem_Type
        End If

        objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objSemItem_Type.GUID, _
                                                               objSemItem_Type_Right.GUID, _
                                                               objSemItem_Type_Right.GUID_Relation, _
                                                               intMin, _
                                                               intMax_Forw, _
                                                               intMax_Backw).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
            objSemItem_Result = objGlobals.LogState_Success
        Else
            objSemItem_Result = objGlobals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_TypeRel(Optional ByVal SemItem_Type As clsSemItem = Nothing, Optional ByVal SemItem_Type_Right As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Type Is Nothing Then
            objSemItem_Type = SemItem_Type
        End If

        If Not SemItem_Type_Right Is Nothing Then
            objSemItem_Type_Right = SemItem_Type_Right
        End If

        objDRC_LogState = semprocA_DBWork_Del_TypeRel.GetData(objSemItem_Type.GUID, _
                                                              objSemItem_Type_Right.GUID, _
                                                              objSemItem_Type_Right.GUID_Relation).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Relation.GUID Then
            objSemItem_Result = objGlobals.LogState_Success
        Else
            objSemItem_Result = objGlobals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_003_TypeAttribute(ByVal SemItem_Attribute As clsSemItem, ByVal intMin As Integer, ByVal intMax As Integer, Optional ByVal SemItem_Type As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        Me.intMin = intMin
        Me.intMax = intMax

        objSemItem_Attribute = SemItem_Attribute
        If Not SemItem_Type Is Nothing Then
            objSemItem_Type = SemItem_Type
        End If


        objDRC_LogState = semprocA_DBWork_Save_TypeAttribute.GetData(objSemItem_Type.GUID, _
                                                                     objSemItem_Attribute.GUID, _
                                                                     intMin, _
                                                                     intMax).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
            objSemItem_Result = objGlobals.LogState_Success
        Else
            objSemItem_Result = objGlobals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function del_003_TypeAttribute(Optional ByVal SemItem_Attribute As clsSemItem = Nothing, Optional ByVal SemItem_Type As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Attribute Is Nothing Then
            objSemItem_Attribute = SemItem_Attribute
        End If

        If Not SemItem_Type Is Nothing Then
            objSemItem_Type = SemItem_Type
        End If

        objDRC_LogState = semprocA_DBWork_Del_TypeAttribute.GetData(objSemItem_Type.GUID, _
                                                                    objSemItem_Attribute.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objGlobals.LogState_Error.GUID Then
            objSemItem_Result = objGlobals.LogState_Success
        Else
            objSemItem_Result = objGlobals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()

        objConnection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)

        semprocA_DBWork_Del_Type.Connection = objConnection
        semprocA_DBWork_Del_TypeAttribute.Connection = objConnection
        semprocA_DBWork_Del_TypeRel.Connection = objConnection
        semprocA_DBWork_Save_Type.Connection = objConnection
        semprocA_DBWork_Save_TypeAttribute.Connection = objConnection
        semprocA_DBWork_Save_TypeRel.Connection = objConnection

        semtblA_Type.Connection = objConnection

    End Sub
End Class
