Public Class clsModule

    Private funcT_related_ModuleActivator_With_RelatedObjectReferences As New ds_ModuleManagement.func_ModuleActivator_With_RelatedObjectReferencesDataTable
    Private funcT_related_ModuleActivators_With_RelatedObjectReferenceType As New ds_ModuleManagement.func_ModuleActivator_With_RelatedObjectReferenceTypesDataTable
    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private objLocalConfig As clsLocalConfig_SemManager
    'Private objLocalConfig As clsLocalConfig_ModuleManagement
    Private strLocation As String
    Private objModule As Object
    Private boolActive As Boolean
    Private boolValid As Boolean
    Private objSemItem_Module As clsSemItem
    Private objSemItem_IntegrationLevel As clsSemItem
    Private GUID_Module As Guid
    Private Name_Module As String
    Private boolEdit As Boolean

    Public Property Editable As Boolean
        Get
            Return boolEdit
        End Get
        Set(ByVal value As Boolean)
            boolEdit = value
        End Set
    End Property

    Public Property Location() As String
        Get
            Return strLocation
        End Get
        Set(ByVal value As String)
            strLocation = value
        End Set
    End Property

    Public ReadOnly Property GUID_LoadedModule() As Guid
        Get
            Return GUID_Module
        End Get
      
    End Property
    Public ReadOnly Property Name_LoadedModule() As String
        Get
            Return Name_Module
        End Get
    End Property

    Public Function Object_OK(ByVal objSemItem_ObjectToTest As clsSemItem, Optional ByVal boolMenu As Boolean = False) As Boolean
        Dim objDRs_ObjectReferences() As DataRow
        Dim objDR_ObjectReferenceTypes As DataRow
        Dim boolResult As Boolean = False


        objDRs_ObjectReferences = funcT_related_ModuleActivator_With_RelatedObjectReferences.Select("GUID_Ref='" & objSemItem_ObjectToTest.GUID.ToString & "'")
        If objDRs_ObjectReferences.Count > 0 Then
            boolResult = True
        Else
            If objSemItem_IntegrationLevel.GUID = objLocalConfig.SemItem_Token_Integration_Level_Menu.GUID Then
                If boolMenu = True Then
                    boolResult = True
                End If
            Else
                For Each objDR_ObjectReferenceTypes In funcT_related_ModuleActivators_With_RelatedObjectReferenceType.Rows
                    Select Case objSemItem_ObjectToTest.GUID_Type
                        Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                            If Not IsDBNull(objDR_ObjectReferenceTypes.Item("Attribute")) Then
                                boolResult = objDR_ObjectReferenceTypes.Item("Attribute")
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                            If Not IsDBNull(objDR_ObjectReferenceTypes.Item("RelationType")) Then
                                boolResult = objDR_ObjectReferenceTypes.Item("RelationType")
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                            If Not IsDBNull(objDR_ObjectReferenceTypes.Item("Token")) Then
                                boolResult = objDR_ObjectReferenceTypes.Item("Token")
                            End If
                        Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                            If Not IsDBNull(objDR_ObjectReferenceTypes.Item("Type")) Then
                                boolResult = objDR_ObjectReferenceTypes.Item("Type")
                            End If

                    End Select
                Next
            End If
            
            
            

        End If



        Return boolResult
    End Function
    Public WriteOnly Property funcT_RelatedObjectReferences() As ds_ModuleManagement.func_ModuleActivator_With_RelatedObjectReferencesDataTable
        Set(ByVal value As ds_ModuleManagement.func_ModuleActivator_With_RelatedObjectReferencesDataTable)
            Dim objDR_Row As DataRow
            For Each objDR_Row In value.Rows
                funcT_related_ModuleActivator_With_RelatedObjectReferences.Rows.Add(objDR_Row.Item(0), objDR_Row.Item(1), objDR_Row.Item(2), objDR_Row.Item(3), objDR_Row.Item(4), objDR_Row.Item(5))

            Next
        End Set
    End Property

    Public WriteOnly Property funcT_RelatedObjectReferenceTypes() As ds_ModuleManagement.func_ModuleActivator_With_RelatedObjectReferenceTypesDataTable
        Set(ByVal value As ds_ModuleManagement.func_ModuleActivator_With_RelatedObjectReferenceTypesDataTable)
            Dim objDR_Row As DataRow
            For Each objDR_Row In value.Rows
                funcT_related_ModuleActivators_With_RelatedObjectReferenceType.Rows.Add(objDR_Row.Item(0), objDR_Row.Item(1), objDR_Row.Item(2), objDR_Row.Item(3), objDR_Row.Item(4), objDR_Row.Item(5), objDR_Row.Item(6), objDR_Row.Item(7), objDR_Row.Item(8), objDR_Row.Item(9), objDR_Row.Item(10))

            Next
            'funcT_related_ModuleActivators_With_RelatedObjectReferenceType = value.Clone
        End Set
    End Property

    Public ReadOnly Property IntegrationLevel_Information() As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Information_Integration_Level
        End Get
    End Property
    Public ReadOnly Property IntegrationLevel_Objecttype() As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Type_Integration_Level
        End Get
    End Property
    Public ReadOnly Property IntegrationLevel_Full() As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Full_Integration_Level
        End Get
    End Property

    Public ReadOnly Property IntegrationLevel_Filter() As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Filter_Integration_Level
        End Get
    End Property

    Public ReadOnly Property IntegrationLevel_Menu As clsSemItem
        Get
            Return objLocalConfig.SemItem_Token_Integration_Level_Menu
        End Get
    End Property

    Public Property IntegrationLevel() As clsSemItem
        Get
            Return objSemItem_IntegrationLevel
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_IntegrationLevel = value
        End Set
    End Property

    Public WriteOnly Property SemItem_Module() As clsSemItem
        
        Set(ByVal value As clsSemItem)
            GUID_Module = value.GUID
            Name_Module = value.Name

        End Set
    End Property
    Public Property loaded_Module() As Object
        Get
            Return objModule
        End Get
        Set(ByVal value As Object)
            objModule = value
        End Set
    End Property

    Public Property Active() As Boolean
        Get
            Return boolActive
        End Get
        Set(ByVal value As Boolean)
            boolActive = value
        End Set
    End Property

    Public Property Valid() As Boolean
        Get
            Return boolValid
        End Get
        Set(ByVal value As Boolean)
            boolValid = value
        End Set
    End Property

    Public Sub New(ByVal LocalConfig As clsLocalConfig_SemManager)
        objLocalConfig = LocalConfig

    End Sub

    Public Sub New()

    End Sub


End Class
