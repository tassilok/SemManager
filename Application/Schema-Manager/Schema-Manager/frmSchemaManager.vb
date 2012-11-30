Imports Sem_Manager
Public Class frmSchemaManager

    Private WithEvents objUserControl_DBView As UserControl_DBView
    Private WithEvents objUserControl_SchemaView As UserControl_SchemaView

    Private objDBWork As clsDBWork
    Private objFrmSemManager As frmSemManager

    Private boolSemView As Boolean
    Private boolApplyable As Boolean
    Private boolSchemaView As Boolean
    Private objDRV_Selected As DataRowView
    Private objSemItem_Server As clsSemItem
    Private objSemItem_SchemaItem As clsSemItem
    Public ReadOnly Property isSchemaItem() As Boolean
        Get
            Return boolSchemaView
        End Get
    End Property

    Public ReadOnly Property isSemView() As Boolean
        Get
            Return boolSemView
        End Get
    End Property

    Public ReadOnly Property DRV_Selected() As DataRowView
        Get
            Return objDRV_Selected
        End Get
        
    End Property

    Public ReadOnly Property SemItem_SchemaItem() As clsSemItem
        Get
            Return objSemItem_SchemaItem
        End Get
    End Property

    Public ReadOnly Property Server() As clsSemItem
        Get
            Return objSemItem_Server
        End Get
    End Property

    Public Sub active_DBView()
        TabControl1.SelectedTab = TabPage_DBView
    End Sub

    Public Property isApplyable() As Boolean
        Get
            Return boolApplyable
        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
            objUserControl_DBView.Applyable = value
            objUserControl_SchemaView.Applyable = value
        End Set
    End Property

    Private Sub selected_Item_DBView(ByVal isSemView As Boolean) Handles objUserControl_DBView.selected_Item
        boolSemView = isSemView
        boolSchemaView = False
        objDRV_Selected = objUserControl_DBView.DRV_Selected
        objSemItem_Server = objUserControl_DBView.Server
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub selected_Item_SchemaView() Handles objUserControl_SchemaView.Selected_Item
        boolSchemaView = True
        objSemItem_SchemaItem = objUserControl_SchemaView.SemItem_Selected
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub
    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)

        objUserControl_DBView = New UserControl_DBView
        objUserControl_DBView.Dock = DockStyle.Fill
        TabPage_DBView.Controls.Add(objUserControl_DBView)

        objUserControl_SchemaView = New UserControl_SchemaView
        objUserControl_SchemaView.Dock = DockStyle.Fill
        TabPage_SchemaView.Controls.Add(objUserControl_SchemaView)

        objDBWork = New clsDBWork
        select_TabPage()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)

        objUserControl_DBView = New UserControl_DBView
        objUserControl_DBView.Dock = DockStyle.Fill
        TabPage_DBView.Controls.Add(objUserControl_DBView)

        objUserControl_SchemaView = New UserControl_SchemaView
        objUserControl_SchemaView.Dock = DockStyle.Fill
        TabPage_SchemaView.Controls.Add(objUserControl_SchemaView)

        select_TabPage()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        select_TabPage()
    End Sub

    Private Sub select_TabPage()
        Select Case TabControl1.SelectedTab.Name
            Case TabPage_DBView.Name
                objUserControl_DBView.initialize()
            Case TabPage_SchemaView.Name
                objUserControl_SchemaView.initialize()
        End Select
    End Sub

    Private Sub frmSchemaManager_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim boolUser As Boolean = False
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_User As New clsSemItem

        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_type_User, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)
        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    Try
                        If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_type_User.GUID Then
                            objSemItem_User.GUID = objDRV_Selected.Item("GUID_Token")
                            objSemItem_User.Name = objDRV_Selected.Item("Name_Token")
                            objSemItem_User.GUID_Parent = objLocalConfig.SemItem_type_User.GUID
                            objSemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objLocalConfig.User = objSemItem_User
                            boolUser = True
                        Else
                            boolUser = False
                        End If
                    Catch ex As Exception
                        boolUser = False
                    End Try
                Else
                    boolUser = False
                End If
            Else
                boolUser = False
            End If
        Else
            boolUser = False
        End If
        If boolUser = False Then
            Application.Exit()
        End If
    End Sub
End Class
