Imports Sem_Manager
Imports Localizing_Manager
Public Class UserControl_DevelopmentTree
    Private Const cstr_GUID_Development As String = "2a5ed6bc-1b57-4ab6-b216-66dd7c58409b"
    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Dev_Open As Integer = 1
    Private Const cint_ImageID_Dev_Closed As Integer = 2


    Private funcA_SoftwareDevelopment_roots_and_L1_with_State As New ds_PluginTableAdapters.func_SoftwareDevelopment_roots_and_L1_with_StateTableAdapter
    Private funcA_subordinated_L1_L2_SoftwareDevelopment_with_State As New ds_PluginTableAdapters.func_subordinated_L1_L2_SoftwareDevelopment_with_StateTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private procA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private procA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private objLocalize_GUIEntries As clsLocalized_GUIEntries
    Private objDlgAttribute_Varchar255 As dlgAttribute_Varchar255
    Private objFrmNewDevelopment As frmNewDevelopment
    Private objFrm_TokenEditor As frmTokenEdit

    Private objTreeNode_Root As TreeNode
    Private objTreeNode_Selected As TreeNode
    Private boolApplyable As Boolean
    Public Event selected_TreeNode_Changed(ByVal objTreeNode As TreeNode)
    Public Event selected_Root()
    Public Event applied_Development(ByVal objSemItem_Development As clsSemItem)

    Public Property isApplyable() As Boolean
        Get
            Return boolApplyable
        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
            ApplyToolStripMenuItem.Visible = boolApplyable
        End Set
    End Property
    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        set_DBConnection()
        configure_GUIEntries()
        fill_Tree()
    End Sub

    Private Sub fill_Tree()

        Dim objDRC_Develeopment As DataRowCollection
        Dim objDR_Development As DataRow
        Dim objTreeNode As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_L1 As TreeNode = Nothing
        TreeView_DevTree.Nodes.Clear()
        objDRC_Develeopment = semtblA_Token.GetData_Token_TypeChilds(objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID).Rows
        ToolStripLabel_Count.Text = objDRC_Develeopment.Count
        objTreeNode_Root = TreeView_DevTree.Nodes.Add(objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID.ToString, objLocalConfig.SemItem_Type_SoftwareDevelopment.Name, cint_ImageID_Root, cint_ImageID_Root)
        objDRC_Develeopment = funcA_SoftwareDevelopment_roots_and_L1_with_State.GetData( _
                                objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                objLocalConfig.SemItem_Type_LogState.GUID, _
                                objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                objLocalConfig.SemItem_RelationType_isSubordinated.GUID).Rows
        For Each objDR_Development In objDRC_Develeopment
            objTreeNodes = objTreeNode_Root.Nodes.Find(objDR_Development.Item("GUID_Development").ToString, False)
            If objTreeNodes.Count = 0 Then
                objTreeNode = objTreeNode_Root.Nodes.Add(objDR_Development.Item("GUID_Development").ToString, objDR_Development.Item("Name_Development"), cint_ImageID_Dev_Closed, cint_ImageID_Dev_Open)
            Else
                objTreeNode = objTreeNodes(0)
            End If

            If Not IsDBNull(objDR_Development.Item("GUID_Development_L1")) Then
                objTreeNode_L1 = objTreeNode.Nodes.Add(objDR_Development.Item("GUID_Development_L1").ToString, objDR_Development.Item("Name_Development_L1"), cint_ImageID_Dev_Closed, cint_ImageID_Dev_Open)
                If Not objDR_Development.Item("GUID_LogSttate_L1") = objLocalConfig.SemItem_Token_LogState_Active.GUID Then
                    objTreeNode_L1.BackColor = Color.Silver
                End If
            End If
        Next
        objTreeNode_Root.Expand()
        TreeView_DevTree.Sort()
    End Sub

    Private Sub set_DBConnection()
        funcA_SoftwareDevelopment_roots_and_L1_with_State.Connection = objLocalConfig.Connection_Plugin
        funcA_subordinated_L1_L2_SoftwareDevelopment_with_State.Connection = objLocalConfig.Connection_Plugin
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim objSemItem_Development As New clsSemItem
        If Not objTreeNode_Selected Is Nothing Then
            Select Case objTreeNode_Selected.ImageIndex
                Case cint_ImageID_Root
                    objFrmNewDevelopment = New frmNewDevelopment
                    objFrmNewDevelopment.ShowDialog(Me)
                    If objFrmNewDevelopment.DialogResult = DialogResult.OK Then
                        fill_Tree()
                    End If
                    '            create_Development(Nothing)
                Case cint_ImageID_Dev_Closed
                    '            create_Development(objTreeNode_Selected)
                    objSemItem_Development.GUID = New Guid(objTreeNode_Selected.Name)
                    objSemItem_Development.Name = objTreeNode_Selected.Text
                    objSemItem_Development.GUID_Parent = objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID
                    objSemItem_Development.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objFrmNewDevelopment = New frmNewDevelopment(objSemItem_Development)
                    objFrmNewDevelopment.ShowDialog(Me)
                    If objFrmNewDevelopment.DialogResult = DialogResult.OK Then
                        objTreeNode_Selected.Nodes.Clear()
                        get_SubNodes(objTreeNode_Selected)
                    End If
            End Select
        End If
    End Sub

    Private Sub create_Development(ByVal objTreeNode_Parent As TreeNode)
        Dim objDRC_Development As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objGUID_Development As Guid
        Dim strName_Development As String
        Dim GUID_Development_Parent As Guid

        If objTreeNode_Parent Is Nothing Then
            GUID_Development_Parent = Nothing
        Else
            GUID_Development_Parent = New Guid(objTreeNode_Parent.Name)
        End If

        objDlgAttribute_Varchar255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Type_SoftwareDevelopment.Name, objLocalConfig.Globals)
        objDlgAttribute_Varchar255.ShowDialog(Me)
        If objDlgAttribute_Varchar255.DialogResult = DialogResult.OK Then
            strName_Development = objDlgAttribute_Varchar255.Value1
            If GUID_Development_Parent = Nothing Then
                objGUID_Development = Guid.NewGuid
                objDRC_Development = funcA_SoftwareDevelopment_roots_and_L1_with_State.GetData_By_Name( _
                                        objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                        objLocalConfig.SemItem_Type_LogState.GUID, _
                                        objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                        objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                        strName_Development).Rows
                If objDRC_Development.Count = 0 Then
                    objDRC_LogState = procA_DBWork_Save_Token.GetData(objGUID_Development, strName_Development, objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, True).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Beim Speichern der Softwareentwicklung ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                    Else
                        set_Development_ActiveInactive(objGUID_Development, True)
                        fill_Tree()
                    End If
                End If

                'If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Exists.GUID Then
                '    MsgBox("Es existiert bereits eine Softwareentwicklung mit diesem Namen! Wählen Sie bitte einen anderen!", MsgBoxStyle.Exclamation)
                'ElseIf objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                '    MsgBox("Beim Speichern der Softwareentwicklung ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                'Else
                '    fill_Tree()
                'End If
            Else
                objGUID_Development = Guid.NewGuid
                objDRC_Development = funcA_TokenToken.GetData_TokenToken_LeftRight(objGUID_Development, objLocalConfig.SemItem_RelationType_isSubordinated.GUID, objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID).Rows
                If objDRC_Development.Count = 0 Then
                    objDRC_LogState = procA_DBWork_Save_Token.GetData(objGUID_Development, strName_Development, objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, True).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Beim Speichern der Softwareentwicklung ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                    Else
                        objDRC_LogState = procA_DBWork_Save_TokenRel.GetData(objGUID_Development, GUID_Development_Parent, objLocalConfig.SemItem_RelationType_isSubordinated.GUID, 0).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Beim Speichern der Softwareentwicklung ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                            fill_Tree()
                        Else
                            set_Development_ActiveInactive(objGUID_Development, True)
                            get_SubNodes(objTreeNode_Parent)
                        End If

                    End If
                End If
            End If
        End If

    End Sub

    Private Function set_Development_ActiveInactive(ByVal GUID_Development As Guid, ByVal boolActive As Boolean) As Boolean

        Dim objDRC_LogStates As DataRowCollection
        Dim objDR_LogState As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim boolAdd As Boolean = True
        Dim boolResult As Boolean = True


        objDRC_LogStates = funcA_TokenToken.GetData_TokenToken_LeftRight(GUID_Development, objLocalConfig.SemItem_RelationType_isInState.GUID, objLocalConfig.SemItem_Type_LogState.GUID).Rows
        For Each objDR_LogState In objDRC_LogStates
            If boolActive = True Then
                If objDR_LogState.Item("GUID_Token_Right") = objLocalConfig.SemItem_Token_LogState_Active.GUID Then
                    boolAdd = False
                Else
                    objDRC_LogState = procA_DBWork_Del_TokenRel.GetData(objDR_LogState.Item("GUID_Token_Left"), objDR_LogState.Item("GUID_Token_Right"), objDR_LogState.Item("GUID_RelationType")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Beim Veknüpfen der Softwareentwicklung mit ihrem Status ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                        boolAdd = False
                        boolResult = False
                        Exit For
                    End If
                End If
            Else
                If objDR_LogState.Item("GUID_Token_Right") = objLocalConfig.SemItem_Token_LogState_Inactive.GUID Then
                    boolAdd = False
                Else
                    objDRC_LogState = procA_DBWork_Del_TokenRel.GetData(objDR_LogState.Item("GUID_Token_Left"), objDR_LogState.Item("GUID_Token_Right"), objDR_LogState.Item("GUID_RelationType")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Beim Veknüpfen der Softwareentwicklung mit ihrem Status ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                        boolAdd = False
                        boolResult = False
                        Exit For
                    End If
                End If
            End If

        Next
        If boolAdd = True Then
            If boolActive = True Then
                objDRC_LogState = procA_DBWork_Save_TokenRel.GetData(GUID_Development, objLocalConfig.SemItem_Token_LogState_Active.GUID, objLocalConfig.SemItem_RelationType_isInState.GUID, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Beim Veknüpfen der Softwareentwicklung mit ihrem Status ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                    boolResult = False
                End If
            Else
                objDRC_LogState = procA_DBWork_Save_TokenRel.GetData(GUID_Development, objLocalConfig.SemItem_Token_LogState_Inactive.GUID, objLocalConfig.SemItem_RelationType_isInState.GUID, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Beim Veknüpfen der Softwareentwicklung mit ihrem Status ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                    boolResult = False
                End If
            End If

        End If
        Return boolResult
    End Function

    Private Sub TreeView_DevTree_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_DevTree.DoubleClick
        Dim objTreeNode As TreeNode
        Dim objSemItem_Development As New clsSemItem

        objTreeNode = TreeView_DevTree.SelectedNode

        If objTreeNode.ImageIndex = cint_ImageID_Dev_Closed Then
            objSemItem_Development.GUID = New Guid(objTreeNode.Name)
            objSemItem_Development.Name = objTreeNode.Text
            objSemItem_Development.GUID_Parent = objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID
            objSemItem_Development.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objFrm_TokenEditor = New frmTokenEdit(objSemItem_Development, objLocalConfig.Globals)
            objFrm_TokenEditor.ShowDialog(Me)
            fill_Tree()
            Try
                TreeView_DevTree.SelectedNode = objTreeNode
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub TreeView_DevTree_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView_DevTree.MouseDown
        objTreeNode_Selected = TreeView_DevTree.GetNodeAt(e.Location)
        If Not objTreeNode_Selected Is Nothing Then
            TreeView_DevTree.SelectedNode = objTreeNode_Selected
        End If
    End Sub

    Private Sub TreeView_DevTree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_DevTree.AfterSelect

        objTreeNode_Selected = e.Node
        ToolStripTextBox_GUID.Text = ""
        Select Case objTreeNode_Selected.ImageIndex
            Case cint_ImageID_Dev_Closed
                get_SubNodes(objTreeNode_Selected)
                ToolStripTextBox_GUID.Text = objTreeNode_Selected.Name
                RaiseEvent selected_TreeNode_Changed(objTreeNode_Selected)
            Case cint_ImageID_Root
                RaiseEvent selected_Root()
        End Select
    End Sub
    Private Sub get_SubNodes(ByVal objTreeNode_Parent As TreeNode)
        Dim objDRC_Development_L1_L2 As DataRowCollection
        Dim objDR_Development_L1_L2 As DataRow

        Dim objTreeNodes() As TreeNode
        Dim objTreeNode As TreeNode

        objTreeNode_Parent.Nodes.Clear()

        objDRC_Development_L1_L2 = funcA_subordinated_L1_L2_SoftwareDevelopment_with_State.GetData_By_GUIDDevelopment( _
                                                objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                objLocalConfig.SemItem_Type_LogState.GUID, _
                                                objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                New Guid(objTreeNode_Parent.Name)).Rows
        For Each objDR_Development_L1_L2 In objDRC_Development_L1_L2
            objTreeNodes = objTreeNode_Parent.Nodes.Find(objDR_Development_L1_L2.Item("GUID_Development_L1").ToString, False)
            If objTreeNodes.Length > 0 Then
                objTreeNode = objTreeNodes(0)
            Else
                objTreeNode = objTreeNode_Selected.Nodes.Add(objDR_Development_L1_L2.Item("GUID_Development_L1").ToString, objDR_Development_L1_L2.Item("Name_Development_L1"), cint_ImageID_Dev_Closed, cint_ImageID_Dev_Open)
                If Not objDR_Development_L1_L2.Item("GUID_LogSttate_L1") = objLocalConfig.SemItem_Token_LogState_Active.GUID Then
                    objTreeNode.BackColor = Color.Silver
                End If
            End If
            If Not IsDBNull(objDR_Development_L1_L2.Item("GUID_Development_L2")) Then
                objTreeNodes = objTreeNode.Nodes.Find(objDR_Development_L1_L2.Item("GUID_Development_L2").ToString, False)
                If objTreeNodes.Length = 0 Then
                    objTreeNode = objTreeNode.Nodes.Add(objDR_Development_L1_L2.Item("GUID_Development_L2").ToString, objDR_Development_L1_L2.Item("Name_Development_L2"), cint_ImageID_Dev_Closed, cint_ImageID_Dev_Open)
                    If Not objDR_Development_L1_L2.Item("GUID_LogState_L2") = objLocalConfig.SemItem_Token_LogState_Active.GUID Then
                        objTreeNode.BackColor = Color.Silver
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub configure_GUIEntries()
        Dim objSemItem_Development As New clsSemItem
        Dim objDR_GUIEntry As DataRow
        Dim strCaption As String
        Dim strToolTip As String

        objSemItem_Development.GUID = New Guid(cstr_GUID_Development)
        objLocalize_GUIEntries = New clsLocalized_GUIEntries(objSemItem_Development, objLocalConfig.Globals)

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripLabel_DevCount.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ToolStripLabel_DevCount.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                ToolStripLabel_DevCount.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripTextBox_Mark.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            
            If Not strToolTip Is Nothing Then
                ToolStripTextBox_Mark.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripLabel_Mark.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ToolStripLabel_Mark.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                ToolStripLabel_Mark.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripLabel_GUIDSelectedLbl.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ToolStripLabel_GUIDSelectedLbl.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                ToolStripLabel_GUIDSelectedLbl.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripTextBox_GUID.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            
            If Not strToolTip Is Nothing Then
                ToolStripTextBox_GUID.ToolTipText = strToolTip
            End If

        End If
    End Sub


    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Development As New clsSemItem

        objTreeNode = TreeView_DevTree.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Dev_Closed Then
                objSemItem_Development.GUID = New Guid(objTreeNode.Name)
                objSemItem_Development.Name = objTreeNode.Text
                objSemItem_Development.GUID_Parent = objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID
                objSemItem_Development.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                RaiseEvent applied_Development(objSemItem_Development)
            End If
        End If
    End Sub

    Private Sub ContextMenuStrip_Development_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Development.Opening
        Dim objTreeNode As TreeNode
        ApplyToolStripMenuItem.Enabled = False
        objTreeNode = TreeView_DevTree.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Dev_Closed Then
                ApplyToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub
End Class
