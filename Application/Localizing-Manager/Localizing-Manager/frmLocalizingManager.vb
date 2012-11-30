Imports Sem_Manager
Public Class frmLocalizingManager
    Private WithEvents objUserControl_RelationTree As UserControl_RelationTree
    Private objUserControl_Localized As UserControl_Localized

    Private objLocalConfig As clsLocalConfig

    Private Sub selected_Related(ByVal SemItem_Selected As clsSemItem) Handles objUserControl_RelationTree.selected_Item
        objUserControl_Localized.initialize(SemItem_Selected, _
                                            objLocalConfig.SemItems_Language, _
                                            True)
    End Sub

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)

        initialize()
    End Sub

    Private Sub initialize()
        objUserControl_RelationTree = New UserControl_RelationTree(objLocalConfig)
        objUserControl_RelationTree.Dock = DockStyle.Fill

        SplitContainer1.Panel1.Controls.Add(objUserControl_RelationTree)

        objUserControl_Localized = New UserControl_Localized(objLocalConfig.Globals)
        objUserControl_Localized.Dock = DockStyle.Fill

        SplitContainer1.Panel2.Controls.Add(objUserControl_Localized)

    End Sub
End Class
