Public Class UserControl_AttributeRelations

    Private typefuncA_Types_With_Attributes_And_Types As New ds_TypeTableAdapters.typefunc_Types_With_Attributes_And_TypesTableAdapter
    Private typefunc_Types_With_Attributes_And_Types_By_GUIDAttribute As New ds_Type.typefunc_Types_With_Attributes_And_TypesDataTable
    'Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter
    'Private semfunc_ObjectReference_By_GUIDAttribute As New ds_ObjectReference.semfunc_ObjectReferenceDataTable
    Private semfuncA_Token_Attribute As New ds_TokenAttributeTableAdapters.semfunc_Token_AttributeTableAdapter
    Private semfunc_Token_Attribute_By_GUIDAttribute As New ds_TokenAttribute.semfunc_Token_AttributeDataTable

    Private objLocalConfig As clsLocalConfig_AttributeRelations
    Private objGUID_Attribute As Guid

    Public Sub New(ByVal Globals As clsGlobals, ByVal GUID_Attribute As Guid)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_AttributeRelations(Globals)
        objGUID_Attribute = GUID_Attribute

        set_DBConnection()
        get_Data()
    End Sub

    Private Sub set_DBConnection()
        typefuncA_Types_With_Attributes_And_Types.Connection = objLocalConfig.Connection_DB
        'semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB
        semfuncA_Token_Attribute.Connection = objLocalConfig.Connection_DB

        typefuncA_Types_With_Attributes_And_Types.Fill_By_AttributeGUID(typefunc_Types_With_Attributes_And_Types_By_GUIDAttribute, objGUID_Attribute)
        'semfuncA_ObjectReference.Fill_By_AttributeGUID(semfunc_ObjectReference_By_GUIDAttribute, objGUID_Attribute)
        semfuncA_Token_Attribute.Fill_TokenAttribute_By_GUID_Attribute(semfunc_Token_Attribute_By_GUIDAttribute, objGUID_Attribute)
    End Sub

    Private Sub get_Data()
        'BindingSource_ObjectReference.DataSource = semfunc_ObjectReference_By_GUIDAttribute
        'DataGridView_ObjectReference.DataSource = BindingSource_ObjectReference
        'DataGridView_ObjectReference.Columns(0).Visible = False
        'DataGridView_ObjectReference.Columns(2).Visible = False
        'DataGridView_ObjectReference.Columns(3).Visible = False
        'DataGridView_ObjectReference.Columns(4).Visible = False

        BindingSource_Types.DataSource = typefunc_Types_With_Attributes_And_Types_By_GUIDAttribute
        DataGridView_Types.DataSource = BindingSource_Types
        DataGridView_Types.Columns(0).Visible = False
        DataGridView_Types.Columns(2).Visible = False
        DataGridView_Types.Columns(3).Visible = False
        DataGridView_Types.Columns(4).Visible = False
        DataGridView_Types.Columns(5).Visible = False

        BindingSource_Token.DataSource = semfunc_Token_Attribute_By_GUIDAttribute
        DataGridView_Token.DataSource = BindingSource_Token
        DataGridView_Token.Columns(0).Visible = False
        DataGridView_Token.Columns(1).Visible = False
        DataGridView_Token.Columns(2).Visible = False
        DataGridView_Token.Columns(3).Visible = False
        DataGridView_Token.Columns(4).Visible = False
        DataGridView_Token.Columns(6).Visible = False


    End Sub
End Class
