Imports Sem_Manager
Public Class UserControl_Version

    Public Event Apply()
    Public Event Cancel()

    Public Event changed_Major()
    Public Event changed_Minor()
    Public Event changed_Build()
    Public Event changed_Revision()

    Private objDR_Version As DataRow

  
    Private objLocalConfig As clsLocalConfig

    Private objSemItem_Token_LogEntry As clsSemItem
    Private objSemItem_Rel As clsSemItem

    Private objVersionWork As clsVersionWork

    Private intMajor As Integer
    Private intMinor As Integer
    Private intBuild As Integer
    Private intRevision As Integer

    Private boolVersionChange As Boolean
    Private boolApply_and_Save As Boolean
    Private boolDescribe As Boolean

    Public ReadOnly Property Major() As Integer
        Get
            Return NumericUpDown_Marjor.Value
        End Get
        
    End Property
    Public ReadOnly Property Build() As Integer
        Get
            Return NumericUpDown_Build.Value
        End Get
        
    End Property
    Public ReadOnly Property Minor() As Integer
        Get
            Return NumericUpDown_Minor.Value
        End Get
        
    End Property
    Public ReadOnly Property Revision() As Integer
        Get
            Return NumericUpDown_Revision.Value
        End Get
        
    End Property

    Public Property SemItem_Token_Rel() As clsSemItem
        Get
            Return objSemItem_Rel
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_Rel = value
        End Set
    End Property

    Public Property SemIte_Token_LogEntry() As clsSemItem
        Get
            Return objSemItem_Token_LogEntry
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_Token_LogEntry = value
            objVersionWork.SemItem_Token_LogEntry = value
        End Set
    End Property
    Public ReadOnly Property Version_Caption() As String
        Get
            Return objDR_Version.Item("Name_DevelopmentVersion")
        End Get

    End Property

    Public Sub VisibleInvisible_Cancel(ByVal boolVisible As Boolean)
        ToolStripButton_Cancel.Visible = boolVisible
        VisibleInvisible_ToolStrip_Buttons()
    End Sub

    Public Sub VisibleInvisible_Clear(ByVal boolVisible As Boolean)
        ToolStripButton_Clear.Visible = boolVisible
        VisibleInvisible_ToolStrip_Buttons()
    End Sub

    Public Sub VisibleInvisible_Apply(ByVal boolVisible As Boolean)
        ToolStripButton_Apply.Visible = boolVisible
        VisibleInvisible_ToolStrip_Buttons()
    End Sub

    Private Sub VisibleInvisible_ToolStrip_Buttons()
        If ToolStripButton_Apply.Visible = True Then
            ToolStrip1.Visible = True
        Else
            If ToolStripButton_Cancel.Visible = True Then
                ToolStrip1.Visible = True
            Else
                If ToolStripButton_Clear.Visible = True Then
                    ToolStrip1.Visible = True
                Else
                    ToolStrip1.Visible = False
                End If

            End If
        End If
    End Sub

    Private Sub set_DBConnection()

    End Sub

    


    Private Sub set_NumericUpDown()
        

        NumericUpDown_Marjor.Value = intMajor
        NumericUpDown_Minor.Value = intMinor
        NumericUpDown_Build.Value = intBuild
        NumericUpDown_Revision.Value = intRevision
    End Sub

    Private Sub NumericUpDown_Marjor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_Marjor.ValueChanged
        If Not objVersionWork Is Nothing Then
            objVersionWork.Revision = NumericUpDown_Marjor.Value
        End If

        boolVersionChange = True
        EnableDisable_Buttons()
        RaiseEvent changed_Major()
    End Sub

    Private Sub NumericUpDown_Minor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_Minor.ValueChanged
        If Not objVersionWork Is Nothing Then
            objVersionWork.Revision = NumericUpDown_Minor.Value
        End If

        boolVersionChange = True
        EnableDisable_Buttons()
        RaiseEvent changed_Minor()
    End Sub

    Private Sub NumericUpDown_Build_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_Build.ValueChanged
        If Not objVersionWork Is Nothing Then
            objVersionWork.Revision = NumericUpDown_Build.Value
        End If

        boolVersionChange = True
        EnableDisable_Buttons()
        RaiseEvent changed_Build()
    End Sub

    Private Sub NumericUpDown_Revision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_Revision.ValueChanged
        If Not objVersionWork Is Nothing Then
            objVersionWork.Revision = NumericUpDown_Revision.Value
        End If

        boolVersionChange = True
        EnableDisable_Buttons()
        RaiseEvent changed_Revision()
    End Sub

    Private Sub EnableDisable_Buttons()
        If boolVersionChange = True Then
            ToolStripButton_Apply.Enabled = True
            ToolStripButton_Clear.Enabled = True
        Else
            ToolStripButton_Apply.Enabled = False
            ToolStripButton_Clear.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Clear.Click

        set_NumericUpDown()
        ToolStripButton_Clear.Enabled = False
        ToolStripButton_Apply.Enabled = False
    End Sub

    Private Sub ToolStripButton_Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Apply.Click
        If boolApply_and_Save = True Then
            objVersionWork.Major = NumericUpDown_Marjor.Value
            objVersionWork.Minor = NumericUpDown_Minor.Value
            objVersionWork.Build = NumericUpDown_Build.Value
            objVersionWork.Revision = NumericUpDown_Revision.Value
            objVersionWork.save_Version(boolDescribe)
        End If
        RaiseEvent Apply()
    End Sub


    Public Sub initialize(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_Rel As clsSemItem, ByVal SemItem_User As clsSemItem, ByVal Describe As Boolean, Optional ByVal SemItem_Token_LogEntry As clsSemItem = Nothing)
        boolDescribe = Describe
        objSemItem_Rel = SemItem_Rel
        objSemItem_Token_LogEntry = SemItem_Token_LogEntry

        objLocalConfig = LocalConfig
        objLocalConfig.SemItem_User = SemItem_User

        set_DBConnection()

        objVersionWork = New clsVersionWork(objLocalConfig, objSemItem_Rel, Me)
        If Not objSemItem_Token_LogEntry Is Nothing Then
            objVersionWork.SemItem_Token_LogEntry = objSemItem_Token_LogEntry
        End If
        If objVersionWork.Version_Exists = True Then
            intMajor = objVersionWork.Major
            intMinor = objVersionWork.Minor
            intBuild = objVersionWork.Build
            intRevision = objVersionWork.Revision
            set_NumericUpDown()
            '
        Else
            set_NumericUpDown()
            objVersionWork.save_Version(boolDescribe)
        End If
        boolApply_and_Save = True
    End Sub
    Public Sub initialize()
        boolApply_and_Save = False
    End Sub

    Private Sub ToolStripButton_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Cancel.Click
        RaiseEvent Cancel()
    End Sub

    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub
End Class
