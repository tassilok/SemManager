Imports System.Windows.Forms

Public Class dlg_Attribute_DateTime

    Private objUserControl_Attribute_DateTime As UserControl_Attribute_DateTime

    Private strCaption As String
    Private objLocalConfig As clsLocalConfig
    Private dateValue As Date

    Public ReadOnly Property Value
        Get
            Return objUserControl_Attribute_DateTime.Value
        End Get
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New(ByVal Caption As String, ByVal Globals As clsGlobals, Optional ByVal Value As Date = Nothing)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        strCaption = Caption
        objLocalConfig = New clsLocalConfig(Globals)
        If Value = Nothing Then
            Value = Now
        End If

        initialize()
    End Sub

    Public Sub New(ByVal Caption As String, ByVal LocalConfig As clsLocalConfig, Optional ByVal Value As Date = Nothing)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        strCaption = Caption
        objLocalConfig = LocalConfig
        If Value = Nothing Then
            Value = Now
        End If

        initialize()
    End Sub

    Private Sub initialize()
        Me.Text = strCaption
        objUserControl_Attribute_DateTime = New UserControl_Attribute_DateTime()
        objUserControl_Attribute_DateTime.Dock = DockStyle.Fill
        Panel_Attribute.Controls.Add(objUserControl_Attribute_DateTime)
    End Sub
End Class
