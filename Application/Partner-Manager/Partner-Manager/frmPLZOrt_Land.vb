Imports Sem_Manager
Public Class frmPLZOrt_Land


    Private objDRC_TokenRel_Address_PLZ As DataRowCollection
    Private objDRC_TokenRel_Address_Ort As DataRowCollection
    Private objDRC_TokenRel_Ort_Land As DataRowCollection

    Private objSemItem_PLZ As New clsSemItem
    Private objSemItem_Ort As New clsSemItem
    Private objSemItem_Land As New clsSemItem

    Private semtbl_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter

    Private WithEvents objUserControl_SemItemList_PLZ As UserControl_SemItemList
    Private WithEvents objUserControl_SemItemList_Ort As UserControl_SemItemList
    Private WithEvents objUserControl_SemItemList_Land As UserControl_SemItemList

    Public ReadOnly Property SemItem_PLZ_Sel() As clsSemItem
        Get
            Return objSemItem_PLZ
        End Get
    End Property

    Public ReadOnly Property SemItem_Ort_Sel() As clsSemItem
        Get
            Return objSemItem_Ort
        End Get
    End Property

    Public ReadOnly Property SemItem_Land_Sel() As clsSemItem
        Get
            Return objSemItem_Land
        End Get
    End Property


    Public Sub New(ByVal DRC_TokenRel_Address_PLZ As DataRowCollection, ByVal DRC_TokenRel_Address_Ort As DataRowCollection, ByVal DRC_TokenRel_Ort_Land As DataRowCollection)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.


        objDRC_TokenRel_Address_PLZ = DRC_TokenRel_Address_PLZ
        objDRC_TokenRel_Address_Ort = DRC_TokenRel_Address_Ort
        objDRC_TokenRel_Ort_Land = DRC_TokenRel_Ort_Land

        set_DBConnection()
        initialize()
        
    End Sub
    Private Sub initialize()
        If Not objDRC_TokenRel_Address_PLZ Is Nothing Then
            If objDRC_TokenRel_Address_PLZ.Count > 0 Then
                objSemItem_PLZ = New clsSemItem
                objSemItem_PLZ.GUID = objDRC_TokenRel_Address_PLZ(0).Item("GUID_Postleitzahl")
                objSemItem_PLZ.Name = objDRC_TokenRel_Address_PLZ(0).Item("Name_Postleitzahl")
                objSemItem_PLZ.GUID_Parent = objLocalConfig.SemItem_Type_Postleitzahl.GUID
                objSemItem_PLZ.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            Else
                objSemItem_PLZ = Nothing
            End If
        Else
            objSemItem_PLZ = Nothing
        End If
        

        If Not objDRC_TokenRel_Address_Ort Is Nothing Then
            If objDRC_TokenRel_Address_Ort.Count > 0 Then
                objSemItem_Ort = New clsSemItem
                objSemItem_Ort.GUID = objDRC_TokenRel_Address_Ort(0).Item("GUID_Ort")
                objSemItem_Ort.Name = objDRC_TokenRel_Address_Ort(0).Item("Name_Ort")
                objSemItem_Ort.GUID_Parent = objLocalConfig.SemItem_Type_Ort.GUID
                objSemItem_Ort.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            Else
                objSemItem_Ort = Nothing
            End If
        Else
            objSemItem_Ort = Nothing
        End If
        
        If Not objDRC_TokenRel_Ort_Land Is Nothing Then
            If objDRC_TokenRel_Ort_Land.Count > 0 Then
                objSemItem_Land = New clsSemItem
                objSemItem_Land.GUID = objDRC_TokenRel_Ort_Land(0).Item("GUID_Land")
                objSemItem_Land.Name = objDRC_TokenRel_Ort_Land(0).Item("Name_Land")
                objSemItem_Land.GUID_Parent = objLocalConfig.SemItem_Type_Postleitzahl.GUID
                objSemItem_Land.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            Else
                objSemItem_Land = Nothing
            End If
        Else
            objSemItem_Land = Nothing
        End If
        

        set_Controls()
    End Sub

    Private Sub set_DBConnection()
        semtbl_Token_Token.Connection = objLocalConfig.Connection_DB
    End Sub
    Private Sub set_Controls()
        objUserControl_SemItemList_PLZ = New UserControl_SemItemList
        objUserControl_SemItemList_PLZ.initialize_Simple(objLocalConfig.SemItem_Type_Postleitzahl, objLocalConfig.Globals)
        If Not objSemItem_PLZ Is Nothing Then
            objUserControl_SemItemList_PLZ.filter_View_GUID_Token(objSemItem_PLZ.GUID)

        End If
        objUserControl_SemItemList_PLZ.Dock = DockStyle.Fill
        objUserControl_SemItemList_Ort = New UserControl_SemItemList
        objUserControl_SemItemList_Ort.initialize_Simple(objLocalConfig.SemItem_Type_Ort, objLocalConfig.Globals)
        If Not objSemItem_Ort Is Nothing Then
            objUserControl_SemItemList_Ort.filter_View_GUID_Token(objSemItem_Ort.GUID)
        End If
        objUserControl_SemItemList_Ort.Dock = DockStyle.Fill
        objUserControl_SemItemList_Land = New UserControl_SemItemList
        objUserControl_SemItemList_Land.initialize_Simple(objLocalConfig.SemItem_Type_Land, objLocalConfig.Globals)
        If Not objSemItem_Land Is Nothing Then
            objUserControl_SemItemList_Land.filter_View_GUID_Token(objSemItem_Land.GUID)
        End If
        objUserControl_SemItemList_Land.Dock = DockStyle.Fill

        Panel_PLZ.Controls.Clear()
        Panel_PLZ.Controls.Add(objUserControl_SemItemList_PLZ)
        Panel_Ort.Controls.Clear()
        Panel_Ort.Controls.Add(objUserControl_SemItemList_Ort)
        Panel_Land.Controls.Clear()
        Panel_Land.Controls.Add(objUserControl_SemItemList_Land)

    End Sub

    Private Sub selected_PLZ() Handles objUserControl_SemItemList_PLZ.Selection_Changed
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim boolFilter_Ort As Boolean
        Dim intCount As Integer


        get_SemItem_PLZ()
        If Not objSemItem_PLZ Is Nothing Then
            boolFilter_Ort = True
            get_SemItem_Ort()
            If Not objSemItem_Ort Is Nothing Then
                intCount = semtbl_Token_Token.Count_By_GUIDs(objSemItem_PLZ.GUID, objSemItem_Ort.GUID, objSemItem_PLZ.GUID_Relation)
                If intCount > 0 Then
                    boolFilter_Ort = False
                End If

            End If
            If boolFilter_Ort = True Then
                objSemItem_Ort = Nothing
                objUserControl_SemItemList_Ort.filter_View_Item(objSemItem_PLZ)
            End If
        End If
        



    End Sub
    Private Sub set_Applyable()
        If Not objSemItem_PLZ Is Nothing And Not objSemItem_Ort Is Nothing Then
            ToolStripButton_Apply.Enabled = True
        Else
            ToolStripButton_Apply.Enabled = False
        End If
    End Sub
    Private Sub get_SemItem_PLZ()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        If objUserControl_SemItemList_PLZ.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_SemItemList_PLZ.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_PLZ = New clsSemItem
            objSemItem_PLZ.GUID = objDRV_Selected.Item(objUserControl_SemItemList_PLZ.RowName_GUID)
            objSemItem_PLZ.Name = objDRV_Selected.Item(objUserControl_SemItemList_PLZ.RowName_Name)
            objSemItem_PLZ.GUID_Parent = objLocalConfig.SemItem_Type_Postleitzahl.GUID
            objSemItem_PLZ.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_PLZ.Direction = objSemItem_PLZ.Direction_LeftRight
            objSemItem_PLZ.GUID_Related = objLocalConfig.SemItem_Type_Ort.GUID
            objSemItem_PLZ.GUID_Relation = objLocalConfig.SemItem_RelationType_located_in.GUID
        Else
            objSemItem_PLZ = Nothing
        End If
        set_Applyable()
    End Sub
    Private Sub get_SemItem_Ort()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        If objUserControl_SemItemList_Ort.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_SemItemList_Ort.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_Ort = New clsSemItem
            objSemItem_Ort.GUID = objDRV_Selected.Item(objUserControl_SemItemList_Ort.RowName_GUID)
            objSemItem_Ort.Name = objDRV_Selected.Item(objUserControl_SemItemList_Ort.RowName_Name)
            objSemItem_Ort.GUID_Parent = objLocalConfig.SemItem_Type_Postleitzahl.GUID
            objSemItem_Ort.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Ort.Direction = objSemItem_Ort.Direction_RightLeft
            objSemItem_Ort.GUID_Related = objLocalConfig.SemItem_Type_Postleitzahl.GUID
            objSemItem_Ort.GUID_Relation = objLocalConfig.SemItem_RelationType_located_in.GUID
        Else
            objSemItem_Ort = Nothing
        End If
        set_Applyable
    End Sub
    Private Sub get_SemItem_Land()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        If objUserControl_SemItemList_Land.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_SemItemList_Land.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_Land = New clsSemItem
            objSemItem_Land.GUID = objDRV_Selected.Item(objUserControl_SemItemList_Land.RowName_GUID)
            objSemItem_Land.Name = objDRV_Selected.Item(objUserControl_SemItemList_Land.RowName_Name)
            objSemItem_Land.GUID_Parent = objLocalConfig.SemItem_Type_Postleitzahl.GUID
            objSemItem_Land.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Land.Direction = objSemItem_Land.Direction_RightLeft
            objSemItem_Land.GUID_Related = objLocalConfig.SemItem_Type_Ort.GUID
            objSemItem_Land.GUID_Relation = objLocalConfig.SemItem_RelationType_located_in.GUID
        Else
            objSemItem_Land = Nothing
        End If
        set_Applyable
    End Sub
    Private Sub selected_ORT() Handles objUserControl_SemItemList_Ort.Selection_Changed
        
        Dim boolFilter_PLZ As Boolean
        Dim boolFilter_Land As Boolean
        Dim intCount As Integer

        get_SemItem_Ort()
        If Not objSemItem_Ort Is Nothing Then
            boolFilter_PLZ = True
            get_SemItem_PLZ()
            If Not objSemItem_PLZ Is Nothing Then
                intCount = semtbl_Token_Token.Count_By_GUIDs(objSemItem_PLZ.GUID, objSemItem_Ort.GUID, objSemItem_Ort.GUID_Relation)
                If intCount > 0 Then
                    boolFilter_PLZ = False
                End If

            End If
            If boolFilter_PLZ = True Then
                objSemItem_PLZ = Nothing
                objUserControl_SemItemList_PLZ.filter_View_Item(objSemItem_Ort)
            End If


            objSemItem_Ort.Direction = objSemItem_Ort.Direction_LeftRight
            objSemItem_Ort.GUID_Related = objLocalConfig.SemItem_Type_Land.GUID
            objSemItem_Ort.GUID_Relation = objLocalConfig.SemItem_RelationType_located_in.GUID
            boolFilter_Land = True
            get_SemItem_Land()
            If Not objSemItem_Land Is Nothing Then
                intCount = semtbl_Token_Token.Count_By_GUIDs(objSemItem_Ort.GUID, objSemItem_Land.GUID, objSemItem_Ort.GUID_Relation)
                If intCount > 0 Then
                    boolFilter_Land = False
                End If

            End If
            If boolFilter_Land = True Then
                objSemItem_Land = Nothing
                objUserControl_SemItemList_Land.filter_View_Item(objSemItem_Ort)
            End If
        End If
        



    End Sub

    Private Sub selected_Land() Handles objUserControl_SemItemList_Land.Selection_Changed
        Dim boolFilter_Ort As Boolean
        Dim intCount As Integer

        get_SemItem_Land()
        If Not objSemItem_Land Is Nothing Then
            boolFilter_Ort = True
            get_SemItem_Ort()
            If Not objSemItem_Ort Is Nothing Then
                intCount = semtbl_Token_Token.Count_By_GUIDs(objSemItem_Ort.GUID, objSemItem_Land.GUID, objSemItem_Land.GUID_Relation)
                If intCount > 0 Then
                    boolFilter_Ort = False
                End If
            End If
            If boolFilter_Ort = True Then
                objSemItem_Ort = Nothing
                objUserControl_SemItemList_Ort.filter_View_Item(objSemItem_Land)
            End If
        End If
    End Sub

    Private Sub ToolStripButton_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Clear.Click
        initialize()
    End Sub

    Private Sub ToolStripButton_Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Apply.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub
End Class