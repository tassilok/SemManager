﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchResult
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.Panel_SearchResults = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Panel_SearchResults
        '
        Me.Panel_SearchResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_SearchResults.Location = New System.Drawing.Point(0, 0)
        Me.Panel_SearchResults.Name = "Panel_SearchResults"
        Me.Panel_SearchResults.Size = New System.Drawing.Size(800, 402)
        Me.Panel_SearchResults.TabIndex = 0
        '
        'frmSearchResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 402)
        Me.Controls.Add(Me.Panel_SearchResults)
        Me.Name = "frmSearchResult"
        Me.Text = "frmSearchResult"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_SearchResults As System.Windows.Forms.Panel
End Class
