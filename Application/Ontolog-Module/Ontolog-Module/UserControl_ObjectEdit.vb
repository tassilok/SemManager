Public Class UserControl_ObjectEdit

    Private objLocalConfig As clsLocalConfig
    Private objDBLevel As clsDBLevel
    Private objOList_Objects As List(Of clsOntologyItem)
    Private objOList_ObjectRel As List(Of clsObjectRel)

    Private objFrm_ObjectEdit As frm_ObjectEdit

    Private objDataGridviewRowCollection_Objects As DataGridViewRowCollection
    Private WithEvents objUserControl_ObjectRelTree As UserControl_ObjectRelTree
    Private WithEvents objUserControl_OItem_List As UserControl_OItemList

    Private objOItem_Object As clsOntologyItem
    Private objOItem_ObjectRel As clsObjectRel
    Private objOItem_Direction As clsOntologyItem
    Private intRowID As Integer
    Private strOntology As String

    Private Sub editObject(ByVal strType As String, ByVal objOItem_Direction As clsOntologyItem) Handles objUserControl_OItem_List.edit_Object
        objFrm_ObjectEdit = New frm_ObjectEdit(objLocalConfig, _
                                               objUserControl_OItem_List.DataGridviewRows, _
                                               objUserControl_OItem_List.RowID, _
                                               strType, _
                                               objOItem_Direction)
        objFrm_ObjectEdit.ShowDialog(Me)
        If objFrm_ObjectEdit.DialogResult = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub selected_Node(ByVal oList_Selected As List(Of clsOntologyItem)) Handles objUserControl_ObjectRelTree.selected_Item


        Dim oList_Object As New List(Of clsOntologyItem)
        Dim oList_Other As New List(Of clsOntologyItem)
        Dim oItem_Direction As clsOntologyItem
        Dim oList_RelationType As New List(Of clsOntologyItem)

        oList_Object.Add(New clsOntologyItem(oList_Selected(0).GUID, objLocalConfig.Globals.Type_Object))
        If oList_Selected(1).Type = objLocalConfig.Globals.Type_Class Then
            oList_Other.Add(New clsOntologyItem(Nothing, Nothing, oList_Selected(1).GUID, objLocalConfig.Globals.Type_Object))
        Else
            oList_Other.Add(New clsOntologyItem(oList_Selected(1).GUID, oList_Selected(1).Type))
        End If


        If oList_Selected.Count > 2 Then
            oList_RelationType.Add(New clsOntologyItem(oList_Selected(2).GUID, objLocalConfig.Globals.Type_RelationType))
            If oList_Selected(3).GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
                oItem_Direction = objLocalConfig.Globals.Direction_LeftRight
            Else
                oItem_Direction = objLocalConfig.Globals.Direction_RightLeft

            End If
            objUserControl_OItem_List.initialize(Nothing, _
                                                 oList_Object(0), _
                                             oItem_Direction, _
                                             oList_Other(0), _
                                             oList_RelationType(0), False)
        Else
            objUserControl_OItem_List.initialize(Nothing, _
                                                 oList_Object(0), _
                                             Nothing, _
                                             oList_Other(0), _
                                             Nothing, False)
        End If

        
    End Sub


    Public Sub New(ByVal OList_Objecst As List(Of clsObjectRel), ByVal Ontology As String, ByVal oItem_Direction As clsOntologyItem, ByVal RowID As Integer, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)

        objOItem_Direction = oItem_Direction
        objOList_ObjectRel = OList_Objecst
        objDataGridviewRowCollection_Objects = Nothing
        intRowID = RowID
        strOntology = Ontology

        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal OList_Objecst As List(Of clsOntologyItem), ByVal Ontology As String, ByVal oItem_Direction As clsOntologyItem, ByVal RowID As Integer, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)

        objOItem_Direction = oItem_Direction
        objOList_Objects = OList_Objecst
        objDataGridviewRowCollection_Objects = Nothing
        intRowID = RowID
        strOntology = Ontology

        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal DataGridviewRowCollection As DataGridViewRowCollection, ByVal Ontology As String, ByVal oItem_Direction As clsOntologyItem, ByVal RowID As Integer, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)

        objOItem_Direction = oItem_Direction
        objDataGridviewRowCollection_Objects = DataGridviewRowCollection
        objOList_Objects = Nothing
        intRowID = RowID
        strOntology = Ontology

        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        If Not objOList_Objects Is Nothing Then
            objOItem_Object = objOList_Objects(intRowID)

            ToolStripTextBox_GUID.Text = objOItem_Object.GUID
            ToolStripTextBox_Name.Text = objOItem_Object.Name

        ElseIf objDataGridviewRowCollection_Objects Is Nothing Then

        Else

            objDGVR_Selected = objDataGridviewRowCollection_Objects(intRowID)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objOItem_Object = New clsOntologyItem
            If strOntology = objLocalConfig.Globals.Type_Other Then
                If objOItem_Direction.GUID = objLocalConfig.Globals.Direction_LeftRight.GUID Then
                    objOItem_Object.GUID = objDRV_Selected.Item("ID_Other")
                    objOItem_Object.Name = objDRV_Selected.Item("Name_Other")
                    objOItem_Object.GUID_Parent = objDRV_Selected.Item("ID_Parent_Other")
                    objOItem_Object.Type = objLocalConfig.Globals.Type_Object
                Else
                    objOItem_Object.GUID = objDRV_Selected.Item("ID_Object")
                    objOItem_Object.Name = objDRV_Selected.Item("Name_Object")
                    objOItem_Object.GUID_Parent = objDRV_Selected.Item("ID_Parent_Object")
                    objOItem_Object.Type = objLocalConfig.Globals.Type_Object
                    
                End If
            Else
                objOItem_Object.GUID = objDRV_Selected.Item("ID_Item")
                objOItem_Object.Name = objDRV_Selected.Item("Name")
                objOItem_Object.GUID_Parent = objDRV_Selected.Item("ID_Parent")
                objOItem_Object.Type = objLocalConfig.Globals.Type_Object
            End If
            

            ToolStripTextBox_GUID.Text = objOItem_Object.GUID
            ToolStripTextBox_Name.Text = objOItem_Object.Name
        End If

        objUserControl_ObjectRelTree = New UserControl_ObjectRelTree(objLocalConfig, objOItem_Object)
        objUserControl_ObjectRelTree.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Clear()
        SplitContainer1.Panel1.Controls.Add(objUserControl_ObjectRelTree)
        objUserControl_OItem_List = New UserControl_OItemList(objLocalConfig)
        objUserControl_OItem_List.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(objUserControl_OItem_List)
        set_CountLbl()
    End Sub

    Private Sub set_CountLbl()
        ToolStripLabel_ObjectCount.Text = intRowID

        If objOList_Objects Is Nothing Then
            ToolStripLabel_ObjectCount.Text = ToolStripLabel_ObjectCount.Text & "/" & objDataGridviewRowCollection_Objects.Count
        Else
            ToolStripLabel_ObjectCount.Text = ToolStripLabel_ObjectCount.Text & "/" & objOList_Objects.Count
        End If

    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)

    End Sub
End Class
