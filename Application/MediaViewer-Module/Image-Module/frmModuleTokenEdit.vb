Imports Sem_Manager
Public Class frmModuleTokenEdit

    Private objLocalConfig As clsLocalConfig
    Private objSemItem_Token As clsSemItem
    Private objUserControl_EditImage As UserControl_EditImage
    Private objUserControl_EditPDF As UserControl_EditPDF
    Private objUserControl_EditMediaItem As UserControl_EditMediaItem

    Public ReadOnly Property SemItem_Result As clsSemItem
        Get
            Return objSemItem_Token
        End Get
    End Property

    Public Sub New(ByVal SemItem_Token As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        objSemItem_Token = SemItem_Token
        initialize()
    End Sub

    Public Sub New(ByVal SemItem_Token As clsSemItem, ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        objSemItem_Token = SemItem_Token
        initialize()
    End Sub

    Private Sub initialize()
        If Not objSemItem_Token Is Nothing Then
            Select Case objSemItem_Token.GUID_Parent
                Case objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                    objUserControl_EditImage = New UserControl_EditImage(objLocalConfig)
                    objUserControl_EditImage.Dock = DockStyle.Fill
                    Me.Controls.Clear()
                    Me.Controls.Add(objUserControl_EditImage)
                    objUserControl_EditImage.initialize(objSemItem_Token)
                Case objLocalConfig.SemItem_Type_Media_Item.GUID
                    objUserControl_EditMediaItem = New UserControl_EditMediaItem(objSemItem_Token, objLocalConfig)
                    objUserControl_EditMediaItem.Dock = DockStyle.Fill
                    Me.Controls.Clear()
                    Me.Controls.Add(objUserControl_EditMediaItem)
                Case objLocalConfig.SemItem_Type_PDF_Documents.GUID
                    objUserControl_EditPDF = New UserControl_EditPDF(objSemItem_Token, objLocalConfig)
                    objUserControl_EditPDF.Dock = DockStyle.Fill
                    Me.Controls.Clear()
                    Me.Controls.Add(objUserControl_EditPDF)
            End Select
        Else
            Me.Controls.Clear()
        End If

    End Sub
End Class