Imports Sem_Manager
Public Class frmPartnerManager
    Private WithEvents objUserControl_SemItemList As UserControl_SemItemList
    Private WithEvents objUserControl_Address As UserControl_Adress
    Private WithEvents objUserControl_PersonalData As UserControl_PersonalData
    Private WithEvents objUserControl_Availability As UserControl_Availability
    Private objUserControl_ComunicationData As UserControl_ComunicationData
    Private objSemItem_Partner As clsSemItem
    Public Event applied_Partner_FromList(ByVal objDGVSRC_Files As DataGridViewSelectedRowCollection, ByVal RowName_GUID As String)
    Public Event applied_Address(ByVal objSemItem_Address)

    Public Property Applyable() As Boolean
        Get
            Return objLocalConfig.Applyable
        End Get
        Set(ByVal value As Boolean)
            objLocalConfig.Applyable = value
            If Not objUserControl_SemItemList Is Nothing Then
                objUserControl_SemItemList.Applyable = objLocalConfig.Applyable
            End If
        End Set
    End Property
    Private Sub applied_Partner() Handles objUserControl_SemItemList.Applied_Item
        RaiseEvent applied_Partner_FromList(objUserControl_SemItemList.DataGridViewRowCollection_Selected, "GUID_Token_Right")
        DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub selected_Partner() Handles objUserControl_SemItemList.Selection_Changed


        objSemItem_Partner = Nothing
        If objUserControl_SemItemList.DataGridViewRowCollection_Selected.Count = 1 Then
            Dim objDGVR_Selected As DataGridViewRow
            Dim objDRV_Selected As DataRowView

            objDGVR_Selected = objUserControl_SemItemList.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Partner = New clsSemItem
            objSemItem_Partner.GUID = objDRV_Selected.Item("GUID_Token")
            objSemItem_Partner.Name = objDRV_Selected.Item("Name_Token")
            objSemItem_Partner.GUID_Parent = objDRV_Selected.Item("GUID_Type")
            objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        
        End If
        If SplitContainer1.Panel2Collapsed = False Then
            fill_TabPages()
        End If
        
    End Sub

    Private Sub fill_TabPages()

        Select Case TabControl1.SelectedTab.Name
            Case TabPage_Address.Name
                TabPage_Address.Controls.Clear()

                objUserControl_Address = New UserControl_Adress(objSemItem_Partner)
                objUserControl_Address.Dock = DockStyle.Fill
                TabPage_Address.Controls.Add(objUserControl_Address)
            Case TabPage_PersonalData.Name
                TabPage_PersonalData.Controls.Clear()
                objUserControl_PersonalData = New UserControl_PersonalData(objLocalConfig, objSemItem_Partner)
                objUserControl_PersonalData.Dock = DockStyle.Fill
                TabPage_PersonalData.Controls.Add(objUserControl_PersonalData)
            Case TabPage_ComData.Name
                TabPage_ComData.Controls.Clear()
                objUserControl_ComunicationData = New UserControl_ComunicationData(objLocalConfig, objSemItem_Partner)
                objUserControl_ComunicationData.Dock = DockStyle.Fill
                TabPage_ComData.Controls.Add(objUserControl_ComunicationData)
            Case TabPage_Availability.Name
                objUserControl_Availability.initialize(objSemItem_Partner)
        End Select

    End Sub
    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        If objLocalConfig Is Nothing Then
            objLocalConfig = New clsLocalConfig(New clsGlobals)
        End If

        objLocalConfig.Applyable = False
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        objLocalConfig = New clsLocalConfig(Globals)
        objLocalConfig.Applyable = True
        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
        set_ControlAttributes()
        get_Partner()
        objUserControl_Availability = New UserControl_Availability(objLocalConfig)
        objUserControl_Availability.Dock = DockStyle.Fill
        TabPage_Availability.Controls.Add(objUserControl_Availability)

    End Sub

    Private Sub set_DBConnection()

    End Sub

    Private Sub set_ControlAttributes()

        If ToolStripButton_ShowAddress.Checked = True Then
            SplitContainer1.Panel2Collapsed = False
            fill_TabPages()

        Else
            SplitContainer1.Panel2Collapsed = True

        End If
    End Sub

    Private Sub get_Partner()
        objUserControl_SemItemList = New UserControl_SemItemList
        objUserControl_SemItemList.Applyable = objLocalConfig.Applyable
        objUserControl_SemItemList.initialize_Simple(objLocalConfig.SemItem_Type_Partner, objLocalConfig.Globals)
        objUserControl_SemItemList.Applyable = objLocalConfig.Applyable
        objUserControl_SemItemList.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Clear()
        SplitContainer1.Panel1.Controls.Add(objUserControl_SemItemList)
    End Sub

    Private Sub ToolStripButton_ShowAddress_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton_ShowAddress.CheckStateChanged
        set_ControlAttributes()
    End Sub


    Private Sub ToolStripButton_ShowAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ShowAddress.Click

    End Sub

    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Close()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        fill_TabPages()
    End Sub
End Class
