Imports Sem_Manager
Public Class frmBookMarks

    Private WithEvents objUserControl_BookMarks As UserControl_Bookmarks

    Private objLocalConfig As clsLocalConfig
    Private objMediaItemConfig As clsMediaItem_Config
    Private objSemItem_User As clsSemItem
    Private objSemItem_MediaItem As clsSemItem
    Private objSemItem_Ref As clsSemItem
    Private boolIsAuthenticated As Boolean

    Public Event set_Position(ByVal objSemItem_BookMark As clsSemItem)

    Private Sub selected_Bookmark(ByVal SemItem_Bookmark As clsSemItem) Handles objUserControl_BookMarks.activate_Bookmark
        RaiseEvent set_Position(SemItem_Bookmark)
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig, Optional ByVal SemItem_User As clsSemItem = Nothing, Optional ByVal isAuthenticated As Boolean = False)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        objSemItem_User = SemItem_User
        boolIsAuthenticated = isAuthenticated

        initialize()
    End Sub

    Private Sub initialize()
        objUserControl_BookMarks = New UserControl_Bookmarks(objLocalConfig)
        objUserControl_BookMarks.Dock = DockStyle.Fill
        ToolStripContainer1.ContentPanel.Controls.Clear()
        ToolStripContainer1.ContentPanel.Controls.Add(objUserControl_BookMarks)

        If boolIsAuthenticated = True Then
            If objSemItem_User Is Nothing Then
                objMediaItemConfig = New clsMediaItem_Config(objLocalConfig, Me)
                objMediaItemConfig.get_User()

                objSemItem_User = objMediaItemConfig.SemItem_User
            End If
        End If
        



    End Sub

    Public Sub initialize_MediaItem(ByVal SemItem_MediaItem As clsSemItem)
        objSemItem_MediaItem = SemItem_MediaItem
        objSemItem_Ref = Nothing
        objUserControl_BookMarks.initialize_MediaItem(objSemItem_MediaItem, objSemItem_User)
    End Sub

    Public Sub initialize_Ref(ByVal SemItem_Ref As clsSemItem)
        objSemItem_Ref = SemItem_Ref
        objSemItem_MediaItem = Nothing
        objUserControl_BookMarks.initialize_Ref(objSemItem_Ref, objSemItem_User)
    End Sub

    Private Sub frmBookMarks_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If boolIsAuthenticated = True And objSemItem_User Is Nothing Then

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            MsgBox("Sie müssen einen Benutzer auswählen!", MsgBoxStyle.Exclamation)
            Me.Close()
        End If

    End Sub
End Class