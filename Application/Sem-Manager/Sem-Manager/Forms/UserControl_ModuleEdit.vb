Public Class UserControl_ModuleEdit
    Private objGlobals As clsGlobals
    Private objSemItem_Token As clsSemItem

    Public Sub New(ByVal Globals As clsGlobals, ByVal SemItem_Token As clsSemItem)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        Dim objModule As clsModule
        Dim objSemItem_Type As New clsSemItem

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objGlobals = Globals
        objSemItem_Token = SemItem_Token



        ToolStripComboBox_Module.Items.Clear()

        objSemItem_Type.GUID = objSemItem_Token.GUID_Parent
        If Not objGlobals.loaded_Modules Is Nothing Then
            If objGlobals.loaded_Modules.Count > 0 Then
                For Each objModule In objGlobals.loaded_Modules
                    If objModule.Active = True And objModule.Valid = True Then
                        If objModule.Object_OK(objSemItem_Type) = True Then

                            If objModule.loaded_Module.TokenEdit = True Then

                                ToolStripComboBox_Module.Items.Add(objModule)
                                ToolStripComboBox_Module.ComboBox.ValueMember = "GUID_LoadedModule"
                                ToolStripComboBox_Module.ComboBox.DisplayMember = "Name_LoadedModule"
                            End If


                        End If
                    End If


                Next
            End If
        End If
        

    End Sub

    
    Private Sub ToolStripComboBox_Module_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_Module.DropDownClosed
        Dim objModule As clsModule

        objModule = ToolStripComboBox_Module.SelectedItem
        If Not objModule Is Nothing Then
            objSemItem_Token = objModule.loaded_Module.edit_SemItem(objSemItem_Token, Me)

        End If
    End Sub

    Private Sub ToolStripComboBox_Module_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox_Module.SelectedIndexChanged

    End Sub
End Class
