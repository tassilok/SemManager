Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class clsSecurity

    Public Function encode_String(ByVal strPassword As String, ByVal strKey As String) As String
        Dim rd As New RijndaelManaged
        Dim md5 As New MD5CryptoServiceProvider
        Dim key() As Byte = md5.ComputeHash(Encoding.UTF8.GetBytes(strKey))
        md5.Clear()
        rd.Key = key
        rd.GenerateIV()

        Dim iv() As Byte = rd.IV
        Dim ms As New MemoryStream

        ms.Write(iv, 0, iv.Length)

        Dim cs As New CryptoStream(ms, rd.CreateEncryptor, CryptoStreamMode.Write)
        Dim data() As Byte = System.Text.Encoding.UTF8.GetBytes(strPassword)

        cs.Write(data, 0, data.Length)
        cs.FlushFinalBlock()

        Dim encdata() As Byte = ms.ToArray()
        Return (Convert.ToBase64String(encdata))
        cs.Close()
        rd.Clear()

    End Function

    Public Function decode_String(ByVal strPassword As String, ByVal strKey As String) As String
        Dim rd As New RijndaelManaged
        Dim rijndaelIvLength As Integer = 16
        Dim md5 As New MD5CryptoServiceProvider
        Dim key() As Byte = md5.ComputeHash(Encoding.UTF8.GetBytes(strKey))

        md5.Clear()

        Dim encdata() As Byte = Convert.FromBase64String(strPassword)
        Dim ms As New MemoryStream(encdata)
        Dim iv(15) As Byte

        ms.Read(iv, 0, rijndaelIvLength)
        rd.IV = iv
        rd.Key = key

        Dim cs As New CryptoStream(ms, rd.CreateDecryptor, CryptoStreamMode.Read)

        Dim data(ms.Length - rijndaelIvLength) As Byte
        Dim i As Integer = cs.Read(data, 0, data.Length)

        Return System.Text.Encoding.UTF8.GetString(data, 0, i)
        cs.Close()
        rd.Clear()

    End Function
End Class

