Public Class clsDBParameter
    Private strName_Parameter As String
    Private strValue_Parameter As String
    Private boolString As Boolean

    Public Property Name_Parameter
        Get
            Return strName_Parameter
        End Get
        Set(ByVal value)
            strName_Parameter = value
        End Set
    End Property

    Public Property Value_Parameter
        Get
            Return strValue_Parameter
        End Get
        Set(ByVal value)
            strValue_Parameter = value
        End Set
    End Property

    Public Property isString As Boolean
        Get
            Return boolString
        End Get
        Set(ByVal value As Boolean)
            boolString = value
        End Set
    End Property
End Class
