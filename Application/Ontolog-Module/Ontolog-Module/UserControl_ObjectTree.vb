﻿Public Class UserControl_ObjectTree
    Private objLocalConfig As clsLocalConfig
    Private objDBLevel As clsDBLevel
    Private objOItem_Object As clsObjectTree

    Private objThread As Threading.Thread
    Private objTreeNodes_Thread As New List(Of TreeNode)

    Private objOItem_Parent As clsOntologyItem
    Private objOItem_RelationType As clsOntologyItem
    Private oItems_No_Parent As Object
    Private oList_Objects As New List(Of clsOntologyItem)
    Private intRowID_No_Parent As Integer
    Private intRowID_Parent As String

    Private boolTopDown As Boolean
    Private boolDataGet As Boolean
    Private boolApplyable As Boolean

    Public Event applied_Objects()

    Public ReadOnly Property List_Objects As List(Of clsOntologyItem)
        Get
            Return oList_Objects
        End Get
    End Property
    Public Property Applyable As Boolean
        Get
            Return boolApplyable
        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
        End Set
    End Property

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        objOItem_RelationType = objLocalConfig.Globals.RelationType_contains
        ToolStripTextBox_RelationType.Text = objOItem_RelationType.Name
        boolApplyable = True

        set_DBConnection()
    End Sub

    Public Sub clear()
        TreeView_Objects.Nodes.Clear()
    End Sub

    Private Sub set_DBConnection()

    End Sub

    Private Sub fill_Tree()
        
        If Not objOItem_Parent Is Nothing Then
            boolTopDown = ToolStripButton_TopDown.Checked

            intRowID_No_Parent = 0
            intRowID_Parent = 0
            boolDataGet = False
            objTreeNodes_Thread.Clear()

            objThread = New Threading.Thread(AddressOf get_Tree)
            objThread.Start()
            Timer_Tree.Start()
        End If
    End Sub

    Private Sub get_Tree()
        Dim intID As Integer
        Dim objTreeNode As New TreeNode
        Dim objOItem As clsObjectTree
        Dim oList_Class As New List(Of clsOntologyItem)
        objDBLevel = New clsDBLevel(objLocalConfig)

        If boolTopDown = True Then
            oList_Class.Add(New clsOntologyItem(Nothing, Nothing, objOItem_Parent.GUID, objLocalConfig.Globals.Field_ID_Object))

            objDBLevel.get_Data_Objects_Tree(objOItem_Parent, objOItem_Parent, objOItem_RelationType)
            oItems_No_Parent = From obj In objDBLevel.OList_Objects
                                 Group Join objPar In objDBLevel.OList_ObjectTree On obj.GUID Equals objPar.ID_Object Into RightTableResult = Group
                                 From objPar In RightTableResult.DefaultIfEmpty
                                 Where objPar Is Nothing
                                 Select Guid = obj.GUID, Name = obj.Name, GUID_Parent = obj.GUID_Parent
                                 Order By Name

            intID = 0
            For Each objItem In oItems_No_Parent
                objTreeNode.Name = objItem.Guid
                objTreeNode.Text = objItem.Name
                
                objTreeNodes_Thread.Add(objTreeNode.Clone)


            Next

            For Each objOItem In objDBLevel.OList_ObjectTree
                objTreeNode.Name = objOItem.ID_Object
                objTreeNode.Text = objOItem.Name_Object

                Dim objTreeNodes = From obj In objTreeNodes_Thread
                                   Where obj.Name = objOItem.ID_Object_Parent

                For Each objTreeNode_sub In objTreeNodes
                    objTreeNode_sub.Nodes.Add(objTreeNode.Clone)
                Next
            Next
        End If

        boolDataGet = True
    End Sub

    Public Sub initialize(ByVal OItem_Parent As clsOntologyItem)
        Timer_Tree.Stop()
        ToolStripProgressBar_List.Visible = True

        Try
            objThread.Abort()

        Catch ex As Exception

        End Try
        boolDataGet = False
        objOItem_Parent = OItem_Parent
        intRowID_No_Parent = 0
        intRowID_Parent = 0
        boolTopDown = True
        get_RelationType()
        TreeView_Objects.Nodes.Clear()
        objTreeNodes_Thread.Clear()
        objThread = New Threading.Thread(AddressOf get_Tree)
        Timer_Tree.Start()
        objThread.Start()
    End Sub

    Private Sub get_RelationType()

    End Sub

    Private Sub Timer_Tree_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Tree.Tick
        Dim dateNow As Date
        Dim intAll As Integer
        Dim dblPrc As Double

        dateNow = Now

        ToolStripProgressBar_List.Visible = True


        If boolDataGet = True Then
            While (Now - dateNow).Milliseconds < 200
                intAll = objTreeNodes_Thread.Count + objDBLevel.OList_ObjectTree.Count
                If intAll <> 0 Then
                    dblPrc = 100 / intAll * intRowID_No_Parent + intRowID_Parent
                Else
                    dblPrc = 0
                End If

                ToolStripLabel_Count.Text = intRowID_No_Parent + intRowID_Parent
                ToolStripProgressBar_List.Value = dblPrc
                If intRowID_No_Parent < objTreeNodes_Thread.Count Then
                    If objTreeNodes_Thread(intRowID_No_Parent).Parent Is Nothing Then
                        TreeView_Objects.Nodes.Add(objTreeNodes_Thread(intRowID_No_Parent))
                    End If


                    intRowID_No_Parent = intRowID_No_Parent + 1
                Else
                    
                    Timer_Tree.Stop()
                    ToolStripProgressBar_List.Value = 0
                    ToolStripProgressBar_List.Visible = False

                End If
            End While

        End If

    End Sub

    Private Sub ToolStripButton_Change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Change.Click

    End Sub

    Private Sub ContextMenuStrip_Tree_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Tree.Opening
        Dim objTreeNode As TreeNode

        NewToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False
        FilterToolStripMenuItem.Enabled = False
        objTreeNode = TreeView_Objects.SelectedNode
        If Not objTreeNode Is Nothing Then
            FilterToolStripMenuItem.Enabled = True
            NewToolStripMenuItem.Enabled = True
            If objTreeNode.Nodes.Count = 0 Then
                DeleteToolStripMenuItem.Enabled = True
            End If

            ApplyToolStripMenuItem.Enabled = boolApplyable
        End If
    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        oList_Objects.Clear()

        If ToolStripButton_Checkboxes.Checked = True Then
            For Each objTreeNode In TreeView_Objects.Nodes
                If objTreeNode.Checked = True Then
                    oList_Objects.Add(New clsOntologyItem(objTreeNode.Name, objTreeNode.Text, objOItem_Parent.GUID, objLocalConfig.Globals.Type_Object))

                End If
                get_SelectedNodes(objTreeNode)
            Next
        Else
            objTreeNode = TreeView_Objects.SelectedNode
            oList_Objects.Add(New clsOntologyItem(objTreeNode.Name, objTreeNode.Text, objOItem_Parent.GUID, objLocalConfig.Globals.Type_Object))
        End If

        RaiseEvent applied_Objects()
    End Sub

    Private Sub get_SelectedNodes(Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode

        For Each objTreeNode_Sub In objTreeNode.Nodes
            If objTreeNode_Sub.Checked = True Then
                oList_Objects.Add(New clsOntologyItem(objTreeNode_Sub.Name, objTreeNode_Sub.Text, objOItem_Parent.GUID, objLocalConfig.Globals.Type_Object))

            End If
            get_SelectedNodes(objTreeNode)
        Next
    End Sub
End Class
