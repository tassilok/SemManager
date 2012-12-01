Imports Sem_Manager
Imports Localizing_Manager
Public Class UserControl_Logentries
    Private Const cstr_GUID_Development As String = "c0c82bc2-cdcc-4d8a-95f7-511044e503bc"

    Private semprocA_DBWork_Save_TokenAttribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_DATETIME As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private procA_related_LogEntry_with_Data As New ds_LogentriesTableAdapters.proc_related_LogEntry_with_DataTableAdapter
    Private proc_related_LogEntry_with_Data As New ds_Logentries.proc_related_LogEntry_with_DataDataTable

    Private objFrmSemManager As frmSemManager
    Private objFrmTokenEdit As frmTokenEdit
    Private objDlg_Attribute_VARCHARMAX As dlgAttribute_VarcharMax
    Private objDlg_Attribute_DATETIME As dlgAttribute_Datetime

    Private objLocalize_GUIEntries As clsLocalized_GUIEntries
    Private objSemItem_Development As clsSemItem
    Private objLogWork_Local As clsLogWork_Local

    Private strCol_Name_LogState As String
    Private strCol_DateTimeStamp As String
    Private strCol_Message As String

    Public Sub New(ByVal SemItem_Development As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Development = SemItem_Development

        set_DBConnection()
        configure_GUIEntries()
        If Not objSemItem_Development Is Nothing Then
            fill_Logentries()
        End If

    End Sub

    Private Sub set_DBConnection()
        procA_related_LogEntry_with_Data.Connection = objLocalConfig.Connection_Plugin
        semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_DATETIME.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        objLogWork_Local = New clsLogWork_Local
    End Sub

    Private Sub fill_Logentries()
        proc_related_LogEntry_with_Data.Clear()
        procA_related_LogEntry_with_Data.Fill(proc_related_LogEntry_with_Data, _
                                              objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                              objLocalConfig.SemItem_Attribute_Message.GUID, _
                                              objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                              objLocalConfig.SemItem_Type_LogState.GUID, _
                                              objLocalConfig.SemItem_RelationType_Happened.GUID, _
                                              objLocalConfig.SemItem_RelationType_provides.GUID, _
                                              objSemItem_Development.GUID)

        BindingSource_LogEntries.DataSource = proc_related_LogEntry_with_Data
        DataGridView_Logentries.DataSource = BindingSource_LogEntries
        DataGridView_Logentries.Columns(0).Visible = False
        DataGridView_Logentries.Columns(1).Visible = False
        DataGridView_Logentries.Columns(2).Visible = False
        DataGridView_Logentries.Columns(3).Visible = False
        DataGridView_Logentries.Columns(4).HeaderText = strCol_Name_LogState
        DataGridView_Logentries.Columns(5).Visible = False
        DataGridView_Logentries.Columns(6).Visible = False
        DataGridView_Logentries.Columns(7).HeaderText = strCol_DateTimeStamp
        DataGridView_Logentries.Columns(8).Visible = False
        DataGridView_Logentries.Columns(9).Width = 200
        DataGridView_Logentries.Columns(9).HeaderText = strCol_Message

        ToolStripLabel_ItemCounts.Text = DataGridView_Logentries.RowCount
    End Sub

    Private Sub DataGridView_Logentries_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Logentries.CellMouseDoubleClick
        Dim objDRV_Selected As DataRowView
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Choosen As DataRowView
        Dim objDRC_LogState As DataRowCollection
        Dim strMessage As String
        Dim dateDateTimeStamp As Date

        objDGVR_Selected = DataGridView_Logentries.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem
        If Not e.ColumnIndex = -1 Then
            Select Case DataGridView_Logentries.Columns(e.ColumnIndex).Name
                Case "Message"
                    objDlg_Attribute_VARCHARMAX = New dlgAttribute_VarcharMax(objLocalConfig.SemItem_Attribute_Message.Name, objLocalConfig.Globals, objDRV_Selected.Item("Message"))
                    objDlg_Attribute_VARCHARMAX.ShowDialog(Me)
                    If objDlg_Attribute_VARCHARMAX.DialogResult = DialogResult.OK Then
                        strMessage = objDlg_Attribute_VARCHARMAX.Value
                        If strMessage <> objDRV_Selected.Item("Message") Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_Development.GUID, objLocalConfig.SemItem_Attribute_Message.GUID, objDRV_Selected.Item("GUID_TokenAttribute_Message"), strMessage, 1).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                                fill_Logentries()
                            Else
                                MsgBox("Die Beschreibung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)

                            End If

                        End If
                    End If

                Case "Name_LogState"
                    objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_LogState, objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)
                    If objFrmSemManager.DialogResult = DialogResult.OK Then
                        If objFrmSemManager.Applied_SemItems = False Then
                            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                                If objFrmSemManager.SelectedRows_Items.Count = 1 Then

                                    objDRV_Choosen = objFrmSemManager.SelectedRows_Items(0).DataBoundItem
                                    If objDRV_Choosen.Item("GUID_Type") = objLocalConfig.SemItem_Type_LogState.GUID Then
                                        If objDRV_Selected.Item("GUID_Logstate") <> objDRV_Choosen.Item("GUID_Token") Then
                                            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objDRV_Selected.Item("GUID_Request"), objDRV_Selected.Item("GUID_Logstate"), objLocalConfig.SemItem_RelationType_provides.GUID).Rows
                                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objDRV_Selected.Item("GUID_Request"), objDRV_Choosen.Item("GUID_Token"), objLocalConfig.SemItem_RelationType_provides.GUID, 1).Rows
                                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                    fill_Logentries()
                                                Else
                                                    MsgBox("Der Logeintrag kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                                                End If
                                            Else
                                                MsgBox("Der Logstate kann nicht verändert werden!", MsgBoxStyle.Exclamation)
                                            End If
                                        End If
                                    Else
                                        MsgBox("Bitte einen Logstate auswählen!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    MsgBox("Bitte nur einen Logstate auswählen!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Bitte einen Logstate auswählen!", MsgBoxStyle.Exclamation)
                            End If
                        Else

                            MsgBox("Bitte einen Logstate auswählen!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Case "DateTimeStamp"
                    objDlg_Attribute_DATETIME = New dlgAttribute_Datetime(objLocalConfig.SemItem_Attribute_DateTimeStamp.Name, objLocalConfig.Globals, objDRV_Selected.Item("DateTimeStamp"))
                    objDlg_Attribute_DATETIME.ShowDialog(Me)
                    If objDlg_Attribute_DATETIME.DialogResult = DialogResult.OK Then
                        dateDateTimeStamp = objDlg_Attribute_DATETIME.Value
                        If dateDateTimeStamp <> objDRV_Selected.Item("DateTimeStamp") Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_DATETIME.GetData(objDRV_Selected.Item("GUID_Request"), objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, objDRV_Selected.Item("GUID_TokenAttribute_DateTimestamp"), dateDateTimeStamp, 1).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                                fill_Logentries()
                            Else
                                MsgBox("Beim Ändern des Zeitsempels ist ein Fehler unterlaufen", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    End If

            End Select
        End If

    End Sub

    Private Sub DataGridView_Logentries_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Logentries.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Logentry As New clsSemItem

        objDGVR_Selected = DataGridView_Logentries.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Logentry.GUID = objDRV_Selected.Item("GUID_Request")
        objSemItem_Logentry.Name = objDRV_Selected.Item("Name_Request")
        objSemItem_Logentry.GUID_Parent = objLocalConfig.SemItem_Type_LogEntry.GUID
        objSemItem_Logentry.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        objFrmTokenEdit = New frmTokenEdit(objSemItem_Logentry, objLocalConfig.Globals)
        objFrmTokenEdit.ShowDialog(Me)
        fill_Logentries()
    End Sub

    Private Sub DataGridView_Logentries_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Logentries.SelectionChanged
        Dim intRowID As Integer
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        intRowID = BindingSource_LogEntries.Position
        If Not intRowID = -1 Then
            objDGVR_Selected = DataGridView_Logentries.Rows(intRowID)

            objDRV_Selected = objDGVR_Selected.DataBoundItem
            TextBox_Message.Text = objDRV_Selected.Item("Message")
        Else
            TextBox_Message.Text = ""
        End If

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        objLogWork_Local.log_Entry(objSemItem_Development)

        fill_Logentries()
    End Sub

    Private Sub configure_GUIEntries()
        Dim objSemItem_Development As New clsSemItem
        Dim objDR_GUIEntry As DataRow
        Dim strCaption As String
        Dim strToolTip As String

        objSemItem_Development.GUID = New Guid(cstr_GUID_Development)
        objLocalize_GUIEntries = New clsLocalized_GUIEntries(objSemItem_Development, objLocalConfig.Globals)

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry("Col_Name_LogState")
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                strCol_Name_LogState = strCaption
            End If

            
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry("Col_DateTimeStamp")
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                strCol_DateTimeStamp = strCaption
            End If

        End If


        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry("Col_DateTimeStamp")
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                strCol_DateTimeStamp = strCaption
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry("Col_Message")
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                strCol_Message = strCaption
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripLabel_ItemCountLbl.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ToolStripLabel_ItemCountLbl.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                ToolStripLabel_ItemCountLbl.ToolTipText = strToolTip
            End If


        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
