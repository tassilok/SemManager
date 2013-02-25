Public Class UserControl_ClassRel

    Private objLocalConfig As clsLocalConfig

    Private objDBLevel As clsDBLevel

    Private objOItem_Class As clsOntologyItem

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
        
        
    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)
    End Sub
End Class
