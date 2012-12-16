Imports Sem_Manager
Public Class UserControl_ReferenceThings
    Private procA_ProcessThing As New ds_ProcessTableAdapters.proc_ProcessThingTableAdapter
    Private procT_ProcessThing As New ds_Process.proc_ProcessThingDataTable

    Private objSemItem_ReferenceThing As clsSemItem
    Private objSemItem_Reference As clsSemItem
    Private objLocalConfig As clsLocalConfig

    Public Sub New(ByVal SemItem_ReferenceThing As clsSemItem, ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_ReferenceThing = SemItem_ReferenceThing
        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()

        get_Data()
        configure_Controls()
    End Sub

    Private Sub fill_Data()
        clear_Controls()
        If procT_ProcessThing.Rows.Count > 0 Then
            TextBox_Count.ReadOnly = True
            TextBox_Count.Text = procT_ProcessThing.Rows(0).Item("Count")
            TextBox_Count.ReadOnly = False


            TextBox_Reference.Text = procT_ProcessThing.Rows(0).Item("Name_Token")


        End If

    End Sub

    Private Sub clear_Controls()
        TextBox_Count.ReadOnly = True
        TextBox_Count.Text = ""
        TextBox_Count.ReadOnly = False

        TextBox_Reference.Text = ""
    End Sub

    Private Sub configure_Controls()
        ToolStripButton_Clear.Enabled = False
        TextBox_Count.Enabled = False
        ToolStripButton_Clear.Enabled = False
        Button_Add_Reference.Enabled = False

        TextBox_Count.Enabled = True
        Button_Add_Reference.Enabled = True
        
    End Sub

    Private Sub get_Data()
        procT_ProcessThing.Clear()

        If Not objSemItem_ReferenceThing Is Nothing Then
            procA_ProcessThing.Fill(procT_ProcessThing, _
                                    objLocalConfig.SemItem_Attribute_Count.GUID, _
                                    objLocalConfig.SemItem_Type_Things_References.GUID, _
                                    objLocalConfig.SemItem_RelationType_contains.GUID, _
                                    objSemItem_ReferenceThing.GUID)

        End If
    End Sub

    Private Sub set_DBConnection()
        procA_ProcessThing.Connection = objLocalConfig.Connection_Plugin
    End Sub

    Private Sub TextBox_Count_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Count.TextChanged
        Timer_Count.Stop()
        If TextBox_Count.ReadOnly = False Then
            Timer_Count.Start()
        End If
    End Sub

    Private Sub Timer_Count_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Count.Tick
        Dim strCount As String
        Dim intCount As Integer
        Timer_Count.Stop()
        strCount = TextBox_Count.Text

        If Integer.TryParse(strCount, intCount) Then

        Else
            TextBox_Count.ReadOnly = True
            TextBox_Count.Text = 0
            TextBox_Count.ReadOnly = False
        End If
    End Sub
End Class
