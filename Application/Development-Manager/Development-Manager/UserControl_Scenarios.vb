Imports Sem_Manager
Imports Localizing_Manager
Public Class UserControl_Scenarios
    Private Const cintImageID_DevStructure As Integer = 0
    Private Const cintImageID_Process As Integer = 1
    Private Const cintImageID_Invoke As Integer = 2
    Private Const cintImageID_Loop As Integer = 3
    Private Const cintImageID_Return As Integer = 4
    Private Const cintImageID_Database As Integer = 5
    Private Const cintImageID_Root As Integer = 6
    Private Const cintImageID_ParameterIN As Integer = 7
    Private Const cintImageID_ParameterOUT As Integer = 8
    Private Const cintImageID_Scenario As Integer = 9
    Private Const cintImageID_GUIEntry As Integer = 10

    Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_Scenes_Of_SoftwareDevelopment As New ds_PluginTableAdapters.proc_Scenes_Of_SoftwareDevelopmentTableAdapter
    Private procA_related_Processes_L1_L2 As New ds_DevStructuresTableAdapters.proc_related_Processes_L1_L2TableAdapter
    Private procA_ProcessTypeOfProcess As New ds_DevStructuresTableAdapters.proc_ProcessTypeOfProcessTableAdapter
    Private procA_DevStructureInvoke_By_GUIDProcess As New ds_DevStructuresTableAdapters.proc_DevStructureInvoke_By_GUIDProcessTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private objUserControl_Localize As UserControl_Localized

    Private objSemItem_Development As clsSemItem
    Private objSemItem_Scene As New clsSemItem
    Private boolApplyable As Boolean

    Private Sub fill_Tree()
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Dev As TreeNode
        Dim objTreeNode_Scene As TreeNode
        Dim objTreeNode_GUIEntry_DevStructure As TreeNode
        Dim objTreeNode_Process As TreeNode
        Dim objDRC_Scenes As DataRowCollection
        Dim objDR_Scenes As DataRow
        Dim objDRC_Process As DataRowCollection

        TreeView_Scenario.Nodes.Clear()

        If objSemItem_Development Is Nothing Then
            objDRC_Scenes = procA_Scenes_Of_SoftwareDevelopment.GetData(objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                    objLocalConfig.SemItem_Type_Scene.GUID, _
                                                                    objLocalConfig.SemItem_Type_GUI_Entires.GUID, _
                                                                    objLocalConfig.SemItem_Type_Development_Structure.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_initializing.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_handles.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                    Nothing).Rows
        Else
            objDRC_Scenes = procA_Scenes_Of_SoftwareDevelopment.GetData(objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                    objLocalConfig.SemItem_Type_Scene.GUID, _
                                                                    objLocalConfig.SemItem_Type_GUI_Entires.GUID, _
                                                                    objLocalConfig.SemItem_Type_Development_Structure.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_initializing.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_handles.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                    objSemItem_Development.GUID).Rows
        End If

        For Each objDR_Scenes In objDRC_Scenes
            objTreeNodes = TreeView_Scenario.Nodes.Find(objDR_Scenes.Item("GUID_Software_Development").ToString, False)
            If objTreeNodes.Count = 0 Then
                objTreeNode_Dev = TreeView_Scenario.Nodes.Add(objDR_Scenes.Item("GUID_Software_Development").ToString, _
                                                              objDR_Scenes.Item("Name_Software_Development"), _
                                                              cintImageID_Root, cintImageID_Root)

            Else
                objTreeNode_Dev = objTreeNodes(0)
            End If
            objTreeNode_Scene = objTreeNode_Dev.Nodes.Add(objDR_Scenes.Item("GUID_Scene").ToString, objDR_Scenes.Item("Name_Scene"), cintImageID_Scenario, cintImageID_Scenario)
            objSemItem_Scene.GUID = objDR_Scenes.Item("GUID_Scene")
            objSemItem_Scene.Name = objDR_Scenes.Item("Name_Scene")
            objSemItem_Scene.GUID_Parent = objLocalConfig.SemItem_Type_Scene.GUID
            objSemItem_Scene.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objTreeNode_GUIEntry_DevStructure = objTreeNode_Scene.Nodes.Add(objDR_Scenes.Item("GUID_GUI_Entires").ToString, objDR_Scenes.Item("Name_Dev_Structure") & " Handles (" & objDR_Scenes.Item("Name_SoftwareDevelopment_GUIEntry") & "\" & objDR_Scenes.Item("Name_GUI_Entires") & ")", cintImageID_DevStructure, cintImageID_DevStructure)
            objDRC_Process = funcA_TokenToken.GetData_TokenToken_LeftRight(objDR_Scenes.Item("GUID_Dev_Structure"), objLocalConfig.SemItem_RelationType_works_off.GUID, objLocalConfig.SemItem_Type_Process.GUID).Rows
            If objDRC_Process.Count > 0 Then
                objTreeNode_Process = objTreeNode_GUIEntry_DevStructure.Nodes.Add(objDRC_Process(0).Item("GUID_Token_Right").ToString, objDRC_Process(0).Item("Name_Token_Right"), cintImageID_Process, cintImageID_Process)
                fill_ProcessTree(objTreeNode_Process)
            End If
        Next


    End Sub

    Private Sub fill_ProcessTree(ByVal objTreeNode_Process As TreeNode)
        Dim objTreeNode_Sub_L1 As TreeNode
        Dim objTreeNode_Sub_l2 As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim objDRC_Processes As DataRowCollection
        Dim objDR_Process As DataRow
        Dim boolSub As Boolean

        objDRC_Processes = procA_related_Processes_L1_L2.GetData(objLocalConfig.SemItem_Type_Process.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                                         New Guid(objTreeNode_Process.Name)).Rows
        objTreeNode_Sub_L1 = Nothing
        objTreeNode_Sub_L2 = Nothing
        For Each objDR_Processes In objDRC_Processes
            If Not IsDBNull(objDR_Processes.Item("GUID_Process_L1")) Then
                If Not objTreeNode_Sub_L1 Is Nothing Then
                    boolSub = True
                Else
                    boolSub = False
                End If
                If boolSub = True Then
                    If New Guid(objTreeNode_Sub_L1.Name) = objDR_Processes.Item("GUID_Process_L1") Then
                        boolSub = False
                    End If
                Else
                    boolSub = True
                End If

                If boolSub = True Then
                    objTreeNodes = objTreeNode_Process.Nodes.Find(objDR_Processes.Item("GUID_Process_L1").ToString, False)
                    If objTreeNodes.Count = 0 Then
                        objTreeNode_Sub_L1 = objTreeNode_Process.Nodes.Add(objDR_Processes.Item("GUID_Process_L1").ToString, objDR_Processes.Item("Name_Process_L1"), cintImageID_Process, cintImageID_Process)
                    Else
                        objTreeNode_Sub_L1 = objTreeNodes(0)

                    End If
                    If Not objTreeNode_Sub_L1.ForeColor = Color.Red Then
                        If configure_Ignore(objTreeNode_Sub_L1) = True Then
                            objTreeNode_Sub_L1.ForeColor = Color.Red
                        Else
                            objTreeNode_Sub_L1.ForeColor = Color.Green
                        End If
                    End If
                    get_Invoke(objTreeNode_Sub_L1)
                    get_DevProcessType(objTreeNode_Sub_L1)
                End If


            End If

            If Not IsDBNull(objDR_Processes.Item("GUID_Process_L2")) Then
                If Not objTreeNode_Sub_L2 Is Nothing Then
                    boolSub = True
                Else
                    boolSub = False
                End If
                If boolSub = True Then
                    If New Guid(objTreeNode_Sub_L2.Name) = objDR_Processes.Item("GUID_Process_L2") Then
                        boolSub = False
                    End If
                Else
                    boolSub = True
                End If

                If boolSub = True Then
                    objTreeNodes = objTreeNode_Sub_L1.Nodes.Find(objDR_Processes.Item("GUID_Process_L2").ToString, False)
                    If objTreeNodes.Count = 0 Then
                        objTreeNode_Sub_l2 = objTreeNode_Sub_L1.Nodes.Add(objDR_Processes.Item("GUID_Process_L2").ToString, objDR_Processes.Item("Name_Process_L2"), cintImageID_Process, cintImageID_Process)
                        If objTreeNode_Sub_L1.ForeColor = Color.Red Then
                            objTreeNode_Sub_l2.ForeColor = Color.Red
                        Else
                            objTreeNode_Sub_l2.ForeColor = Color.Green
                        End If
                    Else
                        objTreeNode_Sub_L2 = objTreeNodes(0)

                    End If
                    If objTreeNode_Sub_L1.ForeColor = Color.Red Then
                        objTreeNode_Sub_l2.ForeColor = Color.Red
                    Else
                        If configure_Ignore(objTreeNode_Sub_l2) = True Then
                            objTreeNode_Sub_l2.ForeColor = Color.Red
                        Else
                            objTreeNode_Sub_l2.ForeColor = Color.Green
                        End If
                    End If
                    
                    get_Invoke(objTreeNode_Sub_L2)
                    get_DevProcessType(objTreeNode_Sub_L2)
                End If
            End If


        Next
    End Sub
    Private Sub get_DevProcessType(ByVal objTreeNode As TreeNode)

        Dim objDRC_ProcessType As DataRowCollection

        objDRC_ProcessType = procA_ProcessTypeOfProcess.GetData(objLocalConfig.SemItem_Attribute_ImageID.GUID, _
                                                                objLocalConfig.SemItem_Type_Process.GUID, _
                                                                objLocalConfig.SemItem_Type_Dev_Structure__Process_Type_to_Process_.GUID, _
                                                                objLocalConfig.SemItem_Type_Dev_Structure.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                New Guid(objTreeNode.Name)).Rows
        If objDRC_ProcessType.Count > 0 Then
            objTreeNode.ImageIndex = objDRC_ProcessType(0).Item("ImageID")
            objTreeNode.SelectedImageIndex = objDRC_ProcessType(0).Item("ImageID")
        End If

        
    End Sub

    Private Sub get_Invoke(ByVal objTreeNode As TreeNode)
        Dim objDRC_Invoke As DataRowCollection
        Dim objTreeNode_DevStructure As TreeNode
        Dim boolInvoke As Boolean


        objDRC_Invoke = procA_DevStructureInvoke_By_GUIDProcess.GetData(objLocalConfig.SemItem_Type_Dev_Structure_Invoke.GUID, _
                                                                    objLocalConfig.SemItem_Type_Development_Structure.GUID, _
                                                                    objLocalConfig.SemItem_Type_Process.GUID, _
                                                                    objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_invoking_Actor.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_invoked_Actor.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                    New Guid(objTreeNode.Name), _
                                                                    objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_Invoke.Count > 0 Then

            objTreeNode.ImageIndex = cintImageID_Invoke
            objTreeNode.SelectedImageIndex = cintImageID_Invoke
            objTreeNode.Text = objDRC_Invoke(0).Item("Name_Software_Development") & "\" & _
                objDRC_Invoke(0).Item("Name_Development_Structure_Invoked")

        End If


    End Sub

    Public Sub New(ByVal SemItem_Development As clsSemItem, ByVal isApplyable As Boolean)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Development = SemItem_Development
        boolApplyable = isApplyable

        ApplyToolStripMenuItem.Visible = boolApplyable

        initialize()
    End Sub


    Private Sub initialize()
        set_Connection()

        objUserControl_Localize = New UserControl_Localized
        objUserControl_Localize.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(objUserControl_Localize)

        fill_Tree()
    End Sub


    Private Sub set_Connection()
        semtblA_Token_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_Scenes_Of_SoftwareDevelopment.Connection = objLocalConfig.Connection_Plugin
        procA_related_Processes_L1_L2.Connection = objLocalConfig.Connection_Plugin
        procA_ProcessTypeOfProcess.Connection = objLocalConfig.Connection_Plugin
        procA_DevStructureInvoke_By_GUIDProcess.Connection = objLocalConfig.Connection_Plugin

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

    End Sub

    Private Sub TreeView_Scenario_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView_Scenario.BeforeExpand
        Dim objTreeNode_Selected As TreeNode

        objTreeNode_Selected = e.Node
        If Not objTreeNode_Selected Is Nothing Then
            If objTreeNode_Selected.ImageIndex = cintImageID_Database Or _
                objTreeNode_Selected.ImageIndex = cintImageID_Invoke Or _
                objTreeNode_Selected.ImageIndex = cintImageID_Loop Or _
                objTreeNode_Selected.ImageIndex = cintImageID_Process Or _
                objTreeNode_Selected.ImageIndex = cintImageID_Return Then
                fill_ProcessTree(objTreeNode_Selected)
            End If
        End If
    End Sub

    Private Sub ContextMenuStrip_Scenario_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Scenario.Opening
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Scenario.SelectedNode

        IgnoreProcessToolStripMenuItem.Enabled = False

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cintImageID_Database Or _
                 objTreeNode.ImageIndex = cintImageID_Invoke Or _
                 objTreeNode.ImageIndex = cintImageID_Loop Or _
                 objTreeNode.ImageIndex = cintImageID_Process Or _
                 objTreeNode.ImageIndex = cintImageID_Return Then

                IgnoreProcessToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub
    Private Function get_Scene(ByVal objTreeNode_Process As TreeNode) As clsSemItem
        Dim objTreeNode_Parent As TreeNode
        Dim objSemItem_Scene As New clsSemItem

        objTreeNode_Parent = objTreeNode_Process
        Do
            objTreeNode_Parent = objTreeNode_Parent.Parent
        Loop Until objTreeNode_Parent.ImageIndex = cintImageID_Scenario

        objSemItem_Scene.GUID = New Guid(objTreeNode_Parent.Name)
        objSemItem_Scene.Name = objTreeNode_Parent.Text
        objSemItem_Scene.GUID_Parent = objLocalConfig.SemItem_Type_Scene.GUID
        objSemItem_Scene.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        Return objSemItem_Scene
    End Function

    Private Function configure_Ignore(ByVal objTreeNode As TreeNode) As Boolean
        Dim objDRC_Ignore As DataRowCollection

        objDRC_Ignore = semtblA_Token_Token.GetData_By_GUIDs(objSemItem_Scene.GUID, New Guid(objTreeNode.Name), objLocalConfig.SemItem_RelationType_ignore.GUID).Rows
        If objDRC_Ignore.Count > 0 Then
            Return True

        Else
            Return False
        End If




    End Function

    Private Sub IgnoreProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IgnoreProcessToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Scene As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim GUID_Process As Guid

        objTreeNode = TreeView_Scenario.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cintImageID_Database Or _
                objTreeNode.ImageIndex = cintImageID_Invoke Or _
                objTreeNode.ImageIndex = cintImageID_Loop Or _
                objTreeNode.ImageIndex = cintImageID_Process Or _
                objTreeNode.ImageIndex = cintImageID_Return Then
                objSemItem_Scene = get_Scene(objTreeNode)
                GUID_Process = New Guid(objTreeNode.Name)
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Scene.GUID, GUID_Process, objLocalConfig.SemItem_RelationType_ignore.GUID, 0).Rows

                If configure_Ignore(objTreeNode) = True Then
                    objTreeNode.ForeColor = Color.Red
                Else
                    objTreeNode.ForeColor = Color.Green
                End If

                configure_ForeColor_SubNodes(objTreeNode)
            End If
        End If
    End Sub

    Private Sub configure_ForeColor_SubNodes(ByVal objTreeNode As TreeNode)
        Dim objTreeNode_Sub As TreeNode

        For Each objTreeNode_Sub In objTreeNode.Nodes
            objTreeNode_Sub.ForeColor = objTreeNode.ForeColor
        Next
    End Sub

    Private Sub DoNotIgnoreProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoNotIgnoreProcessToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Scene As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim GUID_Process As Guid

        objTreeNode = TreeView_Scenario.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cintImageID_Database Or _
                objTreeNode.ImageIndex = cintImageID_Invoke Or _
                objTreeNode.ImageIndex = cintImageID_Loop Or _
                objTreeNode.ImageIndex = cintImageID_Process Or _
                objTreeNode.ImageIndex = cintImageID_Return Then

                GUID_Process = New Guid(objTreeNode.Name)
                objSemItem_Scene = get_Scene(objTreeNode)
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Scene.GUID, GUID_Process, objLocalConfig.SemItem_RelationType_ignore.GUID).Rows
                'objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Scene.GUID, GUID_Process, objLocalConfig.SemItem_RelationType_ignore.GUID, 0).Rows

                If configure_Ignore(objTreeNode) = True Then
                    objTreeNode.ForeColor = Color.Red
                Else
                    objTreeNode.ForeColor = Color.Green
                End If

                configure_ForeColor_SubNodes(objTreeNode)
            End If
        End If
    End Sub
End Class
