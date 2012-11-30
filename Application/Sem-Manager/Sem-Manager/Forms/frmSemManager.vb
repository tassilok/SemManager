Public Class frmSemManager
    Private WithEvents objUserControl_TypeTree As UserControl_TypeTree
    Private WithEvents objUserControl_SemList As UserControl_SemItemList
    Private WithEvents objFrmSearchResult As frmSearchResult


    Private chngtblA_DB As New ds_ChangeTableAdapters.chngtbl_DBTableAdapter
    Private objDGVSRC_Selected As DataGridViewSelectedRowCollection
    Private objDRC_Databases As DataRowCollection

    Private objSplashScreen As New SplashScreen_Main
    Private objFrm_SemManager As frmSemManager

    Private objLocalConfig As clsLocalConfig_SemManager
    Private objSemItems_Selected() As clsSemItem
    Private objSemItem_Start As clsSemItem
    Private boolApplyable As Boolean
    Private boolSemItems As Boolean
    Private GUID_Type_Selected As Guid
    Private boolModuleView As Boolean = True

    Private Sub selected_SearchItem(ByVal SemItem_Selected As clsSemItem) Handles objFrmSearchResult.selected_SemItem
        Dim objSemItem_Type As New clsSemItem
        Select Case SemItem_Selected.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Type.GUID = SemItem_Selected.GUID_Parent
                objUserControl_TypeTree.select_Type(objSemItem_Type)
                TypeTree_Selection_Changed()
                objUserControl_SemList.filter_View_GUID_Token(SemItem_Selected.GUID)
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objUserControl_TypeTree.select_Type(SemItem_Selected)
        End Select
    End Sub

    Public Property ModuleView() As Boolean
        Get
            Return boolModuleView
        End Get
        Set(ByVal value As Boolean)
            boolModuleView = value
            ModuleViewToolStripMenuItem.Checked = value
        End Set
    End Property

    Public ReadOnly Property SelectedItems_TypeGUID() As Guid
        Get
            Return GUID_Type_Selected
        End Get
    End Property
    Public ReadOnly Property SelectedRows_Items() As DataGridViewSelectedRowCollection
        Get
            
            Return objDGVSRC_Selected
        End Get
    End Property
    Public ReadOnly Property Applied_SemItems() As Boolean
        Get
            Return boolSemItems
        End Get
    End Property

    Public ReadOnly Property SemItems_Selected() As clsSemItem()
        Get
            Return objSemItems_Selected
        End Get

    End Property

    Public Property Applyabale() As Boolean
        Get
            Return boolApplyable

        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
            set_Controls_Applyable()
        End Set
    End Property

    Private Sub Applied_SemList() Handles objUserControl_SemList.Applied_Item
        boolSemItems = False
        objDGVSRC_Selected = objUserControl_SemList.DataGridViewRowCollection_Selected
        GUID_Type_Selected = objUserControl_SemList.GUID_Type_Selected
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub Applied_TypeTree() Handles objUserControl_TypeTree.Applyied_Item
        boolSemItems = True
        ReDim Preserve objSemItems_Selected(0)
        objSemItems_Selected(0) = objUserControl_TypeTree.SemItem_Selected
        GUID_Type_Selected = objUserControl_TypeTree.GUID_Type_Selected
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub TypeTree_Selection_Changed() Handles objUserControl_TypeTree.selected_Item
        ReDim Preserve objSemItems_Selected(0)
        Dim boolModule As Boolean = False
        Dim objModules() As clsModule
        Dim objModule As clsModule

        objSemItems_Selected(0) = New clsSemItem
        objSemItems_Selected(0) = objUserControl_TypeTree.SemItem_Selected
        If boolModuleView = True Then
            objModules = objLocalConfig.Globals.loaded_Modules
            If Not objModules Is Nothing Then
                For Each objModule In objLocalConfig.Globals.loaded_Modules
                    If objModule.Active = True And objModule.Valid = True Then
                        If objModule.Object_OK(objSemItems_Selected(0)) = True Then
                            boolModule = True
                            Exit For
                        End If
                    End If
                Next

            End If
        End If
        
        If boolModule = False Then
            Select Case objSemItems_Selected(0).GUID_Type
                Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                    objUserControl_SemList = New UserControl_SemItemList
                    objUserControl_SemList.initialize_Simple(objSemItems_Selected(0), objLocalConfig.Globals)
                Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                    objUserControl_SemList = New UserControl_SemItemList
                    objUserControl_SemList.initialize_Simple(objSemItems_Selected(0), objLocalConfig.Globals)
                Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                    objUserControl_SemList = New UserControl_SemItemList
                    objUserControl_SemList.initialize_Simple(objSemItems_Selected(0), objLocalConfig.Globals)
            End Select
            set_Controls_Applyable()
            objUserControl_SemList.Dock = DockStyle.Fill
            SplitContainer1.Panel2.Controls.Clear()
            SplitContainer1.Panel2.Controls.Add(objUserControl_SemList)
        Else
            If objModule.loaded_Module.start_Module_With_Result(boolApplyable) = True Then
                If boolApplyable = True Then
                    GUID_Type_Selected = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    boolSemItems = True
                    objSemItems_Selected = objModule.loaded_Module.SemItmes_Result
                
                    Me.Hide()
                    DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

        End If

    End Sub
    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_SemManager(New clsGlobals)
        initialize()

    End Sub

    Public Sub New(ByVal ConnectionString_User As String)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Dim objGlobals As New clsGlobals
        objGlobals.set_UserDB(ConnectionString_User)
        objLocalConfig = New clsLocalConfig_SemManager(objGlobals)

        initialize()

    End Sub
    Public Sub New(ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_SemManager(Globals)
        initialize()
       
    End Sub

    Public Sub New(ByVal SemItem As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Start = SemItem
        objLocalConfig = New clsLocalConfig_SemManager(Globals)
        initialize()
    End Sub

    Private Sub initialize()
        objSplashScreen = New SplashScreen_Main
        Application.DoEvents()
        objSplashScreen.Show()
        objSplashScreen.Refresh()


        set_DBConnection()
        If Not objSemItem_Start Is Nothing Then
            objUserControl_TypeTree = New UserControl_TypeTree(objSemItem_Start, objLocalConfig.Globals)

        Else
            objUserControl_TypeTree = New UserControl_TypeTree(objLocalConfig.Globals)

        End If

        objUserControl_TypeTree.Dock = DockStyle.Fill
        get_Modules()
        set_Controls()
        fill_ComboDatabase()

    End Sub

    Private Sub get_Modules()
        Dim objModule As clsModule
        objLocalConfig.Globals.get_Modules(objLocalConfig.Globals)
        configure_Module_Combo()
        

        
    End Sub
    Private Sub configure_Module_Combo()

        ToolStripComboBox_Modules.ComboBox.Items.Clear()
        If Not objLocalConfig.Globals.loaded_Modules Is Nothing Then
            For Each objModule In objLocalConfig.Globals.loaded_Modules
                If objModule.Active = True And objModule.Valid = True Then

                    ToolStripComboBox_Modules.Items.Add(objModule)
                    ToolStripComboBox_Modules.ComboBox.ValueMember = "GUID_LoadedModule"
                    ToolStripComboBox_Modules.ComboBox.DisplayMember = "Name_LoadedModule"

                End If
            Next
        End If
    End Sub

    Private Sub fill_ComboDatabase()
        Dim i As Integer
        objDRC_Databases = chngtblA_DB.GetData().Rows

        For i = 0 To objDRC_Databases.Count - 1
            ToolStripComboBox_Databases.Items.Add(objDRC_Databases(i))
        Next
        ToolStripComboBox_Databases.ComboBox.DisplayMember = "Name_DB"
        ToolStripComboBox_Databases.ComboBox.ValueMember = "GUID_DB"
        
    End Sub

    Private Function set_StartDB(ByVal objDR_Database As DataRow) As clsSemItem
        Dim objSemItem_LogState As clsSemItem

        objSemItem_LogState = objLocalConfig.Globals.LogState_Success

        Return objSemItem_LogState
    End Function
    Private Sub set_Controls_Applyable()
        objUserControl_TypeTree.Applyable = boolApplyable
        If Not objUserControl_SemList Is Nothing Then
            objUserControl_SemList.Applyable = boolApplyable
        End If
    End Sub

    Private Sub set_Controls()
        SplitContainer1.Panel1.Controls.Clear()
        SplitContainer1.Panel1.Controls.Add(objUserControl_TypeTree)

    End Sub

    Private Sub set_DBConnection()
        ToolStripStatusLabel_DB.Text = objLocalConfig.Globals.DB_Path_User
        chngtblA_DB.Connection = objLocalConfig.Connection_Config

    End Sub


    Private Sub ToolStripComboBox_Modules_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_Modules.SelectedIndexChanged
        Dim objModule As clsModule
        objModule = ToolStripComboBox_Modules.SelectedItem
        objModule.loaded_Module.execute_Module()

    End Sub

    Private Sub ConfigureActivationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigureActivationToolStripMenuItem.Click
        Dim objFrmModule As New frmModule(objLocalConfig.Globals)
        objFrmModule.ShowDialog(Me)
        configure_Module_Combo()
    End Sub

    Private Sub ModuleViewToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModuleViewToolStripMenuItem.CheckStateChanged
        boolModuleView = ModuleViewToolStripMenuItem.Checked
    End Sub

    
    
    Private Sub frmSemManager_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not objSplashScreen Is Nothing Then
            objSplashScreen.Close()
            objSplashScreen = Nothing
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        objSplashScreen = New SplashScreen_Main
        objSplashScreen.ShowDialog(Me)

    End Sub

    Private Sub ToolStripComboBox_Databases_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_Databases.SelectedIndexChanged
        Dim objSemItem_Result As clsSemItem
        Dim objDR_Database As DataRow
        Dim strConnectionString_User As String

        objDR_Database = ToolStripComboBox_Databases.SelectedItem
        objSemItem_Result = set_StartDB(objDR_Database)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Die Startdatenbank konnte nicht gesetzt werden!", MsgBoxStyle.Exclamation)
        End If
        strConnectionString_User = objLocalConfig.Globals.get_DB_ConnectionString(objLocalConfig.Globals.Server_Name, objDR_Database.Item("Name_DB"))

        objFrm_SemManager = New frmSemManager(strConnectionString_User)
        objFrm_SemManager.Show()
    End Sub

    Private Sub ToolStripComboBox_Databases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_Databases.Click

    End Sub

    Private Sub ToolStripButton_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Search.Click
        If Not ToolStripTextBox_Search.Text = "" Then
            objFrmSearchResult = New frmSearchResult(objLocalConfig.Globals, ToolStripTextBox_Search.Text)
            objFrmSearchResult.Show()

        Else
            MsgBox("Geben Sie bitte etwas ein, was gesucht werden kann!", MsgBoxStyle.Information)
        End If
    End Sub
End Class
