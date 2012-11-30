Public Class clsLocalConfig_RelationTypeEdit
    Private objGlobals As clsGlobals
    Private objConnection_DB As SqlClient.SqlConnection

    

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
    End Sub

    
End Class
