Imports Sem_Manager
Imports Filesystem_Management
Public Class UserControl_EditImage
    Private objLocalConfig As clsLocalConfig
    Private objTransaction_Image As clsTransaction_Imagevb

    Private objFrm_ImageSingle As frmImageSingle
    Private objUserControl_ImagePersons As UserControl_ImagePersons
    Private objUserControl_ImageBuildings As UserControl_Buildings
    Private objUserControl_ImageSpecies As UserControl_Species
    Private objUserControl_ImagePets As UserControl_Pets
    Private objUserControl_ImagePlants As UserControl_ImagePlant
    Private objUserControl_ImageLoations As UserControl_ImageLocations
    Private objUserControl_ImageLandscapes As UserControl_ImageLandscape
    Private objUserControl_ImageWeatherConditions As UserControl_ImageWeatherCondition
    Private objUserControl_ImageArtWork As UserControl_ArtWork
    Private objUserControl_ImportantEvents As UserControl_ImageImportantEvent

    Private objThread_CreationDate As Threading.Thread

    Private objImageInfo As clsImageInfo
    Private objImage As Image
    Private objDRC_CreationDate As DataRowCollection
    Private boolCreationDate As Boolean

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private objSemItem_Image As clsSemItem
    Private objSemItem_Ref As clsSemItem
    Private objBlobConnection As clsBlobConnection
    Private objFileWork As clsFileWork


    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        objLocalConfig = LocalConfig
        
        initialize()
    End Sub

    Public Sub abort_CreationDate()
        ToolStripLabel_Creation.Text = "-"
        Try
            objThread_CreationDate.Abort()
        Catch ex As Exception

        End Try
        Timer_Create.Stop()
        boolCreationDate = False
    End Sub
    Public Sub initialize()

        abort_CreationDate()

        objUserControl_ImagePersons = New UserControl_ImagePersons(objLocalConfig)
        objUserControl_ImagePersons.Dock = DockStyle.Fill
        TabPage_Persons.Controls.Add(objUserControl_ImagePersons)

        objUserControl_ImageBuildings = New UserControl_Buildings(objLocalConfig)
        objUserControl_ImageBuildings.Dock = DockStyle.Fill
        TabPage_Buildings.Controls.Add(objUserControl_ImageBuildings)

        objUserControl_ImageSpecies = New UserControl_Species(objLocalConfig)
        objUserControl_ImageSpecies.Dock = DockStyle.Fill
        TabPage_Species.Controls.Add(objUserControl_ImageSpecies)

        objUserControl_ImagePets = New UserControl_Pets(objLocalConfig)
        objUserControl_ImagePets.Dock = DockStyle.Fill
        TabPage_Pets.Controls.Add(objUserControl_ImagePets)

        objUserControl_ImagePlants = New UserControl_ImagePlant(objLocalConfig)
        objUserControl_ImagePlants.Dock = DockStyle.Fill
        TabPage_Plants.Controls.Add(objUserControl_ImagePlants)

        objUserControl_ImageLoations = New UserControl_ImageLocations(objLocalConfig)
        objUserControl_ImageLoations.Dock = DockStyle.Fill
        TabPage_Locations.Controls.Add(objUserControl_ImageLoations)

        objUserControl_ImageLandscapes = New UserControl_ImageLandscape(objLocalConfig)
        objUserControl_ImageLandscapes.Dock = DockStyle.Fill
        TabPage_Landscapes.Controls.Add(objUserControl_ImageLandscapes)

        objUserControl_ImageWeatherConditions = New UserControl_ImageWeatherCondition(objLocalConfig)
        objUserControl_ImageWeatherConditions.Dock = DockStyle.Fill
        TabPage_WeatherConditions.Controls.Add(objUserControl_ImageWeatherConditions)

        objUserControl_ImageArtWork = New UserControl_ArtWork(objLocalConfig)
        objUserControl_ImageArtWork.Dock = DockStyle.Fill
        TabPage_ArtWork.Controls.Add(objUserControl_ImageArtWork)

        objUserControl_ImportantEvents = New UserControl_ImageImportantEvent(objLocalConfig)
        objUserControl_ImportantEvents.Dock = DockStyle.Fill
        TabPage_ImportantEvent.Controls.Add(objUserControl_ImportantEvents)

        configure_Controls(False)
        set_DBConnection()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)

        initialize()

    End Sub


    Public Sub initialize(ByVal semItem_Image As clsSemItem)
        objSemItem_Image = semItem_Image


        abort_CreationDate()

        'Application.DoEvents()

        objThread_CreationDate = New Threading.Thread(AddressOf get_CreationDate)
        objThread_CreationDate.Start()
        Timer_Create.Start()

        configure_TabPages()
    End Sub

    Private Sub get_CreationDate()
        Dim funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

        funcA_TokenAttribute_Named_By_GUIDToken.Connection = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)

        objDRC_CreationDate = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Image.GUID, _
                                                                                                             objLocalConfig.SemItem_Attribute_taking.GUID).Rows
        boolCreationDate = True
    End Sub

    Private Sub configure_TabPages()
        objUserControl_ImagePersons.clear_Lists()
        objUserControl_ImageBuildings.clear_Lists()
        objUserControl_ImageSpecies.clear_Lists()
        objUserControl_ImagePets.clear_Lists()
        objUserControl_ImagePlants.clear_Lists()
        objUserControl_ImageLoations.clear_Lists()
        objUserControl_ImageLandscapes.clear_Lists()
        objUserControl_ImportantEvents.clear_Lists()
        objUserControl_ImageWeatherConditions.clear_Lists()
        objUserControl_ImageArtWork.clear_Lists()


        Select Case TabControl1.SelectedTab.Name
            Case TabPage_Image.Name
                load_Image()
            Case TabPage_Buildings.Name
                load_Image(False)
                objUserControl_ImageBuildings.initilialize_Buildings(objSemItem_Image)
            Case TabPage_Locations.Name
                load_Image(False)
                objUserControl_ImageLoations.initilialize_Locations(objSemItem_Image)

            Case TabPage_Species.Name
                load_Image(False)
                objUserControl_ImageSpecies.initilialize_Species(objSemItem_Image)

            Case TabPage_Pets.Name
                load_Image(False)
                objUserControl_ImagePets.initilialize_Pets(objSemItem_Image)
            Case TabPage_Plants.Name
                load_Image(False)
                objUserControl_ImagePlants.initilialize_Plants(objSemItem_Image)

            Case TabPage_ImportantEvent.Name
                load_Image(False)
                objUserControl_ImportantEvents.initilialize_Events(objSemItem_Image)

            Case TabPage_Landscapes.Name
                load_Image(False)
                objUserControl_ImageLandscapes.initilialize_Landscapes(objSemItem_Image)
            Case TabPage_WeatherConditions.Name
                load_Image(False)
                objUserControl_ImageWeatherConditions.initilialize_WeatherConditions(objSemItem_Image)
            Case TabPage_ArtWork.Name
                load_Image(False)
                objUserControl_ImageArtWork.initilialize_ArtWork(objSemItem_Image)
            Case TabPage_Others.Name
                load_Image(False)
            Case TabPage_Persons.Name
                load_Image(False)
                objUserControl_ImagePersons.initilialize_Partners(objSemItem_Image)
        End Select
    End Sub

    Private Sub load_Image(Optional ByVal boolShow As Boolean = True)
        Dim objDRC_File As DataRowCollection
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        Dim strPath As String
        If Not objSemItem_Image Is Nothing Then
            objDRC_File = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Image.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                    objLocalConfig.SemItem_Type_File.GUID).Rows

            If objDRC_File.Count > 0 Then
                objSemItem_File.GUID = objDRC_File(0).Item("GUID_Token_Right")
                objSemItem_File.Name = objDRC_File(0).Item("Name_Token_Right")
                objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                strPath = Environment.ExpandEnvironmentVariables("%temp%") & "\" & Guid.NewGuid.ToString & "." & objLocalConfig.SemItem_Token_Extensions_Image.Name


                objSemItem_Result = objBlobConnection.is_Blob_Present(objSemItem_File)
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath)
                Else


                    strPath = objFileWork.get_Path_FileSystemObject(objSemItem_File)
                    If Not IO.File.Exists(strPath) Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        MsgBox("Die Datei existiert nicht", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objImage = Nothing
                objImage = New Bitmap(strPath)
                If boolShow = True Then
                    configure_Zoom_Image()
                    configure_Controls(True)
                End If
                
                If Not objFrm_ImageSingle Is Nothing Then
                    If objFrm_ImageSingle.IsHandleCreated Then
                        objFrm_ImageSingle.change_Image(objImage)

                    End If
                End If

            Else
                If boolShow = True Then
                    configure_Zoom_Image()
                    configure_Controls(False)
                End If
                
            End If


        Else
            PictureBox_Image.Image.Dispose()
            If boolShow = True Then
                configure_Zoom_Image()
                configure_Controls(False)
            End If

            
        End If

    End Sub

    Public Sub configure_Controls(ByVal boolEnable As Boolean)
        ToolStripButton_Copy.Enabled = boolEnable
        ToolStripButton_Delete.Enabled = boolEnable
        ToolStripButton_Paste.Enabled = boolEnable
        ToolStripSplitButton_Scale.Enabled = boolEnable
        ToolStripButton_LoadImage.Enabled = boolEnable
        ToolStripButton_OwnWindow.Enabled = boolEnable
        ToolStripButton_getMeta.Enabled = boolEnable
        If boolEnable = True Then
            ToolStripLabel_Name.Text = objSemItem_Image.Name
            If Not PictureBox_Image.Image Is Nothing Then
                ToolStripLabel_size.Text = PictureBox_Image.Image.Width.ToString & "/" & PictureBox_Image.Image.Height.ToString
            End If

        Else
            PictureBox_Image.Image = Nothing
            ToolStripLabel_Name.Text = "-"
            ToolStripLabel_size.Text = "/"
        End If

        If Not objSemItem_Image Is Nothing Then
            ToolStripButton_getMeta.Enabled = True
            ToolStripButton_LoadImage.Enabled = True
            ToolStripButton_OwnWindow.Enabled = True
        End If
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
        objFileWork = New clsFileWork(objLocalConfig.Globals)
        objTransaction_Image = New clsTransaction_Imagevb(objLocalConfig)

        objImageInfo = New clsImageInfo(objLocalConfig)
    End Sub


    Private Sub ToolStripButton_LoadImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_LoadImage.Click
        If Not objSemItem_Image Is Nothing Then
            Dim strPath As String
            Dim objImage As Image
            Dim objSemItem_Result As clsSemItem
            Dim objSemItem_File As clsSemItem
            If OpenFileDialog_Image.ShowDialog(Me) = DialogResult.OK Then

                If OpenFileDialog_Image.FileNames.Count = 1 Then
                    Try
                        strPath = OpenFileDialog_Image.FileNames(0)
                        objSemItem_File = New clsSemItem
                        objSemItem_File.GUID = Guid.NewGuid
                        objSemItem_File.Name = strPath.Substring(strPath.LastIndexOf("\") + 1)
                        objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                        objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_Image.save_004_File(objSemItem_File)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_Image.save_005_Blob(strPath)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_Image.save_006_ImageGraphic_To_File(objSemItem_Image)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objImage = New Bitmap(strPath)
                                    PictureBox_Image.Image = objImage
                                    configure_Controls(True)
                                    configure_Zoom_Image()
                                Else
                                    MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                                    objTransaction_Image.del_005_Blob()
                                    objTransaction_Image.del_004_File()
                                End If
                            Else
                                MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                                objTransaction_Image.del_004_File()
                            End If


                        Else
                            MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                        End If


                    Catch ex As Exception
                        MsgBox("Die Datei konnte nicht geladen werden!", MsgBoxStyle.Exclamation)
                    End Try
                End If

            End If

        End If
    End Sub

    Private Sub ToolStripButton_OwnWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_OwnWindow.Click
        objFrm_ImageSingle = New frmImageSingle(PictureBox_Image.Image)
        objFrm_ImageSingle.Show()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        configure_TabPages()
    End Sub

    Private Sub ToolStripButton_getMeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_getMeta.Click
        Dim objDRC_File As DataRowCollection
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        
        objDRC_File = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Image.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                    objLocalConfig.SemItem_Type_File.GUID).Rows


        objSemItem_File.GUID = objDRC_File(0).Item("GUID_Token_Right")
        objSemItem_File.Name = objDRC_File(0).Item("Name_Token_Right")
        objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
        objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objSemItem_Result = objImageInfo.get_Chronical(objSemItem_Image, objSemItem_File)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Die Metadaten konnten nicht ermittelt werden!", MsgBoxStyle.Exclamation)
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

    Private Sub PictureBox_Image_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox_Image.Paint
        If Not objImage Is Nothing Then
            configure_Zoom_Image()
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

        End If
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

    Private Sub Timer_Create_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Create.Tick
        If boolCreationDate = False Then
            ToolStripLabel_Creation.Text = "Loading..."
        Else
            If objDRC_CreationDate.Count > 0 Then
                ToolStripLabel_Creation.Text = objDRC_CreationDate(0).Item("Val_Datetime")
            Else
                ToolStripLabel_Creation.Text = "-"
            End If
            Timer_Create.Stop()
        End If
    End Sub
End Class