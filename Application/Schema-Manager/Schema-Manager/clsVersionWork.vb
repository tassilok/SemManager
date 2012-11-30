Imports Sem_Manager
Public Class clsVersionWork
    'Private objSemItem_Ref As clsSemItem
    'Private objSemItem_Version As clsSemItem
    'Private objSemItem_LogEntry As clsSemItem

    'Private GUID_TokenAttribute_Major As Guid
    'Private GUID_TokenAttribute_Minor As Guid
    'Private GUID_TokenAttribute_Build As Guid
    'Private GUID_TokenAttribute_Revision As Guid

    'Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    'Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    'Private semprocA_DBWork_Save_Token_Attribute_Int As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_IntTableAdapter
    'Private semprocA_DBWork_Del_Token_Attribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    'Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    'Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    'Private intMajor As Integer
    'Private intMinor As Integer
    'Private intBuild As Integer
    'Private intRevision As Integer

    'Public Sub New(ByVal SemItem_Ref As clsSemItem, ByVal SemItem_LogEntry As clsSemItem)
    '    objSemItem_Ref = SemItem_Ref
    '    objSemItem_LogEntry = SemItem_LogEntry

    '    intMajor = 0
    '    intMinor = 0
    '    intBuild = 0
    '    intRevision = 1

    '    set_DBConnection()
    'End Sub

    'Private Sub set_DBConnection()
    '    semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
    '    semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
    '    semprocA_DBWork_Save_Token_Attribute_Int.Connection = objLocalConfig.Connection_DB
    '    semprocA_DBWork_Del_Token_Attribute.Connection = objLocalConfig.Connection_DB
    '    semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
    '    semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
    'End Sub

    'Public Function save_FirstVersion() As clsSemItem


    '    Return save_Version(intMajor, intMinor, intBuild, intRevision)

    'End Function

    'Private Function save_Version(ByVal intMajor As Integer, ByVal intMinor As Integer, ByVal intBuild As Integer, ByVal intRevision As Integer) As clsSemItem
    '    Dim boolSaved As Boolean = True
    '    If save_001_Version() = True Then
    '        If save_002_Major() = True Then
    '            If save_003_Minor() = True Then
    '                If save_004_Build() = True Then
    '                    If save_005_Revision() = True Then
    '                        If save_006_Ref_To_Version() = False Then
    '                            boolSaved = False
    '                            del_005_Revision()
    '                            del_004_Build()
    '                            del_003_Minor()
    '                            del_002_Major()
    '                            del_001_Version()
    '                        End If
    '                    Else
    '                        boolSaved = False
    '                        del_004_Build()
    '                        del_003_Minor()
    '                        del_002_Major()
    '                        del_001_Version()
    '                    End If
    '                Else
    '                    boolSaved = False
    '                    del_003_Minor()
    '                    del_002_Major()
    '                    del_001_Version()
    '                End If
    '            Else
    '                boolSaved = False
    '                del_002_Major()
    '                del_001_Version()
    '            End If
    '        Else
    '            boolSaved = False
    '            del_001_Version()
    '        End If
    '    Else
    '        boolSaved = False
    '    End If
    '    If boolSaved = False Then
    '        objSemItem_Version = Nothing
    '        MsgBox("Die Version kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
    '    End If
    '    Return objSemItem_Version
    'End Function

    'Private Function save_001_Version() As Boolean
    '    Dim objDRC_LogState As DataRowCollection
    '    Dim boolResult As Boolean

    '    objSemItem_Version = New clsSemItem
    '    objSemItem_Version.GUID = Guid.NewGuid
    '    objSemItem_Version.Name = intMajor & "." & intMinor & "." & intBuild & "." & intRevision
    '    objSemItem_Version.GUID_Parent = objLocalConfig.SemItem_type_DevelopmentVersion.GUID

    '    objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Version.GUID, objSemItem_Version.Name, objSemItem_Version.GUID_Parent, True).Rows
    '    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
    '        boolResult = True
    '    Else
    '        boolResult = False
    '    End If

    '    Return boolResult
    'End Function

    'Private Sub del_001_Version()
    '    objSemItem_Version = Nothing

    '    semprocA_DBWork_Del_Token.GetData(objSemItem_Version.GUID)
    'End Sub

    'Private Function save_002_Major() As Boolean
    '    Dim objDRC_LogState As DataRowCollection
    '    Dim boolResult As Boolean

    '    objDRC_LogState = semprocA_DBWork_Save_Token_Attribute_Int.GetData(objSemItem_Version.GUID, objLocalConfig.SemItem_Attribute_Major.GUID, Nothing, intMajor, 0).Rows
    '    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
    '        GUID_TokenAttribute_Major = objDRC_LogState(0).Item("GUID_TokenAttribute")
    '        boolResult = True
    '    Else
    '        GUID_TokenAttribute_Major = Nothing
    '        boolResult = False
    '    End If

    '    Return boolResult

    'End Function

    'Private Sub del_002_Major()
    '    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Major)
    'End Sub

    'Private Function save_003_Minor() As Boolean
    '    Dim objDRC_LogState As DataRowCollection
    '    Dim boolResult As Boolean

    '    objDRC_LogState = semprocA_DBWork_Save_Token_Attribute_Int.GetData(objSemItem_Version.GUID, objLocalConfig.SemItem_Attribute_Minor.GUID, Nothing, intMinor, 0).Rows
    '    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
    '        GUID_TokenAttribute_Minor = objDRC_LogState(0).Item("GUID_TokenAttribute")
    '        boolResult = True
    '    Else
    '        GUID_TokenAttribute_Minor = Nothing
    '        boolResult = False
    '    End If

    '    Return boolResult
    'End Function

    'Private Sub del_003_Minor()
    '    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Minor)
    'End Sub

    'Private Function save_004_Build() As Boolean
    '    Dim objDRC_LogState As DataRowCollection
    '    Dim boolResult As Boolean

    '    objDRC_LogState = semprocA_DBWork_Save_Token_Attribute_Int.GetData(objSemItem_Version.GUID, objLocalConfig.SemItem_Attribute_Build.GUID, Nothing, intBuild, 0).Rows
    '    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
    '        GUID_TokenAttribute_Build = objDRC_LogState(0).Item("GUID_TokenAttribute")
    '        boolResult = True
    '    Else
    '        GUID_TokenAttribute_Build = Nothing
    '        boolResult = False
    '    End If

    '    Return boolResult
    'End Function

    'Private Sub del_004_Build()
    '    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Build)
    'End Sub

    'Private Function save_005_Revision() As Boolean
    '    Dim objDRC_LogState As DataRowCollection
    '    Dim boolResult As Boolean

    '    objDRC_LogState = semprocA_DBWork_Save_Token_Attribute_Int.GetData(objSemItem_Version.GUID, objLocalConfig.SemItem_Attribute_Revision.GUID, Nothing, intRevision, 0).Rows
    '    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
    '        GUID_TokenAttribute_Revision = objDRC_LogState(0).Item("GUID_TokenAttribute")
    '        boolResult = True
    '    Else
    '        GUID_TokenAttribute_Revision = Nothing
    '        boolResult = False
    '    End If

    '    Return boolResult
    'End Function

    'Private Sub del_005_Revision()
    '    semprocA_DBWork_Del_Token_Attribute.GetData(GUID_TokenAttribute_Revision)
    'End Sub

    'Private Function save_006_Ref_To_Version() As Boolean
    '    Dim objDRC_LogState As DataRowCollection
    '    Dim boolResult As Boolean

    '    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Ref.GUID, objSemItem_Version.GUID, objLocalConfig.SemItem_RelationType_isInState.GUID, 0).Rows
    '    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
    '        boolResult = True
    '    Else
    '        boolResult = False
    '    End If

    '    Return boolResult
    'End Function

    'Private Sub del_006_Ref_To_Version()
    '    semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Ref.GUID, objSemItem_Version.GUID, objLocalConfig.SemItem_RelationType_isInState.GUID)
    'End Sub

End Class
