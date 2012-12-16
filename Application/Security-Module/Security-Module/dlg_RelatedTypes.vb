Imports System.Windows.Forms
Imports Sem_Manager

Public Class dlg_RelatedTypes
    Private objLocalConfig As clsLocalConfig
    Private funcA_Types_Rel As New ds_TypeTableAdapters.typefunc_Types_RelTableAdapter
    Private funcT_Types_Rel As New ds_Type.typefunc_Types_RelDataTable

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Private Sub get_Data()

    End Sub

    Private Sub fill_DG()

    End Sub

    Private Sub initialize()
        set_DBConnection()
        get_Data()
        fill_DG()
    End Sub
    Private Sub set_DBConnection()
        funcA_Types_Rel.Connection = objLocalConfig.Connection_DB
    End Sub

End Class
