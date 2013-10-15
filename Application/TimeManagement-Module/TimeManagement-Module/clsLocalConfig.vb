Imports Sem_Manager
Public Class clsLocalConfig
  Private Const cstr_GUIDToken_Development As String = "4a523d1f-cc62-4798-8eb3-faf9c9bbc6a9"
  
  Private objGlobals As clsGlobals
  Private objConnection_DB As SqlClient.SqlConnection
  Private objConnection_Config As SqlClient.SqlConnection
  Private objConnection_Plugin As SqlClient.SqlConnection
  
  Private procA_TokenAttribute_Varchar255 As New ds_TokenAttributeTableAdapters.TokenAttribute_Varchar255TableAdapter
  
  Private funcA_SoftwareDevelopment_Config As New ds_DevelopmentConfigTableAdapters.func_SoftwareDevelopment_ConfigTableAdapter
  Private func_SoftwareDevelopment_Config As New ds_DevelopmentConfig.func_SoftwareDevelopment_ConfigDataTable

   Private procA_OR_Attribute_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_Attribute_By_GUIDObjectReferenceTableAdapter
   Private procA_OR_RelationType_By_GUIDObjectReference As New ds_ObjectReferenceTableAdapters.proc_OR_RelationType_By_GUIDObjectReferenceTableAdapter
   Private procA_OR_Token_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Token_By_GUIDObjectReferenceTableAdapter
   Private procA_OR_Type_By_GUID As New ds_ObjectReferenceTableAdapters.proc_OR_Type_By_GUIDObjectReferenceTableAdapter

  
  Private objGUID_Development As Guid
  
  Private objSemItem_Attribute_DateTimeStamp As New clsSemItem
Private objSemItem_attribute_dbPostfix As New clsSemItem
Private objSemItem_Attribute_ID As New clsSemItem
Private objSemItem_Attribute_Message As New clsSemItem
Private objSemItem_RelationType_belonging As New clsSemItem
Private objSemItem_RelationType_isInState As New clsSemItem
Private objSemItem_RelationType_provides As New clsSemItem
Private objSemItem_RelationType_wasCreatedBy As New clsSemItem
Private objSemItem_Token_Logstate_Krank As New clsSemItem
Private objSemItem_Token_Logstate_private As New clsSemItem
Private objSemItem_Token_Logstate_Urlaub As New clsSemItem
Private objSemItem_Token_Logstate_Work As New clsSemItem
Private objSemItem_Type_LogEntry As New clsSemItem
Private objSemItem_type_Logstate As New clsSemItem
Private objSemItem_Type_Timemanagement As New clsSemItem
Private objSemItem_type_User As New clsSemItem

    Private objSemItem_User As clsSemItem

    Public Property  User() As clsSemItem
        get
            Return objSemItem_User
        End Get
        Set(value As clsSemItem)
            objSemItem_User = value
        End Set
    End Property

  
  Public ReadOnly Property SemItem_Attribute_DateTimeStamp() As clsSemItem
  Get
    Return objSemItem_Attribute_DateTimeStamp
  End Get
End Property

Public ReadOnly Property SemItem_attribute_dbPostfix() As clsSemItem
  Get
    Return objSemItem_attribute_dbPostfix
  End Get
End Property

Public ReadOnly Property SemItem_Attribute_ID() As clsSemItem
  Get
    Return objSemItem_Attribute_ID
  End Get
End Property

Public ReadOnly Property SemItem_Attribute_Message() As clsSemItem
  Get
    Return objSemItem_Attribute_Message
  End Get
End Property

Public ReadOnly Property SemItem_RelationType_belonging() As clsSemItem
  Get
    Return objSemItem_RelationType_belonging
  End Get
End Property

Public ReadOnly Property SemItem_RelationType_isInState() As clsSemItem
  Get
    Return objSemItem_RelationType_isInState
  End Get
End Property

Public ReadOnly Property SemItem_RelationType_provides() As clsSemItem
  Get
    Return objSemItem_RelationType_provides
  End Get
End Property

Public ReadOnly Property SemItem_RelationType_wasCreatedBy() As clsSemItem
  Get
    Return objSemItem_RelationType_wasCreatedBy
  End Get
End Property

