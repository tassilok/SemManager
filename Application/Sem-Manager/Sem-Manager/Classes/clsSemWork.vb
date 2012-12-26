Public Class clsSemWork
    Private semtblA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter
    Private semtblA_RelationType As New ds_SemDBTableAdapters.semtbl_RelationTypeTableAdapter
    Private semtblA_Type As New ds_SemDBTableAdapters.semtbl_TypeTableAdapter
    Private semtblA_Type_Type As New ds_SemDBTableAdapters.semtbl_Type_TypeTableAdapter
    Private semtblA_Type_OR As New ds_SemDBTableAdapters.semtbl_Type_ORTableAdapter
    Private semtblA_Type_Attribute As New ds_SemDBTableAdapters.semtbl_Type_AttributeTableAdapter
    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private semtblA_Token_Token As New ds_SemDBTableAdapters.semtbl_Token_TokenTableAdapter
    Private semtblA_OR_Attribute As New ds_SemDBTableAdapters.semtbl_OR_AttributeTableAdapter

    Private funcA_Token_OR As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private funcA_TokenAttribute_Named As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter

    Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Token_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Type_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter
    Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter

    Public semtblT_Attribute As New ds_SemDB.semtbl_AttributeDataTable
    Public semtblT_RelationType As New ds_SemDB.semtbl_RelationTypeDataTable
    Public semtblT_Type As New ds_SemDB.semtbl_TypeDataTable
    Public semtblT_Type_Deny As New ds_SemDB.semtbl_TypeDataTable
    Public semtblT_Token As New ds_SemDB.semtbl_TokenDataTable
    Public semtblT_Type_Type As New ds_SemDB.semtbl_Type_TypeDataTable
    Public semtblT_Type_Attribute As New ds_SemDB.semtbl_Type_AttributeDataTable
    Public semtblT_Token_Token As New ds_SemDB.semtbl_Token_TokenDataTable
    Public semtblT_OR As New ds_SemDB.semtbl_ORDataTable
    Public semtblT_OR_Token As New ds_SemDB.semtbl_OR_TokenDataTable
    Public semtblT_OR_Attribute As New ds_SemDB.semtbl_OR_AttributeDataTable
    Public semtblT_OR_RelationType As New ds_SemDB.semtbl_OR_RelationTypeDataTable
    Public semtblT_OR_Token_Attribute_Bit As New ds_SemDB.semtbl_OR_Token_Attribute_BitDataTable
    Public semtblT_OR_Token_Attribute_Date As New ds_SemDB.semtbl_OR_Token_Attribute_DateDataTable
    Public semtblT_OR_Token_Attribute_Datetime As New ds_SemDB.semtbl_OR_Token_Attribute_DatetimeDataTable
    Public semtblT_OR_Token_Attribute_Int As New ds_SemDB.semtbl_OR_Token_Attribute_IntDataTable
    Public semtblT_OR_Token_Attribute_Real As New ds_SemDB.semtbl_OR_Token_Attribute_RealDataTable
    Public semtblT_OR_Token_Attribute_Time As New ds_SemDB.semtbl_OR_Token_Attribute_TimeDataTable
    Public semtblT_OR_Token_Attribute_Varchar255 As New ds_SemDB.semtbl_OR_Token_Attribute_Varchar255DataTable
    Public semtblT_OR_Token_Attribute_VarcharMax As New ds_SemDB.semtbl_OR_Token_Attribute_VARCHARMAXDataTable
    Public semtblT_OR_Token_Token As New ds_SemDB.semtbl_OR_Token_TokenDataTable
    Public semtblT_OR_Type As New ds_SemDB.semtbl_OR_TypeDataTable
    Public semtblT_Token_Attribute As New ds_SemDB.semtbl_Token_AttributeDataTable
    Public semtblT_Token_Attribute_Bit As New ds_SemDB.semtbl_Token_Attribute_BitDataTable
    Public semtblT_Token_Attribute_Date As New ds_SemDB.semtbl_Token_Attribute_DateDataTable
    Public semtblT_Token_Attribute_datetime As New ds_SemDB.semtbl_Token_attribute_datetimeDataTable
    Public semtblT_Token_Attribute_Int As New ds_SemDB.semtbl_Token_Attribute_IntDataTable
    Public semtblT_Token_Attribute_Real As New ds_SemDB.semtbl_Token_Attribute_RealDataTable
    Public semtblT_Token_Attribute_Time As New ds_SemDB.semtbl_Token_Attribute_TimeDataTable
    Public semtblT_Token_Attribute_varchar255 As New ds_SemDB.semtbl_Token_Attribute_varchar255DataTable
    Public semtblT_Token_Attribute_varcharMAX As New ds_SemDB.semtbl_Token_Attribute_varcharMAXDataTable
    Public semtblT_Token_OR As New ds_SemDB.semtbl_Token_ORDataTable
    Public semtblT_Type_OR As New ds_SemDB.semtbl_Type_ORDataTable

    Private objLocalConfig As clsLocalConfig_SemWork

    Private boolParent As Boolean = True
    Private boolChilds As Boolean = False
    Private boolRels As Boolean = False
    Private strStep As String
    Private intToDo As Integer
    Private intDone As Integer

    Public ReadOnly Property CountToDo As Integer
        Get
            Return intToDo
        End Get
    End Property

    Public ReadOnly Property CountDone As Integer
        Get
            Return intDone
        End Get
    End Property

    Public ReadOnly Property WorkStep As String
        Get
            Return strStep
        End Get
    End Property
    Public Property Relations As Boolean
        Get
            Return boolRels
        End Get
        Set(ByVal value As Boolean)
            boolRels = value
        End Set
    End Property
    Public Sub add_Type_For_Deny(ByVal objSemItem_Type As clsSemItem)
        semtblT_Type_Deny.Rows.Add(objSemItem_Type.GUID, objSemItem_Type.Name, objSemItem_Type.GUID_Parent)
    End Sub
    Private Function clear_Tables() As Boolean
        semtblT_Attribute.Clear()
        semtblT_OR.Clear()
        semtblT_OR_Attribute.Clear()
        semtblT_OR_RelationType.Clear()
        semtblT_OR_Token_Attribute_Bit.Clear()
        semtblT_OR_Token_Attribute_Date.Clear()
        semtblT_OR_Token_Attribute_Datetime.Clear()
        semtblT_OR_Token_Attribute_Int.Clear()
        semtblT_OR_Token_Attribute_Real.Clear()
        semtblT_OR_Token_Attribute_Time.Clear()
        semtblT_OR_Token_Attribute_Varchar255.Clear()
        semtblT_OR_Token_Attribute_VarcharMax.Clear()
        semtblT_OR_Token.Clear()
        semtblT_OR_Token_Token.Clear()
        semtblT_OR_Type.Clear()
        semtblT_RelationType.Clear()
        semtblT_Token.Clear()
        semtblT_Token_Attribute.Clear()
        semtblT_Token_Attribute_Bit.Clear()
        semtblT_Token_Attribute_Date.Clear()
        semtblT_Token_Attribute_datetime.Clear()
        semtblT_Token_Attribute_Int.Clear()
        semtblT_Token_Attribute_Real.Clear()
        semtblT_Token_Attribute_Time.Clear()
        semtblT_Token_Attribute_varchar255.Clear()
        semtblT_Token_Attribute_varcharMAX.Clear()
        semtblT_Token_OR.Clear()
        semtblT_Token_Token.Clear()
        semtblT_Type.Clear()
        semtblT_Type_Attribute.Clear()
        semtblT_Type_OR.Clear()
        semtblT_Type_Type.Clear()
    End Function

    Public Function add_Attribute(ByVal GUID_Attribute As Guid) As Boolean
        Dim objDRC_Attribute As DataRowCollection
        Dim objDRs_Attribute() As DataRow

        objDRC_Attribute = semtblA_Attribute.GetData_By_GUID(GUID_Attribute).Rows
        If objDRC_Attribute.Count > 0 Then
            objDRs_Attribute = semtblT_Attribute.Select("GUID_Attribute='" & GUID_Attribute.ToString & "'")
            If objDRs_Attribute.Count = 0 Then
                semtblT_Attribute.Rows.Add(objDRC_Attribute(0).Item("GUID_Attribute"), objDRC_Attribute(0).Item("Name_Attribute"), objDRC_Attribute(0).Item("GUID_AttributeType"))
            End If
            Return True
        Else
            Return False
        End If
    End Function

    Public Function add_RelationType(ByVal GUID_RelationType As Guid) As Boolean
        Dim objDRC_RelationType As DataRowCollection
        Dim objDRs_RelationType() As DataRow

        objDRC_RelationType = semtblA_RelationType.GetData_By_GUID(GUID_RelationType).Rows
        If objDRC_RelationType.Count > 0 Then
            objDRs_RelationType = semtblT_RelationType.Select("GUID_RelationType='" & GUID_RelationType.ToString & "'")
            If objDRs_RelationType.Count = 0 Then
                semtblT_RelationType.Rows.Add(objDRC_RelationType(0).Item("GUID_RelationType"), objDRC_RelationType(0).Item("Name_RelationType"))
            End If
        Else
            Return False
        End If
    End Function

    Public Function add_Type(ByVal GUID_Type As Guid, ByVal get_Parent As Boolean, Optional ByVal get_Childs As Boolean = False) As Boolean
        Dim objDRC_Type As DataRowCollection
        Dim objDRC_Token As DataRowCollection
        Dim objDR_Token As DataRow
        Dim objDRs_Type() As DataRow
        Dim objDR_Type_Deny As DataRow
        Dim boolAdd_Token As Boolean
        Dim boolRels As Boolean
        Dim boolParent As Boolean
        Dim boolChilds As Boolean
        Dim boolResult As Boolean

        boolParent = get_Parent
        boolChilds = get_Childs

        objDRC_Type = semtblA_Type.GetData_By_GUID(GUID_Type).Rows
        boolResult = True
        If objDRC_Type.Count > 0 Then
            objDRs_Type = semtblT_Type.Select("GUID_Type='" & GUID_Type.ToString & "'")
            If objDRs_Type.Count = 0 Then
                semtblT_Type.Rows.Add(objDRC_Type(0).Item("GUID_Type"), objDRC_Type(0).Item("Name_Type"), objDRC_Type(0).Item("GUID_Type_Parent"))
                If boolParent = True Then
                    If Not IsDBNull(objDRC_Type(0).Item("GUID_Type_Parent")) Then


                        add_Type(objDRC_Type(0).Item("GUID_Type_Parent"), boolParent, False)


                    End If
                End If
                If boolRels = True Then


                    add_TypeRel(objDRC_Type(0).Item("GUID_Type"))
                    add_TypeRelOR(objDRC_Type(0).Item("GUID_Type"))
                    add_TypeAttribute(objDRC_Type(0).Item("GUID_Type"))
                End If

            End If
            If boolChilds = True Then
                boolAdd_Token = True
                If semtblT_Type_Deny.Rows.Count > 0 Then
                    For Each objDR_Type_Deny In semtblT_Type_Deny.Rows
                        If objDRC_Type(0).Item("GUID_Type") = objDR_Type_Deny.Item("GUID_Type") Then
                            boolAdd_Token = False
                            Exit For
                        End If
                    Next
                End If
                If boolAdd_Token = True Then
                    objDRC_Token = semtblA_Token.GetData_Token_TypeChilds(GUID_Type).Rows
                    For Each objDR_Token In objDRC_Token
                        add_Token(objDR_Token.Item("GUID_Token"))
                    Next
                End If

            End If
        Else
            boolResult = False
        End If
        Return boolResult
    End Function

    Public Function add_Token(ByVal GUID_Token As Guid) As Boolean
        Dim objDRC_Token As DataRowCollection
        Dim objDRs_Token() As DataRow
        Dim objDR_Type_Deny As DataRow
        Dim boolAddToken As Boolean

        objDRC_Token = semtblA_Token.GetData_Token_By_GUID(GUID_Token).Rows
        If objDRC_Token.Count > 0 Then
            If boolParent = True Then
                add_Type(objDRC_Token(0).Item("GUID_Type"), boolParent, boolChilds)
            End If
            boolAddToken = True
            If semtblT_Type_Deny.Rows.Count > 0 Then
                For Each objDR_Type_Deny In semtblT_Type_Deny.Rows
                    If objDRC_Token(0).Item("GUID_Type") = objDR_Type_Deny.Item("GUID_Type") Then
                        boolAddToken = False
                        Exit For
                    End If
                Next
            End If

            If boolAddToken = True Then


                objDRs_Token = semtblT_Token.Select("GUID_Token='" & GUID_Token.ToString & "'")
                If objDRs_Token.Count = 0 Then
                    semtblT_Token.Rows.Add(objDRC_Token(0).Item("GUID_Token"), _
                                           objDRC_Token(0).Item("Name_Token"), _
                                           objDRC_Token(0).Item("GUID_Type"))


                End If
                add_TokenAttribute(GUID_Token)
                If boolRels = True Then
                    add_TokenRel(GUID_Token)

                    add_Token_ORRel(GUID_Token)
                End If
            End If


        End If


        Return True
    End Function

    Private Function add_TokenRel(ByVal GUID_Token As Guid) As Boolean
        Dim objDRC_TokenRel As DataRowCollection
        Dim objDR_TokenRel As DataRow
        Dim objDRs_TokenRel() As DataRow

        objDRC_TokenRel = semtblA_Token_Token.GetData_Right_Tokens_By_GUID_Token_Left(GUID_Token).Rows
        For Each objDR_TokenRel In objDRC_TokenRel
            objDRs_TokenRel = semtblT_Token.Select("GUID_Token='" & objDR_TokenRel.Item("GUID_Token_Right").ToString & "'")
            If objDRs_TokenRel.Count = 0 Then
                add_Token(objDR_TokenRel.Item("GUID_Token_Right"))
            End If

            add_RelationType(objDR_TokenRel.Item("GUID_RelationType"))
            objDRs_TokenRel = semtblT_Token_Token.Select("GUID_Token_Left='" & objDR_TokenRel.Item("GUID_Token_Left").ToString & "' AND " & _
                                                         "GUID_Token_Right='" & objDR_TokenRel.Item("GUID_Token_Right").ToString & "' AND " & _
                                                         "GUID_RelationType='" & objDR_TokenRel.Item("GUID_RelationType").ToString & "'")
            If objDRs_TokenRel.Count = 0 Then
                semtblT_Token_Token.Rows.Add(objDR_TokenRel.Item("GUID_Token_Left"), _
                                             objDR_TokenRel.Item("GUID_Token_Right"), _
                                             objDR_TokenRel.Item("GUID_RelationType"), _
                                             objDR_TokenRel.Item("OrderID"))
            End If
        Next


        Return True
    End Function

    Public Function add_TokenAttribute(ByVal GUID_Token) As Boolean
        Dim objDRC_TokenAttribute As DataRowCollection
        Dim objDR_TokenAttribute As DataRow
        Dim objDRs_TokenAttribute() As DataRow
        Dim objDRs_TokenAttribute_Val() As DataRow

        objDRC_TokenAttribute = funcA_TokenAttribute_Named.GetData(GUID_Token).Rows
        For Each objDR_TokenAttribute In objDRC_TokenAttribute
            add_Attribute(objDR_TokenAttribute.Item("GUID_Attribute"))
            objDRs_TokenAttribute = semtblT_Token_Attribute.Select("GUID_TokenAttribute='" & objDR_TokenAttribute.Item("GUID_TokenAttribute").ToString & "'")
            If objDRs_TokenAttribute.Count = 0 Then
                semtblT_Token_Attribute.Rows.Add(objDR_TokenAttribute.Item("GUID_TokenAttribute"), _
                                                 objDR_TokenAttribute.Item("GUID_Token"), _
                                                 objDR_TokenAttribute.Item("GUID_Attribute"))

            End If
            Select Case objDR_TokenAttribute.Item("GUID_AttributeType")
                Case objLocalConfig.Globals.AttributeType_Bool.GUID
                    objDRs_TokenAttribute_Val = semtblT_Token_Attribute_Bit.Select("GUID_TokenAttribute='" & objDR_TokenAttribute.Item("GUID_TokenAttribute").ToString & "'")
                    If objDRs_TokenAttribute_Val.Count = 0 Then
                        semtblT_Token_Attribute_Bit.Rows.Add(objDR_TokenAttribute.Item("GUID_TokenAttribute"), _
                                                             objDR_TokenAttribute.Item("Val_BOOL"), _
                                                             objDR_TokenAttribute.Item("OrderID"))
                    End If
                Case objLocalConfig.Globals.AttributeType_Date.GUID
                    objDRs_TokenAttribute_Val = semtblT_Token_Attribute_Date.Select("GUID_TokenAttribute='" & objDR_TokenAttribute.Item("GUID_TokenAttribute").ToString & "'")
                    If objDRs_TokenAttribute_Val.Count = 0 Then
                        semtblT_Token_Attribute_Date.Rows.Add(objDR_TokenAttribute.Item("GUID_TokenAttribute"), _
                                                             objDR_TokenAttribute.Item("Val_DATE"), _
                                                             objDR_TokenAttribute.Item("OrderID"))
                    End If
                Case objLocalConfig.Globals.AttributeType_Datetime.GUID
                    objDRs_TokenAttribute_Val = semtblT_Token_Attribute_datetime.Select("GUID_TokenAttribute='" & objDR_TokenAttribute.Item("GUID_TokenAttribute").ToString & "'")
                    If objDRs_TokenAttribute_Val.Count = 0 Then
                        semtblT_Token_Attribute_datetime.Rows.Add(objDR_TokenAttribute.Item("GUID_TokenAttribute"), _
                                                             objDR_TokenAttribute.Item("Val_Datetime"), _
                                                             objDR_TokenAttribute.Item("OrderID"))
                    End If

                Case objLocalConfig.Globals.AttributeType_Int.GUID
                    objDRs_TokenAttribute_Val = semtblT_Token_Attribute_Int.Select("GUID_TokenAttribute='" & objDR_TokenAttribute.Item("GUID_TokenAttribute").ToString & "'")
                    If objDRs_TokenAttribute_Val.Count = 0 Then
                        semtblT_Token_Attribute_Int.Rows.Add(objDR_TokenAttribute.Item("GUID_TokenAttribute"), _
                                                             objDR_TokenAttribute.Item("Val_Int"), _
                                                             objDR_TokenAttribute.Item("OrderID"))
                    End If
                Case objLocalConfig.Globals.AttributeType_Real.GUID
                    objDRs_TokenAttribute_Val = semtblT_Token_Attribute_Real.Select("GUID_TokenAttribute='" & objDR_TokenAttribute.Item("GUID_TokenAttribute").ToString & "'")
                    If objDRs_TokenAttribute_Val.Count = 0 Then
                        semtblT_Token_Attribute_Real.Rows.Add(objDR_TokenAttribute.Item("GUID_TokenAttribute"), _
                                                             objDR_TokenAttribute.Item("Val_Real"), _
                                                             objDR_TokenAttribute.Item("OrderID"))
                    End If

                Case objLocalConfig.Globals.AttributeType_String.GUID
                    objDRs_TokenAttribute_Val = semtblT_Token_Attribute_varcharMAX.Select("GUID_TokenAttribute='" & objDR_TokenAttribute.Item("GUID_TokenAttribute").ToString & "'")
                    If objDRs_TokenAttribute_Val.Count = 0 Then
                        semtblT_Token_Attribute_varcharMAX.Rows.Add(objDR_TokenAttribute.Item("GUID_TokenAttribute"), _
                                                             objDR_TokenAttribute.Item("Val_VARCHARMAX"), _
                                                             objDR_TokenAttribute.Item("OrderID"))
                    End If
                Case objLocalConfig.Globals.AttributeType_Time.GUID
                    objDRs_TokenAttribute_Val = semtblT_Token_Attribute_Time.Select("GUID_TokenAttribute='" & objDR_TokenAttribute.Item("GUID_TokenAttribute").ToString & "'")
                    If objDRs_TokenAttribute_Val.Count = 0 Then
                        semtblT_Token_Attribute_Time.Rows.Add(objDR_TokenAttribute.Item("GUID_TokenAttribute"), _
                                                             objDR_TokenAttribute.Item("Val_Time"), _
                                                             objDR_TokenAttribute.Item("OrderID"))
                    End If
                Case objLocalConfig.Globals.AttributeType_Varchar255.GUID
                    objDRs_TokenAttribute_Val = semtblT_Token_Attribute_varchar255.Select("GUID_TokenAttribute='" & objDR_TokenAttribute.Item("GUID_TokenAttribute").ToString & "'")
                    If objDRs_TokenAttribute_Val.Count = 0 Then
                        semtblT_Token_Attribute_varchar255.Rows.Add(objDR_TokenAttribute.Item("GUID_TokenAttribute"), _
                                                             objDR_TokenAttribute.Item("Val_VARCHAR255"), _
                                                             objDR_TokenAttribute.Item("OrderID"))
                    End If
            End Select
        Next
        Return True
    End Function

    Public Function add_Token_ORRel(ByVal GUID_Token As Guid) As Boolean
        Dim objDRC_Token_ORRel As DataRowCollection
        Dim objDR_Token_ORRel As DataRow
        Dim objDRs_Token_OR() As DataRow
        Dim objDRs_Token_OR_Type() As DataRow

        objDRC_Token_ORRel = funcA_Token_OR.GetData_By_GUIDTokenLeft(GUID_Token).Rows

        For Each objDR_Token_ORRel In objDRC_Token_ORRel
            objDRs_Token_OR = semtblT_OR.Select("GUID_ObjectReference='" & objDR_Token_ORRel.Item("GUID_ObjectReference").ToString & "'")
            If objDRs_Token_OR.Count = 0 Then
                semtblT_OR.Rows.Add(objDR_Token_ORRel.Item("GUID_ObjectReference"), _
                                    objDR_Token_ORRel.Item("GUID_ItemType"))
            End If
            Select Case objDR_Token_ORRel.Item("GUID_ItemType")
                Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                    add_Attribute(objDR_Token_ORRel.Item("GUID_Ref"))
                    objDRs_Token_OR_Type = semtblT_OR_Attribute.Select("GUID_ObjectReference='" & objDR_Token_ORRel.Item("GUID_ObjectReference").ToString & "'")
                    If objDRs_Token_OR_Type.Count = 0 Then
                        semtblT_OR_Attribute.Rows.Add(objDR_Token_ORRel.Item("guid_objectreference"), _
                                                      objDR_Token_ORRel.Item("GUID_Ref"))
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_AttributeType.GUID

                Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

                    add_RelationType(objDR_Token_ORRel.Item("GUID_Ref"))
                    objDRs_Token_OR_Type = semtblT_OR_RelationType.Select("GUID_ObjectReference='" & objDR_Token_ORRel.Item("GUID_ObjectReference").ToString & "'")
                    If objDRs_Token_OR_Type.Count = 0 Then
                        semtblT_OR_RelationType.Rows.Add(objDR_Token_ORRel.Item("GUID_ObjectReference"), _
                                                         objDR_Token_ORRel.Item("GUID_Ref"))
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    add_Token(objDR_Token_ORRel.Item("GUID_Ref"))
                    objDRs_Token_OR_Type = semtblT_OR_Token.Select("GUID_ObjectReference='" & objDR_Token_ORRel.Item("GUID_ObjectReference").ToString & "'")
                    If objDRs_Token_OR_Type.Count = 0 Then
                        semtblT_OR_Token.Rows.Add(objDR_Token_ORRel.Item("GUID_ObjectReference"), _
                                                         objDR_Token_ORRel.Item("GUID_Ref"))
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.GUID

                Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.GUID

                Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.GUID

                Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.GUID

                Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.GUID

                Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.GUID

                Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.GUID

                Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.GUID

                Case objLocalConfig.Globals.ObjectReferenceType_TokenToken.GUID

                Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                    add_Type(objDR_Token_ORRel.Item("GUID_Ref"), boolParent, boolChilds)
                    objDRs_Token_OR_Type = semtblT_OR_Type.Select("GUID_ObjectReference='" & objDR_Token_ORRel.Item("GUID_ObjectReference").ToString & "'")
                    If objDRs_Token_OR_Type.Count = 0 Then
                        semtblT_OR_Type.Rows.Add(objDR_Token_ORRel.Item("GUID_ObjectReference"), _
                                                         objDR_Token_ORRel.Item("GUID_Ref"))
                    End If
                Case objLocalConfig.Globals.ObjectReferenceType_TypeAttribute.GUID

                Case objLocalConfig.Globals.ObjectReferenceType_TypeType.GUID

            End Select
            objDRs_Token_OR = semtblT_Token_OR.Select("GUID_Token_Left='" & objDR_Token_ORRel.Item("GUID_Token_Left").ToString & "' AND " & _
                                                      "GUID_ObjectReference='" & objDR_Token_ORRel.Item("GUID_ObjectReference").ToString & "' AND " & _
                                                      "GUID_RelationType='" & objDR_Token_ORRel.Item("GUID_RelationType").ToString & "'")
            If objDRs_Token_OR.Count = 0 Then
                semtblT_Token_OR.Rows.Add(objDR_Token_ORRel.Item("GUID_Token_Left"), _
                                          objDR_Token_ORRel.Item("GUID_ObjectReference"), _
                                          objDR_Token_ORRel.Item("GUID_RelationType"), _
                                          objDR_Token_ORRel.Item("OrderID"))
            End If
        Next
    End Function

    Private Function add_TypeRel(ByVal GUID_Type_Left As Guid) As Boolean
        Dim objDRC_TypeRel As DataRowCollection
        Dim objDR_TypeRel As DataRow
        Dim objDRs_TypeRel() As DataRow

        objDRC_TypeRel = semtblA_Type_Type.GetData_By_GUIDTypeLeft(GUID_Type_Left).Rows
        For Each objDR_TypeRel In objDRC_TypeRel
            add_Type(objDR_TypeRel.Item("GUID_Type_Right"), boolParent, boolChilds)
            add_RelationType(objDR_TypeRel.Item("GUID_RelationType"))
            objDRs_TypeRel = semtblT_Type_Type.Select("GUID_Type_Left='" & GUID_Type_Left.ToString & "' AND GUID_Type_Right='" & objDR_TypeRel.Item("GUID_Type_Right").ToString & "' AND " & _
                                                      "GUID_RelationType='" & objDR_TypeRel.Item("GUID_RelationType").ToString & "'")
            If objDRs_TypeRel.Count = 0 Then
                semtblT_Type_Type.Rows.Add(objDR_TypeRel.Item("GUID_Type_Left"), _
                                       objDR_TypeRel.Item("GUID_Type_Right"), _
                                       objDR_TypeRel.Item("GUID_RelationType"), _
                                       objDR_TypeRel.Item("Min_forw"), _
                                       objDR_TypeRel.Item("Max_forw"), _
                                       objDR_TypeRel.Item("Max_backw"))
            End If
            
        Next

        Return True
    End Function

    Private Function add_TypeRelOR(ByVal GUID_Type As Guid) As Boolean
        Dim objDRC_TypeRelOR As DataRowCollection
        Dim objDR_TypeRelOR As DataRow
        Dim objDRs_TypeRelOR() As DataRow


        objDRC_TypeRelOR = semtblA_Type_OR.GetData_By_GUIDType(GUID_Type).Rows
        For Each objDR_TypeRelOR In objDRC_TypeRelOR
            add_RelationType(objDR_TypeRelOR.Item("GUID_RelationType"))
            objDRs_TypeRelOR = semtblT_Type_OR.Select("GUID_Type='" & GUID_Type.ToString & "' AND GUID_RelationType='" & objDR_TypeRelOR.Item("GUID_RelationType").ToString & "'")
            If objDRs_TypeRelOR.Count = 0 Then
                add_RelationType(objDRC_TypeRelOR(0).Item("GUID_RelationType"))
                semtblT_Type_OR.Rows.Add(objDR_TypeRelOR.Item("GUID_Type"), _
                                         objDR_TypeRelOR.Item("GUID_RelationType"), _
                                         objDR_TypeRelOR.Item("Min_forw"), _
                                         objDR_TypeRelOR.Item("Max_forw"))

            End If
        Next

        Return True
    End Function

    Private Function add_TypeAttribute(ByVal GUID_Type As Guid) As Boolean
        Dim objDRC_TypeAttribute As DataRowCollection
        Dim objDR_TypeAttribute As DataRow
        Dim objDRs_TypeAttribute() As DataRow

        objDRC_TypeAttribute = semtblA_Type_Attribute.GetData_By_GUIDType(GUID_Type).Rows
        For Each objDR_TypeAttribute In objDRC_TypeAttribute
            objDRs_TypeAttribute = semtblT_Type_Attribute.Select("GUID_Type='" & GUID_Type.ToString & "' AND GUID_Attribute='" & objDR_TypeAttribute.Item("GUID_Attribute").ToString & "'")
            If objDRs_TypeAttribute.Count = 0 Then
                add_Attribute(objDR_TypeAttribute.Item("GUID_Attribute"))
                semtblT_Type_Attribute.Rows.Add(objDR_TypeAttribute.Item("GUID_Type"), _
                                       objDR_TypeAttribute.Item("GUID_Attribute"), _
                                       objDR_TypeAttribute.Item("Min"), _
                                       objDR_TypeAttribute.Item("Max"))
            End If
        Next

        Return True
    End Function

    Public Function relate_added_Items() As clsSemItem
        Dim semtblT_Token_Cpy As New ds_SemDB.semtbl_TokenDataTable

        Dim objSemItem_Result As clsSemItem
        Dim objDR_Type As DataRow
        Dim objDRs_Types_Left() As DataRow
        Dim objDRs_Types_Right() As DataRow
        Dim objDRC_TypeType As DataRowCollection
        Dim objDR_TypeType As DataRow
        Dim objDRC_TypeAttribute As DataRowCollection
        Dim objDR_TypeAttribute As DataRow

        Dim objDR_Token_Added As DataRow
        Dim objDRC_TokenToken As DataRowCollection
        Dim objDR_TokenToken As DataRow
        Dim objDRs_TokenToken() As DataRow
        Dim objDRC_Token_Or As DataRowCollection
        Dim objDR_Token_Or As DataRow
        Dim objDRs_TokenOr() As DataRow

        Dim objDRC_Type_Or As DataRowCollection
        Dim objDR_Type_Or As DataRow
        Dim objDRs_Type_Or() As DataRow



        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        objDRC_TypeType = semtblA_Type_Type.GetData.Rows
        strStep = "TypeType"
        intToDo = objDRC_TypeType.Count
        intDone = 0
        For Each objDR_TypeType In objDRC_TypeType
            objDRs_Types_Left = semtblT_Type.Select("GUID_Type='" & objDR_TypeType.Item("GUID_Type_Left").ToString & "'")
            objDRs_Types_Right = semtblT_Type.Select("GUID_Type='" & objDR_TypeType.Item("GUID_Type_Right").ToString & "'")

            If objDRs_Types_Left.Count > 0 And objDRs_Types_Right.Count > 0 Then
                add_RelationType(objDR_TypeType.Item("GUID_RelationType"))
                semtblT_Type_Type.Rows.Add(objDR_TypeType.Item("GUID_Type_Left"), _
                                           objDR_TypeType.Item("GUID_Type_Right"), _
                                           objDR_TypeType.Item("GUID_RelationType"), _
                                           objDR_TypeType.Item("Min_forw"), _
                                           objDR_TypeType.Item("Max_forw"), _
                                           objDR_TypeType.Item("Max_backw"))

            End If

            intDone = intDone + 1
        Next

        strStep = "Token"
        intToDo = semtblT_Token.Rows.Count
        intDone = 0
        For intDone = 0 To intToDo - 1
            semtblT_Token_Cpy.ImportRow(semtblT_Token.Rows(intDone))
        Next
        intDone = 0


        For Each objDR_Token_Added In semtblT_Token_Cpy.Rows
            objDRC_TokenToken = semtblA_Token_Token.GetData_Right_Tokens_By_GUID_Token_Left(objDR_Token_Added.Item("GUID_Token")).Rows
            For Each objDR_TokenToken In objDRC_TokenToken
                objDRs_TokenToken = semtblT_Token.Select("GUID_Token='" & objDR_TokenToken.Item("GUID_TokeN_Right").ToString & "'")
                If objDRs_TokenToken.Count > 0 Then
                    semtblT_Token_Token.Rows.Add(objDR_TokenToken.Item("GUID_Token_Left"), _
                                                 objDR_TokenToken.Item("GUID_Token_Right"), _
                                                 objDR_TokenToken.Item("GUID_RelationType"), _
                                                 objDR_TokenToken.Item("OrderID"))

                End If
            Next
            objDRC_Token_Or = funcA_Token_OR.GetData_By_GUIDTokenLeft(objDR_Token_Added.Item("GUID_Token")).Rows
            For Each objDR_Token_Or In objDRC_Token_Or
                Select Case objDR_Token_Or.Item("GUID_ItemType")
                    Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID
                        objDRs_TokenOr = semtblT_Attribute.Select("GUID_Attribute='" & objDR_Token_Or.Item("GUID_Ref").ToString & "'")
                        If objDRs_TokenOr.Count > 0 Then
                            add_RelationType(objDR_Token_Or.Item("GUID_RelationType"))
                            add_Token_ORRel(objDR_Token_Added.Item("GUID_Token"))
                        End If
                    Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID
                        objDRs_TokenOr = semtblT_RelationType.Select("GUID_RelationType='" & objDR_Token_Or.Item("GUID_Ref").ToString & "'")
                        If objDRs_TokenOr.Count > 0 Then
                            add_RelationType(objDR_Token_Or.Item("GUID_RelationType"))
                            add_Token_ORRel(objDR_Token_Added.Item("GUID_Token"))
                        End If
                    Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                        objDRs_TokenOr = semtblT_Token.Select("GUID_Token='" & objDR_Token_Or.Item("GUID_Ref").ToString & "'")
                        If objDRs_TokenOr.Count > 0 Then
                            add_RelationType(objDR_Token_Or.Item("GUID_RelationType"))
                            add_Token_ORRel(objDR_Token_Added.Item("GUID_Token"))
                        End If
                    Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeBit.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDate.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeDatetime.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeInt.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeReal.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeTime.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarchar255.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_TokenAttributeVarcharMAX.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_TokenToken.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID
                        objDRs_TokenOr = semtblT_Type.Select("GUID_Type='" & objDR_Token_Or.Item("GUID_Ref").ToString & "'")
                        If objDRs_TokenOr.Count > 0 Then
                            add_RelationType(objDR_Token_Or.Item("GUID_RelationType"))
                            add_Token_ORRel(objDR_Token_Added.Item("GUID_Token"))
                        End If
                    Case objLocalConfig.Globals.ObjectReferenceType_TypeAttribute.GUID
                    Case objLocalConfig.Globals.ObjectReferenceType_TypeType.GUID

                End Select
            Next
            intDone = intDone + 1
        Next

        strStep = "Type"
        intToDo = semtblT_Type.Rows.Count
        intDone = 0
        For Each objDR_Type In semtblT_Type.Rows
            add_TypeAttribute(objDR_Type.Item("GUID_Type"))

            objDRC_Type_Or = semtblA_Type_OR.GetData_By_GUIDType(objDR_Type.Item("GUID_Type")).Rows
            For Each objDR_Type_Or In objDRC_Type_Or

                objDRs_Type_Or = semtblT_RelationType.Select("GUID_RelationType='" & objDR_Type_Or.Item("GUID_RelationType").ToString & "'")
                If objDRs_Type_Or.Count > 0 Then
                    semtblT_Type_OR.Rows.Add(objDR_Type_Or.Item("GUID_Type"), _
                                             objDR_Type_Or.Item("GUID_RelationType"), _
                                             objDR_Type_Or.Item("Min_forw"), _
                                             objDR_Type_Or.Item("Max_forw"))
                End If
            Next
            intDone = intDone + 1
        Next

        Return objSemItem_Result
    End Function

    Private Sub set_DBConnection()
        semtblA_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_RelationType.Connection = objLocalConfig.Connection_DB
        semtblA_Type.Connection = objLocalConfig.Connection_DB
        semtblA_Type_Type.Connection = objLocalConfig.Connection_DB
        semtblA_Type_OR.Connection = objLocalConfig.Connection_DB
        semtblA_Type_Attribute.Connection = objLocalConfig.Connection_DB
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        semtblA_Token_Token.Connection = objLocalConfig.Connection_DB

        funcA_TokenAttribute_Named.Connection = objLocalConfig.Connection_DB
        funcA_Token_OR.Connection = objLocalConfig.Connection_DB

        procA_OR_Attribute_By_GUIDObjectReference.Connection = objLocalConfig.Connection_DB
        procA_OR_RelationType_By_GUIDObjectReference.Connection = objLocalConfig.Connection_DB
        procA_OR_Token_By_GUIDObjectReference.Connection = objLocalConfig.Connection_DB
        procA_OR_Type_By_GUIDObjectReference.Connection = objLocalConfig.Connection_DB

    End Sub

    Public Sub New(ByVal objGlobals As clsGlobals)
        objLocalConfig = New clsLocalConfig_SemWork(objGlobals)

        set_DBConnection()
    End Sub
End Class
