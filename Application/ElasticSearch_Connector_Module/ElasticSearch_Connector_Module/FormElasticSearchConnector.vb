Imports Security_Module
Imports Sem_Manager
Public Class Form_ElasticSearchConnector

    Private objAuthentication As frmAuthenticate

    Private objElasticSarech As clsElasticSearch
    Private objXMLImport As clsXMLImport

    Private objLocalConfig As clsLocalConfig

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objLocalConfig = New clsLocalConfig(New clsGlobals)

        objLocalConfig.SemItem_User = Nothing
        objAuthentication = New frmAuthenticate(frmAuthenticate.ERelateMode.NoRelate, True, False)
        objAuthentication.ShowDialog(Me)
        If objAuthentication.DialogResult = Windows.Forms.DialogResult.OK Then
            objLocalConfig.SemItem_User = New clsSemItem
            objLocalConfig.SemItem_User.GUID = objAuthentication.SemItem_User.GUID
            objLocalConfig.SemItem_User.Name = objAuthentication.SemItem_User.Name
            objLocalConfig.SemItem_User.GUID_Parent = objAuthentication.SemItem_User.GUID_Parent
            objLocalConfig.SemItem_User.GUID_Type = objAuthentication.SemItem_User.GUID_Type

            objXMLImport = New clsXMLImport(objLocalConfig, objLocalConfig.SemItem_User)
            objElasticSarech = New clsElasticSearch(objLocalConfig)

            test_Import_Types()
            'test_CSVImport()
        End If
    End Sub

    Private Sub test_CSVImport()
        objElasticSarech.import_CSV()
    End Sub
    Private Sub test_Import_Types()
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objElasticSarech.export_DataTypes()
        objSemItem_Result = objElasticSarech.export_Attributes()
        objSemItem_Result = objElasticSarech.export_RelationTypes()
        objSemItem_Result = objElasticSarech.export_Types()
        objSemItem_Result = objElasticSarech.export_Token()
        objSemItem_Result = objElasticSarech.export_TokenAttribute(objLocalConfig.Globals.AttributeType_Bool.GUID)
        objSemItem_Result = objElasticSarech.export_TokenAttribute(objLocalConfig.Globals.AttributeType_Date.GUID)
        objSemItem_Result = objElasticSarech.export_TokenAttribute(objLocalConfig.Globals.AttributeType_Datetime.GUID)
        objSemItem_Result = objElasticSarech.export_TokenAttribute(objLocalConfig.Globals.AttributeType_Int.GUID)
        objSemItem_Result = objElasticSarech.export_TokenAttribute(objLocalConfig.Globals.AttributeType_Real.GUID)
        objSemItem_Result = objElasticSarech.export_TokenAttribute(objLocalConfig.Globals.AttributeType_String.GUID)
        objSemItem_Result = objElasticSarech.export_TokenAttribute(objLocalConfig.Globals.AttributeType_Time.GUID)
        objSemItem_Result = objElasticSarech.export_TokenAttribute(objLocalConfig.Globals.AttributeType_Varchar255.GUID)
        objSemItem_Result = objElasticSarech.export_TokenRel()
        objSemItem_Result = objElasticSarech.export_Token_OR()
        objSemItem_Result = objElasticSarech.export_TypeRel()
        objSemItem_Result = objElasticSarech.export_TypeRel_OR()
        objSemItem_Result = objElasticSarech.export_TypeAtt()
    End Sub

    Private Sub test_Import()
        Dim objSemItem_XMLImport As New clsSemItem
        Dim objXML As Xml.XmlDocument
        Dim objSemItem_Result As clsSemItem

        objSemItem_XMLImport.GUID = New Guid("518f3f07-46e8-4e87-b7e6-53653f744ffb")
        objSemItem_XMLImport.Name = "User-Agents"
        objSemItem_XMLImport.GUID_Parent = objLocalConfig.SemItem_Type_XML_Import.GUID
        objSemItem_XMLImport.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objXML = objXMLImport.get_XML_Of_WebResource(objSemItem_XMLImport)

        'objSemItem_Result = objElasticSarech.insert_XML(objXML, objSemItem_XMLImport)


    End Sub

    Private Sub test_SemImport()

    End Sub

    Private Sub Form_ElasticSearchConnector_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objLocalConfig.SemItem_User Is Nothing Then
            Me.Dispose()
        End If
        test_Import()
    End Sub
End Class
