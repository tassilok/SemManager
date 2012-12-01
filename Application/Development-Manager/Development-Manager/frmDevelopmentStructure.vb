Imports Sem_Manager
Public Class frmDevelopmentStructure

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_Token_StructureType As New ds_SemDB.semtbl_TokenDataTable
    Private semtblT_Token_StructureValidity As New ds_SemDB.semtbl_TokenDataTable
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_related_Parameters_with_Direction As New ds_DevStructuresTableAdapters.proc_related_Parameters_with_DirectionTableAdapter
    Private procA_StructureTypeWithAspects_Of_DevStructure_By_Type_AND_Validity As New ds_DevStructuresTableAdapters.proc_StructureTypeWithAspects_Of_DevStructure_By_Type_AND_ValidityTableAdapter
    Private procA_StructureTypeWithAspects_By_StructureType_And_StructureValidity As New ds_DevStructuresTableAdapters.proc_StructureTypeWithAspects_By_StructureType_And_StructureValidityTableAdapter
    Private procA_DevParameter_By_Direction_And_Object As New ds_DevStructuresTableAdapters.proc_DevParameter_By_Direction_And_ObjectTableAdapter
    Private procA_Handler_Of_GUIEntries_By_GUIDDevStructure As New ds_DevStructuresTableAdapters.proc_Handler_Of_GUIEntries_By_GUIDDevStructureTableAdapter

    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private objDRC_DevStructure As DataRowCollection
    Private objDtbl_Parameter As New ds_DevStructures.dtbl_ParametersDataTable
    Private objDRC_Parameters As DataRowCollection

    Private objFrm_DevelopmentManager As frmDevelopmentManager
    Private objFrm_SemManager As frmSemManager
    Private objFrm_TokenEdit As frmTokenEdit
    Private objDlg_Attribute_VARCHAR255 As dlgAttribute_Varchar255
    Private objSemItem_DevelopmentStructure As clsSemItem
    Private objSemItem_Development As clsSemItem

    Private objSemItem_StructureTypeWithAspects As clsSemItem

    Private objDRC_Handles As DataRowCollection
    Private objDR_Type As DataRowView
    Private objDR_Validity As DataRowView

    Private objThread_Name As Threading.Thread
    Private objThread_TypeValidity As Threading.Thread
    Private objSemItem_Handles As clsSemItem

    Private objTransaction_DevStructure As clsTransaction_DevelopmentStructure

    Private boolUser_StrucType As Boolean
    Private boolUser_Validity As Boolean

    Private strConnection_DB_Thread As String
    Private strConnection_Module_Thread As String

    Private strName As String
    Private boolOK_Name As Boolean
    Private boolOK_TypeValidity As Boolean

    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Close()
    End Sub

    Public Sub New(ByVal SemItem_DevelopmentStructure As clsSemItem, ByVal SemItem_Development As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_DevelopmentStructure = SemItem_DevelopmentStructure
        objSemItem_Development = SemItem_Development
        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        Me.Text = objSemItem_Development.Name

        semtblA_Token.Fill_Token_TypeChilds(semtblT_Token_StructureType, objLocalConfig.SemItem_Type_Structure_Type.GUID)
        semtblA_Token.Fill_Token_TypeChilds(semtblT_Token_StructureValidity, objLocalConfig.SemItem_Type_Structure_Validity.GUID)
        boolUser_StrucType = False
        boolUser_Validity = False
        ComboBox_Type.DataSource = semtblT_Token_StructureType
        ComboBox_Type.ValueMember = "GUID_Token"
        ComboBox_Type.DisplayMember = "Name_Token"
        ComboBox_Validity.DataSource = semtblT_Token_StructureValidity
        ComboBox_Validity.ValueMember = "GUID_Token"
        ComboBox_Validity.DisplayMember = "Name_Token"

        objTransaction_DevStructure = New clsTransaction_DevelopmentStructure(objSemItem_DevelopmentStructure, objSemItem_Development)

        
        
    End Sub

    Private Sub set_DBConnection()
        

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        procA_StructureTypeWithAspects_Of_DevStructure_By_Type_AND_Validity.Connection = objLocalConfig.Connection_Plugin
        procA_related_Parameters_with_Direction.Connection = objLocalConfig.Connection_Plugin
        procA_StructureTypeWithAspects_By_StructureType_And_StructureValidity.Connection = objLocalConfig.Connection_Plugin
        procA_DevParameter_By_Direction_And_Object.Connection = objLocalConfig.Connection_Plugin
        procA_Handler_Of_GUIEntries_By_GUIDDevStructure.Connection = objLocalConfig.Connection_Plugin

        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        strConnection_DB_Thread = objLocalConfig.Connection_DB.ConnectionString
        strConnection_Module_Thread = objLocalConfig.Connection_Plugin.ConnectionString
    End Sub

    Private Sub frmDevelopmentStructure_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim objDRC_LogState As DataRowCollection

        If objSemItem_DevelopmentStructure.new_Item = True Then
            objSemItem_DevelopmentStructure.GUID = Guid.NewGuid
            start_test()
        Else
            get_Data()
            If objDRC_DevStructure.Count > 0 Then
                set_Control_Data(objDRC_DevStructure(0))
            End If
        End If
        get_Paremeters()

        boolUser_Validity = True
        boolUser_StrucType = True
        Timer_TestName.Start()
        Timer_TestTypeValidity.Start()
        Timer_Test.Start()
    End Sub

    Private Sub get_Data()

        objDRC_DevStructure = procA_StructureTypeWithAspects_Of_DevStructure_By_Type_AND_Validity.GetData(objLocalConfig.SemItem_Type_Development_Structure.GUID, _
                                                                                                              objLocalConfig.SemItem_Type_Structure_Type_with_Aspects.GUID, _
                                                                                                              objLocalConfig.SemItem_Type_Structure_Type.GUID, _
                                                                                                              objLocalConfig.SemItem_Type_Structure_Validity.GUID, _
                                                                                                              objLocalConfig.SemItem_RelationType_access_by.GUID, _
                                                                                                              objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                                                              Nothing, Nothing, objSemItem_DevelopmentStructure.GUID).Rows

    End Sub

    Private Sub get_Paremeters()
        objDRC_Parameters = procA_related_Parameters_with_Direction.GetData(objLocalConfig.SemItem_Type_Parameter_Dev_Structure.GUID, _
                                                                            objLocalConfig.SemItem_Type_Directions.GUID, _
                                                                            objLocalConfig.SemItem_Type_Development_Structure.GUID, _
                                                                            objLocalConfig.SemItem_Type_Objects.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_directed_by.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_belonging_Paramter.GUID, _
                                                                            objSemItem_DevelopmentStructure.GUID).Rows

        objDtbl_Parameter.Clear()
        For Each objDR_Parameters In objDRC_Parameters
            objDtbl_Parameter.Rows.Add(objDR_Parameters.Item("Name_Directions"), _
                                       objDR_Parameters.Item("GUID_Parameter__Dev_Structure_"), _
                                       objDR_Parameters.Item("GUID_Directions"), _
                                       objDR_Parameters.Item("GUID_Objects"), _
                                       objDR_Parameters.Item("Name_Objects"), _
                                       objSemItem_Development.GUID, _
                                       objSemItem_Development.Name)
        Next

        BindingSource_Parameters.DataSource = objDtbl_Parameter
        DataGridView_Parameters.DataSource = BindingSource_Parameters
        DataGridView_Parameters.Columns(1).Visible = False
        DataGridView_Parameters.Columns(2).Visible = False
        DataGridView_Parameters.Columns(3).Visible = False
        DataGridView_Parameters.Columns(5).Visible = False
        DataGridView_Parameters.Columns(6).Visible = False
    End Sub

    Private Sub get_Data_Handling()
        objDRC_Handles = procA_Handler_Of_GUIEntries_By_GUIDDevStructure.GetData(objLocalConfig.SemItem_Type_GUI_Entires.GUID, _
                                                                                 objLocalConfig.SemItem_Type_Development_Structure.GUID, _
                                                                                 objLocalConfig.SemItem_Type_SoftwareDevelopment.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_handles.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                 objSemItem_DevelopmentStructure.GUID).Rows
    End Sub

    Private Sub set_Control_Data(ByVal objDR_DevStructure As DataRow)


        TextBox_Name.ReadOnly = True
        TextBox_Name.Text = objDR_DevStructure.Item("Name_Development_Structure")
        TextBox_Name.ReadOnly = False
        boolUser_StrucType = False
        ComboBox_Type.SelectedValue = objDR_DevStructure.Item("GUID_Structure_Type")
        boolUser_StrucType = True
        boolUser_Validity = False
        ComboBox_Validity.SelectedValue = objDR_DevStructure.Item("GUID_Structure_Validity")
        boolUser_Validity = False
        
        get_Data_Handling()

        TextBox_Handles.Text = ""
        objSemItem_Handles = New clsSemItem
        If Not objDRC_Handles Is Nothing Then
            If objDRC_Handles.Count > 0 Then
                objSemItem_Handles.GUID = objDRC_Handles(0).Item("GUID_GUI_Entires")
                objSemItem_Handles.Name = objDRC_Handles(0).Item("Name_GUI_Entires") & "\" & objDRC_Handles(0).Item("Name_Software_Development")
                objSemItem_Handles.GUID_Parent = objLocalConfig.SemItem_Type_GUI_Entires.GUID
                objSemItem_Handles.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                TextBox_Handles.Text = objSemItem_Handles.Name
            End If
        End If
        


        start_test()

    End Sub
    Private Sub start_test()
        objDR_Type = ComboBox_Type.SelectedItem
        objDR_Validity = ComboBox_Validity.SelectedItem
        strName = TextBox_Name.Text
        Try
            objThread_Name.Abort()
            objThread_TypeValidity.Abort()
        Catch ex As Exception

        End Try
        objThread_Name = New Threading.Thread(AddressOf test_Name)
        objThread_TypeValidity = New Threading.Thread(AddressOf test_TypeValidity)

        objThread_Name.Start()
        objThread_TypeValidity.Start()
    End Sub
    Private Sub test_TypeValidity()
        Dim objConnection_DB As SqlClient.SqlConnection
        Dim objConnection_Module As SqlClient.SqlConnection

        Dim semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter

        
        Dim objDRC_TypeValidity As DataRowCollection

       

        objConnection_DB = New SqlClient.SqlConnection(strConnection_DB_Thread)
        objConnection_Module = New SqlClient.SqlConnection(strConnection_Module_Thread)

        semtblA_Token.Connection = objConnection_DB

        If Not objDR_Type Is Nothing Then
            If Not objDR_Validity Is Nothing Then
                objDRC_TypeValidity = semtblA_Token.GetData_Token_By_GUID(objDR_Type.Item("GUID_Token")).Rows
                If objDRC_TypeValidity.Count > 0 Then
                    objDRC_TypeValidity = semtblA_Token.GetData_Token_By_GUID(objDR_Validity.Item("GUID_Token")).Rows
                    If objDRC_TypeValidity.Count > 0 Then
                        boolOK_TypeValidity = True
                    Else
                        boolOK_TypeValidity = False
                    End If
                Else
                    boolOK_TypeValidity = False
                End If
            Else
                boolOK_TypeValidity = False
            End If
        Else

            boolOK_TypeValidity = False

        End If

    End Sub
    Private Sub test_Name()
        Dim funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

        Dim objConnection_DB As SqlClient.SqlConnection
        Dim objConnection_Module As SqlClient.SqlConnection

        Dim objDRC_Parameters As DataRowCollection
        Dim objDR_Parameter As DataRow
        Dim objDGVR_Parameter As DataGridViewRow
        Dim objDRV_Parameter As DataRowView
        Dim objDRC_DevStructure As DataRowCollection
        Dim objDR_DevStructure As DataRow

        Dim strParameter As String
        Dim strName_Test As String
        Dim strName_DB As String

        Dim boolTest As Boolean

        objConnection_DB = New SqlClient.SqlConnection(strConnection_DB_Thread)
        objConnection_Module = New SqlClient.SqlConnection(strConnection_Module_Thread)

        funcA_TokenToken.Connection = objConnection_DB

        If strName.Length > 0 Then
            objDRC_DevStructure = funcA_TokenToken.GetData_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel(objSemItem_Development.GUID, strName, _
                                                                                                                    objLocalConfig.SemItem_Type_Development_Structure.GUID, _
                                                                                                                    objLocalConfig.SemItem_RelationType_contains.GUID).Rows
            If objDRC_DevStructure.Count > 0 Then
                If objDRC_DevStructure.Count > 1 Then
                    boolTest = True
                Else
                    If objDRC_DevStructure(0).Item("GUID_Token_Right") = objSemItem_DevelopmentStructure.GUID Then
                        boolTest = False
                        boolOK_Name = True
                    Else
                        boolTest = True
                        boolOK_Name = False
                    End If
                End If
                If boolTest = True Then
                    strParameter = ""
                    If objSemItem_DevelopmentStructure.new_Item = True Then

                        strParameter = ""
                        For Each objDR_Parameter In objDtbl_Parameter.Rows
                            If strParameter = "" Then
                                strParameter = strParameter & objDR_Parameter.Item("Name_Parameter")
                            Else
                                strParameter = strParameter & ", " & objDR_Parameter.Item("Name_Parameter")
                            End If
                        Next

                    Else
                        objDRC_Parameters = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_DevelopmentStructure.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_Parameter_Dev_Structure.GUID).Rows

                        For Each objDR_Parameter In objDRC_Parameters
                            If strParameter = "" Then
                                strParameter = strParameter & objDR_Parameter.Item("Name_Token_Left")
                            Else
                                strParameter = strParameter & ", " & objDR_Parameter.Item("Name_Token_Left")
                            End If
                        Next


                    End If

                    strName_Test = strName & " (" & strParameter & ")"
                    boolOK_Name = True
                    For Each objDR_DevStructure In objDRC_DevStructure
                        If Not objDR_DevStructure.Item("GUID_Token_Right") = objSemItem_DevelopmentStructure.GUID Then
                            objDRC_Parameters = funcA_TokenToken.GetData_TokenToken_RightLeft(objDR_DevStructure.Item("GUID_Token_Right"), objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_Parameter_Dev_Structure.GUID).Rows
                            strParameter = ""
                            For Each objDR_Parameter In objDRC_Parameters
                                If strParameter = "" Then
                                    strParameter = strParameter & objDR_Parameter.Item("Name_Token_Left")
                                Else
                                    strParameter = strParameter & ", " & objDR_Parameter.Item("Name_Token_Left")
                                End If
                            Next

                            strName_DB = strName & " (" & strParameter & ")"
                            If strName_DB = strName_Test Then
                                boolOK_Name = False
                                Exit For
                            End If
                        End If


                    Next

                End If

            Else
                boolOK_Name = True
            End If


        Else
            boolOK_Name = False
        End If




    End Sub

    Private Sub Timer_TestName_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_TestName.Tick
        If boolOK_Name = True Then
            Panel_Name.BackColor = Color.Green
        Else
            Panel_Name.BackColor = Color.Red
        End If
    End Sub

    Private Sub Timer_TestTypeValidity_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_TestTypeValidity.Tick
        If boolOK_TypeValidity = True Then
            Panel_TypeValidity.BackColor = Color.Green

        Else
            Panel_TypeValidity.BackColor = Color.Red
        End If
    End Sub

    Private Sub Timer_Test_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Test.Tick
        If Not objThread_Name.ThreadState = Threading.ThreadState.Running Then
            If Not objThread_TypeValidity.ThreadState = Threading.ThreadState.Running Then
                If boolOK_Name = True And boolOK_TypeValidity = True Then
                    ToolStripButton_Apply.Enabled = True
                Else
                    ToolStripButton_Apply.Enabled = False
                End If
            Else
                ToolStripButton_Apply.Enabled = False
            End If
        Else
            ToolStripButton_Apply.Enabled = False
        End If
    End Sub

    Private Sub TextBox_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Name.TextChanged
        If TextBox_Name.ReadOnly = False Then
            start_test()
        End If
    End Sub

    Private Sub ToolStripButton_Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Apply.Click

        start_test()

        If ToolStripButton_Apply.Enabled = True Then
            objSemItem_DevelopmentStructure.Name = TextBox_Name.Text
            If objTransaction_DevStructure.save_001_DevStructure(objSemItem_DevelopmentStructure) = True Then
                If objTransaction_DevStructure.save_002_StructureTypeWithAspects(objDR_Type, objDR_Validity) = True Then
                    If objTransaction_DevStructure.save_002a_StructureTypeWithAspects_To_StructureType(objDR_Type) = True Then
                        If objTransaction_DevStructure.save_002b_StructureTypeWithAspects_To_StructureValidity(objDR_Validity) = True Then
                            If objTransaction_DevStructure.save_003_DevStructure_To_StructureTypeWithAspects = True Then
                                If objTransaction_DevStructure.save_004_Development_To_DevStructure = True Then
                                    If objTransaction_DevStructure.save_005_DevStructure_To_DevParameters(objDtbl_Parameter) = 0 Then
                                        Me.Hide()
                                    Else

                                    End If
                                Else

                                End If
                            End If
                        Else

                        End If
                    Else

                    End If
                Else

                End If
            Else
                MsgBox("Die Daten konnten nicht gespeichert werden!", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Bitte überprüfen Sie Ihre Eingaben!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    

    Private Sub ComboBox_Type_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ComboBox_Type.MouseDoubleClick
        Dim objSemItem_Type As New clsSemItem

        objDR_Type = ComboBox_Type.SelectedItem
        objSemItem_Type.GUID = objDR_Type.Item("GUID_Token")
        objSemItem_Type.Name = objDR_Type.Item("Name_Token")
        objSemItem_Type.GUID_Parent = objLocalConfig.SemItem_Type_Structure_Type.GUID
        objSemItem_Type.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrm_TokenEdit = New frmTokenEdit(objSemItem_Type, objLocalConfig.Globals)
        objFrm_TokenEdit.ShowDialog(Me)

    End Sub

    Private Sub ComboBox_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Type.SelectedIndexChanged
        start_test()

    End Sub

    Private Sub ComboBox_Validity_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ComboBox_Validity.MouseDoubleClick
        Dim objSemItem_Validity As New clsSemItem

        objDR_Validity = ComboBox_Validity.SelectedItem
        objSemItem_Validity.GUID = objDR_Validity.Item("GUID_Token")
        objSemItem_Validity.Name = objDR_Validity.Item("Name_Token")
        objSemItem_Validity.GUID_Parent = objLocalConfig.SemItem_Type_Structure_Validity.GUID
        objSemItem_Validity.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objFrm_TokenEdit = New frmTokenEdit(objSemItem_Validity, objLocalConfig.Globals)
        objFrm_TokenEdit.ShowDialog(Me)
    End Sub

    Private Sub ComboBox_Validity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Validity.SelectedIndexChanged
        start_test()

    End Sub

    Private Sub ContextMenuStrip_Parameters_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Parameters.Opening
        Dim objDGVC_Selected As DataGridViewCell
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView


        ChangeToolStripMenuItem.Enabled = False

        If DataGridView_Parameters.SelectedRows.Count = 1 Then
            ChangeToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub ChangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeToolStripMenuItem.Click
        Dim objDGVC_Selected As DataGridViewCell
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_Parameters As DataRowCollection

        Dim objDGVR_Result As DataGridViewRow
        Dim objDRV_Result As DataRowView

        Dim objDRC_LogState As DataRowCollection

        
    End Sub

    Private Sub NewParameterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewParameterToolStripMenuItem.Click
        Dim objDGVSRC_Objects As DataGridViewSelectedRowCollection
        Dim objDGVRC_Objects As DataGridViewRow
        Dim objDRV_Objects As DataRowView
        Dim objDGVRC_Directions As DataGridViewRow
        Dim objDRV_Directions As DataRowView
        Dim objDRC_DevParameter As DataRowCollection
        Dim objDRs_Parameters() As DataRow
        Dim intCountDone As Integer
        Dim intCountToDo As Integer

        MsgBox("Wählen Sie bitte den Parameter aus.", MsgBoxStyle.Information)
        objFrm_SemManager = New frmSemManager(objLocalConfig.SemItem_Type_Objects, objLocalConfig.Globals)
        objFrm_SemManager.Applyabale = True
        objFrm_SemManager.ShowDialog(Me)

        If objFrm_SemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
            objDGVSRC_Objects = objFrm_SemManager.SelectedRows_Items
            MsgBox("Wählen Sie bitte die Richtung aus.", MsgBoxStyle.Information)
            objFrm_SemManager = New frmSemManager(objLocalConfig.SemItem_Type_Directions, objLocalConfig.Globals)
            objFrm_SemManager.Applyabale = True
            objFrm_SemManager.ShowDialog(Me)
            If objFrm_SemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then

                If objFrm_SemManager.SelectedRows_Items.Count = 1 Then
                    objDGVRC_Directions = objFrm_SemManager.SelectedRows_Items(0)
                    objDRV_Directions = objDGVRC_Directions.DataBoundItem
                    If objDRV_Directions.Item("GUID_Type") = objLocalConfig.SemItem_Type_Directions.GUID Then
                        intCountToDo = objDGVSRC_Objects.Count
                        intCountDone = 0
                        For Each objDGVRC_Objects In objDGVSRC_Objects
                            objDRV_Objects = objDGVRC_Objects.DataBoundItem
                            If objDRV_Objects.Item("GUID_Type") = objLocalConfig.SemItem_Type_Objects.GUID Then
                                objDRs_Parameters = objDtbl_Parameter.Select("GUID_Direction='" & objDRV_Directions.Item("GUID_Token").ToString & "' AND " & _
                                                                             "GUID_Parameter='" & objDRV_Objects.Item("GUID_Token").ToString & "'")
                                If objDRs_Parameters.Count = 0 Then
                                    objDtbl_Parameter.Rows.Add(objDRV_Directions.Item("Name_Token"), _
                                                               Nothing, _
                                                               objDRV_Directions.Item("GUID_Token"), _
                                                               objDRV_Objects.Item("GUID_Token"), _
                                                               objDRV_Objects.Item("Name_Token"), _
                                                               objSemItem_Development.GUID, _
                                                               objSemItem_Development.Name)
                                    start_test()
                                End If
                            End If
                        Next
                    Else
                        MsgBox("Bitte eine Richtung auswählen!", MsgBoxStyle.Exclamation)
                    End If
                    
                Else
                    MsgBox("Bitte eine Richtung auswählen!", MsgBoxStyle.Exclamation)
                End If

            Else
                MsgBox("Bitte eine Richtung auswählen!", MsgBoxStyle.Exclamation)
            End If

        Else
            MsgBox("Bitte Parameter auswählen!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub Button_SetHandling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SetHandling.Click
        Dim objSemItems_Result() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_Handles As DataRow
        Dim boolSave As Boolean

        MsgBox("Wählen Sie bitte das GUI-Entry aus, welches durch diese Prozedur gehadelt wird!", MsgBoxStyle.Information)
        objFrm_DevelopmentManager = New frmDevelopmentManager(objLocalConfig, True)
        objFrm_DevelopmentManager.ShowDialog(Me)
        If objFrm_DevelopmentManager.DialogResult = Windows.Forms.DialogResult.OK Then
            objSemItems_Result = objFrm_DevelopmentManager.SemItems_Result
            If Not objSemItems_Result Is Nothing Then
                If objSemItems_Result.Count = 1 Then
                    If objSemItems_Result(0).GUID_Parent = objLocalConfig.SemItem_Type_GUI_Entires.GUID Then
                        boolSave = True
                        get_Data_Handling()
                        If Not objDRC_Handles Is Nothing Then
                            For Each objDR_Handles In objDRC_Handles
                                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DevelopmentStructure.GUID, objDR_Handles.Item("GUID_GUI_Entires"), objLocalConfig.SemItem_RelationType_handles.GUID).Rows
                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                    MsgBox("Der Handle kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                                    boolSave = False
                                End If
                            Next
                        End If
                        If boolSave = True Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DevelopmentStructure.GUID, objSemItems_Result(0).GUID, objLocalConfig.SemItem_RelationType_handles.GUID, 0).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                get_Data_Handling()
                                If objDRC_Handles.Count > 0 Then
                                    objSemItem_Handles.GUID = objDRC_Handles(0).Item("GUID_GUI_Entires")
                                    objSemItem_Handles.Name = objDRC_Handles(0).Item("Name_GUI_Entires") & "\" & objDRC_Handles(0).Item("Name_Software_Development")
                                    objSemItem_Handles.GUID_Parent = objLocalConfig.SemItem_Type_GUI_Entires.GUID
                                    objSemItem_Handles.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    TextBox_Handles.Text = objSemItem_Handles.Name
                                End If
                            Else
                                MsgBox("Der Handle kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            End If

                        End If
                    Else
                        MsgBox("Bitte wählen Sie ein GUI-Entry aus!", MsgBoxStyle.Exclamation)
                    End If


                Else
                    MsgBox("Bitte wählen Sie ein GUI-Entry aus!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte wählen Sie ein GUI-Entry aus!", MsgBoxStyle.Exclamation)
            End If

        End If




    End Sub
End Class