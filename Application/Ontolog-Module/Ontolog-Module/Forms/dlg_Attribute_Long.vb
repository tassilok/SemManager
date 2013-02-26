Imports System.Windows.Forms

Public Class dlg_Attribute_Long

    Private strCaption As String
    Private lngValue As Long
    Private objLocalConfig As clsLocalConfig

    Private objUserControl_Attribute_Long As UserControl_Attribute_Long

    Public ReadOnly Property Value As Long
        Get
            Return objUserControl_Attribute_Long.Value
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

    Public Sub New(ByVal Caption As String, ByVal Globals As clsGlobals, Optional ByVal Value As Long = 0)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        strCaption = Caption
        objLocalConfig = New clsLocalConfig(Globals)
        lngValue = Value

        initialize()
    End Sub

    Public Sub New(ByVal Caption As String, ByVal LocalConfig As clsLocalConfig, Optional ByVal Value As Long = 0)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        strCaption = Caption
        objLocalConfig = LocalConfig
        lngValue = Value

        initialize()
    End Sub

    Private Sub initialize()
        Me.Text = strCaption
        objUserControl_Attribute_Long = New UserControl_Attribute_Long()
        objUserControl_Attribute_Long.Value = lngValue
        objUserControl_Attribute_Long.Dock = DockStyle.Fill
        Panel_Value.Controls.Add(objUserControl_Attribute_Long)
    End Sub
End Class
