Imports Sem_Manager
Public Class clsVersionWork
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Int As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_IntTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter

    Private procA_SoftwareDevelopment_Version As New ds_ModuleTableAdapters.proc_SoftwareDevelopment_VersionTableAdapter
    Private procT_SoftwareDevelopment_Version As New ds_Module.proc_SoftwareDevelopment_VersionDataTable

    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private procA_001_ModDBWork_Save_Version As New ds_ModDBWorkTableAdapters.proc_ModDBWork_Save_VersionTableAdapter
    Private procA_002_ModDBWork_Save_Major As New ds_ModDBWorkTableAdapters.proc_ModDBWork_Save_Version_MajorMinorBuildRevisionTableAdapter
    Private procA_003_ModDBWork_Save_Minor As New ds_ModDBWorkTableAdapters.proc_ModDBWork_Save_Version_MajorMinorBuildRevisionTableAdapter
    Private procA_004_ModDBWork_Save_Build As New ds_ModDBWorkTableAdapters.proc_ModDBWork_Save_Version_MajorMinorBuildRevisionTableAdapter
    Private procA_005_ModDBWork_Save_Revision As New ds_ModDBWorkTableAdapters.proc_ModDBWork_Save_Version_MajorMinorBuildRevisionTableAdapter
    Private procA_006_ModDBWork_Del_VersionValues As New ds_ModDBWorkTableAdapters.proc_ModDBWork_Del_Version_MajorMinorBuildRevisionTableAdapter

    Private objLogWork_Local As clsLogWork_Local
    Private objDlgAttribute_VARCHARMAX As dlgAttribute_VarcharMax
    Private objFrmSemManager As frmSemManager

    Private objLocalConfig As clsLocalConfig
    Private objSemItem_Rel As clsSemItem
    Private objSemItem_Token_LogEntry As clsSemItem = Nothing
    Private objSemItem_LogState As clsSemItem = Nothing

    Private objParWindow As Windows.Forms.IWin32Window

    Private intMajor As Integer
    Private intMinor As Integer
    Private intBuild As Integer
    Private intRevision As Integer

    Private boolVersionExists As Boolean
    Private boolVersionChange As Boolean

    Public Property SemItem_LogState() As clsSemItem
        Get
            Return objSemItem_LogState
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_LogState = value
        End Set
    End Property

    Public WriteOnly Property SemItem_Token_LogEntry() As clsSemItem
        Set(ByVal value As clsSemItem)
            objSemItem_Token_LogEntry = value
        End Set
    End Property

    Public ReadOnly Property Version_Exists() As Boolean
        Get
            Return boolVersionExists
        End Get
        
    End Property
    Public Property Major() As Integer
        Get
            Return intMajor
        End Get
        Set(ByVal value As Integer)
            intMajor = value
        End Set
    End Property

    Public Property Minor() As Integer
        Get
            Return intMinor
        End Get
        Set(ByVal value As Integer)
            intMinor = value
        End Set
    End Property

    Public Property Build() As Integer
        Get
            Return intBuild
        End Get
        Set(ByVal value As Integer)
            intBuild = value
        End Set
    End Property
    Public Property Revision() As Integer
        Get
            Return intRevision
        End Get
        Set(ByVal value As Integer)
            intRevision = value
        End Set
    End Property
    Public Function save_Version(ByVal boolDescribe As Boolean) As clsSemItem
        Dim boolSave As Boolean
        Dim objDRC_ObjectReference As DataRowCollection
        Dim objDRC_LogState As DataRowCollection
        Dim objDR_Version As DataRow
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success
        Dim strDescription As String
        Dim GUID_Version As Guid
        Dim GUID_TokenAttribute_Major As Guid
        Dim GUID_TokenAttribute_Minor As Guid
        Dim GUID_TokenAttribute_Build As Guid
        Dim GUID_TokenAttribute_Revision As Guid


        get_VersionData()
        If procT_SoftwareDevelopment_Version.Rows.Count = 0 Then
            'Version noch nicht vorhanden
            boolSave = True
        Else
            'Version vorhanden.
            objDR_Version = procT_SoftwareDevelopment_Version.Rows(0)
            boolVersionChange = False

            'Überprüfen, ob die gespeicherte Version unterschiedlich zur angegebenen ist.
            If objDR_Version.Item("Major") <> intMajor Then
                boolVersionChange = True
            End If

            If objDR_Version.Item("Minor") <> intMinor Then
                boolVersionChange = True
            End If

            If objDR_Version.Item("Build") <> intBuild Then
                boolVersionChange = True
            End If

            If objDR_Version.Item("Revision") <> intRevision Then
                boolVersionChange = True
            End If

            If boolVersionChange = True Then
                'Version ändern
                boolSave = True
                
            End If
        End If

        If boolSave = True Then
            GUID_Version = Guid.NewGuid

            objDRC_LogState = procA_001_ModDBWork_Save_Version.GetData(GUID_Version, intMajor & "." & intMinor & "." & intBuild & "." & intRevision, objLocalConfig.SemItem_type_DevelopmentVersion.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Success.GUID Then
                objDRC_LogState = procA_002_ModDBWork_Save_Major.GetData(GUID_Version, objLocalConfig.SemItem_type_DevelopmentVersion.GUID, objLocalConfig.SemItem_Attribute_Major.GUID, intMajor).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Success.GUID Then
                    GUID_TokenAttribute_Major = objDRC_LogState(0).Item("GUID_TokenAttribute")
                    objDRC_LogState = procA_003_ModDBWork_Save_Minor.GetData(GUID_Version, objLocalConfig.SemItem_type_DevelopmentVersion.GUID, objLocalConfig.SemItem_Attribute_Minor.GUID, intMinor).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Success.GUID Then
                        GUID_TokenAttribute_Minor = objDRC_LogState(0).Item("GUID_TokenAttribute")
                        objDRC_LogState = procA_004_ModDBWork_Save_Build.GetData(GUID_Version, objLocalConfig.SemItem_type_DevelopmentVersion.GUID, objLocalConfig.SemItem_Attribute_Build.GUID, intBuild).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Success.GUID Then
                            GUID_TokenAttribute_Build = objDRC_LogState(0).Item("GUID_TokenAttribute")
                            objDRC_LogState = procA_005_ModDBWork_Save_Revision.GetData(GUID_Version, objLocalConfig.SemItem_type_DevelopmentVersion.GUID, objLocalConfig.SemItem_Attribute_Revision.GUID, intRevision).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Success.GUID Then
                                If objSemItem_Token_LogEntry Is Nothing Then
                                    If boolDescribe = True Then
                                        objSemItem_LogState = get_LogState()
                                        strDescription = get_Message()
                                        objSemItem_Token_LogEntry = objLogWork_Local.log_Entry(objSemItem_Rel, objSemItem_LogState, False, strDescription)
                                    Else

                                        objSemItem_LogState = objLocalConfig.SemItem_Token_LogState_VersionChanged

                                        objSemItem_Token_LogEntry = objLogWork_Local.log_Entry(objSemItem_Rel, objSemItem_LogState, False)
                                    End If


                                End If
                                objDRC_ObjectReference = procA_DBWork_Save_OR_Token.GetData(GUID_Version).Rows
                                If objDRC_ObjectReference.Count > 0 Then

                                    objDRC_LogState = semprocA_DBWork_Save_Token_OR.GetData(objSemItem_Token_LogEntry.GUID, objDRC_ObjectReference(0).Item("GUID_ObjectReference"), objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Rel.GUID, GUID_Version, objLocalConfig.SemItem_RelationType_isInState.GUID, 0).Rows
                                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                            For Each objDR_Version In procT_SoftwareDevelopment_Version.Rows
                                                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Rel.GUID, objDR_Version.Item("GUID_Token_Version"), objLocalConfig.SemItem_RelationType_isInState.GUID).Rows
                                                
                                            Next
                                        Else

                                            semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Token_LogEntry.GUID, GUID_Version, objLocalConfig.SemItem_RelationType_belongsTo.GUID)
                                            objDRC_LogState = procA_006_ModDBWork_Del_VersionValues.GetData(GUID_Version, _
                                                                                                            objLocalConfig.SemItem_type_DevelopmentVersion.GUID, _
                                                                                                            Nothing, Nothing).Rows
                                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Success.GUID Then
                                                semprocA_DBWork_Del_Token.GetData(GUID_Version)
                                            End If

                                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                            'MsgBox("Beim Speichern der Version ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                                        End If
                                    Else
                                        semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Token_LogEntry.GUID, GUID_Version, objLocalConfig.SemItem_RelationType_belongsTo.GUID)
                                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Success.GUID Then
                                            semprocA_DBWork_Del_Token.GetData(GUID_Version)
                                        End If
                                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                        'MsgBox("Beim Speichern der Version ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Success.GUID Then
                                        semprocA_DBWork_Del_Token.GetData(GUID_Version)
                                    End If
                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                    'MsgBox("Beim Speichern der Version ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                                End If
                            End If

                        Else

                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Success.GUID Then
                                semprocA_DBWork_Del_Token.GetData(GUID_Version)
                            End If
                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                            'MsgBox("Beim Speichern der Version ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Success.GUID Then
                            semprocA_DBWork_Del_Token.GetData(GUID_Version)
                        End If
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        'MsgBox("Beim Speichern der Version ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                    End If

                Else
                    semprocA_DBWork_Del_Token.GetData(GUID_Version)
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    'MsgBox("Beim Speichern der Version ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                'MsgBox("Beim Speichern der Version ist ein Fehler unterlaufen!", MsgBoxStyle.Exclamation)
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function save_FirstVersion() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        intMajor = 0
        intMinor = 0
        intBuild = 0
        intRevision = 1

        objSemItem_LogState = objLocalConfig.SemItem_Token_LogState_Create
        objSemItem_Result = save_Version(False)
        Return objSemItem_Result
    End Function

    Public Function del_Versions_Of_Rel() As clsSemItem
        Dim objDRC_Version As DataRowCollection
        Dim objDR_Version As DataRow

        Dim objDRC_LogState As DataRowCollection

        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success

        objDRC_Version = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_Rel.GUID, objLocalConfig.SemItem_RelationType_isInState.GUID, objLocalConfig.SemItem_type_DevelopmentVersion.GUID).Rows
        For Each objDR_Version In objDRC_Version
            objSemItem_Result = del_Version_Attribus(objDR_Version.Item("GUID_Token_Right"))
            If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Rel.GUID, objDR_Version.Item("GUID_Token_Right"), objLocalConfig.SemItem_RelationType_isInState.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objDR_Version.Item("GUID_Token_Right")).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                Else

                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function del_Version_Attribus(ByVal GUID_Version As Guid) As clsSemItem
        Dim objSemItem_Result As clsSemItem = objLocalConfig.Globals.LogState_Success
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_VersionAttribs As DataRowCollection
        Dim objDR_VersionAttrib As DataRow

        objDRC_VersionAttribs = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(GUID_Version, objLocalConfig.SemItem_Attribute_Major.GUID).Rows
        For Each objDR_VersionAttrib In objDRC_VersionAttribs
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_VersionAttrib.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objDRC_VersionAttribs = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(GUID_Version, objLocalConfig.SemItem_Attribute_Minor.GUID).Rows
            For Each objDR_VersionAttrib In objDRC_VersionAttribs
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_VersionAttrib.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objDRC_VersionAttribs = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(GUID_Version, objLocalConfig.SemItem_Attribute_Build.GUID).Rows
            For Each objDR_VersionAttrib In objDRC_VersionAttribs
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_VersionAttrib.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objDRC_VersionAttribs = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(GUID_Version, objLocalConfig.SemItem_Attribute_Revision.GUID).Rows
            For Each objDR_VersionAttrib In objDRC_VersionAttribs
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_VersionAttrib.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        End If

        Return objSemItem_Result
    End Function
    Private Function get_Message() As String
        Dim strResult As String
        objDlgAttribute_VARCHARMAX = New dlgAttribute_VarcharMax(objLocalConfig.SemItem_type_Logstate.Name, objLocalConfig.Globals)
        objDlgAttribute_VARCHARMAX.ShowDialog(objParWindow)

        If objDlgAttribute_VARCHARMAX.DialogResult = DialogResult.OK Then
            strResult = objDlgAttribute_VARCHARMAX.Value
        Else
            MsgBox("Bitte eine Beschreibung eingeben!", MsgBoxStyle.Exclamation)
            strResult = get_Message()
        End If
        Return strResult
    End Function
    Private Function get_LogState() As clsSemItem
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Result As clsSemItem = Nothing

        If objSemItem_LogState Is Nothing Then
            objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_type_Logstate, objLocalConfig.Globals)
            objFrmSemManager.Applyabale = True
            objFrmSemManager.ShowDialog(objParWindow)
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_type_Logstate.GUID Then
                        objSemItem_Result = New clsSemItem
                        objSemItem_Result.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_Result.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_Result.GUID_Parent = objLocalConfig.SemItem_type_Logstate.GUID
                        objSemItem_Result.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                    Else
                        MsgBox("Bitte wählen Sie nur einen Logstate aus!", MsgBoxStyle.Exclamation)
                        objSemItem_Result = get_LogState()
                    End If
                Else
                    MsgBox("Bitte wählen Sie nur einen Logstate aus!", MsgBoxStyle.Exclamation)
                    objSemItem_Result = get_LogState()
                End If
            End If
        End If
        
        Return objSemItem_Result
    End Function

    Public Sub get_VersionData()
        procT_SoftwareDevelopment_Version.Clear()
        procA_SoftwareDevelopment_Version.Fill(procT_SoftwareDevelopment_Version, _
                objLocalConfig.SemItem_Attribute_Major.GUID, _
                objLocalConfig.SemItem_Attribute_Minor.GUID, _
                objLocalConfig.SemItem_Attribute_Build.GUID, _
                objLocalConfig.SemItem_Attribute_Revision.GUID, _
                objLocalConfig.SemItem_type_DevelopmentVersion.GUID, _
                objLocalConfig.SemItem_RelationType_isInState.GUID, _
                objSemItem_Rel.GUID)
        If procT_SoftwareDevelopment_Version.Rows.Count > 0 Then
            boolVersionExists = True
        Else
            boolVersionExists = False
        End If

        'set_Version()
    End Sub

    Private Sub set_Version()
        If procT_SoftwareDevelopment_Version.Rows.Count > 0 Then
            intMajor = procT_SoftwareDevelopment_Version.Rows(0).Item("Major")
            intMinor = procT_SoftwareDevelopment_Version.Rows(0).Item("Minor")
            intBuild = procT_SoftwareDevelopment_Version.Rows(0).Item("Build")
            intRevision = procT_SoftwareDevelopment_Version.Rows(0).Item("Revision")
        Else
            intMajor = 0
            intMinor = 0
            intBuild = 0
            intRevision = 1
        End If
    End Sub

    Private Sub set_DBConnection()
        procA_SoftwareDevelopment_Version.Connection = objLocalConfig.Connection_Plugin

        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Int.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB

        procA_001_ModDBWork_Save_Version.Connection = objLocalConfig.Connection_Plugin
        procA_002_ModDBWork_Save_Major.Connection = objLocalConfig.Connection_Plugin
        procA_003_ModDBWork_Save_Minor.Connection = objLocalConfig.Connection_Plugin
        procA_004_ModDBWork_Save_Build.Connection = objLocalConfig.Connection_Plugin
        procA_005_ModDBWork_Save_Revision.Connection = objLocalConfig.Connection_Plugin
        procA_006_ModDBWork_Del_VersionValues.Connection = objLocalConfig.Connection_Plugin

        objLogWork_Local = New clsLogWork_Local(objLocalConfig)
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_Rel As clsSemItem, ByRef parWindow As Windows.Forms.IWin32Window)
        objSemItem_Rel = SemItem_Rel
        objLocalConfig = LocalConfig
        objParWindow = parWindow
        set_DBConnection()
        initialize()
    End Sub

    Public Sub New(ByVal objGlobals As clsGlobals, ByVal SemItem_Rel As clsSemItem, ByVal objSemItem_User As clsSemItem, ByRef parWindow As Windows.Forms.IWin32Window)
        objSemItem_Rel = SemItem_Rel
        objLocalConfig = New clsLocalConfig(objGlobals)
        objLocalConfig.SemItem_User = New clsSemItem
        objLocalConfig.SemItem_User.GUID = objSemItem_User.GUID
        objLocalConfig.SemItem_User.Name = objSemItem_User.Name
        objLocalConfig.SemItem_User.GUID_Parent = objSemItem_User.GUID_Parent
        objLocalConfig.SemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objParWindow = parWindow
        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        get_VersionData()
        set_Version()
    End Sub

End Class

