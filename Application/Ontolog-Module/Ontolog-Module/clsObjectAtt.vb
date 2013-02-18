Public Class clsObjectAtt
    Private strID_Attribute As String
    Private strID_AttributeType As String
    Private strName_AttributeType As String
    Private strID_Object As String
    Private strName_Object As String
    Private strID_Class As String
    Private strName_Class As String
    Private strVal_Named As String
    Private boolVal As Boolean
    Private lngVal As Long
    Private dblVal As Double
    Private dateVal As Date
    Private strVal As String
    Private lngOrderID As Long

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

    Public Property Name_AttributeType As String
        Get
            Return strName_AttributeType
        End Get
        Set(ByVal value As String)
            strName_AttributeType = value
        End Set
    End Property

    Public Property ID_Object As String
        Get
            Return strID_Object
        End Get
        Set(ByVal value As String)
            strID_Object = value
        End Set
    End Property

    Public Property Name_Object As String
        Get
            Return strName_Object
        End Get
        Set(ByVal value As String)
            strName_Object = value
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

    Public Property Name_Class As String
        Get
            Return strName_Class
        End Get
        Set(ByVal value As String)
            strName_Class = value
        End Set
    End Property

    Public Property OrderID As Long
        Get
            Return lngOrderID
        End Get
        Set(ByVal value As Long)
            lngOrderID = value
        End Set
    End Property

    Public Property val_Named As String
        Get
            Return strVal_Named
        End Get
        Set(ByVal value As String)
            strVal_Named = value
        End Set
    End Property

    Public Property Val_Bit As Boolean
        Get
            Return boolVal
        End Get
        Set(ByVal value As Boolean)
            boolVal = value
        End Set
    End Property

    Public Property Val_lng As Long
        Get
            Return lngVal
        End Get
        Set(ByVal value As Long)
            lngVal = value
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

    Public Property Val_Double As Double
        Get
            Return dblVal
        End Get
        Set(ByVal value As Double)
            dblVal = value
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


    Public Sub New(ByVal ID_Attribute As String, ByVal ID_Object As String, ByVal ID_Class As String, ByVal ID_AttributeType As String, ByVal OrderID As Long)
        strID_Attribute = ID_Attribute
        strID_AttributeType = ID_AttributeType
        strID_Object = ID_Object
        strID_Class = ID_Class
        lngOrderID = OrderID
    End Sub

    Public Sub New(ByVal ID_Attribute As String, ByVal ID_Object As String, ByVal Name_Object As String, ByVal ID_Class As String, ByVal Name_Class As String, ByVal ID_AttributeType As String, ByVal Name_AttributeType As String, ByVal OrderID As Long, ByVal val_Named As String, ByVal val_Bit As Boolean, ByVal val_Datetime As DateTime, ByVal val_Int As Long, ByVal val_Real As Double, ByVal val_String As String)
        strID_Attribute = ID_Attribute
        strID_AttributeType = ID_AttributeType
        strName_AttributeType = Name_AttributeType
        strID_Object = ID_Object
        strName_Object = Name_Object
        strID_Class = ID_Class
        strName_Class = Name_Class
        lngOrderID = OrderID
        strVal_Named = val_Named
        boolVal = val_Bit
        lngVal = val_Int
        dblVal = val_Real
        dateVal = val_Datetime
        strVal = val_String

    End Sub

End Class
