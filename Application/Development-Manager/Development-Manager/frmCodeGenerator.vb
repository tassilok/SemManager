Imports Sem_Manager
Public Class frmCodeGenerator

    Private objXML_clsConfig As Xml.XmlDocument
    Private objXML_Element As Xml.XmlElement
    Private objXML_ConfigDeclaration As Xml.XmlDocument

    Private strXML_Config As String
    Private strXML_Declaration As String
    Private strXML_Declaration_List As String
    Private strXML_Initialization_Attribute As String
    Private strXML_Initialization_Token As String
    Private strXML_Initialization_Type As String
    Private strXML_Initialization_RelationType As String
    Private strXML_Initialization_List As String
    Private strXML_Property As String
    Private strXML_Property_List As String

    Private strList_Initialization_Attribute As String
    Private strList_Initialization_RelationType As String
    Private strList_Initialization_Token As String
    Private strList_Initialization_Type As String

    Private procA_TokenAttribute_VarcharMAX As New ds_TokenAttributeTableAdapters.TokenAttribute_VarcharMAXTableAdapter
    Private objDataGridView_Config As DataGridView

    Private objSemItem_Development As clsSemItem

    Public Sub New(ByRef DataGridView_Config As DataGridView, ByVal SemItem_Development As clsSemItem)

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        objDataGridView_Config = DataGridView_Config
        objSemItem_Development = SemItem_Development
        set_DBConnection()
        get_Code()
    End Sub

    Private Sub get_Code()
        Dim objDRC_XML As DataRowCollection

        'Dim objDR_ConfigItem As DataRow
        Dim objDGVR_ConfigItem As DataGridViewRow
        Dim objDRV_ConfigItem As DataRowView
        objDRC_XML = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(objLocalConfig.SemItem_Token_clsLocalConfig_xml_XML.GUID, objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
        If objDRC_XML.Count > 0 Then
            objXML_clsConfig = New Xml.XmlDocument
            objXML_clsConfig.LoadXml(objDRC_XML(0).Item("Val"))
            objXML_Element = objXML_clsConfig.GetElementsByTagName("data")(0)
            strXML_Config = objXML_Element.InnerText.Replace("@GUID_Development@", objSemItem_Development.GUID.ToString)
            objDRC_XML = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(objLocalConfig.SemItem_Token_Declaration_Configitems_XML.GUID, objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
            If objDRC_XML.Count > 0 Then
                objXML_clsConfig = New Xml.XmlDocument
                objXML_clsConfig.LoadXml(objDRC_XML(0).Item("Val"))
                objXML_Element = objXML_clsConfig.GetElementsByTagName("data")(0)
                strXML_Declaration = objXML_clsConfig.InnerText
                objDRC_XML = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(objLocalConfig.SemItem_Token_Property_ConfigItem_XML.GUID, objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
                If objDRC_XML.Count > 0 Then
                    objXML_clsConfig = New Xml.XmlDocument
                    objXML_clsConfig.LoadXml(objDRC_XML(0).Item("Val"))
                    objXML_Element = objXML_clsConfig.GetElementsByTagName("data")(0)
                    strXML_Property = objXML_Element.InnerText

                    objDRC_XML = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(objLocalConfig.SemItem_Token_Initilize_Attribute__ConfigItem__XML.GUID, objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
                    If objDRC_XML.Count > 0 Then
                        objXML_clsConfig = New Xml.XmlDocument
                        objXML_clsConfig.LoadXml(objDRC_XML(0).Item("Val"))
                        objXML_Element = objXML_clsConfig.GetElementsByTagName("data")(0)
                        strXML_Initialization_Attribute = objXML_Element.InnerText
                        objDRC_XML = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(objLocalConfig.SemItem_Token_Initialize_Token__ConfigItem__XML.GUID, objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
                        If objDRC_XML.Count > 0 Then
                            objXML_clsConfig = New Xml.XmlDocument
                            objXML_clsConfig.LoadXml(objDRC_XML(0).Item("Val"))
                            objXML_Element = objXML_clsConfig.GetElementsByTagName("data")(0)
                            strXML_Initialization_Token = objXML_Element.InnerText
                            objDRC_XML = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(objLocalConfig.SemItem_Token_Initilize_Type__ConfigItem__XML.GUID, objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
                            If objDRC_XML.Count > 0 Then
                                objXML_clsConfig = New Xml.XmlDocument
                                objXML_clsConfig.LoadXml(objDRC_XML(0).Item("Val"))
                                objXML_Element = objXML_clsConfig.GetElementsByTagName("data")(0)
                                strXML_Initialization_Type = objXML_Element.InnerText
                                objDRC_XML = procA_TokenAttribute_VarcharMAX.GetData_By_GUIDAttribute_And_GUIDToken(objLocalConfig.SemItem_Token_Initialize_RelationType__ConfigItem__XML.GUID, objLocalConfig.SemItem_Attribute_XML_Text.GUID).Rows
                                If objDRC_XML.Count > 0 Then
                                    objXML_clsConfig = New Xml.XmlDocument
                                    objXML_clsConfig.LoadXml(objDRC_XML(0).Item("Val"))
                                    objXML_Element = objXML_clsConfig.GetElementsByTagName("data")(0)
                                    strXML_Initialization_RelationType = objXML_Element.InnerText
                                    strXML_Declaration_List = ""
                                    strXML_Initialization_List = ""
                                    strXML_Property_List = ""

                                    strList_Initialization_Attribute = ""
                                    strList_Initialization_RelationType = ""
                                    strList_Initialization_Token = ""
                                    strList_Initialization_Type = ""

                                    If objDataGridView_Config.SelectedRows.Count = 0 Then
                                        For Each objDGVR_ConfigItem In objDataGridView_Config.Rows
                                            objDRV_ConfigItem = objDGVR_ConfigItem.DataBoundItem
                                            create_XML_ConfigItem(objDRV_ConfigItem)
                                        Next
                                    Else
                                        For Each objDGVR_ConfigItem In objDataGridView_Config.SelectedRows
                                            objDRV_ConfigItem = objDGVR_ConfigItem.DataBoundItem
                                            create_XML_ConfigItem(objDRV_ConfigItem)
                                        Next
                                    End If
                                    strXML_Config = strXML_Config.Replace("@" & objLocalConfig.SemItem_Token_Variable_List_Initialize_ConfigItems_Attributes.Name & "@", strList_Initialization_Attribute)
                                    strXML_Config = strXML_Config.Replace("@" & objLocalConfig.SemItem_Token_Variable_List_Initialize_ConfigItems_RelationTypes.Name & "@", strList_Initialization_RelationType)
                                    strXML_Config = strXML_Config.Replace("@" & objLocalConfig.SemItem_Token_Variable_List_Initialize_ConfigItems_Token.Name & "@", strList_Initialization_Token)
                                    strXML_Config = strXML_Config.Replace("@" & objLocalConfig.SemItem_Token_Variable_List_Initialize_ConfigItems_Types.Name & "@", strList_Initialization_Type)

                                    strXML_Config = strXML_Config.Replace("@" & objLocalConfig.SemItem_Token_Variable_List_Declaration_ConfigItems.Name & "@", strXML_Declaration_List)
                                    strXML_Config = strXML_Config.Replace("@" & objLocalConfig.SemItem_Token_Variable_List_Properties.Name & "@", strXML_Property_List)

                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        TextBox_Code.Text = strXML_Config
    End Sub

    Private Sub create_XML_ConfigItem(ByVal objDRV_ConfigItem)
        strXML_Declaration_List = strXML_Declaration_List & strXML_Declaration.Replace("@Name_ConfigItem@", objDRV_ConfigItem.Item("Name_Token_ConfigItem")) & vbCrLf
        strXML_Property_List = strXML_Property_List & strXML_Property.Replace("@Name_ConfigItem@", objDRV_ConfigItem.Item("Name_Token_ConfigItem")) & vbCrLf & vbCrLf
        Select Case objDRV_ConfigItem.Item("GUID_ItemType_OR")
            Case objLocalConfig.Globals.ObjectReferenceType_Attribute.GUID

                strList_Initialization_Attribute = strList_Initialization_Attribute & strXML_Initialization_Attribute.Replace("@Name_ConfigItem@", objDRV_ConfigItem.Item("Name_Token_ConfigItem")) & vbCrLf & vbCrLf
            Case objLocalConfig.Globals.ObjectReferenceType_RelationType.GUID

                strList_Initialization_RelationType = strList_Initialization_RelationType & strXML_Initialization_RelationType.Replace("@Name_ConfigItem@", objDRV_ConfigItem.Item("Name_Token_ConfigItem")) & vbCrLf & vbCrLf
            Case objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                strList_Initialization_Token = strList_Initialization_Token & strXML_Initialization_Token.Replace("@Name_ConfigItem@", objDRV_ConfigItem.Item("Name_Token_ConfigItem")) & vbCrLf & vbCrLf
            Case objLocalConfig.Globals.ObjectReferenceType_Type.GUID

                strList_Initialization_Type = strList_Initialization_Type & strXML_Initialization_Type.Replace("@Name_ConfigItem@", objDRV_ConfigItem.Item("Name_Token_ConfigItem")) & vbCrLf & vbCrLf

        End Select
    End Sub
    Private Sub set_DBConnection()
        procA_TokenAttribute_VarcharMAX.Connection = objLocalConfig.Connection_DB
    End Sub
End Class