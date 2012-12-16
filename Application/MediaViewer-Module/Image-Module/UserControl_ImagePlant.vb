Imports Sem_Manager
Public Class UserControl_ImagePlant
    Private objLocalConfig As clsLocalConfig
    Private WithEvents objUserControl_Plants As UserControl_SemItemList
    Private objSemItem_Image As clsSemItem

    Private procA_ImageObjects_Of_Images As New ds_ImageModuleTableAdapters.proc_ImageObjects_Of_ImagesTableAdapter
    Private procT_ImageObjects_Of_Images As New ds_ImageModule.proc_ImageObjects_Of_ImagesDataTable

    Private objTransaction_ImagePlants As clsTransaction_ImageObjects
    Private boolNoPlants As Boolean

    Private Sub selectionChange_Plants() Handles objUserControl_Plants.Selection_Changed
        If boolNoPlants = False Then
            If objUserControl_Plants.DataGridViewRowCollection_Selected.Count > 0 Then
                ToolStripButton_ToList.Enabled = True
            Else
                ToolStripButton_ToList.Enabled = False
            End If
        End If

    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Public Sub clear_Lists()
        procT_ImageObjects_Of_Images.Clear()

    End Sub

    Public Sub initilialize_Plants(ByVal SemItem_Image As clsSemItem)
        objSemItem_Image = SemItem_Image
        boolNoPlants = False

        fill_Plants()
    End Sub

    Private Sub fill_Plants()
        get_Plants()

        BindingSource_ImageObjects.DataSource = procT_ImageObjects_Of_Images
        DataGridView_PlantsOfImage.DataSource = BindingSource_ImageObjects
        DataGridView_PlantsOfImage.Columns(0).Visible = False
        DataGridView_PlantsOfImage.Columns(1).Visible = False
        DataGridView_PlantsOfImage.Columns(2).Visible = False
        DataGridView_PlantsOfImage.Columns(3).Visible = False
        DataGridView_PlantsOfImage.Columns(4).Visible = False
        DataGridView_PlantsOfImage.Columns(6).Visible = False
    End Sub

    Private Sub get_Plants()
        Dim objDRs_Plants() As DataRow
        procA_ImageObjects_Of_Images.Fill(procT_ImageObjects_Of_Images, _
                                          objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                          objLocalConfig.SemItem_Type_Pflanzenarten.GUID, _
                                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                          objLocalConfig.SemItem_RelationType_is.GUID, _
                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                          objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_plant_Species.GUID, _
                                          objSemItem_Image.GUID)

        objDRs_Plants = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_plant_Species.GUID.ToString & "'")
        If objDRs_Plants.Count > 0 Then

            boolNoPlants = True
        Else
            boolNoPlants = False
        End If
        ToolStripButton_NoPlants.Checked = boolNoPlants
    End Sub

    Private Sub initialize()
        set_DBConnection()
        objUserControl_Plants = New UserControl_SemItemList()
        objUserControl_Plants.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_Plants.initialize_Simple(objLocalConfig.SemItem_Type_Pflanzenarten, objLocalConfig.Globals)
        SplitContainer1.Panel2.Controls.Add(objUserControl_Plants)

    End Sub

    Private Sub set_DBConnection()
        procA_ImageObjects_Of_Images.Connection = objLocalConfig.Connection_Plugin
        objTransaction_ImagePlants = New clsTransaction_ImageObjects(objLocalConfig)
    End Sub

    Private Sub DataGridView_PlantsOfImage_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_PlantsOfImage.SelectionChanged
        If boolNoPlants = False Then
            If DataGridView_PlantsOfImage.SelectedRows.Count > 0 Then
                ToolStripButton_FromList.Enabled = True
            Else
                ToolStripButton_FromList.Enabled = False
            End If
        End If
    End Sub

    Private Sub ToolStripButton_ToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ToList.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_Plants() As DataRow
        Dim objSemItem_ImageObject As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Plant As New clsSemItem
        Dim intCountDone As Integer
        Dim intCountToDo As Integer

        get_Plants()
        intCountToDo = 0
        intCountDone = 0
        For Each objDGVR_Selected In objUserControl_Plants.DataGridViewRowCollection_Selected
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objDRs_Plants = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objDRV_Selected.Item("GUID_Token").ToString & "'")
            If objDRs_Plants.Count = 0 Then
                intCountToDo = intCountToDo + 1
                objSemItem_ImageObject.GUID = Guid.NewGuid
                objSemItem_ImageObject.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_ImageObject.GUID_Parent = objLocalConfig.SemItem_Type_Image_Objects.GUID
                objSemItem_ImageObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_ImagePlants.save_001_ImageObject(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImagePlants.save_002_ImageObject_To_Image(objSemItem_Image)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Plant.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Plant.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Plant.GUID_Parent = objLocalConfig.SemItem_Type_Pflanzenarten.GUID
                        objSemItem_Plant.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_ImagePlants.save_003_ImageObject_To_Object(objSemItem_Plant, objLocalConfig.SemItem_Type_Pflanzenarten.GUID)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intCountDone = intCountDone + 1
                        Else
                            objSemItem_Result = objTransaction_ImagePlants.del_002_ImageObject_To_Image()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_ImagePlants.del_001_ImageObject()

                            End If
                        End If
                    Else

                        objTransaction_ImagePlants.del_001_ImageObject()

                    End If

                End If
            End If

        Next

        If intCountDone < intCountToDo Then
            MsgBox("Es konnten nur " & intCountDone & " von " & intCountToDo & " Pflanzenarten verknüpft werden", MsgBoxStyle.Information)
        End If

        fill_Plants()
    End Sub

    Private Sub ToolStripButton_NoPlants_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_NoPlants.Click
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Plant As New clsSemItem
        Dim objDR_Plant As DataRow
        Dim objSemItem_ImageObject As New clsSemItem
        Dim objDRs_Plants() As DataRow
        Dim boolAddNoPlant As Boolean
        get_Plants()

        If ToolStripButton_NoPlants.Checked = False Then
            boolAddNoPlant = True
            If procT_ImageObjects_Of_Images.Count > 0 Then
                If MsgBox("Wollen Sie alle zugeordneten Pflanzenarten entfernen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    For Each objDR_Plant In procT_ImageObjects_Of_Images.Rows
                        objSemItem_ImageObject.GUID = objDR_Plant.Item("GUID_Token_Right")
                        objSemItem_Result = objTransaction_ImagePlants.del_003_ImageObject_To_Object(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_plant_Species.GUID, objSemItem_ImageObject)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_ImagePlants.del_002_ImageObject_To_Image
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_ImagePlants.del_001_ImageObject
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                    boolAddNoPlant = False
                                    MsgBox("Die Pflanzenart konnten nicht entfernt werden", MsgBoxStyle.Exclamation)
                                    Exit For
                                End If
                            Else
                                boolAddNoPlant = False
                                MsgBox("Die Pflanzenart konnten nicht entfernt werden", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Else
                            boolAddNoPlant = False
                            MsgBox("Die Pflanzenart konnten nicht entfernt werden", MsgBoxStyle.Exclamation)
                            Exit For
                        End If
                    Next
                Else
                    boolAddNoPlant = False
                End If
            End If

            If boolAddNoPlant = True Then
                objSemItem_ImageObject.GUID = Guid.NewGuid
                objSemItem_ImageObject.Name = objSemItem_Image.Name
                objSemItem_ImageObject.GUID_Parent = objLocalConfig.SemItem_Type_Image_Objects.GUID
                objSemItem_ImageObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Result = objTransaction_ImagePlants.save_001_ImageObject(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImagePlants.save_002_ImageObject_To_Image(objSemItem_Image)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_ImagePlants.save_004_noObjects(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_plant_Species, objSemItem_ImageObject)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objTransaction_ImagePlants.del_002_ImageObject_To_Image
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_ImagePlants.del_001_ImageObject()
                            End If


                            MsgBox("Die Markierung, dass das Bild keine Pflanzenarten enthält, kann nicht erzeugt werden.", MsgBoxStyle.Information)
                            ToolStripButton_NoPlants.Checked = False
                        End If
                    Else
                        objTransaction_ImagePlants.del_001_ImageObject()

                        MsgBox("Die Markierung, dass das Bild keine Pflanzenarten enthält, kann nicht erzeugt werden.", MsgBoxStyle.Information)
                        ToolStripButton_NoPlants.Checked = False
                    End If
                Else
                    MsgBox("Die Markierung, dass das Bild keine Pflanzenarten enthält, kann nicht erzeugt werden.", MsgBoxStyle.Information)
                    ToolStripButton_NoPlants.Checked = False
                End If

            End If
        Else
            objDRs_Plants = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_plant_Species.GUID.ToString & "'")
            If objDRs_Plants.Count > 0 Then
                objSemItem_ImageObject.GUID = objDRs_Plants(0).Item("GUID_Token_Right")
                objSemItem_Result = objTransaction_ImagePlants.del_004_noObjects(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImagePlants.del_003_ImageObject_To_Object(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_plant_Species.GUID)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_ImagePlants.del_002_ImageObject_To_Image
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_ImagePlants.del_001_ImageObject
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then

                                MsgBox("Die Markierung, dass das Bild keine Pflanzenart enthält, kann nicht entfernt werden.", MsgBoxStyle.Information)
                                ToolStripButton_NoPlants.Checked = True
                            End If
                        Else
                            MsgBox("Die Markierung, dass das Bild keine Pflanzenart enthält, kann nicht entfernt werden.", MsgBoxStyle.Information)
                            ToolStripButton_NoPlants.Checked = True
                        End If
                    Else
                        MsgBox("Die Markierung, dass das Bild keine Pflanzenart enthält, kann nicht entfernt werden.", MsgBoxStyle.Information)
                        ToolStripButton_NoPlants.Checked = True
                    End If
                Else
                    MsgBox("Die Markierung, dass das Bild keine Pflanzenart enthält, kann nicht entfernt werden.", MsgBoxStyle.Information)
                    ToolStripButton_NoPlants.Checked = True
                End If
            End If

        End If
    End Sub
End Class
