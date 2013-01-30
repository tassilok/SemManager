Public Class clsOntologyItem
    Private Const cint_LeftRight As Integer = 1
    Private Const cint_RightLeft As Integer = 2
    Private objOList_Rel As List(Of clsOntologyItem)
    Private objGUID_Item As String
    Private objGUID_Parent As String
    Private objGUID_Related As String
    Private objGUID_Relation As String
    Private strName As String
    Private strCaption As String
    Private strAdditional1 As String
    Private strAdditional2 As String
    Private objGUID_Type As String
    Private strFilter As String
    Private intImageID As Integer
    Private intVersion As Integer
    Private intLevel As Integer
    Private boolNew As Boolean
    Private boolDel As Boolean
    Private boolMark As Boolean
    Private boolObjectReference As Boolean
    Private intDirection As Integer
    Private intMin As Integer
    Private intMax As Integer
    Private intMax2 As Integer


    Public ReadOnly Property OList_Rel As List(Of clsOntologyItem)
        Get
            Return objOList_Rel
        End Get
    End Property

    Public WriteOnly Property add_OItem(ByVal OItem As clsOntologyItem)
        Set(ByVal value)
            objOList_Rel.Add(OItem)
        End Set
    End Property

    Public Property Rel_ObjectReference() As Boolean
        Get
            Return boolObjectReference
        End Get
        Set(ByVal value As Boolean)
            boolObjectReference = value
        End Set
    End Property
    Public Property Mark() As Boolean
        Get
            Return boolMark
        End Get
        Set(ByVal value As Boolean)
            boolMark = value
        End Set
    End Property
    Public Property Additional1() As String
        Get
            Return strAdditional1
        End Get
        Set(ByVal value As String)
            strAdditional1 = value
        End Set
    End Property
    Public Property Additional2() As String
        Get
            Return strAdditional2
        End Get
        Set(ByVal value As String)
            strAdditional2 = value
        End Set
    End Property
    Public Property Direction() As Integer
        Get
            Return intDirection
        End Get
        Set(ByVal value As Integer)
            intDirection = value
        End Set
    End Property

    Public ReadOnly Property Direction_RightLeft() As Integer
        Get
            Return cint_RightLeft
        End Get
    End Property
    Public ReadOnly Property Direction_LeftRight() As Integer
        Get
            Return cint_LeftRight
        End Get

    End Property
    Public Property Level() As Integer
        Get
            Return intLevel
        End Get
        Set(ByVal value As Integer)
            intLevel = value
        End Set
    End Property

    Public Property deleted() As Boolean
        Get
            Return boolDel
        End Get
        Set(ByVal value As Boolean)
            boolDel = value
        End Set
    End Property
    Public Property new_Item() As Boolean
        Get
            Return boolNew
        End Get
        Set(ByVal value As Boolean)
            boolNew = value
        End Set
    End Property

    Public Property ImageID() As Integer
        Get
            Return intImageID
        End Get
        Set(ByVal value As Integer)
            intImageID = value
        End Set
    End Property
    Public Property GUID() As String
        Get
            Return objGUID_Item
        End Get
        Set(ByVal value As String)
            objGUID_Item = value
        End Set
    End Property

    Public Property GUID_Parent() As String
        Get
            Return objGUID_Parent
        End Get
        Set(ByVal value As String)
            objGUID_Parent = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property
    Public Property Caption() As String
        Get
            Return strCaption
        End Get
        Set(ByVal value As String)
            strCaption = value
        End Set
    End Property
    Public Property GUID_Type() As String
        Get
            Return objGUID_Type
        End Get
        Set(ByVal value As String)
            objGUID_Type = value
        End Set
    End Property
    Public Property Filter() As String
        Get
            Return strFilter
        End Get
        Set(ByVal value As String)
            strFilter = value
        End Set
    End Property
    Public Property Version() As Integer
        Get
            Return intVersion
        End Get
        Set(ByVal value As Integer)
            intVersion = value
        End Set
    End Property
    Public Property GUID_Related() As String
        Get
            Return objGUID_Related
        End Get
        Set(ByVal value As String)
            objGUID_Related = value
        End Set
    End Property
    Public Property GUID_Relation() As String
        Get
            Return objGUID_Relation
        End Get
        Set(ByVal value As String)
            objGUID_Relation = value
        End Set
    End Property
    Public Property Min() As Integer
        Get
            Return intMin
        End Get
        Set(ByVal value As Integer)
            intMin = value
        End Set
    End Property

    Public Property Max1() As Integer
        Get
            Return intMax
        End Get
        Set(ByVal value As Integer)
            intMax = value
        End Set
    End Property

    Public Property Max2() As Integer
        Get
            Return intMax2
        End Get
        Set(ByVal value As Integer)
            intMax2 = value
        End Set
    End Property

    Public Sub New(ByVal GUID_Item As String, ByVal Name_Item As String, ByVal GUID_Type As String)
        GUID = GUID_Item
        Name = Name_Item
        Me.GUID_Type = GUID_Type
    End Sub
    Public Sub New(ByVal GUID_Item As String, ByVal Name_Item As String, ByVal GUID_Item_Parent As String, ByVal GUID_Type As String)
        GUID = GUID_Item
        Name = Name_Item
        GUID_Parent = GUID_Item_Parent
        Me.GUID_Type = GUID_Type
    End Sub

    Public Sub New(ByVal GUID_Item As String, ByVal Name_Item As String, ByVal GUID_Relation As String, ByVal GUID_Related As String, ByVal GUID_Type As String)
        GUID = GUID_Item
        Name = Name_Item
        Me.GUID_Relation = GUID_Relation
        Me.GUID_Related = GUID_Related
        Me.GUID_Type = GUID_Type
    End Sub

End Class
