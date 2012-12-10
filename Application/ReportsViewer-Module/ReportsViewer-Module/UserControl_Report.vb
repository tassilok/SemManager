Imports Sem_Manager
Imports ClassLibrary_ShellWork
Imports Filesystem_Management
Public Class UserControl_Report

    Private objLocalConfig As clsLocalConfig
    Private objShell As clsShellWork
    Private objFileWork As clsFileWork

    Private objUserData As clsUserData

    Private objDataTable As DataTable
    Private objDataAdp As SqlClient.SqlDataAdapter
    Private objDataSet As DataSet
    Private objSemItem_Report As clsSemItem

    Private strView As String
    Private strProcedure As String
    Private strDatabase As String
    Private strServer As String

    Private strConn As String

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        objLocalConfig = LocalConfig
        
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objUserData = New clsUserData(objLocalConfig)
        objShell = New clsShellWork()
        objFileWork = New clsFileWork(objLocalConfig.Globals)
    End Sub

    Public Sub initialize(ByVal SemItem_Report As clsSemItem)
        objDataTable = New DataTable
        objDataSet = New DataSet
        objSemItem_Report = SemItem_Report
        If objSemItem_Report Is Nothing Then
            objDataTable.Clear()
        Else
            get_Data()
        End If
    End Sub

    Private Sub get_Data()
        Dim objDRC_Data As DataRowCollection
        Dim objDRC_Data2 As DataRowCollection

        objDataTable.Clear()

        objUserData.initiaize_ReportFields(objSemItem_Report)
        While objUserData.finished_Data_ReportFields = False
        End While
        objUserData.initialize_Report(objSemItem_Report)
        Timer_Data.Start()
        
    End Sub

    Private Sub Timer_Data_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Data.Tick
        If objUserData.finished_Data_Report = True Then
            If objUserData.Report_procT.Rows.Count > 0 Then
                If Not IsDBNull(objUserData.Report_procT.Rows(0).Item("Name_DBItem")) Then
                    strView = objUserData.Report_procT.Rows(0).Item("Name_DBItem")

                    strDatabase = objUserData.Report_procT.Rows(0).Item("Name_Database")
                    strServer = objUserData.Report_procT.Rows(0).Item("Name_Server")
                    strConn = "Data Source=" & strServer & "\SQLEXPRESS;Initial Catalog=" & strDatabase & ";Integrated Security=True"
                    objDataAdp = New SqlClient.SqlDataAdapter("SELECT * FROM [" & strDatabase & "]..[" & strView & "]", strConn)

                    objDataAdp.Fill(objDataSet)
                    objDataTable = objDataSet.Tables(0)
                    BindingSource_Reports.DataSource = objDataTable
                    DataGridView_Reports.DataSource = BindingSource_Reports
                    BindingNavigator_Reports.BindingSource = BindingSource_Reports
                    configure_DataGridView()
                End If
                

                Timer_Data.Stop()
            End If
            End If

    End Sub

    Private Sub configure_DataGridView()
        Dim objColumn As DataGridViewColumn
        Dim objDRs_Column() As DataRow

        For Each objColumn In DataGridView_Reports.Columns
            objDRs_Column = objUserData.ReportFields_procT.Select("Name_DBColumn='" & objColumn.Name & "'")
            If objDRs_Column.Count > 0 Then
                If objDRs_Column(0).Item("invisible") = True Then
                    objColumn.Visible = False
                End If

                objColumn.HeaderText = objDRs_Column(0).Item("Name_ReportField")
            End If


        Next
    End Sub

    Private Sub DataGridView_Reports_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Reports.CellMouseDoubleClick
        Dim objDRs_Column() As DataRow
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        If e.RowIndex > -1 Then
            objDRs_Column = objUserData.ReportFields_procT.Select("Name_DBColumn='" & DataGridView_Reports.Columns(e.ColumnIndex).Name & "'")
            If objDRs_Column.Count > 0 Then
                objDGVR_Selected = DataGridView_Reports.Rows(e.RowIndex)
                objDRV_Selected = objDGVR_Selected.DataBoundItem

                Select Case objDRs_Column(0).Item("GUID_FieldType")
                    Case objLocalConfig.SemItem_Token_Field_Type_Url.GUID
                        If Not IsDBNull(objDRV_Selected.Item(DataGridView_Reports.Columns(e.ColumnIndex).DataPropertyName)) Then
                            objShell.start_Process(objDRV_Selected.Item(DataGridView_Reports.Columns(e.ColumnIndex).DataPropertyName), Nothing, Nothing, False, False)
                        End If


                End Select
            End If
        End If
        
    End Sub

    Private Sub ContextMenuStrip_Reports_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Reports.Opening
        Dim objDRs_Report() As DataRow
        Dim objDR_Report As DataRow

        FilesToolStripMenuItem.Enabled = True

        If DataGridView_Reports.SelectedCells.Count = 1 Then
            objDRs_Report = objUserData.ReportFields_procT.Select("Name_DBColumn='" & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & "'")
            If objDRs_Report.Count > 0 Then
                If objDRs_Report(0).Item("GUID_FieldType") = objLocalConfig.SemItem_Token_Field_Type_File.GUID Then
                    FilesToolStripMenuItem.Enabled = True
                End If
            End If
        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_Report() As DataRow
        Dim objDRs_Leaded() As DataRow
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objDRs_Report = objUserData.ReportFields_procT.Select("Name_DBColumn='" & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & "'")
        If objDRs_Report.Count > 0 Then
            objDRs_Leaded = objUserData.ReportFields_procT.Select("GUID_ReportField_Leaded='" & objDRs_Report(0).Item("GUID_ReportField").ToString & "'")

            objSemItem_File.GUID = objDRV_Selected.Item(objDRs_Leaded(0).Item("Name_DBColumn"))
            objSemItem_File.Name = objDRV_Selected.Item(objDRs_Report(0).Item("Name_DBColumn"))
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objFileWork.open_FileSystemObject(objSemItem_File)
            If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                MsgBox("Die Datei kann nicht geöffnet werden!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub CopyPathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyPathToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_Report() As DataRow
        Dim objDRs_Leaded() As DataRow
        Dim objSemItem_File As New clsSemItem
        Dim strPath As String

        objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objDRs_Report = objUserData.ReportFields_procT.Select("Name_DBColumn='" & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & "'")
        If objDRs_Report.Count > 0 Then
            objDRs_Leaded = objUserData.ReportFields_procT.Select("GUID_ReportField_Leaded='" & objDRs_Report(0).Item("GUID_ReportField").ToString & "'")

            objSemItem_File.GUID = objDRV_Selected.Item(objDRs_Leaded(0).Item("Name_DBColumn"))
            objSemItem_File.Name = objDRV_Selected.Item(objDRs_Report(0).Item("Name_DBColumn"))
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            strPath = objFileWork.get_Path_FileSystemObject(objSemItem_File, True)
            Clipboard.SetDataObject(strPath)
        End If
    End Sub
End Class
