Imports Sem_Manager
Public Class frmRDFModule
    Private procA_Attribute As New ds_SemDBTableAdapters.semtbl_AttributeTableAdapter

    Private objGlobals As New clsGlobals
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Create_RDF_PLZ()
    End Sub

    Private Sub Create_RDF_PLZ()
        Dim objRDFWork As New clsRDFWork(objGlobals)
        Dim objSemItem_Server As New clsSemItem
        Dim objSemItem_Ontology As New clsSemItem

        objSemItem_Server.GUID = New Guid("d7a03a35-8751-42b4-8e05-19fc7a77ee91")
        objSemItem_Ontology.GUID = New Guid("47bb18b6-8090-4ce1-ab5e-24b72c309a63")
        objSemItem_Ontology.Name = "Server"
        objSemItem_Ontology.GUID_Parent = New Guid("4a186f24-6b8a-4030-a06a-bd706162ea50")
        objSemItem_Ontology.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

        objRDFWork.add_Type(objSemItem_Server, False, True, True)
        objRDFWork.create_RDF(objSemItem_Ontology)
    End Sub
End Class