Public ReadOnly Property SemItem_Token_Logstate_Krank() As clsSemItem
  Get
    Return objSemItem_Token_Logstate_Krank
  End Get
End Property

Public ReadOnly Property SemItem_Token_Logstate_private() As clsSemItem
  Get
    Return objSemItem_Token_Logstate_private
  End Get
End Property

Public ReadOnly Property SemItem_Token_Logstate_Urlaub() As clsSemItem
  Get
    Return objSemItem_Token_Logstate_Urlaub
  End Get
End Property

Public ReadOnly Property SemItem_Token_Logstate_Work() As clsSemItem
  Get
    Return objSemItem_Token_Logstate_Work
  End Get
End Property

Public ReadOnly Property SemItem_Type_LogEntry() As clsSemItem
  Get
    Return objSemItem_Type_LogEntry
  End Get
End Property

Public ReadOnly Property SemItem_type_Logstate() As clsSemItem
  Get
    Return objSemItem_type_Logstate
  End Get
End Property

Public ReadOnly Property SemItem_Type_Timemanagement() As clsSemItem
  Get
    Return objSemItem_Type_Timemanagement
  End Get
End Property

Public ReadOnly Property SemItem_type_User() As clsSemItem
  Get
    Return objSemItem_type_User
  End Get
End Property


  
  Public ReadOnly Property Connection_DB() As SqlClient.SqlConnection
    Get
      Return objConnection_DB
    End Get
  End Property

  Public ReadOnly Property Connection_Plugin() As SqlClient.SqlConnection
    Get
      Return objConnection_Plugin
    End Get
  End Property

  Public ReadOnly Property Globals() As clsGlobals
    Get
      Return objGlobals
    End Get
  End Property
  
  Public Sub New(ByVal Globals As clsGlobals)
    objGlobals = Globals
    objConnection_DB = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
    objConnection_Config = New SqlClient.SqlConnection(objGlobals.ConnectionString_System)

    objGUID_Development = New Guid(cstr_GUIDToken_Development)

    set_DBConnection()
    get_Config()
  End Sub
  
  Private Sub set_DBConnection()
    funcA_SoftwareDevelopment_Config.Connection = objConnection_Config

    procA_TokenAttribute_Varchar255.Connection = objConnection_Config

    procA_OR_Attribute_By_GUIDObjectReference.Connection = objConnection_Config
    procA_OR_RelationType_By_GUIDObjectReference.Connection = objConnection_Config
    procA_OR_Token_By_GUID.Connection = objConnection_Config
    procA_OR_Type_By_GUID.Connection = objConnection_Config
  End Sub
  
  Private Sub get_Config()
    Dim objDRC_RelData As DataRowCollection
    Dim objDRs_ConfigItem() As DataRow
    Dim objDRC_Ref As DataRowCollection
    funcA_SoftwareDevelopment_Config.Fill_By_GUIDDevelopment(func_SoftwareDevelopment_Config, objGUID_Development)
    
    get_Config_Attributes()
    get_Config_RelationTypes()
    get_Config_Token()
    get_Config_Types()
        
    
  End Sub
  
  Private Sub get_Config_Attributes()
      Dim objDRC_RelData As DataRowCollection
      Dim objDRs_ConfigItem() As DataRow
      Dim objDRC_Ref As DataRowCollection
      
      objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_DateTimeStamp'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_DateTimeStamp.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_DateTimeStamp.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_DateTimeStamp.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_DateTimeStamp.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
                
                
            Else
                Err.Raise(1, "Config not set")
            End If
            

        Else
            Err.Raise(1, "Config not set")
        End If

objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='attribute_dbPostfix'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_attribute_dbPostfix.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_attribute_dbPostfix.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_attribute_dbPostfix.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_attribute_dbPostfix.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID

                objDRC_RelData = procA_TokenAttribute_Varchar255.GetData_By_GUIDAttribute_And_GUIDToken(objGUID_Development, objSemItem_Attribute_dbPostfix.GUID).Rows

                objConnection_Plugin = New SqlClient.SqlConnection(objGlobals.get_DB_ConnectionString(objDRC_RelData(0).Item("Val")))
            Else
                Err.Raise(1, "Config not set")
            End If
            

        Else
            Err.Raise(1, "Config not set")
        End If

objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_ID'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_ID.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_ID.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_ID.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_ID.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If
            

        Else
            Err.Raise(1, "Config not set")
        End If

objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Attribute_Message'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Attribute_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Attribute_Message.GUID = objDRC_Ref(0).Item("GUID_Attribute")
                objSemItem_Attribute_Message.Name = objDRC_Ref(0).Item("Name_Attribute")
                objSemItem_Attribute_Message.GUID_Parent = objDRC_Ref(0).Item("GUID_AttributeType")
                objSemItem_Attribute_Message.GUID_Type = objGlobals.ObjectReferenceType_Attribute.GUID
            Else
                Err.Raise(1, "Config not set")
            End If
            

        Else
            Err.Raise(1, "Config not set")
        End If


  End Sub
  
  Private Sub get_Config_RelationTypes()
      Dim objDRC_RelData As DataRowCollection
      Dim objDRs_ConfigItem() As DataRow
      Dim objDRC_Ref As DataRowCollection
      
       objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_belonging'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_belonging.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_belonging.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_belonging.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

 objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_isInState'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_isInState.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_isInState.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_isInState.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

 objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_provides'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_provides.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_provides.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_provides.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

 objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='RelationType_wasCreatedBy'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_RelationType_By_GUIDObjectReference.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_RelationType_wasCreatedBy.GUID = objDRC_Ref(0).Item("GUID_RelationType")
                objSemItem_RelationType_wasCreatedBy.Name = objDRC_Ref(0).Item("Name_RelationType")
                objSemItem_RelationType_wasCreatedBy.GUID_Type = objGlobals.ObjectReferenceType_RelationType.GUID

            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If


  End Sub
  
  Private Sub get_Config_Token()
      Dim objDRC_RelData As DataRowCollection
      Dim objDRs_ConfigItem() As DataRow
      Dim objDRC_Ref As DataRowCollection
      
      objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_Krank'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_Krank.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_Krank.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_Krank.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_Krank.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_private'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_private.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_private.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_private.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_private.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_Urlaub'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_Urlaub.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_Urlaub.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_Urlaub.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_Urlaub.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Token_Logstate_Work'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Token_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Token_Logstate_Work.GUID = objDRC_Ref(0).Item("GUID_Token")
                objSemItem_Token_Logstate_Work.Name = objDRC_Ref(0).Item("Name_Token")
                objSemItem_Token_Logstate_Work.GUID_Parent = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Token_Logstate_Work.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If


  End Sub
  
  Private Sub get_Config_Types()
      Dim objDRC_RelData As DataRowCollection
      Dim objDRs_ConfigItem() As DataRow
      Dim objDRC_Ref As DataRowCollection
      
      objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_LogEntry'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_LogEntry.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_LogEntry.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_LogEntry.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_LogEntry.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_Logstate'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_Logstate.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_Logstate.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_Logstate.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_Logstate.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='Type_Timemanagement'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_Type_Timemanagement.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_Type_Timemanagement.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_Type_Timemanagement.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_Type_Timemanagement.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If

objDRs_ConfigItem = func_SoftwareDevelopment_Config.Select("Name_Token_ConfigItem='type_User'")
        If objDRs_ConfigItem.Length > 0 Then
            objDRC_Ref = procA_OR_Type_By_GUID.GetData(objDRs_ConfigItem(0).Item("GUID_ObjectReference")).Rows
            If objDRC_Ref.Count > 0 Then
                objSemItem_type_User.GUID = objDRC_Ref(0).Item("GUID_Type")
                objSemItem_type_User.Name = objDRC_Ref(0).Item("Name_Type")
                If Not IsDBNull(objDRC_Ref(0).Item("GUID_Type_Parent")) Then
                    objSemItem_type_User.GUID_Parent = objDRC_Ref(0).Item("GUID_Type_Parent")
                End If
                objSemItem_type_User.GUID_Type = objGlobals.ObjectReferenceType_Type.GUID
            Else
                Err.Raise(1, "Config not set")
            End If


        Else
            Err.Raise(1, "Config not set")
        End If


  End Sub
End Class
  