Imports Sem_Manager
Imports MediaViewer_Module
Imports HTMLExport_Module
Public Class UserControl_Process

    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Process As Integer = 1

    Private _dragdropCopy As Boolean = False
    Private _dragEventArgs As DragEventArgs
    Private _mouseButton As MouseButtons

    Private objLocalConfig As clsLocalConfig

    Private WithEvents objUserControl_References As UserControl_References
    Private WithEvents objUserControl_Image As UserControl_Galery

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private procA_Processes_Public As New ds_ProcessTableAdapters.proc_Processes_PublicTableAdapter
    Private procA_TokenToken_LeftRight_Tree As New ds_TokenTableAdapters.proc_TokenToken_LeftRight_TreeTableAdapter
    Private procT_TokenToken_LeftRight_Tree As New ds_Token.proc_TokenToken_LeftRight_TreeDataTable
    Private procA_get_new_Position_Process As New ds_ProcessTableAdapters.proc_get_new_Position_ProcessTableAdapter
    Private procA_supported_Languages As New ds_ProcessTableAdapters.proc_supported_LanguagesTableAdapter
    Private objTreeNode_Root As TreeNode
    Private objTreeNodes_Found() As TreeNode
    Private objTreeNode_Selected As TreeNode
    Private strPath_Node As String

    Private objFrm_TokenEdit As frmTokenEdit
    Private objFrmProcessModule As frmProcessModule
    Private objImageWork As clsImageInfo
    Private objDlgAttribute_VARCHAR255 As dlgAttribute_Varchar255
    Private objTransaction_Process As clsTransaction_Process
    Private objThread_Process As Threading.Thread

    Private objHTMLCreation As clsHTMLCreation

    Private objSemItem_Result As clsSemItem
    Private objSemItems_Language() As clsSemItem


    Private boolDo_Read_Process As Boolean
    Private boolMark As Boolean
    Private intRowID_Process As Integer
    Private intCount_Public As Integer
    Private intCount_Nodes As Integer
    Private intCount_Nodes_Done As Integer
    Private intID_Node As Integer
    Private strHTML_List As String
    Private strHTML_Processes As String

    Private boolPChange_Process As Boolean

    Public Event readed_Items(ByVal intCount As Integer, ByVal intDone As Integer)
    Public Event finished_reading()
    Public Event Applied_Process(ByVal objSemItem_Process As clsSemItem)

    Public Property applyable
        Get
            Return ApplyToolStripMenuItem.Visible
        End Get
        Set(ByVal value)
            ApplyToolStripMenuItem.Visible = value
        End Set
    End Property

    Public ReadOnly Property SemItem_Result As clsSemItem
        Get
            Return objSemItem_Result

        End Get
    End Property

    Public Sub abort_Threads()
        Try
            Timer_Process.Stop()
            objThread_Process.Abort()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Public Sub fill_Processes()
        boolPChange_Process = True
        procT_TokenToken_LeftRight_Tree.Clear()
        TreeView_Process.Nodes.Clear()
        objTreeNode_Root = TreeView_Process.Nodes.Add(objLocalConfig.SemItem_Type_Process.GUID.ToString, objLocalConfig.SemItem_Type_Process.Name, cint_ImageID_Root, cint_ImageID_Root)
        boolDo_Read_Process = True
        intRowID_Process = 0
        intCount_Public = 0

        enableDisable_Buttons(False)

        Timer_Process.Start()
        objThread_Process = New Threading.Thread(AddressOf get_Processes)
        objThread_Process.Start()
    End Sub

    Private Sub enableDisable_Buttons(ByVal boolEnable As Boolean)
        If boolEnable = False Then
            intCount_Nodes_Done = 1
            intCount_Nodes = 0
            Timer_Mark.Stop()
        End If
        ToolStripTextBox_Mark.Enabled = boolEnable
        ToolStripButton_Clear.Enabled = boolEnable
        ToolStripButton_NextProcess.Enabled = boolEnable
        ToolStripButton_Correlation.Enabled = boolEnable
    End Sub

    Private Sub get_Processes()
        Dim objDRC_PublicProcesses As DataRowCollection
        Dim objDR_PublicProcesses As DataRow

        

        procA_TokenToken_LeftRight_Tree.ClearBeforeFill = False
        objDRC_PublicProcesses = procA_Processes_Public.GetData(objLocalConfig.SemItem_Attribute_Public.GUID, _
                                                                objLocalConfig.SemItem_Type_Process.GUID, _
                                                                Nothing).Rows
        intCount_Public = objDRC_PublicProcesses.Count
        For Each objDR_PublicProcesses In objDRC_PublicProcesses
            'objTreeView_Tmp.Nodes.Add(objDR_PublicProcesses.Item("GUID_Process").ToString, objDR_PublicProcesses.Item("Name_Process"), cint_ImageID_Process, cint_ImageID_Process)
            procT_TokenToken_LeftRight_Tree.Rows.Add(objDR_PublicProcesses.Item("GUID_Process"), _
                                                     objDR_PublicProcesses.Item("Name_Process"), _
                                                     objLocalConfig.SemItem_Type_Process.GUID, _
                                                     objLocalConfig.SemItem_Type_Process.GUID, _
                                                     0, 1)
            procA_TokenToken_LeftRight_Tree.Fill(procT_TokenToken_LeftRight_Tree, _
                                                 objDR_PublicProcesses.Item("GUID_Process"), _
                                                 objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                 objLocalConfig.SemItem_Type_Process.GUID, _
                                                 0, -1, 1)
            
        Next
        boolDo_Read_Process = False
    End Sub
    Private Sub initialize()

        set_DBConnection()
        objUserControl_References = New UserControl_References(objLocalConfig)
        objUserControl_References.Dock = DockStyle.Fill
        TabPage_References.Controls.Clear()
        TabPage_References.Controls.Add(objUserControl_References)

        get_SupportedLanguages()

    End Sub

    Private Sub get_SupportedLanguages()
        Dim objDRC_SupportedLanguages As DataRowCollection
        Dim objDR_SupportedLanguages As DataRow
        Dim i As Integer
        objDRC_SupportedLanguages = procA_supported_Languages.GetData(objLocalConfig.SemItem_Type_Module.GUID, _
                                                                      objLocalConfig.SemItem_Type_Language.GUID, _
                                                                      objLocalConfig.SemItem_Type_Process_Module.GUID, _
                                                                      objLocalConfig.SemItem_RelationType_offered_by.GUID, _
                                                                      objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                      objLocalConfig.SemItem_RelationType_isDescribedBy.GUID, _
                                                                      objLocalConfig.SemItem_Development.GUID).Rows
        If objDRC_SupportedLanguages.Count > 0 Then
            ReDim Preserve objSemItems_Language(objDRC_SupportedLanguages.Count - 1)
            For i = 0 To objDRC_SupportedLanguages.Count - 1
                objSemItems_Language(i) = New clsSemItem
                objSemItems_Language(i).GUID = objDRC_SupportedLanguages(i).Item("GUID_Language")
                objSemItems_Language(i).Name = objDRC_SupportedLanguages(i).Item("Name_Language")
                objSemItems_Language(i).GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
                objSemItems_Language(i).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


            Next
        Else
            objSemItems_Language = Nothing
        End If

    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        procA_Processes_Public.Connection = objLocalConfig.Connection_Plugin
        procA_TokenToken_LeftRight_Tree.Connection = objLocalConfig.Connection_DB
        procA_get_new_Position_Process.Connection = objLocalConfig.Connection_Plugin

        procA_supported_Languages.Connection = objLocalConfig.Connection_Plugin

        objTransaction_Process = New clsTransaction_Process(objLocalConfig)
        objHTMLCreation = New clsHTMLCreation(objLocalConfig.Globals, Nothing, Me)

        objImageWork = New clsImageInfo(objLocalConfig.Globals)
    End Sub

    Private Sub Timer_Process_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Process.Tick
        Dim dateStart As Date
        Dim objDR_ChildrenProcesses As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode As TreeNode

        ToolStripLabel_ProcessCount.Text = procT_TokenToken_LeftRight_Tree.Rows.Count

        If intRowID_Process < procT_TokenToken_LeftRight_Tree.Rows.Count Then
            dateStart = Now
            While (Now - dateStart).Milliseconds < 200 And intRowID_Process < procT_TokenToken_LeftRight_Tree.Rows.Count
                objDR_ChildrenProcesses = procT_TokenToken_LeftRight_Tree.Rows(intRowID_Process)
                objTreeNodes = TreeView_Process.Nodes.Find(objDR_ChildrenProcesses.Item("GUID_Token_Parent").ToString, True)
                If objTreeNodes.Count > 0 Then
                    objTreeNodes(0).Nodes.Add(objDR_ChildrenProcesses.Item("GUID_Token").ToString, _
                                              objDR_ChildrenProcesses.Item("Name_Token"), cint_ImageID_Process, cint_ImageID_Process)

                End If
                intRowID_Process = intRowID_Process + 1
            End While
            RaiseEvent readed_Items(procT_TokenToken_LeftRight_Tree.Rows.Count, intRowID_Process)

        ElseIf intRowID_Process >= procT_TokenToken_LeftRight_Tree.Rows.Count And boolDo_Read_Process = False Then
            RaiseEvent finished_reading()
            objTreeNode_Root.Expand()
            Timer_Process.Stop()
            intCount_Nodes = procT_TokenToken_LeftRight_Tree.Rows.Count
            If Not objTreeNode_Selected Is Nothing Then
                objTreeNodes = TreeView_Process.Nodes.Find(objTreeNode_Selected.Name, True)
                For Each objTreeNode In objTreeNodes
                    If objTreeNode.FullPath.ToLower = strPath_Node.ToLower Then
                        TreeView_Process.SelectedNode = objTreeNode
                    End If
                Next
            End If
            boolPChange_Process = False
            enableDisable_Buttons(True)
        End If
    End Sub

    Private Sub ToolStripTextBox_Mark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Mark.Click

    End Sub

    Private Sub ToolStripTextBox_Mark_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Mark.TextChanged
        Timer_Mark.Stop()
        objTreeNodes_Found = Nothing
        intID_Node = 0
        ToolStripButton_NextProcess.Enabled = False
        If ToolStripTextBox_Mark.Text.Length > 0 Then
            Timer_Mark.Start()
        End If
    End Sub

    Private Sub demark_Nodes(Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode
        If objTreeNode Is Nothing Then
            For Each objTreeNode_Sub In TreeView_Process.Nodes
                objTreeNode_Sub.BackColor = Nothing
                demark_Nodes(objTreeNode_Sub)
            Next
        Else
            For Each objTreeNode_Sub In objTreeNode.Nodes
                objTreeNode_Sub.BackColor = Nothing
                demark_Nodes(objTreeNode_Sub)
            Next
        End If
    End Sub



    Private Sub Timer_Mark_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Mark.Tick
        Dim strSearch As String
        Timer_Mark.Stop()
        demark_Nodes()

        strSearch = ToolStripTextBox_Mark.Text.ToLower
        get_Nodes(strSearch)
        If Not objTreeNodes_Found Is Nothing Then
            If objTreeNodes_Found.Count > 0 Then
                TreeView_Process.SelectedNode = objTreeNodes_Found(intID_Node)
                TreeView_Process.Select()
                ToolStripButton_NextProcess.Enabled = True
            Else
                MsgBox("Es wurde kein Prozess gefunden!", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Es wurde kein Prozess gefunden!", MsgBoxStyle.Exclamation)
        End If
        
    End Sub

    Private Sub get_Nodes(ByVal strSearch As String, Optional ByVal objTreeNode_Start As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode
        Dim intCount As Integer
        If objTreeNode_Start Is Nothing Then
            For Each objTreeNode_Sub In TreeView_Process.Nodes
                If objTreeNode_Sub.Text.ToLower.Contains(strSearch) Then
                    If objTreeNodes_Found Is Nothing Then
                        intCount = 0
                        ReDim Preserve objTreeNodes_Found(intCount)

                    Else
                        intCount = objTreeNodes_Found.Length
                        ReDim Preserve objTreeNodes_Found(intCount)
                    End If
                    objTreeNodes_Found(intCount) = objTreeNode_Sub
                End If
                get_Nodes(strSearch, objTreeNode_Sub)
            Next
        Else
            For Each objTreeNode_Sub In objTreeNode_Start.Nodes
                If objTreeNode_Sub.Text.ToLower.Contains(strSearch) Then
                    If objTreeNodes_Found Is Nothing Then
                        intCount = 0
                        ReDim Preserve objTreeNodes_Found(intCount)

                    Else
                        intCount = objTreeNodes_Found.Length
                        ReDim Preserve objTreeNodes_Found(intCount)
                    End If
                    objTreeNodes_Found(intCount) = objTreeNode_Sub
                End If
                get_Nodes(strSearch, objTreeNode_Sub)
            Next
        End If
    End Sub


    Private Sub ToolStripButton_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Clear.Click
        ToolStripTextBox_Mark.Clear()
    End Sub

    Private Sub ToolStripButton_NextProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_NextProcess.Click
        Dim strSearch As String
        strSearch = ToolStripTextBox_Mark.Text
        If Not objTreeNodes_Found Is Nothing Then
            If intID_Node >= objTreeNodes_Found.Length - 1 Then
                MsgBox("Sie haben den letzten Prozess erreicht! Der erste gefundene wird wieder markiert!", MsgBoxStyle.Information)
                intID_Node = 0
            Else
                intID_Node = intID_Node + 1
            End If
            TreeView_Process.SelectedNode = objTreeNodes_Found(intID_Node)
            TreeView_Process.Select()
        End If
    End Sub

    Private Sub TreeView_Process_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Process.AfterSelect

        If boolPChange_Process = False Then
            objUserControl_References.clear_Nodes()
            Dim objTreeNode As TreeNode
            Dim objSemItem_Process As New clsSemItem
            objTreeNode = TreeView_Process.SelectedNode
            If Not objTreeNode Is Nothing Then
                If objTreeNode.ImageIndex = cint_ImageID_Process Then
                    objSemItem_Process.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Process.Name = objTreeNode.Text
                    objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                    objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    fill_TabPages(objSemItem_Process)

                    
                End If

            End If

        End If
    End Sub
    Private Sub fill_TabPages(ByVal objSemItem_Process As clsSemItem)
        Select Case TabControl1.SelectedTab.Name
            Case TabPage_Images.Name

                
                TabPage_Images.Controls.Clear()

                If Not objSemItem_Process Is Nothing Then
                    objUserControl_Image = New UserControl_Galery(objSemItem_Process, objSemItems_Language, objLocalConfig.Globals)
                    objUserControl_Image.Dock = DockStyle.Fill
                    TabPage_Images.Controls.Add(objUserControl_Image)
                End If

            Case TabPage_References.Name
                objUserControl_References.clear_Nodes()
                If Not objSemItem_Process Is Nothing Then
                    objUserControl_References.fill_Tree_Ref_Process(objSemItem_Process)
                End If

        End Select
    End Sub
    Private Sub TreeView_Process_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_Process.DoubleClick

        Dim objDRC_Process As DataRowCollection
        Dim objSemItem_Process As New clsSemItem


        objTreeNode_Selected = TreeView_Process.SelectedNode

        If Not objTreeNode_Selected Is Nothing Then
            If objTreeNode_Selected.ImageIndex = cint_ImageID_Process Then
                objSemItem_Process.GUID = New Guid(objTreeNode_Selected.Name)
                objSemItem_Process.Name = objTreeNode_Selected.Text
                objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objFrm_TokenEdit = New frmTokenEdit(objSemItem_Process, objLocalConfig.Globals)
                objFrm_TokenEdit.ShowDialog(Me)
                strPath_Node = objTreeNode_Selected.FullPath
                strPath_Node = strPath_Node.Substring(0, strPath_Node.Length - objTreeNode_Selected.Text.Length)
                objDRC_Process = semtblA_Token.GetData_Token_By_GUID(objSemItem_Process.GUID).Rows
                If objDRC_Process.Count > 0 Then
                    strPath_Node = strPath_Node & objDRC_Process(0).Item("Name_Token")
                End If
                fill_Processes()

            End If
        End If
    End Sub

    Private Sub expand_Parents(ByVal objTreeNode As TreeNode)
        Dim objTreeNode_Parent As TreeNode

        objTreeNode_Parent = objTreeNode.Parent
        If Not objTreeNode_Parent Is Nothing Then
            objTreeNode_Parent.Expand()
            expand_Parents(objTreeNode_Parent)
        End If
    End Sub

    Private Sub ContextMenuStrip_Process_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Process.Opening
        Dim objTreeNode As TreeNode

        NewToolStripMenuItem.Enabled = False
        ApplyToolStripMenuItem.Enabled = False
        CreateNewToolStripMenuItem.Enabled = False
        SelectExistingToolStripMenuItem.Enabled = False
        RemoveToolStripMenuItem.Enabled = False

        objTreeNode = TreeView_Process.SelectedNode
        If Not objTreeNode Is Nothing Then
            NewToolStripMenuItem.Enabled = True
            CreateNewToolStripMenuItem.Enabled = True
            SelectExistingToolStripMenuItem.Enabled = True
            If objTreeNode.ImageIndex = cint_ImageID_Process Then
                ExportHTMLToolStripMenuItem.Enabled = True
                ApplyToolStripMenuItem.Enabled = True
                RemoveToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Process.SelectedNode

        If Not objTreeNode Is Nothing Then
            objSemItem_Result = New clsSemItem
            objSemItem_Result.GUID = New Guid(objTreeNode.Name)
            objSemItem_Result.Name = objTreeNode.Text
            objSemItem_Result.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
            objSemItem_Result.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            RaiseEvent Applied_Process(objSemItem_Result)

        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        
    End Sub

    Private Sub CreateNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Process.SelectedNode
        If Not objTreeNode Is Nothing Then
            new_Process(True, objTreeNode)
        End If

    End Sub

    Private Sub new_Process(ByVal boolCreate As Boolean, ByVal objTreeNode As TreeNode)

        Dim objDRC_Process As DataRowCollection
        Dim objSemItem_Parent As New clsSemItem
        Dim objSemItem_Process As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objTreeNode_Sub As TreeNode
        Dim intOrderID As Integer
        
        Select Case objTreeNode.ImageIndex
            Case cint_ImageID_Root
                objSemItem_Parent = Nothing
            Case cint_ImageID_Process
                objSemItem_Parent.GUID = New Guid(objTreeNode.Name)
                objSemItem_Parent.Name = objTreeNode.Text
                objSemItem_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        End Select

        If boolCreate = True Then
            objDlgAttribute_VARCHAR255 = New dlgAttribute_Varchar255("New Process", objLocalConfig.Globals)
            objDlgAttribute_VARCHAR255.ShowDialog(Me)
            If objDlgAttribute_VARCHAR255.DialogResult = DialogResult.OK Then
                objSemItem_Process.GUID = Guid.NewGuid
                objSemItem_Process.Name = objDlgAttribute_VARCHAR255.Value1
                objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                If objSemItem_Parent Is Nothing Then
                    objDRC_Process = procA_Processes_Public.GetData(objLocalConfig.SemItem_Attribute_Public.GUID, _
                                                                    objLocalConfig.SemItem_Type_Process.GUID, _
                                                                    objSemItem_Process.Name).Rows
                    If objDRC_Process.Count = 0 Then
                        objSemItem_Result = objTransaction_Process.save_001_Process(objSemItem_Process)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Process.save_002_Process_Public(True)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTreeNode_Sub = objTreeNode.Nodes.Add(objSemItem_Process.GUID.ToString, _
                                                                        objSemItem_Process.Name, cint_ImageID_Process, cint_ImageID_Process)
                            Else
                                objTransaction_Process.del_001_Process()
                                MsgBox("Beim Speichern des Prozesses ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Beim Speichern des Prozesses ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                        End If


                    Else
                        MsgBox("Es existiert bereits ein Public-Prozess mit der Bezeichnung!", MsgBoxStyle.Exclamation)

                    End If
                Else
                    objDRC_Process = funcA_TokenToken.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(objSemItem_Parent.GUID, _
                                                                                                                       objSemItem_Process.Name, _
                                                                                                                       objLocalConfig.SemItem_Type_Process.GUID, _
                                                                                                                       objLocalConfig.SemItem_RelationType_superordinate.GUID).Rows
                    If objDRC_Process.Count = 0 Then
                        objSemItem_Result = objTransaction_Process.save_001_Process(objSemItem_Process)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Process.save_002_Process_Public(False)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                intOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_Parent.GUID, _
                                                                                             objLocalConfig.SemItem_Type_Process.GUID, _
                                                                                             objLocalConfig.SemItem_RelationType_superordinate.GUID)
                                intOrderID = intOrderID + 1
                                objSemItem_Result = objTransaction_Process.save_003_Process_To_Parent(objSemItem_Parent, _
                                                                                                      intOrderID)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objTreeNode_Sub = objTreeNode.Nodes.Add(objSemItem_Process.GUID.ToString, _
                                                                            objSemItem_Process.Name, cint_ImageID_Process, cint_ImageID_Process)
                                Else
                                    objSemItem_Result = objTransaction_Process.del_002_Process_Public

                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_Process.del_001_Process()
                                    End If

                                    MsgBox("Beim Speichern des Prozesses ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                objTransaction_Process.del_001_Process()
                                MsgBox("Beim Speichern des Prozesses ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Beim Speichern des Prozesses ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Es gibt bereits einen untergeordneten Prozesse mit dem Namen!", MsgBoxStyle.Exclamation)
                    End If

                End If
            End If
        Else
            objFrmProcessModule = New frmProcessModule(objLocalConfig)
            objFrmProcessModule.applyable = True
            objFrmProcessModule.ShowDialog(Me)
            If objFrmProcessModule.DialogResult = DialogResult.OK Then

            End If
        End If
    End Sub

    Private Sub SelectExistingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectExistingToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Process.SelectedNode
        If Not objTreeNode Is Nothing Then
            new_Process(False, objTreeNode)
        End If
    End Sub

    Private Sub TreeView_Process_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView_Process.DragDrop

        _dragEventArgs = e

        ' Behandlung von Verschieben oder Kopieren:
        If _mouseButton = MouseButtons.Right Then
            'Kontext-Menü!!!
        Else
            _dragdropCopy = (e.Effect = DragDropEffects.Copy)
            DragDropVerarbeiten()
        End If
    End Sub

    Private Sub TreeView_Process_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView_Process.DragEnter
        If e.Data.GetDataPresent(GetType(TreeNode)) Then
            ' Strg-Taste gedrück? Prüfung über Bitmaske:
            If (e.KeyState And 8) = 8 Then
                e.Effect = DragDropEffects.Copy
            Else
                ' nur linke Maustaste
                e.Effect = DragDropEffects.Move
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub TreeView_Process_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles TreeView_Process.ItemDrag
        Dim sourceNode As TreeNode = DirectCast(e.Item, TreeNode)

        _mouseButton = e.Button

        ' DragDrop beginnen:
        DoDragDrop(sourceNode, DragDropEffects.Move Or DragDropEffects.Copy)
    End Sub

    Private Sub TreeView_Process_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView_Process.KeyDown
        Dim objTreeNode As TreeNode
        Select Case e.KeyCode
            Case Keys.F5
                fill_Processes()
            Case Keys.Up
                objTreeNode = TreeView_Process.SelectedNode
                If Not objTreeNode Is Nothing Then
                    If e.Control = True Then
                        change_Index(objTreeNode, False)
                    End If
                End If
                

            Case Keys.Down

                objTreeNode = TreeView_Process.SelectedNode
                If Not objTreeNode Is Nothing Then
                    If e.Control = True Then
                        change_Index(objTreeNode, True)
                    End If
                End If
        End Select
    End Sub

    Private Sub change_Index(ByVal objTreeNode As TreeNode, ByVal boolUp As Boolean)
        Dim objDRC_Process As DataRowCollection
        Dim objDR_Process As DataRow
        Dim objTreeNode_Parent As TreeNode
        Dim objSemItem_Process_Parent As New clsSemItem
        Dim objSemItem_Process_Child As New clsSemItem
        Dim objSemItem_Process_Child_Old As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objTreeNodes() As TreeNode

        objTreeNode_Parent = objTreeNode.Parent
        If Not objTreeNode_Parent Is Nothing Then
            If Not objTreeNode_Parent.ImageIndex = cint_ImageID_Root Then
                objDRC_Process = procA_get_new_Position_Process.GetData(objLocalConfig.SemItem_Type_Process.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                                        boolUp, _
                                                                        New Guid(objTreeNode.Name), _
                                                                        New Guid(objTreeNode_Parent.Name)).Rows
                If objDRC_Process.Count > 0 Then
                    objSemItem_Process_Parent.GUID = New Guid(objTreeNode_Parent.Name)
                    objSemItem_Process_Parent.Name = objTreeNode_Parent.Text
                    objSemItem_Process_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                    objSemItem_Process_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Process_Child.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Process_Child.Name = objTreeNode.Text
                    objSemItem_Process_Child.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                    objSemItem_Process_Child.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Result = objTransaction_Process.save_003_Process_To_Parent(objSemItem_Process_Parent, _
                                                                                          objDRC_Process(0).Item("OrderID_New"), _
                                                                                          objSemItem_Process_Child)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Process_Child_Old.GUID = objDRC_Process(0).Item("GUID_Process_old")
                        objSemItem_Process_Child_Old.Name = objDRC_Process(0).Item("Name_Process_old")
                        objSemItem_Process_Child_Old.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                        objSemItem_Process_Child_Old.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_Process.save_003_Process_To_Parent(objSemItem_Process_Parent, _
                                                                                              objDRC_Process(0).Item("OrderID_Old"), _
                                                                                              objSemItem_Process_Child_Old)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode_Parent.Nodes.Clear()
                            objDRC_Process = procA_TokenToken_LeftRight_Tree.GetData(objSemItem_Process_Parent.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                                           objLocalConfig.SemItem_Type_Process.GUID, 0, -1, 0).Rows()
                            For Each objDR_Process In objDRC_Process
                                If objDR_Process.Item("GUID_Token_Parent").ToString = objTreeNode_Parent.Name Then
                                    objTreeNode_Parent.Nodes.Add(objDR_Process.Item("GUID_Token").ToString, _
                                                                    objDR_Process.Item("Name_Token"), cint_ImageID_Process, cint_ImageID_Process)
                                Else
                                    objTreeNodes = objTreeNode_Parent.Nodes.Find(objDR_Process.Item("GUID_Token_Parent").ToString, True)
                                    If objTreeNodes.Count > 0 Then
                                        objTreeNodes(0).Nodes.Add(objDR_Process.Item("GUID_Token").ToString, _
                                                                    objDR_Process.Item("Name_Token"), cint_ImageID_Process, cint_ImageID_Process)

                                    End If
                                End If
                                


                            Next
                            objTreeNodes = objTreeNode_Parent.Nodes.Find(objTreeNode.Name, False)
                            If objTreeNodes.Count > 0 Then
                                TreeView_Process.SelectedNode = objTreeNodes(0)
                            End If
                        Else
                            MsgBox("Die Reihenfolge kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                            objSemItem_Result = objTransaction_Process.save_003_Process_To_Parent(objSemItem_Process_Parent, _
                                                                                          objDRC_Process(0).Item("OrderID_Old"), _
                                                                                          objSemItem_Process_Child)
                        End If
                    Else
                        MsgBox("Die Reihenfolge kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub DragDropVerarbeiten()
        Dim sourceNode As TreeNode = TryCast(_dragEventArgs.Data.GetData(GetType(TreeNode)), TreeNode)

        Dim p As Point = TreeView_Process.PointToClient(New Point(_dragEventArgs.X, _dragEventArgs.Y))
        Dim targetNode As TreeNode = TreeView_Process.GetNodeAt(p)
        Dim objNodes() As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim objNode_Parent_Source As TreeNode
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Source As New clsSemItem
        Dim objSemItem_Target As New clsSemItem
        Dim objSemItem_Source_Parent As New clsSemItem
        Dim objDRC_Process As DataRowCollection
        Dim objDR_Process As DataRow
        Dim intOrderID As Integer
        Dim intOrderID_Old As Integer

        If Not targetNode Is Nothing And Not sourceNode Is Nothing And Not sourceNode.ImageIndex = cint_ImageID_Root Then
            objSemItem_Source.GUID = New Guid(sourceNode.Name)
            objSemItem_Source.Name = sourceNode.Text
            objSemItem_Source.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
            objSemItem_Source.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


            Select Case targetNode.ImageIndex
                Case cint_ImageID_Process
                    objSemItem_Target.GUID = New Guid(targetNode.Name)
                    objSemItem_Target.Name = targetNode.Text
                    objSemItem_Target.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                    objSemItem_Target.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objNodes = sourceNode.Nodes.Find(targetNode.Name, True)
                    If objNodes.Count = 0 Then
                        objNode_Parent_Source = sourceNode.Parent
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        If objNode_Parent_Source.ImageIndex = cint_ImageID_Root Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                            If _dragdropCopy = False Then
                                objSemItem_Result = objTransaction_Process.del_002_Process_Public(objSemItem_Source)
                                
                            End If

                        Else
                            objSemItem_Source_Parent.GUID = New Guid(objNode_Parent_Source.Name)
                            objSemItem_Source_Parent.Name = objNode_Parent_Source.Text
                            objSemItem_Source_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                            objSemItem_Source_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            If _dragdropCopy = False Then
                                objSemItem_Result = objTransaction_Process.del_003_Process_To_Parent(objSemItem_Source_Parent, objSemItem_Source)
                                intOrderID_Old = objSemItem_Result.Level
                            End If


                        End If
                        If Not objNode_Parent_Source.Name = targetNode.Name Then
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                intOrderID = get_Next_OrderID(objSemItem_Target)
                                objSemItem_Result = objTransaction_Process.save_003_Process_To_Parent(objSemItem_Target, intOrderID, objSemItem_Source)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objDRC_Process = procA_TokenToken_LeftRight_Tree.GetData(objSemItem_Target.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                                            objLocalConfig.SemItem_Type_Process.GUID, 0, -1, 0).Rows()
                                    For Each objDR_Process In objDRC_Process
                                        If targetNode.Name = objDR_Process.Item("GUID_Token_Parent").ToString Then
                                            targetNode.Nodes.Add(objDR_Process.Item("GUID_Token").ToString, _
                                                                 objDR_Process.Item("Name_Token"), cint_ImageID_Process, cint_ImageID_Process)
                                        Else
                                            objTreeNodes = targetNode.Nodes.Find(objDR_Process.Item("GUID_Token_Parent").ToString, True)
                                            If objTreeNodes.Count > 0 Then
                                                objTreeNodes(0).Nodes.Add(objDR_Process.Item("GUID_Token").ToString, _
                                                                          objDR_Process.Item("Name_Token"), cint_ImageID_Process, cint_ImageID_Process)

                                            End If
                                        End If

                                    Next


                                    If _dragdropCopy = False Then
                                        sourceNode.Remove()
                                    End If
                                Else
                                    If _dragdropCopy = True Then
                                        MsgBox("Der Prozess konnte nicht kopiert werden!", MsgBoxStyle.Exclamation)
                                    Else
                                        If objNode_Parent_Source.ImageIndex = cint_ImageID_Root Then
                                            objTransaction_Process.save_002_Process_Public(True, objSemItem_Source)
                                        Else

                                            objTransaction_Process.save_003_Process_To_Parent(objSemItem_Source_Parent, intOrderID_Old, objSemItem_Source)

                                        End If
                                        MsgBox("Der Prozess konnte nicht verschoben werden!", MsgBoxStyle.Exclamation)
                                    End If
                                    fill_Processes()
                                End If
                            Else
                                If _dragdropCopy = True Then
                                    MsgBox("Der Prozess konnte nicht kopiert werden!", MsgBoxStyle.Exclamation)
                                Else
                                    MsgBox("Der Prozess konnte nicht verschoben werden!", MsgBoxStyle.Exclamation)
                                End If
                                fill_Processes()
                            End If
                        End If
                        
                    Else
                        MsgBox("Sie können einen übergeordneten Ast nicht einem untergeordneten unterordnen!", MsgBoxStyle.Exclamation)
                    End If
                Case cint_ImageID_Root
                    objNode_Parent_Source = sourceNode.Parent
                    If Not objNode_Parent_Source.ImageIndex = cint_ImageID_Root Then
                        objSemItem_Source_Parent.GUID = New Guid(objNode_Parent_Source.Name)
                        objSemItem_Source_Parent.Name = objNode_Parent_Source.Text
                        objSemItem_Source_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                        objSemItem_Source_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        If _dragdropCopy = False Then
                            objSemItem_Result = objTransaction_Process.del_003_Process_To_Parent(objSemItem_Source_Parent, objSemItem_Source)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                MsgBox("Der Prozess kann nicht verschoben werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Process.save_002_Process_Public(True, objSemItem_Source)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objDRC_Process = procA_TokenToken_LeftRight_Tree.GetData(objSemItem_Source.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                                            objLocalConfig.SemItem_Type_Process.GUID, 0, -1, 0).Rows()
                                For Each objDR_Process In objDRC_Process
                                    If objDR_Process.Item("GUID_Token_Parent") = objSemItem_Source.GUID Then
                                        targetNode = objTreeNode_Root.Nodes.Add(objDR_Process.Item("GUID_Token").ToString, _
                                                                        objDR_Process.Item("Name_Token"), cint_ImageID_Process, cint_ImageID_Process)
                                    Else
                                        objTreeNodes = objTreeNode_Root.Nodes.Find(objDR_Process.Item("GUID_Token_Parent").ToString, True)
                                        If objTreeNodes.Count > 0 Then
                                            objTreeNodes(0).Nodes.Add(objDR_Process.Item("GUID_Token").ToString, _
                                                                        objDR_Process.Item("Name_Token"), cint_ImageID_Process, cint_ImageID_Process)

                                        End If
                                    End If
                                    


                                Next


                                If _dragdropCopy = False Then
                                    sourceNode.Remove()
                                End If
                            Else
                                If _dragdropCopy = True Then
                                    MsgBox("Der Prozess kann nicht kopiert werden!", MsgBoxStyle.Exclamation)
                                Else
                                    MsgBox("Der Prozess kann nicht verschoben werden!", MsgBoxStyle.Exclamation)
                                End If

                            End If
                        End If
                    End If
            End Select
        End If
    End Sub

    Private Function get_Next_OrderID(ByVal objSemItem_Process As clsSemItem) As Integer
        Dim intOrderID As Integer
        intOrderID = funcA_TokenToken.LeftRight_Max_OrderID_By_GUIDs(objSemItem_Process.GUID, _
                                                        objLocalConfig.SemItem_Type_Process.GUID, _
                                                        objLocalConfig.SemItem_RelationType_superordinate.GUID)
        Return intOrderID + 1

    End Function

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Parent As TreeNode
        Dim objSemItem_Process As New clsSemItem
        Dim objSemItem_Parent As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objTreeNode = TreeView_Process.SelectedNode
        If objTreeNode.ImageIndex = cint_ImageID_Process Then
            objSemItem_Process.GUID = New Guid(objTreeNode.Name)
            objSemItem_Process.Name = objTreeNode.Text
            objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
            objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objTreeNode_Parent = objTreeNode.Parent
            If objTreeNode_Parent.ImageIndex = cint_ImageID_Root Then
                objSemItem_Result = objTransaction_Process.del_002_Process_Public(objSemItem_Process)
            Else
                objSemItem_Parent.GUID = New Guid(objTreeNode_Parent.Name)
                objSemItem_Parent.Name = objTreeNode_Parent.Text
                objSemItem_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_Process.del_003_Process_To_Parent(objSemItem_Parent, objSemItem_Process)
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objTreeNode.Remove()
            Else
                MsgBox("Der Prozesse kann nicht removed werden!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim objSemItem_Process As clsSemItem
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Process.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Process
                    objSemItem_Process = New clsSemItem
                    objSemItem_Process.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Process.Name = objTreeNode.Text
                    objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                    objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                Case Else
                    objSemItem_Process = Nothing
            End Select
        Else
            objSemItem_Process = Nothing
        End If

        fill_TabPages(objSemItem_Process)
    End Sub

    Private Sub ExportHTMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportHTMLToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Process As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim strLine As String
        Dim intLevel As Integer

        objTreeNode = TreeView_Process.SelectedNode
        strHTML_Processes = ""
        strHTML_List = ""

        If Not objTreeNode Is Nothing Then

            objSemItem_Result = objHTMLCreation.initilialize_ExportFolder()

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objHTMLCreation.open_TextWriter(objTreeNode.Name)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    strLine = objHTMLCreation.get_HTML_Intro()
                    objHTMLCreation.write_Line(strLine)


                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_DocumentInit, False)
                    objHTMLCreation.write_Line(strLine)

                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Head, False)
                    objHTMLCreation.write_Line(strLine)

                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Title, False)
                    objHTMLCreation.write_Line(strLine)

                    objHTMLCreation.write_Line(objHTMLCreation.encode_HTML(objTreeNode.Text))

                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Title, True)
                    objHTMLCreation.write_Line(strLine)

                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Head, True)
                    objHTMLCreation.write_Line(strLine)


                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Body, False)
                    objHTMLCreation.write_Line(strLine)

                    objSemItem_Process.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Process.Name = objTreeNode.Text
                    objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                    objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    intLevel = 1
                    

                    strLine = objHTMLCreation.get_HTML_Heading(intLevel, False)
                    objHTMLCreation.write_Line(strLine)

                    strLine = objHTMLCreation.encode_HTML(objSemItem_Process.Name)
                    strHTML_List = strHTML_List & "<ul>" & vbCrLf
                    strHTML_List = strHTML_List & "<li>" & strLine & "</li>" & vbCrLf
                    objHTMLCreation.write_Line(strLine)
                    strLine = objHTMLCreation.get_HTML_Heading(intLevel, True)
                    objHTMLCreation.write_Line(strLine)

                    export_HTML_Description(objSemItem_Process)
                    export_HTML_Requirements(objSemItem_Process)
                    export_HTML_Images(objSemItem_Process)

                    export_HTML_Process(objSemItem_Process, intLevel)

                    strHTML_List = strHTML_List & "</ul>"
                    objHTMLCreation.write_Line(strHTML_List)
                    objHTMLCreation.write_Line("<hr>" & vbCrLf)
                    objHTMLCreation.write_Line(strHTML_Processes)
                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Body, True)
                    objHTMLCreation.write_Line(strLine)

                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_DocumentInit, False)
                    objHTMLCreation.write_Line(strLine)

                    objHTMLCreation.close_TextWriter()
                End If

                

            End If
            
        End If
    End Sub

    Private Sub export_HTML_Process(ByVal SemItem_Process As clsSemItem, ByVal intLevel As Integer)
        Dim objSemItem_Process_Sub As New clsSemItem

        Dim objDRC_Processes As DataRowCollection
        Dim objDR_Process As DataRow

        Dim strLine As String

        strHTML_List = strHTML_List & "<ul>" & vbCrLf

        objDRC_Processes = funcA_TokenToken.GetData_LeftRight_Ordered_By_GUIDs(SemItem_Process.GUID, _
                                                                               objLocalConfig.SemItem_Type_Process.GUID, _
                                                                               objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                                         True).Rows
        For Each objDR_Process In objDRC_Processes
            objSemItem_Process_Sub.GUID = objDR_Process.Item("GUID_Token_Right")
            objSemItem_Process_Sub.Name = objDR_Process.Item("Name_Token_Right")
            objSemItem_Process_Sub.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
            objSemItem_Process_Sub.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            strLine = objHTMLCreation.get_HTML_Heading(intLevel, False)
            strHTML_Processes = strHTML_Processes & strLine
            'objHTMLCreation.write_Line(strLine)
            strLine = objHTMLCreation.encode_HTML(objSemItem_Process_Sub.Name)
            strHTML_List = strHTML_List & "<li>" & strLine & "</li>"
            strHTML_Processes = strHTML_Processes & strLine
            'objHTMLCreation.write_Line(strLine)
            strLine = objHTMLCreation.get_HTML_Heading(intLevel, True)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)

            export_HTML_Description(objSemItem_Process_Sub)
            export_HTML_Requirements(objSemItem_Process_Sub)
            export_HTML_Images(objSemItem_Process_Sub)

            export_HTML_Process(objSemItem_Process_Sub, intLevel + 1)
        Next
        strHTML_List = strHTML_List & "</ul>" & vbCrLf
    End Sub
    Private Function export_HTML_Images(ByVal SemItem_Process As clsSemItem) As clsSemItem
        Dim objSemIteM_Result As clsSemItem
        Dim objDR_Image As DataRow
        Dim objSemItem_File As New clsSemItem
        Dim strLine As String

        objSemIteM_Result = objImageWork.get_Images(SemItem_Process)
        If objSemIteM_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Table, False)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)
            For Each objDR_Image In objImageWork.Rows_Images
                objSemItem_File.GUID = objDR_Image.Item("GUID_File")
                objSemItem_File.Name = objDR_Image.Item("Name_File")
                objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemIteM_Result = objHTMLCreation.export_File(objSemItem_File)
                If objSemIteM_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                    strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                    'objHTMLCreation.write_Line(strLine)
                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                    strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                    'objHTMLCreation.write_Line(strLine)
                    objHTMLCreation.add_Attribute(objHTMLCreation.SemItem_Attribute_SRC.Name, objSemIteM_Result.Additional1)
                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Images, False)
                    strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                    'objHTMLCreation.write_Line(strLine)

                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                    strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                    'objHTMLCreation.write_Line(strLine)
                    strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                    strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                    'objHTMLCreation.write_Line(strLine)
                End If
            Next
            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Table, True)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)
        End If

        Return objSemIteM_Result
    End Function
    Private Sub export_HTML_Description(ByVal SemItem_Process As clsSemItem)
        Dim objDRC_Description As DataRowCollection
        Dim strLine As String

        objDRC_Description = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(SemItem_Process.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Description.GUID).Rows

        If objDRC_Description.Count > 0 Then
            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Paragraph, False)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            strLine = objHTMLCreation.encode_HTML(objDRC_Description(0).Item("Val_VARCHARMAX"))
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            ' objHTMLCreation.write_Line(strLine)

            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Paragraph, True)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)
        End If
    End Sub

    Private Sub export_HTML_Requirements(ByVal SemItem_Process As clsSemItem)
        Dim objDR_Item As DataRow
        Dim strLine As String

        objUserControl_References.get_References_SUB(SemItem_Process)

        If objUserControl_References.tbl_Application.Count > 0 Or _
            objUserControl_References.tbl_Belonging.Count > 0 Or _
            objUserControl_References.tbl_Document.Count > 0 Or _
            objUserControl_References.tbl_File.Count > 0 Or _
            objUserControl_References.tbl_Group.Count > 0 Or _
            objUserControl_References.tbl_Manual.Count > 0 Or _
            objUserControl_References.tbl_Media.Count > 0 Or _
            objUserControl_References.tbl_Needs.Count > 0 Or _
            objUserControl_References.tbl_NeedsChild.Count > 0 Or _
            objUserControl_References.tbl_NeedsChild.Count > 0 Or _
            objUserControl_References.tbl_Responsiblity.Count > 0 Or _
            objUserControl_References.tbl_Role.Count > 0 Or _
            objUserControl_References.tbl_User.Count > 0 Then
            objHTMLCreation.add_Attribute(objHTMLCreation.SemItem_Attribute_Border.Name, "1")

            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Table, False)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)

            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)

            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)

            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & "Type" & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)

            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)

            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)


            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & "Requirement" & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)

            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)

            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)


            For Each objDR_Item In objUserControl_References.tbl_Application.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_Type_Application.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Token_Right"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            For Each objDR_Item In objUserControl_References.tbl_Belonging.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_RelationType_belonging_Sem_Item.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Ref"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            For Each objDR_Item In objUserControl_References.tbl_Document.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_RelationType_needed_Documentation.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Ref"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            For Each objDR_Item In objUserControl_References.tbl_File.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_Type_File.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Token_Right"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            For Each objDR_Item In objUserControl_References.tbl_Folder.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_type_Folder.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Token_Right"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            For Each objDR_Item In objUserControl_References.tbl_Group.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_Type_Group.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Token_Right"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            For Each objDR_Item In objUserControl_References.tbl_Manual.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_Type_Manual.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Token_Right"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            For Each objDR_Item In objUserControl_References.tbl_Media.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_Type_Media.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Token_Right"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            For Each objDR_Item In objUserControl_References.tbl_Needs.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_RelationType_needs.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Ref"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            For Each objDR_Item In objUserControl_References.tbl_NeedsChild.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_RelationType_needs_Child.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Ref"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            For Each objDR_Item In objUserControl_References.tbl_Responsiblity.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_Type_responsibility.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Token_Right"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            For Each objDR_Item In objUserControl_References.tbl_Role.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_Type_Role.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Token_Right"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            For Each objDR_Item In objUserControl_References.tbl_User.Rows
                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, False) & objHTMLCreation.encode_HTML(objLocalConfig.SemItem_type_User.Name) & objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Bold, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)


                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, False)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.encode_HTML(objDR_Item.Item("Name_Token_Right"))
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableCol, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)

                strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_TableRow, True)
                strHTML_Processes = strHTML_Processes & strLine & vbCrLf
                'objHTMLCreation.write_Line(strLine)
            Next

            strLine = objHTMLCreation.get_HTML_Tag(objHTMLCreation.SemItem_DocType_Table, True)
            strHTML_Processes = strHTML_Processes & strLine & vbCrLf
            'objHTMLCreation.write_Line(strLine)
        End If

        
    End Sub
End Class
