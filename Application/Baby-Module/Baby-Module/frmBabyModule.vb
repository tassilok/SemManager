Imports Sem_Manager
Public Class frmBabyModule

    Private objLocalConfig As clsLocalConfig
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcT_TokenToken As New ds_Token.func_TokenTokenDataTable

    Private objUserControl_Gewichtsmessung As UserControl_Gewichtsmessung
    Private objUserControl_Trinkmessungen As UserControl_Trinken
    Private WithEvents objUserControl_PartnerList As UserControl_SemItemList
    Private objUserControl_Graph As UserControl_Charts

    Private objFilter As New clsFilter
    Private objSemItem_Partner As clsSemItem
    Private objSemItem_Type_Partner As clsSemItem
    Private boolPChange_PartnerList As Boolean
    Private intRowID_Partner_Selected As Integer

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        initialize()
    End Sub

    Private Sub selection_Changed() Handles objUserControl_PartnerList.Selection_Changed
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        If boolPChange_PartnerList = False Then
            If objUserControl_PartnerList.DataGridViewRowCollection_Selected.Count = 1 Then
                objDGVR_Selected = objUserControl_PartnerList.DataGridViewRowCollection_Selected(0)
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                objSemItem_Partner = New clsSemItem
                objSemItem_Partner.GUID = objDRV_Selected.Item("GUID_Token")
                objSemItem_Partner.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                configure_TabPages()
            Else
                objSemItem_Partner = Nothing
            End If

        End If
    End Sub

    Private Sub initialize()
        set_DBConnection()



        objUserControl_Gewichtsmessung = New UserControl_Gewichtsmessung(objLocalConfig)
        objUserControl_Gewichtsmessung.Dock = DockStyle.Fill
        objUserControl_Trinkmessungen = New UserControl_Trinken(objLocalConfig)
        objUserControl_Trinkmessungen.Dock = DockStyle.Fill
        TabPage_Gewicht.Controls.Clear()
        TabPage_Gewicht.Controls.Add(objUserControl_Gewichtsmessung)
        TabPage_Trinken.Controls.Clear()
        TabPage_Trinken.Controls.Add(objUserControl_Trinkmessungen)

        objUserControl_PartnerList = New UserControl_SemItemList()
        objUserControl_PartnerList.Dock = Windows.Forms.DockStyle.Fill
        ToolStripContainer2.ContentPanel.Controls.Clear()
        ToolStripContainer2.ContentPanel.Controls.Add(objUserControl_PartnerList)

        objFilter.GUID_Token_Left = objLocalConfig.SemItem_Type_BaseConfig.GUID
        objFilter.GUID_Type_Right = objLocalConfig.SemItem_Type_Partner.GUID
        objFilter.GUID_RelationType = objLocalConfig.SemItem_RelationType_belonging.GUID
        objFilter.isOtherNull = False
        objFilter.DirectionLeftRight = 2

        objUserControl_Graph = New UserControl_Charts(objLocalConfig)
        objUserControl_Graph.Dock = DockStyle.Fill
        TabPage_Graph.Controls.Add(objUserControl_Graph)

        fill_PartnerList()
    End Sub

    'Private Sub get_BaseData_Partner()
    '    funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_TokenToken, _
    '                                               objLocalConfig.SemItem_Type_BaseConfig.GUID, _
    '                                               objLocalConfig.SemItem_RelationType_belonging.GUID, _
    '                                               objLocalConfig.SemItem_Type_Partner.GUID)
    'End Sub

    Private Sub fill_PartnerList()

        boolPChange_PartnerList = True

        objSemItem_Type_Partner = New clsSemItem
        objSemItem_Type_Partner.Direction = objSemItem_Type_Partner.Direction_RightLeft
        objSemItem_Type_Partner.GUID = objLocalConfig.SemItem_Type_Partner.GUID
        objSemItem_Type_Partner.Name = objLocalConfig.SemItem_Type_Partner.Name
        objSemItem_Type_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

        objUserControl_PartnerList.initialize_Token_Complex(objSemItem_Type_Partner, objLocalConfig.Globals, objFilter)

        boolPChange_PartnerList = False
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
    End Sub


    Private Sub configure_TabPages()

        Dim objDRV_Partner As DataRowView

        Select Case TabControl1.SelectedTab.Name
            Case TabPage_Gewicht.Name
                objUserControl_Gewichtsmessung.initialize_Gewichtsmessung(objSemItem_Partner)
            Case TabPage_Trinken.Name
                objUserControl_Trinkmessungen.initialize_Trinken(objSemItem_Partner)
            Case TabPage_Graph.Name
                objUserControl_Graph.initialize(objSemItem_Partner)
        End Select
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        configure_TabPages()
    End Sub
End Class
