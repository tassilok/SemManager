Public Class clsLocalConfig_SemWork
    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection

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

    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals
        objConnection_DB = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
    End Sub
End Class
