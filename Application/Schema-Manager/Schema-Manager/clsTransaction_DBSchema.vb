Imports Sem_Manager
Imports Version_Module
Imports Log_Manager
Imports Filesystem_Management
Public Class clsTransaction_DBSchema
    Private objSemItem_DBSchema As clsSemItem
    Private objSemItem_SchemaType As clsSemItem
    Private objSemItem_LogEntry As clsSemItem
    Private objSemItem_File As clsSemItem
    Private objSemItems_SchemaType() As clsSemItem

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private objFrmSemManager As frmSemManager
    Private objVersionWork As Version_Module.clsVersionWork
    Private objLogManagement As clsLogManagement
    Private objFrmFileManagement As frmFilesystemManagement

    Public Function save_001_DBSchema(ByVal SemItem_DBSchema As clsSemItem) As clsSemItem
        Dim objDRC_DBSchema As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objSemItem_DBSchema = SemItem_DBSchema

        objDRC_DBSchema = semtblA_Token.GetData_Token_By_GUID(objSemItem_DBSchema.GUID).Rows
        If objDRC_DBSchema.Count > 0 Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DBSchema.GUID, objSemItem_DBSchema.Name, objSemItem_DBSchema.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        
        Return objSemItem_Result
    End Function

    Public Function del_001_DBSchema() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_DBSchema.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_DBSchema_To_SchemaType() As clsSemItem
        Dim objSemItem_SchemaType As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim i As Integer
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_SchemaTypes As DataRowCollection
        Dim objDR_SchemaType As DataRow
        Dim boolDel As Boolean
        Dim boolAdd As Boolean
        Dim boolReverse As Boolean = False

        boolAdd = True
        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_DB_Schema_Type, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(frmSchemaManager)
        If objFrmSemManager.DialogResult = DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                ReDim Preserve objSemItems_SchemaType(objFrmSemManager.SelectedRows_Items.Count - 1)
                i = 0
                For Each objDGVR_Selected In objFrmSemManager.SelectedRows_Items
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_DB_Schema_Type.GUID Then
                        boolReverse = False
                        objSemItems_SchemaType(i) = New clsSemItem
                        objSemItems_SchemaType(i).GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItems_SchemaType(i).Name = objDRV_Selected.Item("Name_Token")
                        objSemItems_SchemaType(i).GUID_Parent = objLocalConfig.SemItem_Type_DB_Schema_Type.GUID
                        objSemItems_SchemaType(i).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    Else
                        boolReverse = True
                        Exit For
                    End If
                    


                Next
                If boolReverse = False Then
                    objDRC_SchemaTypes = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_DBSchema.GUID, objLocalConfig.SemItem_RelationType_is_of_Type.GUID, objLocalConfig.SemItem_Type_DB_Schema_Type.GUID).Rows
                    For Each objDR_SchemaType In objDRC_SchemaTypes
                        boolDel = True
                        For i = 0 To objSemItems_SchemaType.Length - 1
                            If objDR_SchemaType.Item("GUID_Token_Right") = objSemItems_SchemaType(i).GUID Then
                                objSemItems_SchemaType(i).Mark = True
                                boolDel = False
                            End If
                        Next
                        If boolDel = True Then
                            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBSchema.GUID, objDR_SchemaType.Item("GUID_Token_Right"), objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
                            If Not objDRC_LogState(0).Item("GIUD_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                boolAdd = False
                                Exit For
                            End If
                        End If
                    Next
                    If boolAdd = True Then
                        For Each objSemItem_SchemaType In objSemItems_SchemaType
                            If objSemItem_SchemaType.Mark = False Then
                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBSchema.GUID, objSemItem_SchemaType.GUID, objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 0).Rows
                                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                Else
                    MsgBox("Bitte mindestens ein Item vom Typ " & objLocalConfig.SemItem_Type_DB_Schema_Type.Name & " auswählen!", MsgBoxStyle.Exclamation)
                    objSemItem_Result = save_002_DBSchema_To_SchemaType()
                End If
            Else
                MsgBox("Bitte mindestens ein Item vom Typ " & objLocalConfig.SemItem_Type_DB_Schema_Type.Name & " auswählen!", MsgBoxStyle.Exclamation)
                objSemItem_Result = save_002_DBSchema_To_SchemaType()
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        
        Return objSemItem_Result
    End Function

    Public Function del_002_DBSchema_To_SchemaType() As clsSemItem
        Dim objDRC_SchemaTypes As DataRowCollection
        Dim objDR_SchemaType As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success

        objDRC_SchemaTypes = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_DBSchema.GUID, objLocalConfig.SemItem_RelationType_is_of_Type.GUID, objLocalConfig.SemItem_Type_DB_Schema_Type.GUID).Rows
        For Each objDR_SchemaType In objDRC_SchemaTypes
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBSchema.GUID, objDR_SchemaType.Item("GUID_Token_Right"), objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_003_DBSchema_To_DevelopmentVersion() As clsSemItem
        Dim objSemItem_Result As clsSemItem

       
        objVersionWork = New Version_Module.clsVersionWork(objLocalConfig.Globals, objSemItem_DBSchema, objLocalConfig.User, frmSchemaManager)
        objVersionWork.SemItem_LogState = objLocalConfig.SemItem_Token_LogState_Create
        objSemItem_Result = objVersionWork.save_Version(False)

        Return objSemItem_Result
    End Function

    Public Function del_003_DBSchema_To_DevelopmentVersion() As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objVersionWork.del_Versions_Of_Rel
        Return objSemItem_Result
    End Function
    Public Function save_004_DBSchema_To_File() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_LogState As DataRowCollection

        objFrmFileManagement = New frmFilesystemManagement(objLocalConfig.Globals)
        objFrmFileManagement.Applyable = True
        objFrmFileManagement.ShowDialog(frmSchemaManager)
        If objFrmFileManagement.DialogResult = DialogResult.OK Then
            If objFrmFileManagement.GUID_SelectedParent = objLocalConfig.SemItem_Type_File.GUID Then
                If objFrmFileManagement.DGVSRC_Files.Count = 1 Then
                    objDGVR_Selected = objFrmFileManagement.DGVSRC_Files(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    objSemItem_File = New clsSemItem
                    objSemItem_File.GUID = objDRV_Selected.Item("GUID_File")
                    objSemItem_File.Name = objDRV_Selected.Item("Name_File")
                    objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                    objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBSchema.GUID, objSemItem_File.GUID, objLocalConfig.SemItem_RelationType_export_to.GUID, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    MsgBox("Bitte eine Datei für den SQL-Export auswählen!", MsgBoxStyle.Exclamation)
                    objSemItem_Result = save_004_DBSchema_To_File()
                End If
            Else
                MsgBox("Bitte eine Datei für den SQL-Export auswählen!", MsgBoxStyle.Exclamation)
                objSemItem_Result = save_004_DBSchema_To_File()
            End If
        Else

            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_DBSchema_To_File() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBSchema.GUID, objSemItem_File.GUID, objLocalConfig.SemItem_RelationType_export_to.GUID).Rows

        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    
    Public Sub New()
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        objLogManagement = New clsLogManagement(objLocalConfig.Globals)
    End Sub
End Class
