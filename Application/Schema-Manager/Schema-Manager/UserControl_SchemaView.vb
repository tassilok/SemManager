Imports Log_Manager
Imports Sem_Manager
Imports Localizing_Manager
Imports Version_Module
Imports System.Text.RegularExpressions
Public Class UserControl_SchemaView
    Private Const cint_ImageID_Tables As Integer = 0
    Private Const cint_ImageID_TableItem As Integer = 1
    Private Const cint_ImageID_TableItem_Needed As Integer = 2
    Private Const cint_ImageID_TableItem_Dependend As Integer = 3
    Private Const cint_ImageID_Views As Integer = 4
    Private Const cint_ImageID_ViewItem As Integer = 5
    Private Const cint_ImageID_ViewItem_Needed As Integer = 6
    Private Const cint_ImageID_ViewItem_Dependend As Integer = 7
    Private Const cint_ImageID_Procedures As Integer = 8
    Private Const cint_ImageID_ProcedureItem As Integer = 9
    Private Const cint_ImageID_ProcedureItem_Needed As Integer = 10
    Private Const cint_ImageID_ProcedureItem_Dependend As Integer = 11
    Private Const cint_ImageID_Functions As Integer = 12
    Private Const cint_ImageID_FunctionItem As Integer = 13
    Private Const cint_ImageID_FunctionItem_Needed As Integer = 14
    Private Const cint_ImageID_FunctionItem_Dependend As Integer = 15
    Private Const cint_ImageID_Synonyms As Integer = 16
    Private Const cint_ImageID_SynonymItem As Integer = 17
    Private Const cint_ImageID_SynonymItem_Needed As Integer = 18
    Private Const cint_ImageID_SynonymItem_Dependend As Integer = 19
    Private Const cint_ImageID_Triggers As Integer = 20
    Private Const cint_ImageID_TriggerItem As Integer = 21
    Private Const cint_ImageID_TriggerItem_Needed As Integer = 22
    Private Const cint_ImageID_TriggerItem_Dependend As Integer = 23
    Private Const cint_ImageID_NeededItems As Integer = 24
    Private Const cint_ImageID_DependendItems As Integer = 25
    Private Const cint_ImageID_Parameters As Integer = 26
    Private Const cint_ImageID_ParameterItem As Integer = 27
    Private Const cint_ImageID_Synonym_Servers As Integer = 28
    Private Const cint_ImageID_Synonym_Server As Integer = 29
    Private Const cint_ImageID_Synonym_Tables As Integer = 30
    Private Const cint_ImageID_Synonym_Table As Integer = 31
    Private Const cint_ImageID_Synonym_Userschemas As Integer = 32
    Private Const cint_ImageID_Synonym_Userschema As Integer = 33
    Private Const cint_ImageID_Synonym_Databases As Integer = 34
    Private Const cint_ImageID_Synonym_Database As Integer = 35
    Private Const cint_ImageID_AttributeType As Integer = 36
    Private Const cint_ImageID_RelationType As Integer = 37
    Private Const cint_ImageID_Token As Integer = 38
    Private Const cint_ImageID_Type As Integer = 39
    Private Const cint_ImageID_SemItems As Integer = 40

    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Database As Integer = 1

    Private Const cint_ImageID_FunctionsInSchema_DB As Integer = 2
    Private Const cint_ImageID_Function_DB As Integer = 3
    Private Const cint_ImageID_Funciont_DB_in As Integer = 4
    Private Const cint_ImageID_Function_DB_out As Integer = 5
    Private Const cint_ImageID_Function_DB_Definition As Integer = 6
    Private Const cint_ImageID_ProceduresInSchema_DB As Integer = 7
    Private Const cint_ImageID_Procedure_DB As Integer = 8
    Private Const cint_ImageID_Procedure_DB_in As Integer = 9
    Private Const cint_ImageID_Procedure_DB_out As Integer = 10
    Private Const cint_ImageID_Procedure_DB_Definition As Integer = 11
    Private Const cint_ImageID_SynonymInSchema_DB As Integer = 12
    Private Const cint_ImageID_Synonym_DB As Integer = 13
    Private Const cint_ImageID_Synonym_DB_in As Integer = 14
    Private Const cint_ImageID_Synonym_DB_out As Integer = 15
    Private Const cint_ImageID_Synonym_DB_Definition As Integer = 16
    Private Const cint_ImageID_TableInSchema_DB As Integer = 17
    Private Const cint_ImageID_Table_DB As Integer = 18
    Private Const cint_ImageID_Table_DB_in As Integer = 19
    Private Const cint_ImageID_Table_DB_out As Integer = 20
    Private Const cint_ImageID_Table_DB_Definition As Integer = 21
    Private Const cint_ImageID_TriggerInSchema_DB As Integer = 22
    Private Const cint_ImageID_Trigger_DB As Integer = 23
    Private Const cint_ImageID_Trigger_DB_in As Integer = 24
    Private Const cint_ImageID_Trigger_DB_out As Integer = 25
    Private Const cint_ImageID_Trigger_DB_Definition As Integer = 26
    Private Const cint_ImageID_ViewInSchema_DB As Integer = 27
    Private Const cint_ImageID_View_DB As Integer = 28
    Private Const cint_ImageID_View_DB_in As Integer = 29
    Private Const cint_ImageID_View_DB_out As Integer = 30
    Private Const cint_ImageID_View_DB_Definition As Integer = 31


    Private funcA_DatabaseSchema_with_Version_and_Logentry As New ds_SchemaManagerTableAdapters.func_DatabaseSchema_with_Version_and_LogentryTableAdapter
    Private funcT_DatabaseSchema_with_Version_and_Logentry As New ds_SchemaManager.func_DatabaseSchema_with_Version_and_LogentryDataTable
    Private procA_Item_in_Schema As New ds_SchemaManagerTableAdapters.proc_Item_in_SchemaTableAdapter
    Private procT_Item_in_Schema As New ds_SchemaManager.proc_Item_in_SchemaDataTable
    Private procA_DBItems_In_Schema As New ds_SchemaManagerTableAdapters.proc_DBItems_In_SchemaTableAdapter
    Private procT_DBItems_In_Schema As New ds_SchemaManager.proc_DBItems_In_SchemaDataTable
    Private procA_CreationScript_By_GUID_DBItem_To_Schema As New ds_SchemaManagerTableAdapters.proc_CreationScript_By_GUID_DBItem_To_SchemaTableAdapter
    Private procT_CreationScript_By_GUID_DBItem_To_Schema As New ds_SchemaManager.proc_CreationScript_By_GUID_DBItem_To_SchemaDataTable
    Private procA_CreationScript_needed_DBItems As New ds_SchemaManagerTableAdapters.proc_CreationScript_needed_DBItemsTableAdapter
    Private procT_CreationScript_needed_DBItems As New ds_SchemaManager.proc_CreationScript_needed_DBItemsDataTable
    Private procA_Parameters_of_Schema_By_GUIDSchema As New ds_SchemaManagerTableAdapters.proc_Parameters_of_Schema_By_GUIDSchemaTableAdapter
    Private procA_Database_Of_DBSchema_BY_GUIDDBSchema As New ds_SchemaManagerTableAdapters.proc_Database_Of_DBSchema_BY_GUIDDBSchemaTableAdapter
    Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter
    Private procA_SemItems_Of_CreationScripts As New ds_SchemaManagerTableAdapters.proc_SemItems_Of_CreationScriptsTableAdapter
    Private procA_SemItems_Of_DatabaseSchema As New ds_SchemaManagerTableAdapters.proc_SemItems_Of_DatabaseSchemaTableAdapter
    Private proc_XMLText_Of_CreationScript As New ds_SchemaManagerTableAdapters.proc_XMLText_Of_CreationScriptTableAdapter

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private semtblA_Token_OR As New ds_SemDBTableAdapters.semtbl_Token_ORTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcT_TokenToken As New ds_Token.func_TokenTokenDataTable

    Private procA_TokenAttribute_Bit As New ds_TokenAttributeTableAdapters.TokenAttribute_BitTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_Token_Attribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Save_Token_Attribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBwork_Del_Token_Attribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Del_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter
    Private procA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private procA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private procA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter

    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private procA_TSQL_Functions As New ds_TemplateViewTableAdapters.proc_TSQL_FunctionsTableAdapter
    Private procT_TSQL_Functions As New ds_TemplateView.proc_TSQL_FunctionsDataTable
    Private objDR_Functions As DataRow

    
    Private procA_TSQL_procedures As New ds_TemplateViewTableAdapters.proc_TSQL_ProceduresTableAdapter
    Private procT_TSQL_procedures As New ds_TemplateView.proc_TSQL_ProceduresDataTable
    Private objDR_Procedures As DataRow
    
    Private procA_TSQL_synonyms As New ds_TemplateViewTableAdapters.proc_TSQL_SynonymsTableAdapter
    Private procT_TSQL_synonyms As New ds_TemplateView.proc_TSQL_SynonymsDataTable
    Private objDR_Synonyms As DataRow
    
    Private procA_TSQL_Tables As New ds_TemplateViewTableAdapters.proc_TSQL_TablesTableAdapter
    Private procT_TSQL_Tables As New ds_TemplateView.proc_TSQL_TablesDataTable
    Private objDR_Tables As DataRow
    
    Private procA_TSQL_triggers As New ds_TemplateViewTableAdapters.proc_TSQL_TriggersTableAdapter
    Private procT_TSQL_Triggers As New ds_TemplateView.proc_TSQL_TriggersDataTable
    Private objDR_Triggers As DataRow

    Private procA_TSQL_views As New ds_TemplateViewTableAdapters.proc_TSQL_ViewsTableAdapter
    Private procT_TSQL_Views As New ds_TemplateView.proc_TSQL_ViewsDataTable
    Private objDR_Views As DataRow

    Private procA_TSQL_ObjectReferences As New ds_TemplateViewTableAdapters.proc_TSQL_ObjectDefinitionTableAdapter
    Private procA_TSQL_Parameters As New ds_TemplateViewTableAdapters.proc_TSQL_ParametersTableAdapter
    
    Private objFrmSchemaManager As frmSchemaManager
    Private objFrmTemplateView As frmTemplateView
    Private objFrmSemManager As frmSemManager
    Private WithEvents objUserControl_Localize As UserControl_Localized
    Private objUserControl_DBItemsView As UserControl_DBItemsView
    Private objFrmDocumentation As frmSchemaDocumentation
    Private objFrmVersion As frmVersion
    Private objFrm_SemManager As frmSemManager
    Private objDlg_AttributeVarchar255 As dlgAttribute_Varchar255

    Private objRegExp As Regex

    Private objTransaction_DBSchema As clsTransaction_DBSchema

    Private objDBItemWork As clsDBItemWork
    Private objSemItem_Server As clsSemItem
    Private objSemItem_DBSchema As clsSemItem

    Private objSemItems_Language() As clsSemItem

    Private objTreeNode_Database As TreeNode
    Private objDatabaseConnection As New clsDatabaseConnection
    'Private objDatabases() As clsDatabase
    'Private intDatabaseID As Integer
    Private boolDatabases_All As Boolean

    Private objSemDBWork As clsDBWork
    
    Private Name_Schema As String
    Private objSemItem_XML As clsSemItem
    'Private GUID_XML As Guid
    'Private Name_XML As String
    'Private strXML_Function As String
    'Private GUID_TokenAttribute_XMLText As Guid
    Private objLogManagement As clsLogManagement
    'Private date_LogEntry As Date
    Private objSemItem_LogEntry As clsSemItem
    Private strParameters() As String
    'Private GUIDs_Parameter() As Guid = Nothing
    'Private GUIDs_ParameterRel_CreationScript() As Guid = Nothing
    'Private GUIDs_ParameterRel_DBSchema() As Guid = Nothing

    Private GUID_DatabaseSchema As Guid

    Private objThread As Threading.Thread

    Private objSemItem_Selected As clsSemItem

    Private objSemItem_CreationScript As clsSemItem
    Private objDependent As clsDependent = Nothing

    Private strName_Database As String
    Private strName_Server As String

    Private tblDBItemInSchema As New ds_SchemaManager.tblDBItemInSchemaDataTable

    Private intRowsDone As Integer
    Private boolNodesDone As Boolean

    Public Event Selected_Item()

    Private Sub description_changed(ByVal objSemItem_Related As clsSemItem) Handles objUserControl_Localize.changed_Text
        Dim objDRC_Exported As DataRowCollection
        If objSemItem_Related.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID Or _
            objSemItem_Related.GUID_Parent = objLocalConfig.SemItem_Type_DB_Procedure.GUID Or _
            objSemItem_Related.GUID_Parent = objLocalConfig.SemItem_Type_DB_Synonyms.GUID Or _
            objSemItem_Related.GUID_Parent = objLocalConfig.SemItem_Type_DB_Tables.GUID Or _
            objSemItem_Related.GUID_Parent = objLocalConfig.SemItem_Type_DB_Triggers.GUID Or _
            objSemItem_Related.GUID_Parent = objLocalConfig.SemItem_Type_DB_Views.GUID Then
            objDRC_Exported = procA_TokenAttribute_Bit.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_Related.GUID, objLocalConfig.SemItem_Attribute_is_exported.GUID).Rows
            If objDRC_Exported.Count > 0 Then
                semprocA_DBWork_Save_Token_Attribute_Bit.GetData(objSemItem_Related.GUID, objLocalConfig.SemItem_Attribute_is_exported.GUID, objDRC_Exported(0).Item("GUID_TokenAttribute"), False, 0)
            Else
                semprocA_DBWork_Save_Token_Attribute_Bit.GetData(objSemItem_Related.GUID, objLocalConfig.SemItem_Attribute_is_exported.GUID, Nothing, False, 0)
            End If
        End If
    End Sub

    Public ReadOnly Property SemItem_Selected() As clsSemItem
        Get
            Return objSemItem_Selected
        End Get
    End Property

    Public Property Applyable() As Boolean
        Get
            Return ApplyToolStripMenuItem.Visible
        End Get
        Set(ByVal value As Boolean)
            ApplyToolStripMenuItem.Visible = value
            ApplyToolStripMenuItem1.Visible = value
        End Set
    End Property


    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        funcA_DatabaseSchema_with_Version_and_Logentry.Connection = objLocalConfig.Connection_Plugin
        procA_Item_in_Schema.Connection = objLocalConfig.Connection_Plugin
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Token_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_Attribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_Attribute_Bit.Connection = objLocalConfig.Connection_DB
        semprocA_DBwork_Del_Token_Attribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token_OR.Connection = objLocalConfig.Connection_DB
        semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
        semtblA_Token_OR.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_CreationScript_By_GUID_DBItem_To_Schema.Connection = objLocalConfig.Connection_Plugin
        procA_CreationScript_needed_DBItems.Connection = objLocalConfig.Connection_Plugin
        procA_Parameters_of_Schema_By_GUIDSchema.Connection = objLocalConfig.Connection_Plugin
        procA_DBItems_In_Schema.Connection = objLocalConfig.Connection_Plugin
        procA_Database_Of_DBSchema_BY_GUIDDBSchema.Connection = objLocalConfig.Connection_Plugin
        procA_SemItems_Of_CreationScripts.Connection = objLocalConfig.Connection_Plugin
        procA_SemItems_Of_DatabaseSchema.Connection = objLocalConfig.Connection_Plugin

        procA_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        proc_XMLText_Of_CreationScript.Connection = objLocalConfig.Connection_Plugin

        procA_DBWork_Save_OR_Attribute.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_RelationType.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Type.Connection = objLocalConfig.Connection_DB

        procA_TSQL_ObjectReferences.Connection = objLocalConfig.Connection_DB
        procA_TSQL_Functions.Connection = objLocalConfig.Connection_DB
        procA_TSQL_Parameters.Connection = objLocalConfig.Connection_DB
        procA_TSQL_procedures.Connection = objLocalConfig.Connection_DB
        procA_TSQL_synonyms.Connection = objLocalConfig.Connection_DB
        procA_TSQL_Tables.Connection = objLocalConfig.Connection_DB
        procA_TSQL_triggers.Connection = objLocalConfig.Connection_DB
        procA_TSQL_views.Connection = objLocalConfig.Connection_DB

        objTransaction_DBSchema = New clsTransaction_DBSchema

        objLogManagement = New clsLogManagement(objLocalConfig.Globals)
        objUserControl_Localize = New UserControl_Localized(objLocalConfig.Globals)
        objUserControl_DBItemsView = New UserControl_DBItemsView
        objUserControl_DBItemsView.Dock = DockStyle.Fill

        procA_CreationScript_needed_DBItems.ClearBeforeFill = False
    End Sub

    Public Sub initialize()
        fill_SchemaView()
    End Sub

    Private Sub fill_SchemaView()
        funcA_DatabaseSchema_with_Version_and_Logentry.Fill(funcT_DatabaseSchema_with_Version_and_Logentry, _
                                                            objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                            objLocalConfig.SemItem_Attribute_Create_Datatypes.GUID, _
                                                            objLocalConfig.SemItem_Attribute_Create_Object_Reference_Typs.GUID, _
                                                            objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                            objLocalConfig.SemItem_type_DevelopmentVersion.GUID, _
                                                            objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                            objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                            objLocalConfig.SemItem_RelationType_was_created_at.GUID)
        BindingSource_Schemas.DataSource = funcT_DatabaseSchema_with_Version_and_Logentry
        DataGridView_Schemas.DataSource = BindingSource_Schemas

        DataGridView_Schemas.Columns(0).Visible = False
        DataGridView_Schemas.Columns(1).Width = 300
        DataGridView_Schemas.Columns(2).Visible = False
        DataGridView_Schemas.Columns(3).Visible = False
        DataGridView_Schemas.Columns(5).Visible = False
        DataGridView_Schemas.Columns(6).Visible = False
        DataGridView_Schemas.Columns(7).Visible = False
        DataGridView_Schemas.Columns(8).Visible = False
        DataGridView_Schemas.Columns(9).Visible = False
        DataGridView_Schemas.Columns(11).Visible = False
        DataGridView_Schemas.Columns(12).Visible = False

        ToolStripLabel_SchemaCount.Text = DataGridView_Schemas.RowCount

        objUserControl_Localize.Dock = DockStyle.Fill
        SplitContainer3.Panel2.Controls.Clear()
        SplitContainer3.Panel2.Controls.Add(objUserControl_Localize)

        'fill_SchemaTree()
    End Sub

    Private Sub fill_SchemaTree()
        Dim objTreeNode_DBTables As TreeNode
        Dim objTreeNode_DBViews As TreeNode
        Dim objTreeNode_DBProcedures As TreeNode
        Dim objTreeNode_DBFunctions As TreeNode
        Dim objTreeNode_DBSynonyms As TreeNode
        Dim objTreeNode_DBTriggers As TreeNode
        Dim objTreeNode_DBItem As TreeNode
        Dim objTreeNode_Parameters As TreeNode
        Dim objTreeNode_SemItems As TreeNode
        Dim objDRC_SchemaItem As DataRowCollection
        Dim objDR_SchemaItem As DataRow
        Dim objDRC_SemItem As DataRowCollection
        Dim objDR_SemItem As DataRow

        TreeView_SchemaItems.Nodes.Clear()
        objTreeNode_DBTables = TreeView_SchemaItems.Nodes.Add(objLocalConfig.SemItem_Type_DB_Tables.GUID.ToString, objLocalConfig.SemItem_Type_DB_Tables.Name, cint_ImageID_Tables, cint_ImageID_Tables)
        objTreeNode_DBViews = TreeView_SchemaItems.Nodes.Add(objLocalConfig.SemItem_Type_DB_Views.GUID.ToString, objLocalConfig.SemItem_Type_DB_Views.Name, cint_ImageID_Views, cint_ImageID_Views)
        objTreeNode_DBProcedures = TreeView_SchemaItems.Nodes.Add(objLocalConfig.SemItem_Type_DB_Procedure.GUID.ToString, objLocalConfig.SemItem_Type_DB_Procedure.Name, cint_ImageID_Procedures, cint_ImageID_Procedures)
        objTreeNode_DBFunctions = TreeView_SchemaItems.Nodes.Add(objLocalConfig.SemItem_Type_DB_Function.GUID.ToString, objLocalConfig.SemItem_Type_DB_Function.Name, cint_ImageID_Functions, cint_ImageID_Functions)
        objTreeNode_DBSynonyms = TreeView_SchemaItems.Nodes.Add(objLocalConfig.SemItem_Type_DB_Synonyms.GUID.ToString, objLocalConfig.SemItem_Type_DB_Synonyms.Name, cint_ImageID_Synonyms, cint_ImageID_Synonyms)
        objTreeNode_DBTriggers = TreeView_SchemaItems.Nodes.Add(objLocalConfig.SemItem_Type_DB_Triggers.GUID.ToString, objLocalConfig.SemItem_Type_DB_Triggers.Name, cint_ImageID_Triggers, cint_ImageID_Triggers)
        objTreeNode_Parameters = TreeView_SchemaItems.Nodes.Add(objLocalConfig.SemItem_Type_DB_Parameters.GUID.ToString, objLocalConfig.SemItem_Type_DB_Parameters.Name, cint_ImageID_Parameters, cint_ImageID_Parameters)
        objTreeNode_SemItems = TreeView_SchemaItems.Nodes.Add(objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID.ToString, objLocalConfig.SemItem_RelationType_needed_semantic_Object.Name, cint_ImageID_SemItems, cint_ImageID_SemItems)

        objDRC_SchemaItem = procA_Item_in_Schema.GetData(objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                         objLocalConfig.SemItem_Type_Functions_in_Schema.GUID, _
                                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                         GUID_DatabaseSchema).Rows
        objTreeNode_DBFunctions.Text = objTreeNode_DBFunctions.Text & " (" & objDRC_SchemaItem.Count & ")"
        For Each objDR_SchemaItem In objDRC_SchemaItem
            objTreeNode_DBItem = objTreeNode_DBFunctions.Nodes.Add(objDR_SchemaItem.Item("GUID_ItemInSchema").ToString, objDR_SchemaItem.Item("Name_DBItem"), cint_ImageID_FunctionItem, cint_ImageID_FunctionItem)
            'get_dependencies(objTreeNode_DBItem)
        Next

        objDRC_SchemaItem = procA_Item_in_Schema.GetData(objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                         objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID, _
                                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                         GUID_DatabaseSchema).Rows
        objTreeNode_DBProcedures.Text = objTreeNode_DBProcedures.Text & " (" & objDRC_SchemaItem.Count & ")"
        For Each objDR_SchemaItem In objDRC_SchemaItem
            objTreeNode_DBItem = objTreeNode_DBProcedures.Nodes.Add(objDR_SchemaItem.Item("GUID_ItemInSchema").ToString, objDR_SchemaItem.Item("Name_DBItem"), cint_ImageID_ProcedureItem, cint_ImageID_ProcedureItem)

        Next

        objDRC_SchemaItem = procA_Item_in_Schema.GetData(objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                                 objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID, _
                                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                 GUID_DatabaseSchema).Rows

        objTreeNode_DBSynonyms.Text = objTreeNode_DBSynonyms.Text & " (" & objDRC_SchemaItem.Count & ")"
        For Each objDR_SchemaItem In objDRC_SchemaItem
            objTreeNode_DBItem = objTreeNode_DBSynonyms.Nodes.Add(objDR_SchemaItem.Item("GUID_DBItem").ToString, objDR_SchemaItem.Item("Name_DBItem"), cint_ImageID_SynonymItem, cint_ImageID_SynonymItem)
            get_SynonymTreeData(objTreeNode_DBItem)
        Next

        objDRC_SchemaItem = procA_Item_in_Schema.GetData(objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                                 objLocalConfig.SemItem_Type_Tables_in_Schema.GUID, _
                                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                 GUID_DatabaseSchema).Rows

        objTreeNode_DBTables.Text = objTreeNode_DBTables.Text & " (" & objDRC_SchemaItem.Count & ")"
        For Each objDR_SchemaItem In objDRC_SchemaItem
            objTreeNode_DBItem = objTreeNode_DBTables.Nodes.Add(objDR_SchemaItem.Item("GUID_ItemInSchema").ToString, objDR_SchemaItem.Item("Name_DBItem"), cint_ImageID_TableItem, cint_ImageID_TableItem)

        Next

        objDRC_SchemaItem = procA_Item_in_Schema.GetData(objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                 objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID, _
                                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                 GUID_DatabaseSchema).Rows

        objTreeNode_DBTriggers.Text = objTreeNode_DBTriggers.Text & " (" & objDRC_SchemaItem.Count & ")"
        For Each objDR_SchemaItem In objDRC_SchemaItem
            objTreeNode_DBItem = objTreeNode_DBTriggers.Nodes.Add(objDR_SchemaItem.Item("GUID_ItemInSchema").ToString, objDR_SchemaItem.Item("Name_DBItem"), cint_ImageID_TriggerItem, cint_ImageID_TriggerItem)
            '    get_dependencies(objTreeNode_DBItem)
        Next

        objDRC_SchemaItem = procA_Item_in_Schema.GetData(objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                 objLocalConfig.SemItem_Type_Views_in_Schema.GUID, _
                                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                 GUID_DatabaseSchema).Rows

        objTreeNode_DBViews.Text = objTreeNode_DBViews.Text & " (" & objDRC_SchemaItem.Count & ")"
        For Each objDR_SchemaItem In objDRC_SchemaItem
            objTreeNode_DBItem = objTreeNode_DBViews.Nodes.Add(objDR_SchemaItem.Item("GUID_ItemInSchema").ToString, objDR_SchemaItem.Item("Name_DBItem"), cint_ImageID_ViewItem, cint_ImageID_ViewItem)

        Next

        'objDRC_SchemaItem = procA_Parameters_of_Schema_By_GUIDSchema.GetData(objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_DB_Parameters.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_Views_in_Schema.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_Functions_in_Schema.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_Tables_in_Schema.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_DB_Function.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_DB_Tables.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
        '                                                                     objLocalConfig.SemItem_Type_DB_Views.GUID, _
        '                                                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
        '                                                                     objLocalConfig.SemItem_RelationType_creation_template.GUID, _
        '                                                                     objLocalConfig.SemItem_RelationType_needs.GUID, _
        '                                                                     GUID_DatabaseSchema).Rows
        objDRC_SchemaItem = funcA_TokenToken.GetData_TokenToken_LeftRight(GUID_DatabaseSchema, objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Parameters.GUID).Rows
        objTreeNode_Parameters.Text = objTreeNode_Parameters.Text & " (" & objDRC_SchemaItem.Count & ")"
        For Each objDR_SchemaItem In objDRC_SchemaItem
            objTreeNode_DBItem = objTreeNode_Parameters.Nodes.Add(objDR_SchemaItem.Item("GUID_Token_Right").ToString, objDR_SchemaItem.Item("Name_Token_Right"), cint_ImageID_ParameterItem, cint_ImageID_ParameterItem)
        Next

        objDRC_SemItem = procA_SemItems_Of_DatabaseSchema.GetData(objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                                  objLocalConfig.SemItem_Type_Semantic_Objects_of_DB_Schema.GUID, _
                                                                  objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID, _
                                                                  GUID_DatabaseSchema).Rows
        objTreeNode_SemItems.Text = objTreeNode_SemItems.Text & " (" & objDRC_SemItem.Count & ")"
        For Each objDR_SemItem In objDRC_SemItem
            Select Case objDR_SemItem.Item("GUID_ItemType")

                Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                    objTreeNode_DBItem = objTreeNode_SemItems.Nodes.Add(objDR_SemItem.Item("GUID_Ref").ToString, objDR_SemItem.Item("Name_Token"), cint_ImageID_AttributeType, cint_ImageID_AttributeType)

                Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                    objTreeNode_DBItem = objTreeNode_SemItems.Nodes.Add(objDR_SemItem.Item("GUID_Ref").ToString, objDR_SemItem.Item("Name_Token"), cint_ImageID_RelationType, cint_ImageID_RelationType)

                Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objTreeNode_DBItem = objTreeNode_SemItems.Nodes.Add(objDR_SemItem.Item("GUID_Ref").ToString, objDR_SemItem.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)

                Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                    objTreeNode_DBItem = objTreeNode_SemItems.Nodes.Add(objDR_SemItem.Item("GUID_Ref").ToString, objDR_SemItem.Item("Name_Token"), cint_ImageID_Type, cint_ImageID_Type)

            End Select

        Next

    End Sub

    Private Sub fill_TabPages()
        Select Case TabControl1.SelectedTab.Name
            Case TabPage_SchemaItems.Name
                fill_SchemaDetail()
            Case TabPage_Databases.Name
                fill_DatabaseDetail()
        End Select
    End Sub


    Private Sub DataGridView_Schemas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Schemas.SelectionChanged
        fill_TabPages()
    End Sub

    Private Sub fill_DatabaseDetail()
        Dim objDRC_DatabaseOnServer As DataRowCollection
        Dim objDR_DatabaseOnServer As DataRow
        Dim objTreeNode_Root As TreeNode
        Dim objTreeNode_Function As TreeNode
        Dim objTreeNode_Procedure As TreeNode
        Dim objTreeNode_Synonym As TreeNode
        Dim objTreeNode_Table As TreeNode
        Dim objTreeNode_Trigger As TreeNode
        Dim objTreeNode_View As TreeNode
        Dim objDR_DBItem As DataRow
        Dim intCount_Databases As Integer
        TreeView_DatabasesOfSchema.Nodes.Clear()
        objDRC_DatabaseOnServer = procA_Database_Of_DBSchema_BY_GUIDDBSchema.GetData(GUID_DatabaseSchema, _
                                                                                      objLocalConfig.SemItem_Type_Database.GUID, _
                                                                                      objLocalConfig.SemItem_Type_Database_on_Server.GUID, _
                                                                                      objLocalConfig.SemItem_Type_Server.GUID, _
                                                                                      objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                                      objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                                                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        objTreeNode_Root = TreeView_DatabasesOfSchema.Nodes.Add(objLocalConfig.SemItem_Type_Database_on_Server.GUID.ToString, objLocalConfig.SemItem_Type_Database_on_Server.Name, cint_ImageID_Root, cint_ImageID_Root)

        


        boolDatabases_All = False
        For Each objDR_DatabaseOnServer In objDRC_DatabaseOnServer
            


            objTreeNode_Database = objTreeNode_Root.Nodes.Add(objDR_DatabaseOnServer.Item("GUID_SemDB").ToString, objDR_DatabaseOnServer.Item("Name_SemDB") & "@" & objDR_DatabaseOnServer.Item("Name_Server"), cint_ImageID_Database, cint_ImageID_Database)
            objDatabaseConnection.Name_Database = objDR_DatabaseOnServer.Item("Name_SemDB")
            objDatabaseConnection.Name_Server = objDR_DatabaseOnServer.Item("Name_Server")

            objTreeNode_Function = objTreeNode_Database.Nodes.Add(objLocalConfig.SemItem_Type_DB_Function.GUID.ToString, objLocalConfig.SemItem_Type_DB_Function.Name, cint_ImageID_FunctionsInSchema_DB, cint_ImageID_FunctionsInSchema_DB)
            objTreeNode_Procedure = objTreeNode_Database.Nodes.Add(objLocalConfig.SemItem_Type_DB_Procedure.GUID.ToString, objLocalConfig.SemItem_Type_DB_Procedure.Name, cint_ImageID_ProceduresInSchema_DB, cint_ImageID_ProceduresInSchema_DB)
            objTreeNode_Synonym = objTreeNode_Database.Nodes.Add(objLocalConfig.SemItem_Type_DB_Synonyms.GUID.ToString, objLocalConfig.SemItem_Type_DB_Synonyms.Name, cint_ImageID_SynonymInSchema_DB, cint_ImageID_SynonymInSchema_DB)
            objTreeNode_Table = objTreeNode_Database.Nodes.Add(objLocalConfig.SemItem_Type_DB_Tables.GUID.ToString, objLocalConfig.SemItem_Type_DB_Tables.Name, cint_ImageID_TableInSchema_DB, cint_ImageID_TableInSchema_DB)
            objTreeNode_Trigger = objTreeNode_Database.Nodes.Add(objLocalConfig.SemItem_Type_DB_Triggers.GUID.ToString, objLocalConfig.SemItem_Type_DB_Triggers.Name, cint_ImageID_TriggerInSchema_DB, cint_ImageID_TriggerInSchema_DB)
            objTreeNode_View = objTreeNode_Database.Nodes.Add(objLocalConfig.SemItem_Type_DB_Views.GUID.ToString, objLocalConfig.SemItem_Type_DB_Views.Name, cint_ImageID_ViewInSchema_DB, cint_ImageID_ViewInSchema_DB)

            Try
                get_Functions_Of_Database()
                get_Procedures_Of_Database()
                get_Synonyms_Of_Database()
                get_Tables_Of_Database()
                get_Trigger_Of_Database()
                get_Views_Of_Database()

                objTreeNode_Function.Text = objTreeNode_Function.Text & " (" & procT_TSQL_Functions.Rows.Count & ")"
                objTreeNode_Procedure.Text = objTreeNode_Procedure.Text & " (" & procT_TSQL_procedures.Rows.Count & ")"
                objTreeNode_Synonym.Text = objTreeNode_Synonym.Text & " (" & procT_TSQL_synonyms.Rows.Count & ")"
                objTreeNode_Table.Text = objTreeNode_Table.Text & " (" & procT_TSQL_Tables.Rows.Count & ")"
                objTreeNode_Trigger.Text = objTreeNode_Trigger.Text & " (" & procT_TSQL_Triggers.Rows.Count & ")"
                objTreeNode_View.Text = objTreeNode_View.Text & " (" & procT_TSQL_Views.Rows.Count & ")"

                For Each objDR_DBItem In procT_TSQL_Functions.Rows
                    objTreeNode_Function.Nodes.Add(objDR_DBItem.Item("ROUTINE_NAME"), objDR_DBItem.Item("ROUTINE_NAME"), cint_ImageID_Function_DB, cint_ImageID_Function_DB)
                Next

                For Each objDR_DBItem In procT_TSQL_procedures.Rows
                    objTreeNode_Procedure.Nodes.Add(objDR_DBItem.Item("name"), objDR_DBItem.Item("name"), cint_ImageID_Procedure_DB, cint_ImageID_Procedure_DB)
                Next

                For Each objDR_DBItem In procT_TSQL_synonyms.Rows
                    objTreeNode_Synonym.Nodes.Add(objDR_DBItem.Item("name"), objDR_DBItem.Item("name"), cint_ImageID_Synonym_DB, cint_ImageID_Synonym_DB)
                Next

                For Each objDR_DBItem In procT_TSQL_Tables.Rows
                    objTreeNode_Table.Nodes.Add(objDR_DBItem.Item("name"), objDR_DBItem.Item("name"), cint_ImageID_Table_DB, cint_ImageID_Table_DB)
                Next

                For Each objDR_DBItem In procT_TSQL_Triggers.Rows
                    objTreeNode_Trigger.Nodes.Add(objDR_DBItem.Item("name"), objDR_DBItem.Item("name"), cint_ImageID_Trigger_DB, cint_ImageID_Trigger_DB)
                Next

                For Each objDR_DBItem In procT_TSQL_Views.Rows
                    objTreeNode_View.Nodes.Add(objDR_DBItem.Item("name"), objDR_DBItem.Item("name"), cint_ImageID_View_DB, cint_ImageID_View_DB)
                Next
            Catch ex As Exception
                objTreeNode_Database.BackColor = Color.Red
            End Try
            

            
            objTreeNode_Database.Expand()

        Next
        boolDatabases_All = True
    End Sub

    Private Sub get_Functions_Of_Database()
        Dim objConnection As SqlClient.SqlConnection

        objConnection = New SqlClient.SqlConnection(objDatabaseConnection.ConnectionString)
        procA_TSQL_Functions.Connection = objConnection
        procA_TSQL_Functions.Fill(procT_TSQL_Functions)


    End Sub

    Private Sub get_Procedures_Of_Database()
        Dim objConnection As SqlClient.SqlConnection

        objConnection = New SqlClient.SqlConnection(objDatabaseConnection.ConnectionString)
        procA_TSQL_procedures.Connection = objConnection
        procA_TSQL_procedures.Fill(procT_TSQL_procedures)

    End Sub

    Private Sub get_Synonyms_Of_Database()
        Dim objConnection As SqlClient.SqlConnection

        objConnection = New SqlClient.SqlConnection(objDatabaseConnection.ConnectionString)
        procA_TSQL_synonyms.Connection = objConnection
        procA_TSQL_synonyms.Fill(procT_TSQL_synonyms)

    End Sub

    Private Sub get_Tables_Of_Database()
        Dim objConnection As SqlClient.SqlConnection

        objConnection = New SqlClient.SqlConnection(objDatabaseConnection.ConnectionString)
        procA_TSQL_Tables.Connection = objConnection
        procA_TSQL_Tables.Fill(procT_TSQL_Tables)

    End Sub

    Private Sub get_Trigger_Of_Database()
        Dim objConnection As SqlClient.SqlConnection

        objConnection = New SqlClient.SqlConnection(objDatabaseConnection.ConnectionString)
        procA_TSQL_triggers.Connection = objConnection
        procA_TSQL_triggers.Fill(procT_TSQL_Triggers)

    End Sub

    Private Sub get_Views_Of_Database()
        Dim objConnection As SqlClient.SqlConnection

        objConnection = New SqlClient.SqlConnection(objDatabaseConnection.ConnectionString)
        procA_TSQL_views.Connection = objConnection
        procA_TSQL_views.Fill(procT_TSQL_Views)

    End Sub

    Private Sub fill_SchemaDetail()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_SchemaItems As DataRowView
        Dim objDRC_Languageas As DataRowCollection
        Dim objDR_Language As DataRow
        Dim intLangCount As Integer
        TextBox_SchemaName.ReadOnly = True
        CheckBox_AttributeTypes.Enabled = False
        TextBox_Version.Text = ""
        If DataGridView_Schemas.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Schemas.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            GUID_DatabaseSchema = objDRV_Selected.Item("GUID_DatabaseSchema")
            TextBox_SchemaName.Text = objDRV_Selected.Item("Name_DatabaseSchema")
            TextBox_SchemaName.ReadOnly = False
            TextBox_Version.Text = objDRV_Selected.Item("Name_DevelopmentVersion")
            CheckBox_AttributeTypes.Checked = objDRV_Selected.Item("CreateDatatypes")
            CheckBox_AttributeTypes.Enabled = True
            CheckBox_ObjectReferenceTypes.Checked = objDRV_Selected.Item("Create_ObjectReferenceType")
            CheckBox_ObjectReferenceTypes.Enabled = True
            objDRC_Languageas = funcA_TokenToken.GetData_TokenToken_LeftRight(GUID_DatabaseSchema, objLocalConfig.SemItem_RelationType_isDescribedBy.GUID, objLocalConfig.SemItem_Type_Language.GUID).Rows
            intLangCount = 0
            objSemItems_Language = Nothing
            For Each objDR_Language In objDRC_Languageas
                ReDim Preserve objSemItems_Language(intLangCount)
                objSemItems_Language(intLangCount) = New clsSemItem
                objSemItems_Language(intLangCount).GUID = objDR_Language.Item("GUID_Token_Right")
                objSemItems_Language(intLangCount).Name = objDR_Language.Item("Name_Token_Right")
                objSemItems_Language(intLangCount).GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
                objSemItems_Language(intLangCount).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                intLangCount = intLangCount + 1
            Next
            fill_SchemaTree()
        End If
    End Sub

    Private Sub GetFromTemplateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetFromTemplateToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objDRV_Selected As DataRowView

        Dim objConnection As SqlClient.SqlConnection
        Dim objDRC_Exists As DataRowCollection

        Dim objDR_ToImport As DataRow
        Dim boolGetTemplate As Boolean = False
        Dim objSemItem_import As clsSemItem = Nothing
        Dim objSemItem_Schema As New clsSemItem

        Dim boolVersion As Boolean = False

        objTreeNode = TreeView_SchemaItems.SelectedNode

        objSemItem_Schema.GUID = GUID_DatabaseSchema
        objSemItem_Schema.Name = Name_Schema
        objSemItem_Schema.GUID_Parent = objLocalConfig.SemItem_Type_Database_Schema.GUID
        objSemItem_Schema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Functions
                    boolGetTemplate = True
                    objSemItem_import = objLocalConfig.SemItem_Type_DB_Function
                Case cint_ImageID_Procedures
                    boolGetTemplate = True
                    objSemItem_import = objLocalConfig.SemItem_Type_DB_Procedure
                Case cint_ImageID_Synonyms
                    boolGetTemplate = True
                    objSemItem_import = objLocalConfig.SemItem_Type_DB_Synonyms
                Case cint_ImageID_Tables
                    boolGetTemplate = True
                    objSemItem_import = objLocalConfig.SemItem_Type_DB_Tables
                Case cint_ImageID_Triggers
                    boolGetTemplate = True
                    objSemItem_import = objLocalConfig.SemItem_Type_DB_Triggers
                Case cint_ImageID_Views
                    boolGetTemplate = True
                    objSemItem_import = objLocalConfig.SemItem_Type_DB_Views

            End Select
        End If
        objDBItemWork = New clsDBItemWork(GUID_DatabaseSchema)
        If boolGetTemplate = True Then

            Name_Schema = objTreeNode.Text
            objFrmSchemaManager = New frmSchemaManager(objLocalConfig.Globals)
            objFrmSchemaManager.isApplyable = True
            objFrmSchemaManager.ShowDialog(Me)
            If objFrmSchemaManager.DialogResult = DialogResult.OK Then
                objDRV_Selected = objFrmSchemaManager.DRV_Selected
                objSemItem_Server = objFrmSchemaManager.Server

                If objFrmSchemaManager.isSemView = True Then

                Else
                    objDatabaseConnection = New clsDatabaseConnection
                    objDatabaseConnection.Name_Database = objDRV_Selected.Item("Database")
                    objDatabaseConnection.Name_Server = objSemItem_Server.Name
                    objConnection = New SqlClient.SqlConnection(objDatabaseConnection.ConnectionString)

                    objFrmTemplateView = New frmTemplateView(objSemItem_Server.Name, objDRV_Selected.Item("Database"), objSemItem_import, objSemItem_Schema)
                    objFrmTemplateView.ShowDialog(Me)
                    If objFrmTemplateView.DialogResult = DialogResult.OK Then
                        Select Case objSemItem_import.GUID
                            Case objLocalConfig.SemItem_Type_DB_Function.GUID
                                Dim objSemItem_Function As New clsSemItem

                                Dim intFunctions_Done As Integer = 0
                                Dim intFunctions_ToDo As Integer = 0


                                For Each objDR_ToImport In objFrmTemplateView.Functions_Rows
                                    If objDR_ToImport.Item("Import") = True Then

                                        intFunctions_ToDo = intFunctions_ToDo + 1
                                        objSemItem_Function.Name = objDR_ToImport.Item("Function")
                                        objDRC_Exists = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Function.GUID, objSemItem_Function.Name).Rows
                                        If objDRC_Exists.Count = 0 Then
                                            objSemItem_Function.GUID = Guid.NewGuid
                                            objSemItem_Function.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                                            objSemItem_Function.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                        Else
                                            objSemItem_Function.GUID = objDRC_Exists(0).Item("GUID_Token")
                                            objSemItem_Function.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                                            objSemItem_Function.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                        End If
                                        If objDBItemWork.import_DBItem(objSemItem_Function, objConnection) = True Then
                                            intFunctions_Done = intFunctions_Done + 1
                                        End If

                                    End If



                                Next
                                If intFunctions_Done < intFunctions_ToDo Then
                                    MsgBox("Es konnten leider nur " & intFunctions_Done & " Funktionen von " & intFunctions_ToDo & " eingefügt werden!", MsgBoxStyle.Exclamation)
                                End If
                                If intFunctions_Done > 0 Then

                                    objFrmVersion = New frmVersion(objLocalConfig.Globals, objSemItem_Schema, objLocalConfig.User, True)
                                    objFrmVersion.ShowDialog(Me.ParentForm)
                                End If
                            Case objLocalConfig.SemItem_Type_DB_Procedure.GUID
                                Dim objSemItem_Procedure As New clsSemItem


                                Dim intProcedures_Done As Integer = 0
                                Dim intProcedures_ToDo As Integer = 0

                                For Each objDR_ToImport In objFrmTemplateView.Procedure_Rows
                                    If objDR_ToImport.Item("Import") = True Then
                                        intProcedures_ToDo = intProcedures_ToDo + 1
                                        objSemItem_Procedure.Name = objDR_ToImport.Item("Procedure")
                                        objDRC_Exists = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Procedure.GUID, objSemItem_Procedure.Name).Rows
                                        If objDRC_Exists.Count > 0 Then
                                            objSemItem_Procedure.GUID = objDRC_Exists(0).Item("GUID_Token")
                                            objSemItem_Procedure.GUID_Parent = objLocalConfig.SemItem_Type_DB_Procedure.GUID
                                        Else
                                            objSemItem_Procedure.GUID = Guid.NewGuid
                                            objSemItem_Procedure.GUID_Parent = objLocalConfig.SemItem_Type_DB_Procedure.GUID
                                        End If

                                        objSemItem_Procedure.GUID_Parent = objLocalConfig.SemItem_Type_DB_Procedure.GUID
                                        If objDBItemWork.import_DBItem(objSemItem_Procedure, objConnection) = True Then
                                            intProcedures_Done = intProcedures_Done + 1
                                        End If

                                    End If

                                Next
                                If intProcedures_Done < intProcedures_ToDo Then
                                    MsgBox("Es konnten leider nur " & intProcedures_Done & " von " & intProcedures_ToDo & " Prozeduren importiert werden!", MsgBoxStyle.Exclamation)
                                End If
                                If intProcedures_Done > 0 Then

                                    objFrmVersion = New frmVersion(objLocalConfig.Globals, objSemItem_Schema, objLocalConfig.User, True)
                                    objFrmVersion.ShowDialog()
                                End If
                            Case objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                                Dim objSemItem_Synonym As New clsSemItem

                                Dim intSynonym_Done As Integer = 0
                                Dim intSynonym_ToDo As Integer = 0

                                For Each objDR_ToImport In objFrmTemplateView.Synonyms_Rows
                                    If objDR_ToImport.Item("Import") = True Then
                                        intSynonym_ToDo = intSynonym_ToDo + 1
                                        objSemItem_Synonym.Name = objDR_ToImport.Item("Synonym")
                                        objDRC_Exists = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Synonyms.GUID, objSemItem_Synonym.Name).Rows
                                        If objDRC_Exists.Count > 0 Then
                                            objSemItem_Synonym.GUID = objDRC_Exists(0).Item("GUID_Token")
                                            objSemItem_Synonym.GUID_Parent = objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                                        Else
                                            objSemItem_Synonym.GUID = Guid.NewGuid
                                            objSemItem_Synonym.GUID_Parent = objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                                        End If

                                        objSemItem_Synonym.GUID_Parent = objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                                        If objDBItemWork.import_DBItem(objSemItem_Synonym, objConnection) = True Then
                                            intSynonym_Done = intSynonym_Done + 1
                                        End If

                                    End If

                                Next
                                If intSynonym_Done < intSynonym_ToDo Then
                                    MsgBox("Es konnten leider nur " & intSynonym_Done & " von " & intSynonym_ToDo & " Synonyme importiert werden!", MsgBoxStyle.Exclamation)
                                End If
                                If intSynonym_Done > 0 Then

                                    objFrmVersion = New frmVersion(objLocalConfig.Globals, objSemItem_Schema, objLocalConfig.User, True)
                                    objFrmVersion.ShowDialog()
                                End If
                            Case objLocalConfig.SemItem_Type_DB_Tables.GUID
                                Dim objSemItem_Table As New clsSemItem

                                Dim intTable_Done As Integer = 0
                                Dim intTable_ToDo As Integer = 0

                                For Each objDR_ToImport In objFrmTemplateView.Table_Rows
                                    If objDR_ToImport.Item("Import") = True Then
                                        intTable_ToDo = intTable_ToDo + 1
                                        objSemItem_Table.Name = objDR_ToImport.Item("Table")
                                        objDRC_Exists = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Tables.GUID, objSemItem_Table.Name).Rows
                                        If objDRC_Exists.Count > 0 Then
                                            objSemItem_Table.GUID = objDRC_Exists(0).Item("GUID_Token")
                                            objSemItem_Table.GUID_Parent = objLocalConfig.SemItem_Type_DB_Tables.GUID
                                        Else
                                            objSemItem_Table.GUID = Guid.NewGuid
                                            objSemItem_Table.GUID_Parent = objLocalConfig.SemItem_Type_DB_Tables.GUID
                                        End If

                                        objSemItem_Table.GUID_Parent = objLocalConfig.SemItem_Type_DB_Tables.GUID
                                        If objDBItemWork.import_DBItem(objSemItem_Table, objConnection) = True Then
                                            intTable_Done = intTable_Done + 1
                                        End If

                                    End If

                                Next
                                If intTable_Done < intTable_ToDo Then
                                    MsgBox("Es konnten leider nur " & intTable_Done & " von " & intTable_ToDo & " Tablee importiert werden!", MsgBoxStyle.Exclamation)
                                End If
                                If intTable_Done > 0 Then

                                    objFrmVersion = New frmVersion(objLocalConfig.Globals, objSemItem_Schema, objLocalConfig.User, True)
                                    objFrmVersion.ShowDialog()
                                End If
                            Case objLocalConfig.SemItem_Type_DB_Triggers.GUID
                                Dim objSemItem_Trigger As New clsSemItem

                                Dim intTrigger_Done As Integer = 0
                                Dim intTrigger_ToDo As Integer = 0

                                For Each objDR_ToImport In objFrmTemplateView.Trigger_Rows
                                    If objDR_ToImport.Item("Import") = True Then
                                        intTrigger_ToDo = intTrigger_ToDo + 1
                                        objSemItem_Trigger.Name = objDR_ToImport.Item("Trigger")
                                        objDRC_Exists = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Triggers.GUID, objSemItem_Trigger.Name).Rows
                                        If objDRC_Exists.Count > 0 Then
                                            objSemItem_Trigger.GUID = objDRC_Exists(0).Item("GUID_Token")
                                            objSemItem_Trigger.GUID_Parent = objLocalConfig.SemItem_Type_DB_Triggers.GUID
                                        Else
                                            objSemItem_Trigger.GUID = Guid.NewGuid
                                            objSemItem_Trigger.GUID_Parent = objLocalConfig.SemItem_Type_DB_Triggers.GUID
                                        End If

                                        objSemItem_Trigger.GUID_Parent = objLocalConfig.SemItem_Type_DB_Triggers.GUID
                                        If objDBItemWork.import_DBItem(objSemItem_Trigger, objConnection) = True Then
                                            intTrigger_Done = intTrigger_Done + 1
                                        End If

                                    End If

                                Next
                                If intTrigger_Done < intTrigger_ToDo Then
                                    MsgBox("Es konnten leider nur " & intTrigger_Done & " von " & intTrigger_ToDo & " Triggere importiert werden!", MsgBoxStyle.Exclamation)
                                End If
                                If intTrigger_Done > 0 Then

                                    objFrmVersion = New frmVersion(objLocalConfig.Globals, objSemItem_Schema, objLocalConfig.User, True)
                                    objFrmVersion.ShowDialog()
                                End If
                            Case objLocalConfig.SemItem_Type_DB_Views.GUID
                                Dim objSemItem_View As New clsSemItem

                                Dim intView_Done As Integer = 0
                                Dim intView_ToDo As Integer = 0

                                For Each objDR_ToImport In objFrmTemplateView.Views_Rows
                                    If objDR_ToImport.Item("Import") = True Then
                                        intView_ToDo = intView_ToDo + 1
                                        objSemItem_View.Name = objDR_ToImport.Item("View")
                                        objDRC_Exists = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Views.GUID, objSemItem_View.Name).Rows
                                        If objDRC_Exists.Count > 0 Then
                                            objSemItem_View.GUID = objDRC_Exists(0).Item("GUID_Token")
                                            objSemItem_View.GUID_Parent = objLocalConfig.SemItem_Type_DB_Views.GUID
                                        Else
                                            objSemItem_View.GUID = Guid.NewGuid
                                            objSemItem_View.GUID_Parent = objLocalConfig.SemItem_Type_DB_Views.GUID
                                        End If

                                        objSemItem_View.GUID_Parent = objLocalConfig.SemItem_Type_DB_Views.GUID
                                        If objDBItemWork.import_DBItem(objSemItem_View, objConnection) = True Then
                                            intView_Done = intView_Done + 1
                                        End If

                                    End If

                                Next
                                If intView_Done < intView_ToDo Then
                                    MsgBox("Es konnten leider nur " & intView_Done & " von " & intView_ToDo & " Viewe importiert werden!", MsgBoxStyle.Exclamation)
                                End If
                                If intView_Done > 0 Then

                                    objFrmVersion = New frmVersion(objLocalConfig.Globals, objSemItem_Schema, objLocalConfig.User, True)
                                    objFrmVersion.ShowDialog()
                                End If
                        End Select
                    End If
                End If
            End If
        End If
    End Sub
    


    Private Sub ContextMenuStrip_SchemaTree_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_SchemaTree.Opening
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_SchemaItems.SelectedNode
        GetFromTemplateToolStripMenuItem.Enabled = False
        SetDependenciesToolStripMenuItem.Enabled = False
        SynonymsToolStripMenuItem.Enabled = False
        SchemaItemsToolStripMenuItem.Enabled = False
        GetSubItemToolStripMenuItem_Synonyms.Enabled = False
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Functions
                    GetFromTemplateToolStripMenuItem.Enabled = True
                    SetDependenciesToolStripMenuItem.Enabled = True
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_Procedures
                    GetFromTemplateToolStripMenuItem.Enabled = True
                    SetDependenciesToolStripMenuItem.Enabled = True
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_Synonyms
                    GetFromTemplateToolStripMenuItem.Enabled = True
                    SetDependenciesToolStripMenuItem.Enabled = True
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_Tables
                    GetFromTemplateToolStripMenuItem.Enabled = True
                    
                Case cint_ImageID_Triggers
                    GetFromTemplateToolStripMenuItem.Enabled = True
                    SetDependenciesToolStripMenuItem.Enabled = True
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_Views
                    GetFromTemplateToolStripMenuItem.Enabled = True
                    SetDependenciesToolStripMenuItem.Enabled = True
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_FunctionItem
                    SetDependenciesToolStripMenuItem.Enabled = True
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_ProcedureItem
                    SetDependenciesToolStripMenuItem.Enabled = True
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_SynonymItem
                    SetDependenciesToolStripMenuItem.Enabled = True
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_TableItem
                    SetDependenciesToolStripMenuItem.Enabled = True
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_TriggerItem
                    SetDependenciesToolStripMenuItem.Enabled = True
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_ViewItem
                    SetDependenciesToolStripMenuItem.Enabled = True
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_Synonym_Databases
                    If objTreeNode.Nodes.Count = 0 Then
                        SynonymsToolStripMenuItem.Enabled = True
                        GetSubItemToolStripMenuItem_Synonyms.Enabled = True
                    End If
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_Synonym_Servers
                    If objTreeNode.Nodes.Count = 0 Then
                        SynonymsToolStripMenuItem.Enabled = True
                        GetSubItemToolStripMenuItem_Synonyms.Enabled = True
                    End If
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_Synonym_Tables
                    If objTreeNode.Nodes.Count = 0 Then
                        SynonymsToolStripMenuItem.Enabled = True
                        GetSubItemToolStripMenuItem_Synonyms.Enabled = True
                    End If
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_Synonym_Userschemas
                    If objTreeNode.Nodes.Count = 0 Then
                        SynonymsToolStripMenuItem.Enabled = True
                        GetSubItemToolStripMenuItem_Synonyms.Enabled = True
                    End If
                    SchemaItemsToolStripMenuItem.Enabled = True
                Case cint_ImageID_SemItems
                    SetDependenciesToolStripMenuItem.Enabled = True
                    SemItemsToolStripMenuItem.Enabled = True
            End Select
        End If
    End Sub

   
    Private Sub show_SchemaItem_Detail(ByVal objSemItem_Item As clsSemItem)
        Dim objDRC_DBItem As DataRowCollection
        Dim objSemItem_DBItem As New clsSemItem
        Dim objSemItem_DatabaseSchema As New clsSemItem

        objSemItem_DatabaseSchema.GUID = GUID_DatabaseSchema
        objSemItem_DatabaseSchema.GUID_Parent = objLocalConfig.SemItem_Type_Database_Schema.GUID
        objSemItem_DatabaseSchema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        SplitContainer3.Panel1.Controls.Clear()
        Select Case objSemItem_Item.GUID_Parent
            Case objLocalConfig.SemItem_Type_DB_Function.GUID
                objDRC_DBItem = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Item.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_DB_Function.GUID).Rows
                If objDRC_DBItem.Count > 0 Then
                    objSemItem_DBItem.GUID = objDRC_DBItem(0).Item("GUID_Token_Right")
                    objSemItem_DBItem.Name = objDRC_DBItem(0).Item("Name_Token_Right")
                    objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                    objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objUserControl_Localize.initialize(objSemItem_DBItem, objSemItems_Language, False)
                    objUserControl_Localize.Enabled = True
                Else
                    objUserControl_Localize.clear_LanguageTree()
                    objUserControl_Localize.Enabled = False
                End If

                objUserControl_DBItemsView.fill_View(objSemItem_Item, objSemItem_DatabaseSchema)
                SplitContainer3.Panel1.Controls.Add(objUserControl_DBItemsView)
            Case objLocalConfig.SemItem_Type_DB_Parameters.GUID
                objDRC_DBItem = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Item.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_DB_Parameters.GUID).Rows

                If objDRC_DBItem.Count > 0 Then
                    objSemItem_DBItem.GUID = objDRC_DBItem(0).Item("GUID_Token_Right")
                    objSemItem_DBItem.Name = objDRC_DBItem(0).Item("Name_Token_Right")
                    objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                    objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objUserControl_Localize.initialize(objSemItem_DBItem, objSemItems_Language, False)
                    objUserControl_Localize.Enabled = True
                Else
                    objUserControl_Localize.clear_LanguageTree()
                    objUserControl_Localize.Enabled = False
                End If
            Case objLocalConfig.SemItem_Type_DB_Procedure.GUID
                objDRC_DBItem = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Item.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_DB_Procedure.GUID).Rows
                If objDRC_DBItem.Count > 0 Then
                    objSemItem_DBItem.GUID = objDRC_DBItem(0).Item("GUID_Token_Right")
                    objSemItem_DBItem.Name = objDRC_DBItem(0).Item("Name_Token_Right")
                    objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                    objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objUserControl_Localize.initialize(objSemItem_DBItem, objSemItems_Language, False)
                    objUserControl_Localize.Enabled = True
                Else
                    objUserControl_Localize.clear_LanguageTree()
                    objUserControl_Localize.Enabled = False
                End If
                objUserControl_DBItemsView.fill_View(objSemItem_Item, objSemItem_DatabaseSchema)

                SplitContainer3.Panel1.Controls.Add(objUserControl_DBItemsView)
            Case objLocalConfig.SemItem_Type_DB_Synonyms.GUID


                objUserControl_Localize.initialize(objSemItem_Item, objSemItems_Language, False)
                objUserControl_Localize.Enabled = True
                
                objUserControl_DBItemsView.fill_View(objSemItem_Item, objSemItem_DatabaseSchema)

                SplitContainer3.Panel1.Controls.Add(objUserControl_DBItemsView)
            Case objLocalConfig.SemItem_Type_DB_Tables.GUID
                objDRC_DBItem = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Item.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_DB_Tables.GUID).Rows
                If objDRC_DBItem.Count > 0 Then
                    objSemItem_DBItem.GUID = objDRC_DBItem(0).Item("GUID_Token_Right")
                    objSemItem_DBItem.Name = objDRC_DBItem(0).Item("Name_Token_Right")
                    objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                    objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objUserControl_Localize.initialize(objSemItem_DBItem, objSemItems_Language, False)
                    objUserControl_Localize.Enabled = True
                Else
                    objUserControl_Localize.clear_LanguageTree()
                    objUserControl_Localize.Enabled = False
                End If

                objUserControl_DBItemsView.fill_View(objSemItem_Item, objSemItem_DatabaseSchema)

                SplitContainer3.Panel1.Controls.Add(objUserControl_DBItemsView)

            Case objLocalConfig.SemItem_Type_DB_Triggers.GUID
                objDRC_DBItem = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Item.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_DB_Triggers.GUID).Rows
                If objDRC_DBItem.Count > 0 Then
                    objSemItem_DBItem.GUID = objDRC_DBItem(0).Item("GUID_Token_Right")
                    objSemItem_DBItem.Name = objDRC_DBItem(0).Item("Name_Token_Right")
                    objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                    objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objUserControl_Localize.initialize(objSemItem_DBItem, objSemItems_Language, False)
                    objUserControl_Localize.Enabled = True
                Else
                    objUserControl_Localize.clear_LanguageTree()
                    objUserControl_Localize.Enabled = False
                End If
                objUserControl_DBItemsView.fill_View(objSemItem_Item, objSemItem_DatabaseSchema)

                SplitContainer3.Panel1.Controls.Add(objUserControl_DBItemsView)
            Case objLocalConfig.SemItem_Type_DB_Views.GUID
                objDRC_DBItem = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Item.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_DB_Views.GUID).Rows
                If objDRC_DBItem.Count > 0 Then
                    objSemItem_DBItem.GUID = objDRC_DBItem(0).Item("GUID_Token_Right")
                    objSemItem_DBItem.Name = objDRC_DBItem(0).Item("Name_Token_Right")
                    objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                    objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objUserControl_Localize.initialize(objSemItem_DBItem, objSemItems_Language, False)
                    objUserControl_Localize.Enabled = True
                Else
                    objUserControl_Localize.clear_LanguageTree()
                    objUserControl_Localize.Enabled = False
                End If

                objUserControl_DBItemsView.fill_View(objSemItem_Item, objSemItem_DatabaseSchema)

                SplitContainer3.Panel1.Controls.Add(objUserControl_DBItemsView)
        End Select





    End Sub


    Private Sub SetDependenciesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetDependenciesToolStripMenuItem.Click

    End Sub

    Private Sub get_dependencies()
        Dim objDR_Node As DataRow
        Dim GUID_Type_DBItem As Guid
        Dim boolGetDepends As Boolean
        boolGetDepends = False

        For Each objDR_Node In tblDBItemInSchema.Rows
            Select Case objDR_Node.Item("ImageID")
                Case cint_ImageID_FunctionItem

                    GUID_Type_DBItem = objLocalConfig.SemItem_Type_DB_Function.GUID
                    boolGetDepends = True
                Case cint_ImageID_ProcedureItem

                    GUID_Type_DBItem = objLocalConfig.SemItem_Type_DB_Procedure.GUID
                    boolGetDepends = True
                Case cint_ImageID_SynonymItem
                    GUID_Type_DBItem = objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                    boolGetDepends = True
                Case cint_ImageID_TriggerItem

                    GUID_Type_DBItem = objLocalConfig.SemItem_Type_DB_Triggers.GUID
                    boolGetDepends = True
                Case cint_ImageID_TableItem
                    boolGetDepends = True
                    GUID_Type_DBItem = objLocalConfig.SemItem_Type_DB_Tables.GUID
                Case cint_ImageID_ViewItem

                    GUID_Type_DBItem = objLocalConfig.SemItem_Type_DB_Views.GUID
                    boolGetDepends = True
                Case Else
                    boolGetDepends = False
            End Select

            If boolGetDepends Then


                procA_CreationScript_needed_DBItems.Fill(procT_CreationScript_needed_DBItems, _
                                                         objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                            objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                            objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                            objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                            objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                            objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                                            objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                                            objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                            objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                            objLocalConfig.SemItem_RelationType_needs.GUID, _
                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                            objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                            objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                            GUID_Type_DBItem, _
                                                            objDR_Node.Item("GUID_DBItemInSchema"))

                
            End If
        Next

        boolNodesDone = True
    End Sub
    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objDRC_NeededItems As DataRowCollection
        Dim GUID_NeededItem As Guid
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Exported As DataRowCollection
        Dim objSemItem_Ref As New clsSemItem

        objSemItem_Selected = New clsSemItem
        objTreeNode = TreeView_SchemaItems.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_FunctionItem
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Functions_in_Schema.GUID
                    objSemItem_Selected.GUID_Related = objLocalConfig.SemItem_Type_DB_Function.GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Case cint_ImageID_ProcedureItem
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID
                    objSemItem_Selected.GUID_Related = objLocalConfig.SemItem_Type_DB_Procedure.GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Case cint_ImageID_SynonymItem
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID
                    objSemItem_Selected.GUID_Related = objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Case cint_ImageID_TableItem
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Tables_in_Schema.GUID
                    objSemItem_Selected.GUID_Related = objLocalConfig.SemItem_Type_DB_Tables.GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Case cint_ImageID_TriggerItem
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID
                    objSemItem_Selected.GUID_Related = objLocalConfig.SemItem_Type_DB_Triggers.GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Case cint_ImageID_ViewItem
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Views_in_Schema.GUID
                    objSemItem_Selected.GUID_Related = objLocalConfig.SemItem_Type_DB_Views.GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Case Else
                    objSemItem_Selected = Nothing
            End Select
        End If
        If objDependent Is Nothing Then
            RaiseEvent Selected_Item()
        Else
            If Not objSemItem_Selected Is Nothing Then

                If objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Tables_in_Schema.GUID Or _
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID Or _
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Functions_in_Schema.GUID Or _
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Views_in_Schema.GUID Then

                    procA_CreationScript_By_GUID_DBItem_To_Schema.Fill(procT_CreationScript_By_GUID_DBItem_To_Schema, _
                                                                   objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                   objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                   objDependent.SemItem_Dependent.GUID_Parent, _
                                                                   objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                   objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                   objLocalConfig.SemItem_Type_XML.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                   objDependent.SemItem_Dependent.GUID)
                    If procT_CreationScript_By_GUID_DBItem_To_Schema.Rows.Count > 0 Then
                        Select Case objSemItem_Selected.GUID_Parent

                            Case objLocalConfig.SemItem_Type_Tables_in_Schema.GUID
                                objDRC_NeededItems = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Selected.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_DB_Tables.GUID).Rows
                                GUID_NeededItem = objDRC_NeededItems(0).Item("GUID_Token_Right")
                            Case objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID

                                GUID_NeededItem = objSemItem_Selected.GUID
                            Case objLocalConfig.SemItem_Type_Functions_in_Schema.GUID
                                objDRC_NeededItems = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Selected.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_DB_Function.GUID).Rows
                                GUID_NeededItem = objDRC_NeededItems(0).Item("GUID_Token_Right")
                            Case objLocalConfig.SemItem_Type_Views_in_Schema.GUID
                                objDRC_NeededItems = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Selected.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_DB_Views.GUID).Rows
                                GUID_NeededItem = objDRC_NeededItems(0).Item("GUID_Token_Right")
                        End Select
                        If semtblA_Token_Token.Count_By_GUIDs(procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("GUID_CreationScript"), _
                                                                                           objLocalConfig.SemItem_RelationType_needs.GUID, _
                                                                                           GUID_NeededItem) = 0 Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("GUID_CreationScript"), _
                                                                                           GUID_NeededItem, objLocalConfig.SemItem_RelationType_needs.GUID, _
                                                                                           0).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                objDRC_Exported = procA_TokenAttribute_Bit.GetData_By_GUIDAttribute_And_GUIDToken(procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID).Rows
                                If objDRC_Exported.Count = 0 Then

                                    semprocA_DBWork_Save_Token_Attribute_Bit.GetData(procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID, Nothing, False, 0)


                                Else
                                    semprocA_DBWork_Save_Token_Attribute_Bit.GetData(procT_CreationScript_By_GUID_DBItem_To_Schema.Rows(0).Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID, objDRC_Exported(0).Item("GUID_TokenAttribute"), False, 0)

                                End If

                                objSemItem_Ref = New clsSemItem
                                objSemItem_Ref.GUID = GUID_DatabaseSchema
                                objSemItem_Ref.Name = ""
                                objSemItem_Ref.GUID_Parent = objLocalConfig.SemItem_Type_Database_Schema.GUID
                                objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objFrmVersion = New frmVersion(objLocalConfig.Globals, objSemItem_Ref, objLocalConfig.User, True)
                                objFrmVersion.ShowDialog(Me.ParentForm)

                                tblDBItemInSchema.Clear()
                                tblDBItemInSchema.Rows.Add(New Guid(objDependent.TreeNode_DBItem.Name), objDependent.TreeNode_DBItem.ImageIndex)
                                procT_CreationScript_needed_DBItems.Clear()
                                get_dependencies()
                                boolNodesDone = True
                                intRowsDone = 0
                                TimerNodes.Start()
                                TreeView_DatabasesOfSchema.SelectedNode = objDependent.TreeNode_DBItem
                                objDependent.TreeNode_DBItem.ExpandAll()
                            Else
                                MsgBox("Die Verknüpfung konnte leider nicht gespeichert werden!", MsgBoxStyle.Exclamation)

                            End If
                        End If
                    Else
                        MsgBox("Bitte erst die Definition des DB-Items anlegen!", MsgBoxStyle.Exclamation)

                    End If
                Else
                    MsgBox("Bitte nur """ & objLocalConfig.SemItem_Type_DB_Function.Name & """, """ & _
                           objLocalConfig.SemItem_Type_DB_Synonyms.Name & """, """ & _
                           objLocalConfig.SemItem_Type_DB_Tables.Name & """ oder """ & _
                           objLocalConfig.SemItem_Type_DB_Views.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                End If
                objDependent = Nothing
            End If
            ToolStripLabel_SelectDBItem.Enabled = False
            Applyable = False
        End If

    End Sub

    Private Sub UserControl_SchemaView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

   

    Private Sub get_SynonymTreeData(ByVal objTreeNode As TreeNode)
        Dim objDRC_Related As DataRowCollection

        Dim objTreeNode_Servers As TreeNode
        Dim objTreeNode_Tables As TreeNode
        Dim objTreeNode_UserSchemas As TreeNode
        Dim objTreeNode_Databases As TreeNode

        Dim objTreeNode_Server As TreeNode
        Dim objTreeNode_Table As TreeNode
        Dim objTreeNode_UserSchema As TreeNode
        Dim objTreeNode_Database As TreeNode

        objTreeNode.Nodes.Clear()

        'objTreeNode_Databases = objTreeNode.Nodes.Add(objLocalConfig.SemItem_Type_Database.GUID.ToString, objLocalConfig.SemItem_Type_Database.Name, cint_ImageID_Synonym_Databases, cint_ImageID_Synonym_Databases)
        'objTreeNode_Servers = objTreeNode.Nodes.Add(objLocalConfig.SemItem_Type_Server.GUID.ToString, objLocalConfig.SemItem_Type_Server.Name, cint_ImageID_Synonym_Servers, cint_ImageID_Synonym_Servers)
        objTreeNode_Tables = objTreeNode.Nodes.Add(objLocalConfig.SemItem_Type_DB_Tables.GUID.ToString, objLocalConfig.SemItem_Type_DB_Tables.Name, cint_ImageID_Synonym_Tables, cint_ImageID_Synonym_Tables)
        objTreeNode_UserSchemas = objTreeNode.Nodes.Add(objLocalConfig.SemItem_Type_Userschema.GUID.ToString, objLocalConfig.SemItem_Type_Userschema.Name, cint_ImageID_Synonym_Userschemas, cint_ImageID_Synonym_Userschemas)



        procA_DBItems_In_Schema.Fill(procT_DBItems_In_Schema, _
                                     objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                     objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                     objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                     objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                     objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                     objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                     objLocalConfig.SemItem_Type_Functions_in_Schema.GUID, _
                                     objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID, _
                                     objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID, _
                                     objLocalConfig.SemItem_Type_Tables_in_Schema.GUID, _
                                     objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID, _
                                     objLocalConfig.SemItem_Type_Views_in_Schema.GUID, _
                                     objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                     GUID_DatabaseSchema, _
                                     New Guid(objTreeNode.Name))

        If procT_DBItems_In_Schema.Rows.Count > 0 Then
            'objDRC_Related = funcA_TokenToken.GetData_TokenToken_LeftRight(procT_DBItems_In_Schema.Rows(0).Item("GUID_DBItemInSchema"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Server.GUID).Rows
            'If objDRC_Related.Count > 0 Then
            '    objTreeNode_Server = objTreeNode_Servers.Nodes.Add(objDRC_Related(0).Item("GUID_Token_Right").ToString, objDRC_Related(0).Item("Name_Token_Right"), cint_ImageID_Synonym_Server, cint_ImageID_Synonym_Server)

            'End If

            objDRC_Related = funcA_TokenToken.GetData_TokenToken_LeftRight(procT_DBItems_In_Schema.Rows(0).Item("GUID_DBItemInSchema"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Tables.GUID).Rows
            If objDRC_Related.Count > 0 Then
                objTreeNode_Table = objTreeNode_Tables.Nodes.Add(objDRC_Related(0).Item("GUID_Token_Right").ToString, objDRC_Related(0).Item("Name_Token_Right"), cint_ImageID_Synonym_Table, cint_ImageID_Synonym_Table)

            End If

            objDRC_Related = funcA_TokenToken.GetData_TokenToken_LeftRight(procT_DBItems_In_Schema.Rows(0).Item("GUID_DBItemInSchema"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Userschema.GUID).Rows
            If objDRC_Related.Count > 0 Then
                objTreeNode_UserSchema = objTreeNode_UserSchemas.Nodes.Add(objDRC_Related(0).Item("GUID_Token_Right").ToString, objDRC_Related(0).Item("Name_Token_Right"), cint_ImageID_Synonym_Userschema, cint_ImageID_Synonym_Userschema)

            End If

            'objDRC_Related = funcA_TokenToken.GetData_TokenToken_LeftRight(procT_DBItems_In_Schema.Rows(0).Item("GUID_DBItemInSchema"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Database.GUID).Rows
            'If objDRC_Related.Count > 0 Then
            '    objTreeNode_Database = objTreeNode_Databases.Nodes.Add(objDRC_Related(0).Item("GUID_Token_Right").ToString, objDRC_Related(0).Item("Name_Token_Right"), cint_ImageID_Synonym_Database, cint_ImageID_Synonym_Database)

            'End If
        End If
    End Sub

    Private Sub GetSubItemToolStripMenuItem_Synonyms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetSubItemToolStripMenuItem_Synonyms.Click
        Dim objTreeNode As TreeNode
        Dim objDRC_Item As DataRowCollection
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Exported As DataRowCollection
        Dim objSemItem_Table As clsSemItem
        Dim objSemItem_UserSchema As clsSemItem

        objTreeNode = TreeView_SchemaItems.SelectedNode
        procA_DBItems_In_Schema.Fill(procT_DBItems_In_Schema, _
                                     objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                     objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                     objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                     objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                     objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                     objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                     objLocalConfig.SemItem_Type_Functions_in_Schema.GUID, _
                                     objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID, _
                                     objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID, _
                                     objLocalConfig.SemItem_Type_Tables_in_Schema.GUID, _
                                     objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID, _
                                     objLocalConfig.SemItem_Type_Views_in_Schema.GUID, _
                                     objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                     GUID_DatabaseSchema, _
                                     New Guid(objTreeNode.Parent.Name))

        If Not objTreeNode Is Nothing Then

            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Synonym_Databases
                    objDRC_Item = funcA_TokenToken.GetData_TokenToken_LeftRight(procT_DBItems_In_Schema.Rows(0).Item("GUID_DBItemInSchema"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Database.GUID).Rows
                    If objDRC_Item.Count = 0 Then

                        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Database, objLocalConfig.Globals)
                        objFrmSemManager.Applyabale = True
                        objFrmSemManager.ShowDialog(Me)
                        If objFrmSemManager.DialogResult = DialogResult.OK Then
                            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Database.GUID Then
                                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(procT_DBItems_In_Schema.Rows(0).Item("GUID_DBItemInSchema"), objDRV_Selected.Item("GUID_Token"), objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows
                                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                            objDRC_Exported = procA_TokenAttribute_Bit.GetData_By_GUIDAttribute_And_GUIDToken(procT_DBItems_In_Schema(0).Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID).Rows
                                            If objDRC_Exported.Count = 0 Then
                                                semprocA_DBWork_Save_Token_Attribute_Bit.GetData(procT_DBItems_In_Schema(0).Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID, Nothing, False, 0)
                                            Else
                                                semprocA_DBWork_Save_Token_Attribute_Bit.GetData(procT_DBItems_In_Schema(0).Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID, objDRC_Exported(0).Item("GUID_TokenAttribute"), False, 0)
                                            End If
                                            get_SynonymTreeData(objTreeNode.Parent)
                                        Else
                                            MsgBox("Das Database-Item konnte mit dem Synonym nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                        End If
                                    Else
                                        MsgBox("Bitte nur ein Token der Type """ & objLocalConfig.SemItem_Type_Database.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    MsgBox("Bitte nur ein Token der Type """ & objLocalConfig.SemItem_Type_Database.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Bitte nur ein Token der Type """ & objLocalConfig.SemItem_Type_Database.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    Else
                        get_SynonymTreeData(objTreeNode.Parent)
                    End If
                Case cint_ImageID_Synonym_Servers
                    objDRC_Item = funcA_TokenToken.GetData_TokenToken_LeftRight(procT_DBItems_In_Schema.Rows(0).Item("GUID_DBItemInSchema"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Server.GUID).Rows
                    If objDRC_Item.Count = 0 Then
                        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Server, objLocalConfig.Globals)
                        objFrmSemManager.Applyabale = True
                        objFrmSemManager.ShowDialog(Me)
                        If objFrmSemManager.DialogResult = DialogResult.OK Then
                            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Server.GUID Then
                                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(procT_DBItems_In_Schema.Rows(0).Item("GUID_DBItemInSchema"), objDRV_Selected.Item("GUID_Token"), objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows
                                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                            get_SynonymTreeData(objTreeNode.Parent)
                                        Else
                                            MsgBox("Das Database-Item konnte mit dem Synonym nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                        End If
                                    Else
                                        MsgBox("Bitte nur ein Token der Type """ & objLocalConfig.SemItem_Type_Server.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    MsgBox("Bitte nur ein Token der Type """ & objLocalConfig.SemItem_Type_Server.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Bitte nur ein Token der Type """ & objLocalConfig.SemItem_Type_Server.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    Else
                        get_SynonymTreeData(objTreeNode.Parent)
                    End If
                Case cint_ImageID_Synonym_Tables
                    objSemItem_Table = Nothing
                    objDRC_Item = funcA_TokenToken.GetData_TokenToken_LeftRight(procT_DBItems_In_Schema.Rows(0).Item("GUID_DBItemInSchema"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Tables.GUID).Rows
                    If objDRC_Item.Count = 0 Then
                        objDRC_Item = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                                                                       objTreeNode.Parent.Text).Rows
                        If objDRC_Item.Count > 0 Then
                            objSemItem_Table = New clsSemItem
                            objSemItem_Table.GUID = objDRC_Item(0).Item("GUID_Token")
                            objSemItem_Table.Name = objDRC_Item(0).Item("Name_Token")
                            objSemItem_Table.GUID_Parent = objLocalConfig.SemItem_Type_DB_Tables.GUID
                            objSemItem_Table.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        Else
                            objSemItem_Table = Nothing
                            objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_DB_Tables, objLocalConfig.Globals)
                            objFrmSemManager.Applyabale = True
                            objFrmSemManager.ShowDialog(Me)
                            If objFrmSemManager.DialogResult = DialogResult.OK Then
                                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                                    If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                        objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                                        If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_DB_Tables.GUID Then
                                            objSemItem_Table = New clsSemItem
                                            objSemItem_Table.GUID = objDRV_Selected.Item("GUID_Token")
                                            objSemItem_Table.Name = objDRV_Selected.Item("Name_Token")
                                            objSemItem_Table.GUID_Parent = objLocalConfig.SemItem_Type_DB_Tables.GUID
                                            objSemItem_Table.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                        Else

                                            MsgBox("Bitte nur ein Token der Type """ & objLocalConfig.SemItem_Type_DB_Tables.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                        End If
                                    Else

                                        MsgBox("Bitte nur ein Token der Type """ & objLocalConfig.SemItem_Type_DB_Tables.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                    End If
                                Else

                                    MsgBox("Bitte nur ein Token der Type """ & objLocalConfig.SemItem_Type_DB_Tables.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                End If

                            End If
                        End If
                        

                        If Not objSemItem_Table Is Nothing Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(procT_DBItems_In_Schema.Rows(0).Item("GUID_DBItemInSchema"), objSemItem_Table.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                get_SynonymTreeData(objTreeNode.Parent)
                            Else
                                MsgBox("Das Database-Item konnte mit dem Synonym nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                            End If
                        End If

                    Else
                        get_SynonymTreeData(objTreeNode.Parent)
                    End If
                Case cint_ImageID_Synonym_Userschemas
                    objSemItem_UserSchema = Nothing
                    objDRC_Item = funcA_TokenToken.GetData_TokenToken_LeftRight(procT_DBItems_In_Schema.Rows(0).Item("GUID_DBItemInSchema"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_Userschema.GUID).Rows
                    If objDRC_Item.Count = 0 Then
                        objDRC_Item = semtblA_Token.GetData_Token_TypeChilds(objLocalConfig.SemItem_Type_Userschema.GUID).Rows
                        If objDRC_Item.Count = 1 Then
                            objSemItem_UserSchema = New clsSemItem
                            objSemItem_UserSchema.GUID = objDRC_Item(0).Item("GUID_Token")
                            objSemItem_UserSchema.Name = objDRC_Item(0).Item("Name_Token")
                            objSemItem_UserSchema.GUID_Parent = objLocalConfig.SemItem_Type_Userschema.GUID
                            objSemItem_UserSchema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        Else
                            objSemItem_UserSchema = Nothing
                            objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Userschema, objLocalConfig.Globals)
                            objFrmSemManager.Applyabale = True
                            objFrmSemManager.ShowDialog(Me)
                            If objFrmSemManager.DialogResult = DialogResult.OK Then
                                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                                    If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                        objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                                        If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Userschema.GUID Then
                                            objSemItem_UserSchema = New clsSemItem
                                            objSemItem_UserSchema.GUID = objDRV_Selected.Item("GUID_Token")
                                            objSemItem_UserSchema.Name = objDRV_Selected.Item("Name_Token")
                                            objSemItem_UserSchema.GUID_Parent = objLocalConfig.SemItem_Type_Userschema.GUID
                                            objSemItem_UserSchema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                                        Else

                                            MsgBox("Bitte nur ein Token der Type """ & objLocalConfig.SemItem_Type_Userschema.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                        End If
                                    Else

                                        MsgBox("Bitte nur ein Token der Type """ & objLocalConfig.SemItem_Type_Userschema.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                    End If
                                Else

                                    MsgBox("Bitte nur ein Token der Type """ & objLocalConfig.SemItem_Type_Userschema.Name & """ auswählen!", MsgBoxStyle.Exclamation)
                                End If
                            End If
                        End If
                        
                        If Not objSemItem_UserSchema Is Nothing Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(procT_DBItems_In_Schema.Rows(0).Item("GUID_DBItemInSchema"), objSemItem_UserSchema.GUID, objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                get_SynonymTreeData(objTreeNode.Parent)
                            Else
                                MsgBox("Das Database-Item konnte mit dem Synonym nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    Else
                        get_SynonymTreeData(objTreeNode.Parent)
                    End If
            End Select
        End If
    End Sub

    Private Sub SchemaItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchemaItemsToolStripMenuItem.Click
        Dim objTreenode As TreeNode
        Dim objTreeNode_Sub As TreeNode
        Dim objSemItem_Item As New clsSemItem
        Dim boolParent As Boolean

        objTreenode = TreeView_SchemaItems.SelectedNode
        boolParent = False
        If Not objTreenode Is Nothing Then
            objSemItem_Item.GUID = New Guid(objTreenode.Name)
            objSemItem_Item.Name = objTreenode.Text
            objSemItem_Item.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            Select Case objTreenode.ImageIndex
                Case cint_ImageID_Functions, cint_ImageID_Procedures, cint_ImageID_Synonyms, cint_ImageID_Triggers, cint_ImageID_Views
                    boolParent = True
                    If MsgBox("Sollen die Abhängigkeiten automatisch ermittelt werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        For Each objTreeNode_Sub In objTreenode.Nodes
                            get_Dependencies_Automatic(objTreeNode_Sub)
                        Next
                        procT_CreationScript_needed_DBItems.Clear()
                        get_dependencies()
                        boolNodesDone = True
                        intRowsDone = 0
                        TimerNodes.Start()
                    End If
                    

                Case cint_ImageID_FunctionItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID

                Case cint_ImageID_ProcedureItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Procedure.GUID


                Case cint_ImageID_TableItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Tables.GUID

                Case cint_ImageID_TriggerItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Triggers.GUID

                Case cint_ImageID_ViewItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Views.GUID


            End Select
            If boolParent = False Then
                If MsgBox("Sollen die Abhängigkeiten automatisch ermittelt werden?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    objDependent = New clsDependent
                    objDependent.SemItem_Dependent = objSemItem_Item
                    objDependent.TreeNode_DBItem = objTreenode
                    ToolStripLabel_SelectDBItem.Enabled = True
                    Applyable = True
                Else
                    get_Dependencies_Automatic(objTreenode)
                    tblDBItemInSchema.Clear()
                    tblDBItemInSchema.Rows.Add(New Guid(objTreenode.Name), objTreenode.ImageIndex)
                    procT_CreationScript_needed_DBItems.Clear()
                    get_dependencies()
                    boolNodesDone = True
                    intRowsDone = 0
                    TimerNodes.Start()
                End If
            End If
            
            
        End If
    End Sub

    Private Sub get_Dependencies_Automatic(ByVal objTreeNode As TreeNode)
        procT_CreationScript_needed_DBItems.Clear()
        get_Dependend_SchemaItems(objTreenode)
    End Sub

    Public Sub get_Dependend_SchemaItems(ByVal objTreeNode As TreeNode)
        Dim objSemItem_SchemaItem As New clsSemItem
        Dim objSemItem_CreationScript As clsSemItem
        Dim objDRC_XMLText As DataRowCollection

        Dim strSQL As String
        Dim strFroms() As String
        Dim strFrom As String
        Dim intCountDone As Integer

        objSemItem_SchemaItem.GUID = New Guid(objTreeNode.Name)
        objSemItem_SchemaItem.Name = objTreeNode.Text
        Select Case objTreeNode.ImageIndex
            Case cint_ImageID_FunctionItem
                objSemItem_SchemaItem.GUID_Parent = objLocalConfig.SemItem_Type_Functions_in_Schema.GUID
            Case cint_ImageID_ProcedureItem
                objSemItem_SchemaItem.GUID_Parent = objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID
            Case cint_ImageID_ViewItem
                objSemItem_SchemaItem.GUID_Parent = objLocalConfig.SemItem_Type_Views_in_Schema.GUID
            Case cint_ImageID_TriggerItem
                objSemItem_SchemaItem.GUID_Parent = objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID
            Case cint_ImageID_TableItem
                objSemItem_SchemaItem.GUID_Parent = objLocalConfig.SemItem_Type_Tables_in_Schema.GUID
        End Select

        objSemItem_SchemaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objSemItem_CreationScript = get_CreationScript(objSemItem_SchemaItem)

        objDRC_XMLText = proc_XMLText_Of_CreationScript.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                 objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                 objLocalConfig.SemItem_Type_XML.GUID, _
                                                                 objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                 objSemItem_CreationScript.GUID).Rows
        If objDRC_XMLText.Count > 0 Then
            objSemDBWork = New clsDBWork(objLocalConfig.Globals)
            strSQL = objSemDBWork.get_SQL(objDRC_XMLText(0).Item("GUID_XML"))
            intCountDone = save_Functions(objSemItem_CreationScript, strSQL)
            If Not intCountDone = 0 Then
                MsgBox(intCountDone & " Funktionen konnten nicht gefunden/gespeichert werden!", MsgBoxStyle.Exclamation)
            End If


            strFroms = get_Froms(objSemItem_CreationScript, strSQL)

            intCountDone = 0
            If Not strFroms Is Nothing Then
                For Each strFrom In strFroms
                    intCountDone = intCountDone + get_DBItems_from_From(objSemItem_CreationScript, strFrom)
                Next
            End If

            If intCountDone > 0 Then
                MsgBox(intCountDone & " Items konnten nicht gefunden/gespeichert werden!", MsgBoxStyle.Exclamation)
            End If

        End If
    End Sub
    Private Function get_DBItems_from_From(ByVal objSemItem_CreationScript As clsSemItem, ByVal strFrom As String) As Integer

        Dim semtblT_Tables As New ds_SemDB.semtbl_TokenDataTable
        Dim semtblT_Views As New ds_SemDB.semtbl_TokenDataTable
        Dim semtblT_Procedures As New ds_SemDB.semtbl_TokenDataTable
        Dim semtblT_Synonyms As New ds_SemDB.semtbl_TokenDataTable
        Dim semtblT_Commands As New ds_SemDB.semtbl_TokenDataTable
        Dim objDRs_Command() As DataRow
        Dim objDR_Item As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim strFromParts() As String
        Dim strFromParts_tmp() As String
        Dim strFromPart As String
        Dim strFromPart_tmp As String
        Dim objSemItem_DBItem As clsSemItem
        Dim intCount As Integer = 0
        Dim intFound As Integer = 0
        Dim intAr As Integer

        Dim boolFound As Boolean

        semtblA_Token.Fill_Token_TypeChilds(semtblT_Procedures, objLocalConfig.SemItem_Type_DB_Procedure.GUID)
        semtblA_Token.Fill_Token_TypeChilds(semtblT_Tables, objLocalConfig.SemItem_Type_DB_Tables.GUID)
        semtblA_Token.Fill_Token_TypeChilds(semtblT_Views, objLocalConfig.SemItem_Type_DB_Views.GUID)
        semtblA_Token.Fill_Token_TypeChilds(semtblT_Synonyms, objLocalConfig.SemItem_Type_DB_Synonyms.GUID)
        semtblA_Token.Fill_Token_TypeChilds(semtblT_Commands, objLocalConfig.SemItem_Type_Commands.GUID)

        strFromParts = strFrom.Split(" ")
        For Each strFromPart In strFromParts
            If strFromPart.Contains(Chr(10)) Then
                strFromParts_tmp = strFromPart.Split(Chr(10))
                For Each strFromPart_tmp In strFromParts_tmp
                    intAr = strFromParts.Length
                    strFromPart_tmp = strFromPart_tmp.Replace(Chr(13), "")

                    ReDim Preserve strFromParts(intAr)
                    strFromParts(intAr) = strFromPart_tmp

                Next
            ElseIf strFromPart.Contains(Chr(13)) Then
                strFromParts_tmp = strFromPart.Split(Chr(13))
                For Each strFromPart_tmp In strFromParts_tmp
                    intAr = strFromParts.Length
                    strFromPart_tmp = strFromPart_tmp.Replace(Chr(10), "")
                    ReDim Preserve strFromParts(intAr)
                    strFromParts(intAr) = strFromPart_tmp
                Next
            End If

        Next
        For Each strFromPart In strFromParts
            boolFound = False
            If Not strFromPart.Contains("'") And Not strFromPart.Contains("[") Then
                If Not strFromPart.Contains("(") And Not strFromPart.Contains(")") And Not strFromPart = "" Then
                    objDRs_Command = semtblT_Commands.Select("Name_Token='" & strFromPart & "'")
                    If objDRs_Command.Count = 0 Then

                        If boolFound = False Then
                            For Each objDR_Item In semtblT_Procedures.Rows

                                objSemItem_DBItem = compare_ItemName_And_FromPart(strFromPart.ToLower, objDR_Item)
                                If Not objSemItem_DBItem Is Nothing Then
                                    boolFound = True
                                    Exit For
                                End If


                            Next
                        End If

                        If boolFound = False Then
                            For Each objDR_Item In semtblT_Synonyms.Rows

                                objSemItem_DBItem = compare_ItemName_And_FromPart(strFromPart.ToLower, objDR_Item)
                                If Not objSemItem_DBItem Is Nothing Then
                                    boolFound = True
                                    Exit For
                                End If


                            Next

                        End If


                        If boolFound = False Then
                            For Each objDR_Item In semtblT_Views.Rows

                                objSemItem_DBItem = compare_ItemName_And_FromPart(strFromPart.ToLower, objDR_Item)
                                If Not objSemItem_DBItem Is Nothing Then
                                    boolFound = True
                                    Exit For
                                End If


                            Next
                        End If

                        If boolFound = False Then
                            For Each objDR_Item In semtblT_Tables.Rows
                                objSemItem_DBItem = compare_ItemName_And_FromPart(strFromPart.ToLower, objDR_Item)
                                If Not objSemItem_DBItem Is Nothing Then
                                    boolFound = True
                                    Exit For
                                End If
                            Next
                        End If
                    End If

                    If boolFound = True Then
                        If Not objSemItem_DBItem.GUID = objSemItem_CreationScript.GUID_Related Then
                            intCount = intCount + 1

                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_CreationScript.GUID, _
                                                                                    objSemItem_DBItem.GUID, _
                                                                                    objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows
                            If objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Synonyms.GUID Then
                                For Each objDR_Item In semtblT_Tables.Rows

                                    objSemItem_DBItem = compare_ItemName_And_FromPart(strFromPart.ToLower, objDR_Item)
                                    If Not objSemItem_DBItem Is Nothing Then
                                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_CreationScript.GUID, _
                                                                                    objSemItem_DBItem.GUID, _
                                                                                    objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows
                                        Exit For
                                    End If


                                Next
                            End If
                            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                                intFound = intFound + 1
                            End If
                        End If

                    End If
                End If
            End If

        Next


        Return intCount - intFound
    End Function

    Private Function compare_ItemName_And_FromPart(ByVal strFromPart As String, ByVal objDR_Item As DataRow) As clsSemItem
        Dim intStartPos As Integer
        Dim intStopPos As Integer
        Dim strBefore As String
        Dim strAfter As String
        Dim strItemName As String
        Dim objSemItem_DBItem As clsSemItem = Nothing

        strItemName = objDR_Item.Item("Name_Token").ToString.ToLower

        If strFromPart.Contains(strItemName) Then
            intStartPos = strFromPart.ToLower.IndexOf(strItemName)
            intStopPos = intStartPos & strItemName.Length

            strBefore = ""
            strAfter = ""
            If intStartPos > 0 Then
                strBefore = strFromPart.Substring(intStartPos - 1)

            End If
            If strFromPart.Length - 1 > intStopPos Then
                strAfter = strFromPart.Substring(intStopPos + 1)
            End If
            If strBefore = "" And strAfter = "" Then
                objSemItem_DBItem = New clsSemItem
                objSemItem_DBItem.GUID = objDR_Item.Item("GUID_Token")
                objSemItem_DBItem.Name = strItemName
                objSemItem_DBItem.GUID_Parent = objDR_Item.Item("GUID_Type")
                objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            ElseIf strBefore = "[" And strAfter = "]" Then
                objSemItem_DBItem = New clsSemItem
                objSemItem_DBItem.GUID = objDR_Item.Item("GUID_Token")
                objSemItem_DBItem.Name = strItemName
                objSemItem_DBItem.GUID_Parent = objDR_Item.Item("GUID_Type")
                objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            ElseIf strBefore = "" And strAfter = "." Then
                objSemItem_DBItem = New clsSemItem
                objSemItem_DBItem.GUID = objDR_Item.Item("GUID_Token")
                objSemItem_DBItem.Name = strItemName
                objSemItem_DBItem.GUID_Parent = objDR_Item.Item("GUID_Type")
                objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            End If

        End If
        Return objSemItem_DBItem
    End Function

    Private Function save_DBItem_To_CreationScript(ByVal objSemItem_CreationScript As clsSemItem, ByVal strItem As String) As Boolean
        Dim objDRC_DBItem As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean = False
        If strItem.Contains("(") Then
            strItem = strItem.Substring(0, strItem.IndexOf("(") - 1)
            objDRC_DBItem = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Function.GUID, strItem).Rows
            If objDRC_DBItem.Count > 0 Then
                If Not objDRC_DBItem(0).Item("GUID_Token") = objSemItem_CreationScript.GUID_Related Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_CreationScript.GUID, _
                                                                        objDRC_DBItem(0).Item("GUID_Token"), _
                                                                        objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows

                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        boolResult = True
                    End If
                Else
                    boolResult = True
                End If

            Else
                boolResult = False
            End If
        Else
            strItem = strItem.Replace("[", "")
            strItem = strItem.Replace("]", "")
            objDRC_DBItem = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Synonyms.GUID, strItem).Rows
            If objDRC_DBItem.Count > 0 Then
                If Not objDRC_DBItem(0).Item("GUID_Token") = objSemItem_CreationScript.GUID_Related Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_CreationScript.GUID, _
                                                                         objDRC_DBItem(0).Item("GUID_Token"), _
                                                                         objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows

                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        boolResult = True
                    End If
                Else
                    boolResult = True
                End If

            Else
                objDRC_DBItem = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Views.GUID, strItem).Rows
                If objDRC_DBItem.Count > 0 Then
                    If Not objDRC_DBItem(0).Item("GUID_Token") = objSemItem_CreationScript.GUID_Related Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_CreationScript.GUID, _
                                                                        objDRC_DBItem(0).Item("GUID_Token"), _
                                                                        objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows

                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            boolResult = True
                        End If
                    Else
                        boolResult = True
                    End If

                Else
                    objDRC_DBItem = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Tables.GUID, strItem).Rows
                    If objDRC_DBItem.Count > 0 Then
                        If Not objDRC_DBItem(0).Item("GUID_Token") = objSemItem_CreationScript.GUID_Related Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_CreationScript.GUID, _
                                                                        objDRC_DBItem(0).Item("GUID_Token"), _
                                                                        objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows

                            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                                boolResult = True
                            End If
                        Else
                            boolResult = True
                        End If

                    Else
                        boolResult = False
                    End If
                End If
            End If
        End If
        Return boolResult
    End Function

    Private Function get_Froms(ByVal objSemItem_CreateionScript As clsSemItem, ByVal strSQL As String) As String()
        Dim semtblT_Commands As New ds_SemDB.semtbl_TokenDataTable
        Dim objDR_Command As DataRow
        Dim strSQL_Select As String
        Dim strSQLs_From() As String = Nothing
        Dim strSQL_From As String
        Dim strSQL_From_tmp As String
        Dim strSign As String
        Dim i As Integer
        Dim j As Integer
        Dim intSelectStarts() As Integer = Nothing
        Dim intSelectStart As Integer
        Dim boolString As Boolean = False
        Dim boolItem As Boolean = False
        Dim boolNewLine As Boolean
        Dim boolCommand As Boolean


        semtblA_Token.Fill_Token_TypeChilds(semtblT_Commands, objLocalConfig.SemItem_Type_Commands.GUID)

        If strSQL.ToLower.Contains("create procedure") Then
            strSQL = strSQL.Substring(strSQL.ToLower.IndexOf("create procedure"))
        Else
            If strSQL.ToLower.Contains("create function") Then
                strSQL = strSQL.Substring(strSQL.ToLower.IndexOf("create function"))
            Else
                If strSQL.ToLower.Contains("create view") Then
                    strSQL = strSQL.Substring(strSQL.ToLower.IndexOf("create view"))
                End If
            End If
        End If

        For i = 0 To strSQL.Length - 1
            If strSQL.Substring(i, 1) = "'" Then
                boolString = Not boolString
            Else
                If strSQL.Substring(i, 1) = "[" Then
                    boolItem = True
                Else
                    If strSQL.Substring(i, 1) = "]" Then
                        boolItem = False
                    End If
                End If

            End If

            If boolString = False And boolItem = False Then
                If strSQL.Length >= i + "select ".Length Then
                    If strSQL.ToLower.Substring(i, "select ".Length) = "select " Then
                        If intSelectStarts Is Nothing Then
                            j = 0
                            ReDim Preserve intSelectStarts(j)
                        Else
                            j = intSelectStarts.Length
                            ReDim Preserve intSelectStarts(j)
                            j = j - 1
                        End If

                        intSelectStarts(j) = i
                    End If
                End If

            End If


        Next
        If Not intSelectStarts Is Nothing Then
            For Each intSelectStart In intSelectStarts
                strSQL_Select = strSQL.Substring(intSelectStart)
                strSQL_Select = strSQL_Select.ToLower
                If strSQL_Select.Contains("from ") Then
                    strSQL_From = strSQL_Select.Substring(strSQL_Select.IndexOf("from "))
                    strSQL_From_tmp = ""
                    For j = 0 To strSQL_From.Length - 1
                        strSign = strSQL_From.Substring(j, 1)
                        strSQL_From_tmp = strSQL_From_tmp & strSign
                        If strSign = ";" Then
                            Exit For
                        End If
                        If Not Asc(strSign) = 10 And Not Asc(strSign) = 13 Then
                            Select Case strSign
                                Case "'"
                                    boolString = Not boolString
                                Case "["
                                    boolItem = True
                                Case "]"
                                    boolItem = False
                            End Select
                            If Not boolString = True And Not boolItem = True Then
                                If boolNewLine = True Then
                                    boolCommand = False
                                    For Each objDR_Command In semtblT_Commands.Rows
                                        If strSQL_From.Length >= j + objDR_Command.Item("Name_Token").ToString.ToLower.Length Then
                                            If strSign & strSQL_From.Substring(j, objDR_Command.Item("Name_Token").ToString.ToLower.Length) = objDR_Command.Item("Name_Token").ToString.ToLower Then
                                                boolCommand = False
                                                Exit For
                                            End If
                                        End If

                                    Next
                                    If boolCommand = True Then
                                        Exit For
                                    End If
                                End If
                                If strSQL_From.Length >= j + "where ".Length Then
                                    If strSign & strSQL_From.Substring(j, "where ".Length) = "where " Then
                                        Exit For
                                    End If
                                End If

                                If strSQL_From.Length >= j + "group by ".Length Then
                                    If strSign & strSQL_From.Substring(j, "group by ".Length) = "group by " Then
                                        Exit For
                                    End If
                                End If

                                If strSQL_From.Length >= j + "order by ".Length Then
                                    If strSign & strSQL_From.Substring(j, "order by ".Length) = "order by " Then
                                        Exit For
                                    End If
                                End If

                            End If
                            If Not strSign = " " And Not strSign = vbTab Then
                                boolNewLine = False
                            End If

                        Else
                            boolNewLine = True
                        End If
                    Next
                    strSQL_From = strSQL_From_tmp
                    If strSQLs_From Is Nothing Then
                        j = 0
                    Else
                        j = strSQLs_From.Length - 1
                    End If
                    ReDim Preserve strSQLs_From(j)
                    strSQLs_From(j) = strSQL_From
                End If
            Next
            If strSQL.ToLower.Contains("create trigger") Then
                strSQL_From = strSQL.Substring(strSQL.ToLower.IndexOf("create trigger") + "create trigger".Length)
                strSQL_From = strSQL_From.Substring(0, strSQL_From.ToLower.IndexOf("after"))
                strSQL_From = strSQL_From.Substring(strSQL_From.ToLower.IndexOf(" on "))
                strSQL_From = strSQL_From.Substring(strSQL_From.ToLower.IndexOf("[") + 1)
                strSQL_From = strSQL_From.Substring(strSQL_From.ToLower.IndexOf("[") + 1)
                strSQL_From = strSQL_From.Substring(0, strSQL_From.ToLower.IndexOf("]"))
                If strSQL_From <> "" Then
                    If strSQLs_From Is Nothing Then
                        j = 0
                    Else
                        j = strSQLs_From.Length - 1
                    End If
                    strSQLs_From(j) = strSQL_From
                End If

                intSelectStarts = Nothing
                strSQL_From = strSQL
                If strSQL_From.ToLower.Contains("insert into") Then
                    intSelectStart = strSQL_From.ToLower.IndexOf("insert into")
                    strSQL_From = strSQL_From.Substring(strSQL_From.ToLower.IndexOf("insert into") + Len("insert into"))
                    While Not intSelectStart = -1
                        If intSelectStarts Is Nothing Then
                            j = 0
                        Else
                            j = intSelectStarts.Length
                        End If

                        ReDim Preserve intSelectStarts(j)
                        intSelectStarts(j) = intSelectStart


                        If strSQL_From.ToLower.Contains("insert into") Then
                            intSelectStart = intSelectStart + Len("insert into") + strSQL_From.ToLower.IndexOf("insert into")
                            strSQL_From = strSQL_From.Substring(strSQL_From.ToLower.IndexOf("insert into") + Len("insert into"))
                        Else
                            intSelectStart = -1
                        End If

                    End While
                End If

                For Each intSelectStart In intSelectStarts
                    strSQL_From = strSQL.Substring(intSelectStart + Len("insert into"))
                    strSQL_From = strSQL_From.Trim()
                    strSQL_From = strSQL_From.Substring(0, strSQL_From.IndexOf(" "))

                    If strSQL_From <> "" Then
                        If strSQLs_From Is Nothing Then
                            j = 0
                        Else
                            j = strSQLs_From.Length
                        End If
                        ReDim Preserve strSQLs_From(j)
                        strSQLs_From(j) = strSQL_From
                    End If
                Next
            End If
        End If

        Return strSQLs_From
    End Function
    Private Function save_Functions(ByVal objSemItem_CreateionScript As clsSemItem, ByVal strSQL As String) As Integer
        Dim boolOpen As Boolean
        Dim boolClose As Boolean
        Dim boolString As Boolean = False
        Dim boolFunction_start As Boolean = False
        Dim boolItem As Boolean = False
        Dim intCount As Integer = 0
        Dim intDone As Integer = 0
        Dim i As Integer
        Dim intFunctionStart As Integer
        Dim strFunction As String
        Dim objDRC_Function As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        For i = 0 To strSQL.Length - 1
            If strSQL.Substring(i, 1) = "'" Then
                boolString = Not boolString
            End If
            If boolString = False Then
                If strSQL.Substring(i, 1) = "[" Then
                    boolItem = True
                End If
                If strSQL.Substring(i, 1) = "]" Then
                    boolItem = False
                End If
            End If


            If boolString = False And boolItem = False Then
                If strSQL.Substring(i, 1) = "(" Then
                    intFunctionStart = i - 1
                    boolFunction_start = True
                End If
                If boolFunction_start = True Then
                    If strSQL.Substring(i, 1) = ")" Then
                        For j = intFunctionStart To 0 Step -1
                            If strSQL.Substring(j, 1) = " " Or _
                                strSQL.Substring(j, 1) = "=" Or _
                                strSQL.Substring(j, 1) = "(" Or _
                                Asc(strSQL.Substring(j, 1)) = 10 Or _
                                Asc(strSQL.Substring(j, 1)) = 13 Or _
                                strSQL.Substring(j, 1) = "." Then
                                intCount = intCount + 1
                                strFunction = strSQL.Substring(j + 1, intFunctionStart - j)
                                If Not strFunction = "" Then
                                    objDRC_Function = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                                                                   strFunction).Rows
                                    If objDRC_Function.Count > 0 Then
                                        If Not objDRC_Function(0).Item("GUID_Token") = objSemItem_CreateionScript.GUID_Related Then
                                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_CreateionScript.GUID, _
                                                                                                objDRC_Function(0).Item("GUID_Token"), _
                                                                                                objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows
                                            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                                                intDone = intDone + 1
                                            End If
                                        Else
                                            intDone = intDone + 1
                                        End If

                                    Else
                                        intDone = intDone + 1
                                    End If
                                Else
                                    intDone = intDone + 1
                                End If


                                Exit For
                            End If
                        Next
                        boolFunction_start = False
                    End If
                End If
            End If
        Next

        Return intCount - intDone
    End Function


    Private Function get_CreationScript(ByVal objSemItem_SchemaItem As clsSemItem) As clsSemItem
        Dim objDRC_CreationScript As DataRowCollection
        Dim objSemItem_Result As clsSemItem = Nothing

        Select Case objSemItem_SchemaItem.GUID_Parent
            Case objLocalConfig.SemItem_Type_Functions_in_Schema.GUID
                objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                              objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                                                              objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                              objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                              objSemItem_SchemaItem.GUID).Rows
            Case objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID
                objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                              objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                                                              objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                              objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                              objSemItem_SchemaItem.GUID).Rows
            Case objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID
                objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                              objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                                                                              objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                              objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                              objSemItem_SchemaItem.GUID).Rows
            Case objLocalConfig.SemItem_Type_Tables_in_Schema.GUID
                objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                              objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                                                                              objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                              objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                              objSemItem_SchemaItem.GUID).Rows
            Case objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID
                objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                              objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                                                              objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                              objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                              objSemItem_SchemaItem.GUID).Rows
            Case objLocalConfig.SemItem_Type_Views_in_Schema.GUID
                objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                              objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                                                              objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                              objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                              objSemItem_SchemaItem.GUID).Rows

        End Select

        If objDRC_CreationScript.Count > 0 Then
            objSemItem_Result = New clsSemItem
            objSemItem_Result.GUID = objDRC_CreationScript(0).Item("GUID_CreationScript")
            objSemItem_Result.Name = objDRC_CreationScript(0).Item("Name_CreationScript")
            objSemItem_Result.GUID_Parent = objLocalConfig.SemItem_Type_Creation_Scripts.GUID
            objSemItem_Result.GUID_Related = objDRC_CreationScript(0).Item("GUID_DBItem")
            objSemItem_Result.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        Else
            objSemItem_Result = Nothing
        End If

        Return objSemItem_Result
    End Function

    Private Function save_SemObjectOFDBSchema(ByVal objSemItem_Selected As clsSemItem, _
                                                ByVal GUID_DatabaseSchema As Guid, _
                                                ByVal GUID_CreationScript As Guid, _
                                                ByVal boolCreationScript As Boolean) As Boolean

        Dim objSemItem_SemObjectsOfDBSchema As New clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim GUID_ObjectReference As Guid
        Dim intCount As Integer
        Dim boolResult As Boolean = False

        Select Case objSemItem_Selected.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Attribute.GetData(objSemItem_Selected.GUID).Rows
            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objDRC_LogState = procA_DBWork_Save_OR_RelationType.GetData(objSemItem_Selected.GUID).Rows
            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Token.GetData(objSemItem_Selected.GUID).Rows
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Type.GetData(objSemItem_Selected.GUID).Rows
        End Select

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            GUID_ObjectReference = objDRC_LogState(0).Item("GUID_ObjectReference")

            If boolCreationScript = True Then
                intCount = procA_SemItems_Of_CreationScripts.GetData(objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                        objLocalConfig.SemItem_Type_Semantic_Objects_of_DB_Schema.GUID, _
                                                        objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID, _
                                                        GUID_CreationScript).Rows.Count
            Else
                intCount = procA_SemItems_Of_DatabaseSchema.GetData(objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                        objLocalConfig.SemItem_Type_Semantic_Objects_of_DB_Schema.GUID, _
                                                        objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID, _
                                                        GUID_DatabaseSchema).Rows.Count
            End If
            If intCount = 0 Then

                objSemItem_SemObjectsOfDBSchema.GUID = Guid.NewGuid
                objSemItem_SemObjectsOfDBSchema.Name = objSemItem_Selected.Name
                objSemItem_SemObjectsOfDBSchema.GUID_Parent = objLocalConfig.SemItem_Type_Semantic_Objects_of_DB_Schema.GUID
                objSemItem_SemObjectsOfDBSchema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_SemObjectsOfDBSchema.GUID, _
                                                                     objSemItem_SemObjectsOfDBSchema.Name, _
                                                                     objSemItem_SemObjectsOfDBSchema.GUID_Parent, True).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    If boolCreationScript = True Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(GUID_CreationScript, _
                                                                            objSemItem_SemObjectsOfDBSchema.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID, 0).Rows
                    Else
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(GUID_DatabaseSchema, _
                                                                            objSemItem_SemObjectsOfDBSchema.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID, 0).Rows
                    End If

                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        objDRC_LogState = semprocA_DBWork_Save_Token_OR.GetData(objSemItem_SemObjectsOfDBSchema.GUID, GUID_ObjectReference, objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID, 0).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then


                            boolResult = True
                        Else
                            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(GUID_DatabaseSchema, _
                                                                                   objSemItem_SemObjectsOfDBSchema.GUID, _
                                                                                   objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                semprocA_DBWork_Del_Token.GetData(objSemItem_SemObjectsOfDBSchema.GUID)
                            End If

                        End If
                    Else
                        semprocA_DBWork_Del_Token.GetData(objSemItem_SemObjectsOfDBSchema.GUID)
                    End If

                End If

            Else
                boolResult = True
            End If

        End If
        Return boolResult
    End Function

    Private Sub SemItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemItemsToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Selected As New clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_CreationScript As DataRowCollection
        Dim objDRC_Exported As DataRowCollection
        Dim objDRC_Ref As DataRowCollection
        Dim objDR_Ref As DataRow
        Dim GUID_CreationScript As Guid
        Dim GUID_ObjectReference As Guid
        Dim objSemItem_SemObjectsOfDBSchema As New clsSemItem
        Dim objSemItem_Type As clsSemItem
        Dim intCount_ToRef As Integer
        Dim intCount_Refed As Integer
        Dim boolRef As Boolean

        objTreeNode = TreeView_SchemaItems.SelectedNode
        If Not objTreeNode Is Nothing Then
            boolRef = False
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_FunctionItem
                    objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                              objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                                                              objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                              objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                              New Guid(objTreeNode.Name)).Rows

                    boolRef = True
                Case cint_ImageID_ProcedureItem
                    objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                              objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                                                              objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                              objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                              New Guid(objTreeNode.Name)).Rows
                    boolRef = True
                Case cint_ImageID_ViewItem
                    objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                              objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                                                              objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                              objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                              New Guid(objTreeNode.Name)).Rows
                    boolRef = True
                Case cint_ImageID_TriggerItem
                    objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                              objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                                                              objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                              objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                              objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                              New Guid(objTreeNode.Name)).Rows
                    boolRef = True
                Case cint_ImageID_SemItems
                    objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)
                    If objFrmSemManager.DialogResult = DialogResult.OK Then
                        Select Case objFrmSemManager.SelectedItems_TypeGUID
                            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                intCount_Refed = 0
                                intCount_ToRef = objFrmSemManager.SelectedRows_Items.Count
                                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                                    objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_Attribute")
                                    objSemItem_Selected.Name = objDRV_Selected.Item("Name_Attribute")
                                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                                    If save_SemObjectOFDBSchema(objSemItem_Selected, _
                                                             GUID_DatabaseSchema, _
                                                             Nothing, _
                                                             False) = True Then
                                        intCount_Refed = intCount_Refed + 1
                                    End If


                                Next
                            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                                intCount_Refed = 0
                                intCount_ToRef = objFrmSemManager.SelectedRows_Items.Count
                                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                                    objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_RelationType")
                                    objSemItem_Selected.Name = objDRV_Selected.Item("Name_RelationType")
                                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

                                    If save_SemObjectOFDBSchema(objSemItem_Selected, _
                                                             GUID_DatabaseSchema, _
                                                             Nothing, _
                                                             False) = True Then
                                        intCount_Refed = intCount_Refed + 1
                                    End If

                                Next
                            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                                intCount_Refed = 0
                                intCount_ToRef = objFrmSemManager.SemItems_Selected.Count
                                For Each objSemItem_Selected In objFrmSemManager.SemItems_Selected


                                    If save_SemObjectOFDBSchema(objSemItem_Selected, _
                                                             GUID_DatabaseSchema, _
                                                             Nothing, _
                                                             False) = True Then
                                        intCount_Refed = intCount_Refed + 1
                                    End If

                                Next
                            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                intCount_Refed = 0
                                intCount_ToRef = objFrmSemManager.SelectedRows_Items.Count
                                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                                    objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_Token")
                                    objSemItem_Selected.Name = objDRV_Selected.Item("Name_Token")
                                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    If save_SemObjectOFDBSchema(objSemItem_Selected, _
                                                             GUID_DatabaseSchema, _
                                                             Nothing, _
                                                             False) = True Then
                                        intCount_Refed = intCount_Refed + 1
                                    End If

                                Next

                        End Select
                    End If
                    boolRef = False
            End Select
            If boolRef = True Then

                GUID_CreationScript = objDRC_CreationScript(0).Item("GUID_CreationScript")
                objDRC_Exported = procA_TokenAttribute_Bit.GetData_By_GUIDAttribute_And_GUIDToken(objDRC_CreationScript(0).Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID).Rows
                If objDRC_Exported.Count = 0 Then
                    semprocA_DBWork_Save_Token_Attribute_Bit.GetData(objDRC_CreationScript(0).Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID, Nothing, False, 0)
                Else
                    semprocA_DBWork_Save_Token_Attribute_Bit.GetData(objDRC_CreationScript(0).Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID, objDRC_Exported(0).Item("GUID_DBItem"), False, 0)
                End If

                objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    Select Case objFrmSemManager.SelectedItems_TypeGUID
                        Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                            intCount_Refed = 0
                            intCount_ToRef = objFrmSemManager.SelectedRows_Items.Count
                            For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                                objDRV_Selected = objDGVR_Selected.DataBoundItem
                                objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_Attribute")
                                objSemItem_Selected.Name = objDRV_Selected.Item("Name_Attribute")
                                objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                                If save_SemObjectOFDBSchema(objSemItem_Selected, _
                                                         Nothing, _
                                                         GUID_CreationScript, _
                                                         True) = True Then
                                    If save_SemObjectOFDBSchema(objSemItem_Selected, _
                                                         GUID_DatabaseSchema, _
                                                         Nothing, _
                                                         False) = True Then
                                        intCount_Refed = intCount_Refed + 1
                                    End If

                                End If


                            Next
                        Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                            intCount_Refed = 0
                            intCount_ToRef = objFrmSemManager.SelectedRows_Items.Count
                            For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                                objDRV_Selected = objDGVR_Selected.DataBoundItem

                                objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_RelationType")
                                objSemItem_Selected.Name = objDRV_Selected.Item("Name_RelationType")
                                objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

                                If save_SemObjectOFDBSchema(objSemItem_Selected, _
                                                         Nothing, _
                                                         GUID_CreationScript, _
                                                         True) = True Then
                                    If save_SemObjectOFDBSchema(objSemItem_Selected, _
                                                         GUID_DatabaseSchema, _
                                                         Nothing, _
                                                         False) = True Then
                                        intCount_Refed = intCount_Refed + 1
                                    End If

                                End If

                            Next
                        Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                            intCount_Refed = 0
                            intCount_ToRef = objFrmSemManager.SemItems_Selected.Count
                            For Each objSemItem_Selected In objFrmSemManager.SemItems_Selected


                                If save_SemObjectOFDBSchema(objSemItem_Selected, _
                                                         Nothing, _
                                                         GUID_CreationScript, _
                                                         True) = True Then
                                    If save_SemObjectOFDBSchema(objSemItem_Selected, _
                                                         GUID_DatabaseSchema, _
                                                         Nothing, _
                                                         False) = True Then
                                        intCount_Refed = intCount_Refed + 1
                                    End If

                                End If

                            Next
                        Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            intCount_Refed = 0
                            intCount_ToRef = objFrmSemManager.SelectedRows_Items.Count
                            For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                                objDRV_Selected = objDGVR_Selected.DataBoundItem
                                objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_Token")
                                objSemItem_Selected.Name = objDRV_Selected.Item("Name_Token")
                                objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                If save_SemObjectOFDBSchema(objSemItem_Selected, _
                                                         Nothing, _
                                                         GUID_CreationScript, _
                                                         True) = True Then
                                    If save_SemObjectOFDBSchema(objSemItem_Selected, _
                                                         GUID_DatabaseSchema, _
                                                         Nothing, _
                                                         False) = True Then
                                        intCount_Refed = intCount_Refed + 1
                                    End If

                                End If

                            Next

                    End Select
                End If
                If intCount_Refed < intCount_ToRef Then
                    MsgBox("Es konnten nur " & intCount_Refed & " von " & intCount_ToRef & " Items übernommen werden!", MsgBoxStyle.Exclamation)
                End If
                tblDBItemInSchema.Clear()
                tblDBItemInSchema.Rows.Add(New Guid(objTreeNode.Name), objTreeNode.ImageIndex)
                procT_CreationScript_needed_DBItems.Clear()
                get_Dependencies()
                boolNodesDone = True
                intRowsDone = 0
                TimerNodes.Start()
            End If

        End If


    End Sub

    Private Sub get_Related_SemItems(ByVal objTreeNode As TreeNode)
        Dim objDRC_CreationScript As DataRowCollection
        Dim objDRC_Ref As DataRowCollection
        Dim objDR_Ref As DataRow
        Dim objTreeNodes_Needs() As TreeNode
        Dim objTreeNode_Needs As TreeNode
        Dim GUID_CreationScript As Guid

        Select Case objTreeNode.ImageIndex
            Case cint_ImageID_FunctionItem
                objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                          objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                          objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                                                          objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                          objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                          objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                          New Guid(objTreeNode.Name)).Rows
                GUID_CreationScript = objDRC_CreationScript(0).Item("GUID_CreationScript")
                objDRC_Ref = procA_SemItems_Of_CreationScripts.GetData(objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                       objLocalConfig.SemItem_Type_Semantic_Objects_of_DB_Schema.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID, _
                                                                       GUID_CreationScript).Rows
                For Each objDR_Ref In objDRC_Ref
                    objTreeNodes_Needs = objTreeNode.Nodes.Find(objLocalConfig.SemItem_RelationType_needs.GUID.ToString, False)
                    If objTreeNodes_Needs.Length = 0 Then
                        objTreeNode_Needs = objTreeNode.Nodes.Add(objLocalConfig.SemItem_RelationType_needs.GUID.ToString, objLocalConfig.SemItem_RelationType_needs.Name, cint_ImageID_NeededItems, cint_ImageID_NeededItems)
                    Else
                        objTreeNode_Needs = objTreeNodes_Needs(0)
                    End If

                    Select Case objDR_Ref.Item("GUID_ItemType")
                        Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref").ToString, objDR_Ref.Item("Name_Token"), cint_ImageID_AttributeType, cint_ImageID_AttributeType)
                        Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref").ToString, objDR_Ref.Item("Name_Token"), cint_ImageID_RelationType, cint_ImageID_RelationType)
                        Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref").ToString, objDR_Ref.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)
                        Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref").ToString, objDR_Ref.Item("Name_Token"), cint_ImageID_Type, cint_ImageID_Type)
                    End Select
                Next
            Case cint_ImageID_ProcedureItem
                objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                          objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                          objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                                                          objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                          objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                          objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                          New Guid(objTreeNode.Name)).Rows
                GUID_CreationScript = objDRC_CreationScript(0).Item("GUID_CreationScript")
                objDRC_Ref = procA_SemItems_Of_CreationScripts.GetData(objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                       objLocalConfig.SemItem_Type_Semantic_Objects_of_DB_Schema.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID, _
                                                                       GUID_CreationScript).Rows
                For Each objDR_Ref In objDRC_Ref
                    objTreeNodes_Needs = objTreeNode.Nodes.Find(objLocalConfig.SemItem_RelationType_needs.GUID.ToString, False)
                    If objTreeNodes_Needs.Length = 0 Then
                        objTreeNode_Needs = objTreeNode.Nodes.Add(objLocalConfig.SemItem_RelationType_needs.GUID.ToString, objLocalConfig.SemItem_RelationType_needs.Name, cint_ImageID_NeededItems, cint_ImageID_NeededItems)
                    Else
                        objTreeNode_Needs = objTreeNodes_Needs(0)
                    End If

                    Select Case objDR_Ref.Item("GUID_ItemType")
                        Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref").ToString, objDR_Ref.Item("Name_Token"), cint_ImageID_AttributeType, cint_ImageID_AttributeType)
                        Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref").ToString, objDR_Ref.Item("Name_Token"), cint_ImageID_RelationType, cint_ImageID_RelationType)
                        Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref").ToString, objDR_Ref.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)
                        Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref").ToString, objDR_Ref.Item("Name_Token"), cint_ImageID_Type, cint_ImageID_Type)
                    End Select
                Next
            Case cint_ImageID_ViewItem
                objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                          objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                          objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                                                          objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                          objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                          objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                          New Guid(objTreeNode.Name)).Rows
                GUID_CreationScript = objDRC_CreationScript(0).Item("GUID_CreationScript")
                objDRC_Ref = procA_SemItems_Of_CreationScripts.GetData(objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                       objLocalConfig.SemItem_Type_Semantic_Objects_of_DB_Schema.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID, _
                                                                       GUID_CreationScript).Rows
                For Each objDR_Ref In objDRC_Ref
                    objTreeNodes_Needs = objTreeNode.Nodes.Find(objLocalConfig.SemItem_RelationType_needs.GUID.ToString, False)
                    If objTreeNodes_Needs.Length = 0 Then
                        objTreeNode_Needs = objTreeNode.Nodes.Add(objLocalConfig.SemItem_RelationType_needs.GUID.ToString, objLocalConfig.SemItem_RelationType_needs.Name, cint_ImageID_NeededItems, cint_ImageID_NeededItems)
                    Else
                        objTreeNode_Needs = objTreeNodes_Needs(0)
                    End If

                    Select Case objDR_Ref.Item("GUID_ItemType")
                        Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref"), objDR_Ref.Item("Name_Token"), cint_ImageID_AttributeType, cint_ImageID_AttributeType)
                        Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref"), objDR_Ref.Item("Name_Token"), cint_ImageID_RelationType, cint_ImageID_RelationType)
                        Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref"), objDR_Ref.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)
                        Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref"), objDR_Ref.Item("Name_Token"), cint_ImageID_Type, cint_ImageID_Type)
                    End Select
                Next
            Case cint_ImageID_TriggerItem
                objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                          objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                          objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                                                          objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                          objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                          objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                          New Guid(objTreeNode.Name)).Rows
                GUID_CreationScript = objDRC_CreationScript(0).Item("GUID_CreationScript")
                objDRC_Ref = procA_SemItems_Of_CreationScripts.GetData(objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                       objLocalConfig.SemItem_Type_Semantic_Objects_of_DB_Schema.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID, _
                                                                       GUID_CreationScript).Rows
                For Each objDR_Ref In objDRC_Ref
                    objTreeNodes_Needs = objTreeNode.Nodes.Find(objLocalConfig.SemItem_RelationType_needs.GUID.ToString, False)
                    If objTreeNodes_Needs.Length = 0 Then
                        objTreeNode_Needs = objTreeNode.Nodes.Add(objLocalConfig.SemItem_RelationType_needs.GUID.ToString, objLocalConfig.SemItem_RelationType_needs.Name, cint_ImageID_NeededItems, cint_ImageID_NeededItems)
                    Else
                        objTreeNode_Needs = objTreeNodes_Needs(0)
                    End If

                    Select Case objDR_Ref.Item("GUID_ItemType")
                        Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref").ToString, objDR_Ref.Item("Name_Token"), cint_ImageID_AttributeType, cint_ImageID_AttributeType)
                        Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref").ToString, objDR_Ref.Item("Name_Token"), cint_ImageID_RelationType, cint_ImageID_RelationType)
                        Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref").ToString, objDR_Ref.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)
                        Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                            objTreeNode_Needs.Nodes.Add(objDR_Ref.Item("GUID_Ref").ToString, objDR_Ref.Item("Name_Token"), cint_ImageID_Type, cint_ImageID_Type)
                    End Select
                Next
        End Select

    End Sub



    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        fill_TabPages()
    End Sub

    Private Sub TestSchemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestSchemaToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_DatabasesOfSchema.SelectedNode
        If Not objTreeNode Is Nothing Then
            test_Items_DB_to_Schema(objTreeNode)
        End If
    End Sub

    Private Sub set_ConnectionString(ByVal objTreeNode_Database As TreeNode)
        Dim strConnectionParts() As String

        strConnectionParts = objTreeNode_Database.Text.Split("@")
        objDatabaseConnection.Name_Database = strConnectionParts(0)
        objDatabaseConnection.Name_Server = strConnectionParts(1)


    End Sub

    Private Sub ContextMenuStrip_DBView_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_DBView.Opening
        Dim objTreeNode As TreeNode

        TestSchemaToolStripMenuItem.Enabled = False
        ImportexportToolStripMenuItem.Enabled = False
        ImportToolStripMenuItem.Enabled = False
        ExportToolStripMenuItem.Enabled = False
        CopyDefinitionToolStripMenuItem.Enabled = False
        objTreeNode = TreeView_DatabasesOfSchema.SelectedNode

        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Database
                    TestSchemaToolStripMenuItem.Enabled = True

                Case cint_ImageID_FunctionsInSchema_DB, _
                    cint_ImageID_ProceduresInSchema_DB, _
                    cint_ImageID_SynonymInSchema_DB, _
                    cint_ImageID_TableInSchema_DB, _
                    cint_ImageID_TriggerInSchema_DB, _
                    cint_ImageID_ViewInSchema_DB

                    TestSchemaToolStripMenuItem.Enabled = True
                Case cint_ImageID_Funciont_DB_in, _
                    cint_ImageID_Procedure_DB_in, _
                    cint_ImageID_Synonym_DB, _
                    cint_ImageID_Table_DB_in, _
                    cint_ImageID_Trigger_DB_in, _
                    cint_ImageID_View_DB_in

                    ImportexportToolStripMenuItem.Enabled = True
                    ImportToolStripMenuItem.Enabled = True
                    CopyDefinitionToolStripMenuItem.Enabled = True
                Case cint_ImageID_Function_DB_out, _
                    cint_ImageID_Procedure_DB_out, _
                    cint_ImageID_Synonym_DB_out, _
                    cint_ImageID_Table_DB_out, _
                    cint_ImageID_Trigger_DB_out, _
                    cint_ImageID_View_DB_out

                    ImportexportToolStripMenuItem.Enabled = True
                    ExportToolStripMenuItem.Enabled = True
                    CopyDefinitionToolStripMenuItem.Enabled = True
                Case cint_ImageID_Function_DB_Definition, _
                    cint_ImageID_Procedure_DB_Definition, _
                    cint_ImageID_Synonym_DB_Definition, _
                    cint_ImageID_Table_DB_Definition, _
                    cint_ImageID_Trigger_DB_Definition, _
                    cint_ImageID_View_DB_Definition

                    ImportexportToolStripMenuItem.Enabled = True
                    ImportToolStripMenuItem.Enabled = True
                    ExportToolStripMenuItem.Enabled = True
                    CopyDefinitionToolStripMenuItem.Enabled = True
            End Select
        End If
    End Sub

    Private Sub test_Items_DB_to_Schema(ByVal objTreeNode As TreeNode)
        Dim objTreeNode_DBItems As TreeNode
        Dim objTreeNode_Database As TreeNode


        Select Case objTreeNode.ImageIndex
            Case cint_ImageID_Database
                set_ConnectionString(objTreeNode)
                get_Functions_Of_Database()
                get_Procedures_Of_Database()
                get_Synonyms_Of_Database()
                get_Tables_Of_Database()
                get_Trigger_Of_Database()
                get_Views_Of_Database()

                For Each objTreeNode_DBItems In objTreeNode.Nodes


                    get_Items_Of_Schema(objTreeNode_DBItems)


                Next

            Case cint_ImageID_Functions
                objTreeNode_Database = objTreeNode.Parent
                set_ConnectionString(objTreeNode)
                get_Functions_Of_Database()

                get_Items_Of_Schema(objTreeNode)
            Case cint_ImageID_Procedures
                objTreeNode_Database = objTreeNode.Parent
                set_ConnectionString(objTreeNode)
                get_Procedures_Of_Database()

                get_Items_Of_Schema(objTreeNode)
            Case cint_ImageID_Triggers
                objTreeNode_Database = objTreeNode.Parent
                set_ConnectionString(objTreeNode)
                get_Trigger_Of_Database()

                get_Items_Of_Schema(objTreeNode)
            Case cint_ImageID_Views
                objTreeNode_Database = objTreeNode.Parent
                set_ConnectionString(objTreeNode)
                get_Views_Of_Database()

                get_Items_Of_Schema(objTreeNode)



        End Select




    End Sub

    Private Sub get_Items_Of_Schema(ByVal objTreeNode_Items As TreeNode)
        Dim objDR_Item As DataRow
        Dim objDRs_Item() As DataRow
        Dim intImageID_Out As Integer

        Dim objTreeNode_Item As TreeNode
        Dim objDRC_CreationScript As DataRowCollection

        objTreeNode_Items.Nodes.Clear()
        procA_TSQL_ObjectReferences.Connection = New SqlClient.SqlConnection(objDatabaseConnection.ConnectionString)


        Select Case objTreeNode_Items.ImageIndex
            Case cint_ImageID_FunctionsInSchema_DB
                procA_Item_in_Schema.Fill(procT_Item_in_Schema, _
                                  objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                  objLocalConfig.SemItem_Type_Functions_in_Schema.GUID, _
                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                  GUID_DatabaseSchema)
                For Each objDR_Item In procT_TSQL_Functions.Rows
                    objDRs_Item = get_each_Item_Of_Schema(objDR_Item, objTreeNode_Items, "ROUTINE_NAME")
                Next
                intImageID_Out = cint_ImageID_Function_DB_out
            Case cint_ImageID_ProceduresInSchema_DB
                procA_Item_in_Schema.Fill(procT_Item_in_Schema, _
                                  objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                  objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID, _
                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                  GUID_DatabaseSchema)
                For Each objDR_Item In procT_TSQL_procedures.Rows
                    objDRs_Item = get_each_Item_Of_Schema(objDR_Item, objTreeNode_Items, "name")
                Next
                intImageID_Out = cint_ImageID_Procedure_DB_out
            Case cint_ImageID_SynonymInSchema_DB
                procA_Item_in_Schema.Fill(procT_Item_in_Schema, _
                                  objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                  objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID, _
                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                  GUID_DatabaseSchema)
                For Each objDR_Item In procT_TSQL_synonyms.Rows
                    objDRs_Item = get_each_Item_Of_Schema(objDR_Item, objTreeNode_Items, "name")
                Next
                intImageID_Out = cint_ImageID_Synonym_DB_out
            Case cint_ImageID_TableInSchema_DB
                procA_Item_in_Schema.Fill(procT_Item_in_Schema, _
                                  objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                  objLocalConfig.SemItem_Type_Tables_in_Schema.GUID, _
                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                  GUID_DatabaseSchema)
                For Each objDR_Item In procT_TSQL_Tables.Rows
                    objDRs_Item = get_each_Item_Of_Schema(objDR_Item, objTreeNode_Items, "name")
                Next
                intImageID_Out = cint_ImageID_Table_DB_out
            Case cint_ImageID_TriggerInSchema_DB
                procA_Item_in_Schema.Fill(procT_Item_in_Schema, _
                                  objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                  objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID, _
                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                  GUID_DatabaseSchema)
                For Each objDR_Item In procT_TSQL_Triggers.Rows
                    objDRs_Item = get_each_Item_Of_Schema(objDR_Item, objTreeNode_Items, "name")
                Next
                intImageID_Out = cint_ImageID_Trigger_DB_out
            Case cint_ImageID_ViewInSchema_DB
                procA_Item_in_Schema.Fill(procT_Item_in_Schema, _
                                  objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                  objLocalConfig.SemItem_Type_Views_in_Schema.GUID, _
                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                  GUID_DatabaseSchema)
                For Each objDR_Item In procT_TSQL_Views.Rows
                    objDRs_Item = get_each_Item_Of_Schema(objDR_Item, objTreeNode_Items, "name")
                Next
                intImageID_Out = cint_ImageID_View_DB_out
        End Select




        objDRs_Item = procT_Item_in_Schema.Select("Found=" & False)
        For Each objDR_Item In objDRs_Item
            objTreeNode_Item = objTreeNode_Items.Nodes.Add(objDR_Item.Item("GUID_DBItem").ToString, objDR_Item.Item("Name_DBItem"), intImageID_Out, intImageID_Out)
            objTreeNode_Item.ForeColor = Color.Red
        Next
    End Sub

    Private Function get_each_Item_Of_Schema(ByVal objDR_Item As DataRow, ByVal objTreeNode_Items As TreeNode, ByVal strName_Item As String) As DataRow()
        Dim objTreeNode_Item As TreeNode
        Dim objDRs_Item() As DataRow
        Dim objDRC_Definition As DataRowCollection
        Dim objDR_Definition As DataRow
        Dim objDRC_CreationScript As DataRowCollection
        Dim objXML As New Xml.XmlDocument
        Dim objXMLNodeList As Xml.XmlNodeList
        Dim objXMLElement As Xml.XmlElement
        Dim intImageID_DB As Integer
        Dim intImageID_DB_In As Integer
        Dim intImageID_DB_Definition As Integer

        Dim strDefinition_Database As String
        Dim strDefinition_Schema As String
        Dim GUID_DBItem As Guid

        Select Case objTreeNode_Items.ImageIndex
            Case cint_ImageID_FunctionsInSchema_DB
                intImageID_DB = cint_ImageID_Function_DB
                intImageID_DB_Definition = cint_ImageID_Function_DB_Definition
                intImageID_DB_In = cint_ImageID_Funciont_DB_in
                GUID_DBItem = objLocalConfig.SemItem_Type_DB_Function.GUID
            Case cint_ImageID_ProceduresInSchema_DB
                intImageID_DB = cint_ImageID_Procedure_DB
                intImageID_DB_Definition = cint_ImageID_Procedure_DB_Definition
                intImageID_DB_In = cint_ImageID_Procedure_DB_in
                GUID_DBItem = objLocalConfig.SemItem_Type_DB_Procedure.GUID
            Case cint_ImageID_SynonymInSchema_DB
                intImageID_DB = cint_ImageID_Synonym_DB
                intImageID_DB_Definition = cint_ImageID_Synonym_DB_Definition
                intImageID_DB_In = cint_ImageID_Synonym_DB_in
                GUID_DBItem = objLocalConfig.SemItem_Type_DB_Synonyms.GUID
            Case cint_ImageID_TableInSchema_DB
                intImageID_DB = cint_ImageID_Table_DB
                intImageID_DB_Definition = cint_ImageID_Table_DB_Definition
                intImageID_DB_In = cint_ImageID_Table_DB_in
                GUID_DBItem = objLocalConfig.SemItem_Type_DB_Tables.GUID
            Case cint_ImageID_TriggerInSchema_DB
                intImageID_DB = cint_ImageID_Trigger_DB
                intImageID_DB_Definition = cint_ImageID_Trigger_DB_Definition
                intImageID_DB_In = cint_ImageID_Trigger_DB_in
                GUID_DBItem = objLocalConfig.SemItem_Type_DB_Triggers.GUID
            Case cint_ImageID_ViewInSchema_DB
                intImageID_DB = cint_ImageID_View_DB
                intImageID_DB_Definition = cint_ImageID_View_DB_Definition
                intImageID_DB_In = cint_ImageID_View_DB_in
                GUID_DBItem = objLocalConfig.SemItem_Type_DB_Views.GUID


        End Select
        objTreeNode_Item = objTreeNode_Items.Nodes.Add(objDR_Item.Item(strName_Item), objDR_Item.Item(strName_Item), intImageID_DB, intImageID_DB)
        objDRs_Item = procT_Item_in_Schema.Select("Name_DBItem='" & objDR_Item.Item(strName_Item) & "'")
        If objDRs_Item.Length > 0 Then
            objDRs_Item(0).Item("Found") = True
            Try
                objDRC_Definition = procA_TSQL_ObjectReferences.GetData(objDR_Item.Item(strName_Item)).Rows

                If objDRC_Definition.Count > 0 Then
                    strDefinition_Database = ""
                    For Each objDR_Definition In objDRC_Definition
                        If Not strDefinition_Database = "" Then
                            strDefinition_Database = strDefinition_Database & vbCrLf

                        End If
                        strDefinition_Database = strDefinition_Database & objDR_Definition.Item("Text")

                    Next
                    objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                              GUID_DBItem, _
                                                                              objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                              objLocalConfig.SemItem_Type_XML.GUID, _
                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                              objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                              objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                              objDRs_Item(0).Item("GUID_ItemInSchema")).Rows
                    If objDRC_CreationScript.Count > 0 Then
                        objXML.LoadXml(objDRC_CreationScript(0).Item("XML"))
                        objXMLNodeList = objXML.GetElementsByTagName("data")
                        objXMLElement = objXMLNodeList(0)
                        strDefinition_Schema = objXMLElement.InnerText
                        strDefinition_Schema = strDefinition_Schema.Replace(Chr(10), "")
                        strDefinition_Schema = strDefinition_Schema.Replace(Chr(13), "")

                        strDefinition_Database = strDefinition_Database.Replace(Chr(10), "")
                        strDefinition_Database = strDefinition_Database.Replace(Chr(13), "")

                        If String.Compare(strDefinition_Database, strDefinition_Schema, True) = 0 Then
                            objTreeNode_Item.ForeColor = Color.Green

                        Else
                            objTreeNode_Item.ImageIndex = intImageID_DB_Definition
                            objTreeNode_Item.SelectedImageIndex = intImageID_DB_Definition
                            objTreeNode_Item.ForeColor = Color.Yellow
                            objTreeNode_Item.ToolTipText = "Die Definitionen des Schemas und des Datenbankobjekts stimmt nicht überein!"
                        End If

                    Else
                        objTreeNode_Item.ImageIndex = intImageID_DB_In
                        objTreeNode_Item.SelectedImageIndex = intImageID_DB_In
                        objTreeNode_Item.ForeColor = Color.Yellow
                        objTreeNode_Item.ToolTipText = "In der Datenbank existiert keine Definition des Erzeugungsskriptes"
                    End If


                Else
                    objTreeNode_Item.ImageIndex = intImageID_DB_In
                    objTreeNode_Item.SelectedImageIndex = intImageID_DB_In
                    objTreeNode_Item.ForeColor = Color.Red
                    objTreeNode_Item.ToolTipText = "Das Datenbankobjekt existiert nur in der Datenbank!"
                End If
            Catch ex As Exception

            End Try

        End If

        Return objDRs_Item
    End Function

    Private Sub TreeView_DatabasesOfSchema_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_DatabasesOfSchema.AfterSelect
        Dim objTreeNode As TreeNode
        objTreeNode = e.Node

        If Not objTreeNode.ToolTipText = "" Then
            ToolStripLabel_ToolTip.Text = objTreeNode.ToolTipText
        Else
            ToolStripLabel_ToolTip.Text = ""
        End If
    End Sub

    Private Sub ImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objRegExp As Regex
        Dim objSemItem_DBItem As clsSemItem
        Dim objConnection As SqlClient.SqlConnection

        objDatabaseConnection.Name_Database = strName_Database
        objDatabaseConnection.Name_Server = strName_Server

        objDBItemWork = New clsDBItemWork(GUID_DatabaseSchema)

        objTreeNode = TreeView_DatabasesOfSchema.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Funciont_DB_in, cint_ImageID_Function_DB_Definition
                    objRegExp = New Regex(objLocalConfig.Globals.RegEx_GUID)
                    objSemItem_DBItem = New clsSemItem
                    If objRegExp.IsMatch(objTreeNode.Name) = True Then
                        objSemItem_DBItem.GUID = New Guid(objTreeNode.Name)
                        objSemItem_DBItem.Name = objTreeNode.Text
                        objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                        objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    Else
                        objSemItem_DBItem.GUID = Guid.NewGuid
                        objSemItem_DBItem.Name = objTreeNode.Text
                        objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                        objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    End If
                    If objDBItemWork.import_DBItem(objSemItem_DBItem, objConnection) = False Then
                        MsgBox("Die Funktion kann nicht importiert werden!", MsgBoxStyle.Exclamation)
                    End If
            End Select
        End If
    End Sub









    Private Sub CopyDefinitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyDefinitionToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objDRs_Definition() As DataRow
        Dim objConnection As New SqlClient.SqlConnection(objDatabaseConnection.ConnectionString)
        objTreeNode = TreeView_DatabasesOfSchema.SelectedNode

        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Function_DB, cint_ImageID_Function_DB_Definition, cint_ImageID_Function_DB_out, cint_ImageID_Funciont_DB_in
                    procA_TSQL_Functions.Fill(procT_TSQL_Functions)
                    objDRs_Definition = procT_TSQL_Functions.Select("ROUTINE_NAME='" & objTreeNode.Text & "'")
                    If objDRs_Definition.Count > 0 Then
                        Clipboard.SetDataObject(objDRs_Definition(0).Item("ROUTINE_DEFINITION"))
                        MsgBox("Definition wurde ins Clipboard geschrieben!", MsgBoxStyle.Information)
                    Else
                        MsgBox("Keine Definition gefunden!", MsgBoxStyle.Exclamation)
                    End If

                Case cint_ImageID_Procedure_DB, cint_ImageID_Procedure_DB_Definition, cint_ImageID_Procedure_DB_in, cint_ImageID_Procedure_DB_out
                Case cint_ImageID_Synonym_DB, cint_ImageID_Synonym_DB_Definition, cint_ImageID_Synonym_DB_in, cint_ImageID_Synonym_DB_out
                Case cint_ImageID_Table_DB, cint_ImageID_Table_DB_Definition, cint_ImageID_Table_DB_in, cint_ImageID_Table_DB_out
                Case cint_ImageID_Trigger_DB, cint_ImageID_Trigger_DB_Definition, cint_ImageID_Trigger_DB_in, cint_ImageID_Trigger_DB_out
                Case cint_ImageID_View_DB, cint_ImageID_View_DB_Definition, cint_ImageID_View_DB_in, cint_ImageID_View_DB_out
            End Select
        End If
    End Sub


    Private Sub ContextMenuStrip_DataGrid_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_DataGrid.Opening

        ExportOtDBToolStripMenuItem.Enabled = False
        SchemaItemsToolStripMenuItem.Enabled = False

        If DataGridView_Schemas.SelectedRows.Count = 1 Then
            ExportOtDBToolStripMenuItem.Enabled = True
            SchemaItemsToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub ExportOtDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportOtDBToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRV_SemDB As DataRowView
        Dim objSemItem_DBSchema As clsSemItem
        Dim objSemItem_Database As clsSemItem
        Dim objSemItem_Server As New clsSemItem


        If DataGridView_Schemas.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Schemas.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_DBSchema = New clsSemItem
            objSemItem_DBSchema.GUID = objDRV_Selected.Item("GUID_DatabaseSchema")
            objSemItem_DBSchema.Name = objDRV_Selected.Item("Name_DatabaseSchema")
            objSemItem_DBSchema.GUID_Parent = objLocalConfig.SemItem_Type_Database_Schema.GUID
            objSemItem_DBSchema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


            objFrmSchemaManager = New frmSchemaManager(objLocalConfig.Globals)
            objFrmSchemaManager.isApplyable = True
            objFrmSchemaManager.ShowDialog(Me)
            If objFrmSchemaManager.DialogResult = DialogResult.OK Then
                If objFrmSchemaManager.isSemView = True Then
                    objDRV_SemDB = objFrmSchemaManager.DRV_Selected
                    objSemDBWork = New clsDBWork
                    objSemItem_Database = New clsSemItem
                    objSemItem_Database.GUID = objDRV_SemDB.Item("GUID_Database")
                    objSemItem_Database.Name = objDRV_SemDB.Item("Name_Database")
                    objSemItem_Database.GUID_Parent = objLocalConfig.SemItem_Type_Database.GUID
                    objSemItem_Database.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objSemItem_Database.GUID_Related = objDRV_SemDB.Item("GUID_DatabaseOnServer")
                    objSemItem_Server.GUID = objDRV_SemDB.Item("GUID_Server")
                    objSemItem_Server.Name = objDRV_SemDB.Item("Name_Server")
                    objSemItem_Server.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                    objSemItem_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    If objSemDBWork.create_Schema(objSemItem_DBSchema, objSemItem_Database, objSemItem_Server, ToSQLFileToolStripMenuItem.Checked) = True Then
                        fill_SchemaView()
                    End If

                Else
                    MsgBox("Bitte eine Datenbank aus der Semantic-View auswählen!", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub




    Private Sub TreeView_SchemaItems_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_SchemaItems.AfterSelect
        Dim objTreenode As TreeNode
        Dim objSemItem_Item As New clsSemItem

        objTreenode = TreeView_SchemaItems.SelectedNode
        If Not objTreenode Is Nothing Then
            objSemItem_Item.GUID = New Guid(objTreenode.Name)
            objSemItem_Item.Name = objTreenode.Text
            objSemItem_Item.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            Select Case objTreenode.ImageIndex
                Case cint_ImageID_FunctionItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                    show_SchemaItem_Detail(objSemItem_Item)
                Case cint_ImageID_ProcedureItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Procedure.GUID
                    show_SchemaItem_Detail(objSemItem_Item)
                Case cint_ImageID_ParameterItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Parameters.GUID
                    show_SchemaItem_Detail(objSemItem_Item)
                Case cint_ImageID_SynonymItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                    show_SchemaItem_Detail(objSemItem_Item)
                Case cint_ImageID_TableItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Tables.GUID
                    show_SchemaItem_Detail(objSemItem_Item)
                Case cint_ImageID_TriggerItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Triggers.GUID
                    show_SchemaItem_Detail(objSemItem_Item)
                Case cint_ImageID_ViewItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Views.GUID
                    show_SchemaItem_Detail(objSemItem_Item)

            End Select
        End If
    End Sub


    Private Sub TreeView_SchemaItems_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView_SchemaItems.BeforeExpand
        Dim i As Integer
        Dim objTreeNode_Sub As TreeNode

        Try
            objThread.Abort()
        Catch ex As Exception

        End Try

        objThread = New Threading.Thread(AddressOf get_Dependencies)
        procT_CreationScript_needed_DBItems.Clear()
        tblDBItemInSchema.Clear()
        intRowsDone = 0
        Select Case e.Node.ImageIndex
            Case cint_ImageID_Functions

                For Each objTreeNode_Sub In e.Node.Nodes
                    'get_Related_SemItems(objTreeNode_Sub)
                    tblDBItemInSchema.Rows.Add(New Guid(objTreeNode_Sub.Name), objTreeNode_Sub.ImageIndex)

                Next

                boolNodesDone = False
                objThread.Start()
                TimerNodes.Start()

            Case cint_ImageID_Parameters

                For Each objTreeNode_Sub In e.Node.Nodes
                    tblDBItemInSchema.Rows.Add(New Guid(objTreeNode_Sub.Name), objTreeNode_Sub.ImageIndex)
                Next
                boolNodesDone = False
                objThread.Start()
                TimerNodes.Start()
            Case cint_ImageID_Procedures
                For Each objTreeNode_Sub In e.Node.Nodes
                    'get_Related_SemItems(objTreeNode_Sub)
                    tblDBItemInSchema.Rows.Add(New Guid(objTreeNode_Sub.Name), objTreeNode_Sub.ImageIndex)

                Next
                boolNodesDone = False
                objThread.Start()
                TimerNodes.Start()
            Case cint_ImageID_Synonyms
                For Each objTreeNode_Sub In e.Node.Nodes

                    tblDBItemInSchema.Rows.Add(New Guid(objTreeNode_Sub.Name), objTreeNode_Sub.ImageIndex)
                Next
                boolNodesDone = False
                objThread.Start()
                TimerNodes.Start()
            Case cint_ImageID_Tables
                For Each objTreeNode_Sub In e.Node.Nodes
                    tblDBItemInSchema.Rows.Add(New Guid(objTreeNode_Sub.Name), objTreeNode_Sub.ImageIndex)
                Next
                boolNodesDone = False
                objThread.Start()
                TimerNodes.Start()
            Case cint_ImageID_Triggers
                For Each objTreeNode_Sub In e.Node.Nodes
                    tblDBItemInSchema.Rows.Add(New Guid(objTreeNode_Sub.Name), objTreeNode_Sub.ImageIndex)
                Next
                boolNodesDone = False
                objThread.Start()
                TimerNodes.Start()
            Case cint_ImageID_Views
                For Each objTreeNode_Sub In e.Node.Nodes
                    'get_Related_SemItems(objTreeNode_Sub)
                    tblDBItemInSchema.Rows.Add(New Guid(objTreeNode_Sub.Name), objTreeNode_Sub.ImageIndex)

                Next
                boolNodesDone = False
                objThread.Start()
                TimerNodes.Start()
        End Select
    End Sub

    Private Sub TreeView_SchemaItems_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView_SchemaItems.KeyDown
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Parent As TreeNode
        Dim objTreeNode_Parent_Parent As TreeNode
        Dim objSemItem_DBItem As clsSemItem
        Dim objDRC_CreationScript As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ObjectReference As DataRowCollection

        objTreeNode = TreeView_SchemaItems.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case e.KeyCode
                Case Keys.Delete
                    objTreeNode_Parent = objTreeNode.Parent

                    If Not objTreeNode_Parent Is Nothing Then
                        If objTreeNode_Parent.ImageIndex = cint_ImageID_NeededItems Then
                            objTreeNode_Parent_Parent = objTreeNode_Parent.Parent
                            objSemItem_DBItem = New clsSemItem
                            objSemItem_DBItem.GUID = New Guid(objTreeNode_Parent_Parent.Name)
                            objSemItem_DBItem.Name = objTreeNode_Parent_Parent.Text
                            objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            Select Case objTreeNode_Parent_Parent.ImageIndex
                                Case cint_ImageID_FunctionItem
                                    objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID
                                    objSemItem_DBItem.GUID_Related = objLocalConfig.SemItem_Type_Functions_in_Schema.GUID

                                Case cint_ImageID_ProcedureItem
                                    objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Procedure.GUID
                                    objSemItem_DBItem.GUID_Related = objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID

                                Case cint_ImageID_TableItem
                                    objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Tables.GUID
                                    objSemItem_DBItem.GUID_Related = objLocalConfig.SemItem_Type_Tables_in_Schema.GUID

                                Case cint_ImageID_TriggerItem
                                    objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Triggers.GUID
                                    objSemItem_DBItem.GUID_Related = objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID

                                Case cint_ImageID_SynonymItem
                                    objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                                    objSemItem_DBItem.GUID_Related = objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID
                                Case cint_ImageID_ViewItem
                                    objSemItem_DBItem.GUID_Parent = objLocalConfig.SemItem_Type_DB_Views.GUID
                                    objSemItem_DBItem.GUID_Related = objLocalConfig.SemItem_Type_Views_in_Schema.GUID

                            End Select
                            objDRC_CreationScript = procA_CreationScript_By_GUID_DBItem_To_Schema.GetData(objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                                         objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                         objSemItem_DBItem.GUID_Parent, _
                                                                                         objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                         objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                         objLocalConfig.SemItem_Type_XML.GUID, _
                                                                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                         objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                         objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                         objSemItem_DBItem.GUID).Rows
                            If objDRC_CreationScript.Count > 0 Then

                                Select Case objTreeNode.ImageIndex
                                    Case cint_ImageID_Token, cint_ImageID_AttributeType, cint_ImageID_Type, cint_ImageID_RelationType
                                        objDRC_ObjectReference = semfuncA_ObjectReference.GetData_By_GUID_Ref(New Guid(objTreeNode.Name)).Rows
                                        If objDRC_CreationScript.Count > 0 Then
                                            'objDRC_LogState = semprocA_DBWork_Del_Token_OR.GetData(objDRC_CreationScript(0).Item("GUID_CreationScript"), objDRC_ObjectReference(0).Item("GUID_ObjectReference"), objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID).Rows
                                            'If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then

                                            '    get_dependencies(objTreeNode_Parent_Parent)
                                            '    objTreeNode_Parent_Parent.ExpandAll()
                                            'Else
                                            '    MsgBox("Das Sem-Item konnte leider nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                                            'End If
                                        Else
                                            MsgBox("Das Referenzierte Sem-Item konnte nicht gefunden werden!", MsgBoxStyle.Critical)
                                        End If



                                End Select
                            Else
                                MsgBox("Die Definition des Datenbank-Objektes kann nicht ermittelt werden!", MsgBoxStyle.Critical)
                            End If

                        End If

                    End If
            End Select
        End If
    End Sub

    Private Sub DocumentationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentationToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_DBSchema As clsSemItem

        If DataGridView_Schemas.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Schemas.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_DBSchema = New clsSemItem
            objSemItem_DBSchema.GUID = objDRV_Selected.Item("GUID_DatabaseSchema")
            objSemItem_DBSchema.Name = objDRV_Selected.Item("Name_DatabaseSchema")
            objSemItem_DBSchema.GUID_Parent = objLocalConfig.SemItem_Type_Database_Schema.GUID
            objSemItem_DBSchema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objFrmDocumentation = New frmSchemaDocumentation(objSemItem_DBSchema)
            objFrmDocumentation.ShowDialog(Me)

        End If
    End Sub

    Private Sub WhoNeedsThisItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhoNeedsThisItemToolStripMenuItem.Click
        Dim objTreenode As TreeNode
        Dim objSemItem_Item As New clsSemItem

        objTreenode = TreeView_SchemaItems.SelectedNode
        If Not objTreenode Is Nothing Then
            objSemItem_Item.GUID = New Guid(objTreenode.Name)
            objSemItem_Item.Name = objTreenode.Text
            objSemItem_Item.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            Select Case objTreenode.ImageIndex
                Case cint_ImageID_FunctionItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Function.GUID

                Case cint_ImageID_ProcedureItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Procedure.GUID


                Case cint_ImageID_TableItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Tables.GUID

                Case cint_ImageID_TriggerItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Triggers.GUID

                Case cint_ImageID_ViewItem
                    objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_DB_Views.GUID


            End Select

        End If
    End Sub

    Private Sub Button_ChangeVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ChangeVersion.Click
        Dim objSemItem_Schema As New clsSemItem

        objSemItem_Schema.GUID = GUID_DatabaseSchema
        objSemItem_Schema.Name = Name_Schema
        objSemItem_Schema.GUID_Parent = objLocalConfig.SemItem_Type_Database_Schema.GUID
        objSemItem_Schema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrmVersion = New frmVersion(objLocalConfig.Globals, objSemItem_Schema, objLocalConfig.User, True)
        objFrmVersion.ShowDialog(Me)
        If objFrmVersion.DialogResult = DialogResult.OK Then
            fill_SchemaDetail()
        End If
    End Sub

    Private Sub NewSchemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSchemaToolStripMenuItem.Click
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_DatabaseSchema As DataRowCollection
        objDlg_AttributeVarchar255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Type_Database_Schema.Name, objLocalConfig.Globals)
        objDlg_AttributeVarchar255.ShowDialog(Me)
        If objDlg_AttributeVarchar255.DialogResult = DialogResult.OK Then
            objDRC_DatabaseSchema = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_Database_Schema.GUID, objDlg_AttributeVarchar255.Value1).Rows
            If objDRC_DatabaseSchema.Count = 0 Then
                objSemItem_DBSchema = New clsSemItem

                objSemItem_DBSchema.GUID = Guid.NewGuid
                objSemItem_DBSchema.Name = objDlg_AttributeVarchar255.Value1
                objSemItem_DBSchema.GUID_Parent = objLocalConfig.SemItem_Type_Database_Schema.GUID
                objSemItem_DBSchema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_DBSchema.save_001_DBSchema(objSemItem_DBSchema)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_DBSchema.save_002_DBSchema_To_SchemaType
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_DBSchema.save_003_DBSchema_To_DevelopmentVersion
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                            objSemItem_Result = objTransaction_DBSchema.save_004_DBSchema_To_File
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                fill_SchemaView()
                            Else


                                If objTransaction_DBSchema.del_003_DBSchema_To_DevelopmentVersion().GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    If objTransaction_DBSchema.del_002_DBSchema_To_SchemaType().GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_DBSchema.del_001_DBSchema()
                                    End If

                                End If


                                MsgBox("Das Datenbankschema konnte nicht angelegt werden!", MsgBoxStyle.Exclamation)

                            End If




                        Else
                            If objTransaction_DBSchema.del_002_DBSchema_To_SchemaType().GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_DBSchema.del_001_DBSchema()
                            End If

                            MsgBox("Das Datenbankschema konnte nicht angelegt werden!", MsgBoxStyle.Exclamation)

                        End If
                    Else
                        objTransaction_DBSchema.del_001_DBSchema()
                        MsgBox("Das Datenbankschema konnte nicht angelegt werden!", MsgBoxStyle.Exclamation)

                    End If
                Else
                    MsgBox("Das Datenbankschema konnte nicht angelegt werden!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Es existiert bereits ein Datenbankschema mit dem angegebenen Namen!", MsgBoxStyle.Exclamation)
            End If

        End If
    End Sub

    Private Sub TimerNodes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerNodes.Tick
        Dim dateStart As Date
        Dim objDR_Node As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNodes_Needs() As TreeNode
        Dim objTreeNode_Needs As TreeNode
        Dim intImageID As Integer

        dateStart = Now

        While (Now - dateStart).Milliseconds < 280
            If (intRowsDone < procT_CreationScript_needed_DBItems.Rows.Count) Or boolNodesDone = False Then
                Try
                    objDR_Node = procT_CreationScript_needed_DBItems.Rows(intRowsDone)
                    objTreeNodes = TreeView_SchemaItems.Nodes.Find(objDR_Node.Item("GUID_Node_Parent").ToString, True)
                    If objTreeNodes.Count > 0 Then
                        objTreeNodes_Needs = objTreeNodes(0).Nodes.Find(objLocalConfig.SemItem_RelationType_needs.GUID.ToString, False)
                        If objTreeNodes_Needs.Count = 0 Then
                            objTreeNode_Needs = objTreeNodes(0).Nodes.Add(objLocalConfig.SemItem_RelationType_needs.GUID.ToString, objLocalConfig.SemItem_RelationType_needs.Name, cint_ImageID_NeededItems, cint_ImageID_NeededItems)
                        Else
                            objTreeNode_Needs = objTreeNodes_Needs(0)
                        End If
                        Select Case objDR_Node.Item("GUID_Type_DBItem")
                            Case objLocalConfig.SemItem_Type_DB_Function.GUID
                                intImageID = cint_ImageID_FunctionItem_Needed

                            Case objLocalConfig.SemItem_Type_DB_Procedure.GUID
                                intImageID = cint_ImageID_ProcedureItem_Needed
                            Case objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                                intImageID = cint_ImageID_SynonymItem_Needed
                            Case objLocalConfig.SemItem_Type_DB_Tables.GUID
                                intImageID = cint_ImageID_TableItem_Needed
                            Case objLocalConfig.SemItem_Type_DB_Triggers.GUID
                                intImageID = cint_ImageID_TriggerItem_Needed
                            Case objLocalConfig.SemItem_Type_DB_Views.GUID
                                intImageID = cint_ImageID_ViewItem_Needed
                        End Select
                        If objTreeNode_Needs.Nodes.Find(objDR_Node.Item("GUID_DBItem").ToString, False).Count = 0 Then
                            objTreeNode_Needs.Nodes.Add(objDR_Node.Item("GUID_DBItem").ToString, objDR_Node.Item("Name_DBItem"), intImageID, intImageID)
                        End If
                    Else
                        Stop
                    End If
                    intRowsDone = intRowsDone + 1
                Catch ex As Exception

                End Try

            Else
                If boolNodesDone = True Then
                    intRowsDone = 0
                    TimerNodes.Stop()
                End If
            End If
        End While


    End Sub
End Class
