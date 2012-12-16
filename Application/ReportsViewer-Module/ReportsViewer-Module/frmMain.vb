Imports Sem_Manager
Imports Security_Module
Public Class frmMain
    Private cint_ImageID_Root As Integer = 0
    Private cint_ImageID_Report As Integer = 1

    Private objLocalConfig As clsLocalConfig

    Private objUserData As clsUserData

    Private WithEvents objUserControl_Report As UserControl_Report
    Private objFrmAuthenticate As frmAuthenticate
    
    Private objTreeNode_Root As TreeNode

    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Dispose()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        objUserControl_Report = New UserControl_Report(objLocalConfig)
        objUserControl_Report.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(objUserControl_Report)
        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()

        objFrmAuthenticate = New frmAuthenticate(frmAuthenticate.ERelateMode.NoRelate, True, False)
        objFrmAuthenticate.ShowDialog(Me)

        If objFrmAuthenticate.DialogResult = Windows.Forms.DialogResult.OK Then
            objLocalConfig.SemItem_User = objFrmAuthenticate.SemItem_User
        Else
            objLocalConfig.SemItem_User = Nothing
        End If

        objUserData.initailze_ReportTree()
        Do
        Loop While objUserData.finished_Data_ReportTree = False

        objUserData.initialize_Reports()

        fill_Tree()

        
    End Sub

    Private Sub fill_Tree(Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode
        Dim objDRs_Nodes() As DataRow
        Dim objDR_Node As DataRow

        If objTreeNode Is Nothing Then
            TreeView_Report.Nodes.Clear()
            objTreeNode_Root = TreeView_Report.Nodes.Add(objLocalConfig.SemItem_Type_Reports.GUID.ToString, _
                                                         objLocalConfig.SemItem_Type_Reports.Name, _
                                                         cint_ImageID_Root, cint_ImageID_Root)
            objDRs_Nodes = objUserData.ReportTree_procT.Select("GUID_Report_Parent IS NULL")
            For Each objDR_Node In objDRs_Nodes
                objTreeNode_Sub = objTreeNode_Root.Nodes.Add(objDR_Node.Item("GUID_Report").ToString, _
                                           objDR_Node.Item("Name_Report"),
                                           cint_ImageID_Report, cint_ImageID_Report)
                fill_Tree(objTreeNode_Sub)
            Next

        Else
            objDRs_Nodes = objUserData.ReportTree_procT.Select("GUID_Report_Parent='" & objTreeNode.Name & "'")
            For Each objDR_Node In objDRs_Nodes
                objTreeNode_Sub = objTreeNode.Nodes.Add(objDR_Node.Item("GUID_Report").ToString, _
                                           objDR_Node.Item("Name_Report"),
                                           cint_ImageID_Report, cint_ImageID_Report)

                fill_Tree(objTreeNode_Sub)
            Next
        End If
    End Sub

    Private Sub set_DBConnection()
        objUserData = New clsUserData(objLocalConfig)
    End Sub

    Private Sub TreeView_Report_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Report.AfterSelect
        Dim objSemItem_Report As New clsSemItem
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Report.SelectedNode
        objUserControl_Report.initialize(Nothing)
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Report Then
                objSemItem_Report.GUID = New Guid(objTreeNode.Name)
                objSemItem_Report.Name = objTreeNode.Text
                objSemItem_Report.GUID_Parent = objLocalConfig.SemItem_Type_Reports.GUID
                objSemItem_Report.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                objUserControl_Report.initialize(objSemItem_Report)
            End If
        End If

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
