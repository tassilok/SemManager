Public Class clsLocalConfig_TokenTree
    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_System As SqlClient.SqlConnection

    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter

    'Private objSemItem_Type_ObjectReference As New clsSemItem

    'Public ReadOnly Property SemItem_Type_ObjectReference() As clsSemItem
    '    Get
    '        Return objSemItem_Type_ObjectReference
    '    End Get
    'End Property

    Public Property Globals() As clsGlobals
        Get
            Return objGlobals
        End Get
        Set(ByVal value As clsGlobals)
            objGlobals = value
        End Set
    End Property
    Public Property Connection_DB() As SqlClient.SqlConnection
        Get
            Return objConnection_DB
        End Get
        Set(ByVal value As SqlClient.SqlConnection)
            objConnection_DB = value
        End Set
    End Property
    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals
        objConnection_Config = New SqlClient.SqlConnection(objGlobals.ConnectionString_System)
        objConnection_DB = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        objConnection_System = New SqlClient.SqlConnection(objGlobals.ConnectionString_System)
        set_DBConnection()
        get_Config()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Type.Connection = objConnection_System
    End Sub

    Private Sub get_Config()
        'Dim objDRC_Type As DataRowCollection
        'objSemItem_Type_ObjectReference.GUID = semtblA_Type.GUID_Type_ObjectReference
        'objDRC_Type = semtblA_Type.GetData_By_GUID(objSemItem_Type_ObjectReference.GUID).Rows
        'objSemItem_Type_ObjectReference.Name = objDRC_Type(0).Item("Name_Type")
        'objSemItem_Type_ObjectReference.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
    End Sub
End Class
