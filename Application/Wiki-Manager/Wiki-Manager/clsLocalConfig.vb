Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "cf5c35ae-ff58-4dc2-9b17-7ba65f115366"

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection

    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter

    Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
    Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable

    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter


    Private objGUID_Development As Guid

    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_Wiki_Text As New clsSemItem
    Private objSemItem_Attribute_Level As New clsSemItem
    Private objSemItem_Attribute_WIKI_Tag As New clsSemItem
    Private objSemItem_Attribute_DateTimeStamp As New clsSemItem
    Private objSemItem_Attribute_ID As New clsSemItem
    Private objSemItem_Attribute_Revision As New clsSemItem
    Private objSemItem_Attribute_XML_Text As New clsSemItem

    Private objSemItem_Token_Wiki_Components_Kategorie As New clsSemItem
    Private objSemItem_Token_Wiki_Components_Skript As New clsSemItem
    Private objSemItem_Token_Wiki_Components_Tabelle As New clsSemItem
    Private objSemItem_Token_Wiki_Components_Table_Spalte As New clsSemItem
    Private objSemItem_Token_Wiki_Components_Table_Zeile As New clsSemItem
    Private objSemItem_Token_Wiki_Components__berschrift_1 As New clsSemItem
    Private objSemItem_Token_Wiki_Components__berschrift_2 As New clsSemItem
    Private objSemItem_Token_Wiki_Components__berschrift_3 As New clsSemItem
    Private objSemItem_Token_Wiki_Components_Wiki_Link__intern_ As New clsSemItem
    Private objSemItem_Token_Wiki_Components_Fett As New clsSemItem
    Private objSemItem_Token_Variable_wiki_url As New clsSemItem
    Private objSemItem_Token_Variable_wiki_name As New clsSemItem
    Private objSemItem_Token_Variable_page_list As New clsSemItem
    Private objSemItem_Token_Variable_generator_name As New clsSemItem
    Private objSemItem_Token_Variable_year As New clsSemItem
    Private objSemItem_Token_Variable_wiki_text As New clsSemItem
    Private objSemItem_Token_Variable_title As New clsSemItem
    Private objSemItem_Token_Variable_second As New clsSemItem
    Private objSemItem_Token_Variable_revision As New clsSemItem
    Private objSemItem_Token_Variable_month As New clsSemItem
    Private objSemItem_Token_Variable_minute As New clsSemItem
    Private objSemItem_Token_Variable_ip_importer As New clsSemItem
    Private objSemItem_Token_Variable_id As New clsSemItem
    Private objSemItem_Token_Variable_hour As New clsSemItem
    Private objSemItem_Token_Variable_day As New clsSemItem
    Private objSemItem_Token_Variable_comment As New clsSemItem
    Private objSemItem_Token_XML_Table_for_Language_in_WIKI As New clsSemItem
    Private objSemItem_Token_Variable_name_language As New clsSemItem
    Private objSemItem_Token_Variable_text_col As New clsSemItem

    Private objSemItem_Type_Wiki_Document As New clsSemItem
    Private objSemItem_Type_Wiki_Document_Parts As New clsSemItem
    Private objSemItem_Type_Wiki_Heading As New clsSemItem
    Private objSemItem_Type_Wiki_Table As New clsSemItem
    Private objSemItem_Type_Wiki_Column As New clsSemItem
    Private objSemItem_Type_Wiki_Row As New clsSemItem
    Private objSemItem_Type_WIKI_Pre As New clsSemItem
    Private objSemItem_Type_WIKI_Text__Markuped_ As New clsSemItem
    Private objSemItem_Type_Wiki_Link__intern_ As New clsSemItem
    Private objSemItem_Token_XML_WIKI_pagelist As New clsSemItem
    Private objSemItem_Token_XML_WIKI_Import As New clsSemItem
    Private objSemItem_Type_WIKI_Documents_in_Implementation As New clsSemItem
    Private objSemItem_Type_WIKI_Implementation As New clsSemItem
    Private objSemItem_Type_Wiki_Category As New clsSemItem
    Private objSemItem_Type_File As New clsSemItem

    Private objSemItem_RelationType_is As New clsSemItem
    Private objSemItem_RelationType_contains As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_belonging_history As New clsSemItem
    Private objSemItem_RelationType_export_to As New clsSemItem


    Public ReadOnly Property SemItem_Attribute_Wiki_Text() As clsSemItem
        Get
            Return objSemItem_Attribute_Wiki_Text
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_Level() As clsSemItem
        Get
            Return objSemItem_Attribute_Level
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_WIKI_Tag() As clsSemItem
        Get
            Return objSemItem_Attribute_WIKI_Tag
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_DateTimeStamp() As clsSemItem
        Get
            Return objSemItem_Attribute_DateTimeStamp
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_ID() As clsSemItem
        Get
            Return objSemItem_Attribute_ID
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_Revision() As clsSemItem
        Get
            Return objSemItem_Attribute_Revision
        End Get
    End Property
    Public ReadOnly Property SemItem_Attribute_XML_Text() As clsSemItem
        Get
            Return objSemItem_Attribute_XML_Text
        End Get
    End Property

    'Token
    Public ReadOnly Property SemItem_Token_Wiki_Components_Kategorie() As clsSemItem
        Get
            Return objSemItem_Token_Wiki_Components_Kategorie
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Wiki_Components_Skript() As clsSemItem
        Get
            Return objSemItem_Token_Wiki_Components_Skript
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Wiki_Components_Tabelle() As clsSemItem
        Get
            Return objSemItem_Token_Wiki_Components_Tabelle
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Wiki_Components_Table_Spalte() As clsSemItem
        Get
            Return objSemItem_Token_Wiki_Components_Table_Spalte
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Wiki_Components_Table_Zeile() As clsSemItem
        Get
            Return objSemItem_Token_Wiki_Components_Table_Zeile
        End Get
    End Property



    Public ReadOnly Property SemItem_Token_Wiki_Components__berschrift_1() As clsSemItem
        Get
            Return objSemItem_Token_Wiki_Components__berschrift_1
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Wiki_Components__berschrift_2() As clsSemItem
        Get
            Return objSemItem_Token_Wiki_Components__berschrift_2
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Wiki_Components__berschrift_3() As clsSemItem
        Get
            Return objSemItem_Token_Wiki_Components__berschrift_3
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Wiki_Components_Wiki_Link__intern_() As clsSemItem
        Get
            Return objSemItem_Token_Wiki_Components_Wiki_Link__intern_
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_Wiki_Components_Fett() As clsSemItem
        Get
            Return objSemItem_Token_Wiki_Components_Fett
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_WIKI_pagelist() As clsSemItem
        Get
            Return objSemItem_Token_XML_WIKI_pagelist
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_XML_WIKI_Import() As clsSemItem
        Get
            Return objSemItem_Token_XML_WIKI_Import
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_wiki_url() As clsSemItem
        Get
            Return objSemItem_Token_Variable_wiki_url
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_wiki_name() As clsSemItem
        Get
            Return objSemItem_Token_Variable_wiki_name
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_page_list() As clsSemItem
        Get
            Return objSemItem_Token_Variable_page_list
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_generator_name() As clsSemItem
        Get
            Return objSemItem_Token_Variable_generator_name
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_year() As clsSemItem
        Get
            Return objSemItem_Token_Variable_year
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_wiki_text() As clsSemItem
        Get
            Return objSemItem_Token_Variable_wiki_text
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_title() As clsSemItem
        Get
            Return objSemItem_Token_Variable_title
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_second() As clsSemItem
        Get
            Return objSemItem_Token_Variable_second
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_revision() As clsSemItem
        Get
            Return objSemItem_Token_Variable_revision
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_month() As clsSemItem
        Get
            Return objSemItem_Token_Variable_month
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_minute() As clsSemItem
        Get
            Return objSemItem_Token_Variable_minute
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_ip_importer() As clsSemItem
        Get
            Return objSemItem_Token_Variable_ip_importer
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_id() As clsSemItem
        Get
            Return objSemItem_Token_Variable_id
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_hour() As clsSemItem
        Get
            Return objSemItem_Token_Variable_hour
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_day() As clsSemItem
        Get
            Return objSemItem_Token_Variable_day
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_comment() As clsSemItem
        Get
            Return objSemItem_Token_Variable_comment
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Wiki_Category() As clsSemItem
        Get
            Return objSemItem_Type_Wiki_Category
        End Get
    End Property
    Public ReadOnly Property SemItem_Token_XML_Table_for_Language_in_WIKI() As clsSemItem
        Get
            Return objSemItem_Token_XML_Table_for_Language_in_WIKI
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_name_language() As clsSemItem
        Get
            Return objSemItem_Token_Variable_name_language
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Variable_text_col() As clsSemItem
        Get
            Return objSemItem_Token_Variable_text_col
        End Get
    End Property

    'Types
    Public ReadOnly Property SemItem_Type_Wiki_Document() As clsSemItem
        Get
            Return objSemItem_Type_Wiki_Document
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Wiki_Document_Parts() As clsSemItem
        Get
            Return objSemItem_Type_Wiki_Document_Parts
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Wiki_Heading() As clsSemItem
        Get
            Return objSemItem_Type_Wiki_Heading
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Wiki_Table() As clsSemItem
        Get
            Return objSemItem_Type_Wiki_Table
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Wiki_Column() As clsSemItem
        Get
            Return objSemItem_Type_Wiki_Column
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Wiki_Row() As clsSemItem
        Get
            Return objSemItem_Type_Wiki_Row
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_WIKI_Pre() As clsSemItem
        Get
            Return objSemItem_Type_WIKI_Pre
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_WIKI_Text__Markuped_() As clsSemItem
        Get
            Return objSemItem_Type_WIKI_Text__Markuped_
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_Wiki_Link__intern_() As clsSemItem
        Get
            Return objSemItem_Type_Wiki_Link__intern_
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_WIKI_Documents_in_Implementation() As clsSemItem
        Get
            Return objSemItem_Type_WIKI_Documents_in_Implementation
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_WIKI_Implementation() As clsSemItem
        Get
            Return objSemItem_Type_WIKI_Implementation
        End Get
    End Property
    Public ReadOnly Property SemItem_Type_File() As clsSemItem
        Get
            Return objSemItem_Type_File
        End Get
    End Property


    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_is() As clsSemItem
        Get
            Return objSemItem_RelationType_is
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_contains() As clsSemItem
        Get
            Return objSemItem_RelationType_contains
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongsTo() As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_belonging_history() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_history
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_export_to() As clsSemItem
        Get
            Return objSemItem_RelationType_export_to
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

        set_DBConnection()
        get_Config()
    End Sub

    Private Sub set_DBConnection()
        funcA_SoftwareDevelopment_Config.Connection = objConnection_Config

        procA_TokenAttribute_Varchar255.Connection = objConnection_DB

        procA_OR_Attribute_By_GUIDObjectReference.Connection = objConnection_DB
        procA_OR_RelationType_By_GUIDObjectReference.Connection = objConnection_DB
        procA_OR_Token_By_GUID.Connection = objConnection_DB
        procA_OR_Type_By_GUID.Connection = objConnection_DB
    End Sub

    Private Sub get_Config()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection
        funcA_SoftwareDevelopment_Config.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_Config, objGUID_Development)

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='attribute_dbPostfix'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_attribute_dbPostfix.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_attribute_dbPostfix.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_attribute_dbPostfix.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_attribute_dbPostfix.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID

                objDRC_RelData = procA_TokenAttribute_Varchar255.GetData_By_GUIDAttribute_And_GUIDToken(objGUID_Development, objSemItem_attribute_dbPostfix.GUID).Rows
                objConnection_Plugin = New SqlClient.SqlConnection(objGlobals.get_DB_ConnectionString(objDRC_RelData(0).Item("Val")))
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        'Attributes
        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Wiki_Text'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Wiki_Text.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Wiki_Text.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Wiki_Text.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Wiki_Text.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_WIKI_Tag'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_WIKI_Tag.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_WIKI_Tag.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_WIKI_Tag.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_WIKI_Tag.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Revision'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Revision.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Revision.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Revision.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Revision.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        'Token
        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Wiki_Components_Kategorie'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Wiki_Components_Kategorie.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Wiki_Components_Kategorie.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Wiki_Components_Kategorie.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Wiki_Components_Kategorie.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Wiki_Components_Skript'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Wiki_Components_Skript.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Wiki_Components_Skript.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Wiki_Components_Skript.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Wiki_Components_Skript.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Wiki_Components_Tabelle'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Wiki_Components_Tabelle.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Wiki_Components_Tabelle.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Wiki_Components_Tabelle.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Wiki_Components_Tabelle.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Wiki_Components_Table_Spalte'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Wiki_Components_Table_Spalte.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Wiki_Components_Table_Spalte.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Wiki_Components_Table_Spalte.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Wiki_Components_Table_Spalte.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Wiki_Components_Table_Zeile'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Wiki_Components_Table_Zeile.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Wiki_Components_Table_Zeile.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Wiki_Components_Table_Zeile.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Wiki_Components_Table_Zeile.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Wiki_Components__berschrift_1'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Wiki_Components__berschrift_1.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Wiki_Components__berschrift_1.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Wiki_Components__berschrift_1.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Wiki_Components__berschrift_1.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Wiki_Components__berschrift_2'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Wiki_Components__berschrift_2.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Wiki_Components__berschrift_2.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Wiki_Components__berschrift_2.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Wiki_Components__berschrift_2.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Wiki_Components__berschrift_3'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Wiki_Components__berschrift_3.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Wiki_Components__berschrift_3.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Wiki_Components__berschrift_3.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Wiki_Components__berschrift_3.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Wiki_Components_Wiki_Link__intern_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Wiki_Components_Wiki_Link__intern_.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Wiki_Components_Wiki_Link__intern_.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Wiki_Components_Wiki_Link__intern_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Wiki_Components_Wiki_Link__intern_.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Wiki_Components_Fett'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Wiki_Components_Fett.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Wiki_Components_Fett.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Wiki_Components_Fett.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Wiki_Components_Fett.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_WIKI_pagelist'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_WIKI_pagelist.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_WIKI_pagelist.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_WIKI_pagelist.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_WIKI_pagelist.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_WIKI_Import'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_WIKI_Import.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_WIKI_Import.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_WIKI_Import.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_WIKI_Import.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_wiki_url'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_wiki_url.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_wiki_url.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_wiki_url.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_wiki_url.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_wiki_name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_wiki_name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_wiki_name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_wiki_name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_wiki_name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_page_list'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_page_list.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_page_list.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_page_list.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_page_list.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_generator_name'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_generator_name.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_generator_name.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_generator_name.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_generator_name.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_year'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_year.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_year.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_year.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_year.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_wiki_text'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_wiki_text.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_wiki_text.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_wiki_text.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_wiki_text.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_second'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_second.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_second.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_second.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_second.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_revision'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_revision.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_revision.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_revision.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_revision.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_month'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_month.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_month.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_month.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_month.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_minute'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_minute.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_minute.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_minute.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_minute.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_ip_importer'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_ip_importer.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_ip_importer.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_ip_importer.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_ip_importer.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_id'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_id.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_id.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_id.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_id.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_hour'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_hour.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_hour.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_hour.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_hour.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_day'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_day.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_day.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_day.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_day.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_comment'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_comment.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_comment.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_comment.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_comment.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Wiki_Category'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Wiki_Category.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Wiki_Category.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Wiki_Category.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Wiki_Category.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_XML_Table_for_Language_in_WIKI'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_XML_Table_for_Language_in_WIKI.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_XML_Table_for_Language_in_WIKI.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_XML_Table_for_Language_in_WIKI.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_XML_Table_for_Language_in_WIKI.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_name_language'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_name_language.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_name_language.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_name_language.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_name_language.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Variable_text_col'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Variable_text_col.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Variable_text_col.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Variable_text_col.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Variable_text_col.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        'Types
        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Wiki_Document'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Wiki_Document.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Wiki_Document.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Wiki_Document.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Wiki_Document.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Wiki_Document_Parts'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Wiki_Document_Parts.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Wiki_Document_Parts.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Wiki_Document_Parts.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Wiki_Document_Parts.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Wiki_Heading'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Wiki_Heading.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Wiki_Heading.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Wiki_Heading.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Wiki_Heading.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Wiki_Table'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Wiki_Table.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Wiki_Table.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Wiki_Table.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Wiki_Table.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Wiki_Column'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Wiki_Column.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Wiki_Column.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Wiki_Column.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Wiki_Column.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Wiki_Row'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Wiki_Row.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Wiki_Row.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Wiki_Row.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Wiki_Row.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_WIKI_Pre'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_WIKI_Pre.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_WIKI_Pre.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_WIKI_Pre.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_WIKI_Pre.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_WIKI_Text__Markuped_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_WIKI_Text__Markuped_.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_WIKI_Text__Markuped_.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_WIKI_Text__Markuped_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_WIKI_Text__Markuped_.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Wiki_Link__intern_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Wiki_Link__intern_.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Wiki_Link__intern_.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Wiki_Link__intern_.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Wiki_Link__intern_.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_WIKI_Documents_in_Implementation'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_WIKI_Documents_in_Implementation.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_WIKI_Documents_in_Implementation.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_WIKI_Documents_in_Implementation.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_WIKI_Documents_in_Implementation.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_WIKI_Implementation'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_WIKI_Implementation.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_WIKI_Implementation.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_WIKI_Implementation.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_WIKI_Implementation.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        'RelationTypes
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_history'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_history.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_history.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_history.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

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
        
    End Sub
End Class

