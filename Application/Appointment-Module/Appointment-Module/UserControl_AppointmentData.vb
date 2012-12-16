Imports Sem_Manager
Imports Partner_Manager
Public Class UserControl_AppointmentData
    Private objLocalConfig As clsLocalConfig

    Private objSemItem_Contractor As New clsSemItem
    Private objSemItem_Contractee As New clsSemItem
    Private objSemItem_Watcher As New clsSemItem

    Private objTransaction_Appointment As clsTransaction_Appointment

    Private objFRMSemManager As frmSemManager
    Private objDLGAttribute_Datetime As dlgAttribute_Datetime

    Private objSemItem_Appointment As New clsSemItem
    Private objDRC_Start As DataRowCollection
    Private objDRC_End As DataRowCollection
    Private objDRC_User As DataRowCollection
    Private semtblA_User As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_User As New ds_SemDB.semtbl_TokenDataTable
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_DateTime As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private procA_Partner_belonging As New ds_AppointmentModuleTableAdapters.proc_Partner_belongingTableAdapter
    Private procT_Partner_belonging As New ds_AppointmentModule.proc_Partner_belongingDataTable
    Private procA_Resource_Of_Appointment As New ds_AppointmentModuleTableAdapters.proc_Resource_Of_AppointmentTableAdapter
    Private procT_Resource_Of_Appointment As New ds_AppointmentModule.proc_Resource_Of_AppointmentDataTable
 
    Private WithEvents objUserControl_Partners As New UserControl_SemItemList
    Private WithEvents objUserControl_Address As New UserControl_SemItemList
    Private WithEvents objUserControl_Locations As New UserControl_SemItemList
    Private WithEvents objUserControl_Rooms As New UserControl_SemItemList

    Private objUserControl_AddressData As UserControl_Adress

    Private objTransaction_Resource As clsTransaction_Resources

    Private Sub selected_Address() Handles objUserControl_Address.Selection_Changed
        If objUserControl_Address.DataGridViewRowCollection_Selected.Count > 0 Then
            ToolStripButton_Add_Resource1.Enabled = True
        Else
            ToolStripButton_Add_Resource1.Enabled = False
        End If
    End Sub

    Private Sub selected_Location() Handles objUserControl_Locations.Selection_Changed
        If objUserControl_Locations.DataGridViewRowCollection_Selected.Count > 0 Then
            ToolStripButton_Add_Resource1.Enabled = True
        Else
            ToolStripButton_Add_Resource1.Enabled = False
        End If
    End Sub

    Private Sub selected_Rooms() Handles objUserControl_Rooms.Selection_Changed
        If objUserControl_Rooms.DataGridViewRowCollection_Selected.Count > 0 Then
            ToolStripButton_Add_Resource1.Enabled = True
        Else
            ToolStripButton_Add_Resource1.Enabled = False
        End If
    End Sub
    Private Sub selected_Contractors() Handles objUserControl_Partners.Selection_Changed
        If objUserControl_Partners.DataGridViewRowCollection_Selected.Count > 0 Then
            ToolStripButton_AddContractor.Enabled = True
            ToolStripButton_AddContractee.Enabled = True
            ToolStripButton_AddWatcher.Enabled = True
        Else
            ToolStripButton_AddContractor.Enabled = False
            ToolStripButton_AddContractee.Enabled = False
            ToolStripButton_AddWatcher.Enabled = False
        End If
    End Sub



    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        initialize()
    End Sub
    Private Sub get_BaseData_User()
        ToolStripComboBox_User.Enabled = False
        semtblA_User.Fill_Token_TypeChilds(semtblT_User, objLocalConfig.SemItem_type_User.GUID)
    End Sub
    Private Sub get_Data_User()
        objDRC_User = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Appointment.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                    objLocalConfig.SemItem_type_User.GUID).Rows
    End Sub

    Private Sub set_User()

        If objDRC_User.Count > 0 Then
            ToolStripComboBox_User.Enabled = False
            ToolStripComboBox_User.SelectedIndex = 0
            ToolStripComboBox_User.ComboBox.SelectedValue = objDRC_User(0).Item("GUID_Token_Right")
            ToolStripComboBox_User.Enabled = True
        Else
            clear_Controls()
        End If
    End Sub

    Private Sub get_Data_Start()
        objDRC_Start = funcA_TokenAttribute_DateTime.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Appointment.GUID, _
                                                                                            objLocalConfig.SemItem_Attribute_Start.GUID).Rows

    End Sub

    Private Sub configure_TabPages()
        objUserControl_Rooms.clear_List()
        objUserControl_Locations.clear_List()
        objUserControl_Address.clear_List()

        ToolStripButton_Add_Resource1.Enabled = False

        Select Case TabControl2.SelectedTab.Name
            Case TabPage_Address.Name
                objUserControl_Address.initialize_Simple(objLocalConfig.SemItem_Type_Address, objLocalConfig.Globals)
            Case TabPage_Location.Name
                objUserControl_Locations.initialize_Simple(objLocalConfig.SemItem_Type_Ort, objLocalConfig.Globals)
            Case TabPage_Room.Name
                objUserControl_Rooms.initialize_Simple(objLocalConfig.SemItem_Type_Raum, objLocalConfig.Globals)
        End Select
    End Sub

    Private Sub set_Start()
        If objDRC_Start.Count > 0 Then
            ToolStripTextBox_Start.ReadOnly = True
            ToolStripTextBox_Start.Text = objDRC_Start(0).Item("Val_Datetime")
            ToolStripTextBox_Start.ReadOnly = False

        Else
            clear_Controls()
        End If
    End Sub

    Private Sub get_Data_End()
        objDRC_End = funcA_TokenAttribute_DateTime.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Appointment.GUID, _
                                                                                          objLocalConfig.SemItem_Attribute_Ende.GUID).Rows
    End Sub

    Private Sub set_End()
        ToolStripTextBox_End.ReadOnly = True
        ToolStripTextBox_End.Text = ""
        If objDRC_End.Count > 0 Then

            ToolStripTextBox_End.Text = objDRC_End(0).Item("Val_DateTime")

        End If
        ToolStripTextBox_End.ReadOnly = False

    End Sub

    Private Sub initialize()
        set_DBConnection()

        get_BaseData_User()
        ToolStripComboBox_User.ComboBox.DataSource = semtblT_User
        ToolStripComboBox_User.ComboBox.DisplayMember = "Name_Token"
        ToolStripComboBox_User.ComboBox.ValueMember = "GUID_Token"

        objUserControl_Partners.Dock = Windows.Forms.DockStyle.Fill
        
        objUserControl_AddressData = New UserControl_Adress(Nothing)
        SplitContainer3.Panel2.Controls.Add(objUserControl_AddressData)
        objUserControl_Partners.initialize_Simple(objLocalConfig.SemItem_Type_Partner, objLocalConfig.Globals)
        
        SplitContainer_Contractor.Panel2.Controls.Add(objUserControl_Partners)

        objUserControl_Address.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_Locations.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_Rooms.Dock = Windows.Forms.DockStyle.Fill

        TabPage_Address.Controls.Add(objUserControl_Address)
        TabPage_Location.Controls.Add(objUserControl_Locations)
        TabPage_Room.Controls.Add(objUserControl_Rooms)

    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        semtblA_User.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_DateTime.Connection = objLocalConfig.Connection_DB
        procA_Partner_belonging.Connection = objLocalConfig.Connection_Plugin
        procA_Resource_Of_Appointment.Connection = objLocalConfig.Connection_Plugin

        objTransaction_Appointment = New clsTransaction_Appointment(objLocalConfig)
        objTransaction_Resource = New clsTransaction_Resources(objLocalConfig)
    End Sub
    Public Sub initialize_Data(ByVal SemItem_Appointment As clsSemItem)
        objSemItem_Appointment = SemItem_Appointment
        clear_Controls()
        configure_TabPages()
        If Not objSemItem_Appointment Is Nothing Then



            ToolStripButton_AddResource.Enabled = True

            objSemItem_Contractee.GUID = objSemItem_Appointment.GUID
            objSemItem_Contractee.Name = objSemItem_Appointment.Name
            objSemItem_Contractee.GUID_Parent = objSemItem_Appointment.GUID_Parent
            objSemItem_Contractee.Direction = objSemItem_Contractee.Direction_LeftRight
            objSemItem_Contractee.GUID_Related = objLocalConfig.SemItem_Type_Partner.GUID
            objSemItem_Contractee.GUID_Relation = objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID
            objSemItem_Contractee.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Contractor.GUID = objSemItem_Appointment.GUID
            objSemItem_Contractor.Name = objSemItem_Appointment.Name
            objSemItem_Contractor.GUID_Parent = objSemItem_Appointment.GUID_Parent
            objSemItem_Contractor.Direction = objSemItem_Contractor.Direction_LeftRight
            objSemItem_Contractor.GUID_Related = objLocalConfig.SemItem_Type_Partner.GUID
            objSemItem_Contractor.GUID_Relation = objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID
            objSemItem_Contractor.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Watcher.GUID = objSemItem_Appointment.GUID
            objSemItem_Watcher.Name = objSemItem_Appointment.Name
            objSemItem_Watcher.GUID_Parent = objSemItem_Appointment.GUID_Parent
            objSemItem_Watcher.Direction = objSemItem_Contractor.Direction_LeftRight
            objSemItem_Watcher.GUID_Related = objLocalConfig.SemItem_Type_Partner.GUID
            objSemItem_Watcher.GUID_Relation = objLocalConfig.SemItem_RelationType_belonging_Watchers.GUID
            objSemItem_Watcher.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            fill_PartnerList()
            fill_ResourceList()
            objUserControl_Partners.Enabled = True
            
            get_Data_User()
            get_Data_Start()
            get_Data_End()

            set_User()
            set_Start()
            set_End()

        End If
    End Sub

    Public Sub clear_Controls()
        
        objUserControl_Partners.Enabled = False

        
        ToolStripButton_AddContractee.Enabled = False
        ToolStripButton_AddContractor.Enabled = False
        ToolStripButton_AddWatcher.Enabled = False
        ToolStripButton_RemContractee.Enabled = False
        ToolStripButton_RemContractor.Enabled = False
        ToolStripButton_RemWatcher.Enabled = False
        ToolStripButton_Add_Resource1.Enabled = False
        ToolStripButton_AddResource.Enabled = False
        ToolStripButton_Rem_Resource1.Enabled = False

        ToolStripTextBox_Start.ReadOnly = True
        ToolStripTextBox_Start.Text = ""

        ToolStripTextBox_End.ReadOnly = True
        ToolStripTextBox_End.Text = ""

        ToolStripComboBox_User.Enabled = False
        ToolStripComboBox_User.Text = ""

        procT_Partner_belonging.Clear()
        procT_Resource_Of_Appointment.Clear()
    End Sub

    Private Sub ToolStripComboBox_User_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_User.SelectedIndexChanged
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_User As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        If ToolStripComboBox_User.Enabled = True Then
            objDRV_Selected = ToolStripComboBox_User.SelectedItem
            objSemItem_User.GUID = objDRV_Selected.Item("GUID_Token")
            objSemItem_User.Name = objDRV_Selected.Item("Name_Token")
            objSemItem_User.GUID_Parent = objDRV_Selected.Item("GUID_Type")
            objSemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objTransaction_Appointment.save_002_Appointment_To_User(objSemItem_User, True, objSemItem_Appointment)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                get_Data_User()
                set_User()
                MsgBox("Der User konnte nicht verknüpft werden!", MsgBoxStyle.Exclamation)
            End If
        End If
        
    End Sub

    Private Sub ToolStripButton_AddContractor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddContractor.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Partner As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        Dim intToDo As Integer
        Dim intDone As Integer

        intDone = 0
        intToDo = objUserControl_Partners.DataGridViewRowCollection_Selected.Count

        For Each objDGVR_Selected In objUserControl_Partners.DataGridViewRowCollection_Selected
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Partner.GUID Then
                objSemItem_Partner.GUID = objDRV_Selected.Item("GUID_Token")
                objSemItem_Partner.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Partner.GUID_Relation = objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID

                objSemItem_Result = objTransaction_Appointment.save_005_Appointment_To_Partner(objSemItem_Partner, objSemItem_Appointment)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If
            End If
        Next

        If intDone < intToDo Then
            MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Partner verknüpft werden!", MsgBoxStyle.Information)
        End If

        fill_PartnerList()
    End Sub

    Private Sub fill_PartnerList()

        procA_Partner_belonging.Fill(procT_Partner_belonging, _
                                     objLocalConfig.SemItem_Type_Appointment.GUID, _
                                     objLocalConfig.SemItem_Type_Partner.GUID, _
                                     objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                     objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                     objLocalConfig.SemItem_RelationType_belonging_Watchers.GUID, _
                                     objSemItem_Appointment.GUID)

        BindingSource_Partners.DataSource = procT_Partner_belonging
        DataGridView_Partner.DataSource = BindingSource_Partners

        DataGridView_Partner.Columns(0).Visible = False
        DataGridView_Partner.Columns(1).Visible = False
        DataGridView_Partner.Columns(2).Visible = False
        DataGridView_Partner.Columns(3).Width = 120
        DataGridView_Partner.Columns(4).Visible = False
        DataGridView_Partner.Columns(5).Visible = False
        DataGridView_Partner.Columns(6).Width = 300
        DataGridView_Partner.Columns(7).Visible = False
    End Sub

    Private Sub fill_ResourceList()
        procA_Resource_Of_Appointment.Fill(procT_Resource_Of_Appointment, _
                                           objLocalConfig.SemItem_Type_Address.GUID, _
                                           objLocalConfig.SemItem_Type_Raum.GUID, _
                                           objLocalConfig.SemItem_Type_Ort.GUID, _
                                           objLocalConfig.SemItem_RelationType_located_at.GUID, _
                                           objSemItem_Appointment.GUID)

        BindingSource_Resource.DataSource = procT_Resource_Of_Appointment
        DataGridView_Resources.DataSource = BindingSource_Resource

        DataGridView_Resources.Columns(0).Visible = False
        DataGridView_Resources.Columns(2).Visible = False
        DataGridView_Resources.Columns(3).Visible = False
        DataGridView_Resources.Columns(5).Visible = False
    End Sub

    Private Sub ToolStripButton_RemContractor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_RemContractor.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Partner As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        If DataGridView_Partner.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Partner.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            If objDRV_Selected.Item("GUID_RelationType") = objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID Then
                objSemItem_Partner.GUID = objDRV_Selected.Item("GUID_Partner")
                objSemItem_Partner.Name = objDRV_Selected.Item("Name_Partner")
                objSemItem_Partner.GUID_Parent = objDRV_Selected.Item("GUID_Type_Partner")
                objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Partner.GUID_Relation = objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID

                objSemItem_Result = objTransaction_Appointment.del_005_Appointment_To_Partner(objSemItem_Partner, objSemItem_Appointment)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Der Partner konnte nicht entfernt werden!", MsgBoxStyle.Exclamation)
                Else
                    fill_PartnerList()
                End If
            End If
        End If

    End Sub

    Private Sub ToolStripButton_AddContractee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddContractee.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Partner As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        Dim intToDo As Integer
        Dim intDone As Integer

        intDone = 0
        intToDo = objUserControl_Partners.DataGridViewRowCollection_Selected.Count

        For Each objDGVR_Selected In objUserControl_Partners.DataGridViewRowCollection_Selected
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Partner.GUID Then
                objSemItem_Partner.GUID = objDRV_Selected.Item("GUID_Token")
                objSemItem_Partner.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Partner.GUID_Relation = objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID

                objSemItem_Result = objTransaction_Appointment.save_005_Appointment_To_Partner(objSemItem_Partner, objSemItem_Appointment)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If
            End If
        Next

        If intDone < intToDo Then
            MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Partner verknüpft werden!", MsgBoxStyle.Information)
        End If

        fill_PartnerList()
    End Sub

    Private Sub ToolStripButton_RemContractee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_RemContractee.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Partner As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        If DataGridView_Partner.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Partner.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            If objDRV_Selected.Item("GUID_RelationType") = objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID Then
                objSemItem_Partner.GUID = objDRV_Selected.Item("GUID_Partner")
                objSemItem_Partner.Name = objDRV_Selected.Item("Name_Partner")
                objSemItem_Partner.GUID_Parent = objDRV_Selected.Item("GUID_Type_Partner")
                objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Partner.GUID_Relation = objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID

                objSemItem_Result = objTransaction_Appointment.del_005_Appointment_To_Partner(objSemItem_Partner, objSemItem_Appointment)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Der Partner konnte nicht entfernt werden!", MsgBoxStyle.Exclamation)
                Else
                    fill_PartnerList()
                End If
            End If
        End If



    End Sub

    Private Sub ToolStripButton_AddWatcher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddWatcher.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Partner As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        Dim intToDo As Integer
        Dim intDone As Integer

        intDone = 0
        intToDo = objUserControl_Partners.DataGridViewRowCollection_Selected.Count

        For Each objDGVR_Selected In objUserControl_Partners.DataGridViewRowCollection_Selected
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Partner.GUID Then
                objSemItem_Partner.GUID = objDRV_Selected.Item("GUID_Token")
                objSemItem_Partner.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Partner.GUID_Relation = objLocalConfig.SemItem_RelationType_belonging_Watchers.GUID

                objSemItem_Result = objTransaction_Appointment.save_005_Appointment_To_Partner(objSemItem_Partner, objSemItem_Appointment)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If
            End If
        Next

        If intDone < intToDo Then
            MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Partner verknüpft werden!", MsgBoxStyle.Information)
        End If

        fill_PartnerList()
    End Sub

    Private Sub ToolStripButton_RemWatcher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_RemWatcher.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Partner As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        If DataGridView_Partner.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Partner.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            If objDRV_Selected.Item("GUID_RelationType") = objLocalConfig.SemItem_RelationType_belonging_Watchers.GUID Then
                objSemItem_Partner.GUID = objDRV_Selected.Item("GUID_Partner")
                objSemItem_Partner.Name = objDRV_Selected.Item("Name_Partner")
                objSemItem_Partner.GUID_Parent = objDRV_Selected.Item("GUID_Type_Partner")
                objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Partner.GUID_Relation = objLocalConfig.SemItem_RelationType_belonging_Watchers.GUID

                objSemItem_Result = objTransaction_Appointment.del_005_Appointment_To_Partner(objSemItem_Partner, objSemItem_Appointment)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Der Partner konnte nicht entfernt werden!", MsgBoxStyle.Exclamation)
                Else
                    fill_PartnerList()
                End If
            End If
        End If

    End Sub

    Private Sub ToolStripTextBox_Start_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Start.DoubleClick
        Dim dateStart As Date

        If ToolStripTextBox_Start.ReadOnly = False Then
            If Date.TryParse(ToolStripTextBox_Start.Text, dateStart) Then
                objDLGAttribute_Datetime = New dlgAttribute_Datetime("Start:", objLocalConfig.Globals, dateStart)
            Else
                objDLGAttribute_Datetime = New dlgAttribute_Datetime("Start:", objLocalConfig.Globals, Now)
            End If

            objDLGAttribute_Datetime.ShowDialog(Me)
            If objDLGAttribute_Datetime.DialogResult = Windows.Forms.DialogResult.OK Then

                ToolStripTextBox_Start.Text = objDLGAttribute_Datetime.Value

            End If
        End If
        
    End Sub

    Private Sub ToolStripTextBox_Start_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Start.TextChanged
        Dim dateStart As Date
        Dim objSemItem_Result As clsSemItem

        If ToolStripTextBox_Start.ReadOnly = False Then
            If Date.TryParse(ToolStripTextBox_Start.Text, dateStart) Then
                objSemItem_Result = objTransaction_Appointment.save_003_Appointment__Start(dateStart, objSemItem_Appointment)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Das Datum kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    get_Data_Start()
                    set_Start()
                End If
            End If
        End If
        
    End Sub

    Private Sub ToolStripTextBox_End_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_End.DoubleClick
        Dim dateEnd As Date

        If ToolStripTextBox_End.ReadOnly = False Then
            If Date.TryParse(ToolStripTextBox_End.Text, dateEnd) Then
                objDLGAttribute_Datetime = New dlgAttribute_Datetime("End:", objLocalConfig.Globals, dateEnd)
            Else
                objDLGAttribute_Datetime = New dlgAttribute_Datetime("End:", objLocalConfig.Globals, Now)
            End If

            objDLGAttribute_Datetime.ShowDialog(Me)
            If objDLGAttribute_Datetime.DialogResult = Windows.Forms.DialogResult.OK Then

                ToolStripTextBox_End.Text = objDLGAttribute_Datetime.Value

            End If
        End If
        
    End Sub

    Private Sub ToolStripTextBox_End_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_End.TextChanged
        Dim dateEnd As Date
        Dim objSemItem_Result As clsSemItem

        If ToolStripTextBox_End.ReadOnly = False Then
            If Date.TryParse(ToolStripTextBox_End.Text, dateEnd) Then
                objSemItem_Result = objTransaction_Appointment.save_004_Appointment__End(dateEnd, objSemItem_Appointment)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Das Datum kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    get_Data_End()
                    set_End()
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView_Partner_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Partner.SelectionChanged
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        ToolStripButton_RemContractor.Enabled = False
        ToolStripButton_RemContractee.Enabled = False
        ToolStripButton_RemWatcher.Enabled = False

        If DataGridView_Partner.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Partner.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            Select Case objDRV_Selected.Item("GUID_RelationType")
                Case objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID
                    ToolStripButton_RemContractee.Enabled = True
                Case objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID
                    ToolStripButton_RemContractor.Enabled = True
                Case objLocalConfig.SemItem_RelationType_belonging_Watchers.GUID
                    ToolStripButton_RemWatcher.Enabled = True
            End Select
        End If
        

    End Sub

    Private Sub DataGridView_Resources_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Resources.SelectionChanged
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Address As New clsSemItem

        ToolStripButton_Rem_Resource1.Enabled = False

        If DataGridView_Resources.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Resources.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            ToolStripButton_Rem_Resource1.Enabled = True


            If objDRV_Selected.Item("GUID_Type_Resource") = objLocalConfig.SemItem_Type_Address.GUID Then
                objSemItem_Address.GUID = objDRV_Selected.Item("GUID_Resource")
                objSemItem_Address.Name = objDRV_Selected.Item("Name_Resource")
                objSemItem_Address.GUID_Parent = objLocalConfig.SemItem_Type_Address.GUID
                objSemItem_Address.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objUserControl_AddressData = New UserControl_Adress(objSemItem_Address)
                objUserControl_AddressData.Dock = Windows.Forms.DockStyle.Fill
                SplitContainer3.Panel2.Controls.Clear()
                SplitContainer3.Panel2.Controls.Add(objUserControl_AddressData)
            End If
        Else
            objUserControl_AddressData = New UserControl_Adress(Nothing)
            SplitContainer3.Panel2.Controls.Clear()
            SplitContainer3.Panel2.Controls.Add(objUserControl_AddressData)
        End If
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl2.SelectedIndexChanged
        configure_TabPages()
    End Sub

    Private Sub ToolStripButton_Rem_Resource1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Rem_Resource1.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Resource As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intToDo As Integer
        Dim intDone As Integer

        intDone = 0
        intToDo = DataGridView_Resources.SelectedRows.Count
        For Each objDGVR_Selected In DataGridView_Resources.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            If objDRV_Selected.Item("OR") = 1 Then
                objSemItem_Resource.GUID = objDRV_Selected.Item("GUID_Resource")
                objSemItem_Resource.GUID_Type = objDRV_Selected.Item("GUID_Type_Resource")
                objSemItem_Result = objTransaction_Resource.del_002_Appointment_To_ORResource(objSemItem_Appointment, _
                                                                                              objSemItem_Resource)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If
            Else
                objSemItem_Resource.GUID = objDRV_Selected.Item("GUID_Resource")
                objSemItem_Resource.Name = objDRV_Selected.Item("Name_Resource")
                objSemItem_Resource.GUID_Parent = objDRV_Selected.Item("GUID_Type_Resource")
                objSemItem_Resource.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_Resource.del_001_Appointment_To_SimpleResource(objSemItem_Appointment, _
                                                                                                  objSemItem_Resource)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If
            End If
        Next

        If intDone < intToDo Then
            MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Resourcen entfernt werden!", MsgBoxStyle.Exclamation)
        End If

        fill_ResourceList()
    End Sub

    Private Sub ToolStripButton_Add_Resource1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Add_Resource1.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Resource As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intToDo As Integer
        Dim intDone As Integer

        intDone = 0

        Select Case TabControl2.SelectedTab.Name
            Case TabPage_Address.Name
                If objUserControl_Address.DataGridViewRowCollection_Selected.Count > 0 Then
                    intToDo = objUserControl_Address.DataGridViewRowCollection_Selected.Count
                    For Each objDGVR_Selected In objUserControl_Address.DataGridViewRowCollection_Selected
                        objDRV_Selected = objDGVR_Selected.DataBoundItem

                        objSemItem_Resource.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Resource.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Resource.GUID_Parent = objLocalConfig.SemItem_Type_Address.GUID
                        objSemItem_Resource.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_Resource.save_001_Appointment_To_SimpleResource(objSemItem_Appointment, _
                                                                                                           objSemItem_Resource)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intDone = intDone + 1
                        End If
                    Next

                End If

                If intDone < intToDo Then
                    MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Resourcen entfernt werden!", MsgBoxStyle.Exclamation)
                End If
            Case TabPage_Location.Name
                If objUserControl_Locations.DataGridViewRowCollection_Selected.Count > 0 Then
                    intToDo = objUserControl_Locations.DataGridViewRowCollection_Selected.Count
                    For Each objDGVR_Selected In objUserControl_Locations.DataGridViewRowCollection_Selected
                        objDRV_Selected = objDGVR_Selected.DataBoundItem

                        objSemItem_Resource.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Resource.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Resource.GUID_Parent = objLocalConfig.SemItem_Type_Ort.GUID
                        objSemItem_Resource.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_Resource.save_001_Appointment_To_SimpleResource(objSemItem_Appointment, _
                                                                                                           objSemItem_Resource)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intDone = intDone + 1
                        End If
                    Next
                End If

                If intDone < intToDo Then
                    MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Resourcen entfernt werden!", MsgBoxStyle.Exclamation)
                End If
            Case TabPage_Room.Name
                If objUserControl_Rooms.DataGridViewRowCollection_Selected.Count > 0 Then
                    intToDo = objUserControl_Rooms.DataGridViewRowCollection_Selected.Count
                    For Each objDGVR_Selected In objUserControl_Rooms.DataGridViewRowCollection_Selected
                        objDRV_Selected = objDGVR_Selected.DataBoundItem

                        objSemItem_Resource.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Resource.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Resource.GUID_Parent = objLocalConfig.SemItem_Type_Raum.GUID
                        objSemItem_Resource.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_Resource.save_001_Appointment_To_SimpleResource(objSemItem_Appointment, _
                                                                                                           objSemItem_Resource)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intDone = intDone + 1
                        End If
                    Next
                End If

                If intDone < intToDo Then
                    MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Resourcen entfernt werden!", MsgBoxStyle.Exclamation)
                End If
        End Select

        fill_ResourceList()
    End Sub

    Private Sub ToolStripButton_AddResource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddResource.Click
        Dim objSemItem_Result As clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim intDone As Integer
        Dim intToDo As Integer


        intDone = 0
        objFRMSemManager = New frmSemManager(objLocalConfig.Globals)
        objFRMSemManager.Applyabale = True
        objFRMSemManager.ShowDialog(Me)
        If objFRMSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            Select Case objFRMSemManager.SelectedItems_TypeGUID
                Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                    intToDo = objFRMSemManager.SelectedRows_Items.Count
                    For Each objDGVR_Selected In objFRMSemManager.SelectedRows_Items
                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                        objSemItem_Result = New clsSemItem
                        objSemItem_Result.GUID = objDRV_Selected.Item("GUID_Attribute")
                        objSemItem_Result.Name = objDRV_Selected.Item("Name_Attribute")
                        objSemItem_Result.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                        objSemItem_Result = objTransaction_Resource.save_002_Appointment_To_ORResource(objSemItem_Appointment, objSemItem_Result)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intDone = intDone + 1
                        End If
                    Next
                Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                    intToDo = objFRMSemManager.SelectedRows_Items.Count
                    For Each objDGVR_Selected In objFRMSemManager.SelectedRows_Items
                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                        objSemItem_Result = New clsSemItem
                        objSemItem_Result.GUID = objDRV_Selected.Item("GUID_RelationType")
                        objSemItem_Result.Name = objDRV_Selected.Item("Name_RelationType")
                        objSemItem_Result.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

                        objSemItem_Result = objTransaction_Resource.save_002_Appointment_To_ORResource(objSemItem_Appointment, objSemItem_Result)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intDone = intDone + 1
                        End If
                    Next
                Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    intToDo = objFRMSemManager.SelectedRows_Items.Count
                    For Each objDGVR_Selected In objFRMSemManager.SelectedRows_Items
                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                        objSemItem_Result = New clsSemItem
                        objSemItem_Result.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Result.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Result.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_Resource.save_002_Appointment_To_ORResource(objSemItem_Appointment, objSemItem_Result)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intDone = intDone + 1
                        End If
                    Next
                Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                    intToDo = objFRMSemManager.SemItems_Selected.Count
                    For Each objSemItem_Result In objFRMSemManager.SemItems_Selected
                        objSemItem_Result = objTransaction_Resource.save_002_Appointment_To_ORResource(objSemItem_Appointment, objSemItem_Result)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intDone = intDone + 1
                        End If
                    Next
            End Select
        End If

        If intDone < intToDo Then
            MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Resourcen verknüpft werden!", MsgBoxStyle.Information)
        End If

        fill_ResourceList()
    End Sub
End Class
