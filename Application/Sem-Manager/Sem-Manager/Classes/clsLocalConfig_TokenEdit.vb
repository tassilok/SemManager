Public Class clsLocalConfig_TokenEdit
    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection

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
    End Sub
End Class
