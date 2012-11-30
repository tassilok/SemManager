Public Class clsDatabaseConnection
    Private strName_Database As String
    Private strName_Server As String
    Private strConnectionString As String

    Public Property Name_Database() As String
        Get
            Return strName_Database
        End Get
        Set(ByVal value As String)
            strName_Database = value
        End Set
    End Property

    Public Property Name_Server() As String
        Get
            Return strName_Server

        End Get
        Set(ByVal value As String)
            strName_Server = value
        End Set
    End Property

    Public ReadOnly Property ConnectionString() As String
        Get
            Return "Data Source=" & _
                                strName_Server & _
                                "\SQLEXPRESS;Initial Catalog=" & _
                                strName_Database & _
                                ";Integrated Security=True"
        End Get
        
    End Property
End Class
