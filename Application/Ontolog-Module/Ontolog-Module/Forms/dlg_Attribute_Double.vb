Imports System.Windows.Forms

Public Class dlg_Attribute_Double

    Private objLocalConfig As clsLocalConfig

    Private objUserControl_Attribute_Double As UserControl_Attribute_Double

    Private strCaption As String
    Private dblValue As Double

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If objUserControl_Attribute_Double.Test_Value = True Then
            dblValue = objUserControl_Attribute_Double.Value
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Der eingegebenen Wert darf nur numerisch sein!", MsgBoxStyle.Information)
        End If
        
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New(ByVal Caption As String, ByVal Globals As clsGlobals, Optional ByVal Value As Double = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objLocalConfig = New clsLocalConfig(Globals)
        strCaption = Caption
        dblValue = Value

        initialize()
    End Sub

    Public Sub New(ByVal Caption As String, ByVal LocalConfig As clsLocalConfig, Optional ByVal Value As Double = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objLocalConfig = LocalConfig
        strCaption = Caption
        dblValue = Value

        initialize()
    End Sub

    Private Sub initialize()
        Me.Text = strCaption
        objUserControl_Attribute_Double = New UserControl_Attribute_Double
        objUserControl_Attribute_Double.Value = dblValue


    End Sub
End Class
