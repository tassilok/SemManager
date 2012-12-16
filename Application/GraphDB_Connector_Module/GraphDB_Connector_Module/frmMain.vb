Imports Sem_Manager
Public Class frmMain
    Private objLocalConfig As clsLocalConfig

    Private objUserData As clsUserData
    Private objGraphDB As clsGraphDB

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objLocalConfig = New clsLocalConfig(New clsGlobals)

        set_DBConnection()
        initialize()
    End Sub

    Private Sub initialize()
        Dim objSemItem_Result As clsSemItem
        objSemItem_Result = objGraphDB.initialize_GraphDB()
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objGraphDB.SemItem_Url = objUserData.SemItem_URL
            If objGraphDB.SingleInstance = False Then
                If objGraphDB.GraphDB_Exists = False Then
                    objGraphDB.create_Database()
                End If
            End If
            
            objGraphDB.create_KindOfOntologies()
            objGraphDB.create_DataTypes()
            objGraphDB.create_Attributes()
            objGraphDB.create_RelationTypes()
            objGraphDB.create_Class()
            objGraphDB.create_Object()
            objGraphDB.create_Object_Rel()
        End If
        
    End Sub

    Private Sub set_DBConnection()
        objUserData = New clsUserData(objLocalConfig)
        objGraphDB = New clsGraphDB(objLocalConfig)
    End Sub

    
End Class
