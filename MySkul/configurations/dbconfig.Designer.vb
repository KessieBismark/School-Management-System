<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dbconfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.result = New System.Windows.Forms.Label()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.save = New Telerik.WinControls.UI.RadButton()
        Me.read = New Telerik.WinControls.UI.RadButton()
        Me.pword = New Telerik.WinControls.UI.RadTextBox()
        Me.uname = New Telerik.WinControls.UI.RadTextBox()
        Me.dbname = New Telerik.WinControls.UI.RadTextBox()
        Me.sname = New Telerik.WinControls.UI.RadTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.read, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(571, 24)
        Me.Panel3.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(145, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "DATABASE SETTINGS"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(4, 4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 16)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Label19 -"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(543, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 328)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Controls.Add(Me.RadButton2)
        Me.GroupBox3.Controls.Add(Me.result)
        Me.GroupBox3.Controls.Add(Me.RadButton1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(309, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(250, 312)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(19, 65)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(193, 36)
        Me.RadButton2.TabIndex = 11
        Me.RadButton2.Text = "Check internet status"
        Me.RadButton2.ThemeName = "Material"
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Location = New System.Drawing.Point(6, 267)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(49, 16)
        Me.result.TabIndex = 10
        Me.result.Text = "Label8"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(19, 209)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(193, 36)
        Me.RadButton1.TabIndex = 5
        Me.RadButton1.Text = "Establish connection"
        Me.RadButton1.ThemeName = "Material"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "External Database"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(76, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 16)
        Me.Label10.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Internet:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.save)
        Me.GroupBox1.Controls.Add(Me.read)
        Me.GroupBox1.Controls.Add(Me.pword)
        Me.GroupBox1.Controls.Add(Me.uname)
        Me.GroupBox1.Controls.Add(Me.dbname)
        Me.GroupBox1.Controls.Add(Me.sname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 312)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database Connection String"
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(17, 273)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(82, 36)
        Me.save.TabIndex = 15
        Me.save.Text = "Save"
        Me.save.ThemeName = "Material"
        '
        'read
        '
        Me.read.Location = New System.Drawing.Point(160, 273)
        Me.read.Name = "read"
        Me.read.Size = New System.Drawing.Size(108, 36)
        Me.read.TabIndex = 14
        Me.read.Text = "Read file"
        Me.read.ThemeName = "Material"
        '
        'pword
        '
        Me.pword.AutoSize = False
        Me.pword.Location = New System.Drawing.Point(11, 233)
        Me.pword.Name = "pword"
        Me.pword.Size = New System.Drawing.Size(257, 36)
        Me.pword.TabIndex = 13
        Me.pword.ThemeName = "Material"
        '
        'uname
        '
        Me.uname.AutoSize = False
        Me.uname.Location = New System.Drawing.Point(11, 175)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(257, 36)
        Me.uname.TabIndex = 12
        Me.uname.ThemeName = "Material"
        '
        'dbname
        '
        Me.dbname.AutoSize = False
        Me.dbname.Location = New System.Drawing.Point(11, 115)
        Me.dbname.Name = "dbname"
        Me.dbname.Size = New System.Drawing.Size(257, 36)
        Me.dbname.TabIndex = 11
        Me.dbname.ThemeName = "Material"
        '
        'sname
        '
        Me.sname.AutoSize = False
        Me.sname.Location = New System.Drawing.Point(11, 56)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(257, 36)
        Me.sname.TabIndex = 10
        Me.sname.ThemeName = "Material"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "UserID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Database Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Server Name:"
        '
        'dbconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 352)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dbconfig"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.read, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents result As Label
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents save As Telerik.WinControls.UI.RadButton
    Friend WithEvents read As Telerik.WinControls.UI.RadButton
    Friend WithEvents pword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents uname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dbname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents sname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
