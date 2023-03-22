<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eventsact
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
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcom = New Telerik.WinControls.UI.RadTextBox()
        Me.txteventname = New Telerik.WinControls.UI.RadTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txteid = New Telerik.WinControls.UI.RadTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdclear = New Telerik.WinControls.UI.RadButton()
        Me.cmddelete = New Telerik.WinControls.UI.RadButton()
        Me.cmdadd = New Telerik.WinControls.UI.RadButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtet = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.txtst = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.txtcom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txteventname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txteid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdclear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmddelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Comment :"
        '
        'txtcom
        '
        Me.txtcom.AutoSize = False
        Me.txtcom.BackColor = System.Drawing.SystemColors.Control
        Me.txtcom.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcom.Location = New System.Drawing.Point(113, 206)
        Me.txtcom.Name = "txtcom"
        Me.txtcom.Size = New System.Drawing.Size(315, 103)
        Me.txtcom.TabIndex = 54
        Me.txtcom.ThemeName = "Material"
        '
        'txteventname
        '
        Me.txteventname.AutoSize = False
        Me.txteventname.BackColor = System.Drawing.SystemColors.Control
        Me.txteventname.Location = New System.Drawing.Point(113, 165)
        Me.txteventname.Name = "txteventname"
        Me.txteventname.Size = New System.Drawing.Size(315, 36)
        Me.txteventname.TabIndex = 53
        Me.txteventname.ThemeName = "Material"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Event Name :"
        '
        'txteid
        '
        Me.txteid.AutoSize = False
        Me.txteid.BackColor = System.Drawing.SystemColors.Control
        Me.txteid.Location = New System.Drawing.Point(111, 40)
        Me.txteid.Name = "txteid"
        Me.txteid.ReadOnly = True
        Me.txteid.Size = New System.Drawing.Size(315, 36)
        Me.txteid.TabIndex = 51
        Me.txteid.ThemeName = "Material"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Event &ID :"
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdclear.Location = New System.Drawing.Point(179, 328)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(84, 36)
        Me.cmdclear.TabIndex = 49
        Me.cmdclear.Text = "Clear"
        Me.cmdclear.ThemeName = "Material"
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.IndianRed
        Me.cmddelete.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.ForeColor = System.Drawing.SystemColors.Control
        Me.cmddelete.Location = New System.Drawing.Point(333, 328)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(96, 36)
        Me.cmddelete.TabIndex = 48
        Me.cmddelete.Text = "Delete"
        Me.cmddelete.ThemeName = "Material"
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdadd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdadd.Location = New System.Drawing.Point(23, 328)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(86, 36)
        Me.cmdadd.TabIndex = 47
        Me.cmdadd.Text = "Save"
        Me.cmdadd.ThemeName = "Material"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "ADD AN EVENT"
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
        'txtet
        '
        Me.txtet.AutoSize = False
        Me.txtet.BackColor = System.Drawing.SystemColors.Control
        Me.txtet.CalendarSize = New System.Drawing.Size(290, 320)
        Me.txtet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtet.Location = New System.Drawing.Point(113, 124)
        Me.txtet.Name = "txtet"
        Me.txtet.Size = New System.Drawing.Size(315, 36)
        Me.txtet.TabIndex = 43
        Me.txtet.TabStop = False
        Me.txtet.Text = "Saturday, June 15, 2019"
        Me.txtet.ThemeName = "Material"
        Me.txtet.Value = New Date(2019, 6, 15, 0, 0, 0, 0)
        '
        'txtst
        '
        Me.txtst.AutoSize = False
        Me.txtst.BackColor = System.Drawing.SystemColors.Control
        Me.txtst.CalendarSize = New System.Drawing.Size(290, 320)
        Me.txtst.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtst.Location = New System.Drawing.Point(113, 82)
        Me.txtst.Name = "txtst"
        Me.txtst.Size = New System.Drawing.Size(315, 37)
        Me.txtst.TabIndex = 42
        Me.txtst.TabStop = False
        Me.txtst.Text = "Saturday, June 15, 2019"
        Me.txtst.ThemeName = "Material"
        Me.txtst.Value = New Date(2019, 6, 15, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Start date :"
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
        Me.Panel3.Size = New System.Drawing.Size(458, 24)
        Me.Panel3.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(435, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "End date :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtcom)
        Me.Panel1.Controls.Add(Me.txteventname)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txteid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmdclear)
        Me.Panel1.Controls.Add(Me.cmddelete)
        Me.Panel1.Controls.Add(Me.cmdadd)
        Me.Panel1.Controls.Add(Me.txtet)
        Me.Panel1.Controls.Add(Me.txtst)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 385)
        Me.Panel1.TabIndex = 1
        '
        'eventsact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 385)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "eventsact"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "events"
        CType(Me.txtcom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txteventname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txteid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdclear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmddelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcom As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txteventname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txteid As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdclear As Telerik.WinControls.UI.RadButton
    Friend WithEvents cmddelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents cmdadd As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtet As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents txtst As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
End Class
