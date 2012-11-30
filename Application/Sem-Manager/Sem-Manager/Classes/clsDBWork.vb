Public Class clsDBWork
    Private chngtblA_DB As New ds_ChangeTableAdapters.chngtbl_DBTableAdapter

    Private objConnection_DB As SqlClient.SqlConnection
    Private objConnection_Change As SqlClient.SqlConnection
    Private objSemItem_DB_User As New clsSemItem
    Private objGlobals As clsGlobals

    Public ReadOnly Property SemItem_DB() As clsSemItem
        Get
            Return objSemItem_DB_User
        End Get
    End Property

    Public Sub New(ByVal Connection_DB As SqlClient.SqlConnection, ByVal Globals As clsGlobals)
        objConnection_DB = Connection_DB
        objConnection_Change = New SqlClient.SqlConnection
        objGlobals = Globals
        set_DBConnection()
        get_DBs()
    End Sub

    Private Sub set_DBConnection()
        objConnection_Change = New SqlClient.SqlConnection(objGlobals.ConnectionString_Change)
        chngtblA_DB.Connection = objConnection_Change

    End Sub

    Private Sub get_DBs()
        Dim objDRC_DB_User As DataRowCollection

        objDRC_DB_User = chngtblA_DB.GetData_DB_ByName(objConnection_DB.Database).Rows

        objSemItem_DB_User.GUID = objDRC_DB_User(0).Item("GUID_DB")
        objSemItem_DB_User.Name = objDRC_DB_User(0).Item("Name_DB")

    End Sub

    
End Class
