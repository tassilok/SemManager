Imports Sem_Manager
Imports Bank_Transaction_Module
Public Class frmBillModule
    Private Const cint_ImageID_Bill As Integer = 0
    Private Const cint_ImageID_PartialBill As Integer = 1
    Private Const cint_ImageID_Position As Integer = 2
    Private Const cint_ImageID_Unzugeordnet As Integer = 3
    Private Const cint_ImageID_Mandant As Integer = 4
    Private Const cint_ImageID_Ausgaben As Integer = 5
    Private Const cint_ImageID_Einnahmen As Integer = 6
    Private Const cint_ImageID_Root As Integer = 7
    Private Const cint_ImageID_BillSelected As Integer = 8

    Private Const cstr_Ausgaben As String = "Ausgaben"
    Private Const cstr_Einnahmen As String = "Einnahmen"

    Private objUserControl_TransactionDetails As UserControl_TransactionDetail
    Private objUserControl_Documents As UserControl_Documents
    Private objFrmTokenEdit As frmTokenEdit
    Private objFrmBankTransactionModule As frmBankTransactionModule
    Private objDlgAttribute_VARCHAR255 As dlgAttribute_Varchar255

    Private objTransaction_FinancialTransaction As clsTransaction_FinancialTransaction

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private semtblA_SearchTemplates As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semtblT_SearchTemplates As New ds_Token.func_TokenTokenDataTable

    Private procA_FinancialTransaction_Contractee As New ds_FinancialTransactionTableAdapters.proc_FinancialTransaction_ContracteeTableAdapter
    Private procT_FinancialTransaction_Contractee As New ds_FinancialTransaction.proc_FinancialTransaction_ContracteeDataTable

    Private procA_FinancialTransaction_Contractor As New ds_FinancialTransactionTableAdapters.proc_FinancialTransaction_ContractorTableAdapter
    Private procT_FinancialTransaction_Contractor As New ds_FinancialTransaction.proc_FinancialTransaction_ContractorDataTable

    Private procA_Payments_of_Transaction As New ds_FinancialTransactionTableAdapters.proc_Payments_of_TransactionTableAdapter

    Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter

    Private objFrmBillModule As frmBillModule
    Private objFrmSemManager As frmSemManager
    Private objLocalConfig As clsLocalConfig

    Private objSemItem_Search As clsSemItem

    Private objFilter_Real_Amount As clsFilter
    Private objFilter_Real_toPay As clsFilter
    Private objFilter_Date_Payment As clsFilter
    Private objFilter_Date_Transaction As clsFilter
    Private objFilter_Partner As clsFilter

    Private boolIncome As Boolean

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

    Public Sub New(ByVal objGlobals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(objGlobals)
        initialize()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
        get_GrossStandard()
        get_Data()
        get_Data_SearchTemplates()
        ToolStripComboBox_SearchTemplates.ComboBox.DataSource = semtblT_SearchTemplates
        ToolStripComboBox_SearchTemplates.ComboBox.ValueMember = "GUID_Token_Right"
        ToolStripComboBox_SearchTemplates.ComboBox.DisplayMember = "Name_Token_Right"
        ToolStripComboBox_SearchTemplates.ComboBox.SelectedValue = objLocalConfig.SemItem_Token_Search_Template_Name_.GUID
        fill_TransactionTree()
    End Sub

    Private Sub get_GrossStandard()
        Dim objDRC_Attribute As DataRowCollection

        objDRC_Attribute = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objLocalConfig.SemItem_Token_Baseconfig.GUID, _
                                                                                                          objLocalConfig.SemItem_Attribute_Gross__Standard_.GUID).Rows
        If objDRC_Attribute.Count > 0 Then
            objLocalConfig.GrossStandard = objDRC_Attribute(0).Item("Val_BOOL")
        Else
            objLocalConfig.GrossStandard = Nothing
        End If
    End Sub

    Private Sub get_Data_SearchTemplates()
        semtblA_SearchTemplates.Fill_TokenToken_LeftRight(semtblT_SearchTemplates, _
                                                                objLocalConfig.SemItem_Module.GUID, _
                                                                objLocalConfig.SemItem_RelationType_offers.GUID, _
                                                                objLocalConfig.SemItem_Type_Search_Template.GUID)
    End Sub

    Private Sub get_Data(Optional ByVal SemItem_Filter As clsFilter = Nothing)
        Dim objDRC_Filter As DataRowCollection
        If SemItem_Filter Is Nothing Then
            If Not objSemItem_Search Is Nothing Then

                objDRC_Filter = semfuncA_ObjectReference.GetData_By_GUID_Ref(objSemItem_Search.GUID).Rows
                If objDRC_Filter.Count = 1 Then
                    objSemItem_Search.GUID = objDRC_Filter(0).Item("GUID_ObjectReference")

                    procA_FinancialTransaction_Contractee.Fill(procT_FinancialTransaction_Contractee, _
                                               objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                               objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                               objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                objLocalConfig.SemItem_Type_Module.GUID, _
                                                objLocalConfig.SemItem_Type_Bill_Module.GUID, _
                                                objLocalConfig.SemItem_Type_Partner.GUID, _
                                                objLocalConfig.SemItem_Type_Menge.GUID, _
                                                objLocalConfig.SemItem_Type_Payment.GUID, _
                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                objLocalConfig.SemItem_RelationType_zugeh_rige_Mandanten.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                               objLocalConfig.SemItem_Development.GUID, _
                                               Nothing, _
                                               Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, objSemItem_Search.GUID)

                    BindingSource_Contractee.DataSource = procT_FinancialTransaction_Contractee

                    procA_FinancialTransaction_Contractor.Fill(procT_FinancialTransaction_Contractor, _
                                                       objLocalConfig.SemItem_Development.GUID, _
                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                      objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                    objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                objLocalConfig.SemItem_Type_Module.GUID, _
                                                objLocalConfig.SemItem_Type_Bill_Module.GUID, _
                                                objLocalConfig.SemItem_Type_Partner.GUID, _
                                                objLocalConfig.SemItem_Type_Menge.GUID, _
                                                objLocalConfig.SemItem_Type_Payment.GUID, _
                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                objLocalConfig.SemItem_RelationType_zugeh_rige_Mandanten.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                        Nothing, _
                                                       Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, objSemItem_Search.GUID)

                    BindingSource_Contractor.DataSource = procT_FinancialTransaction_Contractor
                End If


            Else
                procA_FinancialTransaction_Contractee.Fill(procT_FinancialTransaction_Contractee, _
                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                       objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                       objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                        objLocalConfig.SemItem_Type_Module.GUID, _
                                                        objLocalConfig.SemItem_Type_Bill_Module.GUID, _
                                                        objLocalConfig.SemItem_Type_Partner.GUID, _
                                                        objLocalConfig.SemItem_Type_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Payment.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                        objLocalConfig.SemItem_RelationType_zugeh_rige_Mandanten.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                        objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                       objLocalConfig.SemItem_Development.GUID, _
                                                       Nothing, _
                                                       Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                BindingSource_Contractee.DataSource = procT_FinancialTransaction_Contractee

                procA_FinancialTransaction_Contractor.Fill(procT_FinancialTransaction_Contractor, _
                                                           objLocalConfig.SemItem_Development.GUID, _
                                                           objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                          objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                        objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                    objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                    objLocalConfig.SemItem_Type_Module.GUID, _
                                                    objLocalConfig.SemItem_Type_Bill_Module.GUID, _
                                                    objLocalConfig.SemItem_Type_Partner.GUID, _
                                                    objLocalConfig.SemItem_Type_Menge.GUID, _
                                                    objLocalConfig.SemItem_Type_Payment.GUID, _
                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                    objLocalConfig.SemItem_RelationType_zugeh_rige_Mandanten.GUID, _
                                                    objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                    objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                    objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                    objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                    objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                    Nothing, _
                                                   Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                BindingSource_Contractor.DataSource = procT_FinancialTransaction_Contractor
            End If

        Else
            Select Case SemItem_Filter.SemItem_Ref.GUID
                Case objLocalConfig.SemItem_Token_Search_Template_Amount_.GUID
                    procA_FinancialTransaction_Contractee.Fill(procT_FinancialTransaction_Contractee, _
                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                       objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                       objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                        objLocalConfig.SemItem_Type_Module.GUID, _
                                                        objLocalConfig.SemItem_Type_Bill_Module.GUID, _
                                                        objLocalConfig.SemItem_Type_Partner.GUID, _
                                                        objLocalConfig.SemItem_Type_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Payment.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                        objLocalConfig.SemItem_RelationType_zugeh_rige_Mandanten.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                        objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                       objLocalConfig.SemItem_Development.GUID, _
                                                       SemItem_Filter.Filter_Real_Start, _
                                                       SemItem_Filter.Filter_Real_End, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                    BindingSource_Contractee.DataSource = procT_FinancialTransaction_Contractee

                    procA_FinancialTransaction_Contractor.Fill(procT_FinancialTransaction_Contractor, _
                                                       objLocalConfig.SemItem_Development.GUID, _
                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                      objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                    objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                objLocalConfig.SemItem_Type_Module.GUID, _
                                                objLocalConfig.SemItem_Type_Bill_Module.GUID, _
                                                objLocalConfig.SemItem_Type_Partner.GUID, _
                                                objLocalConfig.SemItem_Type_Menge.GUID, _
                                                objLocalConfig.SemItem_Type_Payment.GUID, _
                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                objLocalConfig.SemItem_RelationType_zugeh_rige_Mandanten.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                       SemItem_Filter.Filter_Real_Start, _
                                                       SemItem_Filter.Filter_Real_End, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                    BindingSource_Contractor.DataSource = procT_FinancialTransaction_Contractor

                Case objLocalConfig.SemItem_Token_Search_Template_Payment_Date_.GUID
                    procA_FinancialTransaction_Contractee.Fill(procT_FinancialTransaction_Contractee, _
                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                       objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                       objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                        objLocalConfig.SemItem_Type_Module.GUID, _
                                                        objLocalConfig.SemItem_Type_Bill_Module.GUID, _
                                                        objLocalConfig.SemItem_Type_Partner.GUID, _
                                                        objLocalConfig.SemItem_Type_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Payment.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                        objLocalConfig.SemItem_RelationType_zugeh_rige_Mandanten.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                        objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                       objLocalConfig.SemItem_Development.GUID, _
                                                       Nothing, _
                                                       Nothing, SemItem_Filter.Filter_Date_Start, SemItem_Filter.Filter_Date_End, Nothing, Nothing, Nothing, Nothing)

                    BindingSource_Contractee.DataSource = procT_FinancialTransaction_Contractee

                    procA_FinancialTransaction_Contractor.Fill(procT_FinancialTransaction_Contractor, _
                                                       objLocalConfig.SemItem_Development.GUID, _
                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                      objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                    objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                objLocalConfig.SemItem_Type_Module.GUID, _
                                                objLocalConfig.SemItem_Type_Bill_Module.GUID, _
                                                objLocalConfig.SemItem_Type_Partner.GUID, _
                                                objLocalConfig.SemItem_Type_Menge.GUID, _
                                                objLocalConfig.SemItem_Type_Payment.GUID, _
                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                objLocalConfig.SemItem_RelationType_zugeh_rige_Mandanten.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                        Nothing, _
                                                       Nothing, SemItem_Filter.Filter_Date_Start, SemItem_Filter.Filter_Date_End, Nothing, Nothing, Nothing, Nothing)

                    BindingSource_Contractor.DataSource = procT_FinancialTransaction_Contractor



                Case objLocalConfig.SemItem_Token_Search_Template_to_Pay_.GUID
                    procA_FinancialTransaction_Contractee.Fill(procT_FinancialTransaction_Contractee, _
                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                       objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                       objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                        objLocalConfig.SemItem_Type_Module.GUID, _
                                                        objLocalConfig.SemItem_Type_Bill_Module.GUID, _
                                                        objLocalConfig.SemItem_Type_Partner.GUID, _
                                                        objLocalConfig.SemItem_Type_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Payment.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                        objLocalConfig.SemItem_RelationType_zugeh_rige_Mandanten.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                        objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                       objLocalConfig.SemItem_Development.GUID, _
                                                       Nothing, _
                                                       Nothing, Nothing, Nothing, SemItem_Filter.Filter_Real_Start, SemItem_Filter.Filter_Real_End, Nothing, Nothing)

                    BindingSource_Contractee.DataSource = procT_FinancialTransaction_Contractee

                    procA_FinancialTransaction_Contractor.Fill(procT_FinancialTransaction_Contractor, _
                                                       objLocalConfig.SemItem_Development.GUID, _
                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                      objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                    objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                objLocalConfig.SemItem_Type_Module.GUID, _
                                                objLocalConfig.SemItem_Type_Bill_Module.GUID, _
                                                objLocalConfig.SemItem_Type_Partner.GUID, _
                                                objLocalConfig.SemItem_Type_Menge.GUID, _
                                                objLocalConfig.SemItem_Type_Payment.GUID, _
                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                objLocalConfig.SemItem_RelationType_zugeh_rige_Mandanten.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                        Nothing, _
                                                       Nothing, Nothing, Nothing, SemItem_Filter.Filter_Real_Start, SemItem_Filter.Filter_Real_End, Nothing, Nothing)

                    BindingSource_Contractor.DataSource = procT_FinancialTransaction_Contractor
                Case objLocalConfig.SemItem_Token_Search_Template_Contractee_Contractor_.GUID
                    procA_FinancialTransaction_Contractee.Fill(procT_FinancialTransaction_Contractee, _
                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                       objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                       objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                        objLocalConfig.SemItem_Type_Module.GUID, _
                                                        objLocalConfig.SemItem_Type_Bill_Module.GUID, _
                                                        objLocalConfig.SemItem_Type_Partner.GUID, _
                                                        objLocalConfig.SemItem_Type_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Payment.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                        objLocalConfig.SemItem_RelationType_zugeh_rige_Mandanten.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                        objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                        objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                       objLocalConfig.SemItem_Development.GUID, _
                                                       Nothing, _
                                                       Nothing, Nothing, Nothing, Nothing, Nothing, SemItem_Filter.Filter, Nothing)

                    BindingSource_Contractee.DataSource = procT_FinancialTransaction_Contractee

                    procA_FinancialTransaction_Contractor.Fill(procT_FinancialTransaction_Contractor, _
                                                       objLocalConfig.SemItem_Development.GUID, _
                                                       objLocalConfig.SemItem_Attribute_Transaction_Date.GUID, _
                                                      objLocalConfig.SemItem_Attribute_to_Pay.GUID, _
                                                    objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                objLocalConfig.SemItem_Type_Financial_Transaction.GUID, _
                                                objLocalConfig.SemItem_Type_Module.GUID, _
                                                objLocalConfig.SemItem_Type_Bill_Module.GUID, _
                                                objLocalConfig.SemItem_Type_Partner.GUID, _
                                                objLocalConfig.SemItem_Type_Menge.GUID, _
                                                objLocalConfig.SemItem_Type_Payment.GUID, _
                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                objLocalConfig.SemItem_RelationType_zugeh_rige_Mandanten.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID, _
                                                objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Amount.GUID, _
                                                objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                        Nothing, _
                                                       Nothing, Nothing, Nothing, Nothing, Nothing, SemItem_Filter.Filter, Nothing)

                    BindingSource_Contractor.DataSource = procT_FinancialTransaction_Contractor



            End Select
        End If









    End Sub

    Private Sub fill_TransactionTree()
        TreeView_Transactions.Nodes.Clear()
        Dim objDRV_Contract As DataRowView
        Dim objTreeNode_Root As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Partner As TreeNode
        Dim objTreeNode_Sub As TreeNode
        Dim objTreeNode_ContractType_Ausgaben As TreeNode
        Dim objTreeNode_ContractType_Einnahmen As TreeNode
        Dim objTreeNode_Transaction As TreeNode
        Dim i As Integer

        objTreeNode_Root = TreeView_Transactions.Nodes.Add(objLocalConfig.SemItem_Type_Financial_Transaction.GUID.ToString, objLocalConfig.SemItem_Type_Financial_Transaction.Name, cint_ImageID_Root, cint_ImageID_Root)

        For i = 0 To BindingSource_Contractee.Count - 1
            BindingSource_Contractee.Position = i
            objDRV_Contract = BindingSource_Contractee.Current

            objTreeNodes = objTreeNode_Root.Nodes.Find(objDRV_Contract.Item("GUID_Partner").ToString, False)
            If objTreeNodes.Count = 0 Then
                objTreeNode_Partner = objTreeNode_Root.Nodes.Add(objDRV_Contract.Item("GUID_Partner").ToString, objDRV_Contract.Item("Name_Partner"), cint_ImageID_Mandant, cint_ImageID_Mandant)
                objTreeNode_ContractType_Einnahmen = objTreeNode_Partner.Nodes.Add(objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID.ToString, cstr_Einnahmen, cint_ImageID_Einnahmen, cint_ImageID_Einnahmen)
                objTreeNode_ContractType_Ausgaben = objTreeNode_Partner.Nodes.Add(objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID.ToString, cstr_Ausgaben, cint_ImageID_Ausgaben, cint_ImageID_Ausgaben)

            Else
                objTreeNode_Partner = objTreeNodes(0)
                For Each objTreeNode_Sub In objTreeNode_Partner.Nodes
                    If objTreeNode_Sub.Name = objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID.ToString Then
                        objTreeNode_ContractType_Einnahmen = objTreeNode_Sub
                    Else
                        objTreeNode_ContractType_Ausgaben = objTreeNode_Sub
                    End If
                Next
            End If
            objTreeNodes = objTreeNode_ContractType_Ausgaben.Nodes.Find(objDRV_Contract.Item("GUID_Financial_Transaction").ToString, False)
            If objTreeNodes.Count = 0 Then
                objTreeNode_Transaction = objTreeNode_ContractType_Ausgaben.Nodes.Add(objDRV_Contract.Item("GUID_Financial_Transaction").ToString, objDRV_Contract.Item("Name_Financial_Transaction") & "\" & objDRV_Contract.Item("TransactionDate"), cint_ImageID_Bill, cint_ImageID_BillSelected)
            Else
                objTreeNode_Transaction = objTreeNodes(0)
            End If
            If Not IsDBNull(objDRV_Contract.Item("GUID_Financial_Transaction_Child")) Then
                objTreeNode_Transaction.Nodes.Add(objDRV_Contract.Item("GUID_Financial_Transaction_Child").ToString, objDRV_Contract.Item("Name_Financial_Transaction_Child") & "\" & objDRV_Contract.Item("TransactionDate"), cint_ImageID_Position, cint_ImageID_Position)

            End If
        Next

        For i = 0 To BindingSource_Contractor.Count - 1
            BindingSource_Contractor.Position = i
            objDRV_Contract = BindingSource_Contractor.Current

            objTreeNodes = objTreeNode_Root.Nodes.Find(objDRV_Contract.Item("GUID_Partner").ToString, False)
            If objTreeNodes.Count = 0 Then
                objTreeNode_Partner = objTreeNode_Root.Nodes.Add(objDRV_Contract.Item("GUID_Partner").ToString, objDRV_Contract.Item("Name_Partner"), cint_ImageID_Mandant, cint_ImageID_Mandant)
                objTreeNode_ContractType_Einnahmen = objTreeNode_Partner.Nodes.Add(objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID.ToString, cstr_Einnahmen, cint_ImageID_Einnahmen, cint_ImageID_Einnahmen)
                objTreeNode_ContractType_Ausgaben = objTreeNode_Partner.Nodes.Add(objLocalConfig.SemItem_RelationType_belonging_Contractee.GUID.ToString, cstr_Ausgaben, cint_ImageID_Ausgaben, cint_ImageID_Ausgaben)

            Else
                objTreeNode_Partner = objTreeNodes(0)
                For Each objTreeNode_Sub In objTreeNode_Partner.Nodes
                    If objTreeNode_Sub.Name = objLocalConfig.SemItem_RelationType_belonging_Contractor.GUID.ToString Then
                        objTreeNode_ContractType_Einnahmen = objTreeNode_Sub
                    Else
                        objTreeNode_ContractType_Ausgaben = objTreeNode_Sub
                    End If
                Next
            End If

            objTreeNodes = objTreeNode_ContractType_Einnahmen.Nodes.Find(objDRV_Contract.Item("GUID_Financial_Transaction").ToString, False)
            If objTreeNodes.Count = 0 Then
                objTreeNode_Transaction = objTreeNode_ContractType_Einnahmen.Nodes.Add(objDRV_Contract.Item("GUID_Financial_Transaction").ToString, objDRV_Contract.Item("Name_Financial_Transaction") & "\" & objDRV_Contract.Item("TransactionDate"), cint_ImageID_Bill, cint_ImageID_BillSelected)
            Else
                objTreeNode_Transaction = objTreeNodes(0)
            End If
            If Not IsDBNull(objDRV_Contract.Item("GUID_Financial_Transaction_Child")) Then
                objTreeNode_Transaction.Nodes.Add(objDRV_Contract.Item("GUID_Financial_Transaction_Child").ToString, objDRV_Contract.Item("Name_Financial_Transaction_Child") & "\" & objDRV_Contract.Item("TransactionDate"), cint_ImageID_Position, cint_ImageID_Position)

            End If
        Next



        objTreeNode_Root.Expand()
    End Sub
    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        semtblA_SearchTemplates.Connection = objLocalConfig.Connection_DB

        procA_FinancialTransaction_Contractee.Connection = objLocalConfig.Connection_Plugin
        procA_FinancialTransaction_Contractor.Connection = objLocalConfig.Connection_Plugin

        procA_Payments_of_Transaction.Connection = objLocalConfig.Connection_Plugin

        semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB

        objUserControl_TransactionDetails = New UserControl_TransactionDetail(objLocalConfig)
        objUserControl_TransactionDetails.Dock = DockStyle.Fill
        TabPage_TransactionDetails.Controls.Clear()
        TabPage_TransactionDetails.Controls.Add(objUserControl_TransactionDetails)

        objTransaction_FinancialTransaction = New clsTransaction_FinancialTransaction(objLocalConfig)
        objUserControl_Documents = New UserControl_Documents(objLocalConfig)
        objUserControl_Documents.Dock = DockStyle.Fill
        TabPage_Documents.Controls.Clear()
        TabPage_Documents.Controls.Add(objUserControl_Documents)
    End Sub

    Private Sub TreeView_Transactions_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Transactions.AfterSelect
        Dim objTreeNode As TreeNode
        objTreeNode = TreeView_Transactions.SelectedNode
        While Not objTreeNode.ImageIndex = cint_ImageID_Ausgaben And Not objTreeNode.ImageIndex = cint_ImageID_Einnahmen
            If Not objTreeNode Is Nothing Then
                objTreeNode = objTreeNode.Parent
                If objTreeNode Is Nothing Then
                    Exit While
                End If
            End If
        End While
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Ausgaben Then
                boolIncome = False
            ElseIf objTreeNode.ImageIndex = cint_ImageID_Einnahmen Then
                boolIncome = True
            Else
                boolIncome = Nothing
            End If
        End If
        fill_TabPages()

    End Sub

    Private Sub fill_TabPages()

        Dim objSemItem_Transaction As New clsSemItem
        Dim objSemItem_Transaction_Parent As New clsSemItem
        Dim objTreeNode_Selected As TreeNode
        Dim objTreeNode_Parent As TreeNode = Nothing

        objTreeNode_Selected = TreeView_Transactions.SelectedNode
        If Not objTreeNode_Selected Is Nothing Then
            objTreeNode_Parent = objTreeNode_Selected.Parent

        End If
        If objTreeNode_Selected.ImageIndex = cint_ImageID_Bill Or _
            objTreeNode_Selected.ImageIndex = cint_ImageID_Position Then
            objSemItem_Transaction.GUID = New Guid(objTreeNode_Selected.Name)
            objSemItem_Transaction.Name = objTreeNode_Selected.Text
            objSemItem_Transaction.GUID_Parent = objLocalConfig.SemItem_Type_Financial_Transaction.GUID
            objSemItem_Transaction.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        Else
            objSemItem_Transaction = Nothing
        End If


        If objTreeNode_Selected.ImageIndex = cint_ImageID_Position Or _
            objTreeNode_Selected.ImageIndex = cint_ImageID_Bill Then

            If Not objTreeNode_Parent Is Nothing Then
                objSemItem_Transaction_Parent.GUID = New Guid(objTreeNode_Parent.Name)
                objSemItem_Transaction_Parent.Name = objTreeNode_Selected.Text
                objSemItem_Transaction_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Financial_Transaction.GUID
                objSemItem_Transaction_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            End If

        Else
            If objTreeNode_Selected.ImageIndex = cint_ImageID_Root Or _
                objTreeNode_Selected.ImageIndex = cint_ImageID_Einnahmen Or _
                objTreeNode_Selected.ImageIndex = cint_ImageID_Ausgaben Then

                objSemItem_Transaction = Nothing
            End If
            objTreeNode_Parent = Nothing
            objSemItem_Transaction_Parent = Nothing
        End If

        Select Case TabControl1.SelectedTab.Name
            Case TabPage_TransactionDetails.Name
                objUserControl_TransactionDetails.initialize(objSemItem_Transaction, boolIncome)
            Case TabPage_Documents.Name
                objUserControl_Documents.initialize_Belege(objSemItem_Transaction)

        End Select

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        fill_TabPages()
    End Sub

    Private Sub ContextMenuStrip_FinancialTransaction_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_FinancialTransaction.Opening
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Transactions.SelectedNode

        NewTransactionToolStripMenuItem.Enabled = False
        RemoveTransactionToolStripMenuItem.Enabled = False
        NewFromBankToolStripMenuItem.Enabled = False
        NewFromParentToolStripMenuItem.Enabled = False
        RemoveFromTreeToolStripMenuItem.Enabled = False
        DetailsToBillsToolStripMenuItem.Enabled = False
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Einnahmen Or _
                objTreeNode.ImageIndex = cint_ImageID_Ausgaben Or _
                objTreeNode.ImageIndex = cint_ImageID_Bill Then
                NewTransactionToolStripMenuItem.Enabled = True
                NewFromBankToolStripMenuItem.Enabled = True
                If objTreeNode.ImageIndex = cint_ImageID_Ausgaben Or _
                    objTreeNode.ImageIndex = cint_ImageID_Einnahmen Then
                    DetailsToBillsToolStripMenuItem.Enabled = True
                End If
            End If

            If objTreeNode.ImageIndex = cint_ImageID_Bill Or _
                objTreeNode.ImageIndex = cint_ImageID_Position Then
                If objTreeNode.ImageIndex = cint_ImageID_Bill Then
                    NewFromParentToolStripMenuItem.Enabled = True
                    RemoveFromTreeToolStripMenuItem.Enabled = True
                End If
                RemoveTransactionToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub NewTransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTransactionToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Transactions.SelectedNode
        If Not objTreeNode Is Nothing Then
            create_Bill(objTreeNode)
        End If
    End Sub

    Private Function create_Bill(ByVal objTreeNode_Selected As TreeNode, Optional ByVal strName_Transaction As String = Nothing, Optional ByVal boolFromParent As Boolean = False) As clsSemItem
        Dim objTreeNode_Parent As TreeNode
        Dim objTreeNode_Transaction As TreeNode
        Dim objSemItem_Partner As New clsSemItem
        Dim objSemItem_Transaction As New clsSemItem
        Dim objSemItem_Transaction_Parent As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim dateContract As Date
        Dim boolContractor As Boolean
        Dim intImageIndex As Integer
        Dim boolCreate As Boolean = False

        objSemItem_Result = objLocalConfig.Globals.LogState_Error
        objTransaction_FinancialTransaction.SemItem_TokenAttribute_TransactionDate = Nothing

        If Not objTreeNode_Selected Is Nothing Then
            Select Case objTreeNode_Selected.ImageIndex
                Case cint_ImageID_Bill
                    objTreeNode_Parent = objTreeNode_Selected.Parent
                    If objTreeNode_Parent.ImageIndex = cint_ImageID_Einnahmen Then
                        boolContractor = True
                    Else
                        boolContractor = False
                    End If
                    objTreeNode_Parent = objTreeNode_Parent.Parent
                    objSemItem_Partner.GUID = New Guid(objTreeNode_Parent.Name)
                    objSemItem_Partner.Name = objTreeNode_Parent.Text
                    objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                    objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Transaction_Parent.GUID = New Guid(objTreeNode_Selected.Name)
                    objSemItem_Transaction_Parent.Name = objTreeNode_Selected.Text
                    objSemItem_Transaction_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Financial_Transaction.GUID
                    objSemItem_Transaction_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    boolCreate = True
                    

                    intImageIndex = cint_ImageID_Position


                Case cint_ImageID_Ausgaben
                    boolContractor = False
                    objTreeNode_Parent = objTreeNode_Selected.Parent
                    objSemItem_Partner.GUID = New Guid(objTreeNode_Parent.Name)
                    objSemItem_Partner.Name = objTreeNode_Parent.Text
                    objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                    objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Transaction_Parent = Nothing
                    intImageIndex = cint_ImageID_Bill
                    boolCreate = True
                Case cint_ImageID_Einnahmen
                    boolContractor = True
                    objTreeNode_Parent = objTreeNode_Selected.Parent
                    objSemItem_Partner.GUID = New Guid(objTreeNode_Parent.Name)
                    objSemItem_Partner.Name = objTreeNode_Parent.Text
                    objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                    objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Transaction_Parent = Nothing
                    intImageIndex = cint_ImageID_Bill
                    boolCreate = True
            End Select

            If boolCreate = True Then
                objDlgAttribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Type_Financial_Transaction.Name, objLocalConfig.Globals, strName_Transaction)
                objDlgAttribute_VARCHAR255.ShowDialog(Me)

                If objDlgAttribute_VARCHAR255.DialogResult = vbOK Then
                    objSemItem_Transaction.GUID = Guid.NewGuid
                    objSemItem_Transaction.Name = objDlgAttribute_VARCHAR255.Value1
                    objSemItem_Transaction.GUID_Parent = objLocalConfig.SemItem_Type_Financial_Transaction.GUID
                    objSemItem_Transaction.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Result = objTransaction_FinancialTransaction.save_001_FinancialTransaction(objSemItem_Transaction)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        If boolContractor = True Then
                            objSemItem_Result = objTransaction_FinancialTransaction.save_010_FinancialTransaction_To_Contractor(objSemItem_Partner, objSemItem_Transaction)
                        Else
                            objSemItem_Result = objTransaction_FinancialTransaction.save_011_FinancialTransaction_To_Contractee(objSemItem_Partner, objSemItem_Transaction)
                        End If

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            If objLocalConfig.SemItem_Token_StandardCurrency IsNot Nothing Then
                                objSemItem_Result = objTransaction_FinancialTransaction.save_006_Currency(objLocalConfig.SemItem_Token_StandardCurrency, objSemItem_Transaction)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_FinancialTransaction.save_005_Gross(objLocalConfig.GrossStandard, _
                                                                                                               objSemItem_Transaction)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_FinancialTransaction.save_012_FinancialTransaction_To_TaxRate(objLocalConfig.SemItem_Token_TaxRate_Standard, _
                                                                                                                                             objSemItem_Transaction)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                If Not objSemItem_Transaction_Parent Is Nothing Then
                                                    objSemItem_Result = save_Transaction_Sub(objSemItem_Transaction, objSemItem_Transaction_Parent, boolContractor)


                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        If boolFromParent = True Then
                                                            save_Payment_Of_Parent(objSemItem_Transaction_Parent, objSemItem_Transaction)
                                                        End If
                                                        objTreeNode_Transaction = objTreeNode_Selected.Nodes.Add(objSemItem_Transaction.GUID.ToString, _
                                                                                                 objSemItem_Transaction.Name, _
                                                                                                 intImageIndex, _
                                                                                                 intImageIndex)
                                                        TreeView_Transactions.SelectedNode = objTreeNode_Transaction
                                                    Else

                                                    End If
                                                Else
                                                    objTreeNode_Transaction = objTreeNode_Selected.Nodes.Add(objSemItem_Transaction.GUID.ToString, _
                                                                                                 objSemItem_Transaction.Name, _
                                                                                                 intImageIndex, _
                                                                                                 intImageIndex)
                                                    TreeView_Transactions.SelectedNode = objTreeNode_Transaction
                                                End If


                                            Else
                                                MsgBox("Leider konnte die Transaktion nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                If boolContractor = True Then
                                                    objSemItem_Result = objTransaction_FinancialTransaction.del_010_FinancialTransaction_To_Contractor(objSemItem_Partner)

                                                Else
                                                    objSemItem_Result = objTransaction_FinancialTransaction.del_011_FinancialTransaction_To_Contractee(objSemItem_Partner)
                                                End If
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_FinancialTransaction.del_006_Currency(objSemItem_Transaction)
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objTransaction_FinancialTransaction.del_001_FinancialTransaction(objSemItem_Transaction)
                                                    End If

                                                End If
                                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                            End If

                                        Else
                                            MsgBox("Leider konnte die Transaktion nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                            If boolContractor = True Then
                                                objSemItem_Result = objTransaction_FinancialTransaction.del_010_FinancialTransaction_To_Contractor(objSemItem_Partner)

                                            Else
                                                objSemItem_Result = objTransaction_FinancialTransaction.del_011_FinancialTransaction_To_Contractee(objSemItem_Partner)
                                            End If
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_FinancialTransaction.del_006_Currency(objSemItem_Transaction)
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objTransaction_FinancialTransaction.del_001_FinancialTransaction(objSemItem_Transaction)
                                                End If

                                            End If
                                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                        End If

                                    Else

                                        MsgBox("Leider konnte die Transaktion nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                        If boolContractor = True Then
                                            objSemItem_Result = objTransaction_FinancialTransaction.del_010_FinancialTransaction_To_Contractor(objSemItem_Partner)

                                        Else
                                            objSemItem_Result = objTransaction_FinancialTransaction.del_011_FinancialTransaction_To_Contractee(objSemItem_Partner)
                                        End If
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_FinancialTransaction.del_006_Currency(objSemItem_Transaction)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objTransaction_FinancialTransaction.del_001_FinancialTransaction(objSemItem_Transaction)
                                            End If

                                        End If
                                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                    End If
                                Else
                                    MsgBox("Leider konnte die Transaktion nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                    If boolContractor = True Then
                                        objSemItem_Result = objTransaction_FinancialTransaction.del_010_FinancialTransaction_To_Contractor(objSemItem_Partner)

                                    Else
                                        objSemItem_Result = objTransaction_FinancialTransaction.del_011_FinancialTransaction_To_Contractee(objSemItem_Partner)
                                    End If
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_FinancialTransaction.del_001_FinancialTransaction(objSemItem_Transaction)
                                    End If
                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                End If
                            End If

                        Else
                            MsgBox("Leider konnte die Transaktion nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            objTransaction_FinancialTransaction.del_001_FinancialTransaction(objSemItem_Transaction)
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If
                    Else
                        MsgBox("Leider konnte die Transaktion nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If

                End If
            End If
        End If


        Return objSemItem_Result
    End Function

    Private Function save_Payment_Of_Parent(ByVal objSemItem_Transaction_Parent As clsSemItem, ByVal objSemItem_Transaction As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Payment As DataRowCollection
        Dim objDR_Payment As DataRow
        Dim objSemItem_Payment As New clsSemItem
        Dim objSemItem_Sparkasse As New clsSemItem

        objDRC_Payment = procA_Payments_of_Transaction.GetData(objLocalConfig.SemItem_Attribute_Valutatag.GUID, _
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
                                                               objLocalConfig.SemItem_Token_StandardCurrency.Name, _
                                                               objSemItem_Transaction_Parent.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Payment In objDRC_Payment
            objSemItem_Payment.GUID = Guid.NewGuid
            objSemItem_Payment.Name = objDR_Payment.Item("Name_Payment")
            objSemItem_Payment.GUID_Parent = objLocalConfig.SemItem_Type_Payment.GUID
            objSemItem_Payment.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objTransaction_FinancialTransaction.save_013_Payment(objSemItem_Payment)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_FinancialTransaction.save_014_Payment__Amount(objDR_Payment.Item("Ammount"), objSemItem_Payment)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_FinancialTransaction.save_015_Payment__TransactionDate(objDR_Payment.Item("TransactionDate"), objSemItem_Payment)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        If Not IsDBNull(objDR_Payment.Item("GUID_Bank_Transaktionen__Sparkasse_")) Then
                            objSemItem_Sparkasse = New clsSemItem
                            objSemItem_Sparkasse.GUID = objDR_Payment.Item("GUID_Bank_Transaktionen__Sparkasse_")
                            objSemItem_Sparkasse.Name = objDR_Payment.Item("Name_Bank_Transaktionen__Sparkasse_")
                            objSemItem_Sparkasse.GUID_Parent = objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse_.GUID
                            objSemItem_Sparkasse.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Result = objTransaction_FinancialTransaction.save_017_Sparkasse_To_Payment(objSemItem_Sparkasse, objSemItem_Payment)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_FinancialTransaction.save_018_Payment_PercentPart(100, objSemItem_Payment)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_FinancialTransaction.save_016_FinancialTransaction_To_Payment(objSemItem_Payment, objSemItem_Transaction)

                                End If
                            End If
                        End If
                        
                    End If
                End If

                'objSemItem_Result = objTransaction_FinancialTransaction.save_016_FinancialTransaction_To_Payment(objSemItem_Payment, objSemItem_Transaction)
            Else
                Exit For
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                Exit For
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Die Zahlungen konnten nicht verknüpft werden!", MsgBoxStyle.Exclamation)
            objDRC_Payment = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Transaction.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_belonging_Payment.GUID, _
                                                                           objLocalConfig.SemItem_Type_Payment.GUID).Rows
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            For Each objDR_Payment In objDRC_Payment
                objSemItem_Payment.GUID = objDR_Payment.Item("GUID_Token_Right")
                objSemItem_Payment.Name = objDR_Payment.Item("Name_Token_Right")
                objSemItem_Payment.GUID_Parent = objLocalConfig.SemItem_Type_Payment.GUID
                objSemItem_Payment.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_FinancialTransaction.del_016_FinancialTransaction_To_Payment(objSemItem_Transaction, objSemItem_Payment)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                End If
            Next
        End If


        Return objSemItem_Result
    End Function

    Private Function save_Transaction_Sub(ByVal objSemItem_Transaction As clsSemItem, ByVal objSemItem_Transaction_Parent As clsSemItem, ByVal boolContractor As Boolean) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Order As DataRowCollection

        objSemItem_Transaction.Level = -1
        objSemItem_Result = objTransaction_FinancialTransaction.save_007_FinancialTransaction_To_FinancialTransaction_Sub(objSemItem_Transaction, objSemItem_Transaction_Parent)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            While objUserControl_TransactionDetails.isFinished = False

            End While
            If Not objUserControl_TransactionDetails.dateTransaction = Nothing Then
                objSemItem_Result = objTransaction_FinancialTransaction.save_002_TransactionDate(objUserControl_TransactionDetails.dateTransaction, objSemItem_Transaction)
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_FinancialTransaction.save_006_Currency(objUserControl_TransactionDetails.SemItem_Currency, objSemItem_Transaction)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    If boolContractor = True Then
                        If Not objUserControl_TransactionDetails.SemItem_Contractee Is Nothing Then
                            objSemItem_Result = objTransaction_FinancialTransaction.save_011_FinancialTransaction_To_Contractee(objUserControl_TransactionDetails.SemItem_Contractee)

                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        End If
                    Else
                        If Not objUserControl_TransactionDetails.SemItem_Contractor Is Nothing Then
                            objSemItem_Result = objTransaction_FinancialTransaction.save_010_FinancialTransaction_To_Contractor(objUserControl_TransactionDetails.SemItem_Contractor)
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        End If
                    End If
                Else
                    objTransaction_FinancialTransaction.del_002_TransactionDate()
                    objTransaction_FinancialTransaction.del_007_FinancialTransaction_To_FinancialTransaction_Sub()
                End If
            Else
                objTransaction_FinancialTransaction.del_007_FinancialTransaction_To_FinancialTransaction_Sub()

            End If

        End If

        Return objSemItem_Result
    End Function

    Private Sub TreeView_Transactions_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_Transactions.DoubleClick
        Dim objTreeNode As TreeNode
        Dim objSemItem_Token As New clsSemItem

        objTreeNode = TreeView_Transactions.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Bill, cint_ImageID_PartialBill, cint_ImageID_Position
                    objSemItem_Token.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Token.Name = objTreeNode.Text
                    objSemItem_Token.GUID_Parent = objLocalConfig.SemItem_Type_Financial_Transaction.GUID
                    objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objFrmTokenEdit = New frmTokenEdit(objSemItem_Token, objLocalConfig.Globals)
                    objFrmTokenEdit.ShowDialog(Me)
                    fill_TabPages()
                Case cint_ImageID_Mandant
                    objSemItem_Token.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Token.Name = objTreeNode.Text
                    objSemItem_Token.GUID_Parent = objLocalConfig.SemItem_Type_Financial_Transaction.GUID
                    objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objFrmTokenEdit = New frmTokenEdit(objSemItem_Token, objLocalConfig.Globals)
                    objFrmTokenEdit.ShowDialog(Me)
                    fill_TabPages()
            End Select
        End If
    End Sub

    Private Sub TreeView_Transactions_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView_Transactions.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                get_Data()
                fill_TransactionTree()

        End Select
    End Sub

    Private Sub ToolStripTextBox_Search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Search.TextChanged
        Timer_Filter.Stop()
        'objSemItem_Search = Nothing
        If ToolStripTextBox_Search.ReadOnly = False Then
            If ToolStripButton_Filter.Checked = True Then
                Timer_Filter.Start()
            End If

        End If

    End Sub

    Private Sub Timer_Filter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Filter.Tick
        Timer_Filter.Stop()
        If ToolStripTextBox_Search.Text = "" Then
            BindingSource_Contractee.Filter = ""
            BindingSource_Contractor.Filter = ""
            get_Data()
            fill_TransactionTree()
        Else
            Select Case ToolStripComboBox_SearchTemplates.ComboBox.SelectedValue
                Case objLocalConfig.SemItem_Token_Search_Template_Amount_.GUID
                    objFilter_Real_Amount = New clsFilter(ToolStripTextBox_Search.Text, _
                                                          objLocalConfig.Globals.AttributeType_Real.GUID, _
                                                          objLocalConfig.SemItem_Token_Search_Template_Amount_, _
                                                          objLocalConfig.Globals)
                    If Not objFilter_Real_Amount.Filter_Error Then
                        get_Data(objFilter_Real_Amount)
                    Else
                        MsgBox("Der eingegebene Filter kann nicht analyisert werden!", MsgBoxStyle.Exclamation)
                        get_Data()
                    End If

                    fill_TransactionTree()
                Case objLocalConfig.SemItem_Token_Search_Template_Name_.GUID
                    get_Data()
                    BindingSource_Contractee.Filter = "Name_Financial_Transaction LIKE '%" & ToolStripTextBox_Search.Text & "%'"
                    BindingSource_Contractor.Filter = "Name_Financial_Transaction LIKE '%" & ToolStripTextBox_Search.Text & "%'"
                    fill_TransactionTree()
                Case objLocalConfig.SemItem_Token_Search_Template_Payment_Date_.GUID
                    objFilter_Date_Payment = New clsFilter(ToolStripTextBox_Search.Text, _
                                                           objLocalConfig.Globals.AttributeType_Date.GUID, _
                                                           objLocalConfig.SemItem_Token_Search_Template_Payment_Date_, _
                                                           objLocalConfig.Globals)
                    If Not objFilter_Date_Payment.Filter_Error Then
                        get_Data(objFilter_Date_Payment)
                    Else
                        MsgBox("Der eingegebene Filter kann nicht analyisert werden!", MsgBoxStyle.Exclamation)
                        get_Data()
                    End If

                    fill_TransactionTree()
                Case objLocalConfig.SemItem_Token_Search_Template_Transaction_Date_.GUID
                    objFilter_Date_Transaction = New clsFilter(ToolStripTextBox_Search.Text, _
                                                               objLocalConfig.Globals.AttributeType_Date.GUID, _
                                                               objLocalConfig.SemItem_Token_Search_Template_Transaction_Date_, _
                                                               objLocalConfig.Globals)
                    get_Data()
                    BindingSource_Contractee.Filter = "TransactionDate>='" & objFilter_Date_Transaction.Filter_Date_Start.ToString & "' AND TransactionDate <='" & _
                                                      objFilter_Date_Transaction.Filter_Date_End.ToString & "'"
                    BindingSource_Contractor.Filter = "TransactionDate>='" & objFilter_Date_Transaction.Filter_Date_Start.ToString & "' AND TransactionDate <='" & _
                                                      objFilter_Date_Transaction.Filter_Date_End.ToString & "'"
                    fill_TransactionTree()
                Case objLocalConfig.SemItem_Token_Search_Template_to_Pay_.GUID
                    objFilter_Real_toPay = New clsFilter(ToolStripTextBox_Search.Text, _
                                                         objLocalConfig.Globals.AttributeType_Real.GUID, _
                                                         objLocalConfig.SemItem_Token_Search_Template_to_Pay_, _
                                                         objLocalConfig.Globals)
                    If Not objFilter_Real_toPay.Filter_Error Then
                        get_Data(objFilter_Real_toPay)
                    Else
                        MsgBox("Der eingegebene Filter kann nicht analyisert werden!", MsgBoxStyle.Exclamation)
                        get_Data()
                    End If

                    fill_TransactionTree()
                Case objLocalConfig.SemItem_Token_Search_Template_Contractee_Contractor_.GUID
                    objFilter_Partner = New clsFilter(ToolStripTextBox_Search.Text, _
                                                      objLocalConfig.Globals.AttributeType_Varchar255.GUID, _
                                                      objLocalConfig.SemItem_Token_Search_Template_Contractee_Contractor_, _
                                                      objLocalConfig.Globals, False)
                    
                    If Not objFilter_Partner.Filter_Error Then
                        get_Data(objFilter_Partner)
                    Else
                        MsgBox("Der eingegebene Filter kann nicht analyisert werden!", MsgBoxStyle.Exclamation)
                        get_Data()
                    End If
                    fill_TransactionTree()
                Case objLocalConfig.SemItem_Token_Search_Template_Related_Sem_Item_.GUID
                    If Not objSemItem_Search Is Nothing Then
                        get_Data()
                        fill_TransactionTree()
                    End If
            End Select

        End If
    End Sub

    Private Sub ToolStripButton_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Filter.Click
        Timer_Filter.Stop()

        If ToolStripButton_Filter.Checked = True Then
            objSemItem_Search = Nothing
            ToolStripTextBox_Search.ReadOnly = True
            ToolStripTextBox_Search.Text = ""
            ToolStripTextBox_Search.ReadOnly = False
            ToolStripButton_Filter.Checked = False
        Else
            ToolStripButton_Filter.Checked = True
        End If

        Timer_Filter.Start()
    End Sub


    Private Sub NewFromBankToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFromBankToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Partner As TreeNode
        Dim objSemItem_Partner As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Payment As New clsSemItem
        Dim objSemItem_Sparkasse As New clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objTransaction_FinancialTransaction_loc As clsTransaction_FinancialTransaction

        objTreeNode = TreeView_Transactions.SelectedNode


        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Einnahmen Or _
                objTreeNode.ImageIndex = cint_ImageID_Ausgaben Or _
                objTreeNode.ImageIndex = cint_ImageID_Bill Then

                objTreeNode_Partner = objTreeNode.Parent
                If Not objTreeNode_Partner.ImageIndex = cint_ImageID_Mandant Then
                    objTreeNode_Partner = objTreeNode_Partner.Parent
                End If

                objSemItem_Partner.GUID = New Guid(objTreeNode_Partner.Name)
                objSemItem_Partner.Name = objTreeNode_Partner.Text
                objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                objFrmBankTransactionModule = New frmBankTransactionModule(objLocalConfig.Globals, objSemItem_Partner)
                objFrmBankTransactionModule.MultipleSelect = False
                objFrmBankTransactionModule.Applyable = True
                objFrmBankTransactionModule.ShowDialog(Me)
                If objFrmBankTransactionModule.DialogResult = Windows.Forms.DialogResult.OK Then
                    objDGVR_Selected = objFrmBankTransactionModule.DGVSRC_Selected(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem



                    objSemItem_Result = create_Bill(objTreeNode, objDRV_Selected.Item("Name_Token"))
                    objTransaction_FinancialTransaction_loc = New clsTransaction_FinancialTransaction(objLocalConfig)

                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_FinancialTransaction_loc.save_002_TransactionDate(objDRV_Selected.Item("Valutatag"), objTransaction_FinancialTransaction.SemItem_FinancialTransaction)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_FinancialTransaction_loc.save_004_ToPay(objDRV_Selected.Item("Betrag"))
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Payment.GUID = Guid.NewGuid
                                objSemItem_Payment.Name = objDRV_Selected.Item("Betrag").ToString
                                objSemItem_Payment.GUID_Parent = objLocalConfig.SemItem_Type_Payment.GUID
                                objSemItem_Payment.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objSemItem_Sparkasse.GUID = objDRV_Selected.Item("GUID_Token")
                                objSemItem_Sparkasse.Name = objDRV_Selected.Item("Name_Token")
                                objSemItem_Sparkasse.GUID_Parent = objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse_.GUID
                                objSemItem_Sparkasse.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objSemItem_Result = objTransaction_FinancialTransaction_loc.save_013_Payment(objSemItem_Payment)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_FinancialTransaction_loc.save_014_Payment__Amount(objDRV_Selected.Item("Betrag"))
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_FinancialTransaction_loc.save_015_Payment__TransactionDate(objDRV_Selected.Item("Valutatag"))
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_FinancialTransaction_loc.save_016_FinancialTransaction_To_Payment()
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_FinancialTransaction_loc.save_017_Sparkasse_To_Payment(objSemItem_Sparkasse)

                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_FinancialTransaction_loc.save_018_Payment_PercentPart(100, objSemItem_Payment)
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        fill_TabPages()
                                                    Else

                                                        MsgBox("Die Transaktion konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                    End If
                                                Else

                                                    MsgBox("Die Transaktion konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                End If
                                            Else
                                                MsgBox("Die Transaktion konnte nicht vervollständigt werden!", MsgBoxStyle.Exclamation)
                                            End If
                                        Else
                                            MsgBox("Die Transaktion konnte nicht vervollständigt werden!", MsgBoxStyle.Exclamation)
                                        End If



                                    Else
                                        MsgBox("Die Transaktion konnte nicht vervollständigt werden!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    MsgBox("Die Transaktion konnte nicht vervollständigt werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Die Transaktion konnte nicht vervollständigt werden!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Die Transaktion konnte nicht vervollständigt werden!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                End If
            End If


        End If

    End Sub

    Private Sub ToolStripComboBox_SearchTemplates_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_SearchTemplates.SelectedIndexChanged
        ToolStripButton_SemItem.Enabled = False
        ToolStripTextBox_Search.Enabled = True
        'objSemItem_Search = Nothing
        Try
            Select Case ToolStripComboBox_SearchTemplates.ComboBox.SelectedValue
                Case objLocalConfig.SemItem_Token_Search_Template_Contractee_Contractor_.GUID
                    ToolStripButton_SemItem.Enabled = True
                Case objLocalConfig.SemItem_Token_Search_Template_Related_Sem_Item_.GUID
                    ToolStripTextBox_Search.Enabled = False
                    ToolStripButton_SemItem.Enabled = True


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ToolStripButton_SemItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_SemItem.Click

        Dim objDRV_Item As DataRowView

        Select Case ToolStripComboBox_SearchTemplates.ComboBox.SelectedValue
            Case objLocalConfig.SemItem_Token_Search_Template_Contractee_Contractor_.GUID
                objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Partner, objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                        If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                            objDRV_Item = objFrmSemManager.SelectedRows_Items(0).DataBoundItem
                            If objDRV_Item.Item("GUID_Type") = objLocalConfig.SemItem_Type_Partner.GUID Then
                                objSemItem_Search = New clsSemItem
                                objSemItem_Search.GUID = objDRV_Item.Item("GUID_Token")
                                objSemItem_Search.Name = objDRV_Item.Item("Name_Token")
                                objSemItem_Search.GUID_Parent = objDRV_Item.Item("GUID_Type")
                                objSemItem_Search.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                ToolStripTextBox_Search.Text = objSemItem_Search.Name
                            Else
                                MsgBox("Bitte nur Partner auswählen!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Bitte nur einen Partner auswählen!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Bitte nur Partner auswählen!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case objLocalConfig.SemItem_Token_Search_Template_Related_Sem_Item_.GUID
                objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                        If objFrmSemManager.SemItems_Selected.Count = 1 Then
                            objSemItem_Search = objFrmSemManager.SemItems_Selected(0)
                            ToolStripTextBox_Search.Text = objSemItem_Search.Name

                        Else
                            MsgBox("Bitte nur ein Item auswählen!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                            Select Case objFrmSemManager.SelectedItems_TypeGUID
                                Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                    objSemItem_Search = New clsSemItem
                                    objDRV_Item = objFrmSemManager.SelectedRows_Items(0).DataBoundItem
                                    objSemItem_Search.GUID = objDRV_Item.Item("GUID_Attribute")
                                    objSemItem_Search.Name = objDRV_Item.Item("Name_Attribute")
                                    objSemItem_Search.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                                    ToolStripTextBox_Search.Text = objSemItem_Search.Name
                                Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                                    objSemItem_Search = New clsSemItem
                                    objDRV_Item = objFrmSemManager.SelectedRows_Items(0).DataBoundItem
                                    objSemItem_Search.GUID = objDRV_Item.Item("GUID_RelationType")
                                    objSemItem_Search.Name = objDRV_Item.Item("Name_RelationType")
                                    objSemItem_Search.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                                    ToolStripTextBox_Search.Text = objSemItem_Search.Name
                                Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                    objSemItem_Search = New clsSemItem
                                    objDRV_Item = objFrmSemManager.SelectedRows_Items(0).DataBoundItem
                                    objSemItem_Search.GUID = objDRV_Item.Item("GUID_Token")
                                    objSemItem_Search.Name = objDRV_Item.Item("Name_Token")
                                    objSemItem_Search.GUID_Parent = objDRV_Item.Item("GUID_Type")
                                    objSemItem_Search.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                                    ToolStripTextBox_Search.Text = objSemItem_Search.Name
                            End Select
                        Else
                            MsgBox("Bitte nur ein Item auswählen!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                End If


        End Select

    End Sub

    Private Sub NewFromParentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFromParentToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Transactions.SelectedNode

        If objTreeNode.ImageIndex = cint_ImageID_Bill Then
            create_Bill(objTreeNode, objTreeNode.Text, True)
        End If

    End Sub

    Private Sub RemoveFromTreeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFromTreeToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Transactions.SelectedNode

        If objTreeNode.ImageIndex = cint_ImageID_Bill Then
            objTreeNode.Remove()
        End If
    End Sub
End Class
