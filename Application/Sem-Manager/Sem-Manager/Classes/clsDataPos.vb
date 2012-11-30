Public Class clsDataPos
    Private intRow As Integer
    Private intCount As Integer

    Public Property Row() As Integer
        Get
            Return intRow
        End Get
        Set(ByVal value As Integer)
            intRow = value
        End Set
    End Property

    Public Property Count() As Integer
        Get
            Return intCount
        End Get
        Set(ByVal value As Integer)
            intCount = value
        End Set
    End Property
End Class
