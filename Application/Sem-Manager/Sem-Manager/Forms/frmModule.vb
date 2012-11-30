Public Class frmModule
    Private objGlobals As clsGlobals
    Public Sub New(ByRef Globals As clsGlobals)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Dim objModule As clsModule
        Dim objListViewItem_Module As ListViewItem
        objGlobals = Globals
        If Not objGlobals.loaded_Modules Is Nothing Then
            For Each objModule In objGlobals.loaded_Modules
                objListViewItem_Module = ListView_Modules.Items.Add(objModule.GUID_LoadedModule.ToString, objModule.Name_LoadedModule, 0)
                objListViewItem_Module.Checked = objModule.Active

            Next
        End If

    End Sub


    Private Sub ListView_Modules_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView_Modules.Click
       
    End Sub

    Private Sub ListView_Modules_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles ListView_Modules.ItemChecked

        objGlobals.toogle_Module_Active(New Guid(e.Item.Name), e.Item.Checked)

    End Sub
End Class