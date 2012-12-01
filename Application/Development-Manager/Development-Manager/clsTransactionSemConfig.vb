Imports Sem_Manager
Public Class clsTransactionSemConfig
    Private semtblA_TokenToken As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_SemItemsToExportChildren_Of_SoftwareDevelopment As New ds_SemanticConfigTableAdapters.proc_SemItemsToExportChildren_Of_SoftwareDevelopmentTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private objSemItem_SemItemsToExport As New clsSemItem
    Private objSemItem_ConfigItem As clsSemItem
    Private objSemItem_Development As clsSemItem
    Private objSemItem_ExportMode As clsSemItem
    Private objLocalConfig As clsLocalConfig

    Public Property SemItem_ExportMode() As clsSemItem
        Get
            Return objSemItem_ExportMode
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_ExportMode = value
        End Set
    End Property
    Public Property SemItem_SemItemToExport() As clsSemItem
        Get
            Return objSemItem_SemItemsToExport
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_SemItemsToExport = value
        End Set
    End Property

    Public Property SemItem_ConfigItem() As clsSemItem
        Get
            Return objSemItem_ConfigItem
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_ConfigItem = value
        End Set
    End Property

    Public Property SemItem_Development() As clsSemItem
        Get
            Return objSemItem_Development
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_Development = value
        End Set
    End Property

    Public Function save_001_SemItems_To_Export(ByVal SemItem_ConfigItem As clsSemItem, ByVal SemItem_Development As clsSemItem) As clsSemItem
        Dim objDRC_SemItemToExport As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_ConfigItem = SemItem_ConfigItem
        objSemItem_Development = SemItem_Development

        objDRC_SemItemToExport = procA_SemItemsToExportChildren_Of_SoftwareDevelopment.GetData(objLocalConfig.SemItem_Type_Sem_Items_to_expot_with_Children.GUID, _
                                                                                               objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                                               objLocalConfig.SemItem_Type_DevelopmentConfigItem.GUID, _
                                                                                               objLocalConfig.SemItem_Type_Export_Mode.GUID, _
                                                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                               objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                               objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                                               objSemItem_Development.GUID, _
                                                                                               objSemItem_ConfigItem.GUID).Rows
        If objDRC_SemItemToExport.Count = 0 Then
            objSemItem_SemItemsToExport = New clsSemItem
            objSemItem_SemItemsToExport.GUID = Guid.NewGuid
            objSemItem_SemItemsToExport.Name = objSemItem_ConfigItem.Name & "\" & objSemItem_Development.Name
            If objSemItem_SemItemsToExport.Name.Length > 255 Then
                objSemItem_SemItemsToExport.Name = objSemItem_SemItemsToExport.Name.Substring(0, 254)
            End If
            objSemItem_SemItemsToExport.GUID_Parent = objLocalConfig.SemItem_Type_Sem_Items_to_expot_with_Children.GUID
            objSemItem_SemItemsToExport.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_SemItemsToExport.GUID, _
                                                                 objSemItem_SemItemsToExport.Name, _
                                                                 objSemItem_SemItemsToExport.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If


        Else
            objSemItem_SemItemsToExport = New clsSemItem
            objSemItem_SemItemsToExport.GUID = objDRC_SemItemToExport(0).Item("GUID_Sem_Items_to_expot_with_Children")
            objSemItem_SemItemsToExport.Name = objDRC_SemItemToExport(0).Item("Name_Sem_Items_to_expot_with_Children")
            objSemItem_SemItemsToExport.GUID_Parent = objLocalConfig.SemItem_Type_Sem_Items_to_expot_with_Children.GUID
            objSemItem_SemItemsToExport.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_SemItems_To_Export() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_SemItemsToExport.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Delete
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_SemItemToExport_To_ConfigItem() As clsSemItem
        Dim objDRC_SemItemToExport_To_ConfigItem As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_SemItemToExport_To_ConfigItem = semtblA_TokenToken.GetData_By_GUIDs(objSemItem_SemItemsToExport.GUID, _
                                                                                   objSemItem_ConfigItem.GUID, _
                                                                                   objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_SemItemToExport_To_ConfigItem.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_SemItemsToExport.GUID, _
                                                                    objSemItem_ConfigItem.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_contains.GUID, 0).Rows

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_SemItemToExport_To_ConfigItem() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_SemItemsToExport.GUID, _
                                                               objSemItem_ConfigItem.GUID, _
                                                               objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_003_SemItemToExport_To_SoftwareDevelopment() As clsSemItem
        Dim objDRC_SemItemToExport_To_ConfigItem As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_SemItemToExport_To_ConfigItem = semtblA_TokenToken.GetData_By_GUIDs(objSemItem_SemItemsToExport.GUID, _
                                                                                   objSemItem_Development.GUID, _
                                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        If objDRC_SemItemToExport_To_ConfigItem.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_SemItemsToExport.GUID, _
                                                                    objSemItem_Development.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_SemItemToExport_To_SoftwareDevelopment() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_SemItemsToExport.GUID, _
                                                               objSemItem_Development.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_004_SemItemToExport_To_ExportMode(ByVal SemItem_ExportMode As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem = Nothing
        Dim objDRC_ExportMode As DataRowCollection
        Dim objDR_ExportMode As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim boolAdd As Boolean
        objSemItem_ExportMode = SemItem_ExportMode
        objDRC_ExportMode = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_SemItemsToExport.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                          objLocalConfig.SemItem_Type_Export_Mode.GUID).Rows
        boolAdd = True
        For Each objDR_ExportMode In objDRC_ExportMode
            If objDR_ExportMode.Item("GUID_Token_Right") = objSemItem_ExportMode.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_SemItemsToExport.GUID, _
                                                                       objDR_ExportMode.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    boolAdd = False
                    Exit For
                End If
            End If
        Next

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_SemItemsToExport.GUID, _
                                                                   objSemItem_ExportMode.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If



        Return objSemItem_Result
    End Function

    

    Public Function del_004_SemItemToExport_To_ExportMode() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ExportMode As DataRowCollection
        Dim objDR_ExportMode As DataRow

        Dim objSemItem_Result As clsSemItem



        objDRC_ExportMode = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_SemItemsToExport.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                          objLocalConfig.SemItem_Type_Export_Mode.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_ExportMode In objDRC_ExportMode

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_SemItemsToExport.GUID, _
                                                                   objDR_ExportMode.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function get_SemItemsToExport() As clsSemItem
        Dim objDRC_SemItemToExport As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        objDRC_SemItemToExport = procA_SemItemsToExportChildren_Of_SoftwareDevelopment.GetData(objLocalConfig.SemItem_Type_Sem_Items_to_expot_with_Children.GUID, _
                                                                                               objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                                               objLocalConfig.SemItem_Type_DevelopmentConfigItem.GUID, _
                                                                                               objLocalConfig.SemItem_Type_Export_Mode.GUID, _
                                                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                               objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                               objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                                               objSemItem_Development.GUID, _
                                                                                               objSemItem_ConfigItem.GUID).Rows
        If objDRC_SemItemToExport.Count = 0 Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        Else
            objSemItem_SemItemsToExport = New clsSemItem
            objSemItem_SemItemsToExport.GUID = objDRC_SemItemToExport(0).Item("GUID_Sem_Items_to_expot_with_Children")
            objSemItem_SemItemsToExport.Name = objDRC_SemItemToExport(0).Item("Name_Sem_Items_to_expot_with_Children")
            objSemItem_SemItemsToExport.GUID_Parent = objLocalConfig.SemItem_Type_Sem_Items_to_expot_with_Children.GUID
            objSemItem_SemItemsToExport.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_Connection()
    End Sub

    Private Sub set_Connection()

        semtblA_TokenToken.Connection = objLocalConfig.Connection_DB

        procA_SemItemsToExportChildren_Of_SoftwareDevelopment.Connection = objLocalConfig.Connection_Plugin
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
