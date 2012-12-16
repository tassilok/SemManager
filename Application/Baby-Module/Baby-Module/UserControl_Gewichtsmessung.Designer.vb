<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Gewichtsmessung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Gewichtsmessung))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Del = New System.Windows.Forms.Button()
        Me.ImageList_Main = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel_State = New System.Windows.Forms.Panel()
        Me.Button_New = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Gewicht = New System.Windows.Forms.TextBox()
        Me.Label_Gewicht = New System.Windows.Forms.Label()
        Me.DateTimePicker_Zeitpunkt = New System.Windows.Forms.DateTimePicker()
        Me.Label_Zeitpunkt = New System.Windows.Forms.Label()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel_CountLBL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel_Count = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView_Gewichtsmessungen = New System.Windows.Forms.DataGridView()
        Me.BindingSource_Gewichtsmessung = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer_Gewicht = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip_State = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView_Gewichtsmessungen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Gewichtsmessung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStripContainer1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(641, 447)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_Del)
        Me.Panel1.Controls.Add(Me.Panel_State)
        Me.Panel1.Controls.Add(Me.Button_New)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox_Gewicht)
        Me.Panel1.Controls.Add(Me.Label_Gewicht)
        Me.Panel1.Controls.Add(Me.DateTimePicker_Zeitpunkt)
        Me.Panel1.Controls.Add(Me.Label_Zeitpunkt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 24)
        Me.Panel1.TabIndex = 0
        '
        'Button_Del
        '
        Me.Button_Del.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_Del.Enabled = False
        Me.Button_Del.ImageIndex = 2
        Me.Button_Del.ImageList = Me.ImageList_Main
        Me.Button_Del.Location = New System.Drawing.Point(410, 0)
        Me.Button_Del.Name = "Button_Del"
        Me.Button_Del.Size = New System.Drawing.Size(30, 24)
        Me.Button_Del.TabIndex = 8
        Me.Button_Del.UseVisualStyleBackColor = True
        '
        'ImageList_Main
        '
        Me.ImageList_Main.ImageStream = CType(resources.GetObject("ImageList_Main.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Main.Images.SetKeyName(0, "base_floppydisk_32.png")
        Me.ImageList_Main.Images.SetKeyName(1, "NewDocument_32x32.png")
        Me.ImageList_Main.Images.SetKeyName(2, "tasto_8_architetto_franc_01.png")
        '
        'Panel_State
        '
        Me.Panel_State.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_State.Location = New System.Drawing.Point(606, 0)
        Me.Panel_State.Name = "Panel_State"
        Me.Panel_State.Size = New System.Drawing.Size(29, 24)
        Me.Panel_State.TabIndex = 7
        '
        'Button_New
        '
        Me.Button_New.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_New.ImageIndex = 1
        Me.Button_New.ImageList = Me.ImageList_Main
        Me.Button_New.Location = New System.Drawing.Point(379, 0)
        Me.Button_New.Name = "Button_New"
        Me.Button_New.Size = New System.Drawing.Size(31, 24)
        Me.Button_New.TabIndex = 6
        Me.Button_New.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(366, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(13, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "g"
        '
        'TextBox_Gewicht
        '
        Me.TextBox_Gewicht.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox_Gewicht.Enabled = False
        Me.TextBox_Gewicht.Location = New System.Drawing.Point(266, 0)
        Me.TextBox_Gewicht.Name = "TextBox_Gewicht"
        Me.TextBox_Gewicht.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Gewicht.TabIndex = 3
        '
        'Label_Gewicht
        '
        Me.Label_Gewicht.AutoSize = True
        Me.Label_Gewicht.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label_Gewicht.Location = New System.Drawing.Point(206, 0)
        Me.Label_Gewicht.Name = "Label_Gewicht"
        Me.Label_Gewicht.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.Label_Gewicht.Size = New System.Drawing.Size(60, 17)
        Me.Label_Gewicht.TabIndex = 2
        Me.Label_Gewicht.Text = "x_Gewicht:"
        '
        'DateTimePicker_Zeitpunkt
        '
        Me.DateTimePicker_Zeitpunkt.CustomFormat = "dd.MM.yyy HH.mm.ss"
        Me.DateTimePicker_Zeitpunkt.Dock = System.Windows.Forms.DockStyle.Left
        Me.DateTimePicker_Zeitpunkt.Enabled = False
        Me.DateTimePicker_Zeitpunkt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Zeitpunkt.Location = New System.Drawing.Point(66, 0)
        Me.DateTimePicker_Zeitpunkt.Name = "DateTimePicker_Zeitpunkt"
        Me.DateTimePicker_Zeitpunkt.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker_Zeitpunkt.TabIndex = 1
        '
        'Label_Zeitpunkt
        '
        Me.Label_Zeitpunkt.AutoSize = True
        Me.Label_Zeitpunkt.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label_Zeitpunkt.Location = New System.Drawing.Point(0, 0)
        Me.Label_Zeitpunkt.Name = "Label_Zeitpunkt"
        Me.Label_Zeitpunkt.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.Label_Zeitpunkt.Size = New System.Drawing.Size(66, 17)
        Me.Label_Zeitpunkt.TabIndex = 0
        Me.Label_Zeitpunkt.Text = "x_Zeitpunkt:"
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DataGridView_Gewichtsmessungen)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(635, 361)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(3, 33)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(635, 411)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
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
        'DataGridView_Gewichtsmessungen
        '
        Me.DataGridView_Gewichtsmessungen.AllowUserToAddRows = False
        Me.DataGridView_Gewichtsmessungen.AllowUserToDeleteRows = False
        Me.DataGridView_Gewichtsmessungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Gewichtsmessungen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Gewichtsmessungen.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Gewichtsmessungen.Name = "DataGridView_Gewichtsmessungen"
        Me.DataGridView_Gewichtsmessungen.ReadOnly = True
        Me.DataGridView_Gewichtsmessungen.Size = New System.Drawing.Size(635, 361)
        Me.DataGridView_Gewichtsmessungen.TabIndex = 0
        '
        'Timer_Gewicht
        '
        Me.Timer_Gewicht.Interval = 300
        '
        'UserControl_Gewichtsmessung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UserControl_Gewichtsmessung"
        Me.Size = New System.Drawing.Size(641, 447)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView_Gewichtsmessungen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Gewichtsmessung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Gewicht As System.Windows.Forms.TextBox
    Friend WithEvents Label_Gewicht As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_Zeitpunkt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_Zeitpunkt As System.Windows.Forms.Label
    Friend WithEvents ImageList_Main As System.Windows.Forms.ImageList
    Friend WithEvents Button_New As System.Windows.Forms.Button
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel_CountLBL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel_Count As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView_Gewichtsmessungen As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource_Gewichtsmessung As System.Windows.Forms.BindingSource
    Friend WithEvents Timer_Gewicht As System.Windows.Forms.Timer
    Friend WithEvents Panel_State As System.Windows.Forms.Panel
    Friend WithEvents ToolTip_State As System.Windows.Forms.ToolTip
    Friend WithEvents Button_Del As System.Windows.Forms.Button

End Class
