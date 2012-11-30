Imports Sem_Manager
Public Class frmSchemaDocumentation

    Private objSemItem_Schema As clsSemItem
    Private WithEvents objUserControl_DocumentationList As UserControl_SemItemList
    Private WithEvents objUserControl_Implementations As UserControl_WikiImplementation

    Private Sub selectionChanged_DocumentationList() Handles objUserControl_DocumentationList.Selection_Changed
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_Documentation As clsSemItem

        If objUserControl_DocumentationList.DataGridViewRowCollection_Selected.Count = 1 Then
            objDGVR_Selected = objUserControl_DocumentationList.DataGridViewRowCollection_Selected(0)
            objDRV_Selected = objDGVR_Selected.DataBoundItem
            objSemItem_Documentation = New clsSemItem
            objSemItem_Documentation.GUID = objDRV_Selected.Item("GUID_Token_Left")
            objSemItem_Documentation.Name = objDRV_Selected.Item("Name_Token_Left")
            objSemItem_Documentation.GUID_Parent = objDRV_Selected.Item("GUID_Type_Left")
            objSemItem_Documentation.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objUserControl_Implementations.initialize(objSemItem_Documentation)
        Else
            objUserControl_Implementations.initialize()
        End If

    End Sub

    Public Sub New(ByVal SemItem_Schema As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objSemItem_Schema = SemItem_Schema
        objSemItem_Schema.GUID_Related = objLocalConfig.SemItem_Type_Wiki_Documentation__Database_Schema_.GUID
        objSemItem_Schema.GUID_Relation = objLocalConfig.SemItem_RelationType_belongsTo.GUID
        objSemItem_Schema.Direction = objSemItem_Schema.Direction_RightLeft

        objUserControl_DocumentationList = New UserControl_SemItemList
        objUserControl_DocumentationList.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Add(objUserControl_DocumentationList)

        objUserControl_Implementations = New UserControl_WikiImplementation
        objUserControl_Implementations.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(objUserControl_Implementations)

        ToolStripLabel_Schema.Text = objSemItem_Schema.Name
        initialize()
    End Sub

    Private Sub initialize()
        show_SemItemList()
    End Sub

    Private Sub show_SemItemList()
        objUserControl_DocumentationList.initialize_Complex(objSemItem_Schema, objLocalConfig.Globals)
    End Sub

    Private Sub ToolStripButton_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Close.Click
        Me.Hide()
    End Sub
End Class