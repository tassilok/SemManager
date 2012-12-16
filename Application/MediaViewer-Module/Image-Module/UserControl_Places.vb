Imports Sem_Manager
Public Class UserControl_Places
    Private objLocalConfig As clsLocalConfig
    Private WithEvents objUserControl_Locations As UserControl_SemItemList
    Private objSemItem_Image As clsSemItem

    Private procA_ImageObjects_Of_Images As New ds_ImageModuleTableAdapters.proc_ImageObjects_Of_ImagesTableAdapter
    Private procT_ImageObjects_Of_Images As New ds_ImageModule.proc_ImageObjects_Of_ImagesDataTable

    Private objTransaction_ImageLocations As clsTransaction_ImageObjects
    Private boolNoLocations As Boolean

    Private Sub get_Locations()
        Dim objDRs_Locations() As DataRow
        procA_ImageObjects_Of_Images.Fill(procT_ImageObjects_Of_Images, _
                                          objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                          objLocalConfig.SemItem_Type_Ort.GUID, _
                                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                          objLocalConfig.SemItem_RelationType_is.GUID, _
                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                          objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_.GUID, _
                                          objSemItem_Image.GUID)

        objDRs_Partners = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Pets.GUID.ToString & "'")
        If objDRs_Partners.Count > 0 Then

            boolNoPets = True
        Else
            boolNoPets = False
        End If
        ToolStripButton_NoPets.Checked = boolNoPets
    End Sub
End Class
