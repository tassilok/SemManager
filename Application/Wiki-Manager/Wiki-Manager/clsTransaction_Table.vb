Imports Sem_Manager
Public Class clsTransaction_Table

    
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHARMAX As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_VarcharMaxTableAdapter
    Private semprocA_DBwork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private objLocalConfig As clsLocalConfig
    Private objSemItem_WikiDoc As clsSemItem
    Private objSemItem_WIKITable As clsSemItem
    Private objSemItem_WIKIRow As New clsSemItem
    Private objSemItem_WIKICol As New clsSemItem
    Private objSemItems_WIKICol() As clsSemItem
    Private objSemItem_WIKIDocPart As clsSemItem
    Private objTagWork As clsTagWork
    Private GUID_TokenAttribute_WIKIText As Guid
    Private GUID_TokenAttribute_WIKITextDocPart As Guid
    Private strText As String
    Private boolFirstRowBold As Boolean
    Private intBorderWidth As Integer


    'Private intRowID As Integer
    'Private intColID As Integer
    Private intOrderID As Integer
    Public Function save_001_Table(ByVal objDRC_Table As DataRowCollection, ByVal intCount_Cols As Integer) As clsSemItem
        Dim objDR_Row As DataRow
        Dim objDRC_LogState As DataRowCollection
        Dim objSemItem_WikiCol_loc As clsSemItem
        Dim intRows_ToDo As Integer
        Dim intRows_Done As Integer
        Dim intCols_Todo As Integer
        Dim intCols_Done As Integer
        Dim intCol As Integer


        Dim i As Integer
        Dim j As Integer

        objSemItem_WIKITable = New clsSemItem
        objSemItem_WIKITable.GUID = Guid.NewGuid
        objSemItem_WIKITable.Name = objSemItem_WikiDoc.Name & " (ID:" & intOrderID & ")"
        objSemItem_WIKITable.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Table.GUID
        objSemItem_WIKITable.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_WIKITable.GUID, objSemItem_WIKITable.Name, objSemItem_WIKITable.GUID_Parent, True).Rows
        intCols_Todo = intCount_Cols
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            i = 0
            intRows_ToDo = objDRC_Table.Count
            intRows_Done = 0
            For Each objDR_Row In objDRC_Table
                objSemItem_WIKIRow.GUID = Guid.NewGuid
                objSemItem_WIKIRow.Name = objSemItem_WIKITable.Name & " " & i
                objSemItem_WIKIRow.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Row.GUID
                objSemItem_WIKIRow.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_WIKIRow.Additional1 = ""
                objSemItem_WIKIRow.Level = i
                If save_002_Row() = True Then
                    intCols_Done = 0
                    objSemItems_WIKICol = Nothing
                    For j = 0 To intCount_Cols - 1
                        objSemItem_WIKICol.GUID = Guid.NewGuid
                        objSemItem_WIKICol.Name = "Col: " & j + 1
                        objSemItem_WIKICol.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Column.GUID
                        objSemItem_WIKICol.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        objSemItem_WIKICol.Additional1 = ""
                        objSemItem_WIKICol.Level = j
                        If save_003_Col() = True Then
                            strText = objDR_Row.Item(j)
                            If boolFirstRowBold = True Then
                                strText = objTagWork.get_Tag(objLocalConfig.SemItem_Token_Wiki_Components_Fett.GUID, True) & strText & objTagWork.get_Tag(objLocalConfig.SemItem_Token_Wiki_Components_Fett.GUID, True)
                            End If
                            strText = objTagWork.get_Tag(objLocalConfig.SemItem_Token_Wiki_Components_Table_Spalte.GUID, True) & strText
                           
                            If save_004_Col_WIKIText() = True Then
                                objSemItem_WIKICol.GUID_Related = GUID_TokenAttribute_WIKIText
                                objSemItem_WIKICol.Additional1 = strText
                                If save_005_Row_To_Col() = True Then
                                    intCols_Done = intCols_Done + 1
                                    If objSemItems_WIKICol Is Nothing Then
                                        intCol = 0
                                        ReDim Preserve objSemItems_WIKICol(intCol)
                                        objSemItems_WIKICol(intCol) = New clsSemItem
                                        objSemItems_WIKICol(intCol).GUID = objSemItem_WIKICol.GUID
                                        objSemItems_WIKICol(intCol).Name = objSemItem_WIKICol.Name
                                        objSemItems_WIKICol(intCol).GUID_Parent = objSemItem_WIKICol.GUID_Parent
                                        objSemItems_WIKICol(intCol).GUID_Type = objSemItem_WIKICol.GUID_Type
                                        objSemItems_WIKICol(intCol).GUID_Related = objSemItem_WIKICol.GUID_Related
                                        objSemItems_WIKICol(intCol).Additional1 = objSemItem_WIKICol.Additional1
                                    Else
                                        intCol = objSemItems_WIKICol.Length
                                        ReDim Preserve objSemItems_WIKICol(intCol)
                                        objSemItems_WIKICol(intCol) = New clsSemItem
                                        objSemItems_WIKICol(intCol).GUID = objSemItem_WIKICol.GUID
                                        objSemItems_WIKICol(intCol).Name = objSemItem_WIKICol.Name
                                        objSemItems_WIKICol(intCol).GUID_Parent = objSemItem_WIKICol.GUID_Parent
                                        objSemItems_WIKICol(intCol).GUID_Type = objSemItem_WIKICol.GUID_Type
                                        objSemItems_WIKICol(intCol).GUID_Related = objSemItem_WIKICol.GUID_Related
                                        objSemItems_WIKICol(intCol).Additional1 = objSemItem_WIKICol.Additional1
                                    End If
                                End If
                            End If
                        End If
                        

                    Next
                    If intCols_Done < intCols_Todo Then
                        If Not objSemItems_WIKICol Is Nothing Then
                            For Each objSemItem_WikiCol_loc In objSemItems_WIKICol
                                If del_005_Row_To_col(objSemItem_WikiCol_loc) = True Then
                                    If del_004_Col_WIKIText(objSemItem_WikiCol_loc.GUID_Related) = True Then
                                        del_003_Col(objSemItem_WikiCol_loc)
                                    End If
                                End If

                            Next
                        End If
                    Else
                        For Each objSemItem_WikiCol_loc In objSemItems_WIKICol
                            objSemItem_WIKIRow.Additional1 = objSemItem_WIKIRow.Additional1 & objSemItem_WikiCol_loc.Additional1 & vbCrLf
                        Next
                        objSemItem_WIKIRow.Additional1 = objTagWork.get_Tag(objLocalConfig.SemItem_Token_Wiki_Components_Table_Zeile.GUID, True) & vbCrLf & objSemItem_WIKIRow.Additional1
                        If save_006_Row_WIKIText() = True Then
                            If save_007_WIKITable_To_WIKIRow() = True Then
                                objSemItem_WIKITable.Additional1 = objSemItem_WIKITable.Additional1 & objSemItem_WIKIRow.Additional1
                                intRows_Done = intRows_Done + 1
                            Else
                                If del_006_Row_WIKIText() = True Then
                                    If Not objSemItems_WIKICol Is Nothing Then
                                        For Each objSemItem_WikiCol_loc In objSemItems_WIKICol
                                            If del_005_Row_To_col(objSemItem_WikiCol_loc) = True Then
                                                If del_004_Col_WIKIText(objSemItem_WikiCol_loc.GUID_Related) = True Then
                                                    del_003_Col(objSemItem_WikiCol_loc)
                                                End If
                                            End If

                                        Next
                                    End If
                                    del_002_Row()
                                End If
                            End If

                        Else
                            If Not objSemItems_WIKICol Is Nothing Then
                                For Each objSemItem_WikiCol_loc In objSemItems_WIKICol
                                    If del_005_Row_To_col(objSemItem_WikiCol_loc) = True Then
                                        If del_004_Col_WIKIText(objSemItem_WikiCol_loc.GUID_Related) = True Then
                                            del_003_Col(objSemItem_WikiCol_loc)
                                        End If
                                    End If

                                Next
                            End If
                            del_002_Row()
                        End If


                    End If
                End If
                boolFirstRowBold = False
                i = i + 1
            Next
            If intRows_Done > 0 Then

                objSemItem_WIKITable.Additional1 = objTagWork.get_Tag(objLocalConfig.SemItem_Token_Wiki_Components_Tabelle.GUID, True) & vbCrLf & objSemItem_WIKITable.Additional1
                objSemItem_WIKITable.Additional1 = objSemItem_WIKITable.Additional1 & objTagWork.get_Tag(objLocalConfig.SemItem_Token_Wiki_Components_Tabelle.GUID, False)
                If save_008_WIKITable_WIKIText() = True Then
                    If save_009_WIKIDocPart() = True Then
                        If save_010_WIKIDocPart_WIKIText() = True Then
                            If save_011_WIKITable_To_WIKIDocPart() = True Then
                                If save_012_WIKIDocument_To_WIKIDocPart() = False Then
                                    del_011_WIKITable_To_WIKIDocPart()
                                    del_010_WIKIDocPart_WIKIText()
                                    del_009_WIKIDocPart()
                                    del_008_WIKITable_WIKIText()
                                End If
                            Else
                                del_010_WIKIDocPart_WIKIText()
                                del_009_WIKIDocPart()
                                del_008_WIKITable_WIKIText()
                            End If
                        Else

                            del_009_WIKIDocPart()
                            del_008_WIKITable_WIKIText()
                        End If

                    Else

                        del_008_WIKITable_WIKIText()
                    End If
                Else
                    del_001_Table()
                End If
                


            Else
                del_001_Table()
            End If
        Else

            objSemItem_WIKITable = Nothing

        End If

        Return objSemItem_WIKITable
    End Function
    Public Function del_001_Table() As Boolean
        Dim objDRC_LogState As DataRowCollection
        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_WIKITable.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function save_002_Row() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_WIKIRow.GUID, objSemItem_WIKIRow.Name, objSemItem_WIKIRow.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_002_Row() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_WIKIRow.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_003_Col() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_WIKICol.GUID, objSemItem_WIKICol.Name, objSemItem_WIKICol.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function del_003_Col(ByVal objSemItem_Col As clsSemItem) As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_Col.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_004_Col_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_WIKICol.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, strText, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            GUID_TokenAttribute_WIKIText = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_004_Col_WIKIText(ByVal GUID_TokenAttribute As Guid) As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBwork_Del_TokenAttribute.GetData(GUID_TokenAttribute).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function save_005_Row_To_Col() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_WIKIRow.GUID, objSemItem_WIKICol.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, objSemItem_WIKICol.Level).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_005_Row_To_col(ByVal objSemItem_Col As clsSemItem) As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_WIKIRow.GUID, objSemItem_Col.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_006_Row_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_WIKIRow.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, objSemItem_WIKIRow.Additional1, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            objSemItem_WIKIRow.GUID_Related = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_006_Row_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBwork_Del_TokenAttribute.GetData(objSemItem_WIKIRow.GUID_Related).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_007_WIKITable_To_WIKIRow() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_WIKITable.GUID, objSemItem_WIKIRow.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, objSemItem_WIKIRow.Level).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function del_007_WIKITable_To_WIKIRow() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_WIKITable.GUID, objSemItem_WIKIRow.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_008_WIKITable_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_WIKITable.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, objSemItem_WIKITable.Additional1, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            GUID_TokenAttribute_WIKIText = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            GUID_TokenAttribute_WIKIText = Nothing
            Return False
        End If
    End Function

    Public Function del_008_WIKITable_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBwork_Del_TokenAttribute.GetData(GUID_TokenAttribute_WIKIText).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function save_009_WIKIDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection
        objSemItem_WIKIDocPart = New clsSemItem
        objSemItem_WIKIDocPart.GUID = Guid.NewGuid
        objSemItem_WIKIDocPart.Name = objSemItem_WIKITable.Name
        objSemItem_WIKIDocPart.GUID_Parent = objLocalConfig.SemItem_Type_Wiki_Document_Parts.GUID
        objSemItem_WIKIDocPart.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem_WIKIDocPart.GUID, objSemItem_WIKIDocPart.Name, objSemItem_WIKIDocPart.GUID_Parent, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_009_WIKIDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_Token.GetData(objSemItem_WIKIDocPart.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function save_010_WIKIDocPart_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.GetData(objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_Attribute_Wiki_Text.GUID, Nothing, objSemItem_WIKITable.Additional1, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            GUID_TokenAttribute_WIKITextDocPart = objDRC_LogState(0).Item("GUID_TokenAttribute")
            Return True
        Else
            GUID_TokenAttribute_WIKITextDocPart = Nothing
            Return False
        End If
    End Function

    Public Function del_010_WIKIDocPart_WIKIText() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBwork_Del_TokenAttribute.GetData(GUID_TokenAttribute_WIKITextDocPart).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_011_WIKITable_To_WIKIDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_WIKITable.GUID, objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID, 0).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function del_011_WIKITable_To_WIKIDocPart() As Boolean
        Dim objdRC_LogState As DataRowCollection

        objdRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_WIKITable.GUID, objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_RelationType_is.GUID).Rows
        If objdRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function save_012_WIKIDocument_To_WIKIDocPart() As Boolean
        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_WikiDoc.GUID, objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID, intOrderID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function del_012_WIKIDocument_To_WIKIDocPart() As Boolean

        Dim objDRC_LogState As DataRowCollection

        objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_WikiDoc.GUID, objSemItem_WIKIDocPart.GUID, objLocalConfig.SemItem_RelationType_contains.GUID).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_WikiDoc As clsSemItem, ByVal OrderID As Integer, ByVal FirstRowBold As Boolean, ByVal BorderWidth As Integer)
        objLocalConfig = LocalConfig
        intOrderID = OrderID
        boolFirstRowBold = FirstRowBold
        intBorderWidth = BorderWidth
        objSemItem_WikiDoc = SemItem_WikiDoc
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHARMAX.Connection = objLocalConfig.Connection_DB
        semprocA_DBwork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        objTagWork = New clsTagWork(objLocalConfig)
    End Sub
End Class
