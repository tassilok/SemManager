Imports Sem_Manager
Public Class UserControl_DevelopmentStructure
    Private Const cintImageID_DevStructure As Integer = 0
    Private Const cintImageID_Process As Integer = 1
    Private Const cintImageID_Invoke As Integer = 2
    Private Const cintImageID_Loop As Integer = 3
    Private Const cintImageID_Return As Integer = 4
    Private Const cintImageID_Database As Integer = 5
    Private Const cintImageID_Root As Integer = 6
    Private Const cintImageID_ParameterIN As Integer = 7
    Private Const cintImageID_ParameterOUT As Integer = 8
    Private Const cintImageID_Handles As Integer = 9

    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcT_Token_Token As New ds_Token.func_TokenTokenDataTable
    Private procA_TokenAttribute_Int As New ds_TokenAttributeTableAdapters.TokenAttribute_IntTableAdapter

    Private procA_related_Processes_L1_L2 As New ds_DevStructuresTableAdapters.proc_related_Processes_L1_L2TableAdapter
    Private funcA_related_DevStructures_With_InitialProcess As New ds_DevStructuresTableAdapters.func_related_DevStructures_With_InitialProcessTableAdapter
    Private funcT_related_DevStructures_With_InitialProcess As New ds_DevStructures.func_related_DevStructures_With_InitialProcessDataTable
    Private procA_related_Parameters_with_Direction As New ds_DevStructuresTableAdapters.proc_related_Parameters_with_DirectionTableAdapter
    Private procA_ProcessTypeOfProcess As New ds_DevStructuresTableAdapters.proc_ProcessTypeOfProcessTableAdapter
    Private procA_Handler_Of_GUIEntries_By_GUIDDevStructure As New ds_DevStructuresTableAdapters.proc_Handler_Of_GUIEntries_By_GUIDDevStructureTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private procA_DevStructureInvoke_By_GUIDProcess As New ds_DevStructuresTableAdapters.proc_DevStructureInvoke_By_GUIDProcessTableAdapter

    Private objFrm_TokenEditor As frmTokenEdit
    Private objFrm_DevelopmentManager As frmDevelopmentManager
    Private objFrm_DevelopmentStructure As frmDevelopmentStructure
    Private objDLG_Attribute_VARCHAR255 As dlgAttribute_Varchar255
    Private objUserControl_Localized As UserControl_Localized
    Private objLogWork_Local As clsLogWork_Local
    Private objSemItem_Development As clsSemItem
    Private boolApplyable As Boolean

    Public Event applied_DevStructure(ByVal objSemItem_DevStructure As clsSemItem)


    Public Property isApplyable() As Boolean
        Get
            Return boolApplyable
        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
            ApplyToolStripMenuItem.Visible = boolApplyable
        End Set
    End Property


    Public Sub New(ByVal SemItem_Development As clsSemItem, ByVal isApplyable As Boolean)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        boolApplyable = isApplyable
        ApplyToolStripMenuItem.Visible = boolApplyable
        objSemItem_Development = SemItem_Development

        set_DBConnection()

        fill_DevelopmentStructures()
        objUserControl_Localized = New UserControl_Localized
        objUserControl_Localized.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(objUserControl_Localized)

    End Sub

    Private Sub set_DBConnection()
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB
        funcA_related_DevStructures_With_InitialProcess.Connection = objLocalConfig.Connection_Plugin
        procA_related_Parameters_with_Direction.Connection = objLocalConfig.Connection_Plugin
        procA_related_Processes_L1_L2.Connection = objLocalConfig.Connection_Plugin
        procA_DevStructureInvoke_By_GUIDProcess.Connection = objLocalConfig.Connection_Plugin
        procA_ProcessTypeOfProcess.Connection = objLocalConfig.Connection_Plugin
        procA_Handler_Of_GUIEntries_By_GUIDDevStructure.Connection = objLocalConfig.Connection_Plugin

        procA_TokenAttribute_Int.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        objLogWork_Local = New clsLogWork_Local
    End Sub

    Private Sub fill_DevelopmentStructures()
        Dim objDRC_Parameters As DataRowCollection
        Dim objDR_Parameter As DataRow
        Dim objDR_DevStructureWithProc As DataRow
        Dim objDRC_Processes As DataRowCollection
        Dim objDR_Processes As DataRow
        Dim objDRC_Handles As DataRowCollection
        Dim objTreeNodes_Dev() As TreeNode
        Dim objTreeNode_Dev As TreeNode
        Dim objTreeNode_DevStruct As TreeNode
        Dim objTreeNode_Parameter As TreeNode
        Dim objTreeNode_Process As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Sub_L1 As TreeNode
        Dim objTreeNode_Sub_L2 As TreeNode
        Dim strParameter As String
        Dim intCount_DevStructures As Integer
        Dim boolSub As Boolean

        TreeView_DevStructures.Nodes.Clear()
        If objSemItem_Development Is Nothing Then
            funcA_related_DevStructures_With_InitialProcess.Fill(funcT_related_DevStructures_With_InitialProcess, _
                                                             objLocalConfig.SemItem_Type_Development_Structure.GUID, _
                                                             objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                             objLocalConfig.SemItem_Type_Process.GUID, _
                                                             objLocalConfig.SemItem_RelationType_works_off.GUID, _
                                                             objLocalConfig.SemItem_RelationType_contains.GUID.ToString)
        Else
            funcA_related_DevStructures_With_InitialProcess.Fill_By_GUIDDevelopment(funcT_related_DevStructures_With_InitialProcess, _
                                                                                    objLocalConfig.SemItem_Type_Development_Structure.GUID, _
                                                                                    objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                                    objLocalConfig.SemItem_Type_Process.GUID, _
                                                                                    objLocalConfig.SemItem_RelationType_works_off.GUID, _
                                                                                    objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                    objSemItem_Development.GUID)
        End If


        For Each objDR_DevStructureWithProc In funcT_related_DevStructures_With_InitialProcess.Rows
            objTreeNodes_Dev = TreeView_DevStructures.Nodes.Find(objDR_DevStructureWithProc.Item("GUID_SoftwareDevelopment").ToString, False)
            If objTreeNodes_Dev.Count = 0 Then
                objTreeNode_Dev = TreeView_DevStructures.Nodes.Add(objDR_DevStructureWithProc.Item("GUID_SoftwareDevelopment").ToString, objDR_DevStructureWithProc.Item("Name_SoftwareDevelopment"), cintImageID_Root, cintImageID_Root)
                objTreeNode_Dev.Expand()
            Else
                objTreeNode_Dev = objTreeNodes_Dev(0)
            End If
            objDRC_Parameters = procA_related_Parameters_with_Direction.GetData(objLocalConfig.SemItem_Type_Parameter_Dev_Structure.GUID, _
                                                                                objLocalConfig.SemItem_Type_Directions.GUID, _
                                                                                objLocalConfig.SemItem_Type_Development_Structure.GUID, _
                                                                                objLocalConfig.SemItem_Type_Objects.GUID, _
                                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                objLocalConfig.SemItem_RelationType_directed_by.GUID, _
                                                                                objLocalConfig.SemItem_RelationType_belonging_Paramter.GUID, _
                                                                                objDR_DevStructureWithProc.Item("GUID_DevStructure")).Rows

            objTreeNode_DevStruct = objTreeNode_Dev.Nodes.Add(objDR_DevStructureWithProc.Item("GUID_DevStructure").ToString, objDR_DevStructureWithProc.Item("Name_DevStructure"), cintImageID_DevStructure, cintImageID_DevStructure)

            objDRC_Handles = procA_Handler_Of_GUIEntries_By_GUIDDevStructure.GetData(objLocalConfig.SemItem_Type_GUI_Entires.GUID, _
                                                                                 objLocalConfig.SemItem_Type_Development_Structure.GUID, _
                                                                                 objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_handles.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                 objDR_DevStructureWithProc.Item("GUID_DevStructure")).Rows
            If objDRC_Handles.Count > 0 Then
                objTreeNode_DevStruct.Nodes.Add(objDRC_Handles(0).Item("GUID_GUI_Entires").ToString, _
                                                objDRC_Handles(0).Item("Name_GUI_Entires") & "\" & objDRC_Handles(0).Item("Name_Software_Development"), _
                                                cintImageID_Handles, cintImageID_Handles)
            End If
            intCount_DevStructures = intCount_DevStructures + 1
            strParameter = ""
            For Each objDR_Parameter In objDRC_Parameters
                If strParameter = "" Then
                    strParameter = objDR_Parameter.Item("Name_Parameter__Dev_Structure_") & "/" & objDR_Parameter.Item("Name_Directions")
                Else
                    strParameter = strParameter & ", " & objDR_Parameter.Item("Name_Parameter__Dev_Structure_") & "/" & objDR_Parameter.Item("Name_Directions")
                End If

                If objDR_Parameter.Item("GUID_Directions") = objLocalConfig.SemItem_Token_Directions_IN.GUID Then
                    objTreeNode_Parameter = objTreeNode_DevStruct.Nodes.Add(objDR_Parameter.Item("GUID_Parameter__Dev_Structure_").ToString, objDR_Parameter.Item("Name_Parameter__Dev_Structure_"), cintImageID_ParameterIN, cintImageID_ParameterIN)
                Else
                    objTreeNode_Parameter = objTreeNode_DevStruct.Nodes.Add(objDR_Parameter.Item("GUID_Parameter__Dev_Structure_").ToString, objDR_Parameter.Item("Name_Parameter__Dev_Structure_"), cintImageID_ParameterOUT, cintImageID_ParameterOUT)
                End If

            Next
            If Not strParameter = "" Then
                objTreeNode_DevStruct.Text = objTreeNode_DevStruct.Text & " (" & strParameter & ")"
            End If
            If Not IsDBNull(objDR_DevStructureWithProc.Item("GUID_Process")) Then
                objTreeNode_Process = objTreeNode_DevStruct.Nodes.Add(objDR_DevStructureWithProc.Item("GUID_Process").ToString, objDR_DevStructureWithProc.Item("Name_Process"), cintImageID_Process, cintImageID_Process)
                objDRC_Processes = procA_related_Processes_L1_L2.GetData(objLocalConfig.SemItem_Type_Process.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                                         objDR_DevStructureWithProc.Item("GUID_Process")).Rows
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
                                objTreeNode_Sub_L2 = objTreeNode_Sub_L1.Nodes.Add(objDR_Processes.Item("GUID_Process_L2").ToString, objDR_Processes.Item("Name_Process_L2"), cintImageID_Process, cintImageID_Process)
                            Else
                                objTreeNode_Sub_L2 = objTreeNodes(0)

                            End If
                            get_Invoke(objTreeNode_Sub_L2)
                            get_DevProcessType(objTreeNode_Sub_L2)
                        End If
                    End If
                    

                Next
            End If
        Next

        ToolStripLabel_Count.Text = intCount_DevStructures
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

        objTreeNode_DevStructure = get_belonging_DevStructure(objTreeNode)
        If Not objTreeNode_DevStructure Is Nothing Then
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
                If New Guid(objTreeNode_DevStructure.Name) = objDRC_Invoke(0).Item("GUID_Development_Structure_Invoking") Then
                    boolInvoke = True
                    objTreeNode.ImageIndex = cintImageID_Invoke
                    objTreeNode.SelectedImageIndex = cintImageID_Invoke
                Else
                    boolInvoke = False

                End If
                If boolInvoke = True Then
                    objTreeNode.ImageIndex = cintImageID_Invoke
                    objTreeNode.Text = objDRC_Invoke(0).Item("Name_Software_Development") & "\" & _
                        objDRC_Invoke(0).Item("Name_Development_Structure_Invoked")
                End If
            End If
        End If
        
    End Sub

    Private Function get_belonging_DevStructure(ByVal objTreeNode As TreeNode) As TreeNode
        Dim objTreeNode_Parent As TreeNode
        Dim objTreeNode_DevStructure As TreeNode

        objTreeNode_Parent = objTreeNode.Parent
        If Not objTreeNode_Parent Is Nothing Then
            If objTreeNode_Parent.ImageIndex = cintImageID_DevStructure Then
                objTreeNode_DevStructure = objTreeNode_Parent
            Else
                objTreeNode_DevStructure = get_belonging_DevStructure(objTreeNode_Parent)
            End If
        Else
            objTreeNode_DevStructure = Nothing
        End If
        Return objTreeNode_DevStructure
    End Function
    Private Sub TreeView_DevStructures_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_DevStructures.AfterSelect
        Dim objTreeNode As TreeNode
        Dim objSemItem_Related As New clsSemItem

        objTreeNode = TreeView_DevStructures.SelectedNode
        objUserControl_Localized.clear_LanguageTree()
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cintImageID_DevStructure
                    objSemItem_Related.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Related.Name = objTreeNode.Text
                    objSemItem_Related.GUID_Parent = objLocalConfig.SemItem_Type_Development_Structure.GUID
                    objSemItem_Related.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    If Not objLocalConfig.LanguageConfig Is Nothing Then
                        If Not objLocalConfig.LanguageConfig.supported_Languages Is Nothing Then
                            objUserControl_Localized.initialize(objSemItem_Related, objLocalConfig.LanguageConfig.supported_Languages, False)
                        End If
                    End If
                Case cintImageID_Invoke, cintImageID_Loop, cintImageID_Process, cintImageID_Return, cintImageID_Database
                    objSemItem_Related.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Related.Name = objTreeNode.Text
                    objSemItem_Related.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                    objSemItem_Related.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    If Not objLocalConfig.LanguageConfig Is Nothing Then
                        If Not objLocalConfig.LanguageConfig.supported_Languages Is Nothing Then
                            objUserControl_Localized.initialize(objSemItem_Related, objLocalConfig.LanguageConfig.supported_Languages, True)
                        End If
                    End If
                Case cintImageID_ParameterIN, cintImageID_ParameterOUT
                    objSemItem_Related.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Related.Name = objTreeNode.Text
                    objSemItem_Related.GUID_Parent = objLocalConfig.SemItem_Type_Parameter_Dev_Structure.GUID
                    objSemItem_Related.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    If Not objLocalConfig.LanguageConfig Is Nothing Then
                        If Not objLocalConfig.LanguageConfig.supported_Languages Is Nothing Then
                            objUserControl_Localized.initialize(objSemItem_Related, objLocalConfig.LanguageConfig.supported_Languages, False)
                        End If
                    End If

            End Select
        End If
    End Sub

    Private Sub SimpleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Process As New clsSemItem
        Dim objDRC_Process As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim intOrderID As Integer

        objTreeNode = TreeView_DevStructures.SelectedNode
        If Not objTreeNode Is Nothing Then
            objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Type_Process.Name, objLocalConfig.Globals)
            objDLG_Attribute_VARCHAR255.ShowDialog(Me)
            If objDLG_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
                objSemItem_Process.GUID = Guid.NewGuid
                objSemItem_Process.Name = objDLG_Attribute_VARCHAR255.Value1
                objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                If objTreeNode.ImageIndex = cintImageID_DevStructure Then
                    objDRC_Process = funcA_Token_Token.GetData_TokenToken_LeftRight(New Guid(objTreeNode.Name), objLocalConfig.SemItem_RelationType_works_off.GUID, objLocalConfig.SemItem_Type_Process.GUID).Rows
                    If objDRC_Process.Count = 0 Then
                        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Process.GUID, objSemItem_Process.Name, objSemItem_Process.GUID_Parent, True).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(New Guid(objTreeNode.Name), objSemItem_Process.GUID, objLocalConfig.SemItem_RelationType_works_off.GUID, 0).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                objTreeNode.Nodes.Add(objSemItem_Process.GUID.ToString, objSemItem_Process.Name, cintImageID_Process, cintImageID_Process)
                            Else
                                semprocA_DBWork_Del_Token.GetData(objSemItem_Process.GUID)
                                MsgBox("Der Prozess konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Der Prozess konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If
                        
                    Else
                        MsgBox("Sie können einer Entwicklungsstruktur nur einen Prozess zuordnen!", MsgBoxStyle.Exclamation)
                    End If
                ElseIf objTreeNode.ImageIndex = cintImageID_Invoke Or _
                       objTreeNode.ImageIndex = cintImageID_Loop Or _
                       objTreeNode.ImageIndex = cintImageID_Process Or _
                       objTreeNode.ImageIndex = cintImageID_Return Then
                    objDRC_Process = funcA_Token_Token.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(New Guid(objTreeNode.Name), _
                                                                                                objSemItem_Process.Name, _
                                                                                                objLocalConfig.SemItem_Type_Process.GUID, _
                                                                                                objLocalConfig.SemItem_RelationType_superordinate.GUID).Rows
                    If objDRC_Process.Count = 0 Then
                        intOrderID = funcA_Token_Token.LeftRight_Max_OrderID_By_GUIDs(New Guid(objTreeNode.Name), objLocalConfig.SemItem_Type_Process.GUID, objLocalConfig.SemItem_RelationType_superordinate.GUID)
                        intOrderID = intOrderID + 1
                        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Process.GUID, objSemItem_Process.Name, objSemItem_Process.GUID_Parent, True).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(New Guid(objTreeNode.Name), objSemItem_Process.GUID, objLocalConfig.SemItem_RelationType_superordinate.GUID, intOrderID).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                objTreeNode.Nodes.Add(objSemItem_Process.GUID.ToString, objSemItem_Process.Name, cintImageID_Process, cintImageID_Process)
                            Else
                                semprocA_DBWork_Del_Token.GetData(objSemItem_Process.GUID)
                                MsgBox("Beim Speichern des Prozesses ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Beim Speichern des Prozesses ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Es gibt bereits einen untergeordneten Prozesse, der die Bezeichnung besitzt!", MsgBoxStyle.Exclamation)
                    End If
                End If

                
            End If
        End If


    End Sub

    Private Sub ContextMenuStrip_Structures_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Structures.Opening
        Dim funcT_related_DevStructures_With_InitialProcess As New ds_DevStructures.func_related_DevStructures_With_InitialProcessDataTable
        Dim objDRs_Process() As DataRow
        Dim objTreeNode_DevStructure As TreeNode

        InvokeToolStripMenuItem.Enabled = False
        SimpleToolStripMenuItem.Enabled = False
        ApplyToolStripMenuItem.Enabled = False
        LogToolStripMenuItem.Enabled = False
        ChangeTypeToolStripMenuItem.Enabled = False
        objTreeNode_DevStructure = TreeView_DevStructures.SelectedNode
        If Not objTreeNode_DevStructure Is Nothing Then
            If objTreeNode_DevStructure.ImageIndex = cintImageID_DevStructure Then
                LogToolStripMenuItem.Enabled = True
                ApplyToolStripMenuItem.Enabled = True
                funcA_related_DevStructures_With_InitialProcess.Fill_By_GUIDDevelopment(funcT_related_DevStructures_With_InitialProcess, _
                                                                                        objLocalConfig.SemItem_Type_Development_Structure.GUID, _
                                                                                        objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                                        objLocalConfig.SemItem_Type_Process.GUID, _
                                                                                        objLocalConfig.SemItem_RelationType_works_off.GUID, _
                                                                                        objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                        objSemItem_Development.GUID)
                objDRs_Process = funcT_related_DevStructures_With_InitialProcess.Select("GUID_DevStructure='" & objTreeNode_DevStructure.Name & "'")
                If objDRs_Process.Count > 0 Then
                    If IsDBNull(objDRs_Process(0).Item("GUID_Process")) Then
                        SimpleToolStripMenuItem.Enabled = True
                    End If
                Else
                    MsgBox("Fehler beim Auslesen der Prozess-Informationen!", MsgBoxStyle.Critical)
                End If

            ElseIf objTreeNode_DevStructure.ImageIndex = cintImageID_Invoke Or _
                objTreeNode_DevStructure.ImageIndex = cintImageID_Loop Or _
                objTreeNode_DevStructure.ImageIndex = cintImageID_Process Or _
                objTreeNode_DevStructure.ImageIndex = cintImageID_Return Or _
                objTreeNode_DevStructure.ImageIndex = cintImageID_Database Then

                ChangeTypeToolStripMenuItem.Enabled = True
                SimpleToolStripMenuItem.Enabled = True
                InvokeToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub InvokeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvokeToolStripMenuItem.Click
        Dim objSemItems_Result() As clsSemItem
        Dim objTreeNode_DevStructure As TreeNode
        Dim objTreeNode_Process As TreeNode

        Dim objSemItem_DevStructureInvoke As New clsSemItem
        Dim objSemItem_InvokingActor As New clsSemItem
        Dim objSemItem_InvokedActor As New clsSemItem
        Dim objSemItem_Process As New clsSemItem

        Dim objDRC_LogState As DataRowCollection
        Dim objTreeNode As TreeNode
        Dim intOrderID As Integer

        objTreeNode = TreeView_DevStructures.SelectedNode

        If objTreeNode.ImageIndex = cintImageID_Invoke Or _
           objTreeNode.ImageIndex = cintImageID_Database Or _
           objTreeNode.ImageIndex = cintImageID_Loop Or _
           objTreeNode.ImageIndex = cintImageID_Process Or _
           objTreeNode.ImageIndex = cintImageID_Return Then

            

            objTreeNode_DevStructure = get_belonging_DevStructure(objTreeNode)

            objSemItem_InvokingActor.GUID = New Guid(objTreeNode_DevStructure.Name)
            objSemItem_InvokingActor.Name = objTreeNode_DevStructure.Text
            objSemItem_InvokingActor.GUID_Parent = objLocalConfig.SemItem_Type_Development_Structure.GUID
            objSemItem_InvokingActor.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objFrm_DevelopmentManager = New frmDevelopmentManager(objLocalConfig, True)
            objFrm_DevelopmentManager.ShowDialog(Me)
            If objFrm_DevelopmentManager.DialogResult = DialogResult.OK Then
                objSemItems_Result = objFrm_DevelopmentManager.SemItems_Result
                If Not objSemItems_Result Is Nothing Then
                    If objSemItems_Result.Count = 1 Then
                        If objSemItems_Result(0).GUID_Parent = objLocalConfig.SemItem_Type_Development_Structure.GUID Then
                            objSemItem_InvokedActor.GUID = objSemItems_Result(0).GUID
                            objSemItem_InvokedActor.Name = objSemItems_Result(0).Name
                            objSemItem_InvokedActor.GUID_Parent = objSemItems_Result(0).GUID_Parent
                            objSemItem_InvokedActor.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Process.GUID = Guid.NewGuid
                            objSemItem_Process.Name = objSemItems_Result(0).Name
                            objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                            objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_DevStructureInvoke.GUID = Guid.NewGuid
                            objSemItem_DevStructureInvoke.Name = objSemItem_InvokingActor.Name & "\" & objSemItem_InvokedActor.Name
                            If objSemItem_DevStructureInvoke.Name.Length > 255 Then
                                objSemItem_DevStructureInvoke.Name = objSemItem_DevStructureInvoke.Name.Substring(0, 125) & _
                                    "..." & _
                                    objSemItem_DevStructureInvoke.Name.Substring(objSemItem_DevStructureInvoke.Name.Length - 125, 125)
                            End If
                            objSemItem_DevStructureInvoke.GUID_Parent = objLocalConfig.SemItem_Type_Dev_Structure_Invoke.GUID
                            objSemItem_DevStructureInvoke.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DevStructureInvoke.GUID, _
                                                                                 objSemItem_DevStructureInvoke.Name, _
                                                                                 objSemItem_DevStructureInvoke.GUID_Parent, True).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DevStructureInvoke.GUID, _
                                                                                        objSemItem_InvokedActor.GUID, _
                                                                                        objLocalConfig.SemItem_RelationType_invoked_Actor.GUID, 0).Rows
                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DevStructureInvoke.GUID, _
                                                                                            objSemItem_InvokingActor.GUID, _
                                                                                            objLocalConfig.SemItem_RelationType_invoking_Actor.GUID, 0).Rows
                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Process.GUID, objSemItem_Process.Name, objSemItem_Process.GUID_Parent, True).Rows
                                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                            intOrderID = funcA_Token_Token.LeftRight_Max_OrderID_By_GUIDs(New Guid(objTreeNode.Name), objLocalConfig.SemItem_Type_Process.GUID, objLocalConfig.SemItem_RelationType_superordinate.GUID)
                                            intOrderID = intOrderID + 1
                                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(New Guid(objTreeNode.Name), objSemItem_Process.GUID, objLocalConfig.SemItem_RelationType_superordinate.GUID, intOrderID).Rows
                                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DevStructureInvoke.GUID, _
                                                                                                objSemItem_Process.GUID, _
                                                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, intOrderID).Rows
                                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                    objTreeNode_Process = objTreeNode.Nodes.Add(objSemItem_Process.GUID.ToString, objSemItem_Process.Name, cintImageID_Process, cintImageID_Process)
                                                    get_Invoke(objTreeNode_Process)
                                                Else
                                                    objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(New Guid(objTreeNode.Name), objSemItem_Process.GUID, objLocalConfig.SemItem_RelationType_superordinate.GUID).Rows
                                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                                        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Process.GUID).Rows
                                                    End If

                                                    objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DevStructureInvoke.GUID, _
                                                                                                       objSemItem_InvokingActor.GUID, _
                                                                                                       objLocalConfig.SemItem_RelationType_invoking_Actor.GUID).Rows
                                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                                        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DevStructureInvoke.GUID, _
                                                                                                       objSemItem_InvokedActor.GUID, _
                                                                                                       objLocalConfig.SemItem_RelationType_invoked_Actor.GUID).Rows
                                                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                                            semprocA_DBWork_Del_Token.GetData(objSemItem_DevStructureInvoke.GUID)
                                                        End If
                                                    End If

                                                    MsgBox("Der Invoke konnte leider nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                End If
                                            Else
                                                objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Process.GUID).Rows
                                                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DevStructureInvoke.GUID, _
                                                                                                   objSemItem_InvokingActor.GUID, _
                                                                                                   objLocalConfig.SemItem_RelationType_invoking_Actor.GUID).Rows
                                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                                    objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DevStructureInvoke.GUID, _
                                                                                                   objSemItem_InvokedActor.GUID, _
                                                                                                   objLocalConfig.SemItem_RelationType_invoked_Actor.GUID).Rows
                                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                                        semprocA_DBWork_Del_Token.GetData(objSemItem_DevStructureInvoke.GUID)
                                                    End If
                                                End If

                                                MsgBox("Der Invoke konnte leider nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                            End If
                                            
                                        Else
                                            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DevStructureInvoke.GUID, _
                                                                                                   objSemItem_InvokingActor.GUID, _
                                                                                                   objLocalConfig.SemItem_RelationType_invoking_Actor.GUID).Rows
                                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DevStructureInvoke.GUID, _
                                                                                               objSemItem_InvokedActor.GUID, _
                                                                                               objLocalConfig.SemItem_RelationType_invoked_Actor.GUID).Rows
                                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                                    semprocA_DBWork_Del_Token.GetData(objSemItem_DevStructureInvoke.GUID)
                                                End If
                                            End If
                                        End If
                                        
                                    Else
                                        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DevStructureInvoke.GUID, _
                                                                                               objSemItem_InvokedActor.GUID, _
                                                                                               objLocalConfig.SemItem_RelationType_invoked_Actor.GUID).Rows
                                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                            semprocA_DBWork_Del_Token.GetData(objSemItem_DevStructureInvoke.GUID)
                                        End If
                                        MsgBox("Der Invoke konnte leider nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    semprocA_DBWork_Del_Token.GetData(objSemItem_DevStructureInvoke.GUID)
                                    MsgBox("Der Invoke konnte leider nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Der Invoke konnte leider nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If

                        Else
                            MsgBox("Bitte eine Development-Structure auswählen!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Bitte eine Development-Structure auswählen!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Bitte eine Development-Structure auswählen!", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
        
    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_DevStructure As New clsSemItem

        objTreeNode = TreeView_DevStructures.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cintImageID_DevStructure Then
                objSemItem_DevStructure.GUID = New Guid(objTreeNode.Name)
                objSemItem_DevStructure.Name = objTreeNode.Text
                objSemItem_DevStructure.GUID_Parent = objLocalConfig.SemItem_Type_Development_Structure.GUID
                objSemItem_DevStructure.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                RaiseEvent applied_DevStructure(objSemItem_DevStructure)
            End If
        End If
    End Sub

    Private Sub ToolStripButton_AddStructure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddStructure.Click
        Dim objSemItem_DevStructure As New clsSemItem

        objSemItem_DevStructure.GUID = Guid.NewGuid
        objSemItem_DevStructure.GUID_Parent = objLocalConfig.SemItem_Type_Development_Structure.GUID
        objSemItem_DevStructure.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        objSemItem_DevStructure.new_Item = True

        objFrm_DevelopmentStructure = New frmDevelopmentStructure(objSemItem_DevStructure, objSemItem_Development)
        objFrm_DevelopmentStructure.ShowDialog(Me)

        fill_DevelopmentStructures()
    End Sub

    Private Sub TreeView_DevStructures_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView_DevStructures.BeforeExpand
        Dim objTreeNode_Process As TreeNode
        Dim objTreeNode_Sub_L1 As TreeNode
        Dim objTreeNode_Sub_L2 As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim objDRC_Processes As DataRowCollection
        Dim boolSub As Boolean

        objTreeNode_Process = e.Node

        If Not objTreeNode_Process Is Nothing Then
            If Not objTreeNode_Process.ImageIndex = cintImageID_DevStructure And _
                Not objTreeNode_Process.ImageIndex = cintImageID_Root Then
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
                                objTreeNode_Sub_L2 = objTreeNode_Sub_L1.Nodes.Add(objDR_Processes.Item("GUID_Process_L2").ToString, objDR_Processes.Item("Name_Process_L2"), cintImageID_Process, cintImageID_Process)
                            Else
                                objTreeNode_Sub_L2 = objTreeNodes(0)

                            End If
                            get_Invoke(objTreeNode_Sub_L2)
                            get_DevProcessType(objTreeNode_Sub_L2)
                        End If
                    End If


                Next
            End If
        End If
        
    End Sub

    Private Sub TreeView_DevStructures_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_DevStructures.DoubleClick
        Dim objTreeNode As TreeNode
        Dim objSemItem_Token As New clsSemItem
        Dim objTreeNodes() As TreeNode


        objTreeNode = TreeView_DevStructures.SelectedNode

        If Not objTreeNode Is Nothing Then
            If Not objTreeNode.ImageIndex = cintImageID_Root Then
                If objTreeNode.ImageIndex = cintImageID_DevStructure Then
                    objSemItem_Token.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Token.Name = objTreeNode.Text
                    objSemItem_Token.GUID_Parent = objLocalConfig.SemItem_Type_Development_Structure.GUID
                    objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Else
                    objSemItem_Token.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Token.Name = objTreeNode.Text
                    objSemItem_Token.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                    objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objFrm_TokenEditor = New frmTokenEdit(objSemItem_Token, objLocalConfig.Globals)
                    objFrm_TokenEditor.ShowDialog(Me)
                End If

                
                fill_DevelopmentStructures()

                objTreeNodes = TreeView_DevStructures.Nodes.Find(objTreeNode.Name, True)
                If objTreeNodes.Count > 0 Then
                    TreeView_DevStructures.SelectedNode = objTreeNodes(0)
                End If

           
            End If
        End If
    End Sub

    Private Sub TreeView_DevStructures_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView_DevStructures.KeyDown
        Dim objTreeNode As TreeNode
        Dim objTreeNodes() As TreeNode
        Select Case e.KeyCode
            Case Keys.F5
                objTreeNode = TreeView_DevStructures.SelectedNode
                fill_DevelopmentStructures()
                objTreeNodes = TreeView_DevStructures.Nodes.Find(objTreeNode.Name, True)
                If objTreeNodes.Count > 0 Then
                    TreeView_DevStructures.SelectedNode = objTreeNodes(0)
                End If
        End Select
    End Sub

    Private Sub TreeView_DevStructures_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView_DevStructures.MouseDoubleClick
        Dim objSemItem_DevStructure As New clsSemItem
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_DevStructures.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cintImageID_DevStructure Then
                objSemItem_DevStructure.GUID = New Guid(objTreeNode.Name)
                objSemItem_DevStructure.Name = objTreeNode.Text
                objSemItem_DevStructure.GUID_Parent = objLocalConfig.SemItem_Type_Development_Structure.GUID
                objSemItem_DevStructure.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objFrm_DevelopmentStructure = New frmDevelopmentStructure(objSemItem_DevStructure, objSemItem_Development)
                objFrm_DevelopmentStructure.ShowDialog(Me)

            End If
        End If
    End Sub

    Private Sub LogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogToolStripMenuItem.Click

        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_DevStructures.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cintImageID_DevStructure Then
                objLogWork_Local.GUID_Related = New Guid(objTreeNode.Name)
                objLogWork_Local.log_Entry(objSemItem_Development)

            End If

        End If

    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click
        Dim objSemItem_Process As New clsSemItem
        Dim objTreeNode As TreeNode

        


        objTreeNode = TreeView_DevStructures.SelectedNode

        If Not objTreeNode Is Nothing Then
            objSemItem_Process.GUID = New Guid(objTreeNode.Name)
            objSemItem_Process.Name = objTreeNode.Text
            objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
            objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            set_ProcessType(objSemItem_Process, objTreeNode, objLocalConfig.SemItem_Token_Dev_Structure_Database)
        End If

        
    End Sub

    Private Sub set_ProcessType(ByVal objSemItem_Process As clsSemItem, ByVal objTreeNode_Process As TreeNode, Optional ByVal objSemItem_ProcessType As clsSemItem = Nothing)
        Dim objDRC_ProcessType As DataRowCollection
        Dim objDRC_ImageID As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_ProcessTypeOfProcess As New clsSemItem
        Dim intImageID As Integer

        If Not objSemItem_ProcessType Is Nothing Then
            objDRC_ImageID = procA_TokenAttribute_Int.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_ProcessType.GUID, objLocalConfig.SemItem_Attribute_ImageID.GUID).Rows
            If objDRC_ImageID.Count > 0 Then
                intImageID = objDRC_ImageID(0).Item("Val")
            End If
        End If


        objDRC_ProcessType = procA_ProcessTypeOfProcess.GetData(objLocalConfig.SemItem_Attribute_ImageID.GUID, _
                                                           objLocalConfig.SemItem_Type_Process.GUID, _
                                                           objLocalConfig.SemItem_Type_Dev_Structure__Process_Type_to_Process_.GUID, _
                                                           objLocalConfig.SemItem_Type_Dev_Structure.GUID, _
                                                           objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                           objSemItem_Process.GUID).Rows

        If objDRC_ProcessType.Count > 0 Then
            If Not objSemItem_ProcessType Is Nothing Then
                objSemItem_ProcessTypeOfProcess.GUID = objDRC_ProcessType(0).Item("GUID_Dev_Structure__Process_Type_to_Process_")
                objSemItem_ProcessTypeOfProcess.Name = objDRC_ProcessType(0).Item("Name_Dev_Structure__Process_Type_to_Process_")
                objSemItem_ProcessTypeOfProcess.GUID_Parent = objLocalConfig.SemItem_Type_Dev_Structure__Process_Type_to_Process_.GUID
                objSemItem_ProcessTypeOfProcess.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                If Not objDRC_ProcessType(0).Item("GUID_Dev_Structure") = objSemItem_ProcessType.GUID Then
                    objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ProcessTypeOfProcess.GUID, _
                                                                           objDRC_ProcessType(0).Item("GUID_Dev_Structure"), _
                                                                           objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ProcessTypeOfProcess.GUID, _
                                                                                objSemItem_ProcessType.GUID, _
                                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            objTreeNode_Process.ImageIndex = intImageID
                            objTreeNode_Process.SelectedImageIndex = intImageID
                        Else

                            MsgBox("Der Prozesstyp kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                End If
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDRC_ProcessType(0).Item("GUID_Dev_Structure__Process_Type_to_Process_"), objDRC_ProcessType(0).Item("GUID_Dev_Structure"), objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDRC_ProcessType(0).Item("GUID_Dev_Structure__Process_Type_to_Process_"), objSemItem_Process.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objDRC_ProcessType(0).Item("GUID_Dev_Structure__Process_Type_to_Process_")).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                            objTreeNode_Process.Text = objSemItem_Process.Name
                            objTreeNode_Process.ImageIndex = cintImageID_Process
                            objTreeNode_Process.SelectedImageIndex = cintImageID_Process
                        Else
                            MsgBox("Der Prozesstyp kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                        End If

                    Else
                        MsgBox("Der Prozesstyp kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                    End If

                Else
                    MsgBox("Der Prozesstyp kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                End If

            End If



        Else
            If Not objSemItem_ProcessType Is Nothing Then
                objSemItem_ProcessTypeOfProcess.GUID = Guid.NewGuid
                objSemItem_ProcessTypeOfProcess.Name = objSemItem_Process.Name & "\" & objSemItem_ProcessType.Name
                If objSemItem_ProcessTypeOfProcess.Name.Length > 255 Then
                    objSemItem_ProcessTypeOfProcess.Name = objSemItem_ProcessTypeOfProcess.Name.Substring(0, 125) & _
                    "..." & _
                    objSemItem_ProcessTypeOfProcess.Name.Substring(objSemItem_ProcessTypeOfProcess.Name.Length - 125, 125)
                End If
                objSemItem_ProcessTypeOfProcess.GUID_Parent = objLocalConfig.SemItem_Type_Dev_Structure__Process_Type_to_Process_.GUID
                objSemItem_ProcessTypeOfProcess.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_ProcessTypeOfProcess.GUID, _
                                                                     objSemItem_ProcessTypeOfProcess.Name, _
                                                                     objSemItem_ProcessTypeOfProcess.GUID_Parent, True).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ProcessTypeOfProcess.GUID, _
                                                                            objSemItem_ProcessType.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ProcessTypeOfProcess.GUID, _
                                                                                objSemItem_Process.GUID, _
                                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            objTreeNode_Process.ImageIndex = intImageID
                            objTreeNode_Process.SelectedImageIndex = intImageID
                        Else


                            MsgBox("Der Typ kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Der Typ kann nicht geändert werden!", MsgBoxStyle.Exclamation)

                    End If
                Else
                    MsgBox("Der Typ kann nicht geändert werden!", MsgBoxStyle.Exclamation)

                End If
            Else
                objTreeNode_Process.Text = objSemItem_Process.Name
                objTreeNode_Process.ImageIndex = cintImageID_Process
                objTreeNode_Process.SelectedImageIndex = cintImageID_Process
            End If

        End If


    End Sub

    Private Sub LoopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoopToolStripMenuItem.Click
        Dim objSemItem_Process As New clsSemItem
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_DevStructures.SelectedNode

        If Not objTreeNode Is Nothing Then
            objSemItem_Process.GUID = New Guid(objTreeNode.Name)
            objSemItem_Process.Name = objTreeNode.Text
            objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
            objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            set_ProcessType(objSemItem_Process, objTreeNode, objLocalConfig.SemItem_Token_Dev_Structure_Schleife)
        End If
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnToolStripMenuItem.Click
        Dim objSemItem_Process As New clsSemItem
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_DevStructures.SelectedNode

        If Not objTreeNode Is Nothing Then
            objSemItem_Process.GUID = New Guid(objTreeNode.Name)
            objSemItem_Process.Name = objTreeNode.Text
            objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
            objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            set_ProcessType(objSemItem_Process, objTreeNode, objLocalConfig.SemItem_Token_Dev_Structure_Return)
        End If
    End Sub

    Private Sub ProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessToolStripMenuItem.Click
        Dim objSemItem_Process As New clsSemItem
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_DevStructures.SelectedNode

        If Not objTreeNode Is Nothing Then
            objSemItem_Process.GUID = New Guid(objTreeNode.Name)
            objSemItem_Process.Name = objTreeNode.Text
            objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
            objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            set_ProcessType(objSemItem_Process, objTreeNode)
        End If
    End Sub

    Private Sub CopyNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyNameToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_DevStructures.SelectedNode

        If Not objTreeNode Is Nothing Then
            Clipboard.SetDataObject(objTreeNode.Text)
        End If
    End Sub
End Class
