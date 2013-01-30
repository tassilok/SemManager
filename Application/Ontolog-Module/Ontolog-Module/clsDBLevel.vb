Imports ElasticSearch
Public Class clsDBLevel
    Private objElConn As ElasticSearch.Client.ElasticSearchClient
    Private objOntologyList As List(Of clsOntologyItem)
    Private objGlobals As clsGlobals


    Public Sub New(ByVal Globals As clsGlobals)
        objGlobals = Globals
    End Sub
End Class
