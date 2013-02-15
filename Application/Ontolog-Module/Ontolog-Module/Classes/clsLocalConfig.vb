Public Class clsLocalConfig
    Private objGlobals As clsGlobals


    Private Sub get_Config()
        get_Config_AttributeTypes()
        get_Config_RelationTypes()
        get_Config_Classes()
        get_Config_Objects()
    End Sub

    Private Sub get_Config_AttributeTypes()

    End Sub

    Private Sub get_Config_RelationTypes()

    End Sub

    Private Sub get_Config_Objects()

    End Sub

    Private Sub get_Config_Classes()

    End Sub

    Public ReadOnly Property Globals As clsGlobals
        Get
            Return objGlobals
        End Get
    End Property

    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals
        initialize()
    End Sub

    Private Sub initialize()
        get_Config()
    End Sub
End Class
