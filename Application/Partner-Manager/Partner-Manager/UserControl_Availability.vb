Imports Sem_Manager
Public Class UserControl_Availability
    Private cintImageID_Root As Integer = 0
    Private cintImageID_Closed As Integer = 1
    Private cintImageID_OPened As Integer = 2

    Private objLocalConfig As clsLocalConfig
    Private objSemItem_Partner As clsSemItem

    Private objTransaction_Availability As clsTransaction_Availability

    Private semtblA_Weekdays As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_Weekdays As New ds_Token.func_TokenTokenDataTable
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private procA_related_Availabilities_ByGUID_AvailabilityData As New ds_AddressTableAdapters.proc_related_Availabilities_ByGUID_AvailabilityDataTableAdapter
    Private procT_related_Availabilities_ByGUID_AvailabilityData As New ds_Address.proc_related_Availabilities_ByGUID_AvailabilityDataDataTable

    Private objDLG_Attribute_VARCHAR255 As dlgAttribute_Varchar255

    Private objTreeNode_Root As TreeNode
    Private objSemItem_Availability As clsSemItem
    Private objSemItem_AvailabilityData As clsSemItem

    Private objDRC_NachVereinbarung As DataRowCollection

    Private boolLoadDG As Boolean

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        

        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        set_DBConnection()

        get_Data_Weekdays()
    End Sub

    Public Sub initialize(ByVal SemItem_Partner As clsSemItem)

        objSemItem_Partner = SemItem_Partner

        TreeView_AvailabilityData.Nodes.Clear()
        funcA_TokenToken.ClearBeforeFill = False

        objSemItem_Availability = Nothing

        objTreeNode_Root = TreeView_AvailabilityData.Nodes.Add(objLocalConfig.SemItem_Type_Availability_Data.GUID.ToString, objLocalConfig.SemItem_Type_Availability_Data.Name, cintImageID_Root, cintImageID_Root)
        fill_Tree()

        configure_Controls()
    End Sub

    Private Sub configure_Controls()
        Dim objListViewItem As ListViewItem
        If objSemItem_AvailabilityData Is Nothing Then
            If Not objSemItem_Partner Is Nothing Then
                Button_Save.Enabled = False
                Button_Delete.Enabled = False

                CheckBox_byArrangement.Enabled = False

                ComboBox_Weekday.Enabled = False

                MaskedTextBox_To.Enabled = False
                MaskedTextBox_To.Text = Hour(Now) & ":" & Minute(Now)
                MaskedTextBox_To.Enabled = False

                MaskedTextBox_From.Enabled = False
                MaskedTextBox_From.Text = Hour(Now) & ":" & Minute(Now)
                MaskedTextBox_From.Enabled = False

                procT_related_Availabilities_ByGUID_AvailabilityData.Clear()

            Else
                Button_Save.Enabled = False
                Button_Delete.Enabled = False

                CheckBox_byArrangement.Enabled = False
                
                MaskedTextBox_To.Enabled = False
                MaskedTextBox_To.Text = Hour(Now) & ":" & Minute(Now)
                MaskedTextBox_To.Enabled = False

                MaskedTextBox_From.Enabled = False
                MaskedTextBox_From.Text = Hour(Now) & ":" & Minute(Now)
                MaskedTextBox_From.Enabled = False

                ComboBox_Weekday.Enabled = False

                procT_related_Availabilities_ByGUID_AvailabilityData.Clear()

            End If
        Else
            If objSemItem_Availability Is Nothing Then
                Button_Save.Enabled = False
                Button_Delete.Enabled = False

                DataGridView_Availabilities.Enabled = False
                MaskedTextBox_From.Enabled = False
                MaskedTextBox_To.Enabled = False

                
                get_Data_NachVereinbarung()

                ComboBox_Weekday.Enabled = True
                Button_Save.Enabled = True
                CheckBox_byArrangement.Enabled = True

                DataGridView_Availabilities.Enabled = True
                MaskedTextBox_From.Enabled = True
                MaskedTextBox_To.Enabled = True
            Else
                Button_Save.Enabled = True
                Button_Delete.Enabled = True
                CheckBox_byArrangement.Enabled = True
                ComboBox_Weekday.Enabled = True

            End If
        End If

    End Sub

    Private Sub get_Data_Availabilities(ByVal objTreeNode_Selected As TreeNode)

        If Not objTreeNode_Selected Is Nothing Then
            objSemItem_AvailabilityData = New clsSemItem
            objSemItem_AvailabilityData.GUID = New Guid(objTreeNode_Selected.Name)
            objSemItem_AvailabilityData.Name = objTreeNode_Selected.Text
            objSemItem_AvailabilityData.GUID_Parent = objLocalConfig.SemItem_Type_Availability_Data.GUID
            boolLoadDG = True
            procA_related_Availabilities_ByGUID_AvailabilityData.Fill(procT_related_Availabilities_ByGUID_AvailabilityData, _
                                                                  objLocalConfig.SemItem_Attribute_Timestamp__To_.GUID, _
                                                                  objLocalConfig.SemItem_Attribute_Timestamp__from_.GUID, _
                                                                  objLocalConfig.SemItem_Type_Availabilities.GUID, _
                                                                  objLocalConfig.SemItem_Type_Weekdays.GUID, _
                                                                  objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                  objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                  objLocalConfig.SemItem_RelationType_needs.GUID, _
                                                                  New Guid(objTreeNode_Selected.Name), _
                                                                  objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                  Nothing, _
                                                                  Nothing, _
                                                                  Nothing)
            boolLoadDG = False
        Else
            objSemItem_AvailabilityData = Nothing
        End If
        




    End Sub

    

    Private Sub fill_Tree()

        Dim objDRC_AvailabilityData As DataRowCollection
        Dim objDR_AvailabilityData As DataRow
        Dim intCount As Integer
        intCount = 0
        If Not objSemItem_Partner Is Nothing Then
            objDRC_AvailabilityData = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Partner.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                            objLocalConfig.SemItem_Type_Availability_Data.GUID).Rows
            For Each objDR_AvailabilityData In objDRC_AvailabilityData
                intCount = intCount + 1
                objTreeNode_Root.Nodes.Add(objDR_AvailabilityData.Item("GUID_Token_Left").ToString, objDR_AvailabilityData.Item("Name_Token_Left"), cintImageID_Closed, cintImageID_OPened)

            Next
            TreeView_AvailabilityData.ExpandAll()
        End If
        ToolStripLabel_CountAvailabilityData.Text = intCount
    End Sub

    Private Sub get_Data_Weekdays()
        Dim objDR_WeekDays As DataRow
        semtblT_Weekdays = objLocalConfig.Table_Weekdays
        ComboBox_Weekday.DataSource = semtblT_Weekdays
        ComboBox_Weekday.DisplayMember = "Name_Token_Right"
        ComboBox_Weekday.ValueMember = "GUID_Token_Right"
    End Sub

    Private Sub get_Data_NachVereinbarung()


        If Not objSemItem_AvailabilityData Is Nothing Then
            objDRC_NachVereinbarung = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_AvailabilityData.GUID, _
                                                                                                                     objLocalConfig.SemItem_Attribute_Nach_Vereinbarung.GUID).Rows

            CheckBox_byArrangement.Enabled = False
            If objDRC_NachVereinbarung.Count > 0 Then

                CheckBox_byArrangement.Checked = objDRC_NachVereinbarung(0).Item("Val_Bool")

            Else

                CheckBox_byArrangement.Checked = False
                objDRC_NachVereinbarung = Nothing
            End If
        Else
            CheckBox_byArrangement.Checked = False
        End If

    End Sub
    Private Sub set_DBConnection()
        semtblA_Weekdays.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        procA_related_Availabilities_ByGUID_AvailabilityData.Connection = objLocalConfig.Connection_Plugin

        objTransaction_Availability = New clsTransaction_Availability(objLocalConfig)
    End Sub

    


    Private Sub TreeView_AvailabilityData_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_AvailabilityData.AfterSelect
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_AvailabilityData.SelectedNode
        objSemItem_AvailabilityData = Nothing
        objSemItem_Availability = Nothing
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cintImageID_Closed Then
                get_Data_Availabilities(objTreeNode)
                boolLoadDG = True
                BindingSource_Availabilities.DataSource = procT_related_Availabilities_ByGUID_AvailabilityData
                DataGridView_Availabilities.DataSource = BindingSource_Availabilities
                DataGridView_Availabilities.Columns(0).Visible = False
                DataGridView_Availabilities.Columns(1).Visible = False
                DataGridView_Availabilities.Columns(2).Visible = False
                DataGridView_Availabilities.Columns(3).Visible = False
                DataGridView_Availabilities.Columns(5).Visible = False
                DataGridView_Availabilities.Columns(6).Visible = False
                DataGridView_Availabilities.Columns(7).DefaultCellStyle.Format = "HH:mm"
                DataGridView_Availabilities.Columns(8).Visible = False
                DataGridView_Availabilities.Columns(9).DefaultCellStyle.Format = "HH:mm"
                DataGridView_Availabilities.Columns(10).Visible = False
                boolLoadDG = False

            End If
        End If

        configure_Controls()
        ToolStripLabel_AvailabilitiesCount.Text = DataGridView_Availabilities.Rows.Count
    End Sub

    Private Sub DataGridView_Availabilities_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Availabilities.SelectionChanged
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_WeekDay_First() As DataRow
        Dim objListItem_Selected As ListViewItem
        Dim i As Integer
        If boolLoadDG = False Then

            objSemItem_Availability = Nothing
            If DataGridView_Availabilities.Enabled = True Then



                If DataGridView_Availabilities.SelectedRows.Count = 1 Then
                    objDGVR_Selected = DataGridView_Availabilities.SelectedRows(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    objSemItem_Availability = New clsSemItem
                    objSemItem_Availability.GUID = objDRV_Selected.Item("GUID_Availabilities")
                    objSemItem_Availability.Name = objDRV_Selected.Item("Name_Availabilities")
                    objSemItem_Availability.GUID_Parent = objLocalConfig.SemItem_Type_Availabilities.GUID
                    objSemItem_Availability.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    
                    If Not IsDBNull(objDRV_Selected.Item("To")) Then
                        MaskedTextBox_To.Text = CDate(objDRV_Selected.Item("To")).ToString("HH:mm")

                    Else
                        MaskedTextBox_To.Text = Now.ToString("HH:mm")

                    End If

                    If Not IsDBNull(objDRV_Selected.Item("From")) Then
                        MaskedTextBox_From.Text = CDate(objDRV_Selected.Item("From")).ToString("HH:mm")
                    Else
                        MaskedTextBox_From.Text = Now.ToString("HH:mm")

                    End If

                    If Not IsDBNull(objDRV_Selected.Item("GUID_WeekDays")) Then
                        ComboBox_Weekday.SelectedValue = objDRV_Selected.Item("GUID_WeekDays")
                    Else
                        objDRs_WeekDay_First = semtblT_Weekdays.Select("OrderID=1")
                        If objDRs_WeekDay_First.Length > 0 Then
                            ComboBox_Weekday.SelectedValue = objDRs_WeekDay_First(0).Item("GUID_Token_Right")
                        End If
                    End If

                Else
                    objSemItem_Availability = Nothing
                End If
            End If
        End If
        configure_Controls()

    End Sub

    Private Sub ContextMenuStrip_Tree_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Tree.Opening
        Dim objTreeNode_Selected As TreeNode
        NewToolStripMenuItem_Tree.Enabled = False
        RemoveToolStripMenuItem_Tree.Enabled = False
        If Not objSemItem_Partner Is Nothing Then
            NewToolStripMenuItem_Tree.Enabled = True
        End If

        objTreeNode_Selected = TreeView_AvailabilityData.SelectedNode
        If Not objTreeNode_Selected Is Nothing Then
            If objTreeNode_Selected.ImageIndex = cintImageID_Closed Then
                RemoveToolStripMenuItem_Tree.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save.Click
        Dim objSemItem_WeekDay As New clsSemItem
        Dim objDRV_Weekday As DataRowView
        Dim objDRs_Availability() As DataRow
        Dim date_From As Date
        Dim date_To As Date
        Dim objTreeNode As TreeNode
        Dim objSemItem_Result As clsSemItem
        Dim strFilter As String

        objTreeNode = TreeView_AvailabilityData.SelectedNode
        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cintImageID_Closed Then
                get_Data_Availabilities(objTreeNode)
                objDRV_Weekday = ComboBox_Weekday.SelectedItem
                If Date.TryParse(MaskedTextBox_From.Text, date_From) = True Then
                    If Date.TryParse(MaskedTextBox_To.Text, date_To) = True Then
                        objSemItem_WeekDay = New clsSemItem
                        objSemItem_WeekDay.GUID = objDRV_Weekday.Item("GUID_Token_Right")
                        objSemItem_WeekDay.Name = objDRV_Weekday.Item("Name_Token_Right")
                        objSemItem_WeekDay.GUID_Parent = objLocalConfig.SemItem_Type_Weekdays.GUID
                        objSemItem_WeekDay.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        strFilter = "GUID_WeekDays='" & objDRV_Weekday.Item("GUID_Token_Right").ToString & "' AND " & _
                                    "From = '01.01.1900 " & date_From.ToString("HH:mm") & "' AND " & _
                                    "To = '01.01.1900 " & date_To.ToString("HH:mm") & "'"
                        objDRs_Availability = procT_related_Availabilities_ByGUID_AvailabilityData.Select(strFilter)
                        If objDRs_Availability.Count = 0 Then
                            objSemItem_Result = objTransaction_Availability.save_001_AvailabilityData(objSemItem_AvailabilityData)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_Availability.save_002_Availability__ByArrangement(CheckBox_byArrangement.Checked, objSemItem_AvailabilityData)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Availability = New clsSemItem
                                    objSemItem_Availability.GUID = Guid.NewGuid
                                    objSemItem_Availability.Name = objSemItem_WeekDay.Name
                                    objSemItem_Availability.GUID_Parent = objLocalConfig.SemItem_Type_Availabilities.GUID
                                    objSemItem_Availability.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    objSemItem_Result = objTransaction_Availability.save_003_Availability(objSemItem_Availability)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_Availability.save_004_AvailabiltyData_To_Availability
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_Availability.save_005_Availability__From(date_From)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_Availability.save_006_Availability__To(date_To)
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_Availability.save_007_Availability_To_Weekday(objSemItem_WeekDay)
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        get_Data_Availabilities(objTreeNode)
                                                        configure_Controls()
                                                    Else
                                                        objSemItem_Result = objTransaction_Availability.del_006_Availability__To
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_Availability.del_005_Availability__From()
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_Availability.del_004_AvailabilityData_To_Availability()
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objTransaction_Availability.del_003_Availability()
                                                                End If
                                                            End If
                                                        End If



                                                        objTransaction_Availability.del_002_AvailabilityData__ByArrangement()

                                                        MsgBox("Nach Vereinbarung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                    End If
                                                Else
                                                    objSemItem_Result = objTransaction_Availability.del_005_Availability__From()
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_Availability.del_004_AvailabilityData_To_Availability()
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objTransaction_Availability.del_003_Availability()
                                                        End If
                                                    End If


                                                    objTransaction_Availability.del_002_AvailabilityData__ByArrangement()

                                                    MsgBox("Nach Vereinbarung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                End If
                                            Else
                                                objSemItem_Result = objTransaction_Availability.del_004_AvailabilityData_To_Availability()
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objTransaction_Availability.del_003_Availability()
                                                End If

                                                objTransaction_Availability.del_002_AvailabilityData__ByArrangement()

                                                MsgBox("Nach Vereinbarung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                            End If
                                        Else
                                            objTransaction_Availability.del_003_Availability()
                                            objTransaction_Availability.del_002_AvailabilityData__ByArrangement()

                                            MsgBox("Nach Vereinbarung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                        End If
                                    Else

                                        MsgBox("Nach Vereinbarung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    MsgBox("Nach Vereinbarung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Dem Partner konnten keine Erreichbarkeits-Daten angehängt werden!", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Exists
                        End If
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


    End Sub

    Private Sub NewToolStripMenuItem_Tree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem_Tree.Click
        Dim objSemItem_AvailabilityData As New clsSemItem
        Dim objDRC_AvailabilityData As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim objTreeNode_AvailabilityData As TreeNode
        objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Type_Availability_Data.Name, objLocalConfig.Globals)
        objDLG_Attribute_VARCHAR255.ShowDialog(Me)
        If objDLG_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
            objSemItem_AvailabilityData.Name = objDLG_Attribute_VARCHAR255.Value1
            objDRC_AvailabilityData = funcA_TokenToken.GetData_By_GUIDToken_Right_GUIDType_Left_TokenName_Left_GUIDRel(objSemItem_Partner.GUID, _
                                                                                                                       objSemItem_AvailabilityData.Name, _
                                                                                                                       objLocalConfig.SemItem_Type_Availability_Data.GUID, _
                                                                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If objDRC_AvailabilityData.Count = 0 Then
                objSemItem_AvailabilityData.GUID = Guid.NewGuid
                objSemItem_AvailabilityData.GUID_Parent = objLocalConfig.SemItem_Type_Availability_Data.GUID
                objSemItem_AvailabilityData.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_Availability.save_001_AvailabilityData(objSemItem_AvailabilityData)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_Availability.save_001a_AvailabilityData_To_Partner(objSemItem_Partner)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objTreeNode_AvailabilityData = objTreeNode_Root.Nodes.Add(objSemItem_AvailabilityData.GUID.ToString, _
                                                                                  objSemItem_AvailabilityData.Name, cintImageID_Closed, cintImageID_OPened)
                        TreeView_AvailabilityData.SelectedNode = objTreeNode_AvailabilityData
                    Else
                        objTransaction_Availability.del_001_AvailabilityData()

                        MsgBox("Die Erreichbarkeit konnte nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Die Erreichbarkeit konnte nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Es gibt bereits eine Erreichbarkeit mit diesem Namen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
End Class
