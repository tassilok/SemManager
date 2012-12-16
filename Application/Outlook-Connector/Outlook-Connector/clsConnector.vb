Imports Microsoft.Office.Interop.Outlook
Imports System.Runtime.InteropServices
Public Class clsConnector
    Private mltblA_MailItems As New DataSet_OutlookConnectorTableAdapters.proc_MailItemsTableAdapter

    Private objLocalConfig As clsLocalConfig
    Private objOutlook As Microsoft.Office.Interop.Outlook.Application
    Private objMapi As Microsoft.Office.Interop.Outlook.NameSpace
    Private objFolder As Folder

    Public ReadOnly Property State_Outlook() As String
        Get
            objOutlook = CType(Marshal.GetActiveObject("Outlook.Application"), Microsoft.Office.Interop.Outlook.Application)
            If Not objOutlook.ActiveExplorer.CurrentFolder Is Nothing Then
                Return "Running"
            Else
                Return "Not Running"
            End If

            objOutlook = Nothing
        End Get
    End Property

    Public ReadOnly Property CurrentFolder As String
        Get
            objOutlook = CType(Marshal.GetActiveObject("Outlook.Application"), Microsoft.Office.Interop.Outlook.Application)
            If Not objOutlook.ActiveExplorer.CurrentFolder Is Nothing Then
                Return objOutlook.ActiveExplorer.CurrentFolder.Name
            Else
                Return "-"
            End If
            objOutlook = Nothing
        End Get
    End Property

    Private Sub get_MailItemsFromOutlook_Recurse(Optional ByVal objFolder As Microsoft.Office.Interop.Outlook.Folder = Nothing)
        Dim objSubFolder As Microsoft.Office.Interop.Outlook.Folder
        Dim objMailItem As Microsoft.Office.Interop.Outlook.MailItem
        Dim objReciepent As Microsoft.Office.Interop.Outlook.Recipient
        Dim itemType As Type
        Dim strType As String
        Dim strTo As String

        Dim i As Long

        If objFolder Is Nothing Then
            objFolder = objOutlook.ActiveExplorer.CurrentFolder

        End If

        For i = 1 To objFolder.Items.Count
            itemType = objFolder.Items(i).GetType
            strType = DirectCast(itemType.InvokeMember("MessageClass", Reflection.BindingFlags.Public Or Reflection.BindingFlags.GetProperty Or Reflection.BindingFlags.Instance, Nothing, objFolder.Items(i), New Object(-1) {}), String)

            ' Nachrichtenklasse zurückgeben

            If strType = "IPM.Note" Then
                objMailItem = objFolder.Items(i)
                strTo = ""
                For Each objReciepent In objMailItem.Recipients
                    If Not strTo = "" Then
                        strTo = strTo & ";"
                    End If
                    strTo = strTo & objReciepent.Address
                Next
                mltblA_MailItems.proc_insertMailitem(objMailItem.EntryID, _
                                                 objMailItem.SenderEmailAddress, _
                                                 objMailItem.SenderName, _
                                                 objMailItem.SentOn, _
                                                 strTo, _
                                                 objMailItem.Subject, _
                                                 objFolder.Name)
            End If
        Next

        For Each objSubFolder In objFolder.Folders
            get_MailItemsFromOutlook_Recurse(objSubFolder)
        Next
    End Sub

    Public Sub open_MailItem(ByVal strEntryID As String)
        Dim objMailItem As MailItem
        objOutlook = New Microsoft.Office.Interop.Outlook.Application
        objMapi = objOutlook.GetNamespace("Mapi")

        objMailItem = objMapi.GetItemFromID(strEntryID)
        If Not objMailItem Is Nothing Then
            objMailItem.Display()
        Else
            MsgBox("No Item", MsgBoxStyle.Exclamation)
        End If


        objMapi = Nothing
        objOutlook = Nothing
    End Sub


    Public Sub get_MailItemsFromOutlook()

        objOutlook = New Microsoft.Office.Interop.Outlook.Application

        get_MailItemsFromOutlook_Recurse()


        objOutlook = Nothing
    End Sub
    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        mltblA_MailItems.Connection = objLocalConfig.Connection_Plugin
    End Sub
End Class
