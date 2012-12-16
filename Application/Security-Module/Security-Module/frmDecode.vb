Public Class frmDecode

    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Dispose()
    End Sub

    Public Sub New(ByVal strPassword_Decode As String)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        TextBox_Password_Decoded.Text = strPassword_Decode
        strPassword_Decode = Nothing
    End Sub

    Private Sub frmDecode_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        TextBox_Password_Decoded.Text = ""

    End Sub
End Class