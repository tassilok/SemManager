Imports Sem_Manager
Public Class UserControl_Flaeche
    Private objLocalConfig As clsLocalConfig

    Private objTransaction_Flaeche As clsTransaction_FlaecheVolumen

    Private WithEvents objUserControl_Menge_X As UserControl_Menge
    Private WithEvents objUserControl_Menge_Y As UserControl_Menge

    Public Event saved_Flaeche(ByVal objSemItem_Flaeche As clsSemItem)

    Private objFrmParent As Windows.Forms.IWin32Window

    Private dblX As Double
    Private dblY As Double
    Private objSemItem_Einheit_X As clsSemItem
    Private objSemItem_Einheit_Y As clsSemItem
    Private objSemItem_Menge_X As clsSemItem
    Private objSemItem_Menge_Y As clsSemItem

    Private Sub saved_X(ByVal objSemItem_Menge As clsSemItem) Handles objUserControl_Menge_X.saved_Menge
        objSemItem_Einheit_X = objUserControl_Menge_X.SemItem_Einheit

        objSemItem_Menge_X = objSemItem_Menge
        save_Flaeche()
    End Sub

    Private Sub saved_Y(ByVal objSemItem_Menge As clsSemItem) Handles objUserControl_Menge_Y.saved_Menge
        objSemItem_Einheit_Y = objUserControl_Menge_Y.SemItem_Einheit

        objSemItem_Menge_Y = objSemItem_Menge
        save_Flaeche()
    End Sub

    Public Sub clear_Flaeche()
        objUserControl_Menge_X.clear_Menge()
        objUserControl_Menge_Y.clear_Menge()
        objSemItem_Einheit_X = Nothing
        objSemItem_Einheit_Y = Nothing
        objSemItem_Menge_X = Nothing
        objSemItem_Menge_Y = Nothing
        Label_Result.Text = "-"
    End Sub

    Private Sub save_Flaeche()
        Dim objSemItem_Result As clsSemItem
        If Not objSemItem_Menge_X Is Nothing Then
            If Not objSemItem_Menge_Y Is Nothing Then
                objSemItem_Result = objTransaction_Flaeche.save_001_Flaeche(objSemItem_Menge_X, objSemItem_Menge_Y)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Or objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_Flaeche.save_002_FlaechVol_To_Menge_X(objSemItem_Menge_X)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Flaeche.save_003_FlaechVol_To_Menge_Y(objSemItem_Menge_Y)

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                RaiseEvent saved_Flaeche(objTransaction_Flaeche.SemItem_Flaeche)
                            Else
                                objSemItem_Result = objTransaction_Flaeche.del_002_FlaechVol_To_Menge_X
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objTransaction_Flaeche.del_001_Flaeche()
                                End If

                                RaiseEvent saved_Flaeche(Nothing)
                                MsgBox("Die Fläche konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If

                        Else
                            objTransaction_Flaeche.del_001_Flaeche()
                            RaiseEvent saved_Flaeche(Nothing)
                            MsgBox("Die Fläche konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        RaiseEvent saved_Flaeche(Nothing)
                    End If
                Else
                    RaiseEvent saved_Flaeche(Nothing)
                    MsgBox("Die Fläche konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If

            End If

        End If
    End Sub

    Public Sub initialize_Flaeche(Optional ByVal dblFlaeche As Double = Nothing, Optional ByVal dblX As Double = Nothing, Optional ByVal SemItem_Einheit_X As clsSemItem = Nothing, Optional ByVal dblY As Double = Nothing, Optional ByVal SemItem_Einheit_Y As clsSemItem = Nothing)
        Me.dblX = dblX
        Me.dblY = dblY
        objSemItem_Einheit_X = SemItem_Einheit_X
        objSemItem_Einheit_Y = SemItem_Einheit_Y

        objUserControl_Menge_X.initialize_Menge(objSemItem_Einheit_X, dblX)
        objUserControl_Menge_Y.initialize_Menge(objSemItem_Einheit_Y, dblY)

        If Not dblFlaeche = Nothing Then
            Label_Result.Text = dblFlaeche.ToString
        Else
            Label_Result.Text = "-"
        End If
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal frmParent As Windows.Forms.IWin32Window)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objFrmParent = frmParent
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals, ByVal frmParent As Windows.Forms.IWin32Window)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objFrmParent = frmParent
        objLocalConfig = New clsLocalConfig(Globals)
        initialize()
    End Sub

    Private Sub initialize()
        objUserControl_Menge_X = New UserControl_Menge(objLocalConfig.Globals, objFrmParent)
        objUserControl_Menge_X.Dock = DockStyle.Fill
        Panel_X.Controls.Clear()
        Panel_X.Controls.Add(objUserControl_Menge_X)

        objUserControl_Menge_Y = New UserControl_Menge(objLocalConfig.Globals, objFrmParent)
        objUserControl_Menge_Y.Dock = DockStyle.Fill
        Panel_Y.Controls.Clear()
        Panel_Y.Controls.Add(objUserControl_Menge_Y)

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objTransaction_Flaeche = New clsTransaction_FlaecheVolumen(objLocalConfig.Globals)
    End Sub
End Class
