Public Class UserControl_ObjectTree
    Private objLocalConfig As clsLocalConfig
    Private objDBLevel As clsDBLevel
    Private objOItem_Object As clsObjectTree

    Private objThread As Threading.Thread
    Private objTreeNodes_Thread As New List(Of TreeNode)

    Private objOItem_Parent As clsOntologyItem
    Private objOItem_RelationType As clsOntologyItem
    Private oItems_No_Parent As Object
    Private intRowID_No_Parent As Integer
    Private intRowID_Parent As String

    Private boolTopDown As Boolean
    Private boolDataGet As Boolean

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        objOItem_RelationType = objLocalConfig.Globals.RelationType_contains
        ToolStripTextBox_RelationType.Text = objOItem_RelationType.Name

        set_DBConnection()
    End Sub

    Public Sub clear()
        TreeView_Objects.Nodes.Clear()
    End Sub

    Private Sub set_DBConnection()

    End Sub

    Private Sub fill_Tree()
        TreeView_Objects.Nodes.Clear()

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
        objDBLevel = New clsDBLevel(objLocalConfig)

        If boolTopDown = True Then
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

        objOItem_Parent = OItem_Parent
        boolTopDown = True
        get_RelationType()

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
                dblPrc = 100 / intAll * intRowID_No_Parent + intRowID_Parent
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
End Class
