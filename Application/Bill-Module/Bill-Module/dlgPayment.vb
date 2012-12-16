Imports System.Windows.Forms
Imports Bank_Transaction_Module
Imports Sem_Manager
Public Class dlgPayment

    Private objTransaction_FinancialTransaction As clsTransaction_FinancialTransaction
    Private objUserControl_Attribute_DateTime As UserControl_Attribute_Datetime
    Private objFrmBankTransactionModule As frmBankTransactionModule
    Private procA_Payment As New ds_FinancialTransactionTableAdapters.proc_PaymentTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private objLocalConfig As clsLocalConfig

    Private objSemItem_FinancialTransaction As clsSemItem
    Private objSemItem_Payment As clsSemItem
    Private objSemItem_Sparkasse As New clsSemItem
    Private objSemItem_Partner As clsSemItem

    Private objSemItem_Result As clsSemItem

    Private strCurrency As String
    Private dblToPay As Double
    Private datePayment As Date

    Public WriteOnly Property DateTime_Payment As DateTime
        Set(ByVal value As DateTime)
            objUserControl_Attribute_DateTime.Value = value
        End Set
    End Property
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub set_DBConnction()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_Payment.Connection = objLocalConfig.Connection_Plugin
        objTransaction_FinancialTransaction = New clsTransaction_FinancialTransaction(objLocalConfig)
        objFrmBankTransactionModule = New frmBankTransactionModule(objLocalConfig.Globals, objSemItem_Partner)
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_FinancialTransaction As clsSemItem, ByVal Name_Currency As String, ByVal SemItem_Partner As clsSemItem, ByVal dbl_ToPay As Double, ByVal dateTransaction As Date, Optional ByVal SemItem_Payment As clsSemItem = Nothing)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        Me.dblToPay = dbl_ToPay
        objSemItem_Partner = SemItem_Partner
        objSemItem_FinancialTransaction = SemItem_FinancialTransaction
        objSemItem_Payment = SemItem_Payment
        datePayment = dateTransaction
        strCurrency = Name_Currency
        initialize()
    End Sub


    Private Sub initialize()
        Dim objDRC_Payment As DataRowCollection
        set_DBConnction()

        objSemItem_Sparkasse = Nothing


        TextBox_PercPart.Text = "100"
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If Not objSemItem_Payment Is Nothing Then
            objDRC_Payment = procA_Payment.GetData(objLocalConfig.SemItem_Attribute_Amount.GUID, _
                                                   objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                   objLocalConfig.SemItem_Type_Payment.GUID, _
                                                   objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                   strCurrency, _
                                                   objSemItem_FinancialTransaction.GUID, _
                                                   objSemItem_Payment.GUID).Rows
            If objDRC_Payment.Count = 0 Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            Else
                dblToPay = objDRC_Payment(0).Item("Amount")
                datePayment = objDRC_Payment(0).Item("TransactionDate")

            End If
        End If


        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objUserControl_Attribute_DateTime = New UserControl_Attribute_Datetime()
            objUserControl_Attribute_DateTime.Dock = Windows.Forms.DockStyle.Fill
            objUserControl_Attribute_DateTime.Value = datePayment
            Panel_Datetime.Controls.Add(objUserControl_Attribute_DateTime)
            Label_Currency.Text = strCurrency
            TextBox_Amount.Text = dblToPay
        End If


    End Sub

    Private Sub ToolStripButton_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_OK.Click        
        save_Payment()
    End Sub

    Public Sub save_Payment()
        Dim dateTransactionTimeStamp As Date
        Dim dblAmount As Double
        Dim dblPercent As Double
        Dim objSemItem_Result As clsSemItem
        If Double.TryParse(TextBox_PercPart.Text, dblPercent) = True Then
            If dblPercent > 0 Then
                If Double.TryParse(TextBox_Amount.Text, dblAmount) = True Then
                    dateTransactionTimeStamp = objUserControl_Attribute_DateTime.Value
                    objSemItem_Result = save_Payment(dblAmount, dblPercent, dateTransactionTimeStamp)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        DialogResult = Windows.Forms.DialogResult.OK
                        Me.Hide()
                    Else

                        MsgBox("Das Payment konnte nicht erzeugt bzw. geändet werden!", MsgBoxStyle.Exclamation)
                        DialogResult = Windows.Forms.DialogResult.Cancel
                        Me.Hide()
                    End If
                Else
                    MsgBox("Bitte überprüfen Sie den Betrag!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte Geben Sie einen Anteil > 0 ein!", MsgBoxStyle.Exclamation)
            End If

        Else
            MsgBox("Bitte Geben Sie einen Anteil ein!", MsgBoxStyle.Exclamation)
        End If

    End Sub
    Private Function save_Payment(ByVal dblAmount As Double, ByVal dblPercent As Double, ByVal dateTransactionTimeStamp As Date) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intOrderID As Integer

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If objSemItem_Payment Is Nothing Then
            intOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_FinancialTransaction.GUID, _
                                                                         objLocalConfig.SemItem_Type_Payment.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_belonging_Payment.GUID) + 1
            objSemItem_Payment = New clsSemItem
            objSemItem_Payment.GUID = Guid.NewGuid
            objSemItem_Payment.Name = objLocalConfig.SemItem_Type_Payment.Name & " " & intOrderID
            objSemItem_Payment.GUID_Parent = objLocalConfig.SemItem_Type_Payment.GUID
            objSemItem_Payment.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Payment.new_Item = True
            objSemItem_Result = objTransaction_FinancialTransaction.save_013_Payment(objSemItem_Payment)

        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_FinancialTransaction.save_014_Payment__Amount(dblAmount)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_FinancialTransaction.save_015_Payment__TransactionDate(dateTransactionTimeStamp)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_FinancialTransaction.save_016_FinancialTransaction_To_Payment(objSemItem_Payment, objSemItem_FinancialTransaction)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_FinancialTransaction.save_018_Payment_PercentPart(dblPercent, objSemItem_Payment)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            If Not objSemItem_Sparkasse Is Nothing Then
                                objSemItem_Result = objTransaction_FinancialTransaction.save_017_Sparkasse_To_Payment(objSemItem_Sparkasse)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                    objSemItem_Result = objTransaction_FinancialTransaction.del_018_Payment_PercentPart
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_FinancialTransaction.del_016_FinancialTransaction_To_Payment
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_FinancialTransaction.del_015_Payment__TransactionDate
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_FinancialTransaction.del_014_Payment__Amount
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objTransaction_FinancialTransaction.del_013_Payment()
                                                End If
                                            End If
                                        End If

                                    End If
                                    

                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                End If
                            End If
                        Else
                            objSemItem_Result = objTransaction_FinancialTransaction.del_016_FinancialTransaction_To_Payment
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_FinancialTransaction.del_015_Payment__TransactionDate
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_FinancialTransaction.del_014_Payment__Amount
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_FinancialTransaction.del_013_Payment()
                                    End If
                                End If
                            End If
                            

                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If



                    Else

                        objSemItem_Result = objTransaction_FinancialTransaction.del_015_Payment__TransactionDate
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_FinancialTransaction.del_014_Payment__Amount
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_FinancialTransaction.del_013_Payment()
                            End If
                        End If

                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objTransaction_FinancialTransaction.del_014_Payment__Amount
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objTransaction_FinancialTransaction.del_013_Payment()
                    End If
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                If objSemItem_Payment.new_Item = True Then
                    objTransaction_FinancialTransaction.del_013_Payment()

                End If
            End If
        End If

        Return objSemItem_Result
    End Function

    Private Sub ToolStripButton_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Cancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Hide()
    End Sub

    Private Sub dlgPayment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Das Payment konnte nicht ermittelt werden!", MsgBoxStyle.Critical)
            DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub Button_GetBankTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_GetBankTransaction.Click
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView


        objFrmBankTransactionModule.Applyable = True
        objFrmBankTransactionModule.MultipleSelect = False
        objFrmBankTransactionModule.ShowDialog(Me)
        If objFrmBankTransactionModule.DialogResult = Windows.Forms.DialogResult.OK Then
            objDGVR = objFrmBankTransactionModule.DGVSRC_Selected(0)
            objDRV = objDGVR.DataBoundItem
            objSemItem_Sparkasse = New clsSemItem
            objSemItem_Sparkasse.GUID = objDRV.Item("GUID_Token")
            objSemItem_Sparkasse.Name = objDRV.Item("Name_Token")
            objSemItem_Sparkasse.GUID_Parent = objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse_.GUID
            objSemItem_Sparkasse.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            TextBox_BankTransaction.Text = objSemItem_Sparkasse.Name
            TextBox_Amount.Text = objDRV.Item("Betrag")
            objUserControl_Attribute_DateTime.Value = objDRV.Item("Valutatag")
        Else
            objSemItem_Sparkasse = Nothing
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        objSemItem_Sparkasse = Nothing
        TextBox_BankTransaction.Clear()
    End Sub

    Private Sub Button_Calc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Calc.Click
        Dim dblPayment As Double
        Dim dblPercent As Double
        If Not dblToPay = -1 Then
            If Double.TryParse(TextBox_Amount.Text, dblPayment) = True Then
                dblPercent = 100 / dblPayment * dblToPay
                TextBox_PercPart.Text = dblPercent
            Else
                MsgBox("Der Wert kann nicht berechnet werden, weil der Betrag nicht erkannt wird", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Der Wert kann nicht berechnet werden, weil nicht bekannt ist, wie viel zu zahlen ist!", MsgBoxStyle.Information)
        End If
    End Sub
End Class
