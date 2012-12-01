Imports Sem_Manager
Imports RDF_Module
Public Class UserControl_SemanticConfig
    Private funcA_Development_ConfigItem As New ds_SemanticConfigTableAdapters.func_Development_ConfigItemTableAdapter
    Private procA_related_ConfigItems_By_GUIDDevelopment As New ds_SemanticConfigTableAdapters.proc_related_ConfigItems_By_GUIDDevelopmentTableAdapter
    Private procT_related_ConfigItems_By_GUIDDevelopment As New ds_SemanticConfig.proc_related_ConfigItems_By_GUIDDevelopmentDataTable

    Private objFrmCodeGenerator As frmCodeGenerator

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private procA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private procA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private procA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private procA_Development_ConfigItem_By_GUIDObjectReference As New ds_SemanticConfigTableAdapters.proc_Development_ConfigItem_By_GUIDObjectReferenceTableAdapter
    Private procA_DevelopmentConfig_ConfigItem_Name_Token As New ds_SemanticConfigTableAdapters.proc_DevelopmentConfig_ConfigItem_Name_TokenTableAdapter
    Private procA_SemItemsToExportChildren_Of_SoftwareDevelopment As New ds_SemanticConfigTableAdapters.proc_SemItemsToExportChildren_Of_SoftwareDevelopmentTableAdapter

    Private semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter

    Private objFrmSemManager As frmSemManager
    Private objLogWork_Local As New clsLogWork_Local
    Private objTransaction_SemConfig As clsTransactionSemConfig
    Private objRDFWork As RDF_Module.clsRDFWork

    Private objSemItem_Development As clsSemItem

    Public Sub initialize(ByVal SemItem_Development As clsSemItem)
        objSemItem_Development = SemItem_Development
        ToolStripButton_AddConfigItem.Enabled = True
        ToolStripButton_ShowCode.Enabled = True
        fill_ConfigItems()
    End Sub
    Private Sub set_DBConnection()
        funcA_Development_ConfigItem.Connection = objLocalConfig.Connection_Plugin
        procA_DBWork_Save_OR_Attribute.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_RelationType.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Type.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        procA_related_ConfigItems_By_GUIDDevelopment.Connection = objLocalConfig.Connection_Plugin
        procA_Development_ConfigItem_By_GUIDObjectReference.Connection = objLocalConfig.Connection_Plugin
        procA_DevelopmentConfig_ConfigItem_Name_Token.Connection = objLocalConfig.Connection_Plugin
        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB
        procA_SemItemsToExportChildren_Of_SoftwareDevelopment.Connection = objLocalConfig.Connection_Plugin

        semtblA_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_RelationType.Connection = objLocalConfig.Connection_DB
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB

        objRDFWork = New clsRDFWork(objLocalConfig.Globals)
        objTransaction_SemConfig = New clsTransactionSemConfig(objLocalConfig)
    End Sub

    Private Sub fill_ConfigItems()
        procA_related_ConfigItems_By_GUIDDevelopment.Fill(procT_related_ConfigItems_By_GUIDDevelopment, _
                                                          objLocalConfig.SemItem_Type_DevelopmentConfig.GUID, _
                                                          objLocalConfig.SemItem_Type_DevelopmentConfigItem.GUID, _
                                                          objLocalConfig.SemItem_Type_Sem_Items_to_expot_with_Children.GUID, _
                                                          objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                          objLocalConfig.SemItem_Type_Export_Mode.GUID, _
                                                          objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                          objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                          objLocalConfig.SemItem_RelationType_needs.GUID, _
                                                          objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                          objSemItem_Development.GUID)
        BindingSource_ConfigItems.DataSource = procT_related_ConfigItems_By_GUIDDevelopment
        
        DataGridView_ConfigItems.DataSource = BindingSource_ConfigItems
        DataGridView_ConfigItems.Columns(0).Visible = False
        DataGridView_ConfigItems.Columns(1).Visible = False
        DataGridView_ConfigItems.Columns(2).Visible = False
        DataGridView_ConfigItems.Columns(3).Visible = False
        DataGridView_ConfigItems.Columns(4).Visible = False
        DataGridView_ConfigItems.Columns(5).Visible = False
        DataGridView_ConfigItems.Columns(6).Visible = False
        DataGridView_ConfigItems.Columns(7).Visible = False
        DataGridView_ConfigItems.Columns(8).Visible = False
        DataGridView_ConfigItems.Columns(9).Width = 300
        DataGridView_ConfigItems.Columns(10).Visible = False
        ToolStripLabel_Count.Text = DataGridView_ConfigItems.RowCount
        ToolStripButton_ExportRDF.Enabled = True
    End Sub

    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        ToolStripButton_AddConfigItem.Enabled = False
        ToolStripButton_RemoveConfigItem.Enabled = False
        ToolStripButton_ShowCode.Enabled = False
        ToolStripButton_ExportRDF.Enabled = False
        set_DBConnection()
    End Sub

    Private Sub DataGridView_ConfigItems_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_ConfigItems.SelectionChanged
        If DataGridView_ConfigItems.SelectedRows.Count = 1 Then
            ToolStripButton_RemoveConfigItem.Enabled = True
        Else
            ToolStripButton_RemoveConfigItem.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton_AddConfigItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddConfigItem.Click

        Dim objDGVSRC_Selected As DataGridViewSelectedRowCollection
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ConfigItem As DataRowCollection
        Dim objDRC_Token As DataRowCollection
        Dim objDRC_Config As DataRowCollection
        Dim objSemItems_Selected() As clsSemItem
        Dim objSemItem_Selected As clsSemItem
        Dim objSemItem_Config As clsSemItem

        Dim GUID_ConfigItem_Or As Guid

        Dim strPrefix_ConfigItem As String
        Dim strRowName_GUID As String
        Dim strRowName_Name As String
        Dim strName_ConfigItem As String


        Dim intCount As Integer
        Dim intNr As Integer = 0

        objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)

        If objFrmSemManager.DialogResult = DialogResult.OK Then
            objDRC_Config = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Development.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_needs.GUID, _
                                                                          objLocalConfig.SemItem_Type_DevelopmentConfig.GUID).Rows

            If objDRC_Config.Count > 0 Then
                objSemItem_Config = New clsSemItem
                objSemItem_Config.GUID = objDRC_Config(0).Item("GUID_Token_Right")
                objSemItem_Config.Name = objDRC_Config(0).Item("Name_Token_Right")
                objSemItem_Config.GUID_Parent = objLocalConfig.SemItem_Type_DevelopmentConfig.GUID
                objSemItem_Config.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            Else
                objSemItem_Config = New clsSemItem
                objSemItem_Config.GUID = Guid.NewGuid
                objSemItem_Config.Name = objSemItem_Development.Name
                objSemItem_Config.GUID_Parent = objLocalConfig.SemItem_Type_DevelopmentConfig.GUID
                objSemItem_Config.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Config.new_Item = True
            End If
            If objFrmSemManager.Applied_SemItems = True Then
                objSemItems_Selected = objFrmSemManager.SemItems_Selected
                intCount = objSemItems_Selected.Length
                For Each objSemItem_Selected In objSemItems_Selected


                    objDRC_LogState = procA_DBWork_Save_OR_Type.GetData(objSemItem_Selected.GUID).Rows

                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Exists.GUID Or _
                        objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        strName_ConfigItem = ""
                        Select Case objSemItem_Selected.GUID_Type
                            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                strName_ConfigItem = objSemItem_Config.Name

                            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                objDRC_ConfigItem = procA_DevelopmentConfig_ConfigItem_Name_Token.GetData(objSemItem_Selected.GUID).Rows
                                strName_ConfigItem = objDRC_ConfigItem(0).Item("Name_ConfigItem")

                            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                                strName_ConfigItem = objSemItem_Selected.Name
                            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                                strName_ConfigItem = objSemItem_Selected.Name
                        End Select


                        GUID_ConfigItem_Or = objDRC_LogState(0).Item("GUID_ObjectReference")
                        objDRC_ConfigItem = procA_Development_ConfigItem_By_GUIDObjectReference.GetData(objLocalConfig.SemItem_Type_DevelopmentConfigItem.GUID, _
                                                                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                                        GUID_ConfigItem_Or).Rows
                        strPrefix_ConfigItem = objLocalConfig.Globals.ObjectReferenceType_Type.Name
                        strRowName_GUID = "GUID_Type"
                        strRowName_Name = "Name_Type"
                        If save_ConfigItem(objDRC_ConfigItem, objSemItem_Config, GUID_ConfigItem_Or, strName_ConfigItem, strRowName_GUID, strRowName_Name, strPrefix_ConfigItem) = True Then
                            intNr = intNr + 1
                        End If
                    End If

                Next
                If intNr < intCount Then
                    MsgBox("Es wurden nur " & intNr & " von " & intCount & " Items importiert!", MsgBoxStyle.Exclamation)
                End If
                objLogWork_Local.log_Entry(objSemItem_Development, objLocalConfig.SemItem_Token_LogState_Changed, True, objLocalConfig.SemItem_Token_LogState_ConfigItemAdded.Name)
            Else
                objDGVSRC_Selected = objFrmSemManager.SelectedRows_Items
                intCount = objDGVSRC_Selected.Count
                For Each objDGVR_Selected In objDGVSRC_Selected
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    Select Case objFrmSemManager.SelectedItems_TypeGUID
                        Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                            objDRC_LogState = procA_DBWork_Save_OR_Attribute.GetData(objDRV_Selected.Item("GUID_Attribute")).Rows
                            GUID_ConfigItem_Or = objDRC_LogState(0).Item("GUID_ObjectReference")
                            objDRC_ConfigItem = procA_Development_ConfigItem_By_GUIDObjectReference.GetData(objLocalConfig.SemItem_Type_DevelopmentConfigItem.GUID, _
                                                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                                            GUID_ConfigItem_Or).Rows
                            strName_ConfigItem = objDRV_Selected.Item("Name_Attribute")


                            strPrefix_ConfigItem = objLocalConfig.Globals.ObjectReferenceType_Attribute.Name
                            strRowName_GUID = "GUID_Attribute"
                            strRowName_Name = "Name_Attribute"
                            If save_ConfigItem(objDRC_ConfigItem, objSemItem_Config, GUID_ConfigItem_Or, strName_ConfigItem, strRowName_GUID, strRowName_Name, strPrefix_ConfigItem) = True Then
                                intNr = intNr + 1
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                            objDRC_LogState = procA_DBWork_Save_OR_RelationType.GetData(objDRV_Selected.Item("GUID_RelationType")).Rows
                            GUID_ConfigItem_Or = objDRC_LogState(0).Item("GUID_ObjectReference")
                            objDRC_ConfigItem = procA_Development_ConfigItem_By_GUIDObjectReference.GetData(objLocalConfig.SemItem_Type_DevelopmentConfigItem.GUID, _
                                                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                                            GUID_ConfigItem_Or).Rows

                            strName_ConfigItem = objDRV_Selected.Item("Name_RelationType")

                            strPrefix_ConfigItem = objLocalConfig.Globals.ObjectReferenceType_RelationType.Name
                            strRowName_GUID = "GUID_RelationType"
                            strRowName_Name = "Name_RelationType"
                            If save_ConfigItem(objDRC_ConfigItem, objSemItem_Config, GUID_ConfigItem_Or, strName_ConfigItem, strRowName_GUID, strRowName_Name, strPrefix_ConfigItem) = True Then
                                intNr = intNr + 1
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objDRC_LogState = procA_DBWork_Save_OR_Token.GetData(objDRV_Selected.Item("GUID_Token")).Rows
                            GUID_ConfigItem_Or = objDRC_LogState(0).Item("GUID_ObjectReference")
                            objDRC_ConfigItem = procA_Development_ConfigItem_By_GUIDObjectReference.GetData(objLocalConfig.SemItem_Type_DevelopmentConfigItem.GUID, _
                                                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                                            GUID_ConfigItem_Or).Rows
                            objDRC_Token = procA_DevelopmentConfig_ConfigItem_Name_Token.GetData(objDRV_Selected.Item("GUID_Token")).Rows
                            strName_ConfigItem = objDRC_Token(0).Item("Name_ConfigItem")

                            strPrefix_ConfigItem = objLocalConfig.Globals.ObjectReferenceType_Token.Name
                            strRowName_GUID = "GUID_Token"
                            strRowName_Name = "Name_Token"
                            If save_ConfigItem(objDRC_ConfigItem, objSemItem_Config, GUID_ConfigItem_Or, strName_ConfigItem, strRowName_GUID, strRowName_Name, strPrefix_ConfigItem) = True Then
                                intNr = intNr + 1
                            End If
                    End Select


                Next
                If intNr < intCount Then
                    MsgBox("Es wurden nur " & intNr & " von " & intCount & " Items importiert!", MsgBoxStyle.Exclamation)
                End If
                objLogWork_Local.log_Entry(objSemItem_Development, objLocalConfig.SemItem_Token_LogState_Changed, True, objLocalConfig.SemItem_Token_LogState_ConfigItemAdded.Name)
            End If
        End If
        fill_ConfigItems()
    End Sub
    Private Function save_ConfigItem(ByVal objDRC_ConfigItem As DataRowCollection, ByVal objSemItem_Config As clsSemItem, ByVal GUID_ConfigItem_Or As Guid, ByVal strName_ConfigItem As String, ByVal strRowName_GUID As String, ByVal strRowName_Name As String, ByVal strPrefix_ConfigItem As String) As Boolean
        Dim objSemItem_ConfigItem As clsSemItem
        Dim objSemItem_LogEntry As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        Dim boolRelate As Boolean
        Dim boolResult As Boolean

        If objDRC_ConfigItem.Count = 0 Then
            objSemItem_ConfigItem = New clsSemItem
            objSemItem_ConfigItem.GUID = Guid.NewGuid
            objSemItem_ConfigItem.Name = strName_ConfigItem
            strName_ConfigItem = ""
            For i = 0 To objSemItem_ConfigItem.Name.Length - 1
                Select Case objSemItem_ConfigItem.Name.Substring(i, 1)
                    Case "a" To "z", "A" To "Z", "0" To "9"
                        strName_ConfigItem = strName_ConfigItem & objSemItem_ConfigItem.Name.Substring(i, 1)
                    Case Else
                        strName_ConfigItem = strName_ConfigItem & "_"
                End Select
            Next
            strName_ConfigItem = strPrefix_ConfigItem & "_" & strName_ConfigItem
            objSemItem_ConfigItem.Name = strName_ConfigItem
            objSemItem_ConfigItem.GUID_Parent = objLocalConfig.SemItem_Type_DevelopmentConfigItem.GUID
            objSemItem_ConfigItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_ConfigItem.GUID, objSemItem_ConfigItem.Name, objSemItem_ConfigItem.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then

                objDRC_LogState = semprocA_DBWork_Save_Token_OR.GetData(objSemItem_ConfigItem.GUID, GUID_ConfigItem_Or, objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    boolRelate = True
                Else
                    semprocA_DBWork_Del_Token.GetData(objSemItem_ConfigItem.GUID)
                End If

            End If

        Else
            objSemItem_ConfigItem = New clsSemItem
            objSemItem_ConfigItem.GUID = objDRC_ConfigItem(0).Item("GUID_Token_ConfigItem")
            objSemItem_ConfigItem.Name = objDRC_ConfigItem(0).Item("Name_Token_ConfigItem")
            objSemItem_ConfigItem.GUID_Parent = objLocalConfig.SemItem_Type_DevelopmentConfigItem.GUID
            objSemItem_ConfigItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            boolRelate = True
        End If

        If boolRelate = True Then
            If objSemItem_Config.new_Item = True Then
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Config.GUID, objSemItem_Config.Name, objSemItem_Config.GUID_Parent, True).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    boolRelate = False
                Else
                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development.GUID, objSemItem_Config.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        objSemItem_Config.new_Item = False
                    Else
                        semprocA_DBWork_Del_Token.GetData(objSemItem_Config.GUID)
                        MsgBox("Die Konfiguration kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        boolRelate = False
                    End If
                End If


            End If

            If boolRelate = True Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Config.GUID, objSemItem_ConfigItem.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then

                    boolResult = True
                End If
            End If


        End If
        Return boolResult
    End Function

    Private Sub ToolStripButton_ShowCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ShowCode.Click
        objFrmCodeGenerator = New frmCodeGenerator(DataGridView_ConfigItems, objSemItem_Development)
        objFrmCodeGenerator.ShowDialog(Me)
    End Sub

    
    Private Sub ContextMenuStrip_SemItems_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_SemItems.Opening

        setExportModeToolStripMenuItem.Enabled = False

        If DataGridView_ConfigItems.SelectedRows.Count > 0 Then
            setExportModeToolStripMenuItem.Enabled = True

        End If

        
    End Sub



    Private Sub RemoveChildrenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setExportModeToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDGVR_ExportMode As DataGridViewRow
        Dim objDRV_ExportMode As DataRowView
        Dim objDRC_SemItemToExport As DataRowCollection
        Dim objSemItem_ConfigItem As New clsSemItem
        Dim objSemItem_ExportMode As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim boolAddChildren As Boolean
        Dim intCount_Children As Integer
        Dim intDone_Children As Integer = 0

        If DataGridView_ConfigItems.SelectedRows.Count > 0 Then
            intCount_Children = DataGridView_ConfigItems.SelectedRows.Count
            objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Export_Mode, objLocalConfig.Globals)
            objFrmSemManager.Applyabale = True
            objFrmSemManager.ShowDialog(Me)
            If objFrmSemManager.DialogResult = DialogResult.OK Then
                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                    If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                        objDGVR_ExportMode = objFrmSemManager.SelectedRows_Items(0)
                        objDRV_ExportMode = objDGVR_ExportMode.DataBoundItem
                        objSemItem_ExportMode.GUID = objDRV_ExportMode.Item("GUID_Token")
                        objSemItem_ExportMode.Name = objDRV_ExportMode.Item("Name_Token")
                        objSemItem_ExportMode.GUID_Parent = objLocalConfig.SemItem_Type_Export_Mode.GUID
                        objSemItem_ExportMode.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        If objDRV_ExportMode.Item("GUID_Type") = objLocalConfig.SemItem_Type_Export_Mode.GUID Then

                            For Each objDGVR_Selected In DataGridView_ConfigItems.SelectedRows

                                objDRV_Selected = objDGVR_Selected.DataBoundItem
                                objSemItem_ConfigItem.GUID = objDRV_Selected.Item("GUID_Token_ConfigItem")
                                objSemItem_ConfigItem.Name = objDRV_Selected.Item("Name_Token_ConfigItem")
                                objSemItem_ConfigItem.GUID_Parent = objLocalConfig.SemItem_Type_DevelopmentConfigItem.GUID
                                objSemItem_ConfigItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                                Select Case objDRV_ExportMode.Item("GUID_Token")
                                    Case objLocalConfig.SemItem_Token_Export_Mode_Deny_Item_with_Children__Type___Token_.GUID, _
                                        objLocalConfig.SemItem_Token_Export_Mode_Deny_Only_Children__Token_of_Type_.GUID, _
                                        objLocalConfig.SemItem_Token_Export_Mode_Grant_Children_of_Item__Token_of_Type_.GUID

                                        objSemItem_Result = objTransaction_SemConfig.save_001_SemItems_To_Export(objSemItem_ConfigItem, _
                                                                                                                 objSemItem_Development)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_SemConfig.save_002_SemItemToExport_To_ConfigItem
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_SemConfig.save_003_SemItemToExport_To_SoftwareDevelopment
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_SemConfig.save_004_SemItemToExport_To_ExportMode(objSemItem_ExportMode)
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        intDone_Children = intDone_Children + 1
                                                    Else
                                                        objSemItem_Result = objTransaction_SemConfig.del_003_SemItemToExport_To_SoftwareDevelopment
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_SemConfig.del_002_SemItemToExport_To_ConfigItem
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objTransaction_SemConfig.del_001_SemItems_To_Export()
                                                            End If
                                                        End If

                                                    End If
                                                Else
                                                    objSemItem_Result = objTransaction_SemConfig.del_002_SemItemToExport_To_ConfigItem
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objTransaction_SemConfig.del_001_SemItems_To_Export()
                                                    End If

                                                End If
                                            Else
                                                objTransaction_SemConfig.del_001_SemItems_To_Export()
                                            End If
                                           
                                        Else
                                            MsgBox("Der Export-Mode konnte nicht festgelegt werden!", MsgBoxStyle.Exclamation)
                                        End If
                                    Case objLocalConfig.SemItem_Token_Export_Mode_Normal.GUID

                                        objTransaction_SemConfig.SemItem_Development = objSemItem_Development
                                        objTransaction_SemConfig.SemItem_ConfigItem = objSemItem_ConfigItem
                                        objTransaction_SemConfig.SemItem_ExportMode = Nothing
                                        objSemItem_Result = objTransaction_SemConfig.get_SemItemsToExport
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_SemConfig.del_004_SemItemToExport_To_ExportMode()
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_SemConfig.del_003_SemItemToExport_To_SoftwareDevelopment
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_SemConfig.del_002_SemItemToExport_To_ConfigItem
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_SemConfig.del_001_SemItems_To_Export
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            intDone_Children = intDone_Children + 1
                                                        End If
                                                    Else
                                                        MsgBox("Beim Ändern des Export-Modes ist ein Fehler unterlaufen!", MsgBoxStyle.Critical)
                                                    End If
                                                Else
                                                    MsgBox("Beim Ändern des Export-Modes ist ein Fehler unterlaufen!", MsgBoxStyle.Critical)
                                                End If
                                            Else
                                                MsgBox("Der Export-Mode konnte nicht geändert werden!", MsgBoxStyle.Exclamation)
                                            End If
                                        Else
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                                MsgBox("Der Export-Mode konnte nicht geändert werden!", MsgBoxStyle.Exclamation)
                                            End If
                                        End If
                                        


                                End Select


                            Next
                            If intDone_Children < intCount_Children Then
                                MsgBox("Es konnten nur " & intDone_Children & " Items geändert werden!", MsgBoxStyle.Exclamation)

                            End If
                            fill_ConfigItems()
                        Else
                            MsgBox("Bitte wählen Sie einen Export-Typ aus!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Else
                    MsgBox("Bitte wählen Sie einen Export-Typ aus!", MsgBoxStyle.Exclamation)
                End If

            End If

        End If
    End Sub

   
    Private Sub ToolStripButton_ExportRDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ExportRDF.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim GUID_Type_ConfigItem As Guid
        Dim objSemItem_Item As New clsSemItem
        Dim objDRC_Item As DataRowCollection
        Dim objDR_Item As DataRow

        Dim semtblT_Token As New ds_SemDB.semtbl_TokenDataTable
        Dim semtblT_Type As New ds_SemDB.semtbl_TypeDataTable

        For Each objDGVR_Selected In DataGridView_ConfigItems.Rows
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            GUID_Type_ConfigItem = objDRV_Selected.Item("GUID_ItemType_Or")
            Select Case GUID_Type_ConfigItem
                Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                    objSemItem_Item.GUID = objDRV_Selected.Item("GUID_Ref")
                    objRDFWork.add_Attribute(objSemItem_Item)
                    
                Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                    objSemItem_Item.GUID = objDRV_Selected.Item("GUID_Ref")
                    objRDFWork.add_RelationType(objSemItem_Item)
                Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objDRC_Item = semtblA_Token.GetData_Token_By_GUID(objDRV_Selected.Item("GUID_Ref")).Rows
                    semtblT_Token.Rows.Add(objDRC_Item(0).Item(0), _
                                           objDRC_Item(0).Item(1), _
                                           objDRC_Item(0).Item(2))
                Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                    objDRC_Item = semtblA_Type.GetData_By_GUID(objDRV_Selected.Item("GUID_Ref")).Rows
                    semtblT_Type.Rows.Add(objDRC_Item(0).Item(0), _
                                           objDRC_Item(0).Item(1), _
                                           objDRC_Item(0).Item(2))
            End Select


        Next
        For Each objDR_Item In semtblT_Type.Rows
            objSemItem_Item.GUID = objDR_Item.Item("GUID_Type")
            objRDFWork.add_Type(objSemItem_Item, True, True, True)

        Next

        For Each objDR_Item In semtblT_Token.Rows
            objSemItem_Item.GUID = objDR_Item.Item("GUID_Token")
            objRDFWork.add_Token(objSemItem_Item, True)
        Next

        objRDFWork.create_RDF(objSemItem_Development)
    End Sub
End Class
