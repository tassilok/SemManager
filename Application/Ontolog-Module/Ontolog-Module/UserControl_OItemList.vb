Public Class UserControl_OItemList
    Private objLocalConfig As clsLocalConfig

    Private otblT_Objects As New DataSet_Config.otbl_ObjectsDataTable

    Private objDBLevel As clsDBLevel

    Private objOItem_Parent As clsOntologyItem

    Private objOItem_RelationType As clsOntologyItem
    Private objOItem_Other As clsOntologyItem

    Private boolProgChange As Boolean

    Private strRowName_GUID As String

    Dim strName_Filter As String
    Dim strGUID_Filter As String

    Private Event selected_ListItem()

    Public Event Selection_Changed()

    Public ReadOnly Property DataGridViewRowCollection_Selected As DataGridViewSelectedRowCollection
        Get
            Return DataGridView_Items.SelectedRows
        End Get
    End Property

    Public Sub initialize_Simple(ByVal OItem_Parent As clsOntologyItem)
        boolProgChange = True

        objOItem_Parent = OItem_Parent

        ToolStripButton_AddItem.Visible = True
        ToolStripButton_DelItem.Visible = True
        ToolStripButton_Up.Visible = False
        ToolStripButton_Down.Visible = False
        ToolStripButton_Sort.Visible = False
        ToolStripButton_Report.Visible = True
        ToolStripTextBox_Filter.ReadOnly = True
        ToolStripTextBox_Filter.Text = ""
        ToolStripTextBox_Filter.ReadOnly = False
        clear_Relation()
        configure_TabPages()

        boolProgChange = False
    End Sub

    Private Sub get_Data()
        Dim oList_Items As New List(Of clsOntologyItem)
        If Not objOItem_Parent Is Nothing Then
            Select Case objOItem_Parent.Type
                Case objLocalConfig.Globals.Type_Object
                    oList_Items.Clear()
                    oList_Items.Add(New clsOntologyItem(strGUID_Filter, strName_Filter, objOItem_Parent.GUID_Parent, objLocalConfig.Globals.Type_Object))
                    objDBLevel.get_Data_Objects(oList_Items, True)
                    BindingSource_Token.DataSource = objDBLevel.tbl_Objects
                    DataGridView_Items.DataSource = BindingSource_Token
                    DataGridView_Items.Columns(0).Visible = False
                    DataGridView_Items.Columns(2).Visible = False
                    DataGridView_Items.Columns(1).Width = DataGridView_Items.Width - 20
                    ToolStripLabel_Count.Text = DataGridView_Items.RowCount
                    strRowName_GUID = "ID_Object"
                Case objLocalConfig.Globals.Type_RelationType
                    oList_Items.Clear()
                    oList_Items.Add(New clsOntologyItem(strGUID_Filter, strName_Filter, objLocalConfig.Globals.Type_RelationType))
                    objDBLevel.get_Data_RelationTypes(oList_Items, True)
                    BindingSource_RelationType.DataSource = objDBLevel.tbl_RelationTypes
                    DataGridView_Items.DataSource = BindingSource_RelationType
                    DataGridView_Items.Columns(0).Visible = False
                    DataGridView_Items.Columns(1).Width = DataGridView_Items.Width - 20
                    ToolStripLabel_Count.Text = DataGridView_Items.RowCount
                    strRowName_GUID = "ID_RelationType"
                Case objLocalConfig.Globals.Type_AttributeType
                    oList_Items.Clear()
                    oList_Items.Add(New clsOntologyItem(strGUID_Filter, strName_Filter, objLocalConfig.Globals.Type_AttributeType))
                    objDBLevel.get_Data_AttributeType(oList_Items, True)
                    BindingSource_Attribute.DataSource = objDBLevel.tbl_AttributeTypes
                    DataGridView_Items.DataSource = BindingSource_Attribute
                    DataGridView_Items.Columns(0).Visible = False
                    DataGridView_Items.Columns(1).Width = DataGridView_Items.Width - 20
                    ToolStripLabel_Count.Text = DataGridView_Items.RowCount
                    strRowName_GUID = "ID_AttributeType"
            End Select

        Else

        End If

    End Sub

    Private Sub configure_TabPages()
        Select Case TabControl1.SelectedTab.Name
            Case TabPage_List.Name
                get_Data()
            Case TabPage_Tree.Name
                If Not objOItem_Parent Is Nothing Then
                    'objUserControl_TreeOfToken.initialize(objSemItem_Parent)
                End If
        End Select

    End Sub

    Private Sub clear_Relation()
        objOItem_Other = Nothing
        objOItem_RelationType = Nothing
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
    End Sub

    Private Sub DataGridView_Items_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Items.SelectionChanged
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView

        If DataGridView_Items.SelectedRows.Count = 1 Then
            objDGVR = DataGridView_Items.SelectedRows(0)
            objDRV = objDGVR.DataBoundItem
            ToolStripTextBox_GUID.Text = objDRV.Item(strRowName_GUID).ToString
        Else
            ToolStripTextBox_GUID.Clear()
        End If
        If boolProgChange = False Then
            RaiseEvent Selection_Changed()
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
        Timer_Filter.Stop()
        get_Data()
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
End Class
