Public Class UserControl_Attribute_Boolean

    Public Event state_Changed()

    Public Property Value As Boolean
        Get
            Return RadioButton_True.Checked
        End Get
        Set(ByVal value As Boolean)
            RadioButton_True.Checked = value
        End Set
    End Property

    Private Sub RadioButton_True_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_True.CheckedChanged
        RaiseEvent state_Changed()
    End Sub
End Class
