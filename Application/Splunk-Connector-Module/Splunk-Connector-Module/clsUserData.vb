Imports Sem_Manager
Public Class clsUserData
    Private procA_BaseConfig_SplunkServer As New DataSet_SplunkTableAdapters.proc_BaseConfig_SplunkServerTableAdapter
    Private procT_BaseConfig_SplunkServer As New DataSet_Splunk.proc_BaseConfig_SplunkServerDataTable

    Private splunktblA_XML_Variable As New DataSet_SplunkTableAdapters.splunktbl_XML_VariableTableAdapter
    Private splunktblT_XML_Variable As New DataSet_Splunk.splunktbl_XML_VariableDataTable

    Private procA_BaseConfig_XML As New DataSet_SplunkTableAdapters.proc_BaseConfig_XMLTableAdapter
    Private procT_BaseConfig_XML As New DataSet_Splunk.proc_BaseConfig_XMLDataTable

    Private objLocalConfig As clsLocalConfig

    Private objSemItem_Server As New clsSemItem
    Private objSemItem_Port As New clsSemItem

    Public ReadOnly Property XML_Variable_T As DataSet_Splunk.splunktbl_XML_VariableDataTable
        Get
            Return splunktblT_XML_Variable
        End Get
    End Property

    Public ReadOnly Property BaseConfig_XML_T As DataSet_Splunk.proc_BaseConfig_XMLDataTable
        Get
            Return procT_BaseConfig_XML
        End Get
    End Property

    Public ReadOnly Property TextConfig_Report As clsSemItem
        Get
            Dim objXMLDom As New Xml.XmlDocument
            Dim objXMLElement As Xml.XmlElement
            Dim objSemItem_Text As New clsSemItem

            If procT_BaseConfig_XML.Rows.Count = 1 Then
                Try
                    objXMLDom.LoadXml(procT_BaseConfig_XML.Rows(0).Item("XMLReport"))
                    objXMLElement = objXMLDom.GetElementsByTagName("data").Item(0)

                    objSemItem_Text.GUID = procT_BaseConfig_XML.Rows(0).Item("GUID_XML_Report")
                    objSemItem_Text.Name = procT_BaseConfig_XML.Rows(0).Item("Name_XML_Report")
                    objSemItem_Text.Additional1 = objXMLElement.InnerText
                    objSemItem_Text.GUID_Parent = objLocalConfig.SemItem_Type_XML.GUID
                    objSemItem_Text.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                Catch ex As Exception
                    objSemItem_Text = Nothing
                End Try


            Else
                objSemItem_Text = Nothing
            End If

            Return objSemItem_Text
        End Get
    End Property

    Public ReadOnly Property TextConfig_Row As clsSemItem
        Get
            Dim objXMLDom As New Xml.XmlDocument
            Dim objXMLElement As Xml.XmlElement
            Dim objSemItem_Text As New clsSemItem

            If procT_BaseConfig_XML.Rows.Count = 1 Then
                Try
                    objXMLDom.LoadXml(procT_BaseConfig_XML.Rows(0).Item("XMLRow"))
                    objXMLElement = objXMLDom.GetElementsByTagName("data").Item(0)

                    objSemItem_Text.GUID = procT_BaseConfig_XML.Rows(0).Item("GUID_XML_Row")
                    objSemItem_Text.Name = procT_BaseConfig_XML.Rows(0).Item("Name_XML_Row")
                    objSemItem_Text.Additional1 = objXMLElement.InnerText
                    objSemItem_Text.GUID_Parent = objLocalConfig.SemItem_Type_XML.GUID
                    objSemItem_Text.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                Catch ex As Exception
                    objSemItem_Text = Nothing
                End Try


            Else
                objSemItem_Text = Nothing
            End If

            Return objSemItem_Text
        End Get
    End Property


    Public ReadOnly Property TextConfig_Field As clsSemItem
        Get
            Dim objXMLDom As New Xml.XmlDocument
            Dim objXMLElement As Xml.XmlElement
            Dim objSemItem_Text As New clsSemItem

            If procT_BaseConfig_XML.Rows.Count = 1 Then
                Try
                    objXMLDom.LoadXml(procT_BaseConfig_XML.Rows(0).Item("XMLField"))
                    objXMLElement = objXMLDom.GetElementsByTagName("data").Item(0)

                    objSemItem_Text.GUID = procT_BaseConfig_XML.Rows(0).Item("GUID_XML_Field")
                    objSemItem_Text.Name = procT_BaseConfig_XML.Rows(0).Item("Name_XML_Field")
                    objSemItem_Text.Additional1 = objXMLElement.InnerText
                    objSemItem_Text.GUID_Parent = objLocalConfig.SemItem_Type_XML.GUID
                    objSemItem_Text.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                Catch ex As Exception
                    objSemItem_Text = Nothing
                End Try


            Else
                objSemItem_Text = Nothing
            End If

            Return objSemItem_Text
        End Get
    End Property

    Public ReadOnly Property SemItem_Server As clsSemItem
        Get
            If procT_BaseConfig_SplunkServer.Count > 0 Then
                objSemItem_Server = New clsSemItem
                objSemItem_Server.GUID = procT_BaseConfig_SplunkServer.Rows(0).Item("GUID_Server")
                objSemItem_Server.Name = procT_BaseConfig_SplunkServer.Rows(0).Item("Name_Server")
                objSemItem_Server.GUID_Parent = objLocalConfig.SemItem_Type_Server.GUID
                objSemItem_Server.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Else
                objSemItem_Server = Nothing
            End If

            Return objSemItem_Server
        End Get
    End Property

    Public ReadOnly Property SemItem_Port As clsSemItem
        Get
            If procT_BaseConfig_SplunkServer.Count > 0 Then
                objSemItem_Port = New clsSemItem
                objSemItem_Port.GUID = procT_BaseConfig_SplunkServer.Rows(0).Item("GUID_Port")
                objSemItem_Port.Name = procT_BaseConfig_SplunkServer.Rows(0).Item("Name_Port")
                objSemItem_Port.GUID_Parent = objLocalConfig.SemItem_Type_Port.GUID
                objSemItem_Port.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Else
                objSemItem_Port = Nothing
            End If

            Return objSemItem_Port
        End Get
    End Property


    Private Sub get_BaseData()
        procA_BaseConfig_SplunkServer.Fill(procT_BaseConfig_SplunkServer, _
                                           objLocalConfig.SemItem_Type_Server_Port.GUID, _
                                           objLocalConfig.SemItem_Type_Port.GUID, _
                                           objLocalConfig.SemItem_Type_Server.GUID, _
                                           objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                           objLocalConfig.SemItem_BaseConfig.GUID)

        splunktblA_XML_Variable.Fill(splunktblT_XML_Variable)

        procA_BaseConfig_XML.Fill(procT_BaseConfig_XML, _
                                  objLocalConfig.SemItem_Attribute_XML_Text.GUID, _
                                  objLocalConfig.SemItem_Type_XML.GUID, _
                                  objLocalConfig.SemItem_Type_Variable.GUID, _
                                  objLocalConfig.SemItem_RelationType_belonging_Report_Template.GUID, _
                                  objLocalConfig.SemItem_RelationType_belonging_Row_Template.GUID, _
                                  objLocalConfig.SemItem_RelationType_belonging_Field_Template.GUID, _
                                  objLocalConfig.SemItem_RelationType_contains.GUID, _
                                  objLocalConfig.SemItem_BaseConfig.GUID)
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        set_DBConnection()

        initialize()
    End Sub

    Private Sub initialize()
        get_BaseData()
    End Sub

    Private Sub set_DBConnection()
        procA_BaseConfig_SplunkServer.Connection = objLocalConfig.Connection_Plugin
        procA_BaseConfig_XML.Connection = objLocalConfig.Connection_Plugin
        splunktblA_XML_Variable.Connection = objLocalConfig.Connection_Plugin
    End Sub
End Class
