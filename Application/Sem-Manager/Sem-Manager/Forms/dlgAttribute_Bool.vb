Imports System.Windows.Forms

Public Class dlgAttribute_Bool
    Private WithEvents objUserControl_Attribute_Bool As New UserControl_Attribute_Bool

    Private strCaption As String
    Private objGlobals As clsGlobals
    Private boolValue As Boolean

    Public ReadOnly Property Value() As Boolean
        Get
            boolValue = objUserControl_Attribute_Bool.Value
            Return boolValue
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

    Public Sub New(ByVal Caption As String, ByVal Globals As clsGlobals, Optional ByVal Value As Boolean = Nothing)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        strCaption = Caption
        objGlobals = Globals
        boolValue = Value


        Me.Text = strCaption
        If Not boolValue = Nothing Then
            objUserControl_Attribute_Bool.Value = boolValue
        End If

        objUserControl_Attribute_Bool.Dock = DockStyle.Fill
        Panel1.Controls.Add(objUserControl_Attribute_Bool)
    End Sub
End Class
