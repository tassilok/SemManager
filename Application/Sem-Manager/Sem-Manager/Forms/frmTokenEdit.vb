Public Class frmTokenEdit
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    'Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter
    Private semfuncA_Token_Path As New ds_TokenTableAdapters.semfunc_Token_PathTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter

    Private WithEvents objUserControl_TokenTree As UserControl_TokenTree
    Private WithEvents objUserControl_SemItemList As New UserControl_SemItemList
    Private objUserControl_ModuleEdit As UserControl_ModuleEdit

    Private objLocalConfig As clsLocalConfig_TokenTree

    Private objTokenEdit_Navigation As clsTokenEdit_Navigation
    Private objSemClipboard As clsSemClipboard

    Private boolApplyable As Boolean
    Private boolPChange_Name As Boolean
    Private boolSaveName_allways As Boolean

    Public Property enableModuleView As Boolean
        Get
            Return ModuleViewToolStripMenuItem.Checked
        End Get
        Set(ByVal value As Boolean)
            ModuleViewToolStripMenuItem.Checked = value
        End Set
    End Property

    Public Property Applyable() As Boolean
        Get
            Return boolApplyable
        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
        End Set
    End Property

    Public Sub SemItemList_Attributes_Changed() Handles objUserControl_SemItemList.Attributes_Changed
        objUserControl_TokenTree.get_Attributes()
    End Sub

    Public Sub TokenTree_selected_SemItem(ByVal objSemItem As clsSemItem) Handles objUserControl_TokenTree.selected_Node

        objUserControl_SemItemList.Dock = DockStyle.Fill
        objUserControl_SemItemList.initialize_Complex(objSemItem, objLocalConfig.Globals)
        objUserControl_SemItemList.ModuleView = ModuleViewToolStripMenuItem.Checked
        SplitContainer1.Panel2.Controls.Add(objUserControl_SemItemList)
    End Sub

    Public Sub New(ByVal SemItem As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_TokenTree(Globals)
        objLocalConfig.Connection_DB = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)

        objTokenEdit_Navigation = New clsTokenEdit_Navigation(SemItem, objLocalConfig.Globals)

        initialize()
    End Sub

    Public Sub New(ByRef DataGridView_Base As DataGridView, ByVal intRowID As Integer, ByVal objSemItem As clsSemItem, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_TokenTree(Globals)
        objLocalConfig.Connection_DB = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)

        objTokenEdit_Navigation = New clsTokenEdit_Navigation(DataGridView_Base, objSemItem, intRowID, objLocalConfig.Globals)

        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
        set_Token()
        fill_Combo_Modules()
    End Sub


    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB
        'semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB
        semfuncA_Token_Path.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB

        objSemClipboard = New clsSemClipboard(objLocalConfig.Globals)
    End Sub

    Private Sub set_Token()
        Dim objDRC_Token As DataRowCollection
        Dim objDRC_ObjectReference As DataRowCollection

        objDRC_Token = semtblA_Token.GetData_Token_By_GUID(objTokenEdit_Navigation.SemItem_Active.GUID).Rows
        If objTokenEdit_Navigation.SemItem_Active.Rel_ObjectReference = True Then

            objDRC_ObjectReference = semtblA_Token.GetData_Token_By_GUID(objTokenEdit_Navigation.SemItem_Active.GUID_Related).Rows
            If objDRC_ObjectReference.Count > 0 Then
                objTokenEdit_Navigation.SemItem_Active.GUID = objDRC_ObjectReference(0).Item("GUID_Token")
                objTokenEdit_Navigation.SemItem_Active.Name = objDRC_ObjectReference(0).Item("Name_Token")
                objTokenEdit_Navigation.SemItem_Active.GUID_Parent = objDRC_ObjectReference(0).Item("GUID_Type")
                objTokenEdit_Navigation.SemItem_Active.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            Else
                MsgBox("Das referenzierte Token ist nicht mehr vorhanden", MsgBoxStyle.Exclamation)
                Me.Close()
            End If


        End If

        Me.ToolStripTextBox_GUID.Text = objTokenEdit_Navigation.SemItem_Active.GUID.ToString
        Me.ToolStripTextBox_Name.Text = objTokenEdit_Navigation.SemItem_Active.Name
        Me.ToolStripStatusLabel_DB.Text = objLocalConfig.Globals.DB_Path_User
        ToolStripLabel_PosCount.Text = objTokenEdit_Navigation.DataPos.Row & "/" & objTokenEdit_Navigation.DataPos.Count
        Me.Text = semfuncA_Token_Path.Path_By_GUID(objTokenEdit_Navigation.SemItem_Active.GUID, objTokenEdit_Navigation.SemItem_Active.Name, objTokenEdit_Navigation.SemItem_Active.GUID_Parent).ToString

        objUserControl_TokenTree = New UserControl_TokenTree(objTokenEdit_Navigation, objLocalConfig.Globals)
        objUserControl_TokenTree.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Clear()
        SplitContainer1.Panel1.Controls.Add(objUserControl_TokenTree)
    End Sub

    Private Sub ToolStripButton_Nav_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Nav_Next.Click
        If objTokenEdit_Navigation.DataPos.Row < objTokenEdit_Navigation.DataPos.Count Then
            objTokenEdit_Navigation.Next_Sem()
            set_Token()
            
        End If
    End Sub

    Private Sub ToolStripButton_Nav_First_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Nav_First.Click
        If objTokenEdit_Navigation.DataPos.Row > 0 Then
            objTokenEdit_Navigation.First_Sem()
            set_Token()
        End If
    End Sub

    Private Sub ToolStripButton_Nav_Previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Nav_Previous.Click
        If objTokenEdit_Navigation.DataPos.Row > 0 Then
            objTokenEdit_Navigation.Previous_Sem()
            set_Token()
        End If
    End Sub

    Private Sub ToolStripButton_Nav_Last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Nav_Last.Click
        If objTokenEdit_Navigation.DataPos.Row < objTokenEdit_Navigation.DataPos.Count Then
            objTokenEdit_Navigation.Last_Sem()
            set_Token()

        End If
    End Sub

    Private Sub ToolStripTextBox_Name_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Name.Click

    End Sub

    Private Sub ToolStripTextBox_Name_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Name.DoubleClick
        If ToolStripTextBox_Name.ReadOnly = True Then
            ToolStripTextBox_Name.ReadOnly = False
        Else
            ToolStripTextBox_Name.ReadOnly = True
        End If
    End Sub

    Private Sub ToolStripTextBox_Name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox_Name.KeyDown
        Select Case e.KeyCode
            Case Keys.Return, Keys.Enter
                If ToolStripTextBox_Name.ReadOnly = False Then
                    Timer_Name.Stop()
                    save_Name()
                End If
                ToolStripTextBox_Name.ReadOnly = True
        End Select
    End Sub

    Private Sub ToolStripTextBox_Name_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Name.Leave
        If ToolStripTextBox_Name.ReadOnly = False Then
            Timer_Name.Stop()
            save_Name()
        End If
        
    End Sub

    Private Sub ToolStripTextBox_Name_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Name.TextChanged
        Timer_Name.Stop()
        Timer_Name.Start()
    End Sub

    Private Sub Timer_Name_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Name.Tick
        Timer_Name.Stop()
        save_Name()

    End Sub

    Private Sub save_Name()
        Dim objDRC_Token As DataRowCollection

        If boolPChange_Name = False And ToolStripTextBox_Name.ReadOnly = False Then
            objDRC_Token = semtblA_Token.GetData_Token_By_GUID(objTokenEdit_Navigation.SemItem_Active.GUID).Rows
            If objDRC_Token.Count > 0 Then
                If Not ToolStripTextBox_Name.Text = "" Then
                    If objDRC_Token(0).Item("Name_Token") <> ToolStripTextBox_Name.Text Then
                        objDRC_Token = semprocA_DBWork_Save_Token.GetData(objDRC_Token(0).Item("GUID_Token"), ToolStripTextBox_Name.Text, objDRC_Token(0).Item("GUID_Type"), boolSaveName_allways).Rows


                        If objDRC_Token(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Exists.GUID Then
                            ToolStripTextBox_Name.BackColor = Color.Yellow
                        ElseIf objDRC_Token(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                            ToolStripTextBox_Name.BackColor = Nothing
                        ElseIf objDRC_Token(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then

                        Else
                            MsgBox("Beim Umbenennen ist ein Fehler unterlaufen!", MsgBoxStyle.Critical)
                            objDRC_Token = semtblA_Token.GetData_Token_By_GUID(objTokenEdit_Navigation.SemItem_Active.GUID).Rows
                            If objDRC_Token.Count > 0 Then
                                boolPChange_Name = True
                                ToolStripTextBox_Name.Text = objDRC_Token(0).Item("Name_Token")
                                ToolStripTextBox_Name.ReadOnly = True
                                boolPChange_Name = False
                            Else
                                MsgBox("Das Token existiert nicht mehr!", MsgBoxStyle.Critical)
                                Me.Close()
                            End If
                        End If
                    End If

                Else
                    MsgBox("Der Name darf nicht leer sein!", MsgBoxStyle.Exclamation)
                    boolPChange_Name = True
                    ToolStripTextBox_Name.Text = objDRC_Token(0).Item("Name_Token")
                    ToolStripTextBox_Name.ReadOnly = True
                    boolPChange_Name = False
                End If
            Else
                MsgBox("Das Token existiert nicht mehr!", MsgBoxStyle.Critical)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ModuleViewToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModuleViewToolStripMenuItem.CheckStateChanged
        If Not objUserControl_SemItemList Is Nothing Then
            objUserControl_SemItemList.ModuleView = ModuleViewToolStripMenuItem.Checked
        End If
    End Sub

    
    Private Sub ModuleViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuleViewToolStripMenuItem.Click

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim objDRC_LogState As DataRowCollection
        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objTokenEdit_Navigation.SemItem_Active.GUID).Rows
        Select Case objDRC_LogState(0).Item("GUID_Token")
            Case objLocalConfig.Globals.LogState_Delete.GUID
                Me.Close()
            Case objLocalConfig.Globals.LogState_Relation.GUID
                MsgBox("Das Token kann leider nicht gelöscht werden. Es gibt noch Beziehungen, die entfernt werden müssen!", MsgBoxStyle.Exclamation)
            Case objLocalConfig.Globals.LogState_Error.GUID
                MsgBox("Das Token kann leider nicht gelöscht werden. Es ist ein Fehler unterlaufen!", MsgBoxStyle.Critical)
                Me.Close()


        End Select
    End Sub
 


    Private Sub fill_Combo_Modules()
        Dim objSemItem_Type As New clsSemItem
        ToolStripComboBox_ModuleEdit.Items.Clear()

        objSemItem_Type.GUID = objTokenEdit_Navigation.SemItem_Active.GUID_Parent
        If Not objLocalConfig.Globals.loaded_Modules Is Nothing Then
            If objLocalConfig.Globals.loaded_Modules.Count > 0 Then
                For Each objModule In objLocalConfig.Globals.loaded_Modules
                    If objModule.Active = True And objModule.Valid = True Then
                        If objModule.Object_OK(objSemItem_Type) = True Then

                            If objModule.loaded_Module.TokenEdit = True Then

                                ToolStripComboBox_ModuleEdit.Items.Add(objModule)
                                ToolStripComboBox_ModuleEdit.ComboBox.ValueMember = "GUID_LoadedModule"
                                ToolStripComboBox_ModuleEdit.ComboBox.DisplayMember = "Name_LoadedModule"
                            End If


                        End If
                    End If


                Next
            End If
        End If
    End Sub

    Private Sub ToolStripComboBox_ModuleEdit_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_ModuleEdit.DropDownClosed
        Dim objModule As clsModule
        Dim objSemItem_Token As clsSemItem

        objModule = ToolStripComboBox_ModuleEdit.SelectedItem
        If Not objModule Is Nothing Then
            objSemItem_Token = objModule.loaded_Module.edit_SemItem(objTokenEdit_Navigation.SemItem_Active, Me)

        End If
    End Sub

    Private Sub ToClipboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToClipboardToolStripMenuItem.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objSemClipboard.addToClipboard(objTokenEdit_Navigation.SemItem_Active)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Das Token konnte leider nicht in die Zwischenablage kopiert werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class