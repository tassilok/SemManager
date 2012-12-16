Imports System.Windows.Forms

Public Class Dialog_DateFilter

    Public ReadOnly Property DateStart As String
        Get
            Return TextBox_Start.Text
        End Get
    End Property

    Public ReadOnly Property DateEnd As String
        Get
            Return TextBox_End.Text
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


    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        TextBox_Start.Text = MonthCalendar_CreationDate.SelectionRange.Start.Date
        TextBox_End.Text = MonthCalendar_CreationDate.SelectionRange.End.Date
        MonthCalendar_CreationDate.SetDate(Now)

    End Sub

    Private Sub MonthCalendar_CreationDate_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar_CreationDate.DateChanged
        If RadioButton_Start.Checked = True Then
            TextBox_Start.Text = e.Start.Date
            If Date.Parse(TextBox_End.Text) < Date.Parse(TextBox_Start.Text) Then
                TextBox_End.Text = TextBox_Start.Text
            End If
        Else
            TextBox_End.Text = e.Start.Date
            If Date.Parse(TextBox_End.Text) < Date.Parse(TextBox_Start.Text) Then
                TextBox_Start.Text = TextBox_End.Text
            End If
        End If
    End Sub
End Class
