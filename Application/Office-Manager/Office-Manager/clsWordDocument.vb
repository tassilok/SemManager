Imports Microsoft.Office.Interop.Word
Public Class clsWordDocument
    Private strPathDoc As String
    Private objWordDoc As Document

    Public Property WordDoc() As Document
        Get
            Return objWordDoc
        End Get
        Set(ByVal value As Document)
            objWordDoc = value
        End Set
    End Property

    Public Property Path_Doc() As String
        Get
            Return strPathDoc
        End Get
        Set(ByVal value As String)
            strPathDoc = value
        End Set
    End Property

End Class
