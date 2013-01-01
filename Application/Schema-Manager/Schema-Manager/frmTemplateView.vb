Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Management.Common
Imports Sem_Manager
Public Class frmTemplateView
    Private procA_Item_in_Schema As New ds_SchemaManagerTableAdapters.proc_Item_in_SchemaTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private proc_TSQL_Tables As New ds_TemplateViewTableAdapters.proc_TSQL_TablesTableAdapter
    Private systblA_Procedures As New ds_TemplateViewTableAdapters.proc_TSQL_ProceduresTableAdapter
    Private systblA_ObjectDefinitions As New ds_TemplateViewTableAdapters.proc_TSQL_ObjectDefinitionTableAdapter
    Private systblA_PARAMETERS As New ds_TemplateViewTableAdapters.proc_TSQL_ParametersTableAdapter
    Private systblA_Functions As New ds_TemplateViewTableAdapters.proc_TSQL_FunctionsTableAdapter
    Private systblA_Synonyms As New ds_TemplateViewTableAdapters.proc_TSQL_SynonymsTableAdapter
    Private systblA_Triggers As New ds_TemplateViewTableAdapters.proc_TSQL_TriggersTableAdapter
    Private systblA_Views As New ds_TemplateViewTableAdapters.proc_TSQL_ViewsTableAdapter

    Private dtbl_Tables As New ds_TemplateView.dtblTablesDataTable
    Private dtbl_Procedures As New ds_TemplateView.dtblProceduresDataTable
    Private dtbl_Functions As New ds_TemplateView.dtblFunctionsDataTable
    Private dtbl_Synonyms As New ds_TemplateView.dtblSynonymsDataTable
    Private dtbl_Triggers As New ds_TemplateView.dtblTriggersDataTable
    Private dtbl_Views As New ds_TemplateView.dtblViewsDataTable
    Private strServerName As String
    Private strDatabaseName As String
    Private objConnection As SqlClient.SqlConnection
    Private objSemItem_Import As clsSemItem
    Private objSemItem_Schema As clsSemItem
    Private objServerCon As ServerConnection
    Private objServer As Server

    Public ReadOnly Property Table_Rows() As DataRowCollection
        Get
            Return dtbl_Tables.Rows
        End Get
    End Property

    Public ReadOnly Property Procedure_Rows() As DataRowCollection
        Get
            Return dtbl_Procedures.Rows
        End Get
    End Property

    Public ReadOnly Property Functions_Rows() As DataRowCollection
        Get
            Return dtbl_Functions.Rows
        End Get
    End Property

    Public ReadOnly Property Synonyms_Rows() As DataRowCollection
        Get
            Return dtbl_Synonyms.Rows
        End Get
    End Property

    Public ReadOnly Property Trigger_Rows() As DataRowCollection
        Get
            Return dtbl_Triggers.Rows
        End Get
    End Property

    Public ReadOnly Property Views_Rows() As DataRowCollection
        Get
            Return dtbl_Views.Rows
        End Get
    End Property
    Public Sub New(ByVal Server_Name As String, ByVal Database_Name As String, ByVal SemItem_Import As clsSemItem, ByVal SemItem_Schema As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.



        strServerName = Server_Name
        strDatabaseName = Database_Name
        objSemItem_Import = SemItem_Import
        objSemItem_Schema = SemItem_Schema
        objConnection = New SqlClient.SqlConnection("Data Source=" & _
                    strServerName & _
                    "\SQLEXPRESS;Initial Catalog=" & _
                    strDatabaseName & _
                    ";Integrated Security=True")
        set_DBConnection()
    End Sub


    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        procA_Item_in_Schema.Connection = objLocalConfig.Connection_Plugin
        proc_TSQL_Tables.Connection = objConnection
        systblA_ObjectDefinitions.Connection = objConnection
        systblA_Procedures.Connection = objConnection
        systblA_PARAMETERS.Connection = objConnection
        systblA_Functions.Connection = objConnection
        systblA_Synonyms.Connection = objConnection
        systblA_Triggers.Connection = objConnection
        systblA_Views.Connection = objConnection
    End Sub

    Private Sub get_Tables()
        Dim objDRC_Table As DataRowCollection
        Dim objDR_Table As DataRow
        Dim objDRC_SemTable As DataRowCollection
        Dim procT_Item_in_Schema As New ds_SchemaManager.proc_Item_in_SchemaDataTable
        Dim objDRs_DBItem_Exist() As DataRow
        Dim strName_Table As String
        Dim Date_Creation As Date

        dtbl_Tables.Clear()
        
        objDRC_Table = proc_TSQL_Tables.GetData.Rows
        For Each objDR_Table In objDRC_Table
            strName_Table = objDR_Table.Item("name")
            Date_Creation = objDR_Table.Item("create_date")

            procA_Item_in_Schema.Fill(procT_Item_in_Schema, _
                                      objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                      objLocalConfig.SemItem_Type_Tables_in_Schema.GUID, _
                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                      objSemItem_Schema.GUID)
            objDRs_DBItem_Exist = procT_Item_in_Schema.Select("Name_DBItem='" & strName_Table & "'")
            If objDRs_DBItem_Exist.Count = 0 Then
                dtbl_Tables.Rows.Add(True, strName_Table, Nothing, Nothing, Date_Creation)
            Else
                dtbl_Tables.Rows.Add(False, strName_Table, objDRs_DBItem_Exist(0).Item("GUID_DBItem"), objDRs_DBItem_Exist(0).Item("Name_DBItem"), Date_Creation)
            End If
        Next

        




        DataGridView_DBItems.DataSource = dtbl_Tables
        DataGridView_DBItems.Columns(2).Visible = False
    End Sub

    

    Private Sub frmTemplateView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objServerCon = New ServerConnection
        objServerCon.ServerInstance = strServerName & "\SQLEXPRESS"
        objServerCon.LoginSecure = True
        objServer = New Server(objServerCon)

        Try
            objServer.ConnectionContext.Connect()
            If objSemItem_Import.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                Select Case objSemItem_Import.GUID
                    Case objLocalConfig.SemItem_Type_DB_Function.GUID
                        get_Functions()
                    Case objLocalConfig.SemItem_Type_DB_Procedure.GUID
                        get_Procedure()
                    Case objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                        get_Synonyms()
                    Case objLocalConfig.SemItem_Type_DB_Tables.GUID
                        get_Tables()
                    Case objLocalConfig.SemItem_Type_DB_Triggers.GUID
                        get_Triggers()
                    Case objLocalConfig.SemItem_Type_DB_Views.GUID
                        get_Views()
                End Select
            Else
                Select Case objSemItem_Import.GUID_Parent
                    Case objLocalConfig.SemItem_Type_DB_Function.GUID
                        get_Functions(objSemItem_Import)
                    Case objLocalConfig.SemItem_Type_DB_Procedure.GUID
                        get_Procedure(objSemItem_Import)
                    Case objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                        get_Synonyms()
                    Case objLocalConfig.SemItem_Type_DB_Tables.GUID
                        get_Tables()
                    Case objLocalConfig.SemItem_Type_DB_Triggers.GUID
                        get_Triggers()
                    Case objLocalConfig.SemItem_Type_DB_Views.GUID
                        get_Views()
                End Select
            End If
            



            

            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Me.Close()

        End Try
        ToolStripLabel_ItemCount.Text = DataGridView_DBItems.RowCount
    End Sub

    Private Sub get_Procedure(Optional ByVal objSemItem_Item As clsSemItem = Nothing)
        'Dim objDRC_Procedures As DataRowCollection
        Dim systblT_Procedures As New ds_TemplateView.proc_TSQL_ProceduresDataTable
        Dim procT_Item_in_Schema As New ds_SchemaManager.proc_Item_in_SchemaDataTable
        Dim objDRs_DBItem_Exist() As DataRow
        Dim objDRs_Procedures() As DataRow
        Dim objDR_Procedure As DataRow
        Dim objDRC_ObjectDefinition As DataRowCollection
        Dim objDR_ObjectDefinition As DataRow
        Dim objDRC_Parameters As DataRowCollection
        Dim objDR_Parameters As DataRow
        Dim objDRC_SemProcedures As DataRowCollection
        Dim strName_Procedure As String
        Dim strDefinition As String
        Dim strParameters As String
        Dim GUID_ProcSem As Guid
        Dim Name_ProcSem As String
        Dim Date_Create As Date
        Dim Date_Altered As Date
        Dim boolImport As Boolean

        dtbl_Procedures.Clear()
        'objDRC_Procedures = systblA_Procedures.GetData.Rows
        systblA_Procedures.Fill(systblT_Procedures)
        If objSemItem_Item Is Nothing Then
            objDRs_Procedures = systblT_Procedures.Select
        Else
            objDRs_Procedures = systblT_Procedures.Select("name='" & objSemItem_Item.Name & "'")
        End If
        For Each objDR_Procedure In objDRs_Procedures
            strName_Procedure = objDR_Procedure.Item("name")
            Date_Create = objDR_Procedure.Item("create_date")
            Date_Altered = objDR_Procedure.Item("modify_date")
            objDRC_ObjectDefinition = systblA_ObjectDefinitions.GetData(strName_Procedure).Rows
            strDefinition = ""
            For Each objDR_ObjectDefinition In objDRC_ObjectDefinition
                If Not strDefinition = "" Then
                    strDefinition = strDefinition & vbCrLf
                End If
                strDefinition = strDefinition & objDR_ObjectDefinition.Item("Text")
            Next
            If strDefinition = "" Then
                strDefinition = Nothing
            End If

            strParameters = Nothing
            objDRC_Parameters = systblA_PARAMETERS.GetData(strName_Procedure).Rows
            For Each objDR_Parameters In objDRC_Parameters
                If strParameters = Nothing Then
                    strParameters = objDR_Parameters.Item("PARAMETER_NAME")
                Else
                    strParameters = strParameters & "," & objDR_Parameters.Item("PARAMETER_NAME")
                End If
            Next

            procA_Item_in_Schema.Fill(procT_Item_in_Schema, _
                                      objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                      objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID, _
                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                      objSemItem_Schema.GUID)
            objDRs_DBItem_Exist = procT_Item_in_Schema.Select("Name_DBItem='" & strName_Procedure & "'")
            If objDRs_DBItem_Exist.Count > 0 Then
                boolImport = False
                GUID_ProcSem = objDRs_DBItem_Exist(0).Item("GUID_DBItem")
                Name_ProcSem = objDRs_DBItem_Exist(0).Item("Name_DBItem")
                dtbl_Procedures.Rows.Add(boolImport, strName_Procedure, strDefinition, strParameters, GUID_ProcSem, Name_ProcSem, Date_Create, Date_Altered)
            Else
                boolImport = True

                dtbl_Procedures.Rows.Add(boolImport, strName_Procedure, strDefinition, strParameters, Nothing, Nothing, Date_Create, Date_Altered)
            End If


        Next
        DataGridView_DBItems.DataSource = dtbl_Procedures
        DataGridView_DBItems.Columns(4).Visible = False
    End Sub
    Private Sub get_Functions(Optional ByVal objSemItem_Item As clsSemItem = Nothing)
        'Dim objDRC_Functions As DataRowCollection
        Dim systblT_Function As New ds_TemplateView.proc_TSQL_FunctionsDataTable
        Dim procT_Item_in_Schema As New ds_SchemaManager.proc_Item_in_SchemaDataTable
        Dim objDRs_DBItem_Exist() As DataRow
        Dim objDRs_Functions() As DataRow

        Dim objDR_Function As DataRow
        Dim objDRC_ObjectDefinition As DataRowCollection
        Dim objDR_ObjectDefinition As DataRow
        Dim objDRC_Parameters As DataRowCollection
        Dim objDR_Parameters As DataRow
        Dim objDRC_SemFunctions As DataRowCollection
        Dim strName_Function As String
        Dim strDefinition As String
        Dim strParameters As String
        Dim GUID_ProcSem As Guid
        Dim Name_ProcSem As String
        Dim Date_Create As Date
        Dim Date_Altered As Date
        Dim boolImport As Boolean

        dtbl_Functions.Clear()
        systblA_Functions.Fill(systblT_Function)
        If objSemItem_Item Is Nothing Then
            objDRs_Functions = systblT_Function.Select
        Else
            objDRs_Functions = systblT_Function.Select("ROUTINE_NAME='" & objSemItem_Item.Name & "'")
        End If
        For Each objDR_Function In objDRs_Functions
            strName_Function = objDR_Function.Item("ROUTINE_NAME")
            objDRC_ObjectDefinition = systblA_ObjectDefinitions.GetData(strName_Function).Rows
            strDefinition = ""
            For Each objDR_ObjectDefinition In objDRC_ObjectDefinition
                If Not strDefinition = "" Then
                    strDefinition = strDefinition & vbCrLf

                End If
                strDefinition = strDefinition & objDR_ObjectDefinition.Item("Text")
            Next


            Date_Create = objDR_Function.Item("CREATED")
            Date_Altered = objDR_Function.Item("LAST_ALTERED")

            strParameters = Nothing
            objDRC_Parameters = systblA_PARAMETERS.GetData(strName_Function).Rows
            For Each objDR_Parameters In objDRC_Parameters
                If strParameters = Nothing Then
                    strParameters = objDR_Parameters.Item("PARAMETER_NAME")
                Else
                    strParameters = strParameters & "," & objDR_Parameters.Item("PARAMETER_NAME")
                End If
            Next
            procA_Item_in_Schema.Fill(procT_Item_in_Schema, _
                                      objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                      objLocalConfig.SemItem_Type_Functions_in_Schema.GUID, _
                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                      objSemItem_Schema.GUID)
            objDRs_DBItem_Exist = procT_Item_in_Schema.Select("Name_DBItem='" & strName_Function & "'")
            If objDRs_DBItem_Exist.Count > 0 Then
                boolImport = False
                GUID_ProcSem = objDRs_DBItem_Exist(0).Item("GUID_DBItem")
                Name_ProcSem = objDRs_DBItem_Exist(0).Item("Name_DBItem")
                dtbl_Functions.Rows.Add(boolImport, strName_Function, strDefinition, strParameters, GUID_ProcSem, Name_ProcSem, Date_Create, Date_Altered)
            Else
                boolImport = True

                dtbl_Functions.Rows.Add(boolImport, strName_Function, strDefinition, strParameters, Nothing, Nothing, Date_Create, Date_Altered)
            End If


        Next
        DataGridView_DBItems.DataSource = dtbl_Functions
        DataGridView_DBItems.Columns(4).Visible = False
    End Sub
    Private Sub get_Synonyms()
        Dim objDRC_Synonyms As DataRowCollection
        Dim objDR_Synonym As DataRow
        Dim procT_Item_in_Schema As New ds_SchemaManager.proc_Item_in_SchemaDataTable
        Dim objDRs_DBItem_Exist() As DataRow
        Dim objDRC_Parameters As DataRowCollection
        Dim objDR_Parameters As DataRow
        Dim objDRC_SemSynonyms As DataRowCollection

        Dim strName_Synonym As String
        Dim GUID_ProcSem As Guid
        Dim Name_ProcSem As String

        Dim Date_Create As Date
        Dim boolImport As Boolean

        dtbl_Synonyms.Clear()
        objDRC_Synonyms = systblA_Synonyms.GetData.Rows
        For Each objDR_Synonym In objDRC_Synonyms
            strName_Synonym = objDR_Synonym.Item("name")
            Date_Create = objDR_Synonym.Item("create_date")

            
            

            procA_Item_in_Schema.Fill(procT_Item_in_Schema, _
                                      objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                      objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID, _
                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                      objSemItem_Schema.GUID)
            objDRs_DBItem_Exist = procT_Item_in_Schema.Select("Name_DBItem='" & strName_Synonym & "'")
            If objDRs_DBItem_Exist.Count > 0 Then
                boolImport = False
                GUID_ProcSem = objDRs_DBItem_Exist(0).Item("GUID_DBItem")
                Name_ProcSem = objDRs_DBItem_Exist(0).Item("Name_DBItem")
                dtbl_Synonyms.Rows.Add(boolImport, strName_Synonym, GUID_ProcSem, Name_ProcSem, Date_Create)
            Else
                boolImport = True

                dtbl_Synonyms.Rows.Add(boolImport, strName_Synonym, Nothing, Nothing, Date_Create)
            End If


        Next
        DataGridView_DBItems.DataSource = dtbl_Synonyms
        DataGridView_DBItems.Columns(2).Visible = False
    End Sub

    Private Sub get_Triggers()
        Dim objDRC_Triggers As DataRowCollection
        Dim procT_Item_in_Schema As New ds_SchemaManager.proc_Item_in_SchemaDataTable
        Dim objDRs_DBItem_Exist() As DataRow
        Dim objDR_Trigger As DataRow
        Dim objDRC_ObjectDefinition As DataRowCollection
        Dim objDR_ObjectDefinition As DataRow
        Dim objDRC_Parameters As DataRowCollection
        Dim objDR_Parameters As DataRow
        Dim objDRC_SemTriggers As DataRowCollection
        Dim strName_Trigger As String
        Dim strDefinition As String
        Dim GUID_ProcSem As Guid
        Dim Name_ProcSem As String
        Dim Date_Create As Date
        Dim boolImport As Boolean

        dtbl_Triggers.Clear()
        objDRC_Triggers = systblA_Triggers.GetData.Rows
        For Each objDR_Trigger In objDRC_Triggers
            strName_Trigger = objDR_Trigger.Item("name")
            Date_Create = objDR_Trigger.Item("create_date")
            objDRC_ObjectDefinition = systblA_ObjectDefinitions.GetData(strName_Trigger).Rows
            strDefinition = ""
            For Each objDR_ObjectDefinition In objDRC_ObjectDefinition
                If Not strDefinition = "" Then
                    strDefinition = strDefinition & vbCrLf
                End If
                strDefinition = strDefinition & objDR_ObjectDefinition.Item("Text")
            Next
            If strDefinition = "" Then
                strDefinition = Nothing
            End If

            

            procA_Item_in_Schema.Fill(procT_Item_in_Schema, _
                                      objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                      objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID, _
                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                      objSemItem_Schema.GUID)
            objDRs_DBItem_Exist = procT_Item_in_Schema.Select("Name_DBItem='" & strName_Trigger & "'")
            If objDRs_DBItem_Exist.Count > 0 Then
                boolImport = False
                GUID_ProcSem = objDRs_DBItem_Exist(0).Item("GUID_DBItem")
                Name_ProcSem = objDRs_DBItem_Exist(0).Item("Name_DBItem")
                dtbl_Triggers.Rows.Add(boolImport, strName_Trigger, strDefinition, GUID_ProcSem, Name_ProcSem, Date_Create)
            Else
                boolImport = True

                dtbl_Triggers.Rows.Add(boolImport, strName_Trigger, strDefinition, Nothing, Nothing, Date_Create)
            End If


        Next
        DataGridView_DBItems.DataSource = dtbl_Triggers
        DataGridView_DBItems.Columns(3).Visible = False
    End Sub

    Private Sub get_Views()
        Dim objDRC_Views As DataRowCollection
        Dim procT_Item_in_Schema As New ds_SchemaManager.proc_Item_in_SchemaDataTable
        Dim objDRs_DBItem_Exist() As DataRow
        Dim objDR_View As DataRow
        Dim objDRC_ObjectDefinition As DataRowCollection
        Dim objDR_ObjectDefinition As DataRow
        Dim objDRC_Parameters As DataRowCollection
        Dim objDR_Parameters As DataRow
        Dim objDRC_SemViews As DataRowCollection
        Dim strName_View As String
        Dim strDefinition As String
        Dim GUID_ProcSem As Guid
        Dim Name_ProcSem As String
        Dim Date_Create As Date
        Dim boolImport As Boolean

        dtbl_Views.Clear()
        objDRC_Views = systblA_Views.GetData.Rows
        For Each objDR_View In objDRC_Views
            strName_View = objDR_View.Item("name")
            Date_Create = objDR_View.Item("create_date")
            objDRC_ObjectDefinition = systblA_ObjectDefinitions.GetData(strName_View).Rows

            strDefinition = ""
            For Each objDR_ObjectDefinition In objDRC_ObjectDefinition
                If Not strDefinition = "" Then
                    strDefinition = strDefinition & vbCrLf
                End If
                strDefinition = strDefinition & objDR_ObjectDefinition.Item("Text")
            Next
            If strDefinition = "" Then
                strDefinition = Nothing
            End If



            procA_Item_in_Schema.Fill(procT_Item_in_Schema, _
                                      objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                      objLocalConfig.SemItem_Type_Views_in_Schema.GUID, _
                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                      objSemItem_Schema.GUID)
            objDRs_DBItem_Exist = procT_Item_in_Schema.Select("Name_DBItem='" & strName_View & "'")
            If objDRs_DBItem_Exist.Count > 0 Then
                boolImport = False
                GUID_ProcSem = objDRs_DBItem_Exist(0).Item("GUID_DBItem")
                Name_ProcSem = objDRs_DBItem_Exist(0).Item("Name_DBItem")
                dtbl_Views.Rows.Add(boolImport, strName_View, strDefinition, GUID_ProcSem, Name_ProcSem, Date_Create)
            Else
                boolImport = True

                dtbl_Views.Rows.Add(boolImport, strName_View, strDefinition, Nothing, Nothing, Date_Create)
            End If


        Next
        DataGridView_DBItems.DataSource = dtbl_Views
        DataGridView_DBItems.Columns(3).Visible = False
    End Sub

    Private Sub ToolStripButton_Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Apply.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub ToolStripButton_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Cancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Hide()
    End Sub

    Private Sub DataGridView_DBItems_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView_DBItems.CellPainting
        'Dim objDGVR_Selected As DataGridViewRow
        'Dim objDRV_Selected As DataRowView
        'Dim objDGVC_Selected As DataGridViewCell

        'If Not e.RowIndex = -1 Then
        '    objDGVR_Selected = DataGridView_DBItems.Rows(e.RowIndex)
        '    objDRV_Selected = objDGVR_Selected.DataBoundItem

        '    If objDRV_Selected.Item("CreationDate") <> objDRV_Selected.Item("AlterDate") Then
        '        For Each objDGVC_Selected In objDGVR_Selected.Cells
        '            objDGVC_Selected.Style.BackColor = Color.Yellow
        '        Next
        '    End If
        'End If
        
    End Sub
End Class