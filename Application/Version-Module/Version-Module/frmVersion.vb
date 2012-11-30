Imports Sem_Manager
Public Class frmVersion
    Private objLocalConfig As clsLocalConfig
    Private objVersionVals As New clsVersionValues
    Private WithEvents objUserControl_Version As UserControl_Version
    Private boolDescribe As Boolean

    Private Sub Apply_Version() Handles objUserControl_Version.Apply
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub
    Private Sub Cancel_Version() Handles objUserControl_Version.Cancel
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Hide()
    End Sub
    Public Sub New(ByVal objGlobals As clsGlobals, _
                   ByVal SemItem_Ref As clsSemItem, _
                   ByVal objSemItem_User As clsSemItem, _
                   ByVal Describe As Boolean, _
                   Optional ByVal SemItem_Token_LogEntry As clsSemItem = Nothing)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        boolDescribe = Describe

        objLocalConfig = New clsLocalConfig(objGlobals)
        objLocalConfig.SemItem_User = objSemItem_User
        objUserControl_Version = New UserControl_Version()



        objUserControl_Version.initialize(objLocalConfig, SemItem_Ref, objSemItem_User, Describe, SemItem_Token_LogEntry)
        objUserControl_Version.Dock = DockStyle.Fill
        objUserControl_Version.VisibleInvisible_Cancel(True)
        objUserControl_Version.VisibleInvisible_Clear(True)
        Me.Controls.Add(objUserControl_Version)

    End Sub






















End Class