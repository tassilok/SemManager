Imports Sem_Manager
Public Class frmBankTransactionModule
    Private objLocalConfig As clsLocalConfig
    Private objBankTransaction_Sparkasse As clsBankTransaction

    Private objSemItem_Partner As clsSemItem
    Private objSemItem_ImportSetting As clsSemItem
    Private objSemItem_Konto As clsSemItem

    Private objFrmTokenEdit As frmTokenEdit

    Private objTransaction_BankTransaction As clsTransaction_BankTransaction

    Private objDGVSRC As DataGridViewSelectedRowCollection

    Private fA_Sparkasse_BankTransaktionen As New ds_BankTransactionModuleTableAdapters.f_Sparkasse_BankTransaktionenTableAdapter
    Private fT_Sparkasse_BankTransaktionen As New ds_BankTransactionModule.f_Sparkasse_BankTransaktionenDataTable
    Private pA_ImportSettings_of_Partner As New ds_BankTransactionModuleTableAdapters.p_ImportSettings_of_PartnerTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter

    Private boolMultipleSelect As Boolean
    Private strFilter As String
    Private strColumnName As String
    Private intRowID_Filter As Integer

    Public ReadOnly Property DGVSRC_Selected As DataGridViewSelectedRowCollection
        Get
            Return objDGVSRC
        End Get
        
    End Property

    Public Property MultipleSelect As Boolean
        Get
            Return boolMultipleSelect
        End Get
        Set(ByVal value As Boolean)
            boolMultipleSelect = value
        End Set
    End Property

    Public Property Applyable As Boolean
        Get
            Return ApplyToolStripMenuItem.Visible
        End Get
        Set(ByVal value As Boolean)
            ApplyToolStripMenuItem.Visible = value
        End Set
    End Property



    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        objLocalConfig = New clsLocalConfig(New clsGlobals)
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals, ByVal SemItem_Partner As clsSemItem)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Partner = SemItem_Partner
        objLocalConfig = New clsLocalConfig(Globals)
        initialize()
    End Sub

    Private Sub initialize()
        Dim objSemItem_Result As clsSemItem
        set_DBConnection()
        objSemItem_Result = get_importSettings()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            fill_DataGrid()
        Else
            MsgBox("Die Import-Settings konnten nicht ermittelt werden!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Function get_importSettings() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_ImportSettings As DataRowCollection

        objDRC_ImportSettings = pA_ImportSettings_of_Partner.GetData(objLocalConfig.SemItem_Type_Kontodaten.GUID, _
                                                                     objLocalConfig.SemItem_Type_Kontonummer.GUID, _
                                                                     objLocalConfig.SemItem_Type_Bankleitzahl.GUID, _
                                                                     objLocalConfig.SemItem_Type_Import_Settings.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_provides.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belonging_Banks.GUID, _
                                                                     objSemItem_Partner.GUID).Rows
        If objDRC_ImportSettings.Count > 0 Then
            objSemItem_ImportSetting = New clsSemItem
            objSemItem_ImportSetting.GUID = objDRC_ImportSettings(0).Item("GUID_Import_Settings")
            objSemItem_ImportSetting.Name = objDRC_ImportSettings(0).Item("Name_Import_Settings")
            objSemItem_ImportSetting.GUID_Parent = objLocalConfig.SemItem_Type_Import_Settings.GUID
            objSemItem_ImportSetting.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Konto = New clsSemItem
            objSemItem_Konto.GUID = objDRC_ImportSettings(0).Item("GUID_Bankkonto")
            objSemItem_Konto.Name = objDRC_ImportSettings(0).Item("Name_Bankkonto")
            objSemItem_Konto.GUID_Parent = objLocalConfig.SemItem_Type_Kontonummer.GUID
            objSemItem_Konto.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Private Sub fill_DataGrid()
        If ToolStripMenuItem_Transactions.Checked = True Then
            fA_Sparkasse_BankTransaktionen.Fill(fT_Sparkasse_BankTransaktionen, _
                                            objLocalConfig.SemItem_Attribute_Beg_nstigter_Zahlungspflichtiger.GUID, _
                                            objLocalConfig.SemItem_Attribute_Buchungstext.GUID, _
                                            objLocalConfig.SemItem_Attribute_Verwendungszweck.GUID, _
                                            objLocalConfig.SemItem_Attribute_Info.GUID, _
                                            objLocalConfig.SemItem_Attribute_Zahlungsausgang.GUID, _
                                            objLocalConfig.SemItem_Attribute_Valutatag.GUID, _
                                            objLocalConfig.SemItem_Attribute_Betrag.GUID, _
                                            objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse_.GUID, _
                                            objLocalConfig.SemItem_Type_Currencies.GUID, _
                                            objLocalConfig.SemItem_Type_Alternate_Currency_Name.GUID, _
                                            objLocalConfig.SemItem_Type_Kontonummer.GUID, _
                                            objLocalConfig.SemItem_Type_Bankleitzahl.GUID, _
                                            objLocalConfig.SemItem_Type_Payment.GUID, _
                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                            objLocalConfig.SemItem_RelationType_Auftragskonto.GUID, _
                                            objLocalConfig.SemItem_RelationType_Gegenkonto.GUID, _
                                            objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                            objLocalConfig.SemItem_RelationType_offers.GUID)
        Else
            fA_Sparkasse_BankTransaktionen.Fill(fT_Sparkasse_BankTransaktionen, _
                                            objLocalConfig.SemItem_Attribute_Beg_nstigter_Zahlungspflichtiger.GUID, _
                                            objLocalConfig.SemItem_Attribute_Buchungstext.GUID, _
                                            objLocalConfig.SemItem_Attribute_Verwendungszweck.GUID, _
                                            objLocalConfig.SemItem_Attribute_Info.GUID, _
                                            objLocalConfig.SemItem_Attribute_Zahlungsausgang.GUID, _
                                            objLocalConfig.SemItem_Attribute_Valutatag.GUID, _
                                            objLocalConfig.SemItem_Attribute_Betrag.GUID, _
                                            objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse____Archiv.GUID, _
                                            objLocalConfig.SemItem_Type_Currencies.GUID, _
                                            objLocalConfig.SemItem_Type_Alternate_Currency_Name.GUID, _
                                            objLocalConfig.SemItem_Type_Kontonummer.GUID, _
                                            objLocalConfig.SemItem_Type_Bankleitzahl.GUID, _
                                            objLocalConfig.SemItem_Type_Payment.GUID, _
                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                            objLocalConfig.SemItem_RelationType_Auftragskonto.GUID, _
                                            objLocalConfig.SemItem_RelationType_Gegenkonto.GUID, _
                                            objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                            objLocalConfig.SemItem_RelationType_offers.GUID)
        End If
        

        BindingSource_BankTransactions.DataSource = fT_Sparkasse_BankTransaktionen
        DataGridView_BankTransactions.DataSource = BindingSource_BankTransactions

        DataGridView_BankTransactions.Columns(0).Visible = False
        DataGridView_BankTransactions.Columns(1).Visible = False
        DataGridView_BankTransactions.Columns(2).Visible = False
        DataGridView_BankTransactions.Columns(3).Visible = False
        DataGridView_BankTransactions.Columns(5).Visible = False
        DataGridView_BankTransactions.Columns(7).Visible = False
        DataGridView_BankTransactions.Columns(9).Visible = False
        DataGridView_BankTransactions.Columns(11).Visible = False
        DataGridView_BankTransactions.Columns(13).Visible = False
        DataGridView_BankTransactions.Columns(14).Visible = False
        DataGridView_BankTransactions.Columns(16).Visible = False
        DataGridView_BankTransactions.Columns(17).Visible = False
        DataGridView_BankTransactions.Columns(19).Visible = False
        DataGridView_BankTransactions.Columns(20).Visible = False
        DataGridView_BankTransactions.Columns(22).Visible = False
        DataGridView_BankTransactions.Columns(23).Visible = False
        DataGridView_BankTransactions.Columns(25).Visible = False
        DataGridView_BankTransactions.Columns(26).Visible = False
        DataGridView_BankTransactions.Columns(28).Visible = False
        DataGridView_BankTransactions.Columns(29).Visible = False
        DataGridView_BankTransactions.Columns(31).Visible = False
        DataGridView_BankTransactions.Columns(32).Visible = False
        DataGridView_BankTransactions.Columns(33).Visible = False
        DataGridView_BankTransactions.Columns(35).Visible = False
        DataGridView_BankTransactions.Columns(37).Visible = False

        set_Filter_Konto()
    End Sub

    Private Sub set_Filter_Konto()
        BindingSource_BankTransactions.Filter = get_Filter_Base()
    End Sub

    Private Function get_Filter_Base() As String
        Dim strFilter As String

        strFilter = "GUID_Kontonummer_Auftragskonto='" & objSemItem_Konto.GUID.ToString & "'"
        If ToolStripButton_NoPayment.Checked = True Then
            strFilter = strFilter & " AND GUID_Payment IS NULL"
        End If

        Return strFilter
    End Function

    Private Sub set_DBConnection()
        fA_Sparkasse_BankTransaktionen.Connection = objLocalConfig.Connection_Plugin
        pA_ImportSettings_of_Partner.Connection = objLocalConfig.Connection_Plugin
        objTransaction_BankTransaction = New clsTransaction_BankTransaction(objLocalConfig)
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
    End Sub

    Private Sub ContextMenuStrip_BankTransactions_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_BankTransactions.Opening
        Dim objDGVC As DataGridViewCell
        Dim objDGVCo As DataGridViewColumn

        EqualToolStripMenuItem.Enabled = False
        NotEqualToolStripMenuItem.Enabled = False
        FilterToolStripMenuItem.Enabled = False
        approximateToolStripMenuItem.Enabled = False
        ContainsToolStripMenuItem.Enabled = False
        ClearToolStripMenuItem.Enabled = False
        ApplyToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False
        ArchiveToolStripMenuItem.Enabled = False

        If Not BindingSource_BankTransactions.Filter = get_Filter_Base() Then
            FilterToolStripMenuItem.Enabled = True
            ClearToolStripMenuItem.Enabled = True
        End If

        If DataGridView_BankTransactions.SelectedCells.Count = 1 Then
            FilterToolStripMenuItem.Enabled = True
            objDGVC = DataGridView_BankTransactions.SelectedCells(0)
            EqualToolStripMenuItem.Enabled = True
            NotEqualToolStripMenuItem.Enabled = True
            objDGVCo = DataGridView_BankTransactions.Columns(objDGVC.ColumnIndex)


            Select Case objDGVCo.ValueType
                Case System.Type.GetType("System.Double"), System.Type.GetType("System.Single"), System.Type.GetType("System.Integer")
                    approximateToolStripMenuItem.Enabled = True
                    EqualToolStripMenuItem.Enabled = True
                    NotEqualToolStripMenuItem.Enabled = True
                Case System.Type.GetType("System.Boolean")
                    EqualToolStripMenuItem.Enabled = True
                    NotEqualToolStripMenuItem.Enabled = True
                Case System.Type.GetType("System.String")
                    ContainsToolStripMenuItem.Enabled = True
                    EqualToolStripMenuItem.Enabled = True
                    NotEqualToolStripMenuItem.Enabled = True
                Case Else
                    EqualToolStripMenuItem.Enabled = True
                    NotEqualToolStripMenuItem.Enabled = True

            End Select
        End If

        If boolMultipleSelect = True Then
            If DataGridView_BankTransactions.SelectedRows.Count > 0 Then
                ApplyToolStripMenuItem.Enabled = True

            End If
        Else
            If DataGridView_BankTransactions.SelectedRows.Count = 1 Then
                ApplyToolStripMenuItem.Enabled = True
            End If
        End If

        If DataGridView_BankTransactions.SelectedRows.Count > 0 Then
            DeleteToolStripMenuItem.Enabled = True
            ArchiveToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub EqualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EqualToolStripMenuItem.Click
        Dim objDGVC As DataGridViewCell
        Dim objDGVCo As DataGridViewColumn
        Dim strFilter As String

        If DataGridView_BankTransactions.SelectedCells.Count = 1 Then

            objDGVC = DataGridView_BankTransactions.SelectedCells(0)
            objDGVCo = DataGridView_BankTransactions.Columns(objDGVC.ColumnIndex)

            strFilter = objDGVCo.Name
            Select Case objDGVCo.ValueType
                Case System.Type.GetType("System.Double"), System.Type.GetType("System.Single"), System.Type.GetType("System.Integer")
                    If IsDBNull(DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value) Then
                        strFilter = strFilter & " IS NULL"
                    Else
                        strFilter = strFilter & "=" & DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value.ToString.Replace(",", ".")
                    End If
                    If ToolStripButton_NoPayment.Checked = True Then
                        strFilter = strFilter & " AND GUID_Payment IS NULL"
                    End If
                    BindingSource_BankTransactions.Filter = strFilter
                Case System.Type.GetType("System.Boolean")
                    If IsDBNull(DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value) Then
                        strFilter = strFilter & " IS NULL"
                    Else
                        If DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value = True Then
                            strFilter = strFilter & "=1"
                        Else
                            strFilter = strFilter & "=0"
                        End If
                    End If

                    If ToolStripButton_NoPayment.Checked = True Then
                        strFilter = strFilter & " AND GUID_Payment IS NULL"
                    End If
                    BindingSource_BankTransactions.Filter = strFilter
                Case Else
                    If IsDBNull(DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value) Then
                        strFilter = strFilter & " IS NULL"
                    Else
                        strFilter = strFilter & "='" & DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value & "'"
                    End If
                    If ToolStripButton_NoPayment.Checked = True Then
                        strFilter = strFilter & " AND GUID_Payment IS NULL"
                    End If
                    BindingSource_BankTransactions.Filter = strFilter

            End Select

        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        clear_Filter()
        set_Filter_Konto()
    End Sub

    Private Sub NotEqualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotEqualToolStripMenuItem.Click
        Dim objDGVC As DataGridViewCell
        Dim objDGVCo As DataGridViewColumn
        Dim strFilter As String

        If DataGridView_BankTransactions.SelectedCells.Count = 1 Then

            objDGVC = DataGridView_BankTransactions.SelectedCells(0)
            objDGVCo = DataGridView_BankTransactions.Columns(objDGVC.ColumnIndex)

            strFilter = objDGVCo.Name
            Select Case objDGVCo.ValueType
                Case System.Type.GetType("System.Double"), System.Type.GetType("System.Single"), System.Type.GetType("System.Integer")
                    If IsDBNull(DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value) Then
                        strFilter = "NOT " & strFilter & " IS NULL"
                    Else
                        strFilter = "NOT " & strFilter & "=" & DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value.ToString.Replace(",", ".")
                    End If

                    BindingSource_BankTransactions.Filter = strFilter
                Case System.Type.GetType("System.Boolean")
                    If IsDBNull(DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value) Then
                        strFilter = "NOT " & strFilter & " IS NULL"
                    Else
                        If DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value = True Then
                            strFilter = "NOT " & strFilter & "=1"
                        Else
                            strFilter = "NOT " & strFilter & "=0"
                        End If
                    End If

                    If ToolStripButton_NoPayment.Checked = True Then
                        strFilter = strFilter & " AND GUID_Payment IS NULL"
                    End If
                    BindingSource_BankTransactions.Filter = strFilter
                Case Else
                    If IsDBNull(DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value) Then
                        strFilter = "NOT " & strFilter & " IS NULL"
                    Else
                        strFilter = "NOT " & strFilter & "='" & DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value & "'"
                    End If
                    If ToolStripButton_NoPayment.Checked = True Then
                        strFilter = strFilter & " AND GUID_Payment IS NULL"
                    End If
                    BindingSource_BankTransactions.Filter = strFilter

            End Select

        End If
    End Sub

    Private Sub approximateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles approximateToolStripMenuItem.Click
        Dim objDGVC As DataGridViewCell
        Dim objDGVCo As DataGridViewColumn
        Dim strFilter As String
        Dim dblValue As Double
        Dim dblValue_Start As Double
        Dim dblValue_End As Double

        If DataGridView_BankTransactions.SelectedCells.Count = 1 Then

            objDGVC = DataGridView_BankTransactions.SelectedCells(0)
            objDGVCo = DataGridView_BankTransactions.Columns(objDGVC.ColumnIndex)

            strFilter = objDGVCo.Name
            Select Case objDGVCo.ValueType
                Case System.Type.GetType("System.Double"), System.Type.GetType("System.Single"), System.Type.GetType("System.Integer")
                    dblValue = DataGridView_BankTransactions.Rows(objDGVC.RowIndex).Cells(objDGVCo.Name).Value
                    dblValue_Start = dblValue - 10
                    dblValue_End = dblValue + 10
                    strFilter = strFilter & ">=" & dblValue_Start.ToString.Replace(",", ".") & " AND " & objDGVCo.Name & "<= " & dblValue_End.ToString.Replace(",", ".")
                    BindingSource_BankTransactions.Filter = strFilter


            End Select

        End If
    End Sub

    Private Sub ToolStripTextBox_Equal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Equal.TextChanged
        Timer_Equal.Stop()
        Timer_Equal.Start()
    End Sub

    Private Sub ToolStripTextBox_approximate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_approximate.TextChanged
        Timer_approximate.Stop()
        Timer_approximate.Start()

    End Sub

    Private Sub ToolStripTextBox_Contains_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Contains.TextChanged
        Timer_Contains.Stop()
        Timer_Contains.Start()

    End Sub

    Private Sub ToolStripTextBox_NotEqual_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_NotEqual.TextChanged
        Timer_NotEqual.Stop()
        Timer_NotEqual.Start()
    End Sub

    Private Sub Timer_Equal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Equal.Tick
        Dim strText As String
        Timer_Equal.Stop()


        Dim objDGVC As DataGridViewCell
        Dim objDGVCo As DataGridViewColumn
        Dim strFilter As String


        strText = ToolStripTextBox_Equal.Text
        If DataGridView_BankTransactions.SelectedCells.Count = 1 Then

            objDGVC = DataGridView_BankTransactions.SelectedCells(0)
            objDGVCo = DataGridView_BankTransactions.Columns(objDGVC.ColumnIndex)

            strFilter = objDGVCo.Name
            If strText = "" Then
                set_Filter_Konto()
            Else
                Select Case objDGVCo.ValueType
                    Case System.Type.GetType("System.Double"), System.Type.GetType("System.Single"), System.Type.GetType("System.Integer")
                        If strText.ToLower = "null" Then
                            strFilter = strFilter & " IS NULL"
                        Else
                            strFilter = strFilter & "=" & strText
                        End If
                        If ToolStripButton_NoPayment.Checked = True Then
                            strFilter = strFilter & " AND GUID_Payment IS NULL"
                        End If
                        BindingSource_BankTransactions.Filter = strFilter
                    Case System.Type.GetType("System.Boolean")
                        If strText.ToLower = "null" Then
                            strFilter = strFilter & " IS NULL"
                        Else
                            If strText.ToLower = "1" Or strText.ToLower = "true" Then
                                strFilter = strFilter & "=1"
                            ElseIf strText.ToLower = "0" Or strText.ToLower = "false" Then
                                strFilter = strFilter & "=0"
                            Else
                                ToolStripTextBox_Equal.Text = ""
                            End If
                        End If

                        If ToolStripButton_NoPayment.Checked = True Then
                            strFilter = strFilter & " AND GUID_Payment IS NULL"
                        End If
                        BindingSource_BankTransactions.Filter = strFilter
                    Case Else
                        If strText.ToLower = "null" Then
                            strFilter = strFilter & " IS NULL"
                        Else
                            strFilter = strFilter & "='" & strText.Replace("'", "''") & "'"
                        End If
                        If ToolStripButton_NoPayment.Checked = True Then
                            strFilter = strFilter & " AND GUID_Payment IS NULL"
                        End If
                        BindingSource_BankTransactions.Filter = strFilter
                End Select
            End If


        End If

    End Sub

    Private Sub Timer_NotEqual_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_NotEqual.Tick
        Dim strText As String
        Timer_NotEqual.Stop()


        Dim objDGVC As DataGridViewCell
        Dim objDGVCo As DataGridViewColumn
        Dim strFilter As String


        strText = ToolStripTextBox_NotEqual.Text
        If DataGridView_BankTransactions.SelectedCells.Count = 1 Then

            objDGVC = DataGridView_BankTransactions.SelectedCells(0)
            objDGVCo = DataGridView_BankTransactions.Columns(objDGVC.ColumnIndex)

            strFilter = objDGVCo.Name
            If strText = "" Then
                set_Filter_Konto()
            Else
                Select Case objDGVCo.ValueType
                    Case System.Type.GetType("System.Double"), System.Type.GetType("System.Single"), System.Type.GetType("System.Integer")
                        If strText.ToLower = "null" Then
                            strFilter = strFilter & " IS NOT NULL"
                        Else
                            strFilter = "NOT " & strFilter & "=" & strText
                        End If

                        BindingSource_BankTransactions.Filter = strFilter
                    Case System.Type.GetType("System.Boolean")
                        If strText.ToLower = "null" Then
                            strFilter = strFilter & " IS NOT NULL"
                        Else
                            If strText.ToLower = "1" Or strText.ToLower = "true" Then
                                strFilter = "NOT " & strFilter & "=1"
                            ElseIf strText.ToLower = "0" Or strText.ToLower = "false" Then
                                strFilter = "NOT " & strFilter & "=0"
                            Else
                                ToolStripTextBox_Equal.Text = ""
                            End If
                        End If

                        If ToolStripButton_NoPayment.Checked = True Then
                            strFilter = strFilter & " AND GUID_Payment IS NULL"
                        End If
                        BindingSource_BankTransactions.Filter = strFilter
                    Case Else
                        If strText.ToLower = "null" Then
                            strFilter = strFilter & " IS NOT NULL"
                        Else
                            strFilter = "NOT " & strFilter & "='" & strText.Replace("'", "''") & "'"
                        End If
                        If ToolStripButton_NoPayment.Checked = True Then
                            strFilter = strFilter & " AND GUID_Payment IS NULL"
                        End If
                        BindingSource_BankTransactions.Filter = strFilter
                End Select
            End If


        End If

    End Sub

    Private Sub Timer_approximate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_approximate.Tick
        Dim strText As String
        Timer_approximate.Stop()


        Dim objDGVC As DataGridViewCell
        Dim objDGVCo As DataGridViewColumn
        Dim dblFilter1 As Double
        Dim dblFilter2 As Double
        Dim strFilter As String
        Dim strTexts() As String


        strText = ToolStripTextBox_approximate.Text
        If DataGridView_BankTransactions.SelectedCells.Count = 1 Then

            objDGVC = DataGridView_BankTransactions.SelectedCells(0)
            objDGVCo = DataGridView_BankTransactions.Columns(objDGVC.ColumnIndex)

            strFilter = objDGVCo.Name
            If strText = "" Then
                set_Filter_Konto()
            Else
                Select Case objDGVCo.ValueType
                    Case System.Type.GetType("System.Double"), System.Type.GetType("System.Single"), System.Type.GetType("System.Integer")
                        strTexts = strText.Split(" ")
                        If Double.TryParse(strTexts(0), dblFilter1) = True Then
                            If Double.TryParse(strTexts(1), dblFilter2) = True Then

                                strFilter = strFilter & ">=" & dblFilter1 & " AND " & objDGVCo.Name & "<=" & dblFilter2
                                If ToolStripButton_NoPayment.Checked = True Then
                                    strFilter = strFilter & " AND GUID_Payment IS NULL"
                                End If
                                BindingSource_BankTransactions.Filter = strFilter
                            Else
                                ToolStripTextBox_approximate.Text = ""
                            End If
                        Else
                            ToolStripTextBox_approximate.Text = ""
                        End If
                End Select
            End If


        End If
    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        If boolMultipleSelect = True Then
            If DataGridView_BankTransactions.SelectedRows.Count > 0 Then
                objDGVSRC = DataGridView_BankTransactions.SelectedRows
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            If DataGridView_BankTransactions.SelectedRows.Count = 1 Then
                objDGVSRC = DataGridView_BankTransactions.SelectedRows
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
        
    End Sub

    Private Sub ToolStripButton_Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Import.Click
        objBankTransaction_Sparkasse = New clsBankTransaction(objLocalConfig, objSemItem_Partner)


    End Sub

    Private Sub ToolStripButton_NoPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_NoPayment.Click
        
        fill_DataGrid()
    End Sub

    Private Sub Timer_Contains_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Contains.Tick
        Dim strText As String
        Timer_Contains.Stop()


        Dim objDGVC As DataGridViewCell
        Dim objDGVCo As DataGridViewColumn
        Dim strFilter As String


        strText = ToolStripTextBox_Contains.Text
        If DataGridView_BankTransactions.SelectedCells.Count = 1 Then

            objDGVC = DataGridView_BankTransactions.SelectedCells(0)
            objDGVCo = DataGridView_BankTransactions.Columns(objDGVC.ColumnIndex)

            strFilter = objDGVCo.Name
            If strText = "" Then
                set_Filter_Konto()
            Else
                Select Case objDGVCo.ValueType
                    Case System.Type.GetType("System.Double"), System.Type.GetType("System.Single"), System.Type.GetType("System.Integer")
                    

                        MsgBox("Bitte nur Texte", MsgBoxStyle.Exclamation)
                        ToolStripTextBox_Contains.Text = ""
                    Case System.Type.GetType("System.Boolean")
                        MsgBox("Bitte nur Texte", MsgBoxStyle.Exclamation)
                        ToolStripTextBox_Contains.Text = ""
                    Case Else
                        If strText.ToLower = "null" Then
                            strFilter = strFilter & " IS NULL"
                        Else
                            strFilter = strFilter & " LIKE '%" & strText.Replace("'", "''") & "%'"
                        End If
                        If ToolStripButton_NoPayment.Checked = True Then
                            strFilter = strFilter & " AND GUID_Payment IS NULL"
                        End If
                        BindingSource_BankTransactions.Filter = strFilter
                End Select
            End If


        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim objSelCell As DataGridViewCell
        Dim strToCopy As String

        strToCopy = ""
        For Each objSelCell In DataGridView_BankTransactions.SelectedCells
            If Not strToCopy = "" Then
                strToCopy = vbCrLf & strToCopy
            End If
            strToCopy = strToCopy + CStr(objSelCell.Value.ToString)
        Next
        Clipboard.SetDataObject(strToCopy)
    End Sub

    Private Sub DataGridView_BankTransactions_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView_BankTransactions.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                fill_DataGrid()
            Case Else
                Timer_Filter.Stop()
                Timer_ClearFilter.Stop()
                If test_Filter() = True Then
                    If e.KeyData > 31 And e.KeyData < 256 Then
                        strFilter = strFilter + Chr(e.KeyData)
                        Timer_Filter.Start()
                    End If
                    
                End If
                'Timer_ClearFilter.Start()

        End Select
    End Sub

    Private Function test_Filter() As Boolean
        Dim boolResult As Boolean
        intRowID_Filter = BindingSource_BankTransactions.Position
        If strFilter = "" Then
            If DataGridView_BankTransactions.SelectedCells.Count = 1 Then
                strColumnName = DataGridView_BankTransactions.Columns(DataGridView_BankTransactions.SelectedCells(0).ColumnIndex).Name
                boolResult = True
            Else
                strFilter = ""
                strColumnName = ""
                boolResult = False
            End If
        Else
            If DataGridView_BankTransactions.SelectedCells.Count = 1 Then
                If strColumnName = DataGridView_BankTransactions.Columns(DataGridView_BankTransactions.SelectedCells(0).ColumnIndex).Name Then
                    boolResult = True
                Else
                    strColumnName = DataGridView_BankTransactions.Columns(DataGridView_BankTransactions.SelectedCells(0).ColumnIndex).Name

                    strFilter = ""
                    boolResult = True
                End If
            Else
                strColumnName = ""
                strFilter = ""
                boolResult = False
            End If
        End If

        Return boolResult
    End Function

    Private Sub DataGridView_BankTransactions_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_BankTransactions.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Selected As New clsSemItem

        objDGVR_Selected = DataGridView_BankTransactions.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_Token")
        objSemItem_Selected.Name = objDRV_Selected.Item("Name_Token")
        objSemItem_Selected.GUID_Parent = objDRV_Selected.Item("GUID_Type")
        objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrmTokenEdit = New frmTokenEdit(objSemItem_Selected, objLocalConfig.Globals)
        objFrmTokenEdit.ShowDialog(Me)
        fill_DataGrid()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_Payment As DataRowCollection
        Dim objSemItem_Transaction As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intDone As Integer
        Dim intToDo As Integer

        intToDo = DataGridView_BankTransactions.SelectedRows.Count
        intDone = 0

        For Each objDGVR_Selected In DataGridView_BankTransactions.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Transaction.GUID = objDRV_Selected.Item("GUID_Token")
            objSemItem_Transaction.Name = objDRV_Selected.Item("Name_Token")
            objSemItem_Transaction.GUID_Parent = objDRV_Selected.Item("GUID_Type")
            objSemItem_Transaction.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_Payment = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Transaction.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                           objLocalConfig.SemItem_Type_Payment.GUID).Rows
            If objDRC_Payment.Count = 0 Then
                objSemItem_Result = objTransaction_BankTransaction.del_014_BankTransaction_To_Gegenkonto(Nothing, objSemItem_Transaction)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_BankTransaction.del_010_BankTransaction_To_Currency()
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_BankTransaction.del_009_Verwendungszweck_Of_BankTransaction()
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_BankTransaction.del_008_Buchungstext_Of_BankTransaction()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_BankTransaction.del_007_Betrag_Of_BankTransaction()
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_BankTransaction.del_006_BegZahl_Of_BankTransaction()
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_BankTransaction.del_005_Zahlungsausgang_Of_BankTransaction()
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_BankTransaction.del_004_Valutadatum_Of_BankTransaction()
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_BankTransaction.del_003_Info_Of_BankTransaction()
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto()
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_BankTransaction.del_001_BankTransaction()
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            intDone = intDone + 1
                                                        End If
                                                    Else

                                                    End If
                                                Else

                                                End If
                                            Else

                                            End If
                                        Else

                                        End If
                                    Else

                                    End If
                                Else

                                End If
                            Else

                            End If
                        Else

                        End If
                    Else

                    End If
                Else

                End If

            End If
        Next
        If intDone < intToDo Then
            MsgBox("Es konnten nur " & intDone & " Transaktionen von " & intToDo & " gelöscht werden!", MsgBoxStyle.Information)
        End If
        fill_DataGrid()
    End Sub

    Private Sub ArchiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiveToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_LogState As DataRowCollection
        Dim GUID_Type As Guid
        Dim intToDo As Integer
        Dim intDone As Integer

        If DataGridView_BankTransactions.SelectedRows.Count > 0 Then
            intToDo = DataGridView_BankTransactions.SelectedRows.Count
            intDone = 0
            For Each objDGVR_Selected In DataGridView_BankTransactions.SelectedRows
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse_.GUID Then
                    GUID_Type = objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse____Archiv.GUID
                Else
                    GUID_Type = objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse_.GUID
                End If
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objDRV_Selected.Item("GUID_Token"), _
                                                                     objDRV_Selected.Item("Name_Token"), _
                                                                     GUID_Type, True).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    intDone = intDone + 1
                End If

            Next
            If intDone < intToDo Then
                MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Transaktionen archiviert werden!", MsgBoxStyle.Exclamation)
            End If
            fill_DataGrid()
        End If
        
    End Sub

    Private Sub ToolStripMenuItem_Transactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_Transactions.Click
        ToolStripMenuItem_Transactions.Checked = True
        ToolStripMenuItem_Archive.Checked = False
        fill_DataGrid()
    End Sub

    Private Sub ToolStripMenuItem_Archive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_Archive.Click
        ToolStripMenuItem_Transactions.Checked = False
        ToolStripMenuItem_Archive.Checked = True
        fill_DataGrid()
    End Sub

    Private Sub Timer_Filter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Filter.Tick
        Timer_Filter.Stop()
        Dim boolFound As Boolean

        boolFound = False

        While boolFound = False
            If BindingSource_BankTransactions.Position = DataGridView_BankTransactions.RowCount - 1 Then
                MsgBox("Das Ende der Liste wurde erreiche!", MsgBoxStyle.Information)
                BindingSource_BankTransactions.Position = 0
            Else
                BindingSource_BankTransactions.Position = BindingSource_BankTransactions.Position + 1
            End If

            If Not strFilter = "" Then
                If DataGridView_BankTransactions.Rows(intRowID_Filter).Cells(strColumnName).Value.ToString().StartsWith(strFilter) Then
                    boolFound = True
                End If
            Else
                boolFound = True
            End If
        End While
        

    End Sub

    Private Sub DataGridView_BankTransactions_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_BankTransactions.SelectionChanged
        If DataGridView_BankTransactions.SelectedColumns.Count = 1 Then
            If Not DataGridView_BankTransactions.SelectedColumns(0).Name = strColumnName Then
                clear_Filter()
            End If
        Else
            clear_Filter()
        End If
    End Sub

    Private Sub clear_Filter()
        strFilter = ""
        Timer_Filter.Stop()
        intRowID_Filter = 0
        strColumnName = ""
    End Sub

    Private Sub Timer_ClearFilter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_ClearFilter.Tick
        clear_Filter()
    End Sub
End Class
