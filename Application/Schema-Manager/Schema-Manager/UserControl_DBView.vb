Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Management.Common
Imports Sem_Manager
Imports Log_Manager
Imports Version_Module
Imports Filesystem_Management

Public Class UserControl_DBView
    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Server As Integer = 1

    Private boolApplyable As Boolean
    Private dtbl_DBs As New ds_SchemaManager.dtblDBsDataTable

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private procA_SemDBServers As New ds_SchemaManagerTableAdapters.proc_SemDBServersTableAdapter
    Private funcA_SemDatabasesOnServers As New ds_SchemaManagerTableAdapters.func_SemDatabasesOnServersTableAdapter
    Private funcT_SemDatabasesOnServers As New ds_SchemaManager.func_SemDatabasesOnServersDataTable
    Private procA_SemDBs_By_Name As New ds_SchemaManagerTableAdapters.proc_SemDBs_By_NameTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter

    'Private objVersionWork As clsVersionWork
    Private objFrmVersion As frmVersion
    Private objLogManagement As clsLogManagement
    Private objFrm_SemManager As frmSemManager
    Private objFrm_TokenEdit As frmTokenEdit
    Private objDlg_AttributeVarchar255 As dlgAttribute_Varchar255
    Private objTransaction_DBViewSchema As clsTransaction_DBViewSchema
    Private objBlobConnection As clsBlobConnection


    Private objDBWork As clsDBWork
    'Private clsVersionWork As clsVersionWork

    Private objSemItem_Server As New clsSemItem
    Private objSemItem_Database As New clsSemItem
    Private objSemItem_DatabaseOnServer As New clsSemItem

    Private objDRV_Selected As DataRowView
    Private boolSemView As Boolean

    Public Event selected_Item(ByVal boolSemView As Boolean)

    Public ReadOnly Property Server() As clsSemItem
        Get
            Return objSemItem_Server
        End Get
    End Property
    Public ReadOnly Property DRV_Selected() As DataRowView
        Get
            Return objDRV_Selected
        End Get
    End Property
    Public WriteOnly Property Applyable()
        Set(ByVal value)
            boolApplyable = value
            ApplyToolStripMenuItem.Visible = boolApplyable
            ApplyToolStripMenuItem_SemDB.Visible = boolApplyable
            ApplyLiveViewToolStripMenuItem.Visible = boolApplyable
        End Set
    End Property

    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        set_DBConnection()


    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        procA_SemDBServers.Connection = objLocalConfig.Connection_Plugin
        funcA_SemDatabasesOnServers.Connection = objLocalConfig.Connection_Plugin
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        procA_SemDBs_By_Name.Connection = objLocalConfig.Connection_Plugin
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB


        objDBWork = New clsDBWork()


        objLogManagement = New clsLogManagement(objLocalConfig.Globals)
        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
    End Sub

    Public Sub initialize()
        fill_Tree()
    End Sub

    Private Sub fill_Tree()
        Dim objTreeNode_Root As TreeNode
        Dim objTreeNode As TreeNode
        Dim objDRC_Servers As DataRowCollection
        Dim objDR_Server As DataRow

        TreeView_DBServer.Nodes.Clear()

        objTreeNode_Root = TreeView_DBServer.Nodes.Add(objLocalConfig.SemItem_Token_Server_Type_SemDB_Server.GUID.ToString, objLocalConfig.SemItem_Token_Server_Type_SemDB_Server.Name, cint_ImageID_Root, cint_ImageID_Root)

        objDRC_Servers = procA_SemDBServers.GetData(objLocalConfig.SemItem_Type_Server.GUID, _
                                                    objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                    objLocalConfig.SemItem_Token_Server_Type_SemDB_Server.GUID).Rows

        For Each objDR_Server In objDRC_Servers
            objTreeNode = objTreeNode_Root.Nodes.Add(objDR_Server.Item("GUID_Server").ToString, objDR_Server.Item("Name_Server"), cint_ImageID_Server, cint_ImageID_Server)
        Next

        objTreeNode_Root.Expand()
    End Sub

    Private Sub get_DatabasesOfServer(ByVal GUID_Server As Guid)
        funcA_SemDatabasesOnServers.Fill_By_GUIDServer(funcT_SemDatabasesOnServers, _
                                                               objLocalConfig.SemItem_Type_Server.GUID, _
                                                               objLocalConfig.SemItem_Type_Database_on_Server.GUID, _
                                                               objLocalConfig.SemItem_Type_Database.GUID, _
                                                               objLocalConfig.SemItem_type_DevelopmentVersion.GUID, _
                                                               objLocalConfig.SemItem_Type_DB_Schema_Type.GUID, _
                                                               objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                               objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                               objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                               GUID_Server)
    End Sub

    Private Sub configure_TabPages()
        Dim objTreeNode_Selected As TreeNode

        BindingSource_DBsLive.DataSource = Nothing
        DataGridView_DBsLive.DataSource = Nothing
        BindingSource_DBsSem.DataSource = Nothing
        DataGridView_DBsSem.DataSource = Nothing

        objTreeNode_Selected = TreeView_DBServer.SelectedNode

        If Not objTreeNode_Selected Is Nothing Then
            If objTreeNode_Selected.ImageIndex = cint_ImageID_Server Then
                objSemItem_Server.GUID = New Guid(objTreeNode_Selected.Name)
                objSemItem_Server.Name = objTreeNode_Selected.Text
                objSemItem_Server.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                objSemItem_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Select Case TabControl1.SelectedTab.Name
                    Case TabPage_SemView.Name


                        get_DatabasesOfServer(objSemItem_Server.GUID)

                        BindingSource_DBsSem.DataSource = funcT_SemDatabasesOnServers
                        DataGridView_DBsSem.DataSource = BindingSource_DBsSem
                        DataGridView_DBsSem.Columns(0).Visible = False
                        DataGridView_DBsSem.Columns(1).Visible = False
                        DataGridView_DBsSem.Columns(2).Visible = False
                        DataGridView_DBsSem.Columns(3).Visible = False
                        DataGridView_DBsSem.Columns(4).Visible = False
                        DataGridView_DBsSem.Columns(5).Visible = False
                        DataGridView_DBsSem.Columns(6).Visible = False
                        DataGridView_DBsSem.Columns(7).Width = 300
                        DataGridView_DBsSem.Columns(8).Visible = False
                        DataGridView_DBsSem.Columns(9).Visible = False
                        DataGridView_DBsSem.Columns(11).Visible = False
                        DataGridView_DBsSem.Columns(12).Visible = False
                        DataGridView_DBsSem.Columns(14).Visible = False
                        DataGridView_DBsSem.Columns(15).Visible = False
                        DataGridView_DBsSem.Columns(17).Visible = False
                        DataGridView_DBsSem.Columns(18).Visible = False


                        ToolStripLabel_CountSemDBs.Text = DataGridView_DBsSem.RowCount
                    Case TabPage_LiveView.Name
                        get_LiveDBs(objTreeNode_Selected)
                        ToolStripLabel_CountDBs.Text = DataGridView_DBsLive.RowCount
                End Select
            End If
            
        End If
        
    End Sub
    Private Sub TreeView_DBServer_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_DBServer.AfterSelect
        configure_TabPages()
    End Sub

   
    Private Sub get_LiveDBs(ByVal objTreeNode_Selected As TreeNode)
        Dim objServerCon As ServerConnection
        Dim objServer As Server
        Dim objDatabase As Database
        Dim objDataSet As DataSet
        Dim objDataTable As DataTable
        Dim objDRs_SemDBs() As DataRow
        Dim strServer As String
        Dim strSchemaVersion As String
        Dim boolRegistered As Boolean
        Dim boolRightVersion As Boolean

        strServer = objTreeNode_Selected.Text & "\SQLEXPRESS"
        objServerCon = New ServerConnection
        objServerCon.ServerInstance = strServer
        objServerCon.LoginSecure = True
        objServer = New Server(objServerCon)
        dtbl_DBs.Clear()
        Try
            objServer.ConnectionContext.Connect()
            For Each objDatabase In objServer.Databases

                objDataSet = objDatabase.ExecuteWithResults("SELECT value " & _
                    "FROM fn_listextendedproperty(default, default, default, default, default, default, default) " & _
                    "WHERE name='SemDB'")
                objDataTable = objDataSet.Tables(0)
                If objDataTable.Rows.Count > 0 Then
                    objDataSet = objDatabase.ExecuteWithResults("SELECT value " & _
                    "FROM fn_listextendedproperty(default, default, default, default, default, default, default) " & _
                    "WHERE name='SchemaVersion'")
                    objDataTable = objDataSet.Tables(0)
                    strSchemaVersion = ""
                    objDRs_SemDBs = funcT_SemDatabasesOnServers.Select("Name_Database='" & objDatabase.Name & "'")
                    If objDRs_SemDBs.Length = 1 Then
                        boolRegistered = True
                    Else
                        boolRegistered = False
                    End If
                    boolRightVersion = False
                    If objDataTable.Rows.Count > 0 Then
                        strSchemaVersion = objDataTable.Rows(0).Item("Value")
                        If objDRs_SemDBs.Count > 0 Then
                            If objDRs_SemDBs(0).Item("Name_DevelopmentVersion") = strSchemaVersion Then
                                boolRightVersion = True
                            End If
                        End If
                    End If

                    dtbl_DBs.Rows.Add(objDatabase.Name, strSchemaVersion, boolRegistered, boolRightVersion)
                End If

            Next
            BindingSource_DBsLive.DataSource = dtbl_DBs
            DataGridView_DBsLive.DataSource = BindingSource_DBsLive
            DataGridView_DBsLive.Columns(0).Width = 300
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    
    Private Sub format_Controls()
        ApplyToolStripMenuItem.Visible = boolApplyable
    End Sub

    Private Sub ContextMenuStrip_DBView_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_DBView.Opening
        Dim objTreeNode As TreeNode


        NewToolStripMenuItem.Enabled = False
        AttachAsSemDBToolStripMenuItem.Enabled = False

        objTreeNode = TreeView_DBServer.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Server Then
                NewToolStripMenuItem.Enabled = True
            End If
        End If
       
        If DataGridView_DBsLive.SelectedRows.Count = 1 Then
            boolSemView = False
            ApplyToolStripMenuItem.Enabled = True
            AttachAsSemDBToolStripMenuItem.Enabled = True
        End If
       
    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click

        Dim objDGVR_Selected As DataGridViewRow
        
        If DataGridView_DBsLive.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_DBsLive.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            RaiseEvent selected_Item(boolSemView)
        Else
            MsgBox("Bitte nur ein Item auswählen!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub AddDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDatabaseToolStripMenuItem.Click
        Dim objDRs_Databases() As DataRow
        Dim objSemItem_LogEntry As clsSemItem
        Dim objSemItem_Version As clsSemItem
        
        Dim strDatabaseName As String
        objDlg_AttributeVarchar255 = New dlgAttribute_Varchar255("New Database", objLocalConfig.Globals)
        objDlg_AttributeVarchar255.ShowDialog(Me)
        If objDlg_AttributeVarchar255.DialogResult = DialogResult.OK Then
            strDatabaseName = objDlg_AttributeVarchar255.Value1
            get_DatabasesOfServer(objSemItem_Server.GUID)
            objDRs_Databases = funcT_SemDatabasesOnServers.Select("Name_Database='" & strDatabaseName & "'")
            If objDRs_Databases.Count = 0 Then
                If save_001_Database(strDatabaseName) = True Then
                    If save_002_DatabaseToServer() = True Then
                        If save_003_DatabaseOnServer_To_Database() = True Then
                            If save_004_DatabaseOnServer_To_Server() = True Then
                                objSemItem_LogEntry = objLogManagement.log_Entry(Now, objLocalConfig.SemItem_Token_LogState_Create.GUID, objLocalConfig.User.GUID, objLocalConfig.SemItem_Token_LogState_Create.Name)
                                If Not objSemItem_LogEntry Is Nothing Then
                                    objFrmVersion = New frmVersion(objLocalConfig.Globals, objSemItem_DatabaseOnServer, objLocalConfig.User, False, objSemItem_LogEntry)
                                    objFrmVersion.ShowDialog()
                                    If objFrmVersion.DialogResult = DialogResult.OK Then
                                        fill_Tree()
                                    Else
                                        objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                                        del_004_DatabaseOnServer_To_Server()
                                        del_003_DatabaseOnServer_To_Database()
                                        del_002_DatabaseOnServer()
                                        del_001_Database()
                                    End If


                                Else
                                    del_004_DatabaseOnServer_To_Server()
                                    del_003_DatabaseOnServer_To_Database()
                                    del_002_DatabaseOnServer()
                                    del_001_Database()
                                End If

                            Else
                                del_003_DatabaseOnServer_To_Database()
                                del_002_DatabaseOnServer()
                                del_001_Database()
                            End If
                        Else
                            del_002_DatabaseOnServer()
                            del_001_Database()
                        End If
                    Else
                        del_001_Database()
                    End If
                Else
                    MsgBox("Die Datenbank kann leider nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If
                
            Else
                MsgBox("Es gibt bereits eine Datenbank mit dem angegebenen Namen! Bitte wählen Sie einen anderen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Function save_001_Database(ByVal strName_Database As String) As Boolean
        Dim objDRC_LogState As DataRowCollection

        Dim boolResult As Boolean

        objSemItem_Database.GUID = Guid.NewGuid
        objSemItem_Database.Name = strName_Database
        objSemItem_Database.GUID_Parent = objLocalConfig.SemItem_Type_Database.GUID
        objSemItem_Database.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Database.GUID, objSemItem_Database.Name, objSemItem_Database.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Private Sub del_001_Database()
        semprocA_DBWork_Del_Token.GetData(objSemItem_Database.GUID)
    End Sub

    Private Function save_002_DatabaseToServer() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        objSemItem_DatabaseOnServer = New clsSemItem
        objSemItem_DatabaseOnServer.GUID = Guid.NewGuid
        objSemItem_DatabaseOnServer.Name = objSemItem_Database.Name & "\" & objSemItem_Server.Name
        objSemItem_DatabaseOnServer.GUID_Parent = objLocalConfig.SemItem_Type_Database_on_Server.GUID
        objSemItem_DatabaseOnServer.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DatabaseOnServer.GUID, objSemItem_DatabaseOnServer.Name, objSemItem_DatabaseOnServer.GUID_Parent, False).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If
        Return boolResult
    End Function

    Private Sub del_002_DatabaseOnServer()
        semprocA_DBWork_Del_Token.GetData(objSemItem_DatabaseOnServer.GUID)
    End Sub

    Private Function save_003_DatabaseOnServer_To_Database() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DatabaseOnServer.GUID, objSemItem_Database.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Private Sub del_003_DatabaseOnServer_To_Database()
        semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatabaseOnServer.GUID, objSemItem_Database.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID)
    End Sub

    Private Function save_004_DatabaseOnServer_To_Server() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DatabaseOnServer.GUID, objSemItem_Server.GUID, objLocalConfig.SemItem_RelationType_located_in.GUID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Private Sub del_004_DatabaseOnServer_To_Server()
        semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatabaseOnServer.GUID, objSemItem_Server.GUID, objLocalConfig.SemItem_RelationType_located_in.GUID)
    End Sub
    
    Private Sub ApplyToolStripMenuItem_SemDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem_SemDB.Click
        Dim objDGVR_Selected As DataGridViewRow

        objDGVR_Selected = DataGridView_DBsSem.SelectedRows(0)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        RaiseEvent selected_Item(True)

    End Sub

    Private Sub ContextMenuStrip_SemDBs_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_SemDBs.Opening
        ApplyToolStripMenuItem_SemDB.Enabled = False
        SaveTSQLScriptsToolStripMenuItem.Enabled = False
        If DataGridView_DBsSem.SelectedRows.Count = 1 Then
            ApplyToolStripMenuItem_SemDB.Enabled = True
            SaveTSQLScriptsToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        Dim strDB_Name As String


        objTreeNode = TreeView_DBServer.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Server Then
                objDlg_AttributeVarchar255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Type_Database.Name, objLocalConfig.Globals)
                objDlg_AttributeVarchar255.ShowDialog(Me)
                If objDlg_AttributeVarchar255.DialogResult = DialogResult.OK Then
                    strDB_Name = objDlg_AttributeVarchar255.Value1
                    If objDBWork.DB_exists(objTreeNode.Text & "\SQLEXPRESS", strDB_Name) = False Then
                        If objDBWork.create_Database(strDB_Name, objTreeNode.Text & "\SQLEXPRESS") = True Then
                            get_LiveDBs(objTreeNode)
                        Else
                            MsgBox("Die Datennbank konnte nicht angelegt werden!", MsgBoxStyle.Exclamation)
                        End If

                    Else
                        MsgBox("Die Datenbank existiert bereits!", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If
        End If
        
    End Sub

    Private Sub AttachAsSemDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttachAsSemDBToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_SemDBs() As DataRow
        Dim objSemItem_DBOnServer As New clsSemItem
        Dim objSemItem_Database As New clsSemItem
        Dim objSemItem_Version As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Database As DataRowCollection
        Dim objTreeNode As TreeNode
        Dim objSemItem_LogEntry As clsSemItem

        Dim strName_Database As String
        Dim boolSave As Boolean

        If DataGridView_DBsLive.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_DBsLive.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            strName_Database = objDRV_Selected.Item("Database")
            objTreeNode = TreeView_DBServer.SelectedNode
            get_DatabasesOfServer(New Guid(objTreeNode.Name))
            objDRs_SemDBs = funcT_SemDatabasesOnServers.Select("Name_Database='" & strName_Database & "'")
            If objDRs_SemDBs.Count = 0 Then
                boolSave = True
                objDRC_Database = procA_SemDBs_By_Name.GetData(objLocalConfig.SemItem_Attribute_is_Sem_DB.GUID, _
                                                               objLocalConfig.SemItem_Type_Database.GUID, _
                                                               strName_Database).Rows
                If objDRC_Database.Count = 0 Then
                    objSemItem_Database.GUID = Guid.NewGuid
                    objSemItem_Database.Name = strName_Database
                    objSemItem_Database.GUID_Parent = objLocalConfig.SemItem_Type_Database.GUID
                    objSemItem_Database.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Database.GUID, objSemItem_Database.Name, objSemItem_Database.GUID_Parent, True).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Database.GUID, objLocalConfig.SemItem_Attribute_is_Sem_DB.GUID, Nothing, True, 0).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            semprocA_DBWork_Del_Token.GetData(objSemItem_Database.GUID)
                            MsgBox("Die Datenbank konnte nicht registriert werden!", MsgBoxStyle.Exclamation)
                            boolSave = False
                        End If
                    Else

                        MsgBox("Die Datenbank konnte nicht registriert werden!", MsgBoxStyle.Exclamation)
                        boolSave = False
                    End If
                Else
                    objSemItem_Database.GUID = objDRC_Database(0).Item("GUID_Database")
                    objSemItem_Database.Name = objDRC_Database(0).Item("Name_Database")
                    objSemItem_Database.GUID_Parent = objLocalConfig.SemItem_Type_Database.GUID
                    objSemItem_Database.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                End If
                If boolSave = True Then
                    objSemItem_DBOnServer.GUID = Guid.NewGuid
                    objSemItem_DBOnServer.Name = strName_Database & "\" & objTreeNode.Text
                    objSemItem_DBOnServer.GUID_Parent = objLocalConfig.SemItem_Type_Database_on_Server.GUID
                    objSemItem_DBOnServer.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DBOnServer.GUID, _
                                                                         objSemItem_DBOnServer.Name, _
                                                                         objSemItem_DBOnServer.GUID_Parent, True).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBOnServer.GUID, _
                                                                                New Guid(objTreeNode.Name), _
                                                                                objLocalConfig.SemItem_RelationType_located_in.GUID, 0).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBOnServer.GUID, _
                                                                                    objSemItem_Database.GUID, _
                                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                objSemItem_LogEntry = objLogManagement.log_Entry(Now, objLocalConfig.SemItem_Token_LogState_Create.GUID, objLocalConfig.User.GUID, objLocalConfig.SemItem_Token_LogState_Create.Name)
                                objFrmVersion = New frmVersion(objLocalConfig.Globals, objSemItem_DBOnServer, objLocalConfig.User, False, objSemItem_LogEntry)
                                objFrmVersion.ShowDialog()
                                If objFrmVersion.DialogResult = DialogResult.OK Then
                                    get_DatabasesOfServer(New Guid(objTreeNode.Name))
                                Else
                                    objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBOnServer.GUID, _
                                                                                       objSemItem_Database.GUID, _
                                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                                    objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBOnServer.GUID, _
                                                                                       New Guid(objTreeNode.Name), _
                                                                                       objLocalConfig.SemItem_RelationType_located_in.GUID).Rows
                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                        semprocA_DBWork_Del_Token.GetData(objSemItem_DBOnServer.GUID)
                                    End If

                                End If

                            Else
                                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBOnServer.GUID, _
                                                                                       New Guid(objTreeNode.Name), _
                                                                                       objLocalConfig.SemItem_RelationType_located_in.GUID).Rows
                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                    semprocA_DBWork_Del_Token.GetData(objSemItem_DBOnServer.GUID)
                                End If

                                MsgBox("Die Datenbank konnte nicht registriert werden!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            semprocA_DBWork_Del_Token.GetData(objSemItem_DBOnServer.GUID)
                            MsgBox("Die Datenbank konnte nicht registriert werden!", MsgBoxStyle.Exclamation)
                        End If

                    Else
                        MsgBox("Die Datenbank konnte nicht registriert werden!", MsgBoxStyle.Exclamation)
                    End If
                End If
                
            Else
                MsgBox("Die Datenbank wurde bereits registriert!", MsgBoxStyle.Exclamation)
            End If
        End If


    End Sub

    Private Sub NewSchemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSchemaToolStripMenuItem.Click
        Dim objSemItem_Result As clsSemItem

        get_DatabasesOfServer(objSemItem_Server.GUID)

        objTransaction_DBViewSchema = New clsTransaction_DBViewSchema

        objSemItem_Result = objTransaction_DBViewSchema.get_001_TransactionData(objSemItem_Server, funcT_SemDatabasesOnServers, Me)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_DBViewSchema.save_001_Database
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_DBViewSchema.save_002_DB_isSemDB
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_DBViewSchema.save_003_DB_To_Schema
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_DBViewSchema.save_004_DB_To_SchemaType
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_DBViewSchema.save_005_DatabaseOnServer
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_DBViewSchema.save_006_DatabaseOnServer_To_Database
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_DBViewSchema.save_007_DatabaseOnServer_To_Server
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_DBViewSchema.save_008_DatabaseForSynonyms
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_DBViewSchema.save_009_DatabaseForSynonyms_To_DB
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_DBViewSchema.save_010_DBForSynonyms_To_DBOnServer
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                    objSemItem_Result = objTransaction_DBViewSchema.save_011_Version()
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_DBViewSchema.save_012_DBForSynonyms_To_Server
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            get_DatabasesOfServer(objSemItem_Server.GUID)

                                                            BindingSource_DBsSem.DataSource = funcT_SemDatabasesOnServers
                                                            DataGridView_DBsSem.DataSource = BindingSource_DBsSem
                                                            DataGridView_DBsSem.Columns(0).Visible = False
                                                            DataGridView_DBsSem.Columns(1).Visible = False
                                                            DataGridView_DBsSem.Columns(2).Visible = False
                                                            DataGridView_DBsSem.Columns(3).Visible = False
                                                            DataGridView_DBsSem.Columns(4).Visible = False
                                                            DataGridView_DBsSem.Columns(5).Visible = False
                                                            DataGridView_DBsSem.Columns(6).Visible = False
                                                            DataGridView_DBsSem.Columns(7).Width = 300
                                                            DataGridView_DBsSem.Columns(8).Visible = False
                                                            DataGridView_DBsSem.Columns(9).Visible = False
                                                            DataGridView_DBsSem.Columns(11).Visible = False
                                                            DataGridView_DBsSem.Columns(12).Visible = False
                                                            DataGridView_DBsSem.Columns(14).Visible = False

                                                            ToolStripLabel_CountSemDBs.Text = DataGridView_DBsSem.RowCount
                                                        Else
                                                            MsgBox("Das Schema konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                            objSemItem_Result = objTransaction_DBViewSchema.del_011_Version
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_DBViewSchema.del_010_DBForSynonyms_To_DBOnServer
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objSemItem_Result = objTransaction_DBViewSchema.del_009_DatabaseForSynonyms_To_DB
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objSemItem_Result = objTransaction_DBViewSchema.del_008_DatabaseForSynonyms
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objSemItem_Result = objTransaction_DBViewSchema.del_007_DatabaseOnServer_To_Server
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objSemItem_Result = objTransaction_DBViewSchema.del_006_DatabaseOnServer_To_Database
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objSemItem_Result = objTransaction_DBViewSchema.del_005_DatabaseOnServer
                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                        objSemItem_Result = objTransaction_DBViewSchema.del_004_DB_To_SchemaType
                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                            objSemItem_Result = objTransaction_DBViewSchema.del_003_DB_To_Schema
                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                objSemItem_Result = objTransaction_DBViewSchema.del_002_DB_isSemDB
                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                    objTransaction_DBViewSchema.del_001_Database()
                                                                                                End If
                                                                                            End If

                                                                                        End If

                                                                                    End If
                                                                                End If

                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If

                                                        End If

                                                    Else

                                                        MsgBox("Das Schema konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                        objSemItem_Result = objTransaction_DBViewSchema.del_010_DBForSynonyms_To_DBOnServer
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_DBViewSchema.del_009_DatabaseForSynonyms_To_DB
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_DBViewSchema.del_008_DatabaseForSynonyms
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objSemItem_Result = objTransaction_DBViewSchema.del_007_DatabaseOnServer_To_Server
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objSemItem_Result = objTransaction_DBViewSchema.del_006_DatabaseOnServer_To_Database
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objSemItem_Result = objTransaction_DBViewSchema.del_005_DatabaseOnServer
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objSemItem_Result = objTransaction_DBViewSchema.del_004_DB_To_SchemaType
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objSemItem_Result = objTransaction_DBViewSchema.del_003_DB_To_Schema
                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                        objSemItem_Result = objTransaction_DBViewSchema.del_002_DB_isSemDB
                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                            objTransaction_DBViewSchema.del_001_Database()
                                                                                        End If
                                                                                    End If

                                                                                End If

                                                                            End If
                                                                        End If

                                                                    End If
                                                                End If
                                                            End If
                                                        End If




                                                    End If
                                                Else

                                                    MsgBox("Das Schema konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                    objSemItem_Result = objTransaction_DBViewSchema.del_009_DatabaseForSynonyms_To_DB
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_DBViewSchema.del_008_DatabaseForSynonyms
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_DBViewSchema.del_007_DatabaseOnServer_To_Server
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_DBViewSchema.del_006_DatabaseOnServer_To_Database
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objSemItem_Result = objTransaction_DBViewSchema.del_005_DatabaseOnServer
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objSemItem_Result = objTransaction_DBViewSchema.del_004_DB_To_SchemaType
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objSemItem_Result = objTransaction_DBViewSchema.del_003_DB_To_Schema
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objSemItem_Result = objTransaction_DBViewSchema.del_002_DB_isSemDB
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objTransaction_DBViewSchema.del_001_Database()
                                                                                End If
                                                                            End If

                                                                        End If

                                                                    End If
                                                                End If

                                                            End If
                                                        End If
                                                    End If



                                                End If
                                            Else

                                                MsgBox("Das Schema konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                objSemItem_Result = objTransaction_DBViewSchema.del_008_DatabaseForSynonyms
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_DBViewSchema.del_007_DatabaseOnServer_To_Server
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_DBViewSchema.del_006_DatabaseOnServer_To_Database
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_DBViewSchema.del_005_DatabaseOnServer
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_DBViewSchema.del_004_DB_To_SchemaType
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objSemItem_Result = objTransaction_DBViewSchema.del_003_DB_To_Schema
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objSemItem_Result = objTransaction_DBViewSchema.del_002_DB_isSemDB
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objTransaction_DBViewSchema.del_001_Database()
                                                                        End If
                                                                    End If

                                                                End If

                                                            End If
                                                        End If

                                                    End If
                                                End If


                                            End If
                                        Else

                                            MsgBox("Das Schema konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                            objSemItem_Result = objTransaction_DBViewSchema.del_007_DatabaseOnServer_To_Server
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_DBViewSchema.del_006_DatabaseOnServer_To_Database
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_DBViewSchema.del_005_DatabaseOnServer
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_DBViewSchema.del_004_DB_To_SchemaType
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_DBViewSchema.del_003_DB_To_Schema
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_DBViewSchema.del_002_DB_isSemDB
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objTransaction_DBViewSchema.del_001_Database()
                                                                End If
                                                            End If

                                                        End If

                                                    End If
                                                End If

                                            End If

                                        End If
                                    Else

                                        MsgBox("Das Schema konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                        objSemItem_Result = objTransaction_DBViewSchema.del_006_DatabaseOnServer_To_Database
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_DBViewSchema.del_005_DatabaseOnServer
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_DBViewSchema.del_004_DB_To_SchemaType
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_DBViewSchema.del_003_DB_To_Schema
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_DBViewSchema.del_002_DB_isSemDB
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objTransaction_DBViewSchema.del_001_Database()
                                                        End If
                                                    End If

                                                End If

                                            End If
                                        End If

                                    End If
                                Else
                                    MsgBox("Das Schema konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                    objSemItem_Result = objTransaction_DBViewSchema.del_005_DatabaseOnServer
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_DBViewSchema.del_004_DB_To_SchemaType
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_DBViewSchema.del_003_DB_To_Schema
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_DBViewSchema.del_002_DB_isSemDB
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objTransaction_DBViewSchema.del_001_Database()
                                                End If
                                            End If

                                        End If

                                    End If


                                End If
                            Else
                                MsgBox("Das Schema konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                objSemItem_Result = objTransaction_DBViewSchema.del_004_DB_To_SchemaType
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_DBViewSchema.del_003_DB_To_Schema
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_DBViewSchema.del_002_DB_isSemDB
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objTransaction_DBViewSchema.del_001_Database()
                                        End If
                                    End If

                                End If

                            End If
                        Else
                            MsgBox("Das Schema konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            objSemItem_Result = objTransaction_DBViewSchema.del_003_DB_To_Schema
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_DBViewSchema.del_002_DB_isSemDB
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objTransaction_DBViewSchema.del_001_Database()
                                End If
                            End If

                        End If
                    Else
                        MsgBox("Das Schema konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        objSemItem_Result = objTransaction_DBViewSchema.del_002_DB_isSemDB
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTransaction_DBViewSchema.del_001_Database()
                        End If

                    End If
                Else
                    MsgBox("Das Schema konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    objTransaction_DBViewSchema.del_001_Database()
                End If
            Else
                MsgBox("Das Schema konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Private Sub ContextMenuStrip_LiveView_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_LiveView.Opening
        Dim objTreeNode As TreeNode

        ApplyLiveViewToolStripMenuItem.Enabled = False
        AddServerToolStripMenuItem.Enabled = False
        If DataGridView_DBsLive.SelectedRows.Count = 1 Then
            ApplyLiveViewToolStripMenuItem.Enabled = True
        End If

        objTreeNode = TreeView_DBServer.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Root Then
                AddServerToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        configure_TabPages()
    End Sub


    Private Sub AddServerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddServerToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Root As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        objFrm_SemManager = New frmSemManager(objLocalConfig.SemItem_Type_Server, objLocalConfig.Globals)
        objFrm_SemManager.Applyabale = True
        objFrm_SemManager.ShowDialog(Me)

        If objFrm_SemManager.DialogResult = DialogResult.OK Then
            If objFrm_SemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If Not objFrm_SemManager.SelectedRows_Items Is Nothing Then
                    If objFrm_SemManager.SelectedRows_Items.Count = 1 Then
                        objDGVR_Selected = objFrm_SemManager.SelectedRows_Items(0)
                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                        If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Server.GUID Then
                            objTreeNode_Root = TreeView_DBServer.Nodes(0)
                            objTreeNodes = objTreeNode_Root.Nodes.Find(objDRV_Selected.Item("GUID_Token").ToString, False)
                            If objTreeNodes.Count = 0 Then
                                objTreeNode = objTreeNode_Root.Nodes.Add(objDRV_Selected.Item("GUID_Token").ToString, objDRV_Selected.Item("Name_Token"), cint_ImageID_Server, cint_ImageID_Server)
                            End If
                        Else
                            MsgBox("Bitte nur einen Server auswählen!", MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("Bitte nur einen Server auswählen!", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Bitte nur einen Server auswählen!", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Bitte nur einen Server auswählen!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub DataGridView_DBsSem_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView_DBsSem.CellPainting
        If e.RowIndex > -1 Then
            If e.ColumnIndex = 10 Then
                If DataGridView_DBsSem.Rows(e.RowIndex).Cells(18).Value = 0 Then
                    DataGridView_DBsSem.Rows(e.RowIndex).Cells(7).Style.BackColor = Color.Yellow
                End If
            End If
        End If
        
    End Sub

    Private Sub DataGridView_DBsSem_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_DBsSem.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objSemItem_Database As New clsSemItem

        objDGVR_Selected = DataGridView_DBsSem.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Database.GUID = objDRV_Selected.Item("GUID_Database")
        objSemItem_Database.Name = objDRV_Selected.Item("Name_Database")
        objSemItem_Database.GUID_Parent = objLocalConfig.SemItem_Type_Database.GUID
        objSemItem_Database.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrm_TokenEdit = New frmTokenEdit(objSemItem_Database, objLocalConfig.Globals)
        objFrm_TokenEdit.ShowDialog(Me)
    End Sub

    Private Sub SaveTSQLScriptsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveTSQLScriptsToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objDRC_Files As DataRowCollection
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Version As New clsSemItem

        Dim objSemItem_Result As clsSemItem

        Dim boolSave As Boolean

        Dim strPath As String

        objDGVR_Selected = DataGridView_DBsSem.SelectedRows(0)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        If FolderBrowserDialog_Files.ShowDialog(Me) = DialogResult.OK Then
            strPath = FolderBrowserDialog_Files.SelectedPath
            If IO.Directory.Exists(strPath) Then

                objDRC_Files = funcA_TokenToken.GetData_LeftRight_Ordered_By_GUIDs(objDRV_Selected.Item("GUID_DatabaseOnServer"), _
                                                                           objLocalConfig.SemItem_Type_File.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_Schema.GUID, False).Rows
                boolSave = True
                If objDRC_Files.Count > 0 Then
                    Try
                        objSemItem_File.GUID = objDRC_Files(0).Item("GUID_Token_Right")
                        objSemItem_File.Name = objDRC_Files(0).Item("Name_Token_Right")
                        objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                        objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objDRC_Files = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_File.GUID, _
                                                                                     objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                                     objLocalConfig.SemItem_type_DevelopmentVersion.GUID).Rows
                        objSemItem_Version.GUID = objDRC_Files(0).Item("GUID_Token_Right")
                        objSemItem_Version.Name = objDRC_Files(0).Item("Name_Token_Right")
                        objSemItem_Version.GUID_Parent = objLocalConfig.SemItem_type_DevelopmentVersion.GUID
                        objSemItem_Version.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath & "\001_Schema_" & objSemItem_Version.Name & ".sql")
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                            boolSave = False
                        End If
                    Catch ex As Exception
                        boolSave = False
                    End Try


                End If

                If boolSave = True Then
                    objDRC_Files = funcA_TokenToken.GetData_LeftRight_Ordered_By_GUIDs(objDRV_Selected.Item("GUID_DatabaseOnServer"), _
                                                                           objLocalConfig.SemItem_Type_File.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_Config.GUID, False).Rows
                    If objDRC_Files.Count > 0 Then
                        Try
                            objSemItem_File.GUID = objDRC_Files(0).Item("GUID_Token_Right")
                            objSemItem_File.Name = objDRC_Files(0).Item("Name_Token_Right")
                            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objDRC_Files = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_File.GUID, _
                                                                                     objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                                     objLocalConfig.SemItem_type_DevelopmentVersion.GUID).Rows
                            objSemItem_Version.GUID = objDRC_Files(0).Item("GUID_Token_Right")
                            objSemItem_Version.Name = objDRC_Files(0).Item("Name_Token_Right")
                            objSemItem_Version.GUID_Parent = objLocalConfig.SemItem_type_DevelopmentVersion.GUID
                            objSemItem_Version.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath & "\002_Config_" & objSemItem_Version.Name & ".sql")
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                boolSave = False
                            End If
                        Catch ex As Exception
                            boolSave = False
                        End Try


                    End If
                End If

                If boolSave = True Then
                    objDRC_Files = funcA_TokenToken.GetData_LeftRight_Ordered_By_GUIDs(objDRV_Selected.Item("GUID_DatabaseOnServer"), _
                                                                           objLocalConfig.SemItem_Type_File.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_User.GUID, False).Rows
                    If objDRC_Files.Count > 0 Then
                        Try
                            objSemItem_File.GUID = objDRC_Files(0).Item("GUID_Token_Right")
                            objSemItem_File.Name = objDRC_Files(0).Item("Name_Token_Right")
                            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objDRC_Files = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_File.GUID, _
                                                                                     objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                                     objLocalConfig.SemItem_type_DevelopmentVersion.GUID).Rows
                            objSemItem_Version.GUID = objDRC_Files(0).Item("GUID_Token_Right")
                            objSemItem_Version.Name = objDRC_Files(0).Item("Name_Token_Right")
                            objSemItem_Version.GUID_Parent = objLocalConfig.SemItem_type_DevelopmentVersion.GUID
                            objSemItem_Version.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath & "\003_User_" & objSemItem_Version.Name & ".sql")
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                boolSave = False
                            End If
                        Catch ex As Exception
                            boolSave = False
                        End Try


                    End If
                End If

                If boolSave = True Then
                    objDRC_Files = funcA_TokenToken.GetData_LeftRight_Ordered_By_GUIDs(objDRV_Selected.Item("GUID_DatabaseOnServer"), _
                                                                           objLocalConfig.SemItem_Type_File.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_Module.GUID, False).Rows
                    If objDRC_Files.Count > 0 Then
                        Try
                            objSemItem_File.GUID = objDRC_Files(0).Item("GUID_Token_Right")
                            objSemItem_File.Name = objDRC_Files(0).Item("Name_Token_Right")
                            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objDRC_Files = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_File.GUID, _
                                                                                     objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                                     objLocalConfig.SemItem_type_DevelopmentVersion.GUID).Rows
                            objSemItem_Version.GUID = objDRC_Files(0).Item("GUID_Token_Right")
                            objSemItem_Version.Name = objDRC_Files(0).Item("Name_Token_Right")
                            objSemItem_Version.GUID_Parent = objLocalConfig.SemItem_type_DevelopmentVersion.GUID
                            objSemItem_Version.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath & "\004_Module_" & objSemItem_Version.Name & ".sql")
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                boolSave = False
                            End If
                        Catch ex As Exception
                            boolSave = False
                        End Try


                    End If
                    If boolSave = False Then
                        MsgBox("Die Dateien konnten nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                MsgBox("Der Pfad existiert nicht!", MsgBoxStyle.Exclamation)
            End If
        End If


        

    End Sub


    Private Sub DataGridView_DBsSem_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView_DBsSem.CellFormatting
        
    End Sub
End Class
