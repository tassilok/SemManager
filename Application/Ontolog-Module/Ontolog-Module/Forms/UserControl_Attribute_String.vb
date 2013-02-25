Public Class UserControl_Attribute_String

    Public Property Value As String
        Get
            Return TextBox_Val.Text
        End Get
        Set(ByVal value As String)
            TextBox_Val.Text = value
        End Set
    End Property


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
