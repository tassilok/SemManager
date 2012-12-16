Imports Sem_Manager
Public Class UserControl_Buildings

    Private objLocalConfig As clsLocalConfig
    Private WithEvents objUserControl_Buildings As UserControl_SemItemList
    Private objSemItem_Image As clsSemItem

    Private procA_ImageObjects_Of_Images As New ds_ImageModuleTableAdapters.proc_ImageObjects_Of_ImagesTableAdapter
    Private procT_ImageObjects_Of_Images As New ds_ImageModule.proc_ImageObjects_Of_ImagesDataTable

    Private objTransaction_ImageBuildings As clsTransaction_ImageObjects
    Private boolNoBuildings As Boolean

    Private Sub get_Buildings()
        Dim objDRs_Partners() As DataRow
        procA_ImageObjects_Of_Images.Fill(procT_ImageObjects_Of_Images, _
                                          objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                          objLocalConfig.SemItem_Type_Bauwerke.GUID, _
                                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                          objLocalConfig.SemItem_RelationType_is.GUID, _
                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                          objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Buildings.GUID, _
                                          objSemItem_Image.GUID)

        objDRs_Partners = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Persons.GUID.ToString & "'")
        If objDRs_Partners.Count > 0 Then

            boolNoBuildings = True
        Else
            boolNoBuildings = False
        End If
        ToolStripButton_NoBuildings.Checked = boolNoBuildings
    End Sub

    Private Sub initialize()
        set_DBConnection()
        objUserControl_Buildings = New UserControl_SemItemList()
        objUserControl_Buildings.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_Buildings.initialize_Simple(objLocalConfig.SemItem_Type_Bauwerke, objLocalConfig.Globals)
        SplitContainer1.Panel2.Controls.Add(objUserControl_Buildings)

    End Sub

    Public Sub clear_Lists()
        procT_ImageObjects_Of_Images.Clear()

    End Sub

    Private Sub selectionChange_Partners() Handles objUserControl_Buildings.Selection_Changed
        If boolNoBuildings = False Then
            If objUserControl_Buildings.DataGridViewRowCollection_Selected.Count > 0 Then
                ToolStripButton_ToList.Enabled = True
            Else
                ToolStripButton_ToList.Enabled = False
            End If
        End If

    End Sub

    Public Sub initilialize_Buildings(ByVal SemItem_Image As clsSemItem)
        objSemItem_Image = SemItem_Image
        boolNoBuildings = False

        fill_Buildings()
    End Sub

    Private Sub fill_Buildings()
        get_Buildings()

        BindingSource_ImageObjects.DataSource = procT_ImageObjects_Of_Images
        DataGridView_BuildingsOfImage.DataSource = BindingSource_ImageObjects
        DataGridView_BuildingsOfImage.Columns(0).Visible = False
        DataGridView_BuildingsOfImage.Columns(1).Visible = False
        DataGridView_BuildingsOfImage.Columns(2).Visible = False
        DataGridView_BuildingsOfImage.Columns(3).Visible = False
        DataGridView_BuildingsOfImage.Columns(4).Visible = False
        DataGridView_BuildingsOfImage.Columns(6).Visible = False
    End Sub

    Private Sub set_DBConnection()
        procA_ImageObjects_Of_Images.Connection = objLocalConfig.Connection_Plugin
        objTransaction_ImageBuildings = New clsTransaction_ImageObjects(objLocalConfig)
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
        Dim objDRs_Buildings() As DataRow
        Dim objSemItem_ImageObject As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Building As New clsSemItem
        Dim intCountDone As Integer
        Dim intCountToDo As Integer

        get_Buildings()
        intCountToDo = 0
        intCountDone = 0
        For Each objDGVR_Selected In objUserControl_Buildings.DataGridViewRowCollection_Selected
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objDRs_Buildings = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objDRV_Selected.Item("GUID_Token").ToString & "'")
            If objDRs_Buildings.Count = 0 Then
                intCountToDo = intCountToDo + 1
                objSemItem_ImageObject.GUID = Guid.NewGuid
                objSemItem_ImageObject.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_ImageObject.GUID_Parent = objLocalConfig.SemItem_Type_Image_Objects.GUID
                objSemItem_ImageObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_ImageBuildings.save_001_ImageObject(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImageBuildings.save_002_ImageObject_To_Image(objSemItem_Image)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Building.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Building.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Building.GUID_Parent = objLocalConfig.SemItem_Type_Bauwerke.GUID
                        objSemItem_Building.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_ImageBuildings.save_003_ImageObject_To_Object(objSemItem_Building, objLocalConfig.SemItem_Type_Bauwerke.GUID)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intCountDone = intCountDone + 1
                        Else
                            objSemItem_Result = objTransaction_ImageBuildings.del_002_ImageObject_To_Image()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_ImageBuildings.del_001_ImageObject()

                            End If
                        End If
                    Else

                        objTransaction_ImageBuildings.del_001_ImageObject()

                    End If

                End If
            End If

        Next

        If intCountDone < intCountToDo Then
            MsgBox("Es konnten nur " & intCountDone & " von " & intCountToDo & " Bauwerke verknüpft werden", MsgBoxStyle.Information)
        End If

        fill_Buildings()
    End Sub
End Class
