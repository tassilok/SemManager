Public Class UserControl_Attribute_Bool

    Public Event selected_True()
    Public Event selected_False()

    Public Property Value() As Boolean
        Get
            Return RadioButton_True.Checked
        End Get
        Set(ByVal value As Boolean)
            RadioButton_True.Checked = value
        End Set
    End Property
End Class
