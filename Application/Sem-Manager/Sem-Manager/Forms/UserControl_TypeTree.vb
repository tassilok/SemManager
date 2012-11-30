Public Class UserControl_TypeTree
    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Class_Closed As Integer = 1
    Private Const cint_ImageID_Class_Opened As Integer = 2
    Private Const cint_ImageID_Attribute As Integer = 3
    Private Const cint_ImageID_RelationType As Integer = 4

    Private _dragdropCopy As Boolean = False
    Private _dragEventArgs As DragEventArgs
    Private _mouseButton As MouseButtons


    Private objLocalConfig As clsLocalConfig_TypeTree

    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private funcA_TypesTree As New ds_TypeTableAdapters.func_TypesTreeTableAdapter
    Private func_TypesTree As New ds_Type.func_TypesTreeDataTable
    Private typefuncA_Types_Rel As New ds_TypeTableAdapters.typefunc_Types_RelTableAdapter
    Private typefuncA_Types_With_Attributes_And_Types As New ds_TypeTableAdapters.typefunc_Types_With_Attributes_And_TypesTableAdapter
    Private objSemClipboard As clsSemClipboard


    Private semproc_DBWork_Save_Type As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TypeTableAdapter

    Private objTransaction_Types As clsTransaction_Types

    Private objDlg_Attribute_Varchar255 As dlgAttribute_Varchar255
    Private objFrmSemManager As frmSemManager

    Private objSemWork As clsSemWork
    Private objSemItem_Start As clsSemItem
    Private objSemItems_Type() As clsSemItem
    Private objSemItem_Selected As New clsSemItem
    Private objTreeNode_Selected As TreeNode
    Private objTreeNode_Root As TreeNode
    Private objTreeNode_Attribute As TreeNode
    Private objTreeNode_RelationType As TreeNode

    Private objFrmTypeEdit As frmTypeEdit
    Private boolApplyable As Boolean
    Private boolPChange_Filter As Boolean
    Private boolNoChange As Boolean
    Private boolRelAttrib As Boolean

    Public Event Applyied_Item()

    Public Event selected_Item()

 
    Public ReadOnly Property GUID_Type_Selected() As Guid
        Get
            Return objSemItem_Selected.GUID_Type
        End Get
    End Property
    Public ReadOnly Property SemItem_Selected()
        Get
            Return objSemItem_Selected
        End Get
    End Property

    Public Function select_Type(ByVal SemItem_Type As clsSemItem) As clsSemItem
        Dim objTreeNodes() As TreeNode
        Dim objSemItem_Result As clsSemItem

        boolNoChange = True
        objTreeNodes = TreeView_Types.Nodes.Find(SemItem_Type.GUID.ToString, True)
        If objTreeNodes.Count > 0 Then
            TreeView_Types.SelectedNode = objTreeNodes(0)
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        boolNoChange = False
        Return objSemItem_Result
    End Function


    Public Property Applyable() As Boolean
        Get
            Return boolApplyable

        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
            set_Controls_Applyable()
        End Set
    End Property

    Public Sub New(ByVal Globals As clsGlobals, Optional ByVal showRelAttrib As Boolean = True)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_TypeTree(Globals)

        boolRelAttrib = showRelAttrib

        initialize()
    End Sub

    Public Sub New(ByVal SemItem As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_TypeTree(Globals)
        objSemItem_Start = SemItem

        boolRelAttrib = True

        initialize()
    End Sub
    Public Sub New(ByVal SemItems_Type() As clsSemItem, ByVal Globals As clsGlobals)
        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_TypeTree(Globals)
        objSemItems_Type = SemItems_Type

        boolRelAttrib = True

        initialize()
    End Sub

    Private Sub set_Controls_Applyable()
        ApplyToolStripMenuItem.Visible = boolApplyable
    End Sub
    Private Sub initialize()


        set_DBConnection()
        get_Types()
        fill_TreeView()
        get_SelectedNode()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Type.Connection = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)
        funcA_TypesTree.Connection = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)
        semproc_DBWork_Save_Type.Connection = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)
        objTransaction_Types = New clsTransaction_Types(objLocalConfig.Globals)
        typefuncA_Types_With_Attributes_And_Types.Connection = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)
        typefuncA_Types_Rel.Connection = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)

        objSemClipboard = New clsSemClipboard(objLocalConfig.Globals)
    End Sub

    Private Sub get_Types()
        func_TypesTree.Clear()
        funcA_TypesTree.Fill(func_TypesTree)
    End Sub

    Private Sub fill_TreeView()
        TreeView_Types.Nodes.Clear()
        If Not objSemItem_Start Is Nothing Then
            fill_StartItem()
        ElseIf Not objSemItems_Type Is Nothing Then
            fill_StartTypes()
        End If
        fill_Types()
        fill_Attributes_and_RelationTypes()
        TreeView_Types.Nodes(0).Expand()
    End Sub
    Private Sub fill_StartTypes()
        Dim objSemItem_Type As clsSemItem
        Dim objDRs_Type() As DataRow
        Dim objDR_Type As DataRow
        Dim objTreeNode_Type As TreeNode
        objSemWork = New clsSemWork(objLocalConfig.Globals)
        objSemWork.Relations = True
        For Each objSemItem_Type In objSemItems_Type
            objSemWork.add_Type(objSemItem_Type.GUID, True, False)
        Next

        objDRs_Type = objSemWork.semtblT_Type.Select("GUID_Type_Parent is null")
        For Each objDR_Type In objDRs_Type
            objTreeNode_Type = TreeView_Types.Nodes.Add(objDR_Type.Item("GUID_Type").ToString, objDR_Type.Item("Name_Type"), cint_ImageID_Class_Closed, cint_ImageID_Class_Opened)
            Fill_Type_From_StartTypes(objTreeNode_Type)
        Next
    End Sub

    Private Sub Fill_Type_From_StartTypes(ByVal objTreeNode_Parent As TreeNode)
        Dim objDRs_Type() As DataRow
        Dim objDR_Type As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Sub As TreeNode
        objDRs_Type = objSemWork.semtblT_Type.Select("GUID_Type_Parent='" & objTreeNode_Parent.Name & "'")
        For Each objDR_Type In objDRs_Type
            objTreeNodes = objTreeNode_Parent.Nodes.Find(objDR_Type.Item("GUID_Type").ToString, False)
            If objTreeNodes.Length = 0 Then
                objTreeNode_Sub = objTreeNode_Parent.Nodes.Add(objDR_Type.Item("GUID_Type").ToString, objDR_Type.Item("Name_Type"), cint_ImageID_Class_Closed, cint_ImageID_Class_Opened)
                Fill_Type_From_StartTypes(objTreeNode_Sub)
            Else
                objTreeNode_Sub = objTreeNodes(0)
            End If
        Next
    End Sub

    Private Sub fill_StartItem()
        Dim objTreeNode As TreeNode
        Select Case objSemItem_Start.GUID
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objTreeNode = TreeView_Types.Nodes.Add(objSemItem_Start.GUID.ToString, objSemItem_Start.Name, cint_ImageID_Attribute, cint_ImageID_Attribute)
            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objTreeNode = TreeView_Types.Nodes.Add(objSemItem_Start.GUID.ToString, objSemItem_Start.Name, cint_ImageID_RelationType, cint_ImageID_RelationType)


        End Select
        Select Case objSemItem_Start.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objTreeNode = TreeView_Types.Nodes.Add(objSemItem_Start.GUID.ToString, objSemItem_Start.Name, cint_ImageID_Class_Closed, cint_ImageID_Class_Opened)
        End Select
    End Sub

    Private Sub fill_Types()
        Dim objDR_Type As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Sub As TreeNode



        For Each objDR_Type In func_TypesTree.Rows
            If Not IsDBNull(objDR_Type.Item("GUID_Type_Parent")) Then
                If Not objDR_Type.Item("GUID_Type_Parent").ToString = objTreeNode_Root.Name Then
                    objTreeNodes = objTreeNode_Root.Nodes.Find(objDR_Type.Item("GUID_Type_Parent").ToString, True)
                    For Each objTreeNode In objTreeNodes
                        objTreeNode_Sub = objTreeNode.Nodes.Add(objDR_Type.Item("GUID_Type").ToString, objDR_Type.Item("Name_Type"), cint_ImageID_Class_Closed, cint_ImageID_Class_Opened)
                    Next
                Else
                    objTreeNode_Sub = objTreeNode_Root.Nodes.Add(objDR_Type.Item("GUID_Type").ToString, objDR_Type.Item("Name_Type"), cint_ImageID_Class_Closed, cint_ImageID_Class_Opened)
                End If

            Else
                objTreeNode_Root = TreeView_Types.Nodes.Add(objDR_Type.Item("GUID_Type").ToString, objDR_Type.Item("Name_Type"), cint_ImageID_Class_Closed, cint_ImageID_Class_Opened)

            End If
        Next
    End Sub
    Private Sub fill_Attributes_and_RelationTypes()
        If boolRelAttrib = True Then
            TreeView_Types.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString, objLocalConfig.Globals.ObjectReferenceType_Attribute.Name, cint_ImageID_Attribute, cint_ImageID_Attribute)
            TreeView_Types.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString, objLocalConfig.Globals.ObjectReferenceType_RelationType.Name, cint_ImageID_RelationType, cint_ImageID_RelationType)
        End If
        
    End Sub

    Private Sub TreeView_Types_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Types.AfterSelect

        get_SelectedNode()

    End Sub

    Private Sub get_SelectedNode()
        objTreeNode_Selected = TreeView_Types.SelectedNode
        If Not objTreeNode_Selected Is Nothing Then
            objSemItem_Selected.GUID = New Guid(objTreeNode_Selected.Name)
            objSemItem_Selected.Name = objTreeNode_Selected.Text

            Select Case objTreeNode_Selected.ImageIndex
                Case cint_ImageID_Attribute
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                Case cint_ImageID_Class_Closed, cint_ImageID_Root
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                Case cint_ImageID_RelationType
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

            End Select
            ToolStripTextBox_GUID.Text = objSemItem_Selected.GUID.ToString
            RaiseEvent selected_Item()
        Else
            ToolStripTextBox_GUID.Text = ""
        End If
    End Sub

    Private Sub Open_Type(ByVal objTreeNode As TreeNode)
        Dim objSemItem_Type As New clsSemItem
        Dim objDRC_Type As DataRowCollection

        objSemItem_Type.GUID = New Guid(objTreeNode.Name)
        objSemItem_Type.Name = objTreeNode.Text
        objSemItem_Type.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

        objDRC_Type = semtblA_Type.GetData_By_GUID(objSemItem_Type.GUID).Rows
        If objDRC_Type.Count > 0 Then
            If Not IsDBNull(objDRC_Type(0).Item("GUID_Type_Parent")) Then
                objSemItem_Type.GUID_Parent = objDRC_Type(0).Item("GUID_Type_Parent")
            End If

            objFrmTypeEdit = New frmTypeEdit(objSemItem_Type, objLocalConfig.Connction_DB, objLocalConfig.Globals)
            objFrmTypeEdit.ShowDialog(Me)
            If objFrmTypeEdit.changed_Name = True Then
                objTreeNode.Text = objFrmTypeEdit.SemItem_Type.Name
            End If
        Else
            MsgBox("Die Klasse existiert nicht mehr!", MsgBoxStyle.Critical)
        End If



    End Sub

    Private Sub TreeView_Types_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_Types.DoubleClick

        If Not objTreeNode_Selected Is Nothing Then
            Select Case objTreeNode_Selected.ImageIndex
                Case cint_ImageID_Class_Closed
                    Open_Type(objTreeNode_Selected)

                Case cint_ImageID_Attribute

                Case cint_ImageID_RelationType

            End Select
        End If
    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click

        If Not objTreeNode_Selected Is Nothing Then
            objSemItem_Selected.GUID = New Guid(objTreeNode_Selected.Name)
            objSemItem_Selected.Name = objTreeNode_Selected.Text

            Select Case objTreeNode_Selected.ImageIndex
                Case cint_ImageID_Attribute
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                Case cint_ImageID_Class_Closed, cint_ImageID_Root
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                Case cint_ImageID_RelationType
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

            End Select
        Else
            objSemItem_Selected = Nothing

        End If
        If boolNoChange = False Then
            RaiseEvent Applyied_Item()
        End If

    End Sub

    Private Sub NeuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuToolStripMenuItem.Click
        Dim objDRC_LogState As DataRowCollection

        Dim objTreeNode_Parent As TreeNode
        Dim objTreeNode_Child As TreeNode
        Dim objSemItem_Type As New clsSemItem



        objTreeNode_Parent = objTreeNode_Selected
        If Not objTreeNode_Parent Is Nothing Then
            objDlg_Attribute_Varchar255 = New dlgAttribute_Varchar255("New " & objLocalConfig.Globals.ObjectReferenceType_Type.Name, objLocalConfig.Globals, Nothing, Nothing, True)
            objDlg_Attribute_Varchar255.ShowDialog(Me)
            If objDlg_Attribute_Varchar255.DialogResult = DialogResult.OK Then
                If objLocalConfig.Globals.is_GUID(objDlg_Attribute_Varchar255.GUID.ToString) Then
                    objSemItem_Type.GUID = objDlg_Attribute_Varchar255.GUID
                Else
                    objSemItem_Type.GUID = Guid.NewGuid
                End If

                objSemItem_Type.Name = objDlg_Attribute_Varchar255.Value1
                objSemItem_Type.GUID_Parent = New Guid(objTreeNode_Parent.Name)
                objSemItem_Type.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objDRC_LogState = semproc_DBWork_Save_Type.GetData(objSemItem_Type.GUID, objSemItem_Type.Name, objSemItem_Type.GUID_Parent).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    objTreeNode_Child = objTreeNode_Parent.Nodes.Add(objSemItem_Type.GUID.ToString, objSemItem_Type.Name, cint_ImageID_Class_Closed, cint_ImageID_Class_Opened)
                ElseIf objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Exists.GUID Then
                    MsgBox("Es gibt bereits einen Typ mit dem Namen!", MsgBoxStyle.Exclamation)
                End If

            End If
        End If
    End Sub

    Private Sub TreeView_Types_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView_Types.DragDrop
        _dragEventArgs = e

        ' Behandlung von Verschieben oder Kopieren:
        If _mouseButton = MouseButtons.Right Then
            'Kontext-Menü!!!
        Else
            _dragdropCopy = (e.Effect = DragDropEffects.Copy)
            DragDropVerarbeiten()
        End If
    End Sub

    Private Sub DragDropVerarbeiten()
        Dim sourceNode As TreeNode = TryCast(_dragEventArgs.Data.GetData(GetType(TreeNode)), TreeNode)

        Dim p As Point = TreeView_Types.PointToClient(New Point(_dragEventArgs.X, _dragEventArgs.Y))
        Dim targetNode As TreeNode = TreeView_Types.GetNodeAt(p)

        Dim objTreeNode_parent As TreeNode

        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Type As New clsSemItem

        Dim boolMove As Boolean

        If Not targetNode Is Nothing And Not sourceNode Is Nothing Then
            If Not sourceNode.Name = objTreeNode_Root.Name Then
                If Not sourceNode.Name = targetNode.Name Then
                    objTreeNode_parent = targetNode.Parent
                    boolMove = True
                    While Not objTreeNode_parent Is Nothing
                        If objTreeNode_parent.Name = sourceNode.Name Then
                            boolMove = False
                            MsgBox("Bitte keine Knoten untergeortneten Knoten zuordnen!", MsgBoxStyle.Exclamation)
                            Exit While
                        End If
                        objTreeNode_parent = objTreeNode_parent.Parent
                    End While

                    If boolMove = True Then
                        objSemItem_Type.GUID = New Guid(sourceNode.Name)
                        objSemItem_Type.Name = sourceNode.Text
                        objSemItem_Type.GUID_Parent = New Guid(targetNode.Name)
                        objSemItem_Type.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                        objSemItem_Result = objTransaction_Types.save_001_Type(objSemItem_Type)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            targetNode.Nodes.Add(sourceNode.Name, sourceNode.Text, sourceNode.ImageIndex, sourceNode.SelectedImageIndex)
                            sourceNode.Remove()
                            TreeView_Types.Nodes.Clear()
                            get_Types()
                            fill_Types()
                            select_Type(objSemItem_Type)
                        Else
                            MsgBox("Die Type konnte leider nicht verschoben werden!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                End If
                
            End If
        End If

    End Sub

    Private Sub TreeView_Types_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView_Types.DragEnter
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

    Private Sub TreeView_Types_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles TreeView_Types.ItemDrag
        Dim sourceNode As TreeNode = DirectCast(e.Item, TreeNode)

        _mouseButton = e.Button

        ' DragDrop beginnen:
        DoDragDrop(sourceNode, DragDropEffects.Move Or DragDropEffects.Copy)
    End Sub

    Private Sub TreeView_Types_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView_Types.KeyDown
        Dim objSemItem_ClipBoard As New clsSemItem
        Select Case e.KeyCode
            Case Keys.F5
                get_Types()
                fill_TreeView()
            Case Keys.ControlKey
                If e.Shift = True Then
                    objSemItem_ClipBoard = objSemClipboard.getFromClipboard(objLocalConfig.Globals.ObjectReferenceType_Type)
                    If Not objSemItem_ClipBoard Is Nothing Then
                        ToolTip_Clipboard.Show(objSemItem_ClipBoard.Name, Me, Cursor.Position, 1000)
                    End If
                End If
                

        End Select
    End Sub

    Private Sub CopyNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyNameToolStripMenuItem.Click


        If Not objTreeNode_Selected Is Nothing Then
            Clipboard.SetDataObject(objTreeNode_Selected.Text)
        End If
    End Sub

    Private Sub TreeView_Types_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TreeView_Types.KeyPress

    End Sub



    Private Sub TreeView_Types_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView_Types.MouseDown
        objTreeNode_Selected = TreeView_Types.GetNodeAt(e.Location)
        If Not objTreeNode_Selected Is Nothing Then
            TreeView_Types.SelectedNode = objTreeNode_Selected
        End If
    End Sub

    Private Sub ToolStripTextBox_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Filter.Click

    End Sub

    Private Sub ToolStripTextBox_Filter_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Filter.TextChanged
        If boolPChange_Filter = False Then
            ToolStripButton_mark.Checked = True
            Timer_Mark.Stop()
            Timer_Mark.Start()
        End If

    End Sub

    Private Sub Timer_Mark_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Mark.Tick
        Timer_Mark.Stop()
        start_Clear_Mark()
        If ToolStripButton_mark.Checked = True Then
            If Not ToolStripTextBox_Filter.Text = "" Then
                mark_Nodes(ToolStripTextBox_Filter.Text.ToLower)
            End If
        End If
    End Sub
    Private Sub mark_Nodes(ByVal strFind As String)
        Dim objTreeNode As TreeNode
        For Each objTreeNode In TreeView_Types.Nodes
            mark_Node(objTreeNode, strFind)

        Next
    End Sub
    Private Sub mark_Node(ByVal objTreeNode As TreeNode, ByVal strFind As String)
        Dim objTreeNode_Sub As TreeNode
        If objTreeNode.Text.ToLower.Contains(strFind) Then
            expandCollapse_Parents(objTreeNode, True)
            objTreeNode.BackColor = Color.Yellow
        End If

        For Each objTreeNode_Sub In objTreeNode.Nodes
            mark_Node(objTreeNode_Sub, strFind)
        Next
    End Sub

    Private Sub expandCollapse_Parents(ByVal objTreeNode As TreeNode, ByVal boolExpand As Boolean)
        Dim objTreeNode_Parent As TreeNode

        objTreeNode_Parent = objTreeNode
        Do Until objTreeNode_Parent Is Nothing
            objTreeNode_Parent = objTreeNode_Parent.Parent
            If Not objTreeNode_Parent Is Nothing Then
                If boolExpand = True Then
                    objTreeNode_Parent.Expand()
                Else
                    objTreeNode_Parent.Collapse()
                End If
            End If
        Loop
    End Sub
    Private Sub start_Clear_Mark()
        Dim objTreeNode As TreeNode

        For Each objTreeNode In TreeView_Types.Nodes
            clear_Mark(objTreeNode)
        Next
    End Sub

    Private Sub clear_Mark(ByVal objTreeNode As TreeNode)
        Dim objTreeNode_Sub As TreeNode
        objTreeNode.BackColor = Nothing

        For Each objTreeNode_Sub In objTreeNode.Nodes
            clear_Mark(objTreeNode_Sub)
        Next

    End Sub

    Private Sub ToolStripButton_mark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_mark.Click
        If ToolStripButton_mark.Checked = True Then
            ToolStripButton_mark.Checked = False
            start_Clear_Mark()
            boolPChange_Filter = True
            ToolStripTextBox_Filter.Text = ""
            boolPChange_Filter = False
        End If
    End Sub

    Private Sub ContextMenuStrip_Tree_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Tree.Opening
        Dim objTreeNode As TreeNode

        DuplicateToolStripMenuItem.Enabled = False
        ToClipboardToolStripMenuItem.Enabled = False

        objTreeNode = TreeView_Types.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Class_Closed Then
                DuplicateToolStripMenuItem.Enabled = True
                ToClipboardToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub DuplicateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuplicateToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Type_Parent As clsSemItem
        Dim objSemItem_Type As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_TypeAttribute As DataRowCollection
        Dim objDR_TypeAttribute As DataRow
        Dim objDRC_TypeRel As DataRowCollection
        Dim objDR_TypeRel As DataRow
        Dim objSemItem_Attribute As New clsSemItem
        Dim objSemItem_Type_Right As New clsSemItem
        Dim objTreeNodes() As TreeNode

        objTreeNode = TreeView_Types.SelectedNode
        If Not objTreeNode Is Nothing Then
            objDlg_Attribute_Varchar255 = New dlgAttribute_Varchar255("Duplicate Type", objLocalConfig.Globals, objTreeNode.Text)
            objDlg_Attribute_Varchar255.ShowDialog(Me)
            If objDlg_Attribute_Varchar255.DialogResult = DialogResult.OK Then
                If MsgBox("Wollen Sie eine andere Datenbank auswählen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                End If

                MsgBox("Bitte wählen Sie die Eltern-Type aus!", MsgBoxStyle.Information)
                objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                        If objFrmSemManager.SemItems_Selected.Count = 1 Then
                            objSemItem_Type_Parent = objFrmSemManager.SemItems_Selected(0)
                            objSemItem_Type.GUID = Guid.NewGuid
                            objSemItem_Type.Name = objDlg_Attribute_Varchar255.Value1
                            objSemItem_Type.GUID_Parent = objSemItem_Type_Parent.GUID
                            objSemItem_Type.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                            objSemItem_Result = objTransaction_Types.save_001_Type(objSemItem_Type)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objDRC_TypeAttribute = typefuncA_Types_With_Attributes_And_Types.GetData_Attributes_By_GUIDType(New Guid(objTreeNode.Name)).Rows
                                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                For Each objDR_TypeAttribute In objDRC_TypeAttribute
                                    objSemItem_Attribute.GUID = objDR_TypeAttribute.Item("GUID_Attribute")
                                    objSemItem_Attribute.Name = objDR_TypeAttribute.Item("Name_Attribute")
                                    objSemItem_Attribute.GUID_Parent = objDR_TypeAttribute.Item("GUID_AttributeType")
                                    objSemItem_Attribute.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                    objSemItem_Result = objTransaction_Types.save_003_TypeAttribute(objSemItem_Attribute, _
                                                                                                    objDR_TypeAttribute.Item("Min"), _
                                                                                                    objDR_TypeAttribute.Item("Max"))
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                        Exit For
                                    End If
                                Next
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objDRC_TypeRel = typefuncA_Types_Rel.GetData_By_GUID_Type_Left(New Guid(objTreeNode.Name)).Rows
                                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                    For Each objDR_TypeRel In objDRC_TypeRel
                                        objSemItem_Type_Right.GUID = objDR_TypeRel.Item("GUID_Type_Right")
                                        objSemItem_Type_Right.Name = objDR_TypeRel.Item("Name_Type_Right")
                                        objSemItem_Type_Right.GUID_Relation = objDR_TypeRel.Item("GUID_RelationType")
                                        objSemItem_Type_Right.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                                        objSemItem_Result = objTransaction_Types.save_002_TypeRel(objSemItem_Type_Right, _
                                                                                                  objDR_TypeRel.Item("Min_forw"), _
                                                                                                  objDR_TypeRel.Item("Max_forw"), _
                                                                                                  objDR_TypeRel.Item("Max_backw"))
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                            Exit For
                                        End If
                                    Next
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTreeNodes = TreeView_Types.Nodes.Find(objSemItem_Type_Parent.GUID.ToString, True)
                                        If objTreeNodes.Count = 1 Then
                                            objTreeNodes(0).Nodes.Add(objSemItem_Type.GUID.ToString, _
                                                          objSemItem_Type.Name, cint_ImageID_Class_Closed, cint_ImageID_Class_Opened)
                                            objTreeNodes(0).Expand()
                                        Else
                                            MsgBox("Die Elternklasse kann nicht gefunden werden!", MsgBoxStyle.Exclamation)
                                        End If
                                    Else
                                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                        For Each objDR_TypeRel In objDRC_TypeRel
                                            objSemItem_Type_Right.GUID = objDR_TypeRel.Item("GUID_Type_Right")
                                            objSemItem_Type_Right.Name = objDR_TypeRel.Item("Name_Type_Right")
                                            objSemItem_Type_Right.GUID_Relation = objDR_TypeRel.Item("GUID_RelationType")
                                            objSemItem_Type_Right.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                                            objSemItem_Result = objTransaction_Types.del_002_TypeRel(objSemItem_Type, objSemItem_Type_Right)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                                Exit For
                                            End If
                                        Next
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            For Each objDR_TypeAttribute In objDRC_TypeAttribute
                                                objSemItem_Attribute.GUID = objDR_TypeAttribute.Item("GUID_Attribute")
                                                objSemItem_Attribute.Name = objDR_TypeAttribute.Item("Name_Attribute")
                                                objSemItem_Attribute.GUID_Parent = objDR_TypeAttribute.Item("GUID_AttributeType")
                                                objSemItem_Attribute.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                                                objSemItem_Result = objTransaction_Types.del_003_TypeAttribute(objSemItem_Attribute)
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                                    Exit For
                                                End If
                                            Next
                                            MsgBox("Die Type konnte nicht dupliziert werden!", MsgBoxStyle.Exclamation)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_Types.del_001_Type()

                                            Else
                                                objTreeNodes = TreeView_Types.Nodes.Find(objSemItem_Type_Parent.GUID.ToString, True)
                                                If objTreeNodes.Count = 1 Then
                                                    objTreeNodes(0).Nodes.Add(objSemItem_Type.GUID.ToString, _
                                                                  objSemItem_Type.Name, cint_ImageID_Class_Closed, cint_ImageID_Class_Opened)
                                                    objTreeNodes(0).Expand()
                                                Else
                                                    MsgBox("Die Elternklasse kann nicht gefunden werden!", MsgBoxStyle.Exclamation)
                                                End If
                                            End If
                                        Else
                                            MsgBox("Die Klasse konnte nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                                        End If
                                    End If


                                Else
                                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                    For Each objDR_TypeAttribute In objDRC_TypeAttribute
                                        objSemItem_Attribute.GUID = objDR_TypeAttribute.Item("GUID_Attribute")
                                        objSemItem_Attribute.Name = objDR_TypeAttribute.Item("Name_Attribute")
                                        objSemItem_Attribute.GUID_Parent = objDR_TypeAttribute.Item("GUID_AttributeType")
                                        objSemItem_Attribute.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                                        objSemItem_Result = objTransaction_Types.del_003_TypeAttribute(objSemItem_Attribute)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                            Exit For
                                        End If
                                    Next
                                    MsgBox("Die Type konnte nicht dupliziert werden!", MsgBoxStyle.Exclamation)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_Types.del_001_Type()

                                    Else
                                        objTreeNodes = TreeView_Types.Nodes.Find(objSemItem_Type_Parent.GUID.ToString, True)
                                        If objTreeNodes.Count = 1 Then
                                            objTreeNodes(0).Nodes.Add(objSemItem_Type.GUID.ToString, _
                                                          objSemItem_Type.Name, cint_ImageID_Class_Closed, cint_ImageID_Class_Opened)
                                            objTreeNodes(0).Expand()
                                        Else
                                            MsgBox("Die Elternklasse kann nicht gefunden werden!", MsgBoxStyle.Exclamation)
                                        End If
                                    End If
                                End If

                            ElseIf objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then
                                MsgBox("Es existiert bereits eine Type mit dem Namen!", MsgBoxStyle.Exclamation)

                            End If
                        Else
                            MsgBox("Bitte nur eine Type auswählen!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Bitte nur Typen auswählen!", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ToClipboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToClipboardToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Type As New clsSemItem

        objTreeNode = TreeView_Types.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Class_Closed Then
                objSemItem_Type.GUID = New Guid(objTreeNode.Name)
                objSemItem_Type.Name = objTreeNode.Text
                objSemItem_Type.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                objSemClipboard.addToClipboard(objSemItem_Type)
            End If
        End If
    End Sub
End Class
