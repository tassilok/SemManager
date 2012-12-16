Imports Sem_Manager
Public Class clsTransaction_FlaecheVolumen
    Private objLocalConfig As clsLocalConfig

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter

    Private procA_Flaeche_By_Mengen As New ds_MengeTableAdapters.proc_Flaeche_By_MengenTableAdapter
    Private procA_Volumen_By_Mengen As New ds_MengeTableAdapters.proc_Volumen_By_MengenTableAdapter

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter

    Private objSemItem_Flaeche As clsSemItem
    Private objSemItem_Volumen As clsSemItem
    Private objSemItem_Menge_X As clsSemItem
    Private objSemItem_Menge_Y As clsSemItem
    Private objSemItem_Menge_Z As clsSemItem

    Private dblFlaeche As Double
    Private dblVolumen As Double

    Public ReadOnly Property SemItem_Flaeche As clsSemItem
        Get
            Return objSemItem_Flaeche
        End Get
    End Property

    Public ReadOnly Property SemItem_Volumen As clsSemItem
        Get
            Return objSemItem_Volumen
        End Get
    End Property

    Public ReadOnly Property Flaeche As Double
        Get
            Return dblFlaeche
        End Get
    End Property

    Public ReadOnly Property Volumen As Double
        Get
            Return dblVolumen
        End Get
    End Property

    Public Function save_001_Flaeche(ByVal SemItem_Menge_X As clsSemItem, ByVal SemItem_Menge_Y As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Mengen As DataRowCollection

        objSemItem_Volumen = Nothing
        objSemItem_Menge_X = SemItem_Menge_X
        objSemItem_Menge_Y = SemItem_Menge_Y

        objDRC_Mengen = procA_Flaeche_By_Mengen.GetData(objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Einheit.GUID, _
                                                        objLocalConfig.SemItem_Type_Fl_che.GUID, _
                                                        objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                        objLocalConfig.SemItem_RelationType_x.GUID, _
                                                        objLocalConfig.SemItem_RelationType_y.GUID, _
                                                        objSemItem_Menge_X.GUID, _
                                                        objSemItem_Menge_Y.GUID).Rows
        If objDRC_Mengen.Count = 0 Then
            objSemItem_Flaeche = New clsSemItem
            objSemItem_Flaeche.GUID = Guid.NewGuid
            objSemItem_Flaeche.Name = objSemItem_Menge_X.Name & " * " & objSemItem_Menge_Y.Name
            objSemItem_Flaeche.GUID_Parent = objLocalConfig.SemItem_Type_Fl_che.GUID
            objSemItem_Flaeche.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Flaeche.GUID, _
                                                                 objSemItem_Flaeche.Name, _
                                                                 objSemItem_Flaeche.GUID_Parent, True).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
            dblFlaeche = Nothing
        Else
            If Not objDRC_Mengen(0).Item("Name_Flaeche") = objDRC_Mengen(0).Item("Name_Menge_X") & " * " & objDRC_Mengen(0).Item("Name_Menge_Y") Then
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objDRC_Mengen(0).Item("GUID_Flaeche"), _
                                                                     objDRC_Mengen(0).Item("Name_Menge_X") & " * " & objDRC_Mengen(0).Item("Name_Menge_Y"), _
                                                                     objLocalConfig.SemItem_Type_Fl_che.GUID, True).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Exists
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Exists
            End If
            dblFlaeche = objDRC_Mengen(0).Item("Flaeche")
        End If


        Return objSemItem_Result
    End Function

    Public Function del_001_Flaeche(Optional ByVal SemItem_Flaeche As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not SemItem_Flaeche Is Nothing Then
            objSemItem_Flaeche = SemItem_Flaeche
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Flaeche.GUID).Rows

        Select Case objDRC_LogState(0).Item("GUID_Token")
            Case objLocalConfig.Globals.LogState_Error.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            Case objLocalConfig.Globals.LogState_Relation.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Relation
            Case Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End Select

        Return objSemItem_Result
    End Function

    Public Function save_002_Volumen(ByVal SemItem_Menge_X As clsSemItem, ByVal SemItem_Menge_Y As clsSemItem, ByVal SemItem_Menge_Z As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Mengen As DataRowCollection


        objSemItem_Volumen = Nothing
        objSemItem_Menge_X = SemItem_Menge_X
        objSemItem_Menge_Y = SemItem_Menge_Y
        objSemItem_Menge_Z = SemItem_Menge_Z

        objDRC_Mengen = procA_Volumen_By_Mengen.GetData(objLocalConfig.SemItem_Attribute_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Menge.GUID, _
                                                        objLocalConfig.SemItem_Type_Einheit.GUID, _
                                                        objLocalConfig.SemItem_Type_Volumen.GUID, _
                                                        objLocalConfig.SemItem_RelationType_is_of_Type.GUID, _
                                                        objLocalConfig.SemItem_RelationType_x.GUID, _
                                                        objLocalConfig.SemItem_RelationType_y.GUID, _
                                                        objLocalConfig.SemItem_RelationType_z.GUID, _
                                                        objSemItem_Menge_X.GUID, _
                                                        objSemItem_Menge_Y.GUID, _
                                                        objSemItem_Menge_Z.GUID).Rows
        If objDRC_Mengen.Count = 0 Then
            objSemItem_Volumen = New clsSemItem
            objSemItem_Volumen.GUID = Guid.NewGuid
            objSemItem_Volumen.Name = objSemItem_Menge_X.Name & " * " & objSemItem_Menge_Y.Name & " * " & objSemItem_Menge_Z.Name
            objSemItem_Volumen.GUID_Parent = objLocalConfig.SemItem_Type_Volumen.GUID
            objSemItem_Volumen.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_Volumen.GUID, _
                                                                 objSemItem_Volumen.Name, _
                                                                 objSemItem_Volumen.GUID_Parent, True).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
            dblVolumen = Nothing
        Else
            If Not objDRC_Mengen(0).Item("Name_Volumen") = objDRC_Mengen(0).Item("Name_Menge_X") & " * " & objDRC_Mengen(0).Item("Name_Menge_Y") & " * " & objDRC_Mengen(0).Item("Name_Menge_Z") Then
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objDRC_Mengen(0).Item("GUID_Fl_che"), _
                                                                     objDRC_Mengen(0).Item("Name_Menge_X") & " * " & objDRC_Mengen(0).Item("Name_Menge_Y") & " * " & objDRC_Mengen(0).Item("Name_Menge_Z"), _
                                                                     objLocalConfig.SemItem_Type_Volumen.GUID, True).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Exists
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Exists
            End If
            dblVolumen = objDRC_Mengen(0).Item("Volumen")
        End If


        Return objSemItem_Result
    End Function

    Public Function del_001_Volumen(Optional ByVal SemItem_Volumen As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection

        If Not objSemItem_Volumen Is Nothing Then
            objSemItem_Volumen = SemItem_Volumen
        End If

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Volumen.GUID).Rows

        Select Case objDRC_LogState(0).Item("GUID_Token")
            Case objLocalConfig.Globals.LogState_Error.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            Case objLocalConfig.Globals.LogState_Relation.GUID
                objSemItem_Result = objLocalConfig.Globals.LogState_Relation
            Case Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End Select

        Return objSemItem_Result
    End Function

    Private Function save_FlaechVol_To_Menge(ByVal SemIteM_FlaechVol As clsSemItem, ByVal SemItem_Menge As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Menge As DataRowCollection
        Dim objDR_Menge As DataRow

        objDRC_Menge = funcA_TokenToken.GetData_TokenToken_LeftRight(SemIteM_FlaechVol.GUID, _
                                                                     SemIteM_FlaechVol.GUID_Relation, _
                                                                     SemIteM_FlaechVol.GUID_Related).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        For Each objDR_Menge In objDRC_Menge
            If objDR_Menge.Item("GUID_Token_Right") = SemItem_Menge.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(SemIteM_FlaechVol.GUID, _
                                                                       objDR_Menge.Item("GUID_Token_Right"), _
                                                                       SemIteM_FlaechVol.GUID_Relation).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    Exit For
                End If
            End If
        Next

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Nothing.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(SemIteM_FlaechVol.GUID, _
                                                                    SemItem_Menge.GUID, _
                                                                    SemIteM_FlaechVol.GUID_Relation, 1).Rows

            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function
    
    Private Function del_FlaechVol_To_Menge(ByVal SemIteM_FlaechVol As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_Menge As DataRowCollection
        Dim objDR_Menge As DataRow

        objDRC_Menge = funcA_TokenToken.GetData_TokenToken_LeftRight(SemIteM_FlaechVol.GUID, _
                                                                     SemIteM_FlaechVol.GUID_Relation, _
                                                                     SemIteM_FlaechVol.GUID_Related).Rows
        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_Menge In objDRC_Menge
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(SemIteM_FlaechVol.GUID, _
                                                                   objDR_Menge.Item("GUID_Token_Right"), _
                                                                   SemIteM_FlaechVol.GUID_Relation).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function save_002_FlaechVol_To_Menge_X(ByVal SemItem_Mene_X As clsSemItem, Optional ByVal SemItem_FlaecheVol As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem


        objSemItem_Menge_X = SemItem_Mene_X
        If Not SemItem_FlaecheVol Is Nothing Then
            If SemItem_FlaecheVol.GUID_Parent = objLocalConfig.SemItem_Type_Fl_che.GUID Then
                objSemItem_Flaeche = SemItem_FlaecheVol
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Fl_che.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_x.GUID

            Else
                objSemItem_Volumen = SemItem_FlaecheVol
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Volumen.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_x.GUID

            End If
        Else
            If Not objSemItem_Flaeche Is Nothing Then
                SemItem_FlaecheVol = New clsSemItem
                SemItem_FlaecheVol.GUID = objSemItem_Flaeche.GUID
                SemItem_FlaecheVol.Name = objSemItem_Flaeche.Name
                SemItem_FlaecheVol.GUID_Parent = objSemItem_Flaeche.GUID_Parent
                SemItem_FlaecheVol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Fl_che.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_x.GUID
            Else
                SemItem_FlaecheVol.GUID = objSemItem_Volumen.GUID
                SemItem_FlaecheVol.Name = objSemItem_Volumen.Name
                SemItem_FlaecheVol.GUID_Parent = objSemItem_Volumen.GUID_Parent
                SemItem_FlaecheVol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Volumen.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_x.GUID
            End If
        End If

        objSemItem_Result = save_FlaechVol_To_Menge(SemItem_FlaecheVol, objSemItem_Menge_X)

        Return objSemItem_Result
    End Function

    Public Function del_002_FlaechVol_To_Menge_X(Optional ByVal SemItem_FlaecheVol As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        

        If Not SemItem_FlaecheVol Is Nothing Then
            If SemItem_FlaecheVol.GUID_Parent = objLocalConfig.SemItem_Type_Fl_che.GUID Then
                objSemItem_Flaeche = SemItem_FlaecheVol
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Fl_che.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_x.GUID

            Else
                objSemItem_Volumen = SemItem_FlaecheVol
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Volumen.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_x.GUID

            End If
        Else
            If Not objSemItem_Flaeche Is Nothing Then
                SemItem_FlaecheVol = New clsSemItem
                SemItem_FlaecheVol.GUID = objSemItem_Flaeche.GUID
                SemItem_FlaecheVol.Name = objSemItem_Flaeche.Name
                SemItem_FlaecheVol.GUID_Parent = objSemItem_Flaeche.GUID_Parent
                SemItem_FlaecheVol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Fl_che.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_x.GUID
            Else
                SemItem_FlaecheVol.GUID = objSemItem_Volumen.GUID
                SemItem_FlaecheVol.Name = objSemItem_Volumen.Name
                SemItem_FlaecheVol.GUID_Parent = objSemItem_Volumen.GUID_Parent
                SemItem_FlaecheVol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Volumen.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_x.GUID
            End If
        End If

        objSemItem_Result = del_FlaechVol_To_Menge(SemItem_FlaecheVol)

        Return objSemItem_Result
    End Function


    Public Function save_003_FlaechVol_To_Menge_Y(ByVal SemItem_Mene_Y As clsSemItem, Optional ByVal SemItem_FlaecheVol As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Menge_Y = SemItem_Mene_Y
        If Not SemItem_FlaecheVol Is Nothing Then
            If SemItem_FlaecheVol.GUID_Parent = objLocalConfig.SemItem_Type_Fl_che.GUID Then
                objSemItem_Flaeche = SemItem_FlaecheVol
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Fl_che.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_y.GUID

            Else
                objSemItem_Volumen = SemItem_FlaecheVol
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Volumen.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_y.GUID

            End If
        Else
            If Not objSemItem_Flaeche Is Nothing Then
                SemItem_FlaecheVol = New clsSemItem
                SemItem_FlaecheVol.GUID = objSemItem_Flaeche.GUID
                SemItem_FlaecheVol.Name = objSemItem_Flaeche.Name
                SemItem_FlaecheVol.GUID_Parent = objSemItem_Flaeche.GUID_Parent
                SemItem_FlaecheVol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Fl_che.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_y.GUID
            Else
                SemItem_FlaecheVol = New clsSemItem
                SemItem_FlaecheVol.GUID = objSemItem_Flaeche.GUID
                SemItem_FlaecheVol.Name = objSemItem_Flaeche.Name
                SemItem_FlaecheVol.GUID_Parent = objSemItem_Flaeche.GUID_Parent
                SemItem_FlaecheVol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Volumen.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_y.GUID
            End If
        End If

        objSemItem_Result = save_FlaechVol_To_Menge(SemItem_FlaecheVol, objSemItem_Menge_Y)

        Return objSemItem_Result
    End Function

    Public Function del_003_FlaechVol_To_Menge_Y(Optional ByVal SemItem_FlaecheVol As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem


        If Not SemItem_FlaecheVol Is Nothing Then
            If SemItem_FlaecheVol.GUID_Parent = objLocalConfig.SemItem_Type_Fl_che.GUID Then
                objSemItem_Flaeche = SemItem_FlaecheVol
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Fl_che.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_y.GUID

            Else
                objSemItem_Volumen = SemItem_FlaecheVol
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Volumen.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_y.GUID

            End If
        Else
            If Not objSemItem_Flaeche Is Nothing Then
                SemItem_FlaecheVol = New clsSemItem
                SemItem_FlaecheVol.GUID = objSemItem_Flaeche.GUID
                SemItem_FlaecheVol.Name = objSemItem_Flaeche.Name
                SemItem_FlaecheVol.GUID_Parent = objSemItem_Flaeche.GUID_Parent
                SemItem_FlaecheVol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Fl_che.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_y.GUID
            Else
                SemItem_FlaecheVol.GUID = objSemItem_Volumen.GUID
                SemItem_FlaecheVol.Name = objSemItem_Volumen.Name
                SemItem_FlaecheVol.GUID_Parent = objSemItem_Volumen.GUID_Parent
                SemItem_FlaecheVol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Volumen.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_y.GUID
            End If
        End If

        objSemItem_Result = del_FlaechVol_To_Menge(SemItem_FlaecheVol)

        Return objSemItem_Result
    End Function

    Public Function save_004_FlaechVol_To_Menge_Z(ByVal SemItem_Mene_Z As clsSemItem, Optional ByVal SemItem_FlaecheVol As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Menge_Z = SemItem_Mene_Z
        If Not SemItem_FlaecheVol Is Nothing Then
            If SemItem_FlaecheVol.GUID_Parent = objLocalConfig.SemItem_Type_Fl_che.GUID Then
                objSemItem_Flaeche = SemItem_FlaecheVol
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Fl_che.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_z.GUID

            Else
                objSemItem_Volumen = SemItem_FlaecheVol
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Volumen.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_z.GUID

            End If
        Else
            If Not objSemItem_Flaeche Is Nothing Then
                SemItem_FlaecheVol.GUID = objSemItem_Flaeche.GUID
                SemItem_FlaecheVol.Name = objSemItem_Flaeche.Name
                SemItem_FlaecheVol.GUID_Parent = objSemItem_Flaeche.GUID_Parent
                SemItem_FlaecheVol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Fl_che.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_z.GUID
            Else
                SemItem_FlaecheVol.GUID = objSemItem_Flaeche.GUID
                SemItem_FlaecheVol.Name = objSemItem_Flaeche.Name
                SemItem_FlaecheVol.GUID_Parent = objSemItem_Flaeche.GUID_Parent
                SemItem_FlaecheVol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Volumen.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_z.GUID
            End If
        End If

        objSemItem_Result = save_FlaechVol_To_Menge(SemItem_FlaecheVol, objSemItem_Menge_Z)

        Return objSemItem_Result
    End Function

    Public Function del_004_FlaechVol_To_Menge_Z(Optional ByVal SemItem_FlaecheVol As clsSemItem = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem


        If Not SemItem_FlaecheVol Is Nothing Then
            If SemItem_FlaecheVol.GUID_Parent = objLocalConfig.SemItem_Type_Fl_che.GUID Then
                objSemItem_Flaeche = SemItem_FlaecheVol
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Fl_che.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_z.GUID

            Else
                objSemItem_Volumen = SemItem_FlaecheVol
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Volumen.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_z.GUID

            End If
        Else
            If Not objSemItem_Flaeche Is Nothing Then
                SemItem_FlaecheVol = New clsSemItem
                SemItem_FlaecheVol.GUID = objSemItem_Flaeche.GUID
                SemItem_FlaecheVol.Name = objSemItem_Flaeche.Name
                SemItem_FlaecheVol.GUID_Parent = objSemItem_Flaeche.GUID_Parent
                SemItem_FlaecheVol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Fl_che.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_z.GUID
            Else
                SemItem_FlaecheVol.GUID = objSemItem_Volumen.GUID
                SemItem_FlaecheVol.Name = objSemItem_Volumen.Name
                SemItem_FlaecheVol.GUID_Parent = objSemItem_Volumen.GUID_Parent
                SemItem_FlaecheVol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                SemItem_FlaecheVol.GUID_Related = objLocalConfig.SemItem_Type_Volumen.GUID
                SemItem_FlaecheVol.GUID_Relation = objLocalConfig.SemItem_RelationType_z.GUID
            End If
        End If

        objSemItem_Result = del_FlaechVol_To_Menge(SemItem_FlaecheVol)

        Return objSemItem_Result
    End Function

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()

        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB


        funcA_TokenToken.Connection = objLocalConfig.Connection_DB

        procA_Flaeche_By_Mengen.Connection = objLocalConfig.Connection_Plugin
        procA_Volumen_By_Mengen.Connection = objLocalConfig.Connection_Plugin
    End Sub
End Class
