Public Class clsObjectTree
    Private strID_Object As String
    Private strName_Object As String
    Private strID_Parent As String
    Private strID_Object_Parent As String

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

    Public Property ID_Parent As String
        Get
            Return strID_Parent
        End Get
        Set(ByVal value As String)
            strID_Parent = value
        End Set
    End Property

    Public Property ID_Object_Parent As String
        Get
            Return strID_Object_Parent
        End Get
        Set(ByVal value As String)
            strID_Object_Parent = value
        End Set
    End Property


    Public Sub New(ByVal ID_Object As String, ByVal Name_Object As String, ByVal ID_Parent As String, ByVal ID_Object_Parent As String)
        strID_Object = ID_Object
        strName_Object = Name_Object
        strID_Parent = ID_Parent
        strID_Object_Parent = ID_Object_Parent
    End Sub
End Class
