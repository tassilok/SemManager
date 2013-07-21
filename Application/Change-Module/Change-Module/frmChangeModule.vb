Imports Sem_Manager
Imports Process_Module
Imports MediaViewer_Module
Public Class frmChangeModule
    Private Const cintImage_Ticket As Integer = 0
    Private Const cintImage_Process As Integer = 1
    Private Const cintImage_Incident As Integer = 2
    Private Const cintImage_Process_w_doc As Integer = 3
    Private Const cintImage_Incident_w_doc As Integer = 4
    Private Const cintImage_Root As Integer = 5

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private procA_TokenToken_LeftRight_Tree As New ds_TokenTableAdapters.proc_TokenToken_LeftRight_TreeTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private objFrmTokenEdit As frmTokenEdit
    Private objUserControl_References As UserControl_References
    Private WithEvents objUserControl_History As UserControl_History
    Private WithEvents objUserControl_Images_Prcoess As UserControl_Galery
    Private WithEvents objUserControl_Images_ProcessLog As UserControl_Galery
    Private WithEvents objUserControl_MediaItems_Process As UserControl_MediaItem
    Private WithEvents objUserControl_MediaItems_ProcessLog As UserControl_MediaItem
    Private WithEvents objUserControl_PDF_Process As UserControl_PDFViewer
    Private WithEvents objUserControl_PDF_ProcessLog As UserControl_PDFViewer
    Private objDlgAttribute_VARCHAR255 As dlgAttribute_Varchar255
    Private objDlgAttribute_VARCHARMax As dlgAttribute_VarcharMax
    Private objTransaction_Ticket As clsTransaction_Ticket
    Private objTransaction_Process As clsTransaction_Process
    Private objTransaction_ProcessLog As clsTransaction_ProcessLog
    Private objMediaInfo As clsMediaInfo

    Private intRowID As Integer
    Private objDGVRC_Selected As DataGridViewRowCollection
    Private objDRV_Selected As DataRowView
    Private objLocalConfig As clsLocalConfig
    Private objTicketWork As clsTicketWork

    Private objSemItem_Process As clsSemItem
    Private objSemItem_ProcessLog As clsSemItem
    Private objSemItem_TokenAttribute_Description_Ticket As clsSemItem
    Private objSemItem_TokenAttribute_Description_Process As clsSemItem
    Private objSemItem_TokenAttribute_Description_ProcessLog As clsSemItem

    Private strTabPage_Image As String
    Private strTabPage_MediaItem As String
    Private strTabPage_PDF As String

    Private boolProcessPWork As Boolean

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_TokenToken_LeftRight_Tree.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        objUserControl_References = New UserControl_References(objLocalConfig.Globals)
        objUserControl_References.Dock = DockStyle.Fill
        Panel_References.Controls.Clear()
        Panel_References.Controls.Add(objUserControl_References)

        objUserControl_History = New UserControl_History(objLocalConfig)
        objUserControl_History.Dock = DockStyle.Fill
        Panel_History.Controls.Clear()
        Panel_History.Controls.Add(objUserControl_History)

        objTicketWork = New clsTicketWork(objLocalConfig, Me)
        objTransaction_Ticket = New clsTransaction_Ticket(objLocalConfig)
        objTransaction_Process = New clsTransaction_Process(objLocalConfig.Globals)
        objTransaction_ProcessLog = New clsTransaction_ProcessLog(objLocalConfig)

        objMediaInfo = New clsMediaInfo(objLocalConfig.Globals)
    End Sub
    Public Sub New(ByVal RowID As Integer, ByVal DGVRC_Selected As DataGridViewRowCollection, ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        intRowID = RowID
        objDGVRC_Selected = DGVRC_Selected
        set_DBConnection()
        get_Ticket()
    End Sub


    Private Sub get_Ticket()
        Dim objDGVR_Current As DataGridViewRow
        Dim objSemItem_Ticket As clsSemItem
        If objDGVRC_Selected.Count > 0 Then
            If intRowID < 0 Or intRowID > objDGVRC_Selected.Count - 1 Then
                intRowID = 0
                MsgBox("Das ausgewählte Ticket konnte nicht ermittelt werden! Das erste der Liste wird ausgewählt!", MsgBoxStyle.Exclamation)

            End If

            objDGVR_Current = objDGVRC_Selected(intRowID)
            objDRV_Selected = objDGVR_Current.DataBoundItem
            objSemItem_Ticket = New clsSemItem
            objSemItem_Ticket.GUID = objDRV_Selected.Item("GUID_Ticket")
            objSemItem_Ticket.Name = objDRV_Selected.Item("Name_Ticket")
            objSemItem_Ticket.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket.GUID
            objSemItem_Ticket.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            show_Process(objDRV_Selected)
            get_Description_Ticket(objSemItem_Ticket)
        Else
            objDRV_Selected = Nothing
        End If
        TreeView_Ticket.ExpandAll()
    End Sub

    Private Sub configure_Controls()
        boolProcessPWork = True
        ToolStripTextBox_ID.Clear()
        ToolStripTextBox_Name.Clear()
        ToolStripTextBox_Reference.Clear()
        ToolStripLabel_TicketCount.Text = "0/0"
        TextBox_Description_Process.ReadOnly = True
        TextBox_Description_Process.Clear()
        TextBox_Description_ProcessLog.ReadOnly = True
        TextBox_Description_ProcessLog.Clear()
        TextBox_Description_Ticket.ReadOnly = True
        TextBox_Description_Ticket.Clear()
        TreeView_Ticket.Nodes.Clear()
        If Not objDRV_Selected Is Nothing Then
            ToolStripTextBox_ID.Text = objDRV_Selected.Item("ID")
            ToolStripTextBox_Name.Text = objDRV_Selected.Item("Name_Ticket")
            ToolStripTextBox_Reference.Text = objDRV_Selected.Item("Name_item_belongsTo")
            ToolStripLabel_TicketCount.Text = intRowID + 1 & "/" & objDGVRC_Selected.Count
        End If

        configure_Navigation()
        boolProcessPWork = False
    End Sub

    Private Sub configure_Navigation()
        ToolStripButton_MoveFirst.Enabled = False
        ToolStripButton_MovePrevious.Enabled = False
        ToolStripButton_MoveNext.Enabled = False
        ToolStripButton_MoveLast.Enabled = False

        If Not objDRV_Selected Is Nothing Then
            If intRowID > 0 Then
                ToolStripButton_MoveFirst.Enabled = True
                ToolStripButton_MovePrevious.Enabled = True
            End If

            If intRowID < objDGVRC_Selected.Count - 1 Then
                ToolStripButton_MoveNext.Enabled = True
                ToolStripButton_MoveLast.Enabled = True
            End If
        End If
    End Sub

    Private Sub show_Process(ByVal objDRV_Selected As DataRowView)
        Dim objSemItem_Ticket As New clsSemItem
        configure_Controls()

        objSemItem_Ticket.GUID = objDRV_Selected.Item("GUID_Ticket")
        objSemItem_Ticket.Name = objDRV_Selected.Item("Name_Ticket")
        objSemItem_Ticket.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket.GUID
        objSemItem_Ticket.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        show_Ticket(objSemItem_Ticket)
    End Sub

    Private Function show_Ticket(ByVal objSemItem_Ticket As clsSemItem, Optional ByVal objTreeNode_Parent As TreeNode = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success
        Dim objTreeNode_Ticket As TreeNode
        Dim objSemItem_Process As clsSemItem
        Dim objSemItem_SubProcess As clsSemItem
        Dim objSemItem_ProcessLog As clsSemItem
        Dim objSemItem_Incident As clsSemItem
        Dim objDRC_Process As DataRowCollection
        Dim objDR_Process As DataRow
        Dim objDRC_SubProcess As DataRowCollection
        Dim objDR_SubProcess As DataRow
        Dim objDRC_SubIncidents As DataRowCollection
        Dim objDR_SubIncident As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Incident As TreeNode
        Dim objTreeNode_SubIncident As TreeNode
        Dim objTreeNodes_Incidents() As TreeNode
        Dim objTreeNode_Found As TreeNode
        Dim objTreeNode_Process As TreeNode
        Dim GUID_Relation As Guid

        If objTreeNode_Parent Is Nothing Then
            objTreeNode_Ticket = TreeView_Ticket.Nodes.Add(objSemItem_Ticket.GUID.ToString, objSemItem_Ticket.Name, cintImage_Ticket, cintImage_Ticket)
        Else
            objTreeNode_Ticket = objTreeNode_Parent.Nodes.Add(objSemItem_Ticket.GUID.ToString, objSemItem_Ticket.Name, cintImage_Ticket, cintImage_Ticket)
        End If

        objDRC_Process = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Ticket.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                       objLocalConfig.SemItem_Type_Process.GUID).Rows
        If objDRC_Process.Count > 0 Then
            objSemItem_Process = New clsSemItem
            objSemItem_Process.GUID = objDRC_Process(0).Item("GUID_Token_Right")
            objSemItem_Process.Name = objDRC_Process(0).Item("Name_Token_Right")
            objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
            objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            boolProcessPWork = True
            objTreeNode_Found = objTreeNode_Ticket.Nodes.Add(objSemItem_Process.GUID.ToString, objSemItem_Process.Name, cintImage_Process, cintImage_Process)
            boolProcessPWork = False
            objSemItem_ProcessLog = objTicketWork.get_ProcessLog(objSemItem_Process, objSemItem_Ticket)

            objDRC_SubProcess = funcA_TokenToken.GetData_LeftRight_Ordered_By_GUIDs(objSemItem_ProcessLog.GUID, _
                                                                                                objLocalConfig.SemItem_Type_Incident.GUID, _
                                                                                                objLocalConfig.SemItem_RelationType_contains.GUID, True).Rows

            For Each objDR_SubProcess In objDRC_SubProcess

                objTreeNode_Incident = objTreeNode_Found.Nodes.Add(objDR_SubProcess.Item("GUID_Token_Right").ToString, _
                                            objDR_SubProcess.Item("Name_Token_Right"), _
                                            cintImage_Incident, cintImage_Incident)

                objSemItem_Incident = New clsSemItem
                objSemItem_Incident.GUID = New Guid(objTreeNode_Incident.Name)
                objSemItem_Incident.Name = objTreeNode_Incident.Text
                objSemItem_Incident.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID
                objSemItem_Incident.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                If objTicketWork.state_Err(objSemItem_Incident) Then
                    objTreeNode_Incident.BackColor = Color.Red
                Else
                    If objTicketWork.state_Finished(objSemItem_Incident) = True Then
                        boolProcessPWork = True
                        objTreeNode_Incident.Checked = True
                        objTreeNode_Incident.BackColor = Color.Green
                        objTreeNode_Incident.ForeColor = Color.White
                        boolProcessPWork = False
                    ElseIf objTicketWork.state_Obsolete(objSemItem_Incident) = True Then
                        boolProcessPWork = True
                        objTreeNode_Incident.Checked = True
                        objTreeNode_Incident.BackColor = Color.Gray
                        boolProcessPWork = False
                    End If
                End If
                

                objDRC_SubIncidents = procA_TokenToken_LeftRight_Tree.GetData(New Guid(objTreeNode_Incident.Name), _
                                                         objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                         objLocalConfig.SemItem_Type_Incident.GUID, _
                                                         1, _
                                                         -1, 1).Rows
                For Each objDR_SubIncident In objDRC_SubIncidents
                    objSemItem_Incident = Nothing
                    If objDR_SubIncident.Item("GUID_Token_Parent").ToString = objTreeNode_Incident.Name Then
                        objTreeNode_SubIncident = objTreeNode_Incident.Nodes.Add(objDR_SubIncident.Item("GUID_Token").ToString, _
                                                                              objDR_SubIncident.Item("Name_Token"), _
                                                                              cintImage_Incident, cintImage_Incident)
                        objSemItem_Incident = New clsSemItem
                        objSemItem_Incident.GUID = New Guid(objTreeNode_SubIncident.Name)
                        objSemItem_Incident.Name = objTreeNode_SubIncident.Text
                        objSemItem_Incident.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID
                        objSemItem_Incident.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        If objTicketWork.state_Err(objSemItem_Incident) Then
                            objTreeNode_SubIncident.BackColor = Color.Red
                        Else

                            If objTicketWork.state_Finished(objSemItem_Incident) = True Then
                                boolProcessPWork = True
                                objTreeNode_SubIncident.Checked = True
                                objTreeNode_SubIncident.BackColor = Color.Green
                                objTreeNode_SubIncident.ForeColor = Color.White
                                boolProcessPWork = False
                            ElseIf objTicketWork.state_Obsolete(objSemItem_Incident) = True Then
                                boolProcessPWork = True
                                objTreeNode_SubIncident.Checked = True
                                objTreeNode_SubIncident.BackColor = Color.Gray
                                boolProcessPWork = False
                            End If
                        End If
                    Else
                        objTreeNodes_Incidents = objTreeNode_Incident.Nodes.Find(objDR_SubIncident.Item("GUID_Token_Parent").ToString, True)
                        If objTreeNodes_Incidents.Count > 0 Then
                            objTreeNode_SubIncident = objTreeNodes_Incidents(0).Nodes.Add(objDR_SubIncident.Item("GUID_Token").ToString, _
                                                                              objDR_SubIncident.Item("Name_Token"), _
                                                                              cintImage_Incident, cintImage_Incident)

                            objSemItem_Incident = New clsSemItem
                            objSemItem_Incident.GUID = New Guid(objTreeNode_SubIncident.Name)
                            objSemItem_Incident.Name = objTreeNode_SubIncident.Text
                            objSemItem_Incident.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID
                            objSemItem_Incident.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            If objTicketWork.state_Err(objSemItem_Incident) Then
                                objTreeNode_SubIncident.BackColor = Color.Red
                            Else
                                If objTicketWork.state_Finished(objSemItem_Incident) = True Then
                                    boolProcessPWork = True
                                    objTreeNode_SubIncident.Checked = True
                                    objTreeNode_SubIncident.BackColor = Color.Green
                                    objTreeNode_SubIncident.ForeColor = Color.White
                                    boolProcessPWork = False
                                ElseIf objTicketWork.state_Obsolete(objSemItem_Incident) = True Then
                                    boolProcessPWork = True
                                    objTreeNode_SubIncident.Checked = True
                                    objTreeNode_SubIncident.BackColor = Color.Gray
                                    boolProcessPWork = False
                                End If
                            End If
                        End If
                    End If

                Next

            Next

            If objTicketWork.state_Err(objSemItem_ProcessLog) Then
                objTreeNode_Found.BackColor = Color.Red
            Else
                If objTicketWork.state_Finished(objSemItem_ProcessLog) Then
                    boolProcessPWork = True
                    objTreeNode_Found.Checked = True
                    objTreeNode_Found.ForeColor = Color.White
                    boolProcessPWork = False
                    objTreeNode_Found.BackColor = Color.Green
                ElseIf objTicketWork.state_Obsolete(objSemItem_ProcessLog) Then
                    boolProcessPWork = True
                    objTreeNode_Found.Checked = True
                    boolProcessPWork = False
                    objTreeNode_Found.BackColor = Color.Gray
                End If
            End If
        Else
            objSemItem_Process = Nothing

        End If

        If Not objSemItem_Process Is Nothing Then
            objDRC_Process = procA_TokenToken_LeftRight_Tree.GetData(objSemItem_Process.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                                     objLocalConfig.SemItem_Type_Process.GUID, _
                                                                     1, _
                                                                     -1, 1).Rows

            For Each objDR_Process In objDRC_Process
                objTreeNodes = objTreeNode_Ticket.Nodes.Find(objDR_Process.Item("GUID_Token_Parent").ToString, True)
                If objTreeNodes.Count > 0 Then

                    For Each objTreeNode_Found In objTreeNodes
                        boolProcessPWork = True
                        objTreeNode_Process = objTreeNode_Found.Nodes.Add(objDR_Process.Item("GUID_Token").ToString, _
                                                    objDR_Process.Item("Name_token"), cintImage_Process, cintImage_Process)
                        boolProcessPWork = False
                        objSemItem_SubProcess = New clsSemItem
                        objSemItem_SubProcess.GUID = objDR_Process.Item("GUID_Token")
                        objSemItem_SubProcess.Name = objDR_Process.Item("Name_Token")
                        objSemItem_SubProcess.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                        objSemItem_SubProcess.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_ProcessLog = objTicketWork.get_ProcessLog(objSemItem_SubProcess, objSemItem_Ticket)
                        If objSemItem_ProcessLog.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID Then
                            GUID_Relation = objLocalConfig.SemItem_RelationType_superordinate.GUID
                        Else
                            GUID_Relation = objLocalConfig.SemItem_RelationType_contains.GUID
                        End If
                        
                        objDRC_SubProcess = funcA_TokenToken.GetData_LeftRight_Ordered_By_GUIDs(objSemItem_ProcessLog.GUID, _
                                                                                                objLocalConfig.SemItem_Type_Incident.GUID, _
                                                                                                GUID_Relation, True).Rows

                        For Each objDR_SubProcess In objDRC_SubProcess

                            objTreeNode_Incident = objTreeNode_Process.Nodes.Add(objDR_SubProcess.Item("GUID_Token_Right").ToString, _
                                                        objDR_SubProcess.Item("Name_Token_Right"), _
                                                        cintImage_Incident, cintImage_Incident)

                            objSemItem_Incident = New clsSemItem
                            objSemItem_Incident.GUID = New Guid(objTreeNode_Incident.Name)
                            objSemItem_Incident.Name = objTreeNode_Incident.Text
                            objSemItem_Incident.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID
                            objSemItem_Incident.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            If objTicketWork.state_Err(objSemItem_Incident) Then
                                objTreeNode_Incident.BackColor = Color.Red
                            Else
                                If objTicketWork.state_Finished(objSemItem_Incident) = True Then
                                    boolProcessPWork = True
                                    objTreeNode_Incident.Checked = True
                                    objTreeNode_Incident.BackColor = Color.Green
                                    objTreeNode_Incident.ForeColor = Color.White
                                    boolProcessPWork = False
                                ElseIf objTicketWork.state_Finished(objSemItem_Incident) = True Then
                                    boolProcessPWork = True
                                    objTreeNode_Incident.Checked = True
                                    objTreeNode_Incident.BackColor = Color.Gray
                                    boolProcessPWork = False
                                End If
                            End If
                            objDRC_SubIncidents = procA_TokenToken_LeftRight_Tree.GetData(New Guid(objTreeNode_Incident.Name), _
                                                                     objLocalConfig.SemItem_RelationType_superordinate.GUID, _
                                                                     objLocalConfig.SemItem_Type_Incident.GUID, _
                                                                     1, _
                                                                     -1, 1).Rows
                            For Each objDR_SubIncident In objDRC_SubIncidents
                                objSemItem_Incident = Nothing
                                If objDR_SubIncident.Item("GUID_Token_Parent").ToString = objTreeNode_Incident.Name Then
                                    objTreeNode_SubIncident = objTreeNode_Incident.Nodes.Add(objDR_SubIncident.Item("GUID_Token").ToString, _
                                                                                          objDR_SubIncident.Item("Name_Token"), _
                                                                                          cintImage_Incident, cintImage_Incident)
                                    objSemItem_Incident = New clsSemItem
                                    objSemItem_Incident.GUID = New Guid(objTreeNode_SubIncident.Name)
                                    objSemItem_Incident.Name = objTreeNode_SubIncident.Text
                                    objSemItem_Incident.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID
                                    objSemItem_Incident.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    If objTicketWork.state_Err(objSemItem_Incident) Then
                                        objTreeNode_SubIncident.BackColor = Color.Red
                                    Else
                                        If objTicketWork.state_Finished(objSemItem_Incident) = True Then
                                            boolProcessPWork = True
                                            objTreeNode_SubIncident.Checked = True
                                            objTreeNode_SubIncident.BackColor = Color.Green
                                            objTreeNode_SubIncident.ForeColor = Color.White
                                            boolProcessPWork = False
                                        ElseIf objTicketWork.state_Finished(objSemItem_Incident) = True Then
                                            boolProcessPWork = True
                                            objTreeNode_SubIncident.Checked = True
                                            objTreeNode_SubIncident.BackColor = Color.Gray
                                            boolProcessPWork = False
                                        End If
                                    End If
                                Else
                                    objTreeNodes_Incidents = objTreeNode_Incident.Nodes.Find(objDR_SubIncident.Item("GUID_Token").ToString, True)
                                    If objTreeNodes_Incidents.Count > 0 Then
                                        objTreeNode_SubIncident = objTreeNodes_Incidents(0).Nodes.Add(objDR_SubIncident.Item("GUID_Token").ToString, _
                                                                                          objDR_SubIncident.Item("Name_Token"), _
                                                                                          cintImage_Incident, cintImage_Incident)

                                        objSemItem_Incident = New clsSemItem
                                        objSemItem_Incident.GUID = New Guid(objTreeNode_SubIncident.Name)
                                        objSemItem_Incident.Name = objTreeNode_SubIncident.Text
                                        objSemItem_Incident.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID
                                        objSemItem_Incident.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                        If objTicketWork.state_Err(objSemItem_Incident) Then
                                            objTreeNode_SubIncident.BackColor = Color.Red
                                        Else
                                            If objTicketWork.state_Finished(objSemItem_Incident) = True Then
                                                boolProcessPWork = True
                                                objTreeNode_SubIncident.Checked = True
                                                objTreeNode_SubIncident.BackColor = Color.Green
                                                objTreeNode_SubIncident.ForeColor = Color.White
                                                boolProcessPWork = False
                                            ElseIf objTicketWork.state_Finished(objSemItem_Incident) = True Then
                                                boolProcessPWork = True
                                                objTreeNode_SubIncident.Checked = True
                                                objTreeNode_SubIncident.BackColor = Color.Gray
                                                boolProcessPWork = False
                                            End If
                                        End If
                                    End If
                                End If

                            Next

                        Next
                        If objTicketWork.state_Err(objSemItem_ProcessLog) Then
                            objTreeNode_Process.BackColor = Color.Red
                        Else

                            If objTicketWork.state_Finished(objSemItem_ProcessLog) = True Then
                                boolProcessPWork = True
                                objTreeNode_Process.Checked = True
                                objTreeNode_Process.BackColor = Color.Green
                                objTreeNode_Process.ForeColor = Color.White
                                boolProcessPWork = False
                            ElseIf objTicketWork.state_Finished(objSemItem_ProcessLog) = True Then
                                boolProcessPWork = True
                                objTreeNode_Process.Checked = True
                                objTreeNode_Found.BackColor = Color.Gray
                                boolProcessPWork = False
                            End If
                        End If
                    Next

                End If

            Next
        End If



        Return objSemItem_Result
    End Function

    Private Sub TreeView_Ticket_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Ticket.AfterSelect

        objSemItem_Process = Nothing
        objSemItem_ProcessLog = Nothing
        If boolProcessPWork = False Then
            Dim objTreeNode_Selected As TreeNode
            Dim objSemItem_Ticket As clsSemItem
            


            objUserControl_References.clear_Nodes()
            objUserControl_History.clear_History()
            objTreeNode_Selected = TreeView_Ticket.SelectedNode
            If Not objTreeNode_Selected Is Nothing Then

                If objTreeNode_Selected.ImageIndex = cintImage_Incident Or _
                    objTreeNode_Selected.ImageIndex = cintImage_Incident_w_doc Or _
                    objTreeNode_Selected.ImageIndex = cintImage_Process Or _
                    objTreeNode_Selected.ImageIndex = cintImage_Process_w_doc Then

                    objSemItem_Process = New clsSemItem
                    objSemItem_Process.GUID = New Guid(objTreeNode_Selected.Name)
                    objSemItem_Process.Name = objTreeNode_Selected.Text
                    If objTreeNode_Selected.ImageIndex = cintImage_Incident Or _
                        objTreeNode_Selected.ImageIndex = cintImage_Incident_w_doc Then
                        objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID
                        TextBox_Description_Process.ReadOnly = True
                        TextBox_Description_Process.Clear()

                    Else
                        objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                        get_Description_Process(objSemItem_Process)
                    End If
                    objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                    
                    objSemItem_Ticket = get_Ticket(objTreeNode_Selected)



                    objSemItem_ProcessLog = objTicketWork.get_ProcessLog(objSemItem_Process, objSemItem_Ticket)
                    If objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID Then
                        objUserControl_References.fill_Tree_Ref_Process(objSemItem_Process, objSemItem_ProcessLog)
                    Else
                        objUserControl_References.fill_Tree_Ref_Process(objSemItem_Process)
                    End If
                    TabPage_Images.Text = strTabPage_Image & " (" & _
                                            objMediaInfo.count_Media_Of_Ref(objSemItem_Process, objMediaInfo.SemItem_Image) & "/" &
                                            objMediaInfo.count_Media_Of_Ref(objSemItem_ProcessLog, objMediaInfo.SemItem_Image) & ")"
                    TabPage_MediaItems.Text = strTabPage_MediaItem & " (" & _
                                            objMediaInfo.count_Media_Of_Ref(objSemItem_Process, objMediaInfo.SemItem_MediaItem) & "/" &
                                            objMediaInfo.count_Media_Of_Ref(objSemItem_ProcessLog, objMediaInfo.SemItem_MediaItem) & ")"

                    TabPage_PDF.Text = strTabPage_PDF & " (" & _
                                            objMediaInfo.count_Media_Of_Ref(objSemItem_Process, objMediaInfo.SemItem_PDF) & "/" &
                                            objMediaInfo.count_Media_Of_Ref(objSemItem_ProcessLog, objMediaInfo.SemItem_PDF) & ")"

                    objUserControl_History.initialize_History(objSemItem_ProcessLog)
                    configure_TabPages(objSemItem_Process, objSemItem_ProcessLog)
                    get_Description_ProcessLogIncident(objSemItem_ProcessLog)
                    If objTicketWork.state_Err(objSemItem_ProcessLog) Then
                        objTreeNode_Selected.BackColor = Color.Red
                    Else
                        If objTicketWork.state_Err(objSemItem_ProcessLog) Then
                            objTreeNode_Selected.BackColor = Color.Red
                        Else
                            If objTicketWork.state_Finished(objSemItem_ProcessLog) Then
                                boolProcessPWork = True
                                objTreeNode_Selected.Checked = True
                                boolProcessPWork = False
                                objTreeNode_Selected.BackColor = Color.Green
                            ElseIf objTicketWork.state_Obsolete(objSemItem_ProcessLog) Then
                                boolProcessPWork = True
                                objTreeNode_Selected.Checked = True
                                boolProcessPWork = False
                                objTreeNode_Selected.BackColor = Color.Gray
                            End If
                        End If
                    End If
                Else
                    TextBox_Description_Process.ReadOnly = True
                    TextBox_Description_Process.Clear()
                    TextBox_Description_ProcessLog.ReadOnly = True
                    TextBox_Description_ProcessLog.Clear()
                    objUserControl_References.clear_Nodes()
                End If
            End If
        End If
    End Sub

    Private Sub configure_TabPages(ByVal objSemItem_Process As clsSemItem, ByVal objSemItem_ProcessLog As clsSemItem)
        TabPage_Process_Images.Controls.Clear()
        TabPage_ProcessLog_Images.Controls.Clear()
        TabPage_ProcessMediaItem.Controls.Clear()
        TabPage_ProcessLog_MediaItem.Controls.Clear()
        TabPage_Process_PDF.Controls.Clear()
        TabPage_PDF_ProcessLog.Controls.Clear()

        Select Case TabControl1.SelectedTab.Name
            Case TabPage_MediaItems.Name
                Select Case TabControl3.SelectedTab.Name
                    Case TabPage_ProcessMediaItem.Name
                        If Not objSemItem_Process Is Nothing Then
                            objUserControl_MediaItems_Process = New UserControl_MediaItem(objSemItem_Process, objLocalConfig.Globals)
                            objUserControl_MediaItems_Process.Dock = DockStyle.Fill
                            TabPage_ProcessMediaItem.Controls.Add(objUserControl_MediaItems_Process)
                        End If
                    Case TabPage_ProcessLog_MediaItem.Name
                        If Not objSemItem_ProcessLog Is Nothing Then
                            objUserControl_MediaItems_ProcessLog = New UserControl_MediaItem(objSemItem_ProcessLog, objLocalConfig.Globals)
                            objUserControl_MediaItems_ProcessLog.Dock = DockStyle.Fill
                            TabPage_ProcessLog_MediaItem.Controls.Add(objUserControl_MediaItems_ProcessLog)
                        End If
                End Select
            Case TabPage_Images.Name
                Select Case TabControl2.SelectedTab.Name
                    Case TabPage_Process_Images.Name
                        If Not objSemItem_Process Is Nothing Then
                            objUserControl_Images_Prcoess = New UserControl_Galery(objSemItem_Process, objLocalConfig.Globals)
                            objUserControl_Images_Prcoess.allow_Edit = True
                            objUserControl_Images_Prcoess.Dock = DockStyle.Fill
                            TabPage_Process_Images.Controls.Add(objUserControl_Images_Prcoess)
                        End If
                    Case TabPage_ProcessLog_Images.Name
                        If Not objSemItem_ProcessLog Is Nothing Then
                            objUserControl_Images_ProcessLog = New UserControl_Galery(objSemItem_ProcessLog, objLocalConfig.Globals)
                            objUserControl_Images_ProcessLog.allow_Edit = True
                            objUserControl_Images_ProcessLog.Dock = DockStyle.Fill
                            TabPage_ProcessLog_Images.Controls.Add(objUserControl_Images_ProcessLog)
                        End If
                End Select
            Case TabPage_PDF.Name
                Select Case TabControl_PDF.SelectedTab.Name
                    Case TabPage_Process_PDF.Name
                        objUserControl_PDF_Process = New UserControl_PDFViewer(objSemItem_Process, objLocalConfig.Globals)
                        objUserControl_PDF_Process.Dock = DockStyle.Fill
                        TabPage_Process_PDF.Controls.Add(objUserControl_PDF_Process)
                    Case TabPage_PDF_ProcessLog.Name
                        objUserControl_PDF_ProcessLog = New UserControl_PDFViewer(objSemItem_ProcessLog, objLocalConfig.Globals)
                        objUserControl_PDF_ProcessLog.Dock = DockStyle.Fill
                        TabPage_PDF_ProcessLog.Controls.Add(objUserControl_PDF_ProcessLog)

                End Select
        End Select
    End Sub
    Private Sub get_Description_Ticket(ByVal objSemItem_Ticket As clsSemItem)
        Dim objDRC_Description As DataRowCollection

        objDRC_Description = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Ticket.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Description.GUID).Rows
        If objDRC_Description.Count > 0 Then
            objSemItem_TokenAttribute_Description_Ticket = New clsSemItem
            objSemItem_TokenAttribute_Description_Ticket.GUID = objDRC_Description(0).Item("GUID_TokenAttribute")
            TextBox_Description_Ticket.ReadOnly = True
            TextBox_Description_Ticket.Text = objDRC_Description(0).Item("Val_VARCHARMAX")
            TextBox_Description_Ticket.ReadOnly = False
        Else
            objSemItem_TokenAttribute_Description_Ticket = Nothing
            TextBox_Description_Ticket.ReadOnly = True
            TextBox_Description_Ticket.Clear()
            TextBox_Description_Ticket.ReadOnly = False
        End If
    End Sub
    Private Sub get_Description_Process(ByVal objSemItem_Process As clsSemItem)
        Dim objDRC_Description As DataRowCollection

        objDRC_Description = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Process.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Description.GUID).Rows
        If objDRC_Description.Count > 0 Then
            objSemItem_TokenAttribute_Description_Process = New clsSemItem
            objSemItem_TokenAttribute_Description_Process.GUID = objDRC_Description(0).Item("GUID_TokenAttribute")
            TextBox_Description_Process.ReadOnly = True
            TextBox_Description_Process.Text = objDRC_Description(0).Item("Val_VARCHARMAX")
            TextBox_Description_Process.ReadOnly = False
        Else
            objSemItem_TokenAttribute_Description_Process = Nothing
            TextBox_Description_Process.ReadOnly = True
            TextBox_Description_Process.Clear()
            TextBox_Description_Process.ReadOnly = False
        End If
    End Sub
    Private Sub get_Description_ProcessLogIncident(ByVal objSemItem_ProcessLogIncident As clsSemItem)
        Dim objDRC_Description As DataRowCollection

        objDRC_Description = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_ProcessLogIncident.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_Description.GUID).Rows
        If objDRC_Description.Count > 0 Then
            objSemItem_TokenAttribute_Description_ProcessLog = New clsSemItem
            objSemItem_TokenAttribute_Description_ProcessLog.GUID = objDRC_Description(0).Item("GUID_TokenAttribute")
            TextBox_Description_ProcessLog.ReadOnly = True
            TextBox_Description_ProcessLog.Text = objDRC_Description(0).Item("Val_VARCHARMAX")
            TextBox_Description_ProcessLog.ReadOnly = False
        Else
            objSemItem_TokenAttribute_Description_ProcessLog = Nothing
            TextBox_Description_ProcessLog.ReadOnly = True
            TextBox_Description_ProcessLog.Clear()
            TextBox_Description_ProcessLog.ReadOnly = False
        End If
    End Sub
    Private Function get_Ticket(ByVal objTreeNode_Selected As TreeNode) As clsSemItem
        Dim objTreeNode_Parent As TreeNode
        Dim objSemItem_Ticket As clsSemItem = Nothing
        Dim boolFound As Boolean = False

        objTreeNode_Parent = objTreeNode_Selected
        Do
            objTreeNode_Parent = objTreeNode_Parent.Parent
            If Not objTreeNode_Parent Is Nothing Then
                If objTreeNode_Parent.ImageIndex = cintImage_Ticket Then
                    boolFound = True
                End If
            Else
                objSemItem_Ticket = Nothing
                Exit Do
            End If


        Loop Until boolFound = True

        If boolFound = True Then
            objSemItem_Ticket = New clsSemItem
            objSemItem_Ticket.GUID = New Guid(objTreeNode_Parent.Name)
            objSemItem_Ticket.Name = objTreeNode_Parent.Text
            objSemItem_Ticket.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket.GUID
            objSemItem_Ticket.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        End If

        Return objSemItem_Ticket
    End Function

    Private Sub TextBox_Description_Ticket_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Description_Ticket.TextChanged
        Timer_Description_Ticket.Stop()
        If TextBox_Description_Ticket.ReadOnly = False Then
            Timer_Description_Ticket.Start()
        End If

    End Sub

    Private Sub TextBox_Description_Process_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Description_Process.TextChanged
        Timer_Description_Process.Stop()
        If TextBox_Description_Process.ReadOnly = False Then
            Timer_Description_Process.Start()
        End If

    End Sub

    Private Sub TextBox_Description_ProcessLog_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Description_ProcessLog.TextChanged
        Timer_Description_ProcessLog.Stop()
        If TextBox_Description_ProcessLog.ReadOnly = False Then
            Timer_Description_ProcessLog.Start()
        End If

    End Sub

    Private Sub Timer_Description_Ticket_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Description_Ticket.Tick
        Timer_Description_Ticket.Stop()

        save_Description_Ticket()
    End Sub

    Private Sub Timer_Description_Process_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Description_Process.Tick
        Timer_Description_Process.Stop()

        save_Description_Process()
    End Sub

    Private Sub Timer_Description_ProcessLog_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Description_ProcessLog.Tick
        Timer_Description_ProcessLog.Stop()

        save_Description_ProcessLog()
    End Sub

    Private Sub save_Description_Ticket()
        Dim objSemItem_Ticket As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Ticket.GUID = objDRV_Selected.Item("GUID_Ticket")
        objSemItem_Ticket.Name = objDRV_Selected.Item("Name_Ticket")
        objSemItem_Ticket.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket.GUID
        objSemItem_Ticket.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objSemItem_Result = objTransaction_Ticket.save_014_Ticket__Description(TextBox_Description_Ticket.Text, objSemItem_Ticket, objSemItem_TokenAttribute_Description_Ticket)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Die Beschreibung des Tickets konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
            get_Description_Ticket(objSemItem_Ticket)
        End If
    End Sub

    Private Sub save_Description_Process()
        Dim objsemitem_Result As clsSemItem

        objsemitem_Result = objTransaction_Process.save_004_Process__Description(TextBox_Description_Process.Text, objSemItem_Process, objSemItem_TokenAttribute_Description_Process)
        If objsemitem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Die Beschreibung des Prozesses konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
            get_Description_Process(objSemItem_Process)
        End If
    End Sub

    Private Sub save_Description_ProcessLog()
        Dim objsemitem_Result As clsSemItem

        objsemitem_Result = objTransaction_ProcessLog.save_004_ProcessLog__Description(TextBox_Description_ProcessLog.Text, objSemItem_ProcessLog, objSemItem_TokenAttribute_Description_ProcessLog)
        If objsemitem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Die Beschreibung des Prozesses konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
            get_Description_Process(objSemItem_Process)
        End If
    End Sub

    Private Sub TreeView_Ticket_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView_Ticket.BeforeCheck
        If boolProcessPWork = False Then
            Dim objSemItem_Ticket As New clsSemItem
            Dim objTreeNode_Selected As TreeNode
            Dim objTreeNode_Sub As TreeNode
            Dim objSemItem_Result As clsSemItem
            Dim objSemItem_Process As clsSemItem
            Dim objSemItem_ProcessLog As clsSemItem
            Dim objSemItem_LogEntry As clsSemItem
            Dim boolChecked As Boolean
            Dim boolFinish As Boolean


            objTreeNode_Selected = e.Node
            boolChecked = objTreeNode_Selected.Checked


            If Not objTreeNode_Selected.ImageIndex = cintImage_Root And _
                Not objTreeNode_Selected.ImageIndex = cintImage_Ticket Then

                objSemItem_Ticket = get_TicketFromTree(objTreeNode_Selected)
                If boolChecked = False Then
                    boolFinish = True
                    For Each objTreeNode_Sub In objTreeNode_Selected.Nodes
                        If objTreeNode_Sub.Checked = False Then
                            boolFinish = False
                            Exit For
                        End If
                    Next
                    If boolFinish = True Then
                        objSemItem_Process = New clsSemItem
                        objSemItem_Process.GUID = New Guid(objTreeNode_Selected.Name)
                        objSemItem_Process.Name = objTreeNode_Selected.Text
                        If objTreeNode_Selected.ImageIndex = cintImage_Process Or _
                            objTreeNode_Selected.ImageIndex = cintImage_Process_w_doc Then
                            objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                        Else
                            objSemItem_Process.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID
                        End If
                        objSemItem_Process.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_ProcessLog = objTicketWork.get_ProcessLog(objSemItem_Process, objSemItem_Ticket)

                        objSemItem_Result = objTransaction_Ticket.save_004_Logentry(objLocalConfig.SemItem_Token_Logstate_finished, _
                                                                                    objLocalConfig.SemItem_Token_Logstate_finished.Name, _
                                                                                    Now)


                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_LogEntry = objTransaction_Ticket.SemItem_LogEntry
                            objSemItem_Result = objTransaction_ProcessLog.save_003_ProcessLog_To_LogEntry(objSemItem_LogEntry, objSemItem_ProcessLog, False, True)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTreeNode_Selected.BackColor = Color.Green
                                objTreeNode_Selected.ForeColor = Color.White
                            Else
                                objTransaction_Ticket.del_004_Logentry()
                                MsgBox("Der Arbeitsschritt kann nicht abgeschlossen werden!", MsgBoxStyle.Exclamation)
                                e.Cancel = True
                            End If
                        Else
                            MsgBox("Der Arbeitsschritt kann nicht abgeschlossen werden!", MsgBoxStyle.Exclamation)
                            e.Cancel = True
                        End If
                    Else
                        MsgBox("Bitte erst untergeordnete Arbeitsschritte abschließen!", MsgBoxStyle.Exclamation)
                        e.Cancel = True
                    End If
                Else

                End If

            Else
                If objTreeNode_Selected.ImageIndex = cintImage_Ticket Then
                    objSemItem_Ticket = New clsSemItem
                    objSemItem_Ticket.GUID = New Guid(objTreeNode_Selected.Name)
                    objSemItem_Ticket.Name = objTreeNode_Selected.Text
                    objSemItem_Ticket.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket.GUID
                    objSemItem_Ticket.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    If boolChecked = False Then
                        boolFinish = True
                        For Each objTreeNode_Sub In objTreeNode_Selected.Nodes
                            If objTreeNode_Sub.Checked = False Then
                                boolFinish = False
                                Exit For
                            End If
                        Next
                        If boolFinish = True Then
                            objSemItem_Result = objTransaction_Ticket.save_004_Logentry(objLocalConfig.SemItem_Token_Logstate_finished, "finished", Now)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_Ticket.save_005_Ticket_To_Logentry(Nothing, objSemItem_Ticket, False, True)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objTreeNode_Selected.ForeColor = Color.White
                                    objTreeNode_Selected.BackColor = Color.Green
                                Else
                                    objTransaction_Ticket.del_004_Logentry()
                                    MsgBox("Das Ticket kann nicht wieder geschlossen werden!", MsgBoxStyle.Exclamation)
                                    e.Cancel = True
                                End If
                            Else
                                MsgBox("Das Ticket kann nicht wieder geschlossen werden!", MsgBoxStyle.Exclamation)
                                e.Cancel = True
                            End If
                        Else
                            MsgBox("Bitte erst untergeordnete Arbeitsschritte abschließen!", MsgBoxStyle.Exclamation)
                            e.Cancel = True
                        End If
                    Else
                        objSemItem_Result = objTransaction_Ticket.save_004_Logentry(objLocalConfig.SemItem_Token_Logstate_Start, "Reopen", Now)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Ticket.save_005_Ticket_To_Logentry(Nothing, objSemItem_Ticket)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                objTreeNode_Selected.ForeColor = Color.Black
                                objTreeNode_Selected.BackColor = Nothing
                            Else

                                objTransaction_Ticket.del_004_Logentry()
                                MsgBox("Das Ticket kann nicht wieder geöffnet werden!", MsgBoxStyle.Exclamation)
                                e.Cancel = True
                            End If
                        Else
                            MsgBox("Das Ticket kann nicht wieder geöffnet werden!", MsgBoxStyle.Exclamation)
                            e.Cancel = True
                        End If



                    End If
                Else
                    e.Cancel = True
                End If
            End If



        End If




    End Sub

    Private Function get_TicketFromTree(ByVal objTreeNode As TreeNode) As clsSemItem
        Dim objTreeNode_Parent As TreeNode
        Dim objSemItem_Ticket As clsSemItem

        objTreeNode_Parent = objTreeNode.Parent

        Do

            If Not objTreeNode_Parent.ImageIndex = cintImage_Ticket Then
                objTreeNode_Parent = objTreeNode_Parent.Parent
                If objTreeNode_Parent Is Nothing Then
                    Exit Do
                End If
            End If


        Loop Until objTreeNode_Parent.ImageIndex = cintImage_Ticket

        If Not objTreeNode_Parent Is Nothing Then
            objSemItem_Ticket = New clsSemItem
            objSemItem_Ticket.GUID = New Guid(objTreeNode_Parent.Name)
            objSemItem_Ticket.Name = objTreeNode_Parent.Text
            objSemItem_Ticket.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket.GUID
            objSemItem_Ticket.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


        Else
            objSemItem_Ticket = Nothing
        End If

        Return objSemItem_Ticket
    End Function

    Private Sub InformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationToolStripMenuItem.Click
        Dim objTicketWork As New clsTicketWork(objLocalConfig, Me)

        Dim objSemitem_Ticket_And_ProcessItem() As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemitem_Ticket_And_ProcessItem = get_Ticket_And_ProcessItem()

        If Not objSemitem_Ticket_And_ProcessItem Is Nothing Then

            objDlgAttribute_VARCHARMax = New dlgAttribute_VarcharMax(objLocalConfig.SemItem_Token_LogState_Information.Name, objLocalConfig.Globals)
            objDlgAttribute_VARCHARMax.ShowDialog(Me)
            If objDlgAttribute_VARCHARMax.DialogResult = Windows.Forms.DialogResult.OK Then
                objSemItem_Result = objTicketWork.log_Entry_Information(objSemitem_Ticket_And_ProcessItem(1), objSemitem_Ticket_And_ProcessItem(0), objDlgAttribute_VARCHARMax.Value)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objUserControl_History.clear_History()
                    objUserControl_History.initialize_History(objSemitem_Ticket_And_ProcessItem(1))
                Else
                    MsgBox("Die Information konnte nicht geloggt werden!", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            MsgBox("Das zugehörige Ticket konnte nicht ermittelt werden!", MsgBoxStyle.Exclamation)
        End If





    End Sub

    Private Sub ErrorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrorToolStripMenuItem.Click
        Dim objTicketWork As New clsTicketWork(objLocalConfig, Me)
        Dim objTreeNode As TreeNode

        Dim objSemitem_Ticket_And_ProcessItem() As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemitem_Ticket_And_ProcessItem = get_Ticket_And_ProcessItem()

        If Not objSemitem_Ticket_And_ProcessItem Is Nothing Then

            objDlgAttribute_VARCHARMax = New dlgAttribute_VarcharMax(objLocalConfig.SemItem_Token_LogState_Obsolete.Name, objLocalConfig.Globals)
            objDlgAttribute_VARCHARMax.ShowDialog(Me)
            If objDlgAttribute_VARCHARMax.DialogResult = Windows.Forms.DialogResult.OK Then
                objSemItem_Result = objTicketWork.log_Entry_Error(objSemitem_Ticket_And_ProcessItem(1), objSemitem_Ticket_And_ProcessItem(0), objDlgAttribute_VARCHARMax.Value)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objTreeNode = TreeView_Ticket.SelectedNode
                    objTreeNode.BackColor = Color.Red
                    objUserControl_History.clear_History()
                    objUserControl_History.initialize_History(objSemitem_Ticket_And_ProcessItem(1))
                Else
                    MsgBox("Die Information konnte nicht geloggt werden!", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            MsgBox("Das zugehörige Ticket konnte nicht ermittelt werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub



    Private Function get_Ticket_And_ProcessItem() As clsSemItem()
        Dim objTreeNode As TreeNode
        Dim objSemItem_Ticket_And_ProcessItem(1) As clsSemItem

        objTreeNode = TreeView_Ticket.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cintImage_Incident Or _
                objTreeNode.ImageIndex = cintImage_Incident_w_doc Or _
                objTreeNode.ImageIndex = cintImage_Process Or _
                objTreeNode.ImageIndex = cintImage_Process_w_doc Then
                objSemItem_Ticket_And_ProcessItem(0) = get_TicketFromTree(objTreeNode)
                If Not objSemItem_Ticket_And_ProcessItem(0) Is Nothing Then
                    objSemItem_Ticket_And_ProcessItem(1) = New clsSemItem
                    objSemItem_Ticket_And_ProcessItem(1).GUID = New Guid(objTreeNode.Name)
                    objSemItem_Ticket_And_ProcessItem(1).Name = objTreeNode.Text
                    If objTreeNode.ImageIndex = cintImage_Process Or _
                        objTreeNode.ImageIndex = cintImage_Process_w_doc Then
                        objSemItem_Ticket_And_ProcessItem(1).GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                    Else
                        objSemItem_Ticket_And_ProcessItem(1).GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID
                    End If
                    objSemItem_Ticket_And_ProcessItem(1).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Else
                    objSemItem_Ticket_And_ProcessItem = Nothing
                End If
            Else
                objSemItem_Ticket_And_ProcessItem = Nothing
            End If

        Else

            objSemItem_Ticket_And_ProcessItem = Nothing
        End If

        Return objSemItem_Ticket_And_ProcessItem
    End Function

    Private Sub NewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem1.Click
        Dim objSemitem_Ticket_And_ProcessItem() As clsSemItem
        Dim objSemItem_SubProcess As New clsSemItem
        Dim strProcess As String
        Dim objSemItem_Result As clsSemItem
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Ticket.SelectedNode
        If objTreeNode.ImageIndex = cintImage_Process Or objTreeNode.ImageIndex = cintImage_Process_w_doc Then
            objSemitem_Ticket_And_ProcessItem = get_Ticket_And_ProcessItem()
            If Not objSemitem_Ticket_And_ProcessItem Is Nothing Then
                objDlgAttribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Type_Process.Name, objLocalConfig.Globals)
                objDlgAttribute_VARCHAR255.ShowDialog(Me)
                strProcess = objDlgAttribute_VARCHAR255.Value1
                objSemItem_SubProcess.Name = strProcess
                objSemItem_SubProcess.GUID_Parent = objLocalConfig.SemItem_Type_Process.GUID
                objSemItem_SubProcess.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Result = objTransaction_Process.save_003_Process_To_Parent(objSemitem_Ticket_And_ProcessItem(1), -1, objSemItem_SubProcess)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then
                    MsgBox("Es gibt bereits einen untergeordneten Prozess mit der Bezeichnung.", MsgBoxStyle.Exclamation)
                ElseIf objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Der Prozess konnte nicht hinzugefügt werden!", MsgBoxStyle.Exclamation)
                Else
                    objSemItem_SubProcess = objTransaction_Process.SemItem_Process
                    objTreeNode.Nodes.Add(objSemItem_SubProcess.GUID.ToString, objSemItem_SubProcess.Name, cintImage_Process, cintImage_Process)
                End If
            Else
                MsgBox("Das Ticket konnte nicht ermittelt werden!", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Bitte nur einen Prozess auswählen!", MsgBoxStyle.Exclamation)
        End If

        
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        configure_TabPages(objSemItem_Process, objSemItem_ProcessLog)
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl2.SelectedIndexChanged
        configure_TabPages(objSemItem_Process, objSemItem_ProcessLog)
    End Sub

    Private Sub TabControl3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl3.SelectedIndexChanged
        configure_TabPages(objSemItem_Process, objSemItem_ProcessLog)
    End Sub

    

    
    Private Sub TabControl_PDF_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl_PDF.SelectedIndexChanged
        configure_TabPages(objSemItem_Process, objSemItem_ProcessLog)
    End Sub

    Private Sub frmChangeModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        strTabPage_Image = TabPage_Images.Text
        strTabPage_MediaItem = TabPage_MediaItems.Text
        strTabPage_PDF = TabPage_PDF.Text
    End Sub

    Private Sub ObsoleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObsoleteToolStripMenuItem.Click
        Dim objTicketWork As New clsTicketWork(objLocalConfig, Me)
        Dim objTreeNode As TreeNode

        Dim objSemitem_Ticket_And_ProcessItem() As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemitem_Ticket_And_ProcessItem = get_Ticket_And_ProcessItem()

        If Not objSemitem_Ticket_And_ProcessItem Is Nothing Then

            objDlgAttribute_VARCHARMax = New dlgAttribute_VarcharMax(objLocalConfig.SemItem_Token_LogState_Obsolete.Name, objLocalConfig.Globals)
            objDlgAttribute_VARCHARMax.ShowDialog(Me)
            If objDlgAttribute_VARCHARMax.DialogResult = Windows.Forms.DialogResult.OK Then
                objSemItem_Result = objTicketWork.log_Entry_Obsolete(objSemitem_Ticket_And_ProcessItem(1), objSemitem_Ticket_And_ProcessItem(0), objDlgAttribute_VARCHARMax.Value)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objTreeNode = TreeView_Ticket.SelectedNode

                    boolProcessPWork = True
                    objTreeNode.Checked = True
                    objTreeNode.BackColor = Color.Gray
                    boolProcessPWork = False

                    objUserControl_History.clear_History()
                    objUserControl_History.initialize_History(objSemitem_Ticket_And_ProcessItem(1))
                Else
                    MsgBox("Die Information konnte nicht geloggt werden!", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            MsgBox("Das zugehörige Ticket konnte nicht ermittelt werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub TreeView_Ticket_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_Ticket.DoubleClick
        Dim objTreeNode As TreeNode
        Dim objSemItem_Selected As New clsSemItem
        Dim objSemItems_Parents() As clsSemItem

        objTreeNode = TreeView_Ticket.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cintImage_Ticket
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Process_Ticket.GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objFrmTokenEdit = New frmTokenEdit(objSemItem_Selected, objLocalConfig.Globals)
                    objFrmTokenEdit.ShowDialog(Me)
                Case cintImage_Incident, cintImage_Incident_w_doc
                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objFrmTokenEdit = New frmTokenEdit(objSemItem_Selected, objLocalConfig.Globals)
                    objFrmTokenEdit.ShowDialog(Me)
                Case cintImage_Process, cintImage_Process_w_doc


                    objSemItem_Selected.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Selected.Name = objTreeNode.Text
                    objSemItem_Selected.GUID_Parent = objLocalConfig.SemItem_Type_Process_Log.GUID
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objSemItems_Parents = get_Ticket_And_ProcessItem()
                    objSemItem_Selected = objTicketWork.get_ProcessLog(objSemItem_Selected, objSemItems_Parents(0))
                    objFrmTokenEdit = New frmTokenEdit(objSemItem_Selected, objLocalConfig.Globals)
                    objFrmTokenEdit.ShowDialog(Me)
            End Select
        End If
    End Sub

    Private Sub TreeView_Ticket_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView_Ticket.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                show_Process(objDRV_Selected)
        End Select
    End Sub

    Private Sub SubIncidentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubIncidentToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_Ticket.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cintImage_Incident _
                Or objTreeNode.ImageIndex = cintImage_Incident_w_doc _
                Or objTreeNode.ImageIndex = cintImage_Process _
                Or objTreeNode.ImageIndex = cintImage_Process_w_doc Then
                create_Incident(objTreeNode)
            End If
        End If

        
    End Sub

    Private Sub create_Incident(ByVal objTreeNode_Parent As TreeNode)
        Dim objSemItems_Parents() As clsSemItem
        Dim objSemItem_ProcessLog As clsSemItem
        Dim objSemItem_Incident As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objTreeNodes() As TreeNode

        objSemItems_Parents = get_Ticket_And_ProcessItem()
        If Not objSemItems_Parents Is Nothing Then
            If objSemItems_Parents.Count = 2 Then
                objSemItem_ProcessLog = objTicketWork.get_ProcessLog(objSemItems_Parents(1), objSemItems_Parents(0))
                If Not objSemItem_ProcessLog Is Nothing Then

                    objDlgAttribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Type_Incident.Name, objLocalConfig.Globals)
                    objDlgAttribute_VARCHAR255.ShowDialog(Me)
                    If objDlgAttribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then
                        objSemItem_Incident = New clsSemItem
                        objSemItem_Incident.GUID = Guid.NewGuid
                        objSemItem_Incident.Name = objDlgAttribute_VARCHAR255.Value1
                        objSemItem_Incident.GUID_Parent = objLocalConfig.SemItem_Type_Incident.GUID
                        objSemItem_Incident.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_ProcessLog.save_001_ProcessLogIncident(objSemItem_Incident)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                            objSemItem_Result = objTransaction_ProcessLog.save_005_Incident_To_Parent(objSemItem_ProcessLog)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_Ticket.save_013_Ticket_To_ProcessLogIncident(objSemItem_Incident, objSemItems_Parents(0))
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objTreeNodes = objTreeNode_Parent.Nodes.Find(objSemItem_Incident.GUID.ToString, False)
                                    If objTreeNodes.Count = 0 Then
                                        objTreeNode_Parent.Nodes.Add(objSemItem_Incident.GUID.ToString, objSemItem_Incident.Name, cintImage_Incident, cintImage_Incident)
                                    End If
                                Else
                                    MsgBox("Der Incident kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                    objTransaction_ProcessLog.del_001_ProcessLogIncident()
                                End If
                                
                            Else
                                MsgBox("Der Incident kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                objTransaction_ProcessLog.del_001_ProcessLogIncident()
                            End If
                        Else
                            MsgBox("Der Incident kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub ToolStripTextBox_Reference_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Reference.DoubleClick
        Dim objSemItem_Ref As New clsSemItem
        Dim objDRC_Token As DataRowCollection

        If objDRV_Selected.Item("GUID_ItemType_belongsTo") = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
            objDRC_Token = semtblA_Token.GetData_Token_By_GUID(objDRV_Selected.Item("GUID_item_belongsTo")).Rows
            If objDRC_Token.Count > 0 Then
                objSemItem_Ref.GUID = objDRC_Token(0).Item("GUID_Token")
                objSemItem_Ref.Name = objDRC_Token(0).Item("Name_Token")
                objSemItem_Ref.GUID_Parent = objDRC_Token(0).Item("GUID_Type")
                objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objFrmTokenEdit = New frmTokenEdit(objSemItem_Ref, objLocalConfig.Globals)
                objFrmTokenEdit.ShowDialog(Me)
            Else
                MsgBox("Die Referenz konnte nicht gefunden werden!", MsgBoxStyle.Exclamation)
            End If
            
        End If

    End Sub
End Class
