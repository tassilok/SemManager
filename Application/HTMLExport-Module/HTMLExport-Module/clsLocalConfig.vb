Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "9d86d2b2-274b-49c1-83d1-c46dfe73d1ef"

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection

    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter


    Private objGUID_Development As Guid
    Private objSemItem_Development As New clsSemItem
    Private objSemItem_BaseConfig As clsSemItem

    'Attributes
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_Level As New clsSemItem
    Private objSemItem_Attribute_XML_Text As New clsSemItem
    Private objSemItem_Attribute_Intro As New clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_isInState As New clsSemItem
    Private objSemItem_RelationType_relative As New clsSemItem
    Private objSemItem_RelationType_contains As New clsSemItem
    Private objSemItem_RelationType_is As New clsSemItem
    Private objSemItem_RelationType_belonging_Token As New clsSemItem
    Private objSemItem_RelationType_Tag_Start As New clsSemItem
    Private objSemItem_RelationType_Tag_End_Init As New clsSemItem
    Private objSemItem_RelationType_Tag_End As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem
    Private objSemItem_RelationType_Intro As New clsSemItem
    Private objSemItem_RelationType_export_to As New clsSemItem

    'Token
    Private objSemItem_Token_Attribute_Type_Source_of_Resource As New clsSemItem
    Private objSemItem_Token_Document_Tag_Type_Content As New clsSemItem
    Private objSemItem_Token_Document_Tag_Type_Images As New clsSemItem
    Private objSemItem_Token_HTML_Tag_Type_Document_Init_Final As New clsSemItem
    Private objSemItem_Token_HTML_Tag_Type_Heading As New clsSemItem
    Private objSemItem_Token_HTML_Tag_Type_HTML_Head_Init_Final As New clsSemItem
    Private objSemItem_Token_Document_Tag_Type_Paragraph As New clsSemItem
    Private objSemItem_Token_XML_HTML_Intro As New clsSemItem
    Private objSemItem_Token_Document_Tag_Type_Title As New clsSemItem
    Private objSemItem_Token_Document_Tag_Type_Table_Row As New clsSemItem
    Private objSemItem_Token_Document_Tag_Type_Table_Col As New clsSemItem
    Private objSemItem_Token_Document_Tag_Type_Table As New clsSemItem
    Private objSemItem_Token_Tag_Attributes_border As New clsSemItem
    Private objSemItem_Token_Tag_Attributes_src As New clsSemItem
    Private objSemItem_Token_Document_Tag_Type_Bold As New clsSemItem


    'Types
    Private objSemItem_Type_HTML_Tags As New clsSemItem
    Private objSemItem_Type_Tag_Attributes As New clsSemItem
    Private objSemItem_Type_HTML_Document As New clsSemItem
    Private objSemItem_type_DevelopmentVersion As New clsSemItem
    Private objSemItem_Type_Path As New clsSemItem
    Private objSemItem_Type_Document_Parts As New clsSemItem
    Private objSemItem_Type_Zeichen As New clsSemItem
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_Type_HTMLExport_Module As New clsSemItem
    Private objSemItem_Type_Images__Graphic_ As New clsSemItem
    Private objSemItem_Type_PDF_Documents As New clsSemItem
    Private objSemItem_Type_Media_Item As New clsSemItem
    Private objSemItem_Type_XML As New clsSemItem
    Private objSemItem_type_Folder As New clsSemItem


    'Attributes
    Public ReadOnly Property SemItem_attribute_dbPostfix() As clsSemItem
        Get
            Return objSemItem_attribute_dbPostfix
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Level() As clsSemItem
        Get
            Return objSemItem_Attribute_Level
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_XML_Text() As clsSemItem
        Get
            Return objSemItem_Attribute_XML_Text
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Intro() As clsSemItem
        Get
            Return objSemItem_Attribute_Intro
        End Get
    End Property



    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_isInState() As clsSemItem
        Get
            Return objSemItem_RelationType_isInState
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_relative() As clsSemItem
        Get
            Return objSemItem_RelationType_relative
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_contains() As clsSemItem
        Get
            Return objSemItem_RelationType_contains
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_is() As clsSemItem
        Get
            Return objSemItem_RelationType_is
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Token() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Token
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Tag_Start() As clsSemItem
        Get
            Return objSemItem_RelationType_Tag_Start
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Tag_End_Init() As clsSemItem
        Get
            Return objSemItem_RelationType_Tag_End_Init
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Tag_End() As clsSemItem
        Get
            Return objSemItem_RelationType_Tag_End
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Intro() As clsSemItem
        Get
            Return objSemItem_RelationType_Intro
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_export_to() As clsSemItem
        Get
            Return objSemItem_RelationType_export_to
        End Get
    End Property



    'Token
    Public ReadOnly Property SemItem_Token_Attribute_Type_Source_of_Resource() As clsSemItem
        Get
            Return objSemItem_Token_Attribute_Type_Source_of_Resource
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Document_Tag_Type_Content() As clsSemItem
        Get
            Return objSemItem_Token_Document_Tag_Type_Content
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Document_Tag_Type_Images() As clsSemItem
        Get
            Return objSemItem_Token_Document_Tag_Type_Images
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_HTML_Tag_Type_Document_Init_Final() As clsSemItem
        Get
            Return objSemItem_Token_HTML_Tag_Type_Document_Init_Final
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_HTML_Tag_Type_Heading() As clsSemItem
        Get
            Return objSemItem_Token_HTML_Tag_Type_Heading
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_HTML_Tag_Type_HTML_Head_Init_Final() As clsSemItem
        Get
            Return objSemItem_Token_HTML_Tag_Type_HTML_Head_Init_Final
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Document_Tag_Type_Paragraph() As clsSemItem
        Get
            Return objSemItem_Token_Document_Tag_Type_Paragraph
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_HTML_Intro() As clsSemItem
        Get
            Return objSemItem_Token_XML_HTML_Intro
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Document_Tag_Type_Title() As clsSemItem
        Get
            Return objSemItem_Token_Document_Tag_Type_Title
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Document_Tag_Type_Table_Row() As clsSemItem
        Get
            Return objSemItem_Token_Document_Tag_Type_Table_Row
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Document_Tag_Type_Table_Col() As clsSemItem
        Get
            Return objSemItem_Token_Document_Tag_Type_Table_Col
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Document_Tag_Type_Table() As clsSemItem
        Get
            Return objSemItem_Token_Document_Tag_Type_Table
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Tag_Attributes_border() As clsSemItem
        Get
            Return objSemItem_Token_Tag_Attributes_border
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Tag_Attributes_src() As clsSemItem
        Get
            Return objSemItem_Token_Tag_Attributes_src
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Document_Tag_Type_Bold() As clsSemItem
        Get
            Return objSemItem_Token_Document_Tag_Type_Bold
        End Get
    End Property



    'Types
    Public ReadOnly Property SemItem_Type_HTML_Tags() As clsSemItem
        Get
            Return objSemItem_Type_HTML_Tags
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Tag_Attributes() As clsSemItem
        Get
            Return objSemItem_Type_Tag_Attributes
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_HTML_Document() As clsSemItem
        Get
            Return objSemItem_Type_HTML_Document
        End Get
    End Property

    Public ReadOnly Property SemItem_type_DevelopmentVersion() As clsSemItem
        Get
            Return objSemItem_type_DevelopmentVersion
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Path() As clsSemItem
        Get
            Return objSemItem_Type_Path
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Document_Parts() As clsSemItem
        Get
            Return objSemItem_Type_Document_Parts
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Zeichen() As clsSemItem
        Get
            Return objSemItem_Type_Zeichen
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_HTMLExport_Module() As clsSemItem
        Get
            Return objSemItem_Type_HTMLExport_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Images__Graphic_() As clsSemItem
        Get
            Return objSemItem_Type_Images__Graphic_
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_PDF_Documents() As clsSemItem
        Get
            Return objSemItem_Type_PDF_Documents
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Media_Item() As clsSemItem
        Get
            Return objSemItem_Type_Media_Item
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_XML() As clsSemItem
        Get
            Return objSemItem_Type_XML
        End Get
    End Property

    Public ReadOnly Property SemItem_type_Folder() As clsSemItem
        Get
            Return objSemItem_type_Folder
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

    Public ReadOnly Property SemItem_BaseConfig As clsSemItem
        Get
            Return objSemItem_BaseConfig
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

        funcA_TokenToken.Connection = objConnection_Config
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Intro'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Intro.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Intro.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Intro.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Intro.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Level'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Level.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Level.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Level.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Level.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_export_to'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_export_to.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_export_to.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_export_to.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Intro'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Intro.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Intro.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Intro.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_isInState'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_isInState.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_isInState.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_isInState.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_relative'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_relative.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_relative.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_relative.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Tag_Start'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Tag_Start.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Tag_Start.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Tag_Start.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Tag_End_Init'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Tag_End_Init.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Tag_End_Init.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Tag_End_Init.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Tag_End'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Tag_End.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Tag_End.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Tag_End.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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
    End Sub

    Private Sub get_Config_Token()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Document_Tag_Type_Bold'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Document_Tag_Type_Bold.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Document_Tag_Type_Bold.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Document_Tag_Type_Bold.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Document_Tag_Type_Bold.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Tag_Attributes_src'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Tag_Attributes_src.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Tag_Attributes_src.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Tag_Attributes_src.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Tag_Attributes_src.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If


        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Tag_Attributes_border'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Tag_Attributes_border.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Tag_Attributes_border.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Tag_Attributes_border.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Tag_Attributes_border.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Document_Tag_Type_Table_Row'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Document_Tag_Type_Table_Row.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Document_Tag_Type_Table_Row.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Document_Tag_Type_Table_Row.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Document_Tag_Type_Table_Row.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Document_Tag_Type_Table_Col'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Document_Tag_Type_Table_Col.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Document_Tag_Type_Table_Col.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Document_Tag_Type_Table_Col.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Document_Tag_Type_Table_Col.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Document_Tag_Type_Table'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Document_Tag_Type_Table.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Document_Tag_Type_Table.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Document_Tag_Type_Table.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Document_Tag_Type_Table.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Document_Tag_Type_Title'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Document_Tag_Type_Title.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Document_Tag_Type_Title.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Document_Tag_Type_Title.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Document_Tag_Type_Title.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_HTML_Intro'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_HTML_Intro.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_HTML_Intro.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_HTML_Intro.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_HTML_Intro.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Attribute_Type_Source_of_Resource'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Attribute_Type_Source_of_Resource.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Attribute_Type_Source_of_Resource.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Attribute_Type_Source_of_Resource.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Attribute_Type_Source_of_Resource.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Document_Tag_Type_Content'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Document_Tag_Type_Content.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Document_Tag_Type_Content.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Document_Tag_Type_Content.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Document_Tag_Type_Content.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Document_Tag_Type_Images'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Document_Tag_Type_Images.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Document_Tag_Type_Images.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Document_Tag_Type_Images.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Document_Tag_Type_Images.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_HTML_Tag_Type_Document_Init_Final'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_HTML_Tag_Type_Document_Init_Final.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_HTML_Tag_Type_Document_Init_Final.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_HTML_Tag_Type_Document_Init_Final.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_HTML_Tag_Type_Document_Init_Final.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_HTML_Tag_Type_Heading'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_HTML_Tag_Type_Heading.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_HTML_Tag_Type_Heading.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_HTML_Tag_Type_Heading.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_HTML_Tag_Type_Heading.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_HTML_Tag_Type_HTML_Head_Init_Final'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_HTML_Tag_Type_HTML_Head_Init_Final.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_HTML_Tag_Type_HTML_Head_Init_Final.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_HTML_Tag_Type_HTML_Head_Init_Final.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_HTML_Tag_Type_HTML_Head_Init_Final.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Document_Tag_Type_Paragraph'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Document_Tag_Type_Paragraph.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Document_Tag_Type_Paragraph.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Document_Tag_Type_Paragraph.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Document_Tag_Type_Paragraph.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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
            objDRC_Ref = funcA_TokenToken.GetData_TokenToken_RightLeft(objDRC_Ref(0).Item("GUID_Token_Left"), _
                                                                       objSemItem_RelationType_belongsTo.GUID, _
                                                                       objSemItem_Type_HTMLExport_Module.GUID).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_BaseConfig = New clsSemItem
                objSemItem_BaseConfig.GUID = objDRC_Ref(0).Item("GUID_Token_Left")
                objSemItem_BaseConfig.Name = objDRC_Ref(0).Item("Name_Token_Left")
                objSemItem_BaseConfig.GUID_Parent = objSemItem_Type_HTMLExport_Module.GUID
                objSemItem_BaseConfig.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID


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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_Folder'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_Folder.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_Folder.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_Folder.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_Folder.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_XML'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_XML.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_XML.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_XML.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_XML.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_HTML_Tags'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_HTML_Tags.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_HTML_Tags.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_HTML_Tags.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_HTML_Tags.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Tag_Attributes'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Tag_Attributes.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Tag_Attributes.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Tag_Attributes.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Tag_Attributes.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_HTML_Document'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_HTML_Document.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_HTML_Document.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_HTML_Document.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_HTML_Document.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_DevelopmentVersion'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_DevelopmentVersion.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_DevelopmentVersion.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_DevelopmentVersion.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_DevelopmentVersion.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Path'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Path.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Path.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Path.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Path.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Document_Parts'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Document_Parts.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Document_Parts.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Document_Parts.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Document_Parts.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Zeichen'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Zeichen.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Zeichen.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Zeichen.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Zeichen.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_HTMLExport_Module'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_HTMLExport_Module.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_HTMLExport_Module.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_HTMLExport_Module.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_HTMLExport_Module.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

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

    End Sub
End Class
