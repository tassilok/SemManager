Public Class UserControl_AttributeTypeSel

    Private objLocalConfig As clsLocalConfig

    Private strType As String

    Public Event selected_Type(ByVal strType As String)

    Private boolPChange As Boolean

    Public ReadOnly Property selectedType As String
        Get
            If RadioButton_Bit.Checked = True Then
                Return objLocalConfig.Globals.DType_Bool.Name
            ElseIf RadioButton_Datetime.Checked = True Then
                Return objLocalConfig.Globals.DType_DateTime.Name
            ElseIf RadioButton_Long.Checked = True Then
                Return objLocalConfig.Globals.DType_Int.Name
            ElseIf RadioButton_Real.Checked = True Then
                Return objLocalConfig.Globals.DType_Real.Name
            ElseIf RadioButton_String.Checked = True Then
                Return objLocalConfig.Globals.DType_String.Name
            Else
                Return Nothing
            End If
        End Get
    End Property


    Public Sub New(ByVal strType As String, ByVal LocalConfig As clsLocalConfig)

        ' This call is required by the designer.
        InitializeComponent()

        objLocalConfig = LocalConfig
        Me.strType = strType

        ' Add any initialization after the InitializeComponent() call.
        initialize()
    End Sub

    Private Sub initialize()
        boolPChange = True
        Select Case strType
            Case objLocalConfig.Globals.DType_Bool.Name
                RadioButton_Bit.Checked = True
            Case objLocalConfig.Globals.DType_DateTime.Name
                RadioButton_Datetime.Checked = True
            Case objLocalConfig.Globals.DType_Int.Name
                RadioButton_Long.Checked = True

            Case objLocalConfig.Globals.DType_Real.Name
                RadioButton_Real.Checked = True
            Case objLocalConfig.Globals.DType_String.Name
                RadioButton_String.Checked = True

        End Select
        boolPChange = False
    End Sub

    Private Sub RadioButton_Bit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Bit.CheckedChanged
        If boolPChange = False Then
            If RadioButton_Bit.Checked = True Then
                RaiseEvent selected_Type(objLocalConfig.Globals.DType_Bool.Name)
            End If
        End If
        
    End Sub

    Private Sub RadioButton_Datetime_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Datetime.CheckedChanged
        If boolPChange = False Then
            If RadioButton_Datetime.Checked = True Then
                RaiseEvent selected_Type(objLocalConfig.Globals.DType_DateTime.Name)
            End If
        End If
        
    End Sub

    Private Sub RadioButton_Long_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Long.CheckedChanged
        If boolPChange = False Then
            If RadioButton_Long.Checked = True Then
                RaiseEvent selected_Type(objLocalConfig.Globals.DType_Int.Name)
            End If
        End If
        
    End Sub

    Private Sub RadioButton_Real_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Real.CheckedChanged
        If boolPChange = False Then
            If RadioButton_Real.Checked = True Then
                RaiseEvent selected_Type(objLocalConfig.Globals.DType_Int.Name)
            End If
        End If
        
    End Sub

    Private Sub RadioButton_String_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_String.CheckedChanged
        If boolPChange = False Then
            If RadioButton_String.Checked = True Then
                RaiseEvent selected_Type(objLocalConfig.Globals.DType_String.Name)
            End If
        End If
        
    End Sub
End Class
