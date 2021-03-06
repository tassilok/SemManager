﻿Imports Filesystem_Management
Imports Schema_Manager
Imports Sem_Manager
Imports ClassLibrary_ShellWork
Imports Localizing_Manager

Public Class UserControl_DBSchema_For_Applications
    Private Const cstr_GUID_Development As String = "e559ffe2-a91d-4247-b8c7-ea47b9da7a6b"

    Private objLocalConfig As clsLocalConfig
    Private objSemItem_Development As clsSemItem

    Private objTransaction_DBSchemaForApplications As clsTransaction_DBSchemForApplications
    Private objLocalize_GUIEntries As clsLocalized_GUIEntries
    Private objDBWork As Schema_Manager.clsDBWork
    Private objFileWork As clsFileWork
    Private objSemWork As clsSemWork
    Private objShellWork As clsShellWork

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable
    Private procA_SemItemsToExportChildren_Of_SoftwareDevelopment As New ds_SemanticConfigTableAdapters.proc_SemItemsToExportChildren_Of_SoftwareDevelopmentTableAdapter

    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private WithEvents objFRM_SemManager As frmSemManager

    Private objDRV_Selected As DataRowView
    Private procA_DBSchemaOfApplication As New ds_DBSchemaTableAdapters.proc_DBSchema_Of_ApplicationTableAdapter
    Private procT_DBSchemaOfApplication As New ds_DBSchema.proc_DBSchema_Of_ApplicationDataTable
    Private procA_DatabaseOnServer_Of_DBSchemaOfApplication As New ds_DBSchemaTableAdapters.proc_DatabaseOnServer_Of_DBSchemaOfApplicationTableAdapter
    Private procT_DatabaseOnServer_Of_DBSchemaOfApplication As New ds_DBSchema.proc_DatabaseOnServer_Of_DBSchemaOfApplicationDataTable

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter

    Private strCol_Name_Database As String
    Private Name_Token_DBSchemaOfApplication As String
    Private strCol_Name_Server As String
    Private strCol_Name_DBSchemaType As String
    Private strCol_Path_File As String

    Public Sub New(ByVal SemItem_Development As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        objSemItem_Development = SemItem_Development
        initialize()
    End Sub
    Public Sub New(ByVal LocalConfig_SchemaManager As clsLocalConfig, ByVal SemItem_Development As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig_SchemaManager
        objSemItem_Development = SemItem_Development
        initialize()
    End Sub

    Private Sub initialize()
        configure_GUIEntries()
        set_DBConnection()
        fill_DBSchemaView()


    End Sub

    Private Sub fill_DBSchemaView()
        If Not objSemItem_Development Is Nothing Then
            get_DBSchemaOfApplication()
            BindingSource_DBSchemas.DataSource = procT_DBSchemaOfApplication
            DataGridView_DBSchemas.DataSource = BindingSource_DBSchemas
            DataGridView_DBSchemas.Columns(0).Visible = False
            DataGridView_DBSchemas.Columns(1).HeaderText = Name_Token_DBSchemaOfApplication
            DataGridView_DBSchemas.Columns(1).Width = 300
            DataGridView_DBSchemas.Columns(2).Visible = False
            DataGridView_DBSchemas.Columns(3).Visible = False
            DataGridView_DBSchemas.Columns(4).HeaderText = strCol_Name_DBSchemaType
            DataGridView_DBSchemas.Columns(5).Visible = False
            DataGridView_DBSchemas.Columns(6).Visible = False
            DataGridView_DBSchemas.Columns(7).Visible = False
            DataGridView_DBSchemas.Columns(8).Visible = False
            DataGridView_DBSchemas.Columns(9).Visible = False
            DataGridView_DBSchemas.Columns(10).HeaderText = strCol_Path_File
        Else
            Me.Enabled = False
        End If
    End Sub

    Private Sub get_DBSchemaOfApplication()
        procA_DBSchemaOfApplication.Fill(procT_DBSchemaOfApplication, _
                                         objLocalConfig.SemItem_Type_DBSchema_Of_Application.GUID, _
                                         objLocalConfig.SemItem_Type_DB_Schema_Type.GUID, _
                                         objLocalConfig.SemItem_Type_File.GUID, _
                                         objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                         objLocalConfig.SemItem_RelationType_export_to.GUID, _
                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                         objSemItem_Development.GUID)

        get_FilePath()

    End Sub

    Private Sub get_FilePath()
        Dim objDR_DBSchemaOfApplication As DataRow
        Dim objSemItem_File As New clsSemItem
        Dim strPath_File As String

        For Each objDR_DBSchemaOfApplication In procT_DBSchemaOfApplication.Rows
            If objDR_DBSchemaOfApplication.Item("GUID_DBSchemaType") = objLocalConfig.SemItem_Token_DB_Schema_Type_Config.GUID Then
                ConfigSchemaToolStripMenuItem.Enabled = False
            End If
            If objDR_DBSchemaOfApplication.Item("GUID_DBSchemaType") = objLocalConfig.SemItem_Token_DB_Schema_Type_Module.GUID Then
                ModuleSchemaToolStripMenuItem.Enabled = False
            End If
            If objDR_DBSchemaOfApplication.Item("GUID_DBSchemaType") = objLocalConfig.SemItem_Token_DB_Schema_Type_User.GUID Then
                ToolStripMenuItem_DBschema_User.Enabled = False
            End If
            If Not IsDBNull(objDR_DBSchemaOfApplication.Item("GUID_File")) Then
                objSemItem_File.GUID = objDR_DBSchemaOfApplication.Item("GUID_File")
                objSemItem_File.Name = objDR_DBSchemaOfApplication.Item("Name_File")
                objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                strPath_File = objFileWork.get_Path_FileSystemObject(objSemItem_File)
                objDR_DBSchemaOfApplication.Item("Path_File") = strPath_File
            End If

        Next
    End Sub

    Private Sub set_DBConnection()

        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_Config
        procA_DBSchemaOfApplication.Connection = objLocalConfig.Connection_Plugin
        procA_DatabaseOnServer_Of_DBSchemaOfApplication.Connection = objLocalConfig.Connection_Plugin
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB
        funcA_SoftwareDevelopment_Config.Connection = objLocalConfig.Connection_Config

        objFileWork = New clsFileWork(objLocalConfig.Globals)
        objSemWork = New clsSemWork(objLocalConfig.Globals)
        objDBWork = New Schema_Manager.clsDBWork(objLocalConfig.Globals)
        objShellWork = New clsShellWork

        procA_OR_Attribute_By_GUIDObjectReference.Connection = objLocalConfig.Connection_Config
        procA_OR_RelationType_By_GUIDObjectReference.Connection = objLocalConfig.Connection_Config
        procA_OR_Token_By_GUID.Connection = objLocalConfig.Connection_Config
        procA_OR_Type_By_GUID.Connection = objLocalConfig.Connection_Config

        procA_SemItemsToExportChildren_Of_SoftwareDevelopment.Connection = objLocalConfig.Connection_Plugin

        objTransaction_DBSchemaForApplications = New clsTransaction_DBSchemForApplications(objLocalConfig)
    End Sub

    Private Sub DataGridView_DBSchemas_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_DBSchemas.RowHeaderMouseClick

    End Sub

    Private Sub DataGridView_DBSchemas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_DBSchemas.SelectionChanged
        Dim objDGVR_Selected As DataGridViewRow
        objDRV_Selected = Nothing
        ToolStripButton_RemoveSchema.Enabled = False
        ToolStripButton_setExportFile.Enabled = False
        ToolStripButton_Add_DBOnServer.Enabled = False
        ToolStripButton_Remove_DB_On_Server.Enabled = False
        ToolStripButton_ExportDirect.Enabled = False
        ToolStripButton_SaveToFile.Enabled = False

        If DataGridView_DBSchemas.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_DBSchemas.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            ToolStripButton_RemoveSchema.Enabled = True
            ToolStripButton_setExportFile.Enabled = True
            get_DBs_On_Server(objDRV_Selected)
        End If
    End Sub

    Private Sub get_DBs_On_Server(ByVal objDRV_Selected As DataRowView)
        procA_DatabaseOnServer_Of_DBSchemaOfApplication.Fill(procT_DatabaseOnServer_Of_DBSchemaOfApplication, _
                                                             objLocalConfig.SemItem_Type_Database_on_Server.GUID, _
                                                             objLocalConfig.SemItem_Type_Database.GUID, _
                                                             objLocalConfig.SemItem_Type_Server.GUID, _
                                                             objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                             objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                                             objDRV_Selected.Item("GUID_DBSchemaOfApplication"))
        BindingSource_DBOnServer.DataSource = procT_DatabaseOnServer_Of_DBSchemaOfApplication
        DataGridView_DBOnServer.DataSource = BindingSource_DBOnServer

        DataGridView_DBOnServer.Columns(0).Visible = False
        DataGridView_DBOnServer.Columns(1).Visible = False
        DataGridView_DBOnServer.Columns(2).Visible = False
        DataGridView_DBOnServer.Columns(3).Visible = False
        DataGridView_DBOnServer.Columns(4).Visible = False
        DataGridView_DBOnServer.Columns(5).HeaderText = strCol_Name_Database
        DataGridView_DBOnServer.Columns(6).Visible = False
        DataGridView_DBOnServer.Columns(7).Visible = False
        DataGridView_DBOnServer.Columns(8).HeaderText = strCol_Name_Server
        DataGridView_DBOnServer.Columns(9).Visible = False

        ToolStripButton_Add_DBOnServer.Enabled = True
    End Sub

    Private Sub ToolStripButton_setExportFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_setExportFile.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objDGVR_DBSchema_Of_Application As DataGridViewRow
        Dim objDRV_DBSchema_Of_Application As DataRowView
        Dim objDRC_TokenRel As DataRowCollection
        Dim objDR_TokenRel As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_File As New clsSemItem
        Dim boolAdd As Boolean

        objFRM_SemManager = New frmSemManager(objLocalConfig.SemItem_Type_File, objLocalConfig.Globals)
        objFRM_SemManager.Applyabale = True
        objFRM_SemManager.ShowDialog(Me)

        If objFRM_SemManager.DialogResult = DialogResult.OK Then

            If objFRM_SemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFRM_SemManager.SemItems_Selected.Count = 1 Then
                    objSemItem_File = objFRM_SemManager.SemItems_Selected(0)
                    If objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID Then
                        objDGVR_DBSchema_Of_Application = DataGridView_DBSchemas.SelectedRows(0)
                        objDRV_DBSchema_Of_Application = objDGVR_DBSchema_Of_Application.DataBoundItem
                        objDRC_TokenRel = funcA_Token_Token.GetData_TokenToken_LeftRight(objDRV_DBSchema_Of_Application.Item("GUID_DBSchemaOfApplication"), objLocalConfig.SemItem_RelationType_export_to.GUID, objLocalConfig.SemItem_Type_File.GUID).Rows
                        boolAdd = True
                        For Each objDR_TokenRel In objDRC_TokenRel
                            If objDR_TokenRel.Item("GUID_Token_Right") = objSemItem_File.GUID Then
                                boolAdd = False
                            Else
                                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDR_TokenRel.Item("GUID_Token_Left"), objDR_TokenRel.Item("Name_Token_Right"), objLocalConfig.SemItem_RelationType_export_to.GUID).Rows
                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                                    boolAdd = False
                                    MsgBox("Beim Löschen vorhandener Beziehungen zu Dateien, ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                                    Exit For
                                End If

                            End If

                        Next
                        If boolAdd = True Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objDRV_DBSchema_Of_Application.Item("GUID_DBSchemaOfApplication"), objSemItem_File.GUID, objLocalConfig.SemItem_RelationType_export_to.GUID, 0).Rows
                            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then

                                objFileWork = New clsFileWork(objLocalConfig.Globals)
                                objDRV_DBSchema_Of_Application.Item("Path_File") = objFileWork.get_Path_FileSystemObject(objSemItem_File)
                            Else

                                MsgBox("Beim Verknüpfen der Datei ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                            End If

                        End If
                        fill_DBSchemaView()
                    Else
                        MsgBox("Bitte nur eine Datei auswählen!", MsgBoxStyle.Exclamation)

                    End If

                End If


            Else
                MsgBox("Bitte nur eine Datei auswählen!", MsgBoxStyle.Exclamation)
            End If



        End If


    End Sub

    Private Sub DataGridView_DBOnServer_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_DBOnServer.SelectionChanged

        ToolStripButton_Remove_DB_On_Server.Enabled = False
        ToolStripButton_ExportDirect.Enabled = False
        ToolStripButton_SaveToFile.Enabled = False

        If DataGridView_DBOnServer.SelectedRows.Count = 1 Then


            ToolStripButton_Remove_DB_On_Server.Enabled = True
            ToolStripButton_ExportDirect.Enabled = True
            ToolStripButton_SaveToFile.Enabled = True
        End If

    End Sub

    Private Sub ToolStripButton_SaveToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_SaveToFile.Click
        Dim semtblT_Token As New ds_SemDB.semtbl_TokenDataTable
        Dim semtblT_Type As New ds_SemDB.semtbl_TypeDataTable
        Dim objDGVR_DatabaseServer As DataGridViewRow
        Dim objDRV_DatabaseServer As DataRowView
        Dim objDGVR_DBSchemaOfApplciation As DataGridViewRow
        Dim objDRV_DBSchemaOfApplication As DataRowView
        Dim objDRC_Ref As DataRowCollection
        Dim objDRC_Children As DataRowCollection
        Dim objDR_Children As DataRow
        Dim objDRC_ORRel As DataRowCollection
        Dim objDRC_Config As DataRowCollection
        Dim objDRC_DBSchema As DataRowCollection
        Dim objTextWriter As IO.TextWriter
        Dim objSemItem_TypeOfDeniedToken As New clsSemItem
        Dim objSemItem_DBOnServer As New clsSemItem
        Dim objSemItem_Config As New clsSemItem
        Dim objSemItem_SchemaType As New clsSemItem
        Dim objSemItem_DBSchema As New clsSemItem
        Dim objSemItem_Version As New clsSemItem
        Dim objSemItem_DBSchemaOfApplication As New clsSemItem
        Dim objDR_Token As DataRow
        Dim objDRC_Type As DataRowCollection
        Dim objDR_ConfigItem As DataRow
        Dim strPath_File As String
        Dim strDatabase As String
        Dim strSQL As String

        Dim boolSave As Boolean

        If DataGridView_DBOnServer.SelectedRows.Count = 1 Then
            objDGVR_DatabaseServer = DataGridView_DBOnServer.SelectedRows(0)
            objDRV_DatabaseServer = objDGVR_DatabaseServer.DataBoundItem

            objSemItem_DBOnServer.GUID = objDRV_DatabaseServer.Item("GUID_DatabaseOnServer")
            objSemItem_DBOnServer.Name = objDRV_DatabaseServer.Item("Name_DatabaseOnServer")
            objSemItem_DBOnServer.GUID_Parent = objLocalConfig.SemItem_Type_Database_on_Server.GUID
            objSemItem_DBOnServer.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_DBSchema = funcA_Token_Token.GetData_TokenToken_LeftRight(objDRV_DatabaseServer.Item("GUID_Database"), _
                                                                             objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                             objLocalConfig.SemItem_Type_Database_Schema.GUID).Rows
            objDRC_DBSchema = funcA_Token_Token.GetData_TokenToken_LeftRight(objDRC_DBSchema(0).Item("GUID_Token_Right"), _
                                                                             objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                             objLocalConfig.SemItem_Type_DevelopmentVersion.GUID).Rows

            objSemItem_Version.GUID = objDRC_DBSchema(0).Item("GUID_Token_Right")
            objSemItem_Version.Name = objDRC_DBSchema(0).Item("Name_Token_Right")
            objSemItem_Version.GUID_Parent = objLocalConfig.SemItem_Type_DevelopmentVersion.GUID
            objSemItem_Version.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            strDatabase = objDRV_DatabaseServer.Item("Name_Database")

            objDGVR_DBSchemaOfApplciation = DataGridView_DBSchemas.SelectedRows(0)
            objDRV_DBSchemaOfApplication = objDGVR_DBSchemaOfApplciation.DataBoundItem


            If Not IsDBNull(objDRV_DBSchemaOfApplication.Item("Path_File")) Then
                objSemItem_DBSchemaOfApplication.GUID = objDRV_DBSchemaOfApplication.Item("GUID_DBSchemaOfApplication")
                objSemItem_DBSchemaOfApplication.Name = objDRV_DBSchemaOfApplication.Item("Name_Token_DBSchemaOfApplication")
                objSemItem_DBSchemaOfApplication.GUID_Parent = objLocalConfig.SemItem_Type_DBSchema_Of_Application.GUID
                objSemItem_DBSchemaOfApplication.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_SchemaType.GUID = objDRV_DBSchemaOfApplication.Item("GUID_DBSchemaType")
                objSemItem_SchemaType.Name = objDRV_DBSchemaOfApplication.Item("Name_DBSchemaType")
                objSemItem_SchemaType.GUID_Parent = objLocalConfig.SemItem_Type_DB_Schema_Type.GUID
                objSemItem_SchemaType.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                strPath_File = objDRV_DBSchemaOfApplication.Item("Path_File")

                Try
                    If IO.File.Exists(strPath_File) Then
                        IO.File.Delete(strPath_File)
                    End If
                    objTextWriter = New IO.StreamWriter(strPath_File, False)

                    boolSave = True




                Catch ex As Exception
                    MsgBox("Die Datei, in die der SQL-Code exportiert werden soll, kann nicht geschrieben werden!", MsgBoxStyle.Exclamation)
                    boolSave = False
                End Try

                If boolSave = True Then
                    objSemWork = New clsSemWork(objLocalConfig.Globals)

                    Select Case objDRV_DBSchemaOfApplication.Item("GUID_DBSchemaType")
                        Case objLocalConfig.SemItem_Token_DB_Schema_Type_Config.GUID
                            funcA_SoftwareDevelopment_Config.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_Config, objSemItem_Development.GUID)
                            objDRC_Config = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Development.GUID, _
                                                                                               objLocalConfig.SemItem_RelationType_needs.GUID, _
                                                                                               objLocalConfig.SemItem_Type_DevelopmentConfig.GUID).Rows
                            objSemItem_Config.GUID = objDRC_Config(0).Item("GUID_Token_Right")
                            objSemItem_Config.Name = objDRC_Config(0).Item("Name_Token_Right")
                            objSemItem_Config.GUID_Parent = objDRC_Config(0).Item("GUID_Type_Right")
                            objSemItem_Config.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemWork.Relations = False
                            objSemWork.add_Token(objSemItem_Config.GUID)
                            objSemWork.add_Token(objSemItem_Development.GUID)
                            For Each objDR_ConfigItem In func_SoftwareDevelopment_Config.Rows



                                objSemWork.add_Token(objDR_ConfigItem.Item("GUID_Token_ConfigItem"))

                                Select Case objDR_ConfigItem.Item("GUID_ORType")
                                    Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                        objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDR_ConfigItem.Item("GUID_ObjectReference")).Rows
                                        If objDRC_Ref.Count > 0 Then
                                            objSemWork.add_Attribute(objDRC_Ref(0).Item("GUID_Attribute"))
                                        End If
                                    Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                                        objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDR_ConfigItem.Item("GUID_ObjectReference")).Rows
                                        If objDRC_Ref.Count > 0 Then
                                            objSemWork.add_RelationType(objDRC_Ref(0).Item("GUID_RelationType"))
                                        End If
                                    Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                        objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDR_ConfigItem.Item("GUID_ObjectReference")).Rows
                                        If objDRC_Ref.Count > 0 Then
                                            Try
                                                semtblT_Token.Rows.Add(objDRC_Ref(0).Item("GUID_Token"), _
                                                                       objDRC_Ref(0).Item("Name_Token"), _
                                                                       objDRC_Ref(0).Item("GUID_Type"))
                                            Catch ex As Exception

                                            End Try
                                            'objSemWork.add_Token(objDRC_Ref(0).Item("GUID_Token"))
                                        End If
                                    Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID


                                        objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDR_ConfigItem.Item("GUID_ObjectReference")).Rows
                                        If objDRC_Ref.Count > 0 Then
                                            objSemWork.add_Type(objDRC_Ref(0).Item("GUID_Type"), True, False)
                                            objDRC_Children = procA_SemItemsToExportChildren_Of_SoftwareDevelopment.GetData(objLocalConfig.SemItem_Type_Sem_Items_to_expot_with_Children.GUID, _
                                                                                                                        objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                                                                        objLocalConfig.SemItem_Type_DevelopmentConfigItem.GUID, _
                                                                                                                        objLocalConfig.SemItem_Type_Export_Mode.GUID, _
                                                                                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                                                        objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                                                        objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                                                                        objSemItem_Development.GUID, _
                                                                                                                        objDR_ConfigItem.Item("GUID_Token_ConfigItem")).Rows
                                            If objDRC_Children.Count > 0 Then
                                                If objDRC_Children(0).Item("GUID_Export_Mode") = objLocalConfig.SemItem_Token_Export_Mode_Grant_Children_of_Item__Token_of_Type_.GUID Then
                                                    objDRC_Children = semtblA_Token.GetData_Token_TypeChilds(objDRC_Ref(0).Item("GUID_Type")).Rows
                                                    For Each objDR_Children In objDRC_Children
                                                        Try
                                                            semtblT_Token.Rows.Add(objDR_Children.Item("GUID_Token"), _
                                                                                   objDR_Children.Item("Name_Token"), _
                                                                                   objDR_Children.Item("GUID_Type"))
                                                        Catch ex As Exception

                                                        End Try

                                                    Next

                                                ElseIf objDRC_Children(0).Item("GUID_Export_Mode") = objLocalConfig.SemItem_Token_Export_Mode_Deny_Only_Children__Token_of_Type_.GUID Then

                                                    objSemItem_TypeOfDeniedToken.GUID = objDRC_Ref(0).Item("GUID_Type")
                                                    objSemItem_TypeOfDeniedToken.Name = objDRC_Ref(0).Item("Name_Type")
                                                    objSemItem_TypeOfDeniedToken.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                                                    objDRC_Type = semtblA_Type.GetData_By_GUID(objSemItem_TypeOfDeniedToken.GUID).Rows
                                                    If objDRC_Type.Count > 0 Then
                                                        If Not IsDBNull(objDRC_Type(0).Item("GUID_Type_Parent")) Then
                                                            objSemItem_TypeOfDeniedToken.GUID_Parent = objDRC_Type(0).Item("GUID_Type_Parent")
                                                            objSemWork.add_Type_For_Deny(objSemItem_TypeOfDeniedToken)
                                                        End If


                                                    End If


                                                End If

                                            End If
                                        End If
                                End Select
                            Next
                            For Each objDR_Token In semtblT_Token.Rows
                                objSemWork.add_Token(objDR_Token.Item("GUID_Token"))
                            Next
                            objSemWork.relate_added_Items()
                            objDBWork.write_TSQL_SemItems(objSemWork, objTextWriter, objLocalConfig.Connection_Config, True)
                        Case objLocalConfig.SemItem_Token_DB_Schema_Type_Module.GUID
                            objSemWork.Relations = False
                            funcA_SoftwareDevelopment_Config.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_Config, objSemItem_Development.GUID)
                            For Each objDR_ConfigItem In func_SoftwareDevelopment_Config.Rows
                                Select Case objDR_ConfigItem.Item("GUID_ORType")
                                    Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                        objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDR_ConfigItem.Item("GUID_ObjectReference")).Rows
                                        If objDRC_Ref.Count > 0 Then
                                            objSemWork.add_Attribute(objDRC_Ref(0).Item("GUID_Attribute"))
                                        End If
                                    Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                                        objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDR_ConfigItem.Item("GUID_ObjectReference")).Rows
                                        If objDRC_Ref.Count > 0 Then
                                            objSemWork.add_RelationType(objDRC_Ref(0).Item("GUID_RelationType"))
                                        End If
                                    Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                        objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDR_ConfigItem.Item("GUID_ObjectReference")).Rows
                                        If objDRC_Ref.Count > 0 Then
                                            objSemWork.add_Token(objDRC_Ref(0).Item("GUID_Token"))
                                        End If
                                    Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                                        objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDR_ConfigItem.Item("GUID_ObjectReference")).Rows
                                        If objDRC_Ref.Count > 0 Then
                                            objSemWork.add_Type(objDRC_Ref(0).Item("GUID_Type"), False, False)
                                        End If
                                End Select
                            Next
                            objSemWork.relate_added_Items()
                            strSQL = objDBWork.get_SQL_Use_Database(strDatabase)
                            objTextWriter.WriteLine(strSQL)
                            strSQL = objDBWork.get_SQL_GO
                            objTextWriter.WriteLine(strSQL)

                            For Each objDR_ConfigItem In objSemWork.semtblT_Attribute.Rows
                                strSQL = objDBWork.get_SQL_IFNOTExists_Function("dbg_AttributeType_" & objDR_ConfigItem.Item("Name_Attribute"))
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_BEGIN
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_Insert_dbg_Attribute(objDR_ConfigItem.Item("Name_Attribute"))
                                strSQL = objDBWork.get_SQL_execute_SQL(strSQL)
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_END
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_GO
                                objTextWriter.WriteLine(strSQL)
                            Next

                            For Each objDR_ConfigItem In objSemWork.semtblT_RelationType.Rows
                                strSQL = objDBWork.get_SQL_IFNOTExists_Function("dbg_RelationType_" & objDR_ConfigItem.Item("Name_Relationtype"))
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_BEGIN
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_Insert_dbg_RelationType(objDR_ConfigItem.Item("Name_Relationtype"))
                                strSQL = objDBWork.get_SQL_execute_SQL(strSQL)
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_END
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_GO
                                objTextWriter.WriteLine(strSQL)
                            Next

                            For Each objDR_ConfigItem In objSemWork.semtblT_Type.Rows
                                strSQL = objDBWork.get_SQL_IFNOTExists_Function("dbg_Type_" & objDR_ConfigItem.Item("Name_Type"))
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_BEGIN
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_Insert_dbg_Type(objDR_ConfigItem.Item("Name_Type"))
                                strSQL = objDBWork.get_SQL_execute_SQL(strSQL)
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_END
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_GO
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_IFNOTExists_Function("func_Token_" & objDR_ConfigItem.Item("Name_Type"))
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_BEGIN
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_Creation_Token_Of_Type(objDR_ConfigItem.Item("Name_Type"))
                                strSQL = objDBWork.get_SQL_execute_SQL(strSQL)
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_END
                                objTextWriter.WriteLine(strSQL)
                                strSQL = objDBWork.get_SQL_GO
                                objTextWriter.WriteLine(strSQL)
                            Next


                        Case objLocalConfig.SemItem_Token_DB_Schema_Type_User.GUID
                            objSemWork.Relations = False
                            funcA_SoftwareDevelopment_Config.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_Config, objSemItem_Development.GUID)
                            For Each objDR_ConfigItem In func_SoftwareDevelopment_Config.Rows
                                Select Case objDR_ConfigItem.Item("GUID_ORType")
                                    Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                        objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDR_ConfigItem.Item("GUID_ObjectReference")).Rows
                                        If objDRC_Ref.Count > 0 Then
                                            objSemWork.add_Attribute(objDRC_Ref(0).Item("GUID_Attribute"))
                                        End If
                                    Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                                        objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDR_ConfigItem.Item("GUID_ObjectReference")).Rows
                                        If objDRC_Ref.Count > 0 Then
                                            objSemWork.add_RelationType(objDRC_Ref(0).Item("GUID_RelationType"))
                                        End If
                                    Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                        objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDR_ConfigItem.Item("GUID_ObjectReference")).Rows
                                        If objDRC_Ref.Count > 0 Then
                                            Try
                                                semtblT_Token.Rows.Add(objDRC_Ref(0).Item("GUID_Token"), _
                                                                       objDRC_Ref(0).Item("Name_Token"), _
                                                                       objDRC_Ref(0).Item("GUID_Type"))
                                            Catch ex As Exception

                                            End Try
                                            'objSemWork.add_Token(objDRC_Ref(0).Item("GUID_Token"))
                                        End If
                                    Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID


                                        objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDR_ConfigItem.Item("GUID_ObjectReference")).Rows
                                        If objDRC_Ref.Count > 0 Then
                                            objSemWork.add_Type(objDRC_Ref(0).Item("GUID_Type"), True)
                                            objDRC_Children = procA_SemItemsToExportChildren_Of_SoftwareDevelopment.GetData(objLocalConfig.SemItem_Type_Sem_Items_to_expot_with_Children.GUID, _
                                                                                                                        objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                                                                        objLocalConfig.SemItem_Type_DevelopmentConfigItem.GUID, _
                                                                                                                        objLocalConfig.SemItem_Type_Export_Mode.GUID, _
                                                                                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                                                        objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                                                        objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                                                                        objSemItem_Development.GUID, _
                                                                                                                        objDR_ConfigItem.Item("GUID_Token_ConfigItem")).Rows
                                            If objDRC_Children.Count > 0 Then
                                                If objDRC_Children(0).Item("GUID_Export_Mode") = objLocalConfig.SemItem_Token_Export_Mode_Grant_Children_of_Item__Token_of_Type_.GUID Then
                                                    objDRC_Children = semtblA_Token.GetData_Token_TypeChilds(objDRC_Ref(0).Item("GUID_Type")).Rows
                                                    For Each objDR_Children In objDRC_Children
                                                        Try
                                                            semtblT_Token.Rows.Add(objDR_Children.Item("GUID_Token"), _
                                                                                   objDR_Children.Item("Name_Token"), _
                                                                                   objDR_Children.Item("GUID_Type"))
                                                        Catch ex As Exception

                                                        End Try

                                                    Next

                                                ElseIf objDRC_Children(0).Item("GUID_Export_Mode") = objLocalConfig.SemItem_Token_Export_Mode_Deny_Only_Children__Token_of_Type_.GUID Then

                                                    objSemItem_TypeOfDeniedToken.GUID = objDRC_Ref(0).Item("GUID_Type")
                                                    objSemItem_TypeOfDeniedToken.Name = objDRC_Ref(0).Item("Name_Type")
                                                    objSemItem_TypeOfDeniedToken.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                                                    objDRC_Type = semtblA_Type.GetData_By_GUID(objSemItem_TypeOfDeniedToken.GUID).Rows
                                                    If objDRC_Type.Count > 0 Then
                                                        If Not IsDBNull(objDRC_Type(0).Item("GUID_Type_Parent")) Then
                                                            objSemItem_TypeOfDeniedToken.GUID_Parent = objDRC_Type(0).Item("GUID_Type_Parent")
                                                            objSemWork.add_Type_For_Deny(objSemItem_TypeOfDeniedToken)
                                                        End If


                                                    End If


                                                End If

                                            End If
                                        End If
                                End Select

                            Next
                            For Each objDR_Token In semtblT_Token.Rows
                                objSemWork.add_Token(objDR_Token.Item("GUID_Token"))
                            Next
                            objSemWork.relate_added_Items()
                            strSQL = objDBWork.get_SQL_Use_Database(strDatabase)
                            objTextWriter.WriteLine(strSQL)
                            strSQL = objDBWork.get_SQL_GO
                            objTextWriter.WriteLine(strSQL)

                            objDBWork.write_TSQL_SemItems(objSemWork, objTextWriter, objLocalConfig.Connection_Config, True)


                    End Select

                End If
                Try
                    objTextWriter.Close()
                    objDBWork.save_File(objSemItem_DBSchemaOfApplication, objSemItem_Version, objLocalConfig.SemItem_RelationType_export_to, strPath_File)
                    'objShellWork.start_Process(strPath_File, Nothing, Nothing, False, False)
                    MsgBox("Die Datei wurde gespeichert!", MsgBoxStyle.Information)
                Catch ex As Exception

                End Try
            Else
                MsgBox("Es ist kein Export-File festgelegt!", MsgBoxStyle.Exclamation)
            End If


        End If


    End Sub

    Private Sub configure_GUIEntries()
        Dim objSemItem_Development As New clsSemItem
        Dim objDR_GUIEntry As DataRow
        Dim strCaption As String
        Dim strToolTip As String

        objSemItem_Development.GUID = New Guid(cstr_GUID_Development)
        objLocalize_GUIEntries = New clsLocalized_GUIEntries(objSemItem_Development, objLocalConfig.Globals)

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry("Name_Token_DBSchemaOfApplication")
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Name_Token_DBSchemaOfApplication = strCaption
            End If
            

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry("Col_Name_Database")
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                strCol_Name_Database = strCaption
            End If


        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry("col_Name_Server")
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                strCol_Name_Server = strCaption
            End If


        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry("Col_Name_DBSchemaType")
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                strCol_Name_DBSchemaType = strCaption
            End If


        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry("Col_Path_File")
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                strCol_Path_File = strCaption
            End If


        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripButton_setExportFile.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ToolStripButton_setExportFile.ToolTipText = strToolTip
            End If


        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripButton_SaveToFile.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ToolStripButton_SaveToFile.ToolTipText = strToolTip
            End If


        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripMenuItem_DBschema_User.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ToolStripMenuItem_DBschema_User.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                ToolStripMenuItem_DBschema_User.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripSplitButton_Add_Schemas.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            
            If Not strToolTip Is Nothing Then
                ToolStripSplitButton_Add_Schemas.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ModuleSchemaToolStripMenuItem.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ModuleSchemaToolStripMenuItem.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                ModuleSchemaToolStripMenuItem.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripButton_ExportDirect.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            
            If Not strToolTip Is Nothing Then
                ToolStripButton_ExportDirect.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripButton_Remove_DB_On_Server.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            
            If Not strToolTip Is Nothing Then
                ToolStripButton_Remove_DB_On_Server.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripButton_Add_DBOnServer.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            
            If Not strToolTip Is Nothing Then
                ToolStripButton_Add_DBOnServer.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripButton_RemoveSchema.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            
            If Not strToolTip Is Nothing Then
                ToolStripButton_RemoveSchema.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ConfigSchemaToolStripMenuItem.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ConfigSchemaToolStripMenuItem.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                ConfigSchemaToolStripMenuItem.ToolTipText = strToolTip
            End If

        End If
    End Sub

    Private Sub ToolStripMenuItem_DBschema_User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_DBschema_User.Click
        
        Dim objSchemaType As clsSemItem

        objSchemaType = objLocalConfig.SemItem_Token_DB_Schema_Type_User

        relate_DBSchema(objSchemaType)

    End Sub

    Private Sub relate_DBSchema(ByVal SemItem_SchemaType As clsSemItem)
        Dim objSemItem_SchemaType As clsSemItem

        Dim objSemItem_DBSchemaOfApplication As New clsSemItem
        Dim objSemItem_DatabaseOnServer As New clsSemItem
        Dim objSemItem_DatabaseSchema As New clsSemItem
        Dim objSemItem_File As New clsSemItem

        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objDRs_DBSchemaOfApp() As DataRow

        Dim objSemItem_Result As clsSemItem

        Dim boolSelOK As Boolean

        objSemItem_SchemaType = SemItem_SchemaType

        MsgBox("Bitte das Datenbank-Schema auswählen!", MsgBoxStyle.Information)

        objFRM_SemManager = New frmSemManager(objLocalConfig.SemItem_Type_Database_Schema, objLocalConfig.Globals)
        objFRM_SemManager.Applyabale = True
        objFRM_SemManager.ShowDialog(Me)

        If objFRM_SemManager.DialogResult = DialogResult.OK Then

            If objFRM_SemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFRM_SemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFRM_SemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Database_Schema.GUID Then
                        objSemItem_DatabaseSchema.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_DatabaseSchema.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_DatabaseSchema.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                        objSemItem_DatabaseOnServer.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        MsgBox("Bitte die Datenbank eines Servers auswählen!", MsgBoxStyle.Information)

                        objFRM_SemManager = New frmSemManager(objLocalConfig.SemItem_Type_Database_on_Server, objLocalConfig.Globals)
                        objFRM_SemManager.Applyabale = True
                        objFRM_SemManager.ShowDialog(Me)

                        If objFRM_SemManager.DialogResult = DialogResult.OK Then

                            If objFRM_SemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                                If objFRM_SemManager.SelectedRows_Items.Count = 1 Then
                                    objDGVR_Selected = objFRM_SemManager.SelectedRows_Items(0)
                                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Database_on_Server.GUID Then
                                        objSemItem_DatabaseOnServer.GUID = objDRV_Selected.Item("GUID_Token")
                                        objSemItem_DatabaseOnServer.Name = objDRV_Selected.Item("Name_Token")
                                        objSemItem_DatabaseOnServer.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                                        objSemItem_DatabaseOnServer.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                        objFRM_SemManager = New frmSemManager(objLocalConfig.SemItem_Type_File, objLocalConfig.Globals)
                                        objFRM_SemManager.Applyabale = True
                                        objFRM_SemManager.ShowDialog(Me)

                                        If objFRM_SemManager.DialogResult = DialogResult.OK Then

                                            If objFRM_SemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                                                If Not objFRM_SemManager.SelectedRows_Items Is Nothing Then
                                                    If objFRM_SemManager.SelectedRows_Items.Count = 1 Then
                                                        objDGVR_Selected = objFRM_SemManager.SelectedRows_Items(0)
                                                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                                                        If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_File.GUID Then
                                                            objSemItem_File.GUID = objDRV_Selected.Item("GUID_Token")
                                                            objSemItem_File.Name = objDRV_Selected.Item("Name_Token")
                                                            objSemItem_File.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                                                            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                                            boolSelOK = True
                                                        Else
                                                            boolSelOK = False
                                                        End If
                                                    Else
                                                        boolSelOK = False
                                                    End If
                                                Else
                                                    If objFRM_SemManager.SemItems_Selected.Count = 1 Then
                                                        objSemItem_File = objFRM_SemManager.SemItems_Selected(0)
                                                        If objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID Then
                                                            boolSelOK = True
                                                        Else
                                                            boolSelOK = False
                                                        End If

                                                    Else
                                                        boolSelOK = False
                                                    End If
                                                End If
                                                If boolSelOK = True Then
                                                    get_DBSchemaOfApplication()
                                                    objDRs_DBSchemaOfApp = procT_DBSchemaOfApplication.Select("GUID_File='" & objSemItem_File.GUID.ToString & "'")
                                                    If objDRs_DBSchemaOfApp.Count = 0 Then
                                                        objSemItem_DBSchemaOfApplication.GUID = Guid.NewGuid
                                                        objSemItem_DBSchemaOfApplication.Name = objSemItem_Development.Name & " (" & objSemItem_SchemaType.Name & ")"
                                                        objSemItem_DBSchemaOfApplication.GUID_Parent = objLocalConfig.SemItem_Type_DBSchema_Of_Application.GUID
                                                        objSemItem_DBSchemaOfApplication.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                                        objSemItem_Result = objTransaction_DBSchemaForApplications.save_001_DBSchemaOfApplication(objSemItem_DBSchemaOfApplication)
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_DBSchemaForApplications.save_002_DBSchemaOfApplication_To_DBOnServer(objSemItem_DatabaseOnServer)
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_DBSchemaForApplications.save_003_DBSchemaOfApplication_To_DBSchema(objSemItem_DatabaseSchema)
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objSemItem_Result = objTransaction_DBSchemaForApplications.save_004_DBSchemaOfApplication_To_DBSchemaType(objSemItem_SchemaType)
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objSemItem_Result = objTransaction_DBSchemaForApplications.save_005_DBSchemaOfApplication_To_File(objSemItem_File)
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objSemItem_Result = objTransaction_DBSchemaForApplications.save_006_DBSchemaOfApplication_To_Development(objSemItem_Development)
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                fill_DBSchemaView()

                                                                            Else
                                                                                objSemItem_Result = objTransaction_DBSchemaForApplications.del_003_DBSchemaOfApplication_To_DBSchema
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objSemItem_Result = objTransaction_DBSchemaForApplications.del_002_DBSchemaOfApplication_To_DBOnServer
                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                        objTransaction_DBSchemaForApplications.del_001_DBSchemaOfApplication()
                                                                                    End If
                                                                                End If


                                                                                MsgBox("Das Schema für die Applikation konnte nicht vernetzt werden.", MsgBoxStyle.Information)
                                                                            End If
                                                                        Else
                                                                            objSemItem_Result = objTransaction_DBSchemaForApplications.del_003_DBSchemaOfApplication_To_DBSchema
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objSemItem_Result = objTransaction_DBSchemaForApplications.del_002_DBSchemaOfApplication_To_DBOnServer
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objTransaction_DBSchemaForApplications.del_001_DBSchemaOfApplication()
                                                                                End If
                                                                            End If


                                                                            MsgBox("Das Schema für die Applikation konnte nicht vernetzt werden.", MsgBoxStyle.Information)
                                                                        End If
                                                                    Else
                                                                        objSemItem_Result = objTransaction_DBSchemaForApplications.del_003_DBSchemaOfApplication_To_DBSchema
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objSemItem_Result = objTransaction_DBSchemaForApplications.del_002_DBSchemaOfApplication_To_DBOnServer
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objTransaction_DBSchemaForApplications.del_001_DBSchemaOfApplication()
                                                                            End If
                                                                        End If


                                                                        MsgBox("Das Schema für die Applikation konnte nicht vernetzt werden.", MsgBoxStyle.Information)
                                                                    End If
                                                                Else
                                                                    objSemItem_Result = objTransaction_DBSchemaForApplications.del_002_DBSchemaOfApplication_To_DBOnServer
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objTransaction_DBSchemaForApplications.del_001_DBSchemaOfApplication()
                                                                    End If

                                                                    MsgBox("Das Schema für die Applikation konnte nicht vernetzt werden.", MsgBoxStyle.Information)
                                                                End If

                                                            Else
                                                                objTransaction_DBSchemaForApplications.del_001_DBSchemaOfApplication()
                                                                MsgBox("Das Schema für die Applikation konnte nicht vernetzt werden.", MsgBoxStyle.Information)
                                                            End If
                                                        Else
                                                            MsgBox("Das Schema für die Applikation konnte nicht vernetzt werden.", MsgBoxStyle.Information)
                                                        End If

                                                    Else
                                                        MsgBox("Wählen Sie bitte eine andere Datei!", MsgBoxStyle.Information)
                                                    End If


                                                Else
                                                    MsgBox("Bitte nur eine Datei auswählen!", MsgBoxStyle.Information)
                                                End If
                                            Else
                                                MsgBox("Bitte nur eine Datei auswählen!", MsgBoxStyle.Information)
                                            End If
                                        End If

                                    End If
                                Else
                                    MsgBox("Bitte nur eine Datenbank eines Servers aussuchen!", MsgBoxStyle.Information)
                                End If
                            Else
                                MsgBox("Bitte nur eine Datenbank eines Servers aussuchen!", MsgBoxStyle.Information)
                            End If
                        Else
                            MsgBox("Bitte nur eine Datenbank eines Servers aussuchen!", MsgBoxStyle.Information)

                        End If

                    End If

                Else
                    MsgBox("Bitte nur Datenbanken-Schemas auswählen!", MsgBoxStyle.Information)
                End If

            Else
                MsgBox("Bitte nur ein Datenbanken-Schemas auswählen!", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Bitte nur Datenbanken-Schemas auswählen!", MsgBoxStyle.Information)
        End If





    End Sub

    Private Sub ModuleSchemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuleSchemaToolStripMenuItem.Click
        Dim objSchemaType As clsSemItem

        objSchemaType = objLocalConfig.SemItem_Token_DB_Schema_Type_Module

        relate_DBSchema(objSchemaType)
    End Sub

    Private Sub ConfigSchemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigSchemaToolStripMenuItem.Click
        Dim objSchemaType As clsSemItem

        objSchemaType = objLocalConfig.SemItem_Token_DB_Schema_Type_Config

        relate_DBSchema(objSchemaType)
    End Sub
End Class
