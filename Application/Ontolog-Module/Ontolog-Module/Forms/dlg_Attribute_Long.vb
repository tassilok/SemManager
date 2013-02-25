Imports System.Windows.Forms

Public Class dlg_Attribute_Long

    Private strCaption As String
    Private lngValue As Long
    Private objLocalConfig As clsLocalConfig

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
    End Sub
End Class
