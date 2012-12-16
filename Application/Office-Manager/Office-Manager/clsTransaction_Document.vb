Imports Sem_Manager
Public Class clsTransaction_Document
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter

    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Datetime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHAR255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Save_TokenOR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_DBWork_Del_TokenOR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter

    Private objSemItem_Document As clsSemItem
    Private objSemItem_DocumentType As clsSemItem
    Private objSemItem_File As clsSemItem
    Private objSemItem_Folder As clsSemItem
    Private objSemItem_ContentObject As clsSemItem

    Private objLocalConfig As clsLocalConfig

    Private objSemItem_Rel As clsSemItem
    Private GUID_TokenAttribute_LastAccess As Guid
    Public Property SemItem_Document As clsSemItem
        Get
            Return objSemItem_Document
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_Document = value
        End Set
    End Property

    Public Property SemItem_File As clsSemItem
        Get
            Return objSemItem_File
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_File = value
        End Set
    End Property
    Public Function save_001_Document(ByVal SemItem_Document As clsSemItem) As clsSemItem
        Dim objSemItem_Result As New clsSemItem
        Dim objDRC_Document As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Document = SemItem_Document

        objDRC_Document = semtblA_Token.GetData_Token_By_GUID(objSemItem_Document.GUID).Rows
        If objDRC_Document.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Document.GUID, objSemItem_Document.Name, objSemItem_Document.GUID_Parent, True).Rows
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

    Public Function del_001_Document() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Document.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_Document_To_DocumentType(ByVal SemItem_DocumentType As clsSemItem) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objSemItem_DocumentType = SemItem_DocumentType

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Document.GUID, objSemItem_DocumentType.GUID, objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_Document_To_DocumentType() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Document.GUID, objSemItem_DocumentType.GUID, objLocalConfig.SemItem_RelationType_is_of_Type.GUID).rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_003_File(ByVal SemItem_File As clsSemItem) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_File As DataRowCollection

        Dim objSemItem_Result As clsSemItem

        objSemItem_File = SemItem_File

        objDRC_File = semtblA_Token.GetData_Token_By_GUID(objSemItem_File.GUID).Rows
        If objDRC_File.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_File.GUID, objSemItem_File.Name, objSemItem_File.GUID_Parent, True).Rows
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

    Public Function del_003_File() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_File.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function


    Public Function save_005_Doc_To_File() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Document.GUID, _
                                                                objSemItem_File.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging_Document.GUID, 0).Rows

        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_005_Doc_To_File() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Document.GUID, _
                                                               objSemItem_File.GUID, _
                                                               objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows

        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_006_LastAccess(ByVal dateLastAccess As Date) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_LastAccess As DataRowCollection
        Dim objDR_LastAccess As DataRow
        Dim boolAdd As Boolean

        Dim objSemItem_Result As clsSemItem

        objDRC_LastAccess = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_Document.GUID, _
                                                                                                           objLocalConfig.SemItem_Attribute_DateTimeStamp__Change_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        boolAdd = True
        For Each objDR_LastAccess In objDRC_LastAccess
            If objDR_LastAccess.Item("Val_DateTime") = dateLastAccess Then
                GUID_TokenAttribute_LastAccess = objDR_LastAccess.Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_LastAccess.Item("GUID_TokenAttribute")).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then

                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    boolAdd = False
                End If
            End If

        Next
        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_Document.GUID, _
                                                                                   objLocalConfig.SemItem_Attribute_DateTimeStamp__Change_.GUID, _
                                                                                   Nothing, _
                                                                                   dateLastAccess, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                GUID_TokenAttribute_LastAccess = objDRC_LogState(0).Item("GUID_TokenAttribute")
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        Return objSemItem_Result
    End Function

    Public Function del_006_LastAccess() As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(GUID_TokenAttribute_LastAccess).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_007_Doc_To_Rel(ByVal SemItem_Rel As clsSemItem) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Doc_To_Rel As DataRowCollection
        Dim objDR_Doc_To_Rel As DataRow
        Dim objSemItem_Result As clsSemItem
        Dim boolAdd As Boolean

        objSemItem_Rel = SemItem_Rel

        objDRC_Doc_To_Rel = funcA_Token_OR.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objSemItem_Document.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        boolAdd = True
        For Each objDR_Doc_To_Rel In objDRC_Doc_To_Rel
            If objDR_Doc_To_Rel.Item("GUID_ObjectReference") = objSemItem_Rel.GUID_Related Then
                boolAdd = False
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenOR.GetData(objSemItem_Document.GUID, objDR_Doc_To_Rel.Item("GUID_ObjectReference"), objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            End If
        Next

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenOR.GetData(objSemItem_Document.GUID, _
                                                                   objSemItem_Rel.GUID_Related, _
                                                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        Return objSemItem_Result
    End Function

    Public Function del_007_Doc_To_Rel(Optional ByVal SemItem_Rel As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        If Not SemItem_Rel Is Nothing Then
            objSemItem_Rel = SemItem_Rel
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenOR.GetData(objSemItem_Document.GUID, objSemItem_Rel.GUID_Related, objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else

            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_Connection()
    End Sub

    Private Sub set_Connection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenAttribute_Datetime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHAR255.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenOR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenOR.Connection = objLocalConfig.Connection_DB

        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB
    End Sub

End Class
