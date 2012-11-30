Public Class clsLocalConfig_SemList
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

    Public Property Connection_Config() As SqlClient.SqlConnection
        Get
            Return objConnection_Config
        End Get
        Set(ByVal value As SqlClient.SqlConnection)
            objConnection_Config = value
        End Set
    End Property
End Class
