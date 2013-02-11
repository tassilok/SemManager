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

    Private objThread As Threading.Thread
    Private boolDataDone As Boolean

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
        objOList_RelationType_LeftRight = OList_RelationType_LeftRight
        objOList_RelationType_RightLeft = OList_RelationType_RightLeft

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

        objDBLevel_ObjRel.get_Data_ObjectRel(objOList_Object(0), Nothing, Nothing, True, False)

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
            DataGridView_Relations.Columns(12).Visible = False
            ToolStripProgressBar_TokenRelation.Value = 0
        Else
            ToolStripProgressBar_TokenRelation.Value = 50
        End If
    End Sub
End Class
