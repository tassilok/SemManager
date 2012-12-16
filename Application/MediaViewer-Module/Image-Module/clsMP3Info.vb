Imports System.IO
Public Class clsMP3Info

    Private objLocalConfig As clsLocalConfig
    Private mFileName As String

    ''' <summary>
    ''' Diese Funktion ließt den ID3v1 Tag aus einer MP3 Datei aus
    ''' </summary>
    ''' <param name="FileName">Die MP3 Datei</param>
    ''' <returns>Eine Instanz vom Typ ID3V1 mit den Informationen</returns>
    Public Function GetID3v1Tag(Optional ByVal FileName As String = "") As ID3V1
        Dim FS As FileStream
        Dim BinReader As BinaryReader
        Dim Buffer() As Byte
        Dim Tag As New ID3V1(objLocalConfig)
        Dim byteGenre As Byte

        If FileName = "" Then FileName = mFileName

        FS = New FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)

        BinReader = New BinaryReader(FS)

        'Der ID3v1 Tag befindet sich in den letzten 128 Bytes der Datei
        FS.Seek(-128, SeekOrigin.End)
        If (ByteToString(BinReader.ReadBytes(3)).ToUpper = "TAG") Then

            Tag.TagAvailable = True

            With Tag
                .Title = ByteToString(BinReader.ReadBytes(30)).Replace(Chr(0), "")
                .Artist = ByteToString(BinReader.ReadBytes(30)).Replace(Chr(0), "")
                .Album = ByteToString(BinReader.ReadBytes(30)).Replace(Chr(0), "")
                .Year = ByteToString(BinReader.ReadBytes(4)).Replace(Chr(0), "")

                'Wenn Byte 28 == 0 und Byte 29 <> 0 dann ist es die Version 1.1 ansonsten 1.0
                Buffer = BinReader.ReadBytes(30)
                If ((Buffer(28) = 0) And (Buffer(29) <> 0)) Then
                    .TagVersion = ID3V1.ID3Version.ID3V11
                    .Comment = ByteToString(Buffer, 0, 28).Replace(Chr(0), "")
                    .Track = Buffer(29)
                Else
                    .TagVersion = ID3V1.ID3Version.ID3V10
                    .Comment = ByteToString(Buffer).Replace(Chr(0), "")
                    .Track = 0
                End If
                byteGenre = BinReader.ReadByte
                If byteGenre = 0 Then

                Else
                    .Genre = byteGenre
                End If

            End With

        End If

        BinReader.Close()
        FS.Close()

        Return Tag
    End Function


    
    ''' <summary>
    ''' Diese Funktion schreibt die ID3v1 Daten aus einer ID3V1 Instanz in eine MP3 Datei
    ''' </summary>
    ''' <param name="Tag">Die Instanz mit den ID3v1 Tag-Daten</param>
    ''' <param name="FileName">Die MP3 Datei in der die Informationen geschrieben werden sollen</param>
    Public Sub SetID3v1Tag(ByVal Tag As ID3V1, Optional ByVal FileName As String = "")
        Dim FS As FileStream
        Dim BinReader As BinaryReader
        Dim BinWriter As BinaryWriter

        If FileName = "" Then FileName = mFileName

        FS = New FileStream(FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)

        BinReader = New BinaryReader(FS)

        FS.Seek(-128, SeekOrigin.End)
        If (ByteToString(BinReader.ReadBytes(3)).ToUpper = "TAG") Then
            'TAG gefunden, also 3 Schritte in der Datei zurück
            FS.Seek(-3, SeekOrigin.Current)
        Else
            'Kein TAG gefunden als ans ende Der Datei schreiben
            FS.Seek(0, SeekOrigin.End)
        End If

        BinWriter = New BinaryWriter(FS)

        BinWriter.Write("TAG".ToCharArray)
        BinWriter.Write(Tag.Title.PadRight(30, Chr(0)).ToCharArray)
        BinWriter.Write(Tag.Artist.PadRight(30, Chr(0)).ToCharArray)
        BinWriter.Write(Tag.Album.PadRight(30, Chr(0)).ToCharArray)
        BinWriter.Write(Tag.Year.PadRight(4, Chr(0)).ToCharArray)
        Select Case Tag.TagVersion
            Case ID3V1.ID3Version.ID3V10
                BinWriter.Write(Tag.Comment.PadRight(30, Chr(0)).ToCharArray)
            Case ID3V1.ID3Version.ID3V11
                BinWriter.Write(Tag.Comment.PadRight(28, Chr(0)).ToCharArray)
                BinWriter.Write(Chr(0))
                BinWriter.Write(Tag.Track)
        End Select
        BinWriter.Write(Tag.Genre)
        BinWriter.Flush()

        BinWriter.Close()
        BinReader.Close()
    End Sub

    Private Function ByteToString(ByVal Expression() As Byte, Optional ByVal Index As Integer = 0, Optional ByVal Length As Integer = 0) As String
        If Length = 0 Then Length = Expression.Length
        Return System.Text.Encoding.Default.GetString(Expression, Index, Length)
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
    End Sub
