Imports System.Windows.Forms

Public Class dlg_Attribute_Boolean

    Private WithEvents objUserControl_Attribute_Boolean As UserControl_Attribute_Boolean

    Private objLocalConfig As clsLocalConfig
    Private strCaption As String
    Private boolValue As Boolean

    Public ReadOnly Property Value As Boolean
        Get
            Return boolValue
        End Get
    End Property

    Private Sub changed_Value() Handles objUserControl_Attribute_Boolean.state_Changed
        boolValue = objUserControl_Attribute_Boolean.Value
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New(ByVal Caption As String, ByVal Globals As clsGlobals, Optional ByVal Value As Boolean = True)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strCaption = Caption
        objLocalConfig = New clsLocalConfig(Globals)
        boolValue = Value

        initialize()
    End Sub

    Public Sub New(ByVal Caption As String, ByVal LocalConfig As clsLocalConfig, Optional ByVal Value As Boolean = True)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strCaption = Caption
        boolValue = Value
        objLocalConfig = LocalConfig

        initialize()

    End Sub

    Private Sub initialize()
        Me.Text = strCaption
        objUserControl_Attribute_Boolean.Dock = DockStyle.Fill
        Panel_Attribute.Controls.Add(objUserControl_Attribute_Boolean)
    End Sub
End Class
