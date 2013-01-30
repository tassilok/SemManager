Public Class clsLocalConfig
    Private objGlobals As clsGlobals

    Public ReadOnly Property Globals As clsGlobals
        Get
            Return objGlobals
        End Get
    End Property

    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals
    End Sub
End Class
