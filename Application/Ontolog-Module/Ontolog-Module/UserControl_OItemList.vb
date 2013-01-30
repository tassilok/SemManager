Public Class UserControl_OItemList
    Private objLocalConfig As clsLocalConfig

    Private otblT_Objects As New DataSet_Config.otbl_ObjectsDataTable

    Private objDBLevel As clsDBLevel

    Private objOItem_Parent As clsOntologyItem

    Private objOItem_RelationType As clsOntologyItem
    Private objOItem_Other As clsOntologyItem

    Private boolProgChange As Boolean

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

        If Not objOItem_Parent Is Nothing Then
            Select Case objOItem_Parent.GUID_Type
                Case objLocalConfig.Globals.OType_Class.GUID
                    objDBLevel.get_Data_Objects(objOItem_Parent, True)
                    BindingSource_Token.DataSource = objDBLevel.tbl_Objects
                    DataGridView_Items.DataSource = BindingSource_Token
                    DataGridView_Items.Columns(0).Visible = False
                    DataGridView_Items.Columns(2).Visible = False
                    DataGridView_Items.Columns(1).Width = DataGridView_Items.Width - 20
                    ToolStripLabel_Count.Text = DataGridView_Items.RowCount
                Case objLocalConfig.Globals.OType_KindOfOntology.GUID
                    Select Case objOItem_Parent.GUID
                        Case objLocalConfig.Globals.OType_RelationType.GUID
                            objDBLevel.get_Data_RelationTypes(Nothing, True)
                            BindingSource_RelationType.DataSource = objDBLevel.tbl_RelationTypes
                            DataGridView_Items.DataSource = BindingSource_RelationType
                            DataGridView_Items.Columns(0).Visible = False
                            DataGridView_Items.Columns(1).Width = DataGridView_Items.Width - 20
                            ToolStripLabel_Count.Text = DataGridView_Items.RowCount
                    End Select
                    
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
End Class