End Class

''' <summary>
''' Eine Klasse um ID3v1 Informationen von MP3 Dateien zu speichern
''' </summary>
Public Class ID3V1
    Private objLocalConfig As clsLocalConfig

    Private procA_Genre As New ds_ImageModuleTableAdapters.proc_GenreTableAdapter
    Private procT_Genre As New ds_ImageModule.proc_GenreDataTable

    Private mTagAvailable As Boolean
    Private mTagVersion As ID3Version
    Private mArtist As String
    Private mTitle As String
    Private mAlbum As String
    Private mYear As String
    Private mComment As String
    Private mGenre As Byte
    Private mGenreName As String
    Private mTrack As Byte

    Public Property TagAvailable() As Boolean
        Get
            Return mTagAvailable
        End Get
        Set(ByVal value As Boolean)
            mTagAvailable = value
        End Set
    End Property

    Public Property TagVersion() As ID3Version
        Get
            Return mTagVersion
        End Get
        Set(ByVal value As ID3Version)
            mTagVersion = value
        End Set
    End Property

    Public Property Artist() As String
        Get
            Return mArtist
        End Get
        Set(ByVal value As String)
            mArtist = value
        End Set
    End Property

    Public Property Title() As String
        Get
            Return mTitle
        End Get
        Set(ByVal value As String)
            mTitle = value
        End Set
    End Property

    Public Property Album() As String
        Get
            Return mAlbum
        End Get
        Set(ByVal value As String)
            mAlbum = value
        End Set
    End Property

    Public Property Year() As String
        Get
            Return mYear
        End Get
        Set(ByVal value As String)
            mYear = value
        End Set
    End Property

    Public Property Comment() As String
        Get
            Return mComment
        End Get
        Set(ByVal value As String)
            mComment = value
        End Set
    End Property

    Public Property Genre() As Byte
        Get
            Return mGenre
        End Get
        Set(ByVal value As Byte)
            mGenre = value
            mGenreName = GetGenreName(value)
        End Set
    End Property

    Public ReadOnly Property GenreName() As String
        Get
            Return mGenreName
        End Get
    End Property

    Public Property Track() As Byte
        Get
            Return mTrack
        End Get
        Set(ByVal value As Byte)
            mTrack = value
        End Set
    End Property

    Public Enum ID3Version As Integer
        ID3V10 = 10
        ID3V11 = 11
    End Enum

    Public Function GetGenreName(ByVal Number As Byte) As String
        Dim objDRs_Genre() As DataRow

        objDRs_Genre = procT_Genre.Select("ID=" & Number)
        If objDRs_Genre.Count > 0 Then
            Return objDRs_Genre(0).Item("Name_Genre")
        Else
            Return Nothing
        End If

        
    End Function

    Public Sub New(ByVal LocalConfig As clsLocalConfig)
        objLocalConfig = LocalConfig
        initialize()
    End Sub

    Private Sub initialize()
        set_DBConnection()

        procA_Genre.Fill(procT_Genre, _
                         objLocalConfig.SemItem_Type_Genre.GUID, _
                         objLocalConfig.SemItem_Attribute_ID.GUID)
    End Sub

    Private Sub set_DBConnection()
        procA_Genre.Connection = objLocalConfig.Connection_Plugin

    End Sub
End Class
