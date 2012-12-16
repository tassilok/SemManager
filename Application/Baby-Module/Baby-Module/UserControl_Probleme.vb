Imports Sem_Manager
Public Class UserControl_Probleme

    Private objLocalConfig As clsLocalConfig

    Private semtblA_ProblemArten As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_ProblemArten As New ds_SemDB.semtbl_TokenDataTable

    Private procA_Probleme As New dsBabyModuleTableAdapters.proc_ProblemeTableAdapter
    Private procT_Probleme As New dsBabyModule.proc_ProblemeDataTable

    Private objSemItem_Partner As clsSemItem

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Private Sub initialize()

        set_DBConnection()
        get_BaseData_Probleme()
    End Sub

    Private Sub get_BaseData_Probleme()
        semtblA_ProblemArten.Fill_Token_TypeChilds(semtblT_ProblemArten, _
                                                   objLocalConfig.SemItem_Type_Problemarten.GUID)
        semtblT_ProblemArten.Rows.Add(objLocalConfig.Globals.LogState_Nothing.GUID, _
                                      objLocalConfig.Globals.LogState_Nothing.Name, _
                                      objLocalConfig.SemItem_Type_Problemarten.GUID)
        ComboBox_Problemarten.DataSource = semtblT_ProblemArten
        ComboBox_Problemarten.DisplayMember = "Name_Token"
        ComboBox_Problemarten.ValueMember = "GUID_Token"
        ComboBox_Problemarten.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID

    End Sub

    Public Sub initialize_Probleme(ByVal SemItem_Partner As clsSemItem)
        objSemItem_Partner = SemItem_Partner
    End Sub

    Private Sub get_Data_Probleme()
        procA_Probleme.Fill(procT_Probleme, _
                            objLocalConfig.SemItem_Attribute_Startdate.GUID, _
                            objLocalConfig.SemItem_Attribute_Ende.GUID, _
                            objLocalConfig.SemItem_Type_Probleme__Baby_.GUID, _
                            objLocalConfig.SemItem_Type_Problemarten.GUID, _
                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                            objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                            objSemItem_Partner.GUID)
    End Sub

    Private Sub set_DBConnection()
        procA_Probleme.Connection = objLocalConfig.Connection_Plugin
        semtblA_ProblemArten.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
