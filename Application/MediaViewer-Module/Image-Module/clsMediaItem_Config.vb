Imports Sem_Manager
Public Class clsMediaItem_Config
    Private objFrmSemManager As frmSemManager
    Private objLocalConfig As clsLocalConfig
    Private objSemItem_User As clsSemItem
    Private objFrmParent As Windows.Forms.IWin32Window

    Private boolEnableBookmarks As Boolean

    Public ReadOnly Property enable_Bookmarks As Boolean
        Get
            Return boolEnableBookmarks
        End Get
    End Property

    Public Property SemItem_User As clsSemItem
        Get
            Return objSemItem_User
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_User = value
        End Set
    End Property

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal FrmParent As Windows.Forms.IWin32Window)
        objLocalConfig = LocalConfig
        objSemItem_User = Nothing

        boolEnableBookmarks = False
        objFrmParent = FrmParent
    End Sub

    Public Sub get_User()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView

        objSemItem_User = Nothing
        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_type_User, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)
        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem
                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_type_User.GUID Then
                        objSemItem_User = New clsSemItem
                        objSemItem_User.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_User.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_User.GUID_Parent = objDRV_Selected.Item("GUID_Type")
                        objSemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                    Else
                        MsgBox("Bitte nur einen User auswählen!", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Bitte nur einen User auswählen!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Bitte nur einen User auswählen!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
End Class
