Public Class UserControl_Attribute_Long

    Private lngValue As Long

    Public Property Value As Long
        Get

            Return lngValue
        End Get
        Set(ByVal value As Long)
            lngValue = value
            TextBox_Value.Text = lngValue
        End Set
    End Property

    Private Sub TextBox_Value_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Value.TextChanged
        Dim lngValue_old As Long
        lngValue_old = lngValue
        If Long.TryParse(TextBox_Value.Text, lngValue) = False Then
            If Not TextBox_Value.Text = "-" Then
                TextBox_Value.Text = lngValue_old
                MsgBox("Bitte nur Ziffern eingeben!", MsgBoxStyle.Information)
            End If

        End If
    End Sub
End Class
