Imports MediaViewer_Module
Imports Sem_Manager
Public Class UserControl_Internetquelle
    Private WithEvents objUserControl_PDFViewer As UserControl_PDFViewer
    Private objUserControl_Begriffe As New UserControl_SemItemList

    Private objFrmSemManager As frmSemManager

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_Logentry_Of_Quelle As New DataSet_LiteraturQuelleTableAdapters.proc_Logentry_Of_QuelleTableAdapter

    Private objTransaction_InternetQuelle As clsTransaction_InternetQuelle
    Private objTransaction_PDF As clsTransaction_PDF

    Private boolURL As Boolean
    Private boolURL_Show As Boolean
    Private boolPartner As Boolean
    Private boolPartner_Show As Boolean
    Private boolLogEntry As Boolean
    Private boolLogEntry_Show As Boolean

    Private objConnection As SqlClient.SqlConnection
    Private objConnection_Module As SqlClient.SqlConnection
    Private objLocalConfig As clsLocalConfig
    Private objThread_Data As Threading.Thread

    Private objSemItem_LiteraturQuelle As clsSemItem
    Private objSemItem_InternetQuelle As clsSemItem

    Private objDRC_URL As DataRowCollection
    Private objDRC_Partner As DataRowCollection
    Private objDRC_LogEntry As DataRowCollection

    Public Function delete_InternetQuelle(ByVal SemItem_Quelle As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_InternetQuelle As DataRowCollection

        objDRC_InternetQuelle = funcA_TokenToken.GetData_TokenToken_RightLeft(SemItem_Quelle.GUID, _
                                                                              objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                              objLocalConfig.SemItem_Type_Internet_Quellenangabe.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objDRC_InternetQuelle.Count > 0 Then
            objSemItem_InternetQuelle = New clsSemItem
            objSemItem_InternetQuelle.GUID = objDRC_InternetQuelle(0).Item("GUID_Token_Left")
            objSemItem_InternetQuelle.Name = objDRC_InternetQuelle(0).Item("Name_Token_Left")
            objSemItem_InternetQuelle.GUID_Parent = objLocalConfig.SemItem_Type_Internet_Quellenangabe.GUID
            objSemItem_InternetQuelle.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objTransaction_PDF.del_all_Of_Ref(objSemItem_InternetQuelle)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_InternetQuelle.del_006_InternetQuelle_To_Begriff(objSemItem_InternetQuelle)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_InternetQuelle.del_005_InternetQuelle_To_Partner(objSemItem_InternetQuelle)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_InternetQuelle.del_004_InternetQuelle_To_Logentry(objSemItem_InternetQuelle)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_InternetQuelle.del_003_InternetQuelle_To_Url(objSemItem_InternetQuelle)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_InternetQuelle.del_002_InternetQuelle_To_LiteraturQuelle(objSemItem_InternetQuelle, SemItem_Quelle)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_InternetQuelle.del_001_InternetQuelle(objSemItem_InternetQuelle)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            
            
        End If
        

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        set_DBConnection()
        

        objUserControl_Begriffe.Dock = Windows.Forms.DockStyle.Fill
        Panel_Begriffe.Controls.Add(objUserControl_Begriffe)
    End Sub

    Public Sub initialize(ByVal SemItem_LiteraturQuelle As clsSemItem)

        Dim objSemItem_Result As clsSemItem
        objSemItem_LiteraturQuelle = SemItem_LiteraturQuelle

        

        boolURL = False
        boolURL_Show = False
        boolLogEntry = False
        boolLogEntry_Show = False
        boolPartner = False
        boolPartner_Show = False

        TextBox_Partner.Text = ""
        TextBox_URL.Text = ""
        objUserControl_Begriffe.clear_List()
        objUserControl_Begriffe.Enabled = False
        Button_AddURL.Enabled = False
        Button_AddPartner.Enabled = False
        DateTimePicker_Download.Enabled = False
        DateTimePicker_Download.Enabled = True

        Try
            objThread_Data.Abort()
        Catch ex As Exception

        End Try

        If Not objSemItem_LiteraturQuelle Is Nothing Then
            objSemItem_Result = objTransaction_InternetQuelle.save_001_InternetQuelle(objSemItem_LiteraturQuelle)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_InternetQuelle = objTransaction_InternetQuelle.SemItem_InternetQuelle
                
                configure_TabPages()
            Else
                MsgBox("Beim ermitteln der zugehörigen Internet-Quelle ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
            End If
        Else
            objUserControl_PDFViewer.clear()
        End If
    End Sub

    Private Sub configure_TabPages()
        Select Case TabControl1.SelectedTab.Name
            Case TabPage_Data.Name
                objSemItem_InternetQuelle.GUID_Related = objLocalConfig.SemItem_Type_Begriff.GUID
                objSemItem_InternetQuelle.Direction = objSemItem_InternetQuelle.Direction_LeftRight
                objSemItem_InternetQuelle.GUID_Relation = objLocalConfig.SemItem_RelationType_contains.GUID
                objUserControl_Begriffe.initialize_Complex(objSemItem_InternetQuelle, objLocalConfig.Globals)
                objUserControl_Begriffe.Enabled = True
                objThread_Data = New Threading.Thread(AddressOf get_Data)
                objThread_Data.Start()
                Timer_getData.Start()


            Case TabPage_PDF.Name
                If Not objSemItem_InternetQuelle Is Nothing Then
                    If Not objUserControl_PDFViewer Is Nothing Then
                        objUserControl_PDFViewer.Dispose()
                    End If

                    objUserControl_PDFViewer = Nothing
                    objUserControl_PDFViewer = New UserControl_PDFViewer(objSemItem_InternetQuelle, objLocalConfig.Globals)
                    objUserControl_PDFViewer.visibilityDescription = False
                    objUserControl_PDFViewer.Dock = DockStyle.Fill
                    objUserControl_PDFViewer.Enabled = True

                    TabPage_PDF.Controls.Add(objUserControl_PDFViewer)
                End If

        End Select
    End Sub

    Private Sub set_DBConnection()
        objConnection_Module = New SqlClient.SqlConnection(objLocalConfig.Connection_Plugin.ConnectionString)
        objConnection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        objTransaction_InternetQuelle = New clsTransaction_InternetQuelle(objLocalConfig)
        funcA_TokenToken.Connection = objConnection
        procA_Logentry_Of_Quelle.Connection = objConnection_Module
        objTransaction_PDF = New clsTransaction_PDF(New MediaViewer_Module.clsLocalConfig(New clsGlobals))
    End Sub

    Private Sub get_Data()
        get_Data_URL()
        get_Data_Partner()
        get_Data_Logentry()
    End Sub

    Private Sub get_Data_URL()
        objDRC_URL = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_InternetQuelle.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                   objLocalConfig.SemItem_Type_Url.GUID).Rows

        boolURL = True
    End Sub

    Private Sub get_Data_Partner()
        objDRC_Partner = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_InternetQuelle.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_Ersteller.GUID, _
                                                                       objLocalConfig.SemItem_Type_Partner.GUID).Rows

        boolPartner = True
    End Sub

    Private Sub get_Data_Logentry()
        objDRC_LogEntry = procA_Logentry_Of_Quelle.GetData(objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                           objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                           objLocalConfig.SemItem_type_Logstate.GUID, _
                                                           objLocalConfig.SemItem_RelationType_provides.GUID, _
                                                           objLocalConfig.SemItem_Token_Logstate_Download.GUID, _
                                                           objSemItem_InternetQuelle.GUID).Rows

        boolLogEntry = True
    End Sub

    Private Sub Timer_getData_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_getData.Tick
        Dim boolStop As Boolean

        boolStop = True

        ToolStripProgressBar_Data.Value = 0

        If boolURL = True And boolURL_Show = False Then
            boolStop = False
            If ToolStripProgressBar_Data.Value < ToolStripProgressBar_Data.Maximum Then
                ToolStripProgressBar_Data.Increment(ToolStripProgressBar_Data.Step)
            End If
            If objDRC_URL.Count > 0 Then
                TextBox_URL.Text = objDRC_URL(0).Item("Name_Token_Right")
            End If
            TextBox_URL.Enabled = True
            Button_AddURL.Enabled = True
            boolURL_Show = True
        End If

        If boolPartner = True And boolPartner_Show = False Then
            boolStop = False
            If ToolStripProgressBar_Data.Value < ToolStripProgressBar_Data.Maximum Then
                ToolStripProgressBar_Data.Increment(ToolStripProgressBar_Data.Step)
            End If
            If objDRC_Partner.Count > 0 Then
                TextBox_Partner.Text = objDRC_Partner(0).Item("Name_Token_Right")
            End If

            Button_AddPartner.Enabled = True
            boolPartner_Show = True
        End If

        If boolLogEntry = True And boolLogEntry_Show = False Then
            boolStop = False
            If ToolStripProgressBar_Data.Value < ToolStripProgressBar_Data.Maximum Then
                ToolStripProgressBar_Data.Increment(ToolStripProgressBar_Data.Step)
            End If

            If objDRC_LogEntry.Count > 0 Then
                DateTimePicker_Download.Value = objDRC_LogEntry(0).Item("Datetimestamp")
            End If

            DateTimePicker_Download.Enabled = True
            boolLogEntry_Show = True
        End If

        If boolStop = False Then
            ToolStripProgressBar_Data.Visible = True
        Else
            ToolStripProgressBar_Data.Visible = False
            Timer_getData.Stop()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        configure_TabPages()
    End Sub

    Private Sub Button_AddURL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AddURL.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objSemItem_URL As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Url, objLocalConfig.Globals)
        objFRMSemManager.Applyabale = True
        objFRMSemManager.ShowDialog(Me)
        If objFRMSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFRMSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFRMSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFRMSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Url.GUID Then
                        objSemItem_URL.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_URL.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_URL.GUID_Parent = objLocalConfig.SemItem_Type_Url.GUID
                        objSemItem_URL.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_InternetQuelle.save_003_InternetQuelle_To_Url(objSemItem_URL, objSemItem_InternetQuelle)

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            get_Data_URL()
                            If objDRC_URL.Count > 0 Then
                                TextBox_URL.Text = objDRC_URL(0).Item("Name_Token_Right")
                            Else
                                TextBox_URL.Text = ""
                            End If
                        Else
                            MsgBox("Die Url konnte nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Bitte eine Url auswählen!", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Bitte eine Url auswählen!", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Bitte eine Url auswählen!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Button_AddPartner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AddPartner.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objSemItem_Partner As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Partner, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)
        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Partner.GUID Then
                        objSemItem_Partner.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Partner.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                        objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_InternetQuelle.save_005_InternetQuelle_To_Partner(objSemItem_Partner, objSemItem_InternetQuelle)

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            get_Data_Partner()
                            If objDRC_URL.Count > 0 Then
                                TextBox_Partner.Text = objDRC_Partner(0).Item("Name_Token_Right")
                            Else
                                TextBox_Partner.Text = ""
                            End If
                        Else
                            MsgBox("Der Partner konnte nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Bitte einen Partner auswählen!", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Bitte einen Partner auswählen!", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Bitte einen Partner auswählen!", MsgBoxStyle.Information)
            End If
        End If
    End Sub
End Class
