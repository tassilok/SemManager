Public Class UserControl_TokenEdit

    Private objLocalConfig As clsLocalConfig
    Private objDBLevel As clsDBLevel
    Private objOList_Objects As List(Of clsOntologyItem)
    Private objOList_ObjectRel As List(Of clsObjectRel)
    Private objDataGridview_Objects As DataGridView
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
        objDataGridview_Objects = Nothing
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
        objDataGridview_Objects = Nothing
        intRowID = RowID
        strOntology = Ontology

        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal DataGridview_Base As DataGridView, ByVal Ontology As String, ByVal RowID As Integer, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)

        objDataGridview_Objects = DataGridview_Base
        objOList_Objects = Nothing
        intRowID = RowID
        strOntology = Ontology

        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        If objOList_Objects Is Nothing Then
            objOItem_Object = objOList_Objects(intRowID)

            ToolStripTextBox_GUID.Text = objOItem_Object.GUID
            ToolStripTextBox_Name.Name = objOItem_Object.Name

        ElseIf objDataGridview_Objects Is Nothing Then

        Else

            objDGVR_Selected = objDataGridview_Objects.Rows(intRowID)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objOItem_Object = New clsOntologyItem
            objOItem_Object.GUID = objDRV_Selected.Item("GUID")
            objOItem_Object.Name = objDRV_Selected.Item("Name")

            ToolStripTextBox_GUID.Text = objOItem_Object.GUID
            ToolStripTextBox_Name.Name = objOItem_Object.Name
        End If
        set_CountLbl()
    End Sub

    Private Sub set_CountLbl()
        ToolStripLabel_ObjectCount.Text = intRowID

        If objOList_Objects Is Nothing Then
            ToolStripLabel_ObjectCount.Text = ToolStripLabel_ObjectCount.Text & "/" & objDataGridview_Objects.RowCount
        Else
            ToolStripLabel_ObjectCount.Text = ToolStripLabel_ObjectCount.Text & "/" & objOList_Objects.Count
        End If

    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)
    End Sub
End Class
