Imports Sem_Manager
Public Class UserControl_Charts

    Private procA_Mengen_Of_Day_By_Einheit As New dsBabyModuleTableAdapters.proc_Mengen_Of_Day_By_EinheitTableAdapter
    Private objLocalConfig As clsLocalConfig
    Private objSemItem_Partner As clsSemItem


    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        set_DBConnection()

    End Sub

    Public Sub initialize(ByVal SemItem_Partner As clsSemItem)
        objSemItem_Partner = SemItem_Partner

        If Not objSemItem_Partner Is Nothing Then
            procA_Mengen_Of_Day_By_Einheit.Fill(Me.dsBabyModule.Tables.Item("proc_Mengen_Of_Day_By_Einheit"), _
                                 objLocalConfig.SemItem_Type_Trinkmessungen.GUID, _
                                 objLocalConfig.SemItem_Attribute_Gemessen__Zeitpunkt_.GUID, _
                                 objLocalConfig.SemItem_Attribute_Trinkprobleme__Spucken_.GUID, _
                                 objLocalConfig.SemItem_Attribute_Eigeninitiative.GUID, _
                                 objLocalConfig.SemItem_Type_Partner.GUID, _
                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                 objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                 objLocalConfig.SemItem_Type_Trinkbestandteil.GUID, _
                                 objLocalConfig.SemItem_Type_Menge.GUID, _
                                 objLocalConfig.SemItem_Type_Einheit.GUID, _
                                 objLocalConfig.SemItem_RelationType_contains.GUID, _
                                 objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                 objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                 objSemItem_Partner.GUID, _
                                 objLocalConfig.SemItem_Token_Einheit_ml.GUID, _
                                 Nothing)

        Else
            Me.dsBabyModule.Tables.Item("proc_Mengen_Of_Day_By_Einheit").Clear()

        End If
        ReportViewer_Baby.RefreshReport()
    End Sub
    Private Sub set_DBConnection()
        procA_Mengen_Of_Day_By_Einheit.Connection = objLocalConfig.Connection_Plugin
    End Sub



End Class
