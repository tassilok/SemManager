Imports Sem_Manager
Public Class UserControl_Messages
    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Errors As Integer = 1
    Private Const cint_ImageID_Error As Integer = 2
    Private Const cint_ImageID_Users As Integer = 3
    Private Const cint_ImageID_User As Integer = 4
    Private Const cint_ImageID_Inputs As Integer = 5
    Private Const cint_ImageID_Input As Integer = 6
    Private Const cint_ImageID_Language_Done As Integer = 7
    Private Const cint_ImageID_Language_ToDo As Integer = 8
    Private Const cint_ImageID_Caption As Integer = 9
    Private Const cint_ImageID_Message As Integer = 10

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter

    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter
    Private procA_TokenAttribute_VarcharMax As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter

    Private procA_Caption_Of_Message As New ds_MessagesTableAdapters.proc_Caption_Of_MessageTableAdapter
    Private procT_Caption_Of_Message As New ds_Messages.proc_Caption_Of_MessageDataTable

    Private procA_Description_Of_Message As New ds_MessagesTableAdapters.proc_Description_Of_MessageTableAdapter
    Private procT_Description_Of_Message As New ds_Messages.proc_Description_Of_MessageDataTable

    Private procA_LocalizedMessage_Of_Message_By_GUIDMessage_And_GUIDLanguage As New ds_MessagesTableAdapters.proc_LocalizedMessage_Of_Message_By_GUIDMessage_And_GUIDLanguageTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHAR255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter
    Private semprocA_DBwork_Save_TokenAttribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objDlg_Attribute_VARCHAR255 As dlgAttribute_Varchar255

    Private objTreeNode_Root As TreeNode
    Private objTreeNode_UserMessages As TreeNode
    Private objTreeNode_InputMessages As TreeNode
    Private objTreeNode_ErrorMessages As TreeNode

    Private objSemItem_Development As clsSemItem
    Private objSemItems_Language() As clsSemItem

    Private objSemItem_LocalizedMessage As New clsSemItem
    Private GUID_Attribute As Guid
    Private GUID_Message As Guid
    Private GUID_Language As Guid
    Private GUID_TokenAttribute As Guid
    Private objSemItem_Description As New clsSemItem
    Private strCaptionDescription As String

    Dim boolNew_Caption As Boolean
    Dim boolNew_Message As Boolean

    Private intMessage_Count As Integer
    Private intMessage_ToDo As Integer


    Public Sub New(ByVal SemItem_Development As clsSemItem, ByVal SemItems_Language() As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Development = SemItem_Development
        objSemItems_Language = SemItems_Language
        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        TreeView_Messages.Nodes.Clear()
        TextBox_Description.ReadOnly = True
        TextBox_Description.Text = ""

        If Not objSemItem_Development Is Nothing And Not objSemItems_Language Is Nothing Then
            fill_MessageView()
        End If
    End Sub

    Private Sub fill_MessageView()

        objTreeNode_Root = TreeView_Messages.Nodes.Add(objSemItem_Development.GUID.ToString, objSemItem_Development.Name, cint_ImageID_Root, cint_ImageID_Root)

        intMessage_ToDo = 0
        intMessage_Count = 0

        objTreeNode_UserMessages = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_RelationType_User_Message.GUID.ToString, objLocalConfig.SemItem_RelationType_User_Message.Name, cint_ImageID_Users, cint_ImageID_Users)
        get_Messages(objTreeNode_UserMessages)
        objTreeNode_InputMessages = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_RelationType_Input_Message.GUID.ToString, objLocalConfig.SemItem_RelationType_Input_Message.Name, cint_ImageID_Inputs, cint_ImageID_Inputs)
        get_Messages(objTreeNode_InputMessages)
        objTreeNode_ErrorMessages = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_RelationType_Error_Message.GUID.ToString, objLocalConfig.SemItem_RelationType_Error_Message.Name, cint_ImageID_Errors, cint_ImageID_Errors)
        get_Messages(objTreeNode_ErrorMessages)

        objTreeNode_Root.Expand()
        objTreeNode_UserMessages.Expand()
        objTreeNode_InputMessages.Expand()
        objTreeNode_ErrorMessages.Expand()

        ToolStripLabel_ToDoCount.Text = intMessage_ToDo
        ToolStripLabel_MessageCount.Text = intMessage_Count
    End Sub

    Private Sub get_Messages(ByVal objTreeNode_Messages As TreeNode)
        Dim objDRC_Messages As DataRowCollection
        Dim objDR_Message As DataRow
        Dim objTreeNode_Message As TreeNode
        Dim objTreeNode_Caption As TreeNode
        Dim objTreeNode_Description As TreeNode
        Dim boolFinished As Boolean

        Dim intImageID As Integer
        Select Case objTreeNode_Messages.Name
            Case objTreeNode_UserMessages.Name
                objDRC_Messages = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Development.GUID, objLocalConfig.SemItem_RelationType_User_Message.GUID, objLocalConfig.SemItem_Type_Messages.GUID).Rows
                intImageID = cint_ImageID_User
            Case objTreeNode_InputMessages.Name
                objDRC_Messages = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Development.GUID, objLocalConfig.SemItem_RelationType_Input_Message.GUID, objLocalConfig.SemItem_Type_Messages.GUID).Rows
                intImageID = cint_ImageID_Input
            Case objTreeNode_ErrorMessages.Name
                objDRC_Messages = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Development.GUID, objLocalConfig.SemItem_RelationType_Error_Message.GUID, objLocalConfig.SemItem_Type_Messages.GUID).Rows
                intImageID = cint_ImageID_Error
        End Select

        intMessage_Count = intMessage_Count + objDRC_Messages.Count

        For Each objDR_Message In objDRC_Messages
            objTreeNode_Message = objTreeNode_Messages.Nodes.Add(objDR_Message.Item("GUID_Token_Right").ToString, objDR_Message.Item("Name_Token_Right"), intImageID, intImageID)
            objTreeNode_Caption = objTreeNode_Message.Nodes.Add(objLocalConfig.SemItem_Attribute_caption.GUID.ToString & "_" & objTreeNode_Message.Name, objLocalConfig.SemItem_Attribute_caption.Name, cint_ImageID_Caption, cint_ImageID_Caption)
            objTreeNode_Description = objTreeNode_Message.Nodes.Add(objLocalConfig.SemItem_Attribute_Message.GUID.ToString & "_" & objTreeNode_Message.Name, objLocalConfig.SemItem_Attribute_Message.Name, cint_ImageID_Message, cint_ImageID_Message)

            boolFinished = get_CaptionDescription(objTreeNode_Caption, objDR_Message.Item("GUID_Token_Right"), True)
            objTreeNode_Caption.Expand()
            boolFinished = get_CaptionDescription(objTreeNode_Description, objDR_Message.Item("GUID_Token_Right"), False)
            objTreeNode_Description.Expand()
            If boolFinished = False Then
                intMessage_ToDo = intMessage_ToDo + 1
            End If
        Next

    End Sub
    Private Function get_CaptionDescription(ByVal objTreeNode As TreeNode, ByVal GUID_Message As Guid, ByVal boolCaption As Boolean) As Boolean
        Dim objDRs_CaptionsDescriptions() As DataRow
        Dim objTreeNode_MessageCaption As TreeNode
        Dim objSemItem_Language As clsSemItem
        Dim boolResult As Boolean

        If boolCaption = True Then
            procA_Caption_Of_Message.Fill(procT_Caption_Of_Message, _
                                      objLocalConfig.SemItem_Attribute_caption.GUID, _
                                      objLocalConfig.SemItem_Type_Messages.GUID, _
                                      objLocalConfig.SemItem_Type_Language.GUID, _
                                      objLocalConfig.SemItem_Type_Localized_Message.GUID, _
                                      objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                      GUID_Message)
        Else
            procA_Description_Of_Message.Fill(procT_Description_Of_Message, _
                                              objLocalConfig.SemItem_Attribute_Message.GUID, _
                                              objLocalConfig.SemItem_Type_Messages.GUID, _
                                              objLocalConfig.SemItem_Type_Language.GUID, _
                                              objLocalConfig.SemItem_Type_Localized_Message.GUID, _
                                              objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                              GUID_Message)
        End If

        boolResult = True
        For Each objSemItem_Language In objSemItems_Language
            If boolCaption = True Then
                objDRs_CaptionsDescriptions = procT_Caption_Of_Message.Select("GUID_Language='" & objSemItem_Language.GUID.ToString & "'")
                If objDRs_CaptionsDescriptions.Count = 1 Then
                    objTreeNode_MessageCaption = objTreeNode.Nodes.Add(objTreeNode.Name & "_" & objSemItem_Language.GUID.ToString, objSemItem_Language.Name, cint_ImageID_Language_Done, cint_ImageID_Language_Done)
                Else
                    objTreeNode_MessageCaption = objTreeNode.Nodes.Add(objTreeNode.Name & "_" & objSemItem_Language.GUID.ToString, objSemItem_Language.Name, cint_ImageID_Language_ToDo, cint_ImageID_Language_ToDo)
                    boolResult = False
                End If
            Else
                objDRs_CaptionsDescriptions = procT_Description_Of_Message.Select("GUID_Language='" & objSemItem_Language.GUID.ToString & "'")
                If objDRs_CaptionsDescriptions.Count = 1 Then
                    objTreeNode_MessageCaption = objTreeNode.Nodes.Add(objTreeNode.Name & "_" & objSemItem_Language.GUID.ToString, objSemItem_Language.Name, cint_ImageID_Language_Done, cint_ImageID_Language_Done)
                Else
                    objTreeNode_MessageCaption = objTreeNode.Nodes.Add(objTreeNode.Name & "_" & objSemItem_Language.GUID.ToString, objSemItem_Language.Name, cint_ImageID_Language_ToDo, cint_ImageID_Language_ToDo)
                    boolResult = False

                End If
            End If
            


        Next

        Return boolResult
    End Function

    
    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB

        procA_TokenAttribute_Varchar255.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_VarcharMax.Connection = objLocalConfig.Connection_DB

        procA_Caption_Of_Message.Connection = objLocalConfig.Connection_Plugin
        procA_Description_Of_Message.Connection = objLocalConfig.Connection_Plugin
        procA_LocalizedMessage_Of_Message_By_GUIDMessage_And_GUIDLanguage.Connection = objLocalConfig.Connection_Plugin

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHAR255.Connection = objLocalConfig.Connection_DB
        semprocA_DBwork_Save_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
    End Sub

    Private Sub ContextMenuStrip_Messages_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Messages.Opening
        Dim objTreeNode As TreeNode

        NewMessageToolStripMenuItem.Enabled = False
        CopyNameToolStripMenuItem.Enabled = False
        objTreeNode = TreeView_Messages.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Users Or _
                objTreeNode.ImageIndex = cint_ImageID_Inputs Or _
                objTreeNode.ImageIndex = cint_ImageID_Errors Then
                NewMessageToolStripMenuItem.Enabled = True
            End If
            If objTreeNode.ImageIndex = cint_ImageID_Error Or _
                objTreeNode.ImageIndex = cint_ImageID_User Or _
                objTreeNode.ImageIndex = cint_ImageID_Input Then
                CopyNameToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub NewMessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMessageToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objDRC_Messages As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim GUID_MessageExist As Guid
        Dim objSemItem_Message As New clsSemItem
        Dim boolNewMessage As Boolean
        Dim boolSave As Boolean

        objTreeNode = TreeView_Messages.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Users Or _
                objTreeNode.ImageIndex = cint_ImageID_Inputs Or _
                objTreeNode.ImageIndex = cint_ImageID_Errors Then
                objDlg_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Type_Messages.Name, objLocalConfig.Globals)
                objDlg_Attribute_VARCHAR255.ShowDialog(Me)
                If objDlg_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
                    objSemItem_Message.GUID = Guid.NewGuid
                    objSemItem_Message.Name = objDlg_Attribute_VARCHAR255.Value1.Replace("'", "_")
                    objSemItem_Message.GUID_Parent = objLocalConfig.SemItem_Type_Messages.GUID
                    objSemItem_Message.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    Select Case objTreeNode.ImageIndex
                        Case cint_ImageID_Users
                            objSemItem_Message.GUID_Relation = objLocalConfig.SemItem_RelationType_User_Message.GUID
                        Case cint_ImageID_Inputs
                            objSemItem_Message.GUID_Relation = objLocalConfig.SemItem_RelationType_Input_Message.GUID
                        Case cint_ImageID_Errors
                            objSemItem_Message.GUID_Relation = objLocalConfig.SemItem_RelationType_Error_Message.GUID

                    End Select

                    objDRC_Messages = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_Messages.GUID, objSemItem_Message.Name).Rows
                    boolSave = True
                    If objDRC_Messages.Count = 0 Then
                        boolNewMessage = True
                    Else
                        GUID_MessageExist = objDRC_Messages(0).Item("GUID_Token")
                        objDRC_Messages = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Development.GUID, objSemItem_Message.GUID_Relation, objLocalConfig.SemItem_Type_Messages.GUID).Rows
                        If objDRC_Messages.Count = 0 Then
                            If MsgBox("Es existiert bereits eine Meldung mit der Bezeichnung. Soll sie übernommen werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                objSemItem_Message.GUID = GUID_MessageExist
                                boolNewMessage = False
                            Else
                                boolNewMessage = True
                            End If
                        Else
                            boolSave = False
                            boolNewMessage = False
                        End If
                    End If


                    If boolNewMessage = True Then
                        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Message.GUID, objSemItem_Message.Name, objSemItem_Message.GUID_Parent, True).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            boolSave = True
                        Else
                            boolSave = False
                            MsgBox("Die Message konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If
                    End If

                    If boolSave = True Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development.GUID, objSemItem_Message.GUID, objSemItem_Message.GUID_Relation, 0).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            TreeView_Messages.Nodes.Clear()
                            fill_MessageView()
                        Else
                            MsgBox("Die Message konnte nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TreeView_Messages_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Messages.AfterSelect
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Parent As TreeNode
        Dim objTreeNode_Message As TreeNode
        Dim GUID_Message As Guid
        Dim GUID_Language As Guid
        Dim objDRC_Message As DataRowCollection


        TextBox_Description.ReadOnly = True
        TextBox_Description.Text = ""
        objTreeNode = TreeView_Messages.SelectedNode
        If Not objTreeNode Is Nothing Then
            
            If objTreeNode.ImageIndex = cint_ImageID_Language_Done Then

                GUID_Language = New Guid(objTreeNode.Name.Split("_")(2))

                objTreeNode_Parent = objTreeNode.Parent
                objTreeNode_Message = objTreeNode_Parent.Parent
                GUID_Message = New Guid(objTreeNode_Message.Name)

                If objTreeNode_Parent.ImageIndex = cint_ImageID_Caption Then

                    set_CaptionDescription(GUID_Message, GUID_Language, objTreeNode_Message.Text, objTreeNode.Text, True)
                Else
                    set_CaptionDescription(GUID_Message, GUID_Language, objTreeNode_Message.Text, objTreeNode.Text, False)
                End If

            ElseIf objTreeNode.ImageIndex = cint_ImageID_Language_ToDo Then

                GUID_Language = New Guid(objTreeNode.Name.Split("_")(2))

                objTreeNode_Parent = objTreeNode.Parent
                objTreeNode_Message = objTreeNode_Parent.Parent
                GUID_Message = New Guid(objTreeNode_Message.Name)
                If objTreeNode_Parent.ImageIndex = cint_ImageID_Caption Then
                    set_CaptionDescription(GUID_Message, GUID_Language, objTreeNode_Message.Text, objTreeNode.Text, True)
                Else
                    set_CaptionDescription(GUID_Message, GUID_Language, objTreeNode_Message.Text, objTreeNode.Text, False)
                End If
            End If
        End If
    End Sub

    Private Sub set_CaptionDescription(ByVal _GUID_Message As Guid, ByVal _GUID_Language As Guid, ByVal Name_Message As String, ByVal Name_Language As String, ByVal boolCaption As Boolean)
        Dim objDRC_CaptionDescription As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim boolShow As Boolean


        objDRC_CaptionDescription = procA_LocalizedMessage_Of_Message_By_GUIDMessage_And_GUIDLanguage.GetData(objLocalConfig.SemItem_Type_Messages.GUID, _
                                                                                                              objLocalConfig.SemItem_Type_Localized_Message.GUID, _
                                                                                                              objLocalConfig.SemItem_Type_Language.GUID, _
                                                                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                                              objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                                                                              _GUID_Message, _
                                                                                                              _GUID_Language).Rows



        
        If objDRC_CaptionDescription.Count = 0 Then

            objSemItem_LocalizedMessage.GUID = Guid.NewGuid
            objSemItem_LocalizedMessage.Name = Name_Message & "(" & Name_Language & ")"
            If objSemItem_LocalizedMessage.Name.Length > 255 Then
                objSemItem_LocalizedMessage.Name = objSemItem_LocalizedMessage.Name.Substring(0, 99) & "..." & objSemItem_LocalizedMessage.Name.Substring(objSemItem_LocalizedMessage.Name.Length - 100, 100)
            End If
            objSemItem_LocalizedMessage.GUID_Parent = objLocalConfig.SemItem_Type_Localized_Message.GUID
            objSemItem_LocalizedMessage.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_LocalizedMessage.Additional1 = ""
            objSemItem_LocalizedMessage.new_Item = True

            If boolCaption = True Then
                GUID_Attribute = objLocalConfig.SemItem_Attribute_caption.GUID
            Else
                GUID_Attribute = objLocalConfig.SemItem_Attribute_Message.GUID
            End If
            GUID_TokenAttribute = Nothing
            GUID_Message = _GUID_Message
            GUID_Language = _GUID_Language
            boolNew_Caption = True
            boolNew_Message = True


        Else

            objSemItem_LocalizedMessage.GUID = objDRC_CaptionDescription(0).Item("GUID_Localized_Message")
            objSemItem_LocalizedMessage.Name = objDRC_CaptionDescription(0).Item("Name_Localized_Message")
            objSemItem_LocalizedMessage.GUID_Parent = objLocalConfig.SemItem_Type_Localized_Message.GUID
            objSemItem_LocalizedMessage.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            If boolCaption = True Then
                objDRC_CaptionDescription = procA_TokenAttribute_Varchar255.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_LocalizedMessage.GUID, objLocalConfig.SemItem_Attribute_caption.GUID).Rows
                If objDRC_CaptionDescription.Count = 0 Then
                    GUID_TokenAttribute = Nothing
                    objSemItem_LocalizedMessage.Additional1 = ""
                    boolNew_Caption = True
                Else
                    boolNew_Caption = False
                    objSemItem_LocalizedMessage.Additional1 = objDRC_CaptionDescription(0).Item("Val")
                    GUID_TokenAttribute = objDRC_CaptionDescription(0).Item("GUID_TokenAttribute")
                End If


            Else
                objDRC_CaptionDescription = procA_TokenAttribute_VarcharMax.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_LocalizedMessage.GUID, objLocalConfig.SemItem_Attribute_Message.GUID).Rows
                If objDRC_CaptionDescription.Count = 0 Then
                    boolNew_Message = True
                    GUID_TokenAttribute = Nothing
                    objSemItem_LocalizedMessage.Additional1 = ""
                Else
                    boolNew_Message = False
                    objSemItem_LocalizedMessage.Additional1 = objDRC_CaptionDescription(0).Item("Val")
                    GUID_TokenAttribute = objDRC_CaptionDescription(0).Item("GUID_TokenAttribute")
                End If
            End If


            If boolCaption = True Then
                GUID_Attribute = objLocalConfig.SemItem_Attribute_caption.GUID
            Else
                GUID_Attribute = objLocalConfig.SemItem_Attribute_Message.GUID
            End If

            GUID_Message = _GUID_Message
            GUID_Language = _GUID_Language


        End If

        TextBox_Description.ReadOnly = True
        TextBox_Description.Text = objSemItem_LocalizedMessage.Additional1
        If boolCaption = True Then
            TextBox_Description.MaxLength = 255
        Else
            TextBox_Description.MaxLength = 32767
        End If
        TextBox_Description.ReadOnly = False
    End Sub

    Private Sub TextBox_Description_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Description.TextChanged
        Timer_Description.Stop()
        If TextBox_Description.ReadOnly = False Then
            Timer_Description.Start()

        End If
    End Sub

    Private Sub Timer_Description_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Description.Tick
        Dim objDRC_TokenAttribute As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objTreeNode As TreeNode
        Dim boolSaved_Attribute As Boolean
        Dim boolErr As Boolean
        Timer_Description.Stop()

        objTreeNode = TreeView_Messages.SelectedNode
        strCaptionDescription = TextBox_Description.Text
        boolErr = False
        If objSemItem_LocalizedMessage.new_Item = True Then

            If Save_001_LocalizedMessage() = True Then
                If Save_002_LocalizedMessage_To_Language() = True Then
                    If Save_004_Message_To_LocalizedMessage() = False Then
                        del_002_LocalizedMessage_To_Language()
                        del_001_LocalizedMessage()
                        If GUID_Attribute = objLocalConfig.SemItem_Attribute_caption.GUID Then
                            MsgBox("Die Caption kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        Else

                            MsgBox("Die Message kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If
                        boolErr = True
                    End If
                Else

                    del_001_LocalizedMessage()
                    If GUID_Attribute = objLocalConfig.SemItem_Attribute_caption.GUID Then
                        MsgBox("Die Caption kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    Else

                        MsgBox("Die Message kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    End If
                    boolErr = True
                End If
            Else
                If GUID_Attribute = objLocalConfig.SemItem_Attribute_caption.GUID Then
                    MsgBox("Die Caption kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                Else

                    MsgBox("Die Message kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If
                boolErr = True
            End If

        End If

        If boolErr = False Then
            If GUID_Attribute = objLocalConfig.SemItem_Attribute_caption.GUID Then
                boolSaved_Attribute = save_003a_LocalizedMessage__Caption()
            Else
                boolSaved_Attribute = save_003b_LocalizedMessage__Message()
            End If
            If boolSaved_Attribute = True Then
                objSemItem_LocalizedMessage.new_Item = False
                objSemItem_LocalizedMessage.Additional1 = strCaptionDescription
                objTreeNode.ImageIndex = cint_ImageID_Language_Done
                objTreeNode.SelectedImageIndex = cint_ImageID_Language_Done
            Else

                If GUID_Attribute = objLocalConfig.SemItem_Attribute_caption.GUID Then
                    MsgBox("Die Caption kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Die Message kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)

                End If
                TextBox_Description.ReadOnly = True
                TextBox_Description.Text = objSemItem_LocalizedMessage.Additional1
                TextBox_Description.ReadOnly = False

            End If
        Else
            TextBox_Description.ReadOnly = True
            TextBox_Description.Text = ""

        End If
    End Sub

    Private Function Save_001_LocalizedMessage() As Boolean
        Dim objDRC_logState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_logState = semprocA_DBWork_Save_Token.GetData(objSemItem_LocalizedMessage.GUID, objSemItem_LocalizedMessage.Name, objSemItem_LocalizedMessage.GUID_Parent, True).Rows
        If objDRC_logState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function
    Private Function del_001_LocalizedMessage() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_LocalizedMessage.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult

    End Function
    Private Function Save_002_LocalizedMessage_To_Language() As Boolean
        Dim objDRC_logState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_logState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_LocalizedMessage.GUID, GUID_Language, objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, 0).Rows
        If objDRC_logState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then

            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Private Function del_002_LocalizedMessage_To_Language() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_LocalizedMessage.GUID, GUID_Language, objLocalConfig.SemItem_RelationType_isWrittenIn.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Private Function save_003a_LocalizedMessage__Caption() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        If Not strCaptionDescription = objSemItem_LocalizedMessage.Additional1 Then
            If boolNew_Caption = True Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_LocalizedMessage.GUID, objLocalConfig.SemItem_Attribute_caption.GUID, Nothing, strCaptionDescription, 0).Rows
            Else
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(objSemItem_LocalizedMessage.GUID, objLocalConfig.SemItem_Attribute_caption.GUID, GUID_TokenAttribute, strCaptionDescription, 0).Rows
            End If

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                boolNew_Caption = False
                GUID_TokenAttribute = objDRC_LogState(0).Item("GUID_TokenAttribute")
                boolResult = True
            Else
                boolResult = False
            End If
        Else
            boolResult = True
        End If
        

        Return boolResult
    End Function

    Private Function del_003a_LocalizedMessage__Caption() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Private Function save_003b_LocalizedMessage__Message() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean
        If Not strCaptionDescription = objSemItem_LocalizedMessage.Additional1 Then
            If boolNew_Message = True Then
                objDRC_LogState = semprocA_DBwork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_LocalizedMessage.GUID, objLocalConfig.SemItem_Attribute_Message.GUID, Nothing, strCaptionDescription, 0).Rows
            Else
                objDRC_LogState = semprocA_DBwork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_LocalizedMessage.GUID, objLocalConfig.SemItem_Attribute_Message.GUID, GUID_TokenAttribute, strCaptionDescription, 0).Rows
            End If

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                boolNew_Message = False
                GUID_TokenAttribute = objDRC_LogState(0).Item("GUID_TokenAttribute")
                boolResult = True
            Else
                boolResult = False
            End If
        Else
            boolResult = True
        End If
        

        Return boolResult
    End Function

    Private Function del_003b_LocalizedMessage__Message() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Private Function Save_004_Message_To_LocalizedMessage() As Boolean
        Dim objDRC_logState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_logState = semprocA_DBWork_Save_TokenRel.GetData(GUID_Message, objSemItem_LocalizedMessage.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
        If objDRC_logState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Private Function del_004_Message_To_LocalizedMessage() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(GUID_Message, objSemItem_LocalizedMessage.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Private Sub CopyNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyNameToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        
        objTreeNode = TreeView_Messages.SelectedNode
        If Not objTreeNode Is Nothing Then
        
            If objTreeNode.ImageIndex = cint_ImageID_Error Or _
               objTreeNode.ImageIndex = cint_ImageID_User Or _
               objTreeNode.ImageIndex = cint_ImageID_Input Then
                Clipboard.SetDataObject(objTreeNode.Text)
            End If
        End If
    End Sub
End Class
