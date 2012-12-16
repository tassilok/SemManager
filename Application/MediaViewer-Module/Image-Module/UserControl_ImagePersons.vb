Imports Sem_Manager
Public Class UserControl_ImagePersons

    Private objLocalConfig As clsLocalConfig
    Private WithEvents objUserControl_Partners As UserControl_SemItemList
    Private objSemItem_Image As clsSemItem

    Private procA_ImageObjects_Of_Images As New ds_ImageModuleTableAdapters.proc_ImageObjects_Of_ImagesTableAdapter
    Private procT_ImageObjects_Of_Images As New ds_ImageModule.proc_ImageObjects_Of_ImagesDataTable

    Private objTransaction_ImagePerson As clsTransaction_ImageObjects
    Private boolNoPersons As Boolean

    Private Sub selectionChange_Partners() Handles objUserControl_Partners.Selection_Changed
        If boolNoPersons = False Then
            If objUserControl_Partners.DataGridViewRowCollection_Selected.Count > 0 Then
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

    Public Sub initilialize_Partners(ByVal SemItem_Image As clsSemItem)
        objSemItem_Image = SemItem_Image
        boolNoPersons = False

        fill_Partners()
    End Sub

    Private Sub fill_Partners()
        get_Partners()

        BindingSource_ImageObjects.DataSource = procT_ImageObjects_Of_Images
        DataGridView_PartnersOfImage.DataSource = BindingSource_ImageObjects
        DataGridView_PartnersOfImage.Columns(0).Visible = False
        DataGridView_PartnersOfImage.Columns(1).Visible = False
        DataGridView_PartnersOfImage.Columns(2).Visible = False
        DataGridView_PartnersOfImage.Columns(3).Visible = False
        DataGridView_PartnersOfImage.Columns(4).Visible = False
        DataGridView_PartnersOfImage.Columns(6).Visible = False
    End Sub

    Private Sub get_Partners()
        Dim objDRs_Partners() As DataRow
        procA_ImageObjects_Of_Images.Fill(procT_ImageObjects_Of_Images, _
                                          objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                          objLocalConfig.SemItem_Type_Partner.GUID, _
                                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                          objLocalConfig.SemItem_RelationType_is.GUID, _
                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                          objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Persons.GUID, _
                                          objSemItem_Image.GUID)

        objDRs_Partners = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Persons.GUID.ToString & "'")
        If objDRs_Partners.Count > 0 Then

            boolNoPersons = True
        Else
            boolNoPersons = False
        End If
        ToolStripButton_NoPersons.Checked = boolNoPersons
    End Sub

    Private Sub initialize()
        set_DBConnection()
        objUserControl_Partners = New UserControl_SemItemList()
        objUserControl_Partners.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_Partners.initialize_Simple(objLocalConfig.SemItem_Type_Partner, objLocalConfig.Globals)
        SplitContainer1.Panel2.Controls.Add(objUserControl_Partners)

    End Sub

    Private Sub set_DBConnection()
        procA_ImageObjects_Of_Images.Connection = objLocalConfig.Connection_Plugin
        objTransaction_ImagePerson = New clsTransaction_ImageObjects(objLocalConfig)
    End Sub

    Private Sub DataGridView_PartnersOfImage_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_PartnersOfImage.SelectionChanged
        If boolNoPersons = False Then
            If DataGridView_PartnersOfImage.SelectedRows.Count > 0 Then
                ToolStripButton_FromList.Enabled = True
            Else
                ToolStripButton_FromList.Enabled = False
            End If
        End If
        
    End Sub

    Private Sub ToolStripButton_ToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ToList.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRs_Partners() As DataRow
        Dim objSemItem_ImageObject As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Partner As New clsSemItem
        Dim intCountDone As Integer
        Dim intCountToDo As Integer

        get_Partners()
        intCountToDo = 0
        intCountDone = 0
        For Each objDGVR_Selected In objUserControl_Partners.DataGridViewRowCollection_Selected
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objDRs_Partners = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objDRV_Selected.Item("GUID_Token").ToString & "'")
            If objDRs_Partners.Count = 0 Then
                intCountToDo = intCountToDo + 1
                objSemItem_ImageObject.GUID = Guid.NewGuid
                objSemItem_ImageObject.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_ImageObject.GUID_Parent = objLocalConfig.SemItem_Type_Image_Objects.GUID
                objSemItem_ImageObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_ImagePerson.save_001_ImageObject(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImagePerson.save_002_ImageObject_To_Image(objSemItem_Image)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Partner.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Partner.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Partner.GUID
                        objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_ImagePerson.save_003_ImageObject_To_Object(objSemItem_Partner, objLocalConfig.SemItem_Type_Partner.GUID)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intCountDone = intCountDone + 1
                        Else
                            objSemItem_Result = objTransaction_ImagePerson.del_002_ImageObject_To_Image()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_ImagePerson.del_001_ImageObject()

                            End If
                        End If
                    Else

                        objTransaction_ImagePerson.del_001_ImageObject()

                    End If

                End If
            End If

        Next

        If intCountDone < intCountToDo Then
            MsgBox("Es konnten nur " & intCountDone & " von " & intCountToDo & " Partner verknüpft werden", MsgBoxStyle.Information)
        End If

        fill_Partners()
    End Sub

    Private Sub ToolStripButton_NoPersons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_NoPersons.Click
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Partner As New clsSemItem
        Dim objDR_Partner As DataRow
        Dim objSemItem_ImageObject As New clsSemItem
        Dim objDRs_Partners() As DataRow
        Dim boolAddNoPerson As Boolean
        get_Partners()

        If ToolStripButton_NoPersons.Checked = False Then
            boolAddNoPerson = True
            If procT_ImageObjects_Of_Images.Count > 0 Then
                If MsgBox("Wollen Sie alle zugeordneten Partner entfernen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    For Each objDR_Partner In procT_ImageObjects_Of_Images.Rows
                        objSemItem_ImageObject.GUID = objDR_Partner.Item("GUID_Token_Right")
                        objSemItem_Result = objTransaction_ImagePerson.del_003_ImageObject_To_Object(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Persons.GUID, objSemItem_ImageObject)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_ImagePerson.del_002_ImageObject_To_Image
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_ImagePerson.del_001_ImageObject
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                    boolAddNoPerson = False
                                    MsgBox("Die Partner konnten nicht entfernt werden", MsgBoxStyle.Exclamation)
                                    Exit For
                                End If
                            Else
                                boolAddNoPerson = False
                                MsgBox("Die Partner konnten nicht entfernt werden", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Else
                            boolAddNoPerson = False
                            MsgBox("Die Partner konnten nicht entfernt werden", MsgBoxStyle.Exclamation)
                            Exit For
                        End If
                    Next
                Else
                    boolAddNoPerson = False
                End If
            End If

            If boolAddNoPerson = True Then
                objSemItem_ImageObject.GUID = Guid.NewGuid
                objSemItem_ImageObject.Name = objSemItem_Image.Name
                objSemItem_ImageObject.GUID_Parent = objLocalConfig.SemItem_Type_Image_Objects.GUID
                objSemItem_ImageObject.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Result = objTransaction_ImagePerson.save_001_ImageObject(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImagePerson.save_002_ImageObject_To_Image(objSemItem_Image)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_ImagePerson.save_004_noObjects(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Persons, objSemItem_ImageObject)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objTransaction_ImagePerson.del_002_ImageObject_To_Image
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_ImagePerson.del_001_ImageObject()
                            End If


                            MsgBox("Die Markierung, dass das Bild keine Personen enthält, kann nicht erzeugt werden.", MsgBoxStyle.Information)
                            ToolStripButton_NoPersons.Checked = False
                        End If
                    Else
                        objTransaction_ImagePerson.del_001_ImageObject()

                        MsgBox("Die Markierung, dass das Bild keine Personen enthält, kann nicht erzeugt werden.", MsgBoxStyle.Information)
                        ToolStripButton_NoPersons.Checked = False
                    End If
                Else
                    MsgBox("Die Markierung, dass das Bild keine Personen enthält, kann nicht erzeugt werden.", MsgBoxStyle.Information)
                    ToolStripButton_NoPersons.Checked = False
                End If

            End If
        Else
            objDRs_Partners = procT_ImageObjects_Of_Images.Select("GUID_Partner='" & objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Persons.GUID.ToString & "'")
            If objDRs_Partners.Count > 0 Then
                objSemItem_ImageObject.GUID = objDRs_Partners(0).Item("GUID_Token_Right")
                objSemItem_Result = objTransaction_ImagePerson.del_004_noObjects(objSemItem_ImageObject)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_ImagePerson.del_003_ImageObject_To_Object(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Persons.GUID)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_ImagePerson.del_002_ImageObject_To_Image
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_ImagePerson.del_001_ImageObject
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then

                                MsgBox("Die Markierung, dass das Bild keine Personen enthält, kann nicht entfernt werden.", MsgBoxStyle.Information)
                                ToolStripButton_NoPersons.Checked = True
                            End If
                        Else
                            MsgBox("Die Markierung, dass das Bild keine Personen enthält, kann nicht entfernt werden.", MsgBoxStyle.Information)
                            ToolStripButton_NoPersons.Checked = True
                        End If
                    Else
                        MsgBox("Die Markierung, dass das Bild keine Personen enthält, kann nicht entfernt werden.", MsgBoxStyle.Information)
                        ToolStripButton_NoPersons.Checked = True
                    End If
                Else
                    MsgBox("Die Markierung, dass das Bild keine Personen enthält, kann nicht entfernt werden.", MsgBoxStyle.Information)
                    ToolStripButton_NoPersons.Checked = True
                End If
            End If

        End If
        
    End Sub

    Private Sub ToolStripButton_FromList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_FromList.Click

    End Sub
End Class
