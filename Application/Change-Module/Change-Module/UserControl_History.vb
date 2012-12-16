Imports Sem_Manager
Public Class UserControl_History
    Private objLocalConfig As clsLocalConfig
    Private objThread_Log As Threading.Thread

    Private strConnectionString_DB As String
    Private strConnectionString_Module As String
    Private objSemItem_ProcessLog As clsSemItem

    Private objFrm_TokenEdit As frmTokenEdit

    Private procA_Logentries_Of_ProcessLog As New ds_ChangeModuleTableAdapters.proc_Logentries_Of_ProcessLogTableAdapter
    Private procT_Logentries_Of_ProcessLog As New ds_ChangeModule.proc_Logentries_Of_ProcessLogDataTable

    Private boolDone As Boolean

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
    End Sub

    Public Sub initialize_History(ByVal SemItem_ProcessLog As clsSemItem)
        boolDone = False
        objSemItem_ProcessLog = SemItem_ProcessLog
        Try
            objThread_Log.Abort()
        Catch ex As Exception

        End Try
        objThread_Log = New Threading.Thread(AddressOf get_History)
        objThread_Log.Start()
        Timer_History.Start()

    End Sub

    Public Sub clear_History()
        Try
            objThread_Log.Abort()
        Catch ex As Exception

        End Try

        DataGridView_History.DataSource = Nothing
        ToolStripProgressBar_History.Value = 0
    End Sub

    Private Sub get_History()
        Dim procA_Logentries_Of_ProcessLog As New ds_ChangeModuleTableAdapters.proc_Logentries_Of_ProcessLogTableAdapter
        Dim objConnection As SqlClient.SqlConnection


        objConnection = New SqlClient.SqlConnection(strConnectionString_Module)
        procA_Logentries_Of_ProcessLog.Connection = objConnection
        procA_Logentries_Of_ProcessLog.Fill(procT_Logentries_Of_ProcessLog, _
                                            objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                            objLocalConfig.SemItem_Attribute_Message.GUID, _
                                            objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                            objLocalConfig.SemItem_type_Logstate.GUID, _
                                            objLocalConfig.SemItem_Type_Log.GUID, _
                                            objLocalConfig.SemItem_RelationType_belonging_Done.GUID, _
                                            objLocalConfig.SemItem_RelationType_provides.GUID, _
                                            objLocalConfig.SemItem_RelationType_Time_Measuring.GUID, _
                                            objLocalConfig.SemItem_RelationType_contains.GUID, _
                                            objSemItem_ProcessLog.GUID)
        
        boolDone = True
    End Sub

    Private Sub set_DBConnection()
        procA_Logentries_Of_ProcessLog.Connection = objLocalConfig.Connection_Plugin

        strConnectionString_DB = objLocalConfig.Connection_DB.ConnectionString
        strConnectionString_Module = objLocalConfig.Connection_Plugin.ConnectionString
    End Sub

    Private Sub Timer_History_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_History.Tick
        If boolDone = False Then
            ToolStripProgressBar_History.Value = 5
        Else
            BindingSource_History.DataSource = procT_Logentries_Of_ProcessLog
            DataGridView_History.DataSource = BindingSource_History
            DataGridView_History.Columns(0).Visible = False
            DataGridView_History.Columns(1).Visible = False
            DataGridView_History.Columns(2).Visible = False
            DataGridView_History.Columns(3).Visible = False
            DataGridView_History.Columns(5).Visible = False
            DataGridView_History.Columns(7).Visible = False
            DataGridView_History.Columns(8).Visible = False
            DataGridView_History.Columns(9).Width = 300
            ToolStripProgressBar_History.Value = 0
            Timer_History.Stop()
        End If
    End Sub

    Private Sub DataGridView_History_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView_History.MouseDoubleClick
        Dim objSemItem_LogEntry As New clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        If DataGridView_History.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_History.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_LogEntry.GUID = objDRV_Selected.Item("GUID_LogEntry")
            objSemItem_LogEntry.Name = objDRV_Selected.Item("Name_LogEntry")
            objSemItem_LogEntry.GUID_Parent = objLocalConfig.SemItem_Type_LogEntry.GUID
            objSemItem_LogEntry.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objFrm_TokenEdit = New frmTokenEdit(objSemItem_LogEntry, objLocalConfig.Globals)
            objFrm_TokenEdit.ShowDialog(Me)
            initialize_History(objSemItem_ProcessLog)

        End If

    End Sub
End Class
