Public Class clsVersionValues
    Private intMajor As Integer
    Private intMinor As Integer
    Private intBuild As Integer
    Private intRevision As Integer

    Public Property Major() As Integer
        Get
            Return intMajor
        End Get
        Set(ByVal value As Integer)
            intMajor = value
        End Set
    End Property

    Public Property Minor() As Integer
        Get
            Return intMinor
        End Get
        Set(ByVal value As Integer)
            intMinor = value
        End Set
    End Property

    Public Property Build() As Integer
        Get
            Return intBuild
        End Get
        Set(ByVal value As Integer)
            intBuild = value
        End Set
    End Property

    Public Property Revision() As Integer
        Get
            Return intRevision
        End Get
        Set(ByVal value As Integer)
            intRevision = value
        End Set
    End Property

    Public Function is_New_Bigger(ByVal Major As Integer, _
                              ByVal Minor As Integer, _
                              ByVal Build As Integer, _
                              ByVal Revision As Integer) As Boolean
        Dim boolResult As Boolean

        If intMajor < Major Then
            boolResult = True
        Else
            If intMinor < Minor Then
                boolResult = True
            Else
                If intBuild < Build Then
                    boolResult = True
                Else
                    If intRevision < Revision Then
                        boolResult = True
                    Else
                        boolResult = False
                    End If
                End If
            End If
        End If
        Return boolResult
    End Function

End Class
