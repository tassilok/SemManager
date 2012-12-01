Imports Sem_Manager
Public Class UserControl_GUIEntries

    Private Const cint_ImageID_GUICaption As Integer = 0
    Private Const cint_ImageID_GUIEntries As Integer = 1
    Private Const cint_ImageID_LanguageDone As Integer = 2
    Private Const cint_ImageID_LanguageToDo As Integer = 3
    Private Const cint_ImageID_GUIEntry As Integer = 4
    Private Const cint_ImageID_Root As Integer = 5
    Private Const cint_ImageID_ToolTip As Integer = 6
    Private Const cint_ImageID_EntryCaption As Integer = 7

    Private procA_GUICaptions_Of_SoftwareDevelopment As New ds_GUIEntriesTableAdapters.proc_GUICaptions_Of_SoftwareDevelopmentTableAdapter
    Private procT_GUICaptions_Of_SoftwareDevelopment As New ds_GUIEntries.proc_GUICaptions_Of_SoftwareDevelopmentDataTable

    Private procA_GUIEntries_Of_Development As New ds_GUIEntriesTableAdapters.proc_GUIEntries_Of_DevelopmentTableAdapter
    Private procT_GUIEntries_Of_Development As New ds_GUIEntries.proc_GUIEntries_Of_DevelopmentDataTable

    Private procA_GUICaptions_Of_GUIEntry As New ds_GUIEntriesTableAdapters.proc_GUICaptions_Of_GUIEntryTableAdapter
    Private procT_GUICaptions_Of_GUIEntry As New ds_GUIEntries.proc_GUICaptions_Of_GUIEntryDataTable

    Private procA_ToolTipMessages_Of_GUIEntry As New ds_GUIEntriesTableAdapters.proc_ToolTipMessages_Of_GUIEntryTableAdapter
    Private procT_ToolTipMessages_Of_GUIEntry As New ds_GUIEntries.proc_ToolTipMessages_Of_GUIEntryDataTable

    Private semtbl_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter

    Private procA_GUICaption_With_Language As New ds_GUIEntriesTableAdapters.proc_GUICaption_With_LanguageTableAdapter

    Private objDLG_Attribute_VARCHAR255 As dlgAttribute_Varchar255

    Private objSemItems_Languages() As clsSemItem
    Private objSemItem_Development As clsSemItem
    Private objTreeNode_GUICaption As TreeNode
    Private objTreeNode_GUIEntries As TreeNode

    Private objTreeNode_Last_GUICaption As TreeNode
    Private objTreeNode_Last_ToolTip As TreeNode

    Private GUID_GUICaptionToolTip As Guid
    Private boolApplyable As Boolean

    Public Event applied_GUIEntry(ByVal objSemItem_GUIEntry As clsSemItem)

    Public Sub New(ByVal SemItem_Development As clsSemItem, ByVal SemItems_Language() As clsSemItem, ByVal isApplyable As Boolean)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        set_DBConnection()
        objSemItem_Development = SemItem_Development
        objSemItems_Languages = SemItems_Language
        boolApplyable = isApplyable

        initialize()

    End Sub

    Private Sub set_DBConnection()
        semtbl_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB

        procA_GUICaptions_Of_SoftwareDevelopment.Connection = objLocalConfig.Connection_Plugin
        procA_GUIEntries_Of_Development.Connection = objLocalConfig.Connection_Plugin
        procA_GUICaptions_Of_GUIEntry.Connection = objLocalConfig.Connection_Plugin
        procA_ToolTipMessages_Of_GUIEntry.Connection = objLocalConfig.Connection_Plugin
        procA_GUICaption_With_Language.Connection = objLocalConfig.Connection_Plugin
    End Sub
   
    Private Sub initialize()


        TreeView_GUIEntries.Nodes.Clear()
        TextBox_LocalizedDescription.ReadOnly = True
        TextBox_LocalizedDescription.Text = ""
        ApplyToolStripMenuItem.Visible = boolApplyable

        If Not objSemItem_Development Is Nothing And Not objSemItems_Languages Is Nothing Then
            fill_GUIEntryView()
        End If
    End Sub

    Private Sub fill_GUIEntryView()
        Dim objTreeNode_Root As TreeNode
        TreeView_GUIEntries.Nodes.Clear()

        objTreeNode_Root = TreeView_GUIEntries.Nodes.Add(objSemItem_Development.GUID.ToString, objSemItem_Development.Name, cint_ImageID_Root, cint_ImageID_Root)

        objTreeNode_GUICaption = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_GUI_Caption.GUID.ToString, objLocalConfig.SemItem_Type_GUI_Caption.Name, cint_ImageID_GUICaption, cint_ImageID_GUICaption)
        objTreeNode_GUIEntries = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_GUI_Entires.GUID.ToString, objLocalConfig.SemItem_Type_GUI_Entires.Name, cint_ImageID_GUIEntries, cint_ImageID_GUIEntries)

        get_GUICaptions()
        get_GUIEntries()

        objTreeNode_Root.Expand()
        objTreeNode_GUICaption.Expand()
        objTreeNode_GUIEntries.Expand()
    End Sub

    Private Sub get_GUICaptions()
        Dim objSemItem_Language As clsSemItem
        Dim objDRs_GUICaptions() As DataRow
        procA_GUICaptions_Of_SoftwareDevelopment.Fill(procT_GUICaptions_Of_SoftwareDevelopment, _
                                                      objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                      objLocalConfig.SemItem_Type_Language.GUID, _
                                                      objLocalConfig.SemItem_Type_GUI_Caption.GUID, _
                                                      objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                      objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                      objSemItem_Development.GUID)

        For Each objSemItem_Language In objSemItems_Languages
            objDRs_GUICaptions = procT_GUICaptions_Of_SoftwareDevelopment.Select("GUID_Language='" & objSemItem_Language.GUID.ToString & "'")
            If objDRs_GUICaptions.Count = 0 Then
                objTreeNode_GUICaption.Nodes.Add(objSemItem_Development.GUID.ToString & "_" & objSemItem_Language.GUID.ToString, objSemItem_Language.Name, cint_ImageID_LanguageToDo, cint_ImageID_LanguageToDo)
            Else
                objTreeNode_GUICaption.Nodes.Add(objSemItem_Development.GUID.ToString & "_" & objSemItem_Language.GUID.ToString, objSemItem_Language.Name, cint_ImageID_LanguageDone, cint_ImageID_LanguageDone)
            End If
        Next
    End Sub

    Private Sub get_GUIEntries()
        Dim objSemItem_Language As clsSemItem
        Dim objDRs_GIUCaption() As DataRow
        Dim objDRs_ToolTipMessages() As DataRow
        Dim objDR_GUIEntries As DataRow
        Dim objTreeNode_GUIEntry As TreeNode
        Dim objTreeNode_Caption As TreeNode
        Dim objTreeNode_ToolTip As TreeNode
        Dim objTreeNode_Language As TreeNode
        Dim intCount_GUICaptions As Integer = 0
        Dim intCount_ToolTips As Integer = 0
        Dim boolDef_GUICaptions As Boolean
        Dim boolDef_ToolTips As Boolean

        objTreeNode_Last_GUICaption = Nothing
        objTreeNode_Last_ToolTip = Nothing
        ToolStripButton_Jump_to_next_ToDo_GUICaption.Enabled = False
        ToolStripButton_Jump_to_next_ToDo_ToolStrip.Enabled = False

        procA_GUIEntries_Of_Development.Fill(procT_GUIEntries_Of_Development, _
                                             objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                             objLocalConfig.SemItem_Type_GUI_Entires.GUID, _
                                             objLocalConfig.SemItem_RelationType_contains.GUID, _
                                             objSemItem_Development.GUID)
        ToolStripLabel_GUIEntriesCount.Text = procT_GUIEntries_Of_Development.Rows.Count
        For Each objDR_GUIEntries In procT_GUIEntries_Of_Development.Rows
            intCount_GUICaptions = intCount_GUICaptions + 1
            intCount_ToolTips = intCount_ToolTips + 1
            boolDef_GUICaptions = True
            boolDef_ToolTips = True
            procA_GUICaptions_Of_GUIEntry.Fill(procT_GUICaptions_Of_GUIEntry, _
                                               objLocalConfig.SemItem_Type_GUI_Entires.GUID, _
                                               objLocalConfig.SemItem_Type_GUI_Caption.GUID, _
                                               objLocalConfig.SemItem_Type_Language.GUID, _
                                               objLocalConfig.SemItem_RelationType_is_defined_by.GUID, _
                                               objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                               objDR_GUIEntries.Item("GUID_GUI_Entires"))

            procA_ToolTipMessages_Of_GUIEntry.Fill(procT_ToolTipMessages_Of_GUIEntry, _
                                                   objLocalConfig.SemItem_Type_ToolTip_Messages.GUID, _
                                                   objLocalConfig.SemItem_Type_Language.GUID, _
                                                   objLocalConfig.SemItem_Type_GUI_Entires.GUID, _
                                                   objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                   objLocalConfig.SemItem_RelationType_is_defined_by.GUID, _
                                                   objDR_GUIEntries.Item("GUID_GUI_Entires"))

            objTreeNode_GUIEntry = objTreeNode_GUIEntries.Nodes.Add(objDR_GUIEntries.Item("GUID_GUI_Entires").ToString, objDR_GUIEntries.Item("Name_GUI_Entires"), cint_ImageID_GUIEntry, cint_ImageID_GUIEntry)
            objTreeNode_Caption = objTreeNode_GUIEntry.Nodes.Add(objDR_GUIEntries.Item("GUID_GUI_Entires").ToString & "_" & objLocalConfig.SemItem_Type_GUI_Caption.GUID.ToString, objLocalConfig.SemItem_Type_GUI_Caption.Name, cint_ImageID_EntryCaption, cint_ImageID_EntryCaption)
            objTreeNode_ToolTip = objTreeNode_GUIEntry.Nodes.Add(objDR_GUIEntries.Item("GUID_GUI_Entires").ToString & "_" & objLocalConfig.SemItem_Type_ToolTip_Messages.GUID.ToString, objLocalConfig.SemItem_Type_ToolTip_Messages.Name, cint_ImageID_ToolTip, cint_ImageID_ToolTip)
            For Each objSemItem_Language In objSemItems_Languages
                objDRs_GIUCaption = procT_GUICaptions_Of_GUIEntry.Select("GUID_Language='" & objSemItem_Language.GUID.ToString & "'")
                If objDRs_GIUCaption.Count = 0 Then
                    objTreeNode_Language = objTreeNode_Caption.Nodes.Add(objSemItem_Language.GUID.ToString & "_" & objTreeNode_GUIEntry.Name & "_" & objTreeNode_Caption.Name, objSemItem_Language.Name, cint_ImageID_LanguageToDo, cint_ImageID_LanguageToDo)
                    boolDef_GUICaptions = False
                Else
                    objTreeNode_Language = objTreeNode_Caption.Nodes.Add(objDRs_GIUCaption(0).Item("GUID_GUI_Caption").ToString, objSemItem_Language.Name, cint_ImageID_LanguageDone, cint_ImageID_LanguageDone)
                End If

                objDRs_ToolTipMessages = procT_ToolTipMessages_Of_GUIEntry.Select("GUID_Language='" & objSemItem_Language.GUID.ToString & "'")
                If objDRs_ToolTipMessages.Count = 0 Then
                    objTreeNode_Language = objTreeNode_ToolTip.Nodes.Add(objSemItem_Language.GUID.ToString & "_" & objTreeNode_GUIEntry.Name & "_" & objTreeNode_ToolTip.Name, objSemItem_Language.Name, cint_ImageID_LanguageToDo, cint_ImageID_LanguageToDo)
                    boolDef_ToolTips = False
                Else
                    objTreeNode_Language = objTreeNode_ToolTip.Nodes.Add(objDRs_ToolTipMessages(0).Item("GUID_ToolTipMessage").ToString, objSemItem_Language.Name, cint_ImageID_LanguageDone, cint_ImageID_LanguageDone)
                End If
            Next
            If boolDef_GUICaptions = True Then
                intCount_GUICaptions = intCount_GUICaptions - 1
            End If
            If boolDef_ToolTips = True Then
                intCount_ToolTips = intCount_ToolTips - 1
            End If
        Next
        ToolStripTextBox_GUICaption_Count.Text = intCount_GUICaptions
        If intCount_GUICaptions = 0 Then
            ToolStripTextBox_GUICaption_Count.BackColor = Nothing
        Else
            ToolStripButton_Jump_to_next_ToDo_GUICaption.Enabled = True
            ToolStripTextBox_GUICaption_Count.BackColor = Color.Red
        End If
        ToolStripTextBox_ToolTip_Count.Text = intCount_ToolTips
        If intCount_ToolTips = 0 Then
            ToolStripTextBox_ToolTip_Count.BackColor = Nothing
        Else
            ToolStripButton_Jump_to_next_ToDo_ToolStrip.Enabled = True
            ToolStripTextBox_ToolTip_Count.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ContextMenuStrip_GUIEntries_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_GUIEntries.Opening
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_GUIEntries.SelectedNode

        NewGUIEntryToolStripMenuItem.Enabled = False
        CopyNameToolStripMenuItem.Enabled = False
        ApplyToolStripMenuItem.Enabled = False
        If Not objTreeNode Is Nothing Then
            If objTreeNode.Name = objLocalConfig.SemItem_Type_GUI_Entires.GUID.ToString Then
                NewGUIEntryToolStripMenuItem.Enabled = True
            End If
            If objTreeNode.ImageIndex = cint_ImageID_GUIEntry Then
                CopyNameToolStripMenuItem.Enabled = True
                ApplyToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub NewGUIEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGUIEntryToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objDRC_GUIEntry As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_GUIEntry As clsSemItem
        Dim strName_GUIEntry As String
        Dim boolNewEntry As Boolean
        Dim boolSave As Boolean

        objTreeNode = TreeView_GUIEntries.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.Name = objLocalConfig.SemItem_Type_GUI_Entires.GUID.ToString Then
                objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Type_GUI_Entires.Name, objLocalConfig.Globals)
                objDLG_Attribute_VARCHAR255.ShowDialog(Me)
                If objDLG_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
                    strName_GUIEntry = objDLG_Attribute_VARCHAR255.Value1
                    objDRC_GUIEntry = funcA_TokenToken.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(objSemItem_Development.GUID, _
                                                                                                                        strName_GUIEntry, _
                                                                                                                        objLocalConfig.SemItem_Type_GUI_Entires.GUID, _
                                                                                                                        objLocalConfig.SemItem_RelationType_is_defined_by.GUID).Rows
                    If objDRC_GUIEntry.Count = 0 Then
                        objSemItem_GUIEntry = New clsSemItem
                        objSemItem_GUIEntry.GUID = Guid.NewGuid
                        objSemItem_GUIEntry.Name = strName_GUIEntry
                        objSemItem_GUIEntry.GUID_Parent = objLocalConfig.SemItem_Type_GUI_Entires.GUID
                        objSemItem_GUIEntry.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objDRC_GUIEntry = semtbl_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_GUI_Entires.GUID, objSemItem_GUIEntry.Name).Rows
                        If objDRC_GUIEntry.Count = 0 Then
                            boolNewEntry = True
                        Else
                            If MsgBox("Es gibt bereits ein GUI-Entry mit der angegebenen Bezeichnung. Soll es benutzt werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                boolNewEntry = False
                                objSemItem_GUIEntry.GUID = objDRC_GUIEntry(0).Item("GUID_Token")
                                objSemItem_GUIEntry.Name = objDRC_GUIEntry(0).Item("Name_Token")
                                objSemItem_GUIEntry.GUID_Parent = objLocalConfig.SemItem_Type_GUI_Entires.GUID
                                objSemItem_GUIEntry.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                boolSave = True

                            Else
                                boolNewEntry = True
                            End If

                            
                        End If
                        If boolNewEntry = True Then
                            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_GUIEntry.GUID, objSemItem_GUIEntry.Name, objSemItem_GUIEntry.GUID_Parent, True).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                boolSave = True
                            Else
                                MsgBox("Das GUI-Entry kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                boolSave = False
                            End If
                        End If
                        If boolSave = True Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development.GUID, objSemItem_GUIEntry.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, 0).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                                MsgBox("Das GUI-Entry konnte nicht mit der Softwareentwicklung verknüpft werden!", MsgBoxStyle.Exclamation)
                            Else
                                ToolStripTextBox_GUICaption_Count.Text = Integer.Parse(ToolStripTextBox_GUICaption_Count.Text) + 1
                                ToolStripTextBox_ToolTip_Count.Text = Integer.Parse(ToolStripTextBox_ToolTip_Count.Text) + 1
                                fill_GUIEntryView()
                            End If
                        End If
                    Else
                        MsgBox("Der Software-Entwicklung ist bereits ein GUI-Entry mit dem angegebenen Namen zugeordnet. Wählen Sie bitte einen anderen!", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TreeView_GUIEntries_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_GUIEntries.AfterSelect
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Parent As TreeNode
        Dim objTreeNode_GUIEntry As TreeNode
        Dim objSemItem_GUICaptionToolTip As New clsSemItem
        Dim objDRs_GUICaptionToolTip() As DataRow
        Dim objDRC_GUICaptionToolTip As DataRowCollection
        Dim objDRC_GUIEntry As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim strGUIDs() As String
        Dim GUID_Language As Guid
        Dim GUID_GUIEntry As Guid
        Dim GUID_CaptionToolTip As Guid
        Dim boolGUICaption As Boolean
        Dim boolShowText As Boolean
        Dim boolExists As Boolean
        Dim intToolTipToDo_Count As Integer = Integer.Parse(ToolStripTextBox_ToolTip_Count.Text)
        Dim intGUICaption_Count As Integer = Integer.Parse(ToolStripTextBox_GUICaption_Count.Text)

        objTreeNode = e.Node
        TextBox_LocalizedDescription.ReadOnly = True
        TextBox_LocalizedDescription.Text = ""

        If objTreeNode.ImageIndex = cint_ImageID_LanguageDone Or objTreeNode.ImageIndex = cint_ImageID_LanguageToDo Then
            objTreeNode_Parent = objTreeNode.Parent
            If Not objTreeNode_Parent Is Nothing Then
                Select Case objTreeNode_Parent.ImageIndex
                    Case cint_ImageID_EntryCaption
                        boolGUICaption = True
                        boolShowText = True
                        If objTreeNode.ImageIndex = cint_ImageID_LanguageDone Then
                            boolExists = True
                        Else
                            boolExists = False
                        End If
                    Case cint_ImageID_ToolTip
                        boolGUICaption = False
                        boolShowText = True
                        If objTreeNode.ImageIndex = cint_ImageID_LanguageDone Then
                            boolExists = True
                        Else
                            boolExists = False
                        End If
                    Case Else
                        boolShowText = False
                End Select
                If boolShowText = True Then
                    objTreeNode_GUIEntry = objTreeNode_Parent.Parent
                    If boolExists = True Then
                        GUID_CaptionToolTip = New Guid(objTreeNode.Name)

                        objDRC_GUICaptionToolTip = semtbl_Token.GetData_Token_By_GUID(GUID_CaptionToolTip).Rows
                        If objDRC_GUICaptionToolTip.Count = 1 Then
                            objSemItem_GUICaptionToolTip.GUID = objDRC_GUICaptionToolTip(0).Item("GUID_Token")
                            objSemItem_GUICaptionToolTip.Name = objDRC_GUICaptionToolTip(0).Item("Name_Token")
                            If boolGUICaption = True Then
                                objSemItem_GUICaptionToolTip.GUID_Parent = objLocalConfig.SemItem_Type_GUI_Caption.GUID
                            Else
                                objSemItem_GUICaptionToolTip.GUID_Parent = objLocalConfig.SemItem_Type_ToolTip_Messages.GUID
                            End If

                            objSemItem_GUICaptionToolTip.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        Else
                            boolExists = False
                        End If

                    Else

                        strGUIDs = objTreeNode.Name.Split("_")
                        GUID_Language = New Guid(strGUIDs(0))
                        GUID_GUIEntry = New Guid(strGUIDs(1))
                        GUID_CaptionToolTip = New Guid(strGUIDs(2))
                        If boolGUICaption = True Then

                            procA_GUICaptions_Of_GUIEntry.Fill(procT_GUICaptions_Of_GUIEntry, _
                                               objLocalConfig.SemItem_Type_GUI_Entires.GUID, _
                                               objLocalConfig.SemItem_Type_GUI_Caption.GUID, _
                                               objLocalConfig.SemItem_Type_Language.GUID, _
                                               objLocalConfig.SemItem_RelationType_is_defined_by.GUID, _
                                               objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                               GUID_GUIEntry)
                            objDRs_GUICaptionToolTip = procT_GUICaptions_Of_GUIEntry.Select("GUID_Language='" & GUID_Language.ToString & "'")
                            If objDRs_GUICaptionToolTip.Count = 1 Then
                                objSemItem_GUICaptionToolTip.GUID = objDRs_GUICaptionToolTip(0).Item("GUID_GUI_Caption")
                                objSemItem_GUICaptionToolTip.Name = objDRs_GUICaptionToolTip(0).Item("Name_GUI_Caption")
                                objSemItem_GUICaptionToolTip.GUID_Parent = objLocalConfig.SemItem_Type_GUI_Caption.GUID
                                objSemItem_GUICaptionToolTip.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                boolExists = True
                            Else
                                objSemItem_GUICaptionToolTip.GUID = Guid.NewGuid
                                objSemItem_GUICaptionToolTip.Name = objTreeNode_GUIEntry.Text
                                objSemItem_GUICaptionToolTip.GUID_Parent = objLocalConfig.SemItem_Type_GUI_Caption.GUID
                                objSemItem_GUICaptionToolTip.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                boolExists = False
                            End If
                        Else
                            procA_ToolTipMessages_Of_GUIEntry.Fill(procT_ToolTipMessages_Of_GUIEntry, _
                                                   objLocalConfig.SemItem_Type_ToolTip_Messages.GUID, _
                                                   objLocalConfig.SemItem_Type_Language.GUID, _
                                                   objLocalConfig.SemItem_Type_GUI_Entires.GUID, _
                                                   objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                   objLocalConfig.SemItem_RelationType_is_defined_by.GUID, _
                                                   GUID_GUIEntry)
                            objDRs_GUICaptionToolTip = procT_ToolTipMessages_Of_GUIEntry.Select("GUID_Language='" & GUID_Language.ToString & "'")
                            If objDRs_GUICaptionToolTip.Count = 1 Then
                                objSemItem_GUICaptionToolTip.GUID = objDRs_GUICaptionToolTip(0).Item("GUID_ToolTipMessage")
                                objSemItem_GUICaptionToolTip.Name = objDRs_GUICaptionToolTip(0).Item("Name_ToolTipMessage")
                                objSemItem_GUICaptionToolTip.GUID_Parent = objLocalConfig.SemItem_Type_ToolTip_Messages.GUID
                                objSemItem_GUICaptionToolTip.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                boolExists = True
                            Else
                                objSemItem_GUICaptionToolTip.GUID = Guid.NewGuid
                                objSemItem_GUICaptionToolTip.Name = objTreeNode_GUIEntry.Text
                                objSemItem_GUICaptionToolTip.GUID_Parent = objLocalConfig.SemItem_Type_ToolTip_Messages.GUID
                                objSemItem_GUICaptionToolTip.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                boolExists = False
                            End If
                        End If
                    End If




                    If boolExists = True Then
                        TextBox_LocalizedDescription.ReadOnly = True
                        TextBox_LocalizedDescription.Text = objSemItem_GUICaptionToolTip.Name
                        TextBox_LocalizedDescription.MaxLength = 255
                        TextBox_LocalizedDescription.ReadOnly = False

                        GUID_GUICaptionToolTip = objSemItem_GUICaptionToolTip.GUID
                    Else
                        objSemItem_GUICaptionToolTip.GUID = Guid.NewGuid
                        objSemItem_GUICaptionToolTip.Name = objTreeNode_GUIEntry.Text
                        If boolGUICaption = True Then
                            objSemItem_GUICaptionToolTip.GUID_Parent = objLocalConfig.SemItem_Type_GUI_Caption.GUID
                        Else
                            objSemItem_GUICaptionToolTip.GUID_Parent = objLocalConfig.SemItem_Type_ToolTip_Messages.GUID
                        End If

                        objSemItem_GUICaptionToolTip.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_GUICaptionToolTip.GUID, objSemItem_GUICaptionToolTip.Name, objSemItem_GUICaptionToolTip.GUID_Parent, True).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_GUICaptionToolTip.GUID, GUID_Language, objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, 0).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(GUID_GUIEntry, objSemItem_GUICaptionToolTip.GUID, objLocalConfig.SemItem_RelationType_is_defined_by.GUID, 0).Rows
                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                    TextBox_LocalizedDescription.ReadOnly = True
                                    TextBox_LocalizedDescription.Text = objSemItem_GUICaptionToolTip.Name
                                    TextBox_LocalizedDescription.ReadOnly = False
                                    GUID_GUICaptionToolTip = objSemItem_GUICaptionToolTip.GUID
                                    objTreeNode.Name = objSemItem_GUICaptionToolTip.GUID.ToString
                                    objTreeNode.ImageIndex = cint_ImageID_LanguageDone
                                    objTreeNode.SelectedImageIndex = cint_ImageID_LanguageDone
                                    If boolGUICaption = True Then
                                        intGUICaption_Count = intGUICaption_Count - 1
                                    Else
                                        intToolTipToDo_Count = intToolTipToDo_Count - 1
                                    End If
                                Else
                                    MsgBox("Die GUI-Caption konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Die GUI-Caption konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Die GUI-Caption konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If


                    End If

                End If

            End If

        End If

        ToolStripTextBox_GUICaption_Count.Text = intGUICaption_Count
        ToolStripTextBox_ToolTip_Count.Text = intToolTipToDo_Count
    End Sub

    Private Sub TextBox_LocalizedDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_LocalizedDescription.TextChanged
        Timer_Description.Stop()
        If TextBox_LocalizedDescription.ReadOnly = False Then
            Timer_Description.Start()
        End If
    End Sub

    Private Sub Timer_Description_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Description.Tick
        Dim strDescription As String
        Dim objDRC_GUICaptionToolTip As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Timer_Description.Stop()

        strDescription = TextBox_LocalizedDescription.Text
        objDRC_GUICaptionToolTip = semtbl_Token.GetData_Token_By_GUID(GUID_GUICaptionToolTip).Rows
        If objDRC_GUICaptionToolTip.Count = 1 Then
            If objDRC_GUICaptionToolTip(0).Item("Name_Token") <> strDescription Then
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objDRC_GUICaptionToolTip(0).Item("GUID_Token"), strDescription, objDRC_GUICaptionToolTip(0).Item("GUID_Type"), True).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Die Description kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    TextBox_LocalizedDescription.ReadOnly = True
                    TextBox_LocalizedDescription.Text = objDRC_GUICaptionToolTip(0).Item("Name_Token")
                    TextBox_LocalizedDescription.ReadOnly = False
                End If
            End If
        Else
            MsgBox("Die Description kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
            TextBox_LocalizedDescription.ReadOnly = True
            TextBox_LocalizedDescription.Text = ""
        End If

    End Sub

    Private Sub ToolStripButton_Jump_to_next_ToDo_GUICaption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Jump_to_next_ToDo_GUICaption.Click
        find_Next_GUICaptionToolStrip(True)
    End Sub

    Private Sub find_Next_GUICaptionToolStrip(ByVal boolGUICaption As Boolean)
        Dim objTreeNode_GUIEntry As TreeNode
        Dim objTreeNode_GUICaptionToolStrip As TreeNode
        Dim objTreeNode_Languages As TreeNode
        Dim boolFound As Boolean
        Dim boolNext As Boolean
        Dim intImageID As Integer
        If boolGUICaption = True Then
            intImageID = cint_ImageID_EntryCaption
        Else
            intImageID = cint_ImageID_ToolTip
        End If

        If objTreeNode_Last_GUICaption Is Nothing Then
            For Each objTreeNode_GUIEntry In objTreeNode_GUIEntries.Nodes
                For Each objTreeNode_GUICaptionToolStrip In objTreeNode_GUIEntry.Nodes
                    If objTreeNode_GUICaptionToolStrip.ImageIndex = intImageID Then
                        boolFound = False
                        For Each objTreeNode_Languages In objTreeNode_GUICaptionToolStrip.Nodes
                            If objTreeNode_Languages.ImageIndex = cint_ImageID_LanguageToDo Then
                                If boolGUICaption = True Then
                                    objTreeNode_Last_GUICaption = objTreeNode_Languages
                                Else
                                    objTreeNode_Last_ToolTip = objTreeNode_Languages
                                End If

                                boolFound = True
                                Exit For
                            End If
                        Next
                        If boolFound = True Then
                            If boolGUICaption = True Then
                                TreeView_GUIEntries.SelectedNode = objTreeNode_Last_GUICaption
                            Else
                                TreeView_GUIEntries.SelectedNode = objTreeNode_Last_ToolTip
                            End If

                            Exit For
                        End If


                    End If
                Next
                If boolFound = True Then
                    Exit For
                End If
            Next

        Else
            objTreeNode_Languages = objTreeNode_Last_GUICaption
            objTreeNode_GUICaptionToolStrip = objTreeNode_Languages.Parent
            objTreeNode_GUIEntry = objTreeNode_GUICaptionToolStrip.Parent
            objTreeNode_GUIEntries = objTreeNode_GUIEntry.Parent
            boolNext = False
            For Each objTreeNode_GUIEntry In objTreeNode_GUIEntries.Nodes
                If boolNext = True Then
                    For Each objTreeNode_GUICaptionToolStrip In objTreeNode_GUIEntry.Nodes

                        If objTreeNode_GUICaptionToolStrip.ImageIndex = intImageID Then
                            boolFound = False
                            For Each objTreeNode_Languages In objTreeNode_GUICaptionToolStrip.Nodes
                                If objTreeNode_Languages.ImageIndex = cint_ImageID_LanguageToDo Then
                                    If boolGUICaption = True Then
                                        objTreeNode_Last_GUICaption = objTreeNode_Languages
                                    Else
                                        objTreeNode_Last_ToolTip = objTreeNode_Languages
                                    End If
                                    boolFound = True
                                    Exit For
                                End If
                            Next
                            If boolFound = True Then
                                If boolGUICaption = True Then
                                    TreeView_GUIEntries.SelectedNode = objTreeNode_Last_GUICaption
                                Else
                                    TreeView_GUIEntries.SelectedNode = objTreeNode_Last_ToolTip
                                End If
                                Exit For
                            End If


                        End If
                    Next
                    If boolFound = True Then
                        Exit For
                    End If
                End If
                If objTreeNode_GUIEntry.Name = objTreeNode_GUICaptionToolStrip.Parent.Name Then
                    boolNext = True
                End If
            Next
            If boolFound = False Then
                objTreeNode_Last_GUICaption = Nothing
                find_Next_GUICaptionToolStrip(boolGUICaption)
            End If
        End If
    End Sub

    
    Private Sub ToolStripButton_Jump_to_next_ToDo_ToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Jump_to_next_ToDo_ToolStrip.Click
        find_Next_GUICaptionToolStrip(False)
    End Sub

    Private Sub CopyNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyNameToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_GUIEntries.SelectedNode

        
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_GUIEntry Then
                Clipboard.SetDataObject(objTreeNode.Text)
            End If
        End If
    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        Dim objSemItem_GUIEntry As New clsSemItem
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_GUIEntries.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_GUIEntry Then
                objSemItem_GUIEntry.GUID = New Guid(objTreeNode.Name)
                objSemItem_GUIEntry.Name = objTreeNode.Text
                objSemItem_GUIEntry.GUID_Parent = objLocalConfig.SemItem_Type_GUI_Entires.GUID
                objSemItem_GUIEntry.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                RaiseEvent applied_GUIEntry(objSemItem_GUIEntry)
            End If
        End If

    End Sub
End Class
