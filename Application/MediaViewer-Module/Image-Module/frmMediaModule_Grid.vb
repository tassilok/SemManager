Imports Sem_Manager
Public Class frmMediaModule_Grid
    Private objLocalConfig As clsLocalConfig

    Private procA_ImageObjects_Of_Images As New ds_ImageModuleTableAdapters.proc_ImageObjects_Of_ImagesTableAdapter
    Private procT_ImageObjects_Of_Images As New ds_ImageModule.proc_ImageObjects_Of_ImagesDataTable

    Private WithEvents objUserControl_SemItemList As UserControl_SemItemList
    Private WithEvents objUserControl_EditImage As UserControl_EditImage

    Private objFrmSemManager As frmSemManager

    Private objSemItem_MediaType As clsSemItem
    Private boolColor(5) As Boolean

    Private Sub select_Item() Handles objUserControl_SemItemList.Selection_Changed
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Item As New clsSemItem
        objUserControl_EditImage.configure_Controls(False)
        If objUserControl_SemItemList.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_SemItemList.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Item.GUID = objDRV_Selected.Item("GUID_Token")
            objSemItem_Item.Name = objDRV_Selected.Item("Name_Token")
            objSemItem_Item.GUID_Parent = objDRV_Selected.Item("GUID_Type")
            objSemItem_Item.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Select Case objSemItem_Item.GUID_Parent
                Case objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                    objUserControl_EditImage.initialize(objSemItem_Item)
                Case objLocalConfig.SemItem_Type_PDF_Documents.GUID
                Case objLocalConfig.SemItem_Type_Media_Item.GUID

            End Select

        End If
    End Sub

    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Close()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_MediaType As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        objSemItem_MediaType = SemItem_MediaType
        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        Select Case objSemItem_MediaType.GUID
            Case objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                objUserControl_EditImage = New UserControl_EditImage(objLocalConfig)
                objUserControl_EditImage.Dock = DockStyle.Fill
                SplitContainer1.Panel2.Controls.Add(objUserControl_EditImage)
            Case objLocalConfig.SemItem_Type_PDF_Documents.GUID
            Case objLocalConfig.SemItem_Type_Media_Item.GUID

        End Select
        

        objUserControl_SemItemList = New UserControl_SemItemList()
        objUserControl_SemItemList.Dock = Windows.Forms.DockStyle.Fill
        SplitContainer1.Panel1.Controls.Add(objUserControl_SemItemList)

        objUserControl_SemItemList.initialize_Simple(objSemItem_MediaType, objLocalConfig.Globals)
    End Sub

    Private Sub set_DBConnection()
        procA_ImageObjects_Of_Images.Connection = objLocalConfig.Connection_Plugin
    End Sub

 

    Private Sub ToolStripButton_FilterItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_FilterItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objParams(3) As clsDBParameter
        Dim strProcedure As String
        Dim strDatabase As String
        Dim strServer As String

        objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)
        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    Select Case objDRV_Selected.Item("GUID_Type")
                        Case objLocalConfig.SemItem_Type_Partner.GUID
                            strProcedure = "proc_Images_Of_Partner"
                            strDatabase = "sem_db_home_mediaviewer_module"
                            strServer = "VAIPO"

                            objParams(0) = New clsDBParameter
                            objParams(0).Name_Parameter = "@GUID_Partner"
                            objParams(0).isString = True
                            objParams(0).Value_Parameter = objDRV_Selected.Item("GUID_Token").ToString

                            objParams(1) = New clsDBParameter
                            objParams(1).Name_Parameter = "@GUID_Type_Partner"
                            objParams(1).isString = True
                            objParams(1).Value_Parameter = objLocalConfig.SemItem_Type_Partner.GUID.ToString

                            objParams(2) = New clsDBParameter
                            objParams(2).Name_Parameter = "@GUID_RelationType_is"
                            objParams(2).isString = True
                            objParams(2).Value_Parameter = objLocalConfig.SemItem_RelationType_is.GUID.ToString

                            objParams(3) = New clsDBParameter
                            objParams(3).Name_Parameter = "@GUID_RelationType_locatedIn"
                            objParams(3).isString = True
                            objParams(3).Value_Parameter = objLocalConfig.SemItem_RelationType_located_in.GUID.ToString

                            objUserControl_SemItemList.filter_View_By_List(strProcedure, strDatabase, strServer, objParams)

                        Case objLocalConfig.SemItem_Type_Ort.GUID

                        Case Else

                    End Select
                    
                Else
                    MsgBox("Bitte nur ein zulässiges Token auswählen!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte nur zulässige Token auswählen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub ToolStripButton_ToNext_Colored_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ToNext_Colored.Click
        objUserControl_SemItemList.toNext_Colored(Color.Green)
    End Sub

    
    Private Sub ToolStripButton_ToNext_NoColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_ToNext_NoColor.Click
        objUserControl_SemItemList.toNext_Colored(Nothing)
    End Sub

    Private Sub frmMediaModule_Grid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MarkPersonsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarkPersonsToolStripMenuItem.Click
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim objDRs_NoPartners() As DataRow
        Dim objFColor As Color
        Dim objBColor As Color


        If boolColor(0) = False Then
            objFColor = Color.White
            objBColor = Color.Green
            boolColor(0) = True
        ElseIf boolColor(1) = False Then
            objFColor = Color.Black
            objBColor = Color.LightGreen
            boolColor(1) = True
        ElseIf boolColor(2) = False Then
            objFColor = Color.White
            objBColor = Color.Blue
            boolColor(2) = True
        ElseIf boolColor(3) = False Then
            objFColor = Color.Black
            objBColor = Color.LightBlue
            boolColor(3) = True
        ElseIf boolColor(4) = False Then
            objFColor = Color.Black
            objBColor = Color.Beige
            boolColor(4) = True
        ElseIf boolColor(5) = False Then
            objFColor = Color.Black
            objBColor = Color.Yellow
            boolColor(5) = True
        End If

        procA_ImageObjects_Of_Images.Fill(procT_ImageObjects_Of_Images, _
                                          objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                          objLocalConfig.SemItem_Type_Partner.GUID, _
                                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                          objLocalConfig.SemItem_RelationType_is.GUID, _
                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                          objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Persons.GUID, _
                                          Nothing)

        For Each objDGVR In objUserControl_SemItemList.DataGridViewRows
            objDRV = objDGVR.DataBoundItem

            objDRs_NoPartners = procT_ImageObjects_Of_Images.Select("GUID_Token_Right='" & objDRV.Item("GUID_Token").ToString & "'")
            If objDRs_NoPartners.Count > 0 Then
                If objDGVR.Cells(0).Style.BackColor.Name = "0" Then
                    objUserControl_SemItemList.mark_RowCell(objDGVR.Index, objFColor, objBColor)
                End If

            End If
        Next
    End Sub

    Private Sub MarkNoPersonsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarkNoPersonsToolStripMenuItem.Click
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim objDRs_NoPartners() As DataRow
        Dim objFColor As Color
        Dim objBColor As Color

        If boolColor(0) = False Then
            objFColor = Color.White
            objBColor = Color.Green
            boolColor(0) = True
        ElseIf boolColor(1) = False Then
            objFColor = Color.Black
            objBColor = Color.LightGreen
            boolColor(1) = True
        ElseIf boolColor(2) = False Then
            objFColor = Color.White
            objBColor = Color.Blue
            boolColor(2) = True
        ElseIf boolColor(3) = False Then
            objFColor = Color.Black
            objBColor = Color.LightBlue
            boolColor(3) = True
        ElseIf boolColor(4) = False Then
            objFColor = Color.Black
            objBColor = Color.Beige
            boolColor(4) = True
        ElseIf boolColor(5) = False Then
            objFColor = Color.Black
            objBColor = Color.Yellow
            boolColor(5) = True
        End If

        procA_ImageObjects_Of_Images.Fill(procT_ImageObjects_Of_Images, _
                                          objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                          objLocalConfig.SemItem_Type_Partner.GUID, _
                                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                          objLocalConfig.SemItem_RelationType_is.GUID, _
                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                          objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Persons.GUID, _
                                          Nothing)

        For Each objDGVR In objUserControl_SemItemList.DataGridViewRows
            objDRV = objDGVR.DataBoundItem

            objDRs_NoPartners = procT_ImageObjects_Of_Images.Select("GUID_Token_Right='" & objDRV.Item("GUID_Token").ToString & "' AND GUID_Partner='" & objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Persons.GUID.ToString & "'")
            If objDRs_NoPartners.Count > 0 Then
                If objDGVR.Cells(0).Style.BackColor.Name = "0" Then
                    objUserControl_SemItemList.mark_RowCell(objDGVR.Index, objFColor, objBColor)
                End If


            End If
        Next
    End Sub

    Private Sub MarkBuildingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarkBuildingsToolStripMenuItem.Click
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim objDRs_NoPartners() As DataRow
        Dim objFColor As Color
        Dim objBColor As Color

        If boolColor(0) = False Then
            objFColor = Color.White
            objBColor = Color.Green
            boolColor(0) = True
        ElseIf boolColor(1) = False Then
            objFColor = Color.Black
            objBColor = Color.LightGreen
            boolColor(1) = True
        ElseIf boolColor(2) = False Then
            objFColor = Color.White
            objBColor = Color.Blue
            boolColor(2) = True
        ElseIf boolColor(3) = False Then
            objFColor = Color.Black
            objBColor = Color.LightBlue
            boolColor(3) = True
        ElseIf boolColor(4) = False Then
            objFColor = Color.Black
            objBColor = Color.Beige
            boolColor(4) = True
        ElseIf boolColor(5) = False Then
            objFColor = Color.Black
            objBColor = Color.Yellow
            boolColor(5) = True
        End If

        procA_ImageObjects_Of_Images.Fill(procT_ImageObjects_Of_Images, _
                                          objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                          objLocalConfig.SemItem_Type_Bauwerke.GUID, _
                                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                          objLocalConfig.SemItem_RelationType_is.GUID, _
                                          objLocalConfig.SemItem_RelationType_has.GUID, _
                                          objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Buildings.GUID, _
                                          Nothing)

        For Each objDGVR In objUserControl_SemItemList.DataGridViewRows
            objDRV = objDGVR.DataBoundItem

            objDRs_NoPartners = procT_ImageObjects_Of_Images.Select("GUID_Token_Right='" & objDRV.Item("GUID_Token").ToString & "'")
            If objDRs_NoPartners.Count > 0 Then
                If objDGVR.Cells(0).Style.BackColor.Name = "0" Then
                    objUserControl_SemItemList.mark_RowCell(objDGVR.Index, objFColor, objBColor)
                End If

            End If
        Next
    End Sub

    Private Sub ClearMarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearMarkToolStripMenuItem.Click
        objUserControl_SemItemList.initialize_Simple(objSemItem_MediaType, objLocalConfig.Globals)
        boolColor(0) = False
        boolColor(1) = False
        boolColor(2) = False
        boolColor(3) = False
        boolColor(4) = False
        boolColor(5) = False

    End Sub
End Class
