Public Class clsTokenEdit_Navigation

    Private objDataPos As New clsDataPos
    Private intRowID_First As Integer
    Private intRowID_Selected As Integer


    Private Shared objDatagridview_Source As DataGridView
    Private objSemItem_Active As clsSemItem
    Private objGlobals As clsGlobals

    Public Shared ReadOnly Property DataGridView_Source() As DataGridView
        Get
            Return objDatagridview_Source
        End Get
    End Property
    Public Sub select_SemItem()
        intRowID_Selected = objDataPos.Row
    End Sub
    Public Property SemItem_Active() As clsSemItem
        Get
            Return objSemItem_Active
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_Active = value
        End Set
    End Property

    Public ReadOnly Property DataPos() As clsDataPos
        Get
            Return objDataPos
        End Get
    End Property

    Public Sub set_Relation(ByVal GUID_Type As Guid, ByVal GUID_RelationType As Guid)
        objSemItem_Active.GUID_Related = GUID_Type
        objSemItem_Active.GUID_Relation = GUID_RelationType
    End Sub
    Public Sub set_Relation(ByVal GUID_Attribute As Guid)
        objSemItem_Active.GUID_Related = GUID_Attribute
        objSemItem_Active.GUID_Relation = Nothing
    End Sub
    Public Property Deleted() As Boolean
        Get
            Return objSemItem_Active.deleted
        End Get
        Set(ByVal value As Boolean)
            objSemItem_Active.deleted = value
        End Set
    End Property
    Public Sub New(ByVal objSemItem As clsSemItem, ByVal Globals As clsGlobals)
        objGlobals = Globals
        objSemItem_Active = objSemItem
        objDataPos.Count = 1
        objDataPos.Row = 1
        intRowID_First = 1
    End Sub
    Public Sub New(ByRef objDataGridView As DataGridView, ByVal objSemItem As clsSemItem, ByVal intRowID As Integer, ByVal Globals As clsGlobals)
        objGlobals = Globals
        objDatagridview_Source = objDataGridView
        objSemItem_Active = objSemItem
        objDataPos.Row = intRowID + 1
        objDataPos.Count = objDatagridview_Source.RowCount
        intRowID_First = intRowID + 1
    End Sub

    Public Function First_Sem() As Boolean
        Dim objDataGridViewRow As DataGridViewRow
        Dim objDRV As DataRowView

        If objDataPos.Row > 1 Then
            objDataPos.Row = 1
            objDataGridViewRow = objDatagridview_Source.Rows(objDataPos.Row - 1)
            objDRV = objDataGridViewRow.DataBoundItem
            objSemItem_Active = New clsSemItem
            If objDataGridViewRow.Cells.Count = 8 Then
                objSemItem_Active.GUID = objDRV.Item("GUID_Token_Right")
                objSemItem_Active.Name = objDRV.Item("Name_Token_Right")
                objSemItem_Active.GUID_Parent = objDRV.Item("GUID_Type_Right")
            Else
                objSemItem_Active.GUID = objDRV.Item("GUID_Token")
                objSemItem_Active.Name = objDRV.Item("Name_Token")
                objSemItem_Active.GUID_Parent = objDRV.Item("GUID_Type")
            End If

            objSemItem_Active.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Previous_Sem() As Boolean
        Dim objDataGridViewRow As DataGridViewRow
        Dim objDRV As DataRowView

        If objDataPos.Row > 1 Then
            objDataPos.Row = objDataPos.Row - 1
            objDataGridViewRow = objDatagridview_Source.Rows(objDataPos.Row - 1)
            objDRV = objDataGridViewRow.DataBoundItem
            objSemItem_Active = New clsSemItem
            If objDataGridViewRow.Cells.Count = 8 Then
                objSemItem_Active.GUID = objDRV.Item("GUID_Token_Right")
                objSemItem_Active.Name = objDRV.Item("Name_Token_Right")
                objSemItem_Active.GUID_Parent = objDRV.Item("GUID_Type_Right")
            Else
                objSemItem_Active.GUID = objDRV.Item("GUID_Token")
                objSemItem_Active.Name = objDRV.Item("Name_Token")
                objSemItem_Active.GUID_Parent = objDRV.Item("GUID_Type")
            End If

            objSemItem_Active.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

            Return True
        Else
            Return False
        End If
    End Function

    Public Function Next_Sem() As Boolean
        Dim objDataGridViewRow As DataGridViewRow
        Dim objDRV As DataRowView

        If objDataPos.Row < objDataPos.Count Then
            objDataPos.Row = objDataPos.Row + 1
            objDataGridViewRow = objDatagridview_Source.Rows(objDataPos.Row - 1)
            objDRV = objDataGridViewRow.DataBoundItem
            objSemItem_Active = New clsSemItem
            If objDataGridViewRow.Cells.Count = 8 Then
                objSemItem_Active.GUID = objDRV.Item("GUID_Token_Right")
                objSemItem_Active.Name = objDRV.Item("Name_Token_Right")
                objSemItem_Active.GUID_Parent = objDRV.Item("GUID_Type_Right")
            Else
                objSemItem_Active.GUID = objDRV.Item("GUID_Token")
                objSemItem_Active.Name = objDRV.Item("Name_Token")
                objSemItem_Active.GUID_Parent = objDRV.Item("GUID_Type")
            End If

            objSemItem_Active.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Return True
        Else
            Return False
        End If
    End Function
    Public Function Last_Sem() As Boolean
        Dim objDataGridViewRow As DataGridViewRow
        Dim objDRV As DataRowView

        If objDataPos.Row < objDataPos.Count Then
            objDataPos.Row = objDataPos.Count
            objDataGridViewRow = objDatagridview_Source.Rows(objDataPos.Row - 1)
            objDRV = objDataGridViewRow.DataBoundItem
            objSemItem_Active = New clsSemItem
            If objDataGridViewRow.Cells.Count = 8 Then
                objSemItem_Active.GUID = objDRV.Item("GUID_Token_Right")
                objSemItem_Active.Name = objDRV.Item("Name_Token_Right")
                objSemItem_Active.GUID_Parent = objDRV.Item("GUID_Type_Right")
            Else
                objSemItem_Active.GUID = objDRV.Item("GUID_Token")
                objSemItem_Active.Name = objDRV.Item("Name_Token")
                objSemItem_Active.GUID_Parent = objDRV.Item("GUID_Type")
            End If

            objSemItem_Active.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Return True
        Else
            Return False
        End If
    End Function


End Class
