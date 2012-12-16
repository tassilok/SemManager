Imports Sem_Manager
Public Class UserControl_ArtWork
    Private objLocalConfig As clsLocalConfig
    Private WithEvents objUserControl_ImageArt As UserControl_SemItemList
    Private objSemItem_Image As clsSemItem

    Private procA_ImageObjects_Of_Images As New ds_ImageModuleTableAdapters.proc_ImageObjects_Of_ImagesTableAdapter
    Private procT_ImageObjects_Of_Images As New ds_ImageModule.proc_ImageObjects_Of_ImagesDataTable

    Private objTransaction_ImageArtWork As clsTransaction_ImageObjects
    Private boolNoArtWork As Boolean

    Private Sub selectionChange_ArtWork() Handles objUserControl_ImageArt.Selection_Changed
        If boolNoArtWork = False Then
            If objUserControl_ImageArt.DataGridViewRowCollection_Selected.Count > 0 Then
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

    Public Sub initilialize_ArtWork(ByVal SemItem_Image As clsSemItem)
        objSemItem_Image = SemItem_Image
        boolNoArtWork = False

        fill_ArtWorks()
    End Sub

    Private Sub fill_ArtWorks()
        get_ArtWorks()

        BindingSource_ImageObjects.DataSource = procT_ImageObjects_Of_Images
        DataGridView_ArtWorkOfImage.DataSource = BindingSource_ImageObjects
        DataGridView_ArtWorkOfImage.Columns(0).Visible = False
        DataGridView_ArtWorkOfImage.Columns(1).Visible = False
        DataGridView_ArtWorkOfImage.Columns(2).Visible = False
        DataGridView_ArtWorkOfImage.Columns(3).Visible = False
        DataGridView_ArtWorkOfImage.Columns(4).Visible = False
        DataGridView_ArtWorkOfImage.Columns(6).Visible = False
    End Sub

    Private Sub get_ArtWorks()
        Dim objDRs_Plants() As DataRow
        procA_ImageObjects_Of_Images.Fill(procT_ImageObjects_Of_Images, _
                                          objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                          objLocalConfig.SemItem_Type_Kunst.GUID, _
                                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                          objLocalConfig.SemItem_RelationType_is.GUID, _
                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                          objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Artwork.GUID, _
                                          objSemItem_Image.GUID)

        objDRs_Plants = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Artwork.GUID.ToString & "'")
        If objDRs_Plants.Count > 0 Then

            boolNoArtWork = True
        Else
            boolNoArtWork = False
        End If
        ToolStripButton_NoArtWork.Checked = boolNoArtWork
    End Sub

    Private Sub initialize()
        set_DBConnection()
        objUserControl_ImageArt = New UserControl_SemItemList()
        objUserControl_ImageArt.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_ImageArt.initialize_Simple(objLocalConfig.SemItem_Type_Kunst, objLocalConfig.Globals)
        SplitContainer1.Panel2.Controls.Add(objUserControl_ImageArt)

    End Sub

    Private Sub set_DBConnection()
        procA_ImageObjects_Of_Images.Connection = objLocalConfig.Connection_Plugin
        objTransaction_ImageArtWork = New clsTransaction_ImageObjects(objLocalConfig)
    End Sub

    Private Sub DataGridView_ArtWorkOfImage_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_ArtWorkOfImage.SelectionChanged
        If boolNoArtWork = False Then
            If DataGridView_ArtWorkOfImage.SelectedRows.Count > 0 Then
                ToolStripButton_FromList.Enabled = True
            Else
                ToolStripButton_FromList.Enabled = False
            End If
        End If
    End Sub

    Private Sub ToolStripButton_ToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ToList.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_ArtWorks() As DataRow
        Dim objSemItem_ImageObject As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_ArtWork As New clsSemItem
        Dim intCountDone As Integer
        Dim intCountToDo As Integer

        get_ArtWorks()
        intCountToDo = 0
        intCountDone = 0
        For Each objDGVR_Selected In objUserControl_ImageArt.DataGridViewRowCollection_Selected
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objDRs_ArtWorks = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objDRV_Selected.Item("GUID_Token").ToString & "'")
            If objDRs_ArtWorks.Count = 0 Then
                intCountToDo = intCountToDo + 1
                objSemItem_ImageObject.GUID = Guid.NewGuid
                objSemItem_ImageObject.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_ImageObject.GUID_Parent = objLocalConfig.SemItem_Type_Image_Objects.GUID
                objSemItem_ImageObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_ImageArtWork.save_001_ImageObject(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImageArtWork.save_002_ImageObject_To_Image(objSemItem_Image)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_ArtWork.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_ArtWork.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_ArtWork.GUID_Parent = objLocalConfig.SemItem_Type_Kunst.GUID
                        objSemItem_ArtWork.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_ImageArtWork.save_003_ImageObject_To_Object(objSemItem_ArtWork, objLocalConfig.SemItem_Type_Kunst.GUID)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intCountDone = intCountDone + 1
                        Else
                            objSemItem_Result = objTransaction_ImageArtWork.del_002_ImageObject_To_Image()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_ImageArtWork.del_001_ImageObject()

                            End If
                        End If
                    Else

                        objTransaction_ImageArtWork.del_001_ImageObject()

                    End If

                End If
            End If

        Next

        If intCountDone < intCountToDo Then
            MsgBox("Es konnten nur " & intCountDone & " von " & intCountToDo & " Kunstwerke verknüpft werden", MsgBoxStyle.Information)
        End If

        fill_ArtWorks()
    End Sub

    Private Sub ToolStripButton_NoArtWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_NoArtWork.Click
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_ArtWork As New clsSemItem
        Dim objDR_Plant As DataRow
        Dim objSemItem_ImageObject As New clsSemItem
        Dim objDRs_ArtWorks() As DataRow
        Dim boolAddNoArtWork As Boolean
        get_ArtWorks()

        If ToolStripButton_NoArtWork.Checked = False Then
            boolAddNoArtWork = True
            If procT_ImageObjects_Of_Images.Count > 0 Then
                If MsgBox("Wollen Sie alle zugeordneten Pflanzenarten entfernen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    For Each objDR_Plant In procT_ImageObjects_Of_Images.Rows
                        objSemItem_ImageObject.GUID = objDR_Plant.Item("GUID_Token_Right")
                        objSemItem_Result = objTransaction_ImageArtWork.del_003_ImageObject_To_Object(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Artwork.GUID, objSemItem_ImageObject)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_ImageArtWork.del_002_ImageObject_To_Image
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_ImageArtWork.del_001_ImageObject
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                    boolAddNoArtWork = False
                                    MsgBox("Das Kunstwerk konnten nicht entfernt werden", MsgBoxStyle.Exclamation)
                                    Exit For
                                End If
                            Else
                                boolAddNoArtWork = False
                                MsgBox("Das Kunstwerk konnten nicht entfernt werden", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Else
                            boolAddNoArtWork = False
                            MsgBox("Das Kunstwerk konnten nicht entfernt werden", MsgBoxStyle.Exclamation)
                            Exit For
                        End If
                    Next
                Else
                    boolAddNoArtWork = False
                End If
            End If

            If boolAddNoArtWork = True Then
                objSemItem_ImageObject.GUID = Guid.NewGuid
                objSemItem_ImageObject.Name = objSemItem_Image.Name
                objSemItem_ImageObject.GUID_Parent = objLocalConfig.SemItem_Type_Image_Objects.GUID
                objSemItem_ImageObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Result = objTransaction_ImageArtWork.save_001_ImageObject(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImageArtWork.save_002_ImageObject_To_Image(objSemItem_Image)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_ImageArtWork.save_004_noObjects(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Artwork, objSemItem_ImageObject)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objTransaction_ImageArtWork.del_002_ImageObject_To_Image
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_ImageArtWork.del_001_ImageObject()
                            End If


                            MsgBox("Die Markierung, dass das Bild kein Kunstwerk enthält, kann nicht erzeugt werden.", MsgBoxStyle.Information)
                            ToolStripButton_NoArtWork.Checked = False
                        End If
                    Else
                        objTransaction_ImageArtWork.del_001_ImageObject()

                        MsgBox("Die Markierung, dass das Bild kein Kunstwerk enthält, kann nicht erzeugt werden.", MsgBoxStyle.Information)
                        ToolStripButton_NoArtWork.Checked = False
                    End If
                Else
                    MsgBox("Die Markierung, dass das Bild kein Kunstwerk enthält, kann nicht erzeugt werden.", MsgBoxStyle.Information)
                    ToolStripButton_NoArtWork.Checked = False
                End If

            End If
        Else
            objDRs_ArtWorks = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Artwork.GUID.ToString & "'")
            If objDRs_ArtWorks.Count > 0 Then
                objSemItem_ImageObject.GUID = objDRs_ArtWorks(0).Item("GUID_Token_Right")
                objSemItem_Result = objTransaction_ImageArtWork.del_004_noObjects(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImageArtWork.del_003_ImageObject_To_Object(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Artwork.GUID)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_ImageArtWork.del_002_ImageObject_To_Image
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_ImageArtWork.del_001_ImageObject
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then

                                MsgBox("Die Markierung, dass das Bild kein Kunstwerk enthält, kann nicht entfernt werden.", MsgBoxStyle.Information)
                                ToolStripButton_NoArtWork.Checked = True
                            End If
                        Else
                            MsgBox("Die Markierung, dass das Bild kein Kunstwerk enthält, kann nicht entfernt werden.", MsgBoxStyle.Information)
                            ToolStripButton_NoArtWork.Checked = True
                        End If
                    Else
                        MsgBox("Die Markierung, dass das Bild kein Kunstwerk enthält, kann nicht entfernt werden.", MsgBoxStyle.Information)
                        ToolStripButton_NoArtWork.Checked = True
                    End If
                Else
                    MsgBox("Die Markierung, dass das Bild kein Kunstwerk enthält, kann nicht entfernt werden.", MsgBoxStyle.Information)
                    ToolStripButton_NoArtWork.Checked = True
                End If
            End If

        End If
    End Sub
End Class
