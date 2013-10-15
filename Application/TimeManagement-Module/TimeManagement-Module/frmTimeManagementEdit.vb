Imports Sem_Manager
Imports Log_Manager
Public Class frmTimeManagementEdit
    Private objLocalConfig As clsLocalConfig

    Private objDRV_TimeManagement As DataRowView

    Private objSemItem_TimeManagement As clsSemItem

    Private objTransaction_TimeManagement As clsTransaction_TimeManagement

    Private objSemItem_Result As clsSemItem

    Public ReadOnly Property SemItem_Result As clsSemItem
        Get
            Return objSemItem_Result
        End Get
    End Property

    Public Sub New(DRV_TimeManagement As DataRowView, LocalConfig As clsLocalConfig)
        
        ' This call is required by the designer.
        InitializeComponent()
        
        ' Add any initialization after the InitializeComponent() call.
        objLocalConfig = LocalConfig
        objDRV_TimeManagement = DRV_TimeManagement
        set_DBConnection()
        initialize()
    End Sub

    Private sub set_DBConnection
        objTransaction_TimeManagement = new clsTransaction_TimeManagement(objLocalConfig)
    End Sub

    Private sub initialize()
        
        If Not objDRV_TimeManagement Is Nothing Then
            objSemItem_TimeManagement = new clsSemItem With {.GUID = objDRV_TimeManagement.Item("GUID_Log_Management"), _
                                                             .Name = objDRV_TimeManagement.Item("Name_Log_Management"), _
                                                             .GUID_Parent = objLocalConfig.SemItem_Type_Timemanagement.GUID, _
                                                             .GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID}


            TextBox_Name.Text = objDRV_TimeManagement.Item("Name_Log_Management")
            DateTimePicker_Start.Value = objDRV_TimeManagement.Item("Start")
            DateTimePicker_Ende.Value = objDRV_TimeManagement.Item("Ende")

            Select Case objDRV_TimeManagement.Item("GUID_LogState_TimeManagement")
                Case objLocalConfig.SemItem_Token_Logstate_Work.GUID
                    RadioButton_Work.Checked = True
                Case objLocalConfig.SemItem_Token_Logstate_private.GUID
                    RadioButton_Private.Checked = True
                Case objLocalConfig.SemItem_Token_Logstate_Urlaub.GUID
                    RadioButton_Urlaub.Checked = True
                Case objLocalConfig.SemItem_Token_Logstate_Krank.GUID
                    RadioButton_Krankheit.Checked = True
            End Select

        Else 
            objSemItem_TimeManagement = new clsSemItem With {.GUID = guid.NewGuid(), _
                                                             .GUID_Parent = objLocalConfig.SemItem_Type_Timemanagement.GUID, _
                                                             .GUID_Type= objLocalConfig.Globals.ObjectReferenceType_Token.GUID}

            DateTimePicker_Start.Value = Now
            DateTimePicker_Ende.Value = Now
        End If
    End Sub

    Private Sub ToolStripButton_Save_Click( sender As Object,  e As EventArgs) Handles ToolStripButton_Save.Click
        Dim boolSave As Boolean = True
        If DateTimePicker_Start.Value > DateTimePicker_Ende.Value Then
            MsgBox("Start muss vor Ende liegen!",MsgBoxStyle.Information)
            boolSave = False
        End If

        If boolSave Then
            If TextBox_Name.Text = "" then
                MsgBox("Geben Sie bitte eine Bezeichnung für den Eintrag an!",MsgBoxStyle.Information)
                boolSave = False
            End If


        End If

        If boolSave = True Then
            Dim objSemItem_LogState = objLocalConfig.SemItem_Token_Logstate_Work

            If RadioButton_Private.Checked Then
                objSemItem_LogState = objLocalConfig.SemItem_Token_Logstate_private
            elseIf RadioButton_Urlaub.Checked Then
                objSemItem_LogState = objLocalConfig.SemItem_Token_Logstate_Urlaub
            elseIf RadioButton_Krankheit.Checked Then
                objSemItem_LogState = objLocalConfig.SemItem_Token_Logstate_Krank
            End If

            Me.DialogResult = DialogResult.OK
            objSemItem_TimeManagement.Name = TextBox_Name.Text
            dim dateStart = DateTimePicker_Start.Value
            Dim dateEnd = DateTimePicker_Ende.Value
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            If objDRV_TimeManagement Is Nothing Then
                objSemItem_Result = objTransaction_TimeManagement.save_001_TimeManagement(objSemItem_TimeManagement)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_TimeManagement.save_002_LogEntry_Start(dateStart, objSemItem_TimeManagement)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_TimeManagement.save_003_LogEntry_End(dateEnd, objSemItem_TimeManagement)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_TimeManagement.save_004_TimeManagement_To_LogEntry_Start()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_TimeManagement.save_005_TimeManagement_To_LogEntry_End()
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_TimeManagement.save_006_TimeManagement_To_LogState(objSemItem_LogState)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID then
                                        objSemItem_Result = objTransaction_TimeManagement.del_005_TimeManagement_To_LogEntry_End()
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID then
                                            objSemItem_Result = objTransaction_TimeManagement.del_004_TimeManagement_To_LogEntry_Start()
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_TimeManagement.del_003_LogEntry_End()
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_TimeManagement.del_002_LogEntry_Start()
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objTransaction_TimeManagement.del_001_TimeManagement()
                                                    End If
                                                End If
                                            End If
                                    
                                        End If
                                        
                                
                                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                    End If

                                Else 
                                    objSemItem_Result = objTransaction_TimeManagement.del_004_TimeManagement_To_LogEntry_Start()
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_TimeManagement.del_003_LogEntry_End()
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_TimeManagement.del_002_LogEntry_Start()
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objTransaction_TimeManagement.del_001_TimeManagement()
                                            End If
                                        End If
                                    End If
                                    
                                
                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                End If
                            Else 
                                objSemItem_Result = objTransaction_TimeManagement.del_003_LogEntry_End()
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = objTransaction_TimeManagement.del_002_LogEntry_Start()
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objTransaction_TimeManagement.del_001_TimeManagement()
                                    End If
                                End If
                                
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                            End If
                        Else 
                            objSemItem_Result = objTransaction_TimeManagement.del_002_LogEntry_Start()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objTransaction_TimeManagement.del_001_TimeManagement()
                            End If
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If
                    Else 
                        objTransaction_TimeManagement.del_001_TimeManagement()
                    End If
                End If
            Else 

                objSemItem_Result = objTransaction_TimeManagement.save_001_TimeManagement(objSemItem_TimeManagement)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_TimeManagement.save_002_LogEntry_Start(dateStart, objSemItem_TimeManagement)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_TimeManagement.save_003_LogEntry_End(dateEnd, objSemItem_TimeManagement)
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Result = objTransaction_TimeManagement.save_004_TimeManagement_To_LogEntry_Start()
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_TimeManagement.save_005_TimeManagement_To_LogEntry_End()
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.guid Then
                                    objSemItem_Result = objTransaction_TimeManagement.save_006_TimeManagement_To_LogState(objSemItem_LogState)
                                End If
                            
                            end if
                        end if
                        
                
                    End If
                end if
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                Me.DialogResult = DialogResult.OK
            Else 
                MsgBox("Die Zeiterfassung konnte nicht gespeichert werden!",MsgBoxStyle.Exclamation)
                Me.DialogResult = DialogResult.Abort
                
            End If
            Me.close
        End If
    End Sub

    Private Sub ToolStripButton_Cancel_Click( sender As Object,  e As EventArgs) Handles ToolStripButton_Cancel.Click
        Me.DialogResult=DialogResult.Cancel
        Me.Close()
    End Sub
End Class