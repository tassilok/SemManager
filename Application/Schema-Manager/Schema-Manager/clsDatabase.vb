Public Class clsDatabase
    Private strName_Server As String
    Private strName_Database As String
    Private intCount_Functions As Integer
    Private intShown_Functions As Integer
    Private intCount_Procedures As Integer
    Private intShown_Procedures As Integer
    Private intCount_Synonyms As Integer
    Private intShown_Synonyms As Integer
    Private intCount_Tables As Integer
    Private intShown_Tables As Integer
    Private intCount_Triggers As Integer
    Private intShown_Triggers As Integer
    Private intCount_Views As Integer
    Private intShown_Views As Integer
    Private objTreeNode_Database As TreeNode

    Public Property Name_Server() As String
        Get
            Return strName_Server
        End Get
        Set(ByVal value As String)
            strName_Server = value
        End Set
    End Property

    Public Property Name_Database() As String
        Get
            Return strName_Database
        End Get
        Set(ByVal value As String)
            strName_Database = value
        End Set
    End Property

    Public Property Count_Functions() As Integer
        Get
            Return intCount_Functions
        End Get
        Set(ByVal value As Integer)
            intCount_Functions = value
        End Set
    End Property
    Public Property Shown_Functions() As Integer
        Get
            Return intShown_Functions
        End Get
        Set(ByVal value As Integer)
            intShown_Functions = value
        End Set
    End Property

    Public Property Count_Procedures() As Integer
        Get
            Return intCount_Procedures
        End Get
        Set(ByVal value As Integer)
            intCount_Procedures = value
        End Set
    End Property
    Public Property Shown_Procedures() As Integer
        Get
            Return intShown_Procedures
        End Get
        Set(ByVal value As Integer)
            intShown_Procedures = value
        End Set
    End Property

    Public Property Count_Synonyms() As Integer
        Get
            Return intCount_Synonyms
        End Get
        Set(ByVal value As Integer)
            intCount_Synonyms = value
        End Set
    End Property
    Public Property Shown_Synonyms() As Integer
        Get
            Return intShown_Synonyms
        End Get
        Set(ByVal value As Integer)
            intShown_Synonyms = value
        End Set
    End Property

    Public Property Count_Tables() As Integer
        Get
            Return intCount_Tables
        End Get
        Set(ByVal value As Integer)
            intCount_Tables = value
        End Set
    End Property
    Public Property Shown_Tables() As Integer
        Get
            Return intShown_Tables
        End Get
        Set(ByVal value As Integer)
            intShown_Tables = value
        End Set
    End Property
    Public Property Count_Triggers() As Integer
        Get
            Return intCount_Triggers
        End Get
        Set(ByVal value As Integer)
            intCount_Triggers = value
        End Set
    End Property
    Public Property Shown_Triggers() As Integer
        Get
            Return intShown_Triggers
        End Get
        Set(ByVal value As Integer)
            intShown_Triggers = value
        End Set
    End Property

    Public Property Count_Views() As Integer
        Get
            Return intCount_Views
        End Get
        Set(ByVal value As Integer)
            intCount_Views = value
        End Set
    End Property
    Public Property Shown_Views() As Integer
        Get
            Return intShown_Views
        End Get
        Set(ByVal value As Integer)
            intShown_Views = value
        End Set
    End Property
    Public Property TreeNode_Database() As TreeNode
        Get
            Return objTreeNode_Database
        End Get
        Set(ByVal value As TreeNode)
            objTreeNode_Database = value
        End Set
    End Property
End Class
