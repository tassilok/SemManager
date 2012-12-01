Imports Sem_Manager
Public Class clsTransaction_DevelopmentStructure

    Private dtbl_Parameters As ds_DevStructures.dtbl_ParametersDataTable

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter

    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private procA_StructureTypeWithAspects_Of_DevStructure_By_Type_AND_Validity As New ds_DevStructuresTableAdapters.proc_StructureTypeWithAspects_Of_DevStructure_By_Type_AND_ValidityTableAdapter
    Private procA_StructureTypeWithAspects_By_StructureType_And_StructureValidity As New ds_DevStructuresTableAdapters.proc_StructureTypeWithAspects_By_StructureType_And_StructureValidityTableAdapter
    Private procA_DevParameter_By_Direction_And_Object As New ds_DevStructuresTableAdapters.proc_DevParameter_By_Direction_And_ObjectTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private objDRC_DevStructure As DataRowCollection

    Private objDR_Type As DataRowView
    Private objDR_Validity As DataRowView

    Private objSemItem_Development As clsSemItem
    Private objSemItem_DevelopmentStructure As clsSemItem
    Private objSemItem_StructureTypeWithAspects As clsSemItem

    Public Function save_001_DevStructure(ByVal SemItem_DevStructure) As Boolean
        Dim objDRC_LogState As DataRowCollection

        objSemItem_DevelopmentStructure = SemItem_DevStructure

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DevelopmentStructure.GUID, objSemItem_DevelopmentStructure.Name, objSemItem_DevelopmentStructure.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function del_001_DevStructure() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean
        If objSemItem_DevelopmentStructure.new_Item = True Then
            objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_DevelopmentStructure.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                boolResult = False
            Else
                boolResult = True
            End If
        Else
            boolResult = True
        End If

        Return boolResult
    End Function

    Public Function save_002_StructureTypeWithAspects(ByVal DR_Type As DataRowView, ByVal DR_Validity As DataRowView) As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_TypeWithAspects As DataRowCollection
        Dim boolResult As Boolean

        objDR_Type = DR_Type
        objDR_Validity = DR_Validity

        objDRC_TypeWithAspects = procA_StructureTypeWithAspects_By_StructureType_And_StructureValidity.GetData(objLocalConfig.SemItem_Type_Structure_Type.GUID, _
                                                                                                               objLocalConfig.SemItem_Type_Structure_Type_with_Aspects.GUID, _
                                                                                                               objLocalConfig.SemItem_Type_Structure_Validity.GUID, _
                                                                                                               objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                                                               objLocalConfig.SemItem_RelationType_access_by.GUID, _
                                                                                                               objDR_Type.Item("GUID_Token"), _
                                                                                                               objDR_Validity.Item("GUID_Token")).Rows
        objSemItem_StructureTypeWithAspects = New clsSemItem
        If objDRC_TypeWithAspects.Count > 0 Then

            objSemItem_StructureTypeWithAspects.GUID = objDRC_TypeWithAspects(0).Item("GUID_Structure_Type_With_Aspects")
            objSemItem_StructureTypeWithAspects.Name = objDRC_TypeWithAspects(0).Item("Name_Structure_Type_With_Aspects")
            objSemItem_StructureTypeWithAspects.GUID_Parent = objLocalConfig.SemItem_Type_Structure_Type_with_Aspects.GUID
            objSemItem_StructureTypeWithAspects.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_StructureTypeWithAspects.new_Item = False
            boolResult = True
        Else
            objSemItem_StructureTypeWithAspects.GUID = Guid.NewGuid
            objSemItem_StructureTypeWithAspects.Name = objDR_Validity.Item("Name_Token") & " " & objDR_Type.Item("Name_Token")
            objSemItem_StructureTypeWithAspects.GUID_Parent = objLocalConfig.SemItem_Type_Structure_Type_with_Aspects.GUID
            objSemItem_StructureTypeWithAspects.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
            objSemItem_StructureTypeWithAspects.new_Item = True

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_StructureTypeWithAspects.GUID, _
                                                                 objSemItem_StructureTypeWithAspects.Name, _
                                                                 objSemItem_StructureTypeWithAspects.GUID_Parent, _
                                                                 True).Rows

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        End If

        Return boolResult
    End Function


    Public Function del_002_StructureTypeWithAspects() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        If objSemItem_StructureTypeWithAspects.new_Item = True Then
            objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_StructureTypeWithAspects.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        Else
            boolResult = True
        End If

        Return boolResult
    End Function



    Public Function save_002a_StructureTypeWithAspects_To_StructureType(ByVal DR_Type As DataRowView) As Boolean
        Dim boolSave As Boolean
        Dim boolResult As Boolean
        Dim objDRC_LogState As DataRowCollection

        If objSemItem_StructureTypeWithAspects.new_Item = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_StructureTypeWithAspects.GUID, objDR_Type.Item("GUID_Token"), objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        Else
            boolResult = True
        End If
        Return boolResult
    End Function

    Public Function del_002a_StructureTypeWithAspects_To_StructureType() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean



        If objSemItem_StructureTypeWithAspects.new_Item = True Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_StructureTypeWithAspects.GUID, objDRC_DevStructure(0).Item("GUID_Structure_Type"), objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        Else
            boolResult = True
        End If

        Return boolResult
    End Function

    Public Function save_002b_StructureTypeWithAspects_To_StructureValidity(ByVal objDR_Validity As DataRowView) As Boolean
        Dim boolSave As Boolean
        Dim boolResult As Boolean
        Dim objDRC_LogState As DataRowCollection

        If objSemItem_StructureTypeWithAspects.new_Item = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_StructureTypeWithAspects.GUID, objDR_Validity.Item("GUID_Token"), objLocalConfig.SemItem_RelationType_access_by.GUID, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        Else
            boolResult = True
        End If

        Return boolResult
    End Function

    Public Function del_002b_StructureTypeWithAspects_To_StructureValidity() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean
        If objSemItem_StructureTypeWithAspects.new_Item = True Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_StructureTypeWithAspects.GUID, objDR_Validity.Item("GUID_Token"), objLocalConfig.SemItem_RelationType_access_by.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        Else
            boolResult = True
        End If
       
        Return boolResult
    End Function

    Public Function save_003_DevStructure_To_StructureTypeWithAspects() As Boolean
        Dim boolResult As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_DevStructure_To_StructureTypeWithAspects As DataRowCollection
        Dim objDR_DevStructure_To_StructureTypeWithAspects As DataRow
        Dim objSemItem_DevStructureWithAspects_Old As clsSemItem = Nothing
        Dim boolSave As Boolean

        objDRC_DevStructure_To_StructureTypeWithAspects = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_DevelopmentStructure.GUID, _
                                                                                                         objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                                                                         objLocalConfig.SemItem_Type_Structure_Type_with_Aspects.GUID).Rows
        boolSave = True
        For Each objDR_DevStructure_To_StructureTypeWithAspects In objDRC_DevStructure_To_StructureTypeWithAspects
            If objDR_DevStructure_To_StructureTypeWithAspects.Item("GUID_Token_Right") = objSemItem_StructureTypeWithAspects.GUID Then
                boolSave = False
                boolResult = True
                Exit For
            Else
                objSemItem_DevStructureWithAspects_Old = New clsSemItem
                objSemItem_DevStructureWithAspects_Old.GUID = objDR_DevStructure_To_StructureTypeWithAspects.Item("GUID_Token_Right")
                objSemItem_DevStructureWithAspects_Old.Name = objDR_DevStructure_To_StructureTypeWithAspects.Item("Name_Token_Right")
                objSemItem_DevStructureWithAspects_Old.GUID_Parent = objLocalConfig.SemItem_Type_Structure_Type_with_Aspects.GUID
                objSemItem_DevStructureWithAspects_Old.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DevelopmentStructure.GUID, _
                                                                       objDR_DevStructure_To_StructureTypeWithAspects.Item("GUID_Token_Right"), _
                                                                       objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    boolResult = False
                    boolSave = False
                    Exit For
                End If

            End If
        Next

        If boolSave = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DevelopmentStructure.GUID, objSemItem_StructureTypeWithAspects.GUID, objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolResult = True
            Else
                semprocA_DBWork_Save_TokenRel.GetData(objSemItem_DevelopmentStructure.GUID, objSemItem_DevStructureWithAspects_Old.GUID, objLocalConfig.SemItem_RelationType_is_of_Type.GUID, 0)
                boolResult = False
            End If
        End If



        Return boolResult
    End Function

    Public Function del_003_DevStructure_To_StructureTypeWithAspects() As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim boolResult As Boolean

        If objSemItem_DevelopmentStructure.new_Item = True Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_DevelopmentStructure.GUID, objSemItem_StructureTypeWithAspects.GUID, objLocalConfig.SemItem_RelationType_is_of_Type.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        End If

        Return boolResult
    End Function

    Public Function save_004_Development_To_DevStructure() As Boolean
        Dim boolResult As Boolean
        Dim objDRC_Dev_To_DevStructure As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objDRC_Dev_To_DevStructure = semtblA_Token_Token.GetData_By_GUIDs(objSemItem_Development.GUID, objSemItem_DevelopmentStructure.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_Dev_To_DevStructure.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Development.GUID, objSemItem_DevelopmentStructure.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolResult = True
            Else
                boolResult = False

            End If
        Else
            boolResult = True
        End If

        Return boolResult
    End Function

    Public Function del_004_Development_To_DevStructure() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Development.GUID, objSemItem_DevelopmentStructure.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows

        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_005_DevStructure_To_DevParameters(ByRef _dtbl_Parameters As ds_DevStructures.dtbl_ParametersDataTable) As Integer
        Dim intResult As Integer

        Dim objDR_Parameter As DataRow
        Dim objDRC_DevParameter As DataRowCollection

        Dim objSemItem_DevParameter As New clsSemItem

        dtbl_Parameters = _dtbl_Parameters

        intResult = dtbl_Parameters.Rows.Count
        For Each objDR_Parameter In dtbl_Parameters.Rows
            objDRC_DevParameter = procA_DevParameter_By_Direction_And_Object.GetData(objLocalConfig.SemItem_Type_Parameter_Dev_Structure.GUID, _
                                                                                     objLocalConfig.SemItem_Type_Objects.GUID, _
                                                                                     objLocalConfig.SemItem_Type_Directions.GUID, _
                                                                                     objLocalConfig.SemItem_RelationType_directed_by.GUID, _
                                                                                     objLocalConfig.SemItem_RelationType_belonging_Paramter.GUID, _
                                                                                     objDR_Parameter.Item("GUID_Direction"), _
                                                                                     objDR_Parameter.Item("GUID_Parameter")).Rows
            If objDRC_DevParameter.Count = 0 Then
                objSemItem_DevParameter.GUID = Guid.NewGuid
                objSemItem_DevParameter.Name = objDR_Parameter.Item("Name_Parameter")
                objSemItem_DevParameter.GUID_Parent = objLocalConfig.SemItem_Type_Parameter_Dev_Structure.GUID
                objSemItem_DevParameter.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_DevParameter.new_Item = True
            Else
                objSemItem_DevParameter.GUID = objDRC_DevParameter(0).Item("GUID_Parameter__Dev_Structure_")
                objSemItem_DevParameter.Name = objDRC_DevParameter(0).Item("Name_Parameter__Dev_Structure_")
                objSemItem_DevParameter.GUID_Parent = objLocalConfig.SemItem_Type_Parameter_Dev_Structure.GUID
                objSemItem_DevParameter.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_DevParameter.new_Item = False
            End If
            If save_006_DevParameter(objSemItem_DevParameter) = True Then
                If save_007_DevParameter_To_Parameter(objSemItem_DevParameter.GUID, objDR_Parameter.Item("GUID_Parameter")) = True Then
                    If save_008_Parameter_To_Directions(objSemItem_DevParameter.GUID, objDR_Parameter.Item("GUID_Direction")) = True Then
                        If save_009_DevParameter_To_DevStructure(objSemItem_DevParameter.GUID) = True Then
                            intResult = intResult - 1
                        Else
                            If objSemItem_DevParameter.new_Item = True Then
                                If del_008_Parameter_To_Directions(objSemItem_DevParameter.GUID, objDR_Parameter.Item("GUID_Direction")) = True Then
                                    If del_007_DevParameter_To_Parameter(objSemItem_DevParameter.GUID, objDR_Parameter.Item("GUID_Parameter")) = True Then
                                        del_006_DevParameter(objSemItem_DevParameter)
                                    End If
                                End If


                            End If
                        End If
                    Else
                        If objSemItem_DevParameter.new_Item = True Then
                            If del_007_DevParameter_To_Parameter(objSemItem_DevParameter.GUID, objDR_Parameter.Item("GUID_Parameter")) = True Then
                                del_006_DevParameter(objSemItem_DevParameter)
                            End If

                        End If
                    End If
                Else
                    If objSemItem_DevParameter.new_Item = True Then
                        del_006_DevParameter(objSemItem_DevParameter)
                    End If

                End If

            End If
        Next

        Return intResult
    End Function

    Private Function save_006_DevParameter(ByVal objSemItem_DevParameter As clsSemItem) As Boolean
        Dim boolResult As Boolean

        Dim objDRC_DevParameter As DataRowCollection
        Dim objDRC_LogState As DataRowCollection

        objDRC_DevParameter = semtblA_Token.GetData_Token_By_GUID(objSemItem_DevParameter.GUID).Rows
        If objDRC_DevParameter.Count = 0 Then
            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_DevParameter.GUID, objSemItem_DevParameter.Name, objSemItem_DevParameter.GUID_Parent, True).Rows

            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolResult = True
            Else
                boolResult = False
            End If
        End If

        Return boolResult
    End Function

    Private Function del_006_DevParameter(ByVal objSemItem_DevParameter As clsSemItem) As Boolean
        Dim boolResult As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_DevParameter.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If


        Return boolResult
    End Function

    Private Function save_007_DevParameter_To_Parameter(ByVal GUID_DevParameter As Guid, ByVal GUID_Parameter As Guid) As Boolean
        Dim boolResult As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(GUID_DevParameter, GUID_Parameter, objLocalConfig.SemItem_RelationType_belonging_Paramter.GUID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If


        Return boolResult
    End Function

    Private Function del_007_DevParameter_To_Parameter(ByVal GUID_DevParameter As Guid, ByVal GUID_Parameter As Guid) As Boolean
        Dim boolResult As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(GUID_DevParameter, GUID_Parameter, objLocalConfig.SemItem_RelationType_belonging_Paramter.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Private Function save_008_Parameter_To_Directions(ByVal GUID_DevParameter As Guid, ByVal GUID_Direction As Guid) As Boolean
        Dim boolResult As Boolean
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Parameter_To_Direction As DataRowCollection
        Dim objDR_Parameter_To_Direction As DataRow
        Dim boolSave As Boolean

        objDRC_Parameter_To_Direction = funcA_Token_Token.GetData_TokenToken_LeftRight(GUID_DevParameter, objLocalConfig.SemItem_RelationType_directed_by.GUID, objLocalConfig.SemItem_Type_Directions.GUID).Rows
        boolSave = True
        For Each objDR_Parameter_To_Direction In objDRC_Parameter_To_Direction
            If objDR_Parameter_To_Direction.Item("GUID_Token_Right") <> GUID_Direction Then
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(GUID_DevParameter, objDR_Parameter_To_Direction.Item("GUID_Token_Right"), objLocalConfig.SemItem_RelationType_directed_by.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    boolResult = False
                    boolSave = False
                End If
            Else
                boolSave = False
            End If
        Next

        If boolSave = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(GUID_DevParameter, GUID_Direction, objLocalConfig.SemItem_RelationType_directed_by.GUID, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                boolResult = True
            End If
        End If

        Return boolResult
    End Function

    Private Function del_008_Parameter_To_Directions(ByVal GUID_DevParameter As Guid, ByVal GUID_Direction As Guid) As Boolean
        Dim boolResult As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(GUID_DevParameter, GUID_Direction, objLocalConfig.SemItem_RelationType_directed_by.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Private Function save_009_DevParameter_To_DevStructure(ByVal GUID_DevParameter As Guid) As Boolean
        Dim boolResult As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(GUID_DevParameter, objSemItem_DevelopmentStructure.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID, 0).Rows
        If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function

    Private Function del_009_DevParameter_To_DevStructure(ByVal GUID_DevParameter As Guid) As Boolean
        Dim boolResult As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(GUID_DevParameter, objSemItem_DevelopmentStructure.GUID, objLocalConfig.SemItem_RelationType_belongsTo.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            boolResult = True
        Else
            boolResult = False
        End If

        Return boolResult
    End Function
    Public Sub New(ByVal SemItem_DevelopmentStructure As clsSemItem, ByVal SemItem_Development As clsSemItem)
        set_DBConnection()
        objSemItem_DevelopmentStructure = SemItem_DevelopmentStructure
        objSemItem_Development = SemItem_Development
    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Token_Token.Connection = objLocalConfig.Connection_DB
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB

        procA_StructureTypeWithAspects_Of_DevStructure_By_Type_AND_Validity.Connection = objLocalConfig.Connection_Plugin
        procA_StructureTypeWithAspects_By_StructureType_And_StructureValidity.Connection = objLocalConfig.Connection_Plugin
        procA_DevParameter_By_Direction_And_Object.Connection = objLocalConfig.Connection_Plugin
    End Sub

    
End Class
