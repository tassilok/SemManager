Public Class UserControl_ClassAttributeTypes

    Private objLocalConfig As clsLocalConfig

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
        objDBLevel.get_Data_ClassAtt(objList_Classes, True)

        BindingSource_AttributeTypes.DataSource = objDBLevel.tbl_ClassAtt
        DataGridView_AttributeTypes.DataSource = BindingSource_AttributeTypes

        DataGridView_AttributeTypes.Columns(0).Visible = False
        DataGridView_AttributeTypes.Columns(1).Visible = False
        DataGridView_AttributeTypes.Columns(2).Visible = False
    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)
    End Sub

End Class
