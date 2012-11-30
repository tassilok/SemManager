Public Class clsRecreation_SQL
    Private strSQL_Exists As String
    Private strSQL_Drop As String
    Private strSQL_Create As String
    Private _GUID_CreationScript As Guid

    Public Property SQL_Exists() As String
        Get
            Return strSQL_Exists
        End Get
        Set(ByVal value As String)
            strSQL_Exists = value
        End Set
    End Property
    Public Property SQL_Drop() As String
        Get
            Return strSQL_Drop
        End Get
        Set(ByVal value As String)
            strSQL_Drop = value
        End Set
    End Property

    Public Property SQL_Create() As String
        Get
            Return strSQL_Create
        End Get
        Set(ByVal value As String)
            strSQL_Create = value
        End Set
    End Property

    Public Property GUID_CreationScript() As Guid
        Get
            Return _GUID_CreationScript
        End Get
        Set(ByVal value As Guid)
            _GUID_CreationScript = value
        End Set
    End Property
End Class
