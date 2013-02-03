Public Class UserControl_ObjectTree
    Private objLocalConfig As clsLocalConfig
    Private objDBLevel As clsDBLevel
    Private objOItem_Object As clsObjectTree

    Private objRelationType As clsOntologyItem

    Private objThread As Threading.Thread

    Private objOItem_Parent As clsOntologyItem
    Private intRowID As Integer

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

    Private Sub set_DBConnection()

    End Sub

    Private Sub fill_Tree()
        TreeView_Objects.Nodes.Clear()

        If Not objOItem_Parent Is Nothing Then
            boolTopDown = ToolStripButton_TopDown.Checked

            intRowID = 0
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

        get_RelationType()


    End Sub

    Private Sub get_RelationType()

    End Sub

    Private Sub Timer_Tree_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Tree.Tick
        Dim dateNow As Date
        Dim objTreeNodes() As TreeNode

        dateNow = Now

        ToolStripProgressBar_List.Visible = True

        While (Now - dateNow).Milliseconds <= 200
            If boolDataGet = True Then
                If intRowID = 0 Then
                    Dim oItems = From obj In objDBLevel.OList_ObjectTree 
                                 Join objPar In objDBLevel.OList_ObjectTree On obj.
                End If

            End If
        End While
    End Sub
End Class
