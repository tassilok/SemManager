Public Class UserControl_Attribute_VarcharMax
    Const cint_Raw As Integer = 1
    Const cint_RTF As Integer = 2

    Private intType As Integer
    Private strText As String

    Public Property Value() As String
        Get
            
            Select Case intType
                Case cint_Raw
                    Return TextBox_Value.Text
                Case cint_RTF
                    Return RichTextBox_Value.Rtf
                Case Else
                    Return Nothing
            End Select

        End Get
        Set(ByVal value As String)
            Select Case intType
                Case cint_Raw
                    TextBox_Value.Text = value
                Case cint_RTF
                    RichTextBox_Value.Rtf = value
            End Select

        End Set
    End Property

    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        intType = cint_Raw
        TextBox_Value.Select()
    End Sub

    Private Sub TextBox_Value_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.A
                If e.Control = True Then
                    TextBox_Value.SelectionStart = 0
                    TextBox_Value.SelectionLength = TextBox_Value.Text.Length
                End If
        End Select
    End Sub

    Private Sub configure_Tabs()
        Select Case TabControl1.SelectedTab.Name
            Case TabPage_Text.Name
                TextBox_Value.Text = strText
                intType = cint_Raw
            Case TabPage_RTF.Name
                RichTextBox_Value.Rtf = strText
                intType = cint_RTF
        End Select
    End Sub

    Private Sub TextBox_Value_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Value.TextChanged
        strText = TextBox_Value.Text
    End Sub

    Private Sub RichTextBox_Value_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox_Value.TextChanged
        strText = TextBox_Value.Text
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        configure_Tabs()
    End Sub
End Class
