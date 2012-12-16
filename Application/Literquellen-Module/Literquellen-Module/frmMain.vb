Imports Sem_Manager
Public Class frmMain

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private objFRMSemManager As frmSemManager

    Private objSemItem_Quelle As clsSemItem

    Private objLocalConfig As clsLocalConfig
    Private WithEvents objUserControl_LiteraturQuelle As UserControl_LiteraturQuelle
    Private WithEvents objUserControl_Buchquelle As UserControl_Buchquelle
    Private WithEvents objUserControl_InternetQuelle As UserControl_Internetquelle

    Private objTransaction_BuchQuelle As clsTransaction_BuchQuelle
    Private objTransaction_InternetQuelle As clsTransaction_InternetQuelle

    Private Sub add_LiteratuQuelle() Handles objUserControl_LiteraturQuelle.add_LiteraturQuelle
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objDRs_QuellArt() As DataRow

        Dim objSemItem_QuellArt As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Quelle = objUserControl_LiteraturQuelle.addLiteraturQuelle()
        If Not objSemItem_Quelle Is Nothing Then
            If Not objSemItem_Quelle.GUID = objLocalConfig.Globals.LogState_Error.GUID And _
                Not objSemItem_Quelle.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                MsgBox("Wählen Sie bitte den Typen der literarischen Quelle aus!", MsgBoxStyle.Information)
                objFRMSemManager = New frmSemManager(objLocalConfig.SemItem_Type_m_gliche_LiteraturQuellen, objLocalConfig.Globals)
                objFRMSemManager.Applyabale = True
                objFRMSemManager.ShowDialog(Me)
                If objFRMSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                    If objFRMSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                        If objFRMSemManager.SelectedRows_Items.Count = 1 Then
                            objDGVR_Selected = objFRMSemManager.SelectedRows_Items(0)
                            objDRV_Selected = objDGVR_Selected.DataBoundItem

                            If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_m_gliche_LiteraturQuellen.GUID Then
                                objDRs_QuellArt = objLocalConfig.tbl_BaseConfig.Select("GUID_m_gliche_LiteraturQuellen='" & objDRV_Selected.Item("GUID_Token").ToString & "'")
                                If objDRs_QuellArt.Length > 0 Then
                                    objSemItem_QuellArt.GUID = objDRs_QuellArt(0).Item("GUID_Type")
                                    objSemItem_QuellArt.Name = objDRs_QuellArt(0).Item("Name_Type")
                                    objSemItem_QuellArt.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                                    Select Case objSemItem_QuellArt.GUID
                                        Case objLocalConfig.SemItem_Type_Audio_Quelle.GUID

                                        Case objLocalConfig.SemItem_Type_Bild_Quelle.GUID
                                        Case objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID
                                            objSemItem_Result = objTransaction_BuchQuelle.save_001_BuchQuelle(objSemItem_Quelle)
                                        Case objLocalConfig.SemItem_Type_EMail_Quelle.GUID
                                        Case objLocalConfig.SemItem_Type_EMail_Quelle.GUID
                                        Case objLocalConfig.SemItem_Type_Internet_Quellenangabe.GUID
                                            objSemItem_Result = objTransaction_InternetQuelle.save_001_InternetQuelle(objSemItem_Quelle)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_InternetQuelle.save_002_InternetQuelle_To_LiteraturQuelle()
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_InternetQuelle.save_004_InternetQuelle_To_Logentry(Now)
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objUserControl_LiteraturQuelle.refresh_Quellen(objSemItem_Quelle)
                                                    Else

                                                        objSemItem_Result = objTransaction_InternetQuelle.del_002_InternetQuelle_To_LiteraturQuelle
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objTransaction_InternetQuelle.del_001_InternetQuelle()
                                                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                        End If

                                                        MsgBox("Die Internetquelle konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                    End If
                                                Else

                                                    objTransaction_InternetQuelle.del_001_InternetQuelle()
                                                    MsgBox("Die Internetquelle konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                                End If
                                            Else
                                                MsgBox("Die Internetquelle konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                            End If

                                        Case objLocalConfig.SemItem_Type_Video_Quelle.GUID

                                    End Select

                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objUserControl_LiteraturQuelle.fill_LiteraturQuelle()
                                    Else
                                        objUserControl_LiteraturQuelle.delLiteraturQuelle(objSemItem_Quelle)
                                    End If
                                Else
                                    MsgBox("Die Literaturquelle konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                End If
                            End If

                        Else
                            MsgBox("Der Typ wird nicht unterstützt!", MsgBoxStyle.Information)
                        End If

                    Else
                        MsgBox("Bitte einen literarischen Quelltype auswählen!", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Bitte einen literarischen Quelltype auswählen!", MsgBoxStyle.Information)
                End If
            ElseIf objSemItem_Quelle.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Bitte einen literarischen Quelltype auswählen!", MsgBoxStyle.Information)

            End If
        End If
    End Sub

    Private Sub delLiteraturQuelle(ByVal SemItem_LiteraturQuelle As clsSemItem) Handles objUserControl_LiteraturQuelle.del_LiteraturQuelle
        Dim objDRC_QuellArt As DataRowCollection
        Dim objDRs_QuellArt() As DataRow
        Dim objSemItem_Result As clsSemItem

        objSemItem_Quelle = SemItem_LiteraturQuelle

        Select Case objSemItem_Quelle.GUID_Related
            Case objLocalConfig.SemItem_Type_Audio_Quelle.GUID

            Case objLocalConfig.SemItem_Type_Bild_Quelle.GUID

            Case objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID
                objSemItem_Result = objTransaction_BuchQuelle.del_001_BuchQuelle(objSemItem_Quelle)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objUserControl_LiteraturQuelle.delLiteraturQuelle(objSemItem_Quelle)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objUserControl_LiteraturQuelle.refresh_Quellen(objSemItem_Quelle)
                    Else
                        MsgBox("Die Literaturquelle kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Die Literaturquelle kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                End If
            Case objLocalConfig.SemItem_Type_EMail_Quelle.GUID

            Case objLocalConfig.SemItem_Type_Internet_Quellenangabe.GUID
                objSemItem_Result = objUserControl_InternetQuelle.delete_InternetQuelle(objSemItem_Quelle)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objUserControl_LiteraturQuelle.delLiteraturQuelle(objSemItem_Quelle)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objUserControl_LiteraturQuelle.refresh_Quellen()
                    Else
                        MsgBox("Die Internetquelle konnte nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Die Internetquelle konnte nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                End If

            Case objLocalConfig.SemItem_Type_Video_Quelle.GUID

            Case objLocalConfig.SemItem_Type_Zeitungsquelle.GUID

        End Select
    End Sub

    Private Sub LiteraturQuelle_Selected() Handles objUserControl_LiteraturQuelle.select_Quelle
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Quelle As New clsSemItem
        If objUserControl_LiteraturQuelle.DGVR_SelectedRow.Count = 1 Then
            objDRV_Selected = objUserControl_LiteraturQuelle.DGVR_SelectedRow(0).DataBoundItem
            objSemItem_Quelle.GUID = objDRV_Selected.Item("GUID_literarische_Quelle")
            objSemItem_Quelle.Name = objDRV_Selected.Item("Name_literarische_Quelle")
            objSemItem_Quelle.GUID_Parent = objLocalConfig.SemItem_Type_literarische_Quelle.GUID
            objSemItem_Quelle.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Select Case objDRV_Selected.Item("GUID_Type_Quelle")
                Case objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID
                    initialize_BuchQuelle(objSemItem_Quelle)
                Case objLocalConfig.SemItem_Type_Internet_Quellenangabe.GUID
                    initialize_InternetQuelle(objSemItem_Quelle)
            End Select

        Else
            If SplitContainer1.Panel2.Controls.Count > 0 Then
                SplitContainer1.Panel2.Controls.Clear()
            End If
        End If
    End Sub

    Private Sub initialize_BuchQuelle(ByVal SemItem_Quelle As clsSemItem)
        If objUserControl_Buchquelle Is Nothing Then
            SplitContainer1.Panel2.Controls.Clear()
                objUserControl_Buchquelle = New UserControl_Buchquelle(objLocalConfig)
                objUserControl_Buchquelle.Dock = DockStyle.Fill
                objUserControl_Buchquelle.initialize(SemItem_Quelle)


                SplitContainer1.Panel2.Controls.Add(objUserControl_Buchquelle)
            

        Else
            If Not objUserControl_Buchquelle.Parent Is Nothing Then
                If Not objUserControl_Buchquelle.Parent.Name = SplitContainer1.Panel2.Controls(0).Name Then
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(objUserControl_Buchquelle)
                End If
            Else
                SplitContainer1.Panel2.Controls.Clear()
                SplitContainer1.Panel2.Controls.Add(objUserControl_Buchquelle)
            End If


            objUserControl_Buchquelle.initialize(SemItem_Quelle)
        End If
    End Sub

    Private Sub initialize_InternetQuelle(ByVal SemItem_Quelle As clsSemItem)
        If objUserControl_InternetQuelle Is Nothing Then
            SplitContainer1.Panel2.Controls.Clear()

            If Not SemItem_Quelle Is Nothing Then
                objUserControl_InternetQuelle = New UserControl_Internetquelle(objLocalConfig)
                objUserControl_InternetQuelle.Dock = DockStyle.Fill
                objUserControl_InternetQuelle.initialize(SemItem_Quelle)


                SplitContainer1.Panel2.Controls.Add(objUserControl_InternetQuelle)
            End If
            

        Else
            If Not objUserControl_InternetQuelle.Parent Is Nothing Then
                If Not objUserControl_InternetQuelle.Parent.Name = SplitContainer1.Panel2.Controls(0).Name Then
                    SplitContainer1.Panel2.Controls.Clear()
                    SplitContainer1.Panel2.Controls.Add(objUserControl_InternetQuelle)
                End If
            Else
                SplitContainer1.Panel2.Controls.Clear()
                SplitContainer1.Panel2.Controls.Add(objUserControl_InternetQuelle)
            End If

            If Not SemItem_Quelle Is Nothing Then
                objUserControl_InternetQuelle.initialize(SemItem_Quelle)
            End If

        End If
    End Sub



    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Close()
    End Sub

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)

        initialize()
    End Sub

    Public Function get_User() As Boolean
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_User As New clsSemItem

        objFRMSemManager = New frmSemManager(objLocalConfig.SemItem_type_User, objLocalConfig.Globals)
        objFRMSemManager.Applyabale = True
        objFRMSemManager.ShowDialog(Me)

        objLocalConfig.SemItem_User = Nothing

        If objFRMSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFRMSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFRMSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFRMSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_type_User.GUID Then
                        objSemItem_User.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_User.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_User.GUID_Parent = objLocalConfig.SemItem_type_User.GUID
                        objSemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objLocalConfig.SemItem_User = objSemItem_User
                    Else
                        MsgBox("Bitte einen User auswählen!", MsgBoxStyle.Information)
                    End If

                Else
                    MsgBox("Bitte einen User auswählen!", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Bitte einen User auswählen!", MsgBoxStyle.Information)
            End If

        End If

        If Not objLocalConfig.SemItem_User Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub initialize()
        get_User()
        set_DBConnection()
        If Not objLocalConfig.SemItem_User Is Nothing Then
            objUserControl_LiteraturQuelle = New UserControl_LiteraturQuelle(objLocalConfig)
            objUserControl_LiteraturQuelle.Dock = DockStyle.Fill
            SplitContainer1.Panel1.Controls.Add(objUserControl_LiteraturQuelle)
        End If
        
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objLocalConfig.SemItem_User Is Nothing Then
            Application.Exit()
        End If
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)

        objTransaction_BuchQuelle = New clsTransaction_BuchQuelle(objLocalConfig)
        objTransaction_InternetQuelle = New clsTransaction_InternetQuelle(objLocalConfig)
    End Sub
End Class
