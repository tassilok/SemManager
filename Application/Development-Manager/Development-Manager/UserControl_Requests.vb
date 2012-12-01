Imports Sem_Manager
Imports Localizing_Manager
Public Class UserControl_Requests
    Private Const cstr_GUID_Development As String = "43a676a7-9b10-400a-b0ed-82d9e24cfa35"
    Private Const cint_ImageID_Request_Open As Integer = 0
    Private Const cint_ImageID_Request_Changed As Integer = 1
    Private Const cint_ImageID_Request_Obsolete As Integer = 2
    Private Const cint_ImageID_RequestLog_Info As Integer = 4
    Private Const cint_ImageID_RequestLog_Change As Integer = 3
    Private Const cint_ImageID_RequestLog_Obsolete As Integer = 5
    Private Const cint_ImageID_Request_SoftwareDevelopment As Integer = 6
    Private Const cint_ImageID_Root As Integer = 7

    Private semtbl_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private procA_related_LogEntry_with_Data As New ds_PluginTableAdapters.proc_related_LogEntry_with_DataTableAdapter
    Private proc_request_LogEntry_by_Development As New ds_Plugin.proc_related_LogEntry_with_DataDataTable
    Private procA_TokenAttribute_VarcharMAX As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter

    Private objLogWork_Local As clsLogWork_Local
    Private objLocalize_GUIEntries As clsLocalized_GUIEntries
    Private objTreeNode_DevRoot As TreeNode

    Private objSemItem_Development As clsSemItem

    Private GUID_TokenAttribute As Guid
    Private GUID_Request_Log As Guid

    Public Sub New(ByVal SemItem_Development As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Development = SemItem_Development

        set_DBConnection()
        configure_GUIEntries()
        fill_Requests()
    End Sub

    Private Sub set_DBConnection()

        semtbl_Token.Connection = objLocalConfig.Connection_DB
        procA_related_LogEntry_with_Data.Connection = objLocalConfig.Connection_Plugin
        procA_TokenAttribute_VarcharMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB

        objLogWork_Local = New clsLogWork_Local()

    End Sub

    Private Sub fill_Requests()
        Dim objDRC_Development As DataRowCollection
        Dim objDR_Development As DataRow
        Dim objSemItem_Development_tmp As New clsSemItem




        TreeView_Requests.Nodes.Clear()
        objTreeNode_DevRoot = TreeView_Requests.Nodes.Add(objLocalConfig.SemItem_RelationType_Request.GUID.ToString, objLocalConfig.SemItem_RelationType_Request.Name, cint_ImageID_Root, cint_ImageID_Root)

        If Not objSemItem_Development Is Nothing Then


            fill_Requests_of_Development(objSemItem_Development, True)
        Else

            objDRC_Development = semtbl_Token.GetData_Token_TypeChilds(objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID).Rows
            For Each objDR_Development In objDRC_Development
                objSemItem_Development_tmp.GUID = objDR_Development.Item("GUID_Token")
                objSemItem_Development_tmp.Name = objDR_Development.Item("Name_Token")
                objSemItem_Development_tmp.GUID_Parent = objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID
                objSemItem_Development_tmp.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                fill_Requests_of_Development(objSemItem_Development_tmp, False)
            Next
        End If


    End Sub
    Private Sub fill_Requests_of_Development(ByVal objSemItem_Development As clsSemItem, ByVal boolShowTrees As Boolean)
        Dim proc_related_LogEntry_by_Logentry As New ds_Plugin.proc_related_LogEntry_with_DataDataTable
        Dim objDR_Request As DataRow
        Dim objDRs_Change() As DataRow
        Dim objDRs_Obsolete() As DataRow
        Dim objDRs_Info() As DataRow
        Dim objDR_Info As DataRow

        Dim objTreeNode_Development As TreeNode
        Dim objTreeNode_Open As TreeNode
        Dim objTreeNode_Changed As TreeNode
        Dim objTreeNode_Obsolete As TreeNode
        Dim objTreeNode_Request As TreeNode
        Dim objTreeNode_Log As TreeNode
        Dim strMessageLog As String
        Dim strMessage As String
        Dim boolChanged As Boolean
        Dim boolObsolete As Boolean





        procA_related_LogEntry_with_Data.Fill(proc_request_LogEntry_by_Development, _
                                                   objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                   objLocalConfig.SemItem_Attribute_Message.GUID, _
                                                   objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                   objLocalConfig.SemItem_Type_LogState.GUID, _
                                                   objLocalConfig.SemItem_RelationType_Request.GUID, _
                                                   objLocalConfig.SemItem_RelationType_provides.GUID, _
                                                   objSemItem_Development.GUID)
        If boolShowTrees = True Or proc_request_LogEntry_by_Development.Rows.Count > 0 Then
            objTreeNode_Development = objTreeNode_DevRoot.Nodes.Add(objSemItem_Development.GUID.ToString, objSemItem_Development.Name, cint_ImageID_Request_SoftwareDevelopment, cint_ImageID_Request_SoftwareDevelopment)
            objTreeNode_Open = objTreeNode_Development.Nodes.Add(objLocalConfig.SemItem_Token_LogState_Open.GUID.ToString, objLocalConfig.SemItem_Token_LogState_Open.Name, cint_ImageID_Request_Open, cint_ImageID_Request_Open)
            objTreeNode_Changed = objTreeNode_Development.Nodes.Add(objLocalConfig.SemItem_Token_LogState_Changed.GUID.ToString, objLocalConfig.SemItem_Token_LogState_Changed.Name, cint_ImageID_Request_Changed, cint_ImageID_Request_Changed)
            objTreeNode_Obsolete = objTreeNode_Development.Nodes.Add(objLocalConfig.SemItem_Token_LogState_Obsolete.GUID.ToString, objLocalConfig.SemItem_Token_LogState_Obsolete.Name, cint_ImageID_Request_Obsolete, cint_ImageID_Request_Obsolete)
        End If

        For Each objDR_Request In proc_request_LogEntry_by_Development.Rows
            strMessage = objDR_Request.Item("DateTimestamp") & ": " & objDR_Request.Item("Message")
            If strMessage.Length > 255 Then
                strMessage = strMessage.Substring(0, 251) & "..."
            End If

            procA_related_LogEntry_with_Data.Fill(proc_related_LogEntry_by_Logentry, _
                                                  objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                   objLocalConfig.SemItem_Attribute_Message.GUID, _
                                                   objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                   objLocalConfig.SemItem_Type_LogState.GUID, _
                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                   objLocalConfig.SemItem_RelationType_provides.GUID, _
                                                   objDR_Request.Item("GUID_Request"))

            boolChanged = False
            objDRs_Change = proc_related_LogEntry_by_Logentry.Select("GUID_Logstate='" & objLocalConfig.SemItem_Token_LogState_Changed.GUID.ToString & "'")
            If Not objDRs_Change Is Nothing Then
                If objDRs_Change.Count > 0 Then
                    strMessageLog = objDRs_Change(0).Item("DateTimeStamp") & ": " & objDRs_Change(0).Item("Message")
                    If strMessageLog.Length > 255 Then
                        strMessageLog = strMessageLog.Substring(0, 251) & "..."
                    End If
                    objTreeNode_Request = objTreeNode_Changed.Nodes.Add(objDR_Request("GUID_Request").ToString, strMessage, cint_ImageID_Request_Changed, cint_ImageID_Request_Changed)
                    objTreeNode_Request.ToolTipText = objDR_Request.Item("Message")
                    objTreeNode_Log = objTreeNode_Request.Nodes.Add(objDRs_Change(0).Item("GUID_Request").ToString, strMessageLog, cint_ImageID_RequestLog_Change, cint_ImageID_RequestLog_Change)
                    objTreeNode_Log.ToolTipText = objDRs_Change(0).Item("Message")
                    boolChanged = True
                End If
            End If
            boolObsolete = False
            If boolChanged = False Then
                objDRs_Obsolete = proc_related_LogEntry_by_Logentry.Select("GUID_Logstate='" & objLocalConfig.SemItem_Token_LogState_Obsolete.GUID.ToString & "'")
                If Not objDRs_Obsolete Is Nothing Then
                    If objDRs_Obsolete.Count > 0 Then

                        strMessageLog = objDRs_Obsolete(0).Item("DateTimeStamp") & ": " & objDRs_Obsolete(0).Item("Message")
                        If strMessageLog.Length > 255 Then
                            strMessageLog = strMessageLog.Substring(0, 251) & "..."

                        End If
                        objTreeNode_Request = objTreeNode_Obsolete.Nodes.Add(objDR_Request("GUID_Request").ToString, strMessage, cint_ImageID_Request_Obsolete, cint_ImageID_Request_Obsolete)
                        objTreeNode_Log = objTreeNode_Request.Nodes.Add(objDRs_Obsolete(0).Item("GUID_Request").ToString, strMessageLog, cint_ImageID_RequestLog_Obsolete, cint_ImageID_RequestLog_Obsolete)

                        boolObsolete = True
                    End If
                End If
            End If
            If boolChanged = False And boolObsolete = False Then
                objTreeNode_Request = objTreeNode_Open.Nodes.Add(objDR_Request("GUID_Request").ToString, strMessage, cint_ImageID_Request_Open, cint_ImageID_Request_Open)

            End If
            objDRs_Info = proc_related_LogEntry_by_Logentry.Select("GUID_Logstate='" & objLocalConfig.SemItem_Token_LogState_Information.GUID.ToString & "'")
            For Each objDR_Info In objDRs_Info
                strMessageLog = objDR_Info.Item("DateTimeStamp") & ": " & objDR_Info.Item("Message")
                If strMessageLog.Length > 255 Then
                    strMessageLog = strMessageLog.Substring(0, 251) & "..."

                End If
                objTreeNode_Log = objTreeNode_Request.Nodes.Add(objDR_Info.Item("GUID_Request").ToString, strMessageLog, cint_ImageID_RequestLog_Info, cint_ImageID_RequestLog_Info)


            Next

        Next

        TreeView_Requests.ExpandAll()
    End Sub

    Private Sub NewRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRequestToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_LogEntry As clsSemItem
        Dim objSemItem_LogState As clsSemItem
        Dim objSemItem_Development_ToLog As clsSemItem

        Dim objDRC_LogState As DataRowCollection

        objTreeNode = TreeView_Requests.SelectedNode

        If Not objTreeNode Is Nothing Then
            objSemItem_Development_ToLog = get_Request_Development(objTreeNode)

            objSemItem_LogEntry = objLogWork_Local.log_Entry(objSemItem_Development_ToLog, objLocalConfig.SemItem_Token_LogState_Request)
            If Not objSemItem_LogEntry Is Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development_ToLog.GUID, objSemItem_LogEntry.GUID, objLocalConfig.SemItem_RelationType_Request.GUID, 0).Rows

                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    clear_Request_Message()
                    fill_Requests()
                    TreeView_Requests.SelectedNode = objTreeNode
                End If
            End If
        End If

    End Sub

    Private Function get_Request_Development(ByVal objTreeNode As TreeNode) As clsSemItem
        Dim objTreenode_Parent As TreeNode
        Dim objSemItem_Development_Sel As New clsSemItem

        objTreenode_Parent = objTreeNode
        Do
            If Not objTreenode_Parent.Parent.ImageIndex = cint_ImageID_Root Then
                objTreenode_Parent = objTreenode_Parent.Parent
            End If
        Loop Until objTreenode_Parent.Parent.ImageIndex = cint_ImageID_Root
        If objTreenode_Parent.ImageIndex = cint_ImageID_Request_SoftwareDevelopment Then
            objSemItem_Development_Sel.GUID = New Guid(objTreenode_Parent.Name)
            objSemItem_Development_Sel.Name = objTreenode_Parent.Text
            objSemItem_Development_Sel.GUID_Parent = objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID
            objSemItem_Development_Sel.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        Else
            objSemItem_Development_Sel = Nothing
        End If
        Return objSemItem_Development_Sel
    End Function

    Private Sub clear_Request_Message()
        TextBox_RequestMessage.Enabled = False
        TextBox_RequestMessage.Clear()
    End Sub

    Private Sub ContextMenuStrip_Requests_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Requests.Opening
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Requests.SelectedNode
        NewRequestToolStripMenuItem.Enabled = False
        LogToolStripMenuItem.Enabled = False
        ChangeToolStripMenuItem.Enabled = False
        InfoToolStripMenuItem.Enabled = False
        ObsoleteToolStripMenuItem.Enabled = False
        ReopenToolStripMenuItem.Enabled = False
        clear_Request_Message()
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Request_Open
                    If objTreeNode.Name = objLocalConfig.SemItem_Token_LogState_Open.GUID.ToString Then
                        NewRequestToolStripMenuItem.Enabled = True

                    Else
                        LogToolStripMenuItem.Enabled = True
                        ChangeToolStripMenuItem.Enabled = True
                        InfoToolStripMenuItem.Enabled = True
                        ObsoleteToolStripMenuItem.Enabled = True
                        get_Request_Message()
                    End If

                Case cint_ImageID_Request_Changed, cint_ImageID_Request_Obsolete
                    If Not objTreeNode.Name = objLocalConfig.SemItem_Token_LogState_Changed.GUID.ToString And _
                       Not objTreeNode.Name = objLocalConfig.SemItem_Token_LogState_Obsolete.GUID.ToString Then
                        get_Request_Message()
                        LogToolStripMenuItem.Enabled = True
                        ReopenToolStripMenuItem.Enabled = True
                    End If

                Case Else

            End Select
        End If
    End Sub

    Private Sub get_Request_Message()
        Dim objTreeNode As TreeNode
        Dim objDRC_Message As DataRowCollection
        objTreeNode = TreeView_Requests.SelectedNode

        GUID_TokenAttribute = Nothing
        GUID_Request_Log = Nothing
        clear_Request_Message()

        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Request_Open
                    If Not objTreeNode.Name = objLocalConfig.SemItem_Token_LogState_Open.GUID.ToString Then
                        objDRC_Message = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(New Guid(objTreeNode.Name), objLocalConfig.SemItem_Attribute_Message.GUID).Rows
                        If objDRC_Message.Count > 0 Then
                            GUID_Request_Log = New Guid(objTreeNode.Name)
                            GUID_TokenAttribute = objDRC_Message(0).Item("GUID_TokenAttribute")
                            TextBox_RequestMessage.Text = objDRC_Message(0).Item("Val")
                            TextBox_RequestMessage.Enabled = True
                        End If
                    End If

                Case cint_ImageID_Request_Changed, cint_ImageID_Request_Obsolete
                    If Not objTreeNode.Name = objLocalConfig.SemItem_Token_LogState_Changed.GUID.ToString And _
                       Not objTreeNode.Name = objLocalConfig.SemItem_Token_LogState_Obsolete.GUID.ToString Then
                        objDRC_Message = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(New Guid(objTreeNode.Name), objLocalConfig.SemItem_Attribute_Message.GUID).Rows
                        If objDRC_Message.Count > 0 Then
                            GUID_Request_Log = New Guid(objTreeNode.Name)
                            GUID_TokenAttribute = objDRC_Message(0).Item("GUID_TokenAttribute")
                            TextBox_RequestMessage.Text = objDRC_Message(0).Item("Val")
                            TextBox_RequestMessage.Enabled = True
                        End If

                    End If

                Case Else

            End Select
        End If
    End Sub

    Private Sub ChangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Development_ToLog As clsSemItem
        Dim objSemItem_LogEntry As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objTreeNode = TreeView_Requests.SelectedNode
        If Not objTreeNode Is Nothing Then
            objSemItem_Development_ToLog = get_Request_Development(objTreeNode)
            objSemItem_LogEntry = objLogWork_Local.log_Entry(objSemItem_Development_ToLog, objLocalConfig.SemItem_Token_LogState_Changed)
            If Not objSemItem_LogEntry Is Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(New Guid(objTreeNode.Name), objSemItem_LogEntry.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    clear_Request_Message()
                    fill_Requests()
                    TreeView_Requests.SelectedNode = objTreeNode
                End If
            End If
        End If
    End Sub

    Private Sub ObsoleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObsoleteToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Development_ToLog As clsSemItem
        Dim objSemItem_LogEntry As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objTreeNode = TreeView_Requests.SelectedNode
        If Not objTreeNode Is Nothing Then
            objSemItem_Development_ToLog = get_Request_Development(objTreeNode)
            objSemItem_LogEntry = objLogWork_Local.log_Entry(objSemItem_Development_ToLog, objLocalConfig.SemItem_Token_LogState_Obsolete)
            If Not objSemItem_LogEntry Is Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(New Guid(objTreeNode.Name), objSemItem_LogEntry.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    clear_Request_Message()
                    fill_Requests()
                    TreeView_Requests.SelectedNode = objTreeNode
                End If
            End If
        End If
    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Development_ToLog As clsSemItem
        Dim objSemItem_LogEntry As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objTreeNode = TreeView_Requests.SelectedNode
        If Not objTreeNode Is Nothing Then
            objSemItem_Development_ToLog = get_Request_Development(objTreeNode)
            objSemItem_LogEntry = objLogWork_Local.log_Entry(objSemItem_Development_ToLog, objLocalConfig.SemItem_Token_LogState_Information)
            If Not objSemItem_LogEntry Is Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(New Guid(objTreeNode.Name), objSemItem_LogEntry.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    clear_Request_Message()
                    fill_Requests()
                    TreeView_Requests.SelectedNode = objTreeNode
                End If
            End If
        End If
    End Sub

    Private Sub configure_GUIEntries()
        Dim objSemItem_Development As New clsSemItem
        Dim objDR_GUIEntry As DataRow
        Dim strCaption As String
        Dim strToolTip As String

        objSemItem_Development.GUID = New Guid(cstr_GUID_Development)
        objLocalize_GUIEntries = New clsLocalized_GUIEntries(objSemItem_Development, objLocalConfig.Globals)

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

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripTextBox_Mark.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strToolTip Is Nothing Then
                ToolStripTextBox_Mark.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(LogToolStripMenuItem.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                LogToolStripMenuItem.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                LogToolStripMenuItem.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ReopenToolStripMenuItem.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ReopenToolStripMenuItem.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                ReopenToolStripMenuItem.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(InfoToolStripMenuItem.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                InfoToolStripMenuItem.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                InfoToolStripMenuItem.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ObsoleteToolStripMenuItem.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ObsoleteToolStripMenuItem.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                ObsoleteToolStripMenuItem.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ChangeToolStripMenuItem.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ChangeToolStripMenuItem.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                ChangeToolStripMenuItem.ToolTipText = strToolTip
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(NewRequestToolStripMenuItem.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                NewRequestToolStripMenuItem.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                NewRequestToolStripMenuItem.ToolTipText = strToolTip
            End If

        End If
        
    End Sub
End Class
