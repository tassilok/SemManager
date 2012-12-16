Imports Sem_Manager
Imports OrganisationalTransactions
Public Class UserControl_Gewichtsmessung
    Private objLocalConfig As clsLocalConfig
    Private objDLG_Attribute_REAL As dlgAttribute_Real
    Private procA_Gewichtsmessung As New dsBabyModuleTableAdapters.proc_GewichtsmessungTableAdapter
    Private procT_Gewichtsmessung As New dsBabyModule.proc_GewichtsmessungDataTable
    Private procA_Gewichtsmessung_By_Date As New dsBabyModuleTableAdapters.proc_Gewichtsmessung_By_DateTableAdapter
    Private objSemItem_Partner As clsSemItem
    Private objSemItem_Gewichtsmessung As clsSemItem
    Private objTransaction_Gewichtsmessung As clsTransaction_Gewichtsmessung
    Private objTransaction_Menge As clsTransaction_Menge
    Private boolPChange_Gewichtsmessung As Boolean

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        ToolTip_State.SetToolTip(Panel_State, "")
        ToolTip_State.Active = False
        initialize()
    End Sub

    Private Sub get_BaseData_Gewichtsmessung()
        boolPChange_Gewichtsmessung = True
        If Not objSemItem_Partner Is Nothing Then
            procA_Gewichtsmessung.Fill(procT_Gewichtsmessung, _
                                       objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID, _
                                       objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                       objLocalConfig.SemItem_Type_Gewichtsmessung.GUID, _
                                       objLocalConfig.SemItem_Type_Menge.GUID, _
                                       objLocalConfig.SemItem_Type_Einheit.GUID, _
                                       objLocalConfig.SemItem_RelationType_Gewicht.GUID, _
                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                       objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                       objSemItem_Partner.GUID)
        Else
            procT_Gewichtsmessung.Clear()
        End If
        boolPChange_Gewichtsmessung = False
    End Sub

    Private Sub fill_DG_Gewichtsmessung()
        boolPChange_Gewichtsmessung = True
        BindingSource_Gewichtsmessung.DataSource = procT_Gewichtsmessung
        DataGridView_Gewichtsmessungen.DataSource = BindingSource_Gewichtsmessung
        DataGridView_Gewichtsmessungen.Columns(0).Visible = False
        DataGridView_Gewichtsmessungen.Columns(1).Visible = False
        DataGridView_Gewichtsmessungen.Columns(4).Visible = False
        DataGridView_Gewichtsmessungen.Columns(6).Visible = False

        ToolStripLabel_Count.Text = DataGridView_Gewichtsmessungen.RowCount
        boolPChange_Gewichtsmessung = False
    End Sub

    Private Sub initialize()
        set_DBConnection()


    End Sub

    Public Sub initialize_Gewichtsmessung(ByVal SemItem_Partner As clsSemItem)
        objSemItem_Partner = SemItem_Partner
        get_BaseData_Gewichtsmessung()
        fill_DG_Gewichtsmessung()
    End Sub

    Private Sub set_DBConnection()
        procA_Gewichtsmessung.Connection = objLocalConfig.Connection_Plugin
        objTransaction_Gewichtsmessung = New clsTransaction_Gewichtsmessung(objLocalConfig)
        objTransaction_Menge = New clsTransaction_Menge(objLocalConfig.Globals)
        procA_Gewichtsmessung_By_Date.Connection = objLocalConfig.Connection_Plugin
    End Sub

    Private Sub Button_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_New.Click

        DateTimePicker_Zeitpunkt.Enabled = False
        TextBox_Gewicht.Enabled = False
        Button_Del.Enabled = False

        DateTimePicker_Zeitpunkt.Value = Now
        TextBox_Gewicht.Text = ""
        objSemItem_Gewichtsmessung = New clsSemItem
        objSemItem_Gewichtsmessung.GUID = Guid.NewGuid
        objSemItem_Gewichtsmessung.Name = Now.ToString
        objSemItem_Gewichtsmessung.GUID_Parent = objLocalConfig.SemItem_Type_Gewichtsmessung.GUID
        objSemItem_Gewichtsmessung.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        objSemItem_Gewichtsmessung.new_Item = True

        DateTimePicker_Zeitpunkt.Enabled = True
        TextBox_Gewicht.Enabled = True
    End Sub

    Private Sub DateTimePicker_Zeitpunkt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker_Zeitpunkt.ValueChanged

        If DateTimePicker_Zeitpunkt.Enabled = True Then
            Panel_State.BackColor = Color.Yellow
            save_GewichtMessung()
        End If

    End Sub

    Private Sub TextBox_Gewicht_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox_Gewicht.MouseDoubleClick
        Dim dblValue As Double
        If TextBox_Gewicht.Enabled = True Then
            If Double.TryParse(TextBox_Gewicht.Text, dblValue) = False Then
                dblValue = 0
            End If
            objDLG_Attribute_REAL = New dlgAttribute_Real("New Value", objLocalConfig.Globals, dblValue)
            objDLG_Attribute_REAL.ShowDialog(Me)
            If objDLG_Attribute_REAL.DialogResult = Windows.Forms.DialogResult.OK Then
                TextBox_Gewicht.Text = objDLG_Attribute_REAL.Value.ToString
            End If
        End If
    End Sub

    Private Sub TextBox_Gewicht_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Gewicht.TextChanged
        Timer_Gewicht.Stop()
        If TextBox_Gewicht.Enabled = True Then
            Panel_State.BackColor = Color.Yellow
            Timer_Gewicht.Start()

        End If
    End Sub

   


    Private Sub save_GewichtMessung()
        Dim objSemItem_Result As clsSemItem
        Dim dblGewicht As Double
        Dim dateTimeStamp As Date
        Dim objDRC_Gewicht As DataRowCollection
        If objSemItem_Gewichtsmessung.new_Item = True Then
            Panel_State.BackColor = Color.Yellow
            dateTimeStamp = DateTimePicker_Zeitpunkt.Value
            objDRC_Gewicht = procA_Gewichtsmessung_By_Date.GetData(objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID, _
                                                              objLocalConfig.SemItem_Type_Gewichtsmessung.GUID, _
                                                              objLocalConfig.SemItem_Type_Partner.GUID, _
                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                              objSemItem_Partner.GUID, _
                                                              DateTimePicker_Zeitpunkt.Value).Rows
            If objDRC_Gewicht.Count = 0 Then
                If Double.TryParse(TextBox_Gewicht.Text, dblGewicht) = True Then
                    dblGewicht = Double.Parse(TextBox_Gewicht.Text)
                    objSemItem_Result = objTransaction_Gewichtsmessung.save_001_Gewichtsmessung(objSemItem_Gewichtsmessung)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_Gewichtsmessung.save_002_Gewichtsmessung__Zeitpunkt(DateTimePicker_Zeitpunkt.Value)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                            objSemItem_Result = objTransaction_Menge.save_001_Menge(dblGewicht, _
                                                                                    objLocalConfig.SemItem_Token_Einheit_g)
                            If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then
                                    objSemItem_Result = objTransaction_Menge.save_002_Menge__Menge(dblGewicht)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_Menge.save_004_Menge_To_Einheit(objLocalConfig.SemItem_Token_Einheit_g)
                                    End If
                                Else
                                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                End If
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_Menge.save_004_Menge_To_Einheit()
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_Gewichtsmessung.save_003_Gewichtsmessung_To_Menge(objTransaction_Menge.SemItem_Menge)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_Gewichtsmessung.save_004_Gewichtsmessung_To_Partner(objSemItem_Partner)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                DateTimePicker_Zeitpunkt.Enabled = False
                                                TextBox_Gewicht.Enabled = False
                                                TextBox_Gewicht.Text = ""
                                                Button_Del.Enabled = False
                                                objSemItem_Gewichtsmessung.new_Item = False
                                                get_BaseData_Gewichtsmessung()
                                                fill_DG_Gewichtsmessung()
                                                Panel_State.BackColor = Color.Green
                                            End If

                                        Else
                                            Stop
                                        End If
                                    Else
                                        Stop
                                    End If
                                Else
                                    Stop
                                End If
                            Else
                                Stop
                            End If
                        End If
                    Else
                        Stop
                    End If
                End If

            Else

                ToolTip_State.Show("Zeitstempel existiert schon!", Panel_State)
            End If

        Else



        End If
    End Sub
    Private Sub Timer_Gewicht_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Gewicht.Tick
        Timer_Gewicht.Stop()
        save_GewichtMessung()
    End Sub

    Private Sub DataGridView_Gewichtsmessungen_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Gewichtsmessungen.SelectionChanged
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Timer_Gewicht.Stop()
        DateTimePicker_Zeitpunkt.Enabled = False
        TextBox_Gewicht.Enabled = False
        Button_Del.Enabled = False
        Panel_State.BackColor = Nothing
        If boolPChange_Gewichtsmessung = False Then
            If DataGridView_Gewichtsmessungen.SelectedRows.Count = 1 Then
                objDGVR_Selected = DataGridView_Gewichtsmessungen.SelectedRows(0)
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                objSemItem_Gewichtsmessung = New clsSemItem
                objSemItem_Gewichtsmessung.GUID = objDRV_Selected.Item("GUID_Gewichtsmessung")
                objSemItem_Gewichtsmessung.Name = objDRV_Selected.Item("Name_Gewichtsmessung")
                objSemItem_Gewichtsmessung.GUID_Parent = objLocalConfig.SemItem_Type_Gewichtsmessung.GUID
                objSemItem_Gewichtsmessung.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                DateTimePicker_Zeitpunkt.Value = objDRV_Selected.Item("Zeitpunkt_Messung")
                TextBox_Gewicht.Text = objDRV_Selected.Item("Gewicht")
                DateTimePicker_Zeitpunkt.Enabled = True
                TextBox_Gewicht.Enabled = True
                Button_Del.Enabled = True
            Else
                
                TextBox_Gewicht.Text = ""
            End If
        End If
    End Sub

    Private Sub Button_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del.Click
        Dim objSemItem_Result As clsSemItem
        If objSemItem_Gewichtsmessung.new_Item = False Then
            If MsgBox("Wollen Sie die Messung wirklich löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                objSemItem_Result = objTransaction_Gewichtsmessung.del_004_Gewichtsmessung_To_Partner(objSemItem_Gewichtsmessung)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_Gewichtsmessung.del_003_Gewichtsmessung_To_Menge()
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_Gewichtsmessung.del_002_Gewichtsmessung__Zeitpunkt()
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Gewichtsmessung.del_001_Gewichtsmessung()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                Panel_State.BackColor = Nothing
                                TextBox_Gewicht.Enabled = False
                                DateTimePicker_Zeitpunkt.Enabled = False
                                Button_Del.Enabled = False
                                get_BaseData_Gewichtsmessung()
                                fill_DG_Gewichtsmessung()
                            Else

                            End If
                        End If
                    End If
                End If
            End If
            
        Else
            Button_Del.Enabled = False
        End If
    End Sub
End Class
