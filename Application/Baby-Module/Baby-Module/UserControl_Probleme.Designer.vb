<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Probleme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Probleme))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker_Start = New System.Windows.Forms.DateTimePicker()
        Me.Label_Start = New System.Windows.Forms.Label()
        Me.DateTimePicker_Ende = New System.Windows.Forms.DateTimePicker()
        Me.Label_Ende = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Del = New System.Windows.Forms.Button()
        Me.Button_New = New System.Windows.Forms.Button()
        Me.Label_ProblemArt = New System.Windows.Forms.Label()
        Me.ComboBox_Problemarten = New System.Windows.Forms.ComboBox()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Count = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView_Probleme = New System.Windows.Forms.DataGridView()
        Me.BindingSource_Probleme = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_Probleme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Probleme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStripContainer1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(594, 491)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_Save)
        Me.Panel1.Controls.Add(Me.Button_Del)
        Me.Panel1.Controls.Add(Me.Button_New)
        Me.Panel1.Controls.Add(Me.DateTimePicker_Ende)
        Me.Panel1.Controls.Add(Me.Label_Ende)
        Me.Panel1.Controls.Add(Me.DateTimePicker_Start)
        Me.Panel1.Controls.Add(Me.Label_Start)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(588, 24)
        Me.Panel1.TabIndex = 0
        '
        'DateTimePicker_Start
        '
        Me.DateTimePicker_Start.CustomFormat = "dd.MM.yyy HH.mm.ss"
        Me.DateTimePicker_Start.Enabled = False
        Me.DateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Start.Location = New System.Drawing.Point(66, 1)
        Me.DateTimePicker_Start.Name = "DateTimePicker_Start"
        Me.DateTimePicker_Start.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker_Start.TabIndex = 5
        '
        'Label_Start
        '
        Me.Label_Start.AutoSize = True
        Me.Label_Start.Location = New System.Drawing.Point(2, 1)
        Me.Label_Start.Name = "Label_Start"
        Me.Label_Start.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.Label_Start.Size = New System.Drawing.Size(43, 17)
        Me.Label_Start.TabIndex = 4
        Me.Label_Start.Text = "x_Start:"
        '
        'DateTimePicker_Ende
        '
        Me.DateTimePicker_Ende.CustomFormat = "dd.MM.yyy HH.mm.ss"
        Me.DateTimePicker_Ende.Enabled = False
        Me.DateTimePicker_Ende.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Ende.Location = New System.Drawing.Point(257, 1)
        Me.DateTimePicker_Ende.Name = "DateTimePicker_Ende"
        Me.DateTimePicker_Ende.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker_Ende.TabIndex = 7
        '
        'Label_Ende
        '
        Me.Label_Ende.AutoSize = True
        Me.Label_Ende.Location = New System.Drawing.Point(212, 1)
        Me.Label_Ende.Name = "Label_Ende"
        Me.Label_Ende.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.Label_Ende.Size = New System.Drawing.Size(46, 17)
        Me.Label_Ende.TabIndex = 6
        Me.Label_Ende.Text = "x_Ende:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ComboBox_Problemarten)
        Me.Panel2.Controls.Add(Me.Label_ProblemArt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(588, 24)
        Me.Panel2.TabIndex = 1
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ImageStream = CType(resources.GetObject("ImageList_Main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Main.Images.SetKeyName(0, "base_floppydisk_32.png")
        Me.ImageList_Main.Images.SetKeyName(1, "NewDocument_32x32.png")
        Me.ImageList_Main.Images.SetKeyName(2, "tasto_8_architetto_franc_01.png")
        '
        'Button_Save
        '
        Me.Button_Save.ImageIndex = 0
        Me.Button_Save.ImageList = Me.ImageList_Main
        Me.Button_Save.Location = New System.Drawing.Point(481, 0)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(30, 24)
        Me.Button_Save.TabIndex = 17
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Del
        '
        Me.Button_Del.Enabled = False
        Me.Button_Del.ImageIndex = 2
        Me.Button_Del.ImageList = Me.ImageList_Main
        Me.Button_Del.Location = New System.Drawing.Point(557, 0)
        Me.Button_Del.Name = "Button_Del"
        Me.Button_Del.Size = New System.Drawing.Size(30, 24)
        Me.Button_Del.TabIndex = 16
        Me.Button_Del.UseVisualStyleBackColor = True
        '
        'Button_New
        '
        Me.Button_New.ImageIndex = 1
        Me.Button_New.ImageList = Me.ImageList_Main
        Me.Button_New.Location = New System.Drawing.Point(527, 0)
        Me.Button_New.Name = "Button_New"
        Me.Button_New.Size = New System.Drawing.Size(31, 24)
        Me.Button_New.TabIndex = 15
        Me.Button_New.UseVisualStyleBackColor = True
        '
        'Label_ProblemArt
        '
        Me.Label_ProblemArt.AutoSize = True
        Me.Label_ProblemArt.Location = New System.Drawing.Point(2, 5)
        Me.Label_ProblemArt.Name = "Label_ProblemArt"
        Me.Label_ProblemArt.Size = New System.Drawing.Size(59, 13)
        Me.Label_ProblemArt.TabIndex = 0
        Me.Label_ProblemArt.Text = "x_Problem:"
        '
        'ComboBox_Problemarten
        '
        Me.ComboBox_Problemarten.FormattingEnabled = True
        Me.ComboBox_Problemarten.Location = New System.Drawing.Point(68, 2)
        Me.ComboBox_Problemarten.Name = "ComboBox_Problemarten"
        Me.ComboBox_Problemarten.Size = New System.Drawing.Size(329, 21)
        Me.ComboBox_Problemarten.TabIndex = 1
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_Probleme)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(588, 400)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(3, 63)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(588, 425)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel_CountLBL, Me.ToolStripLabel_Count})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(78, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel_CountLBL
        '
        Me.ToolStripLabel_CountLBL.Name = "ToolStripLabel_CountLBL"
        Me.ToolStripLabel_CountLBL.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel_CountLBL.Text = "x_Count:"
        '
        'ToolStripLabel_Count
        '
        Me.ToolStripLabel_Count.Name = "ToolStripLabel_Count"
        Me.ToolStripLabel_Count.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripLabel_Count.Text = "0"
        '
        'DataGridView_Probleme
        '
        Me.DataGridView_Probleme.AllowUserToAddRows = False
        Me.DataGridView_Probleme.AllowUserToDeleteRows = False
        Me.DataGridView_Probleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Probleme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Probleme.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Probleme.Name = "DataGridView_Probleme"
        Me.DataGridView_Probleme.ReadOnly = True
        Me.DataGridView_Probleme.Size = New System.Drawing.Size(588, 400)
        Me.DataGridView_Probleme.TabIndex = 0
        '
        'UserControl_Probleme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UserControl_Probleme"
        Me.Size = New System.Drawing.Size(594, 491)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_Probleme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Probleme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker_Ende As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_Ende As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_Start As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_Start As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ImageList_Main As System.Windows.Forms.ImageList
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents Button_Del As System.Windows.Forms.Button
    Friend WithEvents Button_New As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Problemarten As System.Windows.Forms.ComboBox
    Friend WithEvents Label_ProblemArt As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Count As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_Probleme As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_Probleme As System.Windows.Forms.BindingSource

End Class
