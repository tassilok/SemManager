Imports Sem_Manager
Public Class UserControl_ImageWeatherCondition
    Private objLocalConfig As clsLocalConfig

    Private WithEvents objUserControl_WeatherCondition As UserControl_SemItemList

    Private procA_ImageObjects_Of_Images As New ds_ImageModuleTableAdapters.proc_ImageObjects_Of_ImagesTableAdapter
    Private procT_ImageObjects_Of_Images As New ds_ImageModule.proc_ImageObjects_Of_ImagesDataTable

    Private objSemItem_Image As clsSemItem

    Private objTransaction_ImageWeatherCondition As clsTransaction_ImageObjects
    Private boolNoWeatherconditions As Boolean

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        initialize()

    End Sub

    Private Sub initialize()
        set_DBConnection()
        objUserControl_WeatherCondition = New UserControl_SemItemList()
        objUserControl_WeatherCondition.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_WeatherCondition.initialize_Simple(objLocalConfig.SemItem_Type_Wetterlage, objLocalConfig.Globals)
        SplitContainer1.Panel2.Controls.Add(objUserControl_WeatherCondition)

    End Sub

    Private Sub get_WeatherConditions()
        Dim objDRs_WeatherConditions() As DataRow
        procA_ImageObjects_Of_Images.Fill(procT_ImageObjects_Of_Images, _
                                          objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                          objLocalConfig.SemItem_Type_Wetterlage.GUID, _
                                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                          objLocalConfig.SemItem_RelationType_is.GUID, _
                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                          objLocalConfig.SemItem_Token_Image_Objects__No_Objects__weather_condition.GUID, _
                                          objSemItem_Image.GUID)

        objDRs_WeatherConditions = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objLocalConfig.SemItem_Token_Image_Objects__No_Objects__weather_condition.GUID.ToString & "'")
        If objDRs_WeatherConditions.Count > 0 Then

            boolNoWeatherconditions = True
        Else
            boolNoWeatherconditions = False
        End If
        ToolStripButton_NoWeathercondition.Checked = boolNoWeatherconditions
    End Sub

    Public Sub clear_Lists()
        procT_ImageObjects_Of_Images.Clear()

    End Sub

    Private Sub selectionChange_WeatherConditions() Handles objUserControl_WeatherCondition.Selection_Changed
        If boolNoWeatherconditions = False Then
            If objUserControl_WeatherCondition.DataGridViewRowCollection_Selected.Count > 0 Then
                ToolStripButton_ToList.Enabled = True
            Else
                ToolStripButton_ToList.Enabled = False
            End If
        End If

    End Sub


    Public Sub initilialize_WeatherConditions(ByVal SemItem_Image As clsSemItem)
        objSemItem_Image = SemItem_Image
        boolNoWeatherconditions = False

        fill_WeatherConditions()
    End Sub

    Private Sub fill_WeatherConditions()
        get_WeatherConditions()

        BindingSource_ImageObjects.DataSource = procT_ImageObjects_Of_Images
        DataGridView_ImageWeatherconditions.DataSource = BindingSource_ImageObjects
        DataGridView_ImageWeatherconditions.Columns(0).Visible = False
        DataGridView_ImageWeatherconditions.Columns(1).Visible = False
        DataGridView_ImageWeatherconditions.Columns(2).Visible = False
        DataGridView_ImageWeatherconditions.Columns(3).Visible = False
        DataGridView_ImageWeatherconditions.Columns(4).Visible = False
        DataGridView_ImageWeatherconditions.Columns(6).Visible = False
    End Sub

    Private Sub set_DBConnection()
        procA_ImageObjects_Of_Images.Connection = objLocalConfig.Connection_Plugin
        objTransaction_ImageWeatherCondition = New clsTransaction_ImageObjects(objLocalConfig)
    End Sub

    Private Sub ToolStripButton_ToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ToList.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_Landscapes() As DataRow
        Dim objSemItem_ImageObject As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Landscapes As New clsSemItem
        Dim intCountDone As Integer
        Dim intCountToDo As Integer

        get_WeatherConditions()
        intCountToDo = 0
        intCountDone = 0
        For Each objDGVR_Selected In objUserControl_WeatherCondition.DataGridViewRowCollection_Selected
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objDRs_Landscapes = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objDRV_Selected.Item("GUID_Token").ToString & "'")
            If objDRs_Landscapes.Count = 0 Then
                intCountToDo = intCountToDo + 1
                objSemItem_ImageObject.GUID = Guid.NewGuid
                objSemItem_ImageObject.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_ImageObject.GUID_Parent = objLocalConfig.SemItem_Type_Image_Objects.GUID
                objSemItem_ImageObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_ImageWeatherCondition.save_001_ImageObject(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImageWeatherCondition.save_002_ImageObject_To_Image(objSemItem_Image)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Landscapes.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Landscapes.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Landscapes.GUID_Parent = objLocalConfig.SemItem_Type_Wetterlage.GUID
                        objSemItem_Landscapes.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_ImageWeatherCondition.save_003_ImageObject_To_Object(objSemItem_Landscapes, objLocalConfig.SemItem_Type_landscape.GUID)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intCountDone = intCountDone + 1
                        Else
                            objSemItem_Result = objTransaction_ImageWeatherCondition.del_002_ImageObject_To_Image()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_ImageWeatherCondition.del_001_ImageObject()

                            End If
                        End If
                    Else

                        objTransaction_ImageWeatherCondition.del_001_ImageObject()

                    End If

                End If
            End If

        Next

        If intCountDone < intCountToDo Then
            MsgBox("Es konnten nur " & intCountDone & " von " & intCountToDo & " Wetterlagen verknüpft werden", MsgBoxStyle.Information)
        End If

        fill_WeatherConditions()
    End Sub
End Class
