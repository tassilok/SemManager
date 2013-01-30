Public Class clsObjectRel
    Private strID_Object As String
    Private strName_Object As String
    Private strID_Parent_Object As String
    Private strName_Parent_Object As String
    Private strID_Other As String
    Private strName_Other As String
    Private strID_Parent_Right As String
    Private strName_Parent_Right As String
    Private strID_RelationType As String
    Private strName_RelationType As String
    Private strID_Ontology As String
    Private lngOrderID As Long
    Private strID_ItemType As String
    Private strName_ItemType As String

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

End Class
