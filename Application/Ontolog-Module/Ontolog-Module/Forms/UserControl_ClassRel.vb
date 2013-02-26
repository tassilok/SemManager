Public Class UserControl_ClassRel

    Private objLocalConfig As clsLocalConfig

    Private objFrmMain As frmMain

    Private objDBLevel As clsDBLevel

    Private objOItem_Class As clsOntologyItem

    Private objDlg_Attribute_Long As dlg_Attribute_Long

    Private boolObjectReference As Boolean
    Private objDirection As clsOntologyItem

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal oItem_Class As clsOntologyItem, ByVal Direction As clsOntologyItem, Optional ByVal is_ObjectReference As Boolean = False)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        objOItem_Class = oItem_Class

        boolObjectReference = is_ObjectReference
        objDirection = Direction

        set_DBConnection()

        initialize()
    End Sub

    Private Sub initialize()
        get_Data_ClassRelations()
    End Sub

    Private Sub get_Data_ClassRelations()
        Dim oList_Classes As New List(Of clsOntologyItem)


        DataGridView_Relations.DataSource = Nothing
        BindingSource_Relations.DataSource = Nothing

        oList_Classes.Clear()
        oList_Classes.Add(objOItem_Class)

        If boolObjectReference = False Then
            objDBLevel.get_Data_ClassRel(oList_Classes, objDirection, False, True)
        Else
            objDBLevel.get_Data_ClassRel(oList_Classes, objLocalConfig.Globals.Direction_LeftRight, False, True, True)
        End If


        BindingSource_Relations.DataSource = objDBLevel.tbl_ClassRelation
        DataGridView_Relations.DataSource = BindingSource_Relations

        If boolObjectReference = False Then
            If objDirection.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
                DataGridView_Relations.Columns(0).Visible = False
                DataGridView_Relations.Columns(1).Visible = False
                DataGridView_Relations.Columns(2).Visible = False
                DataGridView_Relations.Columns(4).Visible = False
                DataGridView_Relations.Columns(6).Visible = False
            Else
                DataGridView_Relations.Columns(0).Visible = False
                DataGridView_Relations.Columns(2).Visible = False
                DataGridView_Relations.Columns(3).Visible = False
                DataGridView_Relations.Columns(4).Visible = False
            End If
        Else
            DataGridView_Relations.Columns(0).Visible = False
            DataGridView_Relations.Columns(1).Visible = False
            DataGridView_Relations.Columns(2).Visible = False
            DataGridView_Relations.Columns(3).Visible = False
            DataGridView_Relations.Columns(4).Visible = False
            DataGridView_Relations.Columns(6).Visible = False
            DataGridView_Relations.Columns(8).Visible = False
        End If

        ToolStripLabel_Count.Text = DataGridView_Relations.RowCount
        
    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)
    End Sub


    Private Sub ToolStripButton_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Add.Click
        Dim oList_Class As List(Of clsOntologyItem)
        Dim oList_RelationType As List(Of clsOntologyItem)
        Dim objOItem_Result As clsOntologyItem

        objFrmMain = New frmMain(objLocalConfig, objLocalConfig.Globals.Type_Class)
        objFrmMain.Applyable = True
        objFrmMain.ShowDialog(Me)
        If objFrmMain.DialogResult = DialogResult.OK Then
            If objFrmMain.Type_Applied = objLocalConfig.Globals.Type_Class Then
                oList_Class = objFrmMain.OList_Simple
                If oList_Class.Count = 1 Then
                    objFrmMain = New frmMain(objLocalConfig, objLocalConfig.Globals.Type_RelationType)
                    objFrmMain.Applyable = True
                    objFrmMain.ShowDialog(Me)
                    If objFrmMain.DialogResult = DialogResult.OK Then
                        If objFrmMain.Type_Applied = objLocalConfig.Globals.Type_RelationType Then
                            oList_RelationType = objFrmMain.OList_Simple
                            If oList_RelationType.Count = 1 Then
                                If objDirection.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
                                    objOItem_Result = objDBLevel.save_ClassRel(objOItem_Class, oList_RelationType(0), 1, 1, -1, oList_Class(0))

                                Else
                                    objOItem_Result = objDBLevel.save_ClassRel(oList_Class(0), oList_RelationType(0), 1, 1, -1, objOItem_Class)
                                End If

                                If Not objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                                    MsgBox("Die Beziehung konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                Else
                                    get_Data_ClassRelations()
                                End If
                            Else
                                MsgBox("Bitte einen Beziehungstyp auswählen!", MsgBoxStyle.Information)
                            End If
                        Else
                            MsgBox("Bitte einen Beziehungstyp auswählen!", MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("Bitte einen Beziehungstyp auswählen!", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Bitte eine Klasse auswählen!", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Bitte eine Klasse auswählen!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub DataGridView_Relations_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Relations.CellDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objOItem_Class_Left As New clsOntologyItem
        Dim objOItem_Class_Right As New clsOntologyItem
        Dim objOItem_RelationType As New clsOntologyItem
        Dim objOItem_Result As clsOntologyItem
        Dim lngValue As Long
        Dim lngMin_forw As Long
        Dim lngMax_forw As Long
        Dim lngMax_backw As Long

        If DataGridView_Relations.Columns(e.ColumnIndex).DataPropertyName = objLocalConfig.Globals.Field_Min_forw Or _
           DataGridView_Relations.Columns(e.ColumnIndex).DataPropertyName = objLocalConfig.Globals.Field_Max_forw Or _
           DataGridView_Relations.Columns(e.ColumnIndex).DataPropertyName = objLocalConfig.Globals.Field_Max_backw Then


            objDGVR_Selected = DataGridView_Relations.Rows(e.RowIndex)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objDlg_Attribute_Long = New dlg_Attribute_Long(objLocalConfig.Globals.Field_OrderID, objLocalConfig, objDRV_Selected.Item(objLocalConfig.Globals.Field_Min_forw))
            objDlg_Attribute_Long.ShowDialog(Me)
            If objDlg_Attribute_Long.DialogResult = DialogResult.OK Then
                lngValue = objDlg_Attribute_Long.Value

                objOItem_Result = objLocalConfig.Globals.LState_Error
                Select Case DataGridView_Relations.Columns(e.ColumnIndex).DataPropertyName
                    Case objLocalConfig.Globals.Field_Min_forw

                        lngMax_forw = objDRV_Selected.Item("Max_forw")
                        lngMax_backw = objDRV_Selected.Item("Max_backw")
                        If (lngMax_forw >= lngValue Or lngMax_forw = -1) And _
                            lngValue >= 0 Then
                            lngMin_forw = lngValue
                            objOItem_Result = objLocalConfig.Globals.LState_Success
                        End If


                    Case objLocalConfig.Globals.Field_Max_forw
                        lngMin_forw = objDRV_Selected.Item("Min_forw")
                        If (lngValue = -1 Or lngValue >= lngMin_forw) And _
                            lngValue <> 0 Then
                            lngMax_forw = lngValue
                            objOItem_Result = objLocalConfig.Globals.LState_Success
                        End If

                        lngMax_backw = objDRV_Selected.Item("Max_backw")
                    Case objLocalConfig.Globals.Field_Max_backw
                        lngMin_forw = objDRV_Selected.Item("Min_forw")
                        lngMax_forw = objDRV_Selected.Item("Max_forw")
                        If lngValue = -1 Or lngValue > 0 Then
                            lngMax_backw = lngValue
                        End If

                End Select

                objOItem_Class_Left.GUID = objDRV_Selected.Item("ID_Class_Left")
                objOItem_Class_Left.Type = objLocalConfig.Globals.Type_Class

                objOItem_RelationType.GUID = objDRV_Selected.Item("ID_RelationType")
                objOItem_RelationType.Type = objLocalConfig.Globals.Type_RelationType

                If Not IsDBNull(objDRV_Selected.Item("ID_Class_Right")) Then
                    objOItem_Class_Right.GUID = objDRV_Selected.Item("ID_Class_Right")
                    objOItem_Class_Right.Type = objLocalConfig.Globals.Type_Class
                Else
                    objOItem_Class_Right = Nothing
                End If

                If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                    objOItem_Result = objDBLevel.save_ClassRel(objOItem_Class_Left, _
                                                           objOItem_RelationType, _
                                                           lngMin_forw, _
                                                           lngMax_forw, _
                                                           lngMax_backw, _
                                                           objOItem_Class_Right)
                End If
                

                If Not objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                    MsgBox("Die Beziehung konnte nicht geändert werden!", MsgBoxStyle.Exclamation)
                End If

                get_Data_ClassRelations()
            End If
        End If
    End Sub

    Private Sub ToolStripButton_Dell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Dell.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim oItem_Class_Left As New clsOntologyItem
        Dim oItem_Class_Right As New clsOntologyItem
        Dim oItem_RelationType As New clsOntologyItem

        For Each objDGVR_Selected In DataGridView_Relations.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            oItem_Class_Left.GUID = objDRV_Selected.Item("ID_Class_Left")

            If Not IsDBNull(objDRV_Selected.Item("ID_Class_Right")) Then

            End If


            objDBLevel.del_ClassRel(
        Next
    End Sub
End Class
