Public Class clsObjectRel
    Private strID_Object As String
    Private strName_Object As String
    Private strID_Parent_Object As String
    Private strName_Parent_Object As String
    Private strID_Other As String
    Private strName_Other As String
    Private strID_Parent_Left As String
    Private strName_Parent_Left As String
    Private strID_Parent_Right As String
    Private strName_Parent_Right As String
    Private strID_RelationType As String
    Private strName_RelationType As String
    Private strID_Ontology As String
    Private lngOrderID As Long
    Private strID_ItemType As String
    Private strName_ItemType As String

    Public Property ID_Ontology As String
        Get
            Return strID_Ontology
        End Get
        Set(ByVal value As String)
            strID_Ontology = value
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

    Public Property ID_Parent_Right As String
        Get
            Return strID_Parent_Right
        End Get
        Set(ByVal value As String)
            strID_Parent_Right = value
        End Set
    End Property

    Public Property Name_Parent_Right As String
        Get
            Return strName_Parent_Right
        End Get
        Set(ByVal value As String)
            strName_Parent_Right = value
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

    Public Property ID_ItemType As String
        Get
            Return strID_ItemType
        End Get
        Set(ByVal value As String)
            strID_ItemType = value
        End Set
    End Property

    Public Property Name_ItemType As String
        Get
            Return strName_ItemType
        End Get
        Set(ByVal value As String)
            strName_ItemType = value
        End Set
    End Property

    Public Sub New(ByVal ID_Object As String, ByVal ID_Parent_Left As String, ByVal ID_Right As String, ByVal ID_Parent_Right As String, ByVal ID_RelationType As String, ByVal ID_Ontology As String, ByVal OrderID As Long)
        strID_Object = ID_Object
        strID_Parent_Left = ID_Parent_Left
        strID_Other = ID_Other
        strID_Parent_Right = ID_Parent_Right
        strID_RelationType = ID_RelationType
        strID_Ontology = ID_Ontology
        lngOrderID = OrderID
    End Sub

    Public Sub New(ByVal ID_Object As String, ByVal Name_Object As String, ByVal ID_Parent_Left As String, ByVal Name_Parent_Left As String, ByVal ID_Right As String, ByVal Nam_Right As String, ByVal ID_Parent_Right As String, ByVal Name_Parent_Right As String, ByVal ID_RelationType As String, ByVal Name_RelationType As String, ByVal ID_Ontology As String, ByVal OrderID As Long)
        strID_Object = ID_Object
        strName_Object = Name_Object
        strID_Parent_Left = ID_Parent_Left
        strName_Parent_Left = Name_Parent_Left
        strID_Other = ID_Other
        strName_Other = Name_Other
        strID_Parent_Right = ID_Parent_Right
        strName_Parent_Right = Name_Parent_Right
        strID_RelationType = ID_RelationType
        strName_RelationType = Name_RelationType
        strID_Ontology = ID_Ontology
        lngOrderID = lngOrderID
    End Sub
End Class
