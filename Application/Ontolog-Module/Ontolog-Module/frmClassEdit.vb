Public Class frmClassEdit
    Private objLocalConfig As clsLocalConfig

    Private WithEvents objUserControl_ClassAttributeType As UserControl_ClassAttributeTypes

    Private objOItem_Class As clsOntologyItem

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal oItem_Class As clsOntologyItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objOItem_Class = oItem_Class
        objLocalConfig = LocalConfig
        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        objUserControl_ClassAttributeType.Dock = DockStyle.Fill

        SplitContainer1.Panel1.Controls.Add(objUserControl_ClassAttributeType)

    End Sub

    Private Sub set_DBConnection()
        objUserControl_ClassAttributeType = New UserControl_ClassAttributeTypes(objLocalConfig, objOItem_Class)
        
    End Sub
End Class