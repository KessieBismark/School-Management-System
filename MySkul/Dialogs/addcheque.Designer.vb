<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addcheque
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Txtrecord = New System.Windows.Forms.TextBox()
        Me.txtcid = New System.Windows.Forms.Label()
        Me.txtcamount = New Telerik.WinControls.UI.RadTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdclear = New Telerik.WinControls.UI.RadButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdadd = New Telerik.WinControls.UI.RadButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.txtcname = New Telerik.WinControls.UI.RadTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtaccount = New Telerik.WinControls.UI.RadTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cdelete = New Telerik.WinControls.UI.RadButton()
        Me.RadDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtctype = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcamount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdclear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdadd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txtcname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtctype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Txtrecord
        '
        Me.Txtrecord.Location = New System.Drawing.Point(386, 46)
        Me.Txtrecord.Name = "Txtrecord"
        Me.Txtrecord.Size = New System.Drawing.Size(107, 20)
        Me.Txtrecord.TabIndex = 59
        Me.Txtrecord.Visible = False
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
        'txtcamount
        '
        Me.txtcamount.AutoSize = False
        Me.txtcamount.BackColor = System.Drawing.SystemColors.Control
        Me.txtcamount.Location = New System.Drawing.Point(108, 168)
        Me.txtcamount.Name = "txtcamount"
        Me.txtcamount.Size = New System.Drawing.Size(383, 36)
        Me.txtcamount.TabIndex = 54
        Me.txtcamount.ThemeName = "Material"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Amount :"
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdclear.Location = New System.Drawing.Point(214, 318)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(120, 36)
        Me.cmdclear.TabIndex = 49
        Me.cmdclear.Text = "Clear"
        Me.cmdclear.ThemeName = "Material"
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
        Me.Label1.Location = New System.Drawing.Point(496, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdadd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdadd.Location = New System.Drawing.Point(37, 318)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(120, 36)
        Me.cmdadd.TabIndex = 47
        Me.cmdadd.Text = "Save"
        Me.cmdadd.ThemeName = "Material"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cheque ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name :"
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
        Me.Panel3.Size = New System.Drawing.Size(519, 24)
        Me.Panel3.TabIndex = 5
        '
        'txtcname
        '
        Me.txtcname.AutoSize = False
        Me.txtcname.BackColor = System.Drawing.SystemColors.Control
        Me.txtcname.Location = New System.Drawing.Point(108, 76)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(383, 36)
        Me.txtcname.TabIndex = 7
        Me.txtcname.ThemeName = "Material"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtaccount)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cdelete)
        Me.Panel1.Controls.Add(Me.RadDateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtctype)
        Me.Panel1.Controls.Add(Me.Txtrecord)
        Me.Panel1.Controls.Add(Me.txtcid)
        Me.Panel1.Controls.Add(Me.txtcamount)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmdclear)
        Me.Panel1.Controls.Add(Me.cmdadd)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtcname)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 378)
        Me.Panel1.TabIndex = 2
        '
        'txtaccount
        '
        Me.txtaccount.AutoSize = False
        Me.txtaccount.BackColor = System.Drawing.SystemColors.Control
        Me.txtaccount.Location = New System.Drawing.Point(108, 122)
        Me.txtaccount.Name = "txtaccount"
        Me.txtaccount.Size = New System.Drawing.Size(383, 36)
        Me.txtaccount.TabIndex = 72
        Me.txtaccount.ThemeName = "Material"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Amount No& :"
        '
        'cdelete
        '
        Me.cdelete.BackColor = System.Drawing.Color.IndianRed
        Me.cdelete.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdelete.ForeColor = System.Drawing.SystemColors.Control
        Me.cdelete.Location = New System.Drawing.Point(391, 318)
        Me.cdelete.Name = "cdelete"
        Me.cdelete.Size = New System.Drawing.Size(98, 36)
        Me.cdelete.TabIndex = 70
        Me.cdelete.Text = "Delete"
        Me.cdelete.ThemeName = "Material"
        '
        'RadDateTimePicker1
        '
        Me.RadDateTimePicker1.BackColor = System.Drawing.SystemColors.Control
        Me.RadDateTimePicker1.CalendarSize = New System.Drawing.Size(290, 320)
        Me.RadDateTimePicker1.Location = New System.Drawing.Point(110, 265)
        Me.RadDateTimePicker1.Name = "RadDateTimePicker1"
        Me.RadDateTimePicker1.Size = New System.Drawing.Size(383, 36)
        Me.RadDateTimePicker1.TabIndex = 63
        Me.RadDateTimePicker1.TabStop = False
        Me.RadDateTimePicker1.Text = "Thursday, May 7, 2020"
        Me.RadDateTimePicker1.ThemeName = "Material"
        Me.RadDateTimePicker1.Value = New Date(2020, 5, 7, 19, 2, 6, 885)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Date on cheque :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Type :"
        '
        'txtctype
        '
        Me.txtctype.AutoSize = False
        Me.txtctype.BackColor = System.Drawing.SystemColors.Control
        Me.txtctype.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Credit"
        RadListDataItem2.Text = "Debit"
        Me.txtctype.Items.Add(RadListDataItem1)
        Me.txtctype.Items.Add(RadListDataItem2)
        Me.txtctype.Location = New System.Drawing.Point(110, 214)
        Me.txtctype.Name = "txtctype"
        Me.txtctype.Size = New System.Drawing.Size(383, 36)
        Me.txtctype.TabIndex = 60
        Me.txtctype.ThemeName = "Material"
        '
        'addcheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 378)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addcheque"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addcheque"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcamount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdclear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdadd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtcname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtaccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtctype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txtrecord As TextBox
    Friend WithEvents txtcid As Label
    Friend WithEvents txtcamount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdclear As Telerik.WinControls.UI.RadButton
    Friend WithEvents cmdadd As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents Label7 As Label
    Friend WithEvents txtctype As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents cdelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtaccount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label9 As Label
End Class
