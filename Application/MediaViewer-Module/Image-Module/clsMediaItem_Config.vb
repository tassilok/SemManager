Imports Sem_Manager
Public Class clsMediaItem_Config
    Private objFrmSemManager As frmSemManager
    Private objLocalConfig As clsLocalConfig
    Private objSemItem_User As clsSemItem
    Private objFrmParent As Windows.Forms.IWin32Window
    Private objSemItem_OR As New clsSemItem

    Private procA_Image_Of_Or As New ds_ImageModuleTableAdapters.proc_Image_Of_OrTableAdapter
    Private procA_MediaItem_Of_Or As New ds_ImageModuleTableAdapters.proc_MediaItem_Of_OrTableAdapter
    Private procA_PDF_Of_Or As New ds_ImageModuleTableAdapters.proc_PDF_Of_OrTableAdapter

    Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter

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

    Public Function has_Images(ByVal SemItem_Ref As clsSemItem) As Boolean
        Dim objDRC_OR As DataRowCollection
        Dim objDRC_Image As DataRowCollection
        Dim boolResult As Boolean

        boolResult = False

        objDRC_OR = semfuncA_ObjectReference.GetData_By_GUID_Ref(SemItem_Ref.GUID).Rows
        If objDRC_OR.Count > 0 Then
            objSemItem_OR.GUID = objDRC_OR(0).Item("GUID_ObjectReference")

            objDRC_Image = procA_Image_Of_Or.GetData(objLocalConfig.SemItem_Type_Images__Graphic_.GUID, _
                                                     objLocalConfig.SemItem_Type_File.GUID, _
                                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                     objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                     objSemItem_OR.GUID).Rows
            If objDRC_Image.Count > 0 Then
                boolResult = True
            End If
        End If

        Return boolResult
    End Function

    Public Function has_MediaItems(ByVal SemItem_Ref As clsSemItem) As Boolean
        Dim objDRC_OR As DataRowCollection
        Dim objDRC_MediaItem As DataRowCollection
        Dim boolResult As Boolean

        boolResult = False

        objDRC_OR = semfuncA_ObjectReference.GetData_By_GUID_Ref(SemItem_Ref.GUID).Rows
        If objDRC_OR.Count > 0 Then
            objSemItem_OR.GUID = objDRC_OR(0).Item("GUID_ObjectReference")

            objDRC_MediaItem = procA_MediaItem_Of_Or.GetData(objLocalConfig.SemItem_Type_Media_Item.GUID, _
                                                     objLocalConfig.SemItem_Type_File.GUID, _
                                                     objLocalConfig.SemItem_Type_Media_Item_Bookmark.GUID, _
                                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                     objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                     objSemItem_OR.GUID).Rows
            If objDRC_MediaItem.Count > 0 Then
                boolResult = True
            End If
        End If

        Return boolResult
    End Function

    Public Function has_PDFs(ByVal SemItem_Ref As clsSemItem) As Boolean
        Dim objDRC_OR As DataRowCollection
        Dim objDRC_Pdf As DataRowCollection
        Dim boolResult As Boolean

        boolResult = False

        objDRC_OR = semfuncA_ObjectReference.GetData_By_GUID_Ref(SemItem_Ref.GUID).Rows
        If objDRC_OR.Count > 0 Then
            objSemItem_OR.GUID = objDRC_OR(0).Item("GUID_ObjectReference")

            objDRC_Pdf = procA_PDF_Of_Or.GetData(objLocalConfig.SemItem_Type_PDF_Documents.GUID, _
                                                     objLocalConfig.SemItem_Type_File.GUID, _
                                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                     objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                     objSemItem_OR.GUID).Rows
            If objDRC_Pdf.Count > 0 Then
                boolResult = True
            End If
        End If

        Return boolResult
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal FrmParent As Windows.Forms.IWin32Window)
        objLocalConfig = LocalConfig
        objSemItem_User = Nothing

        boolEnableBookmarks = False
        set_DBConnection()
        objFrmParent = FrmParent
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)
        set_DBConnection()

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

    Private Sub set_DBConnection()
        procA_Image_Of_Or.Connection = objLocalConfig.Connection_Plugin
        procA_MediaItem_Of_Or.Connection = objLocalConfig.Connection_Plugin
        procA_PDF_Of_Or.Connection = objLocalConfig.Connection_Plugin

        semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
