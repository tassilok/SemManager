Imports Sem_Manager
Imports Bank_Transaction_Module
Public Class UserControl_TransactionDetail

    Private objLocalConfig As clsLocalConfig

    Private objThread_Data As Threading.Thread

    Private objFrmSemManager As frmSemManager
    Private objFrmTokenEdit As frmTokenEdit
    Private objFrmBankTransactionModule As frmBankTransactionModule
    Private objUserControl_SemItemList As UserControl_SemItemList
    Private objUserControl_Offset As UserControl_Offset
    Private objDLG_Varchar255 As dlgAttribute_Varchar255
    Private objDLG_Real As dlgAttribute_Real
    Private objDlg_Payment As dlgPayment

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private procA_Payments_of_Transaction As New ds_FinancialTransactionTableAdapters.proc_Payments_of_TransactionTableAdapter
    Private procA_Menge_Of_FinancialTransaction As New ds_FinancialTransactionTableAdapters.proc_Menge_Of_FinancialTransactionTableAdapter

    Private objTransaction_FinancialTransaction As clsTransaction_FinancialTransaction
    Private objSemClipboard As clsSemClipboard

    Private objSemItem_Transaction As clsSemItem
    Private objSemItem_Transaction_Parent As clsSemItem
    Private objSemItem_Clipboard As clsSemItem

    Private semtblA_Currencies As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_Currencies As New ds_SemDB.semtbl_TokenDataTable
    Private semtblA_TaxRates As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_TaxRates As New ds_SemDB.semtbl_TokenDataTable
    Private semtblA_Einheit As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_Einheit As New ds_SemDB.semtbl_TokenDataTable

    Private objDRC_Date As DataRowCollection
    Private objDRC_TransactionID As DataRowCollection
    Private objDRC_Currency As DataRowCollection
    Private procT_Payments_of_Transaction As New ds_FinancialTransaction.proc_Payments_of_TransactionDataTable
    Private objDRC_AmmountPayment As DataRowCollection
    Private objDRC_TaxRate As DataRowCollection
    Private objDRC_Ammount As DataRowCollection
    Private objDRC_Contractee As DataRowCollection
    Private objDRC_Contractor As DataRowCollection
    Private objDRC_Gross As DataRowCollection

    Private objDLG_DateTime As dlgAttribute_Datetime

    Private strCurrency As String

    Private objSemItem_Datedone As clsSemItem
    Private objSemItem_TransactionIDDone As clsSemItem
    Private objSemItem_CurrencyDone As clsSemItem
    Private objSemItem_PaymentsDone As clsSemItem
    Private objSemItem_AmmountPayment As clsSemItem
    Private objSemItem_TaxRate As clsSemItem
    Private objSemItem_Ammount As clsSemItem
    Private objSemItem_Contractee As clsSemItem
    Private objSemItem_Contractor As clsSemItem
    Private objSemItem_Gross As clsSemItem
    Private objSemItem_SemItems As clsSemItem

    Private boolIncome As Boolean
    Private boolPauseThread As Boolean
    Private boolFinished As Boolean

    Public ReadOnly Property isFinished As Boolean
        Get
            Return boolFinished
        End Get
    End Property

    Public ReadOnly Property dateTransaction As Date
        Get
            Dim date_Transaction As Date
            date_Transaction = Nothing
            If boolFinished = True Then
                If objDRC_Date.Count > 0 Then
                    date_Transaction = objDRC_Date(0).Item("Val_Datetime")
                End If
            End If
            Return date_Transaction

        End Get
    End Property

    Public ReadOnly Property ID_Transaction As Integer
        Get
            Dim intID As Integer
            intID = Nothing
            If boolFinished = True Then
                If objDRC_TransactionID.Count > 0 Then
                    intID = objDRC_TransactionID(0).Item("Val_INT")
                End If
            End If
            Return intID
        End Get
    End Property

    Public ReadOnly Property SemItem_Currency As clsSemItem
        Get
            Dim objSemItem_Result As New clsSemItem

            objSemItem_Result = Nothing
            If boolFinished = True Then
                If objDRC_Currency.Count > 0 Then
                    objSemItem_Result = New clsSemItem
                    objSemItem_Result.GUID = objDRC_Currency(0).Item("GUID_Token_Right")
                    objSemItem_Result.Name = objDRC_Currency(0).Item("Name_Token_Right")
                    objSemItem_Result.GUID_Parent = objLocalConfig.SemItem_Type_Currencies.GUID
                    objSemItem_Result.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                End If
            End If

            Return objSemItem_Result
        End Get
    End Property

    Public ReadOnly Property SemItem_Contractor As clsSemItem
        Get
            Dim objSemItem_Result As New clsSemItem
            objSemItem_Result = Nothing
            If boolFinished = True Then
                If objDRC_Contractor.Count > 0 Then
                    objSemItem_Result = New clsSemItem
                    objSemItem_Result.GUID = objDRC_Contractor(0).Item("GUID_Token_Right")
                    objSemItem_Result.Name = objDRC_Contractor(0).Item("Name_Token_Right")
                    objSemItem_Result.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                    objSemItem_Result.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                End If
            End If
            Return objSemItem_Result
        End Get
    End Property

    Public ReadOnly Property SemItem_Contractee As clsSemItem
        Get
            Dim objSemItem_Result As New clsSemItem
            objSemItem_Result = Nothing
            If boolFinished = True Then
                If objDRC_Contractee.Count > 0 Then
                    objSemItem_Result.GUID = objDRC_Contractee(0).Item("GUID_Token_Right")
                    objSemItem_Result.Name = objDRC_Contractee(0).Item("Name_Token_Right")
                    objSemItem_Result.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                    objSemItem_Result.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                End If
            End If
            Return objSemItem_Result
        End Get
    End Property



    Public WriteOnly Property Pause_Thread As Boolean
        Set(ByVal value As Boolean)
            boolPauseThread = value
            Try
                If boolPauseThread = True Then
                    objThread_Data.Suspend()
                Else
                    objThread_Data.Resume()
                End If
            Catch ex As Exception

            End Try
        End Set
    End Property

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
    End Sub

    Public Function initialize(ByVal SemItem_Transaction As clsSemItem, ByVal isIncome As Boolean, Optional ByVal SemItem_Transaction_Parent As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        boolPauseThread = False
        objSemItem_Transaction = SemItem_Transaction
        objSemItem_Transaction_Parent = SemItem_Transaction_Parent

        boolIncome = isIncome
        boolFinished = False
        Panel_Offset.Controls.Clear()

        objUserControl_SemItemList = New UserControl_SemItemList
        objUserControl_SemItemList.Dock = DockStyle.Fill
        objUserControl_Offset = New UserControl_Offset(objLocalConfig)
        objUserControl_Offset.Dock = DockStyle.Fill

        set_DBConnection()
        clear_Controls()
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If Not objSemItem_Transaction Is Nothing Then
            objUserControl_Offset.initialize_Offset(objSemItem_Transaction)
            Panel_Offset.Controls.Add(objUserControl_Offset)

            objSemItem_TransactionIDDone = objLocalConfig.Globals.LogState_Insert
            objSemItem_Ammount = objLocalConfig.Globals.LogState_Insert
            objSemItem_AmmountPayment = objLocalConfig.Globals.LogState_Insert
            objSemItem_Contractee = objLocalConfig.Globals.LogState_Insert
            objSemItem_Contractor = objLocalConfig.Globals.LogState_Insert
            objSemItem_Datedone = objLocalConfig.Globals.LogState_Insert
            objSemItem_PaymentsDone = objLocalConfig.Globals.LogState_Insert
            objSemItem_TaxRate = objLocalConfig.Globals.LogState_Insert
            objSemItem_CurrencyDone = objLocalConfig.Globals.LogState_Insert
            objSemItem_Gross = objLocalConfig.Globals.LogState_Insert
            objSemItem_SemItems = objLocalConfig.Globals.LogState_Insert

            semtblA_Currencies.Fill_Token_TypeChilds(semtblT_Currencies, _
                                                     objLocalConfig.SemItem_Type_Currencies.GUID)
            ComboBox_currency.DataSource = semtblT_Currencies
            ComboBox_currency.ValueMember = "GUID_Token"
            ComboBox_currency.DisplayMember = "Name_Token"
            strCurrency = ComboBox_currency.Text

            semtblA_TaxRates.Fill_Token_TypeChilds(semtblT_TaxRates, _
                                                   objLocalConfig.SemItem_Type_Tax_Rates.GUID)
            ComboBox_TaxRate.DataSource = semtblT_TaxRates
            ComboBox_TaxRate.ValueMember = "GUID_Token"
            ComboBox_TaxRate.DisplayMember = "Name_Token"

            semtblA_Einheit.Fill_Token_TypeChilds(semtblT_Einheit, _
                                                  objLocalConfig.SemItem_Type_Einheit.GUID)
            ComboBox_unit.DataSource = semtblT_Einheit
            ComboBox_unit.ValueMember = "GUID_Token"
            ComboBox_unit.DisplayMember = "Name_Token"
            ProgressBar_ReadData.Visible = True
            objThread_Data = New Threading.Thread(AddressOf get_Data)
            objThread_Data.Start()
            If boolPauseThread = True Then
                Try
                    objThread_Data.Suspend()
                Catch ex As Exception

                End Try

            End If
            Timer_Data.Start()
        Else
            ProgressBar_ReadData.Visible = False
        End If

        Return objSemItem_Result
    End Function

    Private Sub clear_Controls()

        Timer_Data.Stop()
        objDRC_Currency = Nothing
        TextBox_Amount.ReadOnly = True
        TextBox_Contractee.ReadOnly = True
        TextBox_Contractor.ReadOnly = True
        TextBox_Date.ReadOnly = True
        TextBox_Rest.ReadOnly = True
        TextBox_sum.ReadOnly = True
        ComboBox_currency.Enabled = False
        DataGridView_Payment.Enabled = False
        CheckBox_Gross.Enabled = False
        ComboBox_TaxRate.Enabled = False
        ComboBox_unit.Enabled = False
        Button_Contractee.Enabled = False
        Button_Contractor.Enabled = False

        TextBox_Contractee.Text = ""
        TextBox_Contractor.Text = ""
        TextBox_TransactionID.ReadOnly = True
        Button_Date.Enabled = False
        strCurrency = ""

        objDRC_Date = Nothing
        TextBox_Date.Clear()


        objDRC_TransactionID = Nothing

        TextBox_TransactionID.Clear()


        procT_Payments_of_Transaction.Clear()
        DataGridView_Payment.DataSource = Nothing

        Panel_SemItems.Controls.Clear()

        ProgressBar_ReadData.Value = 0
    End Sub

    Private Sub set_DBConnection()
        semtblA_Currencies.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        semtblA_TaxRates.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        semtblA_Einheit.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)

        funcA_TokenToken.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        procA_Payments_of_Transaction.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_Plugin.ConnectionString)
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        procA_Menge_Of_FinancialTransaction.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_Plugin.ConnectionString)

        objTransaction_FinancialTransaction = New clsTransaction_FinancialTransaction(objLocalConfig)
        objSemClipboard = New clsSemClipboard(objLocalConfig.Globals)
    End Sub

    Private Sub get_Data()
        Dim funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
        Dim funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
        Dim procA_Payments_of_Transaction As New ds_FinancialTransactionTableAdapters.proc_Payments_of_TransactionTableAdapter
        Dim procA_Menge_Of_FinancialTransaction As New ds_FinancialTransactionTableAdapters.proc_Menge_Of_FinancialTransactionTableAdapter


        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_Payments_of_Transaction.Connection = objLocalConfig.Connection_Plugin
        procA_Menge_Of_FinancialTransaction.Connection = objLocalConfig.Connection_Plugin

        objDRC_Currency = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Transaction.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belonging_Currency.GUID, _
                                                                        objLocalConfig.SemItem_Type_Currencies.GUID).Rows
        objSemItem_CurrencyDone = objLocalConfig.Globals.LogState_Success

        objDRC_Date = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Transaction.GUID, _
                                                                                                     objLocalConfig.SemItem_Attribute_Transaction_Date.GUID).Rows

        objSemItem_Datedone = objLocalConfig.Globals.LogState_Success



        objDRC_TransactionID = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Transaction.GUID, _
                                                                                                              objLocalConfig.SemItem_Attribute_Transaction_ID.GUID).Rows
        objSemItem_TransactionIDDone = objLocalConfig.Globals.LogState_Success


        procA_Payments_of_Transaction.Fill(procT_Payments_of_Transaction, _
                                                                objLocalConfig.SemItem_Attribute_Valutatag.GUID, _
                                                                objLocalConfig.SemItem_Attribute_Beg_nstigter_Zahlungspflichtiger.GUID, _
                                                                objLocalConfig.SemItem_Attribute_Betrag.GUID, _
                                                                 objLocalConfig.SemItem_Attribute_Amount.GUID, _
                                                                    objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                                    objLocalConfig.SemItem_Attribute_part____.GUID, _
                                                                    objLocalConfig.SemItem_Type_Payment.GUID, _
                                                                    objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse_.GUID, _
                                                                    objLocalConfig.SemItem_Type_Kontonummer.GUID, _
                                                                    objLocalConfig.SemItem_Type_Bankleitzahl.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_Gegenkonto.GUID, _
                                                                    strCurrency, _
                                                                    objSemItem_Transaction.GUID)
        objSemItem_PaymentsDone = objLocalConfig.Globals.LogState_Success

        objDRC_AmmountPayment = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Transaction.GUID, _
                                                                                                               objLocalConfig.SemItem_Attribute_to_Pay.GUID).Rows

        objSemItem_AmmountPayment = objLocalConfig.Globals.LogState_Success

        objDRC_Gross = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Transaction.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_gross.GUID).Rows
        objSemItem_Gross = objLocalConfig.Globals.LogState_Success

        objDRC_TaxRate = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Transaction.GUID, _
                                                                      objLocalConfig.SemItem_RelationType_belonging_Tax_Rate.GUID, _
                                                                      objLocalConfig.SemItem_Type_Tax_Rates.GUID).Rows
        objSemItem_TaxRate = objLocalConfig.Globals.LogState_Success

        objDRC_Ammount = procA_Menge_Of_FinancialTransaction.GetData(objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                                     objLocalConfig.SemItem_Type_Menge.GUID, _
                                                                     objLocalConfig.SemItem_Type_Einheit.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                                     objSemItem_Transaction.GUID).Rows
        objSemItem_Ammount = objLocalConfig.Globals.LogState_Success

        objDRC_Contractee = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Transaction.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                                          objLocalConfig.SemItem_Type_Partner.GUID).Rows

        objSemItem_Contractee = objLocalConfig.Globals.LogState_Success

        objDRC_Contractor = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Transaction.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                                          objLocalConfig.SemItem_Type_Partner.GUID).Rows
        objSemItem_Contractor = objLocalConfig.Globals.LogState_Success

        objSemItem_Transaction.GUID_Relation = objLocalConfig.SemItem_RelationType_belonging_Sem_Item.GUID

        objSemItem_Transaction.Rel_ObjectReference = True
        objSemItem_Transaction.Direction = objSemItem_Transaction.Direction_LeftRight
        objUserControl_SemItemList.initialize_Complex(objSemItem_Transaction, objLocalConfig.Globals)

        objSemItem_SemItems = objLocalConfig.Globals.LogState_Success

    End Sub

    Private Sub Timer_Data_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Data.Tick
        Dim dblRest As Double


        If boolPauseThread = False Then
            Dim boolThreadStop As Boolean = True
            Dim intProgressBar As Integer = 0

            'Transaction-Date
            If objSemItem_Datedone.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                If objDRC_Date.Count > 0 Then
                    TextBox_Date.Text = objDRC_Date(0).Item("Val_Datetime")
                Else
                    TextBox_Date.Text = ""
                End If
                Button_Date.Enabled = True
                intProgressBar = intProgressBar + 1
                objSemItem_Datedone = objLocalConfig.Globals.LogState_Nothing
            ElseIf objSemItem_Datedone.GUID = objLocalConfig.Globals.LogState_Insert.GUID Then
                Button_Date.Enabled = False
                boolThreadStop = False
            End If

            'Transaction-ID
            If objSemItem_TransactionIDDone.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                If objDRC_TransactionID.Count > 0 Then
                    TextBox_TransactionID.ReadOnly = True
                    TextBox_TransactionID.Text = objDRC_TransactionID(0).Item("Val_VARCHAR255")

                Else
                    TextBox_TransactionID.Text = ""
                End If
                intProgressBar = intProgressBar + 1
                TextBox_TransactionID.ReadOnly = False
                objSemItem_TransactionIDDone = objLocalConfig.Globals.LogState_Nothing
            ElseIf objSemItem_TransactionIDDone.GUID = objLocalConfig.Globals.LogState_Insert.GUID Then
                TextBox_TransactionID.ReadOnly = True
                boolThreadStop = False
            End If

            'Currency
            If objSemItem_CurrencyDone.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                If objDRC_Currency.Count > 0 Then
                    ComboBox_currency.SelectedValue = objDRC_Currency(0).Item("GUID_Token_Right")
                End If

                ComboBox_currency.Enabled = True
                intProgressBar = intProgressBar + 1
                objSemItem_CurrencyDone = objLocalConfig.Globals.LogState_Nothing
            ElseIf objSemItem_CurrencyDone.GUID = objLocalConfig.Globals.LogState_Insert.GUID Then
                ComboBox_currency.Enabled = False
                boolThreadStop = False
            End If

            'Amount
            If objSemItem_Ammount.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                TextBox_Amount.ReadOnly = True
                ComboBox_unit.Enabled = False
                If objDRC_Ammount.Count > 0 Then
                    TextBox_Amount.Text = objDRC_Ammount(0).Item("Menge")
                    ComboBox_unit.SelectedValue = objDRC_Ammount(0).Item("GUID_Einheit")
                Else
                    TextBox_Amount.Text = ""
                End If
                ComboBox_unit.Enabled = True
                TextBox_Amount.ReadOnly = False
                intProgressBar = intProgressBar + 1
                objSemItem_Ammount = objLocalConfig.Globals.LogState_Nothing
            ElseIf objSemItem_Ammount.GUID = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolThreadStop = False
                TextBox_Amount.ReadOnly = True

                TextBox_Amount.Text = ""

                TextBox_Amount.ReadOnly = False
            End If

            'Payment
            If objSemItem_AmmountPayment.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_sum.ReadOnly = True
                If objDRC_AmmountPayment.Count > 0 Then
                    TextBox_sum.Text = objDRC_AmmountPayment(0).Item("Val_Real")
                    dblRest = objDRC_AmmountPayment(0).Item("Val_Real")
                    TextBox_Rest.Text = dblRest.ToString("N2") & " " & ComboBox_currency.Text
                    If procT_Payments_of_Transaction.Rows.Count > 0 Then
                        dblRest = objDRC_AmmountPayment(0).Item("Val_Real") - procT_Payments_of_Transaction.Compute("sum(Payment_CleanedAmount)", "")
                        TextBox_Rest.Text = dblRest.ToString("N2") & " " & ComboBox_currency.Text
                    Else
                        TextBox_Rest.Text = ""

                    End If
                    objUserControl_Offset.Amount_Offset1 = objDRC_AmmountPayment(0).Item("Val_Real")
                Else

                    TextBox_Rest.Text = ""
                    TextBox_sum.Text = ""
                    
                    

                End If
                TextBox_sum.ReadOnly = False
                intProgressBar = intProgressBar + 1
                objSemItem_AmmountPayment = objLocalConfig.Globals.LogState_Nothing
            ElseIf objSemItem_AmmountPayment.GUID = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolThreadStop = False
                TextBox_sum.ReadOnly = True
                TextBox_sum.Text = ""
                TextBox_Rest.Text = ""
            End If

            'Gross
            If objSemItem_Gross.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                CheckBox_Gross.Enabled = False
                If objDRC_Gross.Count > 0 Then
                    CheckBox_Gross.Checked = objDRC_Gross(0).Item("Val_Bool")
                Else
                    CheckBox_Gross.Checked = False
                End If

                CheckBox_Gross.Enabled = True
                intProgressBar = intProgressBar + 1
                objSemItem_Gross = objLocalConfig.Globals.LogState_Nothing
            ElseIf objSemItem_Gross.GUID = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolThreadStop = False
                CheckBox_Gross.Enabled = False
                CheckBox_Gross.Checked = False
                CheckBox_Gross.Enabled = True
            End If

            'Contractee
            If objSemItem_Contractee.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                If objDRC_Contractee.Count > 0 Then
                    TextBox_Contractee.Text = objDRC_Contractee(0).Item("Name_Token_Right")
                Else
                    TextBox_Contractee.Text = ""
                End If
                Button_Contractee.Enabled = True
                intProgressBar = intProgressBar + 1
                objSemItem_Contractee = objLocalConfig.Globals.LogState_Nothing
            ElseIf objSemItem_Contractee.GUID = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolThreadStop = False
                TextBox_Contractee.Text = ""
            End If

            'Contractor
            If objSemItem_Contractor.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                If objDRC_Contractor.Count > 0 Then
                    TextBox_Contractor.Text = objDRC_Contractor(0).Item("Name_Token_Right")

                Else
                    TextBox_Contractor.Text = ""
                End If
                Button_Contractor.Enabled = True
                intProgressBar = intProgressBar + 1
                objSemItem_Contractor = objLocalConfig.Globals.LogState_Nothing
            ElseIf objSemItem_Contractor.GUID = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolThreadStop = False
                TextBox_Contractor.Text = ""
            End If

            'Payments
            If objSemItem_PaymentsDone.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                DataGridView_Payment.Enabled = True
                BindingSource_Payments.DataSource = procT_Payments_of_Transaction
                DataGridView_Payment.DataSource = BindingSource_Payments

                DataGridView_Payment.Columns(0).Visible = False
                DataGridView_Payment.Columns(1).Visible = False
                DataGridView_Payment.Columns(2).Visible = False
                DataGridView_Payment.Columns(3).Visible = False
                DataGridView_Payment.Columns(4).Visible = False
                DataGridView_Payment.Columns(5).Visible = False
                DataGridView_Payment.Columns(8).Visible = False
                ''DataGridView_Payment.Columns(7).Visible = False
                DataGridView_Payment.Columns(9).Visible = False
                DataGridView_Payment.Columns(11).Visible = False
                'DataGridView_Payment.Columns(12).Visible = False
                DataGridView_Payment.Columns(13).Visible = False
                DataGridView_Payment.Columns(14).Visible = False
                DataGridView_Payment.Columns(16).Visible = False
                'DataGridView_Payment.Columns(17).Visible = False
                DataGridView_Payment.Columns(18).Visible = False
                DataGridView_Payment.Columns(19).Visible = False
                DataGridView_Payment.Columns(20).Visible = False
                DataGridView_Payment.Columns(22).Visible = False
                DataGridView_Payment.Columns(23).Visible = False
                DataGridView_Payment.Columns(25).Visible = False
                DataGridView_Payment.Columns(26).Visible = False

                intProgressBar = intProgressBar + 1
                objSemItem_PaymentsDone = objLocalConfig.Globals.LogState_Nothing
            ElseIf objSemItem_PaymentsDone.GUID = objLocalConfig.Globals.LogState_Insert.GUID Then
                DataGridView_Payment.DataSource = Nothing
                boolThreadStop = False
            End If

            'TaxRate
            If objSemItem_TaxRate.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                ComboBox_TaxRate.Enabled = False
                If objDRC_TaxRate.Count > 0 Then
                    ComboBox_TaxRate.SelectedValue = objDRC_TaxRate(0).Item("GUID_Token_Right")
                End If
                ComboBox_TaxRate.Enabled = True
                intProgressBar = intProgressBar + 1
                objSemItem_TaxRate = objLocalConfig.Globals.LogState_Nothing
            ElseIf objSemItem_TaxRate.GUID = objLocalConfig.Globals.LogState_Insert.GUID Then
                ComboBox_TaxRate.Enabled = False
                boolThreadStop = False
            End If

            'SemItems
            If objSemItem_SemItems.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                Panel_SemItems.Controls.Clear()
                Panel_SemItems.Controls.Add(objUserControl_SemItemList)
                intProgressBar = intProgressBar + 1
                objSemItem_SemItems = objLocalConfig.Globals.LogState_Nothing
            ElseIf objSemItem_SemItems.GUID = objLocalConfig.Globals.LogState_Insert.GUID Then
                Panel_SemItems.Controls.Clear()
                boolThreadStop = False
            End If


            If boolThreadStop = True Then
                Timer_Data.Stop()
                boolFinished = True
                ProgressBar_ReadData.Value = 0
                ProgressBar_ReadData.Visible = False
            Else
                ProgressBar_ReadData.Value = intProgressBar
            End If
        End If

    End Sub

    Private Sub Button_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Date.Click
        Dim objSemItem_Result As clsSemItem
        If objDRC_Date.Count > 0 Then
            objDLG_DateTime = New dlgAttribute_Datetime(objLocalConfig.SemItem_Attribute_Transaction_Date.Name, objLocalConfig.Globals, objDRC_Date(0).Item("Val_Datetime"))
        Else
            objDLG_DateTime = New dlgAttribute_Datetime(objLocalConfig.SemItem_Attribute_Transaction_Date.Name, objLocalConfig.Globals)
        End If
        objDLG_DateTime.ShowDialog(Me)
        If objDLG_DateTime.DialogResult = Windows.Forms.DialogResult.OK Then

            objSemItem_Result = objTransaction_FinancialTransaction.save_002_TransactionDate(objDLG_DateTime.Value, _
                                                                                             objSemItem_Transaction)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_Date.Text = objDLG_DateTime.Value
            Else
                MsgBox("Das Datum kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                clear_Controls()
                objThread_Data = New Threading.Thread(AddressOf get_Data)
                objThread_Data.Start()
                Timer_Data.Start()
            End If


        End If
    End Sub



    Private Sub TextBox_TransactionID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_TransactionID.TextChanged
        Timer_TransactionID.Stop()
        If TextBox_TransactionID.ReadOnly = False Then
            Timer_TransactionID.Start()
        End If
    End Sub

    Private Sub Timer_TransactionID_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_TransactionID.Tick
        If boolPauseThread = False Then
            Timer_TransactionID.Stop()

            save_TransactionID()
        End If

    End Sub

    Private Sub save_TransactionID()
        Dim strTransactionID As String
        Dim objSemItem_Result As clsSemItem

        strTransactionID = TextBox_TransactionID.Text

        objSemItem_Result = objTransaction_FinancialTransaction.save_003_TransactionID(strTransactionID, _
                                                                                       objSemItem_Transaction)
        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            clear_Controls()
            objThread_Data = New Threading.Thread(AddressOf get_Data)
            objThread_Data.Start()
            Timer_Data.Start()
            MsgBox("Die Transaction-ID kann nicht geändert werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub


    Private Sub ContextMenuStrip_Payment_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Payment.Opening

        NewPaymentToolStripMenuItem.Enabled = False
        ChangePaymentToolStripMenuItem.Enabled = False
        RemovePaymentToolStripMenuItem1.Enabled = False
        ApplyBankTransactionToolStripMenuItem.Enabled = False
        CalculatePercentToolStripMenuItem.Enabled = False
        If Not objSemItem_PaymentsDone Is Nothing Then
            If objSemItem_PaymentsDone.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                NewPaymentToolStripMenuItem.Enabled = True
                If DataGridView_Payment.SelectedRows.Count > 0 Then
                    RemovePaymentToolStripMenuItem1.Enabled = True
                    If DataGridView_Payment.SelectedRows.Count = 1 Then
                        ChangePaymentToolStripMenuItem.Enabled = True
                        ApplyBankTransactionToolStripMenuItem.Enabled = True
                        If TextBox_sum.Text <> "" Then
                            CalculatePercentToolStripMenuItem.Enabled = True
                        End If
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub NewPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPaymentToolStripMenuItem.Click
        Dim objSemItem_Partner As clsSemItem
        Dim dblToPay As Double
        If boolIncome = True Then
            objSemItem_Partner = New clsSemItem
            objSemItem_Partner.GUID = objDRC_Contractor(0).Item("GUID_Token_Right")
            objSemItem_Partner.Name = objDRC_Contractor(0).Item("Name_Token_Right")
            objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
            objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        ElseIf boolIncome = False Then
            objSemItem_Partner = New clsSemItem
            objSemItem_Partner.GUID = objDRC_Contractee(0).Item("GUID_Token_Right")
            objSemItem_Partner.Name = objDRC_Contractee(0).Item("Name_Token_Right")
            objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
            objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        Else
            objSemItem_Partner = Nothing
        End If

        dblToPay = get_ToPay_From_Textbox()
        objDlg_Payment = New dlgPayment(objLocalConfig, _
                                        objSemItem_Transaction, _
                                        ComboBox_currency.Text, _
                                        objSemItem_Partner, _
                                        dblToPay, _
                                        objDRC_Date(0).Item("Val_Datetime"))
        If objDRC_Date.Count > 0 Then

            If Not IsDBNull(objDRC_Date(0).Item("Val_Datetime")) Then
                objDlg_Payment.DateTime_Payment = objDRC_Date(0).Item("Val_Datetime")
            End If
        End If

        objDlg_Payment.ShowDialog(Me)
        If objDlg_Payment.DialogResult = DialogResult.OK Then
            refresh_Payments()
        End If
    End Sub

    Private Function get_ToPay_From_Textbox() As Double
        Dim strToPay As String
        Dim dblToPay As Double

        If TextBox_Rest.Text <> "" Then
            strToPay = TextBox_Rest.Text
            If strToPay.Contains(" ") Then
                strToPay = strToPay.Substring(0, strToPay.IndexOf(" ") - 1)
                If Double.TryParse(strToPay, dblToPay) = False Then
                    dblToPay = -1
                End If
            Else
                dblToPay = -1
            End If
        Else
            dblToPay = -1
        End If
        Return dblToPay
    End Function
    Private Sub refresh_Payments()
        procA_Payments_of_Transaction.Fill(procT_Payments_of_Transaction, _
                                                                 objLocalConfig.SemItem_Attribute_Valutatag.GUID, _
                                                                objLocalConfig.SemItem_Attribute_Beg_nstigter_Zahlungspflichtiger.GUID, _
                                                                objLocalConfig.SemItem_Attribute_Betrag.GUID, _
                                                                 objLocalConfig.SemItem_Attribute_Amount.GUID, _
                                                                    objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                                    objLocalConfig.SemItem_Attribute_part____.GUID, _
                                                                    objLocalConfig.SemItem_Type_Payment.GUID, _
                                                                    objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse_.GUID, _
                                                                    objLocalConfig.SemItem_Type_Kontonummer.GUID, _
                                                                    objLocalConfig.SemItem_Type_Bankleitzahl.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_Gegenkonto.GUID, _
                                                                    strCurrency, _
                                                                    objSemItem_Transaction.GUID)
        BindingSource_Payments.DataSource = procT_Payments_of_Transaction
        DataGridView_Payment.DataSource = BindingSource_Payments
        DataGridView_Payment.Columns(0).Visible = False
        DataGridView_Payment.Columns(1).Visible = False
        DataGridView_Payment.Columns(2).Visible = False
        DataGridView_Payment.Columns(3).Visible = False
        DataGridView_Payment.Columns(4).Visible = False
        DataGridView_Payment.Columns(5).Visible = False
        DataGridView_Payment.Columns(8).Visible = False
        ''DataGridView_Payment.Columns(7).Visible = False
        DataGridView_Payment.Columns(9).Visible = False
        DataGridView_Payment.Columns(11).Visible = False
        'DataGridView_Payment.Columns(12).Visible = False
        DataGridView_Payment.Columns(13).Visible = False
        DataGridView_Payment.Columns(14).Visible = False
        DataGridView_Payment.Columns(16).Visible = False
        'DataGridView_Payment.Columns(17).Visible = False
        DataGridView_Payment.Columns(18).Visible = False
        DataGridView_Payment.Columns(19).Visible = False
        DataGridView_Payment.Columns(20).Visible = False
        DataGridView_Payment.Columns(22).Visible = False
        DataGridView_Payment.Columns(23).Visible = False
        DataGridView_Payment.Columns(25).Visible = False
        DataGridView_Payment.Columns(26).Visible = False


        refresh_Rest()

    End Sub

    Private Sub refresh_Rest()
        TextBox_Rest.Clear()
        Dim dblRest As Double

        If Not objDRC_AmmountPayment Is Nothing Then
            If objDRC_AmmountPayment.Count > 0 Then
                If Not IsDBNull(objDRC_AmmountPayment(0).Item("Val_Real")) Then
                    dblRest = objDRC_AmmountPayment(0).Item("Val_Real")

                    TextBox_Rest.Text = dblRest.ToString("N2") & " " & ComboBox_currency.Text
                    If Not procT_Payments_of_Transaction.Rows.Count = 0 Then
                        dblRest = objDRC_AmmountPayment(0).Item("Val_Real") - procT_Payments_of_Transaction.Compute("sum(Payment_CleanedAmount)", "")
                        TextBox_Rest.Text = dblRest.ToString("N2") & " " & ComboBox_currency.Text
                    Else
                        If MsgBox("Soll ein Payment erzeugt werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            create_FirstPayment()
                        End If
                    End If

                End If
            End If
            
        End If
        
    End Sub
    Private Sub RemovePaymentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemovePaymentToolStripMenuItem1.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Payment As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        For Each objDGVR_Selected In DataGridView_Payment.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Payment.GUID = objDRV_Selected.Item("GUID_Payment")
            objSemItem_Payment.Name = objDRV_Selected.Item("Name_Payment")
            objSemItem_Payment.GUID_Parent = objLocalConfig.SemItem_Type_Payment.GUID
            objSemItem_Payment.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objTransaction_FinancialTransaction.del_016_FinancialTransaction_To_Payment(objSemItem_Payment, objSemItem_Transaction)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_FinancialTransaction.del_015_Payment__TransactionDate(objSemItem_Payment)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_FinancialTransaction.del_014_Payment__Amount(objSemItem_Payment)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_FinancialTransaction.del_013_Payment(objSemItem_Payment)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Das Payment kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Das Payment kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Das Payment kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Das Payment kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
            End If

        Next
        refresh_Payments()
    End Sub

    Private Sub TextBox_sum_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_sum.DoubleClick
        Dim dblSum As Double
        If TextBox_sum.ReadOnly = False Then
            If Double.TryParse(TextBox_sum.Text, dblSum) = False Then
                dblSum = 0
            End If
            objDLG_Real = New dlgAttribute_Real(objLocalConfig.SemItem_Attribute_Betrag.Name, objLocalConfig.Globals)
            objDLG_Real.Value = dblSum
            objDLG_Real.ShowDialog(Me)
            If objDLG_Real.DialogResult = Windows.Forms.DialogResult.OK Then
                TextBox_sum.Text = objDLG_Real.Value
            End If
        End If
    End Sub

    Private Sub TextBox_sum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_sum.TextChanged
        Timer_Sum.Stop()
        If TextBox_sum.ReadOnly = False Then
            Timer_Sum.Start()
        End If
    End Sub

    Private Sub Timer_Sum_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Sum.Tick
        If boolPauseThread = False Then
            Timer_Sum.Stop()
            save_Sum()
        End If

    End Sub
    Private Sub save_Sum()
        Dim dblSum As Double
        Dim objSemItem_Result As clsSemItem

        If Double.TryParse(TextBox_sum.Text, dblSum) = True Then
            objSemItem_Result = objTransaction_FinancialTransaction.save_004_ToPay(dblSum, _
                                                                                   objSemItem_Transaction)
            If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then


                clear_Controls()
                objThread_Data = New Threading.Thread(AddressOf get_Data)
                objThread_Data.Start()
                Timer_Data.Start()
                MsgBox("Die Transaction-ID kann nicht geändert werden!", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Bitte geben Sie nur Fließpunktzahlen ein!", MsgBoxStyle.Exclamation)

        End If
        refresh_Sum()

    End Sub

    Private Sub refresh_Sum()
        get_Data_Sum()
        If objDRC_AmmountPayment.Count > 0 Then
            TextBox_sum.ReadOnly = True
            TextBox_sum.Text = objDRC_AmmountPayment(0).Item("Val_Real")
            TextBox_sum.ReadOnly = False
            refresh_Payments()
            TextBox_sum.SelectionStart = TextBox_sum.Text.Length
        Else
            TextBox_sum.ReadOnly = True
            TextBox_sum.Text = 0
            TextBox_sum.ReadOnly = False
            refresh_Payments()
            TextBox_sum.SelectionStart = TextBox_sum.Text.Length
        End If

    End Sub

    Private Sub get_Data_Sum()
        objDRC_AmmountPayment = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Transaction.GUID, _
                                                                                                               objLocalConfig.SemItem_Attribute_to_Pay.GUID).Rows
    End Sub

    Private Sub ComboBox_currency_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_currency.SelectedIndexChanged
        Dim objSemItem_Currency As New clsSemItem
        Dim objDR_Currency As DataRowView
        Dim objSemItem_Result As clsSemItem

        If ComboBox_currency.Enabled = True Then
            objDR_Currency = ComboBox_currency.SelectedItem
            objSemItem_Currency.GUID = objDR_Currency.Item("GUID_Token")
            objSemItem_Currency.Name = objDR_Currency.Item("Name_Token")
            objSemItem_Currency.GUID_Parent = objDR_Currency.Item("GUID_Type")
            objSemItem_Currency.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objTransaction_FinancialTransaction.save_006_Currency(objSemItem_Currency, objSemItem_Transaction)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Die Währung konnte nicht geändert werden!", MsgBoxStyle.Exclamation)
            End If

            refresh_Currency()
        End If

    End Sub
    Private Sub get_Data_Currency()
        objDRC_Currency = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Transaction.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belonging_Currency.GUID, _
                                                                        objLocalConfig.SemItem_Type_Currencies.GUID).Rows
    End Sub
    Private Sub refresh_Currency()
        get_Data_Currency()
        ComboBox_currency.Enabled = False
        If objDRC_Currency.Count > 0 Then
            ComboBox_currency.SelectedValue = objDRC_Currency(0).Item("GUID_Token_Right")
        End If

        ComboBox_currency.Enabled = True
    End Sub

    Private Sub CheckBox_Gross_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_Gross.CheckedChanged
        Dim objSemItem_Result As clsSemItem
        If CheckBox_Gross.Enabled = True Then
            objSemItem_Result = objTransaction_FinancialTransaction.save_005_Gross(CheckBox_Gross.Checked, objSemItem_Transaction)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Brutto kann nicht geändert werden!", MsgBoxStyle.Exclamation)

            End If
        End If
        refresh_Gross()
    End Sub

    Private Sub refresh_Gross()
        get_Data_Gross()
        CheckBox_Gross.Enabled = False
        If objDRC_Gross.Count > 0 Then
            CheckBox_Gross.Checked = objDRC_Gross(0).Item("Val_Bool")
        Else
            CheckBox_Gross.Checked = False
        End If
        CheckBox_Gross.Enabled = True
    End Sub

    Private Sub get_Data_Gross()
        objDRC_Gross = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Transaction.GUID, _
                                                                                                     objLocalConfig.SemItem_Attribute_gross.GUID).Rows
    End Sub

    Private Sub ComboBox_TaxRate_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_TaxRate.SelectedValueChanged
        If ComboBox_TaxRate.Enabled = True Then
            Dim objDRV_Selected As DataRowView
            Dim objSemItem_TaxRate As New clsSemItem
            Dim objSemItem_Result As clsSemItem

            objDRV_Selected = ComboBox_TaxRate.SelectedItem
            objSemItem_TaxRate.GUID = objDRV_Selected.Item("GUID_Token")
            objSemItem_TaxRate.Name = objDRV_Selected.Item("Name_Token")
            objSemItem_TaxRate.GUID_Parent = objDRV_Selected.Item("GUID_Type")
            objSemItem_TaxRate.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objTransaction_FinancialTransaction.save_012_FinancialTransaction_To_TaxRate(objSemItem_TaxRate, objSemItem_Transaction)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Die Steuerrate konnte nicht geändert werden!", MsgBoxStyle.Exclamation)
            End If
            refresh_TaxRate()
        End If

    End Sub

    Private Sub refresh_TaxRate()
        get_Data_Taxrate()

    End Sub

    Private Sub get_Data_Taxrate()
        objDRC_TaxRate = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Transaction.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belonging_Tax_Rate.GUID, _
                                                                     objLocalConfig.SemItem_Type_Tax_Rates.GUID).Rows

        ComboBox_TaxRate.Enabled = False
        If objDRC_TaxRate.Count > 0 Then
            ComboBox_TaxRate.SelectedValue = objDRC_TaxRate(0).Item("GUID_Token_Right")
        End If
        ComboBox_TaxRate.Enabled = True
    End Sub

    Private Sub TextBox_Amount_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Amount.DoubleClick
        If TextBox_Amount.ReadOnly = False Then
            objDLG_Varchar255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Attribute_Amount.Name, objLocalConfig.Globals)
            objDLG_Varchar255.ShowDialog(Me)
            If objDLG_Varchar255.DialogResult = Windows.Forms.DialogResult.OK Then
                TextBox_Amount.Text = objDLG_Varchar255.Value1
            End If
        End If
    End Sub

    Private Sub TextBox_Amount_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox_Amount.MouseDoubleClick
        Dim dblAmount As Double
        If TextBox_Amount.ReadOnly = False Then
            If Double.TryParse(TextBox_Amount.Text, dblAmount) = False Then
                dblAmount = 0
            End If
            objDLG_Real = New dlgAttribute_Real(objLocalConfig.SemItem_Attribute_Amount.Name, objLocalConfig.Globals)
            objDLG_Real.Value = dblAmount
            objDLG_Real.ShowDialog(Me)
            If objDLG_Real.DialogResult = Windows.Forms.DialogResult.OK Then
                TextBox_sum.Text = objDLG_Real.Value
            End If
        End If
    End Sub

    Private Sub TextBox_Amount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Amount.TextChanged
        Timer_Menge.Stop()
        If TextBox_Amount.ReadOnly = False Then
            Timer_Menge.Start()
        End If
    End Sub

    Private Sub Timer_Menge_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Menge.Tick
        If boolPauseThread = False Then
            Timer_Menge.Stop()
            save_Menge()
        End If

    End Sub

    Private Sub save_Menge()
        Dim dblMenge As Double
        Dim objSemItem_Result As clsSemItem

        If TextBox_Amount.Text <> "" Then
            If Double.TryParse(TextBox_Amount.Text, dblMenge) = True Then
                objSemItem_Result = objTransaction_FinancialTransaction.save_008_Menge(dblMenge, ComboBox_unit.Text)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_FinancialTransaction.save_009_FinancialTransaction_To_Menge(objSemItem_Transaction)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        objTransaction_FinancialTransaction.del_008_Menge()
                        MsgBox("Die Menge konnte nicht geändert werden!", MsgBoxStyle.Exclamation)
                    End If
                Else

                    MsgBox("Die Menge konnte nicht geändert werden!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte nur Fließpunktzahlen für Mengen verwenden!", MsgBoxStyle.Exclamation)
            End If
        End If
        
        refresh_Menge()
    End Sub

    Private Sub refresh_Menge()
        get_Data_Menge()
        TextBox_Amount.ReadOnly = True
        ComboBox_unit.Enabled = False
        If objDRC_Ammount.Count > 0 Then
            TextBox_Amount.Text = objDRC_Ammount(0).Item("Menge")
            ComboBox_unit.SelectedValue = objDRC_Ammount(0).Item("GUID_Einheit")
        Else
            TextBox_Amount.Text = ""
        End If
        ComboBox_unit.Enabled = True
        TextBox_Amount.ReadOnly = False
    End Sub

    Private Sub get_Data_Menge()
        objDRC_Ammount = procA_Menge_Of_FinancialTransaction.GetData(objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                                     objLocalConfig.SemItem_Type_Menge.GUID, _
                                                                     objLocalConfig.SemItem_Type_Einheit.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                                     objSemItem_Transaction.GUID).Rows
    End Sub

    Private Sub ComboBox_unit_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_unit.SelectedIndexChanged
        If ComboBox_unit.Enabled = True Then
            save_Menge()
        End If

    End Sub

    Private Sub Button_Contractee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Contractee.Click
        Dim objSemItem_Partner As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Partner = get_Partner()
        If Not objSemItem_Partner Is Nothing Then
            objSemItem_Result = objTransaction_FinancialTransaction.save_011_FinancialTransaction_To_Contractee(objSemItem_Partner, objSemItem_Transaction)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_Contractee.Text = objSemItem_Partner.Name
            Else
                MsgBox("Der Auftragnehmer kann nicht gesetzt werden!", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Private Function get_Partner() As clsSemItem
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Partner As clsSemItem = Nothing
        Dim boolRelate As Boolean

        objSemItem_Clipboard = objSemClipboard.getFromClipboard(objLocalConfig.Globals.ObjectReferenceType_Token)

        boolRelate = True
        If Not objSemItem_Clipboard Is Nothing Then
            If objSemItem_Clipboard.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID Then
                If MsgBox("Wollen Sie den Partner """ & objSemItem_Clipboard.Name & """ verknüpfen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    objSemItem_Partner = objSemItem_Clipboard
                    boolRelate = False
                End If
            End If
        End If
        If boolRelate = True Then
            objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Partner, objLocalConfig.Globals)
            objFrmSemManager.Applyabale = True
            objFrmSemManager.ShowDialog(Me)
            If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then

                    If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                        objDRV_Selected = objFrmSemManager.SelectedRows_Items(0).DataBoundItem
                        If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Partner.GUID Then
                            objSemItem_Partner = New clsSemItem
                            objSemItem_Partner.GUID = objDRV_Selected.Item("GUID_Token")
                            objSemItem_Partner.Name = objDRV_Selected.Item("Name_Token")
                            objSemItem_Partner.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                            objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        Else
                            MsgBox("Bitte wählen Sie nur Partner aus!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Bitte wählen Sie nur einen Partner aus!", MsgBoxStyle.Exclamation)
                    End If


                Else
                    MsgBox("Bitte wählen Sie nur Partner aus!", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
        

        Return objSemItem_Partner
    End Function

    Private Sub Button_Contractor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Contractor.Click
        Dim objSemItem_Partner As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Partner = get_Partner()
        If Not objSemItem_Partner Is Nothing Then
            objSemItem_Result = objTransaction_FinancialTransaction.save_010_FinancialTransaction_To_Contractor(objSemItem_Partner, objSemItem_Transaction)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_Contractor.Text = objSemItem_Partner.Name
            Else
                MsgBox("Der Auftragnehmer kann nicht gesetzt werden!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub ChangePaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePaymentToolStripMenuItem.Click

    End Sub

    Private Sub ChangePaymentToolStripMenuItem_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChangePaymentToolStripMenuItem.DoubleClick
        Dim objSemItem_Payment As New clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim dblToPay As Double

        If DataGridView_Payment.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Payment.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_Payment.GUID = objDRV_Selected.Item("GUID_Payment")
            objSemItem_Payment.Name = objDRV_Selected.Item("Name_Payment")
            objSemItem_Payment.GUID_Parent = objLocalConfig.SemItem_Type_Payment.GUID
            objSemItem_Payment.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            dblToPay = get_ToPay_From_Textbox()

            objDlg_Payment = New dlgPayment(objLocalConfig, objSemItem_Transaction, strCurrency, objSemItem_Payment, dblToPay, objDRC_Date(0).Item("Val_Datetime"))
            objDlg_Payment.ShowDialog(Me)
            If objDlg_Payment.DialogResult = DialogResult.OK Then
                refresh_Payments()
            End If
        End If
    End Sub

    Private Sub DataGridView_Payment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView_Payment.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                refresh_Payments()
        End Select
    End Sub

    Private Sub DataGridView_Payment_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Payment.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Payment As New clsSemItem

        If DataGridView_Payment.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Payment.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_Payment.GUID = objDRV_Selected.Item("GUID_Payment")
            objSemItem_Payment.Name = objDRV_Selected.Item("Name_Payment")
            objSemItem_Payment.GUID_Parent = objLocalConfig.SemItem_Type_Payment.GUID
            objSemItem_Payment.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objFrmTokenEdit = New frmTokenEdit(objSemItem_Payment, objLocalConfig.Globals)
            objFrmTokenEdit.ShowDialog(Me)
            refresh_Payments()
        End If
    End Sub

    Private Sub ApplyBankTransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyBankTransactionToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Payment As New clsSemItem
        Dim objSemItem_Partner As clsSemItem
        Dim objSemItem_Sparkasse As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        If DataGridView_Payment.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Payment.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Payment.GUID = objDRV_Selected.Item("GUID_Payment")
            objSemItem_Payment.Name = objDRV_Selected.Item("Name_Payment")
            objSemItem_Payment.GUID_Parent = objLocalConfig.SemItem_Type_Payment.GUID
            objSemItem_Payment.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            If boolIncome = True Then
                objSemItem_Partner = New clsSemItem
                objSemItem_Partner.GUID = objDRC_Contractor(0).Item("GUID_Token_Right")
                objSemItem_Partner.Name = objDRC_Contractor(0).Item("Name_Token_Right")
                objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            ElseIf boolIncome = False Then
                objSemItem_Partner = New clsSemItem
                objSemItem_Partner.GUID = objDRC_Contractee(0).Item("GUID_Token_Right")
                objSemItem_Partner.Name = objDRC_Contractee(0).Item("Name_Token_Right")
                objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            Else
                objSemItem_Partner = Nothing
            End If
            If Not objSemItem_Partner Is Nothing Then
                objFrmBankTransactionModule = New frmBankTransactionModule(objLocalConfig.Globals, objSemItem_Partner)
                objFrmBankTransactionModule.Applyable = True
                objFrmBankTransactionModule.MultipleSelect = False
                objFrmBankTransactionModule.ShowDialog(Me)
                If objFrmBankTransactionModule.DialogResult = DialogResult.OK Then
                    objDGVR_Selected = objFrmBankTransactionModule.DGVSRC_Selected(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    objSemItem_Sparkasse.GUID = objDRV_Selected.Item("GUID_Token")
                    objSemItem_Sparkasse.Name = objDRV_Selected.Item("Name_Token")
                    objSemItem_Sparkasse.GUID_Parent = objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse_.GUID
                    objSemItem_Sparkasse.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Result = objTransaction_FinancialTransaction.save_017_Sparkasse_To_Payment(objSemItem_Sparkasse, objSemItem_Payment)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        refresh_Payments()
                    Else
                        MsgBox("Das Payment kann nicht mit der Bank-Transaktion verknüpft werden!", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If

        End If

    End Sub

    Private Sub CalculatePercentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatePercentToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Payment As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        Dim dblPaid As Double
        Dim dblPerc As Double
        Dim dblToPay As Double

        If DataGridView_Payment.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Payment.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            If Not IsDBNull(objDRV_Selected.Item("Ammount")) Then
                dblPaid = objDRV_Selected.Item("Ammount")
                If Double.TryParse(TextBox_sum.Text, dblToPay) Then
                    If dblPaid > 0 Then
                        dblPerc = 100 / dblPaid * dblToPay
                        objSemItem_Payment.GUID = objDRV_Selected.Item("GUID_Payment")
                        objSemItem_Payment.Name = objDRV_Selected.Item("Name_Payment")
                        objSemItem_Payment.GUID_Parent = objLocalConfig.SemItem_Type_Payment.GUID
                        objSemItem_Payment.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_FinancialTransaction.save_018_Payment_PercentPart(dblPerc, objSemItem_Payment)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            refresh_Payments()
                            refresh_Rest()
                        Else
                            MsgBox("Die Prozente konnten nicht berechnet werden.", MsgBoxStyle.Information)
                        End If

                    End If


                End If
            End If
        End If
    End Sub

    
    Private Sub create_FirstPayment()
        Dim objSemItem_Partner As clsSemItem
        Dim dblRest As Double

        If boolIncome = True Then
            objSemItem_Partner = New clsSemItem
            objSemItem_Partner.GUID = objDRC_Contractor(0).Item("GUID_Token_Right")
            objSemItem_Partner.Name = objDRC_Contractor(0).Item("Name_Token_Right")
            objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
            objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        ElseIf boolIncome = False Then
            objSemItem_Partner = New clsSemItem
            objSemItem_Partner.GUID = objDRC_Contractee(0).Item("GUID_Token_Right")
            objSemItem_Partner.Name = objDRC_Contractee(0).Item("Name_Token_Right")
            objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
            objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        Else
            objSemItem_Partner = Nothing
        End If

        If Not objSemItem_Transaction Is Nothing _
            And Not objSemItem_Partner Is Nothing _
            And Not objDRC_Currency.Count = 0 _
            And Not objDRC_AmmountPayment.Count = 0 Then

            get_Data()

            objDlg_Payment = New dlgPayment(objLocalConfig, _
                        objSemItem_Transaction, _
                        ComboBox_currency.Text, _
                        objSemItem_Partner, _
                        objDRC_AmmountPayment(0).Item("Val_Real"), _
                        objDRC_Date(0).Item("Val_Datetime"))

            objDlg_Payment.save_Payment()
            If objDlg_Payment.DialogResult = DialogResult.OK Then
                refresh_Payments()
            End If
            get_Data_Sum()
            If objDRC_AmmountPayment.Count > 0 Then
                TextBox_sum.Text = objDRC_AmmountPayment(0).Item("Val_Real")
                dblRest = objDRC_AmmountPayment(0).Item("Val_Real")
                TextBox_Rest.Text = dblRest.ToString("N2") & " " & ComboBox_currency.Text
                If procT_Payments_of_Transaction.Rows.Count > 0 Then
                    dblRest = objDRC_AmmountPayment(0).Item("Val_Real") - procT_Payments_of_Transaction.Compute("sum(Payment_CleanedAmount)", "")
                    TextBox_Rest.Text = dblRest.ToString("N2") & " " & ComboBox_currency.Text

                End If
                objUserControl_Offset.Amount_Offset1 = objDRC_AmmountPayment(0).Item("Val_Real")
            End If

        End If
    End Sub

End Class
