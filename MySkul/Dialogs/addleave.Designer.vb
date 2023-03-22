<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addleave
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
        Me.cdelete = New Telerik.WinControls.UI.RadButton()
        Me.leavestart = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.leaveend = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtstaff = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtcid = New System.Windows.Forms.Label()
        Me.cmdclear = New Telerik.WinControls.UI.RadButton()
        Me.cmdadd = New Telerik.WinControls.UI.RadButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtleave = New Telerik.WinControls.UI.RadTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leavestart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.leaveend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdclear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtleave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cdelete
        '
        Me.cdelete.BackColor = System.Drawing.Color.Firebrick
        Me.cdelete.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdelete.ForeColor = System.Drawing.SystemColors.Control
        Me.cdelete.Location = New System.Drawing.Point(366, 268)
        Me.cdelete.Name = "cdelete"
        Me.cdelete.Size = New System.Drawing.Size(123, 36)
        Me.cdelete.TabIndex = 70
        Me.cdelete.Text = "Deactivate"
        Me.cdelete.ThemeName = "Material"
        '
        'leavestart
        '
        Me.leavestart.BackColor = System.Drawing.SystemColors.Control
        Me.leavestart.CalendarSize = New System.Drawing.Size(290, 320)
        Me.leavestart.Location = New System.Drawing.Point(106, 168)
        Me.leavestart.Name = "leavestart"
        Me.leavestart.Size = New System.Drawing.Size(383, 36)
        Me.leavestart.TabIndex = 63
        Me.leavestart.TabStop = False
        Me.leavestart.Text = "Thursday, May 7, 2020"
        Me.leavestart.ThemeName = "Material"
        Me.leavestart.Value = New Date(2020, 5, 7, 19, 2, 6, 885)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Leave Starts :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.leaveend)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cdelete)
        Me.Panel1.Controls.Add(Me.leavestart)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtstaff)
        Me.Panel1.Controls.Add(Me.txtcid)
        Me.Panel1.Controls.Add(Me.cmdclear)
        Me.Panel1.Controls.Add(Me.cmdadd)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtleave)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(511, 325)
        Me.Panel1.TabIndex = 3
        '
        'leaveend
        '
        Me.leaveend.BackColor = System.Drawing.SystemColors.Control
        Me.leaveend.CalendarSize = New System.Drawing.Size(290, 320)
        Me.leaveend.Location = New System.Drawing.Point(106, 217)
        Me.leaveend.Name = "leaveend"
        Me.leaveend.Size = New System.Drawing.Size(383, 36)
        Me.leaveend.TabIndex = 72
        Me.leaveend.TabStop = False
        Me.leaveend.Text = "Thursday, May 7, 2020"
        Me.leaveend.ThemeName = "Material"
        Me.leaveend.Value = New Date(2020, 5, 7, 19, 2, 6, 885)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Leave Ends :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Staff Name :"
        '
        'txtstaff
        '
        Me.txtstaff.AutoSize = False
        Me.txtstaff.BackColor = System.Drawing.SystemColors.Control
        Me.txtstaff.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.txtstaff.Location = New System.Drawing.Point(106, 70)
        Me.txtstaff.Name = "txtstaff"
        Me.txtstaff.Size = New System.Drawing.Size(383, 36)
        Me.txtstaff.TabIndex = 60
        Me.txtstaff.ThemeName = "Material"
        '
        'txtcid
        '
        Me.txtcid.AutoSize = True
        Me.txtcid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcid.Location = New System.Drawing.Point(109, 41)
        Me.txtcid.Name = "txtcid"
        Me.txtcid.Size = New System.Drawing.Size(0, 18)
        Me.txtcid.TabIndex = 55
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdclear.Location = New System.Drawing.Point(214, 268)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(120, 36)
        Me.cmdclear.TabIndex = 49
        Me.cmdclear.Text = "Clear"
        Me.cmdclear.ThemeName = "Material"
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdadd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdadd.Location = New System.Drawing.Point(37, 268)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(120, 36)
        Me.cmdadd.TabIndex = 47
        Me.cmdadd.Text = "Save"
        Me.cmdadd.ThemeName = "Material"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Staff ID :"
        '
        'txtleave
        '
        Me.txtleave.AutoSize = False
        Me.txtleave.BackColor = System.Drawing.SystemColors.Control
        Me.txtleave.Location = New System.Drawing.Point(106, 119)
        Me.txtleave.Name = "txtleave"
        Me.txtleave.Size = New System.Drawing.Size(383, 36)
        Me.txtleave.TabIndex = 7
        Me.txtleave.ThemeName = "Material"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Leave Type :"
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
        Me.Panel3.Size = New System.Drawing.Size(509, 24)
        Me.Panel3.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "ADD A CHEQUE"
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
        Me.Label1.Location = New System.Drawing.Point(486, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'addleave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 325)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addleave"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "0"
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leavestart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.leaveend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdclear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtleave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cdelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents leavestart As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtcid As Label
    Friend WithEvents cmdclear As Telerik.WinControls.UI.RadButton
    Friend WithEvents cmdadd As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtleave As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents leaveend As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtstaff As Telerik.WinControls.UI.RadDropDownList
End Class
