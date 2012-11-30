Imports System.Diagnostics
Public Class clsShellWork
    Private objProcess As Process
    Private objStartInfo As ProcessStartInfo


    Public Function start_Process(ByVal strPath As String, ByVal strParameters As String, ByVal strWorkingDirectory As String, ByVal boolWait As Boolean, ByVal boolBackground As Boolean) As Boolean
        Dim boolResult As Boolean

        objProcess = New Process
        objStartInfo = objProcess.StartInfo
        strPath = Environment.ExpandEnvironmentVariables(strPath)
        objStartInfo.FileName = strPath
        If Not strWorkingDirectory Is Nothing Then
            objStartInfo.WorkingDirectory = strWorkingDirectory
        End If

        If Not strParameters = "" Then
            strParameters = Environment.ExpandEnvironmentVariables(strParameters)
            objStartInfo.Arguments = strParameters
        End If

        objStartInfo.RedirectStandardOutput = False
        objStartInfo.UseShellExecute = True
        If boolBackground = True Then
            objStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        Else
            objStartInfo.WindowStyle = ProcessWindowStyle.Normal
        End If

        Try
            objProcess = Diagnostics.Process.Start(objStartInfo)
            If boolWait = True Then
                objProcess.WaitForExit()
            End If
            boolResult = True
        Catch ex As Exception
            boolResult = False
        End Try

        Return boolResult
    End Function
End Class
