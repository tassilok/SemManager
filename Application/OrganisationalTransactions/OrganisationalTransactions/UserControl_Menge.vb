Imports Sem_Manager
Public Class UserControl_Menge
    Private objLocalConfig As clsLocalConfig

    Private objTransaction_Menge As clsTransaction_Menge

    Private semtblA_Token_Einheit As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_Token_Einheit As New ds_SemDB.semtbl_TokenDataTable

    Private objFrm_Parent As Windows.Forms.IWin32Window
    Private procA_Menge_By_Val_Einheit As New ds_MengeTableAdapters.proc_Menge_By_Val_EinheitTableAdapter

    Private objDlg_Attribute_Real As dlgAttribute_Real
    Private objDRC_Menge As DataRowCollection

    Private objSemItem_Menge As clsSemItem
    Private objSemItem_Einheit As clsSemItem
    Private dblMenge As Double

    Public Event saved_Menge(ByVal objSemItem_Menge As clsSemItem)

    Public ReadOnly Property Menge As Double
        Get
            Return dblMenge
        End Get
    End Property

    Public ReadOnly Property SemItem_Einheit As clsSemItem
        Get
            Return objSemItem_Einheit
        End Get
    End Property
    Public Sub initialize_Menge(Optional ByVal SemItem_Einheit As clsSemItem = Nothing, Optional ByVal dblMenge As Double = Nothing)
        objSemItem_Einheit = SemItem_Einheit
        Me.dblMenge = dblMenge

        initialize()
    End Sub
    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal objFrm As Windows.Forms.IWin32Window)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        objFrm_Parent = objFrm
        
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals, ByVal objFrm As Windows.Forms.IWin32Window)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        objFrm_Parent = objFrm
        
        initialize()
    End Sub

    Public Sub clear_Menge()
        ComboBox_Einheit.Enabled = False
        ComboBox_Einheit.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID
        ComboBox_Einheit.Enabled = True

        TextBox_Menge.ReadOnly = True
        TextBox_Menge.Clear()
        TextBox_Menge.ReadOnly = False

        objSemItem_Einheit = Nothing
        objSemItem_Menge = Nothing
    End Sub

    Private Sub initialize()

        set_DBConnection()



        semtblA_Token_Einheit.Fill_Token_TypeChilds(semtblT_Token_Einheit, _
                                                    objLocalConfig.SemItem_Type_Einheit.GUID)
        semtblT_Token_Einheit.Rows.Add(objLocalConfig.Globals.LogState_Nothing.GUID, "", objLocalConfig.SemItem_Type_Einheit.GUID)
        ComboBox_Einheit.DataSource = semtblT_Token_Einheit
        ComboBox_Einheit.ValueMember = "GUID_Token"
        ComboBox_Einheit.DisplayMember = "Name_Token"
        ComboBox_Einheit.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID

        configure_Controls()
    End Sub

    Private Sub configure_Controls()
        If Not objSemItem_Einheit Is Nothing Then
            ComboBox_Einheit.SelectedValue = objSemItem_Einheit.GUID
        End If
        If Not dblMenge = Nothing Then
            TextBox_Menge.Text = dblMenge
        End If
    End Sub

    Private Sub set_DBConnection()
        semtblA_Token_Einheit.Connection = objLocalConfig.Connection_DB
        procA_Menge_By_Val_Einheit.Connection = objLocalConfig.Connection_Plugin
        objTransaction_Menge = New clsTransaction_Menge(objLocalConfig.Globals)
    End Sub

    Private Sub TextBox_Menge_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Menge.DoubleClick
        Dim dblMenge As Double
        If TextBox_Menge.ReadOnly = False Then
            If Double.TryParse(TextBox_Menge.Text, dblMenge) = False Then
                dblMenge = 0
            End If
            objDlg_Attribute_Real = New dlgAttribute_Real("new", objLocalConfig.Globals, dblMenge)
            objDlg_Attribute_Real.ShowDialog(objFrm_Parent)
            If objDlg_Attribute_Real.DialogResult = Windows.Forms.DialogResult.OK Then
                TextBox_Menge.Text = objDlg_Attribute_Real.Value
            End If

        End If
    End Sub

    Private Sub save_Menge()
        Dim dblMenge As Double
        Dim objDR_Einheit As DataRowView
        Dim objSemItem_Einheit As clsSemItem
        Dim objSemItem_Result As clsSemItem

        If Double.TryParse(TextBox_Menge.Text, dblMenge) = True Then
            If Not ComboBox_Einheit.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objDR_Einheit = ComboBox_Einheit.SelectedItem
                objSemItem_Einheit = New clsSemItem
                objSemItem_Einheit.GUID = objDR_Einheit.Item("GUID_Token")
                objSemItem_Einheit.Name = objDR_Einheit.Item("Name_Token")
                objSemItem_Einheit.GUID_Parent = objLocalConfig.SemItem_Type_Einheit.GUID
                objSemItem_Einheit.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_Menge.save_001_Menge(dblMenge, objSemItem_Einheit)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_Menge.save_002_Menge__Menge
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Menge.save_004_Menge_To_Einheit
                            If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                MsgBox("Die Menge konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                objSemItem_Result = objTransaction_Menge.del_002_Menge__Menge
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objTransaction_Menge.del_001_Menge()
                                End If
                                RaiseEvent saved_Menge(Nothing)
                            Else
                                RaiseEvent saved_Menge(objTransaction_Menge.SemItem_Menge)
                            End If
                        Else
                            MsgBox("Die Menge konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            objTransaction_Menge.del_001_Menge()
                            RaiseEvent saved_Menge(Nothing)
                        End If
                    Else
                        RaiseEvent saved_Menge(objTransaction_Menge.SemItem_Menge)
                    End If
                    
                Else
                    MsgBox("Die Menge konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    RaiseEvent saved_Menge(Nothing)
                End If
            End If
        End If

    End Sub


    Private Sub TextBox_Menge_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Menge.TextChanged
        Timer_Menge.Stop()
        If TextBox_Menge.ReadOnly = False Then
            Timer_Menge.Start()
        End If
    End Sub

    Private Sub Timer_Menge_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Menge.Tick
        Timer_Menge.Stop()
        save_Menge()
    End Sub

    Private Sub ComboBox_Einheit_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_Einheit.SelectedIndexChanged
        If ComboBox_Einheit.Enabled = True Then
            save_Menge()
        End If
    End Sub
End Class
