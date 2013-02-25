Public Class frm_AttributeTypeEdit

    Private objLocalConfig As clsLocalConfig

    Private objDBLevel As clsDBLevel

    Private WithEvents objUserControl_AttributeTypeSel As UserControl_AttributeTypeSel

    Private objOItem_AttributeType As clsOntologyItem

    Private strDType As String

    Private boolOpen As Boolean

    Private Sub changed_DType(ByVal strType As String) Handles objUserControl_AttributeTypeSel.selected_Type
        save_DataType(strType)
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal OItem_AttributeType As clsOntologyItem)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objLocalConfig = LocalConfig
        objOItem_AttributeType = OItem_AttributeType

        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        boolOpen = True
        get_Data_AttributeType()
        If boolOpen = True Then
            ToolStripTextBox_GUID.Text = objOItem_AttributeType.GUID
            ToolStripTextBox_Name.Text = objOItem_AttributeType.Name

            objUserControl_AttributeTypeSel = New UserControl_AttributeTypeSel(strDType, objLocalConfig)
            objUserControl_AttributeTypeSel.Dock = DockStyle.Fill
            SplitContainer1.Panel1.Controls.Add(objUserControl_AttributeTypeSel)
        End If
    End Sub

    Private Sub get_Data_AttributeType()
        Dim oList_AttributeTypes As New List(Of clsOntologyItem)

        oList_AttributeTypes.Add(objOItem_AttributeType)
        objDBLevel.get_Data_AttributeType(oList_AttributeTypes)

        If objDBLevel.OList_AttributeTypes.Count > 0 Then
            objOItem_AttributeType.GUID = objDBLevel.OList_AttributeTypes(0).GUID
            objOItem_AttributeType.Name = objDBLevel.OList_AttributeTypes(0).Name
            objOItem_AttributeType.GUID_Parent = objDBLevel.OList_AttributeTypes(0).GUID_Parent
            objOItem_AttributeType.Type = objLocalConfig.Globals.Type_AttributeType

            Select Case objOItem_AttributeType.GUID_Parent
                Case objLocalConfig.Globals.DType_Bool.GUID
                    strDType = objLocalConfig.Globals.DType_Bool.Name
                Case objLocalConfig.Globals.DType_DateTime.GUID
                    strDType = objLocalConfig.Globals.DType_DateTime.Name
                Case objLocalConfig.Globals.DType_Int.GUID
                    strDType = objLocalConfig.Globals.DType_Int.Name

                Case objLocalConfig.Globals.DType_Real.GUID
                    strDType = objLocalConfig.Globals.DType_Real.Name
                Case objLocalConfig.Globals.DType_String.GUID
                    strDType = objLocalConfig.Globals.DType_String.Name
            End Select

        Else
            MsgBox("Der Attributtype ist nicht vorhanden!", MsgBoxStyle.Exclamation)
            boolOpen = False
        End If
    End Sub


    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)

    End Sub

    Private Sub frm_AttributeTypeEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If boolOpen = False Then
            Me.Close()
        End If
    End Sub

    Private Sub save_DataType(ByVal strType As String)
        Dim objOItem_Result As clsOntologyItem

        Select Case strType
            Case objLocalConfig.Globals.DType_Bool.Name
                objOItem_AttributeType.GUID_Parent = objLocalConfig.Globals.DType_Bool.GUID
            Case objLocalConfig.Globals.DType_DateTime.Name
                objOItem_AttributeType.GUID_Parent = objLocalConfig.Globals.DType_DateTime.GUID
            Case objLocalConfig.Globals.DType_Int.Name
                objOItem_AttributeType.GUID_Parent = objLocalConfig.Globals.DType_Int.GUID

            Case objLocalConfig.Globals.DType_Real.Name
                objOItem_AttributeType.GUID_Parent = objLocalConfig.Globals.DType_Real.GUID

            Case objLocalConfig.Globals.DType_String.Name
                objOItem_AttributeType.GUID_Parent = objLocalConfig.Globals.DType_String.GUID


        End Select

        objOItem_Result = objDBLevel.save_AttributeType(objOItem_AttributeType)
    End Sub
End Class