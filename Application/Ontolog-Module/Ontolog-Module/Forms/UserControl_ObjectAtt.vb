Public Class UserControl_ObjectAtt

    Private objLocalConfig As clsLocalConfig

    Private objDBLevel_ObjAtt As clsDBLevel

    Private objOItem_Object As clsOntologyItem
    Private objOItem_AttributeType As clsOntologyItem

    Private objThread As Threading.Thread
    Private boolDataDone As Boolean

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Public Sub initialize_RelList(ByVal OItem_Object As clsOntologyItem, _
                                  ByVal OItem_AttributeType As clsOntologyItem)

        objOItem_Object = OItem_Object
        objOItem_AttributeType = OItem_AttributeType

        BindingSource_ObjectAtt.DataSource = Nothing
        DataGridView_ObjectAtt.DataSource = Nothing

        Try
            objThread.Abort()
        Catch ex As Exception

        End Try

        boolDataDone = False

        objThread = New Threading.Thread(AddressOf get_Data)

        Timer_ObjectAtt.Stop()
        Timer_ObjectAtt.Start()
        objThread.Start()
    End Sub

    Private Sub get_Data()
        objDBLevel_ObjAtt.get_Data_ObjectAtt(objOItem_Object, _
                                             objOItem_AttributeType, True, _
                                             False)
        boolDataDone = True
    End Sub

    Private Sub set_DBConnection()
        objDBLevel_ObjAtt = New clsDBLevel(objLocalConfig)
    End Sub

    Private Sub Timer_ObjectAtt_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_ObjectAtt.Tick
        If boolDataDone = True Then
            Timer_ObjectAtt.Stop()
            BindingSource_ObjectAtt.DataSource = objDBLevel_ObjAtt.tbl_ObjectAttribute
            DataGridView_ObjectAtt.DataSource = BindingSource_ObjectAtt

            DataGridView_ObjectAtt.Columns(0).Visible = False
            DataGridView_ObjectAtt.Columns(1).Visible = False
            DataGridView_ObjectAtt.Columns(2).Visible = False
            DataGridView_ObjectAtt.Columns(3).Visible = False
            DataGridView_ObjectAtt.Columns(5).Visible = False
            DataGridView_ObjectAtt.Columns(6).Visible = False
            DataGridView_ObjectAtt.Columns(9).Visible = False
            DataGridView_ObjectAtt.Columns(10).Visible = False
            DataGridView_ObjectAtt.Columns(11).Visible = False
            DataGridView_ObjectAtt.Columns(12).Visible = False
            DataGridView_ObjectAtt.Columns(13).Visible = False
            DataGridView_ObjectAtt.Columns(14).Visible = False
            DataGridView_ObjectAtt.Columns(15).Visible = False


            ToolStripProgressBar_ObjectAtt.Value = 0
        Else
            ToolStripProgressBar_ObjectAtt.Value = 50
        End If
    End Sub
End Class
