Imports Sem_Manager
Public Class frmAppointmentModule

    Private WithEvents objUserControl_Appointment As UserControl_Appointments

    Private objFrmSemManager As frmSemManager
    Private objLocalConfig As clsLocalConfig

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)
        initialize()
    End Sub

    Private Sub initialize()
        get_User()
        objUserControl_Appointment = New UserControl_Appointments(objLocalConfig)
        objUserControl_Appointment.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(objUserControl_Appointment)
        objUserControl_Appointment.initalize_Appointments(objLocalConfig.User)
    End Sub

    Private Sub get_User()
        Dim objDGVR_Selected As DataGridViewRow
        Dim objDRV_Selected As DataRowView
        Dim objSemItem_User As New clsSemItem

        objFrmSemManager = New frmSemManager(objLocalConfig.SemItem_type_User, objLocalConfig.Globals)
        objFrmSemManager.Applyabale = True
        objFrmSemManager.ShowDialog(Me)

        objLocalConfig.User = Nothing

        If objFrmSemManager.DialogResult = Windows.Forms.DialogResult.OK Then
            If objFrmSemManager.SelectedItems_TypeGUID = objLocalConfig.Globals.ObjectReferenceType_Token.GUID Then
                If objFrmSemManager.SelectedRows_Items.Count = 1 Then
                    objDGVR_Selected = objFrmSemManager.SelectedRows_Items(0)
                    objDRV_Selected = objDGVR_Selected.DataBoundItem

                    If objDRV_Selected.Item("GUID_Type") = objLocalConfig.SemItem_type_User.GUID Then
                        objSemItem_User.GUID = objDRV_Selected.Item("GUID_Token")
                        objSemItem_User.Name = objDRV_Selected.Item("Name_Token")
                        objSemItem_User.GUID_Parent = objLocalConfig.SemItem_type_User.GUID
                        objSemItem_User.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                        objLocalConfig.User = objSemItem_User

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub frmAppointmentModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objLocalConfig.User Is Nothing Then
            Me.Close()
        End If
    End Sub

    

    
End Class
