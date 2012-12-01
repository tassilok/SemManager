Imports Sem_Manager
Public Class UserControl_Localized
    Private Const cint_ImageID_Language_Standard As Integer = 0
    Private Const cint_ImageID_Language As Integer = 1
    Private Const cint_ImageID_Language_Standard_ToDo As Integer = 2
    Private Const cint_ImageID_Language_Standard_Done As Integer = 3
    Private Const cint_ImageID_Language_ToDo As Integer = 4
    Private Const cint_ImageID_Language_Done As Integer = 5
    Private Const cint_ImageID_LocalizedNames_Root As Integer = 6
    Private Const cint_ImageID_LocalizedNames_ToDo As Integer = 7
    Private Const cint_ImageID_LocalizedNames_Done As Integer = 8
    Private Const cint_ImageID_LocalizedName As Integer = 9

    Private funcA_Describing_LocalizedDescription As New ds_LocalizeTableAdapters.func_Describing_LocalizedDescriptionTableAdapter
    Private funcT_Describing_LocalizedDescription As New ds_Localize.func_Describing_LocalizedDescriptionDataTable
    Private funcA_Alternative_LocalizedNames As New ds_LocalizeTableAdapters.func_Alternative_LocalizedNamesTableAdapter
    Private funcT_Alternative_LocalizedNames As New ds_Localize.func_Alternative_LocalizedNamesDataTable
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter

    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_Token_Attribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter

    Private objDLG_Attribute_VARCHAR255 As dlgAttribute_Varchar255

    Private objSemItems_Languages() As clsSemItem
    Private objSemItem_Related As clsSemItem
    Private objSemItem_SelectedDescription As New clsSemItem

    Private strMessage As String
    Private boolProgChange_Description As Boolean
    Private boolLocalizedNames As Boolean

    Public Sub clear_LanguageTree()
        TextBox_Description.ReadOnly = True
        boolProgChange_Description = True
        TextBox_Description.Clear()
        boolProgChange_Description = False
        TreeView_Description.Nodes.Clear()
    End Sub
    Private Sub fill_LocalizedNames()
        Dim objSemItem_Language As clsSemItem
        Dim objTreeNode_LocalizedNamesRoot As TreeNode
        Dim objTreeNode_localizedName As TreeNode
        Dim objDRs_LocalizedNames() As DataRow
        If Not objSemItem_Related Is Nothing Then
            If Not objSemItems_Languages Is Nothing Then
                objTreeNode_LocalizedNamesRoot = TreeView_Description.Nodes.Add(objLocalConfig.SemItem_Type_Localized_Names.GUID.ToString, objLocalConfig.SemItem_Type_Localized_Names.Name, cint_ImageID_LocalizedNames_Root, cint_ImageID_LocalizedNames_Root)

                funcA_Alternative_LocalizedNames.Fill_By_GUIDRef(funcT_Alternative_LocalizedNames, _
                                                      objLocalConfig.SemItem_Type_Localized_Names.GUID, _
                                                      objLocalConfig.SemItem_Type_Language.GUID, _
                                                      objLocalConfig.SemItem_RelationType_alternative_for.GUID, _
                                                      objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                      objSemItem_Related.GUID)

                For Each objSemItem_Language In objSemItems_Languages
                    If objSemItem_Language.Mark = False Then
                        
                        objDRs_LocalizedNames = funcT_Alternative_LocalizedNames.Select("GUID_Token_Language='" & objSemItem_Language.GUID.ToString & "'")
                        If objDRs_LocalizedNames.Count = 0 Then
                            objTreeNode_localizedName = objTreeNode_LocalizedNamesRoot.Nodes.Add(objSemItem_Language.GUID.ToString, objSemItem_Language.Name, cint_ImageID_LocalizedNames_ToDo, cint_ImageID_LocalizedNames_ToDo)
                        Else
                            objTreeNode_localizedName = objTreeNode_LocalizedNamesRoot.Nodes.Add(objSemItem_Language.GUID.ToString, objSemItem_Language.Name, cint_ImageID_LocalizedNames_Done, cint_ImageID_LocalizedNames_Done)
                            objTreeNode_localizedName.Nodes.Add(objDRs_LocalizedNames(0).Item("GUID_Token").ToString, objDRs_LocalizedNames(0).Item("Name_Token"), cint_ImageID_LocalizedName, cint_ImageID_LocalizedName)
                        End If
                    End If
                    


                Next
            End If
        End If
    End Sub
    Private Sub fill_LanguageTree()
        Dim objSemItem_Language As clsSemItem
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Parent As TreeNode
        Dim objDRs_Message() As DataRow
        Dim boolStandard As Boolean

        clear_LanguageTree()
        If boolLocalizedNames = True Then
            fill_LocalizedNames()
        End If
        If Not objSemItem_Related Is Nothing Then

            If Not objSemItems_Languages Is Nothing Then
                funcA_Describing_LocalizedDescription.Fill_By_GUID_Token(funcT_Describing_LocalizedDescription, _
                                                                         objLocalConfig.SemItem_Attribute_Message.GUID, _
                                                                         objLocalConfig.SemItem_Type_LocalizedDescription.GUID, _
                                                                         objLocalConfig.SemItem_Type_Language.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_describes.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                                         objSemItem_Related.GUID)
                For Each objSemItem_Language In objSemItems_Languages
                    If objSemItem_Language.Mark = True Then
                        boolStandard = True
                        objTreeNodes = TreeView_Description.Nodes.Find(objLocalConfig.SemItem_RelationType_Standard.GUID.ToString, False)
                        If objTreeNodes.Length = 0 Then
                            objTreeNode_Parent = TreeView_Description.Nodes.Add(objLocalConfig.SemItem_RelationType_Standard.GUID.ToString, objLocalConfig.SemItem_RelationType_Standard.Name, cint_ImageID_Language_Standard, cint_ImageID_Language_Standard)
                        Else
                            objTreeNode_Parent = objTreeNodes(0)
                        End If

                    Else
                        boolStandard = False
                        objTreeNodes = TreeView_Description.Nodes.Find(objLocalConfig.SemItem_RelationType_additional.GUID.ToString, False)
                        If objTreeNodes.Length = 0 Then
                            objTreeNode_Parent = TreeView_Description.Nodes.Add(objLocalConfig.SemItem_RelationType_additional.GUID.ToString, objLocalConfig.SemItem_RelationType_additional.Name, cint_ImageID_Language, cint_ImageID_Language)
                        Else
                            objTreeNode_Parent = objTreeNodes(0)
                        End If

                    End If
                    objDRs_Message = funcT_Describing_LocalizedDescription.Select("GUID_Token_Language='" & objSemItem_Language.GUID.ToString & "'")
                    If objDRs_Message.Count > 0 Then

                        If boolStandard = True Then
                            objTreeNode_Parent.Nodes.Add(objSemItem_Language.GUID.ToString, objSemItem_Language.Name, cint_ImageID_Language_Standard_Done, cint_ImageID_Language_Standard_Done)
                        Else
                            objTreeNode_Parent.Nodes.Add(objSemItem_Language.GUID.ToString, objSemItem_Language.Name, cint_ImageID_Language_Done, cint_ImageID_Language_Done)
                        End If

                    Else
                        If boolStandard = True Then
                            objTreeNode_Parent.Nodes.Add(objSemItem_Language.GUID.ToString, objSemItem_Language.Name, cint_ImageID_Language_Standard_ToDo, cint_ImageID_Language_Standard_ToDo)
                        Else
                            objTreeNode_Parent.Nodes.Add(objSemItem_Language.GUID.ToString, objSemItem_Language.Name, cint_ImageID_Language_ToDo, cint_ImageID_Language_ToDo)

                        End If
                    End If
                Next
            End If

        End If

        TreeView_Description.ExpandAll()
    End Sub

    

    Private Sub TextBox_Description_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Description.TextChanged
        Timer_Description.Stop()
        If boolProgChange_Description = False Then
            Timer_Description.Start()
        End If
    End Sub

    

    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        funcA_Describing_LocalizedDescription.Connection = objLocalConfig.Connection_Plugin
        funcA_Alternative_LocalizedNames.Connection = objLocalConfig.Connection_Plugin

        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_Attribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB
    End Sub

    Public Sub initialize(ByVal SemItem_Related As clsSemItem, ByVal SemItems_Language() As clsSemItem, ByVal LocalizedNames As Boolean)
        boolLocalizedNames = LocalizedNames
        objSemItems_Languages = SemItems_Language
        objSemItem_Related = SemItem_Related

        fill_LanguageTree()
    End Sub


    Private Sub TreeView_Description_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Description.AfterSelect
        Dim objTreeNode_SelectedLanguage As TreeNode
        Dim objDRs_Description() As DataRow

        boolProgChange_Description = True
        TextBox_Description.ReadOnly = True
        TextBox_Description.Clear()
        boolProgChange_Description = False
        objTreeNode_SelectedLanguage = TreeView_Description.SelectedNode
        If Not objTreeNode_SelectedLanguage Is Nothing Then
            Select Case objTreeNode_SelectedLanguage.ImageIndex
                Case cint_ImageID_Language_Standard_ToDo, cint_ImageID_Language_Standard_Done, cint_ImageID_Language_ToDo, cint_ImageID_Language_Done
                    objSemItem_SelectedDescription.GUID = objSemItem_Related.GUID
                    objSemItem_SelectedDescription.GUID_Related = New Guid(objTreeNode_SelectedLanguage.Name)
                    objSemItem_SelectedDescription.GUID_Parent = objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID
                    objSemItem_SelectedDescription.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objDRs_Description = funcT_Describing_LocalizedDescription.Select("GUID_Token_Language='" & objTreeNode_SelectedLanguage.Name & "'")
                    If objDRs_Description.Count > 0 Then
                        objSemItem_SelectedDescription.GUID_Relation = objDRs_Description(0).Item("GUID_TokenAttribute_Message")
                        boolProgChange_Description = True
                        TextBox_Description.ReadOnly = False
                        TextBox_Description.Text = objDRs_Description(0).Item("Message")
                        strMessage = TextBox_Description.Text
                        boolProgChange_Description = False
                    Else
                        objSemItem_SelectedDescription.GUID_Relation = Nothing
                        objSemItem_SelectedDescription.new_Item = True
                        boolProgChange_Description = True
                        TextBox_Description.ReadOnly = False
                        TextBox_Description.Text = ""
                        strMessage = TextBox_Description.Text
                        boolProgChange_Description = False
                    End If
            End Select
        End If
    End Sub


    Private Sub Timer_Description_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Description.Tick
        Timer_Description.Stop()
        Dim objSemItem_LocalizedDescription_New As New clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim GUID_ObjectReference As Guid
        Dim strMessage_New As String

        strMessage_New = TextBox_Description.Text
        If Not strMessage_New = strMessage Then
            If objSemItem_SelectedDescription.new_Item = True Then
                objSemItem_LocalizedDescription_New.GUID = Guid.NewGuid
                If strMessage_New.Length > 251 Then
                    objSemItem_LocalizedDescription_New.Name = strMessage_New.Substring(0, 251) & "..."
                Else
                    objSemItem_LocalizedDescription_New.Name = strMessage_New
                End If

                objSemItem_LocalizedDescription_New.GUID_Parent = objLocalConfig.SemItem_Type_LocalizedDescription.GUID
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_LocalizedDescription_New.GUID, objSemItem_LocalizedDescription_New.Name, objSemItem_LocalizedDescription_New.GUID_Parent, True).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_LocalizedDescription_New.GUID, objSemItem_SelectedDescription.GUID_Related, objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        'Object-Reference
                        'objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Related.GUID, objSemItem_LocalizedDescription_New.GUID, objLocalConfig.SemItem_RelationType_isDescribedBy.GUID, 0).Rows
                        objDRC_LogState = procA_DBWork_Save_OR_Token.GetData(objSemItem_Related.GUID).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            GUID_ObjectReference = objDRC_LogState(0).Item("GUID_ObjectReference")
                            objDRC_LogState = semprocA_DBWork_Save_Token_OR.GetData(objSemItem_LocalizedDescription_New.GUID, GUID_ObjectReference, objLocalConfig.SemItem_RelationType_describes.GUID, 0).Rows

                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                objDRC_LogState = semprocA_DBWork_Save_Token_Attribute_VARCHARMAX.GetData(objSemItem_LocalizedDescription_New.GUID, objLocalConfig.SemItem_Attribute_Message.GUID, Nothing, strMessage_New, 0).Rows
                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                    objSemItem_SelectedDescription.GUID_Relation = objDRC_LogState(0).Item("GUID_TokenAttribute")
                                    objSemItem_SelectedDescription.new_Item = False
                                    objSemItem_SelectedDescription.Additional1 = strMessage_New
                                    funcA_Describing_LocalizedDescription.Fill_By_GUID_Token(funcT_Describing_LocalizedDescription, _
                                                          objLocalConfig.SemItem_Attribute_Message.GUID, _
                                                          objLocalConfig.SemItem_Type_LocalizedDescription.GUID, _
                                                          objLocalConfig.SemItem_Type_Language.GUID, _
                                                          objLocalConfig.SemItem_RelationType_isDescribedBy.GUID, _
                                                          objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                          objSemItem_Related.GUID)

                                Else

                                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Related.GUID, objSemItem_LocalizedDescription_New.GUID, objLocalConfig.SemItem_RelationType_isDescribedBy.GUID)
                                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_LocalizedDescription_New.GUID, objSemItem_Related.GUID_Related, objLocalConfig.SemItem_RelationType_isWrittenIn.GUID)
                                    semprocA_DBWork_Del_Token.GetData(objSemItem_LocalizedDescription_New.GUID)
                                    MsgBox("Die Beschreibung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                semprocA_DBWork_Del_TokenRel.GetData(objSemItem_LocalizedDescription_New.GUID, objSemItem_Related.GUID_Related, objLocalConfig.SemItem_RelationType_isWrittenIn.GUID)
                                semprocA_DBWork_Del_Token.GetData(objSemItem_LocalizedDescription_New.GUID)
                                MsgBox("Die Beschreibung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Die Beschreibung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If
                        
                    Else
                        semprocA_DBWork_Del_Token.GetData(objSemItem_LocalizedDescription_New.GUID)
                        MsgBox("Die Beschreibung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Die Beschreibung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If

            Else
                objDRC_LogState = semprocA_DBWork_Save_Token_Attribute_VARCHARMAX.GetData(objSemItem_LocalizedDescription_New.GUID, objLocalConfig.SemItem_Attribute_Message.GUID, objSemItem_SelectedDescription.GUID_Relation, strMessage_New, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Die Beschreibung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    clear_LanguageTree()
                End If
            End If
        End If
    End Sub
    
    Private Sub TreeView_Description_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView_Description.MouseDown
        Timer_Name.Stop()
        Timer_Name.Start()

    End Sub

    Private Sub TreeView_Description_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView_Description.MouseUp
        Timer_Name.Stop()
    End Sub

    Private Sub Timer_Name_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Name.Tick
        Dim objDRC_LogState As DataRowCollection
        Dim objTreeNode As TreeNode

        Timer_Name.Stop()

        objTreeNode = TreeView_Description.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_LocalizedName Then
                objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objTreeNode.Parent.Text, objLocalConfig.Globals, objTreeNode.Text)
                objDLG_Attribute_VARCHAR255.ShowDialog(Me)
                If objDLG_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
                    objDRC_LogState = semprocA_DBWork_Save_Token.GetData(New Guid(objTreeNode.Name), objDLG_Attribute_VARCHAR255.Value1, objLocalConfig.SemItem_Type_Localized_Names.GUID, True).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                        objTreeNode.Text = objDLG_Attribute_VARCHAR255.Value1
                    Else
                        MsgBox("Der alternative Name konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub ContextMenuStrip_localizedNames_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_localizedNames.Opening
        Dim objTreenode As TreeNode

        AddLocalizedNameToolStripMenuItem.Enabled = False

        objTreenode = TreeView_Description.SelectedNode
        If Not objTreenode Is Nothing Then
            If objTreenode.ImageIndex = cint_ImageID_LocalizedNames_ToDo Then
                AddLocalizedNameToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub AddLocalizedNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddLocalizedNameToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objDRs_LocalizedNames() As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim GUID_LocalizedName As Guid
        Dim GUID_ObjectReference As Guid

        objTreeNode = TreeView_Description.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_LocalizedNames_ToDo Then
                funcA_Alternative_LocalizedNames.Fill_By_GUIDRef(funcT_Alternative_LocalizedNames, _
                                                             objLocalConfig.SemItem_Type_Localized_Names.GUID, _
                                                             objLocalConfig.SemItem_Type_Language.GUID, _
                                                             objLocalConfig.SemItem_RelationType_alternative_for.GUID, _
                                                             objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                             objSemItem_Related.GUID)
                objDRs_LocalizedNames = funcT_Alternative_LocalizedNames.Select("GUID_Token_Language='" & objTreeNode.Name & "'")

                If objDRs_LocalizedNames.Length = 0 Then
                    objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objTreeNode.Text, objLocalConfig.Globals)
                    objDLG_Attribute_VARCHAR255.ShowDialog(Me)
                    If objDLG_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
                        GUID_LocalizedName = Guid.NewGuid
                        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(GUID_LocalizedName, objDLG_Attribute_VARCHAR255.Value1, objLocalConfig.SemItem_Type_Localized_Names.GUID, True).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(GUID_LocalizedName, New Guid(objTreeNode.Name), objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, 0).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                objDRC_LogState = procA_DBWork_Save_OR_Token.GetData(objSemItem_Related.GUID).Rows
                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                    GUID_ObjectReference = objDRC_LogState(0).Item("GUID_ObjectReference")
                                    objDRC_LogState = semprocA_DBWork_Save_Token_OR.GetData(GUID_LocalizedName, GUID_ObjectReference, objLocalConfig.SemItem_RelationType_alternative_for.GUID, 0).Rows
                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                        objTreeNode.Nodes.Add(GUID_LocalizedName.ToString, objDLG_Attribute_VARCHAR255.Value1, cint_ImageID_LocalizedName, cint_ImageID_LocalizedName)
                                        objTreeNode.ImageIndex = cint_ImageID_LocalizedNames_Done
                                    Else
                                        semprocA_DBWork_Del_TokenRel.GetData(GUID_LocalizedName, New Guid(objTreeNode.Name), objLocalConfig.SemItem_RelationType_isWrittenIn.GUID)
                                        semprocA_DBWork_Del_Token.GetData(GUID_LocalizedName)
                                        MsgBox("Der alternative Name konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    semprocA_DBWork_Del_Token.GetData(GUID_LocalizedName)
                                    MsgBox("Der alternative Name konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                End If
                                
                            Else
                                semprocA_DBWork_Del_Token.GetData(GUID_LocalizedName)
                                MsgBox("Der alternative Name konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If

                        Else
                            MsgBox("Der alternative Name konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Else
                    MsgBox("Die Datenbasis hat sich geändert!", MsgBoxStyle.Exclamation)
                    fill_LanguageTree()
                End If
            End If


        End If
    End Sub
End Class
