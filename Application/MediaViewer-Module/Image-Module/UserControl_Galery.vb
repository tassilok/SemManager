Imports Sem_Manager
Imports Filesystem_Management
Imports Localizing_Manager
Public Class UserControl_Galery
    Private objUserControl_Localized As UserControl_Localized

    Private objFrmSemManager As frmSemManager
    Private objFrmTokenEdit As frmTokenEdit
    Private objTransaction_Image As clsTransaction_Imagevb
    Private objBlobConnection As Filesystem_Management.clsBlobConnection
    Private objFileWork As clsFileWork
    Private objImageInfo As clsImageInfo
    Private objFrmEditImage As frmEditImage

    Private objLocalConfig As clsLocalConfig
    Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private procA_Image_Of_Or As New ds_ImageModuleTableAdapters.proc_Image_Of_OrTableAdapter
    Private procT_Image_Of_Or As New ds_ImageModule.proc_Image_Of_OrDataTable
    Private procA_Medias_Chrono As New ds_ImageModuleTableAdapters.proc_Medias_ChronoTableAdapter
    Private procT_Medias_Chrono As New ds_ImageModule.proc_Medias_ChronoDataTable
    Private procA_Images_Of_NamedRelated As New ds_ImageModuleTableAdapters.proc_Images_Of_NamedRelatedTableAdapter
    Private procT_Images_Of_NamedRelated As New ds_ImageModule.proc_Images_Of_NamedRelatedDataTable

    Private objDRs_Images() As DataRow

    Private objSemItem_Ref As clsSemItem
    Private objSemItem_Or As clsSemItem = Nothing
    Private objSemItems_Languages() As clsSemItem
    Private objSemItem_File As New clsSemItem
    Private objSemItem_ImageGraphic As clsSemItem
    Private objGraphics As Graphics
    Private objSemItem_Year As clsSemItem
    Private objSemItem_Month As clsSemItem
    Private objSemItem_Day As clsSemItem

    Private objSemItem_Showed As clsSemItem
    Private objImage As Image

    Private intID As Integer = 0
    Private intRowID As Integer = -1
    Private boolAllowEdit As Boolean
    Private boolAllowRelate As Boolean
    Private boolIsNamed As Boolean

    Public Event related_Image(ByVal intID As Integer)
    Public Event relate_All_Images()

    Public WriteOnly Property Enable_Relation As Boolean
        Set(ByVal value As Boolean)
            boolAllowRelate = value
            ToolStripButton_Relate.Enabled = value
        End Set
    End Property

    Public Function DR_Selected(ByVal intRowID As Integer) As DataRow
        If Not objSemItem_Ref Is Nothing Then
            Return procT_Image_Of_Or.Rows(intRowID)
        Else
            Return objDRs_Images(intRowID)

        End If
    End Function

    Public ReadOnly Property DRs_Images As DataRow()
        Get
            Dim objDRs_Image() As DataRow
            Dim objDR_Image As DataRow
            Dim i As Integer
            If Not objSemItem_Ref Is Nothing Then
                ReDim Preserve objDRs_Image(procT_Image_Of_Or.Rows.Count - 1)
                For i = 0 To procT_Image_Of_Or.Rows.Count - 1

                    objDRs_Image(i) = procT_Image_Of_Or.Rows(i)
                Next

                Return objDRs_Image
            Else
                Return objDRs_Images

            End If
        End Get
    End Property

    Public Property allow_Edit As Boolean
        Get
            Return boolAllowEdit
        End Get
        Set(ByVal value As Boolean)
            boolAllowEdit = value
            If Not objSemItem_Ref Is Nothing Then
                If boolIsNamed = False Then
                    configure_Navigation_Ref()
                Else
                    configure_Images_NamedSemantics()
                End If

            Else
                configure_Navigation_Chrono()
            End If

        End Set
    End Property

    Private Sub get_Languages()
        Dim objDRC_Languages As DataRowCollection
        Dim i As Integer


        objDRC_Languages = funcA_TokenToken.GetData_TokenToken_LeftRight(objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_isDescribedBy.GUID, _
                                                                            objLocalConfig.SemItem_Type_Language.GUID).Rows
        If objDRC_Languages.Count > 0 Then


            ReDim Preserve objSemItems_Languages(objDRC_Languages.Count - 1)
            For i = 0 To objDRC_Languages.Count - 1
                objSemItems_Languages(i) = New clsSemItem
                objSemItems_Languages(i).GUID = objDRC_Languages(i).Item("GUID_Token_Right")
                objSemItems_Languages(i).Name = objDRC_Languages(i).Item("Name_Token_Right")
                objSemItems_Languages(i).GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
                objSemItems_Languages(i).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Next
        End If

    End Sub

    Public Sub New(ByVal SemItem_Ref As clsSemItem, ByVal SemItems_Languages() As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = SemItem_Ref
        objSemItems_Languages = SemItems_Languages

        objLocalConfig = New clsLocalConfig(New clsGlobals)
        initialize()
    End Sub

    Public Sub New(ByVal SemItem_Ref As clsSemItem, ByVal SemItems_Languages() As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = SemItem_Ref
        objSemItems_Languages = SemItems_Languages

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

    Public Sub New(ByVal SemItem_Ref As clsSemItem, ByVal SemItems_Languages() As clsSemItem, ByVal LocalConfig As clsLocalConfig, Optional ByVal isNamed As Boolean = False)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = SemItem_Ref
        objSemItems_Languages = SemItems_Languages
        boolIsNamed = isNamed
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Public Sub New(ByVal SemItem_Year As clsSemItem, ByVal SemItem_Month As clsSemItem, ByVal SemItem_Day As clsSemItem, ByVal SemItems_Languages() As clsSemItem, ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Ref = Nothing
        objSemItem_Year = SemItem_Year
        objSemItem_Month = SemItem_Month
        objSemItem_Day = SemItem_Day
        objSemItems_Languages = SemItems_Languages

        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Private Sub initialize()
        Dim objDRC_Or As DataRowCollection

        set_DBConnection()

        objGraphics = PictureBox_Image.CreateGraphics
        objTransaction_Image = New clsTransaction_Imagevb(objLocalConfig)

        objUserControl_Localized = New UserControl_Localized(objLocalConfig.Globals)
        objUserControl_Localized.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(objUserControl_Localized)

        If objSemItem_Ref Is Nothing Then

            configure_Images_Chrono()
        Else
            If boolIsNamed = False Then
                objDRC_Or = semfuncA_ObjectReference.GetData_By_GUID_Ref(objSemItem_Ref.GUID).Rows
                If objDRC_Or.Count > 0 Then
                    objSemItem_Or = New clsSemItem
                    objSemItem_Or.GUID = objDRC_Or(0).Item("GUID_ObjectReference")
                    objSemItem_Or.Name = objDRC_Or(0).Item("Name_Token")
                    objSemItem_Or.GUID_Parent = objDRC_Or(0).Item("GUID_ItemType")
                Else
                    objSemItem_Or = Nothing
                End If
                configure_Images_Ref()
            Else
                configure_Images_NamedSemantics()
            End If

        End If

        ToolStripLabel_size.Text = "0/0"

    End Sub

    Private Sub get_Images_NamedSemantics()
        Dim strFilter As String

        intRowID = -1


        procA_Images_Of_NamedRelated.Fill(procT_Images_Of_NamedRelated, _
                                          objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                          objLocalConfig.SemItem_Type_File.GUID, _
                                          objLocalConfig.SemItem_Type_Images__Graphic_.GUID, _
                                          objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                          objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                          objLocalConfig.SemItem_RelationType_is.GUID, _
                                          objSemItem_Ref.GUID)

        If procT_Images_Of_NamedRelated.Count > 0 Then
            intRowID = 0
        End If
    End Sub

    Private Sub get_Images_Chrono()
        Dim strFilter As String

        intRowID = -1


        procA_Medias_Chrono.Fill(procT_Medias_Chrono, _
                                     objLocalConfig.SemItem_Attribute_ID.GUID, _
                                     objLocalConfig.SemItem_Type_Year.GUID, _
                                     objLocalConfig.SemItem_Type_Month.GUID, _
                                     objLocalConfig.SemItem_Type_Day.GUID, _
                                     objLocalConfig.SemItem_Type_File.GUID, _
                                     objLocalConfig.SemItem_RelationType_taking_at.GUID, _
                                     objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                     objLocalConfig.SemItem_Type_Images__Graphic_.GUID)

        If objSemItem_Year Is Nothing Then
            strFilter = "Year IS NULL"
        Else
            If objSemItem_Year.GUID = objLocalConfig.SemItem_Token_Logstate_Unassigned.GUID Then
                strFilter = "Year IS NULL"
            Else
                strFilter = "Year=" & objSemItem_Year.Name
            End If

        End If

        If Not objSemItem_Month Is Nothing Then
            strFilter = strFilter & " AND Month=" & objSemItem_Month.Name.Substring(0, objSemItem_Month.Name.IndexOf(" "))
        End If

        If Not objSemItem_Day Is Nothing Then
            strFilter = strFilter & " AND Day=" & objSemItem_Day.Name.Substring(0, objSemItem_Day.Name.IndexOf(" "))
        End If

        objDRs_Images = procT_Medias_Chrono.Select(strFilter, "Year,Month,Day")
        If objDRs_Images.Count > 0 Then
            intRowID = 0
        End If


    End Sub

    Private Sub configure_Images_Chrono()
        PictureBox_Image.Image = Nothing
        get_Images_Chrono()
        show_Image()
        If objSemItem_Showed.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Images können nicht angezeigt werden!", MsgBoxStyle.Exclamation)
        End If


        configure_Navigation_Chrono()
    End Sub

    Private Sub configure_Images_NamedSemantics()
        PictureBox_Image.Image = Nothing
        get_Images_NamedSemantics()
        show_Image()
        If objSemItem_Showed.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Images können nicht angezeigt werden!", MsgBoxStyle.Exclamation)
        End If


        configure_Navigation_NamedSemantics()
    End Sub

    Private Sub configure_Navigation_NamedSemantics()
        ToolStripButton_Copy.Enabled = False
        ToolStripButton_Delete.Enabled = False
        ToolStripButton_LoadImage.Enabled = False
        ToolStripButton_Replace.Enabled = False

        ToolStripButton_MoveFirst.Enabled = False
        ToolStripButton_MoveLast.Enabled = False
        ToolStripButton_MoveNext.Enabled = False
        ToolStripButton_MovePrevious.Enabled = False
        ToolStripButton_Paste.Enabled = False

        If intRowID = -1 Then
            ToolStripLabel_ItemCount.Text = "0/0"
        Else
            If objSemItem_Showed.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                ToolStripLabel_ItemCount.Text = intRowID + 1 & "/" & procT_Images_Of_NamedRelated.Count
                If boolAllowEdit = True Then
                    ToolStripButton_Copy.Enabled = True
                    ToolStripButton_Delete.Enabled = True
                End If

                If intRowID < procT_Images_Of_NamedRelated.Rows.Count - 1 Then

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

    Private Sub configure_Images_Ref()
        objImage = Nothing
        PictureBox_Image.Image = Nothing
        get_Images()
        show_Image()
        If objSemItem_Showed.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Images können nicht angezeigt werden!", MsgBoxStyle.Exclamation)
        End If
        configure_Navigation_Ref()
    End Sub
    Private Sub configure_Navigation_Chrono()
        ToolStripButton_Copy.Enabled = False
        ToolStripButton_Delete.Enabled = False
        ToolStripButton_LoadImage.Enabled = False
        ToolStripButton_Replace.Enabled = False

        ToolStripButton_MoveFirst.Enabled = False
        ToolStripButton_MoveLast.Enabled = False
        ToolStripButton_MoveNext.Enabled = False
        ToolStripButton_MovePrevious.Enabled = False
        ToolStripButton_Paste.Enabled = False

        If intRowID = -1 Then
            ToolStripLabel_ItemCount.Text = "0/0"
        Else
            show_Image()
            If objSemItem_Showed.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                ToolStripLabel_ItemCount.Text = intRowID + 1 & "/" & objDRs_Images.Count
                If boolAllowEdit = True Then
                    ToolStripButton_Copy.Enabled = True
                    ToolStripButton_Delete.Enabled = True
                End If

                If intRowID < objDRs_Images.Count - 1 Then

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
    Private Sub configure_Navigation_Ref()
        ToolStripButton_Copy.Enabled = False
        ToolStripButton_Delete.Enabled = False
        ToolStripButton_LoadImage.Enabled = False
        ToolStripButton_Replace.Enabled = False

        ToolStripButton_MoveFirst.Enabled = False
        ToolStripButton_MoveLast.Enabled = False
        ToolStripButton_MoveNext.Enabled = False
        ToolStripButton_MovePrevious.Enabled = False
        ToolStripButton_Paste.Enabled = False

        If intRowID = -1 Then
            If boolAllowEdit = True Then
                ToolStripButton_LoadImage.Enabled = True
                ToolStripButton_Paste.Enabled = True
            End If

            ToolStripLabel_ItemCount.Text = "0/0"
        Else
            If boolIsNamed = False Then
                If objSemItem_Showed.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    ToolStripLabel_ItemCount.Text = intRowID + 1 & "/" & procT_Image_Of_Or.Rows.Count
                    If boolAllowEdit = True Then
                        ToolStripButton_Replace.Enabled = True
                        ToolStripButton_Copy.Enabled = True
                        ToolStripButton_Delete.Enabled = True
                        ToolStripButton_LoadImage.Enabled = True
                        ToolStripButton_Paste.Enabled = True

                    End If

                    If intRowID < procT_Image_Of_Or.Rows.Count - 1 Then

                        ToolStripButton_MoveNext.Enabled = True
                        ToolStripButton_MoveLast.Enabled = True

                    End If

                    If intRowID > 0 Then
                        ToolStripButton_MoveFirst.Enabled = True
                        ToolStripButton_MovePrevious.Enabled = True
                    End If
                End If
            End If


        End If
    End Sub
    Private Sub get_Images()
        intRowID = -1
        If Not objSemItem_Or Is Nothing Then
            procA_Image_Of_Or.Fill(procT_Image_Of_Or, _
                                   objLocalConfig.SemItem_Type_Images__Graphic_.GUID, _
                                   objLocalConfig.SemItem_Type_File.GUID, _
                                  objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                  objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                  objSemItem_Or.GUID)

        Else
            procT_Image_Of_Or.Clear()
        End If

    End Sub

    Private Sub show_Image()
        Dim objDR_Image As DataRow


        Dim strPath As String
        Dim intDatePart As Integer

        ToolStripLabel_Name.Text = "-"

        If intRowID = -1 Then
            If boolIsNamed = False Then
                If procT_Image_Of_Or.Rows.Count > 0 Then
                    intRowID = 0
                End If
            Else
                If procT_Images_Of_NamedRelated.Count > 0 Then
                    intRowID = 0
                End If
            End If

        End If

        If Not intRowID = -1 Then
            If Not objSemItem_Ref Is Nothing Then
                If boolIsNamed = False Then
                    objDR_Image = procT_Image_Of_Or.Rows(intRowID)
                Else
                    objDR_Image = procT_Images_Of_NamedRelated.Rows(intRowID)
                End If

            Else
                objDR_Image = objDRs_Images(intRowID)

            End If

            objSemItem_File.GUID = objDR_Image.Item("GUID_File")
            objSemItem_File.Name = objDR_Image.Item("GUID_File").ToString & "." & objLocalConfig.SemItem_Token_Extensions_Image.Name
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            strPath = Environment.ExpandEnvironmentVariables("%Temp%")
            strPath = objFileWork.merge_paths(strPath, Guid.NewGuid.ToString & "." & objLocalConfig.SemItem_Token_Extensions_Image.Name, "\")

            objSemItem_Showed = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath)
            If objSemItem_Showed.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objImage = New Bitmap(strPath)


                PictureBox_Image.Image = objImage
                configure_Zoom_Image()
                'PictureBox_Image.Image = AutoSizeImage(objImage, PictureBox_Image.ClientRectangle.Width, PictureBox_Image.ClientRectangle.Height, ToolStripButton_Stretch.Checked)
                'objGraphics.DrawImage(objImage, 0, 0, PictureBox_Image.Width, PictureBox_Image.Height)
                objSemItem_Showed = objLocalConfig.Globals.LogState_Success
                objSemItem_ImageGraphic = New clsSemItem
                objSemItem_ImageGraphic.GUID = objDR_Image.Item("GUID_Images__Graphic_")
                objSemItem_ImageGraphic.Name = objDR_Image.Item("Name_Images__Graphic_")
                objSemItem_ImageGraphic.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                objSemItem_ImageGraphic.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                ToolStripLabel_Name.Text = objSemItem_ImageGraphic.Name
                If objSemItem_Ref Is Nothing Then
                    If Not IsDBNull(objDRs_Images(intRowID).Item("Day")) Then
                        intDatePart = objDRs_Images(intRowID).Item("Day")
                        ToolStripLabel_Name.Text = ToolStripLabel_Name.Text & " (" & intDatePart.ToString("00")

                        intDatePart = objDRs_Images(intRowID).Item("Month")
                        ToolStripLabel_Name.Text = ToolStripLabel_Name.Text & "." & intDatePart.ToString("00")

                        intDatePart = objDRs_Images(intRowID).Item("Year")
                        ToolStripLabel_Name.Text = ToolStripLabel_Name.Text & "." & intDatePart.ToString("00") & ")"
                    End If


                End If
                objUserControl_Localized.initialize(objSemItem_Ref, objSemItems_Languages, True)


            Else
                objUserControl_Localized.clear_LanguageTree()
                objSemItem_ImageGraphic = Nothing
                objSemItem_Showed = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Showed = objLocalConfig.Globals.LogState_Nothing
        End If

    End Sub



    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB
        procA_Image_Of_Or.Connection = objLocalConfig.Connection_Plugin
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
        procA_Medias_Chrono.Connection = objLocalConfig.Connection_Plugin
        procA_Images_Of_NamedRelated.Connection = objLocalConfig.Connection_Plugin

        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
        objFileWork = New clsFileWork(objLocalConfig.Globals)
        objImageInfo = New clsImageInfo(objLocalConfig)
    End Sub
    Public Function AutoSizeImage(ByVal oBitmap As Image, _
          ByVal maxWidth As Integer, _
          ByVal maxHeight As Integer, _
          Optional ByVal bStretch As Boolean = False) As Image

        ' Größenverhältnis der max. Dimension
        Dim maxRatio As Single = maxWidth / maxHeight

        ' Bildgröße und aktuelles Größenverhältnis
        Dim imgWidth As Integer = oBitmap.Width
        Dim imgHeight As Integer = oBitmap.Height
        Dim imgRatio As Single = imgWidth / imgHeight

        ' Bild anpassen?
        If (imgWidth > maxWidth Or imgHeight > maxHeight) Or (bStretch) Then
            If imgRatio <= maxRatio Then
                ' Größenverhältnis des Bildes ist kleiner als die
                ' maximale Größe, in der das Bild angezeigt werden kann.
                ' In diesem Fall muss die Bildbreite angepasst werden.
                imgWidth = imgWidth / (imgHeight / maxHeight)
                imgHeight = maxHeight
            Else
                ' Größenverhältnis des Bildes ist größer als die 
                ' maximale Größe, in der das Bild angezeigt werden kann.
                ' In diesem Fall muss die Bildhöhe angepasst werden.
                imgHeight = imgHeight / (imgWidth / maxWidth)
                imgWidth = maxWidth
            End If

            ' Bitmap-Objekt in der neuen Größe erstellen
            Dim oImage As New Bitmap(imgWidth, imgHeight)

            ' Bild interpolieren, damit die Qualität erhalten bleibt
            Using g As Graphics = Graphics.FromImage(oImage)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(oBitmap, New Rectangle(0, 0, imgWidth, imgHeight))
            End Using

            ToolStripLabel_size.Text = oImage.Width & "/" & oImage.Height
            ' neues Bitmap zurückgeben
            Return oImage
        Else
            ' unverändertes Originalbild zurückgeben
            ToolStripLabel_size.Text = oBitmap.Width & "/" & oBitmap.Height
            Return oBitmap
        End If
    End Function

    Private Sub ToolStripButton_Paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Paste.Click
        Dim objSemItem_Result As clsSemItem

        Dim objImage As Image
        Dim strPath As String

        If Clipboard.ContainsImage Then
            objImage = Clipboard.GetData(System.Windows.Forms.DataFormats.Bitmap)
            strPath = Environment.ExpandEnvironmentVariables("%temp%")
            strPath = objFileWork.merge_paths(strPath, Guid.NewGuid.ToString & "." & objLocalConfig.SemItem_Token_Extensions_Image.Name, "\")
            objImage.Save(strPath)

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            If objSemItem_Or Is Nothing Then

                objSemItem_Result = objTransaction_Image.save_001_OR_of_Ref(objSemItem_Ref)

                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Or = New clsSemItem
                    objSemItem_Or.GUID = objSemItem_Result.GUID_Related

                Else

                    MsgBox("Das Image konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If

            End If

            If ToolStripButton_Replace.Checked = False Then
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intID = get_NextID()

                    objSemItem_ImageGraphic = New clsSemItem
                    objSemItem_ImageGraphic.GUID = Guid.NewGuid
                    objSemItem_ImageGraphic.Name = objSemItem_Ref.Name & " Abb." & intID
                    objSemItem_ImageGraphic.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                    objSemItem_ImageGraphic.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Result = objTransaction_Image.save_002_ImageGraphic(objSemItem_ImageGraphic)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                        objSemItem_File.GUID = Guid.NewGuid
                        objSemItem_File.Name = objSemItem_File.GUID.ToString & "." & objLocalConfig.SemItem_Token_Extensions_Image.Name
                        objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID

                        objSemItem_Result = objTransaction_Image.save_004_File(objSemItem_File)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Image.save_005_Blob(strPath)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_Image.save_006_ImageGraphic_To_File
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_Image.save_007_ImageGraphic_To_OR(intID, objSemItem_ImageGraphic, objSemItem_Or)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objImageInfo.get_Chronical(objSemItem_ImageGraphic, objSemItem_File, strPath)
                                        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            MsgBox("Die Metadaten des Images konnten nicht ermittelt werden!", MsgBoxStyle.Exclamation)
                                        End If
                                        configure_Images_Ref()
                                    Else
                                        MsgBox("Die Zwischenablage enthält kein Bild!", MsgBoxStyle.Exclamation)
                                        objSemItem_Result = objTransaction_Image.del_006_ImageGraphic_To_File
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                            objSemItem_Result = objTransaction_Image.del_005_Blob
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objTransaction_Image.del_004_File()
                                            End If

                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objTransaction_Image.del_002_ImageGraphic()
                                            End If
                                        End If



                                    End If
                                Else
                                    MsgBox("Die Zwischenablage enthält kein Bild!", MsgBoxStyle.Exclamation)
                                    objSemItem_Result = objTransaction_Image.del_005_Blob
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_Image.del_004_File()
                                    End If

                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_Image.del_002_ImageGraphic()
                                    End If
                                End If
                            Else
                                MsgBox("Die Zwischenablage enthält kein Bild!", MsgBoxStyle.Exclamation)
                                objSemItem_Result = objTransaction_Image.del_004_File()

                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objTransaction_Image.del_002_ImageGraphic()
                                End If
                            End If
                        Else
                            MsgBox("Die Zwischenablage enthält kein Bild!", MsgBoxStyle.Exclamation)

                            objTransaction_Image.del_002_ImageGraphic()


                        End If

                    Else
                        MsgBox("Die Zwischenablage enthält kein Bild!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else

                objSemItem_File = New clsSemItem
                objSemItem_File.GUID = procT_Image_Of_Or.Rows(intRowID).Item("GUID_File")
                objSemItem_File.Name = procT_Image_Of_Or.Rows(intRowID).Item("Name_File")
                objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_Image.save_005_Blob(strPath, objSemItem_File)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    configure_Images_Ref()
                Else
                    MsgBox("Das Image konnte nicht ersetzt werden!", MsgBoxStyle.Exclamation)
                End If
            End If


        Else
            MsgBox("Die Zwischenablage enthält kein Bild!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ToolStripButton_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Copy.Click
        Dim objImage As Image

        objImage = PictureBox_Image.Image
        Clipboard.SetDataObject(objImage)
    End Sub

    Private Sub ToolStripButton_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Delete.Click
        Dim objDRC_Image As DataRowCollection
        Dim objDR_Image As DataRow
        Dim objSemItem_Result As clsSemItem
        Dim boolRemove_Relation As Boolean
        Dim intOrderID As Integer

        If Not intRowID = -1 Then
            If Not objSemItem_Or Is Nothing Then
                If procT_Image_Of_Or.Rows.Count > intRowID Then
                    objDR_Image = procT_Image_Of_Or.Rows(intRowID)
                    objDRC_Image = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objDR_Image.Item("GUID_Images__Graphic_"), _
                                                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                    If objDRC_Image.Count > 0 Then
                        intOrderID = procT_Image_Of_Or.Rows(intRowID).Item("OrderID")

                        If objDRC_Image.Count = 1 Then
                            If objDRC_Image(0).Item("GUID_ObjectReference") = objSemItem_Or.GUID Then
                                boolRemove_Relation = False
                            Else
                                ToolStripButton_Delete.Enabled = False
                            End If
                        Else
                            boolRemove_Relation = False
                        End If

                        If MsgBox("Wollen Sie das Image wirklich löschen!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            If ToolStripButton_Delete.Enabled = True Then
                                objSemItem_ImageGraphic = New clsSemItem
                                objSemItem_ImageGraphic.GUID = objDR_Image.Item("GUID_Images__Graphic_")
                                objSemItem_ImageGraphic.Name = objDR_Image.Item("Name_Images__Graphic_")
                                objSemItem_ImageGraphic.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                                objSemItem_ImageGraphic.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                objSemItem_File = New clsSemItem
                                objSemItem_File.GUID = objDR_Image.Item("GUID_File")
                                objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                                objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                If boolRemove_Relation = True Then
                                    MsgBox("Das Image ist noch in anderen Beziehungen aktiv! Es wird lediglich die Beziehung zum Image gelöscht!", MsgBoxStyle.Information)
                                End If

                                objSemItem_Result = objTransaction_Image.del_007_ImageGraphic_To_OR(objSemItem_ImageGraphic, objSemItem_Or)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    If boolRemove_Relation = False Then
                                        objSemItem_Result = objTransaction_Image.del_006_ImageGraphic_To_File(objSemItem_ImageGraphic, objSemItem_File)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_Image.del_005_Blob(objSemItem_File)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_Image.del_004_File(objSemItem_File)
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then


                                                    objSemItem_Result = objTransaction_Image.del_002_ImageGraphic(objSemItem_ImageGraphic)
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        intRowID = -1
                                                        intID = 0
                                                        configure_Images_Ref()
                                                    Else
                                                        objTransaction_Image.save_004_File(objSemItem_File)
                                                        objTransaction_Image.save_006_ImageGraphic_To_File(objSemItem_ImageGraphic, objSemItem_File)
                                                        objTransaction_Image.save_007_ImageGraphic_To_OR(intOrderID, objSemItem_ImageGraphic, objSemItem_Or)

                                                        MsgBox("Die Beziehung zwischen dem Image und seiner Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                                                    End If

                                                Else

                                                    objTransaction_Image.save_006_ImageGraphic_To_File(objSemItem_ImageGraphic, objSemItem_File)
                                                    objTransaction_Image.save_007_ImageGraphic_To_OR(intOrderID, objSemItem_ImageGraphic, objSemItem_Or)

                                                    MsgBox("Die Beziehung zwischen dem Image und seiner Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                                                End If
                                            Else
                                                objTransaction_Image.save_006_ImageGraphic_To_File(objSemItem_ImageGraphic, objSemItem_File)
                                                objTransaction_Image.save_007_ImageGraphic_To_OR(intOrderID, objSemItem_ImageGraphic, objSemItem_Or)

                                                MsgBox("Die Beziehung zwischen dem Image und seiner Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                                            End If
                                        Else
                                            objTransaction_Image.save_007_ImageGraphic_To_OR(intOrderID, objSemItem_ImageGraphic, objSemItem_Or)
                                            MsgBox("Die Beziehung zwischen dem Image und seiner Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                                        End If
                                    End If

                                Else
                                    MsgBox("Die Beziehung zwischen dem Image und seiner Referenz kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                                End If
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

        Else

            ToolStripButton_Delete.Enabled = False
        End If


    End Sub

    Private Sub ToolStripButton_LoadImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_LoadImage.Click
        Dim strPath As String
        Dim objImage As Image
        Dim objSemItem_Result As clsSemItem
        If OpenFileDialog_Image.ShowDialog(Me) = DialogResult.OK Then
            If ToolStripButton_Replace.Checked = True Then
                If OpenFileDialog_Image.FileNames.Count = 1 Then
                    Try
                        strPath = OpenFileDialog_Image.FileNames(0)
                        objImage = Image.FromFile(strPath)
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        If objSemItem_Or Is Nothing Then

                            objSemItem_Result = objTransaction_Image.save_001_OR_of_Ref(objSemItem_Ref)

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Or = New clsSemItem
                                objSemItem_Or.GUID = objSemItem_Result.GUID_Related

                            Else

                                MsgBox("Das Image konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_File = New clsSemItem
                            objSemItem_File.GUID = procT_Image_Of_Or.Rows(intRowID).Item("GUID_File")
                            objSemItem_File.Name = procT_Image_Of_Or.Rows(intRowID).Item("Name_File")
                            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                            objSemItem_Result = objTransaction_Image.save_005_Blob(strPath, objSemItem_File)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                configure_Images_Ref()
                            Else
                                MsgBox("Das Image konnte nicht ersetzt werden!", MsgBoxStyle.Exclamation)
                            End If
                        End If

                    Catch ex As Exception
                        MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                    End Try
                End If
            Else
                For Each strPath In OpenFileDialog_Image.FileNames
                    Try
                        objImage = Image.FromFile(strPath)

                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        If objSemItem_Or Is Nothing Then

                            objSemItem_Result = objTransaction_Image.save_001_OR_of_Ref(objSemItem_Ref)

                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Or = New clsSemItem
                                objSemItem_Or.GUID = objSemItem_Result.GUID_Related

                            Else

                                MsgBox("Das Image konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            intID = get_NextID()

                            objSemItem_ImageGraphic = New clsSemItem
                            objSemItem_ImageGraphic.GUID = Guid.NewGuid
                            objSemItem_ImageGraphic.Name = strPath.Substring(strPath.LastIndexOf("\") + 1)
                            objSemItem_ImageGraphic.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                            objSemItem_ImageGraphic.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Result = objTransaction_Image.save_002_ImageGraphic(objSemItem_ImageGraphic)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                objSemItem_File.GUID = Guid.NewGuid
                                objSemItem_File.Name = objSemItem_File.GUID.ToString & "." & objLocalConfig.SemItem_Token_Extensions_Image.Name
                                objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID

                                objSemItem_Result = objTransaction_Image.save_004_File(objSemItem_File)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_Image.save_005_Blob(strPath)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_Image.save_006_ImageGraphic_To_File
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_Image.save_007_ImageGraphic_To_OR(intID, objSemItem_ImageGraphic, objSemItem_Or)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objImageInfo.get_Chronical(objSemItem_ImageGraphic, objSemItem_File, strPath)
                                                If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    MsgBox("Die Metadaten des Images konnten nicht ermittelt werden!", MsgBoxStyle.Exclamation)

                                                End If
                                                configure_Images_Ref()
                                            Else
                                                MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                                                objSemItem_Result = objTransaction_Image.del_006_ImageGraphic_To_File
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                    objSemItem_Result = objTransaction_Image.del_005_Blob
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objTransaction_Image.del_004_File()
                                                    End If

                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objTransaction_Image.del_002_ImageGraphic()
                                                    End If
                                                End If



                                            End If
                                        Else
                                            MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                                            objSemItem_Result = objTransaction_Image.del_005_Blob
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objTransaction_Image.del_004_File()
                                            End If

                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objTransaction_Image.del_002_ImageGraphic()
                                            End If
                                        End If
                                    Else
                                        MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                                        objSemItem_Result = objTransaction_Image.del_004_File()
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objTransaction_Image.del_002_ImageGraphic()
                                        End If
                                    End If
                                Else
                                    MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)

                                    objTransaction_Image.del_002_ImageGraphic()


                                End If

                            Else
                                MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                            End If
                        End If
                        objImage = Nothing
                    Catch ex As Exception
                        MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                        Exit For
                    End Try
                Next
            End If



        End If
    End Sub

    Private Function get_NextID() As Integer
        Dim objDRC_Images As DataRowCollection
        objDRC_Images = procA_Image_Of_Or.GetData(objLocalConfig.SemItem_Type_Images__Graphic_.GUID, _
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
    Private Sub ToolStripButton_MoveFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_MoveFirst.Click
        intRowID = 0
        intID = 0
        show_Image()
        If objSemItem_Ref Is Nothing Then
            configure_Navigation_Chrono()
        Else
            If boolIsNamed = False Then
                configure_Navigation_Ref()
            Else
                configure_Navigation_NamedSemantics()
            End If

        End If

    End Sub

    Private Sub ToolStripButton_MoveLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_MoveLast.Click
        If Not objSemItem_Ref Is Nothing Then
            If boolIsNamed = False Then
                intRowID = procT_Image_Of_Or.Rows.Count - 1
            Else
                intRowID = procT_Images_Of_NamedRelated.Count - 1
            End If

        Else
            intRowID = objDRs_Images.Count - 1
        End If

        intID = 0
        show_Image()
        If objSemItem_Ref Is Nothing Then
            configure_Navigation_Chrono()
        Else
            If boolIsNamed = False Then
                configure_Navigation_Ref()
            Else
                configure_Navigation_NamedSemantics()
            End If

        End If
    End Sub

    Private Sub ToolStripButton_MovePrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_MovePrevious.Click
        If intRowID > 0 Then
            intRowID = intRowID - 1
        End If
        intID = 0
        show_Image()
        If objSemItem_Ref Is Nothing Then
            configure_Navigation_Chrono()
        Else
            If boolIsNamed = False Then
                configure_Navigation_Ref()
            Else
                configure_Navigation_NamedSemantics()
            End If

        End If
    End Sub

    Private Sub ToolStripButton_MoveNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_MoveNext.Click
        If Not objSemItem_Ref Is Nothing Then
            If boolIsNamed = False Then
                If intRowID < procT_Image_Of_Or.Rows.Count - 1 Then
                    intRowID = intRowID + 1
                End If
            Else
                If intRowID < procT_Images_Of_NamedRelated.Count - 1 Then
                    intRowID = intRowID + 1
                End If
            End If

        Else
            If intRowID < objDRs_Images.Count - 1 Then
                intRowID = intRowID + 1
            End If
        End If

        intID = 0
        show_Image()
        If objSemItem_Ref Is Nothing Then
            configure_Navigation_Chrono()
        Else
            If boolIsNamed = False Then
                configure_Navigation_Ref()
            Else
                configure_Navigation_NamedSemantics()
            End If

        End If
    End Sub

    Private Sub PictureBox_Image_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox_Image.DoubleClick

    End Sub

    Private Sub PictureBox_Image_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox_Image.Paint
        
    End Sub





    Private Sub ToolStripButton_Relate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Relate.Click
        Dim objDR_Image As DataRow
        Dim objSemItem_Image As New clsSemItem
        If intRowID > -1 Then
            If Not objSemItem_Ref Is Nothing Then
                If boolIsNamed = False Then
                    objDR_Image = procT_Image_Of_Or.Rows(intRowID)
                Else
                    objDR_Image = procT_Images_Of_NamedRelated.Rows(intRowID)
                End If

            Else
                objDR_Image = procT_Medias_Chrono.Rows(intRowID)
            End If
        End If
        

        objSemItem_Image.GUID = objDR_Image.Item("GUID_Images__Graphic_")
        objSemItem_Image.Name = objDR_Image.Item("Name_Images__Graphic_")
        objSemItem_Image.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
        objSemItem_Image.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrmEditImage = New frmEditImage(objLocalConfig)
        If intRowID > -1 Then
            If Not objSemItem_Ref Is Nothing Then
                If boolIsNamed = False Then
                    objFrmEditImage.initialize_OR(procT_Image_Of_Or, intRowID)
                Else
                    objFrmEditImage.initialize_Named(procT_Images_Of_NamedRelated, intRowID)
                End If

            Else
                objFrmEditImage.initialize_Chrono(procT_Medias_Chrono, intRowID)
            End If
        End If
        PictureBox_Image.Visible = False
        objFrmEditImage.ShowDialog(Me)
        PictureBox_Image.Visible = True
        'Dim objDR_Image As DataRow
        'Dim objDGVR_Selected As DataGridViewRow
        'Dim objDRV_Selected As DataRowView
        'Dim objSemItem_Selected As clsSemItem
        'Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Error
        'If Not intRowID = -1 Then

        '    objDR_Image = procT_Image_Of_Or.Rows(intRowID)
        '    objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
        '    objFrmSemManager.Applyabale = True
        '    objFrmSemManager.ShowDialog(Me.ParentForm)
        '    If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
        '        objSemItem_Selected = New clsSemItem
        '        Select Case objFrmSemManager.SelectedItems_TypeGUID
        '            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

        '                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
        '                    objDRV_Selected = objDGVR_Selected.DataBoundItem
        '                    objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_Attribute")
        '                    objSemItem_Selected.Name = objDRV_Selected.Item("Name_Attribute")
        '                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
        '                    objSemItem_Result = objTransaction_Image.save_001_OR_of_Ref(objSemItem_Selected)
        '                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
        '                        Exit For
        '                    Else
        '                        objSemItem_Result = objTransaction_Image.save_007_ImageGraphic_To_OR(1)
        '                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
        '                            Exit For
        '                        End If
        '                    End If

        '                Next
        '            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
        '                objSemItem_Selected = New clsSemItem
        '                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
        '                    objDRV_Selected = objDGVR_Selected.DataBoundItem
        '                    objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_RelationType")
        '                    objSemItem_Selected.Name = objDRV_Selected.Item("Name_RelationType")
        '                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
        '                    objSemItem_Result = objTransaction_Image.save_001_OR_of_Ref(objSemItem_Selected)
        '                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
        '                        Exit For
        '                    Else
        '                        objSemItem_Result = objTransaction_Image.save_007_ImageGraphic_To_OR(1)
        '                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
        '                            Exit For
        '                        End If
        '                    End If
        '                Next
        '            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        '                objSemItem_Selected = New clsSemItem
        '                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
        '                    objDRV_Selected = objDGVR_Selected.DataBoundItem
        '                    objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_Token")
        '                    objSemItem_Selected.Name = objDRV_Selected.Item("Name_Token")
        '                    objSemItem_Selected.GUID_Parent = objDRV_Selected.Item("GUID_Type")
        '                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        '                    objSemItem_Result = objTransaction_Image.save_001_OR_of_Ref(objSemItem_Selected)
        '                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
        '                        Exit For
        '                    Else
        '                        objSemItem_Result = objTransaction_Image.save_007_ImageGraphic_To_OR(1)
        '                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
        '                            Exit For
        '                        End If
        '                    End If
        '                Next

        '            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
        '                For Each objSemItem_Selected In objFrmSemManager.SemItems_Selected
        '                    objSemItem_Result = objTransaction_Image.save_001_OR_of_Ref(objSemItem_Selected)
        '                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
        '                        Exit For
        '                    Else
        '                        objSemItem_Result = objTransaction_Image.save_007_ImageGraphic_To_OR(1)
        '                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
        '                            Exit For
        '                        End If
        '                    End If
        '                Next
        '        End Select
        '        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
        '            MsgBox("Leider konnten nicht alle Beziehungen hergestellt werden!", MsgBoxStyle.Exclamation)

        '        End If
        '    End If
        'End If
    End Sub

    Private Sub ToolStripButton_OpenEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_OpenEdit.Click
        Dim objSemItem_Image As New clsSemItem
        Dim objDR_Image As DataRow
        If Not intRowID = -1 Then
            If boolIsNamed = False Then
                objDR_Image = procT_Image_Of_Or.Rows(intRowID)
            Else
                objDR_Image = procT_Images_Of_NamedRelated(intRowID)
            End If

            objSemItem_Image.GUID = objDR_Image.Item("GUID_Images__Graphic_")
            objSemItem_Image.Name = objDR_Image.Item("Name_Images__Graphic_")
            objSemItem_Image.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
            objSemItem_Image.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objFrmTokenEdit = New frmTokenEdit(objSemItem_Image, objLocalConfig.Globals)
            objFrmTokenEdit.ShowDialog(Me)
        End If

    End Sub

    Private Sub ToolStripButton_Meta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Meta.Click
        Dim objSemItem_Image As New clsSemItem
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objdR_Image As DataRow
        If Not intRowID = -1 Then

            objdR_Image = procT_Image_Of_Or.Rows(intRowID)
            objSemItem_Image.GUID = objdR_Image.Item("GUID_Images__Graphic_")
            objSemItem_Image.Name = objdR_Image.Item("Name_Images__Graphic_")
            objSemItem_Image.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
            objSemItem_Image.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_File.GUID = objdR_Image.Item("GUID_File")
            objSemItem_File.Name = objdR_Image.Item("Name_File")
            objSemItem_Image.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_Image.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objImageInfo.get_Chronical(objSemItem_Image, objSemItem_File)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Die Metadaten konnten nicht ermittelt werden!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub ContextMenuStrip_Relate_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Relate.Opening
        ToolStripButton_Relate.Enabled = False
        RelateAllToolStripMenuItem.Enabled = False
        SaveImagesToolStripMenuItem.Enabled = False
        If boolAllowRelate = True Then
            If Not intRowID = -1 Then
                RelateToolStripMenuItem.Enabled = True
                RelateAllToolStripMenuItem.Enabled = True

            End If
        End If

        If Not intRowID = -1 Then
            SaveImagesToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub RelateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelateToolStripMenuItem.Click
        If Not intRowID = -1 Then
            RaiseEvent related_Image(intRowID)
        End If
    End Sub

    Private Sub RelateAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelateAllToolStripMenuItem.Click
        If Not intRowID = -1 Then
            RaiseEvent relate_All_Images()
        End If
    End Sub

  
    Private Sub GotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GotoToolStripMenuItem.Click
        Dim intImageID As Integer

        If Not ToolStripTextBox_Goto.Text = "" Then
            If Integer.TryParse(ToolStripTextBox_Goto.Text, intImageID) Then
                If Not objSemItem_Ref Is Nothing Then
                    If boolIsNamed = False Then
                        If intImageID < procT_Image_Of_Or.Rows.Count - 1 Then
                            intRowID = intImageID
                            show_Image()
                            configure_Navigation_Ref()
                        Else
                            MsgBox("Ihre Eingabe überschreitet die Anzahl der Bilder", MsgBoxStyle.Information)
                        End If
                    Else
                        If intImageID < procT_Images_Of_NamedRelated.Count - 1 Then
                            intRowID = intImageID
                            show_Image()
                            configure_Navigation_NamedSemantics()
                        Else
                            MsgBox("Ihre Eingabe überschreitet die Anzahl der Bilder", MsgBoxStyle.Information)
                        End If
                    End If

                Else
                    If intImageID < objDRs_Images.Count - 1 Then
                        intRowID = intImageID
                        show_Image()
                        configure_Navigation_Chrono()
                    Else
                        MsgBox("Ihre Eingabe überschreitet die Anzahl der Bilder", MsgBoxStyle.Information)
                    End If
                End If
            Else
                MsgBox("Bitte nur Zahlen eingeben!", MsgBoxStyle.Information)
            End If
        End If
        
        
    End Sub

    Private Sub ToolStripMenuItem_Stretch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_Stretch.Click
        If ToolStripMenuItem_Stretch.Checked = False Then

            ToolStripMenuItem_Stretch.Checked = True
            ToolStripMenuItem_Original.Checked = False
            ToolStripMenuItem_Zoom.Checked = False
        End If
    End Sub

    Private Sub ToolStripMenuItem_Original_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_Original.Click
        If ToolStripMenuItem_Original.Checked = False Then

            ToolStripMenuItem_Original.Checked = True
            ToolStripMenuItem_Stretch.Checked = False
            ToolStripMenuItem_Zoom.Checked = False
        End If

    End Sub

    Private Sub ToolStripMenuItem_Zoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_Zoom.Click
        

        If ToolStripMenuItem_Zoom.Checked = False Then
            

            ToolStripMenuItem_Original.Checked = False
            ToolStripMenuItem_Stretch.Checked = False
            ToolStripMenuItem_Zoom.Checked = True
        End If
    End Sub

    Private Sub configure_Zoom_Image()

        If ToolStripMenuItem_Stretch.Checked = True Then
        
            PictureBox_Image.Image = AutoSizeImage(objImage, PictureBox_Image.ClientRectangle.Width, PictureBox_Image.ClientRectangle.Height, True)
            PictureBox_Image.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf ToolStripMenuItem_Original.Checked = True Then
            PictureBox_Image.Image = AutoSizeImage(objImage, objImage.Width, objImage.Height)
            PictureBox_Image.SizeMode = PictureBoxSizeMode.Normal
        ElseIf ToolStripMenuItem_Zoom.Checked = True Then
            PictureBox_Image.Image = AutoSizeImage(objImage, PictureBox_Image.ClientRectangle.Width, PictureBox_Image.ClientRectangle.Height, False)
            PictureBox_Image.SizeMode = PictureBoxSizeMode.AutoSize
            'Dim intHeight_PictureBox As Integer
            'Dim intWidth_PictureBox As Integer
            'Dim intHeight_Image As Integer
            'Dim intWidth_Image As Integer
            'Dim intDiff_Width As Integer
            'Dim intDiff_Height As Integer
            'Dim dblFactor As Double
            'Dim objImage As Image

            'intHeight_Image = PictureBox_Image.Image.Height
            'intWidth_Image = PictureBox_Image.Image.Width
            'intHeight_PictureBox = PictureBox_Image.Height
            'intWidth_PictureBox = PictureBox_Image.Width

            'intDiff_Height = intHeight_PictureBox - intHeight_Image

            'intDiff_Width = intWidth_PictureBox - intWidth_Image


            'If System.Math.Abs(intDiff_Height) > System.Math.Abs(intDiff_Width) Then
            '    dblFactor = intHeight_PictureBox / intHeight_Image
            '    intWidth_Image = intWidth_Image * dblFactor
            '    intHeight_Image = intHeight_PictureBox

            '    PictureBox_Image.SizeMode = PictureBoxSizeMode.Normal
            '    objImage = New Bitmap(PictureBox_Image.Image, intWidth_Image, intHeight_Image)
            '    PictureBox_Image.Image = objImage

            'Else
            '    dblFactor = intWidth_PictureBox / intWidth_Image
            '    intWidth_Image = intWidth_PictureBox
            '    intHeight_Image = intHeight_Image * dblFactor

            '    PictureBox_Image.SizeMode = PictureBoxSizeMode.Normal
            '    objImage = New Bitmap(PictureBox_Image.Image, intWidth_Image, intHeight_Image)
            '    PictureBox_Image.Image = objImage
            'End If
        End If
    End Sub

    Private Sub SplitContainer1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SplitContainer1.KeyDown

    End Sub

    Private Sub PictureBox_Image_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Image.Click

    End Sub

    Private Sub SaveImagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveImagesToolStripMenuItem.Click
        Dim objDR_Row As DataRow
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim strPath As String
        Dim strPath_File As String
        Dim intID As Integer
        Dim intToDo As Integer
        Dim intDone As Integer

        FolderBrowserDialog_Save.SelectedPath = Application.ExecutablePath

        If FolderBrowserDialog_Save.ShowDialog(Me) = DialogResult.OK Then
            strPath = FolderBrowserDialog_Save.SelectedPath
            If objSemItem_Ref Is Nothing Then
                intToDo = objDRs_Images.Count
                intDone = 0
                For Each objDR_Row In objDRs_Images
                    intID = 0
                    Do
                        If intID = 0 Then
                            strPath_File = strPath & IO.Path.DirectorySeparatorChar & objDR_Row.Item("Name_Images__Graphic_")
                        Else
                            strPath_File = strPath & IO.Path.DirectorySeparatorChar & "(" & intID & ")" & objDR_Row.Item("Name_Images__Graphic_")
                        End If
                        If IO.Path.GetExtension(strPath_File) = "" Then
                            strPath_File = strPath_File & IO.Path.GetExtension(objDR_Row.Item("Name_File"))
                        End If
                        intID = intID + 1
                    Loop Until IO.File.Exists(strPath_File) = False

                    objSemItem_File.GUID = objDR_Row.Item("GUID_File")
                    objSemItem_File.Name = objDR_Row.Item("Name_File")
                    objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                    objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath_File)

                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        intDone = intDone + 1
                    End If
                Next

                If intDone < intToDo Then
                    MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Images gespeichert werden!", MsgBoxStyle.Exclamation)
                End If
            Else
                If boolIsNamed = False Then
                    For Each objDR_Row In procT_Image_Of_Or.Rows

                    Next

                Else
                    For Each objDR_Row In procT_Images_Of_NamedRelated.Rows

                    Next
                End If
            End If
        End If

        


    End Sub

    Private Sub PictureBox_Image_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox_Image.Resize
        If Not objImage Is Nothing Then
            configure_Zoom_Image()
        End If
    End Sub
End Class
