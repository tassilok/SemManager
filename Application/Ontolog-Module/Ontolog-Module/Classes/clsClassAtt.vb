Public Class clsClassAtt
    Private strID_AttributeType As String
    Private strID_Class As String
    Private strID_DataType As String
    Private intMin As Integer
    Private intMax As Integer

    Public Property ID_AttributeType As String
        Get
            Return strID_AttributeType
        End Get
        Set(ByVal value As String)
            strID_AttributeType = value
        End Set
    End Property

    Public Property ID_Class As String
        Get
            Return strID_Class
        End Get
        Set(ByVal value As String)
            strID_Class = value
        End Set
    End Property

    Public Property ID_DataType As String
        Get
            Return strID_DataType
        End Get
        Set(ByVal value As String)
            strID_DataType = value
        End Set
    End Property

    Public Property Min As Integer
        Get
            Return intMin
        End Get
        Set(ByVal value As Integer)
            intMin = value
        End Set
    End Property

    Public Property Max As Integer
        Get
            Return intMax
        End Get
        Set(ByVal value As Integer)
            intMax = value
        End Set
    End Property


    Public Sub New(ByVal ID_AttributeType As String, ByVal ID_DataType As String, ByVal ID_Class As String, ByVal Min As Integer, ByVal Max As Integer)
        strID_AttributeType = ID_AttributeType
        strID_DataType = ID_DataType
        strID_Class = ID_Class
        intMin = Min
        intMax = Max
    End Sub
End Class
