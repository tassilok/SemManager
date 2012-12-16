Imports Sem_Manager
Imports MediaViewer_Module
Public Class UserControl_PersonalData

    Private objSemItem_Partner As clsSemItem
    Private objLocalConfig As clsLocalConfig

    Private objDLG_Attribute_VARCHAR255 As dlgAttribute_Varchar255
    Private objFrm_DateTimePicker As New frmDateTimePicker
    Private objTransaction_PersonalData As clsTransaction_PersonalData
    Private objFrmSemManager As frmSemManager
    Private objUserControl_ImageEdit As UserControl_EditImage

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_Geschlecht As New ds_SemDB.semtbl_TokenDataTable
    Private semtblT_Familienstand As New ds_SemDB.semtbl_TokenDataTable

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDTokenT As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter


    Private objThread_Data As Threading.Thread

    Private objSemItem_PersonalData As clsSemItem

    Private objDRC_Voranme As DataRowCollection
    Private boolVorname As Boolean
    Private objDRC_Nachname As DataRowCollection
    Private boolNachname As Boolean
    Private objDRC_Geschlecht As DataRowCollection
    Private boolGeschlecht As Boolean
    Private objDRC_Geburtsdatum As DataRowCollection
    Private boolGeburtsdatum As Boolean
    Private objDRC_Todesdatum As DataRowCollection
    Private boolTodesdatum As Boolean
    Private objDRC_Familienstand As DataRowCollection
    Private boolFamilienstand As Boolean
    Private objDRC_Sozialversicherungsnummer As DataRowCollection
    Private boolSozialversicherungsnummer As Boolean
    Private objDRC_eTin As DataRowCollection
    Private boolETin As Boolean
    Private objDRC_Identifikationsnummer As DataRowCollection
    Private boolIdNr As Boolean
    Private objDRC_Steuernummer As DataRowCollection
    Private boolSteuernummer As Boolean
    Private objSemItem_Image As clsSemItem
    Private boolPhoto As Boolean


    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_Partner As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig
        objSemItem_Partner = SemItem_Partner
        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals, ByVal SemItem_Partner As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(Globals)
        objSemItem_Partner = SemItem_Partner
        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()

        objUserControl_ImageEdit = New UserControl_EditImage(objLocalConfig.Globals)
        objUserControl_ImageEdit.Dock = Windows.Forms.DockStyle.Fill
        Panel_Foto.Controls.Add(objUserControl_ImageEdit)

        clear_Controls()
        get_BaseData_Geschlecht()
        get_BaseData_Familienstand()


        ComboBox_Familienstand.DataSource = semtblT_Familienstand
        ComboBox_Geschlecht.DataSource = semtblT_Geschlecht
        ComboBox_Familienstand.ValueMember = "GUID_Token"
        ComboBox_Familienstand.DisplayMember = "Name_Token"
        ComboBox_Geschlecht.ValueMember = "GUID_token"
        ComboBox_Geschlecht.DisplayMember = "Name_Token"




        Timer_Data.Stop()
        Try
            objThread_Data.Abort()

        Catch ex As Exception

        End Try
        If Not objSemItem_Partner Is Nothing Then
            get_BaseData_personalData()
            get_Data_Foto()
            objThread_Data = New Threading.Thread(AddressOf get_Data)
            objThread_Data.Start()
            Timer_Data.Start()
        End If
        
    End Sub

    Private Sub get_Data()
        If Not objSemItem_PersonalData Is Nothing Then
            get_Data_eTin()
            get_Data_Familienstand()
            get_Data_Geburtsdatum()
            get_Data_Todesdatum()
            get_Data_Geschlecht()
            get_Data_Nachname()
            get_Data_Sozialversicherungsnummer()
            get_Data_Vorname()
            get_Data_IdentifikationsNummer()
            get_Data_Steuernummer()
        Else
            boolETin = True
            boolFamilienstand = True
            boolGeburtsdatum = True
            boolTodesdatum = True
            boolGeschlecht = True
            boolNachname = True
            boolSozialversicherungsnummer = True
            boolVorname = True
            boolIdNr = True
            boolSteuernummer = True
        End If

    End Sub

    Private Sub get_Data_Foto()
        Dim objDRC_Image As DataRowCollection

        objSemItem_Image = Nothing
        If Not objSemItem_PersonalData Is Nothing Then
            Button_AddImageExisting.Enabled = True
            Button_AddImageNew.Enabled = True
            objDRC_Image = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belonging_photo.GUID, _
                                                                     objLocalConfig.SemItem_Type_Images__Graphic_.GUID).Rows
            If objDRC_Image.Count > 0 Then
                Button_AddImageNew.Enabled = False
                Button_DelPhoto.Enabled = True
                objSemItem_Image = New clsSemItem
                objSemItem_Image.GUID = objDRC_Image(0).Item("GUID_Token_Right")
                objSemItem_Image.Name = objDRC_Image(0).Item("Name_Token_Right")
                objSemItem_Image.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                objSemItem_Image.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objUserControl_ImageEdit.initialize(objSemItem_Image)
                objUserControl_ImageEdit.Enabled = True
            Else
                objUserControl_ImageEdit.initialize(objSemItem_Image)
            End If

        End If
        


        boolPhoto = True
    End Sub
    Private Sub clear_Controls()
        TextBox_eTin.Enabled = False
        TextBox_Nachname.Enabled = False
        TextBox_Vorname.Enabled = False
        TextBox_Sozialversicherungsnummer.Enabled = False
        TextBox_Identifikationsnummer.Enabled = False
        TextBox_Steuernummer.Enabled = False
        MaskedTextBox_Geburtsdatum.Enabled = False
        MaskedTextBox_Todesdatum.Enabled = False
        ComboBox_Familienstand.Enabled = False
        ComboBox_Geschlecht.Enabled = False
        Button_AddImageExisting.Enabled = False
        Button_AddImageNew.Enabled = False

        TextBox_eTin.Text = ""
        TextBox_Nachname.Text = ""
        TextBox_Vorname.Text = ""
        TextBox_Sozialversicherungsnummer.Text = ""
        MaskedTextBox_Geburtsdatum.Text = ""
        MaskedTextBox_Geburtsdatum.Text = ""
        ComboBox_Familienstand.SelectedItem = objLocalConfig.Globals.LogState_Nothing
        ComboBox_Geschlecht.SelectedItem = objLocalConfig.Globals.LogState_Nothing

        Button_Geburtsdatum.Enabled = False
        Button_Geburtsdatum.Enabled = False
        Button_eTin.Enabled = False
        Button_INr.Enabled = False
        Button_Sozialversicherungsnummer.Enabled = False
        Button_Steuernummer.Enabled = False

        Button_Del_eTin.Enabled = False
        Button_Del_Geburtsdatum.Enabled = False
        Button_Del_Geburtsdatum.Enabled = False
        Button_Del_INr.Enabled = False
        Button_Del_Sozialversicherungsnummer.Enabled = False
        Button_Del_Steuernummer.Enabled = False

        objUserControl_ImageEdit.Enabled = False

        objSemItem_PersonalData = Nothing

        boolFamilienstand = False
        boolGeburtsdatum = False
        boolTodesdatum = False
        boolETin = False
        boolGeschlecht = False
        boolNachname = False
        boolSozialversicherungsnummer = False
        boolVorname = False
        boolIdNr = False
        boolSteuernummer = False
        boolPhoto = False
    End Sub


    Private Sub get_BaseData_Geschlecht()
        semtblA_Token.Fill_Token_TypeChilds(semtblT_Geschlecht, objLocalConfig.SemItem_Type_Geschlecht.GUID)
        semtblT_Geschlecht.Rows.Add(objLocalConfig.Globals.LogState_Nothing.GUID, _
                                    "", _
                                    objLocalConfig.Globals.LogState_Nothing.GUID_Parent)

    End Sub

    Private Sub get_BaseData_Familienstand()
        semtblA_Token.Fill_Token_TypeChilds(semtblT_Familienstand, objLocalConfig.SemItem_Type_Familienstand.GUID)
        semtblT_Familienstand.Rows.Add(objLocalConfig.Globals.LogState_Nothing.GUID, _
                                    "", _
                                    objLocalConfig.Globals.LogState_Nothing.GUID_Parent)
    End Sub

    Private Sub get_BaseData_personalData()
        Dim objDRC_PersonalData As DataRowCollection
        objDRC_PersonalData = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_Partner.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                            objLocalConfig.SemItem_Type_nat_rliche_Person.GUID).Rows
        If objDRC_PersonalData.Count > 0 Then
            objSemItem_PersonalData = New clsSemItem
            objSemItem_PersonalData.GUID = objDRC_PersonalData(0).Item("GUID_Token_Left")
            objSemItem_PersonalData.Name = objDRC_PersonalData(0).Item("Name_Token_Left")
            objSemItem_PersonalData.GUID_Parent = objLocalConfig.SemItem_Type_nat_rliche_Person.GUID
            objSemItem_PersonalData.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        Else
            objSemItem_PersonalData = Nothing
        End If
    End Sub
    Private Sub get_Data_Vorname()
        objDRC_Voranme = funcA_TokenAttribute_Named_By_GUIDTokenT.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_PersonalData.GUID, _
                                                                                                         objLocalConfig.SemItem_Attribute_Vorname.GUID).Rows
        boolVorname = True
    End Sub


    Private Sub get_Data_Nachname()
        objDRC_Nachname = funcA_TokenAttribute_Named_By_GUIDTokenT.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_PersonalData.GUID, _
                                                                                                          objLocalConfig.SemItem_Attribute_Nachname.GUID).Rows
        boolNachname = True
    End Sub

    Private Sub get_Data_Geschlecht()
        objDRC_Geschlecht = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                          objLocalConfig.SemItem_Type_Geschlecht.GUID).Rows
        boolGeschlecht = True
    End Sub

    

    Private Sub get_Data_Familienstand()
        objDRC_Familienstand = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                             objLocalConfig.SemItem_Type_Familienstand.GUID).Rows
        boolFamilienstand = True
    End Sub

    Private Sub get_Data_Geburtsdatum()
        objDRC_Geburtsdatum = funcA_TokenAttribute_Named_By_GUIDTokenT.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_PersonalData.GUID, _
                                                                                                              objLocalConfig.SemItem_Attribute_Geburtsdatum.GUID).Rows
        boolGeburtsdatum = True
    End Sub

    Private Sub get_Data_Todesdatum()
        objDRC_Todesdatum = funcA_TokenAttribute_Named_By_GUIDTokenT.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_PersonalData.GUID, _
                                                                                                              objLocalConfig.SemItem_Attribute_Todesdatum.GUID).Rows
        boolTodesdatum = True
    End Sub

    Private Sub get_Data_Sozialversicherungsnummer()
        objDRC_Sozialversicherungsnummer = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                                         objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                                         objLocalConfig.SemItem_Type_Sozialversicherungsnummer.GUID).Rows
        boolSozialversicherungsnummer = True
    End Sub

    Private Sub get_Data_eTin()
        objDRC_eTin = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                    objLocalConfig.SemItem_Type_eTin.GUID).Rows
        boolETin = True
    End Sub

    Private Sub get_Data_IdentifikationsNummer()
        objDRC_Identifikationsnummer = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                                     objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                                     objLocalConfig.SemItem_Type_Identifkationsnummer__IdNr_.GUID).Rows
        boolIdNr = True
    End Sub

    Private Sub get_Data_Steuernummer()
        objDRC_Steuernummer = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_PersonalData.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                            objLocalConfig.SemItem_Type_Steuernummer.GUID).Rows
        boolSteuernummer = True
    End Sub
    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDTokenT.Connection = objLocalConfig.Connection_DB

        objTransaction_PersonalData = New clsTransaction_PersonalData(objLocalConfig)

    End Sub

    Private Sub Timer_Data_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Data.Tick
        Dim boolStop As Boolean
        Dim intProgress As Integer

        boolStop = True
        intProgress = 0
        If boolVorname = True Then
            If Not objDRC_Voranme Is Nothing Then
                If objDRC_Voranme.Count > 0 Then
                    TextBox_Vorname.Text = objDRC_Voranme(0).Item("Val_VARCHAR255")
                End If
            End If
            
            TextBox_Vorname.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolNachname = True Then
            If Not objDRC_Nachname Is Nothing Then
                If objDRC_Nachname.Count > 0 Then
                    TextBox_Nachname.Text = objDRC_Nachname(0).Item("Val_VARCHAR255")
                End If
            End If
            
            TextBox_Nachname.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolGeschlecht = True Then
            If Not objDRC_Geschlecht Is Nothing Then
                If objDRC_Geschlecht.Count > 0 Then
                    ComboBox_Geschlecht.SelectedValue = objDRC_Geschlecht(0).Item("GUID_Token_Right")
                Else
                    ComboBox_Geschlecht.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID
                End If
                ComboBox_Geschlecht.Enabled = True
                intProgress = intProgress + 1
            End If
            
        Else
            boolStop = False
        End If

        If boolFamilienstand = True Then
            If Not objDRC_Familienstand Is Nothing Then
                If objDRC_Familienstand.Count > 0 Then
                    ComboBox_Familienstand.SelectedValue = objDRC_Familienstand(0).Item("GUID_Token_Right")
                Else
                    ComboBox_Familienstand.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID
                End If
            End If
            
            ComboBox_Familienstand.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolGeburtsdatum = True Then
            If Not objDRC_Geburtsdatum Is Nothing Then
                If objDRC_Geburtsdatum.Count > 0 Then
                    MaskedTextBox_Geburtsdatum.Text = objDRC_Geburtsdatum(0).Item("Val_DATETIME")
                    Button_Del_Geburtsdatum.Enabled = True
                End If
            End If
            
            Button_Geburtsdatum.Enabled = True
            intProgress = intProgress + 1
        End If

        If boolTodesdatum = True Then
            If Not objDRC_Todesdatum Is Nothing Then
                If objDRC_Todesdatum.Count > 0 Then
                    MaskedTextBox_Todesdatum.Text = objDRC_Todesdatum(0).Item("Val_Datetime")
                    Button_Del_Todesdatum.Enabled = True
                End If
            End If
            Button_Todesdatum.Enabled = True
            intProgress = intProgress + 1
        End If

        If boolSozialversicherungsnummer = True Then
            If Not objDRC_Sozialversicherungsnummer Is Nothing Then
                If objDRC_Sozialversicherungsnummer.Count > 0 Then
                    TextBox_Sozialversicherungsnummer.Text = objDRC_Sozialversicherungsnummer(0).Item("Name_Token_Right")
                    Button_Del_Sozialversicherungsnummer.Enabled = True
                End If
            End If

            Button_Sozialversicherungsnummer.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolETin = True Then
            If Not objDRC_eTin Is Nothing Then
                If objDRC_eTin.Count > 0 Then
                    TextBox_eTin.Text = objDRC_eTin(0).Item("Name_Token_Right")
                    Button_Del_eTin.Enabled = True
                End If
            End If
            
            Button_eTin.Enabled = True
            intProgress = intProgress + 1
        Else
            boolStop = False
        End If

        If boolIdNr = True Then
            If Not objDRC_Identifikationsnummer Is Nothing Then
                If objDRC_Identifikationsnummer.Count > 0 Then
                    TextBox_Identifikationsnummer.Text = objDRC_Identifikationsnummer(0).Item("Name_Token_Right")
                    Button_Del_INr.Enabled = True
                End If
            End If
            
            Button_INr.Enabled = True
            intProgress = intProgress + 1
        End If

        If boolSteuernummer = True Then
            If Not objDRC_Steuernummer Is Nothing Then
                If objDRC_Steuernummer.Count > 0 Then
                    TextBox_Steuernummer.Text = objDRC_Steuernummer(0).Item("Name_Token_Right")
                    Button_Del_Steuernummer.Enabled = True
                End If
            End If

            Button_Steuernummer.Enabled = True
            intProgress = intProgress + 1
        End If

        If boolStop = True Then
            ToolStripProgressBar_Data.Visible = False
            ToolStripProgressBar_Data.Value = 0
            Timer_Data.Stop()
        Else
            ToolStripProgressBar_Data.Visible = True
            ToolStripProgressBar_Data.Value = intProgress
        End If
    End Sub

    Private Sub TextBox_Vorname_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Vorname.DoubleClick
        objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Attribute_Vorname.Name, objLocalConfig.Globals, TextBox_Vorname.Text)
        objDLG_Attribute_VARCHAR255.ShowDialog(Me)
        If objDLG_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
            TextBox_Vorname.Text = objDLG_Attribute_VARCHAR255.Value1
        End If
    End Sub

    Private Sub TextBox_Vorname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Vorname.TextChanged
        Timer_Vorname.Stop()
        If TextBox_Vorname.Enabled = True Then
            Timer_Vorname.Start()
        End If

    End Sub

    Private Sub TextBox_Nachname_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Nachname.DoubleClick
        objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Attribute_Nachname.Name, objLocalConfig.Globals, TextBox_Nachname.Text)
        objDLG_Attribute_VARCHAR255.ShowDialog(Me)
        If objDLG_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
            TextBox_Nachname.Text = objDLG_Attribute_VARCHAR255.Value1
        End If
    End Sub

    Private Sub TextBox_Nachname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Nachname.TextChanged
        Timer_Nachname.Stop()
        If TextBox_Nachname.Enabled = True Then
            Timer_Nachname.Start()
        End If


    End Sub

    Private Sub Button_Geburtsdatum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Geburtsdatum.Click
        Dim objSemItem_Result As clsSemItem
        Dim dateParse As Date

        If Date.TryParse(MaskedTextBox_Geburtsdatum.Text, dateParse) = True Then
            objFrm_DateTimePicker.Date_Selected_Start = dateParse

        Else
            objFrm_DateTimePicker.Date_Selected_Start = Now

        End If
        
        

        objFrm_DateTimePicker.ShowDialog(Me)
        If objFrm_DateTimePicker.DialogResult = DialogResult.OK Then
            If objFrm_DateTimePicker.Date_Selected_Start = objFrm_DateTimePicker.Date_Selected_End Then
                objSemItem_Result = objTransaction_PersonalData.save_005_Geburtsdatum(objFrm_DateTimePicker.Date_Selected_Start, objSemItem_PersonalData)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    MaskedTextBox_Geburtsdatum.Text = objFrm_DateTimePicker.Date_Selected_Start.ToString
                    Button_Del_Geburtsdatum.Enabled = True
                End If
            Else
                MsgBox("Bitte keine Ranges auswählen!", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Private Sub Timer_Vorname_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Vorname.Tick
        Timer_Vorname.Stop()
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = create_PersonalData()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            If Not TextBox_Vorname.Text = "" Then

                objSemItem_Result = objTransaction_PersonalData.save_002_Vorname(TextBox_Vorname.Text, _
                                                                                 objSemItem_PersonalData, _
                                                                                 Nothing)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Der Vorname konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    get_Data_Vorname()
                    TextBox_Vorname.Enabled = False
                    If objDRC_Voranme.Count > 0 Then
                        TextBox_Vorname.Text = objDRC_Voranme(0).Item("Val_VARCHAR255")
                    Else
                        TextBox_Vorname.Text = ""
                    End If
                    TextBox_Vorname.Enabled = True
                End If
            Else
                objSemItem_Result = objTransaction_PersonalData.del_002_Vorname(Nothing, objSemItem_PersonalData)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Der Vorname konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    get_Data_Vorname()
                    TextBox_Vorname.Enabled = False
                    If objDRC_Voranme.Count > 0 Then
                        TextBox_Vorname.Text = objDRC_Voranme(0).Item("Val_VARCHAR255")
                    Else
                        TextBox_Vorname.Text = ""
                    End If
                    TextBox_Vorname.Enabled = True
                End If
            End If
        Else
            MsgBox("Der Vorname kann nicht gespeichert werden!", MsgBoxStyle.Critical)
            TextBox_Vorname.Enabled = False
            TextBox_Vorname.Text = ""

        End If

        
    End Sub

    Private Function create_PersonalData() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        get_BaseData_personalData()

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objSemItem_PersonalData Is Nothing Then
            objSemItem_PersonalData = New clsSemItem
            objSemItem_PersonalData.GUID = Guid.NewGuid
            objSemItem_PersonalData.Name = objSemItem_Partner.Name
            objSemItem_PersonalData.GUID_Parent = objLocalConfig.SemItem_Type_nat_rliche_Person.GUID
            objSemItem_PersonalData.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


            objSemItem_Result = objTransaction_PersonalData.save_001_personalData(objSemItem_PersonalData)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_PersonalData.save_010_PersonalData_To_Partner(objSemItem_Partner, objSemItem_PersonalData)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    objTransaction_PersonalData.del_010_PersonalData_To_Partner(objSemItem_Partner)
                End If
            End If
        End If
        Return objSemItem_Result
    End Function

    Private Sub Timer_Nachname_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Nachname.Tick
        Timer_Nachname.Stop()
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = create_PersonalData()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            If Not TextBox_Nachname.Text = "" Then

                objSemItem_Result = objTransaction_PersonalData.save_002_Nachname(TextBox_Nachname.Text, _
                                                                                 objSemItem_PersonalData, _
                                                                                 Nothing)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Der Nachname konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    get_Data_Nachname()
                    TextBox_Nachname.Enabled = False
                    If objDRC_Voranme.Count > 0 Then
                        TextBox_Nachname.Text = objDRC_Voranme(0).Item("Val_VARCHAR255")
                    Else
                        TextBox_Nachname.Text = ""
                    End If
                    TextBox_Nachname.Enabled = True
                End If
            Else
                objSemItem_Result = objTransaction_PersonalData.del_002_Nachname(Nothing, objSemItem_PersonalData)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Der Nachname konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    get_Data_Nachname()
                    TextBox_Nachname.Enabled = False
                    If objDRC_Voranme.Count > 0 Then
                        TextBox_Nachname.Text = objDRC_Voranme(0).Item("Val_VARCHAR255")
                    Else
                        TextBox_Nachname.Text = ""
                    End If
                    TextBox_Nachname.Enabled = True
                End If
            End If
        Else
            MsgBox("Der Nachname kann nicht gespeichert werden!", MsgBoxStyle.Critical)
            TextBox_Nachname.Enabled = False
            TextBox_Nachname.Text = ""

        End If
    End Sub

    Private Sub ComboBox_Geschlecht_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Geschlecht.SelectedIndexChanged
        Dim objDR_Geschlecht As DataRowView
        Dim objSemItem_Geschlecht As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        If ComboBox_Geschlecht.Enabled = True Then
            objSemItem_Result = create_PersonalData()
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objDR_Geschlecht = ComboBox_Geschlecht.SelectedItem
                If Not objDR_Geschlecht.Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then
                    objSemItem_Geschlecht.GUID = objDR_Geschlecht.Item("GUID_Token")
                    objSemItem_Geschlecht.Name = objDR_Geschlecht.Item("Name_Token")
                    objSemItem_Geschlecht.GUID_Parent = objLocalConfig.SemItem_Type_Geschlecht.GUID
                    objSemItem_Geschlecht.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objSemItem_Result = objTransaction_PersonalData.save_003_PersonalData_To_Geschlecht(objSemItem_Geschlecht, objSemItem_PersonalData)
                    
                Else
                    objSemItem_Result = objTransaction_PersonalData.del_003_PersonalData_To_Geschlecht(objSemItem_PersonalData)
                End If
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Das Geschlecht konnte nicht zugeordnet werden;-)", MsgBoxStyle.Exclamation)
                    ComboBox_Geschlecht.Enabled = False
                End If
            Else
                MsgBox("Das Geschlecht konnte nicht zugeordnet werden;-)", MsgBoxStyle.Exclamation)
                ComboBox_Geschlecht.Enabled = False
            End If
            
        End If
    End Sub

    Private Sub ComboBox_Familienstand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Familienstand.SelectedIndexChanged
        Dim objDR_Familienstand As DataRowView
        Dim objSemItem_Familienstand As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        If ComboBox_Familienstand.Enabled = True Then
            objSemItem_Result = create_PersonalData()
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objDR_Familienstand = ComboBox_Familienstand.SelectedItem
                If Not objDR_Familienstand.Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then
                    objSemItem_Familienstand.GUID = objDR_Familienstand.Item("GUID_Token")
                    objSemItem_Familienstand.Name = objDR_Familienstand.Item("Name_Token")
                    objSemItem_Familienstand.GUID_Parent = objLocalConfig.SemItem_Type_Familienstand.GUID
                    objSemItem_Familienstand.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objSemItem_Result = objTransaction_PersonalData.save_004_PersonalData_To_Familienstand(objSemItem_Familienstand, objSemItem_PersonalData)

                Else
                    objSemItem_Result = objTransaction_PersonalData.del_004_PersonalData_To_Familienstand(objSemItem_PersonalData)
                End If
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Das Familienstand konnte nicht zugeordnet werden;-)", MsgBoxStyle.Exclamation)
                    ComboBox_Familienstand.Enabled = False
                End If
            Else
                MsgBox("Das Familienstand konnte nicht zugeordnet werden;-)", MsgBoxStyle.Exclamation)
                ComboBox_Familienstand.Enabled = False
            End If

        End If
    End Sub

    Private Sub Button_Sozialversicherungsnummer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Sozialversicherungsnummer.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Sozialversicherungsnummer As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = create_PersonalData()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Sozialversicherungsnummer, objLocalConfig.Globals)
            objFrmSemManager.Applyabale = True
            objFrmSemManager.ShowDialog(Me)
            If objFrmSemManager.DialogResult = DialogResult.OK Then
                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                    If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                        objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                        If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Sozialversicherungsnummer.GUID Then
                            objSemItem_Sozialversicherungsnummer.GUID = objDRV_Selected.Item("GUID_Token")
                            objSemItem_Sozialversicherungsnummer.Name = objDRV_Selected.Item("Name_Token")
                            objSemItem_Sozialversicherungsnummer.GUID_Parent = objLocalConfig.SemItem_Type_Sozialversicherungsnummer.GUID
                            objSemItem_Sozialversicherungsnummer.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Result = objTransaction_PersonalData.save_006_PersonalData_To_Sozialversicherungsnummer(objSemItem_Sozialversicherungsnummer, _
                                                                                                                             objSemItem_PersonalData)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                TextBox_Sozialversicherungsnummer.Text = objSemItem_Sozialversicherungsnummer.Name
                                Button_Del_Sozialversicherungsnummer.Enabled = True
                            Else

                                MsgBox("Die Sozialversicherungsnummer kann nicht zugeordnet werden!", MsgBoxStyle.Exclamation)
                                Button_Sozialversicherungsnummer.Enabled = False
                            End If
                        Else
                            MsgBox("Bitte nur Token vom Typ " & objLocalConfig.SemItem_Type_Sozialversicherungsnummer.Name & " auswählen!", MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("Bitte nur eine " & objLocalConfig.SemItem_Type_Sozialversicherungsnummer.Name & " auswählen!", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Bitte eine " & objLocalConfig.SemItem_Type_Sozialversicherungsnummer.Name & " auswählen!", MsgBoxStyle.Information)
                End If
            End If
        Else
            MsgBox("Die Sozialversicherungsnummer kann nicht zugeordnet werden!", MsgBoxStyle.Exclamation)
            Button_Sozialversicherungsnummer.Enabled = False
        End If

    End Sub

    Private Sub Button_eTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_eTin.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_eTin As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = create_PersonalData()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_eTin, objLocalConfig.Globals)
            objFrmSemManager.Applyabale = True
            objFrmSemManager.ShowDialog(Me)
            If objFrmSemManager.DialogResult = DialogResult.OK Then
                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                    If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                        objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                        If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_eTin.GUID Then
                            objSemItem_eTin.GUID = objDRV_Selected.Item("GUID_Token")
                            objSemItem_eTin.Name = objDRV_Selected.Item("Name_Token")
                            objSemItem_eTin.GUID_Parent = objLocalConfig.SemItem_Type_eTin.GUID
                            objSemItem_eTin.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Result = objTransaction_PersonalData.save_007_PersonalData_To_eTin(objSemItem_eTin, _
                                                                                                          objSemItem_PersonalData)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                TextBox_eTin.Text = objSemItem_eTin.Name
                                Button_Del_eTin.Enabled = True
                            Else

                                MsgBox("Die eTin kann nicht zugeordnet werden!", MsgBoxStyle.Exclamation)
                                Button_eTin.Enabled = False
                            End If
                        Else
                            MsgBox("Bitte nur Token vom Typ " & objLocalConfig.SemItem_Type_eTin.Name & " auswählen!", MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("Bitte nur eine " & objLocalConfig.SemItem_Type_eTin.Name & " auswählen!", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Bitte eine " & objLocalConfig.SemItem_Type_eTin.Name & " auswählen!", MsgBoxStyle.Information)
                End If
            End If
        Else
            MsgBox("Die eTin kann nicht zugeordnet werden!", MsgBoxStyle.Exclamation)
            Button_eTin.Enabled = False
        End If
    End Sub

    Private Sub Button_INr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_INr.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Identifkationsnummer__IdNr_ As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = create_PersonalData()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Identifkationsnummer__IdNr_, objLocalConfig.Globals)
            objFrmSemManager.Applyabale = True
            objFrmSemManager.ShowDialog(Me)
            If objFrmSemManager.DialogResult = DialogResult.OK Then
                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                    If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                        objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                        If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Identifkationsnummer__IdNr_.GUID Then
                            objSemItem_Identifkationsnummer__IdNr_.GUID = objDRV_Selected.Item("GUID_Token")
                            objSemItem_Identifkationsnummer__IdNr_.Name = objDRV_Selected.Item("Name_Token")
                            objSemItem_Identifkationsnummer__IdNr_.GUID_Parent = objLocalConfig.SemItem_Type_Identifkationsnummer__IdNr_.GUID
                            objSemItem_Identifkationsnummer__IdNr_.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Result = objTransaction_PersonalData.save_008_PersonalData_To_Identifkationsnummer__IdNr_(objSemItem_Identifkationsnummer__IdNr_, _
                                                                                                          objSemItem_PersonalData)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                TextBox_Identifikationsnummer.Text = objSemItem_Identifkationsnummer__IdNr_.Name
                                Button_Del_INr.Enabled = True
                            Else
                                MsgBox("Die Identifkationsnummer__IdNr_ kann nicht zugeordnet werden!", MsgBoxStyle.Exclamation)
                                Button_INr.Enabled = False
                            End If
                        Else
                            MsgBox("Bitte nur Token vom Typ " & objLocalConfig.SemItem_Type_Identifkationsnummer__IdNr_.Name & " auswählen!", MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("Bitte nur eine " & objLocalConfig.SemItem_Type_Identifkationsnummer__IdNr_.Name & " auswählen!", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Bitte eine " & objLocalConfig.SemItem_Type_Identifkationsnummer__IdNr_.Name & " auswählen!", MsgBoxStyle.Information)
                End If
            End If
        Else
            MsgBox("Die Identifkationsnummer__IdNr_ kann nicht zugeordnet werden!", MsgBoxStyle.Exclamation)
            Button_INr.Enabled = False
        End If
    End Sub

    Private Sub Button_Steuernummer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Steuernummer.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Steuernummer As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = create_PersonalData()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Steuernummer, objLocalConfig.Globals)
            objFrmSemManager.Applyabale = True
            objFrmSemManager.ShowDialog(Me)
            If objFrmSemManager.DialogResult = DialogResult.OK Then
                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                    If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                        objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                        If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Steuernummer.GUID Then
                            objSemItem_Steuernummer.GUID = objDRV_Selected.Item("GUID_Token")
                            objSemItem_Steuernummer.Name = objDRV_Selected.Item("Name_Token")
                            objSemItem_Steuernummer.GUID_Parent = objLocalConfig.SemItem_Type_Steuernummer.GUID
                            objSemItem_Steuernummer.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Result = objTransaction_PersonalData.save_009_PersonalData_To_Steuernummer(objSemItem_Steuernummer, _
                                                                                                          objSemItem_PersonalData)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                TextBox_Steuernummer.Text = objSemItem_Steuernummer.Name
                                Button_Del_Steuernummer.Enabled = True
                            Else

                                MsgBox("Die Steuernummer kann nicht zugeordnet werden!", MsgBoxStyle.Exclamation)
                                Button_Steuernummer.Enabled = False
                            End If
                        Else
                            MsgBox("Bitte nur Token vom Typ " & objLocalConfig.SemItem_Type_Steuernummer.Name & " auswählen!", MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("Bitte nur eine " & objLocalConfig.SemItem_Type_Steuernummer.Name & " auswählen!", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Bitte eine " & objLocalConfig.SemItem_Type_Steuernummer.Name & " auswählen!", MsgBoxStyle.Information)
                End If
            End If
        Else
            MsgBox("Die Steuernummer kann nicht zugeordnet werden!", MsgBoxStyle.Exclamation)
            Button_Steuernummer.Enabled = False
        End If
    End Sub


    Private Sub Button_Del_Sozialversicherungsnummer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del_Sozialversicherungsnummer.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = create_PersonalData()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_PersonalData.del_006_PersonalData_To_Sozialversicherungsnummer(objSemItem_PersonalData)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_Sozialversicherungsnummer.Text = ""
                Button_Del_Sozialversicherungsnummer.Enabled = False
            Else
                MsgBox("Die Sozialversicherungsnummer kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                Button_Sozialversicherungsnummer.Enabled = False
                Button_Del_Sozialversicherungsnummer.Enabled = False
            End If
        Else
            MsgBox("Die Sozialversicherungsnummer kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
            Button_Sozialversicherungsnummer.Enabled = False
            Button_Del_Sozialversicherungsnummer.Enabled = False
        End If
    End Sub

    Private Sub Button_Del_eTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del_eTin.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = create_PersonalData()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_PersonalData.del_007_PersonalData_To_eTin(objSemItem_PersonalData)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_eTin.Text = ""
                Button_Del_eTin.Enabled = False
            Else
                MsgBox("Die eTin kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                Button_eTin.Enabled = False
                Button_Del_eTin.Enabled = False
            End If
        Else
            MsgBox("Die eTin kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
            Button_eTin.Enabled = False
            Button_Del_eTin.Enabled = False
        End If
    End Sub

    Private Sub Button_Del_INr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del_INr.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = create_PersonalData()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_PersonalData.del_008_PersonalData_To_Identifkationsnummer__IdNr_(objSemItem_PersonalData)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_Identifikationsnummer.Text = ""
                Button_Del_INr.Enabled = False
            Else
                MsgBox("Die INr kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                Button_INr.Enabled = False
                Button_Del_INr.Enabled = False
            End If
        Else
            MsgBox("Die INr kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
            Button_INr.Enabled = False
            Button_Del_INr.Enabled = False
        End If
    End Sub

    Private Sub Button_Del_Steuernummer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del_Steuernummer.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = create_PersonalData()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_PersonalData.del_009_PersonalData_To_Steuernummer(objSemItem_PersonalData)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                TextBox_Steuernummer.Text = ""
                Button_Del_Steuernummer.Enabled = False
            Else
                MsgBox("Die INr kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                Button_Steuernummer.Enabled = False
                Button_Del_Steuernummer.Enabled = False
            End If
        Else
            MsgBox("Die INr kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
            Button_Steuernummer.Enabled = False
            Button_Del_Steuernummer.Enabled = False
        End If
    End Sub

    Private Sub Button_Del_Geburtsdatum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del_Geburtsdatum.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = create_PersonalData()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_PersonalData.del_005_Geburtsdatum(Nothing, objSemItem_PersonalData)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                MaskedTextBox_Geburtsdatum.Text = ""
                Button_Del_Geburtsdatum.Enabled = False
            Else
                MsgBox("Die INr kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                Button_Geburtsdatum.Enabled = False
                Button_Del_Geburtsdatum.Enabled = False
            End If
        Else
            MsgBox("Die INr kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
            Button_Geburtsdatum.Enabled = False
            Button_Del_Geburtsdatum.Enabled = False
        End If
    End Sub

    Private Sub Button_Todesdatum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Todesdatum.Click
        Dim objSemItem_Result As clsSemItem
        Dim dateParse As Date

        If Date.TryParse(MaskedTextBox_Todesdatum.Text, dateParse) = True Then
            objFrm_DateTimePicker.Date_Selected_Start = dateParse

        Else
            objFrm_DateTimePicker.Date_Selected_Start = Now

        End If



        objFrm_DateTimePicker.ShowDialog(Me)
        If objFrm_DateTimePicker.DialogResult = DialogResult.OK Then
            If objFrm_DateTimePicker.Date_Selected_Start = objFrm_DateTimePicker.Date_Selected_End Then
                objSemItem_Result = objTransaction_PersonalData.save_011_Todesdatum(objFrm_DateTimePicker.Date_Selected_Start, objSemItem_PersonalData)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    MaskedTextBox_Todesdatum.Text = objFrm_DateTimePicker.Date_Selected_Start.ToString
                    Button_Del_Todesdatum.Enabled = True
                End If
            Else
                MsgBox("Bitte keine Ranges auswählen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub Button_Del_Todesdatum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Del_Todesdatum.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = create_PersonalData()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_PersonalData.del_011_Todesdatum(Nothing, objSemItem_PersonalData)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                MaskedTextBox_Todesdatum.Text = ""
                Button_Del_Todesdatum.Enabled = False
            Else
                MsgBox("Die INr kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                Button_Todesdatum.Enabled = False
                Button_Del_Todesdatum.Enabled = False
            End If
        Else
            MsgBox("Die INr kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
            Button_Todesdatum.Enabled = False
            Button_Del_Todesdatum.Enabled = False
        End If
    End Sub

    Private Sub Button_AddImageNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AddImageNew.Click
        Dim objSemItem_Result As clsSemItem
        objSemItem_Image = New clsSemItem
        objSemItem_Image.GUID = Guid.NewGuid
        objSemItem_Image.Name = objSemItem_Partner.Name
        objSemItem_Image.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
        objSemItem_Image.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objSemItem_Result = objTransaction_PersonalData.save_012_Image(objSemItem_Image)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_PersonalData.save_013_PersonalData_To_Image(objSemItem_PersonalData, _
                                                                                           objSemItem_Image)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Das Image konnte nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                objTransaction_PersonalData.del_012_Image(objSemItem_Image)
                objUserControl_ImageEdit.Enabled = False
                objSemItem_Image = Nothing
            End If
        Else
            MsgBox("Das Image konnte nicht erzeugt werden!", MsgBoxStyle.Exclamation)
            objUserControl_ImageEdit.Enabled = False
            objSemItem_Image = Nothing
        End If

        objUserControl_ImageEdit.initialize(objSemItem_Image)
    End Sub
End Class
