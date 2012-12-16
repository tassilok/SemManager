Imports Sem_Manager
Public Class frmProcessModule
    Private objLocalConfig As clsLocalConfig
    Private WithEvents objUserControl_Process As UserControl_Process
    Private boolApplyable As Boolean
    Private objSemItem_Result As clsSemItem

    Public ReadOnly Property SemItem_Result As clsSemItem
        Get
            Return objSemItem_Result
        End Get
    End Property


    Public Property applyable As Boolean
        Get
            Return boolApplyable
        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
            objUserControl_Process.applyable = boolApplyable
        End Set
    End Property

    Private Sub applied_Process(ByVal objSemItem_Process) Handles objUserControl_Process.Applied_Process
        objSemItem_Result = objSemItem_Process
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub readed_Items_Process(ByVal intCount As Integer, ByVal intDone As Integer) Handles objUserControl_Process.readed_Items
        ToolStripProgressBar_Count.Minimum = 1
        ToolStripProgressBar_Count.Maximum = intCount
        ToolStripProgressBar_Count.Value = intDone
    End Sub
    Private Sub finished_Reading_Process() Handles objUserControl_Process.finished_reading
        ToolStripProgressBar_Count.Minimum = 0
        ToolStripProgressBar_Count.Value = 0
    End Sub
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        initialize()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Private Sub initialize()
        objUserControl_Process = New UserControl_Process(objLocalConfig)
        objUserControl_Process.Dock = DockStyle.Fill
        TabPage_Process.Controls.Add(objUserControl_Process)

        objUserControl_Process.fill_Processes()
    End Sub

    Private Sub TabControl_ProcessServiceFunction_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl_ProcessServiceFunction.SelectedIndexChanged
        ToolStripProgressBar_Count.Minimum = 0
        ToolStripProgressBar_Count.Value = 0
        objUserControl_Process.abort_Threads()

        Select Case TabControl_ProcessServiceFunction.SelectedTab.Name
            Case TabPage_Functions.Name

            Case TabPage_Problems.Name
            Case TabPage_Process.Name

                objUserControl_Process.fill_Processes()
            Case TabPage_Services.Name
        End Select
    End Sub
End Class
