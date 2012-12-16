Imports Sem_Manager
Imports OrganisationalTransactions
Public Class frmTrinkbestandteil
    Private objLocalConfig As clsLocalConfig

    Private procA_Trinkbestandteil As New dsBabyModuleTableAdapters.proc_TrinkbestandteilTableAdapter
    Private semtblA_Token_Medikamente As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_Token_Medikamente As New ds_SemDB.semtbl_TokenDataTable
    Private semtblA_Token_Nahrungsmittel As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_Token_Nahrungsmittel As New ds_SemDB.semtbl_TokenDataTable

    Private objTransaction_Trinkbestandteil As clsTransaction_Trinkmessungen

    Private objSemItem_Bestandteil As clsSemItem

    Private WithEvents objUserControl_Menge As UserControl_Menge

    Private objDRC_Trinkbestandteil As DataRowCollection

    Private objSemItem_Trinkmessung As clsSemItem
    Private objSemItem_Medikament As clsSemItem
    Private objSemItem_Nahrungsmittel As clsSemItem
    Private objSemItem_Einheit As New clsSemItem
    Private objSemItem_Menge As clsSemItem
    Private dblMenge As Double

    Private Sub saved_Menge(ByVal objSemItem_Menge As clsSemItem) Handles objUserControl_Menge.saved_Menge
        Me.objSemItem_Menge = objSemItem_Menge
        test_Save()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_Trinkmessung As clsSemItem, Optional ByVal SemItem_Bestandteil As clsSemItem = Nothing)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        objSemItem_Bestandteil = SemItem_Bestandteil
        objSemItem_Trinkmessung = SemItem_Trinkmessung

        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()

        objUserControl_Menge.Dock = DockStyle.Fill
        Panel_Menge.Controls.Add(objUserControl_Menge)
        set_Controls()

    End Sub

    Private Sub fill_Combo_Medikamente()
        ComboBox_Medikament.Enabled = False
        ComboBox_Medikament.Items.Clear()
        semtblA_Token_Medikamente.Fill_Token_TypeChilds(semtblT_Token_Medikamente, _
                                                        objLocalConfig.SemItem_Type_Medikamente.GUID)
        semtblT_Token_Medikamente.Rows.Add(objLocalConfig.Globals.LogState_Nothing.GUID, "", objLocalConfig.SemItem_Type_Medikamente.GUID)
        ComboBox_Medikament.DataSource = semtblT_Token_Medikamente
        ComboBox_Medikament.DisplayMember = "Name_Token"
        ComboBox_Medikament.ValueMember = "GUID_Token"

        If objSemItem_Medikament Is Nothing Then
            ComboBox_Medikament.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID
        Else
            ComboBox_Medikament.SelectedValue = objSemItem_Medikament.GUID
        End If
        ComboBox_Medikament.Enabled = True
    End Sub

    Private Sub fill_Combo_Nahrungsmittel()
        ComboBox_Nahrungsmittel.Enabled = False
        ComboBox_Nahrungsmittel.Items.Clear()
        semtblA_Token_Nahrungsmittel.Fill_Token_TypeChilds(semtblT_Token_Nahrungsmittel, _
                                                        objLocalConfig.SemItem_Type_Nahrung.GUID)
        semtblT_Token_Nahrungsmittel.Rows.Add(objLocalConfig.Globals.LogState_Nothing.GUID, "", objLocalConfig.SemItem_Type_Nahrung.GUID)
        ComboBox_Nahrungsmittel.DataSource = semtblT_Token_Nahrungsmittel
        ComboBox_Nahrungsmittel.DisplayMember = "Name_Token"
        ComboBox_Nahrungsmittel.ValueMember = "GUID_Token"

        If objSemItem_Nahrungsmittel Is Nothing Then
            ComboBox_Nahrungsmittel.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID
        Else
            ComboBox_Nahrungsmittel.SelectedValue = objSemItem_Nahrungsmittel.GUID
        End If
        ComboBox_Nahrungsmittel.Enabled = True
    End Sub

    Private Sub get_Trinkbestandteil()


        objSemItem_Einheit = Nothing
        objSemItem_Medikament = Nothing
        objSemItem_Nahrungsmittel = Nothing
        dblMenge = Nothing

        If Not objSemItem_Bestandteil Is Nothing Then
            objDRC_Trinkbestandteil = procA_Trinkbestandteil.GetData(objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                                     objLocalConfig.SemItem_Type_Trinkbestandteil.GUID, _
                                                                     objLocalConfig.SemItem_Type_Menge.GUID, _
                                                                     objLocalConfig.SemItem_Type_Einheit.GUID, _
                                                                     objLocalConfig.SemItem_Type_Medikamente.GUID, _
                                                                     objLocalConfig.SemItem_Type_Nahrung.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                     objSemItem_Bestandteil.GUID).Rows
            If objDRC_Trinkbestandteil.Count > 0 Then
                dblMenge = objDRC_Trinkbestandteil(0).Item("Menge")
                objSemItem_Einheit = New clsSemItem
                objSemItem_Einheit.GUID = objDRC_Trinkbestandteil(0).Item("GUID_Einheit")
                objSemItem_Einheit.Name = objDRC_Trinkbestandteil(0).Item("Name_Einheit")
                objSemItem_Einheit.GUID_Parent = objLocalConfig.SemItem_Type_Einheit.GUID
                objSemItem_Einheit.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                If Not IsDBNull(objDRC_Trinkbestandteil(0).Item("GUID_Nahrung")) Then
                    objSemItem_Nahrungsmittel = New clsSemItem
                    objSemItem_Nahrungsmittel.GUID = objDRC_Trinkbestandteil(0).Item("GUID_Nahrung")
                    objSemItem_Nahrungsmittel.Name = objDRC_Trinkbestandteil(0).Item("Name_Nahrung")
                    objSemItem_Nahrungsmittel.GUID_Parent = objLocalConfig.SemItem_Type_Nahrung.GUID
                    objSemItem_Nahrungsmittel.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Else
                    If Not IsDBNull(objDRC_Trinkbestandteil(0).Item("GUID_Medikamente")) Then
                        objSemItem_Medikament = New clsSemItem
                        objSemItem_Medikament.GUID = objDRC_Trinkbestandteil(0).Item("GUID_Medikamente")
                        objSemItem_Medikament.Name = objDRC_Trinkbestandteil(0).Item("Name_Medikamente")
                        objSemItem_Medikament.GUID_Parent = objLocalConfig.SemItem_Type_Medikamente.GUID
                        objSemItem_Medikament.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    End If
                End If

            End If

        End If
    End Sub

    Private Sub set_Controls()
        get_Trinkbestandteil()
        fill_Combo_Medikamente()
        fill_Combo_Nahrungsmittel()
        objUserControl_Menge.initialize_Menge(objSemItem_Einheit, dblMenge)
    End Sub

    Private Sub set_DBConnection()
        procA_Trinkbestandteil.Connection = objLocalConfig.Connection_Plugin
        objUserControl_Menge = New UserControl_Menge(objLocalConfig.Globals, Me)
        semtblA_Token_Medikamente.Connection = objLocalConfig.Connection_DB
        semtblA_Token_Nahrungsmittel.Connection = objLocalConfig.Connection_DB
        objTransaction_Trinkbestandteil = New clsTransaction_Trinkmessungen(objLocalConfig)
    End Sub

    Private Sub ComboBox_Medikament_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_Medikament.SelectedIndexChanged
        Dim objDRV_Selected As DataRowView

        If ComboBox_Medikament.Enabled = True Then
            objDRV_Selected = ComboBox_Medikament.SelectedItem
            If Not objDRV_Selected.Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then
                ComboBox_Nahrungsmittel.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID
            End If

            test_Save()
        End If
        
    End Sub


    Private Sub ComboBox_Nahrungsmittel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_Nahrungsmittel.SelectedIndexChanged
        Dim objDRV_Selected As DataRowView

        If ComboBox_Nahrungsmittel.Enabled = True Then
            objDRV_Selected = ComboBox_Nahrungsmittel.SelectedItem
            If Not objDRV_Selected.Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then
                ComboBox_Medikament.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID
            End If

            test_Save()
        End If
        
    End Sub

    Private Sub test_Save()
        Dim boolSaveable As Boolean = True

        get_Trinkbestandteil()

        If ComboBox_Medikament.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID And ComboBox_Nahrungsmittel.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID Then
            boolSaveable = False
        Else
            If objSemItem_Menge Is Nothing Then
                boolSaveable = False
            End If
        End If

        If boolSaveable = True Then
            boolSaveable = False
            If Not objDRC_Trinkbestandteil Is Nothing Then
                If objDRC_Trinkbestandteil.Count > 0 Then
                    If Not ComboBox_Medikament.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID Then
                        If IsDBNull(objDRC_Trinkbestandteil(0).Item("GUID_Medikamente")) Then
                            boolSaveable = True
                        Else
                            If Not objDRC_Trinkbestandteil(0).Item("GUID_Medikamente") = ComboBox_Medikament.SelectedValue Then
                                boolSaveable = True
                            End If
                        End If
                    ElseIf Not ComboBox_Nahrungsmittel.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID Then
                        If IsDBNull(objDRC_Trinkbestandteil(0).Item("GUID_Nahrungsmittel")) Then
                            boolSaveable = True
                        Else
                            If Not objDRC_Trinkbestandteil(0).Item("GUID_Nahrungsmittel") = ComboBox_Nahrungsmittel.SelectedValue Then
                                boolSaveable = True
                            End If
                        End If
                    End If

                    If Not objDRC_Trinkbestandteil(0).Item("GUID_Menge") = objSemItem_Menge.GUID Then
                        boolSaveable = True
                    End If
                Else
                    boolSaveable = True
                End If
            Else
                boolSaveable = True
            End If
            

        End If

        ToolStripButton_Save.Enabled = boolSaveable

    End Sub

    Private Sub ToolStripButton_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Save.Click
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Zusatz As clsSemItem
        Dim objDRV_Zusatz As DataRowView

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If objSemItem_Bestandteil Is Nothing Then
            objSemItem_Bestandteil = New clsSemItem
            objSemItem_Bestandteil.GUID = Guid.NewGuid
            objSemItem_Bestandteil.Name = objSemItem_Trinkmessung.Name
            objSemItem_Bestandteil.GUID_Parent = objLocalConfig.SemItem_Type_Trinkbestandteil.GUID
            objSemItem_Bestandteil.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Result = objTransaction_Trinkbestandteil.save_006_Trinkbestandteil(objSemItem_Bestandteil)
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            If Not ComboBox_Medikament.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objDRV_Zusatz = ComboBox_Medikament.SelectedItem
                objSemItem_Zusatz = New clsSemItem
                objSemItem_Zusatz.GUID = objDRV_Zusatz.Item("GUID_Token")
                objSemItem_Zusatz.Name = objDRV_Zusatz.Item("Name_Token")
                objSemItem_Zusatz.GUID_Parent = objLocalConfig.SemItem_Type_Medikamente.GUID
                objSemItem_Zusatz.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Result = objTransaction_Trinkbestandteil.save_008_Trinkbestandteil_To_Medikament(objSemItem_Zusatz, objSemItem_Bestandteil)

            ElseIf Not ComboBox_Nahrungsmittel.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objDRV_Zusatz = ComboBox_Nahrungsmittel.SelectedItem
                objSemItem_Zusatz = New clsSemItem
                objSemItem_Zusatz.GUID = objDRV_Zusatz.Item("GUID_Token")
                objSemItem_Zusatz.Name = objDRV_Zusatz.Item("Name_Token")
                objSemItem_Zusatz.GUID_Parent = objLocalConfig.SemItem_Type_Nahrung.GUID
                objSemItem_Zusatz.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Result = objTransaction_Trinkbestandteil.save_009_Trinkbestandteil_To_Nahrungsmittel(objSemItem_Zusatz, objSemItem_Bestandteil)

            End If
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_Trinkbestandteil.save_007_Trinkmessung_To_Trinkbestandteil(objSemItem_Trinkmessung, objSemItem_Bestandteil)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_Trinkbestandteil.save_010_Trinkbestandteil_To_Menge(objSemItem_Menge, objSemItem_Bestandteil)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        Me.Close()
                    Else
                        MsgBox("Der Bestandteil konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Der Bestandteil konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Der Bestandteil konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Der Bestandteil konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class