Public Class frmImageSingle

    Public Sub New(ByRef objImage As Image)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        PictureBox_Images.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox_Images.Image = objImage
    End Sub

    Public Sub change_Image(ByVal objImage As Image)
        PictureBox_Images.Image.Dispose()
        PictureBox_Images.Image = objImage
    End Sub
End Class