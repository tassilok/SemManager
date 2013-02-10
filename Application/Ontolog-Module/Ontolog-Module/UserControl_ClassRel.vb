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
    End Sub

    Private Sub get_Data_ClassRelations()
        Dim oList_Classes As New List(Of clsOntologyItem)

        oList_Classes.Add(objOItem_Class)


    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)
    End Sub
End Class
