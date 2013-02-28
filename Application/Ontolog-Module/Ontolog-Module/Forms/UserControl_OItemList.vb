Public Class UserControl_OItemList
    Private objLocalConfig As clsLocalConfig

    Private otblT_Objects As New DataSet_Config.otbl_ObjectsDataTable

    Private objDBLevel As clsDBLevel

    Private objFrm_Main As frmMain

    Private objTransaction_Objects As clsTransaction_Objects
    Private objTransaction_RelationTypes As clsTransaction_RelationTypes
    Private objTransaction_AttributeTypes As clsTransaction_AttributeTypes

    Private objOItem_Parent As clsOntologyItem

    Private objOItem_RelationType As clsOntologyItem
    Private objOItem_Other As clsOntologyItem
    Private objOItem_Object As clsOntologyItem

    Private objThread_List As Threading.Thread

    Private boolProgChange As Boolean

    Private strRowName_GUID As String
    Private strGUID_Class As String

    Private objOItem_Direction As clsOntologyItem

    Private oList_Selected_Simple As New List(Of clsOntologyItem)
    Private oList_Selected_ObjectRel As New List(Of clsObjectRel)

    Private objDlg_Attribute_Boolean As dlg_Attribute_Boolean
    Private objDlg_Attribute_DateTime As dlg_Attribute_DateTime
    Private objDlg_Attribute_Long As dlg_Attribute_Long
    Private objDlg_Attribute_Double As dlg_Attribute_Double
    Private objDlg_Attribute_String As dlg_Attribute_String

    Private boolOR As Boolean

    Private strName_Filter As String
    Private strGUID_Filter As String

    Private intRowID As Integer

    Private boolFinished As Boolean
    Private boolApplyable As Boolean

    Private strType As String

    Private Event selected_ListItem()

    Public Event Selection_Changed()
    Public Event edit_Object(ByVal strType As String, ByVal oItem_Direction As clsOntologyItem)

    Public Event applied_Items()


    Public ReadOnly Property OList_Simple As List(Of clsOntologyItem)
        Get
            Return oList_Selected_Simple
        End Get
    End Property

    Public ReadOnly Property OList_ObjectRel As List(Of clsObjectRel)
        Get
            Return oList_Selected_ObjectRel
        End Get
    End Property

    Public Property Applyable As Boolean
        Get
            Return boolApplyable
        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
        End Set
    End Property

    Public ReadOnly Property RowID As Integer
        Get
            Return intRowID
        End Get
    End Property

    Public ReadOnly Property DataGridviewRows As DataGridViewRowCollection
        Get
            Return DataGridView_Items.Rows
        End Get
    End Property

    Public ReadOnly Property DataGridViewRowCollection_Selected As DataGridViewSelectedRowCollection
        Get
            Return DataGridView_Items.SelectedRows
        End Get
    End Property

    Public Sub initialize(ByVal OItem_Parent As clsOntologyItem, Optional ByVal oItem_Object As clsOntologyItem = Nothing, Optional ByVal OItem_Direction As clsOntologyItem = Nothing, Optional ByVal OItem_Other As clsOntologyItem = Nothing, Optional ByVal OItem_RelType As clsOntologyItem = Nothing, Optional ByVal boolOR As Boolean = False)
        boolProgChange = True

        Me.boolOR = boolOR
        clear_Relation()
        strGUID_Class = Nothing

        If OItem_Direction Is Nothing Then
            If Not oItem_Object Is Nothing Then
                If oItem_Object.GUID <> "" Then
                    strGUID_Filter = oItem_Object.GUID
                ElseIf oItem_Object.Name <> "" Then
                    strGUID_Filter = oItem_Object.Name
                End If
            End If
            objOItem_Other = OItem_Other

            objOItem_Object = oItem_Object
            objOItem_RelationType = OItem_RelType
            objOItem_Parent = OItem_Parent


            If objOItem_Parent Is Nothing Then
                strType = OItem_Other.Type
            Else
                strType = objOItem_Parent.Type
            End If

        Else

            strType = objLocalConfig.Globals.Type_Other
            objOItem_Direction = OItem_Direction
            If objOItem_Direction.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
                If Not oItem_Object Is Nothing Then
                    If oItem_Object.GUID <> "" Then
                        strGUID_Filter = oItem_Object.GUID
                    ElseIf oItem_Object.Name <> "" Then
                        strGUID_Filter = oItem_Object.Name
                    End If
                End If
                objOItem_Other = OItem_Other

                objOItem_RelationType = OItem_RelType
                objOItem_Parent = OItem_Parent
            Else
                If Not OItem_Other Is Nothing Then
                    strGUID_Class = OItem_Other.GUID_Parent
                End If
                If Not oItem_Object Is Nothing Then
                    objOItem_Other = oItem_Object

                End If

                objOItem_Parent = OItem_Parent
                objOItem_RelationType = OItem_RelType
            End If

        End If



        ToolStripButton_AddItem.Visible = True
        ToolStripButton_DelItem.Visible = True
        ToolStripButton_Up.Visible = False
        ToolStripButton_Down.Visible = False
        ToolStripButton_Sort.Visible = False
        ToolStripButton_Report.Visible = True
        ToolStripTextBox_Filter.ReadOnly = True
        ToolStripTextBox_Filter.Text = ""
        ToolStripTextBox_Filter.ReadOnly = False

        configure_TabPages()

        boolProgChange = False
    End Sub

    Private Sub get_Data()
        Dim oList_Items As New List(Of clsOntologyItem)
        Dim oList_Other As New List(Of clsOntologyItem)
        Dim oList_RelType As New List(Of clsOntologyItem)

        If Not objOItem_Parent Is Nothing Then
            If objOItem_Parent.Type = objLocalConfig.Globals.Type_Object Then
                strGUID_Class = objOItem_Parent.GUID_Parent
            Else
                strGUID_Class = objOItem_Parent.GUID
            End If
            If boolOR = False Then
                Select Case objOItem_Parent.Type
                    Case objLocalConfig.Globals.Type_Object


                        oList_Items.Add(New clsOntologyItem(strGUID_Filter, strName_Filter, strGUID_Class, objLocalConfig.Globals.Type_Object))
                        objDBLevel.get_Data_Objects(oList_Items, True)
                        'objDBLevel.get_Data_Objects(oList_Items)



                    Case objLocalConfig.Globals.Type_RelationType
                        oList_Items.Add(New clsOntologyItem(strGUID_Filter, strName_Filter, objLocalConfig.Globals.Type_RelationType))
                        objDBLevel.get_Data_RelationTypes(oList_Items, True)

                    Case objLocalConfig.Globals.Type_AttributeType
                        oList_Items.Add(New clsOntologyItem(strGUID_Filter, strName_Filter, objLocalConfig.Globals.Type_AttributeType))
                        objDBLevel.get_Data_AttributeType(oList_Items, True)

                End Select
            Else

            End If


        Else
            If Not objOItem_Other Is Nothing Then
                Select Case objOItem_Other.Type



                    Case objLocalConfig.Globals.Type_RelationType
                        oList_Items.Add(New clsOntologyItem(strGUID_Filter, strName_Filter, objLocalConfig.Globals.Type_RelationType))
                        objDBLevel.get_Data_RelationTypes(oList_Items, True)

                    Case objLocalConfig.Globals.Type_AttributeType

                        objDBLevel.get_Data_ObjectAtt(objOItem_Object, objOItem_Other, True, False)

                    Case Else
                        oList_Other.Add(objOItem_Other)
                        oList_RelType.Add(objOItem_RelationType)

                        oList_Items.Add(New clsOntologyItem(strGUID_Filter, strName_Filter, strGUID_Class, objLocalConfig.Globals.Type_Object))
                        objDBLevel.get_Data_ObjectRel(oList_Items, oList_Other, oList_RelType, True, False)
                End Select
            Else
                oList_RelType.Add(objOItem_RelationType)
                oList_Items.Add(New clsOntologyItem(strGUID_Filter, strName_Filter, strGUID_Class, objLocalConfig.Globals.Type_Object))
                objDBLevel.get_Data_ObjectRel(oList_Items, Nothing, oList_RelType, True, False)
            End If
            

        End If
        boolFinished = True
    End Sub

    Private Sub configure_TabPages()

        Timer_List.Stop()
        Select Case TabControl1.SelectedTab.Name
            Case TabPage_List.Name
                Try
                    objThread_List.Abort()
                Catch ex As Exception

                End Try
                objThread_List = New Threading.Thread(AddressOf get_Data)
                boolFinished = False
                BindingSource_Attribute.DataSource = Nothing
                BindingSource_RelationType.DataSource = Nothing
                BindingSource_Token.DataSource = Nothing
                BindingSource_Type.DataSource = Nothing

                DataGridView_Items.DataSource = Nothing

                objThread_List.Start()
                Timer_List.Start

            Case TabPage_Tree.Name
                If Not objOItem_Parent Is Nothing Then
                    'objUserControl_TreeOfToken.initialize(objSemItem_Parent)
                End If
        End Select

    End Sub

    Private Sub clear_Relation()
        objOItem_Other = Nothing
        objOItem_RelationType = Nothing
        objOItem_Direction = Nothing
        strGUID_Filter = Nothing
        strName_Filter = Nothing
        ToolStripButton_Relate.Checked = False
        ToolStripButton_Relate.Enabled = False
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)
        objTransaction_Objects = New clsTransaction_Objects(objLocalConfig, Me)
        objTransaction_AttributeTypes = New clsTransaction_AttributeTypes(objLocalConfig, Me)
        objTransaction_RelationTypes = New clsTransaction_RelationTypes(objLocalConfig, Me)
    End Sub

    Private Sub DataGridView_Items_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Items.RowHeaderMouseDoubleClick

        intRowID = e.RowIndex
        RaiseEvent edit_Object(strType, objOItem_Direction)

    End Sub

    Private Sub DataGridView_Items_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Items.SelectionChanged
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView

        If DataGridView_Items.SelectedRows.Count = 1 Then

            objDGVR = DataGridView_Items.SelectedRows(0)
            objDRV = objDGVR.DataBoundItem
            ToolStripTextBox_GUID.Text = objDRV.Item(strRowName_GUID).ToString
            If boolProgChange = False Then
                RaiseEvent Selection_Changed()
            End If
        Else
            ToolStripTextBox_GUID.Clear()
        End If
        
    End Sub

    Private Sub ToolStripTextBox_Filter_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Filter.TextChanged
        If boolProgChange = False Then
            Timer_Filter.Stop()
            ToolStripButton_Filter.Checked = True
            Timer_Filter.Start()
        End If
    End Sub

    Private Sub Timer_Filter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Filter.Tick
        Timer_Filter.Stop()
        Filter_List()
    End Sub

    Private Sub Filter_List()
        If ToolStripButton_Filter.Checked = True Then
            strName_Filter = ToolStripTextBox_Filter.Text
            If objLocalConfig.Globals.is_GUID(strName_Filter) Then
                strGUID_Filter = strName_Filter
                strName_Filter = ""
            End If
        Else
            strGUID_Filter = ""
            strName_Filter = ""


        End If
        configure_TabPages()
    End Sub

    Private Sub ToolStripButton_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Filter.Click
        If ToolStripButton_Filter.Checked = True Then
            ToolStripButton_Filter.Checked = False
            ToolStripTextBox_Filter.Text = ""
        Else
            ToolStripButton_Filter.Checked = True
            Filter_List()
        End If

    End Sub

    Private Sub Timer_List_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_List.Tick

        If boolFinished = True Then
            Timer_List.Stop()
            If Not objOItem_Parent Is Nothing Then
                Select Case objOItem_Parent.Type
                    Case objLocalConfig.Globals.Type_Object

                        BindingSource_Token.DataSource = objDBLevel.tbl_Objects
                        DataGridView_Items.DataSource = BindingSource_Token
                        DataGridView_Items.Columns(0).Visible = False
                        DataGridView_Items.Columns(2).Visible = False
                        DataGridView_Items.Columns(1).Width = DataGridView_Items.Width - 20
                        ToolStripLabel_Count.Text = DataGridView_Items.RowCount
                        strRowName_GUID = "ID_Item"
                    Case objLocalConfig.Globals.Type_RelationType


                        BindingSource_RelationType.DataSource = objDBLevel.tbl_RelationTypes
                        DataGridView_Items.DataSource = BindingSource_RelationType
                        DataGridView_Items.Columns(0).Visible = False
                        DataGridView_Items.Columns(1).Width = DataGridView_Items.Width - 20
                        ToolStripLabel_Count.Text = DataGridView_Items.RowCount
                        strRowName_GUID = "ID_Item"
                    Case objLocalConfig.Globals.Type_AttributeType


                        BindingSource_Attribute.DataSource = objDBLevel.tbl_AttributeTypes
                        DataGridView_Items.DataSource = BindingSource_Attribute
                        DataGridView_Items.Columns(0).Visible = False
                        DataGridView_Items.Columns(1).Width = DataGridView_Items.Width - 20
                        ToolStripLabel_Count.Text = DataGridView_Items.RowCount
                        strRowName_GUID = "ID_Item"
                End Select


            Else
                BindingSource_TokenToken.DataSource = objDBLevel.tbl_ObjectRelation
                DataGridView_Items.DataSource = BindingSource_TokenToken
                Select Case strType
                    Case objLocalConfig.Globals.Type_Object

                        BindingSource_Token.DataSource = objDBLevel.tbl_Objects
                        DataGridView_Items.DataSource = BindingSource_Token
                        DataGridView_Items.Columns(0).Visible = False
                        DataGridView_Items.Columns(2).Visible = False
                        DataGridView_Items.Columns(1).Width = DataGridView_Items.Width - 20
                        ToolStripLabel_Count.Text = DataGridView_Items.RowCount
                        strRowName_GUID = "ID_Item"
                    Case objLocalConfig.Globals.Type_RelationType


                        BindingSource_RelationType.DataSource = objDBLevel.tbl_RelationTypes
                        DataGridView_Items.DataSource = BindingSource_RelationType
                        DataGridView_Items.Columns(0).Visible = False
                        DataGridView_Items.Columns(1).Width = DataGridView_Items.Width - 20
                        ToolStripLabel_Count.Text = DataGridView_Items.RowCount
                        strRowName_GUID = "ID_Item"
                    Case objLocalConfig.Globals.Type_AttributeType

                        BindingSource_Attribute.DataSource = objDBLevel.tbl_ObjectAttribute
                        DataGridView_Items.DataSource = BindingSource_Attribute
                        DataGridView_Items.Columns(0).Visible = False
                        DataGridView_Items.Columns(1).Visible = False
                        DataGridView_Items.Columns(2).Visible = False
                        DataGridView_Items.Columns(3).Visible = False
                        DataGridView_Items.Columns(4).Visible = False
                        DataGridView_Items.Columns(5).Visible = False
                        DataGridView_Items.Columns(6).Visible = False
                        DataGridView_Items.Columns(9).Visible = False
                        DataGridView_Items.Columns(10).Visible = False
                        DataGridView_Items.Columns(11).Visible = False
                        DataGridView_Items.Columns(12).Visible = False
                        DataGridView_Items.Columns(13).Visible = False
                        DataGridView_Items.Columns(14).Visible = False
                        DataGridView_Items.Columns(15).Visible = False

                        ToolStripLabel_Count.Text = DataGridView_Items.RowCount
                        strRowName_GUID = "ID_ObjectAttribute"
                    Case objLocalConfig.Globals.Type_Other
                        If objOItem_Direction.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
                            DataGridView_Items.Columns(0).Visible = False
                            DataGridView_Items.Columns(1).Visible = False
                            DataGridView_Items.Columns(2).Visible = False
                            DataGridView_Items.Columns(3).Visible = False
                            DataGridView_Items.Columns(4).Visible = False
                            DataGridView_Items.Columns(5).Visible = False
                            DataGridView_Items.Columns(7).Visible = False
                            DataGridView_Items.Columns(9).Visible = False
                            DataGridView_Items.Columns(10).Visible = False
                            DataGridView_Items.Columns(11).Visible = False
                        Else
                            DataGridView_Items.Columns(0).Visible = False
                            DataGridView_Items.Columns(2).Visible = False
                            DataGridView_Items.Columns(3).Visible = False
                            DataGridView_Items.Columns(4).Visible = False
                            DataGridView_Items.Columns(5).Visible = False
                            DataGridView_Items.Columns(7).Visible = False
                            DataGridView_Items.Columns(8).Visible = False
                            DataGridView_Items.Columns(9).Visible = False
                            DataGridView_Items.Columns(10).Visible = False
                            DataGridView_Items.Columns(11).Visible = False
                        End If
                End Select


                ToolStripLabel_Count.Text = DataGridView_Items.RowCount

            End If
            ToolStripProgressBar_List.Value = 0

        Else
            ToolStripProgressBar_List.Value = 50

        End If
    End Sub

    Private Sub ToolStripButton_AddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddItem.Click
        Dim objOItem_Result As clsOntologyItem
        Dim objOItem_Class As New clsOntologyItem
        Dim oList_Simple As List(Of clsOntologyItem)
        Dim oList_ObjRel As New List(Of clsObjectRel)
        Dim oItem_Obj As clsOntologyItem
        Dim boolAdd As Boolean

        Dim boolValue As Boolean
        Dim dateValue As Date
        Dim lngValue As Long
        Dim dblValue As Double
        Dim strValue As String

        If Not objOItem_Parent Is Nothing Then
            Select Case objOItem_Parent.Type
                Case objLocalConfig.Globals.Type_Object
                    objOItem_Result = objTransaction_Objects.save_Object(objOItem_Parent.GUID_Parent)
                    If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                        configure_TabPages()
                    ElseIf objOItem_Result.GUID = objLocalConfig.Globals.LState_Error.GUID Then
                        MsgBox("Beim Erzeugen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                    End If

                Case objLocalConfig.Globals.Type_RelationType
                    objOItem_Result = objTransaction_RelationTypes.save_RelType()
                    If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                        configure_TabPages()
                    ElseIf objOItem_Result.GUID = objLocalConfig.Globals.LState_Relation.GUID Then
                        MsgBox("Es gibt bereits einen Beziehungstyp mit diesem Namen!", MsgBoxStyle.Exclamation)
                    ElseIf objOItem_Result.GUID = objLocalConfig.Globals.LState_Error.GUID Then
                        MsgBox("Beim Erzeugen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                    End If


                Case objLocalConfig.Globals.Type_AttributeType
                    objOItem_Result = objTransaction_AttributeTypes.save_AttType()
                    If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                        configure_TabPages()
                    ElseIf objOItem_Result.GUID = objLocalConfig.Globals.LState_Relation.GUID Then
                        MsgBox("Es gibt bereits einen Beziehungstyp mit diesem Namen!", MsgBoxStyle.Exclamation)
                    ElseIf objOItem_Result.GUID = objLocalConfig.Globals.LState_Error.GUID Then
                        MsgBox("Beim Erzeugen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                    End If


            End Select


        Else

            Select Case strType
                Case objLocalConfig.Globals.Type_Object


                Case objLocalConfig.Globals.Type_RelationType



                Case objLocalConfig.Globals.Type_AttributeType
                    Dim objLDT = From objDT In objDBLevel.OList_DataTypes
                               Group By objDT.GUID, objDT.Name Into Group

                    Dim objLAT = From objAT In objDBLevel.OList_AttributeTypes
                                 Group By objAT.GUID, objAT.Name Into Group
                    If objLDT.Count > 0 Then
                        Select Case objLDT(0).GUID
                            Case objLocalConfig.Globals.DType_Bool.GUID
                                objDlg_Attribute_Boolean = New dlg_Attribute_Boolean(objLAT(0).Name & "/" & objLDT(0).Name, objLocalConfig)
                                objDlg_Attribute_Boolean.ShowDialog(Me)
                                If objDlg_Attribute_Boolean.DialogResult = DialogResult.OK Then

                                End If
                            Case objLocalConfig.Globals.DType_DateTime.GUID
                                objDlg_Attribute_DateTime = New dlg_Attribute_DateTime(objLAT(0).Name & "/" & objLDT(0).Name, objLocalConfig)
                                objDlg_Attribute_DateTime.ShowDialog(Me)
                                If objDlg_Attribute_DateTime.DialogResult = DialogResult.OK Then
                                    dateValue = objDlg_Attribute_DateTime.Value
                                End If
                            Case objLocalConfig.Globals.DType_Int.GUID
                                objDlg_Attribute_Long = New dlg_Attribute_Long(objLAT(0).Name & "/" & objLDT(0).Name, objLocalConfig)
                                objDlg_Attribute_Long.ShowDialog(Me)
                                If objDlg_Attribute_Long.DialogResult = DialogResult.OK Then

                                End If
                            Case objLocalConfig.Globals.DType_Real.GUID
                                objDlg_Attribute_Double = New dlg_Attribute_Double(objLAT(0).Name & "/" & objLDT(0).Name, objLocalConfig)
                                objDlg_Attribute_Double.ShowDialog(Me)
                                If objDlg_Attribute_Double.DialogResult = DialogResult.OK Then

                                End If
                            Case objLocalConfig.Globals.DType_String.GUID
                                objDlg_Attribute_String = New dlg_Attribute_String(objLAT(0).Name & "/" & objLDT(0).Name, objLocalConfig)
                                objDlg_Attribute_String.ShowDialog(Me)
                                If objDlg_Attribute_String.DialogResult = DialogResult.OK Then

                                End If
                        End Select

                    End If


                Case objLocalConfig.Globals.Type_Other
                    Select Case objOItem_Other.Type
                        Case objLocalConfig.Globals.Type_Object
                            If objOItem_Direction.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
                                objOItem_Class.GUID = objOItem_Other.GUID_Parent
                                objOItem_Class.Type = objLocalConfig.Globals.Type_Class
                            Else
                                objOItem_Class.GUID = strGUID_Class
                                objOItem_Class.Type = objLocalConfig.Globals.Type_Class
                            End If
                            

                            objFrm_Main = New frmMain(objLocalConfig, objLocalConfig.Globals.Type_Class, objOItem_Class)
                            objFrm_Main.ShowDialog(Me)
                            If objFrm_Main.DialogResult = DialogResult.OK Then
                                If objFrm_Main.Type_Applied = objLocalConfig.Globals.Type_Object Then
                                    oList_Simple = objFrm_Main.OList_Simple
                                    boolAdd = True

                                    Dim oLSel = From obj In oList_Simple
                                                Group By obj.GUID_Parent Into Group

                                    For Each oSel In oLSel
                                        If Not oSel.GUID_Parent = objOItem_Class.GUID Then
                                            boolAdd = False
                                            Exit For
                                        End If
                                    Next

                                Else
                                    MsgBox("Bitte nur Objekte auswählen!", MsgBoxStyle.Information)
                                End If


                            End If
                    End Select

                    If boolAdd = True Then
                        For Each oItem_Obj In oList_Simple
                            If objOItem_Direction.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
                                oList_ObjRel.Add(New clsObjectRel(objOItem_Object.GUID, objOItem_Object.GUID_Parent, oItem_Obj.GUID, oItem_Obj.GUID_Parent, objOItem_RelationType.GUID, oItem_Obj.Type, Nothing, 1))

                            Else
                                oList_ObjRel.Add(New clsObjectRel(objOItem_Other.GUID, objOItem_Other.GUID_Parent, oItem_Obj.GUID, oItem_Obj.GUID_Parent, objOItem_RelationType.GUID, oItem_Obj.Type, Nothing, 1))

                            End If
                        Next
                        objOItem_Result = objDBLevel.save_ObjRel(oList_ObjRel)

                        If Not objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                            MsgBox("Beim Speichern ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                        ElseIf objOItem_Result.Max1 > objOItem_Result.Val Then
                            MsgBox("Es konnten nicht alle Beziehungen erzeugt werden!", MsgBoxStyle.Information)

                        End If
                        configure_TabPages()
                    Else
                        MsgBox("Sie haben Objekte der falschen Klasse ausgewählt!", MsgBoxStyle.Exclamation)
                    End If


            End Select

        End If
    End Sub
    
    

    Private Sub ToolStripButton_DelItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_DelItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim oList_Simple As New List(Of clsOntologyItem)
        Dim oList_ORel As New List(Of clsObjectRel)
        Dim strIDs() As String

        For Each objDGVR_Selected In DataGridView_Items.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            If Not objOItem_Parent Is Nothing Then
                Select Case objOItem_Parent.Type
                    Case objLocalConfig.Globals.Type_Object
                        oList_Simple.Add(New clsOntologyItem(objDRV_Selected.Item("ID_Item"), objLocalConfig.Globals.Type_Object))

                    Case objLocalConfig.Globals.Type_RelationType
                  
                    Case objLocalConfig.Globals.Type_AttributeType
                  

                End Select

                If Not oList_Simple Is Nothing Then
                    If oList_Simple.Count > 0 Then
                        strIDs = objDBLevel.del_Objects(oList_Simple)

                        If Not strIDs Is Nothing Then
                            Dim objLDel = From objObj In oList_Simple
                                      Group Join strID In strIDs On objObj.GUID Equals strID Into RightTableResult = Group
                                      From strID In RightTableResult.DefaultIfEmpty
                                      Where strID Is Nothing

                            If objLDel.Count > 0 Then
                                MsgBox("Es konnten nur " & oList_Simple.Count - objLDel.Count & " von " & oList_Simple.Count & " Objekte gelöscht werden!")
                            End If
                        Else
                            MsgBox("Kein Objekt kann gelöscht werden!", MsgBoxStyle.Exclamation)
                        End If
                        

                    End If
                End If

                configure_TabPages()
            Else

                Select Case strType
                    Case objLocalConfig.Globals.Type_Object


                    Case objLocalConfig.Globals.Type_RelationType



                    Case objLocalConfig.Globals.Type_AttributeType



                    Case objLocalConfig.Globals.Type_Other
                        
                        If objOItem_Direction.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then

                        Else

                        End If
                End Select

            End If

        Next
    End Sub

    Private Sub ContextMenuStrip_SemList_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_SemList.Opening
        'Dim objModule As clsModule
        'Dim objModules_Show() As clsModule
        'Dim objSemItem_ToTest As New clsSemItem
        Dim i As Integer
        Dim boolFillCombo As Boolean = False

        ToClipboardToolStripMenuItem.Enabled = False
        ToolStripComboBox_ModuleMenu.Items.Clear()
        ToolStripComboBox_ModuleEdit.Enabled = False
        ApplyToolStripMenuItem.Enabled = False
        'If objSemItem_Complex_Base Is Nothing Then
        '    objSemItem_ToTest = objSemItem_Parent
        'Else
        '    objSemItem_ToTest.GUID = objSemItem_Complex_Base.GUID_Related
        '    objSemItem_ToTest.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        'End If
        'If Not objLocalConfig.Globals.loaded_Modules Is Nothing Then
        '    i = 0
        '    For Each objModule In objLocalConfig.Globals.loaded_Modules
        '        If objModule.Active = True And objModule.Valid = True Then
        '            If objModule.Object_OK(objSemItem_ToTest, True) Then
        '                ReDim Preserve objModules_Show(i)
        '                objModules_Show(i) = objModule
        '                boolFillCombo = True
        '                i = i + 1

        '            End If
        '        End If
        '    Next

        '    If boolFillCombo = True Then
        '        ToolStripComboBox_ModuleEdit.Items.Clear()
        '        For Each objModule In objModules_Show
        '            ToolStripComboBox_ModuleMenu.Items.Add(objModule)
        '            If objModule.loaded_Module.TokenEdit = True Then

        '                ToolStripComboBox_ModuleEdit.Items.Add(objModule)
        '                ToolStripComboBox_ModuleEdit.ComboBox.ValueMember = "GUID_LoadedModule"
        '                ToolStripComboBox_ModuleEdit.ComboBox.DisplayMember = "Name_LoadedModule"
        '            End If
        '        Next
        '        ToolStripComboBox_ModuleMenu.ComboBox.ValueMember = "GUID_LoadedModule"
        '        ToolStripComboBox_ModuleMenu.ComboBox.DisplayMember = "Name_LoadedModule"
        '    End If
        'End If
        ToolStripComboBox_ModuleEdit.Enabled = False
        If DataGridView_Items.SelectedRows.Count > 0 Then
            If boolApplyable = True Then
                ApplyToolStripMenuItem.Enabled = True
            End If
            If DataGridView_Items.SelectedRows.Count = 1 Then
                ToolStripComboBox_ModuleEdit.Enabled = True
                ToClipboardToolStripMenuItem.Enabled = True


            End If
        End If
        

    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        oList_Selected_ObjectRel.Clear()
        oList_Selected_Simple.Clear()
        If boolApplyable = True And DataGridView_Items.SelectedRows.Count > 0 Then
            For Each objDGVR_Selected In DataGridView_Items.SelectedRows
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                If Not objOItem_Parent Is Nothing Then
                    Select Case objOItem_Parent.Type
                        Case objLocalConfig.Globals.Type_Object
                            oList_Selected_Simple.Add(New clsOntologyItem(objDRV_Selected.Item("ID_Item"), _
                                                                          objDRV_Selected.Item("Name"), _
                                                                          objDRV_Selected.Item("ID_Parent"), _
                                                                          objLocalConfig.Globals.Type_Object))
                            RaiseEvent applied_Items()
                        Case objLocalConfig.Globals.Type_RelationType
                            oList_Selected_Simple.Add(New clsOntologyItem(objDRV_Selected.Item("ID_Item"), _
                                                                              objDRV_Selected.Item("Name"), _
                                                                              objLocalConfig.Globals.Type_RelationType))
                            RaiseEvent applied_Items()
                        Case objLocalConfig.Globals.Type_AttributeType
                            oList_Selected_Simple.Add(New clsOntologyItem(objDRV_Selected.Item("ID_Item"), _
                                                                              objDRV_Selected.Item("Name"), _
                                                                              objDRV_Selected.Item("ID_Parent"), _
                                                                              objLocalConfig.Globals.Type_AttributeType))
                            RaiseEvent applied_Items()
                    End Select


                Else

                    Select Case strType
                        Case objLocalConfig.Globals.Type_Object


                        Case objLocalConfig.Globals.Type_RelationType



                        Case objLocalConfig.Globals.Type_AttributeType



                        Case objLocalConfig.Globals.Type_Other
                        
                        
                    End Select

                End If
            Next
        End If
    End Sub
End Class

