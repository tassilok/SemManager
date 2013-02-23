Public Class UserControl_ObjectAtt

    Private objLocalConfig As clsLocalConfig

    Private objDBLevel_ObjAtt As clsDBLevel

    Private objOList_Object As List(Of clsOntologyItem)
    Private objOList_AttributeType As List(Of clsOntologyItem)
    Private objOList_DataType As List(Of clsOntologyItem)

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
                                  ByVal OList_AttributeType As List(Of clsOntologyItem), _
                                  ByVal OList_DataType As List(Of clsOntologyItem))

        objOList_Object = OList_Object
        objOList_AttributeType = OList_AttributeType
        objOList_DataType = OList_DataType

        Try
            objThread.Abort()
        Catch ex As Exception

        End Try

        boolDataDone = False

        objThread = New Threading.Thread(AddressOf get_Data)

        Timer_ObjectAtt.Stop()
        Timer_ObjectAtt.Start()
    End Sub

    Private Sub get_Data()

    End Sub

    Private Sub set_DBConnection()
        objDBLevel_ObjAtt = New clsDBLevel(objLocalConfig)
    End Sub
End Class
