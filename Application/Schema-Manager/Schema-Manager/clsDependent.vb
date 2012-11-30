Imports Sem_Manager
Public Class clsDependent
    Dim objSemItem_Dependent As clsSemItem
    Dim objTreeNode_DBItem As TreeNode

    Public Property SemItem_Dependent() As clsSemItem
        Get
            Return objSemItem_Dependent
        End Get
        Set(ByVal value As clsSemItem)
            objSemItem_Dependent = value
        End Set
    End Property

    Public Property TreeNode_DBItem() As TreeNode
        Get
            Return objTreeNode_DBItem
        End Get
        Set(ByVal value As TreeNode)
            objTreeNode_DBItem = value
        End Set
    End Property
End Class
