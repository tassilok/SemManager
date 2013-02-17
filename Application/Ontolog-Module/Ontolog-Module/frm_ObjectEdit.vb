Public Class frm_ObjectEdit
    Private objLocalConfig As clsLocalConfig

    Private objUserControl_TokenEdit As UserControl_ObjectEdit

    Private objOList_Objects As List(Of clsOntologyItem)
    Private objDGVRS As DataGridViewRowCollection
    Private intRowID As Integer

    Private strType As String
    Private objOItem_Direction As clsOntologyItem

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal oList_Objects As List(Of clsOntologyItem), ByVal intRowID As Integer, ByVal Type As String, ByVal OItem_Direction As clsOntologyItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        objOList_Objects = oList_Objects
        objDGVRS = Nothing

        strType = Type
        objOItem_Direction = OItem_Direction

        Me.intRowID = intRowID

        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal objDataGridViewRowCollection As DataGridViewRowCollection, ByVal intRowID As Integer, ByVal Type As String, ByVal OItem_Direction As clsOntologyItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        strType = Type
        objOItem_Direction = OItem_Direction
        objLocalConfig = LocalConfig
        objDGVRS = objDataGridViewRowCollection
        objOList_Objects = Nothing

        Me.intRowID = intRowID

        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        Me.Controls.Clear()
        Me.Controls.Add(objUserControl_TokenEdit)
    End Sub

    Private Sub set_DBConnection()
        If objOList_Objects Is Nothing Then
            objUserControl_TokenEdit = New UserControl_ObjectEdit(objDGVRS, strType, objOItem_Direction, intRowID, objLocalConfig.Globals)
        Else
            objUserControl_TokenEdit = New UserControl_ObjectEdit(objOList_Objects, strType, objOItem_Direction, intRowID, objLocalConfig.Globals)
        End If

        objUserControl_TokenEdit.Dock = DockStyle.Fill
    End Sub
End Class