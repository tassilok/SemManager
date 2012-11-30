Public Class clsTransaction_TreeOfToken
    Private objLocalConfig As clsLocalConfig_SemManager
    Private objConnection As SqlClient.SqlConnection

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private objSemItem_Token_Children As clsSemItem
    Private objSemItem_Token_Parent As clsSemItem

    Public Function save_001_Token(ByVal SemItem_Token_Children As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Token_Children = SemItem_Token_Children

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Token_Children.GUID, _
                                                             objSemItem_Token_Children.Name, _
                                                             objSemItem_Token_Children.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_Token(Optional ByVal SemItem_Token_Children As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Token_Children Is Nothing Then
            objSemItem_Token_Children = SemItem_Token_Children
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Token_Children.GUID).Rows
        Select Case objDRC_LogState(0).Item("GUID_Token")
            Case objLocalConfig.Globals.LogState_Error.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            Case objLocalConfig.Globals.LogState_Relation.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Relation
            Case Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End Select


        Return objSemItem_Result
    End Function

    Public Function save_002_TokenRel(ByVal SemItem_Token_Parent As clsSemItem, Optional ByVal SemItem_Token_Children As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim intOrderID As Integer

        objSemItem_Token_Parent = SemItem_Token_Parent
        If Not SemItem_Token_Children Is Nothing Then
            objSemItem_Token_Children = SemItem_Token_Children
        End If
        intOrderID = 0
        If objSemItem_Token_Parent.Direction = objSemItem_Token_Parent.Direction_LeftRight Then
            If objSemItem_Token_Parent.Mark = True Then
                intOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_Token_Parent.GUID, _
                                                                    objSemItem_Token_Parent.GUID_Parent, _
                                                                    objSemItem_Token_Parent.GUID_Related)
            End If
            intOrderID = intOrderID + 1
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Token_Parent.GUID, _
                                                                    objSemItem_Token_Children.GUID, _
                                                                    objSemItem_Token_Parent.GUID_Related,
                                                                    intOrderID).Rows

        Else
            If objSemItem_Token_Parent.Mark = True Then
                intOrderID = funcA_TokenToken.RightLeft_Max_OrderID_By_GUIDs(objSemItem_Token_Parent.GUID, _
                                                                    objSemItem_Token_Parent.GUID_Parent, _
                                                                    objSemItem_Token_Parent.GUID_Related)
            End If
            intOrderID = intOrderID + 1
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Token_Children.GUID, _
                                                                    objSemItem_Token_Parent.GUID, _
                                                                    objSemItem_Token_Parent.GUID_Related,
                                                                    intOrderID).Rows
        End If

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function del_002_TokenRel(Optional ByVal SemItem_Token_Parent As clsSemItem = Nothing, Optional ByVal SemItem_Token_Children As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Token_Parent Is Nothing Then
            objSemItem_Token_Parent = SemItem_Token_Parent
        End If

        If Not SemItem_Token_Children Is Nothing Then
            objSemItem_Token_Children = SemItem_Token_Children
        End If
        If objSemItem_Token_Parent.Direction = objSemItem_Token_Parent.Direction_LeftRight Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Token_Parent.GUID, _
                                                                   objSemItem_Token_Children.GUID, _
                                                                   objSemItem_Token_Parent.GUID_Related).Rows


        Else
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Token_Children.GUID, _
                                                                   objSemItem_Token_Parent.GUID, _
                                                                   objSemItem_Token_Parent.GUID_Related).Rows
        End If

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function
    Public Sub New(ByVal LocalConfig As clsLocalConfig_SemManager)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objConnection = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)

        semprocA_DBWork_Save_Token.Connection = objConnection
        semprocA_DBWork_Del_Token.Connection = objConnection
        semprocA_DBWork_Save_TokenRel.Connection = objConnection
        semprocA_DBWork_Del_TokenRel.Connection = objConnection

        funcA_TokenToken.Connection = objConnection
    End Sub
End Class
