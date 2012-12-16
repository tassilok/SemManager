Imports Sem_Manager
Public Class frmAuthenticate

    <FlagsAttribute()> _
    Public Enum ERelateMode As Integer
        NoRelate = 1
        User_To_Group = 2
        Group_To_User = 3
    End Enum

    Private boolUser As Boolean
    Private boolGroup As Boolean

    Private objLocalConfig As clsLocalConfig
    Private WithEvents objUserControl_Authenticate As UserControl_Authenticate

    Private objSemItem_User As clsSemItem
    Private objSemItem_Group As clsSemItem

    Private intAuthenticationMode As ERelateMode

    Public ReadOnly Property SemItem_User As clsSemItem
        Get
            Return objSemItem_User
        End Get
    End Property

    Public ReadOnly Property SemItem_Group As clsSemItem
        Get
            Return objSemItem_Group
        End Get
    End Property

    Private Sub applied(ByVal SemItem_User As clsSemItem, ByVal SemItem_Group As clsSemItem) Handles objUserControl_Authenticate.applied
        objSemItem_User = SemItem_User
        objSemItem_Group = SemItem_Group
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Public Sub New(ByVal AuthenticationMode As ERelateMode, ByVal boolUser As Boolean, ByVal boolGroup As Boolean)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        intAuthenticationMode = AuthenticationMode
        Me.boolGroup = boolGroup
        Me.boolUser = boolUser
        initialize()

    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal boolUser As Boolean, ByVal boolGroup As Boolean, ByVal AuthenticationMode As ERelateMode)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        intAuthenticationMode = AuthenticationMode
        Me.boolGroup = boolGroup
        Me.boolUser = boolUser
        initialize()

    End Sub

    Public Sub New(ByVal Globals As clsGlobals, ByVal AuthenticationMode As ERelateMode, ByVal boolUser As Boolean, ByVal boolGroup As Boolean)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        intAuthenticationMode = AuthenticationMode
        Me.boolGroup = boolGroup
        Me.boolUser = boolUser
        initialize()

    End Sub

    Private Sub initialize()
        set_DBConnection()

        objUserControl_Authenticate = New UserControl_Authenticate(objLocalConfig)
        objUserControl_Authenticate.Dock = DockStyle.Fill
        ToolStripContainer1.ContentPanel.Controls.Add(objUserControl_Authenticate)
        objUserControl_Authenticate.initialize_Authentication(boolUser, boolGroup, intAuthenticationMode)
    End Sub

    Private Sub set_DBConnection()

    End Sub

    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class