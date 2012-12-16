Imports Sem_Manager
Imports Filesystem_Management
Public Class UserControl_MediaDetail_MP3

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private procA_Composer As New ds_ImageModuleTableAdapters.proc_ComposerTableAdapter

    Private objDlg_Attribute_VARCHAR255 As dlgAttribute_Varchar255
    Private objDlg_Attribute_VARCHARMAX As dlgAttribute_VarcharMax
    Private objFrmSemManager As frmSemManager

    Private objLocalConfig As clsLocalConfig

    Private objBlobConnection As clsBlobConnection

    Private objTransaction_MP3 As clsTransaction_MP3

    Private objThread_Data As Threading.Thread

    Private objSemItem_File As clsSemItem
    Private objSemItem_MediaItem As clsSemItem
    Private objSemItem_MP3 As clsSemItem

    Dim objDRC_Title As DataRowCollection
    Dim boolTitleDone As Boolean
    Dim objDRC_Comment As DataRowCollection
    Dim boolCommentDone As Boolean
    Dim objDRC_Laenge As DataRowCollection
    Dim boolLaengeDone As Boolean
    Dim objDRC_Album As DataRowCollection
    Dim boolAlbumDone As Boolean
    Dim objDRC_Artist As DataRowCollection
    Dim boolArtistDone As Boolean
    Dim objDRC_Genre As DataRowCollection
    Dim boolGenre As Boolean
    Dim objDRC_Disk As DataRowCollection
    Dim boolDiskDone As Boolean
    Dim objDRC_Composer As DataRowCollection
    Dim boolComposerDone As Boolean
    Dim objDRC_Year As DataRowCollection
    Dim boolYearDone As Boolean

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_File As clsSemItem, ByVal SemItem_MediaItem As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        objSemItem_File = SemItem_File
        objSemItem_MediaItem = SemItem_MediaItem

        initialize()
    End Sub

    Private Sub get_BaseData_MP3()
        Dim objDRC_MP3 As DataRowCollection
        objDRC_MP3 = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_MediaItem.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                   objLocalConfig.SemItem_Type_mp3_File.GUID).Rows
        If objDRC_MP3.Count > 0 Then
            objSemItem_MP3 = New clsSemItem
            objSemItem_MP3.GUID = objDRC_MP3(0).Item("GUID_Token_Left")
            objSemItem_MP3.Name = objDRC_MP3(0).Item("Name_Token_Left")
            objSemItem_MP3.GUID_Parent = objLocalConfig.SemItem_Type_mp3_File.GUID
            objSemItem_MP3.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        Else
            objSemItem_MP3 = Nothing
        End If
    End Sub

    Private Sub get_Data_Title()
        If Not objSemItem_MP3 Is Nothing Then
            objDRC_Title = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_MP3.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_Titel.GUID).Rows
        Else
            objDRC_Title = Nothing

        End If
        
        boolTitleDone = True
    End Sub

    Private Sub get_Data_Comment()
        If Not objSemItem_MP3 Is Nothing Then
            objDRC_Comment = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_MP3.GUID, _
                                                                                                            objLocalConfig.SemItem_Attribute_comment.GUID).Rows
        Else
            objDRC_Comment = Nothing

        End If
        boolCommentDone = True
    End Sub

    Private Sub get_Data_Album()
        If Not objSemItem_MP3 Is Nothing Then
            objDRC_Album = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_MP3.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_from.GUID, _
                                                                         objLocalConfig.SemItem_Type_Album.GUID).Rows

        Else
            objDRC_Album = Nothing
        End If

        boolAlbumDone = True
    End Sub

    Private Sub get_Data_Artist()
        If Not objSemItem_MP3 Is Nothing Then
            objDRC_Artist = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_MP3.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_Artist.GUID, _
                                                                          objLocalConfig.SemItem_Type_Band.GUID).Rows

        Else
            objDRC_Artist = Nothing
        End If

        boolArtistDone = True
    End Sub

    Private Sub get_Data_Genre()
        If Not objSemItem_MP3 Is Nothing Then
            objDRC_Genre = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_MP3.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                         objLocalConfig.SemItem_Type_Genre.GUID).Rows
        Else
            objDRC_Genre = Nothing
        End If

        boolGenre = True
    End Sub

    Private Sub get_Data_Disk()
        If Not objSemItem_MP3 Is Nothing Then
            objDRC_Disk = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_MP3.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_Disc.GUID, _
                                                                        objLocalConfig.SemItem_Type_Media.GUID).Rows

        Else
            objDRC_Disk = Nothing
        End If

        boolDiskDone = True
    End Sub

    Private Sub get_Data_Composer()
        If Not objSemItem_MP3 Is Nothing Then
            objDRC_Composer = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_MP3.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_Composer.GUID, _
                                                                            objLocalConfig.SemItem_Type_Partner.GUID).Rows
        Else
            objDRC_Composer = Nothing
        End If

        boolComposerDone = True
    End Sub

    Private Sub get_Data_Length()
        If Not objSemItem_MP3 Is Nothing Then
            objDRC_Laenge = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_MP3.GUID, _
                                                                                                           objLocalConfig.SemItem_Attribute_L_nge__Minuten_.GUID).Rows
        Else
            objDRC_Laenge = Nothing
        End If

        boolLaengeDone = True
    End Sub

    Private Sub get_Data_Year()
        If Not objSemItem_MP3 Is Nothing Then
            objDRC_Year = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_MP3.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_from.GUID, _
                                                                        objLocalConfig.SemItem_Type_Year.GUID).Rows

        Else
            objDRC_Year = Nothing
        End If

        boolYearDone = True
    End Sub

    Private Sub get_Data()
        get_Data_Album()
        get_Data_Artist()
        get_Data_Comment()
        get_Data_Composer()
        get_Data_Disk()
        get_Data_Genre()
        get_Data_Title()
        get_Data_Year()
        get_Data_Length()
    End Sub

    Private Sub initialize()

        set_DBConnection()
        get_BaseData_MP3()
        clear_Controls()
        If Not objSemItem_MediaItem Is Nothing Then
            objThread_Data = New Threading.Thread(AddressOf get_Data)
            objThread_Data.Start()
            Timer_MP3.Start()
        End If
        If Not objSemItem_File Is Nothing Then
            ToolStripButton_FromFile.Enabled = True
        End If
    End Sub

    Private Sub clear_Controls()
        boolAlbumDone = False
        boolArtistDone = False
        boolCommentDone = False
        boolComposerDone = False
        boolDiskDone = False
        boolGenre = False
        boolLaengeDone = False
        boolTitleDone = False
        boolYearDone = False

        TextBox_Album.Enabled = False
        TextBox_Artist.Enabled = False
        TextBox_Comment.Enabled = False
        TextBox_Composer.Enabled = False
        TextBox_Length.Enabled = False
        TextBox_Title.Enabled = False
        TextBox_Year.Enabled = False
        TextBox_Genre.Enabled = False
        TextBox_Disk.Enabled = False

        TextBox_Album.Clear()
        TextBox_Artist.Clear()
        TextBox_Comment.Clear()
        TextBox_Composer.Clear()
        TextBox_Length.Clear()
        TextBox_Title.Clear()
        TextBox_Year.Clear()
        TextBox_Genre.Clear()
        TextBox_Disk.Clear()

        ToolStripButton_FromFile.Enabled = False
        ToolStripButton_ToFile.Enabled = False
    End Sub

    Private Sub set_DBConnection()

        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        procA_Composer.Connection = objLocalConfig.Connection_DB

        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)

        objTransaction_MP3 = New clsTransaction_MP3(objLocalConfig)


    End Sub

    Private Sub Timer_MP3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_MP3.Tick
        Dim boolStop As Boolean
        Dim intProgress As Integer

        boolStop = True
        intProgress = 0

        If boolAlbumDone = True Then
            If Not objDRC_Album Is Nothing Then
                If objDRC_Album.Count > 0 Then
                    ToolStripButton_ToFile.Enabled = True
                    TextBox_Album.Text = objDRC_Album(0).Item("Name_Token_Right")
                    Button_Del_Album.Enabled = True
                End If
            End If

            Button_Album.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolArtistDone = True Then
            If Not objDRC_Artist Is Nothing Then
                If objDRC_Artist.Count > 0 Then
                    ToolStripButton_ToFile.Enabled = True
                    TextBox_Artist.Text = objDRC_Artist(0).Item("Name_Token_Right")
                    Button_Del_Artist.Enabled = True
                End If
            End If


            Button_Artist.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolCommentDone = True Then
            If Not objDRC_Comment Is Nothing Then
                If objDRC_Comment.Count > 0 Then
                    ToolStripButton_ToFile.Enabled = True
                    TextBox_Comment.Text = objDRC_Comment(0).Item("Val_VARCHARMAX")
                End If
            End If

            TextBox_Comment.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolComposerDone = True Then
            If Not objDRC_Composer Is Nothing Then
                If objDRC_Composer.Count > 0 Then
                    ToolStripButton_ToFile.Enabled = True
                    TextBox_Composer.Text = objDRC_Composer(0).Item("Name_Token_Right")
                    Button_Del_Composer.Enabled = True
                End If
            End If

            Button_Composer.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolDiskDone = True Then
            If Not objDRC_Disk Is Nothing Then
                If objDRC_Disk.Count > 0 Then
                    ToolStripButton_ToFile.Enabled = True
                    TextBox_Disk.Text = objDRC_Disk(0).Item("Name_Token_Right")
                    Button_Del_Disk.Enabled = True
                End If
            End If

            Button_Disk.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolGenre = True Then
            If Not objDRC_Genre Is Nothing Then
                If objDRC_Genre.Count > 0 Then
                    ToolStripButton_ToFile.Enabled = True
                    TextBox_Genre.Text = objDRC_Genre(0).Item("Name_Token_Right")
                    Button_Del_Genre.Enabled = True
                End If
            End If


            Button_Genre.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolLaengeDone = True Then
            If Not objDRC_Laenge Is Nothing Then
                If objDRC_Laenge.Count > 0 Then
                    ToolStripButton_ToFile.Enabled = True
                    TextBox_Length.Text = objDRC_Laenge(0).Item("Val_Real").ToString
                End If
            End If

            TextBox_Length.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolTitleDone = True Then
            If Not objDRC_Title Is Nothing Then
                If objDRC_Title.Count > 0 Then
                    ToolStripButton_ToFile.Enabled = True
                    TextBox_Title.Text = objDRC_Title(0).Item("Val_VARCHAR255")
                End If
            End If

            TextBox_Title.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolYearDone = True Then
            If Not objDRC_Year Is Nothing Then
                If objDRC_Year.Count > 0 Then
                    ToolStripButton_ToFile.Enabled = True
                    TextBox_Year.Text = objDRC_Year(0).Item("Name_Token_Right")
                    Button_Del_Year.Enabled = True
                End If
            End If

            Button_Year.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolStop = True Then
            ToolStripProgressBar_Readed.Visible = False
            ToolStripProgressBar_Readed.Value = 0
            Timer_MP3.Stop()
        Else
            ToolStripProgressBar_Readed.Visible = True
            ToolStripProgressBar_Readed.Value = intProgress
        End If
    End Sub

    Private Sub Button_Del_Composer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del_Composer.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_MP3.del_012_MP3_To_Partner
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_Composer.Text = ""
                Button_Del_Composer.Enabled = False
            Else
                MsgBox("Der Composer kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                Button_Del_Composer.Enabled = False
            End If
        Else
            MsgBox("Der Composer kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
            Button_Del_Composer.Enabled = False
        End If
    End Sub

    Private Sub Button_Composer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Composer.Click
        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Partner, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)

        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem

        Dim objSemItem_Partner As clsSemItem

        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Partner.GUID Then
                        objSemItem_Partner = New clsSemItem
                        objSemItem_Partner.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Partner.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Partner.GUID_Parent = objLocalConfig.SemItem_Type_Media.GUID
                        objSemItem_Partner.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_MP3.save_002_MediaItem_To_MP3
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_MP3.save_012_MP3_To_Partner(objSemItem_Partner)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    TextBox_Composer.Text = objSemItem_Partner.Name
                                    Button_Del_Composer.Enabled = True
                                Else
                                    MsgBox("Der Composer kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                    Button_Composer.Enabled = False
                                    Button_Del_Composer.Enabled = False
                                    TextBox_Composer.Text = ""
                                End If
                            Else
                                MsgBox("Der Composer kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                objTransaction_MP3.del_001_MP3()
                                Button_Composer.Enabled = False
                                Button_Del_Composer.Enabled = False
                                TextBox_Composer.Text = ""
                            End If
                            
                        Else
                            MsgBox("Der Composer kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                            Button_Composer.Enabled = False
                            Button_Del_Composer.Enabled = False
                            TextBox_Composer.Text = ""
                        End If

                    Else
                        MsgBox("Bitte einen Composer auswählen!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Bitte nur einen Composer auswählen!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte einen Composer auswählen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub TextBox_Title_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox_Title.MouseDoubleClick
        If TextBox_Title.Enabled = True Then
            objDlg_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Attribute_Titel.Name, _
                                                                  objLocalConfig.Globals, _
                                                                  TextBox_Title.Text)
            objDlg_Attribute_VARCHAR255.ShowDialog(Me)
            If objDlg_Attribute_VARCHAR255.DialogResult = Windows.Forms.DialogResult.OK Then
                TextBox_Title.Text = objDlg_Attribute_VARCHAR255.Value1
            End If
        End If
        

    End Sub

 
    Private Sub TextBox_Title_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Title.TextChanged
        Timer_Title.Stop()
        If TextBox_Title.Enabled = True Then
            Timer_Title.Start()
        End If
    End Sub

    Private Sub Timer_Title_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Title.Tick
        Timer_Title.Stop()
        Dim objSemItem_Result As clsSemItem
        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_MP3.save_002_MediaItem_To_MP3
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                objSemItem_Result = objTransaction_MP3.save_003_MP3__Title(TextBox_Title.Text, _
                                                                       objTransaction_MP3.SemItem_MP3)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Der Titel kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    TextBox_Title.Enabled = False
                    TextBox_Title.Text = ""
                End If
            Else
                MsgBox("Der Titel kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                objTransaction_MP3.del_001_MP3()
                TextBox_Title.Enabled = False
                TextBox_Title.Text = ""
            End If
            
        Else

            MsgBox("Der Titel kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
            TextBox_Title.Enabled = False
            TextBox_Title.Text = ""
        End If

    End Sub

    Private Sub TextBox_Comment_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox_Comment.MouseDoubleClick
        If TextBox_Comment.Enabled = True Then
            objDlg_Attribute_VARCHARMAX = New dlgAttribute_VarcharMax(objLocalConfig.SemItem_Attribute_comment.Name, _
                                                                      objLocalConfig.Globals)
            objDlg_Attribute_VARCHARMAX.ShowDialog(Me)
            If objDlg_Attribute_VARCHARMAX.DialogResult = Windows.Forms.DialogResult.OK Then
                TextBox_Comment.Text = objDlg_Attribute_VARCHARMAX.Value
            End If
        End If
    End Sub

    Private Sub TextBox_Comment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Comment.TextChanged
        Timer_Comment.Stop()
        If TextBox_Comment.Enabled = True Then
            Timer_Comment.Start()
        End If
    End Sub

    Private Sub Timer_Comment_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Comment.Tick
        Timer_Comment.Stop()
        Dim objSemItem_Result As clsSemItem
        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_MP3.save_002_MediaItem_To_MP3
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_MP3.save_004_MP3__Comment(TextBox_Comment.Text, _
                                                                       objTransaction_MP3.SemItem_MP3)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Der Kommentar kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    TextBox_Comment.Enabled = False
                    TextBox_Comment.Text = ""
                End If
            Else
                MsgBox("Der Kommentar kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                objTransaction_MP3.del_001_MP3()
                TextBox_Comment.Enabled = False
                TextBox_Comment.Text = ""
            End If
            
        Else

            MsgBox("Der Kommentar kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
            TextBox_Comment.Enabled = False
            TextBox_Comment.Text = ""
        End If
    End Sub

    Private Sub TextBox_Length_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Length.TextChanged
        Timer_Length.Stop()
        If TextBox_Length.Enabled = True Then
            Timer_Length.Start()
        End If
    End Sub

    Private Sub Timer_Length_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Length.Tick
        Timer_Length.Stop()
        Dim objSemItem_Result As clsSemItem
        Dim dblLength As Double
        If Double.TryParse(TextBox_Length.Text, dblLength) = True Then
            objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_MP3.save_002_MediaItem_To_MP3
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_MP3.save_005_MP3__Length(dblLength, _
                                                                           objTransaction_MP3.SemItem_MP3)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Der Kommentar kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                        TextBox_Length.Enabled = False
                        TextBox_Length.Text = ""
                    End If
                Else
                    MsgBox("Der Kommentar kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    objTransaction_MP3.del_001_MP3()
                    TextBox_Length.Enabled = False
                    TextBox_Length.Text = ""
                End If
                
            Else

                MsgBox("Der Kommentar kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                TextBox_Length.Enabled = False
                TextBox_Length.Text = ""
            End If
        Else
            MsgBox("Bitte eine gültige Länge eingeben!", MsgBoxStyle.Exclamation)
            TextBox_Length.Enabled = False
            TextBox_Length.Text = ""
            TextBox_Length.Enabled = True
        End If
        

    End Sub

    Private Sub Button_Album_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Album.Click
        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Album, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)

        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem

        Dim objSemItem_Album As clsSemItem

        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Album.GUID Then
                        objSemItem_Album = New clsSemItem
                        objSemItem_Album.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Album.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Album.GUID_Parent = objLocalConfig.SemItem_Type_Album.GUID
                        objSemItem_Album.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_MP3.save_002_MediaItem_To_MP3
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_MP3.save_006_MP3_To_Album(objSemItem_Album)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    TextBox_Album.Text = objSemItem_Album.Name
                                    Button_Del_Album.Enabled = True
                                Else
                                    MsgBox("Das Album kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                    Button_Album.Enabled = False
                                    Button_Del_Album.Enabled = False
                                    TextBox_Album.Text = ""
                                End If
                            Else
                                MsgBox("Das Album kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                objTransaction_MP3.del_001_MP3()
                                Button_Album.Enabled = False
                                Button_Del_Album.Enabled = False
                                TextBox_Album.Text = ""
                            End If
                            
                        Else
                            MsgBox("Das Album kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                            Button_Album.Enabled = False
                            Button_Del_Album.Enabled = False
                            TextBox_Album.Text = ""
                        End If

                    Else
                        MsgBox("Bitte ein Album auswählen!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Bitte nur ein Album auswählen!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte ein Album auswählen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub Button_Del_Album_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del_Album.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_MP3.del_006_MP3_To_Album
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_Album.Text = ""
                Button_Del_Album.Enabled = False
            Else
                MsgBox("Das Album kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                Button_Del_Album.Enabled = False
            End If
        Else
            MsgBox("Das Album kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
            Button_Del_Album.Enabled = False
        End If
    End Sub

    Private Sub Button_Artist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Artist.Click
        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Band, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)

        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem

        Dim objSemItem_Artist As clsSemItem

        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Band.GUID Then
                        objSemItem_Artist = New clsSemItem
                        objSemItem_Artist.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Artist.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Artist.GUID_Parent = objLocalConfig.SemItem_Type_Band.GUID
                        objSemItem_Artist.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_MP3.save_002_MediaItem_To_MP3
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_MP3.save_007_MP3_To_Artist(objSemItem_Artist)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    TextBox_Artist.Text = objSemItem_Artist.Name
                                    Button_Del_Artist.Enabled = True
                                Else
                                    MsgBox("Die Band kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                    Button_Artist.Enabled = False
                                    Button_Del_Artist.Enabled = False
                                    TextBox_Artist.Text = ""
                                End If
                            Else
                                MsgBox("Die Band kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                objTransaction_MP3.del_001_MP3()
                                Button_Artist.Enabled = False
                                Button_Del_Artist.Enabled = False
                                TextBox_Artist.Text = ""
                            End If
                            
                        Else
                            MsgBox("Die Band kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                            Button_Artist.Enabled = False
                            Button_Del_Artist.Enabled = False
                            TextBox_Artist.Text = ""
                        End If

                    Else
                        MsgBox("Bitte eine Band auswählen!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Bitte nur eine Band auswählen!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte eine Band auswählen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub Button_Del_Artist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del_Artist.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_MP3.del_007_MP3_To_Artist
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_Artist.Text = ""
                Button_Del_Artist.Enabled = False
            Else
                MsgBox("Die Band kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                Button_Del_Artist.Enabled = False
            End If
        Else
            MsgBox("Die Band kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
            Button_Del_Artist.Enabled = False
        End If
    End Sub

    Private Sub Button_Genre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Genre.Click
        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Genre, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)

        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem

        Dim objSemItem_Genre As clsSemItem

        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Genre.GUID Then
                        objSemItem_Genre = New clsSemItem
                        objSemItem_Genre.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Genre.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Genre.GUID_Parent = objLocalConfig.SemItem_Type_Genre.GUID
                        objSemItem_Genre.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_MP3.save_002_MediaItem_To_MP3
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_MP3.save_009_MP3_To_Genre(objSemItem_Genre)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    TextBox_Genre.Text = objSemItem_Genre.Name
                                    Button_Del_Genre.Enabled = True
                                Else
                                    MsgBox("Das Genre kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                    Button_Genre.Enabled = False
                                    Button_Del_Genre.Enabled = False
                                    TextBox_Genre.Text = ""
                                End If
                            Else
                                MsgBox("Das Genre kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                objTransaction_MP3.del_001_MP3()
                                Button_Genre.Enabled = False
                                Button_Del_Genre.Enabled = False
                                TextBox_Genre.Text = ""
                            End If
                            
                        Else
                            MsgBox("Das Genre kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                            Button_Genre.Enabled = False
                            Button_Del_Genre.Enabled = False
                            TextBox_Genre.Text = ""
                        End If

                    Else
                        MsgBox("Bitte ein Genre auswählen!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Bitte nur ein Genre auswählen!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte ein Genre auswählen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub Button_Del_Genre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del_Genre.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_MP3.del_009_MP3_To_Genre
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_Genre.Text = ""
                Button_Del_Genre.Enabled = False
            Else
                MsgBox("Das Genre kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                Button_Del_Genre.Enabled = False
            End If
        Else
            MsgBox("Das Genre kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
            Button_Del_Genre.Enabled = False
        End If
    End Sub

    Private Sub Button_Disk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Disk.Click
        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Media, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)

        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem

        Dim objSemItem_Media As clsSemItem

        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Media.GUID Then
                        objSemItem_Media = New clsSemItem
                        objSemItem_Media.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Media.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Media.GUID_Parent = objLocalConfig.SemItem_Type_Media.GUID
                        objSemItem_Media.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_MP3.save_002_MediaItem_To_MP3
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_MP3.save_010_MP3_To_Media(objSemItem_Media)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    TextBox_Disk.Text = objSemItem_Media.Name
                                    Button_Del_Disk.Enabled = True
                                Else
                                    MsgBox("Die Disk kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                    Button_Disk.Enabled = False
                                    Button_Del_Disk.Enabled = False
                                    TextBox_Disk.Text = ""
                                End If
                            Else
                                MsgBox("Die Disk kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                objTransaction_MP3.del_001_MP3()
                                Button_Disk.Enabled = False
                                Button_Del_Disk.Enabled = False
                                TextBox_Disk.Text = ""
                            End If
                            
                        Else
                            MsgBox("Die Disk kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                            Button_Disk.Enabled = False
                            Button_Del_Disk.Enabled = False
                            TextBox_Disk.Text = ""
                        End If

                    Else
                        MsgBox("Bitte eine Disk auswählen!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Bitte nur eine Disk auswählen!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte eine Disk auswählen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub Button_Del_Disk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del_Disk.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_MP3.del_010_MP3_To_Media
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_Disk.Text = ""
                Button_Del_Disk.Enabled = False
            Else
                MsgBox("Die Disk kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
                Button_Del_Disk.Enabled = False
            End If
        Else
            MsgBox("Die Disk kann nicht entfernt werden!", MsgBoxStyle.Exclamation)
            Button_Del_Disk.Enabled = False
        End If
    End Sub

    Private Sub Button_Year_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Year.Click
        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Media, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)

        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem

        Dim objSemItem_Year As clsSemItem

        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Year.GUID Then
                        objSemItem_Year = New clsSemItem
                        objSemItem_Year.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Year.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Year.GUID_Parent = objLocalConfig.SemItem_Type_Year.GUID
                        objSemItem_Year.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_MP3.save_002_MediaItem_To_MP3
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_MP3.save_014_MP3_To_Year(objSemItem_Year)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    TextBox_Year.Text = objSemItem_Year.Name
                                    Button_Del_Year.Enabled = True
                                Else
                                    MsgBox("Das Jahr kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                    Button_Year.Enabled = False
                                    Button_Del_Year.Enabled = False
                                    TextBox_Year.Text = ""
                                End If
                            Else
                                MsgBox("Das Jahr kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                                objTransaction_MP3.del_001_MP3()
                                Button_Year.Enabled = False
                                Button_Del_Year.Enabled = False
                                TextBox_Year.Text = ""
                            End If
                            
                        Else
                            MsgBox("Das Jahr kann nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                            Button_Year.Enabled = False
                            Button_Del_Year.Enabled = False
                            TextBox_Year.Text = ""
                        End If

                    Else
                        MsgBox("Bitte ein Jahr auswählen!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Bitte nur ein Jahr auswählen!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte ein Jahr auswählen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub ToolStripButton_FromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_FromFile.Click
        Dim strPath As String
        Dim objMP3File As Mp3Lib.Mp3File
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Ref As New clsSemItem
        Dim objDRC_Ref As DataRowCollection
        Dim strTag As String
        strPath = Environment.ExpandEnvironmentVariables("%temp%")
        strPath = strPath & Guid.NewGuid.ToString
        objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            Try
                objMP3File = New Mp3Lib.Mp3File(strPath)

                objSemItem_Result = objTransaction_MP3.save_001_MP3(objSemItem_MediaItem)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_MP3.save_002_MediaItem_To_MP3()
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        strTag = objMP3File.TagHandler.Title
                        If strTag <> "" Then
                            objSemItem_Result = objTransaction_MP3.save_003_MP3__Title(strTag)
                        End If

                        strTag = objMP3File.TagHandler.Comment
                        If strTag <> "" Then
                            objSemItem_Result = objTransaction_MP3.save_004_MP3__Comment(strTag)
                        End If

                        strTag = objMP3File.TagHandler.Length.ToString
                        If strTag <> "" Then
                            objSemItem_Result = objTransaction_MP3.save_005_MP3__Length(strTag)
                        End If

                        strTag = objMP3File.TagHandler.Composer
                        If strTag <> "" Then
                            objDRC_Ref = procA_Composer.GetData(objLocalConfig.SemItem_Type_Partner.GUID, _
                                                                objLocalConfig.SemItem_RelationType_Composer.GUID, _
                                                                objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                strTag).Rows
                            If objDRC_Ref.Count = 0 Then
                            Else
                                
                            End If
                            'objSemItem_Result = objTransaction_MP3.save_005_MP3__Lengt(strTag)
                        End If

                    Else

                    End If


                    strTag = objMP3File.TagHandler.Length.ToString
                Else

                End If

            Catch ex As Exception
                MsgBox("Datei wurde nicht als mp3-File erkannt!", MsgBoxStyle.Exclamation)
            End Try


        Else
            MsgBox("Die Datei konnte nicht geöffnet werden!", MsgBoxStyle.Exclamation)
        End If


    End Sub
End Class
