Public Class frmTypeEdit

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private chngprocA_Max_Version_Type As New ds_ChangeTableAdapters.chngproc_Max_Version_TypeTableAdapter
    Private semprocA_Type_with_Path_By_GUID As New ds_TypeTableAdapters.semproc_Type_with_Path_By_GUIDTableAdapter
    Private typefuncA_Types_With_Attributes_And_Types As New ds_TypeTableAdapters.typefunc_Types_With_Attributes_And_TypesTableAdapter
    Private typetbl_Types_With_Attributes_And_Types As New ds_Type.typefunc_Types_With_Attributes_And_TypesDataTable
    Private typefuncA_Types_Rel As New ds_TypeTableAdapters.typefunc_Types_RelTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_Token_OR As New ds_TokenTableAdapters.func_Token_ORTableAdapter
    Private typetbl_Types_Rel_LeftRight As New ds_Type.typefunc_Types_RelDataTable
    Private typetbl_Types_Rel_RightLeft As New ds_Type.typefunc_Types_RelDataTable
    Private semprocA_DBWork_Save_TypeAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TypeAttributeTableAdapter
    Private semprocA_DBWork_Save_TypeRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TypeRelTableAdapter
    Private semprocA_DBWork_Del_TypeRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Type_RelTableAdapter
    Private semfuncA_Token_Attribute As New ds_TokenAttributeTableAdapters.semfunc_Token_AttributeTableAdapter
    Private semprocA_DBWork_Del_TypeAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TypeAttributeTableAdapter
    Private semprocA_DBWork_Save_Type_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Type_ORTableAdapter
    Private semprocA_DBWork_Del_Type_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Type_ORTableAdapter
    Private semprocA_DBWork_Save_Type As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TypeTableAdapter

    Private procA_Type_OR_By_GUIDType As New ds_ObjectReferenceTableAdapters.proc_Type_OR_By_GUIDTypeTableAdapter
    Private procT_Type_OR_By_GUIDType As New ds_ObjectReference.proc_Type_OR_By_GUIDTypeDataTable

    Private objTransaction_Types As clsTransaction_Types

    Private objFrmSemManager As frmSemManager

    Private objLocalConfig As clsLocalConfig_TypeEdit
    Private objSemItem_Type As clsSemItem
    Private objDBWork As clsDBWork

    Private intVersion_Class As Integer
    Private boolChange_Name As Boolean
    Public ReadOnly Property SemItem_Type As clsSemItem
        Get
            Return objSemItem_Type
        End Get
    End Property
    Public ReadOnly Property changed_Name As Boolean
        Get
            Return boolChange_Name
        End Get
    End Property
    Public Sub New(ByVal SemItem_Type As clsSemItem, ByVal Connection_DB As SqlClient.SqlConnection, ByVal Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_TypeEdit(Globals)
        objLocalConfig.Connection_DB = Connection_DB

        objSemItem_Type = SemItem_Type

        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
        get_Version_Type()
        get_TypeData()
    End Sub

    Private Sub set_DBConnection()

        objLocalConfig.Connection_Change = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_Change)
        chngprocA_Max_Version_Type.Connection = objLocalConfig.Connection_DB
        semprocA_Type_with_Path_By_GUID.Connection = objLocalConfig.Connection_DB
        typefuncA_Types_With_Attributes_And_Types.Connection = objLocalConfig.Connection_DB
        typefuncA_Types_Rel.Connection = objLocalConfig.Connection_DB
        semfuncA_Token_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TypeAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TypeAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TypeRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TypeRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Type_OR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Type.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Type_OR.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
        procA_Type_OR_By_GUIDType.Connection = objLocalConfig.Connection_DB

        objDBWork = New clsDBWork(objLocalConfig.Connection_DB, objLocalConfig.Globals)
        objTransaction_Types = New clsTransaction_Types(objLocalConfig.Globals)



    End Sub

    Private Sub get_TypeData()
        Dim objDRC_Type As DataRowCollection

        If objSemItem_Type.GUID = Nothing Then

            objSemItem_Type.GUID = Guid.NewGuid
            objSemItem_Type.Name = ""
            objSemItem_Type.new_Item = True
            objDRC_Type = semprocA_Type_with_Path_By_GUID.GetData(objSemItem_Type.GUID_Parent).Rows
        Else
            objDRC_Type = semprocA_Type_with_Path_By_GUID.GetData(objSemItem_Type.GUID).Rows
        End If
        ToolStripTextBox_ClassName.ReadOnly = True
        ToolStripTextBox_GUID.Text = objSemItem_Type.GUID.ToString
        ToolStripTextBox_ClassName.Text = objSemItem_Type.Name
        ToolStripTextBox_ClassName.ReadOnly = False
        Me.Text = objDRC_Type(0).Item("Path_Type")
        Me.ToolStripStatusLabel_DB.Text = objLocalConfig.Globals.DB_Path_User
        get_Type_Attributes()
        get_Type_Realtions()
    End Sub

    Private Sub get_Type_Attributes()
        typefuncA_Types_With_Attributes_And_Types.Fill_By_TypeGUID(typetbl_Types_With_Attributes_And_Types, objSemItem_Type.GUID)
        BindingSource_Attributes.DataSource = typetbl_Types_With_Attributes_And_Types

        DataGridView_Attributes.DataSource = BindingSource_Attributes

        DataGridView_Attributes.Columns(0).Visible = False
        DataGridView_Attributes.Columns(1).Visible = False
        DataGridView_Attributes.Columns(2).Visible = False
        DataGridView_Attributes.Columns(3).Width = 150
        DataGridView_Attributes.Columns(4).Visible = False
        DataGridView_Attributes.Columns(5).Width = 150
        
    End Sub

    Private Sub get_Type_Realtions()
        typefuncA_Types_Rel.Fill_By_GUID_Type_Left(typetbl_Types_Rel_LeftRight, objSemItem_Type.GUID)
        typefuncA_Types_Rel.Fill_By_GUID_Type_Right(typetbl_Types_Rel_RightLeft, objSemItem_Type.GUID)
        procA_Type_OR_By_GUIDType.Fill(procT_Type_OR_By_GUIDType, objSemItem_Type.GUID)

        BindingSource_RelForw.DataSource = typetbl_Types_Rel_LeftRight
        BindingSource_RelBackw.DataSource = typetbl_Types_Rel_RightLeft
        BindingSource_ObjectReferences.DataSource = procT_Type_OR_By_GUIDType

        DataGridView_RelationsForward.DataSource = BindingSource_RelForw
        DataGridView_BackwardRelations.DataSource = BindingSource_RelBackw
        DataGridView_ObjectReferences.DataSource = BindingSource_ObjectReferences

        DataGridView_RelationsForward.Columns(0).Visible = False
        DataGridView_RelationsForward.Columns(1).Visible = False
        DataGridView_RelationsForward.Columns(2).Visible = False
        DataGridView_RelationsForward.Columns(3).Visible = False
        DataGridView_RelationsForward.Columns(4).Width = 150
        DataGridView_RelationsForward.Columns(5).Visible = False
        DataGridView_RelationsForward.Columns(6).Width = 150
        DataGridView_RelationsForward.Columns(7).Visible = False

        DataGridView_BackwardRelations.Columns(0).Visible = False
        DataGridView_BackwardRelations.Columns(1).Width = 150
        DataGridView_BackwardRelations.Columns(2).Visible = False
        DataGridView_BackwardRelations.Columns(3).Visible = False
        DataGridView_BackwardRelations.Columns(4).Width = 150
        DataGridView_BackwardRelations.Columns(5).Visible = False
        DataGridView_BackwardRelations.Columns(6).Visible = False
        DataGridView_BackwardRelations.Columns(7).Visible = False

        DataGridView_ObjectReferences.Columns(0).Visible = False
        DataGridView_ObjectReferences.Columns(1).Visible = False
        DataGridView_ObjectReferences.Columns(2).Visible = False
        DataGridView_ObjectReferences.Columns(3).Width = 150
    End Sub

    Private Sub get_Version_Type()
        Dim objDRC_MaxVersion As DataRowCollection

        intVersion_Class = 1
        If Not objSemItem_Type.GUID = Nothing Then
            objDRC_MaxVersion = chngprocA_Max_Version_Type.GetData(objSemItem_Type.GUID, objDBWork.SemItem_DB.GUID).Rows


            If objDRC_MaxVersion.Count > 0 Then
                If Not IsDBNull(objDRC_MaxVersion(0).Item("Version_Type")) Then
                    intVersion_Class = objDRC_MaxVersion(0).Item("Version_Type")
                End If

            End If

        End If
        ToolStripStatusLabel_Version.Text = intVersion_Class
    End Sub

    Private Sub ToolStripButton_AddAttribute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddAttribute.Click
        Dim objSemItems_Selected() As clsSemItem
        Dim objSemItem_Attribute As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView

        objFrmSemManager = New frmSemManager(objLocalConfig.Globals.ObjectReferenceType_Attribute, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)
        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.Applied_SemItems = False Then
                If Not objFrmSemManager.SelectedRows_Items Is Nothing Then
                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID Then
                        For Each objDGVR In objFrmSemManager.SelectedRows_Items
                            objDRV = objDGVR.DataBoundItem
                            objDRC_LogState = semprocA_DBWork_Save_TypeAttribute.GetData(objSemItem_Type.GUID, objDRV.Item("GUID_Attribute"), 1, 1).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                                MsgBox("Die Beziehung zwischen Attribut und Typ konnte nicht gesetzt werden.", MsgBoxStyle.Exclamation)
                                Exit For
                            End If
                        Next
                    Else
                        MsgBox("Bitte wählen Sie nur Attribute aus!", MsgBoxStyle.Exclamation)
                    End If
                    
                End If
                


            Else
                MsgBox("Bitte wählen Sie nur Attribute aus!", MsgBoxStyle.Exclamation)
            End If
            
            get_Type_Attributes()
        End If

    End Sub

    Private Sub ToolStripButton_DelAttribute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_DelAttribute.Click
        Dim objDRC_TokenAttribute As DataRowCollection
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim objDRC_Result As DataRowCollection

        If DataGridView_Attributes.SelectedRows.Count = 0 Then
            MsgBox("Bitte wählen Sie mindestens ein Attribut aus!", MsgBoxStyle.Exclamation)
        Else
            For Each objDGVR In DataGridView_Attributes.SelectedRows
                objDRV = objDGVR.DataBoundItem
                objDRC_TokenAttribute = semfuncA_Token_Attribute.GetData_TokenAttribute_By_GUID_Attribute_And_GUID_Type(objDRV.Item("GUID_Attribute"), objSemItem_Type.GUID).Rows
                If objDRC_TokenAttribute.Count > 0 Then
                    MsgBox("Das Attribute """ & objDRV.Item("Name_Attribute") & """ kann nicht gelöscht werden, weil es Token gibt, die Ausprägungen dieses Attributs besitzen!", MsgBoxStyle.Exclamation)
                Else
                    objDRC_Result = semprocA_DBWork_Del_TypeAttribute.GetData(objSemItem_Type.GUID, objDRV.Item("GUID_Attribute")).Rows
                    If objDRC_Result.Count > 0 Then
                        If objDRC_Result(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                        End If
                        get_Type_Attributes()
                    Else
                        MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                        get_Type_Attributes()
                    End If

                End If
            Next
        End If
    End Sub

    Private Sub DataGridView_RelationsForward_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_RelationsForward.CellContentClick

    End Sub
    Private Sub inc_Rel_Min_Forw(ByVal objDRV As DataRowView)


        Dim objDRC_TypeRel As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeRel = typefuncA_Types_Rel.GetData_Type_Rel_By_GUIDs(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType")).Rows
        If objDRC_TypeRel.Count > 0 Then
            If objDRC_TypeRel(0).Item("Min_forw") < objDRC_TypeRel(0).Item("Max_forw") And _
                            Not objDRC_TypeRel(0).Item("Max_forw") = -1 Then
                objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType"), objDRC_TypeRel(0).Item("Min_forw") + 1, objDRC_TypeRel(0).Item("Max_forw"), objDRC_TypeRel(0).Item("Max_Backw")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                End If
                get_Type_Realtions()


            End If
        End If

    End Sub

    Private Sub dec_Rel_Min_Forw(ByVal objDRV As DataRowView)


        Dim objDRC_TypeRel As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeRel = typefuncA_Types_Rel.GetData_Type_Rel_By_GUIDs(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType")).Rows
        If objDRC_TypeRel(0).Item("Min_forw") > 0 Then
            objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType"), objDRC_TypeRel(0).Item("Min_forw") - 1, objDRC_TypeRel(0).Item("Max_forw"), objDRC_TypeRel(0).Item("Max_Backw")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Realtions()
        End If
    End Sub
    Private Sub inc_Rel_Max_Forw(ByVal objDRV As DataRowView)

        Dim objDRC_TypeRel As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeRel = typefuncA_Types_Rel.GetData_Type_Rel_By_GUIDs(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType")).Rows
        If Not objDRC_TypeRel(0).Item("Max_forw") = -1 Then

            objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType"), objDRC_TypeRel(0).Item("Min_forw"), objDRC_TypeRel(0).Item("Max_forw") + 1, objDRC_TypeRel(0).Item("Max_Backw")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Realtions()
        Else
            If objDRC_TypeRel(0).Item("Min_forw") = 0 Then
                objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType"), objDRC_TypeRel(0).Item("Min_forw"), 1, objDRC_TypeRel(0).Item("Max_Backw")).Rows
            Else
                objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType"), objDRC_TypeRel(0).Item("Min_forw"), objDRC_TypeRel(0).Item("Min_forw"), objDRC_TypeRel(0).Item("Max_Backw")).Rows
            End If
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Realtions()
        End If
    End Sub
    Private Sub dec_Rel_Max_Forw(ByVal objDRV As DataRowView)

        Dim objDRC_TypeRel As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeRel = typefuncA_Types_Rel.GetData_Type_Rel_By_GUIDs(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType")).Rows
        If objDRC_TypeRel(0).Item("Max_forw") > 1 Then

            objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType"), objDRC_TypeRel(0).Item("Min_forw"), objDRC_TypeRel(0).Item("Max_forw") - 1, objDRC_TypeRel(0).Item("Max_Backw")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Realtions()


        Else
            objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType"), objDRC_TypeRel(0).Item("Min_forw"), -1, objDRC_TypeRel(0).Item("Max_Backw")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Realtions()
        End If
    End Sub
    Private Sub inc_Rel_Max_Backw(ByVal objDRV As DataRowView)

        Dim objDRC_TypeRel As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeRel = typefuncA_Types_Rel.GetData_Type_Rel_By_GUIDs(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType")).Rows
        If Not objDRC_TypeRel(0).Item("Max_backw") = -1 Then
            objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType"), objDRC_TypeRel(0).Item("Min_forw"), objDRC_TypeRel(0).Item("Max_forw"), objDRC_TypeRel(0).Item("Max_Backw") + 1).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Realtions()

        Else
            objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType"), objDRC_TypeRel(0).Item("Min_forw"), objDRC_TypeRel(0).Item("Max_forw"), 1).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Realtions()
        End If
    End Sub
    Private Sub dec_Rel_Max_Backw(ByVal objDRV As DataRowView)

        Dim objDRC_TypeRel As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeRel = typefuncA_Types_Rel.GetData_Type_Rel_By_GUIDs(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType")).Rows
        If objDRC_TypeRel(0).Item("Max_backw") > 1 Then
            objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType"), objDRC_TypeRel(0).Item("Min_forw"), objDRC_TypeRel(0).Item("Max_forw"), objDRC_TypeRel(0).Item("Max_Backw") - 1).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Realtions()
        Else
            objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objDRV.Item("GUID_Type_Left"), objDRV.Item("GUID_Type_Right"), objDRV.Item("GUID_RelationType"), objDRC_TypeRel(0).Item("Min_forw"), objDRC_TypeRel(0).Item("Max_forw"), -1).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Realtions()
        End If
    End Sub

    Private Sub DataGridView_RelationsForward_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_RelationsForward.CellContentDoubleClick
        
    End Sub

    Private Function set_Type_Min_forw_OK(ByVal GUID_Type_Right As Guid, ByVal GUID_RelationType As Guid, ByVal intMin_New As Integer) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_TypeType As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeType = typefuncA_Types_Rel.GetData_Type_Rel_By_GUIDs(objSemItem_Type.GUID, GUID_Type_Right, GUID_RelationType).Rows
        If objDRC_TypeType.Count > 0 Then
            If intMin_New >= 0 Then
                If Not intMin_New = objDRC_TypeType(0).Item("Min_forw") Then
                    If intMin_New <= objDRC_TypeType(0).Item("Max_forw") Or objDRC_TypeType(0).Item("Max_forw") = -1 Then
                        objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objSemItem_Type.GUID, _
                                                                               GUID_Type_Right, _
                                                                               GUID_RelationType, _
                                                                               intMin_New, _
                                                                               objDRC_TypeType(0).Item("Max_forw"), _
                                                                               objDRC_TypeType(0).Item("Max_backw")).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
                End If
                
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
            
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Delete
        End If


        Return objSemItem_Result
    End Function

    Private Function set_Type_Max_forw_OK(ByVal GUID_Type_Right As Guid, ByVal GUID_RelationType As Guid, ByVal intMax_New As Integer) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_TypeType As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeType = typefuncA_Types_Rel.GetData_Type_Rel_By_GUIDs(objSemItem_Type.GUID, GUID_Type_Right, GUID_RelationType).Rows
        If objDRC_TypeType.Count > 0 Then
            If intMax_New > 0 Or intMax_New = -1 Then
                If Not objDRC_TypeType(0).Item("Max_forw") = intMax_New Then
                    If intMax_New >= objDRC_TypeType(0).Item("Min_forw") Or intMax_New = -1 Then
                        objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objSemItem_Type.GUID, _
                                                                               GUID_Type_Right, _
                                                                               GUID_RelationType, _
                                                                               objDRC_TypeType(0).Item("Min_forw"), _
                                                                               intMax_New, _
                                                                               objDRC_TypeType(0).Item("Max_backw")).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
                End If

            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Delete
        End If


        Return objSemItem_Result
    End Function

    Private Function set_Type_Max_backw_OK(ByVal GUID_Type_Right As Guid, ByVal GUID_RelationType As Guid, ByVal intMax_New As Integer) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_TypeType As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeType = typefuncA_Types_Rel.GetData_Type_Rel_By_GUIDs(objSemItem_Type.GUID, GUID_Type_Right, GUID_RelationType).Rows
        If objDRC_TypeType.Count > 0 Then
            If intMax_New > 0 Or intMax_New = -1 Then
                If Not objDRC_TypeType(0).Item("Max_backw") = intMax_New Then
                    objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objSemItem_Type.GUID, _
                                                                       GUID_Type_Right, _
                                                                       GUID_RelationType, _
                                                                       objDRC_TypeType(0).Item("Min_forw"), _
                                                                       objDRC_TypeType(0).Item("Max_forw"), _
                                                                       intMax_New).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
                End If


            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Delete
        End If


        Return objSemItem_Result
    End Function

    Private Sub DataGridView_RelationsForward_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_RelationsForward.CellDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDlgAttribute_Int As dlgAttribute_Int
        Dim objSemItem_Result As clsSemItem
        Dim intValue As Integer

        Dim boolMin_forw As Boolean
        Dim boolMax_forw As Boolean
        Dim boolMax_backw As Boolean
        Dim boolShowDialog As Boolean = False

        objDGVR_Selected = DataGridView_RelationsForward.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        Select Case DataGridView_RelationsForward.Columns(e.ColumnIndex).Name
            Case "Min_forw"
                boolMin_forw = True
                boolMax_forw = False
                boolMax_backw = False
                boolShowDialog = True
            Case "Max_forw"
                boolMin_forw = False
                boolMax_forw = True
                boolMax_backw = False
                boolShowDialog = True
            Case "Max_backw"
                boolMin_forw = False
                boolMax_forw = False
                boolMax_backw = True
                boolShowDialog = True
        End Select

        If boolShowDialog = True Then
            objDlgAttribute_Int = New dlgAttribute_Int(DataGridView_RelationsForward.Columns(e.ColumnIndex).Name, objLocalConfig.Globals, objDRV_Selected.Item(DataGridView_RelationsForward.Columns(e.ColumnIndex).Name))
            objDlgAttribute_Int.ShowDialog(Me)
            If objDlgAttribute_Int.DialogResult = Windows.Forms.DialogResult.OK Then
                intValue = objDlgAttribute_Int.Value
                If boolMin_forw = True Then
                    objSemItem_Result = set_Type_Min_forw_OK(objDRV_Selected.Item("GUID_Type_Right"), objDRV_Selected.Item("GUID_RelationType"), intValue)

                ElseIf boolMax_forw = True Then
                    objSemItem_Result = set_Type_Max_forw_OK(objDRV_Selected.Item("GUID_Type_Right"), objDRV_Selected.Item("GUID_RelationType"), intValue)
                ElseIf boolMax_backw = True Then
                    objSemItem_Result = set_Type_Max_backw_OK(objDRV_Selected.Item("GUID_Type_Right"), objDRV_Selected.Item("GUID_RelationType"), intValue)
                End If

                Select Case objSemItem_Result.GUID
                    Case objLocalConfig.Globals.LogState_Success.GUID
                        get_Type_Realtions()
                    Case objLocalConfig.Globals.LogState_Error.GUID
                        MsgBox("Der Wert ist außerhalb des Bereichs!", MsgBoxStyle.Exclamation)
                    Case objLocalConfig.Globals.LogState_Delete.GUID
                        MsgBox("Die Beziehung ist nicht mehr vorhanden!", MsgBoxStyle.Exclamation)
                        get_Type_Realtions()
                End Select
            End If
        End If
    End Sub

    Private Sub DataGridView_RelationsForward_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView_RelationsForward.MouseWheel
        Dim objRect_Column_Min As Rectangle
        Dim objRect_Column_Max_forw As Rectangle
        Dim objRect_Column_Max_backw As Rectangle
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim objHitTest As DataGridView.HitTestInfo


        objRect_Column_Min = DataGridView_RelationsForward.GetColumnDisplayRectangle(8, True)
        objHitTest = DataGridView_RelationsForward.HitTest(e.X, e.Y)
        If (e.X >= objRect_Column_Min.X And _
            e.X <= objRect_Column_Min.X + objRect_Column_Min.Width) And _
            (e.Y >= objRect_Column_Min.Y And e.Y <= objRect_Column_Min.Y + objRect_Column_Min.Height) Then
            If objHitTest.RowIndex > -1 Then
                objDGVR = DataGridView_RelationsForward.Rows(objHitTest.RowIndex)
                objDRV = objDGVR.DataBoundItem
                If e.Delta > 0 Then
                    inc_Rel_Min_Forw(objDRV)
                ElseIf e.Delta < 0 Then
                    dec_Rel_Min_Forw(objDRV)
                End If

            End If
        End If

        objRect_Column_Max_forw = DataGridView_RelationsForward.GetColumnDisplayRectangle(9, True)
        If (e.X >= objRect_Column_Max_forw.X And _
            e.X <= objRect_Column_Max_forw.X + objRect_Column_Max_forw.Width) And _
            (e.Y >= objRect_Column_Max_forw.Y And e.Y <= objRect_Column_Max_forw.Y + objRect_Column_Max_forw.Height) Then
            If objHitTest.RowIndex > -1 Then
                objDGVR = DataGridView_RelationsForward.Rows(objHitTest.RowIndex)
                objDRV = objDGVR.DataBoundItem
                If e.Delta > 0 Then
                    inc_Rel_Max_Forw(objDRV)
                ElseIf e.Delta < 0 Then
                    dec_Rel_Max_Forw(objDRV)
                End If
            End If
        End If

        objRect_Column_Max_backw = DataGridView_RelationsForward.GetColumnDisplayRectangle(10, True)
        If (e.X >= objRect_Column_Max_backw.X And _
            e.X <= objRect_Column_Max_backw.X + objRect_Column_Max_backw.Width) And _
            (e.Y >= objRect_Column_Max_backw.Y And e.Y <= objRect_Column_Max_backw.Y + objRect_Column_Max_backw.Height) Then
            If objHitTest.RowIndex > -1 Then
                objDGVR = DataGridView_RelationsForward.Rows(objHitTest.RowIndex)
                objDRV = objDGVR.DataBoundItem

                If e.Delta > 0 Then
                    inc_Rel_Max_Backw(objDRV)
                ElseIf e.Delta < 0 Then
                    dec_Rel_Max_Backw(objDRV)

                End If
            End If
        End If
    End Sub

    Private Sub DataGridView_BackwardRelations_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView_BackwardRelations.MouseWheel
        Dim objRect_Column_Min As Rectangle
        Dim objRect_Column_Max_forw As Rectangle
        Dim objRect_Column_Max_backw As Rectangle
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim objHitTest As DataGridView.HitTestInfo


        objRect_Column_Min = DataGridView_BackwardRelations.GetColumnDisplayRectangle(8, True)
        objHitTest = DataGridView_BackwardRelations.HitTest(e.X, e.Y)
        If (e.X >= objRect_Column_Min.X And _
            e.X <= objRect_Column_Min.X + objRect_Column_Min.Width) And _
            (e.Y >= objRect_Column_Min.Y And e.Y <= objRect_Column_Min.Y + objRect_Column_Min.Height) Then
            If objHitTest.RowIndex > -1 Then

                objDGVR = DataGridView_BackwardRelations.Rows(objHitTest.RowIndex)
                objDRV = objDGVR.DataBoundItem
                If e.Delta > 0 Then
                    inc_Rel_Min_Forw(objDRV)
                ElseIf e.Delta < 0 Then
                    dec_Rel_Min_Forw(objDRV)
                End If

            End If
        End If

        objRect_Column_Max_forw = DataGridView_BackwardRelations.GetColumnDisplayRectangle(9, True)
        If (e.X >= objRect_Column_Max_forw.X And _
            e.X <= objRect_Column_Max_forw.X + objRect_Column_Max_forw.Width) And _
            (e.Y >= objRect_Column_Max_forw.Y And e.Y <= objRect_Column_Max_forw.Y + objRect_Column_Max_forw.Height) Then
            If objHitTest.RowIndex > -1 Then
                objDGVR = DataGridView_BackwardRelations.Rows(objHitTest.RowIndex)
                objDRV = objDGVR.DataBoundItem
                If e.Delta > 0 Then
                    inc_Rel_Max_Forw(objDRV)
                ElseIf e.Delta < 0 Then
                    dec_Rel_Max_Forw(objDRV)
                End If
            End If
        End If

        objRect_Column_Max_backw = DataGridView_BackwardRelations.GetColumnDisplayRectangle(10, True)
        If (e.X >= objRect_Column_Max_backw.X And _
            e.X <= objRect_Column_Max_backw.X + objRect_Column_Max_backw.Width) And _
            (e.Y >= objRect_Column_Max_backw.Y And e.Y <= objRect_Column_Max_backw.Y + objRect_Column_Max_backw.Height) Then
            If objHitTest.RowIndex > -1 Then

                objDGVR = DataGridView_BackwardRelations.Rows(objHitTest.RowIndex)
                objDRV = objDGVR.DataBoundItem
                If e.Delta > 0 Then
                    inc_Rel_Max_Backw(objDRV)
                ElseIf e.Delta < 0 Then
                    dec_Rel_Max_Backw(objDRV)

                End If
            End If
        End If
    End Sub


    Private Sub dec_Attr_Min(ByVal objDRV As DataRowView)

        Dim objDRC_TypeAttrib As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeAttrib = typefuncA_Types_With_Attributes_And_Types.GetData_Type_And_Attribute_By_GUIDs(objDRV.Item("GUID_Type"), objDRV.Item("GUID_Attribute")).Rows
        If objDRC_TypeAttrib(0).Item("Min") > 0 Then
            objDRC_LogState = semprocA_DBWork_Save_TypeAttribute.GetData(objDRV.Item("GUID_Type"), objDRV.Item("GUID_Attribute"), objDRV.Item("Min") - 1, objDRV.Item("Max")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Attributes()
        End If
    End Sub

    Private Sub inc_Attr_Min(ByVal objDRV As DataRowView)

        Dim objDRC_TypeAttrib As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeAttrib = typefuncA_Types_With_Attributes_And_Types.GetData_Type_And_Attribute_By_GUIDs(objDRV.Item("GUID_Type"), objDRV.Item("GUID_Attribute")).Rows
        If objDRC_TypeAttrib(0).Item("Min") < objDRC_TypeAttrib(0).Item("Max") Then
            objDRC_LogState = semprocA_DBWork_Save_TypeAttribute.GetData(objDRV.Item("GUID_Type"), objDRV.Item("GUID_Attribute"), objDRV.Item("Min") + 1, objDRV.Item("Max")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Attributes()
        End If
    End Sub
    Private Sub inc_Attr_Max(ByVal objDRV As DataRowView)

        Dim objDRC_TypeAttrib As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeAttrib = typefuncA_Types_With_Attributes_And_Types.GetData_Type_And_Attribute_By_GUIDs(objDRV.Item("GUID_Type"), objDRV.Item("GUID_Attribute")).Rows
        If Not objDRC_TypeAttrib(0).Item("Max") = -1 Then
            objDRC_LogState = semprocA_DBWork_Save_TypeAttribute.GetData(objDRV.Item("GUID_Type"), objDRV.Item("GUID_Attribute"), objDRV.Item("Min"), objDRV.Item("Max") + 1).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Attributes()
        Else
            If Not objDRV.Item("Min") = 0 Then
                objDRC_LogState = semprocA_DBWork_Save_TypeAttribute.GetData(objDRV.Item("GUID_Type"), objDRV.Item("GUID_Attribute"), objDRV.Item("Min"), objDRV.Item("Min")).Rows
            Else
                objDRC_LogState = semprocA_DBWork_Save_TypeAttribute.GetData(objDRV.Item("GUID_Type"), objDRV.Item("GUID_Attribute"), objDRV.Item("Min"), 1).Rows
            End If

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Attributes()
        End If
    End Sub
    Private Sub dec_Attr_Max(ByVal objDRV As DataRowView)

        Dim objDRC_TypeAttrib As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        objDRC_TypeAttrib = typefuncA_Types_With_Attributes_And_Types.GetData_Type_And_Attribute_By_GUIDs(objDRV.Item("GUID_Type"), objDRV.Item("GUID_Attribute")).Rows
        If objDRC_TypeAttrib(0).Item("Max") > objDRC_TypeAttrib(0).Item("Min") Then
            If Not objDRC_TypeAttrib(0).Item("Max") = 1 Then
                objDRC_LogState = semprocA_DBWork_Save_TypeAttribute.GetData(objDRV.Item("GUID_Type"), objDRV.Item("GUID_Attribute"), objDRV.Item("Min"), objDRV.Item("Max") - 1).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                End If
                get_Type_Attributes()
            End If

            
        Else

            objDRC_LogState = semprocA_DBWork_Save_TypeAttribute.GetData(objDRV.Item("GUID_Type"), objDRV.Item("GUID_Attribute"), objDRV.Item("Min"), -1).Rows


            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Beim Löschen ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            End If
            get_Type_Attributes()
        End If
    End Sub

    Private Sub DataGridView_Attributes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Attributes.CellDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDLGAttribute_Int As dlgAttribute_Int
        Dim objSemItem_Result As clsSemItem
        Dim boolShow_Dialog As Boolean = False
        Dim boolMin As Boolean
        Dim intValue As Integer

        objDGVR_Selected = DataGridView_Attributes.Rows(e.RowIndex)

        objDRV_Selected = objDGVR_Selected.DataBoundItem



        Select Case DataGridView_Attributes.Columns(e.ColumnIndex).Name
            Case "Min"
                boolShow_Dialog = True
                boolMin = True
            Case "Max"
                boolShow_Dialog = False
                boolMin = False
        End Select

        If boolShow_Dialog = True Then

            objDLGAttribute_Int = New dlgAttribute_Int(DataGridView_Attributes.Columns(e.ColumnIndex).Name, _
                                                       objLocalConfig.Globals, objDRV_Selected.Item(DataGridView_Attributes.Columns(e.ColumnIndex).Name))


            objDLGAttribute_Int.ShowDialog(Me)
            If objDLGAttribute_Int.DialogResult = Windows.Forms.DialogResult.OK Then
                intValue = objDLGAttribute_Int.Value
                If boolMin = True Then
                    objSemItem_Result = set_Attrib_Min_OK(objDRV_Selected.Item("GUID_Attribute"), intValue)
                Else
                    objSemItem_Result = set_Attrib_Max_OK(objDRV_Selected.Item("GUID_Attribute"), intValue)
                End If

                Select Case objSemItem_Result.GUID
                    Case objLocalConfig.Globals.LogState_Success.GUID
                        get_Type_Attributes()
                    Case objLocalConfig.Globals.LogState_Error.GUID
                        MsgBox("Der Wert liegt außerhalb des zulässigen Bereichs!", MsgBoxStyle.Exclamation)
                    Case objLocalConfig.Globals.LogState_Delete.GUID
                        MsgBox("Die Beziehung zwischen der Type """ & objSemItem_Type.Name & """ und dem Attribut """ & objDRV_Selected.Item("Name_Attribute") & """ ist nicht mehr vorhanden!", MsgBoxStyle.Exclamation)

                End Select
            End If
        End If
    End Sub

    Private Sub DataGridView_Attributes_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Attributes.CellMouseDoubleClick
        
    End Sub
    Private Sub DataGridView_Attributes_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView_Attributes.MouseWheel
        Dim objRect_Column_Min As Rectangle
        Dim objRect_Column_Max_forw As Rectangle
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim objHitTest As DataGridView.HitTestInfo


        objRect_Column_Min = DataGridView_Attributes.GetColumnDisplayRectangle(6, True)
        objHitTest = DataGridView_Attributes.HitTest(e.X, e.Y)
        If (e.X >= objRect_Column_Min.X And _
            e.X <= objRect_Column_Min.X + objRect_Column_Min.Width) And _
            (e.Y >= objRect_Column_Min.Y And e.Y <= objRect_Column_Min.Y + objRect_Column_Min.Height) Then
            If objHitTest.RowIndex > -1 Then

                objDGVR = DataGridView_Attributes.Rows(objHitTest.RowIndex)
                objDRV = objDGVR.DataBoundItem
                If e.Delta > 0 Then
                    inc_Attr_Min(objDRV)
                ElseIf e.Delta < 0 Then
                    dec_Attr_Min(objDRV)
                End If

            End If
        End If

        objRect_Column_Max_forw = DataGridView_Attributes.GetColumnDisplayRectangle(7, True)
        If (e.X >= objRect_Column_Max_forw.X And _
            e.X <= objRect_Column_Max_forw.X + objRect_Column_Max_forw.Width) And _
            (e.Y >= objRect_Column_Max_forw.Y And e.Y <= objRect_Column_Max_forw.Y + objRect_Column_Max_forw.Height) Then
            If objHitTest.RowIndex > -1 Then
                objDGVR = DataGridView_Attributes.Rows(objHitTest.RowIndex)
                objDRV = objDGVR.DataBoundItem
                If e.Delta > 0 Then
                    inc_Attr_Max(objDRV)
                ElseIf e.Delta < 0 Then
                    dec_Attr_Max(objDRV)
                End If
            End If
        End If

        
    End Sub

   

   

    Private Sub ToolStripTextBox_ClassName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_ClassName.TextChanged
        If ToolStripTextBox_ClassName.ReadOnly = False Then
            Timer_ClassName.Start()
        End If

    End Sub

   

   
    Private Sub frmTypeEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton_DelRelated_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton_AddType_Forw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddType_Forw.Click
        Dim objSemItems_Selected() As clsSemItem
        Dim objSemItem_Type_Selected As clsSemItem
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim objDRC_LogState As DataRowCollection

        objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)
        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.Applied_SemItems = True Then
                objSemItems_Selected = objFrmSemManager.SemItems_Selected
                If Not objSemItems_Selected Is Nothing Then
                    If objSemItems_Selected.Length = 1 Then
                        objSemItem_Type_Selected = objSemItems_Selected(0)
                        If objSemItem_Type_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                            objFrmSemManager = New frmSemManager(objLocalConfig.Globals.ObjectReferenceType_RelationType, objLocalConfig.Globals)
                            objFrmSemManager.Applyabale = True
                            objFrmSemManager.ShowDialog(Me)
                            If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                                If Not objFrmSemManager.SelectedRows_Items Is Nothing Then
                                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID Then
                                        If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                            objDGVR = objFrmSemManager.SelectedRows_Items(0)
                                            objDRV = objDGVR.DataBoundItem
                                            objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objSemItem_Type.GUID, objSemItem_Type_Selected.GUID, objDRV.Item("GUID_RelationType"), 1, 1, -1).Rows
                                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                                                MsgBox("Die Beziehung zwischen diesem Typ und dem anderen konnte nicht gesetzt werden.", MsgBoxStyle.Exclamation)

                                            End If
                                            get_Type_Realtions()
                                        Else
                                            MsgBox("Bitte nur einen Beziehungstyp auswählen!", MsgBoxStyle.Exclamation)
                                        End If


                                    End If
                                End If
                            End If
                        Else
                            MsgBox("Bitte nur ein Type auswählen!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Bitte nur ein Item auswählen!", MsgBoxStyle.Exclamation)
                    End If


                Else
                    MsgBox("Sie müssen ein Type auswählen!", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub

   
    Private Sub ToolStripButton_Remove_TypeRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Remove_TypeRight.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_Token As DataRowCollection
        Dim objDRC_Type As DataRowCollection
        Dim GUID_Type_Left As Guid
        Dim GUID_Type_Right As Guid
        Dim GUID_RelationType As Guid
        Dim intToDo As Integer
        Dim intDone As Integer

        intToDo = DataGridView_RelationsForward.SelectedRows.Count
        intDone = 0
        For Each objDGVR_Selected In DataGridView_RelationsForward.SelectedRows

            objDRV_Selected = objDGVR_Selected.DataBoundItem

            GUID_Type_Left = objDRV_Selected.Item("GUID_Type_Left")
            GUID_Type_Right = objDRV_Selected.Item("GUID_Type_Right")
            GUID_RelationType = objDRV_Selected.Item("GUID_RelationType")

            objDRC_Token = funcA_TokenToken.GetData_By_GUIDTypeLeft_GUIDRelationType_GUIDTypeRight(GUID_Type_Left, GUID_Type_Right, GUID_RelationType).Rows
            If objDRC_Token.Count = 0 Then
                objDRC_Type = semprocA_DBWork_Del_TypeRel.GetData(GUID_Type_Left, GUID_Type_Right, GUID_RelationType).Rows
                If objDRC_Type(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    intDone = intDone + 1
                End If
                get_Type_Realtions()
            Else
                MsgBox("Die Beziehung kann nicht gelöscht werden, weil es noch Token gibt, die die Beziehung ausprägen!", MsgBoxStyle.Exclamation)
            End If


        Next
        If intDone < intToDo Then
            MsgBox("Es wurden " & intDone & " von " & intToDo & " Items entfernt!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ToolStripButton_AddRelationType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddRelationType.Click
        Dim objDGVSRC_Selected As DataGridViewSelectedRowCollection
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_LogState As DataRowCollection

        objFrmSemManager = New frmSemManager(objLocalConfig.Globals.ObjectReferenceType_RelationType, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)
        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID Then
                objDGVSRC_Selected = objFrmSemManager.SelectedRows_Items


                If Not objDGVSRC_Selected Is Nothing Then
                    If objDGVSRC_Selected.Count = 1 Then
                        objDGVR_Selected = objDGVSRC_Selected(0)
                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                        objDRC_LogState = semprocA_DBWork_Save_Type_OR.GetData(objSemItem_Type.GUID, objDRV_Selected.Item("GUID_RelationType"), 1, -1).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            MsgBox("Die Beziehung konnte nicht eingefügt werden!", MsgBoxStyle.Exclamation)
                        End If
                        get_Type_Realtions()
                    Else
                        MsgBox("Bitte nur ein Item vom Typ ""RelationType"" auswählen!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Bitte ein Item vom Typ ""RelationType"" auswählen!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte ein Item vom Typ ""RelationType"" auswählen!", MsgBoxStyle.Exclamation)
            End If
        
        End If

    End Sub

    Private Sub ToolStripButton_DelRelationType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_DelRelationType.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_Token_OR As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim intCount_ToDo As Integer
        Dim intCount_Done As Integer

        intCount_ToDo = DataGridView_ObjectReferences.SelectedRows.Count
        intCount_Done = 0
        For Each objDGVR_Selected In DataGridView_ObjectReferences.SelectedRows
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objDRC_Token_OR = funcA_Token_OR.GetData_By_GUIDTypeLeft_GUIDRelationType(objSemItem_Type.GUID, objDRV_Selected.Item("GUID_RelationType")).Rows
            If objDRC_Token_OR.Count = 0 Then
                objDRC_LogState = semprocA_DBWork_Del_Type_OR.GetData(objSemItem_Type.GUID, objDRV_Selected.Item("GUID_RelationType")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    intCount_Done = intCount_Done + 1
                End If
            End If
        Next
        If intCount_Done < intCount_ToDo Then
            MsgBox("Es konnten nur " & intCount_Done & " von " & intCount_ToDo & " Items gelöscht werden!", MsgBoxStyle.Exclamation)
        End If
        get_Type_Realtions()

    End Sub

    Private Sub ToolStripButton_AddType_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddType_Back.Click
        Dim objSemItems_Selected() As clsSemItem
        Dim objSemItem_Type_Selected As clsSemItem
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim objDRC_LogState As DataRowCollection

        objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)
        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.Applied_SemItems = True Then
                objSemItems_Selected = objFrmSemManager.SemItems_Selected
                If Not objSemItems_Selected Is Nothing Then
                    If objSemItems_Selected.Length = 1 Then
                        objSemItem_Type_Selected = objSemItems_Selected(0)
                        If objSemItem_Type_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                            objFrmSemManager = New frmSemManager(objLocalConfig.Globals.ObjectReferenceType_RelationType, objLocalConfig.Globals)
                            objFrmSemManager.Applyabale = True
                            objFrmSemManager.ShowDialog(Me)
                            If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                                If Not objFrmSemManager.SelectedRows_Items Is Nothing Then
                                    If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID Then
                                        If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                            objDGVR = objFrmSemManager.SelectedRows_Items(0)
                                            objDRV = objDGVR.DataBoundItem
                                            objDRC_LogState = semprocA_DBWork_Save_TypeRel.GetData(objSemItem_Type_Selected.GUID, objSemItem_Type.GUID, objDRV.Item("GUID_RelationType"), 1, 1, -1).Rows
                                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                                                MsgBox("Die Beziehung zwischen diesem Typ und dem anderen konnte nicht gesetzt werden.", MsgBoxStyle.Exclamation)

                                            End If
                                            get_Type_Realtions()
                                        Else
                                            MsgBox("Bitte nur einen Beziehungstyp auswählen!", MsgBoxStyle.Exclamation)
                                        End If


                                    End If
                                End If
                            End If
                        Else
                            MsgBox("Bitte nur ein Type auswählen!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Bitte nur ein Item auswählen!", MsgBoxStyle.Exclamation)
                    End If


                Else
                    MsgBox("Sie müssen ein Type auswählen!", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub
    Private Function set_Attrib_Max_OK(ByVal GUID_Attribute As Guid, ByVal intMax_New As Integer) As clsSemItem
        Dim objDRC_TypeAttribute As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem


        If intMax_New > 0 Then
            objDRC_TypeAttribute = typefuncA_Types_With_Attributes_And_Types.GetData_Type_And_Attribute_By_GUIDs(objSemItem_Type.GUID, GUID_Attribute).Rows
            If objDRC_TypeAttribute.Count > 0 Then
                If Not intMax_New = objDRC_TypeAttribute(0).Item("Max") Then
                    If intMax_New >= objDRC_TypeAttribute(0).Item("Min") Or intMax_New = -1 Then
                        objDRC_LogState = semprocA_DBWork_Save_TypeAttribute.GetData(objSemItem_Type.GUID, GUID_Attribute, objDRC_TypeAttribute(0).Item("Min"), intMax_New).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        End If

                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Delete
            End If
        Else

            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        

        Return objSemItem_Result
    End Function

    Private Function set_Attrib_Min_OK(ByVal GUID_Attribute As Guid, ByVal intMin_New As Integer) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_TypeAttribute As DataRowCollection

        If intMin_New >= 0 Then
            objDRC_TypeAttribute = typefuncA_Types_With_Attributes_And_Types.GetData_Type_And_Attribute_By_GUIDs(objSemItem_Type.GUID, GUID_Attribute).Rows
            If objDRC_TypeAttribute.Count > 0 Then
                If Not intMin_New = objDRC_TypeAttribute(0).Item("Min") Then
                    If intMin_New <= objDRC_TypeAttribute(0).Item("Max") Then
                        objDRC_LogState = semprocA_DBWork_Save_TypeAttribute.GetData(objSemItem_Type.GUID, GUID_Attribute, intMin_New, objDRC_TypeAttribute(0).Item("Max")).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If

                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Delete
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Private Sub ToolStripButton_DelType_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_DelType_Back.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_Token As DataRowCollection
        Dim objDRC_Type As DataRowCollection
        Dim GUID_Type_Left As Guid
        Dim GUID_Type_Right As Guid
        Dim GUID_RelationType As Guid
        Dim intToDo As Integer
        Dim intDone As Integer

        intToDo = DataGridView_BackwardRelations.SelectedRows.Count
        intDone = 0
        For Each objDGVR_Selected In DataGridView_BackwardRelations.SelectedRows

            objDRV_Selected = objDGVR_Selected.DataBoundItem

            GUID_Type_Left = objDRV_Selected.Item("GUID_Type_Left")
            GUID_Type_Right = objDRV_Selected.Item("GUID_Type_Right")
            GUID_RelationType = objDRV_Selected.Item("GUID_RelationType")

            objDRC_Token = funcA_TokenToken.GetData_By_GUIDTypeLeft_GUIDRelationType_GUIDTypeRight(GUID_Type_Left, GUID_Type_Right, GUID_RelationType).Rows
            If objDRC_Token.Count = 0 Then
                objDRC_Type = semprocA_DBWork_Del_TypeRel.GetData(GUID_Type_Left, GUID_Type_Right, GUID_RelationType).Rows
                If objDRC_Type(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    intDone = intDone + 1
                End If
                get_Type_Realtions()
            Else
                MsgBox("Die Beziehung kann nicht gelöscht werden, weil es noch Token gibt, die die Beziehung ausprägen!", MsgBoxStyle.Exclamation)
            End If


        Next
        If intDone < intToDo Then
            MsgBox("Es wurden " & intDone & " von " & intToDo & " Items entfernt!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    

    Private Function set_OR_Min_OK(ByVal GUID_RelationType As Guid, ByVal intMin_New As Integer) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_TypeOR_Rel As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_TypeOR_Rel As DataRow
        Dim boolRelFound As Boolean = False

        If intMin_New >= 0 Then
            objDRC_TypeOR_Rel = procA_Type_OR_By_GUIDType.GetData(objSemItem_Type.GUID).Rows
            For Each objDR_TypeOR_Rel In objDRC_TypeOR_Rel
                If objDR_TypeOR_Rel.Item("GUID_RelationType") = GUID_RelationType Then
                    boolRelFound = True
                    Exit For

                End If
            Next

            If boolRelFound = True Then
                If Not intMin_New = objDR_TypeOR_Rel.Item("Min_forw") Then
                    If intMin_New <= objDR_TypeOR_Rel.Item("Max_forw") Or objDR_TypeOR_Rel.Item("Max_forw") = -1 Then
                        objDRC_LogState = semprocA_DBWork_Save_Type_OR.GetData(objSemItem_Type.GUID, _
                                                                               GUID_RelationType, _
                                                                               intMin_New, _
                                                                               objDR_TypeOR_Rel.Item("Max_forw")).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        End If
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Delete
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        

        Return objSemItem_Result
    End Function

    Private Function set_OR_Max_OK(ByVal GUID_RelationType As Guid, ByVal intMax_New As Integer) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_TypeOR_Rel As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_TypeOR_Rel As DataRow
        Dim boolRelFound As Boolean = False

        If intMax_New > 0 Or intMax_New = -1 Then
            objDRC_TypeOR_Rel = procA_Type_OR_By_GUIDType.GetData(objSemItem_Type.GUID).Rows
            For Each objDR_TypeOR_Rel In objDRC_TypeOR_Rel
                If objDR_TypeOR_Rel.Item("GUID_RelationType") = GUID_RelationType Then
                    boolRelFound = True
                    Exit For

                End If
            Next

            If boolRelFound = True Then

                If Not intMax_New = objDR_TypeOR_Rel.Item("Max_forw") Then
                    If intMax_New >= objDR_TypeOR_Rel.Item("Min_forw") Or intMax_New = -1 Then
                        objDRC_LogState = semprocA_DBWork_Save_Type_OR.GetData(objSemItem_Type.GUID, _
                                                                               GUID_RelationType, _
                                                                               objDR_TypeOR_Rel.Item("Min_forw"), _
                                                                               intMax_New).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        End If
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Delete
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Private Sub DataGridView_ObjectReferences_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_ObjectReferences.CellDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDlgAttribute_Int As dlgAttribute_Int
        Dim objSemItem_Result As clsSemItem

        Dim boolMin As Boolean
        Dim boolShowDialog As Boolean = False
        Dim intValue As Integer

        objDGVR_Selected = DataGridView_ObjectReferences.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem

        Select Case DataGridView_ObjectReferences.Columns(e.ColumnIndex).Name
            Case "Min_forw"
                boolMin = True
                boolShowDialog = True
            Case "Max_forw"
                boolMin = False
                boolShowDialog = True
        End Select

        If boolShowDialog = True Then
            objDlgAttribute_Int = New dlgAttribute_Int(DataGridView_ObjectReferences.Columns(e.ColumnIndex).Name, objLocalConfig.Globals, objDRV_Selected.Item(DataGridView_ObjectReferences.Columns(e.ColumnIndex).Name))
            objDlgAttribute_Int.ShowDialog(Me)
            If objDlgAttribute_Int.DialogResult = Windows.Forms.DialogResult.OK Then
                intValue = objDlgAttribute_Int.Value
                If boolMin = True Then
                    objSemItem_Result = set_OR_Min_OK(objDRV_Selected.Item("Guid_RelationType"), intValue)
                    Select Case objSemItem_Result.GUID
                        Case objLocalConfig.Globals.LogState_Success.GUID
                            get_Type_Realtions()
                        Case objLocalConfig.Globals.LogState_Delete.GUID
                            MsgBox("Die Beziehung existiert nicht mehr!", MsgBoxStyle.Exclamation)
                        Case objLocalConfig.Globals.LogState_Error.GUID
                            MsgBox("Der Wert liegt außerhalb des Bereichs!", MsgBoxStyle.Exclamation)
                            get_Type_Realtions()
                    End Select
                Else
                    objSemItem_Result = set_OR_Max_OK(objDRV_Selected.Item("Guid_RelationType"), intValue)
                End If
            End If

        End If
    End Sub

    Private Sub Timer_ClassName_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_ClassName.Tick
        Timer_ClassName.Stop()
        Dim strName_Class As String
        Dim objDRC_Class As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        strName_Class = ToolStripTextBox_ClassName.Text
        boolChange_Name = False
        objDRC_Class = semtblA_Type.GetData_By_GUID(objSemItem_Type.GUID).Rows
        If objDRC_Class.Count > 0 Then
            objDRC_LogState = semprocA_DBWork_Save_Type.GetData(objSemItem_Type.GUID, strName_Class, objSemItem_Type.GUID_Parent).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Or objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then
                boolChange_Name = True
                objSemItem_Type.Name = strName_Class
            Else
                MsgBox("Der Klassenname kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                ToolStripTextBox_ClassName.ReadOnly = True
                ToolStripTextBox_ClassName.Text = objSemItem_Type.Name
                ToolStripTextBox_ClassName.ReadOnly = False
            End If
        Else
            MsgBox("Die Klasse existiert nicht mehr!", MsgBoxStyle.Critical)
            Me.Close()
        End If
    End Sub


    Private Sub ToolStripButton_DelClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_DelClass.Click
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objTransaction_Types.del_001_Type(objSemItem_Type)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            Me.Close()
        Else
            MsgBox("Die Klasse konnte nicht gelöscht werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class