Imports Sem_Manager
Public Class frmGet_User_And_Group

    Private objLocalConfig As clsLocalConfig
    Private WithEvents objUserControl_User As New UserControl_SemItemList
    Private WithEvents objUserControl_Group As New UserControl_SemItemList

    Private objSemItem_User As clsSemItem
    Private objSemItem_Group As clsSemItem

    Private boolUser As Boolean
    Private boolGroup As Boolean

    Public ReadOnly Property SemItem_User
        Get
            Return objSemItem_User
        End Get

    End Property

    Public ReadOnly Property SemItem_Group
        Get
            Return objSemItem_Group
        End Get
    End Property

    Public Sub selection_Changed_User() Handles objUserControl_User.Selection_Changed
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        ToolStripButton_Apply.Enabled = False
        boolUser = False
        If objUserControl_User.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_User.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_User = New clsSemItem
            objSemItem_User.GUID = objDRV_Selected.Item("GUID_Token")
            objSemItem_User.Name = objDRV_Selected.Item("Name_Token")
            objSemItem_User.GUID_Parent = objLocalConfig.SemItem_type_User.GUID
            objSemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_User.Direction = objSemItem_User.Direction_RightLeft
            objSemItem_User.GUID_Relation = objLocalConfig.SemItem_RelationType_contains.GUID
            objSemItem_User.GUID_Related = objLocalConfig.SemItem_Type_Group.GUID
            boolUser = True
            objUserControl_Group.initialize_Complex(objSemItem_User, objLocalConfig.Globals)

        End If
    End Sub

    Public Sub selection_Changed_Group() Handles objUserControl_Group.Selection_Changed
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        ToolStripButton_Apply.Enabled = False
        boolGroup = False
        If objUserControl_Group.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_Group.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_Group = New clsSemItem
            objSemItem_Group.GUID = objDRV_Selected.Item("GUID_Token_Left")
            objSemItem_Group.Name = objDRV_Selected.Item("Name_Token_Left")
            objSemItem_Group.GUID_Parent = objLocalConfig.SemItem_Type_Group.GUID
            objSemItem_Group.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            boolGroup = True


        End If
        If boolUser = True And boolGroup = True Then
            ToolStripButton_Apply.Enabled = True

        End If
    End Sub
    Private Sub ToolStripButton_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Cancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Hide()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Private Sub initialize()
        objUserControl_User.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Add(objUserControl_User)
        objUserControl_Group.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(objUserControl_Group)
        objUserControl_User.initialize_Simple(objLocalConfig.SemItem_type_User, objLocalConfig.Globals)

    End Sub

    Private Sub ToolStripButton_Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Apply.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub
End Class