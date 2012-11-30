Imports Sem_Manager
Imports Wiki_Manager
Imports Log_Manager

Public Class UserControl_WikiImplementation

    Private procA_CreationScript_Of_DBSchema_GUID_DBSchema_Ordered As New ds_SchemaManagerTableAdapters.proc_CreationScript_Of_DBSchema_GUID_DBSchema_OrderedTableAdapter
    Private procA_LocalizedDescription_By_GUIDDBItem_And_GUID_Language As New ds_LocalizeTableAdapters.proc_LocalizedDescription_By_GUIDDBItem_And_GUID_LanguageTableAdapter
    Private procA_CreationScripts_Of_DBSchema_By_GUIDDbSchema As New ds_SchemaManagerTableAdapters.proc_CreationScripts_Of_DBSchema_By_GUIDDbSchemaTableAdapter
    Private procT_CreationScripts_Of_DBSchema_By_GUIDDbSchema As New ds_SchemaManager.proc_CreationScripts_Of_DBSchema_By_GUIDDbSchemaDataTable
    Private procA_Language_By_GUIDDBSchema As New ds_LocalizeTableAdapters.proc_Language_By_GUIDDBSchemaTableAdapter
    Private procA_TokenAttribute_VarcharMAX As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter
    Private procA_TokenAttribute_Bit As New ds_TokenAttributeTableAdapters.TokenAttribute_BitTableAdapter

    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_Token_Or As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private funcT_WikiDocuments As New ds_Token.func_TokenTokenDataTable

    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter

    Private objSemItem_WikiDocumentation As clsSemItem
    Private objSemItem_WikiImplementation As clsSemItem
    Private WithEvents objUserControl_ImplementationList As New UserControl_SemItemList

    Private objWIKI As clsWIKI

    Private objLogManagement As clsLogManagement

    Private objSemItem_Url As clsSemItem


    Private Sub SelectionChanged_ImplementationList() Handles objUserControl_ImplementationList.Selection_Changed
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objDRC_Url As DataRowCollection
        If objUserControl_ImplementationList.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_ImplementationList.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_WikiImplementation = New clsSemItem
            objSemItem_WikiImplementation.GUID = objDRV_Selected.Item("GUID_Token_Right")
            objSemItem_WikiImplementation.Name = objDRV_Selected.Item("Name_Token_Right")
            objSemItem_WikiImplementation.GUID_Parent = objLocalConfig.SemItem_Type_WIKI_Implementation.GUID
            objSemItem_WikiImplementation.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            fill_DocView()

            objDRC_Url = funcA_Token_Token.GetData_TokenToken_LeftRight(objDRV_Selected.Item("GUID_Token_Right"), objLocalConfig.SemItem_RelationType_implemented_on.GUID, objLocalConfig.SemItem_Type_Url.GUID).Rows
            If objDRC_Url.Count > 0 Then
                objSemItem_Url = New clsSemItem
                objSemItem_Url.GUID = objDRC_Url(0).Item("GUID_Token_Right")
                objSemItem_Url.Name = objDRC_Url(0).Item("Name_Token_Right")
                objSemItem_Url.GUID_Parent = objDRC_Url(0).Item("GUID_Type_Right")
                objSemItem_Url.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                TextBox_Url.Text = objSemItem_Url.Name

                ToolStripSplitButton_Export.Enabled = True
                ExportXMLToolStripMenuItem.Enabled = True
                DirectToolStripMenuItem.Enabled = True
            Else
                ToolStripSplitButton_Export.Enabled = False
                ExportXMLToolStripMenuItem.Enabled = False
                DirectToolStripMenuItem.Enabled = False
                funcT_WikiDocuments.Clear()
                objSemItem_Url = Nothing
                TextBox_Url.Text = Nothing
            End If
        Else
            clear_Detail()
        End If
    End Sub
    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
       

        objUserControl_ImplementationList.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Add(objUserControl_ImplementationList)

        set_DBConnection()
    End Sub
    Private Sub fill_DocView()

        funcA_Token_Token.Fill_TokenToken_LeftRight(funcT_WikiDocuments, objSemItem_WikiImplementation.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, objLocalConfig.SemItem_Type_Wiki_Document.GUID)
        BindingSource_Wikidocs.DataSource = funcT_WikiDocuments
        DataGridView_Documents.DataSource = BindingSource_Wikidocs
        DataGridView_Documents.Columns(0).Visible = False
        DataGridView_Documents.Columns(1).Visible = False
        DataGridView_Documents.Columns(2).Visible = False
        DataGridView_Documents.Columns(3).Visible = False
        DataGridView_Documents.Columns(4).Width = 300
        DataGridView_Documents.Columns(5).Visible = False
        DataGridView_Documents.Columns(6).Visible = False
        DataGridView_Documents.Columns(7).Visible = False
        DataGridView_Documents.Columns(8).Visible = False
        DataGridView_Documents.Columns(9).Visible = False
    End Sub
    Private Sub set_DBConnection()
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB
        procA_CreationScript_Of_DBSchema_GUID_DBSchema_Ordered.Connection = objLocalConfig.Connection_Plugin
        funcA_Token_Or.Connection = objLocalConfig.Connection_DB
        procA_LocalizedDescription_By_GUIDDBItem_And_GUID_Language.Connection = objLocalConfig.Connection_Plugin
        procA_CreationScripts_Of_DBSchema_By_GUIDDbSchema.Connection = objLocalConfig.Connection_Plugin
        procA_Language_By_GUIDDBSchema.Connection = objLocalConfig.Connection_Plugin
        procA_TokenAttribute_VarcharMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        procA_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB

        objWIKI = New clsWIKI()
        objLogManagement = New clsLogManagement(objLocalConfig.Globals)
    End Sub

    Private Sub clear_Detail()
        TextBox_Url.Text = ""
        DataGridView_Documents.DataSource = Nothing
    End Sub
    Public Sub initialize(Optional ByVal SemItem_WikiDocumentation As clsSemItem = Nothing)


        If Not SemItem_WikiDocumentation Is Nothing Then
            objSemItem_WikiDocumentation = SemItem_WikiDocumentation
            objSemItem_WikiDocumentation.GUID_Related = objLocalConfig.SemItem_Type_WIKI_Implementation.GUID
            objSemItem_WikiDocumentation.Direction = objSemItem_WikiDocumentation.Direction_LeftRight
            objSemItem_WikiDocumentation.GUID_Relation = objLocalConfig.SemItem_RelationType_belongsTo.GUID
            get_Implementations()
        Else
            clear_Implementations()
        End If

    End Sub

    Private Sub clear_Implementations()
        objUserControl_ImplementationList.clear_List()
        clear_Detail()
    End Sub
    Private Sub get_Implementations()
        objUserControl_ImplementationList.initialize_Complex(objSemItem_WikiDocumentation, objLocalConfig.Globals)
    End Sub

  
    Private Sub ExportXMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportXMLToolStripMenuItem.Click
        Dim intCount_Not_inserted As Integer
        Dim strUrl_WIKI As String
        Dim strPath_XML As String

        create_WIKIDocs(objSemItem_WikiImplementation)
        intCount_Not_inserted = objWIKI.create_WIKIText_Of_WIKIDoc(objSemItem_WikiImplementation)
        If Not intCount_Not_inserted = 0 Then
            MsgBox(intCount_Not_inserted & " Dokumente konnten nicht vertextet werden!", MsgBoxStyle.Exclamation)
        End If
        strUrl_WIKI = TextBox_Url.Text
        strPath_XML = objWIKI.export_XML_For_Import(objSemItem_WikiImplementation, strUrl_WIKI)
        If strPath_XML = "" Then
            MsgBox("XML konnte nicht exportiert werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub

   

    
    Private Sub DirectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectToolStripMenuItem.Click

    End Sub

    Private Function create_WIKIDocs(ByVal objSemItem_WikiImplementation As clsSemItem) As Boolean

        Dim procT_CreationScript_Of_DBSchema_GUID_DBSchema_Ordered As New ds_SchemaManager.proc_CreationScript_Of_DBSchema_GUID_DBSchema_OrderedDataTable
        Dim objDRC_Schema As DataRowCollection
        Dim objDR_DBItem As DataRow
        Dim objDRC_Language As DataRowCollection
        Dim objDR_Language As DataRow
        Dim objDRC_Description As DataRowCollection
        Dim objDRC_Needed_DBItems As DataRowCollection
        Dim objDR_Needed_DBItem As DataRow
        Dim objDRC_Needed_SemItems As DataRowCollection
        Dim objDR_Needed_SemItems As DataRow
        Dim objDRs_XMLText() As DataRow
        Dim objDR_Language_For_Pages As DataRow
        Dim objDataTable_LanguagePages As New ds_WikiManagement.DataTable_LanguagePagesDataTable
        Dim objDataTable_BaseData As New ds_WIKI.DataTable_BaseDataDataTable
        Dim objDRC_Exported As DataRowCollection
        Dim objSemItem_LanguageLbl As New clsSemItem
        Dim boolResult As Boolean = True
        Dim objSemItem_DBItem As New clsSemItem
        Dim objSemItem_WIKIDoc As clsSemItem
        Dim objSemItem_LogEntry As clsSemItem
        Dim strBaseData As String
        Dim strName As String
        Dim strChangeDate As String
        Dim strDBItem_Type As String
        Dim strType As String
        Dim strDescription As String
        Dim strDescription_val As String
        Dim strDependencies As String
        Dim strDependencies_Forward As String
        Dim strDependencies_Backward As String
        Dim GUID_TokenAttribute_Exported As Guid
        Dim GUID_Token_Language_First As Guid
        Dim strSkript As String
        Dim strLink As String
        Dim strLink_To_Doc As String
        Dim strSQL As String
        Dim boolFirst As Boolean
        Dim boolExport As Boolean

        Dim date_Creation As Date


        objDRC_Schema = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_WikiDocumentation.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, objLocalConfig.SemItem_Type_Database_Schema.GUID).Rows
        If objDRC_Schema.Count > 0 Then
            procA_CreationScripts_Of_DBSchema_By_GUIDDbSchema.Fill(procT_CreationScripts_Of_DBSchema_By_GUIDDbSchema, _
                                                                   objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                                                   objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                   objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                                   objLocalConfig.SemItem_Type_XML.GUID, _
                                                                   objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                                   objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                                   objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                                                   objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                                                   objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                                   objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                   objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                   objDRC_Schema(0).Item("GUID_Token_Right"))


            'objDRC_Language = funcA_Token_Token.GetData_TokenToken_LeftRight(objDRC_Schema(0).Item("GUID_Token_Right"), objLocalConfig.SemItem_RelationType_isDescribedBy.GUID, objLocalConfig.SemItem_Type_Language.GUID).Rows
            objDRC_Language = procA_Language_By_GUIDDBSchema.GetData(objLocalConfig.SemItem_Attribute_Short.GUID, _
                                                                     objLocalConfig.SemItem_Type_Language.GUID, _
                                                                     objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_isDescribedBy.GUID, _
                                                                     objDRC_Schema(0).Item("GUID_Token_Right")).Rows


            procA_CreationScript_Of_DBSchema_GUID_DBSchema_Ordered.Fill(procT_CreationScript_Of_DBSchema_GUID_DBSchema_Ordered, _
                                                                                            objLocalConfig.SemItem_Attribute_DateTimeStamp.GUID, _
                                                                                            objLocalConfig.SemItem_Type_Creation_Scripts.GUID, _
                                                                                            objLocalConfig.SemItem_Type_LogEntry.GUID, _
                                                                                            objLocalConfig.SemItem_Type_Database_Schema.GUID, _
                                                                                            objLocalConfig.SemItem_Type_DB_Function.GUID, _
                                                                                            objLocalConfig.SemItem_Type_DB_Procedure.GUID, _
                                                                                            objLocalConfig.SemItem_Type_DB_Synonyms.GUID, _
                                                                                            objLocalConfig.SemItem_Type_DB_Tables.GUID, _
                                                                                            objLocalConfig.SemItem_Type_DB_Triggers.GUID, _
                                                                                            objLocalConfig.SemItem_Type_DB_Views.GUID, _
                                                                                            objLocalConfig.SemItem_RelationType_was_created_at.GUID, _
                                                                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                            objLocalConfig.SemItem_RelationType_creation_template.GUID, _
                                                                                            objLocalConfig.SemItem_Type_Functions_in_Schema.GUID, _
                                                                                            objLocalConfig.SemItem_Type_Procedures_in_Schemas.GUID, _
                                                                                            objLocalConfig.SemItem_Type_Synonyms_in_Schemas.GUID, _
                                                                                            objLocalConfig.SemItem_Type_Tables_in_Schema.GUID, _
                                                                                            objLocalConfig.SemItem_Type_Triggers_in_Schema.GUID, _
                                                                                            objLocalConfig.SemItem_Type_Views_in_Schema.GUID, _
                                                                                            objDRC_Schema(0).Item("GUID_Token_Right"))
            GUID_Token_Language_First = objDRC_Language(0).Item("GUID_Language")
            For Each objDR_DBItem In procT_CreationScript_Of_DBSchema_GUID_DBSchema_Ordered.Rows
                objDRC_Exported = procA_TokenAttribute_Bit.GetData_By_GUIDAttribute_And_GUIDToken(objDR_DBItem.Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID).Rows
                If objDRC_Exported.Count = 0 Then
                    GUID_TokenAttribute_Exported = Nothing
                    boolExport = True
                Else
                    GUID_TokenAttribute_Exported = objDRC_Exported(0).Item("GUID_TokenAttribute")
                    If objDRC_Exported(0).Item("Val") = False Then

                        boolExport = True
                    Else
                        If AllToolStripMenuItem.Enabled = True Then
                            boolExport = True
                        Else
                            boolExport = False
                        End If

                    End If
                End If

                If boolExport = True Then
                    boolFirst = True
                    For Each objDR_Language In objDRC_Language

                        objSemItem_DBItem.GUID = objDR_DBItem.Item("GUID_DBItem")
                        If GUID_Token_Language_First = objDR_Language.Item("GUID_Language") Then
                            objSemItem_DBItem.Name = objDR_DBItem.Item("Name_DBItem")
                        Else
                            objSemItem_DBItem.Name = objDR_DBItem.Item("Name_DBItem") & "/" & objDR_Language.Item("Short")
                        End If

                        objSemItem_DBItem.GUID_Parent = objDR_DBItem.Item("GUID_Type_DBItem")
                        objSemItem_DBItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        Select Case objSemItem_DBItem.GUID_Parent
                            Case objLocalConfig.SemItem_Type_DB_Function.GUID
                                strType = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_Funktionen.GUID, objDR_Language.Item("GUID_Language"))

                            Case objLocalConfig.SemItem_Type_DB_Procedure.GUID
                                strType = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_Prozeduren.GUID, objDR_Language.Item("GUID_Language"))
                            Case objLocalConfig.SemItem_Type_DB_Synonyms.GUID
                                strType = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_Synonyme.GUID, objDR_Language.Item("GUID_Language"))
                            Case objLocalConfig.SemItem_Type_DB_Tables.GUID
                                strType = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_Tabellen.GUID, objDR_Language.Item("GUID_Language"))
                            Case objLocalConfig.SemItem_Type_DB_Triggers.GUID
                                strType = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_Trigger.GUID, objDR_Language.Item("GUID_Language"))
                            Case objLocalConfig.SemItem_Type_DB_Views.GUID
                                strType = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_Abfragen.GUID, objDR_Language.Item("GUID_Language"))
                        End Select
                        date_Creation = objDR_DBItem.Item("DateTimeStamp")
                        objSemItem_WIKIDoc = objWIKI.get_WIKIDocument(objSemItem_DBItem.Name, objSemItem_WikiImplementation, False)
                        strBaseData = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_Basisdaten.GUID, objDR_Language.Item("GUID_Language"))
                        objWIKI.add_heading(objSemItem_WIKIDoc, strBaseData, 1)
                        strName = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_DBItem_Name.GUID, objDR_Language.Item("GUID_Language"))
                        strChangeDate = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_DBItem_ChangeDate.GUID, objDR_Language.Item("GUID_Language"))
                        strDBItem_Type = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_DBItem_Type.GUID, objDR_Language.Item("GUID_Language"))

                        objDataTable_BaseData.Clear()
                        objDataTable_BaseData.Rows.Add(strName, strDBItem_Type, strChangeDate)
                        objDataTable_BaseData.Rows.Add(objDR_DBItem.Item("Name_DBItem"), strType, date_Creation.ToString)
                        objWIKI.add_Table(objSemItem_WIKIDoc, objDataTable_BaseData.Rows, 3, True)

                        strDescription = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_Beschreibung.GUID, objDR_Language.Item("GUID_Language"))
                        objWIKI.add_heading(objSemItem_WIKIDoc, strDescription, 1)
                        objDRC_Description = procA_LocalizedDescription_By_GUIDDBItem_And_GUID_Language.GetData(objLocalConfig.SemItem_Attribute_Message.GUID, _
                                                                                                                objLocalConfig.SemItem_Type_Language.GUID, _
                                                                                                                objLocalConfig.SemItem_type_LocalizedDescription.GUID, _
                                                                                                                objLocalConfig.SemItem_RelationType_describes.GUID, _
                                                                                                                objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                                                                                objDR_DBItem.Item("GUID_DBItem"), _
                                                                                                                objDR_Language.Item("GUID_Language")).Rows
                        If objDRC_Description.Count > 0 Then
                            strDescription_val = objDRC_Description(0).Item("Message")
                            objWIKI.add_Markuped_Text(objSemItem_WIKIDoc, strDescription_val)
                        End If
                        strDependencies = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_Abh_ngigkeiten.GUID, objDR_Language.Item("GUID_Language"))
                        objWIKI.add_heading(objSemItem_WIKIDoc, strDependencies, 1)
                        strDependencies_Forward = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_F_r_das_Datenbankobjekt_notwendig.GUID, objDR_Language.Item("GUID_Language"))
                        objWIKI.add_heading(objSemItem_WIKIDoc, strDependencies_Forward, 2)
                        objDRC_Needed_DBItems = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_DBItem.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Function.GUID).Rows
                        strLink_To_Doc = ""
                        For Each objDR_Needed_DBItem In objDRC_Needed_DBItems
                            If objDR_Language.Item("GUID_Language") = GUID_Token_Language_First Then
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right"))
                            Else
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right") & "/" & objDR_Language.Item("Short") & "|" & objDRC_Needed_DBItems(0).Item("Name_Token_Right"))
                            End If


                            If strLink_To_Doc = "" Then
                                strLink_To_Doc = strLink_To_Doc & strLink
                            Else
                                strLink_To_Doc = strLink_To_Doc & ", " & strLink
                            End If

                        Next

                        objDRC_Needed_DBItems = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_DBItem.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Procedure.GUID).Rows
                        For Each objDR_Needed_DBItem In objDRC_Needed_DBItems
                            If objDR_Language.Item("GUID_Language") = GUID_Token_Language_First Then
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right"))
                            Else
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right") & "/" & objDR_Language.Item("Short") & "|" & objDRC_Needed_DBItems(0).Item("Name_Token_Right"))
                            End If
                            If strLink_To_Doc = "" Then
                                strLink_To_Doc = strLink_To_Doc & strLink
                            Else
                                strLink_To_Doc = strLink_To_Doc & ", " & strLink
                            End If
                        Next

                        objDRC_Needed_DBItems = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_DBItem.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Synonyms.GUID).Rows
                        For Each objDR_Needed_DBItem In objDRC_Needed_DBItems
                            If objDR_Language.Item("GUID_Language") = GUID_Token_Language_First Then
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right"))
                            Else
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right") & "/" & objDR_Language.Item("Short") & "|" & objDRC_Needed_DBItems(0).Item("Name_Token_Right"))
                            End If
                            If strLink_To_Doc = "" Then
                                strLink_To_Doc = strLink_To_Doc & strLink
                            Else
                                strLink_To_Doc = strLink_To_Doc & ", " & strLink
                            End If
                        Next

                        objDRC_Needed_DBItems = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_DBItem.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Tables.GUID).Rows
                        For Each objDR_Needed_DBItem In objDRC_Needed_DBItems
                            If objDR_Language.Item("GUID_Language") = GUID_Token_Language_First Then
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right"))
                            Else
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right") & "/" & objDR_Language.Item("Short") & "|" & objDRC_Needed_DBItems(0).Item("Name_Token_Right"))
                            End If
                            If strLink_To_Doc = "" Then
                                strLink_To_Doc = strLink_To_Doc & strLink
                            Else
                                strLink_To_Doc = strLink_To_Doc & ", " & strLink
                            End If


                        Next
                        objDRC_Needed_DBItems = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_DBItem.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Tables.GUID).Rows
                        For Each objDR_Needed_DBItem In objDRC_Needed_DBItems
                            If objDR_Language.Item("GUID_Language") = GUID_Token_Language_First Then
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right"))
                            Else
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right") & "/" & objDR_Language.Item("Short") & "|" & objDRC_Needed_DBItems(0).Item("Name_Token_Right"))
                            End If
                            If strLink_To_Doc = "" Then
                                strLink_To_Doc = strLink_To_Doc & strLink
                            Else
                                strLink_To_Doc = strLink_To_Doc & ", " & strLink
                            End If
                        Next

                        objDRC_Needed_DBItems = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_DBItem.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Triggers.GUID).Rows
                        For Each objDR_Needed_DBItem In objDRC_Needed_DBItems
                            If objDR_Language.Item("GUID_Language") = GUID_Token_Language_First Then
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right"))
                            Else
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right") & "/" & objDR_Language.Item("Short") & "|" & objDRC_Needed_DBItems(0).Item("Name_Token_Right"))
                            End If
                            If strLink_To_Doc = "" Then
                                strLink_To_Doc = strLink_To_Doc & strLink
                            Else
                                strLink_To_Doc = strLink_To_Doc & ", " & strLink
                            End If
                        Next

                        objDRC_Needed_DBItems = funcA_Token_Token.GetData_TokenToken_LeftRight(objDR_DBItem.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_needs.GUID, objLocalConfig.SemItem_Type_DB_Views.GUID).Rows
                        For Each objDR_Needed_DBItem In objDRC_Needed_DBItems
                            If objDR_Language.Item("GUID_Language") = GUID_Token_Language_First Then
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right"))
                            Else
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_DBItem.Item("Name_Token_Right") & "/" & objDR_Language.Item("Short") & "|" & objDRC_Needed_DBItems(0).Item("Name_Token_Right"))
                            End If
                            If strLink_To_Doc = "" Then
                                strLink_To_Doc = strLink_To_Doc & strLink
                            Else
                                strLink_To_Doc = strLink_To_Doc & ", " & strLink
                            End If
                        Next

                        If Not strLink_To_Doc = "" Then
                            objWIKI.add_Markuped_Text(objSemItem_WIKIDoc, strLink_To_Doc)
                        End If




                        strLink_To_Doc = ""
                        objDRC_Needed_SemItems = funcA_Token_Or.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objDR_DBItem.Item("GUID_CreationScript"), objLocalConfig.SemItem_RelationType_needed_semantic_Object.GUID).Rows
                        For Each objDR_Needed_SemItems In objDRC_Needed_SemItems
                            If objDR_Language.Item("GUID_Language") = GUID_Token_Language_First Then
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_SemItems.Item("Name_Ref"))
                            Else
                                strLink = objWIKI.get_String_Markuped(objLocalConfig.SemItem_Token_Wiki_Components_Wiki_Link__intern_, objDR_Needed_SemItems.Item("Name_Ref") & "/" & objDR_Language.Item("Short") & "|" & objDR_Needed_SemItems.Item("Name_Ref"))
                            End If
                            If strLink_To_Doc = "" Then
                                strLink_To_Doc = strLink_To_Doc & strLink
                            Else
                                strLink_To_Doc = strLink_To_Doc & ", " & strLink
                            End If
                        Next

                        If strLink_To_Doc = "" Then
                            objWIKI.add_Markuped_Text(objSemItem_WIKIDoc, strLink_To_Doc)
                        End If

                        'strDependencies_Backward = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_Notwendig_f_r.GUID, objDR_Language.Item("GUID_Token"))

                        'objWIKI.add_heading(objSemItem_WIKIDoc, strDependencies_Backward, 2)
                        strSkript = objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_Skript.GUID, objDR_Language.Item("GUID_Language"))
                        objWIKI.add_heading(objSemItem_WIKIDoc, strSkript, 1)
                        objDRs_XMLText = procT_CreationScripts_Of_DBSchema_By_GUIDDbSchema.Select("GUID_CreationScript='" & objDR_DBItem.Item("GUID_CreationScript").ToString & "'")
                        If objDRs_XMLText.Count > 0 Then
                            strSQL = get_XMLInnerText(objDRs_XMLText(0).Item("GUID_XML"))
                            objWIKI.add_Pre(objSemItem_WIKIDoc, strSQL)
                        End If

                        'objWIKI.add_Category(objSemItem_WIKIDoc, objSemItem_WikiImplementation, objDR_Language.Item("Short"))

                        boolFirst = True
                        objDataTable_LanguagePages.Clear()
                        For Each objDR_Language_For_Pages In objDRC_Language
                            If GUID_Token_Language_First = objDR_Language_For_Pages.Item("GUID_Language") Then

                                objDataTable_LanguagePages.Rows.Add(objDR_DBItem.Item("Name_DBItem"), objDR_Language_For_Pages.Item("Short"))
                            Else
                                objDataTable_LanguagePages.Rows.Add(objDR_DBItem.Item("Name_DBItem") & "/" & objDR_Language_For_Pages.Item("Short"), objDR_Language_For_Pages.Item("Short"))
                            End If

                        Next

                        objWIKI.add_Language_Table(objSemItem_WIKIDoc, objLocalConfig.get_LocalizedName(objLocalConfig.SemItem_Token_Names_Language_Lbl.GUID, objDR_Language.Item("GUID_Language")), objDataTable_LanguagePages.Rows)
                        objWIKI.add_Category(objSemItem_WIKIDoc, objSemItem_WikiImplementation, strType)




                    Next
                    semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objDR_DBItem.Item("GUID_DBItem"), objLocalConfig.SemItem_Attribute_is_exported.GUID, GUID_TokenAttribute_Exported, True, 0)
                End If
                




            Next
        Else
            boolResult = False
        End If


    End Function


    Private Function get_XMLInnerText(ByVal GUID_XML As Guid) As String
        Dim objXML As Xml.XmlDocument
        Dim objXMLNodeList As Xml.XmlNodeList
        Dim objXMLElement As Xml.XmlElement

        Dim objDRC_XML As DataRowCollection
        Dim strXML As String
        Dim strSQL As String

        objDRC_XML = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(GUID_XML, objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
        If objDRC_XML.Count > 0 Then
            strXML = objDRC_XML(0).Item("Val")
            objXML = New Xml.XmlDocument
            objXML.LoadXml(strXML)
            objXMLNodeList = objXML.GetElementsByTagName("data")
            If objXMLNodeList.Count > 0 Then
                objXMLElement = objXMLNodeList(0)
                strSQL = objXML.InnerText

            Else
                strSQL = Nothing
            End If
        Else
            strSQL = Nothing
        End If
        Return strSQL
    End Function

   
End Class
