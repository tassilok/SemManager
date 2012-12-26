Public Class frmSemManager_BU
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private procA_TokenRel_With_Or As New ds_TokenTableAdapters.proc_TokenRel_With_OrTableAdapter
    Private procT_TokenRel_With_Or As New ds_Token.proc_TokenRel_With_OrDataTable
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private funcT_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttribute.func_TokenAttribute_Named_By_GUIDTokenDataTable

    Private WithEvents objUserControl_TypeTree As UserControl_TypeTree
    Private WithEvents objUserControl_SemItemList_TokenList As UserControl_SemItemList
    Private WithEvents objUserControl_TokenTree As UserControl_TreeOfToken
    Private WithEvents objUserControl_SemItemList_Attributes As UserControl_SemItemList
    Private WithEvents objUserControl_SemItemList_RelationTypes As UserControl_SemItemList

    Private objDLG_Attribute_Int As dlgAttribute_Int

    Private objSplashScreen As New SplashScreen_Main

    Private objLocalConfig As clsLocalConfig_SemManager

    Private objFrmSemManager_BU As frmSemManager_BU

    Private objTransaction_TokenRel As clsTransaction_TokenRel
    Private objTransaction_TokenAttribute As clsTransaction_TokenAttribute

    Private objSemClipboard As clsSemClipboard

    Private objSemItem_Token As New clsSemItem

    Private objSemItem_Direction_LeftRight As New clsSemItem
    Private objSemItem_Direction_RightLeft As New clsSemItem

    Private objSemItem_Token_Att As clsSemItem
    Private objSemItem_Attribute As clsSemItem

    Private objSemItem_Token_Left As clsSemItem
    Private objSemItem_RelationType As clsSemItem
    Private objSemItem_Right As clsSemItem

    Private objSemItem_Token_ForAtt As clsSemItem

    Private objSemItem_Token_Thread1 As clsSemItem
    Private objSemItem_Token_Thread2 As clsSemItem

    Private objThread_TokenRelation As Threading.Thread
    Private objThread_TokenAttribute As Threading.Thread

    Private boolTokenAttribute As Boolean
    Private boolTokenRel As Boolean

    Private strTokRelFilter As String


    Private boolApplyable As Boolean

    Private Sub applied_Type() Handles objUserControl_TypeTree.Applyied_Item
        Dim objSemItem_Result As clsSemItem
        objSemItem_Right = objUserControl_TypeTree.SemItem_Selected
        objSemItem_Result = save_Relation()
        If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            
            get_TokenRelation(objSemItem_Token)
        Else
            MsgBox("Die Beziehung konnte nicht hergestellt werden!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub applied_Attribute() Handles objUserControl_SemItemList_Attributes.Applied_Item
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        If objUserControl_SemItemList_Attributes.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_SemItemList_Attributes.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            objSemItem_Attribute = New clsSemItem
            objSemItem_Attribute.GUID = objDRV_Selected.Item("GUID_Attribute")
            objSemItem_Attribute.Name = objDRV_Selected.Item("Name_Attribute")
            objSemItem_Attribute.GUID_Type = objDRV_Selected.Item("GUID_AttributeType")

            save_TokenAttribute()
        Else
            MsgBox("Bitte nur einen Attribut auswählen!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub applied_RelationType() Handles objUserControl_SemItemList_RelationTypes.Applied_Item
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem
        If objUserControl_SemItemList_RelationTypes.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_SemItemList_RelationTypes.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_RelationType = New clsSemItem
            objSemItem_RelationType.GUID = objDRV_Selected.Item("GUID_RelationType")
            objSemItem_RelationType.Name = objDRV_Selected.Item("Name_RelationType")
            objSemItem_RelationType.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

            objSemItem_Result = save_Relation()
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Die Beziehung konnte nicht hergestellt werden!", MsgBoxStyle.Exclamation)
            ElseIf objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                get_TokenRelation(objSemItem_Token)
            End If
        Else
            MsgBox("Bitte nur einen RelationType auswählen!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub applied_Token() Handles objUserControl_SemItemList_TokenList.Applied_Item
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim intToDo As Integer
        Dim intDone As Integer
        Dim objSemItem_Result As clsSemItem

        If objUserControl_SemItemList_TokenList.DataGridViewRowCollection_Selected.Count > 0 Then
            intToDo = objUserControl_SemItemList_TokenList.DataGridViewRowCollection_Selected.Count
            intDone = 0
            For Each objDGVR_Selected In objUserControl_SemItemList_TokenList.DataGridViewRowCollection_Selected
                objDGVR_Selected = objUserControl_SemItemList_TokenList.DataGridViewRowCollection_Selected(0)
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                objSemItem_Right = New clsSemItem
                objSemItem_Right.GUID = objDRV_Selected.Item("GUID_Token")
                objSemItem_Right.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_Right.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                objSemItem_Right.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = save_Relation()
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If
            Next
            If intDone < intToDo Then
                MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Beziehungen hergestellt werden!", MsgBoxStyle.Exclamation)
            End If
            get_TokenRelation(objSemItem_Token)
        End If
    End Sub

    Private Sub selected_TokenTree(ByVal SemItem_Node As clsSemItem) Handles objUserControl_TokenTree.selected_Node
        objUserControl_SemItemList_TokenList.select_Row(SemItem_Node.GUID)
        
    End Sub

    Private Sub TypeTree_Selection_Changed() Handles objUserControl_TypeTree.selected_Item
        Dim objSemItem_Selected
        Dim boolModule As Boolean = False
        Dim objModules() As clsModule
        Dim objModule As clsModule
        Dim objSemItems_Selected() As clsSemItem
        Dim GUID_Type_Selected As Guid
        Dim boolSemItems As Boolean
        Dim objSemItem_Result As clsSemItem
        Dim intDone As Integer
        Dim intToDo As Integer

        objSemItem_Selected = objUserControl_TypeTree.SemItem_Selected
        objSemItem_Token = Nothing

        
        If ToolStripButton_Token.Checked = True Then
            If ToolStripButton_ModuleView.Checked = True Then

                objModules = objLocalConfig.Globals.loaded_Modules
                If Not objModules Is Nothing Then
                    For Each objModule In objLocalConfig.Globals.loaded_Modules
                        If objModule.Active = True And objModule.Valid = True Then
                            If objModule.Object_OK(objSemItem_Selected) = True Then
                                boolModule = True
                                Exit For
                            End If
                        End If
                    Next

                End If


                If boolModule = True Then
                    boolApplyable = True
                    If objModule.loaded_Module.start_Module_With_Result(boolApplyable) = True Then

                        If boolApplyable = True Then
                            GUID_Type_Selected = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItems_Selected = objModule.loaded_Module.SemItmes_Result
                            If Not objSemItems_Selected Is Nothing Then
                                intToDo = objSemItems_Selected.Count
                                intDone = 0
                                For Each objSemItem_Right In objSemItems_Selected
                                    objSemItem_Result = save_Relation()
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        intDone = intDone + 1
                                    End If
                                Next
                                If intDone < intToDo Then
                                    MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Beziehungen hergestellt werden!", MsgBoxStyle.Exclamation)
                                End If
                                get_TokenRelation(objSemItem_Token)
                            End If

                        End If
                    End If
                End If
            End If


            objUserControl_SemItemList_TokenList.clear_List()
            objUserControl_SemItemList_TokenList.initialize_Simple(objSemItem_Selected, objLocalConfig.Globals)
            objUserControl_SemItemList_TokenList.ModuleView = ToolStripButton_ModuleView.Checked
            objUserControl_TokenTree.initialize(objSemItem_Selected)
            If Not objSemItem_Token_Left Is Nothing Then
                objUserControl_SemItemList_TokenList.SemItem_Other = objSemItem_Token_Left
            End If
            If Not objSemItem_RelationType Is Nothing Then
                objUserControl_SemItemList_TokenList.SemItem_RelationType = objSemItem_RelationType
            End If
        Else
            objUserControl_SemItemList_TokenList.clear_List()
            procT_TokenRel_With_Or.Clear()
            funcT_TokenAttribute_Named_By_GUIDToken.Clear()
            objUserControl_TokenTree.initialize(Nothing)
        End If


    End Sub

    Private Sub ToolStripButton_Filter_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Filter.CheckStateChanged
        If ToolStripButton_Filter.Checked = True Then
            SplitContainer_Filter_Body.Panel1Collapsed = False
        Else
            SplitContainer_Filter_Body.Panel1Collapsed = True
        End If
    End Sub


    Private Sub ToolStripButton_Types_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Types.CheckStateChanged
        If ToolStripButton_Types.Checked = True Then
            SplitContainer_TypeToken.Panel1Collapsed = False
        Else
            SplitContainer_TypeToken.Panel1Collapsed = True
        End If
    End Sub

    Private Sub ToolStripButton_Token_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Token.CheckStateChanged
        If ToolStripButton_Token.Checked = True Then
            SplitContainer_TypeToken.Panel2Collapsed = False
        Else
            SplitContainer_TypeToken.Panel2Collapsed = True
        End If
    End Sub


    Private Sub ToolStripButton_AttribRel_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AttribRel.CheckStateChanged
        If ToolStripButton_AttribRel.Checked = True Then
            SplitContainer_AttribRelTokenRel.Panel1Collapsed = False
        Else
            SplitContainer_AttribRelTokenRel.Panel1Collapsed = True
        End If
    End Sub

    Private Sub ToolStripButton_TokenRel_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_TokenRel.CheckStateChanged
        If ToolStripButton_TokenRel.Checked = True Then
            SplitContainer_AttribRelTokenRel.Panel2Collapsed = False
        Else
            SplitContainer_AttribRelTokenRel.Panel2Collapsed = True
        End If
    End Sub

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        objLocalConfig = New clsLocalConfig_SemManager(New clsGlobals)

        set_DBConnection()

        initialize()
    End Sub

    Public Sub New(ByVal strConnectionString As String)
        Dim objGlobals As New clsGlobals

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.


        objGlobals.set_UserDB(strConnectionString)
        objLocalConfig = New clsLocalConfig_SemManager(objGlobals)

        set_DBConnection()

        initialize()
    End Sub

    Private Sub set_DBConnection()

        
        semtblA_Token.Connection = New Data.SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_System)

        objTransaction_TokenRel = New clsTransaction_TokenRel(objLocalConfig.Globals)
        objSemClipboard = New clsSemClipboard(objLocalConfig.Globals)
    End Sub


    Private Sub initialize()
        Dim objSemItem_SemItemList_Attribute As New clsSemItem
        Dim objSemItem_SemItemList_RelationType As New clsSemItem
        Dim objDRC_Direction As DataRowCollection

        objSplashScreen = New SplashScreen_Main
        Application.DoEvents()
        objSplashScreen.Show()
        objSplashScreen.Refresh()


        ToolStripButton_Filter.Checked = False

        get_Modules()

        objDRC_Direction = semtblA_Token.GetData_Token_By_GUID(objLocalConfig.Globals.GUID_Direction_LeftRight).Rows
        objSemItem_Direction_LeftRight.GUID = objLocalConfig.Globals.GUID_Direction_LeftRight
        objSemItem_Direction_LeftRight.Name = objDRC_Direction(0).Item("Name_Token")
        objSemItem_Direction_LeftRight.GUID_Parent = objDRC_Direction(0).Item("GUID_Type")
        objSemItem_Direction_LeftRight.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objDRC_Direction = semtblA_Token.GetData_Token_By_GUID(objLocalConfig.Globals.GUID_Direction_RightLeft).Rows
        objSemItem_Direction_RightLeft.GUID = objLocalConfig.Globals.GUID_Direction_RightLeft
        objSemItem_Direction_RightLeft.Name = objDRC_Direction(0).Item("Name_Token")
        objSemItem_Direction_RightLeft.GUID_Parent = objDRC_Direction(0).Item("GUID_Type")
        objSemItem_Direction_RightLeft.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        semtblA_Token.Connection = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)

        ToolStripStatusLabel_Database.Text = objLocalConfig.Globals.DB_Name_User & "@" & objLocalConfig.Globals.Server_Name
        objUserControl_TypeTree = New UserControl_TypeTree(objLocalConfig.Globals, False)

        objUserControl_TypeTree.Dock = DockStyle.Fill
        SplitContainer_TypeToken.Panel1.Controls.Add(objUserControl_TypeTree)

        objUserControl_SemItemList_TokenList = New UserControl_SemItemList
        objUserControl_SemItemList_TokenList.Dock = DockStyle.Fill
        objUserControl_SemItemList_TokenList.Applyable = True
        SplitContainer_Token.Panel1.Controls.Add(objUserControl_SemItemList_TokenList)

        objUserControl_TokenTree = New UserControl_TreeOfToken(objLocalConfig.Globals)
        objUserControl_TokenTree.Dock = DockStyle.Fill
        SplitContainer_Token.Panel2.Controls.Add(objUserControl_TokenTree)


        objSemItem_SemItemList_Attribute.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
        objUserControl_SemItemList_Attributes = New UserControl_SemItemList
        objUserControl_SemItemList_Attributes.Applyable = True
        objUserControl_SemItemList_Attributes.Dock = DockStyle.Fill
        Panel_Attributes.Controls.Add(objUserControl_SemItemList_Attributes)
        objUserControl_SemItemList_Attributes.initialize_Simple(objSemItem_SemItemList_Attribute, objLocalConfig.Globals)

        objSemItem_SemItemList_RelationType.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
        objUserControl_SemItemList_RelationTypes = New UserControl_SemItemList
        objUserControl_SemItemList_RelationTypes.Applyable = True
        objUserControl_SemItemList_RelationTypes.Dock = DockStyle.Fill
        Panel_RelationTypes.Controls.Add(objUserControl_SemItemList_RelationTypes)
        objUserControl_SemItemList_RelationTypes.initialize_Simple(objSemItem_SemItemList_RelationType, objLocalConfig.Globals)

        objSplashScreen.Close()
    End Sub

    Private Sub get_Modules()
        objLocalConfig.Globals.get_Modules(objLocalConfig.Globals)
    End Sub

    Private Sub objUserControl_SemItemList_Token_Selection_Changed() Handles objUserControl_SemItemList_TokenList.Selection_Changed
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        objSemItem_Token = Nothing

        If objUserControl_SemItemList_TokenList.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_SemItemList_TokenList.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objUserControl_TokenTree.find_Node(objDRV_Selected.Item("GUID_Token"))
            objSemItem_Token = New clsSemItem
            objSemItem_Token.GUID = objDRV_Selected.Item("GUID_Token")
            objSemItem_Token.Name = objDRV_Selected.Item("Name_Token")
            objSemItem_Token.GUID_Parent = objDRV_Selected.Item("GUID_Type")
            objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            get_TokenRelation(objSemItem_Token)
            get_TokenAttribute(objSemItem_Token)



        Else
            procT_TokenRel_With_Or.Clear()
            funcT_TokenAttribute_Named_By_GUIDToken.Clear()
        End If
    End Sub

    Private Sub get_TokenAttribute(ByVal objSemItem_Token As clsSemItem)
        objSemItem_Token_Thread2 = objSemItem_Token

        Timer_TokenAttribute.Enabled = False
        DataGridView_TokenAtt.DataSource = Nothing
        ToolStripProgressBar_TokenAttribiute.Value = 0
        Try
            objThread_TokenAttribute.Abort()
        Catch ex As Exception

        End Try
        If Not objSemItem_Token_Thread2 Is Nothing Then
            funcT_TokenAttribute_Named_By_GUIDToken.Clear()
            ToolStripButton_DelTokenAtt.Enabled = False
            ContextMenuStrip_TokAtt.Enabled = False
            objThread_TokenAttribute = New Threading.Thread(AddressOf get_TokenAttribute_Thread)
            boolTokenAttribute = False
            Timer_TokenAttribute.Enabled = True

            objThread_TokenAttribute.Start()
        End If
        
    End Sub

    Private Sub get_TokenAttribute_Thread()
        funcA_TokenAttribute_Named_By_GUIDToken.Connection.Close()
        While Not funcA_TokenAttribute_Named_By_GUIDToken.Connection.State = ConnectionState.Closed

        End While
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = New Data.SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)
        funcA_TokenAttribute_Named_By_GUIDToken.Fill(funcT_TokenAttribute_Named_By_GUIDToken, objSemItem_Token_Thread2.GUID)
        boolTokenAttribute = True


    End Sub

    Private Sub get_TokenRelation(ByVal SemItem_Token As clsSemItem)


        Timer_TokenRelation.Stop()
        ToolStripProgressBar_TokenRelation.Value = 0
        DataGridView_Relations.DataSource = Nothing
        Try
            objThread_TokenRelation.Abort()
        Catch ex As Exception

        End Try


        If Not SemItem_Token Is Nothing Then
            objSemItem_Token_Thread1 = objSemItem_Token

            ContextMenuStrip_TokRel.Enabled = False
            ToolStripButton_DelTokenRel.Enabled = False

            objThread_TokenRelation = New Threading.Thread(AddressOf get_TokenRelation_Thread)
            boolTokenRel = False
            Timer_TokenRelation.Enabled = True
            objThread_TokenRelation.Start()
        Else
            procT_TokenRel_With_Or.Clear()
        End If
        ToolStripLabel_RelCount.Text = procT_TokenRel_With_Or.Rows.Count
    End Sub

    Private Sub get_TokenRelation_Thread()

        procA_TokenRel_With_Or.Connection.Close()
        While Not procA_TokenRel_With_Or.Connection.State = ConnectionState.Closed

        End While
        procA_TokenRel_With_Or.Connection = New Data.SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)
        procA_TokenRel_With_Or.Fill(procT_TokenRel_With_Or, _
                                        objSemItem_Token_Thread1.GUID, _
                                        objSemItem_Direction_LeftRight.GUID, _
                                        objSemItem_Direction_LeftRight.Name, _
                                        objSemItem_Direction_RightLeft.GUID, _
                                        objSemItem_Direction_RightLeft.Name, _
                                        objSemItem_Direction_LeftRight.GUID_Parent, _
                                        objLocalConfig.Globals.ObjectReferenceType_Token.GUID, _
                                        objLocalConfig.Globals.ObjectReferenceType_Token.Name)

        boolTokenRel = True
    End Sub

    Private Sub ContextMenuStrip_TokRel_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_TokRel.Opening
        Dim strHeaderText As String

        EditToolStripMenuItem.Enabled = False
        CopyValToolStripMenuItem1.Enabled = False
        SetOrderIDToolStripMenuItem.Enabled = False
        SetRelationTypeToolStripMenuItem.Enabled = False
        ModuleMenuToolStripMenuItem.Enabled = False
        ModuleEditToolStripMenuItem.Enabled = False


        ClearFilterToolStripMenuItem.Enabled = False
        EqualToolStripMenuItem.Enabled = False
        DifferentToolStripMenuItem.Enabled = False
        ContainsToolStripMenuItem.Enabled = False
        ClearFilterToolStripMenuItem.Enabled = False
        GreaterToolStripMenuItem.Enabled = False
        LessThanToolStripMenuItem.Enabled = False
        RelateToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False

        If DataGridView_Relations.SelectedRows.Count > 0 Then
            FilterToolStripMenuItem.Enabled = True
            EditToolStripMenuItem.Enabled = True
            SetRelationTypeToolStripMenuItem.Enabled = True
        End If
        If DataGridView_Relations.SelectedCells.Count >= 1 Then
            strHeaderText = DataGridView_Relations.Columns(DataGridView_Relations.SelectedCells(0).ColumnIndex).HeaderText
            If Not (strHeaderText = "OrderID" Or strHeaderText = "Name_Direction") Then
                ContainsToolStripMenuItem.Enabled = True
            ElseIf strHeaderText = "OrderID" Then
                GreaterToolStripMenuItem.Enabled = True
                LessThanToolStripMenuItem.Enabled = True
                SetOrderIDToolStripMenuItem.Enabled = True
            End If
            EqualToolStripMenuItem.Enabled = True
            DifferentToolStripMenuItem.Enabled = True
            DeleteToolStripMenuItem.Enabled = True



        End If
        If DataGridView_Relations.SelectedRows.Count = 1 Then
            EditToolStripMenuItem.Enabled = True
            SetOrderIDToolStripMenuItem.Enabled = True
            SetRelationTypeToolStripMenuItem.Enabled = True
            ModuleMenuToolStripMenuItem.Enabled = True
            ModuleEditToolStripMenuItem.Enabled = True
        End If

        If DataGridView_Relations.SelectedCells.Count = 1 Then
            EditToolStripMenuItem.Enabled = True
            CopyValToolStripMenuItem1.Enabled = True
            
        End If
        If strTokRelFilter <> "" Then
            ClearFilterToolStripMenuItem.Enabled = True
        End If

        If Not objSemItem_Token Is Nothing Then
            RelateToolStripMenuItem.Enabled = True
        End If


    End Sub

    Private Sub EqualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EqualToolStripMenuItem.Click
        filter_TokRel("=")
    End Sub

    Private Sub filter_TokRel(ByVal strOperator As String, Optional ByVal strValue As String = "")
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDGVC_Selected As DataGridViewCell
        Dim objDGVCO_Selected As DataGridViewColumn

        objDGVC_Selected = DataGridView_Relations.SelectedCells(0)

        objDGVR_Selected = DataGridView_Relations.Rows(objDGVC_Selected.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objDGVCO_Selected = DataGridView_Relations.Columns(objDGVC_Selected.ColumnIndex)

        strTokRelFilter = BindingSource_TokenRel.Filter

        Select Case objDGVCO_Selected.HeaderText
            Case "Name_Direction"
                If Not (strOperator = "<" Or strOperator = ">") Then
                    If strTokRelFilter <> "" Then
                        strTokRelFilter = strTokRelFilter & " AND "
                    End If
                    If strOperator = "NOT" Then
                        strTokRelFilter = strTokRelFilter & " NOT "
                        strOperator = "="
                    End If
                    If Not strOperator = "LIKE" Then

                        strTokRelFilter = strTokRelFilter & "GUID_Direction " & strOperator & " '" & objDRV_Selected.Item("GUID_Direction").ToString & "'"
                    Else
                        strTokRelFilter = strTokRelFilter & "Name_Direction LIKE '%" & strValue.Replace("'", "''") & "'%"
                    End If

                End If


            Case "Name_Token"
                If Not (strOperator = "<" Or strOperator = ">") Then
                    If strTokRelFilter <> "" Then
                        strTokRelFilter = strTokRelFilter & " AND "
                    End If
                    If strOperator = "NOT" Then
                        strTokRelFilter = strTokRelFilter & " NOT "
                        strOperator = "="
                    End If
                    If Not strOperator = "LIKE" Then
                        strTokRelFilter = strTokRelFilter & "Name_Token " & strOperator & " '" & objDRV_Selected.Item("Name_Token") & "'"
                    Else
                        strTokRelFilter = strTokRelFilter & "Name_Token LIKE '%" & strValue.Replace("'", "''") & "%'"
                    End If

                End If


            Case "Name_RelationType"
                If Not (strOperator = "<" Or strOperator = ">") Then
                    If strTokRelFilter <> "" Then
                        strTokRelFilter = strTokRelFilter & " AND "
                    End If
                    If strOperator = "NOT" Then
                        strTokRelFilter = strTokRelFilter & " NOT "
                        strOperator = "="
                    End If
                    If Not strOperator = "LIKE" Then
                        strTokRelFilter = strTokRelFilter & "GUID_RelationType " & strOperator & " '" & objDRV_Selected.Item("GUID_RelationType").ToString & "'"
                    Else
                        strTokRelFilter = strTokRelFilter & "Name_RelationType LIKE '%" & strValue.Replace("'", "''") & "%'"
                    End If

                End If


            Case "Name_Other"
                If Not (strOperator = "<" Or strOperator = ">") Then
                    If strTokRelFilter <> "" Then
                        strTokRelFilter = strTokRelFilter & " AND "
                    End If
                    If strOperator = "NOT" Then
                        strTokRelFilter = strTokRelFilter & " NOT "
                        strOperator = "="
                    End If
                    If Not strOperator = "LIKE" Then
                        strTokRelFilter = strTokRelFilter & "Name_Other " & strOperator & " '" & objDRV_Selected.Item("Name_Other") & "'"
                    Else
                        strTokRelFilter = strTokRelFilter & "Name_Other LIKE '%" & strValue.Replace("'", "''") & "%'"
                    End If

                End If


            Case "Name_Parent_Other"
                If Not (strOperator = "<" Or strOperator = ">") Then
                    If strTokRelFilter <> "" Then
                        strTokRelFilter = strTokRelFilter & " AND "
                    End If
                    If strOperator = "NOT" Then
                        strTokRelFilter = strTokRelFilter & " NOT "
                        strOperator = "="
                    End If
                    If Not strOperator = "LIKE" Then
                        strTokRelFilter = strTokRelFilter & "GUID_Parent_Other " & strOperator & " '" & objDRV_Selected.Item("GUID_Parent_Other").ToString & "'"
                    Else
                        strTokRelFilter = strTokRelFilter & "Name_Parent_Other LIKE '%" & strValue.Replace("'", "''") & "%'"
                    End If

                End If

            Case "OrderID"
                If Not strOperator = "LIKE" Then
                    If strTokRelFilter <> "" Then
                        strTokRelFilter = strTokRelFilter & " AND "
                    End If
                    If strOperator = "NOT" Then
                        strTokRelFilter = strTokRelFilter & " NOT "
                        strOperator = "="
                    End If
                    strTokRelFilter = strTokRelFilter & "OrderID " & strOperator & " " & objDRV_Selected.Item("OrderID") & ""
                End If

        End Select

        BindingSource_TokenRel.Filter = strTokRelFilter
        ToolStripLabel_Filter.Text = strTokRelFilter
        ToolStripLabel_RelCount.Text = DataGridView_Relations.Rows.Count
    End Sub

    Private Sub DifferentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DifferentToolStripMenuItem.Click
        filter_TokRel("NOT")
    End Sub

    Private Sub ContainsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContainsToolStripMenuItem.Click
        Dim strValue As String
        If Not ToolStripTextBox_TokRelContains.Text = "" Then
            strValue = ToolStripTextBox_TokRelContains.Text
            filter_TokRel("LIKE", strValue)
        Else
            MsgBox("Bitte einen Suchstring eineben!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub GreaterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreaterToolStripMenuItem.Click
        filter_TokRel(">")

    End Sub

    Private Sub LessThanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LessThanToolStripMenuItem.Click
        filter_TokRel("<")
    End Sub

    Private Sub ClearFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFilterToolStripMenuItem.Click
        BindingSource_TokenRel.Filter = ""
        strTokRelFilter = BindingSource_TokenRel.Filter

        ToolStripLabel_Filter.Text = ""
        ToolStripLabel_RelCount.Text = DataGridView_Relations.Rows.Count
    End Sub

    Private Sub RelateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelateToolStripMenuItem.Click
        objSemItem_Right = Nothing
        objSemItem_Token_Left = New clsSemItem
        objSemItem_Token_Left.GUID = objSemItem_Token.GUID
        objSemItem_Token_Left.Name = objSemItem_Token.Name
        objSemItem_Token_Left.GUID_Parent = objSemItem_Token.GUID_Parent
        objSemItem_Token_Left.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        save_Relation()
    End Sub
    Private Sub save_TokenAttribute()
        Dim boolRelate As Boolean
        Dim objSemItem_Result As clsSemItem

        boolRelate = True

        If Not objSemItem_Token_Att Is Nothing Then
            ToolStripStatusLabel_TokenAtt_Token.Text = objSemItem_Token_Att.Name
        Else
            ToolStripStatusLabel_TokenAtt_Token.Text = ""
            boolRelate = False
        End If

        If Not objSemItem_Attribute Is Nothing Then
            ToolStripStatusLabel_TokenAtt_Attribute.Text = objSemItem_Attribute.Name
        Else
            ToolStripStatusLabel_TokenAtt_Attribute.Text = ""
            boolRelate = False
        End If

        If boolRelate = True Then
            objTransaction_TokenAttribute = New clsTransaction_TokenAttribute(objLocalConfig.Globals, Me)
            objSemItem_Result = objTransaction_TokenAttribute.save_001_TokenAttribute(objSemItem_Token_Att, _
                                                                                      objSemItem_Attribute)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Attribute = Nothing
                get_TokenAttribute(objSemItem_Token)
                save_TokenAttribute()
            Else
                MsgBox("Das Attribut konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Function save_Relation() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_ForListRelation As New clsSemItem
        Dim objSemItem_Clipboard As clsSemItem
        Dim objDRC_Token As DataRowCollection

        objSemItem_Result = objLocalConfig.Globals.LogState_Success


        If Not objSemItem_Token_Left Is Nothing Then
            objSemItem_ForListRelation.GUID = objSemItem_Token_Left.GUID
            objSemItem_ForListRelation.Name = objSemItem_Token_Left.Name
            objSemItem_ForListRelation.GUID_Parent = objSemItem_Token_Left.GUID_Parent
            objSemItem_ForListRelation.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_ForListRelation.Direction = objSemItem_ForListRelation.Direction_RightLeft

            objUserControl_SemItemList_TokenList.SemItem_Other = objSemItem_ForListRelation
            ToolStripStatusLabel_TokenRelLeft.Text = objSemItem_Token_Left.Name
        Else
            ToolStripStatusLabel_TokenRelLeft.Text = "-"
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        End If


        If Not objSemItem_Right Is Nothing Then
            ToolStripStatusLabel_TokenRelRight.Text = objSemItem_Right.Name
        Else
            objSemItem_Clipboard = objSemClipboard.getFromClipboard(objLocalConfig.Globals.ObjectReferenceType_Token, True)
            If Not objSemItem_Clipboard Is Nothing Then
                objDRC_Token = semtblA_Token.GetData_Token_By_GUID(objSemItem_Clipboard.GUID).Rows
                If objDRC_Token.Count > 0 Then
                    objSemItem_Right = New clsSemItem
                    objSemItem_Right.GUID = objSemItem_Clipboard.GUID
                    objSemItem_Right.Name = objDRC_Token(0).Item("Name_Token")
                    objSemItem_Right.GUID_Parent = objDRC_Token(0).Item("GUID_Type")
                    objSemItem_Right.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                End If
            End If
            If Not objSemItem_Right Is Nothing Then
                ToolStripStatusLabel_TokenRelRight.Text = objSemItem_Right.Name
            Else
                ToolStripStatusLabel_TokenRelRight.Text = "-"
                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            End If
            
        End If

        If Not objSemItem_RelationType Is Nothing Then
            objUserControl_SemItemList_TokenList.SemItem_RelationType = objSemItem_RelationType
            ToolStripStatusLabel_TokenRelRelation.Text = objSemItem_RelationType.Name
        Else
            ToolStripStatusLabel_TokenRelRelation.Text = "-"
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_TokenRel.save_001_TokenRel(objSemItem_Token_Left, _
                                                      objSemItem_RelationType, _
                                                      objSemItem_Right)

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                ToolStripStatusLabel_RelationDone.Text = ToolStripStatusLabel_TokenRelLeft.Text & " / " & _
                    ToolStripStatusLabel_TokenRelRelation.Text & " / " & _
                    ToolStripStatusLabel_TokenRelRight.Text

                objSemItem_Right = Nothing
                save_Relation()
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            End If
        End If
        Return objSemItem_Result
    End Function

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Token_Left As New clsSemItem
        Dim objSemItem_RelationType As New clsSemItem
        Dim objSemItem_Right As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intDone As Integer
        Dim intToDo As Integer

        If MsgBox("Wollen Sie die Beziehungen wirklich entfernen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            intToDo = DataGridView_Relations.SelectedRows.Count
            intDone = 0
            For Each objDGVR_Selected In DataGridView_Relations.SelectedRows
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                objSemItem_RelationType.GUID = objDRV_Selected.Item("GUID_RelationType")
                objSemItem_RelationType.Name = objDRV_Selected.Item("Name_RelationType")
                objSemItem_RelationType.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

                If objDRV_Selected.Item("GUID_Direction") = objSemItem_Direction_LeftRight.GUID Then
                    objSemItem_Token_Left.GUID = objSemItem_Token.GUID
                    objSemItem_Token_Left.Name = objSemItem_Token.Name
                    objSemItem_Token_Left.GUID_Parent = objSemItem_Token.GUID_Parent
                    objSemItem_Token_Left.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Right.GUID = objDRV_Selected.Item("GUID_Other")
                    objSemItem_Right.Name = objDRV_Selected.Item("Name_Other")
                    objSemItem_Right.GUID_Parent = objDRV_Selected.Item("GUID_Parent_Other")
                    objSemItem_Right.GUID_Type = objDRV_Selected.Item("GUID_ItemType")
                Else
                    objSemItem_Token_Left.GUID = objDRV_Selected.Item("GUID_Other")
                    objSemItem_Token_Left.Name = objDRV_Selected.Item("Name_Other")
                    objSemItem_Token_Left.GUID_Parent = objDRV_Selected.Item("GUID_Parent_Other")
                    objSemItem_Token_Left.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                    objSemItem_Right.GUID = objSemItem_Token.GUID
                    objSemItem_Right.Name = objSemItem_Token.Name
                    objSemItem_Right.GUID_Parent = objSemItem_Token.GUID_Parent
                    objSemItem_Right.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                End If

                objSemItem_Result = objTransaction_TokenRel.del_001_TokenRel(objSemItem_Token_Left, _
                                                                                objSemItem_RelationType, _
                                                                                objSemItem_Right)

                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If
            Next

            If intDone < intToDo Then
                MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Beziehungen gelöscht werden!", MsgBoxStyle.Information)
            End If
            get_TokenRelation(objSemItem_Token)
        End If


    End Sub

    Private Sub RelateToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelateToolStripMenuItem1.Click
        objSemItem_Attribute = Nothing
        objSemItem_Token_Att = New clsSemItem
        objSemItem_Token_Att.GUID = objSemItem_Token.GUID
        objSemItem_Token_Att.Name = objSemItem_Token.Name
        objSemItem_Token_Att.GUID_Parent = objSemItem_Token.GUID_Parent
        objSemItem_Token_Att.GUID_Type = objSemItem_Token.GUID_Type

        save_TokenAttribute()
    End Sub

    Private Sub ContextMenuStrip_TokAtt_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_TokAtt.Opening
        EditToolStripMenuItem1.Enabled = False
        RelateToolStripMenuItem1.Enabled = False
        DeleteToolStripMenuItem1.Enabled = False

        If DataGridView_TokenAtt.SelectedRows.Count = 1 Then
            EditToolStripMenuItem1.Enabled = True
        End If

        If DataGridView_TokenAtt.SelectedRows.Count > 0 Then
            DeleteToolStripMenuItem1.Enabled = True
        End If
        If Not objSemItem_Token Is Nothing Then
            RelateToolStripMenuItem1.Enabled = True
        End If
    End Sub

    Private Sub DataGridView_Relations_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Relations.CellMouseDoubleClick
        Dim strHeaderText As String

        strHeaderText = DataGridView_Relations.Columns(e.ColumnIndex).HeaderText
        If strHeaderText = "OrderID" Then
            set_OrderID()
        End If
    End Sub

    Private Sub DataGridView_Relations_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Relations.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_SelParent As New clsSemItem
        Dim objSemItem_Selected As New clsSemItem

        objDGVR_Selected = DataGridView_Relations.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        Select Case objDRV_Selected.Item("GUID_ItemType")
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_Other")
                objSemItem_Selected.Name = objDRV_Selected.Item("Name_Other")
                objSemItem_Selected.GUID_Parent = objDRV_Selected.Item("GUID_Parent_Other")
                objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                If ToolStripButton_AttribRel.Checked = True Then
                    objUserControl_SemItemList_Attributes.filter_View_GUID_Token(objSemItem_Selected.GUID)
                End If


            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_Other")
                objSemItem_Selected.Name = objDRV_Selected.Item("Name_Other")
                objSemItem_Selected.GUID_Parent = objDRV_Selected.Item("GUID_Parent_Other")
                objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

                If ToolStripButton_AttribRel.Checked = True Then
                    objUserControl_SemItemList_RelationTypes.filter_View_GUID_Token(objSemItem_Selected.GUID)
                End If
            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_Other")
                objSemItem_SelParent.GUID = objDRV_Selected.Item("GUID_Parent_Other")
                objUserControl_TypeTree.select_Type(objSemItem_SelParent)
                TypeTree_Selection_Changed()
                objUserControl_SemItemList_TokenList.filter_View_GUID_Token(objSemItem_Selected.GUID)
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objSemItem_Selected.GUID = objDRV_Selected.Item("GUID_Other")
                objSemItem_Selected.Name = objDRV_Selected.Item("Name_Other")
                objSemItem_Selected.GUID_Parent = objDRV_Selected.Item("GUID_Parent_Other")
                objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objUserControl_TypeTree.select_Type(objSemItem_Selected)
        End Select
    End Sub

    Private Sub DataGridView_TokenAtt_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_TokenAtt.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Attribute As clsSemItem
        Dim objSemItem_TokenAttribute As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objDGVR_Selected = DataGridView_TokenAtt.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objSemItem_Attribute = New clsSemItem
        objSemItem_Attribute.GUID = objDRV_Selected.Item("GUID_Attribute")


        objSemItem_TokenAttribute = New clsSemItem
        objSemItem_TokenAttribute.GUID = objDRV_Selected.Item("GUID_TokenAttribute")

        objTransaction_TokenAttribute = New clsTransaction_TokenAttribute(objLocalConfig.Globals, Me)

        Select Case objDRV_Selected.Item("GUID_AttributeType")
            Case objLocalConfig.Globals.AttributeType_Bool.GUID
                objTransaction_TokenAttribute.Value_Bit = objDRV_Selected.Item("VAL_BOOL")
                objSemItem_Attribute.GUID_Type = objLocalConfig.Globals.AttributeType_Bool.GUID
            Case objLocalConfig.Globals.AttributeType_Date.GUID
                objTransaction_TokenAttribute.Value_Date = objDRV_Selected.Item("VAL_DATE")
                objSemItem_Attribute.GUID_Type = objLocalConfig.Globals.AttributeType_Date.GUID
            Case objLocalConfig.Globals.AttributeType_Datetime.GUID
                objTransaction_TokenAttribute.Value_Date = objDRV_Selected.Item("VAL_DATE")
                objSemItem_Attribute.GUID_Type = objLocalConfig.Globals.AttributeType_Datetime.GUID
            Case objLocalConfig.Globals.AttributeType_Int.GUID
                objTransaction_TokenAttribute.Value_Int = objDRV_Selected.Item("VAL_INT")
                objSemItem_Attribute.GUID_Type = objLocalConfig.Globals.AttributeType_Int.GUID
            Case objLocalConfig.Globals.AttributeType_Real.GUID
                objTransaction_TokenAttribute.Value_Real = objDRV_Selected.Item("VAL_REAL")
                objSemItem_Attribute.GUID_Type = objLocalConfig.Globals.AttributeType_Real.GUID
            Case objLocalConfig.Globals.AttributeType_Time.GUID
                objTransaction_TokenAttribute.Value_Date = objDRV_Selected.Item("VAL_TIME")
                objSemItem_Attribute.GUID_Type = objLocalConfig.Globals.AttributeType_Time.GUID
            Case objLocalConfig.Globals.AttributeType_String.GUID
                objTransaction_TokenAttribute.Value_str = objDRV_Selected.Item("VAL_VARCHARMAX")
                objSemItem_Attribute.GUID_Type = objLocalConfig.Globals.AttributeType_String.GUID
            Case objLocalConfig.Globals.AttributeType_Varchar255.GUID
                objTransaction_TokenAttribute.Value_str = objDRV_Selected.Item("VAL_VARCHAR255")
                objSemItem_Attribute.GUID_Type = objLocalConfig.Globals.AttributeType_Varchar255.GUID
        End Select

        objSemItem_Result = objTransaction_TokenAttribute.save_001_TokenAttribute(objSemItem_Token, objSemItem_Attribute, objSemItem_TokenAttribute, objDRV_Selected.Item("OrderID"))
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            get_TokenAttribute(objSemItem_Token)
        ElseIf objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            MsgBox("Der Wert konnte nicht verändert werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_TokenAttribute As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intToDo As Integer
        Dim intDone As Integer

        If MsgBox("Wollen Sie die Beziehungen wirklich entfernen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            intToDo = DataGridView_TokenAtt.SelectedRows.Count
            intDone = 0
            objTransaction_TokenAttribute = New clsTransaction_TokenAttribute(objLocalConfig.Globals, Me)

            For Each objDGVR_Selected In DataGridView_TokenAtt.SelectedRows
                objDRV_Selected = objDGVR_Selected.DataBoundItem

                objSemItem_TokenAttribute.GUID = objDRV_Selected.Item("GUID_TokenAttribute")

                objSemItem_Result = objTransaction_TokenAttribute.del_001_TokenAttribute(objSemItem_TokenAttribute)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If
            Next

            If intDone < intToDo Then
                MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Beziehungen gelöscht werden!", MsgBoxStyle.Exclamation)
            End If

            get_TokenAttribute(objSemItem_Token)
        End If
    End Sub

    Private Sub ToolStripStatusLabel_Database_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel_Database.Click
        Dim objFrmDBSelection As New frmDBSelection(objLocalConfig)
        Dim objSemItem_Result As clsSemItem
        Dim objDR_Database As DataRow
        Dim strConnectionString_User As String

        objFrmDBSelection.ShowDialog(Me)
        If objFrmDBSelection.DialogResult = Windows.Forms.DialogResult.OK Then
            objSemItem_Result = objFrmDBSelection.SemItem_DB
            strConnectionString_User = objLocalConfig.Globals.get_DB_ConnectionString(objLocalConfig.Globals.Server_Name, objSemItem_Result.Name)

            objFrmSemManager_BU = New frmSemManager_BU(strConnectionString_User)
            objFrmSemManager_BU.Show()
        End If
        
    End Sub

    Private Sub CopyValToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyValToolStripMenuItem1.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        If DataGridView_Relations.SelectedCells.Count = 1 Then
            objDGVR_Selected = DataGridView_Relations.Rows(DataGridView_Relations.SelectedCells(0).RowIndex)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            Clipboard.SetDataObject(objDRV_Selected.Item(DataGridView_Relations.SelectedCells(0).ColumnIndex).ToString)
        End If
    End Sub

    Private Sub CopyValToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyValToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        If DataGridView_TokenAtt.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_TokenAtt.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            Select Case objDRV_Selected.Item("GUID_AttributeType")
                Case objLocalConfig.Globals.AttributeType_Bool.GUID
                    Clipboard.SetDataObject(objDRV_Selected.Item("VAL_BOOL").ToString)
                Case objLocalConfig.Globals.AttributeType_Date.GUID, objLocalConfig.Globals.AttributeType_Datetime.GUID
                    Clipboard.SetDataObject(objDRV_Selected.Item("VAL_DATE").ToString)
                Case objLocalConfig.Globals.AttributeType_Int.GUID
                    Clipboard.SetDataObject(objDRV_Selected.Item("VAL_INT").ToString)
                Case objLocalConfig.Globals.AttributeType_Real.GUID
                    Clipboard.SetDataObject(objDRV_Selected.Item("VAL_REAL").ToString)
                Case objLocalConfig.Globals.AttributeType_Time.GUID
                Case objLocalConfig.Globals.AttributeType_Time.GUID
                    Clipboard.SetDataObject(objDRV_Selected.Item("VAL_TIME").ToString)
                Case objLocalConfig.Globals.AttributeType_String.GUID
                    Clipboard.SetDataObject(objDRV_Selected.Item("VAL_VARCHARMAX").ToString)
                Case objLocalConfig.Globals.AttributeType_Varchar255.GUID
                    Clipboard.SetDataObject(objDRV_Selected.Item("VAL_VARCHAR255").ToString)

            End Select
        End If
    End Sub

    Private Sub SetOrderIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetOrderIDToolStripMenuItem.Click
        Dim strHeaderText As String
        strHeaderText = DataGridView_Relations.Columns(DataGridView_Relations.SelectedCells(0).ColumnIndex).HeaderText
        If strHeaderText = "OrderID" Then
            set_OrderID()
        End If

    End Sub

    Private Sub set_OrderID()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Token_Left As New clsSemItem
        Dim objSemItem_Token_Right As New clsSemItem
        Dim objSemItem_RelationType As New clsSemItem
        Dim objSemItem_Result As clsSemItem


        objDGVR_Selected = DataGridView_Relations.Rows(DataGridView_Relations.SelectedCells(0).RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        objDLG_Attribute_Int = New dlgAttribute_Int("OrderID", objLocalConfig.Globals, objDRV_Selected.Item("OrderID"))
        objDLG_Attribute_Int.ShowDialog(Me)
        If objDLG_Attribute_Int.DialogResult = Windows.Forms.DialogResult.OK Then
            If objDRV_Selected.Item("GUID_Direction") = objLocalConfig.Globals.GUID_Direction_LeftRight Then
                objSemItem_Token_Left.GUID = objSemItem_Token.GUID
                objSemItem_Token_Left.Name = objSemItem_Token.Name
                objSemItem_Token_Left.GUID_Parent = objSemItem_Token.GUID_Parent
                objSemItem_Token_Left.GUID_Type = objSemItem_Token.GUID_Type

                objSemItem_Token_Right.GUID = objDRV_Selected.Item("GUID_Other")
                objSemItem_Token_Right.Name = objDRV_Selected.Item("Name_Other")
                objSemItem_Token_Right.GUID_Parent = objDRV_Selected.Item("GUID_Parent_Other")
                objSemItem_Token_Right.GUID_Type = objDRV_Selected.Item("GUID_ItemType")
            Else
                objSemItem_Token_Left.GUID = objDRV_Selected.Item("GUID_Other")
                objSemItem_Token_Left.Name = objDRV_Selected.Item("Name_Other")
                objSemItem_Token_Left.GUID_Parent = objDRV_Selected.Item("GUID_Parent_Other")
                objSemItem_Token_Left.GUID_Type = objDRV_Selected.Item("GUID_ItemType")

                objSemItem_Token_Right.GUID = objSemItem_Token.GUID
                objSemItem_Token_Right.Name = objSemItem_Token.Name
                objSemItem_Token_Right.GUID_Parent = objSemItem_Token.GUID_Parent
                objSemItem_Token_Right.GUID_Type = objSemItem_Token.GUID_Type
            End If






            objSemItem_Token_Right.Level = objDLG_Attribute_Int.Value

            objSemItem_RelationType.GUID = objDRV_Selected.Item("GUID_RelationType")
            objSemItem_RelationType.Name = objDRV_Selected.Item("Name_RelationType")
            objSemItem_RelationType.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

            objSemItem_Result = objTransaction_TokenRel.save_001_TokenRel(objSemItem_Token_Left, _
                                                                        objSemItem_RelationType, _
                                                                        objSemItem_Token_Right)


            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                get_TokenRelation(objSemItem_Token)
            Else
                MsgBox("Die OrderID konnte leider nicht geändert werden!", MsgBoxStyle.Exclamation)
            End If
        End If



    End Sub

    Private Sub SetRelationTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetRelationTypeToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objSemItem_Token_Rel As New clsSemItem
        Dim objSemItem_Other As New clsSemItem

        If Not objSemItem_RelationType Is Nothing Then
            If DataGridView_Relations.SelectedRows.Count > 0 Then
                If MsgBox("Wollen Sie den Beziehungstyp wirklich zu """ & objSemItem_RelationType.Name & """ ändern?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    For Each objDGVR_Selected In DataGridView_Relations.SelectedRows
                        objDRV_Selected = objDGVR_Selected.DataBoundItem

                        objSemItem_Token_Rel.GUID = objSemItem_Token.GUID
                        objSemItem_Token_Rel.Name = objSemItem_Token.Name
                        objSemItem_Token_Rel.GUID_Parent = objSemItem_Token.GUID_Parent
                        objSemItem_Token_Rel.GUID_Type = objSemItem_Token.GUID_Type



                        Select Case objDRV_Selected.Item("GUID_ItemType")
                            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                objSemItem_Other.GUID = objDRV_Selected.Item("GUID_Other")
                                objSemItem_Other.Name = objDRV_Selected.Item("Name_Other")
                                objSemItem_Other.GUID_Parent = objDRV_Selected.Item("GUID_Parent_Other")
                                objSemItem_Other.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID, _
                                objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID, _
                                objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                                objSemItem_Other.GUID = objDRV_Selected.Item("GUID_ObjectReference")
                                objSemItem_Other.GUID_Type = objDRV_Selected.Item("GUID_ItemType")
                                objSemItem_Other.Mark = True



                        End Select

                        If objDRV_Selected.Item("GUID_Direction") = objLocalConfig.Globals.GUID_Direction_LeftRight Then
                            objSemItem_Other.Level = objDRV_Selected.Item("OrderID")
                            objTransaction_TokenRel.save_001_TokenRel(objSemItem_Token_Rel, objSemItem_RelationType, objSemItem_Other)

                        Else
                            objSemItem_Token_Rel.Level = objDRV_Selected.Item("OrderID")
                            objTransaction_TokenRel.save_001_TokenRel(objSemItem_Other, objSemItem_RelationType, objSemItem_Token_Rel)
                        End If


                    Next
                    get_TokenRelation(objSemItem_Token)
                End If
                
            End If
        End If

    End Sub

    Private Sub ToolStripStatusLabel_TokenRelRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel_TokenRelRight.Click
        objSemItem_Right = Nothing
        ToolStripStatusLabel_TokenRelRight.Text = "-"
    End Sub

    Private Sub Timer_TokenAttribute_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_TokenAttribute.Tick

        If boolTokenAttribute = True Then
            Timer_TokenAttribute.Enabled = False


            BindingSource_TokenAtt.DataSource = funcT_TokenAttribute_Named_By_GUIDToken
            DataGridView_TokenAtt.DataSource = BindingSource_TokenAtt
            DataGridView_TokenAtt.Columns(0).Visible = False
            DataGridView_TokenAtt.Columns(1).Visible = False
            DataGridView_TokenAtt.Columns(3).Visible = False
            DataGridView_TokenAtt.Columns(4).Visible = False
            DataGridView_TokenAtt.Columns(6).Visible = False
            DataGridView_TokenAtt.Columns(7).Visible = False
            DataGridView_TokenAtt.Columns(8).Visible = False
            DataGridView_TokenAtt.Columns(9).Visible = False
            DataGridView_TokenAtt.Columns(10).Visible = False
            DataGridView_TokenAtt.Columns(11).Visible = False
            DataGridView_TokenAtt.Columns(12).Visible = False
            DataGridView_TokenAtt.Columns(13).Visible = False

            ToolStripButton_DelTokenAtt.Enabled = True
            ContextMenuStrip_TokAtt.Enabled = True

            ToolStripProgressBar_TokenAttribiute.Value = 0
        Else
            ToolStripProgressBar_TokenAttribiute.Value = 50
        End If
        
    End Sub

    Private Sub Timer_TokenRelation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_TokenRelation.Tick
        If boolTokenRel = True Then
            Timer_TokenRelation.Enabled = False

            BindingSource_TokenRel.DataSource = procT_TokenRel_With_Or
            DataGridView_Relations.DataSource = BindingSource_TokenRel

            DataGridView_Relations.Columns(0).Visible = False
            DataGridView_Relations.Columns(1).DisplayIndex = 0
            DataGridView_Relations.Columns(2).Visible = False
            DataGridView_Relations.Columns(3).Visible = False
            DataGridView_Relations.Columns(4).DisplayIndex = 3
            DataGridView_Relations.Columns(5).DisplayIndex = 2
            DataGridView_Relations.Columns(6).Visible = False
            DataGridView_Relations.Columns(7).DisplayIndex = 1
            DataGridView_Relations.Columns(8).Visible = False
            DataGridView_Relations.Columns(9).Visible = False
            DataGridView_Relations.Columns(10).DisplayIndex = 4
            DataGridView_Relations.Columns(11).Visible = False
            DataGridView_Relations.Columns(12).DisplayIndex = 5
            ContextMenuStrip_TokRel.Enabled = True
            ToolStripButton_DelTokenRel.Enabled = True
            ToolStripProgressBar_TokenRelation.Value = 0
        Else
            ToolStripProgressBar_TokenRelation.Value = 50
        End If
    End Sub
End Class