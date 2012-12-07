Imports Sem_Manager
Public Class clsLocalConfig
    Private Const cstr_GUIDToken_Development As String = "04816070-c3d0-4570-8e27-9732f48d1c6d"

    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Plugin As SqlClient.SqlConnection

    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter

    Private objSemItem_Development As clsSemItem

    'Types
    Private objSemItem_Type_Report As clsSemItem
    Private objSemItem_Type_DBProcedure As clsSemItem
    Private objSemItem_Type_DatabaseOnServer As clsSemItem
    Private objSemItem_Type_Database As clsSemItem
    Private objSemItem_Type_Server As clsSemItem
    Private objSemItem_Type_DBView As clsSemItem

    'RelationTypes
    Private objSemItem_RelationType_is As clsSemItem
    Private objSemItem_RelationType_isPartOf As clsSemItem
    Private objSemItem_RelationType_belongsTo As clsSemItem
    Private objSemItem_RelationType_locatedIn As clsSemItem
    Private objSemItem_RelationType_Contains As clsSemItem

    'Types
    Public ReadOnly Property SemItem_Type_Report As clsSemItem
        Get
            Return objSemItem_Type_Report
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Database As clsSemItem
        Get
            Return objSemItem_Type_Database
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DatabaseOnServer As clsSemItem
        Get
            Return objSemItem_Type_DatabaseOnServer
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DBProcedure As clsSemItem
        Get
            Return objSemItem_Type_DBProcedure
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Server As clsSemItem
        Get
            Return objSemItem_Type_Server
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_DBView As clsSemItem
        Get
            Return objSemItem_Type_DBView
        End Get
    End Property


    'RelationTypes
    Public ReadOnly Property SemItem_RelationType_Contains As clsSemItem
        Get
            Return objSemItem_RelationType_Contains
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_belongsTo As clsSemItem
        Get
            Return objSemItem_RelationType_belongsTo
        End Get
    End Property

    Public ReadOnly Property SemItem_RelationType_locatedIn As clsSemItem
        Get
            Return objSemItem_RelationType_locatedIn
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_is As clsSemItem
        Get
            Return objSemItem_RelationType_is
        End Get
    End Property
    Public ReadOnly Property SemItem_RelationType_isPartOf As clsSemItem
        Get
            Return objSemItem_RelationType_isPartOf
        End Get
    End Property

    Public ReadOnly Property Connection_Plugin() As SqlClient.SqlConnection
        Get
            Return objConnection_Plugin
        End Get
    End Property

    Public ReadOnly Property Connection_Config() As SqlClient.SqlConnection
        Get
            Return objConnection_Config
        End Get
    End Property

    Public ReadOnly Property Connection_DB() As SqlClient.SqlConnection
        Get
            Return objConnection_DB
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
        objSemItem_Development = New clsSemItem
        objSemItem_Development.GUID = New Guid(cstr_GUIDToken_Development)

        set_DBConnection()
        get_Config()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Type.Connection = objConnection_DB
        semtblA_Attribute.Connection = objConnection_DB
        semtblA_RelationType.Connection = objConnection_DB
        semtblA_Token.Connection = objConnection_DB
    End Sub

    Private Sub get_Config()

        get_Config_Attributes()
        get_Config_RelationTypes()
        get_Config_Token()
        get_Config_Types()


    End Sub

    Private Sub get_Config_Attributes()
        

    End Sub

    Private Sub get_Config_RelationTypes()
        Dim objDRC_RelationType As DataRowCollection

        objSemItem_RelationType_is = New clsSemItem
        objSemItem_RelationType_is.GUID = New Guid("3e104b75-e01c-48a0-b041-12908fd446a0")
        objDRC_RelationType = semtblA_RelationType.GetData_By_GUID(objSemItem_RelationType_is.GUID).Rows
        If objDRC_RelationType.Count > 0 Then
            objSemItem_RelationType_is.Name = objDRC_RelationType(0).Item("Name_RelationType")
            objSemItem_RelationType_is.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID
        Else
            Err.Raise(1, "Config not set")
        End If

        objSemItem_RelationType_isPartOf = New clsSemItem
        objSemItem_RelationType_isPartOf.GUID = New Guid("e8388fee-cc30-456e-af70-c8aaa4e2fa1b")
        objDRC_RelationType = semtblA_RelationType.GetData_By_GUID(objSemItem_RelationType_isPartOf.GUID).Rows
        If objDRC_RelationType.Count > 0 Then
            objSemItem_RelationType_isPartOf.Name = objDRC_RelationType(0).Item("Name_RelationType")
            objSemItem_RelationType_isPartOf.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID
        Else
            Err.Raise(1, "Config not set")
        End If

        objSemItem_RelationType_belongsTo = New clsSemItem
        objSemItem_RelationType_belongsTo.GUID = New Guid("e07469d9-766c-443e-8526-6d9c684f944f")
        objDRC_RelationType = semtblA_RelationType.GetData_By_GUID(objSemItem_RelationType_belongsTo.GUID).Rows
        If objDRC_RelationType.Count > 0 Then
            objSemItem_RelationType_belongsTo.Name = objDRC_RelationType(0).Item("Name_RelationType")
            objSemItem_RelationType_belongsTo.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID
        Else
            Err.Raise(1, "Config not set")
        End If

        objSemItem_RelationType_locatedIn = New clsSemItem
        objSemItem_RelationType_locatedIn.GUID = New Guid("439e614d-fb8a-4ae7-b5a2-7be25a058e6c")
        objDRC_RelationType = semtblA_RelationType.GetData_By_GUID(objSemItem_RelationType_locatedIn.GUID).Rows
        If objDRC_RelationType.Count > 0 Then
            objSemItem_RelationType_locatedIn.Name = objDRC_RelationType(0).Item("Name_RelationType")
            objSemItem_RelationType_locatedIn.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID
        Else
            Err.Raise(1, "Config not set")
        End If

        objSemItem_RelationType_Contains = New clsSemItem
        objSemItem_RelationType_Contains.GUID = New Guid("e9711603-47db-44d8-a476-fe88290639a4")
        objDRC_RelationType = semtblA_RelationType.GetData_By_GUID(objSemItem_RelationType_Contains.GUID).Rows
        If objDRC_RelationType.Count > 0 Then
            objSemItem_RelationType_Contains.Name = objDRC_RelationType(0).Item("Name_RelationType")
            objSemItem_RelationType_Contains.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID
        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub

    Private Sub get_Config_Token()
        
    End Sub

    Private Sub get_Config_Types()
        Dim objDRC_Type As DataRowCollection

        objSemItem_Type_Report = New clsSemItem
        objSemItem_Type_Report.GUID = New Guid("30cbc6e8-9c0f-47d6-920c-97fdc40ea1de")
        objDRC_Type = semtblA_Type.GetData_By_GUID(objSemItem_Type_Report.GUID).Rows
        If objDRC_Type.Count > 0 Then
            objSemItem_Type_Report.Name = objDRC_Type(0).Item("Name_Type")
            objSemItem_Type_Report.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
        Else
            Err.Raise(1, "Config not set")
        End If


        objSemItem_Type_DBProcedure = New clsSemItem
        objSemItem_Type_DBProcedure.GUID = New Guid("3dd1a15f-eef3-4943-8ce1-828e201a3c9d")
        objDRC_Type = semtblA_Type.GetData_By_GUID(objSemItem_Type_DBProcedure.GUID).Rows
        If objDRC_Type.Count > 0 Then
            objSemItem_Type_DBProcedure.Name = objDRC_Type(0).Item("Name_Type")
            objSemItem_Type_DBProcedure.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
        Else
            Err.Raise(1, "Config not set")
        End If

        objSemItem_Type_DatabaseOnServer = New clsSemItem
        objSemItem_Type_DatabaseOnServer.GUID = New Guid("76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c")
        objDRC_Type = semtblA_Type.GetData_By_GUID(objSemItem_Type_DatabaseOnServer.GUID).Rows
        If objDRC_Type.Count > 0 Then
            objSemItem_Type_DatabaseOnServer.Name = objDRC_Type(0).Item("Name_Type")
            objSemItem_Type_DatabaseOnServer.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
        Else
            Err.Raise(1, "Config not set")
        End If

        objSemItem_Type_Database = New clsSemItem
        objSemItem_Type_Database.GUID = New Guid("f8a525de-72bb-4904-941f-63a40ce34234")
        objDRC_Type = semtblA_Type.GetData_By_GUID(objSemItem_Type_Database.GUID).Rows
        If objDRC_Type.Count > 0 Then
            objSemItem_Type_Database.Name = objDRC_Type(0).Item("Name_Type")
            objSemItem_Type_Database.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
        Else
            Err.Raise(1, "Config not set")
        End If

        objSemItem_Type_Server = New clsSemItem
        objSemItem_Type_Server.GUID = New Guid("d7a03a35-8751-42b4-8e05-19fc7a77ee91")
        objDRC_Type = semtblA_Type.GetData_By_GUID(objSemItem_Type_Server.GUID).Rows
        If objDRC_Type.Count > 0 Then
            objSemItem_Type_Server.Name = objDRC_Type(0).Item("Name_Type")
            objSemItem_Type_Server.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
        Else
            Err.Raise(1, "Config not set")
        End If

        objSemItem_Type_DBView = New clsSemItem
        objSemItem_Type_DBView.GUID = New Guid("9403650d-2a28-4a0d-9a7f-f1d893960701")
        objDRC_Type = semtblA_Type.GetData_By_GUID(objSemItem_Type_DBView.GUID).Rows
        If objDRC_Type.Count > 0 Then
            objSemItem_Type_DBView.Name = objDRC_Type(0).Item("Name_Type")
            objSemItem_Type_DBView.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
        Else
            Err.Raise(1, "Config not set")
        End If
    End Sub



End Class

