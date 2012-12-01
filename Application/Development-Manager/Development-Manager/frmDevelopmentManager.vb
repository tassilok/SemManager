Imports Sem_Manager
Imports Localizing_Manager
Imports Filesystem_Management
Imports Schema_Manager
Public Class frmDevelopmentManager

    Private objLocalize_GUIEntries As clsLocalized_GUIEntries
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private procA_Folder_Of_ImageVideoManagemment As New ds_PluginTableAdapters.proc_Folder_Of_ImageVideoManagemmentTableAdapter

    Private objGlobals As clsGlobals

    Private objFrmSemManager As frmSemManager
    Private objFileWork As clsFileWork
    Private WithEvents objUserControl_DevelopmentTree As UserControl_DevelopmentTree

    Private objUserControl_BaseData As UserControl_BaseData
    Private objUserControl_Request As UserControl_Requests
    Private objUserControl_Logentries As UserControl_Logentries
    Private objUserControl_SemConfig As UserControl_SemanticConfig
    Private WithEvents objUserControl_DevelopmentStructure As UserControl_DevelopmentStructure
    Private objUserControl_DBSchemaOfApplication As UserControl_DBSchema_For_Applications
    Private WithEvents objUserControl_GUIEntries As UserControl_GUIEntries
    Private objUserControl_Messages As UserControl_Messages
    Private objUserControl_Scenarios As UserControl_Scenarios
    Private objUserControl_Libraries As UserControl_SemItemList

    Private objSemItems_Result() As clsSemItem
    Private objSemItems_Languages() As clsSemItem
    Private objSemItem_Development As New clsSemItem
    Private objLanguage As clsLanguage
    Private boolApplyable As Boolean

    Public ReadOnly Property SemItems_Result() As clsSemItem()
        Get
            Return objSemItems_Result
        End Get
    End Property

    Private Sub applied_GUIEntry(ByVal objSemItem_GUIEntry As clsSemItem) Handles objUserControl_GUIEntries.applied_GUIEntry
        ReDim Preserve objSemItems_Result(0)
        objSemItems_Result(0) = objSemItem_GUIEntry
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub applied_DevStructure(ByVal objSemItem_DevStructure As clsSemItem) Handles objUserControl_DevelopmentStructure.applied_DevStructure
        ReDim Preserve objSemItems_Result(0)
        objSemItems_Result(0) = objSemItem_DevStructure
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub
    Private Sub applied_Development(ByVal objSemItem_Development As clsSemItem) Handles objUserControl_DevelopmentTree.applied_Development
        ReDim Preserve objSemItems_Result(0)
        objSemItems_Result(0) = objSemItem_Development
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub Development_Changed(ByVal objTreeNode As TreeNode) Handles objUserControl_DevelopmentTree.selected_TreeNode_Changed
        Dim objDRC_DevelopmentParent As DataRowCollection

        objDRC_DevelopmentParent = funcA_TokenToken.GetData_TokenToken_LeftRight(New Guid(objTreeNode.Name), _
                                                                                 objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                                 objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID).Rows

        objSemItem_Development = New clsSemItem
        objSemItem_Development.GUID = New Guid(objTreeNode.Name)
        objSemItem_Development.Name = objTreeNode.Text
        objSemItem_Development.GUID_Parent = objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID
        If objDRC_DevelopmentParent.Count > 0 Then
            objSemItem_Development.GUID_Related = objDRC_DevelopmentParent(0).Item("GUID_Token_Right")
        Else
            objSemItem_Development.GUID_Related = Nothing
        End If
        objSemItem_Development.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        objLanguage = New clsLanguage(objSemItem_Development)
        objLocalConfig.LanguageConfig = objLanguage
        refresh_TabPages()
    End Sub

    Private Sub Development_Root_Choosen() Handles objUserControl_DevelopmentTree.selected_Root
        objSemItem_Development = Nothing
        refresh_TabPages()
    End Sub

    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objGlobals = New clsGlobals
        objLocalConfig = New clsLocalConfig(objGlobals)
        initialize()
    End Sub

    Public Sub New(ByVal LocalConfig As Development_Manager.clsLocalConfig, ByVal isApplyable As Boolean)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        boolApplyable = isApplyable
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Private Sub initialize()
        objSemItem_Development = Nothing
        objUserControl_DevelopmentTree = New UserControl_DevelopmentTree
        objUserControl_DevelopmentTree.isApplyable = boolApplyable
        objUserControl_DevelopmentTree.Dock = DockStyle.Fill

        SplitContainer1.Panel1.Controls.Clear()
        SplitContainer1.Panel1.Controls.Add(objUserControl_DevelopmentTree)
        set_DBConnection()
        get_Folder_ImageVideoManagement()
        If objLocalConfig.SemItem_Token_User Is Nothing Then
            get_User()
            If Not objLocalConfig.SemItem_Token_User Is Nothing Then
                configure_GUI()
                refresh_TabPages()
            End If
        End If


    End Sub

    Private Sub get_Folder_ImageVideoManagement()
        Dim objDRC_ImageVideoFolder As DataRowCollection
        Dim objSemItem_Folder As New clsSemItem

        objDRC_ImageVideoFolder = procA_Folder_Of_ImageVideoManagemment.GetData(objLocalConfig.SemItem_Type_Image_Video_Management.GUID, _
                                                                                objLocalConfig.SemItem_Type_Folder.GUID, _
                                                                                objLocalConfig.SemItem_RelationType_SourcesLocatedIn.GUID, _
                                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                objLocalConfig.SemItem_Token_Module_Development_Management.GUID).Rows
        If objDRC_ImageVideoFolder.Count > 0 Then
            objSemItem_Folder.GUID = objDRC_ImageVideoFolder(0).Item("GUID_Folder")
            objSemItem_Folder.Name = objDRC_ImageVideoFolder(0).Item("Name_Folder")
            objSemItem_Folder.GUID_Parent = objLocalConfig.SemItem_Type_Folder.GUID
            objSemItem_Folder.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objLocalConfig.Path_ImageVideos = objFileWork.get_Path_FileSystemObject(objSemItem_Folder)

            If IO.Directory.Exists(objLocalConfig.Path_ImageVideos) Then
                objLocalConfig.Path_ImageVideos = Nothing
            End If
        End If
    End Sub

    Private Sub configure_GUI()
        Dim strCaption As String

        objLocalize_GUIEntries = New clsLocalized_GUIEntries(objLocalConfig.SemItem_Development, objLocalConfig.Globals)
        strCaption = objLocalize_GUIEntries.get_Localized_Caption
        If Not strCaption Is Nothing Then
            Me.Text = strCaption
        End If
        configure_GUIEntries()
    End Sub

    Private Sub configure_GUIEntries()
        Dim objDR_GUIEntry As DataRow
        Dim strCaption As String
        Dim strToolTip As String

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(TabPage_Basedata.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                TabPage_Basedata.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                TabPage_Basedata.ToolTipText = strToolTip
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(TabPage_DBSchema.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                TabPage_DBSchema.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                TabPage_DBSchema.ToolTipText = strToolTip
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(TabPage_devStructures.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                TabPage_devStructures.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                TabPage_devStructures.ToolTipText = strToolTip
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(TabPage_GUIEntries.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                TabPage_GUIEntries.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                TabPage_GUIEntries.ToolTipText = strToolTip
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(TabPage_Libraries.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                TabPage_Libraries.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                TabPage_Libraries.ToolTipText = strToolTip
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(TabPage_Logentries.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                TabPage_Logentries.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                TabPage_Logentries.ToolTipText = strToolTip
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(TabPage_Messages.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                TabPage_Messages.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                TabPage_Messages.ToolTipText = strToolTip
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(TabPage_Requests.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                TabPage_Requests.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                TabPage_Requests.ToolTipText = strToolTip
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(TabPage_Scenarios.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                TabPage_Scenarios.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                TabPage_Scenarios.ToolTipText = strToolTip
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(TabPage_SemConfig.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                TabPage_SemConfig.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                TabPage_SemConfig.ToolTipText = strToolTip
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(ToolStripButton_Close.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                ToolStripButton_Close.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                ToolStripButton_Close.ToolTipText = strToolTip
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(TabPage_Features.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                TabPage_Features.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                TabPage_Features.ToolTipText = strToolTip
            End If
        End If

        objDR_GUIEntry = objLocalize_GUIEntries.get_Localized_GUIEntry(TabPage_ModuleManagement.Name)
        If Not objDR_GUIEntry Is Nothing Then
            strCaption = objDR_GUIEntry.Item("Name_GUI_Caption")
            strToolTip = objDR_GUIEntry.Item("Name_ToolTip_Messages")
            If Not strCaption Is Nothing Then
                TabPage_ModuleManagement.Text = strCaption
            End If
            If Not strToolTip Is Nothing Then
                TabPage_ModuleManagement.ToolTipText = strToolTip
            End If
        End If
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_Folder_Of_ImageVideoManagemment.Connection = objLocalConfig.Connection_Plugin

        objFileWork = New clsFileWork(objLocalConfig.Globals)
    End Sub

    Private Sub get_User()
        Dim objDGVSRC As DataGridViewSelectedRowCollection
        Dim objDRV As DataRowView
        Dim objSemItem_User As New clsSemItem

        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_User, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)
        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.Applied_SemItems = False Then
                objDGVSRC = objFrmSemManager.SelectedRows_Items
                If objDGVSRC.Count = 1 Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                        objDRV = objDGVSRC(0).DataBoundItem
                        If objDRV.Item("GUID_Type") = objLocalConfig.SemItem_Type_User.GUID Then
                            objSemItem_User.GUID = objDRV.Item("GUID_Token")
                            objSemItem_User.Name = objDRV.Item("Name_Token")
                            objSemItem_User.GUID_Parent = objLocalConfig.SemItem_Type_User.GUID
                            objSemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objLocalConfig.SemItem_Token_User = objSemItem_User
                        Else
                            objLocalConfig.SemItem_Token_User = Nothing
                        End If
                    Else
                        objLocalConfig.SemItem_Token_User = Nothing
                    End If
                Else
                    objLocalConfig.SemItem_Token_User = Nothing
                End If
            Else
                objLocalConfig.SemItem_Token_User = Nothing
            End If
        Else
            objLocalConfig.SemItem_Token_User = Nothing
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl_ModuleManagement.SelectedIndexChanged
        refresh_TabPages()
    End Sub

    Private Sub get_Languages()
        Dim objDRC_Language As DataRowCollection
        Dim objDR_Language As DataRow
        Dim objSemItem_Language As clsSemItem
        Dim i As Integer
        Dim boolAdd As Boolean

        If objSemItem_Development Is Nothing Then
            objSemItems_Languages = Nothing
        Else
            If objSemItem_Development.GUID_Related = Nothing Then
                objDRC_Language = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Development.GUID, objLocalConfig.SemItem_RelationType_Standard.GUID, objLocalConfig.SemItem_Type_Language.GUID).Rows
            Else
                objDRC_Language = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Development.GUID_Related, objLocalConfig.SemItem_RelationType_Standard.GUID, objLocalConfig.SemItem_Type_Language.GUID).Rows
            End If

            If objDRC_Language.Count > 0 Then
                ReDim Preserve objSemItems_Languages(0)
                objSemItems_Languages(0) = New clsSemItem
                objSemItems_Languages(0).GUID = objDRC_Language(0).Item("GUID_Token_Right")
                objSemItems_Languages(0).Name = objDRC_Language(0).Item("Name_Token_Right")
                objSemItems_Languages(0).GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
                objSemItems_Languages(0).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            End If

            If objSemItem_Development.GUID_Related = Nothing Then
                objDRC_Language = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Development.GUID, objLocalConfig.SemItem_RelationType_additional.GUID, objLocalConfig.SemItem_Type_Language.GUID).Rows
            Else
                objDRC_Language = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Development.GUID_Related, objLocalConfig.SemItem_RelationType_additional.GUID, objLocalConfig.SemItem_Type_Language.GUID).Rows
            End If

            For Each objDR_Language In objDRC_Language
                boolAdd = True
                If objSemItems_Languages Is Nothing Then
                    i = 0
                Else
                    For Each objSemItem_Language In objSemItems_Languages
                        If objSemItem_Language.GUID = objDR_Language.Item("GUID_Token_Right") Then
                            boolAdd = False
                            Exit For

                        End If
                    Next
                    If boolAdd = True Then
                        i = objSemItems_Languages.Length
                    End If

                End If

                If boolAdd = True Then
                    ReDim Preserve objSemItems_Languages(i)
                    objSemItems_Languages(i) = New clsSemItem
                    objSemItems_Languages(i).GUID = objDR_Language.Item("GUID_Token_Right")
                    objSemItems_Languages(i).Name = objDRC_Language(0).Item("Name_Token_Right")
                    objSemItems_Languages(i).GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
                    objSemItems_Languages(i).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                End If

            Next
        End If
    End Sub

    Private Sub refresh_TabPages()
        Dim objSemItem_Development_Library As clsSemItem
        get_Languages()
        If TabControl_ModuleManagement.SelectedTab Is TabPage_Basedata Then
            objUserControl_BaseData = New UserControl_BaseData(objSemItem_Development)
            objUserControl_BaseData.Dock = DockStyle.Fill
            If Not objSemItem_Development Is Nothing Then
                objUserControl_BaseData.EnableDisable_Controls(True)
                objUserControl_BaseData.get_Data()
            Else
                objUserControl_BaseData.EnableDisable_Controls(False)

            End If
            TabPage_Basedata.Controls.Clear()
            TabPage_Basedata.Controls.Add(objUserControl_BaseData)
        ElseIf TabControl_ModuleManagement.SelectedTab Is TabPage_DBSchema Then
            objUserControl_DBSchemaOfApplication = New UserControl_DBSchema_For_Applications(objSemItem_Development, objLocalConfig.Globals)
            objUserControl_DBSchemaOfApplication.Dock = DockStyle.Fill
            TabPage_DBSchema.Controls.Clear()
            TabPage_DBSchema.Controls.Add(objUserControl_DBSchemaOfApplication)
        ElseIf TabControl_ModuleManagement.SelectedTab Is TabPage_devStructures Then
            objUserControl_DevelopmentStructure = New UserControl_DevelopmentStructure(objSemItem_Development, boolApplyable)
            objUserControl_DevelopmentStructure.Dock = DockStyle.Fill
            TabPage_devStructures.Controls.Clear()
            TabPage_devStructures.Controls.Add(objUserControl_DevelopmentStructure)
        ElseIf TabControl_ModuleManagement.SelectedTab Is TabPage_GUIEntries Then
            objUserControl_GUIEntries = New UserControl_GUIEntries(objSemItem_Development, objSemItems_Languages, boolApplyable)
            objUserControl_GUIEntries.Dock = DockStyle.Fill
            TabPage_GUIEntries.Controls.Clear()
            TabPage_GUIEntries.Controls.Add(objUserControl_GUIEntries)
        ElseIf TabControl_ModuleManagement.SelectedTab Is TabPage_Libraries Then
            objUserControl_Libraries = New UserControl_SemItemList
            objUserControl_Libraries.Dock = DockStyle.Fill
            TabPage_Libraries.Controls.Clear()
            TabPage_Libraries.Controls.Add(objUserControl_Libraries)
            If Not objSemItem_Development Is Nothing Then
                objSemItem_Development_Library = objSemItem_Development
                objSemItem_Development_Library.GUID_Related = objLocalConfig.SemItem_Type_Development_Libraries.GUID
                objSemItem_Development_Library.GUID_Relation = objLocalConfig.SemItem_RelationType_needs.GUID
                objUserControl_Libraries.initialize_Complex(objSemItem_Development_Library, objLocalConfig.Globals)
            End If
        ElseIf TabControl_ModuleManagement.SelectedTab Is TabPage_Logentries Then
            objUserControl_Logentries = New UserControl_Logentries(objSemItem_Development)
            objUserControl_Logentries.Dock = DockStyle.Fill
            TabPage_Logentries.Controls.Clear()
            TabPage_Logentries.Controls.Add(objUserControl_Logentries)
        ElseIf TabControl_ModuleManagement.SelectedTab Is TabPage_Messages Then
            objUserControl_Messages = New UserControl_Messages(objSemItem_Development, objSemItems_Languages)
            objUserControl_Messages.Dock = DockStyle.Fill
            TabPage_Messages.Controls.Clear()
            TabPage_Messages.Controls.Add(objUserControl_Messages)

        ElseIf TabControl_ModuleManagement.SelectedTab Is TabPage_Requests Then
            objUserControl_Request = New UserControl_Requests(objSemItem_Development)
            objUserControl_Request.Dock = DockStyle.Fill
            TabPage_Requests.Controls.Clear()
            TabPage_Requests.Controls.Add(objUserControl_Request)
        ElseIf TabControl_ModuleManagement.SelectedTab Is TabPage_Scenarios Then
            objUserControl_Scenarios = New UserControl_Scenarios(objSemItem_Development, boolApplyable)
            objUserControl_Scenarios.Dock = DockStyle.Fill
            TabPage_Scenarios.Controls.Clear()
            TabPage_Scenarios.Controls.Add(objUserControl_Scenarios)
        ElseIf TabControl_ModuleManagement.SelectedTab Is TabPage_SemConfig Then
            objUserControl_SemConfig = New UserControl_SemanticConfig()
            If Not objSemItem_Development Is Nothing Then
                objUserControl_SemConfig.initialize(objSemItem_Development)
            End If
            objUserControl_SemConfig.Dock = DockStyle.Fill
            TabPage_SemConfig.Controls.Clear()
            TabPage_SemConfig.Controls.Add(objUserControl_SemConfig)
        End If
    End Sub

    Private Sub frmDevelopmentManager_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objLocalConfig.SemItem_Token_User Is Nothing Then
            Application.Exit()
        End If
    End Sub
End Class
