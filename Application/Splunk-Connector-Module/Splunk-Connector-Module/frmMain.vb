﻿Imports Sem_Manager

Public Class frmMain
    Private objLocalConfig As clsLocalConfig

    Private objSplunk As clsSplunk

    Private objSemItem_TestReport As New clsSemItem

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)

        initialize()
    End Sub

    Private Sub initialize()

    End Sub

End Class
