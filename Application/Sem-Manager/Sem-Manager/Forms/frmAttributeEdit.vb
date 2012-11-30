Public Class frmAttributeEdit
    Private objLocalConfig As clsLocalConfig_AttributeEdit

    Private WithEvents objUserControl_AttributeRelations As UserControl_AttributeRelations
    Private WithEvents objUserControl_AttributeTypeSel As UserControl_AttributeTypeSel

    Private semprocA_DBWork_Save_Attribute As New ds_DBWorkTableAdapters.semproc_DBWork_Save_AttributeTableAdapter

    Private objSemItem_Attribute As clsSemItem

    Private boolToSave As Boolean

    Private Sub AttributeType_Changed() Handles objUserControl_AttributeTypeSel.changed_Type
        Timer_NameAttribute.Stop()
        boolToSave = True

        save_Attribute()

    End Sub

    Public Sub New(ByVal Globals As clsGlobals, ByVal SemItem_Attribute As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_AttributeEdit(Globals)

        objSemItem_Attribute = SemItem_Attribute
        
        set_DBConnection()
        get_Data()
    End Sub

    Private Sub get_Data()
        Dim objDRC_LogState As DataRowCollection

        objUserControl_AttributeRelations = New UserControl_AttributeRelations(objLocalConfig.Globals, objSemItem_Attribute.GUID)
        objUserControl_AttributeRelations.Dock = DockStyle.Fill
        objUserControl_AttributeTypeSel = New UserControl_AttributeTypeSel(objLocalConfig.Globals, objSemItem_Attribute)
        objUserControl_AttributeTypeSel.Dock = DockStyle.Fill

        SplitContainer1.Panel1.Controls.Add(objUserControl_AttributeTypeSel)
        SplitContainer1.Panel2.Controls.Add(objUserControl_AttributeRelations)

        If objSemItem_Attribute.new_Item = True Then

            objDRC_LogState = semprocA_DBWork_Save_Attribute.GetData(objSemItem_Attribute.GUID, objSemItem_Attribute.Name, objUserControl_AttributeTypeSel.Value.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Das Attribute kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                Me.Close()
            End If

        End If
        ToolStripTextBox_GUID.Text = objSemItem_Attribute.GUID.ToString
        ToolStripTextBox_Name.Text = objSemItem_Attribute.Name
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBWork_Save_Attribute.Connection = objLocalConfig.Connection_DB

    End Sub



    Private Sub ToolStripTextBox_Name_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Name.TextChanged
        Timer_NameAttribute.Stop()

        boolToSave = True
        Timer_NameAttribute.Start()
    End Sub

    Private Sub Timer_NameAttribute_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_NameAttribute.Tick
        save_Attribute()
    End Sub
    Private Sub save_Attribute()
        Dim GUID_AttributeType As Guid
        Dim objDRC_LogState As DataRowCollection
        Dim strName_Attribute As String

        strName_Attribute = ToolStripTextBox_Name.Text
        GUID_AttributeType = objUserControl_AttributeTypeSel.Value.GUID

        If Not strName_Attribute = "" Then
            If Not GUID_AttributeType = Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_Attribute.GetData(objSemItem_Attribute.GUID, strName_Attribute, GUID_AttributeType).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Das Attribute kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                Else
                    boolToSave = False
                End If
            End If
        End If
        Timer_NameAttribute.Stop()
    End Sub
    Private Sub ToolStripButton_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_OK.Click
        Timer_NameAttribute.Stop()
        If boolToSave = True Then
            save_Attribute()
        End If
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub frmAttributeEdit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer_NameAttribute.Stop()
        If boolToSave = True Then
            If MsgBox("Sollen die Änderungen gespeichert werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                save_Attribute()
            End If
        End If
    End Sub

   
    Private Sub ToolStripButton_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Cancel.Click
        Timer_NameAttribute.Stop()
        If boolToSave = True Then
            If MsgBox("Sollen die Änderungen gespeichert werden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                save_Attribute()
            End If
        End If
    End Sub
End Class