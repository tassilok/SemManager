Imports Sem_Manager
Imports Filesystem_Management
Imports OrganisationalTransactions
Public Class clsImageInfo
    Private objBlobConnection As clsBlobConnection
    Private objLocalConfig As clsLocalConfig
    Private procA_Image_Of_Or As New ds_ImageModuleTableAdapters.proc_Image_Of_OrTableAdapter
    Private procT_Image_Of_Or As New ds_ImageModule.proc_Image_Of_OrDataTable
    Private procA_Images_And_Files As New ds_ImageModuleTableAdapters.proc_Images_And_FilesTableAdapter
    Private funcA_TokenToken As New ds_TokenTableAdapters.func_TokenTokenTableAdapter
    Private semfuncA_ObjectReference As New ds_ObjectReferenceTableAdapters.semfunc_ObjectReferenceTableAdapter

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter

    Private objTransaction_Image As clsTransaction_Imagevb
    Private objTransaction_Datetime As clsTransaction_DateTime

    Private objSemItem_Year As clsSemItem
    Private objSemItem_Month As clsSemItem
    Private objSemItem_Day As clsSemItem

    Public ReadOnly Property Rows_Images() As DataRowCollection
        Get
            Return procT_Image_Of_Or.Rows
        End Get
    End Property

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig

        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig(Globals)

        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()
    End Sub

    Public Function get_Images(ByVal SemItem_Ref As clsSemItem) As clsSemItem
        Dim objDRC_OR As DataRowCollection
        Dim objSemItem_Result As clsSemItem

        objDRC_OR = semfuncA_ObjectReference.GetData_By_GUID_Ref(SemItem_Ref.GUID).Rows
        If objDRC_OR.Count > 0 Then
            procA_Image_Of_Or.Fill(procT_Image_Of_Or, _
                                   objLocalConfig.SemItem_Type_Images__Graphic_.GUID, _
                                   objLocalConfig.SemItem_Type_File.GUID, _
                                   objLocalConfig.SemItem_RelationType_belongsTo.GUID, _
                                   objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                   objDRC_OR(0).Item("GUID_ObjectReference"))
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        Return objSemItem_Result
    End Function

    Public Sub start_Getting_Chronical()
        Dim objDRC_Images As DataRowCollection
        Dim objDR_Image As DataRow
        Dim objSemItem_Image As New clsSemItem
        Dim objSemItem_File As New clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim strPath_Blob As String
        Dim intToDo As Integer
        Dim intDone As Integer

        objDRC_Images = procA_Images_And_Files.GetData(objLocalConfig.SemItem_Type_Images__Graphic_.GUID, _
                                                       objLocalConfig.SemItem_Type_File.GUID, _
                                                       objLocalConfig.SemItem_RelationType_belonging_Source.GUID).Rows

        intToDo = objDRC_Images.Count
        intDone = 0
        For Each objDR_Image In objDRC_Images
            objSemItem_Image.GUID = objDR_Image.Item("GUID_Images__Graphic_")
            objSemItem_Image.Name = objDR_Image.Item("Name_Images__Graphic_")
            objSemItem_Image.GUID_Parent = objLocalConfig.SemItem_Type_Images__Graphic_.GUID
            objSemItem_Image.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            objSemItem_File.GUID = objDR_Image.Item("GUID_File")
            objSemItem_File.Name = objDR_Image.Item("Name_File")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

            strPath_Blob = Environment.ExpandEnvironmentVariables("%Temp%") & "\" & Guid.NewGuid.ToString & "." & objLocalConfig.SemItem_Token_Extensions_Image.Name

            objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath_Blob)

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = get_Chronical(objSemItem_Image, objSemItem_File, strPath_Blob)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If
            End If


        Next
    End Sub

    Public Function get_Chronical(ByVal objSemItem_Image As clsSemItem, ByVal objSemItem_File As clsSemItem, Optional ByVal strPath_Blob As String = Nothing) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_File As DataRowCollection
        Dim objImage As Image
        Dim objPropertyItem As Drawing.Imaging.PropertyItem
        Dim byteValue() As Byte
        Dim strValue As String
        Dim strDates() As String
        Dim dateCreate As Date = Nothing

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If strPath_Blob = Nothing Then
            objDRC_File = funcA_TokenToken.GetData_TokenToken_LeftRight(objSemItem_Image.GUID, _
                                                                        objLocalConfig.SemItem_RelationType_belonging_Source.GUID, _
                                                                        objLocalConfig.SemItem_Type_File.GUID).Rows
            If objDRC_File.Count > 0 Then
                strPath_Blob = Environment.ExpandEnvironmentVariables("%Temp%") & "\" & Guid.NewGuid.ToString & "." & objLocalConfig.SemItem_Token_Extensions_Image.Name
                objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath_Blob)
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objImage = New Bitmap(strPath_Blob)
            For Each objPropertyItem In objImage.PropertyItems
                If objPropertyItem.Id = 306 Or objPropertyItem.Id = 9003 Or objPropertyItem.Id = 36867 Then
                    byteValue = objPropertyItem.Value
                    strValue = ""
                    For i As Integer = 0 To byteValue.Length - 1
                        strValue = strValue & Chr(byteValue(i))
                    Next
                    strDates = strValue.Split(" ")
                    If strDates.Count = 2 Then
                        strDates(0) = strDates(0).Replace(":", ".")
                        strValue = strDates(0) & " " & strDates(1)
                    End If
                    If Date.TryParse(strValue, dateCreate) = False Then
                        dateCreate = Nothing
                    End If
                    Exit For
                End If
                

            Next

            If Not dateCreate = Nothing Then
                objSemItem_Result = objTransaction_Image.save_008_ImageGraphic__Taking(dateCreate, objSemItem_Image)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objSemItem_Result = objTransaction_Datetime.save_001_Period(dateCreate.Year, objLocalConfig.SemItem_Type_Year.GUID)
                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                        objSemItem_Result = objTransaction_Datetime.save_002_Period__Value
                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                            objSemItem_Year = objTransaction_Datetime.SemItem_Period

                            objSemItem_Result = objTransaction_Image.save_009_ImageGraphic_To_Year(objSemItem_Year)
                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                objSemItem_Result = objTransaction_Datetime.save_001_Period(dateCreate.Month, objLocalConfig.SemItem_Type_Month.GUID)
                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                    objSemItem_Result = objTransaction_Datetime.save_002_Period__Value
                                    If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                        objSemItem_Month = objTransaction_Datetime.SemItem_Period
                                        objSemItem_Result = objTransaction_Image.save_010_ImageGraphic_To_Month(objSemItem_Month)
                                        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                            objSemItem_Result = objTransaction_Datetime.save_001_Period(dateCreate.Day, objLocalConfig.SemItem_Type_Day.GUID)
                                            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                objSemItem_Result = objTransaction_Datetime.save_002_Period__Value
                                                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                                                    objSemItem_Day = objTransaction_Datetime.SemItem_Period
                                                    objSemItem_Result = objTransaction_Image.save_011_ImageGraphic_To_Day(objSemItem_Day)
                                                Else
                                                    objTransaction_Datetime.del_001_Period()
                                                End If
                                                


                                            End If
                                        End If
                                    Else
                                        objTransaction_Datetime.del_001_Period()
                                    End If
                                    
                                End If
                            End If
                        Else
                            objTransaction_Datetime.del_001_Period()
                        End If
                        

                    End If
                End If

            End If
        End If

        Return objSemItem_Result
    End Function

    Private Sub set_DBConnection()
        semtblA_Token.Connection = objLocalConfig.Connection_DB
        procA_Images_And_Files.Connection = objLocalConfig.Connection_Plugin
        funcA_TokenToken.Connection = objLocalConfig.Connection_DB
        procA_Image_Of_Or.Connection = objLocalConfig.Connection_Plugin
        semfuncA_ObjectReference.Connection = objLocalConfig.Connection_DB

        objBlobConnection = New clsBlobConnection(objLocalConfig.Globals)
        objTransaction_Image = New clsTransaction_Imagevb(objLocalConfig)
        objTransaction_Datetime = New clsTransaction_DateTime(objLocalConfig.Globals)
    End Sub
End Class
