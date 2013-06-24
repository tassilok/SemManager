Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "ecb262a9-1967-4ee8-964f-ca531b3253cf"

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection

    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter

    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter


    Private objGUID_Development As Guid

    'Attributes
    Private objSemItem_Attribute_Beg_nstigter_Zahlungspflichtiger As New clsSemItem
    Private objSemItem_Attribute_Buchungstext As New clsSemItem
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_Info As New clsSemItem
    Private objSemItem_Attribute_Verwendungszweck As New clsSemItem
    Private objSemItem_Attribute_Zahlungsausgang As New clsSemItem
    Private objSemItem_Attribute_First_Line_Col_Header As New clsSemItem
    Private objSemItem_Attribute_Valutatag As New clsSemItem
    Private objSemItem_Attribute_Betrag As New clsSemItem
    Private objSemItem_Attribute_Start As New clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_Auftragskonto As New clsSemItem
    Private objSemItem_RelationType_belonging As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_Gegenkonto As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem
    Private objSemItem_RelationType_belonging_Banks As New clsSemItem
    Private objSemItem_RelationType_works_with As New clsSemItem
    Private objSemItem_RelationType_imports_from As New clsSemItem
    Private objSemItem_RelationType_offers As New clsSemItem
    Private objSemItem_RelationType_provides As New clsSemItem
    Private objSemItem_RelationType_was_finished_with As New clsSemItem
    Private objSemItem_RelationType_Log_of As New clsSemItem
    Private objSemItem_RelationType_contains As New clsSemItem
    Private objSemItem_RelationType_belonging_Type As New clsSemItem
    Private objSemItem_RelationType_belonging_Token As New clsSemItem
    Private objSemItem_RelationType_belonging_RelationType As New clsSemItem
    Private objSemItem_RelationType_belonging_Attribute As New clsSemItem
    Private objSemItem_RelationType_is As New clsSemItem

    'Type
    Private objSemItem_Type_Alternate_Currency_Name As New clsSemItem
    Private objSemItem_Type_Bank_Transaktionen__Sparkasse_ As New clsSemItem
    Private objSemItem_Type_Bankleitzahl As New clsSemItem
    Private objSemItem_Type_Currencies As New clsSemItem
    Private objSemItem_Type_Kontonummer As New clsSemItem
    Private objSemItem_Type_Payment As New clsSemItem
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_Bank_Transaction_Module As New clsSemItem
    Private objSemItem_Type_Import_Settings As New clsSemItem
    Private objSemItem_Type_Text_Seperators As New clsSemItem
    Private objSemItem_Type_Text_Qualifier As New clsSemItem
    Private objSemItem_Type_File As New clsSemItem
    Private objSemItem_Type_LogEntry As New clsSemItem
    Private objSemItem_Type_Imports As New clsSemItem
    Private objSemItem_Type_Kontodaten As New clsSemItem
    Private objSemItem_Type_Bank_Transaktionen__Sparkasse____Archiv As New clsSemItem
    Private objSemItem_Type_Financial_Transaction___Archive As New clsSemItem
    Private objSemItem_Type_Report_Field As New clsSemItem
    Private objSemItem_Type_Ontology_Item As New clsSemItem
    Private objSemItem_Type_Ontology_Join As New clsSemItem
    Private objSemItem_Type_Partner As New clsSemItem

    'Token
    Private objSemItem_Token_Logstate_Config_Error As New clsSemItem

    Private objSemItem_Development As New clsSemItem
    Private objSemItem_Module As New clsSemItem
    Private objSemItem_BaseConfig As New clsSemItem

    'Attributes
    Public ReadOnly Property SemItem_Attribute_Beg_nstigter_Zahlungspflichtiger() As clsSemItem
        Get
            Return objSemItem_Attribute_Beg_nstigter_Zahlungspflichtiger
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Buchungstext() As clsSemItem
        Get
            Return objSemItem_Attribute_Buchungstext
        End Get
    End Property

    Public ReadOnly Property SemItem_attribute_dbPostfix() As clsSemItem
        Get
            Return objSemItem_attribute_dbPostfix
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Info() As clsSemItem
        Get
            Return objSemItem_Attribute_Info
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Verwendungszweck() As clsSemItem
        Get
            Return objSemItem_Attribute_Verwendungszweck
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Zahlungsausgang() As clsSemItem
        Get
            Return objSemItem_Attribute_Zahlungsausgang
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_First_Line_Col_Header() As clsSemItem
        Get
            Return objSemItem_Attribute_First_Line_Col_Header
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Valutatag() As clsSemItem
        Get
            Return objSemItem_Attribute_Valutatag
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Betrag() As clsSemItem
        Get
            Return objSemItem_Attribute_Betrag
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Start() As clsSemItem
        Get
            Return objSemItem_Attribute_Start
        End Get
    End Property

    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_Auftragskonto() As clsSemItem
        Get
            Return objSemItem_RelationType_Auftragskonto
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Gegenkonto() As clsSemItem
        Get
            Return objSemItem_RelationType_Gegenkonto
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Banks() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Banks
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_works_with() As clsSemItem
        Get
            Return objSemItem_RelationType_works_with
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_imports_from() As clsSemItem
        Get
            Return objSemItem_RelationType_imports_from
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offers() As clsSemItem
        Get
            Return objSemItem_RelationType_offers
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_provides() As clsSemItem
        Get
            Return objSemItem_RelationType_provides
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_was_finished_with() As clsSemItem
        Get
            Return objSemItem_RelationType_was_finished_with
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Log_of() As clsSemItem
        Get
            Return objSemItem_RelationType_Log_of
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_contains() As clsSemItem
        Get
            Return objSemItem_RelationType_contains
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Type() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Token() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_RelationType() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_RelationType
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Attribute() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Attribute
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is() As clsSemItem
        Get
            Return objSemItem_RelationType_is
        End Get
    End Property

    'Types
    Public ReadOnly Property SemItem_Type_Alternate_Currency_Name() As clsSemItem
        Get
            Return objSemItem_Type_Alternate_Currency_Name
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

    Public ReadOnly Property SemItem_Type_Currencies() As clsSemItem
        Get
            Return objSemItem_Type_Currencies
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Kontonummer() As clsSemItem
        Get
            Return objSemItem_Type_Kontonummer
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Payment() As clsSemItem
        Get
            Return objSemItem_Type_Payment
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Bank_Transaction_Module() As clsSemItem
        Get
            Return objSemItem_Type_Bank_Transaction_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Text_Seperators() As clsSemItem
        Get
            Return objSemItem_Type_Text_Seperators
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Text_Qualifier() As clsSemItem
        Get
            Return objSemItem_Type_Text_Qualifier
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_File() As clsSemItem
        Get
            Return objSemItem_Type_File
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Kontodaten() As clsSemItem
        Get
            Return objSemItem_Type_Kontodaten
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Partner() As clsSemItem
        Get
            Return objSemItem_Type_Partner
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

    Public ReadOnly Property SemItem_Type_Import_Settings() As clsSemItem
        Get
            Return objSemItem_Type_Import_Settings
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_LogEntry() As clsSemItem
        Get
            Return objSemItem_Type_LogEntry
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Imports() As clsSemItem
        Get
            Return objSemItem_Type_Imports
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Bank_Transaktionen__Sparkasse____Archiv() As clsSemItem
        Get
            Return objSemItem_Type_Bank_Transaktionen__Sparkasse____Archiv
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Financial_Transaction___Archive() As clsSemItem
        Get
            Return objSemItem_Type_Financial_Transaction___Archive
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Report_Field() As clsSemItem
        Get
            Return objSemItem_Type_Report_Field
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Ontology_Item() As clsSemItem
        Get
            Return objSemItem_Type_Ontology_Item
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Ontology_Join() As clsSemItem
        Get
            Return objSemItem_Type_Ontology_Join
        End Get
    End Property

    'Token
    Public ReadOnly Property SemItem_Token_Logstate_Config_Error() As clsSemItem
        Get
            Return objSemItem_Token_Logstate_Config_Error
        End Get
    End Property

    Public ReadOnly Property SemItem_BaseConfig As clsSemItem
        Get
            Return objSemItem_BaseConfig
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Buchungstext'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Buchungstext.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Buchungstext.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Buchungstext.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Buchungstext.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Info'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Info.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Info.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Info.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Info.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Verwendungszweck'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Verwendungszweck.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Verwendungszweck.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Verwendungszweck.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Verwendungszweck.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_First_Line_Col_Header'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_First_Line_Col_Header.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_First_Line_Col_Header.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_First_Line_Col_Header.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_First_Line_Col_Header.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Start'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Start.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Start.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Start.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Start.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Auftragskonto'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Auftragskonto.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Auftragskonto.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Auftragskonto.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Banks'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Banks.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Banks.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Banks.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_works_with'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_works_with.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_works_with.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_works_with.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_imports_from'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_imports_from.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_imports_from.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_imports_from.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_provides'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_provides.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_provides.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_provides.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_was_finished_with'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_was_finished_with.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_was_finished_with.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_was_finished_with.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Log_of'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Log_of.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Log_of.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Log_of.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Type'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Type.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Type.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Type.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Token'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Token.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Token.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Token.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_RelationType'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_RelationType.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_RelationType.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_RelationType.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Attribute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Attribute.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Attribute.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Attribute.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_is'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_is.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_is.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_is.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

    End Sub

    Private Sub get_Config_Token()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        funcA_TokenToken.Connection = Connection_DB

        objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Development.GUID, _
                                                                   objSemItem_RelationType_offered_by.GUID, _
                                                                   objSemItem_Type_Module.GUID).Rows
        If objDRC_Ref.Count > 0 Then
            objSemItem_Module.GUID = objDRC_Ref(0).Item("GUID_Token_Left")
            objSemItem_Module.Name = objDRC_Ref(0).Item("Name_Token_Left")
            objSemItem_Module.GUID_Parent = objSemItem_Type_Module.GUID
            objSemItem_Module.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Module.GUID, _
                                                                       objSemItem_RelationType_belongsTo.GUID, _
                                                                       objSemItem_Type_Bank_Transaction_Module.GUID).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_BaseConfig.GUID = objDRC_Ref(0).Item("GUID_TokeN_Left")
                objSemItem_BaseConfig.Name = objDRC_Ref(0).Item("Name_Token_Left")
                objSemItem_BaseConfig.GUID_Parent = objSemItem_Type_Bank_Transaction_Module.GUID
                objSemItem_BaseConfig.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

            End If
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_Config_Error'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_Config_Error.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_Config_Error.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_Config_Error.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_Config_Error.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Alternate_Currency_Name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Alternate_Currency_Name.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Alternate_Currency_Name.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Alternate_Currency_Name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Alternate_Currency_Name.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Bank_Transaction_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Bank_Transaction_Module.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Bank_Transaction_Module.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Bank_Transaction_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Bank_Transaction_Module.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Import_Settings'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Import_Settings.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Import_Settings.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Import_Settings.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Import_Settings.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Text_Seperators'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Text_Seperators.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Text_Seperators.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Text_Seperators.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Text_Seperators.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Text_Qualifier'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Text_Qualifier.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Text_Qualifier.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Text_Qualifier.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Text_Qualifier.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_File'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_File.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_File.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_File.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_File.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_LogEntry'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_LogEntry.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_LogEntry.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_LogEntry.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_LogEntry.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Imports'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Imports.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Imports.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Imports.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Imports.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Kontodaten'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Kontodaten.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Kontodaten.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Kontodaten.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Kontodaten.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Bank_Transaktionen__Sparkasse____Archiv'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Bank_Transaktionen__Sparkasse____Archiv.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Bank_Transaktionen__Sparkasse____Archiv.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Bank_Transaktionen__Sparkasse____Archiv.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Bank_Transaktionen__Sparkasse____Archiv.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Financial_Transaction___Archive'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Financial_Transaction___Archive.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Financial_Transaction___Archive.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Financial_Transaction___Archive.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Financial_Transaction___Archive.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Report_Field'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Report_Field.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Report_Field.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Report_Field.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Report_Field.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Ontology_Item'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Ontology_Item.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Ontology_Item.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Ontology_Item.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Ontology_Item.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Ontology_Join'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Ontology_Join.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Ontology_Join.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Ontology_Join.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Ontology_Join.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

    End Sub
End Class
