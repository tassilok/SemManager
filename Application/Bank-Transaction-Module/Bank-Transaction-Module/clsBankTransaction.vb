Imports Sem_Manager
Imports Filesystem_Management
Imports Log_Manager
Public Class clsBankTransaction

    Private objLocalConfig As clsLocalConfig

    Private objFileWork As clsFileWork

    Private objTransaction_BankTransaction As clsTransaction_BankTransaction
    Private objTransaction_ImportLog As clsTransaction_ImportLog

    Private objTextReader As IO.StreamReader

    Private objSemItem_Partner As clsSemItem
    Private objSemItem_Konto As clsSemItem
    Private objSemItem_ImportSetting As clsSemItem
    Private objSemItem_ImportFile As New clsSemItem
    Private objSemItem_Result_Config As clsSemItem
    Private objSemItem_TextQualifier As clsSemItem
    Private objSemItem_TextSeperator As clsSemItem
    Private objSemItem_Type_BelongingBank As clsSemItem
    Private objSemItem_ImportLog As clsSemItem
    Private objSemItem_LogEntry As clsSemItem
    Private dateStart As Date

    Private objLogManagement As clsLogManagement

    Private objDRC_Attributes As DataRowCollection
    Private objDRC_Types As DataRowCollection

    Private boolFirstColHeader As Boolean

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private funcA_Token_Token As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private funcA_Token_Or As New ds_ObjectReferenceTableAdapters.func_Token_ORTableAdapter
    Private typefuncA_Types_With_Attributes_And_Types As New ds_TypeTableAdapters.typefunc_Types_With_Attributes_And_TypesTableAdapter
    Private typefuncT_Types_With_Attributes_And_Types As New ds_Type.typefunc_Types_With_Attributes_And_TypesDataTable
    Private typefuncA_Types_Rel As New ds_TypeTableAdapters.typefunc_Types_RelTableAdapter
    Private typefuncT_Types_Rel As New ds_Type.typefunc_Types_RelDataTable
    Private fA_Sparkasse_BankTransaktionen As New ds_BankTransactionModuleTableAdapters.f_Sparkasse_BankTransaktionenTableAdapter
    Private fT_Sparkasse_BankTransaktionen_Import As New ds_BankTransactionModule.f_Sparkasse_BankTransaktionenDataTable
    Private pA_Currency_By_Name As New ds_BankTransactionModuleTableAdapters.p_Currency_By_NameTableAdapter
    Private pA_Konto_By_KTO_And_BLZ As New ds_BankTransactionModuleTableAdapters.p_Konto_By_KTO_And_BLZTableAdapter
    Private pA_ImportSettings_of_Partner As New ds_BankTransactionModuleTableAdapters.p_ImportSettings_of_PartnerTableAdapter

    Public Sub New(ByVal LocalConfig As clsLocalConfig, ByVal SemItem_Partner As clsSemItem)

        objSemItem_Partner = SemItem_Partner

        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Private Function get_importSettings() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_ImportSettings As DataRowCollection

        objDRC_ImportSettings = pA_ImportSettings_of_Partner.GetData(objLocalConfig.SemItem_Type_Kontodaten.GUID, _
                                                                     objLocalConfig.SemItem_Type_Kontonummer.GUID, _
                                                                     objLocalConfig.SemItem_Type_Bankleitzahl.GUID, _
                                                                     objLocalConfig.SemItem_Type_Import_Settings.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_provides.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                                                     objLocalConfig.SemItem_RelationType_belonging_Banks.GUID, _
                                                                     objSemItem_Partner.GUID).Rows
        If objDRC_ImportSettings.Count > 0 Then
            objSemItem_ImportSetting = New clsSemItem
            objSemItem_ImportSetting.GUID = objDRC_ImportSettings(0).Item("GUID_Import_Settings")
            objSemItem_ImportSetting.Name = objDRC_ImportSettings(0).Item("Name_Import_Settings")
            objSemItem_ImportSetting.GUID_Parent = objLocalConfig.SemItem_Type_Import_Settings.GUID
            objSemItem_ImportSetting.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_Konto = New clsSemItem
            objSemItem_Konto.GUID = objDRC_ImportSettings(0).Item("GUID_Bankkonto")
            objSemItem_Konto.Name = objDRC_ImportSettings(0).Item("Name_Bankkonto")
            objSemItem_Konto.GUID_Parent = objLocalConfig.SemItem_Type_Kontonummer.GUID
            objSemItem_Konto.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID


            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Private Sub initialize()
        Dim objDRC_FirstColHeader As DataRowCollection
        Dim objDRC_ImportFile As DataRowCollection
        Dim objDRC_TextSeperator As DataRowCollection
        Dim objDRC_TextQualifier As DataRowCollection
        Dim objDRC_belongingBank As DataRowCollection

        set_DBConnection()
        objSemItem_Result_Config = get_importSettings()

        If objSemItem_Result_Config.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objDRC_FirstColHeader = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_ImportSetting.GUID, _
                                                                                                               objLocalConfig.SemItem_Attribute_First_Line_Col_Header.GUID).Rows
            If objDRC_FirstColHeader.Count > 0 Then
                boolFirstColHeader = objDRC_FirstColHeader(0).Item("Val_BOOL")
            Else
                boolFirstColHeader = False
            End If

            If boolFirstColHeader = False Then
                objSemItem_Result_Config = objLocalConfig.SemItem_Token_Logstate_Config_Error
            End If

            objDRC_ImportFile = funcA_Token_Token.GetData_LeftRight_Ordered_By_GUIDs(objSemItem_ImportSetting.GUID, _
                                                                                    objLocalConfig.SemItem_Type_File.GUID, _
                                                                               objLocalConfig.SemItem_RelationType_imports_from.GUID, _
                                                                               1).Rows
            If objDRC_ImportFile.Count > 0 Then
                objSemItem_ImportFile.GUID = objDRC_ImportFile(0).Item("GUID_Token_Right")
                objSemItem_ImportFile.Name = objDRC_ImportFile(0).Item("Name_Token_Right")
                objSemItem_ImportFile.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                objSemItem_ImportFile.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID
                objSemItem_ImportFile.Additional1 = objFileWork.get_Path_FileSystemObject(objSemItem_ImportFile, False)

                If Not IO.File.Exists(objSemItem_ImportFile.Additional1) Then
                    objSemItem_Result_Config = objLocalConfig.SemItem_Token_Logstate_Config_Error
                End If
            Else
                objSemItem_Result_Config = objLocalConfig.SemItem_Token_Logstate_Config_Error
            End If

            objDRC_TextSeperator = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_ImportSetting.GUID, _
                                                                                  objLocalConfig.SemItem_RelationType_works_with.GUID, _
                                                                                  objLocalConfig.SemItem_Type_Text_Seperators.GUID).Rows
            If objDRC_TextSeperator.Count > 0 Then
                objSemItem_TextSeperator = New clsSemItem
                objSemItem_TextSeperator.GUID = objDRC_TextSeperator(0).Item("GUID_Token_Right")
                objSemItem_TextSeperator.Name = objDRC_TextSeperator(0).Item("Name_Token_Right")
                objSemItem_TextSeperator.GUID_Parent = objLocalConfig.SemItem_Type_Text_Seperators.GUID
                objSemItem_TextSeperator.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Else
                objSemItem_TextSeperator = Nothing
            End If

            objDRC_TextQualifier = funcA_Token_Token.GetData_TokenToken_LeftRight(objSemItem_ImportSetting.GUID, _
                                                                                  objLocalConfig.SemItem_RelationType_works_with.GUID, _
                                                                                  objLocalConfig.SemItem_Type_Text_Qualifier.GUID).Rows
            If objDRC_TextQualifier.Count > 0 Then
                objSemItem_TextQualifier = New clsSemItem
                objSemItem_TextQualifier.GUID = objDRC_TextQualifier(0).Item("GUID_Token_Right")
                objSemItem_TextQualifier.Name = objDRC_TextQualifier(0).Item("Name_Token_Right")
                objSemItem_TextQualifier.GUID_Parent = objLocalConfig.SemItem_Type_Text_Qualifier.GUID
                objSemItem_TextQualifier.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            Else
                objSemItem_TextQualifier = Nothing
            End If

            objDRC_belongingBank = funcA_Token_Or.GetData_By_GUIDTokenLeft_And_GUIDRelationType(objSemItem_ImportSetting.GUID, _
                                                                                                objLocalConfig.SemItem_RelationType_belonging_Banks.GUID).Rows
            If objDRC_belongingBank.Count > 0 Then
                objSemItem_Type_BelongingBank = New clsSemItem
                objSemItem_Type_BelongingBank.GUID = objDRC_belongingBank(0).Item("GUID_Ref")
                objSemItem_Type_BelongingBank.Name = objDRC_belongingBank(0).Item("Name_Ref")
                objSemItem_Type_BelongingBank.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Type.GUID

            Else
                objSemItem_Result_Config = objLocalConfig.SemItem_Token_Logstate_Config_Error
            End If

            get_BankTransactions()
            import_Transactions()
        Else
            MsgBox("Config-Error!", MsgBoxStyle.Exclamation)
        End If

        
    End Sub

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        funcA_Token_Token.Connection = objLocalConfig.Connection_DB
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB
        funcA_Token_Or.Connection = objLocalConfig.Connection_DB
        typefuncA_Types_With_Attributes_And_Types.Connection = objLocalConfig.Connection_DB
        typefuncA_Types_Rel.Connection = objLocalConfig.Connection_DB

        fA_Sparkasse_BankTransaktionen.Connection = objLocalConfig.Connection_Plugin
        pA_Currency_By_Name.Connection = objLocalConfig.Connection_Plugin
        pA_Konto_By_KTO_And_BLZ.Connection = objLocalConfig.Connection_Plugin
        pA_ImportSettings_of_Partner.Connection = objLocalConfig.Connection_Plugin

        objFileWork = New clsFileWork(objLocalConfig.Globals)
        objTransaction_BankTransaction = New clsTransaction_BankTransaction(objLocalConfig)
        objTransaction_ImportLog = New clsTransaction_ImportLog(objLocalConfig)
        objLogManagement = New clsLogManagement(objLocalConfig.Globals)

    End Sub

    Private Sub get_BankTransactions()
        fA_Sparkasse_BankTransaktionen.Fill_With_Archive(fT_Sparkasse_BankTransaktionen_Import, _
                                            objLocalConfig.SemItem_Attribute_Beg_nstigter_Zahlungspflichtiger.GUID, _
                                            objLocalConfig.SemItem_Attribute_Buchungstext.GUID, _
                                            objLocalConfig.SemItem_Attribute_Verwendungszweck.GUID, _
                                            objLocalConfig.SemItem_Attribute_Info.GUID, _
                                            objLocalConfig.SemItem_Attribute_Zahlungsausgang.GUID, _
                                            objLocalConfig.SemItem_Attribute_Valutatag.GUID, _
                                            objLocalConfig.SemItem_Attribute_Betrag.GUID, _
                                            objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse_.GUID, _
                                            objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse____Archiv.GUID, _
                                            objLocalConfig.SemItem_Type_Currencies.GUID, _
                                            objLocalConfig.SemItem_Type_Alternate_Currency_Name.GUID, _
                                            objLocalConfig.SemItem_Type_Kontonummer.GUID, _
                                            objLocalConfig.SemItem_Type_Bankleitzahl.GUID, _
                                            objLocalConfig.SemItem_Type_Payment.GUID, _
                                            objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                            objLocalConfig.SemItem_RelationType_Auftragskonto.GUID, _
                                            objLocalConfig.SemItem_RelationType_Gegenkonto.GUID, _
                                            objLocalConfig.SemItem_RelationType_belonging.GUID, _
                                            objLocalConfig.SemItem_RelationType_offers.GUID)


    End Sub

    Public Function import_Transactions() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim strLine As String
        Dim strLines_Error() As String = Nothing
        Dim strCells() As String
        Dim strHeaders() As String
        Dim objDRs_Transactions() As DataRow
        Dim objDRC_Data As DataRowCollection
        Dim objDRC_Currency As DataRowCollection
        Dim objDRC_Kto As DataRowCollection
        Dim objTextWriter As IO.StreamWriter

        Dim objSemItem_Auftragskonto As New clsSemItem

        Dim objSemItem_Transaction As New clsSemItem
        Dim strCell As String
        Dim strSelect As String
        Dim boolFirstLine As Boolean

        Dim dblBetrag As Double
        Dim boolZahlungsausgang As Boolean
        Dim dateValutaDate As Date
        Dim strBegZahl As String
        Dim strGegenkonto As String
        Dim strBLZGegenkonto As String
        Dim strAuftragskonto As String
        Dim strCurrency As String
        Dim strInfo As String
        Dim strVerwendungszweck As String
        Dim strBuchungstext As String
        Dim strError As String

        Dim objSemItem_Currency As clsSemItem
        Dim objSemItem_Kto As clsSemItem
        Dim objSemItem_BLZ As clsSemItem

        Dim i As Integer
        Dim intTr As Integer
        Dim intTrDone As Integer
        Dim intLinesError As Integer


        If objSemItem_Result_Config.GUID = objLocalConfig.SemItem_Token_Logstate_Config_Error.GUID Then
            objSemItem_Result = objLocalConfig.SemItem_Token_Logstate_Config_Error
        Else
            boolFirstLine = True
            objSemItem_Result = Create_ImportLog()
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                Try
                    objTextReader = New IO.StreamReader(objSemItem_ImportFile.Additional1, True)
                    intTr = 0
                    intTrDone = 0
                    While Not objTextReader.EndOfStream
                        strLine = objTextReader.ReadLine
                        If boolFirstLine = True Then
                            strHeaders = strLine.Split(objSemItem_TextSeperator.Name)
                            boolFirstLine = False
                        Else
                            intTr = intTr + 1
                            strCells = strLine.Split(objSemItem_TextSeperator.Name)
                            strSelect = ""
                            For i = 0 To strHeaders.Length - 1

                                Select Case i

                                    Case 8

                                        If strCells(i).StartsWith(objSemItem_TextQualifier.Name & "-") Then
                                            boolZahlungsausgang = True
                                            dblBetrag = Double.Parse(strCells(i).Replace(objSemItem_TextQualifier.Name, "").Replace("'", "''").Substring(1))
                                            strSelect = strSelect & " AND " & strHeaders(i).Replace(objSemItem_TextQualifier.Name, "") & "=" & dblBetrag.ToString.Replace(",", ".")
                                            strSelect = strSelect & " AND Zahlungsausgang=1"
                                        Else
                                            boolZahlungsausgang = False
                                            dblBetrag = Double.Parse(strCells(i).Replace(objSemItem_TextQualifier.Name, "").Replace("'", "''"))
                                            strSelect = strSelect & " AND " & strHeaders(i).Replace(objSemItem_TextQualifier.Name, "") & "=" & dblBetrag.ToString.Replace(",", ".")
                                            strSelect = strSelect & " AND Zahlungsausgang=0"
                                        End If
                                    Case 1
                                    Case 2
                                        If Date.TryParse(strCells(i).Replace(objSemItem_TextQualifier.Name, "").Replace("'", "''"), dateValutaDate) Then
                                            strSelect = strSelect & " AND Valutatag='" & dateValutaDate.ToString & "'"
                                        Else
                                            strGegenkonto = ""
                                        End If

                                    Case 5
                                        strBegZahl = strCells(i).Replace(objSemItem_TextQualifier.Name, "").Replace("'", "''")
                                        'strSelect = strSelect & " AND BegZahl='" & strBegZahl & "'"
                                    Case 6
                                        strGegenkonto = strCells(i).Replace(objSemItem_TextQualifier.Name, "").Replace("'", "''")
                                        strSelect = strSelect & " AND Name_Kontonummer_Gegenkonto='" & strGegenkonto & "'"
                                    Case 7
                                        strBLZGegenkonto = strCells(i).Replace(objSemItem_TextQualifier.Name, "").Replace("'", "''")
                                        strSelect = strSelect & " AND Name_Bankleitzahl_Gegenkonto='" & strBLZGegenkonto & "'"
                                    Case 9
                                        strCurrency = strCells(i).Replace(objSemItem_TextQualifier.Name, "").Replace("'", "''")
                                        strSelect = strSelect & " AND Name_Alternate_Currency_Name='" & strCurrency & "'"
                                    Case 0
                                        strAuftragskonto = strCells(i).Replace(objSemItem_TextQualifier.Name, "").Replace("'", "''")
                                        strSelect = "Name_Kontonummer_Auftragskonto='" & strAuftragskonto & "'"
                                    Case 3
                                        strBuchungstext = strCells(i).Replace(objSemItem_TextQualifier.Name, "").Replace("'", "''")
                                        strSelect = strSelect & " AND Buchungstext='" & strBuchungstext & "'"
                                    Case 4
                                        strVerwendungszweck = strCells(i).Replace(objSemItem_TextQualifier.Name, "").Replace("'", "''")
                                        'strSelect = strSelect & " AND Verwendungszweck='" & strVerwendungszweck & "'"
                                    Case 10
                                        strInfo = strCells(i).Replace(objSemItem_TextQualifier.Name, "").Replace("'", "''")
                                        strSelect = strSelect & " AND Info='" & strInfo & "'"
                                End Select

                            Next
                            If Not strGegenkonto = "" And Not strBLZGegenkonto = "" Then
                                objDRs_Transactions = fT_Sparkasse_BankTransaktionen_Import.Select(strSelect)
                                If objDRs_Transactions.Count = 0 Then
                                    objSemItem_Transaction = New clsSemItem
                                    objSemItem_Transaction.GUID = Guid.NewGuid
                                    objSemItem_Transaction.Name = strBuchungstext & strVerwendungszweck
                                    objSemItem_Transaction.GUID_Parent = objLocalConfig.SemItem_Type_Bank_Transaktionen__Sparkasse_.GUID
                                    objSemItem_Transaction.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                    objSemItem_Result = objTransaction_BankTransaction.save_001_BankTransaction(objSemItem_Transaction)
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objDRC_Data = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_Kontonummer.GUID, _
                                                                                                       strAuftragskonto).Rows
                                        If objDRC_Data.Count > 0 Then
                                            objSemItem_Auftragskonto.GUID = objDRC_Data(0).Item("GUID_Token")
                                            objSemItem_Auftragskonto.Name = objDRC_Data(0).Item("Name_Token")
                                            objSemItem_Auftragskonto.GUID_Parent = objLocalConfig.SemItem_Type_Kontonummer.GUID
                                            objSemItem_Auftragskonto.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                            objSemItem_Result = objTransaction_BankTransaction.save_002_BankTransaction_To_Auftragskonto(objSemItem_Auftragskonto, _
                                                                                                                                         objSemItem_Transaction)

                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_BankTransaction.save_003_Info_Of_BankTransaction(strInfo, _
                                                                                                                                    objSemItem_Transaction)
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Result = objTransaction_BankTransaction.save_004_Valutadatum_Of_BankTransaction(dateValutaDate, _
                                                                                                                                               objSemItem_Transaction)
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objSemItem_Result = objTransaction_BankTransaction.save_005_Zahlungsausgang_Of_BankTransaction(boolZahlungsausgang, _
                                                                                                                                                   objSemItem_Transaction)
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_BankTransaction.save_006_BegZahl_Of_BankTransaction(strBegZahl, _
                                                                                                                                                       objSemItem_Transaction)
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_BankTransaction.save_007_Betrag_Of_BankTransaction(dblBetrag, _
                                                                                                                                                           objSemItem_Transaction)
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objSemItem_Result = objTransaction_BankTransaction.save_008_Buchungstext_Of_BankTransaction(strBuchungstext, _
                                                                                                                                                               objSemItem_Transaction)
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        If Not strVerwendungszweck = "" Then
                                                                            objSemItem_Result = objTransaction_BankTransaction.save_009_Verwendungszweck_Of_BankTransaction(strVerwendungszweck, _
                                                                                                                                                                   objSemItem_Transaction)
                                                                        End If

                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objDRC_Currency = pA_Currency_By_Name.GetData(objLocalConfig.SemItem_Type_Currencies.GUID, _
                                                                                                                          objLocalConfig.SemItem_Type_Alternate_Currency_Name.GUID, _
                                                                                                                          objLocalConfig.SemItem_RelationType_offers.GUID, _
                                                                                                                          strCurrency).Rows
                                                                            If objDRC_Currency.Count > 0 Then
                                                                                objSemItem_Currency = New clsSemItem
                                                                                objSemItem_Currency.GUID = objDRC_Currency(0).Item("GUID_Currencies")
                                                                                objSemItem_Currency.Name = objDRC_Currency(0).Item("Name_Currencies")
                                                                                objSemItem_Currency.GUID_Parent = objLocalConfig.SemItem_Type_Currencies.GUID
                                                                                objSemItem_Currency.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                                                                objSemItem_Result = objTransaction_BankTransaction.save_010_BankTransaction_To_Currency(objSemItem_Currency)
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objDRC_Kto = pA_Konto_By_KTO_And_BLZ.GetData(objLocalConfig.SemItem_Type_Kontonummer.GUID, _
                                                                                                                                 objLocalConfig.SemItem_Type_Bankleitzahl.GUID, _
                                                                                                                                 objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                                                                                                                 strGegenkonto, _
                                                                                                                                 strBLZGegenkonto).Rows
                                                                                    If objDRC_Kto.Count > 0 Then
                                                                                        objSemItem_Kto = New clsSemItem
                                                                                        objSemItem_Kto.GUID = objDRC_Kto(0).Item("GUID_Kontonummer")
                                                                                        objSemItem_Kto.Name = objDRC_Kto(0).Item("Name_Kontonummer")
                                                                                        objSemItem_Kto.GUID_Parent = objLocalConfig.SemItem_Type_Kontonummer.GUID
                                                                                        objSemItem_Kto.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                                                                        objSemItem_BLZ = New clsSemItem
                                                                                        objSemItem_BLZ.GUID = objDRC_Kto(0).Item("GUID_Bankleitzahl")
                                                                                        objSemItem_BLZ.Name = objDRC_Kto(0).Item("Name_Bankleitzahl")
                                                                                        objSemItem_BLZ.GUID_Parent = objLocalConfig.SemItem_Type_Bankleitzahl.GUID
                                                                                        objSemItem_BLZ.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                                                                    Else
                                                                                        objSemItem_Kto = New clsSemItem
                                                                                        objSemItem_Kto.GUID = Guid.NewGuid
                                                                                        objSemItem_Kto.Name = strGegenkonto
                                                                                        objSemItem_Kto.GUID_Parent = objLocalConfig.SemItem_Type_Kontonummer.GUID
                                                                                        objSemItem_Kto.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                                                                        objSemItem_Result = objTransaction_BankTransaction.save_011_Gegenkonto(objSemItem_Kto)
                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                            objDRC_Kto = semtblA_Token.GetData_Token_By_Name_And_GUIDType(objLocalConfig.SemItem_Type_Bankleitzahl.GUID, _
                                                                                                                                                          strBLZGegenkonto).Rows
                                                                                            If objDRC_Kto.Count > 0 Then
                                                                                                objSemItem_BLZ = New clsSemItem
                                                                                                objSemItem_BLZ.GUID = objDRC_Kto(0).Item("GUID_Token")
                                                                                                objSemItem_BLZ.Name = objDRC_Kto(0).Item("Name_Token")
                                                                                                objSemItem_BLZ.GUID_Parent = objLocalConfig.SemItem_Type_Bankleitzahl.GUID
                                                                                                objSemItem_BLZ.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                                                                            Else
                                                                                                objSemItem_BLZ = New clsSemItem
                                                                                                objSemItem_BLZ.GUID = Guid.NewGuid
                                                                                                objSemItem_BLZ.Name = strBLZGegenkonto
                                                                                                objSemItem_BLZ.GUID_Parent = objLocalConfig.SemItem_Type_Bankleitzahl.GUID
                                                                                                objSemItem_BLZ.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                                                                                                objSemItem_Result = objTransaction_BankTransaction.save_012_BLZ_Gegenkonto(objSemItem_BLZ)
                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                                                                                                    objTransaction_BankTransaction.del_011_Gegenkonto()
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If

                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                        objSemItem_Result = objTransaction_BankTransaction.save_013_KTO_To_BLZ(objSemItem_Kto, objSemItem_BLZ)
                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                            objSemItem_Result = objTransaction_BankTransaction.save_014_BankTransaction_To_Gegenkonto()
                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                intTrDone = intTrDone + 1
                                                                                            Else
                                                                                                objSemItem_Result = objTransaction_BankTransaction.del_010_BankTransaction_To_Currency()
                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_009_Verwendungszweck_Of_BankTransaction()
                                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_008_Buchungstext_Of_BankTransaction()
                                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_007_Betrag_Of_BankTransaction()
                                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                objSemItem_Result = objTransaction_BankTransaction.del_006_BegZahl_Of_BankTransaction()
                                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_005_Zahlungsausgang_Of_BankTransaction()
                                                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_004_Valutadatum_Of_BankTransaction()
                                                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_003_Info_Of_BankTransaction()
                                                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                                objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto(objSemItem_Transaction, _
                                                                                                                                                                                                                        objSemItem_Auftragskonto)

                                                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                                    objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                                                            End If
                                                                                        Else
                                                                                            objTransaction_BankTransaction.del_011_Gegenkonto()
                                                                                            objTransaction_BankTransaction.del_012_BLZ_Gegenkonto()
                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_010_BankTransaction_To_Currency()
                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                objSemItem_Result = objTransaction_BankTransaction.del_009_Verwendungszweck_Of_BankTransaction()
                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_008_Buchungstext_Of_BankTransaction()
                                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_007_Betrag_Of_BankTransaction()
                                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_006_BegZahl_Of_BankTransaction()
                                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                objSemItem_Result = objTransaction_BankTransaction.del_005_Zahlungsausgang_Of_BankTransaction()
                                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_004_Valutadatum_Of_BankTransaction()
                                                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_003_Info_Of_BankTransaction()
                                                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto(objSemItem_Transaction, _
                                                                                                                                                                                                                    objSemItem_Auftragskonto)

                                                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                                objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                                                        End If

                                                                                    Else
                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_010_BankTransaction_To_Currency()
                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_009_Verwendungszweck_Of_BankTransaction()
                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                objSemItem_Result = objTransaction_BankTransaction.del_008_Buchungstext_Of_BankTransaction()
                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_007_Betrag_Of_BankTransaction()
                                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_006_BegZahl_Of_BankTransaction()
                                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_005_Zahlungsausgang_Of_BankTransaction()
                                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                objSemItem_Result = objTransaction_BankTransaction.del_004_Valutadatum_Of_BankTransaction()
                                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_003_Info_Of_BankTransaction()
                                                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto(objSemItem_Transaction, _
                                                                                                                                                                                                                objSemItem_Auftragskonto)

                                                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                            objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                                                    End If
                                                                                Else
                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_009_Verwendungszweck_Of_BankTransaction()
                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_008_Buchungstext_Of_BankTransaction()
                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_007_Betrag_Of_BankTransaction()
                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                objSemItem_Result = objTransaction_BankTransaction.del_006_BegZahl_Of_BankTransaction()
                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_005_Zahlungsausgang_Of_BankTransaction()
                                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_004_Valutadatum_Of_BankTransaction()
                                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_003_Info_Of_BankTransaction()
                                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto(objSemItem_Transaction, _
                                                                                                                                                                                                        objSemItem_Auftragskonto)

                                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                    objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If

                                                                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                                                End If
                                                                            Else
                                                                                objSemItem_Result = objTransaction_BankTransaction.del_009_Verwendungszweck_Of_BankTransaction()
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_008_Buchungstext_Of_BankTransaction()
                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_007_Betrag_Of_BankTransaction()
                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_006_BegZahl_Of_BankTransaction()
                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                objSemItem_Result = objTransaction_BankTransaction.del_005_Zahlungsausgang_Of_BankTransaction()
                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_004_Valutadatum_Of_BankTransaction()
                                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_003_Info_Of_BankTransaction()
                                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto(objSemItem_Transaction, _
                                                                                                                                                                                                    objSemItem_Auftragskonto)

                                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                                objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If

                                                                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                                            End If
                                                                        Else

                                                                            objSemItem_Result = objTransaction_BankTransaction.del_008_Buchungstext_Of_BankTransaction()
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objSemItem_Result = objTransaction_BankTransaction.del_007_Betrag_Of_BankTransaction()
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_006_BegZahl_Of_BankTransaction()
                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_005_Zahlungsausgang_Of_BankTransaction()
                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_004_Valutadatum_Of_BankTransaction()
                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                objSemItem_Result = objTransaction_BankTransaction.del_003_Info_Of_BankTransaction()
                                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto(objSemItem_Transaction, _
                                                                                                                                                                                            objSemItem_Auftragskonto)

                                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                        objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If


                                                                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                                        End If
                                                                    Else

                                                                        objSemItem_Result = objTransaction_BankTransaction.del_007_Betrag_Of_BankTransaction()
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objSemItem_Result = objTransaction_BankTransaction.del_006_BegZahl_Of_BankTransaction()
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objSemItem_Result = objTransaction_BankTransaction.del_005_Zahlungsausgang_Of_BankTransaction()
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_004_Valutadatum_Of_BankTransaction()
                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                        objSemItem_Result = objTransaction_BankTransaction.del_003_Info_Of_BankTransaction()
                                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                            objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto(objSemItem_Transaction, _
                                                                                                                                                                                    objSemItem_Auftragskonto)

                                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                                objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If

                                                                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                                    End If
                                                                Else

                                                                    objSemItem_Result = objTransaction_BankTransaction.del_006_BegZahl_Of_BankTransaction()
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objSemItem_Result = objTransaction_BankTransaction.del_005_Zahlungsausgang_Of_BankTransaction()
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objSemItem_Result = objTransaction_BankTransaction.del_004_Valutadatum_Of_BankTransaction()
                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objSemItem_Result = objTransaction_BankTransaction.del_003_Info_Of_BankTransaction()
                                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                    objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto(objSemItem_Transaction, _
                                                                                                                                                                            objSemItem_Auftragskonto)

                                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                        objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                                End If
                                                            Else

                                                                objSemItem_Result = objTransaction_BankTransaction.del_005_Zahlungsausgang_Of_BankTransaction()
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objSemItem_Result = objTransaction_BankTransaction.del_004_Valutadatum_Of_BankTransaction()
                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objSemItem_Result = objTransaction_BankTransaction.del_003_Info_Of_BankTransaction()
                                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                            objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto(objSemItem_Transaction, _
                                                                                                                                                                    objSemItem_Auftragskonto)

                                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                                objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If



                                                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                            End If
                                                        Else

                                                            objSemItem_Result = objTransaction_BankTransaction.del_004_Valutadatum_Of_BankTransaction()
                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objSemItem_Result = objTransaction_BankTransaction.del_003_Info_Of_BankTransaction()
                                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                    objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto(objSemItem_Transaction, _
                                                                                                                                                            objSemItem_Auftragskonto)

                                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                        objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                                                    End If
                                                                End If
                                                            End If


                                                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                        End If
                                                    Else

                                                        objSemItem_Result = objTransaction_BankTransaction.del_003_Info_Of_BankTransaction()
                                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                            objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto(objSemItem_Transaction, _
                                                                                                                                                    objSemItem_Auftragskonto)

                                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                                objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                                            End If
                                                        End If

                                                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                    End If
                                                Else

                                                    objSemItem_Result = objTransaction_BankTransaction.del_002_BankTransaction_To_Auftragskonto(objSemItem_Transaction, _
                                                                                                                                                objSemItem_Auftragskonto)
                                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                        objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                                    End If
                                                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                End If
                                            Else
                                                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                                objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                            End If
                                        Else
                                            objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                            objTransaction_BankTransaction.del_001_BankTransaction(objSemItem_Transaction)
                                        End If
                                    Else
                                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                                    End If
                                End If
                            End If
                            
                        End If
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                            If strLines_Error Is Nothing Then
                                intLinesError = 0

                            Else
                                intLinesError = strLines_Error.Length

                            End If
                            ReDim Preserve strLines_Error(intLinesError)
                            strLines_Error(intLinesError) = strLine
                        End If
                    End While

                    objTextReader.Close()
                Catch ex As Exception
                    objSemItem_Result = close_ImportLog(objLocalConfig.Globals.LogState_Error, "File not Found")
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                        MsgBox("Der Import konnte nicht protokolliert werden: File not Found!", MsgBoxStyle.Exclamation)
                    End If
                End Try
            Else
                MsgBox("Der Import kann nicht protokolliert werden!", MsgBoxStyle.Exclamation)
            End If
            
            
        End If
        If strLines_Error Is Nothing Then
            objSemItem_Result = close_ImportLog(objLocalConfig.Globals.LogState_Success, "Done!")
            If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                MsgBox("Der Import konnte nicht protokolliert werden: Success!", MsgBoxStyle.Information)
            End If
        Else

            strError = ""
            For intLinesError = 0 To strLines_Error.Count
                strError = strError & strLines_Error(i)
            Next
            objSemItem_Result = close_ImportLog(objLocalConfig.Globals.LogState_Error, strError)

            If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                Try

                    objTextWriter = New IO.StreamWriter("importlog" & Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & "-" & Now.Minute & "-" & Now.Second & ".txt", False)
                    objTextWriter.Write(strError)

                    MsgBox("Der Import konnte nicht vollständig durchgeführt und protokolleirt werden. Das Protokoll findet sich im Programmverzeichnis!", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox("Der Import konnte nicht vollständig durchgeführt und protokolleirt werden. Das Protokoll konnte nicht geschrieben werden!", MsgBoxStyle.Exclamation)
                End Try
                
            End If


        End If
        Return objSemItem_Result
    End Function

    Private Function Create_ImportLog() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        objSemItem_ImportLog = New clsSemItem

        dateStart = Now

        objSemItem_ImportLog = New clsSemItem
        objSemItem_ImportLog.GUID = Guid.NewGuid
        objSemItem_ImportLog.Name = dateStart.ToString & ": " & objSemItem_ImportSetting.Name
        objSemItem_ImportLog.GUID_Parent = objLocalConfig.SemItem_Type_Imports.GUID
        objSemItem_ImportLog.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        objSemItem_Result = objTransaction_ImportLog.save_001_ImportLog(objSemItem_ImportLog)
        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = objTransaction_ImportLog.save_002_Start(dateStart)
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_ImportLog.save_003_ImportLog_To_ImportSetting(objSemItem_ImportSetting)
                If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then

                    objSemItem_Result = objTransaction_ImportLog.del_002_Start
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objTransaction_ImportLog.del_001_ImportLog()
                    End If
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If
            Else
                objTransaction_ImportLog.del_001_ImportLog()
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result

    End Function

    Private Function close_ImportLog(ByVal objSemItem_LogState As clsSemItem, ByVal strMessage As String) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_LogEntry = objLogManagement.log_Entry(Now, objSemItem_LogState.GUID, Nothing, strMessage)
        If Not objSemItem_LogState Is Nothing Then
            objSemItem_Result = objTransaction_ImportLog.save_004_ImportLog_To_LogEntry(objSemItem_LogEntry)
            If Not objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = objTransaction_ImportLog.del_002_Start
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objTransaction_ImportLog.del_001_ImportLog()
                End If
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        Else
            objSemItem_Result = objTransaction_ImportLog.del_002_Start
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objTransaction_ImportLog.del_001_ImportLog()
            End If
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

End Class
