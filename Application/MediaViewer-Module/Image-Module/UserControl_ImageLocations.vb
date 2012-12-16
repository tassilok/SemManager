Imports Sem_Manager
Public Class UserControl_ImageLocations
    Private objLocalConfig As clsLocalConfig
    Private WithEvents objUserControl_Locations As UserControl_SemItemList
    Private objSemItem_Image As clsSemItem

    Private procA_ImageObjects_Of_Images As New ds_ImageModuleTableAdapters.proc_ImageObjects_Of_ImagesTableAdapter
    Private procT_ImageObjects_Of_Images As New ds_ImageModule.proc_ImageObjects_Of_ImagesDataTable

    Private objTransaction_ImageLocations As clsTransaction_ImageObjects
    Private boolNoLocations As Boolean

    Private Sub get_Locations()
        Dim objDRs_Partners() As DataRow
        procA_ImageObjects_Of_Images.Fill(procT_ImageObjects_Of_Images, _
                                          objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                          objLocalConfig.SemItem_Type_Ort.GUID, _
                                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                          objLocalConfig.SemItem_RelationType_is.GUID, _
                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                          objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Location.GUID, _
                                          objSemItem_Image.GUID)

        objDRs_Partners = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Location.GUID.ToString & "'")
        If objDRs_Partners.Count > 0 Then

            boolNoLocations = True
        Else
            boolNoLocations = False
        End If
        ToolStripButton_NoLocations.Checked = boolNoLocations
    End Sub

    Private Sub initialize()
        set_DBConnection()
        objUserControl_Locations = New UserControl_SemItemList()
        objUserControl_Locations.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_Locations.initialize_Simple(objLocalConfig.SemItem_Type_Ort, objLocalConfig.Globals)
        SplitContainer1.Panel2.Controls.Add(objUserControl_Locations)

    End Sub

    Public Sub clear_Lists()
        procT_ImageObjects_Of_Images.Clear()

    End Sub

    Private Sub selectionChange_Location() Handles objUserControl_Locations.Selection_Changed
        If boolNoLocations = False Then
            If objUserControl_Locations.DataGridViewRowCollection_Selected.Count > 0 Then
                ToolStripButton_ToList.Enabled = True
            Else
                ToolStripButton_ToList.Enabled = False
            End If
        End If

    End Sub

    Public Sub initilialize_Locations(ByVal SemItem_Image As clsSemItem)
        objSemItem_Image = SemItem_Image
        boolNoLocations = False

        fill_Locations()
    End Sub

    Private Sub fill_Locations()
        get_Locations()

        BindingSource_ImageObjects.DataSource = procT_ImageObjects_Of_Images
        DataGridView_LocationsOfImage.DataSource = BindingSource_ImageObjects
        DataGridView_LocationsOfImage.Columns(0).Visible = False
        DataGridView_LocationsOfImage.Columns(1).Visible = False
        DataGridView_LocationsOfImage.Columns(2).Visible = False
        DataGridView_LocationsOfImage.Columns(3).Visible = False
        DataGridView_LocationsOfImage.Columns(4).Visible = False
        DataGridView_LocationsOfImage.Columns(6).Visible = False
    End Sub

    Private Sub set_DBConnection()
        procA_ImageObjects_Of_Images.Connection = objLocalConfig.Connection_Plugin
        objTransaction_ImageLocations = New clsTransaction_ImageObjects(objLocalConfig)
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
        Dim objDRs_Locations() As DataRow
        Dim objSemItem_ImageObject As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Locations As New clsSemItem
        Dim intCountDone As Integer
        Dim intCountToDo As Integer

        get_Locations()
        intCountToDo = 0
        intCountDone = 0
        For Each objDGVR_Selected In objUserControl_Locations.DataGridViewRowCollection_Selected
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objDRs_Locations = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objDRV_Selected.Item("GUID_Token").ToString & "'")
            If objDRs_Locations.Count = 0 Then
                intCountToDo = intCountToDo + 1
                objSemItem_ImageObject.GUID = Guid.NewGuid
                objSemItem_ImageObject.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_ImageObject.GUID_Parent = objLocalConfig.SemItem_Type_Image_Objects.GUID
                objSemItem_ImageObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_ImageLocations.save_001_ImageObject(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImageLocations.save_002_ImageObject_To_Image(objSemItem_Image)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Locations.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Locations.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Locations.GUID_Parent = objLocalConfig.SemItem_Type_Ort.GUID
                        objSemItem_Locations.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_ImageLocations.save_003_ImageObject_To_Object(objSemItem_Locations, objLocalConfig.SemItem_Type_Ort.GUID)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intCountDone = intCountDone + 1
                        Else
                            objSemItem_Result = objTransaction_ImageLocations.del_002_ImageObject_To_Image()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_ImageLocations.del_001_ImageObject()

                            End If
                        End If
                    Else

                        objTransaction_ImageLocations.del_001_ImageObject()

                    End If

                End If
            End If

        Next

        If intCountDone < intCountToDo Then
            MsgBox("Es konnten nur " & intCountDone & " von " & intCountToDo & " Orte verknüpft werden", MsgBoxStyle.Information)
        End If

        fill_Locations()
    End Sub

End Class
