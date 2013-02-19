Public Class clsReport

    Private objLocalConfig As clsLocalConfig
    Private objConnection As SqlClient.SqlConnection

    Private initializeA_Tables As New DataSet_ReportTableAdapters.initialize_TablesTableAdapter
    Private finalizeA_Tables As New DataSet_ReportTableAdapters.finalize_TablesTableAdapter

    Private initializeA_Table As New DataSet_ReportTableAdapters.initialize_TableTableAdapter
    Private finalizeA_Table As New DataSet_ReportTableAdapters.finalize_TableTableAdapter
    Private createA_Table_orgT As New DataSet_ReportTableAdapters.create_Table_orgTTableAdapter
    Private createA_Table_attT As New DataSet_ReportTableAdapters.create_Table_attTTableAdapter
    Private createA_Table_relT As New DataSet_ReportTableAdapters.create_Table_relTTableAdapter

    Private objDBLevel_Classes As clsDBLevel
    Private objDBLevel_CalssAtt As clsDBLevel
    Private objDBLevel_AttributeTypes As clsDBLevel
    Private objDBLevel_DataType As clsDBLevel
    Private objDBLevel_ClassRel As clsDBLevel
    Private objDBlevel_ObjAtt As clsDBLevel
    Private objDBLevel_Objects As clsDBLevel
    Private objDBLevel_ObjectRel As clsDBLevel

    Private objDBLevel_OntologyRules As clsDBLevel
    Private objDBLevel_Ontology As clsDBLevel

    Public Sub sync_SQLDB()
        sync_SQLDB_Classes()
        sync_SQLDB_Attributes()
    End Sub

    Public Sub sync_SQLDB_Relations()
        Dim objClassRel As clsClassRel
        Dim objOList_Objects_Left As New List(Of clsOntologyItem)
        Dim objOList_Objects_Right As New List(Of clsOntologyItem)
        Dim objOList_RelTypes As New List(Of clsOntologyItem)
        Dim objOItem_ORel As clsObjectRel
        Dim objTextWriter As IO.TextWriter
        Dim strPath As String
        Dim strLine As String
        Dim strType As String
        Dim i As Integer
        Dim j As Integer

        objDBLevel_ClassRel.get_Data_ClassRel(Nothing, Nothing, False, False, False)

        For Each objClassRel In objDBLevel_ClassRel.OList_ClassRel_ID
            objOList_Objects_Left.Add(New clsOntologyItem(Nothing, Nothing, objClassRel.ID_Class_Left, objLocalConfig.Globals.Type_Object))
            objOList_Objects_Right.Add(New clsOntologyItem(Nothing, Nothing, objClassRel.ID_Class_Right, objLocalConfig.Globals.Type_Object))
            objOList_RelTypes.Add(New clsOntologyItem(objClassRel.ID_RelationType, objLocalConfig.Globals.Type_RelationType))

            objDBLevel_ObjectRel.get_Data_ObjectRel(objOList_Objects_Left, objOList_Objects_Right, objOList_RelTypes, False, True)

            strPath = "%Temp%\" & Guid.NewGuid().ToString & ".xml"
            strPath = Environment.ExpandEnvironmentVariables(strPath)

            i = 0
            If objDBLevel_ObjectRel.OList_ObjectRel.Count > 0 Then
                While i < objDBLevel_ObjectRel.OList_ObjectRel.Count
                    objTextWriter = New IO.StreamWriter(strPath, False, System.Text.Encoding.UTF8)
                    strLine = "<?xml version=""1.0"" encoding=""UTF-8""?>"
                    objTextWriter.WriteLine(strLine)
                    strLine = "<root>"
                    objTextWriter.WriteLine(strLine)

                    For j = i To i + 500
                        If j < objDBLevel_ObjectRel.OList_ObjectRel.Count Then
                            objOItem_ORel = objDBLevel_ObjectRel.OList_ObjectRel(j)

                            strLine = "<tmptbl>"
                            objTextWriter.WriteLine(strLine)

                            strLine = "<GUID_Object_Left>" & objOItem_ORel.ID_Object & "</GUID_Object_Left>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<GUID_Object_Right>" & objOItem_ORel.ID_Other & "</GUID_Object_Right>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<GUID_RelationType>" & objOItem_ORel.ID_RelationType & "</GUID_RelationType>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<Name_RelationType>" & objOItem_ORel.Name_RelationType & "</Name_RelationType>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<OrderID>" & objOItem_ORel.OrderID & "</OrderID>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<Exist>1</Exist>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "</tmptbl>"
                            objTextWriter.WriteLine(strLine)
                        Else
                            Exit For
                        End If
                    Next
                    strLine = "</root>"
                    objTextWriter.WriteLine(strLine)
                    objTextWriter.Close()

                    i = j
                End While
            End If
        Next
    End Sub

    Public Sub sync_SQLDB_Attributes()
        Dim objOItem_Object As clsOntologyItem
        Dim objOItem_AttributeType As clsOntologyItem
        Dim objOItem_ObjAtt As clsObjectAtt
        Dim oList_AttributeTypes As New List(Of clsOntologyItem)
        Dim oListDataTypes As New List(Of clsOntologyItem)
        Dim objTextWriter As IO.TextWriter
        Dim strPath As String
        Dim strLine As String
        Dim strType As String
        Dim strLength As String
        Dim i As Long
        Dim j As Long


        initializeA_Tables.GetData(objLocalConfig.Globals.Type_Attribute)

        objDBLevel_AttributeTypes.get_Data_AttributeType(Nothing, False)

        For Each objOItem_AttributeType In objDBLevel_AttributeTypes.OList_AttributeTypes
            oList_AttributeTypes.Clear()
            oList_AttributeTypes.Add(New clsOntologyItem(objOItem_AttributeType.GUID, objLocalConfig.Globals.Type_AttributeType))
            objDBLevel_CalssAtt.get_Data_ClassAtt(Nothing, oList_AttributeTypes, False, True)

            Select Case objOItem_AttributeType.GUID_Parent
                Case objLocalConfig.Globals.DType_Bool.GUID
                    strType = "Bit"
                    strLength = "0"
                Case objLocalConfig.Globals.DType_DateTime.GUID
                    strType = "DateTime"
                    strLength = "0"
                Case objLocalConfig.Globals.DType_Int.GUID
                    strType = "Bigint"
                    strLength = "0"
                Case objLocalConfig.Globals.DType_Real.GUID
                    strType = "Real"
                    strLength = "0"
                Case objLocalConfig.Globals.DType_String.GUID
                    strType = "NVARCHAR"
                    strLength = "MAX"

            End Select
            oListDataTypes.Clear()
            
            oListDataTypes.Add(New clsOntologyItem(objOItem_AttributeType.GUID_Parent, objLocalConfig.Globals.Type_DataType))
            objDBLevel_DataType.get_Data_DataTyps(oListDataTypes, False)

            initializeA_Table.GetData("attT_" & objOItem_AttributeType.Name)

            strPath = "%Temp%\" & Guid.NewGuid().ToString & ".xml"
            strPath = Environment.ExpandEnvironmentVariables(strPath)

            objDBlevel_ObjAtt.get_Data_ObjectAtt(Nothing, objOItem_AttributeType, False, False)


            i = 0

            If objDBlevel_ObjAtt.OList_ObjectAtt.Count > 0 Then
                While i < objDBlevel_ObjAtt.OList_ObjectAtt.Count
                    objTextWriter = New IO.StreamWriter(strPath, False, System.Text.Encoding.UTF8)
                    strLine = "<?xml version=""1.0"" encoding=""UTF-8""?>"
                    objTextWriter.WriteLine(strLine)
                    strLine = "<root>"
                    objTextWriter.WriteLine(strLine)

                    For j = i To i + 500
                        If j < objDBlevel_ObjAtt.OList_ObjectAtt.Count Then
                            objOItem_ObjAtt = objDBlevel_ObjAtt.OList_ObjectAtt(j)
                            strLine = "<tmptbl>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<GUID_Attribute>" & objOItem_ObjAtt.ID_Attribute & "</GUID_Attribute>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<GUID_AttributeType>" & objOItem_ObjAtt.ID_AttributeType & "</GUID_AttributeType>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<Name_AttributeType><![CDATA[" & objOItem_ObjAtt.Name_AttributeType & "]]></Name_AttributeType>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<GUID_Object>" & objOItem_ObjAtt.ID_Object & "</GUID_Object>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<OrderID>" & objOItem_ObjAtt.OrderID & "</OrderID>"
                            objTextWriter.WriteLine(strLine)
                            If strType = "NVARCHAR" Then
                                strLine = "<val><![CDATA[" & Web.HttpUtility.HtmlEncode(objOItem_ObjAtt.val_Named) & "]]></val>"
                            ElseIf strType = "Real" Then
                                strLine = "<val>" & objOItem_ObjAtt.val_Named.Replace(",", ".") & "</val>"
                            Else

                                strLine = "<val>" & objOItem_ObjAtt.val_Named & "</val>"
                            End If

                            objTextWriter.WriteLine(strLine)
                            strLine = "<Exist>1</Exist>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "</tmptbl>"
                            objTextWriter.WriteLine(strLine)

                        Else
                            Exit For
                        End If
                    Next

                    strLine = "</root>"
                    objTextWriter.WriteLine(strLine)
                    objTextWriter.Close()

                    createA_Table_attT.GetData(objLocalConfig.Globals.Type_Attribute, objOItem_AttributeType.Name, strType, strLength, True, strPath)

                    i = j
                End While
            Else
                createA_Table_attT.GetData(objLocalConfig.Globals.Type_Attribute, objOItem_AttributeType.Name, strType, strLength, False, strPath)
            End If

            finalizeA_Table.GetData("attT_" & objOItem_AttributeType.Name)
        Next

        
        finalizeA_Tables.GetData(objLocalConfig.Globals.Type_Attribute)

    End Sub

    Public Sub sync_SQLDB_Classes()
        Dim objOItem_Class As clsOntologyItem
        Dim objOItem_Object As clsOntologyItem
        Dim oList_Objects As New List(Of clsOntologyItem)
        Dim objTextWriter As IO.TextWriter
        Dim strPath As String
        Dim strLine As String
        Dim i As Long
        Dim j As Long


        objDBLevel_Classes.get_Data_Classes(Nothing, False, False)
        For Each objOItem_Class In objDBLevel_Classes.OList_Classes

            initializeA_Table.GetData("orgT_" & objOItem_Class.Name)
            oList_Objects.Clear()
            oList_Objects.Add(New clsOntologyItem(Nothing, Nothing, objOItem_Class.GUID, objLocalConfig.Globals.Type_Object))
            objDBLevel_Objects.get_Data_Objects(oList_Objects, False)
            strPath = "%Temp%\" & Guid.NewGuid().ToString & ".xml"
            strPath = Environment.ExpandEnvironmentVariables(strPath)
            i = 0
            If objDBLevel_Objects.OList_Objects.Count > 0 Then
                While i < objDBLevel_Objects.OList_Objects.Count

                    objTextWriter = New IO.StreamWriter(strPath, False, System.Text.Encoding.UTF8)
                    strLine = "<?xml version=""1.0"" encoding=""UTF-8""?>"
                    objTextWriter.WriteLine(strLine)
                    strLine = "<root>"
                    objTextWriter.WriteLine(strLine)
                    For j = i To i + 500

                        If j < objDBLevel_Objects.OList_Objects.Count Then
                            objOItem_Object = objDBLevel_Objects.OList_Objects(j)
                            strLine = "<tmptbl>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<GUID>" & objOItem_Object.GUID & "</GUID>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<Name><![CDATA[" & objOItem_Object.Name & "]]></Name>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<GUID_Class>" & objOItem_Object.GUID_Parent & "</GUID_Class>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "<Exist>1</Exist>"
                            objTextWriter.WriteLine(strLine)
                            strLine = "</tmptbl>"
                            objTextWriter.WriteLine(strLine)

                        Else
                            Exit For
                        End If

                    Next

                    strLine = "</root>"
                    objTextWriter.WriteLine(strLine)
                    objTextWriter.Close()


                    createA_Table_orgT.GetData(objLocalConfig.Globals.Type_Class, objOItem_Class.Name, strPath, True)




                    i = j
                End While
            Else
                createA_Table_orgT.GetData(objLocalConfig.Globals.Type_Class, objOItem_Class.Name, strPath, False)
            End If


            finalizeA_Table.GetData("orgT_" & objOItem_Class.Name)
        Next

        finalizeA_Tables.GetData(objLocalConfig.Globals.Type_Class)
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)

        set_DBConnection()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        Dim strConnection As String

        strConnection = objLocalConfig.Globals.get_ConnectionStr(objLocalConfig.Globals.Rep_Server, _
                                                                 objLocalConfig.Globals.Rep_Instance, _
                                                                 objLocalConfig.Globals.Rep_Database)
        initializeA_Table.Connection = New SqlClient.SqlConnection(strConnection)
        finalizeA_Table.Connection = New SqlClient.SqlConnection(strConnection)

        createA_Table_attT.Connection = New SqlClient.SqlConnection(strConnection)
        createA_Table_orgT.Connection = New SqlClient.SqlConnection(strConnection)
        createA_Table_relT.Connection = New SqlClient.SqlConnection(strConnection)

        initializeA_Tables.Connection = New SqlClient.SqlConnection(strConnection)
        finalizeA_Tables.Connection = New SqlClient.SqlConnection(strConnection)

        objDBLevel_AttributeTypes = New clsDBLevel(objLocalConfig)
        objDBlevel_ObjAtt = New clsDBLevel(objLocalConfig)
        objDBLevel_Objects = New clsDBLevel(objLocalConfig)
        objDBLevel_Classes = New clsDBLevel(objLocalConfig)
        objDBLevel_CalssAtt = New clsDBLevel(objLocalConfig)
        objDBLevel_Ontology = New clsDBLevel(objLocalConfig)
        objDBLevel_OntologyRules = New clsDBLevel(objLocalConfig)
        objDBLevel_DataType = New clsDBLevel(objLocalConfig)
        objDBLevel_ClassRel = New clsDBLevel(objLocalConfig)
        objDBLevel_ObjectRel = New clsDBLevel(objLocalConfig)
    End Sub
End Class
