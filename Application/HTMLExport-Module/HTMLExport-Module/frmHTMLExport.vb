Imports Sem_Manager
Imports Ionic.Zip
Imports Security_Module
Public Class frmHTMLExport
    Private objLocalConfig As clsLocalConfig

    Private procA_HTMLDocuments As New DataSet_HTMLTableAdapters.proc_HTMLDocumentsTableAdapter
    Private procT_HTMLDocuments As New DataSet_HTML.proc_HTMLDocumentsDataTable

    Private objHTMLExport As clsHTMLCreation

    Private objFrmAuthentication As frmAuthenticate
    Private objSemItem_User As clsSemItem

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)

        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
        objHTMLExport = New clsHTMLCreation(objLocalConfig, objSemItem_User, Me)

        get_Data()
    End Sub

    Private Sub get_Data()
        procA_HTMLDocuments.Fill(procT_HTMLDocuments, _
                                 objLocalConfig.SemItem_Type_HTML_Document.GUID, _
                                 objLocalConfig.SemItem_type_DevelopmentVersion.GUID, _
                                 objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                 Nothing)

        BindingSource_HTMLDOC.DataSource = procT_HTMLDocuments
        DataGridView_HTMLDoc.DataSource = BindingSource_HTMLDOC

        ToolStripLabel_Count.Text = DataGridView_HTMLDoc.RowCount
    End Sub

    Private Sub set_DBConnection()
        procA_HTMLDocuments.Connection = objLocalConfig.Connection_Plugin


    End Sub

    Private Sub ToolStripMenuItem_HTMLDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_HTMLDoc.Click
        test_HTMLDoc()
    End Sub

    Private Sub test_HTMLDoc()
        Dim strHTML As String
        Dim objSemItem_HTMLDoc As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objHTMLDocument As HtmlDocument

        strHTML = objHTMLExport.get_HTML_Intro
        strHTML = strHTML & objHTMLExport.get_HTML_Tag(objHTMLExport.SemItem_DocType_DocumentInit, False)
        strHTML = strHTML & objHTMLExport.get_HTML_Tag(objHTMLExport.SemItem_DocType_Head, False)
        strHTML = strHTML & objHTMLExport.get_HTML_Tag(objHTMLExport.SemItem_DocType_Title, False)

        strHTML = strHTML & "Test"

        strHTML = strHTML & objHTMLExport.get_HTML_Tag(objHTMLExport.SemItem_DocType_Title, True)
        strHTML = strHTML & objHTMLExport.get_HTML_Tag(objHTMLExport.SemItem_DocType_Head, True)

        strHTML = strHTML & objHTMLExport.get_HTML_Tag(objHTMLExport.SemItem_DocType_Body, False)


        strHTML = strHTML & objHTMLExport.get_HTML_Tag(objHTMLExport.SemItem_DocType_Body, True)


        strHTML = strHTML & objHTMLExport.get_HTML_Heading(1, False)
        strHTML = strHTML & "Test"
        strHTML = strHTML & objHTMLExport.get_HTML_Heading(1, True)


        strHTML = strHTML & objHTMLExport.get_HTML_Tag(objHTMLExport.SemItem_DocType_DocumentInit, True)
        WebBrowser_Test.Navigate("about:blank")
        objHTMLDocument = WebBrowser_Test.Document
        objHTMLDocument.Write(strHTML)

        'objSemItem_HTMLDoc.new_Item = True
        'objSemItem_HTMLDoc.Name = "Testeintrag"
        'objSemItem_HTMLDoc.GUID_Parent = objLocalConfig.SemItem_Type_HTML_Document.GUID
        'objSemItem_HTMLDoc.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


        'objSemItem_Result = objHTMLExport.initialize_Document(objSemItem_HTMLDoc)
        'If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
        '    objSemItem_Result = objHTMLExport.insert_DocumentPart_HTML()
        '    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

        '    End If
        'End If
        'get_Data()
    End Sub

    Private Sub frmHTMLExport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim boolOpen As Boolean

        boolOpen = False
        objFrmAuthentication = New frmAuthenticate(objLocalConfig.Globals, frmAuthenticate.ERelateMode.NoRelate, True, False)
        objFrmAuthentication.ShowDialog(Me)
        If objFrmAuthentication.DialogResult = Windows.Forms.DialogResult.OK Then
            objSemItem_User = objFrmAuthentication.SemItem_User
            objHTMLExport = New clsHTMLCreation(objLocalConfig, objSemItem_User, Me)
            boolOpen = True
        End If

        If boolOpen = False Then
            Me.Close()
        End If
    End Sub
End Class
