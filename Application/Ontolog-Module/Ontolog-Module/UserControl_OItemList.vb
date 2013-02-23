﻿Public Class UserControl_OItemList
    Private objLocalConfig As clsLocalConfig

    Private otblT_Objects As New DataSet_Config.otbl_ObjectsDataTable

    Private objDBLevel As clsDBLevel

    Private objTransaction_Objects As clsTransaction_Objects
    Private objTransaction_RelationTypes As clsTransaction_RelationTypes
    Private objTransaction_AttributeTypes As clsTransaction_AttributeTypes

    Private objOItem_Parent As clsOntologyItem

    Private objOItem_RelationType As clsOntologyItem
    Private objOItem_Other As clsOntologyItem

    Private objThread_List As Threading.Thread

    Private boolProgChange As Boolean

    Private strRowName_GUID As String
    Private strGUID_Class As String

    Private objOItem_Direction As clsOntologyItem

    Private boolOR As Boolean

    Private strName_Filter As String
    Private strGUID_Filter As String

    Private intRowID As Integer

    Private boolFinished As Boolean

    Private strType As String

    Private Event selected_ListItem()

    Public Event Selection_Changed()
    Public Event edit_Object(ByVal strType As String, ByVal oItem_Direction As clsOntologyItem)

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
            Select Case objOItem_Other.Type
                


                Case objLocalConfig.Globals.Type_RelationType
                    oList_Items.Add(New clsOntologyItem(strGUID_Filter, strName_Filter, objLocalConfig.Globals.Type_RelationType))
                    objDBLevel.get_Data_RelationTypes(oList_Items, True)

                Case objLocalConfig.Globals.Type_AttributeType
                    oList_Items.Add(New clsOntologyItem(strGUID_Filter, strName_Filter, objLocalConfig.Globals.Type_AttributeType))
                    objDBLevel.get_Data_AttributeType(oList_Items, True)
                Case Else
                    oList_Other.Add(objOItem_Other)
                    oList_RelType.Add(objOItem_RelationType)

                    oList_Items.Add(New clsOntologyItem(strGUID_Filter, strName_Filter, strGUID_Class, objLocalConfig.Globals.Type_Object))
                    objDBLevel.get_Data_ObjectRel(oList_Items, oList_Other, oList_RelType, True, False)
            End Select
            
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


                        BindingSource_Attribute.DataSource = objDBLevel.tbl_AttributeTypes
                        DataGridView_Items.DataSource = BindingSource_Attribute
                        DataGridView_Items.Columns(0).Visible = False
                        DataGridView_Items.Columns(1).Width = DataGridView_Items.Width - 20
                        ToolStripLabel_Count.Text = DataGridView_Items.RowCount
                        strRowName_GUID = "ID_Item"
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
                strRowName_GUID = "ID_Other"
            End If
            ToolStripProgressBar_List.Value = 0

        Else
            ToolStripProgressBar_List.Value = 50

        End If
    End Sub

    Private Sub ToolStripButton_AddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddItem.Click
        Dim objOItem_Result As clsOntologyItem
        If Not objOItem_Parent Is Nothing Then
            Select Case objOItem_Parent.Type
                Case objLocalConfig.Globals.Type_Object
                    objOItem_Result = objTransaction_Objects.save_Object(objOItem_Parent.GUID_Parent)
                    If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                        get_Data()
                    ElseIf objOItem_Result.GUID = objLocalConfig.Globals.LState_Error.GUID Then
                        MsgBox("Beim Erzeugen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                    End If

                Case objLocalConfig.Globals.Type_RelationType
                    objOItem_Result = objTransaction_RelationTypes.save_RelType()
                    If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                        get_Data()
                    ElseIf objOItem_Result.GUID = objLocalConfig.Globals.LState_Relation.GUID Then
                        MsgBox("Es gibt bereits einen Beziehungstyp mit diesem Namen!", MsgBoxStyle.Exclamation)
                    ElseIf objOItem_Result.GUID = objLocalConfig.Globals.LState_Error.GUID Then
                        MsgBox("Beim Erzeugen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                    End If


                Case objLocalConfig.Globals.Type_AttributeType
                    objOItem_Result = objTransaction_AttributeTypes.save_AttType()
                    If objOItem_Result.GUID = objLocalConfig.Globals.LState_Success.GUID Then
                        get_Data()
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



                Case objLocalConfig.Globals.Type_Other
                    If objOItem_Direction.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then

                    Else

                    End If
            End Select

        End If
    End Sub
    
    

End Class

