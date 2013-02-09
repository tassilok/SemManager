Public Class clsObjectRel
    Private strID_Object As String
    Private strName_Object As String
    Private strID_Parent_Object As String
    Private strName_Parent_Object As String
    Private strID_Other As String
    Private strName_Other As String
    Private strID_Parent_Other As String
    Private strName_Parent_Other As String
    Private strID_RelationType As String
    Private strName_RelationType As String
    Private strOntology As String
    Private strID_Direction As String
    Private strName_Direction As String
    Private lngOrderID As Long

    Public Property ID_Direction As String
        Get
            Return strID_Direction
        End Get
        Set(ByVal value As String)
            strID_Direction = value
        End Set
    End Property

    Public Property Name_Direction As String
        Get
            Return strName_Direction
        End Get
        Set(ByVal value As String)
            strName_Direction = value
        End Set
    End Property

    Public Property Ontology As String
        Get
            Return strOntology
        End Get
        Set(ByVal value As String)
            strOntology = value
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

    Public Property ID_Parent_Object As String
        Get
            Return strID_Parent_Object
        End Get
        Set(ByVal value As String)
            strID_Parent_Object = value
        End Set
    End Property

    Public Property Name_Parent_Object As String
        Get
            Return strName_Parent_Object
        End Get
        Set(ByVal value As String)
            strName_Parent_Object = value
        End Set
    End Property

    Public Property ID_Other As String
        Get
            Return strID_Other
        End Get
        Set(ByVal value As String)
            strID_Other = value
        End Set
    End Property

    Public Property Name_Other As String
        Get
            Return strName_Other
        End Get
        Set(ByVal value As String)
            strName_Other = value
        End Set
    End Property

    Public Property ID_Parent_Other As String
        Get
            Return strID_Parent_Other
        End Get
        Set(ByVal value As String)
            strID_Parent_Other = value
        End Set
    End Property

    Public Property Name_Parent_Right As String
        Get
            Return strName_Parent_Other
        End Get
        Set(ByVal value As String)
            strName_Parent_Other = value
        End Set
    End Property

    Public Property ID_RelationType As String
        Get
            Return strID_RelationType
        End Get
        Set(ByVal value As String)
            strID_RelationType = value
        End Set
    End Property

    Public Property Name_RelationType As String
        Get
            Return strName_RelationType
        End Get
        Set(ByVal value As String)
            strName_RelationType = value
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

 
    Public Sub New(ByVal ID_Object As String, _
                   ByVal ID_Parent_Object As String, _
                   ByVal ID_Other As String, _
                   ByVal ID_Parent_Other As String, _
                   ByVal ID_RelationType As String, _
                   ByVal Ontology As String, _
                   ByVal ID_Direction As String, _
                   ByVal OrderID As Long)

        strID_Object = ID_Object
        strID_Parent_Object = ID_Parent_Object
        strID_Other = ID_Other
        strID_Parent_Other = ID_Parent_Other
        strID_RelationType = ID_RelationType
        strOntology = Ontology
        strID_Direction = ID_Direction
        lngOrderID = OrderID
    End Sub

    Public Sub New(ByVal ID_Object As String, ByVal Name_Object As String, _
                   ByVal ID_Parent_Object As String, _
                   ByVal Name_Parent_Object As String, _
                   ByVal ID_Other As String, _
                   ByVal Name_Other As String, _
                   ByVal ID_Parent_Other As String, _
                   ByVal Name_Parent_Other As String, _
                   ByVal ID_RelationType As String, _
                   ByVal Name_RelationType As String, _
                   ByVal Ontology As String, _
                   ByVal ID_Direction As String, _
                   ByVal Name_Direction As String, _
                   ByVal OrderID As Long)

        strID_Object = ID_Object
        strName_Object = Name_Object
        strID_Parent_Other = ID_Parent_Other
        strName_Parent_Other = Name_Parent_Other
        strID_Other = ID_Other
        strName_Other = Name_Other
        strID_RelationType = ID_RelationType
        strName_RelationType = Name_RelationType
        strOntology = Ontology
        strID_Direction = ID_Direction
        strName_Direction = Name_Direction
        lngOrderID = lngOrderID
    End Sub

    Public Sub New()

    End Sub
End Class
