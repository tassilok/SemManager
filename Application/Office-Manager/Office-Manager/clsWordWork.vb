Imports Microsoft.Office.Interop.Word
Imports System.Runtime.InteropServices

Public Class clsWordWork

    Private Const wdFieldEmpty As Integer = -1
    Private Const wdCharacter As Integer = 1
    Private Const wdBulletGallery As Integer = 1
    Private Const wdTrailingTab As Integer = 0
    Private Const wdListNumberStyleBullet As Integer = 23
    Private Const wdListApplyToWholeList As Integer = 0
    Private Const wdWord10ListBehavior As Integer = 2
    Private Const wdSortByName As Integer = 0
    Private Const wdGoToBookmark As Integer = -1

    Private objWord As Application
    Private objWordDocs() As clsWordDocument
    Private strFilePath_LastAction As String
    Private strFileName As String

    Private intDocID As Integer
    Private boolVisible As Boolean
    Public ReadOnly Property FilePath_LastAction() As String
        Get
            Return strFilePath_LastAction
        End Get
    End Property
    Public ReadOnly Property FilePath_Active_Doc() As String
        Get
            open_Word()
            Return objWord.ActiveDocument.Path
        End Get
    End Property
    Public ReadOnly Property FileName_Active_Doc() As String
        Get
            open_Word()
            Return objWord.ActiveDocument.Name
        End Get
    End Property
    Public Property Visible() As Boolean
        Get
            Return boolVisible
        End Get
        Set(ByVal value As Boolean)
            boolVisible = value
            Try
                objWord.Visible = value
            Catch ex As Exception

            End Try
        End Set
    End Property

    Public Function is_Doc_Open(ByVal strName_Doc As String, Optional ByVal boolActivate As Boolean = False) As Boolean
        Dim objWordDoc As Microsoft.Office.Interop.Word.Document = Nothing
        Dim boolOpen As Boolean

        boolOpen = False
        open_Word()
        If Not objWord Is Nothing Then
            For Each objWordDoc In objWord.Documents
                If objWordDoc.Name.Contains(strName_Doc) Then
                    If boolActivate = True Then
                        objWordDoc.Activate()
                    End If
                    boolOpen = True
                    Exit For
                End If
            Next
        End If
        Return boolOpen
    End Function

    Public Function activate_Doc(ByVal strName_Doc As String) As Boolean
        Dim objWordDoc As Microsoft.Office.Interop.Word.Document = Nothing
        Dim boolActivate As Boolean

        boolActivate = False
        If Not objWord Is Nothing Then
            For Each objWordDoc In objWord.Documents
                If objWordDoc.Name.Contains(strName_Doc) Then
                    objWordDoc.WordDoc.Activate()
                    boolActivate = True
                    Exit For
                End If
            Next
        End If
        Return boolActivate
    End Function
    Public Function open_Word() As Boolean
        Try

            objWord = CType(Marshal.GetActiveObject("Word.Application"), Microsoft.Office.Interop.Word.Application)
            objWord.Visible = boolVisible

        Catch ex As Exception

            objWord = New Microsoft.Office.Interop.Word.Application
            If boolVisible = True Then
                objWord.Visible = boolVisible
            End If

        End Try

        If Not objWord Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function close_Word() As Boolean
        Try
            If Not objWord Is Nothing Then
                objWord.Documents.Close(False)
                objWord.Quit(False)
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function get_ChangeDate(ByVal intDocID As Integer) As Date
        Dim dateLastAccess As Date
        dateLastAccess = IO.File.GetLastAccessTime(objWordDocs(intDocID).Path_Doc)
        Return dateLastAccess
    End Function

    Public Function open_Document(ByVal strPath_Doc As String, ByVal strCategory As String, ByVal strName As String, ByVal strPath_Template As String) As Integer
        Dim objWordDoc_active As Microsoft.Office.Interop.Word.Document = Nothing
        Dim boolOpen As Boolean = True
        open_Word()
        Try
            If IO.File.Exists(strPath_Doc) Then
                For Each objWordDoc_active In objWord.Documents
                    If (objWordDoc_active.Path & "\" & objWordDoc_active.Name).ToLower = strPath_Doc.ToLower Then
                        objWordDoc_active.Activate()
                        boolOpen = False
                    End If
                Next
                intDocID = intDocID + 1
                ReDim Preserve objWordDocs(intDocID - 1)
                objWordDocs(intDocID - 1) = New clsWordDocument
                objWordDocs(intDocID - 1).Path_Doc = strPath_Doc
                If boolOpen = True Then
                    objWordDocs(intDocID - 1).WordDoc = objWord.Documents.Open(objWordDocs(intDocID - 1).Path_Doc)
                Else
                    objWordDocs(intDocID - 1) = objWordDoc_active
                End If

            Else
                intDocID = intDocID + 1
                ReDim Preserve objWordDocs(intDocID - 1)
                objWordDocs(intDocID - 1) = New clsWordDocument
                objWordDocs(intDocID - 1).Path_Doc = strPath_Doc
                If IO.File.Exists(strPath_Template) Then
                    objWordDocs(intDocID - 1).WordDoc = objWord.Documents.Add(strPath_Template)
                Else
                    objWordDocs(intDocID - 1).WordDoc = objWord.Documents.Add
                End If
                objWordDocs(intDocID - 1).WordDoc.SaveAs(strPath_Doc)


            End If

            If Not strName = "" Then
                objWord.ActiveDocument.BuiltInDocumentProperties("TITLE") = strName
                objWord.ActiveDocument.BuiltInDocumentProperties("CATEGORY") = strCategory
                objWord.ActiveDocument.Fields.Update()
            End If

            Return intDocID - 1

        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function close_WordDoc(ByVal intDocID As Integer) As Boolean
        Try
            objWordDocs(intDocID).WordDoc.Close(False)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function activate_Bookmark(ByVal strTitle As String, ByVal strDocName As String) As Boolean
        Dim objDocument As Microsoft.Office.Interop.Word.Document
        Dim boolResult As Boolean


        Try
            open_Word()
            For Each objDocument In objWord.Documents
                If objDocument.Name = strDocName Then
                    objDocument.Activate()
                    objWord.Selection.GoTo(What:=wdGoToBookmark, Name:= _
                        strTitle)
                    With objDocument.Bookmarks
                        .DefaultSorting = wdSortByName
                        .ShowHidden = False
                    End With
                    boolResult = True
                    Exit For
                End If
            Next


        Catch ex As Exception
            boolResult = False
        End Try

        Return boolResult
    End Function

    Public Function get_ContentObjects(Optional ByVal intDocID As Integer = Nothing) As clsContentObject()

        Dim objWordDoc As Microsoft.Office.Interop.Word.Document
        Dim objContentControl As Microsoft.Office.Interop.Word.ContentControl
        Dim objContentObjects() As clsContentObject
        Dim intContentObjectID As Integer = 0

        Try
            open_Word()
            If objWord.Documents.Count > 0 Then
                If intDocID = Nothing Then
                    objWordDoc = objWord.ActiveDocument

                Else
                    objWordDoc = objWordDocs(intDocID)

                End If

                
                For Each objContentControl In objWordDoc.ContentControls
                    ReDim Preserve objContentObjects(intContentObjectID)
                    objContentObjects(intContentObjectID) = New clsContentObject
                    objContentObjects(intContentObjectID).Name_Doc = objWordDoc.Name
                    objContentObjects(intContentObjectID).ContentControl = objContentControl
                    intContentObjectID = intContentObjectID + 1
                Next

            Else

            End If


        Catch ex As Exception
            objContentObjects = Nothing
        End Try

        Return objContentObjects
    End Function

    Public Function insert_BookMark(ByVal GUID_ContentObject As Guid) As String

        Dim objWordDoc As Microsoft.Office.Interop.Word.Document
        Dim strDocGUID As String
        Dim strTitle As String

        strTitle = GUID_ContentObject.ToString

        strTitle = "m_" & strTitle.Replace("-", "_")
        Try
            open_Word()
            If objWord.Documents.Count > 0 Then
                objWordDoc = objWord.ActiveDocument
                strDocGUID = objWordDoc.Name
                strFilePath_LastAction = objWordDoc.Path
                With objWordDoc.Bookmarks
                    If .Exists(strTitle) Then
                        .Item(strTitle).Delete()
                    End If
                    .Add(strTitle, objWord.Selection.Range)
                    .DefaultSorting = wdSortByName
                    .ShowHidden = False
                End With
            Else
                strDocGUID = Nothing
            End If


        Catch ex As Exception
            strDocGUID = Nothing
        End Try

        Return strDocGUID
    End Function

    Public Function insert_ContentControl(ByVal strTitle As String) As String
        Dim objContentControl As Microsoft.Office.Interop.Word.ContentControl
        Dim objWordDoc As Microsoft.Office.Interop.Word.Document
        Dim strDocGUID As String

        Try
            open_Word()
            If objWord.Documents.Count > 0 Then
                objWordDoc = objWord.ActiveDocument
                strDocGUID = objWordDoc.Name
                strFilePath_LastAction = objWordDoc.Path
                objContentControl = objWord.ActiveDocument.ContentControls.Add(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlRichText)
                objContentControl.Title = strTitle
                objContentControl.Range.Select()
            Else
                strDocGUID = Nothing
            End If


        Catch ex As Exception
            strDocGUID = Nothing
        End Try

        Return strDocGUID
    End Function

    Public Function insert_DocumentContent(ByVal strPath_Doc As String) As String
        Dim objWordDoc As Microsoft.Office.Interop.Word.Document
        Dim strDocGUID As String

        Try
            open_Word()
            If objWord.Documents.Count > 0 Then
                objWordDoc = objWord.ActiveDocument
                strDocGUID = objWordDoc.Name
                strFilePath_LastAction = objWordDoc.Path
                strPath_Doc = strPath_Doc.Replace("\", "\\")
                objWord.Selection.Fields.Add(objWord.Selection.Range, wdFieldEmpty, "INCLUDETEXT  """ & strPath_Doc & """ ", True)
                move_Right()
            Else
                strDocGUID = Nothing
            End If


        Catch ex As Exception
            strDocGUID = Nothing
        End Try

        Return strDocGUID
    End Function

    Public Function insert_Link(ByVal strTitle As String, ByVal strLinkCaption As String, ByVal strLink As String) As String
        Dim objContentControl As Microsoft.Office.Interop.Word.ContentControl
        Dim objHyperlink As Microsoft.Office.Interop.Word.Hyperlink
        Dim objWordDoc As Microsoft.Office.Interop.Word.Document
        Dim strDocGUID As String

        Try
            open_Word()
            If objWord.Documents.Count > 0 Then
                objWordDoc = objWord.ActiveDocument
                strDocGUID = objWordDoc.Name
                strFilePath_LastAction = objWordDoc.Path
                If strLink.ToLower.StartsWith(strFilePath_LastAction.ToLower) Then
                    strLink = strLink.Substring(strFilePath_LastAction.Length + 1)
                End If
                objHyperlink = objWord.Selection.Range.Hyperlinks.Add(objWord.Selection.Range, strLink, , , strLinkCaption)
                objHyperlink.Range.Select()
                objContentControl = objWord.ActiveDocument.ContentControls.Add(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlRichText)
                objContentControl.Title = strTitle
                objContentControl.Range.Select()
                move_Right()
            Else
                strDocGUID = Nothing
            End If

        Catch ex As Exception
            strDocGUID = Nothing
        End Try

        Return strDocGUID
    End Function

    Public Function insert_List() As String
        Dim objWordDoc As Microsoft.Office.Interop.Word.Document
        Dim objListGalleries As Microsoft.Office.Interop.Word.ListGalleries
        Dim strDocGUID As String

        Try
            open_Word()
            If objWord.Documents.Count > 0 Then
                objListGalleries = objWord.ListGalleries
                With objListGalleries(wdBulletGallery).ListTemplates(1).ListLevels(1)
                    .NumberFormat = ChrW(61623)
                    .TrailingCharacter = wdTrailingTab
                    .NumberStyle = wdListNumberStyleBullet
                    .ResetOnHigher = 0
                    .StartAt = 1
                    .LinkedStyle = ""
                End With
                objListGalleries(wdBulletGallery).ListTemplates(1).Name = ""
                objWordDoc = objWord.ActiveDocument
                strDocGUID = objWordDoc.Name
                strFilePath_LastAction = objWordDoc.Path
                objWord.Selection.Range.ListFormat.ApplyListTemplateWithLevel(ListTemplate:= _
                    objListGalleries(wdBulletGallery).ListTemplates(1), ContinuePreviousList:= _
                    False, ApplyTo:=wdListApplyToWholeList, DefaultListBehavior:= _
                    wdWord10ListBehavior)
            Else
                strDocGUID = Nothing
            End If


        Catch ex As Exception
            strDocGUID = Nothing
        End Try

        Return strDocGUID

    End Function

    Public Function insert_NewLine() As String
        Dim objWordDoc As Microsoft.Office.Interop.Word.Document
        Dim strDocGUID As String

        Try
            open_Word()
            If objWord.Documents.Count > 0 Then
                objWordDoc = objWord.ActiveDocument
                strDocGUID = objWordDoc.Name
                strFilePath_LastAction = objWordDoc.Path
                objWord.Selection.TypeParagraph()
            Else
                strDocGUID = Nothing
            End If


        Catch ex As Exception
            strDocGUID = Nothing
        End Try

        Return strDocGUID
    End Function

    Public Function insert_TextContent(ByVal strTitle As String, ByVal strValue As String) As String
        Dim objContentControl As Microsoft.Office.Interop.Word.ContentControl
        Dim objWordDoc As Microsoft.Office.Interop.Word.Document
        Dim strDocGUID As String

        Try
            open_Word()
            If objWord.Documents.Count > 0 Then
                objWordDoc = objWord.ActiveDocument
                strDocGUID = objWordDoc.Name
                strFilePath_LastAction = objWordDoc.Path
                objContentControl = objWord.ActiveDocument.ContentControls.Add(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlRichText)
                objContentControl.Title = strTitle
                objContentControl.Range.Select()
                objWord.Selection.TypeText(strValue)
                move_Right()
            Else
                strDocGUID = Nothing
            End If


        Catch ex As Exception
            strDocGUID = Nothing
        End Try

        Return strDocGUID
    End Function

    Public Function move_Right() As String
        Dim objWordDoc As Microsoft.Office.Interop.Word.Document
        Dim strDocGUID As String

        Try
            open_Word()
            If objWord.Documents.Count > 0 Then
                objWordDoc = objWord.ActiveDocument
                strDocGUID = objWordDoc.Name
                strFilePath_LastAction = objWordDoc.Path
                objWord.Selection.MoveRight(wdCharacter, 1)
            Else
                strDocGUID = Nothing
            End If


        Catch ex As Exception
            strDocGUID = Nothing
        End Try

        Return strDocGUID
    End Function

    Public Function save_WordDoc(Optional ByVal intDocID As Integer = Nothing) As Boolean

        Try
            If Not intDocID = -1 Then
                objWord.ActiveDocument.Save()

            Else
                intDocID = 0
                objWordDocs(intDocID).WordDoc.SaveAs(objWordDocs(intDocID).Path_Doc)
            End If

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function type_Text(ByVal strText As String) As String
        Dim objWordDoc As Microsoft.Office.Interop.Word.Document
        Dim strDocGUID As String

        Try
            open_Word()
            If objWord.Documents.Count > 0 Then
                objWordDoc = objWord.ActiveDocument
                strDocGUID = objWordDoc.Name
                strFilePath_LastAction = objWordDoc.Path
                objWord.Selection.TypeText(strText)
            Else
                strDocGUID = Nothing
            End If


        Catch ex As Exception
            strDocGUID = Nothing
        End Try

        Return strDocGUID
    End Function
End Class
