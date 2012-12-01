Imports Sem_Manager
Imports Version_Module
Public Class frmNewDevelopment

    Private funcA_SoftwareDevelopment_roots_and_L1_with_State As New ds_PluginTableAdapters.func_SoftwareDevelopment_roots_and_L1_with_StateTableAdapter
    Private func_SoftwareDevelopment_roots_and_L1_with_State As New ds_Plugin.func_SoftwareDevelopment_roots_and_L1_with_StateDataTable
    Private funcA_subordinated_L1_L2_SoftwareDevelopment_with_State As New ds_PluginTableAdapters.func_subordinated_L1_L2_SoftwareDevelopment_with_StateTableAdapter
    Private func_subordinated_L1_L2_SoftwareDevelopment_with_State As New ds_Plugin.func_subordinated_L1_L2_SoftwareDevelopment_with_StateDataTable

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_Token_Attribute_Int As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_IntTableAdapter
    Private semprocA_DBWork_Del_Token_Attribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objLogWork_Local As clsLogWork_Local

    Private WithEvents objUserControl_Version As UserControl_Version
    Private WithEvents objUserControl_StdLanguage As UserControl_SemItemList
    Private WithEvents objUserControl_PLanguage As UserControl_SemItemList

    Private objSemItem_Development_Parent As clsSemItem
    Private objSemItem_Development As New clsSemItem

    Private Sub changed_Version_Major() Handles objUserControl_Version.changed_Major
        test_OK()
    End Sub
    Private Sub changed_Version_Minor() Handles objUserControl_Version.changed_Minor
        test_OK()
    End Sub

    Private Sub changed_Version_Build() Handles objUserControl_Version.changed_Build
        test_OK()
    End Sub

    Private Sub changed_Version_Revision() Handles objUserControl_Version.changed_Revision
        test_OK()
    End Sub
    
    Private Sub test_OK()
        Dim boolEnable As Boolean = True
        Dim objDRs_Dev() As DataRow

        If objUserControl_PLanguage.DataGridViewRowCollection_Selected.Count = 1 Then
            Label_PLanguage_OK.BackColor = Color.Green
            ToolTip_PLanguage.SetToolTip(Label_PLanguage_OK, "OK!")
            ToolTip_PLanguage.Active = True
        Else
            ToolTip_PLanguage.SetToolTip(Label_PLanguage_OK, "Bitte nur eine Programmiersprache auswählen!")
            ToolTip_PLanguage.Active = True
            Label_PLanguage_OK.BackColor = Color.Red
            boolEnable = False
        End If

        If objUserControl_StdLanguage.DataGridViewRowCollection_Selected.Count = 1 Then
            ToolTip_StdLanguage.SetToolTip(Label_StdLanguage_OK, "OK!")
            ToolTip_StdLanguage.Active = True
            Label_StdLanguage_OK.BackColor = Color.Green
        Else
            ToolTip_StdLanguage.SetToolTip(Label_StdLanguage_OK, "Bitte nur eine Standard-Sprache auswählen!")
            ToolTip_StdLanguage.Active = True
            Label_StdLanguage_OK.BackColor = Color.Red
            boolEnable = False
        End If
        If TextBox_Name.Text.Length > 0 Then

            If objSemItem_Development_Parent Is Nothing Then
                funcA_SoftwareDevelopment_roots_and_L1_with_State.Fill(func_SoftwareDevelopment_roots_and_L1_with_State, _
                                                                       objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                       objLocalConfig.SemItem_Type_LogState.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_isSubordinated.GUID)
                objDRs_Dev = func_SoftwareDevelopment_roots_and_L1_with_State.Select("Name_Development='" & TextBox_Name.Text & "'")
                If objDRs_Dev.Length > 0 Then
                    boolEnable = False
                    ToolTip_Name.SetToolTip(Label_Name_OK, "Es gibt bereits eine Softwareentwicklung mit dem Namen auf dieser Ebene!")
                    ToolTip_Name.Active = True
                    Label_Name_OK.BackColor = Color.Red
                Else
                    ToolTip_Name.SetToolTip(Label_Name_OK, "OK!")
                    ToolTip_Name.Active = True
                    Label_Name_OK.BackColor = Color.Green
                End If

            Else
                funcA_subordinated_L1_L2_SoftwareDevelopment_with_State.Fill_By_GUIDDevelopment(func_subordinated_L1_L2_SoftwareDevelopment_with_State, _
                                                                             objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                             objLocalConfig.SemItem_Type_LogState.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                             objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                             objSemItem_Development_Parent.GUID)
                objDRs_Dev = func_subordinated_L1_L2_SoftwareDevelopment_with_State.Select("Name_Development_L2='" & TextBox_Name.Text & "'")
                If objDRs_Dev.Count > 0 Then
                    ToolTip_Name.SetToolTip(Label_Name_OK, "Es gibt bereits eine Softwareentwicklung mit dem Namen auf dieser Ebene!")
                    ToolTip_Name.Active = True
                    Label_Name_OK.BackColor = Color.Red
                    boolEnable = False
                Else
                    ToolTip_Name.SetToolTip(Label_Name_OK, "OK!")
                    ToolTip_Name.Active = True
                    Label_Name_OK.BackColor = Color.Green

                End If
            End If
        Else
            ToolTip_Name.SetToolTip(Label_Name_OK, "Der Name darf nicht leer sein!")
            ToolTip_Name.Active = True
            Label_Name_OK.BackColor = Color.Red
            boolEnable = False
        End If

        If objUserControl_Version.Major = 1 Or _
           objUserControl_Version.Minor = 1 Or _
           objUserControl_Version.Build = 1 Or _
           objUserControl_Version.Revision = 1 Then
            ToolTip_Version.SetToolTip(Label_Version_OK, "OK!")
            ToolTip_Version.Active = True
            Label_Version_OK.BackColor = Color.Green

        Else
            ToolTip_Version.SetToolTip(Label_Version_OK, "Mindestens eine Ziffer muss sich von 0 unterscheiden!")
            ToolTip_Version.Active = True
            boolEnable = False
            Label_Version_OK.BackColor = Color.Red

        End If

        If boolEnable = True Then
            ToolStripButton_OK.Enabled = True
        Else
            ToolStripButton_OK.Enabled = False
        End If
    End Sub

    Private Sub Changed_StdLanguage() Handles objUserControl_StdLanguage.Selection_Changed
        test_OK()

    End Sub

    Private Sub Changed_PLanguage() Handles objUserControl_PLanguage.Selection_Changed
        test_OK()
    End Sub

    Public Sub New(Optional ByVal SemItem_Development_Parent As clsSemItem = Nothing)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        set_DBConnection()
        objSemItem_Development_Parent = SemItem_Development_Parent
        objUserControl_PLanguage = New UserControl_SemItemList
        objUserControl_PLanguage.Dock = DockStyle.Fill
        objUserControl_PLanguage.initialize_Simple(objLocalConfig.SemItem_Type_ProgramingLanguage, objLocalConfig.Globals)

        objUserControl_StdLanguage = New UserControl_SemItemList
        objUserControl_StdLanguage.Dock = DockStyle.Fill
        objUserControl_StdLanguage.initialize_Simple(objLocalConfig.SemItem_Type_Language, objLocalConfig.Globals)

        objUserControl_Version = New UserControl_Version
        objUserControl_Version.VisibleInvisible_Apply(False)
        objUserControl_Version.VisibleInvisible_Cancel(False)
        objUserControl_Version.VisibleInvisible_Clear(False)
        objUserControl_Version.Dock = DockStyle.Fill
        objUserControl_Version.initialize()


        Panel_PLanguage.Controls.Clear()
        Panel_PLanguage.Controls.Add(objUserControl_PLanguage)

        Panel_StdLanguage.Controls.Clear()
        Panel_StdLanguage.Controls.Add(objUserControl_StdLanguage)

        Panel_Version.Controls.Clear()
        Panel_Version.Controls.Add(objUserControl_Version)

        test_OK()
    End Sub

    Private Sub set_DBConnection()
        funcA_SoftwareDevelopment_roots_and_L1_with_State.Connection = objLocalConfig.Connection_Plugin
        funcA_subordinated_L1_L2_SoftwareDevelopment_with_State.Connection = objLocalConfig.Connection_Plugin

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_Attribute_Int.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token_Attribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
    End Sub

    Private Sub TextBox_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Name.TextChanged
        Timer_Name.Stop()
        Timer_Name.Start()
    End Sub

    Private Sub Timer_Name_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Name.Tick
        test_OK()
        Timer_Name.Stop()
    End Sub

    Private Sub Label_Name_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_Name_OK.Click

    End Sub

   

   
    Private Sub ToolStripButton_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_OK.Click
        Dim objDRC_LogState As DataRowCollection
        'Dim objSemItem_Development.GUID As Guid
        Dim GUID_Version As Guid
        Dim GUID_TokenAttribute_Major As Guid
        Dim GUID_TokenAttribute_Minor As Guid
        Dim GUID_TokenAttribute_Build As Guid
        Dim GUID_TokenAttribute_Revision As Guid

        test_OK()
        If ToolStripButton_OK.Enabled = True Then
            objSemItem_Development = New clsSemItem
            objSemItem_Development.GUID = Guid.NewGuid
            objSemItem_Development.Name = TextBox_Name.Text
            objSemItem_Development.GUID_Parent = objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID
            objSemItem_Development.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Development.GUID, objSemItem_Development.Name, objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                GUID_Version = Guid.NewGuid
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(GUID_Version, _
                                                                     objUserControl_Version.Major & "." & _
                                                                     objUserControl_Version.Minor & "." & _
                                                                     objUserControl_Version.Build & "." & _
                                                                     objUserControl_Version.Revision, objLocalConfig.SemItem_Type_DevelopmentVersion.GUID, True).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    objDRC_LogState = semprocA_DBWork_Save_Token_Attribute_Int.GetData(GUID_Version, objLocalConfig.SemItem_Attribute_Major.GUID, Nothing, objUserControl_Version.Major, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        GUID_TokenAttribute_Major = objDRC_LogState(0).Item("GUID_TokenAttribute")
                        objDRC_LogState = semprocA_DBWork_Save_Token_Attribute_Int.GetData(GUID_Version, objLocalConfig.SemItem_Attribute_Minor.GUID, Nothing, objUserControl_Version.Minor, 0).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            GUID_TokenAttribute_Minor = objDRC_LogState(0).Item("GUID_TokenAttribute")
                            objDRC_LogState = semprocA_DBWork_Save_Token_Attribute_Int.GetData(GUID_Version, objLocalConfig.SemItem_Attribute_Build.GUID, Nothing, objUserControl_Version.Build, 0).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                GUID_TokenAttribute_Build = objDRC_LogState(0).Item("GUID_TokenAttribute")
                                objDRC_LogState = semprocA_DBWork_Save_Token_Attribute_Int.GetData(GUID_Version, objLocalConfig.SemItem_Attribute_Revision.GUID, Nothing, objUserControl_Version.Revision, 0).Rows
                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                    GUID_TokenAttribute_Revision = objDRC_LogState(0).Item("GUID_TokenAttribute")
                                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development.GUID, GUID_Version, objLocalConfig.SemItem_RelationType_isInState.GUID, 0).Rows
                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_PLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, 0).Rows
                                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_StdLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_Standard.GUID, 0).Rows
                                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_StdLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_offers.GUID, 0).Rows
                                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development.GUID, objLocalConfig.SemItem_Token_User.GUID, objLocalConfig.SemItem_RelationType_wasDevelopedBy.GUID, True).Rows
                                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development.GUID, objLocalConfig.SemItem_Token_LogState_Active.GUID, objLocalConfig.SemItem_RelationType_isInState.GUID, 0).Rows
                                                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                            If objSemItem_Development_Parent Is Nothing Then
                                                                DialogResult = Windows.Forms.DialogResult.OK
                                                                save_LogEntry()
                                                                Me.Hide()
                                                            Else
                                                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development.GUID, objSemItem_Development_Parent.GUID, objLocalConfig.SemItem_RelationType_isSubordinated.GUID, 0).Rows
                                                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                                    DialogResult = Windows.Forms.DialogResult.OK
                                                                    save_LogEntry()
                                                                    Me.Hide()
                                                                Else
                                                                    MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)
                                                                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objLocalConfig.SemItem_Token_LogState_Active.GUID, objLocalConfig.SemItem_RelationType_isInState.GUID)
                                                                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objLocalConfig.SemItem_Token_User.GUID, objLocalConfig.SemItem_RelationType_wasDevelopedBy.GUID)
                                                                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_StdLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_offers.GUID)
                                                                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_StdLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_Standard.GUID)
                                                                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_PLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_isWrittenIn.GUID)
                                                                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, GUID_Version, objLocalConfig.SemItem_RelationType_isInState.GUID)
                                                                    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Revision)
                                                                    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Build)
                                                                    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Minor)
                                                                    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Major)
                                                                    semprocA_DBWork_Del_Token.GetData(GUID_Version)
                                                                    semprocA_DBWork_Del_Token.GetData(objSemItem_Development.GUID)
                                                                    Me.Hide()
                                                                End If
                                                            End If

                                                        Else
                                                            MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)
                                                            semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objLocalConfig.SemItem_Token_User.GUID, objLocalConfig.SemItem_RelationType_wasDevelopedBy.GUID)
                                                            semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_StdLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_offers.GUID)
                                                            semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_StdLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_Standard.GUID)
                                                            semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_PLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_isWrittenIn.GUID)
                                                            semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, GUID_Version, objLocalConfig.SemItem_RelationType_isInState.GUID)
                                                            semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Revision)
                                                            semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Build)
                                                            semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Minor)
                                                            semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Major)
                                                            semprocA_DBWork_Del_Token.GetData(GUID_Version)
                                                            semprocA_DBWork_Del_Token.GetData(objSemItem_Development.GUID)
                                                            Me.Hide()
                                                        End If
                                                    Else
                                                        MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)
                                                        semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_StdLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_offers.GUID)
                                                        semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_StdLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_Standard.GUID)
                                                        semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_PLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_isWrittenIn.GUID)
                                                        semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, GUID_Version, objLocalConfig.SemItem_RelationType_isInState.GUID)
                                                        semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Revision)
                                                        semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Build)
                                                        semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Minor)
                                                        semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Major)
                                                        semprocA_DBWork_Del_Token.GetData(GUID_Version)
                                                        semprocA_DBWork_Del_Token.GetData(objSemItem_Development.GUID)
                                                        Me.Hide()
                                                    End If
                                                Else
                                                    MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)
                                                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_StdLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_Standard.GUID)
                                                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_PLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_isWrittenIn.GUID)
                                                    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, GUID_Version, objLocalConfig.SemItem_RelationType_isInState.GUID)
                                                    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Revision)
                                                    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Build)
                                                    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Minor)
                                                    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Major)
                                                    semprocA_DBWork_Del_Token.GetData(GUID_Version)
                                                    semprocA_DBWork_Del_Token.GetData(objSemItem_Development.GUID)
                                                    Me.Hide()
                                                End If
                                            Else
                                                MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)
                                                semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objUserControl_PLanguage.DataGridViewRowCollection_Selected(0).DataBoundItem.item("GUID_Token"), objLocalConfig.SemItem_RelationType_isWrittenIn.GUID)
                                                semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, GUID_Version, objLocalConfig.SemItem_RelationType_isInState.GUID)
                                                semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Revision)
                                                semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Build)
                                                semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Minor)
                                                semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Major)
                                                semprocA_DBWork_Del_Token.GetData(GUID_Version)
                                                semprocA_DBWork_Del_Token.GetData(objSemItem_Development.GUID)
                                                Me.Hide()
                                            End If
                                        Else
                                            MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)

                                            semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, GUID_Version, objLocalConfig.SemItem_RelationType_isInState.GUID)
                                            semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Revision)
                                            semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Build)
                                            semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Minor)
                                            semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Major)
                                            semprocA_DBWork_Del_Token.GetData(GUID_Version)
                                            semprocA_DBWork_Del_Token.GetData(objSemItem_Development.GUID)
                                            Me.Hide()
                                        End If

                                    Else
                                        MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)
                                        semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Revision)
                                        semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Build)
                                        semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Minor)
                                        semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Major)
                                        semprocA_DBWork_Del_Token.GetData(GUID_Version)
                                        semprocA_DBWork_Del_Token.GetData(objSemItem_Development.GUID)
                                        Me.Hide()
                                    End If
                                Else
                                    MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)
                                    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Build)
                                    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Minor)
                                    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Major)
                                    semprocA_DBWork_Del_Token.GetData(GUID_Version)
                                    semprocA_DBWork_Del_Token.GetData(objSemItem_Development.GUID)
                                    Me.Hide()
                                End If
                            Else
                                MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)
                                semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Minor)
                                semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Major)
                                semprocA_DBWork_Del_Token.GetData(GUID_Version)
                                semprocA_DBWork_Del_Token.GetData(objSemItem_Development.GUID)
                                Me.Hide()
                            End If
                        Else
                            MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)
                            semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Major)
                            semprocA_DBWork_Del_Token.GetData(GUID_Version)
                            semprocA_DBWork_Del_Token.GetData(objSemItem_Development.GUID)
                            Me.Hide()
                        End If
                    Else
                        MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)
                        semprocA_DBWork_Del_Token.GetData(GUID_Version)
                        semprocA_DBWork_Del_Token.GetData(objSemItem_Development.GUID)
                        Me.Hide()
                    End If

                Else
                    MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)
                    semprocA_DBWork_Del_Token.GetData(objSemItem_Development.GUID)
                    Me.Hide()
                End If
            Else
                MsgBox("Softwarentwicklung konnte nicht gespeichert werden!", MsgBoxStyle.Critical)
                Me.Hide()
            End If
        Else
            MsgBox("Die Basis-Daten haben sich geändert. Bitte überprüfen Sie Ihre Eingaben!", MsgBoxStyle.Exclamation)

        End If
    End Sub
    Private Function save_LogEntry() As Boolean

        Dim objSemItem_LogEntry As clsSemItem

        objLogWork_Local = New clsLogWork_Local
        objSemItem_LogEntry = objLogWork_Local.log_Entry(objSemItem_Development, objLocalConfig.SemItem_Token_LogState_Create)
        If Not objSemItem_LogEntry Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function
End Class