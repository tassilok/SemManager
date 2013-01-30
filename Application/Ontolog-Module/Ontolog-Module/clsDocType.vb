Public Class clsDocType
    Private strDoc As String
    Private oList_Fields As New List(Of String)

    Public ReadOnly Property Doc As String
        Get
            Return strDoc
        End Get
    End Property

    Public Sub add_Field(ByVal strField As String)
        oList_Fields.Add(strField)
    End Sub
End Class
