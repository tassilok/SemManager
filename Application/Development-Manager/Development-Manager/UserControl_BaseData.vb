Imports Sem_Manager
Imports Localizing_Manager
Public Class UserControl_BaseData
    Private Const cstrGUID_Development As String = "42e05640-22f0-4fff-bf3b-27d7dd93e081"


    Private funcA_SoftwareDevelopment_BaseData As New ds_BaseDataTableAdapters.func_SoftwareDevelopment_BaseDataTableAdapter
    Private func_SoftwareDevelopment_BaseData As New ds_BaseData.func_SoftwareDevelopment_BaseDataDataTable
    
    Private procA_SoftwareDevelopment_PossibleStates As New ds_BaseDataTableAdapters.proc_SoftwareDevelopment_PossibleStatesTableAdapter
    Private proc_SoftwareDevelopment_PossibleStates As New ds_BaseData.proc_SoftwareDevelopment_PossibleStatesDataTable

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_Token_Attribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter

    Private objUserControl_SemItem As UserControl_SemItemList
    Private objUserControl_Localized As UserControl_Localized

    Private objLocalize_GUIEntries As clsLocalized_GUIEntries

    Private objSemItem_Development_Languages As clsSemItem
    Private objSemItem_Development As clsSemItem
    Private objLanguage As clsLanguage
    'Private objSemItems_Languages() As clsSemItem


    Public Sub New(ByVal SemItem_Development As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Development = SemItem_Development
        set_DBConnection()
        procA_SoftwareDevelopment_PossibleStates.Fill(proc_SoftwareDevelopment_PossibleStates, _
                                                      objLocalConfig.SemItem_Token_PossibleStates_DevelopmentStandard.GUID, _
                                                      objLocalConfig.SemItem_Type_LogState.GUID, _
                                                      objLocalConfig.SemItem_RelationType_Possible.GUID)
        ComboBox_State.DataSource = proc_SoftwareDevelopment_PossibleStates
        ComboBox_State.DisplayMember = "Name_LogState"
        ComboBox_State.ValueMember = "GUID_LogState"
        objUserControl_Localized = New UserControl_Localized
        objUserControl_Localized.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(objUserControl_Localized)
        EnableDisable_Controls(False)

    End Sub

    Public Sub EnableDisable_Controls(ByVal boolEnable As Boolean)
        TextBox_Creator.Enabled = boolEnable
        TextBox_FolderSourceCode.Enabled = boolEnable
        TextBox_LanguageStandard.Enabled = boolEnable
        TextBox_PLanguage.Enabled = boolEnable
        TextBox_Version.Enabled = boolEnable

        Button_Creator.Enabled = boolEnable
        Button_FolderSourceCode.Enabled = boolEnable
        Button_PLanguage.Enabled = boolEnable
        Button_Version.Enabled = boolEnable
        Button_LanguageStandard.Enabled = boolEnable

        ComboBox_State.Enabled = boolEnable
        Panel_Languages.Enabled = boolEnable

        objUserControl_Localized.Enabled = boolEnable

        configure_GUIEntries()
    End Sub

    Private Sub set_DBConnection()
        funcA_SoftwareDevelopment_BaseData.Connection = objLocalConfig.Connection_Plugin
        procA_SoftwareDevelopment_PossibleStates.Connection = objLocalConfig.Connection_Plugin

        semprocA_DBWork_Save_Token_Attribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
    End Sub

    Public Sub get_Data()
        Dim objDGVR_Language As DataGridViewRow
        Dim objDRV_Language As DataRowView
        Dim intLanguageCount As Integer

        'objSemItems_Languages = Nothing
        Label_Development.Text = objSemItem_Development.Name

        func_SoftwareDevelopment_BaseData.Clear()
        funcA_SoftwareDevelopment_BaseData.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_BaseData, _
                                                                   objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                   objLocalConfig.SemItem_Type_LogState.GUID, _
                                                                   objLocalConfig.SemItem_Type_User.GUID, _
                                                                   objLocalConfig.SemItem_Type_DevelopmentVersion.GUID, _
                                                                   objLocalConfig.SemItem_Type_ProgramingLanguage.GUID, _
                                                                   objLocalConfig.SemItem_Type_Folder.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_wasDevelopedBy.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_SourcesLocatedIn.GUID, _
                                                                   objSemItem_Development.GUID)
        objSemItem_Development_Languages = Nothing
        If func_SoftwareDevelopment_BaseData.Rows.Count > 0 Then
            If Not IsDBNull(func_SoftwareDevelopment_BaseData.Rows(0).Item("GUID_LogState")) Then
                ComboBox_State.SelectedValue = func_SoftwareDevelopment_BaseData.Rows(0).Item("GUID_LogState")
            End If
            If Not IsDBNull(func_SoftwareDevelopment_BaseData.Rows(0).Item("Name_user")) Then
                TextBox_Creator.Text = func_SoftwareDevelopment_BaseData.Rows(0).Item("Name_user")
            Else
                TextBox_Creator.Text = ""
            End If

            If Not IsDBNull(func_SoftwareDevelopment_BaseData.Rows(0).Item("Name_Version")) Then
                TextBox_Version.Text = func_SoftwareDevelopment_BaseData.Rows(0).Item("Name_Version")
            Else
                TextBox_Version.Text = ""
            End If

            If Not IsDBNull(func_SoftwareDevelopment_BaseData.Rows(0).Item("Name_PLanguage")) Then
                TextBox_PLanguage.Text = func_SoftwareDevelopment_BaseData.Rows(0).Item("Name_PLanguage")
            Else
                TextBox_PLanguage.Text = ""
            End If

            objSemItem_Development_Languages = New clsSemItem
            If objSemItem_Development.GUID_Related = Nothing Then
               
                objSemItem_Development_Languages.GUID = objSemItem_Development.GUID

            Else
               
                objSemItem_Development_Languages.GUID = objSemItem_Development.GUID_Related
            End If
            objSemItem_Development_Languages.GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
            objSemItem_Development_Languages.Direction = objSemItem_Development_Languages.Direction_LeftRight
            objSemItem_Development_Languages.GUID_Related = objLocalConfig.SemItem_Type_Language.GUID
            objSemItem_Development_Languages.GUID_Relation = objLocalConfig.SemItem_RelationType_additional.GUID
            objSemItem_Development_Languages.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objUserControl_SemItem = New UserControl_SemItemList
            objUserControl_SemItem.initialize_Complex(objSemItem_Development_Languages, objLocalConfig.Globals)
            objUserControl_SemItem.Dock = DockStyle.Fill
            Panel_Languages.Controls.Add(objUserControl_SemItem)
            objLanguage = objLocalConfig.LanguageConfig
            If Not objLanguage.supported_Languages Is Nothing Then
                If objLanguage.supported_Languages(0).Mark = True Then
                    TextBox_LanguageStandard.Text = objLanguage.supported_Languages(0).Name

                Else
                    TextBox_LanguageStandard.Text = ""
                End If

            Else
                TextBox_LanguageStandard.Text = ""
            End If
            'If func_Standard_Language.Rows.Count > 0 Then
            '    ReDim Preserve objSemItems_Languages(0)
            '    objSemItems_Languages(0) = New clsSemItem
            '    objSemItems_Languages(0).GUID = func_Standard_Language.Rows(0).Item("GUID_Token")
            '    objSemItems_Languages(0).Name = func_Standard_Language.Rows(0).Item("Name_Token")
            '    objSemItems_Languages(0).GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
            '    objSemItems_Languages(0).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            '    objSemItems_Languages(0).Mark = True

            '    TextBox_LanguageStandard.Text = func_Standard_Language.Rows(0).Item("Name_Token")
            'Else
            '    TextBox_LanguageStandard.Text = ""

            'End If

            'If objUserControl_SemItem.DataGridViewRows.Count > 0 Then
            '    intLanguageCount = 0
            '    For Each objDGVR_Language In objUserControl_SemItem.DataGridViewRows
            '        objDRV_Language = objDGVR_Language.DataBoundItem
            '        If Not objSemItems_Languages Is Nothing Then
            '            intLanguageCount = objSemItems_Languages.Length
            '            ReDim Preserve objSemItems_Languages(intLanguageCount)
            '            objSemItems_Languages(intLanguageCount) = New clsSemItem
            '        Else
            '            ReDim Preserve objSemItems_Languages(intLanguageCount)
            '            objSemItems_Languages(intLanguageCount) = New clsSemItem
            '        End If
            '        objSemItems_Languages(intLanguageCount).GUID = objDRV_Language.Item("GUID_Token_Right")
            '        objSemItems_Languages(intLanguageCount).Name = objDRV_Language.Item("Name_Token_Right")
            '        objSemItems_Languages(intLanguageCount).GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
            '        objSemItems_Languages(intLanguageCount).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            '    Next
            'End If

            If Not IsDBNull(func_SoftwareDevelopment_BaseData.Rows(0).Item("Name_Folder")) Then
                TextBox_FolderSourceCode.Text = func_SoftwareDevelopment_BaseData.Rows(0).Item("Name_Folder")
            Else
                TextBox_FolderSourceCode.Text = ""
            End If
            objUserControl_Localized.initialize(objSemItem_Development, objLanguage.supported_Languages, False)
        Else
            MsgBox("Die Basis-Daten sind fehlerhaft!", MsgBoxStyle.Exclamation)
            TextBox_Creator.Text = ""
            TextBox_Version.Text = ""
        End If



    End Sub

    
    Private Sub configure_GUIEntries()
        Dim objSemItem_Development As New clsSemItem
        Dim objDR_GUIEntry As DataRow
        Dim strCaption As String
        Dim strToolTip As String

        objSemItem_Development.GUID = New Guid(cstrGUID_Development)
        objLocalize_GUIEntries = New clsLocalized_GUIEntries(objSemItem_Development, objLocalConfig.Globals)
        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(Label_PLanguage.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Label_PLanguage.Text = strCaption
            End If
            
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(Label_StandarLanguage.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Label_StandarLanguage.Text = strCaption
            End If
            
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(Label_State.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Label_State.Text = strCaption
            End If

        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(Button_Version.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Button_Version.Text = strCaption
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(Label_Languages.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Label_Languages.Text = strCaption
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(Label_Creator.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Label_Creator.Text = strCaption
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(Button_FolderSourceCode.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Button_FolderSourceCode.Text = strCaption
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(Button_LanguageStandard.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Button_LanguageStandard.Text = strCaption
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(Label_FolderSourceCode.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Label_FolderSourceCode.Text = strCaption
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(Label_Version.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Label_Version.Text = strCaption
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(Button_PLanguage.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Button_PLanguage.Text = strCaption
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(Button_Creator.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                Button_Creator.Text = strCaption
            End If
        End If
    End Sub
    

   
End Class
