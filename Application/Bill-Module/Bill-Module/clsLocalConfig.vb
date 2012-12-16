Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c"

    Private boolGrossStandard As Boolean

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection

    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter
    Private procA_Languages_Of_Module As New ds_FinancialTransactionTableAdapters.proc_Languages_Of_BillModuleTableAdapter
    Private procA_StandardCurrency_Of_BillModule As New ds_FinancialTransactionTableAdapters.proc_StandardCurrency_Of_BillModuleTableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter


    Private objGUID_Development As Guid
    Private objSemItem_Development As clsSemItem
    Private objSemItem_Module As clsSemItem

    'Attributes
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_Transaction_Date As New clsSemItem
    Private objSemItem_Attribute_to_Pay As New clsSemItem
    Private objSemItem_Attribute_gross As New clsSemItem
    Private objSemItem_Attribute_Menge As New clsSemItem
    Private objSemItem_Attribute_Amount As New clsSemItem
    Private objSemItem_Attribute_Transaction_ID As New clsSemItem
    Private objSemItem_Attribute_Gross__Standard_ As New clsSemItem
    Private objSemItem_Attribute_Zahlungsausgang As New clsSemItem
    Private objSemItem_Attribute_Betrag As New clsSemItem
    Private objSemItem_Attribute_Beg_nstigter_Zahlungspflichtiger As New clsSemItem
    Private objSemItem_Attribute_Valutatag As New clsSemItem
    Private objSemItem_Attribute_part____ As New clsSemItem

    'Token
    Private objSemItem_Token_Currency_Standard As New clsSemItem
    Private objSemItems_Token_Language() As clsSemItem
    Private objSemItem_Token_Direction_Up As New clsSemItem
    Private objSemItem_Token_Direction_Down As New clsSemItem
    Private objSemItem_Token_Search_Template_Transaction_Date_ As New clsSemItem
    Private objSemItem_Token_Search_Template_to_Pay_ As New clsSemItem
    Private objSemItem_Token_Search_Template_Payment_Date_ As New clsSemItem
    Private objSemItem_Token_Search_Template_Name_ As New clsSemItem
    Private objSemItem_Token_Search_Template_Amount_ As New clsSemItem
    Private objSemItem_Token_TaxRate_Standard As New clsSemItem
    Private objSemItem_Token_Baseconfig As New clsSemItem
    Private objSemItem_Token_Search_Template_Contractee_Contractor_ As New clsSemItem
    Private objSemItem_Token_Search_Template_Related_Sem_Item_ As New clsSemItem


    'Types
    Private objSemItem_Type_Tax_Rates As New clsSemItem
    Private objSemItem_Type_Payment As New clsSemItem
    Private objSemItem_Type_Partner As New clsSemItem
    Private objSemItem_Type_Menge As New clsSemItem
    Private objSemItem_Type_Financial_Transaction As New clsSemItem
    Private objSemItem_Type_Currencies As New clsSemItem
    Private objSemItem_Type_Einheit As New clsSemItem
    Private objSemItem_Type_Bill_Module As New clsSemItem
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_Language As New clsSemItem
    Private objSemItem_Type_Container__physical_ As New clsSemItem
    Private objSemItem_Type_Beleg As New clsSemItem
    Private objSemItem_Type_Belegsart As New clsSemItem
    Private objSemItem_Type_Search_Template As New clsSemItem
    Private objSemItem_Type_Bank_Transaktionen__Sparkasse_ As New clsSemItem
    Private objSemItem_Type_Bankleitzahl As New clsSemItem
    Private objSemItem_Type_Kontonummer As New clsSemItem
    Private objSemItem_Type_Offset As New clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_belonging_Tax_Rate As New clsSemItem
    Private objSemItem_RelationType_belonging_Sem_Item As New clsSemItem
    Private objSemItem_RelationType_belonging_Payment As New clsSemItem
    Private objSemItem_RelationType_belonging_Currency As New clsSemItem
    Private objSemItem_RelationType_belonging_Contractor As New clsSemItem
    Private objSemItem_RelationType_belonging_Contractee As New clsSemItem
    Private objSemItem_RelationType_belonging_Amount As New clsSemItem
    Private objSemItem_RelationType_is_of_Type As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_zugeh_rige_Mandanten As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem
    Private objSemItem_RelationType_contains As New clsSemItem
    Private objSemItem_RelationType_isDescribedBy As New clsSemItem
    Private objSemItem_RelationType_Standard As New clsSemItem
    Private objSemItem_RelationType_located_in As New clsSemItem
    Private objSemItem_RelationType_offers As New clsSemItem
    Private objSemItem_RelationType_Gegenkonto As New clsSemItem
    Private objSemItem_RelationType_accountings As New clsSemItem

    Public Property GrossStandard As Boolean
        Get
            Return boolGrossStandard
        End Get
        Set(ByVal value As Boolean)
            boolGrossStandard = value
        End Set
    End Property

    'Attributes
    Public ReadOnly Property SemItem_attribute_dbPostfix() As clsSemItem
        Get
            Return objSemItem_attribute_dbPostfix
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Transaction_Date() As clsSemItem
        Get
            Return objSemItem_Attribute_Transaction_Date
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_to_Pay() As clsSemItem
        Get
            Return objSemItem_Attribute_to_Pay
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_gross() As clsSemItem
        Get
            Return objSemItem_Attribute_gross
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Menge() As clsSemItem
        Get
            Return objSemItem_Attribute_Menge
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Amount() As clsSemItem
        Get
            Return objSemItem_Attribute_Amount
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Transaction_ID() As clsSemItem
        Get
            Return objSemItem_Attribute_Transaction_ID
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Gross__Standard_() As clsSemItem
        Get
            Return objSemItem_Attribute_Gross__Standard_
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Zahlungsausgang() As clsSemItem
        Get
            Return objSemItem_Attribute_Zahlungsausgang
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Betrag() As clsSemItem
        Get
            Return objSemItem_Attribute_Betrag
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Beg_nstigter_Zahlungspflichtiger() As clsSemItem
        Get
            Return objSemItem_Attribute_Beg_nstigter_Zahlungspflichtiger
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Valutatag() As clsSemItem
        Get
            Return objSemItem_Attribute_Valutatag
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_part____() As clsSemItem
        Get
            Return objSemItem_Attribute_part____
        End Get
    End Property

    'Token
    Public ReadOnly Property SemItems_Token_Languages() As clsSemItem()
        Get
            Return objSemItems_Token_Language
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_StandardCurrency As clsSemItem
        Get
            Return objSemItem_Token_Currency_Standard
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Direction_Up() As clsSemItem
        Get
            Return objSemItem_Token_Direction_Up
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Direction_Down() As clsSemItem
        Get
            Return objSemItem_Token_Direction_Down
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Search_Template_Transaction_Date_() As clsSemItem
        Get
            Return objSemItem_Token_Search_Template_Transaction_Date_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Search_Template_to_Pay_() As clsSemItem
        Get
            Return objSemItem_Token_Search_Template_to_Pay_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Search_Template_Payment_Date_() As clsSemItem
        Get
            Return objSemItem_Token_Search_Template_Payment_Date_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Search_Template_Name_() As clsSemItem
        Get
            Return objSemItem_Token_Search_Template_Name_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Search_Template_Amount_() As clsSemItem
        Get
            Return objSemItem_Token_Search_Template_Amount_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_TaxRate_Standard As clsSemItem
        Get
            Return objSemItem_Token_TaxRate_Standard
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Baseconfig As clsSemItem
        Get
            Return objSemItem_Token_Baseconfig
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Search_Template_Contractee_Contractor_() As clsSemItem
        Get
            Return objSemItem_Token_Search_Template_Contractee_Contractor_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Search_Template_Related_Sem_Item_() As clsSemItem
        Get
            Return objSemItem_Token_Search_Template_Related_Sem_Item_
        End Get
    End Property

    'Types
    Public ReadOnly Property SemItem_Type_Tax_Rates() As clsSemItem
        Get
            Return objSemItem_Type_Tax_Rates
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Payment() As clsSemItem
        Get
            Return objSemItem_Type_Payment
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Partner() As clsSemItem
        Get
            Return objSemItem_Type_Partner
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Menge() As clsSemItem
        Get
            Return objSemItem_Type_Menge
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Financial_Transaction() As clsSemItem
        Get
            Return objSemItem_Type_Financial_Transaction
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Currencies() As clsSemItem
        Get
            Return objSemItem_Type_Currencies
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Einheit() As clsSemItem
        Get
            Return objSemItem_Type_Einheit
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Bill_Module() As clsSemItem
        Get
            Return objSemItem_Type_Bill_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Language() As clsSemItem
        Get
            Return objSemItem_Type_Language
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Container__physical_() As clsSemItem
        Get
            Return objSemItem_Type_Container__physical_
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Beleg() As clsSemItem
        Get
            Return objSemItem_Type_Beleg
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Belegsart() As clsSemItem
        Get
            Return objSemItem_Type_Belegsart
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Search_Template() As clsSemItem
        Get
            Return objSemItem_Type_Search_Template
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Bank_Transaktionen__Sparkasse_() As clsSemItem
        Get
            Return objSemItem_Type_Bank_Transaktionen__Sparkasse_
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Bankleitzahl() As clsSemItem
        Get
            Return objSemItem_Type_Bankleitzahl
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Kontonummer() As clsSemItem
        Get
            Return objSemItem_Type_Kontonummer
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Offset() As clsSemItem
        Get
            Return objSemItem_Type_Offset
        End Get
    End Property

    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_belonging_Tax_Rate() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Tax_Rate
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Sem_Item() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Sem_Item
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Payment() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Payment
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Currency() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Currency
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Contractor() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Contractor
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Contractee() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Contractee
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Amount() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Amount
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is_of_Type() As clsSemItem
        Get
            Return objSemItem_RelationType_is_of_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_zugeh_rige_Mandanten() As clsSemItem
        Get
            Return objSemItem_RelationType_zugeh_rige_Mandanten
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_contains() As clsSemItem
        Get
            Return objSemItem_RelationType_contains
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_isDescribedBy() As clsSemItem
        Get
            Return objSemItem_RelationType_isDescribedBy
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Standard() As clsSemItem
        Get
            Return objSemItem_RelationType_Standard
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_located_in() As clsSemItem
        Get
            Return objSemItem_RelationType_located_in
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offers() As clsSemItem
        Get
            Return objSemItem_RelationType_offers
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Gegenkonto() As clsSemItem
        Get
            Return objSemItem_RelationType_Gegenkonto
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_accountings() As clsSemItem
        Get
            Return objSemItem_RelationType_accountings
        End Get
    End Property

    Public ReadOnly Property SemItem_Development As clsSemItem
        Get
            Return objSemItem_Development
        End Get
    End Property


    Public ReadOnly Property SemItem_Module As clsSemItem
        Get
            Return objSemItem_Module
        End Get
    End Property
    Public ReadOnly Property Connection_DB() As SqlClient.SqlConnection
        Get
            Return objConnection_DB
        End Get
    End Property

    Public ReadOnly Property Connection_Plugin() As SqlClient.SqlConnection
        Get
            Return objConnection_Plugin
        End Get
    End Property

    Public ReadOnly Property Globals() As clsGlobals
        Get
            Return objGlobals
        End Get
    End Property

    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals
        objConnection_DB = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        objConnection_Config = New SqlClient.SqlConnection(objGlobals.ConnectionString_System)

        objGUID_Development = New Guid(cstr_GUIDToken_Development)
        objSemItem_Development = New clsSemItem
        objSemItem_Development.GUID = objGUID_Development

        set_DBConnection()
        get_Config()
    End Sub

    Private Sub set_DBConnection()
        funcA_SoftwareDevelopment_Config.Connection = objConnection_Config

        procA_TokenAttribute_Varchar255.Connection = objConnection_Config

        procA_OR_Attribute_By_GUIDObjectReference.Connection = objConnection_Config
        procA_OR_RelationType_By_GUIDObjectReference.Connection = objConnection_Config
        procA_OR_Token_By_GUID.Connection = objConnection_Config
        procA_OR_Type_By_GUID.Connection = objConnection_Config

        funcA_TokenToken.Connection = objConnection_DB
    End Sub

    Private Sub get_Config()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection
        funcA_SoftwareDevelopment_Config.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_Config, objGUID_Development)

        get_Config_Attributes()
        get_Config_RelationTypes()
        get_Config_Types()
        get_Config_Token()

    End Sub

    Private Sub get_Config_Attributes()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='attribute_dbPostfix'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_attribute_dbPostfix.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_attribute_dbPostfix.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_attribute_dbPostfix.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_attribute_dbPostfix.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID

                objDRC_RelData = procA_TokenAttribute_Varchar255.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_Development.GUID, objSemItem_attribute_dbPostfix.GUID).Rows

                objConnection_Plugin = New SqlClient.SqlConnection(objGlobals.get_DB_ConnectionString(objDRC_RelData(0).Item("Val")))
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Transaction_Date'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Transaction_Date.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Transaction_Date.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Transaction_Date.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Transaction_Date.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_to_Pay'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_to_Pay.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_to_Pay.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_to_Pay.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_to_Pay.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_gross'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_gross.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_gross.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_gross.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_gross.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Menge'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Menge.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Menge.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Menge.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Menge.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Amount'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Amount.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Amount.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Amount.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Amount.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Transaction_ID'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Transaction_ID.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Transaction_ID.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Transaction_ID.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Transaction_ID.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Gross__Standard_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Gross__Standard_.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Gross__Standard_.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Gross__Standard_.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Gross__Standard_.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Zahlungsausgang'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Zahlungsausgang.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Zahlungsausgang.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Zahlungsausgang.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Zahlungsausgang.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Betrag'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Betrag.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Betrag.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Betrag.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Betrag.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Beg_nstigter_Zahlungspflichtiger'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Beg_nstigter_Zahlungspflichtiger.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Beg_nstigter_Zahlungspflichtiger.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Beg_nstigter_Zahlungspflichtiger.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Beg_nstigter_Zahlungspflichtiger.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Valutatag'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Valutatag.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Valutatag.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Valutatag.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Valutatag.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_part____'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_part____.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_part____.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_part____.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_part____.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub

    Private Sub get_Config_RelationTypes()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Tax_Rate'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Tax_Rate.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Tax_Rate.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Tax_Rate.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Sem_Item'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Sem_Item.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Sem_Item.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Sem_Item.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Payment'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Payment.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Payment.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Payment.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Currency'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Currency.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Currency.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Currency.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Contractor'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Contractor.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Contractor.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Contractor.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Contractee'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Contractee.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Contractee.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Contractee.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Amount'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Amount.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Amount.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Amount.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_is_of_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_is_of_Type.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_is_of_Type.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_is_of_Type.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belongsTo'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belongsTo.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belongsTo.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belongsTo.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_zugeh_rige_Mandanten'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_zugeh_rige_Mandanten.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_zugeh_rige_Mandanten.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_zugeh_rige_Mandanten.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_offered_by'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_offered_by.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_offered_by.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_offered_by.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_contains'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_contains.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_contains.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_contains.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_isDescribedBy'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_isDescribedBy.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_isDescribedBy.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_isDescribedBy.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Standard'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Standard.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Standard.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Standard.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_located_in'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_located_in.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_located_in.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_located_in.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_offers'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_offers.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_offers.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_offers.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Gegenkonto'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Gegenkonto.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Gegenkonto.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Gegenkonto.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_accountings'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_accountings.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_accountings.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_accountings.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub

    Private Sub get_Config_Token()
        Dim objDRC_Currency As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection
        Dim objDRC_Languages As DataRowCollection
        Dim objDR_Language As DataRow
        Dim objDRC_Module As DataRowCollection
        Dim intLanguageID As Integer

        procA_Languages_Of_Module.Connection = Connection_Plugin
        procA_StandardCurrency_Of_BillModule.Connection = Connection_Plugin

        objSemItems_Token_Language = Nothing

        objDRC_Languages = procA_Languages_Of_Module.GetData(SemItem_Type_Language.GUID, _
                                                             SemItem_Type_Module.GUID, _
                                                             SemItem_Type_Bill_Module.GUID, _
                                                             SemItem_RelationType_isDescribedBy.GUID, _
                                                             SemItem_RelationType_belongsTo.GUID, _
                                                             SemItem_RelationType_offered_by.GUID, _
                                                             SemItem_Development.GUID).Rows
        For Each objDR_Language In objDRC_Languages
            If objSemItems_Token_Language Is Nothing Then
                intLanguageID = 0
            Else
                intLanguageID = objSemItems_Token_Language.Length
            End If
            ReDim Preserve objSemItems_Token_Language(intLanguageID)
            objSemItems_Token_Language(intLanguageID) = New clsSemItem
            objSemItems_Token_Language(intLanguageID).GUID = objDR_Language.Item("GUID_Language")
            objSemItems_Token_Language(intLanguageID).Name = objDR_Language.Item("Name_Language")
            objSemItems_Token_Language(intLanguageID).GUID_Parent = SemItem_Type_Language.GUID
            objSemItems_Token_Language(intLanguageID).GUID_Type = Globals.ObjectReferenceType_Token.GUID

        Next
        objDRC_Currency = procA_StandardCurrency_Of_BillModule.GetData(SemItem_Type_Currencies.GUID, _
                                                                           SemItem_Type_Module.GUID, _
                                                                           SemItem_Type_Bill_Module.GUID, _
                                                                           SemItem_RelationType_Standard.GUID, _
                                                                           SemItem_RelationType_belongsTo.GUID, _
                                                                           SemItem_RelationType_offered_by.GUID, _
                                                                           objSemItem_Development.GUID).Rows
        If objDRC_Currency.Count > 0 Then
            objSemItem_Token_Currency_Standard.GUID = objDRC_Currency(0).Item("GUID_Currencies")
            objSemItem_Token_Currency_Standard.Name = objDRC_Currency(0).Item("Name_Currencies")
            objSemItem_Token_Currency_Standard.GUID_Parent = objDRC_Currency(0).Item("GUID_Type_Currencies")
            objSemItem_Token_Currency_Standard.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

        Else
            objSemItem_Token_Currency_Standard = Nothing
        End If

        objDRC_Module = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Development.GUID, _
                                                                      SemItem_RelationType_offered_by.GUID, _
                                                                      SemItem_Type_Module.GUID).Rows
        If objDRC_Module.Count > 0 Then
            objSemItem_Module = New clsSemItem
            objSemItem_Module.GUID = objDRC_Module(0).Item("GUID_Token_Left")
            objSemItem_Module.Name = objDRC_Module(0).Item("Name_Token_Left")
            objSemItem_Module.GUID_Parent = objSemItem_Type_Module.GUID
            objSemItem_Module.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Direction_Up'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Direction_Up.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Direction_Up.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Direction_Up.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Direction_Up.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Direction_Down'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Direction_Down.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Direction_Down.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Direction_Down.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Direction_Down.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Search_Template_Transaction_Date_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Search_Template_Transaction_Date_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Search_Template_Transaction_Date_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Search_Template_Transaction_Date_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Search_Template_Transaction_Date_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Search_Template_to_Pay_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Search_Template_to_Pay_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Search_Template_to_Pay_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Search_Template_to_Pay_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Search_Template_to_Pay_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Search_Template_Payment_Date_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Search_Template_Payment_Date_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Search_Template_Payment_Date_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Search_Template_Payment_Date_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Search_Template_Payment_Date_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Search_Template_Name_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Search_Template_Name_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Search_Template_Name_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Search_Template_Name_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Search_Template_Name_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Search_Template_Amount_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Search_Template_Amount_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Search_Template_Amount_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Search_Template_Amount_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Search_Template_Amount_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Module.GUID, _
                                                                   objSemItem_RelationType_belongsTo.GUID, _
                                                                   objSemItem_Type_Bill_Module.GUID).Rows
        If objDRC_Ref.Count > 0 Then
            objSemItem_Token_Baseconfig.GUID = objDRC_Ref(0).Item("GUID_Token_Left")
            objSemItem_Token_Baseconfig.Name = objDRC_Ref(0).Item("Name_Token_Left")
            objSemItem_Token_Baseconfig.GUID_Parent = objSemItem_Type_Bill_Module.GUID
            objSemItem_Token_Baseconfig.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

            objDRC_Ref = funcA_TokenToken.GetData_TokenToken_LeftRight(objDRC_Ref(0).Item("GUID_Token_Left"), _
                                                                       objSemItem_RelationType_Standard.GUID, _
                                                                       objSemItem_Type_Tax_Rates.GUID).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_TaxRate_Standard.GUID = objDRC_Ref(0).Item("GUID_Token_Right")
                objSemItem_Token_TaxRate_Standard.Name = objDRC_Ref(0).Item("Name_Token_Right")
                objSemItem_Token_TaxRate_Standard.GUID_Parent = objSemItem_Type_Tax_Rates.GUID
                objSemItem_Token_TaxRate_Standard.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

            End If
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Search_Template_Contractee_Contractor_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Search_Template_Contractee_Contractor_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Search_Template_Contractee_Contractor_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Search_Template_Contractee_Contractor_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Search_Template_Contractee_Contractor_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Search_Template_Related_Sem_Item_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Search_Template_Related_Sem_Item_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Search_Template_Related_Sem_Item_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Search_Template_Related_Sem_Item_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Search_Template_Related_Sem_Item_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub

    Private Sub get_Config_Types()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Tax_Rates'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Tax_Rates.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Tax_Rates.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Tax_Rates.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Tax_Rates.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Payment'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Payment.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Payment.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Payment.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Payment.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Partner'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Partner.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Partner.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Partner.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Partner.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Menge'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Menge.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Menge.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Menge.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Menge.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Financial_Transaction'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Financial_Transaction.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Financial_Transaction.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Financial_Transaction.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Financial_Transaction.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Currencies'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Currencies.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Currencies.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Currencies.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Currencies.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Einheit'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Einheit.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Einheit.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Einheit.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Einheit.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Bill_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Bill_Module.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Bill_Module.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Bill_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Bill_Module.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Module.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Module.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Module.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Language'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Language.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Language.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Language.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Language.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Container__physical_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Container__physical_.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Container__physical_.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Container__physical_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Container__physical_.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Beleg'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Beleg.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Beleg.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Beleg.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Beleg.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Belegsart'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Belegsart.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Belegsart.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Belegsart.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Belegsart.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Search_Template'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Search_Template.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Search_Template.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Search_Template.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Search_Template.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Bank_Transaktionen__Sparkasse_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Bank_Transaktionen__Sparkasse_.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Bank_Transaktionen__Sparkasse_.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Bank_Transaktionen__Sparkasse_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Bank_Transaktionen__Sparkasse_.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Bankleitzahl'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Bankleitzahl.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Bankleitzahl.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Bankleitzahl.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Bankleitzahl.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Kontonummer'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Kontonummer.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Kontonummer.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Kontonummer.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Kontonummer.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Offset'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Offset.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Offset.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Offset.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Offset.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub
End Class

