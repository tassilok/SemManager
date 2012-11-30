Public Class UserControl_Attribute_VARCHAR255

    Private boolSecure_Val1 As Boolean
    Private boolSecure_Val2 As Boolean
    Private boolEditGUID As Boolean

    Public Event change_Length(ByVal intLength As Integer)

    Public Property Secure_Value1() As Boolean
        Get
            Return boolSecure_Val1
        End Get
        Set(ByVal value As Boolean)
            boolSecure_Val1 = value
            If boolSecure_Val1 = True Then
                TextBox_Value1.PasswordChar = "*"
            Else
                TextBox_Value1.PasswordChar = Nothing
            End If
        End Set
    End Property

    Public Property Secure_Value2() As Boolean
        Get
            Return boolSecure_Val2
        End Get
        Set(ByVal value As Boolean)
            boolSecure_Val2 = value
            If boolSecure_Val2 = True Then
                TextBox_Value2.PasswordChar = "*"
                TextBox_Value2.Enabled = True
            Else
                TextBox_Value2.PasswordChar = Nothing
                TextBox_Value2.Enabled = False
            End If
        End Set
    End Property
    Public Property GUID() As Guid
        Get
            Dim GUID_ As Guid
            If Not TextBox_GUID.Text = "" Then
                Try
                    GUID_ = New Guid(TextBox_GUID.Text)
                Catch ex As Exception
                    GUID_ = Nothing
                End Try
                Return GUID_
            Else
                Return Nothing
            End If

        End Get
        Set(ByVal value As Guid)
            TextBox_GUID.Text = value.ToString
        End Set
    End Property

    Public Property Value1() As String
        Get
            Return TextBox_Value1.Text
        End Get
        Set(ByVal value As String)
            TextBox_Value1.Text = value
            TextBox_Value1.SelectAll()
        End Set
    End Property
    Public Property Value2() As String
        Get
            Return TextBox_Value2.Text
        End Get
        Set(ByVal value As String)
            TextBox_Value2.Text = value
            TextBox_Value2.SelectAll()
        End Set
    End Property

    Private Sub Button_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_New.Click
        TextBox_GUID.Text = Guid.NewGuid.ToString
    End Sub

    Public Sub New(Optional ByVal editGUID As Boolean = False)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()
        boolEditGUID = editGUID
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        TextBox_Value1.Select()
    End Sub

    Private Sub TextBox_GUID_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_GUID.DoubleClick
        If boolEditGUID = True Then
            If TextBox_GUID.ReadOnly = True Then
                TextBox_GUID.ReadOnly = False
            Else
                TextBox_GUID.ReadOnly = True
                TextBox_GUID.Clear()
            End If
        End If
        
    End Sub

    Private Sub TextBox_Value1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Value1.TextChanged
        RaiseEvent change_Length(TextBox_Value1.Text.Length)
    End Sub
End Class
