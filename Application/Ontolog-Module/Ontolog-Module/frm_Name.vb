Public Class frm_Name

    Private objLocalConfig As clsLocalConfig
    Private strCaption As String
    Private strGUID As String
    Private strValue1 As String
    Private strValue2 As String
    Private boolSecure As Boolean
    Private boolGUID As Boolean
    Private boolIsListPossible As Boolean
    Private boolAdditional As Boolean
    Private boolList As Boolean
    Private boolShowRepeat As Boolean
    Private strValues() As String
    Private boolEmptyAllowed As Boolean

    Private objOItem_Result As clsOntologyItem

    Public ReadOnly Property isList
        Get
            Return boolList
        End Get
    End Property

    Public ReadOnly Property More
        Get
            Return CheckBox_Additional.Checked
        End Get
    End Property

    Public ReadOnly Property Values As String()
        Get
            Return strValues
        End Get
    End Property

    Public ReadOnly Property OItem_Result As clsOntologyItem
        Get
            Return objOItem_Result
        End Get
    End Property

    Public ReadOnly Property ItemCount As Integer
        Get
            Return NumericUpDown_Additional.Value
        End Get
    End Property
    Public ReadOnly Property List As Boolean
        Get
            Return boolList
        End Get
    End Property
    Public ReadOnly Property Value1 As String
        Get
            Return strValue1
        End Get
    End Property

    Public ReadOnly Property Value2 As String
        Get
            Return strValue2
        End Get
    End Property

    

    Public Sub New(ByVal Caption As String, _
                   ByVal Globals As clsGlobals, _
                   Optional ByVal strGUID As String = Nothing, _
                   Optional ByVal Value1 As String = Nothing, _
                   Optional ByVal Value2 As String = Nothing, _
                   Optional ByVal editGUID As Boolean = False, _
                   Optional ByVal isListPossible As Boolean = False, _
                   Optional ByVal isSecured As Boolean = False, _
                   Optional ByVal showRepeat As Boolean = False, _
                   Optional ByVal has_Additional As Boolean = False, _
                   Optional ByVal emptyAllowed As Boolean = True)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strCaption = Caption
        objLocalConfig = New clsLocalConfig(Globals)
        strValue1 = Value1
        strValue2 = Value2
        boolSecure = isSecured
        boolAdditional = has_Additional
        Me.strGUID = strGUID

        boolGUID = editGUID
        boolShowRepeat = showRepeat
        boolEmptyAllowed = emptyAllowed

        Me.Text = strCaption

        boolIsListPossible = isListPossible

        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal Caption As String, _
                   ByVal LocalConfig As clsLocalConfig, _
                   Optional ByVal strGUID As String = Nothing, _
                   Optional ByVal Value1 As String = Nothing, _
                   Optional ByVal Value2 As String = Nothing, _
                   Optional ByVal editGUID As Boolean = False, _
                   Optional ByVal isListPossible As Boolean = False, _
                   Optional ByVal isSecured As Boolean = False, _
                   Optional ByVal showRepeat As Boolean = False, _
                   Optional ByVal has_Additional As Boolean = False, _
                   Optional ByVal emptyAllowed As Boolean = True)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strCaption = Caption
        objLocalConfig = LocalConfig
        strValue1 = Value1
        strValue2 = Value2
        boolSecure = isSecured
        boolAdditional = has_Additional
        Me.strGUID = strGUID

        boolGUID = editGUID
        boolShowRepeat = showRepeat
        boolEmptyAllowed = emptyAllowed

        Me.Text = strCaption

        boolIsListPossible = isListPossible

        set_DBConnection()
        initialize()
    End Sub

    Private Sub set_DBConnection()

    End Sub

    Private Sub initialize()
        If boolIsListPossible = False Then
            ToolStripMenuItem_List.Enabled = False
        End If

        If boolSecure = True Then
            TextBox_Name.UseSystemPasswordChar = True
            TextBox_Repeat.UseSystemPasswordChar = True
            If boolShowRepeat = True Then
                TextBox_Repeat.Visible = True
                Label_Repeat.Visible = True
                Me.Height = Me.Height + TextBox_Repeat.Height + 5
            End If
            
        End If

        If boolGUID = True Then
            Button_NewGUID.Enabled = True
        Else
            Button_NewGUID.Enabled = False
        End If

        If boolAdditional = True Then
            NumericUpDown_Additional.Visible = True
        Else
            NumericUpDown_Additional.Visible = False
        End If

        TextBox_GUID.Text = strGUID
        TextBox_Name.ReadOnly = True

        TextBox_Name.Text = strValue1

        TextBox_Name.ReadOnly = False

        Me.DialogResult = Windows.Forms.DialogResult.None
    End Sub

    Private Sub TextBox_Name_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Name.TextChanged
        If TextBox_Name.ReadOnly = False Then
            strValue1 = TextBox_Name.Text
        End If
    End Sub

    Private Sub ToolStripMenuItem_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_List.Click
        If TextBox_Name.Multiline = False Then
            Me.Height = Me.Height + 100
            TextBox_Name.Multiline = True
            TextBox_Name.Height = TextBox_Name.Height + 100
            TextBox_Name.ScrollBars = ScrollBars.Vertical
            boolList = True
        Else
            boolList = False
        End If
    End Sub

    Private Sub TextBox_GUID_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox_GUID.MouseDoubleClick
        If TextBox_GUID.ReadOnly = True Then
            If boolGUID = True Then
                TextBox_GUID.ReadOnly = False
            End If
        Else
            TextBox_GUID.ReadOnly = True
        End If
    End Sub

    Private Sub Button_NewGUID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_NewGUID.Click
        TextBox_GUID.Text = Guid.NewGuid.ToString.Replace("-", "")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_OK.Click
        Dim boolClose As Boolean = True
        Dim boolEmpty As Boolean = False
        Dim strValue As String
        
        If boolList = True Then
            strValues = TextBox_Name.Text.Split(vbCrLf)
            For Each strValue In strValues
                If strValue = "" Then
                    boolEmpty = True
                End If
            Next

            
        Else
            If boolSecure = True Then
                If Not TextBox_Name.Text = TextBox_Repeat.Text Then
                    MsgBox("Die Passwörter stimmen nicht überein!", MsgBoxStyle.Exclamation)
                    boolClose = False
                End If
            End If

            If strValue1 = "" Then
                boolEmpty = True
            End If
        End If
        
        If boolClose = True Then
            If boolEmptyAllowed = False Then
                If boolEmpty = True Then
                    MsgBox("Leere Zeichenketten sind nicht erlaubt!", MsgBoxStyle.Exclamation)
                    boolClose = False
                End If
            End If
            If boolClose = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
            
        End If

    End Sub
End Class