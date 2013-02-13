Public Class frmClassEdit
    Private objLocalConfig As clsLocalConfig

    Private WithEvents objUserControl_ClassAttributeType As UserControl_ClassAttributeTypes
    Private WithEvents objUserControl_ClassRel_Forward As UserControl_ClassRel
    Private WithEvents objUserControl_ClassRel_Backward As UserControl_ClassRel
    Private WithEvents objUserControl_ClassRel_OR As UserControl_ClassRel

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

        objUserControl_ClassRel_Forward.Dock = DockStyle.Fill

        TabPage_Forward.Controls.Add(objUserControl_ClassRel_Forward)

        objUserControl_ClassRel_Backward.Dock = DockStyle.Fill

        TabPage_Backward.Controls.Add(objUserControl_ClassRel_Backward)

        objUserControl_ClassRel_OR.Dock = DockStyle.Fill

        TabPage_ObjectReferences.Controls.Add(objUserControl_ClassRel_OR)

        ToolStripTextBox_GUID.Text = objOItem_Class.GUID
        ToolStripTextBox_Name.Text = objOItem_Class.Name
    End Sub

    Private Sub set_DBConnection()
        objUserControl_ClassAttributeType = New UserControl_ClassAttributeTypes(objLocalConfig, objOItem_Class)
        objUserControl_ClassRel_Forward = New UserControl_ClassRel(objLocalConfig, objOItem_Class, objLocalConfig.Globals.Direction_LeftRight, False)
        objUserControl_ClassRel_Backward = New UserControl_ClassRel(objLocalConfig, objOItem_Class, objLocalConfig.Globals.Direction_RightLeft, False)
        objUserControl_ClassRel_OR = New UserControl_ClassRel(objLocalConfig, objOItem_Class, objLocalConfig.Globals.Direction_LeftRight, True)

    End Sub
End Class