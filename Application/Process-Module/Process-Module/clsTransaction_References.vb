Imports Sem_Manager
Public Class clsTransaction_References
    Private objLocalConfig As clsLocalConfig

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_DBWork_Del_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter

    Private procA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private procA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private procA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter

    Private objSemItem_Process_Or_Log As clsSemItem = Nothing
    Private objSemItem_ProcessRef As clsSemItem = Nothing
    Private objSemItems_Selected() As clsSemItem

    Private semtblT_SimpleItems As New ds_SemDB.semtbl_TokenDataTable
    Private objSemItem_RelationType As clsSemItem
    Private intDoneCount As Integer

    Public Property SemItem_Process_Or_Log As clsSemItem
        Get
            Return objSemItem_Process_Or_Log
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_Process_Or_Log = value
        End Set
    End Property
    Public Property SemItem_ProcessRef As clsSemItem
        Get
            Return objSemItem_ProcessRef
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_ProcessRef = value
        End Set
    End Property

    Public ReadOnly Property SemItems_Selected As clsSemItem()
        Get
            Return objSemItems_Selected
        End Get
    End Property

    Private Function get_ProcessRef() As clsSemItem
        Dim objDRC_ProcessRef As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        objDRC_ProcessRef = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Process_Or_Log.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                          objLocalConfig.SemItem_Type_Process_References.GUID).Rows
        If objDRC_ProcessRef.Count > 0 Then
            objSemItem_ProcessRef = New clsSemItem
            objSemItem_ProcessRef.GUID = objDRC_ProcessRef(0).Item("GUID_Token_Right")
            objSemItem_ProcessRef.Name = objDRC_ProcessRef(0).Item("Name_Token_Right")
            objSemItem_ProcessRef.GUID_Parent = objDRC_ProcessRef(0).Item("GUID_Type_Right")
            objSemItem_ProcessRef.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function save_001_ProcessRef(ByVal SemItem_Process_Or_Log As clsSemItem) As clsSemItem
        Dim objDRC_ProcessRef As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As New clsSemItem
        objSemItem_Process_Or_Log = SemItem_Process_Or_Log
        objDRC_ProcessRef = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Process_Or_Log.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                          objLocalConfig.SemItem_Type_Process_References.GUID).Rows
        If objDRC_ProcessRef.Count > 0 Then
            objSemItem_ProcessRef = New clsSemItem
            objSemItem_ProcessRef.GUID = objDRC_ProcessRef(0).Item("GUID_Token_right")
            objSemItem_ProcessRef.Name = objDRC_ProcessRef(0).Item("Name_Token_Right")
            objSemItem_ProcessRef.GUID_Parent = objDRC_ProcessRef(0).Item("GUID_Type_Right")
            objSemItem_ProcessRef.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_ProcessRef = New clsSemItem
            objSemItem_ProcessRef.GUID = Guid.NewGuid
            objSemItem_ProcessRef.Name = objSemItem_Process_Or_Log.Name
            objSemItem_ProcessRef.GUID_Parent = objLocalConfig.SemItem_Type_Process_References.GUID
            objSemItem_ProcessRef.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_ProcessRef.GUID, _
                                                                 objSemItem_ProcessRef.Name, _
                                                                 objSemItem_ProcessRef.GUID_Parent, True).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Process_Or_Log.GUID, _
                                                                        objSemItem_ProcessRef.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_contains.GUID, 0).Rows

                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    semprocA_DBWork_Del_Token.GetData(objSemItem_ProcessRef.GUID)
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If

            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If


        End If

        Return objSemItem_Result

    End Function

    Public Function del_001_ProcessRef(Optional ByVal SemItem_Process_Or_Log As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_ProcessRef As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_ProcessRef As DataRow

        If Not SemItem_Process_Or_Log Is Nothing Then
            objSemItem_Process_Or_Log = SemItem_Process_Or_Log
        End If

        objDRC_ProcessRef = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Process_Or_Log.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                         objLocalConfig.SemItem_Type_Process_References.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_ProcessRef In objDRC_ProcessRef
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Process_Or_Log.GUID, _
                                                                   objDR_ProcessRef.Item("GUID_Token_right"), _
                                                                   objLocalConfig.SemItem_RelationType_contains.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objDR_ProcessRef.Item("GUID_Token_right")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next
        Return objSemItem_Result
    End Function

    Public Function save_002_SimpleItems(ByVal _semtblT_Items As ds_SemDB.semtbl_TokenDataTable, ByVal SemItem_RelationType As clsSemItem, Optional ByVal SemItem_ProcessRef As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDR_SimpleItems As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ProcessRef Is Nothing Then
            objSemItem_ProcessRef = SemItem_ProcessRef
        End If
        objSemItem_RelationType = SemItem_RelationType
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If objSemItem_ProcessRef Is Nothing Then
            objSemItem_Result = get_ProcessRef()
        End If
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            semtblT_SimpleItems = _semtblT_Items

            objSemItem_Result = objLocalConfig.Globals.LogState_Success

            For Each objDR_SimpleItems In semtblT_SimpleItems.Rows
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ProcessRef.GUID, _
                                                                        objDR_SimpleItems.Item("GUID_Token"), _
                                                                        objSemItem_RelationType.GUID, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        End If





        Return objSemItem_Result
    End Function

    Public Function del_002_SimpleItems(Optional ByVal _semtblT_SimpleItems As ds_SemDB.semtbl_TokenDataTable = Nothing, Optional ByVal SemItem_RelationType As clsSemItem = Nothing, Optional ByVal SemItem_ProcessRef As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDR_SimpleItems As DataRow
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ProcessRef Is Nothing Then
            objSemItem_ProcessRef = SemItem_ProcessRef
        End If
        If Not _semtblT_SimpleItems Is Nothing Then
            semtblT_SimpleItems = _semtblT_SimpleItems
        End If
        If Not SemItem_RelationType Is Nothing Then
            objSemItem_RelationType = SemItem_RelationType
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If SemItem_ProcessRef Is Nothing Then
            objSemItem_Result = get_ProcessRef()
        End If
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            For Each objDR_SimpleItems In semtblT_SimpleItems.Rows
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ProcessRef.GUID, _
                                                                       objDR_SimpleItems.Item("GUID_Token"), _
                                                                       objSemItem_RelationType.GUID).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        End If


        Return objSemItem_Result
    End Function

    Public Function save_003_ORRef(ByVal SemItems_Selected() As clsSemItem, ByVal SemItem_RelationType As clsSemItem, Optional ByVal SemItem_ProcessRef As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        Dim objDRC_LogState As DataRowCollection
        Dim i As Integer

        If Not SemItem_ProcessRef Is Nothing Then
            objSemItem_ProcessRef = SemItem_ProcessRef
        End If

        objSemItem_RelationType = SemItem_RelationType
        objSemItems_Selected = SemItems_Selected

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For i = 0 To objSemItems_Selected.Count - 1

            Select Case objSemItems_Selected(i).GUID_Type
                Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                    objDRC_LogState = procA_DBWork_Save_OR_Attribute.GetData(objSemItems_Selected(i).GUID).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItems_Selected(i).GUID_Related = objDRC_LogState(0).Item("GUID_ObjectReference")
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                    objDRC_LogState = procA_DBWork_Save_OR_RelationType.GetData(objSemItems_Selected(i).GUID).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItems_Selected(i).GUID_Related = objDRC_LogState(0).Item("GUID_ObjectReference")
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objDRC_LogState = procA_DBWork_Save_OR_Token.GetData(objSemItems_Selected(i).GUID).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItems_Selected(i).GUID_Related = objDRC_LogState(0).Item("GUID_ObjectReference")
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                    objDRC_LogState = procA_DBWork_Save_OR_Type.GetData(objSemItems_Selected(i).GUID).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItems_Selected(i).GUID_Related = objDRC_LogState(0).Item("GUID_ObjectReference")
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
            End Select
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

            For intDoneCount = 0 To objSemItems_Selected.Count - 1
                objDRC_LogState = semprocA_DBWork_Save_Token_OR.GetData(objSemItem_ProcessRef.GUID, _
                                                                        objSemItems_Selected(intDoneCount).GUID_Related, _
                                                                        objSemItem_RelationType.GUID, 1).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next

        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_ORRef(Optional ByVal SemItems_Selected() As clsSemItem = Nothing, Optional ByVal SemItem_RelationType As clsSemItem = Nothing, Optional ByVal SemItem_ProcessRef As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ProcessRef Is Nothing Then
            objSemItem_ProcessRef = SemItem_ProcessRef
        End If
        If Not objSemItem_RelationType Is Nothing Then
            objSemItem_RelationType = SemItem_RelationType
        End If

        If Not objSemItems_Selected Is Nothing Then
            intDoneCount = 0
            objSemItems_Selected = SemItems_Selected
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If intDoneCount = 0 Then
            For i = 0 To objSemItems_Selected.Count - 1
                objDRC_LogState = semprocA_DBWork_Del_Token_OR.GetData(objSemItem_ProcessRef.GUID, _
                                                                       objSemItems_Selected(i).GUID_Related, _
                                                                       objSemItem_RelationType.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        Else
            For i = intDoneCount To 0 Step -1
                objDRC_LogState = semprocA_DBWork_Del_Token_OR.GetData(objSemItem_ProcessRef.GUID, _
                                                                       objSemItems_Selected(i).GUID_Related, _
                                                                       objSemItem_RelationType.GUID).Rows
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
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token_OR.Connection = objLocalConfig.Connection_DB

        procA_DBWork_Save_OR_Attribute.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_RelationType.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Type.Connection = objLocalConfig.Connection_DB
    End Sub

End Class
