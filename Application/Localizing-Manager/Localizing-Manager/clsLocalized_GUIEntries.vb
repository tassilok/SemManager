Imports Sem_Manager
Imports System.Management

Public Class clsLocalized_GUIEntries
    Private procA_Language_By_CodePage As New ds_LocalizeTableAdapters.proc_Language_By_CodePageTableAdapter
    Private procA_GUICaption_Of_SoftwareDevelopment_By_GUIDSoftwareDevelopment_And_GUIDLanguage As New ds_LocalizeTableAdapters.proc_GUICaption_Of_SoftwareDevelopment_By_GUIDSoftwareDevelopment_And_GUIDLanguageTableAdapter
    Private procA_GUIEntries_Of_SoftwareDevelopment As New ds_LocalizeTableAdapters.proc_GUIEntries_Of_SoftwareDevelopmentTableAdapter
    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private objSemItem_Development As clsSemItem
    Private objSemItem_Language_OS As clsSemItem
    Private objSemItem_Language_Development As clsSemItem
    Private objLocalConfig As Localizing_Manager.clsLocalConfig

    Public ReadOnly Property SemItem_Language_Standard() As clsSemItem
        Get
            Return objSemItem_Language_Development
        End Get
    End Property

    Public ReadOnly Property SemItem_Language_OS() As clsSemItem
        Get
            Return objSemItem_Language_OS
        End Get
    End Property

    Private Function get_Language_Standard() As clsSemItem
        Dim objDRC_Language As DataRowCollection
        Dim objSemItem_Language As clsSemItem

        objDRC_Language = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Development.GUID, objLocalConfig.SemItem_RelationType_Standard.GUID, objLocalConfig.SemItem_Type_Language.GUID).Rows
        If objDRC_Language.Count = 0 Then
            Return Nothing

        Else
            objSemItem_Language = New clsSemItem
            objSemItem_Language.GUID = objDRC_Language(0).Item("GUID_Token_Right")
            objSemItem_Language.Name = objDRC_Language(0).Item("Name_Token_Right")
            objSemItem_Language.GUID_Parent = objLocalConfig.SemItem_Type_Language.GUID
            objSemItem_Language.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            Return objSemItem_Language
        End If
    End Function

    Private Function get_Language_OS() As clsSemItem
        Dim objDRC_Language As DataRowCollection
        Dim objMgmtObjSearcher As ManagementObjectSearcher
        Dim objMgmtObjColl As ManagementObjectCollection
        Dim objMgmtObj As ManagementObject
        Dim strOSLanguageCode As String
        Dim intOSLanguageCode As String

        Dim objSemItem_Language As clsSemItem = Nothing

        objMgmtObjSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
        objMgmtObjColl = objMgmtObjSearcher.Get()
        intOSLanguageCode = 0
        strOSLanguageCode = "0"
        For Each objMgmtObj In objMgmtObjColl
            strOSLanguageCode = objMgmtObj("OSLanguage")
        Next
        If Integer.TryParse(strOSLanguageCode, intOSLanguageCode) = True Then
            objDRC_Language = procA_Language_By_CodePage.GetData(objLocalConfig.SemItem_Type_Language.GUID, _
                                                                 objLocalConfig.SemItem_Attribute_Codepage.GUID, _
                                                                 intOSLanguageCode).Rows
            If objDRC_Language.Count > 0 Then
                objSemItem_Language = New clsSemItem
                objSemItem_Language.GUID = objDRC_Language(0).Item("GUID_Language")
                objSemItem_Language.Name = objDRC_Language(0).Item("Name_Language")
                objSemItem_Language.GUID_Parent = objDRC_Language(0).Item("GUID_Type_Language")
                objSemItem_Language.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            End If

        End If

        Return objSemItem_Language
    End Function

    Public Function get_Localized_Caption() As String
        Dim objDRC_LocalizedCaption As DataRowCollection
        Dim strCaption As String = Nothing

        objDRC_LocalizedCaption = procA_GUICaption_Of_SoftwareDevelopment_By_GUIDSoftwareDevelopment_And_GUIDLanguage.GetData(objLocalConfig.SemItem_type_SoftwareDevelopment.GUID, _
                                                                                                                              objLocalConfig.SemItem_Type_GUI_Caption.GUID, _
                                                                                                                              objLocalConfig.SemItem_Type_Language.GUID, _
                                                                                                                              objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                                                              objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                                                                                              objSemItem_Development.GUID, _
                                                                                                                              objSemItem_Language_OS.GUID).Rows
        If objDRC_LocalizedCaption.Count > 0 Then
            strCaption = objDRC_LocalizedCaption(0).Item("Name_GUI_Caption")
        Else
            objDRC_LocalizedCaption = procA_GUICaption_Of_SoftwareDevelopment_By_GUIDSoftwareDevelopment_And_GUIDLanguage.GetData(objLocalConfig.SemItem_type_SoftwareDevelopment.GUID, _
                                                                                                                              objLocalConfig.SemItem_Type_GUI_Caption.GUID, _
                                                                                                                              objLocalConfig.SemItem_Type_Language.GUID, _
                                                                                                                              objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                                                                              objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                                                                                              objSemItem_Development.GUID, _
                                                                                                                              objSemItem_Language_Development.GUID).Rows
            If objDRC_LocalizedCaption.Count > 0 Then
                strCaption = objDRC_LocalizedCaption(0).Item("Name_GUI_Caption")
            End If
        End If
        Return strCaption
    End Function

    Public Function get_Localized_GUIEntry(ByVal Name_GUIEntry As String) As DataRow
        Dim objDRC_GUIEntry As DataRowCollection
        Dim objDR_Result As DataRow = Nothing

        objDRC_GUIEntry = procA_GUIEntries_Of_SoftwareDevelopment.GetData(objLocalConfig.SemItem_type_SoftwareDevelopment.GUID, _
                                                                          objLocalConfig.SemItem_Type_Language.GUID, _
                                                                          objLocalConfig.SemItem_Type_ToolTip_Messages.GUID, _
                                                                          objLocalConfig.SemItem_Type_GUI_Caption.GUID, _
                                                                          objLocalConfig.SemItem_Type_GUI_Entires.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_is_defined_by.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                          objSemItem_Language_OS.GUID, _
                                                                          objSemItem_Development.GUID, _
                                                                          Name_GUIEntry).Rows
        If objDRC_GUIEntry.Count > 0 Then
            objDR_Result = objDRC_GUIEntry(0)
        Else
            objDRC_GUIEntry = procA_GUIEntries_Of_SoftwareDevelopment.GetData(objLocalConfig.SemItem_type_SoftwareDevelopment.GUID, _
                                                                          objLocalConfig.SemItem_Type_Language.GUID, _
                                                                          objLocalConfig.SemItem_Type_ToolTip_Messages.GUID, _
                                                                          objLocalConfig.SemItem_Type_GUI_Caption.GUID, _
                                                                          objLocalConfig.SemItem_Type_GUI_Entires.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_isWrittenIn.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_is_defined_by.GUID, _
                                                                          objLocalConfig.SemItem_RelationType_contains.GUID, _
                                                                          objSemItem_Language_OS.GUID, _
                                                                          objSemItem_Development.GUID, _
                                                                          Name_GUIEntry).Rows
            If objDRC_GUIEntry.Count > 0 Then
                objDR_Result = objDRC_GUIEntry(0)
            End If
        End If
        Return objDR_Result
    End Function

    Public Sub New(ByVal SemItem_Development As clsSemItem, ByVal Globals As clsGlobals)
        objSemItem_Development = SemItem_Development
        objLocalConfig = New clsLocalConfig(Globals)

        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        objSemItem_Language_OS = get_Language_OS()
        objSemItem_Language_Development = get_Language_Standard()
    End Sub

    Private Sub set_DBConnection()
        procA_Language_By_CodePage.Connection = objLocalConfig.Connection_Plugin
        procA_GUICaption_Of_SoftwareDevelopment_By_GUIDSoftwareDevelopment_And_GUIDLanguage.Connection = objLocalConfig.Connection_Plugin
        procA_GUIEntries_Of_SoftwareDevelopment.Connection = objLocalConfig.Connection_Plugin
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
