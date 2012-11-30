Imports System.Windows.Forms

Public Class dlgAttribute_VarcharMax

    Private objUserControl_Attribute_VarcharMax As New UserControl_Attribute_VarcharMax

    Dim strCaption As String
    Dim strValue As String
    Dim objGlobals As clsGlobals
    Public ReadOnly Property Value() As String
        Get
            strValue = objUserControl_Attribute_VarcharMax.Value
            Return strValue
        End Get
    End Property
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If objUserControl_Attribute_VarcharMax.Value = "" Then
            MsgBox("Die Zeichenfolge darf nicht leer sein!", MsgBoxStyle.Exclamation)
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If

        
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New(ByVal Caption As String, ByVal Globals As clsGlobals, Optional ByVal Value As String = Nothing)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        strCaption = Caption
        strValue = Value
        objGlobals = Globals

        If Not strValue Is Nothing Then
            objUserControl_Attribute_VarcharMax.Value = strValue
        End If
        objUserControl_Attribute_VarcharMax.Dock = DockStyle.Fill
        Panel1.Controls.Add(objUserControl_Attribute_VarcharMax)
    End Sub
End Class
