Public Class clsFieldQuery
    Private strField As String
    Private strQuery As String

    Public Property Field As String
        Get
            Return strField
        End Get
        Set(ByVal value As String)
            strField = value
        End Set
    End Property

    Public Property Query As String
        Get
            Return strQuery
        End Get
        Set(ByVal value As String)
            strQuery = value
        End Set
    End Property
End Class
