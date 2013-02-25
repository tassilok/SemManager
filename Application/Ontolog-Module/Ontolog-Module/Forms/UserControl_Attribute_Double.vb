Imports System.Text.RegularExpressions
Public Class UserControl_Attribute_Double
    Private dblValue As Double

    Public Event doTerm()

    Public ReadOnly Property Test_Value As Boolean
        Get
            Return Double.TryParse(TextBox_Value.Text, dblValue)
        End Get
    End Property

    Public Property Value As Double
        Get
            Double.TryParse(TextBox_Value.Text, dblValue)

            Return dblValue
        End Get
        Set(ByVal value As Double)
            TextBox_Value.Text = value
        End Set
    End Property

    Private Sub TextBox_Value_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Value.TextChanged
        Dim objMatchCollection_Parts As MatchCollection
        Dim objMatchCollection_Math As MatchCollection
        Dim objMatchCollection_Number As MatchCollection
        Dim objMatch As Match
        Dim objRegEx_Part As Regex
        Dim objRegEx_Math As Regex
        Dim objRegEx_Number As Regex
        Dim iIx As Integer

        iIx = 0
        objRegEx_Part = New Regex("(.*\)")
        objMatchCollection_Parts = objRegEx_Part.Matches(TextBox_Value.Text)

        objRegEx_Math = New Regex("[+-*/]")
        objMatchCollection_Math = objRegEx_Math.Matches(TextBox_Value.Text)

        objRegEx_Number = New Regex("^-*[0-9,\.]+$")
        objMatchCollection_Number = objRegEx_Number.Matches(TextBox_Value.Text)


    End Sub
End Class
