Imports Sem_Manager
Public Class clsTransaction_ImageObjects
    Private objLocalConfig As clsLocalConfig

    Private objSemItem_ImageObject As clsSemItem
    Private objSemItem_Image As clsSemItem
    Private objSemItem_Object As clsSemItem

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Public Function save_001_ImageObject(ByVal SemItem_ImageObject As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_ImageObject = SemItem_ImageObject

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_ImageObject.GUID, _
                                                             objSemItem_ImageObject.Name, _
                                                             objSemItem_ImageObject.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_001_ImageObject(Optional ByVal SemItem_ImageObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ImageObject Is Nothing Then
            objSemItem_ImageObject = SemItem_ImageObject
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_ImageObject.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID And Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Relation.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_ImageObject_To_Image(ByVal SemItem_Image As clsSemItem, Optional ByVal SemItem_ImageObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Person As DataRowCollection
        Dim objDR_Person As DataRow

        objSemItem_Image = SemItem_Image
        If Not SemItem_ImageObject Is Nothing Then
            objSemItem_ImageObject = SemItem_ImageObject
        End If

        objDRC_Person = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ImageObject.GUID, _
                                                                      objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                                                      objLocalConfig.SemItem_Type_Image_Objects.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing

        For Each objDR_Person In objDRC_Person
            If objDR_Person.Item("GUID_Token_Right") = objSemItem_ImageObject.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ImageObject.GUID, _
                                                                       objDR_Person.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_located_in.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ImageObject.GUID, _
                                                                    objSemItem_Image.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_located_in.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_ImageObject_To_Image(Optional ByVal SemItem_ImageObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Persons As DataRowCollection
        Dim objDR_Person As DataRow

        If Not SemItem_ImageObject Is Nothing Then
            objSemItem_ImageObject = SemItem_ImageObject
        End If

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_Persons = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ImageObject.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_located_in.GUID, _
                                                                       objLocalConfig.SemItem_Type_Images__Graphic_.GUID).Rows

        For Each objDR_Person In objDRC_Persons
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ImageObject.GUID, _
                                                                   objDR_Person.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_located_in.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Nothing.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next


        Return objSemItem_Result
    End Function

    Public Function save_003_ImageObject_To_Object(ByVal SemItem_Object As clsSemItem, ByVal GUID_Type_Object As Guid, Optional ByVal SemItem_ImageObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Object As DataRowCollection
        Dim objDR_Object As DataRow

        objSemItem_Object = SemItem_Object
        If Not SemItem_ImageObject Is Nothing Then
            objSemItem_ImageObject = SemItem_ImageObject
        End If

        objDRC_Object = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ImageObject.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_is.GUID, _
                                                                       GUID_Type_Object).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Object In objDRC_Object
            If objDR_Object.Item("GUID_Token_Right") = objSemItem_Object.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ImageObject.GUID, _
                                                                       objDR_Object.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_is.GUID).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For

                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ImageObject.GUID, _
                                                                    objSemItem_Object.GUID, _
                                                                    objLocalConfig.SemItem_RelationType_is.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If
        Return objSemItem_Result
    End Function

    Public Function del_003_ImageObject_To_Object(ByVal GUID_Type_Object As Guid, Optional ByVal SemItem_ImageObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Object As DataRowCollection
        Dim objDR_Object As DataRow

        If Not SemItem_ImageObject Is Nothing Then
            objSemItem_ImageObject = SemItem_ImageObject
        End If

        objDRC_Object = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ImageObject.GUID, _
                                                                       objLocalConfig.SemItem_RelationType_is.GUID, _
                                                                       GUID_Type_Object).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_Object In objDRC_Object
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ImageObject.GUID, _
                                                                   objDR_Object.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_is.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_004_noObjects(ByVal SemItem_NoObject As clsSemItem, Optional ByVal SemItem_ImageObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ImageObject Is Nothing Then
            objSemItem_ImageObject = objSemItem_ImageObject
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ImageObject.GUID, _
                                                                SemItem_NoObject.GUID, _
                                                                objLocalConfig.SemItem_RelationType_has.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_noObjects(Optional ByVal SemItem_ImageObject As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_NoObjects As DataRowCollection
        Dim objDR_NoObjects As DataRow

        If Not SemItem_ImageObject Is Nothing Then
            objSemItem_ImageObject = SemItem_ImageObject
        End If

        objDRC_NoObjects = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ImageObject.GUID, _
                                                                         objLocalConfig.SemItem_RelationType_has.GUID, _
                                                                         objLocalConfig.SemItem_Type_Image_Objects__No_Objects_.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        For Each objDR_NoObjects In objDRC_NoObjects
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ImageObject.GUID, _
                                                                   objDR_NoObjects.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_has.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
