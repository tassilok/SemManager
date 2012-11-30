Public Class frmDBSelection

    Private objLocalConfig As clsLocalConfig_SemManager

    Private objSemItem_DB As New clsSemItem

    Private chngtblA_DB As New ds_ChangeTableAdapters.chngtbl_DBTableAdapter
    Private chngtblT_DB As New ds_Change.chngtbl_DBDataTable

    Public ReadOnly Property SemItem_DB As clsSemItem
        Get
            Return objSemItem_DB
        End Get
    End Property

    Private Sub Button_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_OK.Click
        If ListView_DB.SelectedItems.Count = 1 Then
            get_SelectedDB()
            DialogResult = Windows.Forms.DialogResult.OK
            Me.Hide()
        End If
    End Sub

    Private Sub Button_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Cancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Hide()
    End Sub

    Private Sub get_SelectedDB()
        Dim objListItem_DB As ListViewItem
        Dim objDRs_DB As DataRow()

        If ListView_DB.SelectedItems.Count = 1 Then
            objListItem_DB = ListView_DB.SelectedItems(0)
            objDRs_DB = chngtblT_DB.Select("GUID_DB='" & objListItem_DB.Name & "'")
            objSemItem_DB = New clsSemItem
            objSemItem_DB.GUID = objDRs_DB(0).Item("GUID_DB")
            objSemItem_DB.Name = objDRs_DB(0).Item("Name_DB")
        Else
            objSemItem_DB = Nothing
        End If

    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig_SemManager)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        set_DBConnection()
        fill_DBs()
    End Sub

    Private Sub fill_DBs()

        Dim objDR_Database As DataRow

        For Each objDR_Database In chngtblT_DB.Rows
            ListView_DB.Items.Add(objDR_Database.Item("GUID_DB").ToString, objDR_Database.Item("Name_DB"), 0)

        Next

    End Sub

    Private Sub set_DBConnection()
        chngtblA_DB.Connection = objLocalConfig.Connection_Config
        chngtblA_DB.Fill(chngtblT_DB)
    End Sub

    Private Sub ListView_DB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView_DB.DoubleClick
        get_SelectedDB()
        Button_OK.PerformClick()
    End Sub
End Class