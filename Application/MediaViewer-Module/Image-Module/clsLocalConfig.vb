Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "b8e5b73f-c84a-48f7-ad9e-48d1ad6c7d66"

    Private objGlobals As Sem_Manager.clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection

    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable
    Private funcA_TokenAttribute_VARCHARMAX As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter


    Private objGUID_Development As Guid
    Private objSemItem_Development As clsSemItem
    Private objSemItem_Module As clsSemItem
    Private objSemItem_BaseConfig As clsSemItem
    Private objSemItem_UrlService As clsSemItem

    'Attributes
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_ID As New clsSemItem
    Private objSemItem_Attribute_Media_Position As New clsSemItem
    Private objSemItem_Attribute_Titel As New clsSemItem
    Private objSemItem_Attribute_L_nge__Minuten_ As New clsSemItem
    Private objSemItem_Attribute_comment As New clsSemItem
    Private objSemItem_Attribute_taking As New clsSemItem
    Private objSemItem_Attribute_DateTimeStamp As New clsSemItem
    Private objSemItem_Attribute_XML_Text As New clsSemItem

    'Types
    Private objSemItem_Type_Images__Graphic_ As New clsSemItem
    Private objSemItem_Type_File As New clsSemItem
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_Image_Module As New clsSemItem
    Private objSemItem_Type_Language As New clsSemItem
    Private objSemItem_Type_PDF_Documents As New clsSemItem
    Private objSemItem_Type_Media_Item_Range As New clsSemItem
    Private objSemItem_Type_Media_Item_Bookmark As New clsSemItem
    Private objSemItem_Type_Media_Item As New clsSemItem
    Private objSemItem_Type_Filetypes As New clsSemItem
    Private objSemItem_Type_Search_Template As New clsSemItem
    Private objSemItem_Type_Year As New clsSemItem
    Private objSemItem_Type_Partner As New clsSemItem
    Private objSemItem_Type_Media As New clsSemItem
    Private objSemItem_Type_Genre As New clsSemItem
    Private objSemItem_Type_Band As New clsSemItem
    Private objSemItem_Type_Album As New clsSemItem
    Private objSemItem_Type_mp3_File As New clsSemItem
    Private objSemItem_Type_Day As New clsSemItem
    Private objSemItem_Type_Month As New clsSemItem
    Private objSemItem_type_User As New clsSemItem
    Private objSemItem_Type_LogEntry As New clsSemItem
    Private objSemItem_Type_Ort As New clsSemItem
    Private objSemItem_Type_Image_Objects As New clsSemItem
    Private objSemItem_Type_Image_Objects__No_Objects_ As New clsSemItem
    Private objSemItem_Type_Bauwerke As New clsSemItem
    Private objSemItem_Type_Haustier As New clsSemItem
    Private objSemItem_Type_Tierarten As New clsSemItem
    Private objSemItem_Type_Pflanzenarten As New clsSemItem
    Private objSemItem_Type_Wichtige_Ereignisse As New clsSemItem
    Private objSemItem_Type_landscape As New clsSemItem
    Private objSemItem_Type_Wetterlage As New clsSemItem
    Private objSemItem_Type_Kunst As New clsSemItem
    Private objSemItem_Type_Url As New clsSemItem

    'Token
    Private objSemItem_Token_Extensions_Image As New clsSemItem
    Private objSemItem_Token_Extensions_pdf As New clsSemItem
    Private objSemItem_Token_Extensions_mod As New clsSemItem
    Private objSemItem_Token_Logstate_User_Defined As New clsSemItem
    Private objSemItem_Token_Logstate_Last_Position As New clsSemItem
    Private objSemItem_Token_Logstate_Start As New clsSemItem
    Private objSemItem_Token_Logstate_Stop As New clsSemItem
    Private objSemItem_Token_Search_Template_Name_ As New clsSemItem
    Private objSemItem_Token_Logstate_Unassigned As New clsSemItem
    Private objSemItem_Token_Logstate_Pause As New clsSemItem
    Private objSemItem_Token_Image_Objects__No_Objects__weather_condition As New clsSemItem
    Private objSemItem_Token_Image_Objects__No_Objects__no_Symbol As New clsSemItem
    Private objSemItem_Token_Image_Objects__No_Objects__no_Persons As New clsSemItem
    Private objSemItem_Token_Image_Objects__No_Objects__no_Location As New clsSemItem
    Private objSemItem_Token_Image_Objects__No_Objects__no_landscape As New clsSemItem
    Private objSemItem_Token_Image_Objects__No_Objects__no_Address As New clsSemItem
    Private objSemItem_Token_Image_Objects__No_Objects__no_species As New clsSemItem
    Private objSemItem_Token_Image_Objects__No_Objects__no_Pets As New clsSemItem
    Private objSemItem_Token_Image_Objects__No_Objects__no_Buildings As New clsSemItem
    Private objSemItem_Token_Image_Objects__No_Objects__no_plant_Species As New clsSemItem
    Private objSemItem_Token_Image_Objects__No_Objects__no_Artwork As New clsSemItem
    Private objSemItem_Token_XML_Windows_Playlist_1_0_mediasrc As New clsSemItem
    Private objSemItem_Token_XML_Windows_Playlist_1_0 As New clsSemItem
    Private objSemItem_Token_Variable_URL_MEDIASRC As New clsSemItem
    Private objSemItem_Token_Variable_MEDIASRC As New clsSemItem
    Private objSemItem_Token_Variable_title As New clsSemItem
    Private objSemItem_Token_Variable_ITEMCOUNT As New clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_belonging_Source As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem
    Private objSemItem_RelationType_isDescribedBy As New clsSemItem
    Private objSemItem_RelationType_is_of_Type As New clsSemItem
    Private objSemItem_RelationType_is_used_by As New clsSemItem
    Private objSemItem_RelationType_finished_with As New clsSemItem
    Private objSemItem_RelationType_started_with As New clsSemItem
    Private objSemItem_RelationType_offers As New clsSemItem
    Private objSemItem_RelationType_from As New clsSemItem
    Private objSemItem_RelationType_Disc As New clsSemItem
    Private objSemItem_RelationType_Composer As New clsSemItem
    Private objSemItem_RelationType_Artist As New clsSemItem
    Private objSemItem_RelationType_taking_at As New clsSemItem
    Private objSemItem_RelationType_belonging_Done As New clsSemItem
    Private objSemItem_RelationType_is As New clsSemItem
    Private objSemItem_RelationType_located_in As New clsSemItem
    Private objSemItem_RelationType_has As New clsSemItem
    Private objSemItem_RelationType_wasCreatedBy As New clsSemItem
    Private objSemItem_RelationType_Media_Webservice_Url As New clsSemItem
    Private objSemItem_RelationType_contains As New clsSemItem

    Private strXML_WPL1 As String
    Private strXML_WPL_SRCURL As String

    'Attributes
    Public ReadOnly Property SemItem_attribute_dbPostfix() As clsSemItem
        Get
            Return objSemItem_attribute_dbPostfix
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_ID() As clsSemItem
        Get
            Return objSemItem_Attribute_ID
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Media_Position() As clsSemItem
        Get
            Return objSemItem_Attribute_Media_Position
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Titel() As clsSemItem
        Get
            Return objSemItem_Attribute_Titel
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_L_nge__Minuten_() As clsSemItem
        Get
            Return objSemItem_Attribute_L_nge__Minuten_
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_comment() As clsSemItem
        Get
            Return objSemItem_Attribute_comment
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_taking() As clsSemItem
        Get
            Return objSemItem_Attribute_taking
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_DateTimeStamp() As clsSemItem
        Get
            Return objSemItem_Attribute_DateTimeStamp
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_XML_Text() As clsSemItem
        Get
            Return objSemItem_Attribute_XML_Text
        End Get
    End Property

    'Types
    Public ReadOnly Property SemItem_Type_Images__Graphic_() As clsSemItem
        Get
            Return objSemItem_Type_Images__Graphic_
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_File() As clsSemItem
        Get
            Return objSemItem_Type_File
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Image_Module() As clsSemItem
        Get
            Return objSemItem_Type_Image_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Language() As clsSemItem
        Get
            Return objSemItem_Type_Language
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_PDF_Documents() As clsSemItem
        Get
            Return objSemItem_Type_PDF_Documents
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Media_Item_Range() As clsSemItem
        Get
            Return objSemItem_Type_Media_Item_Range
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Media_Item_Bookmark() As clsSemItem
        Get
            Return objSemItem_Type_Media_Item_Bookmark
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Media_Item() As clsSemItem
        Get
            Return objSemItem_Type_Media_Item
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Filetypes() As clsSemItem
        Get
            Return objSemItem_Type_Filetypes
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Search_Template() As clsSemItem
        Get
            Return objSemItem_Type_Search_Template
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Year() As clsSemItem
        Get
            Return objSemItem_Type_Year
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Partner() As clsSemItem
        Get
            Return objSemItem_Type_Partner
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Media() As clsSemItem
        Get
            Return objSemItem_Type_Media
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Genre() As clsSemItem
        Get
            Return objSemItem_Type_Genre
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Band() As clsSemItem
        Get
            Return objSemItem_Type_Band
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Album() As clsSemItem
        Get
            Return objSemItem_Type_Album
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_mp3_File() As clsSemItem
        Get
            Return objSemItem_Type_mp3_File
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Day() As clsSemItem
        Get
            Return objSemItem_Type_Day
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Month() As clsSemItem
        Get
            Return objSemItem_Type_Month
        End Get
    End Property

    Public ReadOnly Property SemItem_type_User() As clsSemItem
        Get
            Return objSemItem_type_User
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_LogEntry() As clsSemItem
        Get
            Return objSemItem_Type_LogEntry
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Ort() As clsSemItem
        Get
            Return objSemItem_Type_Ort
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Image_Objects() As clsSemItem
        Get
            Return objSemItem_Type_Image_Objects
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Image_Objects__No_Objects_() As clsSemItem
        Get
            Return objSemItem_Type_Image_Objects__No_Objects_
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Tierarten() As clsSemItem
        Get
            Return objSemItem_Type_Tierarten
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Bauwerke() As clsSemItem
        Get
            Return objSemItem_Type_Bauwerke
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Haustier() As clsSemItem
        Get
            Return objSemItem_Type_Haustier
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Pflanzenarten() As clsSemItem
        Get
            Return objSemItem_Type_Pflanzenarten
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Wichtige_Ereignisse() As clsSemItem
        Get
            Return objSemItem_Type_Wichtige_Ereignisse
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_landscape() As clsSemItem
        Get
            Return objSemItem_Type_landscape
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Wetterlage() As clsSemItem
        Get
            Return objSemItem_Type_Wetterlage
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Kunst() As clsSemItem
        Get
            Return objSemItem_Type_Kunst
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Url() As clsSemItem
        Get
            Return objSemItem_Type_Url
        End Get
    End Property


    'Token
    Public ReadOnly Property SemItem_Token_Extensions_Image() As clsSemItem
        Get
            Return objSemItem_Token_Extensions_Image
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Extensions_pdf() As clsSemItem
        Get
            Return objSemItem_Token_Extensions_pdf
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Extensions_mod() As clsSemItem
        Get
            Return objSemItem_Token_Extensions_mod
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Logstate_User_Defined() As clsSemItem
        Get
            Return objSemItem_Token_Logstate_User_Defined
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Logstate_Last_Position() As clsSemItem
        Get
            Return objSemItem_Token_Logstate_Last_Position
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Logstate_Start() As clsSemItem
        Get
            Return objSemItem_Token_Logstate_Start
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Logstate_Stop() As clsSemItem
        Get
            Return objSemItem_Token_Logstate_Stop
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Search_Template_Name_() As clsSemItem
        Get
            Return objSemItem_Token_Search_Template_Name_
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Logstate_Unassigned() As clsSemItem
        Get
            Return objSemItem_Token_Logstate_Unassigned
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Logstate_Pause() As clsSemItem
        Get
            Return objSemItem_Token_Logstate_Pause
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Image_Objects__No_Objects__weather_condition() As clsSemItem
        Get
            Return objSemItem_Token_Image_Objects__No_Objects__weather_condition
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Image_Objects__No_Objects__no_Symbol() As clsSemItem
        Get
            Return objSemItem_Token_Image_Objects__No_Objects__no_Symbol
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Image_Objects__No_Objects__no_Persons() As clsSemItem
        Get
            Return objSemItem_Token_Image_Objects__No_Objects__no_Persons
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Image_Objects__No_Objects__no_Location() As clsSemItem
        Get
            Return objSemItem_Token_Image_Objects__No_Objects__no_Location
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Image_Objects__No_Objects__no_landscape() As clsSemItem
        Get
            Return objSemItem_Token_Image_Objects__No_Objects__no_landscape
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Image_Objects__No_Objects__no_Address() As clsSemItem
        Get
            Return objSemItem_Token_Image_Objects__No_Objects__no_Address
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Image_Objects__No_Objects__no_species() As clsSemItem
        Get
            Return objSemItem_Token_Image_Objects__No_Objects__no_species
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Image_Objects__No_Objects__no_Pets() As clsSemItem
        Get
            Return objSemItem_Token_Image_Objects__No_Objects__no_Pets
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Image_Objects__No_Objects__no_Buildings() As clsSemItem
        Get
            Return objSemItem_Token_Image_Objects__No_Objects__no_Buildings
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Image_Objects__No_Objects__no_plant_Species() As clsSemItem
        Get
            Return objSemItem_Token_Image_Objects__No_Objects__no_plant_Species
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Image_Objects__No_Objects__no_Artwork() As clsSemItem
        Get
            Return objSemItem_Token_Image_Objects__No_Objects__no_Artwork
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_Windows_Playlist_1_0_mediasrc() As clsSemItem
        Get
            Return objSemItem_Token_XML_Windows_Playlist_1_0_mediasrc
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_Windows_Playlist_1_0() As clsSemItem
        Get
            Return objSemItem_Token_XML_Windows_Playlist_1_0
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_URL_MEDIASRC() As clsSemItem
        Get
            Return objSemItem_Token_Variable_URL_MEDIASRC
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_MEDIASRC() As clsSemItem
        Get
            Return objSemItem_Token_Variable_MEDIASRC
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_title() As clsSemItem
        Get
            Return objSemItem_Token_Variable_title
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ITEMCOUNT() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ITEMCOUNT
        End Get
    End Property

    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Source() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Source
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_isDescribedBy() As clsSemItem
        Get
            Return objSemItem_RelationType_isDescribedBy
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is_of_Type() As clsSemItem
        Get
            Return objSemItem_RelationType_is_of_Type
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is_used_by() As clsSemItem
        Get
            Return objSemItem_RelationType_is_used_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_finished_with() As clsSemItem
        Get
            Return objSemItem_RelationType_finished_with
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_started_with() As clsSemItem
        Get
            Return objSemItem_RelationType_started_with
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offers() As clsSemItem
        Get
            Return objSemItem_RelationType_offers
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_from() As clsSemItem
        Get
            Return objSemItem_RelationType_from
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Disc() As clsSemItem
        Get
            Return objSemItem_RelationType_Disc
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Composer() As clsSemItem
        Get
            Return objSemItem_RelationType_Composer
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Artist() As clsSemItem
        Get
            Return objSemItem_RelationType_Artist
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_taking_at() As clsSemItem
        Get
            Return objSemItem_RelationType_taking_at
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Done() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Done
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is() As clsSemItem
        Get
            Return objSemItem_RelationType_is
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_located_in() As clsSemItem
        Get
            Return objSemItem_RelationType_located_in
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_has() As clsSemItem
        Get
            Return objSemItem_RelationType_has
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_wasCreatedBy() As clsSemItem
        Get
            Return objSemItem_RelationType_wasCreatedBy
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Media_Webservice_Url() As clsSemItem
        Get
            Return objSemItem_RelationType_Media_Webservice_Url
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_contains() As clsSemItem
        Get
            Return objSemItem_RelationType_contains
        End Get
    End Property

    Public ReadOnly Property SemItem_Development As clsSemItem
        Get
            Return objSemItem_Development
        End Get
    End Property

    Public ReadOnly Property SemItem_BaseConfig As clsSemItem
        Get
            Return objSemItem_BaseConfig
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

    Public ReadOnly Property GUID_Development As Guid
        Get
            Return objGUID_Development
        End Get
    End Property

    Public ReadOnly Property SemItem_Url As clsSemItem
        Get
            Return objSemItem_UrlService
        End Get
    End Property

    Public ReadOnly Property XML_WPL1 As String
        Get
            Return strXML_WPL1
        End Get
    End Property

    Public ReadOnly Property XML_SRCURL As String
        Get
            Return strXML_WPL_SRCURL
        End Get
    End Property

    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals
        objConnection_DB = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        objConnection_Config = New SqlClient.SqlConnection(objGlobals.ConnectionString_System)

        objGUID_Development = New Guid(cstr_GUIDToken_Development)
        objSemItem_Development = New clsSemItem
        objSemItem_Development.GUID = objGUID_Development
        objSemItem_Development.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

        set_DBConnection()
        get_Config()
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objConnection_Config
        funcA_SoftwareDevelopment_Config.Connection = objConnection_Config

        procA_TokenAttribute_Varchar255.Connection = objConnection_Config

        procA_OR_Attribute_By_GUIDObjectReference.Connection = objConnection_Config
        procA_OR_RelationType_By_GUIDObjectReference.Connection = objConnection_Config
        procA_OR_Token_By_GUID.Connection = objConnection_Config
        procA_OR_Type_By_GUID.Connection = objConnection_Config
        funcA_TokenAttribute_VARCHARMAX.Connection = objConnection_Config
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

        get_XML()
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_ID'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_ID.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_ID.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_ID.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_ID.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Media_Position'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Media_Position.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Media_Position.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Media_Position.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Media_Position.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Titel'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Titel.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Titel.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Titel.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Titel.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_L_nge__Minuten_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_L_nge__Minuten_.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_L_nge__Minuten_.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_L_nge__Minuten_.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_L_nge__Minuten_.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_comment'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_comment.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_comment.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_comment.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_comment.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_taking'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_taking.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_taking.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_taking.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_taking.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_DateTimeStamp'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_DateTimeStamp.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_DateTimeStamp.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_DateTimeStamp.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_DateTimeStamp.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_XML_Text'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_XML_Text.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_XML_Text.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_XML_Text.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_XML_Text.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Source'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Source.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Source.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Source.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_is_used_by'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_is_used_by.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_is_used_by.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_is_used_by.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_finished_with'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_finished_with.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_finished_with.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_finished_with.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_started_with'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_started_with.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_started_with.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_started_with.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_from'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_from.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_from.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_from.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Disc'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Disc.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Disc.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Disc.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Composer'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Composer.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Composer.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Composer.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Artist'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Artist.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Artist.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Artist.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_taking_at'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_taking_at.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_taking_at.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_taking_at.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_Done'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_Done.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_Done.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_Done.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_has'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_has.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_has.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_has.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_wasCreatedBy'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_wasCreatedBy.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_wasCreatedBy.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_wasCreatedBy.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Url'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Url.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Url.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Url.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Url.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

    End Sub

    Private Sub get_Config_Token()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Extensions_Image'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Extensions_Image.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Extensions_Image.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Extensions_Image.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Extensions_Image.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Development.GUID, _
                                                                  objSemItem_RelationType_offered_by.GUID, _
                                                                  objSemItem_Type_Module.GUID).Rows
        If objDRC_Ref.Count > 0 Then
            objSemItem_Module = New clsSemItem
            objSemItem_Module.GUID = objDRC_Ref(0).Item("GUID_Token_Left")
            objSemItem_Module.Name = objDRC_Ref(0).Item("Name_Token_Left")
            objSemItem_Module.GUID_Parent = objSemItem_Type_Module.GUID
            objSemItem_Module.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

        Else
            Err.Raise(1, "Config not set")
        End If

        objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Module.GUID, _
                                                                   objSemItem_RelationType_belongsTo.GUID, _
                                                                   objSemItem_Type_Image_Module.GUID).Rows
        If objDRC_Ref.Count > 0 Then
            objSemItem_BaseConfig = New clsSemItem
            objSemItem_BaseConfig.GUID = objDRC_Ref(0).Item("GUID_Token_Left")
            objSemItem_BaseConfig.Name = objDRC_Ref(0).Item("Name_Token_Left")
            objSemItem_BaseConfig.GUID_Parent = objSemItem_Type_Image_Module.GUID
            objSemItem_BaseConfig.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
        Else
            Err.Raise(1, "Config not set")
        End If


        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Extensions_pdf'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Extensions_pdf.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Extensions_pdf.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Extensions_pdf.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Extensions_pdf.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Extensions_mod'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Extensions_mod.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Extensions_mod.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Extensions_mod.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Extensions_mod.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_User_Defined'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_User_Defined.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_User_Defined.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_User_Defined.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_User_Defined.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_Last_Position'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_Last_Position.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_Last_Position.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_Last_Position.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_Last_Position.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_Start'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_Start.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_Start.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_Start.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_Start.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_Stop'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_Stop.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_Stop.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_Stop.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_Stop.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_Unassigned'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_Unassigned.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_Unassigned.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_Unassigned.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_Unassigned.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_Pause'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_Pause.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_Pause.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_Pause.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_Pause.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Image_Objects__No_Objects__weather_condition'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Image_Objects__No_Objects__weather_condition.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Image_Objects__No_Objects__weather_condition.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Image_Objects__No_Objects__weather_condition.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Image_Objects__No_Objects__weather_condition.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Image_Objects__No_Objects__no_Symbol'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Image_Objects__No_Objects__no_Symbol.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Symbol.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Symbol.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Image_Objects__No_Objects__no_Symbol.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Image_Objects__No_Objects__no_Persons'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Image_Objects__No_Objects__no_Persons.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Persons.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Persons.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Image_Objects__No_Objects__no_Persons.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Image_Objects__No_Objects__no_Location'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Image_Objects__No_Objects__no_Location.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Location.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Location.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Image_Objects__No_Objects__no_Location.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Image_Objects__No_Objects__no_landscape'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Image_Objects__No_Objects__no_landscape.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_landscape.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_landscape.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Image_Objects__No_Objects__no_landscape.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Image_Objects__No_Objects__no_Address'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Image_Objects__No_Objects__no_Address.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Address.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Address.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Image_Objects__No_Objects__no_Address.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Image_Objects__No_Objects__no_species'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Image_Objects__No_Objects__no_species.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_species.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_species.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Image_Objects__No_Objects__no_species.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Image_Objects__No_Objects__no_Pets'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Image_Objects__No_Objects__no_Pets.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Pets.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Pets.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Image_Objects__No_Objects__no_Pets.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Image_Objects__No_Objects__no_Buildings'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Image_Objects__No_Objects__no_Buildings.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Buildings.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Buildings.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Image_Objects__No_Objects__no_Buildings.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Image_Objects__No_Objects__no_plant_Species'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Image_Objects__No_Objects__no_plant_Species.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_plant_Species.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_plant_Species.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Image_Objects__No_Objects__no_plant_Species.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Image_Objects__No_Objects__no_Artwork'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Image_Objects__No_Objects__no_Artwork.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Artwork.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Image_Objects__No_Objects__no_Artwork.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Image_Objects__No_Objects__no_Artwork.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        funcA_TokenToken.Connection = objConnection_DB

        objDRC_Ref = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_BaseConfig.GUID, _
                                                                   objSemItem_RelationType_Media_Webservice_Url.GUID, _
                                                                   objSemItem_Type_Url.GUID).Rows
        If objDRC_Ref.Count > 0 Then
            objSemItem_UrlService = New clsSemItem
            objSemItem_UrlService.GUID = objDRC_Ref(0).Item("GUID_Token_Right")
            objSemItem_UrlService.Name = objDRC_Ref(0).Item("Name_Token_Right")
            objSemItem_UrlService.GUID_Parent = objSemItem_Type_Url.GUID
            objSemItem_UrlService.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
        Else
            objSemItem_UrlService = Nothing
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_Windows_Playlist_1_0_mediasrc'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_Windows_Playlist_1_0_mediasrc.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_Windows_Playlist_1_0_mediasrc.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_Windows_Playlist_1_0_mediasrc.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_Windows_Playlist_1_0_mediasrc.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_Windows_Playlist_1_0'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_Windows_Playlist_1_0.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_Windows_Playlist_1_0.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_Windows_Playlist_1_0.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_Windows_Playlist_1_0.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_URL_MEDIASRC'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_URL_MEDIASRC.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_URL_MEDIASRC.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_URL_MEDIASRC.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_URL_MEDIASRC.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_MEDIASRC'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_MEDIASRC.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_MEDIASRC.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_MEDIASRC.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_MEDIASRC.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_title'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_title.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_title.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_title.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_title.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ITEMCOUNT'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ITEMCOUNT.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ITEMCOUNT.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ITEMCOUNT.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ITEMCOUNT.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Images__Graphic_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Images__Graphic_.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Images__Graphic_.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Images__Graphic_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Images__Graphic_.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Image_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Image_Module.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Image_Module.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Image_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Image_Module.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_PDF_Documents'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_PDF_Documents.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_PDF_Documents.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_PDF_Documents.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_PDF_Documents.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Media_Item_Range'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Media_Item_Range.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Media_Item_Range.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Media_Item_Range.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Media_Item_Range.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Media_Item_Bookmark'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Media_Item_Bookmark.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Media_Item_Bookmark.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Media_Item_Bookmark.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Media_Item_Bookmark.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Media_Item'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Media_Item.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Media_Item.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Media_Item.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Media_Item.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Filetypes'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Filetypes.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Filetypes.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Filetypes.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Filetypes.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Year'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Year.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Year.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Year.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Year.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Media'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Media.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Media.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Media.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Media.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Genre'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Genre.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Genre.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Genre.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Genre.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Band'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Band.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Band.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Band.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Band.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Album'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Album.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Album.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Album.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Album.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_mp3_File'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_mp3_File.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_mp3_File.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_mp3_File.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_mp3_File.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Day'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Day.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Day.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Day.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Day.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Year'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Year.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Year.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Year.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Year.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Month'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Month.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Month.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Month.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Month.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_User'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_User.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_User.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_User.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_User.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Ort'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Ort.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Ort.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Ort.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Ort.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Image_Objects'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Image_Objects.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Image_Objects.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Image_Objects.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Image_Objects.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Image_Objects__No_Objects_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Image_Objects__No_Objects_.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Image_Objects__No_Objects_.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Image_Objects__No_Objects_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Image_Objects__No_Objects_.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Tierarten'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Tierarten.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Tierarten.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Tierarten.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Tierarten.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Bauwerke'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Bauwerke.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Bauwerke.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Bauwerke.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Bauwerke.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Haustier'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Haustier.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Haustier.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Haustier.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Haustier.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Pflanzenarten'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Pflanzenarten.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Pflanzenarten.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Pflanzenarten.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Pflanzenarten.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Wichtige_Ereignisse'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Wichtige_Ereignisse.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Wichtige_Ereignisse.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Wichtige_Ereignisse.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Wichtige_Ereignisse.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_landscape'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_landscape.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_landscape.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_landscape.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_landscape.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Wetterlage'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Wetterlage.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Wetterlage.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Wetterlage.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Wetterlage.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Kunst'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Kunst.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Kunst.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Kunst.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Kunst.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Media_Webservice_Url'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Media_Webservice_Url.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Media_Webservice_Url.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Media_Webservice_Url.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub

    Private Sub get_XML()
        Dim objDRC_XML As DataRowCollection

        objDRC_XML = funcA_TokenAttribute_VARCHARMAX.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_Token_XML_Windows_Playlist_1_0.GUID, _
                                                                                            objSemItem_Attribute_XML_Text.GUID).Rows
        If objDRC_XML.Count > 0 Then
            strXML_WPL1 = objDRC_XML(0).Item("Val")
            objDRC_XML = funcA_TokenAttribute_VARCHARMAX.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_Token_XML_Windows_Playlist_1_0_mediasrc.GUID, _
                                                                                                objSemItem_Attribute_XML_Text.GUID).Rows
            If objDRC_XML.Count > 0 Then
                strXML_WPL_SRCURL = objDRC_XML(0).Item("Val")
            Else
                Err.Raise(1, "Config not set")
            End If
        Else
            Err.Raise(1, "Config not set")

        End If



    End Sub
End Class
