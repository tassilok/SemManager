Imports System.Windows.Forms

Public Class dlgAttribute_Real

    Private WithEvents objUserControl_Attribute_Real As New UserControl_Attribute_Real

    Dim strCaption As String
    Dim dblValue As Double
    Dim objGlobals As clsGlobals

    Private Sub doTerm() Handles objUserControl_Attribute_Real.Term_Do
        Dim strTerm As String
        strTerm = objUserControl_Attribute_Real.Term
        TextBox_Term.Text = strTerm
        Button_Calc.Enabled = True
    End Sub

    Private Sub noTerm() Handles objUserControl_Attribute_Real.Term_No
        TextBox_Term.Text = ""
        Button_Calc.Enabled = False
    End Sub

    Public Property Value() As Double
        Get
            dblValue = objUserControl_Attribute_Real.Value
            Return dblValue
        End Get
        Set(ByVal value As Double)
            objUserControl_Attribute_Real.Value = value
        End Set

    End Property
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If objUserControl_Attribute_Real.OK = True Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Überprüfen Sie bitte Ihre eingaben!", MsgBoxStyle.Information)
        End If
        
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New(ByVal Caption As String, ByVal Globals As clsGlobals, Optional ByVal Value As Double = Nothing)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        strCaption = Caption
        objGlobals = Globals
        dblValue = Value
        Me.Text = strCaption
        If Not dblValue = Nothing Then
            objUserControl_Attribute_Real.Value = dblValue
        End If
        objUserControl_Attribute_Real.Dock = DockStyle.Fill
        Panel1.Controls.Add(objUserControl_Attribute_Real)
    End Sub



    Private Sub Button_Calc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Calc.Click
        Dim strTerm As String
        Dim i As Integer
        Dim dblValTmp As Double
        Dim intAfterKomma As Integer
        Dim strOperator As String

        strTerm = TextBox_Term.Text

        dblValue = 0
        strOperator = "+"
        intAfterKomma = 10

        For i = 0 To strTerm.Length - 1
            If Integer.TryParse(strTerm.Substring(i, 1), dblValTmp) Then
                Select Case strOperator
                    Case "+"
                        dblValue = dblValue + dblValTmp
                        intAfterKomma = 10
                    Case "-"
                        dblValue = dblValue - dblValTmp
                        intAfterKomma = 10
                    Case "/"
                        dblValue = dblValue / dblValTmp
                        intAfterKomma = 10
                    Case "*"
                        dblValue = dblValue * dblValTmp
                        intAfterKomma = 10
                    Case ","
                        dblValue = dblValue + (dblValTmp / intAfterKomma)
                        intAfterKomma = intAfterKomma * 10
                End Select

            Else
                Select Case strTerm.Substring(i, 1)
                    Case "+", "*", "-", "/", ","
                        strOperator = strTerm.Substring(i, 1)

                End Select
            End If
        Next

        objUserControl_Attribute_Real.Value = dblValue
    End Sub
End Class
