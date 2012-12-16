Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "f74f2b0d-84a4-48ae-a930-a6f13081a95b"

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
    Private objSemItem_Development As clsSemItem
    Private strConnection_Plugin As String

    'Attributes
    Private objSemItem_attribute_dbPostfix As New clsSemItem
    Private objSemItem_Attribute_Startdate As New clsSemItem
    Private objSemItem_Attribute_Message As New clsSemItem
    Private objSemItem_Attribute_ID As New clsSemItem
    Private objSemItem_Attribute_Enddate As New clsSemItem
    Private objSemItem_Attribute_DateTimeStamp As New clsSemItem
    Private objSemItem_Attribute_Datetime__To_Do_List_ As New clsSemItem
    Private objSemItem_Attribute_Description As New clsSemItem
    Private objSemItem_Attribute_Standard As New clsSemItem

    'Types
    Private objSemItem_type_User As New clsSemItem
    Private objSemItem_Type_Time_Period As New clsSemItem
    Private objSemItem_Type_Process_Ticket As New clsSemItem
    Private objSemItem_Type_Process_Log As New clsSemItem
    Private objSemItem_Type_Process_Last_Done As New clsSemItem
    Private objSemItem_Type_Module As New clsSemItem
    Private objSemItem_type_Logstate As New clsSemItem
    Private objSemItem_Type_LogEntry As New clsSemItem
    Private objSemItem_Type_Log As New clsSemItem
    Private objSemItem_Type_Language As New clsSemItem
    Private objSemItem_Type_Incident As New clsSemItem
    Private objSemItem_Type_Group As New clsSemItem
    Private objSemItem_Type_correlated_Process_Ticket_Creation As New clsSemItem
    Private objSemItem_Type_Process As New clsSemItem
    Private objSemItem_Type_Feiertage As New clsSemItem
    Private objSemItem_Type_Ort As New clsSemItem
    Private objSemItem_Type_User_Work_Config As New clsSemItem
    Private objSemItem_Type_Process_Ticket_Lists As New clsSemItem

    'Token
    Private objSemItem_Token_Process_Incident As New clsSemItem
    Private objSemItem_Token_Logstate_solved As New clsSemItem
    Private objSemItem_Token_LogState_Obsolete As New clsSemItem
    Private objSemItem_Token_LogState_Information As New clsSemItem
    Private objSemItem_Token_Logstate_finished As New clsSemItem
    Private objSemItem_Token_Logstate_Error As New clsSemItem
    Private objSemItem_Token_LogState_Create As New clsSemItem
    Private objSemItem_Token_Logstate_Start As New clsSemItem
    Private objSemItem_Token_Logstate_Stop As New clsSemItem
    Private objSemItem_Token_Logstate_DayStart As New clsSemItem
    Private objSemItem_Token_Logstate_DayEnd As New clsSemItem
    Private objSemItem_Token_Process_Ticket_Lists_All As New clsSemItem
    Private objSemItem_Token_Process_Ticket_Lists_Selected_Date_Range As New clsSemItem
    Private objSemItem_Token_Process_Ticket_Lists_ProcessTicketList As New clsSemItem
    Private objSemItem_Token_Process_Ticket_Lists_Open As New clsSemItem
    Private objSemItem_Token_Process_Ticket_Lists_This_Year As New clsSemItem
    Private objSemItem_Token_Process_Ticket_Lists_This_Week As New clsSemItem
    Private objSemItem_Token_Process_Ticket_Lists_This_Month As New clsSemItem
    Private objSemItem_Token_Process_Ticket_Lists_This_Day As New clsSemItem


    'RelationTypes
    Private objSemItem_RelationType_wasCreatedBy As New clsSemItem
    Private objSemItem_RelationType_Time_Measuring As New clsSemItem
    Private objSemItem_RelationType_provides As New clsSemItem
    Private objSemItem_RelationType_offered_by As New clsSemItem
    Private objSemItem_RelationType_Last_Done As New clsSemItem
    Private objSemItem_RelationType_isInState As New clsSemItem
    Private objSemItem_RelationType_isDescribedBy As New clsSemItem
    Private objSemItem_RelationType_contains As New clsSemItem
    Private objSemItem_RelationType_belongsTo As New clsSemItem
    Private objSemItem_RelationType_belonging_validity_period As New clsSemItem
    Private objSemItem_RelationType_belonging_Done As New clsSemItem
    Private objSemItem_RelationType_started_with As New clsSemItem
    Private objSemItem_RelationType_finished_with As New clsSemItem
    Private objSemItem_RelationType_Error_Queue As New clsSemItem
    Private objSemItem_RelationType_correlation_Done As New clsSemItem
    Private objSemItem_RelationType_superordinate As New clsSemItem

    Private objSemItem_User As clsSemItem
    Private objSemItem_Group As clsSemItem

    'Attributes
    Public ReadOnly Property SemItem_attribute_dbPostfix() As clsSemItem
        Get
            Return objSemItem_attribute_dbPostfix
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Startdate() As clsSemItem
        Get
            Return objSemItem_Attribute_Startdate
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Message() As clsSemItem
        Get
            Return objSemItem_Attribute_Message
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_ID() As clsSemItem
        Get
            Return objSemItem_Attribute_ID
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Enddate() As clsSemItem
        Get
            Return objSemItem_Attribute_Enddate
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_DateTimeStamp() As clsSemItem
        Get
            Return objSemItem_Attribute_DateTimeStamp
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Datetime__To_Do_List_() As clsSemItem
        Get
            Return objSemItem_Attribute_Datetime__To_Do_List_
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Description() As clsSemItem
        Get
            Return objSemItem_Attribute_Description
        End Get
    End Property

    Public ReadOnly Property SemItem_Attribute_Standard() As clsSemItem
        Get
            Return objSemItem_Attribute_Standard
        End Get
    End Property


    'Types
    Public ReadOnly Property SemItem_type_User() As clsSemItem
        Get
            Return objSemItem_type_User
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Time_Period() As clsSemItem
        Get
            Return objSemItem_Type_Time_Period
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Process_Ticket() As clsSemItem
        Get
            Return objSemItem_Type_Process_Ticket
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Process_Log() As clsSemItem
        Get
            Return objSemItem_Type_Process_Log
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Process_Last_Done() As clsSemItem
        Get
            Return objSemItem_Type_Process_Last_Done
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Module() As clsSemItem
        Get
            Return objSemItem_Type_Module
        End Get
    End Property

    Public ReadOnly Property SemItem_type_Logstate() As clsSemItem
        Get
            Return objSemItem_type_Logstate
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_LogEntry() As clsSemItem
        Get
            Return objSemItem_Type_LogEntry
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Log() As clsSemItem
        Get
            Return objSemItem_Type_Log
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Language() As clsSemItem
        Get
            Return objSemItem_Type_Language
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Incident() As clsSemItem
        Get
            Return objSemItem_Type_Incident
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Group() As clsSemItem
        Get
            Return objSemItem_Type_Group
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_correlated_Process_Ticket_Creation() As clsSemItem
        Get
            Return objSemItem_Type_correlated_Process_Ticket_Creation
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Process() As clsSemItem
        Get
            Return objSemItem_Type_Process
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Feiertage() As clsSemItem
        Get
            Return objSemItem_Type_Feiertage
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Ort() As clsSemItem
        Get
            Return objSemItem_Type_Ort
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_User_Work_Config() As clsSemItem
        Get
            Return objSemItem_Type_User_Work_Config
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Process_Ticket_Lists() As clsSemItem
        Get
            Return objSemItem_Type_Process_Ticket_Lists
        End Get
    End Property

    'Token
    Public ReadOnly Property SemItem_Token_Process_Incident() As clsSemItem
        Get
            Return objSemItem_Token_Process_Incident
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Logstate_solved() As clsSemItem
        Get
            Return objSemItem_Token_Logstate_solved
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_LogState_Obsolete() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Obsolete
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_LogState_Information() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Information
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Logstate_finished() As clsSemItem
        Get
            Return objSemItem_Token_Logstate_finished
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Logstate_Error() As clsSemItem
        Get
            Return objSemItem_Token_Logstate_Error
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_LogState_Create() As clsSemItem
        Get
            Return objSemItem_Token_LogState_Create
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

    Public ReadOnly Property SemItem_Token_Logstate_DayStart() As clsSemItem
        Get
            Return objSemItem_Token_Logstate_DayStart
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Logstate_DayEnd() As clsSemItem
        Get
            Return objSemItem_Token_Logstate_DayEnd
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Process_Ticket_Lists_All() As clsSemItem
        Get
            Return objSemItem_Token_Process_Ticket_Lists_All
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Process_Ticket_Lists_Selected_Date_Range() As clsSemItem
        Get
            Return objSemItem_Token_Process_Ticket_Lists_Selected_Date_Range
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Process_Ticket_Lists_Open() As clsSemItem
        Get
            Return objSemItem_Token_Process_Ticket_Lists_Open
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Process_Ticket_Lists_ProcessTicketList() As clsSemItem
        Get
            Return objSemItem_Token_Process_Ticket_Lists_ProcessTicketList
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Process_Ticket_Lists_This_Year() As clsSemItem
        Get
            Return objSemItem_Token_Process_Ticket_Lists_This_Year
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Process_Ticket_Lists_This_Week() As clsSemItem
        Get
            Return objSemItem_Token_Process_Ticket_Lists_This_Week
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Process_Ticket_Lists_This_Month() As clsSemItem
        Get
            Return objSemItem_Token_Process_Ticket_Lists_This_Month
        End Get
    End Property

    Public ReadOnly Property SemItem_Token_Process_Ticket_Lists_This_Day() As clsSemItem
        Get
            Return objSemItem_Token_Process_Ticket_Lists_This_Day
        End Get
    End Property

    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_wasCreatedBy() As clsSemItem
        Get
            Return objSemItem_RelationType_wasCreatedBy
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Time_Measuring() As clsSemItem
        Get
            Return objSemItem_RelationType_Time_Measuring
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_provides() As clsSemItem
        Get
            Return objSemItem_RelationType_provides
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_offered_by() As clsSemItem
        Get
            Return objSemItem_RelationType_offered_by
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Last_Done() As clsSemItem
        Get
            Return objSemItem_RelationType_Last_Done
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_isInState() As clsSemItem
        Get
            Return objSemItem_RelationType_isInState
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_isDescribedBy() As clsSemItem
        Get
            Return objSemItem_RelationType_isDescribedBy
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

    Public ReadOnly Property SemItem_RelationType_belonging_validity_period() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_validity_period
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belonging_Done() As clsSemItem
        Get
            Return objSemItem_RelationType_belonging_Done
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_started_with() As clsSemItem
        Get
            Return objSemItem_RelationType_started_with
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_finished_with() As clsSemItem
        Get
            Return objSemItem_RelationType_finished_with
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_Error_Queue() As clsSemItem
        Get
            Return objSemItem_RelationType_Error_Queue
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_correlation_Done() As clsSemItem
        Get
            Return objSemItem_RelationType_correlation_Done
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_superordinate() As clsSemItem
        Get
            Return objSemItem_RelationType_superordinate
        End Get
    End Property


    Public Property SemItem_User As clsSemItem
        Get
            Return objSemItem_User
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_User = value
        End Set
    End Property

    Public Property SemItem_Group As clsSemItem
        Get
            Return objSemItem_Group
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_Group = value
        End Set
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

    Public ReadOnly Property SemItem_Development As clsSemItem
        Get
            Return objSemItem_Development
        End Get
    End Property

    Public ReadOnly Property ConnectionString_Plugin As String
        Get
            Return strConnection_Plugin
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
    End Sub

    Private Sub get_Config()
        Dim objDRC_RelData As DataRowCollection
        Dim objDRs_ConfigItem() As DataRow
        Dim objDRC_Ref As DataRowCollection
        funcA_SoftwareDevelopment_Config.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_Config, objGUID_Development)

        get_Config_Attributes()
        get_Config_RelationTypes()
        get_Config_Token()
        get_Config_Types()


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
                strConnection_Plugin = objConnection_Plugin.ConnectionString
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Startdate'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Startdate.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Startdate.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Startdate.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Startdate.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Message'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Message.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Message.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Message.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Message.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Enddate'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Enddate.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Enddate.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Enddate.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Enddate.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Datetime__To_Do_List_'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Datetime__To_Do_List_.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Datetime__To_Do_List_.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Datetime__To_Do_List_.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Datetime__To_Do_List_.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Description'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Description.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Description.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Description.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Description.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Standard'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Standard.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Standard.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Standard.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Standard.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Time_Measuring'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Time_Measuring.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Time_Measuring.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Time_Measuring.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Last_Done'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Last_Done.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Last_Done.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Last_Done.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging_validity_period'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging_validity_period.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging_validity_period.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging_validity_period.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_Error_Queue'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_Error_Queue.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_Error_Queue.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_Error_Queue.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_correlation_Done'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_correlation_Done.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_correlation_Done.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_correlation_Done.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_superordinate'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_superordinate.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_superordinate.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_superordinate.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Process_Incident'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Process_Incident.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Process_Incident.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Process_Incident.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Process_Incident.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_solved'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_solved.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_solved.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_solved.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_solved.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_Obsolete'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_Obsolete.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_Obsolete.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_Obsolete.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_Obsolete.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_Information'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_Information.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_Information.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_Information.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_Information.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_finished'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_finished.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_finished.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_finished.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_finished.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_Error'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_Error.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_Error.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_Error.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_Error.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_LogState_Create'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_LogState_Create.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_LogState_Create.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_LogState_Create.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_LogState_Create.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_DayStart'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_DayStart.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_DayStart.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_DayStart.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_DayStart.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_DayEnd'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_DayEnd.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_DayEnd.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_DayEnd.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_DayEnd.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Process_Ticket_Lists_All'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Process_Ticket_Lists_All.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Process_Ticket_Lists_All.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Process_Ticket_Lists_All.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Process_Ticket_Lists_All.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Process_Ticket_Lists_Selected_Date_Range'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Process_Ticket_Lists_Selected_Date_Range.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Process_Ticket_Lists_Selected_Date_Range.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Process_Ticket_Lists_Selected_Date_Range.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Process_Ticket_Lists_Selected_Date_Range.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Process_Ticket_Lists_Open'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Process_Ticket_Lists_Open.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Process_Ticket_Lists_Open.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Process_Ticket_Lists_Open.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Process_Ticket_Lists_Open.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Process_Ticket_Lists_This_Year'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Process_Ticket_Lists_This_Year.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Process_Ticket_Lists_This_Year.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Process_Ticket_Lists_This_Year.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Process_Ticket_Lists_This_Year.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Process_Ticket_Lists_This_Week'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Process_Ticket_Lists_This_Week.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Process_Ticket_Lists_This_Week.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Process_Ticket_Lists_This_Week.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Process_Ticket_Lists_This_Week.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Process_Ticket_Lists_This_Month'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Process_Ticket_Lists_This_Month.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Process_Ticket_Lists_This_Month.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Process_Ticket_Lists_This_Month.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Process_Ticket_Lists_This_Month.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Process_Ticket_Lists_This_Day'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Process_Ticket_Lists_This_Day.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Process_Ticket_Lists_This_Day.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Process_Ticket_Lists_This_Day.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Process_Ticket_Lists_This_Day.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Process_Ticket_Lists_ProcessTicketList'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Process_Ticket_Lists_ProcessTicketList.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Process_Ticket_Lists_ProcessTicketList.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Process_Ticket_Lists_ProcessTicketList.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Process_Ticket_Lists_ProcessTicketList.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Time_Period'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Time_Period.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Time_Period.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Time_Period.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Time_Period.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Process_Ticket'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Process_Ticket.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Process_Ticket.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Process_Ticket.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Process_Ticket.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Process_Log'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Process_Log.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Process_Log.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Process_Log.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Process_Log.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Process_Last_Done'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Process_Last_Done.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Process_Last_Done.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Process_Last_Done.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Process_Last_Done.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_Logstate'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_Logstate.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_Logstate.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_Logstate.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_Logstate.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Log'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Log.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Log.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Log.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Log.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Incident'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Incident.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Incident.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Incident.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Incident.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Group'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Group.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Group.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Group.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Group.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_correlated_Process_Ticket_Creation'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_correlated_Process_Ticket_Creation.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_correlated_Process_Ticket_Creation.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_correlated_Process_Ticket_Creation.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_correlated_Process_Ticket_Creation.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Process'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Process.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Process.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Process.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Process.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Feiertage'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Feiertage.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Feiertage.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Feiertage.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Feiertage.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
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

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_User_Work_Config'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_User_Work_Config.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_User_Work_Config.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_User_Work_Config.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_User_Work_Config.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

        objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Process_Ticket_Lists'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Process_Ticket_Lists.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Process_Ticket_Lists.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Process_Ticket_Lists.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Process_Ticket_Lists.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub
End Class
