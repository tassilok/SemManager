Public Class clsTransaction_RelationTypes

    Private objLocalConfig As clsLocalConfig

    Private objDBLevel As clsDBLevel

    Private objFrm_Name As frm_Name

    Private objfrmParent As Windows.Forms.IWin32Window

    Public Function save_RelType(Optional ByVal OItem_RelationType As clsOntologyItem = Nothing) As clsOntologyItem
        Dim objOItem_RelationType As New clsOntologyItem
        Dim objOItem_Result As clsOntologyItem

        objOItem_Result = objLocalConfig.Globals.LState_Nothing
        objFrm_Name = New frm_Name("New RelationType", _
                                           objLocalConfig, _
                                           Nothing, _
                                           Nothing, _
                                           Nothing, _
                                           True)
        objFrm_Name.ShowDialog(objfrmParent)
        If objFrm_Name.DialogResult = DialogResult.OK Then
            objOItem_RelationType.GUID = objFrm_Name.TextBox_GUID.Text
            If objOItem_RelationType.GUID = "" Then
                objOItem_RelationType.GUID = Guid.NewGuid.ToString.Replace("-", "")
            End If
            objOItem_RelationType.Name = objFrm_Name.Value1
            objOItem_RelationType.Type = objLocalConfig.Globals.Type_RelationType

            objOItem_Result = objDBLevel.save_RelationType(objOItem_RelationType)

            If objOItem_Result.GUID = objLocalConfig.Globals.LState_Exists.GUID Then
                objOItem_Result = objLocalConfig.Globals.LState_Relation

            ElseIf objOItem_Result.GUID = objLocalConfig.Globals.LState_Error.GUID Then
                objOItem_Result = objLocalConfig.Globals.LState_Error
            Else
                objOItem_Result = objLocalConfig.Globals.LState_Success
            End If


        End If

        Return objOItem_Result
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig, Optional ByVal frmParent As Windows.Forms.IWin32Window = Nothing)
        objLocalConfig = LocalConfig
        objfrmParent = frmParent

        set_DBConnection()
    End Sub

    Private Sub set_DBConnection()
        objDBLevel = New clsDBLevel(objLocalConfig)
    End Sub
End Class
