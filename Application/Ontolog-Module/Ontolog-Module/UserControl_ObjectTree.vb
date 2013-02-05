Public Class UserControl_ObjectTree
    Private objLocalConfig As clsLocalConfig
    Private objDBLevel As clsDBLevel
    Private objOItem_Object As clsObjectTree

    Private objRelationType As clsOntologyItem

    Private objThread As Threading.Thread

    Private objOItem_Parent As clsOntologyItem
    Private oItems_No_Parent As System.Collections.IDictionary
    Private intRowID_No_Parent As Integer
    Private intRowID_Parent As String

    Private boolTopDown As Boolean
    Private boolDataGet As Boolean

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        objRelationType = objLocalConfig.Globals.RelationType_contains
        ToolStripTextBox_RelationType.Text = objRelationType.Name

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
            objThread = New Threading.Thread(AddressOf get_Tree)
            objThread.Start()
            Timer_Tree.Start()
        End If
    End Sub

    Private Sub get_Tree()
        objDBLevel = New clsDBLevel(objLocalConfig)
        If boolTopDown = True Then
            objDBLevel.get_Data_Objects_Tree(objOItem_Parent, objOItem_Parent, objRelationType)
            oItems_No_Parent = From obj In objDBLevel.OList_Objects
                                 Join objPar In objDBLevel.OList_ObjectTree.DefaultIfEmpty On obj.GUID Equals objPar.ID_Object
                                 Where objPar.ID_Object Is Nothing
                                 Select ID_Object = obj.GUID, Name_Object = obj.Name, ID_Object_Parent = obj.GUID_Parent
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
        Dim objTreeNodes() As TreeNode

        dateNow = Now

        ToolStripProgressBar_List.Visible = True


        If boolDataGet = True Then
            While (Now - dateNow).Milliseconds < 200
                If intRowID_No_Parent < oItems_No_Parent.Count Then
                    objTreeNodes = TreeView_Objects.Nodes.Find(oItems_No_Parent(intRowID_No_Parent).ID_Object, False)
                    If objTreeNodes.Count = 0 Then
                        TreeView_Objects.Nodes.Add(oItems_No_Parent(intRowID_No_Parent).ID_Object, oItems_No_Parent(intRowID_No_Parent).Name)

                    End If
                    intRowID_No_Parent = intRowID_No_Parent + 1
                Else
                    If intRowID_Parent < objDBLevel.OList_ObjectTree.Count Then

                    End If
                End If
            End While

        End If

    End Sub
End Class
