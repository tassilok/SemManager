Imports Sem_Manager
Imports Process_Module
Public Class UserControl_TicketList

    Private chngviewA_TicketList As New ds_ChangeModuleTableAdapters.chngview_TicketListTableAdapter
    Private chngviewT_TicketList As New ds_ChangeModule.chngview_TicketListDataTable
    Private chngviewA_TicketList_TicketList As New ds_ChangeModuleTableAdapters.chngview_TicketList_TicketListsTableAdapter
    Private chngviewT_TicketList_TicketList As New ds_ChangeModule.chngview_TicketList_TicketListsDataTable

    Private objTransaction_Ticket As clsTransaction_Ticket

    Private objFrmChangeModule As frmChangeModule
    Private objTicketWork As clsTicketWork
    Private objFrm_TokenEdit As frmTokenEdit
    Private objDLG_Attribute_Int As dlgAttribute_Int

    Private objLocalConfig As clsLocalConfig

    Private objSemItem_TicketList As clsSemItem
    Private objSemItems_Tickets() As clsSemItem
    Private boolRefresh As Boolean

    Private dateStart As Date
    Private dateEnd As Date
    Private boolAll As Boolean

    Public Event selected_Ticket(ByVal objDGVSRC As DataGridViewSelectedRowCollection)
    Public Event refreshed_Tickets()
    Public Event related_Ticket()

    Public Sub relatedTree()
        ToolStripButton_TicketRel.Enabled = True
    End Sub
    Public ReadOnly Property SemItems_Tickets As clsSemItem()
        Get
            Return objSemItems_Tickets
        End Get
    End Property

    Public Property doRefresh As Boolean
        Get
            Return boolRefresh
        End Get
        Set(ByVal value As Boolean)
            boolRefresh = value
        End Set
    End Property

    Public Property All As Boolean
        Get
            Return boolAll
        End Get
        Set(ByVal value As Boolean)
            boolAll = value
            refresh_TicketList(objSemItem_TicketList)
        End Set
    End Property

    
    Public Sub refresh_TicketList(Optional ByVal SemItem_TicketList As clsSemItem = Nothing)

        ToolStripButton_TicketRel.Enabled = False
        If objSemItem_TicketList Is Nothing Then
            objSemItem_TicketList = SemItem_TicketList
            boolRefresh = True
            get_TicketList()
            configure_DataGridView()
        Else
            If Not SemItem_TicketList Is Nothing Then

                objSemItem_TicketList = SemItem_TicketList
                If objSemItem_TicketList.GUID = objLocalConfig.SemItem_Token_Process_Ticket_Lists_All.GUID Then
                    boolRefresh = True
                Else
                    If objSemItem_TicketList.GUID = objLocalConfig.SemItem_Token_Process_Ticket_Lists_All.GUID Then
                        boolRefresh = True
                    Else
                        boolRefresh = False

                    End If
                End If

                get_TicketList()
                configure_DataGridView()

            Else
                DataGridView_Tickets.DataSource = Nothing
                boolRefresh = True
            End If
        End If


    End Sub

    Public Property applyable As Boolean
        Get
            Return ApplyToolStripMenuItem.Visible
        End Get
        Set(ByVal value As Boolean)
            ApplyToolStripMenuItem.Visible = value
        End Set
    End Property

    Private Sub initialize()
        set_DBConnection()

    End Sub

    Private Sub configure_DataGridView()


        DataGridView_Tickets.DataSource = BindingSource_Tickets
        If DataGridView_Tickets.Columns.Count <= 24 Then
            BindingSource_Tickets.Sort = "ID"
            DataGridView_Tickets.Columns(0).Visible = False
            DataGridView_Tickets.Columns(1).Visible = True
            DataGridView_Tickets.Columns(1).Width = 300
            DataGridView_Tickets.Columns(2).Visible = False
            DataGridView_Tickets.Columns(5).Visible = False
            DataGridView_Tickets.Columns(6).Visible = True
            DataGridView_Tickets.Columns(6).Width = 300
            DataGridView_Tickets.Columns(7).Visible = False
            DataGridView_Tickets.Columns(8).Visible = True
            DataGridView_Tickets.Columns(8).Width = 300
            DataGridView_Tickets.Columns(9).Visible = False
            DataGridView_Tickets.Columns(10).Visible = False
            DataGridView_Tickets.Columns(12).Visible = False
            DataGridView_Tickets.Columns(13).Visible = False

            DataGridView_Tickets.Columns(16).Visible = False
            DataGridView_Tickets.Columns(18).Visible = False
            DataGridView_Tickets.Columns(19).Visible = True
            DataGridView_Tickets.Columns(20).Visible = False
            DataGridView_Tickets.Columns(21).Visible = False
            DataGridView_Tickets.Columns(22).Visible = False

        Else
            BindingSource_Tickets.Sort = ""

            DataGridView_Tickets.Columns(0).Visible = False
            DataGridView_Tickets.Columns(1).Visible = True
            DataGridView_Tickets.Columns(1).Width = 300
            DataGridView_Tickets.Columns(2).Visible = True
            DataGridView_Tickets.Columns(2).Width = 100
            DataGridView_Tickets.Columns(3).Visible = True
            DataGridView_Tickets.Columns(3).Width = 100
            DataGridView_Tickets.Columns(4).Visible = False
            DataGridView_Tickets.Columns(5).Visible = False
            DataGridView_Tickets.Columns(6).Visible = False
            DataGridView_Tickets.Columns(7).Visible = True
            DataGridView_Tickets.Columns(7).Width = 300
            DataGridView_Tickets.Columns(8).Visible = False
            DataGridView_Tickets.Columns(9).Visible = True
            DataGridView_Tickets.Columns(9).Width = 300
            DataGridView_Tickets.Columns(10).Visible = False
            DataGridView_Tickets.Columns(11).Visible = False
            DataGridView_Tickets.Columns(12).Visible = False
            DataGridView_Tickets.Columns(13).Visible = False
            DataGridView_Tickets.Columns(14).Visible = False
            DataGridView_Tickets.Columns(15).Visible = False
            DataGridView_Tickets.Columns(16).Visible = True
            DataGridView_Tickets.Columns(16).Width = 300
            DataGridView_Tickets.Columns(17).Visible = False
            DataGridView_Tickets.Columns(18).Visible = True
            DataGridView_Tickets.Columns(18).Width = 200
            DataGridView_Tickets.Columns(19).Visible = False
            DataGridView_Tickets.Columns(20).Visible = True
            DataGridView_Tickets.Columns(20).Width = 200
            DataGridView_Tickets.Columns(21).Visible = False
            DataGridView_Tickets.Columns(22).Visible = False
            DataGridView_Tickets.Columns(23).Visible = False
            DataGridView_Tickets.Columns(24).Visible = False
            DataGridView_Tickets.Columns(25).Visible = False
        End If

        
    End Sub

    Private Sub get_TicketList()
        Dim dateStart As Date
        Dim dateEnd As Date
        Dim strFilter_Finished As String

        If objSemItem_TicketList Is Nothing Then
            boolRefresh = True
            objSemItem_TicketList = objLocalConfig.SemItem_Token_Process_Ticket_Lists_Open

        End If

        If boolAll = True Then
            strFilter_Finished = ""
        Else
            strFilter_Finished = "GUID_LogState_Finished IS NULL"
        End If

        BindingSource_Tickets.RemoveFilter()

        Select Case objSemItem_TicketList.GUID
            Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_ProcessTicketList.GUID
                If boolRefresh = True Then
                    get_Tickets()
                End If

                BindingSource_Tickets.DataSource = chngviewT_TicketList

                BindingSource_Tickets.Filter = strFilter_Finished

            Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_Selected_Date_Range.GUID

                If boolRefresh = True Then
                    get_Tickets()
                End If

                BindingSource_Tickets.DataSource = chngviewT_TicketList

                If Date.TryParse(objSemItem_TicketList.Additional1, dateStart) Then
                    If Date.TryParse(objSemItem_TicketList.Additional2, dateEnd) Then
                        If strFilter_Finished <> "" Then
                            strFilter_Finished = strFilter_Finished & " AND "
                        End If
                        strFilter_Finished = strFilter_Finished & "DateTime_TimeStamp>'" & objSemItem_TicketList.Additional1 & "' AND DateTime_TimeStamp<'" & objSemItem_TicketList.Additional2 & "'"
                        BindingSource_Tickets.Filter = strFilter_Finished
                    Else
                        BindingSource_Tickets.RemoveFilter()
                    End If
                Else
                    BindingSource_Tickets.RemoveFilter()
                End If
                

            Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Day.GUID
                If boolRefresh = True Then
                    get_Tickets()
                End If
                BindingSource_Tickets.DataSource = chngviewT_TicketList

                dateStart = Now
                dateEnd = dateStart

                If Date.TryParse(dateStart.Date & " 00:00:00", dateStart) Then
                    If Date.TryParse(dateEnd.Date & " 23:59:00", dateEnd) Then
                        If strFilter_Finished <> "" Then
                            strFilter_Finished = strFilter_Finished & " AND "
                        End If

                        strFilter_Finished = strFilter_Finished & "DateTime_TimeStamp>'" & dateStart & "' AND DateTime_TimeStamp<'" & dateEnd & "'"
                        BindingSource_Tickets.Filter = strFilter_Finished
                    Else
                        BindingSource_Tickets.RemoveFilter()
                    End If
                Else
                    BindingSource_Tickets.RemoveFilter()
                End If
                
            Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Month.GUID
                If boolRefresh = True Then
                    get_Tickets()
                End If
                BindingSource_Tickets.DataSource = chngviewT_TicketList

                dateStart = Now
                dateEnd = dateStart

                If Date.TryParse("01." & dateStart.Month & "." & dateStart.Year & " 00:00:00", dateStart) Then
                    If Date.TryParse(Date.DaysInMonth(dateEnd.Year, dateEnd.Month) & "." & dateEnd.Month & "." & dateEnd.Day & " 23:59:00", dateEnd) Then
                        If strFilter_Finished <> "" Then
                            strFilter_Finished = strFilter_Finished & " AND "
                        End If

                        strFilter_Finished = strFilter_Finished & "DateTime_TimeStamp>'" & dateStart & "' AND DateTime_TimeStamp<'" & dateEnd & "'"
                        BindingSource_Tickets.Filter = strFilter_Finished
                    Else
                        BindingSource_Tickets.RemoveFilter()
                    End If
                Else
                    BindingSource_Tickets.RemoveFilter()
                End If
            Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Week.GUID
                If boolRefresh = True Then
                    get_Tickets()
                End If

                dateStart = Now
                dateEnd = dateStart
                
                BindingSource_Tickets.DataSource = chngviewT_TicketList
                If Date.TryParse(DateAdd(DateInterval.Day, ((7 - dateStart.DayOfWeek) - 1) * -1, dateStart).Date & " 00:00:00", dateStart) Then
                    If Date.TryParse(DateAdd(DateInterval.Day, (7 - dateStart.DayOfWeek), dateStart).Date & " 23:59:00", dateEnd) Then
                        If strFilter_Finished <> "" Then
                            strFilter_Finished = strFilter_Finished & " AND "
                        End If

                        strFilter_Finished = strFilter_Finished & "DateTime_TimeStamp>'" & dateStart & "' AND DateTime_TimeStamp<'" & dateEnd & "'"
                        BindingSource_Tickets.Filter = strFilter_Finished
                    Else
                        BindingSource_Tickets.RemoveFilter()
                    End If
                Else
                    BindingSource_Tickets.RemoveFilter()
                End If
            Case objLocalConfig.SemItem_Token_Process_Ticket_Lists_This_Year.GUID
                If boolRefresh = True Then
                    get_Tickets()
                End If
                BindingSource_Tickets.DataSource = chngviewT_TicketList

                dateStart = Now

                If Date.TryParse("01.01." & dateStart.Year & " 00:00:00", dateStart) Then
                    If Date.TryParse("31.12." & dateStart.Year & " 23:59:00", dateEnd) Then
                        If strFilter_Finished <> "" Then
                            strFilter_Finished = strFilter_Finished & " AND "
                        End If

                        strFilter_Finished = strFilter_Finished & "DateTime_TimeStamp>'" & dateStart & "' AND DateTime_TimeStamp<'" & dateEnd & "'"

                        BindingSource_Tickets.Filter = strFilter_Finished
                    Else
                        BindingSource_Tickets.RemoveFilter()
                    End If
                Else
                    BindingSource_Tickets.RemoveFilter()
                End If
            Case Else
                BindingSource_Tickets.RemoveFilter()
                If objSemItem_TicketList.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket_Lists.GUID Then
                    chngviewA_TicketList_TicketList.Fill(chngviewT_TicketList_TicketList)
                    BindingSource_Tickets.RemoveFilter()
                    BindingSource_Tickets.DataSource = chngviewT_TicketList_TicketList
                    If strFilter_Finished <> "" Then
                        strFilter_Finished = strFilter_Finished & " AND "
                    End If

                    strFilter_Finished = strFilter_Finished & "GUID_TicketList='" & objSemItem_TicketList.GUID.ToString & "'"

                    BindingSource_Tickets.Filter = strFilter_Finished
                End If
        End Select

    End Sub

    Public Sub get_Tickets()
        chngviewA_TicketList.create_Tables_Group(objLocalConfig.SemItem_Attribute_ID.GUID, _
                                                    objLocalConfig.SemItem_Attribute_Startdate.GUID, _
                                                    objLocalConfig.SemItem_Attribute_Datetime__To_Do_List_.GUID, _
                                                    objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                    objLocalConfig.SemItem_Attribute_Message.GUID, _
                                                    objLocalConfig.SemItem_Type_Process_Ticket.GUID, _
                                                    objLocalConfig.SemItem_Type_Group.GUID, _
                                                    objLocalConfig.SemItem_Type_Incident.GUID, _
                                                    objLocalConfig.SemItem_Type_Process_Last_Done.GUID, _
                                                    objLocalConfig.SemItem_Type_Process.GUID, _
                                                    objLocalConfig.SemItem_type_Logstate.GUID, _
                                                    objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                    objLocalConfig.SemItem_RelationType_Last_Done.GUID, _
                                                    objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                    objLocalConfig.SemItem_RelationType_provides.GUID, _
                                                    objLocalConfig.SemItem_RelationType_belonging_Done.GUID, _
                                                    objLocalConfig.SemItem_RelationType_started_with.GUID, _
                                                    objLocalConfig.SemItem_RelationType_finished_with.GUID, _
                                                    objLocalConfig.SemItem_Group.GUID)

        chngviewA_TicketList.Fill(chngviewT_TicketList, objLocalConfig.SemItem_Group.GUID)
        RaiseEvent refreshed_Tickets()
        boolRefresh = False
    End Sub

    Private Sub set_DBConnection()
        chngviewA_TicketList_TicketList.Connection = objLocalConfig.Connection_Plugin
        chngviewA_TicketList.Connection = objLocalConfig.Connection_Plugin
        objTransaction_Ticket = New clsTransaction_Ticket(objLocalConfig)
        objTicketWork = New clsTicketWork(objLocalConfig, Me)
    End Sub
    Public Sub New(Optional ByVal SemItem_TicketList As clsSemItem = Nothing)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        objSemItem_TicketList = SemItem_TicketList
        initialize()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig, Optional ByVal SemItem_TicketList As clsSemItem = Nothing)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        objSemItem_TicketList = SemItem_TicketList
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals, Optional ByVal SemItem_TicketList As clsSemItem = Nothing)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        objSemItem_TicketList = SemItem_TicketList
        initialize()
    End Sub

    Private Sub ContextMenuStrip_Tickets_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Tickets.Opening
        ApplyToolStripMenuItem.Enabled = False
        OpenToolStripMenuItem.Enabled = False
        EqualToolStripMenuItem.Enabled = False
        NotEqualToolStripMenuItem.Enabled = False
        approximateToolStripMenuItem.Enabled = False
        ContainsToolStripMenuItem.Enabled = False
        ClearToolStripMenuItem.Enabled = False
        FilterToolStripMenuItem.Enabled = False
        RelateToolStripMenuItem.Enabled = False
        If DataGridView_Tickets.SelectedRows.Count >= 0 Then
            If DataGridView_Tickets.SelectedRows.Count = 1 Then
                OpenToolStripMenuItem.Enabled = True
            End If

            RelateToolStripMenuItem.Enabled = True
            ApplyToolStripMenuItem.Enabled = True
        End If

        If Not BindingSource_Tickets.Filter = "" Then
            FilterToolStripMenuItem.Enabled = True
            ClearToolStripMenuItem.Enabled = True
        End If

        If DataGridView_Tickets.SelectedCells.Count = 1 Then
            EqualToolStripMenuItem.Enabled = True
            NotEqualToolStripMenuItem.Enabled = True
            approximateToolStripMenuItem.Enabled = True
            ContainsToolStripMenuItem.Enabled = True
            ClearToolStripMenuItem.Enabled = True
            FilterToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click

        If DataGridView_Tickets.SelectedRows.Count = 1 Then
            RaiseEvent selected_Ticket(DataGridView_Tickets.SelectedRows)
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objTicketWork.new_Ticket
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            boolRefresh = True
            get_TicketList()
        Else
            MsgBox("Beim Erzeugen des Tickets ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
        End If
        
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow

        If DataGridView_Tickets.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Tickets.SelectedRows(0)
            objFrmChangeModule = New frmChangeModule(objDGVR_Selected.Index, DataGridView_Tickets.Rows, objLocalConfig)
            objFrmChangeModule.ShowDialog(Me)
        End If
    End Sub

    Private Sub EqualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EqualToolStripMenuItem.Click
        Dim objDGVC As DataGridViewCell
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim strFilter_Finished As String

        If boolAll = True Then
            strFilter_Finished = ""
        Else
            strFilter_Finished = "GUID_LogState_Finished IS NULL"
        End If

        If DataGridView_Tickets.SelectedCells.Count = 1 Then
            objDGVC = DataGridView_Tickets.SelectedCells(0)
            objDGVR = DataGridView_Tickets.Rows(objDGVC.RowIndex)
            objDRV = objDGVR.DataBoundItem

            If Not strFilter_Finished = "" Then
                strFilter_Finished = strFilter_Finished & " AND "
            End If

            Select Case DataGridView_Tickets.Columns(objDGVC.ColumnIndex).Name
                Case "ID"
                    strFilter_Finished = strFilter_Finished & DataGridView_Tickets.Columns(objDGVC.ColumnIndex).Name & "=" & objDRV.Item(objDGVC.ColumnIndex)
                    BindingSource_Tickets.Filter = strFilter_Finished
                Case Else
                    strFilter_Finished = strFilter_Finished & DataGridView_Tickets.Columns(objDGVC.ColumnIndex).Name & "='" & objDRV.Item(objDGVC.ColumnIndex).ToString.Replace("'", "''") & "'"
                    BindingSource_Tickets.Filter = strFilter_Finished
            End Select
        End If


    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Dim strFilter_Finished As String
        If boolAll = True Then
            strFilter_Finished = ""
        Else
            strFilter_Finished = "GUID_LogState_Finished IS NULL"
        End If
        BindingSource_Tickets.Filter = strFilter_Finished
    End Sub

    Private Sub DataGridView_Tickets_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Tickets.DoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Ticket As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        If DataGridView_Tickets.SelectedCells.Count = 1 Then
            If DataGridView_Tickets.Columns(DataGridView_Tickets.SelectedCells(0).ColumnIndex).Name = "Ticket-Order" Then
                objDGVR_Selected = DataGridView_Tickets.Rows(DataGridView_Tickets.SelectedCells(0).RowIndex)
                objDRV_Selected = objDGVR_Selected.DataBoundItem

                objDLG_Attribute_Int = New dlgAttribute_Int("Ticket-Order", objLocalConfig.Globals, objDRV_Selected.Item("Ticket-Order"))
                objDLG_Attribute_Int.ShowDialog(Me)

                If objDLG_Attribute_Int.DialogResult = DialogResult.OK Then
                    objSemItem_Ticket.GUID = objDRV_Selected.Item("GUID_Ticket")
                    objSemItem_Ticket.Name = objDRV_Selected.Item("Name_Ticket")
                    objSemItem_Ticket.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket.GUID
                    objSemItem_Ticket.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_TicketList.Level = objDLG_Attribute_Int.Value

                    objSemItem_Result = objTransaction_Ticket.save_015_Ticket_To_TicketList(objSemItem_TicketList, _
                                                                        objSemItem_Ticket)

                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Die Ticket-Order konnte nicht geändert werden!", MsgBoxStyle.Information)
                    Else
                        get_Tickets()
                    End If

                End If
            End If
        End If

    End Sub

    Private Sub DataGridView_Tickets_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView_Tickets.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                get_Tickets()
        End Select
    End Sub

    Private Sub DataGridView_Tickets_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Tickets.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Ticket As New clsSemItem

        objDGVR_Selected = DataGridView_Tickets.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Ticket.GUID = objDRV_Selected.Item("GUID_Ticket")
        objSemItem_Ticket.Name = objDRV_Selected.Item("Name_Ticket")
        objSemItem_Ticket.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket.GUID
        objSemItem_Ticket.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrm_TokenEdit = New frmTokenEdit(objSemItem_Ticket, objLocalConfig.Globals)
        objFrm_TokenEdit.ShowDialog(Me)
    End Sub

    Private Sub RelateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelateToolStripMenuItem.Click
        Dim objDRV_Selected As DataRowView
        Dim i As Integer

        ReDim objSemItems_Tickets(DataGridView_Tickets.SelectedRows.Count - 1)


        For i = 0 To DataGridView_Tickets.SelectedRows.Count - 1
            objDRV_Selected = DataGridView_Tickets.SelectedRows(i).DataBoundItem
            objSemItems_Tickets(i) = New clsSemItem
            objSemItems_Tickets(i).GUID = objDRV_Selected.Item("GUID_Ticket")
            objSemItems_Tickets(i).Name = objDRV_Selected.Item("Name_Ticket")
            objSemItems_Tickets(i).GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket.GUID
            objSemItems_Tickets(i).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItems_Tickets(i).Level = objDRV_Selected.Item("ID")
        Next

        RaiseEvent related_Ticket()
    End Sub

    Private Sub ToolStripButton_TicketRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_TicketRel.Click
        If DataGridView_Tickets.Columns.Count <= 24 Then
            chngviewA_TicketList.Fill(chngviewT_TicketList, _
                                  objLocalConfig.SemItem_Group.GUID)
            BindingSource_Tickets.DataSource = chngviewT_TicketList
        Else
            chngviewA_TicketList_TicketList.Fill(chngviewT_TicketList_TicketList)
            BindingSource_Tickets.DataSource = chngviewT_TicketList_TicketList
        End If
        
        DataGridView_Tickets.DataSource = BindingSource_Tickets
        
    End Sub

    Private Sub NotEqualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotEqualToolStripMenuItem.Click

    End Sub

    Private Sub approximateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles approximateToolStripMenuItem.Click

    End Sub

    Private Sub ContainsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContainsToolStripMenuItem.Click

    End Sub
End Class
