Public Class clsMediaPlayer
    ' Schreiben Sie den folgenden Code in ein öffentliches Modul
    Private Declare Function GetProfileString Lib "kernel32" _
      Alias "GetProfileStringA" ( _
      ByVal lpAppName As String, _
      ByVal lpKeyName As String, _
      ByVal lpDefault As String, _
      ByVal lpReturnedString As String, _
      ByVal nSize As Long) As Long
    Private Declare Function mciSendString Lib "winmm.dll" _
      Alias "mciSendStringA" ( _
      ByVal lpstrCommand As String, _
      ByVal lpstrReturnString As String, _
      ByVal uReturnLength As Long, _
      ByVal hwndCallback As Long) As Long
    Private Declare Function mciGetErrorString Lib "winmm.dll" _
      Alias "mciGetErrorStringA" ( _
      ByVal dwError As Long, _
      ByVal lpstrBuffer As String, _
      ByVal uLength As Long) As Long
    Private Declare Function GetShortPathNameA Lib "kernel32" ( _
      ByVal lpszLongPath As String, _
      ByVal lpszShortPath As String, _
      ByVal cchBuffer As Long) As Long
    

    ' die MCISendString Callback Konstanten
    Private Const MM_MCINOTIFY = &H3B9 ' wird an die Standard Fensterprozedur geschickt  
    ' falls bei Ereignissen
    Private Const MCI_NOTIFY_ABORTED = &H4 ' Wiedergabe wurde abgebrochen
    Private Const MCI_NOTIFY_FAILURE = &H8 ' ein Fehler ist beim Aufruf aufgetreten
    Private Const MCI_NOTIFY_SUCCESSFUL = &H1 ' der Befehl wurde erfolgreich ausgeführt
    Private Const MCI_NOTIFY_SUPERSEDED = &H2 ' ein anderes Gerät bekommt die  
    ' Nachrichten, das eigene Programm wird nicht mehr benachrichtigt


    Private OpenAlias As Boolean
    Private Const StdAlias = "TmpAlias"



    Private strCommand_Open As String
    Private strCommand_Play As String

    Private strPath As String

    Public Sub play_Video()
        mciSendString(strCommand_Open, Nothing, 0, 0)
        mciSendString(strCommand_Play, Nothing, 0, 0)
    End Sub
    

    


    Public Sub New(ByVal Path As String)
        strPath = Path

        strCommand_Open = "open " & Chr(34) & strPath & Chr(34) & " type digitalvideo alias Video"
        strCommand_Play = "play Video"
    End Sub
End Class
