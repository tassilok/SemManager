Public Class UserControl_Attribute_DateTime
    Private dateValue As DateTime

    Public Property Value As DateTime
        Get
            Date.TryParse(DateTimePicker_Value.Value.Date.ToString("dd.MM.yyyy") & " " & _
                NumericUpDown_Hour.Value.ToString("00") & ":" & _
                NumericUpDown_Minute.Value.ToString("00") & ":" & _
                NumericUpDown_Second.Value.ToString("00") & "." & _
                NumericUpDown_Millisecond.Value.ToString("000"), dateValue)
            Return dateValue
        End Get
        Set(ByVal value As DateTime)
            dateValue = value
            DateTimePicker_Value.Value = dateValue.Date
            NumericUpDown_Hour.Value = dateValue.Hour
            NumericUpDown_Minute.Value = dateValue.Minute
            NumericUpDown_Second.Value = dateValue.Second
            NumericUpDown_Millisecond.Value = dateValue.Millisecond
        End Set
    End Property
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub
End Class
