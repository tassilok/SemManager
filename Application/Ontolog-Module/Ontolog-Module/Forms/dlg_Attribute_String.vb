Imports System.Windows.Forms

Public Class dlg_Attribute_String
    Private objUserControl_Attribute_String As UserControl_Attribute_String

    Private strCaption As String
    Private objLocalConfig As clsLocalConfig
    Private strValue As String

    Public ReadOnly Property Value As String
        Get
            Return objUserControl_Attribute_String.Value
        End Get
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If objUserControl_Attribute_String.Value.Length > 0 Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Keine leeren Zeichenketten, bitte!", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        If objUserControl_Attribute_String.Value <> strValue Then
            If MsgBox("Der Text wurde geändert! Wollen Sie den Dialog wirklich beenden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If

        End If
        
    End Sub

    Public Sub New(ByVal Caption As String, ByVal Globals As clsGlobals, Optional ByVal Value As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strCaption = Caption
        strValue = Value
        objLocalConfig = New clsLocalConfig(Globals)

        initialize()
    End Sub

    Public Sub New(ByVal Caption As String, ByVal LocalConfig As clsLocalConfig, Optional ByVal Value As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strCaption = Caption
        strValue = Value
        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Private Sub initialize()
        Me.Text = strCaption
        objUserControl_Attribute_String = New UserControl_Attribute_String()
        objUserControl_Attribute_String.Value = strValue
    End Sub
End Class
