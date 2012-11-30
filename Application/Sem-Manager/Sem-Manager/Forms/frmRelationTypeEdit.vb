Public Class frmRelationTypeEdit
    Private objSemItem_RelationType As clsSemItem
    Private objLocalConfig As clsLocalConfig_RelationTypeEdit

    Private typefuncA_Types_Rel As New ds_TypeTableAdapters.typefunc_Types_RelTableAdapter
    Private typefunc_Types_Rel As New ds_Type.typefunc_Types_RelDataTable
    Private tokenfuncA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private tokenfunc_TokenToken As New ds_Token.func_TokenTokenDataTable
    Private semproc_DBWork_Save_RelationType As New ds_DBWorkTableAdapters.semproc_DBWork_Save_RelationTypeTableAdapter

    Public Sub New(ByVal Globals As clsGlobals, ByVal SemItem_RelationType As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_RelationTypeEdit(Globals)
        objSemItem_RelationType = SemItem_RelationType
        ToolStripTextBox_Name.Text = objSemItem_RelationType.Name
        ToolStripTextBox_GUID.Text = objSemItem_RelationType.GUID.ToString
        set_DBConnection()
        If objSemItem_RelationType.new_Item = True Then
            save_RelationType()
        End If

        get_Data()
    End Sub

    Private Sub set_DBConnection()
        typefuncA_Types_Rel.Connection = objLocalConfig.Connection_DB
        tokenfuncA_TokenToken.Connection = objLocalConfig.Connection_DB
        semproc_DBWork_Save_RelationType.Connection = objLocalConfig.Connection_DB
    End Sub

    Private Sub get_Data()
        get_Types()
        get_Token()
    End Sub
    Private Sub get_Types()
        typefunc_Types_Rel.Clear()
        typefuncA_Types_Rel.Fill_By_GUIDRelationType(typefunc_Types_Rel, objSemItem_RelationType.GUID)

        BindingSource_Type.DataSource = typefunc_Types_Rel
        DataGridView_Type.DataSource = BindingSource_Type
        DataGridView_Type.Columns(0).Visible = False
        DataGridView_Type.Columns(1).Visible = True
        DataGridView_Type.Columns(1).Width = 200
        DataGridView_Type.Columns(2).Visible = False
        DataGridView_Type.Columns(3).Visible = False
        DataGridView_Type.Columns(4).Visible = False
        DataGridView_Type.Columns(5).Visible = False
        DataGridView_Type.Columns(6).Visible = True
        DataGridView_Type.Columns(6).Width = 200
        DataGridView_Type.Columns(7).Visible = False
        DataGridView_Type.Columns(8).Visible = False
        DataGridView_Type.Columns(9).Visible = False
        DataGridView_Type.Columns(10).Visible = False
    End Sub

    Private Sub get_Token()
        tokenfunc_TokenToken.Clear()
        tokenfuncA_TokenToken.Fill_By_GUIDRelationType(tokenfunc_TokenToken, objSemItem_RelationType.GUID)

        BindingSource_Token.DataSource = tokenfunc_TokenToken
        DataGridView_Token.DataSource = BindingSource_Token

        DataGridView_Token.Columns(0).Visible = False
        DataGridView_Token.Columns(1).Visible = True
        DataGridView_Token.Columns(1).Width = 200
        DataGridView_Token.Columns(1).DisplayIndex = 2
        DataGridView_Token.Columns(2).Visible = False
        DataGridView_Token.Columns(3).Visible = False
        DataGridView_Token.Columns(4).Visible = True
        DataGridView_Token.Columns(4).Width = 200
        DataGridView_Token.Columns(4).DisplayIndex = 1
        DataGridView_Token.Columns(5).Visible = False
        DataGridView_Token.Columns(6).Visible = False
        DataGridView_Token.Columns(7).Visible = False
        DataGridView_Token.Columns(8).Visible = True
        DataGridView_Token.Columns(8).Width = 200
        DataGridView_Token.Columns(8).DisplayIndex = 0
        DataGridView_Token.Columns(9).Visible = True
        DataGridView_Token.Columns(9).DisplayIndex = 3
        DataGridView_Token.Columns(9).Width = 200

    End Sub

    Private Sub save_RelationType()
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semproc_DBWork_Save_RelationType.GetData(objSemItem_RelationType.GUID, objSemItem_RelationType.Name).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Exists.GUID Then
            MsgBox("Beim Speichern ist ein Fehler aufgetreten!", MsgBoxStyle.Exclamation)
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripTextBox_Name_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Name.Click

    End Sub

    Private Sub ToolStripTextBox_Name_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Name.TextChanged
        Timer_RelationType.Stop()
        Timer_RelationType.Start()
    End Sub

    Private Sub Timer_RelationType_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_RelationType.Tick
        Dim strName_RelationType As String

        strName_RelationType = ToolStripTextBox_Name.Text
        If strName_RelationType = "" Then
            MsgBox("Bitte keine leeren Namen!", MsgBoxStyle.Exclamation)
            ToolStripTextBox_Name.Text = objSemItem_RelationType.Name
        Else
            objSemItem_RelationType.Name = ToolStripTextBox_Name.Text
            save_RelationType()
        End If
        Timer_RelationType.Stop()
    End Sub
End Class