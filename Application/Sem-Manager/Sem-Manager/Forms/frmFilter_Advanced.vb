Public Class frmFilter_Advanced

    Private objGlobals As clsGlobals

    Private objConnection As SqlClient.SqlConnection

    Private dtbl_SemItems As New ds_SemItems.DataTable_SemItemDataTable

    Private objUserControl_Attribute_Bool As UserControl_Attribute_Bool
    Private objUserControl_Attribute_DateTime As UserControl_Attribute_Datetime
    Private objUserControl_Attribute_Int As UserControl_Attribute_Int
    Private objUserControl_Attribute_Real As UserControl_Attribute_Real
    Private objUserControl_Attribute_Varchar255 As UserControl_Attribute_VARCHAR255
    Private objUserControl_Attribute_VarcharMAX As UserControl_Attribute_VarcharMax

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter

    Private WithEvents objUserControl_TokenTree As UserControl_TokenTree
    Private objFrmSemManager As frmSemManager


    Private objSemItem_ForFilter As clsSemItem
    Private objSemItem_Selected As clsSemItem
    Private objFilter As New clsFilter


    Public ReadOnly Property Filter As clsFilter
        Get
            Return objFilter
        End Get
    End Property
    Private Sub TokenTree_selected_SemItem(ByVal objSemItem As clsSemItem) Handles objUserControl_TokenTree.selected_Node
        objSemItem_Selected = objSemItem

    End Sub

    Public Sub New(ByVal Globals As clsGlobals, ByVal SemItem_ForFilter As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objGlobals = Globals
        objSemItem_ForFilter = SemItem_ForFilter

        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
        objUserControl_TokenTree = New UserControl_TokenTree(objSemItem_ForFilter, objGlobals)
        objUserControl_TokenTree.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Add(objUserControl_TokenTree)

    End Sub

    Private Sub ToolStripContainer1_TopToolStripPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripContainer1.TopToolStripPanel.Click
        
    End Sub

    Private Sub ToolStripButton_AddRelation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_AddRelation.Click
        Dim objSemItem_Type As New clsSemItem
        Dim objDRV_Selected As DataRowView
        Dim boolType As Boolean

        objFilter = New clsFilter
        objFilter.GUID_RelationType = Nothing
        objFilter.GUID_Token_Left = Nothing
        objFilter.GUID_Token_Right = Nothing
        objFilter.GUID_Type_Left = Nothing
        objFilter.GUID_Type_Right = Nothing

        If Not objSemItem_Selected Is Nothing Then
            objFilter.DirectionLeftRight = objSemItem_Selected.Direction
            objFilter.isOtherNull = ToolStripButton_NoRelation.Checked
            If objSemItem_Selected.Direction = objSemItem_Selected.Direction_LeftRight Then
                If objSemItem_ForFilter.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID Then
                    objFilter.GUID_Type_Left = objSemItem_ForFilter.GUID_Type
                Else
                    objFilter.GUID_Type_Left = objSemItem_ForFilter.GUID
                End If
            Else
                If objSemItem_ForFilter.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID Then
                    objFilter.GUID_Type_Right = objSemItem_ForFilter.GUID_Type
                Else
                    objFilter.GUID_Type_Right = objSemItem_ForFilter.GUID
                End If
            End If
            If MsgBox("Soll der Beziehungstyp im Filter benutzt werden!", MsgBoxStyle.YesNo) = vbYes Then
                objFilter.GUID_RelationType = objSemItem_Selected.GUID_Relation
            Else
                objFilter.GUID_RelationType = Nothing
            End If

            Select Case objSemItem_Selected.GUID_Type
                Case objGlobals.ObjectReferenceType_Attribute.GUID

                Case objGlobals.ObjectReferenceType_Token.GUID

                    If MsgBox("Wollen Sie ein Token im Filter benutzen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        If objSemItem_Selected.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID Then
                            objSemItem_Type.GUID = objSemItem_Selected.GUID_Type
                        Else
                            objSemItem_Type.GUID = objSemItem_Selected.GUID
                        End If

                        objFrmSemManager = New frmSemManager(objSemItem_Type, objGlobals)
                        objFrmSemManager.Applyabale = True
                        objFrmSemManager.ShowDialog(Me)
                        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                            If objFrmSemManager.SelectedItems_TypeGUID = objGlobals.ObjectReferenceType_Token.GUID Then
                                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                    If objSemItem_Selected.Direction = objSemItem_Selected.Direction_LeftRight Then
                                        boolType = False
                                        objDRV_Selected = objFrmSemManager.SelectedRows_Items(0).DataBoundItem
                                        If objSemItem_Selected.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID Then


                                            objFilter.GUID_Token_Right = objDRV_Selected.Item("GUID_Token")

                                        Else
                                            objFilter.GUID_Token_Left = objDRV_Selected.Item("GUID_Token")
                                        End If
                                    Else
                                        If objSemItem_Selected.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID Then
                                        Else

                                        End If
                                    End If
                                Else
                                    MsgBox("Es wird die Type benutzt!", MsgBoxStyle.Information)
                                    boolType = True
                                End If
                            Else
                                MsgBox("Es wird die Type benutzt!", MsgBoxStyle.Information)
                                boolType = True
                            End If
                        Else
                            MsgBox("Es wird die Type benutzt!", MsgBoxStyle.Information)
                            boolType = True
                        End If

                    Else
                        boolType = True
                    End If
                    If boolType = True Then
                        If objSemItem_Selected.Direction = objSemItem_Selected.Direction_LeftRight Then

                            objFilter.GUID_Type_Right = objSemItem_Selected.GUID
                        

                        Else

                            objFilter.GUID_Type_Left = objSemItem_Selected.GUID
                            
                        End If
                    End If

            End Select
        End If
        show_Filter()
    End Sub

    Private Sub show_Filter()

        Dim objDRC_Item As DataRowCollection

        TextBox_Token.Clear()
        TextBox_Type.Clear()
        TextBox_RelationType.Clear()

        

        If objFilter.DirectionLeftRight = objSemItem_Selected.Direction_LeftRight Then
            If objGlobals.is_GUID(objFilter.GUID_Token_Right.ToString) Then
                objDRC_Item = semtblA_Token.GetData_Token_By_GUID(objFilter.GUID_Token_Right).Rows
                If objDRC_Item.Count > 0 Then
                    TextBox_Token.Text = objDRC_Item(0).Item("Name_Token")
                    objDRC_Item = semtblA_Type.GetData_By_GUID(objDRC_Item(0).Item("GUID_type")).Rows
                    TextBox_Token.Text = TextBox_Token.Text & "\" & objDRC_Item(0).Item("Name_Token")
                End If
            End If

            If objGlobals.is_GUID(objFilter.GUID_Type_Right.ToString) Then
                objDRC_Item = semtblA_Type.GetData_By_GUID(objFilter.GUID_Type_Right).Rows
                If objDRC_Item.Count > 0 Then
                    TextBox_Type.Text = objDRC_Item(0).Item("Name_Type")
                End If
            End If

            If objGlobals.is_GUID(objFilter.GUID_RelationType.ToString) Then
                objDRC_Item = semtblA_RelationType.GetData_By_GUID(objFilter.GUID_RelationType).Rows
                If objDRC_Item.Count > 0 Then
                    TextBox_RelationType.Text = objDRC_Item(0).Item("Name_RelationType")
                End If
            End If
        Else
            If objGlobals.is_GUID(objFilter.GUID_Token_Left.ToString) Then
                objDRC_Item = semtblA_Token.GetData_Token_By_GUID(objFilter.GUID_Token_Left).Rows
                If objDRC_Item.Count > 0 Then
                    TextBox_Token.Text = objDRC_Item(0).Item("Name_Token")
                    objDRC_Item = semtblA_Type.GetData_By_GUID(objDRC_Item(0).Item("GUID_type")).Rows
                    TextBox_Token.Text = TextBox_Token.Text & "\" & objDRC_Item(0).Item("Name_Token")
                End If
            End If

            If objGlobals.is_GUID(objFilter.GUID_Type_Left.ToString) Then
                objDRC_Item = semtblA_Type.GetData_By_GUID(objFilter.GUID_Type_Left).Rows
                If objDRC_Item.Count > 0 Then
                    TextBox_Type.Text = objDRC_Item(0).Item("Name_Type")
                End If
            End If

            If objGlobals.is_GUID(objFilter.GUID_RelationType.ToString) Then
                objDRC_Item = semtblA_RelationType.GetData_By_GUID(objFilter.GUID_RelationType).Rows
                If objDRC_Item.Count > 0 Then
                    TextBox_RelationType.Text = objDRC_Item(0).Item("Name_RelationType")
                End If
            End If
        End If
    End Sub

    Private Sub set_DBConnection()

        objConnection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)

        semtblA_Token.Connection = objConnection
        semtblA_Type.Connection = objConnection
        semtblA_RelationType.Connection = objConnection
    End Sub

    Private Sub Button_RemoveToken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_RemoveToken.Click
        If objFilter.DirectionLeftRight = objSemItem_Selected.Direction_LeftRight Then
            objFilter.GUID_Token_Right = Nothing

        Else
            objFilter.GUID_Token_Left = Nothing
        End If

        TextBox_Token.Clear()
    End Sub

    Private Sub Button_RemoveType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_RemoveType.Click
        If objFilter.DirectionLeftRight = objSemItem_Selected.Direction_LeftRight Then
            objFilter.GUID_Type_Right = Nothing

        Else
            objFilter.GUID_Type_Left = Nothing
        End If

        TextBox_Type.Clear()
    End Sub

    Private Sub Button_RemoveRelationType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_RemoveRelationType.Click
        objFilter.GUID_RelationType = Nothing
        TextBox_RelationType.Clear()
    End Sub

    Private Sub ToolStripButton_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Cancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ToolStripButton_Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Apply.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class