Imports Sem_Manager
Public Class UserControl_ImageLandscape
    Private objLocalConfig As clsLocalConfig

    Private WithEvents objUserControl_Landscape As UserControl_SemItemList

    Private procA_ImageObjects_Of_Images As New ds_ImageModuleTableAdapters.proc_ImageObjects_Of_ImagesTableAdapter
    Private procT_ImageObjects_Of_Images As New ds_ImageModule.proc_ImageObjects_Of_ImagesDataTable

    Private objSemItem_Image As clsSemItem

    Private objTransaction_ImageLandScape As clsTransaction_ImageObjects
    Private boolNoLocations As Boolean

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
        objUserControl_Landscape = New UserControl_SemItemList()
        objUserControl_Landscape.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_Landscape.initialize_Simple(objLocalConfig.SemItem_Type_landscape, objLocalConfig.Globals)
        SplitContainer1.Panel2.Controls.Add(objUserControl_Landscape)

    End Sub

    Private Sub get_Landscapes()
        Dim objDRs_Partners() As DataRow
        procA_ImageObjects_Of_Images.Fill(procT_ImageObjects_Of_Images, _
                                          objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                          objLocalConfig.SemItem_Type_landscape.GUID, _
                                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                          objLocalConfig.SemItem_RelationType_is.GUID, _
                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                          objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_landscape.GUID, _
                                          objSemItem_Image.GUID)

        objDRs_Partners = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Location.GUID.ToString & "'")
        If objDRs_Partners.Count > 0 Then

            boolNoLocations = True
        Else
            boolNoLocations = False
        End If
        ToolStripButton_NoLandscape.Checked = boolNoLocations
    End Sub

    Public Sub clear_Lists()
        procT_ImageObjects_Of_Images.Clear()

    End Sub

    Private Sub selectionChange_Landscape() Handles objUserControl_Landscape.Selection_Changed
        If boolNoLocations = False Then
            If objUserControl_Landscape.DataGridViewRowCollection_Selected.Count > 0 Then
                ToolStripButton_ToList.Enabled = True
            Else
                ToolStripButton_ToList.Enabled = False
            End If
        End If

    End Sub


    Public Sub initilialize_Landscapes(ByVal SemItem_Image As clsSemItem)
        objSemItem_Image = SemItem_Image
        boolNoLocations = False

        fill_Landscapes()
    End Sub

    Private Sub fill_Landscapes()
        get_Landscapes()

        BindingSource_ImageObjects.DataSource = procT_ImageObjects_Of_Images
        DataGridView_ImageLandscapes.DataSource = BindingSource_ImageObjects
        DataGridView_ImageLandscapes.Columns(0).Visible = False
        DataGridView_ImageLandscapes.Columns(1).Visible = False
        DataGridView_ImageLandscapes.Columns(2).Visible = False
        DataGridView_ImageLandscapes.Columns(3).Visible = False
        DataGridView_ImageLandscapes.Columns(4).Visible = False
        DataGridView_ImageLandscapes.Columns(6).Visible = False
    End Sub

    Private Sub set_DBConnection()
        procA_ImageObjects_Of_Images.Connection = objLocalConfig.Connection_Plugin
        objTransaction_ImageLandScape = New clsTransaction_ImageObjects(objLocalConfig)
    End Sub

    Private Sub ToolStripButton_ToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton_ToList_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ToList.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_Landscapes() As DataRow
        Dim objSemItem_ImageObject As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Landscapes As New clsSemItem
        Dim intCountDone As Integer
        Dim intCountToDo As Integer

        get_Landscapes()
        intCountToDo = 0
        intCountDone = 0
        For Each objDGVR_Selected In objUserControl_Landscape.DataGridViewRowCollection_Selected
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objDRs_Landscapes = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objDRV_Selected.Item("GUID_Token").ToString & "'")
            If objDRs_Landscapes.Count = 0 Then
                intCountToDo = intCountToDo + 1
                objSemItem_ImageObject.GUID = Guid.NewGuid
                objSemItem_ImageObject.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_ImageObject.GUID_Parent = objLocalConfig.SemItem_Type_Image_Objects.GUID
                objSemItem_ImageObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_ImageLandScape.save_001_ImageObject(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImageLandScape.save_002_ImageObject_To_Image(objSemItem_Image)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Landscapes.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Landscapes.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Landscapes.GUID_Parent = objLocalConfig.SemItem_Type_landscape.GUID
                        objSemItem_Landscapes.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_ImageLandScape.save_003_ImageObject_To_Object(objSemItem_Landscapes, objLocalConfig.SemItem_Type_landscape.GUID)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intCountDone = intCountDone + 1
                        Else
                            objSemItem_Result = objTransaction_ImageLandScape.del_002_ImageObject_To_Image()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_ImageLandScape.del_001_ImageObject()

                            End If
                        End If
                    Else

                        objTransaction_ImageLandScape.del_001_ImageObject()

                    End If

                End If
            End If

        Next

        If intCountDone < intCountToDo Then
            MsgBox("Es konnten nur " & intCountDone & " von " & intCountToDo & " Landschaften verknüpft werden", MsgBoxStyle.Information)
        End If

        fill_Landscapes()
    End Sub
End Class
