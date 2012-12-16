Imports Sem_Manager
Public Class UserControl_Buchquelle

    Private objLocalConfig As clsLocalConfig

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private objUserControl_Begriffe As New UserControl_SemItemList
    Private objDlgAttribute_Varchar255 As dlgAttribute_Varchar255
    Private objFRMSemManager As frmSemManager

    Private objTransaction_BuchQuelle As clsTransaction_BuchQuelle

    Private objSemItem_LiteraturQuelle As clsSemItem
    Private objSemItem_BuchQuelle As clsSemItem

    Private objConnection_Thread As SqlClient.SqlConnection
    Private objThread_Data As Threading.Thread

    Private objDRC_Seite As DataRowCollection
    Private boolSeite As Boolean
    Private boolSeite_Show As Boolean
    Private objDRC_Literatur As DataRowCollection
    Private boolLiteratur As Boolean
    Private boolLiteratur_Show As Boolean
    Private objDRC_ParentQuelle As DataRowCollection
    Private boolParentQuelle As Boolean
    Private boolParentQuelle_Show As Boolean


    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        objLocalConfig = LocalConfig
        set_DBConnection()

        objUserControl_Begriffe.Dock = Windows.Forms.DockStyle.Fill
        Panel_Begriffe.Controls.Add(objUserControl_Begriffe)
    End Sub

    Public Sub initialize(ByVal SemItem_LiteraturQuelle As clsSemItem)

        Dim objDRC_BuchQuelle As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objSemItem_LiteraturQuelle = SemItem_LiteraturQuelle

        objUserControl_Begriffe.clear_List()
        objUserControl_Begriffe.Enabled = False
        TextBox_Seite.Enabled = False
        Button_Literatur.Enabled = False
        Button_ParentQuelle.Enabled = False
        Button_DelParent.Enabled = False
        TextBox_Seite.Text = ""
        TextBox_Literatur.Text = ""
        TextBox_ParentQuelle.Text = ""

        boolLiteratur = False
        boolParentQuelle = False
        boolSeite = False
        boolLiteratur_Show = False
        boolParentQuelle_Show = False
        boolSeite_Show = False

        Try
            objThread_Data.Abort()
        Catch ex As Exception

        End Try

        If Not SemItem_LiteraturQuelle Is Nothing Then
            

            objUserControl_Begriffe.Enabled = True

            objDRC_BuchQuelle = funcA_TokenToken.GetData_TokenToken_RightLeft(objSemItem_LiteraturQuelle.GUID, _
                                                                              objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                              objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID).Rows
            If objDRC_BuchQuelle.Count > 0 Then
                objSemItem_BuchQuelle = New clsSemItem
                objSemItem_BuchQuelle.GUID = objDRC_BuchQuelle(0).Item("GUID_Token_Left")
                objSemItem_BuchQuelle.Name = objDRC_BuchQuelle(0).Item("Name_Token_Left")
                objSemItem_BuchQuelle.GUID_Parent = objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID
                objSemItem_BuchQuelle.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objTransaction_BuchQuelle.save_001_BuchQuelle(objSemItem_LiteraturQuelle)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_BuchQuelle = objTransaction_BuchQuelle.SemItem_BuchQeulle
                Else
                    MsgBox("Die Buch-Quellenangabe konnte nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                End If
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_BuchQuelle.GUID_Related = objLocalConfig.SemItem_Type_Begriff.GUID
                objSemItem_BuchQuelle.Direction = objSemItem_LiteraturQuelle.Direction_LeftRight
                objSemItem_BuchQuelle.GUID_Relation = objLocalConfig.SemItem_RelationType_contains.GUID

                objUserControl_Begriffe.initialize_Complex(objSemItem_BuchQuelle, objLocalConfig.Globals)
                objThread_Data = New Threading.Thread(AddressOf get_Data)
                objThread_Data.Start()
                Timer_getData.Start()

            End If
            
        End If
        

    End Sub

    Private Sub get_Data()
        get_Data_Seite()
        get_Data_Literatur()
        get_Data_Parent()
    End Sub

    Private Sub get_Data_Seite()
        objDRC_Seite = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_BuchQuelle.GUID, _
                                                                                                      objLocalConfig.SemItem_Attribute_Seite.GUID).Rows

        boolSeite = True
    End Sub

    Private Sub get_Data_Literatur()

        objDRC_Literatur = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_BuchQuelle.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                         objLocalConfig.SemItem_Type_Literatur.GUID).Rows
        boolLiteratur = True
    End Sub

    Private Sub get_Data_Parent()
        objDRC_ParentQuelle = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_BuchQuelle.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_isSubordinated.GUID, _
                                                                            objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID).Rows
        boolParentQuelle = True
    End Sub

    Private Sub set_DBConnection()
        objConnection_Thread = New SqlClient.SqlConnection(objLocalConfig.Connection_DB.ConnectionString)
        funcA_TokenToken.Connection = objConnection_Thread
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objConnection_Thread

        objTransaction_BuchQuelle = New clsTransaction_BuchQuelle(objLocalConfig)
    End Sub

    Private Sub Timer_getData_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_getData.Tick
        Dim boolStop As Boolean

        boolStop = True

        ToolStripProgressBar_Data.Value = 0

        If boolSeite = True And boolSeite_Show = False Then
            boolStop = False
            If ToolStripProgressBar_Data.Value < ToolStripProgressBar_Data.Maximum Then
                ToolStripProgressBar_Data.Increment(ToolStripProgressBar_Data.Step)
            End If
            If objDRC_Seite.Count > 0 Then
                TextBox_Seite.Text = objDRC_Seite(0).Item("Val_VARCHAR255")
            End If
            TextBox_Seite.Enabled = True
            boolSeite_Show = True
        End If

        If boolLiteratur = True And boolLiteratur_Show = False Then
            boolStop = False
            If ToolStripProgressBar_Data.Value < ToolStripProgressBar_Data.Maximum Then
                ToolStripProgressBar_Data.Increment(ToolStripProgressBar_Data.Step)
            End If
            If objDRC_Literatur.Count > 0 Then
                TextBox_Literatur.Text = objDRC_Literatur(0).Item("Name_Token_Right")
            End If

            Button_Literatur.Enabled = True
            boolLiteratur_Show = True
        End If

        If boolParentQuelle = True And boolParentQuelle_Show = False Then
            boolStop = False
            If ToolStripProgressBar_Data.Value < ToolStripProgressBar_Data.Maximum Then
                ToolStripProgressBar_Data.Increment(ToolStripProgressBar_Data.Step)
            End If

            If objDRC_ParentQuelle.Count > 0 Then
                TextBox_ParentQuelle.Text = objDRC_ParentQuelle(0).Item("Name_Token_Right")
                Button_DelParent.Enabled = True
            End If

            Button_ParentQuelle.Enabled = True
            boolParentQuelle_Show = True
        End If

        If boolStop = False Then
            ToolStripProgressBar_Data.Visible = True
        Else
            ToolStripProgressBar_Data.Visible = False
            Timer_getData.Stop()
        End If
    End Sub

    Private Sub TextBox_Seite_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox_Seite.MouseDoubleClick
        If TextBox_Seite.Enabled = True Then
            objDlgAttribute_Varchar255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Attribute_Seite.Name, objLocalConfig.Globals, TextBox_Seite.Text)
            objDlgAttribute_Varchar255.ShowDialog(Me)
            If objDlgAttribute_Varchar255.DialogResult = Windows.Forms.DialogResult.OK Then
                TextBox_Seite.Text = objDlgAttribute_Varchar255.Value1
            End If
        End If

    End Sub

    Private Sub TextBox_Seite_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Seite.TextChanged
        Timer_Seite.Stop()
        If TextBox_Seite.Enabled = True Then
            Timer_Seite.Start()
        End If
    End Sub

    Private Sub Timer_Seite_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Seite.Tick
        Dim objSemItem_Result As clsSemItem

        Timer_Seite.Stop()
        If TextBox_Seite.Text <> "" Then
            objSemItem_Result = objTransaction_BuchQuelle.save_002_Seite(TextBox_Seite.Text, objSemItem_BuchQuelle)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Die Änderungen konnten nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                get_Data_Seite()
                TextBox_Seite.Enabled = False
                If objDRC_Seite.Count > 0 Then
                    TextBox_Seite.Text = objDRC_Seite(0).Item("VAL_VARCHAR255")
                Else
                    TextBox_Seite.Text = ""
                End If
                TextBox_Seite.Enabled = True
            End If
        Else
            objSemItem_Result = objTransaction_BuchQuelle.del_002_Seite(objSemItem_BuchQuelle)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Die Änderungen konnten nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                get_Data_Seite()
                TextBox_Seite.Enabled = False
                If objDRC_Seite.Count > 0 Then
                    TextBox_Seite.Text = objDRC_Seite(0).Item("VAL_VARCHAR255")
                Else
                    TextBox_Seite.Text = ""
                End If
                TextBox_Seite.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button_Literatur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Literatur.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objSemItem_Literatur As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objFRMSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Literatur, objLocalConfig.Globals)
        objFRMSemManager.Applyabale = True
        objFRMSemManager.ShowDialog(Me)
        If objFRMSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFRMSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFRMSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFRMSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Literatur.GUID Then
                        objSemItem_Literatur.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Literatur.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Literatur.GUID_Parent = objLocalConfig.SemItem_Type_Literatur.GUID
                        objSemItem_Literatur.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_BuchQuelle.save_003_Quelle_To_Literatur(objSemItem_Literatur, objSemItem_BuchQuelle)

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            get_Data_Literatur()
                            If objDRC_Literatur.Count > 0 Then
                                TextBox_Literatur.Text = objDRC_Literatur(0).Item("Name_Token_Right")
                            Else
                                TextBox_Literatur.Text = ""
                            End If
                        Else
                            MsgBox("Die Literatur konnte nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Bitte eine Literatur auswählen!", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Bitte eine Literatur auswählen!", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Bitte eine Literatur auswählen!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Button_ParentQuelle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ParentQuelle.Click
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        Dim objSemItem_Parent As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        objFRMSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Buch_Quellenangabe, objLocalConfig.Globals)
        objFRMSemManager.Applyabale = True
        objFRMSemManager.ShowDialog(Me)
        If objFRMSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFRMSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFRMSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFRMSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID Then
                        objSemItem_Parent.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Parent.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID
                        objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objSemItem_Result = objTransaction_BuchQuelle.save_004_Quelle_To_Parent(objSemItem_Parent, objSemItem_BuchQuelle)

                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            get_Data_Parent()
                            If objDRC_Literatur.Count > 0 Then
                                TextBox_ParentQuelle.Text = objDRC_ParentQuelle(0).Item("Name_Token_Right")
                                Button_DelParent.Enabled = True
                            Else
                                Button_DelParent.Enabled = False
                                TextBox_ParentQuelle.Text = ""
                            End If
                        Else
                            MsgBox("Die Buchquelle konnte nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Bitte eine Buchquelle auswählen!", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Bitte eine Buchquelle auswählen!", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Bitte eine Buchquelle auswählen!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Button_DelParent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DelParent.Click
        Dim objSemItem_Parent As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        get_Data_Parent()

        If objDRC_ParentQuelle.Count > 0 Then
            objSemItem_Parent.GUID = objDRC_ParentQuelle(0).Item("GUID_Token_Right")
            objSemItem_Parent.Name = objDRC_ParentQuelle(0).Item("Name_Token_Right")
            objSemItem_Parent.GUID_Parent = objLocalConfig.SemItem_Type_Buch_Quellenangabe.GUID
            objSemItem_Parent.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objTransaction_BuchQuelle.del_004_Quelle_To_Parent(objSemItem_Parent, objSemItem_BuchQuelle)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Die übergeordnete Buchquelle konnte nicht verknüpft werden!", MsgBoxStyle.Exclamation)

            End If

            get_Data_Parent()
            If objDRC_ParentQuelle.Count > 0 Then
                TextBox_ParentQuelle.Text = objDRC_ParentQuelle(0).Item("Name_Token_Right")
                Button_DelParent.Enabled = True
            Else
                TextBox_ParentQuelle.Text = ""
                Button_DelParent.Enabled = False
            End If
        Else
            Button_DelParent.Enabled = False
            TextBox_ParentQuelle.Text = ""
        End If
    End Sub
End Class
