Public Class clsFieldQuery
    Private strField_ID As String
    Private strQuery_ID As String

    Private strField_Name As String
    Private strQuery_Name As String

    Private strField_IDParent As String
    Private strQuery_IDParent As String

    Public Property Field_ID As String
        Get
            Return strField_ID
        End Get
        Set(ByVal value As String)
            strField_ID = value
        End Set
    End Property

    Public Property Query_ID As String
        Get
            Return strQuery_ID
        End Get
        Set(ByVal value As String)
            strQuery_ID = value
        End Set
    End Property

    Public Property Field_Name As String
        Get
            Return strField_Name
        End Get
        Set(ByVal value As String)
            strField_Name = value
        End Set
    End Property

    Public Property Query_Name As String
        Get
            Return strQuery_Name
        End Get
        Set(ByVal value As String)
            strQuery_Name = value
        End Set
    End Property

    Public Property Field_IDParent As String
        Get
            Return strField_IDParent
        End Get
        Set(ByVal value As String)
            strField_IDParent = value
        End Set
    End Property

    Public Property Query_IDParent As String
        Get
            Return strQuery_IDParent
        End Get
        Set(ByVal value As String)
            strQuery_IDParent = value
        End Set
    End Property
    
    Public Sub New()
        
    End Sub
End Class
