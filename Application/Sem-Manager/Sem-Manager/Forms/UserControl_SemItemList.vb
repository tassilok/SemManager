Public Class UserControl_SemItemList
    Private objLocalConfig As New clsLocalConfig_SemList

    Private objFrmSemManager As frmSemManager
    Private objFrmTokenEdit As frmTokenEdit
    Private objDlgAttribute_Bool As dlgAttribute_Bool
    Private objDlgAttribute_Datetime As dlgAttribute_Datetime
    Private objDlgAttribute_Int As dlgAttribute_Int
    Private objDlgAttribute_Real As dlgAttribute_Real
    Private objDlgAttribute_Varchar255 As dlgAttribute_Varchar255
    Private objDlgAttribute_VarcharMax As dlgAttribute_VarcharMax
    Private objFrm_RelationTypeEdit As frmRelationTypeEdit
    Private objFrm_FilterAdvanced As frmFilter_Advanced
    Private objFrm_Replace As FrmReplace

    Private objFrmAttributeEdit As frmAttributeEdit

    Private objUserControl_TreeOfToken As UserControl_TreeOfToken

    Private objSemClipboard As clsSemClipboard

    Private AttributeA_List_With_TypeName As New ds_AttributeTableAdapters.Attribute_List_With_TypeNameTableAdapter
    Private Attribute_List_With_TypeName As New ds_Attribute.Attribute_List_With_TypeNameDataTable
    Private semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtbl_Token As New ds_SemDB.semtbl_TokenDataTable
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtbl_Type As New ds_SemDB.semtbl_TypeDataTable
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter
    Private semtbl_RelationType As New ds_SemDB.semtbl_RelationTypeDataTable

    Private semtblA_TokenAttribute_Bit As New ds_SemDBTableAdapters.semtbl_Token_Attribute_BitTableAdapter
    Private semtblA_TokenAttribute_Date As New ds_SemDBTableAdapters.semtbl_Token_Attribute_DateTableAdapter
    Private semtblA_TokenAttribute_DateTime As New ds_SemDBTableAdapters.semtbl_Token_attribute_datetimeTableAdapter
    Private semtblA_TokenAttribute_Int As New ds_SemDBTableAdapters.semtbl_Token_Attribute_IntTableAdapter
    Private semtblA_TokenAttribute_Real As New ds_SemDBTableAdapters.semtbl_Token_Attribute_RealTableAdapter
    Private semtblA_TokenAttribute_Time As New ds_SemDBTableAdapters.semtbl_Token_Attribute_TimeTableAdapter
    Private semtblA_TokenAttribute_Varchar255 As New ds_SemDBTableAdapters.semtbl_Token_Attribute_varchar255TableAdapter
    Private semtblA_TokenAttribute_VarcharMax As New ds_SemDBTableAdapters.semtbl_Token_Attribute_varcharMAXTableAdapter


    'Private funcA_TokenAttribute_Named As New ds_TokenAttributeTableAdapters.func_TokenAttribute_NamedTableAdapter
    'Private func_TokenAttribute_Named As New ds_TokenAttribute.func_TokenAttribute_NamedDataTable
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private funcT_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttribute.func_TokenAttribute_Named_By_GUIDTokenDataTable
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private funcT_Token_OR As New ds_ObjectReference.func_Token_ORDataTable
    Private procA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private procA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private procA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter
    'Private semfuncA_Token_Attribute As New ds_TokenAttributeTableAdapters.semfunc_Token_AttributeTableAdapter
    'Private semfunc_Token_Attribute As New ds_TokenAttribute.semfunc_Token_AttributeDataTable
    'Private semfuncA_Token_Attribute_Bit As New ds_TokenAttributeTableAdapters.TokenAttribute_BitTableAdapter
    'Private semfunc_Token_Attribute_Bit As New ds_TokenAttribute.TokenAttribute_BitDataTable
    'Private semfuncA_Token_Attribute_Date As New ds_TokenAttributeTableAdapters.TokenAttribute_DateTableAdapter
    'Private semfunc_Token_Attribute_Date As New ds_TokenAttribute.TokenAttribute_DateDataTable
    'Private semfuncA_Token_Attribute_Int As New ds_TokenAttributeTableAdapters.TokenAttribute_IntTableAdapter
    'Private semfunc_Token_Attribute_Int As New ds_TokenAttribute.TokenAttribute_IntDataTable
    'Private semfuncA_Token_Attribute_Real As New ds_TokenAttributeTableAdapters.TokenAttribute_RealTableAdapter
    'Private semfunc_Token_Attribute_Real As New ds_TokenAttribute.TokenAttribute_RealDataTable
    'Private semfuncA_Token_Attribute_Time As New ds_TokenAttributeTableAdapters.TokenAttribute_TimeTableAdapter
    'Private semfunc_Token_Attribute_Time As New ds_TokenAttribute.TokenAttribute_TimeDataTable
    'Private semfuncA_Token_Attribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter
    'Private semfunc_Token_Attribute_Varchar255 As New ds_TokenAttribute.TokenAttribute_Varchar255DataTable
    'Private semfuncA_Token_Attribute_VarcharMAX As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter
    'Private semfunc_Token_Attribute_VarcharMAX As New ds_TokenAttribute.TokenAttribute_VarcharMAXDataTable

    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Date As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DateTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Datetime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Int As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_IntTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Real As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_RealTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Time As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_TimeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Varchar255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VarcharMax As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenOR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Del_Attribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_AttributeTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Del_RelationType As New ds_DBWorkTableAdapters.semproc_DBWork_Del_RelationTypeTableAdapter
    Private semprocA_DBWork_Del_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter

    'Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter
    'Private semfunc_ObjectReference As New ds_ObjectReference.semfunc_ObjectReferenceDataTable

    Private semfuncA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semfunc_TokenToken As New ds_Token.func_TokenTokenDataTable
    'Private semfuncA_TokenToken_OR_LeftRight As New ds_TokenTableAdapters.func_TokenToken_OR_LeftRightTableAdapter
    'Private semfunc_TokenToken_OR_LeftRight As New ds_Token.func_TokenToken_OR_LeftRightDataTable
    'Private semfuncA_TokenToken_OR_RightLeft As New ds_TokenTableAdapters.func_TokenToken_OR_RightLeftTableAdapter
    'Private semfunc_TokenToken_OR_RightLeft As New ds_Token.func_TokenToken_OR_RightLeftDataTable


    Private objDGRVRC_Selected As DataGridViewRowCollection
    Private objDRV_Selected As DataRowView

    Private objSemItem_Parent As clsSemItem
    Private objSemItem_Complex_Base As clsSemItem
    Private objSemItem_Filter_Complex As clsSemItem
    Private objSemItem_Added As clsSemItem
    Private objFilter As clsFilter
    Private objSemItem_FilterBase As clsSemItem

    Private objSemItem_Other As clsSemItem
    Private objSemItem_RelationType As clsSemItem

    Public Event Applied_Item()
    Public Event Attributes_Changed()
    Public Event Selection_Changed()
    Public Event Item_Added(ByVal objSemItem_Item As clsSemItem)

    Private strGUID_Filter As String
    Private strName_Filter As String

    Private strRowName_GUID As String
    Private strRowName_Name As String

    Private boolApplyable As Boolean
    Private boolProgChange As Boolean
    Private boolComplex As Boolean
    Private boolProgChange_Filter As Boolean
    Private boolModuleView As Boolean = True
    Private boolComplexToken As Boolean

    Public Property SemItem_Other As clsSemItem
        Get
            Return objSemItem_Other
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_Other = value
            configure_Relation()
        End Set
    End Property

    Public Property SemItem_RelationType As clsSemItem
        Get
            Return objSemItem_RelationType
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_RelationType = value
            configure_Relation()
        End Set
    End Property

    Public Property visibility_Filter As Boolean
        Get
            Return ToolStrip_Filter.Visible
        End Get
        Set(ByVal value As Boolean)
            ToolStrip_Filter.Visible = value
        End Set
    End Property

    Public Property visibility_Edit As Boolean
        Get
            Return ToolStrip_Edit.Visible
        End Get
        Set(ByVal value As Boolean)
            ToolStrip_Edit.Visible = value
        End Set
    End Property
    Public Property ModuleView() As Boolean
        Get
            Return boolModuleView
        End Get
        Set(ByVal value As Boolean)
            boolModuleView = value
        End Set
    End Property

    Public ReadOnly Property RowName_GUID() As String
        Get
            Return strRowName_GUID
        End Get
    End Property
    Public ReadOnly Property RowName_Name() As String
        Get
            Return strRowName_Name
        End Get
    End Property
    Public ReadOnly Property ByUser() As Boolean
        Get
            Return Not boolProgChange
        End Get
    End Property
    Public ReadOnly Property GUID_Type_Selected() As Guid
        Get
            If objSemItem_Complex_Base Is Nothing Then
                If objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Or objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                    Return objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                Else
                    Return objSemItem_Parent.GUID_Type
                End If


            Else

                Return objSemItem_Complex_Base.GUID_Type

            End If
        End Get
    End Property
    Public ReadOnly Property DataGridViewRowCollection_Selected() As DataGridViewSelectedRowCollection
        Get
            Return DataGridView_Items.SelectedRows()
        End Get

    End Property

    Public ReadOnly Property DataGridViewRows() As DataGridViewRowCollection
        Get
            Return DataGridView_Items.Rows
        End Get
    End Property

    Public ReadOnly Property RowCounts() As Integer
        Get
            Return DataGridView_Items.RowCount
        End Get
    End Property


    Public Property Applyable() As Boolean
        Get
            Return boolApplyable
        End Get
        Set(ByVal value As Boolean)
            boolApplyable = value
            set_Controls_Applyable()
        End Set
    End Property

    Private Sub configure_Relation()
        If Not objSemItem_Other Is Nothing And Not objSemItem_RelationType Is Nothing Then
            ToolStripButton_Relate.Enabled = True
        End If
    End Sub

    Public Sub select_Row(ByVal GUID_Row As Guid)
        Dim objGUID_Type As Guid
        Dim boolObjectReference As Boolean
        Dim intIdRow As Integer

        If objSemItem_Complex_Base Is Nothing Then
            objGUID_Type = objSemItem_Parent.GUID_Type
            boolObjectReference = False

        Else
            objGUID_Type = objSemItem_Complex_Base.GUID_Type
            boolObjectReference = objSemItem_Complex_Base.Rel_ObjectReference
        End If

        DataGridView_Items.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect

        Select Case objGUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.GUID


                If objSemItem_Complex_Base Is Nothing Then
                
                    strRowName_GUID = "GUID_Attribute"
                    strRowName_Name = "Name_Attribute"
                Else

                
                    strRowName_GUID = "GUID_TokenAttribute"
                    strRowName_Name = "Val_Named"

                End If

                If Not strGUID_Filter = "" Then
                    intIdRow = BindingSource_Attribute.Find(strRowName_GUID, GUID_Row)
                    If intIdRow > -1 Then

                        BindingSource_Attribute.Position = intIdRow
                        If Not DataGridView_Items.CurrentRow Is Nothing Then
                            DataGridView_Items.CurrentRow.Selected = True
                        End If

                    End If
                End If

            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                strRowName_GUID = "GUID_RelationType"


                intIdRow = BindingSource_RelationType.Find(strRowName_GUID, GUID_Row)
                If intIdRow > -1 Then

                    BindingSource_RelationType.Position = intIdRow
                    If Not DataGridView_Items.CurrentRow Is Nothing Then
                        DataGridView_Items.CurrentRow.Selected = True
                    End If

                End If


            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID, objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                ToolStripButton_FilterAdvanced.Enabled = True
                If objSemItem_Filter_Complex Is Nothing Then
                    boolComplex = False
                Else
                    boolComplex = True
                End If
                
                If boolComplex = True Then
                    If objSemItem_Filter_Complex.Direction = objSemItem_Filter_Complex.Direction_LeftRight Then
                        If boolObjectReference = True Then
                
                            strRowName_GUID = "GUID_ObjectReference"
                            strRowName_Name = "Name_Ref"
                            intIdRow = BindingSource_TokenToken.Find(strRowName_GUID, GUID_Row)
                            If intIdRow > -1 Then
                                BindingSource_TokenToken.Position = intIdRow
                                If Not DataGridView_Items.CurrentRow Is Nothing Then
                                    DataGridView_Items.CurrentRow.Selected = True
                                End If

                            End If
                        Else

                            strRowName_GUID = "GUID_Token_Right"
                            strRowName_Name = "Name_Token_Right"
                            intIdRow = BindingSource_TokenToken.Find(strRowName_GUID, GUID_Row)
                            If intIdRow > -1 Then
                                BindingSource_TokenToken.Position = intIdRow
                                If Not DataGridView_Items.CurrentRow Is Nothing Then
                                    DataGridView_Items.CurrentRow.Selected = True
                                End If

                            End If
                        End If

                    Else


                        strRowName_GUID = "GUID_Token_Left"
                        strRowName_Name = "Name_Token_Left"
                        intIdRow = BindingSource_TokenToken.Find(strRowName_GUID, GUID_Row)
                        If intIdRow > -1 Then
                            BindingSource_TokenToken.Position = intIdRow
                            If Not DataGridView_Items.CurrentRow Is Nothing Then
                                DataGridView_Items.CurrentRow.Selected = True
                            End If

                        End If
                    End If


                Else

                    If objSemItem_Complex_Base Is Nothing Then


                        strRowName_GUID = "GUID_Token"
                        strRowName_Name = "Name_Token"

                        intIdRow = BindingSource_Token.Find(strRowName_GUID, GUID_Row)
                        If intIdRow > -1 Then
                            BindingSource_Token.Position = intIdRow
                            If Not DataGridView_Items.CurrentRow Is Nothing Then
                                DataGridView_Items.CurrentRow.Selected = True
                            End If

                        End If
                    Else
                        If boolComplexToken = False Then
                            If objSemItem_Complex_Base.Direction = objSemItem_Complex_Base.Direction_LeftRight Then
                                If boolObjectReference = True Then


                                    strRowName_GUID = "GUID_ObjectReference"
                                    strRowName_Name = "Name_Ref"
                                    intIdRow = BindingSource_TokenToken.Find(strRowName_GUID, GUID_Row)
                                    If intIdRow > -1 Then
                                        BindingSource_TokenToken.Position = intIdRow
                                        If Not DataGridView_Items.CurrentRow Is Nothing Then
                                            DataGridView_Items.CurrentRow.Selected = True
                                        End If

                                    End If

                                Else

                                    strRowName_GUID = "GUID_Token_Right"
                                    strRowName_Name = "Name_Token_Right"
                                    intIdRow = BindingSource_TokenToken.Find(strRowName_GUID, GUID_Row)
                                    If intIdRow > -1 Then
                                        BindingSource_TokenToken.Position = intIdRow
                                        If Not DataGridView_Items.CurrentRow Is Nothing Then
                                            DataGridView_Items.CurrentRow.Selected = True
                                        End If

                                    End If
                                End If


                            Else


                                If boolObjectReference = True Then
                                    funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(funcT_Token_OR, objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Relation)

                                    strRowName_GUID = "GUID_ObjectReference"
                                    strRowName_Name = "Name_Ref"
                                    intIdRow = BindingSource_TokenToken.Find(strRowName_GUID, GUID_Row)

                                    If intIdRow > -1 Then
                                        BindingSource_TokenToken.Position = intIdRow
                                        If Not DataGridView_Items.CurrentRow Is Nothing Then
                                            DataGridView_Items.CurrentRow.Selected = True
                                        End If

                                    End If
                                Else
                                    semfuncA_TokenToken.Fill_TokenToken_RightLeft(semfunc_TokenToken, objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Relation, objSemItem_Complex_Base.GUID_Related)
                                    strRowName_GUID = "GUID_Token_Left"
                                    strRowName_Name = "Name_Token_Left"
                                    intIdRow = BindingSource_TokenToken.Find(strRowName_GUID, GUID_Row)

                                    If intIdRow > -1 Then
                                        BindingSource_TokenToken.Position = intIdRow
                                        If Not DataGridView_Items.CurrentRow Is Nothing Then
                                            DataGridView_Items.CurrentRow.Selected = True
                                        End If

                                    End If
                                End If



                            End If
                        Else



                        End If


                    End If


                End If


        End Select

    End Sub

    Public Sub Activate_List()
        TabControl1.SelectedTab = TabPage_List
    End Sub
        
    Public Sub Activate_Tree()
        TabControl1.SelectedTab = TabPage_Tree
    End Sub
        
    Public Sub clear_List()
        DataGridView_Items.DataSource = Nothing
    End Sub
    Public Sub filter_View_GUID_Token(ByVal GUID_Filter As Guid)
        strGUID_Filter = GUID_Filter.ToString
        strName_Filter = ""
        filter_Datagridview_Token()
    End Sub
    Public Sub filter_View_Item(ByVal objSemItem As clsSemItem)
        boolProgChange = True
        objSemItem_Filter_Complex = objSemItem
        strGUID_Filter = ""
        strName_Filter = ""
        ToolStripTextBox_Filter.Clear()
        get_Data(objSemItem_Filter_Complex)
        boolProgChange = False
    End Sub

    Public Sub filter_View_By_List(ByVal strName_Procedure As String, ByVal strName_Database As String, ByVal strName_Server As String, ByVal objParameters() As clsDBParameter)
        Dim objDBConn As SqlClient.SqlConnection
        Dim objDBCmd As SqlClient.SqlCommand
        Dim objDBAdapter As SqlClient.SqlDataAdapter
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim objDataTable As DataTable
        Dim objDataSet As New DataSet
        Dim objParam As clsDBParameter
        Dim objDRs_Selected() As DataRow
        Dim strRowName_GUID As String


        Dim boolObjectReference As Boolean
        Dim strSQL As String

        If objSemItem_Complex_Base Is Nothing Then

            boolObjectReference = False

        Else

            boolObjectReference = objSemItem_Complex_Base.Rel_ObjectReference
        End If



        If objSemItem_Filter_Complex Is Nothing Then
            boolComplex = False
            strRowName_GUID = "GUID_Token"
            BindingSource_Token.Position = -1
        Else
            BindingSource_TokenToken.Position = -1
            If objSemItem_Filter_Complex.Direction = objSemItem_Filter_Complex.Direction_LeftRight Then
                If boolObjectReference = True Then
                    strRowName_GUID = "GUID_ObjectReference"
                    BindingSource_TokenToken.Position = -1

                Else

                    strRowName_GUID = "GUID_Token_Right"

                End If

            Else


                strRowName_GUID = "GUID_Token_Left"

            End If

            boolComplex = True
        End If


        objDBConn = New SqlClient.SqlConnection(objLocalConfig.Globals.get_DB_ConnectionString(strName_Server, strName_Database))
        objDBConn.Open()

        objDBCmd = New SqlClient.SqlCommand(strName_Procedure, objDBConn)
        objDBCmd.CommandType = CommandType.Text

        strSQL = ""
        For Each objParam In objParameters
            If strSQL = "" Then
                strSQL = objParam.Name_Parameter & "="
            Else
                strSQL = strSQL & "," & objParam.Name_Parameter & "="
            End If

            If objParam.isString = True Then
                strSQL = strSQL & "'" & objParam.Value_Parameter & "'"
            Else
                strSQL = strSQL & objParam.Value_Parameter
            End If
        Next

        strSQL = "execute " & strName_Procedure & " " & strSQL
        objDBCmd.CommandText = strSQL
        objDBAdapter = New SqlClient.SqlDataAdapter(objDBCmd)
        objDBAdapter.Fill(objDataSet)
        objDataTable = objDataSet.Tables(0)

        For Each objDGVR In DataGridView_Items.Rows
            objDRV = objDGVR.DataBoundItem


            objDRs_Selected = objDataTable.Select("GUID_Item='" & objDRV.Item(strRowName_GUID).ToString & "'")
            If objDRs_Selected.Count = 1 Then

                For i = 0 To DataGridView_Items.ColumnCount - 1
                    DataGridView_Items.Rows(objDGVR.Index).Cells(i).Style.BackColor = Color.Green
                    DataGridView_Items.Rows(objDGVR.Index).Cells(i).Style.ForeColor = Color.White
                Next

            End If
        Next
        objDBConn.Close()

    End Sub

    Public Sub toNext_Colored(ByVal objBackColor As System.Drawing.Color)
        Dim boolStop As Boolean
        boolStop = False

        If objSemItem_Complex_Base Is Nothing Then

            If BindingSource_Token.Position < DataGridView_Items.Rows.Count - 1 Then
                BindingSource_Token.Position = BindingSource_Token.Position + 1
            End If

            While boolStop = False
                For i = 0 To DataGridView_Items.ColumnCount - 1
                    If DataGridView_Items.Rows(BindingSource_Token.Position).Cells(i).Style.BackColor = objBackColor Then
                        DataGridView_Items.Rows(BindingSource_Token.Position).Selected = True
                        boolStop = True
                        Exit For
                    End If

                Next
                If boolStop = False Then
                    If BindingSource_Token.Position = DataGridView_Items.Rows.Count - 1 Then
                        MsgBox("Das Ende der Liste wurde erreicht!", MsgBoxStyle.Information)
                        boolStop = True
                    Else
                        BindingSource_Token.Position = BindingSource_Token.Position + 1
                    End If
                End If

            End While


        Else
            If BindingSource_TokenToken.Position < DataGridView_Items.Rows.Count - 1 Then
                BindingSource_TokenToken.Position = BindingSource_TokenToken.Position + 1
            End If
            While boolStop = False
                For i = 0 To DataGridView_Items.ColumnCount - 1
                    If DataGridView_Items.Rows(BindingSource_TokenToken.Position).Cells(i).Style.BackColor = objBackColor Then
                        DataGridView_Items.Rows(BindingSource_TokenToken.Position).Selected = True
                        boolStop = True
                        Exit For
                    End If

                Next
                If boolStop = False Then
                    If BindingSource_TokenToken.Position = DataGridView_Items.Rows.Count - 1 Then
                        MsgBox("Das Ende der Liste wurde erreicht!", MsgBoxStyle.Information)
                        boolStop = True
                    Else
                        BindingSource_TokenToken.Position = BindingSource_TokenToken.Position + 1
                    End If
                End If

            End While

        End If




    End Sub
    Public Sub clear_Filter_GUID_Token()
        strGUID_Filter = ""
        filter_Datagridview_Token()
    End Sub
    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub set_Controls_Applyable()
        ApplyToolStripMenuItem.Visible = boolApplyable
    End Sub
    Private Sub set_DBConnection()
        objSemClipboard = New clsSemClipboard(objLocalConfig.Globals)

        AttributeA_List_With_TypeName.Connection = objLocalConfig.Connection_DB
        semtblA_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_RelationType.Connection = objLocalConfig.Connection_DB
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB

        semfuncA_TokenToken.Connection = objLocalConfig.Connection_DB
        'semfuncA_TokenToken_OR_LeftRight.Connection = objLocalConfig.Connection_DB
        'semfuncA_TokenToken_OR_RightLeft.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        'semfuncA_Token_Attribute.Connection = objLocalConfig.Connection_DB
        'semfuncA_Token_Attribute_Bit.Connection = objLocalConfig.Connection_DB
        'semfuncA_Token_Attribute_Date.Connection = objLocalConfig.Connection_DB
        'semfuncA_Token_Attribute_Int.Connection = objLocalConfig.Connection_DB
        'semfuncA_Token_Attribute_Real.Connection = objLocalConfig.Connection_DB
        'semfuncA_Token_Attribute_Time.Connection = objLocalConfig.Connection_DB
        'semfuncA_Token_Attribute_Varchar255.Connection = objLocalConfig.Connection_DB
        'semfuncA_Token_Attribute_VarcharMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Date.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Datetime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Int.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Real.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Time.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Varchar255.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VarcharMax.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Attribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_RelationType.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenOR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token_OR.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Attribute.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_RelationType.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Type.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB

        semtblA_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        semtblA_TokenAttribute_Date.Connection = objLocalConfig.Connection_DB
        semtblA_TokenAttribute_DateTime.Connection = objLocalConfig.Connection_DB
        semtblA_TokenAttribute_Int.Connection = objLocalConfig.Connection_DB
        semtblA_TokenAttribute_Real.Connection = objLocalConfig.Connection_DB
        semtblA_TokenAttribute_Time.Connection = objLocalConfig.Connection_DB
        semtblA_TokenAttribute_Varchar255.Connection = objLocalConfig.Connection_DB
        semtblA_TokenAttribute_VarcharMax.Connection = objLocalConfig.Connection_DB

        objUserControl_TreeOfToken = New UserControl_TreeOfToken(objLocalConfig.Globals)
        objUserControl_TreeOfToken.Dock = DockStyle.Fill
        TabPage_Tree.Controls.Add(objUserControl_TreeOfToken)

        'semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB
    End Sub

    Private Sub clear_Relation()
        objSemItem_Other = Nothing
        objSemItem_RelationType = Nothing
        ToolStripButton_Relate.Checked = False
        ToolStripButton_Relate.Enabled = False
    End Sub
    Public Sub initialize_Complex(ByVal BatItem_Complex As clsSemItem, ByVal Globals As clsGlobals)

        boolProgChange = True

        objLocalConfig.Globals = Globals
        objLocalConfig.Connection_DB = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)

        objSemItem_Complex_Base = BatItem_Complex

        ToolStripButton_AddItem.Visible = True
        ToolStripButton_DelItem.Visible = True
        ToolStripButton_Up.Visible = True
        ToolStripButton_Down.Visible = True
        ToolStripButton_Sort.Visible = True
        ToolStripButton_Report.Visible = True
        clear_Relation()
        set_DBConnection()
        get_Data()
        boolProgChange = False
    End Sub

    Public Sub initialize_Token_Complex(ByVal objSemItem_Item As clsSemItem, ByVal Globals As clsGlobals, _
                                        ByVal Filter As clsFilter)
        boolProgChange = True
        boolComplexToken = True
        objLocalConfig.Globals = Globals
        objLocalConfig.Connection_DB = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)
        objSemItem_Parent = objSemItem_Item
        objSemItem_FilterBase = objSemItem_Item
        objFilter = Filter
        ToolStripButton_AddItem.Visible = True
        ToolStripButton_DelItem.Visible = True
        ToolStripButton_Up.Visible = False
        ToolStripButton_Down.Visible = False
        ToolStripButton_Sort.Visible = False
        ToolStripButton_Report.Visible = True
        clear_Relation()
        set_DBConnection()
        get_Data()
        boolProgChange = False
    End Sub

    Public Sub initialize_Simple(ByVal BatItem_Parent As clsSemItem, ByVal Globals As clsGlobals)
        boolProgChange = True

        objLocalConfig.Globals = Globals
        objLocalConfig.Connection_DB = New SqlClient.SqlConnection(objLocalConfig.Globals.ConnectionString_User)

        objSemItem_Parent = BatItem_Parent

        ToolStripButton_AddItem.Visible = True
        ToolStripButton_DelItem.Visible = True
        ToolStripButton_Up.Visible = False
        ToolStripButton_Down.Visible = False
        ToolStripButton_Sort.Visible = False
        ToolStripButton_Report.Visible = True
        ToolStripTextBox_Filter.ReadOnly = True
        ToolStripTextBox_Filter.Text = ""
        ToolStripTextBox_Filter.ReadOnly = False
        clear_Relation()
        set_DBConnection()
        configure_TabPages()

        boolProgChange = False
    End Sub

    Private Sub get_Data(Optional ByVal objSemItem_Filter_Complex As clsSemItem = Nothing)
        Dim objGUID_Type As Guid
        Dim objGUID_Parent As Guid
        Dim strFilter As String

        Dim boolProgChange_Loc As Boolean
        Dim boolObjectReference As Boolean = False

        If objSemItem_Complex_Base Is Nothing Then
            objGUID_Type = objSemItem_Parent.GUID_Type
            boolObjectReference = False

        Else
            objGUID_Type = objSemItem_Complex_Base.GUID_Type
            boolObjectReference = objSemItem_Complex_Base.Rel_ObjectReference
        End If

        boolProgChange_Loc = boolProgChange
        boolProgChange = True

        DataGridView_Items.DataBindings.Clear()
        BindingSource_Attribute.Filter = ""
        BindingSource_RelationType.Filter = ""
        BindingSource_Token.Filter = ""
        BindingSource_TokenToken.Filter = ""
        BindingSource_Type.Filter = ""
        Select Case objGUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.GUID

                ToolStripButton_FilterAdvanced.Enabled = False

                If objSemItem_Complex_Base Is Nothing Then
                    AttributeA_List_With_TypeName.Fill(Attribute_List_With_TypeName)
                    BindingSource_Attribute.DataSource = Attribute_List_With_TypeName
                    strRowName_GUID = "GUID_Attribute"
                    strRowName_Name = "Name_Attribute"
                Else

                    funcA_TokenAttribute_Named_By_GUIDToken.Fill_By_GUIDToken_And_GUIDAttribute(funcT_TokenAttribute_Named_By_GUIDToken, objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Related)
                    BindingSource_Attribute.DataSource = funcT_TokenAttribute_Named_By_GUIDToken

                    strRowName_GUID = "GUID_TokenAttribute"
                    strRowName_Name = "Val_Named"

                End If

                If Not strGUID_Filter = "" Then
                    BindingSource_Attribute.Filter = strRowName_GUID & "='" & strGUID_Filter & "'"
                End If

                If Not strName_Filter = "" Then
                    strFilter = BindingSource_Attribute.Filter
                    If Not strFilter = "" Then
                        strFilter = strFilter & " AND "
                    End If


                    If Not objSemItem_Complex_Base Is Nothing Then
                        If objSemItem_Complex_Base.GUID_Relation = objLocalConfig.Globals.AttributeType_String.GUID _
                        Or objSemItem_Complex_Base.GUID_Relation = objLocalConfig.Globals.AttributeType_Varchar255.GUID Then
                            strFilter = strRowName_Name & " LIKE '%" & strName_Filter & "%'"
                        ElseIf objSemItem_Complex_Base.GUID_Relation = objLocalConfig.Globals.AttributeType_Time.GUID Then
                            strFilter = strRowName_Name & "='" & strName_Filter & "'"
                        Else
                            strFilter = strRowName_Name & "=" & strName_Filter
                        End If
                    Else
                        strFilter = strFilter & strRowName_Name & " LIKE '%" & strName_Filter & "%'"
                    End If


                    BindingSource_Attribute.Filter = strFilter
                End If
                DataGridView_Items.DataSource = BindingSource_Attribute
                If objSemItem_Complex_Base Is Nothing Then
                    DataGridView_Items.Columns(0).Visible = False
                    DataGridView_Items.Columns(2).Visible = False
                    DataGridView_Items.Columns(1).HeaderText = objLocalConfig.Globals.ObjectReferenceType_Attribute.Name
                    DataGridView_Items.Columns(1).Width = 300
                Else
                    DataGridView_Items.Columns(0).Visible = False
                    DataGridView_Items.Columns(1).Visible = False
                    DataGridView_Items.Columns(2).Visible = False
                    DataGridView_Items.Columns(3).Visible = False
                    DataGridView_Items.Columns(4).Visible = False
                    DataGridView_Items.Columns(5).HeaderText = objLocalConfig.Globals.ObjectReferenceType_Attribute.Name
                    DataGridView_Items.Columns(5).Width = 300
                    DataGridView_Items.Columns(6).Visible = False
                    DataGridView_Items.Columns(7).Visible = False
                    DataGridView_Items.Columns(8).Visible = False
                    DataGridView_Items.Columns(9).Visible = False
                    DataGridView_Items.Columns(10).Visible = False
                    DataGridView_Items.Columns(11).Visible = False
                    DataGridView_Items.Columns(12).Visible = False
                    DataGridView_Items.Columns(13).Visible = False


                End If


            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                ToolStripButton_FilterAdvanced.Enabled = False
                semtblA_RelationType.Fill(semtbl_RelationType)
                BindingSource_RelationType.DataSource = semtbl_RelationType
                strRowName_GUID = "GUID_RelationType"
                strRowName_Name = "Name_RelationType"
                If Not strGUID_Filter = "" Then
                    BindingSource_RelationType.Filter = "GUID_RelationType='" & strGUID_Filter & "'"
                End If

                If Not strName_Filter = "" Then
                    If BindingSource_RelationType.Filter = "" Then
                        BindingSource_RelationType.Filter = "Name_RelationType LIKE '%" & strName_Filter & "%'"
                    Else
                        BindingSource_RelationType.Filter = BindingSource_RelationType.Filter & " AND Name_RelationType LIKE '%" & strName_Filter & "%'"
                    End If
                End If
                DataGridView_Items.DataSource = BindingSource_RelationType
                DataGridView_Items.Columns(0).Visible = False
                DataGridView_Items.Columns(1).HeaderText = objLocalConfig.Globals.ObjectReferenceType_RelationType.Name
                DataGridView_Items.Columns(1).Width = 300
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID, objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                ToolStripButton_FilterAdvanced.Enabled = True
                If objSemItem_Filter_Complex Is Nothing Then
                    boolComplex = False
                Else
                    boolComplex = True
                End If
                If objGUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                    If objSemItem_Complex_Base Is Nothing Then
                        objGUID_Parent = objSemItem_Parent.GUID_Parent
                    Else
                        objGUID_Parent = objSemItem_Complex_Base.GUID_Parent
                    End If

                Else
                    If objSemItem_Complex_Base Is Nothing Then
                        objGUID_Parent = objSemItem_Parent.GUID
                    Else
                        objGUID_Parent = objSemItem_Complex_Base.GUID
                    End If

                End If
                If boolComplex = True Then
                    If objSemItem_Filter_Complex.Direction = objSemItem_Filter_Complex.Direction_LeftRight Then
                        If boolObjectReference = True Then
                            funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(funcT_Token_OR, objSemItem_Filter_Complex.GUID, objSemItem_Filter_Complex.GUID_Relation)

                            'semfuncA_TokenToken_OR_LeftRight.Fill_By_GUIDToken_And_GUIDRelationType(semfunc_TokenToken_OR_LeftRight, objSemItem_Filter_Complex.GUID, objSemItem_Filter_Complex.GUID_Relation)
                            strRowName_GUID = "GUID_ObjectReference"
                            strRowName_Name = "Name_Ref"
                            BindingSource_TokenToken.DataSource = funcT_Token_OR
                        Else
                            semfuncA_TokenToken.Fill_TokenToken_LeftRight(semfunc_TokenToken, objSemItem_Filter_Complex.GUID, objSemItem_Filter_Complex.GUID_Relation, objSemItem_Filter_Complex.GUID_Related)
                            strRowName_GUID = "GUID_Token_Right"
                            strRowName_Name = "Name_Token_Right"
                            BindingSource_TokenToken.DataSource = semfunc_TokenToken
                        End If

                    Else

                        semfuncA_TokenToken.Fill_TokenToken_RightLeft(semfunc_TokenToken, objSemItem_Filter_Complex.GUID, objSemItem_Filter_Complex.GUID_Relation, objSemItem_Filter_Complex.GUID_Related)
                        strRowName_GUID = "GUID_Token_Left"
                        strRowName_Name = "Name_Token_Left"
                        BindingSource_TokenToken.DataSource = semfunc_TokenToken

                    End If


                Else

                    If objSemItem_Complex_Base Is Nothing Then

                        If objSemItem_FilterBase Is Nothing Then
                            semtblA_Token.Fill_Token_TypeChilds(semtbl_Token, objSemItem_Parent.GUID)


                        Else
                            semtblA_Token.Fill_Token_By_Rel(semtbl_Token, _
                                                            objFilter.DirectionLeftRight, _
                                                            objFilter.isOtherNull, _
                                                            objFilter.GUID_Token_Left, _
                                                            objFilter.Name_Token_Left, _
                                                            objFilter.GUID_Type_Left, _
                                                            objFilter.GUID_Token_Right, _
                                                            objFilter.Name_Token_Right, _
                                                            objFilter.GUID_Type_Right, _
                                                            objFilter.GUID_RelationType)
                        End If

                        BindingSource_Token.DataSource = semtbl_Token
                        strRowName_GUID = "GUID_Token"
                        strRowName_Name = "Name_Token"
                    Else
                        If boolComplexToken = False Then
                            If objSemItem_Complex_Base.Direction = objSemItem_Complex_Base.Direction_LeftRight Then
                                If boolObjectReference = True Then
                                    funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(funcT_Token_OR, objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Relation)

                                    strRowName_GUID = "GUID_ObjectReference"
                                    strRowName_Name = "Name_Ref"
                                    BindingSource_TokenToken.DataSource = funcT_Token_OR

                                Else
                                    semfuncA_TokenToken.Fill_TokenToken_LeftRight(semfunc_TokenToken, objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Relation, objSemItem_Complex_Base.GUID_Related)
                                    strRowName_GUID = "GUID_Token_Right"
                                    strRowName_Name = "Name_Token_Right"
                                    BindingSource_TokenToken.DataSource = semfunc_TokenToken
                                End If


                            Else


                                If boolObjectReference = True Then
                                    funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(funcT_Token_OR, objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Relation)

                                    strRowName_GUID = "GUID_ObjectReference"
                                    strRowName_Name = "Name_Ref"
                                    BindingSource_TokenToken.DataSource = funcT_Token_OR
                                Else
                                    semfuncA_TokenToken.Fill_TokenToken_RightLeft(semfunc_TokenToken, objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Relation, objSemItem_Complex_Base.GUID_Related)
                                    strRowName_GUID = "GUID_Token_Left"
                                    strRowName_Name = "Name_Token_Left"
                                    BindingSource_TokenToken.DataSource = semfunc_TokenToken
                                End If



                            End If
                        Else



                        End If


                    End If


                End If




                filter_Datagridview_Token()

        End Select
        set_LBL_Count()
        RaiseEvent Attributes_Changed()
        boolProgChange = boolProgChange_Loc
    End Sub

    Private Sub set_LBL_Count()
        Dim objBindingSource As BindingSource
        objBindingSource = DataGridView_Items.DataSource
        If Not objBindingSource Is Nothing Then
            ToolStripLabel_Count.Text = objBindingSource.Position + 1 & "/" & DataGridView_Items.RowCount
        Else
            ToolStripLabel_Count.Text = "0/0"
        End If

    End Sub
    Private Sub filter_Datagridview_Token()
        Dim boolCheck As Boolean = False
        Dim strFilter As String = ""

        If Not strGUID_Filter = "" Then
            If boolComplex = False Then
                strFilter = strRowName_GUID & "='" & strGUID_Filter & "'"
            Else
                strFilter = strRowName_GUID & "='" & strGUID_Filter & "'"
            End If


            boolCheck = True


        End If

        If Not strName_Filter = "" Then
            If boolComplex = False Then
                If strFilter = "" Then
                    strName_Filter = strName_Filter.Replace("'", "''")
                    strFilter = strRowName_Name & " LIKE '%" & strName_Filter & "%'"
                Else
                    strName_Filter = strName_Filter.Replace("'", "''")
                    strFilter = strFilter & " AND " & strRowName_Name & " LIKE '%" & strName_Filter & "%'"
                End If
            Else
                If BindingSource_TokenToken.Filter = "" Then
                    strName_Filter = strName_Filter.Replace("'", "''")
                    strFilter = strRowName_Name = " LIKE '%" & strName_Filter & "%'"
                Else
                    strName_Filter = strName_Filter.Replace("'", "''")
                    strFilter = strFilter & " AND " & strRowName_Name = " LIKE '%" & strName_Filter & "%'"
                End If
            End If
            boolCheck = True
        End If

        If boolComplex = False Then
            BindingSource_Token.Filter = strFilter
        Else
            BindingSource_TokenToken.Filter = strFilter
        End If
        If boolCheck = True Then
            boolProgChange_Filter = True
            ToolStripButton_Filter.Checked = True
            boolProgChange_Filter = False
        Else
            boolProgChange_Filter = True
            ToolStripButton_Filter.Checked = False
            boolProgChange_Filter = False
        End If
        Config_Datagridview_Token()
    End Sub
    Private Sub Config_Datagridview_Token()


        If boolComplex = True Then
            ToolStripButton_Filter.Checked = True
        End If

        If boolComplex = False Then
            If objSemItem_Complex_Base Is Nothing Then
                DataGridView_Items.DataSource = BindingSource_Token
            Else
                DataGridView_Items.DataSource = BindingSource_TokenToken
            End If
        Else
            DataGridView_Items.DataSource = BindingSource_TokenToken
        End If

        If DataGridView_Items.ColumnCount = 3 Then
            DataGridView_Items.Columns(0).Visible = False
            DataGridView_Items.Columns(2).Visible = False
            DataGridView_Items.Columns(1).HeaderText = objLocalConfig.Globals.ObjectReferenceType_Token.Name
            DataGridView_Items.Columns(1).Width = 300
            Dim objDGVR As DataGridViewRow
            For Each objDGVR In DataGridView_Items.SelectedRows
                objDGVR.Selected = False
            Next
        ElseIf DataGridView_Items.ColumnCount = 5 Then
            DataGridView_Items.Columns(0).Visible = False
            DataGridView_Items.Columns(2).Visible = False
            DataGridView_Items.Columns(1).HeaderText = objLocalConfig.Globals.ObjectReferenceType_Token.Name
            DataGridView_Items.Columns(1).Width = 300
            DataGridView_Items.Columns(3).Visible = False
            DataGridView_Items.Columns(4).Visible = False
            Dim objDGVR As DataGridViewRow
            For Each objDGVR In DataGridView_Items.SelectedRows
                objDGVR.Selected = False
            Next
        ElseIf DataGridView_Items.ColumnCount = 11 Then

            DataGridView_Items.Columns(0).Visible = False
            DataGridView_Items.Columns(1).Visible = False
            DataGridView_Items.Columns(2).Visible = False
            DataGridView_Items.Columns(3).Visible = False
            DataGridView_Items.Columns(4).Visible = False
            DataGridView_Items.Columns(5).Visible = False
            DataGridView_Items.Columns(6).Visible = False
            DataGridView_Items.Columns(8).Visible = False
            DataGridView_Items.Columns(9).Visible = False
            DataGridView_Items.Columns(10).Visible = False

            If objSemItem_Complex_Base Is Nothing Then
                If objSemItem_Filter_Complex.Direction = objSemItem_Filter_Complex.Direction_LeftRight Then
                    DataGridView_Items.Columns(4).HeaderText = objLocalConfig.Globals.ObjectReferenceType_Token.Name
                    DataGridView_Items.Columns(4).Width = 300
                    DataGridView_Items.Columns(4).Visible = True


                Else
                    DataGridView_Items.Columns(1).HeaderText = objLocalConfig.Globals.ObjectReferenceType_Token.Name
                    DataGridView_Items.Columns(1).Width = 300
                    DataGridView_Items.Columns(1).Visible = True

                End If

                If objSemItem_Filter_Complex.Mark = True Then
                    If DataGridView_Items.RowCount = 1 Then
                        DataGridView_Items.Rows(0).Selected = True
                    End If
                Else
                    Dim objDGVR As DataGridViewRow
                    For Each objDGVR In DataGridView_Items.SelectedRows
                        objDGVR.Selected = False
                    Next
                End If
            Else

                If objSemItem_Complex_Base.Direction = objSemItem_Complex_Base.Direction_LeftRight Then
                    DataGridView_Items.Columns(4).HeaderText = objLocalConfig.Globals.ObjectReferenceType_Token.Name
                    DataGridView_Items.Columns(4).Width = 300
                    DataGridView_Items.Columns(4).Visible = True

                Else
                    DataGridView_Items.Columns(1).HeaderText = objLocalConfig.Globals.ObjectReferenceType_Token.Name
                    DataGridView_Items.Columns(1).Width = 300
                    DataGridView_Items.Columns(1).Visible = True
                End If
            End If
        Else
            DataGridView_Items.Columns(0).Visible = False
            DataGridView_Items.Columns(1).Visible = False
            DataGridView_Items.Columns(2).Visible = False
            DataGridView_Items.Columns(3).Visible = False
            DataGridView_Items.Columns(4).Visible = False
            DataGridView_Items.Columns(5).Visible = False
            DataGridView_Items.Columns(6).Visible = False
            DataGridView_Items.Columns(7).Visible = False
            DataGridView_Items.Columns(8).Visible = False
            DataGridView_Items.Columns(9).Visible = False
            DataGridView_Items.Columns(10).Width = 250
            DataGridView_Items.Columns(12).Visible = False


        End If

    End Sub


    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click

        RaiseEvent Applied_Item()
    End Sub

    Private Sub ToolStripButton_AddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddItem.Click
        Dim objGUID_Type As Guid
        Dim objGUID_Parent As Guid
        Dim objDGVSRC_Selected As DataGridViewSelectedRowCollection
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Related_Relation As DataRowCollection
        Dim objSemItem_Edit As clsSemItem
        Dim objSemItem_Result As clsSemItem

        Dim objSemItem_ClipBoard As clsSemItem

        Dim objGUID_Related As Guid
        Dim objGUID_Relation As Guid
        Dim strCaption As String

        Dim boolRelate As Boolean
        Dim boolVal As Boolean
        Dim dateVal As Date
        Dim intVal As Integer
        Dim dblVal As Double
        Dim strVal As String


        If objSemItem_Complex_Base Is Nothing Then
            objGUID_Type = objSemItem_Parent.GUID_Type
            objGUID_Related = objSemItem_Parent.GUID_Related
            objGUID_Relation = objSemItem_Parent.GUID_Relation

        Else
            objGUID_Type = objSemItem_Complex_Base.GUID_Type
            objGUID_Related = objSemItem_Complex_Base.GUID_Related
            objGUID_Relation = objSemItem_Complex_Base.GUID_Relation

        End If

        Select Case objGUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.GUID



                objDRC_Related_Relation = semtblA_Attribute.GetData_By_GUID(objGUID_Related).Rows
                strCaption = objSemItem_Complex_Base.Name & " / " & objDRC_Related_Relation(0).Item("Name_Attribute")


                objDlgAttribute_Bool = New dlgAttribute_Bool(strCaption, objLocalConfig.Globals)
                objDlgAttribute_Bool.ShowDialog(Me)

                If objDlgAttribute_Bool.DialogResult = DialogResult.OK Then
                    boolVal = objDlgAttribute_Bool.Value

                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Related, Nothing, boolVal, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        MsgBox("Das Attribut konnte leider nicht ausgeprägt werden!", MsgBoxStyle.Exclamation)
                    Else
                        objSemItem_Added = New clsSemItem
                        objSemItem_Added.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                        objSemItem_Added.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.GUID
                        RaiseEvent Item_Added(objSemItem_Added)
                    End If


                End If

            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.GUID
                objDRC_Related_Relation = semtblA_Attribute.GetData_By_GUID(objGUID_Related).Rows
                strCaption = objSemItem_Complex_Base.Name & " / " & objDRC_Related_Relation(0).Item("Name_Attribute")


                objDlgAttribute_Datetime = New dlgAttribute_Datetime(strCaption, objLocalConfig.Globals, , True)
                objDlgAttribute_Datetime.ShowDialog(Me)
                If objDlgAttribute_Datetime.DialogResult = DialogResult.OK Then
                    dateVal = objDlgAttribute_Datetime.Value

                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Date.GetData(objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Related, Nothing, dateVal, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        MsgBox("Das Attribut konnte leider nicht ausgeprägt werden!", MsgBoxStyle.Exclamation)
                    Else
                        objSemItem_Added = New clsSemItem
                        objSemItem_Added.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                        objSemItem_Added.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.GUID
                        RaiseEvent Item_Added(objSemItem_Added)
                    End If


                End If
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.GUID
                objDRC_Related_Relation = semtblA_Attribute.GetData_By_GUID(objGUID_Related).Rows
                strCaption = objSemItem_Complex_Base.Name & " / " & objDRC_Related_Relation(0).Item("Name_Attribute")


                objDlgAttribute_Int = New dlgAttribute_Int(strCaption, objLocalConfig.Globals)
                objDlgAttribute_Int.ShowDialog(Me)
                If objDlgAttribute_Int.DialogResult = DialogResult.OK Then
                    intVal = objDlgAttribute_Int.Value

                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Int.GetData(objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Related, Nothing, intVal, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        MsgBox("Das Attribut konnte leider nicht ausgeprägt werden!", MsgBoxStyle.Exclamation)
                    Else
                        objSemItem_Added = New clsSemItem
                        objSemItem_Added.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                        objSemItem_Added.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.GUID
                        RaiseEvent Item_Added(objSemItem_Added)
                    End If


                End If
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.GUID
                objDRC_Related_Relation = semtblA_Attribute.GetData_By_GUID(objGUID_Related).Rows
                strCaption = objSemItem_Complex_Base.Name & " / " & objDRC_Related_Relation(0).Item("Name_Attribute")


                objDlgAttribute_Real = New dlgAttribute_Real(strCaption, objLocalConfig.Globals)
                objDlgAttribute_Real.ShowDialog(Me)
                If objDlgAttribute_Real.DialogResult = DialogResult.OK Then
                    dblVal = objDlgAttribute_Real.Value

                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Real.GetData(objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Related, Nothing, dblVal, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        MsgBox("Das Attribut konnte leider nicht ausgeprägt werden!", MsgBoxStyle.Exclamation)
                    Else
                        objSemItem_Added = New clsSemItem
                        objSemItem_Added.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                        objSemItem_Added.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.GUID
                        RaiseEvent Item_Added(objSemItem_Added)
                    End If


                End If
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.GUID
                objDRC_Related_Relation = semtblA_Attribute.GetData_By_GUID(objGUID_Related).Rows
                strCaption = objSemItem_Complex_Base.Name & " / " & objDRC_Related_Relation(0).Item("Name_Attribute")


                objDlgAttribute_Datetime = New dlgAttribute_Datetime(strCaption, objLocalConfig.Globals)
                objDlgAttribute_Datetime.ShowDialog(Me)
                If objDlgAttribute_Datetime.DialogResult = DialogResult.OK Then
                    dateVal = objDlgAttribute_Datetime.Value

                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Related, Nothing, dateVal, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        MsgBox("Das Attribut konnte leider nicht ausgeprägt werden!", MsgBoxStyle.Exclamation)
                    Else
                        objSemItem_Added = New clsSemItem
                        objSemItem_Added.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                        objSemItem_Added.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.GUID
                        RaiseEvent Item_Added(objSemItem_Added)
                    End If


                End If
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.GUID
                objDRC_Related_Relation = semtblA_Attribute.GetData_By_GUID(objGUID_Related).Rows
                strCaption = objSemItem_Complex_Base.Name & " / " & objDRC_Related_Relation(0).Item("Name_Attribute")


                objDlgAttribute_Datetime = New dlgAttribute_Datetime(strCaption, objLocalConfig.Globals, Nothing, False)
                objDlgAttribute_Datetime.ShowDialog(Me)
                If objDlgAttribute_Datetime.DialogResult = DialogResult.OK Then
                    dateVal = objDlgAttribute_Datetime.Value

                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Related, Nothing, dateVal, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        MsgBox("Das Attribut konnte leider nicht ausgeprägt werden!", MsgBoxStyle.Exclamation)
                    Else
                        objSemItem_Added = New clsSemItem
                        objSemItem_Added.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                        objSemItem_Added.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.GUID
                        RaiseEvent Item_Added(objSemItem_Added)
                    End If


                End If
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.GUID
                objDRC_Related_Relation = semtblA_Attribute.GetData_By_GUID(objGUID_Related).Rows
                strCaption = objSemItem_Complex_Base.Name & " / " & objDRC_Related_Relation(0).Item("Name_Attribute")


                objDlgAttribute_Varchar255 = New dlgAttribute_Varchar255(strCaption, objLocalConfig.Globals)
                objDlgAttribute_Varchar255.ShowDialog(Me)
                If objDlgAttribute_Varchar255.DialogResult = DialogResult.OK Then
                    strVal = objDlgAttribute_Varchar255.Value1

                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Varchar255.GetData(objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Related, Nothing, strVal, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        MsgBox("Das Attribut konnte leider nicht ausgeprägt werden!", MsgBoxStyle.Exclamation)
                    Else
                        objSemItem_Added = New clsSemItem
                        objSemItem_Added.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                        objSemItem_Added.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.GUID
                        RaiseEvent Item_Added(objSemItem_Added)
                    End If


                End If
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.GUID
                objDRC_Related_Relation = semtblA_Attribute.GetData_By_GUID(objGUID_Related).Rows
                strCaption = objSemItem_Complex_Base.Name & " / " & objDRC_Related_Relation(0).Item("Name_Attribute")


                objDlgAttribute_VarcharMax = New dlgAttribute_VarcharMax(strCaption, objLocalConfig.Globals)
                objDlgAttribute_VarcharMax.ShowDialog(Me)
                If objDlgAttribute_VarcharMax.DialogResult = DialogResult.OK Then
                    strVal = objDlgAttribute_VarcharMax.Value

                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Related, Nothing, strVal, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        MsgBox("Das Attribut konnte leider nicht ausgeprägt werden!", MsgBoxStyle.Exclamation)
                    Else
                        objSemItem_Added = New clsSemItem
                        objSemItem_Added.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
                        objSemItem_Added.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.GUID
                        RaiseEvent Item_Added(objSemItem_Added)
                    End If


                End If
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                strCaption = objLocalConfig.Globals.ObjectReferenceType_Attribute.Name
                objDlgAttribute_Varchar255 = New dlgAttribute_Varchar255(strCaption, objLocalConfig.Globals, Nothing, Nothing, True)
                objDlgAttribute_Varchar255.ShowDialog(Me)
                If objDlgAttribute_Varchar255.DialogResult = DialogResult.OK Then
                    strVal = objDlgAttribute_Varchar255.Value1

                    If semtblA_Attribute.GetData_By_Name(strVal).Rows.Count = 0 Then
                        objSemItem_Edit = New clsSemItem
                        objSemItem_Edit.new_Item = True
                        If objLocalConfig.Globals.is_GUID(objDlgAttribute_Varchar255.GUID.ToString) Then
                            objSemItem_Edit.GUID = objDlgAttribute_Varchar255.GUID
                        Else
                            objSemItem_Edit.GUID = Guid.NewGuid
                        End If

                        objSemItem_Edit.Name = strVal
                        objSemItem_Edit.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                        objFrmAttributeEdit = New frmAttributeEdit(objLocalConfig.Globals, objSemItem_Edit)
                        objFrmAttributeEdit.ShowDialog(Me)
                        If objFrmAttributeEdit.DialogResult = DialogResult.OK Then
                            RaiseEvent Item_Added(objSemItem_Edit)
                            get_Data()
                        End If
                    Else
                        MsgBox("Das Attribute existiert bereits!", MsgBoxStyle.Exclamation)
                    End If

                End If
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID, objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                If objGUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                    If objSemItem_Complex_Base Is Nothing Then
                        If objGUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                            objGUID_Parent = objSemItem_Parent.GUID_Parent
                        Else
                            objGUID_Parent = objSemItem_Parent.GUID
                        End If
                        objSemItem_Result = add_Token(objGUID_Parent)

                        If Not objSemItem_Result Is Nothing Then
                            filter_View_GUID_Token(objSemItem_Result.GUID)
                        End If

                    Else
                        boolRelate = True
                        objSemItem_ClipBoard = objSemClipboard.getFromClipboard(objLocalConfig.Globals.ObjectReferenceType_Token)
                        If Not objSemItem_ClipBoard Is Nothing Then
                            If objSemItem_ClipBoard.GUID_Parent = objSemItem_Complex_Base.GUID_Related Then
                                If MsgBox("Wollen Sie das Token " & objSemItem_ClipBoard.Name & " im Sem-Clipboard verknüpfen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    boolRelate = True = False
                                    If objSemItem_Complex_Base.Direction = objSemItem_Complex_Base.Direction_LeftRight Then
                                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Complex_Base.GUID, objSemItem_ClipBoard.GUID, objSemItem_Complex_Base.GUID_Relation, 1).Rows
                                    Else
                                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ClipBoard.GUID, objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Relation, 1).Rows
                                    End If
                                End If
                                
                            End If
                        End If
                        If boolRelate = True Then
                            add_Token_Relation()
                        End If

                    End If
                Else
                    objGUID_Parent = objSemItem_Parent.GUID
                    objSemItem_Result = add_Token(objGUID_Parent)

                    If Not objSemItem_Result Is Nothing Then
                        filter_View_GUID_Token(objSemItem_Result.GUID)
                    End If
                End If


            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                strCaption = objLocalConfig.Globals.ObjectReferenceType_RelationType.Name
                objDlgAttribute_Varchar255 = New dlgAttribute_Varchar255(strCaption, objLocalConfig.Globals, Nothing, Nothing, True)
                objDlgAttribute_Varchar255.ShowDialog(Me)
                If objDlgAttribute_Varchar255.DialogResult = DialogResult.OK Then
                    strVal = objDlgAttribute_Varchar255.Value1

                    If semtblA_RelationType.GetData_By_Name(strVal).Rows.Count = 0 Then
                        objSemItem_Edit = New clsSemItem
                        objSemItem_Edit.new_Item = True
                        If objLocalConfig.Globals.is_GUID(objDlgAttribute_Varchar255.GUID.ToString) Then
                            objSemItem_Edit.GUID = objDlgAttribute_Varchar255.GUID
                        Else
                            objSemItem_Edit.GUID = Guid.NewGuid
                        End If

                        objSemItem_Edit.Name = strVal
                        objSemItem_Edit.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                        objFrm_RelationTypeEdit = New frmRelationTypeEdit(objLocalConfig.Globals, objSemItem_Edit)
                        objFrm_RelationTypeEdit.ShowDialog(Me)
                        RaiseEvent Item_Added(objSemItem_Edit)
                        get_Data()

                    Else
                        MsgBox("Das Attribute existiert bereits!", MsgBoxStyle.Exclamation)
                    End If
                End If
        End Select
        get_Data()
        RaiseEvent Attributes_Changed()
    End Sub


    Public Function relate_Item(ByVal objSemItem_Item As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Result = objLocalConfig.Globals.LogState_Error

        Select Case objSemItem_Item.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID

        End Select


        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            If Not  objSemItem_Other is nothing Then
                If objLocalConfig.Globals.is_GUID(objSemItem_Other.Direction)
                    If objSemItem_Other.Direction = objSemItem_Other.Direction_LeftRight Then
                        If objSemItem_Other.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Item.GUID, _
                                                                                    objSemItem_Other.GUID, _
                                                                                    objSemItem_RelationType.GUID, 1).Rows
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If
                    Else
                        If objSemItem_Other.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Other.GUID, _
                                                                                    objSemItem_Item.GUID, _
                                                                                    objSemItem_RelationType.GUID, 1).Rows
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If
                    End If
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            objSemItem_Result = objLocalConfig.Globals.LogState_Success
                        Else
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If
                    End If
                Else 
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                End If
            Else 
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            End If
            
            
        End If

        Return objSemItem_Result
    End Function
    Private Function add_Token(ByVal objGUID_Type As Guid, Optional ByVal strValue As String = "", Optional ByVal boolMore As Boolean = False) As clsSemItem
        Dim strCaption As String
        Dim strVal As String
        Dim objDRC_Token As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItems_Selected() As clsSemItem
        Dim objSemItem_Selected As clsSemItem = Nothing
        Dim objGUID_Type_Selected As Guid
        Dim objDGVRC_Selected As DataGridViewSelectedRowCollection
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_ObjectReference As DataRowCollection
        Dim intCount As Integer = 0
        Dim intDone As Integer = 0
        Dim boolAdd As Boolean
        Dim boolMessageExists As Boolean
        Dim boolContinueWithChoose as Boolean


        strCaption = objLocalConfig.Globals.ObjectReferenceType_Token.Name
        objDlgAttribute_Varchar255 = New dlgAttribute_Varchar255(strCaption, objLocalConfig.Globals, strValue, Nothing, True, True)
        objDlgAttribute_Varchar255.show_Additional = True
        objDlgAttribute_Varchar255.show_ItemCount = True
        objDlgAttribute_Varchar255.more = boolMore
        objDlgAttribute_Varchar255.ShowDialog(Me)
        If objDlgAttribute_Varchar255.DialogResult = DialogResult.OK Then
            boolMessageExists = False
            If objDlgAttribute_Varchar255.isList = True Then
                boolContinueWithChoose = False
                For Each strVal In objDlgAttribute_Varchar255.Values
                    strVal = strVal.Replace(vbCr,"")
                    strVal = strVal.Replace(vbLf,"")
                    objDRC_Token = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objGUID_Type, strVal).Rows
                    
                    If objDRC_Token.Count > 0 Then
                        If MsgBox("Es existiert bereits ein Token mit der Bezeichnung """ & strVal & """. Soll ein zweites erzeugt werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            boolAdd = True
                                
                        Else
                            If MsgBox("Sollen weiter eingefügt werden?",MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                boolContinueWithChoose=True
                            End If
                            boolAdd = False
                        End If
                    Else
                        boolAdd = True
                    End If

                    

                    If boolAdd = True Then
                        objSemItem_Selected = New clsSemItem
                        If objLocalConfig.Globals.is_GUID(objDlgAttribute_Varchar255.GUID.ToString) Then
                            objSemItem_Selected.GUID = objDlgAttribute_Varchar255.GUID

                        Else
                            objSemItem_Selected.GUID = Guid.NewGuid
                        End If

                        objSemItem_Selected.Name = strVal
                        objSemItem_Selected.GUID_Parent = objGUID_Type
                        objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Selected.GUID, objSemItem_Selected.Name, objSemItem_Selected.GUID_Parent, True).Rows
                        If objDRC_LogState(0).Item("GUID_Type") = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Beim Speichern ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                        Else
                            relate_Item(objSemItem_Selected)
                            RaiseEvent Item_Added(objSemItem_Selected)
                        End If
                        get_Data()
                    Else
                        If Not boolContinueWithChoose
                            Exit For
                        End If
                        
                    End If
                Next
            Else
                For i As Integer = 1 To objDlgAttribute_Varchar255.ItemCount
                    strVal = objDlgAttribute_Varchar255.Value1
                    objDRC_Token = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objGUID_Type, strVal).Rows
                    If boolMessageExists = False Then
                        If objDRC_Token.Count > 0 Then
                            If MsgBox("Es existiert bereits ein Token mit der Bezeichnung """ & strVal & """. Soll ein zweites erzeugt werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                boolAdd = True
                            Else
                                boolAdd = False
                            End If
                        Else
                            boolAdd = True
                        End If
                        boolMessageExists = True
                    Else

                        boolAdd = True
                    End If


                    If boolAdd = True Then
                        objSemItem_Selected = New clsSemItem
                        If objLocalConfig.Globals.is_GUID(objDlgAttribute_Varchar255.GUID.ToString) Then
                            objSemItem_Selected.GUID = objDlgAttribute_Varchar255.GUID

                        Else
                            objSemItem_Selected.GUID = Guid.NewGuid
                        End If

                        objSemItem_Selected.Name = strVal
                        objSemItem_Selected.GUID_Parent = objGUID_Type
                        objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Selected.GUID, objSemItem_Selected.Name, objSemItem_Selected.GUID_Parent, True).Rows
                        If objDRC_LogState(0).Item("GUID_Type") = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Beim Speichern ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                        Else
                            RaiseEvent Item_Added(objSemItem_Selected)
                        End If
                        If ToolStripButton_Relate.Checked = True Then
                            relate_Item(objSemItem_Selected)
                        End If
                        get_Data()
                    Else
                        Exit For
                    End If
                Next
            End If

            If boolAdd = True Then
                If objDlgAttribute_Varchar255.more = True Then
                    add_Token(objGUID_Type, objDlgAttribute_Varchar255.Value1, objDlgAttribute_Varchar255.more)
                End If
            End If
        End If

        Return objSemItem_Selected
    End Function
    Private Sub add_Token_Relation()
        Dim objDRC_Type As DataRowCollection
        Dim objSemItem_Rel As clsSemItem
        Dim objDGVR_SelectedRows As DataGridViewSelectedRowCollection
        Dim objDGVR_SelectedRow As DataGridViewRow
        Dim objDGVRC_Selected As DataGridViewSelectedRowCollection
        Dim objDRV_Selected As DataRowView
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_ObjectReference As DataRowCollection
        Dim objGUID_Type_Selected As Guid
        Dim objSemItems_Selected() As clsSemItem
        Dim objSemItem_Selected As clsSemItem
        Dim objSemItem_ToTest As clsSemItem
        Dim objSemItems_Result() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDGVSRC_Result As DataGridViewSelectedRowCollection
        Dim objDGVR_Result As DataGridViewRow
        Dim objDVR_Result As DataRowView
        Dim strRowName_GUID_Selected As String
        Dim objModule As clsModule
        Dim boolModule As Boolean

        Dim intCount1 As Integer = 0
        Dim intDone1 As Integer = 0
        Dim intCount2 As Integer = 0
        Dim intDone2 As Integer = 0

        objSemItem_Rel = New clsSemItem
        
        objSemItem_Rel.GUID = objSemItem_Complex_Base.GUID_Related
        If objSemItem_Complex_Base.Rel_ObjectReference = False Then

            objDRC_Type = semtblA_Type.GetData_By_GUID(objSemItem_Rel.GUID).Rows
            objSemItem_Rel.Name = objDRC_Type(0).Item("Name_Type")
            objSemItem_Rel.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
        End If


        If objSemItem_Complex_Base.Rel_ObjectReference = True Then
            objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
            objFrmSemManager.Applyabale = True
            objFrmSemManager.ShowDialog(Me)
            If objFrmSemManager.DialogResult = DialogResult.OK Then
                objGUID_Type_Selected = objFrmSemManager.SelectedItems_TypeGUID
                If objFrmSemManager.Applied_SemItems = True Then
                    objSemItems_Selected = objFrmSemManager.SemItems_Selected
                    intCount1 = objSemItems_Selected.Length
                    intCount2 = intCount1
                    For Each objSemItem_Selected In objSemItems_Selected
                        Select Case objGUID_Type_Selected
                            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                objDRC_ObjectReference = procA_DBWork_Save_OR_Attribute.GetData(objSemItem_Selected.GUID).Rows
                            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                                objDRC_ObjectReference = procA_DBWork_Save_OR_RelationType.GetData(objSemItem_Selected.GUID).Rows
                            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                objDRC_ObjectReference = procA_DBWork_Save_OR_Token.GetData(objSemItem_Selected.GUID).Rows
                            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                                objDRC_ObjectReference = procA_DBWork_Save_OR_Type.GetData(objSemItem_Selected.GUID).Rows

                        End Select

                        If objDRC_ObjectReference.Count > 0 Then
                            intDone1 = intDone1 + 1
                            If objSemItem_Complex_Base.Direction = objSemItem_Complex_Base.Direction_LeftRight Then
                                If objSemItem_Complex_Base.Rel_ObjectReference = True Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenOR.GetData(objSemItem_Complex_Base.GUID, objDRC_ObjectReference(0).Item("GUID_ObjectReference"), objSemItem_Complex_Base.GUID_Relation, 1).Rows
                                Else
                                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Complex_Base.GUID, objDRC_ObjectReference(0).Item("GUID_ObjectReference"), objSemItem_Complex_Base.GUID_Relation, 1).Rows

                                End If
                            Else
                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objDRC_ObjectReference(0).Item("GUID_ObjectReference"), objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Relation, 1).Rows
                            End If

                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                If objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                                    relate_Item(objSemItem_Selected)
                                End If
                                intDone2 = intDone2 + 1
                            End If
                        End If
                    Next

                Else

                    objDGVRC_Selected = objFrmSemManager.SelectedRows_Items
                    intCount1 = objDGVRC_Selected.Count
                    intCount2 = intCount1
                    For Each objDGVR_Selected In objDGVRC_Selected
                        objDRV_Selected = objDGVR_Selected.DataBoundItem
                        Select Case objGUID_Type_Selected
                            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                                objDRC_ObjectReference = procA_DBWork_Save_OR_Attribute.GetData(objDRV_Selected.Item(0)).Rows
                            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                                objDRC_ObjectReference = procA_DBWork_Save_OR_RelationType.GetData(objDRV_Selected.Item(0)).Rows
                            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                objDRC_ObjectReference = procA_DBWork_Save_OR_Token.GetData(objDRV_Selected.Item(0)).Rows
                            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                                objDRC_ObjectReference = procA_DBWork_Save_OR_Type.GetData(objDRV_Selected.Item(0)).Rows

                        End Select

                        If objDRC_ObjectReference.Count > 0 Then
                            intDone1 = intDone1 + 1

                            objDRC_LogState = semprocA_DBWork_Save_TokenOR.GetData(objSemItem_Complex_Base.GUID, objDRC_ObjectReference(0).Item("GUID_ObjectReference"), objSemItem_Complex_Base.GUID_Relation, 1).Rows

                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                intDone2 = intDone2 + 1
                            End If
                        End If
                    Next
                End If

                If Not intCount1 = intDone1 Then
                    MsgBox("Es konnten nur " & intDone1 & " von " & intCount1 & " Items eingefügt werden!", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            If Not objLocalConfig.Globals.loaded_Modules Is Nothing And boolModuleView = True Then
                boolModule = True
                objSemItem_ToTest = New clsSemItem
                If objSemItem_Complex_Base Is Nothing Then
                    objSemItem_ToTest = objSemItem_Parent
                Else
                    objSemItem_ToTest.GUID = objSemItem_Complex_Base.GUID_Related
                    objSemItem_ToTest.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                End If

                For Each objModule In objLocalConfig.Globals.loaded_Modules
                    boolModule = False
                    If objModule.Active = True And objModule.Valid = True Then
                        If objModule.Object_OK(objSemItem_ToTest) = True Then

                            If objModule.loaded_Module.start_Module_With_Result(True) = True Then
                                boolModule = True

                                If objSemItem_Complex_Base.Direction = objSemItem_Complex_Base.Direction_LeftRight Then
                                    objSemItems_Result = objModule.loaded_Module.SemItmes_Result

                                    If Not objSemItems_Result Is Nothing Then
                                        intDone1 = 0
                                        intCount1 = objSemItems_Result.Length
                                        For Each objSemItem_Result In objSemItems_Result
                                            If objSemItem_Result.GUID_Parent = objSemItem_Complex_Base.GUID_Related Then
                                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Complex_Base.GUID, objSemItem_Result.GUID, objSemItem_Complex_Base.GUID_Relation, 1).Rows
                                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                    intDone1 = intDone1 + 1
                                                End If
                                            End If
                                        Next
                                        If intDone1 < intCount1 Then
                                            MsgBox("Es wurden " & intDone1 & " von " & intCount1 & " Items hinzugefügt!", MsgBoxStyle.Exclamation)
                                        End If
                                    Else
                                        MsgBox("Es wurden keine Items ausgewählt!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    objSemItems_Result = objModule.loaded_Module.SemItmes_Result

                                    If Not objSemItems_Result Is Nothing Then
                                        intDone1 = 0
                                        intCount1 = objSemItems_Result.Length
                                        For Each objSemItem_Result In objSemItems_Result
                                            If objSemItem_Result.GUID_Parent = objSemItem_Complex_Base.GUID_Related Then
                                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Result.GUID, objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Relation, 1).Rows
                                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                                    intDone1 = intDone1 + 1
                                                End If
                                            End If
                                        Next
                                        If intDone1 < intCount1 Then
                                            MsgBox("Es wurden " & intDone1 & " von " & intCount1 & " Items hinzugefügt!", MsgBoxStyle.Exclamation)
                                        End If
                                    Else
                                        MsgBox("Es wurden keine Items ausgewählt!", MsgBoxStyle.Exclamation)
                                    End If
                                End If

                            End If
                            Exit For
                        End If
                    End If
                Next
            End If
            If boolModule = False Then
                objFrmSemManager = New frmSemManager(objSemItem_Rel, objLocalConfig.Globals)
                objFrmSemManager.Applyabale = True
                objFrmSemManager.ModuleView = False
                objFrmSemManager.ShowDialog(Me)
                If objFrmSemManager.DialogResult = DialogResult.OK Then
                    If objFrmSemManager.Applied_SemItems = False Then
                        If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                            objDGVR_SelectedRows = objFrmSemManager.SelectedRows_Items
                            intCount1 = objDGVR_SelectedRows.Count
                            For Each objDGVR_SelectedRow In objDGVR_SelectedRows
                                objDRV_Selected = objDGVR_SelectedRow.DataBoundItem
                                If objDRV_Selected.Item("GUID_Type") = objSemItem_Complex_Base.GUID_Related Then
                                    If objSemItem_Complex_Base.Direction = objSemItem_Complex_Base.Direction_LeftRight Then
                                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Complex_Base.GUID, objDRV_Selected.Item("GUID_Token"), objSemItem_Complex_Base.GUID_Relation, 1).Rows
                                    Else
                                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objDRV_Selected.Item("GUID_Token"), objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Relation, 1).Rows
                                    End If

                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                        intDone1 = intDone1 + 1
                                    End If
                                End If
                            Next
                            If Not intDone1 = intCount1 Then
                                MsgBox(intDone1 & " von " & intCount1 & " Items verknüpft", MsgBoxStyle.Information)
                            End If

                            get_Data()

                        Else
                            MsgBox("Bitte nur Tokens auswählen!", MsgBoxStyle.Exclamation)
                        End If

                    Else
                        MsgBox("Bitte nur Tokens auswählen!", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If

        End If

    End Sub
    Private Sub ContextMenuStrip_SemList_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_SemList.Opening
        Dim objModule As clsModule
        Dim objModules_Show() As clsModule
        Dim objSemItem_ToTest As New clsSemItem
        Dim i As Integer
        Dim boolFillCombo As Boolean = False

        ToClipboardToolStripMenuItem.Enabled = False
        ToolStripComboBox_ModuleMenu.Items.Clear()
        ToolStripComboBox_ModuleEdit.Enabled = False
        If objSemItem_Complex_Base Is Nothing Then
            objSemItem_ToTest = objSemItem_Parent
        Else
            objSemItem_ToTest.GUID = objSemItem_Complex_Base.GUID_Related
            objSemItem_ToTest.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
        End If
        If Not objLocalConfig.Globals.loaded_Modules Is Nothing Then
            i = 0
            For Each objModule In objLocalConfig.Globals.loaded_Modules
                If objModule.Active = True And objModule.Valid = True Then
                    If objModule.Object_OK(objSemItem_ToTest, True) Then
                        ReDim Preserve objModules_Show(i)
                        objModules_Show(i) = objModule
                        boolFillCombo = True
                        i = i + 1

                    End If
                End If
            Next

            If boolFillCombo = True Then
                ToolStripComboBox_ModuleEdit.Items.Clear()
                For Each objModule In objModules_Show
                    ToolStripComboBox_ModuleMenu.Items.Add(objModule)
                    If objModule.loaded_Module.TokenEdit = True Then

                        ToolStripComboBox_ModuleEdit.Items.Add(objModule)
                        ToolStripComboBox_ModuleEdit.ComboBox.ValueMember = "GUID_LoadedModule"
                        ToolStripComboBox_ModuleEdit.ComboBox.DisplayMember = "Name_LoadedModule"
                    End If
                Next
                ToolStripComboBox_ModuleMenu.ComboBox.ValueMember = "GUID_LoadedModule"
                ToolStripComboBox_ModuleMenu.ComboBox.DisplayMember = "Name_LoadedModule"
            End If
        End If
        ToolStripComboBox_ModuleEdit.Enabled = False
        If DataGridView_Items.SelectedRows.Count = 1 Then
            ToolStripComboBox_ModuleEdit.Enabled = True
            ToClipboardToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton_DelItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_DelItem.Click
        Dim objDRC_LogState As DataRowCollection
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim GUID_TokenAttribute As Guid
        Dim GUID_Attribute As Guid
        Dim GUID_Token As Guid
        Dim GUID_RelationType As Guid

        For Each objDGVR In DataGridView_Items.SelectedRows
            objDRV = objDGVR.DataBoundItem
            If Not objSemItem_Complex_Base Is Nothing Then
                Select Case objSemItem_Complex_Base.GUID_Type
                    Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID, objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                        If objSemItem_Complex_Base.Direction = objSemItem_Complex_Base.Direction_LeftRight Then
                            If objSemItem_Complex_Base.Rel_ObjectReference = True Then
                                GUID_Token = objDRV.Item("GUID_ObjectReference")
                                objDRC_LogState = semprocA_DBWork_Del_Token_OR.GetData(objSemItem_Complex_Base.GUID, GUID_Token, objSemItem_Complex_Base.GUID_Relation).Rows
                            Else
                                GUID_Token = objDRV.Item("GUID_Token_Right")
                                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Complex_Base.GUID, GUID_Token, objSemItem_Complex_Base.GUID_Relation).Rows
                            End If

                        Else


                            GUID_Token = objDRV.Item("GUID_Token_Left")

                            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(GUID_Token, objSemItem_Complex_Base.GUID, objSemItem_Complex_Base.GUID_Relation).Rows



                        End If

                        Select Case objDRC_LogState(0).Item("GUID_Token")
                            Case objLocalConfig.Globals.LogState_Relation.GUID
                                MsgBox("Das Token kann nicht gelöscht werden, weil es Teil einer Beziehung ist!", MsgBoxStyle.Exclamation)
                            Case objLocalConfig.Globals.LogState_Error.GUID
                                MsgBox("Beim Löschen des Token ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                        End Select

                    Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.GUID
                        GUID_TokenAttribute = objDRV.Item("GUID_TokenAttribute")
                        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute).Rows
                        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                            MsgBox("Die Attributausprägung konnte leider nicht gelöscht werden!", MsgBoxStyle.Exclamation)

                        End If

                End Select
            Else
                Select Case objSemItem_Parent.GUID_Type
                    Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID, objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                        GUID_Token = objDRV.Item("GUID_Token")
                        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(GUID_Token).Rows
                        Select Case objDRC_LogState(0).Item("GUID_Token")
                            Case objLocalConfig.Globals.LogState_Relation.GUID
                                MsgBox("Das Token kann nicht gelöscht werden, weil es Teil einer Beziehung ist!", MsgBoxStyle.Exclamation)
                            Case objLocalConfig.Globals.LogState_Error.GUID
                                MsgBox("Beim Löschen des Token ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                        End Select
                    Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                        GUID_Attribute = objDRV.Item("GUID_Attribute")
                        objDRC_LogState = semprocA_DBWork_Del_Attribute.GetData(GUID_Attribute).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
                            MsgBox("Es existieren noch Ausprägungen bzw. Beziehungen zu der Objektreferenz dieses Attributs!", MsgBoxStyle.Exclamation)
                        ElseIf objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Beim Löschen des Attributs ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                        End If
                    Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                        GUID_RelationType = objDRV.Item("GUID_RelationType")
                        objDRC_LogState = semprocA_DBWork_Del_RelationType.GetData(GUID_RelationType).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
                            MsgBox("Es existieren Beziehungen zu anderen Items!", MsgBoxStyle.Exclamation)
                        ElseIf objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                            MsgBox("Beim Löschen des Beziehungstyps ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
                        End If
                End Select
            End If
        Next
        get_Data()

    End Sub

    Private Sub DataGridView_Items_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Items.CellMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_TokenAttribute As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_TokenToken As DataRow
        Dim objGUID_Type As Guid
        Dim GUID_TokenAttribute As Guid
        Dim intOrderID_old As Integer
        Dim intOrderID_new As Integer
        Dim boolObjectReference As Boolean

        If Not e.ColumnIndex = -1 Then
            If DataGridView_Items.Columns(e.ColumnIndex).Name = "OrderID" Then
                objDGVR_Selected = DataGridView_Items.Rows(e.RowIndex)
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                intOrderID_old = objDRV_Selected.Item("OrderID")

                objDlgAttribute_Int = New dlgAttribute_Int("OrderID", objLocalConfig.Globals, intOrderID_old)
                objDlgAttribute_Int.ShowDialog()
                If objDlgAttribute_Int.DialogResult = DialogResult.OK Then
                    intOrderID_new = objDlgAttribute_Int.Value
                    If objSemItem_Complex_Base Is Nothing Then
                        objGUID_Type = objSemItem_Parent.GUID_Type
                        boolObjectReference = False

                    Else
                        objGUID_Type = objSemItem_Complex_Base.GUID_Type
                        boolObjectReference = objSemItem_Complex_Base.Rel_ObjectReference

                    End If
                    Select Case objGUID_Type

                        Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.GUID
                            GUID_TokenAttribute = objDRV_Selected.Item("GUID_TokenAttribute")
                            objDRC_TokenAttribute = semtblA_TokenAttribute_Bit.GetData_By_GUIDTokenAttribute(GUID_TokenAttribute).Rows
                            If objDRC_TokenAttribute.Count > 0 Then
                                If objDRC_TokenAttribute(0).Item("OrderID") <> intOrderID_new Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), GUID_TokenAttribute, objDRV_Selected.Item("Val_BOOL"), intOrderID_new).Rows
                                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                                        MsgBox("Die Reihenfolge kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                                    End If

                                End If
                            Else
                                MsgBox("Die Attributausprägung kann nicht gefunden werden!", MsgBoxStyle.Exclamation)
                            End If

                        Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.GUID
                            GUID_TokenAttribute = objDRV_Selected.Item("GUID_TokenAttribute")
                            objDRC_TokenAttribute = semtblA_TokenAttribute_Date.GetData_By_GUIDTokenAttribute(GUID_TokenAttribute).Rows
                            If objDRC_TokenAttribute.Count > 0 Then
                                If objDRC_TokenAttribute(0).Item("OrderID") <> intOrderID_new Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Date.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), GUID_TokenAttribute, objDRV_Selected.Item("Val_DATE"), intOrderID_new).Rows
                                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                                        MsgBox("Die Reihenfolge kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                                    End If

                                End If
                            Else
                                MsgBox("Die Attributausprägung kann nicht gefunden werden!", MsgBoxStyle.Exclamation)
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.GUID

                            GUID_TokenAttribute = objDRV_Selected.Item("GUID_TokenAttribute")
                            objDRC_TokenAttribute = semtblA_TokenAttribute_DateTime.GetData_By_GUIDTokenAttribute(GUID_TokenAttribute).Rows
                            If objDRC_TokenAttribute.Count > 0 Then
                                If objDRC_TokenAttribute(0).Item("OrderID") <> intOrderID_new Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), GUID_TokenAttribute, objDRV_Selected.Item("Val_DATETIME"), intOrderID_new).Rows
                                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                                        MsgBox("Die Reihenfolge kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                                    End If

                                End If
                            Else
                                MsgBox("Die Attributausprägung kann nicht gefunden werden!", MsgBoxStyle.Exclamation)
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.GUID
                            GUID_TokenAttribute = objDRV_Selected.Item("GUID_TokenAttribute")
                            objDRC_TokenAttribute = semtblA_TokenAttribute_Int.GetData_By_GUIDTokenAttribute(GUID_TokenAttribute).Rows
                            If objDRC_TokenAttribute.Count > 0 Then
                                If objDRC_TokenAttribute(0).Item("OrderID") <> intOrderID_new Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Int.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), GUID_TokenAttribute, objDRV_Selected.Item("Val_INT"), intOrderID_new).Rows
                                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                                        MsgBox("Die Reihenfolge kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                                    End If

                                End If
                            Else
                                MsgBox("Die Attributausprägung kann nicht gefunden werden!", MsgBoxStyle.Exclamation)
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.GUID
                            GUID_TokenAttribute = objDRV_Selected.Item("GUID_TokenAttribute")
                            objDRC_TokenAttribute = semtblA_TokenAttribute_Real.GetData_By_GUIDTokenAttribute(GUID_TokenAttribute).Rows
                            If objDRC_TokenAttribute.Count > 0 Then
                                If objDRC_TokenAttribute(0).Item("OrderID") <> intOrderID_new Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Real.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), GUID_TokenAttribute, objDRV_Selected.Item("Val_REAL"), intOrderID_new).Rows
                                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                                        MsgBox("Die Reihenfolge kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                                    End If

                                End If
                            Else
                                MsgBox("Die Attributausprägung kann nicht gefunden werden!", MsgBoxStyle.Exclamation)
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.GUID
                            GUID_TokenAttribute = objDRV_Selected.Item("GUID_TokenAttribute")
                            objDRC_TokenAttribute = semtblA_TokenAttribute_Time.GetData_By_GUIDTokenAttribute(GUID_TokenAttribute).Rows
                            If objDRC_TokenAttribute.Count > 0 Then
                                If objDRC_TokenAttribute(0).Item("OrderID") <> intOrderID_new Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Time.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), GUID_TokenAttribute, objDRV_Selected.Item("Val_TIME"), intOrderID_new).Rows
                                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                                        MsgBox("Die Reihenfolge kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                                    End If

                                End If
                            Else
                                MsgBox("Die Attributausprägung kann nicht gefunden werden!", MsgBoxStyle.Exclamation)
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.GUID
                            GUID_TokenAttribute = objDRV_Selected.Item("GUID_TokenAttribute")
                            objDRC_TokenAttribute = semtblA_TokenAttribute_Varchar255.GetData_By_GUIDTokenAttribute(GUID_TokenAttribute).Rows
                            If objDRC_TokenAttribute.Count > 0 Then
                                If objDRC_TokenAttribute(0).Item("OrderID") <> intOrderID_new Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Varchar255.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), GUID_TokenAttribute, objDRV_Selected.Item("Val_VARCHAR255"), intOrderID_new).Rows
                                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                                        MsgBox("Die Reihenfolge kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                                    End If

                                End If
                            Else
                                MsgBox("Die Attributausprägung kann nicht gefunden werden!", MsgBoxStyle.Exclamation)
                            End If

                        Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.GUID
                            GUID_TokenAttribute = objDRV_Selected.Item("GUID_TokenAttribute")
                            objDRC_TokenAttribute = semtblA_TokenAttribute_VarcharMax.GetData_By_GUIDTokenAttribute(GUID_TokenAttribute).Rows
                            If objDRC_TokenAttribute.Count > 0 Then
                                If objDRC_TokenAttribute(0).Item("OrderID") <> intOrderID_new Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), GUID_TokenAttribute, objDRV_Selected.Item("Val_VARCHARMAX"), intOrderID_new).Rows
                                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                                        MsgBox("Die Reihenfolge kann nicht geändert werden!", MsgBoxStyle.Exclamation)
                                    End If

                                End If
                            Else
                                MsgBox("Die Attributausprägung kann nicht gefunden werden!", MsgBoxStyle.Exclamation)
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            intOrderID_old = objDRV_Selected.Item("OrderID")
                            If intOrderID_new <> intOrderID_old Then
                                If boolObjectReference = True Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenOR.GetData(objDRV_Selected.Item("GUID_Token_Left"), objDRV_Selected.Item("GUID_ObjectReference"), objDRV_Selected.Item("GUID_RelationType"), intOrderID_new).Rows
                                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                                        MsgBox("Die OrderID konnte nicht geändert werden!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objDRV_Selected.Item("GUID_Token_Left"), objDRV_Selected.Item("GUID_Token_Right"), objDRV_Selected.Item("GUID_RelationType"), intOrderID_new).Rows
                                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                                        MsgBox("Die OrderID konnte nicht geändert werden!", MsgBoxStyle.Exclamation)
                                    End If
                                End If

                            End If
                    End Select
                    get_Data()
                End If
            End If
        End If


    End Sub

    Private Sub DataGridView_Items_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView_Items.KeyDown
        Dim objSemItem_Clipboard As clsSemItem
        Dim objSemItem_Type As New clsSemItem
        Select Case e.KeyCode
            Case Keys.F5
                get_Data()
            Case Keys.ControlKey
                If e.Shift = True Then
                    If objSemItem_Parent Is Nothing Then
                        objSemItem_Type = objLocalConfig.Globals.ObjectReferenceType_Token
                        objSemItem_Clipboard = objSemClipboard.getFromClipboard(objSemItem_Type)

                    Else
                        If objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID Then
                            objSemItem_Type.GUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        Else
                            objSemItem_Type.GUID = objSemItem_Parent.GUID_Type
                        End If

                        objSemItem_Clipboard = objSemClipboard.getFromClipboard(objSemItem_Type)
                    End If

                    If Not objSemItem_Clipboard Is Nothing Then
                        ToolTip_Item.Show(objSemItem_Clipboard.Name, Me, Cursor.Position, 1000)
                    End If
                End If
                
        End Select
    End Sub

    Private Sub DataGridView_Items_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView_Items.MouseDown
        Dim objDGVRC_Selected As DataGridViewSelectedRowCollection

        Dim objDGVR As DataGridViewRow


        objDGVRC_Selected = DataGridView_Items.SelectedRows
        If Not objDGVRC_Selected Is Nothing Then
            If objDGVRC_Selected.Count = 1 Then
                objDGVR = objDGVRC_Selected(0)
                objDRV_Selected = objDGVR.DataBoundItem
            End If
        End If
    End Sub





    Private Sub DataGridView_Items_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Items.RowHeaderMouseDoubleClick
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Selected As New clsSemItem
        Dim objGUID_Type As Guid
        Dim objGUID_Parent As Guid
        Dim objGUID_ObjectReference As Guid
        Dim objDRC_LogState As DataRowCollection
        Dim boolObjectReference As Boolean
        objDGVR_Selected = DataGridView_Items.Rows(e.RowIndex)
        objDRV_Selected = objDGVR_Selected.DataBoundItem



        If objSemItem_Complex_Base Is Nothing Then
            objGUID_Type = objSemItem_Parent.GUID_Type
            boolObjectReference = False
        Else
            objGUID_Type = objSemItem_Complex_Base.GUID_Type
            boolObjectReference = objSemItem_Complex_Base.Rel_ObjectReference
        End If

        Select Case objGUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.GUID

                objDlgAttribute_Bool = New dlgAttribute_Bool(objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.Name, objLocalConfig.Globals, objDRV_Selected("VAL_BIT"))
                objDlgAttribute_Bool.ShowDialog()
                If objDlgAttribute_Bool.DialogResult = DialogResult.OK Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), objDRV_Selected.Item("GUID_TokenAttribute"), objDlgAttribute_Bool.Value, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Beim Speichern ist ein Fehler passiert!", MsgBoxStyle.Exclamation)
                    End If
                End If

            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.GUID

                objDlgAttribute_Datetime = New dlgAttribute_Datetime(objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.Name, objLocalConfig.Globals, objDRV_Selected("VAL_DATE"), True)
                objDlgAttribute_Datetime.ShowDialog()
                If objDlgAttribute_Datetime.DialogResult = DialogResult.OK Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Date.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), objDRV_Selected.Item("GUID_TokenAttribute"), objDlgAttribute_Datetime.Value, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Beim Speichern ist ein Fehler passiert!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.GUID

                objDlgAttribute_Datetime = New dlgAttribute_Datetime(objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.Name, objLocalConfig.Globals, objDRV_Selected("VAL_DATETIME"))
                objDlgAttribute_Datetime.ShowDialog()
                If objDlgAttribute_Datetime.DialogResult = DialogResult.OK Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), objDRV_Selected.Item("GUID_TokenAttribute"), objDlgAttribute_Datetime.Value, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Beim Speichern ist ein Fehler passiert!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.GUID

                objDlgAttribute_Int = New dlgAttribute_Int(objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.Name, objLocalConfig.Globals, objDRV_Selected("VAL_INT"))
                objDlgAttribute_Int.ShowDialog()
                If objDlgAttribute_Int.DialogResult = DialogResult.OK Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Int.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), objDRV_Selected.Item("GUID_TokenAttribute"), objDlgAttribute_Int.Value, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Beim Speichern ist ein Fehler passiert!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.GUID

                objDlgAttribute_Real = New dlgAttribute_Real(objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.Name, objLocalConfig.Globals, objDRV_Selected("VAL_REAL"))
                objDlgAttribute_Real.ShowDialog()
                If objDlgAttribute_Real.DialogResult = DialogResult.OK Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Real.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), objDRV_Selected.Item("GUID_TokenAttribute"), objDlgAttribute_Real.Value, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Beim Speichern ist ein Fehler passiert!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.GUID

                objDlgAttribute_Datetime = New dlgAttribute_Datetime(objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.Name, objLocalConfig.Globals, objDRV_Selected("VAL_TIME"))
                objDlgAttribute_Datetime.ShowDialog()
                If objDlgAttribute_Datetime.DialogResult = DialogResult.OK Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Time.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), objDRV_Selected.Item("GUID_TokenAttribute"), objDlgAttribute_Datetime.Value, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Beim Speichern ist ein Fehler passiert!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.GUID

                objDlgAttribute_Varchar255 = New dlgAttribute_Varchar255(objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.Name, objLocalConfig.Globals, objDRV_Selected("VAL_VARCHAR255"))
                objDlgAttribute_Varchar255.ShowDialog()
                If objDlgAttribute_Varchar255.DialogResult = DialogResult.OK Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Varchar255.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), objDRV_Selected.Item("GUID_TokenAttribute"), objDlgAttribute_Varchar255.Value1, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Beim Speichern ist ein Fehler passiert!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.GUID

                objDlgAttribute_VarcharMax = New dlgAttribute_VarcharMax(objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.Name, objLocalConfig.Globals, objDRV_Selected("VAL_VARCHARMAX"))
                objDlgAttribute_VarcharMax.ShowDialog()
                If objDlgAttribute_VarcharMax.DialogResult = DialogResult.OK Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VarcharMax.GetData(objDRV_Selected.Item("GUID_Token"), objDRV_Selected.Item("GUID_Attribute"), objDRV_Selected.Item("GUID_TokenAttribute"), objDlgAttribute_VarcharMax.Value, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Beim Speichern ist ein Fehler passiert!", MsgBoxStyle.Exclamation)
                    End If
                End If

            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objSemItem_Selected.GUID = objDRV_Selected.Item(strRowName_GUID)
                objSemItem_Selected.Name = objDRV_Selected.Item(strRowName_Name)
                objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objFrmAttributeEdit = New frmAttributeEdit(objLocalConfig.Globals, objSemItem_Selected)
                objFrmAttributeEdit.ShowDialog()




            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID, objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                If objGUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                    If objSemItem_Complex_Base Is Nothing Then
                        objGUID_Parent = objSemItem_Parent.GUID_Parent
                    Else
                        objGUID_Parent = objSemItem_Complex_Base.GUID_Related
                    End If

                Else
                    If objSemItem_Complex_Base Is Nothing Then
                        objGUID_Parent = objSemItem_Parent.GUID
                    Else
                        objGUID_Parent = objSemItem_Complex_Base.GUID_Related
                    End If

                End If
                If boolObjectReference = True Then
                    objGUID_ObjectReference = objDRV_Selected.Item("GUID_ItemType")
                    Select Case objGUID_ObjectReference
                        Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            objSemItem_Selected.GUID = objDRV_Selected.Item(strRowName_GUID)
                            objSemItem_Selected.Name = objDRV_Selected.Item(strRowName_Name)
                            objSemItem_Selected.GUID_Related = objDRV_Selected.Item("GUID_Ref")
                            objSemItem_Selected.GUID_Parent = objGUID_Parent
                            objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objSemItem_Selected.Rel_ObjectReference = True
                            objFrmTokenEdit = New frmTokenEdit(DataGridView_Items, objDGVR_Selected.Index, objSemItem_Selected, objLocalConfig.Globals)
                            objFrmTokenEdit.Applyable = boolApplyable
                            objFrmTokenEdit.enableModuleView = boolModuleView
                            objFrmTokenEdit.ShowDialog(Me)


                    End Select
                Else
                    objSemItem_Selected.GUID = objDRV_Selected.Item(strRowName_GUID)
                    objSemItem_Selected.Name = objDRV_Selected.Item(strRowName_Name)
                    objSemItem_Selected.GUID_Parent = objGUID_Parent
                    objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objFrmTokenEdit = New frmTokenEdit(DataGridView_Items, objDGVR_Selected.Index, objSemItem_Selected, objLocalConfig.Globals)
                    objFrmTokenEdit.Applyable = boolApplyable
                    objFrmTokenEdit.enableModuleView = boolModuleView
                    objFrmTokenEdit.ShowDialog(Me)
                End If


            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objSemItem_Selected.GUID = objDRV_Selected.Item(strRowName_GUID)
                objSemItem_Selected.Name = objDRV_Selected.Item(strRowName_Name)
                objSemItem_Selected.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objFrm_RelationTypeEdit = New frmRelationTypeEdit(objLocalConfig.Globals, objSemItem_Selected)
                objFrm_RelationTypeEdit.ShowDialog(Me)
        End Select

        get_Data()
    End Sub

    Public Sub mark_RowCell(ByVal intRowID As Integer, ByVal objForeColor As System.Drawing.Color, ByVal objBackColor As System.Drawing.Color, Optional ByVal intColID As Integer = -1)
        Dim i As Integer

        If intColID = -1 Then
            For i = 0 To DataGridView_Items.ColumnCount - 1
                DataGridView_Items.Rows(intRowID).Cells(i).Style.BackColor = objBackColor
                DataGridView_Items.Rows(intRowID).Cells(i).Style.ForeColor = objForeColor
            Next
        Else
            DataGridView_Items.Rows(intRowID).Cells(intColID).Style.BackColor = objBackColor
            DataGridView_Items.Rows(intRowID).Cells(i).Style.ForeColor = objForeColor
        End If
    End Sub

    Private Sub DataGridView_Items_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Items.SelectionChanged
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView

        ToolStripButton_Replace.Enabled = False
        If DataGridView_Items.SelectedRows.Count = 1 Then
            objDGVR = DataGridView_Items.SelectedRows(0)
            objDRV = objDGVR.DataBoundItem
            ToolStripTextBox_GUID.Text = objDRV.Item(strRowName_GUID).ToString
        Else
            ToolStripTextBox_GUID.Clear()
        End If
        
        ToolStripButton_Replace.Enabled = EnabledReplace()
        
        If boolProgChange = False Then
            RaiseEvent Selection_Changed()
        End If

    End Sub

    Private Sub ToolStripTextBox_Filter_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Filter.TextChanged
        If boolProgChange = False Then
            Timer_Filter.Stop()
            ToolStripButton_Filter.Checked = True
            Timer_Filter.Start()
        End If

    End Sub



    Private Sub Timer_Filter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Filter.Tick
        If ToolStripButton_Filter.Checked = True Then
            strName_Filter = ToolStripTextBox_Filter.Text
            If objLocalConfig.Globals.is_GUID(strName_Filter) Then
                strGUID_Filter = strName_Filter
                strName_Filter = ""
            End If
        Else
            strGUID_Filter = ""
            strName_Filter = ""


        End If
        Timer_Filter.Stop()
        get_Data()

    End Sub


    Private Sub ToolStripButton_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Filter.Click
        'If ToolStripButton_Filter.Checked = False Then
        '    boolProgChange = True
        '    strGUID_Filter = ""
        '    ToolStripTextBox_Filter.Clear()
        '    boolProgChange = False
        '    Timer_Filter.Start()
        'Else
        '    ToolStripButton_Filter.Checked = False
        'End If

        If ToolStripTextBox_Filter.ReadOnly = False Then
            If ToolStripButton_Filter.Checked = True Then
                strGUID_Filter = ""
                strName_Filter = ""
                If Not objSemItem_Filter_Complex Is Nothing Then
                    get_Data()
                End If

            End If
            boolProgChange = True
            filter_Datagridview_Token()
            boolProgChange = False
        End If
        
    End Sub

    Private Sub CopyNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyNameToolStripMenuItem.Click
        If Not objDRV_Selected Is Nothing Then
            Clipboard.SetDataObject(objDRV_Selected.Item(strRowName_Name))
        End If
    End Sub

    Private Sub ToolStripTextBox_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Filter.Click

    End Sub

    Private Sub UserControl_SemItemList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        boolProgChange = False
    End Sub

    Private Sub ToolStripComboBox_ModuleMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_ModuleMenu.Click

    End Sub

    Private Sub ToolStripComboBox_ModuleMenu_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_ModuleMenu.SelectedIndexChanged
        Dim objDGVSRC_Selected As DataGridViewSelectedRowCollection
        Dim objModule As clsModule

        objDGVSRC_Selected = DataGridView_Items.SelectedRows
        If objDGVSRC_Selected.Count > 0 Then
            objModule = ToolStripComboBox_ModuleMenu.SelectedItem
            If Not objSemItem_Complex_Base Is Nothing Then
                If objSemItem_Complex_Base.Direction = objSemItem_Complex_Base.Direction_LeftRight Then

                    If objModule.loaded_Module.activate_Menue_DataGrid(objDGVSRC_Selected, strRowName_GUID, strRowName_Name, "GUID_Type_Right", objLocalConfig.Globals.ObjectReferenceType_Token.GUID) = True Then

                    End If
                Else

                End If

            Else
                If objModule.loaded_Module.activate_Menue_DataGrid(objDGVSRC_Selected, strRowName_GUID, strRowName_Name, "GUID_Type", objLocalConfig.Globals.ObjectReferenceType_Token.GUID) = True Then

                End If

            End If

        End If
    End Sub


    Private Sub ToolStripButton_FilterAdvanced_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_FilterAdvanced.Click

        If objSemItem_Complex_Base Is Nothing Then
            objSemItem_FilterBase = New clsSemItem
            objSemItem_FilterBase.GUID = objSemItem_Parent.GUID
            objSemItem_FilterBase.Name = objSemItem_Parent.Name
            objSemItem_FilterBase.GUID_Parent = objSemItem_Parent.GUID_Parent
            objSemItem_FilterBase.GUID_Type = objSemItem_Parent.GUID_Type

        Else
            objSemItem_FilterBase = New clsSemItem
            objSemItem_FilterBase.GUID = objSemItem_Parent.GUID
            objSemItem_FilterBase.Name = objSemItem_Complex_Base.Name
            objSemItem_FilterBase.GUID_Parent = objSemItem_Complex_Base.GUID_Parent
            objSemItem_FilterBase.GUID_Type = objSemItem_Complex_Base.GUID_Type
        End If
        objFrm_FilterAdvanced = New frmFilter_Advanced(objLocalConfig.Globals, objSemItem_FilterBase)
        objFrm_FilterAdvanced.ShowDialog(Me)
        If objFrm_FilterAdvanced.DialogResult = DialogResult.OK Then
            objFilter = objFrm_FilterAdvanced.Filter
            get_Data()

        End If
    End Sub

    Private Sub BindingSource_Attribute_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BindingSource_Attribute.PositionChanged
        set_LBL_Count()
    End Sub

    Private Sub BindingSource_RelationType_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BindingSource_RelationType.PositionChanged
        set_LBL_Count()
    End Sub

    Private Sub BindingSource_Token_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BindingSource_Token.PositionChanged
        set_LBL_Count()
    End Sub

    Private Sub BindingSource_TokenToken_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BindingSource_TokenToken.PositionChanged
        set_LBL_Count()
    End Sub

    Private Sub BindingSource_Type_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BindingSource_Type.PositionChanged
        set_LBL_Count()
    End Sub

    Private Sub ToolStripButton_Sort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Sort.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim intOrderID As Integer

        objDlgAttribute_Int = New dlgAttribute_Int("Start-ID", objLocalConfig.Globals, 1)
        objDlgAttribute_Int.ShowDialog(Me)
        intOrderID = objDlgAttribute_Int.Value

        If DataGridView_Items.SelectedRows.Count > 0 Then
            For Each objDGVR_Selected In DataGridView_Items.SelectedRows
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                set_OrderID(objDRV_Selected, intOrderID)
                intOrderID = intOrderID + 1
            Next
        Else
            For Each objDGVR_Selected In DataGridView_Items.Rows
                objDRV_Selected = objDGVR_Selected.DataBoundItem
                set_OrderID(objDRV_Selected, intOrderID)
                intOrderID = intOrderID + 1
            Next
        End If

        get_Data()
    End Sub

    Private Function set_OrderID(ByVal objDRV_Selected As DataRowView, ByVal intOrderID As Integer) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objDRV_Selected.Item("GUID_Token_Left"), _
                                                                objDRV_Selected.Item("GUID_Token_Right"), _
                                                                objDRV_Selected.Item("GUID_RelationType"), _
                                                                intOrderID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        configure_TabPages()
    End Sub

    Private Sub configure_TabPages()
        Select Case TabControl1.SelectedTab.Name
            Case TabPage_List.Name
                get_Data()
            Case TabPage_Tree.Name
                If Not objSemItem_Parent Is Nothing Then
                    objUserControl_TreeOfToken.initialize(objSemItem_Parent)
                End If
        End Select

    End Sub

    Private Sub ToolStripComboBox_ModuleEdit_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_ModuleEdit.DropDownClosed
        Dim objModule As clsModule
        Dim objSemItem_Token As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_Token As DataRowCollection

        If DataGridView_Items.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Items.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objModule = ToolStripComboBox_ModuleEdit.SelectedItem
            objSemItem_Token = Nothing
            If Not objModule Is Nothing Then
                If objSemItem_Complex_Base Is Nothing Then
                    objSemItem_Token = New clsSemItem
                    objSemItem_Token.GUID = objDRV_Selected.Item("GUID_Token")
                    objSemItem_Token.Name = objDRV_Selected.Item("Name_Token")
                    objSemItem_Token.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                    objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                Else
                    If objSemItem_Complex_Base.Rel_ObjectReference = False Then
                        objSemItem_Token = New clsSemItem
                        If objSemItem_Complex_Base.Direction = objSemItem_Complex_Base.Direction_LeftRight Then
                            objSemItem_Token.GUID = objDRV_Selected.Item("GUID_Token_Right")
                            objSemItem_Token.Name = objDRV_Selected.Item("Name_Token_Right")
                            objSemItem_Token.GUID_Parent = objDRV_Selected.Item("GUID_Type_Right")
                            objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        Else
                            objSemItem_Token.GUID = objDRV_Selected.Item("GUID_Token_Left")
                            objSemItem_Token.Name = objDRV_Selected.Item("Name_Token_Left")
                            objSemItem_Token.GUID_Parent = objDRV_Selected.Item("GUID_Type_Left")
                            objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        End If

                    Else
                        If objDRV_Selected.Item("GUID_ItemType") = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                            objDRC_Token = semtblA_Token.GetData_Token_By_GUID(objDRV_Selected.Item("GUID_Ref")).Rows
                            If objDRC_Token.Count = 1 Then
                                objSemItem_Token = New clsSemItem
                                objSemItem_Token.GUID = objDRC_Token(0).Item("GUID_Token")
                                objSemItem_Token.Name = objDRC_Token(0).Item("Name_Token")
                                objSemItem_Token.GUID_Parent = objDRC_Token(0).Item("GUID_Type")
                                objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            End If


                        End If
                    End If


                End If
                If Not objSemItem_Token Is Nothing Then
                    objSemItem_Result = objModule.loaded_Module.edit_SemItem(objSemItem_Token, Me)
                End If


            End If
        End If
        
    End Sub

    
    Private Sub ToClipboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToClipboardToolStripMenuItem.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRC_Selected As DataRowView

        Dim objSemItem_Clipboard As New clsSemItem
        Dim objGUID_Type As Guid
        Dim objGUID_Parent As Guid
        Dim boolObjectReference As Boolean

        If DataGridView_Items.SelectedRows.Count = 1 Then
            objDGVR_Selected = DataGridView_Items.SelectedRows(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem

            If objSemItem_Complex_Base Is Nothing Then
                objGUID_Type = objSemItem_Parent.GUID_Type
                boolObjectReference = False

            Else
                objGUID_Type = objSemItem_Complex_Base.GUID_Type
                boolObjectReference = objSemItem_Complex_Base.Rel_ObjectReference
            End If

            Select Case objGUID_Type
                Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.GUID, _
                    objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.GUID

                    If objSemItem_Complex_Base Is Nothing Then

                        strRowName_GUID = "GUID_Attribute"
                        strRowName_Name = "Name_Attribute"
                    Else
                        strRowName_GUID = "GUID_TokenAttribute"
                        strRowName_Name = "Val_Named"

                    End If

                    objSemItem_Clipboard.GUID = objDRV_Selected.Item(strRowName_GUID)
                    objSemItem_Clipboard.Name = objDRV_Selected.Item(strRowName_Name)
                    objSemItem_Clipboard.GUID_Type = objGUID_Type

                    objSemClipboard.addToClipboard(objSemItem_Clipboard)
                Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                    strRowName_GUID = "GUID_RelationType"
                    strRowName_Name = "Name_RelationType"

                    objSemItem_Clipboard.GUID = objDRV_Selected.Item(strRowName_GUID)
                    objSemItem_Clipboard.Name = objDRV_Selected.Item(strRowName_Name)
                    objSemItem_Clipboard.GUID_Type = objGUID_Type

                    objSemClipboard.addToClipboard(objSemItem_Clipboard)
                Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID, objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objGUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    If objSemItem_Filter_Complex Is Nothing Then
                        boolComplex = False
                    Else
                        boolComplex = True
                    End If

                    If objGUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                        If objSemItem_Complex_Base Is Nothing Then
                            objGUID_Parent = objSemItem_Parent.GUID_Parent
                        Else
                            objGUID_Parent = objSemItem_Complex_Base.GUID_Parent
                        End If

                    Else
                        If objSemItem_Complex_Base Is Nothing Then
                            objGUID_Parent = objSemItem_Parent.GUID
                        Else
                            objGUID_Parent = objSemItem_Complex_Base.GUID
                        End If

                    End If
                    If boolComplex = True Then
                        If objSemItem_Filter_Complex.Direction = objSemItem_Filter_Complex.Direction_LeftRight Then
                            If boolObjectReference = True Then


                                strRowName_GUID = "GUID_ObjectReference"
                                strRowName_Name = "Name_Ref"

                                objSemItem_Clipboard.GUID = objDRV_Selected.Item(strRowName_GUID)
                                objSemItem_Clipboard.Name = objDRV_Selected.Item(strRowName_Name)
                                objSemItem_Clipboard.GUID_Parent = objGUID_Parent
                                objSemItem_Clipboard.GUID_Type = objGUID_Type

                                objSemClipboard.addToClipboard(objSemItem_Clipboard)
                            Else

                                strRowName_GUID = "GUID_Token_Right"
                                strRowName_Name = "Name_Token_Right"

                                objSemItem_Clipboard.GUID = objDRV_Selected.Item(strRowName_GUID)
                                objSemItem_Clipboard.Name = objDRV_Selected.Item(strRowName_Name)
                                objSemItem_Clipboard.GUID_Parent = objGUID_Parent
                                objSemItem_Clipboard.GUID_Type = objGUID_Type

                                objSemClipboard.addToClipboard(objSemItem_Clipboard)
                            End If

                        Else


                            strRowName_GUID = "GUID_Token_Left"
                            strRowName_Name = "Name_Token_Left"

                            objSemItem_Clipboard.GUID = objDRV_Selected.Item(strRowName_GUID)
                            objSemItem_Clipboard.Name = objDRV_Selected.Item(strRowName_Name)
                            objSemItem_Clipboard.GUID_Parent = objGUID_Parent
                            objSemItem_Clipboard.GUID_Type = objGUID_Type

                            objSemClipboard.addToClipboard(objSemItem_Clipboard)
                        End If


                    Else

                        If objSemItem_Complex_Base Is Nothing Then
                            strRowName_GUID = "GUID_Token"
                            strRowName_Name = "Name_Token"

                            objSemItem_Clipboard.GUID = objDRV_Selected.Item(strRowName_GUID)
                            objSemItem_Clipboard.Name = objDRV_Selected.Item(strRowName_Name)
                            objSemItem_Clipboard.GUID_Parent = objGUID_Parent
                            objSemItem_Clipboard.GUID_Type = objGUID_Type

                            objSemClipboard.addToClipboard(objSemItem_Clipboard)
                        Else
                            If boolComplexToken = False Then
                                If objSemItem_Complex_Base.Direction = objSemItem_Complex_Base.Direction_LeftRight Then
                                    If boolObjectReference = True Then


                                        strRowName_GUID = "GUID_ObjectReference"
                                        strRowName_Name = "Name_Ref"

                                        objSemItem_Clipboard.GUID = objDRV_Selected.Item(strRowName_GUID)
                                        objSemItem_Clipboard.Name = objDRV_Selected.Item(strRowName_Name)
                                        objSemItem_Clipboard.GUID_Parent = objGUID_Parent
                                        objSemItem_Clipboard.GUID_Type = objGUID_Type

                                        objSemClipboard.addToClipboard(objSemItem_Clipboard)
                                    Else

                                        strRowName_GUID = "GUID_Token_Right"
                                        strRowName_Name = "Name_Token_Right"

                                        objSemItem_Clipboard.GUID = objDRV_Selected.Item(strRowName_GUID)
                                        objSemItem_Clipboard.Name = objDRV_Selected.Item(strRowName_Name)
                                        objSemItem_Clipboard.GUID_Parent = objGUID_Parent
                                        objSemItem_Clipboard.GUID_Type = objGUID_Type

                                        objSemClipboard.addToClipboard(objSemItem_Clipboard)
                                    End If


                                Else


                                    If boolObjectReference = True Then


                                        strRowName_GUID = "GUID_ObjectReference"
                                        strRowName_Name = "Name_Ref"

                                        objSemItem_Clipboard.GUID = objDRV_Selected.Item(strRowName_GUID)
                                        objSemItem_Clipboard.Name = objDRV_Selected.Item(strRowName_Name)
                                        objSemItem_Clipboard.GUID_Parent = objGUID_Parent
                                        objSemItem_Clipboard.GUID_Type = objGUID_Type

                                        objSemClipboard.addToClipboard(objSemItem_Clipboard)
                                    Else

                                        strRowName_GUID = "GUID_Token_Left"
                                        strRowName_Name = "Name_Token_Left"

                                        objSemItem_Clipboard.GUID = objDRV_Selected.Item(strRowName_GUID)
                                        objSemItem_Clipboard.Name = objDRV_Selected.Item(strRowName_Name)
                                        objSemItem_Clipboard.GUID_Parent = objGUID_Parent
                                        objSemItem_Clipboard.GUID_Type = objGUID_Type

                                        objSemClipboard.addToClipboard(objSemItem_Clipboard)
                                    End If



                                End If
                            Else



                            End If


                        End If
                    End If
            End Select
        End If
    End Sub

    Private Function EnabledReplace() As Boolean
        

        If DataGridView_Items.SelectedRows.Count>0 Then
            Dim objGUID_Type as Guid
            Dim boolObjectReference as Boolean

            If objSemItem_Complex_Base Is Nothing Then
                objGUID_Type = objSemItem_Parent.GUID_Type
                boolObjectReference = False

            Else
                objGUID_Type = objSemItem_Complex_Base.GUID_Type
                boolObjectReference = objSemItem_Complex_Base.Rel_ObjectReference
            End If

            If boolObjectReference = False Then
                Select Case objGUID_Type
                    Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.GUID, _
                            objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.GUID

                        Return False

                    Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                        Return False

                    Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID, objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        If objSemItem_Complex_Base Is Nothing Then
                            Return True
                        Else 
                            Return False
                        End If
                        

                End Select
            Else 
                Return False
            End If
            
        Else 
            Return False
        End If
    End Function

    Private Sub ToolStripButton_Replace_Click( sender As Object,  e As EventArgs) Handles ToolStripButton_Replace.Click
        
        objFrm_Replace = new FrmReplace(DataGridView_Items,objLocalConfig)
        objFrm_Replace.ShowDialog(Me)
        get_Data()
    End Sub
End Class
