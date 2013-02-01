Public Class clsClassRel
    Dim strID_Class_Left As String
    Dim strID_Class_Right As String
    Dim strID_RelationType As String
    Dim lngMin_Forw As Long
    Dim lngMax_Forw As Long
    Dim lngMax_Backw As Long

    Public Property ID_Class_Left As String
        Get
            Return strID_Class_Left
        End Get
        Set(ByVal value As String)
            strID_Class_Left = value
        End Set
    End Property

    Public Property ID_Class_Right As String
        Get
            Return strID_Class_Right
        End Get
        Set(ByVal value As String)
            strID_Class_Right = value
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

    Public Property Min_Forw As Long
        Get
            Return lngMin_Forw
        End Get
        Set(ByVal value As Long)
            lngMin_Forw = value
        End Set
    End Property

    Public Property Max_Forw As Long
        Get
            Return lngMax_Forw
        End Get
        Set(ByVal value As Long)
            lngMax_Forw = value
        End Set
    End Property

    Public Property Max_Backw As Long
        Get
            Return lngMax_Backw
        End Get
        Set(ByVal value As Long)
            lngMax_Backw = value
        End Set
    End Property

    Public Sub New(ByVal ID_Class_Left As String, ByVal ID_Class_Right As String, ByVal ID_RelationType As String, ByVal Min_forw As Long, ByVal Max_forw As Long, ByVal Max_backw As Long)
        strID_Class_Left = ID_Class_Left
        strID_Class_Right = ID_Class_Right
        strID_RelationType = ID_RelationType
        lngMin_Forw = Min_forw
        lngMax_Forw = Max_forw
        lngMax_Backw = Max_backw
    End Sub
End Class
