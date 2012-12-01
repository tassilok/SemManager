Imports Sem_Manager
Imports Log_Manager
Imports Version_Module
Public Class clsLogWork_Local
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private objLogManagement As clsLogManagement
    Private objFrmSemManager As frmSemManager
    Private objGUID_Related As Guid
    Private objDBWork As clsDBWork

    Public Property GUID_Related() As Guid
        Get
            Return objGUID_Related
        End Get
        Set(ByVal value As Guid)
            objGUID_Related = value
        End Set
    End Property

    Public Function log_Entry(ByVal objSemItem_Development As clsSemItem, Optional ByVal objSemItem_State As clsSemItem = Nothing, Optional ByVal change_Version As Boolean = True, Optional ByVal strMessage As String = Nothing, Optional ByVal SemItem_LogEntry As clsSemItem = Nothing) As clsSemItem
        Dim objDate As Date

        Dim objSemItem_Development_Parent As New clsSemItem
        Dim objsemitems() As clsSemItem
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim objDRC_ObjectReference As DataRowCollection
        'Dim objSemItem_State As clsSemItem
        'Dim objSemItem_User As clsSemItem
        Dim objSemItem_LogEntry As clsSemItem = Nothing
        'Dim objSemItem_LogState As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Simple As New clsSemItem
        Dim objListViewItem As ListViewItem
        Dim objVersionValue As New clsVersionValues
        Dim strCaption As String
        Dim boolNoVersionChange As Boolean
        Dim boolVersionChanged As Boolean
        Dim boolResult As Boolean
        Dim boolWeiter As Boolean
        Dim boolChangeVersion As Boolean

        'Dim objDlg_Attribute_VARCHAR255 As dlgAttribute_VARCHAR255
        Dim objDlg_Attribute_STRING As dlgAttribute_VarcharMax
        Dim objFrm_Version As frmVersion
        If objSemItem_LogEntry Is Nothing Then
            If strMessage = Nothing Then
                MsgBox("Geben Sie bitte eine Beschreibung der durchgeführten Aktionen ein.", MsgBoxStyle.Information)
                strCaption = "Beschreibung"
                objDlg_Attribute_STRING = New dlgAttribute_VarcharMax(strCaption, objLocalConfig.Globals)
                objDlg_Attribute_STRING.ShowDialog()
                If objDlg_Attribute_STRING.DialogResult = Windows.Forms.DialogResult.OK Then
                    strMessage = objDlg_Attribute_STRING.Value

                End If
            End If

            If Not strMessage = Nothing Then
                boolWeiter = False
                If objSemItem_State Is Nothing Then
                    MsgBox("Wählen Sie bitte den Status des Logeintrags aus.", MsgBoxStyle.Information)
                    objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_LogState, objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(frmDevelopmentManager)
                    If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                        If objFrmSemManager.Applied_SemItems = False Then
                            If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                                objDGVR = objFrmSemManager.SelectedRows_Items(0)
                                If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                                    objDRV = objDGVR.DataBoundItem
                                    If objDRV.Item("GUID_Type") = objLocalConfig.SemItem_Type_LogState.GUID Then
                                        objSemItem_State = New clsSemItem
                                        objSemItem_State.GUID = objDRV.Item("GUID_Token")
                                        objSemItem_State.Name = objDRV.Item("Name_Token")
                                        objSemItem_State.GUID_Parent = objLocalConfig.SemItem_Type_LogState.GUID

                                        boolWeiter = True
                                    Else
                                        objSemItem_State = Nothing
                                        MsgBox("Bitte nur einen Status auswählen!", MsgBoxStyle.Exclamation)
                                    End If
                                End If
                            End If

                        End If


                    End If
                Else
                    boolWeiter = True
                End If
            Else
                boolWeiter = True
            End If



            If boolWeiter = True Then
                If objSemItem_LogEntry Is Nothing Then
                    objSemItem_LogEntry = New clsSemItem
                    objDate = Now
                    objSemItem_LogEntry = objLogManagement.log_Entry(objDate, objSemItem_State.GUID, objLocalConfig.SemItem_Token_User.GUID, strMessage)

                End If
                
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development.GUID, objSemItem_LogEntry.GUID, objLocalConfig.SemItem_RelationType_Happened.GUID, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then


                    boolChangeVersion = True
                    If (objSemItem_State.GUID = objLocalConfig.SemItem_Token_LogState_Information.GUID Or _
                        objSemItem_State.GUID = objLocalConfig.SemItem_Token_LogState_Obsolete.GUID Or _
                        objSemItem_State.GUID = objLocalConfig.SemItem_Token_LogState_Request.GUID) And _
                        change_Version = False Then

                        boolChangeVersion = False
                    End If

                    If boolChangeVersion = True Then
                        boolNoVersionChange = False
                        boolVersionChanged = False

                        Do

                            objFrm_Version = New frmVersion(objLocalConfig.Globals, _
                                                            objSemItem_Development, _
                                                            objLocalConfig.SemItem_Token_User, _
                                                            False, _
                                                            objSemItem_LogEntry)
                            objFrm_Version.ShowDialog()
                            If objFrm_Version.DialogResult = Windows.Forms.DialogResult.OK Then
                                boolResult = True
                                boolVersionChanged = True
                            Else
                                If MsgBox("Wollen Sie die Version wirklich nicht ändern?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    boolNoVersionChange = True
                                End If
                            End If
                        Loop While boolNoVersionChange = False And boolVersionChanged = False
                    End If


                    objSemItem_LogEntry.Additional1 = objDate.ToString
                    objSemItem_LogEntry.Additional2 = strMessage
                Else
                    objLogManagement.del_LogEntry(objSemItem_LogEntry.GUID)
                    objSemItem_LogEntry = Nothing
                    MsgBox("Der Logeintrag konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                End If

                If Not objGUID_Related = Nothing Then
                    objDRC_ObjectReference = procA_DBWork_Save_OR_Token.GetData(objGUID_Related).Rows
                    semprocA_DBWork_Save_Token_OR.GetData(objSemItem_LogEntry.GUID, objDRC_ObjectReference(0).Item("GUID_ObjectReference"), objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0)

                End If

                '    Else
                '        objSemItem_LogEntry = Nothing
                '        MsgBox("Bitte ein Item vom Typ 'User' auswählen!", MsgBoxStyle.Exclamation)
                '    End If
                'Else
                '    objSemItem_LogEntry = Nothing
                '    MsgBox("Bitte genau ein Bat des Typs 'User' auswählen!", MsgBoxStyle.Exclamation)
                'End If
                '        Else
                'objSemItem_LogEntry = Nothing
                'MsgBox("Sie müssen ein Bat vom Typ 'User' auswählen, damit der Logeintrag gesetzt werden kann!", MsgBoxStyle.Exclamation)
                '        End If

                If Not objSemItem_Development.GUID_Related.ToString = objLocalConfig.Globals.GUID_Empty_str Then
                    MsgBox("Log für übergeordnete Software-Entwicklung!", MsgBoxStyle.Information)
                    objSemItem_Development_Parent.GUID = objSemItem_Development.GUID_Related
                    log_Entry(objSemItem_Development_Parent, objSemItem_State, True, strMessage & "\" & objSemItem_Development.Name, objSemItem_LogEntry)
                End If
            Else
                objSemItem_LogEntry = Nothing
                MsgBox("Bitte ein Item vom Typ 'Logstate' auswählen!", MsgBoxStyle.Exclamation)
            End If
        End If



        Return objSemItem_LogEntry
    End Function

    Public Sub New()

        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB
        objLogManagement = New clsLogManagement(objLocalConfig.Globals)

    End Sub
End Class

