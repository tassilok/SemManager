Imports Sem_Manager
Imports OrganisationalTransactions
Public Class UserControl_Trinken
    Private objLocalConfig As clsLocalConfig
    Private objSemItem_Partner As clsSemItem

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_Nahrungs
    Private procA_Trinkmessungen As New dsBabyModuleTableAdapters.proc_TrinkmessungenTableAdapter
    Private procT_Trinkmessungen As New dsBabyModule.proc_TrinkmessungenDataTable
    Private procA_Trinkmessungen_By_Date As New dsBabyModuleTableAdapters.proc_Trinkmessungen_By_DateTableAdapter
    Private procA_Trinkbestandteile_Of_Messung As New dsBabyModuleTableAdapters.proc_Trinkbestandteile_Of_MessungTableAdapter
    Private procT_Trinkbestandteile_Of_Messung As New dsBabyModule.proc_Trinkbestandteile_Of_MessungDataTable
    Private procA_Bestandteile As New dsBabyModuleTableAdapters.proc_BestandteileTableAdapter
    Private procT_Bestandteile As New dsBabyModule.proc_BestandteileDataTable
    Private procA_Mengen_Of_Day As New dsBabyModuleTableAdapters.proc_Mengen_Of_DayTableAdapter
    Private procT_Mengen_Of_Day As New dsBabyModule.proc_Mengen_Of_DayDataTable
    Private procT_Mengen_Of_days As New dsBabyModule.proc_Mengen_Of_DayDataTable
    Private procA_Wochenstatistik As New dsBabyModuleTableAdapters.proc_WochenstatistikTableAdapter
    Private procT_Wochenstatistik As New dsBabyModule.proc_WochenstatistikDataTable
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private objTransaction_Menge As clsTransaction_Menge
    Private objTransaction_Trinkmessungen As clsTransaction_Trinkmessungen
    Private objFRMTokenEdit As frmTokenEdit

    Private objThread_Tagesmenge As Threading.Thread

    Private objFrmTrinkbestandteil As frmTrinkbestandteil
    Private objDLG_Attribute_REAL As dlgAttribute_Real

    Private objSemItem_TrinkMessung As clsSemItem

    Private date_Messung As Date

    Private boolPChange_Trinken As Boolean
    Private boolGetTagesmengen As Boolean

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

    Public Sub initialize_Trinken(ByVal SemItem_Partner As clsSemItem)
        objSemItem_Partner = SemItem_Partner
        get_BaseData_Trinken()
        fill_DG_Trinken()
        configure_TabPages()
    End Sub

    Private Sub set_DBConnection()
        procA_Trinkmessungen.Connection = objLocalConfig.Connection_Plugin
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_Mengen_Of_Day.Connection = objLocalConfig.Connection_Plugin
        procA_Bestandteile.Connection = objLocalConfig.Connection_Plugin
        objTransaction_Trinkmessungen = New clsTransaction_Trinkmessungen(objLocalConfig)
        objTransaction_Menge = New clsTransaction_Menge(objLocalConfig.Globals)
        procA_Trinkmessungen_By_Date.Connection = objLocalConfig.Connection_Plugin
        procA_Trinkbestandteile_Of_Messung.Connection = objLocalConfig.Connection_Plugin
        procA_Wochenstatistik.Connection = objLocalConfig.Connection_Plugin
    End Sub

    Private Sub get_BaseData_Trinken()
        boolPChange_Trinken = True
        procT_Trinkbestandteile_Of_Messung.Clear()
        If Not objSemItem_Partner Is Nothing Then
            procA_Trinkmessungen.Fill(procT_Trinkmessungen, _
                                      objLocalConfig.SemItem_Type_Trinkmessungen.GUID, _
                                      objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                      objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID, _
                                      objLocalConfig.SemItem_Attribute_Trinkprobleme__Spucken_.GUID, _
                                      objLocalConfig.SemItem_Attribute_Eigeninitiative.GUID, _
                                      objLocalConfig.SemItem_Type_Partner.GUID, _
                                      objLocalConfig.SemItem_Type_Trinkbestandteil.GUID, _
                                      objLocalConfig.SemItem_Type_Menge.GUID, _
                                      objLocalConfig.SemItem_Type_Einheit.GUID, _
                                      objLocalConfig.SemItem_Type_Medikamente.GUID, _
                                      objLocalConfig.SemItem_Type_Nahrung.GUID, _
                                      objLocalConfig.SemItem_RelationType_contains.GUID, _
                                      objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                      objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                      objSemItem_Partner.GUID)
                                       
        Else
            procT_Trinkmessungen.Clear()

        End If

        boolPChange_Trinken = False
    End Sub

    Private Sub configure_TabPages()
        Select Case TabControl1.SelectedTab.Name
            Case TabPage_Days.Name
                fill_Tagesverlauf()
            Case TabPage_Weeks.Name
                fill_Wochenstatistik()
        End Select
    End Sub

    Private Sub fill_DG_Trinken()
        boolPChange_Trinken = True
        BindingSource_Trinken.DataSource = procT_Trinkmessungen
        DataGridView_Trinken.DataSource = BindingSource_Trinken
        DataGridView_Trinken.Columns(0).Visible = False
        DataGridView_Trinken.Columns(1).Visible = False
        DataGridView_Trinken.Columns(2).Visible = False
        DataGridView_Trinken.Columns(3).Visible = False
        DataGridView_Trinken.Columns(4).Visible = False
        DataGridView_Trinken.Columns(5).Visible = False
        DataGridView_Trinken.Columns(7).Visible = False
        DataGridView_Trinken.Columns(9).Visible = False

        ToolStripLabel_Count_Trinken.Text = DataGridView_Trinken.RowCount
        boolPChange_Trinken = False
        ToolStripLabel_Filter.Enabled = False
        ToolStripButton_ClearFilter.Enabled = False
        BindingSource_Trinken.Filter = ""
    End Sub



    Private Sub Button_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del.Click
        Dim objSemItem_Result As clsSemItem
        If objSemItem_TrinkMessung.new_Item = False Then
            If MsgBox("Wollen Sie die Messung wirklich löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                objSemItem_Result = objTransaction_Trinkmessungen.del_005_Trinkmessungen_To_Partner(objSemItem_TrinkMessung)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    
                    objSemItem_Result = objTransaction_Trinkmessungen.del_004_Trinkmessung__Zeitpunkt()
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_Trinkmessungen.del_003_Eigeninitiative__Trinkprobleme()
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Trinkmessungen.del_002_Trinkmessungen__Trinkprobleme
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_Trinkmessungen.del_001_Trinkmessungen()
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    Button_Save.Enabled = False
                                    DateTimePicker_Zeitpunkt.Enabled = False
                                    Button_Del.Enabled = False
                                    CheckBox_Eigeninitiative.Enabled = False
                                    CheckBox_Spucken.Enabled = False
                                    get_BaseData_Trinken()
                                    fill_DG_Trinken()
                                Else

                                End If
                            Else

                            End If

                        Else

                        End If

                    End If

                    End If
                End If

            Else
                Button_Del.Enabled = False
            End If
    End Sub

    Private Sub DateTimePicker_Zeitpunkt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker_Zeitpunkt.ValueChanged
        If DateTimePicker_Zeitpunkt.Enabled = True Then
            Button_Save.Enabled = True
        End If
    End Sub

    Private Sub Button_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_New.Click
        DateTimePicker_Zeitpunkt.Enabled = False
        Button_Save.Enabled = True
        Button_Del.Enabled = False
        CheckBox_Eigeninitiative.Enabled = False
        CheckBox_Spucken.Enabled = False

        DateTimePicker_Zeitpunkt.Value = Now
        objSemItem_TrinkMessung = New clsSemItem
        objSemItem_TrinkMessung.GUID = Guid.NewGuid
        objSemItem_TrinkMessung.Name = Now.ToString
        objSemItem_TrinkMessung.GUID_Parent = objLocalConfig.SemItem_Type_Trinkmessungen.GUID
        objSemItem_TrinkMessung.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        objSemItem_TrinkMessung.new_Item = True

        DateTimePicker_Zeitpunkt.Enabled = True
        CheckBox_Eigeninitiative.Enabled = True
        CheckBox_Spucken.Enabled = True
    End Sub

    Private Sub save_TrinkMessung()
        Dim objSemItem_Result As clsSemItem
        Dim dblMenge As Double
        Dim dateTimeStamp As Date
        Dim objDRC_Menge As DataRowCollection
        Dim objDRs_Trinkmessung() As DataRow
        Dim objDGVR_Selected As DataGridViewRow

        Button_Save.Enabled = False
        If objSemItem_TrinkMessung.new_Item = True Then

            dateTimeStamp = DateTimePicker_Zeitpunkt.Value
            objDRC_Menge = procA_Trinkmessungen_By_Date.GetData(objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID, _
                                                                  objLocalConfig.SemItem_Type_Trinkmessungen.GUID, _
                                                                  objLocalConfig.SemItem_Type_Partner.GUID, _
                                                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                              objSemItem_Partner.GUID, _
                                                              DateTimePicker_Zeitpunkt.Value).Rows
            If objDRC_Menge.Count = 0 Then
                objSemItem_TrinkMessung.Name = DateTimePicker_Zeitpunkt.Value.ToString
                objSemItem_Result = objTransaction_Trinkmessungen.save_001_Trinkmessungen(objSemItem_TrinkMessung)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_Trinkmessungen.save_002_Trinkmessungen__Trinkprobleme(CheckBox_Spucken.Checked)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_Trinkmessungen.save_003_Trinkmessungen__Eigeninitiative(CheckBox_Eigeninitiative.Checked)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Trinkmessungen.save_004_Trinkmessungen__Zeitpunkt(DateTimePicker_Zeitpunkt.Value)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_Trinkmessungen.save_005_Trinkmessungen_To_Partner(objSemItem_Partner)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    get_BaseData_Trinken()
                                    fill_DG_Trinken()
                                    BindingSource_Trinken.Filter = "GUID_Trinkmessungen='" & objSemItem_TrinkMessung.GUID.ToString & "'"
                                    If DataGridView_Trinken.RowCount > 0 Then
                                        objDGVR_Selected = DataGridView_Trinken.Rows(0)
                                        objDGVR_Selected.Selected = True
                                    End If
                                    ToolStripLabel_Filter.Enabled = True
                                    ToolStripButton_ClearFilter.Enabled = True
                                Else
                                    MsgBox("Die Messung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                    objSemItem_Result = objTransaction_Trinkmessungen.del_004_Trinkmessung__Zeitpunkt
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_Trinkmessungen.del_003_Eigeninitiative__Trinkprobleme
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_Trinkmessungen.del_002_Trinkmessungen__Trinkprobleme
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objTransaction_Trinkmessungen.del_001_Trinkmessungen()
                                            End If
                                        End If
                                    End If


                                    DateTimePicker_Zeitpunkt.Enabled = False
                                    Button_Del.Enabled = False
                                    CheckBox_Eigeninitiative.Enabled = False
                                    CheckBox_Spucken.Enabled = False
                                    objSemItem_TrinkMessung.new_Item = False
                                    get_BaseData_Trinken()
                                    fill_DG_Trinken()
                                End If
                            Else

                                MsgBox("Die Messung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                objSemItem_Result = objTransaction_Trinkmessungen.del_003_Eigeninitiative__Trinkprobleme
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_Trinkmessungen.del_002_Trinkmessungen__Trinkprobleme
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_Trinkmessungen.del_001_Trinkmessungen()
                                    End If
                                End If

                                DateTimePicker_Zeitpunkt.Enabled = False
                                Button_Del.Enabled = False
                                CheckBox_Eigeninitiative.Enabled = False
                                CheckBox_Spucken.Enabled = False
                                objSemItem_TrinkMessung.new_Item = False
                                get_BaseData_Trinken()
                                fill_DG_Trinken()
                            End If
                        Else
                            MsgBox("Die Messung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            objSemItem_Result = objTransaction_Trinkmessungen.del_002_Trinkmessungen__Trinkprobleme
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_Trinkmessungen.del_001_Trinkmessungen()
                            End If

                        End If

                    Else
                        MsgBox("Die Messung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        objTransaction_Trinkmessungen.del_001_Trinkmessungen()
                    End If

                Else
                    MsgBox("Die Messung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If
                
            End If

        Else
            get_BaseData_Trinken()
            objDRs_Trinkmessung = procT_Trinkmessungen.Select("GUID_Trinkmessungen='" & objSemItem_TrinkMessung.GUID.ToString & "'")
            If objDRs_Trinkmessung.Count > 0 Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                If Not IsDBNull(objDRs_Trinkmessung(0).Item("Zeitpunkt")) Then
                    If Not objDRs_Trinkmessung(0).Item("Zeitpunkt") = DateTimePicker_Zeitpunkt.Value Then
                        objSemItem_Result = objTransaction_Trinkmessungen.save_004_Trinkmessungen__Zeitpunkt(DateTimePicker_Zeitpunkt.Value, objDRs_Trinkmessung(0).Item("GUID_TokenAttribute_Zeitpunkt"), objSemItem_TrinkMessung)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Der Zeitpunkt kann nicht verändert werden!", MsgBoxStyle.Exclamation)
                            DateTimePicker_Zeitpunkt.Enabled = False
                            CheckBox_Eigeninitiative.Enabled = False
                            CheckBox_Spucken.Enabled = False
                            Button_Save.Enabled = False
                            Button_Del.Enabled = False
                        End If
                    End If
                Else
                    objSemItem_Result = objTransaction_Trinkmessungen.save_004_Trinkmessungen__Zeitpunkt(DateTimePicker_Zeitpunkt.Value, Nothing, objSemItem_TrinkMessung)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Der Zeitpunkt kann nicht verändert werden!", MsgBoxStyle.Exclamation)
                        DateTimePicker_Zeitpunkt.Enabled = False
                        CheckBox_Eigeninitiative.Enabled = False
                        CheckBox_Spucken.Enabled = False
                        Button_Save.Enabled = False
                        Button_Del.Enabled = False
                    End If
                End If
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    If Not IsDBNull(objDRs_Trinkmessung(0).Item("Trinkprobleme")) Then
                        objSemItem_Result = objTransaction_Trinkmessungen.save_002_Trinkmessungen__Trinkprobleme(CheckBox_Spucken.Checked, objDRs_Trinkmessung(0).Item("GUID_TokenAttribute_Trinkprobleme"), objSemItem_TrinkMessung)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Trinkprobleme kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                            DateTimePicker_Zeitpunkt.Enabled = False
                            CheckBox_Eigeninitiative.Enabled = False
                            CheckBox_Spucken.Enabled = False
                            Button_Save.Enabled = False
                            Button_Del.Enabled = False
                        End If
                    Else
                        objSemItem_Result = objTransaction_Trinkmessungen.save_002_Trinkmessungen__Trinkprobleme(CheckBox_Spucken.Checked, Nothing, objSemItem_TrinkMessung)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Trinkprobleme kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                            DateTimePicker_Zeitpunkt.Enabled = False
                            CheckBox_Eigeninitiative.Enabled = False
                            CheckBox_Spucken.Enabled = False
                            Button_Save.Enabled = False
                            Button_Del.Enabled = False
                        End If
                    End If

                End If
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    If Not IsDBNull(objDRs_Trinkmessung(0).Item("Eigeninitiative")) Then
                        objSemItem_Result = objTransaction_Trinkmessungen.save_003_Trinkmessungen__Eigeninitiative(CheckBox_Eigeninitiative.Checked, objDRs_Trinkmessung(0).Item("GUID_TokenAttribute_Eigeninitiative"), objSemItem_TrinkMessung)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Eigeninitiative kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                            DateTimePicker_Zeitpunkt.Enabled = False
                            CheckBox_Eigeninitiative.Enabled = False
                            CheckBox_Spucken.Enabled = False
                            Button_Save.Enabled = False
                            Button_Del.Enabled = False
                        End If
                    Else
                        objSemItem_Result = objTransaction_Trinkmessungen.save_003_Trinkmessungen__Eigeninitiative(CheckBox_Eigeninitiative.Checked, Nothing, objSemItem_TrinkMessung)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Eigeninitiative kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                            DateTimePicker_Zeitpunkt.Enabled = False
                            CheckBox_Eigeninitiative.Enabled = False
                            CheckBox_Spucken.Enabled = False
                            Button_Save.Enabled = False
                            Button_Del.Enabled = False
                        End If
                    End If
                End If

            End If

        End If
    End Sub


    

    Private Sub DataGridView_Trinken_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Trinken.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Trinkmessung As New clsSemItem

        If DataGridView_Trinken.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Trinken.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Trinkmessung.GUID = objDRV_Selected.Item("GUID_Trinkmessungen")
            objSemItem_Trinkmessung.Name = objDRV_Selected.Item("Name_Trinkmessungen")
            objSemItem_Trinkmessung.GUID_Parent = objLocalConfig.SemItem_Type_Trinkmessungen.GUID
            objSemItem_Trinkmessung.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objFRMTokenEdit = New frmTokenEdit(objSemItem_Trinkmessung, objLocalConfig.Globals)
            objFRMTokenEdit.ShowDialog(Me)
            get_BaseData_Trinken()
            fill_DG_Trinken()

        End If
    End Sub

    Private Sub DataGridView_Trinken_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Trinken.SelectionChanged
        boolGetTagesmengen = False
        Timer_Tagesmengen.Stop()
        ProgressBar_Mengen.Value = 0
        procT_Mengen_Of_Day.Clear()
        fill_DGV_Bestandteil()





    End Sub

    Private Sub get_Tagesmengen()

        If Not objSemItem_Partner Is Nothing Then
            procA_Mengen_Of_Day.Fill(procT_Mengen_Of_Day, _
                                 objLocalConfig.SemItem_Type_Trinkmessungen.GUID, _
                                 objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID, _
                                 objLocalConfig.SemItem_Attribute_Trinkprobleme__Spucken_.GUID, _
                                 objLocalConfig.SemItem_Attribute_Eigeninitiative.GUID, _
                                 objLocalConfig.SemItem_Type_Partner.GUID, _
                                 objLocalConfig.SemItem_Type_Nahrung.GUID, _
                                 objLocalConfig.SemItem_Type_Medikamente.GUID, _
                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                 objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                 objLocalConfig.SemItem_Type_Trinkbestandteil.GUID, _
                                 objLocalConfig.SemItem_Type_Menge.GUID, _
                                 objLocalConfig.SemItem_Type_Einheit.GUID, _
                                 objLocalConfig.SemItem_RelationType_contains.GUID, _
                                 objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                 objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                 objSemItem_Partner.GUID, _
                                 date_Messung)
        Else
            procT_Mengen_Of_Day.Clear()
        End If
        


        boolGetTagesmengen = True
    End Sub

    Private Sub fill_Wochenstatistik()
        If Not objSemItem_Partner Is Nothing Then
            procA_Wochenstatistik.Fill(procT_Wochenstatistik, _
                                       objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID, _
                                       objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                       objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID, _
                                       objLocalConfig.SemItem_Attribute_Trinkprobleme__Spucken_.GUID, _
                                       objLocalConfig.SemItem_Attribute_Eigeninitiative.GUID, _
                                       objLocalConfig.SemItem_Type_Gewichtsmessung.GUID, _
                                       objLocalConfig.SemItem_Type_Menge.GUID, _
                                       objLocalConfig.SemItem_Type_Einheit.GUID, _
                                       objLocalConfig.SemItem_Type_Trinkmessungen.GUID, _
                                       objLocalConfig.SemItem_Type_Partner.GUID, _
                                       objLocalConfig.SemItem_Type_Nahrung.GUID, _
                                       objLocalConfig.SemItem_Type_Medikamente.GUID, _
                                       objLocalConfig.SemItem_Type_Trinkbestandteil.GUID, _
                                       objLocalConfig.SemItem_RelationType_contains.GUID, _
                                       objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                       objLocalConfig.SemItem_RelationType_Gewicht.GUID, _
                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                       objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                       objSemItem_Partner.GUID)

        Else
            procT_Wochenstatistik.Clear()
        End If

        BindingSource_Weeks.DataSource = procT_Wochenstatistik
        DataGridView_Weeks.DataSource = BindingSource_Weeks
    End Sub
    Private Sub fill_Tagesverlauf()
        
        If Not objSemItem_Partner Is Nothing Then
            procA_Mengen_Of_Day.Fill(procT_Mengen_Of_days, _
                                 objLocalConfig.SemItem_Type_Trinkmessungen.GUID, _
                                 objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID, _
                                 objLocalConfig.SemItem_Attribute_Trinkprobleme__Spucken_.GUID, _
                                 objLocalConfig.SemItem_Attribute_Eigeninitiative.GUID, _
                                 objLocalConfig.SemItem_Type_Partner.GUID, _
                                 objLocalConfig.SemItem_Type_Nahrung.GUID, _
                                 objLocalConfig.SemItem_Type_Medikamente.GUID, _
                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                 objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                 objLocalConfig.SemItem_Type_Trinkbestandteil.GUID, _
                                 objLocalConfig.SemItem_Type_Menge.GUID, _
                                 objLocalConfig.SemItem_Type_Einheit.GUID, _
                                 objLocalConfig.SemItem_RelationType_contains.GUID, _
                                 objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                 objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                 objSemItem_Partner.GUID, _
                                 Nothing)
        Else
            procT_Mengen_Of_days.Clear()
        End If

        BindingSource_Days.DataSource = procT_Mengen_Of_days
        DataGridView_Dayly.DataSource = BindingSource_Days
        BindingSource_Days.Filter = "GUID_Type_Medikamente IS NULL"

    End Sub


    Private Sub fill_DGV_Bestandteil()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        DateTimePicker_Zeitpunkt.Enabled = False
        Button_Del.Enabled = False
        CheckBox_Eigeninitiative.Enabled = False
        CheckBox_Spucken.Enabled = False
        Button_Save.Enabled = False
        procT_Trinkbestandteile_Of_Messung.Clear()

        If boolPChange_Trinken = False Then
            If DataGridView_Trinken.SelectedRows.Count = 1 Then

                ProgressBar_Mengen.Value = 50

                objDGVR_Selected = DataGridView_Trinken.SelectedRows(0)
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                objSemItem_TrinkMessung = New clsSemItem
                objSemItem_TrinkMessung.GUID = objDRV_Selected.Item("GUID_Trinkmessungen")
                objSemItem_TrinkMessung.Name = objDRV_Selected.Item("Name_Trinkmessungen")
                objSemItem_TrinkMessung.GUID_Parent = objLocalConfig.SemItem_Type_Trinkmessungen.GUID
                objSemItem_TrinkMessung.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                DateTimePicker_Zeitpunkt.Value = objDRV_Selected.Item("Zeitpunkt")
                date_Messung = objDRV_Selected.Item("Zeitpunkt")

                CheckBox_Eigeninitiative.Checked = objDRV_Selected.Item("Eigeninitiative")
                If Not IsDBNull(objDRV_Selected.Item("Trinkprobleme")) Then
                    CheckBox_Spucken.Checked = objDRV_Selected.Item("Trinkprobleme")
                Else
                    CheckBox_Spucken.Checked = False
                End If

                procA_Trinkbestandteile_Of_Messung.Fill(procT_Trinkbestandteile_Of_Messung, _
                                                        objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Trinkbestandteil.GUID, _
                                                        objLocalConfig.SemItem_Type_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Einheit.GUID, _
                                                        objLocalConfig.SemItem_Type_Medikamente.GUID, _
                                                        objLocalConfig.SemItem_Type_Nahrung.GUID, _
                                                        objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                        objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                        objSemItem_TrinkMessung.GUID)


                BindingSource_Bestandteil.DataSource = procT_Trinkbestandteile_Of_Messung
                DataGridView_Bestandteil.DataSource = BindingSource_Bestandteil
                For i As Integer = 0 To DataGridView_Bestandteil.Columns.Count - 1
                    DataGridView_Bestandteil.Columns(i).Visible = False
                Next

                DataGridView_Bestandteil.Columns(3).Visible = True
                DataGridView_Bestandteil.Columns(4).Visible = True
                DataGridView_Bestandteil.Columns(12).Visible = True
                DataGridView_Bestandteil.Columns(15).Visible = True

                DateTimePicker_Zeitpunkt.Enabled = True
                Button_Save.Enabled = False
                Button_Del.Enabled = True
                CheckBox_Eigeninitiative.Enabled = True
                CheckBox_Spucken.Enabled = True

                Try

                    objThread_Tagesmenge.Abort()
                Catch ex As Exception

                End Try
                objThread_Tagesmenge = New Threading.Thread(AddressOf get_Tagesmengen)
                objThread_Tagesmenge.Start()
                Timer_Tagesmengen.Start()
            End If
        End If
    End Sub

    Private Sub Button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save.Click
        save_TrinkMessung()
    End Sub

    Private Sub ContextMenuStrip_Bestandteile_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Bestandteile.Opening
        AddBestandteilToolStripMenuItem.Enabled = False
        RemoveBestandteilToolStripMenuItem.Enabled = False
        ChangeBestandteilToolStripMenuItem.Enabled = False
        If DataGridView_Trinken.SelectedRows.Count = 1 Then
            AddBestandteilToolStripMenuItem.Enabled = True
        End If

        If DataGridView_Bestandteil.SelectedRows.Count > 0 Then
            RemoveBestandteilToolStripMenuItem.Enabled = True
            If DataGridView_Bestandteil.SelectedRows.Count = 1 Then
                ChangeBestandteilToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub ChangeBestandteilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeBestandteilToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Trinkbestandteil As New clsSemItem

        objDGVR_Selected = DataGridView_Bestandteil.SelectedRows(0)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Trinkbestandteil.GUID = objDRV_Selected.Item("GUID_Trinkbestandteil")
        objSemItem_Trinkbestandteil.Name = objDRV_Selected.Item("name_Trinkbestandteil")
        objSemItem_Trinkbestandteil.GUID_Parent = objLocalConfig.SemItem_Type_Trinkbestandteil.GUID
        objSemItem_Trinkbestandteil.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrmTrinkbestandteil = New frmTrinkbestandteil(objLocalConfig, objSemItem_TrinkMessung, objSemItem_Trinkbestandteil)
        objFrmTrinkbestandteil.ShowDialog(Me)
        fill_DGV_Bestandteil()
    End Sub

    Private Sub AddBestandteilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBestandteilToolStripMenuItem.Click
        Dim intPos As Integer
        Dim objDGVR_Selected As DataGridViewRow

        objFrmTrinkbestandteil = New frmTrinkbestandteil(objLocalConfig, objSemItem_TrinkMessung)
        objFrmTrinkbestandteil.ShowDialog(Me)
        get_BaseData_Trinken()
        intPos = BindingSource_Trinken.Position
        objDGVR_Selected = DataGridView_Trinken.Rows(intPos)
        fill_DGV_Bestandteil()
        Try

            objDGVR_Selected.Selected = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox_Spucken_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_Spucken.CheckStateChanged
        Button_Save.Enabled = True
    End Sub

    Private Sub CheckBox_Spucken_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_Spucken.Click

    End Sub

    Private Sub CheckBox_Eigeninitiative_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_Eigeninitiative.CheckStateChanged
        Button_Save.Enabled = True
    End Sub

    Private Sub RemoveBestandteilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveBestandteilToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Trinkbestandteil As New clsSemItem
        Dim objSemItem_Menge As New clsSemItem

        For Each objDGVR_Selected In DataGridView_Bestandteil.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Trinkbestandteil.GUID = objDRV_Selected.Item("GUID_Trinkbestandteil")
            objSemItem_Trinkbestandteil.Name = objDRV_Selected.Item("Name_Trinkbestandteil")
            objSemItem_Trinkbestandteil.GUID_Parent = objLocalConfig.SemItem_Type_Trinkbestandteil.GUID
            objSemItem_Trinkbestandteil.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objTransaction_Trinkmessungen.del_010_Trinkbestandteil_To_Menge(objSemItem_Trinkbestandteil)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_Trinkmessungen.del_009_Trinkbestandteil_To_Nahrungsmittel
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_Trinkmessungen.del_008_Trinkbestandteil_To_Medikament
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_Trinkmessungen.del_007_Trinkmessung_To_Trinkbestandteil(False, objSemItem_TrinkMessung, objSemItem_Trinkbestandteil)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Trinkmessungen.del_006_Trinkbestandteil
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                fill_DGV_Bestandteil()
                            Else

                            End If
                        Else

                        End If

                    Else

                    End If
                Else

                End If
            Else
                MsgBox("Der Trinkbestandteil konnte nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                objSemItem_Menge.GUID = objDRV_Selected.Item("GUID_Menge")
                objSemItem_Menge.Name = objDRV_Selected.Item("name_Menge")
                objSemItem_Menge.GUID_Parent = objLocalConfig.SemItem_Type_Menge.GUID
                objSemItem_Menge.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_Trinkmessungen.save_010_Trinkbestandteil_To_Menge(objSemItem_Menge)

            End If

        Next
    End Sub

    Private Sub Timer_Tagesmengen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Tagesmengen.Tick
        Timer_Tagesmengen.Stop()
        If boolGetTagesmengen = True Then
            DataGridView_Tagesmengen.DataSource = Nothing
            BindingSource_Tagesmengen.DataSource = procT_Mengen_Of_Day
            DataGridView_Tagesmengen.DataSource = BindingSource_Tagesmengen
            DataGridView_Tagesmengen.Columns(1).Width = 35
            DataGridView_Tagesmengen.Columns(3).Width = 45
            ProgressBar_Mengen.Value = 0
        End If
    End Sub

    Private Sub Button_Clear_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ClearFilter.Click
        BindingSource_Trinken.Filter = ""
        ToolStripLabel_Filter.Enabled = False
        ToolStripButton_ClearFilter.Enabled = False
    End Sub

    Private Sub DataGridView_Bestandteil_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Bestandteil.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objSemItem_Bestandteil As New clsSemItem

        If DataGridView_Bestandteil.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Bestandteil.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Bestandteil.GUID = objDRV_Selected.Item("GUID_Trinkbestandteil")
            objSemItem_Bestandteil.Name = objDRV_Selected.Item("Name_Trinkbestandteil")
            objSemItem_Bestandteil.GUID_Parent = objLocalConfig.SemItem_Type_Trinkbestandteil.GUID
            objSemItem_Bestandteil.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objFRMTokenEdit = New frmTokenEdit(objSemItem_Bestandteil, objLocalConfig.Globals)
            objFRMTokenEdit.ShowDialog(Me)
            fill_DGV_Bestandteil()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        configure_TabPages()
    End Sub

    
End Class

