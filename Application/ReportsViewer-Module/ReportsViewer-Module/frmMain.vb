Imports Sem_Manager
Public Class frmMain
    Private cint_ImageID_Root As Integer = 0
    Private cint_ImageID_Report As Integer = 1

    Private objLocalConfig As clsLocalConfig

    Private WithEvents objUserControl_Report As UserControl_Report

    Private procA_TokenTree_TopDown As New ds_TokenTableAdapters.proc_TokenTree_TopDownTableAdapter
    Private procT_TokenTree_TopDown As New ds_Token.proc_TokenTree_TopDownDataTable
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

        procA_TokenTree_TopDown.Fill(procT_TokenTree_TopDown, _
                                     objLocalConfig.SemItem_Type_Report.GUID, _
                                     objLocalConfig.SemItem_RelationType_Contains.GUID, _
                                     Nothing)
        fill_Tree()
    End Sub

    Private Sub fill_Tree(Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode
        Dim objDRs_Nodes() As DataRow
        Dim objDR_Node As DataRow

        If objTreeNode Is Nothing Then
            TreeView_Report.Nodes.Clear()
            objTreeNode_Root = TreeView_Report.Nodes.Add(objLocalConfig.SemItem_Type_Report.GUID.ToString, _
                                                         objLocalConfig.SemItem_Type_Report.Name, _
                                                         cint_ImageID_Root, cint_ImageID_Root)
            objDRs_Nodes = procT_TokenTree_TopDown.Select("GUID_Token_Parent IS NULL")
            For Each objDR_Node In objDRs_Nodes
                objTreeNode_Sub = objTreeNode_Root.Nodes.Add(objDR_Node.Item("GUID_Token").ToString, _
                                           objDR_Node.Item("Name_Token"),
                                           cint_ImageID_Report, cint_ImageID_Report)
                fill_Tree(objTreeNode_Sub)
            Next

        Else
            objDRs_Nodes = procT_TokenTree_TopDown.Select("GUID_Token_Parent='" & objTreeNode.Name & "'")
            For Each objDR_Node In objDRs_Nodes
                objTreeNode_Sub = objTreeNode.Nodes.Add(objDR_Node.Item("GUID_Token").ToString, _
                                           objDR_Node.Item("Name_Token"),
                                           cint_ImageID_Report, cint_ImageID_Report)

                fill_Tree(objTreeNode_Sub)
            Next
        End If
    End Sub

    Private Sub set_DBConnection()
        procA_TokenTree_TopDown.Connection = objLocalConfig.Connection_DB
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
                objSemItem_Report.GUID_Parent = objLocalConfig.SemItem_Type_Report.GUID
                objSemItem_Report.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                objUserControl_Report.initialize(objSemItem_Report)
            End If
        End If

    End Sub
End Class
