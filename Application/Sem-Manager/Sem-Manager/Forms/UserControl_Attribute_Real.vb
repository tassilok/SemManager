﻿Public Class UserControl_Attribute_Real
    Private dblValue As Double
    Private boolOK As Boolean
    Private strTerm As String

    Public Event Term_No()
    Public Event Term_Do()

    Public ReadOnly Property Term As String
        Get
            Return strTerm
        End Get
    End Property

    Public ReadOnly Property OK As Boolean
        Get
            Return boolOK
        End Get
    End Property

    Public Property Value() As Double
        Get
            If Not TextBox_Value.Text = "" Then
                Return dblValue
            Else
                Return Nothing
            End If

        End Get
        Set(ByVal value As Double)
            dblValue = value
            TextBox_Value.Text = value
        End Set
    End Property
    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        TextBox_Value.Select()
    End Sub

    Private Sub TextBox_Value_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Value.TextChanged
        Dim dblValue_tmp As Double

        RaiseEvent Term_No()

        If Double.TryParse(TextBox_Value.Text, dblValue_tmp) = True Then
            dblValue = dblValue_tmp
            boolOK = True
        Else
            boolOK = False
            dblValue = 0
            If parseTerm() = True Then
                strTerm = TextBox_Value.Text
                RaiseEvent Term_Do()
            End If
        End If
    End Sub

    Private Function parseTerm() As Boolean
        Dim strTermParse As String
        Dim i As Integer
        Dim intNumber As Integer
        Dim boolResult As Boolean

        strTermParse = TextBox_Value.Text

        boolResult = True
        For i = 0 To strTermParse.Length - 1
            If Not Integer.TryParse(strTermParse.Substring(i, 1), intNumber) Then
                If Not strTermParse.Substring(i, 1) = "+" And
                    Not strTermParse.Substring(i, 1) = "*" And
                    Not strTermParse.Substring(i, 1) = "-" And
                    Not strTermParse.Substring(i, 1) = "," And
                    Not strTermParse.Substring(i, 1) = " " Then

                    boolResult = False
                    Exit For

                End If
            End If
        Next

        Return boolResult
    End Function

End Class
