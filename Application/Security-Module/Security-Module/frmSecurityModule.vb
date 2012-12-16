Imports Sem_Manager
Public Class frmSecurityModule
    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Type_Passwords_Closed As Integer = 1
    Private Const cint_ImageID_Type_Passwords_Opened As Integer = 2
    Private Const cint_ImageID_Related As Integer = 3
    Private Const cint_ImageID_Type_Related_Closed As Integer = 4
    Private Const cint_ImageID_Type_Related_Open As Integer = 5
    Private Const cint_ImageID_Token As Integer = 6

    Private objFrmAuthenticate As frmAuthenticate

    Private funcA_TypeType As New ds_TypeTableAdapters.typefunc_Types_RelTableAdapter
    Private funcT_TypeType As New ds_Type.typefunc_Types_RelDataTable
    Private procA_Types_To_Encode As New ds_SecurityModuleTableAdapters.proc_Types_To_EncodeTableAdapter
    Private pA_Secured_Items As New ds_SecurityModuleTableAdapters.p_Secured_ItemsTableAdapter
    Private pT_Secured_Items As New ds_SecurityModule.p_Secured_ItemsDataTable
    
    Private objLocalConfig As clsLocalConfig
    Private objFrmSemManager As frmSemManager
    Private objSecurityModuleWork As clsSecurityModuleWork
    Private objDlgAttribute_VARCHAR255 As dlgAttribute_Varchar255
    Private objFrmTokenEdit As frmTokenEdit
    Private objSemWork As clsSemWork

    Private objTransaction_Passwords As clsTransaction_Passwords

    Private objTreeNode_Root As TreeNode
    Private objTreeNode As TreeNode

    Private boolOpen As Boolean
    Private boolApplyable As Boolean

    Public Event applied_Password(ByVal objSemItem_Password As clsSemItem)


    Public Property isApplyable As Boolean
        Get
            Return boolApplyable
        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
            ApplyToolStripMenuItem.Visible = value
            ToolStripButton_Apply.Visible = value
        End Set
    End Property

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        initialize()
    End Sub

    Public Sub New(ByVal objGlobals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(objGlobals)
        initialize()
    End Sub

    Private Sub initialize()
        Dim objSemItem_Result As clsSemItem

        set_DBConnection()
        objSemItem_Result = get_User()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objSecurityModuleWork.initialize_User(objLocalConfig.SemItem_User)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Sie haben das falsche Passwort eingegeben!", MsgBoxStyle.Exclamation)
                boolOpen = False
            Else
                get_Types()
                ToolStripComboBox_Search.Items.Add(objLocalConfig.SemItem_Token_Search_Template_Name_)
                ToolStripComboBox_Search.Items.Add(objLocalConfig.SemItem_Token_Search_Template_Related_Sem_Item_)
                ToolStripComboBox_Search.Items.Add(objLocalConfig.SemItem_Token_Search_Template_Related_Type_)
                ToolStripComboBox_Search.ComboBox.DisplayMember = "Name"
                ToolStripComboBox_Search.ComboBox.ValueMember = "GUID"
                ToolStripComboBox_Search.SelectedItem = objLocalConfig.SemItem_Token_Search_Template_Name_
            End If
        End If
    End Sub

    Private Sub get_Types()
        Dim objDRC_TypesToEncode As DataRowCollection
        Dim objDR_TypesToEncode As DataRow
        Dim objDRC_Encoded As DataRowCollection
        Dim objDR_Encoded As DataRow
        Dim objTreeNode As TreeNode

        TreeView_RelatedItems.Nodes.Clear()

        objTreeNode_Root = TreeView_RelatedItems.Nodes.Add(objLocalConfig.SemItem_Development.GUID.ToString, objLocalConfig.SemItem_Development.Name, cint_ImageID_Root, cint_ImageID_Root)


        objDRC_TypesToEncode = procA_Types_To_Encode.GetData(objLocalConfig.SemItem_Type_Security_Module.GUID, _
                                                             objLocalConfig.SemItem_RelationType_belonging_Endoding_Types.GUID, _
                                                             objLocalConfig.SemItem_BaseConfig.GUID).Rows
        
        For Each objDR_TypesToEncode In objDRC_TypesToEncode
            objTreeNode = objTreeNode_Root.Nodes.Add(objDR_TypesToEncode.Item("GUID_Type").ToString, objDR_TypesToEncode.Item("Name_Type"), cint_ImageID_Type_Passwords_Closed, cint_ImageID_Type_Passwords_Opened)

            
        Next


    End Sub

    Private Sub get_Types_Related()
        Dim objDRC_TypesRelated As DataRowCollection

    End Sub
    Private Function get_User() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_User As clsSemItem

        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        boolOpen = True

        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_type_User, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)

        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_type_User.GUID Then
                        objSemItem_User = New clsSemItem
                        objSemItem_User.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_User.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_User.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                        objSemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objLocalConfig.SemItem_User = objSemItem_User
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        MsgBox("Sie müssen einen User auswählen!", MsgBoxStyle.Exclamation)
                        boolOpen = False
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    MsgBox("Sie müssen einen User auswählen!", MsgBoxStyle.Exclamation)
                    boolOpen = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                MsgBox("Sie müssen einen User auswählen!", MsgBoxStyle.Exclamation)
                boolOpen = False
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            MsgBox("Sie müssen einen User auswählen!", MsgBoxStyle.Exclamation)
            boolOpen = False
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Private Sub frmSecurityModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If boolOpen = False Then
            Me.Dispose()
        End If
    End Sub

    Private Sub set_DBConnection()
        funcA_TypeType.Connection = objLocalConfig.Connection_DB
        objSecurityModuleWork = New clsSecurityModuleWork(objLocalConfig.Globals, Me)
        procA_Types_To_Encode.Connection = objLocalConfig.Connection_Plugin
        objTransaction_Passwords = New clsTransaction_Passwords(objLocalConfig)

        pA_Secured_Items.Connection = objLocalConfig.Connection_Plugin
        objSemWork = New clsSemWork(objLocalConfig.Globals)
    End Sub

    Private Sub TreeView_RelatedItems_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_RelatedItems.AfterSelect

        objTreeNode = TreeView_RelatedItems.SelectedNode
        NewToolStripMenuItem.Enabled = False
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Type_Passwords_Closed
                    NewToolStripMenuItem.Enabled = True
                    fill_Passwords(objTreeNode)
            End Select
            
        End If
        
    End Sub

    Private Sub fill_Passwords(ByVal objTreeNode_Type As TreeNode, Optional ByVal objSemItem_Password As clsSemItem = Nothing)
        pA_Secured_Items.Fill(pT_Secured_Items, _
                              objLocalConfig.SemItem_type_User.GUID, _
                              objLocalConfig.SemItem_User.GUID, _
                              objLocalConfig.SemItem_RelationType_encoded_by.GUID, _
                              New Guid(objTreeNode_Type.Name))

        BindingSource_Passwords.DataSource = pT_Secured_Items
        DataGridView_Passwords.DataSource = BindingSource_Passwords
        If Not objSemItem_Password Is Nothing Then
            BindingSource_Passwords.Filter = "GUID_Password='" & objSemItem_Password.GUID.ToString & "'"
        End If

        DataGridView_Passwords.Columns(0).Visible = False
        DataGridView_Passwords.Columns(1).Visible = False
        DataGridView_Passwords.Columns(2).Visible = False
        DataGridView_Passwords.Columns(3).Visible = False
        DataGridView_Passwords.Columns(4).Visible = False
        DataGridView_Passwords.Columns(5).Visible = False
        DataGridView_Passwords.Columns(7).Visible = False
        DataGridView_Passwords.Columns(9).Visible = False
    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim strPassword_Decoded As String
        Dim strPassword_Encoded As String

        Dim objSemItem_Password As New clsSemItem
        Dim objTreeNode_Selected As TreeNode
        Dim objSemItem_Secured As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        objTreeNode_Selected = TreeView_RelatedItems.SelectedNode
        If Not objTreeNode_Selected Is Nothing Then

            Select Case objTreeNode_Selected.ImageIndex

                Case cint_ImageID_Type_Passwords_Closed
                    objDlgAttribute_VARCHAR255 = New dlgAttribute_Varchar255("New Password", objLocalConfig.Globals)
                    objDlgAttribute_VARCHAR255.secure_Val1 = True
                    objDlgAttribute_VARCHAR255.secure_Val2 = True
                    objDlgAttribute_VARCHAR255.ShowDialog(Me)
                    If objDlgAttribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then
                        strPassword_Decoded = objDlgAttribute_VARCHAR255.Value1
                        strPassword_Encoded = objSecurityModuleWork.encode_Password(strPassword_Decoded)

                        objSemItem_Password.GUID = Guid.NewGuid
                        objSemItem_Password.Name = strPassword_Encoded
                        objSemItem_Password.GUID_Parent = New Guid(objTreeNode_Selected.Name)
                        objSemItem_Password.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_Passwords.save_001_Password(objSemItem_Password)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Passwords.save_002_Password_To_User(objLocalConfig.SemItem_User)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
                                objFrmSemManager.Applyabale = True
                                objFrmSemManager.ShowDialog(Me)
                                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then

                                    If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                        objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                                        funcA_TypeType.Fill_By_GUID_Type_Right(funcT_TypeType, New Guid(objTreeNode_Selected.Name))
                                        If funcT_TypeType.Select("GUID_Type_Left='" & objDRV_Selected.Item("GUID_Type").ToString & "'").Count > 0 Then
                                            objSemItem_Secured.GUID = objDRV_Selected.Item("GUID_Token")
                                            objSemItem_Secured.Name = objDRV_Selected.Item("Name_Token")
                                            objSemItem_Secured.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                                            objSemItem_Secured.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                            objSemItem_Result = objTransaction_Passwords.save_003_Password_To_Secured(objSemItem_Secured)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                fill_Passwords(objTreeNode_Selected, objSemItem_Password)
                                            Else
                                                MsgBox("Das Passwort konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                objTransaction_Passwords.del_001_Password()
                                            End If

                                        Else
                                            MsgBox("Bitte nur ein Token auswählen!", MsgBoxStyle.Exclamation)
                                            objTransaction_Passwords.del_001_Password()
                                        End If
                                    Else
                                        MsgBox("Bitte nur ein Token auswählen!", MsgBoxStyle.Exclamation)
                                        objTransaction_Passwords.del_001_Password()
                                    End If

                                Else
                                    MsgBox("Bitte nur Token auswählen!", MsgBoxStyle.Exclamation)
                                    objTransaction_Passwords.del_001_Password()
                                End If
                            Else

                                MsgBox("Das Passwort kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                objTransaction_Passwords.del_001_Password()

                            End If

                        Else
                            MsgBox("Das Passwort kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If

                    End If
            End Select
        End If
        
    End Sub

    

    

   

    Private Sub ToolStripButton_Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Apply.Click
        apply()
    End Sub

    Private Sub apply()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRow

        Dim objSemItem_Password As New clsSemItem

        If DataGridView_Passwords.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Passwords.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_Password.GUID = objDRV_Selected.Item("GUID_Token_Left")
            objSemItem_Password.Name = objDRV_Selected.Item("Name_Token_Left")
            objSemItem_Password.GUID_Parent = objDRV_Selected.Item("GUID_Type_Left")
            objSemItem_Password.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            RaiseEvent applied_Password(objSemItem_Password)
            DialogResult = Windows.Forms.DialogResult.OK
            Me.Hide()
        End If
    End Sub

    Private Sub DataGridView_Passwords_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub ContextMenuStrip_Passwords_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Passwords.Opening
        ApplyToolStripMenuItem.Enabled = False
        CopyPasswordToolStripMenuItem.Enabled = False
        If DataGridView_Passwords.SelectedRows.Count > 0 Then
            ApplyToolStripMenuItem.Enabled = True
            If DataGridView_Passwords.SelectedRows.Count = 1 Then
                CopyPasswordToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub DataGridView_Passwords_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView_Passwords.KeyDown
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objFrmDecode As frmDecode
        Dim strPassword_Decode As String

        Select Case e.KeyCode
            Case Keys.Space
                If DataGridView_Passwords.SelectedRows.Count = 1 Then
                    objDGVR_Selected = DataGridView_Passwords.SelectedRows(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    strPassword_Decode = objSecurityModuleWork.decode_Password(objDRV_Selected.Item("Name_Password"))
                    objFrmDecode = New frmDecode(strPassword_Decode)
                    objFrmDecode.ShowDialog(Me)
                    strPassword_Decode = Nothing
                Else
                    MsgBox("Bitte nur eine Zeile markieren!", MsgBoxStyle.Exclamation)
                End If
            Case Keys.P
                If e.Control = True Then
                    If DataGridView_Passwords.SelectedRows.Count = 1 Then
                        objDGVR_Selected = DataGridView_Passwords.SelectedRows(0)
                        objDRV_Selected = objDGVR_Selected.DataBoundItem

                        strPassword_Decode = objSecurityModuleWork.decode_Password(objDRV_Selected.Item("Name_Password"))
                        Clipboard.SetDataObject(strPassword_Decode)
                        Timer_Remove.Start()
                        strPassword_Decode = Nothing
                    Else
                        MsgBox("Bitte nur eine Zeile markieren!", MsgBoxStyle.Exclamation)
                    End If
                End If
        End Select

    End Sub

    Private Sub DataGridView_Passwords_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Passwords.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Secured As clsSemItem

        objDGVR_Selected = DataGridView_Passwords.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Secured = New clsSemItem
        objSemItem_Secured.GUID = objDRV_Selected.Item("GUID_Secured")
        objSemItem_Secured.Name = objDRV_Selected.Item("Name_Secured")
        objSemItem_Secured.GUID_Parent = objDRV_Selected.Item("GUID_Type_Secured")
        objSemItem_Secured.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrmTokenEdit = New frmTokenEdit(objSemItem_Secured, objLocalConfig.Globals)
        objFrmTokenEdit.ShowDialog(Me)
    End Sub

    Private Sub DataGridView_Passwords_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Passwords.SelectionChanged
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        ApplyToolStripMenuItem.Enabled = False
        ChangeToolStripMenuItem.Enabled = False
        If DataGridView_Passwords.SelectedRows.Count = 1 Then
            ApplyToolStripMenuItem.Enabled = True
            ToolStripButton_Apply.Enabled = True
            ChangeToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ChangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim strPassword_Decoded As String
        Dim strPassword_Encoded As String
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Password As clsSemItem

        objDGVR_Selected = DataGridView_Passwords.SelectedRows(0)
        objDRV_Selected = objDGVR_Selected.DataBoundItem
        objSemItem_Password = New clsSemItem
        objSemItem_Password.GUID = objDRV_Selected.Item("GUID_Password")
        objSemItem_Password.Name = objDRV_Selected.Item("Name_Password")
        objSemItem_Password.GUID_Parent = objDRV_Selected.Item("GUID_Type_Password")
        objSemItem_Password.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objSemItem_Password.Name = objSecurityModuleWork.decode_Password(objSemItem_Password.Name)

        objDlgAttribute_VARCHAR255 = New dlgAttribute_Varchar255(objSemItem_Password.Name, objLocalConfig.Globals)
        objDlgAttribute_VARCHAR255.secure_Val1 = True
        objDlgAttribute_VARCHAR255.secure_Val2 = True

        objDlgAttribute_VARCHAR255.ShowDialog(Me)
        If objDlgAttribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then
            strPassword_Decoded = objDlgAttribute_VARCHAR255.Value1

            strPassword_Encoded = objSecurityModuleWork.encode_Password(strPassword_Decoded)

            objSemItem_Password.Name = strPassword_Encoded

            objSemItem_Result = objTransaction_Passwords.save_001_Password(objSemItem_Password)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                MsgBox("Das Passwort wurde geändert!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Das Passwort konnte nicht geändert werden!", MsgBoxStyle.Exclamation)
            End If

            fill_Passwords(objTreeNode)
            BindingSource_Passwords.Filter = "GUID_Password='" & objSemItem_Password.GUID.ToString & "'"

        End If
    End Sub

    Private Sub ToolStripTextBox_Search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Search.TextChanged
        Timer_Search.Stop()
        If ToolStripTextBox_Search.ReadOnly = False Then
            Timer_Search.Start()
        End If


    End Sub

    Private Sub ToolStripButton_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Filter.Click
        If ToolStripButton_Filter.Checked = True Then
            ToolStripButton_Filter.Checked = False
            Timer_Search.Start()
        Else
            ToolStripButton_Filter.Checked = True
            Timer_Search.Start()
        End If
    End Sub

    Private Sub Timer_Search_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Search.Tick
        Dim objSemItem_Search As clsSemItem
        Timer_Search.Stop()
        If ToolStripButton_Filter.Checked = True Then
            If ToolStripTextBox_Search.Text = "" Then
                BindingSource_Passwords.Filter = ""
            Else
                objSemItem_Search = ToolStripComboBox_Search.SelectedItem
                If Not objSemItem_Search Is Nothing Then
                    Select Case objSemItem_Search.GUID
                        Case objLocalConfig.SemItem_Token_Search_Template_Name_.GUID
                            If objLocalConfig.Globals.is_GUID(ToolStripTextBox_Search.Text) Then
                                BindingSource_Passwords.Filter = "GUID_Secured='" & ToolStripTextBox_Search.Text & "'"
                            Else
                                BindingSource_Passwords.Filter = "Name_Secured LIKE '%" & ToolStripTextBox_Search.Text & "%'"
                            End If
                        Case objLocalConfig.SemItem_Token_Search_Template_Related_Sem_Item_.GUID
                        Case objLocalConfig.SemItem_Token_Search_Template_Related_Type_.GUID

                    End Select
                End If

            End If
        Else
            BindingSource_Passwords.RemoveFilter()
        End If
        
    End Sub

    
    

    Private Sub open_Authentication(ByVal boolUser As Boolean, ByVal boolGroup As Boolean, ByVal RelateMode As frmAuthenticate.ERelateMode)
        Dim objSemItem_User As clsSemItem
        Dim objSemItem_Group As clsSemItem
        Dim strAuthentication As String

        objFrmAuthenticate = New frmAuthenticate(objLocalConfig, boolUser, boolGroup, RelateMode)
        objFrmAuthenticate.ShowDialog(Me)
        If objFrmAuthenticate.DialogResult = Windows.Forms.DialogResult.OK Then
            objSemItem_User = objFrmAuthenticate.SemItem_User
            objSemItem_Group = objFrmAuthenticate.SemItem_Group

            strAuthentication = ""

            If Not objSemItem_User Is Nothing Then
                strAuthentication = objSemItem_User.Name
            End If

            If Not objSemItem_Group Is Nothing Then
                If strAuthentication <> "" Then
                    strAuthentication = strAuthentication & " / "
                End If
                strAuthentication = strAuthentication & objSemItem_Group.Name
            End If

            MsgBox(strAuthentication)
        End If
    End Sub

    Private Sub ToolStripMenuItem_UserAndGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_UserAndGroup.Click
        open_Authentication(True, True, frmAuthenticate.ERelateMode.NoRelate)
    End Sub

    Private Sub ToolStripMenuItem_User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_User.Click
        open_Authentication(True, False, frmAuthenticate.ERelateMode.NoRelate)
    End Sub

    Private Sub ToolStripMenuItem_Group_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_Group.Click
        open_Authentication(False, True, frmAuthenticate.ERelateMode.NoRelate)
    End Sub

    Private Sub ToolStripMenuItem_UserToGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_UserToGroup.Click
        open_Authentication(True, True, frmAuthenticate.ERelateMode.User_To_Group)
    End Sub

    Private Sub ToolStripMenuItem_GroupToUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_GroupToUser.Click
        open_Authentication(True, True, frmAuthenticate.ERelateMode.Group_To_User)
    End Sub

    Private Sub CopyPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyPasswordToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim strPassword_Decode As String

        objDGVR_Selected = DataGridView_Passwords.SelectedRows(0)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        strPassword_Decode = objSecurityModuleWork.decode_Password(objDRV_Selected.Item("Name_Password"))
        Clipboard.SetDataObject(strPassword_Decode)
        Timer_Remove.Start()
    End Sub

    Private Sub Timer_Remove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Remove.Tick
        Timer_Remove.Stop()
        Clipboard.Clear()
    End Sub
End Class
