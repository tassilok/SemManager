<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_AttributeRelations
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
        Me.components = New System.ComponentModel.Container
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.DataGridView_Types = New System.Windows.Forms.DataGridView
        Me.Label_Types = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.DataGridView_Token = New System.Windows.Forms.DataGridView
        Me.Label_Token = New System.Windows.Forms.Label
        Me.DataGridView_ObjectReference = New System.Windows.Forms.DataGridView
        Me.Label_ObjectReference = New System.Windows.Forms.Label
        Me.BindingSource_Types = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_Token = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource_ObjectReference = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView_Types, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView_Token, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_ObjectReference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Types, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Token, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_ObjectReference, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView_Types)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_Types)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(336, 389)
        Me.SplitContainer1.SplitterDistance = 112
        Me.SplitContainer1.TabIndex = 0
        '
        'DataGridView_Types
        '
        Me.DataGridView_Types.AllowUserToAddRows = False
        Me.DataGridView_Types.AllowUserToDeleteRows = False
        Me.DataGridView_Types.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Types.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Types.Location = New System.Drawing.Point(4, 21)
        Me.DataGridView_Types.Name = "DataGridView_Types"
        Me.DataGridView_Types.ReadOnly = True
        Me.DataGridView_Types.Size = New System.Drawing.Size(325, 84)
        Me.DataGridView_Types.TabIndex = 1
        '
        'Label_Types
        '
        Me.Label_Types.AutoSize = True
        Me.Label_Types.Location = New System.Drawing.Point(4, 4)
        Me.Label_Types.Name = "Label_Types"
        Me.Label_Types.Size = New System.Drawing.Size(90, 13)
        Me.Label_Types.TabIndex = 0
        Me.Label_Types.Text = "x_Related Types:"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DataGridView_Token)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label_Token)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView_ObjectReference)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label_ObjectReference)
        Me.SplitContainer2.Size = New System.Drawing.Size(336, 273)
        Me.SplitContainer2.SplitterDistance = 112
        Me.SplitContainer2.TabIndex = 0
        '
        'DataGridView_Token
        '
        Me.DataGridView_Token.AllowUserToAddRows = False
        Me.DataGridView_Token.AllowUserToDeleteRows = False
        Me.DataGridView_Token.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Token.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Token.Location = New System.Drawing.Point(4, 21)
        Me.DataGridView_Token.Name = "DataGridView_Token"
        Me.DataGridView_Token.ReadOnly = True
        Me.DataGridView_Token.Size = New System.Drawing.Size(325, 84)
        Me.DataGridView_Token.TabIndex = 3
        '
        'Label_Token
        '
        Me.Label_Token.AutoSize = True
        Me.Label_Token.Location = New System.Drawing.Point(4, 4)
        Me.Label_Token.Name = "Label_Token"
        Me.Label_Token.Size = New System.Drawing.Size(92, 13)
        Me.Label_Token.TabIndex = 2
        Me.Label_Token.Text = "x_Related Token:"
        '
        'DataGridView_ObjectReference
        '
        Me.DataGridView_ObjectReference.AllowUserToAddRows = False
        Me.DataGridView_ObjectReference.AllowUserToDeleteRows = False
        Me.DataGridView_ObjectReference.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_ObjectReference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ObjectReference.Location = New System.Drawing.Point(4, 20)
        Me.DataGridView_ObjectReference.Name = "DataGridView_ObjectReference"
        Me.DataGridView_ObjectReference.ReadOnly = True
        Me.DataGridView_ObjectReference.Size = New System.Drawing.Size(325, 130)
        Me.DataGridView_ObjectReference.TabIndex = 5
        '
        'Label_ObjectReference
        '
        Me.Label_ObjectReference.AutoSize = True
        Me.Label_ObjectReference.Location = New System.Drawing.Point(4, 4)
        Me.Label_ObjectReference.Name = "Label_ObjectReference"
        Me.Label_ObjectReference.Size = New System.Drawing.Size(145, 13)
        Me.Label_ObjectReference.TabIndex = 4
        Me.Label_ObjectReference.Text = "x_Related Object-Reference:"
        '
        'UserControl_AttributeRelations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UserControl_AttributeRelations"
        Me.Size = New System.Drawing.Size(336, 389)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView_Types, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView_Token, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_ObjectReference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Types, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Token, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_ObjectReference, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView_Types As System.Windows.Forms.DataGridView
    Friend WithEvents Label_Types As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView_Token As System.Windows.Forms.DataGridView
    Friend WithEvents Label_Token As System.Windows.Forms.Label
    Friend WithEvents DataGridView_ObjectReference As System.Windows.Forms.DataGridView
    Friend WithEvents Label_ObjectReference As System.Windows.Forms.Label
    Friend WithEvents BindingSource_Types As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource_Token As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource_ObjectReference As System.Windows.Forms.BindingSource

End Class
