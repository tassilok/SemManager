Imports Sem_Manager
Public Class clsLanguage

    Private funcA_Standard_Language As New ds_BaseDataTableAdapters.func_Standard_LanguageTableAdapter
    Private funcT_Standard_Language As New ds_BaseData.func_Standard_LanguageDataTable
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcT_TokenToken As New ds_Token.func_TokenTokenDataTable

    Private objSemItem_Development As clsSemItem
    Private objSemItems_Languages() As clsSemItem

    Public ReadOnly Property supported_Languages() As clsSemItem()
        Get
            Return objSemItems_Languages
        End Get

    End Property
    Private Sub get_Languages()
        If Not objSemItem_Development Is Nothing Then
            If objSemItem_Development.GUID_Related = Nothing Then
                funcA_Standard_Language.Fill_By_GUIDDevelopment(funcT_Standard_Language, _
                                                                objLocalConfig.SemItem_Type_Language.GUID, _
                                                                objLocalConfig.SemItem_RelationType_Standard.GUID, _
                                                                objSemItem_Development.GUID)

                funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_TokenToken, _
                                                           objSemItem_Development.GUID, _
                                                           objLocalConfig.SemItem_RelationType_additional.GUID, _
                                                           objLocalConfig.SemItem_Type_Language.GUID)
            Else
                funcA_Standard_Language.Fill_By_GUIDDevelopment(funcT_Standard_Language, _
                                                                objLocalConfig.SemItem_Type_Language.GUID, _
                                                                objLocalConfig.SemItem_RelationType_Standard.GUID, _
                                                                objSemItem_Development.GUID_Related)
                funcA_TokenToken.Fill_TokenToken_LeftRight(funcT_TokenToken, _
                                                           objSemItem_Development.GUID_Related, _
                                                           objLocalConfig.SemItem_RelationType_additional.GUID, _
                                                           objLocalConfig.SemItem_Type_Language.GUID)
            End If
            If funcT_Standard_Language.Rows.Count > 0 Then
                ReDim Preserve objSemItems_Languages(0)
                objSemItems_Languages(0) = New clsSemItem
                objSemItems_Languages(0).GUID = funcT_Standard_Language.Rows(0).Item("GUID_Token")
                objSemItems_Languages(0).Name = funcT_Standard_Language.Rows(0).Item("Name_Token")
                objSemItems_Languages(0).GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
                objSemItems_Languages(0).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItems_Languages(0).Mark = True

            End If
            If funcT_TokenToken.Rows.Count > 0 Then
                Dim intCountLanguages As Integer
                If objSemItems_Languages Is Nothing Then
                    intCountLanguages = 0

                Else
                    intCountLanguages = objSemItems_Languages.Length
                End If
                ReDim Preserve objSemItems_Languages(intCountLanguages)
                objSemItems_Languages(intCountLanguages) = New clsSemItem
                objSemItems_Languages(intCountLanguages).GUID = funcT_TokenToken.Rows(0).Item("GUID_Token_Right")
                objSemItems_Languages(intCountLanguages).Name = funcT_TokenToken.Rows(0).Item("Name_Token_Right")
                objSemItems_Languages(intCountLanguages).GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
                objSemItems_Languages(intCountLanguages).GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            End If

        Else
            objSemItems_Languages = Nothing
        End If

    End Sub

    Public Sub New(ByVal SemItem_Development As clsSemItem)
        objSemItem_Development = SemItem_Development
        set_DBConnection()
        get_Languages()
    End Sub

    Private Sub set_DBConnection()
        funcA_Standard_Language.Connection = objLocalConfig.Connection_Plugin
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
