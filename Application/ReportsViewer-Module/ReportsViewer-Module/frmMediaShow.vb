Imports Sem_Manager
Imports MediaViewer_Module
Public Class frmMediaShow
    Private Const cint_Image As Integer = 0
    Private Const cint_MediaItem As Integer = 1
    Private Const cint_PDF As Integer = 2


    Private objUserControl_Galery As UserControl_Galery
    Private objUserControl_PDFViewer As UserControl_PDFViewer
    Private objUserControl_MediaItem As UserControl_MediaItem

    Private objLocalConfig As clsLocalConfig

    Private objSemItem_Ref As clsSemItem

    Private intType As Integer

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal intType As Integer, ByVal SemItem_Ref As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.intType = intType

        objSemItem_Ref = SemItem_Ref

        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Private Sub initialize()
        Select Case intType
            Case cint_Image
                objUserControl_Galery = New UserControl_Galery(objSemItem_Ref, objLocalConfig.Globals)
                objUserControl_Galery.Dock = DockStyle.Fill
                Me.Controls.Add(objUserControl_Galery)
            Case cint_MediaItem
                objUserControl_MediaItem = New UserControl_MediaItem(objSemItem_Ref, objLocalConfig.Globals)
                objUserControl_MediaItem.Dock = DockStyle.Fill
                Me.Controls.Add(objUserControl_MediaItem)
            Case cint_PDF
                objUserControl_PDFViewer = New UserControl_PDFViewer(objSemItem_Ref, objLocalConfig.Globals)
                objUserControl_PDFViewer.Dock = DockStyle.Fill
                Me.Controls.Add(objUserControl_PDFViewer)
        End Select
    End Sub
End Class