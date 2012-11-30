Public Class frmSearchResult
    Private objGlobals As clsGlobals
    Private WithEvents objUserControl_SearchResult As UserControl_SearchResult
    Private strSearch As String

    Public Event selected_SemItem(ByVal SemItem_Selected As clsSemItem)

    Private Sub selected_SemItem_UserContrl(ByVal SemItem_Selected As clsSemItem) Handles objUserControl_SearchResult.selected_Item
        RaiseEvent selected_SemItem(SemItem_Selected)
    End Sub

    Public Sub New(ByVal Globals As clsGlobals, ByVal Search As String)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objGlobals = Globals

        objUserControl_SearchResult = New UserControl_SearchResult(objGlobals)
        objUserControl_SearchResult.Dock = DockStyle.Fill
        Panel_SearchResults.Controls.Add(objUserControl_SearchResult)

        strSearch = Search
        objUserControl_SearchResult.find_Item(strSearch)
    End Sub
End Class