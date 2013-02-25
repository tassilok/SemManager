Public Class clsOntologies
    Private objLocalConfig As clsLocalConfig

    Private objOList As New List(Of clsOntologyItem)

    Private objDBLevel As clsDBLevel
    Private objDBLevel_Attributes As clsDBLevel
    Private objDBLevel_RelTypes As clsDBLevel
    Private objDBLevel_Classes As clsDBLevel
    Private objDBLevel_Objects As clsDBLevel

    Public ReadOnly Property OList As List(Of clsOntologyItem)
        Get
            Return objOList
        End Get
    End Property

    Public Function get_Ontologies(ByVal OItem_Ontology As clsOntologyItem) As clsOntologyItem
        Dim objOItem_Result As clsOntologyItem
        Dim objOList_Ontologies As New List(Of clsOntologyItem)
        Dim oList_Param1 As List(Of clsOntologyItem)
        Dim oList_Param2 As List(Of clsOntologyItem)
        Dim oList_Param3 As List(Of clsOntologyItem)

        oList_Param1 = New List(Of clsOntologyItem)
        oList_Param1.Add(OItem_Ontology)
        oList_Param2 = New List(Of clsOntologyItem)
        oList_Param1.Add(objLocalConfig.Globals.Class_Ontologies)
        oList_Param3 = New List(Of clsOntologyItem)
        oList_Param1.Add(objLocalConfig.Globals.RelationType_contains)

        objDBLevel.get_Data_ObjectRel(oList_Param1, oList_Param2, oList_Param3, False, True)


        objOList_Ontologies.Add(OItem_Ontology)

        Dim oList = From obj In objDBLevel.OList_ObjectRel_ID
                    Group By obj.ID_Other Into Group

        For Each ListItem In oList
            objOList_Ontologies.Add(New clsOntologyItem(ListItem.ID_Other, objLocalConfig.Globals.Type_Object))

        Next

        oList_Param2 = New List(Of clsOntologyItem)
        oList_Param2.Add(objLocalConfig.Globals.Class_OntologyItems)
        oList_Param3 = New List(Of clsOntologyItem)
        oList_Param3.Add(objLocalConfig.Globals.RelationType_contains)
        objDBLevel.get_Data_ObjectRel(objOList_Ontologies, oList_Param2, oList_Param3, False, False)

        oList_Param2 = New List(Of clsOntologyItem)
        oList_Param2.Add(New clsOntologyItem(Nothing, objLocalConfig.Globals.Type_Attribute))
        oList_Param3 = New List(Of clsOntologyItem)
        oList_Param3.Add(objLocalConfig.Globals.RelationType_belongingAttribute)

        objDBLevel_Attributes.get_Data_ObjectRel(objDBLevel.OList_Objects, _
                                        oList_Param2, _
                                        oList_Param3, False, False)

        oList_Param2 = New List(Of clsOntologyItem)
        oList_Param2.Add(New clsOntologyItem(Nothing, objLocalConfig.Globals.Type_Class))
        oList_Param3 = New List(Of clsOntologyItem)
        oList_Param3.Add(objLocalConfig.Globals.RelationType_belongingClass)

        objDBLevel_Classes.get_Data_ObjectRel(objDBLevel.OList_Objects, _
                                        oList_Param2, _
                                        oList_Param3, False, False)

        oList_Param2 = New List(Of clsOntologyItem)
        oList_Param2.Add(New clsOntologyItem(Nothing, objLocalConfig.Globals.Type_Object))
        oList_Param3 = New List(Of clsOntologyItem)
        oList_Param3.Add(objLocalConfig.Globals.RelationType_belongingObject)

        objDBLevel_Objects.get_Data_ObjectRel(objDBLevel.OList_Objects, _
                                        oList_Param2, _
                                        oList_Param3, False, False)


        oList_Param2 = New List(Of clsOntologyItem)
        oList_Param2.Add(New clsOntologyItem(Nothing, objLocalConfig.Globals.Type_RelationType))
        oList_Param3 = New List(Of clsOntologyItem)
        oList_Param3.Add(objLocalConfig.Globals.RelationType_belongingRelationType)

        objDBLevel_RelTypes.get_Data_ObjectRel(objDBLevel.OList_Objects, _
                                        oList_Param2, _
                                        oList_Param3, False, False)


        Return objOItem_Result
    End Function

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)

        set_DBConnection()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)
        objDBLevel_Attributes = New clsDBLevel(objLocalConfig)
        objDBLevel_RelTypes = New clsDBLevel(objLocalConfig)
        objDBLevel_Classes = New clsDBLevel(objLocalConfig)
        objDBLevel_Objects = New clsDBLevel(objLocalConfig)
    End Sub
End Class
