Imports Sem_Manager
Imports Log_Manager
Imports Security_Module

Public Class frmTimeManagementModule
    private objLocalConfig As clsLocalConfig

    Private objFrm_Authenticate As frmAuthenticate

    Private orgprocA_TimeManagement As New DataSet_TimeManagementTableAdapters.orgproc_TimeManagementTableAdapter
    Private orgprocT_TimeManagement As New DataSet_TimeManagement.orgproc_TimeManagementDataTable

    Private objFrm_TimeManagement_Edit As frmTimeManagementEdit

    Private objDlg_Attribute_DateTime As dlgAttribute_Datetime
    Private objDlg_Attribute_Varchar255 As dlgAttribute_Varchar255
    Private objFrmSemManager As frmSemManager
    Private objFrm_TokenEdit As frmTokenEdit

    Private objTransaction_TimeManagement As clsTransaction_TimeManagement

    Private boolStart As Boolean

    Public Sub New()
        
        ' This call is required by the designer.
        InitializeComponent()
        
        ' Add any initialization after the InitializeComponent() call.
        objLocalConfig = New clsLocalConfig(New clsGlobals())
        set_DBConnection()
        initialize()
    End Sub


    Private sub initialize()
        boolStart = False

        objFrm_Authenticate = new frmAuthenticate(objLocalConfig.Globals,frmAuthenticate.ERelateMode.NoRelate, True, False)
        objFrm_Authenticate.ShowDialog(me)
        If objFrm_Authenticate.DialogResult=DialogResult.OK Then
            objLocalConfig.User = objFrm_Authenticate.SemItem_User
            boolStart = True
            Configure_DataGrid()
        End If

        
    End Sub

    Private sub Configure_DataGrid()
        orgprocA_TimeManagement.Fill(orgprocT_TimeManagement, _
                                     objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                     objLocalConfig.SemItem_Type_Timemanagement.GUID, _
                                     objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                     objLocalConfig.SemItem_type_Logstate.GUID, _
                                     objLocalConfig.SemItem_type_User.GUID, _
                                     objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                     objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                     objLocalConfig.SemItem_RelationType_wasCreatedBy.GUID, _
                                     objLocalConfig.SemItem_Token_Logstate_private.GUID,
                                     objLocalConfig.User.GUID)

        BindingSource_LogManagement.DataSource = orgprocT_TimeManagement
        DataGridView_LogManagement.DataSource = BindingSource_LogManagement

        DataGridView_LogManagement.Columns(0).Visible = False
        DataGridView_LogManagement.Columns(1).HeaderText = "Bezeichnung (Zeiterfassung)"
        DataGridView_LogManagement.Columns(2).Visible = False
        DataGridView_LogManagement.Columns(3).Visible = False
        DataGridView_LogManagement.Columns(4).Visible = False
        DataGridView_LogManagement.Columns(5).HeaderText = "Typ"
        DataGridView_LogManagement.Columns(6).Visible = False
        DataGridView_LogManagement.Columns(7).HeaderText = "Wochentag"
        DataGridView_LogManagement.Columns(8).HeaderText = "Start"
        DataGridView_LogManagement.Columns(9).HeaderText = "Ende"
        DataGridView_LogManagement.Columns(10).HeaderText = "Stunden"
        DataGridView_LogManagement.Columns(11).HeaderText = "Minuten"
        DataGridView_LogManagement.Columns(12).HeaderText = "Wochenstunden"
        DataGridView_LogManagement.Columns(13).HeaderText = "Wochenminuten"
        DataGridView_LogManagement.Columns(14).HeaderText = "ToDo Wochenstunden"
        DataGridView_LogManagement.Columns(15).HeaderText = "ToDo Wochenminuten"
        DataGridView_LogManagement.Columns(16).HeaderText = "Tagesstunden"
        DataGridView_LogManagement.Columns(17).HeaderText = "Tagesminuten"
        DataGridView_LogManagement.Columns(18).HeaderText = "ToDo Tagesstunden"
        DataGridView_LogManagement.Columns(19).HeaderText = "ToDo Tagesminuten"
        DataGridView_LogManagement.Columns(20).HeaderText = "ToDo_Ende"
        DataGridView_LogManagement.Columns(21).HeaderText = "Jahr"
        DataGridView_LogManagement.Columns(22).HeaderText = "Monat"
        DataGridView_LogManagement.Columns(23).HeaderText = "Tag"
        DataGridView_LogManagement.Columns(24).HeaderText = "Woche"
        DataGridView_LogManagement.Columns(25).HeaderText = "Jahrestag"
        DataGridView_LogManagement.Columns(26).HeaderText = "Datumssequenz"
        DataGridView_LogManagement.Columns(27).Visible = False
        DataGridView_LogManagement.Columns(28).Visible = False
        DataGridView_LogManagement.Columns(29).Visible = False
        DataGridView_LogManagement.Columns(30).Visible = False
        DataGridView_LogManagement.Columns(31).Visible = False
        DataGridView_LogManagement.Columns(32).Visible = False
        DataGridView_LogManagement.Columns(33).Visible = False
        DataGridView_LogManagement.Columns(34).Visible = False

        filter_View()
        sort_View()
    End Sub

    Private sub filter_View
        Dim strFilter as String = ""
        If ToolStripTextBox_Filter.Text = "" Then
            Select Case ToolStripDropDownButton_Range.Text
                Case TodayToolStripMenuItem.Text
                    strFilter = "Year_Start=" & Now.Year & " AND Month_Start=" & Now.Month & " AND Day_Start=" & Now.Day
                    ToolStripTextBox_Filter.Text = strFilter
                    filter_View()
                Case YesterdayToolStripMenuItem.Text

                    strFilter = "Year_Start=" & Now.Subtract(New TimeSpan(1,0,0,0)).Year & " AND Month_Start=" & Now.Subtract(New TimeSpan(1,0,0,0)).Month & " AND Day_Start=" & Now.Subtract(New TimeSpan(1,0,0,0)).Day
                    ToolStripTextBox_Filter.Text = strFilter
                    filter_View()
                Case XThisWeekToolStripMenuItem.Text
                    Dim today As Date = date.Today
                    Dim dayDiff As Integer = today.DayOfWeek - DayOfWeek.Monday
                    Dim monday As Date = today.AddDays(-dayDiff)
                    strFilter = "DateTimeStamp_Start_Seq>=" & (monday.Year * 10000 + monday.Month * 100 + monday.Day)
                    ToolStripTextBox_Filter.Text = strFilter
                    filter_View()
                Case LastTwoWeeksToolStripMenuItem.Text
                    Dim today As Date = date.Today
                    Dim dayDiff As Integer = (today.Subtract(New TimeSpan(7,0,0,0))).DayOfWeek - DayOfWeek.Monday
                    Dim monday As Date = (today.Subtract(New TimeSpan(7,0,0,0))).AddDays(-dayDiff)
                    strFilter = "DateTimeStamp_Start_Seq>=" & (monday.Year * 10000 + monday.Month * 100 + monday.Day)
                    ToolStripTextBox_Filter.Text = strFilter
                    filter_View()
                Case XThisMonthToolStripMenuItem.Text
                    strFilter = "DateTimeStamp_Start_Seq>=" + Now.Year * 10000 + Now.Month  * 100 + 1
                    ToolStripTextBox_Filter.Text = strFilter
                    filter_View()
                Case AllToolStripMenuItem.Text
                    ToolStripTextBox_Filter.Text = ""
                    BindingSource_LogManagement.RemoveFilter()
            End Select

            
        Else 
            strFilter = ToolStripTextBox_Filter.Text
            Try
                BindingSource_LogManagement.Filter = strFilter
            Catch ex As Exception
                MsgBox("Der Filter ist ungültig!",MsgBoxStyle.Information)
                BindingSource_LogManagement.RemoveFilter()
            End Try
            
        End If
    End Sub

    Private sub sort_View
        Dim strSort As String
        If ToolStripTextBox_Sort.Text = "" Then
            strSort = "Ende desc"
            ToolStripTextBox_Sort.Text = strSort
            sort_View()
        Else 
            strSort = ToolStripTextBox_Sort.Text
            Try
                BindingSource_LogManagement.Sort = strSort
            Catch ex As Exception
                MsgBox("Die Angabe der Sortierung ist fehlerhaft!",MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    
    Private sub set_DBConnection()
        orgprocA_TimeManagement.Connection = objLocalConfig.Connection_Plugin
        objTransaction_TimeManagement = new clsTransaction_TimeManagement(objLocalConfig)
    End Sub

    Private Sub frmTimeManagementModule_Load(sender As Object, e As EventArgs) Handles Me.Load
        If boolStart=False Then
            Me.Close()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles NewToolStripMenuItem.Click
        objFrm_TimeManagement_Edit = new frmTimeManagementEdit(Nothing, objLocalConfig)
        objFrm_TimeManagement_Edit.ShowDialog(Me)
        If objFrm_TimeManagement_Edit.DialogResult = DialogResult.OK Then
            Configure_DataGrid()
        End If
    End Sub

    Private Sub DataGridView_LogManagement_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView_LogManagement.CellFormatting
        If DataGridView_LogManagement.Columns(e.ColumnIndex).DataPropertyName = "ToDo_Hours_Week" Or _ 
           DataGridView_LogManagement.Columns(e.ColumnIndex).DataPropertyName = "ToDo_Minutes_Week" Or _ 
           DataGridView_LogManagement.Columns(e.ColumnIndex).DataPropertyName = "ToDo_Hours_Day" Or _
           DataGridView_LogManagement.Columns(e.ColumnIndex).DataPropertyName = "ToDo_Minutes_Day"Then
        
            If e.Value > 0 Then 
                DataGridView_LogManagement.Rows(e.RowIndex).Cells(DataGridView_LogManagement.Columns(e.ColumnIndex).DataPropertyName).Style.BackColor = Color.Yellow
                DataGridView_LogManagement.Rows(e.RowIndex).Cells(DataGridView_LogManagement.Columns(e.ColumnIndex).DataPropertyName).Style.ForeColor = Color.Black
            End If
        End If
        

        
    End Sub

    Private Sub ContextMenuStrip_TimeManagement_Opening( sender As Object,  e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_TimeManagement.Opening
        
        EditToolStripMenuItem.Enabled = False

        If DataGridView_LogManagement.SelectedRows.Count = 1 Then
            EditToolStripMenuItem.Enabled = True
        End If
        
        If DataGridView_LogManagement.SelectedCells.Count=1 Then
            If DataGridView_LogManagement.SelectedCells(0).OwningColumn.DataPropertyName = "Name_Log_Management" Or _
                DataGridView_LogManagement.SelectedCells(0).OwningColumn.DataPropertyName = "Name_LogState_TimeManagement"  Or _
                DataGridView_LogManagement.SelectedCells(0).OwningColumn.DataPropertyName = "Start" Or _
                DataGridView_LogManagement.SelectedCells(0).OwningColumn.DataPropertyName = "Ende" Then
                EditToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles EditToolStripMenuItem.Click
        
        If DataGridView_LogManagement.SelectedRows.Count = 1 Then
           
            Dim objDGVR_Selected = DataGridView_LogManagement.SelectedRows(0)
            Dim objDRV_Selected As DataRowView = objDGVR_Selected.DataBoundItem
            objFrm_TimeManagement_Edit = new frmTimeManagementEdit(objDRV_Selected,objLocalConfig)
            objFrm_TimeManagement_Edit.ShowDialog(me)
            If objFrm_TimeManagement_Edit.DialogResult = DialogResult.OK Then
                Configure_DataGrid()
            End If
        End If

        If DataGridView_LogManagement.SelectedCells.Count=1 Then
            Dim objDGVR_Selected = DataGridView_LogManagement.Rows(DataGridView_LogManagement.SelectedCells(0).RowIndex)
            Dim objDRV_Selected  As DataRowView = objDGVR_Selected.DataBoundItem
            Dim objSemItem_TimeManagement = New clsSemItem With {.GUID = objDRV_Selected.Item("GUID_Log_Management"), _
                                                                                             .Name = objDRV_Selected.Item("Name_Log_Management"), _
                                                                                             .GUID_Parent = objLocalConfig.SemItem_Type_Timemanagement.GUID, _
                                                                                             .GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID}
            Select Case DataGridView_LogManagement.SelectedCells(0).OwningColumn.DataPropertyName
                case "Name_Log_Management"
                    objFrm_TokenEdit = new frmTokenEdit(objSemItem_TimeManagement,objLocalConfig.Globals)
                    objFrm_TokenEdit.ShowDialog(me)
                    Configure_DataGrid()
                case "Name_LogState_TimeManagement"
                    objFrmSemManager = new frmSemManager(objLocalConfig.SemItem_type_Logstate, objLocalConfig.Globals)
                    If objFrmSemManager.DialogResult=DialogResult.OK Then
                        If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                            If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                Dim objDGVR_Applied = objFrmSemManager.SelectedRows_Items(0)
                                Dim objDRV_Applied As DataRowView = objDGVR_Applied.DataBoundItem

                                If objDRV_Applied.Item("GUID_Type") = objLocalConfig.SemItem_type_Logstate.GUID Then
                                    If objDRV_Applied.Item("GUID_Token") = objLocalConfig.SemItem_Token_Logstate_Work.GUID Or _
                                        objDRV_Applied.Item("GUID_Token") = objLocalConfig.SemItem_Token_Logstate_private.GUID Or _
                                        objDRV_Applied.Item("GUID_Token") = objLocalConfig.SemItem_Token_Logstate_Urlaub.GUID Or _
                                        objDRV_Applied.Item("GUID_Token") = objLocalConfig.SemItem_Token_Logstate_Krank.GUID Then

                                        Dim objSemItem_LogState  = new clsSemItem With {.GUID = objDRV_Applied.Item("GUID_Token"), _
                                                                                        .Name = objDRV_Applied.Item("name_Token"), _
                                                                                        .GUID_Parent = objLocalConfig.SemItem_type_Logstate.GUID, _
                                                                                        .GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID}

                                        Dim objSemItem_Result = objTransaction_TimeManagement.save_006_TimeManagement_To_LogState(objSemItem_LogState, objSemItem_TimeManagement)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objDRV_Selected.Item("GUID_LogState") = objSemItem_LogState.GUID
                                            objDRV_Selected.Item("Name_logState") = objSemItem_LogState.Name
                                        Else
                                            MsgBox("Der LogState Konnte nicht geändert werden")
                                        End If
                                    Else
                                        MsgBox("Bitte nur einen gültigen Logstate auswählen!",MsgBoxStyle.Information)
                                    End If
                                Else 
                                    MsgBox("Bitte nur einen Logstate auswählen!",MsgBoxStyle.Information)
                                End If
                            Else
                                MsgBox("Bitte nur einen Logstate auswählen!",MsgBoxStyle.Information)
                            End If
                        Else
                            MsgBox("Bitte nur einen Logstate auswählen!",MsgBoxStyle.Information)
                        End If
                        
                    End If
                Case "Start"

                Case "Ende"
            End Select
            
        End If
    End Sub

    Private sub ConfigureCalculation(optional menuItem As ToolStripMenuItem = Nothing)
        
        ToolStripDropDownButton_Calc.Text = menuItem.Text
        
        Calculate()
    End Sub

    Private sub Calculate
        Dim calcTest As Double
        Dim calculation As Double = 0
        Dim first As Boolean = True
        If DataGridView_LogManagement.SelectedCells.Count>0 Then
            for each cell As DataGridViewCell in DataGridView_LogManagement.SelectedCells
            If Not Double.TryParse(cell.Value.ToString(),calcTest) Then
                ToolStripTextBox_Calculation.Text = ""
                return
            Else 
                Try
                    If ToolStripDropDownButton_Calc.Text = ToolStripMenuItem_Calc_Mult.Text then
                        If first Then
                            calculation = calcTest
                            first = False
                        Else 
                            calculation = calculation * calcTest
                        End If
                    Elseif ToolStripDropDownButton_Calc.Text = ToolStripMenuItem_CalcAdd.Text or _
                        ToolStripDropDownButton_Calc.Text = ToolStripMenuItem_AVG.Text then
                        calculation = calculation + calcTest
                    End If
                    Catch ex As Exception
                        ToolStripTextBox_Calculation.Text = ""
                        return
                    End Try
                End If
            Next

            If ToolStripDropDownButton_Calc.Text = ToolStripMenuItem_AVG.Text Then
                calculation = calculation / DataGridView_LogManagement.SelectedCells.Count
            End If
            ToolStripTextBox_Calculation.Text = calculation.ToString()
        Else 
            ToolStripTextBox_Calculation.Text = ""
        End If
        
        

        
    End Sub

    Private Sub ToolStripMenuItem_AVG_Click( sender As Object,  e As EventArgs) Handles ToolStripMenuItem_AVG.Click
        ConfigureCalculation(ToolStripMenuItem_AVG)
    End Sub

    Private Sub ToolStripMenuItem_Calc_Mult_Click( sender As Object,  e As EventArgs) Handles ToolStripMenuItem_Calc_Mult.Click
        ConfigureCalculation(ToolStripMenuItem_Calc_Mult)
    End Sub

    Private Sub ToolStripMenuItem_CalcAdd_Click( sender As Object,  e As EventArgs) Handles ToolStripMenuItem_CalcAdd.Click
        ConfigureCalculation(ToolStripMenuItem_CalcAdd)
    End Sub

    Private Sub DataGridView_LogManagement_CellClick( sender As Object,  e As DataGridViewCellEventArgs) Handles DataGridView_LogManagement.CellClick
        Calculate
    End Sub
End Class
