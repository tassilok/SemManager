Imports System.Windows.Forms

Public Class dlgAttribute_Datetime
    Private strCaption As String
    Private dateValue As Date
    Private boolDate As Boolean
    Private objGlobals As clsGlobals

    Private objUserControl_Attribute_Datetime As UserControl_Attribute_Datetime

    Public ReadOnly Property Value() As Date
        Get
            Return objUserControl_Attribute_Datetime.Value
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


    Public Sub New(ByVal Caption As String, ByVal Globals As clsGlobals, Optional ByVal Value As Date = Nothing, Optional ByVal isDate As Boolean = Nothing)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        strCaption = Caption
        objGlobals = Globals
        dateValue = Value
        boolDate = isDate

        objUserControl_Attribute_Datetime = New UserControl_Attribute_Datetime(boolDate)
        Me.Text = strCaption

        If Not Value = Nothing Then
            objUserControl_Attribute_Datetime.Value = dateValue

        End If
        
        objUserControl_Attribute_Datetime.Dock = DockStyle.Fill
        Panel1.Controls.Add(objUserControl_Attribute_Datetime)
    End Sub


End Class
