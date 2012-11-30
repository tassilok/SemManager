Imports Sem_Manager
Imports Log_Manager
Public Class clsDBItemWork
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private procA_TokenAttribute_Bit As New ds_TokenAttributeTableAdapters.TokenAttribute_BitTableAdapter
    Private procA_TokenAttribute_VARCHARMAX As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_Token_Attribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBWork_Save_Token_Attribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_DBwork_Del_Token_Attribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private procA_DBItems_In_Schema As New ds_SchemaManagerTableAdapters.proc_DBItems_In_SchemaTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private procA_TSQL_ObjectReference As New ds_TemplateViewTableAdapters.proc_TSQL_ObjectDefinitionTableAdapter
    Private procA_CreationScript_Of_DBItem_By_GUIDDBItem As New ds_SchemaManagerTableAdapters.proc_CreationScript_Of_DBItem_By_GUIDDBItemTableAdapter

    Private procA_TSQL_PARAMETERS As New ds_TemplateViewTableAdapters.proc_TSQL_ParametersTableAdapter
    Private procA_TSQL_Functions As New ds_TemplateViewTableAdapters.proc_TSQL_FunctionsTableAdapter
    Private procA_TSQL_procedures As New ds_TemplateViewTableAdapters.proc_TSQL_ProceduresTableAdapter
    Private procA_TSQL_synonyms As New ds_TemplateViewTableAdapters.proc_TSQL_SynonymsTableAdapter
    Private procA_TSQL_Tables As New ds_TemplateViewTableAdapters.proc_TSQL_TablesTableAdapter
    Private procA_TSQL_triggers As New ds_TemplateViewTableAdapters.proc_TSQL_TriggersTableAdapter
    Private procA_TSQL_views As New ds_TemplateViewTableAdapters.proc_TSQL_ViewsTableAdapter

    'Private date_LogEntry As Date
    Private objSemItem_LogEntry_Creation As clsSemItem
    Private objSemItem_LogEntry_Change As clsSemItem
    Private objSemItem_DBItem As clsSemItem
    Private objSemItem_DBItemInSchema As clsSemItem
    Private objSemItem_CreationScript As clsSemItem
    Private objSemItem_XML As clsSemItem
    Private objSemItem_Result_CreationScript As clsSemItem
    Private date_LogEntry_Creation As Date
    Private date_LogEntry_Change As Date

    Private strXML As String = "<?xml version=""1.0"" encoding=""utf-8""?>" & vbCrLf & _
                "<data>" & vbCrLf & _
                "<![CDATA[@Script@" & _
                "]]>" & vbCrLf & _
                "</data>"
    
    Private objLogManagement As clsLogManagement
    Private GUID_TokenAttribute_XMLText As Guid
    Private GUID_DatabaseSchema As Guid
    Private strParameters() As String
    Private GUIDs_Parameter() As Guid
    Private GUIDs_ParameterRel() As Guid
    Private GUIDs_ParameterRel_DBSchema() As Guid

    Private boolDBItem_Exists As Boolean
    Private boolDBItemInSchema_Exists As Boolean

    Public Property SemItem_DBItem
        Get
            Return objSemItem_DBItem
        End Get
        Set(ByVal value)
            objSemItem_DBItem = value
        End Set
    End Property

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Token_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_Attribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_Attribute_Bit.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB
        semprocA_DBwork_Del_Token_Attribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        procA_TSQL_ObjectReference.Connection = objLocalConfig.Connection_DB

        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB

        procA_DBItems_In_Schema.Connection = objLocalConfig.Connection_Plugin
        procA_CreationScript_Of_DBItem_By_GUIDDBItem.Connection = objLocalConfig.Connection_Plugin

        objLogManagement = New clsLogManagement(objLocalConfig.Globals)
    End Sub
    Public Function save_001_DBItem(ByVal SemItem_DBItem As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_DBItem As DataRowCollection
        objSemItem_DBItem = SemItem_DBItem
        objDRC_DBItem = semtblA_Token.GetData_Token_By_GUID(objSemItem_DBItem.GUID).Rows
        If objDRC_DBItem.Count = 0 Then
            boolDBItem_Exists = False
            Dim objDRC_LogState As DataRowCollection
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DBItem.GUID, objSemItem_DBItem.Name, objSemItem_DBItem.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            boolDBItem_Exists = True
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function
    Public Function del_001_DBItem() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        If boolDBItem_Exists = False Then
            objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_DBItem.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

    End Function

    Public Function save_002_DBItem_In_Schema() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_DBItemInSchema As DataRowCollection



        objDRC_DBItemInSchema = procA_DBItems_In_Schema.GetData(objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                                 objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                                 objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                                                 objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                                                 objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                                 objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                                 objLocalConfig.SemItem_Type_Functions_in_Schema.GUID, _
                                                                 objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID, _
                                                                 objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID, _
                                                                 objLocalConfig.SemItem_Type_Tables_in_Schema.GUID, _
                                                                 objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID, _
                                                                 objLocalConfig.SemItem_Type_Views_in_Schema.GUID, _
                                                                 objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                 GUID_DatabaseSchema, _
                                                                 objSemItem_DBItem.GUID).Rows


        If objDRC_DBItemInSchema.Count = 0 Then
            boolDBItemInSchema_Exists = False
            objSemItem_DBItemInSchema = New clsSemItem
            objSemItem_DBItemInSchema.GUID = Guid.NewGuid
            objSemItem_DBItemInSchema.Name = objSemItem_DBItem.Name
            Select Case objSemItem_DBItem.GUID_Parent
                Case objLocalConfig.SemItem_Type_DB_Function.GUID
                    objSemItem_DBItemInSchema.GUID_Parent = objLocalConfig.SemItem_Type_Functions_in_Schema.GUID
                Case objLocalConfig.SemItem_Type_DB_Procedure.GUID
                    objSemItem_DBItemInSchema.GUID_Parent = objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID
                Case objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                    objSemItem_DBItemInSchema.GUID_Parent = objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID
                Case objLocalConfig.SemItem_Type_DB_Tables.GUID
                    objSemItem_DBItemInSchema.GUID_Parent = objLocalConfig.SemItem_Type_Tables_in_Schema.GUID
                Case objLocalConfig.SemItem_Type_DB_Triggers.GUID
                    objSemItem_DBItemInSchema.GUID_Parent = objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID
                Case objLocalConfig.SemItem_Type_DB_Views.GUID
                    objSemItem_DBItemInSchema.GUID_Parent = objLocalConfig.SemItem_Type_Views_in_Schema.GUID

            End Select
            objSemItem_DBItemInSchema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DBItemInSchema.GUID, objSemItem_DBItemInSchema.Name, objSemItem_DBItemInSchema.GUID_Parent, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_DBItemInSchema = New clsSemItem
            objSemItem_DBItemInSchema.GUID = objDRC_DBItemInSchema(0).Item("GUID_DBItemInSchema")
            objSemItem_DBItemInSchema.Name = objDRC_DBItemInSchema(0).Item("Name_DBItemInSchema")
            Select Case objSemItem_DBItem.GUID_Parent
                Case objLocalConfig.SemItem_Type_DB_Function.GUID
                    objSemItem_DBItemInSchema.GUID_Parent = objLocalConfig.SemItem_Type_Functions_in_Schema.GUID
                Case objLocalConfig.SemItem_Type_DB_Procedure.GUID
                    objSemItem_DBItemInSchema.GUID_Parent = objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID
                Case objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                    objSemItem_DBItemInSchema.GUID_Parent = objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID
                Case objLocalConfig.SemItem_Type_DB_Tables.GUID
                    objSemItem_DBItemInSchema.GUID_Parent = objLocalConfig.SemItem_Type_Tables_in_Schema.GUID
                Case objLocalConfig.SemItem_Type_DB_Triggers.GUID
                    objSemItem_DBItemInSchema.GUID_Parent = objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID
                Case objLocalConfig.SemItem_Type_DB_Views.GUID
                    objSemItem_DBItemInSchema.GUID_Parent = objLocalConfig.SemItem_Type_Views_in_Schema.GUID

            End Select
            objSemItem_DBItemInSchema.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            boolDBItemInSchema_Exists = True
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function
    Public Function del_002_DBItemInSchema() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        If boolDBItemInSchema_Exists = False Then
            objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_DBItemInSchema.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function
    Public Function save_003_DBItemInSchema_To_Schema() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBItemInSchema.GUID, GUID_DatabaseSchema, objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function del_003_DBItemInSchema_To_Schema() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If boolDBItemInSchema_Exists = False Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBItemInSchema.GUID, GUID_DatabaseSchema, objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function
    Public Function save_004_DBItemInSchema_To_DBItem() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBItemInSchema.GUID, objSemItem_DBItem.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        Return objSemItem_Result
    End Function
    Public Function del_004_DBItemInSchema_To_DBItem() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If boolDBItem_Exists = False Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBItemInSchema.GUID, objSemItem_DBItem.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function
    Public Function save_005_CreationScript(ByVal dateChanged As Date) As clsSemItem
        Dim objDRC_CreationScript As DataRowCollection
        Dim objDRC_LogState As DataRowCollection


        Dim boolResult As Boolean

        objDRC_CreationScript = procA_CreationScript_Of_DBItem_By_GUIDDBItem.GetData(objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                     objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                                                     objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                                                     objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                                                                     objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                                                                     objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                                                     objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                                                     objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                     objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                     objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                     objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                     objSemItem_DBItem.GUID).Rows
        If objDRC_CreationScript.Count > 0 Then
            If objDRC_CreationScript(0).Item("DateTimeStamp") >= dateChanged Then
                objSemItem_CreationScript = New clsSemItem
                objSemItem_CreationScript.GUID = objDRC_CreationScript(0).Item("GUID_CreationScript")
                objSemItem_CreationScript.Name = objDRC_CreationScript(0).Item("Name_CreationScript")
                objSemItem_CreationScript.GUID_Parent = objLocalConfig.SemItem_Type_Creation_Scripts.GUID
                objSemItem_CreationScript.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_Result_CreationScript = objLocalConfig.Globals.LogState_Exists
            Else
                objSemItem_CreationScript = New clsSemItem
                objSemItem_CreationScript.GUID = Guid.NewGuid
                objSemItem_CreationScript.Name = objSemItem_DBItem.Name
                objSemItem_CreationScript.GUID_Parent = objLocalConfig.SemItem_Type_Creation_Scripts.GUID
                objSemItem_CreationScript.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_CreationScript.GUID, objSemItem_CreationScript.Name, objLocalConfig.SemItem_Type_Creation_Scripts.GUID, True).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    objSemItem_Result_CreationScript = objLocalConfig.Globals.LogState_Success
                Else
                    objSemItem_Result_CreationScript = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Else
            objSemItem_CreationScript = New clsSemItem
            objSemItem_CreationScript.GUID = Guid.NewGuid
            objSemItem_CreationScript.Name = objSemItem_DBItem.Name
            objSemItem_CreationScript.GUID_Parent = objLocalConfig.SemItem_Type_Creation_Scripts.GUID
            objSemItem_CreationScript.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_CreationScript.GUID, objSemItem_CreationScript.Name, objLocalConfig.SemItem_Type_Creation_Scripts.GUID, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then


                objSemItem_Result_CreationScript = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result_CreationScript = objLocalConfig.Globals.LogState_Error
            End If
        End If


        Return objSemItem_Result_CreationScript
    End Function
    Public Function del_005_CreationScript() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_CreationScript.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function save_006_CreationScript_To_DBSchema() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim boolResult As Boolean


        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_CreationScript.GUID, GUID_DatabaseSchema, objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        

        Return objSemItem_Result
    End Function
    Public Function del_006_CreationScript_To_DBSchema() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_CreationScript.GUID, GUID_DatabaseSchema, objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result

    End Function


    Public Function save_007_DBItem_To_CreationScript() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBItem.GUID, objSemItem_CreationScript.GUID, objLocalConfig.SemItem_RelationType_creation_template.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function del_007_DBItem_To_CreationScript() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBItem.GUID, objSemItem_CreationScript.GUID, objLocalConfig.SemItem_RelationType_creation_template.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function save_008_XMLTemplate(ByVal strDescription As String) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_XMLText As DataRowCollection
        Dim boolAdd_XML As Boolean

        Dim objSemItem_Result As clsSemItem

        boolAdd_XML = True
        If objSemItem_Result_CreationScript.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then

            objDRC_XMLText = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_CreationScript.GUID, _
                                                                           objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                           objLocalConfig.SemItem_Type_XML.GUID).Rows
            If objDRC_XMLText.Count > 0 Then
                boolAdd_XML = False
                objSemItem_XML = New clsSemItem
                objSemItem_XML.GUID = objDRC_XMLText(0).Item("GUID_Token_Right")
                objSemItem_XML.Name = objDRC_XMLText(0).Item("Name_Token_Right")
                objSemItem_XML.GUID_Parent = objLocalConfig.SemItem_Type_XML.GUID
                objSemItem_XML.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_XML.Additional1 = strDescription
                objSemItem_Result_CreationScript = objLocalConfig.Globals.LogState_Success
            End If

        End If
        If boolAdd_XML = True Then
            objSemItem_XML = New clsSemItem
            objSemItem_XML.GUID = Guid.NewGuid
            objSemItem_XML.Name = objSemItem_DBItem.Name
            objSemItem_XML.GUID_Parent = objLocalConfig.SemItem_Type_XML.GUID
            objSemItem_XML.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_XML.Additional1 = strDescription
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_XML.GUID, objSemItem_XML.Name, objLocalConfig.SemItem_Type_XML.GUID, True).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If
        

        Return objSemItem_Result
    End Function
    Public Function del_008_XMLTemplate() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_XML.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function save_009_XMLText() As clsSemItem
        Dim objDRC_Logstate As DataRowCollection
        Dim objDRC_XMLText As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        Dim boolAdd As Boolean

        boolAdd = True

        If objSemItem_Result_CreationScript.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then
            objDRC_XMLText = procA_TokenAttribute_VARCHARMAX.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_XML.GUID, objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
            If objDRC_XMLText.Count > 0 Then
                GUID_TokenAttribute_XMLText = objDRC_XMLText(0).Item("GUID_TokenAttribute")
                boolAdd = False
            End If
        End If
        If boolAdd = True Then
            objDRC_Logstate = semprocA_DBWork_Save_Token_Attribute_VARCHARMAX.GetData(objSemItem_XML.GUID, objLocalConfig.SemItem_Attribute_XML_Text.GUID, Nothing, objSemItem_XML.Additional1, 0).Rows
            If objDRC_Logstate(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                GUID_TokenAttribute_XMLText = objDRC_Logstate(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                GUID_TokenAttribute_XMLText = Nothing
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If


        Return objSemItem_Result
    End Function
    Public Function del_009_XMLText() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBwork_Del_Token_Attribute.GetData(GUID_TokenAttribute_XMLText).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function save_010_CreationScript_To_XMLTemplate() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_CreationScript.GUID, objSemItem_XML.GUID, objLocalConfig.SemItem_RelationType_creation_template.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function del_010_CreationScript_To_XMLTemplate() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_CreationScript.GUID, objSemItem_XML.GUID, objLocalConfig.SemItem_RelationType_creation_template.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function save_011_LogEntry_Creation(ByVal dateChanged As Date) As clsSemItem
        Dim objDRC_CreationDate As DataRowCollection
        Dim objSemItem_Result As clsSemItem
        date_LogEntry_Creation = dateChanged

        objDRC_CreationDate = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_CreationScript.GUID, objLocalConfig.SemItem_RelationType_was_created_at.GUID, objLocalConfig.SemItem_Type_LogEntry.GUID).Rows
        If objDRC_CreationDate.Count = 0 Then
            objSemItem_LogEntry_Creation = objLogManagement.log_Entry(date_LogEntry_Creation, objLocalConfig.SemItem_Token_LogState_Create.GUID, Nothing)
            If Not objSemItem_LogEntry_Creation Is Nothing Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_LogEntry_Creation = New clsSemItem
            objSemItem_LogEntry_Creation.GUID = objDRC_CreationDate(0).Item("GUID_token_Right")
            objSemItem_LogEntry_Creation.Name = objDRC_CreationDate(0).Item("Name_Token_Right")
            objSemItem_LogEntry_Creation.GUID_Parent = objLocalConfig.SemItem_Type_LogEntry.GUID
            objSemItem_LogEntry_Creation.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function del_011_LogEntry_Creation() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        objSemItem_Result = objLogManagement.del_LogEntry(objSemItem_LogEntry_Creation.GUID)
        Return objSemItem_Result
    End Function

    Public Function save_012_DBItemInSchema_To_LogEntry_Create() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DBItemInSchema.GUID, objSemItem_LogEntry_Creation.GUID, objLocalConfig.SemItem_RelationType_was_created_at.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function del_012_DBItemInSchema_To_LogEntry_Create() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DBItemInSchema.GUID, objSemItem_LogEntry_Creation.GUID, objLocalConfig.SemItem_RelationType_was_created_at.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    
    Public Function save_013_CreationScript_To_Logentry_Create() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_CreationScript.GUID, objSemItem_LogEntry_Creation.GUID, objLocalConfig.SemItem_RelationType_was_created_at.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result

    End Function

    Public Function del_013_CrationScript_To_Logentry_Change() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_CreationScript.GUID, objSemItem_LogEntry_Creation.GUID, objLocalConfig.SemItem_RelationType_was_created_at.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function
    Public Function save_014_Parameters(ByVal _strParameters() As String) As clsSemItem
        Dim objDRC_Parameter As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim GUID_Parameter As Guid
        Dim strParameter As String
        Dim intCountParameters As Integer
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success

        strParameters = _strParameters
        GUIDs_Parameter = Nothing
        For Each strParameter In strParameters
            If Not strParameter Is Nothing Then
                objDRC_Parameter = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_DB_Parameters.GUID, strParameter).Rows
                If objDRC_Parameter.Count = 0 Then
                    GUID_Parameter = Guid.NewGuid
                    objDRC_LogState = semprocA_DBWork_Save_Token.GetData(GUID_Parameter, strParameter, objLocalConfig.SemItem_Type_DB_Parameters.GUID, True).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                        If GUIDs_Parameter Is Nothing Then
                            intCountParameters = 0

                        Else
                            intCountParameters = GUIDs_Parameter.Length
                        End If
                        ReDim Preserve GUIDs_Parameter(intCountParameters)
                        GUIDs_Parameter(intCountParameters) = GUID_Parameter
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If


                Else
                    GUID_Parameter = objDRC_Parameter(0).Item("GUID_Token")
                    If GUIDs_Parameter Is Nothing Then
                        intCountParameters = 0

                    Else
                        intCountParameters = GUIDs_Parameter.Length
                    End If
                    ReDim Preserve GUIDs_Parameter(intCountParameters)
                    GUIDs_Parameter(intCountParameters) = GUID_Parameter
                End If
            End If

        Next
        Return objSemItem_Result
    End Function
    Public Function del_014_Parameters() As clsSemItem
        Dim GUID_Parameter As Guid
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success

        If Not GUIDs_Parameter Is Nothing Then
            For Each GUID_Parameter In GUIDs_Parameter
                objDRC_LogState = semprocA_DBWork_Del_Token.GetData(GUID_Parameter).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        End If

        Return objSemItem_Result
    End Function

    Public Function save_015_CreationScript_To_Parameters() As clsSemItem
        Dim GUID_Parameter As Guid
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success
        Dim intCount_Parameters As Integer = 0

        GUIDs_ParameterRel = Nothing
        If Not GUIDs_Parameter Is Nothing Then
            For Each GUID_Parameter In GUIDs_Parameter
                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_CreationScript.GUID, GUID_Parameter, objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    If GUIDs_ParameterRel Is Nothing Then
                        intCount_Parameters = 0
                    Else
                        intCount_Parameters = GUIDs_ParameterRel.Length
                    End If
                    ReDim Preserve GUIDs_ParameterRel(intCount_Parameters)
                    GUIDs_ParameterRel(intCount_Parameters) = GUID_Parameter
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If

            Next
        End If
        Return objSemItem_Result
    End Function

    Public Function del_015_CreationScript_To_Parameters() As clsSemItem
        Dim GUID_Parameter As Guid
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success

        If Not GUIDs_ParameterRel Is Nothing Then
            For Each GUID_Parameter In GUIDs_ParameterRel
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_CreationScript.GUID, GUID_Parameter, objLocalConfig.SemItem_RelationType_needs.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        End If
        Return objSemItem_Result
    End Function

    Public Function save_016_Save_DBSchema_To_Parameters() As clsSemItem
        Dim GUID_Parameter As Guid
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success
        Dim intCount_Parameters As Integer = 0

        GUIDs_ParameterRel_DBSchema = Nothing
        If Not GUIDs_Parameter Is Nothing Then
            For Each GUID_Parameter In GUIDs_Parameter
                If semtblA_Token_Token.Count_By_GUIDs(GUID_DatabaseSchema, GUID_Parameter, objLocalConfig.SemItem_RelationType_needs.GUID) = 0 Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(GUID_DatabaseSchema, GUID_Parameter, objLocalConfig.SemItem_RelationType_needs.GUID, 0).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        If GUIDs_ParameterRel_DBSchema Is Nothing Then
                            intCount_Parameters = 0
                        Else
                            intCount_Parameters = GUIDs_ParameterRel_DBSchema.Length
                        End If
                        ReDim Preserve GUIDs_ParameterRel_DBSchema(intCount_Parameters)
                        GUIDs_ParameterRel_DBSchema(intCount_Parameters) = GUID_Parameter
                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                End If
            Next
        End If
        Return objSemItem_Result
    End Function
    Public Function del_016_DBSchema_To_Parameters() As clsSemItem
        Dim GUID_Parameter As Guid
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success
        Dim objDRC_LogState As DataRowCollection

        If Not GUIDs_ParameterRel_DBSchema Is Nothing Then
            For Each GUID_Parameter In GUIDs_ParameterRel_DBSchema
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(GUID_DatabaseSchema, GUID_Parameter, objLocalConfig.SemItem_RelationType_needs.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        End If

        Return objSemItem_Result
    End Function

    Public Function save_017_DBItem_Exported() As clsSemItem
        Dim objDRC_Exported As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_Exported = procA_TokenAttribute_Bit.GetData_By_GUIDAttribute_And_GUIDToken(objSemItem_DBItem.GUID, objLocalConfig.SemItem_Attribute_is_exported.GUID).Rows
        If objDRC_Exported.Count > 0 Then
            objDRC_LogState = semprocA_DBWork_Save_Token_Attribute_Bit.GetData(objSemItem_DBItem.GUID, objLocalConfig.SemItem_Attribute_is_exported.GUID, objDRC_Exported(0).Item("GUID_TokenAttribute"), False, 0).Rows
        Else
            objDRC_LogState = semprocA_DBWork_Save_Token_Attribute_Bit.GetData(objSemItem_DBItem.GUID, objLocalConfig.SemItem_Attribute_is_exported.GUID, Nothing, False, 0).Rows
        End If
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function


    Public Function import_DBItem(ByVal objSemItem_DBItem As clsSemItem, ByVal objConnection_DB As SqlClient.SqlConnection) As Boolean

        Dim procT_TSQL_Functions As New ds_TemplateView.proc_TSQL_FunctionsDataTable
        Dim procT_TSQL_Procedures As New ds_TemplateView.proc_TSQL_ProceduresDataTable
        Dim procT_TSQL_Synonyms As New ds_TemplateView.proc_TSQL_SynonymsDataTable
        Dim procT_TSQL_Tables As New ds_TemplateView.proc_TSQL_TablesDataTable
        Dim procT_TSQL_Triggers As New ds_TemplateView.proc_TSQL_TriggersDataTable
        Dim procT_TSQL_Views As New ds_TemplateView.proc_TSQL_ViewsDataTable

        Dim objDRs_DBItem() As DataRow
        Dim date_Creation As Date
        Dim date_Change As Date
        Dim objSemItem_Result_CreationScript As clsSemItem

        Dim boolXML As Boolean
        Dim boolParameters As Boolean
        Dim strDefinition As String
        Dim strXML_DBItem As String
        Dim boolResult As Boolean = False
        Dim boolWeiter As Boolean
        Dim boolNoScript As Boolean


        procA_TSQL_Functions.Connection = objConnection_DB
        procA_TSQL_procedures.Connection = objConnection_DB
        procA_TSQL_synonyms.Connection = objConnection_DB
        procA_TSQL_Tables.Connection = objConnection_DB
        procA_TSQL_triggers.Connection = objConnection_DB
        procA_TSQL_views.Connection = objConnection_DB

        Select Case objSemItem_DBItem.GUID_Parent
            Case objLocalConfig.SemItem_Type_DB_Function.GUID
                boolXML = True
                boolParameters = True

                procA_TSQL_Functions.Fill(procT_TSQL_Functions)

                objDRs_DBItem = procT_TSQL_Functions.Select("ROUTINE_NAME='" & objSemItem_DBItem.Name & "'")
                date_Creation = objDRs_DBItem(0).Item("CREATED")
                date_Change = objDRs_DBItem(0).Item("LAST_ALTERED")
            Case objLocalConfig.SemItem_Type_DB_Procedure.GUID
                boolXML = True
                boolParameters = True

                procA_TSQL_procedures.Fill(procT_TSQL_Procedures)

                objDRs_DBItem = procT_TSQL_Procedures.Select("name='" & objSemItem_DBItem.Name & "'")
                date_Creation = objDRs_DBItem(0).Item("create_date")
                date_Change = objDRs_DBItem(0).Item("modify_date")
            Case objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                boolXML = True
                boolParameters = False

                procA_TSQL_synonyms.Fill(procT_TSQL_Synonyms)

                objDRs_DBItem = procT_TSQL_Synonyms.Select("name='" & objSemItem_DBItem.Name & "'")
                date_Creation = objDRs_DBItem(0).Item("create_date")
                date_Change = objDRs_DBItem(0).Item("modify_date")
            Case objLocalConfig.SemItem_Type_DB_Tables.GUID
                boolXML = True
                boolParameters = False

                procA_TSQL_Tables.Fill(procT_TSQL_Tables)

                objDRs_DBItem = procT_TSQL_Tables.Select("name='" & objSemItem_DBItem.Name & "'")
                date_Creation = objDRs_DBItem(0).Item("create_date")
                date_Change = objDRs_DBItem(0).Item("modify_date")
            Case objLocalConfig.SemItem_Type_DB_Triggers.GUID
                boolXML = True
                boolParameters = False

                procA_TSQL_triggers.Fill(procT_TSQL_Triggers)

                objDRs_DBItem = procT_TSQL_Triggers.Select("name='" & objSemItem_DBItem.Name & "'")
                date_Creation = objDRs_DBItem(0).Item("create_date")
                date_Change = objDRs_DBItem(0).Item("modify_date")
            Case objLocalConfig.SemItem_Type_DB_Views.GUID
                boolXML = True
                boolParameters = False

                procA_TSQL_views.Fill(procT_TSQL_Views)

                objDRs_DBItem = procT_TSQL_Views.Select("name='" & objSemItem_DBItem.Name & "'")
                date_Creation = objDRs_DBItem(0).Item("create_date")
                date_Change = objDRs_DBItem(0).Item("modify_date")
        End Select

        strDefinition = get_DBItem_Definition(objSemItem_DBItem, objConnection_DB)

        If save_001_DBItem(objSemItem_DBItem).GUID = objLocalConfig.Globals.LogState_Success.GUID Then

            If save_002_DBItem_In_Schema().GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                If save_003_DBItemInSchema_To_Schema().GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    If save_004_DBItemInSchema_To_DBItem().GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        boolWeiter = True

                        If Not strDefinition Is Nothing Then
                            boolXML = True
                            objSemItem_Result_CreationScript = save_005_CreationScript(date_Change)

                            If objSemItem_Result_CreationScript.GUID = objLocalConfig.Globals.LogState_Success.GUID Or _
                                objSemItem_Result_CreationScript.GUID = objLocalConfig.Globals.LogState_Exists.GUID Then

                                If save_006_CreationScript_To_DBSchema().GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                    If save_007_DBItem_To_CreationScript().GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        strXML_DBItem = strXML.Replace("@Script@", strDefinition)
                                        
                                        If save_008_XMLTemplate(strXML_DBItem).GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            If save_009_XMLText().GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                                If save_010_CreationScript_To_XMLTemplate().GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                                    del_009_XMLText()
                                                    del_008_XMLTemplate()
                                                    del_007_DBItem_To_CreationScript()
                                                    del_006_CreationScript_To_DBSchema()
                                                    del_005_CreationScript()
                                                    del_004_DBItemInSchema_To_DBItem()
                                                    del_003_DBItemInSchema_To_Schema()
                                                    del_002_DBItemInSchema()
                                                    del_001_DBItem()
                                                    boolWeiter = False
                                                End If
                                            Else
                                                del_008_XMLTemplate()
                                                del_007_DBItem_To_CreationScript()
                                                del_006_CreationScript_To_DBSchema()
                                                del_005_CreationScript()
                                                del_004_DBItemInSchema_To_DBItem()
                                                del_003_DBItemInSchema_To_Schema()
                                                del_002_DBItemInSchema()
                                                del_001_DBItem()
                                                boolWeiter = False

                                            End If
                                        Else

                                            del_004_DBItemInSchema_To_DBItem()
                                            del_003_DBItemInSchema_To_Schema()
                                            del_002_DBItemInSchema()
                                            del_001_DBItem()
                                            boolWeiter = False
                                        End If
                                    Else

                                        del_007_DBItem_To_CreationScript()
                                        del_006_CreationScript_To_DBSchema()
                                        del_005_CreationScript()
                                        del_004_DBItemInSchema_To_DBItem()
                                        del_003_DBItemInSchema_To_Schema()
                                        del_002_DBItemInSchema()
                                        del_001_DBItem()
                                    End If

                                Else
                                    del_005_CreationScript()
                                    del_004_DBItemInSchema_To_DBItem()
                                    del_003_DBItemInSchema_To_Schema()
                                    del_002_DBItemInSchema()
                                    del_001_DBItem()
                                End If

                            Else

                                del_004_DBItemInSchema_To_DBItem()
                                del_003_DBItemInSchema_To_Schema()
                                del_002_DBItemInSchema()
                                del_001_DBItem()

                            End If

                        Else
                            boolNoScript = True
                            boolWeiter = False
                        End If
                        If boolWeiter = True Then


                            If save_011_LogEntry_Creation(date_Change).GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                                If save_012_DBItemInSchema_To_LogEntry_Create().GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    If Not strDefinition Is Nothing Then

                                        If save_013_CreationScript_To_Logentry_Create().GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            get_DBItem_Parameters(objSemItem_DBItem, objConnection_DB)

                                            If Not strParameters Is Nothing Then


                                                If save_014_Parameters(strParameters).GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    If save_015_CreationScript_To_Parameters().GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        If save_016_Save_DBSchema_To_Parameters().GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            boolResult = True
                                                        Else
                                                            del_015_CreationScript_To_Parameters()
                                                            del_014_Parameters()
                                                            del_013_CrationScript_To_Logentry_Change()
                                                            del_012_DBItemInSchema_To_LogEntry_Create()
                                                            del_011_LogEntry_Creation()
                                                            If boolXML = True Then
                                                                del_010_CreationScript_To_XMLTemplate()
                                                                del_009_XMLText()
                                                                del_008_XMLTemplate()
                                                                del_007_DBItem_To_CreationScript()
                                                                del_006_CreationScript_To_DBSchema()
                                                                del_005_CreationScript()

                                                            End If

                                                            del_004_DBItemInSchema_To_DBItem()
                                                            del_003_DBItemInSchema_To_Schema()
                                                            del_002_DBItemInSchema()
                                                            del_001_DBItem()
                                                        End If
                                                    Else


                                                        del_014_Parameters()
                                                        del_013_CrationScript_To_Logentry_Change()
                                                        del_012_DBItemInSchema_To_LogEntry_Create()
                                                        del_011_LogEntry_Creation()
                                                        If boolXML = True Then
                                                            del_010_CreationScript_To_XMLTemplate()
                                                            del_009_XMLText()
                                                            del_008_XMLTemplate()

                                                            del_007_DBItem_To_CreationScript()
                                                            del_006_CreationScript_To_DBSchema()
                                                            del_005_CreationScript()

                                                        End If
                                                        del_004_DBItemInSchema_To_DBItem()
                                                        del_003_DBItemInSchema_To_Schema()
                                                        del_002_DBItemInSchema()
                                                        del_001_DBItem()
                                                    End If
                                                Else

                                                    del_013_CrationScript_To_Logentry_Change()

                                                    del_012_DBItemInSchema_To_LogEntry_Create()
                                                    del_011_LogEntry_Creation()
                                                    If boolXML = True Then
                                                        del_010_CreationScript_To_XMLTemplate()
                                                        del_009_XMLText()
                                                        del_008_XMLTemplate()
                                                        del_007_DBItem_To_CreationScript()
                                                        del_006_CreationScript_To_DBSchema()
                                                        del_005_CreationScript()

                                                    End If
                                                    del_004_DBItemInSchema_To_DBItem()
                                                    del_003_DBItemInSchema_To_Schema()
                                                    del_002_DBItemInSchema()
                                                    del_001_DBItem()
                                                End If
                                            Else
                                                save_017_DBItem_Exported()
                                                boolResult = True
                                            End If
                                        Else

                                            del_012_DBItemInSchema_To_LogEntry_Create()
                                            del_011_LogEntry_Creation()
                                            If boolXML = True Then
                                                del_010_CreationScript_To_XMLTemplate()
                                                del_009_XMLText()
                                                del_008_XMLTemplate()
                                                del_007_DBItem_To_CreationScript()

                                                del_006_CreationScript_To_DBSchema()
                                                del_005_CreationScript()

                                            End If
                                            del_004_DBItemInSchema_To_DBItem()
                                            del_003_DBItemInSchema_To_Schema()
                                            del_002_DBItemInSchema()
                                            del_001_DBItem()
                                        End If


                                    Else
                                        boolResult = True
                                    End If

                                    'GUIDs_Parameter = Nothing
                                    'GUIDs_ParameterRel_CreationScript = Nothing


                                Else

                                    del_011_LogEntry_Creation()
                                    If boolXML = True Then
                                        del_010_CreationScript_To_XMLTemplate()
                                        del_009_XMLText()
                                        del_008_XMLTemplate()
                                        del_007_DBItem_To_CreationScript()
                                        del_006_CreationScript_To_DBSchema()
                                        del_005_CreationScript()

                                    End If
                                    del_004_DBItemInSchema_To_DBItem()
                                    del_003_DBItemInSchema_To_Schema()
                                    del_002_DBItemInSchema()
                                    del_001_DBItem()
                                End If
                            Else
                                If boolXML = True Then
                                    del_010_CreationScript_To_XMLTemplate()
                                    del_009_XMLText()
                                    del_008_XMLTemplate()
                                    del_007_DBItem_To_CreationScript()
                                    del_006_CreationScript_To_DBSchema()
                                    del_005_CreationScript()

                                End If
                                del_004_DBItemInSchema_To_DBItem()
                                del_003_DBItemInSchema_To_Schema()
                                del_002_DBItemInSchema()
                                del_001_DBItem()
                            End If
                        Else
                            If boolNoScript = False Then
                                del_003_DBItemInSchema_To_Schema()
                                del_002_DBItemInSchema()
                                del_001_DBItem()
                            Else
                                boolResult = True
                            End If
                            

                        End If

                    End If
                Else

                    del_002_DBItemInSchema()
                    del_001_DBItem()
                End If
            Else

                del_001_DBItem()
            End If


        Else

        End If

        Return boolResult


    End Function

    Private Sub get_DBItem_Parameters(ByVal objSemItem_DBItem As clsSemItem, ByVal objConnectionDB As SqlClient.SqlConnection)
        Dim objDRC_Parameters As DataRowCollection

        Dim intParCount As Integer

        strParameters = Nothing

        procA_TSQL_PARAMETERS.Connection = objConnectionDB
        objDRC_Parameters = procA_TSQL_PARAMETERS.GetData(objSemItem_DBItem.Name).Rows
        For Each objDR_Parameters In objDRC_Parameters
            If strParameters Is Nothing Then
                intParCount = 0

            Else
                intParCount = strParameters.Length

            End If
            ReDim Preserve strParameters(intParCount)
            strParameters(intParCount) = objDR_Parameters.Item("PARAMETER_NAME")
        Next

    End Sub

    Private Function get_DBItem_Definition(ByVal objSemItem_DBItem As clsSemItem, ByVal objConnection_DB As SqlClient.SqlConnection) As String
        Dim objDRC_ObjectDefinition As DataRowCollection
        Dim objDR_ObjectDefinition As DataRow
        Dim strDefinition As String = Nothing
        Dim strParameters() As String

        procA_TSQL_ObjectReference.Connection = objConnection_DB
        Select Case objSemItem_DBItem.GUID_Parent
            Case objLocalConfig.SemItem_Type_DB_Function.GUID, objLocalConfig.SemItem_Type_DB_Procedure.GUID, objLocalConfig.SemItem_Type_DB_Triggers.GUID, objLocalConfig.SemItem_Type_DB_Views.GUID
                objDRC_ObjectDefinition = procA_TSQL_ObjectReference.GetData(objSemItem_DBItem.Name).Rows
                strDefinition = ""
                For Each objDR_ObjectDefinition In objDRC_ObjectDefinition
                    If Not strDefinition = "" Then
                        strDefinition = strDefinition & vbCrLf
                    End If
                    strDefinition = strDefinition & objDR_ObjectDefinition.Item("text")

                Next


        End Select

        Return strDefinition
    End Function

    Public Sub New(ByVal _GUID_DatabaseSchema As Guid)
        set_DBConnection()
        GUID_DatabaseSchema = _GUID_DatabaseSchema

    End Sub
End Class
