Imports Sem_Manager
Public Class frmFilterSort
    Private cint_ImageID_Root As Integer = 0
    Private cint_ImageID_Filters As Integer = 1
    Private cint_ImageID_Filter As Integer = 2
    Private cint_ImagreID_Sorts As Integer = 3
    Private cint_ImagreID_Sort As Integer = 4

    Private objLocalConfig As clsLocalConfig

    Private objSemItem_Report As clsSemItem

    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Hide()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
    End Sub

    Public Sub initialize(ByVal SemItem_Report As clsSemItem)
        objSemItem_Report = SemItem_Report


    End Sub
End Class