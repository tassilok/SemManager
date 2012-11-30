Public Class frmDateTimePicker

    Public Property Date_Selected_Start As Date
        Get
            Return MonthCalendar_Date.SelectionRange.Start
        End Get
        Set(ByVal value As Date)
            MonthCalendar_Date.SetDate(value)
        End Set
    End Property

    Public Property Date_Selected_End As Date
        Get
            Return MonthCalendar_Date.SelectionRange.End
        End Get
        Set(ByVal value As Date)
            MonthCalendar_Date.SetDate(value)
        End Set
    End Property

    Private Sub ToolStripButton_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_OK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub ToolStripButton_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Hide()
    End Sub
End Class