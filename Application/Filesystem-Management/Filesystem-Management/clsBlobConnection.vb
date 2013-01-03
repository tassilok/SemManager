Imports Sem_Manager
Public Class clsBlobConnection
    Private objLocalConfig As clsLocalConfig_FileManager

    Private semtblA_Blob As New ds_BlobTableAdapters.semtbl_BlobTableAdapter
    Private semtblA_Blob_meta As New ds_BlobTableAdapters.semtbl_Blob_metaTableAdapter
    Private funcA_TokenAttribute_Named_By_GUIDToken As New ds_TokenAttributeTableAdapters.func_TokenAttribute_Named_By_GUIDTokenTableAdapter
    Private procA_Blob As New ds_BlobTableAdapters.proc_BlobTableAdapter

    Private semprocA_DBWork_Save_TokenAttribute_Bit As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_BitTableAdapter
    Private semprocA_DBWork_Del_TokenAttribute As New ds_DBWorkTableAdapters.semproc_DBWork_Del_TokenAttributeTableAdapter
    Private semprocA_DBWork_Save_TokenAttribute_Datetime As New ds_DBWorkTableAdapters.semproc_DBWork_Save_TokenAttribute_DatetimeTableAdapter

    Private procA_Files_MD5 As New ds_BlobTableAdapters.proc_Files_MD5TableAdapter

    Private objSQLFs As SqlTypes.SqlFileStream
    Private objCMD As SqlClient.SqlCommand

    Private objDRC_BaseEinheit As DataRowCollection

    Private objSemItem_BaseEinheit As New clsSemItem

    Private dbl_Size_Smallest As Double
    Private intID As Integer
    Private intID_Smallest As Integer

    Private GUID_TokenAttribute_BlobOn As Guid

    Dim strFilePath As String = Nothing

    Public ReadOnly Property FilePath As String
        Get
            Return strFilePath
        End Get
    End Property

    Public Function File_Of_Hash(ByVal strHash As String) As clsSemItem
        Dim objSemItem_File As clsSemItem = Nothing
        Dim objDRC_File As DataRowCollection

        objDRC_File = procA_Files_MD5.GetData(strHash).Rows
        If objDRC_File.Count > 0 Then
            objSemItem_File = New clsSemItem
            objSemItem_File.GUID = objDRC_File(0).Item("GUID_Blob")
            objSemItem_File.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
            objSemItem_File.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

        End If

        Return objSemItem_File
    End Function

    Public Sub New()
        

        objLocalConfig = New clsLocalConfig_FileManager(New clsGlobals)

        initialize()
    End Sub

    Public Sub New(ByVal Globals As clsGlobals)
        objLocalConfig = New clsLocalConfig_FileManager(Globals)

        initialize()
    End Sub

    Public Sub New(ByVal LocalConfig As clsLocalConfig_FileManager)
        objLocalConfig = LocalConfig

        initialize()
    End Sub
   
    Private Sub initialize()


        set_DBConnection()

    End Sub

    Private Sub set_DBConnection()
        semtblA_Blob.Connection = objLocalConfig.Connection_Blob
        semtblA_Blob_meta.Connection = objLocalConfig.Connection_Blob
        procA_Files_MD5.Connection = objLocalConfig.Connection_Blob
        funcA_TokenAttribute_Named_By_GUIDToken.Connection = objLocalConfig.Connection_DB

        semprocA_DBWork_Save_TokenAttribute_Datetime.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Save_TokenAttribute_Bit.Connection = objLocalConfig.Connection_DB
        semprocA_DBWork_Del_TokenAttribute.Connection = objLocalConfig.Connection_DB

        procA_Blob.Connection = objLocalConfig.Connection_Blob
    End Sub
    Public Function is_Blob_Present(ByVal objSemItem_File As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objTX As SqlClient.SqlTransaction = Nothing
        Dim objCMD As SqlClient.SqlCommand
        Dim pathObj As Object

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If Not objLocalConfig.Connection_Blob.State = ConnectionState.Open Then
            objLocalConfig.Connection_Blob.Open()
        End If
        objCMD = New SqlClient.SqlCommand("SELECT Data_Blob.PathName() FROM semtbl_Blob WHERE GUID_Blob='" & objSemItem_File.GUID.ToString & "'", objLocalConfig.Connection_Blob, objTX)
        pathObj = objCMD.ExecuteScalar()
        If Not pathObj Is Nothing Then
            If Not pathObj.Equals(DBNull.Value) Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Success
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
            End If
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Nothing
        End If

        Return objSemItem_Result
    End Function
    Public Function get_BlobStream(ByVal objSemItem_File As clsSemItem) As SqlTypes.SqlFileStream
        Dim objTX As SqlClient.SqlTransaction = Nothing
        Dim pathObj As Object
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If Not objLocalConfig.Connection_Blob.State = ConnectionState.Open Then
            objLocalConfig.Connection_Blob.Open()
        End If
        objCMD = New SqlClient.SqlCommand("SELECT Data_Blob.PathName() FROM semtbl_Blob WHERE GUID_Blob='" & objSemItem_File.GUID.ToString & "'", objLocalConfig.Connection_Blob, objTX)
        pathObj = objCMD.ExecuteScalar()
        If Not pathObj.Equals(DBNull.Value) Then
            strFilePath = DirectCast(pathObj, String)
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objTX = objLocalConfig.Connection_Blob.BeginTransaction("mainTranaction")
            objCMD = New SqlClient.SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()", objLocalConfig.Connection_Blob, objTX)
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            Dim objScalar As Object = objCMD.ExecuteScalar()
            '
            Dim objTxCtx As Byte()
            If Not objScalar.Equals(DBNull.Value) Then
                objTxCtx = DirectCast(objScalar, Byte())
                objSQLFs = New SqlTypes.SqlFileStream(strFilePath, objTxCtx, IO.FileAccess.Read)
                


                



            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If



        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            Try
                objCMD.Transaction.Rollback()
            Catch ex As Exception

            End Try


        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            Return objSQLFs
        Else
            Return Nothing
        End If
    End Function

    Public Function close_SQLStream()
        objSQLFs.Close()
        objCMD.Transaction.Commit()
    End Function
    Public Function save_Blob_To_File(ByVal objSemItem_File As clsSemItem, ByVal strPath_File As String) As clsSemItem

        Dim objCMD As SqlClient.SqlCommand
        Dim objTX As SqlClient.SqlTransaction = Nothing
        Dim pathObj As Object
        Dim objSemItem_Result As clsSemItem
        Dim objFileInfo As IO.FileInfo
        Dim objDRC_Create As DataRowCollection

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If Not objLocalConfig.Connection_Blob.State = ConnectionState.Open Then
            objLocalConfig.Connection_Blob.Open()
        End If
        objCMD = New SqlClient.SqlCommand("SELECT Data_Blob.PathName() FROM semtbl_Blob WHERE GUID_Blob='" & objSemItem_File.GUID.ToString & "'", objLocalConfig.Connection_Blob, objTX)
        pathObj = objCMD.ExecuteScalar()
        If Not pathObj.Equals(DBNull.Value) Then
            strFilePath = DirectCast(pathObj, String)
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objTX = objLocalConfig.Connection_Blob.BeginTransaction("mainTranaction")
            objCMD = New SqlClient.SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()", objLocalConfig.Connection_Blob, objTX)
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            Dim objScalar As Object = objCMD.ExecuteScalar()
            '
            Dim objTxCtx As Byte()
            If Not objScalar.Equals(DBNull.Value) Then
                objTxCtx = DirectCast(objScalar, Byte())
                Dim objSQLFs As New SqlTypes.SqlFileStream(strFilePath, objTxCtx, IO.FileAccess.Read)
                Dim lngPos As Long = 0
                Dim byteFile(9999) As Byte
                Try
                    Dim objFileStream As New IO.FileStream(strPath_File, IO.FileMode.Create)
                    While objSQLFs.Position < objSQLFs.Length
                        If objSQLFs.Position + 10000 < objSQLFs.Length Then
                            objSQLFs.Read(byteFile, 0, 10000)
                            objFileStream.Write(byteFile, 0, byteFile.Length)
                        Else

                            ReDim byteFile(objSQLFs.Length - objSQLFs.Position - 1)
                            lngPos = objSQLFs.Length - objSQLFs.Position
                            objSQLFs.Read(byteFile, 0, objSQLFs.Length - objSQLFs.Position)
                            objFileStream.Write(byteFile, 0, lngPos)
                        End If
                    End While
                    objFileStream.Close()

                    objDRC_Create = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_File.GUID, _
                                                                                                               objLocalConfig.SemItem_Attribute_Datetimestamp__Create_.GUID).Rows
                    If objDRC_Create.Count > 0 Then
                        objFileInfo = New IO.FileInfo(strPath_File)
                        objFileInfo.CreationTime = objDRC_Create(0).Item("VAL_DATETIME")

                    End If

                    

                Catch ex As Exception
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error

                End Try



                objSQLFs.Close()
                objCMD.Transaction.Commit()



            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If



        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            Try
                objCMD.Transaction.Rollback()
            Catch ex As Exception

            End Try


        End If
        Return objSemItem_Result
    End Function

    Public Function upd_Meta_All_Blos() As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objSemItem_File As New clsSemItem
        Dim objDRC_Blobs As DataRowCollection
        Dim objDR_Blobs As DataRow

        Dim intToDo As Integer
        Dim intDone As Integer

        objDRC_Blobs = semtblA_Blob_meta.GetData().Rows
        intToDo = objDRC_Blobs.Count
        intDone = 0


        For Each objDR_Blobs In objDRC_Blobs
            objSemItem_File.GUID = objDR_Blobs.Item("GUID_Blob")
            'objSemItem_Result = upd_CreationDate_Of_Blob(objSemItem_File)
            'If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = upd_Size_Of_Blob(objSemItem_File)

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objSemItem_Result = upd_BlobHash(objSemItem_File)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    intDone = intDone + 1
                End If

            End If
            'End If

        Next

        objSemItem_Result = New clsSemItem
        If intDone < intToDo Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Success
        End If
        objSemItem_Result.Additional1 = intToDo & "/" & intDone

        Return objSemItem_Result
    End Function

    Public Function compare_File(ByVal strFilePath As String) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim strHash_File As String
        Dim byteFile() As Byte
        Dim objDRC_File As DataRowCollection
        Dim objDR_File As DataRow
        Dim objCMD As SqlClient.SqlCommand
        Dim objTX As SqlClient.SqlTransaction = Nothing
        Dim pathObj As Object
        Dim strHash As String

        Dim objFileStream As New IO.FileStream(strFilePath, IO.FileMode.Open, IO.FileAccess.Read)
        Dim objBinaryReader As New IO.BinaryReader(objFileStream)

        If objFileStream.Length > 4000 Then
            ReDim byteFile(4000)
            objFileStream.Seek(0, IO.SeekOrigin.Begin)
            For i = 0 To 2000
                byteFile(i) = objBinaryReader.ReadByte
            Next

            strHash_File = getHash(byteFile, 2000)
            objFileStream.Seek(-2001, IO.SeekOrigin.End)
            For i = 0 To 2000
                byteFile(i) = objBinaryReader.ReadByte
            Next
            strHash_File = strHash_File & getHash(byteFile, 2000)
        Else
            ReDim byteFile(objFileStream.Length)
            For i = 0 To objFileStream.Length - 1
                byteFile(i) = objFileStream.ReadByte
            Next

            strHash_File = getHash(byteFile, objFileStream.Length - 1)

        End If

        objDRC_File = procA_Files_MD5.GetData(strHash_File).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        If objDRC_File.Count > 0 Then
            objFileStream.Seek(0, IO.SeekOrigin.Begin)
            ReDim byteFile(objFileStream.Length - 1)
            byteFile = objBinaryReader.ReadBytes(objFileStream.Length - 1)
            strHash_File = getHash(byteFile, objFileStream.Length - 1)
            

            For Each objDR_File In objDRC_File
                If Not objLocalConfig.Connection_Blob.State = ConnectionState.Open Then
                    objLocalConfig.Connection_Blob.Open()
                End If

                objCMD = New SqlClient.SqlCommand("SELECT Data_Blob.PathName() FROM semtbl_Blob WHERE GUID_Blob='" & objDR_File.Item("GUID_Blob").ToString & "'", objLocalConfig.Connection_Blob, objTX)
                pathObj = objCMD.ExecuteScalar()
                If Not pathObj.Equals(DBNull.Value) Then
                    strFilePath = DirectCast(pathObj, String)
                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If

                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    objTX = objLocalConfig.Connection_Blob.BeginTransaction("mainTranaction")
                    objCMD = New SqlClient.SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()", objLocalConfig.Connection_Blob, objTX)
                End If

                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                    Dim objScalar As Object = objCMD.ExecuteScalar()
                    '
                    Dim objTxCtx As Byte()
                    If Not objScalar.Equals(DBNull.Value) Then
                        objTxCtx = DirectCast(objScalar, Byte())
                        Dim objSQLFs As New SqlTypes.SqlFileStream(strFilePath, objTxCtx, IO.FileAccess.Read)
                        Dim lngPos As Long = 0


                        ReDim byteFile(objSQLFs.Length - 1)
                        For i = 0 To objSQLFs.Length - 1
                            byteFile(i) = objSQLFs.ReadByte

                        Next


                        strHash = getHash(byteFile, objSQLFs.Length - 1)



                        objSQLFs.Close()
                        objCMD.Transaction.Rollback()

                        If strHash = strHash_File Then
                            objSemItem_Result.GUID = objDR_File.Item("GUID_Blob")
                            objSemItem_Result.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID
                            objSemItem_Result.GUID_Type = objLocalConfig.Globals.ObjectReferenceType_Token.GUID

                            Exit For
                        End If

                    Else
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If



                End If
            Next

        End If
        
        objBinaryReader.Close()
        objFileStream.Close()

        Return objSemItem_Result
    End Function
    Public Function upd_BlobHash(ByVal objSemItem_File As clsSemItem) As clsSemItem
        Dim objCMD As SqlClient.SqlCommand
        Dim objTX As SqlClient.SqlTransaction = Nothing
        Dim pathObj As Object
        Dim objSemItem_Result As clsSemItem
        Dim objFileInfo As IO.FileInfo
        Dim byteFile() As Byte
        Dim objDRC_Create As DataRowCollection
        Dim strHash As String

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        Try
            objLocalConfig.Connection_Blob.Close()
        Catch ex As Exception

        End Try
        objLocalConfig.Connection_Blob.Open()
        objCMD = New SqlClient.SqlCommand("SELECT Data_Blob.PathName() FROM semtbl_Blob WHERE GUID_Blob='" & objSemItem_File.GUID.ToString & "'", objLocalConfig.Connection_Blob, objTX)
        pathObj = objCMD.ExecuteScalar()
        If Not pathObj.Equals(DBNull.Value) Then
            strFilePath = DirectCast(pathObj, String)
        Else
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objTX = objLocalConfig.Connection_Blob.BeginTransaction("mainTranaction")
            objCMD = New SqlClient.SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()", objLocalConfig.Connection_Blob, objTX)
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            Dim objScalar As Object = objCMD.ExecuteScalar()
            '
            Dim objTxCtx As Byte()
            If Not objScalar.Equals(DBNull.Value) Then
                objTxCtx = DirectCast(objScalar, Byte())
                Dim objSQLFs As New SqlTypes.SqlFileStream(strFilePath, objTxCtx, IO.FileAccess.Read)
                Dim lngPos As Long = 0
                
                If objSQLFs.Length > 4000 Then
                    ReDim byteFile(4000)
                    objSQLFs.Seek(0, IO.SeekOrigin.Begin)
                    For i = 0 To 1999
                        byteFile(i) = objSQLFs.ReadByte
                    Next

                    strHash = getHash(byteFile, 2000)
                    objSQLFs.Seek(-2000, IO.SeekOrigin.End)
                    For i = 0 To 1999
                        byteFile(i) = objSQLFs.ReadByte
                    Next
                    strHash = strHash & getHash(byteFile, 2000)
                Else
                    If objSQLFs.Length > 0 Then
                        ReDim byteFile(objSQLFs.Length)
                        For i = 0 To objSQLFs.Length - 1
                            byteFile(i) = objSQLFs.ReadByte
                        Next

                        strHash = getHash(byteFile, objSQLFs.Length - 1)
                    Else
                        strHash = ""
                    End If
                    

                End If



                objSQLFs.Close()
                objCMD.Transaction.Rollback()


                semtblA_Blob.update_Hash(objSemItem_File.GUID, strHash)

            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If



        End If

        
        Return objSemItem_Result
    End Function
    Public Function upd_Size_Of_Blob(ByVal objSemItem_File As clsSemItem) As clsSemItem
        Dim objCMD As SqlClient.SqlCommand
        Dim objTX As SqlClient.SqlTransaction = Nothing
        Dim pathObj As Object
        Dim objSemItem_Result As clsSemItem
        Dim strFilePath As String = Nothing
        Dim lngSize As Long

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If Not objLocalConfig.Connection_Blob.State = ConnectionState.Open Then
            objLocalConfig.Connection_Blob.Open()
        End If
        objCMD = New SqlClient.SqlCommand("SELECT Data_Blob.PathName() FROM semtbl_Blob WHERE GUID_Blob='" & objSemItem_File.GUID.ToString & "'", objLocalConfig.Connection_Blob, objTX)
        pathObj = objCMD.ExecuteScalar()
        If pathObj.Equals(DBNull.Value) Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objTX = objLocalConfig.Connection_Blob.BeginTransaction("mainTranaction")
            objCMD = New SqlClient.SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()", objLocalConfig.Connection_Blob, objTX)
        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            Dim objScalar As Object = objCMD.ExecuteScalar()
            '
            Dim objTxCtx As Byte()
            If Not objScalar.Equals(DBNull.Value) Then

                objTxCtx = DirectCast(objScalar, Byte())
                Dim objSQLFs As New SqlTypes.SqlFileStream(pathObj, objTxCtx, IO.FileAccess.Read)
                lngSize = objSQLFs.Length
                objSQLFs.Close()
                objCMD.Transaction.Commit()

                semtblA_Blob_meta.upd_Blob_Size(objSemItem_File.GUID, lngSize)

            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If



        End If

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
            Try
                objCMD.Transaction.Rollback()
            Catch ex As Exception

            End Try


        End If
        
        Return objSemItem_Result
    End Function

    Public Function upd_CreationDate_Of_Blob(ByVal objSemItem_File As clsSemItem, ByVal dateCreate As Date) As clsSemItem
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        semtblA_Blob_meta.upd_Blob_CreationDate(objSemItem_File.GUID, dateCreate)

        Return objSemItem_Result
    End Function
    Public Function save_File_To_Blob(ByVal objSemItem_File As clsSemItem, ByVal strPath_File As String) As clsSemItem

        Dim objCMD As SqlClient.SqlCommand
        Dim objTX As SqlClient.SqlTransaction = Nothing
        Dim pathObj As Object
        Dim objSemItem_Result As clsSemItem
        Dim strFilePath As String = Nothing
        Dim objFileInfo As IO.FileInfo
        Dim objDRC_Create As DataRowCollection
        Dim lngSize As Long
        Dim strHash As String = ""



        objSemItem_Result = compare_File(strPath_File)
        If Not objSemItem_Result.GUID_Parent = objLocalConfig.SemItem_Type_File.GUID Then
            objSemItem_Result = objLocalConfig.Globals.LogState_Success

            If Not objLocalConfig.Connection_Blob.State = ConnectionState.Open Then
                objLocalConfig.Connection_Blob.Open()
            End If
            If semtblA_Blob_meta.Count_Blobs(objSemItem_File.GUID) = 0 Then
                objCMD = New SqlClient.SqlCommand("INSERT INTO semtbl_Blob (GUID_Blob, Data_Blob) VALUES ('" & objSemItem_File.GUID.ToString & "', CAST('' as varbinary(max)))", objLocalConfig.Connection_Blob, objTX)
                objCMD.ExecuteNonQuery()
            End If

            objCMD = New SqlClient.SqlCommand("SELECT Data_Blob.PathName() FROM semtbl_Blob WHERE GUID_Blob='" & objSemItem_File.GUID.ToString & "'", objLocalConfig.Connection_Blob, objTX)
            pathObj = objCMD.ExecuteScalar()
            If Not pathObj.Equals(DBNull.Value) Then
                strFilePath = DirectCast(pathObj, String)
            Else
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                objTX = objLocalConfig.Connection_Blob.BeginTransaction("mainTranaction")
                objCMD = New SqlClient.SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()", objLocalConfig.Connection_Blob, objTX)
            End If





            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                Dim objScalar As Object = objCMD.ExecuteScalar()
                '
                Dim objTxCtx As Byte()
                If Not objScalar.Equals(DBNull.Value) Then
                    objTxCtx = DirectCast(objScalar, Byte())

                    Dim objSQLFs As New SqlTypes.SqlFileStream(strFilePath, objTxCtx, IO.FileAccess.Write)
                    strPath_File = Environment.ExpandEnvironmentVariables(strPath_File)
                    objFileInfo = New IO.FileInfo(strPath_File)

                    Dim objFileStream As New IO.FileStream(strPath_File, IO.FileMode.Open, IO.FileAccess.Read)
                    Dim objBinaryReader As New IO.BinaryReader(objFileStream)
                    Dim lngPos As Long = 0

                    strHash = ""
                    Dim byteFile(9999) As Byte
                    While objFileStream.Position < objFileStream.Length
                        If objFileStream.Position + 10000 < objFileStream.Length Then
                            byteFile = objBinaryReader.ReadBytes(10000)
                            objSQLFs.Write(byteFile, 0, byteFile.Length)
                        Else
                            ReDim byteFile(objFileStream.Length - objFileStream.Position - 1)
                            lngPos = objFileStream.Length - objFileStream.Position
                            byteFile = objBinaryReader.ReadBytes(objFileStream.Length - objFileStream.Position)
                            objSQLFs.Write(byteFile, 0, lngPos)
                        End If
                    End While


                    objSQLFs.Flush()
                    objSQLFs.Close()
                    objFileStream.Position = 0
                    If objFileStream.Length > 4000 Then
                        ReDim byteFile(4000)
                        objFileStream.Seek(0, IO.SeekOrigin.Begin)
                        byteFile = objBinaryReader.ReadBytes(2000)
                        strHash = getHash(byteFile, 2000)
                        objFileStream.Seek(-2001, IO.SeekOrigin.End)
                        byteFile = objBinaryReader.ReadBytes(2000)
                        strHash = strHash & getHash(byteFile, 2000)
                    Else
                        ReDim byteFile(objFileStream.Length)
                        byteFile = objBinaryReader.ReadBytes(objFileStream.Length)
                        strHash = getHash(byteFile, objFileStream.Length)

                    End If
                    objBinaryReader.Close()
                    objFileStream.Close()

                    objCMD.Transaction.Commit()
                    objTX = objLocalConfig.Connection_Blob.BeginTransaction
                    semtblA_Blob_meta.Transaction = objTX
                    semtblA_Blob_meta.upd_Blob_Size(objSemItem_File.GUID, lngSize)
                    objTX.Commit()



                Else
                    objSemItem_Result = objLocalConfig.Globals.LogState_Error
                End If



            End If

            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                Try
                    objCMD.Transaction.Rollback()
                Catch ex As Exception

                End Try
                set_Blob_Off(objSemItem_File)
            Else
                objTX.Dispose()
                semtblA_Blob.update_Hash(objSemItem_File.GUID, strHash)

                If Not objFileInfo Is Nothing Then
                    upd_CreationDate_Of_Blob(objSemItem_File, objFileInfo.CreationTime)
                    objDRC_Create = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_File.GUID, _
                                                                                                                   objLocalConfig.SemItem_Attribute_Datetimestamp__Create_.GUID).Rows
                    If objDRC_Create.Count > 0 Then
                        semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_File.GUID, _
                                                                     objLocalConfig.SemItem_Attribute_Datetimestamp__Create_.GUID, _
                                                                     objDRC_Create(0).Item("GUID_TokenAttribute"), objFileInfo.CreationTime, 0)
                    Else
                        semprocA_DBWork_Save_TokenAttribute_Datetime.GetData(objSemItem_File.GUID, _
                                                                     objLocalConfig.SemItem_Attribute_Datetimestamp__Create_.GUID, _
                                                                     Nothing, objFileInfo.CreationTime, 0)
                    End If

                End If

                objSemItem_Result = set_Blob_On(objSemItem_File)
                If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Error.GUID Then
                    del_Blob(objSemItem_File)
                End If
            End If
        Else
            objSemItem_Result.GUID_Related = objSemItem_Result.GUID
            objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Relation.GUID
        End If

        
        Return objSemItem_Result
    End Function

    Private Function getHash(ByVal byteFile() As Byte, ByVal intLength As Integer) As String
        Dim byteHash() As Byte
        Dim strHash As String
        Dim objMD5 As Security.Cryptography.MD5

        objMD5 = New Security.Cryptography.MD5CryptoServiceProvider
        byteHash = objMD5.ComputeHash(byteFile, 0, intLength - 1)
        strHash = BitConverter.ToString(byteHash)

        Return strHash

    End Function

    Public Function set_Blob_On(ByVal objSemItem_File As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_BlobOn As DataRowCollection
        Dim objDR_BlobOn As DataRow
        Dim boolAdd As Boolean

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_BlobOn = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_File.GUID, objLocalConfig.SemItem_Attribute_Blob.GUID).Rows
        boolAdd = True
        If objDRC_BlobOn.Count > 0 Then
            boolAdd = False
            GUID_TokenAttribute_BlobOn = objDRC_BlobOn(0).Item("GUID_TokenAttribute")

            If objDRC_BlobOn.Count > 1 Then

                For i = 1 To objDRC_BlobOn.Count - 1
                    objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDRC_BlobOn(i).Item("GUID_TokenAttribute")).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                        Exit For
                    End If
                Next
            End If
            If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
                If objDRC_BlobOn(0).Item("Val_BOOL") = False Then
                    objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_File.GUID, _
                                                                                      objLocalConfig.SemItem_Attribute_Blob.GUID, _
                                                                                      objDRC_BlobOn(0).Item("GUID_TokenAttribute"), _
                                                                                      True, 0).Rows
                    If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                        objSemItem_Result = objLocalConfig.Globals.LogState_Error
                    End If
                End If
            End If
        End If

        If boolAdd = True Then
            objDRC_LogState = semprocA_DBWork_Save_TokenAttribute_Bit.GetData(objSemItem_File.GUID, _
                                                                              objLocalConfig.SemItem_Attribute_Blob.GUID, _
                                                                              Nothing, _
                                                                              True, 0).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
            End If
        End If

        Return objSemItem_Result
    End Function

    Public Function set_Blob_Off(ByVal objSemItem_File As clsSemItem) As clsSemItem
        Dim objSemItem_Result As clsSemItem
        Dim objDRC_LogState As DataRowCollection
        Dim objDRC_BlobOn As DataRowCollection
        Dim objDR_BlobOn As DataRow

        objSemItem_Result = objLocalConfig.Globals.LogState_Success

        objDRC_BlobOn = funcA_TokenAttribute_Named_By_GUIDToken.GetData_By_GUIDToken_And_GUIDAttribute(objSemItem_File.GUID, objLocalConfig.SemItem_Attribute_Blob.GUID).Rows

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        For Each objDR_BlobOn In objDRC_BlobOn
            objDRC_LogState = semprocA_DBWork_Del_TokenAttribute.GetData(objDR_BlobOn.Item("GUID_TokenAttribute")).Rows
            If objDRC_LogState(0).Item("GUID_Token") = objLocalConfig.Globals.LogState_Error.GUID Then
                objSemItem_Result = objLocalConfig.Globals.LogState_Error
                Exit For
            End If
        Next

        Return objSemItem_Result
    End Function

    Public Function del_Blob(ByVal objSemItem_File As clsSemItem) As clsSemItem
        Dim objCMD As SqlClient.SqlCommand
        Dim objTX As SqlClient.SqlTransaction = Nothing
        Dim pathObj As Object
        Dim objSemItem_Result As clsSemItem

        objSemItem_Result = objLocalConfig.Globals.LogState_Success
        If Not objLocalConfig.Connection_Blob.State = ConnectionState.Open Then
            objLocalConfig.Connection_Blob.Open()
        End If
        Try
            objCMD = New SqlClient.SqlCommand("DELETE FROM semtbl_Blob WHERE GUID_Blob='" & objSemItem_File.GUID.ToString & "'", objLocalConfig.Connection_Blob, objTX)
            pathObj = objCMD.ExecuteScalar()

        Catch ex As Exception
            objSemItem_Result = objLocalConfig.Globals.LogState_Error
        End Try

        If objSemItem_Result.GUID = objLocalConfig.Globals.LogState_Success.GUID Then
            objSemItem_Result = set_Blob_Off(objSemItem_File)
        End If
        Return objSemItem_Result
    End Function
End Class
