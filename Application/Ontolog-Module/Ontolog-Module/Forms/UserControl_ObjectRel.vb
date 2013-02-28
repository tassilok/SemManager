Public Class UserControl_ObjectRel

    Private objLocalConfig As clsLocalConfig

    Private objOList_Object As List(Of clsOntologyItem)
    Private objOList_Class_LeftRight As List(Of clsOntologyItem)
    Private objOList_RelationType_LeftRight As List(Of clsOntologyItem)
    Private objOList_ClassRel_LeftRight As List(Of clsClassRel)
    Private objOList_Class_RightLeft As List(Of clsOntologyItem)
    Private objOList_RelationType_RightLeft As List(Of clsOntologyItem)
    Private objOList_ClassRel_RightLeft As List(Of clsClassRel)

    Private objDBLevel_ObjRel As clsDBLevel

    Private objOItem_Object As clsOntologyItem
    Private objOItem_Other As clsOntologyItem
    Private objOItem_RelationType As clsOntologyItem

    Private objThread As Threading.Thread
    Private boolDataDone As Boolean

    Private strTokRelFilter As String

    Public Event selected_Left(ByVal oItem_Left As clsOntologyItem)
    Public Event selected_Right(ByVal oItem_Right As clsOntologyItem)
    Public Event selected_RelationType(ByVal oItem_RelationType As clsOntologyItem)
    Public Event related_Items()

    Public Sub applied_Object(ByVal oList_Objects As List(Of clsOntologyItem))
        Dim l As Long

        For l = 0 To oList_Objects.Count - 1
            objOItem_Other = oList_Objects(l)
            save_Relation()
        Next
        initialize_Data()
    End Sub

    Public Sub applied_RelType(ByVal oItem_RelType As clsOntologyItem)
        objOItem_RelationType = oItem_RelType
        save_Relation()
        initialize_Data()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Public Sub initialize_RelList(ByVal OList_Object As List(Of clsOntologyItem), _
                                  ByVal OList_Class_LeftRight As List(Of clsOntologyItem), _
                                  ByVal OList_RelationType_LeftRight As List(Of clsOntologyItem), _
                                  ByVal OList_ClassRel_LeftRight As List(Of clsClassRel), _
                                  ByVal OList_Class_RightLeft As List(Of clsOntologyItem), _
                                  ByVal OList_RelationType_RightLeft As List(Of clsOntologyItem), _
                                  ByVal OList_ClassRel_RightLeft As List(Of clsClassRel))



        objOList_Class_LeftRight = OList_Class_LeftRight
        objOList_Class_RightLeft = OList_Class_RightLeft
        objOList_ClassRel_LeftRight = OList_ClassRel_LeftRight
        objOList_ClassRel_RightLeft = OList_ClassRel_RightLeft
        objOList_Object = OList_Object
        objOItem_Object = objOList_Object(0)
        objOList_RelationType_LeftRight = OList_RelationType_LeftRight
        objOList_RelationType_RightLeft = OList_RelationType_RightLeft

        
        initialize_Data()
    End Sub

    Private Sub initialize_Data()
        BindingSource_ObjectRel.DataSource = Nothing
        DataGridView_Relations.DataSource = Nothing


        Try
            objThread.Abort()
        Catch ex As Exception

        End Try

        boolDataDone = False
        objThread = New Threading.Thread(AddressOf get_Data)
        Timer_TokenRelation.Stop()
        Timer_TokenRelation.Start()

        objThread.Start()
    End Sub

    Private Sub get_Data()

        objDBLevel_ObjRel.get_Data_ObjectRel(objOList_Object, Nothing, Nothing, True, False)

        boolDataDone = True

    End Sub

    Private Sub set_DBConnection()
        objDBLevel_ObjRel = New clsDBLevel(objLocalConfig)
    End Sub

    Private Sub Timer_TokenRelation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_TokenRelation.Tick
        If boolDataDone = True Then
            Timer_TokenRelation.Stop()
            BindingSource_ObjectRel.DataSource = objDBLevel_ObjRel.tbl_ObjectRelation
            DataGridView_Relations.DataSource = BindingSource_ObjectRel
            DataGridView_Relations.Columns(0).Visible = False
            DataGridView_Relations.Columns(1).Visible = False
            DataGridView_Relations.Columns(2).Visible = False
            DataGridView_Relations.Columns(3).Visible = False
            DataGridView_Relations.Columns(4).Visible = False
            DataGridView_Relations.Columns(7).Visible = False
            DataGridView_Relations.Columns(9).Visible = False
            'DataGridView_Relations.Columns(12).Visible = False
            ToolStripProgressBar_TokenRelation.Value = 0
        Else
            ToolStripProgressBar_TokenRelation.Value = 50
        End If
    End Sub

    Private Sub DataGridView_Relations_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView_Relations.MouseDoubleClick

    End Sub

    Private Sub DataGridView_Relations_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridView_Relations.Paint

    End Sub

    

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim oList_Relation As New List(Of clsOntologyItem)
        Dim objOItem_Result As clsOntologyItem

        For Each objDGVR_Selected In DataGridView_Relations.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            oList_Relation.Add(New clsOntologyItem(objDRV_Selected.Item("ID_Object"), _
                                                   objDRV_Selected.Item("ID_RelationType"), _
                                                   objDRV_Selected.Item("ID_Other"), _
                                                   0, _
                                                   objLocalConfig.Globals.Type_ObjectRel))


        Next

        objOItem_Result = objDBLevel_ObjRel.del_ObjectRel(oList_Relation)

        If objOItem_Result.GUID = objLocalConfig.Globals.LState_Error.GUID Then
            MsgBox("Es konnten nicht alle Beziehungen gelöscht werden!", MsgBoxStyle.Information)
        End If

        initialize_Data()
    End Sub

    Private Sub ContextMenuStrip_TokRel_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_TokRel.Opening
        Dim strHeaderText As String

        EditToolStripMenuItem.Enabled = False
        CopyValToolStripMenuItem1.Enabled = False
        SetOrderIDToolStripMenuItem.Enabled = False
        SetRelationTypeToolStripMenuItem.Enabled = False
        ModuleMenuToolStripMenuItem.Enabled = False
        ModuleEditToolStripMenuItem.Enabled = False


        ClearFilterToolStripMenuItem.Enabled = False
        EqualToolStripMenuItem.Enabled = False
        DifferentToolStripMenuItem.Enabled = False
        ContainsToolStripMenuItem.Enabled = False
        ClearFilterToolStripMenuItem.Enabled = False
        GreaterToolStripMenuItem.Enabled = False
        LessThanToolStripMenuItem.Enabled = False
        RelateToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False

        If DataGridView_Relations.SelectedRows.Count > 0 Then
            FilterToolStripMenuItem.Enabled = True
            EditToolStripMenuItem.Enabled = True
            SetRelationTypeToolStripMenuItem.Enabled = True
        End If
        If DataGridView_Relations.SelectedCells.Count >= 1 Then
            strHeaderText = DataGridView_Relations.Columns(DataGridView_Relations.SelectedCells(0).ColumnIndex).HeaderText
            If Not (strHeaderText = "OrderID") Then
                ContainsToolStripMenuItem.Enabled = True
            ElseIf strHeaderText = "OrderID" Then
                GreaterToolStripMenuItem.Enabled = True
                LessThanToolStripMenuItem.Enabled = True
                SetOrderIDToolStripMenuItem.Enabled = True
            End If
            EqualToolStripMenuItem.Enabled = True
            DifferentToolStripMenuItem.Enabled = True
            DeleteToolStripMenuItem.Enabled = True



        End If
        If DataGridView_Relations.SelectedRows.Count = 1 Then
            EditToolStripMenuItem.Enabled = True
            SetOrderIDToolStripMenuItem.Enabled = True
            SetRelationTypeToolStripMenuItem.Enabled = True
            ModuleMenuToolStripMenuItem.Enabled = True
            ModuleEditToolStripMenuItem.Enabled = True
        End If

        If DataGridView_Relations.SelectedCells.Count = 1 Then
            EditToolStripMenuItem.Enabled = True
            CopyValToolStripMenuItem1.Enabled = True

        End If
        If strTokRelFilter <> "" Then
            ClearFilterToolStripMenuItem.Enabled = True
        End If

        If Not objOItem_Object Is Nothing Then
            RelateToolStripMenuItem.Enabled = True
        End If


    End Sub

    Private Sub filter_ObjRel(ByVal strOperator As String, Optional ByVal strValue As String = "")
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDGVC_Selected As DataGridViewCell
        Dim objDGVCO_Selected As DataGridViewColumn

        objDGVC_Selected = DataGridView_Relations.SelectedCells(0)

        objDGVR_Selected = DataGridView_Relations.Rows(objDGVC_Selected.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objDGVCO_Selected = DataGridView_Relations.Columns(objDGVC_Selected.ColumnIndex)

        strTokRelFilter = BindingSource_ObjectRel.Filter

        Select Case objDGVCO_Selected.HeaderText

            Case "Name_Object"
                If Not (strOperator = "<" Or strOperator = ">") Then
                    If strTokRelFilter <> "" Then
                        strTokRelFilter = strTokRelFilter & " AND "
                    End If
                    If strOperator = "NOT" Then
                        strTokRelFilter = strTokRelFilter & " NOT "
                        strOperator = "="
                    End If
                    If Not strOperator = "LIKE" Then
                        strTokRelFilter = strTokRelFilter & "Name_Object " & strOperator & " '" & objDRV_Selected.Item("Name_Object") & "'"
                    Else
                        strTokRelFilter = strTokRelFilter & "Name_Object LIKE '%" & strValue.Replace("'", "''") & "%'"
                    End If

                End If


            Case "Name_RelationType"
                If Not (strOperator = "<" Or strOperator = ">") Then
                    If strTokRelFilter <> "" Then
                        strTokRelFilter = strTokRelFilter & " AND "
                    End If
                    If strOperator = "NOT" Then
                        strTokRelFilter = strTokRelFilter & " NOT "
                        strOperator = "="
                    End If
                    If Not strOperator = "LIKE" Then
                        strTokRelFilter = strTokRelFilter & "GUID_RelationType " & strOperator & " '" & objDRV_Selected.Item("GUID_RelationType").ToString & "'"
                    Else
                        strTokRelFilter = strTokRelFilter & "Name_RelationType LIKE '%" & strValue.Replace("'", "''") & "%'"
                    End If

                End If


            Case "Name_Other"
                If Not (strOperator = "<" Or strOperator = ">") Then
                    If strTokRelFilter <> "" Then
                        strTokRelFilter = strTokRelFilter & " AND "
                    End If
                    If strOperator = "NOT" Then
                        strTokRelFilter = strTokRelFilter & " NOT "
                        strOperator = "="
                    End If
                    If Not strOperator = "LIKE" Then
                        strTokRelFilter = strTokRelFilter & "Name_Other " & strOperator & " '" & objDRV_Selected.Item("Name_Other") & "'"
                    Else
                        strTokRelFilter = strTokRelFilter & "Name_Other LIKE '%" & strValue.Replace("'", "''") & "%'"
                    End If

                End If


            Case "Name_Parent_Other"
                If Not (strOperator = "<" Or strOperator = ">") Then
                    If strTokRelFilter <> "" Then
                        strTokRelFilter = strTokRelFilter & " AND "
                    End If
                    If strOperator = "NOT" Then
                        strTokRelFilter = strTokRelFilter & " NOT "
                        strOperator = "="
                    End If
                    If Not strOperator = "LIKE" Then
                        strTokRelFilter = strTokRelFilter & "GUID_Parent_Other " & strOperator & " '" & objDRV_Selected.Item("GUID_Parent_Other").ToString & "'"
                    Else
                        strTokRelFilter = strTokRelFilter & "Name_Parent_Other LIKE '%" & strValue.Replace("'", "''") & "%'"
                    End If

                End If

            Case "OrderID"
                If Not strOperator = "LIKE" Then
                    If strTokRelFilter <> "" Then
                        strTokRelFilter = strTokRelFilter & " AND "
                    End If
                    If strOperator = "NOT" Then
                        strTokRelFilter = strTokRelFilter & " NOT "
                        strOperator = "="
                    End If
                    strTokRelFilter = strTokRelFilter & "OrderID " & strOperator & " " & objDRV_Selected.Item("OrderID") & ""
                End If

        End Select

        BindingSource_ObjectRel.Filter = strTokRelFilter
        ToolStripLabel_Filter.Text = strTokRelFilter
        ToolStripLabel_RelCount.Text = DataGridView_Relations.Rows.Count
    End Sub

    Private Sub EqualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EqualToolStripMenuItem.Click
        filter_ObjRel("=")
    End Sub

    Private Sub DifferentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DifferentToolStripMenuItem.Click
        filter_ObjRel("NOT")
    End Sub

    Private Sub ContainsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContainsToolStripMenuItem.Click
        Dim strValue As String
        If Not ToolStripTextBox_TokRelContains.Text = "" Then
            strValue = ToolStripTextBox_TokRelContains.Text
            filter_ObjRel("LIKE", strValue)
        Else
            MsgBox("Bitte einen Suchstring eineben!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub GreaterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreaterToolStripMenuItem.Click
        filter_ObjRel(">")
    End Sub

    Private Sub LessThanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LessThanToolStripMenuItem.Click
        filter_ObjRel("<")
    End Sub

    Private Sub ClearFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFilterToolStripMenuItem.Click
        BindingSource_ObjectRel.Filter = ""
        strTokRelFilter = BindingSource_ObjectRel.Filter

        ToolStripLabel_Filter.Text = ""
        ToolStripLabel_RelCount.Text = DataGridView_Relations.Rows.Count
    End Sub

    Private Sub RelateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelateToolStripMenuItem.Click
        objOItem_Other = Nothing

        save_Relation()
        initialize_Data()
    End Sub
    Private Function save_Relation() As clsOntologyItem
        Dim objOItem_Result As clsOntologyItem
        Dim objOItem_ForListRelation As New clsOntologyItem
        Dim objOList_Right As New List(Of clsOntologyItem)
        Dim objOItem_Right As clsOntologyItem
        Dim objOItem_Clipboard As clsOntologyItem
        Dim oList_ObjRel As New List(Of clsObjectRel)

        objOItem_Result = objLocalConfig.Globals.LState_Success


        If Not objOItem_Object Is Nothing Then
            objOItem_ForListRelation.GUID = objOItem_Object.GUID
            objOItem_ForListRelation.Name = objOItem_Object.Name
            objOItem_ForListRelation.GUID_Parent = objOItem_Object.GUID_Parent
            objOItem_ForListRelation.Type = objLocalConfig.Globals.Type_Object
            objOItem_ForListRelation.Direction = objOItem_ForListRelation.Direction_RightLeft

            'objUserControl_SemItemList_TokenLis.SemItem_Other = objSemItem_ForListRelation

            RaiseEvent selected_Left(objOItem_Object)

        Else
            RaiseEvent selected_Left(Nothing)

            objOItem_Result = objLocalConfig.Globals.LState_Nothing
        End If


        If Not objOItem_Other Is Nothing Then
            RaiseEvent selected_Right(objOItem_Other)

        Else

            If Not objOItem_Clipboard Is Nothing Then
                
            End If
            If Not objOItem_Other Is Nothing Then
                RaiseEvent selected_Right(objOItem_Other)
            Else
                RaiseEvent selected_Right(nothing)
                objOItem_Result = objLocalConfig.Globals.LState_Nothing
            End If

        End If

        If Not objOItem_RelationType Is Nothing Then
            RaiseEvent selected_RelationType(objOItem_RelationType)
        Else
            RaiseEvent selected_RelationType(Nothing)
            objOItem_Result = objLocalConfig.Globals.LState_Nothing
        End If

        If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
            objOList_Right.Add(New clsOntologyItem(objOItem_Other.GUID, objOItem_Other.Name, objOItem_Other.GUID_Parent, objOItem_Other.Type))
            For Each objOItem_Right In objOList_Right
                oList_ObjRel.Add(New clsObjectRel(objOItem_Object.GUID, _
                                                  objOItem_Object.GUID_Parent, _
                                                  objOItem_Right.GUID, _
                                                  objOItem_Right.GUID_Parent, _
                                                  objOItem_RelationType.GUID, _
                                                  objLocalConfig.Globals.Type_Object, _
                                                  Nothing, _
                                                  1))
            Next

            If oList_ObjRel.Count > 0 Then
                objOItem_Result = objDBLevel_ObjRel.save_ObjRel(oList_ObjRel)
            End If

            If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                RaiseEvent related_Items()

                objOItem_Other = Nothing
                save_Relation()
            Else
                objOItem_Result = objLocalConfig.Globals.LState_Nothing
            End If
        End If
        Return objOItem_Result
    End Function
End Class
