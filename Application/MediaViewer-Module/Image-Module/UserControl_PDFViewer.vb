Imports Sem_Manager
Imports Localizing_Manager
Imports Filesystem_Management
Public Class UserControl_PDFViewer

    Private objLocalConfig As clsLocalConfig
    Private objTransaction_PDF As clsTransaction_PDF
    Private objUserControl_Localized As UserControl_Localized

    Private objFrm_TokenEdit As frmTokenEdit
    Private objBlobConnection As clsBlobConnection
    Private objFileWork As clsFileWork

    Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private procA_PDF_Of_Or As New ds_ImageModuleTableAdapters.proc_PDF_Of_OrTableAdapter
    Private procT_PDF_Of_OR As New ds_ImageModule.proc_PDF_Of_OrDataTable

    Private objSemItem_Or As clsSemItem = Nothing
    Private objSemItem_Ref As clsSemItem
    Private objSemItems_Language() As clsSemItem

    Private objSemItem_File As New clsSemItem

    Private objSemItem_Showed As clsSemItem
    Private objSemItem_PDFDocument As clsSemItem

    Private intRowID As Integer
    Private intID As Integer

    Public Property visibilityDescription As Boolean
        Get
            Return SplitContainer1.Panel2Collapsed
        End Get
        Set(ByVal value As Boolean)
            SplitContainer1.Panel2Collapsed = True
        End Set
    End Property

    
    Public WriteOnly Property Enable_Relation As Boolean
        Set(ByVal value As Boolean)
            'boolAllowRelate = value
            'RelateToolStripMenuItem.Enabled = value
        End Set
    End Property

    Public Sub New(ByVal SemItem_Ref As clsSemItem, ByVal SemItems_Language() As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = SemItem_Ref
        objSemItems_Language = SemItems_Language

        objLocalConfig = New clsLocalConfig(New clsGlobals)
        initialize()

    End Sub

    Public Sub New(ByVal SemItem_Ref As clsSemItem, ByVal SemItems_Language() As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = SemItem_Ref
        objSemItems_Language = SemItems_Language

        objLocalConfig = New clsLocalConfig(Globals)
        initialize()

    End Sub

    Public Sub New(ByVal SemItem_Ref As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = SemItem_Ref

        objLocalConfig = New clsLocalConfig(Globals)
        get_Languages()
        initialize()

    End Sub

    Public Sub New(ByVal SemItem_Ref As clsSemItem, ByVal SemItems_Language() As clsSemItem, ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = SemItem_Ref
        objSemItems_Language = SemItems_Language

        objLocalConfig = LocalConfig
        initialize()

    End Sub

    Private Sub get_Languages()
        Dim objDRC_Languages As DataRowCollection
        Dim i As Integer


        objDRC_Languages = funcA_TokenToken.GetData_TokenToken_LeftRight(objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_isDescribedBy.GUID, _
                                                                            objLocalConfig.SemItem_Type_Language.GUID).Rows
        If objDRC_Languages.Count > 0 Then


            ReDim Preserve objSemItems_Language(objDRC_Languages.Count - 1)
            For i = 0 To objDRC_Languages.Count - 1
                objSemItems_Language(i) = New clsSemItem
                objSemItems_Language(i).GUID = objDRC_Languages(i).Item("GUID_Token_Right")
                objSemItems_Language(i).Name = objDRC_Languages(i).Item("Name_Token_Right")
                objSemItems_Language(i).GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
                objSemItems_Language(i).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Next
        End If

    End Sub

    Private Sub initialize()
        Dim objDRC_Or As DataRowCollection

        set_DBConnection()
        objUserControl_Localized = New UserControl_Localized(objLocalConfig.Globals)
        objUserControl_Localized.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(objUserControl_Localized)


        objDRC_Or = semfuncA_ObjectReference.GetData_By_GUID_Ref(objSemItem_Ref.GUID).Rows
        If objDRC_Or.Count > 0 Then
            objSemItem_Or = New clsSemItem
            objSemItem_Or.GUID = objDRC_Or(0).Item("GUID_ObjectReference")
            objSemItem_Or.Name = objDRC_Or(0).Item("Name_Token")
            objSemItem_Or.GUID_Parent = objDRC_Or(0).Item("GUID_ItemType")
        Else
            objSemItem_Or = Nothing
        End If

        configure_PDFs()
    End Sub

    Private Sub get_PDFs()
        intRowID = -1
        If Not objSemItem_Or Is Nothing Then
            procA_PDF_Of_Or.Fill(procT_PDF_Of_OR, _
                                   objLocalConfig.SemItem_Type_PDF_Documents.GUID, _
                                   objLocalConfig.SemItem_Type_File.GUID, _
                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                  objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                  objSemItem_Or.GUID)

        Else
            procT_PDF_Of_OR.Clear()
        End If

    End Sub

    Public Sub clear()
        AxFoxitCtl_Main = Nothing
        AxFoxitCtl_Main = New AxFOXITREADERLib.AxFoxitCtl
        objUserControl_Localized.clear_LanguageTree()
    End Sub

    Private Sub configure_PDFs()
        AxFoxitCtl_Main.OpenFile(Nothing)
        get_PDFs()
        show_PDF()
        If objSemItem_Showed.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Images können nicht angezeigt werden!", MsgBoxStyle.Exclamation)
        End If
        configure_Navigation()
    End Sub

    Private Sub show_PDF()
        Dim objDR_Image As DataRow

        Dim strPath As String

        If intRowID = -1 Then
            If procT_PDF_Of_OR.Rows.Count > 0 Then
                intRowID = 0
            End If
        End If

        If Not intRowID = -1 Then
            objDR_Image = procT_PDF_Of_OR.Rows(intRowID)
            objSemItem_File = New clsSemItem
            objSemItem_File.GUID = objDR_Image.Item("GUID_File")
            objSemItem_File.Name = objDR_Image.Item("GUID_File").ToString & "." & objLocalConfig.SemItem_Token_Extensions_pdf.Name
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            strPath = Environment.ExpandEnvironmentVariables("%Temp%")
            strPath = objFileWork.merge_paths(strPath, Guid.NewGuid.ToString & "." & objLocalConfig.SemItem_Token_Extensions_pdf.Name, "\")

            objSemItem_Showed = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath)
            If objSemItem_Showed.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                AxFoxitCtl_Main.OpenFile(strPath)
                objSemItem_Showed = objLocalConfig.Globals.LogState_Success
                objSemItem_PDFDocument = New clsSemItem
                objSemItem_PDFDocument.GUID = objDR_Image.Item("GUID_PDF_Documents")
                objSemItem_PDFDocument.Name = objDR_Image.Item("Name_PDF_Documents")
                objSemItem_PDFDocument.GUID_Parent = objLocalConfig.SemItem_Type_PDF_Documents.GUID
                objSemItem_PDFDocument.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objUserControl_Localized.initialize(objSemItem_Ref, objSemItems_Language, True)
            Else
                objUserControl_Localized.clear_LanguageTree()
                objSemItem_PDFDocument = Nothing
                objSemItem_Showed = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Showed = objLocalConfig.Globals.LogState_Nothing
        End If

    End Sub
    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
        semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB
        procA_PDF_Of_Or.Connection = objLocalConfig.Connection_Plugin
        objTransaction_PDF = New clsTransaction_PDF(objLocalConfig)
        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
        objFileWork = New clsFileWork(objLocalConfig.Globals)
    End Sub

    Private Sub configure_Navigation()

        ToolStripButton_Delete.Enabled = False
        ToolStripButton_Add.Enabled = False
        ToolStripButton_Replace.Enabled = False

        ToolStripButton_MoveFirst.Enabled = False
        ToolStripButton_MoveLast.Enabled = False
        ToolStripButton_MoveNext.Enabled = False
        ToolStripButton_MovePrevious.Enabled = False

        If intRowID = -1 Then
            ToolStripButton_Add.Enabled = True

        Else
            If objSemItem_Showed.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                ToolStripButton_Replace.Enabled = True
                ToolStripButton_Delete.Enabled = True
                ToolStripButton_Add.Enabled = True

                If intRowID < procT_PDF_Of_OR.Rows.Count - 1 Then

                    ToolStripButton_MoveNext.Enabled = True
                    ToolStripButton_MoveLast.Enabled = True

                End If

                If intRowID > 0 Then
                    ToolStripButton_MoveFirst.Enabled = True
                    ToolStripButton_MovePrevious.Enabled = True
                End If
            End If

        End If
    End Sub

    Private Sub ToolStripButton_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Add.Click
        Dim objSemItem_Result As clsSemItem

        Dim strPath As String
        If OpenFileDialog_PDF.ShowDialog(Me) = DialogResult.OK Then
            For Each strPath In OpenFileDialog_PDF.FileNames
                If IO.File.Exists(strPath) Then

                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    If objSemItem_Or Is Nothing Then

                        objSemItem_Result = objTransaction_PDF.save_001_OR_of_Ref(objSemItem_Ref)

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Or = New clsSemItem
                            objSemItem_Or.GUID = objSemItem_Result.GUID_Related

                        Else

                            MsgBox("Das Image konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        End If

                    End If

                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        intID = get_NextID()

                        objSemItem_PDFDocument = New clsSemItem
                        objSemItem_PDFDocument.GUID = Guid.NewGuid
                        objSemItem_PDFDocument.Name = objSemItem_Ref.Name & " Doc." & intID
                        objSemItem_PDFDocument.GUID_Parent = objLocalConfig.SemItem_Type_PDF_Documents.GUID
                        objSemItem_PDFDocument.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_PDF.save_002_PDFDocument(objSemItem_PDFDocument)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                           
                            objSemItem_File.GUID = Guid.NewGuid
                            objSemItem_File.Name = objSemItem_File.GUID.ToString & "." & objLocalConfig.SemItem_Token_Extensions_pdf.Name
                            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID

                            objSemItem_Result = objTransaction_PDF.save_004_File(objSemItem_File)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_PDF.save_005_Blob(strPath)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_PDF.save_006_PDFDocument_To_File
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_PDF.save_007_PDFDocument_To_OR(intID, objSemItem_PDFDocument, objSemItem_Or)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            configure_PDFs()
                                        Else
                                            MsgBox("Die Zwischenablage enthält kein Bild!", MsgBoxStyle.Exclamation)
                                            objSemItem_Result = objTransaction_PDF.del_006_PDFDocument_To_File
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                objSemItem_Result = objTransaction_PDF.del_005_Blob
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objTransaction_PDF.del_004_File()
                                                End If

                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objTransaction_PDF.del_002_PDFDocument()
                                                End If
                                            End If



                                        End If
                                    Else
                                        MsgBox("Die Zwischenablage enthält kein Bild!", MsgBoxStyle.Exclamation)
                                        objSemItem_Result = objTransaction_PDF.del_005_Blob
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objTransaction_PDF.del_004_File()
                                        End If

                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objTransaction_PDF.del_002_PDFDocument()
                                        End If
                                    End If
                                Else
                                    MsgBox("Die Zwischenablage enthält kein Bild!", MsgBoxStyle.Exclamation)
                                    objSemItem_Result = objTransaction_PDF.del_004_File()

                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_PDF.del_002_PDFDocument()
                                    End If
                                End If
                            Else
                                MsgBox("Die Zwischenablage enthält kein Bild!", MsgBoxStyle.Exclamation)
                                
                                objTransaction_PDF.del_002_PDFDocument()


                            End If
                           
                        Else
                            MsgBox("Die Zwischenablage enthält kein Bild!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Else
                    MsgBox("Die Datei konnte nicht gefunden werden:" & strPath, MsgBoxStyle.Exclamation)
                End If
            Next

            


        End If

        


    End Sub

    Private Function get_NextID() As Integer
        Dim objDRC_Images As DataRowCollection
        objDRC_Images = procA_PDF_Of_Or.GetData(objLocalConfig.SemItem_Type_PDF_Documents.GUID, _
                                                    objLocalConfig.SemItem_Type_File.GUID, _
                                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                  objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                  objSemItem_Or.GUID).Rows
        If objDRC_Images.Count > 0 Then
            Return objDRC_Images(objDRC_Images.Count - 1).Item("OrderID") + 1
        Else
            Return 1
        End If
    End Function

    Private Sub ToolStripButton_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Delete.Click
        Dim objDRC_PDF As DataRowCollection
        Dim objDR_PDF As DataRow
        Dim objSemItem_Result As clsSemItem
        Dim boolRemove_Relation As Boolean
        Dim intOrderID As Integer

        If Not intRowID = -1 Then
            If Not objSemItem_Or Is Nothing Then
                If procT_PDF_Of_OR.Rows.Count > intRowID Then
                    If MsgBox("Wollen Sie das PDF-File wirklich löschen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        objDR_PDF = procT_PDF_Of_OR.Rows(intRowID)
                        objDRC_PDF = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objDR_PDF.Item("GUID_PDF_Documents"), _
                                                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                        If objDRC_PDF.Count > 0 Then
                            intOrderID = procT_PDF_Of_OR.Rows(intRowID).Item("OrderID")
                            If objDRC_PDF.Count = 1 Then
                                If objDRC_PDF(0).Item("GUID_ObjectReference") = objSemItem_Or.GUID Then
                                    boolRemove_Relation = False
                                Else
                                    ToolStripButton_Delete.Enabled = False
                                End If
                            Else
                                boolRemove_Relation = False
                            End If

                            If ToolStripButton_Delete.Enabled = True Then
                                objSemItem_PDFDocument = New clsSemItem
                                objSemItem_PDFDocument.GUID = objDR_PDF.Item("GUID_PDF_Documents")
                                objSemItem_PDFDocument.Name = objDR_PDF.Item("Name_PDF_Documents")
                                objSemItem_PDFDocument.GUID_Parent = objLocalConfig.SemItem_Type_PDF_Documents.GUID
                                objSemItem_PDFDocument.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objSemItem_File = New clsSemItem
                                objSemItem_File.GUID = objDR_PDF.Item("GUID_File")
                                objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                                objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                If boolRemove_Relation = True Then
                                    MsgBox("Das Image ist noch in anderen Beziehungen aktiv! Es wird lediglich die Beziehung zum Image gelöscht!", MsgBoxStyle.Information)
                                End If

                                objSemItem_Result = objTransaction_PDF.del_007_PDFDocument_To_OR(objSemItem_PDFDocument, objSemItem_Or)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    If boolRemove_Relation = False Then
                                        objSemItem_Result = objTransaction_PDF.del_006_PDFDocument_To_File(objSemItem_PDFDocument, objSemItem_File)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_PDF.del_005_Blob(objSemItem_File)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_PDF.del_004_File(objSemItem_File)
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                    objSemItem_Result = objTransaction_PDF.del_002_PDFDocument(objSemItem_PDFDocument)
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        intRowID = -1
                                                        intID = 0
                                                        configure_PDFs()
                                                    Else
                                                        objTransaction_PDF.save_004_File(objSemItem_File)
                                                        objTransaction_PDF.save_006_PDFDocument_To_File(objSemItem_PDFDocument, objSemItem_File)
                                                        objTransaction_PDF.save_007_PDFDocument_To_OR(intOrderID, objSemItem_PDFDocument, objSemItem_Or)

                                                        MsgBox("Die Beziehung zwischen dem Image und seiner Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                                                    End If

                                                Else

                                                    objTransaction_PDF.save_006_PDFDocument_To_File(objSemItem_PDFDocument, objSemItem_File)
                                                    objTransaction_PDF.save_007_PDFDocument_To_OR(intOrderID, objSemItem_PDFDocument, objSemItem_Or)

                                                    MsgBox("Die Beziehung zwischen dem Image und seiner Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                                                End If
                                            Else
                                                objTransaction_PDF.save_006_PDFDocument_To_File(objSemItem_PDFDocument, objSemItem_File)
                                                objTransaction_PDF.save_007_PDFDocument_To_OR(intOrderID, objSemItem_PDFDocument, objSemItem_Or)

                                                MsgBox("Die Beziehung zwischen dem Image und seiner Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                                            End If
                                        Else
                                            objTransaction_PDF.save_007_PDFDocument_To_OR(intOrderID, objSemItem_PDFDocument, objSemItem_Or)
                                            MsgBox("Die Beziehung zwischen dem Image und seiner Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                                        End If
                                    End If

                                Else
                                    MsgBox("Die Beziehung zwischen dem Image und seiner Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                                End If
                            End If
                        Else
                            ToolStripButton_Delete.Enabled = False
                        End If
                    End If
                    
                Else
                    ToolStripButton_Delete.Enabled = False
                End If
            Else
                ToolStripButton_Delete.Enabled = False
            End If

        Else

            ToolStripButton_Delete.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton_MoveFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_MoveFirst.Click
        intRowID = 0
        intID = 0
        show_PDF()
        configure_Navigation()
    End Sub

    Private Sub ToolStripButton_MoveLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_MoveLast.Click
        intRowID = procT_PDF_Of_OR.Rows.Count - 1
        intID = 0
        show_PDF()
        configure_Navigation()
    End Sub

    Private Sub ToolStripButton_MovePrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_MovePrevious.Click
        If intRowID > 0 Then
            intRowID = intRowID - 1
        End If
        intID = 0
        show_PDF()
        configure_Navigation()
    End Sub

    Private Sub ToolStripButton_MoveNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_MoveNext.Click
        If intRowID < procT_PDF_Of_OR.Rows.Count - 1 Then
            intRowID = intRowID + 1
        End If
        intID = 0
        show_PDF()
        configure_Navigation()
    End Sub

    Private Sub ToolStripButton_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Edit.Click
        objFrm_TokenEdit = New frmTokenEdit(objSemItem_PDFDocument, objLocalConfig.Globals)
        objFrm_TokenEdit.ShowDialog(Me)

    End Sub

    Protected Overrides Sub Finalize()
        Try
            AxFoxitCtl_Main.Dispose()
        Catch ex As Exception

        End Try

        MyBase.Finalize()
    End Sub
End Class
