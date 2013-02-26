Public Class UserControl_ClassAttributeTypes

    Private objLocalConfig As clsLocalConfig

    Private objDlg_Attribute_Long As dlg_Attribute_Long

    Private objFrmMain As frmMain

    Private objOItem_Class As clsOntologyItem

    Private objDBLevel As clsDBLevel

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal oItem_Class As clsOntologyItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        objOItem_Class = oItem_Class

        set_DBConnection()

        initialize()
    End Sub

    Private Sub initialize()
        get_Data_AttributeTypes()
    End Sub

    Private Sub get_Data_AttributeTypes()
        Dim objList_Classes As New List(Of clsOntologyItem)
        objList_Classes.Add(objOItem_Class)
        objDBLevel.get_Data_ClassAtt(objList_Classes, Nothing, True, False)

        BindingSource_AttributeTypes.DataSource = objDBLevel.tbl_ClassAtt
        DataGridView_AttributeTypes.DataSource = BindingSource_AttributeTypes

        DataGridView_AttributeTypes.Columns(0).Visible = False
        DataGridView_AttributeTypes.Columns(1).Visible = False
        DataGridView_AttributeTypes.Columns(2).Visible = False
    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)
    End Sub

    Private Sub ToolStripButton_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Add.Click
        Dim objOItem_Result As clsOntologyItem
        objFrmMain = New frmMain(objLocalConfig, objLocalConfig.Globals.Type_AttributeType)
        objFrmMain.Applyable = True
        objFrmMain.ShowDialog(Me)
        If objFrmMain.DialogResult = DialogResult.OK Then
            If objFrmMain.Type_Applied = objLocalConfig.Globals.Type_AttributeType Then
                objOItem_Result = objDBLevel.save_ClassAttType(objOItem_Class, objFrmMain.OList_Simple, 1, 1)
                If Not objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                    MsgBox("Beim Speichern ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)

                End If
                get_Data_AttributeTypes()
            Else
                MsgBox("Bitte nur Attributtypen auswählen!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub ToolStripButton_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Del.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim oItem_AttType As New clsOntologyItem
        Dim objOItem_Result As clsOntologyItem
        Dim intToDo As Integer
        Dim intDone As Integer
        Dim intRelated As Integer

        intToDo = DataGridView_AttributeTypes.SelectedRows.Count
        intDone = 0
        intRelated = 0

        For Each objDGVR_Selected In DataGridView_AttributeTypes.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            oItem_AttType.GUID = objDRV_Selected.Item("ID_AttributeType")
            oItem_AttType.Type = objLocalConfig.Globals.Type_AttributeType

            objOItem_Result = objDBLevel.del_ClassAttType(objOItem_Class, oItem_AttType)
            Select Case objOItem_Result.GUID
                Case objLocalConfig.Globals.LState_Success.GUID
                    intDone = intDone + 1
                Case objLocalConfig.Globals.LState_Relation.GUID
                    intRelated = intRelated + 1
            End Select
        Next

        If intDone < intToDo Then
            If intRelated > 0 Then
                MsgBox(intRelated & " Beziehungen konnten nicht gelöscht werden, weil noch Objekte vorhanden sind, die diese Beziehungen ausprägen", MsgBoxStyle.Exclamation)

            End If
            If intDone + intRelated < intToDo Then
                MsgBox("Beim Löschen von " & intToDo - intRelated - intDone & " Beziehungen ist ein Fehler aufgetreten!", MsgBoxStyle.Critical)
            End If
        End If

        get_Data_AttributeTypes()
    End Sub

    Private Sub DataGridView_AttributeTypes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_AttributeTypes.CellDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objOItem_Class_Left As New clsOntologyItem
        Dim objOItem_AttributeType As New clsOntologyItem
        Dim objOList_AttType As New List(Of clsOntologyItem)
        Dim objOItem_Result As clsOntologyItem
        Dim lngValue As Long
        Dim lngMin_forw As Long
        Dim lngMax_forw As Long

        If DataGridView_AttributeTypes.Columns(e.ColumnIndex).DataPropertyName = objLocalConfig.Globals.Field_Min_forw Or _
           DataGridView_AttributeTypes.Columns(e.ColumnIndex).DataPropertyName = objLocalConfig.Globals.Field_Max_forw Then


            objDGVR_Selected = DataGridView_AttributeTypes.Rows(e.RowIndex)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objDlg_Attribute_Long = New dlg_Attribute_Long(objLocalConfig.Globals.Field_OrderID, objLocalConfig, objDRV_Selected.Item(objLocalConfig.Globals.Field_Min_forw))
            objDlg_Attribute_Long.ShowDialog(Me)
            If objDlg_Attribute_Long.DialogResult = DialogResult.OK Then
                lngValue = objDlg_Attribute_Long.Value

                objOItem_Result = objLocalConfig.Globals.LState_Error
                Select Case DataGridView_AttributeTypes.Columns(e.ColumnIndex).DataPropertyName
                    Case objLocalConfig.Globals.Field_Min_forw

                        lngMax_forw = objDRV_Selected.Item("Max_forw")
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

                    
                End Select

                objOItem_Class.GUID = objDRV_Selected.Item("ID_Class")
                objOItem_Class.Type = objLocalConfig.Globals.Type_Class

                objOItem_AttributeType.GUID = objDRV_Selected.Item("ID_AttributeType")
                objOItem_AttributeType.Type = objLocalConfig.Globals.Type_AttributeType

                
                If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                    objOList_AttType.Add(objOItem_AttributeType)
                    objOItem_Result = objDBLevel.save_ClassAttType(objOItem_Class, _
                                                           objOList_AttType, _
                                                           lngMin_forw, _
                                                           lngMax_forw)
                End If


                If Not objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                    MsgBox("Die Beziehung konnte nicht geändert werden!", MsgBoxStyle.Exclamation)
                End If

                get_Data_AttributeTypes()
            End If
        End If
    End Sub
End Class
