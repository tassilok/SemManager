Public Class frmSelect_Items
    Private objRadioButtons() As RadioButton = Nothing

    Private intX As Integer
    Private intY As Integer

    Public Sub add_Item(ByVal objSemItem_Item As clsSemItem)
        Dim i As Integer
        Dim objControls() As Control

        If objRadioButtons Is Nothing Then
            i = 0
            intX = 10
            intY = 20
        Else
            i = objRadioButtons.Count

        End If

        ReDim Preserve objRadioButtons(i)
        objRadioButtons(i) = New RadioButton
        objRadioButtons(i).Name = objSemItem_Item.GUID.ToString
        objRadioButtons(i).Text = objSemItem_Item.Name
       
        GroupBox_Items.Controls.Add(objRadioButtons(i))
        objControls = GroupBox_Items.Controls.Find(objSemItem_Item.GUID.ToString, True)
        If i > 0 Then
            If objControls.Count > 0 Then
                intY = intY + objControls(0).Height + 4
            End If
        End If
        If objControls.Count > 0 Then

            objControls(0).SetBounds(intX, intY, objControls(0).Width, objControls(0).Height)

        End If

        If i = 0 Then
            objRadioButtons(i).Checked = True
        End If
    End Sub
    Public Sub New(ByVal strCaption As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        intX = 10
        intY = 10

        GroupBox_Items.Text = strCaption
    End Sub
End Class