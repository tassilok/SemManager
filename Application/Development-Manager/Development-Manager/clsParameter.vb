Public Class clsParameter
    Private strName_Direction As String
    Private strctGUID_Parameter_DevStructure As Guid
    Private strctGUID_Direction As Guid
    Private strctGUID_Parameter As Guid
    Private strName_Parameter As String
    Private strctGUID_SoftwareDevelopment As Guid
    Private strName_SoftwareDevelopment As String


    Public Property Name_Direction() As String
        Get
            Return strName_Direction
        End Get
        Set(ByVal value As String)
            strName_Direction = value
        End Set
    End Property

    Public Property GUID_Parameter_DevStructure() As Guid
        Get
            Return strctGUID_Parameter_DevStructure
        End Get
        Set(ByVal value As Guid)
            strctGUID_Parameter_DevStructure = value
        End Set
    End Property

    Public Property GUID_Direction() As Guid
        Get
            Return strctGUID_Direction
        End Get
        Set(ByVal value As Guid)
            strctGUID_Direction = value
        End Set
    End Property

    Public Property GUID_Parameter() As Guid
        Get
            Return strctGUID_Parameter
        End Get
        Set(ByVal value As Guid)
            strctGUID_Parameter = value
        End Set
    End Property

    Public Property Name_Parameter() As String
        Get
            Return strName_Parameter
        End Get
        Set(ByVal value As String)
            strName_Parameter = value
        End Set
    End Property

    Public Property GUID_SoftwareDevelopment() As Guid
        Get
            Return strctGUID_SoftwareDevelopment
        End Get
        Set(ByVal value As Guid)
            strctGUID_SoftwareDevelopment = value
        End Set
    End Property

    Public Property Name_SoftwareDevelopment() As String
        Get
            Return strName_SoftwareDevelopment
        End Get
        Set(ByVal value As String)
            strName_SoftwareDevelopment = value
        End Set
    End Property

End Class
