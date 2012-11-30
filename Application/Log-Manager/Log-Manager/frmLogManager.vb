Imports Sem_Manager
Public Class frmLogManager
    Private objLocalConfig As clsLocalConfig

    Private WithEvents objUserControl_Logentries As UserControl_SemItemList
    Private WithEvents objUserControl_LogEntry As UserControl_Logentry

    Private objSemItem_LogEntry As clsSemItem

    Private Sub selected_Logentry() Handles objUserControl_Logentries.Selection_Changed
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        objSemItem_LogEntry = Nothing

        If objUserControl_Logentries.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_Logentries.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_LogEntry = New clsSemItem
            objSemItem_LogEntry.GUID = objDRV_Selected.Item("GUID_Token")
            objSemItem_LogEntry.Name = objDRV_Selected.Item("Name_Token")
            objSemItem_LogEntry.GUID_Parent = objLocalConfig.SemItem_Type_LogEntry.GUID
            objSemItem_LogEntry.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objUserControl_LogEntry.initialize(objSemItem_LogEntry)
        Else
            objUserControl_LogEntry.clear_Controls()
        End If
    End Sub

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        initialize()
    End Sub

    Private Sub initialize()
        objUserControl_Logentries = New UserControl_SemItemList
        objUserControl_Logentries.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Add(objUserControl_Logentries)

        objUserControl_LogEntry = New UserControl_Logentry(objLocalConfig)
        objUserControl_LogEntry.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(objUserControl_LogEntry)

        objUserControl_Logentries.initialize_Simple(objLocalConfig.SemItem_Type_LogEntry, objLocalConfig.Globals)

    End Sub

    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Close()
    End Sub
End Class
