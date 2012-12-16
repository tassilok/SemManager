Imports Sem_Manager
Public Class frmScenesLiterature
    Private WithEvents objUserControl_SceneTree As UserControl_SceneTree
    Private WithEvents objUserControl_SceneDetail As UserControl_SceneDetail
    Private objLocalConfig As clsLocalConfig
    Private objSemItems_Relation(1) As clsSemItem

    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Close()
    End Sub

    Private Sub selected_Node(ByVal SemItem_Item As clsSemItem) Handles objUserControl_SceneTree.selected_Node
        Dim objSemItem_Item As New clsSemItem


        objSemItem_Item = SemItem_Item
        If objSemItem_Item.GUID_Parent = objLocalConfig.SemItem_Type_Szene.GUID Then
            objUserControl_SceneDetail.initialize_Scenes(objSemItem_Item)
        Else
            objSemItem_Item = Nothing
            objUserControl_SceneDetail.initialize_Scenes(objSemItem_Item)
        End If




    End Sub

    Private Sub test_Author()


        objSemItems_Relation(0) = New clsSemItem
        objSemItems_Relation(0).GUID = New Guid("35325335-833e-463e-9d8c-f8cffe99b5c8")
        objSemItems_Relation(0).GUID_Relation = New Guid("e9711603-47db-44d8-a476-fe88290639a4")
        objSemItems_Relation(0).Mark = True
        objSemItems_Relation(1) = New clsSemItem
        objSemItems_Relation(1).GUID = New Guid("a47c6de3-e732-463e-8591-fa5791b35c63")
        objSemItems_Relation(1).GUID_Relation = New Guid("e9711603-47db-44d8-a476-fe88290639a4")
        objUserControl_SceneTree = New UserControl_SceneTree(objSemItems_Relation, New clsGlobals)
        objUserControl_SceneTree.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Add(objUserControl_SceneTree)
    End Sub

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        initialize()
    End Sub

    Private Sub initialize()

        objLocalConfig = New clsLocalConfig(New clsGlobals)
        objUserControl_SceneDetail = New UserControl_SceneDetail(objLocalConfig)
        objUserControl_SceneDetail.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(objUserControl_SceneDetail)

        test_Author()
    End Sub
End Class
