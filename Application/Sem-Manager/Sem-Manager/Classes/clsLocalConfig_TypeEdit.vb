Public Class clsLocalConfig_TypeEdit
    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Config As SqlClient.SqlConnection
    Private objConnection_Change As SqlClient.SqlConnection

    Private objGlobals As clsGlobals
    Public ReadOnly Property Globals() As clsGlobals
        Get
            Return objGlobals
        End Get
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
    Public Property Connection_Change() As SqlClient.SqlConnection
        Get
            Return objConnection_Change
        End Get
        Set(ByVal value As SqlClient.SqlConnection)
            objConnection_Change = value
        End Set
    End Property

    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals
    End Sub
End Class
