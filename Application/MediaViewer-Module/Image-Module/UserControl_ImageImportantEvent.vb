Imports Sem_Manager
Public Class UserControl_ImageImportantEvent
    Private objLocalConfig As clsLocalConfig
    Private WithEvents objUserControl_ImportantEvents As UserControl_SemItemList
    Private objSemItem_Image As clsSemItem

    Private procA_Image_Of_Or_ImportantEvents As New ds_ImageModuleTableAdapters.proc_Image_Of_Or_ImportantEventsTableAdapter
    Private procT_Image_Of_Or_ImportantEvents As New ds_ImageModule.proc_Image_Of_Or_ImportantEventsDataTable

    Private objTransaction_Image As clsTransaction_Imagevb

    Private Sub get_ImportantEvents()

        procA_Image_Of_Or_ImportantEvents.Fill(procT_Image_Of_Or_ImportantEvents, _
                                          objLocalConfig.SemItem_Type_Images__Graphic_.GUID, _
                                          objLocalConfig.SemItem_Type_File.GUID, _
                                          objLocalConfig.SemItem_Type_Wichtige_Ereignisse.GUID, _
                                          objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                          objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                          objSemItem_Image.GUID)


    End Sub

    Private Sub initialize()
        set_DBConnection()
        objUserControl_ImportantEvents = New UserControl_SemItemList()
        objUserControl_ImportantEvents.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_ImportantEvents.initialize_Simple(objLocalConfig.SemItem_Type_Wichtige_Ereignisse, objLocalConfig.Globals)
        SplitContainer1.Panel2.Controls.Add(objUserControl_ImportantEvents)

    End Sub

    Public Sub clear_Lists()
        procT_Image_Of_Or_ImportantEvents.Clear()

    End Sub

    Private Sub selectionChange_Partners() Handles objUserControl_ImportantEvents.Selection_Changed

        If objUserControl_ImportantEvents.DataGridViewRowCollection_Selected.Count > 0 Then
            ToolStripButton_ToList.Enabled = True
        Else
            ToolStripButton_ToList.Enabled = False
        End If


    End Sub

    Public Sub initilialize_Events(ByVal SemItem_Image As clsSemItem)
        objSemItem_Image = SemItem_Image

        fill_ImportantEvents()
    End Sub

    Private Sub fill_ImportantEvents()
        get_ImportantEvents()

        BindingSource_ImageObjects.DataSource = procT_Image_Of_Or_ImportantEvents
        DataGridView_ImportantEventsOfImage.DataSource = BindingSource_ImageObjects
        DataGridView_ImportantEventsOfImage.Columns(0).Visible = False
        DataGridView_ImportantEventsOfImage.Columns(1).Visible = False
        DataGridView_ImportantEventsOfImage.Columns(2).Visible = False
        DataGridView_ImportantEventsOfImage.Columns(3).Visible = False
        DataGridView_ImportantEventsOfImage.Columns(4).Visible = False
        DataGridView_ImportantEventsOfImage.Columns(6).Visible = False
        DataGridView_ImportantEventsOfImage.Columns(7).Visible = False
        DataGridView_ImportantEventsOfImage.Columns(8).Visible = False
        DataGridView_ImportantEventsOfImage.Columns(9).Visible = False
        DataGridView_ImportantEventsOfImage.Columns(11).Visible = False
    End Sub

    Private Sub set_DBConnection()
        procA_Image_Of_Or_ImportantEvents.Connection = objLocalConfig.Connection_Plugin
        objTransaction_Image = New clsTransaction_Imagevb(objLocalConfig)
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Private Sub ToolStripButton_ToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ToList.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_Events() As DataRow
        Dim objSemItem_ImageObject As New clsSemItem
        Dim objSemItem_Ref As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Events As New clsSemItem
        Dim objSemItem_OR As New clsSemItem
        Dim intCountDone As Integer
        Dim intCountToDo As Integer

        get_ImportantEvents()
        intCountToDo = 0
        intCountDone = 0
        For Each objDGVR_Selected In objUserControl_ImportantEvents.DataGridViewRowCollection_Selected
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Ref.GUID = objDRV_Selected.Item("GUID_Token")
            objSemItem_Ref.Name = objDRV_Selected.Item("Name_Token")
            objSemItem_Ref.GUID_Parent = objDRV_Selected.Item("GUID_Type")
            objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Result = objTransaction_Image.save_001_OR_of_Ref(objSemItem_Ref)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_Image.save_007_ImageGraphic_To_OR(0, objSemItem_Image)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intCountDone = intCountDone + 1
                End If
            End If
        Next

        If intCountDone < intCountToDo Then
            MsgBox("Es konnten nur " & intCountDone & " von " & intCountToDo & " Wichtige Ereignisse verknüpft werden", MsgBoxStyle.Information)
        End If

        fill_ImportantEvents()
    End Sub
End Class
