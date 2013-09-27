Imports System.Windows.Forms

Public Class dlgAttribute_Varchar255

    Private WithEvents objUserControl_Varchar255 As UserControl_Attribute_VARCHAR255
    Private objUserControl_VARCHARMAX As UserControl_Attribute_VarcharMax

    Private objConnection As SqlClient.SqlConnection
    Private objFrmSemManager As frmSemManager

    Private objSemItem_Result As clsSemItem

    Dim strCaption As String
    Dim strValue1 As String
    Dim strValue2 As String
    Dim strValues() As String
    Dim objGlobals As clsGlobals
    Dim boolGUID As Boolean
    Dim boolList As Boolean

    Private Sub change_Length(ByVal intLength As Integer) Handles objUserControl_Varchar255.change_Length
        ToolStripStatusLabel_Length.Text = intLength
    End Sub

    Public ReadOnly Property isList As Boolean
        Get
            Return boolList
        End Get
    End Property
    Public ReadOnly Property SemItem_Result As clsSemItem
        Get
            Return objSemItem_Result
        End Get
    End Property
    Public Property secure_Val1 As Boolean
        Get
            Return objUserControl_Varchar255.Secure_Value1
        End Get
        Set(ByVal value As Boolean)
            objUserControl_Varchar255.Secure_Value1 = True
            If value = True Then
                ListToolStripMenuItem.Enabled = False
            End If
        End Set
    End Property

    Public Property secure_Val2 As Boolean
        Get
            Return objUserControl_Varchar255.Secure_Value2
        End Get
        Set(ByVal value As Boolean)
            objUserControl_Varchar255.Secure_Value2 = True
            If value = True Then
                ListToolStripMenuItem.Enabled = False
            End If
        End Set
    End Property

    Public Property GUID() As Guid
        Get
            Return objUserControl_Varchar255.GUID
        End Get
        Set(ByVal value As Guid)
            objUserControl_Varchar255.GUID = value
        End Set
    End Property
    Public ReadOnly Property Value1() As String
        Get
            strValue1 = objUserControl_Varchar255.Value1
            Return strValue1
        End Get

    End Property
    Public ReadOnly Property Value2() As String
        Get
            strValue2 = objUserControl_Varchar255.Value2
            Return strValue2
        End Get
    End Property

    Public ReadOnly Property Values() As String()
        Get
            Return strValues
        End Get
    End Property

    Public Property show_ItemCount As Boolean
        Get
            Return NumericUpDown_ItemCount.Visible
        End Get
        Set(ByVal value As Boolean)
            NumericUpDown_ItemCount.Visible = value
        End Set
    End Property

    Public Property show_Additional As Boolean
        Get
            Return CheckBox_more.Visible
        End Get
        Set(ByVal value As Boolean)
            CheckBox_more.Visible = value
        End Set
    End Property

    Public ReadOnly Property ItemCount As Integer
        Get
            Return NumericUpDown_ItemCount.Value
        End Get
    End Property

    Public Property more As Boolean
        Get
            Return CheckBox_more.Checked
        End Get
        Set(ByVal value As Boolean)
            CheckBox_more.Checked = value
        End Set
    End Property
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim boolOK As Boolean = True
        If ListToolStripMenuItem.Checked = False Then
            boolList = False
            If objUserControl_Varchar255.Secure_Value2 = True Then
                If Not objUserControl_Varchar255.Value1 = objUserControl_Varchar255.Value2 Then
                    boolOK = False

                End If
            End If
            If boolOK = True Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MsgBox("Die Passwörter stimmen nicht überein!", MsgBoxStyle.Exclamation)
            End If
        Else
            boolList = True
            If objUserControl_VARCHARMAX.Value = "" Then
                boolOK = False
            Else
                strValues = objUserControl_VARCHARMAX.Value.Split(vbCrLf)

            End If
            If boolOK = True Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub set_DBConnection()

        objConnection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)

        ToolStripStatusLabel_DB.Text = objConnection.Database & "@" & objConnection.DataSource
    End Sub

    Public Sub New(ByVal Caption As String, ByVal Globals As clsGlobals, Optional ByVal Value1 As String = Nothing, Optional ByVal Value2 As String = Nothing, Optional ByVal editGUID As Boolean = Nothing, Optional ByVal isListPossible As Boolean = False)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        strCaption = Caption
        objGlobals = Globals
        strValue1 = Value1
        strValue2 = Value2

        boolGUID = editGUID

        Me.Text = strCaption

        If isListPossible = False Then
            ListToolStripMenuItem.Enabled = False
        End If
        set_DBConnection()
        show_Edit()

    End Sub

    Private Sub SemItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemItemToolStripMenuItem.Click
        Dim objDRV_Selected As DataRowView

        objSemItem_Result = Nothing
        CheckBox_SemItem.Checked = False
        objFrmSemManager = New frmSemManager(objGlobals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)
        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objGlobals.ObjectReferenceType_Type.GUID Then
                If objFrmSemManager.SemItems_Selected.Count = 1 Then
                    objSemItem_Result = objFrmSemManager.SemItems_Selected(0)
                    objUserControl_Varchar255.Value1 = objSemItem_Result.Name
                    CheckBox_SemItem.Checked = True
                Else
                    MsgBox("Bitte nur ein Item auswählen!", MsgBoxStyle.Exclamation)
                End If
            Else
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDRV_Selected = objFrmSemManager.SelectedRows_Items(0).DataBoundItem
                    Select Case objFrmSemManager.SelectedItems_TypeGUID
                        Case objGlobals.ObjectReferenceType_Attribute.GUID
                            objSemItem_Result = New clsSemItem
                            objSemItem_Result.GUID = objDRV_Selected.Item("GUID_Attribute")
                            objSemItem_Result.Name = objDRV_Selected.Item("Name_Attribute")
                            objSemItem_Result.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
                            objUserControl_Varchar255.Value1 = objSemItem_Result.Name
                            CheckBox_SemItem.Checked = True
                        Case objGlobals.ObjectReferenceType_RelationType.GUID
                            objSemItem_Result = New clsSemItem
                            objSemItem_Result.GUID = objDRV_Selected.Item("GUID_RelationType")
                            objSemItem_Result.Name = objDRV_Selected.Item("Name_RelationType")
                            objSemItem_Result.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID
                            objUserControl_Varchar255.Value1 = objSemItem_Result.Name
                            CheckBox_SemItem.Checked = True
                        Case objGlobals.ObjectReferenceType_Token.GUID
                            objSemItem_Result = New clsSemItem
                            objSemItem_Result.GUID = objDRV_Selected.Item("GUID_Token")
                            objSemItem_Result.Name = objDRV_Selected.Item("Name_Token")
                            objSemItem_Result.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                            objSemItem_Result.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID
                            objUserControl_Varchar255.Value1 = objSemItem_Result.Name
                            CheckBox_SemItem.Checked = True
                    End Select
                    objSemItem_Result = New clsSemItem

                Else
                    MsgBox("Bitte nur ein Item auswählen!", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub ListToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem.CheckStateChanged
        show_Edit()
    End Sub

    Private Sub show_Edit()
        Panel_Data.Controls.Clear()
        If ListToolStripMenuItem.Checked = True Then
            objUserControl_VARCHARMAX = New UserControl_Attribute_VarcharMax
            If Not strValue1 Is Nothing Then
                objUserControl_VARCHARMAX.Value = strValue1
            End If

            objUserControl_VARCHARMAX.Dock = DockStyle.Fill
            Panel_Data.Controls.Add(objUserControl_VARCHARMAX)
        Else
            objUserControl_Varchar255 = New UserControl_Attribute_VARCHAR255(boolGUID)
            If Not strValue1 Is Nothing Then
                objUserControl_Varchar255.Value1 = strValue1
            End If
            If Not strValue2 Is Nothing Then
                objUserControl_Varchar255.Value2 = strValue2
            End If

            objUserControl_Varchar255.Dock = DockStyle.Fill
            Panel_Data.Controls.Add(objUserControl_Varchar255)
        End If
    End Sub

    
End Class
