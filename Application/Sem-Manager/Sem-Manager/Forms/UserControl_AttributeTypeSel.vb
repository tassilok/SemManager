Public Class UserControl_AttributeTypeSel

    Private AttributeA_List_With_TypeName As New ds_AttributeTableAdapters.Attribute_List_With_TypeNameTableAdapter

    Private objLocalConfig As clsLocalConfig_AttributeTypeSell

    
    Private objSemItem_Attribute As clsSemItem
    Private boolProgChange As Boolean

    Public Event changed_Type()

    Public ReadOnly Property Value() As clsSemItem
        Get
            If RadioButton_Bit.Checked = True Then
                Return objLocalConfig.Globals.AttributeType_Bool
            ElseIf RadioButton_Date.Checked = True Then
                Return objLocalConfig.Globals.AttributeType_Date
            ElseIf RadioButton_Datetime.Checked = True Then
                Return objLocalConfig.Globals.AttributeType_Datetime
            ElseIf RadioButton_Int.Checked = True Then
                Return objLocalConfig.Globals.AttributeType_Int
            ElseIf RadioButton_Real.Checked = True Then
                Return objLocalConfig.Globals.AttributeType_Real
            ElseIf RadioButton_Varchar255.Checked = True Then
                Return objLocalConfig.Globals.AttributeType_Varchar255
            ElseIf RadioButton_VarcharMAX.Checked = True Then
                Return objLocalConfig.Globals.AttributeType_String
            ElseIf RadioButton_Time.Checked = True Then
                Return objLocalConfig.Globals.AttributeType_Time
            Else
                Return Nothing
            End If

        End Get
    End Property
    Private Sub RadioButton_Bit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Bit.CheckedChanged
        If RadioButton_Bit.Checked = True And boolProgChange = False Then
            RaiseEvent changed_Type()
        End If

    End Sub

    Public Sub New(ByVal Globals As clsGlobals, ByVal SemItem_Attribute As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig_AttributeTypeSell(Globals)
        objSemItem_Attribute = SemItem_Attribute

        set_DBConnection()
        get_Data()
    End Sub

    Private Sub set_DBConnection()
        AttributeA_List_With_TypeName.Connection = objLocalConfig.Connection_DB
    End Sub

    Private Sub get_Data()
        Dim objDRC_Attribute As DataRowCollection
        objDRC_Attribute = AttributeA_List_With_TypeName.GetData_By_GUIDAttribute(objSemItem_Attribute.GUID).Rows
        If objDRC_Attribute.Count > 0 Then
            boolProgChange = True
            Select Case objDRC_Attribute(0).Item("GUID_AttributeType")
                Case objLocalConfig.Globals.AttributeType_Bool.GUID
                    RadioButton_Bit.Checked = True
                Case objLocalConfig.Globals.AttributeType_Date.GUID
                    RadioButton_Date.Checked = True
                Case objLocalConfig.Globals.AttributeType_Datetime.GUID
                    RadioButton_Datetime.Checked = True
                Case objLocalConfig.Globals.AttributeType_Int.GUID
                    RadioButton_Int.Checked = True

                Case objLocalConfig.Globals.AttributeType_Real.GUID
                    RadioButton_Real.Checked = True

                Case objLocalConfig.Globals.AttributeType_String.GUID
                    RadioButton_VarcharMAX.Checked = True
                Case objLocalConfig.Globals.AttributeType_Time.GUID
                    RadioButton_Time.Checked = True
                Case objLocalConfig.Globals.AttributeType_Varchar255.GUID
                    RadioButton_Varchar255.Checked = True
            End Select
            boolProgChange = False
        End If

    End Sub

    Private Sub RadioButton_Date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Date.CheckedChanged
        If RadioButton_Date.Checked = True And boolProgChange = False Then
            RaiseEvent changed_Type()
        End If

    End Sub

    Private Sub RadioButton_Datetime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Datetime.CheckedChanged
        If RadioButton_Datetime.Checked = True And boolProgChange = False Then
            RaiseEvent changed_Type()
        End If

    End Sub

    Private Sub RadioButton_Int_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Int.CheckedChanged
        If RadioButton_Int.Checked = True And boolProgChange = False Then
            RaiseEvent changed_Type()
        End If

    End Sub

    Private Sub RadioButton_Real_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Real.CheckedChanged
        If RadioButton_Real.Checked = True And boolProgChange = False Then
            RaiseEvent changed_Type()
        End If

    End Sub

    Private Sub RadioButton_Varchar255_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Varchar255.CheckedChanged
        If RadioButton_Varchar255.Checked = True And boolProgChange = False Then
            RaiseEvent changed_Type()
        End If

    End Sub

    Private Sub RadioButton_VarcharMAX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_VarcharMAX.CheckedChanged
        If RadioButton_VarcharMAX.Checked = True And boolProgChange = False Then
            RaiseEvent changed_Type()
        End If

    End Sub

    Private Sub RadioButton_Time_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Time.CheckedChanged
        If RadioButton_Time.Checked = True And boolProgChange = False Then
            RaiseEvent changed_Type()
        End If
    End Sub
End Class
