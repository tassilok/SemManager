Imports Sem_Manager
Imports Filesystem_Management
Public Class clsTransaction_Imagevb
    Private objLocalConfig As clsLocalConfig

    Private procA_DBWork_Save_OR_Attribute As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_AttributeTableAdapter
    Private procA_DBWork_Save_OR_RelationType As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_RelationTypeTableAdapter
    Private procA_DBWork_Save_OR_Token As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TokenTableAdapter
    Private procA_DBWork_Save_OR_Type As New ds_ObjectReferenceTableAdapters.proc_DBWork_Save_OR_TypeTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_INT As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_IntTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Datetime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private semprocA_DBWork_Save_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Save_Token_ORTableAdapter
    Private semprocA_DBWork_Del_Token_OR As New ds_DBWorkTableAdapters.semproc_DBWork_Del_Token_ORTableAdapter

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private objBlobConnection As clsBlobConnection

    Private objSemItem_Ref As clsSemItem
    Private objSemItem_OR As clsSemItem
    Private objSemItem_ImageGraphic As clsSemItem
    Private objSemItem_File As clsSemItem
    Private objSemItem_TokenAttribute_Taking As clsSemItem
    Private objSemItem_Year As clsSemItem
    Private objSemItem_Month As clsSemItem
    Private objSemItem_Day As clsSemItem
    Private intID As Integer

    Public Function save_001_OR_of_Ref(ByVal SemItem_Ref As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_Ref = SemItem_Ref

        Select Case objSemItem_Ref.GUID_Type
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Attribute.GetData(objSemItem_Ref.GUID).Rows
            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                objDRC_LogState = procA_DBWork_Save_OR_RelationType.GetData(objSemItem_Ref.GUID).Rows
            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Token.GetData(objSemItem_Ref.GUID).Rows
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                objDRC_LogState = procA_DBWork_Save_OR_Type.GetData(objSemItem_Ref.GUID).Rows
        End Select

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_OR = New clsSemItem
            objSemItem_OR.GUID = objDRC_LogState(0).Item("GUID_ObjectReference")

            objSemItem_Result = objLocalConfig.Globals.LogState_Success
            objSemItem_Result.GUID_Related = objDRC_LogState(0).Item("GUID_objectReference")
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_002_ImageGraphic(ByVal SemItem_ImageGraphic As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_ImageGraphic = SemItem_ImageGraphic

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_ImageGraphic.GUID, _
                                                             objSemItem_ImageGraphic.Name, _
                                                             objSemItem_ImageGraphic.GUID_Parent, True).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If

        Return objSemItem_Result
    End Function

    Public Function del_002_ImageGraphic(Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_ImageGraphic.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function



    Public Function save_004_File(ByVal SemItem_File As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        objSemItem_File = SemItem_File

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_File.GUID, _
                                                             objSemItem_File.Name, _
                                                             objSemItem_File.GUID_Parent, True).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_004_File(Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_File.GUID).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_005_Blob(ByVal strPath_File As String, Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If
        objSemItem_File.Additional1 = strPath_File

        objSemItem_Result = objBlobConnection.save_File_To_Blob(objSemItem_File, objSemItem_File.Additional1)

        Return objSemItem_Result
    End Function

    Public Function del_005_Blob(Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objBlobConnection.del_Blob(objSemItem_File)

        Return objSemItem_Result
    End Function

    Public Function save_006_ImageGraphic_To_File(Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing, Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic

        End If

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ImageGraphic.GUID, _
                                                                objSemItem_File.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belonging_Source.GUID, 0).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If


        Return objSemItem_Result
    End Function

    Public Function del_006_ImageGraphic_To_File(Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing, Optional ByVal SemItem_File As clsSemItem = Nothing) As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic

        End If

        If Not SemItem_File Is Nothing Then
            objSemItem_File = SemItem_File
        End If

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ImageGraphic.GUID, _
                                                               objSemItem_File.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belonging_Source.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result

    End Function

    Public Function save_007_ImageGraphic_To_OR(ByVal ID As Integer, Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing, Optional ByVal SemItem_OR As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        If Not SemItem_OR Is Nothing Then
            objSemItem_OR = SemItem_OR
        End If

        intID = ID

        objDRC_LogState = semprocA_DBWork_Save_Token_OR.GetData(objSemItem_ImageGraphic.GUID, _
                                                                objSemItem_OR.GUID, _
                                                                objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                intID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If
        Return objSemItem_Result
    End Function

    Public Function del_007_ImageGraphic_To_OR(Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing, Optional ByVal SemItem_OR As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        If Not SemItem_OR Is Nothing Then
            objSemItem_OR = SemItem_OR
        End If



        objDRC_LogState = semprocA_DBWork_Del_Token_OR.GetData(objSemItem_ImageGraphic.GUID, _
                                                               objSemItem_OR.GUID, _
                                                               objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows

        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function save_008_ImageGraphic__Taking(ByVal dateCreate As Date, Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing, Optional ByVal SemItem_TokenAttribute_Taking As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Taking As DataRowCollection
        Dim objDR_Taking As DataRow

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If


        objSemItem_TokenAttribute_Taking = SemItem_TokenAttribute_Taking

        objDRC_Taking = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_ImageGraphic.GUID, _
                                                                                                       objLocalConfig.SemItem_Attribute_taking.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        If Not objSemItem_TokenAttribute_Taking Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_ImageGraphic.GUID, _
                                                                                   objLocalConfig.SemItem_Attribute_taking.GUID, _
                                                                                   objSemItem_TokenAttribute_Taking.GUID, _
                                                                                   dateCreate, 1).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            End If
        Else
            For Each objDR_Taking In objDRC_Taking
                If objDR_Taking.Item("Val_Datetime") = dateCreate Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Success
                    objSemItem_TokenAttribute_Taking = New clsSemItem
                    objSemItem_TokenAttribute_Taking.GUID = objDR_Taking.Item("GUID_TokenAttribute")
                Else
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Taking.Item("GUID_TokenAttribute")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                End If
            Next
        End If
        
        

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_ImageGraphic.GUID, _
                                                                                   objLocalConfig.SemItem_Attribute_taking.GUID, _
                                                                                   Nothing, _
                                                                                   dateCreate, 1).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
                objSemItem_TokenAttribute_Taking = New clsSemItem
                objSemItem_TokenAttribute_Taking.GUID = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function del_008_ImageGraphic__Taking(Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing, Optional ByVal SemItem_TokenAttribute_Taking As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Taking As DataRowCollection
        Dim objDR_Taking As DataRow

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        objSemItem_TokenAttribute_Taking = SemItem_TokenAttribute_Taking

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If Not objSemItem_TokenAttribute_Taking Is Nothing Then
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objSemItem_TokenAttribute_Taking.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objDRC_Taking = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_ImageGraphic.GUID, _
                                                                                                           objLocalConfig.SemItem_Attribute_taking.GUID).Rows
            For Each objDR_Taking In objDRC_Taking
                objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_Taking.Item("GUID_TokenAttribute")).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            Next
        End If

        Return objSemItem_Result
    End Function

    Public Function save_009_ImageGraphic_To_Year(ByVal SemItem_Year As clsSemItem, Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        objSemItem_Year = SemItem_Year

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ImageGraphic.GUID, _
                                                                objSemItem_Year.GUID, _
                                                                objLocalConfig.SemItem_RelationType_taking_at.GUID, 1).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_009_ImageGraphic_To_Year(Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Period As DataRowCollection
        Dim objDR_Period As DataRow

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        objDRC_Period = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ImageGraphic.GUID, _
                                                                      objLocalConfig.SemItem_RelationType_taking_at.GUID, _
                                                                      objLocalConfig.SemItem_Type_Year.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Period In objDRC_Period
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ImageGraphic.GUID, _
                                                                   objDR_Period.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_taking_at.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_010_ImageGraphic_To_Month(ByVal SemItem_Month As clsSemItem, Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        objSemItem_Month = SemItem_Month

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ImageGraphic.GUID, _
                                                                objSemItem_Month.GUID, _
                                                                objLocalConfig.SemItem_RelationType_taking_at.GUID, 1).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_010_ImageGraphic_To_Month(Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Period As DataRowCollection
        Dim objDR_Period As DataRow

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        objDRC_Period = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ImageGraphic.GUID, _
                                                                      objLocalConfig.SemItem_RelationType_taking_at.GUID, _
                                                                      objLocalConfig.SemItem_Type_Month.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Period In objDRC_Period
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ImageGraphic.GUID, _
                                                                   objDR_Period.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_taking_at.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_011_ImageGraphic_To_Day(ByVal SemItem_Day As clsSemItem, Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        objSemItem_Day = SemItem_Day

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_ImageGraphic.GUID, _
                                                                objSemItem_Day.GUID, _
                                                                objLocalConfig.SemItem_RelationType_taking_at.GUID, 1).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Function del_011_ImageGraphic_To_Day(Optional ByVal SemItem_ImageGraphic As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Period As DataRowCollection
        Dim objDR_Period As DataRow

        If Not SemItem_ImageGraphic Is Nothing Then
            objSemItem_ImageGraphic = SemItem_ImageGraphic
        End If

        objDRC_Period = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_ImageGraphic.GUID, _
                                                                      objLocalConfig.SemItem_RelationType_taking_at.GUID, _
                                                                      objLocalConfig.SemItem_Type_Day.GUID).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Period In objDRC_Period
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_ImageGraphic.GUID, _
                                                                   objDR_Period.Item("GUID_Token_Right"), _
                                                                   objLocalConfig.SemItem_RelationType_taking_at.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        procA_DBWork_Save_OR_Attribute.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_RelationType.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Token.Connection = objLocalConfig.Connection_DB
        procA_DBWork_Save_OR_Type.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_INT.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Datetime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token_OR.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token_OR.Connection = objLocalConfig.Connection_DB

        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
    End Sub
End Class