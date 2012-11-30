Imports System.Windows.Forms

Public Class dlgAttribute_Int

    Private WithEvents objUserControl_Attribute_Int As New UserControl_Attribute_Int

    Private strCaption As String
    Private intValue As Integer
    Private objGlobals As clsGlobals

    Private Sub doTerm() Handles objUserControl_Attribute_Int.Term_Do
        Dim strTerm As String
        strTerm = objUserControl_Attribute_Int.Term
        TextBox_Term.Text = strTerm
        Button_Calc.Enabled = True
    End Sub

    Private Sub noTerm() Handles objUserControl_Attribute_Int.Term_No
        TextBox_Term.Text = ""
        Button_Calc.Enabled = False
    End Sub

    Public ReadOnly Property Value() As Integer
        Get
            Return objUserControl_Attribute_Int.Value
        End Get
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If objUserControl_Attribute_Int.OK = True Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Bitte überprüfen Sie Ihre Eingaben!", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New(ByVal Caption As String, ByVal Globals As clsGlobals, Optional ByVal Value As Integer = Nothing)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        strCaption = Caption
        intValue = Value
        objGlobals = Globals

        objUserControl_Attribute_Int.Value = intValue
        Me.Text = strCaption
        objUserControl_Attribute_Int.Dock = DockStyle.Fill
        Panel1.Controls.Add(objUserControl_Attribute_Int)
    End Sub







    Private Sub Button_Calc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Calc.Click
        Dim strTerm As String
        Dim i As Integer
        Dim intValTmp As Integer
        Dim strOperator As String

        strTerm = TextBox_Term.Text

        intValue = 0
        strOperator = "+"

        For i = 0 To strTerm.Length - 1
            If Integer.TryParse(strTerm.Substring(i, 1), intValTmp) Then
                Select Case strOperator
                    Case "+"
                        intValue = intValue + intValTmp
                    Case "-"
                        intValue = intValue - intValTmp
                    Case "*"
                        intValue = intValue * intValTmp
                End Select

            Else
                Select Case strTerm.Substring(i, 1)
                    Case "+", "*", "-"
                        strOperator = strTerm.Substring(i, 1)
                    
                End Select
            End If
        Next

        objUserControl_Attribute_Int.Value = intValue
    End Sub
End Class
