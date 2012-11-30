Imports Sem_Manager
Imports Log_Manager
Imports Version_Module
Public Class UserControl_DBItemsView
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    'Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private funcT_Histories As New ds_Token.func_TokenTokenDataTable
    Private funcT_TokenToken As New ds_Token.func_TokenTokenDataTable
    Private semprocA_DBWork_Save_TokenAttribute_VarcharMax As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    'Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private procA_belonging_LogEntry_of_CreationScript As New ds_SchemaManagerTableAdapters.proc_belonging_LogEntry_of_CreationScriptTableAdapter
    Private procT_belonging_LogEntry_of_CreationScript As New ds_SchemaManager.proc_belonging_LogEntry_of_CreationScriptDataTable
    Private procA_TokenAttribute_Bit As New ds_TokenAttributeTableAdapters.TokenAttribute_BitTableAdapter
    Private procA_TokenAttribute_VARCHARMAX As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter

    'Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    'Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    'Private semprocA_DBWork_Save_Token_Attribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    'Private semprocA_DBwork_Del_Token_Attribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objFrmVersion As frmVersion
    Private objFrmTemplateView As frmTemplateView
    Private objFrmSemManager As frmSemManager
    Private objLogManagement As clsLogManagement

    Private objDBItemWork As clsDBItemWork

    Private objDlgVarchar_MAX As dlgAttribute_VarcharMax
    Private objSemItem_Database As clsSemItem
    Private objSemItem_Server As clsSemItem
    Private objSemItem_Item As clsSemItem
    Private objSemItem_LogEntry As clsSemItem

    Private objSemItem_DatabaseSchema As clsSemItem
    'Private GUID_DatabaseSchema As Guid

    Private objSemItem_CreationScript As clsSemItem
    'Private GUID_CreationScript As Guid
    'Private Name_CreationScript As String

    Private objSemItem_XML As clsSemItem
    'Private GUID_XML As Guid
    'Private Name_XML As String
    Private strXML_Item As String

    Private strXML As String = "<?xml version=""1.0"" encoding=""utf-8""?>" & vbCrLf & _
                "<data>" & vbCrLf & _
                "<![CDATA[@Script@" & _
                "]]>" & vbCrLf & _
                "</data>"

    'Private GUID_TokenAttribute_XMLText As Guid


    'Private GUIDs_Parameter() As Guid
    'Private GUIDs_ParameterRel() As Guid
    'Private GUIDs_ParameterRel_DBSchema() As Guid

    Private strParameters() As String

    Private date_LogEntry As Date

    Private procA_CreationScript_By_GUID_DBItem_To_Schema As New ds_SchemaManagerTableAdapters.proc_CreationScript_By_GUID_DBItem_To_SchemaTableAdapter
    Private procT_CreationScript_By_GUID_DBItem_To_Schema As New ds_SchemaManager.proc_CreationScript_By_GUID_DBItem_To_SchemaDataTable
    Private Sub get_CreationScript(ByVal objSemItem_Item As clsSemItem)
        procA_CreationScript_By_GUID_DBItem_To_Schema.Fill(procT_CreationScript_By_GUID_DBItem_To_Schema, _
                                                           objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                           objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                           objSemItem_Item.GUID_Parent, _
                                                           objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                           objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                           objLocalConfig.SemItem_Type_XML.GUID, _
                                                           objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                           objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                           objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                           objSemItem_Item.GUID)

    End Sub
    Public Sub fill_View(ByVal SemItem_Item As clsSemItem, ByVal SemItem_DBSchema As clsSemItem)
        ToolStripLabel_CountParameters.Text = DataGridView_Parameters.RowCount

        objSemItem_DatabaseSchema = SemItem_DBSchema
        objSemItem_Item = SemItem_Item
        get_CreationScript(objSemItem_Item)
        If procT_CreationScript_By_GUID_DBItem_To_Schema.Rows.Count > 0 Then
            funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_TokenToken, _
                                                  procT_CreationScript_By_GUID_DBItem_To_Schema(0).Item("GUID_CreationScript"), _
                                                  objLocalConfig.SemItem_RelationType_needs.GUID, _
                                                  objLocalConfig.SemItem_Type_DB_Parameters.GUID)

            BindingSource_Parameters.DataSource = funcT_TokenToken
            DataGridView_Parameters.DataSource = BindingSource_Parameters
            DataGridView_Parameters.Columns(0).Visible = False
            DataGridView_Parameters.Columns(1).Visible = False
            DataGridView_Parameters.Columns(2).Visible = False
            DataGridView_Parameters.Columns(3).Visible = False
            DataGridView_Parameters.Columns(4).Width = 250
            DataGridView_Parameters.Columns(5).Visible = False
            DataGridView_Parameters.Columns(6).Visible = False
            DataGridView_Parameters.Columns(7).Visible = False
            DataGridView_Parameters.Columns(8).Visible = False
            DataGridView_Parameters.Columns(9).Visible = False
            TextBox_CreationDate.Text = procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("CreationDate")
            TextBox_Script.Text = procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("XML")
        Else
            TextBox_CreationDate.Text = ""
            TextBox_Script.Text = ""
        End If
    End Sub

    Private Sub fill_HistoryView()
        If procT_CreationScript_By_GUID_DBItem_To_Schema.Rows.Count > 0 Then
            procA_belonging_LogEntry_of_CreationScript.Fill(procT_belonging_LogEntry_of_CreationScript, _
                                                                        objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                        objLocalConfig.SemItem_Attribute_Message.GUID, _
                                                                        objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                        objLocalConfig.SemItem_type_Logstate.GUID, _
                                                                        objLocalConfig.SemItem_type_User.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_provides.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belonging_history.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_wasCreatedBy.GUID)
            BindingSource_ScriptHistory.DataSource = procT_belonging_LogEntry_of_CreationScript
            DataGridView_ScriptHistory.DataSource = BindingSource_ScriptHistory


            DataGridView_ScriptHistory.Columns(1).Visible = False
            DataGridView_ScriptHistory.Columns(2).Visible = False
            DataGridView_ScriptHistory.Columns(3).Visible = False
            DataGridView_ScriptHistory.Columns(4).Visible = False
            DataGridView_ScriptHistory.Columns(5).Visible = False
            DataGridView_ScriptHistory.Columns(7).Visible = False
            DataGridView_ScriptHistory.Columns(8).Visible = False
            DataGridView_ScriptHistory.Columns(9).Visible = False
            DataGridView_ScriptHistory.Columns(11).Visible = False
            DataGridView_ScriptHistory.Columns(12).Visible = False
        Else
            funcT_Histories.Clear()
        End If

    End Sub

    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_CreationScript_By_GUID_DBItem_To_Schema.Connection = objLocalConfig.Connection_Plugin
        semprocA_DBWork_Save_TokenAttribute_VarcharMax.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        procA_belonging_LogEntry_of_CreationScript.Connection = objLocalConfig.Connection_Plugin
        'semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        'semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        'semprocA_DBWork_Save_Token_Attribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        'semprocA_DBwork_Del_Token_Attribute.Connection = objLocalConfig.Connection_DB
        'semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        'semtblA_Token_Token.Connection = objLocalConfig.Connection_DB

        objLogManagement = New clsLogManagement(objLocalConfig.Globals)

    End Sub

    Private Sub ToolStripButton_EditScript_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_EditScript.Click
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Exported As DataRowCollection
        Dim objSemItem_Logentry As clsSemItem

        Dim strValue As String

        fill_View(objSemItem_Item, objSemItem_DatabaseSchema)
        If procT_CreationScript_By_GUID_DBItem_To_Schema.Rows.Count > 0 Then
            objDlgVarchar_MAX = New dlgAttribute_VarcharMax(objLocalConfig.SemItem_Type_Creation_Scripts.Name, objLocalConfig.Globals, procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("XML"))
            objDlgVarchar_MAX.ShowDialog(Me)
            If objDlgVarchar_MAX.DialogResult = DialogResult.OK Then
                strValue = objDlgVarchar_MAX.Value
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData( _
                                        procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("GUID_XML"), _
                                        objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                        procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("GUID_Token_Attribute_XML"), _
                                        strValue, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then

                    objSemItem_Logentry = objLogManagement.log_Entry(Now, objLocalConfig.SemItem_Token_LogState_Changed.GUID, objLocalConfig.User.GUID, objLocalConfig.SemItem_Token_LogState_Changed.Name)
                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("GUID_CreationScript"), objSemItem_Logentry.GUID, objLocalConfig.SemItem_RelationType_belonging_history.GUID, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        objDRC_Exported = procA_TokenAttribute_Bit.GetData_By_GUIDAttribute_And_GUIDToken(procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID).Rows
                        If objDRC_Exported.Count = 0 Then
                            semprocA_DBWork_Save_TokenAttribute_Bit.GetData(procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID, Nothing, False, 0)
                        Else
                            semprocA_DBWork_Save_TokenAttribute_Bit.GetData(procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID, objDRC_Exported(0).Item("GUID_TokenAttribute"), False, 0)
                        End If

                        

                        objFrmVersion = New frmVersion(objLocalConfig.Globals, objSemItem_DatabaseSchema, objLocalConfig.User, False, objSemItem_Logentry)
                        objFrmVersion.ShowDialog()

                        fill_HistoryView()
                    Else
                        objLogManagement.del_LogEntry(objSemItem_Logentry.GUID)
                        MsgBox("Die Änderung konnte nicht protokolliert werden!", MsgBoxStyle.Exclamation)
                    End If
                    fill_View(objSemItem_Item, objSemItem_DatabaseSchema)
                Else
                    MsgBox("Leider konnte der Text nicht geändert werden!", MsgBoxStyle.Exclamation)
                End If
            End If

        Else
            TextBox_CreationDate.Text = ""
        End If


    End Sub



    Private Sub ToolStripButton_newDefinition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_newDefinition.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_DBItem As DataRowCollection
        Dim objDRC_Exists As DataRowCollection
        Dim objDRC_Related As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_Related As DataRow
        Dim objDRC_XML As DataRowCollection
        Dim objDatabaseConnection As New clsDatabaseConnection
        Dim objConnection As SqlClient.SqlConnection
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_DBItem As New clsSemItem
        Dim boolExists As Boolean
        Dim boolImport As Boolean = False
        Dim boolWeiter As Boolean
        Dim boolXML As Boolean
        Dim intCount_ToRelate As Integer
        Dim intCount_Related As Integer

        If Not objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Tables.GUID Then
            objDBItemWork = New clsDBItemWork(objSemItem_DatabaseSchema.GUID)
            objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Database, objLocalConfig.Globals)
            objFrmSemManager.Applyabale = True
            objFrmSemManager.ShowDialog(Me)
            If objFrmSemManager.DialogResult = DialogResult.OK Then
                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                    If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                        objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                        objDRV_Selected = objDGVR_Selected.DataBoundItem

                        If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Database.GUID Then
                            objSemItem_Database = New clsSemItem
                            objSemItem_Database.GUID = objDRV_Selected.Item("GUID_Token")
                            objSemItem_Database.Name = objDRV_Selected.Item("Name_Token")
                            objSemItem_Database.GUID_Parent = objLocalConfig.SemItem_Type_Database.GUID
                            objSemItem_Database.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Server, objLocalConfig.Globals)
                            objFrmSemManager.Applyabale = True
                            objFrmSemManager.ShowDialog(Me)
                            If objFrmSemManager.DialogResult = DialogResult.OK Then
                                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                                    If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                        objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                                        objDRV_Selected = objDGVR_Selected.DataBoundItem

                                        If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Server.GUID Then
                                            objSemItem_Server = New clsSemItem
                                            objSemItem_Server.GUID = objDRV_Selected.Item("GUID_Token")
                                            objSemItem_Server.Name = objDRV_Selected.Item("Name_Token")
                                            objSemItem_Server.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                                            objSemItem_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                            objDatabaseConnection.Name_Server = objSemItem_Server.Name
                                            objDatabaseConnection.Name_Database = objSemItem_Database.Name
                                            objConnection = New SqlClient.SqlConnection(objDatabaseConnection.ConnectionString)
                                            objDBItemWork = New clsDBItemWork(objSemItem_DatabaseSchema.GUID)
                                            boolImport = True
                                        Else
                                            MsgBox("Bitte ein Token vom Typ """ & objLocalConfig.SemItem_Type_Database.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                        End If
                                    Else
                                        MsgBox("Bitte ein Token vom Typ """ & objLocalConfig.SemItem_Type_Database.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    MsgBox("Bitte ein Token vom Typ """ & objLocalConfig.SemItem_Type_Database.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                End If
                            End If
                        Else
                            MsgBox("Bitte ein Token vom Typ """ & objLocalConfig.SemItem_Type_Database.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Bitte ein Token vom Typ """ & objLocalConfig.SemItem_Type_Database.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Bitte ein Token vom Typ """ & objLocalConfig.SemItem_Type_Database.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            boolImport = True
        End If
        
        If boolImport = True Then
            Select Case objSemItem_Item.GUID_Parent
                Case objLocalConfig.SemItem_Type_DB_Tables.GUID
                    objDRC_XML = procA_TokenAttribute_VARCHARMAX.GetData_By_GUIDAttribute_And_GUIDToken(objLocalConfig.SemItem_Token_XML_XML_Template.GUID, _
                                                                                                        objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
                    If objDRC_XML.Count > 0 Then
                        objDlgVarchar_MAX = New dlgAttribute_VarcharMax(objLocalConfig.SemItem_Type_Creation_Scripts.Name, objLocalConfig.Globals, objDRC_XML(0).Item("Val"))
                    Else
                        objDlgVarchar_MAX = New dlgAttribute_VarcharMax(objLocalConfig.SemItem_Type_Creation_Scripts.Name, objLocalConfig.Globals)
                    End If

                    objDlgVarchar_MAX.ShowDialog(Me)
                    If objDlgVarchar_MAX.DialogResult = DialogResult.OK Then
                        objDRC_DBItem = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Item.GUID, _
                                                                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                      objLocalConfig.SemItem_Type_DB_Tables.GUID).Rows
                        objSemItem_DBItem.GUID = objDRC_DBItem(0).Item("GUID_Token_Right")
                        objSemItem_DBItem.Name = objDRC_DBItem(0).Item("Name_Token_Right")
                        objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Tables.GUID
                        objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        strXML = objDlgVarchar_MAX.Value
                        objDBItemWork = New clsDBItemWork(objSemItem_DatabaseSchema.GUID)
                        objDBItemWork.SemItem_DBItem = objSemItem_DBItem
                        objSemItem_Result = objDBItemWork.save_005_CreationScript(Now)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objDBItemWork.save_007_DBItem_To_CreationScript
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objDBItemWork.save_008_XMLTemplate(strXML)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objDBItemWork.save_009_XMLText
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objDBItemWork.save_010_CreationScript_To_XMLTemplate

                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objDBItemWork.save_011_LogEntry_Creation(Now)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objDBItemWork.save_013_CreationScript_To_Logentry_Create
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    fill_View(objSemItem_Item, objSemItem_DatabaseSchema)
                                                Else
                                                    objSemItem_Result = objDBItemWork.del_011_LogEntry_Creation

                                                    objSemItem_Result = objDBItemWork.del_009_XMLText()
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                        objSemItem_Result = objDBItemWork.del_010_CreationScript_To_XMLTemplate
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objDBItemWork.del_008_XMLTemplate()
                                                            objSemItem_Result = objDBItemWork.del_007_DBItem_To_CreationScript()
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objDBItemWork.del_005_CreationScript()
                                                            End If



                                                        End If

                                                    End If


                                                    MsgBox("Das Skript konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                End If
                                            Else


                                                objSemItem_Result = objDBItemWork.del_009_XMLText()
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                    objSemItem_Result = objDBItemWork.del_010_CreationScript_To_XMLTemplate
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objDBItemWork.del_008_XMLTemplate()
                                                        objSemItem_Result = objDBItemWork.del_007_DBItem_To_CreationScript()
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objDBItemWork.del_005_CreationScript()
                                                        End If



                                                    End If

                                                End If


                                                MsgBox("Das Skript konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                            End If
                                            fill_View(objSemItem_Item, objSemItem_DatabaseSchema)
                                        Else
                                            objSemItem_Result = objDBItemWork.del_009_XMLText()
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objDBItemWork.del_008_XMLTemplate()
                                            End If

                                            objDBItemWork.del_005_CreationScript()
                                            MsgBox("Das Skript konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                        End If
                                    Else
                                        objDBItemWork.del_008_XMLTemplate()
                                        objDBItemWork.del_005_CreationScript()
                                        MsgBox("Das Skript konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    objDBItemWork.del_005_CreationScript()
                                    MsgBox("Das Skript konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                objDBItemWork.del_005_CreationScript()
                                MsgBox("Das Skript konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Das Skript konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If


                    End If
                Case objLocalConfig.SemItem_Type_DB_Function.GUID
                    Dim objSemItem_Function As New clsSemItem

                    'Dim objSemItem_FunctionInSchema As New clsSemItem

                    objFrmTemplateView = New frmTemplateView(objSemItem_Server.Name, objSemItem_Database.Name, objSemItem_Item, objSemItem_DatabaseSchema)
                    objFrmTemplateView.ShowDialog(Me)
                    If objFrmTemplateView.DialogResult = DialogResult.OK Then
                        objDRC_DBItem = objFrmTemplateView.Functions_Rows
                        If objDRC_DBItem.Count > 0 Then
                            If objDRC_DBItem(0).Item("Import") = True Then
                                objSemItem_Function.Name = objDRC_DBItem(0).Item("Function")
                                objDRC_Exists = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Function.GUID, objSemItem_Function.Name).Rows
                                If objDRC_Exists.Count > 0 Then
                                    objSemItem_Function.GUID = objDRC_Exists(0).Item("GUID_Token")

                                Else
                                    objSemItem_Function.GUID = Guid.NewGuid

                                End If
                                objSemItem_Function.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                                objSemItem_Function.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                If objDBItemWork.import_DBItem(objSemItem_Function, objConnection) = True Then

                                Else
                                    MsgBox("Die Funktion konnte nicht importiert werden!", MsgBoxStyle.Exclamation)
                                End If


                            End If
                        End If
                    End If
                Case objLocalConfig.SemItem_Type_DB_Procedure.GUID
                    Dim objSemItem_Procedure As New clsSemItem

                    objFrmTemplateView = New frmTemplateView(objSemItem_Server.Name, objSemItem_Database.Name, objSemItem_Item, objSemItem_DatabaseSchema)
                    objFrmTemplateView.ShowDialog(Me)
                    If objFrmTemplateView.DialogResult = DialogResult.OK Then
                        objDRC_DBItem = objFrmTemplateView.Procedure_Rows
                        If objDRC_DBItem.Count > 0 Then
                            If objDRC_DBItem(0).Item("Import") = True Then
                                objSemItem_Procedure.Name = objDRC_DBItem(0).Item("Procedure")
                                objDRC_Exists = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Procedure.GUID, objSemItem_Procedure.Name).Rows
                                If objDRC_Exists.Count > 0 Then
                                    objSemItem_Procedure.GUID = objDRC_Exists(0).Item("GUID_Token")

                                Else
                                    objSemItem_Procedure.GUID = Guid.NewGuid

                                End If
                                objSemItem_Procedure.GUID_Parent = objLocalConfig.SemItem_Type_DB_Procedure.GUID


                                If objDBItemWork.import_DBItem(objSemItem_Procedure, objConnection) = False Then
                                    MsgBox("Die Funktion konnte nicht importiert werden!", MsgBoxStyle.Exclamation)
                                End If

                            End If
                        End If
                    End If
                Case objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                    Dim objSemItem_Synonym As New clsSemItem

                    objFrmTemplateView = New frmTemplateView(objSemItem_Server.Name, objSemItem_Database.Name, objSemItem_Item, objSemItem_DatabaseSchema)
                    objFrmTemplateView.ShowDialog(Me)
                    If objFrmTemplateView.DialogResult = DialogResult.OK Then
                        objDRC_DBItem = objFrmTemplateView.Procedure_Rows
                        If objDRC_DBItem.Count > 0 Then
                            If objDRC_DBItem(0).Item("Import") = True Then
                                objSemItem_Synonym.Name = objDRC_DBItem(0).Item("Synonym")
                                objDRC_Exists = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Synonyms.GUID, objSemItem_Synonym.Name).Rows
                                If objDRC_Exists.Count > 0 Then
                                    objSemItem_Synonym.GUID = objDRC_Exists(0).Item("GUID_Token")

                                Else
                                    objSemItem_Synonym.GUID = Guid.NewGuid

                                End If
                                objSemItem_Synonym.GUID_Parent = objLocalConfig.SemItem_Type_DB_Synonyms.GUID


                                If objDBItemWork.import_DBItem(objSemItem_Synonym, objConnection) = False Then
                                    MsgBox("Die Funktion konnte nicht importiert werden!", MsgBoxStyle.Exclamation)
                                End If

                            End If
                        End If
                    End If
                Case objLocalConfig.SemItem_Type_Views_in_Schema.GUID

            End Select
        End If

    End Sub
    
End Class
