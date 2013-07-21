Imports Filesystem_Management
Imports Sem_Manager

Module modMain

    Private semtblA_Token As New ds_SemDBTableAdapters.semtbl_TokenTableAdapter
    Private objGlobals As clsGlobals


    Private objFileWork As clsFileWork
    Private objBlobConnection As clsBlobConnection
    Private objLocalConfig As Filesystem_Management.clsLocalConfig_FileManager

    Sub Main(ByVal args() As String)
        Dim strFunction As String
        Dim strPath As String
        Dim strPathFolder As String
        Dim strGUID_File As String
        Dim objDRC_File As DataRowCollection
        Dim objSemItem_File As clsSemItem
        Dim objSemItem_Result As clsSemItem

        set_DBConnection()

        If args.Count = 3 Then
            strFunction = args(0)
            strPath = args(1)
            strGUID_File = args(2)

            If Not strFunction.ToLower = "export" Then
                out_Syntax()
            Else
                If Not objGlobals.is_GUID(strGUID_File) Then
                    Console.WriteLine("The GUID is not valid!")
                    Console.WriteLine()
                    out_Syntax()
                Else
                    objSemItem_File = New clsSemItem
                    objSemItem_File.GUID = New Guid(strGUID_File)
                    objDRC_File = semtblA_Token.GetData_Token_By_GUID(objSemItem_File.GUID).Rows

                    If objDRC_File.Count = 0 Then
                        Console.WriteLine("The File doesen't exist!")
                        Console.WriteLine()
                        out_Syntax()
                        Environment.Exit(-1)
                    Else
                        If Not objDRC_File(0).Item("GUID_Type") = objLocalConfig.SemItem_Type_File.GUID Then
                            Console.WriteLine("The GUID relates to no file!")
                            Console.WriteLine()
                            out_Syntax()
                            Environment.Exit(-1)
                        Else
                            objSemItem_File.Name = objDRC_File(0).Item("Name_Token")
                            objSemItem_File.GUID_Parent = objDRC_File(0).Item("GUID_Type")
                            objSemItem_File.GUID_Type = objGlobals.ObjectReferenceType_Token.GUID

                            If objFileWork.is_File_Blob(objSemItem_File) = False Then
                                objSemItem_File.Additional1 = objFileWork.get_Path_FileSystemObject(objSemItem_File, False)
                                If Not IO.File.Exists(objSemItem_File.Additional1) Then
                                    Console.WriteLine("The sourcefile is not present!")
                                    Console.WriteLine()
                                    out_Syntax()
                                    Environment.Exit(-1)
                                End If
                            End If

                            strPathFolder = IO.Path.GetDirectoryName(strPath)


                            Try
                                If IO.Directory.Exists(strPathFolder) = False Then
                                    IO.Directory.CreateDirectory(strPathFolder)
                                End If
                            Catch ex As Exception
                                Console.WriteLine("The Path is not valid!")
                                Console.WriteLine()
                                out_Syntax()
                                Environment.Exit(-1)
                            End Try


                            If objSemItem_File.Additional1 = "" Then
                                objSemItem_Result = objBlobConnection.save_Blob_To_File(objSemItem_File, strPath)
                                If objSemItem_Result.GUID = objGlobals.LogState_Error.GUID Then
                                    Console.WriteLine("The File cannot be saved!")
                                    Console.WriteLine()
                                    out_Syntax()
                                    Environment.Exit(-1)
                                End If
                            Else
                                Try
                                    IO.File.Copy(objSemItem_File.Additional1, strPath, True)
                                Catch ex As Exception
                                    Console.WriteLine("The File cannot be saved!")
                                    Console.WriteLine()
                                    out_Syntax()
                                    Environment.Exit(-1)
                                End Try


                            End If
                        End If

                    End If
                    

                End If
                
                
            End If
        Else
            out_Syntax()
        End If
    End Sub


    Private Sub out_Syntax()
        Console.WriteLine("Syntax: " & AppDomain.CurrentDomain.FriendlyName & ": [Export] [Laufwerk]:[Pfad][Dateiname] [GUID_File]")
    End Sub

    Private Sub set_DBConnection()
        objGlobals = New clsGlobals(False, AppDomain.CurrentDomain.BaseDirectory & "\")
        semtblA_Token.Connection = New SqlClient.SqlConnection(objGlobals.ConnectionString_User)
        objFileWork = New clsFileWork(objGlobals)
        objLocalConfig = New clsLocalConfig_FileManager(objGlobals)
        objBlobConnection = New clsBlobConnection(objLocalConfig)
    End Sub

End Module
