Imports Sem_Manager
Public Class clsTagWork
    Private objLocalConfig As clsLocalConfig
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Public Function get_Tag(ByVal GUID_WikiComponent As Guid, ByVal boolOpen As Boolean) As String
        Dim objDRC_Markup As DataRowCollection
        Dim strTag As String = Nothing

        objDRC_Markup = funcA_TokenAttribute_Named_By_GUIDToken.GetData_OrderIDASC(GUID_WikiComponent, objLocalConfig.SemItem_Attribute_WIKI_Tag.GUID).Rows
        If objDRC_Markup.Count > 0 Then
            If objDRC_Markup.Count = 1 Then
                strTag = objDRC_Markup(0).Item("Val_VARCHAR255")
            ElseIf objDRC_Markup.Count = 2 Then
                If boolOpen = True Then
                    strTag = objDRC_Markup(0).Item("Val_VARCHAR255")
                Else
                    strTag = objDRC_Markup(1).Item("Val_VARCHAR255")
                End If
            End If
        End If
        Return strTag
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
    End Sub
End Class
