<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_ObjectRelTree
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_ObjectRelTree))
        Me.TreeView_ObjectRels = New System.Windows.Forms.TreeView()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'TreeView_ObjectRels
        '
        Me.TreeView_ObjectRels.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_ObjectRels.ImageIndex = 0
        Me.TreeView_ObjectRels.ImageList = Me.ImageList_Main
        Me.TreeView_ObjectRels.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_ObjectRels.Name = "TreeView_ObjectRels"
        Me.TreeView_ObjectRels.SelectedImageIndex = 0
        Me.TreeView_ObjectRels.Size = New System.Drawing.Size(351, 390)
        Me.TreeView_ObjectRels.TabIndex = 0
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ImageStream = CType(resources.GetObject("ImageList_Main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Main.Images.SetKeyName(0, "Empty.png")
        Me.ImageList_Main.Images.SetKeyName(1, "pulsante_02_architetto_f_01.png")
        '
        'UserControl_ObjectRelTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TreeView_ObjectRels)
        Me.Name = "UserControl_ObjectRelTree"
        Me.Size = New System.Drawing.Size(351, 390)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView_ObjectRels As System.Windows.Forms.TreeView
    Friend WithEvents ImageList_Main As System.Windows.Forms.ImageList

End Class
