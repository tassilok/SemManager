Public Class clsAttribute
    Private lngVal As Long
    Private boolVal As Boolean
    Private dblVal As Double
    Private dateVal As Date
    Private strVal As String
    Private strName As String
    Private strID_AttributeType As String
    Private strID_Attribute As String
    Private strID_DataType As String

    Public Property Val_Long As Long
        Get
            Return lngVal
        End Get
        Set(ByVal value As Long)
            lngVal = value
        End Set
    End Property

    Public Property Val_Bool As Boolean
        Get
            Return boolVal
        End Get
        Set(ByVal value As Boolean)
            boolVal = value
        End Set
    End Property

    Public Property Val_Double As Double
        Get
            Return dblVal
        End Get
        Set(ByVal value As Double)
            dblVal = value
        End Set
    End Property

    Public Property Val_Date As Date
        Get
            Return dateVal
        End Get
        Set(ByVal value As Date)
            dateVal = value
        End Set
    End Property

    Public Property Val_String As String
        Get
            Return strVal
        End Get
        Set(ByVal value As String)
            strVal = value
        End Set
    End Property

    Public Property Val_Name As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property

    Public Property ID_Attribute As String
        Get
            Return strID_Attribute
        End Get
        Set(ByVal value As String)
            strID_Attribute = value
        End Set
    End Property

    Public Property ID_AttributeType As String
        Get
            Return strID_AttributeType
        End Get
        Set(ByVal value As String)
            strID_AttributeType = value
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

    Public Sub New(ByVal ID_Attribute As String, _
                   ByVal ID_AttributeType As String, _
                   ByVal ID_DataType As String, _
                   ByVal Val_Bool As Boolean, _
                   ByVal Val_Long As Long, _
                   ByVal Val_Real As Double, _
                   ByVal Val_Date As Date, _
                   ByVal Val_String As String, _
                   ByVal Val_Name As String)


        strID_Attribute = ID_Attribute
        strID_AttributeType = ID_AttributeType
        strID_DataType = ID_DataType

        boolVal = Val_Bool
        lngVal = Val_Long
        dblVal = Val_Real
        dateVal = Val_Date
        strVal = Val_String
        strName = Val_Name


    End Sub
End Class
