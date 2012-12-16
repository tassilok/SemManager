Imports Sem_Manager
Public Class UserControl_Appointments
    Private procA_Appointments As New ds_AppointmentModuleTableAdapters.proc_AppointmentsTableAdapter
    Private procT_Appointments As New ds_AppointmentModule.proc_AppointmentsDataTable

    Private objUserControl_AppointMentData As UserControl_AppointmentData
    Private objTransaction_Appointment As clsTransaction_Appointment

    Private objFrmTokenEdit As frmTokenEdit


    Private objDlgAttribute_Datetime As dlgAttribute_Datetime
    Private objDlgAttribute_VARCHAR255 As dlgAttribute_Varchar255

    Private objLocalConfig As clsLocalConfig
    Private objSemItem_User As clsSemItem

    Private Sub get_Data_Appointments()
        procA_Appointments.Fill(procT_Appointments, _
                                objLocalConfig.SemItem_Attribute_Start.GUID, _
                                objLocalConfig.SemItem_Attribute_Ende.GUID, _
                                objLocalConfig.SemItem_Type_Appointment.GUID, _
                                objLocalConfig.SemItem_type_User.GUID, _
                                objSemItem_User.GUID, _
                                objLocalConfig.SemItem_RelationType_belongsTo.GUID)
        
    End Sub

    Private Sub set_Grid()
        BindingSource_Appointments.DataSource = procT_Appointments
        DataGridView_Appointments.DataSource = BindingSource_Appointments

        DataGridView_Appointments.Columns(0).Width = 0
        DataGridView_Appointments.Columns(2).Visible = False
        DataGridView_Appointments.Columns(3).Visible = False
        DataGridView_Appointments.Columns(4).Visible = False


        set_FilterAppointments()
    End Sub

    Private Sub set_FilterAppointments()
        If ToolStripButton_OnlyActive.Checked = True Then
            BindingSource_Appointments.Filter = "Start>='" & Now.ToString & "' or End>='" & Now.ToString & "'"
        Else
            BindingSource_Appointments.Filter = ""
        End If

    End Sub

    Private Sub set_DBConnection()
        procA_Appointments.Connection = objLocalConfig.Connection_Plugin
        objTransaction_Appointment = New clsTransaction_Appointment(objLocalConfig)
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        objUserControl_AppointMentData = New UserControl_AppointmentData(objLocalConfig)
        objUserControl_AppointMentData.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(objUserControl_AppointMentData)
        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
        
    End Sub

    Public Sub initalize_Appointments(ByVal SemItem_User As clsSemItem)
        objSemItem_User = SemItem_User
        get_Data_Appointments()
        set_Grid()
    End Sub

    Private Sub DataGridView_Appointments_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView_Appointments.KeyDown
        If e.KeyCode = Keys.F5 Then
            get_Data_Appointments()
        End If
    End Sub

    Private Sub DataGridView_Appointments_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Appointments.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Appointment As New clsSemItem

        objDGVR_Selected = DataGridView_Appointments.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Appointment.GUID = objDRV_Selected.Item("GUID_Appointment")
        objSemItem_Appointment.Name = objDRV_Selected.Item("Name_Appointment")
        objSemItem_Appointment.GUID_Parent = objLocalConfig.SemItem_Type_Appointment.GUID
        objSemItem_Appointment.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrmTokenEdit = New frmTokenEdit(objSemItem_Appointment, objLocalConfig.Globals)
        objFrmTokenEdit.ShowDialog(Me)
        get_Data_Appointments()
    End Sub

    Private Sub DataGridView_Appointments_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Appointments.SelectionChanged
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objSemItem_Appointment As New clsSemItem

        objUserControl_AppointMentData.clear_Controls()
        If DataGridView_Appointments.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Appointments.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_Appointment.GUID = objDRV_Selected.Item("GUID_Appointment")
            objSemItem_Appointment.Name = objDRV_Selected.Item("Name_Appointment")
            objSemItem_Appointment.GUID_Parent = objLocalConfig.SemItem_Type_Appointment.GUID
            objSemItem_Appointment.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objUserControl_AppointMentData.initialize_Data(objSemItem_Appointment)

        End If
    End Sub

    Private Sub ContextMenuStrip_Appointment_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Appointment.Opening
        RemoveToolStripMenuItem.Enabled = False

        If DataGridView_Appointments.SelectedRows.Count > 0 Then
            RemoveToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim objSemItem_Appointment As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim dateStart As Date
        objDlgAttribute_VARCHAR255 = New dlgAttribute_Varchar255("Title", objLocalConfig.Globals)
        objDlgAttribute_VARCHAR255.ShowDialog(Me)
        If objDlgAttribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then
            objSemItem_Appointment.Name = objDlgAttribute_VARCHAR255.Value1

            objDlgAttribute_Datetime = New dlgAttribute_Datetime("New Start-Date", objLocalConfig.Globals)
            objDlgAttribute_Datetime.ShowDialog(Me)
            If objDlgAttribute_Datetime.DialogResult = Windows.Forms.DialogResult.OK Then
                dateStart = objDlgAttribute_Datetime.Value
                objSemItem_Appointment.GUID = Guid.NewGuid
                objSemItem_Appointment.GUID_Parent = objLocalConfig.SemItem_Type_Appointment.GUID
                objSemItem_Appointment.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_Appointment.save_001_Appointment(objSemItem_Appointment)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_Appointment.save_002_Appointment_To_User(objLocalConfig.User)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_Appointment.save_003_Appointment__Start(dateStart)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            get_Data_Appointments()
                        Else
                            objSemItem_Result = objTransaction_Appointment.del_002_Appointment_To_User
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_Appointment.del_001_Appointment()
                            End If

                            MsgBox("Der Termin konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        objTransaction_Appointment.del_001_Appointment()
                        MsgBox("Der Termin konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)

                    End If
                Else
                    MsgBox("Der Termin konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If
            End If
        End If

    End Sub

    Private Sub ToolStripButton_OnlyActive_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton_OnlyActive.CheckStateChanged
        set_FilterAppointments()
    End Sub

End Class
