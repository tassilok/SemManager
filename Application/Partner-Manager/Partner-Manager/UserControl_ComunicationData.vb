Imports Sem_Manager
Public Class UserControl_ComunicationData

    Private objSemItem_Partner As clsSemItem

    Private objUserControl_Tel As UserControl_SemItemList
    Private objUserControl_Fax As UserControl_SemItemList
    Private objUserControl_Eamil As UserControl_SemItemList
    Private objUserControl_Url As UserControl_SemItemList
    Private objUserControl_Webservice As UserControl_SemItemList


    Private objSemItem_ComunicationData As clsSemItem
    Private objSemItem_Com_Tel As clsSemItem
    Private objSemItem_Com_Fax As clsSemItem
    Private objSemItem_Com_Email As clsSemItem
    Private objSemItem_Com_Url As clsSemItem
    Private objSemItem_Com_WebService As clsSemItem

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private strTabPage_Tel As String
    Private strTabPage_Web As String

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_Partner As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        objSemItem_Partner = SemItem_Partner
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals, ByVal SemItem_Partner As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        objSemItem_Partner = SemItem_Partner
        initialize()
    End Sub

    Private Sub initialize()
        Dim strTabName_Tel As String
        Dim strTabName_Web As String

        strTabPage_Tel = TabPage_Tel.Text
        strTabPage_Web = TabPage_Web.Text

        objUserControl_Tel = New UserControl_SemItemList
        objUserControl_Fax = New UserControl_SemItemList
        objUserControl_Eamil = New UserControl_SemItemList
        objUserControl_Url = New UserControl_SemItemList
        objUserControl_Webservice = New UserControl_SemItemList

        set_DBConnection()


        clear_Controls()

        If Not objSemItem_Partner Is Nothing Then
            get_BaseData_ComunicationData()
            If Not objSemItem_ComunicationData Is Nothing Then
                objSemItem_Com_Tel = New clsSemItem
                objSemItem_Com_Tel.GUID = objSemItem_ComunicationData.GUID
                objSemItem_Com_Tel.Name = objSemItem_ComunicationData.Name
                objSemItem_Com_Tel.GUID_Parent = objSemItem_ComunicationData.GUID_Parent
                objSemItem_Com_Tel.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Com_Tel.GUID_Related = objLocalConfig.SemItem_Type_Telefonnummer.GUID
                objSemItem_Com_Tel.GUID_Relation = objLocalConfig.SemItem_RelationType_Tel.GUID
                objSemItem_Com_Tel.Direction = objSemItem_Com_Tel.Direction_LeftRight

                objSemItem_Com_Fax = New clsSemItem
                objSemItem_Com_Fax.GUID = objSemItem_ComunicationData.GUID
                objSemItem_Com_Fax.Name = objSemItem_ComunicationData.Name
                objSemItem_Com_Fax.GUID_Parent = objSemItem_ComunicationData.GUID_Parent
                objSemItem_Com_Fax.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Com_Fax.GUID_Related = objLocalConfig.SemItem_Type_Telefonnummer.GUID
                objSemItem_Com_Fax.GUID_Relation = objLocalConfig.SemItem_RelationType_Fax.GUID
                objSemItem_Com_Fax.Direction = objSemItem_Com_Tel.Direction_LeftRight

                objSemItem_Com_Email = New clsSemItem
                objSemItem_Com_Email.GUID = objSemItem_ComunicationData.GUID
                objSemItem_Com_Email.Name = objSemItem_ComunicationData.Name
                objSemItem_Com_Email.GUID_Parent = objSemItem_ComunicationData.GUID_Parent
                objSemItem_Com_Email.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Com_Email.GUID_Related = objLocalConfig.SemItem_Type_eMail_Address.GUID
                objSemItem_Com_Email.GUID_Relation = objLocalConfig.SemItem_RelationType_contains.GUID
                objSemItem_Com_Email.Direction = objSemItem_Com_Tel.Direction_LeftRight

                objSemItem_Com_Url = New clsSemItem
                objSemItem_Com_Url.GUID = objSemItem_ComunicationData.GUID
                objSemItem_Com_Url.Name = objSemItem_ComunicationData.Name
                objSemItem_Com_Url.GUID_Parent = objSemItem_ComunicationData.GUID_Parent
                objSemItem_Com_Url.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Com_Url.GUID_Related = objLocalConfig.SemItem_Type_Url.GUID
                objSemItem_Com_Url.GUID_Relation = objLocalConfig.SemItem_RelationType_contains.GUID
                objSemItem_Com_Url.Direction = objSemItem_Com_Tel.Direction_LeftRight

                objSemItem_Com_WebService = New clsSemItem
                objSemItem_Com_WebService.GUID = objSemItem_ComunicationData.GUID
                objSemItem_Com_WebService.Name = objSemItem_ComunicationData.Name
                objSemItem_Com_WebService.GUID_Parent = objSemItem_ComunicationData.GUID_Parent
                objSemItem_Com_WebService.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Com_WebService.GUID_Related = objLocalConfig.SemItem_Type_Web_Service.GUID
                objSemItem_Com_WebService.GUID_Relation = objLocalConfig.SemItem_RelationType_contains.GUID
                objSemItem_Com_WebService.Direction = objSemItem_Com_Tel.Direction_LeftRight

                objUserControl_Tel.initialize_Complex(objSemItem_Com_Tel, objLocalConfig.Globals)
                objUserControl_Tel.Dock = DockStyle.Fill
                Panel_Telephone.Controls.Add(objUserControl_Tel)
                strTabName_Tel = strTabPage_Tel.Replace("/", " (" & objUserControl_Tel.RowCounts.ToString & ")/")

                objUserControl_Fax.initialize_Complex(objSemItem_Com_Fax, objLocalConfig.Globals)
                objUserControl_Fax.Dock = DockStyle.Fill
                Panel_Fax.Controls.Add(objUserControl_Fax)
                strTabName_Tel = strTabName_Tel & " (" & objUserControl_Fax.RowCounts.ToString & ")"

                objUserControl_Eamil.initialize_Complex(objSemItem_Com_Email, objLocalConfig.Globals)
                objUserControl_Eamil.Dock = DockStyle.Fill
                Panel_Email.Controls.Add(objUserControl_Eamil)

                objUserControl_Url.initialize_Complex(objSemItem_Com_Url, objLocalConfig.Globals)
                objUserControl_Url.Dock = DockStyle.Fill
                Panel_Url.Controls.Add(objUserControl_Url)

                objUserControl_Webservice.initialize_Complex(objSemItem_Com_WebService, objLocalConfig.Globals)
                objUserControl_Webservice.Dock = DockStyle.Fill
                Panel_Webservice.Controls.Add(objUserControl_Webservice)
                strTabName_Web = strTabPage_Web & " (" & objUserControl_Eamil.RowCounts & "/" & objUserControl_Url.RowCounts & "/" & objUserControl_Webservice.RowCounts & ")"

                TabPage_Tel.Text = strTabName_Tel
                TabPage_Web.Text = strTabName_Web
            End If


        End If

    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
    End Sub

    Private Sub get_BaseData_ComunicationData()
        Dim objDRC_ComunicationData As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objDRC_ComunicationData = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Partner.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                            objLocalConfig.SemItem_Type_Kommunikationsangaben.GUID).Rows
        If objDRC_ComunicationData.Count > 0 Then
            objSemItem_ComunicationData = New clsSemItem
            objSemItem_ComunicationData.GUID = objDRC_ComunicationData(0).Item("GUID_Token_Left")
            objSemItem_ComunicationData.Name = objDRC_ComunicationData(0).Item("Name_Token_Left")
            objSemItem_ComunicationData.GUID_Parent = objLocalConfig.SemItem_Type_Kommunikationsangaben.GUID
            objSemItem_ComunicationData.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        Else
            objSemItem_ComunicationData = New clsSemItem
            objSemItem_ComunicationData.GUID = Guid.NewGuid
            objSemItem_ComunicationData.Name = objSemItem_Partner.Name
            objSemItem_ComunicationData.GUID_Parent = objLocalConfig.SemItem_Type_Kommunikationsangaben.GUID
            objSemItem_ComunicationData.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_ComunicationData.GUID, _
                                                                 objSemItem_ComunicationData.Name, _
                                                                 objSemItem_ComunicationData.GUID_Parent, True).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ComunicationData.GUID, _
                                                                        objSemItem_Partner.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, 1).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    semprocA_DBWork_Del_Token.GetData(objSemItem_ComunicationData.GUID)
                    objSemItem_ComunicationData = Nothing
                End If
            Else

                objSemItem_ComunicationData = Nothing
            End If

        End If
    End Sub

    Private Sub clear_Controls()
        Panel_Telephone.Controls.Clear()
        Panel_Fax.Controls.Clear()
        Panel_Email.Controls.Clear()
        Panel_Url.Controls.Clear()
        Panel_Webservice.Controls.Clear()
    End Sub
End Class
