Public Class UserControl_ClassAttributeTypes

    Private objLocalConfig As clsLocalConfig

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
End Class
