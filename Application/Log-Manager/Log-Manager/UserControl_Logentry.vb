Imports Sem_Manager
Public Class UserControl_Logentry

    Private objLocalConfig As clsLocalConfig

    Private objUserControl_Relations As UserControl_SemItemList

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_LogStates As New ds_SemDB.semtbl_TokenDataTable
    Private semtblT_User As New ds_SemDB.semtbl_TokenDataTable

    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private objDRC_Message As DataRowCollection
    Private boolDone_Message As Boolean
    Private objDRC_TimeStamp As DataRowCollection
    Private boolDone_Timestamp As Boolean
    Private objDRC_LogState As DataRowCollection
    Private boolDone_LogState As Boolean
    Private objDRC_User As DataRowCollection
    Private boolDone_User As Boolean

    Private objSemItem_Logentry As clsSemItem

    Private objThread_Data As Threading.Thread
    Private objTransaction_LogEntry As clsTransaction_Logentries
    Private objDLG_Attribute_VARCHAR255 As dlgAttribute_Varchar255
    Private objDLG_Attribute_VARCHARMAX As dlgAttribute_VarcharMax

    Private Sub get_Data_Message()
        objDRC_Message = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Logentry.GUID, _
                                                                                                        objLocalConfig.SemItem_Attribute_Message.GUID).Rows

        boolDone_Message = True
    End Sub

    Private Sub get_Data_LogState()
        objDRC_LogState = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Logentry.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_provides.GUID, _
                                                                        objLocalConfig.SemItem_type_Logstate.GUID).Rows
        boolDone_LogState = True
    End Sub

    Private Sub get_Data_User()
        objDRC_User = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Logentry.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_wasCreatedBy.GUID, _
                                                                    objLocalConfig.SemItem_type_User.GUID).Rows

        boolDone_User = True
    End Sub

    Private Sub get_Data_TimeStamp()
        objDRC_TimeStamp = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Logentry.GUID, _
                                                                                                          objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID).Rows
        boolDone_Timestamp = True
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        objUserControl_Relations = New UserControl_SemItemList()
        objUserControl_Relations.Dock = DockStyle.Fill
        Panel_Relations.Controls.Add(objUserControl_Relations)

        clear_Controls()
        set_DBConnection()

        semtblA_Token.Fill_Token_TypeChilds(semtblT_LogStates, objLocalConfig.SemItem_type_Logstate.GUID)
        semtblA_Token.Fill_Token_TypeChilds(semtblT_User, objLocalConfig.SemItem_type_User.GUID)
        
        ComboBox_Logstate.DataSource = semtblT_LogStates
        ComboBox_Logstate.ValueMember = "GUID_Token"
        ComboBox_Logstate.DisplayMember = "Name_Token"
        ComboBox_User.DataSource = semtblT_User
        ComboBox_User.ValueMember = "GUID_Token"
        ComboBox_User.DisplayMember = "Name_Token"


    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        objTransaction_LogEntry = New clsTransaction_Logentries(objLocalConfig)
    End Sub


    Public Sub clear_Controls()
        TextBox_Caption.ReadOnly = True
        TextBox_Caption.Text = ""
        TextBox_Message.ReadOnly = True
        TextBox_Message.Text = ""
        Button_FromTimestamp.Enabled = False
        DateTimePicker_DateTimeStamp.Enabled = False
        ComboBox_Logstate.Enabled = False
        ComboBox_Logstate.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID
        ComboBox_User.Enabled = False
        ComboBox_User.SelectedValue = objLocalConfig.Globals.LogState_Nothing.GUID
        objUserControl_Relations.clear_List()
        objUserControl_Relations.Enabled = False
    End Sub

    Public Sub initialize(ByVal SemItem_Logentry As clsSemItem)
        

        objSemItem_Logentry = SemItem_Logentry
        clear_Controls()
        If Not objSemItem_Logentry Is Nothing Then
            objSemItem_Logentry.GUID_Relation = objLocalConfig.SemItem_RelationType_belongsTo.GUID
            objSemItem_Logentry.Rel_ObjectReference = True
            objSemItem_Logentry.Direction = objSemItem_Logentry.Direction_LeftRight

            objUserControl_Relations.initialize_Complex(objSemItem_Logentry, objLocalConfig.Globals)
            objUserControl_Relations.Enabled = True

            TextBox_Caption.Text = objSemItem_Logentry.Name
            TextBox_Caption.ReadOnly = False

            Timer_Data.Stop()
            Try
                objThread_Data.Abort()
            Catch ex As Exception

            End Try

            boolDone_LogState = False
            boolDone_Message = False
            boolDone_Timestamp = False
            boolDone_User = False
            objThread_Data = New Threading.Thread(AddressOf get_Data)
            objThread_Data.Start()
            Timer_Data.Start()

        End If


    End Sub

    Private Sub get_Data()
        get_Data_LogState()
        get_Data_Message()
        get_Data_User()
        get_Data_TimeStamp()
    End Sub

    Private Sub Timer_Data_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Data.Tick
        Dim boolStop As Boolean
        Dim intCount As Integer

        boolStop = True

        intCount = 1

        If boolDone_LogState = True Then
            If objDRC_LogState.Count > 0 Then
                ComboBox_Logstate.SelectedValue = objDRC_LogState(0).Item("GUID_Token_Right")
            End If
            ComboBox_Logstate.Enabled = True
            intCount = intCount + 1
        Else
            boolStop = False
        End If

        If boolDone_Message = True Then
            If objDRC_Message.Count > 0 Then
                TextBox_Message.Text = objDRC_Message(0).Item("Val_VARCHARMAX")
            End If
            TextBox_Message.ReadOnly = False
            intCount = intCount + 1
        Else
            boolStop = False
        End If

        If boolDone_User = True Then
            If objDRC_User.Count > 0 Then
                ComboBox_User.SelectedValue = objDRC_User(0).Item("GUID_Token_Right")

            End If
            ComboBox_User.Enabled = True
            intCount = intCount + 1
        End If

        If boolDone_Timestamp = True Then
            If objDRC_TimeStamp.Count > 0 Then
                DateTimePicker_DateTimeStamp.Value = objDRC_TimeStamp(0).Item("VAL_DateTime")
            End If
            Button_FromTimestamp.Enabled = True
            DateTimePicker_DateTimeStamp.Enabled = True
            If objDRC_TimeStamp.Count = 0 Then
                DateTimePicker_DateTimeStamp.Value = Now
                save_DateTimeStamp()
            End If
            intCount = intCount + 1
        Else
            boolStop = False
        End If

        If boolStop = True Then
            Timer_Data.Stop()
            ToolStripProgressBar_Data.Value = 0
        Else
            ToolStripProgressBar_Data.Value = intCount
        End If
    End Sub

    Private Sub DateTimePicker_DateTimeStamp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker_DateTimeStamp.LostFocus
        If DateTimePicker_DateTimeStamp.Enabled = True Then
            save_DateTimeStamp()
        End If
        
    End Sub

    Private Sub save_DateTimeStamp()
        Dim objSemItem_Result As clsSemItem
        If DateTimePicker_DateTimeStamp.Enabled = True Then
            get_Data_TimeStamp()
            If objDRC_TimeStamp.Count > 0 Then
                If objDRC_TimeStamp(0).Item("VAL_DateTime") <> DateTimePicker_DateTimeStamp.Value Then
                    objSemItem_Result = objTransaction_LogEntry.save_001_LogEntry_Datetime(objSemItem_Logentry, _
                                                                                           DateTimePicker_DateTimeStamp.Value)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        DateTimePicker_DateTimeStamp.Enabled = False
                        MsgBox("Der Zeitstempel konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)

                    End If
                End If
            Else
                objSemItem_Result = objTransaction_LogEntry.save_001_LogEntry_Datetime(objSemItem_Logentry, _
                                                                                           DateTimePicker_DateTimeStamp.Value)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    DateTimePicker_DateTimeStamp.Enabled = False
                    MsgBox("Der Zeitstempel konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)

                End If
            End If
        End If
    End Sub

    Private Sub TextBox_Caption_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox_Caption.MouseDoubleClick
        If TextBox_Caption.ReadOnly = False Then
            objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Attribute_Message.Name, objLocalConfig.Globals, TextBox_Caption.Text)
            objDLG_Attribute_VARCHAR255.ShowDialog(Me)
            If objDLG_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
                TextBox_Caption.Text = objDLG_Attribute_VARCHAR255.Value1
            End If
        End If
        
    End Sub

    Private Sub TextBox_Caption_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Caption.TextChanged
        Timer_Caption.Stop()
        If TextBox_Caption.ReadOnly = False Then
            Timer_Caption.Start()
        End If
    End Sub

    Private Sub Timer_Message_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Message.Tick
        Dim objSemItem_Result As clsSemItem
        Dim boolAdd As Boolean

        Timer_Message.Stop()
        get_Data_Message()
        If TextBox_Message.Text = "" Then
            objSemItem_Result = objTransaction_LogEntry.del_002_Message()
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Die Message konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                TextBox_Message.ReadOnly = True
                If objDRC_Message.Count > 0 Then
                    TextBox_Message.Text = objDRC_Message(0).Item("Val_VARCHARMAX")
                Else
                    TextBox_Message.Text = ""
                End If
                TextBox_Message.ReadOnly = False
            End If
        Else
            boolAdd = True
            If objDRC_Message.Count > 0 Then
                If objDRC_Message(0).Item("VAL_VARCHARMAX") = TextBox_Message.Text Then
                    boolAdd = False
                
                End If
            End If

            If boolAdd = True Then
                objSemItem_Result = objTransaction_LogEntry.save_002_Message(TextBox_Message.Text, _
                                                                             objSemItem_Logentry)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    TextBox_Message.ReadOnly = True
                    TextBox_Message.Text = objDRC_Message(0).Item("Val_VARCHARMAX")
                    TextBox_Message.ReadOnly = False
                    MsgBox("Die Nachricht konnte leider nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub Timer_Caption_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Caption.Tick
        Dim objSemItem_Result As clsSemItem

        Timer_Caption.Stop()

        If TextBox_Caption.Text = "" Then
            MsgBox("Der Logentry benötigt eine Bezeichnung", MsgBoxStyle.Exclamation)
            TextBox_Caption.ReadOnly = True
            TextBox_Caption.Text = objSemItem_Logentry.Name
            TextBox_Caption.ReadOnly = False
        Else


            objSemItem_Logentry.Name = TextBox_Caption.Text

            objSemItem_Result = objTransaction_LogEntry.save_000_LogEntry(objSemItem_Logentry)

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                TextBox_Caption.ReadOnly = True
                TextBox_Caption.Text = objDRC_Message(0).Item("Val_VARCHARMAX")
                TextBox_Caption.ReadOnly = False
                MsgBox("Die Nachricht konnte leider nicht gespeichert werden!", MsgBoxStyle.Exclamation)
            End If


        End If
    End Sub

    Private Sub ComboBox_Logstate_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_Logstate.DropDownClosed
        If ComboBox_Logstate.Enabled = True Then
            save_LogState()
        End If
    End Sub

    Private Sub ComboBox_Logstate_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_Logstate.SelectedIndexChanged
        If ComboBox_Logstate.Enabled = True Then
            save_LogState()
        End If
    End Sub

    Private Sub save_LogState()
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_LogState As clsSemItem
        get_Data_LogState()
        objDRV_Selected = ComboBox_Logstate.SelectedItem

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        If objDRC_LogState.Count > 0 Then
            If objDRV_Selected.Item("GUID_Token") = objDRC_LogState(0).Item("Guid_Token_Right") Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            End If
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objSemItem_LogState = New clsSemItem
            objSemItem_LogState.GUID = objDRV_Selected.Item("GUID_Token")
            objSemItem_LogState.Name = objDRV_Selected.Item("Name_Token")
            objSemItem_LogState.GUID_Parent = objLocalConfig.SemItem_type_Logstate.GUID
            objSemItem_LogState.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Result = objTransaction_LogEntry.save_005_LogState(objSemItem_LogState, _
                                                                          objSemItem_Logentry)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Der Logstate konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                ComboBox_Logstate.Enabled = False
                ComboBox_Logstate.SelectedValue = objDRC_LogState(0).Item("GUID_Token_Right")
                ComboBox_Logstate.Enabled = True
            End If
        End If
    End Sub

    Private Sub ComboBox_User_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_User.DropDownClosed
        If ComboBox_User.Enabled = True Then
            save_User()
        End If
    End Sub

    Private Sub save_User()
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_User As clsSemItem
        get_Data_LogState()
        objDRV_Selected = ComboBox_User.SelectedItem

        If Not objDRV_Selected Is Nothing Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            If objDRC_LogState.Count > 0 Then
                If objDRV_Selected.Item("GUID_Token") = objDRC_LogState(0).Item("Guid_Token_Right") Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                End If
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objSemItem_User = New clsSemItem
                objSemItem_User.GUID = objDRV_Selected.Item("GUID_Token")
                objSemItem_User.Name = objDRV_Selected.Item("Name_Token")
                objSemItem_User.GUID_Parent = objLocalConfig.SemItem_type_Logstate.GUID
                objSemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = objTransaction_LogEntry.save_003_User(objSemItem_User, _
                                                                              objSemItem_Logentry)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    MsgBox("Der User konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    ComboBox_User.Enabled = False
                    ComboBox_User.SelectedValue = objDRC_LogState(0).Item("GUID_Token_Right")
                    ComboBox_User.Enabled = True
                End If
            End If
        Else
            objSemItem_Result = objTransaction_LogEntry.del_003_User(objSemItem_Logentry)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                MsgBox("Der User konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                ComboBox_User.Enabled = False
                If objDRC_User.Count > 0 Then
                    ComboBox_User.SelectedValue = objDRC_User(0).Item("GUID_Token_Right")
                End If
                ComboBox_User.Enabled = True
            End If
        End If
        
    End Sub

    Private Sub ComboBox_User_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_User.SelectedIndexChanged
        If ComboBox_User.Enabled = True Then
            save_User()
        End If
    End Sub


    Private Sub TextBox_Message_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Message.TextChanged
        Timer_Message.Stop()
        If TextBox_Message.ReadOnly = False Then
            Timer_Message.Start()
        End If
    End Sub

    Private Sub Button_FromTimestamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_FromTimestamp.Click
        If TextBox_Caption.Enabled = True Then
            TextBox_Caption.Text = DateTimePicker_DateTimeStamp.Value.ToString
        End If
    End Sub
End Class
