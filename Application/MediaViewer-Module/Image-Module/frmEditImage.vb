Imports Sem_Manager
Public Class frmEditImage
    Dim objLocalConfig As clsLocalConfig
    Dim objUserControl_EditImage As UserControl_EditImage

    Dim cintListType_OR As Integer = 1
    Dim cintListType_Chrono As Integer = 2
    Dim cintListType_Named As Integer = 3

    Dim intListType As Integer
    Dim intRowID As Integer

    Private procT_Image_Of_Or As New ds_ImageModule.proc_Image_Of_OrDataTable
    Private procT_Medias_Chrono As New ds_ImageModule.proc_Medias_ChronoDataTable
    Private procT_Images_Of_NamedRelated As New ds_ImageModule.proc_Images_Of_NamedRelatedDataTable

    Public Sub New(ByVal LocalConfig As clsLocalConfig)


        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = LocalConfig

        objUserControl_EditImage = New UserControl_EditImage(objLocalConfig)
        objUserControl_EditImage.Dock = DockStyle.Fill

        ToolStripContainer1.ContentPanel.Controls.Add(objUserControl_EditImage)
    End Sub

    Public Sub initialize_OR(ByRef _procT_Image_Of_Or As ds_ImageModule.proc_Image_Of_OrDataTable, ByVal _intRowID As Integer)
        procT_Image_Of_Or = _procT_Image_Of_Or
        intListType = cintListType_OR
        intRowID = _intRowID
        configure_Navigation()
        get_Image()
    End Sub

    Public Sub initialize_Chrono(ByRef _procT_Medias_Chrono As ds_ImageModule.proc_Medias_ChronoDataTable, ByVal _intRowID As Integer)
        procT_Medias_Chrono = _procT_Medias_Chrono
        intListType = cintListType_Chrono
        intRowID = _intRowID
        configure_Navigation()
        get_Image()
    End Sub

    Public Sub initialize_Named(ByRef _procT_Images_Of_NamedRelated As ds_ImageModule.proc_Images_Of_NamedRelatedDataTable, ByVal _intRowID As Integer)
        procT_Images_Of_NamedRelated = _procT_Images_Of_NamedRelated
        intListType = cintListType_Named
        intRowID = _intRowID
        configure_Navigation()
        get_Image()
    End Sub

    Private Sub get_Image()
        Dim objDR_Image As DataRow
        Dim objSemItem_Image As New clsSemItem

        If intRowID > -1 Then
            Select Case intListType
                Case cintListType_Chrono
                    objDR_Image = procT_Medias_Chrono.Rows(intRowID)

                Case cintListType_Named
                    objDR_Image = procT_Images_Of_NamedRelated.Rows(intRowID)

                Case cintListType_OR
                    objDR_Image = procT_Image_Of_Or.Rows(intRowID)

            End Select

            objSemItem_Image.GUID = objDR_Image.Item("GUID_Images__Graphic_")
            objSemItem_Image.Name = objDR_Image.Item("Name_Images__Graphic_")
            objSemItem_Image.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
            objSemItem_Image.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objUserControl_EditImage.initialize(objSemItem_Image)

        End If
        


    End Sub

    Private Sub configure_Navigation()

        ToolStripButton_First.Enabled = False
        ToolStripButton_Previous.Enabled = False
        ToolStripButton_Next.Enabled = False
        ToolStripButton_Last.Enabled = False

        If intRowID > 0 Then
            ToolStripButton_First.Enabled = True
            ToolStripButton_Previous.Enabled = True
        End If

        Select Case intListType
            Case cintListType_Chrono
                

                If intRowID < procT_Medias_Chrono.Count - 1 Then
                    ToolStripButton_Last.Enabled = True
                    ToolStripButton_Next.Enabled = True
                End If
                ToolStripLabel_Position.Text = intRowID + 1 & "/" & procT_Medias_Chrono.Count
            Case cintListType_Named
                If intRowID < procT_Images_Of_NamedRelated.Count - 1 Then
                    ToolStripButton_Last.Enabled = True
                    ToolStripButton_Next.Enabled = True
                End If
                ToolStripLabel_Position.Text = intRowID + 1 & "/" & procT_Images_Of_NamedRelated.Count
            Case cintListType_OR
                If intRowID < procT_Image_Of_Or.Count - 1 Then
                    ToolStripButton_Last.Enabled = True
                    ToolStripButton_Next.Enabled = True
                End If
                ToolStripLabel_Position.Text = intRowID + 1 & "/" & procT_Image_Of_Or.Count
        End Select


    End Sub

    Private Sub ToolStripButton_First_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_First.Click
        intRowID = 0
        configure_Navigation()
        get_Image()


    End Sub

    Private Sub ToolStripButton_Previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Previous.Click
        intRowID = intRowID - 1
        configure_Navigation()
        get_Image()
    End Sub

    Private Sub ToolStripButton_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Next.Click
        intRowID = intRowID + 1
        configure_Navigation()
        get_Image()

    End Sub

    Private Sub ToolStripButton_Last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Last.Click

        Select Case intListType
            Case cintListType_Chrono


                intRowID = procT_Medias_Chrono.Count - 1 
            Case cintListType_Named
                intRowID = procT_Images_Of_NamedRelated.Count - 1 
            Case cintListType_OR
                intRowID = procT_Image_Of_Or.Count - 1 
        End Select


        configure_Navigation()
        get_Image()
    End Sub
End Class