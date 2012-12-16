Imports Sem_Manager
Imports MediaViewer_Module
Public Class frmOutlookConnector
    Private objLocalConfig As clsLocalConfig

    Private procA_Exists_MailItem As New DataSet_OutlookConnectorTableAdapters.proc_Exists_MailItemTableAdapter

    Private objTransaction_OutlookConnector As clsTransactionOutlookConnector

    Private objUserControl_PDFViewer As UserControl_PDFViewer
    Private objFrmTokenEdit As frmTokenEdit

    Private objOutlookConnector As clsConnector
    Private dlgDateFilter As Dialog_DateFilter

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        set_DBConnection()

        Initialize()
    End Sub

    Private Sub Initialize()

    End Sub

    Private Sub set_DBConnection()
        Me.Proc_MailItemsTableAdapter.Connection = objLocalConfig.Connection_Plugin
        procA_Exists_MailItem.Connection = objLocalConfig.Connection_Plugin
        objTransaction_OutlookConnector = New clsTransactionOutlookConnector(objLocalConfig)
        objOutlookConnector = New clsConnector(objLocalConfig)
    End Sub

    Private Sub Button_GetMailItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_GetMailItems.Click
        objOutlookConnector.get_MailItemsFromOutlook()
        Me.Proc_MailItemsTableAdapter.Fill(Me.DataSet_OutlookConnector.proc_MailItems, _
                                           objLocalConfig.SemItem_Type_Outlook_Item.GUID)
    End Sub

    Private Sub frmOutlookConnector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet_OutlookConnector.mltbl_MailItems". Sie können sie bei Bedarf verschieben oder entfernen.

        get_StateAndFolder()

        refresh_Items()
    End Sub

    Private Sub refresh_Items()
        Me.Proc_MailItemsTableAdapter.Fill(Me.DataSet_OutlookConnector.proc_MailItems, objLocalConfig.SemItem_Type_Outlook_Item.GUID)
    End Sub

    Private Sub Button_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Refresh.Click
        get_StateAndFolder()
    End Sub

    Private Sub get_StateAndFolder()
        Try
            Button_GetMailItems.Enabled = True
            Label_State.Text = objOutlookConnector.State_Outlook
            Label_CurrentFolder.Text = objOutlookConnector.CurrentFolder
        Catch ex As Exception
            Button_GetMailItems.Enabled = False

        End Try
        
    End Sub



    Private Sub ContextMenuStrip_Filter_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Filter.Opening

        OpenToolStripMenuItem.Enabled = False
        ContainsToolStripMenuItem.Enabled = False
        EquivalentToolStripMenuItem.Enabled = False
        NotEquivalentToolStripMenuItem.Enabled = False
        DateToolStripMenuItem.Enabled = False
        CopyToolStripMenuItem.Enabled = False
        CreateItemsToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False

        If DataGridView_MailItems.SelectedCells.Count = 1 Then
            ContainsToolStripMenuItem.Enabled = True
            EquivalentToolStripMenuItem.Enabled = True
            NotEquivalentToolStripMenuItem.Enabled = True
            DateToolStripMenuItem.Enabled = True
            CopyToolStripMenuItem.Enabled = True
        End If
        If Label_State.Text = "Running" Then
            If DataGridView_MailItems.SelectedRows.Count = 1 Then
                OpenToolStripMenuItem.Enabled = True
            End If

        End If

        If DataGridView_MailItems.SelectedRows.Count > 0 Then
            CreateItemsToolStripMenuItem.Enabled = True
            DeleteToolStripMenuItem.Enabled = True
        End If

    End Sub



    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim strEntryID As String

        objDGVR_Selected = DataGridView_MailItems.SelectedRows(0)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        strEntryID = objDRV_Selected.Item("EntryID")
        objOutlookConnector.open_MailItem(strEntryID)

    End Sub

    Private Sub EquivalentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquivalentToolStripMenuItem.Click
        filterGrid(EquivalentToolStripMenuItem.Name)
    End Sub

    Private Sub filterGrid(ByVal strType As String)
        Dim strColumn As String = ""
        Dim strFilterText As String = ""
        Dim strFilter As String = ""
        Dim strPrefix As String = ""
        Dim strPostfix As String = ""
        Dim strConnector As String = ""
        Dim intColumnIndex As Integer
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        strFilter = MltblMailItemsBindingSource.Filter



        intColumnIndex = DataGridView_MailItems.SelectedCells(0).ColumnIndex
        strColumn = DataGridView_MailItems.Columns(intColumnIndex).HeaderText
        objDGVR_Selected = DataGridView_MailItems.Rows(DataGridView_MailItems.SelectedCells(0).RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        If strColumn <> "" Then
            Select Case strType
                Case ContainsToolStripMenuItem.Name
                    strPrefix = "%"
                    strPostfix = "%"
                    strConnector = " LIKE "
                    strFilterText = ToolStripTextBox_Contains.Text
                    strFilterText = strFilterText.Replace("'", "''")
                    strFilterText = "'" & strPrefix & strFilterText & strPostfix & "'"
                Case EquivalentToolStripMenuItem.Name
                    strPrefix = ""
                    strPostfix = ""
                    strConnector = " = "
                    strFilterText = objDRV_Selected.Item(strColumn)
                    strFilterText = strFilterText.Replace("'", "''")
                    strFilterText = "'" & strPrefix & strFilterText & strPostfix & "'"
                Case NotEquivalentToolStripMenuItem.Name
                    strPrefix = ""
                    strPostfix = ""
                    strConnector = " != "
                    strFilterText = objDRV_Selected.Item(strColumn)
                    strFilterText = strFilterText.Replace("'", "''")
                    strFilterText = "'" & strPrefix & strFilterText & strPostfix & "'"
                Case DateToolStripMenuItem.Name
                    strPrefix = ""
                    strPostfix = ""
                    strConnector = " >= "
                    strFilterText = "'" & dlgDateFilter.DateStart & "' AND " & "[" & strColumn & "]<='" & dlgDateFilter.DateEnd & "'"

            End Select

            If strFilterText <> "" Then

                If Not strFilter = "" Then
                    strFilter = strFilter & " AND "
                End If

                strFilter = strFilter & "[" & strColumn & "]" & strConnector & strFilterText
                MltblMailItemsBindingSource.Filter = strFilter
                Label_Filter.Text = strFilter
            Else
                MsgBox("Bitte geben Sie einen Filter ein", MsgBoxStyle.Information)

            End If
        End If
    End Sub

    Private Sub NotEquivalentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotEquivalentToolStripMenuItem.Click
        filterGrid(NotEquivalentToolStripMenuItem.Name)
    End Sub


    Private Sub ContainsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContainsToolStripMenuItem.Click
        filterGrid(ContainsToolStripMenuItem.Name)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        MltblMailItemsBindingSource.RemoveFilter()
        Label_Filter.Text = "-"
    End Sub

    Private Sub DateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateToolStripMenuItem.Click
        dlgDateFilter = New Dialog_DateFilter()
        dlgDateFilter.ShowDialog(Me)
        If dlgDateFilter.DialogResult = Windows.Forms.DialogResult.OK Then
            filterGrid(DateToolStripMenuItem.Name)
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        objDGVR_Selected = DataGridView_MailItems.Rows(DataGridView_MailItems.SelectedCells(0).RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        Clipboard.SetDataObject(objDRV_Selected.Item(DataGridView_MailItems.Columns(DataGridView_MailItems.SelectedCells(0).ColumnIndex).HeaderText).ToString)
    End Sub

    Private Sub CreateItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateItemsToolStripMenuItem.Click
        putItemToSemDB()
        refresh_Items()
    End Sub

    Private Sub putItemToSemDB()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_Sem As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_MailItem As New clsSemItem
        Dim objSemItem_OutlookItem As New clsSemItem
        Dim objSemItem_EmailAddress_Von As New clsSemItem
        Dim objSemItems_EmailAddress_An() As clsSemItem
        Dim objSemItem_EmailAddress_An As clsSemItem
        Dim strTOs() As String
        Dim i As Integer
        Dim intToDo As Integer
        Dim intDone As Integer
        Dim intError As Integer

        intToDo = DataGridView_MailItems.SelectedRows.Count
        intDone = 0
        intError = 0

        For Each objDGVR_Selected In DataGridView_MailItems.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objDRC_Sem = procA_Exists_MailItem.GetData(objLocalConfig.SemItem_Type_Outlook_Item.GUID, _
                                                       objLocalConfig.SemItem_Type_e_Mail.GUID, _
                                                       objLocalConfig.SemItem_Type_eMail_Address.GUID, _
                                                       objLocalConfig.SemItem_RelationType_is.GUID, _
                                                       objLocalConfig.SemItem_RelationType_Von.GUID, _
                                                       objLocalConfig.SemItem_RelationType_An.GUID, _
                                                       objDRV_Selected.Item("EntryID")).Rows
            If objDRC_Sem.Count = 0 Then
                objSemItem_MailItem.GUID = Guid.NewGuid
                objSemItem_MailItem.Name = objDRV_Selected.Item("Subject")
                objSemItem_MailItem.GUID_Parent = objLocalConfig.SemItem_Type_e_Mail.GUID
                objSemItem_MailItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_OutlookConnector.save_001_MailItem(objSemItem_MailItem)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_OutlookConnector.save_002_MailItem_To_Sended(objDRV_Selected.Item("CreationDate"))
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                        objSemItem_EmailAddress_Von = Nothing
                        objSemItems_EmailAddress_An = Nothing
                        If Not IsDBNull(objDRV_Selected.Item("SenderEmailAddress")) Then
                            If Not objDRV_Selected.Item("SenderEmailAddress") = "" Then
                                objSemItem_EmailAddress_Von = New clsSemItem
                                objSemItem_EmailAddress_Von.GUID = Guid.NewGuid
                                objSemItem_EmailAddress_Von.Name = objDRV_Selected.Item("SenderEmailAddress")
                                objSemItem_EmailAddress_Von.GUID_Parent = objLocalConfig.SemItem_Type_eMail_Address.GUID
                                objSemItem_EmailAddress_Von.Mark = True
                                objSemItem_EmailAddress_Von.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objSemItem_Result = objTransaction_OutlookConnector.save_003_EmailAddress(objSemItem_EmailAddress_Von)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_EmailAddress_Von = objTransaction_OutlookConnector.SemItem_EmailAdr_Von
                                Else

                                    objSemItem_Result = objTransaction_OutlookConnector.del_002_MailItem_To_Sended
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_OutlookConnector.del_001_MailItem()
                                    End If
                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                    intError = intError + 1
                                End If
                            End If
                        End If

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            If Not IsDBNull(objDRV_Selected.Item("To")) Then
                                If Not objDRV_Selected.Item("To") = "" Then
                                    strTOs = objDRV_Selected.Item("To").ToString.Split(";")
                                    ReDim Preserve objSemItems_EmailAddress_An(strTOs.Count)
                                    For i = 0 To strTOs.Count - 1
                                        objSemItems_EmailAddress_An(i) = New clsSemItem
                                        objSemItems_EmailAddress_An(i).GUID = Guid.NewGuid
                                        objSemItems_EmailAddress_An(i).Name = objDRV_Selected.Item("To")
                                        If objSemItems_EmailAddress_An(i).Name.StartsWith("'") Then
                                            objSemItems_EmailAddress_An(i).Name = objSemItems_EmailAddress_An(i).Name.Remove(0, 1)
                                        End If
                                        If objSemItems_EmailAddress_An(i).Name.EndsWith("'") Then
                                            objSemItems_EmailAddress_An(i).Name = objSemItems_EmailAddress_An(i).Name.Remove(objSemItems_EmailAddress_An(i).Name.Length - 1, 1)
                                        End If
                                        objSemItems_EmailAddress_An(i).GUID_Parent = objLocalConfig.SemItem_Type_eMail_Address.GUID
                                        objSemItems_EmailAddress_An(i).Mark = False
                                        objSemItems_EmailAddress_An(i).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                        objSemItem_Result = objTransaction_OutlookConnector.save_003_EmailAddress(objSemItems_EmailAddress_An(i))
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItems_EmailAddress_An(i) = objTransaction_OutlookConnector.SemItem_EmailAdr_An
                                        Else

                                            objSemItem_Result = objTransaction_OutlookConnector.del_002_MailItem_To_Sended
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objTransaction_OutlookConnector.del_001_MailItem()
                                            End If
                                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                            intError = intError + 1
                                            Exit For
                                        End If
                                    Next


                                End If
                            End If
                        End If

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            If Not objSemItem_EmailAddress_Von Is Nothing Then
                                objSemItem_Result = objTransaction_OutlookConnector.save_004_MailItem_VonAn(objSemItem_EmailAddress_Von)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                    objSemItem_Result = objTransaction_OutlookConnector.del_002_MailItem_To_Sended
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_OutlookConnector.del_001_MailItem()
                                    End If
                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                    intError = intError + 1
                                End If
                            End If

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                For Each objSemItem_EmailAddress_An In objSemItems_EmailAddress_An
                                    If Not objSemItem_EmailAddress_An Is Nothing Then
                                        objSemItem_Result = objTransaction_OutlookConnector.save_004_MailItem_VonAn(objSemItem_EmailAddress_An)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                            objSemItem_Result = objTransaction_OutlookConnector.del_002_MailItem_To_Sended
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objTransaction_OutlookConnector.del_001_MailItem()
                                            End If
                                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                            intError = intError + 1
                                            Exit For
                                        End If
                                    End If

                                Next

                            End If
                        End If

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_OutlookItem.GUID = Guid.NewGuid
                            objSemItem_OutlookItem.Name = objDRV_Selected.Item("EntryID")
                            objSemItem_OutlookItem.GUID_Parent = objLocalConfig.SemItem_Type_Outlook_Item.GUID
                            objSemItem_OutlookItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Result = objTransaction_OutlookConnector.save_005_OutlookItem(objSemItem_OutlookItem)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_OutlookConnector.save_006_OutlookItem_To_MailItem
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    intDone = intDone + 1
                                Else
                                    objSemItem_Result = objTransaction_OutlookConnector.del_002_MailItem_To_Sended
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_OutlookConnector.del_001_MailItem()
                                    End If
                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                    intError = intError + 1
                                End If
                            Else
                                objSemItem_Result = objTransaction_OutlookConnector.del_002_MailItem_To_Sended
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objTransaction_OutlookConnector.del_001_MailItem()
                                End If
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                intError = intError + 1
                            End If
                        End If
                    Else
                        objTransaction_OutlookConnector.del_001_MailItem()
                        intError = intError + 1
                    End If
                Else
                    intError = intError + 1
                End If
            Else

            End If

        Next
        If intError > 0 Then
            MsgBox("Es sind " & intError & " Fehler aufgetreten!", MsgBoxStyle.Exclamation)
        End If

        If intDone < intToDo Then
            MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Emails importiert werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    

    
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        If MsgBox("Wollen Sie die Mails wirklich löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For Each objDGVR_Selected In DataGridView_MailItems.SelectedRows
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                Me.Proc_MailItemsTableAdapter.proc_del_MailItem(objDRV_Selected.Item("id"))
            Next
        End If

        Me.Proc_MailItemsTableAdapter.Fill(Me.DataSet_OutlookConnector.proc_MailItems, objLocalConfig.SemItem_Type_Outlook_Item.GUID)
    End Sub

    Private Sub DataGridView_MailItems_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView_MailItems.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                refresh_Items()
        End Select
    End Sub



    Private Sub DataGridView_MailItems_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_MailItems.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_MailItem As DataRowCollection
        Dim objSemItem_MailItem As New clsSemItem

        objDGVR_Selected = DataGridView_MailItems.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        If objDRV_Selected.Item("SemItem_Present") = True Then

            objDGVR_Selected = DataGridView_MailItems.Rows(e.RowIndex)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objDRC_MailItem = procA_Exists_MailItem.GetData(objLocalConfig.SemItem_Type_Outlook_Item.GUID, _
                                                             objLocalConfig.SemItem_Type_e_Mail.GUID, _
                                                             objLocalConfig.SemItem_Type_eMail_Address.GUID, _
                                                             objLocalConfig.SemItem_RelationType_is.GUID, _
                                                             objLocalConfig.SemItem_RelationType_Von.GUID, _
                                                             objLocalConfig.SemItem_RelationType_An.GUID, _
                                                             objDRV_Selected.Item("EntryID")).Rows
            If objDRC_MailItem.Count > 0 Then
                objSemItem_MailItem.GUID = objDRC_MailItem(0).Item("GUID_e_Mail")
                objSemItem_MailItem.Name = objDRC_MailItem(0).Item("Name_e_Mail")
                objSemItem_MailItem.GUID_Parent = objLocalConfig.SemItem_Type_e_Mail.GUID
                objSemItem_MailItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objFrmTokenEdit = New frmTokenEdit(objSemItem_MailItem, objLocalConfig.Globals)
                objFrmTokenEdit.ShowDialog(Me)
            Else
                MsgBox("Es existiert kein Sem-Item zu dieser Mail!", MsgBoxStyle.Information)
            End If
        Else
            putItemToSemDB()
        End If
    End Sub

    Private Sub DataGridView_MailItems_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_MailItems.SelectionChanged
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_MailItem As DataRowCollection
        Dim objSemItem_MailItem As New clsSemItem

        If Not objUserControl_PDFViewer Is Nothing Then
            objUserControl_PDFViewer.clear()
            objUserControl_PDFViewer.Dispose()

        End If


        If DataGridView_MailItems.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_MailItems.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            If objDRV_Selected.Item("SemItem_Present") = True Then
                objDRC_MailItem = procA_Exists_MailItem.GetData(objLocalConfig.SemItem_Type_Outlook_Item.GUID, _
                                                             objLocalConfig.SemItem_Type_e_Mail.GUID, _
                                                             objLocalConfig.SemItem_Type_eMail_Address.GUID, _
                                                             objLocalConfig.SemItem_RelationType_is.GUID, _
                                                             objLocalConfig.SemItem_RelationType_Von.GUID, _
                                                             objLocalConfig.SemItem_RelationType_An.GUID, _
                                                             objDRV_Selected.Item("EntryID")).Rows
                If objDRC_MailItem.Count > 0 Then
                    objSemItem_MailItem.GUID = objDRC_MailItem(0).Item("GUID_e_Mail")
                    objSemItem_MailItem.Name = objDRC_MailItem(0).Item("Name_e_Mail")
                    objSemItem_MailItem.GUID_Parent = objLocalConfig.SemItem_Type_e_Mail.GUID
                    objSemItem_MailItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objUserControl_PDFViewer = New UserControl_PDFViewer(objSemItem_MailItem, objLocalConfig.Globals)
                    objUserControl_PDFViewer.Dock = Windows.Forms.DockStyle.Fill
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(objUserControl_PDFViewer)
                    objUserControl_PDFViewer.visibilityDescription = False
                Else
                    MsgBox("Es existiert kein Sem-Item zu dieser Mail!", MsgBoxStyle.Information)
                End If
            End If
        Else

        End If
    End Sub


End Class
