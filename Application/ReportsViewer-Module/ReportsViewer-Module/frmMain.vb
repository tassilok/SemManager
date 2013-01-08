Imports Sem_Manager
Imports Security_Module
Imports Splunk_Connector_Module
Public Class frmMain
    Private cint_ImageID_Root As Integer = 0
    Private cint_ImageID_Report As Integer = 1

    Private objLocalConfig As clsLocalConfig

    Private objUserData As clsUserData


    Private objDLGAttribute_VARCHAR255 As dlgAttribute_Varchar255

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private WithEvents objUserControl_Report As UserControl_Report
    Private objFrmAuthenticate As frmAuthenticate
    Private objFrmTokenEdit As frmTokenEdit

    Private objTransaction_Reports As clsTransaction_Reports
    Private objReportXMLExport As clsReportXMLExport
    Private objSplunk As Splunk_Connector_Module.clsSplunk
    
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
        If Not objLocalConfig.SemItem_User Is Nothing Then
            objUserData.get_Data_XMLConfig(objLocalConfig.SemItem_User)
        End If

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
        objTransaction_Reports = New clsTransaction_Reports(objLocalConfig)
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        objReportXMLExport = New clsReportXMLExport(objLocalConfig)
        objSplunk = New Splunk_Connector_Module.clsSplunk(objLocalConfig.Globals)
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

    Private Sub TreeView_Report_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_Report.DoubleClick
        Dim objTreeNode As TreeNode
        Dim objSemItem_Report As New clsSemItem
        objTreeNode = TreeView_Report.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Report Then
                objSemItem_Report.GUID = New Guid(objTreeNode.Name)
                objSemItem_Report.Name = objTreeNode.Text
                objSemItem_Report.GUID_Parent = objLocalConfig.SemItem_Type_Reports.GUID
                objSemItem_Report.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objFrmTokenEdit = New frmTokenEdit(objSemItem_Report, objLocalConfig.Globals)
                objFrmTokenEdit.ShowDialog()
            End If
        End If
    End Sub

    Private Sub TreeView_Report_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView_Report.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                fill_Tree()
        End Select
    End Sub

    Private Sub ContextMenuStrip_Reports_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Reports.Opening
        Dim objTreeNode As TreeNode


        GetColumnsToolStripMenuItem.Enabled = False
        AddReportToolStripMenuItem.Enabled = False
        ExportXMLToolStripMenuItem.Enabled = False
        ExportToSplunkToolStripMenuItem.Enabled = False

        objTreeNode = TreeView_Report.SelectedNode

        If Not objTreeNode Is Nothing Then
            AddReportToolStripMenuItem.Enabled = True
            If objTreeNode.ImageIndex = cint_ImageID_Report Then
                ExportToSplunkToolStripMenuItem.Enabled = True
                GetColumnsToolStripMenuItem.Enabled = True
                If Not objLocalConfig.SemItem_User Is Nothing Then
                    If objUserData.XMLConfig_procT.Rows.Count = 1 Then
                        ExportXMLToolStripMenuItem.Enabled = True
                    End If

                End If

            End If
        End If
    End Sub

    Private Sub GetColumnsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetColumnsToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Report As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objTreeNode = TreeView_Report.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Report Then
                objSemItem_Report = New clsSemItem
                objSemItem_Report.GUID = New Guid(objTreeNode.Name)
                objSemItem_Report.Name = objTreeNode.Text
                objSemItem_Report.GUID_Parent = objLocalConfig.SemItem_Type_Reports.GUID
                objSemItem_Report.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objUserData.get_Columns(objSemItem_Report)
                If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    MsgBox("Der Report ist nicht richtig konfiguriert!", MsgBoxStyle.Exclamation)
                End If

            End If
        End If
    End Sub

    Private Sub AddReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddReportToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Report As clsSemItem
        Dim objSemItem_Report_Parent As clsSemItem
        Dim objDRC_Reports As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objTreeNode = TreeView_Report.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Report Then
                objSemItem_Report_Parent = New clsSemItem
                objSemItem_Report_Parent.GUID = New Guid(objTreeNode.Name)
                objSemItem_Report_Parent.Name = objTreeNode.Text
                objSemItem_Report_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Reports.GUID
                objSemItem_Report_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            Else
                objSemItem_Report_Parent = Nothing
            End If

            objDLGAttribute_VARCHAR255 = New dlgAttribute_Varchar255("New Report", objLocalConfig.Globals)
            objDLGAttribute_VARCHAR255.ShowDialog(Me)
            If objDLGAttribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then
                If Not objSemItem_Report_Parent Is Nothing Then
                    objDRC_Reports = funcA_TokenToken.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(objSemItem_Report_Parent.GUID, _
                                                                                                                   objDLGAttribute_VARCHAR255.Value1, _
                                                                                                                   objLocalConfig.SemItem_Type_Reports.GUID, _
                                                                                                                   objLocalConfig.SemItem_RelationType_contains.GUID).Rows
                    If objDRC_Reports.Count = 0 Then
                        objSemItem_Report = New clsSemItem
                        objSemItem_Report.GUID = Guid.NewGuid
                        objSemItem_Report.Name = objDLGAttribute_VARCHAR255.Value1
                        objSemItem_Report.GUID_Parent = objLocalConfig.SemItem_Type_Reports.GUID
                        objSemItem_Report.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    Else
                        objSemItem_Report = Nothing
                    End If
                Else
                    objSemItem_Report = New clsSemItem
                    objSemItem_Report.GUID = Guid.NewGuid
                    objSemItem_Report.Name = objDLGAttribute_VARCHAR255.Value1
                    objSemItem_Report.GUID_Parent = objLocalConfig.SemItem_Type_Reports.GUID
                    objSemItem_Report.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                End If
                
                If Not objSemItem_Report Is Nothing Then


                    objSemItem_Result = objTransaction_Reports.save_006_Report(objSemItem_Report)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        If Not objSemItem_Report_Parent Is Nothing Then
                            objSemItem_Result = objTransaction_Reports.save_007_Report_to_Report(objSemItem_Report_Parent, _
                                                                                             objSemItem_Report)
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        End If
                        
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objTreeNode.Nodes.Add(objSemItem_Report.GUID.ToString, _
                                                  objSemItem_Report.Name, _
                                                  cint_ImageID_Report, _
                                                  cint_ImageID_Report)
                        Else
                            objTransaction_Reports.del_006_Report(objSemItem_Report)
                            MsgBox("Der Report konnte nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Der Report konnte nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Es gibt bereits einen Report mit dem Namen!", MsgBoxStyle.Exclamation)
                End If

            End If
        End If
    End Sub

    Private Sub ExportXMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportXMLToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Report As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objTreeNode = TreeView_Report.SelectedNode
        If Not objTreeNode Is Nothing Then
            objSemItem_Report.GUID = New Guid(objTreeNode.Name)
            objSemItem_Report.Name = objTreeNode.Text
            objSemItem_Report.GUID_Parent = objLocalConfig.SemItem_Type_Reports.GUID
            objSemItem_Report.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objReportXMLExport.initialize(objSemItem_Report)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objReportXMLExport.create_XML()
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    MsgBox("Datei wurde erzeugt!", MsgBoxStyle.Information)
                Else
                    MsgBox("Das File kann nicht exportiert werden!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Das File kann nicht exportiert werden!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub ExportToSplunkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToSplunkToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem_Report As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objTreeNode = TreeView_Report.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Report Then
                objSemItem_Report.GUID = New Guid(objTreeNode.Name)
                objSemItem_Report.Name = objTreeNode.Text
                objSemItem_Report.GUID_Parent = objLocalConfig.SemItem_Type_Reports.GUID
                objSemItem_Report.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objSplunk.write_Report(objSemItem_Report)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Der Report kann leider nicht zu Splunk exportiert werden!", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Der Report wurde zu Splunk exportiert!", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub
End Class
