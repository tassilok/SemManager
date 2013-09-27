Imports System.Text.RegularExpressions

Public Class FrmReplace

    Private objLocalConfig As clsLocalConfig_SemList
    Private objDataGridView_ToReplace As DataGridView
    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter

    Public Sub New(DataGridView_ToReplace As DataGridView, LocalConfig As clsLocalConfig_SemList)
        
        ' This call is required by the designer.
        InitializeComponent()
        
        ' Add any initialization after the InitializeComponent() call.
        objDataGridView_ToReplace = DataGridView_ToReplace
        
        objLocalConfig = LocalConfig

        set_DBConnection()
        Initialize()
    End Sub

    Private sub set_DBConnection
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
    End Sub
    Private sub Initialize()

        For Each objDGVR As DataGridViewRow In objDataGridView_ToReplace.SelectedRows
            Dim objDRV As DataRowView = objDGVR.DataBoundItem
            Ds_Replace.dtbl_Replace.Rows.Add(objDRV.Item("GUID_Token"), objDRV.Item("Name_Token"), "", objDRV.Item("GUID_Type"))
        Next
        
        DataGridView_Replace.Columns(0).Visible = False
        DataGridView_Replace.Columns(3).Visible = False
    End Sub

    Private Sub TextBox_Search_TextChanged( sender As Object,  e As EventArgs) Handles TextBox_Search.TextChanged
        
        If TextBox_Search.Text.Length>0 Then
            Button_Test.Enabled= True
        Else 
            Button_Test.Enabled = False
        End If
    End Sub

    Private Sub Button_Test_Click( sender As Object,  e As EventArgs) Handles Button_Test.Click
        Dim strSearch as String = TextBox_Search.Text
        Dim strReplace As String = TextBox_Replace.Text

        For Each objDGVR As DataGridViewRow In DataGridView_Replace.Rows
            Dim objDRV As DataRowView = objDGVR.DataBoundItem
            Dim strNew =  Regex.Replace(objDRV.Item("Name_Item"),TextBox_Search.Text,TextBox_Replace.Text)
            
            objDRV.Item("Name_ReplacedItem") = strNew
        Next

        
    End Sub

    Private Sub Button_Cancel_Click( sender As Object,  e As EventArgs) Handles Button_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button_OK_Click( sender As Object,  e As EventArgs) Handles Button_OK.Click
        Dim objSemList_Items As New List(Of clsSemItem)
        Dim objDRC_LogState as DataRowCollection
        Dim boolMark As Boolean
        For Each objDGVR As DataGridViewRow In DataGridView_Replace.Rows
            Dim objDRV_Selected As DataRowView = objDGVR.DataBoundItem
            If objDRV_Selected.Item("Name_Item") <> objDRV_Selected.Item("Name_ReplacedItem") Then
                boolMark = True
            Else 
                boolMark = False
            End If
            objSemList_Items.Add(New clsSemItem With {.GUID = objDRV_Selected.Item("GUID_Item"), _
                                                      .Name = objDRV_Selected.Item("Name_ReplacedItem"), _
                                                      .GUID_Parent = objDRV_Selected.Item("GUID_Parent"), _
                                                      .Mark = boolMark})

            
        Next

        Dim objSemList_Change = (From objSemItem in objSemList_Items
                                 Where objSemItem.Mark = True
                                 Select objSemItem).ToList()

        If objSemList_Change.Any() Then
            Dim intOrig = DataGridView_Replace.Rows.Count
            Dim intToDo = objSemList_Items.Count
            Dim intDone = 0
            For Each objSemItem As clsSemItem In objSemList_Change
                objDRC_LogState = semprocA_DBWork_Save_Token.GetData(objSemItem.GUID,objSemItem.Name,objSemItem.GUID_Parent,False).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                    intDone = intDone + 1
                End If

            Next

            If intDone < intToDo Or intToDo < intOrig Then
                MsgBox("Es wurden " & intDone & " von " & intToDo & " von ursprünglich " & intOrig & " Elemente eingefügt!",MsgBoxStyle.Information)
            End If
            Me.Close()
        Else 
            MsgBox("Es wurden keine Änderungen festgestellt!",MsgBoxStyle.Information)
        End If
    End Sub
End Class