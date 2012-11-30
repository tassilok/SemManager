Imports Sem_Manager
'Imports Version_Module
Public Class clsTransaction_DBViewSchema
    Private objSemItem_Database As clsSemItem
    Private objSemItem_Synonym_Database As clsSemItem
    Private objSemItem_Synonym_Server As clsSemItem
    Private objSemItem_DatabaseOnServer_DB As clsSemItem
    Private objSemItem_Server As clsSemItem
    Private objSemItem_Schema As clsSemItem
    Private objSemItem_SchemaType As clsSemItem
    Private objSemItem_DatbaseForSynonyms As clsSemItem
    Private objSemItem_Version As clsSemItem

    Private funcT_SemDatabasesOnServers As ds_SchemaManager.func_SemDatabasesOnServersDataTable

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private objFrmSemManager As frmSemManager
    'Private objVersionWork As Version_Module.clsVersionWork
    Private objDlg_AttributeVarchar255 As dlgAttribute_Varchar255
    Private objForm As Windows.Forms.IWin32Window

    Private GIUD_TokenAttribute_isSemItem As Guid

    Public Function get_001_TransactionData(ByVal SemItem_Server As clsSemItem, ByRef _funcT_SemDatabasesOnServers As ds_SchemaManager.func_SemDatabasesOnServersDataTable, ByRef _Form As Windows.Forms.IWin32Window) As clsSemItem
        Dim objDRs_DatabaseOnServer() As DataRow
        Dim objSemItem_Result As clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        objForm = _Form
        funcT_SemDatabasesOnServers = _funcT_SemDatabasesOnServers
        objSemItem_Server = SemItem_Server

        MsgBox("Bitte die Datenbank auswählen, die für diesen Server angelegt werden soll!", MsgBoxStyle.Information)
        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_Type_Database, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(objForm)

        'objDlg_AttributeVarchar255 = New dlgAttribute_Varchar255("New " & objLocalConfig.SemItem_Type_Database.Name, objLocalConfig.Globals)
        'objDlg_AttributeVarchar255.ShowDialog(objForm)
        'If objDlg_AttributeVarchar255.DialogResult = DialogResult.OK Then
        If objFrmSemManager.DialogResult = DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_Type_Database.GUID Then
                        objSemItem_Database = New clsSemItem
                        objSemItem_Database.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Database.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Database.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                        objSemItem_Database.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        objDRs_DatabaseOnServer = funcT_SemDatabasesOnServers.Select("Name_Database='" & objSemItem_Database.Name & "'")
                        If objDRs_DatabaseOnServer.Count = 0 Then
                            objSemItem_Database.GUID = Guid.NewGuid
                            objSemItem_Database.GUID_Parent = objLocalConfig.SemItem_Type_Database.GUID
                            objSemItem_Database.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            objSemItem_Result = get_002_Refs(objLocalConfig.SemItem_Type_Database_Schema)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = get_002_Refs(objLocalConfig.SemItem_Type_DB_Schema_Type)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = get_002_Refs(objLocalConfig.SemItem_Type_Database)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Result = get_002_Refs(objLocalConfig.SemItem_Type_Server)
                                    End If
                                End If
                            End If

                        Else
                            MsgBox("Die Datenbank wurde an diesem Server schon registriert!", MsgBoxStyle.Exclamation)
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End If
                    Else
                        MsgBox("Bitte nur eine Datenbank auswählen!", MsgBoxStyle.Exclamation)
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    MsgBox("Bitte nur eine Datenbank auswählen!", MsgBoxStyle.Exclamation)
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error

                End If
            Else
                MsgBox("Bitte nur eine Datenbank auswählen!", MsgBoxStyle.Exclamation)
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
            
            
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        End If

        Return objSemItem_Result
    End Function

    Private Function get_002_Refs(ByVal objSemItem_TokenType As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDGVR_Schema As DataGridViewRow
        Dim objDRV_Schema As DataRowView
        Dim objDRC_Version As DataRowCollection


        Select Case objSemItem_TokenType.GUID
            Case objLocalConfig.SemItem_Type_Database_Schema.GUID
                MsgBox("Bitte das Schema der zu erzeugen Datenbank auswählen!", MsgBoxStyle.Information)

            Case objLocalConfig.SemItem_Type_DB_Schema_Type.GUID
                MsgBox("Bitte den Schematyp der zu erzeugen Datenbank auswählen!", MsgBoxStyle.Information)
            Case objLocalConfig.SemItem_Type_Database.GUID
                MsgBox("Bitte die Synonym-Datenbank der zu erzeugen Datenbank auswählen!", MsgBoxStyle.Information)

            Case objLocalConfig.SemItem_Type_Server.GUID

                MsgBox("Bitte den Synonym-Server der zu erzeugen Datenbank auswählen!", MsgBoxStyle.Information)

        End Select
        objFrmSemManager = New frmSemManager(objSemItem_TokenType, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(objForm)
        If objFrmSemManager.DialogResult = DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Schema = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Schema = objDGVR_Schema.DataBoundItem
                    If objDRV_Schema.Item("GUID_Type") = objSemItem_TokenType.GUID Then
                        Select Case objSemItem_TokenType.GUID
                            Case objLocalConfig.SemItem_Type_Database_Schema.GUID
                                objSemItem_Schema = New clsSemItem
                                objSemItem_Schema.GUID = objDRV_Schema.Item("GUID_Token")
                                objSemItem_Schema.Name = objDRV_Schema.Item("Name_Token")
                                objSemItem_Schema.GUID_Parent = objSemItem_TokenType.GUID
                                objSemItem_Schema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                objSemItem_Result = objLocalConfig.Globals.LogState_Success

                                objDRC_Version = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Schema.GUID, _
                                                                                                objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                                                objLocalConfig.SemItem_type_DevelopmentVersion.GUID).Rows
                                If objDRC_Version.Count > 0 Then
                                    objSemItem_Version = New clsSemItem
                                    objSemItem_Version.GUID = objDRC_Version(0).Item("GUID_Token_Right")
                                    objSemItem_Version.Name = objDRC_Version(0).Item("Name_Token_Right")
                                    objSemItem_Version.GUID_Parent = objLocalConfig.SemItem_type_DevelopmentVersion.GUID
                                    objSemItem_Version.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                Else
                                    objSemItem_Version = Nothing
                                End If
                            Case objLocalConfig.SemItem_Type_DB_Schema_Type.GUID
                                objSemItem_SchemaType = New clsSemItem
                                objSemItem_SchemaType.GUID = objDRV_Schema.Item("GUID_Token")
                                objSemItem_SchemaType.Name = objDRV_Schema.Item("Name_Token")
                                objSemItem_Schema.GUID_Parent = objSemItem_TokenType.GUID
                                objSemItem_SchemaType.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                            Case objLocalConfig.SemItem_Type_Database.GUID
                                objSemItem_Synonym_Database = New clsSemItem
                                objSemItem_Synonym_Database.GUID = objDRV_Schema.Item("GUID_Token")
                                objSemItem_Synonym_Database.Name = objDRV_Schema.Item("Name_Token")
                                objSemItem_Synonym_Database.GUID_Parent = objSemItem_TokenType.GUID
                                objSemItem_Synonym_Database.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                            Case objLocalConfig.SemItem_Type_Server.GUID
                                objSemItem_Synonym_Server = New clsSemItem
                                objSemItem_Synonym_Server.GUID = objDRV_Schema.Item("GUID_Token")
                                objSemItem_Synonym_Server.Name = objDRV_Schema.Item("Name_Token")
                                objSemItem_Synonym_Server.GUID_Parent = objSemItem_TokenType.GUID
                                objSemItem_Synonym_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                            Case Else
                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        End Select

                    Else
                        MsgBox("Bitte nur einen Schematyp auswählen!", MsgBoxStyle.Exclamation)
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else
                    MsgBox("Bitte nur einen Schematyp auswählen!", MsgBoxStyle.Exclamation)
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                MsgBox("Bitte nur einen Schematyp auswählen!", MsgBoxStyle.Exclamation)
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            MsgBox("Bitte nur einen Schematyp auswählen!", MsgBoxStyle.Exclamation)
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_001_Database() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Database As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objDRC_Database = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_Database.GUID, _
                                                                           objSemItem_Database.Name).Rows
        If objDRC_Database.Count > 0 Then
            objSemItem_Database.GUID = objDRC_Database(0).Item("GUID_Token")
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Database.GUID, objSemItem_Database.Name, objSemItem_Database.GUID_Parent, True).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        

        Return objSemItem_Result
    End Function

    Public Function del_001_Database() As clsSemItem
        Dim objSemItem_Result As clsSemItem

        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Database.GUID).Rows

        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_DB_isSemDB() As clsSemItem
        Dim objDRC_SemDB As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_SemDB As DataRow
        Dim objSemItem_Result As clsSemItem
        Dim boolSave As Boolean
        Dim i As Integer

        boolSave = True
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        objDRC_SemDB = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Database.GUID, objLocalConfig.SemItem_Attribute_is_Sem_DB.GUID).Rows
        If objDRC_SemDB.Count > 1 Then
            boolSave = False
            For i = 1 To objDRC_SemDB.Count - 1
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_SemDB(i).Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
            If objDRC_SemDB(0).Item("Val") = False Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Database.GUID, _
                                                                                  objLocalConfig.SemItem_Attribute_is_Sem_DB.GUID, _
                                                                                  objDRC_SemDB(0).Item("GUID_TokenAttribute"), _
                                                                                  True, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                    objSemItem_Database.GUID_Related = objDRC_SemDB(0).Item("GUID_TokenAttribute")
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        End If
        If boolSave = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_Database.GUID, _
                                                                              objLocalConfig.SemItem_Attribute_is_Sem_DB.GUID, _
                                                                              Nothing, _
                                                                              True, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Database.GUID_Related = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        Return objSemItem_Result
    End Function

    Public Function del_002_DB_isSemDB() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_SemDB As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_SemDB As DataRow

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        objDRC_SemDB = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Database.GUID, objLocalConfig.SemItem_Attribute_is_Sem_DB.GUID).Rows
        For Each objDR_SemDB In objDRC_SemDB
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_SemDB.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_003_DB_To_Schema() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_DB_To_SchemaType As DataRowCollection
        Dim objDR_DB_To_SchemaType As DataRow
        Dim boolAdd As Boolean

        objDRC_DB_To_SchemaType = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Database.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                                 objLocalConfig.SemItem_Type_Database_Schema.GUID).Rows
        boolAdd = True
        For Each objDR_DB_To_SchemaType In objDRC_DB_To_SchemaType
            If objDR_DB_To_SchemaType.Item("GUID_Token_Right") = objSemItem_Schema.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Database.GUID, _
                                                                       objDR_DB_To_SchemaType.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    boolAdd = False
                    Exit For
                End If
            End If
        Next

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Database.GUID, _
                                                                    objSemItem_Schema.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_003_DB_To_Schema() As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success
        Dim objDRC_DB_To_SchemaType As DataRowCollection
        Dim objDR_DB_To_SchemaType As DataRow

        Dim objDRC_LogState As DataRowCollection

        objDRC_DB_To_SchemaType = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Database.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                                 objLocalConfig.SemItem_Type_Database_Schema.GUID).Rows
        For Each objDR_DB_To_SchemaType In objDRC_DB_To_SchemaType
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Database.GUID, _
                                                                   objDR_DB_To_SchemaType.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then

                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_004_DB_To_SchemaType() As clsSemItem
        Dim objDRC_SchemaType As DataRowCollection
        Dim objDR_SchemaType As DataRow

        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        Dim boolAdd As Boolean

        objDRC_SchemaType = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Database.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                           objLocalConfig.SemItem_Type_DB_Schema_Type.GUID).Rows

        boolAdd = True
        For Each objDR_SchemaType In objDRC_SchemaType
            If objDR_SchemaType.Item("GUID_Token_Right") = objLocalConfig.SemItem_Type_DB_Schema_Type.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Database.GUID, _
                                                                       objSemItem_SchemaType.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next
        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Database.GUID, _
                                                                    objSemItem_SchemaType.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        Return objSemItem_Result
    End Function

    Public Function del_004_DB_To_SchemaType() As clsSemItem
        Dim objDRC_DB_To_SchemaType As DataRowCollection
        Dim objDR_DB_To_SchemaType As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_DB_To_SchemaType = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Database.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                                 objSemItem_SchemaType.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_DB_To_SchemaType In objDRC_DB_To_SchemaType
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Database.GUID, _
                                                                   objDR_DB_To_SchemaType.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_008_DatabaseForSynonyms() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_DatabaseForSynonyms As DataRowCollection

        Dim objDRC_LogState As DataRowCollection


        objDRC_DatabaseForSynonyms = funcA_Token_Token.GetData_TokenToken_RightLeft(objSemItem_Synonym_Database.GUID, _
                                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                    objLocalConfig.SemItem_Type_Database_for_Synonyms.GUID).Rows

        If objDRC_DatabaseForSynonyms.Count > 0 Then
            objSemItem_DatbaseForSynonyms = New clsSemItem
            objSemItem_DatbaseForSynonyms.GUID = objDRC_DatabaseForSynonyms(0).Item("GUID_Token_Left")
            objSemItem_DatbaseForSynonyms.Name = objDRC_DatabaseForSynonyms(0).Item("Name_Token_Left")
            objSemItem_DatbaseForSynonyms.GUID_Parent = objLocalConfig.SemItem_Type_Database_for_Synonyms.GUID
            objSemItem_DatbaseForSynonyms.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_DatabaseForSynonyms = funcA_Token_Token.GetData_TokenToken_LeftRight(objDRC_DatabaseForSynonyms(0).Item("GUID_Token_Left"), _
                                                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                        objLocalConfig.SemItem_Type_Server.GUID).Rows
            If objDRC_DatabaseForSynonyms.Count > 0 Then

                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            End If

        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objSemItem_DatbaseForSynonyms = New clsSemItem
            objSemItem_DatbaseForSynonyms.GUID = Guid.NewGuid
            objSemItem_DatbaseForSynonyms.Name = objSemItem_Synonym_Database.Name & "\" & objSemItem_Server.Name
            If objSemItem_DatbaseForSynonyms.Name.Length > 255 Then
                objSemItem_DatbaseForSynonyms.Name = objSemItem_DatbaseForSynonyms.Name.Substring(0, 254)
            End If
            objSemItem_DatbaseForSynonyms.GUID_Parent = objLocalConfig.SemItem_Type_Database_for_Synonyms.GUID
            objSemItem_DatbaseForSynonyms.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DatbaseForSynonyms.GUID, _
                                                                 objSemItem_DatbaseForSynonyms.Name, _
                                                                 objSemItem_DatbaseForSynonyms.GUID_Parent, True).Rows

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        

        Return objSemItem_Result

    End Function

    Public Function del_008_DatabaseForSynonyms() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_DatbaseForSynonyms.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_009_DatabaseForSynonyms_To_DB() As clsSemItem
        Dim objDRC_DB_To_DatabaseForSynonyms As DataRowCollection
        Dim objDR_DB_To_DatabaseForSynonyms As DataRow

        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem


        objDRC_DB_To_DatabaseForSynonyms = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DatbaseForSynonyms.GUID, _
                                                                                          objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                          objLocalConfig.SemItem_Type_Database.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_DB_To_DatabaseForSynonyms In objDRC_DB_To_DatabaseForSynonyms
            If objDR_DB_To_DatabaseForSynonyms.Item("GUID_Token_Right") = objSemItem_Database.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatbaseForSynonyms.GUID, _
                                                                       objDR_DB_To_DatabaseForSynonyms.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error

                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DatbaseForSynonyms.GUID, _
                                                                    objSemItem_Synonym_Database.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function
    Public Function del_009_DatabaseForSynonyms_To_DB() As clsSemItem

        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatbaseForSynonyms.GUID, _
                                                               objSemItem_Database.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_010_DBForSynonyms_To_DBOnServer() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_DBForSynonyms_To_DBOnServer As DataRowCollection
        Dim objDR_DBForSynonyms_To_DBOnServer As DataRow
        Dim objDRC_LogState As DataRowCollection

        objDRC_DBForSynonyms_To_DBOnServer = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DatbaseForSynonyms.GUID, _
                                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                            objLocalConfig.SemItem_Type_Database_on_Server.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_DBForSynonyms_To_DBOnServer In objDRC_DBForSynonyms_To_DBOnServer
            If objDR_DBForSynonyms_To_DBOnServer.Item("GUID_Token_Right") = objSemItem_DatabaseOnServer_DB.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatbaseForSynonyms.GUID, _
                                                                       objDR_DBForSynonyms_To_DBOnServer.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DatbaseForSynonyms.GUID, _
                                                                    objSemItem_DatabaseOnServer_DB.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_010_DBForSynonyms_To_DBOnServer() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_DBForSynonyms_To_DBOnServer As DataRowCollection
        Dim objDR_DBForSynonyms_To_DBOnServer As DataRow

        objDRC_DBForSynonyms_To_DBOnServer = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DatbaseForSynonyms.GUID, _
                                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                            objLocalConfig.SemItem_Type_Database_on_Server.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_DBForSynonyms_To_DBOnServer In objDRC_DBForSynonyms_To_DBOnServer

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatbaseForSynonyms.GUID, _
                                                                   objDR_DBForSynonyms_To_DBOnServer.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then

                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next
        Return objSemItem_Result
    End Function

    Public Function save_012_DBForSynonyms_To_Server() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        Dim objDRC_DBForSynonyms_To_Server As DataRowCollection
        Dim objDR_DBForSynonyms_To_Server As DataRow

        objDRC_DBForSynonyms_To_Server = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DatbaseForSynonyms.GUID, _
                                                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                        objLocalConfig.SemItem_Type_Server.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_DBForSynonyms_To_Server In objDRC_DBForSynonyms_To_Server
            If objDR_DBForSynonyms_To_Server.Item("GUID_Token_Right") = objSemItem_Synonym_Server.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatbaseForSynonyms.GUID, _
                                                                       objDR_DBForSynonyms_To_Server.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DatbaseForSynonyms.GUID, _
                                                                    objSemItem_Synonym_Server.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_012_DBForSynonyms_To_Server() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        Dim objDRC_DBForSynonyms_To_Server As DataRowCollection
        Dim objDR_DBForSynonyms_To_Server As DataRow

        objDRC_DBForSynonyms_To_Server = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DatbaseForSynonyms.GUID, _
                                                                                        objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                        objLocalConfig.SemItem_Type_Server.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_DBForSynonyms_To_Server In objDRC_DBForSynonyms_To_Server

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatbaseForSynonyms.GUID, _
                                                                   objDR_DBForSynonyms_To_Server.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_005_DatabaseOnServer() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim objDRs_DatabaseOnServer() As DataRow

        objDRs_DatabaseOnServer = funcT_SemDatabasesOnServers.Select("GUID_Database='" & objSemItem_Database.GUID.ToString & "'")
        If objDRs_DatabaseOnServer.Count = 0 Then
            objSemItem_DatabaseOnServer_DB = New clsSemItem
            objSemItem_DatabaseOnServer_DB.GUID = Guid.NewGuid
            objSemItem_DatabaseOnServer_DB.Name = objSemItem_Database.Name & "\" & objSemItem_Server.Name
            If objSemItem_DatabaseOnServer_DB.Name.Length > 255 Then
                objSemItem_DatabaseOnServer_DB.Name = objSemItem_DatabaseOnServer_DB.Name.Substring(0, 254)

            End If
            objSemItem_DatabaseOnServer_DB.GUID_Parent = objLocalConfig.SemItem_Type_Database_on_Server.GUID
            objSemItem_DatabaseOnServer_DB.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                 objSemItem_DatabaseOnServer_DB.Name, _
                                                                 objSemItem_DatabaseOnServer_DB.GUID_Parent, True).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_DatabaseOnServer_DB = New clsSemItem
            objSemItem_DatabaseOnServer_DB.GUID = objDRs_DatabaseOnServer(0).Item("GUID_DatabaseOnServer")
            objSemItem_DatabaseOnServer_DB.Name = objDRs_DatabaseOnServer(0).Item("Name_DatabaseOnServer")
            objSemItem_DatabaseOnServer_DB.GUID_Parent = objLocalConfig.SemItem_Type_Database_on_Server.GUID
            objSemItem_DatabaseOnServer_DB.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_DatabaseOnServer() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_DatabaseOnServer_DB.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_006_DatabaseOnServer_To_Database() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_DatabaseOnServer_To_Database As DataRowCollection
        Dim objDR_DatabaseOnServer_To_Database As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim boolAdd = True

        objDRC_DatabaseOnServer_To_Database = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                                             objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                             objLocalConfig.SemItem_Type_Database.GUID).Rows
        boolAdd = True
        For Each objDR_DatabaseOnServer_To_Database In objDRC_DatabaseOnServer_To_Database
            If objDR_DatabaseOnServer_To_Database.Item("GUID_Token_Right") = objSemItem_Database.GUID Then
                boolAdd = False
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                       objSemItem_Database.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    boolAdd = False
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                    objSemItem_Database.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

        End If

        Return objSemItem_Result
    End Function

    Public Function del_006_DatabaseOnServer_To_Database() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_DatabaseOnServer_To_Database As DataRowCollection
        Dim objDR_DatabaseOnServer_To_Database As DataRow
        Dim objDRC_LogState As DataRowCollection

        objDRC_DatabaseOnServer_To_Database = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                                             objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                             objLocalConfig.SemItem_Type_Database.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_DatabaseOnServer_To_Database In objDRC_DatabaseOnServer_To_Database
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                   objDR_DatabaseOnServer_To_Database.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next


        Return objSemItem_Result
    End Function

    Public Function save_007_DatabaseOnServer_To_Server() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_DatabaseOnServer_To_Server As DataRowCollection
        Dim objDR_DatabaseOnServer_To_Server As DataRow
        Dim objDRC_LogState As DataRowCollection

        objDRC_DatabaseOnServer_To_Server = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                                           objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                                                                           objLocalConfig.SemItem_Type_Server.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_DatabaseOnServer_To_Server In objDRC_DatabaseOnServer_To_Server
            If objDR_DatabaseOnServer_To_Server.Item("GUID_Token_Right") = objSemItem_Server.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                        objSemItem_Server.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_located_in.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                    objSemItem_Server.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_located_in.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error

            End If
        End If
        Return objSemItem_Result
    End Function
    Public Function del_007_DatabaseOnServer_To_Server() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_DatabaseOnServer_To_Server As DataRowCollection
        Dim objDR_DatabaseOnServer_To_Server As DataRow
        Dim objDRC_LogState As DataRowCollection

        objDRC_DatabaseOnServer_To_Server = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                                           objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                                                                           objLocalConfig.SemItem_Type_Server.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_DatabaseOnServer_To_Server In objDRC_DatabaseOnServer_To_Server

            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                    objSemItem_Server.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_located_in.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If

        Next

        Return objSemItem_Result
    End Function

    Public Function save_011_Version(Optional ByVal SemItem_DatabaseOnServer_DB As clsSemItem = Nothing, Optional ByVal SemItem_Version As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_Version_Old As New clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Version As DataRowCollection
        Dim objDR_Version As DataRow

        If Not SemItem_DatabaseOnServer_DB Is Nothing Then
            objSemItem_DatabaseOnServer_DB = SemItem_DatabaseOnServer_DB
        End If

        If Not SemItem_Version Is Nothing Then
            objSemItem_Version = SemItem_Version
        End If

        objDRC_Version = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_isInState.GUID, _
                                                                        objLocalConfig.SemItem_type_DevelopmentVersion.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_Version In objDRC_Version
            If objDR_Version.Item("Name_Token_Right") = objSemItem_Version.Name Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Version_Old.GUID = objDR_Version("GUID_Token_Right")
                objSemItem_Version_Old.Name = objDR_Version("Name_Token_Right")
                objSemItem_Version_Old.GUID_Parent = objDR_Version("GUID_Type_Right")
                objSemItem_Version_Old.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objSemItem_Result = del_011_Version(objSemItem_DatabaseOnServer_DB, objSemItem_Version_Old)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    Exit For
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            If Not SemItem_Version Is Nothing Then
                objSemItem_Version = SemItem_Version
            End If

            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DatabaseOnServer_DB.GUID, _
                                                                objSemItem_Version.GUID, _
                                                                objLocalConfig.SemItem_RelationType_isInState.GUID, 0).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        

        'objVersionWork = New Version_Module.clsVersionWork(objLocalConfig.Globals, objSemItem_DatabaseOnServer_DB, objLocalConfig.User, objForm)

        'objSemItem_Result = objVersionWork.save_FirstVersion()
        Return objSemItem_Result
    End Function

    Public Function del_011_Version(Optional ByVal SemItem_DatabaseOnServer_DB As clsSemItem = Nothing, Optional ByVal SemItem_Version As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        'objVersionWork = New Version_Module.clsVersionWork(objLocalConfig.Globals, objSemItem_DatabaseOnServer_DB, objLocalConfig.User, objForm)
        'objSemItem_Result = objVersionWork.del_Versions_Of_Rel()

        If Not SemItem_DatabaseOnServer_DB Is Nothing Then
            objSemItem_DatabaseOnServer_DB = SemItem_DatabaseOnServer_DB
        End If

        If Not SemItem_Version Is Nothing Then
            objSemItem_Version = SemItem_Version
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DatabaseOnServer_DB.GUID, _
                                                               objSemItem_Version.GUID, _
                                                               objLocalConfig.SemItem_RelationType_isInState.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
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
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
