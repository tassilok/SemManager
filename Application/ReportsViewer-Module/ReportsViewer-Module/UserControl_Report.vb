Imports Sem_Manager
Imports ClassLibrary_ShellWork
Imports Filesystem_Management
Imports Security_Module
Imports MediaViewer_Module
Public Class UserControl_Report

    Private frmTokenEdit As frmTokenEdit

    Private Const cint_FilterID_equal As Integer = 1
    Private Const cint_FilterID_different As Integer = 2
    Private Const cint_FilterID_contains As Integer = 3

    Private Const cint_Image As Integer = 0
    Private Const cint_MediaItem As Integer = 1
    Private Const cint_PDF As Integer = 2

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter

    Private objMediaItem_Config As clsMediaItem_Config

    Private objLocalConfig As clsLocalConfig
    Private objShell As clsShellWork
    Private objFileWork As clsFileWork
    Private objBlobConnection As clsBlobConnection

    Private objFrmMediaShow As frmMediaShow

    Private objUserData As clsUserData

    Private objSecurityModuleWork As clsSecurityModuleWork

    Private objDataTable As DataTable
    Private objDataAdp As SqlClient.SqlDataAdapter
    Private objDataSet As DataSet
    Private objSemItem_Report As clsSemItem
    Private objSemItem_Token As New clsSemItem

    Private strView As String
    Private strProcedure As String
    Private strDatabase As String
    Private strServer As String

    Private strConn As String

    Private boolFilterChanged As Boolean

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
        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
        objSecurityModuleWork = New clsSecurityModuleWork(objLocalConfig.Globals, Me)
        
        objMediaItem_Config = New clsMediaItem_Config(objLocalConfig.Globals)
        semtblA_Token.Connection = objLocalConfig.Connection_DB
    End Sub

    Public Sub initialize(ByVal SemItem_Report As clsSemItem)
        objDataTable = New DataTable
        objDataSet = New DataSet
        objSemItem_Report = SemItem_Report
        If objSemItem_Report Is Nothing Then
            objDataTable.Clear()
            BindingSource_Reports.DataSource = Nothing
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
                    Try
                        BindingSource_Reports.DataSource = objDataTable
                    Catch ex As Exception
                        BindingSource_Reports.RemoveFilter()
                        BindingSource_Reports.DataSource = objDataTable
                    End Try

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

                If Not IsDBNull(objDRs_Column(0).Item("Name_Field_Format")) Then
                    objColumn.DefaultCellStyle.Format = objDRs_Column(0).Item("Name_Field_Format")
                End If

                If objDRs_Column(0).Item("GUID_FieldType") = objLocalConfig.SemItem_Token_Field_Type_Zahl.GUID Then
                    objColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
                End If

                Try
                    If objColumn.Displayed = True Then
                        objColumn.DisplayIndex = objDRs_Column(0).Item("OrderID")
                    End If
                Catch ex As Exception

                End Try
            End If


        Next


    End Sub

    Private Sub DataGridView_Reports_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Reports.CellMouseClick
        Dim objDRs_Report() As DataRow
        Dim objDRs_Leaded() As DataRow
        Dim objDRs_Type() As DataRow
        Dim objDR_Report As DataRow
        Dim objSemItem_Ref As clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objGUID_Item As Guid
        Dim objDRC_Token As DataRowCollection

        ToolStripButton_OpenFile.Enabled = False
        ToolStripButton_CopyPath.Enabled = False
        ToolStripButton_DownloadFile.Enabled = False

        ToolStripButton_OpenLink.Enabled = False

        ToolStripButton_DrillDown.Enabled = False

        ToolStripButton_OpenImage.Enabled = False
        ToolStripButton_OpenMedia.Enabled = False
        ToolStripButton_OpenPDF.Enabled = False

        ToolStripButton_DecodePassword.Enabled = False

        If DataGridView_Reports.SelectedCells.Count = 1 Then
            objDRs_Report = objUserData.ReportFields_procT.Select("Name_DBColumn='" & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & "'")
            If objDRs_Report.Count > 0 Then
                objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                objDRs_Type = objUserData.ReportFields_procT.Select("GUID_ReportField='" & objDRs_Report(0).Item("GUID_ReportField_Type").ToString & "'")
                If objDRs_Type.Count > 0 Then
                    

                    Select Case objDRV_Selected.Item(objDRs_Type(0).Item("Name_DBColumn"))
                        Case objLocalConfig.SemItem_Type_File.GUID
                            ToolStripButton_OpenFile.Enabled = True
                            ToolStripButton_CopyPath.Enabled = True
                            ToolStripButton_DownloadFile.Enabled = True
                        Case objLocalConfig.SemItem_Type_Password.GUID
                            ToolStripButton_DecodePassword.Enabled = True

                        Case objLocalConfig.SemItem_Type_Url.GUID
                            ToolStripButton_OpenLink.Enabled = True
                    End Select
                    
                End If


                objDRs_Leaded = objUserData.ReportFields_procT.Select("GUID_ReportField_Leaded='" & objDRs_Report(0).Item("GUID_ReportField").ToString & "'")
                If objDRs_Leaded.Count > 0 Then
                    If Not IsDBNull(objDRV_Selected.Item(objDRs_Leaded(0).Item("Name_DBColumn"))) Then
                        objSemItem_Ref = New clsSemItem
                        objSemItem_Ref.GUID = objDRV_Selected.Item(objDRs_Leaded(0).Item("Name_DBColumn"))
                        objSemItem_Ref.Name = objDRV_Selected.Item(objDRs_Report(0).Item("Name_DBColumn"))

                        If Not IsDBNull(objDRV_Selected.Item(objDRs_Leaded(0).Item("Name_DBColumn"))) Then
                            objGUID_Item = objDRV_Selected.Item(objDRs_Leaded(0).Item("Name_DBColumn"))
                            objDRC_Token = semtblA_Token.GetData_Token_By_GUID(objGUID_Item).Rows
                            If objDRC_Token.Count = 1 Then
                                objSemItem_Token = New clsSemItem
                                objSemItem_Token.GUID = objDRC_Token(0).Item("GUID_Token")
                                objSemItem_Token.Name = objDRC_Token(0).Item("Name_Token")
                                objSemItem_Token.GUID_Parent = objDRC_Token(0).Item("GUID_Type")
                                objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                If objMediaItem_Config.has_Images(objSemItem_Ref) = True Then
                                    ToolStripButton_OpenImage.Enabled = True
                                End If

                                If objMediaItem_Config.has_MediaItems(objSemItem_Ref) = True Then
                                    ToolStripButton_OpenMedia.Enabled = True
                                End If

                                If objMediaItem_Config.has_PDFs(objSemItem_Ref) = True Then
                                    ToolStripButton_OpenPDF.Enabled = True
                                End If
                            End If

                        End If
                    End If
                    
                End If

            End If
        End If
    End Sub

    Private Sub ContextMenuStrip_Reports_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Reports.Opening
        Dim objDRs_Report() As DataRow
        Dim objDR_Report As DataRow
        Dim objDRs_Type() As DataRow
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        FilesToolStripMenuItem.Enabled = True
        CopyNameToolStripMenuItem.Enabled = False
        CopyGUIDToolStripMenuItem.Enabled = False
        DecodePasswordToolStripMenuItem.Enabled = False
        FilterToolStripMenuItem.Enabled = False
        If BindingSource_Reports.Filter = "" Then
            ToolStripTextBox_Filter.Text = ""
            ClearFilterToolStripMenuItem.Enabled = False
        Else
            ClearFilterToolStripMenuItem.Enabled = True
        End If

        FieldToFilterToolStripMenuItem.Enabled = False
        FieldToSortToolStripMenuItem.Enabled = False

        If DataGridView_Reports.SelectedCells.Count = 1 Then
            
            FilterToolStripMenuItem.Enabled = True
            CopyNameToolStripMenuItem.Enabled = True
            objDRs_Report = objUserData.ReportFields_procT.Select("Name_DBColumn='" & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & "'")
            If objDRs_Report.Count > 0 Then
                If Not IsDBNull(objDRs_Report(0).Item("GUID_ReportField_Type")) Then
                    objDRs_Type = objUserData.ReportFields_procT.Select("GUID_ReportField='" & objDRs_Report(0).Item("GUID_ReportField_Type").ToString & "'")
                    If objDRs_Type.Count > 0 Then
                        objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
                        objDRV_Selected = objDGVR_Selected.DataBoundItem

                        Select Case objDRV_Selected.Item(objDRs_Type(0).Item("Name_DBColumn"))
                            Case objLocalConfig.SemItem_Type_File.GUID
                                FilesToolStripMenuItem.Enabled = True
                            Case objLocalConfig.SemItem_Type_Password.GUID
                                DecodePasswordToolStripMenuItem.Enabled = True


                        End Select

                    End If
                End If
            End If
            
            
            FieldToFilterToolStripMenuItem.Enabled = True
            FieldToSortToolStripMenuItem.Enabled = True
            If objDRs_Report.Count > 0 Then
                
                objDRs_Report = objUserData.ReportFields_procT.Select("GUID_ReportField_Leaded='" & objDRs_Report(0).Item("GUID_ReportField").ToString & "'")
                If objDRs_Report.Count > 0 Then
                    If objDRs_Report(0).Item("GUID_FieldType") = objLocalConfig.SemItem_Token_Field_Type_GUID.GUID Then
                        CopyGUIDToolStripMenuItem.Enabled = True
                    End If
                End If

            End If
        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        
    End Sub

    Private Sub open_File()
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
    Private Sub copy_Path()
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

    Private Sub decode_Password()

        If Not objLocalConfig.SemItem_User Is Nothing Then
            Dim objDGVR_Selected As DataGridViewRow
            Dim objDRV_Selected As DataRowView
            Dim objDRs_Report() As DataRow
            Dim objDRs_Type() As DataRow
            Dim objDRC_Token As DataRowCollection
            Dim objGUID_Item As Guid
            Dim strPassword As String

            XEditSemItemToolStripMenuItem.Enabled = False
            If DataGridView_Reports.SelectedCells.Count = 1 Then
                objDRs_Report = objUserData.ReportFields_procT.Select("Name_DBColumn='" & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & "'")
                If objDRs_Report.Count > 0 Then

                    objDRs_Type = objUserData.ReportFields_procT.Select("GUID_ReportField='" & objDRs_Report(0).Item("GUID_ReportField_Type").ToString & "'")
                    objDRs_Report = objUserData.ReportFields_procT.Select("GUID_ReportField_Leaded='" & objDRs_Report(0).Item("GUID_ReportField").ToString & "'")
                    If objDRs_Report.Count > 0 Then

                        If objDRs_Type.Count > 0 Then

                            objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
                            objDRV_Selected = objDGVR_Selected.DataBoundItem

                            If Not IsDBNull(objDRV_Selected.Item(objDRs_Report(0).Item("Name_DBColumn"))) Then

                                objSecurityModuleWork.initialize_User(objLocalConfig.SemItem_User)
                                strPassword = objSecurityModuleWork.decode_Password(objSemItem_Token.Name)
                                If strPassword <> "" Then
                                    Clipboard.SetText(strPassword)
                                    Timer_Password.Start()
                                Else
                                    MsgBox("Das Passwort konnte nicht ermittelt werden!", MsgBoxStyle.Information)
                                End If

                            End If
                        Else
                            MsgBox("Das Feld konnte nicht als Password-Feld identifiziert werden!", MsgBoxStyle.Exclamation)
                        End If

                    End If
                End If
            End If

        End If
    End Sub
    Private Sub download_File()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_Report() As DataRow
        Dim objDRs_Leaded() As DataRow
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem
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

            If objFileWork.is_File_Blob(objSemItem_File) Then
                If FolderBrowserDialog_Save.ShowDialog(Me) = DialogResult.OK Then
                    strPath = FolderBrowserDialog_Save.SelectedPath
                    If IO.Directory.Exists(strPath) Then
                        strPath = objFileWork.merge_paths(strPath, objSemItem_File.Name, "\")
                        If IO.File.Exists(strPath) Then
                            MsgBox("Die Datei existiert bereits!", MsgBoxStyle.Information)
                        Else
                            objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath)

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                If MsgBox("Die Datei wurde gespeichert! Soll sie geöffnet werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    objShell.start_Process(strPath, Nothing, Nothing, False, False)
                                End If
                            Else

                                MsgBox("Die Datei kann nicht geöffnet werden!", MsgBoxStyle.Exclamation)
                            End If
                        End If

                    Else
                        MsgBox("Der Pfad existiert nicht", MsgBoxStyle.Information)
                    End If

                End If


            Else
                MsgBox("Die Datei ist nicht in der Datenbank gespeichert.", MsgBoxStyle.Information)
            End If


            
        End If
    End Sub


    Private Sub CopyPathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyPathToolStripMenuItem.Click
        copy_Path()
    End Sub

    Private Sub CopyGUIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyGUIDToolStripMenuItem.Click
        Dim objDRs_Report() As DataRow
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        
        If DataGridView_Reports.SelectedCells.Count = 1 Then

            objDRs_Report = objUserData.ReportFields_procT.Select("Name_DBColumn='" & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & "'")
            If objDRs_Report.Count > 0 Then
                objDRs_Report = objUserData.ReportFields_procT.Select("GUID_ReportField_Leaded='" & objDRs_Report(0).Item("GUID_ReportField").ToString & "'")
                If objDRs_Report.Count > 0 Then
                    If objDRs_Report(0).Item("GUID_FieldType") = objLocalConfig.SemItem_Token_Field_Type_GUID.GUID Then
                        objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
                        objDRV_Selected = objDGVR_Selected.DataBoundItem

                        If Not IsDBNull(objDRV_Selected.Item(objDRs_Report(0).Item("Name_DBColumn"))) Then
                            Clipboard.SetText(objDRV_Selected.Item(objDRs_Report(0).Item("Name_DBColumn")).ToString)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CopyNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyNameToolStripMenuItem.Click
        Dim objDRs_Report() As DataRow
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        If DataGridView_Reports.SelectedCells.Count = 1 Then
            objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            Clipboard.SetText(objDRV_Selected.Item(DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName))
            
        End If
    End Sub

    Private Sub EditToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.DropDownOpening
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_Report() As DataRow
        Dim objDRC_Token As DataRowCollection
        Dim objGUID_Item As Guid

        objSemItem_Token = Nothing
        XEditSemItemToolStripMenuItem.Enabled = False
        If DataGridView_Reports.SelectedCells.Count = 1 Then
            objDRs_Report = objUserData.ReportFields_procT.Select("Name_DBColumn='" & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & "'")
            If objDRs_Report.Count > 0 Then
                objDRs_Report = objUserData.ReportFields_procT.Select("GUID_ReportField_Leaded='" & objDRs_Report(0).Item("GUID_ReportField").ToString & "'")
                If objDRs_Report.Count > 0 Then
                    If objDRs_Report(0).Item("GUID_FieldType") = objLocalConfig.SemItem_Token_Field_Type_GUID.GUID Then
                        objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
                        objDRV_Selected = objDGVR_Selected.DataBoundItem

                        If Not IsDBNull(objDRV_Selected.Item(objDRs_Report(0).Item("Name_DBColumn"))) Then
                            objGUID_Item = objDRV_Selected.Item(objDRs_Report(0).Item("Name_DBColumn"))
                            objDRC_Token = semtblA_Token.GetData_Token_By_GUID(objGUID_Item).Rows
                            If objDRC_Token.Count = 1 Then
                                objSemItem_Token = New clsSemItem
                                objSemItem_Token.GUID = objDRC_Token(0).Item("GUID_Token")
                                objSemItem_Token.Name = objDRC_Token(0).Item("Name_Token")
                                objSemItem_Token.GUID_Parent = objDRC_Token(0).Item("GUID_Type")
                                objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                XEditSemItemToolStripMenuItem.Enabled = True
                            End If

                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub XEditSemItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XEditSemItemToolStripMenuItem.Click
        frmTokenEdit = New frmTokenEdit(objSemItem_Token, objLocalConfig.Globals)
        frmTokenEdit.ShowDialog(Me)
    End Sub

    Private Sub DecodePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecodePasswordToolStripMenuItem.Click
        decode_Password()

    End Sub

    Private Sub Timer_Password_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Password.Tick
        Timer_Password.Stop()

        Clipboard.Clear()
    End Sub

    Private Sub EqualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EqualToolStripMenuItem.Click
        objLocalConfig.Filter_Type = cint_FilterID_equal
        filter_Grid(objLocalConfig.Filter_Type)
        ToolStripButton_Filter.Checked = True



    End Sub

    Private Sub filter_Grid(ByVal intFilter As Integer)
        Dim objDRs_Report() As DataRow
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim strOperator As String
        Dim boolNull As Boolean

        objLocalConfig.Filter = ""

        Select Case intFilter
            Case cint_FilterID_contains
                strOperator = " LIKE "
            Case cint_FilterID_different
                strOperator = "NOT "
            Case cint_FilterID_equal
                strOperator = "="
        End Select
        If DataGridView_Reports.SelectedCells.Count = 1 Then

            objDRs_Report = objUserData.ReportFields_procT.Select("Name_DBColumn='" & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & "'")
            If objDRs_Report.Count > 0 Then
                If objDRs_Report(0).Item("GUID_FieldType") = objLocalConfig.SemItem_Token_Field_Type_Zahl.GUID Then
                    If IsDBNull(DataGridView_Reports.SelectedCells(0)) Then
                        boolNull = True
                    Else
                        objLocalConfig.Filter = DataGridView_Reports.SelectedCells(0).Value
                    End If

                Else
                    If IsDBNull(DataGridView_Reports.SelectedCells(0)) Then
                        boolNull = ""
                    Else
                        If strOperator = " LIKE " Then
                            If ToolStripTextBox_contains.Text <> "" Then
                                objLocalConfig.Filter = "'%" & ToolStripTextBox_contains.Text & "%'"
                            Else
                                objLocalConfig.Filter = ""
                            End If

                        Else
                            objLocalConfig.Filter = "'" & DataGridView_Reports.SelectedCells(0).Value.ToString & "'"
                        End If

                    End If

                End If
                If objLocalConfig.Filter <> "" Then
                    If boolNull = True Then
                        If strOperator = "NOT " Then
                            objLocalConfig.Filter = strOperator & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & " IS NULL"
                        Else
                            objLocalConfig.Filter = DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & " IS NULL"
                        End If

                    Else
                        If strOperator = "NOT " Then
                            objLocalConfig.Filter = strOperator & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & "=" & objLocalConfig.Filter
                        Else
                            objLocalConfig.Filter = DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & strOperator & objLocalConfig.Filter
                        End If
                    End If
                End If

                BindingSource_Reports.Filter = objLocalConfig.Filter

            End If
        End If
        

        ToolStripTextBox_Filter.Text = BindingSource_Reports.Filter
    End Sub

    Private Sub ClearFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFilterToolStripMenuItem.Click
        BindingSource_Reports.RemoveFilter()
        ToolStripTextBox_Filter.Text = BindingSource_Reports.Filter
    End Sub

    Private Sub DifferentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DifferentToolStripMenuItem.Click
        objLocalConfig.Filter_Type = cint_FilterID_different
        filter_Grid(objLocalConfig.Filter_Type)
        ToolStripButton_Filter.Checked = True
    End Sub

    Private Sub ContainsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContainsToolStripMenuItem.Click
        objLocalConfig.Filter_Type = cint_FilterID_contains
        filter_Grid(objLocalConfig.Filter_Type)
        ToolStripButton_Filter.Checked = True
    End Sub

    Private Sub ToolStripTextBox_contains_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox_contains.KeyDown
        Select Case e.KeyCode
            Case Keys.Return, Keys.Enter
                objLocalConfig.Filter_Type = cint_FilterID_contains
                filter_Grid(objLocalConfig.Filter_Type)
                ToolStripButton_Filter.Checked = True
        End Select
    End Sub



    Private Sub DataGridView_Reports_CellMouseEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Reports.CellMouseEnter

    End Sub

    Private Sub ToolStripButton_OpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_OpenFile.Click
        open_File()
    End Sub

    Private Sub ToolStripButton_DownloadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_DownloadFile.Click
        download_File()
    End Sub

    Private Sub ToolStripButton_CopyPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_CopyPath.Click
        copy_Path()
    End Sub

    Private Sub ToolStripButton_DecodePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_DecodePassword.Click
        decode_Password()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripButton_OpenImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_OpenImage.Click
        open_MediaImagePDF(cint_Image)

    End Sub

    Private Sub open_MediaImagePDF(ByVal intMediaType As Integer)
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_Report() As DataRow
        Dim objDRs_Leaded() As DataRow
        Dim objDRs_Type() As DataRow
        Dim objSemItem_Ref As clsSemItem

        objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem
        objDRs_Report = objUserData.ReportFields_procT.Select("Name_DBColumn='" & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & "'")
        If objDRs_Report.Count > 0 Then
            objDRs_Type = objUserData.ReportFields_procT.Select("GUID_ReportField='" & objDRs_Report(0).Item("GUID_ReportField_Type").ToString & "'")
            objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            If objDRs_Type.Count > 0 Then
                Select Case objDRV_Selected.Item(objDRs_Type(0).Item("Name_DBColumn"))
                    Case objLocalConfig.SemItem_Type_File.GUID
                        ToolStripButton_OpenFile.Enabled = True
                        ToolStripButton_CopyPath.Enabled = True
                        ToolStripButton_DownloadFile.Enabled = True
                    Case objLocalConfig.SemItem_Type_Password.GUID
                        ToolStripButton_DecodePassword.Enabled = True


                End Select
            End If


            objDRs_Leaded = objUserData.ReportFields_procT.Select("GUID_ReportField_Leaded='" & objDRs_Report(0).Item("GUID_ReportField").ToString & "'")
            If objDRs_Leaded.Count > 0 Then
                If objDRs_Leaded(0).Item("GUID_FieldType") = objLocalConfig.SemItem_Token_Field_Type_GUID.GUID Then
                    objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    objSemItem_Ref = New clsSemItem
                    objSemItem_Ref.GUID = objDRV_Selected.Item(objDRs_Leaded(0).Item("Name_DBColumn"))
                    objSemItem_Ref.Name = objDRV_Selected.Item(objDRs_Report(0).Item("Name_DBColumn"))

                    objFrmMediaShow = New frmMediaShow(objLocalConfig, intMediaType, objSemItem_Ref)
                    objFrmMediaShow.ShowDialog(Me)
                End If
            End If
        End If


    End Sub

    Private Sub ToolStripButton_OpenMedia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_OpenMedia.Click
        open_MediaImagePDF(cint_MediaItem)
    End Sub

    Private Sub ToolStripButton_OpenPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_OpenPDF.Click
        open_MediaImagePDF(cint_PDF)

    End Sub

    Private Sub ToolStripButton_OpenLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_OpenLink.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_Report() As DataRow
        Dim objDRs_Leaded() As DataRow
        Dim objDRs_Type() As DataRow
        Dim objSemItem_Ref As clsSemItem

        objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem
        objDRs_Report = objUserData.ReportFields_procT.Select("Name_DBColumn='" & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName & "'")
        If objDRs_Report.Count > 0 Then
            objDRs_Type = objUserData.ReportFields_procT.Select("GUID_ReportField='" & objDRs_Report(0).Item("GUID_ReportField_Type").ToString & "'")
            objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            If objDRs_Type.Count > 0 Then

            End If


            objDRs_Leaded = objUserData.ReportFields_procT.Select("GUID_ReportField_Leaded='" & objDRs_Report(0).Item("GUID_ReportField").ToString & "'")
            If objDRs_Leaded.Count > 0 Then
                If objDRs_Leaded(0).Item("GUID_FieldType") = objLocalConfig.SemItem_Token_Field_Type_GUID.GUID Then
                    objDGVR_Selected = DataGridView_Reports.Rows(DataGridView_Reports.SelectedCells(0).RowIndex)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    objSemItem_Ref = New clsSemItem
                    objSemItem_Ref.GUID = objDRV_Selected.Item(objDRs_Leaded(0).Item("Name_DBColumn"))
                    objSemItem_Ref.Name = objDRV_Selected.Item(objDRs_Report(0).Item("Name_DBColumn"))
                    objSemItem_Ref.GUID_Parent = objDRV_Selected.Item(objDRs_Type(0).Item("Name_DBColumn"))
                    objSemItem_Ref.GUID_Type = objLocalConfig.Globals.LogState_Success.GUID

                    If objShell.start_Process(objSemItem_Ref.Name, Nothing, Nothing, False, False) = False Then
                        MsgBox("Der Link konnte nicht geöffnet werden!", MsgBoxStyle.Exclamation)
                    End If


                End If
            End If
        End If
    End Sub

    Private Sub DataGridView_Reports_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Reports.ColumnHeaderMouseClick
        objLocalConfig.Sort = DataGridView_Reports.SortedColumn.DataPropertyName
        If DataGridView_Reports.SortOrder = SortOrder.Descending Then
            objLocalConfig.Sort = objLocalConfig.Sort & " DESC"
        End If
        ToolStripTextBox_Sort.Text = objLocalConfig.Sort
    End Sub

    Private Sub DataGridView_Reports_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView_Reports.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                get_Data()

        End Select
    End Sub

    Private Sub ToolStripButton_Filter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton_Filter.Click

        If boolFilterChanged = True Then
            objLocalConfig.Filter = ToolStripTextBox_Filter.Text
        End If
        If ToolStripButton_Filter.Checked = True Then
            
            Try
                BindingSource_Reports.Filter = objLocalConfig.Filter
                ToolStripTextBox_Filter.Text = objLocalConfig.Filter
            Catch ex As Exception
                MsgBox(ex.Message)
                ToolStripTextBox_Filter.Text = ""
            End Try
            boolFilterChanged = False
        Else
            BindingSource_Reports.RemoveFilter()
            ToolStripTextBox_Filter.Text = ""
            boolFilterChanged = False
        End If
    End Sub

    Private Sub ToolStripTextBox_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Filter.Click

    End Sub

    Private Sub ToolStripTextBox_Filter_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Filter.DoubleClick

    End Sub

    Private Sub ToolStripTextBox_Filter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox_Filter.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Return

                boolFilterChanged = True
                ToolStripButton_Filter.Checked = True
                objLocalConfig.Filter = ToolStripTextBox_Filter.Text
                Try
                    BindingSource_Reports.Filter = objLocalConfig.Filter
                    ToolStripTextBox_Filter.Text = objLocalConfig.Filter
                Catch ex As Exception
                    MsgBox(ex.Message)
                    ToolStripTextBox_Filter.Text = ""
                End Try


            Case Else

                boolFilterChanged = True

        End Select
        

    End Sub

    Private Sub DataGridView_Reports_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Reports.Sorted


    End Sub


    Private Sub ToolStripTextBox_Sort_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox_Sort.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Return
                objLocalConfig.Sort = ToolStripTextBox_Sort.Text
                Try
                    BindingSource_Reports.Sort = objLocalConfig.Sort
                Catch ex As Exception
                    BindingSource_Reports.Sort = ""
                    ToolStripTextBox_Sort.Text = ""
                End Try
            Case Else

        End Select
    End Sub

    Private Sub FieldToFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldToFilterToolStripMenuItem.Click
        ToolStripTextBox_Filter.Text = ToolStripTextBox_Filter.Text & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName
    End Sub

    Private Sub FieldToSortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldToSortToolStripMenuItem.Click
        ToolStripTextBox_Sort.Text = ToolStripTextBox_Sort.Text & DataGridView_Reports.Columns(DataGridView_Reports.SelectedCells(0).ColumnIndex).DataPropertyName
    End Sub
End Class
