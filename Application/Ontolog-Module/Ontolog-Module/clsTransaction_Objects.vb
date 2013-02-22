Public Class clsTransaction_Objects
    Private objLocalConfig As clsLocalConfig

    Private objDBLevel As clsDBLevel

    Private objFrm_Name As frm_Name

    Private objfrmParent As Windows.Forms.IWin32Window

    Public Function save_Object(ByVal strClass As String, Optional ByVal objOItem_Object As clsOntologyItem = Nothing) As clsOntologyItem
        Dim oList_Objects As New List(Of clsOntologyItem)
        Dim oList_ObjectDbl As New List(Of clsOntologyItem)
        Dim strGUID As String
        Dim objOItem_Result As clsOntologyItem
        Dim strValue As String
        Dim boolSave As Boolean

        If objOItem_Object Is Nothing Then
            objFrm_Name = New frm_Name("New Object", objLocalConfig, Nothing, Nothing, Nothing, True, True, False, False, True)
            objFrm_Name.ShowDialog(objfrmParent)
            If objFrm_Name.DialogResult = DialogResult.OK Then
                If objFrm_Name.isList = True Then
                    For Each strValue In objFrm_Name.Values
                        oList_Objects.Add(New clsOntologyItem(Guid.NewGuid.ToString.Replace("-", ""), _
                                                              strValue, _
                                                              strClass))
                    Next
                Else
                    If objFrm_Name.TextBox_GUID.Text = "" Then
                        strGUID = Guid.NewGuid.ToString.Replace("-", "")
                    Else
                        strGUID = objFrm_Name.TextBox_GUID.Text
                    End If
                    oList_Objects.Add(New clsOntologyItem(strGUID, _
                                                          objFrm_Name.Value1, _
                                                          strClass, _
                                                          objLocalConfig.Globals.Type_Object))
                    oList_ObjectDbl.Add(New clsOntologyItem(Nothing,
                                                            objFrm_Name.Value1, _
                                                            strClass, _
                                                            objLocalConfig.Globals.Type_Object))
                End If
                If objFrm_Name.More = True Then

                End If
            End If
        End If

        boolSave = True

        objOItem_Result = objLocalConfig.Globals.LState_Nothing
        If oList_Objects.Count > 0 Then
            objDBLevel.get_Data_Objects(oList_ObjectDbl)
            If objDBLevel.OList_Objects.Count > 0 Then
                Dim oL_Double = From obj_db In objDBLevel.OList_Objects
                                Join obj_new In oList_Objects On obj_db.Name.ToLower Equals obj_new.Name.ToLower

                If oL_Double.Count > 0 Then
                    If MsgBox("Es existiert bereits Objekt(e) mit dem Namen. Wollen Sie weitere anlegen?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        boolSave = False
                    End If
                End If

            End If
            If boolSave = True Then
                objOItem_Result = objDBLevel.save_Objects(oList_Objects)
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
