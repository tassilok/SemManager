Public Class clsContentObject
    Private _Name_Doc As String
    Private objContentControl As Microsoft.Office.Interop.Word.ContentControl

    Public Property Name_Doc() As String
        Get
            Return _Name_Doc
        End Get
        Set(ByVal Value As String)
            _Name_Doc = Value
        End Set
    End Property

    Public Property ContentControl() As Microsoft.Office.Interop.Word.ContentControl
        Get
            Return objContentControl
        End Get
        Set(ByVal value As Microsoft.Office.Interop.Word.ContentControl)
            objContentControl = value
        End Set
    End Property
End Class