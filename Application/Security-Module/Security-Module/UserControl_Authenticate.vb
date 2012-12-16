Imports Sem_Manager
Public Class UserControl_Authenticate

    <FlagsAttribute()> _
    Public Enum ERelateMode As Integer
        NoRelate = 1
        User_To_Group = 2
        Group_To_User = 3
    End Enum


    Private WithEvents objUserControl_SemItemList_User As New UserControl_SemItemList
    Private WithEvents objUserControl_SemItemList_Group As New UserControl_SemItemList

    Private objSemItem_User As clsSemItem
    Private objSemItem_Group As clsSemItem

    Private objLocalConfig As clsLocalConfig

    Private intRelateMode As ERelateMode

    Public Event applied(ByVal SemItem_User As clsSemItem, ByVal SemItem_Group As clsSemItem)


    Public Sub New(ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        initialize()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()

        objUserControl_SemItemList_Group.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_SemItemList_User.Dock = Windows.Forms.DockStyle.Fill

        SplitContainer_UserGroup.Panel1.Controls.Add(objUserControl_SemItemList_User)
        SplitContainer_UserGroup.Panel2.Controls.Add(objUserControl_SemItemList_Group)

    End Sub

    Public Sub initialize_Authentication(ByVal boolUser As Boolean, Optional ByVal boolGroup As Boolean = False, Optional ByVal RelateMode As ERelateMode = ERelateMode.NoRelate)
        Dim objSemItem_Type_Group As clsSemItem
        Dim objSemItem_Type_User As clsSemItem

        intRelateMode = RelateMode

        objSemItem_Type_Group = objLocalConfig.SemItem_Type_Group
        objSemItem_Type_User = objLocalConfig.SemItem_type_User

        objUserControl_SemItemList_Group.clear_List()
        objUserControl_SemItemList_User.clear_List()

        If boolGroup = True Then
            SplitContainer_UserGroup.Panel2Collapsed = False
        Else
            SplitContainer_UserGroup.Panel2Collapsed = True
        End If

        If boolUser = True Then
            SplitContainer_UserGroup.Panel1Collapsed = False
        Else
            SplitContainer_UserGroup.Panel1Collapsed = True
        End If

        Select Case intRelateMode
            Case ERelateMode.NoRelate
                If SplitContainer_UserGroup.Panel1Collapsed = False Then
                    objUserControl_SemItemList_User.initialize_Simple(objSemItem_Type_User, objLocalConfig.Globals)
                End If

                If SplitContainer_UserGroup.Panel2Collapsed = False Then
                    objUserControl_SemItemList_Group.initialize_Simple(objSemItem_Type_Group, objLocalConfig.Globals)
                End If
            Case ERelateMode.User_To_Group
                objUserControl_SemItemList_User.initialize_Simple(objSemItem_Type_User, objLocalConfig.Globals)
            Case ERelateMode.Group_To_User
                objUserControl_SemItemList_Group.initialize_Simple(objSemItem_Type_Group, objLocalConfig.Globals)
        End Select

    End Sub

    Private Sub select_User() Handles objUserControl_SemItemList_User.Selection_Changed
        Dim objSemItem_User As New clsSemItem
        Dim objDGVR_Select As DataGridViewRow
        Dim objDRV_Select As DataRowView

        If intRelateMode = ERelateMode.User_To_Group Then
            objUserControl_SemItemList_Group.clear_List()
            If objUserControl_SemItemList_User.DataGridViewRowCollection_Selected.Count = 1 Then
                objDGVR_Select = objUserControl_SemItemList_User.DataGridViewRowCollection_Selected(0)
                objDRV_Select = objDGVR_Select.DataBoundItem

                objSemItem_User.GUID = objDRV_Select.Item(objUserControl_SemItemList_User.RowName_GUID)
                objSemItem_User.Name = objDRV_Select.Item(objUserControl_SemItemList_User.RowName_Name)
                objSemItem_User.GUID_Parent = objLocalConfig.SemItem_type_User.GUID
                objSemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_User.GUID_Related = objLocalConfig.SemItem_Type_Group.GUID
                objSemItem_User.Direction = objSemItem_User.Direction_RightLeft
                objSemItem_User.GUID_Relation = objLocalConfig.SemItem_RelationType_contains.GUID

                objUserControl_SemItemList_Group.initialize_Complex(objSemItem_User, objLocalConfig.Globals)
            End If

        End If
        configure_Apply()
    End Sub

    Private Sub select_Group() Handles objUserControl_SemItemList_Group.Selection_Changed
        Dim objSemItem_Group As New clsSemItem
        Dim objDGVR_Select As DataGridViewRow
        Dim objDRV_Select As DataRowView

        If intRelateMode = ERelateMode.Group_To_User Then
            objUserControl_SemItemList_User.clear_List()
            If objUserControl_SemItemList_Group.DataGridViewRowCollection_Selected.Count = 1 Then
                objDGVR_Select = objUserControl_SemItemList_Group.DataGridViewRowCollection_Selected(0)
                objDRV_Select = objDGVR_Select.DataBoundItem

                objSemItem_Group.GUID = objDRV_Select.Item(objUserControl_SemItemList_Group.RowName_GUID)
                objSemItem_Group.Name = objDRV_Select.Item(objUserControl_SemItemList_Group.RowName_Name)
                objSemItem_Group.GUID_Parent = objLocalConfig.SemItem_Type_Group.GUID
                objSemItem_Group.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Group.GUID_Related = objLocalConfig.SemItem_type_User.GUID
                objSemItem_Group.Direction = objSemItem_Group.Direction_LeftRight
                objSemItem_Group.GUID_Relation = objLocalConfig.SemItem_RelationType_contains.GUID

                objUserControl_SemItemList_User.initialize_Complex(objSemItem_Group, objLocalConfig.Globals)
            End If

        End If
        configure_Apply()
    End Sub

    Private Sub configure_Apply()
        Dim boolEnable As Boolean
        boolEnable = True
        If SplitContainer_UserGroup.Panel1Collapsed = False Then
            If objUserControl_SemItemList_User.DataGridViewRowCollection_Selected.Count <> 1 Then
                boolEnable = False
            End If
        End If

        If SplitContainer_UserGroup.Panel2Collapsed = False Then
            If objUserControl_SemItemList_Group.DataGridViewRowCollection_Selected.Count <> 1 Then
                boolEnable = False
            End If
        End If


        ToolStripButton_Apply.Enabled = boolEnable
        
    End Sub


    Private Sub set_DBConnection()

    End Sub

    Private Sub ToolStripButton_Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Apply.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        If SplitContainer_UserGroup.Panel1Collapsed = False Then
            If objUserControl_SemItemList_User.DataGridViewRowCollection_Selected.Count = 1 Then
                objDGVR_Selected = objUserControl_SemItemList_User.DataGridViewRowCollection_Selected(0)
                objDRV_Selected = objDGVR_Selected.DataBoundItem

                objSemItem_User = New clsSemItem

                If intRelateMode = ERelateMode.NoRelate Or intRelateMode = ERelateMode.User_To_Group Then
                    objSemItem_User = New clsSemItem
                    objSemItem_User.GUID = objDRV_Selected.Item("GUID_Token")
                    objSemItem_User.Name = objDRV_Selected.Item("Name_Token")
                    objSemItem_User.GUID_Parent = objLocalConfig.SemItem_type_User.GUID
                    objSemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Else
                    objSemItem_User = New clsSemItem
                    objSemItem_User.GUID = objDRV_Selected.Item("GUID_Token_Right")
                    objSemItem_User.Name = objDRV_Selected.Item("Name_Token_Right")
                    objSemItem_User.GUID_Parent = objLocalConfig.SemItem_type_User.GUID
                    objSemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                End If
            End If
        End If

        If SplitContainer_UserGroup.Panel2Collapsed = False Then
            If objUserControl_SemItemList_Group.DataGridViewRowCollection_Selected.Count = 1 Then
                objDGVR_Selected = objUserControl_SemItemList_Group.DataGridViewRowCollection_Selected(0)
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                If intRelateMode = ERelateMode.NoRelate Or intRelateMode = ERelateMode.Group_To_User Then
                    objSemItem_Group = New clsSemItem
                    objSemItem_Group.GUID = objDRV_Selected.Item("GUID_Token")
                    objSemItem_Group.Name = objDRV_Selected.Item("Name_Token")
                    objSemItem_Group.GUID_Parent = objLocalConfig.SemItem_Type_Group.GUID
                    objSemItem_Group.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Else
                    objSemItem_Group = New clsSemItem
                    objSemItem_Group.GUID = objDRV_Selected.Item("GUID_Token_Left")
                    objSemItem_Group.Name = objDRV_Selected.Item("Name_Token_Left")
                    objSemItem_Group.GUID_Parent = objLocalConfig.SemItem_Type_Group.GUID
                    objSemItem_Group.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                End If

            End If
        End If

        RaiseEvent applied(objSemItem_User, objSemItem_Group)
    End Sub
End Class
