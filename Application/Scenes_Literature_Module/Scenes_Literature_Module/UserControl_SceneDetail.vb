Imports Sem_Manager
Imports MediaViewer_Module
Public Class UserControl_SceneDetail
    Private WithEvents objUserControl_MediaItem As UserControl_MediaItem
    Private WithEvents objUserControl_Image As UserControl_Galery
    Private WithEvents objUserControl_PDF As UserControl_PDFViewer
    Private WithEvents objUserControl_LiterarischesDatum As UserControl_SemItemList
    Private WithEvents objUserControl_LiterarischerCharakter As UserControl_SemItemList
    Private WithEvents objUserControl_LiterarischerOrt As UserControl_SemItemList


    Private objLocalConfig As clsLocalConfig
    Private objSemItem_Scene As clsSemItem
    Private objSemItem_Scene_LiterarischerCharakter As clsSemItem
    Private objSemItem_Scene_LiterarischerOrt As clsSemItem
    Private objSemItem_Scene_LiterarischesDatum As clsSemItem

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig



        initialize()
    End Sub

    Public Sub initialize_Scenes(ByVal SemItem_Scene As clsSemItem)
        objSemItem_Scene = SemItem_Scene

        

        If Not objSemItem_Scene Is Nothing Then
            objSemItem_Scene_LiterarischerCharakter = New clsSemItem
            objSemItem_Scene_LiterarischerCharakter.GUID = objSemItem_Scene.GUID
            objSemItem_Scene_LiterarischerCharakter.Name = objSemItem_Scene.Name
            objSemItem_Scene_LiterarischerCharakter.GUID_Parent = objSemItem_Scene.GUID_Parent
            objSemItem_Scene_LiterarischerCharakter.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Scene_LiterarischerCharakter.GUID_Related = objLocalConfig.SemItem_Type_literarischer_Charakter.GUID
            objSemItem_Scene_LiterarischerCharakter.GUID_Relation = objLocalConfig.SemItem_RelationType_contains.GUID
            objSemItem_Scene_LiterarischerCharakter.Direction = objSemItem_Scene_LiterarischerCharakter.Direction_LeftRight

            objSemItem_Scene_LiterarischerOrt = New clsSemItem
            objSemItem_Scene_LiterarischerOrt.GUID = objSemItem_Scene.GUID
            objSemItem_Scene_LiterarischerOrt.Name = objSemItem_Scene.Name
            objSemItem_Scene_LiterarischerOrt.GUID_Parent = objSemItem_Scene.GUID_Parent
            objSemItem_Scene_LiterarischerOrt.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Scene_LiterarischerOrt.GUID_Related = objLocalConfig.SemItem_Type_Literarischer_Ort.GUID
            objSemItem_Scene_LiterarischerOrt.GUID_Relation = objLocalConfig.SemItem_RelationType_located_in.GUID
            objSemItem_Scene_LiterarischerOrt.Direction = objSemItem_Scene_LiterarischerCharakter.Direction_LeftRight

            objSemItem_Scene_LiterarischesDatum = New clsSemItem
            objSemItem_Scene_LiterarischesDatum.GUID = objSemItem_Scene.GUID
            objSemItem_Scene_LiterarischesDatum.Name = objSemItem_Scene.Name
            objSemItem_Scene_LiterarischesDatum.GUID_Parent = objSemItem_Scene.GUID_Parent
            objSemItem_Scene_LiterarischesDatum.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Scene_LiterarischesDatum.GUID_Related = objLocalConfig.SemItem_Type_literarisches_Datum.GUID
            objSemItem_Scene_LiterarischesDatum.GUID_Relation = objLocalConfig.SemItem_RelationType_findet_statt_am.GUID
            objSemItem_Scene_LiterarischesDatum.Direction = objSemItem_Scene_LiterarischerCharakter.Direction_LeftRight

            objUserControl_LiterarischerCharakter.initialize_Complex(objSemItem_Scene_LiterarischerCharakter, objLocalConfig.Globals)
            objUserControl_LiterarischerOrt.initialize_Complex(objSemItem_Scene_LiterarischerOrt, objLocalConfig.Globals)
            objUserControl_LiterarischesDatum.initialize_Complex(objSemItem_Scene_LiterarischesDatum, objLocalConfig.Globals)

            Label_SceneName.Text = objSemItem_Scene.Name
            objUserControl_Image = New UserControl_Galery(objSemItem_Scene, objLocalConfig.Globals)
            objUserControl_Image.allow_Edit = True
            objUserControl_Image.Dock = DockStyle.Fill
            objUserControl_MediaItem = New UserControl_MediaItem(objSemItem_Scene, objLocalConfig.Globals)
            objUserControl_MediaItem.Allow_Edit = True
            objUserControl_MediaItem.Dock = DockStyle.Fill
            objUserControl_PDF = New UserControl_PDFViewer(objSemItem_Scene, objLocalConfig.Globals)
            objUserControl_PDF.Dock = DockStyle.Fill
            objUserControl_LiterarischerCharakter.Enabled = True
            objUserControl_LiterarischerOrt.Enabled = True
            objUserControl_LiterarischesDatum.Enabled = True
            configure_TabPages()
        Else
            Label_SceneName.Text = "-"
            objUserControl_LiterarischerCharakter.Enabled = False
            objUserControl_LiterarischerOrt.Enabled = False
            objUserControl_LiterarischesDatum.Enabled = False

            TabPage_Images.Controls.Clear()

            TabPage_MediaItems.Controls.Clear()

            TabPage_PDF.Controls.Clear()

        End If
        
    End Sub

    Private Sub initialize()

        
        objUserControl_LiterarischerCharakter = New UserControl_SemItemList()
        objUserControl_LiterarischerCharakter.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_LiterarischerOrt = New UserControl_SemItemList()
        objUserControl_LiterarischerOrt.Dock = Windows.Forms.DockStyle.Fill
        objUserControl_LiterarischesDatum = New UserControl_SemItemList()
        objUserControl_LiterarischesDatum.Dock = Windows.Forms.DockStyle.Fill

        Panel_LiterarischerCharakter.Controls.Add(objUserControl_LiterarischerCharakter)

        Panel_LiterarischerOr.Controls.Add(objUserControl_LiterarischerOrt)

        Panel_LiterarischesDatum.Controls.Add(objUserControl_LiterarischesDatum)


        objUserControl_LiterarischerCharakter.Enabled = False
        objUserControl_LiterarischerOrt.Enabled = False
        objUserControl_LiterarischesDatum.Enabled = False
        TabPage_Images.Controls.Clear()

        TabPage_MediaItems.Controls.Clear()

        TabPage_PDF.Controls.Clear()
    End Sub

    Private Sub configure_TabPages()
        Select Case TabControl_Medias.SelectedTab.Name
            Case TabPage_Images.Name
                TabPage_Images.Controls.Clear()
                TabPage_Images.Controls.Add(objUserControl_Image)
            Case TabPage_MediaItems.Name
                TabPage_MediaItems.Controls.Clear()
                TabPage_MediaItems.Controls.Add(objUserControl_MediaItem)

            Case TabPage_PDF.Name
                TabPage_PDF.Controls.Clear()
                TabPage_PDF.Controls.Add(objUserControl_PDF)
        End Select
    End Sub

    Private Sub TabControl_Medias_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl_Medias.SelectedIndexChanged
        configure_TabPages()
    End Sub
End Class
