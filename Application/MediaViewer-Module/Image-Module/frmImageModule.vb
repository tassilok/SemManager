Imports Sem_Manager
Imports Filesystem_Management
Public Class frmImageModule
    Private Const cint_ImageID_Root As Integer = 0
    Private Const cint_ImageID_Close As Integer = 1
    Private Const cint_ImageID_Close_SubItems As Integer = 2
    Private Const cint_ImageID_Close_Images As Integer = 3
    Private Const cint_ImageID_Close_Images_SubItems As Integer = 4
    Private Const cint_ImageID_Open As Integer = 5
    Private Const cint_ImageID_Open_SubItems As Integer = 6
    Private Const cint_ImageID_Open_Images As Integer = 7
    Private Const cint_ImageID_Open_Images_SubItems As Integer = 8
    Private Const cint_ImageID_Attributes As Integer = 9
    Private Const cint_ImageID_RelationTypes As Integer = 10
    Private Const cint_ImageID_Token As Integer = 11
    Private Const cint_ImageID_Attribute As Integer = 12
    Private Const cint_ImageID_RelationType As Integer = 13
    Private Const cint_ImageID_Token_Named As Integer = 14
    Private Const cint_ImageID_Close_RelateChoose As Integer = 15
    Private Const cint_ImageID_Open_RelateChoose As Integer = 16

    Private WithEvents objUserControl_Galery As UserControl_Galery
    Private WithEvents objUserControl_PDF As UserControl_PDFViewer
    Private WithEvents objUserControl_MediaItem As UserControl_MediaItem
    Private objFrmChooseRelation As frmRelationChoose
    Private objFrmSemManager As frmSemManager
    Private objBlobConnection As clsBlobConnection
    Private objFrmTokenEdit As frmTokenEdit
    Private objFrmImageModule_Grid As frmMediaModule_Grid


    Private objLocalConfig As clsLocalConfig
    Private objSemItems_Language() As clsSemItem
    Private objSemItem_Empty As New clsSemItem
    Private objSemItem_ToRelate As New clsSemItem
    Private objImageInfo As clsImageInfo
    Private objMediaInfo As clsMediaInfo

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblT_Token As New ds_SemDB.semtbl_TokenDataTable

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcT_SearchTemplates As New ds_Token.func_TokenTokenDataTable
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtblT_Type As New ds_SemDB.semtbl_TypeDataTable
    Private semtblT_Type_Tree As New ds_SemDB.semtbl_TypeDataTable
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private funcT_Token_OR As New ds_ObjectReference.func_Token_ORDataTable
    Private semtblT_RelatedToken As New ds_SemDB.semtbl_TokenDataTable

    Private procA_Image_Of_Or As New ds_ImageModuleTableAdapters.proc_Image_Of_OrTableAdapter
    Private procA_MediaItem_Of_Or As New ds_ImageModuleTableAdapters.proc_MediaItem_Of_OrTableAdapter
    Private procA_PDF_Of_Or As New ds_ImageModuleTableAdapters.proc_PDF_Of_OrTableAdapter
    Private procA_Images_And_References As New ds_ImageModuleTableAdapters.proc_Images_And_ReferencesTableAdapter
    Private procT_Images_And_References As New ds_ImageModule.proc_Images_And_ReferencesDataTable
    Private procA_Related_Of_ImageObjects As New ds_ImageModuleTableAdapters.proc_Related_Of_ImageObjectsTableAdapter

    Private semtblA_OR_Attribute As New ds_SemDBTableAdapters.semtbl_OR_AttributeTableAdapter
    Private semtblA_OR_RelationType As New ds_SemDBTableAdapters.semtbl_OR_RelationTypeTableAdapter
    Private semtblA_OR_Token As New ds_SemDBTableAdapters.semtbl_OR_TokenTableAdapter
    Private semtblA_OR_Type As New ds_SemDBTableAdapters.semtbl_OR_TypeTableAdapter

    Private procA_Medias_Chrono_DateParts As New ds_ImageModuleTableAdapters.proc_Medias_Chrono_DatePartsTableAdapter

    Private objTransaction_Image As clsTransaction_Imagevb
    Private objTransaction_MediaItem As clsTransaction_MediaItem

    Private objDRs_Attributes() As DataRow
    Private objDRs_RelationTypes() As DataRow

    Private objTreeNode_Root As TreeNode
    Private objTreeNode_Attributes As TreeNode
    Private objTreeNode_RelationTypes As TreeNode

    Private objSemItem_Type_Selected As clsSemItem

    Private boolOpen As Boolean
    Private boolPChange_MediaType As Boolean

    Private objDGVR_Selected As DataGridViewRow
    Private objDRV_Selected As DataRowView

    Public Event applied_Item(ByVal objSemItem_FileSystemObject As clsSemItem)

    Private Sub related_Items_Image(ByVal intRowID) Handles objUserControl_Galery.related_Image
        Dim objDR_Image As DataRow
        Dim objSemItem_ImageGraphic As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        If Not objSemItem_ToRelate Is Nothing Then
            objSemItem_Result = objTransaction_Image.save_001_OR_of_Ref(objSemItem_ToRelate)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objDR_Image = objUserControl_Galery.DR_Selected(intRowID)
                If Not objDR_Image Is Nothing Then
                    objSemItem_ImageGraphic.GUID = objDR_Image.Item("GUID_Images__Graphic_")
                    objSemItem_ImageGraphic.Name = objDR_Image.Item("Name_Images__Graphic_")
                    objSemItem_ImageGraphic.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                    objSemItem_ImageGraphic.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Result = objTransaction_Image.save_007_ImageGraphic_To_OR(0, objSemItem_ImageGraphic)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        ToolStripLabel_LastRelation.Text = objSemItem_ToRelate.Name & " / " & objSemItem_ImageGraphic.Name
                    Else
                        MsgBox("Das Image konnte nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If
            
        End If
        
    End Sub

    Private Sub related_Items_AllImage() Handles objUserControl_Galery.relate_All_Images
        Dim objDR_Image As DataRow
        Dim objSemItem_ImageGraphic As New clsSemItem
        Dim objSemItem_Result As clsSemItem

        If Not objSemItem_ToRelate Is Nothing Then
            objSemItem_Result = objTransaction_Image.save_001_OR_of_Ref(objSemItem_ToRelate)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                For Each objDR_Image In objUserControl_Galery.DRs_Images
                    objSemItem_ImageGraphic.GUID = objDR_Image.Item("GUID_Images__Graphic_")
                    objSemItem_ImageGraphic.Name = objDR_Image.Item("Name_Images__Graphic_")
                    objSemItem_ImageGraphic.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                    objSemItem_ImageGraphic.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objSemItem_Result = objTransaction_Image.save_007_ImageGraphic_To_OR(0, objSemItem_ImageGraphic)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        ToolStripLabel_LastRelation.Text = objSemItem_ToRelate.Name & " / " & objSemItem_ImageGraphic.Name
                    Else
                        MsgBox("Das Image konnte nicht verknüpft werden!", MsgBoxStyle.Exclamation)
                    End If
                Next

                

            End If

        End If

    End Sub

    Private Sub related_Items_Media() Handles objUserControl_MediaItem.related_Items
        Dim objSemItem_MediaItem As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim intID As Integer
        Dim intToDo As Integer
        Dim intDone As Integer
        intToDo = objUserControl_MediaItem.DataGridViewRow_SelectedRows.Count
        intDone = 0
        intID = 0
        If Not objSemItem_ToRelate Is Nothing Then
            objSemItem_Result = objTransaction_MediaItem.save_001_OR_of_Ref(objSemItem_ToRelate)

            For Each objDGVR_Selected In objUserControl_MediaItem.DataGridViewRow_SelectedRows
                objDRV_Selected = objDGVR_Selected.DataBoundItem

                objSemItem_MediaItem.GUID = objDRV_Selected.Item("GUID_Media_Item")
                objSemItem_MediaItem.Name = objDRV_Selected.Item("Name_Media_Item")
                objSemItem_MediaItem.GUID_Parent = objLocalConfig.SemItem_Type_Media_Item.GUID
                objSemItem_MediaItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID



                If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objTransaction_MediaItem.save_007_MediaItem_To_OR(intID, objSemItem_MediaItem)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        ToolStripLabel_LastRelation.Text = objSemItem_ToRelate.Name & " / " & objSemItem_MediaItem.Name
                        intDone = intDone + 1
                        intID = intID + 1
                    End If
                End If
            Next
        End If
        

        If intDone < intToDo Then
            MsgBox("Es konnten nur " & intDone & " von " & intToDo & " Items verknüpft werden!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public WriteOnly Property applyable As Boolean
        Set(ByVal value As Boolean)

        End Set
    End Property


    Public ReadOnly Property SemItem_Type_PDF_Document As clsSemItem
        Get
            Return objLocalConfig.SemItem_Type_PDF_Documents
        End Get
    End Property

    Public ReadOnly Property SemItem_Type_Images As clsSemItem
        Get
            Return objLocalConfig.SemItem_Type_Images__Graphic_
        End Get
    End Property

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)

        funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_SearchTemplates, _
                                                   objLocalConfig.SemItem_Module.GUID, _
                                                   objLocalConfig.SemItem_RelationType_offers.GUID, _
                                                   objLocalConfig.SemItem_Type_Search_Template.GUID)
        ToolStripComboBox_SearchTemplate.ComboBox.DataSource = funcT_SearchTemplates
        ToolStripComboBox_SearchTemplate.ComboBox.DisplayMember = "Name_Token_Right"
        ToolStripComboBox_SearchTemplate.ComboBox.ValueMember = "GUID_Token_Right"

        config_SearchTemplates()


        objSemItem_Empty.GUID = objLocalConfig.SemItem_Development.GUID

        boolPChange_MediaType = True
        ToolStripComboBox_MediaType.ComboBox.Items.Add(objLocalConfig.SemItem_Type_Images__Graphic_)
        ToolStripComboBox_MediaType.ComboBox.Items.Add(objLocalConfig.SemItem_Type_PDF_Documents)
        ToolStripComboBox_MediaType.ComboBox.Items.Add(objLocalConfig.SemItem_Type_Media_Item)
        ToolStripComboBox_MediaType.ComboBox.Items.Add(objSemItem_Empty)
        ToolStripComboBox_MediaType.ComboBox.ValueMember = "GUID"
        ToolStripComboBox_MediaType.ComboBox.DisplayMember = "Name"
        ToolStripComboBox_MediaType.ComboBox.SelectedValue = objSemItem_Empty.GUID
        boolPChange_MediaType = False
        set_DBConnection()
        'initialize()
    End Sub

    Private Sub config_SearchTemplates()
        If ToolStripComboBox_SearchTemplate.Items.Count > 0 And TreeView_RelatedItems.Nodes.Count > 0 Then
            ToolStripTextBox_Filter.ReadOnly = False
            ToolStripButton_Filter.Enabled = True
            ToolStripComboBox_SearchTemplate.Enabled = True

        Else
            ToolStripTextBox_Filter.ReadOnly = True
            ToolStripButton_Filter.Enabled = False
            ToolStripComboBox_SearchTemplate.Enabled = False
        End If
    End Sub


    Public Sub initialize(ByVal SemItem_Type As clsSemItem)
        If SemItem_Type Is Nothing Then
            TreeView_RelatedItems.Nodes.Clear()
            SplitContainer1.Panel2.Controls.Clear()
        Else
            TreeView_RelatedItems.Nodes.Clear()
            SplitContainer1.Panel2.Controls.Clear()
            objSemItem_Type_Selected = SemItem_Type

            get_Languages()
            If boolOpen = True Then
                get_MediaItems_And_RelatedItems()
                If ToolStripMenuItem_Semantic.Checked = True Then
                    fill_Tree_semantic()
                ElseIf ToolStripMenuItem_Chrono.Checked = True Then
                    fill_Tree_Chrono()
                ElseIf ToolStripMenuItem_ChronoSemantic.Checked = True Then
                    MsgBox("Noch nicht implementiert!", MsgBoxStyle.Information)
                ElseIf NamedSemanticsToolStripMenuItem.Checked = True Then
                    fill_Tree_NamedSemantics()
                End If

            Else
                MsgBox("Die Konfiguration ist nicht vollständig!", MsgBoxStyle.Exclamation)
            End If
        End If


    End Sub

    Private Sub get_Languages()
        Dim objDRC_Languages As DataRowCollection
        Dim i As Integer


        objDRC_Languages = funcA_TokenToken.GetData_TokenToken_LeftRight(objLocalConfig.SemItem_BaseConfig.GUID, _
                                                                            objLocalConfig.SemItem_RelationType_isDescribedBy.GUID, _
                                                                            objLocalConfig.SemItem_Type_Language.GUID).Rows
        If objDRC_Languages.Count > 0 Then
            boolOpen = True

            ReDim Preserve objSemItems_Language(objDRC_Languages.Count - 1)
            For i = 0 To objDRC_Languages.Count - 1
                objSemItems_Language(i) = New clsSemItem
                objSemItems_Language(i).GUID = objDRC_Languages(i).Item("GUID_Token_Right")
                objSemItems_Language(i).Name = objDRC_Languages(i).Item("Name_Token_Right")
                objSemItems_Language(i).GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
                objSemItems_Language(i).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Next
        Else
            boolOpen = False
        End If

    End Sub

    Private Sub get_MediaItems_And_RelatedItems()
        Dim objDR_PDFDocument As DataRow
        Dim objDRs_RelItems() As DataRow
        Dim objDR_RelItem As DataRow
        Dim objDRC_Type As DataRowCollection
        Dim intItemCount As Integer = 0

        'semtblA_Token.Fill_Token_TypeChilds(semtblT_Token, objSemItem_Type_Selected.GUID)
        'funcT_Token_OR.Clear()
        'funcA_Token_OR.ClearBeforeFill = False

        'For Each objDR_PDFDocument In semtblT_Token.Rows
        '    funcA_Token_OR.Fill_By_GUIDTokenLeft_And_GUIDRelationType(funcT_Token_OR, _
        '                                                              objDR_PDFDocument.Item("GUID_Token"), _
        '                                                              objLocalConfig.SemItem_RelationType_belongsTo.GUID)

        'Next

        semtblT_RelatedToken.Clear()
        semtblT_Token.Clear()
        semtblT_Type.Clear()
        semtblT_Type_Tree.Clear()

        procT_Images_And_References.Clear()

        procA_Images_And_References.Fill(procT_Images_And_References, _
                                         objSemItem_Type_Selected.GUID, _
                                         objLocalConfig.SemItem_RelationType_belongsTo.GUID)

        objDRs_Attributes = procT_Images_And_References.Select("GUID_ItemType='" & objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString & "'", "Name_Token")
        intItemCount = objDRs_Attributes.Count
        objDRs_RelationTypes = procT_Images_And_References.Select("GUID_ItemType='" & objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString & "'", "Name_Token")
        intItemCount = intItemCount + objDRs_RelationTypes.Count
        If objDRs_Attributes.Count > 0 Then
            objTreeNode_Attributes = TreeView_RelatedItems.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID.ToString, _
                                                                     objLocalConfig.Globals.ObjectReferenceType_Attribute.Name, _
                                                                     cint_ImageID_Attributes, cint_ImageID_Attributes)
        End If

        If objDRs_RelationTypes.Count > 0 Then
            objTreeNode_RelationTypes = TreeView_RelatedItems.Nodes.Add(objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID.ToString, _
                                                                        objLocalConfig.Globals.ObjectReferenceType_RelationType.Name, _
                                                                        cint_ImageID_RelationTypes, cint_ImageID_RelationTypes)

        End If

        objDRs_RelItems = procT_Images_And_References.Select("GUID_ItemType='" & objLocalConfig.Globals.ObjectReferenceType_Type.GUID.ToString & "'")
        intItemCount = intItemCount + objDRs_RelItems.Count
        For Each objDR_RelItem In objDRs_RelItems
            objDRC_Type = semtblA_Type.GetData_By_GUID(objDR_RelItem.Item("GUID_Ref")).Rows
            If objDRC_Type.Count > 0 Then
                semtblT_Type.Rows.Add(objDRC_Type(0).Item(0), objDRC_Type(0).Item(1), objDRC_Type(0).Item(2))
                get_Parent(objDRC_Type(0).Item("GUID_Type_Parent"))
            End If


        Next

        objDRs_RelItems = procT_Images_And_References.Select("GUID_ItemType='" & objLocalConfig.Globals.ObjectReferenceType_Token.GUID.ToString & "'")
        intItemCount = intItemCount + objDRs_RelItems.Count
        semtblA_Token.ClearBeforeFill = False
        For Each objDR_RelItem In objDRs_RelItems
            semtblA_Token.Fill_Token_By_GUID(semtblT_RelatedToken, objDR_RelItem.Item("GUID_Ref"))

        Next

        For Each objDR_RelItem In semtblT_RelatedToken.Rows
            get_Parent(objDR_RelItem.Item("GUID_Type"))
        Next

        ToolStripLabel_ItemCount.Text = intItemCount
    End Sub

    Private Sub get_Parent(ByVal GUID_TypeParent As Guid)
        Dim objDRC_Type As DataRowCollection

        objDRC_Type = semtblA_Type.GetData_By_GUID(GUID_TypeParent).Rows
        If objDRC_Type.Count > 0 Then
            If semtblT_Type_Tree.Select("GUID_Type='" & GUID_TypeParent.ToString & "'").Count = 0 Then
                semtblT_Type_Tree.Rows.Add(objDRC_Type(0).Item(0), objDRC_Type(0).Item(1), objDRC_Type(0).Item(2))
            End If

            If Not IsDBNull(objDRC_Type(0).Item("GUID_Type_Parent")) Then
                get_Parent(objDRC_Type(0).Item("GUID_Type_Parent"))
            End If
        End If
    End Sub

    Private Sub fill_Tree_Attributes()
        Dim objDR_Attribute As DataRow
        If Not objTreeNode_Attributes Is Nothing Then
            objTreeNode_Attributes.Nodes.Clear()
            For Each objDR_Attribute In objDRs_Attributes
                objTreeNode_Attributes.Nodes.Add(objDR_Attribute.Item("GUID_Ref"), _
                                                 objDR_Attribute.Item("Name_Ref"), _
                                                 cint_ImageID_Attribute, cint_ImageID_Attribute)
            Next
        End If


    End Sub

    Private Sub fill_Tree_RelationTypes()
        Dim objDR_RelationType As DataRow
        If Not objTreeNode_RelationTypes Is Nothing Then
            objTreeNode_RelationTypes.Nodes.Clear()
            For Each objDR_RelationType In objDRs_RelationTypes
                objTreeNode_Attributes.Nodes.Add(objDR_RelationType.Item("GUID_Ref"), _
                                                 objDR_RelationType.Item("Name_Ref"), _
                                                 cint_ImageID_RelationType, cint_ImageID_RelationType)
            Next
        End If


    End Sub
    Private Sub fill_Tree_Chrono()
        Dim objDRC_Chrono As DataRowCollection
        Dim objDR_Chrono As DataRow
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Year As TreeNode
        Dim objTreeNode_Month As TreeNode
        Dim objTreeNode_Day As TreeNode
        Dim objTreeNode_Unassigned As TreeNode
        Dim objDRs_Subs() As DataRow
        Dim objDR_Sub As DataRow

        objDRC_Chrono = procA_Medias_Chrono_DateParts.GetData(objLocalConfig.SemItem_Attribute_ID.GUID, _
                                                              objLocalConfig.SemItem_Type_Year.GUID, _
                                                              objLocalConfig.SemItem_Type_Month.GUID, _
                                                              objLocalConfig.SemItem_Type_Day.GUID, _
                                                              objLocalConfig.SemItem_RelationType_taking_at.GUID, _
                                                              objSemItem_Type_Selected.GUID).Rows


        TreeView_RelatedItems.Nodes.Clear()


        objTreeNode_Root = TreeView_RelatedItems.Nodes.Add(objSemItem_Type_Selected.GUID.ToString, objSemItem_Type_Selected.Name, cint_ImageID_Root, cint_ImageID_Root)

        For Each objDR_Chrono In objDRC_Chrono
            If IsDBNull(objDR_Chrono.Item("GUID_Year")) Then
                objTreeNode_Unassigned = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Token_Logstate_Unassigned.GUID.ToString, _
                                                                    objLocalConfig.SemItem_Token_Logstate_Unassigned.Name, cint_ImageID_Close, cint_ImageID_Open)
            Else
                objTreeNodes = objTreeNode_Root.Nodes.Find(objDR_Chrono.Item("GUID_Year").ToString, False)
                If objTreeNodes.Count = 0 Then
                    objTreeNode_Year = objTreeNode_Root.Nodes.Add(objDR_Chrono.Item("GUID_Year").ToString, objDR_Chrono.Item("Year"), cint_ImageID_Close, cint_ImageID_Open)
                Else
                    objTreeNode_Year = objTreeNodes(0)
                End If

                objTreeNodes = objTreeNode_Year.Nodes.Find(objDR_Chrono.Item("GUID_Month").ToString, False)

                If objTreeNodes.Count = 0 Then
                    objTreeNode_Month = objTreeNode_Year.Nodes.Add(objDR_Chrono.Item("GUID_Month").ToString, objDR_Chrono.Item("Month") & " " & objDR_Chrono.Item("NameOfMonth"), cint_ImageID_Close, cint_ImageID_Open)

                Else
                    objTreeNode_Month = objTreeNodes(0)
                End If

                objTreeNodes = objTreeNode_Month.Nodes.Find(objDR_Chrono.Item("GUID_Day").ToString, False)

                If objTreeNodes.Count = 0 Then
                    objTreeNode_Day = objTreeNode_Month.Nodes.Add(objDR_Chrono.Item("GUID_Day").ToString, objDR_Chrono.Item("Day") & " " & objDR_Chrono.Item("NameOfDay"), cint_ImageID_Close, cint_ImageID_Open)
                Else
                    objTreeNode_Day = objTreeNodes(0)
                End If
            End If

        Next
    End Sub

    Private Sub fill_Tree_NamedSemantics()
        Dim objTreeNode_Partners As TreeNode
        Dim objTreeNode_Locations As TreeNode
        Dim objTreeNode_Buildings As TreeNode
        Dim objTreeNode_Pets As TreeNode
        Dim objTreeNode_Species As TreeNode
        Dim objTreeNode_Plants As TreeNode
        Dim objTreeNode_Landscapes As TreeNode
        Dim objTreeNode_WeatherConditions As TreeNode
        Dim objTreeNode_ArtWork As TreeNode
        Dim objDRC_Related As DataRowCollection
        Dim objDR_Related As DataRow

        TreeView_RelatedItems.Nodes.Clear()


        objTreeNode_Root = TreeView_RelatedItems.Nodes.Add(objSemItem_Type_Selected.GUID.ToString, objSemItem_Type_Selected.Name, cint_ImageID_Root, cint_ImageID_Root)
        objTreeNode_Partners = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_Partner.GUID.ToString, objLocalConfig.SemItem_Type_Partner.Name, cint_ImageID_Close, cint_ImageID_Open)
        objTreeNode_Locations = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_Ort.GUID.ToString, objLocalConfig.SemItem_Type_Ort.Name, cint_ImageID_Close, cint_ImageID_Open)
        objTreeNode_Buildings = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_Bauwerke.GUID.ToString, objLocalConfig.SemItem_Type_Bauwerke.Name, cint_ImageID_Close, cint_ImageID_Open)
        objTreeNode_Pets = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_Haustier.GUID.ToString, objLocalConfig.SemItem_Type_Haustier.Name, cint_ImageID_Close, cint_ImageID_Open)
        objTreeNode_Species = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_Tierarten.GUID.ToString, objLocalConfig.SemItem_Type_Tierarten.Name, cint_ImageID_Close, cint_ImageID_Open)
        objTreeNode_Plants = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_Pflanzenarten.GUID.ToString, objLocalConfig.SemItem_Type_Pflanzenarten.Name, cint_ImageID_Close, cint_ImageID_Open)
        objTreeNode_Landscapes = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_landscape.GUID.ToString, objLocalConfig.SemItem_Type_landscape.Name, cint_ImageID_Close, cint_ImageID_Open)
        objTreeNode_WeatherConditions = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_Wetterlage.GUID.ToString, objLocalConfig.SemItem_Type_Wetterlage.Name, cint_ImageID_Close, cint_ImageID_Open)
        objTreeNode_ArtWork = objTreeNode_Root.Nodes.Add(objLocalConfig.SemItem_Type_Kunst.GUID.ToString, objLocalConfig.SemItem_Type_Kunst.Name, cint_ImageID_Close, cint_ImageID_Open)

        'Partners
        objDRC_Related = procA_Related_Of_ImageObjects.GetData(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Persons.GUID, _
                                                               objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                                               objLocalConfig.SemItem_Type_Partner.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is.GUID).Rows
        For Each objDR_Related In objDRC_Related
            objTreeNode_Partners.Nodes.Add(objDR_Related.Item("GUID_Token").ToString, objDR_Related.Item("Name_Token").ToString, cint_ImageID_Token_Named, cint_ImageID_Token_Named)
        Next

        'Locations
        objDRC_Related = procA_Related_Of_ImageObjects.GetData(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Location.GUID, _
                                                               objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                                               objLocalConfig.SemItem_Type_Ort.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is.GUID).Rows
        For Each objDR_Related In objDRC_Related
            objTreeNode_Locations.Nodes.Add(objDR_Related.Item("GUID_Token").ToString, objDR_Related.Item("Name_Token").ToString, cint_ImageID_Token_Named, cint_ImageID_Token_Named)
        Next

        'Buildings
        objDRC_Related = procA_Related_Of_ImageObjects.GetData(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Buildings.GUID, _
                                                               objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                                               objLocalConfig.SemItem_Type_Bauwerke.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is.GUID).Rows
        For Each objDR_Related In objDRC_Related
            objTreeNode_Buildings.Nodes.Add(objDR_Related.Item("GUID_Token").ToString, objDR_Related.Item("Name_Token").ToString, cint_ImageID_Token_Named, cint_ImageID_Token_Named)
        Next

        'Pets
        objDRC_Related = procA_Related_Of_ImageObjects.GetData(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Pets.GUID, _
                                                               objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                                               objLocalConfig.SemItem_Type_Haustier.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is.GUID).Rows
        For Each objDR_Related In objDRC_Related
            objTreeNode_Pets.Nodes.Add(objDR_Related.Item("GUID_Token").ToString, objDR_Related.Item("Name_Token").ToString, cint_ImageID_Token_Named, cint_ImageID_Token_Named)
        Next

        'Species
        objDRC_Related = procA_Related_Of_ImageObjects.GetData(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_species.GUID, _
                                                               objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                                               objLocalConfig.SemItem_Type_Tierarten.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is.GUID).Rows
        For Each objDR_Related In objDRC_Related
            objTreeNode_Species.Nodes.Add(objDR_Related.Item("GUID_Token").ToString, objDR_Related.Item("Name_Token").ToString, cint_ImageID_Token_Named, cint_ImageID_Token_Named)
        Next

        'Plants
        objDRC_Related = procA_Related_Of_ImageObjects.GetData(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_plant_Species.GUID, _
                                                               objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                                               objLocalConfig.SemItem_Type_Pflanzenarten.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is.GUID).Rows
        For Each objDR_Related In objDRC_Related
            objTreeNode_Plants.Nodes.Add(objDR_Related.Item("GUID_Token").ToString, objDR_Related.Item("Name_Token").ToString, cint_ImageID_Token_Named, cint_ImageID_Token_Named)
        Next

        'Landscapes
        objDRC_Related = procA_Related_Of_ImageObjects.GetData(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_landscape.GUID, _
                                                               objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                                               objLocalConfig.SemItem_Type_landscape.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is.GUID).Rows
        For Each objDR_Related In objDRC_Related
            objTreeNode_Landscapes.Nodes.Add(objDR_Related.Item("GUID_Token").ToString, objDR_Related.Item("Name_Token").ToString, cint_ImageID_Token_Named, cint_ImageID_Token_Named)
        Next

        'WeatherConditions
        objDRC_Related = procA_Related_Of_ImageObjects.GetData(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__weather_condition.GUID, _
                                                               objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                                               objLocalConfig.SemItem_Type_Wetterlage.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is.GUID).Rows
        For Each objDR_Related In objDRC_Related
            objTreeNode_WeatherConditions.Nodes.Add(objDR_Related.Item("GUID_Token").ToString, objDR_Related.Item("Name_Token").ToString, cint_ImageID_Token_Named, cint_ImageID_Token_Named)
        Next

        'ArtWork
        objDRC_Related = procA_Related_Of_ImageObjects.GetData(objLocalConfig.SemItem_Token_Image_Objects__No_Objects__no_Artwork.GUID, _
                                                               objLocalConfig.SemItem_Type_Image_Objects.GUID, _
                                                               objLocalConfig.SemItem_Type_Kunst.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is.GUID).Rows
        For Each objDR_Related In objDRC_Related
            objTreeNode_ArtWork.Nodes.Add(objDR_Related.Item("GUID_Token").ToString, objDR_Related.Item("Name_Token").ToString, cint_ImageID_Token_Named, cint_ImageID_Token_Named)
        Next

    End Sub

    Private Sub fill_Tree_semantic()
        Dim objDRs_Item() As DataRow
        Dim objDRC_Type As DataRowCollection
        Dim objDR_Item As DataRow
        Dim objSemItem_Type As New clsSemItem

        TreeView_RelatedItems.Nodes.Clear()


        objTreeNode_Root = TreeView_RelatedItems.Nodes.Add(objSemItem_Type_Selected.GUID.ToString, objSemItem_Type_Selected.Name, cint_ImageID_Root, cint_ImageID_Root)


        fill_Tree_Type()
        For Each objDR_Item In semtblT_Token.Rows
            objDRC_Type = semtblA_Type.GetData_By_GUID(objDR_Item.Item("GUID_Type")).Rows

            objSemItem_Type.GUID = objDRC_Type(0).Item("GUID_Type")
            objSemItem_Type.Name = objDRC_Type(0).Item("Name_Type")
            objSemItem_Type.GUID_Parent = objDRC_Type(0).Item("GUID_Type_Parent")
            objSemItem_Type.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
            fill_Tree_Type(objSemItem_Type)
        Next

        fill_Tree_Attributes()
        fill_Tree_RelationTypes()
    End Sub

    

    Private Sub fill_Tree_Type(Optional ByVal objSemItem_Type As clsSemItem = Nothing)
        Dim objDRs_Item() As DataRow

        Dim objDR_Item As DataRow

        Dim objTreeNode As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim intImageID As Integer
        Dim intSelectedImageID As Integer
        Dim boolPDF As Boolean

        If objSemItem_Type Is Nothing Then
            objDRs_Item = semtblT_Type_Tree.Select("GUID_Type_Parent IS NULL", "Name_Type")
            If objDRs_Item.Count > 0 Then
                objSemItem_Type = New clsSemItem
                objSemItem_Type.GUID = objDRs_Item(0).Item("GUID_Type")
                objSemItem_Type.Name = objDRs_Item(0).Item("Name_Type")
                objSemItem_Type.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                objTreeNode = objTreeNode_Root.Nodes.Add(objSemItem_Type.GUID.ToString, objSemItem_Type.Name)

                If has_SubItems(objSemItem_Type) = True Then
                    If has_Image(objSemItem_Type) = True Then
                        intImageID = cint_ImageID_Close_Images_SubItems
                        intSelectedImageID = cint_ImageID_Open_Images_SubItems

                    Else
                        intImageID = cint_ImageID_Close_SubItems
                        intSelectedImageID = cint_ImageID_Open_SubItems
                    End If
                Else
                    If has_Image(objSemItem_Type) = True Then
                        intImageID = cint_ImageID_Close_Images
                        intSelectedImageID = cint_ImageID_Open_Images
                    Else
                        intImageID = cint_ImageID_Close
                        intSelectedImageID = cint_ImageID_Open
                    End If
                End If

                objTreeNode.ImageIndex = intImageID
                objTreeNode.SelectedImageIndex = intSelectedImageID
                get_Token(objTreeNode)

            End If
        Else
            If has_SubItems(objSemItem_Type) = True Then
                If has_Image(objSemItem_Type) = True Then
                    intImageID = cint_ImageID_Close_Images_SubItems
                    intSelectedImageID = cint_ImageID_Open_Images_SubItems

                Else
                    intImageID = cint_ImageID_Close_SubItems
                    intSelectedImageID = cint_ImageID_Open_SubItems
                End If
            Else
                If has_Image(objSemItem_Type) = True Then
                    intImageID = cint_ImageID_Close_Images
                    intSelectedImageID = cint_ImageID_Open_Images
                Else
                    intImageID = cint_ImageID_Close
                    intSelectedImageID = cint_ImageID_Open
                End If
            End If

            objTreeNodes = objTreeNode_Root.Nodes.Find(objSemItem_Type.GUID.ToString, True)
            If objTreeNodes.Count > 0 Then
                objTreeNodes(0).ImageIndex = intImageID
                objTreeNodes(0).SelectedImageIndex = intSelectedImageID
                get_Token(objTreeNodes(0))
            Else
                objTreeNodes = objTreeNode_Root.Nodes.Find(objSemItem_Type.GUID_Parent.ToString, True)
                If objTreeNodes.Count > 0 Then
                    objTreeNode = objTreeNodes(0).Nodes.Add(objSemItem_Type.GUID.ToString, objSemItem_Type.Name, intImageID, intSelectedImageID)
                    get_Token(objTreeNode)
                Else
                    objTreeNode = Nothing
                End If
            End If


        End If

        If Not objSemItem_Type Is Nothing Then
            objDRs_Item = semtblT_Type_Tree.Select("GUID_Type_Parent='" & objSemItem_Type.GUID.ToString & "'", "Name_Type")
            objSemItem_Type = New clsSemItem
            For Each objDR_Item In objDRs_Item
                objSemItem_Type.GUID = objDR_Item.Item("GUID_Type")
                objSemItem_Type.Name = objDR_Item.Item("Name_Type")
                objSemItem_Type.GUID_Parent = objDR_Item.Item("GUID_Type_Parent")
                objSemItem_Type.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                fill_Tree_Type(objSemItem_Type)

            Next
        End If

    End Sub

    Private Sub get_Token(ByVal objTreeNode_Type As TreeNode)
        Dim objDRs_Token() As DataRow
        Dim objDR_Token As DataRow

        objTreeNode_Type.Nodes.Clear()
        objDRs_Token = semtblT_RelatedToken.Select("GUID_Type='" & objTreeNode_Type.Name & "'", "Name_Token")

        For Each objDR_Token In objDRs_Token
            objTreeNode_Type.Nodes.Add(objDR_Token.Item("GUID_Token").ToString, objDR_Token.Item("Name_Token"), cint_ImageID_Token, cint_ImageID_Token)

        Next

    End Sub

    Private Function has_Image(ByVal objSemItem As clsSemItem) As Boolean
        If funcT_Token_OR.Select("GUID_Ref='" & objSemItem.GUID.ToString & "'").Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function has_SubItems(ByVal objSemItem_Type As clsSemItem) As Boolean
        If semtblT_Token.Select("GUID_Type='" & objSemItem_Type.GUID.ToString & "'").Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'Private Sub test()
    '    Dim objSemItem_Test As New clsSemItem
    '    Dim objSemItems_Language(1) As clsSemItem

    '    objLocalConfig = New clsLocalConfig(New clsGlobals)

    '    objSemItem_Test.GUID = New Guid("7841700f-085e-48e6-a9a9-c9c6b5b8b6b8")
    '    objSemItem_Test.Name = "Test"
    '    objSemItem_Test.GUID_Parent = New Guid("2c1f5b97-21e5-44ca-95d2-43008011c14d")
    '    objSemItem_Test.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

    '    objSemItems_Language(0) = New clsSemItem
    '    objSemItems_Language(0).GUID = New Guid("8b1691d9-b296-4841-b01e-a7b6452eab2f")
    '    objSemItems_Language(0).Name = "German (Germany)"
    '    objSemItems_Language(0).GUID_Parent = New Guid("e79ff4de-2e39-4101-b5a1-0055c40f41cd")
    '    objSemItems_Language(0).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

    '    objSemItems_Language(1) = New clsSemItem
    '    objSemItems_Language(1).GUID = New Guid("63188e16-0cd7-4384-90a8-558b47564b7b")
    '    objSemItems_Language(1).Name = "English (United States)"
    '    objSemItems_Language(1).GUID_Parent = New Guid("e79ff4de-2e39-4101-b5a1-0055c40f41cd")
    '    objSemItems_Language(1).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

    '    objUserControl_Galery = New UserControl_Galery(objSemItem_Test, objSemItems_Language)
    '    objUserControl_Galery.Dock = DockStyle.Fill

    '    Me.Controls.Clear()
    '    Me.Controls.Add(objUserControl_Galery)
    'End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB

        semtblA_OR_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_OR_RelationType.Connection = objLocalConfig.Connection_DB
        semtblA_OR_Token.Connection = objLocalConfig.Connection_DB
        semtblA_OR_Type.Connection = objLocalConfig.Connection_DB

        procA_Image_Of_Or.Connection = objLocalConfig.Connection_Plugin
        procA_MediaItem_Of_Or.Connection = objLocalConfig.Connection_Plugin
        procA_PDF_Of_Or.Connection = objLocalConfig.Connection_Plugin
        procA_Images_And_References.Connection = objLocalConfig.Connection_Plugin

        procA_Medias_Chrono_DateParts.Connection = objLocalConfig.Connection_Plugin
        procA_Related_Of_ImageObjects.Connection = objLocalConfig.Connection_Plugin

        objTransaction_Image = New clsTransaction_Imagevb(objLocalConfig)
        objTransaction_MediaItem = New clsTransaction_MediaItem(objLocalConfig)
        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
        objImageInfo = New clsImageInfo(objLocalConfig)
        objMediaInfo = New clsMediaInfo(objLocalConfig.Globals)
    End Sub

    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Close()
    End Sub

    Private Sub frmImageModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub TreeView_RelatedItems_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_RelatedItems.AfterSelect
        Dim objTreeNode As TreeNode
        Dim objSemItem_Ref As clsSemItem
        Dim objTreeNode_Parent As TreeNode
        Dim objTreeNode_Parent_Parent As TreeNode
        Dim objTreeNode_Parent_Parent_Parent As TreeNode

        Dim objSemItem_Year As clsSemItem
        Dim objSemItem_Month As clsSemItem
        Dim objSemItem_Day As clsSemItem

        objTreeNode = TreeView_RelatedItems.SelectedNode

        SplitContainer1.Panel2.Controls.Clear()

        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Close, cint_ImageID_Close_Images, cint_ImageID_Close_Images_SubItems, cint_ImageID_Close_SubItems
                    If ToolStripMenuItem_Semantic.Checked = True Then
                        objSemItem_Ref = New clsSemItem
                        objSemItem_Ref.GUID = New Guid(objTreeNode.Name)
                        objSemItem_Ref.Name = objTreeNode.Text
                        objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                        Select Case objSemItem_Type_Selected.GUID
                            Case objLocalConfig.SemItem_Type_Images__Graphic_.GUID

                                objUserControl_Galery = New UserControl_Galery(objSemItem_Ref, objSemItems_Language, objLocalConfig)
                                objUserControl_Galery.allow_Edit = True
                                objUserControl_Galery.Dock = DockStyle.Fill
                                If objSemItem_ToRelate Is Nothing Then
                                    objUserControl_Galery.Enable_Relation = False
                                Else
                                    objUserControl_Galery.Enable_Relation = True
                                End If

                                SplitContainer1.Panel2.Controls.Add(objUserControl_Galery)
                            Case objLocalConfig.SemItem_Type_PDF_Documents.GUID
                                objUserControl_PDF = New UserControl_PDFViewer(objSemItem_Ref, objSemItems_Language, objLocalConfig)
                                objUserControl_PDF.Dock = DockStyle.Fill
                                SplitContainer1.Panel2.Controls.Add(objUserControl_PDF)
                            Case objLocalConfig.SemItem_Type_Media_Item.GUID
                                Try
                                    objUserControl_MediaItem.stop_Media()
                                Catch ex As Exception

                                End Try
                                objUserControl_MediaItem = New UserControl_MediaItem(objSemItem_Ref, objSemItems_Language, objLocalConfig)
                                objUserControl_MediaItem.Allow_Edit = True
                                objUserControl_MediaItem.Dock = DockStyle.Fill
                                If objSemItem_ToRelate Is Nothing Then
                                    objUserControl_MediaItem.Enable_Relation = False
                                Else
                                    objUserControl_MediaItem.Enable_Relation = True
                                End If
                                SplitContainer1.Panel2.Controls.Add(objUserControl_MediaItem)

                        End Select
                    ElseIf ToolStripMenuItem_Chrono.Checked = True Then
                        objTreeNode_Parent = objTreeNode.Parent
                        If Not objTreeNode_Parent Is Nothing Then
                            If objTreeNode_Parent.ImageIndex = cint_ImageID_Root Then
                                objSemItem_Year = New clsSemItem
                                objSemItem_Year.GUID = New Guid(objTreeNode.Name)
                                objSemItem_Year.Name = objTreeNode.Text
                                objSemItem_Year.GUID_Parent = objLocalConfig.SemItem_Type_Year.GUID
                                objSemItem_Year.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


                            Else
                                objTreeNode_Parent_Parent = objTreeNode.Parent.Parent
                                If objTreeNode_Parent_Parent.ImageIndex = cint_ImageID_Root Then
                                    objSemItem_Month = New clsSemItem
                                    objSemItem_Month.GUID = New Guid(objTreeNode.Name)
                                    objSemItem_Month.Name = objTreeNode.Text
                                    objSemItem_Month.GUID_Parent = objLocalConfig.SemItem_Type_Month.GUID
                                    objSemItem_Month.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    objSemItem_Year = New clsSemItem
                                    objSemItem_Year.GUID = New Guid(objTreeNode_Parent.Name)
                                    objSemItem_Year.Name = objTreeNode_Parent.Text
                                    objSemItem_Year.GUID_Parent = objLocalConfig.SemItem_Type_Year.GUID
                                    objSemItem_Year.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                Else
                                    objTreeNode_Parent_Parent_Parent = objTreeNode_Parent_Parent.Parent

                                    objSemItem_Day = New clsSemItem
                                    objSemItem_Day.GUID = New Guid(objTreeNode.Name)
                                    objSemItem_Day.Name = objTreeNode.Text
                                    objSemItem_Day.GUID_Parent = objLocalConfig.SemItem_Type_Day.GUID
                                    objSemItem_Day.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    objSemItem_Month = New clsSemItem
                                    objSemItem_Month.GUID = New Guid(objTreeNode_Parent.Name)
                                    objSemItem_Month.Name = objTreeNode_Parent.Text
                                    objSemItem_Month.GUID_Parent = objLocalConfig.SemItem_Type_Month.GUID
                                    objSemItem_Month.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    objSemItem_Year = New clsSemItem
                                    objSemItem_Year.GUID = New Guid(objTreeNode_Parent_Parent.Name)
                                    objSemItem_Year.Name = objTreeNode_Parent_Parent.Text
                                    objSemItem_Year.GUID_Parent = objLocalConfig.SemItem_Type_Year.GUID
                                    objSemItem_Year.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                                End If
                            End If
                        End If
                        objUserControl_Galery = New UserControl_Galery(objSemItem_Year, objSemItem_Month, objSemItem_Day, objSemItems_Language, objLocalConfig)
                        objUserControl_Galery.allow_Edit = False
                        
                        objUserControl_Galery.Dock = DockStyle.Fill
                        SplitContainer1.Panel2.Controls.Add(objUserControl_Galery)
                    End If



                Case cint_ImageID_Attributes
                Case cint_ImageID_RelationTypes
                Case cint_ImageID_Token
                    objSemItem_Ref = New clsSemItem
                    objSemItem_Ref.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Ref.Name = objTreeNode.Text
                    objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    Select Case objSemItem_Type_Selected.GUID
                        Case objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                            objUserControl_Galery = New UserControl_Galery(objSemItem_Ref, objSemItems_Language, objLocalConfig)
                            objUserControl_Galery.allow_Edit = True
                            objUserControl_Galery.Dock = DockStyle.Fill
                            If objSemItem_ToRelate Is Nothing Then
                                objUserControl_Galery.Enable_Relation = False
                            Else
                                objUserControl_Galery.Enable_Relation = True
                            End If
                            SplitContainer1.Panel2.Controls.Add(objUserControl_Galery)
                        Case objLocalConfig.SemItem_Type_PDF_Documents.GUID
                            objUserControl_PDF = New UserControl_PDFViewer(objSemItem_Ref, objSemItems_Language, objLocalConfig)
                            objUserControl_PDF.Dock = DockStyle.Fill
                            If objSemItem_ToRelate Is Nothing Then
                                objUserControl_PDF.Enable_Relation = False
                            Else
                                objUserControl_PDF.Enable_Relation = True
                            End If
                            SplitContainer1.Panel2.Controls.Add(objUserControl_PDF)
                        Case objLocalConfig.SemItem_Type_Media_Item.GUID
                            objUserControl_MediaItem = New UserControl_MediaItem(objSemItem_Ref, objSemItems_Language, objLocalConfig)
                            objUserControl_MediaItem.Allow_Edit = True
                            objUserControl_MediaItem.Dock = DockStyle.Fill
                            If objSemItem_ToRelate Is Nothing Then
                                objUserControl_MediaItem.Enable_Relation = False
                            Else
                                objUserControl_MediaItem.Enable_Relation = True
                            End If
                            SplitContainer1.Panel2.Controls.Add(objUserControl_MediaItem)


                    End Select
                Case cint_ImageID_Token_Named
                    objSemItem_Ref = New clsSemItem
                    objSemItem_Ref.GUID = New Guid(objTreeNode.Name)
                    objSemItem_Ref.Name = objTreeNode.Text
                    objSemItem_Ref.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    objTreeNode_Parent = objTreeNode.Parent
                    objSemItem_Ref.GUID_Parent = New Guid(objTreeNode_Parent.Name)

                    objUserControl_Galery = New UserControl_Galery(objSemItem_Ref, objSemItems_Language, objLocalConfig, True)
                    objUserControl_Galery.allow_Edit = True
                    objUserControl_Galery.Dock = DockStyle.Fill
                    If objSemItem_ToRelate Is Nothing Then
                        objUserControl_Galery.Enable_Relation = False
                    Else
                        objUserControl_Galery.Enable_Relation = True
                    End If
                    SplitContainer1.Panel2.Controls.Add(objUserControl_Galery)
            End Select
        End If
    End Sub

    Private Sub ContextMenuStrip_Item_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Item.Opening
        Dim objTreeNode As TreeNode
        Dim objTreeNode_Parent As TreeNode

        NewToolStripMenuItem.Enabled = False
        SaveToolStripMenuItem.Enabled = False
        RelateToolStripMenuItem.Enabled = False
        ChangeParentToolStripMenuItem.Enabled = False
        RemoveFromTreeToolStripMenuItem.Enabled = False
        objTreeNode = TreeView_RelatedItems.SelectedNode
        If Not objTreeNode Is Nothing Then

            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Attributes
                    NewToolStripMenuItem.Enabled = True

                Case cint_ImageID_RelationTypes
                    NewToolStripMenuItem.Enabled = True

                Case cint_ImageID_Close, cint_ImageID_Close_Images, cint_ImageID_Close_Images_SubItems, cint_ImageID_Close_SubItems
                    RelateToolStripMenuItem.Enabled = True
                    NewToolStripMenuItem.Enabled = True
                    RemoveFromTreeToolStripMenuItem.Enabled = True
                Case cint_ImageID_Token
                    RelateToolStripMenuItem.Enabled = True
                    NewToolStripMenuItem.Enabled = True
                    RemoveFromTreeToolStripMenuItem.Enabled = True
                    objTreeNode_Parent = objTreeNode.Parent
                    If objTreeNode_Parent.ImageIndex = cint_ImageID_Close _
                        Or objTreeNode_Parent.ImageIndex = cint_ImageID_Close_Images _
                        Or objTreeNode_Parent.ImageIndex = cint_ImageID_Close_Images_SubItems _
                        Or objTreeNode_Parent.ImageIndex = cint_ImageID_Close_SubItems Then

                        ChangeParentToolStripMenuItem.Enabled = True
                    End If
                Case cint_ImageID_Close_RelateChoose
                    ChangeParentToolStripMenuItem.Enabled = True
                    RemoveFromTreeToolStripMenuItem.Enabled = True
                Case cint_ImageID_Root
                    If Not objTreeNode.Name = "Unknown" Then
                        NewToolStripMenuItem.Enabled = True
                        RemoveFromTreeToolStripMenuItem.Enabled = True
                    End If
            End Select

            If SubItem_With_Image(objTreeNode) Then
                SaveToolStripMenuItem.Enabled = True
            End If
        End If


    End Sub

    Private Function SubItem_With_Image(ByVal objTreeNode As TreeNode) As Boolean
        Dim boolResult As Boolean = False
        Dim objTreeNode_Sub As TreeNode
        If objTreeNode.ImageIndex = cint_ImageID_Close_Images Or _
            objTreeNode.ImageIndex = cint_ImageID_Close_Images_SubItems Then
            boolResult = True
        ElseIf objTreeNode.ImageIndex = cint_ImageID_Token Then
            boolResult = True
        Else
            For Each objTreeNode_Sub In objTreeNode.Nodes

                boolResult = SubItem_With_Image(objTreeNode_Sub)
                If boolResult = True Then
                    Exit For
                End If
            Next
        End If


        Return boolResult
    End Function
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objSemItem As New clsSemItem

        Dim objSemItem_Selected As clsSemItem



        objTreeNode = TreeView_RelatedItems.SelectedNode
        If Not objTreeNode Is Nothing Then
            Select Case objTreeNode.ImageIndex
                Case cint_ImageID_Attributes
                    objSemItem = objLocalConfig.Globals.ObjectReferenceType_Attribute
                Case cint_ImageID_RelationTypes
                    objSemItem = objLocalConfig.Globals.ObjectReferenceType_RelationType
                Case cint_ImageID_Close, cint_ImageID_Close_Images, cint_ImageID_Close_Images_SubItems, cint_ImageID_Close_SubItems
                    objSemItem.GUID = New Guid(objTreeNode.Name)
                    objSemItem.Name = objTreeNode.Text
                    objSemItem.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                    objFrmSemManager = New frmSemManager(objSemItem, objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)
                    If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                        add_Item()
                    End If
                Case cint_ImageID_Root
                    objFrmSemManager = New frmSemManager(objLocalConfig.Globals)
                    objFrmSemManager.Applyabale = True
                    objFrmSemManager.ShowDialog(Me)
                    If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
                        add_Item()
                    End If
            End Select
        End If
    End Sub

    Private Sub add_Item()
        Dim objTreeNodes() As TreeNode
        Dim objDGVR As DataGridViewRow
        Dim objDRV As DataRowView
        Dim objTreeNode_Parent As TreeNode
        Dim objTreeNode_ToInsert As TreeNode

        Select Case objFrmSemManager.SelectedItems_TypeGUID
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                For Each objDGVR In objFrmSemManager.SelectedRows_Items
                    objDRV = objDGVR.DataBoundItem



                Next
            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                For Each objDGVR In objFrmSemManager.SelectedRows_Items
                    objDRV = objDGVR.DataBoundItem
                Next
            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                For Each objDGVR In objFrmSemManager.SelectedRows_Items
                    objDRV = objDGVR.DataBoundItem


                    objTreeNodes = objTreeNode_Root.Nodes.Find(objDRV.Item("GUID_Token").ToString, True)
                    If objTreeNodes.Count > 0 Then
                        TreeView_RelatedItems.SelectedNode = objTreeNodes(0)
                    Else
                        objTreeNodes = objTreeNode_Root.Nodes.Find(objDRV.Item("GUID_Type").ToString, True)
                        If objTreeNodes.Count = 0 Then
                            get_Parent(objDRV.Item("GUID_Type"))
                            fill_Tree_semantic()
                        End If
                        objTreeNodes = objTreeNode_Root.Nodes.Find(objDRV.Item("GUID_Type").ToString, True)

                        objTreeNode_ToInsert = objTreeNodes(0).Nodes.Add(objDRV.Item("GUID_Token").ToString, _
                                                                        objDRV.Item("Name_Token"), _
                                                                        cint_ImageID_Token, cint_ImageID_Token)
                        TreeView_RelatedItems.SelectedNode = objTreeNode_ToInsert
                    End If


                Next
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                For Each objSemItem_Selected In objFrmSemManager.SemItems_Selected

                Next
        End Select
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim strPath As String

        objTreeNode = TreeView_RelatedItems.SelectedNode
        If Not objTreeNode Is Nothing Then
            If FolderBrowserDialog_Export.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                strPath = FolderBrowserDialog_Export.SelectedPath
                create_Folders_And_Media(strPath, objTreeNode)
            End If

        End If
    End Sub

    Private Function create_Folders_And_Media(ByVal strPath As String, ByVal objTreeNode As TreeNode) As clsSemItem
        Dim Chars_Invalid() As Char
        Dim CharInvalid As Char
        Dim objDRC_OR As DataRowCollection
        Dim objDR_Or As DataRow
        Dim objDRC_Image As DataRowCollection
        Dim objDR_Image As DataRow
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_MediaType As clsSemItem
        Dim objTreeNode_Sub As TreeNode
        Dim strFileName As String
        Dim strPath_Create As String
        Dim strName_Row As String
        Dim strPathFile As String
        Dim strID As String

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        objSemItem_MediaType = ToolStripComboBox_MediaType.ComboBox.SelectedItem

        If RefAsFolderToolStripMenuItem.Checked = True Then
            strPath_Create = objTreeNode.Text
        Else
            strPath_Create = strPath
        End If

        If IO.Directory.Exists(strPath) Then
            Chars_Invalid = IO.Path.GetInvalidPathChars()
            For Each CharInvalid In Chars_Invalid
                strPath_Create = strPath_Create.Replace(CharInvalid, "_")
            Next

            If RefAsFolderToolStripMenuItem.Checked = True Then
                strPath_Create = strPath & "\" & strPath_Create
            Else
                strPath_Create = strPath
            End If

            Try
                If IO.Directory.Exists(strPath_Create) = False Then
                    IO.Directory.CreateDirectory(strPath_Create)
                End If

                If objTreeNode.ImageIndex = cint_ImageID_Attribute Or _
                    objTreeNode.ImageIndex = cint_ImageID_Close_Images Or _
                    objTreeNode.ImageIndex = cint_ImageID_Close_Images_SubItems Or _
                    objTreeNode.ImageIndex = cint_ImageID_RelationType Or _
                    objTreeNode.ImageIndex = cint_ImageID_Token Then
                    objDRC_OR = Nothing
                    Select Case objTreeNode.ImageIndex
                        Case cint_ImageID_Attribute
                            objDRC_OR = semtblA_OR_Attribute.GetData_By_GUIDAttribute(New Guid(objTreeNode.Name)).Rows

                        Case cint_ImageID_Close_Images
                            objDRC_OR = semtblA_OR_Type.GetData_By_GUIDType(New Guid(objTreeNode.Name)).Rows

                        Case cint_ImageID_Close_Images_SubItems
                            objDRC_OR = semtblA_OR_Type.GetData_By_GUIDType(New Guid(objTreeNode.Name)).Rows

                        Case cint_ImageID_RelationType
                            objDRC_OR = semtblA_OR_RelationType.GetData_By_GUIDRelationType(New Guid(objTreeNode.Name)).Rows

                        Case cint_ImageID_Token
                            objDRC_OR = semtblA_OR_Token.GetData_By_GUIDToken(New Guid(objTreeNode.Name)).Rows

                    End Select
                    If Not objDRC_OR Is Nothing Then

                        For Each objDR_Or In objDRC_OR
                            Select Case objSemItem_MediaType.GUID
                                Case objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                                    objDRC_Image = procA_Image_Of_Or.GetData(objLocalConfig.SemItem_Type_Images__Graphic_.GUID, _
                                                                             objLocalConfig.SemItem_Type_File.GUID, _
                                                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                 objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                 objDR_Or.Item("GUID_ObjectReference")).Rows
                                    strName_Row = "Name_Images__Graphic_"
                                Case objLocalConfig.SemItem_Type_Media_Item.GUID
                                    objDRC_Image = procA_MediaItem_Of_Or.GetData(objLocalConfig.SemItem_Type_Media_Item.GUID, _
                                                                                 objLocalConfig.SemItem_Type_File.GUID, _
                                                                                 objLocalConfig.SemItem_Type_Media_Item_Bookmark.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                 objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                                 objDR_Or.Item("GUID_ObjectReference")).Rows
                                    strName_Row = "Name_Media_Item"
                                Case objLocalConfig.SemItem_Type_PDF_Documents.GUID
                                    objDRC_Image = procA_PDF_Of_Or.GetData(objLocalConfig.SemItem_Type_PDF_Documents.GUID, _
                                                                           objLocalConfig.SemItem_Type_File.GUID, _
                                                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                 objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                 objDR_Or.Item("GUID_ObjectReference")).Rows
                                    strName_Row = "Name_PDF_Documents"
                            End Select

                            For Each objDR_Image In objDRC_Image
                                objSemItem_File.GUID = objDR_Image.Item("GUID_File")
                                If GUIDAsNameToolStripMenuItem.Checked = True Then
                                    strFileName = objDR_Image.Item("GUID_File").ToString
                                    objSemItem_File.Name = strFileName.Replace("-", "")

                                Else
                                    strFileName = objDR_Image.Item("Name_File")
                                    If strFileName.LastIndexOf(".") > 0 Then
                                        strFileName = strFileName.Substring(strFileName.LastIndexOf("."))
                                    End If
                                    objSemItem_File.Name = objDR_Image.Item(strName_Row)

                                    objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                                    objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    strID = ""
                                    For i = 4 To objDR_Image.Item("OrderID").ToString.Length Step -1
                                        strID = strID & "0"
                                    Next
                                    strID = strID & objDR_Image.Item("OrderID").ToString

                                    
                                    objSemItem_File.Name = objSemItem_File.Name & strID & strFileName

                                End If

                                


                                'strFileName = "Abb. " & strID & ".jpg"
                                strPathFile = strPath_Create & "\" & objSemItem_File.Name
                                If IO.File.Exists(strPathFile) = False Then
                                    objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPathFile)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                        Exit For
                                    End If
                                End If
                                
                            Next
                        Next



                    End If

                End If
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    If SubnodesToolStripMenuItem.Checked = True Then
                        For Each objTreeNode_Sub In objTreeNode.Nodes
                            objSemItem_Result = create_Folders_And_Media(strPath_Create, objTreeNode_Sub)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                Exit For
                            End If
                        Next
                    End If
                    
                End If
            Catch ex As Exception
                MsgBox("Die Bilder können nicht exportiert werden!", MsgBoxStyle.Exclamation)

            End Try

        Else
            MsgBox("Der Pfad existiert nicht!", MsgBoxStyle.Exclamation)
        End If

        Return objSemItem_Result
    End Function

    Private Sub ToolStripComboBox_MediaType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_MediaType.SelectedIndexChanged
        selected_MediaType()
    End Sub

    Private Sub selected_MediaType()
        ToolStripButton_Meta.Enabled = False
        If boolPChange_MediaType = False Then
            If Not ToolStripComboBox_MediaType.ComboBox.SelectedItem Is Nothing Then
                If ToolStripButton_OpenGrid.Checked = False Then

                    Select Case ToolStripComboBox_MediaType.SelectedItem.guid
                        Case objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                            initialize(objLocalConfig.SemItem_Type_Images__Graphic_)
                            ToolStripButton_Meta.Enabled = True
                        Case objLocalConfig.SemItem_Type_PDF_Documents.GUID
                            initialize(objLocalConfig.SemItem_Type_PDF_Documents)

                        Case objLocalConfig.SemItem_Type_Media_Item.GUID
                            initialize(objLocalConfig.SemItem_Type_Media_Item)
                            ToolStripButton_Meta.Enabled = True

                        Case objSemItem_Empty.GUID
                            initialize(Nothing)

                    End Select


                Else
                    objFrmImageModule_Grid = New frmMediaModule_Grid(objLocalConfig, ToolStripComboBox_MediaType.SelectedItem)
                    objFrmImageModule_Grid.ShowDialog(Me)
                End If
            End If
            

        End If
        config_SearchTemplates()
    End Sub

    Private Sub ToolStripTextBox_Filter_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox_Filter.TextChanged
        Timer_Filter.Stop()
        If ToolStripTextBox_Filter.ReadOnly = False Then
            If ToolStripButton_Filter.Checked = True Then
                Timer_Filter.Start()
            End If

        End If
    End Sub

    Private Sub ToolStripButton_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Filter.Click
        Timer_Filter.Stop()
        clear_Mark()
        If ToolStripButton_Filter.Checked = True Then
            ToolStripTextBox_Filter.ReadOnly = True
            ToolStripTextBox_Filter.Text = ""
            ToolStripTextBox_Filter.ReadOnly = False
            ToolStripButton_Filter.Checked = False
        Else
            ToolStripButton_Filter.Checked = True
        End If

        Timer_Filter.Start()
    End Sub

    Private Sub Timer_Filter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Filter.Tick
        Dim objTreeNodes() As TreeNode
        Timer_Filter.Stop()
        clear_Mark()
        Select Case ToolStripComboBox_SearchTemplate.ComboBox.SelectedValue
            Case objLocalConfig.SemItem_Token_Search_Template_Name_.GUID
                If objLocalConfig.Globals.is_GUID(ToolStripTextBox_Filter.Text) Then
                    objTreeNodes = TreeView_RelatedItems.Nodes.Find(ToolStripTextBox_Filter.Text, True)
                    If objTreeNodes.Count > 0 Then
                        TreeView_RelatedItems.SelectedNode = objTreeNodes(0)
                    End If
                Else

                    If ToolStripTextBox_Filter.Text.Length > 0 Then
                        mark_Node(ToolStripTextBox_Filter.Text)
                    End If

                End If

        End Select
    End Sub

    Private Sub clear_Mark(Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode

        If objTreeNode Is Nothing Then
            For Each objTreeNode_Sub In TreeView_RelatedItems.Nodes
                objTreeNode_Sub.BackColor = Nothing
                clear_Mark(objTreeNode_Sub)
            Next
        Else
            For Each objTreeNode_Sub In objTreeNode.Nodes
                objTreeNode_Sub.BackColor = Nothing
                clear_Mark(objTreeNode_Sub)
            Next
        End If
    End Sub

    Private Sub mark_Node(ByVal strFilter As String, Optional ByVal objTreeNode As TreeNode = Nothing)
        Dim objTreeNode_Sub As TreeNode
        If objTreeNode Is Nothing Then
            For Each objTreeNode_Sub In TreeView_RelatedItems.Nodes
                If objTreeNode_Sub.Text.ToString.ToLower.Contains(strFilter.ToLower) Then
                    objTreeNode_Sub.BackColor = Color.Yellow
                    expand_Parents(objTreeNode_Sub)
                End If
                mark_Node(strFilter, objTreeNode_Sub)
            Next
        Else
            For Each objTreeNode_Sub In objTreeNode.Nodes
                If objTreeNode_Sub.Text.ToString.ToLower.Contains(strFilter.ToLower) Then
                    objTreeNode_Sub.BackColor = Color.Yellow
                    expand_Parents(objTreeNode_Sub)
                End If
                mark_Node(strFilter, objTreeNode_Sub)
            Next
        End If
    End Sub

    Private Sub expand_Parents(ByVal objTreeNode As TreeNode)
        Dim objTreeNode_Parent As TreeNode

        objTreeNode_Parent = objTreeNode.Parent
        If Not objTreeNode_Parent Is Nothing Then
            objTreeNode_Parent.Expand()
            expand_Parents(objTreeNode_Parent)
        End If
    End Sub

    Private Sub TreeView_RelatedItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView_RelatedItems.DoubleClick
        Dim objSemItem_Token As New clsSemItem
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_RelatedItems.SelectedNode

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Token Then
                objSemItem_Token.GUID = New Guid(objTreeNode.Name)
                objSemItem_Token.Name = objTreeNode.Text
                If objTreeNode.Parent.ImageIndex = cint_ImageID_Close_RelateChoose Then
                    objSemItem_Token.GUID_Parent = New Guid(objTreeNode.Parent.Parent.Name)
                Else
                    objSemItem_Token.GUID_Parent = New Guid(objTreeNode.Parent.Name)
                End If

                objSemItem_Token.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objFrmTokenEdit = New frmTokenEdit(objSemItem_Token, objLocalConfig.Globals)
                objFrmTokenEdit.ShowDialog(Me)

            End If
        End If
    End Sub

    Private Sub ToolStripButton_Meta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Meta.Click
        Select Case ToolStripComboBox_MediaType.SelectedItem.guid
            Case objLocalConfig.SemItem_Type_Images__Graphic_.GUID
                objImageInfo.start_Getting_Chronical()

            Case objLocalConfig.SemItem_Type_PDF_Documents.GUID


            Case objLocalConfig.SemItem_Type_Media_Item.GUID
                objMediaInfo.start_Getting_Meta()

            Case objSemItem_Empty.GUID


        End Select

    End Sub

    Private Sub ToolStripMenuItem_Semantic_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_Semantic.CheckStateChanged

    End Sub

    Private Sub ToolStripMenuItem_Semantic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_Semantic.Click
        If ToolStripMenuItem_Semantic.Checked = False Then
            ToolStripMenuItem_Semantic.Checked = True
            ToolStripMenuItem_ChronoSemantic.Checked = False
            ToolStripMenuItem_Chrono.Checked = False
            NamedSemanticsToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub ToolStripMenuItem_Chrono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_Chrono.Click
        If ToolStripMenuItem_Chrono.Checked = False Then
            ToolStripMenuItem_Chrono.Checked = True
            ToolStripMenuItem_Semantic.Checked = False
            ToolStripMenuItem_ChronoSemantic.Checked = False
            NamedSemanticsToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub ToolStripMenuItem_ChronoSemantic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_ChronoSemantic.Click
        If ToolStripMenuItem_ChronoSemantic.Checked = False Then
            ToolStripMenuItem_ChronoSemantic.Checked = True
            ToolStripMenuItem_Chrono.Checked = False
            ToolStripMenuItem_Semantic.Checked = False
            NamedSemanticsToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub RelateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelateToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        Dim objTreeNode_Parent As TreeNode

        ToolStripLabel_LastRelation.Text = "/"

        objTreeNode = TreeView_RelatedItems.SelectedNode
        objSemItem_ToRelate = Nothing
        If Not objUserControl_Galery Is Nothing Then
            objUserControl_Galery.Enable_Relation = False
        End If
        If Not objUserControl_MediaItem Is Nothing Then
            objUserControl_MediaItem.Enable_Relation = True
        End If

        If Not objTreeNode Is Nothing Then
            If objTreeNode.ImageIndex = cint_ImageID_Close Or _
                objTreeNode.ImageIndex = cint_ImageID_Close_Images Or _
                objTreeNode.ImageIndex = cint_ImageID_Close_SubItems Or _
                objTreeNode.ImageIndex = cint_ImageID_Close_Images_SubItems Then

                objSemItem_ToRelate.GUID = New Guid(objTreeNode.Name)
                objSemItem_ToRelate.Name = objTreeNode.Text
                objSemItem_ToRelate.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objSemItem_ToRelate.Additional1 = objTreeNode.FullPath

            ElseIf objTreeNode.ImageIndex = cint_ImageID_Token Then
                objSemItem_ToRelate = New clsSemItem
                objSemItem_ToRelate.GUID = New Guid(objTreeNode.Name)
                objSemItem_ToRelate.Name = objTreeNode.Text

                objSemItem_ToRelate.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objTreeNode_Parent = objTreeNode.Parent

                objSemItem_ToRelate.GUID_Parent = New Guid(objTreeNode_Parent.Name)

                objSemItem_ToRelate.Additional1 = objTreeNode.FullPath

            End If

            If Not objSemItem_ToRelate Is Nothing Then
                If Not objUserControl_MediaItem Is Nothing Then
                    objUserControl_MediaItem.Enable_Relation = True
                End If
                If Not objUserControl_Galery Is Nothing Then
                    objUserControl_Galery.Enable_Relation = True
                End If
                ToolStripLabel_LastRelation.Text = objSemItem_ToRelate.Additional1 & " / "

            End If
        End If
    End Sub

    Private Sub NamedSemanticsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NamedSemanticsToolStripMenuItem.Click
        If NamedSemanticsToolStripMenuItem.Checked = True Then
            ToolStripMenuItem_ChronoSemantic.Checked = False
            ToolStripMenuItem_Chrono.Checked = False
            ToolStripMenuItem_Semantic.Checked = False

        End If
    End Sub

    Private Sub ChangeParentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeParentToolStripMenuItem.Click
        Dim objTreeNode As TreeNode
        Dim objTreeNodes() As TreeNode
        Dim objTreeNode_Parent As TreeNode
        Dim objTreeNode_NewParent As TreeNode
        Dim objTreeNode_NewChild As New TreeNode
        Dim objSemItem_Choosen As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_Related As DataRowCollection
        Dim objDR_Related As DataRow
        Dim strGUIDs() As String
        Dim strGUID As String
        Dim i As Integer
        Dim j As Integer

        clear_Mark()

        objTreeNode = TreeView_RelatedItems.SelectedNode
        If Not objTreeNode Is Nothing Then

            If objTreeNode.ImageIndex = cint_ImageID_Token _
                Or objTreeNode.ImageIndex = cint_ImageID_Close_RelateChoose Then

                objTreeNode_Parent = objTreeNode.Parent
                If objTreeNode_Parent.ImageIndex = cint_ImageID_Close _
                        Or objTreeNode_Parent.ImageIndex = cint_ImageID_Close_Images _
                        Or objTreeNode_Parent.ImageIndex = cint_ImageID_Close_Images_SubItems _
                        Or objTreeNode_Parent.ImageIndex = cint_ImageID_Close_SubItems Then

                    If Not objTreeNode.Name = "Unknown" Then
                        If objTreeNode.ImageIndex = cint_ImageID_Close_RelateChoose Then
                            strGUIDs = objTreeNode.Name.Split("_")
                            objSemItem_Choosen.GUID = New Guid(strGUIDs(0))
                            objSemItem_Choosen.GUID_Parent = New Guid(strGUIDs(1))
                        Else
                            objSemItem_Choosen.GUID = New Guid(objTreeNode.Name)
                            objSemItem_Choosen.GUID_Parent = New Guid(objTreeNode_Parent.Name)
                        End If

                        objSemItem_Choosen.Name = objTreeNode.Text

                        objSemItem_Choosen.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objFrmChooseRelation = New frmRelationChoose(objLocalConfig.Globals, objSemItem_Choosen)
                        objFrmChooseRelation.ShowDialog(Me)
                        If objFrmChooseRelation.DialogResult = Windows.Forms.DialogResult.OK Then
                            objSemItem_Result = objFrmChooseRelation.SemItem_Result
                            If objSemItem_Result.Rel_ObjectReference = False Then
                                If objSemItem_Result.Direction = objSemItem_Result.Direction_LeftRight Then
                                    For Each objTreeNode In objTreeNode_Parent.Nodes

                                        If Not objTreeNode Is Nothing Then
                                            If objTreeNode.ImageIndex = cint_ImageID_Token _
                                                Or objTreeNode.ImageIndex = cint_ImageID_Close_RelateChoose Then

                                                If Not objTreeNode.Name = "Unknown" Then
                                                    objTreeNode.BackColor = Color.Yellow
                                                    If objTreeNode.ImageIndex = cint_ImageID_Close_RelateChoose Then
                                                        strGUIDs = objTreeNode.Name.Split("_")
                                                        strGUID = strGUIDs(0)
                                                    Else
                                                        strGUID = objTreeNode.Name
                                                    End If

                                                    objDRC_Related = funcA_TokenToken.GetData_TokenToken_LeftRight(New Guid(strGUID), _
                                                                                                           objSemItem_Result.GUID_Relation, _
                                                                                                           objSemItem_Result.GUID).Rows

                                                    objTreeNode_NewChild.Name = objTreeNode.Name
                                                    objTreeNode_NewChild.Text = objTreeNode.Text

                                                    If objDRC_Related.Count > 0 Then
                                                        For Each objDR_Related In objDRC_Related
                                                            objTreeNodes = objTreeNode_Parent.Nodes.Find(objDR_Related.Item("GUID_Token_Right").ToString & "_" & objDR_Related.Item("GUID_Type_Right").ToString & "_" & objDR_Related.Item("GUID_RelationType").ToString, False)
                                                            If objTreeNodes.Count = 0 Then
                                                                objTreeNode_NewParent = objTreeNode_Parent.Nodes.Add(objDR_Related.Item("GUID_Token_Right").ToString & "_" & objDR_Related.Item("GUID_Type_Right").ToString & "_" & objDR_Related.Item("GUID_RelationType").ToString, _
                                                                                                                 objDR_Related.Item("Name_Token_Right"), _
                                                                                                                 cint_ImageID_Close_RelateChoose, cint_ImageID_Open_RelateChoose)
                                                            Else
                                                                objTreeNode_NewParent = objTreeNodes(0)
                                                            End If

                                                            If objTreeNode.ImageIndex = cint_ImageID_Token Then
                                                                objTreeNode_NewParent.Nodes.Add(objTreeNode_NewChild.Name, objTreeNode_NewChild.Text, cint_ImageID_Token, cint_ImageID_Token)
                                                            Else
                                                                For j = 0 To objTreeNode.Nodes.Count - 1
                                                                    objTreeNode_NewParent.Nodes.Add(objTreeNode.Nodes(j).Name, objTreeNode.Nodes(j).Text, objTreeNode.Nodes(j).ImageIndex, objTreeNode.Nodes(j).SelectedImageIndex)
                                                                Next
                                                            End If


                                                        Next
                                                    Else

                                                        objTreeNodes = objTreeNode_Parent.Nodes.Find("Unknown", False)
                                                        If objTreeNodes.Count = 0 Then
                                                            objTreeNode_NewParent = objTreeNode_Parent.Nodes.Add("Unknown", "Unknown", cint_ImageID_Close_RelateChoose, cint_ImageID_Open_RelateChoose)

                                                        Else
                                                            objTreeNode_NewParent = objTreeNodes(0)
                                                        End If
                                                        objTreeNode_NewParent.Nodes.Add(objTreeNode_NewChild.Name, objTreeNode_NewChild.Text, cint_ImageID_Token, cint_ImageID_Token)

                                                    End If
                                                Else

                                                End If

                                            End If

                                        End If


                                    Next

                                    For i = objTreeNode_Parent.Nodes.Count - 1 To 0 Step -1
                                        If objTreeNode_Parent.Nodes(i).BackColor = Color.Yellow Then
                                            objTreeNode_Parent.Nodes(i).Remove()
                                        End If
                                    Next


                                Else
                                    For Each objTreeNode In objTreeNode_Parent.Nodes
                                        If Not objTreeNode Is Nothing Then
                                            If objTreeNode.ImageIndex = cint_ImageID_Token _
                                                Or objTreeNode.ImageIndex = cint_ImageID_Close_RelateChoose Then

                                                If Not objTreeNode.Name = "Unknown" Then
                                                    objTreeNode.BackColor = Color.Yellow
                                                    If objTreeNode.ImageIndex = cint_ImageID_Close_RelateChoose Then
                                                        strGUIDs = objTreeNode.Name.Split("_")
                                                        strGUID = strGUIDs(0)
                                                    Else
                                                        strGUID = objTreeNode.Name
                                                    End If

                                                    objDRC_Related = funcA_TokenToken.GetData_TokenToken_RightLeft(New Guid(strGUID), _
                                                                                                           objSemItem_Result.GUID_Relation, _
                                                                                                           objSemItem_Result.GUID).Rows
                                                    objTreeNode_NewChild.Name = objTreeNode.Name
                                                    objTreeNode_NewChild.Text = objTreeNode.Text

                                                    If objDRC_Related.Count > 0 Then
                                                        For Each objDR_Related In objDRC_Related
                                                            objTreeNodes = objTreeNode_Parent.Nodes.Find(objDR_Related.Item("GUID_Token_Left").ToString & "_" & objDR_Related.Item("GUID_Type_Left").ToString & "_" & objDR_Related.Item("GUID_RelationType").ToString, False)
                                                            If objTreeNodes.Count = 0 Then
                                                                objTreeNode_NewParent = objTreeNode_Parent.Nodes.Add(objDR_Related.Item("GUID_Token_Left").ToString & "_" & objDR_Related.Item("GUID_Type_Left").ToString & "_" & objDR_Related.Item("GUID_RelationType").ToString, _
                                                                                                                 objDR_Related.Item("Name_Token_Left"), _
                                                                                                                 cint_ImageID_Close_RelateChoose, cint_ImageID_Open_RelateChoose)
                                                            Else
                                                                objTreeNode_NewParent = objTreeNodes(0)
                                                            End If

                                                            If objTreeNode.ImageIndex = cint_ImageID_Token Then
                                                                objTreeNode_NewParent.Nodes.Add(objTreeNode_NewChild.Name, objTreeNode_NewChild.Text, cint_ImageID_Token, cint_ImageID_Token)
                                                            Else
                                                                For j = 0 To objTreeNode.Nodes.Count - 1
                                                                    objTreeNode_NewParent.Nodes.Add(objTreeNode.Nodes(j).Name, objTreeNode.Nodes(j).Text, objTreeNode.Nodes(j).ImageIndex, objTreeNode.Nodes(j).SelectedImageIndex)
                                                                Next
                                                            End If
                                                            


                                                        Next
                                                    Else

                                                        objTreeNodes = objTreeNode_Parent.Nodes.Find("Unknown", False)
                                                        If objTreeNodes.Count = 0 Then
                                                            objTreeNode_NewParent = objTreeNode_Parent.Nodes.Add("Unknown", "Unknown", cint_ImageID_Close_RelateChoose, cint_ImageID_Open_RelateChoose)

                                                        Else
                                                            objTreeNode_NewParent = objTreeNodes(0)
                                                        End If
                                                        objTreeNode_NewParent.Nodes.Add(objTreeNode_NewChild.Name, objTreeNode_NewChild.Text, cint_ImageID_Token, cint_ImageID_Token)

                                                    End If
                                                End If

                                            End If

                                        End If

                                    Next

                                    For i = objTreeNode_Parent.Nodes.Count - 1 To 0 Step -1
                                        If objTreeNode_Parent.Nodes(i).BackColor = Color.Yellow Then
                                            
                                            objTreeNode_Parent.Nodes(i).Remove()
                                        End If
                                    Next
                                End If
                            Else
                                MsgBox("Objekt-Referenzen sind noch nicht möglich!", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    End If

                End If

            End If
        End If
        TreeView_RelatedItems.Sort()
    End Sub

    Private Sub TreeView_RelatedItems_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView_RelatedItems.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                selected_MediaType()
        End Select
    End Sub

    Private Sub RemoveFromTreeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFromTreeToolStripMenuItem.Click
        Dim objTreeNode As TreeNode

        objTreeNode = TreeView_RelatedItems.SelectedNode
        If Not objTreeNode Is Nothing Then
            objTreeNode.Remove()
        End If

    End Sub
End Class