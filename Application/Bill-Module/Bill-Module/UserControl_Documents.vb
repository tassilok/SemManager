Imports Sem_Manager
Imports MediaViewer_Module
Public Class UserControl_Documents
    Private objLocalConfig As clsLocalConfig
    Private objUserControl_PDFViewer As UserControl_PDFViewer

    Private objTransaction_Beleg As clsTransaction_Belege
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter

    Private objFrmSemManager As frmSemManager

    Private objSemItem_Transaction As clsSemItem
    Private objSemItem_Beleg As New clsSemItem
    Private objSemItem_Location As New clsSemItem
    Private objSemItem_BelegsArt_Leer As New clsSemItem
    Private intRowID As Integer

    Private objDlgAttribute_VARCHAR255 As dlgAttribute_Varchar255
    Private funcT_Belege As New ds_Token.func_TokenTokenDataTable
    Private semtblT_Belegsart As New ds_SemDB.semtbl_TokenDataTable
    Private objDRC_Location As DataRowCollection
    Private objDRC_Belegsart As DataRowCollection


    Private boolNew As Boolean
    Private boolMoveFirst As Boolean
    Private boolMovePrevious As Boolean
    Private boolMoveNext As Boolean
    Private boolMoveLast As Boolean
    Private boolDel As Boolean
    Private boolTitle As Boolean
    Private boolBtnLocation As Boolean
    Private boolBtnDelLocation As Boolean
    Private boolType As Boolean
    Private boolUp As Boolean
    Private boolDown As Boolean

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        boolNew = ToolStripButton_New.Enabled
        boolMoveFirst = ToolStripButton_MoveFirst.Enabled
        boolMovePrevious = ToolStripButton_MovePrevious.Enabled
        boolMoveNext = ToolStripButton_MoveNext.Enabled
        boolMoveLast = ToolStripButton_MoveLast.Enabled
        boolDel = ToolStripButton_Del.Enabled
        boolTitle = ToolStripTextBox_Title.Enabled
        boolBtnLocation = ToolStripButton_Location.Enabled
        boolType = ToolStripComboBox_Type.Enabled
        boolUp = ToolStripButton_Up.Enabled
        boolDown = ToolStripButton_Down.Enabled
        boolBtnDelLocation = ToolStripButton_DelLocation.Enabled

        objLocalConfig = LocalConfig
        set_DBConnection()
        intRowID = 0
        objSemItem_BelegsArt_Leer.GUID = Guid.NewGuid
        objSemItem_BelegsArt_Leer.Name = ""
        objSemItem_BelegsArt_Leer.GUID_Parent = objLocalConfig.SemItem_Type_Belegsart.GUID
        objSemItem_BelegsArt_Leer.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        semtblT_Belegsart.Rows.Add(objSemItem_Beleg.GUID, _
                            objSemItem_BelegsArt_Leer.Name, _
                            objSemItem_BelegsArt_Leer.GUID_Parent)
        ToolStripComboBox_Type.ComboBox.DataSource = semtblT_Belegsart
        ToolStripComboBox_Type.ComboBox.ValueMember = "GUID_Token"
        ToolStripComboBox_Type.ComboBox.DisplayMember = "Name_Token"

        ToolStripComboBox_Type.ComboBox.SelectedValue = objSemItem_Beleg.GUID
    End Sub

    Private Sub clear_Controls()
        ToolStripButton_New.Enabled = boolNew
        ToolStripButton_MoveFirst.Enabled = boolMoveFirst
        ToolStripButton_MovePrevious.Enabled = boolMovePrevious
        ToolStripButton_MoveNext.Enabled = boolMoveNext
        ToolStripButton_MoveLast.Enabled = boolMoveLast
        ToolStripButton_Del.Enabled = boolDel
        ToolStripButton_Up.Enabled = boolUp
        ToolStripButton_Down.Enabled = boolUp
        ToolStripTextBox_Title.ReadOnly = boolTitle
        ToolStripTextBox_Title.Text = ""
        ToolStripTextBox_Location.Text = ""
        ToolStripButton_Location.Enabled = boolBtnLocation
        ToolStripButton_DelLocation.Enabled = boolBtnDelLocation
        ToolStripComboBox_Type.Enabled = boolType


        ToolStripContainer1.ContentPanel.Controls.Clear()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

        semtblA_Token.Fill_Token_TypeChilds(semtblT_Belegsart, _
                                            objLocalConfig.SemItem_Type_Belegsart.GUID)
 
        objTransaction_Beleg = New clsTransaction_Belege(objLocalConfig)
    End Sub


    Private Sub get_Data_Belege()
        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_Belege, _
                                                   objSemItem_Transaction.GUID, _
                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                   objLocalConfig.SemItem_Type_Beleg.GUID)



    End Sub

    Private Sub get_Data_Location()
        objDRC_Location = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Beleg.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                                                        objLocalConfig.SemItem_Type_Container__physical_.GUID).Rows
        If objDRC_Location.Count > 0 Then
            objSemItem_Location = New clsSemItem
            objSemItem_Location.GUID = objDRC_Location(0).Item("GUID_Token_Right")
            objSemItem_Location.Name = objDRC_Location(0).Item("Name_Token_Right")
            objSemItem_Location.GUID_Parent = objLocalConfig.SemItem_Type_Container__physical_.GUID
            objSemItem_Location.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objDRC_Location = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Location.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                            objLocalConfig.SemItem_Type_Container__physical_.GUID).Rows
            If objDRC_Location.Count > 0 Then
                objSemItem_Location.Name = objDRC_Location(0).Item("Name_Token_Left") & "\" & objSemItem_Location.Name
            End If
        Else
            objSemItem_Location = Nothing
        End If

    End Sub

    Private Sub get_Data_Belegsart()
        objDRC_Belegsart = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Beleg.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                         objLocalConfig.SemItem_Type_Belegsart.GUID).Rows
    End Sub

    Private Sub configure_Navigation()
        Dim objDR_Beleg As DataRow
        Dim objSemItem_Belegsart As New clsSemItem
        clear_Controls()

        ToolStripButton_New.Enabled = True

        If funcT_Belege.Rows.Count > intRowID + 1 Then
            ToolStripButton_Up.Enabled = True
            ToolStripButton_MoveNext.Enabled = True
            ToolStripButton_MoveLast.Enabled = True
        End If

        If intRowID > 0 Then
            ToolStripButton_Down.Enabled = True
            ToolStripButton_MovePrevious.Enabled = True
            ToolStripButton_MoveFirst.Enabled = True
        End If

        If funcT_Belege.Rows.Count > 0 Then

            ToolStripButton_Del.Enabled = True
            ToolStripButton_Location.Enabled = True

            objSemItem_Beleg = New clsSemItem
            objDR_Beleg = funcT_Belege.Rows(intRowID)
            objSemItem_Beleg.GUID = objDR_Beleg.Item("GUID_Token_Right")
            objSemItem_Beleg.Name = objDR_Beleg.Item("Name_Token_Right")
            objSemItem_Beleg.GUID_Parent = objLocalConfig.SemItem_Type_Beleg.GUID
            objSemItem_Beleg.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            ToolStripTextBox_Title.Text = objSemItem_Beleg.Name
            ToolStripTextBox_Title.ReadOnly = False
            get_Data_Location()
            If Not objSemItem_Location Is Nothing Then
                ToolStripTextBox_Location.Text = objSemItem_Location.Name
                ToolStripButton_DelLocation.Enabled = True
            End If
            get_Data_Belegsart()
            If objDRC_Belegsart.Count > 0 Then
                ToolStripComboBox_Type.ComboBox.SelectedValue = objDRC_Belegsart(0).Item("GUID_Token_Right")
            End If
            ToolStripComboBox_Type.Enabled = True
            objUserControl_PDFViewer = New UserControl_PDFViewer(objSemItem_Beleg, objLocalConfig.SemItems_Token_Languages)
            objUserControl_PDFViewer.Dock = DockStyle.Fill
            ToolStripContainer1.ContentPanel.Controls.Add(objUserControl_PDFViewer)

        End If
    End Sub
    Public Sub initialize_Belege(ByVal SemItem_Transaction As clsSemItem)


        objSemItem_Transaction = SemItem_Transaction

        If Not objSemItem_Transaction Is Nothing Then

            get_Data_Belege()

        End If

        configure_Navigation()
    End Sub

    Private Sub ToolStripButton_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_New.Click
        Dim objSemItem_NewBeleg As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        If Not objSemItem_Transaction Is Nothing Then
            objDlgAttribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Type_Beleg.Name, objLocalConfig.Globals, objSemItem_Transaction.Name)
            objDlgAttribute_VARCHAR255.ShowDialog(Me)
            If objDlgAttribute_VARCHAR255.DialogResult = vbOK Then
                objSemItem_NewBeleg.GUID = Guid.NewGuid
                objSemItem_NewBeleg.Name = objDlgAttribute_VARCHAR255.Value1
                objSemItem_NewBeleg.GUID_Parent = objLocalConfig.SemItem_Type_Beleg.GUID
                objSemItem_NewBeleg.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_Beleg.save_001_Beleg(objSemItem_NewBeleg)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_Beleg.save_002_Transaction_To_Beleg(objSemItem_Transaction, objSemItem_NewBeleg)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        get_Data_Belege()
                        configure_Navigation()
                    Else
                        MsgBox("Der Beleg kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        objTransaction_Beleg.del_001_Beleg(objSemItem_NewBeleg)
                    End If
                Else
                    MsgBox("Der Beleg kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)

                End If
            End If
        Else
            ToolStripButton_New.Enabled = False
        End If
    End Sub

    Private Sub ToolStripComboBox_Type_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_Type.Click

    End Sub

    Private Sub ToolStripComboBox_Type_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_Type.SelectedIndexChanged

        If ToolStripComboBox_Type.Enabled = True Then
            Dim objDRV_Belegstype As DataRowView
            Dim objDR_Belegstype As DataRow
            Dim objSemItem_Result As clsSemItem
            Dim objSemItem_BelegsArt As clsSemItem
            get_Data_Belegsart()
            objDRV_Belegstype = ToolStripComboBox_Type.SelectedItem
            If objDRV_Belegstype.Item("GUID_Type") = objSemItem_BelegsArt_Leer.GUID Then
                If objDRC_Belegsart.Count > 0 Then
                    objDR_Belegstype = objDRC_Belegsart(0)
                    objSemItem_BelegsArt = New clsSemItem
                    objSemItem_BelegsArt.GUID = objDR_Belegstype.Item("GUID_Token_Right")
                    objSemItem_BelegsArt.Name = objDR_Belegstype.Item("Name_Token_Right")
                    objSemItem_BelegsArt.GUID_Parent = objLocalConfig.SemItem_Type_Belegsart.GUID
                    objSemItem_BelegsArt.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Result = objTransaction_Beleg.del_003_Beleg_To_Belegsart(objSemItem_Beleg, _
                                                                                        objSemItem_BelegsArt)

                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        ToolStripComboBox_Type.ComboBox.SelectedValue = objSemItem_BelegsArt.GUID

                    End If
                End If
            Else
                objSemItem_BelegsArt = New clsSemItem
                objSemItem_BelegsArt.GUID = objDRV_Belegstype.Item("GUID_Token")
                objSemItem_BelegsArt.Name = objDRV_Belegstype.Item("Name_Token")
                objSemItem_BelegsArt.GUID_Parent = objDRV_Belegstype.Item("GUID_Type")
                objSemItem_BelegsArt.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_Beleg.save_003_Beleg_To_Belegsart(objSemItem_Beleg, _
                                                                                     objSemItem_BelegsArt)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    ToolStripComboBox_Type.ComboBox.SelectedValue = objDRC_Belegsart(0).Item("GUID_Token_Right")
                End If
            End If
        End If
        


    End Sub

    Private Sub ToolStripButton_Location_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Location.Click

        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Container As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Container__physical_, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)
        If objFrmSemManager.DialogResult = vbOK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Container__physical_.GUID Then
                        objSemItem_Container = New clsSemItem
                        objSemItem_Container.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Container.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Container.GUID_Parent = objLocalConfig.SemItem_Type_Container__physical_.GUID
                        objSemItem_Container.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        objSemItem_Result = objTransaction_Beleg.save_004_Beleg_To_Container(objSemItem_Container, objSemItem_Beleg)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            get_Data_Location()
                            ToolStripTextBox_Location.Text = objSemItem_Location.Name
                            ToolStripButton_DelLocation.Enabled = True
                        Else
                            MsgBox("Die Location konnte nicht gesetzt werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Bitte nur einen Container auswählen!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Bitte nur einen Container auswählen!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte wählen Sie einen Container aus!", MsgBoxStyle.Exclamation)

            End If
        End If
    End Sub

    Private Sub ToolStripButton_DelLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_DelLocation.Click
        Dim objSemItem_Result As clsSemItem



        objSemItem_Result = objTransaction_Beleg.del_004_Beleg_To_Container(objSemItem_Beleg, objSemItem_Location)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            ToolStripTextBox_Location.Clear()
            ToolStripButton_DelLocation.Enabled = False
        Else
            MsgBox("Die Location konnte nicht gelöscht werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ToolStripTextBox_Title_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Title.TextChanged
        Timer_Title.Stop()
        If ToolStripTextBox_Title.ReadOnly = False Then
            Timer_Title.Start()
        End If
    End Sub

    Private Sub Timer_Title_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Title.Tick
        Timer_Title.Stop()
        Dim strName As String
        Dim objSemItem_Result As clsSemItem

        strName = objSemItem_Beleg.Name

        objSemItem_Beleg.Name = ToolStripTextBox_Title.Text

        objSemItem_Result = objTransaction_Beleg.save_001_Beleg(objSemItem_Beleg)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Der Beleg konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
            get_Data_Belege()
            If funcT_Belege.Rows.Count > intRowID Then
                objSemItem_Beleg.GUID = funcT_Belege.Rows(intRowID).Item("GUID_Token_Right")
                objSemItem_Beleg.Name = funcT_Belege.Rows(intRowID).Item("Name_Token_Right")

                ToolStripTextBox_Title.ReadOnly = True
                ToolStripTextBox_Title.Text = objSemItem_Beleg.Name
                ToolStripTextBox_Title.ReadOnly = False
            End If
        End If

    End Sub
End Class
