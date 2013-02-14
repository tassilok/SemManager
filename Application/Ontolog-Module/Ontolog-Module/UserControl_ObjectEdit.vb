Public Class UserControl_ObjectEdit

    Private objLocalConfig As clsLocalConfig
    Private objDBLevel As clsDBLevel
    Private objOList_Objects As List(Of clsOntologyItem)
    Private objOList_ObjectRel As List(Of clsObjectRel)
    Private objDataGridviewRowCollection_Objects As DataGridViewRowCollection
    Private objUserControl_ObjectRelTree As UserControl_ObjectRelTree
    Private objOItem_Object As clsOntologyItem
    Private objOItem_ObjectRel As clsObjectRel
    Private intRowID As Integer
    Private strOntology As String

    Public Sub New(ByVal OList_Objecst As List(Of clsObjectRel), ByVal Ontology As String, ByVal RowID As Integer, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)

        objOList_ObjectRel = OList_Objecst
        objDataGridviewRowCollection_Objects = Nothing
        intRowID = RowID
        strOntology = Ontology

        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal OList_Objecst As List(Of clsOntologyItem), ByVal Ontology As String, ByVal RowID As Integer, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)

        objOList_Objects = OList_Objecst
        objDataGridviewRowCollection_Objects = Nothing
        intRowID = RowID
        strOntology = Ontology

        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal DataGridviewRowCollection As DataGridViewRowCollection, ByVal Ontology As String, ByVal RowID As Integer, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)

        objDataGridviewRowCollection_Objects = DataGridviewRowCollection
        objOList_Objects = Nothing
        intRowID = RowID
        strOntology = Ontology

        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        If Not objOList_Objects Is Nothing Then
            objOItem_Object = objOList_Objects(intRowID)

            ToolStripTextBox_GUID.Text = objOItem_Object.GUID
            ToolStripTextBox_Name.Text = objOItem_Object.Name

        ElseIf objDataGridviewRowCollection_Objects Is Nothing Then

        Else

            objDGVR_Selected = objDataGridviewRowCollection_Objects(intRowID)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objOItem_Object = New clsOntologyItem
            objOItem_Object.GUID = objDRV_Selected.Item("ID_Item")
            objOItem_Object.Name = objDRV_Selected.Item("Name")
            objOItem_Object.GUID_Parent = objDRV_Selected.Item("ID_Parent")

            ToolStripTextBox_GUID.Text = objOItem_Object.GUID
            ToolStripTextBox_Name.Text = objOItem_Object.Name
        End If

        objUserControl_ObjectRelTree = New UserControl_ObjectRelTree(objLocalConfig, objOItem_Object)
        objUserControl_ObjectRelTree.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Clear()
        SplitContainer1.Panel1.Controls.Add(objUserControl_ObjectRelTree)
        set_CountLbl()
    End Sub

    Private Sub set_CountLbl()
        ToolStripLabel_ObjectCount.Text = intRowID

        If objOList_Objects Is Nothing Then
            ToolStripLabel_ObjectCount.Text = ToolStripLabel_ObjectCount.Text & "/" & objDataGridviewRowCollection_Objects.Count
        Else
            ToolStripLabel_ObjectCount.Text = ToolStripLabel_ObjectCount.Text & "/" & objOList_Objects.Count
        End If

    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)

    End Sub
End Class
