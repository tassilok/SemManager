Imports Sem_Manager
Public Class UserControl_Adress

    Private procA_related_Address_ByGUID_Partner As New ds_AddressTableAdapters.proc_related_Address_ByGUID_PartnerTableAdapter
    Private procA_TokenAttribute_Zusatz_ByGUID_Address As New ds_AddressTableAdapters.proc_TokenAttribute_Zusatz_ByGUID_AddressTableAdapter
    Private procA_TokenAttribute_Strasse_ByGUID_Address As New ds_AddressTableAdapters.proc_TokenAttribute_Strasse_ByGUID_AddressTableAdapter
    Private procA_TokenAttribute_Postfach_ByGUID_Address As New ds_AddressTableAdapters.proc_TokenAttribute_Postfach_ByGUID_AddressTableAdapter

    Private procA_related_Postleitzahl_ByGUID_Address As New ds_AddressTableAdapters.proc_related_Postleitzahl_ByGUID_AddressTableAdapter
    Private procA_related_Ort_ByGUID_Address As New ds_AddressTableAdapters.proc_related_Ort_ByGUID_AddressTableAdapter
    Private procA_related_Land_ByGUID_Ort As New ds_AddressTableAdapters.proc_related_Land_ByGUID_OrtTableAdapter

    Private objDLG_Attribute_VARCHAR255 As dlgAttribute_Varchar255

    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semtbl_Type_Attribute As New ds_SemDBTableAdapters.semtbl_Type_AttributeTableAdapter
    Private semtbl_Type_Type As New ds_SemDBTableAdapters.semtbl_Type_TypeTableAdapter

    Private semprocA_DBWork_Save_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenTableAdapter
    Private semprocA_DBWork_Save_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenRelTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_VARCHAR255 As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_Varchar255TableAdapter
    Private semprocA_DBWork_Del_TokenRel As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenRelTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter

    Private semprocA_DBWork_Del_Token As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenTableAdapter

    Private objDR_Axiom_TokenAttribute_Zusatz As DataRow
    Private objDR_Axiom_TokenAttribute_Strasse As DataRow
    Private objDR_Axiom_TokenAttribute_Postfach As DataRow

    Private objDR_Axiom_TokenRel_Address_Ort As DataRow
    Private objDR_Axiom_TokenRel_Address_Postleitzahl As DataRow
    Private objDR_Axiom_TokenRel_Ort_Land As DataRow

    Private objDR_Axiom_Address As DataRow
    Private procT_Address As New ds_Address.proc_related_Address_ByGUID_PartnerDataTable
    Private objDRC_TokenAttribute_Zusatz As DataRowCollection
    Private objDRC_TokenAttribute_Strasse As DataRowCollection
    Private objDRC_TokenAttribute_Postfach As DataRowCollection
    Private objDRC_TokenRel_Address_PLZ As DataRowCollection
    Private objDRC_TokenRel_Address_Ort As DataRowCollection
    Private objDRC_TokenRel_Ort_Land As DataRowCollection
    Private objSemItem_Partner As clsSemItem
    Private objSemItem_Address As clsSemItem

    Private objFrmPLZOrtLand As frmPLZOrt_Land

    Private intCount_Address_Forw As Integer
    Private intCount_Address_Backw As Integer
    Private intCount_TokenAttribute_Zusatz As Integer
    Private intCount_TokenAttribute_Strasse As Integer
    Private intCount_TokenAttribute_Postfach As Integer
    Private intCount_TokenRel_Address_Ort As Integer
    Private intCount_TokenRel_Address_PLZ As Integer
    Private intCount_TokenRel_Ort_Land As Integer

    Private boolProgChange_Zusatz As Boolean
    Private boolProgChange_Strasse As Boolean
    Private boolProgChange_Postfach As Boolean

    Public Sub New(ByVal SemItem_Related As clsSemItem)
        boolProgChange_Postfach = True
        boolProgChange_Strasse = True
        boolProgChange_Zusatz = True

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        objLocalConfig = New clsLocalConfig(New clsGlobals)
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        If Not SemItem_Related Is Nothing Then
            If SemItem_Related.GUID_Parent = objLocalConfig.SemItem_Type_Address.GUID Then
                objSemItem_Partner = Nothing
                objSemItem_Address = SemItem_Related
            Else
                objSemItem_Partner = SemItem_Related
                objSemItem_Address = Nothing
            End If
        End If
        

        set_DBConnection()
        If Not SemItem_Related Is Nothing Then
            get_Axioms()
            get_AddressData()
            fill_Controls()
        Else
            Me.Enabled = False
        End If


        boolProgChange_Postfach = False
        boolProgChange_Strasse = False
        boolProgChange_Zusatz = False
    End Sub

    Private Sub get_Axioms()
        objDR_Axiom_Address = semtbl_Type_Type.GetData_ByGUIDs(objLocalConfig.SemItem_Type_Partner.GUID, objLocalConfig.SemItem_Type_Address.GUID, objLocalConfig.SemItem_RelationType_Sitz.GUID).Rows(0)
        objDR_Axiom_TokenAttribute_Zusatz = semtbl_Type_Attribute.GetData_ByGUIDs(objLocalConfig.SemItem_Type_Address.GUID, objLocalConfig.SemItem_Attribute_Zusatz.GUID).Rows(0)
        objDR_Axiom_TokenAttribute_Strasse = semtbl_Type_Attribute.GetData_ByGUIDs(objLocalConfig.SemItem_Type_Address.GUID, objLocalConfig.SemItem_Attribute_Straße.GUID).Rows(0)
        objDR_Axiom_TokenAttribute_Postfach = semtbl_Type_Attribute.GetData_ByGUIDs(objLocalConfig.SemItem_Type_Address.GUID, objLocalConfig.SemItem_Attribute_Postfach.GUID).Rows(0)

        objDR_Axiom_TokenRel_Address_Ort = semtbl_Type_Type.GetData_ByGUIDs(objLocalConfig.SemItem_Type_Address.GUID, objLocalConfig.SemItem_Type_Ort.GUID, objLocalConfig.SemItem_RelationType_located_in.GUID).Rows(0)
        objDR_Axiom_TokenRel_Address_Postleitzahl = semtbl_Type_Type.GetData_ByGUIDs(objLocalConfig.SemItem_Type_Address.GUID, objLocalConfig.SemItem_Type_Postleitzahl.GUID, objLocalConfig.SemItem_RelationType_located_in.GUID).Rows(0)
        objDR_Axiom_TokenRel_Ort_Land = semtbl_Type_Type.GetData_ByGUIDs(objLocalConfig.SemItem_Type_Ort.GUID, objLocalConfig.SemItem_Type_Land.GUID, objLocalConfig.SemItem_RelationType_located_in.GUID).Rows(0)

    End Sub

    Private Sub set_DBConnection()
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB


        semtbl_Type_Attribute.Connection = objLocalConfig.Connection_DB
        semtbl_Type_Type.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_VARCHAR255.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_Token.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenRel.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        procA_related_Address_ByGUID_Partner.Connection = objLocalConfig.Connection_Plugin
        procA_TokenAttribute_Zusatz_ByGUID_Address.Connection = objLocalConfig.Connection_Plugin
        procA_TokenAttribute_Strasse_ByGUID_Address.Connection = objLocalConfig.Connection_Plugin
        procA_TokenAttribute_Postfach_ByGUID_Address.Connection = objLocalConfig.Connection_Plugin

        procA_related_Postleitzahl_ByGUID_Address.Connection = objLocalConfig.Connection_Plugin
        procA_related_Ort_ByGUID_Address.Connection = objLocalConfig.Connection_Plugin
        procA_related_Land_ByGUID_Ort.Connection = objLocalConfig.Connection_Plugin
    End Sub
    Private Sub set_Axioms()

        ToolStripLabel_AxiomAddresses.Text = objDR_Axiom_Address.Item("Min_forw") & "/" & procT_Address.Rows.Count & "/" & objDR_Axiom_Address.Item("Max_Forw")
        If test_Axiom_Rel_Forw(objDR_Axiom_Address.Item("Min_forw"), objDR_Axiom_Address.Item("Max_Forw"), procT_Address.Rows.Count) = True Then
            ToolStripLabel_AxiomAddresses.ForeColor = Nothing
        Else
            ToolStripLabel_AxiomAddresses.ForeColor = Color.SandyBrown
        End If
        If test_Axiom_Attribute(objDR_Axiom_TokenAttribute_Zusatz.Item("Min"), objDR_Axiom_TokenAttribute_Zusatz.Item("Max"), intCount_TokenAttribute_Zusatz) = False Then
            Label_Zusatz.ForeColor = Color.SandyBrown
        Else
            Label_Zusatz.ForeColor = Color.Black
        End If
        If test_Axiom_Attribute(objDR_Axiom_TokenAttribute_Strasse.Item("Min"), objDR_Axiom_TokenAttribute_Strasse.Item("Max"), intCount_TokenAttribute_Strasse) = False Then
            Label_Strasse.ForeColor = Color.SandyBrown
        Else
            Label_Strasse.ForeColor = Color.Black
        End If
        If test_Axiom_Attribute(objDR_Axiom_TokenAttribute_Postfach.Item("Min"), objDR_Axiom_TokenAttribute_Postfach.Item("Max"), intCount_TokenAttribute_Postfach) = False Then
            Label_Strasse.ForeColor = Color.SandyBrown
        Else
            Label_Strasse.ForeColor = Color.Black
        End If
        Label_PlzOrtLand.ForeColor = Color.Black
        If test_Axiom_Rel_Forw(objDR_Axiom_TokenRel_Address_Ort.Item("Min_forw"), objDR_Axiom_TokenRel_Address_Ort.Item("Max_Forw"), intCount_TokenRel_Address_Ort) = False Then
            Label_PlzOrtLand.ForeColor = Color.SandyBrown
        End If
        If test_Axiom_Rel_Forw(objDR_Axiom_TokenRel_Address_Postleitzahl.Item("Min_forw"), objDR_Axiom_TokenRel_Address_Postleitzahl.Item("Max_Forw"), intCount_TokenRel_Address_PLZ) = False Then
            Label_PlzOrtLand.ForeColor = Color.SandyBrown
        End If
        If test_Axiom_Rel_Forw(objDR_Axiom_TokenRel_Ort_Land.Item("Min_forw"), objDR_Axiom_TokenRel_Ort_Land.Item("Max_Forw"), intCount_TokenRel_Ort_Land) = False Then
            Label_PlzOrtLand.ForeColor = Color.SandyBrown
        End If
    End Sub
    Private Sub fill_Controls()
        Dim objDR_Adress As DataRow
        Dim boolEnable_DelPLZOrtLand As Boolean = False


        ToolStripButton_Apply.Enabled = objLocalConfig.Applyable
        
        boolProgChange_Zusatz = True
        TextBox_Zusatz.Text = ""
        boolProgChange_Zusatz = False
        TextBox_PLZOrtLand.Text = ""
        boolProgChange_Strasse = True
        TextBox_Strasse.Text = ""
        boolProgChange_Strasse = False
        boolProgChange_Postfach = True
        MaskedTextBox_Postfach.Text = ""
        boolProgChange_Postfach = False



        If intCount_TokenAttribute_Zusatz > 0 Then
            boolProgChange_Zusatz = True
            TextBox_Zusatz.Text = objDRC_TokenAttribute_Zusatz(0).Item("Zusatz")
            boolProgChange_Zusatz = False
        End If

        If intCount_TokenAttribute_Strasse > 0 Then
            boolProgChange_Strasse = True
            TextBox_Strasse.Text = objDRC_TokenAttribute_Strasse(0).Item("Strasse")
            boolProgChange_Strasse = False
        End If
        If intCount_TokenAttribute_Postfach > 0 Then
            boolProgChange_Postfach = True
            MaskedTextBox_Postfach.Text = objDRC_TokenAttribute_Postfach(0).Item("Postfach")
            boolProgChange_Postfach = False
        End If

        If intCount_TokenRel_Address_PLZ > 0 Then
            boolEnable_DelPLZOrtLand = True
            TextBox_PLZOrtLand.Text = objDRC_TokenRel_Address_PLZ(0).Item("Name_Postleitzahl")
        End If
        If intCount_TokenRel_Address_Ort > 0 Then
            boolEnable_DelPLZOrtLand = True
            If Not TextBox_PLZOrtLand.Text = "" Then
                TextBox_PLZOrtLand.Text = TextBox_PLZOrtLand.Text & " "


            End If
            TextBox_PLZOrtLand.Text = TextBox_PLZOrtLand.Text & objDRC_TokenRel_Address_Ort(0).Item("Name_Ort")
        End If
        If intCount_TokenRel_Ort_Land > 0 Then
            boolEnable_DelPLZOrtLand = True
            If Not TextBox_PLZOrtLand.Text = "" Then
                TextBox_PLZOrtLand.Text = TextBox_PLZOrtLand.Text & vbCrLf
            End If
            TextBox_PLZOrtLand.Text = TextBox_PLZOrtLand.Text & objDRC_TokenRel_Ort_Land(0).Item("Name_Land")
        End If
        Button_DelPLZOrtLand.Enabled = boolEnable_DelPLZOrtLand
        set_Axioms()

    End Sub
    Private Sub get_AddressData()

        get_Data_Address()
        get_Data_Strasse()
        get_Data_Zusatz()
        get_Data_Postfach()
        get_Data_PLZ()
        get_Data_Ort()
        get_Data_Land()
        del_Adresse_if_possible()
    End Sub
    Private Sub get_Data_Address()
        If objSemItem_Address Is Nothing Then
            procA_related_Address_ByGUID_Partner.Fill(procT_Address, objLocalConfig.SemItem_Type_Address.GUID, objLocalConfig.SemItem_RelationType_Sitz.GUID, objSemItem_Partner.GUID)
        Else
            procT_Address.Clear()
            procT_Address.Rows.Add(objSemItem_Address.GUID, _
                                   objSemItem_Address.Name, _
                                   objSemItem_Address.GUID_Parent)
        End If

        intCount_Address_Forw = procT_Address.Count
    End Sub
    Private Sub get_Data_Zusatz()
        intCount_TokenAttribute_Zusatz = 0
        If procT_Address.Rows.Count > 0 Then
            objDRC_TokenAttribute_Zusatz = procA_TokenAttribute_Zusatz_ByGUID_Address.GetData(objLocalConfig.SemItem_Attribute_Zusatz.GUID, procT_Address.Rows(0).Item("GUID_Address")).Rows
            intCount_TokenAttribute_Zusatz = objDRC_TokenAttribute_Zusatz.Count
        End If

    End Sub
    Private Sub get_Data_Strasse()
        intCount_TokenAttribute_Strasse = 0
        If procT_Address.Rows.Count > 0 Then
            objDRC_TokenAttribute_Strasse = procA_TokenAttribute_Strasse_ByGUID_Address.GetData(objLocalConfig.SemItem_Attribute_Straße.GUID, procT_Address.Rows(0).Item("GUID_Address")).Rows
            intCount_TokenAttribute_Strasse = objDRC_TokenAttribute_Strasse.Count
        End If

    End Sub
    Private Sub get_Data_Postfach()
        intCount_TokenAttribute_Postfach = 0
        If procT_Address.Rows.Count > 0 Then
            objDRC_TokenAttribute_Postfach = procA_TokenAttribute_Postfach_ByGUID_Address.GetData(objLocalConfig.SemItem_Attribute_Postfach.GUID, procT_Address.Rows(0).Item("GUID_Address")).Rows
            intCount_TokenAttribute_Postfach = objDRC_TokenAttribute_Postfach.Count
        End If
    End Sub
    Private Sub get_Data_Ort()
        intCount_TokenRel_Address_Ort = 0
        If procT_Address.Rows.Count > 0 Then
            objDRC_TokenRel_Address_Ort = procA_related_Ort_ByGUID_Address.GetData(objLocalConfig.SemItem_Type_Ort.GUID, objLocalConfig.SemItem_RelationType_located_in.GUID, procT_Address.Rows(0).Item("GUID_Address")).Rows
            intCount_TokenRel_Address_Ort = objDRC_TokenRel_Address_Ort.Count
        End If
    End Sub
    Private Sub get_Data_PLZ()
        intCount_TokenRel_Address_PLZ = 0
        If procT_Address.Rows.Count > 0 Then

            objDRC_TokenRel_Address_PLZ = procA_related_Postleitzahl_ByGUID_Address.GetData(objLocalConfig.SemItem_Type_Postleitzahl.GUID, objLocalConfig.SemItem_RelationType_located_in.GUID, procT_Address.Rows(0).Item("GUID_Address")).Rows
            intCount_TokenRel_Address_PLZ = objDRC_TokenRel_Address_PLZ.Count
        End If
    End Sub
    Private Sub get_Data_Land()
        intCount_TokenRel_Ort_Land = 0
        If procT_Address.Rows.Count > 0 Then


            If objDRC_TokenRel_Address_Ort.Count > 0 Then
                objDRC_TokenRel_Ort_Land = procA_related_Land_ByGUID_Ort.GetData(objLocalConfig.SemItem_Type_Land.GUID, objLocalConfig.SemItem_RelationType_located_in.GUID, objDRC_TokenRel_Address_Ort(0).Item("GUID_Ort")).Rows
                intCount_TokenRel_Ort_Land = objDRC_TokenRel_Ort_Land.Count
            End If

        End If
    End Sub
    Private Function test_Axiom_Rel_Forw(ByVal intMin_TypeRel As Integer, ByVal intMax_TypeRelForw As Integer, ByVal intCount_TokenRel As Integer) As Boolean
        Dim boolResult As Boolean

        If intCount_TokenRel >= intMin_TypeRel And (intCount_TokenRel <= intMax_TypeRelForw Or intMax_TypeRelForw = -1) Then
            boolResult = True
        Else
            boolResult = False
        End If
        Return boolResult
    End Function

    Private Function test_Axiom_Rel_Backw(ByVal intMax_TypeRelBack As Integer, ByVal intCount_TokenRelBackw As Integer) As Boolean
        Dim boolResult As Boolean

        If intCount_TokenRelBackw <= intMax_TypeRelBack Or intMax_TypeRelBack = -1 Then
            boolResult = True
        Else
            boolResult = False
        End If
        Return boolResult
    End Function

    Private Function test_Axiom_Attribute(ByVal intMin_TypeAttribute As Integer, ByVal intMax_TypeAttribute As Integer, ByVal intCount_TokenAttribute As Integer) As Boolean
        Dim boolResult As Boolean

        If intCount_TokenAttribute >= intMin_TypeAttribute And (intCount_TokenAttribute <= intMax_TypeAttribute Or intMax_TypeAttribute = -1) Then
            boolResult = True
        Else
            boolResult = False
        End If
        Return boolResult
    End Function

    Private Sub TextBox_Zusatz_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Zusatz.DoubleClick
        objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Attribute_Zusatz.Name, objLocalConfig.Globals, TextBox_Zusatz.Text)
        objDLG_Attribute_VARCHAR255.ShowDialog(Me)
        If objDLG_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
            TextBox_Zusatz.Text = objDLG_Attribute_VARCHAR255.Value1
        End If
    End Sub
    Private Sub TextBox_Zusatz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Zusatz.TextChanged
        If boolProgChange_Zusatz = False Then
            Timer_Zusatz.Stop()
            Timer_Zusatz.Start()
        End If

    End Sub


    Private Sub Timer_Zusatz_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Zusatz.Tick
        Dim strZusatz As String
        Dim GUID_Token_Address As Guid
        Dim objDRC_LogState As DataRowCollection

        strZusatz = TextBox_Zusatz.Text
        get_Data_Zusatz()
        If intCount_TokenAttribute_Zusatz > 0 Then
            If strZusatz <> objDRC_TokenAttribute_Zusatz(0).Item("Zusatz") Then
                If Not strZusatz = "" Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(procT_Address.Rows(0).Item("GUID_Address"), objLocalConfig.SemItem_Attribute_Zusatz.GUID, objDRC_TokenAttribute_Zusatz(0).Item("GUID_Token_Attribute_Zusatz"), strZusatz, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                        del_Adresse_if_possible()
                    Else
                        boolProgChange_Zusatz = True
                        TextBox_Zusatz.Text = objDRC_TokenAttribute_Zusatz(0).Item("Zusatz")
                        boolProgChange_Zusatz = False
                    End If
                Else
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_TokenAttribute_Zusatz(0).Item("GUID_Token_Attribute_Zusatz")).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                        MsgBox("Der Adresszusatz konnte nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                    End If
                    get_AddressData()
                    fill_Controls()
                End If
                
            End If
            
        Else

            If intCount_Address_Forw = 0 Then
                GUID_Token_Address = create_Address()

            Else
                GUID_Token_Address = procT_Address.Rows(0).Item("GUID_Address")

            End If


            If Not GUID_Token_Address = Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(GUID_Token_Address, objLocalConfig.SemItem_Attribute_Zusatz.GUID, Nothing, strZusatz, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    get_AddressData()
                Else
                    semprocA_DBWork_Del_Token.GetData(GUID_Token_Address)
                    boolProgChange_Zusatz = True
                    TextBox_Zusatz.Clear()
                    MsgBox("Die Adresse konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    boolProgChange_Zusatz = False
                End If
            Else

                boolProgChange_Zusatz = True
                TextBox_Zusatz.Clear()
                MsgBox("Die Adresse konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                boolProgChange_Zusatz = False

            End If
        End If
        Timer_Zusatz.Stop()
    End Sub

    Private Sub del_Adresse_if_possible()
        Dim objDRC_LogState As DataRowCollection
        Dim boolDel As Boolean = True

        If intCount_Address_Forw > 0 Then
            If intCount_TokenAttribute_Postfach > 0 Then
                boolDel = False
            End If
            If intCount_TokenAttribute_Strasse > 0 Then
                boolDel = False
            End If
            If intCount_TokenAttribute_Zusatz > 0 Then
                boolDel = False
            End If
            If intCount_TokenRel_Address_Ort > 0 Then
                boolDel = False
            End If
            If intCount_TokenRel_Address_PLZ > 0 Then
                boolDel = False
            End If
        Else
            boolDel = False
        End If
        If boolDel = True Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(objSemItem_Partner.GUID, procT_Address.Rows(0).Item("GUID_Address"), objLocalConfig.SemItem_RelationType_Sitz.GUID).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                objDRC_LogState = semprocA_DBWork_Del_Token.GetData(procT_Address.Rows(0).Item("GUID_Address")).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    MsgBox("Die Adresse kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Die Adresse kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    Private Function create_Address() As Guid
        Dim objDRC_LogState As DataRowCollection
        Dim GUID_Token_Address As Guid
        GUID_Token_Address = Guid.NewGuid
        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(GUID_Token_Address, objSemItem_Partner.Name, objLocalConfig.SemItem_Type_Address.GUID, True).Rows
        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(objSemItem_Partner.GUID, GUID_Token_Address, objLocalConfig.SemItem_RelationType_Sitz.GUID, 0).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                MsgBox("Die Adresse kann nicht erzeugt werden!", MsgBoxStyle.Exclamation)
                GUID_Token_Address = Nothing
            End If
        Else
            MsgBox("Die Adresse kann nicht erzeugt werden!", MsgBoxStyle.Exclamation)
            GUID_Token_Address = Nothing
        End If
        Return GUID_Token_Address
    End Function

    Private Sub TextBox_Strasse_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Strasse.DoubleClick
        objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_Attribute_Straße.Name, objLocalConfig.Globals, TextBox_Strasse.Name)
        objDLG_Attribute_VARCHAR255.ShowDialog(Me)
        If objDLG_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
            TextBox_Strasse.Text = objDLG_Attribute_VARCHAR255.Value1
        End If
    End Sub
    Private Sub TextBox_Strasse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Strasse.TextChanged
        If boolProgChange_Strasse = False Then
            Timer_Strasse.Stop()
            Timer_Strasse.Start()
        End If
    End Sub

    Private Sub Timer_Strasse_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Strasse.Tick
        Dim strStrasse As String
        Dim GUID_Token_Address As Guid
        Dim objDRC_LogState As DataRowCollection

        Timer_Strasse.Stop()
        strStrasse = TextBox_Strasse.Text
        get_Data_Strasse()
        If intCount_TokenAttribute_Strasse > 0 Then
            If strStrasse <> objDRC_TokenAttribute_Strasse(0).Item("Strasse") Then
                If Not strStrasse = "" Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(procT_Address.Rows(0).Item("GUID_Address"), objLocalConfig.SemItem_Attribute_Straße.GUID, objDRC_TokenAttribute_Strasse(0).Item("GUID_Token_Attribute_Strasse"), strStrasse, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        boolProgChange_Strasse = True
                        TextBox_Strasse.Text = objDRC_TokenAttribute_Strasse(0).Item("Strasse")
                        boolProgChange_Strasse = False
                    Else
                        del_Adresse_if_possible()
                    End If
                Else
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_TokenAttribute_Strasse(0).Item("GUID_Token_Attribute_Strasse")).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                        MsgBox("Die Strasse konnte nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                        get_Data_Strasse()
                        fill_Controls()
                    End If
                End If
                
            End If

        Else

            If intCount_Address_Forw = 0 Then
                GUID_Token_Address = create_Address()

            Else
                GUID_Token_Address = procT_Address.Rows(0).Item("GUID_Address")

            End If


            If Not GUID_Token_Address = Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(GUID_Token_Address, objLocalConfig.SemItem_Attribute_Straße.GUID, Nothing, strStrasse, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    get_AddressData()
                Else
                    semprocA_DBWork_Del_Token.GetData(GUID_Token_Address)
                    boolProgChange_Strasse = True
                    TextBox_Strasse.Clear()
                    MsgBox("Die Adresse konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    boolProgChange_Strasse = False
                    get_Data_Strasse()
                    fill_Controls()
                End If
            Else

                boolProgChange_Strasse = True
                TextBox_Strasse.Clear()
                MsgBox("Die Adresse konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                boolProgChange_Strasse = False
                get_Data_Strasse()
                fill_Controls()
            End If
        End If

    End Sub

    Private Sub MaskedTextBox_Postfach_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox_Postfach.DoubleClick
        objDLG_Attribute_VARCHAR255 = New dlgAttribute_Varchar255(objLocalConfig.SemItem_attribute_dbPostfix.Name, objLocalConfig.Globals, MaskedTextBox_Postfach.Text)
        objDLG_Attribute_VARCHAR255.ShowDialog(Me)
        If objDLG_Attribute_VARCHAR255.DialogResult = DialogResult.OK Then
            MaskedTextBox_Postfach.Text = objDLG_Attribute_VARCHAR255.Value1
        End If
    End Sub

    

    

    Private Sub MaskedTextBox_Postfach_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox_Postfach.TextChanged
        If boolProgChange_Postfach = False Then
            Timer_Postfach.Stop()
            Timer_Postfach.Start()
        End If
    End Sub

    Private Sub Timer_Postfach_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Postfach.Tick
        Dim strPostfach As String
        Dim strPostfach_tmp As String
        Dim GUID_Token_Address As Guid
        Dim objDRC_LogState As DataRowCollection

        strPostfach = MaskedTextBox_Postfach.Text
        strPostfach_tmp = ""
        For i = 0 To strPostfach.Length - 1
            Select Case strPostfach.Substring(i, 1)
                Case "0" To "9"
                    strPostfach_tmp = strPostfach_tmp & strPostfach.Substring(i, 1)
            End Select
        Next
        strPostfach = strPostfach_tmp
        get_Data_Postfach()
        If intCount_TokenAttribute_Postfach > 0 Then
            If strPostfach <> objDRC_TokenAttribute_Postfach(0).Item("Postfach") Then
                If Not strPostfach = "" Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(procT_Address.Rows(0).Item("GUID_Address"), objLocalConfig.SemItem_Attribute_Straße.GUID, objDRC_TokenAttribute_Postfach(0).Item("GUID_Token_Attribute_Postfach"), strPostfach, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Update.GUID Then
                        del_Adresse_if_possible()
                    Else
                        boolProgChange_Postfach = True
                        MaskedTextBox_Postfach.Text = objDRC_TokenAttribute_Postfach(0).Item("Postfache")
                        boolProgChange_Postfach = False
                    End If
                Else
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_TokenAttribute_Postfach(0).Item("GUID_Token_Attribute_Postfach")).Rows
                    If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                        MsgBox("Das Postfach kann nicht gelöscht werden!", MsgBoxStyle.Exclamation)
                        
                    End If
                    get_AddressData()
                    fill_Controls()
                End If
                
            End If

        Else

            If intCount_Address_Forw = 0 Then
                GUID_Token_Address = create_Address()
                

            Else
                GUID_Token_Address = procT_Address.Rows(0).Item("GUID_Address")

            End If


            If Not GUID_Token_Address = Nothing Then
                objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_VARCHAR255.GetData(GUID_Token_Address, objLocalConfig.SemItem_Attribute_Postfach.GUID, Nothing, strPostfach, 0).Rows
                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                    get_AddressData()
                Else
                    semprocA_DBWork_Del_Token.GetData(GUID_Token_Address)
                    boolProgChange_Postfach = True
                    MaskedTextBox_Postfach.Clear()
                    MsgBox("Die Adresse konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                    boolProgChange_Postfach = False
                End If
            Else

                boolProgChange_Postfach = True
                MaskedTextBox_Postfach.Clear()
                MsgBox("Die Adresse konnte nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                boolProgChange_Postfach = False

            End If
        End If
        Timer_Postfach.Stop()
    End Sub

    Private Sub MaskedTextBox_Postfach_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox_Postfach.MaskInputRejected

    End Sub

    Private Sub Button_addPLZOrtLand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_addPLZOrtLand.Click
        Dim objSemItem_PLZ As clsSemItem
        Dim objSemItem_Ort As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim boolSave As Boolean
        objFrmPLZOrtLand = New frmPLZOrt_Land(objDRC_TokenRel_Address_PLZ, objDRC_TokenRel_Address_Ort, objDRC_TokenRel_Ort_Land)
        objFrmPLZOrtLand.ShowDialog()
        If objFrmPLZOrtLand.DialogResult = DialogResult.OK Then
            objSemItem_Ort = objFrmPLZOrtLand.SemItem_Ort_Sel
            objSemItem_PLZ = objFrmPLZOrtLand.SemItem_PLZ_Sel
            If Not objSemItem_Ort Is Nothing And Not objSemItem_PLZ Is Nothing Then
                get_Data_Address()
                get_Data_Ort()
                get_Data_PLZ()
                If intCount_Address_Forw = 0 Then
                    If Not create_Address() = Nothing Then
                        get_Data_Address()
                        boolSave = True
                    Else
                        boolSave = False
                    End If
                    
                Else
                    boolSave = True
                End If
                If boolSave = True Then
                    If intCount_TokenRel_Address_Ort = 0 Then
                        objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(procT_Address.Rows(0).Item("GUID_Address"), objSemItem_Ort.GUID, objLocalConfig.SemItem_RelationType_located_in.GUID, 0).Rows
                        If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                            get_Data_Ort()
                        Else
                            MsgBox("Die Adresse kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                            boolSave = False
                        End If
                    Else
                        If Not objDRC_TokenRel_Address_Ort(0).Item("GUID_Ort") = objSemItem_Ort.GUID Then
                            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(procT_Address.Rows(0).Item("GUID_Address"), objDRC_TokenRel_Address_Ort(0).Item("GUID_Ort"), objLocalConfig.SemItem_RelationType_located_in.GUID).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(procT_Address.Rows(0).Item("GUID_Address"), objSemItem_Ort.GUID, objLocalConfig.SemItem_RelationType_located_in.GUID, 0).Rows
                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                    get_Data_Ort()
                                Else
                                    MsgBox("Die Adresse kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                    boolSave = False
                                End If
                            Else

                                MsgBox("Die Adresse kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                boolSave = False
                            End If
                        End If
                    End If
                    If boolSave = True Then
                        If intCount_TokenRel_Address_PLZ = 0 Then
                            objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(procT_Address.Rows(0).Item("GUID_Address"), objSemItem_PLZ.GUID, objLocalConfig.SemItem_RelationType_located_in.GUID, 0).Rows
                            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                get_Data_PLZ()
                            Else
                                MsgBox("Die Adresse kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                boolSave = False
                            End If
                        Else
                            If Not objDRC_TokenRel_Address_PLZ(0).Item("GUID_Ort") = objSemItem_PLZ.GUID Then
                                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(procT_Address.Rows(0).Item("GUID_Address"), objDRC_TokenRel_Address_PLZ(0).Item("GUID_Postleitzahl"), objLocalConfig.SemItem_RelationType_located_in.GUID).Rows
                                If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                                    objDRC_LogState = semprocA_DBWork_Save_TokenRel.GetData(procT_Address.Rows(0).Item("GUID_Address"), objSemItem_PLZ.GUID, objLocalConfig.SemItem_RelationType_located_in.GUID, 0).Rows
                                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Insert.GUID Then
                                        get_Data_PLZ()
                                    Else
                                        MsgBox("Die Adresse kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                        boolSave = False
                                    End If
                                Else

                                    MsgBox("Die Adresse kann nicht gespeichert werden!", MsgBoxStyle.Exclamation)
                                    boolSave = False
                                End If
                            End If
                        End If
                    End If
                    
                End If
                
            End If
        End If
        get_Data_Land()
        fill_Controls()
        get_Axioms()
        set_Axioms()

    End Sub

    Private Sub Button_DelPLZOrtLand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DelPLZOrtLand.Click
        Dim objDRC_LogState As DataRowCollection
        Dim boolDel As Boolean
        get_Data_PLZ()
        get_Data_Ort()
        get_Data_Land()

        boolDel = True
        If intCount_TokenRel_Address_PLZ > 0 Then
            objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(procT_Address.Rows(0).Item("GUID_Address"), objDRC_TokenRel_Address_PLZ(0).Item("GUID_Postleitzahl"), objLocalConfig.SemItem_RelationType_located_in.GUID).Rows
            If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                MsgBox("Die Postleitzahl konnte nicht entfernt werden!", MsgBoxStyle.Exclamation)
                boolDel = False
            End If
        End If

        If boolDel = True Then
            If intCount_TokenRel_Address_Ort > 0 Then
                objDRC_LogState = semprocA_DBWork_Del_TokenRel.GetData(procT_Address.Rows(0).Item("GUID_Address"), objDRC_TokenRel_Address_Ort(0).Item("GUID_Ort"), objLocalConfig.SemItem_RelationType_located_in.GUID).Rows
                If Not objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Delete.GUID Then
                    MsgBox("Der Ort konnte nicht entfernt werden!", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
        get_AddressData()
        fill_Controls()
    End Sub
End Class
