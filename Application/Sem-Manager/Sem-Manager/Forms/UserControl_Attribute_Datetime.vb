Public Class UserControl_Attribute_Datetime
    Private objDate As Date
    Private objTime As Date
    Private boolDate As Boolean


    Public Property Value() As Date
        Get
            objDate = Date.Parse(NumericUpDown_Day.Value & "." & NumericUpDown_Month.Value & "." & NumericUpDown_Year.Value & " " & NumericUpDown_Hour.Value & ":" & NumericUpDown_Minute.Value & ":" & NumericUpDown_Second.Value)

            Return objDate

        End Get
        Set(ByVal value As Date)
            objDate = value
            If boolDate = Nothing Then
                NumericUpDown_Day.Value = objDate.Day
                NumericUpDown_Month.Value = objDate.Month
                NumericUpDown_Year.Value = objDate.Year

                NumericUpDown_Hour.Value = objDate.Hour
                NumericUpDown_Minute.Value = objDate.Minute
                NumericUpDown_Second.Value = objDate.Second
            Else
                If boolDate = True Then
                    NumericUpDown_Day.Value = objDate.Day
                    NumericUpDown_Month.Value = objDate.Month
                    NumericUpDown_Year.Value = objDate.Year
                Else
                    NumericUpDown_Hour.Value = objDate.Hour
                    NumericUpDown_Minute.Value = objDate.Minute
                    NumericUpDown_Second.Value = objDate.Second
                End If
            End If

            
        End Set
    End Property
    Private Sub NumericUpDown_Day_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim intDay As Integer
        intDay = objDate.Month

        If Date.TryParse(NumericUpDown_Day.Value & "." & NumericUpDown_Month.Value & "." & NumericUpDown_Year.Value, objDate) = False Then
            NumericUpDown_Day.Value = intDay
        End If
    End Sub

    Private Sub NumericUpDown_Month_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim intMonth As Integer

        intMonth = objDate.Month
        If Date.TryParse(NumericUpDown_Day.Value & "." & NumericUpDown_Month.Value & "." & NumericUpDown_Year.Value, objDate) = False Then
            NumericUpDown_Month.Value = intMonth
        End If
    End Sub

    Public Sub New(Optional ByVal isDate As Boolean = Nothing)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        boolDate = isDate
        If boolDate = Nothing Then
            NumericUpDown_Day.Select()
            Panel_Date.Enabled = True
            Panel_Time.Enabled = True
        Else
            If boolDate = True Then
                NumericUpDown_Day.Select()
                Panel_Date.Enabled = True
                Panel_Time.Enabled = False
            Else
                NumericUpDown_Hour.Select()
                Panel_Date.Enabled = False
                Panel_Time.Enabled = True
            End If
        End If
        objDate = Today
        objTime = Now

        NumericUpDown_Day.Value = objDate.Day
        NumericUpDown_Month.Value = objDate.Month
        NumericUpDown_Year.Value = objDate.Year

        NumericUpDown_Hour.Value = objTime.Hour
        NumericUpDown_Minute.Value = objTime.Minute
        NumericUpDown_Second.Value = objTime.Second

    End Sub

    Private Sub NumericUpDown_Year_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim intYear As Integer

        intYear = objDate.Year
        If Date.TryParse(NumericUpDown_Day.Value & "." & NumericUpDown_Month.Value & "." & NumericUpDown_Year.Value, objDate) = False Then
            NumericUpDown_Year.Value = intYear
        End If
    End Sub
End Class
